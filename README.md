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

#### **Wednesday, March 11, 2026**
<!-- HN:47331708:start -->
* [47331708](https://news.social-protocols.org/stats?id=47331708) #11 13 points 1 comments -> [Sergey Brin Funds Misleading Ballot Measure to Negate Wealth Tax](https://prospect.org/2026/03/10/google-brin-california-wealth-tax-ballot-measure/)<!-- HN:47331708:end --><!-- HN:47332939:start -->
* [47332939](https://news.social-protocols.org/stats?id=47332939) #1 29 points 41 comments -> [Why does AI tell you to use Terminal so much?](https://eclecticlight.co/2026/03/11/why-does-ai-tell-you-to-use-terminal-so-much/)<!-- HN:47332939:end --><!-- HN:47275743:start -->
* [47275743](https://news.social-protocols.org/stats?id=47275743) #21 14 points 18 comments -> [Docs directories are doomed](https://yagmin.com/blog/your-docs-directory-is-doomed/)<!-- HN:47275743:end --><!-- HN:47290574:start -->
* [47290574](https://news.social-protocols.org/stats?id=47290574) #26 12 points 7 comments -> [CAP theorem – Partition is a verb](http://mmudama.github.io/posts/2026/cap-partitions/)<!-- HN:47290574:end --><!-- HN:47291258:start -->
* [47291258](https://news.social-protocols.org/stats?id=47291258) #12 7 points 2 comments -> [Show HN: Custom Git-receive-pack implementation](https://github.com/runxiyu/furgit/tree/master/cmd/receivepack9418)<!-- HN:47291258:end --><!-- HN:47296163:start -->
* [47296163](https://news.social-protocols.org/stats?id=47296163) #11 10 points 2 comments -> [Show HN: I wrote down every expensive hardware development mistake I've seen](https://thehardesthardwarelessons.com/)<!-- HN:47296163:end --><!-- HN:47338445:start -->
* [47338445](https://news.social-protocols.org/stats?id=47338445) #18 23 points 20 comments -> [Why Do They Want to Get Rid of Software Engineers?](https://jrswab.com/blog/why-do-they-want-to-get-rid-of-software-engineers/)<!-- HN:47338445:end --><!-- HN:47338960:start -->
* [47338960](https://news.social-protocols.org/stats?id=47338960) #16 6 points 1 comments -> [Medical technology company in Michigan hit by suspected Iran-linked cyberattack](https://www.fox17online.com/news/local-news/kzoo-bc/kalamazoo/stryker-headquarters-in-portage-closes-amid-reported-cyber-attack-affecting-global-systems)<!-- HN:47338960:end --><!-- HN:47339888:start -->
* [47339888](https://news.social-protocols.org/stats?id=47339888) #12 80 points 38 comments -> [Hisense TVs force owners to watch intrusive ads](https://www.tomshardware.com/tech-industry/big-tech/hisense-tvs-force-owners-to-watch-intrusive-ads-when-switching-inputs-visiting-the-home-screen-or-even-changing-channels-practice-infuriates-consumers-brand-denies-wrongdoing)<!-- HN:47339888:end --><!-- HN:47339763:start -->
* [47339763](https://news.social-protocols.org/stats?id=47339763) #30 11 points 2 comments -> [Nvidia Releases NemoClaw – Enterprise AI Agents, Redefined](https://nemoclaw.bot)<!-- HN:47339763:end --><!-- HN:47343112:start -->
* [47343112](https://news.social-protocols.org/stats?id=47343112) #15 15 points 7 comments -> [NemoClaw – Nvidia's upcoming open-source AI agent platform](https://nemoclaw.bot)<!-- HN:47343112:end -->
#### **Thursday, March 12, 2026**<!-- HN:47346383:start -->
* [47346383](https://news.social-protocols.org/stats?id=47346383) #15 26 points 8 comments -> [US intelligence says Iran government is not at risk of collapse](https://www.reuters.com/business/media-telecom/us-intelligence-says-iran-government-is-not-risk-collapse-say-sources-2026-03-11/)<!-- HN:47346383:end --><!-- HN:47348573:start -->
* [47348573](https://news.social-protocols.org/stats?id=47348573) #30 3 points 0 comments -> [Independent Geophysical Forensic Analysis of the Nordstream Pipeline Sabotage](https://www.geophysical-forensics.ch/nordstream.html)<!-- HN:47348573:end --><!-- HN:47350341:start -->
* [47350341](https://news.social-protocols.org/stats?id=47350341) #25 7 points 0 comments -> [At Least 17 U.S. Sites Damaged in War with Iran, Analysis Shows](https://www.nytimes.com/interactive/2026/03/11/world/middleeast/iran-us-military-bases-strikes-map.html)<!-- HN:47350341:end --><!-- HN:47350252:start -->
* [47350252](https://news.social-protocols.org/stats?id=47350252) #21 14 points 29 comments -> [Show HN: I built an SDK that scrambles HTML so scrapers get garbage](https://www.obscrd.dev/)<!-- HN:47350252:end --><!-- HN:47350467:start -->
* [47350467](https://news.social-protocols.org/stats?id=47350467) #24 45 points 41 comments -> [USDA is closing buildings, relocating staff, and downsizing-a lot](https://www.foodpolitics.com/2026/03/usda-is-closing-buildings-relocating-staff-and-downsizing-a-lot/)<!-- HN:47350467:end --><!-- HN:47352819:start -->
* [47352819](https://news.social-protocols.org/stats?id=47352819) #20 42 points 12 comments -> [Another DOGE staffer explaining how he flagged grants at NEH for "DEI"](https://bsky.app/profile/404media.co/post/3mgupw4v3ak2j)<!-- HN:47352819:end --><!-- HN:47353293:start -->
* [47353293](https://news.social-protocols.org/stats?id=47353293) #7 8 points 0 comments -> [We will come to regret our every use of AI](https://libresolutions.network/articles/ai-regret/)<!-- HN:47353293:end --><!-- HN:47353981:start -->
* [47353981](https://news.social-protocols.org/stats?id=47353981) #28 16 points 10 comments -> [Show HN: LogClaw – Open-source AI SRE that auto-creates tickets from logs](https://logclaw.ai)<!-- HN:47353981:end --><!-- HN:47355213:start -->
* [47355213](https://news.social-protocols.org/stats?id=47355213) #9 30 points 16 comments -> [Show HN: Aurion OS – A 32-bit GUI operating system written from scratch in C](https://github.com/Luka12-dev/AurionOS)<!-- HN:47355213:end --><!-- HN:47357294:start -->
* [47357294](https://news.social-protocols.org/stats?id=47357294) #3 33 points 11 comments -> [Illinois introduces OS-level age verification law](https://legiscan.com/IL/bill/SB3977/2025)<!-- HN:47357294:end --><!-- HN:47358033:start -->
* [47358033](https://news.social-protocols.org/stats?id=47358033) #10 4 points 0 comments -> [Qodo Outperforms Claude in Code Review Benchmark](https://www.qodo.ai/blog/qodo-outperforms-claude-in-code-review-benchmark/)<!-- HN:47358033:end -->
#### **Friday, March 13, 2026**
<!-- HN:47359136:start -->
* [47359136](https://news.social-protocols.org/stats?id=47359136) #2 91 points 16 comments -> [Tennessee grandmother jailed after AI face recognition error links her to fraud](https://www.theguardian.com/us-news/2026/mar/12/tennessee-grandmother-ai-fraud)<!-- HN:47359136:end --><!-- HN:47363901:start -->
* [47363901](https://news.social-protocols.org/stats?id=47363901) #2 48 points 22 comments -> [301M Records Exposed: The HIPAA Breach Epidemic](https://ciphercue.com/blog/hipaa-breach-epidemic-301-million-records)<!-- HN:47363901:end --><!-- HN:47364829:start -->
* [47364829](https://news.social-protocols.org/stats?id=47364829) #4 6 points 0 comments -> [Four crew members killed after US refuelling plane crashes in Iraq](https://www.bbc.com/news/articles/cy0dz5ql17vo)<!-- HN:47364829:end --><!-- HN:47366400:start -->
* [47366400](https://news.social-protocols.org/stats?id=47366400) #1 64 points 3 comments -> [Channel Surfer – Watch YouTube Like It's Cable TV](https://channelsurfer.tv/)<!-- HN:47366400:end --><!-- HN:47365597:start -->
* [47365597](https://news.social-protocols.org/stats?id=47365597) #5 190 points 24 comments -> [Meta Platforms: Lobbying, Dark Money, and the App Store Accountability Act](https://github.com/upper-up/meta-lobbying-and-other-findings)<!-- HN:47365597:end --><!-- HN:47365461:start -->
* [47365461](https://news.social-protocols.org/stats?id=47365461) #25 40 points 3 comments -> [Two long-lost episodes of 'Doctor Who' have been found](https://apnews.com/article/doctor-who-lost-episodes-found-daleks-6849b09faa6eca9377b2a0db45d47ff8)<!-- HN:47365461:end --><!-- HN:47367291:start -->
* [47367291](https://news.social-protocols.org/stats?id=47367291) #26 6 points 0 comments -> [ECJ says EU states must change gender of citizens even if nat'l laws forbid it](https://brusselssignal.eu/2026/03/ecj-says-member-states-must-change-gender-of-citizens-even-if-national-laws-forbid-it/)<!-- HN:47367291:end -->
#### **Saturday, March 14, 2026**
<!-- HN:47371486:start -->
* [47371486](https://news.social-protocols.org/stats?id=47371486) #3 18 points 2 comments -> ["Added 1M context window for Opus 4.6 by default for Max, Team, and Enterprise"](https://raw.githubusercontent.com/anthropics/claude-code/refs/heads/main/CHANGELOG.md)<!-- HN:47371486:end --><!-- HN:47310815:start -->
* [47310815](https://news.social-protocols.org/stats?id=47310815) #10 58 points 5 comments -> [Coding My Handwriting](https://www.amygoodchild.com/blog/cursive-handwriting-in-javascript)<!-- HN:47310815:end --><!-- HN:47310591:start -->
* [47310591](https://news.social-protocols.org/stats?id=47310591) #23 6 points 2 comments -> [Show HN: Robotics runtime in the browser (flight controller, WebAssembly)](https://cdn.copper-robotics.com/demo/flight-controller/index.html)<!-- HN:47310591:end --><!-- HN:47309397:start -->
* [47309397](https://news.social-protocols.org/stats?id=47309397) #30 243 points 46 comments -> [Okmain: How to pick an OK main colour of an image](https://dgroshev.com/blog/okmain/)<!-- HN:47309397:end --><!-- HN:47374676:start -->
* [47374676](https://news.social-protocols.org/stats?id=47374676) #1 61 points 10 comments -> [Age Verification Lobbying: Dark Money, Model Legislation, Institutional Capture](https://tboteproject.com)<!-- HN:47374676:end --><!-- HN:47375008:start -->
* [47375008](https://news.social-protocols.org/stats?id=47375008) #9 9 points 7 comments -> [UCP Protocol: The Internet Has 100M Shops and No Front Door](https://askucp.com/blog)<!-- HN:47375008:end --><!-- HN:47374958:start -->
* [47374958](https://news.social-protocols.org/stats?id=47374958) #22 8 points 3 comments -> [Show HN: AgentArmor – open-source 8-layer security framework for AI agents](https://github.com/Agastya910/agentarmor)<!-- HN:47374958:end --><!-- HN:47378946:start -->
* [47378946](https://news.social-protocols.org/stats?id=47378946) #5 5 points 0 comments -> [The United States of Eugenics](https://conversationalist.org/2025/04/17/united-states-america-eugenics-politics-policy-race-science-disablism-transphobia-racism-xenophobia-trump-immigration/)<!-- HN:47378946:end --><!-- HN:47379391:start -->
* [47379391](https://news.social-protocols.org/stats?id=47379391) #11 32 points 7 comments -> [Digg.com Closing Due to Spam](https://digg.com?hn)<!-- HN:47379391:end --><!-- HN:47380530:start -->
* [47380530](https://news.social-protocols.org/stats?id=47380530) #29 4 points 1 comments -> [Jürgen Habermas, influential German philosopher, dies at 96](https://www.washingtonpost.com/world/2026/03/14/juergen-habermas-dead-germany/8b2c0bc0-1fb0-11f1-a29c-fd43da9a479a_story.html)<!-- HN:47380530:end --><!-- HN:47380637:start -->
* [47380637](https://news.social-protocols.org/stats?id=47380637) #12 3 points 0 comments -> [I rebuilt a daily habit because the default experience felt broken](https://apps.apple.com/us/app/brzzy-weather-local-forecasts/id6670187343)<!-- HN:47380637:end --><!-- HN:47381336:start -->
* [47381336](https://news.social-protocols.org/stats?id=47381336) #18 5 points 4 comments -> [Cursor billed us $450 for a seat that existed for seconds](https://cursor.com)<!-- HN:47381336:end --><!-- HN:47381261:start -->
* [47381261](https://news.social-protocols.org/stats?id=47381261) #22 54 points 8 comments -> [Jared Kushner Solicits Funds for His Firm While Working as Mideast Envoy](https://www.nytimes.com/2026/03/13/business/jared-kushner-affinity-mideast-funds.html)<!-- HN:47381261:end -->
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
* [47407846](https://news.social-protocols.org/stats?id=47407846) #6 9 points 0 comments -> [Every 8 minutes, a case of sexual assault/misconduct was reported to Uber](https://every8minutes.com)<!-- HN:47407846:end -->