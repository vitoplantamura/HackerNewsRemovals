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

#### **Saturday, May 30, 2026**
<!-- HN:48332889:start -->
* [48332889](https://news.social-protocols.org/stats?id=48332889) #13 10 points 0 comments -> [Records Show UC Sharing Data with US Customs and Border Protection](https://www.dailycal.org/news/uc/records-show-uc-sharing-data-with-us-customs-and-border-protection/article_785ac3ca-9ab2-4ab0-bbb8-07742e62d3d8.html)<!-- HN:48332889:end --><!-- HN:48333177:start -->
* [48333177](https://news.social-protocols.org/stats?id=48333177) #24 6 points 1 comments -> [Company accidentally blows $500M on Claude AI in one month](https://www.msn.com/en-us/news/technology/company-accidentally-blows-500-000-000-on-claude-ai-in-one-month/ar-AA24nahv)<!-- HN:48333177:end --><!-- HN:48282025:start -->
* [48282025](https://news.social-protocols.org/stats?id=48282025) #29 20 points 2 comments -> [Understand Anything – Graphs that teach the codebase](https://understand-anything.com/)<!-- HN:48282025:end --><!-- HN:48336022:start -->
* [48336022](https://news.social-protocols.org/stats?id=48336022) #16 13 points 9 comments -> [Airlines Can't Charge You for What You Wear](https://voyagecoat.com/)<!-- HN:48336022:end --><!-- HN:48288583:start -->
* [48288583](https://news.social-protocols.org/stats?id=48288583) #13 7 points 1 comments -> [Gardeners often hear about supposed hacks and quick fix. Here are some debunked](https://apnews.com/article/gardening-myths-vinegar-tilling-watering-c07faf7472e7a2dc40d3886b94f1b508)<!-- HN:48288583:end --><!-- HN:48335135:start -->
* [48335135](https://news.social-protocols.org/stats?id=48335135) #15 299 points 222 comments -> [Proposed new US funding rules: We can cancel any grant at any time](https://arstechnica.com/science/2026/05/the-office-of-management-and-budget-tries-again-to-cripple-us-science/)<!-- HN:48335135:end --><!-- HN:48338988:start -->
* [48338988](https://news.social-protocols.org/stats?id=48338988) #30 6 points 1 comments -> [Driver, 87, dies after Tesla on Autopilot mode crashes into pond](https://www.usatoday.com/story/news/nation/2026/05/29/tesla-on-autopilot-mode-crashes-into-pond-87-year-old-driver-dies/90319482007/)<!-- HN:48338988:end --><!-- HN:48339576:start -->
* [48339576](https://news.social-protocols.org/stats?id=48339576) #24 48 points 13 comments -> [Thiel moves family to Milei's libertarian Argentina](https://www.ft.com/content/3d7ab893-1842-4c6c-a3d9-26871d79dde4)<!-- HN:48339576:end --><!-- HN:48340025:start -->
* [48340025](https://news.social-protocols.org/stats?id=48340025) #17 6 points 0 comments -> [An OS in pure Rust with its own TCP/IP and TLS 1.3 stack, fetching the live web](https://github.com/rfi-irfos/rusty-penguin)<!-- HN:48340025:end --><!-- HN:48340468:start -->
* [48340468](https://news.social-protocols.org/stats?id=48340468) #6 11 points 1 comments -> [Zerostack v1.3.4 released – Lightweight Unix-inspired coding agent](https://crates.io/crates/zerostack/1.3.4)<!-- HN:48340468:end --><!-- HN:48340528:start -->
* [48340528](https://news.social-protocols.org/stats?id=48340528) #16 9 points 5 comments -> [Kore: Binary File Format Optimized for Modern Data Systems (Open Source)](https://github.com/arunkatherashala/Kore)<!-- HN:48340528:end --><!-- HN:48340944:start -->
* [48340944](https://news.social-protocols.org/stats?id=48340944) #16 -> [Republicans are trying to kill science in this country](https://www.npr.org/2026/05/21/nx-s1-5828768/science-funding-cuts-nih-trump-administration)<!-- HN:48340944:end --><!-- HN:48340958:start -->
* [48340958](https://news.social-protocols.org/stats?id=48340958) #23 6 points 0 comments -> [AWS Budgets Has an 8-Hour Delay. Your Bedrock Bill Doesn't](https://blog.llmcap.io/aws-budgets-has-an-8-hour-delay-your-bedrock-bill-doesn-t)<!-- HN:48340958:end -->
#### **Sunday, May 31, 2026**
<!-- HN:48341505:start -->
* [48341505](https://news.social-protocols.org/stats?id=48341505) #20 8 points 1 comments -> [Custom Errors Are Non-Negotiable in My Rust Applications](https://tristonarmstrong.com/blog/custom-errors-are-non-negotiable-in-my-rust-applications)<!-- HN:48341505:end --><!-- HN:48342097:start -->
* [48342097](https://news.social-protocols.org/stats?id=48342097) #3 39 points 16 comments -> [Anyone can build a platform now. Almost nobody can get people to find it](https://claudefolio.com/blog/anyone-can-build-a-platform-now-almost-nobody-can-get-people-to-find-it)<!-- HN:48342097:end --><!-- HN:48303859:start -->
* [48303859](https://news.social-protocols.org/stats?id=48303859) #23 5 points 0 comments -> [Carbon Nanotube CPU Cooling](https://www.lttlabs.com/articles/2026/05/26/carbice-ice-pads)<!-- HN:48303859:end --><!-- HN:48343061:start -->
* [48343061](https://news.social-protocols.org/stats?id=48343061) #24 11 points 0 comments -> [Building a LangGraph pipeline for production data engineering](https://labyrinthanalyticsconsulting.com/blog/building-first-langgraph-pipeline)<!-- HN:48343061:end --><!-- HN:48343445:start -->
* [48343445](https://news.social-protocols.org/stats?id=48343445) #22 5 points 1 comments -> [The ~500kB NBSDGames 6 managed to be published ahead of GTA 6](https://github.com/abakh/nbsdgames/releases)<!-- HN:48343445:end --><!-- HN:48309623:start -->
* [48309623](https://news.social-protocols.org/stats?id=48309623) #21 10 points 1 comments -> [Soviet 80s supercomputer project "Start"](https://start.iis.nsk.su/)<!-- HN:48309623:end --><!-- HN:48344930:start -->
* [48344930](https://news.social-protocols.org/stats?id=48344930) #6 4 points 1 comments -> [Show HN: The Tired Engineer](https://www.thetiredengineer.com/)<!-- HN:48344930:end --><!-- HN:48345414:start -->
* [48345414](https://news.social-protocols.org/stats?id=48345414) #24 9 points 11 comments -> [Human brains are misaligned, hallucinative, stochastic parrots](https://substack.com/@samuelfitoussi/p-191268395)<!-- HN:48345414:end --><!-- HN:48346697:start -->
* [48346697](https://news.social-protocols.org/stats?id=48346697) #9 17 points 6 comments -> [An Analysis of GrapheneOS's Server Infrastructure](https://write.as/hcbg2iz91vzqh)<!-- HN:48346697:end -->
#### **Monday, June 1, 2026**
<!-- HN:48346947:start -->
* [48346947](https://news.social-protocols.org/stats?id=48346947) #6 506 points 328 comments -> [Creatine raises brain energy levels and slows cognitive decline: study](https://thesciverse.org/scientists-found-that-the-creatine-supplement-millions-take-for-muscle-gains-is-quietly-raising-brain-energy-levels-and-slowing-early-alzheimers-cognitive-decline-by-30/)<!-- HN:48346947:end --><!-- HN:48353670:start -->
* [48353670](https://news.social-protocols.org/stats?id=48353670) #19 24 points 40 comments -> [Dune's Butlerian Jihad and the Future of AI](https://technology.inquirer.net/147084/dunes-butlerian-jihad-and-the-future-of-ai)<!-- HN:48353670:end --><!-- HN:48354405:start -->
* [48354405](https://news.social-protocols.org/stats?id=48354405) #21 25 points 40 comments -> [Why Are Large Language Models So Terrible at Video Games?](https://spectrum.ieee.org/ai-video-games-llms-togelius)<!-- HN:48354405:end --><!-- HN:48301135:start -->
* [48301135](https://news.social-protocols.org/stats?id=48301135) #22 42 points 40 comments -> [Sony Launches Bravia 9 II and Bravia 7 II with 'True RGB'](https://www.flatpanelshd.com/news.php?subaction=showfull&id=1779897602)<!-- HN:48301135:end --><!-- HN:48354414:start -->
* [48354414](https://news.social-protocols.org/stats?id=48354414) #18 21 points 15 comments -> [two strangers. one call. no names](https://just2voices.com/)<!-- HN:48354414:end --><!-- HN:48314719:start -->
* [48314719](https://news.social-protocols.org/stats?id=48314719) #30 44 points 40 comments -> [Two Ways to Draw Infinite Jest's Sierpinski Gasket](https://www.chiply.dev/post-ij-sierpinski)<!-- HN:48314719:end --><!-- HN:48361346:start -->
* [48361346](https://news.social-protocols.org/stats?id=48361346) #4 45 points 16 comments -> [Hackers Used Meta's AI Support Bot to Seize Instagram Accounts](https://krebsonsecurity.com/2026/06/hackers-used-metas-ai-support-bot-to-seize-instagram-accounts/)<!-- HN:48361346:end --><!-- HN:48352627:start -->
* [48352627](https://news.social-protocols.org/stats?id=48352627) #24 92 points 194 comments -> [Surface Laptop Ultra: Made for World Makers](https://blogs.windows.com/devices/2026/05/31/introducing-surface-laptop-ultra-made-for-world-makers/)<!-- HN:48352627:end -->
#### **Tuesday, June 2, 2026**
<!-- HN:48367253:start -->
* [48367253](https://news.social-protocols.org/stats?id=48367253) #9 -> [Cloudflare CDN Pricing 2026: Real Cost per GB, Hidden Fees and Best Alternatives](https://blog.blazingcdn.com/en-us/what-is-the-price-per-gb-of-cloudflare-cdn)<!-- HN:48367253:end --><!-- HN:48367009:start -->
* [48367009](https://news.social-protocols.org/stats?id=48367009) #23 5 points 3 comments -> [Not Every Byte Gets a Vote](https://mitander.xyz/posts/not-every-byte-gets-a-vote/)<!-- HN:48367009:end --><!-- HN:48368456:start -->
* [48368456](https://news.social-protocols.org/stats?id=48368456) #25 6 points 0 comments -> [A Zipper Patent Sat in a Garage for 40 Years. Now It's Real.](https://www.yankodesign.com/2026/05/31/a-zipper-patent-sat-in-a-garage-for-40-years-now-its-real/)<!-- HN:48368456:end --><!-- HN:48357075:start -->
* [48357075](https://news.social-protocols.org/stats?id=48357075) #26 529 points 49 comments -> [CS336: Language Modeling from Scratch](https://cs336.stanford.edu/)<!-- HN:48357075:end --><!-- HN:48371671:start -->
* [48371671](https://news.social-protocols.org/stats?id=48371671) #22 -> ["I was just scammed for $500K by Polymarket."](https://xcancel.com/willo2_Poly/status/2061640812132516321)<!-- HN:48371671:end --><!-- HN:48375544:start -->
* [48375544](https://news.social-protocols.org/stats?id=48375544) #3 55 points 27 comments -> [Uber caps employee AI spending after blowing through budget in four months](https://techcrunch.com/2026/06/02/uber-caps-employee-ai-spending-after-blowing-through-budget-in-four-months/)<!-- HN:48375544:end --><!-- HN:48377014:start -->
* [48377014](https://news.social-protocols.org/stats?id=48377014) #7 -> [I got tired of proprietary supplement blends, so I open-sourced my formulas](https://nuc.luyml.com)<!-- HN:48377014:end -->
#### **Wednesday, June 3, 2026**
<!-- HN:48378099:start -->
* [48378099](https://news.social-protocols.org/stats?id=48378099) #30 60 points 56 comments -> [I Don't Want My Search Engine to Think for Me](https://searchzee.com/blog/search-without-ai-summaries)<!-- HN:48378099:end --><!-- HN:48377631:start -->
* [48377631](https://news.social-protocols.org/stats?id=48377631) #12 49 points 30 comments -> [LLMs are not the black box you were promised](https://www.jay.ai/blog/llms-are-not-a-black-box)<!-- HN:48377631:end --><!-- HN:48378995:start -->
* [48378995](https://news.social-protocols.org/stats?id=48378995) #22 11 points 40 comments -> [Can A.I. Produce Writing That We Want to Read?](https://www.newyorker.com/news/fault-lines/can-ai-produce-writing-that-we-actually-want-to-read)<!-- HN:48378995:end --><!-- HN:48382782:start -->
* [48382782](https://news.social-protocols.org/stats?id=48382782) #4 8 points 3 comments -> [Did Claude Opus 4.8 distill Alibaba's Qwen? Here's what the evidence says](https://blog.kilo.ai/p/did-claude-opus-48-distill-alibabas)<!-- HN:48382782:end --><!-- HN:48341806:start -->
* [48341806](https://news.social-protocols.org/stats?id=48341806) #17 19 points 7 comments -> [OpenRidingController – DIY horse riding controller for the PC](https://github.com/Squalius-cephalus/OpenRidingController)<!-- HN:48341806:end --><!-- HN:48383018:start -->
* [48383018](https://news.social-protocols.org/stats?id=48383018) #7 39 points 41 comments -> [Bun Has Been Converted to Rust. Now What?](https://bytecode.news/posts/2026/06/bun-has-been-converted-to-rust-now-what)<!-- HN:48383018:end --><!-- HN:48383248:start -->
* [48383248](https://news.social-protocols.org/stats?id=48383248) #9 17 points 19 comments -> [Which sparkling water is the best?](https://www.maximevidal.com/sparkling-water)<!-- HN:48383248:end --><!-- HN:48383451:start -->
* [48383451](https://news.social-protocols.org/stats?id=48383451) #13 22 points 8 comments -> [Take Action: LAPD Removed Crime Location Data. Here's Why It Matters](https://blog.spotcrime.com/2026/06/take-action-lapd-removed-crime-location.html)<!-- HN:48383451:end --><!-- HN:48378349:start -->
* [48378349](https://news.social-protocols.org/stats?id=48378349) #23 16 points 3 comments -> [I Found a Bug in Apple's Fsck_hfs](https://medium.com/@kivancgunalp/i-found-a-bug-in-apples-fsck-hfs-here-s-how-i-tracked-it-down-edc782ce5cf9)<!-- HN:48378349:end -->
#### **Thursday, June 4, 2026**<!-- HN:48400544:start -->
* [48400544](https://news.social-protocols.org/stats?id=48400544) #13 7 points 7 comments -> [Show HN: Open Terminal – A Bloomberg Style App for Research](https://tesseractanalytics.ai/)<!-- HN:48400544:end --><!-- HN:48355607:start -->
* [48355607](https://news.social-protocols.org/stats?id=48355607) #18 74 points 71 comments -> [Now Is the Best Time to Be a Duct Tape Engineer](https://derwiki.medium.com/now-is-the-best-time-to-be-a-duct-tape-engineer-eefc1d141c23)<!-- HN:48355607:end --><!-- HN:48402052:start -->
* [48402052](https://news.social-protocols.org/stats?id=48402052) #7 24 points 42 comments -> [Fear and Social Pressure Are 'Overarming' the U.S.](https://home.dartmouth.edu/news/2026/06/how-fear-and-social-pressure-are-overarming-us)<!-- HN:48402052:end --><!-- HN:48404434:start -->
* [48404434](https://news.social-protocols.org/stats?id=48404434) #26 11 points 14 comments -> [Most men lie about how tall they are](https://www.newyorker.com/culture/the-lede/the-men-who-lie-about-their-height)<!-- HN:48404434:end --><!-- HN:48363683:start -->
* [48363683](https://news.social-protocols.org/stats?id=48363683) #15 9 points 1 comments -> [My two light switches got stuck in an infinite echo loop](https://docodethatmatters.com/the-infinite-echo-state-mirror-bug/)<!-- HN:48363683:end -->
#### **Friday, June 5, 2026**
<!-- HN:48406328:start -->
* [48406328](https://news.social-protocols.org/stats?id=48406328) #11 6 points 2 comments -> [Bricks and Minifigs Parts Ways with Franchise Owners](https://bricksandminifigs.com/blog/blog/2026/06/04/bricks-and-minifigs-salem-joshua-johnson-brandon-best-resignation/)<!-- HN:48406328:end --><!-- HN:48407068:start -->
* [48407068](https://news.social-protocols.org/stats?id=48407068) #10 22 points 41 comments -> [What happens if Japan takes in zero immigrants?](https://www.konichivalue.com/p/what-happens-if-japan-takes-in-zero)<!-- HN:48407068:end --><!-- HN:48407753:start -->
* [48407753](https://news.social-protocols.org/stats?id=48407753) #14 35 points 15 comments -> [SpaceX: Flying High on Impunity](https://georgiebc.wordpress.com/2026/06/01/flying-high-on-impunity/)<!-- HN:48407753:end -->