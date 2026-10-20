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

#### **Wednesday, October 14, 2026**<!-- HN:50085259:start -->
* [50085259](https://news.social-protocols.org/stats?id=50085259) #29 42 points 40 comments -> [Agent erased full season of "The Challenge Swe": "Hundreds of days of work gone"](https://www.aviaduct.com/?l=og+en&u=https%3A%2F%2Fwww.aftonbladet.se%2Fnojesbladet%2Fa%2F31oE8A%2Fthe-challenge-sverige-raderad-av-ai-bara-veckor-innan-premiaren)<!-- HN:50085259:end --><!-- HN:50085547:start -->
* [50085547](https://news.social-protocols.org/stats?id=50085547) #6 17 points 4 comments -> [The road we were told not to take](https://www.aspendailynews.com/opinion/whiting-the-road-we-were-told-not-to-take-0b9fd0a3?taid=6acba476a2e9090001ef1611&utm_campaign=trueanthem&utm_medium=social&utm_source=twitter)<!-- HN:50085547:end --><!-- HN:50087140:start -->
* [50087140](https://news.social-protocols.org/stats?id=50087140) #3 18 points 1 comments -> [Meta is meddling with Brazilian democracy](https://paydayreport.com/meta-censors-over-1-080-pro-lula-accounts-during-brazilian-presidential-election/)<!-- HN:50087140:end --><!-- HN:50089624:start -->
* [50089624](https://news.social-protocols.org/stats?id=50089624) #29 25 points 3 comments -> [Shit Flow Diagram](https://en.wikipedia.org/wiki/Shit_flow_diagram)<!-- HN:50089624:end --><!-- HN:50093445:start -->
* [50093445](https://news.social-protocols.org/stats?id=50093445) #9 9 points 2 comments -> [Back to School, in Gaza](https://www.newyorker.com/news/the-lede/back-to-school-in-gaza)<!-- HN:50093445:end --><!-- HN:50093298:start -->
* [50093298](https://news.social-protocols.org/stats?id=50093298) #10 9 points 0 comments -> [Private equity ownership affects dental practices](https://www.dentaleconomics.com/macro-op-ed/industry-news/news/55341670/how-does-private-equity-ownership-really-affect-dental-practices)<!-- HN:50093298:end --><!-- HN:50092847:start -->
* [50092847](https://news.social-protocols.org/stats?id=50092847) #18 141 points 63 comments -> [How the Military Will Hack the Election](https://www.kenklippenstein.com/p/how-the-military-will-hack-the-election)<!-- HN:50092847:end --><!-- HN:50096334:start -->
* [50096334](https://news.social-protocols.org/stats?id=50096334) #5 11 points 0 comments -> [Anthropic revenue jumps to $16.8B in third quarter, claims profitable](https://www.reuters.com/technology/anthropic-revenue-jumps-168-billion-third-quarter-ft-reports-2026-10-14/)<!-- HN:50096334:end --><!-- HN:50096485:start -->
* [50096485](https://news.social-protocols.org/stats?id=50096485) #22 11 points 2 comments -> [Problems with the Rust Language](https://oxetene.net/problems-with-the-rust-language/)<!-- HN:50096485:end -->
#### **Thursday, October 15, 2026**
<!-- HN:50097811:start -->
* [50097811](https://news.social-protocols.org/stats?id=50097811) #23 5 points 2 comments -> [Capsem – a Rust hypervisor sandboxing AI agents in air-gapped Linux VMs](https://capsem.org/)<!-- HN:50097811:end --><!-- HN:50098702:start -->
* [50098702](https://news.social-protocols.org/stats?id=50098702) #2 44 points 1 comments -> [Future of Cancer Care Today (FCCT)](https://sijbrandijfoundation.org/fcct)<!-- HN:50098702:end --><!-- HN:50101149:start -->
* [50101149](https://news.social-protocols.org/stats?id=50101149) #3 34 points 40 comments -> [The cost of getting a job today](https://weli.dev/blog/the-cost-of-getting-a-job-today/)<!-- HN:50101149:end --><!-- HN:50102689:start -->
* [50102689](https://news.social-protocols.org/stats?id=50102689) #3 -> [ICE Kills More Americans Than Illegal Immigrants](https://hughhowey.com/ice-kills-more-americans-than-illegal-immigrants/)<!-- HN:50102689:end --><!-- HN:50102854:start -->
* [50102854](https://news.social-protocols.org/stats?id=50102854) #25 44 points 41 comments -> [X purges 13,000 accounts linked to suspected meddling ahead of US midterms](https://www.theregister.com/security/2026/10/15/x-purges-13000-accounts-linked-to-suspected-meddling-ahead-of-us-midterms/5303234)<!-- HN:50102854:end --><!-- HN:50103090:start -->
* [50103090](https://news.social-protocols.org/stats?id=50103090) #18 10 points 1 comments -> [Hiring in tech is mostly bullshit](https://tej.as/blog/companies-are-full-of-it)<!-- HN:50103090:end --><!-- HN:50106620:start -->
* [50106620](https://news.social-protocols.org/stats?id=50106620) #17 67 points 5 comments -> [Muse Spark Open, the Most Capable US Open‑Weight Model to Date](https://research.meta.ai/blog/muse-spark-open)<!-- HN:50106620:end --><!-- HN:50106676:start -->
* [50106676](https://news.social-protocols.org/stats?id=50106676) #26 221 points 10 comments -> [An Israeli firm is sending zero-click spyware through online ads](https://www.theverge.com/tech/1011956/discover-tech-zero-click-ads-spyware)<!-- HN:50106676:end --><!-- HN:50103000:start -->
* [50103000](https://news.social-protocols.org/stats?id=50103000) #7 488 points 1 comments -> [Israeli firm's digital ads enabling installation of 'zero-click' spyware](https://www.theguardian.com/technology/2026/oct/15/israeli-firm-digital-ads-enabling-installation-of-zero-click-spyware-researchers-say)<!-- HN:50103000:end -->
#### **Friday, October 16, 2026**
<!-- HN:50113528:start -->
* [50113528](https://news.social-protocols.org/stats?id=50113528) #24 21 points 40 comments -> [Porsche Mission S](https://www.porsche.com/international/models/mission-s/)<!-- HN:50113528:end --><!-- HN:50116367:start -->
* [50116367](https://news.social-protocols.org/stats?id=50116367) #26 29 points 40 comments -> [Japanese people still aren't having sex. And nobody knows why](https://www.sciencefocus.com/news/japanese-people-sex-inactivity-inexperience)<!-- HN:50116367:end --><!-- HN:50118863:start -->
* [50118863](https://news.social-protocols.org/stats?id=50118863) #16 27 points 31 comments -> [Redesigning Source Control at Anthropic](https://simonwillison.net/2026/Oct/13/redesigning-source-control-at-anthropic/)<!-- HN:50118863:end --><!-- HN:50118950:start -->
* [50118950](https://news.social-protocols.org/stats?id=50118950) #28 9 points 2 comments -> [Show HN: Grimoire for Biology](https://grimoire.bio)<!-- HN:50118950:end --><!-- HN:50118624:start -->
* [50118624](https://news.social-protocols.org/stats?id=50118624) #18 63 points 89 comments -> [Tesla Unveils 'Flying' Roadster with SpaceX Thrusters [video]](https://www.youtube.com/watch?v=eqOfmtTJD1A)<!-- HN:50118624:end -->
#### **Saturday, October 17, 2026**
<!-- HN:50092655:start -->
* [50092655](https://news.social-protocols.org/stats?id=50092655) #2 21 points 1 comments -> [Ultramarine 1 Flash: Frontier Model 100X Cheaper](https://www.paperinstruments.com/ultramarine)<!-- HN:50092655:end --><!-- HN:50127732:start -->
* [50127732](https://news.social-protocols.org/stats?id=50127732) #10 7 points 0 comments -> [DeepSeek v4.1 flash on OpenCode pretty good](https://github.com/aditauqir/shev)<!-- HN:50127732:end --><!-- HN:50128297:start -->
* [50128297](https://news.social-protocols.org/stats?id=50128297) #28 44 points 9 comments -> [Israeli settlers attack olive framers & Washington Post journalist in West Bank](https://www.theguardian.com/world/2026/oct/16/israeli-settlers-attack-olive-farmers-west-bank-washington-post-journalist-heidi-levine)<!-- HN:50128297:end --><!-- HN:50129235:start -->
* [50129235](https://news.social-protocols.org/stats?id=50129235) #13 15 points 10 comments -> [Is MCP becoming the common foundation of smart, decentralised search?](https://contextetech.com/en/articles/mcp-protocol-smart-decentralised-search)<!-- HN:50129235:end --><!-- HN:50130442:start -->
* [50130442](https://news.social-protocols.org/stats?id=50130442) #15 10 points 3 comments -> [Show HN: Which Mac runs which LLM, and how fast](https://macyou.co/mac-llm-calculator)<!-- HN:50130442:end --><!-- HN:50129121:start -->
* [50129121](https://news.social-protocols.org/stats?id=50129121) #1 507 points 4 comments -> [DeepSeek: DeepSeek v4.1 Flash 1017](https://openrouter.ai/deepseek/deepseek-v4.1-flash-1017)<!-- HN:50129121:end --><!-- HN:50131881:start -->
* [50131881](https://news.social-protocols.org/stats?id=50131881) #6 49 points 10 comments -> [Ad-tech company was a delivery system for "mercenary spyware"](https://pluralistic.net/2026/10/17/mercenary-spyware/#discover-tech)<!-- HN:50131881:end --><!-- HN:50130570:start -->
* [50130570](https://news.social-protocols.org/stats?id=50130570) #5 86 points 146 comments -> [Super Intelligence](https://www.si.gov/)<!-- HN:50130570:end --><!-- HN:50132972:start -->
* [50132972](https://news.social-protocols.org/stats?id=50132972) #28 19 points 4 comments -> [Elon Musk's foundation is opaque, miserly and self-serving](https://www.economist.com/business/2026/10/13/elon-musks-foundation-is-opaque-miserly-and-self-serving)<!-- HN:50132972:end --><!-- HN:50133500:start -->
* [50133500](https://news.social-protocols.org/stats?id=50133500) #17 28 points 7 comments -> [Qwen3.8-27B on the iPhone 18 Neural Engine at 15–70 tok/s (1.5 bpw)](https://twitter.com/anemll/status/2111517143087067309)<!-- HN:50133500:end --><!-- HN:50133738:start -->
* [50133738](https://news.social-protocols.org/stats?id=50133738) #25 6 points 2 comments -> [Owner of Former UWS Barbecue Restaurant Indicted for Wage Theft: Manhattan DA](https://www.westsiderag.com/2026/10/08/owner-of-former-uws-barbecue-restaurant-indicted-for-wage-theft-manhattan-da)<!-- HN:50133738:end --><!-- HN:50133713:start -->
* [50133713](https://news.social-protocols.org/stats?id=50133713) #9 24 points 40 comments -> [AI Can Write the Code. Who Verifies It?](https://mihaisplace.com/blog/ai-can-write-the-code-who-verifies-it)<!-- HN:50133713:end --><!-- HN:50089727:start -->
* [50089727](https://news.social-protocols.org/stats?id=50089727) #17 7 points 6 comments -> [Almost every dumbphone worth knowing about](https://slowerliving.club/phones/)<!-- HN:50089727:end -->
#### **Sunday, October 18, 2026**
<!-- HN:50136881:start -->
* [50136881](https://news.social-protocols.org/stats?id=50136881) #1 417 points 211 comments -> [Zuckerberg's Meta Takes Down No Kings Instagram During Protest Day](https://meidasnews.com/news/zuckerbergs-meta-takes-down-no-kings-instagram-during-massive-protest-day)<!-- HN:50136881:end --><!-- HN:50137826:start -->
* [50137826](https://news.social-protocols.org/stats?id=50137826) #11 4 points 1 comments -> [My AI agent caught most of our sites saying sent while no email left the server](https://iampneuma.com/the-function-returned-true/)<!-- HN:50137826:end --><!-- HN:50138156:start -->
* [50138156](https://news.social-protocols.org/stats?id=50138156) #7 27 points 40 comments -> [The game industry is broken – can we fix it?](https://knowledge.edge-online.com/p/the-game-industry-is-broken-can-we-fix-it-tim-sweeney-edge-crash)<!-- HN:50138156:end --><!-- HN:50139658:start -->
* [50139658](https://news.social-protocols.org/stats?id=50139658) #10 13 points 2 comments -> [It's time to talk about TEEs](https://alinush.github.io//tee)<!-- HN:50139658:end --><!-- HN:50139935:start -->
* [50139935](https://news.social-protocols.org/stats?id=50139935) #14 25 points 40 comments -> [Kids are outsmarting social media bans. That's not a problem we need to solve](https://www.technologyreview.com/2026/10/16/1146834/kids-are-outsmarting-social-media-bans-thats-not-a-problem-we-need-to-solve/)<!-- HN:50139935:end --><!-- HN:50140638:start -->
* [50140638](https://news.social-protocols.org/stats?id=50140638) #25 6 points 11 comments -> [Germany's 17M Immigrants: Where They Come From](https://www.visualcapitalist.com/cp/where-germanys-immigrants-come-from/)<!-- HN:50140638:end --><!-- HN:50141206:start -->
* [50141206](https://news.social-protocols.org/stats?id=50141206) #11 79 points 25 comments -> [Theranos-Style Fraud Has Become the Norm](https://www.theatlantic.com/ideas/2026/10/theranos-trump-nathan-fielder/689001/)<!-- HN:50141206:end --><!-- HN:50142034:start -->
* [50142034](https://news.social-protocols.org/stats?id=50142034) #5 16 points 4 comments -> [Campus deplatformings hit record high](https://expression.fire.org/p/campus-deplatformings-hit-record)<!-- HN:50142034:end --><!-- HN:50103988:start -->
* [50103988](https://news.social-protocols.org/stats?id=50103988) #28 16 points 23 comments -> [They war-gamed dimming the Sun. It went worse than you think](https://www.wired.com/story/they-war-gamed-dimming-the-sun-it-went-even-worse-than-you-think/)<!-- HN:50103988:end -->
#### **Monday, October 19, 2026**
<!-- HN:50148396:start -->
* [50148396](https://news.social-protocols.org/stats?id=50148396) #18 22 points 6 comments -> [Show HN: Strot – Compile an LLM's intent once, run decisions locally forever](https://github.com/strot-ai/Project-STROT)<!-- HN:50148396:end --><!-- HN:50148882:start -->
* [50148882](https://news.social-protocols.org/stats?id=50148882) #3 15 points 6 comments -> [Agent-Skills.market](https://agent-skills.market/)<!-- HN:50148882:end --><!-- HN:50150908:start -->
* [50150908](https://news.social-protocols.org/stats?id=50150908) #4 10 points 4 comments -> [Show HN: I re-read the terms of 175 AI tools twice; 60% changed in 15 weeks](https://clipjury.com/guides/ai-tool-terms-changed-2026/)<!-- HN:50150908:end --><!-- HN:50152207:start -->
* [50152207](https://news.social-protocols.org/stats?id=50152207) #17 -> [Stripe will acquire OpenRouter for $7.5B](https://startupfortune.com/stripe-will-pay-75-billion-for-openrouter-the-ai-model-traffic-cop/)<!-- HN:50152207:end --><!-- HN:50151390:start -->
* [50151390](https://news.social-protocols.org/stats?id=50151390) #5 120 points 52 comments -> [Harness Engineering 101: The LLM is the brain, the harness is the body](https://github.com/IsuruMaduranga/harness-engineering-101)<!-- HN:50151390:end --><!-- HN:50153384:start -->
* [50153384](https://news.social-protocols.org/stats?id=50153384) #30 6 points 0 comments -> [WFP stops provision to half a million people in Gaza over lack of funding](https://www.middleeasteye.net/news/world-food-programme-stops-funding-half-million-people-gaza-over-lack-funding)<!-- HN:50153384:end --><!-- HN:50153598:start -->
* [50153598](https://news.social-protocols.org/stats?id=50153598) #20 7 points 4 comments -> [Kevin Bacon's missing clothes finally delivered in Ireland](https://www.rte.ie/entertainment/2026/1019/1595980-kevin-bacon/)<!-- HN:50153598:end --><!-- HN:50154060:start -->
* [50154060](https://news.social-protocols.org/stats?id=50154060) #21 25 points 42 comments -> [AI companies are coming for the plumbers](https://www.tomshardware.com/tech-industry/artificial-intelligence/ai-lab-offers-free-plumbing-and-hvac-repairs-across-three-cities-to-train-ai-robots-wearable-sensors-record-video-of-repair-work-for-robotics-training-free-services-also-include-electrical-work-air-duct-cleaning-and-carpet-cleaning)<!-- HN:50154060:end --><!-- HN:50155237:start -->
* [50155237](https://news.social-protocols.org/stats?id=50155237) #27 116 points 2 comments -> [Ukraine carries out first ever aerial drone evacuation of a wounded soldier](https://www.dailymail.com/news/article-16220441/Ukraine-carries-aerial-drone-evacuation-wounded-soldier-frontline.html)<!-- HN:50155237:end -->