**UPDATE** (February 4, 2024): This is the discussion about this project on HN: [here](https://news.ycombinator.com/item?id=39230513). Please specifically read @dang's comment regarding the core assumption of this project: [here](https://news.ycombinator.com/item?id=39231537). On a personal note, the number of Stories removed yesterday (Saturday, February 3, 2024) was the lowest ever recorded by the service. This includes 2 duplicate Stories. As a side note, **in the list always check whether a Story is a duplicate or not**: this is a very reasonable reason for removal and unfortunately I have no way of automatically determining it in the service!

# Introduction

The purpose of this project is to try to understand the type and scale of the moderation of the Hacker News Front Page.

**NOTE**: I love Hacker News. I try to read it every day. In the case of OnnxStream ([here](https://news.ycombinator.com/item?id=37752632) for example), 95% of the comments were helpful and intelligent. I also understand that moderating a site with huge traffic and where users are basically anonymous must be a very difficult task.

Returning to the purpose of this project, from what I have been able to see, the "public" (i.e. observable from the outside) moderation of the Front Page consists of two main tools: modification of the title of a Story (voluntarily or involuntarily influencing its growth in terms of rank) or directly its removal.

Regarding the first type of moderation, an excellent [site](https://hackernewstitles.netlify.app/) is already available that tracks changes to Story titles. Here instead I will focus on the second type.

For the reasons explained in the "Why?" section below, I have developed a small application that logs all the Stories that are removed from the Front Page, for personal use. I later discovered that there is no tool/website that provides this type of information and I decided to make it public here. It was a difficult decision but my rationale is: is it better to have more transparency or less transparency?

If you know of a tool/website similar to this, please let me know: I will archive this repo or set it to private.

A possible very positive outcome for this project could be to have a list similar to this, but available directly among the [HN lists](https://news.ycombinator.com/lists). Or even to notify a user when a Story is penalized on the Front Page, perhaps indicating the number of flags and/or the reason, for example.

# Why?

<details>
<summary>Feel free to skip this part or click to expand</summary>

A friend of mine posted two Stories on Hacker News related to OnnxStream (31 days apart), the first related to SDXL Turbo support and the second related to TinyLlama and Mistral 7B support.

In the case of the [first](https://news.ycombinator.com/item?id=38646969), the Story was among the first on the Front Page, until its title was changed from "Stable Diffusion Turbo on a Raspberry Pi Zero 2 generates an image in 29 minutes" to "OnnxStream: Stable Diffusion XL 1.0 Base on a Raspberry Pi Zero 2". This effectively "killed" the Story. One user pointed out that the new title didn't reflect the spirit of the Story (thanks @practice9).

In the case of the [second](https://news.ycombinator.com/item?id=38991145), the Story was in third place on the Front Page, less than an hour after the submission. In this case it was simply removed from the Front Page.

Having discovered this, perplexed, I sent an email to the moderator. @dang, who was very kind and quick in his response, explained to me that the Story had been flagged by users even without being explicitly [flagged], and that he could therefore only hypothesize the causes of the flag. His hypothesis was that (some?) users might be fed up with news related to LLMs.

While I have no reason to doubt Daniel's good faith, it's hard to believe that HN users would be tired of LLM-related news.

So I decided to develop a small console application to determine the frequency of this phenomenon (actually I was also motivated by the prospect of writing some C# code, after more than 2 years of complete abstinence). I subsequently discovered that there were no tools/websites that monitored this specific phenomenon and I therefore decided to make it public here.

</details>

# How it works

Using the [official HN API](https://github.com/HackerNews/API), the service fetches 90 Top Stories every minute and makes a comparison with the first 30 Top Stories (i.e. the Front Page) fetched the previous minute. It logs all missing Stories here. The assumption is that a Story cannot go from the top 30 to a position greater than 90 in a single minute, without having been explicitly removed. If a Story reappears on the Front Page, it is removed from this log. All Stories present in the [second-chance pool](https://news.ycombinator.com/pool) are excluded from the log. Title and URL are those from when the Story first appeared in the top 30. The number of points and comments and the rank are those from when the Story was removed from the Front Page. The ID points to the [news.social-protocols.org](https://news.social-protocols.org) page for that Story, which provides a graph of the Story's position on the Front Page over time.

# The list (updated in real time, max delay: 1 minute)

**NOTE**: always check whether a Story is a duplicate or not: this is a very reasonable reason for removal and unfortunately I have no way of automatically determining it in the service!

#### **Friday, July 17, 2026**
<!-- HN:48941051:start -->
* [48941051](https://news.social-protocols.org/stats?id=48941051) #25 6 points 8 comments -> [Show HN: ReasonGate- An explainable gate that blocks LLM prompt injection](https://github.com/cgrtml/reasongate)<!-- HN:48941051:end --><!-- HN:48942250:start -->
* [48942250](https://news.social-protocols.org/stats?id=48942250) #9 43 points 24 comments -> [Google Kills Custom Search API on Jan 1, 2027](https://thenextgennexus.com/2026/05/14/google-kills-custom-search-api-on-jan-1-2027-you-have-9-months/)<!-- HN:48942250:end --><!-- HN:48951147:start -->
* [48951147](https://news.social-protocols.org/stats?id=48951147) #6 -> [Why the People Who Could Fix It Are the First to Leave](https://www.hackingleadership.com/p/why-the-people-who-could-fix-it-are-the-first-to-leave)<!-- HN:48951147:end --><!-- HN:48951014:start -->
* [48951014](https://news.social-protocols.org/stats?id=48951014) #12 50 points 14 comments -> [ICE Flight Monitor Interactive Dashboard](https://www.humanrightsfirst.org/ice-flight-monitor-interactive-dashboard)<!-- HN:48951014:end --><!-- HN:48952450:start -->
* [48952450](https://news.social-protocols.org/stats?id=48952450) #8 8 points 2 comments -> [I built a digital F1 garage to learn how Formula 1 cars work](https://paddockpass.app)<!-- HN:48952450:end --><!-- HN:48924855:start -->
* [48924855](https://news.social-protocols.org/stats?id=48924855) #14 7 points 2 comments -> [Show HN: Tarit – a hypervisor which is 2x faster than firecracker](https://github.com/instavm/tarit)<!-- HN:48924855:end -->
#### **Saturday, July 18, 2026**
<!-- HN:48953830:start -->
* [48953830](https://news.social-protocols.org/stats?id=48953830) #16 5 points 0 comments -> [Native C# CEL Implementation](https://www.nuget.org/packages/Celly)<!-- HN:48953830:end --><!-- HN:48954267:start -->
* [48954267](https://news.social-protocols.org/stats?id=48954267) #4 8 points 0 comments -> [Algorithm for NP-Complete Sudoku](https://zenodo.org/records/21420871)<!-- HN:48954267:end --><!-- HN:48955740:start -->
* [48955740](https://news.social-protocols.org/stats?id=48955740) #29 10 points 1 comments -> [Show HN: Find someone in the dark – light them or light yourself? (Three.js)](https://github.com/skorotkiewicz/signal-in-the-dark)<!-- HN:48955740:end --><!-- HN:48903490:start -->
* [48903490](https://news.social-protocols.org/stats?id=48903490) #13 8 points 1 comments -> [Responsive Design Calculator](https://www.redblobgames.com/blog/2026-07-11-responsive-design-calculator/)<!-- HN:48903490:end --><!-- HN:48959314:start -->
* [48959314](https://news.social-protocols.org/stats?id=48959314) #6 13 points 0 comments -> [Frozen 2 should be Rated R](https://interconnected.org/home/2026/07/17/frozen)<!-- HN:48959314:end --><!-- HN:48959473:start -->
* [48959473](https://news.social-protocols.org/stats?id=48959473) #18 35 points 40 comments -> [Young adults are poor despite every metric which suggests otherwise](https://xcancel.com/i/article/2077113148524417439)<!-- HN:48959473:end --><!-- HN:48959575:start -->
* [48959575](https://news.social-protocols.org/stats?id=48959575) #27 29 points 26 comments -> [Heresy](https://paulgraham.com/heresy.html)<!-- HN:48959575:end --><!-- HN:48960416:start -->
* [48960416](https://news.social-protocols.org/stats?id=48960416) #24 11 points 4 comments -> [In Germany if you say a restaurant is just ok they send the gestapo after you](https://twitter.com/eigen_moomin/status/2077471686295957749)<!-- HN:48960416:end --><!-- HN:48960551:start -->
* [48960551](https://news.social-protocols.org/stats?id=48960551) #14 28 points 40 comments -> [Show HN: Get alerts for good seats at 70mm IMAX showings of The Odyssey](https://imaxxing.io/)<!-- HN:48960551:end --><!-- HN:48959102:start -->
* [48959102](https://news.social-protocols.org/stats?id=48959102) #28 30 points 40 comments -> [The Fermi Paradox, Percolation, and Inbreeding](https://reactormag.com/the-fermi-paradox-percolation-and-inbreeding/)<!-- HN:48959102:end --><!-- HN:48962963:start -->
* [48962963](https://news.social-protocols.org/stats?id=48962963) #10 9 points 1 comments -> [AI Mania Is Eviscerating Global Decision-Making](https://hermit-tech.com/blog/ai-mania-is-eviscerating-global-decisionmaking)<!-- HN:48962963:end --><!-- HN:48904912:start -->
* [48904912](https://news.social-protocols.org/stats?id=48904912) #29 32 points 6 comments -> [Show HN: Rejourney – Open-source revenue leak prediction for web and mobile apps](https://github.com/rejourneyco/rejourney)<!-- HN:48904912:end --><!-- HN:48962405:start -->
* [48962405](https://news.social-protocols.org/stats?id=48962405) #27 4 points 2 comments -> [Ada: An AI business intelligence software from CSV and Excel(yes LLMs but more)](https://github.com/saineshnakra/automated-data-analyst)<!-- HN:48962405:end -->
#### **Sunday, July 19, 2026**
<!-- HN:48963642:start -->
* [48963642](https://news.social-protocols.org/stats?id=48963642) #22 13 points 3 comments -> [AI Bubble vs. Dot Com Crash. History Is Repeating](https://www.youtube.com/watch?v=zWJ-g5u9Rqs)<!-- HN:48963642:end --><!-- HN:48965983:start -->
* [48965983](https://news.social-protocols.org/stats?id=48965983) #30 9 points 4 comments -> [Show HN: OfflineTTS — Free browser-based TTS & STT that runs locally](https://offlinetts.com/)<!-- HN:48965983:end --><!-- HN:48882993:start -->
* [48882993](https://news.social-protocols.org/stats?id=48882993) #9 6 points 2 comments -> [I Put My Son in a Swamp](https://thepotato.tech/posts/i-put-my-son-in-a-swamp/)<!-- HN:48882993:end --><!-- HN:48966754:start -->
* [48966754](https://news.social-protocols.org/stats?id=48966754) #17 25 points 2 comments -> [Qwen 3.8 Max](https://qwen.ai/home)<!-- HN:48966754:end --><!-- HN:48966665:start -->
* [48966665](https://news.social-protocols.org/stats?id=48966665) #16 6 points 7 comments -> [Save GPT-5.5](https://save-gpt-5-5.fyi/)<!-- HN:48966665:end --><!-- HN:48966190:start -->
* [48966190](https://news.social-protocols.org/stats?id=48966190) #1 211 points 96 comments -> [Qwen 3.8 Max Preview](https://www.qwencloud.com/pricing/token-plan)<!-- HN:48966190:end --><!-- HN:48966939:start -->
* [48966939](https://news.social-protocols.org/stats?id=48966939) #23 9 points 0 comments -> [Show HN: Akashic – A self-hosted intelligence workspace inspired by Palantir](https://github.com/CaviraOSS/Akashic)<!-- HN:48966939:end --><!-- HN:48930892:start -->
* [48930892](https://news.social-protocols.org/stats?id=48930892) #13 7 points 3 comments -> [Holding the LLM Stack in Your Head](https://thegustafson.com/series)<!-- HN:48930892:end --><!-- HN:48970684:start -->
* [48970684](https://news.social-protocols.org/stats?id=48970684) #10 11 points 8 comments -> [Show HN: How much profit does your employer make per employee?](https://yourfairshare.info)<!-- HN:48970684:end --><!-- HN:48972197:start -->
* [48972197](https://news.social-protocols.org/stats?id=48972197) #11 3 points 0 comments -> [Principia Artificialis – Mathematical Foundations of Artificial Thought](https://github.com/holland202/Principia-Artificialis)<!-- HN:48972197:end --><!-- HN:48971999:start -->
* [48971999](https://news.social-protocols.org/stats?id=48971999) #9 10 points 0 comments -> [Grok-iOS – remote Grok Build from your iPhone over ACP](https://github.com/Pedroshakoor/grok-build-ios)<!-- HN:48971999:end --><!-- HN:48972524:start -->
* [48972524](https://news.social-protocols.org/stats?id=48972524) #4 11 points 3 comments -> [Spain beats Argentina to win the World Cup](https://english.elpais.com/sports/2026-07-19/spain-beat-argentina-to-win-the-world-cup.html)<!-- HN:48972524:end -->
#### **Monday, July 20, 2026**
<!-- HN:48972928:start -->
* [48972928](https://news.social-protocols.org/stats?id=48972928) #17 28 points 13 comments -> [CO2 overload in blood suggests toxic atmosphere within 50 years](https://doi.org/10.1007/s11869-026-01918-5)<!-- HN:48972928:end --><!-- HN:48904070:start -->
* [48904070](https://news.social-protocols.org/stats?id=48904070) #15 5 points 1 comments -> [Native SDK from Vercel](https://native-sdk.dev/)<!-- HN:48904070:end --><!-- HN:48974426:start -->
* [48974426](https://news.social-protocols.org/stats?id=48974426) #21 32 points 12 comments -> [Big Tech Needs to Justify AI Spending as Investors Dump Stocks](https://www.bloomberg.com/news/articles/2026-07-19/big-tech-needs-to-justify-ai-spending-as-investors-dump-stocks)<!-- HN:48974426:end --><!-- HN:48919485:start -->
* [48919485](https://news.social-protocols.org/stats?id=48919485) #17 4 points 0 comments -> [I beat mem0 on long eval memory and could not care less](https://octopodas.com/)<!-- HN:48919485:end --><!-- HN:48977270:start -->
* [48977270](https://news.social-protocols.org/stats?id=48977270) #8 23 points 43 comments -> [Why is it so hard for the U.S. to win wars?](https://www.npr.org/2026/07/18/g-s1-134037/why-is-it-so-hard-for-the-u-s-to-win-wars)<!-- HN:48977270:end --><!-- HN:48978454:start -->
* [48978454](https://news.social-protocols.org/stats?id=48978454) #7 3 points 1 comments -> [Simple Invoices. Faster Payments](https://duely-44998.bubbleapps.io/)<!-- HN:48978454:end --><!-- HN:48979201:start -->
* [48979201](https://news.social-protocols.org/stats?id=48979201) #13 14 points 1 comments -> [Lossless model compression experiment: GLM-5.2 in 25% less memory](https://brianbell-x.github.io/weight-compression/)<!-- HN:48979201:end --><!-- HN:48979825:start -->
* [48979825](https://news.social-protocols.org/stats?id=48979825) #21 28 points 6 comments -> [I Tracked 997 Chrome Extensions That Changed Their Titles](https://extensionranker.com/blog/chrome-extension-title-changes-rankings)<!-- HN:48979825:end --><!-- HN:48980375:start -->
* [48980375](https://news.social-protocols.org/stats?id=48980375) #23 13 points 3 comments -> [SaaS *is* dead. But not because AI "killed" it, because AI killed it](https://avivcarmi.com/saas-is-dead/)<!-- HN:48980375:end --><!-- HN:48910259:start -->
* [48910259](https://news.social-protocols.org/stats?id=48910259) #23 8 points 2 comments -> [Another Entry in the "Stuff Im Glad Im Not Responsible for" Ledger](https://blog.cloudflare.com/dnssec-nta-ede-33/)<!-- HN:48910259:end --><!-- HN:48936658:start -->
* [48936658](https://news.social-protocols.org/stats?id=48936658) #21 12 points 3 comments -> [What I Learned from Reimplementing 40 Multi-Agent LLM Papers](https://medium.com/@Koukyosyumei/what-i-learned-from-reimplementing-40-multi-agent-llm-papers-bd6b574f5659)<!-- HN:48936658:end -->
#### **Tuesday, July 21, 2026**
<!-- HN:48901918:start -->
* [48901918](https://news.social-protocols.org/stats?id=48901918) #21 16 points 3 comments -> [Rendering Fonts Quickly on the GPU](https://www.outercloud.dev/blogs/webgpu-font-rendering/)<!-- HN:48901918:end --><!-- HN:48986912:start -->
* [48986912](https://news.social-protocols.org/stats?id=48986912) #13 4 points 2 comments -> [Show HN: I made email signatures less boring](https://esigna.app)<!-- HN:48986912:end --><!-- HN:48987618:start -->
* [48987618](https://news.social-protocols.org/stats?id=48987618) #7 6 points 0 comments -> [Show HN: Turn casual photos into professional headshots with AI](https://portraify.app)<!-- HN:48987618:end --><!-- HN:48987958:start -->
* [48987958](https://news.social-protocols.org/stats?id=48987958) #19 3 points 0 comments -> [Bash for Browser Front End](https://alganet.github.io/terminal/?p=post:2026-07-21-00-Bash-for-Browser-Frontend&lang=en)<!-- HN:48987958:end --><!-- HN:48988265:start -->
* [48988265](https://news.social-protocols.org/stats?id=48988265) #20 25 points 18 comments -> [Reverse-engineering is cheap now](https://simonwillison.net/2026/Jul/20/cheap-reverse-engineering/)<!-- HN:48988265:end --><!-- HN:48988189:start -->
* [48988189](https://news.social-protocols.org/stats?id=48988189) #15 12 points 9 comments -> [Zoom is now Chrome only](https://zoom.us/test)<!-- HN:48988189:end --><!-- HN:48937703:start -->
* [48937703](https://news.social-protocols.org/stats?id=48937703) #23 11 points 4 comments -> [Flight Planning with Little Navmap](https://tech.marksblogg.com/little-navmap-flight-planning.html)<!-- HN:48937703:end --><!-- HN:48968474:start -->
* [48968474](https://news.social-protocols.org/stats?id=48968474) #12 17 points 40 comments -> [Postmortem of a British Startup: Tract](https://buildwithtract.com/)<!-- HN:48968474:end --><!-- HN:48992028:start -->
* [48992028](https://news.social-protocols.org/stats?id=48992028) #6 4 points 1 comments -> [Garzed – my garden waters itself off soil-moisture sensors](https://garzed.com)<!-- HN:48992028:end --><!-- HN:48992039:start -->
* [48992039](https://news.social-protocols.org/stats?id=48992039) #27 19 points 3 comments -> [Mullvad and Daniel Berntsson's Failed Cleanup](https://markwrites.io/mullvad-and-daniel-berntssons-failed-cleanup/)<!-- HN:48992039:end --><!-- HN:48992960:start -->
* [48992960](https://news.social-protocols.org/stats?id=48992960) #12 20 points 11 comments -> [Sarah's Wager](https://colossus.com/article/sarah-guo-conviction/)<!-- HN:48992960:end --><!-- HN:48993448:start -->
* [48993448](https://news.social-protocols.org/stats?id=48993448) #9 174 points 86 comments -> [ICE to Pay Thomson Reuters $125M to Find Voter Fraud](https://www.404media.co/ice-to-pay-thomson-reuters-125-million-to-find-voter-fraud/)<!-- HN:48993448:end --><!-- HN:48994103:start -->
* [48994103](https://news.social-protocols.org/stats?id=48994103) #20 29 points 41 comments -> [Amid nurse shortage, a university rolls out the welcome mat for men](https://text.npr.org/nx-s1-5869813)<!-- HN:48994103:end --><!-- HN:48995333:start -->
* [48995333](https://news.social-protocols.org/stats?id=48995333) #25 11 points 3 comments -> [Show HN: I built a command palette for the terminal – 6.2MB, pure Go, no fzf](https://github.com/matheuzgomes/decoreba)<!-- HN:48995333:end --><!-- HN:48995946:start -->
* [48995946](https://news.social-protocols.org/stats?id=48995946) #30 24 points 10 comments -> [How did the H1B visa become the 'Indian' visa](https://numberstation.fm/the-body-shop/)<!-- HN:48995946:end -->
#### **Wednesday, July 22, 2026**
<!-- HN:48999376:start -->
* [48999376](https://news.social-protocols.org/stats?id=48999376) #9 27 points 4 comments -> [An Engineer's Guide to USB Type-C [pdf]](https://www.ti.com/lit/eb/slyy228/slyy228.pdf)<!-- HN:48999376:end --><!-- HN:49002010:start -->
* [49002010](https://news.social-protocols.org/stats?id=49002010) #19 6 points 2 comments -> [Airglow browser lets users modify YouTube, Gmail and Spotify in real time](https://runtimewire.com/article/airglow-browser-lets-users-modify-youtube-gmail-and-spotify-in-real-time)<!-- HN:49002010:end --><!-- HN:49001775:start -->
* [49001775](https://news.social-protocols.org/stats?id=49001775) #19 17 points 3 comments -> [Ten ways a check passes while the thing it checks is broken](https://phronesis.world/papers/ways-of-checking/)<!-- HN:49001775:end --><!-- HN:49001930:start -->
* [49001930](https://news.social-protocols.org/stats?id=49001930) #3 61 points 6 comments -> [Kimi K3: second only to Fable 5 on AA-Briefcase](https://artificialanalysis.ai/articles/kimi-k3-agentic-knowledge-benchmark)<!-- HN:49001930:end --><!-- HN:49001708:start -->
* [49001708](https://news.social-protocols.org/stats?id=49001708) #29 18 points 40 comments -> [Tesla Balance Bike](https://shop.tesla.com/product/balance-bike-for-kids)<!-- HN:49001708:end --><!-- HN:49003465:start -->
* [49003465](https://news.social-protocols.org/stats?id=49003465) #13 38 points 40 comments -> [Codeberg: ToU extension to prohibit LLM-extrusions](https://codeberg.org/Codeberg/org/pulls/1253)<!-- HN:49003465:end --><!-- HN:49004914:start -->
* [49004914](https://news.social-protocols.org/stats?id=49004914) #13 5 points 0 comments -> [OpenAI Hacks Hugging Face, What Happened, Alignment and Paper Clips](https://stratechery.com/2026/openai-hacks-hugging-face-what-happened-alignment-and-paper-clips/)<!-- HN:49004914:end --><!-- HN:49005398:start -->
* [49005398](https://news.social-protocols.org/stats?id=49005398) #30 69 points 80 comments -> [OpenAI says its AI went rogue and launched 'unprecedented' cyber-attack](https://www.bbc.com/news/articles/c3ek3gvdnj3o)<!-- HN:49005398:end --><!-- HN:49008217:start -->
* [49008217](https://news.social-protocols.org/stats?id=49008217) #10 10 points 2 comments -> [I Am Buiding BorgIOS to de-shitify the Internet](https://github.com/bitmonky/BorgIOS)<!-- HN:49008217:end --><!-- HN:49007487:start -->
* [49007487](https://news.social-protocols.org/stats?id=49007487) #28 44 points 26 comments -> [How to Read a Painting](https://sheets.works/data-viz/how-to-read-a-painting/)<!-- HN:49007487:end --><!-- HN:48933232:start -->
* [48933232](https://news.social-protocols.org/stats?id=48933232) #11 36 points 7 comments -> [Drake Anthony Recreates the Mechanical Bulb First Seen in 1675 – TechEBlog](https://www.techeblog.com/drake-anthony-styropyro-mechanical-bulb-barometric-light/)<!-- HN:48933232:end -->