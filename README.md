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
#### **Tuesday, October 20, 2026**
<!-- HN:50159464:start -->
* [50159464](https://news.social-protocols.org/stats?id=50159464) #21 35 points 37 comments -> [Token-maxxing is dead, OpenRouter's token usage plateaus](https://openrouter.ai/rankings)<!-- HN:50159464:end --><!-- HN:50159993:start -->
* [50159993](https://news.social-protocols.org/stats?id=50159993) #1 243 points 131 comments -> [Lula supporters protest against Meta to denounce its 'electoral interference'](https://efe.com/english/latest-news/2026-10-20/lula-supporters-protest-against-meta-to-denounce-its-electoral-interference/)<!-- HN:50159993:end --><!-- HN:50160289:start -->
* [50160289](https://news.social-protocols.org/stats?id=50160289) #1 60 points 32 comments -> [Novo Nordisk, Eli Lilly Report GLP-1 Signals of Slowed Biological Aging at ARDD](https://trial.medpath.com/news/novo-nordisk-and-eli-lilly-report-glp-1-signals-of-slowed-biological-aging-at-ardd)<!-- HN:50160289:end --><!-- HN:50160419:start -->
* [50160419](https://news.social-protocols.org/stats?id=50160419) #15 27 points 2 comments -> [OpenBSD 8.0: released Oct 20, 2026](https://marc.info/?l=openbsd-misc&m=179245849770356&w=2)<!-- HN:50160419:end --><!-- HN:50161505:start -->
* [50161505](https://news.social-protocols.org/stats?id=50161505) #26 24 points 40 comments -> [Americans Are Spending More Money to Drive Worse Cars](https://www.theatlantic.com/technology/2026/10/americans-not-buying-electric-cars/689071/)<!-- HN:50161505:end --><!-- HN:50162198:start -->
* [50162198](https://news.social-protocols.org/stats?id=50162198) #9 23 points 16 comments -> [Vite+ an excellent toolchain for AI agent development](https://janmichalek.com/blog/vite-plus-agentni-vyvoj?lang=en)<!-- HN:50162198:end --><!-- HN:50166918:start -->
* [50166918](https://news.social-protocols.org/stats?id=50166918) #6 4 points 0 comments -> [The Byzantine Generals Problem: A visual explanation](https://gravitypersists.github.io/exploring-byzantine-generals-problem/)<!-- HN:50166918:end --><!-- HN:50167523:start -->
* [50167523](https://news.social-protocols.org/stats?id=50167523) #21 5 points 0 comments -> [Building full-firm knowledge graphs to dramatically speed up agents](https://lexifina.com/blog/building-full-firm-knowledge-graphs-to-dramatically-speed-up-agents)<!-- HN:50167523:end --><!-- HN:50167524:start -->
* [50167524](https://news.social-protocols.org/stats?id=50167524) #22 18 points 23 comments -> [Getting Banned from r/java](https://sjhannah.com/blog/2026/05/30/getting-banned-from-r-java/)<!-- HN:50167524:end --><!-- HN:50168168:start -->
* [50168168](https://news.social-protocols.org/stats?id=50168168) #13 10 points 1 comments -> [OpenDE: Play Deus Ex 1999 demo in the browser](https://opende.netlify.app)<!-- HN:50168168:end --><!-- HN:50167456:start -->
* [50167456](https://news.social-protocols.org/stats?id=50167456) #21 6 points 2 comments -> [Show HN: Run Claude Code unattended inside a fence, under a dollar budget](https://github.com/metahumansworld/SIwithin)<!-- HN:50167456:end --><!-- HN:50169336:start -->
* [50169336](https://news.social-protocols.org/stats?id=50169336) #25 3 points 0 comments -> [Go Conventions That Clicked Too Late for an AI Engineer](https://towardsdev.com/10-go-conventions-that-clicked-too-late-for-an-ai-engineer-78319f2d538f?sk=5858de12ec208931b984d8f55436a7a2)<!-- HN:50169336:end --><!-- HN:50167560:start -->
* [50167560](https://news.social-protocols.org/stats?id=50167560) #30 6 points 1 comments -> [How to Link Real-Time Live Streaming to Video-on-Demand](https://www.red5.net/blog/how-to-link-real-time-live-streaming-to-video-on-demand/)<!-- HN:50167560:end --><!-- HN:50153229:start -->
* [50153229](https://news.social-protocols.org/stats?id=50153229) #16 43 points 7 comments -> [One Manhattan power room took down FAA air traffic control in 1991](https://matthorn.io/posts/2026-10-18-33-thomas-street/)<!-- HN:50153229:end --><!-- HN:50172809:start -->
* [50172809](https://news.social-protocols.org/stats?id=50172809) #15 10 points 1 comments -> [Third US aircraft carrier, 10k troops head to Middle East](https://www.iranintl.com/en/202610207766)<!-- HN:50172809:end -->
#### **Wednesday, October 21, 2026**
<!-- HN:50174448:start -->
* [50174448](https://news.social-protocols.org/stats?id=50174448) #17 8 points 7 comments -> [Microagi: Accelerating Embodied AGI](https://www.microagi.ai/)<!-- HN:50174448:end --><!-- HN:50175075:start -->
* [50175075](https://news.social-protocols.org/stats?id=50175075) #25 6 points 16 comments -> [T3 Code starting move to GitCafe](https://git.cafe/pingdotgg/t3code)<!-- HN:50175075:end --><!-- HN:50175063:start -->
* [50175063](https://news.social-protocols.org/stats?id=50175063) #18 7 points 0 comments -> [GitHub package firewall](https://github.blog/changelog/2026-10-20-github-package-firewall-in-public-preview/)<!-- HN:50175063:end --><!-- HN:50176508:start -->
* [50176508](https://news.social-protocols.org/stats?id=50176508) #25 8 points 3 comments -> [SaaS Is Dead](https://saasisdead.si/)<!-- HN:50176508:end --><!-- HN:50176351:start -->
* [50176351](https://news.social-protocols.org/stats?id=50176351) #14 21 points 17 comments -> [Alibaba hikes DeepSeek V4 Flash 0731 output prices by 230%](https://www.stork.ai/newsletter/2026-10-20-alibaba-quietly-tripled-deepseek-prices#lead)<!-- HN:50176351:end --><!-- HN:50178218:start -->
* [50178218](https://news.social-protocols.org/stats?id=50178218) #25 10 points 4 comments -> [Show HN: Linkit – AI bookmark manager, 100% free and open source](https://github.com/blue-idea/linkit)<!-- HN:50178218:end --><!-- HN:50179719:start -->
* [50179719](https://news.social-protocols.org/stats?id=50179719) #16 16 points 8 comments -> [Despite Iran's Attacks, Gulf Oil Exports Exceed Prewar Levels](https://maritime-executive.com/article/report-despite-iran-s-attacks-gulf-oil-exports-exceed-prewar-levels)<!-- HN:50179719:end --><!-- HN:50180518:start -->
* [50180518](https://news.social-protocols.org/stats?id=50180518) #23 10 points 2 comments -> [Global warming will breach 1.5°C – but deep, fast cuts can still bring it back](https://news.un.org/en/story/2026/10/1168634)<!-- HN:50180518:end --><!-- HN:50180943:start -->
* [50180943](https://news.social-protocols.org/stats?id=50180943) #2 261 points 103 comments -> [PHP 8.5.12, 8.4.27, 8.3.36 and 8.2.35 out](https://www.php.net/index.php)<!-- HN:50180943:end --><!-- HN:50181265:start -->
* [50181265](https://news.social-protocols.org/stats?id=50181265) #7 29 points 4 comments -> [Patch the Planet](https://patchtheplanet.org/)<!-- HN:50181265:end --><!-- HN:50181058:start -->
* [50181058](https://news.social-protocols.org/stats?id=50181058) #13 30 points 2 comments -> [PHP2Shell](https://www.php2shell.com)<!-- HN:50181058:end --><!-- HN:50179706:start -->
* [50179706](https://news.social-protocols.org/stats?id=50179706) #19 227 points 112 comments -> [Qwen3-Coder writes less secure code when told it's for a US persona](https://www.hirundo.io/blog/qwen3-coder-vulnerabilities)<!-- HN:50179706:end --><!-- HN:50185455:start -->
* [50185455](https://news.social-protocols.org/stats?id=50185455) #13 12 points 5 comments -> [Open Source Games](https://opensourcegames.dev/)<!-- HN:50185455:end --><!-- HN:50185438:start -->
* [50185438](https://news.social-protocols.org/stats?id=50185438) #14 45 points 41 comments -> [Anthropic's Public Benefit Charter](https://www.anthropic.com/public-benefit-charter)<!-- HN:50185438:end --><!-- HN:50186215:start -->
* [50186215](https://news.social-protocols.org/stats?id=50186215) #2 200 points 2 comments -> [Meta hit with $25B penalty for deceiving users about privacy on Facebook](https://nmdoj.gov/press-release/the-new-mexico-department-of-justice-secures-another-landmark-victory-against-big-tech-with-historic-25-billion-penalty-against-facebook/)<!-- HN:50186215:end --><!-- HN:50186129:start -->
* [50186129](https://news.social-protocols.org/stats?id=50186129) #19 312 points 90 comments -> [Mistral Large 4](https://mistral.ai/news/mistral-large-4/)<!-- HN:50186129:end -->
#### **Thursday, October 22, 2026**
<!-- HN:50189666:start -->
* [50189666](https://news.social-protocols.org/stats?id=50189666) #26 27 points 11 comments -> [The era of speedball capitalism has dawned](https://www.economist.com/business/2026/09/30/the-era-of-speedball-capitalism-has-dawned)<!-- HN:50189666:end --><!-- HN:50151971:start -->
* [50151971](https://news.social-protocols.org/stats?id=50151971) #30 11 points 20 comments -> [Honey, I shrunk the TV](https://cakehonolulu.github.io/honey-i-shrunk-the-tv/)<!-- HN:50151971:end -->