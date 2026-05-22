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

#### **Saturday, May 16, 2026**
<!-- HN:48121143:start -->
* [48121143](https://news.social-protocols.org/stats?id=48121143) #14 6 points 0 comments -> [Matlab: Communications Toolbox](https://www.mathworks.com/products/communications.html)<!-- HN:48121143:end --><!-- HN:48158737:start -->
* [48158737](https://news.social-protocols.org/stats?id=48158737) #4 3 points 4 comments -> [Setting up an AI-native organization](https://aweb.ai/blog/ai-first-company-howto)<!-- HN:48158737:end --><!-- HN:48158110:start -->
* [48158110](https://news.social-protocols.org/stats?id=48158110) #26 39 points 41 comments -> [Someone Shared a Real Monet Painting as AI and Asked for Critiques](https://petapixel.com/2026/05/14/someone-shared-a-real-monet-painting-as-ai-and-asked-for-critiques/)<!-- HN:48158110:end --><!-- HN:48159604:start -->
* [48159604](https://news.social-protocols.org/stats?id=48159604) #14 6 points 2 comments -> [The End of Refugee Resettlement](https://www.newyorker.com/news/letter-from-jordan/the-end-of-refugee-resettlement)<!-- HN:48159604:end --><!-- HN:48160313:start -->
* [48160313](https://news.social-protocols.org/stats?id=48160313) #5 7 points 7 comments -> [I spent my whole career building passive income. Here's what I got wrong](https://dariusforoux.com/i-spent-my-whole-career-building-passive-income-heres-what-i-got-wrong/)<!-- HN:48160313:end --><!-- HN:48161891:start -->
* [48161891](https://news.social-protocols.org/stats?id=48161891) #26 -> [Impeaching Every Federal Judge and Justice Who Endorsed Unitary Executive Theory](https://cmarmitage.substack.com/p/the-case-for-impeaching-and-removing)<!-- HN:48161891:end --><!-- HN:48160837:start -->
* [48160837](https://news.social-protocols.org/stats?id=48160837) #27 25 points 4 comments -> [Mode collapse has a name, and he's selling cancer treatment advice on Amazon](https://danielmay.co.uk/posts/cheap-agents-alumni-shirts-and-elias-thorne/)<!-- HN:48160837:end --><!-- HN:48162431:start -->
* [48162431](https://news.social-protocols.org/stats?id=48162431) #30 6 points 0 comments -> [Show HN: Daily vibe-coding video games, day 33: Tower Defense (single prompt)](https://gamevibe.us/33-tower-defense)<!-- HN:48162431:end --><!-- HN:48161974:start -->
* [48161974](https://news.social-protocols.org/stats?id=48161974) #10 95 points 23 comments -> [Technofascism](https://third-bit.com/2026/05/15/technofascism/)<!-- HN:48161974:end -->
#### **Sunday, May 17, 2026**
<!-- HN:48120162:start -->
* [48120162](https://news.social-protocols.org/stats?id=48120162) #4 212 points 100 comments -> [Windows 9x Subsystem for Linux](https://codeberg.org/hails/wsl9x)<!-- HN:48120162:end --><!-- HN:48164229:start -->
* [48164229](https://news.social-protocols.org/stats?id=48164229) #9 31 points 14 comments -> [I tried to make Claude make me money on open-source bounties](https://github.com/ztc00/algora-scout/blob/main/POST.md)<!-- HN:48164229:end --><!-- HN:48127151:start -->
* [48127151](https://news.social-protocols.org/stats?id=48127151) #12 45 points 40 comments -> [Stochastic Parrots: Frequently Unasked Questions](https://medium.com/@emilymenonbender/stochastic-parrots-frequently-unasked-questions-49c2e7d22d11)<!-- HN:48127151:end --><!-- HN:48166275:start -->
* [48166275](https://news.social-protocols.org/stats?id=48166275) #5 19 points 9 comments -> [Show HN: Codiff, a local diff review tool](https://github.com/nkzw-tech/codiff/releases)<!-- HN:48166275:end --><!-- HN:48166877:start -->
* [48166877](https://news.social-protocols.org/stats?id=48166877) #26 44 points 13 comments -> [Ten Signs of Fascism. America has all of them](https://rutgerbregman.substack.com/p/10-signs-of-fascism-america-has-all)<!-- HN:48166877:end --><!-- HN:48167823:start -->
* [48167823](https://news.social-protocols.org/stats?id=48167823) #3 10 points 8 comments -> [Klaxon a livr earthquake map with no back end](https://klaxon.live/)<!-- HN:48167823:end --><!-- HN:48169255:start -->
* [48169255](https://news.social-protocols.org/stats?id=48169255) #13 12 points 0 comments -> [The ultimate female fantasy – A feminist critique of Beauty and the Beast](https://storica.club/blog/beast-was-the-best-part/)<!-- HN:48169255:end --><!-- HN:48170505:start -->
* [48170505](https://news.social-protocols.org/stats?id=48170505) #8 8 points 2 comments -> [Age Assurance on the Internet: Identity, Privacy, and the Limits of Verification](https://sphericalcowconsulting.com/2026/04/14/age-assurance/)<!-- HN:48170505:end --><!-- HN:48171948:start -->
* [48171948](https://news.social-protocols.org/stats?id=48171948) #5 12 points 1 comments -> [How a New Israeli Policy Cuts Off Humanitarian Aid in Gaza](https://www.newyorker.com/science/medical-dispatch/how-a-new-israeli-policy-cuts-off-humanitarian-aid-in-gaza)<!-- HN:48171948:end --><!-- HN:48171826:start -->
* [48171826](https://news.social-protocols.org/stats?id=48171826) #8 63 points 36 comments -> [The AI water issue is fake](https://blog.andymasley.com/p/the-ai-water-issue-is-fake)<!-- HN:48171826:end --><!-- HN:48168856:start -->
* [48168856](https://news.social-protocols.org/stats?id=48168856) #4 528 points 225 comments -> [Security researcher says Microsoft built a Bitlocker backdoor, releases exploit](https://www.techspot.com/news/112410-security-researcher-microsoft-secretly-built-backdoor-bitlocker-releases.html)<!-- HN:48168856:end --><!-- HN:48170247:start -->
* [48170247](https://news.social-protocols.org/stats?id=48170247) #18 90 points 22 comments -> [Dontsurveil.me](https://opencivics-labs.github.io/dontsurveil.me/c22.html)<!-- HN:48170247:end -->
#### **Monday, May 18, 2026**
<!-- HN:48175597:start -->
* [48175597](https://news.social-protocols.org/stats?id=48175597) #1 10 points 5 comments -> [Freelang – a Libc-free, direct sys/kernel call language with weird concurrency](https://freelang.dev)<!-- HN:48175597:end --><!-- HN:48175307:start -->
* [48175307](https://news.social-protocols.org/stats?id=48175307) #21 15 points 7 comments -> [Which country voted the best at Eurovision?](https://lalitm.com/post/which-country-voted-best-at-eurovision/)<!-- HN:48175307:end --><!-- HN:48176902:start -->
* [48176902](https://news.social-protocols.org/stats?id=48176902) #1 20 points 7 comments -> [Nobody Pushed Back: Why Engineers Stay Silent Until It's Too Late](https://howtocenterdiv.com/beyond-the-div/nobody-pushed-back)<!-- HN:48176902:end --><!-- HN:48153278:start -->
* [48153278](https://news.social-protocols.org/stats?id=48153278) #27 5 points 2 comments -> [The 30-Hour Shift That Turned a San Jose Robot Lab into a Global Spectacle](https://beeble.com/en/blog/the-30-hour-shift-that-turned-a-san-jose-robot-lab-into-a-global-spectacle)<!-- HN:48153278:end --><!-- HN:48178124:start -->
* [48178124](https://news.social-protocols.org/stats?id=48178124) #2 17 points 3 comments -> [The Global Fertility Crisis Is Worse Than You Probably Think](https://www.derekthompson.org/p/why-the-whole-world-stopped-having)<!-- HN:48178124:end --><!-- HN:48179026:start -->
* [48179026](https://news.social-protocols.org/stats?id=48179026) #27 7 points 3 comments -> [Should I take my car to the carwash 50M away or walk?](https://twitter.com/openservai/status/2055663644944576846)<!-- HN:48179026:end --><!-- HN:48179130:start -->
* [48179130](https://news.social-protocols.org/stats?id=48179130) #26 19 points 20 comments -> [Russia is starting to lose ground in Ukraine](https://www.economist.com/graphic-detail/2026/05/17/russia-is-starting-to-lose-ground-in-ukraine)<!-- HN:48179130:end --><!-- HN:48177584:start -->
* [48177584](https://news.social-protocols.org/stats?id=48177584) #23 -> [WHO declares major outbreak of Ebola virus species an international emergency](https://www.science.org/content/article/major-outbreak-rare-ebola-virus-species-northern-congo-alarms-scientists)<!-- HN:48177584:end --><!-- HN:48179467:start -->
* [48179467](https://news.social-protocols.org/stats?id=48179467) #15 7 points 1 comments -> [The American epoch of oil is collapsing. What comes next could be ugly](https://www.theguardian.com/us-news/ng-interactive/2026/may/17/america-china-energy-oil-renewables)<!-- HN:48179467:end --><!-- HN:48179931:start -->
* [48179931](https://news.social-protocols.org/stats?id=48179931) #10 26 points 5 comments -> [Shame them, shun them, ban them, beat them](https://www.experimental-history.com/p/shame-them-shun-them-ban-them-beat)<!-- HN:48179931:end --><!-- HN:48183060:start -->
* [48183060](https://news.social-protocols.org/stats?id=48183060) #4 62 points 20 comments -> [At least 100 deaths reported in Ebola outbreak in DR Congo](https://www.bbc.com/news/articles/cq6pz60p996o)<!-- HN:48183060:end --><!-- HN:48184921:start -->
* [48184921](https://news.social-protocols.org/stats?id=48184921) #11 7 points 5 comments -> [Crypto industry lobbies to evade AML/CTF rules](https://www.standwithcrypto.org/eu/en/manifesto)<!-- HN:48184921:end --><!-- HN:48184944:start -->
* [48184944](https://news.social-protocols.org/stats?id=48184944) #12 9 points 1 comments -> [The tyranny of single page apps](https://blog.bidisaster.party/spas/)<!-- HN:48184944:end --><!-- HN:48186326:start -->
* [48186326](https://news.social-protocols.org/stats?id=48186326) #17 44 points 27 comments -> [Mexican government breached by solo user with Claude, 150 GB exfiltrated](https://konstantintkachuk.com/writing/the-floor-doesnt-exist/)<!-- HN:48186326:end -->
#### **Tuesday, May 19, 2026**
<!-- HN:48187706:start -->
* [48187706](https://news.social-protocols.org/stats?id=48187706) #12 -> [Data Center Waste Heat as an Emerging Urban Thermal Hazard](https://asmedigitalcollection.asme.org/sustainablebuildings/article/doi/10.1115/1.4071922/1233035/Data-center-waste-heat-as-an-emerging-urban)<!-- HN:48187706:end --><!-- HN:48188908:start -->
* [48188908](https://news.social-protocols.org/stats?id=48188908) #8 7 points 1 comments -> [Bornagain.com](http://bornagain.com/)<!-- HN:48188908:end --><!-- HN:48189544:start -->
* [48189544](https://news.social-protocols.org/stats?id=48189544) #8 2 points 0 comments -> [Show HN: Closed Rings – A CLI-first time tracker for developers](https://closedrings.sh/en)<!-- HN:48189544:end --><!-- HN:48192727:start -->
* [48192727](https://news.social-protocols.org/stats?id=48192727) #18 33 points 9 comments -> [IDF struggles to curb endless feed of soldiers posting misdeeds on social media](https://www.timesofisrael.com/idf-struggles-to-throttle-endless-feed-of-soldiers-posting-misdeeds-on-social-media/)<!-- HN:48192727:end --><!-- HN:48193578:start -->
* [48193578](https://news.social-protocols.org/stats?id=48193578) #23 60 points 49 comments -> [Iran demands Big Tech pay fees for undersea Internet cables in Strait of Hormuz](https://arstechnica.com/tech-policy/2026/05/iran-demands-big-tech-pay-fees-for-undersea-internet-cables-in-strait-of-hormuz/)<!-- HN:48193578:end --><!-- HN:48195589:start -->
* [48195589](https://news.social-protocols.org/stats?id=48195589) #9 6 points 3 comments -> [Slopinator: Attack AI training with poisoned GitHub repositories](https://codeberg.org/the-slopinator/slopinator)<!-- HN:48195589:end --><!-- HN:48192397:start -->
* [48192397](https://news.social-protocols.org/stats?id=48192397) #24 104 points 19 comments -> [U.S. Cybersecurity Agency Leaves Its Digital Keys Out in Public on GitHub](https://gizmodo.com/the-worst-leak-that-ive-witnessed-u-s-cybersecurity-agency-leaves-its-digital-keys-out-in-public-on-github-2000760330)<!-- HN:48192397:end --><!-- HN:48195387:start -->
* [48195387](https://news.social-protocols.org/stats?id=48195387) #19 18 points 7 comments -> [RuView – See through walls with WiFi](https://github.com/ruvnet/RuView)<!-- HN:48195387:end --><!-- HN:48196008:start -->
* [48196008](https://news.social-protocols.org/stats?id=48196008) #13 9 points 6 comments -> [Raindrop Workshop: Your local OSS agent debugger](https://github.com/raindrop-ai/workshop)<!-- HN:48196008:end --><!-- HN:48195914:start -->
* [48195914](https://news.social-protocols.org/stats?id=48195914) #24 26 points 2 comments -> [Google IO 26 Keynote](https://www.youtube.com/watch?v=wYSncx9zLIU)<!-- HN:48195914:end --><!-- HN:48196656:start -->
* [48196656](https://news.social-protocols.org/stats?id=48196656) #1 171 points 1 comments -> [Gemini 3.5: frontier intelligence with action](https://blog.google/innovation-and-ai/models-and-research/gemini-models/gemini-3-5/)<!-- HN:48196656:end --><!-- HN:48196764:start -->
* [48196764](https://news.social-protocols.org/stats?id=48196764) #23 98 points 124 comments -> [Google Search as you know it is over](https://techcrunch.com/2026/05/19/google-search-as-you-know-it-is-over/)<!-- HN:48196764:end --><!-- HN:48169508:start -->
* [48169508](https://news.social-protocols.org/stats?id=48169508) #6 43 points 5 comments -> [KV Cache Is Becoming the Memory Hierarchy of Inference](https://touchdown-labs.com/blog/kv-cache-memory-hierarchy-inference.html)<!-- HN:48169508:end --><!-- HN:48197859:start -->
* [48197859](https://news.social-protocols.org/stats?id=48197859) #18 5 points 1 comments -> [Andrej Karpathy Joins Anthropic](https://www.thevccorner.com/p/breaking-andrej-karpathy-joins-anthropic)<!-- HN:48197859:end -->
#### **Wednesday, May 20, 2026**
<!-- HN:48200827:start -->
* [48200827](https://news.social-protocols.org/stats?id=48200827) #26 58 points 40 comments -> [Railway Is Having a Major Outage](https://status.railway.com/#/)<!-- HN:48200827:end --><!-- HN:48202993:start -->
* [48202993](https://news.social-protocols.org/stats?id=48202993) #6 249 points 6 comments -> [GitHub Compromised](https://twitter.com/i/status/2056949168208552080)<!-- HN:48202993:end --><!-- HN:48204998:start -->
* [48204998](https://news.social-protocols.org/stats?id=48204998) #15 3 points 0 comments -> [Watch RT Live Anywhere in the World](https://rtlive.ru)<!-- HN:48204998:end --><!-- HN:48204843:start -->
* [48204843](https://news.social-protocols.org/stats?id=48204843) #6 9 points 2 comments -> [The AI Quant Desk for Onchain Finance](https://grid.raster.finance/en/portfolio-analytics)<!-- HN:48204843:end --><!-- HN:48170546:start -->
* [48170546](https://news.social-protocols.org/stats?id=48170546) #15 9 points 1 comments -> [Show HN: Typeset sitelen pona and copy a PNG (for toki pona speakers)](https://sitelen.vercel.app/)<!-- HN:48170546:end --><!-- HN:48172366:start -->
* [48172366](https://news.social-protocols.org/stats?id=48172366) #24 7 points 5 comments -> [Enabling Resizable Bar on RTX 3080 Vbios via GitHub](https://github.com/danindiana/rtx3080-rebar-vbios/tree/master)<!-- HN:48172366:end --><!-- HN:48207509:start -->
* [48207509](https://news.social-protocols.org/stats?id=48207509) #5 27 points 41 comments -> [560-610 minutes of exercise a week needed for substantial heart benefits](https://bmjgroup.com/560-610-minutes-of-exercise-a-week-needed-for-substantial-heart-benefits/)<!-- HN:48207509:end --><!-- HN:48213666:start -->
* [48213666](https://news.social-protocols.org/stats?id=48213666) #26 16 points 1 comments -> [In Yesterday's IO Keynote Google Declared War on the Remnants of the Web](https://tldr.nettime.org/@tante/116605858023186072)<!-- HN:48213666:end --><!-- HN:48207004:start -->
* [48207004](https://news.social-protocols.org/stats?id=48207004) #25 887 points 700 comments -> [Goodbye Visa and Mastercard: 130M Europeans switching to sovereign payment](https://www.lesnumeriques.com/banque-en-ligne/adieu-visa-et-mastercard-130-millions-d-europeens-basculent-vers-un-paiement-100-souverain-des-2026-n250918.html)<!-- HN:48207004:end -->
#### **Thursday, May 21, 2026**
<!-- HN:48217052:start -->
* [48217052](https://news.social-protocols.org/stats?id=48217052) #21 133 points 3 comments -> [OpenAI to confidentially file for IPO as soon as Friday](https://www.cnbc.com/2026/05/20/openai-ipo-filing.html)<!-- HN:48217052:end --><!-- HN:48220829:start -->
* [48220829](https://news.social-protocols.org/stats?id=48220829) #9 13 points 6 comments -> [A Girl Who Couldn't Draw Home](https://www.gailweiner.com/post/the-girl-who-couldn-t-draw-home)<!-- HN:48220829:end --><!-- HN:48224161:start -->
* [48224161](https://news.social-protocols.org/stats?id=48224161) #22 3 points 1 comments -> [What 1,281 agent runs reveal about coding agent failure in large codebases](https://tessl.io/blog/coding-agent-failure-patterns-large-codebases/)<!-- HN:48224161:end --><!-- HN:48225399:start -->
* [48225399](https://news.social-protocols.org/stats?id=48225399) #8 5 points 0 comments -> [Wes mckinney releases multiple bangers](https://kenn.io/)<!-- HN:48225399:end --><!-- HN:48182797:start -->
* [48182797](https://news.social-protocols.org/stats?id=48182797) #23 6 points 1 comments -> [Starchild-1: The First Real-Time Multimodal World Model](https://odyssey.ml/introducing-starchild-1)<!-- HN:48182797:end --><!-- HN:48229260:start -->
* [48229260](https://news.social-protocols.org/stats?id=48229260) #20 29 points 8 comments -> [Curtis Yarvin and the Political Evolution of Silicon Valley Reactionaries](https://www.dontbeasucker.blog/p/the-butterflies-in-your-stomach)<!-- HN:48229260:end -->
#### **Friday, May 22, 2026**<!-- HN:48231256:start -->
* [48231256](https://news.social-protocols.org/stats?id=48231256) #8 7 points 3 comments -> [Coins Stream](https://coins.stream)<!-- HN:48231256:end --><!-- HN:48231674:start -->
* [48231674](https://news.social-protocols.org/stats?id=48231674) #2 -> [Show HN: Tight C, a systems language with 10 keywords](https://github.com/alonsovm44/tc-lang/)<!-- HN:48231674:end --><!-- HN:48232060:start -->
* [48232060](https://news.social-protocols.org/stats?id=48232060) #29 18 points 12 comments -> [Show HN: KVBoost – chunk-level KV cache reuse for HuggingFace, 5–48x faster TTFT](https://pythongiant.github.io/KVBoost/)<!-- HN:48232060:end --><!-- HN:48233289:start -->
* [48233289](https://news.social-protocols.org/stats?id=48233289) #1 22 points 13 comments -> [We should get rid of average CPU utilization](https://www.theocharis.dev/blog/why-we-should-get-rid-of-average-cpu-utilization/)<!-- HN:48233289:end --><!-- HN:48232901:start -->
* [48232901](https://news.social-protocols.org/stats?id=48232901) #18 7 points 0 comments -> [Pokélike](https://pokelike.xyz/)<!-- HN:48232901:end --><!-- HN:48222783:start -->
* [48222783](https://news.social-protocols.org/stats?id=48222783) #8 12 points 4 comments -> [Read the DNC's 2024 autopsy obtained by CNN](https://www.cnn.com/2026/05/21/politics/read-full-dnc-2024-autopsy-cnn)<!-- HN:48222783:end --><!-- HN:48235234:start -->
* [48235234](https://news.social-protocols.org/stats?id=48235234) #18 12 points 1 comments -> [Department of War Publishes Second Release of UAP Files](https://www.war.gov/UFO/?releaseDate=Release+02#records)<!-- HN:48235234:end --><!-- HN:48238896:start -->
* [48238896](https://news.social-protocols.org/stats?id=48238896) #3 59 points 24 comments -> [Microsoft Drops Claude Code After Budget Overrun](https://aiweekly.co/alerts/microsoft-drops-claude-code-after-budget-overrun)<!-- HN:48238896:end -->