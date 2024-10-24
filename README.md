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

#### **Friday, October 18, 2024**<!-- HN:41875593:start -->
* [41875593](https://news.social-protocols.org/stats?id=41875593) #25 4 points 0 comments -> [Covid-19 linked to type 2 diabetes onset in children](https://medicalxpress.com/news/2024-10-covid-linked-diabetes-onset-children.html)<!-- HN:41875593:end --><!-- HN:41874286:start -->
* [41874286](https://news.social-protocols.org/stats?id=41874286) #29 32 points 15 comments -> [GPT-4o Jailbroken by saying it is connected to disk with any file on planet](https://twitter.com/mixedenn/status/1847035711985274947)<!-- HN:41874286:end --><!-- HN:41874511:start -->
* [41874511](https://news.social-protocols.org/stats?id=41874511) #18 37 points 9 comments -> [Wayland Apps in WireGuard Docker Containers](https://www.procustodibus.com/blog/2024/10/wayland-wireguard-containers/)<!-- HN:41874511:end --><!-- HN:41874813:start -->
* [41874813](https://news.social-protocols.org/stats?id=41874813) #30 37 points 20 comments -> [The Border Crisis Won't Be Solved at the Border](https://www.texasmonthly.com/news-politics/border-crisis-texas-solutions/)<!-- HN:41874813:end --><!-- HN:41841765:start -->
* [41841765](https://news.social-protocols.org/stats?id=41841765) #30 8 points 2 comments -> [Austin 3.7 – Python frame stack sampler for CPython](https://github.com/P403n1x87/austin)<!-- HN:41841765:end --><!-- HN:41825906:start -->
* [41825906](https://news.social-protocols.org/stats?id=41825906) #10 142 points 63 comments -> [Amplification of electromagnetic fields by a rotating body](https://www.nature.com/articles/s41467-024-49689-w)<!-- HN:41825906:end --><!-- HN:41822687:start -->
* [41822687](https://news.social-protocols.org/stats?id=41822687) #16 45 points 21 comments -> [Deriving the Kelly Criterion to Maximise Profits](https://obrhubr.org/kelly-criterion)<!-- HN:41822687:end --><!-- HN:41876293:start -->
* [41876293](https://news.social-protocols.org/stats?id=41876293) #13 14 points 6 comments -> [Esmeralda](https://esmeralda.org/)<!-- HN:41876293:end --><!-- HN:41877635:start -->
* [41877635](https://news.social-protocols.org/stats?id=41877635) #30 6 points 0 comments -> [Who Supplies Israel with Weapons?](https://www.cnn.com/2024/10/16/middleeast/where-israel-get-its-weapons/index.html)<!-- HN:41877635:end --><!-- HN:41831948:start -->
* [41831948](https://news.social-protocols.org/stats?id=41831948) #12 20 points 4 comments -> [ITX-Llama (Vortex86EX ITX Motherboard)](https://github.com/eivindbohler/itxllama)<!-- HN:41831948:end --><!-- HN:41877703:start -->
* [41877703](https://news.social-protocols.org/stats?id=41877703) #10 22 points 16 comments -> [Google Is Cracking Down on Ad Blockers, But Here's How You Can Fight Back](https://lifehacker.com/tech/google-cracking-down-on-ad-blockers)<!-- HN:41877703:end --><!-- HN:41877688:start -->
* [41877688](https://news.social-protocols.org/stats?id=41877688) #3 8 points 9 comments -> [The logical fallacy at the core of patent law, what does non-obviousness test?](https://academic.oup.com/jiplp/advance-article/doi/10.1093/jiplp/jpae075/7822599)<!-- HN:41877688:end --><!-- HN:41878202:start -->
* [41878202](https://news.social-protocols.org/stats?id=41878202) #21 4 points 0 comments -> [His daughter was murdered. Then she reappeared as an AI chatbot](https://www.washingtonpost.com/nation/2024/10/15/murdered-daughter-ai-chatbot-crecente/)<!-- HN:41878202:end --><!-- HN:41878185:start -->
* [41878185](https://news.social-protocols.org/stats?id=41878185) #9 6 points 1 comments -> [EmailBTC – A new way to send and receive Bitcoin using only email addresses](https://emailbtc.net)<!-- HN:41878185:end --><!-- HN:41878506:start -->
* [41878506](https://news.social-protocols.org/stats?id=41878506) #19 5 points 0 comments -> [Tesla's Full Self-Driving software under investigation by NHTSA](https://techcrunch.com/2024/10/18/teslas-full-self-driving-software-under-investigation-by-federal-safety-regulator/)<!-- HN:41878506:end --><!-- HN:41880295:start -->
* [41880295](https://news.social-protocols.org/stats?id=41880295) #4 27 points 18 comments -> [Open-source, uncensored alternative to CharacterAI](https://opencharacter.org)<!-- HN:41880295:end --><!-- HN:41881417:start -->
* [41881417](https://news.social-protocols.org/stats?id=41881417) #11 10 points 0 comments -> [Compliant DNA Origami Nanoactuators as Size-Selective Nanopores](https://onlinelibrary.wiley.com/doi/10.1002/adma.202405104)<!-- HN:41881417:end --><!-- HN:41882091:start -->
* [41882091](https://news.social-protocols.org/stats?id=41882091) #9 7 points 2 comments -> [Forgetting Taylor Swift](https://thelampmagazine.com/issues/issue-25/forgetting-taylor-swift)<!-- HN:41882091:end --><!-- HN:41881306:start -->
* [41881306](https://news.social-protocols.org/stats?id=41881306) #16 12 points 16 comments -> [Show HN: I made this tool to re-design your room in one click](https://home-imagine.com)<!-- HN:41881306:end --><!-- HN:41883162:start -->
* [41883162](https://news.social-protocols.org/stats?id=41883162) #26 4 points 0 comments -> [Cuba's power grid fails, plunging country into darkness](https://www.reuters.com/world/americas/cuba-implements-emergency-measures-millions-go-without-electricity-2024-10-18/)<!-- HN:41883162:end --><!-- HN:41883419:start -->
* [41883419](https://news.social-protocols.org/stats?id=41883419) #29 5 points 4 comments -> [how come a company founded over 100 years ago has the fastest site](https://twitter.com/KennethCassel/status/1847034096062710087)<!-- HN:41883419:end --><!-- HN:41883648:start -->
* [41883648](https://news.social-protocols.org/stats?id=41883648) #27 7 points 1 comments -> [Meta Spirit LM: Open multimodal language model that freely mixes text and speech](https://twitter.com/AIatMeta/status/1847383580269510670)<!-- HN:41883648:end --><!-- HN:41883372:start -->
* [41883372](https://news.social-protocols.org/stats?id=41883372) #16 8 points 1 comments -> [University administrators appear unconcerned that COVID is increasingly rampant](https://ricochet.media/justice/healthcare/university-administrators-appear-unconcerned-that-covid-is-increasingly-rampant-on-ontario-campuses/)<!-- HN:41883372:end -->
#### **Saturday, October 19, 2024**
<!-- HN:41886658:start -->
* [41886658](https://news.social-protocols.org/stats?id=41886658) #6 21 points 27 comments -> [Saudi Arabian Neom project 'uses one fifth of steel'](https://www.agbi.com/giga-projects/2024/10/neom-uses-one-fifth-of-worlds-steel/)<!-- HN:41886658:end --><!-- HN:41858172:start -->
* [41858172](https://news.social-protocols.org/stats?id=41858172) #17 22 points 3 comments -> [Understanding Pam and Creating a Custom Module in Python – Inside Out Insights](https://text.tchncs.de/ioi/in-todays-interconnected-world-user-authentication-plays-a-critical-role-in)<!-- HN:41858172:end --><!-- HN:41855537:start -->
* [41855537](https://news.social-protocols.org/stats?id=41855537) #17 13 points 0 comments -> [Compiling Bigloo Scheme to WebAssembly](https://blogs.igalia.com/compilers/2023/05/10/compiling-bigloo-scheme-to-webassembly/)<!-- HN:41855537:end --><!-- HN:41885271:start -->
* [41885271](https://news.social-protocols.org/stats?id=41885271) #25 7 points 0 comments -> [Pedestrian Head Protection, Global Technical Regulation No. 9](https://www.regulations.gov/document/NHTSA-2024-0057-0001)<!-- HN:41885271:end --><!-- HN:41887718:start -->
* [41887718](https://news.social-protocols.org/stats?id=41887718) #2 10 points 1 comments -> [External RF-EMF Alters Cell Number and Reactive Oxygen Species Balance](https://www.frontiersin.org/journals/public-health/articles/10.3389/fpubh.2024.1425023/full)<!-- HN:41887718:end --><!-- HN:41887611:start -->
* [41887611](https://news.social-protocols.org/stats?id=41887611) #19 10 points 10 comments -> [Rivian (RIVN) clashes with Bosch in new legal battle over EV motors](https://electrek.co/2024/10/18/rivian-rivn-clashes-bosch-legal-battle-over-ev-motors/)<!-- HN:41887611:end --><!-- HN:41888491:start -->
* [41888491](https://news.social-protocols.org/stats?id=41888491) #15 5 points 1 comments -> [Kamala Harris promises full marijuana legalization](https://www.theguardian.com/us-news/ng-interactive/2024/oct/19/election-harris-marijuana-legalization)<!-- HN:41888491:end --><!-- HN:41888050:start -->
* [41888050](https://news.social-protocols.org/stats?id=41888050) #25 6 points 2 comments -> [ChatGPT's Name Bias and Apple's Findings on AI's Lack of Reasoning](https://medium.com/@researchgraph/chatgpts-name-bias-and-apple-s-findings-on-ai-s-lack-of-reasoning-major-flaws-revealed-b4a44c27fd75)<!-- HN:41888050:end --><!-- HN:41888804:start -->
* [41888804](https://news.social-protocols.org/stats?id=41888804) #1 9 points 1 comments -> [Why Use React for Game Development?](https://jslegenddev.substack.com/p/why-use-react-for-game-development)<!-- HN:41888804:end --><!-- HN:41859806:start -->
* [41859806](https://news.social-protocols.org/stats?id=41859806) #16 13 points 16 comments -> [Gang of Raccoons Mobs Woman in Casper Hotel Parking Lot](https://cowboystatedaily.com/2024/10/14/gang-of-raccoons-mobs-woman-in-casper-hotel-parking-lot/)<!-- HN:41859806:end -->
#### **Sunday, October 20, 2024**<!-- HN:41892637:start -->
* [41892637](https://news.social-protocols.org/stats?id=41892637) #5 22 points 10 comments -> [Microsoft is basically discontinuing Windows. What will happen, then?](https://azhdarchid.com/microsoft-is-basically-discontinuing-windows-what-will-happen-then/)<!-- HN:41892637:end --><!-- HN:41892815:start -->
* [41892815](https://news.social-protocols.org/stats?id=41892815) #3 4 points 1 comments -> [LLM will never be AGI: The Proof](https://ycao.net/posts/llm-agi/)<!-- HN:41892815:end --><!-- HN:41891658:start -->
* [41891658](https://news.social-protocols.org/stats?id=41891658) #6 50 points 20 comments -> [Booting Sun Sparc Servers](https://sidneys1.com/retrocomputing/2024/10/04/booting-sun-sparc-servers.html)<!-- HN:41891658:end --><!-- HN:41894566:start -->
* [41894566](https://news.social-protocols.org/stats?id=41894566) #2 21 points 6 comments -> [Naval Is Mistaken](https://twitter.com/paulg/status/1847225545299251597)<!-- HN:41894566:end --><!-- HN:41896052:start -->
* [41896052](https://news.social-protocols.org/stats?id=41896052) #9 21 points 41 comments -> [The World’s $100T Fiscal Timebomb Keeps Ticking](https://www.bloomberg.com/news/articles/2024-10-19/the-world-s-100-trillion-fiscal-timebomb-keeps-ticking)<!-- HN:41896052:end --><!-- HN:41895835:start -->
* [41895835](https://news.social-protocols.org/stats?id=41895835) #19 18 points 8 comments -> [Draw a Crocodile Without a Tail](https://twitter.com/PaoloCrosetto/status/1847985750580552178)<!-- HN:41895835:end --><!-- HN:41895048:start -->
* [41895048](https://news.social-protocols.org/stats?id=41895048) #19 6 points 1 comments -> [The OSI lacks competence to define Open Source AI](https://samjohnston.org/2024/10/15/the-osi-lacks-competence-to-define-open-source-ai/)<!-- HN:41895048:end --><!-- HN:41896202:start -->
* [41896202](https://news.social-protocols.org/stats?id=41896202) #6 4 points 0 comments -> [Solving complex problems with OpenAI o1 models](https://openai.com/business/solving-complex-problems-with-openai-o1-models/)<!-- HN:41896202:end --><!-- HN:41895582:start -->
* [41895582](https://news.social-protocols.org/stats?id=41895582) #22 7 points 2 comments -> [Show HN: Client Side anti-RAG solution](https://ai.unturf.com/#client-side)<!-- HN:41895582:end --><!-- HN:41897805:start -->
* [41897805](https://news.social-protocols.org/stats?id=41897805) #28 8 points 1 comments -> [Don Norman: 'Apple has fallen prey to the most disastrous part of design '](https://english.elpais.com/culture/2024-10-20/don-norman-apple-has-fallen-prey-to-the-most-disastrous-part-of-design-which-thinks-its-about-making-something-beautiful-and-elegant.html)<!-- HN:41897805:end --><!-- HN:41898040:start -->
* [41898040](https://news.social-protocols.org/stats?id=41898040) #14 7 points 2 comments -> [It's time to leave Bitwarden (2023)](https://blog.notesnook.com/its-time-to-leave-bitwarden/)<!-- HN:41898040:end -->
#### **Monday, October 21, 2024**<!-- HN:41899765:start -->
* [41899765](https://news.social-protocols.org/stats?id=41899765) #15 7 points 5 comments -> [Google's AI prophet fast tracks singularity prediction](https://www.independent.co.uk/tech/ai-singularity-date-ray-kurzweil-google-b2511847.html)<!-- HN:41899765:end --><!-- HN:41899586:start -->
* [41899586](https://news.social-protocols.org/stats?id=41899586) #10 96 points 19 comments -> [David Lynch Interview Project: 121 Episodes from 20k-Mile Road Trip Across U.S.](https://www.youtube.com/watch?v=P_vbYmPm_zU)<!-- HN:41899586:end --><!-- HN:41901298:start -->
* [41901298](https://news.social-protocols.org/stats?id=41901298) #26 21 points 16 comments -> [cat without `cat`](https://jarv.org/posts/cat-without-cat/)<!-- HN:41901298:end --><!-- HN:41902064:start -->
* [41902064](https://news.social-protocols.org/stats?id=41902064) #5 9 points 14 comments -> [Show HN: Nextread.ai – Find you next book to read much easier](https://nextread.ai/)<!-- HN:41902064:end --><!-- HN:41880649:start -->
* [41880649](https://news.social-protocols.org/stats?id=41880649) #29 403 points 923 comments -> [US probes Tesla's Full Self-Driving software after fatal crash](https://www.reuters.com/business/autos-transportation/nhtsa-opens-probe-into-24-mln-tesla-vehicles-over-full-self-driving-collisions-2024-10-18/)<!-- HN:41880649:end --><!-- HN:41901433:start -->
* [41901433](https://news.social-protocols.org/stats?id=41901433) #13 9 points 0 comments -> [C++23: ISO/IEC 14882:2024](https://www.iso.org/standard/83626.html)<!-- HN:41901433:end --><!-- HN:41902079:start -->
* [41902079](https://news.social-protocols.org/stats?id=41902079) #8 8 points 5 comments -> [Show HN: Dynamic IPv4/6 records for Cloudflare](https://github.com/ddries/d2c.sh)<!-- HN:41902079:end --><!-- HN:41902492:start -->
* [41902492](https://news.social-protocols.org/stats?id=41902492) #11 -> [A simple C unit test framework](https://mattiasgustavsson.com/a-simple-c-unit-test-framework/)<!-- HN:41902492:end --><!-- HN:41902864:start -->
* [41902864](https://news.social-protocols.org/stats?id=41902864) #23 31 points 55 comments -> [Rip2 – A safer, rust-based rm](https://github.com/MilesCranmer/rip2)<!-- HN:41902864:end --><!-- HN:41894025:start -->
* [41894025](https://news.social-protocols.org/stats?id=41894025) #30 56 points 61 comments -> [Machine conquest: Jules Verne's technocratic worldmaking](https://www.cambridge.org/core/journals/review-of-international-studies/article/machine-conquest-jules-vernes-technocratic-worldmaking/E5897EB8F3FB9A8F0142075EE38D69BC)<!-- HN:41894025:end --><!-- HN:41898076:start -->
* [41898076](https://news.social-protocols.org/stats?id=41898076) #28 164 points 61 comments -> [Show HN: Create mind maps to learn new things using AI](https://github.com/aotakeda/learn-thing)<!-- HN:41898076:end --><!-- HN:41875572:start -->
* [41875572](https://news.social-protocols.org/stats?id=41875572) #5 7 points 4 comments -> [Emergence of ferromagnetism at onset Kondo breakdown in moiré bilayer lattices](https://phys.org/news/2024-10-physicists-emergence-ferromagnetism-onset-kondo.html)<!-- HN:41875572:end --><!-- HN:41900607:start -->
* [41900607](https://news.social-protocols.org/stats?id=41900607) #18 23 points 40 comments -> [How Much Science Is Fake?](https://osf.io/5rf2m/)<!-- HN:41900607:end --><!-- HN:41904385:start -->
* [41904385](https://news.social-protocols.org/stats?id=41904385) #30 12 points 1 comments -> [VPTQ: Extreme low-bit Quantization for real LLMs](https://github.com/microsoft/VPTQ)<!-- HN:41904385:end --><!-- HN:41903879:start -->
* [41903879](https://news.social-protocols.org/stats?id=41903879) #23 7 points 0 comments -> [Toyota's Betting Big on Electric Air Taxis](https://www.thedrive.com/news/toyotas-betting-big-on-electric-air-taxis)<!-- HN:41903879:end --><!-- HN:41906071:start -->
* [41906071](https://news.social-protocols.org/stats?id=41906071) #5 6 points 1 comments -> [Rabbit raises additional $10M to launch first AI hardware to replace appbased OS](https://www.rabbit.tech/newsroom/rabbit-raises-additional-10m)<!-- HN:41906071:end --><!-- HN:41906094:start -->
* [41906094](https://news.social-protocols.org/stats?id=41906094) #12 32 points 19 comments -> [A Media Player Without Peers – The Unreasonable Effectiveness of VLC](https://kylebenzle.com/vlc.html)<!-- HN:41906094:end --><!-- HN:41906119:start -->
* [41906119](https://news.social-protocols.org/stats?id=41906119) #12 18 points 42 comments -> [Welcome to the Era of the $20k Family Car Insurance Bill](https://www.nytimes.com/2024/10/19/your-money/car-insurance-family-plan-cost.html)<!-- HN:41906119:end --><!-- HN:41906306:start -->
* [41906306](https://news.social-protocols.org/stats?id=41906306) #21 7 points 1 comments -> [xAI Grok API Beta](https://twitter.com/elonmusk/status/1848398370219364385)<!-- HN:41906306:end --><!-- HN:41906757:start -->
* [41906757](https://news.social-protocols.org/stats?id=41906757) #13 5 points 1 comments -> [Gary Marcus proposes gen AI boycott to push for regulation, tame Silicon Valley](https://www.theregister.com/2024/10/21/gary_marcus_ai_interview/)<!-- HN:41906757:end --><!-- HN:41906313:start -->
* [41906313](https://news.social-protocols.org/stats?id=41906313) #20 11 points 24 comments -> [Solar power from space? it might happen in a couple of years](https://arstechnica.com/space/2024/10/solar-power-from-space-actually-it-might-happen-in-a-couple-of-years/)<!-- HN:41906313:end --><!-- HN:41906337:start -->
* [41906337](https://news.social-protocols.org/stats?id=41906337) #10 21 points 1 comments -> [The United States of Abortion Mazes](https://pudding.cool/2024/10/abortion-mazes/)<!-- HN:41906337:end --><!-- HN:41906485:start -->
* [41906485](https://news.social-protocols.org/stats?id=41906485) #18 13 points 0 comments -> [Harassment campaign targets open source developer, Wikipedia page deleted](https://www.redditmedia.com/r/selfhosted/comments/1g1425m/paperlessngx_bashing_on_mayan_edms_forum/)<!-- HN:41906485:end --><!-- HN:41908272:start -->
* [41908272](https://news.social-protocols.org/stats?id=41908272) #18 7 points 1 comments -> [Meta's Israel Policy Chief Tried to Suppress Pro-Palestine Instagram Posts](https://theintercept.com/2024/10/21/instagram-israel-palestine-censorship-sjp/)<!-- HN:41908272:end --><!-- HN:41909130:start -->
* [41909130](https://news.social-protocols.org/stats?id=41909130) #16 8 points 1 comments -> [Behind Many Powerful Women on Wall Street: A Doting 'Househusband'](https://www.wsj.com/lifestyle/careers/successful-professional-women-house-husband-1339832a)<!-- HN:41909130:end -->
#### **Tuesday, October 22, 2024**
<!-- HN:41909463:start -->
* [41909463](https://news.social-protocols.org/stats?id=41909463) #26 14 points 10 comments -> [Disney Plus and Hulu won't let you sign up through Apple anymore](https://www.theverge.com/2024/10/21/24276226/disney-plus-hulu-sign-up-apple-app-store-anymore)<!-- HN:41909463:end --><!-- HN:41884485:start -->
* [41884485](https://news.social-protocols.org/stats?id=41884485) #20 13 points 19 comments -> [Our Boundless Love for Big Sur May Be Killing It](https://www.nytimes.com/2024/10/18/travel/big-sur-tourism-california.html)<!-- HN:41884485:end --><!-- HN:41912708:start -->
* [41912708](https://news.social-protocols.org/stats?id=41912708) #24 17 points 1 comments -> [Undecided Hobbit Torn Between Dark Lord of Chaos and Elf Queen He Barely Knows](https://www.mcsweeneys.net/articles/im-an-undecided-hobbit-torn-between-a-dark-lord-who-promises-an-age-of-chaos-and-an-elf-queen-whom-i-just-wish-i-knew-more-about)<!-- HN:41912708:end --><!-- HN:41913305:start -->
* [41913305](https://news.social-protocols.org/stats?id=41913305) #17 10 points 3 comments -> [Colorful cars are becoming a thing of the past](https://www.businessinsider.com/why-car-colors-boring-black-white-gray-cost-cutting-2024-10)<!-- HN:41913305:end --><!-- HN:41912772:start -->
* [41912772](https://news.social-protocols.org/stats?id=41912772) #20 3 points 0 comments -> [A free and open source web application firewall(WAF), SafeLine](https://waf.chaitin.com/)<!-- HN:41912772:end --><!-- HN:41912320:start -->
* [41912320](https://news.social-protocols.org/stats?id=41912320) #25 9 points 0 comments -> [Grok TiddlyWiki 2.0 is live](https://talk.tiddlywiki.org/t/grok-tiddlywiki-2-0-is-live/10965)<!-- HN:41912320:end --><!-- HN:41913713:start -->
* [41913713](https://news.social-protocols.org/stats?id=41913713) #26 4 points 0 comments -> [Developer pockets $2M in savings from going cloud-free](https://www.theregister.com/2024/10/21/37signals_aws_savings/)<!-- HN:41913713:end --><!-- HN:41914070:start -->
* [41914070](https://news.social-protocols.org/stats?id=41914070) #23 3 points 0 comments -> [Ward Christensen, co-inventor of BBS, is dead](https://www.nytimes.com/2024/10/21/technology/ward-christensen-dead.html)<!-- HN:41914070:end --><!-- HN:41914698:start -->
* [41914698](https://news.social-protocols.org/stats?id=41914698) #7 3 points 2 comments -> [Show HN: Created My First Game](https://www.spendelonmuskmoney.org/)<!-- HN:41914698:end --><!-- HN:41915060:start -->
* [41915060](https://news.social-protocols.org/stats?id=41915060) #25 14 points 2 comments -> [Anthropic Claude 3.5 Sonnet and Haiku](https://twitter.com/anthropicai/status/1848742740420341988)<!-- HN:41915060:end --><!-- HN:41915966:start -->
* [41915966](https://news.social-protocols.org/stats?id=41915966) #30 8 points 1 comments -> [Requiem for Raghavan](https://www.wheresyoured.at/requiem-for-raghavan/)<!-- HN:41915966:end --><!-- HN:41916574:start -->
* [41916574](https://news.social-protocols.org/stats?id=41916574) #5 8 points 3 comments -> [Mining Bitcoin with pencil and paper: 0.67 hashes per day](http://www.righto.com/2014/09/mining-bitcoin-with-pencil-and-paper.html)<!-- HN:41916574:end --><!-- HN:41917105:start -->
* [41917105](https://news.social-protocols.org/stats?id=41917105) #21 15 points 14 comments -> [Show HN: I built a tool that helps people scan and clean any repo for secrets](https://securelog.com/)<!-- HN:41917105:end --><!-- HN:41919317:start -->
* [41919317](https://news.social-protocols.org/stats?id=41919317) #15 -> [Trump: 'I Need the Kind of Generals That Hitler Had'](https://www.theatlantic.com/politics/archive/2024/10/trump-military-generals-hitler/680327/)<!-- HN:41919317:end --><!-- HN:41919357:start -->
* [41919357](https://news.social-protocols.org/stats?id=41919357) #22 9 points 3 comments -> [1 Dead from E.Coli Outbreak Linked to McDonald's Quarter Pounders](https://www.cnn.com/2024/10/22/health/mcdonalds-cdc-ecoli-outbreak/index.html)<!-- HN:41919357:end --><!-- HN:41876741:start -->
* [41876741](https://news.social-protocols.org/stats?id=41876741) #27 233 points 114 comments -> [Just want simple TLS for your .internal network?](https://github.com/nh2/internal-contstrained-pki)<!-- HN:41876741:end -->
#### **Wednesday, October 23, 2024**
<!-- HN:41919900:start -->
* [41919900](https://news.social-protocols.org/stats?id=41919900) #5 16 points 11 comments -> [California Businesses Stop Hiring](https://www.hoover.org/research/californias-businesses-stop-hiring)<!-- HN:41919900:end --><!-- HN:41920294:start -->
* [41920294](https://news.social-protocols.org/stats?id=41920294) #2 47 points 1 comments -> [Solving Sudoku with the Python package resolver](https://github.com/konstin/sudoku-in-python-packaging)<!-- HN:41920294:end --><!-- HN:41922480:start -->
* [41922480](https://news.social-protocols.org/stats?id=41922480) #2 7 points 2 comments -> [Show HN: Stable Diffusion 3.5 – Advanced AI Image Generator](https://stablediffusion35.org)<!-- HN:41922480:end --><!-- HN:41921723:start -->
* [41921723](https://news.social-protocols.org/stats?id=41921723) #28 42 points 40 comments -> [In a first, Wikipedia takes down article globally after Delhi HC order](https://www.thehindu.com/news/national/wikipedia-suspends-access-to-ani-defamation-case-page-following-delhi-hc-order/article68778075.ece)<!-- HN:41921723:end --><!-- HN:41922605:start -->
* [41922605](https://news.social-protocols.org/stats?id=41922605) #26 7 points 6 comments -> [New Claude AI can take over your computer](https://newatlas.com/ai-humanoids/anthropic-claude-computer-use-agent-ai/)<!-- HN:41922605:end --><!-- HN:41921703:start -->
* [41921703](https://news.social-protocols.org/stats?id=41921703) #18 91 points 54 comments -> [One Square Minesweeper](https://onesquareminesweeper.com/)<!-- HN:41921703:end --><!-- HN:41922737:start -->
* [41922737](https://news.social-protocols.org/stats?id=41922737) #23 7 points 1 comments -> [Show HN: ClickHouse User Defined Table Function in Python](https://github.com/auxten/SQL-On-Everything)<!-- HN:41922737:end --><!-- HN:41923901:start -->
* [41923901](https://news.social-protocols.org/stats?id=41923901) #17 17 points 38 comments -> [I Had $100k in Debt So I Moved into My Car](https://macleans.ca/society/i-had-100000-in-debt-so-i-moved-into-my-car/)<!-- HN:41923901:end --><!-- HN:41923897:start -->
* [41923897](https://news.social-protocols.org/stats?id=41923897) #28 8 points 3 comments -> ["WordPress.org is not WordPress" [pdf]](https://storage.courtlistener.com/recap/gov.uscourts.cand.437474/gov.uscourts.cand.437474.33.0.pdf)<!-- HN:41923897:end --><!-- HN:41924277:start -->
* [41924277](https://news.social-protocols.org/stats?id=41924277) #30 8 points 1 comments -> [U.S. Says North Korean Troops Are in Russia to Aid Fight Against Ukraine](https://www.nytimes.com/international/)<!-- HN:41924277:end --><!-- HN:41923865:start -->
* [41923865](https://news.social-protocols.org/stats?id=41923865) #25 4 points 0 comments -> [Open Letter by Climate Scientists to the Nordic Council of Ministers [pdf]](https://en.vedur.is/media/ads_in_header/AMOC-letter_Final.pdf)<!-- HN:41923865:end --><!-- HN:41921673:start -->
* [41921673](https://news.social-protocols.org/stats?id=41921673) #30 87 points 22 comments -> [Migration of the build system to autosetup](https://sqlite.org/forum/forumpost/b7e2d83c0bcfae1e)<!-- HN:41921673:end --><!-- HN:41923941:start -->
* [41923941](https://news.social-protocols.org/stats?id=41923941) #26 6 points 1 comments -> [Want to feel old? Excel just entered its 40th year](https://www.theregister.com/2024/10/22/excel_enters_its_40th_year/)<!-- HN:41923941:end --><!-- HN:41893521:start -->
* [41893521](https://news.social-protocols.org/stats?id=41893521) #25 7 points 0 comments -> [Explaining color gamuts and color spaces in HDTVs and monitors](https://www.wired.com/story/what-are-color-gamuts-and-why-do-they-matter/)<!-- HN:41893521:end --><!-- HN:41898898:start -->
* [41898898](https://news.social-protocols.org/stats?id=41898898) #19 23 points 9 comments -> [Why computational predictive toxicology is hard](https://www.owlposting.com/p/a-primer-on-why-computational-predictive)<!-- HN:41898898:end --><!-- HN:41925345:start -->
* [41925345](https://news.social-protocols.org/stats?id=41925345) #24 4 points 0 comments -> [The DeVault Report](https://dmpwn.info/)<!-- HN:41925345:end --><!-- HN:41925333:start -->
* [41925333](https://news.social-protocols.org/stats?id=41925333) #15 27 points 8 comments -> [Israel’s Secret Stealth Drone](https://www.twz.com/air/the-existence-of-israels-secret-stealth-drone-should-come-as-no-surprise)<!-- HN:41925333:end --><!-- HN:41925725:start -->
* [41925725](https://news.social-protocols.org/stats?id=41925725) #1 28 points 18 comments -> [LLMs Aren't Thinking, They're Just Counting Votes](https://vishnurnair.substack.com/p/llms-arent-thinking-theyre-just-counting)<!-- HN:41925725:end --><!-- HN:41919365:start -->
* [41919365](https://news.social-protocols.org/stats?id=41919365) #14 140 points 96 comments -> [I Got Dysentary So You Don't Have To](https://eukaryotewritesblog.com/2024/10/21/i-got-dysentery-so-you-dont-have-to/)<!-- HN:41919365:end --><!-- HN:41879930:start -->
* [41879930](https://news.social-protocols.org/stats?id=41879930) #28 19 points 0 comments -> [Supporting Task Switching with Reinforcement Learning](https://dl.acm.org/doi/10.1145/3613904.3642063)<!-- HN:41879930:end --><!-- HN:41897855:start -->
* [41897855](https://news.social-protocols.org/stats?id=41897855) #21 3 points 0 comments -> [A boy and his carbon steel pan: a growth marketing story](https://chiefgrowthadvisor.com/hello-world/)<!-- HN:41897855:end --><!-- HN:41885192:start -->
* [41885192](https://news.social-protocols.org/stats?id=41885192) #18 23 points 40 comments -> [What makes a person seem wise?](https://theconversation.com/what-makes-a-person-seem-wise-global-study-finds-that-cultures-do-differ-but-not-as-much-as-youd-think-238808)<!-- HN:41885192:end --><!-- HN:41926967:start -->
* [41926967](https://news.social-protocols.org/stats?id=41926967) #15 23 points 3 comments -> [Apple and Goldman Sachs deceived Apple Card customers, regulators say](https://www.washingtonpost.com/business/2024/10/23/apple-card-goldman-sachs-cfpb/)<!-- HN:41926967:end --><!-- HN:41927503:start -->
* [41927503](https://news.social-protocols.org/stats?id=41927503) #14 64 points 40 comments -> [Landowner Sues After State Searches Property Without Warrant or Consent](https://www.agweb.com/news/business/farmland/rural-landowner-sues-after-state-searches-property-without-warrant-or-cons)<!-- HN:41927503:end --><!-- HN:41927286:start -->
* [41927286](https://news.social-protocols.org/stats?id=41927286) #9 24 points 17 comments -> [Show HN: Nix at work: FlakeHub Cache and private flakes](https://determinate.systems/posts/flakehub-cache-and-private-flakes/)<!-- HN:41927286:end --><!-- HN:41928708:start -->
* [41928708](https://news.social-protocols.org/stats?id=41928708) #13 8 points 0 comments -> [Bail Bond Insurers Are Lobbying to Keep People in Jail](https://jacobin.com/2024/10/bail-bonds-lobbyists-insurers-reform/)<!-- HN:41928708:end --><!-- HN:41927942:start -->
* [41927942](https://news.social-protocols.org/stats?id=41927942) #13 5 points 0 comments -> [The greenhouse gas footprint of liquefied natural gas (LNG) exported from the US](https://scijournals.onlinelibrary.wiley.com/doi/10.1002/ese3.1934)<!-- HN:41927942:end -->