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
* [47838178](https://news.social-protocols.org/stats?id=47838178) #21 75 points 20 comments -> [The Palantir's Stasi Protocols](https://professorsigmund.com/praxis/palantir-stasi-protocols.html)<!-- HN:47838178:end --><!-- HN:47840570:start -->
* [47840570](https://news.social-protocols.org/stats?id=47840570) #2 50 points 1 comments -> [Tim Cook Stepping Down as Apple CEO, John Ternus Taking Over](https://techcrunch.com/2026/04/20/tim-cook-stepping-down-as-apple-ceo-john-ternus-taking-over/)<!-- HN:47840570:end -->
#### **Tuesday, April 21, 2026**
<!-- HN:47843573:start -->
* [47843573](https://news.social-protocols.org/stats?id=47843573) #21 10 points 3 comments -> [FreeBSD CVE-2026-4747 Log Suggests Mythos Is a Marketing Trick](https://www.flyingpenguin.com/freebsd-cve-2026-4747-log-suggests-mythos-is-a-marketing-trick/)<!-- HN:47843573:end --><!-- HN:47848110:start -->
* [47848110](https://news.social-protocols.org/stats?id=47848110) #17 -> [Show HN: Antenna – RSS reader with a built-in MCP server](https://antennafeed.com/)<!-- HN:47848110:end --><!-- HN:47822372:start -->
* [47822372](https://news.social-protocols.org/stats?id=47822372) #27 77 points 29 comments -> [Bullshit About Bullshit Machines [pdf]](https://aphyr.com/data/posts/411/the-future-of-everything-is-lies.pdf)<!-- HN:47822372:end --><!-- HN:47849018:start -->
* [47849018](https://news.social-protocols.org/stats?id=47849018) #21 9 points 1 comments -> [Zelensky says failure of US envoys to visit Kyiv is 'disrespectful'](https://www.bbc.com/news/articles/cd9v420y190o)<!-- HN:47849018:end --><!-- HN:47849131:start -->
* [47849131](https://news.social-protocols.org/stats?id=47849131) #27 5 points 0 comments -> [My University Hired a Terrorist](https://www.facultyleaks.com/p/my-university-hired-terrorist)<!-- HN:47849131:end --><!-- HN:47844431:start -->
* [47844431](https://news.social-protocols.org/stats?id=47844431) #27 272 points 145 comments -> [A Roblox cheat and one AI tool brought down Vercel's platform](https://webmatrices.com/post/how-a-roblox-cheat-and-one-ai-tool-brought-down-vercel-s-entire-platform)<!-- HN:47844431:end --><!-- HN:47789445:start -->
* [47789445](https://news.social-protocols.org/stats?id=47789445) #26 47 points 0 comments -> [Leonardo, Borgia, and Machiavelli: A Fateful Collusion](https://www.historytoday.com/archive/leonardo-borgia-and-machiavelli-fateful-collusion)<!-- HN:47789445:end --><!-- HN:47851242:start -->
* [47851242](https://news.social-protocols.org/stats?id=47851242) #24 47 points 10 comments -> [Meta to start capturing employee mouse movements, keystrokes for AI training](https://www.reuters.com/sustainability/boards-policy-regulation/meta-start-capturing-employee-mouse-movements-keystrokes-ai-training-data-2026-04-21/)<!-- HN:47851242:end -->
#### **Wednesday, April 22, 2026**
<!-- HN:47855616:start -->
* [47855616](https://news.social-protocols.org/stats?id=47855616) #9 102 points 41 comments -> [SpaceX Says It Has Agreement to Acquire Cursor for $60B](https://www.bloomberg.com/news/articles/2026-04-21/spacex-says-has-agreement-to-acquire-cursor-for-60-billion)<!-- HN:47855616:end --><!-- HN:47855448:start -->
* [47855448](https://news.social-protocols.org/stats?id=47855448) #15 96 points 69 comments -> [SpaceX Said to Agree to Buy Cursor for More Than $50B](https://www.nytimes.com/2026/04/21/business/spacex-cursor-deal.html)<!-- HN:47855448:end --><!-- HN:47858014:start -->
* [47858014](https://news.social-protocols.org/stats?id=47858014) #6 11 points 3 comments -> [OpenAI reinvents Recall except everything is stored remotely](https://developers.openai.com/codex/memories/chronicle)<!-- HN:47858014:end --><!-- HN:47860742:start -->
* [47860742](https://news.social-protocols.org/stats?id=47860742) #5 178 points 101 comments -> [Irony as Meta staff unhappy about running surveillance software on work PCs](https://www.theregister.com/2026/04/22/meta_employee_surveillance_software/)<!-- HN:47860742:end --><!-- HN:47860961:start -->
* [47860961](https://news.social-protocols.org/stats?id=47860961) #12 89 points 63 comments -> [Meta employees are up in arms over a mandatory program to train AI on their](https://www.businessinsider.com/meta-new-ai-tool-tracks-staff-activity-sparks-concern-2026-4)<!-- HN:47860961:end --><!-- HN:47863248:start -->
* [47863248](https://news.social-protocols.org/stats?id=47863248) #10 14 points 7 comments -> [Books Are Not Remotely Too Expensive](https://www.millersbookreview.com/p/no-books-are-not-remotely-too-expensive)<!-- HN:47863248:end --><!-- HN:47862608:start -->
* [47862608](https://news.social-protocols.org/stats?id=47862608) #4 64 points 8 comments -> [The eighth-generation TPU: An architecture deep dive](https://cloud.google.com/blog/products/compute/tpu-8t-and-tpu-8i-technical-deep-dive)<!-- HN:47862608:end --><!-- HN:47864566:start -->
* [47864566](https://news.social-protocols.org/stats?id=47864566) #8 8 points 1 comments -> [The best time to post on Hacker News](https://blog.alcazarsec.com/tech/posts/best-time-to-post-on-hacker-news)<!-- HN:47864566:end --><!-- HN:47864808:start -->
* [47864808](https://news.social-protocols.org/stats?id=47864808) #24 49 points 24 comments -> [Top MAGA influencer revealed to be AI](https://nypost.com/2026/04/21/us-news/top-maga-influencer-emily-hart-revealed-to-be-ai-created-by-a-guy-in-india/)<!-- HN:47864808:end --><!-- HN:47865432:start -->
* [47865432](https://news.social-protocols.org/stats?id=47865432) #8 6 points 1 comments -> [Windows 9x Subsystem for Linux](https://codeberg.org/hails/wsl9x)<!-- HN:47865432:end --><!-- HN:47865838:start -->
* [47865838](https://news.social-protocols.org/stats?id=47865838) #8 24 points 6 comments -> [The Tech Oligarch's Republic](https://www.forever-wars.com/the-tech-oligarchs-republic/)<!-- HN:47865838:end --><!-- HN:47870528:start -->
* [47870528](https://news.social-protocols.org/stats?id=47870528) #18 5 points 0 comments -> [Islam Is Not the Cause of Honor Killings. It's Part of the Solution](https://yaqeeninstitute.org/read/paper/islam-is-not-the-cause-of-honor-killings-its-part-of-the-solution)<!-- HN:47870528:end -->