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

#### **Sunday, May 4, 2025**
<!-- HN:43883321:start -->
* [43883321](https://news.social-protocols.org/stats?id=43883321) #28 8 points 0 comments -> [NEA Cancels Grants After Proposed Elimination of Agency](https://www.artnews.com/art-news/news/national-endowment-for-the-arts-cancels-grants-trump-1234740558/)<!-- HN:43883321:end --><!-- HN:43885659:start -->
* [43885659](https://news.social-protocols.org/stats?id=43885659) #10 6 points 1 comments -> [Show HN: Voxdazz – Text-to-speech with lip-sync video generation](https://voxdazz.com)<!-- HN:43885659:end --><!-- HN:43885794:start -->
* [43885794](https://news.social-protocols.org/stats?id=43885794) #14 11 points 5 comments -> [Switch to a tiling-window-manager TODAY](https://github.com/uint23/sxwm)<!-- HN:43885794:end --><!-- HN:43886706:start -->
* [43886706](https://news.social-protocols.org/stats?id=43886706) #21 5 points 0 comments -> [El Paso Is Having Its Dustiest Year Since the Actual Dust Bowl](https://gizmodo.com/el-paso-is-having-its-dustiest-year-since-the-actual-dust-bowl-2000596987)<!-- HN:43886706:end --><!-- HN:43887446:start -->
* [43887446](https://news.social-protocols.org/stats?id=43887446) #25 12 points 1 comments -> [Zuckerberg Sailed 5,300 Miles with Two Superyachts to Helicopter Up a Mountain](https://www.sustainability-times.com/sustainable-business/mark-zuckerberg-sailed-5300-miles-with-two-superyachts-only-to-helicopter-up-a-mountain-and-ski-down-in-billionaire-style/)<!-- HN:43887446:end --><!-- HN:43888907:start -->
* [43888907](https://news.social-protocols.org/stats?id=43888907) #20 9 points 2 comments -> [NASA Proposal Would Shift Agency's Focus Away from Space Science](https://www.nytimes.com/2025/05/02/us/politics/trump-budget-nasa-cuts.html)<!-- HN:43888907:end --><!-- HN:43888871:start -->
* [43888871](https://news.social-protocols.org/stats?id=43888871) #15 14 points 6 comments -> [Why are there no thunderstorms in the UK?](https://www.onepotscience.com/why-are-there-no-thunderstorms-in-the-uk/)<!-- HN:43888871:end --><!-- HN:43889814:start -->
* [43889814](https://news.social-protocols.org/stats?id=43889814) #24 15 points 1 comments -> [Tech hiring slows, unemployment rises, jobs report shows](https://www.computerworld.com/article/3976643/tech-hiring-slows-unemployment-rises-jobs-report-shows.html)<!-- HN:43889814:end --><!-- HN:43889311:start -->
* [43889311](https://news.social-protocols.org/stats?id=43889311) #24 17 points 7 comments -> [The New Control Society](https://www.thenewatlantis.com/publications/the-new-control-society)<!-- HN:43889311:end --><!-- HN:43890139:start -->
* [43890139](https://news.social-protocols.org/stats?id=43890139) #6 3 points 1 comments -> [An Enterprise-Level Retrieval-Augmented Generation System](https://comfyai.app/article/llm-applications/enterprise-level-rag-hands-on-practice-II)<!-- HN:43890139:end -->
#### **Monday, May 5, 2025**
<!-- HN:43890695:start -->
* [43890695](https://news.social-protocols.org/stats?id=43890695) #28 12 points 2 comments -> [The Signal Clone the Trump Admin Uses Was Hacked](https://micahflee.com/the-signal-clone-the-trump-admin-uses-was-hacked/)<!-- HN:43890695:end --><!-- HN:43865209:start -->
* [43865209](https://news.social-protocols.org/stats?id=43865209) #27 13 points 2 comments -> [Reconstructing dopamine's link to reward (2024)](https://www.thetransmitter.org/dopamine/reconstructing-dopamines-link-to-reward/)<!-- HN:43865209:end --><!-- HN:43890108:start -->
* [43890108](https://news.social-protocols.org/stats?id=43890108) #25 23 points 3 comments -> [Censoring Social Media](https://www.tbray.org/ongoing/When/202x/2025/04/28/Censoring-Social-Media)<!-- HN:43890108:end --><!-- HN:43894260:start -->
* [43894260](https://news.social-protocols.org/stats?id=43894260) #1 9 points 0 comments -> [Management Habits Burning Out Your Best Engineers](https://techleaderslaunchpad.com/resources/blog/9-management-habits-quietly-burning-out-your-best-engineers)<!-- HN:43894260:end --><!-- HN:43894889:start -->
* [43894889](https://news.social-protocols.org/stats?id=43894889) #25 5 points 0 comments -> [Trump's movie tariffs are designed to destroy the international film industry](https://www.theguardian.com/film/2025/may/05/trumps-movie-tariffs-are-designed-to-destroy-the-international-film-industry)<!-- HN:43894889:end --><!-- HN:43895786:start -->
* [43895786](https://news.social-protocols.org/stats?id=43895786) #19 4 points 0 comments -> [Conservatives may self-rate as having better 'mental health' because of stigma](https://medicalxpress.com/news/2025-04-mental-health-stigma-term.html)<!-- HN:43895786:end --><!-- HN:43899687:start -->
* [43899687](https://news.social-protocols.org/stats?id=43899687) #7 6 points 1 comments -> [You Meet More Perverts When You're Poor](https://peaked.substack.com/p/you-meet-more-perverts-when-youre)<!-- HN:43899687:end --><!-- HN:43900239:start -->
* [43900239](https://news.social-protocols.org/stats?id=43900239) #30 7 points 3 comments -> [A militarized conspiracy theorist group believes radars are 'weather weapons'](https://www.cnn.com/2025/05/05/weather/weather-weapons-nws-radar-attack)<!-- HN:43900239:end -->
#### **Tuesday, May 6, 2025**
<!-- HN:43899959:start -->
* [43899959](https://news.social-protocols.org/stats?id=43899959) #22 20 points 53 comments -> [Why it is (nearly) impossible that we live in a simulation](https://arxiv.org/abs/2504.08461)<!-- HN:43899959:end --><!-- HN:43900322:start -->
* [43900322](https://news.social-protocols.org/stats?id=43900322) #28 15 points 1 comments -> [How Indian Colleges Casually Violate Human Rights](https://isomorphism.xyz/blog/2025/indian-colleges/)<!-- HN:43900322:end --><!-- HN:43901708:start -->
* [43901708](https://news.social-protocols.org/stats?id=43901708) #20 15 points 0 comments -> [Wrapping Paper Turns All Your Presents into Bread](https://spoon-tamago.com/bread-wrapping-paper/)<!-- HN:43901708:end --><!-- HN:43901673:start -->
* [43901673](https://news.social-protocols.org/stats?id=43901673) #10 6 points 4 comments -> [22-inch foldable external display](https://uperfect.com/products/omega-flexible-display-22-inch)<!-- HN:43901673:end --><!-- HN:43902031:start -->
* [43902031](https://news.social-protocols.org/stats?id=43902031) #16 24 points 3 comments -> [Can you smuggle data in an ID card photo?](https://informatykzakladowy.pl/pierwszy-na-swiecie-dowod-osobisty-z-reklama-bloga/)<!-- HN:43902031:end --><!-- HN:43903206:start -->
* [43903206](https://news.social-protocols.org/stats?id=43903206) #13 -> [From the Transistor to the Web Browser, a rough outline for a 12 week course](https://github.com/andrewn6/fromthetransistor)<!-- HN:43903206:end --><!-- HN:43904407:start -->
* [43904407](https://news.social-protocols.org/stats?id=43904407) #6 4 points 2 comments -> [Hey, let's fire all the devs and replace them with AI](https://mdwdotla.medium.com/hey-lets-fire-all-the-devs-and-replace-them-with-ai-8a0c3011d12)<!-- HN:43904407:end --><!-- HN:43904356:start -->
* [43904356](https://news.social-protocols.org/stats?id=43904356) #5 28 points 20 comments -> [I so hate the phrase "vibe coding"](https://artiss.blog/2025/03/i-so-hate-the-phrase-vibe-coding/)<!-- HN:43904356:end --><!-- HN:43903414:start -->
* [43903414](https://news.social-protocols.org/stats?id=43903414) #27 21 points 7 comments -> [Show HN: AnuDB– Backed on RocksDB, 279x Faster Than SQLite in Parallel Workloads](https://github.com/hash-anu/AnuDB)<!-- HN:43903414:end --><!-- HN:43905635:start -->
* [43905635](https://news.social-protocols.org/stats?id=43905635) #17 10 points 1 comments -> [Website for US deportation airline GlobalX defaced by hackers](https://www.reuters.com/world/us/website-us-deportation-airline-globalx-defaced-by-hackers-2025-05-05/)<!-- HN:43905635:end --><!-- HN:43906716:start -->
* [43906716](https://news.social-protocols.org/stats?id=43906716) #14 6 points 0 comments -> [Infants and Babies can become pitch-perfect with early exposure to certain music](https://www.babymusic.ai/methodology)<!-- HN:43906716:end --><!-- HN:43904233:start -->
* [43904233](https://news.social-protocols.org/stats?id=43904233) #6 153 points 2 comments -> [OpenAI agrees to buy Windsurf for about $3B](https://www.reuters.com/business/openai-agrees-buy-windsurf-about-3-billion-bloomberg-news-reports-2025-05-06/)<!-- HN:43904233:end --><!-- HN:43907903:start -->
* [43907903](https://news.social-protocols.org/stats?id=43907903) #12 4 points 0 comments -> [PDF generation now available in beta in Grok Studio](https://twitter.com/grok/status/1919797270670967006)<!-- HN:43907903:end --><!-- HN:43883667:start -->
* [43883667](https://news.social-protocols.org/stats?id=43883667) #17 17 points 2 comments -> [The Tragic Story Behind the Infamous '4 Children for Sale' Photograph (2023)](https://allthatsinteresting.com/4-children-for-sale)<!-- HN:43883667:end -->
#### **Wednesday, May 7, 2025**
<!-- HN:43910874:start -->
* [43910874](https://news.social-protocols.org/stats?id=43910874) #30 9 points 2 comments -> [U.S. Orders Intelligence Agencies to Step Up Spying on Greenland](https://www.wsj.com/world/greenland-spying-us-intelligence-809c4ef2)<!-- HN:43910874:end --><!-- HN:43910794:start -->
* [43910794](https://news.social-protocols.org/stats?id=43910794) #2 173 points 35 comments -> [FTC bans hidden fees for live events and short-term rentals, effective May 12](https://techcrunch.com/2025/05/05/ftc-bans-hidden-fees-for-live-events-and-short-term-rentals-effective-may-12/)<!-- HN:43910794:end --><!-- HN:43913896:start -->
* [43913896](https://news.social-protocols.org/stats?id=43913896) #3 55 points 1 comments -> [Agentic Editing in Zed](https://zed.dev/blog/fastest-ai-code-editor?e=60)<!-- HN:43913896:end --><!-- HN:43914034:start -->
* [43914034](https://news.social-protocols.org/stats?id=43914034) #15 12 points 1 comments -> [Agentic Editing in Zed](https://zed.dev/agentic)<!-- HN:43914034:end --><!-- HN:43915070:start -->
* [43915070](https://news.social-protocols.org/stats?id=43915070) #7 19 points 1 comments -> [U.S. Jury Orders NSO Group to Pay $168M in WhatsApp Spyware Case](https://techoreon.com/us-jury-nso-group-pay-whatsapp-168-million-spyware/)<!-- HN:43915070:end --><!-- HN:43915365:start -->
* [43915365](https://news.social-protocols.org/stats?id=43915365) #20 7 points 0 comments -> [Real ID now required in US after nearly 20 years of delays](https://www.theguardian.com/us-news/2025/may/07/real-id-domestic-flights)<!-- HN:43915365:end --><!-- HN:43918596:start -->
* [43918596](https://news.social-protocols.org/stats?id=43918596) #7 49 points 22 comments -> [Social AI companions pose unacceptable risks to teens and children under 18](https://www.commonsensemedia.org/ai-ratings/social-ai-companions)<!-- HN:43918596:end --><!-- HN:43918600:start -->
* [43918600](https://news.social-protocols.org/stats?id=43918600) #4 129 points 23 comments -> [Three Chapters at Cloudflare: Programmer to CTO to Board of Directors](https://blog.cloudflare.com/en-us/three-chapters-at-cloudflare-programmer-to-cto-to-board-of-directors/)<!-- HN:43918600:end --><!-- HN:43920389:start -->
* [43920389](https://news.social-protocols.org/stats?id=43920389) #29 4 points 1 comments -> [After an Arizona man was shot, an AI video of him addresses his killer in court](https://www.npr.org/2025/05/07/g-s1-64640/ai-impact-statement-murder-victim)<!-- HN:43920389:end -->
#### **Thursday, May 8, 2025**
<!-- HN:43923331:start -->
* [43923331](https://news.social-protocols.org/stats?id=43923331) #25 19 points 10 comments -> [Why Intel Deprecated SGX?](https://hardenedvault.net/blog/2022-01-15-sgx-deprecated/)<!-- HN:43923331:end --><!-- HN:43925319:start -->
* [43925319](https://news.social-protocols.org/stats?id=43925319) #17 12 points 0 comments -> [What Money Can't Buy: The Moral Limits of Markets](https://sandel.scholars.harvard.edu/publications/what-money-cant-buy-moral-limits-markets)<!-- HN:43925319:end --><!-- HN:43924779:start -->
* [43924779](https://news.social-protocols.org/stats?id=43924779) #18 21 points 8 comments -> [Xenon is an open source universal game cheating framework C++](https://github.com/kiocode/xenon-cheats)<!-- HN:43924779:end --><!-- HN:43925911:start -->
* [43925911](https://news.social-protocols.org/stats?id=43925911) #5 30 points 11 comments -> [Globalization did not hollow out the American middle class](https://www.noahpinion.blog/p/globalization-did-not-hollow-out)<!-- HN:43925911:end --><!-- HN:43925427:start -->
* [43925427](https://news.social-protocols.org/stats?id=43925427) #21 12 points 1 comments -> [BYD Sealion 7 surpass Tesla Model Y to be Australia's best-selling electric car](https://www.drive.com.au/news/byd-sealion-7-surpasses-tesla-model-y-to-become-australias-new-best-selling-electric-car/)<!-- HN:43925427:end --><!-- HN:43927318:start -->
* [43927318](https://news.social-protocols.org/stats?id=43927318) #5 20 points 3 comments -> [Cybertruck owners won't get Autosteer feature](https://electrek.co/2025/05/07/tesla-bait-and-switch-cybertruck-owners-wont-get-autosteer-feature/)<!-- HN:43927318:end --><!-- HN:43928613:start -->
* [43928613](https://news.social-protocols.org/stats?id=43928613) #27 10 points 5 comments -> [Robert Francis Prevost Is Chosen as First Pope from U.S.](https://www.nytimes.com/live/2025/05/08/world/pope-conclave-news)<!-- HN:43928613:end --><!-- HN:43928742:start -->
* [43928742](https://news.social-protocols.org/stats?id=43928742) #2 206 points 3 comments -> [Chicago native Cardinal Prevost elected pope, takes name Leo XIV](https://catholicreview.org/chicago-native-cardinal-prevost-elected-pope-takes-name-leo-xiv/)<!-- HN:43928742:end --><!-- HN:43932202:start -->
* [43932202](https://news.social-protocols.org/stats?id=43932202) #4 6 points 0 comments -> [Radiation Tolerant Software Framework for Space Applications](https://github.com/r0nlt/Space-Radiation-Tolerant)<!-- HN:43932202:end -->
#### **Friday, May 9, 2025**
<!-- HN:43932278:start -->
* [43932278](https://news.social-protocols.org/stats?id=43932278) #18 11 points 6 comments -> [Gender characteristics of service robots can influence customer decisions](https://www.psu.edu/news/health-and-human-development/story/gender-characteristics-service-robots-can-influence-customer)<!-- HN:43932278:end --><!-- HN:43901081:start -->
* [43901081](https://news.social-protocols.org/stats?id=43901081) #12 23 points 9 comments -> [Show HN: OpenRouter Model Price Comparison](https://compare-openrouter-models.pages.dev/)<!-- HN:43901081:end --><!-- HN:43934781:start -->
* [43934781](https://news.social-protocols.org/stats?id=43934781) #30 7 points 1 comments -> [Realism Still Doesn't Justify Including Sexual Assault](https://mythcreants.com/blog/realism-still-doesnt-justify-including-sexual-assault/)<!-- HN:43934781:end --><!-- HN:43898956:start -->
* [43898956](https://news.social-protocols.org/stats?id=43898956) #19 8 points 0 comments -> [Fui: C library for interacting with the framebuffer in a tty context](https://github.com/martinfama/fui)<!-- HN:43898956:end --><!-- HN:43934279:start -->
* [43934279](https://news.social-protocols.org/stats?id=43934279) #10 45 points 26 comments -> [6502 Illegal Opcodes in the Siemens PC 100 Assembly Manual (1980)](https://www.pagetable.com/?p=1798)<!-- HN:43934279:end --><!-- HN:43935814:start -->
* [43935814](https://news.social-protocols.org/stats?id=43935814) #20 11 points 1 comments -> [Apple is planning smart glasses with and without AR](https://www.theverge.com/news/663600/apple-smart-glasses-chips-ar-chip)<!-- HN:43935814:end --><!-- HN:43936460:start -->
* [43936460](https://news.social-protocols.org/stats?id=43936460) #28 3 points 0 comments -> [Reincarnated by A.I., Arizona Man Forgives His Killer at Sentencing](https://www.nytimes.com/2025/05/08/us/ai-victim-impact-statement-manslaughter.html)<!-- HN:43936460:end --><!-- HN:43937396:start -->
* [43937396](https://news.social-protocols.org/stats?id=43937396) #19 7 points 1 comments -> ['Inheritance is an injustice': Why a 33-year-old redistributed €27M](https://www.lemonde.fr/en/economy/article/2025/05/08/inheritance-is-an-injustice-why-a-33-year-old-redistributed-27-million_6741060_19.html)<!-- HN:43937396:end --><!-- HN:43939834:start -->
* [43939834](https://news.social-protocols.org/stats?id=43939834) #26 6 points 0 comments -> [Bluetooth 6.1](https://www.bluetooth.com/blog/delivering-on-the-bi-annual-release-schedule-bluetooth-core-6-1-is-here/)<!-- HN:43939834:end --><!-- HN:43909774:start -->
* [43909774](https://news.social-protocols.org/stats?id=43909774) #16 13 points 0 comments -> [Some Thoughts on LCP eBook DRM](https://shkspr.mobi/blog/2025/03/some-thoughts-on-lcp-ebook-drm/)<!-- HN:43909774:end -->
#### **Saturday, May 10, 2025**
<!-- HN:43942928:start -->
* [43942928](https://news.social-protocols.org/stats?id=43942928) #8 -> [Uber Driver app can get location in background without the permissions (How?)](https://developer.apple.com/forums/thread/783227)<!-- HN:43942928:end --><!-- HN:43911197:start -->
* [43911197](https://news.social-protocols.org/stats?id=43911197) #21 8 points 0 comments -> [Running Windows.exe on a Linux Brain: The Sysadmin's Guide to Neurodivergence](https://leantime.io/running-windows-exe-on-a-linux-brain-the-sysadmins-guide-to-neurodivergence/)<!-- HN:43911197:end --><!-- HN:43943871:start -->
* [43943871](https://news.social-protocols.org/stats?id=43943871) #7 27 points 16 comments -> [Why should I care? or why punks are correct and old wise philosophers are wrong](https://abuseofnotation.github.io/moral-law/)<!-- HN:43943871:end --><!-- HN:43944809:start -->
* [43944809](https://news.social-protocols.org/stats?id=43944809) #3 39 points 39 comments -> [The Fallacy of Techno-Feudalism](https://petrapalusova.com/articles/tech-platforms-digital-economy-techno-feudalism)<!-- HN:43944809:end --><!-- HN:43945324:start -->
* [43945324](https://news.social-protocols.org/stats?id=43945324) #18 4 points 0 comments -> [The Dave and Busters Anomaly](https://www.searchengine.show/the-dave-and-busters-anomaly/)<!-- HN:43945324:end --><!-- HN:43947161:start -->
* [43947161](https://news.social-protocols.org/stats?id=43947161) #5 10 points 0 comments -> [Simon Willison's first blog on LLMs (2022)](https://simonwillison.net/2022/May/31/a-datasette-tutorial-written-by-gpt-3/)<!-- HN:43947161:end -->