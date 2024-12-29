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

#### **Monday, December 23, 2024**
<!-- HN:42489944:start -->
* [42489944](https://news.social-protocols.org/stats?id=42489944) #3 23 points 8 comments -> [Nostr is public key microblogging that works](https://github.com/nostr-protocol/nips/blob/master/01.md)<!-- HN:42489944:end --><!-- HN:42477226:start -->
* [42477226](https://news.social-protocols.org/stats?id=42477226) #22 6 points 0 comments -> [Piezoelectric Generators](https://www.americanpiezo.com/knowledge-center/piezo-theory/generators/)<!-- HN:42477226:end --><!-- HN:42493868:start -->
* [42493868](https://news.social-protocols.org/stats?id=42493868) #20 6 points 1 comments -> [Palantir and Anduril join forces with tech groups to bid for Pentagon contracts](https://www.ft.com/content/6cfdfe2b-6872-4963-bde8-dc6c43be5093)<!-- HN:42493868:end --><!-- HN:42493664:start -->
* [42493664](https://news.social-protocols.org/stats?id=42493664) #20 28 points 41 comments -> [Coke, PepsiCo Lobby to Keep Sugary Sodas in Food-Stamp Program](https://www.wsj.com/politics/policy/rfk-jr-soda-snap-food-stamps-coke-pepsi-9bd9a872)<!-- HN:42493664:end --><!-- HN:42494809:start -->
* [42494809](https://news.social-protocols.org/stats?id=42494809) #22 28 points 20 comments -> [Good cities can't exist without public order](https://www.noahpinion.blog/p/good-cities-cant-exist-without-public)<!-- HN:42494809:end -->
#### **Tuesday, December 24, 2024**
<!-- HN:42500482:start -->
* [42500482](https://news.social-protocols.org/stats?id=42500482) #16 187 points 88 comments -> [Intel shareholders file case asking ex CEO, CFO to return 3 years of salary](https://www.cfodive.com/news/intel-shareholders-yank-exceo-cfo-compensation-foundry/736193/)<!-- HN:42500482:end --><!-- HN:42494746:start -->
* [42494746](https://news.social-protocols.org/stats?id=42494746) #21 401 points 298 comments -> [Commercial tea bags release microplastics, entering human cells](https://medicalxpress.com/news/2024-12-commercial-tea-bags-millions-microplastics.html)<!-- HN:42494746:end --><!-- HN:42495077:start -->
* [42495077](https://news.social-protocols.org/stats?id=42495077) #23 250 points 36 comments -> [Fogus: Things and Stuff of 2024](https://blog.fogus.me/2024/12/23/the-best-things-and-stuff-of-2024/)<!-- HN:42495077:end --><!-- HN:42502210:start -->
* [42502210](https://news.social-protocols.org/stats?id=42502210) #18 5 points 1 comments -> [7-year-old boy undergoes heart surgery after getting hit by falling drone](https://www.cbsnews.com/news/florida-holiday-show-drone-collision-orlando/)<!-- HN:42502210:end --><!-- HN:42502915:start -->
* [42502915](https://news.social-protocols.org/stats?id=42502915) #3 4 points 0 comments -> [Charlie Munger's wisdom lives on in LLMs](https://bren.blog/charlie-munger-lives-on-in-llms)<!-- HN:42502915:end --><!-- HN:42502768:start -->
* [42502768](https://news.social-protocols.org/stats?id=42502768) #26 5 points 0 comments -> [Return to NSA's Menwith Hill with 60 Minutes (2000)](https://cryptome.org/menwith-mn60.htm)<!-- HN:42502768:end --><!-- HN:42484790:start -->
* [42484790](https://news.social-protocols.org/stats?id=42484790) #17 22 points 23 comments -> [Communal Luxury: The Public Bathhouse](https://solar.lowtechmagazine.com/2024/09/communal-luxury-the-public-bathhouse/)<!-- HN:42484790:end --><!-- HN:42503558:start -->
* [42503558](https://news.social-protocols.org/stats?id=42503558) #15 22 points 24 comments -> [Apple seeks to defend Google's billion-dollar payments in search case](https://www.reuters.com/technology/apple-seeks-defend-googles-billion-dollar-payments-search-case-2024-12-24/)<!-- HN:42503558:end --><!-- HN:42503332:start -->
* [42503332](https://news.social-protocols.org/stats?id=42503332) #2 30 points 1 comments -> [I sensed anxiety and frustration at NeurIPS'24](https://kyunghyuncho.me/i-sensed-anxiety-and-frustration-at-neurips24/)<!-- HN:42503332:end --><!-- HN:42504250:start -->
* [42504250](https://news.social-protocols.org/stats?id=42504250) #9 9 points 1 comments -> [Nobody goes to New York City anymore. It's too crowded](https://www.natesilver.net/p/nobody-goes-to-new-york-city-anymore)<!-- HN:42504250:end --><!-- HN:42485688:start -->
* [42485688](https://news.social-protocols.org/stats?id=42485688) #11 10 points 1 comments -> [Suprnova's Founder Speaks: 20 Years, Many Lessons, and a YouTube Empire](https://torrentfreak.com/suprnovas-founder-speaks-20-years-many-lessons-and-a-youtube-empire-241219/)<!-- HN:42485688:end -->
#### **Wednesday, December 25, 2024**
<!-- HN:42506478:start -->
* [42506478](https://news.social-protocols.org/stats?id=42506478) #21 14 points 1 comments -> [Solar, EVs and a Big Exit from Coal: 2024's Good Climate News](https://www.bloomberg.com/news/articles/2024-12-24/solar-evs-and-a-big-exit-from-coal-2024-s-good-climate-news)<!-- HN:42506478:end --><!-- HN:42506882:start -->
* [42506882](https://news.social-protocols.org/stats?id=42506882) #8 3 points 2 comments -> [Destroy AI](https://ali-alkhatib.com/blog/fuck-up-ai)<!-- HN:42506882:end --><!-- HN:42489600:start -->
* [42489600](https://news.social-protocols.org/stats?id=42489600) #10 57 points 10 comments -> [What Happened to the Largest Tube TV? [video]](https://www.youtube.com/watch?v=JfZxOuc9Qwk)<!-- HN:42489600:end --><!-- HN:42505475:start -->
* [42505475](https://news.social-protocols.org/stats?id=42505475) #23 70 points 36 comments -> [Jujutsu Megamerges and jj Absorb](https://v5.chriskrycho.com/journal/jujutsu-megamerges-and-jj-absorb/)<!-- HN:42505475:end -->
#### **Thursday, December 26, 2024**
<!-- HN:42513907:start -->
* [42513907](https://news.social-protocols.org/stats?id=42513907) #28 34 points 22 comments -> [The Rise of Post-Literate History](https://www.compactmag.com/article/the-rise-of-post-literate-history/)<!-- HN:42513907:end --><!-- HN:42515052:start -->
* [42515052](https://news.social-protocols.org/stats?id=42515052) #16 4 points 1 comments -> [The Dome Paradox: A Loophole in Newton's Laws](https://www.youtube.com/watch?v=EjZB81jCGj4)<!-- HN:42515052:end --><!-- HN:42516874:start -->
* [42516874](https://news.social-protocols.org/stats?id=42516874) #8 18 points 1 comments -> [Tokyo makes 3D data available](https://info.tokyo-digitaltwin.metro.tokyo.lg.jp/3dmodel/)<!-- HN:42516874:end -->
#### **Friday, December 27, 2024**
<!-- HN:42519202:start -->
* [42519202](https://news.social-protocols.org/stats?id=42519202) #27 8 points 6 comments -> [OpenAI is Lehman Brothers: A crash is coming](https://sherwood.news/tech/open-ai-is-lehman-brothers/)<!-- HN:42519202:end --><!-- HN:42519913:start -->
* [42519913](https://news.social-protocols.org/stats?id=42519913) #5 5 points 0 comments -> [Blazed – Rust-based 3D renderer](https://github.com/splurf/blazed-demo)<!-- HN:42519913:end --><!-- HN:42521914:start -->
* [42521914](https://news.social-protocols.org/stats?id=42521914) #2 61 points 18 comments -> [Denmark Offers to Buy USA (2019)](https://www.newyorker.com/humor/borowitz-report/denmark-offers-to-buy-us)<!-- HN:42521914:end --><!-- HN:42521782:start -->
* [42521782](https://news.social-protocols.org/stats?id=42521782) #18 7 points 2 comments -> [From Pen and Paper to an AI Factory: McLaren's F1 Reinvention](https://www.mclaren.com/racing/partners/dell-technologies/how-ai-is-revolutionising-f1-presented-by-dell-technologies/)<!-- HN:42521782:end --><!-- HN:42521545:start -->
* [42521545](https://news.social-protocols.org/stats?id=42521545) #9 -> [Supernovae evidence for foundational change to cosmological models](https://academic.oup.com/mnrasl/article/537/1/L55/7926647)<!-- HN:42521545:end --><!-- HN:42523491:start -->
* [42523491](https://news.social-protocols.org/stats?id=42523491) #4 -> [Show HN: DeepSeek v3 – A 671B parameter AI Language Model](https://deepseekv3.org/)<!-- HN:42523491:end --><!-- HN:42521735:start -->
* [42521735](https://news.social-protocols.org/stats?id=42521735) #26 23 points 7 comments -> [An Evidence-Based Approach to Goal Setting and Behavior Change](https://www.strongerbyscience.com/goal-setting/)<!-- HN:42521735:end --><!-- HN:42523590:start -->
* [42523590](https://news.social-protocols.org/stats?id=42523590) #3 8 points 1 comments -> [Induced Demand Debunked](https://urbanreforminstitute.org/2023/06/induced-demand-debunked/)<!-- HN:42523590:end --><!-- HN:42523934:start -->
* [42523934](https://news.social-protocols.org/stats?id=42523934) #25 49 points 34 comments -> [Matt Mullenweg Asks What Drama to Create in 2025, Community Reacts](https://wptavern.com/matt-mullenweg-asks-what-drama-to-create-in-2025-community-reacts)<!-- HN:42523934:end -->
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
* [42536342](https://news.social-protocols.org/stats?id=42536342) #23 10 points 3 comments -> [Dr. Paul Releases 2024 'Festivus' Report on Government Waste](https://www.hsgac.senate.gov/media/reps/dr-paul-releases-2024-festivus-report-on-government-waste/)<!-- HN:42536342:end --><!-- HN:42537082:start -->
* [42537082](https://news.social-protocols.org/stats?id=42537082) #8 9 points 0 comments -> [Google search hallucinates Encanto 2](https://bsky.app/profile/jasonschreier.bsky.social/post/3leezrzlvrk2m)<!-- HN:42537082:end --><!-- HN:42537790:start -->
* [42537790](https://news.social-protocols.org/stats?id=42537790) #4 4 points 6 comments -> [Show HN: I built a website that explains any difficult concept in seconds](https://www.nodsgy.com/)<!-- HN:42537790:end --><!-- HN:42537829:start -->
* [42537829](https://news.social-protocols.org/stats?id=42537829) #1 26 points 7 comments -> [America in Two Headlines](https://www.kenklippenstein.com/p/america-in-two-headlines)<!-- HN:42537829:end -->