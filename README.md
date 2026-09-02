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

#### **Thursday, August 27, 2026**
<!-- HN:49461862:start -->
* [49461862](https://news.social-protocols.org/stats?id=49461862) #8 9 points 1 comments -> [Qwen3.8-Flash-Next Intelligence, Performance and Price Analysis](https://artificialanalysis.ai/models/qwen3-8-flash-next)<!-- HN:49461862:end --><!-- HN:49463680:start -->
* [49463680](https://news.social-protocols.org/stats?id=49463680) #3 24 points 4 comments -> ["No way to prevent this" say users of only language where this regularly happens](https://xeiaso.net/shitposts/no-way-to-prevent-this/memory-safety/CVE-2026-41992/)<!-- HN:49463680:end --><!-- HN:49464973:start -->
* [49464973](https://news.social-protocols.org/stats?id=49464973) #3 15 points 0 comments -> [The Unwelcoming States of America](https://www.economist.com/leaders/2026/08/27/the-unwelcoming-states-of-america)<!-- HN:49464973:end --><!-- HN:49464847:start -->
* [49464847](https://news.social-protocols.org/stats?id=49464847) #7 11 points 2 comments -> [Never Launch Alone](https://launchgenius.app)<!-- HN:49464847:end --><!-- HN:49464834:start -->
* [49464834](https://news.social-protocols.org/stats?id=49464834) #7 21 points 7 comments -> [Show HN: Pause – weekly curated 1:1 coffee matches for London professionals](https://joinpause.co/)<!-- HN:49464834:end --><!-- HN:49465539:start -->
* [49465539](https://news.social-protocols.org/stats?id=49465539) #15 3 points 7 comments -> [Classical chess ranks 562nd of 960 starting positions after 460,800 games](https://chess960v2.com/en/news/2026-08-14-halfway)<!-- HN:49465539:end --><!-- HN:49464979:start -->
* [49464979](https://news.social-protocols.org/stats?id=49464979) #15 13 points 11 comments -> [AC2 Protocol: The missing security layer for AI agents](https://www.ac2protocol.org)<!-- HN:49464979:end --><!-- HN:49464310:start -->
* [49464310](https://news.social-protocols.org/stats?id=49464310) #25 14 points 3 comments -> [Confdiff – semantic diff for config files (JSON/YAML/TOML) that redacts secrets](https://github.com/esperanza-volkov/confdiff)<!-- HN:49464310:end --><!-- HN:49466057:start -->
* [49466057](https://news.social-protocols.org/stats?id=49466057) #27 5 points 0 comments -> [A sandbox is not a permission model for multi-agent systems](https://github.com/agentconnect-md/agentconnect)<!-- HN:49466057:end --><!-- HN:49464845:start -->
* [49464845](https://news.social-protocols.org/stats?id=49464845) #23 25 points 5 comments -> [Apple threat notifications and spyware: what everyone should know](https://www.accessnow.org/apple-threat-notifications-and-spyware/)<!-- HN:49464845:end --><!-- HN:49467570:start -->
* [49467570](https://news.social-protocols.org/stats?id=49467570) #13 14 points 2 comments -> [Qwen3.8-27B can silently corrupt business records](https://ingot.tools/reports/qwen3-8-27b-glitch-tokens)<!-- HN:49467570:end --><!-- HN:49465784:start -->
* [49465784](https://news.social-protocols.org/stats?id=49465784) #27 24 points 40 comments -> [Hollywood's Video Game Era Is Here. Will It Be Any Good?](https://www.statsignificant.com/p/hollywoods-video-game-era-is-here)<!-- HN:49465784:end --><!-- HN:49466865:start -->
* [49466865](https://news.social-protocols.org/stats?id=49466865) #11 105 points 3 comments -> [Japanese polka dot artist Yayoi Kusama dies aged 97](https://www.bbc.com/news/articles/c3v4k0re3vwo)<!-- HN:49466865:end --><!-- HN:49467702:start -->
* [49467702](https://news.social-protocols.org/stats?id=49467702) #24 28 points 9 comments -> [Grok Bot for Linux: Unofficial port of the official app (open source)](https://github.com/jakob-bu/grok-bot-linux-unofficial)<!-- HN:49467702:end --><!-- HN:49468945:start -->
* [49468945](https://news.social-protocols.org/stats?id=49468945) #13 8 points 1 comments -> [I measured what my Claude.md, skills and hooks are worth](https://github.com/jameskomo/config-drift-checker)<!-- HN:49468945:end --><!-- HN:49469134:start -->
* [49469134](https://news.social-protocols.org/stats?id=49469134) #22 21 points 5 comments -> [Y Combinator's Ankit Gupta faces backlash over H-1B comments](https://americanbazaaronline.com/2026/08/27/y-combinators-ankit-gupta-faces-backlash-over-h-1b-comments-487099/)<!-- HN:49469134:end -->
#### **Friday, August 28, 2026**
<!-- HN:49470949:start -->
* [49470949](https://news.social-protocols.org/stats?id=49470949) #20 127 points 26 comments -> [Meta Paid $17B – Gets to Write Safety Rules for Other SocMedia Platform](https://www.techdirt.com/2026/08/26/meta-just-paid-nearly-17-billion-to-make-sure-it-gets-to-write-the-kid-safety-rules-for-every-other-social-media-platform/)<!-- HN:49470949:end --><!-- HN:49473982:start -->
* [49473982](https://news.social-protocols.org/stats?id=49473982) #6 7 points 0 comments -> [CSV merger that lines up mismatched columns by header, browser-only](https://usefiletools.com/data/merge-csv/)<!-- HN:49473982:end --><!-- HN:49474572:start -->
* [49474572](https://news.social-protocols.org/stats?id=49474572) #30 6 points 0 comments -> [Lake America? Spare Us](https://www.nationalreview.com/corner/lake-america-spare-us/)<!-- HN:49474572:end --><!-- HN:49474703:start -->
* [49474703](https://news.social-protocols.org/stats?id=49474703) #30 6 points 0 comments -> [The Unwelcoming States of America](https://www.economist.com/leaders/2026/08/27/the-unwelcoming-states-of-america)<!-- HN:49474703:end --><!-- HN:49474605:start -->
* [49474605](https://news.social-protocols.org/stats?id=49474605) #18 7 points 6 comments -> [We will need more (not fewer) scientists](https://blog.valency.io/posts/we-need-more-scientists)<!-- HN:49474605:end --><!-- HN:49471714:start -->
* [49471714](https://news.social-protocols.org/stats?id=49471714) #23 110 points 13 comments -> [AI Engineer Notebooks – free, framework-free RAG/agents/evals on Colab](https://github.com/calmrocks/ai-engineer-notebooks)<!-- HN:49471714:end --><!-- HN:49476278:start -->
* [49476278](https://news.social-protocols.org/stats?id=49476278) #12 10 points 0 comments -> [I Cut 80%+ of Context Overhead in My Coding Agent](https://m-reschreiter.at/en/blog/how-i-cut-80-percent-context-overhead-dynamic-tools)<!-- HN:49476278:end --><!-- HN:49476929:start -->
* [49476929](https://news.social-protocols.org/stats?id=49476929) #24 9 points 1 comments -> [South Korea's 'AI for All' Push Gives Free Access to Every Citizen](https://www.wsj.com/tech/ai/south-koreas-ai-for-all-push-gives-free-access-to-every-citizen-451f6b2c)<!-- HN:49476929:end --><!-- HN:49477683:start -->
* [49477683](https://news.social-protocols.org/stats?id=49477683) #14 3 points 3 comments -> [Teleport: Pack an agent session, resume it anywhere on any harness](https://github.com/sisig-ai/teleport)<!-- HN:49477683:end --><!-- HN:49477428:start -->
* [49477428](https://news.social-protocols.org/stats?id=49477428) #21 9 points 6 comments -> [What Running Kafka on VMs Taught Us About Systems Thinking](https://engineering.moniepoint.com/what-running-kafka-on-vms-taught-us-about-systems-thinking)<!-- HN:49477428:end --><!-- HN:49477530:start -->
* [49477530](https://news.social-protocols.org/stats?id=49477530) #21 14 points 4 comments -> [Show HN: Talos – An AI agent with a permission kernel between model and shell](https://talos-agent.ch/)<!-- HN:49477530:end --><!-- HN:49478525:start -->
* [49478525](https://news.social-protocols.org/stats?id=49478525) #10 9 points 0 comments -> [How do functions like alloca allocate memory from the stack?](https://devblogs.microsoft.com/oldnewthing/20260817-00/?p=112617)<!-- HN:49478525:end --><!-- HN:49477055:start -->
* [49477055](https://news.social-protocols.org/stats?id=49477055) #24 312 points 3 comments -> [Pentagon's blacklisting of Anthropic was unlawful, US judge rules](https://www.reuters.com/legal/government/us-judge-blocks-pentagons-anthropic-blacklisting-2026-08-28/)<!-- HN:49477055:end --><!-- HN:49481679:start -->
* [49481679](https://news.social-protocols.org/stats?id=49481679) #21 4 points 2 comments -> [Show HN: I'm auctioning 12 laser-etched logo spots on my next MacBook](https://lidbrand.com)<!-- HN:49481679:end --><!-- HN:49481689:start -->
* [49481689](https://news.social-protocols.org/stats?id=49481689) #14 13 points 3 comments -> [I Design with AI](https://ref.tools/blog/how-i-design-with-ai)<!-- HN:49481689:end --><!-- HN:49483248:start -->
* [49483248](https://news.social-protocols.org/stats?id=49483248) #11 27 points 29 comments -> [The OG Creator of Task Manager on Windows Built a New Task Manager](https://tmog.org)<!-- HN:49483248:end --><!-- HN:49483182:start -->
* [49483182](https://news.social-protocols.org/stats?id=49483182) #7 186 points 148 comments -> [25,000 Lbs. Of Chicken Products Recalled in 5 States: USDA](https://www.thehealthy.com/news/chicken-recall-fsis-august-2026/)<!-- HN:49483182:end -->
#### **Saturday, August 29, 2026**
<!-- HN:49486805:start -->
* [49486805](https://news.social-protocols.org/stats?id=49486805) #30 24 points 9 comments -> [Twitterwebviewer.com Service Discontinued](https://twitterwebviewer.com/?)<!-- HN:49486805:end --><!-- HN:49487506:start -->
* [49487506](https://news.social-protocols.org/stats?id=49487506) #12 24 points 13 comments -> [e is a customizable self-aware Emacs-like editor written in Chez Scheme](https://github.com/paveluv/e)<!-- HN:49487506:end --><!-- HN:49489504:start -->
* [49489504](https://news.social-protocols.org/stats?id=49489504) #2 5 points 2 comments -> [POWBlock is a universal bot/DDoS defense primitive for any server](https://github.com/8Protons/POWBlock)<!-- HN:49489504:end --><!-- HN:49489864:start -->
* [49489864](https://news.social-protocols.org/stats?id=49489864) #12 15 points 3 comments -> [I'm teaching an introductory 12 week course on Quantum Oracle Engineering](https://shukla.io/quantum-oracle-engineering/)<!-- HN:49489864:end --><!-- HN:49491282:start -->
* [49491282](https://news.social-protocols.org/stats?id=49491282) #24 21 points 5 comments -> [Claude permanently raising weekly limits by 25%](https://bsky.app/profile/anthropicbot.bsky.social/post/3muaaxs5nx424)<!-- HN:49491282:end --><!-- HN:49491447:start -->
* [49491447](https://news.social-protocols.org/stats?id=49491447) #25 6 points 0 comments -> [I hate AI images and music](https://mat.leaflet.pub/3mu35coarbs2o)<!-- HN:49491447:end --><!-- HN:49493660:start -->
* [49493660](https://news.social-protocols.org/stats?id=49493660) #30 18 points 2 comments -> [Palestinian woman and NBC News team attacked by masked Israeli settlers](https://www.nbcnews.com/world/middle-east/palestinian-nbc-news-team-attacked-masked-israeli-settlers-rcna595024)<!-- HN:49493660:end --><!-- HN:49491544:start -->
* [49491544](https://news.social-protocols.org/stats?id=49491544) #20 38 points 40 comments -> [A better SQL in 11 lines of code](https://prela-lang.org/tutorial/)<!-- HN:49491544:end -->
#### **Sunday, August 30, 2026**
<!-- HN:49494023:start -->
* [49494023](https://news.social-protocols.org/stats?id=49494023) #26 12 points 5 comments -> [Twitter (Not affiliated with X Corp)](https://twitter.now/maintenance/)<!-- HN:49494023:end --><!-- HN:49494212:start -->
* [49494212](https://news.social-protocols.org/stats?id=49494212) #28 18 points 2 comments -> [Police departments weren’t looking for Flock abuse. We did it for them.](https://www.washingtonpost.com/technology/2026/08/19/we-found-cops-who-misused-flock-their-police-departments-didnt-know/)<!-- HN:49494212:end --><!-- HN:49494049:start -->
* [49494049](https://news.social-protocols.org/stats?id=49494049) #30 4 points 0 comments -> [PCSX2 2.8.0 is now out This release is PACKED](https://pcsx2.net/blog/2026/pcsx2-2.8/)<!-- HN:49494049:end --><!-- HN:49495976:start -->
* [49495976](https://news.social-protocols.org/stats?id=49495976) #18 -> [Palestinian woman and NBC News team attacked by Israeli settlers in West Bank](https://www.nbcnews.com/world/middle-east/palestinian-nbc-news-team-attacked-masked-israeli-settlers-rcna595024)<!-- HN:49495976:end --><!-- HN:49496707:start -->
* [49496707](https://news.social-protocols.org/stats?id=49496707) #21 35 points 41 comments -> [Iceland rejects reopening talks on EU entry](https://www.ft.com/content/53b5abd8-2919-4dc6-8dd6-81fc054e8b6f)<!-- HN:49496707:end --><!-- HN:49497803:start -->
* [49497803](https://news.social-protocols.org/stats?id=49497803) #9 -> [The turbulent AI era is here. The choices we make now are critical](https://www.gatesnotes.com/home/home-page-topic/reader/a-turbulent-ai-era-and-critical-choices-to-make)<!-- HN:49497803:end --><!-- HN:49499051:start -->
* [49499051](https://news.social-protocols.org/stats?id=49499051) #10 6 points 1 comments -> [Emacs vs. Vim 2026: 24.3% vs. 8% Usage, 20x Memory Gap](https://tech-insider.org/emacs-vs-vim-2026/)<!-- HN:49499051:end --><!-- HN:49501087:start -->
* [49501087](https://news.social-protocols.org/stats?id=49501087) #30 11 points 1 comments -> [Flock's CEO Is Lying to Cops About 404 Media's Reporting on Abortion Case](https://www.404media.co/flocks-ceo-is-lying-to-cops-about-404-medias-reporting-on-abortion-case/)<!-- HN:49501087:end --><!-- HN:49501002:start -->
* [49501002](https://news.social-protocols.org/stats?id=49501002) #5 19 points 11 comments -> [Should We Have Kept the American Empire?](https://www.maximum-progress.com/p/should-we-have-kept-the-american)<!-- HN:49501002:end --><!-- HN:49502101:start -->
* [49502101](https://news.social-protocols.org/stats?id=49502101) #12 17 points 7 comments -> [I am no longer letting Claude Code add itself as Co-author in my commits](https://igupta.in/blog/why-i-am-no-longer-letting-claude-code-add-itself-as-coauthor/)<!-- HN:49502101:end --><!-- HN:49501147:start -->
* [49501147](https://news.social-protocols.org/stats?id=49501147) #29 25 points 13 comments -> [Running SQLite Apps on Docker and Kubernetes with Litestream](https://openrun.dev/blog/litestream/)<!-- HN:49501147:end --><!-- HN:49501932:start -->
* [49501932](https://news.social-protocols.org/stats?id=49501932) #9 17 points 12 comments -> [1kB Website as Status Symbol](https://async.cat/blog)<!-- HN:49501932:end --><!-- HN:49501210:start -->
* [49501210](https://news.social-protocols.org/stats?id=49501210) #22 29 points 21 comments -> [Norway Shrugged](https://paragraph.com/@hagaetc/norway-shrugged)<!-- HN:49501210:end -->
#### **Monday, August 31, 2026**
<!-- HN:49503421:start -->
* [49503421](https://news.social-protocols.org/stats?id=49503421) #12 27 points 20 comments -> [Show HN: Academa – Long-form STEM lecture videos generated by LLMs](https://academa.ai/)<!-- HN:49503421:end --><!-- HN:49504922:start -->
* [49504922](https://news.social-protocols.org/stats?id=49504922) #9 13 points 16 comments -> [CobaltC – The Successor to C?](https://strawberry9.github.io/the-wrong-memory/Appendix_06.html)<!-- HN:49504922:end --><!-- HN:49505043:start -->
* [49505043](https://news.social-protocols.org/stats?id=49505043) #27 10 points 5 comments -> [Show HN: Prove your code produced your claims without making reviewers rerun it](https://github.com/27-GROUP/kveritas-go/)<!-- HN:49505043:end --><!-- HN:49446839:start -->
* [49446839](https://news.social-protocols.org/stats?id=49446839) #14 8 points 0 comments -> [A spy satellite simulator in the browser, except the data is real](https://github.com/bilawalsidhu/gods-eye-view)<!-- HN:49446839:end --><!-- HN:49507976:start -->
* [49507976](https://news.social-protocols.org/stats?id=49507976) #4 12 points 4 comments -> [The ISBN was invented in 1970. Your books don't care](https://www.shelvd.org/blog/isbn-invented-1970)<!-- HN:49507976:end --><!-- HN:49508622:start -->
* [49508622](https://news.social-protocols.org/stats?id=49508622) #27 4 points 0 comments -> [Lake Ontario Now Called Lake America on Google Maps](https://apnews.com/article/lake-trump-ontario-america-7c5c9776d72cb8e8d782e05ec6e7332b)<!-- HN:49508622:end --><!-- HN:49508200:start -->
* [49508200](https://news.social-protocols.org/stats?id=49508200) #18 8 points 0 comments -> [The AI-Native SDLC Starts with Your Infrastructure](https://metalbear.com/blog/ai-native-sdlc-infrastructure/)<!-- HN:49508200:end --><!-- HN:49509876:start -->
* [49509876](https://news.social-protocols.org/stats?id=49509876) #5 29 points 30 comments -> [Omarchy: 1Password and 37signals become Distinguished Corporate Patrons](https://omarchy.org/news/2026/08/1password-and-37signals-become-distinguished-corporate-patrons/)<!-- HN:49509876:end --><!-- HN:49510600:start -->
* [49510600](https://news.social-protocols.org/stats?id=49510600) #12 6 points 1 comments -> [Show HN: 2x-4x cheaper GLM 5.3 for coding and research](https://www.coralbricks.ai)<!-- HN:49510600:end --><!-- HN:49510612:start -->
* [49510612](https://news.social-protocols.org/stats?id=49510612) #14 18 points 3 comments -> [Agentic Trust Controls](https://trustcontrols.ai/)<!-- HN:49510612:end --><!-- HN:49512789:start -->
* [49512789](https://news.social-protocols.org/stats?id=49512789) #30 73 points 62 comments -> [Student Teacher Arrested for Private Snapchat Message](https://www.gadgetreview.com/student-teacher-sent-a-private-snapchat-complaining-about-her-workday-an-hour-later-police-pulled-up-to-her-school)<!-- HN:49512789:end --><!-- HN:49514454:start -->
* [49514454](https://news.social-protocols.org/stats?id=49514454) #5 -> [The river of Apple's interface guidelines](https://hig.josefrichter.design/)<!-- HN:49514454:end -->
#### **Tuesday, September 1, 2026**
<!-- HN:49517420:start -->
* [49517420](https://news.social-protocols.org/stats?id=49517420) #3 61 points 4 comments -> [Tailcat: Tailscale Without Tailscale, by Tailscale](https://tailscale.com/blog/tailcat)<!-- HN:49517420:end --><!-- HN:49517483:start -->
* [49517483](https://news.social-protocols.org/stats?id=49517483) #10 20 points 0 comments -> [Is MCP Good Yet?](https://ismcpgoodyet.com)<!-- HN:49517483:end --><!-- HN:49518078:start -->
* [49518078](https://news.social-protocols.org/stats?id=49518078) #26 3 points 0 comments -> [Google Ads vs. Facebook Ads: Which Is Better for Small Businesses?](https://www.hostiqen.com/2026/08/google-ads-vs-facebook-ads-which-is.html)<!-- HN:49518078:end --><!-- HN:49518916:start -->
* [49518916](https://news.social-protocols.org/stats?id=49518916) #15 14 points 2 comments -> [1Password Supports the Ethnic Cleansing of Europe](https://www.alilleybrinker.com/blog/1password-funds-ethnic-cleansing/)<!-- HN:49518916:end --><!-- HN:49520270:start -->
* [49520270](https://news.social-protocols.org/stats?id=49520270) #18 34 points 40 comments -> [Lake Ontario ("Lake America")](https://community.openstreetmap.org/t/lake-ontario-lake-america/146975)<!-- HN:49520270:end --><!-- HN:49521192:start -->
* [49521192](https://news.social-protocols.org/stats?id=49521192) #3 5 points 1 comments -> [Nemotron 3 Ultra Explained](https://miraflow.ai/blog/nemotron-3-ultra-explained-nvidia-hybrid-mamba-moe-2026)<!-- HN:49521192:end --><!-- HN:49520229:start -->
* [49520229](https://news.social-protocols.org/stats?id=49520229) #12 6 points 4 comments -> [We Let AI Agents Rewrite a 92M-Message-a-Day Service in Go](https://www.checklyhq.com/blog/agentic-rewrite-nodejs-to-go/)<!-- HN:49520229:end --><!-- HN:49521490:start -->
* [49521490](https://news.social-protocols.org/stats?id=49521490) #7 5 points 0 comments -> [Please stop calling databases CP or AP (2015)](https://martin.kleppmann.com/2015/05/11/please-stop-calling-databases-cp-or-ap.html)<!-- HN:49521490:end --><!-- HN:49521180:start -->
* [49521180](https://news.social-protocols.org/stats?id=49521180) #5 12 points 1 comments -> [Fuck you, show me the prompt](https://hamel.dev/blog/posts/prompt/)<!-- HN:49521180:end --><!-- HN:49475924:start -->
* [49475924](https://news.social-protocols.org/stats?id=49475924) #14 19 points 3 comments -> [Benchmarking Vector Indexes](https://www.percona.com/blog/benchmarking-vector-indexes/)<!-- HN:49475924:end --><!-- HN:49523101:start -->
* [49523101](https://news.social-protocols.org/stats?id=49523101) #18 -> [Christian Employers Can Now Discriminate Against Trans People](https://theintercept.com/2026/09/01/christian-employers-settlement-gender-discrimination-eeoc/)<!-- HN:49523101:end --><!-- HN:49525576:start -->
* [49525576](https://news.social-protocols.org/stats?id=49525576) #7 14 points 0 comments -> [Fable 5.1 System Card](https://www.anthropic.com/document/claude-fable-5-1-mythos-5-1-system-card)<!-- HN:49525576:end --><!-- HN:49525496:start -->
* [49525496](https://news.social-protocols.org/stats?id=49525496) #7 65 points 11 comments -> [Claude Fable 5.1 and Claude Mythos 5.1](https://www.anthropic.com/claude-fable-and-mythos-5-1)<!-- HN:49525496:end -->
#### **Wednesday, September 2, 2026**
<!-- HN:49448019:start -->
* [49448019](https://news.social-protocols.org/stats?id=49448019) #29 52 points 11 comments -> [Specifications Don't Exist](https://www.galois.com/articles/specifications-dont-exist)<!-- HN:49448019:end --><!-- HN:49530472:start -->
* [49530472](https://news.social-protocols.org/stats?id=49530472) #8 43 points 11 comments -> [Claude Fable 5.1 made me a nice animated pelican](https://simonwillison.net/2026/Sep/1/claude-fable-5-1/)<!-- HN:49530472:end --><!-- HN:49533743:start -->
* [49533743](https://news.social-protocols.org/stats?id=49533743) #23 5 points 8 comments -> [Draft Punk – The Campaign for Alive 2027 – Alive2027.com](https://alive2027.com/)<!-- HN:49533743:end --><!-- HN:49534583:start -->
* [49534583](https://news.social-protocols.org/stats?id=49534583) #13 17 points 7 comments -> [LLM Judges Verify Presence, Not Absence: Omission Blindness in AI Clinical Notes](https://arxiv.org/abs/2608.31016)<!-- HN:49534583:end -->