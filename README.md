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

#### **Tuesday, October 15, 2024**
<!-- HN:41845075:start -->
* [41845075](https://news.social-protocols.org/stats?id=41845075) #25 5 points 0 comments -> [Riots and the far right: the global network behind the violence](https://news.sky.com/story/riots-and-the-far-right-the-global-network-behind-the-violence-13232023)<!-- HN:41845075:end --><!-- HN:41807954:start -->
* [41807954](https://news.social-protocols.org/stats?id=41807954) #8 37 points 17 comments -> ['Islands' of regularity discovered in the famously chaotic three-body problem](https://phys.org/news/2024-10-islands-regularity-famously-chaotic-body.html)<!-- HN:41807954:end --><!-- HN:41845624:start -->
* [41845624](https://news.social-protocols.org/stats?id=41845624) #18 23 points 11 comments -> [India's Renewable Energy Capacity Hits 200 GW Milestone, Accounts for 46.3%](https://www.ndtvprofit.com/business/india-renewable-energy-hits-200-gw-milestone-46-percent-total-power)<!-- HN:41845624:end --><!-- HN:41848053:start -->
* [41848053](https://news.social-protocols.org/stats?id=41848053) #9 8 points 3 comments -> [Looking for help for Bloxtor: A Free Open-Source Web App Framework](https://github.com/a19836/bloxtor)<!-- HN:41848053:end --><!-- HN:41845705:start -->
* [41845705](https://news.social-protocols.org/stats?id=41845705) #21 28 points 43 comments -> [The American economy has left other rich countries in the dust](https://www.economist.com/special-report/2024/10/14/the-american-economy-has-left-other-rich-countries-in-the-dust)<!-- HN:41845705:end --><!-- HN:41848935:start -->
* [41848935](https://news.social-protocols.org/stats?id=41848935) #11 5 points 0 comments -> [Announcing Our Updated Responsible Scaling Policy](https://www.anthropic.com/news/announcing-our-updated-responsible-scaling-policy)<!-- HN:41848935:end --><!-- HN:41850573:start -->
* [41850573](https://news.social-protocols.org/stats?id=41850573) #16 33 points 40 comments -> [Fable Is Winding Down](https://www.fable.app/blog/fable-is-winding-down)<!-- HN:41850573:end --><!-- HN:41852556:start -->
* [41852556](https://news.social-protocols.org/stats?id=41852556) #29 27 points 40 comments -> [X still struggles to grow subscription revenue](https://techcrunch.com/2024/10/15/elon-musks-x-still-struggles-to-grow-subscription-revenue/)<!-- HN:41852556:end -->
#### **Wednesday, October 16, 2024**<!-- HN:41855952:start -->
* [41855952](https://news.social-protocols.org/stats?id=41855952) #12 13 points 0 comments -> [Www.onedollarhomepage.com](https://www.onedollarhomepage.com/)<!-- HN:41855952:end --><!-- HN:41857194:start -->
* [41857194](https://news.social-protocols.org/stats?id=41857194) #25 9 points 4 comments -> [European Road Safety Orgs Are Terrified of the Cybertruck](https://gizmodo.com/european-road-safety-orgs-are-terrified-of-the-cybertruck-2000512122)<!-- HN:41857194:end --><!-- HN:41857290:start -->
* [41857290](https://news.social-protocols.org/stats?id=41857290) #14 74 points 43 comments -> [Can't trust any VPN these days](https://blog.orhun.dev/cant-trust-any-vpn/)<!-- HN:41857290:end --><!-- HN:41857503:start -->
* [41857503](https://news.social-protocols.org/stats?id=41857503) #17 30 points 42 comments -> [Commission concludes that X should not be designated under the DMA](https://ec.europa.eu/commission/presscorner/detail/en/mex_24_5324)<!-- HN:41857503:end --><!-- HN:41858307:start -->
* [41858307](https://news.social-protocols.org/stats?id=41858307) #12 14 points 10 comments -> [Intel spends more on R&D than Nvidia and AMD combined](https://www.tomshardware.com/tech-industry/intel-spends-more-on-r-and-d-than-nvidia-and-amd-combined-yet-continues-to-lag-in-market-cap-nvidia-spends-almost-2x-more-than-amd)<!-- HN:41858307:end --><!-- HN:41858854:start -->
* [41858854](https://news.social-protocols.org/stats?id=41858854) #9 -> [Show HN: Engine – AI-powered IDE in the browser](https://app.enginelabs.ai/)<!-- HN:41858854:end --><!-- HN:41860835:start -->
* [41860835](https://news.social-protocols.org/stats?id=41860835) #6 10 points 0 comments -> [The open future of networking hardware for AI](https://engineering.fb.com/2024/10/15/data-infrastructure/open-future-networking-hardware-ai-ocp-2024-meta/)<!-- HN:41860835:end --><!-- HN:41860855:start -->
* [41860855](https://news.social-protocols.org/stats?id=41860855) #22 5 points 2 comments -> [The University of Michigan Doubled Down on DEI What Went Wrong?](https://www.nytimes.com/2024/10/16/magazine/dei-university-michigan.html)<!-- HN:41860855:end --><!-- HN:41862360:start -->
* [41862360](https://news.social-protocols.org/stats?id=41862360) #27 3 points 0 comments -> [Forgejo v9.0 Is Available](https://forgejo.org/2024-10-release-v9-0/)<!-- HN:41862360:end --><!-- HN:41861838:start -->
* [41861838](https://news.social-protocols.org/stats?id=41861838) #10 19 points 0 comments -> [The Sound of the Dialup, Pictured](https://www.windytan.com/2012/11/the-sound-of-dialup-pictured.html)<!-- HN:41861838:end --><!-- HN:41845322:start -->
* [41845322](https://news.social-protocols.org/stats?id=41845322) #11 8 points 0 comments -> [10B Integers Walk into an Array](https://donraab.medium.com/10-billion-integers-walk-into-an-array-37097386c964)<!-- HN:41845322:end --><!-- HN:41864794:start -->
* [41864794](https://news.social-protocols.org/stats?id=41864794) #25 4 points 0 comments -> [Ollama can run any GGUF Model on Hugging Face Hub now](https://huggingface.co/docs/hub/en/ollama)<!-- HN:41864794:end -->
#### **Thursday, October 17, 2024**
<!-- HN:41866521:start -->
* [41866521](https://news.social-protocols.org/stats?id=41866521) #25 9 points 6 comments -> [Critical default credentials in Kubernetes allows SSH root access](https://www.theregister.com/2024/10/16/critical_kubernetes_image_builder_bug/)<!-- HN:41866521:end --><!-- HN:41867861:start -->
* [41867861](https://news.social-protocols.org/stats?id=41867861) #16 28 points 40 comments -> [EV battery prices to fall by nearly 50 pct and near ICE parity by 2026](https://thedriven.io/2024/10/16/ev-battery-prices-to-fall-by-nearly-50-pct-and-near-ice-parity-by-2026-says-goldman-sachs/)<!-- HN:41867861:end --><!-- HN:41868609:start -->
* [41868609](https://news.social-protocols.org/stats?id=41868609) #2 10 points 1 comments -> [Show HN: Last CLI tool you will need](https://tushynski.me/from-documentation-chaos-to-terminal-clarity-last-cli-you-will-need/)<!-- HN:41868609:end --><!-- HN:41867294:start -->
* [41867294](https://news.social-protocols.org/stats?id=41867294) #16 40 points 30 comments -> [Show HN: I'm building a Product Hunt alternative, it's 4 days old](https://www.launching.today/)<!-- HN:41867294:end --><!-- HN:41867608:start -->
* [41867608](https://news.social-protocols.org/stats?id=41867608) #15 52 points 10 comments -> [Raspberry Pi 3 fastboot in less than 2 seconds](https://www.furkantokac.com/rpi3-fast-boot-less-than-2-seconds/)<!-- HN:41867608:end --><!-- HN:41869962:start -->
* [41869962](https://news.social-protocols.org/stats?id=41869962) #12 -> [Marissa Mayer: I Am Not a Feminist. I Am Not Neurodivergent:I Am a Software Girl](https://www.wired.com/story/big-interview-marissa-mayer-yahoo-sunshine-ai/)<!-- HN:41869962:end --><!-- HN:41870190:start -->
* [41870190](https://news.social-protocols.org/stats?id=41870190) #17 10 points 1 comments -> [For the love of God, stop talking about "post-truth"](https://www.conspicuouscognition.com/p/for-the-love-of-god-stop-talking)<!-- HN:41870190:end --><!-- HN:41870198:start -->
* [41870198](https://news.social-protocols.org/stats?id=41870198) #16 26 points 26 comments -> [I Went from Reading 40 Books a Year to Reading 0](https://durmonski.com/self-improvement/from-reading-40-books-to-reading-0/)<!-- HN:41870198:end --><!-- HN:41870289:start -->
* [41870289](https://news.social-protocols.org/stats?id=41870289) #21 7 points 1 comments -> [Meta under fire for 'polluting' open-source](https://www.ft.com/content/397c50d8-8796-4042-a814-0ac2c068361f)<!-- HN:41870289:end --><!-- HN:41870912:start -->
* [41870912](https://news.social-protocols.org/stats?id=41870912) #12 10 points 2 comments -> [How Software Companies Die](https://gist.githubusercontent.com/eliot-akira/6eaecda619d0fafd1d74/raw/4dcb405f0f604c240e3eabb5ecf88d143cf99582/how-software-companies-die)<!-- HN:41870912:end --><!-- HN:41871918:start -->
* [41871918](https://news.social-protocols.org/stats?id=41871918) #7 6 points 0 comments -> [UK police raid home, seize devices of Electronic Intifada's Asa Winstanley](https://electronicintifada.net/blogs/ali-abunimah/uk-police-raid-home-seize-devices-eis-asa-winstanley)<!-- HN:41871918:end --><!-- HN:41870685:start -->
* [41870685](https://news.social-protocols.org/stats?id=41870685) #22 10 points 7 comments -> [Show HN: MusicAny – I Build an AI Music Generator with Music Genre Knowledge](https://musicany.com)<!-- HN:41870685:end -->
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
* [41858172](https://news.social-protocols.org/stats?id=41858172) #17 22 points 3 comments -> [Understanding Pam and Creating a Custom Module in Python – Inside Out Insights](https://text.tchncs.de/ioi/in-todays-interconnected-world-user-authentication-plays-a-critical-role-in)<!-- HN:41858172:end --><!-- HN:41886047:start -->
* [41886047](https://news.social-protocols.org/stats?id=41886047) #11 7 points 1 comments -> [Implementing Brainfuck in APL](https://blog.wilsonb.com/posts/2024-09-27-brainfuck.html)<!-- HN:41886047:end --><!-- HN:41855537:start -->
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
* [41899765](https://news.social-protocols.org/stats?id=41899765) #15 7 points 5 comments -> [Google's AI prophet fast tracks singularity prediction](https://www.independent.co.uk/tech/ai-singularity-date-ray-kurzweil-google-b2511847.html)<!-- HN:41899765:end --><!-- HN:41900528:start -->
* [41900528](https://news.social-protocols.org/stats?id=41900528) #12 7 points 0 comments -> [The "child identifies as wolf" story was only ever about bullying](https://www.skeptic.org.uk/2024/10/the-child-identifies-as-wolf-story-was-only-ever-about-bullying-not-species-confusion/)<!-- HN:41900528:end -->