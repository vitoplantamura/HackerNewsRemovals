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

#### **Monday, March 3, 2025**
<!-- HN:43235933:start -->
* [43235933](https://news.social-protocols.org/stats?id=43235933) #1 78 points 9 comments -> [Firefly Aerospace Becomes First Commercial Company to Successfully Land on Moon](https://fireflyspace.com/news/firefly-aerospace-becomes-first-commercial-company-to-successfully-land-on-the-moon/)<!-- HN:43235933:end --><!-- HN:43239249:start -->
* [43239249](https://news.social-protocols.org/stats?id=43239249) #17 307 points 394 comments -> [The top 10% owns 87% of the stocks](https://awealthofcommonsense.com/2025/02/the-top-10/)<!-- HN:43239249:end --><!-- HN:43205209:start -->
* [43205209](https://news.social-protocols.org/stats?id=43205209) #23 18 points 2 comments -> [Show HN: Free Kindle Scribe Weekly Planner Creator](https://tools.docgenie.co.uk/)<!-- HN:43205209:end --><!-- HN:43240354:start -->
* [43240354](https://news.social-protocols.org/stats?id=43240354) #15 38 points 30 comments -> [Difficult Employees (and How to Handle Them)](https://newsletter.canopy.is/p/the-5-most-difficult-employees-and)<!-- HN:43240354:end --><!-- HN:43244106:start -->
* [43244106](https://news.social-protocols.org/stats?id=43244106) #15 16 points 3 comments -> [The Oldest "Map of America" Is Mysteriously Accurate](https://www.thetravel.com/oldest-american-map-accuracy-surprises-experts/)<!-- HN:43244106:end -->
#### **Tuesday, March 4, 2025**
<!-- HN:43248796:start -->
* [43248796](https://news.social-protocols.org/stats?id=43248796) #29 4 points 0 comments -> [Show HN: Interview Coder is an invisible AI to solve any coding problem](https://www.interviewcoder.co)<!-- HN:43248796:end --><!-- HN:43210114:start -->
* [43210114](https://news.social-protocols.org/stats?id=43210114) #8 14 points 5 comments -> [I created an MVP for an AI SVG maker in a week! Check it out!](https://easysvg.ai)<!-- HN:43210114:end --><!-- HN:43252479:start -->
* [43252479](https://news.social-protocols.org/stats?id=43252479) #21 12 points 4 comments -> [Grok Is Having an Outage](https://status.x.ai/)<!-- HN:43252479:end --><!-- HN:43211101:start -->
* [43211101](https://news.social-protocols.org/stats?id=43211101) #6 89 points 25 comments -> [Ohio One Construction Timeline Update](https://newsroom.intel.com/corporate/ohio-one-construction-timeline-update)<!-- HN:43211101:end --><!-- HN:43217165:start -->
* [43217165](https://news.social-protocols.org/stats?id=43217165) #8 65 points 23 comments -> [Salty game dev comments, easier mods are in Command and Conquer's source code](https://arstechnica.com/gaming/2025/02/command-conquer-source-release-promises-more-mods-and-updates-for-rts-legend/)<!-- HN:43217165:end --><!-- HN:43253407:start -->
* [43253407](https://news.social-protocols.org/stats?id=43253407) #17 192 points 253 comments -> [Italy moves to reverse anti-nuclear stance](https://www.world-nuclear-news.org/articles/cabinet-moves-to-reverse-italys-anti-nuclear-stance)<!-- HN:43253407:end --><!-- HN:43253562:start -->
* [43253562](https://news.social-protocols.org/stats?id=43253562) #21 231 points 219 comments -> [Federal workers ordered to return to offices without desks, Wi-Fi and lights](https://www.cnn.com/2025/03/04/politics/federal-employees-return-to-office-problems/index.html)<!-- HN:43253562:end --><!-- HN:43245235:start -->
* [43245235](https://news.social-protocols.org/stats?id=43245235) #30 277 points 605 comments -> [How the U.K. broke its own economy](https://www.theatlantic.com/ideas/archive/2025/03/uk-needs-abundance/681877/)<!-- HN:43245235:end --><!-- HN:43256389:start -->
* [43256389](https://news.social-protocols.org/stats?id=43256389) #26 10 points 1 comments -> [Ontario to Slap Export Tax on Electricity to U.S.](https://www.wsj.com/livecoverage/trump-tariffs-canada-mexico-china-stock-market-today-03-04-2025/card/ontario-to-slap-export-tax-on-electricity-to-u-s--jlR92HoSLMWlYIWcvab1)<!-- HN:43256389:end --><!-- HN:43207962:start -->
* [43207962](https://news.social-protocols.org/stats?id=43207962) #8 36 points 16 comments -> [The Meter, Golden Ratio, Pyramids, and Cubits, Oh My](https://www.iforgeiron.com/topic/60514-the-meter-golden-ratio-pyramids-and-cubits-oh-my/)<!-- HN:43207962:end --><!-- HN:43253167:start -->
* [43253167](https://news.social-protocols.org/stats?id=43253167) #15 81 points 27 comments -> [How Google tracks Android device users before they've even opened an app](https://www.theregister.com/2025/03/04/google_android/)<!-- HN:43253167:end --><!-- HN:43257468:start -->
* [43257468](https://news.social-protocols.org/stats?id=43257468) #21 5 points 0 comments -> [China to build 'deep-sea space station' 6,000ft below surface](https://oceanographicmagazine.com/news/china-to-build-deep-sea-space-station-6000-feet-below-surface/)<!-- HN:43257468:end --><!-- HN:43257436:start -->
* [43257436](https://news.social-protocols.org/stats?id=43257436) #8 18 points 12 comments -> [Farallon Islands live (and controllable) webcam](https://www.calacademy.org/webcams/farallones)<!-- HN:43257436:end --><!-- HN:43258678:start -->
* [43258678](https://news.social-protocols.org/stats?id=43258678) #30 4 points 0 comments -> [I replaced my entire tech stack with Postgres [video]](https://www.youtube.com/watch?v=3JW732GrMdg)<!-- HN:43258678:end --><!-- HN:43259250:start -->
* [43259250](https://news.social-protocols.org/stats?id=43259250) #18 8 points 0 comments -> [Arc‑AGI Without Pretraining](https://twitter.com/LiaoIsaac91893/status/1896944891319742499)<!-- HN:43259250:end --><!-- HN:43259292:start -->
* [43259292](https://news.social-protocols.org/stats?id=43259292) #20 7 points 0 comments -> [Oil drilling in the mouth of the Amazon – Lula on a course to disaster](https://news.mongabay.com/2025/02/oil-drilling-in-the-mouth-of-the-amazon-lula-on-a-course-to-disaster-commentary/)<!-- HN:43259292:end --><!-- HN:43259279:start -->
* [43259279](https://news.social-protocols.org/stats?id=43259279) #21 12 points 4 comments -> [Economic and Market Data Signal a Recession Is Coming](https://www.forbes.com/sites/mayrarodriguezvalladares/2025/03/04/economic-and-market-data-signal-a-recession-is-coming/)<!-- HN:43259279:end --><!-- HN:43259329:start -->
* [43259329](https://news.social-protocols.org/stats?id=43259329) #22 6 points 1 comments -> [GTA 3 on a Volumetric Display [video]](https://www.youtube.com/watch?v=onYH5gvlnzE)<!-- HN:43259329:end --><!-- HN:43257883:start -->
* [43257883](https://news.social-protocols.org/stats?id=43257883) #29 4 points 1 comments -> ["Free Software": An idea whose time has passed](https://r0ml.medium.com/free-software-an-idea-whose-time-has-passed-6570c1d8218a)<!-- HN:43257883:end --><!-- HN:43259899:start -->
* [43259899](https://news.social-protocols.org/stats?id=43259899) #11 15 points 2 comments -> [Some D0g3 Staffers Are Drawing Six-Figure Government Salaries](https://www.wired.com/story/doge-government-salaries-elon-musk/)<!-- HN:43259899:end --><!-- HN:43259742:start -->
* [43259742](https://news.social-protocols.org/stats?id=43259742) #7 22 points 3 comments -> [AI: Where in the Loop Should Humans Go?](https://www.honeycomb.io/blog/ai-where-in-the-loop-should-humans-go)<!-- HN:43259742:end --><!-- HN:43213819:start -->
* [43213819](https://news.social-protocols.org/stats?id=43213819) #14 31 points 40 comments -> [Micro keypad to do your regular Git push/pull/add/commit actions](https://www.gitsyncpad.xyz/)<!-- HN:43213819:end --><!-- HN:43248947:start -->
* [43248947](https://news.social-protocols.org/stats?id=43248947) #29 191 points 21 comments -> [DeepSeek's smallpond: Bringing Distributed Computing to DuckDB](https://mehdio.substack.com/p/duckdb-goes-distributed-deepseeks)<!-- HN:43248947:end -->
#### **Wednesday, March 5, 2025**
<!-- HN:43261629:start -->
* [43261629](https://news.social-protocols.org/stats?id=43261629) #20 9 points 0 comments -> [Groceries in the U.S. remain expensive; more states want to stop taxing them](https://apnews.com/article/grocery-tax-arkansas-mississippi-tennessee-alabama-547de604a971480d5d15cce4519c04e4)<!-- HN:43261629:end --><!-- HN:43261899:start -->
* [43261899](https://news.social-protocols.org/stats?id=43261899) #1 127 points 28 comments -> [Trump's 'Crypto Reserve' Is Such Brazen Corruption](https://zeteo.com/p/trumps-crypto-reserve-is-such-brazen)<!-- HN:43261899:end --><!-- HN:43232188:start -->
* [43232188](https://news.social-protocols.org/stats?id=43232188) #15 28 points 4 comments -> [An small microbial ecosystem has formed on the International Space Station](https://arstechnica.com/science/2025/03/the-space-station-is-nearly-as-microbe-free-as-an-isolation-ward/)<!-- HN:43232188:end --><!-- HN:43265912:start -->
* [43265912](https://news.social-protocols.org/stats?id=43265912) #5 2 points 0 comments -> [Intelligent Life May Be Hiding in the Moons](https://nautil.us/intelligent-life-may-be-hiding-in-the-moons-1194315/)<!-- HN:43265912:end --><!-- HN:43266020:start -->
* [43266020](https://news.social-protocols.org/stats?id=43266020) #26 5 points 0 comments -> [DOGE's Misplaced War on Software Licenses](https://www.wired.com/story/doge-software-license-cancel-federal-budget/)<!-- HN:43266020:end --><!-- HN:43265568:start -->
* [43265568](https://news.social-protocols.org/stats?id=43265568) #28 13 points 1 comments -> [Tesla Sales Plunge in Germany, Reflecting Broader Slump in Europe](https://www.nytimes.com/2025/03/05/business/tesla-germany-sales-elon-musk.html)<!-- HN:43265568:end --><!-- HN:43266071:start -->
* [43266071](https://news.social-protocols.org/stats?id=43266071) #26 28 points 10 comments -> [The Big Government Contracts Doge Hasn't Touched](https://www.nytimes.com/interactive/2025/03/04/upshot/doge-musk-contracts-cuts.html)<!-- HN:43266071:end --><!-- HN:43265955:start -->
* [43265955](https://news.social-protocols.org/stats?id=43265955) #26 102 points 121 comments -> [Who's Afraid of Peter Thiel? A New Biography Suggests We All Should Be (2021)](https://time.com/6092844/peter-thiel-power-biography-the-contrarian/)<!-- HN:43265955:end --><!-- HN:43265794:start -->
* [43265794](https://news.social-protocols.org/stats?id=43265794) #16 58 points 37 comments -> [They wanted to save us from a dark AI future. Then six people were killed](https://www.theguardian.com/global/ng-interactive/2025/mar/05/zizians-artificial-intelligence)<!-- HN:43265794:end --><!-- HN:43266608:start -->
* [43266608](https://news.social-protocols.org/stats?id=43266608) #26 6 points 3 comments -> [I built an extension that lets you extract text from anywhere to your clipboard](https://chromewebstore.google.com/detail/esticra/nenfeobdiiiblnnlfoadbjabdeochjmn?hl=en)<!-- HN:43266608:end --><!-- HN:43267520:start -->
* [43267520](https://news.social-protocols.org/stats?id=43267520) #26 3 points 0 comments -> [Delivering what's needed to make Europe sovereign](https://netzpolitik.org/2025/open-source-funding-on-the-brink-delivering-whats-needed-to-make-europe-sovereign/)<!-- HN:43267520:end --><!-- HN:43226546:start -->
* [43226546](https://news.social-protocols.org/stats?id=43226546) #24 68 points 109 comments -> [The INTERNET is killing old PC hardware [video]](https://www.youtube.com/watch?v=TE_ePuGAvPM)<!-- HN:43226546:end --><!-- HN:43223930:start -->
* [43223930](https://news.social-protocols.org/stats?id=43223930) #27 89 points 42 comments -> [BMW Group Product Catalog–Historic Models](https://www.bmwgroup-classic.com/en/history/historic-modeloverview-bmw.html)<!-- HN:43223930:end --><!-- HN:43235671:start -->
* [43235671](https://news.social-protocols.org/stats?id=43235671) #19 3 points 0 comments -> [Understand the Joule Thief Circuit](https://electronics.stackexchange.com/questions/358135/understand-the-joule-thief-circuit)<!-- HN:43235671:end --><!-- HN:43268333:start -->
* [43268333](https://news.social-protocols.org/stats?id=43268333) #8 8 points 1 comments -> [Tech and Non-Tech Stacks to Run Listen Notes (2025)](https://www.listennotes.fm/p/tech-and-non-tech-stacks-to-run-listen)<!-- HN:43268333:end --><!-- HN:43270090:start -->
* [43270090](https://news.social-protocols.org/stats?id=43270090) #23 6 points 0 comments -> [Due to new tariffs, many more physical game discs may "simply not get made"](https://arstechnica.com/gaming/2025/03/thanks-to-new-tariffs-many-more-physical-game-discs-may-simply-not-get-made/)<!-- HN:43270090:end -->
#### **Thursday, March 6, 2025**
<!-- HN:43272607:start -->
* [43272607](https://news.social-protocols.org/stats?id=43272607) #25 29 points 40 comments -> [Superintelligence Strategy](https://www.nationalsecurity.ai/)<!-- HN:43272607:end --><!-- HN:43275343:start -->
* [43275343](https://news.social-protocols.org/stats?id=43275343) #17 4 points 1 comments -> [Warrior Jesus and a Letter from Luigi](https://ashelby.substack.com/p/warrior-jesus-and-a-letter-from-luigi)<!-- HN:43275343:end --><!-- HN:43228841:start -->
* [43228841](https://news.social-protocols.org/stats?id=43228841) #21 8 points 2 comments -> [Encrypt Images Without a Key Using Visual Cryptography](https://github.com/coduri/VisualCrypto)<!-- HN:43228841:end --><!-- HN:43276843:start -->
* [43276843](https://news.social-protocols.org/stats?id=43276843) #25 163 points 65 comments -> [The Authoritarian Regime Survival Guide](https://verfassungsblog.de/the-authoritarian-regime-survival-guide/)<!-- HN:43276843:end --><!-- HN:43278705:start -->
* [43278705](https://news.social-protocols.org/stats?id=43278705) #1 302 points 88 comments -> [Buy European Made. Support European Values](https://www.buy-european-made.eu/)<!-- HN:43278705:end --><!-- HN:43278852:start -->
* [43278852](https://news.social-protocols.org/stats?id=43278852) #6 5 points 0 comments -> [Is Social Security a Ponzi Scheme?](https://marginalrevolution.com/marginalrevolution/2025/03/is-social-security-a-ponzi-scheme-2.html)<!-- HN:43278852:end --><!-- HN:43278880:start -->
* [43278880](https://news.social-protocols.org/stats?id=43278880) #15 37 points 32 comments -> [Now there are two Chinese automakers on the top list](https://daoinsights.com/news/now-there-are-two-chinese-automakers-on-the-worlds-top-10-list/)<!-- HN:43278880:end --><!-- HN:43280135:start -->
* [43280135](https://news.social-protocols.org/stats?id=43280135) #27 8 points 0 comments -> [Job Cuts Surge on Doge Actions, Retail Woes; Highest Monthly Total Since 2020](https://www.challengergray.com/blog/job-cuts-surge-on-doge-actions-retail-woes-highest-monthly-total-since-july-2020/)<!-- HN:43280135:end --><!-- HN:43274821:start -->
* [43274821](https://news.social-protocols.org/stats?id=43274821) #20 575 points 344 comments -> [The US stops sharing air quality data from embassies worldwide](https://apnews.com/article/us-air-quality-monitors-8270927bbd0f166238243ac9d14bce03)<!-- HN:43274821:end --><!-- HN:43279574:start -->
* [43279574](https://news.social-protocols.org/stats?id=43279574) #14 5 points 0 comments -> [[flagged] Buy European Made. Support European Values](https://news.ycombinator.com/item?id=43278705)<!-- HN:43279574:end --><!-- HN:43279528:start -->
* [43279528](https://news.social-protocols.org/stats?id=43279528) #26 -> [Israel creating GPT-like tool using collection of Palestinian surveillance data](https://www.theguardian.com/world/2025/mar/06/israel-military-ai-surveillance)<!-- HN:43279528:end --><!-- HN:43281417:start -->
* [43281417](https://news.social-protocols.org/stats?id=43281417) #4 13 points 1 comments -> [Job Cuts Surge on Doge Actions, Retail Woes; Highest Monthly Since July 2020](https://www.challengergray.com/blog/job-cuts-surge-on-doge-actions-retail-woes-highest-monthly-total-since-july-2020/)<!-- HN:43281417:end --><!-- HN:43277924:start -->
* [43277924](https://news.social-protocols.org/stats?id=43277924) #21 153 points 96 comments -> [Forget Twitter Threads; Write a Blog Post Instead (2021)](https://kevquirk.com/blog/forget-twitter-threads-write-a-blog-post-instead)<!-- HN:43277924:end --><!-- HN:43246403:start -->
* [43246403](https://news.social-protocols.org/stats?id=43246403) #14 28 points 40 comments -> [Windows Is Free for Business (2008)](https://davegutteridge.com/windows_is_free_for_business)<!-- HN:43246403:end --><!-- HN:43234183:start -->
* [43234183](https://news.social-protocols.org/stats?id=43234183) #18 5 points 2 comments -> [Mercury astronaut had to beg controllers for permission to pee](https://idlewords.com/shepard_pee.htm)<!-- HN:43234183:end --><!-- HN:43282892:start -->
* [43282892](https://news.social-protocols.org/stats?id=43282892) #24 104 points 4 comments -> [UK quietly scrubs encryption advice from government websites](https://techcrunch.com/2025/03/06/uk-quietly-scrubs-encryption-advice-from-government-websites/)<!-- HN:43282892:end --><!-- HN:43282489:start -->
* [43282489](https://news.social-protocols.org/stats?id=43282489) #25 43 points 4 comments -> [Mistral OCR](https://mistral.ai/news/mistral-ocr)<!-- HN:43282489:end --><!-- HN:43239573:start -->
* [43239573](https://news.social-protocols.org/stats?id=43239573) #30 17 points 2 comments -> [IoT project using thermal sensors to monitor spaces](https://s2.dev/blog/iot)<!-- HN:43239573:end --><!-- HN:43284359:start -->
* [43284359](https://news.social-protocols.org/stats?id=43284359) #12 12 points 2 comments -> [Model pickers are a UX failure](https://www.augmentcode.com/blog/ai-model-pickers-are-a-design-failure-not-a-feature)<!-- HN:43284359:end --><!-- HN:43285234:start -->
* [43285234](https://news.social-protocols.org/stats?id=43285234) #16 4 points 0 comments -> [Show HN: Stealth Interview – Undetectable Interview AI](https://www.stealthinterview.ai)<!-- HN:43285234:end -->
#### **Friday, March 7, 2025**
<!-- HN:43286864:start -->
* [43286864](https://news.social-protocols.org/stats?id=43286864) #24 7 points 2 comments -> [Hacked firm demanded journalist 'take down' breach reporting, citing UK court](https://techcrunch.com/2025/03/06/hacked-health-firm-hcrg-demanded-journalist-take-down-data-breach-reporting-citing-uk-court-order/)<!-- HN:43286864:end --><!-- HN:43288164:start -->
* [43288164](https://news.social-protocols.org/stats?id=43288164) #23 28 points 40 comments -> [40% of Britons haven't read a single book in the last 12 months](https://yougov.co.uk/entertainment/articles/51730-40-of-britons-havent-read-a-single-book-in-the-last-12-months)<!-- HN:43288164:end --><!-- HN:43288341:start -->
* [43288341](https://news.social-protocols.org/stats?id=43288341) #21 26 points 40 comments -> [Google begins testing AI-only search results](https://arstechnica.com/google/2025/03/google-is-expanding-ai-overviews-and-testing-ai-only-search-results/)<!-- HN:43288341:end --><!-- HN:43289226:start -->
* [43289226](https://news.social-protocols.org/stats?id=43289226) #25 -> [Meta, Google, and Salesforce announce major layoffs in 2025](https://www.indmoney.com/blog/us-stocks/meta-google-salesforce-announce-layoffs-2025)<!-- HN:43289226:end --><!-- HN:43289022:start -->
* [43289022](https://news.social-protocols.org/stats?id=43289022) #11 22 points 21 comments -> [How often are children genetically unrelated to their presumed fathers?](https://www.science.org/content/article/how-often-are-children-genetically-unrelated-their-presumed-fathers)<!-- HN:43289022:end --><!-- HN:43245361:start -->
* [43245361](https://news.social-protocols.org/stats?id=43245361) #28 23 points 9 comments -> [Show HN: I built a Matrix themed AI hacking game](https://matrix.repello.ai)<!-- HN:43245361:end --><!-- HN:43253069:start -->
* [43253069](https://news.social-protocols.org/stats?id=43253069) #12 14 points 10 comments -> [What if football championships were lineal?](https://www.ufnc.xyz/)<!-- HN:43253069:end --><!-- HN:43289641:start -->
* [43289641](https://news.social-protocols.org/stats?id=43289641) #29 5 points 3 comments -> [Else Considered Smelly](https://wiki.c2.com/?ElseConsideredSmelly)<!-- HN:43289641:end --><!-- HN:43290066:start -->
* [43290066](https://news.social-protocols.org/stats?id=43290066) #16 4 points 0 comments -> [China Tests First Oblique Detonation Engine](https://www.china-arms.com/2025/02/china-tests-oblique-detonation-engine/)<!-- HN:43290066:end --><!-- HN:43289842:start -->
* [43289842](https://news.social-protocols.org/stats?id=43289842) #29 8 points 0 comments -> [Social media does 'more harm than good'](https://www.lbc.co.uk/tech/social-media-ban-kids-children-uk/)<!-- HN:43289842:end --><!-- HN:43290187:start -->
* [43290187](https://news.social-protocols.org/stats?id=43290187) #12 4 points 0 comments -> ['Fake Satoshi' Dr Craig Wright hit with costs bill over AI evidence](https://www.lawgazette.co.uk/news/fake-satoshi-hit-with-costs-bill-over-ai-evidence/5122587.article)<!-- HN:43290187:end --><!-- HN:43291247:start -->
* [43291247](https://news.social-protocols.org/stats?id=43291247) #24 6 points 0 comments -> [Female brewers are back – 500 years since their heyday](https://www.telegraph.co.uk/food-and-drink/beer/female-brewers-are-back/)<!-- HN:43291247:end --><!-- HN:43293113:start -->
* [43293113](https://news.social-protocols.org/stats?id=43293113) #30 6 points 0 comments -> [Poland must look at acquiring nuclear weapons, says Donald Tus](https://www.ft.com/content/c2845e81-befa-4b97-bb46-34037368d9f2)<!-- HN:43293113:end --><!-- HN:43293517:start -->
* [43293517](https://news.social-protocols.org/stats?id=43293517) #17 7 points 1 comments -> [Kennedy and influencers bash seed oils, baffling nutrition scientists](https://apnews.com/article/seed-oil-beef-tallow-kennedy-4fdf0f30134277fd6dd20b4ede789295)<!-- HN:43293517:end --><!-- HN:43293573:start -->
* [43293573](https://news.social-protocols.org/stats?id=43293573) #7 41 points 22 comments -> [The Take It Down Act isn't a law, it's a weapon](https://www.theverge.com/policy/624974/take-it-down-act-deepfakes-nonconsensual-pornography-trump-constitutional-crisis)<!-- HN:43293573:end --><!-- HN:43293562:start -->
* [43293562](https://news.social-protocols.org/stats?id=43293562) #21 14 points 1 comments -> [Broadcom has won. 70 percent of large VMware customers bought its biggest bundle](https://www.theregister.com/2025/03/07/broadcom_q1_fy2025/)<!-- HN:43293562:end --><!-- HN:43293852:start -->
* [43293852](https://news.social-protocols.org/stats?id=43293852) #27 5 points 0 comments -> [Chatbots Convinced Idiots They Cracked the Code on a Sculpture in CIA's Backyard](https://gizmodo.com/chatbots-have-convinced-idiots-that-they-cracked-the-code-on-a-mysterious-sculpture-in-the-cias-backyard-2000573216)<!-- HN:43293852:end --><!-- HN:43292805:start -->
* [43292805](https://news.social-protocols.org/stats?id=43292805) #26 47 points 34 comments -> [Cliff Asness: The New 'Crypto Fort Knox' Is as Dumb as It Sounds](https://www.thefp.com/p/trumps-crypto-fort-knox)<!-- HN:43292805:end --><!-- HN:43295006:start -->
* [43295006](https://news.social-protocols.org/stats?id=43295006) #28 13 points 1 comments -> [Musk/DOGE efforts to sell off civil rights historical site](https://www.alreporter.com/2025/03/06/historic-montgomery-bus-station-freedom-riders-museum-part-of-doge-ordered-sell-off/)<!-- HN:43295006:end --><!-- HN:43295164:start -->
* [43295164](https://news.social-protocols.org/stats?id=43295164) #16 14 points 5 comments -> [We found a DOGE guy at NASA because his Google Calendar was public](https://www.businessinsider.com/doge-nasa-google-calendar-public-2025-3)<!-- HN:43295164:end --><!-- HN:43294848:start -->
* [43294848](https://news.social-protocols.org/stats?id=43294848) #28 5 points 0 comments -> [Gene Hackman died of heart disease, his wife died of hantavirus 1 week earlier](https://www.wfsb.com/2025/03/07/investigation-advances-into-gene-hackmans-mysterious-death-with-update-by-authorities/)<!-- HN:43294848:end -->
#### **Saturday, March 8, 2025**
<!-- HN:43296131:start -->
* [43296131](https://news.social-protocols.org/stats?id=43296131) #17 12 points 1 comments -> ['Elon killed my resale': Bay Area Tesla owners using stickers to avoid backlash](https://www.sfchronicle.com/bayarea/article/tesla-elon-musk-backlash-20206901.php)<!-- HN:43296131:end --><!-- HN:43251868:start -->
* [43251868](https://news.social-protocols.org/stats?id=43251868) #10 17 points 40 comments -> [The German language broke my website](https://speedbumpapp.com/en/blog/german-translation/)<!-- HN:43251868:end --><!-- HN:43297671:start -->
* [43297671](https://news.social-protocols.org/stats?id=43297671) #21 20 points 4 comments -> [It is hard to recommend Python in production](https://ashishb.net/programming/python-in-production/)<!-- HN:43297671:end --><!-- HN:43297168:start -->
* [43297168](https://news.social-protocols.org/stats?id=43297168) #25 8 points 1 comments -> [Exploring the Hybrid Debian GNU/KFreeBSD Distribution](https://www.linuxjournal.com/content/exploring-hybrid-debian-gnukfreebsd-distribution)<!-- HN:43297168:end --><!-- HN:43296886:start -->
* [43296886](https://news.social-protocols.org/stats?id=43296886) #10 103 points 21 comments -> [Take It Down Act: A Flawed Attempt to Protect Victims That'll Lead to Censorship](https://www.eff.org/deeplinks/2025/02/take-it-down-act-flawed-attempt-protect-victims-will-lead-censorship)<!-- HN:43296886:end --><!-- HN:43296765:start -->
* [43296765](https://news.social-protocols.org/stats?id=43296765) #28 12 points 0 comments -> [Revenge Font](https://revengefont.com/)<!-- HN:43296765:end --><!-- HN:43259146:start -->
* [43259146](https://news.social-protocols.org/stats?id=43259146) #12 16 points 1 comments -> [2025-03-01 the cold glow of tritium](https://computer.rip/2025-03-01-the-cold-glow-of-tritium.html)<!-- HN:43259146:end --><!-- HN:43256878:start -->
* [43256878](https://news.social-protocols.org/stats?id=43256878) #23 18 points 4 comments -> [I hacked my company's SSO provider](https://mattsayar.com/how-i-hacked-my-companys-sso-provider/)<!-- HN:43256878:end --><!-- HN:43267232:start -->
* [43267232](https://news.social-protocols.org/stats?id=43267232) #17 8 points 2 comments -> [Show HN: AI art generation faster than Midjourney](https://www.gentube.app/?_cid=np)<!-- HN:43267232:end --><!-- HN:43266327:start -->
* [43266327](https://news.social-protocols.org/stats?id=43266327) #14 39 points 49 comments -> [Qualcomm Claims New X85 Modem Creates 'Huge Delta' in Performance versus Apple](https://www.macrumors.com/2025/03/05/qualcomm-claims-x85-modem-better-than-apple/)<!-- HN:43266327:end --><!-- HN:43226052:start -->
* [43226052](https://news.social-protocols.org/stats?id=43226052) #24 116 points 22 comments -> [Unleashed Recompiled: PC port of the Xbox 360 version of Sonic Unleashed](https://github.com/hedge-dev/UnleashedRecomp)<!-- HN:43226052:end --><!-- HN:43302097:start -->
* [43302097](https://news.social-protocols.org/stats?id=43302097) #5 175 points 2 comments -> [Google will still have to break up its business, the Justice Department said](https://www.engadget.com/big-tech/google-will-still-have-to-break-up-its-business-the-justice-department-said-150000739.html)<!-- HN:43302097:end --><!-- HN:43302563:start -->
* [43302563](https://news.social-protocols.org/stats?id=43302563) #26 14 points 2 comments -> [Linear Pluggable Optics Save Energy in Data Centers](https://semiengineering.com/linear-pluggable-optics-save-energy-in-data-centers/)<!-- HN:43302563:end --><!-- HN:43303943:start -->
* [43303943](https://news.social-protocols.org/stats?id=43303943) #22 15 points 7 comments -> [Backdoor detected in ESP32 Espressif IoT chip](https://www.tarlogic.com/news/backdoor-esp32-chip-infect-ot-devices/)<!-- HN:43303943:end --><!-- HN:43304253:start -->
* [43304253](https://news.social-protocols.org/stats?id=43304253) #4 6 points 0 comments -> [The Lie That Facebook Sold You](https://havenweb.org/2022/11/02/facebook-lie.html)<!-- HN:43304253:end -->
#### **Sunday, March 9, 2025**
<!-- HN:43304971:start -->
* [43304971](https://news.social-protocols.org/stats?id=43304971) #18 7 points 2 comments -> [Tesla Cybertruck Banned and Seized by Police in the U.K](https://www.forbes.com/sites/peterlyon/2025/02/20/tesla-cybertruck-banned-in-the-uk-due-to-safety-issues/)<!-- HN:43304971:end -->