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
* [46928894](https://news.social-protocols.org/stats?id=46928894) #17 -> [GitBlack: Tracing America's Foundation](https://gitblack.vercel.app/)<!-- HN:46928894:end --><!-- HN:46932010:start -->
* [46932010](https://news.social-protocols.org/stats?id=46932010) #2 6 points 4 comments -> [Turning books to courses using AI](https://www.book2course.org/)<!-- HN:46932010:end --><!-- HN:46931948:start -->
* [46931948](https://news.social-protocols.org/stats?id=46931948) #27 127 points 33 comments -> [The world heard JD Vance being booed at the Olympics. Except for viewers in USA](https://www.theguardian.com/sport/2026/feb/07/jd-vance-boos-winter-olympics)<!-- HN:46931948:end --><!-- HN:46934190:start -->
* [46934190](https://news.social-protocols.org/stats?id=46934190) #1 3 points 0 comments -> [Show HN: I built a festival tracker that matches lineups to your music library](https://apps.apple.com/us/app/festiveo-music-festivals/id6755355854)<!-- HN:46934190:end --><!-- HN:46935980:start -->
* [46935980](https://news.social-protocols.org/stats?id=46935980) #1 174 points 39 comments -> [Vouch](https://github.com/mitchellh/vouch)<!-- HN:46935980:end --><!-- HN:46937543:start -->
* [46937543](https://news.social-protocols.org/stats?id=46937543) #5 5 points 0 comments -> [Show HN: The biggest achievement of my life so far](https://github.com/adityaprasad-sudo/Explore-Singapore)<!-- HN:46937543:end --><!-- HN:46868272:start -->
* [46868272](https://news.social-protocols.org/stats?id=46868272) #12 20 points 3 comments -> [International Image Interoperability Framework](https://iiif.io/)<!-- HN:46868272:end --><!-- HN:46857115:start -->
* [46857115](https://news.social-protocols.org/stats?id=46857115) #14 64 points 5 comments -> [Formally Verifying PBS Kids with Lean4](https://www.shadaj.me/writing/cyberchase-lean)<!-- HN:46857115:end --><!-- HN:46870117:start -->
* [46870117](https://news.social-protocols.org/stats?id=46870117) #25 11 points 0 comments -> [SpiceDB Query Planner](https://authzed.com/blog/introducing-spicedb-query-planner)<!-- HN:46870117:end --><!-- HN:46859433:start -->
* [46859433](https://news.social-protocols.org/stats?id=46859433) #28 60 points 12 comments -> [Kolakoski Sequence](https://en.wikipedia.org/wiki/Kolakoski_sequence)<!-- HN:46859433:end --><!-- HN:46888128:start -->
* [46888128](https://news.social-protocols.org/stats?id=46888128) #13 12 points 0 comments -> [The Muppets are horny and weird again (just like Jim Henson intended)](https://www.polygon.com/the-muppet-show-disney-special-review/)<!-- HN:46888128:end -->
#### **Monday, February 9, 2026**
<!-- HN:46940088:start -->
* [46940088](https://news.social-protocols.org/stats?id=46940088) #6 6 points 1 comments -> [Tenure Is a Total Scam](https://www.betonit.ai/p/tenure-is-a-total-scam)<!-- HN:46940088:end --><!-- HN:46941323:start -->
* [46941323](https://news.social-protocols.org/stats?id=46941323) #4 8 points 1 comments -> [Accountability for ICE and CBP](https://www.doomsdayscenario.co/p/accountability-for-ice-and-cbp)<!-- HN:46941323:end --><!-- HN:46892105:start -->
* [46892105](https://news.social-protocols.org/stats?id=46892105) #11 10 points 0 comments -> [Lessons from BF-Tree: Building a Concurrent Larger-Than-Memory Index in Rust](https://zhihanz.github.io/posts/bf-tree-rust-implementation/)<!-- HN:46892105:end --><!-- HN:46943865:start -->
* [46943865](https://news.social-protocols.org/stats?id=46943865) #3 21 points 4 comments -> [Is the author of pdf-lib okay?](https://github.com/Hopding/pdf-lib)<!-- HN:46943865:end --><!-- HN:46899833:start -->
* [46899833](https://news.social-protocols.org/stats?id=46899833) #20 9 points 0 comments -> [Werewolf Vflex Adapter Review](https://hagensieker.com/2026/02/05/werewolf-vflex-adapter-review/)<!-- HN:46899833:end --><!-- HN:46946603:start -->
* [46946603](https://news.social-protocols.org/stats?id=46946603) #21 7 points 2 comments -> [Safe Drinking Water Is a Basic Human Right That Texas Prisons Fail to Respect](https://truthout.org/articles/safe-drinking-water-is-a-basic-human-right-that-texas-prisons-fail-to-respect/)<!-- HN:46946603:end --><!-- HN:46948148:start -->
* [46948148](https://news.social-protocols.org/stats?id=46948148) #7 15 points 1 comments -> [Irish man detained by ICE fearing for his life in Texas detention centre](https://www.thesun.ie/news/16511082/seamus-culleton-ice-hell-trump/)<!-- HN:46948148:end --><!-- HN:46946872:start -->
* [46946872](https://news.social-protocols.org/stats?id=46946872) #25 254 points 3 comments -> [GitHub Is Down](https://github.com/)<!-- HN:46946872:end --><!-- HN:46949198:start -->
* [46949198](https://news.social-protocols.org/stats?id=46949198) #8 10 points 4 comments -> [State of Ruby 2026](https://devnewsletter.com/p/state-of-ruby-2026/)<!-- HN:46949198:end --><!-- HN:46949291:start -->
* [46949291](https://news.social-protocols.org/stats?id=46949291) #23 22 points 2 comments -> [This Whistle Fights Fascists](https://www.theverge.com/policy/874959/3d-printed-whistles-for-ice-minneapolis-chicago-renee-good-alex-pretti)<!-- HN:46949291:end -->
#### **Tuesday, February 10, 2026**
<!-- HN:46954714:start -->
* [46954714](https://news.social-protocols.org/stats?id=46954714) #26 -> [Trump threatens to block opening of US-Canada bridge](https://www.bbc.com/news/articles/cpw052pkvl0o)<!-- HN:46954714:end --><!-- HN:46954875:start -->
* [46954875](https://news.social-protocols.org/stats?id=46954875) #5 9 points 1 comments -> [I woke up to 77 pull requests. None of them were from a human](https://zachwills.net/building-at-the-speed-of-thought/)<!-- HN:46954875:end --><!-- HN:46955032:start -->
* [46955032](https://news.social-protocols.org/stats?id=46955032) #8 8 points 2 comments -> [America isn't exceptional – it's the exception](https://www.not-ship.com/america-isnt-exceptional-its-the-exception/)<!-- HN:46955032:end --><!-- HN:46878373:start -->
* [46878373](https://news.social-protocols.org/stats?id=46878373) #8 122 points 18 comments -> [How I've run major projects (2025)](https://www.benkuhn.net/pjm/)<!-- HN:46878373:end --><!-- HN:46889027:start -->
* [46889027](https://news.social-protocols.org/stats?id=46889027) #14 13 points 12 comments -> [I made an open-source juypter alternative](https://github.com/DannyMang/more-compute)<!-- HN:46889027:end --><!-- HN:46892205:start -->
* [46892205](https://news.social-protocols.org/stats?id=46892205) #19 12 points 6 comments -> [Richard F. Burton: On the English adventurer and writer](https://thelampmagazine.com/issues/issue-32/richard-f-burton)<!-- HN:46892205:end --><!-- HN:46877291:start -->
* [46877291](https://news.social-protocols.org/stats?id=46877291) #22 118 points 11 comments -> [Information Is Beautiful](https://informationisbeautiful.net/)<!-- HN:46877291:end --><!-- HN:46890174:start -->
* [46890174](https://news.social-protocols.org/stats?id=46890174) #24 112 points 20 comments -> [F# 10](https://devblogs.microsoft.com/dotnet/introducing-fsharp-10/)<!-- HN:46890174:end --><!-- HN:46957495:start -->
* [46957495](https://news.social-protocols.org/stats?id=46957495) #5 18 points 0 comments -> [ICE is pushing readers to nonprofit news sites that cover immigrant communities](https://www.niemanlab.org/2026/02/ice-activity-is-pushing-readers-to-nonprofit-news-sites-that-cover-immigrant-communities/)<!-- HN:46957495:end --><!-- HN:46958597:start -->
* [46958597](https://news.social-protocols.org/stats?id=46958597) #6 -> [Show HN: Pipelock – All-in-one security harness for AI coding agents](https://github.com/luckyPipewrench/pipelock)<!-- HN:46958597:end --><!-- HN:46959067:start -->
* [46959067](https://news.social-protocols.org/stats?id=46959067) #3 63 points 37 comments -> [Australian author's erotic novel is child sex abuse material, judge finds](https://www.bbc.com/news/articles/ckgzv529v5no)<!-- HN:46959067:end --><!-- HN:46958760:start -->
* [46958760](https://news.social-protocols.org/stats?id=46958760) #23 10 points 1 comments -> [Bitchat – decentralized peer-to-peer messaging](https://en.wikipedia.org/wiki/Bitchat)<!-- HN:46958760:end --><!-- HN:46959764:start -->
* [46959764](https://news.social-protocols.org/stats?id=46959764) #4 11 points 12 comments -> [74% of European firms would fail without access to U.S. technology](https://europeancorrespondent.com/en/r/trumps-power-switch)<!-- HN:46959764:end --><!-- HN:46963892:start -->
* [46963892](https://news.social-protocols.org/stats?id=46963892) #10 13 points 5 comments -> [The SaaSpocalypse – The week AI killed software](https://www.fintechbrainfood.com/p/the-saaspocalypse)<!-- HN:46963892:end -->
#### **Wednesday, February 11, 2026**
<!-- HN:46934187:start -->
* [46934187](https://news.social-protocols.org/stats?id=46934187) #11 6 points 0 comments -> [Ship Types, Not Docs](https://shiptypes.com/)<!-- HN:46934187:end --><!-- HN:46904710:start -->
* [46904710](https://news.social-protocols.org/stats?id=46904710) #12 8 points 1 comments -> [Computer Chronicles: AI (1984-1998)](https://computerchronicles.tv/#collection/ai)<!-- HN:46904710:end --><!-- HN:46973565:start -->
* [46973565](https://news.social-protocols.org/stats?id=46973565) #26 8 points 3 comments -> [Tech workers are frustrated by their companies silence about ICE](https://www.theverge.com/ai-artificial-intelligence/876558/tech-workers-ice-resistance-google-microsoft-clear-abbott)<!-- HN:46973565:end --><!-- HN:46973011:start -->
* [46973011](https://news.social-protocols.org/stats?id=46973011) #24 7 points 0 comments -> [Something Big Is Happening](https://shumer.dev/something-big-is-happening)<!-- HN:46973011:end --><!-- HN:46973849:start -->
* [46973849](https://news.social-protocols.org/stats?id=46973849) #14 9 points 0 comments -> [The Torture Will Continue Until Shareholder Value Improves [video]](https://www.youtube.com/watch?v=NIXd3PEbsNk)<!-- HN:46973849:end --><!-- HN:46974999:start -->
* [46974999](https://news.social-protocols.org/stats?id=46974999) #1 59 points 26 comments -> [Who Smeared Feynman](https://blog.nuclearsecrecy.com/2014/07/11/smeared-richard-feynman/)<!-- HN:46974999:end --><!-- HN:46976123:start -->
* [46976123](https://news.social-protocols.org/stats?id=46976123) #25 6 points 1 comments -> [EPA to repeal its own conclusion that greenhouse gases warm the planet](https://www.nbcnews.com/science/climate-change/epa-to-repeal-endangerment-finding-climate-change-emissions-rcna258250)<!-- HN:46976123:end --><!-- HN:46981354:start -->
* [46981354](https://news.social-protocols.org/stats?id=46981354) #20 10 points 0 comments -> [ICE Is Crashing the US Court System in Minnesota](https://www.wired.com/story/ice-crashing-us-court-system-minnesota/)<!-- HN:46981354:end --><!-- HN:46917005:start -->
* [46917005](https://news.social-protocols.org/stats?id=46917005) #7 88 points 30 comments -> [Single bone in Spain offers first direct evidence of Hannibal's war elephants](https://phys.org/news/2026-02-hannibal-famous-war-elephants-bone.html)<!-- HN:46917005:end --><!-- HN:46913062:start -->
* [46913062](https://news.social-protocols.org/stats?id=46913062) #8 27 points 2 comments -> [Switzerland's Extraordinary Medieval Library](https://www.bbc.com/travel/article/20260202-inside-switzerlands-extraordinary-medieval-library)<!-- HN:46913062:end --><!-- HN:46909279:start -->
* [46909279](https://news.social-protocols.org/stats?id=46909279) #13 336 points 62 comments -> [It's all a blur](https://lcamtuf.substack.com/p/its-all-a-blur)<!-- HN:46909279:end --><!-- HN:46913747:start -->
* [46913747](https://news.social-protocols.org/stats?id=46913747) #28 16 points 4 comments -> [Show HN: Hibana – An Affine MPST Runtime for Rust](https://hibanaworks.dev)<!-- HN:46913747:end --><!-- HN:46913489:start -->
* [46913489](https://news.social-protocols.org/stats?id=46913489) #30 296 points 294 comments -> [Lessons you will learn living in a snowy place](https://eukaryotewritesblog.com/2026/01/21/very-snowy-place/)<!-- HN:46913489:end --><!-- HN:46982240:start -->
* [46982240](https://news.social-protocols.org/stats?id=46982240) #22 10 points 1 comments -> [Hacker News now thinks coding is solved](https://old.reddit.com/r/BetterOffline/comments/1qynmuc/hacker_news_now_thinks_coding_is_solved/)<!-- HN:46982240:end --><!-- HN:46977210:start -->
* [46977210](https://news.social-protocols.org/stats?id=46977210) #2 371 points 199 comments -> [GLM-5: From Vibe Coding to Agentic Engineering](https://z.ai/blog/glm-5)<!-- HN:46977210:end -->
#### **Thursday, February 12, 2026**
<!-- HN:46982762:start -->
* [46982762](https://news.social-protocols.org/stats?id=46982762) #22 14 points 1 comments -> [Rare, dangerous side effects of some Covid-19 vaccines explained](https://www.science.org/content/article/rare-dangerous-side-effects-some-covid-19-vaccines-explained)<!-- HN:46982762:end --><!-- HN:46984799:start -->
* [46984799](https://news.social-protocols.org/stats?id=46984799) #14 17 points 10 comments -> [GLM-5 was trained entirely on Huawei chips](https://glm5.net/)<!-- HN:46984799:end --><!-- HN:46976443:start -->
* [46976443](https://news.social-protocols.org/stats?id=46976443) #13 365 points 170 comments -> [Why Vampires Live Forever](https://machielreyneke.com/blog/vampires-longevity/)<!-- HN:46976443:end --><!-- HN:46986064:start -->
* [46986064](https://news.social-protocols.org/stats?id=46986064) #18 9 points 4 comments -> [Show HN: Huesnatch – 6 free color tools for designers, no login, no uploads](https://github.com/huesnatch/huesnatch)<!-- HN:46986064:end --><!-- HN:46987524:start -->
* [46987524](https://news.social-protocols.org/stats?id=46987524) #4 39 points 4 comments -> [Resist and Unsubscribe](https://www.resistandunsubscribe.com)<!-- HN:46987524:end --><!-- HN:46934901:start -->
* [46934901](https://news.social-protocols.org/stats?id=46934901) #19 4 points 0 comments -> [Put Your Reputation on the Deadline (2023)](https://taylor.town/reputation-deadline)<!-- HN:46934901:end --><!-- HN:46988035:start -->
* [46988035](https://news.social-protocols.org/stats?id=46988035) #7 3 points 4 comments -> [Did HN just censor the Resist and Unsubscribe story?](https://www.resistandunsubscribe.com)<!-- HN:46988035:end --><!-- HN:46940959:start -->
* [46940959](https://news.social-protocols.org/stats?id=46940959) #17 9 points 1 comments -> [Quitting](https://thepointmag.com/examined-life/quitting/)<!-- HN:46940959:end --><!-- HN:46986614:start -->
* [46986614](https://news.social-protocols.org/stats?id=46986614) #21 22 points 40 comments -> [Show HN: A free online British accent generator for instant voice conversion](https://audioconvert.ai/british-accent-generator)<!-- HN:46986614:end --><!-- HN:46988928:start -->
* [46988928](https://news.social-protocols.org/stats?id=46988928) #29 33 points 8 comments -> [I Regret to Inform You That the FDA Is FDAing Again](https://marginalrevolution.com/marginalrevolution/2026/02/i-regret-to-inform-you-that-the-fda-is-still-fdaing.html)<!-- HN:46988928:end --><!-- HN:46989379:start -->
* [46989379](https://news.social-protocols.org/stats?id=46989379) #12 37 points 23 comments -> [Kim Jong Un chooses teen daughter as heir](https://www.bbc.com/news/articles/cn0e1g7kwglo)<!-- HN:46989379:end --><!-- HN:46987038:start -->
* [46987038](https://news.social-protocols.org/stats?id=46987038) #24 38 points 40 comments -> [Show HN: Geo Racers – Race from London to Tokyo on a single bus pass](https://geo-racers.com/)<!-- HN:46987038:end -->