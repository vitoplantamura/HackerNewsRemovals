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

#### **Monday, June 29, 2026**
<!-- HN:48712338:start -->
* [48712338](https://news.social-protocols.org/stats?id=48712338) #3 35 points 2 comments -> [A QNX-inspired operating system with selectable kernels](https://qsoe.net)<!-- HN:48712338:end --><!-- HN:48713686:start -->
* [48713686](https://news.social-protocols.org/stats?id=48713686) #5 22 points 13 comments -> [Sophon PFG-1: a monolithic-3D AI ASIC with 330 GB of on-die DRAM and no HBM](https://www.phantafield.com/whitepaper)<!-- HN:48713686:end --><!-- HN:48713887:start -->
* [48713887](https://news.social-protocols.org/stats?id=48713887) #8 68 points 16 comments -> [Tell Congress: Don't Force Age Checks Online](https://act.eff.org/action/tell-congress-don-t-force-age-checks-online)<!-- HN:48713887:end --><!-- HN:48714919:start -->
* [48714919](https://news.social-protocols.org/stats?id=48714919) #4 21 points 4 comments -> [Some Simple Economics of AGI](https://papers.ssrn.com/sol3/papers.cfm?abstract_id=6298838)<!-- HN:48714919:end --><!-- HN:48717573:start -->
* [48717573](https://news.social-protocols.org/stats?id=48717573) #18 4 points 0 comments -> [Children in West Bank are being killed by Israel without accountability](https://www.theguardian.com/world/2026/jun/29/is-it-israels-aim-to-kill-our-children-west-bank-parents-implore-end-to-idfs-child-killings-with-impunity)<!-- HN:48717573:end --><!-- HN:48719665:start -->
* [48719665](https://news.social-protocols.org/stats?id=48719665) #27 54 points 35 comments -> [A field guide to the modern front end for developers who hand-wrote HTML](https://davidpoblador.com/deep-dives/the-descent/)<!-- HN:48719665:end --><!-- HN:48720179:start -->
* [48720179](https://news.social-protocols.org/stats?id=48720179) #10 12 points 3 comments -> [WebGL Without a GPU](https://microlink.io/blog/webgl-without-a-gpu)<!-- HN:48720179:end --><!-- HN:48719483:start -->
* [48719483](https://news.social-protocols.org/stats?id=48719483) #20 12 points 6 comments -> [DocumentDB – a MongoDB compatible open-source database](https://documentdb.io/)<!-- HN:48719483:end --><!-- HN:48720997:start -->
* [48720997](https://news.social-protocols.org/stats?id=48720997) #4 15 points 0 comments -> [Mullvad's co-founder is bankrolling the far right](https://korben.info/en/mullvad-cofounder-funding-far-right.html)<!-- HN:48720997:end --><!-- HN:48721083:start -->
* [48721083](https://news.social-protocols.org/stats?id=48721083) #2 30 points 6 comments -> [Mullvad VPN co-founder donated ~500,000USD to Swedish far-right political party](https://www.flamman.se/techprofil-ger-miljoner-till-orebropartiet/)<!-- HN:48721083:end --><!-- HN:48722366:start -->
* [48722366](https://news.social-protocols.org/stats?id=48722366) #6 12 points 0 comments -> [Mullvad's co-founder is bankrolling the far right](https://korben.info/en/mullvad-cofounder-funding-far-right.html)<!-- HN:48722366:end --><!-- HN:48723276:start -->
* [48723276](https://news.social-protocols.org/stats?id=48723276) #13 17 points 9 comments -> [The 80% Problem: The Last 20% Is Where the Engineer Used to Live](https://www.jonathanbeard.io/blog/2026/06/27/the-80-percent-problem.html)<!-- HN:48723276:end --><!-- HN:48668269:start -->
* [48668269](https://news.social-protocols.org/stats?id=48668269) #17 11 points 6 comments -> [Alternatives to Nested If Function](https://medium.com/@crispomwangi/7-alternatives-to-nested-if-function-a9cb07f3df1e)<!-- HN:48668269:end -->
#### **Tuesday, June 30, 2026**
<!-- HN:48727059:start -->
* [48727059](https://news.social-protocols.org/stats?id=48727059) #17 4 points 3 comments -> [What any website can see about you](https://mysysinfo.com)<!-- HN:48727059:end --><!-- HN:48725359:start -->
* [48725359](https://news.social-protocols.org/stats?id=48725359) #22 29 points 40 comments -> [You really shouldn't copy-paste errors into Claude Code](https://home.robusta.dev/blog/you-really-shouldnt-copy-paste-errors-into-claude-code)<!-- HN:48725359:end --><!-- HN:48727538:start -->
* [48727538](https://news.social-protocols.org/stats?id=48727538) #25 26 points 22 comments -> [Why Won't Europe Build AI Data Centers in Iceland?](https://mrkt30.com/why-wont-europe-build-ai-data-centers-in-iceland/)<!-- HN:48727538:end --><!-- HN:48728442:start -->
* [48728442](https://news.social-protocols.org/stats?id=48728442) #30 10 points 0 comments -> [ICE Tracks Down Woman to Force Her to Delete Instagram Post](https://newrepublic.com/post/212340/ice-poll-worker-election-delete-instagram-post)<!-- HN:48728442:end --><!-- HN:48728441:start -->
* [48728441](https://news.social-protocols.org/stats?id=48728441) #9 -> [300k-Year-Old Cave Site Explored in Northern Israel](https://archaeology.org/news/2026/06/18/300000-year-old-cave-site-explored-in-northern-israel/)<!-- HN:48728441:end --><!-- HN:48729019:start -->
* [48729019](https://news.social-protocols.org/stats?id=48729019) #9 5 points 9 comments -> [Show HN: Bored People Chat – Anonymous global chat room](https://boredpeoplechat.com/)<!-- HN:48729019:end --><!-- HN:48730720:start -->
* [48730720](https://news.social-protocols.org/stats?id=48730720) #6 7 points 8 comments -> [I spent 6 days building my VDOM library as I hated how React handles memo](https://vflash.github.io/Tyaff/)<!-- HN:48730720:end --><!-- HN:48731167:start -->
* [48731167](https://news.social-protocols.org/stats?id=48731167) #25 13 points 2 comments -> [American Pride Falls to 25-Year Record Low](https://news.gallup.com/poll/711938/american-pride-falls-year-record-low.aspx)<!-- HN:48731167:end --><!-- HN:48730922:start -->
* [48730922](https://news.social-protocols.org/stats?id=48730922) #6 17 points 41 comments -> [Should every baby's DNA be sequenced?](https://www.economist.com/science-and-technology/2026/06/29/should-every-babys-dna-be-sequenced)<!-- HN:48730922:end --><!-- HN:48730904:start -->
* [48730904](https://news.social-protocols.org/stats?id=48730904) #6 167 points 58 comments -> [Sony erases digital content from libraries; reminded we don't own what we buy](https://arstechnica.com/gadgets/2026/06/sony-erases-digital-content-from-libraries-were-reminded-we-dont-own-what-we-buy/)<!-- HN:48730904:end --><!-- HN:48732846:start -->
* [48732846](https://news.social-protocols.org/stats?id=48732846) #9 22 points 18 comments -> [Beware, Claude Code deletes &gt;30 day old transcripts. Anthropic won't fix it](https://github.com/anthropics/claude-code/issues/62476)<!-- HN:48732846:end --><!-- HN:48734715:start -->
* [48734715](https://news.social-protocols.org/stats?id=48734715) #25 21 points 41 comments -> [BMW iX5 Blows Away the Competition with 460-KW Charging, 435-Mile Range](https://insideevs.com/news/800125/bmw-ix5-neue-klasse-ev-electric-suv/)<!-- HN:48734715:end --><!-- HN:48737302:start -->
* [48737302](https://news.social-protocols.org/stats?id=48737302) #18 20 points 13 comments -> [Show HN: I made a heatmap of 3400 VCs who are open to cold emails](https://apparent.social/heat-map)<!-- HN:48737302:end --><!-- HN:48737575:start -->
* [48737575](https://news.social-protocols.org/stats?id=48737575) #17 13 points 0 comments -> [AI Is Making Us Lose Our Individuality](https://emmettbuckthompson.com/blog/ai-is-making-us-lose-our-individuality)<!-- HN:48737575:end --><!-- HN:48738413:start -->
* [48738413](https://news.social-protocols.org/stats?id=48738413) #30 15 points 40 comments -> [The best thing that's ever happened for multiplayer games?](https://mas-bandwidth.com/the-best-thing-thats-ever-happened-for-multiplayer-games/)<!-- HN:48738413:end -->
#### **Wednesday, July 1, 2026**
<!-- HN:48740817:start -->
* [48740817](https://news.social-protocols.org/stats?id=48740817) #23 63 points 2 comments -> [Claude Fable 5 export control lifted](https://twitter.com/synthwavedd/status/2072103052635451559)<!-- HN:48740817:end --><!-- HN:48741012:start -->
* [48741012](https://news.social-protocols.org/stats?id=48741012) #1 134 points 33 comments -> [The President Made More Than $1Billon in Crypto Deals](https://www.wsj.com/politics/policy/trump-made-more-than-1-billion-on-crypto-deals-part-of-2025-windfall-ee917d3f)<!-- HN:48741012:end --><!-- HN:48741360:start -->
* [48741360](https://news.social-protocols.org/stats?id=48741360) #28 10 points 6 comments -> [Americans see their country's past, present and future](https://www.economist.com/graphic-detail/2026/06/29/how-americans-see-their-countrys-past-present-and-future)<!-- HN:48741360:end --><!-- HN:48741853:start -->
* [48741853](https://news.social-protocols.org/stats?id=48741853) #27 80 points 21 comments -> [Redeploying Fable 5](https://www.anthropic.com/news/redeploying-fable-5)<!-- HN:48741853:end --><!-- HN:48744232:start -->
* [48744232](https://news.social-protocols.org/stats?id=48744232) #5 333 points 163 comments -> [Single Dose of Frog-Derived Gut Bacterium Eradicates 100% of Tumors in Mice](https://www.thefocalpoints.com/p/new-study-frog-derived-gut-bacterium)<!-- HN:48744232:end --><!-- HN:48747772:start -->
* [48747772](https://news.social-protocols.org/stats?id=48747772) #5 73 points 33 comments -> [The Anti-Palantir Manifesto](https://nym.com/blog/anti-palantir-manifesto)<!-- HN:48747772:end --><!-- HN:48747916:start -->
* [48747916](https://news.social-protocols.org/stats?id=48747916) #2 75 points 2 comments -> [SpudCell: The first synthetic cell with a complete cell cycle](https://biotic.org/research/spudcell/)<!-- HN:48747916:end --><!-- HN:48750661:start -->
* [48750661](https://news.social-protocols.org/stats?id=48750661) #15 16 points 2 comments -> [My OSCP Pentesting Cheatsheet](https://hackerask.com/posts/pentesting-cheatsheet/)<!-- HN:48750661:end --><!-- HN:48751752:start -->
* [48751752](https://news.social-protocols.org/stats?id=48751752) #6 262 points 142 comments -> [ZCode: Claude Code from the Makers of GLM](https://zcode.z.ai/cn)<!-- HN:48751752:end --><!-- HN:48753342:start -->
* [48753342](https://news.social-protocols.org/stats?id=48753342) #22 37 points 15 comments -> [Japan has 41% of the 100-year companies – secrets of 1,447-year survival](https://www.j-times.org/en/media/articles/japan-shinise-1400-years-2026/)<!-- HN:48753342:end --><!-- HN:48754128:start -->
* [48754128](https://news.social-protocols.org/stats?id=48754128) #12 38 points 22 comments -> [US feds are actively hiring "person who decides which models to ban"](https://www.usajobs.gov/job/856265200)<!-- HN:48754128:end -->
#### **Thursday, July 2, 2026**
<!-- HN:48755653:start -->
* [48755653](https://news.social-protocols.org/stats?id=48755653) #13 14 points 3 comments -> [Avoiding Fallback in Distributed Systems](https://builder.aws.com)<!-- HN:48755653:end --><!-- HN:48756038:start -->
* [48756038](https://news.social-protocols.org/stats?id=48756038) #10 11 points 5 comments -> [Show HN: Meow – The 4th and final JavaScript runtime and toolchain](https://meow.style)<!-- HN:48756038:end --><!-- HN:48757500:start -->
* [48757500](https://news.social-protocols.org/stats?id=48757500) #7 13 points 3 comments -> [MarketFish – Simulate a market with 128 AI consumers before you launch](https://github.com/Key-wxh/market-fish)<!-- HN:48757500:end --><!-- HN:48759252:start -->
* [48759252](https://news.social-protocols.org/stats?id=48759252) #7 10 points 5 comments -> [Canadian boy, 11, dies of rabies after waking to bat on his face](https://www.bbc.com/news/articles/c982m1m95q9o)<!-- HN:48759252:end --><!-- HN:48759329:start -->
* [48759329](https://news.social-protocols.org/stats?id=48759329) #9 23 points 42 comments -> [Meta building cloud business to sell excess AI capacity](https://www.reuters.com/business/meta-sell-excess-ai-computing-capacity-via-cloud-business-bloomberg-news-reports-2026-07-01/)<!-- HN:48759329:end --><!-- HN:48760659:start -->
* [48760659](https://news.social-protocols.org/stats?id=48760659) #6 4 points 1 comments -> [Foreign Influence in the Campaign Against American AI](https://www.btcpolicy.org/articles/foreign-influence-campaign-against-american-ai-part-ii-singham-ground-game)<!-- HN:48760659:end --><!-- HN:48761297:start -->
* [48761297](https://news.social-protocols.org/stats?id=48761297) #6 5 points 0 comments -> [An AI board that pre-registers its bets – bet #1 just graded wrong](https://github.com/danilushin/asktheboard)<!-- HN:48761297:end --><!-- HN:48761088:start -->
* [48761088](https://news.social-protocols.org/stats?id=48761088) #4 12 points 14 comments -> [In the age of algorithms and AI, is traditional media democracy's defence?](https://www.martenscentre.eu/media-mentions/in-the-age-of-algorithms-and-ai-is-traditional-media-democracys-last-line-of-defence/)<!-- HN:48761088:end --><!-- HN:48758970:start -->
* [48758970](https://news.social-protocols.org/stats?id=48758970) #18 302 points 206 comments -> [Why I'm Forced to Say Farewell: Google Management Has Lost Its Moral Compass](https://docs.google.com/document/d/1SH9QRTAlL02THgAN2AGmWe9El0_2ZJF6hhgDBx8k97c/edit?tab=t.0)<!-- HN:48758970:end --><!-- HN:48763962:start -->
* [48763962](https://news.social-protocols.org/stats?id=48763962) #5 16 points 2 comments -> [EU Court of Justice allows criminal prosecution for reposting RT videos](https://tass.com/world/2154415)<!-- HN:48763962:end --><!-- HN:48763868:start -->
* [48763868](https://news.social-protocols.org/stats?id=48763868) #12 23 points 16 comments -> [Former Microsoft dev built a 2.5KB Notepad clone](https://theguptalog.blogspot.com/2026/07/former-microsoft-dev-built-25kb-notepad.html)<!-- HN:48763868:end --><!-- HN:48763963:start -->
* [48763963](https://news.social-protocols.org/stats?id=48763963) #26 26 points 18 comments -> [Show HN: QUALITY.md – open format/specification, agent skill, and CLI](https://getquality.md)<!-- HN:48763963:end --><!-- HN:48732250:start -->
* [48732250](https://news.social-protocols.org/stats?id=48732250) #21 9 points 0 comments -> [Too many tables are bad for you](https://www.cybertec-postgresql.com/en/too-many-tables-are-bad/)<!-- HN:48732250:end --><!-- HN:48766630:start -->
* [48766630](https://news.social-protocols.org/stats?id=48766630) #14 3 points 1 comments -> [Rust Is Not a Memory-Safe Language](http://unsoliciteddave.blogspot.com/2026/07/rust-is-not-memory-safe.html)<!-- HN:48766630:end --><!-- HN:48767515:start -->
* [48767515](https://news.social-protocols.org/stats?id=48767515) #22 10 points 7 comments -> [BlastRadar – paste a Git diff, get a production risk score in 10 seconds](https://blastradar.vercel.app/)<!-- HN:48767515:end -->
#### **Friday, July 3, 2026**
<!-- HN:48769110:start -->
* [48769110](https://news.social-protocols.org/stats?id=48769110) #13 18 points 40 comments -> ["An AI Job Apocalypse?" – Goldman Sachs Report [pdf]](https://www.goldmansachs.com/static-libs/pdf-redirect/prod/index.html?path=/pdfs/insights/goldman-sachs-research/an-ai-job-apocalypse/report.pdf&originalQuery=&referrer=)<!-- HN:48769110:end --><!-- HN:48770226:start -->
* [48770226](https://news.social-protocols.org/stats?id=48770226) #12 10 points 6 comments -> [Ask HN: Looking for work, donations, friendship, or advisors](https://cjohnson.io/history)<!-- HN:48770226:end --><!-- HN:48770677:start -->
* [48770677](https://news.social-protocols.org/stats?id=48770677) #10 9 points 0 comments -> [Wasmer: Fast, secure, lightweight containers based on WebAssembly](https://wasmer.io/)<!-- HN:48770677:end --><!-- HN:48770575:start -->
* [48770575](https://news.social-protocols.org/stats?id=48770575) #18 13 points 2 comments -> [Every AI Visibility Tool Is Lying to You](https://canonry.ai/blog/ai-visibility-tools-are-lying)<!-- HN:48770575:end --><!-- HN:48731252:start -->
* [48731252](https://news.social-protocols.org/stats?id=48731252) #11 8 points 14 comments -> [I Type Holes in Keyboard Covers – This One Survived](https://medium.com/@jamesgarside_/i-type-holes-in-keyboard-covers-e5664732ef93)<!-- HN:48731252:end --><!-- HN:48769696:start -->
* [48769696](https://news.social-protocols.org/stats?id=48769696) #24 37 points 43 comments -> [AI is 'not smart' so what's next in artificial intelligence?](https://www.bbc.com/news/articles/cj6gr0xkyr3o)<!-- HN:48769696:end --><!-- HN:48774195:start -->
* [48774195](https://news.social-protocols.org/stats?id=48774195) #17 11 points 4 comments -> [Goodebye Forever Probably: Why I'm leaving developer relations](https://whitep4nth3r.com/blog/goodbye-forever-probably/)<!-- HN:48774195:end --><!-- HN:48778991:start -->
* [48778991](https://news.social-protocols.org/stats?id=48778991) #10 3 points 2 comments -> [The MJ Rathbun case: How an autonomous AI bot cyberbullied a human programmer](https://chatgptdesactualizado.blogspot.com/2026/07/mj-rathbun-chronicles-of-first-bully.html)<!-- HN:48778991:end --><!-- HN:48779565:start -->
* [48779565](https://news.social-protocols.org/stats?id=48779565) #6 3 points 0 comments -> [Doing the Work](https://bran.name/doing-the-work.html)<!-- HN:48779565:end --><!-- HN:48779071:start -->
* [48779071](https://news.social-protocols.org/stats?id=48779071) #21 5 points 3 comments -> [Why Being Overqualified Is a Risk](https://newsletter.bphogan.com/archive/issue-52-run-coding-models-locally-and-why-being/)<!-- HN:48779071:end --><!-- HN:48779321:start -->
* [48779321](https://news.social-protocols.org/stats?id=48779321) #10 20 points 11 comments -> [Oak: Git for Agents](https://oak.space/)<!-- HN:48779321:end --><!-- HN:48780222:start -->
* [48780222](https://news.social-protocols.org/stats?id=48780222) #10 6 points 9 comments -> [Show HN: Updated my landing page with Fable (retro pixel style)](https://www.tryguildly.com/)<!-- HN:48780222:end --><!-- HN:48780128:start -->
* [48780128](https://news.social-protocols.org/stats?id=48780128) #16 22 points 9 comments -> [AI First: How the Federal Government Is Prioritizing AI over People and Planet](https://stopgreedbuildgreen.climateandcommunity.org/posts/ai-first)<!-- HN:48780128:end --><!-- HN:48779415:start -->
* [48779415](https://news.social-protocols.org/stats?id=48779415) #16 34 points 20 comments -> [Pet projects are getting too big to pet](https://www.nnehdi.me/p/pet-projects-are-getting-too-big)<!-- HN:48779415:end --><!-- HN:48780352:start -->
* [48780352](https://news.social-protocols.org/stats?id=48780352) #13 40 points 19 comments -> [Goodbye, Forever, Probably](https://whitep4nth3r.com/blog/goodbye-forever-probably/)<!-- HN:48780352:end --><!-- HN:48780857:start -->
* [48780857](https://news.social-protocols.org/stats?id=48780857) #14 9 points 2 comments -> [Elevating Privileges from Firefox to Android Root](https://rootme.nebusec.ai/)<!-- HN:48780857:end -->
#### **Saturday, July 4, 2026**
<!-- HN:48781865:start -->
* [48781865](https://news.social-protocols.org/stats?id=48781865) #10 7 points 2 comments -> [CueBench for Developers is live: score how well you drive coding agents](https://app.cuebench.dev)<!-- HN:48781865:end --><!-- HN:48783125:start -->
* [48783125](https://news.social-protocols.org/stats?id=48783125) #12 6 points 3 comments -> [Godot bans "vibe-coded" code contributions](https://theguptalog.blogspot.com/2026/07/godot-bans-ai-generated-code.html)<!-- HN:48783125:end --><!-- HN:48785026:start -->
* [48785026](https://news.social-protocols.org/stats?id=48785026) #3 10 points 4 comments -> [Show HN: Foundation, a different approach to software and AI](https://github.com/nmxmxh/foundation)<!-- HN:48785026:end --><!-- HN:48785573:start -->
* [48785573](https://news.social-protocols.org/stats?id=48785573) #15 -> ['All men are created equal': America has lost its values. It's time to go back](https://www.theguardian.com/us-news/ng-interactive/2026/jul/04/250-years-declaration-of-independence)<!-- HN:48785573:end --><!-- HN:48788041:start -->
* [48788041](https://news.social-protocols.org/stats?id=48788041) #15 2 points 0 comments -> [Iredis](https://github.com/laixintao/iredis)<!-- HN:48788041:end --><!-- HN:48765066:start -->
* [48765066](https://news.social-protocols.org/stats?id=48765066) #11 8 points 0 comments -> [At Dog School, children gain a sense of achievement](https://www.csmonitor.com/Perspectives/Making-a-difference/2026/0630/dog-school-south-africa-funda-nenja)<!-- HN:48765066:end -->
#### **Sunday, July 5, 2026**
<!-- HN:48790122:start -->
* [48790122](https://news.social-protocols.org/stats?id=48790122) #23 9 points 6 comments -> [Zo Computer](https://www.zo.computer)<!-- HN:48790122:end --><!-- HN:48789325:start -->
* [48789325](https://news.social-protocols.org/stats?id=48789325) #26 28 points 41 comments -> [My AI-built PHP engine in Rust passes 17% of PHP-src tests, renders WordPress](https://ekinertac.com/blog/i-dont-know-rust-my-ai-is-rewriting-php-in-it/)<!-- HN:48789325:end --><!-- HN:48747762:start -->
* [48747762](https://news.social-protocols.org/stats?id=48747762) #20 30 points 40 comments -> [Can you build a recognizable World Map in under 500 bytes?](https://www.experimentlog.com/blog/building-a-world-map-with-only-500-bytes)<!-- HN:48747762:end --><!-- HN:48791440:start -->
* [48791440](https://news.social-protocols.org/stats?id=48791440) #15 15 points 3 comments -> [Beeg float library, a Rust port of Fabrice Bellard's libbf](https://github.com/lifthrasiir/libbeef)<!-- HN:48791440:end --><!-- HN:48791799:start -->
* [48791799](https://news.social-protocols.org/stats?id=48791799) #15 42 points 40 comments -> [Is The Economist Always Wrong?](https://economist.com/interactive/finance-and-economics/2026/07/02/is-the-economist-always-wrong)<!-- HN:48791799:end --><!-- HN:48760633:start -->
* [48760633](https://news.social-protocols.org/stats?id=48760633) #15 9 points 4 comments -> [The Economy Is K-Shaped](https://moai.studio/blog/posts/economy-is-k-shaped.html)<!-- HN:48760633:end -->