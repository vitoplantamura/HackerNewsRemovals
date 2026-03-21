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

#### **Sunday, March 15, 2026**
<!-- HN:47382739:start -->
* [47382739](https://news.social-protocols.org/stats?id=47382739) #11 103 points 2 comments -> [FCC chairman threatens TV broadcast licenses over news coverage](https://fortune.com/2026/03/14/fcc-brendan-carr-tv-broadcast-licenses-news-coverage-us-war-iran-trump/)<!-- HN:47382739:end --><!-- HN:47383298:start -->
* [47383298](https://news.social-protocols.org/stats?id=47383298) #12 60 points 33 comments -> [Federal Surveillance Tech Becomes Mandatory in New Cars by 2027](https://www.gadgetreview.com/federal-surveillance-tech-becomes-mandatory-in-new-cars-by-2027)<!-- HN:47383298:end --><!-- HN:47321469:start -->
* [47321469](https://news.social-protocols.org/stats?id=47321469) #6 27 points 6 comments -> [Deriving Type Erasure](https://david.alvarezrosa.com/posts/deriving-type-erasure/)<!-- HN:47321469:end --><!-- HN:47320571:start -->
* [47320571](https://news.social-protocols.org/stats?id=47320571) #17 44 points 19 comments -> [Offloading FFmpeg with Cloudflare](https://kentcdodds.com/blog/offloading-ffmpeg-with-cloudflare)<!-- HN:47320571:end --><!-- HN:47382196:start -->
* [47382196](https://news.social-protocols.org/stats?id=47382196) #13 91 points 58 comments -> [The Sound of Contamination: Headphones Contain Ing Hormone-Disrupting Chemicals](https://arnika.org/en/news/the-sound-of-contamination-all-analysed-headphones-on-the-central-european-market-found-to-contain-hormone-disrupting-chemicals)<!-- HN:47382196:end --><!-- HN:47383942:start -->
* [47383942](https://news.social-protocols.org/stats?id=47383942) #29 9 points 2 comments -> [FCC Chair Threatens to Revoke Broadcasters' Licenses over War Coverage](https://www.nytimes.com/2026/03/14/world/middleeast/fcc-broadcasters-iran-war.html)<!-- HN:47383942:end --><!-- HN:47325606:start -->
* [47325606](https://news.social-protocols.org/stats?id=47325606) #10 -> [From Braun T3 to Apple's iPod](https://drams.framer.website/journal/from-braun-t3-to-apples-ipod)<!-- HN:47325606:end --><!-- HN:47384467:start -->
* [47384467](https://news.social-protocols.org/stats?id=47384467) #21 -> [Microslop](https://www.s-config.com/microslop/)<!-- HN:47384467:end --><!-- HN:47339928:start -->
* [47339928](https://news.social-protocols.org/stats?id=47339928) #28 14 points 3 comments -> [The Passion of Will Self](https://www.newstatesman.com/culture/books/2026/03/the-passion-of-will-self)<!-- HN:47339928:end --><!-- HN:47387548:start -->
* [47387548](https://news.social-protocols.org/stats?id=47387548) #17 12 points 7 comments -> [Brazil publishes a list of companies needing age verification, includes Ubuntu](https://www.gov.br/anpd/pt-br/assuntos/noticias/em-acao-de-monitoramento-do-eca-digital-a-anpd-estende-o-prazo-para-que-empresas-prestem-informacoes-sobre-implementacao-das-novas-regras)<!-- HN:47387548:end --><!-- HN:47387956:start -->
* [47387956](https://news.social-protocols.org/stats?id=47387956) #24 12 points 6 comments -> [The U.S. Mint dropped the olive branch from the dime](https://fortune.com/2026/03/12/us-mint-drops-olive-branch-dime-peace-war/)<!-- HN:47387956:end --><!-- HN:47388830:start -->
* [47388830](https://news.social-protocols.org/stats?id=47388830) #14 46 points 23 comments -> [Palantir defends its role in the kill chain: "We are proud of that"](https://www.heise.de/en/news/Palantir-defends-its-role-in-the-kill-chain-We-are-very-very-proud-of-that-11211275.html)<!-- HN:47388830:end --><!-- HN:47389858:start -->
* [47389858](https://news.social-protocols.org/stats?id=47389858) #3 31 points 9 comments -> [Tech companies defeat bill as AI drains local water supplies](https://www.theolympus.net/13531/)<!-- HN:47389858:end --><!-- HN:47389472:start -->
* [47389472](https://news.social-protocols.org/stats?id=47389472) #8 12 points 5 comments -> [The most brilliant move in corporate history?](https://asymco.com/2026/03/10/the-most-brilliant-move-in-corporate-history/)<!-- HN:47389472:end --><!-- HN:47390287:start -->
* [47390287](https://news.social-protocols.org/stats?id=47390287) #8 8 points 1 comments -> [AI Didn't Make Expertise Optional. It Made It More Valuable](https://getaibook.com/blog/ai-didnt-make-expertise-optional/)<!-- HN:47390287:end -->
#### **Monday, March 16, 2026**
<!-- HN:47332593:start -->
* [47332593](https://news.social-protocols.org/stats?id=47332593) #13 116 points 63 comments -> [C++26: The Oxford Variadic Comma](https://www.sandordargo.com/blog/2026/03/11/cpp26-oxford-variadic-comma)<!-- HN:47332593:end --><!-- HN:47396122:start -->
* [47396122](https://news.social-protocols.org/stats?id=47396122) #10 5 points 1 comments -> [A curated list of AI slops](https://github.com/yikerman/awesome-ai-slop)<!-- HN:47396122:end --><!-- HN:47397163:start -->
* [47397163](https://news.social-protocols.org/stats?id=47397163) #9 4 points 0 comments -> [LoKI – Local AI Assistant for Linux and WSL](https://schneider-ki.com/)<!-- HN:47397163:end --><!-- HN:47339463:start -->
* [47339463](https://news.social-protocols.org/stats?id=47339463) #25 173 points 69 comments -> [//go:fix inline and the source-level inliner](https://go.dev/blog/inliner)<!-- HN:47339463:end --><!-- HN:47339818:start -->
* [47339818](https://news.social-protocols.org/stats?id=47339818) #27 202 points 76 comments -> [Bus travel from Lima to Rio de Janeiro](https://kenschutte.com/lima-to-rio-by-bus/)<!-- HN:47339818:end -->
#### **Tuesday, March 17, 2026**
<!-- HN:47406569:start -->
* [47406569](https://news.social-protocols.org/stats?id=47406569) #25 20 points 10 comments -> [Show HN: Trackm, a personal finance web app](https://trackm.net)<!-- HN:47406569:end --><!-- HN:47407846:start -->
* [47407846](https://news.social-protocols.org/stats?id=47407846) #6 9 points 0 comments -> [Every 8 minutes, a case of sexual assault/misconduct was reported to Uber](https://every8minutes.com)<!-- HN:47407846:end --><!-- HN:47407711:start -->
* [47407711](https://news.social-protocols.org/stats?id=47407711) #28 8 points 1 comments -> [Early adult drinking linked to middleage cognitive decline–even after abstinence](https://medicalxpress.com/news/2026-03-early-adult-linked-middle-age.html)<!-- HN:47407711:end --><!-- HN:47348652:start -->
* [47348652](https://news.social-protocols.org/stats?id=47348652) #23 278 points 135 comments -> [Home Assistant waters my plants](https://finnian.io/blog/home-assistant-waters-my-plants/)<!-- HN:47348652:end --><!-- HN:47410765:start -->
* [47410765](https://news.social-protocols.org/stats?id=47410765) #3 -> [Kagi Orion Early Beta for Linux Flatpak](https://orionbrowser.com/download/oriongtk-early-beta)<!-- HN:47410765:end --><!-- HN:47412848:start -->
* [47412848](https://news.social-protocols.org/stats?id=47412848) #23 -> [Turns Out the DOGE Bros Who Killed Humanities Grants Are Sensitive About It](https://www.techdirt.com/2026/03/16/turns-out-the-doge-bros-who-killed-humanities-grants-are-kinda-sensitive-about-it/)<!-- HN:47412848:end --><!-- HN:47410870:start -->
* [47410870](https://news.social-protocols.org/stats?id=47410870) #5 782 points 14 comments -> [Reddit User Uncovers Who Is Behind Meta's $2B Lobbying for Age Verification Tech](https://www.gadgetreview.com/reddit-user-uncovers-who-is-behind-metas-2b-lobbying-for-invasive-age-verification-tech)<!-- HN:47410870:end --><!-- HN:47357633:start -->
* [47357633](https://news.social-protocols.org/stats?id=47357633) #11 38 points 5 comments -> [Perlsky Is a Perl 5 Implementation of an at Protocol Personal Data Server](https://tangled.org/alice.mosphere.at/perlsky)<!-- HN:47357633:end --><!-- HN:47357846:start -->
* [47357846](https://news.social-protocols.org/stats?id=47357846) #15 10 points 2 comments -> [Diels-grabsch2: Self Hashing C Program (2019)](https://www.ioccc.org/2019/diels-grabsch2/)<!-- HN:47357846:end --><!-- HN:47356382:start -->
* [47356382](https://news.social-protocols.org/stats?id=47356382) #19 4 points 0 comments -> [The Official GBBS Pro Repository](https://gbbs.applearchives.com/)<!-- HN:47356382:end --><!-- HN:47358335:start -->
* [47358335](https://news.social-protocols.org/stats?id=47358335) #25 35 points 20 comments -> [How long does it take to get last liquid drops from kitchen containers?](https://www.brown.edu/news/2026-03-04/kitchen-fluid-dynamics)<!-- HN:47358335:end --><!-- HN:47415051:start -->
* [47415051](https://news.social-protocols.org/stats?id=47415051) #18 7 points 2 comments -> [Why Are We Still Doing This?](https://www.wheresyoured.at/why-are-we-still-doing-this/)<!-- HN:47415051:end --><!-- HN:47415103:start -->
* [47415103](https://news.social-protocols.org/stats?id=47415103) #22 -> [DOGE Didn't Cut Government Waste. It Was Government Waste](https://www.techdirt.com/2026/03/17/doge-didnt-cut-government-waste-it-was-government-waste/)<!-- HN:47415103:end --><!-- HN:47416604:start -->
* [47416604](https://news.social-protocols.org/stats?id=47416604) #10 11 points 3 comments -> [How OpenClaw's Memory System Works](https://www.db0.ai/blog/how-openclaw-memory-works)<!-- HN:47416604:end --><!-- HN:47418184:start -->
* [47418184](https://news.social-protocols.org/stats?id=47418184) #7 8 points 0 comments -> [Curated Female Founder Cohort in SF](https://jointheden.co/)<!-- HN:47418184:end --><!-- HN:47418595:start -->
* [47418595](https://news.social-protocols.org/stats?id=47418595) #6 8 points 0 comments -> [Iranian citizens are calling in Israeli air strikes on their leaders](https://www.iranintl.com/en/202603179685)<!-- HN:47418595:end --><!-- HN:47417983:start -->
* [47417983](https://news.social-protocols.org/stats?id=47417983) #5 71 points 16 comments -> [Warranty Void If Regenerated](https://nearzero.software/p/warranty-void-if-regenerated)<!-- HN:47417983:end -->
#### **Wednesday, March 18, 2026**
<!-- HN:47420307:start -->
* [47420307](https://news.social-protocols.org/stats?id=47420307) #17 9 points 1 comments -> [FAQs About the Public Debt](https://www.treasurydirect.gov/help-center/public-debt-faqs/)<!-- HN:47420307:end --><!-- HN:47361251:start -->
* [47361251](https://news.social-protocols.org/stats?id=47361251) #17 115 points 30 comments -> [Chrome extension adjusts video speed based on how fast the speaker is talking](https://github.com/ywong137/speech-speed)<!-- HN:47361251:end --><!-- HN:47421742:start -->
* [47421742](https://news.social-protocols.org/stats?id=47421742) #29 4 points 0 comments -> [Show HN: Bank Parser – Convert US Bank Statement PDFs to QuickBooks-Ready Excel](https://bank-parser.com)<!-- HN:47421742:end --><!-- HN:47367601:start -->
* [47367601](https://news.social-protocols.org/stats?id=47367601) #11 116 points 30 comments -> [Pandas Exercises for Data Analysis (Interactive)](https://machinelearningplus.com/python/101-pandas-exercises-python-interactive/)<!-- HN:47367601:end --><!-- HN:47371749:start -->
* [47371749](https://news.social-protocols.org/stats?id=47371749) #12 79 points 40 comments -> [A Tiny Camera Revealed a Hidden Passage in the Great Pyramid](https://modernengineeringmarvels.com/2026/03/13/a-tiny-camera-revealed-a-hidden-passage-in-the-great-pyramid/)<!-- HN:47371749:end --><!-- HN:47372367:start -->
* [47372367](https://news.social-protocols.org/stats?id=47372367) #14 379 points 103 comments -> [JPEG Compression](https://www.sophielwang.com/blog/jpeg)<!-- HN:47372367:end --><!-- HN:47369883:start -->
* [47369883](https://news.social-protocols.org/stats?id=47369883) #30 313 points 47 comments -> [More than 135 open hardware devices flashable with your own firmware](https://openhardware.directory)<!-- HN:47369883:end --><!-- HN:47427271:start -->
* [47427271](https://news.social-protocols.org/stats?id=47427271) #13 17 points 8 comments -> [Wide logging: Stripe's canonical log line pattern](https://blog.alcazarsec.com/tech/posts/wide-logging)<!-- HN:47427271:end --><!-- HN:47427388:start -->
* [47427388](https://news.social-protocols.org/stats?id=47427388) #1 98 points 2 comments -> [A tiny, decentralised tool to explore the small web](https://codeberg.org/susam/wander)<!-- HN:47427388:end --><!-- HN:47378568:start -->
* [47378568](https://news.social-protocols.org/stats?id=47378568) #23 7 points 1 comments -> [A dither generator for triangular and hexagonal pixels (2025)](https://danieltemkin.com/DitherStudies)<!-- HN:47378568:end --><!-- HN:47427290:start -->
* [47427290](https://news.social-protocols.org/stats?id=47427290) #11 57 points 17 comments -> [Wander – A tiny, decentralised tool (just 2 files) to explore the small web](https://susam.net/wander/)<!-- HN:47427290:end --><!-- HN:47431428:start -->
* [47431428](https://news.social-protocols.org/stats?id=47431428) #28 11 points 1 comments -> [NYC High School Student Freed After 10 Months in ICE Detention](https://www.nytimes.com/2026/03/18/nyregion/nyc-high-school-student-ice-freed.html)<!-- HN:47431428:end --><!-- HN:47432522:start -->
* [47432522](https://news.social-protocols.org/stats?id=47432522) #1 -> [Website to post Claude fuck ups](https://claudedidwhat.wtf)<!-- HN:47432522:end -->
#### **Thursday, March 19, 2026**
<!-- HN:47433363:start -->
* [47433363](https://news.social-protocols.org/stats?id=47433363) #13 5 points 0 comments -> [Unplug ICE](https://unplugice.org/)<!-- HN:47433363:end --><!-- HN:47432540:start -->
* [47432540](https://news.social-protocols.org/stats?id=47432540) #29 7 points 0 comments -> [Shooting-Free Days Decline in Major U.S. Cities](https://www.publichealth.columbia.edu/news/shooting-free-days-decline-major-u-s-cities-new-metric-aims-building-sustained-periods-peace)<!-- HN:47432540:end --><!-- HN:47381834:start -->
* [47381834](https://news.social-protocols.org/stats?id=47381834) #21 24 points 7 comments -> [Your Framework Doesn't Matter](https://cemrehancavdar.com/2026/02/19/your-framework-may-not-matter/)<!-- HN:47381834:end --><!-- HN:47436453:start -->
* [47436453](https://news.social-protocols.org/stats?id=47436453) #2 56 points 17 comments -> [Translate Garry Tan's LinkedIn-speak to plain English](https://github.com/garrytan/gstack/pull/213)<!-- HN:47436453:end --><!-- HN:47385544:start -->
* [47385544](https://news.social-protocols.org/stats?id=47385544) #25 10 points 2 comments -> [The Operator That Dethroned a King: Python's Walrus Operator Story](https://techlife.blog/posts/the-operator-that-dethroned-a-king-pythons-walrus-operator-story/)<!-- HN:47385544:end --><!-- HN:47438716:start -->
* [47438716](https://news.social-protocols.org/stats?id=47438716) #16 155 points 79 comments -> [OpenAI to Acquire Astral](https://openai.com/index/openai-to-acquire-astral/)<!-- HN:47438716:end --><!-- HN:47441931:start -->
* [47441931](https://news.social-protocols.org/stats?id=47441931) #12 33 points 10 comments -> [Pentagon asks for $200bn for Iran War](https://www.bloomberg.com/news/articles/2026-03-19/hegseth-says-iran-war-not-becoming-a-forever-war-or-quagmire)<!-- HN:47441931:end --><!-- HN:47399803:start -->
* [47399803](https://news.social-protocols.org/stats?id=47399803) #16 5 points 1 comments -> [55-Mile Chevy Squarebody Still Wrapped in Factory Plastic Sells for $100K](https://www.thedrive.com/news/55-mile-chevy-squarebody-still-wrapped-in-factory-plastic-sells-for-100k)<!-- HN:47399803:end --><!-- HN:47438001:start -->
* [47438001](https://news.social-protocols.org/stats?id=47438001) #22 368 points 3 comments -> [Afroman Wins Civil Trial over Use of Police Raid Footage in His Music Videos](https://www.nytimes.com/2026/03/19/us/afroman-trial-lemon-cake-verdict.html)<!-- HN:47438001:end --><!-- HN:47443175:start -->
* [47443175](https://news.social-protocols.org/stats?id=47443175) #23 -> [US has "lost control of its own foreign policy", Oman says](https://www.theguardian.com/world/2026/mar/19/us-lost-control-of-its-own-foreign-policy-oman-foreign-minister)<!-- HN:47443175:end --><!-- HN:47388293:start -->
* [47388293](https://news.social-protocols.org/stats?id=47388293) #23 83 points 16 comments -> [Pretraining Language Models via Neural Cellular Automata](https://hanseungwook.github.io/blog/nca-pre-pre-training/)<!-- HN:47388293:end --><!-- HN:47388658:start -->
* [47388658](https://news.social-protocols.org/stats?id=47388658) #27 449 points 127 comments -> [Nvidia greenboost: transparently extend GPU VRAM using system RAM/NVMe](https://gitlab.com/IsolatedOctopi/nvidia_greenboost)<!-- HN:47388658:end --><!-- HN:47385439:start -->
* [47385439](https://news.social-protocols.org/stats?id=47385439) #29 167 points 93 comments -> [LotusNotes](https://computer.rip/2026-03-14-lotusnotes.html)<!-- HN:47385439:end --><!-- HN:47442215:start -->
* [47442215](https://news.social-protocols.org/stats?id=47442215) #27 63 points 18 comments -> [Love of corporate bullshit is correlated with bad judgment](https://pluralistic.net/2026/03/19/jargon-watch/)<!-- HN:47442215:end -->
#### **Friday, March 20, 2026**
<!-- HN:47406731:start -->
* [47406731](https://news.social-protocols.org/stats?id=47406731) #23 6 points 1 comments -> [I built a clip-on muscle sensor so personal trainers can show clients progress](https://inara.technology)<!-- HN:47406731:end --><!-- HN:47450514:start -->
* [47450514](https://news.social-protocols.org/stats?id=47450514) #25 9 points 2 comments -> [Kin: Semantic version control that tracks code as entities, not files](https://github.com/firelock-ai/kin)<!-- HN:47450514:end --><!-- HN:47452828:start -->
* [47452828](https://news.social-protocols.org/stats?id=47452828) #14 42 points 31 comments -> [3M's PFAS exit killed the supply chain for two-phase immersion cooling in DCs](https://thecoolingreport.com/intel.html)<!-- HN:47452828:end --><!-- HN:47453728:start -->
* [47453728](https://news.social-protocols.org/stats?id=47453728) #5 7 points 6 comments -> [The 12" chef knife, a humble plea](https://kellykozakandjoshdonald.substack.com/p/the-12-chef-knife-a-humble-plea)<!-- HN:47453728:end --><!-- HN:47454241:start -->
* [47454241](https://news.social-protocols.org/stats?id=47454241) #25 12 points 21 comments -> [Nvidia's Huang pitches AI tokens on top of salary](https://www.cnbc.com/2026/03/20/nvidia-ai-agents-tokens-human-workers-engineer-jobs-unemployment-jensen-huang.html)<!-- HN:47454241:end --><!-- HN:47457929:start -->
* [47457929](https://news.social-protocols.org/stats?id=47457929) #9 34 points 7 comments -> [US to deploy additional troops to the Middle East, officials say](https://www.reuters.com/world/us-deploy-thousands-additional-troops-middle-east-officials-say-2026-03-20/)<!-- HN:47457929:end --><!-- HN:47459969:start -->
* [47459969](https://news.social-protocols.org/stats?id=47459969) #11 24 points 9 comments -> [Time to Dump Windows?](https://dennisforbes.ca/blog/microblog/2026/02/time_to_dump_windows/)<!-- HN:47459969:end -->
#### **Saturday, March 21, 2026**
<!-- HN:47462298:start -->
* [47462298](https://news.social-protocols.org/stats?id=47462298) #9 28 points 21 comments -> [Why I'm Not Worried About Running Out of Work in the Age of AI](https://kellblog.com/2026/03/19/why-im-not-worried-about-running-out-of-work-in-the-age-of-ai/)<!-- HN:47462298:end -->