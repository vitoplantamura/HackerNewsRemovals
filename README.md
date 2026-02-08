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

#### **Monday, February 2, 2026**
<!-- HN:46811655:start -->
* [46811655](https://news.social-protocols.org/stats?id=46811655) #20 10 points 4 comments -> [From its name, to its hazy origins, to its drug interactions, there's a lot goin](https://www.atlasobscura.com/articles/grapefruit-history-and-drug-interactions)<!-- HN:46811655:end --><!-- HN:46849375:start -->
* [46849375](https://news.social-protocols.org/stats?id=46849375) #23 12 points 0 comments -> [A Collection of Awesome Nostr Projects](https://github.com/aljazceru/awesome-nostr)<!-- HN:46849375:end --><!-- HN:46852548:start -->
* [46852548](https://news.social-protocols.org/stats?id=46852548) #22 5 points 0 comments -> [NPR and PBS Never Needed Your Taxpayer Dollars](https://www.nationalreview.com/2026/02/npr-and-pbs-never-needed-your-taxpayer-dollars/)<!-- HN:46852548:end --><!-- HN:46853532:start -->
* [46853532](https://news.social-protocols.org/stats?id=46853532) #21 5 points 3 comments -> [Welcome to Trumpistan](https://archive.vanityfair.com/article/2017/2/welcome-to-trumpistan)<!-- HN:46853532:end --><!-- HN:46813009:start -->
* [46813009](https://news.social-protocols.org/stats?id=46813009) #15 8 points 3 comments -> [Attilio Berni plays the sub-contrabass saxophone [video]](https://www.youtube.com/watch?v=9BiW2mVKk0w)<!-- HN:46813009:end --><!-- HN:46855003:start -->
* [46855003](https://news.social-protocols.org/stats?id=46855003) #7 17 points 16 comments -> [Applications where agents are first-class citizens](https://every.to/guides/agent-native)<!-- HN:46855003:end --><!-- HN:46805867:start -->
* [46805867](https://news.social-protocols.org/stats?id=46805867) #21 8 points 0 comments -> [High performance, open source RAFT clustered database: RooDB](https://github.com/jgarzik/roodb)<!-- HN:46805867:end --><!-- HN:46856133:start -->
* [46856133](https://news.social-protocols.org/stats?id=46856133) #3 5 points 0 comments -> [Tim Cook sold Apple's soul](https://www.loopwerk.io/articles/2026/tim-cook-sold-apples-soul/)<!-- HN:46856133:end --><!-- HN:46856384:start -->
* [46856384](https://news.social-protocols.org/stats?id=46856384) #18 10 points 1 comments -> [Google AI helped IDF drones with targeting in 2024 breaching its own policies](https://www.washingtonpost.com/technology/2026/02/01/google-ai-israel-military/)<!-- HN:46856384:end --><!-- HN:46857257:start -->
* [46857257](https://news.social-protocols.org/stats?id=46857257) #29 4 points 1 comments -> [Classified Whistleblower Complaint About Tulsi Gabbard Stalls Within Her Agency](https://www.wsj.com/politics/national-security/classified-whistleblower-complaint-about-tulsi-gabbard-stalls-within-her-agency-027f5331)<!-- HN:46857257:end --><!-- HN:46857796:start -->
* [46857796](https://news.social-protocols.org/stats?id=46857796) #5 15 points 4 comments -> [My five stages of AI grief](https://dev-tester.com/my-five-stages-of-ai-grief/)<!-- HN:46857796:end --><!-- HN:46857618:start -->
* [46857618](https://news.social-protocols.org/stats?id=46857618) #9 20 points 5 comments -> [Claude Code's renderer is more complex than a game engine](https://spader.zone/engine/)<!-- HN:46857618:end --><!-- HN:46858682:start -->
* [46858682](https://news.social-protocols.org/stats?id=46858682) #24 7 points 2 comments -> [Rust Coreutils Continues Working Toward 100% GNU Compatibility, Proving Trolls](https://www.phoronix.com/news/Rust-Coreutils-FOSDEM-2026)<!-- HN:46858682:end --><!-- HN:46857124:start -->
* [46857124](https://news.social-protocols.org/stats?id=46857124) #24 44 points 59 comments -> [We asked 15,000 European devs about jobs, salaries, and AI [pdf]](https://static.germantechjobs.de/market-reports/European-Transparent-IT-Job-Market-Report-2025.pdf)<!-- HN:46857124:end --><!-- HN:46860753:start -->
* [46860753](https://news.social-protocols.org/stats?id=46860753) #25 9 points 3 comments -> [Don't discount American democracy's resilience](https://www.natesilver.net/p/dont-discount-american-democracys)<!-- HN:46860753:end --><!-- HN:46860984:start -->
* [46860984](https://news.social-protocols.org/stats?id=46860984) #23 19 points 13 comments -> [LinkedIn Is Down](https://ctrlv.link/8aQX)<!-- HN:46860984:end -->
#### **Tuesday, February 3, 2026**
<!-- HN:46864214:start -->
* [46864214](https://news.social-protocols.org/stats?id=46864214) #29 8 points 0 comments -> [Partner at Day One Ventures ranks intelligence by how Jewish someone is](https://twitter.com/amasad/status/2018175092648472913)<!-- HN:46864214:end --><!-- HN:46866421:start -->
* [46866421](https://news.social-protocols.org/stats?id=46866421) #21 5 points 2 comments -> [Use Less Shit](https://uselessshit.org/)<!-- HN:46866421:end --><!-- HN:46868518:start -->
* [46868518](https://news.social-protocols.org/stats?id=46868518) #17 10 points 13 comments -> [Boring Go – A practical guide to writing boring, maintainable Go](https://golang.college/books/boring-go)<!-- HN:46868518:end --><!-- HN:46868565:start -->
* [46868565](https://news.social-protocols.org/stats?id=46868565) #6 11 points 5 comments -> [Claude Sonnet 5 Is Imminent – and It Could Be a Generation Ahead of Google](https://ucstrategies.com/news/claude-sonnet-5-is-imminent-and-it-could-be-a-generation-ahead-of-google/)<!-- HN:46868565:end --><!-- HN:46819827:start -->
* [46819827](https://news.social-protocols.org/stats?id=46819827) #11 9 points 2 comments -> [SVGs are uniquely legible to LLMs](https://turbek.com/Designing-Interactive-SVGs-with-AI/)<!-- HN:46819827:end --><!-- HN:46846762:start -->
* [46846762](https://news.social-protocols.org/stats?id=46846762) #16 17 points 3 comments -> [Same SQL, Different Results: A Subtle Oracle vs. PostgreSQL Migration Bug](https://databaserookies.wordpress.com/2026/01/30/same-sql-different-results-a-subtle-oracle-vs-postgresql-migration-bug/)<!-- HN:46846762:end --><!-- HN:46869797:start -->
* [46869797](https://news.social-protocols.org/stats?id=46869797) #29 8 points 0 comments -> [Israeli Military Found Gaza Health Ministry Death Toll Was Accurate](https://theintercept.com/2026/01/30/israel-gaza-death-toll-accurate-denial/)<!-- HN:46869797:end --><!-- HN:46870113:start -->
* [46870113](https://news.social-protocols.org/stats?id=46870113) #16 17 points 2 comments -> [Lead in archived hair documents a decline in lead exposure to humans after EPA](https://www.pnas.org/doi/10.1073/pnas.2525498123)<!-- HN:46870113:end --><!-- HN:46871251:start -->
* [46871251](https://news.social-protocols.org/stats?id=46871251) #18 18 points 2 comments -> [Show HN: Inverting Agent Model (App as Clients, Chat as Server and Reflection)](https://github.com/RAIL-Suite/RAIL)<!-- HN:46871251:end --><!-- HN:46874206:start -->
* [46874206](https://news.social-protocols.org/stats?id=46874206) #10 7 points 0 comments -> [Sonnet 5 (Full Text)](https://www.folger.edu/explore/shakespeares-works/shakespeares-sonnets/read/5/)<!-- HN:46874206:end --><!-- HN:46875125:start -->
* [46875125](https://news.social-protocols.org/stats?id=46875125) #14 11 points 0 comments -> [Have we tried asking women about the 'birth rate crisis' yet?](https://www.glamourmagazine.co.uk/article/falling-birth-rates-uk-feminist-solution)<!-- HN:46875125:end --><!-- HN:46837150:start -->
* [46837150](https://news.social-protocols.org/stats?id=46837150) #15 11 points 0 comments -> [I became a maintainer and all I got was a lousy perspective on librarianship](https://www.hughrundle.net/i-accidentally-became-a-foss-maintainer-and-all-i-got-was-this-lousy-new-perspective-on-librarianship/)<!-- HN:46837150:end --><!-- HN:46876347:start -->
* [46876347](https://news.social-protocols.org/stats?id=46876347) #21 33 points 16 comments -> [When rust ≠ performance. a lesson in developer experience](https://suriya.cc/tech/performance/oxen-add/)<!-- HN:46876347:end --><!-- HN:46872894:start -->
* [46872894](https://news.social-protocols.org/stats?id=46872894) #25 269 points 14 comments -> [X offices raided French prosecutors investigate child abuse images and deepfakes](https://apnews.com/article/france-x-investigation-seach-elon-musk-1116be84d84201011219086ecfd4e0bc)<!-- HN:46872894:end -->
#### **Wednesday, February 4, 2026**
<!-- HN:46878979:start -->
* [46878979](https://news.social-protocols.org/stats?id=46878979) #13 7 points 2 comments -> [TikTok System Design:(Step-by-Step Guide)](https://grokkingthesystemdesign.com/guides/tiktok-system-design/)<!-- HN:46878979:end --><!-- HN:46879078:start -->
* [46879078](https://news.social-protocols.org/stats?id=46879078) #22 28 points 5 comments -> [Valve wants to hold [patent troll] Leigh Rothschild personally liable](https://www.reporterbyte.com/news/10087/piercing-the-veil-why-valve-wants-to-hold-leigh-rothschild-personally-liable/)<!-- HN:46879078:end --><!-- HN:46880807:start -->
* [46880807](https://news.social-protocols.org/stats?id=46880807) #4 7 points 0 comments -> [A programmer's guide to leaving GitHub](https://lord.io/leaving-github/)<!-- HN:46880807:end --><!-- HN:46884481:start -->
* [46884481](https://news.social-protocols.org/stats?id=46884481) #4 14 points 13 comments -> [Anthropic Claude Max $200/mo: They claim 99% uptime, I calculated 84% Loss: $780](https://gist.github.com/LEX8888/0caac27b96fa164e2a8ac57e9a5f2365)<!-- HN:46884481:end --><!-- HN:46884595:start -->
* [46884595](https://news.social-protocols.org/stats?id=46884595) #19 28 points 29 comments -> [Your Job Isn't Disappearing. It's Shrinking Around You in Real Time](https://newsletter.jantegze.com/p/your-job-isnt-disappearing-its-shrinking)<!-- HN:46884595:end --><!-- HN:46887364:start -->
* [46887364](https://news.social-protocols.org/stats?id=46887364) #5 8 points 0 comments -> [Male students show more tolerance for political enemies than females for allies](https://expression.fire.org/p/male-students-show-more-tolerance)<!-- HN:46887364:end --><!-- HN:46888998:start -->
* [46888998](https://news.social-protocols.org/stats?id=46888998) #15 5 points 0 comments -> [Cracking the Clit (2017)](https://logicmag.io/sex/cracking-the-clit/)<!-- HN:46888998:end --><!-- HN:46889088:start -->
* [46889088](https://news.social-protocols.org/stats?id=46889088) #8 10 points 0 comments -> [Claude Code's /Insights](https://www.natemeyvis.com/claude-codes-insights/)<!-- HN:46889088:end --><!-- HN:46891584:start -->
* [46891584](https://news.social-protocols.org/stats?id=46891584) #9 10 points 7 comments -> [Disk Scout – Find the Cheapest SSDs Across Amazon](https://disk-scout.com/)<!-- HN:46891584:end --><!-- HN:46826803:start -->
* [46826803](https://news.social-protocols.org/stats?id=46826803) #8 127 points 69 comments -> [Yawning has an unexpected influence on the fluid inside your brain](https://www.newscientist.com/article/2513692-yawning-has-an-unexpected-influence-on-the-fluid-inside-your-brain/)<!-- HN:46826803:end --><!-- HN:46811812:start -->
* [46811812](https://news.social-protocols.org/stats?id=46811812) #12 49 points 6 comments -> [Litestream Writable VFS](https://fly.io/blog/litestream-writable-vfs/)<!-- HN:46811812:end -->
#### **Thursday, February 5, 2026**<!-- HN:46894971:start -->
* [46894971](https://news.social-protocols.org/stats?id=46894971) #23 7 points 0 comments -> [Toxic Truth: How Wikipedia Poisons Global Knowledge](https://ellakenan100.substack.com/p/toxic-truth-how-wikipedia-poisons)<!-- HN:46894971:end --><!-- HN:46893394:start -->
* [46893394](https://news.social-protocols.org/stats?id=46893394) #13 20 points 9 comments -> [We Used To Build Things. What Happened?](https://garryslist.org/posts/we-used-to-build-things-what-happened)<!-- HN:46893394:end --><!-- HN:46895170:start -->
* [46895170](https://news.social-protocols.org/stats?id=46895170) #2 24 points 2 comments -> [Resist and Unsubscribe](https://www.resistandunsubscribe.com)<!-- HN:46895170:end --><!-- HN:46895602:start -->
* [46895602](https://news.social-protocols.org/stats?id=46895602) #26 57 points 33 comments -> [Sam Altman Responds to Anthropic Ad Campaign](https://twitter.com/i/status/2019139174339928189)<!-- HN:46895602:end --><!-- HN:46897368:start -->
* [46897368](https://news.social-protocols.org/stats?id=46897368) #23 8 points 4 comments -> [QuitGPT – OpenAI Execs Are Trump's Biggest Donors](https://quitgpt.org/)<!-- HN:46897368:end --><!-- HN:46895950:start -->
* [46895950](https://news.social-protocols.org/stats?id=46895950) #9 30 points 40 comments -> [Study: Older Cannabis Users Have Larger Brains, Better Cognition](https://news.cuanschutz.edu/news-stories/study-finds-cannabis-usage-in-middle-aged-and-older-adults-associated-with-larger-brain-volume-better-cognitive-function)<!-- HN:46895950:end --><!-- HN:46898038:start -->
* [46898038](https://news.social-protocols.org/stats?id=46898038) #4 11 points 3 comments -> [Justice.gov JEE files contains bash manual](https://framapiaf.org/@bitecode/116014584956841267)<!-- HN:46898038:end --><!-- HN:46897210:start -->
* [46897210](https://news.social-protocols.org/stats?id=46897210) #27 38 points 40 comments -> [Valve's Steam Machine has been delayed, and the RAM crisis will impact pricing](https://www.theverge.com/games/874196/valve-steam-machine-frame-controller-delay-pricing-memory-crisis)<!-- HN:46897210:end --><!-- HN:46900161:start -->
* [46900161](https://news.social-protocols.org/stats?id=46900161) #3 36 points 44 comments -> [Fined $48k for using a jammer to keep commuters from using phones while driving](https://transition.fcc.gov/eb/Orders/2014/FCC-14-55A1.html)<!-- HN:46900161:end --><!-- HN:46902965:start -->
* [46902965](https://news.social-protocols.org/stats?id=46902965) #5 11 points 0 comments -> [Times New Resistance](https://www.abbyhaddican.com/times-new-resistance)<!-- HN:46902965:end --><!-- HN:46901974:start -->
* [46901974](https://news.social-protocols.org/stats?id=46901974) #30 32 points 40 comments -> [Everyone Is Stealing TV](https://www.theverge.com/streaming/873416/piracy-streaming-boxes)<!-- HN:46901974:end -->
#### **Friday, February 6, 2026**<!-- HN:46908531:start -->
* [46908531](https://news.social-protocols.org/stats?id=46908531) #30 8 points 6 comments -> [The $921M Special Interest Machine That Controls California](https://garryslist.org/posts/the-921m-special-interest-machine-that-controls-california)<!-- HN:46908531:end --><!-- HN:46845135:start -->
* [46845135](https://news.social-protocols.org/stats?id=46845135) #7 41 points 1 comments -> [Pong Cam – My ESP32S3 Thinks It's a WebCam](https://www.atomic14.com/2026/02/01/pong-cam)<!-- HN:46845135:end --><!-- HN:46845567:start -->
* [46845567](https://news.social-protocols.org/stats?id=46845567) #14 60 points 7 comments -> [Launching My Side Project as a Solo Dev: The Walkthrough](https://alt-romes.github.io/posts/2026-01-30-from-side-project-to-kickstarter-a-walkthrough.html)<!-- HN:46845567:end --><!-- HN:46844391:start -->
* [46844391](https://news.social-protocols.org/stats?id=46844391) #22 25 points 6 comments -> [You Still Struggle with CORS Even After Reading Docs](https://evan-moon.github.io/2020/05/21/about-cors/en/)<!-- HN:46844391:end --><!-- HN:46847297:start -->
* [46847297](https://news.social-protocols.org/stats?id=46847297) #24 159 points 39 comments -> [There Will Come Soft Rains (1950) [pdf]](https://www.btboces.org/Downloads/7_There%20Will%20Come%20Soft%20Rains%20by%20Ray%20Bradbury.pdf)<!-- HN:46847297:end --><!-- HN:46842090:start -->
* [46842090](https://news.social-protocols.org/stats?id=46842090) #25 39 points 13 comments -> [What's wrong with bunny hands on dinosaurs? (2018)](https://paleoaerie.org/2018/06/13/whats-wrong-with-bunny-hands-on-dinosaurs/)<!-- HN:46842090:end --><!-- HN:46845296:start -->
* [46845296](https://news.social-protocols.org/stats?id=46845296) #27 62 points 29 comments -> [OpenClaw: When AI Agents Get Full System Access. Security nightmare?](https://innfactory.ai:443/en/blog/openclaw-ai-agent-security/)<!-- HN:46845296:end --><!-- HN:46841897:start -->
* [46841897](https://news.social-protocols.org/stats?id=46841897) #28 139 points 24 comments -> [150 MB Minimal FreeBSD Installation](https://vermaden.wordpress.com/2026/02/01/150-mb-minimal-freebsd-installation/)<!-- HN:46841897:end --><!-- HN:46913201:start -->
* [46913201](https://news.social-protocols.org/stats?id=46913201) #4 46 points 40 comments -> [Wall Street just lost $285B because of 13 Markdown files](https://martinalderson.com/posts/wall-street-lost-285-billion-because-of-13-markdown-files/)<!-- HN:46913201:end --><!-- HN:46915035:start -->
* [46915035](https://news.social-protocols.org/stats?id=46915035) #27 10 points 6 comments -> [White House launches direct-to-consumer drug site TrumpRx](https://www.cnbc.com/2026/02/05/trump-rx-white-house-launches-direct-to-consumer-drug-site.html)<!-- HN:46915035:end -->
#### **Saturday, February 7, 2026**
<!-- HN:46920157:start -->
* [46920157](https://news.social-protocols.org/stats?id=46920157) #13 9 points 0 comments -> [Installing Ollama and Gemma 3B on Linux](https://byandrev.dev/en/blog/ollama-in-linux)<!-- HN:46920157:end --><!-- HN:46920922:start -->
* [46920922](https://news.social-protocols.org/stats?id=46920922) #27 30 points 14 comments -> [Hello world does not compile](https://github.com/anthropics/claudes-c-compiler/issues/1)<!-- HN:46920922:end --><!-- HN:46920954:start -->
* [46920954](https://news.social-protocols.org/stats?id=46920954) #17 9 points 4 comments -> [Make Trust Irrelevant: A Gamer's Take on Agentic AI Safety](https://github.com/Deso-PK/make-trust-irrelevant)<!-- HN:46920954:end --><!-- HN:46866937:start -->
* [46866937](https://news.social-protocols.org/stats?id=46866937) #4 112 points 17 comments -> [A century of hair samples proves leaded gas ban worked](https://arstechnica.com/science/2026/02/a-century-of-hair-samples-proves-leaded-gas-ban-worked/)<!-- HN:46866937:end --><!-- HN:46922912:start -->
* [46922912](https://news.social-protocols.org/stats?id=46922912) #22 4 points 3 comments -> [Watermark API – $0.01/image, 10x cheaper than Cloudinary](https://api-production-caa8.up.railway.app/docs)<!-- HN:46922912:end --><!-- HN:46923469:start -->
* [46923469](https://news.social-protocols.org/stats?id=46923469) #8 11 points 8 comments -> [Omarchy First Impressions](https://brianlovin.com/writing/omarchy-first-impressions-CEEstJk)<!-- HN:46923469:end --><!-- HN:46923520:start -->
* [46923520](https://news.social-protocols.org/stats?id=46923520) #27 5 points 1 comments -> [Reputation Scores for GitHub Accounts](https://shkspr.mobi/blog/2026/02/reputation-scores-for-github-accounts/)<!-- HN:46923520:end --><!-- HN:46924371:start -->
* [46924371](https://news.social-protocols.org/stats?id=46924371) #9 9 points 5 comments -> [Show HN: One-click AI employee with its own cloud desktop](https://cloudbot-ai.com)<!-- HN:46924371:end --><!-- HN:46925131:start -->
* [46925131](https://news.social-protocols.org/stats?id=46925131) #9 5 points 2 comments -> [Show HN: I'm 15 and built a free tool for reading ancient texts.](https://the-lexicon-project.netlify.app/)<!-- HN:46925131:end --><!-- HN:46924891:start -->
* [46924891](https://news.social-protocols.org/stats?id=46924891) #15 17 points 7 comments -> [What Is Stoicism?](https://stoacentral.com/guides/what-is-stoicism)<!-- HN:46924891:end --><!-- HN:46927661:start -->
* [46927661](https://news.social-protocols.org/stats?id=46927661) #4 9 points 2 comments -> [We have broken SHA-1 in practice](https://shattered.io/)<!-- HN:46927661:end -->
#### **Sunday, February 8, 2026**
<!-- HN:46868879:start -->
* [46868879](https://news.social-protocols.org/stats?id=46868879) #22 8 points 3 comments -> [Show HN: Browser based state machine simulator and visualizer](https://svylabs.github.io/smac-viz/)<!-- HN:46868879:end --><!-- HN:46930665:start -->
* [46930665](https://news.social-protocols.org/stats?id=46930665) #4 6 points 11 comments -> [Do you have a mathematically attractive face?](https://www.doimog.com)<!-- HN:46930665:end --><!-- HN:46928894:start -->
* [46928894](https://news.social-protocols.org/stats?id=46928894) #17 -> [GitBlack: Tracing America's Foundation](https://gitblack.vercel.app/)<!-- HN:46928894:end --><!-- HN:46931026:start -->
* [46931026](https://news.social-protocols.org/stats?id=46931026) #9 52 points 42 comments -> [Bye Bye Humanity: The Potential AMOC Collapse](https://thatjoescott.com/2026/02/03/bye-bye-humanity-the-potential-amoc-collapse/)<!-- HN:46931026:end --><!-- HN:46931805:start -->
* [46931805](https://news.social-protocols.org/stats?id=46931805) #4 21 points 34 comments -> [OpenClaw Is Changing My Life](https://reorx.com/blog/openclaw-is-changing-my-life/)<!-- HN:46931805:end --><!-- HN:46932010:start -->
* [46932010](https://news.social-protocols.org/stats?id=46932010) #2 6 points 4 comments -> [Turning books to courses using AI](https://www.book2course.org/)<!-- HN:46932010:end -->