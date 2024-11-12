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

#### **Wednesday, November 6, 2024**
<!-- HN:42056287:start -->
* [42056287](https://news.social-protocols.org/stats?id=42056287) #3 9 points 0 comments -> [All the "Top" USElection tweets on X are scam or fake](https://i.ritzastatic.com/images/514e752c76a44dba9cf11b5e550afb33/x.gif)<!-- HN:42056287:end --><!-- HN:42056756:start -->
* [42056756](https://news.social-protocols.org/stats?id=42056756) #4 5 points 3 comments -> [MOATs Aren't Useful](https://rohan.ga/blog/moats/)<!-- HN:42056756:end --><!-- HN:42057186:start -->
* [42057186](https://news.social-protocols.org/stats?id=42057186) #20 5 points 1 comments -> [Bitcoin breaks above its all-time high of $73,777](https://www.fxstreet.com/cryptocurrencies/news/breaking-bitcoin-breaks-above-its-all-time-high-of-73-777-ahead-of-election-results-202411060312)<!-- HN:42057186:end --><!-- HN:42003087:start -->
* [42003087](https://news.social-protocols.org/stats?id=42003087) #5 20 points 12 comments -> [Why Aren't There B Batteries? (2022)](https://www.thebatterygenie.com/why-arent-there-b-batteries/)<!-- HN:42003087:end --><!-- HN:42057690:start -->
* [42057690](https://news.social-protocols.org/stats?id=42057690) #14 4 points 0 comments -> [Has a president ever won two non-consecutive White House elections?](https://nypost.com/2024/11/06/us-news/has-a-president-ever-won-two-non-consecutive-white-house-elections/)<!-- HN:42057690:end --><!-- HN:42057321:start -->
* [42057321](https://news.social-protocols.org/stats?id=42057321) #11 8 points 1 comments -> [Nintendo Switch successor will have backwards compatibility](https://twitter.com/NintendoCoLtd/status/1853972163033968794)<!-- HN:42057321:end --><!-- HN:42057465:start -->
* [42057465](https://news.social-protocols.org/stats?id=42057465) #14 5 points 2 comments -> [Show HN: Real-time ChatGPT-like data analysis for US Election](https://dashboard.itsverve.com/public)<!-- HN:42057465:end --><!-- HN:42057597:start -->
* [42057597](https://news.social-protocols.org/stats?id=42057597) #4 18 points 6 comments -> [A GitHub repo that curates all the awesome repos](https://github.com/bayandin/awesome-awesomeness)<!-- HN:42057597:end --><!-- HN:42025785:start -->
* [42025785](https://news.social-protocols.org/stats?id=42025785) #20 9 points 3 comments -> [Fact [pdf]](https://ranjitjhala.github.io/static/fact_dsl.pdf)<!-- HN:42025785:end --><!-- HN:42064963:start -->
* [42064963](https://news.social-protocols.org/stats?id=42064963) #29 3 points 2 comments -> ['Double Standards and Hypocrisy': The Dissent at Cisco over the War in Gaza](https://www.wired.com/story/cisco-dissent-gaza-israel-war/)<!-- HN:42064963:end --><!-- HN:42066129:start -->
* [42066129](https://news.social-protocols.org/stats?id=42066129) #24 5 points 1 comments -> [The Manosphere Won](https://www.wired.com/story/donald-trump-manosphere-won/)<!-- HN:42066129:end --><!-- HN:42066341:start -->
* [42066341](https://news.social-protocols.org/stats?id=42066341) #25 12 points 3 comments -> [Politicians are Jungian symbols, policies are facades](https://ofthetwodreams.substack.com/p/humans-live-and-die-by-their-myths)<!-- HN:42066341:end --><!-- HN:42069306:start -->
* [42069306](https://news.social-protocols.org/stats?id=42069306) #30 10 points 0 comments -> [German Government Collapses](https://www.euronews.com/my-europe/2024/11/06/german-coalition-government-collapses-chancellor-scholz-fires-finance-minister-lindner)<!-- HN:42069306:end --><!-- HN:42070007:start -->
* [42070007](https://news.social-protocols.org/stats?id=42070007) #3 9 points 0 comments -> [And now we see what is possible](https://geohot.github.io//blog/jekyll/update/2024/11/06/what-is-possible.html)<!-- HN:42070007:end -->
#### **Thursday, November 7, 2024**
<!-- HN:42072346:start -->
* [42072346](https://news.social-protocols.org/stats?id=42072346) #21 7 points 1 comments -> [Threads Bans Anyone for Mentioning Hitler, Even to Criticize](https://www.techdirt.com/2024/11/01/threads-bans-anyone-for-mentioning-hitler-even-to-criticize/)<!-- HN:42072346:end --><!-- HN:42073181:start -->
* [42073181](https://news.social-protocols.org/stats?id=42073181) #23 4 points 0 comments -> [Palestinians will not be allowed to return to homes in northern Gaza, says IDF](https://www.theguardian.com/world/2024/nov/06/palestinians-will-not-be-allowed-to-return-to-homes-in-northern-gaza-says-idf)<!-- HN:42073181:end --><!-- HN:42030915:start -->
* [42030915](https://news.social-protocols.org/stats?id=42030915) #24 7 points 0 comments -> [Listening in on the Mysterious Marbled Murrelet](https://hakaimagazine.com/news/listening-in-on-the-mysterious-marbled-murrelet/)<!-- HN:42030915:end --><!-- HN:42075387:start -->
* [42075387](https://news.social-protocols.org/stats?id=42075387) #15 9 points 4 comments -> [The Deterioration of Google](https://www.baldurbjarnason.com/2024/the-deterioration-of-google/)<!-- HN:42075387:end --><!-- HN:42074721:start -->
* [42074721](https://news.social-protocols.org/stats?id=42074721) #20 7 points 2 comments -> [WP Engine Tracker](https://wordpressenginetracker.com/)<!-- HN:42074721:end --><!-- HN:42069246:start -->
* [42069246](https://news.social-protocols.org/stats?id=42069246) #21 55 points 34 comments -> [Man spent $2M to find new largest prime number](https://www.popsci.com/science/largest-prime-number/)<!-- HN:42069246:end --><!-- HN:42075325:start -->
* [42075325](https://news.social-protocols.org/stats?id=42075325) #14 6 points 0 comments -> [What if everyone pointed a laser pointer at the moon? [video]](https://www.youtube.com/watch?v=JqFSGkFPipM)<!-- HN:42075325:end --><!-- HN:42074845:start -->
* [42074845](https://news.social-protocols.org/stats?id=42074845) #28 14 points 0 comments -> [Job leaving rituals in the WFH era](https://shkspr.mobi/blog/2022/11/job-leaving-rituals-in-the-wfh-era/)<!-- HN:42074845:end --><!-- HN:42004228:start -->
* [42004228](https://news.social-protocols.org/stats?id=42004228) #30 4 points 1 comments -> [Kliktopia Archive](https://kliktopia.org)<!-- HN:42004228:end --><!-- HN:42080974:start -->
* [42080974](https://news.social-protocols.org/stats?id=42080974) #16 19 points 26 comments -> [Top Billionaires make nearly $64B in post-Trump election stock surge](https://www.theregister.com/2024/11/07/top_10_billionaires/)<!-- HN:42080974:end --><!-- HN:42082119:start -->
* [42082119](https://news.social-protocols.org/stats?id=42082119) #8 7 points 1 comments -> [How to Solve It with Code](https://www.answer.ai/posts/2024-11-07-solveit.html)<!-- HN:42082119:end -->
#### **Friday, November 8, 2024**
<!-- HN:42083630:start -->
* [42083630](https://news.social-protocols.org/stats?id=42083630) #19 26 points 2 comments -> [Kagi Translate](https://translate.kagi.com/)<!-- HN:42083630:end --><!-- HN:42084571:start -->
* [42084571](https://news.social-protocols.org/stats?id=42084571) #11 29 points 40 comments -> [There's Almost No Gitlab](https://julien.danjou.info/p/theres-almost-no-gitlab)<!-- HN:42084571:end --><!-- HN:42084369:start -->
* [42084369](https://news.social-protocols.org/stats?id=42084369) #16 10 points 1 comments -> [Corinthian Bronze](https://en.wikipedia.org/wiki/Corinthian_bronze)<!-- HN:42084369:end --><!-- HN:42082498:start -->
* [42082498](https://news.social-protocols.org/stats?id=42082498) #21 54 points 37 comments -> [Wild Ball](https://r3f-drei-rapier.surge.sh)<!-- HN:42082498:end --><!-- HN:42083559:start -->
* [42083559](https://news.social-protocols.org/stats?id=42083559) #14 286 points 198 comments -> [After decades, FDA moves to pull ineffective decongestant off shelves](https://arstechnica.com/health/2024/11/fda-proposes-ditching-common-decongestant-for-being-completely-useless/)<!-- HN:42083559:end --><!-- HN:42086795:start -->
* [42086795](https://news.social-protocols.org/stats?id=42086795) #5 11 points 1 comments -> [Show HN: Motherfuckingrssreader.com](https://motherfuckingrssreader.com/)<!-- HN:42086795:end --><!-- HN:42087346:start -->
* [42087346](https://news.social-protocols.org/stats?id=42087346) #20 58 points 27 comments -> [TSMC will stop making 7 nm chips for Chinese customers](https://arstechnica.com/tech-policy/2024/11/tsmc-will-stop-making-7-nm-chips-for-chinese-customers/)<!-- HN:42087346:end --><!-- HN:42087478:start -->
* [42087478](https://news.social-protocols.org/stats?id=42087478) #22 38 points 2 comments -> [Man sick of crashes sues Intel for allegedly hiding CPU defects](https://arstechnica.com/tech-policy/2024/11/man-sick-of-crashes-sues-intel-for-allegedly-hiding-cpu-defects/)<!-- HN:42087478:end --><!-- HN:42088024:start -->
* [42088024](https://news.social-protocols.org/stats?id=42088024) #23 6 points 2 comments -> [How Much Porn Are We Watching? A Lot](https://thewalrus.ca/when-porn-becomes-communal/)<!-- HN:42088024:end --><!-- HN:42087811:start -->
* [42087811](https://news.social-protocols.org/stats?id=42087811) #26 26 points 15 comments -> [It feels like 2004 again](https://www.anildash.com//2024/10/15/its-2004-again/)<!-- HN:42087811:end --><!-- HN:42089883:start -->
* [42089883](https://news.social-protocols.org/stats?id=42089883) #24 -> [I wonder how much Cook dithered over that cheerful-looking exclamation mark](https://daringfireball.net/2024/11/i_wonder)<!-- HN:42089883:end --><!-- HN:42090306:start -->
* [42090306](https://news.social-protocols.org/stats?id=42090306) #15 7 points 0 comments -> [Nearly 70% of Gaza war dead are women and children, UN says](https://www.bbc.com/news/articles/cn5wel11pgdo)<!-- HN:42090306:end --><!-- HN:42090696:start -->
* [42090696](https://news.social-protocols.org/stats?id=42090696) #28 4 points 1 comments -> [Dutch king says his nation failed Jewish community during football fan attacks](https://www.independent.co.uk/news/world/europe/amsterdam-israel-football-ajax-maccabi-attacks-king-netherlands-b2643792.html)<!-- HN:42090696:end -->
#### **Saturday, November 9, 2024**
<!-- HN:42091181:start -->
* [42091181](https://news.social-protocols.org/stats?id=42091181) #24 4 points 2 comments -> [Maelstrom: High-Performance Matrix Home-Server Written in Rust](https://github.com/maelstrom-rs/maelstrom)<!-- HN:42091181:end --><!-- HN:42090568:start -->
* [42090568](https://news.social-protocols.org/stats?id=42090568) #29 27 points 6 comments -> [What does a scientist look like? Children drawing women more than ever before](https://www.science.org/content/article/what-does-scientist-look-children-are-drawing-women-more-ever)<!-- HN:42090568:end --><!-- HN:42094180:start -->
* [42094180](https://news.social-protocols.org/stats?id=42094180) #17 7 points 1 comments -> [The Retraction Watch Hijacked Journal Checker](https://retractionwatch.com/the-retraction-watch-hijacked-journal-checker/)<!-- HN:42094180:end --><!-- HN:42008891:start -->
* [42008891](https://news.social-protocols.org/stats?id=42008891) #16 112 points 24 comments -> ['Smart' insulin prevents diabetic highs – and deadly lows](https://www.nature.com/articles/d41586-024-03357-7#ref-CR1)<!-- HN:42008891:end --><!-- HN:42095390:start -->
* [42095390](https://news.social-protocols.org/stats?id=42095390) #13 11 points 0 comments -> [Average rate on a 30-year mortgage in the US rises for 6th straight week](https://apnews.com/article/mortgage-rates-housing-interest-financing-home-loan-36992be9d7760237baef95ca2c160f9a)<!-- HN:42095390:end --><!-- HN:42095362:start -->
* [42095362](https://news.social-protocols.org/stats?id=42095362) #22 12 points 5 comments -> [Australia to ban under-16s from social media – but can't say how TikTok](https://www.theguardian.com/australia-news/2024/nov/07/australian-government-to-legislate-social-media-age-limit-of-16-but-cant-say-how-platforms-will-enforce-it)<!-- HN:42095362:end --><!-- HN:42095319:start -->
* [42095319](https://news.social-protocols.org/stats?id=42095319) #26 14 points 0 comments -> [A brief history of privacy protection on Macs](https://eclecticlight.co/2024/11/09/a-brief-history-of-privacy-protection-on-macs/)<!-- HN:42095319:end --><!-- HN:42070807:start -->
* [42070807](https://news.social-protocols.org/stats?id=42070807) #19 56 points 14 comments -> [Writing Tiny Desktop Apps in C and GTK3 (2022)](https://danielc.dev/blog/tiny-windows-linux-gtk-apps/)<!-- HN:42070807:end --><!-- HN:42096208:start -->
* [42096208](https://news.social-protocols.org/stats?id=42096208) #24 3 points 0 comments -> [DNA firm [Atlas Biomed] holding highly sensitive data 'vanishes' without warning](https://www.bbc.co.uk/news/articles/cz7wl7rpndjo)<!-- HN:42096208:end --><!-- HN:42073406:start -->
* [42073406](https://news.social-protocols.org/stats?id=42073406) #21 5 points 0 comments -> [Calculating at Pencil and Paper Scale](https://win-vector.com/2024/11/06/calculating-at-pencil-and-paper-scale/)<!-- HN:42073406:end -->
#### **Sunday, November 10, 2024**
<!-- HN:42097086:start -->
* [42097086](https://news.social-protocols.org/stats?id=42097086) #17 23 points 18 comments -> [Om Malik – With AI, the Future of Augmented Reality Is in Your Ears](https://crazystupidtech.com/archive/with-ai-the-future-of-augmented-reality-is-in/)<!-- HN:42097086:end --><!-- HN:42047530:start -->
* [42047530](https://news.social-protocols.org/stats?id=42047530) #16 4 points 0 comments -> [How to Salt Water Test a Dice](https://thecriticaldice.com/blogs/news/how-to-salt-water-test-your-dice)<!-- HN:42047530:end --><!-- HN:42099472:start -->
* [42099472](https://news.social-protocols.org/stats?id=42099472) #28 8 points 1 comments -> [Ousterhout's Dichotomy](https://en.wikipedia.org/wiki/Ousterhout%27s_dichotomy)<!-- HN:42099472:end --><!-- HN:42029880:start -->
* [42029880](https://news.social-protocols.org/stats?id=42029880) #21 8 points 0 comments -> [The Little Brass Box Company](https://www.littlebrassbox.com)<!-- HN:42029880:end --><!-- HN:42101091:start -->
* [42101091](https://news.social-protocols.org/stats?id=42101091) #3 7 points 3 comments -> [Meta's Threads is 'overrun' with liberal election fraud conspiracies](https://www.usermag.co/p/metas-threads-overrun-with-liberal-election-fraud-conspiracies)<!-- HN:42101091:end --><!-- HN:42101248:start -->
* [42101248](https://news.social-protocols.org/stats?id=42101248) #23 11 points 19 comments -> [Tuberculosis is rising in the U.S. again. How did we get here?](https://www.nationalgeographic.com/science/article/us-tuberculosis-tb-rates-rising)<!-- HN:42101248:end --><!-- HN:42101338:start -->
* [42101338](https://news.social-protocols.org/stats?id=42101338) #12 5 points 0 comments -> [Hacking National Bank of the Kyrgyz Republic](https://filetransfer.io/data-package/ZOusTwRr#link)<!-- HN:42101338:end --><!-- HN:42099769:start -->
* [42099769](https://news.social-protocols.org/stats?id=42099769) #10 21 points 18 comments -> [M4 and M4 Pro Mac minis are probably Apple's best Mac minis](https://arstechnica.com/apple/2024/11/review-m4-and-m4-pro-mac-minis-are-probably-apples-best-mac-minis-ever/)<!-- HN:42099769:end --><!-- HN:42101705:start -->
* [42101705](https://news.social-protocols.org/stats?id=42101705) #11 9 points 5 comments -> [Ruby might be better than Python for new learners](https://ronynn.github.io/ruby-might-be-better-than-python/)<!-- HN:42101705:end --><!-- HN:42101890:start -->
* [42101890](https://news.social-protocols.org/stats?id=42101890) #14 14 points 7 comments -> [A Lunar Space Elevator Could Be Built for $2B [pdf]](https://www.hou.usra.edu/meetings/newviews2018/pdf/6016.pdf)<!-- HN:42101890:end --><!-- HN:42102034:start -->
* [42102034](https://news.social-protocols.org/stats?id=42102034) #11 33 points 21 comments -> [The Rust Trademark Policy is still harmful](https://purplesyringa.moe/blog/the-rust-trademark-policy-is-still-harmful/)<!-- HN:42102034:end -->
#### **Monday, November 11, 2024**<!-- HN:42104374:start -->
* [42104374](https://news.social-protocols.org/stats?id=42104374) #2 14 points 0 comments -> [The mirror of fascism in big tech](https://deadsimpletech.com/blog/fascism_mirror)<!-- HN:42104374:end --><!-- HN:42103910:start -->
* [42103910](https://news.social-protocols.org/stats?id=42103910) #7 15 points 15 comments -> [Who Would Support Deploying the Military to Domestic Protests?](https://www.lawfaremedia.org/article/who-would-support-deploying-the-military-to-domestic-protests)<!-- HN:42103910:end --><!-- HN:42105398:start -->
* [42105398](https://news.social-protocols.org/stats?id=42105398) #27 11 points 0 comments -> [Australian scientists thought to be on the verge of curing paralysis](https://www.9news.com.au/national/spinal-cord-research-trials-using-nerve-cells-from-nose-to-treat-paralysis-queensland-griffith-university/a90c494b-1042-4ab3-b631-67e9d565ceb2)<!-- HN:42105398:end --><!-- HN:42104762:start -->
* [42104762](https://news.social-protocols.org/stats?id=42104762) #12 211 points 80 comments -> [Apple threatened workers over their talk about pay and remote work, feds charge](https://www.mercurynews.com/2024/11/06/apple-threatened-workers-over-talk-about-pay-remote-work-feds-charge/)<!-- HN:42104762:end --><!-- HN:42100876:start -->
* [42100876](https://news.social-protocols.org/stats?id=42100876) #15 220 points 64 comments -> [JVM Anatomy Quarks](https://shipilev.net/jvm/anatomy-quarks/)<!-- HN:42100876:end --><!-- HN:42103761:start -->
* [42103761](https://news.social-protocols.org/stats?id=42103761) #18 136 points 188 comments -> [Standing Desk Might Be as Bad as Sitting All Day](https://www.sciencealert.com/your-standing-desk-might-actually-be-as-bad-as-sitting-all-day)<!-- HN:42103761:end --><!-- HN:42105508:start -->
* [42105508](https://news.social-protocols.org/stats?id=42105508) #18 40 points 15 comments -> [Mattel apologises after Wicked movie dolls link to porn site on packaging](https://www.theguardian.com/film/2024/nov/11/mattel-apologises-after-mistakenly-linking-to-porn-website-on-wicked-dolls)<!-- HN:42105508:end --><!-- HN:42105835:start -->
* [42105835](https://news.social-protocols.org/stats?id=42105835) #19 23 points 4 comments -> [Inside M4 chips: P cores](https://eclecticlight.co/2024/11/11/inside-m4-chips-p-cores/)<!-- HN:42105835:end --><!-- HN:42106724:start -->
* [42106724](https://news.social-protocols.org/stats?id=42106724) #18 -> ["The Hatpin Peril" Terrorized Men Who Couldn't Handle the 20th-Century Woman](https://www.smithsonianmag.com/history/hatpin-peril-terrorized-men-who-couldnt-handle-20th-century-woman-180951219/)<!-- HN:42106724:end --><!-- HN:42106504:start -->
* [42106504](https://news.social-protocols.org/stats?id=42106504) #25 7 points 0 comments -> [A sit-down with Ubuntu founder Mark 'SABDFL' Shuttleworth](https://www.theregister.com/2024/11/11/mark_shuttleworth_ubuntu_interview/)<!-- HN:42106504:end --><!-- HN:42107120:start -->
* [42107120](https://news.social-protocols.org/stats?id=42107120) #13 20 points 8 comments -> [Memecoins Are the Point](http://jpkoning.blogspot.com/2024/10/memecoins-are-point.html)<!-- HN:42107120:end --><!-- HN:42107157:start -->
* [42107157](https://news.social-protocols.org/stats?id=42107157) #5 67 points 2 comments -> [AI protein-prediction tool AlphaFold3 is now open source](https://www.nature.com/articles/d41586-024-03708-4)<!-- HN:42107157:end --><!-- HN:42107966:start -->
* [42107966](https://news.social-protocols.org/stats?id=42107966) #25 3 points 0 comments -> [Traditional Japanese Salted Aged Salmon Recipe for 1,000 Years [video]](https://www.youtube.com/watch?v=DLaaqv1Tykg)<!-- HN:42107966:end --><!-- HN:42108247:start -->
* [42108247](https://news.social-protocols.org/stats?id=42108247) #24 4 points 0 comments -> [Tariffs Won't Work, Just as McKinley's Didn't](https://www.bloomberg.com/opinion/articles/2024-11-08/trump-s-tariffs-won-t-work-just-as-mckinley-s-didn-t)<!-- HN:42108247:end --><!-- HN:42030233:start -->
* [42030233](https://news.social-protocols.org/stats?id=42030233) #18 12 points 1 comments -> [Data movement bottlenecks to large-scale model training: Scaling past 1e28 FLOP](https://epochai.org/blog/data-movement-bottlenecks-scaling-past-1e28-flop)<!-- HN:42030233:end --><!-- HN:42109712:start -->
* [42109712](https://news.social-protocols.org/stats?id=42109712) #24 13 points 4 comments -> [LICENSE.TXT [video]](https://www.youtube.com/watch?v=CUleKnUUaGI)<!-- HN:42109712:end --><!-- HN:42110357:start -->
* [42110357](https://news.social-protocols.org/stats?id=42110357) #29 6 points 0 comments -> [Foundry worker puts wet scrap metal into furnace](https://www.youtube.com/watch?v=oWSHEC1N770)<!-- HN:42110357:end -->
#### **Tuesday, November 12, 2024**
<!-- HN:42111551:start -->
* [42111551](https://news.social-protocols.org/stats?id=42111551) #9 5 points 2 comments -> [Higher maternal mortality rates in states with more abortion restrictions](https://sph.tulane.edu/study-finds-higher-maternal-mortality-rates-states-more-abortion-restrictions)<!-- HN:42111551:end -->