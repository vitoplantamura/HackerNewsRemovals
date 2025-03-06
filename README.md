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

#### **Friday, February 28, 2025**
<!-- HN:43200179:start -->
* [43200179](https://news.social-protocols.org/stats?id=43200179) #14 5 points 0 comments -> [Tesla Powerwall 3 Alternatives](https://www.virtuesolar.com/2025/02/17/tesla-powerwall-3-alternatives/)<!-- HN:43200179:end --><!-- HN:43199460:start -->
* [43199460](https://news.social-protocols.org/stats?id=43199460) #4 250 points 3 comments -> [Some Command & Conquer games are now open source](https://github.com/electronicarts)<!-- HN:43199460:end --><!-- HN:43205100:start -->
* [43205100](https://news.social-protocols.org/stats?id=43205100) #26 9 points 1 comments -> ['I decided I was done':Canada pizzeria boycotts US ingredients in tariff dispute](https://www.theguardian.com/world/2025/feb/28/canada-pizzeria-owner-boycotts-us-products)<!-- HN:43205100:end --><!-- HN:43207338:start -->
* [43207338](https://news.social-protocols.org/stats?id=43207338) #6 26 points 2 comments -> [Hundreds in US climate agency fired in latest cuts](https://www.bbc.com/news/articles/cdell8n14x2o)<!-- HN:43207338:end --><!-- HN:43200450:start -->
* [43200450](https://news.social-protocols.org/stats?id=43200450) #17 193 points 19 comments -> [Markov Chains Explained Visually (2014)](https://setosa.io/ev/markov-chains/)<!-- HN:43200450:end --><!-- HN:43207491:start -->
* [43207491](https://news.social-protocols.org/stats?id=43207491) #6 20 points 0 comments -> [The full force of this administration's destruction is about to hit](https://www.thehandbasket.co/p/government-destruction-ssa-doge)<!-- HN:43207491:end --><!-- HN:43205196:start -->
* [43205196](https://news.social-protocols.org/stats?id=43205196) #26 95 points 151 comments -> [AMD RDNA 4 – AMD Radeon RX 9000 Series Graphics Cards](https://www.amd.com/en/newsroom/press-releases/2025-2-28-amd-unveils-next-generation-amd-rdna-4-architectu.html)<!-- HN:43205196:end --><!-- HN:43169461:start -->
* [43169461](https://news.social-protocols.org/stats?id=43169461) #21 317 points 230 comments -> [Spotify's Beta Used 'Pirate' MP3 Files, Some from Pirate Bay](https://torrentfreak.com/spotifys-beta-used-pirate-mp3-files-some-from-pirate-bay-170509/)<!-- HN:43169461:end --><!-- HN:43200065:start -->
* [43200065](https://news.social-protocols.org/stats?id=43200065) #24 792 points 6 comments -> [Mozilla owns "information you input through Firefox"](https://www.mozilla.org/en-US/about/legal/terms/firefox/)<!-- HN:43200065:end --><!-- HN:43210569:start -->
* [43210569](https://news.social-protocols.org/stats?id=43210569) #1 51 points 7 comments -> ["No, we are absolutely not prepared to [fork Firefox]"](https://codeberg.org/librewolf/issues/issues/2252#issuecomment-2886286)<!-- HN:43210569:end --><!-- HN:43211925:start -->
* [43211925](https://news.social-protocols.org/stats?id=43211925) #9 -> [Google's Sergey Brin: Engineers Should Work 60-Hour Weeks in Office to Build AI](https://gizmodo.com/googles-sergey-brin-says-engineers-should-work-60-hour-weeks-in-office-to-build-ai-that-could-replace-them-2000570025)<!-- HN:43211925:end --><!-- HN:43170457:start -->
* [43170457](https://news.social-protocols.org/stats?id=43170457) #23 18 points 9 comments -> [The Moped King](https://www.streetsblogprojects.org/fly-electric-bike-moped-new-york-city-streets-safety-lithium-ion-batteries)<!-- HN:43170457:end -->
#### **Saturday, March 1, 2025**
<!-- HN:43215769:start -->
* [43215769](https://news.social-protocols.org/stats?id=43215769) #29 6 points 0 comments -> [DeepSeek-V3/R1 Inference System Overview](https://github.com/deepseek-ai/open-infra-index/blob/main/202502OpenSourceWeek/day_6_one_more_thing_deepseekV3R1_inference_system_overview.md)<!-- HN:43215769:end --><!-- HN:43214294:start -->
* [43214294](https://news.social-protocols.org/stats?id=43214294) #3 305 points 68 comments -> [Self-Hosting a Firefox Sync Server](https://blog.diego.dev/posts/firefox-sync-server/)<!-- HN:43214294:end --><!-- HN:43219743:start -->
* [43219743](https://news.social-protocols.org/stats?id=43219743) #11 7 points 0 comments -> [HIV/AIDS deaths likely to soar after USAID promises broken](https://www.science.org/content/article/bloodbath-hiv-field-reeling-after-billions-u-s-funding-axed)<!-- HN:43219743:end --><!-- HN:43219616:start -->
* [43219616](https://news.social-protocols.org/stats?id=43219616) #27 8 points 9 comments -> [The Press Falls to Another Record Low in Public Trust](https://jonathanturley.org/2025/03/01/the-press-falls-to-another-record-low-in-public-trust/)<!-- HN:43219616:end --><!-- HN:43220426:start -->
* [43220426](https://news.social-protocols.org/stats?id=43220426) #16 5 points 0 comments -> [Coastal Economies Rely on NOAA, from Maine to Florida, Texas and Alaska](https://theconversation.com/coastal-economies-rely-on-noaa-from-maine-to-florida-texas-and-alaska-even-if-they-dont-realize-it-250016)<!-- HN:43220426:end --><!-- HN:43221543:start -->
* [43221543](https://news.social-protocols.org/stats?id=43221543) #4 59 points 37 comments -> [Open AI in Trouble](https://garymarcus.substack.com/p/openai-in-deep-trouble)<!-- HN:43221543:end --><!-- HN:43221685:start -->
* [43221685](https://news.social-protocols.org/stats?id=43221685) #7 32 points 43 comments -> [Why so many children in America have ADHD](https://www.economist.com/united-states/2025/02/20/why-so-many-children-in-america-have-adhd)<!-- HN:43221685:end --><!-- HN:43222653:start -->
* [43222653](https://news.social-protocols.org/stats?id=43222653) #24 6 points 0 comments -> [Is Donald Trump the Antichrist? A Bayesian Analysis](https://gist.github.com/ndbroadbent/cfaad426ef641e981cdea3642a3e45b1)<!-- HN:43222653:end --><!-- HN:43223209:start -->
* [43223209](https://news.social-protocols.org/stats?id=43223209) #17 5 points 0 comments -> [RFK Jr. issues rule barring public comment on HHS rulemaking](https://thehill.com/policy/healthcare/5170090-rfk-jr-hhs-public-comment-rulemaking-ends/)<!-- HN:43223209:end --><!-- HN:43223684:start -->
* [43223684](https://news.social-protocols.org/stats?id=43223684) #11 49 points 18 comments -> [China advises citizens specializing in AI to avoid traveling to America](https://www.saba.ye/en/news3445018.htm)<!-- HN:43223684:end -->
#### **Sunday, March 2, 2025**<!-- HN:43205642:start -->
* [43205642](https://news.social-protocols.org/stats?id=43205642) #15 10 points 0 comments -> [New footage shows sneaky killer is decapitating baby seals on California beaches](https://www.sfgate.com/local/article/coyotes-decapitating-seals-northern-california-20183166.php)<!-- HN:43205642:end --><!-- HN:43227131:start -->
* [43227131](https://news.social-protocols.org/stats?id=43227131) #17 7 points 10 comments -> [Show HN: What did you do last week? – Evaluates your 5 bullet points](https://whatdidyoudolastweek.biz)<!-- HN:43227131:end --><!-- HN:43182253:start -->
* [43182253](https://news.social-protocols.org/stats?id=43182253) #27 14 points 0 comments -> [The GitVenom campaign: cryptocurrency theft using GitHub](https://securelist.com/gitvenom-campaign/115694/)<!-- HN:43182253:end --><!-- HN:43230442:start -->
* [43230442](https://news.social-protocols.org/stats?id=43230442) #14 5 points 2 comments -> [Pubmed Has Been Deleted](https://pubmed.ncbi.nlm.nih.gov/)<!-- HN:43230442:end --><!-- HN:43230904:start -->
* [43230904](https://news.social-protocols.org/stats?id=43230904) #8 5 points 1 comments -> [Perun on "could Europe defend itself without US?"](https://www.youtube.com/watch?v=7giYIisLuaA)<!-- HN:43230904:end --><!-- HN:43231551:start -->
* [43231551](https://news.social-protocols.org/stats?id=43231551) #30 11 points 9 comments -> [I'm a neuroscientist. Here's the surprising truth about TikTok 'brain rot'](https://www.sciencefocus.com/comment/tiktok-braintot-psychologist-explains)<!-- HN:43231551:end --><!-- HN:43232841:start -->
* [43232841](https://news.social-protocols.org/stats?id=43232841) #15 27 points 13 comments -> [Falsehoods programmers believe about languages (localization)](https://www.lexiconista.com/falsehoods-about-languages/)<!-- HN:43232841:end --><!-- HN:43234281:start -->
* [43234281](https://news.social-protocols.org/stats?id=43234281) #30 18 points 4 comments -> [Brazilians hail strength of democracy as Bolsonaro is called to account](https://www.theguardian.com/world/2025/feb/19/brazil-jair-bolsonaro-coup)<!-- HN:43234281:end --><!-- HN:43235524:start -->
* [43235524](https://news.social-protocols.org/stats?id=43235524) #29 -> [Donald Trump supporters lose $12B after his meme coin collapses](https://www.uniladtech.com/news/tech-news/donald-trump-supporters-lose-12-billion-after-meme-coin-collapse-393345-20250228)<!-- HN:43235524:end --><!-- HN:43236182:start -->
* [43236182](https://news.social-protocols.org/stats?id=43236182) #15 11 points 1 comments -> [Stand Up for Science](https://standupforscience2025.org/)<!-- HN:43236182:end -->
#### **Monday, March 3, 2025**
<!-- HN:43235933:start -->
* [43235933](https://news.social-protocols.org/stats?id=43235933) #1 78 points 9 comments -> [Firefly Aerospace Becomes First Commercial Company to Successfully Land on Moon](https://fireflyspace.com/news/firefly-aerospace-becomes-first-commercial-company-to-successfully-land-on-the-moon/)<!-- HN:43235933:end --><!-- HN:43239249:start -->
* [43239249](https://news.social-protocols.org/stats?id=43239249) #17 307 points 394 comments -> [The top 10% owns 87% of the stocks](https://awealthofcommonsense.com/2025/02/the-top-10/)<!-- HN:43239249:end --><!-- HN:43205209:start -->
* [43205209](https://news.social-protocols.org/stats?id=43205209) #23 18 points 2 comments -> [Show HN: Free Kindle Scribe Weekly Planner Creator](https://tools.docgenie.co.uk/)<!-- HN:43205209:end --><!-- HN:43240354:start -->
* [43240354](https://news.social-protocols.org/stats?id=43240354) #15 38 points 30 comments -> [Difficult Employees (and How to Handle Them)](https://newsletter.canopy.is/p/the-5-most-difficult-employees-and)<!-- HN:43240354:end --><!-- HN:43244658:start -->
* [43244658](https://news.social-protocols.org/stats?id=43244658) #29 7 points 0 comments -> [Resurrecting a Windows Laptop](https://www.both.org/?p=9751)<!-- HN:43244658:end --><!-- HN:43244106:start -->
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
* [43278705](https://news.social-protocols.org/stats?id=43278705) #1 102 points 7 comments -> [Buy European Made. Support European Values](https://www.buy-european-made.eu/)<!-- HN:43278705:end -->