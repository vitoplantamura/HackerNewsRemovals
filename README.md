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

#### **Tuesday, April 14, 2026**
<!-- HN:47757775:start -->
* [47757775](https://news.social-protocols.org/stats?id=47757775) #29 98 points 114 comments -> [The tech jobs bust is real. Don't blame AI (yet)](https://economist.com/finance-and-economics/2026/04/13/the-tech-jobs-bust-is-real-dont-blame-ai-yet)<!-- HN:47757775:end --><!-- HN:47759400:start -->
* [47759400](https://news.social-protocols.org/stats?id=47759400) #18 6 points 0 comments -> [SnapState - Persistent state for AI agent workflows](https://snapstate.dev)<!-- HN:47759400:end --><!-- HN:47757595:start -->
* [47757595](https://news.social-protocols.org/stats?id=47757595) #22 27 points 1 comments -> [Mathematical Minimalism](https://www.johndcook.com/blog/2026/04/13/the-smallest-math-library/)<!-- HN:47757595:end --><!-- HN:47760925:start -->
* [47760925](https://news.social-protocols.org/stats?id=47760925) #29 133 points 35 comments -> [Hacker compromises A16Z-backed phone farm, calling them the 'antichrist'](https://www.404media.co/hacker-compromises-a16z-backed-phone-farm-tries-to-post-memes-calling-a16z-the-antichrist/)<!-- HN:47760925:end --><!-- HN:47766960:start -->
* [47766960](https://news.social-protocols.org/stats?id=47766960) #2 44 points 12 comments -> [AI Will Never Be Ethical or Safe](https://meiert.com/blog/ai-ethics-and-safety/)<!-- HN:47766960:end --><!-- HN:47770330:start -->
* [47770330](https://news.social-protocols.org/stats?id=47770330) #7 7 points 1 comments -> [The cost of building a workflow editor on React Flow](https://www.workflowbuilder.io/blog/build-vs-buy-workflow-editor-hidden-cost-react-flow)<!-- HN:47770330:end --><!-- HN:47770400:start -->
* [47770400](https://news.social-protocols.org/stats?id=47770400) #18 2 points 2 comments -> [Show HN: Sk.illmd.com, a forum for talking about and showing off agent skills](https://skillmd.discourse.group/)<!-- HN:47770400:end --><!-- HN:47769967:start -->
* [47769967](https://news.social-protocols.org/stats?id=47769967) #16 119 points 2 comments -> [California ghost-gun bill wants 3D printers to play cop, EFF says](https://www.theregister.com/2026/04/14/eff_california_3dprinted_firearms/)<!-- HN:47769967:end --><!-- HN:47768195:start -->
* [47768195](https://news.social-protocols.org/stats?id=47768195) #6 388 points 366 comments -> [Spain to expand internet blocks to tennis, golf, movies broadcasting times](https://bandaancha.eu/articulos/telefonica-consigue-bloqueos-ips-11731)<!-- HN:47768195:end -->
#### **Wednesday, April 15, 2026**<!-- HN:47779856:start -->
* [47779856](https://news.social-protocols.org/stats?id=47779856) #18 28 points 41 comments -> [The Deepfake Nudes Crisis in Schools Is Worse Than You Thought](https://www.wired.com/story/deepfake-nudify-schools-global-crisis/)<!-- HN:47779856:end --><!-- HN:47778366:start -->
* [47778366](https://news.social-protocols.org/stats?id=47778366) #27 104 points 2 comments -> [US national level OS-level age verification bill](https://social.coop/@cwebber/116408556882122186)<!-- HN:47778366:end --><!-- HN:47783873:start -->
* [47783873](https://news.social-protocols.org/stats?id=47783873) #29 32 points 1 comments -> [Jury Finds Live Nation Acts as a Monopoly in a Victory for States](https://www.nytimes.com/2026/04/15/arts/music/live-nation-antitrust-trial-verdict-monopoly.html)<!-- HN:47783873:end --><!-- HN:47784060:start -->
* [47784060](https://news.social-protocols.org/stats?id=47784060) #19 9 points 2 comments -> [Show HN: Jeeves – TUI for browsing and resuming AI agent sessions](https://github.com/robinovitch61/jeeves)<!-- HN:47784060:end -->
#### **Thursday, April 16, 2026**
<!-- HN:47787368:start -->
* [47787368](https://news.social-protocols.org/stats?id=47787368) #22 53 points 9 comments -> [Amazon AI Cancelling Webcomics](http://www.kleefeldoncomics.com/2026/04/amazon-ai-cancelling-webcomics.html)<!-- HN:47787368:end --><!-- HN:47720941:start -->
* [47720941](https://news.social-protocols.org/stats?id=47720941) #16 17 points 6 comments -> [A Mercury Rover Could Explore the Planet by Sticking to the Terminator](https://www.universetoday.com/articles/a-mercury-rover-could-explore-the-planet-by-sticking-to-the-terminator)<!-- HN:47720941:end --><!-- HN:47788773:start -->
* [47788773](https://news.social-protocols.org/stats?id=47788773) #20 9 points 5 comments -> [AWS/GCP too expensive? Cloudexit.pro will help you move to bare-metal](https://cloudexit.pro/)<!-- HN:47788773:end --><!-- HN:47788857:start -->
* [47788857](https://news.social-protocols.org/stats?id=47788857) #10 93 points 61 comments -> [IPv8 Proposal](https://www.ietf.org/archive/id/draft-thain-ipv8-00.html)<!-- HN:47788857:end --><!-- HN:47791507:start -->
* [47791507](https://news.social-protocols.org/stats?id=47791507) #29 47 points 40 comments -> [The noise we make is hurting animals. Can we learn to shut up?](https://www.technologyreview.com/2026/04/16/1135179/anthropogenic-noise-hurting-animals/)<!-- HN:47791507:end --><!-- HN:47793493:start -->
* [47793493](https://news.social-protocols.org/stats?id=47793493) #2 163 points 86 comments -> [Claude Opus 4.7](https://www.anthropic.com/claude/opus)<!-- HN:47793493:end --><!-- HN:47795152:start -->
* [47795152](https://news.social-protocols.org/stats?id=47795152) #30 9 points 0 comments -> [Armed Off-Duty Cop Tried to Incite Violence at a High School Anti-ICE Protest](https://theintercept.com/2026/04/15/high-school-ice-protest-arizona-armed-cop/)<!-- HN:47795152:end --><!-- HN:47733059:start -->
* [47733059](https://news.social-protocols.org/stats?id=47733059) #4 104 points 37 comments -> [PCI Express over Fiber [video]](https://www.youtube.com/watch?v=XaDa9bBucEI)<!-- HN:47733059:end --><!-- HN:47736331:start -->
* [47736331](https://news.social-protocols.org/stats?id=47736331) #6 59 points 24 comments -> [TigerBeetle: A Trillion Transactions [video]](https://www.youtube.com/watch?v=y2_BqkKTbD8)<!-- HN:47736331:end --><!-- HN:47738520:start -->
* [47738520](https://news.social-protocols.org/stats?id=47738520) #12 92 points 84 comments -> [Put your SSH keys in your TPM chip](https://raymii.org/s/tutorials/Put_your_SSH_keys_in_your_TPM_chip.html)<!-- HN:47738520:end --><!-- HN:47737041:start -->
* [47737041](https://news.social-protocols.org/stats?id=47737041) #18 7 points 0 comments -> [How the Roll Function Works (In APL\360 and Its Descendants)](https://www.jsoftware.com/papers/roll.htm)<!-- HN:47737041:end -->
#### **Friday, April 17, 2026**
<!-- HN:47751608:start -->
* [47751608](https://news.social-protocols.org/stats?id=47751608) #22 12 points 10 comments -> [288,493 Requests – How I Spotted an XML-RPC Brute Force from a Weird Cache Ratio](https://marcindudek.dev/blog/xmlrpc-brute-force-cache-rate/)<!-- HN:47751608:end --><!-- HN:47803005:start -->
* [47803005](https://news.social-protocols.org/stats?id=47803005) #2 11 points 5 comments -> [First bikebell against noise-canceling headphones](https://www.welovecycling.com/wide/duobell/)<!-- HN:47803005:end --><!-- HN:47803477:start -->
* [47803477](https://news.social-protocols.org/stats?id=47803477) #5 13 points 40 comments -> [How to make buffet breakfasts less wasteful](https://www.economist.com/science-and-technology/2026/04/14/how-to-make-buffet-breakfasts-less-wasteful)<!-- HN:47803477:end --><!-- HN:47805027:start -->
* [47805027](https://news.social-protocols.org/stats?id=47805027) #21 23 points 1 comments -> [Testosterone shifts political preferences in weakly affiliated Democratic men](https://www.psypost.org/scientists-discover-weak-dems-have-highest-testosterone-but-theres-an-intriguing-twist/)<!-- HN:47805027:end --><!-- HN:47747986:start -->
* [47747986](https://news.social-protocols.org/stats?id=47747986) #22 17 points 5 comments -> [Taking a Look at Compression Algorithms – Moncef Abboud](https://cefboud.com/posts/compression/)<!-- HN:47747986:end --><!-- HN:47742677:start -->
* [47742677](https://news.social-protocols.org/stats?id=47742677) #19 5 points 1 comments -> [Why "200 OK" does not mean your system worked](https://blog.bridgexapi.io/why-200-ok-does-not-mean-your-system-worked)<!-- HN:47742677:end --><!-- HN:47808343:start -->
* [47808343](https://news.social-protocols.org/stats?id=47808343) #12 4 points 0 comments -> [Claude Design](https://claude.ai/design)<!-- HN:47808343:end --><!-- HN:47808588:start -->
* [47808588](https://news.social-protocols.org/stats?id=47808588) #24 7 points 0 comments -> [xAI has Released Grok 4.3 (beta)](https://twitter.com/techdevnotes/status/2045072883206991973)<!-- HN:47808588:end --><!-- HN:47751830:start -->
* [47751830](https://news.social-protocols.org/stats?id=47751830) #22 69 points 39 comments -> [The Utopia of the Family Computer](https://mudmapmagazine.com/the-utopia-of-the-family-computer/)<!-- HN:47751830:end -->
#### **Saturday, April 18, 2026**
<!-- HN:47815269:start -->
* [47815269](https://news.social-protocols.org/stats?id=47815269) #14 58 points 14 comments -> [Flock Condemns False Child Predator Allegations, Yet Calls Critics Terrorists](https://ipvm.com/reports/flock-allegations-critics)<!-- HN:47815269:end --><!-- HN:47816514:start -->
* [47816514](https://news.social-protocols.org/stats?id=47816514) #7 7 points 3 comments -> [Show HN: Solyto – a free, open-source all-in-one personal management app](https://solyto.app)<!-- HN:47816514:end --><!-- HN:47817303:start -->
* [47817303](https://news.social-protocols.org/stats?id=47817303) #26 13 points 0 comments -> [White House probes wave of missing or dead American scientists](https://www.foxnews.com/video/6393235356112)<!-- HN:47817303:end --><!-- HN:47817902:start -->
* [47817902](https://news.social-protocols.org/stats?id=47817902) #18 15 points 2 comments -> [Headless Everything for Personal AI](https://interconnected.org/home/2026/04/18/headless)<!-- HN:47817902:end --><!-- HN:47817555:start -->
* [47817555](https://news.social-protocols.org/stats?id=47817555) #24 9 points 3 comments -> [Rail: A self-hosting language that speaks TLS alone](https://github.com/zemo-g/rail)<!-- HN:47817555:end --><!-- HN:47820071:start -->
* [47820071](https://news.social-protocols.org/stats?id=47820071) #10 3 points 1 comments -> [What Is Llms.txt and Does Your Business Need One?](https://semarkglobal.com/blog/what-is-llms-txt-does-your-business-need-one)<!-- HN:47820071:end -->
#### **Sunday, April 19, 2026**
<!-- HN:47756320:start -->
* [47756320](https://news.social-protocols.org/stats?id=47756320) #28 138 points 72 comments -> [Brunost: The Nynorsk Programming Language](https://lindbakk.com/blog/introducing-brunost)<!-- HN:47756320:end --><!-- HN:47822375:start -->
* [47822375](https://news.social-protocols.org/stats?id=47822375) #9 3 points 0 comments -> [Android 15's hidden Linux Terminal is a real Debian VM – and it runs Claude Code](https://github.com/JoJa84/Codefone)<!-- HN:47822375:end --><!-- HN:47824105:start -->
* [47824105](https://news.social-protocols.org/stats?id=47824105) #24 11 points 2 comments -> [Turning Point USA Is Expanding Its Reach to K-12 Schools](https://www.edweek.org/policy-politics/how-charlie-kirks-turning-point-usa-is-expanding-its-reach-to-k-12-schools/2025/09)<!-- HN:47824105:end --><!-- HN:47824038:start -->
* [47824038](https://news.social-protocols.org/stats?id=47824038) #16 -> [The EU digital ID wallet can't deliver the privacy properties it claims](https://github.com/eu-digital-identity-wallet/av-doc-technical-specification/issues/26)<!-- HN:47824038:end --><!-- HN:47824832:start -->
* [47824832](https://news.social-protocols.org/stats?id=47824832) #14 16 points 1 comments -> [Discord Read Receipts Exploit: When, How Often, How Long](https://paul.koeck.dev/writeups/discord-read-receipts)<!-- HN:47824832:end --><!-- HN:47825432:start -->
* [47825432](https://news.social-protocols.org/stats?id=47825432) #11 7 points 1 comments -> [543 Hours: What happens when AI runs while you sleep](https://michael.roth.rocks/research/543-hours/)<!-- HN:47825432:end --><!-- HN:47826473:start -->
* [47826473](https://news.social-protocols.org/stats?id=47826473) #11 24 points 1 comments -> [Europe has 'maybe six weeks of jet fuel left'](https://www.bbc.com/news/articles/czjw2kz0l22o)<!-- HN:47826473:end --><!-- HN:47825590:start -->
* [47825590](https://news.social-protocols.org/stats?id=47825590) #21 8 points 4 comments -> [Gender reassignment significantly increases psychiatric morbidity](https://onlinelibrary.wiley.com/doi/10.1111/apa.70533)<!-- HN:47825590:end --><!-- HN:47824976:start -->
* [47824976](https://news.social-protocols.org/stats?id=47824976) #1 375 points 2 comments -> [Vercel Says Internal Systems Hit in Breach](https://decipher.sc/2026/04/19/vercel-says-internal-systems-hit-in-breach/)<!-- HN:47824976:end --><!-- HN:47827424:start -->
* [47827424](https://news.social-protocols.org/stats?id=47827424) #8 5 points 0 comments -> [Islamic Medicine (2018)](https://hekint.org/2018/11/19/islamic-medicine/)<!-- HN:47827424:end -->
#### **Monday, April 20, 2026**<!-- HN:47829015:start -->
* [47829015](https://news.social-protocols.org/stats?id=47829015) #28 -> [Canada's PM calls economic ties with US a weakness that must be corrected](https://abcnews.com/Business/wireStory/canadas-prime-minister-economic-ties-us-weakness-corrected-132187806)<!-- HN:47829015:end --><!-- HN:47829800:start -->
* [47829800](https://news.social-protocols.org/stats?id=47829800) #17 37 points 9 comments -> [Anthropic installs spyware when you install Claude Desktop](https://www.thatprivacyguy.com/blog/anthropic-spyware/)<!-- HN:47829800:end --><!-- HN:47830234:start -->
* [47830234](https://news.social-protocols.org/stats?id=47830234) #4 5 points 0 comments -> [Anthropic installs spyware when you install Claude Desktop](https://blog.alexewerlof.com/p/local-browser-ai)<!-- HN:47830234:end --><!-- HN:47830534:start -->
* [47830534](https://news.social-protocols.org/stats?id=47830534) #3 7 points 0 comments -> [DIDs Are Cool. We Didn't Need Them](https://www.inamoon.com/blog/dids-vs-subjects)<!-- HN:47830534:end --><!-- HN:47829757:start -->
* [47829757](https://news.social-protocols.org/stats?id=47829757) #18 12 points 2 comments -> [Contra Benn Jordan, data center (and all) sub-audible infrasound issues are fake](https://blog.andymasley.com/p/contra-benn-jordan-data-center-and)<!-- HN:47829757:end --><!-- HN:47766185:start -->
* [47766185](https://news.social-protocols.org/stats?id=47766185) #23 18 points 7 comments -> [Recovering Windows Live Writer Files](https://benovermyer.com/blog/2026/04/recovering-windows-live-writer-files/)<!-- HN:47766185:end --><!-- HN:47831499:start -->
* [47831499](https://news.social-protocols.org/stats?id=47831499) #30 42 points 11 comments -> [Tracking when Trump chickens out](https://www.thetacotracker.com/)<!-- HN:47831499:end --><!-- HN:47833156:start -->
* [47833156](https://news.social-protocols.org/stats?id=47833156) #1 249 points 116 comments -> [Tesla Hid Fatal Accidents to Continue Testing Autonomous Driving (French)](https://www.rts.ch/info/monde/2026/article/tesla-dissimule-des-milliers-d-incidents-de-conduite-autonome-mortels-29214161.html)<!-- HN:47833156:end --><!-- HN:47838969:start -->
* [47838969](https://news.social-protocols.org/stats?id=47838969) #11 6 points 1 comments -> [Outrage over Israeli soldier's vandalism of Jesus statue in Lebanon](https://www.bbc.com/news/articles/cpd575n1znzo)<!-- HN:47838969:end --><!-- HN:47838178:start -->
* [47838178](https://news.social-protocols.org/stats?id=47838178) #21 75 points 20 comments -> [The Palantir's Stasi Protocols](https://professorsigmund.com/praxis/palantir-stasi-protocols.html)<!-- HN:47838178:end -->