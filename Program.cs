//
// License: MIT
//
// On Linux (including ARM distributions), you can compile and run this file using either
// Mono or .NET 7/8. On Windows, there is an additional possibility: using the .NET Framework.
// This code has been tested in all these 3 cases. The only dependency is Newtonsoft.Json.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.IO;

namespace HN
{
    class Program
    {
        private const int _totalNum = 90;
        private const int _observedNum = 30;
        private const int _sleepInterval = 60;
        private const int _poolHtmlInterval = 60;
        private const string _filePath = @"README.md";

        private const string _tagStart = "<!-- HN:";
        private const string _tagEnd0 = ":start -->";
        private const string _tagEnd1 = ":end -->";

        private static HttpClient _client = new HttpClient();
        private static Dictionary<int, JObject> _storiesCache = new Dictionary<int, JObject>();
        private static int[] _prevTopStories = null;
        private static Tuple<int, int, int>[] _alreadyAdded = null;
        private static bool _commitPending = false;
        private static string _poolHtml = null;
        private static DateTime _poolHtmlLastTime = DateTime.MinValue;

        private class HNFatalError : Exception
        {
            public HNFatalError(string message, Exception inner) : base(message, inner)
            {
            }
        }

        public static async Task Main(string[] args)
        {
            Console.WriteLine("(HNR) Starting...");

            while (true)
            {
                try
                {
                    if (_alreadyAdded == null)
                        _alreadyAdded = MarkdownGetAll();

                    var topStories = (await Program.GetTopStories()).Take(_totalNum).ToArray();

                    var keysToCache = topStories.Take(_observedNum).Where(i => !_storiesCache.ContainsKey(i)).ToArray();
                    var valuesToCache = await Task.WhenAll(keysToCache.Select(i => GetStory(i)));
                    foreach (var t in keysToCache.Zip(valuesToCache, (first, second) => new Tuple<int, JObject>(first, second)))
                        _storiesCache.Add(t.Item1, t.Item2);

                    if (_prevTopStories != null)
                    {
                        var missing = _prevTopStories.Take(_observedNum).Where(i => !topStories.Contains(i)).Select(i => _storiesCache[i]).ToArray();
                        foreach (var story in missing)
                            await Add(story);
                    }

                    var toDeleteIds = _alreadyAdded.Where(t => topStories.Contains(t.Item1)).Select(t => t.Item1).ToArray();
                    foreach (var storyId in toDeleteIds)
                        MarkdownDelete(storyId);

                    if (_commitPending)
                    {
                        Console.WriteLine(File.ReadAllText(_filePath)); // **IMPORTANT** remove this line if running as a Linux or Windows service.

                        Func<string, bool> git =
                            (string a) =>
                            {
                                var process = new System.Diagnostics.Process();
                                process.StartInfo.FileName = "git";
                                process.StartInfo.Arguments = a;
                                process.Start();
                                process.WaitForExit();
                                return process.ExitCode == 0;
                            };

                        bool res0 = git("commit -a -m \"Update " + DateTime.UtcNow.ToString() + "\"");
                        bool res1 = git("push");

                        if (res0 && res1)
                            _commitPending = false;
                    }

                    _prevTopStories = topStories;
                }
                catch (Exception e)
                {
                    if (e is HNFatalError)
                    {
                        Console.WriteLine(e.ToString());
                        return;
                    }
                    else
                    {
                        _prevTopStories = null;
                        _alreadyAdded = null;
                        _storiesCache.Clear();
                        Console.Write("§");
                    }
                }

                Thread.Sleep(_sleepInterval * 1000);
            }
        }

        private static async Task<T> GetJson<T>(string url)
        {
            var response = await _client.GetAsync(new Uri(url));
            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(result);
        }

        private static async Task<int[]> GetTopStories()
        {
            var jsonData = await GetJson<JArray>("https://hacker-news.firebaseio.com/v0/topstories.json");
            return jsonData.Take(_totalNum).Select(v => v.ToObject<int>()).ToArray();
        }

        private static async Task<JObject> GetStory(int id)
        {
            return await GetJson<JObject>("https://hacker-news.firebaseio.com/v0/item/" + id.ToString() + ".json");
        }

        private static T CannotFail<U, T>(U arg0, Func<U, T> f)
        {
            try
            {
                return f(arg0);
            }
            catch (Exception e)
            {
                if (e is HNFatalError)
                    throw e;
                else
                    throw new HNFatalError(e.Message, e);
            }
        }

