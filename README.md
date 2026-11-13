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
* [50440657](https://news.social-protocols.org/stats?id=50440657) #16 12 points 1 comments -> [Wake me up when AI can...](https://stoppels.ch/2026/10/03/wake-me-up-when-ai-can.html)<!-- HN:50440657:end --><!-- HN:50443313:start -->
* [50443313](https://news.social-protocols.org/stats?id=50443313) #16 4 points 1 comments -> [U.S. highways have 878 stretches of 50+ miles with no fast EV charger (map)](https://chargingnear.me/nevi-charging-gaps)<!-- HN:50443313:end -->
#### **Wednesday, November 11, 2026**
<!-- HN:50427407:start -->
* [50427407](https://news.social-protocols.org/stats?id=50427407) #14 4 points 2 comments -> [Good Enough for a Tuesday Night](https://www.newyorker.com/culture/the-weekend-essay/good-enough-for-a-tuesday-night)<!-- HN:50427407:end --><!-- HN:50452074:start -->
* [50452074](https://news.social-protocols.org/stats?id=50452074) #7 36 points 31 comments -> [The Zig project is going nowhere](https://bytecode.news/posts/2026/10/the-zig-project-is-going-nowhere)<!-- HN:50452074:end --><!-- HN:50451985:start -->
* [50451985](https://news.social-protocols.org/stats?id=50451985) #9 36 points 41 comments -> [The Housing Market Is Nuts](https://nuts.logical.li/)<!-- HN:50451985:end --><!-- HN:50428860:start -->
* [50428860](https://news.social-protocols.org/stats?id=50428860) #25 6 points 0 comments -> [Beans at altitude: stovetop vs. pressure cooker](https://highaltitudelife.com/beans-at-altitude-stovetop-vs-pressure-cooker/)<!-- HN:50428860:end -->
#### **Thursday, November 12, 2026**
<!-- HN:50459776:start -->
* [50459776](https://news.social-protocols.org/stats?id=50459776) #11 221 points 187 comments -> [Nvidia prepares to fire CEO Jensen Huang, WSJ reports](https://twitter.com/watcherguru/status/2120645607866188008)<!-- HN:50459776:end --><!-- HN:50463813:start -->
* [50463813](https://news.social-protocols.org/stats?id=50463813) #12 13 points 3 comments -> [Europe has been living beyond its means. Now the bills are due](https://economist.com/europe/2026/11/10/europe-has-been-living-beyond-its-means-now-the-bills-are-due)<!-- HN:50463813:end --><!-- HN:50467139:start -->
* [50467139](https://news.social-protocols.org/stats?id=50467139) #8 162 points 87 comments -> [Nvidia CEO Jensen Huang resigns after reports of second affair deepened scandal](https://www.bbc.co.uk/news/live/c6zjry11v8w1t)<!-- HN:50467139:end --><!-- HN:50467132:start -->
* [50467132](https://news.social-protocols.org/stats?id=50467132) #3 364 points 197 comments -> [Jensen Huang resigns as Nvidia CEO immediately](https://www.reuters.com/live/nvidia-live-board-meets-fate-ceo-jensen-huang-after-affair-reports-2026-11-12/)<!-- HN:50467132:end --><!-- HN:50467191:start -->
* [50467191](https://news.social-protocols.org/stats?id=50467191) #17 70 points 18 comments -> [Nvidia CEO Jensen Huang resigns after reports of extramarital relationships](https://www.nbcnews.com/tech/tech-news/nvidia-ceo-jensen-huang-resigns-reports-extramarital-relationships-rcna608402)<!-- HN:50467191:end --><!-- HN:50469123:start -->
* [50469123](https://news.social-protocols.org/stats?id=50469123) #26 8 points 3 comments -> [Show HN: A self-hosted PHP platform combining CMS, e-commerce and more, built-in](https://getvale.org)<!-- HN:50469123:end --><!-- HN:50470975:start -->
* [50470975](https://news.social-protocols.org/stats?id=50470975) #23 17 points 8 comments -> [AI Models Know What Women, Peace and Security Is. They Just Don't Bring It Up](https://blog.cip.org/p/ai-models-know-what-women-peace-and)<!-- HN:50470975:end --><!-- HN:50471428:start -->
* [50471428](https://news.social-protocols.org/stats?id=50471428) #12 14 points 3 comments -> [Gemini 4 Hydrogen](https://deepmind.google/models/model-cards/gemini-4-hydrogen/)<!-- HN:50471428:end --><!-- HN:50471793:start -->
* [50471793](https://news.social-protocols.org/stats?id=50471793) #2 300 points 7 comments -> [Rust 1.100.0](https://github.com/rust-lang/rust/releases/tag/1.100.0)<!-- HN:50471793:end --><!-- HN:50473606:start -->
* [50473606](https://news.social-protocols.org/stats?id=50473606) #23 21 points 14 comments -> [Microsoft Status: "We are re-routing the protocols"](https://admin.cloud.microsoft/?#/servicehealth/:/alerts/MO1550821)<!-- HN:50473606:end -->
#### **Friday, November 13, 2026**
<!-- HN:50475735:start -->
* [50475735](https://news.social-protocols.org/stats?id=50475735) #2 76 points 44 comments -> [Why You Should Expect an AI Crash](https://www.economist.com/leaders/2026/11/12/why-you-should-expect-an-ai-crash)<!-- HN:50475735:end --><!-- HN:50475505:start -->
* [50475505](https://news.social-protocols.org/stats?id=50475505) #27 14 points 2 comments -> [Outlook Down, Microsoft Teams and Office may be impacted](https://status.cloud.microsoft/m365/referrer=serviceStatusRedirect)<!-- HN:50475505:end --><!-- HN:50477331:start -->
* [50477331](https://news.social-protocols.org/stats?id=50477331) #1 112 points 43 comments -> [Africa's solar revolution is vast and speedy](https://www.economist.com/middle-east-and-africa/2026/11/12/africas-solar-revolution-is-vast-and-speedy)<!-- HN:50477331:end --><!-- HN:50480194:start -->
* [50480194](https://news.social-protocols.org/stats?id=50480194) #3 9 points 1 comments -> [People Vote for Anti-Immigration Parties Because They Don't Like Immigration](https://www.popularbydesign.org/p/people-vote-for-anti-immigration)<!-- HN:50480194:end -->