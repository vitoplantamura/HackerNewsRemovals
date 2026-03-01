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

#### **Monday, February 23, 2026**
<!-- HN:47046124:start -->
* [47046124](https://news.social-protocols.org/stats?id=47046124) #14 13 points 0 comments -> [Browse Code by Meaning](https://haskellforall.com/2026/02/browse-code-by-meaning)<!-- HN:47046124:end --><!-- HN:47046433:start -->
* [47046433](https://news.social-protocols.org/stats?id=47046433) #30 32 points 49 comments -> [Write-Only Code](https://www.heavybit.com/library/article/write-only-code)<!-- HN:47046433:end --><!-- HN:47116385:start -->
* [47116385](https://news.social-protocols.org/stats?id=47116385) #23 33 points 19 comments -> [IT Staffing Firms (TCS, Cognizant, Infosis Underpay Developers by 80–100%](https://h1bdatahub.com/blog/cognizant-tcs-infosys-low-h1b-salaries-exposed)<!-- HN:47116385:end --><!-- HN:47117521:start -->
* [47117521](https://news.social-protocols.org/stats?id=47117521) #15 9 points 0 comments -> [LGP to take Mister Car Wash private in $3.1B deal](https://www.alternativeswatch.com/2026/02/22/lgp-take-mister-car-wash-private-3-1-billion-deal/)<!-- HN:47117521:end --><!-- HN:47117972:start -->
* [47117972](https://news.social-protocols.org/stats?id=47117972) #10 16 points 3 comments -> [Show HN: Openslack – An open source version of Slack](https://github.com/BilalG1/openslack)<!-- HN:47117972:end --><!-- HN:47117681:start -->
* [47117681](https://news.social-protocols.org/stats?id=47117681) #21 5 points 4 comments -> [Show HN: I scraped 5,700 YC companies to find what niches are now getting funded](https://bigideasdb.com/saas-sellers-report)<!-- HN:47117681:end --><!-- HN:47073674:start -->
* [47073674](https://news.social-protocols.org/stats?id=47073674) #14 5 points 1 comments -> [What size should I use for my queue](https://www.syntacticbrownsugar.tech/posts/what-size-queue/)<!-- HN:47073674:end --><!-- HN:47118338:start -->
* [47118338](https://news.social-protocols.org/stats?id=47118338) #30 9 points 1 comments -> [Compulsively violent people might have lower IQs](https://www.psypost.org/people-who-engage-in-impulsive-violence-tend-to-have-lower-iq-scores/)<!-- HN:47118338:end --><!-- HN:47074049:start -->
* [47074049](https://news.social-protocols.org/stats?id=47074049) #19 22 points 5 comments -> [Cursor's Debug Mode Is Arguably Its Best Feature](https://davidgomes.com/cursor-debug-mode/)<!-- HN:47074049:end --><!-- HN:47087443:start -->
* [47087443](https://news.social-protocols.org/stats?id=47087443) #21 6 points 2 comments -> [The Oracle of Bacon: Thirty Years Later](https://3quarksdaily.com/3quarksdaily/2026/02/the-oracle-of-bacon-thirty-years-later.html)<!-- HN:47087443:end --><!-- HN:47121442:start -->
* [47121442](https://news.social-protocols.org/stats?id=47121442) #12 29 points 8 comments -> [I Donut Believe – Presenting Third Party Results (Donut Lab)](https://idonutbelieve.com/)<!-- HN:47121442:end --><!-- HN:47120901:start -->
* [47120901](https://news.social-protocols.org/stats?id=47120901) #19 39 points 41 comments -> [Don't host email yourself – your reminder in 2026](https://www.coinerella.com/dont-host-email-yourself-your-reminder-in-2026/)<!-- HN:47120901:end --><!-- HN:47124974:start -->
* [47124974](https://news.social-protocols.org/stats?id=47124974) #6 29 points 3 comments -> [Federal Gov Trafficking Pregnant Children to Texas So They Can't Get Abortions](https://www.throughline.news/p/the-trump-administration-is-trafficking)<!-- HN:47124974:end --><!-- HN:47126851:start -->
* [47126851](https://news.social-protocols.org/stats?id=47126851) #24 10 points 2 comments -> [Waymo Is Destroying Tesla's Self-Driving Dreams](https://neuralfoundry.substack.com/p/waymo-is-destroying-teslas-self-driving)<!-- HN:47126851:end --><!-- HN:47126656:start -->
* [47126656](https://news.social-protocols.org/stats?id=47126656) #30 20 points 14 comments -> [Show HN: Shibuya – A High-Performance WAF in Rust with eBPF and ML Engine](https://ghostklan.com/shibuya.html)<!-- HN:47126656:end --><!-- HN:47129696:start -->
* [47129696](https://news.social-protocols.org/stats?id=47129696) #21 21 points 1 comments -> [US ambassador to France banned from meeting French government](https://www.reuters.com/world/us-ambassador-france-banned-meeting-french-government-2026-02-23/)<!-- HN:47129696:end --><!-- HN:47129415:start -->
* [47129415](https://news.social-protocols.org/stats?id=47129415) #9 32 points 10 comments -> [AI-powered reverse-engineering of Rosetta 2 for Linux](https://github.com/Inokinoki/attesor)<!-- HN:47129415:end --><!-- HN:47130304:start -->
* [47130304](https://news.social-protocols.org/stats?id=47130304) #28 6 points 0 comments -> [Sam Altman's anti-human worldview](https://disconnect.blog/sam-altmans-anti-human-worldview/)<!-- HN:47130304:end -->
#### **Tuesday, February 24, 2026**
<!-- HN:47131219:start -->
* [47131219](https://news.social-protocols.org/stats?id=47131219) #27 13 points 20 comments -> [Psychology suggests making a shopping list is a sign of sharper thinking](https://economictimes.indiatimes.com/news/international/us/still-making-a-shopping-list-psychology-suggests-its-a-sign-of-sharper-thinking/articleshow/127796018.cms?from=mdr)<!-- HN:47131219:end --><!-- HN:47132012:start -->
* [47132012](https://news.social-protocols.org/stats?id=47132012) #30 8 points 4 comments -> [Dow tumbles more than 800 points as tariff uncertainty and AI disruption fears](https://www.cnn.com/2026/02/23/investing/us-stocks-trump-tariffs)<!-- HN:47132012:end --><!-- HN:47084622:start -->
* [47084622](https://news.social-protocols.org/stats?id=47084622) #8 10 points 4 comments -> [GPU Rack Power Density, 2015–2025](https://syaala.com/blog/gpu-rack-density-timeline-2026)<!-- HN:47084622:end --><!-- HN:47132001:start -->
* [47132001](https://news.social-protocols.org/stats?id=47132001) #13 16 points 3 comments -> [I Turned Off ChatGPT's Memory](https://every.to/also-true-for-humans/why-i-turned-off-chatgpt-s-memory)<!-- HN:47132001:end --><!-- HN:47134063:start -->
* [47134063](https://news.social-protocols.org/stats?id=47134063) #3 20 points 4 comments -> [The Engine Behind the Hype](https://www.onuruzunismail.com/blog/the-engine-behind-the-hype)<!-- HN:47134063:end --><!-- HN:47079208:start -->
* [47079208](https://news.social-protocols.org/stats?id=47079208) #10 86 points 22 comments -> [Baby chicks pass the bouba-kiki test, challenging a theory of language evolution](https://www.scientificamerican.com/article/baby-chicks-pass-the-bouba-kiki-test-challenging-a-theory-of-language/)<!-- HN:47079208:end --><!-- HN:47124325:start -->
* [47124325](https://news.social-protocols.org/stats?id=47124325) #30 110 points 27 comments -> [C99 implementation of new O(m log^(2/3) n) shortest path algorithm](https://github.com/danalec/DMMSY-SSSP)<!-- HN:47124325:end --><!-- HN:47136553:start -->
* [47136553](https://news.social-protocols.org/stats?id=47136553) #2 33 points 19 comments -> [Show HN: SNKV – SQLite's B-tree as a key-value store (C/C++ and Python bindings)](https://github.com/hash-anu/snkv)<!-- HN:47136553:end --><!-- HN:47137907:start -->
* [47137907](https://news.social-protocols.org/stats?id=47137907) #30 9 points 2 comments -> [Trump Fake Electors Plot](https://en.wikipedia.org/wiki/Trump_fake_electors_plot)<!-- HN:47137907:end --><!-- HN:47139916:start -->
* [47139916](https://news.social-protocols.org/stats?id=47139916) #15 4 points 3 comments -> [Will the U.S. confirm that aliens exist before 2027? (27%)](https://kalshi.com/markets/kxaliens/aliens/kxaliens-27)<!-- HN:47139916:end --><!-- HN:47090261:start -->
* [47090261](https://news.social-protocols.org/stats?id=47090261) #21 11 points 0 comments -> [The 7-Year Bug That Took 3 Minutes to Fix](https://agilitza.com/blog/the-7-year-bug-that-took-3-minutes-to-fix/)<!-- HN:47090261:end --><!-- HN:47088711:start -->
* [47088711](https://news.social-protocols.org/stats?id=47088711) #23 6 points 1 comments -> [Variable interpolatable smooth curves and outlines](https://thottingal.in/blog/2026/02/20/var-interpolatable-smooth-curves/)<!-- HN:47088711:end -->
#### **Wednesday, February 25, 2026**
<!-- HN:47145640:start -->
* [47145640](https://news.social-protocols.org/stats?id=47145640) #12 6 points 0 comments -> [Democracy in 2025: on rising authoritarianism in the United States](https://www.hks.harvard.edu/faculty-research/policy-topics/democracy-governance/harvard-experts-discuss-competitive)<!-- HN:47145640:end --><!-- HN:47077215:start -->
* [47077215](https://news.social-protocols.org/stats?id=47077215) #7 96 points 41 comments -> [Justifying Text-Wrap: Pretty](https://matklad.github.io/2026/02/14/justifying-text-wrap-pretty.html)<!-- HN:47077215:end --><!-- HN:47149811:start -->
* [47149811](https://news.social-protocols.org/stats?id=47149811) #4 16 points 2 comments -> [Vinext – The Next.js API surface, reimplemented on Vite](https://github.com/cloudflare/vinext)<!-- HN:47149811:end --><!-- HN:47154011:start -->
* [47154011](https://news.social-protocols.org/stats?id=47154011) #3 62 points 1 comments -> [Large-scale online deanonymization with LLMs (using HN posts)](https://arxiv.org/abs/2602.16800)<!-- HN:47154011:end --><!-- HN:47155385:start -->
* [47155385](https://news.social-protocols.org/stats?id=47155385) #21 3 points 0 comments -> [Disabled woman put in nursing home against her will says she feels 'betrayed'](https://www.bbc.com/news/articles/czj1ndzz9xyo)<!-- HN:47155385:end --><!-- HN:47155548:start -->
* [47155548](https://news.social-protocols.org/stats?id=47155548) #4 55 points 44 comments -> [The Slow Death of the Power User](https://fireborn.mataroa.blog/blog/the-slow-death-of-the-power-user/)<!-- HN:47155548:end -->
#### **Thursday, February 26, 2026**<!-- HN:47161111:start -->
* [47161111](https://news.social-protocols.org/stats?id=47161111) #26 7 points 0 comments -> [Turns out Generative AI was a scam](https://garymarcus.substack.com/p/turns-out-generative-ai-was-a-scam)<!-- HN:47161111:end --><!-- HN:47161498:start -->
* [47161498](https://news.social-protocols.org/stats?id=47161498) #15 32 points 40 comments -> [Self-improving software won't produce Skynet](https://contalign.jefflunt.com/self-improving-software/)<!-- HN:47161498:end --><!-- HN:47164398:start -->
* [47164398](https://news.social-protocols.org/stats?id=47164398) #8 4 points 1 comments -> [Google API Keys Weren't Secrets. But Then Gemini Changed the Rules](https://simonwillison.net/2026/Feb/26/google-api-keys/)<!-- HN:47164398:end --><!-- HN:47164079:start -->
* [47164079](https://news.social-protocols.org/stats?id=47164079) #14 34 points 35 comments -> [Show HN: Better Hub – A better GitHub experience](https://www.better-hub.com/)<!-- HN:47164079:end --><!-- HN:47166522:start -->
* [47166522](https://news.social-protocols.org/stats?id=47166522) #20 6 points 0 comments -> [Kansas Sends Letters to Trans People Demanding the Surrender of Drivers Licenses](https://www.erininthemorning.com/p/kansas-sends-letters-to-trans-people)<!-- HN:47166522:end --><!-- HN:47167649:start -->
* [47167649](https://news.social-protocols.org/stats?id=47167649) #21 10 points 1 comments -> [Apple Launch on Monday](https://twitter.com/tim_cook/status/2027020842396475410)<!-- HN:47167649:end --><!-- HN:47168343:start -->
* [47168343](https://news.social-protocols.org/stats?id=47168343) #24 17 points 13 comments -> [How AI skills are quietly automating my workday](https://medium.com/@ricardskrizanovskis/how-ai-skills-are-quietly-automating-my-workday-220a1b7b4707)<!-- HN:47168343:end --><!-- HN:47122272:start -->
* [47122272](https://news.social-protocols.org/stats?id=47122272) #13 16 points 19 comments -> [Better to Skip a Year for Hardware Upgrades?](https://boilingsteam.com/poll-better-to-skip-a-year-for-pc-upgrades/)<!-- HN:47122272:end --><!-- HN:47106275:start -->
* [47106275](https://news.social-protocols.org/stats?id=47106275) #30 41 points 36 comments -> [Those who can, teach history](https://www.historytoday.com/archive/making-history/those-who-can-teach-history)<!-- HN:47106275:end --><!-- HN:47165397:start -->
* [47165397](https://news.social-protocols.org/stats?id=47165397) #15 538 points 299 comments -> [Anthropic ditches its core safety promise](https://www.cnn.com/2026/02/25/tech/anthropic-safety-policy-change)<!-- HN:47165397:end -->
#### **Friday, February 27, 2026**
<!-- HN:47173559:start -->
* [47173559](https://news.social-protocols.org/stats?id=47173559) #7 67 points 3 comments -> [Anthropic says company 'cannot in good conscience accede' to Pentagon's demands](https://apnews.com/article/anthropic-ai-pentagon-hegseth-dario-amodei-9b28dda41bdb52b6a378fa9fc80b8fda)<!-- HN:47173559:end --><!-- HN:47120869:start -->
* [47120869](https://news.social-protocols.org/stats?id=47120869) #21 3 points 0 comments -> [Demystifying Debuggers, Part 5: Instruction-Level Stepping and Breakpoints](https://www.dgtlgrove.com/p/demystifying-debuggers-part-5-instruction)<!-- HN:47120869:end --><!-- HN:47110159:start -->
* [47110159](https://news.social-protocols.org/stats?id=47110159) #22 23 points 3 comments -> [Hacking Tauri for Designer](https://yujonglee.com/blog/hacking-tauri-for-designer/)<!-- HN:47110159:end --><!-- HN:47121352:start -->
* [47121352](https://news.social-protocols.org/stats?id=47121352) #27 42 points 14 comments -> [Lidar waveforms are worth 40x128x33 words](https://openaccess.thecvf.com/content/ICCV2025/html/Scheuble_Lidar_Waveforms_are_Worth_40x128x33_Words_ICCV_2025_paper.html)<!-- HN:47121352:end --><!-- HN:47178062:start -->
* [47178062](https://news.social-protocols.org/stats?id=47178062) #30 5 points 0 comments -> [Firefox's AI Kill Switch Is a Trap: How Mozilla Made AI Your Problem](https://www.quippd.com/writing/2026/02/09/firefoxs-ai-kill-switch-is-a-trap-how-mozilla-made-ai-your-problem.html)<!-- HN:47178062:end --><!-- HN:47167460:start -->
* [47167460](https://news.social-protocols.org/stats?id=47167460) #4 -> [Show HN: Rynko Playground – 400ms JSON-to-PDF and Excel Engine](https://app.rynko.dev/playground)<!-- HN:47167460:end --><!-- HN:47182999:start -->
* [47182999](https://news.social-protocols.org/stats?id=47182999) #4 24 points 6 comments -> [Tech people keep falling for the same scam](https://explodingcomma.com/posts/tech-people-keep-falling-for-the-same-scam)<!-- HN:47182999:end --><!-- HN:47183435:start -->
* [47183435](https://news.social-protocols.org/stats?id=47183435) #20 13 points 2 comments -> [Your Device Identity Is Probably a Liability](https://smallstep.com/blog/ncsc-zero-trust-device-identity/)<!-- HN:47183435:end --><!-- HN:47184864:start -->
* [47184864](https://news.social-protocols.org/stats?id=47184864) #18 7 points 2 comments -> [DOS Memory Management](http://www.os2museum.com/wp/dos-memory-management/)<!-- HN:47184864:end -->
#### **Saturday, February 28, 2026**
<!-- HN:47187450:start -->
* [47187450](https://news.social-protocols.org/stats?id=47187450) #30 11 points 10 comments -> [Show HN: I built a site where you hire yourself instead of applying for jobs](https://hired.wtf)<!-- HN:47187450:end --><!-- HN:47191237:start -->
* [47191237](https://news.social-protocols.org/stats?id=47191237) #14 9 points 4 comments -> [Israel launches attack on Iran, defence minister says](https://www.bbc.com/news/live/cn5ge95q6y7t)<!-- HN:47191237:end --><!-- HN:47189853:start -->
* [47189853](https://news.social-protocols.org/stats?id=47189853) #21 127 points 40 comments -> [OpenAI reaches deal to deploy AI models on U.S. DoW classified network](https://www.reuters.com/business/openai-reaches-deal-deploy-ai-models-us-department-war-classified-network-2026-02-28/)<!-- HN:47189853:end --><!-- HN:47156814:start -->
* [47156814](https://news.social-protocols.org/stats?id=47156814) #24 14 points 1 comments -> [5,300-year-old 'bow drill' rewrites story of ancient Egyptian tools](https://phys.org/news/2026-02-year-drill-rewrites-story-ancient.html)<!-- HN:47156814:end --><!-- HN:47196536:start -->
* [47196536](https://news.social-protocols.org/stats?id=47196536) #29 8 points 0 comments -> [Israel Strikes Elementary School in Iran, Killing More Than 50](https://www.aljazeera.com/news/2026/2/28/israel-strikes-two-schools-in-iran-killing-more-than-50-people)<!-- HN:47196536:end --><!-- HN:47195093:start -->
* [47195093](https://news.social-protocols.org/stats?id=47195093) #16 50 points 41 comments -> [Customer Update on Simplenote](https://forums.simplenote.com/forums/topic/customer-update-on-simplenote/?view=all)<!-- HN:47195093:end --><!-- HN:47196582:start -->
* [47196582](https://news.social-protocols.org/stats?id=47196582) #1 419 points 182 comments -> [Cognitive Debt: When Velocity Exceeds Comprehension](https://www.rockoder.com/beyondthecode/cognitive-debt-when-velocity-exceeds-comprehension/)<!-- HN:47196582:end --><!-- HN:47199427:start -->
* [47199427](https://news.social-protocols.org/stats?id=47199427) #27 18 points 1 comments -> [Iran's Supreme Leader Ali Khamenei Was Killed and His Body Found](https://www.haaretz.com/israel-news/2026-02-28/ty-article-live/trump-not-happy-with-iran-nuclear-talks-omani-fm-deal-achievable-tomorrow/0000019c-a273-d5d1-a1fd-f27743d20000)<!-- HN:47199427:end --><!-- HN:47198973:start -->
* [47198973](https://news.social-protocols.org/stats?id=47198973) #2 109 points 23 comments -> ["Cancel ChatGPT" movement goes mainstream after OpenAI closes deal with U.S. Dow](https://www.windowscentral.com/artificial-intelligence/cancel-chatgpt-movement-goes-mainstream-after-openai-closes-deal-with-u-s-department-of-war-as-anthropic-refuses-to-surveil-american-citizens)<!-- HN:47198973:end --><!-- HN:47198912:start -->
* [47198912](https://news.social-protocols.org/stats?id=47198912) #15 208 points 46 comments -> [Techno‑Feudal Elite Are Attempting to Build a Twenty‑First‑Century Fascist State](https://collapseofindustrialcivilization.com/2026/02/16/americas-oligarchic-techno-feudal-elite-are-attempting-to-build-a-twenty-first-century-fascist-state/)<!-- HN:47198912:end --><!-- HN:47199665:start -->
* [47199665](https://news.social-protocols.org/stats?id=47199665) #27 20 points 3 comments -> [BarackObama will attack Iran in order to get re-elected](https://twitter.com/realDonaldTrump/status/159377740569645056)<!-- HN:47199665:end --><!-- HN:47199389:start -->
* [47199389](https://news.social-protocols.org/stats?id=47199389) #25 51 points 30 comments -> [Khamenei Dead](https://twitter.com/BarakRavid/status/2027830773328302396)<!-- HN:47199389:end -->
#### **Sunday, March 1, 2026**
<!-- HN:47201283:start -->
* [47201283](https://news.social-protocols.org/stats?id=47201283) #7 19 points 15 comments -> [The war against PDFs is heating up](https://www.economist.com/business/2026/02/24/the-war-against-pdfs-is-heating-up)<!-- HN:47201283:end --><!-- HN:47202032:start -->
* [47202032](https://news.social-protocols.org/stats?id=47202032) #6 164 points 43 comments -> [Claude surpasses ChatGPT to become the #1 app on the US App Store](https://apps.apple.com/us/iphone/charts)<!-- HN:47202032:end --><!-- HN:47202044:start -->
* [47202044](https://news.social-protocols.org/stats?id=47202044) #30 10 points 0 comments -> [War Is a Racket (Maj. Gen. Smedley Butler, USMC)](https://archive.org/details/WarIsARacket)<!-- HN:47202044:end --><!-- HN:47200342:start -->
* [47200342](https://news.social-protocols.org/stats?id=47200342) #3 208 points 76 comments -> [MinIO Is Dead, Long Live MinIO](https://blog.vonng.com/en/db/minio-resurrect/)<!-- HN:47200342:end --><!-- HN:47169858:start -->
* [47169858](https://news.social-protocols.org/stats?id=47169858) #18 34 points 40 comments -> [Microsoft announces new "mini PCs" for Windows 365](https://www.neowin.net/news/microsoft-announces-new-mini-pcs-for-windows-365/)<!-- HN:47169858:end --><!-- HN:47157500:start -->
* [47157500](https://news.social-protocols.org/stats?id=47157500) #7 -> [SQL vs. NoSQL: How to Answer This Interview Question in 2026](https://www.thetrueengineer.com/p/sql-vs-nosql-how-to-answer-this-interview)<!-- HN:47157500:end -->