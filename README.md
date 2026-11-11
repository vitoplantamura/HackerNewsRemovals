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

#### **Thursday, November 5, 2026**
<!-- HN:50375728:start -->
* [50375728](https://news.social-protocols.org/stats?id=50375728) #3 60 points 11 comments -> [Want to Rent an Internet Address at the White House?](https://krebsonsecurity.com/2026/11/want-to-rent-an-internet-address-at-the-white-house/)<!-- HN:50375728:end --><!-- HN:50337586:start -->
* [50337586](https://news.social-protocols.org/stats?id=50337586) #13 14 points 4 comments -> [An intuition for how neural nets can understand text](https://info.zairai.ai/neurons-understanding-text)<!-- HN:50337586:end --><!-- HN:50385091:start -->
* [50385091](https://news.social-protocols.org/stats?id=50385091) #17 6 points 0 comments -> [How "Safety" Rhetoric Is Weaponized to Protect Israel and Smear Its Critics](https://www.columnblog.com/p/how-safety-rhetoric-is-weaponized)<!-- HN:50385091:end --><!-- HN:50385764:start -->
* [50385764](https://news.social-protocols.org/stats?id=50385764) #24 -> [Thursday's $3T tech sell-off, and what it means if you build AI products](https://vithushansylvester.com/writing/the-3-trillion-thursday)<!-- HN:50385764:end -->
#### **Friday, November 6, 2026**
<!-- HN:50383963:start -->
* [50383963](https://news.social-protocols.org/stats?id=50383963) #9 94 points 3 comments -> [Tencent Launches Hy4, One of the Leading Open-Source AI Models](https://www.tencent.com/tencent-launches-hy4-joining-the-ranks-of-the-worlds-leading-open-source-ai-models/)<!-- HN:50383963:end --><!-- HN:50387623:start -->
* [50387623](https://news.social-protocols.org/stats?id=50387623) #12 11 points 2 comments -> [Claude was faster and cheaper. We took the scenic route anyway](https://blog.grainulation.org/verify-then-vote/)<!-- HN:50387623:end --><!-- HN:50379704:start -->
* [50379704](https://news.social-protocols.org/stats?id=50379704) #6 613 points 2 comments -> [Alpine Linux Security Advisory: OpenSSH-server password authentication bypass](https://alpinelinux.org/posts/2026-11-05-openssh-password-authentication-bypass/)<!-- HN:50379704:end --><!-- HN:50377976:start -->
* [50377976](https://news.social-protocols.org/stats?id=50377976) #25 247 points 5 comments -> [OpenSSH 10.6p2 Critical workaround for alpine without PAM](https://www.openssh.org/releasenotes.html#10.6p2)<!-- HN:50377976:end --><!-- HN:50377221:start -->
* [50377221](https://news.social-protocols.org/stats?id=50377221) #24 176 points 220 comments -> [OpenSSH 10.6p2 has been released with a workaround for a critical vulnerability](https://hachyderm.io/@damienmiller/117563026759098135)<!-- HN:50377221:end --><!-- HN:50387406:start -->
* [50387406](https://news.social-protocols.org/stats?id=50387406) #19 66 points 31 comments -> [Tesla and SpaceX lose over $420B in combined market cap in the two days](https://www.cnbc.com/2026/11/05/tesla-spacex-stocks-fall-after-2026-midterms.html)<!-- HN:50387406:end --><!-- HN:50388263:start -->
* [50388263](https://news.social-protocols.org/stats?id=50388263) #8 31 points 41 comments -> [How accurately did science fiction stories predict AI?](https://jamesyu.org/science-fiction-predictions-of-ai/)<!-- HN:50388263:end --><!-- HN:50389446:start -->
* [50389446](https://news.social-protocols.org/stats?id=50389446) #24 4 points 0 comments -> [Does the Neuroslop Enrichment Real?](https://github.com/notlibrary/USSR)<!-- HN:50389446:end --><!-- HN:50392176:start -->
* [50392176](https://news.social-protocols.org/stats?id=50392176) #22 9 points 2 comments -> [Can Democrats effectively abolish Electoral College after midterm wins?](https://www.snopes.com/news/2026/11/05/democrats-abolish-electoral-college/)<!-- HN:50392176:end --><!-- HN:50394288:start -->
* [50394288](https://news.social-protocols.org/stats?id=50394288) #12 10 points 2 comments -> [Promethevs: Full DeepSeek-v4.1-Flash-1017, locally, on 12GB of VRAM](https://github.com/Magnvs7/Promethevs)<!-- HN:50394288:end --><!-- HN:50393183:start -->
* [50393183](https://news.social-protocols.org/stats?id=50393183) #1 89 points 1 comments -> [FAA Begins Retiring Decades Old Floppy Disks from Air Traffic Control](https://www.faa.gov/newsroom/trumps-transportation-secretary-sean-p-duffy-begins-retiring-decades-old-floppy-disks-air)<!-- HN:50393183:end --><!-- HN:50393154:start -->
* [50393154](https://news.social-protocols.org/stats?id=50393154) #2 296 points 413 comments -> [RIP Cybertruck. You Were Unloved, Unwanted, and Utterly Absurd](https://www.wired.com/story/rip-cybertruck-you-were-unloved-unwanted-and-utterly-absurd/)<!-- HN:50393154:end --><!-- HN:50395318:start -->
* [50395318](https://news.social-protocols.org/stats?id=50395318) #25 90 points 1 comments -> [Anthropic IPO Valuation Talks Drop to $1.3T as Major Investors Balk](https://epyhia.com/anthropic-ipo-valuation-talks-drop-to-1-3-trillion-as-major-investors)<!-- HN:50395318:end --><!-- HN:50399400:start -->
* [50399400](https://news.social-protocols.org/stats?id=50399400) #12 15 points 1 comments -> [*sshole, or when are we going to get rid of C?](https://sunshowers.io/posts/sshole/)<!-- HN:50399400:end -->
#### **Saturday, November 7, 2026**
<!-- HN:50399859:start -->
* [50399859](https://news.social-protocols.org/stats?id=50399859) #17 19 points 8 comments -> [No CVE Today, Please](https://nocveday.com/)<!-- HN:50399859:end --><!-- HN:50401255:start -->
* [50401255](https://news.social-protocols.org/stats?id=50401255) #24 -> [The Military Triumphal Arch](https://triumphalarch.com/)<!-- HN:50401255:end --><!-- HN:50401409:start -->
* [50401409](https://news.social-protocols.org/stats?id=50401409) #9 9 points 2 comments -> [Show HN: Backwords – Let AI teach you how to speak in reverse](https://backwords.greg.technology/)<!-- HN:50401409:end --><!-- HN:50402369:start -->
* [50402369](https://news.social-protocols.org/stats?id=50402369) #9 4 points 4 comments -> [Arete-27B: Qwen3.8-27B, post-trained to reinforce Western values](https://nousresearch.com/arete)<!-- HN:50402369:end --><!-- HN:50404622:start -->
* [50404622](https://news.social-protocols.org/stats?id=50404622) #2 8 points 1 comments -> [I don't care if web content is AI-generated](https://kevinboone.me/ai.html)<!-- HN:50404622:end --><!-- HN:50405484:start -->
* [50405484](https://news.social-protocols.org/stats?id=50405484) #6 5 points 4 comments -> [Let's Encrypt AI: protect AI chats with on AI GPUs by the end of 2027](https://letsencrypt.ai/)<!-- HN:50405484:end --><!-- HN:50405649:start -->
* [50405649](https://news.social-protocols.org/stats?id=50405649) #3 8 points 0 comments -> [Google Described Its Agent Sandbox. I Built One with Firecracker and Measured It](https://antonau.tech/posts/2026/11/agents-microvm-firecracker/)<!-- HN:50405649:end --><!-- HN:50406589:start -->
* [50406589](https://news.social-protocols.org/stats?id=50406589) #2 80 points 1 comments -> [The End of AI Frontiers](https://hunch.net/?p=13764006)<!-- HN:50406589:end -->
#### **Sunday, November 8, 2026**
<!-- HN:50411767:start -->
* [50411767](https://news.social-protocols.org/stats?id=50411767) #8 13 points 1 comments -> [a](http://a.com)<!-- HN:50411767:end --><!-- HN:50408729:start -->
* [50408729](https://news.social-protocols.org/stats?id=50408729) #8 5 points 1 comments -> [JIT bitmap text rendering for microcontrollers](https://linebender.org/blog/jit-bitmap-text/)<!-- HN:50408729:end --><!-- HN:50414155:start -->
* [50414155](https://news.social-protocols.org/stats?id=50414155) #9 5 points 3 comments -> [Scrine – Joyscroll books. Read any book one sentence at a time](https://scrine.io/)<!-- HN:50414155:end --><!-- HN:50414839:start -->
* [50414839](https://news.social-protocols.org/stats?id=50414839) #1 -> ["RAM Altman"= Linux script emailing Altman daily on how much RAM left on your PC](https://respawnfirst.com/linux-script-emails-sam-altman-unused-ram-ram-altman/)<!-- HN:50414839:end --><!-- HN:50372396:start -->
* [50372396](https://news.social-protocols.org/stats?id=50372396) #18 3 points 1 comments -> [Everything should be a random number generator](https://en.cppreference.com/cpp/numeric/random)<!-- HN:50372396:end --><!-- HN:50415078:start -->
* [50415078](https://news.social-protocols.org/stats?id=50415078) #28 43 points 12 comments -> [Show HN: FuckCaptcha – a field guide to 39 CAPTCHA types and how they break](https://github.com/vsmutok/FuckCaptcha)<!-- HN:50415078:end -->
#### **Monday, November 9, 2026**
<!-- HN:50360369:start -->
* [50360369](https://news.social-protocols.org/stats?id=50360369) #22 15 points 2 comments -> [Taco: The Tensor Algebra Compiler](http://tensor-compiler.org/)<!-- HN:50360369:end --><!-- HN:50353814:start -->
* [50353814](https://news.social-protocols.org/stats?id=50353814) #24 59 points 23 comments -> [The History of Djgpp](https://www.delorie.com/djgpp/history.html)<!-- HN:50353814:end --><!-- HN:50420983:start -->
* [50420983](https://news.social-protocols.org/stats?id=50420983) #20 4 points 1 comments -> [I Resist Generative "AI"](https://estherweidauer.com/articles/why-resist-generative-ai.html)<!-- HN:50420983:end --><!-- HN:50422001:start -->
* [50422001](https://news.social-protocols.org/stats?id=50422001) #1 28 points 8 comments -> [Being a meat proxy for AI should be grounds for getting people fired](https://swiftrocks.com/being-a-meat-proxy-for-ai-should-be-grounds-for-getting-people-fired)<!-- HN:50422001:end --><!-- HN:50402428:start -->
* [50402428](https://news.social-protocols.org/stats?id=50402428) #23 13 points 1 comments -> [SultanC – an Arabic-first systems programming language](https://github.com/sultan-language/sultanc)<!-- HN:50402428:end --><!-- HN:50421899:start -->
* [50421899](https://news.social-protocols.org/stats?id=50421899) #21 9 points 2 comments -> [WindyMaps – Free offline maps, 1h/1km weather and route trip planner](https://windymapy.com)<!-- HN:50421899:end --><!-- HN:50422181:start -->
* [50422181](https://news.social-protocols.org/stats?id=50422181) #13 32 points 40 comments -> [370 Books in 20 months: South African author defends her use of AI](https://www.enca.com/lifestyle/370-books-20-months-sa-author-defends-her-use-ai)<!-- HN:50422181:end --><!-- HN:50429477:start -->
* [50429477](https://news.social-protocols.org/stats?id=50429477) #21 -> [Nuance Labs](https://app.nuancelabs.ai/try)<!-- HN:50429477:end --><!-- HN:50429652:start -->
* [50429652](https://news.social-protocols.org/stats?id=50429652) #16 9 points 0 comments -> [I Am Done Using Your UI](https://killianc.com/i-am-done-using-your-ui/)<!-- HN:50429652:end -->
#### **Tuesday, November 10, 2026**
<!-- HN:50431811:start -->
* [50431811](https://news.social-protocols.org/stats?id=50431811) #30 -> [Show HN: Rat Race (After Dark, 1994), ported from 68k assembly to TypeScript](https://rat-race.heyitsjam.es/)<!-- HN:50431811:end --><!-- HN:50433669:start -->
* [50433669](https://news.social-protocols.org/stats?id=50433669) #29 6 points 1 comments -> [AI Bubble Tracker](https://endtime-instruments.org/ai-bubble-tracker/)<!-- HN:50433669:end --><!-- HN:50433079:start -->
* [50433079](https://news.social-protocols.org/stats?id=50433079) #24 106 points 126 comments -> [A year after the 100% AI mandate nobody understands our code](https://www.reddit.com/r/ClaudeCode/comments/1xq2n3t/a_year_after_the_100_ai_mandate_nobody/)<!-- HN:50433079:end --><!-- HN:50429906:start -->
* [50429906](https://news.social-protocols.org/stats?id=50429906) #1 960 points 586 comments -> [Claude Fable 5.2 and Mythos 5.2](https://www.anthropic.com/claude-fable-and-mythos-5-2)<!-- HN:50429906:end --><!-- HN:50436587:start -->
* [50436587](https://news.social-protocols.org/stats?id=50436587) #5 13 points 1 comments -> [Mathematicians Are Like Luddites](https://alok.blog/luddite/)<!-- HN:50436587:end --><!-- HN:50440359:start -->
* [50440359](https://news.social-protocols.org/stats?id=50440359) #9 30 points 23 comments -> [Compress any LLM 3x in one click,near-lossless,in under 50 MB RAM](https://neuracryption.com/research)<!-- HN:50440359:end --><!-- HN:50440657:start -->
* [50440657](https://news.social-protocols.org/stats?id=50440657) #16 12 points 1 comments -> [Wake me up when AI can...](https://stoppels.ch/2026/10/03/wake-me-up-when-ai-can.html)<!-- HN:50440657:end --><!-- HN:50442225:start -->
* [50442225](https://news.social-protocols.org/stats?id=50442225) #15 60 points 5 comments -> [.NET 11](https://devblogs.microsoft.com/dotnet/announcing-dotnet-11/)<!-- HN:50442225:end --><!-- HN:50443313:start -->
* [50443313](https://news.social-protocols.org/stats?id=50443313) #16 4 points 1 comments -> [U.S. highways have 878 stretches of 50+ miles with no fast EV charger (map)](https://chargingnear.me/nevi-charging-gaps)<!-- HN:50443313:end -->