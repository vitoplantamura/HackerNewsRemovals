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

#### **Wednesday, September 18, 2024**
<!-- HN:41524517:start -->
* [41524517](https://news.social-protocols.org/stats?id=41524517) #8 34 points 9 comments -> [Ribbit: A portable, compact and extensible R4RS Scheme implementation](https://github.com/udem-dlteam/ribbit)<!-- HN:41524517:end --><!-- HN:41552132:start -->
* [41552132](https://news.social-protocols.org/stats?id=41552132) #12 5 points 1 comments -> [The Illusion of a Pagan West](https://unherd.com/2024/09/the-illusion-of-a-pagan-west/)<!-- HN:41552132:end --><!-- HN:41577717:start -->
* [41577717](https://news.social-protocols.org/stats?id=41577717) #4 8 points 11 comments -> [Show HN: Free AI tailored workout generator](https://www.workoutgenerator.fit)<!-- HN:41577717:end --><!-- HN:41578117:start -->
* [41578117](https://news.social-protocols.org/stats?id=41578117) #3 24 points 22 comments -> [Tax the Rich – European Citizens' Initiative](https://www.tax-the-rich.eu)<!-- HN:41578117:end --><!-- HN:41529435:start -->
* [41529435](https://news.social-protocols.org/stats?id=41529435) #3 86 points 19 comments -> [Haxe lang – build cross-platform application with fast cross-compiler](https://haxe.org)<!-- HN:41529435:end --><!-- HN:41528598:start -->
* [41528598](https://news.social-protocols.org/stats?id=41528598) #23 67 points 4 comments -> [Scrolling Text Display](http://www.technoblogy.com/show?4WX8)<!-- HN:41528598:end --><!-- HN:41579730:start -->
* [41579730](https://news.social-protocols.org/stats?id=41579730) #19 5 points 0 comments -> [U.S. Shrugs as World War III Approaches](https://www.wsj.com/opinion/u-s-shrugs-as-world-war-iii-approaches-devastating-bipartisan-report-716bda71)<!-- HN:41579730:end --><!-- HN:41580375:start -->
* [41580375](https://news.social-protocols.org/stats?id=41580375) #19 7 points 0 comments -> [Israel detonates Hezbollah walkie-talkies in second wave after pager attack](https://www.axios.com/2024/09/18/israel-detonates-hezbollah-walkie-talkies-second-wave-after-pager-attack)<!-- HN:41580375:end --><!-- HN:41580214:start -->
* [41580214](https://news.social-protocols.org/stats?id=41580214) #19 30 points 7 comments -> [Walkie talkies explode across Lebanon a day after pager explosions](https://www.dailymail.co.uk/news/article-13864883/Lebanon-explosions-Hezbollah-communications-devices-detonate-country-pager-bomb.html)<!-- HN:41580214:end --><!-- HN:41583139:start -->
* [41583139](https://news.social-protocols.org/stats?id=41583139) #27 7 points 1 comments -> [How Wikipedia Became a Propaganda Site](https://www.thefp.com/p/how-wikipedia-became-propaganda-site)<!-- HN:41583139:end --><!-- HN:41582958:start -->
* [41582958](https://news.social-protocols.org/stats?id=41582958) #13 6 points 0 comments -> [The San Francisco Freedom Club](https://www.sffc.party)<!-- HN:41582958:end --><!-- HN:41583294:start -->
* [41583294](https://news.social-protocols.org/stats?id=41583294) #30 13 points 1 comments -> [Walkie-talkie explosions rock Lebanon a day after pager attacks](https://apnews.com/live/lebanon-syria-pagers-hezbollah-updates)<!-- HN:41583294:end --><!-- HN:41585624:start -->
* [41585624](https://news.social-protocols.org/stats?id=41585624) #6 5 points 1 comments -> [Seventh Day Adventists, fighting onanism, and selling veganism to America](https://josepheverettwil.substack.com/p/the-shady-story-behind-why-we-think)<!-- HN:41585624:end -->
#### **Thursday, September 19, 2024**
<!-- HN:41538009:start -->
* [41538009](https://news.social-protocols.org/stats?id=41538009) #11 13 points 5 comments -> [Are You Qualified to Use Null in SQL?](https://agentm.github.io/project-m36/posts/2024-07-16-are-you-qualified-to-use-null.html)<!-- HN:41538009:end --><!-- HN:41587900:start -->
* [41587900](https://news.social-protocols.org/stats?id=41587900) #11 10 points 26 comments -> [Strange Design Decision: An Oven with French Doors](https://www.core77.com/posts/133639/Strange-Design-Decision-An-Oven-with-French-Doors)<!-- HN:41587900:end --><!-- HN:41590030:start -->
* [41590030](https://news.social-protocols.org/stats?id=41590030) #7 11 points 4 comments -> [Diversification is a negative price lunch](https://outcastbeta.com/diversification-is-a-negative-price-lunch/)<!-- HN:41590030:end --><!-- HN:41580502:start -->
* [41580502](https://news.social-protocols.org/stats?id=41580502) #11 255 points 147 comments -> [0day Contest for End-of-Life Devices Announced](https://www.districtcon.org/junkyard)<!-- HN:41580502:end --><!-- HN:41580166:start -->
* [41580166](https://news.social-protocols.org/stats?id=41580166) #12 210 points 107 comments -> [Bento: Jupyter Notebooks at Meta](https://engineering.fb.com/2024/09/17/data-infrastructure/inside-bento-jupyter-notebooks-at-meta/)<!-- HN:41580166:end --><!-- HN:41583689:start -->
* [41583689](https://news.social-protocols.org/stats?id=41583689) #15 108 points 126 comments -> [iOS 18 breaks IMAPS self-signed certs](https://forums.developer.apple.com/forums/thread/756626)<!-- HN:41583689:end --><!-- HN:41574844:start -->
* [41574844](https://news.social-protocols.org/stats?id=41574844) #12 1570 points 799 comments -> [Apple mobile processors are now made in America by TSMC](https://timculpan.substack.com/p/apple-mobile-processors-are-now-made)<!-- HN:41574844:end --><!-- HN:41584486:start -->
* [41584486](https://news.social-protocols.org/stats?id=41584486) #16 383 points 209 comments -> [LinkedIn is now using everyone's content to train their AI tool](https://twitter.com/RachelTobac/status/1836471586624540705)<!-- HN:41584486:end --><!-- HN:41539841:start -->
* [41539841](https://news.social-protocols.org/stats?id=41539841) #17 117 points 4 comments -> [A overview of binaries, ELF, and NoMMU on Linux](http://lists.landley.net/pipermail/toybox-landley.net/2024-January/029957.html)<!-- HN:41539841:end --><!-- HN:41583062:start -->
* [41583062](https://news.social-protocols.org/stats?id=41583062) #21 156 points 33 comments -> [Qwen2.5: A Party of Foundation Models](https://qwenlm.github.io/blog/qwen2.5/)<!-- HN:41583062:end --><!-- HN:41590688:start -->
* [41590688](https://news.social-protocols.org/stats?id=41590688) #15 32 points 15 comments -> [Tech Jobs Have Dried Up–-and Aren't Coming Back Soon](https://www.wsj.com/articles/tech-jobs-artificial-intelligence-cce22393)<!-- HN:41590688:end --><!-- HN:41582461:start -->
* [41582461](https://news.social-protocols.org/stats?id=41582461) #23 160 points 161 comments -> [Microplastics in the olfactory bulb of the human brain](https://jamanetwork.com/journals/jamanetworkopen/fullarticle/2823787)<!-- HN:41582461:end --><!-- HN:41581942:start -->
* [41581942](https://news.social-protocols.org/stats?id=41581942) #27 240 points 102 comments -> [RabbitMQ 4.0](https://github.com/rabbitmq/rabbitmq-server/releases/tag/v4.0.1)<!-- HN:41581942:end --><!-- HN:41586836:start -->
* [41586836](https://news.social-protocols.org/stats?id=41586836) #9 64 points 19 comments -> [Debugging Behind the Iron Curtain (2010)](https://www.jakepoz.com/debugging-behind-the-iron-curtain/)<!-- HN:41586836:end --><!-- HN:41573034:start -->
* [41573034](https://news.social-protocols.org/stats?id=41573034) #26 616 points 341 comments -> [Independent directors of 23andMe resign from board](https://investors.23andme.com/news-releases/news-release-details/independent-directors-23andme-resign-board/)<!-- HN:41573034:end --><!-- HN:41591024:start -->
* [41591024](https://news.social-protocols.org/stats?id=41591024) #11 5 points 0 comments -> [A modest proposal for the regulation of comedy](https://www.newstatesman.com/comment/2024/09/modest-proposal-regulating-comedy-john-gray)<!-- HN:41591024:end --><!-- HN:41590544:start -->
* [41590544](https://news.social-protocols.org/stats?id=41590544) #27 3 points 0 comments -> [Lenovo Yoga with 'Lunar Lake' chip smokes M3 MacBook Air in battery life test](https://www.notebookcheck.net/Lenovo-Yoga-Slim-7i-with-Lunar-Lake-chip-smokes-M3-powered-MacBook-Air-in-battery-life-test-lasts-almost-an-entire-day.890402.0.html)<!-- HN:41590544:end --><!-- HN:41577156:start -->
* [41577156](https://news.social-protocols.org/stats?id=41577156) #30 301 points 120 comments -> [Gentle Guide to Self-Hosting](https://knhash.in/gentle-guide-to-self-hosting/)<!-- HN:41577156:end --><!-- HN:41590319:start -->
* [41590319](https://news.social-protocols.org/stats?id=41590319) #25 11 points 9 comments -> [Apple Gets EU Warning to Open Up iPhone Operating System](https://www.bloomberg.com/news/articles/2024-09-19/apple-faces-eu-warning-to-open-up-iphone-operating-system)<!-- HN:41590319:end --><!-- HN:41583028:start -->
* [41583028](https://news.social-protocols.org/stats?id=41583028) #29 206 points 96 comments -> [Meta AI: "The Future of AI Is Open Source and Decentralized"](https://twitter.com/AIatMeta/status/1834633042339741961)<!-- HN:41583028:end --><!-- HN:41590469:start -->
* [41590469](https://news.social-protocols.org/stats?id=41590469) #30 7 points 3 comments -> [Nirvana fallacy (Perfect solution fallacy)](https://en.wikipedia.org/wiki/Nirvana_fallacy)<!-- HN:41590469:end --><!-- HN:41582278:start -->
* [41582278](https://news.social-protocols.org/stats?id=41582278) #24 209 points 45 comments -> [Senate Vote Tomorrow Could Give Helping Hand to Patent Trolls](https://www.eff.org/deeplinks/2024/09/senate-vote-tomorrow-could-give-helping-hand-patent-trolls)<!-- HN:41582278:end --><!-- HN:41579354:start -->
* [41579354](https://news.social-protocols.org/stats?id=41579354) #29 38 points 2 comments -> [Five hundred and seven Mechanical Movements](https://507movements.com/)<!-- HN:41579354:end --><!-- HN:41575323:start -->
* [41575323](https://news.social-protocols.org/stats?id=41575323) #29 403 points 161 comments -> [Scramble: Open-Source Alternative to Grammarly](https://github.com/zlwaterfield/scramble)<!-- HN:41575323:end --><!-- HN:41587510:start -->
* [41587510](https://news.social-protocols.org/stats?id=41587510) #30 53 points 39 comments -> [YouTube confirms your pause screen is now fair game for ads](https://www.theverge.com/2024/9/18/24248391/youtube-pause-ads-widely-rolling-out)<!-- HN:41587510:end --><!-- HN:41590771:start -->
* [41590771](https://news.social-protocols.org/stats?id=41590771) #21 7 points 0 comments -> [Using RP2040 PIO to drive a poorly-designed display](http://dmitry.gr/?r=06.%20Thoughts&proj=09.ComplexPioMachines)<!-- HN:41590771:end --><!-- HN:41590460:start -->
* [41590460](https://news.social-protocols.org/stats?id=41590460) #23 5 points 0 comments -> [Satisficing](https://en.wikipedia.org/wiki/Satisficing)<!-- HN:41590460:end --><!-- HN:41590384:start -->
* [41590384](https://news.social-protocols.org/stats?id=41590384) #16 14 points 6 comments -> [Rolls-Royce wins pioneering deal to build mini nuclear plants in Czech Republic](https://www.ft.com/content/aee922e1-a29c-4150-ba6d-efba7a3d7bd5)<!-- HN:41590384:end --><!-- HN:41591237:start -->
* [41591237](https://news.social-protocols.org/stats?id=41591237) #2 7 points 0 comments -> [Nebula: Brave's differentially private system for privacy-preserving analytics](https://brave.com/blog/nebula/)<!-- HN:41591237:end --><!-- HN:41591664:start -->
* [41591664](https://news.social-protocols.org/stats?id=41591664) #18 3 points 1 comments -> [Dumb Home](https://dbushell.com/2024/09/19/dumb-home/)<!-- HN:41591664:end --><!-- HN:41580481:start -->
* [41580481](https://news.social-protocols.org/stats?id=41580481) #14 5 points 0 comments -> [Android 15 for Raspberry Pi 5 is here](https://emteria.com/lp/raspberry-pi-imager-android-rpi5)<!-- HN:41580481:end --><!-- HN:41592008:start -->
* [41592008](https://news.social-protocols.org/stats?id=41592008) #5 4 points 2 comments -> [Iran linked hacker group Handala Hack Team claim pager explosions](https://doublepulsar.com/hacker-group-handala-hack-team-claim-battery-explosions-linked-to-israeli-battery-company-5bea086280cd)<!-- HN:41592008:end --><!-- HN:41591765:start -->
* [41591765](https://news.social-protocols.org/stats?id=41591765) #20 22 points 41 comments -> [WSJ: Tech jobs have dried up](https://www.wsj.com/tech/tech-jobs-artificial-intelligence-cce22393)<!-- HN:41591765:end --><!-- HN:41593146:start -->
* [41593146](https://news.social-protocols.org/stats?id=41593146) #30 3 points 0 comments -> ['It's not fun anymore': Fentanyl users rush for treatment as drug deaths drop](https://sfstandard.com/2024/09/19/treatment-rush-potency-down/)<!-- HN:41593146:end --><!-- HN:41591991:start -->
* [41591991](https://news.social-protocols.org/stats?id=41591991) #26 6 points 0 comments -> [The "R" in MTTR: Repair or Recover? What's the Difference?](https://www.causely.io/blog/mttr-meaning/)<!-- HN:41591991:end --><!-- HN:41595042:start -->
* [41595042](https://news.social-protocols.org/stats?id=41595042) #29 3 points 0 comments -> [Homeless people often choose the street over a bed – find out why](https://missionlocal.org/2024/09/sf-homeless-shelters-street-bed-navigation-centers/)<!-- HN:41595042:end --><!-- HN:41594523:start -->
* [41594523](https://news.social-protocols.org/stats?id=41594523) #27 10 points 0 comments -> [There is no antimimetics division V2](https://qntm.org/publ)<!-- HN:41594523:end -->
#### **Friday, September 20, 2024**
<!-- HN:41540542:start -->
* [41540542](https://news.social-protocols.org/stats?id=41540542) #12 170 points 104 comments -> [MicroPython on Flipper Zero](https://lab.flipper.net/apps/upython)<!-- HN:41540542:end --><!-- HN:41548551:start -->
* [41548551](https://news.social-protocols.org/stats?id=41548551) #21 5 points 0 comments -> [Sculpture commemorates 16th century drowning that inspired Shakespeare](https://www.theguardian.com/artanddesign/2024/sep/15/river-stour-sculpture-commemorates-16th-century-drowning-that-inspired-shakespeare)<!-- HN:41548551:end --><!-- HN:41598274:start -->
* [41598274](https://news.social-protocols.org/stats?id=41598274) #21 15 points 5 comments -> [How Stripe Built One of Silicon Valley’s Best Engineering Teams](https://review.firstround.com/how-stripe-built-one-of-silicon-valleys-best-engineering-teams/)<!-- HN:41598274:end --><!-- HN:41599259:start -->
* [41599259](https://news.social-protocols.org/stats?id=41599259) #19 8 points 3 comments -> [Pov: Living in My Car in SF](https://www.youtube.com/watch?v=tonG-OufefQ)<!-- HN:41599259:end --><!-- HN:41560225:start -->
* [41560225](https://news.social-protocols.org/stats?id=41560225) #7 33 points 22 comments -> [Show HN: Microtonal Piano](https://osolmaz.github.io/microtonal-piano/)<!-- HN:41560225:end --><!-- HN:41598170:start -->
* [41598170](https://news.social-protocols.org/stats?id=41598170) #19 176 points 92 comments -> [Why Apple Uses JPEG XL in the iPhone 16 and What It Means for Your Photos](https://petapixel.com/2024/09/18/why-apple-uses-jpeg-xl-in-the-iphone-16-and-what-it-means-for-your-photos/)<!-- HN:41598170:end --><!-- HN:41600170:start -->
* [41600170](https://news.social-protocols.org/stats?id=41600170) #23 16 points 6 comments -> [Young women are starting to leave men behind](https://www.ft.com/content/17606f25-1d03-4f37-b7f4-f39989af9bde)<!-- HN:41600170:end --><!-- HN:41600483:start -->
* [41600483](https://news.social-protocols.org/stats?id=41600483) #28 3 points 0 comments -> [30th-anniversary limited-run PS5 and PS5 Pro bring back mid-'90s gray plastic](https://arstechnica.com/gaming/2024/09/30th-anniversary-limited-run-ps5-and-ps5-pro-bring-back-mid-90s-gray-plastic/)<!-- HN:41600483:end --><!-- HN:41602181:start -->
* [41602181](https://news.social-protocols.org/stats?id=41602181) #17 7 points 0 comments -> [A year in exile: The fading hopes of Nagorno-Karabakh Armenians](https://www.newarab.com/analysis/year-exile-fading-hopes-nagorno-karabakh-armenians)<!-- HN:41602181:end --><!-- HN:41602024:start -->
* [41602024](https://news.social-protocols.org/stats?id=41602024) #23 10 points 14 comments -> [Dry Cask Storage](https://en.wikipedia.org/wiki/Dry_cask_storage)<!-- HN:41602024:end --><!-- HN:41603237:start -->
* [41603237](https://news.social-protocols.org/stats?id=41603237) #18 3 points 0 comments -> [Amazon says workers need to be in the office. Most of Silicon Valley disagrees](https://www.ft.com/content/c7b82efc-9174-4fc0-8f06-6c6a884d5105)<!-- HN:41603237:end --><!-- HN:41602877:start -->
* [41602877](https://news.social-protocols.org/stats?id=41602877) #12 20 points 6 comments -> [Comedian John Mulaney brutally roasts SF techies at Dreamforce](https://sfstandard.com/2024/09/19/comedian-john-mulaney-brutally-roasts-sf-techies-and-ai-at-dreamforce/)<!-- HN:41602877:end --><!-- HN:41603448:start -->
* [41603448](https://news.social-protocols.org/stats?id=41603448) #12 5 points 1 comments -> [Researcher reveals 'catastrophic' security flaw in the Arc browser](https://www.theverge.com/2024/9/20/24249919/arc-browser-boost-firebase-vulnerability-patched)<!-- HN:41603448:end --><!-- HN:41604241:start -->
* [41604241](https://news.social-protocols.org/stats?id=41604241) #26 6 points 2 comments -> [Updates to the Google Photos API](https://developers.google.com/photos/support/updates)<!-- HN:41604241:end --><!-- HN:41604161:start -->
* [41604161](https://news.social-protocols.org/stats?id=41604161) #30 20 points 12 comments -> [Evidence points to Wuhan market as source of Covid-19 outbreak](https://www.newscientist.com/article/2448671-evidence-points-to-wuhan-market-as-source-of-covid-19-outbreak/)<!-- HN:41604161:end --><!-- HN:41603920:start -->
* [41603920](https://news.social-protocols.org/stats?id=41603920) #23 13 points 4 comments -> [Re-opened Three Mile Island will power AI data centers under new deal](https://arstechnica.com/ai/2024/09/re-opened-three-mile-island-will-power-ai-data-centers-under-new-deal/)<!-- HN:41603920:end --><!-- HN:41605202:start -->
* [41605202](https://news.social-protocols.org/stats?id=41605202) #24 6 points 1 comments -> [Qualcomm Approached Intel About a Takeover in Recent Days](https://www.wsj.com/arts-culture/books/graveyard-of-the-pacific-review-broken-by-the-waves-883b6c3a)<!-- HN:41605202:end --><!-- HN:41550404:start -->
* [41550404](https://news.social-protocols.org/stats?id=41550404) #30 14 points 5 comments -> [Ultrasonic Chips Could Cut Interference in the IoT](https://spectrum.ieee.org/topological-acoustics)<!-- HN:41550404:end -->
#### **Saturday, September 21, 2024**
<!-- HN:41552849:start -->
* [41552849](https://news.social-protocols.org/stats?id=41552849) #8 17 points 4 comments -> [A picture of Earth through time](https://blog.google/products/earth/a-picture-of-earth-through-time/)<!-- HN:41552849:end --><!-- HN:41607569:start -->
* [41607569](https://news.social-protocols.org/stats?id=41607569) #19 41 points 27 comments -> [Ruby on Rails continues to thrive](https://blogyet.com/blog_posts/why-ruby-on-rails-will-never-die-a-veteran-coder-s-perspective)<!-- HN:41607569:end --><!-- HN:41606530:start -->
* [41606530](https://news.social-protocols.org/stats?id=41606530) #22 187 points 115 comments -> [Apple Shares Full iPhone 16 and iPhone 16 Pro Repair Manuals](https://www.macrumors.com/2024/09/20/iphone-16-repair-manual/)<!-- HN:41606530:end --><!-- HN:41607166:start -->
* [41607166](https://news.social-protocols.org/stats?id=41607166) #28 103 points 60 comments -> [Inside Annapurna Interactive's Mass Walkout](https://www.ign.com/articles/what-the-heck-has-been-going-on-at-annapurna-interactive-an-investigation)<!-- HN:41607166:end --><!-- HN:41609758:start -->
* [41609758](https://news.social-protocols.org/stats?id=41609758) #17 5 points 1 comments -> [Glacier National Park replacing signs that predicted glaciers would gone by 2020](https://www.cnn.com/2020/01/08/us/glaciers-national-park-2020-trnd/index.html)<!-- HN:41609758:end --><!-- HN:41569284:start -->
* [41569284](https://news.social-protocols.org/stats?id=41569284) #30 13 points 5 comments -> [Gibbons move with rhythm and intention. Dare we say style?](https://www.nytimes.com/2024/09/14/science/gibbons-dancing-apes.html)<!-- HN:41569284:end --><!-- HN:41612584:start -->
* [41612584](https://news.social-protocols.org/stats?id=41612584) #13 5 points 1 comments -> [The Pain of Travelling While Palestinian](https://www.newyorker.com/culture/the-weekend-essay/the-pain-of-travelling-while-palestinian)<!-- HN:41612584:end --><!-- HN:41613025:start -->
* [41613025](https://news.social-protocols.org/stats?id=41613025) #30 16 points 10 comments -> [Why I'm Leaving Meta](https://medium.com/@peravi8126/why-im-leaving-meta-c3ab43491204)<!-- HN:41613025:end -->
#### **Sunday, September 22, 2024**
<!-- HN:41567862:start -->
* [41567862](https://news.social-protocols.org/stats?id=41567862) #14 24 points 3 comments -> [A Simple Spaced Repetition Algo (In Ugly SQL)](https://taylor.town/flashcasts-srs-algo)<!-- HN:41567862:end --><!-- HN:41616612:start -->
* [41616612](https://news.social-protocols.org/stats?id=41616612) #2 16 points 12 comments -> [Hacker Leaks 3.3B Emails and Yes Every Single One Is Unique](https://hackerdose.com/privacy/massive-3-3-billion-emails-leaked/)<!-- HN:41616612:end --><!-- HN:41616706:start -->
* [41616706](https://news.social-protocols.org/stats?id=41616706) #7 9 points 1 comments -> [Fukuppy](https://en.wikipedia.org/wiki/Fukuppy)<!-- HN:41616706:end --><!-- HN:41609694:start -->
* [41609694](https://news.social-protocols.org/stats?id=41609694) #20 102 points 31 comments -> [Social Initiation](https://socialcommunication.truman.edu/attitudes-emotions/social-initiation/)<!-- HN:41609694:end --><!-- HN:41616799:start -->
* [41616799](https://news.social-protocols.org/stats?id=41616799) #22 4 points 1 comments -> [A 23-person Lego team built a 1:1 scale working McLaren P1 using 342,817 pieces](https://www.lego.com/en-us/aboutus/news/2024/september/lego-technic-ultimate-challenge)<!-- HN:41616799:end --><!-- HN:41616540:start -->
* [41616540](https://news.social-protocols.org/stats?id=41616540) #26 42 points 23 comments -> [Bruce Schneier: Israel's Pager Attacks Have Changed the World](https://www.nytimes.com/2024/09/22/opinion/israel-pager-attacks-supply-chain.html)<!-- HN:41616540:end --><!-- HN:41615563:start -->
* [41615563](https://news.social-protocols.org/stats?id=41615563) #21 8 points 3 comments -> [Open Source Icon Sets](https://icon-sets.iconify.design/)<!-- HN:41615563:end -->
#### **Monday, September 23, 2024**
<!-- HN:41621672:start -->
* [41621672](https://news.social-protocols.org/stats?id=41621672) #12 24 points 9 comments -> [Man dies after being knocked down by woman on scooter](https://abc7.com/post/man-dies-after-being-knocked-down-woman-scooter-koreatown-police-investigating-hit-run/15337382/)<!-- HN:41621672:end --><!-- HN:41621631:start -->
* [41621631](https://news.social-protocols.org/stats?id=41621631) #24 54 points 27 comments -> [California fails to track its homelessness spending or results, a new audit says](https://calmatters.org/housing/homelessness/2024/04/california-homelessness-spending/)<!-- HN:41621631:end --><!-- HN:41575856:start -->
* [41575856](https://news.social-protocols.org/stats?id=41575856) #16 94 points 57 comments -> [Trove of dinosaur fossils found high in B.C. mountains](https://www.cbc.ca/news/canada/british-columbia/b-c-researchers-fossil-trove-1.7325926)<!-- HN:41575856:end --><!-- HN:41576870:start -->
* [41576870](https://news.social-protocols.org/stats?id=41576870) #18 46 points 6 comments -> [The Norwegian model of training to run](http://www.mariusbakken.com/the-norwegian-model.html)<!-- HN:41576870:end --><!-- HN:41572437:start -->
* [41572437](https://news.social-protocols.org/stats?id=41572437) #29 174 points 49 comments -> [Scientific Visualization: Python + Matplotlib (2021)](https://github.com/rougier/scientific-visualization-book)<!-- HN:41572437:end --><!-- HN:41621477:start -->
* [41621477](https://news.social-protocols.org/stats?id=41621477) #8 6 points 0 comments -> [Show HN: I built a tool to roast landing pages using AI agents](https://roastmylandingpage.io/)<!-- HN:41621477:end --><!-- HN:41620661:start -->
* [41620661](https://news.social-protocols.org/stats?id=41620661) #30 50 points 9 comments -> [Linear Mobile – Available for iOS and Android](https://linear.app/mobile)<!-- HN:41620661:end --><!-- HN:41620923:start -->
* [41620923](https://news.social-protocols.org/stats?id=41620923) #20 44 points 19 comments -> [Super Useful Chrome Plugins for Front-End Developers](https://jsdevspace.substack.com/p/13-super-useful-chrome-plugins-for)<!-- HN:41620923:end --><!-- HN:41625358:start -->
* [41625358](https://news.social-protocols.org/stats?id=41625358) #2 5 points 0 comments -> [America is becoming less "woke"](https://www.economist.com/briefing/2024/09/19/america-is-becoming-less-woke)<!-- HN:41625358:end --><!-- HN:41624741:start -->
* [41624741](https://news.social-protocols.org/stats?id=41624741) #30 28 points 40 comments -> [Guiding principles: How US dietary guidelines contribute to obesity](https://thehill.com/opinion/4891813-robert-kennedy-jr-chronic-disease/)<!-- HN:41624741:end --><!-- HN:41621020:start -->
* [41621020](https://news.social-protocols.org/stats?id=41621020) #18 300 points 242 comments -> [London saw a surprising benefit to ultra-low emissions zone: More active kids](https://grist.org/cities/london-fining-polluting-cars-more-active-kids/)<!-- HN:41621020:end --><!-- HN:41580619:start -->
* [41580619](https://news.social-protocols.org/stats?id=41580619) #21 156 points 61 comments -> [Things I've learned serving on the board of the Python Software Foundation](https://simonwillison.net/2024/Sep/18/board-of-the-python-software-foundation/)<!-- HN:41580619:end --><!-- HN:41618926:start -->
* [41618926](https://news.social-protocols.org/stats?id=41618926) #27 230 points 108 comments -> [Sublime text started adding a “.s” to new files](https://forum.sublimetext.com/t/sublime-text-started-adding-a-s-to-new-files-very-annoying/73628)<!-- HN:41618926:end --><!-- HN:41618117:start -->
* [41618117](https://news.social-protocols.org/stats?id=41618117) #26 31 points 2 comments -> [Backup Strategies for SQLite in Production](https://oldmoe.blog/2024/04/30/backup-strategies-for-sqlite-in-production/)<!-- HN:41618117:end --><!-- HN:41578637:start -->
* [41578637](https://news.social-protocols.org/stats?id=41578637) #27 113 points 108 comments -> [Bricked iPhone 16 Can Be Restored Wirelessly Using Another iPhone](https://www.macrumors.com/2024/09/18/iphone-16-restored-wirelessly-another-iphone/)<!-- HN:41578637:end --><!-- HN:41588038:start -->
* [41588038](https://news.social-protocols.org/stats?id=41588038) #21 74 points 62 comments -> [It's Okay to Abandon Things](https://netninja.com/2024/02/05/its-okay-to-abandon-things/)<!-- HN:41588038:end --><!-- HN:41620086:start -->
* [41620086](https://news.social-protocols.org/stats?id=41620086) #27 22 points 8 comments -> [Mozilla's privacy preserving ad attribution: The future or an oxymoron?](https://www.ethicalads.io/blog/2024/08/mozillas-privacy-preserving-ad-attribution-the-future-or-an-oxymoron/)<!-- HN:41620086:end --><!-- HN:41620414:start -->
* [41620414](https://news.social-protocols.org/stats?id=41620414) #21 91 points 15 comments -> [Show HN: Put ful.co/ in front of any URL to easily copy its SVGs and images](https://ful.co/)<!-- HN:41620414:end --><!-- HN:41624675:start -->
* [41624675](https://news.social-protocols.org/stats?id=41624675) #27 23 points 3 comments -> [FTC Sues Prescription Drug Middlemen for Artificially Inflating Insulin Prices](https://www.ftc.gov/news-events/news/press-releases/2024/09/ftc-sues-prescription-drug-middlemen-artificially-inflating-insulin-drug-prices)<!-- HN:41624675:end --><!-- HN:41625258:start -->
* [41625258](https://news.social-protocols.org/stats?id=41625258) #23 16 points 1 comments -> [The Problems That Google Docs Never Solved](https://amistrongeryet.substack.com/p/the-problem-with-google-docs)<!-- HN:41625258:end --><!-- HN:41625488:start -->
* [41625488](https://news.social-protocols.org/stats?id=41625488) #25 4 points 2 comments -> [An AI can beat CAPTCHA tests 100 per cent of the time](https://www.newscientist.com/article/2448687-an-ai-can-beat-captcha-tests-100-per-cent-of-the-time/)<!-- HN:41625488:end --><!-- HN:41619516:start -->
* [41619516](https://news.social-protocols.org/stats?id=41619516) #29 20 points 10 comments -> [FOSDEM 2025](https://fosdem.org/2025/)<!-- HN:41619516:end --><!-- HN:41627806:start -->
* [41627806](https://news.social-protocols.org/stats?id=41627806) #20 4 points 0 comments -> [Today's satellite view of fires in southern Lebanon](https://firms.modaps.eosdis.nasa.gov/map/#d:today;@35.37,33.17,10.66z)<!-- HN:41627806:end --><!-- HN:41628225:start -->
* [41628225](https://news.social-protocols.org/stats?id=41628225) #25 47 points 41 comments -> [Honey, YouTubers Are Poisoning the Kids](https://www.trend-mill.com/p/honey-youtubers-are-poisoning-the)<!-- HN:41628225:end --><!-- HN:41630461:start -->
* [41630461](https://news.social-protocols.org/stats?id=41630461) #9 7 points 3 comments -> [Storing RSA Private Keys in DNS TXT Records?](https://reconwave.com/blog/post/storing-private-keys-in-txt-dns)<!-- HN:41630461:end --><!-- HN:41630348:start -->
* [41630348](https://news.social-protocols.org/stats?id=41630348) #16 7 points 0 comments -> [Positive effects of creatine supplementation on memory in healthy individuals](https://www.ncbi.nlm.nih.gov/pmc/articles/PMC9999677/)<!-- HN:41630348:end --><!-- HN:41630976:start -->
* [41630976](https://news.social-protocols.org/stats?id=41630976) #9 6 points 2 comments -> [Show HN: Who Should Be the President?](https://ileantoward.com/)<!-- HN:41630976:end --><!-- HN:41629811:start -->
* [41629811](https://news.social-protocols.org/stats?id=41629811) #29 95 points 262 comments -> [Anime is eating the world](https://a16z.com/anime-is-eating-the-world/)<!-- HN:41629811:end --><!-- HN:41631464:start -->
* [41631464](https://news.social-protocols.org/stats?id=41631464) #22 6 points 0 comments -> [Israeli military shuts down Al Jazeera bureau in West Bank raid](https://www.theguardian.com/world/2024/sep/22/al-jazeera-office-west-bank-raid-israeli-forces-media)<!-- HN:41631464:end -->
#### **Tuesday, September 24, 2024**
<!-- HN:41631995:start -->
* [41631995](https://news.social-protocols.org/stats?id=41631995) #18 6 points 2 comments -> ["Traffic Violence": The Grifters Go After Cars](https://albertcory50.substack.com/p/traffic-violence-the-grifters-go)<!-- HN:41631995:end --><!-- HN:41632606:start -->
* [41632606](https://news.social-protocols.org/stats?id=41632606) #6 5 points 2 comments -> [Bootstrapped to 10K Users: Is B2B the Only Way to Monetize?](https://www.jobsolv.com/)<!-- HN:41632606:end -->