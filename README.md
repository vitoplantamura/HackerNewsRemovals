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

#### **Wednesday, October 23, 2024**
<!-- HN:41919900:start -->
* [41919900](https://news.social-protocols.org/stats?id=41919900) #5 16 points 11 comments -> [California Businesses Stop Hiring](https://www.hoover.org/research/californias-businesses-stop-hiring)<!-- HN:41919900:end --><!-- HN:41920294:start -->
* [41920294](https://news.social-protocols.org/stats?id=41920294) #2 47 points 1 comments -> [Solving Sudoku with the Python package resolver](https://github.com/konstin/sudoku-in-python-packaging)<!-- HN:41920294:end --><!-- HN:41922480:start -->
* [41922480](https://news.social-protocols.org/stats?id=41922480) #2 7 points 2 comments -> [Show HN: Stable Diffusion 3.5 – Advanced AI Image Generator](https://stablediffusion35.org)<!-- HN:41922480:end --><!-- HN:41921723:start -->
* [41921723](https://news.social-protocols.org/stats?id=41921723) #28 42 points 40 comments -> [In a first, Wikipedia takes down article globally after Delhi HC order](https://www.thehindu.com/news/national/wikipedia-suspends-access-to-ani-defamation-case-page-following-delhi-hc-order/article68778075.ece)<!-- HN:41921723:end --><!-- HN:41922605:start -->
* [41922605](https://news.social-protocols.org/stats?id=41922605) #26 7 points 6 comments -> [New Claude AI can take over your computer](https://newatlas.com/ai-humanoids/anthropic-claude-computer-use-agent-ai/)<!-- HN:41922605:end --><!-- HN:41921703:start -->
* [41921703](https://news.social-protocols.org/stats?id=41921703) #18 91 points 54 comments -> [One Square Minesweeper](https://onesquareminesweeper.com/)<!-- HN:41921703:end --><!-- HN:41922737:start -->
* [41922737](https://news.social-protocols.org/stats?id=41922737) #23 7 points 1 comments -> [Show HN: ClickHouse User Defined Table Function in Python](https://github.com/auxten/SQL-On-Everything)<!-- HN:41922737:end --><!-- HN:41923901:start -->
* [41923901](https://news.social-protocols.org/stats?id=41923901) #17 17 points 38 comments -> [I Had $100k in Debt So I Moved into My Car](https://macleans.ca/society/i-had-100000-in-debt-so-i-moved-into-my-car/)<!-- HN:41923901:end --><!-- HN:41923897:start -->
* [41923897](https://news.social-protocols.org/stats?id=41923897) #28 8 points 3 comments -> ["WordPress.org is not WordPress" [pdf]](https://storage.courtlistener.com/recap/gov.uscourts.cand.437474/gov.uscourts.cand.437474.33.0.pdf)<!-- HN:41923897:end --><!-- HN:41924277:start -->
* [41924277](https://news.social-protocols.org/stats?id=41924277) #30 8 points 1 comments -> [U.S. Says North Korean Troops Are in Russia to Aid Fight Against Ukraine](https://www.nytimes.com/international/)<!-- HN:41924277:end --><!-- HN:41923865:start -->
* [41923865](https://news.social-protocols.org/stats?id=41923865) #25 4 points 0 comments -> [Open Letter by Climate Scientists to the Nordic Council of Ministers [pdf]](https://en.vedur.is/media/ads_in_header/AMOC-letter_Final.pdf)<!-- HN:41923865:end --><!-- HN:41921673:start -->
* [41921673](https://news.social-protocols.org/stats?id=41921673) #30 87 points 22 comments -> [Migration of the build system to autosetup](https://sqlite.org/forum/forumpost/b7e2d83c0bcfae1e)<!-- HN:41921673:end --><!-- HN:41923941:start -->
* [41923941](https://news.social-protocols.org/stats?id=41923941) #26 6 points 1 comments -> [Want to feel old? Excel just entered its 40th year](https://www.theregister.com/2024/10/22/excel_enters_its_40th_year/)<!-- HN:41923941:end --><!-- HN:41893521:start -->
* [41893521](https://news.social-protocols.org/stats?id=41893521) #25 7 points 0 comments -> [Explaining color gamuts and color spaces in HDTVs and monitors](https://www.wired.com/story/what-are-color-gamuts-and-why-do-they-matter/)<!-- HN:41893521:end --><!-- HN:41898898:start -->
* [41898898](https://news.social-protocols.org/stats?id=41898898) #19 23 points 9 comments -> [Why computational predictive toxicology is hard](https://www.owlposting.com/p/a-primer-on-why-computational-predictive)<!-- HN:41898898:end --><!-- HN:41925345:start -->
* [41925345](https://news.social-protocols.org/stats?id=41925345) #24 4 points 0 comments -> [The DeVault Report](https://dmpwn.info/)<!-- HN:41925345:end --><!-- HN:41925333:start -->
* [41925333](https://news.social-protocols.org/stats?id=41925333) #15 27 points 8 comments -> [Israel’s Secret Stealth Drone](https://www.twz.com/air/the-existence-of-israels-secret-stealth-drone-should-come-as-no-surprise)<!-- HN:41925333:end --><!-- HN:41925725:start -->
* [41925725](https://news.social-protocols.org/stats?id=41925725) #1 28 points 18 comments -> [LLMs Aren't Thinking, They're Just Counting Votes](https://vishnurnair.substack.com/p/llms-arent-thinking-theyre-just-counting)<!-- HN:41925725:end --><!-- HN:41919365:start -->
* [41919365](https://news.social-protocols.org/stats?id=41919365) #14 140 points 96 comments -> [I Got Dysentary So You Don't Have To](https://eukaryotewritesblog.com/2024/10/21/i-got-dysentery-so-you-dont-have-to/)<!-- HN:41919365:end --><!-- HN:41879930:start -->
* [41879930](https://news.social-protocols.org/stats?id=41879930) #28 19 points 0 comments -> [Supporting Task Switching with Reinforcement Learning](https://dl.acm.org/doi/10.1145/3613904.3642063)<!-- HN:41879930:end --><!-- HN:41897855:start -->
* [41897855](https://news.social-protocols.org/stats?id=41897855) #21 3 points 0 comments -> [A boy and his carbon steel pan: a growth marketing story](https://chiefgrowthadvisor.com/hello-world/)<!-- HN:41897855:end --><!-- HN:41885192:start -->
* [41885192](https://news.social-protocols.org/stats?id=41885192) #18 23 points 40 comments -> [What makes a person seem wise?](https://theconversation.com/what-makes-a-person-seem-wise-global-study-finds-that-cultures-do-differ-but-not-as-much-as-youd-think-238808)<!-- HN:41885192:end --><!-- HN:41926967:start -->
* [41926967](https://news.social-protocols.org/stats?id=41926967) #15 23 points 3 comments -> [Apple and Goldman Sachs deceived Apple Card customers, regulators say](https://www.washingtonpost.com/business/2024/10/23/apple-card-goldman-sachs-cfpb/)<!-- HN:41926967:end --><!-- HN:41927503:start -->
* [41927503](https://news.social-protocols.org/stats?id=41927503) #14 64 points 40 comments -> [Landowner Sues After State Searches Property Without Warrant or Consent](https://www.agweb.com/news/business/farmland/rural-landowner-sues-after-state-searches-property-without-warrant-or-cons)<!-- HN:41927503:end --><!-- HN:41927286:start -->
* [41927286](https://news.social-protocols.org/stats?id=41927286) #9 24 points 17 comments -> [Show HN: Nix at work: FlakeHub Cache and private flakes](https://determinate.systems/posts/flakehub-cache-and-private-flakes/)<!-- HN:41927286:end --><!-- HN:41928708:start -->
* [41928708](https://news.social-protocols.org/stats?id=41928708) #13 8 points 0 comments -> [Bail Bond Insurers Are Lobbying to Keep People in Jail](https://jacobin.com/2024/10/bail-bonds-lobbyists-insurers-reform/)<!-- HN:41928708:end --><!-- HN:41927942:start -->
* [41927942](https://news.social-protocols.org/stats?id=41927942) #13 5 points 0 comments -> [The greenhouse gas footprint of liquefied natural gas (LNG) exported from the US](https://scijournals.onlinelibrary.wiley.com/doi/10.1002/ese3.1934)<!-- HN:41927942:end -->
#### **Thursday, October 24, 2024**
<!-- HN:41930586:start -->
* [41930586](https://news.social-protocols.org/stats?id=41930586) #23 70 points 9 comments -> [Apple ripped a valuable hearing loss feature from the AirPods line](https://mattiebee.io/55828/it-sure-looks-like-apple-ripped-a-valuable-hearing-loss-feature-from-the-airpods-line)<!-- HN:41930586:end --><!-- HN:41930517:start -->
* [41930517](https://news.social-protocols.org/stats?id=41930517) #28 21 points 41 comments -> [Tesla has been testing a robotaxi service in the Bay Area for most of the year](https://www.theverge.com/2024/10/23/24278056/tesla-robotaxi-ride-hailing-test-employees)<!-- HN:41930517:end --><!-- HN:41933072:start -->
* [41933072](https://news.social-protocols.org/stats?id=41933072) #11 12 points 1 comments -> [Goodbye from a Linux Community Volunteer](https://lore.kernel.org/all/2m53bmuzemamzc4jzk2bj7tli22ruaaqqe34a2shtdtqrd52hp@alifh66en3rj/?continueFlag=e2ee59a17c94394b73015e68fa012316)<!-- HN:41933072:end --><!-- HN:41925323:start -->
* [41925323](https://news.social-protocols.org/stats?id=41925323) #11 148 points 41 comments -> [Async Rust in Three Parts](https://jacko.io/async_intro.html)<!-- HN:41925323:end --><!-- HN:41931392:start -->
* [41931392](https://news.social-protocols.org/stats?id=41931392) #23 183 points 94 comments -> [TSMC Cuts Off Client After Discovering Chips Sent to Huawei](https://www.bloomberg.com/news/articles/2024-10-23/tsmc-cuts-off-client-after-discovering-chips-diverted-to-huawei)<!-- HN:41931392:end --><!-- HN:41930772:start -->
* [41930772](https://news.social-protocols.org/stats?id=41930772) #23 56 points 7 comments -> [Rust in Enterprise Kernels](https://lwn.net/Articles/993337/)<!-- HN:41930772:end --><!-- HN:41933078:start -->
* [41933078](https://news.social-protocols.org/stats?id=41933078) #15 21 points 27 comments -> [Show HN: Microsoft Teams Ticketing System – Ticketing as a Service](https://www.teamswork.app/best-microsoft-teams-ticketing-service-desk)<!-- HN:41933078:end --><!-- HN:41934219:start -->
* [41934219](https://news.social-protocols.org/stats?id=41934219) #15 -> [Goodbye from a Linux Community Volunteer](https://lore.kernel.org/all/2m53bmuzemamzc4jzk2bj7tli22ruaaqqe34a2shtdtqrd52hp@alifh66en3rj/)<!-- HN:41934219:end --><!-- HN:41934437:start -->
* [41934437](https://news.social-protocols.org/stats?id=41934437) #20 9 points 1 comments -> [(UK) Government crackdown on single-use vapes](https://www.gov.uk/government/news/government-crackdown-on-single-use-vapes)<!-- HN:41934437:end --><!-- HN:41935555:start -->
* [41935555](https://news.social-protocols.org/stats?id=41935555) #22 9 points 1 comments -> [I think Visual Studio has a problem... Rider is Free now!](https://www.jetbrains.com/rider/)<!-- HN:41935555:end --><!-- HN:41936328:start -->
* [41936328](https://news.social-protocols.org/stats?id=41936328) #19 -> [She Was Arrested for Praying in Her Head](https://www.thefp.com/p/abortion-buffer-zones-united-kingdom-free-speech-arrested-for-praying-in-her-head)<!-- HN:41936328:end --><!-- HN:41936527:start -->
* [41936527](https://news.social-protocols.org/stats?id=41936527) #4 19 points 2 comments -> [Uber, Lyft drivers block Manhattan traffic to protest lockouts](https://www.amny.com/transit/uber-lyft-drivers-block-traffic-lockouts/)<!-- HN:41936527:end --><!-- HN:41936688:start -->
* [41936688](https://news.social-protocols.org/stats?id=41936688) #5 -> [The U.S. Government-Bought Tool That Can Track Phones at Abortion Clinics](https://www.404media.co/inside-the-u-s-government-bought-tool-that-can-track-phones-at-abortion-clinics/)<!-- HN:41936688:end --><!-- HN:41935741:start -->
* [41935741](https://news.social-protocols.org/stats?id=41935741) #28 61 points 54 comments -> [Developing with Docker](https://danielquinn.org/blog/developing-with-docker/)<!-- HN:41935741:end --><!-- HN:41937577:start -->
* [41937577](https://news.social-protocols.org/stats?id=41937577) #22 4 points 0 comments -> [Everything Is a Conspiracy Theory When You Don't Bother to Educate Yourself](https://www.techdirt.com/2024/10/23/everything-is-a-conspiracy-theory-when-you-dont-bother-to-educate-yourself/)<!-- HN:41937577:end --><!-- HN:41936890:start -->
* [41936890](https://news.social-protocols.org/stats?id=41936890) #14 22 points 18 comments -> [The Rise and Fall of IQ: The Cognitive Divide](https://onepercentrule.substack.com/p/the-rise-and-fall-of-iq-the-cognitive)<!-- HN:41936890:end --><!-- HN:41938209:start -->
* [41938209](https://news.social-protocols.org/stats?id=41938209) #2 15 points 7 comments -> [Many people overestimate the percentage of immigrants in their country](https://ourworldindata.org/data-insights/many-people-overestimate-the-percentage-of-immigrants-in-their-country)<!-- HN:41938209:end --><!-- HN:41937793:start -->
* [41937793](https://news.social-protocols.org/stats?id=41937793) #19 8 points 0 comments -> [APL Cultivations](https://xpqz.github.io/cultivations/Intro.html)<!-- HN:41937793:end --><!-- HN:41890048:start -->
* [41890048](https://news.social-protocols.org/stats?id=41890048) #18 13 points 2 comments -> [Nonlinear Schrödinger numerical simulation in 3D](https://marl0ny.github.io/split-operator-simulations/js/3d.html)<!-- HN:41890048:end --><!-- HN:41939158:start -->
* [41939158](https://news.social-protocols.org/stats?id=41939158) #5 16 points 15 comments -> [Ultra fast key value store (in C btw)](https://freshql.ai/blog_fast_storage.html)<!-- HN:41939158:end --><!-- HN:41939138:start -->
* [41939138](https://news.social-protocols.org/stats?id=41939138) #27 7 points 0 comments -> [Kazan Declaration [pdf]](http://static.kremlin.ru/media/events/files/en/RosOySvLzGaJtmx2wYFv0lN4NSPZploG.pdf)<!-- HN:41939138:end -->
#### **Friday, October 25, 2024**
<!-- HN:41944002:start -->
* [41944002](https://news.social-protocols.org/stats?id=41944002) #18 25 points 1 comments -> [U.S. Study on Puberty Blockers Goes Unpublished Because of Politics, Doctor Says](https://www.nytimes.com/2024/10/23/science/puberty-blockers-olson-kennedy.html)<!-- HN:41944002:end --><!-- HN:41943756:start -->
* [41943756](https://news.social-protocols.org/stats?id=41943756) #8 31 points 29 comments -> [Show HN: I made a Bluesky video downloader that can download videos from Bluesky](https://blueskyvideodownloader.org/)<!-- HN:41943756:end --><!-- HN:41945213:start -->
* [41945213](https://news.social-protocols.org/stats?id=41945213) #21 9 points 0 comments -> [Wikipedia's Pro-Hamas Editors Hijacked the Israel-Palestine Narrative](https://www.piratewires.com/p/how-wikipedia-s-pro-hamas-editors-hijacked-the-israel-palestine-narrative)<!-- HN:41945213:end --><!-- HN:41944836:start -->
* [41944836](https://news.social-protocols.org/stats?id=41944836) #8 27 points 2 comments -> [Astronauts return from nearly eight months on ISS after Starliner problems](https://www.theguardian.com/science/2024/oct/25/spacex-astronauts-return-to-earth-after-delay-due-to-boeing-capsule-snags)<!-- HN:41944836:end --><!-- HN:41943589:start -->
* [41943589](https://news.social-protocols.org/stats?id=41943589) #18 32 points 24 comments -> [Eartho: Open-Source, Privacy-Focused Alternative to Google Sign-In](https://github.com/eartho-group/eartho)<!-- HN:41943589:end --><!-- HN:41919275:start -->
* [41919275](https://news.social-protocols.org/stats?id=41919275) #15 8 points 1 comments -> [The Ballad of the Inquisition's Greatest Witch Trial](https://www.historytoday.com/archive/history-matters/ballad-inquisitions-greatest-witch-trial)<!-- HN:41919275:end --><!-- HN:41946497:start -->
* [41946497](https://news.social-protocols.org/stats?id=41946497) #18 9 points 0 comments -> [Ensuring Stability and Security: Recent Timeline](https://wpengine.com/blog/ensuring-stability-and-security/)<!-- HN:41946497:end --><!-- HN:41947403:start -->
* [41947403](https://news.social-protocols.org/stats?id=41947403) #7 21 points 41 comments -> [It's not just obesity. Drugs like Ozempic will change the world](https://www.economist.com/leaders/2024/10/24/its-not-just-obesity-drugs-like-ozempic-will-change-the-world)<!-- HN:41947403:end --><!-- HN:41947201:start -->
* [41947201](https://news.social-protocols.org/stats?id=41947201) #27 27 points 40 comments -> [The future of software is Nix](https://determinate.systems/posts/the-future-is-nix/)<!-- HN:41947201:end --><!-- HN:41948631:start -->
* [41948631](https://news.social-protocols.org/stats?id=41948631) #15 20 points 8 comments -> [Jeff Bezos kills Washington Post editorial board presidential endorsement](https://www.washingtonpost.com/style/media/2024/10/25/washington-post-endorsement-president/)<!-- HN:41948631:end --><!-- HN:41949441:start -->
* [41949441](https://news.social-protocols.org/stats?id=41949441) #5 37 points 1 comments -> [US Copyright Office "frees the McFlurry," allowing repair of ice cream machines](https://arstechnica.com/tech-policy/2024/10/us-copyright-office-frees-the-mcflurry-allowing-repair-of-ice-cream-machines/)<!-- HN:41949441:end --><!-- HN:41907928:start -->
* [41907928](https://news.social-protocols.org/stats?id=41907928) #21 8 points 4 comments -> [New largest prime number found See all 41,024,320 digits [video]](https://www.youtube.com/watch?v=zsyGRDrDfbI)<!-- HN:41907928:end --><!-- HN:41905595:start -->
* [41905595](https://news.social-protocols.org/stats?id=41905595) #29 40 points 1 comments -> [Making Of: Line Drawing Tutorial (2017)](https://www.redblobgames.com/making-of/line-drawing/)<!-- HN:41905595:end --><!-- HN:41910080:start -->
* [41910080](https://news.social-protocols.org/stats?id=41910080) #17 11 points 6 comments -> [Show HN: Optimizing compiler for a large subset of C, written in Rust](https://github.com/xqb64/ucc)<!-- HN:41910080:end -->
#### **Saturday, October 26, 2024**
<!-- HN:41951215:start -->
* [41951215](https://news.social-protocols.org/stats?id=41951215) #28 9 points 1 comments -> [Wikipedia Put a Near Total Ban on Calling Gaza Health Ministry "Hamas-Run"](https://jewishjournal.com/news/united-states/376157/wikipedia-editors-place-a-near-total-ban-on-calling-gaza-health-ministry-hamas-run/)<!-- HN:41951215:end --><!-- HN:41951972:start -->
* [41951972](https://news.social-protocols.org/stats?id=41951972) #4 6 points 5 comments -> [Cqwrteur's fork of Linux kernel, rename it to Cinux](https://github.com/Cqinux/cinux)<!-- HN:41951972:end --><!-- HN:41952120:start -->
* [41952120](https://news.social-protocols.org/stats?id=41952120) #25 5 points 0 comments -> [Israel strikes military targets in Iran](https://www.washingtonpost.com/world/2024/10/25/israel-iran-attack-war-strikes/)<!-- HN:41952120:end --><!-- HN:41951773:start -->
* [41951773](https://news.social-protocols.org/stats?id=41951773) #25 85 points 30 comments -> [Russia amplified hurricane disinformation to drive Americans apart](https://abc7chicago.com/post/russia-amplified-hurricane-disinformation-drive-americans-apart-researchers-find/15463309/)<!-- HN:41951773:end --><!-- HN:41952375:start -->
* [41952375](https://news.social-protocols.org/stats?id=41952375) #23 6 points 1 comments -> [Tesla headquarters spills gallons of lime-green liquid into Bay Area street](https://www.sfgate.com/tech/article/tesla-spills-lime-green-liquid-19863951.php)<!-- HN:41952375:end --><!-- HN:41916143:start -->
* [41916143](https://news.social-protocols.org/stats?id=41916143) #6 7 points 1 comments -> [Solving the Mystery of ARM7TDMI Multiply Carry Flag](https://bmchtech.github.io/post/multiply/)<!-- HN:41916143:end --><!-- HN:41953494:start -->
* [41953494](https://news.social-protocols.org/stats?id=41953494) #24 34 points 27 comments -> [On Linux MAINTAINERS file removal of Russian developers](https://laforge.gnumonks.org/blog/20241025-linux-maintainers-russian/)<!-- HN:41953494:end --><!-- HN:41954445:start -->
* [41954445](https://news.social-protocols.org/stats?id=41954445) #22 36 points 34 comments -> [Lily Allen Says Her OnlyFans Feet Pictures Make More Money Than Spotify Streams](https://variety.com/2024/music/news/lily-allen-onlyfans-feet-pictures-spotify-1236191247/)<!-- HN:41954445:end --><!-- HN:41954755:start -->
* [41954755](https://news.social-protocols.org/stats?id=41954755) #8 8 points 4 comments -> [Hacktoberfest 2024](https://hacktoberfest.com)<!-- HN:41954755:end --><!-- HN:41955754:start -->
* [41955754](https://news.social-protocols.org/stats?id=41955754) #2 -> ["Twitch or Terrorist?", A Game](https://www.twitchorterrorist.com/)<!-- HN:41955754:end --><!-- HN:41956080:start -->
* [41956080](https://news.social-protocols.org/stats?id=41956080) #13 43 points 11 comments -> [35% Faster Than the Filesystem](https://www.sqlite.org/fasterthanfs.html)<!-- HN:41956080:end --><!-- HN:41956788:start -->
* [41956788](https://news.social-protocols.org/stats?id=41956788) #10 11 points 0 comments -> [Microsoft fires employees who organized vigil for Palestinians killed in Gaza](https://apnews.com/article/microsoft-fired-workers-israel-palestinians-gaza-72de6fe1f35db9398e3b6785203c6bbf)<!-- HN:41956788:end --><!-- HN:41956759:start -->
* [41956759](https://news.social-protocols.org/stats?id=41956759) #23 5 points 1 comments -> [1933 and the Definition of Fascism](https://acoup.blog/2024/10/25/new-acquisitions-1933-and-the-definition-of-fascism/)<!-- HN:41956759:end --><!-- HN:41914835:start -->
* [41914835](https://news.social-protocols.org/stats?id=41914835) #5 60 points 13 comments -> [Vampire Number](https://mathworld.wolfram.com/VampireNumber.html)<!-- HN:41914835:end --><!-- HN:41909933:start -->
* [41909933](https://news.social-protocols.org/stats?id=41909933) #21 43 points 72 comments -> [Adaptation to high-altitude hypoxia on the Tibetan Plateau](https://www.sciencealert.com/humans-are-evolving-right-before-our-eyes-on-the-tibetan-plateau)<!-- HN:41909933:end --><!-- HN:41913319:start -->
* [41913319](https://news.social-protocols.org/stats?id=41913319) #22 60 points 75 comments -> [Marketing the Odin programming language is weird](http://www.gingerbill.org/article/2024/09/08/odin-weird-to-market/)<!-- HN:41913319:end --><!-- HN:41957829:start -->
* [41957829](https://news.social-protocols.org/stats?id=41957829) #19 83 points 24 comments -> [Bullenweg.com is no longer available following threats of legal action](https://bullenweg.com/)<!-- HN:41957829:end --><!-- HN:41958309:start -->
* [41958309](https://news.social-protocols.org/stats?id=41958309) #7 6 points 0 comments -> [Microsoft fires employees who organized vigil for Palestinians killed in Gaza](https://apnews.com/article/microsoft-fired-workers-israel-palestinians-gaza-72de6fe1f35db9398e3b6785203c6bbf)<!-- HN:41958309:end -->
#### **Sunday, October 27, 2024**
<!-- HN:41960114:start -->
* [41960114](https://news.social-protocols.org/stats?id=41960114) #25 6 points 3 comments -> [Google to develop AI that takes over computers, The Information reports](https://www.reuters.com/technology/artificial-intelligence/google-develop-ai-that-takes-over-computers-information-reports-2024-10-26/)<!-- HN:41960114:end --><!-- HN:41961469:start -->
* [41961469](https://news.social-protocols.org/stats?id=41961469) #18 5 points 0 comments -> [It's now the Washington Post humor writer's job to endorse Harris for president](https://www.washingtonpost.com/opinions/2024/10/26/washington-post-endorses-kamala-harris-satire/)<!-- HN:41961469:end --><!-- HN:41961391:start -->
* [41961391](https://news.social-protocols.org/stats?id=41961391) #12 10 points 10 comments -> [UK sleep experts say it's time to kill daylight saving for good](https://www.theregister.com/2024/10/27/abolish_daylight_saving_time/)<!-- HN:41961391:end --><!-- HN:41933527:start -->
* [41933527](https://news.social-protocols.org/stats?id=41933527) #12 8 points 0 comments -> [A brief history of Notion's data catalog](https://www.notion.so/blog/a-brief-history-of-notions-data-catalog)<!-- HN:41933527:end --><!-- HN:41935319:start -->
* [41935319](https://news.social-protocols.org/stats?id=41935319) #14 19 points 14 comments -> [Comparison of configuration file languages (2016)](https://gist.github.com/njsmith/78f68204c5d969f8c8bc645ef77d4a8f)<!-- HN:41935319:end --><!-- HN:41915978:start -->
* [41915978](https://news.social-protocols.org/stats?id=41915978) #23 63 points 69 comments -> [Order and orient the keys on your keychain](https://practicalbetterments.com/order-and-orient-the-keys-on-your-keychain/)<!-- HN:41915978:end --><!-- HN:41960124:start -->
* [41960124](https://news.social-protocols.org/stats?id=41960124) #14 41 points 1 comments -> [DragonRuby Game Toolkit hits v6.0](https://dragonruby.itch.io/dragonruby-gtk/devlog/809843/dragonruby-hits-v60)<!-- HN:41960124:end --><!-- HN:41918354:start -->
* [41918354](https://news.social-protocols.org/stats?id=41918354) #17 3 points 2 comments -> [Humans Are Evolving Right Before Our Eyes on the Tibetan Plateau](https://www.sciencealert.com/humans-are-evolving-right-before-our-eyes-on-the-tibetan-plateau)<!-- HN:41918354:end --><!-- HN:41961356:start -->
* [41961356](https://news.social-protocols.org/stats?id=41961356) #7 26 points 17 comments -> [Some people with ADHD thrive in periods of stress, new study shows](https://www.theguardian.com/us-news/2024/oct/26/adhd-symptoms-high-stress)<!-- HN:41961356:end --><!-- HN:41961550:start -->
* [41961550](https://news.social-protocols.org/stats?id=41961550) #20 4 points 0 comments -> [Decomplexifying Curl](https://daniel.haxx.se/blog/2024/10/27/decomplexifying-curl/)<!-- HN:41961550:end --><!-- HN:41960843:start -->
* [41960843](https://news.social-protocols.org/stats?id=41960843) #29 9 points 0 comments -> ['We took on Google and they were forced to pay out £2B'](https://www.bbc.co.uk/news/articles/cjr431lr72jo)<!-- HN:41960843:end --><!-- HN:41960011:start -->
* [41960011](https://news.social-protocols.org/stats?id=41960011) #18 51 points 10 comments -> [Codeberg Reconsidering OSI License Approval in Terms of Use](https://codeberg.org/Codeberg/Community/issues/1654)<!-- HN:41960011:end --><!-- HN:41959324:start -->
* [41959324](https://news.social-protocols.org/stats?id=41959324) #29 8 points 0 comments -> [A16 Technology](https://www.tsmc.com/english/dedicatedFoundry/technology/logic/l_A16)<!-- HN:41959324:end --><!-- HN:41962411:start -->
* [41962411](https://news.social-protocols.org/stats?id=41962411) #14 15 points 13 comments -> [Scientists developed a novel method to detect lies](https://www.universal-sci.com/headlines/2020/12/17/spotting-liars-is-hard-but-our-new-method-is-effective-and-ethical)<!-- HN:41962411:end --><!-- HN:41963083:start -->
* [41963083](https://news.social-protocols.org/stats?id=41963083) #15 4 points 0 comments -> [Microsoft fires employees who organized vigil for Palestinians killed in Gaza](https://apnews.com/article/microsoft-fired-workers-israel-palestinians-gaza-72de6fe1f35db9398e3b6785203c6bbf)<!-- HN:41963083:end --><!-- HN:41962569:start -->
* [41962569](https://news.social-protocols.org/stats?id=41962569) #8 8 points 0 comments -> [Show HN: I Built a Tech Stack Recommender](https://boilerplatehub.com/tech-stack-recommender)<!-- HN:41962569:end --><!-- HN:41962983:start -->
* [41962983](https://news.social-protocols.org/stats?id=41962983) #3 19 points 10 comments -> [The Blowout No One Sees Coming](https://app.vantagedatahouse.com/analysis/TheBlowoutNoOneSeesComing-1)<!-- HN:41962983:end --><!-- HN:41962820:start -->
* [41962820](https://news.social-protocols.org/stats?id=41962820) #25 7 points 5 comments -> [Don't use Summer and Winter for event invites, it's "northern" and not inclusive](https://www.nature.com/articles/d41586-024-03245-0)<!-- HN:41962820:end --><!-- HN:41962901:start -->
* [41962901](https://news.social-protocols.org/stats?id=41962901) #17 14 points 2 comments -> [Cissp Cheatsheet](https://old.reddit.com/r/cissp/comments/uzpwcw/cissp_cheatsheet_for_exam_preparation/)<!-- HN:41962901:end --><!-- HN:41962480:start -->
* [41962480](https://news.social-protocols.org/stats?id=41962480) #14 6 points 0 comments -> [Mathematics for Computer Science [pdf]](https://courses.csail.mit.edu/6.042/spring18/mcs.pdf)<!-- HN:41962480:end --><!-- HN:41961149:start -->
* [41961149](https://news.social-protocols.org/stats?id=41961149) #23 11 points 0 comments -> [Wafer Scale – Trilogy Systems: Part 2](https://thechipletter.substack.com/p/wafer-scale-trilogy-systems-part-359)<!-- HN:41961149:end --><!-- HN:41962757:start -->
* [41962757](https://news.social-protocols.org/stats?id=41962757) #11 4 points 0 comments -> [The Knowledge Graph: things, not strings (2012)](https://blog.google/products/search/introducing-knowledge-graph-things-not/)<!-- HN:41962757:end --><!-- HN:41962627:start -->
* [41962627](https://news.social-protocols.org/stats?id=41962627) #27 8 points 1 comments -> [Privacy4Cars](https://privacy4cars.com/)<!-- HN:41962627:end --><!-- HN:41926070:start -->
* [41926070](https://news.social-protocols.org/stats?id=41926070) #17 10 points 4 comments -> [A Deep Dive into German Strings](https://cedardb.com/blog/strings_deep_dive/)<!-- HN:41926070:end --><!-- HN:41963890:start -->
* [41963890](https://news.social-protocols.org/stats?id=41963890) #15 11 points 1 comments -> [ModelKit: Transforming AI/ML artifact sharing and management across lifecycles](https://kitops.ml/docs/modelkit/intro.html)<!-- HN:41963890:end --><!-- HN:41963906:start -->
* [41963906](https://news.social-protocols.org/stats?id=41963906) #20 13 points 4 comments -> [What Is a Raspberry Pi AI Kit?](https://raspberrytips.com/what-is-raspberry-pi-ai-kit/)<!-- HN:41963906:end -->
#### **Monday, October 28, 2024**
<!-- HN:41966711:start -->
* [41966711](https://news.social-protocols.org/stats?id=41966711) #26 8 points 1 comments -> [Microsoft fires employees who organized vigil for Palestinians killed in Gaza](https://www.seattletimes.com/business/microsoft-fires-employees-who-organized-vigil-for-palestinians-killed-in-gaza/)<!-- HN:41966711:end --><!-- HN:41967293:start -->
* [41967293](https://news.social-protocols.org/stats?id=41967293) #9 18 points 1 comments -> [Japan's Jimi 'Mundane' Halloween Costumes of 2024](https://www.spoon-tamago.com/jimi-mundane-halloween-2024/)<!-- HN:41967293:end --><!-- HN:41968008:start -->
* [41968008](https://news.social-protocols.org/stats?id=41968008) #21 10 points 2 comments -> [Digital Nomads Are Exploiting the World](https://www.thrillist.com/travel/nation/digital-nomads-criticism-locals-exploitation)<!-- HN:41968008:end --><!-- HN:41925216:start -->
* [41925216](https://news.social-protocols.org/stats?id=41925216) #13 12 points 7 comments -> [Did DORA's last update create an encryption loophole?](https://evervault.com/blog/did-dora-s-last-update-create-an-encryption-loophole)<!-- HN:41925216:end --><!-- HN:41968744:start -->
* [41968744](https://news.social-protocols.org/stats?id=41968744) #1 12 points 4 comments -> [Why Google Search Is Falling Apart?](https://wpxplore.com/google-search-is-falling-apart/)<!-- HN:41968744:end --><!-- HN:41969327:start -->
* [41969327](https://news.social-protocols.org/stats?id=41969327) #1 26 points 1 comments -> [How to Build Your Career in AI [pdf]](https://wordpress.deeplearning.ai/wp-content/uploads/2022/10/eBook-How-to-Build-a-Career-in-AI.pdf)<!-- HN:41969327:end --><!-- HN:41967147:start -->
* [41967147](https://news.social-protocols.org/stats?id=41967147) #9 59 points 114 comments -> [Could you pass this 8th grade test from 1912?](https://onepercentrule.substack.com/p/could-you-pass-this-8th-grade-test)<!-- HN:41967147:end --><!-- HN:41940394:start -->
* [41940394](https://news.social-protocols.org/stats?id=41940394) #7 8 points 2 comments -> [Preserved tracks suggest non-avian dinosaurs used their wings to run](https://www.newscientist.com/article/2452672-preserved-tracks-suggest-non-avian-dinosaurs-used-their-wings-to-run/)<!-- HN:41940394:end --><!-- HN:41970413:start -->
* [41970413](https://news.social-protocols.org/stats?id=41970413) #2 10 points 0 comments -> [Microsoft fires employees who organized vigil for Palestinians killed in Gaza](https://apnews.com/article/microsoft-fired-workers-israel-palestinians-gaza-72de6fe1f35db9398e3b6785203c6bbf)<!-- HN:41970413:end --><!-- HN:41971060:start -->
* [41971060](https://news.social-protocols.org/stats?id=41971060) #8 15 points 2 comments -> [M-series MacBook SSD storage upgrade (non-official) [video]](https://www.youtube.com/watch?v=E3N-z-Y8cuw)<!-- HN:41971060:end --><!-- HN:41947881:start -->
* [41947881](https://news.social-protocols.org/stats?id=41947881) #6 10 points 2 comments -> [x86 Early Kernel Boot Process with Microcode, ACPI Overrides, and Initrd](https://labcsmart.com/x86-platforms-part-3-early-kernel-boot-process-with-microcode-acpi-override-and-initrd/)<!-- HN:41947881:end --><!-- HN:41972610:start -->
* [41972610](https://news.social-protocols.org/stats?id=41972610) #23 9 points 2 comments -> [UnitedHealth says Change Healthcare hack affects 100M – largest US health breach](https://techcrunch.com/2024/10/24/unitedhealth-change-healthcare-hacked-millions-health-records-ransomware/)<!-- HN:41972610:end -->
#### **Tuesday, October 29, 2024**
<!-- HN:41978213:start -->
* [41978213](https://news.social-protocols.org/stats?id=41978213) #3 22 points 4 comments -> [How to Learn Things by Yourself](https://brunothedev.github.io/p/2024-10-28-how_to_learn.html)<!-- HN:41978213:end --><!-- HN:41977665:start -->
* [41977665](https://news.social-protocols.org/stats?id=41977665) #17 12 points 0 comments -> [Show HN: Apache ResilientDB, High-Performance Open-Source Blockchain](https://resilientdb.incubator.apache.org/)<!-- HN:41977665:end --><!-- HN:41978940:start -->
* [41978940](https://news.social-protocols.org/stats?id=41978940) #9 7 points 2 comments -> [Haiku OS domain has been hijacked](https://haiku-os.org)<!-- HN:41978940:end --><!-- HN:41942693:start -->
* [41942693](https://news.social-protocols.org/stats?id=41942693) #10 11 points 1 comments -> [Lost Silk Road cities discovered in Uzbek mountains](https://www.bbc.co.uk/news/articles/c238kv8ddeyo)<!-- HN:41942693:end --><!-- HN:41926320:start -->
* [41926320](https://news.social-protocols.org/stats?id=41926320) #26 54 points 25 comments -> [Debugging audio artifacts caused by... a serial port?](https://www.recall.ai/post/debugging-audio-artifacts-caused-by-a-serial-port)<!-- HN:41926320:end --><!-- HN:41978246:start -->
* [41978246](https://news.social-protocols.org/stats?id=41978246) #19 117 points 42 comments -> [An indie studio created a game based on Stanislaw Lem's novel](https://invinciblethegame.com/?hn)<!-- HN:41978246:end -->