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

#### **Tuesday, March 18, 2025**<!-- HN:43394099:start -->
* [43394099](https://news.social-protocols.org/stats?id=43394099) #22 21 points 3 comments -> [Sobering Revenue Stats of 70K Mobile Apps Show Why Devs Beg for Subscriptions](https://arstechnica.com/gadgets/2025/03/sobering-revenue-stats-of-70k-mobile-apps-show-why-devs-beg-for-subscriptions/)<!-- HN:43394099:end --><!-- HN:43393772:start -->
* [43393772](https://news.social-protocols.org/stats?id=43393772) #20 6 points 0 comments -> [A Farewell from Cosmo Music](https://cosmomusic.ca/)<!-- HN:43393772:end --><!-- HN:43393079:start -->
* [43393079](https://news.social-protocols.org/stats?id=43393079) #28 220 points 194 comments -> [Amazon plans to lay off 14,000 managerial positions to save $3.5B yearly](https://techstartups.com/2025/03/17/amazon-to-lay-off-14000-managerial-positions-to-save-3-5-billion-annually/)<!-- HN:43393079:end --><!-- HN:43392303:start -->
* [43392303](https://news.social-protocols.org/stats?id=43392303) #27 45 points 73 comments -> [Occupry your next lease to negotiate a better deal](https://occupry.com)<!-- HN:43392303:end --><!-- HN:43394554:start -->
* [43394554](https://news.social-protocols.org/stats?id=43394554) #5 35 points 12 comments -> [How Many Lives Does US Foreign Aid Save?](https://www.cgdev.org/blog/how-many-lives-does-us-foreign-aid-save)<!-- HN:43394554:end --><!-- HN:43394931:start -->
* [43394931](https://news.social-protocols.org/stats?id=43394931) #27 4 points 0 comments -> [Webb Just Captured the First Direct Image of Carbon Dioxide on an Exoplanet](https://scitechdaily.com/webb-just-captured-the-first-direct-image-of-carbon-dioxide-on-an-exoplanet/)<!-- HN:43394931:end --><!-- HN:43395360:start -->
* [43395360](https://news.social-protocols.org/stats?id=43395360) #25 -> [Israel ends Gaza ceasefire. 86 Palestinians killed in minutes](https://www.cnn.com/world/live-news/gaza-israel-hamas-strikes-03-18-25/index.html)<!-- HN:43395360:end --><!-- HN:43378076:start -->
* [43378076](https://news.social-protocols.org/stats?id=43378076) #26 4 points 2 comments -> [Using Time Travel for Procrastination](https://medium.com/luminasticity/using-time-travel-for-procrastination-8c8ab4d0de4d)<!-- HN:43378076:end --><!-- HN:43397896:start -->
* [43397896](https://news.social-protocols.org/stats?id=43397896) #27 4 points 0 comments -> [At least 404 killed as Israel unleashes strikes on Gaza, breaking ceasefire](https://www.aljazeera.com/news/2025/3/18/israel-launches-gaza-assault-killing-hundreds-and-shattering-ceasefire)<!-- HN:43397896:end --><!-- HN:43398374:start -->
* [43398374](https://news.social-protocols.org/stats?id=43398374) #2 8 points 0 comments -> [Mistral AI is a research lab building the best open source models in the world](https://docs.mistral.ai/)<!-- HN:43398374:end --><!-- HN:43396808:start -->
* [43396808](https://news.social-protocols.org/stats?id=43396808) #9 9 points 9 comments -> [Show HN: I made a visual UI creation tool.](https://uiblocks.xyz)<!-- HN:43396808:end --><!-- HN:43399796:start -->
* [43399796](https://news.social-protocols.org/stats?id=43399796) #15 17 points 0 comments -> [More than 400 Palestinians killed in Israeli strikes on Gaza](https://www.nbcnews.com/news/world/live-blog/israel-hamas-war-hundreds-palestinians-killed-israeli-strikes-gaza-rcna196842)<!-- HN:43399796:end --><!-- HN:43397832:start -->
* [43397832](https://news.social-protocols.org/stats?id=43397832) #23 17 points 16 comments -> [Ownership of High-Risk ("Vicious") Dogs as a Marker for Deviant Behaviors](https://www.researchgate.net/publication/6729905_Ownership_of_High-Risk_Vicious_Dogs_as_a_Marker_for_Deviant_Behaviors)<!-- HN:43397832:end --><!-- HN:43398837:start -->
* [43398837](https://news.social-protocols.org/stats?id=43398837) #15 54 points 32 comments -> [AI crawlers haven't learned to play nice with websites](https://www.theregister.com/2025/03/18/ai_crawlers_sourcehut/)<!-- HN:43398837:end --><!-- HN:43400876:start -->
* [43400876](https://news.social-protocols.org/stats?id=43400876) #1 20 points 1 comments -> [Asahi Lina: I no longer feel safe working on Linux GPU drivers or Linux graphics](https://vt.social/@lina/114184129186555191)<!-- HN:43400876:end --><!-- HN:43400867:start -->
* [43400867](https://news.social-protocols.org/stats?id=43400867) #23 3 points 0 comments -> [Google's AI 'co-scientist' cracked 10-year superbug problem in just 2 days](https://www.livescience.com/technology/artificial-intelligence/googles-ai-co-scientist-cracked-10-year-superbug-problem-in-just-2-days)<!-- HN:43400867:end --><!-- HN:43398780:start -->
* [43398780](https://news.social-protocols.org/stats?id=43398780) #1 214 points 4 comments -> [Google announces agreement to acquire Wiz](https://blog.google/inside-google/company-announcements/google-agreement-acquire-wiz/)<!-- HN:43398780:end --><!-- HN:43404482:start -->
* [43404482](https://news.social-protocols.org/stats?id=43404482) #6 30 points 4 comments -> [Doge order leads to journal cancellations by U.S. agricultural library](https://www.science.org/content/article/doge-order-leads-journal-cancellations-u-s-agricultural-library)<!-- HN:43404482:end -->
#### **Wednesday, March 19, 2025**
<!-- HN:43406555:start -->
* [43406555](https://news.social-protocols.org/stats?id=43406555) #5 30 points 20 comments -> [Would You Rather Have Married Young?](https://www.metropolitanreview.org/p/would-you-rather-have-married-young)<!-- HN:43406555:end --><!-- HN:43407423:start -->
* [43407423](https://news.social-protocols.org/stats?id=43407423) #2 49 points 14 comments -> [Show HN: I made a worldwide sexual life dashboard](https://www.worldsexmap.com/)<!-- HN:43407423:end --><!-- HN:43408140:start -->
* [43408140](https://news.social-protocols.org/stats?id=43408140) #30 7 points 3 comments -> [Why Is White House Using Starlink to 'Improve Wi-Fi'?](https://www.msn.com/en-us/news/technology/wait-why-is-the-white-house-using-starlink-to-improve-wi-fi/ar-AA1BaYFi)<!-- HN:43408140:end --><!-- HN:43402115:start -->
* [43402115](https://news.social-protocols.org/stats?id=43402115) #18 430 points 113 comments -> [Amazon to kill off local Alexa processing, all voice requests shipped to cloud](https://www.theregister.com/2025/03/17/amazon_kills_on_device_alexa/)<!-- HN:43402115:end --><!-- HN:43403377:start -->
* [43403377](https://news.social-protocols.org/stats?id=43403377) #24 164 points 40 comments -> [PeerTube v7.1 Is Out](https://joinpeertube.org/news/release-7.1)<!-- HN:43403377:end --><!-- HN:43409044:start -->
* [43409044](https://news.social-protocols.org/stats?id=43409044) #24 3 points 0 comments -> [Ne Zha 2 is the most successful animated film – and I've no idea why](https://www.telegraph.co.uk/films/0/ne-aha-2-review-animation/)<!-- HN:43409044:end --><!-- HN:43409092:start -->
* [43409092](https://news.social-protocols.org/stats?id=43409092) #23 9 points 4 comments -> [Co-Doodle with Gemini](https://huggingface.co/spaces/Trudy/gemini-codrawing)<!-- HN:43409092:end --><!-- HN:43401421:start -->
* [43401421](https://news.social-protocols.org/stats?id=43401421) #19 164 points 45 comments -> [Preview: Amazon S3 Tables and Lakehouse in DuckDB](https://duckdb.org/2025/03/14/preview-amazon-s3-tables.html)<!-- HN:43401421:end --><!-- HN:43409281:start -->
* [43409281](https://news.social-protocols.org/stats?id=43409281) #29 4 points 0 comments -> [Nvidia DGX Spark](https://www.nvidia.com/en-us/products/workstations/dgx-spark/)<!-- HN:43409281:end --><!-- HN:43408564:start -->
* [43408564](https://news.social-protocols.org/stats?id=43408564) #21 16 points 10 comments -> [Digital Hygiene](https://karpathy.bearblog.dev/digital-hygiene/)<!-- HN:43408564:end --><!-- HN:43378571:start -->
* [43378571](https://news.social-protocols.org/stats?id=43378571) #27 144 points 42 comments -> [Rust on the RP2350 (2024)](https://thejpster.org.uk/blog/blog-2024-08-08/)<!-- HN:43378571:end --><!-- HN:43377910:start -->
* [43377910](https://news.social-protocols.org/stats?id=43377910) #14 12 points 3 comments -> [The Wasp That Lays Eggs Inside Caterpillars and Turns Them into Slaves](https://www.wired.com/2014/10/absurd-creature-week-glyptapanteles-wasp-caterpillar-bodyguard/)<!-- HN:43377910:end --><!-- HN:43410897:start -->
* [43410897](https://news.social-protocols.org/stats?id=43410897) #7 4 points 1 comments -> [Vibe Coder Front End Developer](https://getcoai.com/careers/vibe-coder-frontend-developer-role/)<!-- HN:43410897:end --><!-- HN:43411277:start -->
* [43411277](https://news.social-protocols.org/stats?id=43411277) #18 3 points 1 comments -> [MVVM in SwiftUI for a Better Architecture](https://matteomanferdini.com/swiftui-mvvm/)<!-- HN:43411277:end --><!-- HN:43410562:start -->
* [43410562](https://news.social-protocols.org/stats?id=43410562) #14 23 points 11 comments -> [Intel AVX10 Drops Optional 512-Bit: No AVX10 256-Bit Only E-Cores in the Future](https://www.phoronix.com/news/Intel-AVX10-Drops-256-Bit)<!-- HN:43410562:end --><!-- HN:43410720:start -->
* [43410720](https://news.social-protocols.org/stats?id=43410720) #16 11 points 2 comments -> [Indiana Pi Bill](https://en.wikipedia.org/wiki/Indiana_pi_bill)<!-- HN:43410720:end --><!-- HN:43411474:start -->
* [43411474](https://news.social-protocols.org/stats?id=43411474) #19 10 points 0 comments -> [Tesla Removed from Vancouver Auto Show](https://www.ctvnews.ca/vancouver/article/tesla-removed-from-vancouver-auto-show/)<!-- HN:43411474:end --><!-- HN:43411049:start -->
* [43411049](https://news.social-protocols.org/stats?id=43411049) #25 5 points 0 comments -> [Nvidia Blackwell Delivers World-Record DeepSeek-R1 Inference Performance](https://developer.nvidia.com/blog/nvidia-blackwell-delivers-world-record-deepseek-r1-inference-performance/)<!-- HN:43411049:end --><!-- HN:43410579:start -->
* [43410579](https://news.social-protocols.org/stats?id=43410579) #21 97 points 59 comments -> [Tesla loses ground as Chinese EVs dominate global markets](https://restofworld.org/2025/tesla-loses-ground-chinese-ev-dominate-global-markets/)<!-- HN:43410579:end --><!-- HN:43410741:start -->
* [43410741](https://news.social-protocols.org/stats?id=43410741) #21 3 points 0 comments -> [How Do Bluetooth Cassette Adapters Work?](https://garagedreams.net/products/how-do-bluetooth-cassette-adapters-work)<!-- HN:43410741:end --><!-- HN:43410559:start -->
* [43410559](https://news.social-protocols.org/stats?id=43410559) #29 -> [This is How Tesla Will Die](https://www.planetearthandbeyond.co/p/this-is-how-tesla-will-die)<!-- HN:43410559:end --><!-- HN:43412151:start -->
* [43412151](https://news.social-protocols.org/stats?id=43412151) #17 36 points 38 comments -> [Pixel 9a: The latest A-series phone with Google AI smarts at an unbeatable value](https://blog.google/products/pixel/pixel-9a-the-latest-a-series-phone-with-google-ai-smarts-at-an-unbeatable-value/)<!-- HN:43412151:end --><!-- HN:43413650:start -->
* [43413650](https://news.social-protocols.org/stats?id=43413650) #20 28 points 40 comments -> [Solar Generation Surge Sends European Power Prices Below Zero](https://www.bloomberg.com/news/articles/2025-03-19/solar-generation-surge-sends-european-power-prices-below-zero)<!-- HN:43413650:end --><!-- HN:43414706:start -->
* [43414706](https://news.social-protocols.org/stats?id=43414706) #17 3 points 0 comments -> [Rules for Crafting Products That Stand Out](https://www.figma.com/blog/karri-saarinens-10-rules-for-crafting-products-that-stand-out/)<!-- HN:43414706:end --><!-- HN:43415574:start -->
* [43415574](https://news.social-protocols.org/stats?id=43415574) #21 15 points 3 comments -> [Why Tech Bros Overestimate AI's Creative Abilities](https://www.aaronrosspowell.com/p/why-tech-bros-overestimate-ai-s-creative-abilities)<!-- HN:43415574:end -->
#### **Thursday, March 20, 2025**
<!-- HN:43418472:start -->
* [43418472](https://news.social-protocols.org/stats?id=43418472) #16 11 points 1 comments -> [Cybertruck crash report says witness could not open door to save victims](https://oaklandside.org/2025/03/18/cybertruck-crash-report-says-witness-could-not-open-door-to-save-victims/)<!-- HN:43418472:end --><!-- HN:43419095:start -->
* [43419095](https://news.social-protocols.org/stats?id=43419095) #22 27 points 8 comments -> [Doge to Fired CISA Staff: Email Us Your Personal Data](https://krebsonsecurity.com/2025/03/doge-to-fired-cisa-staff-email-us-your-personal-data/)<!-- HN:43419095:end --><!-- HN:43418218:start -->
* [43418218](https://news.social-protocols.org/stats?id=43418218) #19 147 points 22 comments -> [Introduction to Deep Learning (CMU)](https://deeplearning.cs.cmu.edu/./S25/index.html)<!-- HN:43418218:end --><!-- HN:43387661:start -->
* [43387661](https://news.social-protocols.org/stats?id=43387661) #18 6 points 3 comments -> [7159997483.com](https://7159997483.com/)<!-- HN:43387661:end --><!-- HN:43425082:start -->
* [43425082](https://news.social-protocols.org/stats?id=43425082) #30 4 points 0 comments -> [Apple Shakes Up AI Executive Ranks in Bid to Turn Around Siri](https://www.bloomberg.com/news/articles/2025-03-20/apple-vision-pro-chief-mike-rockwell-named-siri-head-giannandrea-keeps-ai-role)<!-- HN:43425082:end --><!-- HN:43426218:start -->
* [43426218](https://news.social-protocols.org/stats?id=43426218) #21 8 points 1 comments -> [Tesla Recalls Most Cybertrucks](https://www.wsj.com/business/autos/tesla-recalls-most-cybertrucks-71ef6fee)<!-- HN:43426218:end --><!-- HN:43425856:start -->
* [43425856](https://news.social-protocols.org/stats?id=43425856) #11 7 points 1 comments -> [Stellar Blockchain Accounts](https://blog.biggertech.co/blog/article/accounts)<!-- HN:43425856:end --><!-- HN:43426872:start -->
* [43426872](https://news.social-protocols.org/stats?id=43426872) #22 9 points 2 comments -> [Tesla recalls most Cybertrucks due to trim detaching from vehicle](https://www.reuters.com/business/autos-transportation/tesla-recall-over-46000-cybertrucks-nhtsa-says-2025-03-20/)<!-- HN:43426872:end --><!-- HN:43426697:start -->
* [43426697](https://news.social-protocols.org/stats?id=43426697) #22 16 points 0 comments -> [TruffleRuby 24.2.0](https://github.com/oracle/truffleruby/releases/tag/graal-24.2.0)<!-- HN:43426697:end --><!-- HN:43425935:start -->
* [43425935](https://news.social-protocols.org/stats?id=43425935) #16 32 points 21 comments -> [The Asus Ascent GX10 a Nvidia GB10 Mini PC with 128GB of Memory and 200GbE](https://www.servethehome.com/this-is-the-asus-ascent-gx10-a-nvidia-gb10-mini-pc-with-128gb-of-memory-and-200gbe/)<!-- HN:43425935:end --><!-- HN:43425876:start -->
* [43425876](https://news.social-protocols.org/stats?id=43425876) #14 50 points 25 comments -> [OpenAI uses open source Ory to authenticate over 400M weekly active users](https://www.ory.sh/blog/openai-oauth2-server-open-source)<!-- HN:43425876:end --><!-- HN:43425841:start -->
* [43425841](https://news.social-protocols.org/stats?id=43425841) #15 119 points 54 comments -> [French scientist denied entry into the U.S., French government says](https://www.reuters.com/world/french-scientist-denied-entry-into-us-french-government-says-2025-03-20/)<!-- HN:43425841:end --><!-- HN:43425623:start -->
* [43425623](https://news.social-protocols.org/stats?id=43425623) #27 4 points 2 comments -> [A Deep Dive into MCP and the Future of AI Tooling](https://a16z.com/a-deep-dive-into-mcp-and-the-future-of-ai-tooling/)<!-- HN:43425623:end --><!-- HN:43427368:start -->
* [43427368](https://news.social-protocols.org/stats?id=43427368) #21 8 points 0 comments -> [Britain Issues Travel Warning for US](https://www.newsweek.com/britain-issues-travel-warning-us-deportations-2047878)<!-- HN:43427368:end --><!-- HN:43427526:start -->
* [43427526](https://news.social-protocols.org/stats?id=43427526) #30 4 points 0 comments -> [Anti-Israel and anti-Jewish bias undermines Wikipedia's neutrality, says ADL](https://www.msnbc.com/morning-joe/watch/anti-israel-and-anti-jewish-bias-undermines-wikipedia-s-neutrality-says-adl-report-234825285807)<!-- HN:43427526:end --><!-- HN:43426164:start -->
* [43426164](https://news.social-protocols.org/stats?id=43426164) #8 53 points 10 comments -> [Show HN: AgentKit – JavaScript Alternative to OpenAI Agents SDK with Native MCP](https://github.com/inngest/agent-kit)<!-- HN:43426164:end --><!-- HN:43426534:start -->
* [43426534](https://news.social-protocols.org/stats?id=43426534) #18 37 points 11 comments -> [How to Be Good at Dating](https://fantasticanachronism.com/2025/03/20/how-to-be-good-at-dating/)<!-- HN:43426534:end --><!-- HN:43428011:start -->
* [43428011](https://news.social-protocols.org/stats?id=43428011) #8 10 points 0 comments -> [Arduino device helps 'split the G' on a pint of Guinness](https://blog.arduino.cc/2025/03/11/this-arduino-device-helps-split-the-g-on-a-pint-of-guinness/)<!-- HN:43428011:end --><!-- HN:43429184:start -->
* [43429184](https://news.social-protocols.org/stats?id=43429184) #24 7 points 0 comments -> [In latest blow to Tesla, regulators recall nearly all Cybertrucks](https://apnews.com/article/cybertruck-recall-tesla-elon-musk-nhtsa-8c517e21aa1119d74b9db39f6aca01b7)<!-- HN:43429184:end --><!-- HN:43429510:start -->
* [43429510](https://news.social-protocols.org/stats?id=43429510) #14 9 points 0 comments -> [Court Imposes over $1.6B in Penalties on a Toyota Subsidiary for Emissions Fraud](https://www.justice.gov/opa/pr/court-sentences-hino-motors-ltd-toyota-subsidiary-and-imposes-over-16b-penalties-emissions)<!-- HN:43429510:end --><!-- HN:43429436:start -->
* [43429436](https://news.social-protocols.org/stats?id=43429436) #15 8 points 0 comments -> [NATS Server v2.11](https://nats.io/blog/nats-server-2.11-release/)<!-- HN:43429436:end --><!-- HN:43429872:start -->
* [43429872](https://news.social-protocols.org/stats?id=43429872) #26 4 points 1 comments -> [Texas Senate passes bill to put Ten Commandments in public school classrooms](https://www.texastribune.org/2025/03/04/texas-senate-ten-commandments-prayer-schools/)<!-- HN:43429872:end -->
#### **Friday, March 21, 2025**
<!-- HN:43430682:start -->
* [43430682](https://news.social-protocols.org/stats?id=43430682) #22 8 points 0 comments -> [Meet Elon Musk’s Top Lieutenant Who Oversees DOGE](https://www.nytimes.com/2025/03/20/technology/elon-musk-steve-davis-doge.html)<!-- HN:43430682:end --><!-- HN:43430938:start -->
* [43430938](https://news.social-protocols.org/stats?id=43430938) #25 10 points 0 comments -> [Indian chemical company employees indicted for Importing of Fentanyl Precursors](https://www.justice.gov/opa/pr/india-based-chemical-manufacturing-company-and-top-employees-indicted-unlawful-importation)<!-- HN:43430938:end --><!-- HN:43431780:start -->
* [43431780](https://news.social-protocols.org/stats?id=43431780) #2 422 points 195 comments -> [Boycott IETF 127](https://boycott-ietf127.org/)<!-- HN:43431780:end --><!-- HN:43431882:start -->
* [43431882](https://news.social-protocols.org/stats?id=43431882) #28 10 points 0 comments -> [Show HN: Minimal JavaScript/TS framework that made us 10k in 10 days](https://github.com/The-Pocket-World/Pocket-Flow-Framework)<!-- HN:43431882:end --><!-- HN:43435281:start -->
* [43435281](https://news.social-protocols.org/stats?id=43435281) #29 3 points 0 comments -> [Counter-terror police investigating 'unprecedented' fire that shut Heathrow](https://www.theguardian.com/uk-news/2025/mar/21/counter-terror-police-investigating-unprecedented-fire-shut-heathrow)<!-- HN:43435281:end --><!-- HN:43398148:start -->
* [43398148](https://news.social-protocols.org/stats?id=43398148) #19 61 points 12 comments -> [Debugging PostgreSQL More Easily](https://www.cybertec-postgresql.com/en/debugging-postgresql-more-easily/)<!-- HN:43398148:end --><!-- HN:43435552:start -->
* [43435552](https://news.social-protocols.org/stats?id=43435552) #26 3 points 0 comments -> [The Risk of Financial Bubbles in Renewable Energy Markets](https://www.mdpi.com/1996-1073/18/6/1400)<!-- HN:43435552:end --><!-- HN:43435190:start -->
* [43435190](https://news.social-protocols.org/stats?id=43435190) #29 7 points 0 comments -> [Steam on Xbox evidence Microsoft didn't want you to see](https://www.theverge.com/news/633478/microsoft-xbox-steam-games-support-ui)<!-- HN:43435190:end --><!-- HN:43436585:start -->
* [43436585](https://news.social-protocols.org/stats?id=43436585) #28 4 points 0 comments -> [New desalination technology being tested in California could lower costs](https://www.latimes.com/environment/story/2025-03-21/desalination-tech-tested)<!-- HN:43436585:end --><!-- HN:43437641:start -->
* [43437641](https://news.social-protocols.org/stats?id=43437641) #28 3 points 0 comments -> [Unix Pipeline Philosophy in HTMX + FastHTML Workflows](https://mikelev.in/futureproof/unix-pipelines-htmx-fasthtml-workflow/)<!-- HN:43437641:end --><!-- HN:43439186:start -->
* [43439186](https://news.social-protocols.org/stats?id=43439186) #9 15 points 1 comments -> [Artificial Intelligence Learns to Reason](https://www.science.org/doi/10.1126/science.adw5211)<!-- HN:43439186:end --><!-- HN:43439662:start -->
* [43439662](https://news.social-protocols.org/stats?id=43439662) #25 8 points 1 comments -> [Feds charge three over Molotov attacks on Tesla sites in multiple states](https://www.theregister.com/2025/03/21/tesla_attack_charges/)<!-- HN:43439662:end --><!-- HN:43439881:start -->
* [43439881](https://news.social-protocols.org/stats?id=43439881) #6 7 points 1 comments -> [Plex remote stream no longer free; Plex Pass 2x price hike](https://www.plex.tv/blog/important-2025-plex-updates/)<!-- HN:43439881:end --><!-- HN:43440240:start -->
* [43440240](https://news.social-protocols.org/stats?id=43440240) #29 8 points 0 comments -> [Foreigners Dump U.S. Treasuries. Here's Who Did the Most Selling](https://www.barrons.com/articles/treasuries-foreign-sell-gold-765ce81f)<!-- HN:43440240:end --><!-- HN:43440449:start -->
* [43440449](https://news.social-protocols.org/stats?id=43440449) #30 22 points 11 comments -> [How 'Careless People' is becoming a bigger problem for Meta](https://www.theverge.com/command-line-newsletter/634080/careless-people-sarah-wynn-williams-book-meta-congress)<!-- HN:43440449:end -->
#### **Saturday, March 22, 2025**<!-- HN:43409533:start -->
* [43409533](https://news.social-protocols.org/stats?id=43409533) #23 29 points 41 comments -> [Rocky Linux from CIQ – Hardened](https://ciq.com/products/rocky-linux/hardened/)<!-- HN:43409533:end --><!-- HN:43443280:start -->
* [43443280](https://news.social-protocols.org/stats?id=43443280) #12 5 points 2 comments -> [Show HN: Font Pair – I was wasting hours choosing fonts, so I built this](https://github.com/CodeWithNeer/FontPair)<!-- HN:43443280:end --><!-- HN:43443979:start -->
* [43443979](https://news.social-protocols.org/stats?id=43443979) #8 11 points 0 comments -> [Vibe Coding – The Ultimate Guide with Resources](https://natural20.com/vibe-coding/)<!-- HN:43443979:end --><!-- HN:43444098:start -->
* [43444098](https://news.social-protocols.org/stats?id=43444098) #29 4 points 0 comments -> [Number of border searches of electronic devices increasing every year](https://www.eff.org/issues/border-searches)<!-- HN:43444098:end --><!-- HN:43444191:start -->
* [43444191](https://news.social-protocols.org/stats?id=43444191) #7 9 points 1 comments -> [VibeSail: A case study in vibe coding a game](https://www.vibecoding.games/vibesail-a-case-study-in-vibe-coding-a-game/)<!-- HN:43444191:end --><!-- HN:43444337:start -->
* [43444337](https://news.social-protocols.org/stats?id=43444337) #24 24 points 9 comments -> [Zen browser had a backdoor enabled by default](https://github.com/zen-browser/desktop/issues/5947)<!-- HN:43444337:end --><!-- HN:43444605:start -->
* [43444605](https://news.social-protocols.org/stats?id=43444605) #10 27 points 40 comments -> [MacBooks account for 86% of total Mac sales; Mac desktops just 14%](https://macdailynews.com/2025/03/19/macbooks-account-for-86-of-total-mac-sales-mac-desktops-just-14/)<!-- HN:43444605:end --><!-- HN:43443974:start -->
* [43443974](https://news.social-protocols.org/stats?id=43443974) #17 33 points 22 comments -> [The future of AI is Ruby on Rails](https://www.seangoedecke.com/ai-and-ruby/#fnref-1)<!-- HN:43443974:end --><!-- HN:43443823:start -->
* [43443823](https://news.social-protocols.org/stats?id=43443823) #17 31 points 5 comments -> [Don't compete](https://invertedpassion.com/dont-compete/)<!-- HN:43443823:end --><!-- HN:43444017:start -->
* [43444017](https://news.social-protocols.org/stats?id=43444017) #21 30 points 1 comments -> [Concise Machine Learning [pdf]](https://people.eecs.berkeley.edu/~jrs/papers/machlearn.pdf)<!-- HN:43444017:end --><!-- HN:43445179:start -->
* [43445179](https://news.social-protocols.org/stats?id=43445179) #17 3 points 0 comments -> [Targeting Brain's Drainage Pathways Rejuvenates Memory](https://neurosciencenews.com/lymphatic-system-aging-memory-28507/)<!-- HN:43445179:end --><!-- HN:43446225:start -->
* [43446225](https://news.social-protocols.org/stats?id=43446225) #22 3 points 0 comments -> [Krazam: Microservices [video]](https://www.youtube.com/watch?v=y8OnoxKotPQ)<!-- HN:43446225:end --><!-- HN:43446544:start -->
* [43446544](https://news.social-protocols.org/stats?id=43446544) #9 7 points 4 comments -> [The Ugly Truth About the Education System You Were Never Told](https://www.thesouljam.com/posts/the-ugly-truth-about-the-education-system-you-were-never-told)<!-- HN:43446544:end --><!-- HN:43447308:start -->
* [43447308](https://news.social-protocols.org/stats?id=43447308) #24 11 points 1 comments -> [NYU Website Hacked](https://web.archive.org/web/20250322133330/https://www.nyu.edu/)<!-- HN:43447308:end --><!-- HN:43448528:start -->
* [43448528](https://news.social-protocols.org/stats?id=43448528) #12 11 points 1 comments -> [You Shouldn't Use Next.js](https://www.epicweb.dev/why-i-wont-use-nextjs)<!-- HN:43448528:end -->
#### **Sunday, March 23, 2025**
<!-- HN:43449973:start -->
* [43449973](https://news.social-protocols.org/stats?id=43449973) #3 6 points 1 comments -> [Hetzner is forwarding other people's traffic to you](https://kiwi.fuo.fi/notes/a5oh5qt4ra5o000v)<!-- HN:43449973:end --><!-- HN:43449889:start -->
* [43449889](https://news.social-protocols.org/stats?id=43449889) #1 28 points 6 comments -> [YC alum LunaJoy got $6.6M, offers job below minimum wage](https://www.workatastartup.com/jobs/72101)<!-- HN:43449889:end --><!-- HN:43448322:start -->
* [43448322](https://news.social-protocols.org/stats?id=43448322) #16 42 points 14 comments -> [Meta pirated at least 101 of my books, and others](https://garymarcus.substack.com/p/meta-pirated-at-least-101-of-my-books)<!-- HN:43448322:end --><!-- HN:43450256:start -->
* [43450256](https://news.social-protocols.org/stats?id=43450256) #21 4 points 0 comments -> [Facebook tells people to download their recorded videos before they're deleted](https://www.facebook.com/business/help/1005165994166600?_fb_noscript=1)<!-- HN:43450256:end --><!-- HN:43451695:start -->
* [43451695](https://news.social-protocols.org/stats?id=43451695) #18 4 points 0 comments -> [1k True Fans (2008)](https://kk.org/thetechnium/1000-true-fans/)<!-- HN:43451695:end --><!-- HN:43448193:start -->
* [43448193](https://news.social-protocols.org/stats?id=43448193) #12 118 points 39 comments -> [Mathematical Methods for Physics [pdf]](https://www.ma.imperial.ac.uk/~dturaev/Mathematical_Methods2021.pdf)<!-- HN:43448193:end --><!-- HN:43445614:start -->
* [43445614](https://news.social-protocols.org/stats?id=43445614) #14 143 points 7 comments -> [Differential Geometry: A First Course in Curves and Surfaces [pdf]](https://math.franklin.uga.edu/sites/default/files/users/user317/ShifrinDiffGeo.pdf)<!-- HN:43445614:end --><!-- HN:43451439:start -->
* [43451439](https://news.social-protocols.org/stats?id=43451439) #28 19 points 2 comments -> [ThePrimeagen: Programming, AI, ADHD, Productivity, Addiction, and God](https://www.youtube.com/watch?v=tNZnLkRBYA8)<!-- HN:43451439:end --><!-- HN:43451159:start -->
* [43451159](https://news.social-protocols.org/stats?id=43451159) #18 14 points 0 comments -> [Carl Linnaeus's note-taking innovations](https://jillianhess.substack.com/p/carl-linnaeuss-note-taking-innovations)<!-- HN:43451159:end --><!-- HN:43446174:start -->
* [43446174](https://news.social-protocols.org/stats?id=43446174) #7 9 points 1 comments -> [Neanderthals may have eaten maggots as part of their diet](https://www.science.org/content/article/neanderthals-may-have-eaten-maggots-part-their-diet)<!-- HN:43446174:end --><!-- HN:43452431:start -->
* [43452431](https://news.social-protocols.org/stats?id=43452431) #10 9 points 1 comments -> [Hardware-Aware Coding: CPU Architecture Concepts Every Developer Should Know](https://blog.codingconfessions.com/p/hardware-aware-coding)<!-- HN:43452431:end --><!-- HN:43452177:start -->
* [43452177](https://news.social-protocols.org/stats?id=43452177) #12 5 points 1 comments -> [Show HN: NPM-Audit-to-Report](https://github.com/egorsmkv/npm-audit-to-report)<!-- HN:43452177:end --><!-- HN:43454841:start -->
* [43454841](https://news.social-protocols.org/stats?id=43454841) #26 4 points 0 comments -> [All the terrifying signs World War III is already playing out in the shadows](https://www.dailymail.co.uk/news/article-14516439/world-war-3-playing-shadows-russia-ukraine-trump.html)<!-- HN:43454841:end --><!-- HN:43454341:start -->
* [43454341](https://news.social-protocols.org/stats?id=43454341) #18 15 points 2 comments -> [Ttyd – Share your terminal over the web](https://github.com/tsl0922/ttyd)<!-- HN:43454341:end --><!-- HN:43454136:start -->
* [43454136](https://news.social-protocols.org/stats?id=43454136) #20 7 points 0 comments -> [Tied Crosscoders: Tracing How Chat LLM Behavior Emerges from Base Model](https://www.lesswrong.com/posts/3T8eKyaPvDDm2wzor/research-question)<!-- HN:43454136:end --><!-- HN:43455011:start -->
* [43455011](https://news.social-protocols.org/stats?id=43455011) #9 5 points 0 comments -> [Donate USB Drives and SD Cards to Help US Smuggle Outside Info into North Korea](https://flashdrivesforfreedom.org)<!-- HN:43455011:end --><!-- HN:43456355:start -->
* [43456355](https://news.social-protocols.org/stats?id=43456355) #3 10 points 1 comments -> [Sharing My USPS Mail Alerts Apps Script](https://taslim.xyz/blog/2025/sharing-my-usps-mail-alerts-apps-script/)<!-- HN:43456355:end -->
#### **Monday, March 24, 2025**
<!-- HN:43457428:start -->
* [43457428](https://news.social-protocols.org/stats?id=43457428) #21 5 points 0 comments -> ["The bargain we are being asked to ratify" – AI as technological bribery](https://librarianshipwreck.wordpress.com/2025/03/02/the-bargain-we-are-being-asked-to-ratify-ai-as-technological-bribery/)<!-- HN:43457428:end --><!-- HN:43457754:start -->
* [43457754](https://news.social-protocols.org/stats?id=43457754) #5 3 points 0 comments -> [Exploring Ruby Ractors – I paid for for 10 cores I'm gonna use 10 cores](https://jpterry.com/posts/2025/03/exploring-ruby-ractors/)<!-- HN:43457754:end --><!-- HN:43458359:start -->
* [43458359](https://news.social-protocols.org/stats?id=43458359) #1 6 points 0 comments -> [Show HN: I build a Free and Open-source tool for Macs:)](https://github.com/caioricciuti/cr-mac-helper)<!-- HN:43458359:end --><!-- HN:43458633:start -->
* [43458633](https://news.social-protocols.org/stats?id=43458633) #26 23 points 13 comments -> [Rust Additions for GCC 15 Bring Support for If-Let Statements](https://www.phoronix.com/news/GCC-15-Rust-if-let)<!-- HN:43458633:end --><!-- HN:43458758:start -->
* [43458758](https://news.social-protocols.org/stats?id=43458758) #18 63 points 21 comments -> [Tesla sales drop 35% in San Diego County](https://fox5sandiego.com/news/business/tesla-sales-drop-35-in-san-diego-county/)<!-- HN:43458758:end --><!-- HN:43459859:start -->
* [43459859](https://news.social-protocols.org/stats?id=43459859) #29 5 points 0 comments -> [Met Police gets first permanent facial recognition cameras in London](https://www.lbc.co.uk/crime/facial-recognition-camera-london-permanent-met-police/)<!-- HN:43459859:end --><!-- HN:43427595:start -->
* [43427595](https://news.social-protocols.org/stats?id=43427595) #16 26 points 4 comments -> [Taming Servers for Fun and Profit](https://blog.railway.com/p/data-center-build-part-two)<!-- HN:43427595:end --><!-- HN:43459535:start -->
* [43459535](https://news.social-protocols.org/stats?id=43459535) #20 7 points 3 comments -> [Why we chose LangGraph to build our coding agent](https://www.qodo.ai/blog/why-we-chose-langgraph-to-build-our-coding-agent/)<!-- HN:43459535:end -->