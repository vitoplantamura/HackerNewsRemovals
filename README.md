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

#### **Monday, November 17, 2025**
<!-- HN:45950766:start -->
* [45950766](https://news.social-protocols.org/stats?id=45950766) #1 7 points 2 comments -> [The Shutdown of Usa.i.d. Has Killed Thousands](https://www.newyorker.com/culture/the-new-yorker-documentary/the-shutdown-of-usaid-has-already-killed-hundreds-of-thousands)<!-- HN:45950766:end --><!-- HN:45876574:start -->
* [45876574](https://news.social-protocols.org/stats?id=45876574) #30 18 points 1 comments -> [Help My LocalDate Isn't Flattened](https://horstmann.com/unblog/2025-11-08/index.html)<!-- HN:45876574:end --><!-- HN:45952737:start -->
* [45952737](https://news.social-protocols.org/stats?id=45952737) #26 17 points 12 comments -> [Drone footage shows scale of revolting 60M-long mountain of waste next to river](https://news.sky.com/story/kidlington-fly-tipping-drone-footage-shows-scale-of-revolting-60m-long-mountain-of-waste-next-to-river-13471314)<!-- HN:45952737:end --><!-- HN:45953198:start -->
* [45953198](https://news.social-protocols.org/stats?id=45953198) #11 13 points 7 comments -> [Peter Thiel has sold his stake in Nvidia](https://www.techinasia.com/news/peter-thiel-sells-entire-nvidia-stake-despite-ai-bubble-fears)<!-- HN:45953198:end --><!-- HN:45953072:start -->
* [45953072](https://news.social-protocols.org/stats?id=45953072) #25 6 points 2 comments -> ["Two US Marines implicated" in killing family in notorious Iraq war shooting](https://www.bbc.co.uk/news/articles/c2emyz0zpxko)<!-- HN:45953072:end --><!-- HN:45955948:start -->
* [45955948](https://news.social-protocols.org/stats?id=45955948) #9 5 points 2 comments -> [Every log must fire: applying Chekhov's gun to cybersecurity incident reports](https://andreafortuna.org/2025/11/17/chekhovs-gun-and-cybersecurity-incident-reports)<!-- HN:45955948:end --><!-- HN:45820782:start -->
* [45820782](https://news.social-protocols.org/stats?id=45820782) #4 52 points 35 comments -> [WebTransport is almost here to allow UDP-like exchange in the browser](https://developer.mozilla.org/en-US/docs/Web/API/WebTransport_API)<!-- HN:45820782:end --><!-- HN:45864768:start -->
* [45864768](https://news.social-protocols.org/stats?id=45864768) #9 23 points 5 comments -> [There Has to Be a Better Way to Make Titanium](https://www.orcasciences.com/articles/there-has-to-be-a-better-way-to-make-titanium)<!-- HN:45864768:end --><!-- HN:45796932:start -->
* [45796932](https://news.social-protocols.org/stats?id=45796932) #15 75 points 17 comments -> [Celtic Code: Drawing Knots with Python](https://2earth.github.io/website/20250202.html)<!-- HN:45796932:end --><!-- HN:45958509:start -->
* [45958509](https://news.social-protocols.org/stats?id=45958509) #24 4 points 0 comments -> [Color Palette Pro](https://colorpalette.pro/)<!-- HN:45958509:end -->
#### **Tuesday, November 18, 2025**
<!-- HN:45961819:start -->
* [45961819](https://news.social-protocols.org/stats?id=45961819) #3 10 points 1 comments -> [Chris Simpkins (designer of the Roboto font) has passed away](https://typedrawers.com/discussion/5403/chris-simpkins-has-passed-away)<!-- HN:45961819:end --><!-- HN:45963156:start -->
* [45963156](https://news.social-protocols.org/stats?id=45963156) #20 6 points 0 comments -> [Trump, 79, Has Dementia Just Like His Father: Niece](https://vechron.com/2025/11/trump-has-dementia-just-like-his-father-says-niece/)<!-- HN:45963156:end --><!-- HN:45963949:start -->
* [45963949](https://news.social-protocols.org/stats?id=45963949) #1 293 points 142 comments -> [Cloudflare Global Network experiencing issues](https://www.cloudflarestatus.com/incidents/8gmgl950y3h7)<!-- HN:45963949:end --><!-- HN:45964409:start -->
* [45964409](https://news.social-protocols.org/stats?id=45964409) #15 5 points 0 comments -> [Cloudflare Outage 2025: What Website Owners Need to Know](https://veerhost.com/cloudflare-outage-2025-what-website-owners-need-to-know/)<!-- HN:45964409:end --><!-- HN:45968043:start -->
* [45968043](https://news.social-protocols.org/stats?id=45968043) #2 353 points 1 comments -> [Gemini 3 for developers: New reasoning, agentic capabilities](https://blog.google/technology/developers/gemini-3-developers/)<!-- HN:45968043:end --><!-- HN:45967999:start -->
* [45967999](https://news.social-protocols.org/stats?id=45967999) #7 336 points 1 comments -> [Gemini 3](https://blog.google/products/gemini/gemini-3/)<!-- HN:45967999:end --><!-- HN:45968091:start -->
* [45968091](https://news.social-protocols.org/stats?id=45968091) #6 79 points 6 comments -> [Google Brings Gemini 3 AI Model to Search and AI Mode](https://blog.google/products/search/gemini-3-search-ai-mode/)<!-- HN:45968091:end --><!-- HN:45969009:start -->
* [45969009](https://news.social-protocols.org/stats?id=45969009) #14 7 points 3 comments -> [Google internal SSO: Sign into corp intranet](https://login.corp.google.com/)<!-- HN:45969009:end --><!-- HN:45968065:start -->
* [45968065](https://news.social-protocols.org/stats?id=45968065) #18 189 points 3 comments -> [Google Antigravity, a New Era in AI-Assisted Software Development](https://antigravity.google/blog/introducing-google-antigravity)<!-- HN:45968065:end --><!-- HN:45971456:start -->
* [45971456](https://news.social-protocols.org/stats?id=45971456) #9 -> [Jerry Seinfeld and the "too sensitive" left](https://reedybear.bearblog.dev/jerry-seinfeld-and-the-too-sensitive-left/)<!-- HN:45971456:end --><!-- HN:45969581:start -->
* [45969581](https://news.social-protocols.org/stats?id=45969581) #24 71 points 2 comments -> [Google CEO: If an AI bubble pops, no one is getting out clean](https://arstechnica.com/ai/2025/11/googles-sundar-pichai-warns-of-irrationality-in-trillion-dollar-ai-investment-boom/)<!-- HN:45969581:end --><!-- HN:45963836:start -->
* [45963836](https://news.social-protocols.org/stats?id=45963836) #18 425 points 2 comments -> [Gemini 3 Pro Model Card](https://pixeldrain.com/u/hwgaNKeH)<!-- HN:45963836:end -->
#### **Wednesday, November 19, 2025**
<!-- HN:45973648:start -->
* [45973648](https://news.social-protocols.org/stats?id=45973648) #9 39 points 124 comments -> [Ford can't find mechanics for $120K: It takes math to learn a trade](https://www.joannejacobs.com/post/ford-can-t-find-mechanics-for-120k-it-takes-math-to-learn-a-trade)<!-- HN:45973648:end --><!-- HN:45979228:start -->
* [45979228](https://news.social-protocols.org/stats?id=45979228) #1 -> [Zo: Personal Servers for Everyone](https://www.zo.computer/)<!-- HN:45979228:end --><!-- HN:45978880:start -->
* [45978880](https://news.social-protocols.org/stats?id=45978880) #3 17 points 19 comments -> [Geothermal's Time Has Come](https://www.economist.com/interactive/science-and-technology/2025/11/18/geothermal-time-has-finally-come)<!-- HN:45978880:end --><!-- HN:45979674:start -->
* [45979674](https://news.social-protocols.org/stats?id=45979674) #22 6 points 0 comments -> [40% of young U.S. women want to leave the country: Gallup poll](https://www.deseret.com/politics/2025/11/18/gallup-poll-finds-us-women-want-leave-country-permanently/)<!-- HN:45979674:end --><!-- HN:45890639:start -->
* [45890639](https://news.social-protocols.org/stats?id=45890639) #19 7 points 6 comments -> [Race optimization algorithms with good initializations (beat them with bonuses)](https://debargha.com)<!-- HN:45890639:end --><!-- HN:45982542:start -->
* [45982542](https://news.social-protocols.org/stats?id=45982542) #1 61 points 47 comments -> [I am just sooo sick of AI prediction content, let's kill it already](https://verdikapuku.com/posts/i-am-just-so-sick-of-ai-prediction-content/)<!-- HN:45982542:end --><!-- HN:45983069:start -->
* [45983069](https://news.social-protocols.org/stats?id=45983069) #5 12 points 5 comments -> [Cypherpunks Hall of Fame](https://github.com/cypherpunkshall/cypherpunkshall.github.io)<!-- HN:45983069:end --><!-- HN:45981825:start -->
* [45981825](https://news.social-protocols.org/stats?id=45981825) #22 21 points 2 comments -> [The "Learned Helplessness" of AI](https://himanshusinghbisht.substack.com/p/the-learned-helplessness-of-ai)<!-- HN:45981825:end --><!-- HN:45985264:start -->
* [45985264](https://news.social-protocols.org/stats?id=45985264) #27 13 points 0 comments -> [Children among 25 killed in one of Russia's deadliest strikes on western Ukraine](https://www.bbc.com/news/articles/cy0yere4k0zo)<!-- HN:45985264:end --><!-- HN:45984789:start -->
* [45984789](https://news.social-protocols.org/stats?id=45984789) #30 17 points 3 comments -> [Detection, Decoding of "Power Track" Predictive Signaling in Equity Market Data](https://github.com/TheGameStopsNow/power-tracks-research)<!-- HN:45984789:end --><!-- HN:45985425:start -->
* [45985425](https://news.social-protocols.org/stats?id=45985425) #16 8 points 1 comments -> [I worked, I paid taxes – then the bank took my home](https://www.bbc.com/news/articles/cp8jz321x14o)<!-- HN:45985425:end -->
#### **Thursday, November 20, 2025**
<!-- HN:45979190:start -->
* [45979190](https://news.social-protocols.org/stats?id=45979190) #19 304 points 335 comments -> [Larry Summers resigns from OpenAI board](https://www.cnbc.com/2025/11/19/larry-summers-epstein-openai.html)<!-- HN:45979190:end --><!-- HN:45990287:start -->
* [45990287](https://news.social-protocols.org/stats?id=45990287) #1 28 points 9 comments -> [Why Zig Is Quietly Doing What Rust Couldn't: Staying Simple](https://freedium-mirror.cfd/@daxx5/why-zig-is-quietly-doing-what-rust-couldnt-staying-simple-a47f86b3a58a)<!-- HN:45990287:end --><!-- HN:45991835:start -->
* [45991835](https://news.social-protocols.org/stats?id=45991835) #17 35 points 19 comments -> [Tesla Robotaxi had 3 more crashes, now 7 total](https://electrek.co/2025/11/17/tesla-robotaxi-had-3-more-crashes-now-7-total/)<!-- HN:45991835:end --><!-- HN:45994235:start -->
* [45994235](https://news.social-protocols.org/stats?id=45994235) #21 7 points 1 comments -> [Show HN: Rapid-rs – Zero-config web framework for Rust](https://crates.io/crates/rapid-rs)<!-- HN:45994235:end --><!-- HN:45995554:start -->
* [45995554](https://news.social-protocols.org/stats?id=45995554) #19 14 points 4 comments -> [Gary Mani Mounfield of the Stone Roses and Primal Scream Dead at 63](https://www.manchestereveningnews.co.uk/news/greater-manchester-news/gary-mani-dead-stone-roses-32913693)<!-- HN:45995554:end --><!-- HN:45899836:start -->
* [45899836](https://news.social-protocols.org/stats?id=45899836) #6 47 points 10 comments -> [CoMaps emerges as an Organic Maps fork](https://lwn.net/Articles/1024387/)<!-- HN:45899836:end --><!-- HN:45997425:start -->
* [45997425](https://news.social-protocols.org/stats?id=45997425) #21 4 points 1 comments -> [nanochat.karpathy.ai](https://nanochat.karpathy.ai/)<!-- HN:45997425:end -->
#### **Friday, November 21, 2025**<!-- HN:45998649:start -->
* [45998649](https://news.social-protocols.org/stats?id=45998649) #27 70 points 49 comments -> [AI Is Writing Its Own Kernels, and They Are 17x Faster](https://adrs-ucb.notion.site/autocomp)<!-- HN:45998649:end --><!-- HN:45993943:start -->
* [45993943](https://news.social-protocols.org/stats?id=45993943) #17 185 points 197 comments -> [The Banished Bottom of the Housing Market](https://www.ryanpuzycki.com/p/the-banished-bottom-of-the-housing)<!-- HN:45993943:end --><!-- HN:45952621:start -->
* [45952621](https://news.social-protocols.org/stats?id=45952621) #8 21 points 40 comments -> [Apple's iPhone Overhaul Will Reduce Its Reliance on Annual Fall Spectacle](https://www.bloomberg.com/news/newsletters/2025-11-16/apple-s-iphone-road-map-iphone-air-2-iphone-18-mac-pro-future-tesla-carplay-mi1q4l2o)<!-- HN:45952621:end --><!-- HN:46004118:start -->
* [46004118](https://news.social-protocols.org/stats?id=46004118) #16 34 points 1 comments -> [Jmail: Gmail Clone with Epstein's Emails](https://jmail.world)<!-- HN:46004118:end --><!-- HN:46003995:start -->
* [46003995](https://news.social-protocols.org/stats?id=46003995) #15 17 points 7 comments -> [iHeartRadio web has exposed all its source code](https://github.com/Gh0styTongue/iHeart-Frontend-Source-Code)<!-- HN:46003995:end --><!-- HN:46006335:start -->
* [46006335](https://news.social-protocols.org/stats?id=46006335) #2 5 points 1 comments -> [Deciding to Win: A Common Sense Renewal of the Democratic Party](https://decidingtowin.org)<!-- HN:46006335:end --><!-- HN:46006756:start -->
* [46006756](https://news.social-protocols.org/stats?id=46006756) #6 11 points 5 comments -> [UK bar bans solo-drinkers to 'protect customers'](https://www.bbc.com/news/articles/cnve4eypg8zo)<!-- HN:46006756:end --><!-- HN:45923755:start -->
* [45923755](https://news.social-protocols.org/stats?id=45923755) #25 4 points 1 comments -> [The Anatomy of the Least Squares Method, Part Two](https://thepalindrome.org/p/the-anatomy-of-the-least-squares-ab5)<!-- HN:45923755:end -->
#### **Saturday, November 22, 2025**
<!-- HN:46010043:start -->
* [46010043](https://news.social-protocols.org/stats?id=46010043) #14 8 points 4 comments -> [Real-Time AI-Powered Texas Hold'em in Python and Flask – Play in the Browser](https://github.com/EMMA019/AI_pokergame)<!-- HN:46010043:end --><!-- HN:46011569:start -->
* [46011569](https://news.social-protocols.org/stats?id=46011569) #7 30 points 19 comments -> [Microsoft Will Preload Windows 11 File Explorer to Fix Bad Performance](https://blogs.windows.com/windows-insider/2025/11/21/announcing-windows-11-insider-preview-build-26100-7271-dev-beta-channels/)<!-- HN:46011569:end --><!-- HN:45926581:start -->
* [45926581](https://news.social-protocols.org/stats?id=45926581) #10 7 points 0 comments -> [Mexico's Female Rodeo Culture](https://www.cnn.com/2025/11/13/style/escaramuza-cowgirl-fashion-photography)<!-- HN:45926581:end --><!-- HN:46012052:start -->
* [46012052](https://news.social-protocols.org/stats?id=46012052) #22 7 points 1 comments -> [Openring-rs: a webring for static site generators written in Rust](https://github.com/lukehsiao/openring-rs)<!-- HN:46012052:end --><!-- HN:46012538:start -->
* [46012538](https://news.social-protocols.org/stats?id=46012538) #10 8 points 5 comments -> [Building a deep-space logistics startup](https://ionmicrosys.com/)<!-- HN:46012538:end --><!-- HN:46013900:start -->
* [46013900](https://news.social-protocols.org/stats?id=46013900) #24 21 points 5 comments -> [Why DETRs are replacing YOLOs for real-time object detection](https://blog.datameister.ai/detection-transformers-real-time-object-detection)<!-- HN:46013900:end --><!-- HN:45962656:start -->
* [45962656](https://news.social-protocols.org/stats?id=45962656) #19 50 points 40 comments -> [Event Sourcing in Go: From Zero to Production](https://skoredin.pro/blog/golang/event-sourcing-go)<!-- HN:45962656:end --><!-- HN:46015417:start -->
* [46015417](https://news.social-protocols.org/stats?id=46015417) #7 20 points 42 comments -> [The Pentagon Can't Trust GPS Anymore](https://www.wsj.com/tech/the-pentagon-cant-trust-gps-anymore-is-quantum-physics-the-answer-d7b2d4e6)<!-- HN:46015417:end --><!-- HN:46015262:start -->
* [46015262](https://news.social-protocols.org/stats?id=46015262) #16 36 points 41 comments -> [A looming 'insect apocalypse' could endanger global food supplies](https://www.livescience.com/animals/insects/a-looming-insect-apocalypse-could-endanger-global-food-supplies-can-we-stop-it-before-its-too-late)<!-- HN:46015262:end --><!-- HN:46018107:start -->
* [46018107](https://news.social-protocols.org/stats?id=46018107) #16 6 points 9 comments -> [Show HN: RealDeed – Tokenize Real Estate into Digital Assets](https://www.realdeed.co/)<!-- HN:46018107:end -->
#### **Sunday, November 23, 2025**
<!-- HN:46017830:start -->
* [46017830](https://news.social-protocols.org/stats?id=46017830) #28 3 points 0 comments -> [A Woman on a Mission to Photograph Every Species of Hummingbird](https://www.audubon.org/magazine/meet-woman-mission-photograph-every-species-of-hummingbird-world)<!-- HN:46017830:end --><!-- HN:45937230:start -->
* [45937230](https://news.social-protocols.org/stats?id=45937230) #29 14 points 0 comments -> [Anukari on the CPU (part 2: CPU optimization)](https://anukari.com/blog/devlog/anukari-on-the-cpu-part-2-cpu-optimization)<!-- HN:45937230:end -->