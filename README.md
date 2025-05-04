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

#### **Monday, April 28, 2025**
<!-- HN:43816291:start -->
* [43816291](https://news.social-protocols.org/stats?id=43816291) #13 8 points 2 comments -> [Is open-world design making games worse?](https://dadrian.io/blog/posts/open-world-games-trends/)<!-- HN:43816291:end --><!-- HN:43816186:start -->
* [43816186](https://news.social-protocols.org/stats?id=43816186) #6 7 points 1 comments -> [Many cultures borrow. Japan transforms](https://www.nytimes.com/2025/04/22/t-magazine/foreign-imports-japan.html)<!-- HN:43816186:end --><!-- HN:43818266:start -->
* [43818266](https://news.social-protocols.org/stats?id=43818266) #7 3 points 1 comments -> [What we get when male fitness standards clash with female preferences](https://nataliaantonova.substack.com/p/this-internet-poll-is-breaking-mens)<!-- HN:43818266:end --><!-- HN:43818965:start -->
* [43818965](https://news.social-protocols.org/stats?id=43818965) #12 16 points 8 comments -> [The Zuckerbergs Founded Two Bay Area Schools. Now They're Closing](https://www.nytimes.com/2025/04/24/us/school-closure-zuckerberg-chan.html)<!-- HN:43818965:end --><!-- HN:43820163:start -->
* [43820163](https://news.social-protocols.org/stats?id=43820163) #6 17 points 5 comments -> [There are reports of widespread power cuts in Spain and Portugal](https://www.bbc.co.uk/news/live/c9wpq8xrvd9t)<!-- HN:43820163:end --><!-- HN:43820177:start -->
* [43820177](https://news.social-protocols.org/stats?id=43820177) #14 10 points 1 comments -> [Spain, Portugal and parts of France hit by power outage](https://www.euronews.com/my-europe/2025/04/28/spain-portugal-and-parts-of-france-hit-by-massive-power-outage)<!-- HN:43820177:end --><!-- HN:43819914:start -->
* [43819914](https://news.social-protocols.org/stats?id=43819914) #25 53 points 2 comments -> [Nationwide Power Outages Also Disrupt Internet Traffic in Portugal and Spain](https://twitter.com/CloudflareRadar/status/1916811587408536055)<!-- HN:43819914:end --><!-- HN:43820043:start -->
* [43820043](https://news.social-protocols.org/stats?id=43820043) #7 316 points 245 comments -> [Reports of widespread power cuts in Spain and Portugal](https://www.bbc.com/news/live/c9wpq8xrvd9t)<!-- HN:43820043:end --><!-- HN:43821039:start -->
* [43821039](https://news.social-protocols.org/stats?id=43821039) #6 4 points 1 comments -> [Spain and Portugal suffering nationwide power outage](https://www.theguardian.com/world/live/2025/apr/28/ukraine-russia-zelenskyy-putin-trump-crimea-germany-europe-news-live-updates)<!-- HN:43821039:end --><!-- HN:43820144:start -->
* [43820144](https://news.social-protocols.org/stats?id=43820144) #28 24 points 6 comments -> [Making a game from scratch using only a guitar [video]](https://www.youtube.com/watch?v=wesICmc48UE)<!-- HN:43820144:end --><!-- HN:43822292:start -->
* [43822292](https://news.social-protocols.org/stats?id=43822292) #7 16 points 0 comments -> [Anthropic Economic Index: AI's Impact on Software Development](https://www.anthropic.com/research/impact-software-development)<!-- HN:43822292:end --><!-- HN:43822868:start -->
* [43822868](https://news.social-protocols.org/stats?id=43822868) #14 29 points 8 comments -> [AI Goes to College for the Free Money](https://marginalrevolution.com/marginalrevolution/2025/04/ai-goes-to-college-for-the-free-money.html)<!-- HN:43822868:end --><!-- HN:43823622:start -->
* [43823622](https://news.social-protocols.org/stats?id=43823622) #5 -> [DeepSeek-R2](https://deepseek.ai/blog/deepseek-r2-ai-model-launch-2025)<!-- HN:43823622:end --><!-- HN:43824648:start -->
* [43824648](https://news.social-protocols.org/stats?id=43824648) #23 3 points 0 comments -> [Doge employees gain accounts on classified networks holding nuclear secrets](https://www.npr.org/2025/04/28/nx-s1-5378684/doge-energy-department-nuclear-secrets-access)<!-- HN:43824648:end --><!-- HN:43825285:start -->
* [43825285](https://news.social-protocols.org/stats?id=43825285) #6 8 points 0 comments -> [Five Things the Nuclear Bros Don't Want You to Know About Small Modular Reactors](https://blog.ucs.org/edwin-lyman/five-things-the-nuclear-bros-dont-want-you-to-know-about-small-modular-reactors/)<!-- HN:43825285:end --><!-- HN:43825874:start -->
* [43825874](https://news.social-protocols.org/stats?id=43825874) #21 3 points 0 comments -> [They Stole a Quarter-Billion in Crypto and Got Caught Within a Month](https://www.nytimes.com/2025/04/24/magazine/crybercrime-crypto-minecraft.html)<!-- HN:43825874:end --><!-- HN:43826312:start -->
* [43826312](https://news.social-protocols.org/stats?id=43826312) #30 5 points 0 comments -> [Multiple GPL violations proved on Limited Run Games remasters](https://github.com/notaz/pcsx_rearmed/issues/352)<!-- HN:43826312:end --><!-- HN:43826425:start -->
* [43826425](https://news.social-protocols.org/stats?id=43826425) #13 24 points 3 comments -> [On Lisp](https://www.paulgraham.com/onlisptext.html)<!-- HN:43826425:end -->
#### **Tuesday, April 29, 2025**
<!-- HN:43825798:start -->
* [43825798](https://news.social-protocols.org/stats?id=43825798) #29 25 points 14 comments -> [Beyond Elk: Lightweight and Scalable Cloud-Native Log Monitoring](https://greptime.com/blogs/2025-04-24-elasticsearch-greptimedb-comparison-performance)<!-- HN:43825798:end --><!-- HN:43830946:start -->
* [43830946](https://news.social-protocols.org/stats?id=43830946) #10 29 points 41 comments -> [Spain and Portugal power outage: what caused it, and was there a cyber-attack?](https://www.theguardian.com/business/2025/apr/28/spain-and-portugal-power-outage-cause-cyber-attack-electricity)<!-- HN:43830946:end --><!-- HN:43830198:start -->
* [43830198](https://news.social-protocols.org/stats?id=43830198) #28 36 points 24 comments -> [Vibe Coding: Developer Slot Machines (Cursor, Windsurf)](https://prototypr.io/note/vibe-coding-cursor-windsurf-slot-machine)<!-- HN:43830198:end --><!-- HN:43832554:start -->
* [43832554](https://news.social-protocols.org/stats?id=43832554) #5 4 points 0 comments -> [My new Alpine-Linux kiosk miniPC (€189) boots in ~3 seconds](https://giuliomagnifico.blog/post/2025-24-04-minipc-kiosk/)<!-- HN:43832554:end --><!-- HN:43832051:start -->
* [43832051](https://news.social-protocols.org/stats?id=43832051) #26 12 points 0 comments -> [White House Press Secretary Refuses to Rule Out Arrest of Supreme Court Judges](https://newrepublic.com/post/194481/karoline-leavitt-arrest-supreme-court-judges)<!-- HN:43832051:end --><!-- HN:43837810:start -->
* [43837810](https://news.social-protocols.org/stats?id=43837810) #11 19 points 6 comments -> [Amazon has no choice but to display tariffs on prices now](https://www.theverge.com/amazon/657959/amazon-has-no-choice-but-to-display-tariffs-on-prices-now)<!-- HN:43837810:end -->
#### **Wednesday, April 30, 2025**
<!-- HN:43840062:start -->
* [43840062](https://news.social-protocols.org/stats?id=43840062) #15 14 points 3 comments -> [All the Women I Met in Jail](https://www.harpersbazaar.com/culture/features/a64577728/domestic-violence-law/)<!-- HN:43840062:end --><!-- HN:43842915:start -->
* [43842915](https://news.social-protocols.org/stats?id=43842915) #3 10 points 0 comments -> [Awesome List on AI for Security](https://github.com/AmanPriyanshu/Awesome-AI-For-Security)<!-- HN:43842915:end --><!-- HN:43842821:start -->
* [43842821](https://news.social-protocols.org/stats?id=43842821) #4 29 points 18 comments -> [AI TIMLINE – All prominent events in the field](https://nhlocal.github.io/AiTimeline/)<!-- HN:43842821:end --><!-- HN:43845022:start -->
* [43845022](https://news.social-protocols.org/stats?id=43845022) #26 25 points 16 comments -> [RFK Jr is wrong – there's a rich history of autistic poets](https://theconversation.com/rfk-jr-said-many-autistic-people-will-never-write-a-poem-even-though-theres-a-rich-history-of-neurodivergent-poets-and-writers-255367)<!-- HN:43845022:end --><!-- HN:43847368:start -->
* [43847368](https://news.social-protocols.org/stats?id=43847368) #20 33 points 41 comments -> [Young people aren't as happy as they used to be [Global Flourishing Study]](https://www.nytimes.com/2025/04/30/well/mind/happiness-flourishing-young-adult-study.html)<!-- HN:43847368:end --><!-- HN:43848462:start -->
* [43848462](https://news.social-protocols.org/stats?id=43848462) #14 -> [Columbia student Mohsen Mahdawi is released from detention](https://www.npr.org/2025/04/30/nx-s1-5382306/mohsen-madawi-released-ice-columbia-university-activist-judge)<!-- HN:43848462:end --><!-- HN:43847305:start -->
* [43847305](https://news.social-protocols.org/stats?id=43847305) #20 11 points 10 comments -> [Show HN: 1.2 users a day to keep the 9–5 away](https://www.postonreddit.com)<!-- HN:43847305:end --><!-- HN:43851627:start -->
* [43851627](https://news.social-protocols.org/stats?id=43851627) #18 20 points 1 comments -> [Tim Sweeney: "NO FEES on web transactions. Game over for the Apple Tax"](https://twitter.com/TimSweeneyEpic/status/1917706848251134055)<!-- HN:43851627:end --><!-- HN:43851502:start -->
* [43851502](https://news.social-protocols.org/stats?id=43851502) #20 24 points 2 comments -> [How to Not Get Poisoned in America](https://buttondown.com/theswordandthesandwich/archive/how-to-not-get-poisoned-in-america/)<!-- HN:43851502:end --><!-- HN:43851843:start -->
* [43851843](https://news.social-protocols.org/stats?id=43851843) #22 7 points 0 comments -> [RFK Jr. Rejects Germ Theory](https://arstechnica.com/health/2025/04/rfk-jr-s-anti-vaccine-stance-is-rooted-in-a-disbelief-in-germ-theory/)<!-- HN:43851843:end -->
#### **Thursday, May 1, 2025**
<!-- HN:43852500:start -->
* [43852500](https://news.social-protocols.org/stats?id=43852500) #30 6 points 2 comments -> [Republicans in Congress Want a Flat $200 Annual EV Tax](https://arstechnica.com/cars/2025/04/republicans-want-to-tax-ev-drivers-200-year-in-new-transport-bill/)<!-- HN:43852500:end --><!-- HN:43854283:start -->
* [43854283](https://news.social-protocols.org/stats?id=43854283) #20 4 points 0 comments -> [Phi Silica: Microsoft hardware plan for local AI](https://blogs.windows.com/windowsexperience/2024/12/06/phi-silica-small-but-mighty-on-device-slm/)<!-- HN:43854283:end --><!-- HN:43854498:start -->
* [43854498](https://news.social-protocols.org/stats?id=43854498) #6 23 points 40 comments -> [Dropbox will require App Indicator support on Linux](https://help.dropbox.com/installs/dropbox-desktop-app-for-linux)<!-- HN:43854498:end --><!-- HN:43860431:start -->
* [43860431](https://news.social-protocols.org/stats?id=43860431) #26 19 points 1 comments -> [Git Changesets](https://github.com/changesets/changesets)<!-- HN:43860431:end --><!-- HN:43862745:start -->
* [43862745](https://news.social-protocols.org/stats?id=43862745) #4 14 points 1 comments -> [Trump's stablecoin chosen for $2B Abu Dhabi investment in Binance](https://www.kitco.com/news/off-the-wire/2025-05-01/trumps-stablecoin-chosen-2-billion-abu-dhabi-investment-binance-co)<!-- HN:43862745:end -->
#### **Friday, May 2, 2025**<!-- HN:43865372:start -->
* [43865372](https://news.social-protocols.org/stats?id=43865372) #19 3 points 2 comments -> [Show HN: CapOS – A responsibility-gated OS stack with signed process execution](https://zenodo.org/communities/xtothepowerofinfinity/records)<!-- HN:43865372:end --><!-- HN:43868232:start -->
* [43868232](https://news.social-protocols.org/stats?id=43868232) #3 -> [GPT-FoxNewsDad: A GPT designed to help tech/academia people with life struggles](https://chatgpt.com/g/g-6814740bd1cc81919d28a7c4b8db055d-gpt-foxnewsdad)<!-- HN:43868232:end --><!-- HN:43867613:start -->
* [43867613](https://news.social-protocols.org/stats?id=43867613) #18 5 points 0 comments -> [Bundle Python with the z/OS base system](https://ibm-z-hardware-and-operating-systems.ideas.ibm.com/ideas/ZOS-I-3993)<!-- HN:43867613:end --><!-- HN:43870781:start -->
* [43870781](https://news.social-protocols.org/stats?id=43870781) #16 11 points 5 comments -> [The Female Gaze](https://www.maryharrington.co.uk/p/the-female-gaze)<!-- HN:43870781:end --><!-- HN:43870090:start -->
* [43870090](https://news.social-protocols.org/stats?id=43870090) #27 13 points 9 comments -> [Grand Theft Auto VI gets pushed back to May 26, 2026](https://arstechnica.com/gaming/2025/05/gta-vi-will-miss-2025-after-all-new-target-is-may-26-2026/)<!-- HN:43870090:end --><!-- HN:43870083:start -->
* [43870083](https://news.social-protocols.org/stats?id=43870083) #29 10 points 2 comments -> [Opinion: Is a split imminent? – Synadia demands NATS back from the CNCF](https://www.heise.de/en/opinion/Opinion-Is-a-split-imminent-Synadia-demands-NATS-back-from-the-CNCF-10366963.html)<!-- HN:43870083:end --><!-- HN:43869203:start -->
* [43869203](https://news.social-protocols.org/stats?id=43869203) #30 6 points 1 comments -> [The Chromium Security Paradox](https://www.island.io/blog/the-chromium-security-paradox)<!-- HN:43869203:end -->
#### **Saturday, May 3, 2025**
<!-- HN:43875403:start -->
* [43875403](https://news.social-protocols.org/stats?id=43875403) #6 5 points 3 comments -> [Demo Driven Development: Show, Don't Just Tell](https://shubhanshu.com/blog/demo-driven-development.html#demo-driven-development)<!-- HN:43875403:end --><!-- HN:43875319:start -->
* [43875319](https://news.social-protocols.org/stats?id=43875319) #25 8 points 1 comments -> [Exchange Fund Investor Defers $388K Taxes, Comes Out $278K Ahead Amid Volatility](https://usecache.com/companion/erics-journey-how-cache-helped-protect-wealth-as-the-market-turned)<!-- HN:43875319:end --><!-- HN:43876414:start -->
* [43876414](https://news.social-protocols.org/stats?id=43876414) #8 9 points 1 comments -> [Creating Bluey: Tales from the Art Director](https://substack.com/home/post/p-160238071)<!-- HN:43876414:end --><!-- HN:43872990:start -->
* [43872990](https://news.social-protocols.org/stats?id=43872990) #12 153 points 289 comments -> [The first driverless semis have started running regular longhaul routes](https://www.cnn.com/2025/05/01/business/first-driverless-semis-started-regular-routes)<!-- HN:43872990:end --><!-- HN:43877338:start -->
* [43877338](https://news.social-protocols.org/stats?id=43877338) #13 33 points 52 comments -> [The number of new apartments is at a 50-year high, but states expect a slowdown](https://oregoncapitalchronicle.com/2025/05/02/the-number-of-new-apartments-is-at-a-50-year-high-but-states-expect-a-slowdown/)<!-- HN:43877338:end --><!-- HN:43880461:start -->
* [43880461](https://news.social-protocols.org/stats?id=43880461) #24 3 points 0 comments -> [Six Deadly Minutes: How Israeli soldiers killed 15 rescue workers in Gaza](https://www.nytimes.com/video/world/middleeast/100000010140613/israel-gaza-medics-attack-idf.html)<!-- HN:43880461:end -->
#### **Sunday, May 4, 2025**
<!-- HN:43883321:start -->
* [43883321](https://news.social-protocols.org/stats?id=43883321) #28 8 points 0 comments -> [NEA Cancels Grants After Proposed Elimination of Agency](https://www.artnews.com/art-news/news/national-endowment-for-the-arts-cancels-grants-trump-1234740558/)<!-- HN:43883321:end --><!-- HN:43885659:start -->
* [43885659](https://news.social-protocols.org/stats?id=43885659) #10 6 points 1 comments -> [Show HN: Voxdazz – Text-to-speech with lip-sync video generation](https://voxdazz.com)<!-- HN:43885659:end --><!-- HN:43885794:start -->
* [43885794](https://news.social-protocols.org/stats?id=43885794) #14 11 points 5 comments -> [Switch to a tiling-window-manager TODAY](https://github.com/uint23/sxwm)<!-- HN:43885794:end --><!-- HN:43886706:start -->
* [43886706](https://news.social-protocols.org/stats?id=43886706) #21 5 points 0 comments -> [El Paso Is Having Its Dustiest Year Since the Actual Dust Bowl](https://gizmodo.com/el-paso-is-having-its-dustiest-year-since-the-actual-dust-bowl-2000596987)<!-- HN:43886706:end --><!-- HN:43887446:start -->
* [43887446](https://news.social-protocols.org/stats?id=43887446) #25 12 points 1 comments -> [Zuckerberg Sailed 5,300 Miles with Two Superyachts to Helicopter Up a Mountain](https://www.sustainability-times.com/sustainable-business/mark-zuckerberg-sailed-5300-miles-with-two-superyachts-only-to-helicopter-up-a-mountain-and-ski-down-in-billionaire-style/)<!-- HN:43887446:end --><!-- HN:43888246:start -->
* [43888246](https://news.social-protocols.org/stats?id=43888246) #21 4 points 0 comments -> [The World Of dBASE (1984) [video]](https://www.youtube.com/watch?v=bYU3CQomE5M)<!-- HN:43888246:end --><!-- HN:43888907:start -->
* [43888907](https://news.social-protocols.org/stats?id=43888907) #20 9 points 2 comments -> [NASA Proposal Would Shift Agency's Focus Away from Space Science](https://www.nytimes.com/2025/05/02/us/politics/trump-budget-nasa-cuts.html)<!-- HN:43888907:end --><!-- HN:43888871:start -->
* [43888871](https://news.social-protocols.org/stats?id=43888871) #15 14 points 6 comments -> [Why are there no thunderstorms in the UK?](https://www.onepotscience.com/why-are-there-no-thunderstorms-in-the-uk/)<!-- HN:43888871:end --><!-- HN:43889814:start -->
* [43889814](https://news.social-protocols.org/stats?id=43889814) #24 15 points 1 comments -> [Tech hiring slows, unemployment rises, jobs report shows](https://www.computerworld.com/article/3976643/tech-hiring-slows-unemployment-rises-jobs-report-shows.html)<!-- HN:43889814:end --><!-- HN:43889311:start -->
* [43889311](https://news.social-protocols.org/stats?id=43889311) #24 17 points 7 comments -> [The New Control Society](https://www.thenewatlantis.com/publications/the-new-control-society)<!-- HN:43889311:end --><!-- HN:43890139:start -->
* [43890139](https://news.social-protocols.org/stats?id=43890139) #6 3 points 1 comments -> [An Enterprise-Level Retrieval-Augmented Generation System](https://comfyai.app/article/llm-applications/enterprise-level-rag-hands-on-practice-II)<!-- HN:43890139:end -->