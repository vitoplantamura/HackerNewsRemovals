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
* [43304971](https://news.social-protocols.org/stats?id=43304971) #18 7 points 2 comments -> [Tesla Cybertruck Banned and Seized by Police in the U.K](https://www.forbes.com/sites/peterlyon/2025/02/20/tesla-cybertruck-banned-in-the-uk-due-to-safety-issues/)<!-- HN:43304971:end --><!-- HN:43305375:start -->
* [43305375](https://news.social-protocols.org/stats?id=43305375) #13 12 points 2 comments -> [US 'to cease all future military exercises in Europe'](https://www.telegraph.co.uk/us/politics/2025/03/08/us-to-cease-all-future-military-exercises-in-europe-reports/)<!-- HN:43305375:end --><!-- HN:43304567:start -->
* [43304567](https://news.social-protocols.org/stats?id=43304567) #4 23 points 40 comments -> [Toward a Passwordless Future](https://www.privacyguides.org/articles/2025/03/08/toward-a-passwordless-future/)<!-- HN:43304567:end --><!-- HN:43287345:start -->
* [43287345](https://news.social-protocols.org/stats?id=43287345) #27 9 points 0 comments -> [The trap of the top-down approach](https://www.cryptologie.net/article/625/the-trap-of-the-top-down-approach/)<!-- HN:43287345:end --><!-- HN:43305683:start -->
* [43305683](https://news.social-protocols.org/stats?id=43305683) #13 27 points 23 comments -> [YouTube, when the walls fell [video]](https://www.youtube.com/watch?v=l0jw_Q23NIU)<!-- HN:43305683:end --><!-- HN:43306027:start -->
* [43306027](https://news.social-protocols.org/stats?id=43306027) #7 5 points 2 comments -> [GTA 6 fans gutted after learning it will be unplayable for PC Players at launch](https://www.gamingbible.com/news/gta-6-unplayable-launch-696549-20250307)<!-- HN:43306027:end --><!-- HN:43306192:start -->
* [43306192](https://news.social-protocols.org/stats?id=43306192) #29 43 points 24 comments -> [State Department Will Use AI to Search for 'Pro-Hamas' Students to Deport](https://gizmodo.com/state-department-will-use-ai-to-search-for-pro-hamas-students-to-deport-2000573143)<!-- HN:43306192:end --><!-- HN:43267291:start -->
* [43267291](https://news.social-protocols.org/stats?id=43267291) #29 29 points 40 comments -> [Time for a Change: The long, contentious history of time shifts](https://worldhistory.substack.com/p/time-for-a-change)<!-- HN:43267291:end --><!-- HN:43307229:start -->
* [43307229](https://news.social-protocols.org/stats?id=43307229) #1 16 points 20 comments -> [Rust vs. Go: Battle for the Back End](https://effective-programmer.com/rust-vs-go-battle-for-the-backend-368f775de9fc)<!-- HN:43307229:end --><!-- HN:43306839:start -->
* [43306839](https://news.social-protocols.org/stats?id=43306839) #11 12 points 1 comments -> [Becoming a Good Engineer](https://0x0001.cc/blog/good-engineer.md)<!-- HN:43306839:end --><!-- HN:43308852:start -->
* [43308852](https://news.social-protocols.org/stats?id=43308852) #17 3 points 0 comments -> [Developer guilty of using kill switch to sabotage employer's systems](https://www.bleepingcomputer.com/news/security/developer-guilty-of-using-kill-switch-to-sabotage-employers-systems/)<!-- HN:43308852:end --><!-- HN:43309485:start -->
* [43309485](https://news.social-protocols.org/stats?id=43309485) #23 4 points 0 comments -> [DHS Detains Lead Negotiator of Columbia Encampment](https://www.dropsitenews.com/p/dhs-detains-columbia-university-student-gaza)<!-- HN:43309485:end --><!-- HN:43311025:start -->
* [43311025](https://news.social-protocols.org/stats?id=43311025) #15 9 points 0 comments -> [DOGE's Cuts to the IRS Threaten to Cost More Than Doge Will Ever Save](https://www.propublica.org/article/how-doge-irs-cuts-will-cost-more-than-savings-trump-musk-deficit)<!-- HN:43311025:end --><!-- HN:43310634:start -->
* [43310634](https://news.social-protocols.org/stats?id=43310634) #22 14 points 3 comments -> [Reasons veterans are especially hard-hit by federal cuts](https://theconversation.com/5-reasons-veterans-are-especially-hard-hit-by-federal-cuts-251188)<!-- HN:43310634:end --><!-- HN:43279870:start -->
* [43279870](https://news.social-protocols.org/stats?id=43279870) #10 9 points 3 comments -> [BBS from Scratch](https://bbsfromscratch.com/)<!-- HN:43279870:end --><!-- HN:43312242:start -->
* [43312242](https://news.social-protocols.org/stats?id=43312242) #28 8 points 3 comments -> [Violent and sudden. What a firing squad execution looked like through my eyes](https://apnews.com/article/south-carolina-firing-squad-eyewitness-account-sigmon-427cccb55be58954af4434e89bcc41d8)<!-- HN:43312242:end --><!-- HN:43312516:start -->
* [43312516](https://news.social-protocols.org/stats?id=43312516) #9 32 points 12 comments -> [Poland says it may need alternative to Musk’s Starlink in Ukraine](https://www.reuters.com/world/europe/poland-says-it-may-need-alternative-musks-starlink-ukraine-2025-03-09/)<!-- HN:43312516:end --><!-- HN:43312920:start -->
* [43312920](https://news.social-protocols.org/stats?id=43312920) #3 14 points 2 comments -> [H.R. 1936: To prohibit funds for the USAF to invade Canada, Panama, or Greenland](https://www.govtrack.us/congress/bills/119/hr1936)<!-- HN:43312920:end --><!-- HN:43313398:start -->
* [43313398](https://news.social-protocols.org/stats?id=43313398) #12 8 points 1 comments -> [Can the US switch off Europe's weapons?](https://www.ft.com/content/1503a69e-13e4-4ee8-9d05-b9ce1f7cc89e)<!-- HN:43313398:end --><!-- HN:43313341:start -->
* [43313341](https://news.social-protocols.org/stats?id=43313341) #13 20 points 11 comments -> [Top links on Bluesky, Updated Hourly](https://theblue.report)<!-- HN:43313341:end --><!-- HN:43279939:start -->
* [43279939](https://news.social-protocols.org/stats?id=43279939) #15 28 points 1 comments -> [Graphite: Node-based, non-destructive, procedural 2D vector editor](https://github.com/GraphiteEditor/Graphite)<!-- HN:43279939:end --><!-- HN:43314301:start -->
* [43314301](https://news.social-protocols.org/stats?id=43314301) #14 12 points 1 comments -> [US authorities arrest Palestinian student protester at Columbia University](https://www.reuters.com/world/us/us-authorities-arrest-palestinian-student-protester-columbia-university-students-2025-03-09/)<!-- HN:43314301:end --><!-- HN:43314809:start -->
* [43314809](https://news.social-protocols.org/stats?id=43314809) #25 -> [The Fascist Tech Bro Takeover Is Here](https://www.theindex.media/the-fascist-tech-bro-takeover-is-here-2/)<!-- HN:43314809:end --><!-- HN:43283214:start -->
* [43283214](https://news.social-protocols.org/stats?id=43283214) #26 7 points 0 comments -> [Japan's Clever Anti-Snow Roadways](https://www.core77.com/posts/135763/Japans-Clever-Anti-Snow-Roadways)<!-- HN:43283214:end -->
#### **Monday, March 10, 2025**
<!-- HN:43314994:start -->
* [43314994](https://news.social-protocols.org/stats?id=43314994) #23 47 points 10 comments -> [ICE arrests Palestinian activist who helped lead Columbia University protests](https://apnews.com/article/columbia-university-mahmoud-khalil-ice-15014bcbb921f21a9f704d5acdcae7a8)<!-- HN:43314994:end --><!-- HN:43315046:start -->
* [43315046](https://news.social-protocols.org/stats?id=43315046) #25 34 points 13 comments -> [Tesla Used Car Price Crashes – Model Y, Model 3 Deals Explode](https://www.forbes.com/sites/brookecrothers/2025/03/09/tesla-used-car-price-crashes--model-y-model-3-deals-explode/)<!-- HN:43315046:end --><!-- HN:43283271:start -->
* [43283271](https://news.social-protocols.org/stats?id=43283271) #12 6 points 1 comments -> [Pompey's Greatest Show on Earth](https://www.historytoday.com/archive/history-matters/pompeys-greatest-show-earth)<!-- HN:43283271:end --><!-- HN:43316469:start -->
* [43316469](https://news.social-protocols.org/stats?id=43316469) #21 5 points 1 comments -> [The US economy is heading for recession](https://www.ft.com/content/078780dd-16e0-45e4-b281-c70d59cc07ee)<!-- HN:43316469:end --><!-- HN:43316590:start -->
* [43316590](https://news.social-protocols.org/stats?id=43316590) #26 5 points 1 comments -> [Columbia Expelled Student Protesters For the First Time in Over 50 Years](https://www.thenation.com/article/activism/columbia-expels-student-protesters-milstein-library/)<!-- HN:43316590:end --><!-- HN:43316237:start -->
* [43316237](https://news.social-protocols.org/stats?id=43316237) #25 8 points 1 comments -> [Tesla Showroom Set on Fire](https://www.hindustantimes.com/trending/tesla-showroom-set-on-fire-12-cars-destroyed-in-suspected-arson-attack-in-france-101741243979863.html)<!-- HN:43316237:end --><!-- HN:43316724:start -->
* [43316724](https://news.social-protocols.org/stats?id=43316724) #20 12 points 0 comments -> ['Nobody will trust a US treaty again,' and the yen is new safe haven](https://fortune.com/2025/03/09/us-treaty-nato-ukraine-russia-trump-japan-yen-safe-haven-dedollarization/)<!-- HN:43316724:end --><!-- HN:43314171:start -->
* [43314171](https://news.social-protocols.org/stats?id=43314171) #23 100 points 14 comments -> [Apple rearranged its XNU kernel with exclaves](https://www.theregister.com/2025/03/08/kernel_sanders_apple_rearranges_xnu/)<!-- HN:43314171:end --><!-- HN:43316556:start -->
* [43316556](https://news.social-protocols.org/stats?id=43316556) #28 24 points 10 comments -> [Free95: An open-source windows-compatible operating system](https://github.com/Versoft-Software/Free95)<!-- HN:43316556:end --><!-- HN:43317954:start -->
* [43317954](https://news.social-protocols.org/stats?id=43317954) #27 34 points 10 comments -> [Another late-night Claude Code post](https://twitter.com/Steve_Yegge/status/1898993080931611112)<!-- HN:43317954:end --><!-- HN:43318709:start -->
* [43318709](https://news.social-protocols.org/stats?id=43318709) #19 13 points 6 comments -> [Is X Down?](https://downdetector.in/status/twitter/)<!-- HN:43318709:end --><!-- HN:43318094:start -->
* [43318094](https://news.social-protocols.org/stats?id=43318094) #11 13 points 23 comments -> [Show HN: Back to one-time end-to-end encrypted anonymous chats in 2025](https://www.yaps.chat/)<!-- HN:43318094:end --><!-- HN:43290704:start -->
* [43290704](https://news.social-protocols.org/stats?id=43290704) #16 25 points 40 comments -> [Nomars: No Manning Required Ship](https://www.darpa.mil/research/programs/no-manning-required-ship)<!-- HN:43290704:end --><!-- HN:43317406:start -->
* [43317406](https://news.social-protocols.org/stats?id=43317406) #24 105 points 66 comments -> [Llama.cpp AI Performance with the GeForce RTX 5090 Review](https://www.phoronix.com/review/nvidia-rtx5090-llama-cpp)<!-- HN:43317406:end --><!-- HN:43320980:start -->
* [43320980](https://news.social-protocols.org/stats?id=43320980) #30 8 points 3 comments -> [What a Wrongful Death Lawsuit Reveals About America's Largest Oxygen Provider](https://www.propublica.org/article/lincare-wrongful-death-lawsuit-sleep-apnea-oxygen)<!-- HN:43320980:end --><!-- HN:43294756:start -->
* [43294756](https://news.social-protocols.org/stats?id=43294756) #16 44 points 14 comments -> [From Prompt to Adventures:Creating Games with LLMs and Restate Durable Functions](https://restate.dev/blog/from-prompt-to-adventures-creating-games-with-llms-and-restates-durable-functions/)<!-- HN:43294756:end --><!-- HN:43322481:start -->
* [43322481](https://news.social-protocols.org/stats?id=43322481) #20 6 points 0 comments -> [Wealthy Colleges Fight to Protect Their Riches from Taxation](https://www.bloomberg.com/news/articles/2025-03-10/wealthiest-colleges-fight-to-protect-their-riches-from-taxation)<!-- HN:43322481:end --><!-- HN:43322896:start -->
* [43322896](https://news.social-protocols.org/stats?id=43322896) #25 5 points 1 comments -> [George Washington knew difference between running a business vs. the government](https://theconversation.com/george-washington-a-real-estate-investor-and-successful-entrepreneur-knew-the-difference-between-running-a-business-and-running-the-government-250332)<!-- HN:43322896:end --><!-- HN:43323812:start -->
* [43323812](https://news.social-protocols.org/stats?id=43323812) #13 -> [Anonymous: We are here to fight against fasciscm that has taken root in America](https://opdreadnought.com)<!-- HN:43323812:end --><!-- HN:43323652:start -->
* [43323652](https://news.social-protocols.org/stats?id=43323652) #14 110 points 88 comments -> [Wall Street sell-off turns 'ugly' as US recession fears grow](https://www.independent.co.uk/business/wall-street-selloff-turns-ugly-as-us-recession-fears-grow-b2712420.html)<!-- HN:43323652:end --><!-- HN:43324220:start -->
* [43324220](https://news.social-protocols.org/stats?id=43324220) #9 14 points 11 comments -> [I quit my FAANG job because it'll be automated by the end of the year (2025)](https://jagilley.github.io/faang-blog.html)<!-- HN:43324220:end --><!-- HN:43325019:start -->
* [43325019](https://news.social-protocols.org/stats?id=43325019) #16 27 points 19 comments -> [We've been wrong about math for 2300 years](https://davidbessis.substack.com/p/weve-been-wrong-about-math-for-2300)<!-- HN:43325019:end --><!-- HN:43326554:start -->
* [43326554](https://news.social-protocols.org/stats?id=43326554) #6 6 points 0 comments -> [Leningrad-1: a 44-IC Soviet style ZX-Spectrum clone](https://alex-j-lowry.github.io/leningrd.html)<!-- HN:43326554:end -->
#### **Tuesday, March 11, 2025**
<!-- HN:43328035:start -->
* [43328035](https://news.social-protocols.org/stats?id=43328035) #30 6 points 0 comments -> [Bluesky's CEO on the Future of Social Media at SXSW [video]](https://www.youtube.com/watch?v=B7OwcXCE5Rg)<!-- HN:43328035:end --><!-- HN:43327395:start -->
* [43327395](https://news.social-protocols.org/stats?id=43327395) #20 10 points 7 comments -> [A 19yo woman graduated from high school with honors even though she can't read](https://www.ky3.com/2025/02/28/former-high-school-honors-student-who-says-she-cant-read-write-sues-district-where-she-graduated/)<!-- HN:43327395:end -->