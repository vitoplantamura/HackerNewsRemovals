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

#### **Saturday, November 22, 2025**
<!-- HN:46010043:start -->
* [46010043](https://news.social-protocols.org/stats?id=46010043) #14 8 points 4 comments -> [Real-Time AI-Powered Texas Hold'em in Python and Flask – Play in the Browser](https://github.com/EMMA019/AI_pokergame)<!-- HN:46010043:end --><!-- HN:46011569:start -->
* [46011569](https://news.social-protocols.org/stats?id=46011569) #7 30 points 19 comments -> [Microsoft Will Preload Windows 11 File Explorer to Fix Bad Performance](https://blogs.windows.com/windows-insider/2025/11/21/announcing-windows-11-insider-preview-build-26100-7271-dev-beta-channels/)<!-- HN:46011569:end --><!-- HN:45926581:start -->
* [45926581](https://news.social-protocols.org/stats?id=45926581) #10 7 points 0 comments -> [Mexico's Female Rodeo Culture](https://www.cnn.com/2025/11/13/style/escaramuza-cowgirl-fashion-photography)<!-- HN:45926581:end --><!-- HN:46012052:start -->
* [46012052](https://news.social-protocols.org/stats?id=46012052) #22 7 points 1 comments -> [Openring-rs: a webring for static site generators written in Rust](https://github.com/lukehsiao/openring-rs)<!-- HN:46012052:end --><!-- HN:46012538:start -->
* [46012538](https://news.social-protocols.org/stats?id=46012538) #10 8 points 5 comments -> [Building a deep-space logistics startup](https://ionmicrosys.com/)<!-- HN:46012538:end --><!-- HN:46013900:start -->
* [46013900](https://news.social-protocols.org/stats?id=46013900) #24 21 points 5 comments -> [Why DETRs are replacing YOLOs for real-time object detection](https://blog.datameister.ai/detection-transformers-real-time-object-detection)<!-- HN:46013900:end --><!-- HN:46015417:start -->
* [46015417](https://news.social-protocols.org/stats?id=46015417) #7 20 points 42 comments -> [The Pentagon Can't Trust GPS Anymore](https://www.wsj.com/tech/the-pentagon-cant-trust-gps-anymore-is-quantum-physics-the-answer-d7b2d4e6)<!-- HN:46015417:end --><!-- HN:46015262:start -->
* [46015262](https://news.social-protocols.org/stats?id=46015262) #16 36 points 41 comments -> [A looming 'insect apocalypse' could endanger global food supplies](https://www.livescience.com/animals/insects/a-looming-insect-apocalypse-could-endanger-global-food-supplies-can-we-stop-it-before-its-too-late)<!-- HN:46015262:end --><!-- HN:46018107:start -->
* [46018107](https://news.social-protocols.org/stats?id=46018107) #16 6 points 9 comments -> [Show HN: RealDeed – Tokenize Real Estate into Digital Assets](https://www.realdeed.co/)<!-- HN:46018107:end -->
#### **Sunday, November 23, 2025**
<!-- HN:45937230:start -->
* [45937230](https://news.social-protocols.org/stats?id=45937230) #29 14 points 0 comments -> [Anukari on the CPU (part 2: CPU optimization)](https://anukari.com/blog/devlog/anukari-on-the-cpu-part-2-cpu-optimization)<!-- HN:45937230:end --><!-- HN:46019168:start -->
* [46019168](https://news.social-protocols.org/stats?id=46019168) #29 64 points 26 comments -> [How to Spot a Counterfeit Lithium-Ion Battery](https://spectrum.ieee.org/counterfeit-lithium-ion-batteries)<!-- HN:46019168:end --><!-- HN:46020794:start -->
* [46020794](https://news.social-protocols.org/stats?id=46020794) #18 17 points 9 comments -> [Rust Isn't the Future of Systems Programming – It's Just the Hype Cycle](https://freedium-mirror.cfd/cachecowboy/rust-isnt-the-future-of-systems-programming-it-s-just-the-hype-cycle-29afd73ff871)<!-- HN:46020794:end --><!-- HN:46021942:start -->
* [46021942](https://news.social-protocols.org/stats?id=46021942) #5 -> [Gemini 3 Just Made Larry Page World's Third Richest Man](https://vechron.com/2025/11/larry-page-overtakes-jeff-bezos-to-become-third-richest/)<!-- HN:46021942:end --><!-- HN:46024211:start -->
* [46024211](https://news.social-protocols.org/stats?id=46024211) #19 11 points 3 comments -> [Top MAGA Influencers on X/Twitter Accidentally Unmasked as Foreign Trolls](https://www.thedailybeast.com/top-maga-influencers-accidentally-unmasked-as-foreign-actors/)<!-- HN:46024211:end --><!-- HN:46025978:start -->
* [46025978](https://news.social-protocols.org/stats?id=46025978) #7 34 points 16 comments -> [Scoop: Judge Caught Using AI to Read His Court Decisions](https://migrantinsider.com/p/scoop-judge-caught-using-ai-to-read)<!-- HN:46025978:end --><!-- HN:46026919:start -->
* [46026919](https://news.social-protocols.org/stats?id=46026919) #10 8 points 5 comments -> [I Let Claude Build My Home Network: Two ISPs Bonded, $312/Year Saved](https://jonathanclark.com/posts/bonded-internet-connection-ai.html)<!-- HN:46026919:end --><!-- HN:46027265:start -->
* [46027265](https://news.social-protocols.org/stats?id=46027265) #11 5 points 2 comments -> [AI Content Pipeline: My Experience](https://techlife.blog/posts/ai-content-pipeline/)<!-- HN:46027265:end --><!-- HN:46027245:start -->
* [46027245](https://news.social-protocols.org/stats?id=46027245) #21 5 points 4 comments -> [Lead magnet creation for blue collar SaaS](https://estimatekit.com/free-templates)<!-- HN:46027245:end -->
#### **Monday, November 24, 2025**
<!-- HN:45952155:start -->
* [45952155](https://news.social-protocols.org/stats?id=45952155) #15 14 points 1 comments -> [Halfbakery: Purely functional programming with heat output](https://www.halfbakery.com/idea/Purely_20functional_20programming_20with_20heat_20output#1763275883)<!-- HN:45952155:end --><!-- HN:45952355:start -->
* [45952355](https://news.social-protocols.org/stats?id=45952355) #16 11 points 0 comments -> ['Complicated' watch from 1907 sets world record at auction](https://www.bbc.co.uk/news/articles/cn7e4m48gdro)<!-- HN:45952355:end --><!-- HN:45922514:start -->
* [45922514](https://news.social-protocols.org/stats?id=45922514) #29 55 points 16 comments -> [Spectral rendering, part 2: Real-time rendering](https://momentsingraphics.de/SpectralRendering2Rendering.html)<!-- HN:45922514:end --><!-- HN:45956542:start -->
* [45956542](https://news.social-protocols.org/stats?id=45956542) #30 33 points 10 comments -> [Pyrotechnic Display Design Software](https://github.com/giuseppe-coco/FireShow)<!-- HN:45956542:end --><!-- HN:46029561:start -->
* [46029561](https://news.social-protocols.org/stats?id=46029561) #20 39 points 25 comments -> [My Life Is a Lie: How a Broken Benchmark Broke America](https://www.yesigiveafig.com/p/part-1-my-life-is-a-lie)<!-- HN:46029561:end --><!-- HN:46029765:start -->
* [46029765](https://news.social-protocols.org/stats?id=46029765) #14 37 points 3 comments -> [B-Trees: Why Every Database Uses Them](https://mehmetgoekce.substack.com/p/b-trees-why-every-database-uses-them)<!-- HN:46029765:end --><!-- HN:45989899:start -->
* [45989899](https://news.social-protocols.org/stats?id=45989899) #25 3 points 3 comments -> [GravOpt – optimizer hits 99.9999% MAX-CUT in 100 steps](https://github.com/Kretski/GravOptAdaptiveE)<!-- HN:45989899:end --><!-- HN:46029772:start -->
* [46029772](https://news.social-protocols.org/stats?id=46029772) #15 161 points 1 comments -> [We stopped roadmap work for a week and fixed 189 bugs](https://lalitm.com/fixits-are-good-for-the-soul/)<!-- HN:46029772:end --><!-- HN:46033945:start -->
* [46033945](https://news.social-protocols.org/stats?id=46033945) #20 8 points 3 comments -> ['Nobody wants to come': What if the U.S. can no longer attract immigrant doctors](https://www.npr.org/sections/shots-health-news/2025/11/24/nx-s1-5618291/immigrant-physicians-foreign-born-doctors-trump-h1b)<!-- HN:46033945:end --><!-- HN:46034470:start -->
* [46034470](https://news.social-protocols.org/stats?id=46034470) #4 29 points 12 comments -> [US 'Homeland Security' Twitter account seemingly run from Israel](https://www.thecanary.co/trending/2025/11/23/twitter-location-data/)<!-- HN:46034470:end --><!-- HN:46034281:start -->
* [46034281](https://news.social-protocols.org/stats?id=46034281) #6 9 points 5 comments -> [Hugo Static Site on Cloudflare](https://techlife.blog/posts/hugo-static-site-on-cloudflare/)<!-- HN:46034281:end --><!-- HN:46036217:start -->
* [46036217](https://news.social-protocols.org/stats?id=46036217) #1 528 points 177 comments -> [France threatens GrapheneOS with arrests / server seizure for refusing backdoors](https://mamot.fr/@LaQuadrature/115581775965025042)<!-- HN:46036217:end --><!-- HN:46035533:start -->
* [46035533](https://news.social-protocols.org/stats?id=46035533) #1 329 points 16 comments -> [SHA1-Hulud the Second Comming – Postman, Zapier, PostHog All Compromised via NPM](https://www.aikido.dev/blog/shai-hulud-strikes-again-hitting-zapier-ensdomains)<!-- HN:46035533:end --><!-- HN:46038354:start -->
* [46038354](https://news.social-protocols.org/stats?id=46038354) #30 4 points 1 comments -> [Why my rust rewrite of Mozilla's readability is better than original readability](https://github.com/theiskaa/readabilityrs)<!-- HN:46038354:end --><!-- HN:46040005:start -->
* [46040005](https://news.social-protocols.org/stats?id=46040005) #20 109 points 30 comments -> [DoGE "cut muscle, not fat"; 26K experts rehired after brutal cuts](https://arstechnica.com/tech-policy/2025/11/doge-doesnt-exist-anymore-but-expert-says-its-still-not-dead/)<!-- HN:46040005:end -->
#### **Tuesday, November 25, 2025**
<!-- HN:46041401:start -->
* [46041401](https://news.social-protocols.org/stats?id=46041401) #21 -> [USAID shutdown has led to deaths](https://hsph.harvard.edu/news/usaid-shutdown-has-led-to-hundreds-of-thousands-of-deaths/)<!-- HN:46041401:end --><!-- HN:45975889:start -->
* [45975889](https://news.social-protocols.org/stats?id=45975889) #16 11 points 0 comments -> [A Major City of the Kazakh Steppe? Investigating Semiyarka's Bronze Age Legacy](https://www.cambridge.org/core/journals/antiquity/article/major-city-of-the-kazakh-steppe-investigating-semiyarkas-bronze-age-legacy/7D20FEEC9B8F7BC60721BF7CA401B788)<!-- HN:45975889:end --><!-- HN:45974732:start -->
* [45974732](https://news.social-protocols.org/stats?id=45974732) #21 61 points 45 comments -> [Neopets.com Changed My Life (2019)](https://annastreetman.com/2019/05/19/how-neopets-com-changed-my-life/)<!-- HN:45974732:end --><!-- HN:46043972:start -->
* [46043972](https://news.social-protocols.org/stats?id=46043972) #5 7 points 2 comments -> [Show HN: I built the literal Duolingo Killer](https://kanjieight.vercel.app/)<!-- HN:46043972:end --><!-- HN:46046626:start -->
* [46046626](https://news.social-protocols.org/stats?id=46046626) #7 12 points 4 comments -> [Cryptology firm cancels elections after losing encryption key](https://www.bbc.com/news/articles/c62vl05rz0ko)<!-- HN:46046626:end --><!-- HN:46010552:start -->
* [46010552](https://news.social-protocols.org/stats?id=46010552) #20 27 points 10 comments -> [Explaining, at some length, Techmeme's 20 years of consistency](https://news.techmeme.com/250912/20-years)<!-- HN:46010552:end --><!-- HN:45981514:start -->
* [45981514](https://news.social-protocols.org/stats?id=45981514) #7 175 points 39 comments -> [Meta Segment Anything Model 3](https://ai.meta.com/blog/segment-anything-model-3/?_fb_noscript=1)<!-- HN:45981514:end --><!-- HN:46012588:start -->
* [46012588](https://news.social-protocols.org/stats?id=46012588) #21 7 points 0 comments -> [Room-temperature processible ceramics enable sustainable electronics](https://www.dezeen.com/2025/11/17/geolectric-light-mit-design-intelligence-lab/)<!-- HN:46012588:end --><!-- HN:46049370:start -->
* [46049370](https://news.social-protocols.org/stats?id=46049370) #18 13 points 11 comments -> [Show HN: Secure private diffchecker with merge support](https://diffchecker.dev)<!-- HN:46049370:end --><!-- HN:45988000:start -->
* [45988000](https://news.social-protocols.org/stats?id=45988000) #4 31 points 2 comments -> [A rare GM EV1 saved from the crusher is going to be driveable again](https://electrek.co/2025/11/19/gm-ev1-saved-from-crusher-going-driveable-again/)<!-- HN:45988000:end --><!-- HN:46050903:start -->
* [46050903](https://news.social-protocols.org/stats?id=46050903) #10 3 points 0 comments -> [Constant-time support coming to LLVM: Protecting cryptographic code](https://blog.trailofbits.com/2025/11/25/constant-time-support-coming-to-llvm-protecting-cryptographic-code-at-the-compiler-level/)<!-- HN:46050903:end --><!-- HN:46050997:start -->
* [46050997](https://news.social-protocols.org/stats?id=46050997) #30 18 points 7 comments -> [Stop Putting Your Passwords into Random Websites (Yes, Seriously, You Are the PR](https://labs.watchtowr.com/stop-putting-your-passwords-into-random-websites-yes-seriously-you-are-the-problem/)<!-- HN:46050997:end -->
#### **Wednesday, November 26, 2025**
<!-- HN:46052090:start -->
* [46052090](https://news.social-protocols.org/stats?id=46052090) #8 25 points 6 comments -> [LLVM Adds Constant-Time Support for Protecting Cryptographic Code](https://blog.trailofbits.com/2025/11/25/constant-time-support-lands-in-llvm-protecting-cryptographic-code-at-the-compiler-level/)<!-- HN:46052090:end --><!-- HN:46052672:start -->
* [46052672](https://news.social-protocols.org/stats?id=46052672) #22 16 points 1 comments -> [Brand New Layouts with CSS Subgrid](https://www.joshwcomeau.com/css/subgrid/)<!-- HN:46052672:end --><!-- HN:45997514:start -->
* [45997514](https://news.social-protocols.org/stats?id=45997514) #18 -> [Microsoft makes Zork I, II, and III open source under MIT License](https://arstechnica.com/gaming/2025/11/microsoft-makes-zork-i-ii-and-iii-open-source-under-mit-license/)<!-- HN:45997514:end --><!-- HN:45994277:start -->
* [45994277](https://news.social-protocols.org/stats?id=45994277) #28 15 points 11 comments -> [First Air-Breathing Spacecraft](https://rdw.com/newsroom/redwire-awarded-44-million-darpa-contract-to-advance-very-low-earth-orbit-mission/)<!-- HN:45994277:end --><!-- HN:46056197:start -->
* [46056197](https://news.social-protocols.org/stats?id=46056197) #29 75 points 56 comments -> [Await Is Not a Context Switch: Understanding Python's Coroutines vs. Tasks](https://mergify.com/blog/await-is-not-a-context-switch-understanding-python-s-coroutines-vs-tasks)<!-- HN:46056197:end --><!-- HN:46057717:start -->
* [46057717](https://news.social-protocols.org/stats?id=46057717) #11 14 points 1 comments -> [Show HN: Offline RAG System Using Docker and Llama 3 (No Cloud APIs)](https://github.com/PhilYeh1212/Local-AI-Knowledge-Base-Docker-Llama3)<!-- HN:46057717:end --><!-- HN:46055944:start -->
* [46055944](https://news.social-protocols.org/stats?id=46055944) #23 436 points 572 comments -> [I don't care how well your "AI" works](https://fokus.cool/2025/11/25/i-dont-care-how-well-your-ai-works.html)<!-- HN:46055944:end --><!-- HN:46059765:start -->
* [46059765](https://news.social-protocols.org/stats?id=46059765) #2 38 points 5 comments -> [GrapheneOS is leaving France after receiving threats from law enforcement](https://grapheneos.social/@GrapheneOS/115606319562587450)<!-- HN:46059765:end --><!-- HN:46060357:start -->
* [46060357](https://news.social-protocols.org/stats?id=46060357) #15 38 points 41 comments -> [Investors expect AI use to soar. That's not happening](https://www.economist.com/finance-and-economics/2025/11/26/investors-expect-ai-use-to-soar-thats-not-happening)<!-- HN:46060357:end --><!-- HN:46061362:start -->
* [46061362](https://news.social-protocols.org/stats?id=46061362) #21 13 points 5 comments -> [Widespread service disruptions reported as major platforms go down worldwide](https://www.ynetnews.com/tech-and-digital/article/bky0aavb11g)<!-- HN:46061362:end --><!-- HN:46061232:start -->
* [46061232](https://news.social-protocols.org/stats?id=46061232) #15 24 points 26 comments -> [API that auto-routes to the cheapest AI provider (OpenAI/Anthropic/Gemini)](https://tokensaver.org/)<!-- HN:46061232:end --><!-- HN:45987014:start -->
* [45987014](https://news.social-protocols.org/stats?id=45987014) #9 40 points 31 comments -> [An Homage to 90s –/Public_HTML Hosting](https://public.monster/)<!-- HN:45987014:end --><!-- HN:45984864:start -->
* [45984864](https://news.social-protocols.org/stats?id=45984864) #22 224 points 54 comments -> [Copyparty, the FOSS file server [video]](https://www.youtube.com/watch?v=15_-hgsX2V0)<!-- HN:45984864:end -->
#### **Thursday, November 27, 2025**
<!-- HN:46062483:start -->
* [46062483](https://news.social-protocols.org/stats?id=46062483) #20 98 points 92 comments -> [AirDrop support for Pixel 10 likely exists because of the EU ruling](https://9to5google.com/2025/11/21/googles-airdrop-support-for-pixel-10-likely-exists-because-of-the-eus-apple-ruling/)<!-- HN:46062483:end --><!-- HN:46064998:start -->
* [46064998](https://news.social-protocols.org/stats?id=46064998) #25 3 points 1 comments -> [Vibe coding: What is it good for? Absolutely nothing](https://www.theregister.com/2025/11/24/opinion_column_vibe_coding/)<!-- HN:46064998:end --><!-- HN:46068314:start -->
* [46068314](https://news.social-protocols.org/stats?id=46068314) #5 5 points 1 comments -> [Why (Senior) Engineers Struggle to Build AI Agents](https://www.philschmid.de/why-engineers-struggle-building-agents)<!-- HN:46068314:end --><!-- HN:46069743:start -->
* [46069743](https://news.social-protocols.org/stats?id=46069743) #8 32 points 19 comments -> [Don't be a scary old guy: My 40s survival strategy with charm](https://www.devas.life/dont-be-a-scary-old-guy-my-40s-survival-strategy-with-charm/)<!-- HN:46069743:end --><!-- HN:46069919:start -->
* [46069919](https://news.social-protocols.org/stats?id=46069919) #2 11 points 4 comments -> [What Happens When You Train Pure Logic Without Knowledge: 15-Expert Moe](https://github.com/vac-architector/VAC-Memory-System/blob/main/LOGICA_MOE_STORY.md)<!-- HN:46069919:end --><!-- HN:46070597:start -->
* [46070597](https://news.social-protocols.org/stats?id=46070597) #21 5 points 1 comments -> [Face transplants promised hope. Patients were put through the unthinkable](https://www.theguardian.com/science/2025/nov/27/face-transplant-patients-results-outcomes)<!-- HN:46070597:end --><!-- HN:46070842:start -->
* [46070842](https://news.social-protocols.org/stats?id=46070842) #10 5 points 3 comments -> [It's Been a Very Hard Year](https://bell.bz/its-been-a-very-hard-year/)<!-- HN:46070842:end --><!-- HN:46073862:start -->
* [46073862](https://news.social-protocols.org/stats?id=46073862) #6 12 points 3 comments -> [Show HN: Whole-home VPN router with hardware kill switch (OpenWrt and WireGuard)](https://github.com/yoloshii/privacy-first-network)<!-- HN:46073862:end --><!-- HN:46073319:start -->
* [46073319](https://news.social-protocols.org/stats?id=46073319) #25 6 points 1 comments -> [Show HN: No Black Friday – A directory of fair-price brands](https://no-blackfriday.com)<!-- HN:46073319:end -->
#### **Friday, November 28, 2025**
<!-- HN:46036124:start -->
* [46036124](https://news.social-protocols.org/stats?id=46036124) #17 8 points 0 comments -> [Modelling Agent Systems with Erlang (2004) [pdf]](https://erlang.org/workshop/2004/carlosvarela.pdf)<!-- HN:46036124:end --><!-- HN:46075575:start -->
* [46075575](https://news.social-protocols.org/stats?id=46075575) #25 8 points 2 comments -> [Andrew Kelley removed his "monkeys" and "losers" references](https://web.archive.org/web/20251127021007/https://ziglang.org/news/migrating-from-github-to-codeberg/)<!-- HN:46075575:end --><!-- HN:46074729:start -->
* [46074729](https://news.social-protocols.org/stats?id=46074729) #24 10 points 7 comments -> [Overlord: AI accountability that watches over you](https://overlord.app/)<!-- HN:46074729:end --><!-- HN:46080131:start -->
* [46080131](https://news.social-protocols.org/stats?id=46080131) #21 12 points 0 comments -> [The Pro-Israel Information War](https://www.leefang.com/p/inside-the-pro-israel-information)<!-- HN:46080131:end --><!-- HN:46027104:start -->
* [46027104](https://news.social-protocols.org/stats?id=46027104) #24 16 points 4 comments -> [NSA and IETF, Part 2](https://blog.cr.yp.to/20251123-corruption.html)<!-- HN:46027104:end -->