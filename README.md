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

#### **Friday, February 7, 2025**<!-- HN:42967989:start -->
* [42967989](https://news.social-protocols.org/stats?id=42967989) #24 27 points 2 comments -> [White House budget proposal could shatter the National Science Foundation](https://arstechnica.com/science/2025/02/white-house-budget-proposal-could-shatter-the-national-science-foundation/)<!-- HN:42967989:end --><!-- HN:42968435:start -->
* [42968435](https://news.social-protocols.org/stats?id=42968435) #17 8 points 1 comments -> [Doge Treasury Agent Reportedly Resigns After Racist Posts](https://www.forbes.com/sites/mollybohannon/2025/02/06/doge-treasury-agent-reportedly-resigns-after-racist-posts-heres-what-to-know-about-musks-agency/)<!-- HN:42968435:end --><!-- HN:42968995:start -->
* [42968995](https://news.social-protocols.org/stats?id=42968995) #14 14 points 3 comments -> [Andreessen Horowitz Defends Hiring of Daniel Penny to Its Investors](https://www.nytimes.com/2025/02/05/technology/daniel-penny-andreessen-horowitz-investors.html)<!-- HN:42968995:end --><!-- HN:42969643:start -->
* [42969643](https://news.social-protocols.org/stats?id=42969643) #3 20 points 11 comments -> [Show HN: I built an AI satirical news site because news was depressing me](https://thescallion.netlify.app/)<!-- HN:42969643:end --><!-- HN:42970411:start -->
* [42970411](https://news.social-protocols.org/stats?id=42970411) #19 7 points 1 comments -> [Doge Engineer Resigns After Racist Eugenics Remarks Revealed](https://www.commondreams.org/news/doge-account-racist-marko-elez)<!-- HN:42970411:end --><!-- HN:42926845:start -->
* [42926845](https://news.social-protocols.org/stats?id=42926845) #18 35 points 41 comments -> [If your customers don't talk, NPS is a vanity metric](https://www.elliotcsmith.com/if-your-customers-dont-talk-nps-is-a-vanity-metric/)<!-- HN:42926845:end --><!-- HN:42970776:start -->
* [42970776](https://news.social-protocols.org/stats?id=42970776) #9 53 points 40 comments -> [Is the use of reCAPTCHA GDPR-compliant?](https://dg-datenschutz.de/ist_die_verwendung_von_recaptcha_dsgvo_konform/)<!-- HN:42970776:end --><!-- HN:42971116:start -->
* [42971116](https://news.social-protocols.org/stats?id=42971116) #13 5 points 0 comments -> [How to Not Get Fired in 2025](https://startupbaniya.com/how-to-not-get-fired-2025)<!-- HN:42971116:end --><!-- HN:42971609:start -->
* [42971609](https://news.social-protocols.org/stats?id=42971609) #24 3 points 0 comments -> [Podcasts probably have the lowest information density of any medium ever created](https://twitter.com/0x49fa98/status/1887522746147459484)<!-- HN:42971609:end --><!-- HN:42972315:start -->
* [42972315](https://news.social-protocols.org/stats?id=42972315) #4 13 points 8 comments -> [Rewrote 42k lines of code from Python to Go. Technical deep dive](https://lovable.dev/blog/from-python-to-go)<!-- HN:42972315:end --><!-- HN:42972431:start -->
* [42972431](https://news.social-protocols.org/stats?id=42972431) #11 8 points 1 comments -> [Asahi Linux Lead Developer Hector Martin Steps Down](https://www.phoronix.com/news/Asahi-Linux-Lead-No-Upstream)<!-- HN:42972431:end --><!-- HN:42970039:start -->
* [42970039](https://news.social-protocols.org/stats?id=42970039) #13 315 points 87 comments -> [Harvard preserving for public use data.gov datasets](https://lil.law.harvard.edu/blog/2025/02/06/announcing-data-gov-archive/)<!-- HN:42970039:end --><!-- HN:42930301:start -->
* [42930301](https://news.social-protocols.org/stats?id=42930301) #15 37 points 12 comments -> [Experience the DeepSeek R1 Distilled 'Reasoning' Models on Ryzen AI and Radeon](https://community.amd.com/t5/ai/experience-the-deepseek-r1-distilled-reasoning-models-on-amd/ba-p/740593)<!-- HN:42930301:end --><!-- HN:42971470:start -->
* [42971470](https://news.social-protocols.org/stats?id=42971470) #23 27 points 15 comments -> [OpenAI cofounder John Schulman is joining Mira Murati's startup](https://finance.yahoo.com/news/openai-cofounder-john-schulman-joining-211110685.html)<!-- HN:42971470:end --><!-- HN:42972129:start -->
* [42972129](https://news.social-protocols.org/stats?id=42972129) #26 11 points 0 comments -> [UK government reportedly demands Apple backdoor to encrypted cloud data](https://techcrunch.com/2025/02/07/uk-government-demands-apple-backdoor-to-encrypted-cloud-data-report/)<!-- HN:42972129:end --><!-- HN:42972996:start -->
* [42972996](https://news.social-protocols.org/stats?id=42972996) #21 7 points 0 comments -> [U.K. orders Apple to let it spy on users' encrypted accounts](https://www.msn.com/en-us/news/technology/uk-orders-apple-to-let-it-spy-on-users-encrypted-accounts/ar-AA1yzETB)<!-- HN:42972996:end --><!-- HN:42971144:start -->
* [42971144](https://news.social-protocols.org/stats?id=42971144) #19 47 points 31 comments -> [Boeing reports Starliner losses of more than half a billion dollars in 2024](https://spacenews.com/boeing-reports-starliner-losses-of-more-than-half-a-billion-dollars-in-2024/)<!-- HN:42971144:end --><!-- HN:42971875:start -->
* [42971875](https://news.social-protocols.org/stats?id=42971875) #27 -> [The Culture Scene Is Total Madness](https://www.honest-broker.com/p/the-culture-scene-is-total-madness)<!-- HN:42971875:end --><!-- HN:42971146:start -->
* [42971146](https://news.social-protocols.org/stats?id=42971146) #14 19 points 1 comments -> [Using pip to install a Large Language Model that's under 100MB](https://simonwillison.net/2025/Feb/7/pip-install-llm-smollm2/)<!-- HN:42971146:end --><!-- HN:42972380:start -->
* [42972380](https://news.social-protocols.org/stats?id=42972380) #14 17 points 4 comments -> [Entity-Component-System Architecture in Kubernetes](https://fancl20.github.io/contents/00-posts/2025-02-07-ecs-and-k8s.html)<!-- HN:42972380:end --><!-- HN:42972854:start -->
* [42972854](https://news.social-protocols.org/stats?id=42972854) #29 9 points 14 comments -> [AI dialogue analysis confirms movies have grown more violent over past 70 years](https://phys.org/news/2025-02-ai-driven-dialogue-analysis-popular.html)<!-- HN:42972854:end --><!-- HN:42972722:start -->
* [42972722](https://news.social-protocols.org/stats?id=42972722) #6 27 points 9 comments -> [Personal Software Is Becoming a Trend](https://xuanwo.io/links/2025/02/personal-software-is-becoming-a-trend/)<!-- HN:42972722:end --><!-- HN:42972678:start -->
* [42972678](https://news.social-protocols.org/stats?id=42972678) #20 27 points 7 comments -> [Multiple security flaws found in DeepSeek iOS app, incl sending unencrypted data](https://9to5mac.com/2025/02/07/multiple-security-flaws-found-in-deepseek-ios-app-including-sending-unencrypted-data/)<!-- HN:42972678:end --><!-- HN:42972910:start -->
* [42972910](https://news.social-protocols.org/stats?id=42972910) #28 12 points 0 comments -> [Gleam v1.8.0 Released](https://gleam.run/news/gleam-gets-rename-variable/)<!-- HN:42972910:end --><!-- HN:42973989:start -->
* [42973989](https://news.social-protocols.org/stats?id=42973989) #28 15 points 12 comments -> [AI Startup School with Elon Musk, Satya Nadella, Sam Altman, Andrej Karpathy](https://events.ycombinator.com/ai-sus)<!-- HN:42973989:end --><!-- HN:42975057:start -->
* [42975057](https://news.social-protocols.org/stats?id=42975057) #24 4 points 0 comments -> [A fourth federal agency locks its doors to Democratic lawmakers](https://www.axios.com/2025/02/07/house-democrats-education-department-doge-musk)<!-- HN:42975057:end --><!-- HN:42975431:start -->
* [42975431](https://news.social-protocols.org/stats?id=42975431) #27 16 points 0 comments -> [This ain't the Apprentice. Stop Calling Them Firings. They're Purges](https://talkingpointsmemo.com/morning-memo/this-aint-the-apprentice-stop-calling-them-firings-theyre-purges)<!-- HN:42975431:end --><!-- HN:42976352:start -->
* [42976352](https://news.social-protocols.org/stats?id=42976352) #27 4 points 0 comments -> [GCC 15 Compiler Showing Off Nice Performance Improvements on AMD Zen 5](https://www.phoronix.com/review/gcc-15-amd-zen5/4)<!-- HN:42976352:end --><!-- HN:42976278:start -->
* [42976278](https://news.social-protocols.org/stats?id=42976278) #28 3 points 0 comments -> [Commenters Cry Foul After Popular Silicon Valley Forum Bans Politics (2016)](https://www.buzzfeednews.com/article/nitashatiku/silicon-valleys-most-popular-forum-bans-stories-about-politi)<!-- HN:42976278:end --><!-- HN:42936253:start -->
* [42936253](https://news.social-protocols.org/stats?id=42936253) #18 25 points 4 comments -> [Don't Delegate Understanding](https://stephango.com/understand)<!-- HN:42936253:end --><!-- HN:42976716:start -->
* [42976716](https://news.social-protocols.org/stats?id=42976716) #9 7 points 0 comments -> [The Purge – By Dan Rather and Team Steady](https://steady.substack.com/p/the-purge)<!-- HN:42976716:end --><!-- HN:42977332:start -->
* [42977332](https://news.social-protocols.org/stats?id=42977332) #29 53 points 8 comments -> [Long Covid impacting more than 1M children: CDC study suggests](https://abcnews.go.com/Health/long-covid-impacting-1-million-children-cdc-study/story?id=118393880)<!-- HN:42977332:end --><!-- HN:42978060:start -->
* [42978060](https://news.social-protocols.org/stats?id=42978060) #29 16 points 0 comments -> [Surely You're a Creep, Mr. Feynman (2019)](https://thebaffler.com/outbursts/surely-youre-a-creep-mr-feynman-mcneill)<!-- HN:42978060:end --><!-- HN:42978228:start -->
* [42978228](https://news.social-protocols.org/stats?id=42978228) #5 6 points 3 comments -> [Consistent Jailbreaking Method in o1, o3, and 4o](https://generalanalysis.com/blog/jailbreaking_techniques)<!-- HN:42978228:end --><!-- HN:42978758:start -->
* [42978758](https://news.social-protocols.org/stats?id=42978758) #28 5 points 0 comments -> [Gleichschaltung](https://en.wikipedia.org/wiki/Gleichschaltung)<!-- HN:42978758:end -->
#### **Saturday, February 8, 2025**
<!-- HN:42979855:start -->
* [42979855](https://news.social-protocols.org/stats?id=42979855) #11 8 points 4 comments -> [Aliens Cause Global Warming – Michael Crichton [pdf]](https://stephenschneider.stanford.edu/Publications/PDF_Papers/Crichton2003.pdf)<!-- HN:42979855:end --><!-- HN:42953044:start -->
* [42953044](https://news.social-protocols.org/stats?id=42953044) #7 7 points 1 comments -> [25 Years Ago, Joan Didion Kept a Diary. It's About to Become Public](https://www.nytimes.com/2025/02/05/books/new-book-joan-didion-notes-to-john.html)<!-- HN:42953044:end --><!-- HN:42938235:start -->
* [42938235](https://news.social-protocols.org/stats?id=42938235) #22 22 points 4 comments -> [Unobtanium 6502 based KIM-1 part now obtanium with FPGA](https://blog.paulsajna.com/fpga-mcs6530-rriot/)<!-- HN:42938235:end --><!-- HN:42983180:start -->
* [42983180](https://news.social-protocols.org/stats?id=42983180) #15 4 points 4 comments -> [The Puzzle](https://silence.bearblog.dev/the-puzzle/)<!-- HN:42983180:end --><!-- HN:42983148:start -->
* [42983148](https://news.social-protocols.org/stats?id=42983148) #13 47 points 32 comments -> [Show HN: FreeDemandLetter – A Weapon for Anyone Who's Sick of Getting Shafted](https://www.freedemandletter.com)<!-- HN:42983148:end --><!-- HN:42954058:start -->
* [42954058](https://news.social-protocols.org/stats?id=42954058) #15 21 points 5 comments -> [Global Caps Lock Key](https://globalcapslock.com)<!-- HN:42954058:end --><!-- HN:42956261:start -->
* [42956261](https://news.social-protocols.org/stats?id=42956261) #15 6 points 6 comments -> [I Applied Wavelet Transforms to AI and Found Hidden Structure](https://zenodo.org/records/14799070)<!-- HN:42956261:end --><!-- HN:42986335:start -->
* [42986335](https://news.social-protocols.org/stats?id=42986335) #13 47 points 21 comments -> [Mark Zuckerberg messages Facebook engineer](https://twitter.com/TechEmails/status/1888313183024074910)<!-- HN:42986335:end -->
#### **Sunday, February 9, 2025**
<!-- HN:42949631:start -->
* [42949631](https://news.social-protocols.org/stats?id=42949631) #14 11 points 7 comments -> [Who Is Being Excluded by Museums' Wholesale Adoption of Digital Technology?](https://amuseumfornow.com/blog/who-is-being-excluded-by-museums-wholesale-adoption-of-digital-technology)<!-- HN:42949631:end --><!-- HN:42961442:start -->
* [42961442](https://news.social-protocols.org/stats?id=42961442) #28 13 points 10 comments -> [Enter OpenEuroLLM, an 'Open, Compliant, Diverse' Series of Foundation Models](https://slator.com/enter-openeurollm-open-compliant-diverse-series-of-foundation-models/)<!-- HN:42961442:end --><!-- HN:42988416:start -->
* [42988416](https://news.social-protocols.org/stats?id=42988416) #30 5 points 1 comments -> [Scientists just cracked the perfect boiled egg](https://www.pbs.org/newshour/science/scientists-just-cracked-the-perfect-boiled-egg)<!-- HN:42988416:end --><!-- HN:42988706:start -->
* [42988706](https://news.social-protocols.org/stats?id=42988706) #27 8 points 1 comments -> [Experts Call for an Immediate Ban on Magic Sponges for Household Cleaning](https://jasondeegan.com/experts-call-for-an-immediate-ban-on-magic-sponges-for-household-cleaning/)<!-- HN:42988706:end --><!-- HN:42986149:start -->
* [42986149](https://news.social-protocols.org/stats?id=42986149) #25 53 points 8 comments -> [Ada Gems (2014)](https://www.adacore.com/gems)<!-- HN:42986149:end --><!-- HN:42946223:start -->
* [42946223](https://news.social-protocols.org/stats?id=42946223) #26 194 points 59 comments -> [RISC-V Mainboard for Framework Laptop 13 is now available](https://frame.work/gb/en/blog/risc-v-mainboard-for-framework-laptop-13-is-now-available)<!-- HN:42946223:end --><!-- HN:42989306:start -->
* [42989306](https://news.social-protocols.org/stats?id=42989306) #23 7 points 1 comments -> [FOSDEM 2025 – How we are defending Software Freedom against Apple at the EU's h [video]](https://fosdem.org/2025/schedule/event/fosdem-2025-5084-how-we-are-defending-software-freedom-against-apple-at-the-eu-s-highest-court/)<!-- HN:42989306:end --><!-- HN:42990037:start -->
* [42990037](https://news.social-protocols.org/stats?id=42990037) #21 9 points 2 comments -> [Things USAID has funded [video]](https://www.youtube.com/watch?v=Pdw31c6HPCI)<!-- HN:42990037:end --><!-- HN:42990401:start -->
* [42990401](https://news.social-protocols.org/stats?id=42990401) #17 13 points 1 comments -> [Frontier AI systems have surpassed the self-replicating red line](https://arxiv.org/abs/2412.12140)<!-- HN:42990401:end --><!-- HN:42986485:start -->
* [42986485](https://news.social-protocols.org/stats?id=42986485) #19 205 points 163 comments -> [Is Software Abstraction Killing Civilization? (2021)](https://datagubbe.se/endofciv/)<!-- HN:42986485:end --><!-- HN:42990815:start -->
* [42990815](https://news.social-protocols.org/stats?id=42990815) #19 7 points 2 comments -> [TikTok Almost Won the Presidency for Romania's Far-Right Candidate](https://context.ro/how-tiktok-almost-won-the-presidency-for-romanias-far-right-candidate/)<!-- HN:42990815:end --><!-- HN:42991750:start -->
* [42991750](https://news.social-protocols.org/stats?id=42991750) #10 13 points 1 comments -> [CFPB 404: Page not found](https://www.consumerfinance.gov/)<!-- HN:42991750:end --><!-- HN:42971675:start -->
* [42971675](https://news.social-protocols.org/stats?id=42971675) #19 3 points 0 comments -> [René Girard and the Mimetic Trap](https://onepercentrule.substack.com/p/the-mimetic-trap)<!-- HN:42971675:end --><!-- HN:42992304:start -->
* [42992304](https://news.social-protocols.org/stats?id=42992304) #14 -> [Teen on Musk's DOGE Team Graduated from 'The Com'](https://krebsonsecurity.com/2025/02/teen-on-musks-doge-team-graduated-from-the-com/)<!-- HN:42992304:end --><!-- HN:42992365:start -->
* [42992365](https://news.social-protocols.org/stats?id=42992365) #13 5 points 1 comments -> [The "Need for Chaos" Voter](https://www.forkingpaths.co/p/the-need-for-chaos-voter-a68)<!-- HN:42992365:end --><!-- HN:42991830:start -->
* [42991830](https://news.social-protocols.org/stats?id=42991830) #15 19 points 40 comments -> [Mission Accomplished? Heat pump adoption has a long way to go](https://www.heatpumped.org/p/mission-accomplished-heat-pump-adoption-has-a-long-way-to-go)<!-- HN:42991830:end --><!-- HN:42994006:start -->
* [42994006](https://news.social-protocols.org/stats?id=42994006) #3 -> [Artifical ballot generation script by DOGE Engineer Ethan Shaotran](https://github.com/DevrathIyer/ballotproof/blob/master/generate.py)<!-- HN:42994006:end --><!-- HN:42994281:start -->
* [42994281](https://news.social-protocols.org/stats?id=42994281) #25 9 points 0 comments -> [Keir Starmer appoints Jeff Bezos as his "first buddy"](https://pluralistic.net/2025/01/22/autocrats-of-trade/)<!-- HN:42994281:end --><!-- HN:42993661:start -->
* [42993661](https://news.social-protocols.org/stats?id=42993661) #10 34 points 40 comments -> [Music Generation AI Models](https://www.maximepeabody.com/blog/music-ai-models)<!-- HN:42993661:end --><!-- HN:42995174:start -->
* [42995174](https://news.social-protocols.org/stats?id=42995174) #6 7 points 0 comments -> [DOGE Exposes Once-Secret Government Networks, Making Cyber-Espionage Easier Than](https://cyberintel.substack.com/p/doge-exposes-once-secret-government)<!-- HN:42995174:end -->
#### **Monday, February 10, 2025**
<!-- HN:42995524:start -->
* [42995524](https://news.social-protocols.org/stats?id=42995524) #30 13 points 0 comments -> [IT Unemployment Rises to 5.7% as AI Hits Tech Jobs](https://www.wsj.com/articles/it-unemployment-rises-to-5-7-as-ai-hits-tech-jobs-7726bb1b)<!-- HN:42995524:end --><!-- HN:42995453:start -->
* [42995453](https://news.social-protocols.org/stats?id=42995453) #2 18 points 5 comments -> [Clark County Election Analysis](https://electiontruthalliance.org/2024-us-election-analysis)<!-- HN:42995453:end --><!-- HN:42971044:start -->
* [42971044](https://news.social-protocols.org/stats?id=42971044) #21 15 points 0 comments -> [Why We Chose the Name Attio](https://attio.com/blog/how-we-chose-the-name-attio)<!-- HN:42971044:end --><!-- HN:42995886:start -->
* [42995886](https://news.social-protocols.org/stats?id=42995886) #1 -> [USPS Is a Failed Sovereign Wealth Fund](https://gopostal.substack.com/p/usps-is-a-failed-sovereign-wealth)<!-- HN:42995886:end --><!-- HN:42996690:start -->
* [42996690](https://news.social-protocols.org/stats?id=42996690) #1 8 points 1 comments -> [WTF Are Popcorn Tasks?](https://madole.xyz/blog/wtf-are-popcorn-tasks)<!-- HN:42996690:end --><!-- HN:42997285:start -->
* [42997285](https://news.social-protocols.org/stats?id=42997285) #11 9 points 1 comments -> [Judge denies union demand to block DOGE's access to Labor Department data](https://www.politico.com/news/2025/02/07/judge-denies-lawsuit-union-musk-doge-labor-department-00203245)<!-- HN:42997285:end --><!-- HN:42995403:start -->
* [42995403](https://news.social-protocols.org/stats?id=42995403) #24 35 points 40 comments -> [Reflect Orbital: Sunlight after dark using a constellation of spatial reflectors](https://www.reflectorbital.com/)<!-- HN:42995403:end --><!-- HN:42999044:start -->
* [42999044](https://news.social-protocols.org/stats?id=42999044) #24 29 points 40 comments -> [Man who lost Bitcoin fortune in Welsh tip explores purchase of entire landfill](https://www.theguardian.com/technology/2025/feb/10/man-who-lost-bitcoin-fortune-in-welsh-tip-explores-purchase-of-entire-landfill)<!-- HN:42999044:end --><!-- HN:42999742:start -->
* [42999742](https://news.social-protocols.org/stats?id=42999742) #23 3 points 0 comments -> [AI is accelerating scientific production, not progress](https://twitter.com/random_walker/status/1888919433671843947)<!-- HN:42999742:end --><!-- HN:42997647:start -->
* [42997647](https://news.social-protocols.org/stats?id=42997647) #28 98 points 96 comments -> [Apple's Best Option: Decentralize iCloud](https://www.mnot.net/blog/2025/02/09/decentralize-icloud)<!-- HN:42997647:end --><!-- HN:42999464:start -->
* [42999464](https://news.social-protocols.org/stats?id=42999464) #24 14 points 11 comments -> [The Crisis in Tech's Obsession with Junior Talent](https://medium.com/mr-plan-publication/8-out-of-10-senior-engineers-feel-undervalued-the-hidden-crisis-in-techs-obsession-with-junior-fa9cc62b1e8e)<!-- HN:42999464:end --><!-- HN:43000170:start -->
* [43000170](https://news.social-protocols.org/stats?id=43000170) #3 7 points 1 comments -> [Show HN: Hanko – Open-Source Auth and User Management for the Passkey Era](https://www.hanko.io/)<!-- HN:43000170:end --><!-- HN:42993044:start -->
* [42993044](https://news.social-protocols.org/stats?id=42993044) #21 120 points 9 comments -> [OpenStreetMap Calendar](https://osmcal.org/)<!-- HN:42993044:end --><!-- HN:42996831:start -->
* [42996831](https://news.social-protocols.org/stats?id=42996831) #17 145 points 82 comments -> [How does Ada's memory safety compare against Rust?](https://ajxs.me/blog/How_Does_Adas_Memory_Safety_Compare_Against_Rust.html)<!-- HN:42996831:end --><!-- HN:42999088:start -->
* [42999088](https://news.social-protocols.org/stats?id=42999088) #12 56 points 26 comments -> [Beavers finish seven-year dam project in two days saving – $1M](https://www.nationalgeographic.com/animals/article/beaver-dam-czech-republic)<!-- HN:42999088:end --><!-- HN:42975885:start -->
* [42975885](https://news.social-protocols.org/stats?id=42975885) #9 16 points 3 comments -> [We rewrote The NYT text editing library. Then we OSSd it. Then rewrote it again](https://smoores.dev/post/we_rewrote_nyt_text_editing/)<!-- HN:42975885:end --><!-- HN:42992345:start -->
* [42992345](https://news.social-protocols.org/stats?id=42992345) #19 144 points 96 comments -> [Persistent packages on Steam Deck using Nix](https://chrastecky.dev/gaming/persistent-packages-on-steam-deck-using-nix)<!-- HN:42992345:end --><!-- HN:42994440:start -->
* [42994440](https://news.social-protocols.org/stats?id=42994440) #23 144 points 25 comments -> [Show HN: Searchable library of free audiobooks](https://booksearch.party/)<!-- HN:42994440:end --><!-- HN:43000511:start -->
* [43000511](https://news.social-protocols.org/stats?id=43000511) #10 4 points 0 comments -> [LemonTV – Cross platform torrent streaming app](https://lemontv.xyz)<!-- HN:43000511:end --><!-- HN:43002492:start -->
* [43002492](https://news.social-protocols.org/stats?id=43002492) #11 33 points 23 comments -> [The Physicians Are Healing Themselves, with Ozempic](https://www.nytimes.com/2025/02/10/health/doctors-ozempic-weight-loss.html)<!-- HN:43002492:end --><!-- HN:43003953:start -->
* [43003953](https://news.social-protocols.org/stats?id=43003953) #21 5 points 0 comments -> [Corporate "DEI" is an imperfect vehicle for deeply meaningful ideas](https://charity.wtf/2025/02/10/corporate-dei-is-an-imperfect-vehicle-for-deeply-meaningful-ideals/)<!-- HN:43003953:end --><!-- HN:43005535:start -->
* [43005535](https://news.social-protocols.org/stats?id=43005535) #5 10 points 2 comments -> [It Is a Coup](https://broligarchy.substack.com/p/it-is-a-coup)<!-- HN:43005535:end --><!-- HN:43005265:start -->
* [43005265](https://news.social-protocols.org/stats?id=43005265) #21 13 points 2 comments -> [Duolingo Handbook](https://handbook.duolingo.com)<!-- HN:43005265:end --><!-- HN:43006172:start -->
* [43006172](https://news.social-protocols.org/stats?id=43006172) #10 14 points 1 comments -> [Musk-led group makes $97.4B bid for ChatGPT maker OpenAI](https://www.bbc.co.uk/news/articles/cpdx75zgg88o)<!-- HN:43006172:end --><!-- HN:43006097:start -->
* [43006097](https://news.social-protocols.org/stats?id=43006097) #7 3 points 0 comments -> [Frontier AI systems have surpassed the self-replicating red line](https://arxiv.org/abs/2412.12140)<!-- HN:43006097:end -->
#### **Tuesday, February 11, 2025**
<!-- HN:43007564:start -->
* [43007564](https://news.social-protocols.org/stats?id=43007564) #25 30 points 22 comments -> [Google Calendar removed events like Pride and BHM; retains Black Friday](https://www.theverge.com/news/608858/google-calendar-missing-events-holidays)<!-- HN:43007564:end --><!-- HN:43007862:start -->
* [43007862](https://news.social-protocols.org/stats?id=43007862) #26 52 points 13 comments -> [Danes sign petition to buy California from U.S.](https://ktla.com/news/california/thousands-of-danes-sign-petition-to-buy-california-from-u-s/amp/)<!-- HN:43007862:end --><!-- HN:43008340:start -->
* [43008340](https://news.social-protocols.org/stats?id=43008340) #19 5 points 0 comments -> [Trump's Orders on Gender Put Science Back in the Driver's Seat](https://www.newsweek.com/trumps-orders-gender-put-science-back-drivers-seat-opinion-2027532)<!-- HN:43008340:end --><!-- HN:43008417:start -->
* [43008417](https://news.social-protocols.org/stats?id=43008417) #23 34 points 16 comments -> [What are non intelligent people like me supposed to do for money?](https://www.reddit.com/r/findapath/s/Me91Ke0COG)<!-- HN:43008417:end --><!-- HN:43009729:start -->
* [43009729](https://news.social-protocols.org/stats?id=43009729) #29 5 points 3 comments -> [Musk-led group makes $97.4B bid for ChatGPT maker OpenAI](https://www.bbc.com/news/articles/cpdx75zgg88o)<!-- HN:43009729:end --><!-- HN:43011257:start -->
* [43011257](https://news.social-protocols.org/stats?id=43011257) #11 19 points 42 comments -> [Altman: OpenAI not for sale, especially to competitor who is not able to beat us](https://www.axios.com/2025/02/11/openai-altman-musk-offer)<!-- HN:43011257:end --><!-- HN:43010662:start -->
* [43010662](https://news.social-protocols.org/stats?id=43010662) #28 68 points 81 comments -> [Sid Meier's Civilization VII](https://civilization.2k.com/civ-vii/buy/)<!-- HN:43010662:end --><!-- HN:43011989:start -->
* [43011989](https://news.social-protocols.org/stats?id=43011989) #12 4 points 2 comments -> [Most Harvard students are unemployed, tech companies prefer H1B workers](https://twitter.com/soulofpetronius/status/1871977670256238833)<!-- HN:43011989:end --><!-- HN:43012390:start -->
* [43012390](https://news.social-protocols.org/stats?id=43012390) #18 5 points 0 comments -> [UK and US refuse to sign international AI declaration](https://www.bbc.com/news/articles/c8edn0n58gwo)<!-- HN:43012390:end --><!-- HN:43007052:start -->
* [43007052](https://news.social-protocols.org/stats?id=43007052) #25 75 points 144 comments -> [Google Maps now shows the 'Gulf of America'](https://www.theverge.com/news/609772/google-maps-gulf-of-america-rename-mexico)<!-- HN:43007052:end --><!-- HN:43011535:start -->
* [43011535](https://news.social-protocols.org/stats?id=43011535) #22 11 points 1 comments -> [Enterprise Is Dead](https://cra.mr/enterprise-is-dead/)<!-- HN:43011535:end --><!-- HN:43014321:start -->
* [43014321](https://news.social-protocols.org/stats?id=43014321) #10 7 points 0 comments -> [Proton Wallet is now available for all](https://primal.net/e/note1fus8glne8684xtn3n8lt2wjztsjss6k4jmc56ttl573ngxczerlqp84g9m)<!-- HN:43014321:end --><!-- HN:43014716:start -->
* [43014716](https://news.social-protocols.org/stats?id=43014716) #8 15 points 9 comments -> [The Curious Similarity Between LLMs and Quantum Mechanics](https://robleclerc.substack.com/p/the-curious-similarity-between-llms)<!-- HN:43014716:end --><!-- HN:43015271:start -->
* [43015271](https://news.social-protocols.org/stats?id=43015271) #5 8 points 9 comments -> [Show HN: I built an AI coloring page generator](https://www.colori.io/)<!-- HN:43015271:end --><!-- HN:42989340:start -->
* [42989340](https://news.social-protocols.org/stats?id=42989340) #18 12 points 0 comments -> [Tariff Engineering](https://www.readtrung.com/p/tariff-engineering-explained)<!-- HN:42989340:end --><!-- HN:43016703:start -->
* [43016703](https://news.social-protocols.org/stats?id=43016703) #28 -> [DOGE Teen Ran Image-Sharing Site Linked to Pedophilia and the KKK](https://www.muskwatch.com/p/doge-teen-ran-image-sharing-site)<!-- HN:43016703:end --><!-- HN:43018223:start -->
* [43018223](https://news.social-protocols.org/stats?id=43018223) #19 6 points 1 comments -> [Man who lost $780M in Bitcoin in a landfill now wants to buy the dump](https://www.tomshardware.com/tech-industry/cryptocurrency/landfill-concealing-8-000-bitcoins-valued-at-usd780m-to-transform-into-a-solar-farm-but-man-now-wishes-to-buy-the-site)<!-- HN:43018223:end --><!-- HN:43018790:start -->
* [43018790](https://news.social-protocols.org/stats?id=43018790) #10 6 points 1 comments -> [Letters from BBC Television Licensing](http://www.bbctvlicence.com/)<!-- HN:43018790:end --><!-- HN:43014070:start -->
* [43014070](https://news.social-protocols.org/stats?id=43014070) #19 74 points 11 comments -> [Get in loser. We're rewinding the stack](https://andrews.substack.com/p/get-in-loser-were-rewinding-the-stack)<!-- HN:43014070:end -->
#### **Wednesday, February 12, 2025**<!-- HN:42985614:start -->
* [42985614](https://news.social-protocols.org/stats?id=42985614) #16 3 points 0 comments -> [Creality Space Pi Filament Dryer Plus: Review and Specs](https://syntaxglow.com/2025/02/08/creality-space-pi-filament-dryer-plus-review-specs/)<!-- HN:42985614:end --><!-- HN:43021333:start -->
* [43021333](https://news.social-protocols.org/stats?id=43021333) #10 224 points 112 comments -> [Resist Authoritarianism by Refusing to Obey in Advance (2017)](https://lithub.com/resist-authoritarianism-by-refusing-to-obey-in-advance/)<!-- HN:43021333:end --><!-- HN:43020684:start -->
* [43020684](https://news.social-protocols.org/stats?id=43020684) #11 293 points 260 comments -> [WASM will replace containers](https://creston.blog/wasm-will-replace-containers/)<!-- HN:43020684:end --><!-- HN:42994590:start -->
* [42994590](https://news.social-protocols.org/stats?id=42994590) #12 230 points 58 comments -> [Smoke in the cabin of two 737 MAX caused by Load Reduction Device system [video]](https://www.youtube.com/watch?v=swlVkYVSlIE)<!-- HN:42994590:end --><!-- HN:43019737:start -->
* [43019737](https://news.social-protocols.org/stats?id=43019737) #13 99 points 40 comments -> [Migrate purchases from one Apple Account to another](https://support.apple.com/en-us/117294)<!-- HN:43019737:end --><!-- HN:43021515:start -->
* [43021515](https://news.social-protocols.org/stats?id=43021515) #17 147 points 97 comments -> [jj: a Git-compatible VCS that is both simple and powerful](https://github.com/jj-vcs/jj)<!-- HN:43021515:end --><!-- HN:43023655:start -->
* [43023655](https://news.social-protocols.org/stats?id=43023655) #30 9 points 3 comments -> [The Tao of Go](https://bitfieldconsulting.com/posts/tao-of-go)<!-- HN:43023655:end --><!-- HN:42986629:start -->
* [42986629](https://news.social-protocols.org/stats?id=42986629) #20 55 points 28 comments -> [Show HN: App that simulates a software engineer's daily job](https://mock-job-mentor.vercel.app/dashboard)<!-- HN:42986629:end --><!-- HN:43025266:start -->
* [43025266](https://news.social-protocols.org/stats?id=43025266) #23 8 points 4 comments -> [Delivering Malware Through Abandoned Amazon S3 Buckets](https://www.schneier.com/blog/archives/2025/02/delivering-malware-through-abandoned-amazon-s3-buckets.html)<!-- HN:43025266:end --><!-- HN:43025420:start -->
* [43025420](https://news.social-protocols.org/stats?id=43025420) #21 4 points 0 comments -> [Representation of BBC News Content in AI Assistants [pdf]](https://www.bbc.co.uk/aboutthebbc/documents/bbc-research-into-ai-assistants.pdf)<!-- HN:43025420:end --><!-- HN:43026302:start -->
* [43026302](https://news.social-protocols.org/stats?id=43026302) #18 5 points 0 comments -> [Ignorance is bliss when you're drowning in information](https://www.theregister.com/2025/02/12/ignorance_really_is_bliss/)<!-- HN:43026302:end --><!-- HN:43026455:start -->
* [43026455](https://news.social-protocols.org/stats?id=43026455) #27 3 points 0 comments -> [The secret behind sharp vision: the benefits of tiny eye movements](https://medicalxpress.com/news/2025-02-secret-sharp-vision-reveals-benefits.html)<!-- HN:43026455:end --><!-- HN:43026104:start -->
* [43026104](https://news.social-protocols.org/stats?id=43026104) #21 29 points 1 comments -> [Syd: An Introduction to Secure Application Sandboxing for Linux [video]](https://fosdem.org/2025/schedule/event/fosdem-2025-4176-syd-an-introduction-to-secure-application-sandboxing-for-linux/)<!-- HN:43026104:end --><!-- HN:43028063:start -->
* [43028063](https://news.social-protocols.org/stats?id=43028063) #8 4 points 1 comments -> [Let's Buy California – Denmark's Next Big Adventure](https://denmarkification.com/)<!-- HN:43028063:end --><!-- HN:43028641:start -->
* [43028641](https://news.social-protocols.org/stats?id=43028641) #8 9 points 1 comments -> [Startup Funding Roadmap](https://anyonyashraya.com/on_startup_funding.html)<!-- HN:43028641:end -->
#### **Thursday, February 13, 2025**
<!-- HN:43031367:start -->
* [43031367](https://news.social-protocols.org/stats?id=43031367) #8 10 points 2 comments -> [Help Denmark Buy California – Because Why Not?](https://denmarkification.com/)<!-- HN:43031367:end --><!-- HN:43032112:start -->
* [43032112](https://news.social-protocols.org/stats?id=43032112) #24 16 points 11 comments -> [Apple Resumes Advertising on X](https://www.macrumors.com/2025/02/12/apple-resumes-advertising-on-x/)<!-- HN:43032112:end --><!-- HN:43032540:start -->
* [43032540](https://news.social-protocols.org/stats?id=43032540) #2 7 points 0 comments -> [More than 100 women kept as slaves in illegal egg harvesting farm in Georgia](https://thenewfeminist.co.uk/2025/02/more-than-100-women-kept-as-slaves-in-illegal-egg-harvesting-farm-in-georgia/)<!-- HN:43032540:end --><!-- HN:43032999:start -->
* [43032999](https://news.social-protocols.org/stats?id=43032999) #18 8 points 1 comments -> [AI column-smashes words, concocts scientific term now used in 20 papers](https://boingboing.net/2025/02/12/fancy-science-journal-caught-publishing-nonsense-term-vegetative-electron-microscopy-doubles-down.html)<!-- HN:43032999:end -->