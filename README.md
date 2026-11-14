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
* [50480194](https://news.social-protocols.org/stats?id=50480194) #3 9 points 1 comments -> [People Vote for Anti-Immigration Parties Because They Don't Like Immigration](https://www.popularbydesign.org/p/people-vote-for-anti-immigration)<!-- HN:50480194:end --><!-- HN:50481354:start -->
* [50481354](https://news.social-protocols.org/stats?id=50481354) #14 7 points 1 comments -> [Llama.cpp: 6.5x faster prompt processing on Arm with a NEON kernel](https://github.com/hardwiredagent/silicon-forge-arm-neon-study)<!-- HN:50481354:end --><!-- HN:50485166:start -->
* [50485166](https://news.social-protocols.org/stats?id=50485166) #4 10 points 7 comments -> [Comparing Jensen to Steve Jobs Is Stupid](https://jonaserthal.com/blog/jobs-and-jensen/)<!-- HN:50485166:end --><!-- HN:50487861:start -->
* [50487861](https://news.social-protocols.org/stats?id=50487861) #6 15 points 4 comments -> [6-11X speedup running Qwen3.6 on my RTX 4090, full repo.](https://github.com/me-farza/lightreason/tree/main)<!-- HN:50487861:end --><!-- HN:50486480:start -->
* [50486480](https://news.social-protocols.org/stats?id=50486480) #23 21 points 11 comments -> [Gnomon. Git for Postgres data, built for agents](https://github.com/bitsinfra/gnomon)<!-- HN:50486480:end --><!-- HN:50490383:start -->
* [50490383](https://news.social-protocols.org/stats?id=50490383) #6 -> [US Radar Service Outage](https://www.weather.gov/afc/radaroutage)<!-- HN:50490383:end --><!-- HN:50490967:start -->
* [50490967](https://news.social-protocols.org/stats?id=50490967) #14 6 points 1 comments -> [Home Assistant: the password is not the key – token secrets in cleartext](https://seclists.org/fulldisclosure/2026/Nov/34)<!-- HN:50490967:end -->
#### **Saturday, November 14, 2026**
<!-- HN:50491753:start -->
* [50491753](https://news.social-protocols.org/stats?id=50491753) #18 7 points 0 comments -> [Doc-foundry – AI writes Security detection rules, then proves they work](https://github.com/mjha-arya/DOC-foundry)<!-- HN:50491753:end --><!-- HN:50492450:start -->
* [50492450](https://news.social-protocols.org/stats?id=50492450) #14 -> [Hawaii DOT: All West Coast flights halted by SpaceX debris after FAA ground stop](https://www.hawaiinewsnow.com/2026/11/14/dot-all-west-coast-flights-halted-by-spacex-debris-after-faa-ground-stop/)<!-- HN:50492450:end --><!-- HN:50492945:start -->
* [50492945](https://news.social-protocols.org/stats?id=50492945) #9 7 points 1 comments -> [Hawaii flights halted due to debris from SpaceX launch amidst FAA's ground stop](https://www.kitv.com/news/hawaii-flights-to-west-coast-halted-due-to-debris-from-spacex-launch-amidst-faas-nationwide/article_9b8dfe4d-8e80-4949-96a2-39c4eddc870f.html)<!-- HN:50492945:end --><!-- HN:50492456:start -->
* [50492456](https://news.social-protocols.org/stats?id=50492456) #8 213 points 101 comments -> [Ukraine knocks out 36% of Russia's oil refining capacity in under two weeks](https://english.nv.ua/nation/thirteen-day-drone-blitz-paralyzes-36-of-moscow-s-oil-50658616.html)<!-- HN:50492456:end --><!-- HN:50492601:start -->
* [50492601](https://news.social-protocols.org/stats?id=50492601) #2 205 points 1 comments -> [FAA lifted National Ground Stop at 0119Z](https://www.fly.faa.gov/adv/adv_otherdis?adv_date=11142026&advn=5)<!-- HN:50492601:end --><!-- HN:50493731:start -->
* [50493731](https://news.social-protocols.org/stats?id=50493731) #15 12 points 1 comments -> [Run Cloudflare Workers Anywhere](https://openorange.dev/)<!-- HN:50493731:end --><!-- HN:50494303:start -->
* [50494303](https://news.social-protocols.org/stats?id=50494303) #30 -> [Israeli airstrike on Nasser hospital in Gaza killed surgeon and others](https://www.theguardian.com/world/2026/nov/12/israeli-airstrike-nasser-hospital-gaza-kills-surgeon)<!-- HN:50494303:end --><!-- HN:50494914:start -->
* [50494914](https://news.social-protocols.org/stats?id=50494914) #3 11 points 0 comments -> [The Invention of Islamic Invention](https://www.cremieux.xyz/p/the-invention-of-islamic-invention)<!-- HN:50494914:end --><!-- HN:50467010:start -->
* [50467010](https://news.social-protocols.org/stats?id=50467010) #26 6 points 1 comments -> [Cabo Pulmo, John Steinbeck, and the village that wouldn't give up](https://blue-continuum.com/the-village-that-gave-back-its-sea)<!-- HN:50467010:end -->