        private static Tuple<int, int, int>[] MarkdownGetAll()
        {
            return CannotFail(_filePath,
                path =>
                {
                    string file = File.ReadAllText(path);

                    var ret = new List<Tuple<int, int, int>>();

                    int start = 0;
                    while (true)
                    {
                        int pos = file.IndexOf(_tagStart, start);
                        if (pos < 0)
                            break;

                        int textStart = pos;

                        start = pos + _tagStart.Length;

                        pos = file.IndexOf(_tagEnd0, start);
                        if (pos < 0)
                            throw new Exception("MarkdownGetAll: _tagEnd0 not found.");

                        int storyId = int.Parse(file.Substring(start, pos - start));

                        string storyEndTag = _tagStart + storyId.ToString() + _tagEnd1;
                        pos = file.IndexOf(storyEndTag, start);
                        if (pos < 0)
                            throw new Exception("MarkdownGetAll: storyEndTag not found.");

                        int textEnd = pos + storyEndTag.Length;

                        ret.Add(new Tuple<int, int, int>(storyId, textStart, textEnd));

                        start = textEnd;
                    }

                    if (ret.Select(t => t.Item1).Distinct().Count() != ret.Count())
                        throw new Exception("MarkdownGetAll: return value contains duplicates.");

                    return ret.ToArray();
                });
        }

        private static void MarkdownAdd(int id, string md)
        {
            md =
                _tagStart + id.ToString() + _tagEnd0 +
                Environment.NewLine + "* " + md +
                _tagStart + id.ToString() + _tagEnd1;

            CannotFail(md,
                text =>
                {
                    string file = File.ReadAllText(_filePath).TrimEnd(' ', '\r', '\n');

                    string today = "**" + DateTime.UtcNow.ToLongDateString() + "**";
                    if (file.IndexOf(today) < 0)
                        text = Environment.NewLine + "#### " + today + Environment.NewLine + text;

                    File.WriteAllText(_filePath, file + text);
                    return true;
                });

            _alreadyAdded = MarkdownGetAll();
            _commitPending = true;
        }

        private static void MarkdownDelete(int id_)
        {
            CannotFail(id_,
                id =>
                {
                    string file = File.ReadAllText(_filePath);

                    var toDelete = _alreadyAdded.Where(t => t.Item1 == id).ToArray();
                    if (toDelete.Length != 1)
                        throw new Exception("MarkdownDelete: id not found.");

                    file = file.Substring(0, toDelete[0].Item2) + file.Substring(toDelete[0].Item3);
                    File.WriteAllText(_filePath, file);
                    return true;
                });

            _alreadyAdded = MarkdownGetAll();
            _commitPending = true;
        }

        private static async Task<bool> IsStoryInPoolNoExcept(int id)
        {
            bool ret = false;

            try
            {
                if (_poolHtml == null || DateTime.UtcNow - _poolHtmlLastTime > new TimeSpan(0, 0, _poolHtmlInterval))
                {
                    try
                    {
                        var response = await _client.GetAsync(new Uri("https://news.ycombinator.com/pool"));
                        _poolHtml = await response.Content.ReadAsStringAsync();
                        _poolHtmlLastTime = DateTime.UtcNow;
                    }
                    catch
                    {
                    }
                }

                ret =
                    _poolHtml.IndexOf(id.ToString() + "\"") >= 0 ||
                    _poolHtml.IndexOf(id.ToString() + "'") >= 0;
            }
            catch
            {
            }

            return ret;
        }

        private static async Task Add(JObject story)
        {
            if (story["type"].ToObject<string>() == "story")
            {
                int id = story["id"].ToObject<int>();
                if (_alreadyAdded.Where(t => t.Item1 == id).Count() == 0 && !await IsStoryInPoolNoExcept(id))
                {
                    string title = story["title"].ToObject<string>();
                    string url = story["url"].ToObject<string>();

                    int pos = _prevTopStories.TakeWhile(i => i != id).Count() + 1;

                    string moreData = "";

                    try
                    {
                        var updated = await GetStory(id);

                        int comments = updated["descendants"].ToObject<int>();
                        int points = updated["score"].ToObject<int>();

                        moreData = points.ToString() + " points " + comments.ToString() + " comments ";
                    }
                    catch
                    {
                    }

                    Func<string, string> sanitize =
                        (string s) =>
                        {
                            return string.Concat(s.ToCharArray().Select(
                                c =>
                                {
                                    string t = c.ToString();
                                    if (t == "<")
                                        t = "&lt;";
                                    else if (t == ">")
                                        t = "&gt;";
                                    return t;
                                }).ToArray());
                        };

                    MarkdownAdd(id,
                        "[" + id.ToString() + "](https://news.social-protocols.org/stats?id=" + id.ToString() + ") #" + pos.ToString() + " " +
                        moreData + "-> [" + sanitize(title) + "](" + sanitize(url) + ")");
                }
            }
        }
    }
}
