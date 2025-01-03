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

#### **Saturday, December 28, 2024**
<!-- HN:42526150:start -->
* [42526150](https://news.social-protocols.org/stats?id=42526150) #21 12 points 10 comments -> [Show HN: NeatShift – Organize Windows Files with Symbolic Links](https://github.com/BytexGrid/NeatShift)<!-- HN:42526150:end --><!-- HN:42507395:start -->
* [42507395](https://news.social-protocols.org/stats?id=42507395) #14 5 points 2 comments -> [Clap to Find My Phone App](https://getmobi.ai/)<!-- HN:42507395:end --><!-- HN:42529207:start -->
* [42529207](https://news.social-protocols.org/stats?id=42529207) #12 50 points 23 comments -> [LLMs are everything that it wrong in computing](https://crys.site/blog/2024/llms-scare-me/)<!-- HN:42529207:end --><!-- HN:42530293:start -->
* [42530293](https://news.social-protocols.org/stats?id=42530293) #3 9 points 7 comments -> [Casual Viewing – Why Netflix looks like that](https://www.nplusonemag.com/issue-49/essays/casual-viewing/)<!-- HN:42530293:end --><!-- HN:42529396:start -->
* [42529396](https://news.social-protocols.org/stats?id=42529396) #17 29 points 3 comments -> [Ten things in tech I found joy in during 2024](https://rubenerd.com/ten-it-things-i-found-joy-in-this-year/)<!-- HN:42529396:end --><!-- HN:42506623:start -->
* [42506623](https://news.social-protocols.org/stats?id=42506623) #16 90 points 26 comments -> [PixLens: A lens that turns the scenery you see into pixel art](https://monoli-shop.com/products/pixlens-コピー)<!-- HN:42506623:end --><!-- HN:42532156:start -->
* [42532156](https://news.social-protocols.org/stats?id=42532156) #17 13 points 8 comments -> [Costco Denies Shareholder Demand to Back Down from DEI Hiring](https://www.newsweek.com/costco-board-shareholder-dei-hiring-2006717)<!-- HN:42532156:end --><!-- HN:42532429:start -->
* [42532429](https://news.social-protocols.org/stats?id=42532429) #4 40 points 19 comments -> [Missile Strike Confirmed as Cause of Azerbaijan E190 Crash – Aeroxplorer.com](https://aeroxplorer.com/articles/missile-strike-confirmed-as-cause-of-azerbaijan-e190-crash.php)<!-- HN:42532429:end --><!-- HN:42532353:start -->
* [42532353](https://news.social-protocols.org/stats?id=42532353) #30 11 points 6 comments -> [Per Seat Pricing Sucks](https://blog.flippercloud.io/per-seat-pricing-sucks/)<!-- HN:42532353:end -->
#### **Sunday, December 29, 2024**
<!-- HN:42536342:start -->
* [42536342](https://news.social-protocols.org/stats?id=42536342) #23 10 points 3 comments -> [Dr. Paul Releases 2024 'Festivus' Report on Government Waste](https://www.hsgac.senate.gov/media/reps/dr-paul-releases-2024-festivus-report-on-government-waste/)<!-- HN:42536342:end --><!-- HN:42537790:start -->
* [42537790](https://news.social-protocols.org/stats?id=42537790) #4 4 points 6 comments -> [Show HN: I built a website that explains any difficult concept in seconds](https://www.nodsgy.com/)<!-- HN:42537790:end --><!-- HN:42537829:start -->
* [42537829](https://news.social-protocols.org/stats?id=42537829) #12 30 points 16 comments -> [America in Two Headlines](https://www.kenklippenstein.com/p/america-in-two-headlines)<!-- HN:42537829:end --><!-- HN:42538458:start -->
* [42538458](https://news.social-protocols.org/stats?id=42538458) #26 9 points 5 comments -> [SQLite3: No Room for Drama](https://calmlog.medium.com/sqlite3-no-room-for-drama-ceea8a84426e)<!-- HN:42538458:end --><!-- HN:42539398:start -->
* [42539398](https://news.social-protocols.org/stats?id=42539398) #29 23 points 7 comments -> [McKinsey Destroyed the Middle Class](https://www.theatlantic.com/ideas/archive/2020/02/how-mckinsey-destroyed-middle-class/605878/)<!-- HN:42539398:end --><!-- HN:42539673:start -->
* [42539673](https://news.social-protocols.org/stats?id=42539673) #7 5 points 0 comments -> [Year 2024 ends on bad note for Boeing with twin 737-800 disasters on same day](https://telanganatoday.com/year-2024-ends-bad-note-boeing-twin-disasters-striking-737-800-aircraft-same-day)<!-- HN:42539673:end --><!-- HN:42540870:start -->
* [42540870](https://news.social-protocols.org/stats?id=42540870) #14 8 points 0 comments -> [Pirate Party – a political party in Iceland (and in many other countries)](https://en.wikipedia.org/wiki/Pirate_Party_(Iceland))<!-- HN:42540870:end --><!-- HN:42540850:start -->
* [42540850](https://news.social-protocols.org/stats?id=42540850) #4 4 points 0 comments -> [The BBC's Civil War over Gaza](https://www.dropsitenews.com/p/bbc-civil-war-gaza-israel-biased-coverage)<!-- HN:42540850:end --><!-- HN:42541536:start -->
* [42541536](https://news.social-protocols.org/stats?id=42541536) #25 24 points 7 comments -> [Enslaved on OnlyFans: Women describe lives of torment and sexual servitude](https://www.reuters.com/investigates/special-report/onlyfans-sex-trafficking/)<!-- HN:42541536:end --><!-- HN:42540427:start -->
* [42540427](https://news.social-protocols.org/stats?id=42540427) #30 204 points 161 comments -> [China turns members of its diaspora into spies](https://www.economist.com/china/2024/12/26/how-china-turns-members-of-its-diaspora-into-spies)<!-- HN:42540427:end --><!-- HN:42542215:start -->
* [42542215](https://news.social-protocols.org/stats?id=42542215) #4 5 points 1 comments -> [Epoll Is Fundamentally Broken](https://idea.popcount.org/2017-02-20-epoll-is-fundamentally-broken-12/)<!-- HN:42542215:end -->
#### **Monday, December 30, 2024**
<!-- HN:42544923:start -->
* [42544923](https://news.social-protocols.org/stats?id=42544923) #4 11 points 3 comments -> [What ails America and how to fix it? (Jeffrey Sachs)](https://www.jeffsachs.org/newspaper-articles/6gfpzjj9m8phyl5adxg5dp26xc4l2d)<!-- HN:42544923:end --><!-- HN:42545772:start -->
* [42545772](https://news.social-protocols.org/stats?id=42545772) #15 46 points 10 comments -> [Israel built an 'AI factory' for war. It unleashed it in Gaza](https://www.washingtonpost.com/technology/2024/12/29/ai-israel-war-gaza-idf/)<!-- HN:42545772:end --><!-- HN:42550367:start -->
* [42550367](https://news.social-protocols.org/stats?id=42550367) #24 3 points 0 comments -> [Show HN: Learn Japanese Kanji, no silly mnemonics](https://www.kanjideck.com)<!-- HN:42550367:end --><!-- HN:42552741:start -->
* [42552741](https://news.social-protocols.org/stats?id=42552741) #9 3 points 0 comments -> [Enjoy Apple TV+ for free the first weekend of 2025](https://www.apple.com/tv-pr/news/2024/12/get-a-free-all-access-pass-to-apple-tv-the-first-weekend-of-2025/)<!-- HN:42552741:end --><!-- HN:42554088:start -->
* [42554088](https://news.social-protocols.org/stats?id=42554088) #8 4 points 1 comments -> [Is a Dosa a Crepe?](https://datanutrition.org/)<!-- HN:42554088:end --><!-- HN:42519168:start -->
* [42519168](https://news.social-protocols.org/stats?id=42519168) #18 100 points 186 comments -> [Where is James Bond? Trapped in an ugly stalemate with Amazon](https://www.wsj.com/business/media/james-bond-movies-amazon-barbara-broccoli-0b04f0db)<!-- HN:42519168:end -->
#### **Tuesday, December 31, 2024**
<!-- HN:42555040:start -->
* [42555040](https://news.social-protocols.org/stats?id=42555040) #6 5 points 0 comments -> [Former Meta Recruiter Reveals Why You're Struggling to Land a Big Tech Offer](https://techiegamers.com/breaking-into-big-tech/)<!-- HN:42555040:end --><!-- HN:42555590:start -->
* [42555590](https://news.social-protocols.org/stats?id=42555590) #17 3 points 2 comments -> [Show HN: I Made a Dumb Game](https://pizzzza.lol)<!-- HN:42555590:end --><!-- HN:42530620:start -->
* [42530620](https://news.social-protocols.org/stats?id=42530620) #26 21 points 28 comments -> [Monokai Pro for Jetbrains](https://monokai.pro/jetbrains)<!-- HN:42530620:end --><!-- HN:42547367:start -->
* [42547367](https://news.social-protocols.org/stats?id=42547367) #15 11 points 4 comments -> [Letting Language Models Write My Website](https://nicholas.carlini.com/writing/2025/llms-write-my-bio.html)<!-- HN:42547367:end --><!-- HN:42534100:start -->
* [42534100](https://news.social-protocols.org/stats?id=42534100) #24 -> [The most stunning portrait that I have ever seen](https://www.bbc.com/news/articles/cvg7vwlg8rmo)<!-- HN:42534100:end --><!-- HN:42559048:start -->
* [42559048](https://news.social-protocols.org/stats?id=42559048) #2 20 points 40 comments -> [Show HN: Obsess Jobs – Apply to jobs in your sleep](https://obsessjobs.com/)<!-- HN:42559048:end --><!-- HN:42559598:start -->
* [42559598](https://news.social-protocols.org/stats?id=42559598) #2 10 points 9 comments -> [Apple TV+ free first weekend of 2025](https://www.apple.com/tv-pr/news/2024/12/get-a-free-all-access-pass-to-apple-tv-the-first-weekend-of-2025/)<!-- HN:42559598:end --><!-- HN:42558142:start -->
* [42558142](https://news.social-protocols.org/stats?id=42558142) #27 19 points 7 comments -> [The British Empire Was Much Worse Than You Realize](https://www.newyorker.com/magazine/2022/04/04/the-british-empire-was-much-worse-than-you-realize-caroline-elkinss-legacy-of-violence)<!-- HN:42558142:end --><!-- HN:42560933:start -->
* [42560933](https://news.social-protocols.org/stats?id=42560933) #5 17 points 9 comments -> [Show HN: I made a tiny game that helps increase IQ](https://vidzert.com/connect-dots-without-crossing-lines)<!-- HN:42560933:end -->
#### **Wednesday, January 1, 2025**<!-- HN:42565524:start -->
* [42565524](https://news.social-protocols.org/stats?id=42565524) #19 9 points 3 comments -> [At least 10 killed after vehicle hits crowd of people in New Orleans](https://news.sky.com/story/casualties-feared-after-reports-a-vehicle-struck-people-in-new-orleans-13282315)<!-- HN:42565524:end --><!-- HN:42566387:start -->
* [42566387](https://news.social-protocols.org/stats?id=42566387) #21 32 points 40 comments -> [A Legendary Exposé of the Brutality of the Soviet Union](https://www.smithsonianmag.com/smart-news/discover-the-story-behind-a-legendary-expose-of-the-brutality-of-the-soviet-union-180985658/)<!-- HN:42566387:end --><!-- HN:42565442:start -->
* [42565442](https://news.social-protocols.org/stats?id=42565442) #23 15 points 4 comments -> [Should you do a newspaper workout?](https://elsbethvaino.com/2013/05/should-you-do-a-newspaper-workout/)<!-- HN:42565442:end -->
#### **Thursday, January 2, 2025**<!-- HN:42571045:start -->
* [42571045](https://news.social-protocols.org/stats?id=42571045) #12 23 points 40 comments -> [Could the Soviet Union have survived?](https://www.historytoday.com/archive/head-head/could-soviet-union-have-survived)<!-- HN:42571045:end --><!-- HN:42571569:start -->
* [42571569](https://news.social-protocols.org/stats?id=42571569) #19 29 points 15 comments -> [Spirituality Is Secure Attachment with Reality](https://intimatemirror.substack.com/p/spirituality-is-secure-attachment)<!-- HN:42571569:end --><!-- HN:42573214:start -->
* [42573214](https://news.social-protocols.org/stats?id=42573214) #8 6 points 2 comments -> [Show HN: A tool to generate dragon names](https://dragonnamegenerator.net)<!-- HN:42573214:end --><!-- HN:42569236:start -->
* [42569236](https://news.social-protocols.org/stats?id=42569236) #25 320 points 184 comments -> [Rails for everything](https://literallythevoid.com/blog/rails_for_everything.html)<!-- HN:42569236:end --><!-- HN:42573936:start -->
* [42573936](https://news.social-protocols.org/stats?id=42573936) #28 6 points 1 comments -> [Pink Floyd's Young Lust telephone signalling explained](https://telephoneworld.org/landline-telephone-history/pink-floyds-young-lust-explained-and-demystified/)<!-- HN:42573936:end --><!-- HN:42542576:start -->
* [42542576](https://news.social-protocols.org/stats?id=42542576) #22 36 points 54 comments -> [Where are Mr. Beast's early sponsors now?](https://www.preethamrn.com/posts/where-are-mrbeast-sponsors-now)<!-- HN:42542576:end --><!-- HN:42540005:start -->
* [42540005](https://news.social-protocols.org/stats?id=42540005) #17 95 points 21 comments -> [DuPont and "DuPont" connectors, and how to crimp them properly](https://www.mattmillman.com/info/crimpconnectors/dupont-and-dupont-connectors/)<!-- HN:42540005:end --><!-- HN:42574420:start -->
* [42574420](https://news.social-protocols.org/stats?id=42574420) #26 3 points 0 comments -> [Things we think will happen in 2025](https://www.vox.com/future-perfect/392241/2025-new-year-predictions-trump-musk-artificial-intelligence)<!-- HN:42574420:end --><!-- HN:42570138:start -->
* [42570138](https://news.social-protocols.org/stats?id=42570138) #28 106 points 80 comments -> [Are there more trees on Earth than stars in the Milky Way? (2016)](https://www.snopes.com/fact-check/trees-stars-milky-way/)<!-- HN:42570138:end --><!-- HN:42574496:start -->
* [42574496](https://news.social-protocols.org/stats?id=42574496) #25 8 points 0 comments -> [What It's Like to Work for Elon Musk - Genius, Chaos, and Burnout](https://techiegamers.com/the-truth-about-working-for-elon-musk/)<!-- HN:42574496:end --><!-- HN:42574238:start -->
* [42574238](https://news.social-protocols.org/stats?id=42574238) #26 9 points 3 comments -> [US culture breeds 'laziness' and 'mediocrity](https://www.telegraph.co.uk/world-news/2024/12/27/us-culture-breeds-laziness-mediocrity-says-vivek-ramaswamy/)<!-- HN:42574238:end --><!-- HN:42553657:start -->
* [42553657](https://news.social-protocols.org/stats?id=42553657) #13 5 points 1 comments -> [The Upside of the Pentium Bug (1995) [pdf]](https://websrv.cecs.uci.edu/~papers/mpr/MPR/EDITOR/0903ed.pdf)<!-- HN:42553657:end --><!-- HN:42569728:start -->
* [42569728](https://news.social-protocols.org/stats?id=42569728) #23 73 points 2 comments -> [(Amiga) AROS Research Operating System: Summary of 2024](https://arosnews.github.io/aros-x86-summary-2024/)<!-- HN:42569728:end --><!-- HN:42574545:start -->
* [42574545](https://news.social-protocols.org/stats?id=42574545) #26 5 points 0 comments -> [Korean Assembly Speaker's adherence to procedure key to making troops stand down](https://www.aljazeera.com/news/2024/12/27/unlikely-political-thor-emerges-from-south-koreas-martial-law-crisis)<!-- HN:42574545:end --><!-- HN:42571963:start -->
* [42571963](https://news.social-protocols.org/stats?id=42571963) #28 25 points 9 comments -> [How I Use Claude](https://borretti.me/article/how-i-use-claude)<!-- HN:42571963:end --><!-- HN:42574352:start -->
* [42574352](https://news.social-protocols.org/stats?id=42574352) #30 6 points 4 comments -> [Nearly Half of US Unicorns Have Immigrants Founders](https://gfmag.com/capital-raising-corporate-finance/us-unicorns-immigrant-founders/)<!-- HN:42574352:end --><!-- HN:42539700:start -->
* [42539700](https://news.social-protocols.org/stats?id=42539700) #26 132 points 49 comments -> [We fine-tuned Llama and got 4.2x Sonnet 3.5 accuracy for code generation](https://finecodex.com/)<!-- HN:42539700:end --><!-- HN:42540792:start -->
* [42540792](https://news.social-protocols.org/stats?id=42540792) #28 72 points 28 comments -> [What is a second?](https://www.johndcook.com/blog/2024/12/29/what-exactly-is-a-second/)<!-- HN:42540792:end --><!-- HN:42576141:start -->
* [42576141](https://news.social-protocols.org/stats?id=42576141) #16 6 points 1 comments -> [Employees Speak Out: Google, Apple, MS, & Intel Discriminate Against White Men [video]](https://www.youtube.com/watch?v=sdwtMtaIkGM)<!-- HN:42576141:end --><!-- HN:42576001:start -->
* [42576001](https://news.social-protocols.org/stats?id=42576001) #23 6 points 1 comments -> [Palestinian Authority Suspends Al Jazeera TV in West Bank, Citing Incitement](https://www.bbc.com/news/articles/cvgmxzyrmn8o)<!-- HN:42576001:end --><!-- HN:42576090:start -->
* [42576090](https://news.social-protocols.org/stats?id=42576090) #27 8 points 0 comments -> [The Dogs of (Urban) War: Lessons from the IDFs' Specialized Canine Unit](https://mwi.westpoint.edu/the-dogs-of-urban-war-lessons-from-oketz-the-israel-defense-forces-specialized-canine-unit/)<!-- HN:42576090:end --><!-- HN:42547615:start -->
* [42547615](https://news.social-protocols.org/stats?id=42547615) #17 9 points 4 comments -> [Systems Ideas That Sound Good but Almost Never Work – "Let's Just "](https://hardcoresoftware.learningbyshipping.com/p/225-systems-ideas-that-sound-good)<!-- HN:42547615:end -->
#### **Friday, January 3, 2025**
<!-- HN:42582415:start -->
* [42582415](https://news.social-protocols.org/stats?id=42582415) #2 12 points 2 comments -> [FCC's Net Neutrality Rules Struck Down by Sixth Circuit](https://stocks.apple.com/AOtE_yI5dTe6OkLqgYKQ69A)<!-- HN:42582415:end --><!-- HN:42582913:start -->
* [42582913](https://news.social-protocols.org/stats?id=42582913) #13 5 points 3 comments -> [Justine: "I'm over 40 and I'm one of the most active coders in the world"](https://twitter.com/JustineTunney/status/1875041647198879889)<!-- HN:42582913:end --><!-- HN:42581368:start -->
* [42581368](https://news.social-protocols.org/stats?id=42581368) #15 35 points 40 comments -> [Party Squasher, the first guest occupancy counter for homes](https://www.partysquasher.com/)<!-- HN:42581368:end --><!-- HN:42583297:start -->
* [42583297](https://news.social-protocols.org/stats?id=42583297) #7 21 points 6 comments -> [Why Canada Should Join the EU](https://www.economist.com/europe/2025/01/02/why-canada-should-join-the-eu)<!-- HN:42583297:end --><!-- HN:42583485:start -->
* [42583485](https://news.social-protocols.org/stats?id=42583485) #18 17 points 16 comments -> [Mars Exploration: How the CIA's Project Stargate Went to Mars [pdf]](https://www.cia.gov/readingroom/docs/cia-rdp96-00788r001900760001-9.pdf)<!-- HN:42583485:end --><!-- HN:42584900:start -->
* [42584900](https://news.social-protocols.org/stats?id=42584900) #6 30 points 34 comments -> [A free, unlimited online PDF converter with Privacy focus](https://quicklypdf.com)<!-- HN:42584900:end --><!-- HN:42566112:start -->
* [42566112](https://news.social-protocols.org/stats?id=42566112) #14 1244 points 264 comments -> [DOOM CAPTCHA](https://doom-captcha.vercel.app/)<!-- HN:42566112:end --><!-- HN:42585377:start -->
* [42585377](https://news.social-protocols.org/stats?id=42585377) #21 12 points 2 comments -> [Time to check if you ran any of these 33 malicious Chrome extensions](https://arstechnica.com/security/2025/01/dozens-of-backdoored-chrome-extensions-discovered-on-2-6-million-devices/)<!-- HN:42585377:end --><!-- HN:42584599:start -->
* [42584599](https://news.social-protocols.org/stats?id=42584599) #23 6 points 0 comments -> [K/Simple in OCaml](https://git.uwaterloo.ca/lseo/ksimple_ml)<!-- HN:42584599:end -->