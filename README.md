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

#### **Tuesday, September 10, 2024**
<!-- HN:41452780:start -->
* [41452780](https://news.social-protocols.org/stats?id=41452780) #29 118 points 27 comments -> [Paper types ranked by likelihood of paper cuts](https://phys.org/news/2024-08-paper-likelihood.html)<!-- HN:41452780:end --><!-- HN:41498640:start -->
* [41498640](https://news.social-protocols.org/stats?id=41498640) #5 10 points 3 comments -> [Huawei Unveils $2,800 Trifold Mate XT Just Hours After Apple Launches iPhone 16](https://www.bloomberg.com/news/articles/2024-09-10/huawei-trifold-phone-versus-iphone-16-specs-price-release-date)<!-- HN:41498640:end --><!-- HN:41496254:start -->
* [41496254](https://news.social-protocols.org/stats?id=41496254) #13 238 points 170 comments -> [DOJ claims Google has "trifecta of monopolies" on Day 1 of ad tech trial](https://arstechnica.com/tech-policy/2024/09/doj-claims-google-has-trifecta-of-monopolies-on-day-1-of-ad-tech-trial/)<!-- HN:41496254:end --><!-- HN:41498643:start -->
* [41498643](https://news.social-protocols.org/stats?id=41498643) #29 11 points 0 comments -> [Google's 2.4B euro fine upheld by Europe's top court in EU antitrust probe](https://www.cnbc.com/2024/09/10/googles-2point4-billion-euro-fine-upheld-by-europes-top-court.html)<!-- HN:41498643:end --><!-- HN:41499452:start -->
* [41499452](https://news.social-protocols.org/stats?id=41499452) #13 7 points 0 comments -> [The FBI spent decades tracking mathematician Paul Erdős](https://www.muckrock.com/news/archives/2015/jul/21/nothing-indicate-nothing-indicate-subject-had-any-/)<!-- HN:41499452:end --><!-- HN:41499855:start -->
* [41499855](https://news.social-protocols.org/stats?id=41499855) #1 27 points 14 comments -> [Meta's Hack (HHVM) language appears to be no longer maintained](https://github.com/facebook/hhvm/graphs/commit-activity)<!-- HN:41499855:end --><!-- HN:41495871:start -->
* [41495871](https://news.social-protocols.org/stats?id=41495871) #10 100 points 37 comments -> [Affordable DE10-Nano compatible boards for MiSTer FPGA retro platform](https://www.retrorgb.com/mister-pi-de-10-nano-clone-up-for-sale-today.html)<!-- HN:41495871:end --><!-- HN:41500419:start -->
* [41500419](https://news.social-protocols.org/stats?id=41500419) #29 5 points 0 comments -> [In Slingshot, a mission to Titan goes off course](https://spacenews.com/in-slingshot-a-mission-to-titan-goes-off-course/)<!-- HN:41500419:end --><!-- HN:41500402:start -->
* [41500402](https://news.social-protocols.org/stats?id=41500402) #30 4 points 0 comments -> [Epilepsy drug shows promise in reducing obstructive sleep apnea symptoms](https://www.ajmc.com/view/epilepsy-drug-shows-promise-in-reducing-obstructive-sleep-apnea-symptoms)<!-- HN:41500402:end --><!-- HN:41500201:start -->
* [41500201](https://news.social-protocols.org/stats?id=41500201) #20 38 points 27 comments -> [Bank of America raises minimum hourly pay to $24, as tellers flee the industry](https://www.npr.org/2024/09/10/nx-s1-5106884/bank-of-america-raises-hourly-pay-tellers-flee-banking)<!-- HN:41500201:end --><!-- HN:41495762:start -->
* [41495762](https://news.social-protocols.org/stats?id=41495762) #29 69 points 40 comments -> [Tesla FSD no longer offered for purchase](https://www.notateslaapp.com/news/2245/tesla-updates-fsd-package-can-now-only-buy-fsd-supervised)<!-- HN:41495762:end --><!-- HN:41500799:start -->
* [41500799](https://news.social-protocols.org/stats?id=41500799) #3 5 points 2 comments -> [Budget-friendly DIY video surveillance](https://felenasoft.com/xeoma/en/articles/diy-video-surveillance-system/)<!-- HN:41500799:end --><!-- HN:41500768:start -->
* [41500768](https://news.social-protocols.org/stats?id=41500768) #29 8 points 0 comments -> [BitKeeper, Linux, and licensing disputes: How Linus wrote Git in 14 days](https://lwn.net/Articles/974914/)<!-- HN:41500768:end --><!-- HN:41498529:start -->
* [41498529](https://news.social-protocols.org/stats?id=41498529) #6 47 points 7 comments -> [SQL powered operating system instrumentation, monitoring, and analytics](https://github.com/osquery/osquery)<!-- HN:41498529:end --><!-- HN:41500136:start -->
* [41500136](https://news.social-protocols.org/stats?id=41500136) #29 15 points 1 comments -> [Overweight Ford F-750 Plunges Through Historic Wooden Bridge in Maine](https://www.thedrive.com/news/overweight-ford-f-750-plunges-through-historic-wooden-bridge-in-maine)<!-- HN:41500136:end --><!-- HN:41501714:start -->
* [41501714](https://news.social-protocols.org/stats?id=41501714) #14 26 points 40 comments -> [Sony announces PS5 Pro, a $700 graphics workhorse available Nov. 7](https://arstechnica.com/gaming/2024/09/sony-announces-ps5-pro-a-700-graphics-workhorse-available-nov-7/)<!-- HN:41501714:end --><!-- HN:41500861:start -->
* [41500861](https://news.social-protocols.org/stats?id=41500861) #25 8 points 8 comments -> [Show HN: I built a cheaper ChatGPT alternative that runs on your desktop](https://www.trynyro.com)<!-- HN:41500861:end --><!-- HN:41504881:start -->
* [41504881](https://news.social-protocols.org/stats?id=41504881) #17 26 points 40 comments -> [The US finally takes aim at truck bloat](https://www.theverge.com/2024/9/10/24241047/nhtsa-rule-pedestrian-safety-fmvss-suv-truck-design)<!-- HN:41504881:end --><!-- HN:41459722:start -->
* [41459722](https://news.social-protocols.org/stats?id=41459722) #16 23 points 8 comments -> [DJI Neo review – a drone that can do everything, and land in your hand](https://www.digitalcameraworld.com/reviews/dji-neo-review)<!-- HN:41459722:end -->
#### **Wednesday, September 11, 2024**
<!-- HN:41508158:start -->
* [41508158](https://news.social-protocols.org/stats?id=41508158) #9 61 points 39 comments -> [Facebook uses Australian adults public photos/posts to train AI, without opt-out](https://www.abc.net.au/news/2024-09-11/facebook-scraping-photos-data-no-opt-out/104336170)<!-- HN:41508158:end --><!-- HN:41508244:start -->
* [41508244](https://news.social-protocols.org/stats?id=41508244) #8 29 points 40 comments -> [Common mistakes when using the metric system](https://www.nayuki.io/page/common-mistakes-when-using-the-metric-system)<!-- HN:41508244:end --><!-- HN:41510008:start -->
* [41510008](https://news.social-protocols.org/stats?id=41510008) #4 6 points 14 comments -> [UK Shops can refuse to take cash even though it's legal tender (2023)](https://fullfact.org/online/legal-tender-cash-in-shops/)<!-- HN:41510008:end --><!-- HN:41510774:start -->
* [41510774](https://news.social-protocols.org/stats?id=41510774) #3 -> [CPI for all items rises 2.5%; shelter up](https://www.bls.gov/news.release/archives/cpi_09112024.htm)<!-- HN:41510774:end --><!-- HN:41508321:start -->
* [41508321](https://news.social-protocols.org/stats?id=41508321) #7 46 points 10 comments -> [Casio WQV2 Wrist Camera Photos](https://www.urban75.org/watchcam/index.html)<!-- HN:41508321:end --><!-- HN:41509713:start -->
* [41509713](https://news.social-protocols.org/stats?id=41509713) #15 155 points 40 comments -> [Radicle 1.0 – A Local-First, P2P Alternative to GitHub](https://radicle.xyz/2024/09/10/radicle-1.0.html)<!-- HN:41509713:end --><!-- HN:41510566:start -->
* [41510566](https://news.social-protocols.org/stats?id=41510566) #18 14 points 9 comments -> [Europe has opened a door to a universal wallet](https://thenextweb.com/news/eu-digital-id-supports-universal-digital-wallet)<!-- HN:41510566:end --><!-- HN:41509922:start -->
* [41509922](https://news.social-protocols.org/stats?id=41509922) #25 3 points 0 comments -> [Samsung Electronics plans global job cuts of up to 30% in some divisions](https://www.reuters.com/technology/samsung-elec-plans-global-job-cuts-up-30-some-divisions-sources-say-2024-09-11/)<!-- HN:41509922:end --><!-- HN:41511139:start -->
* [41511139](https://news.social-protocols.org/stats?id=41511139) #26 4 points 3 comments -> [Debate in nuclear-armed former colony fails to reassure global community](https://www.aljazeera.com/opinions/2024/9/11/debate-in-nuclear-armed-former-colony-fails-to-reassure-global-community)<!-- HN:41511139:end --><!-- HN:41511987:start -->
* [41511987](https://news.social-protocols.org/stats?id=41511987) #8 5 points 0 comments -> [Human drivers are to blame for most serious Waymo collisions](https://www.understandingai.org/p/human-drivers-are-to-blame-for-most)<!-- HN:41511987:end --><!-- HN:41509742:start -->
* [41509742](https://news.social-protocols.org/stats?id=41509742) #12 87 points 21 comments -> [Binsider – A TUI for analyzing Linux binaries](https://binsider.dev/)<!-- HN:41509742:end --><!-- HN:41511672:start -->
* [41511672](https://news.social-protocols.org/stats?id=41511672) #29 48 points 9 comments -> [Device Tree Patches Posted for Review to Boot Linux on Apple A7 to A11 Devices](https://www.phoronix.com/news/Linux-DT-Patches-A7-To-A11)<!-- HN:41511672:end --><!-- HN:41513293:start -->
* [41513293](https://news.social-protocols.org/stats?id=41513293) #28 10 points 0 comments -> [Senators Believe AI Summaries May Be an Antitrust Violation](https://gizmodo.com/senators-call-on-ftc-to-investigate-ai-summaries-as-an-antitrust-violation-2000497441)<!-- HN:41513293:end --><!-- HN:41513775:start -->
* [41513775](https://news.social-protocols.org/stats?id=41513775) #16 27 points 43 comments -> [Swiss BMW Driver Slammed with $116,000 Tailgating Fine Because He's Rich](https://www.thedrive.com/news/swiss-bmw-driver-slammed-with-116000-tailgating-fine-because-hes-rich)<!-- HN:41513775:end -->
#### **Thursday, September 12, 2024**<!-- HN:41516997:start -->
* [41516997](https://news.social-protocols.org/stats?id=41516997) #22 22 points 40 comments -> [Sony Turns to AI to Tackle Rising Animation Costs and Animator Shortage](https://www.cartoonbrew.com/business/sony-wants-to-produce-more-animation-content-but-hampered-by-animator-shortage-high-costs-242893.html)<!-- HN:41516997:end --><!-- HN:41517811:start -->
* [41517811](https://news.social-protocols.org/stats?id=41517811) #26 10 points 2 comments -> [Live SpaceX Polaris Dawn Spacewalk](https://www.youtube.com/watch?v=_FbnAmkb9bE)<!-- HN:41517811:end --><!-- HN:41483617:start -->
* [41483617](https://news.social-protocols.org/stats?id=41483617) #18 25 points 9 comments -> [[Deploying a basic React site pt 1] Setting up a self-hosted Kubernetes cluster](https://jpegsfiles.medium.com/deploying-a-basic-react-site-part-1-setting-up-a-kubernetes-cluster-hosted-on-a-home-server-8db517d2bcda)<!-- HN:41483617:end --><!-- HN:41515792:start -->
* [41515792](https://news.social-protocols.org/stats?id=41515792) #24 12 points 1 comments -> [New PostmarketOS installations now by default use doas instead of sudo](https://postmarketos.org/edge/2024/09/11/doas-instead-of-sudo/)<!-- HN:41515792:end --><!-- HN:41516783:start -->
* [41516783](https://news.social-protocols.org/stats?id=41516783) #20 7 points 1 comments -> [ISO Panel – Trust in AI: How to build global confidence [video]](https://www.iso.org/annualmeeting/session/ai/trust)<!-- HN:41516783:end --><!-- HN:41514727:start -->
* [41514727](https://news.social-protocols.org/stats?id=41514727) #29 155 points 32 comments -> [Mistral releases Pixtral 12B, its first multimodal model](https://techcrunch.com/2024/09/11/mistral-releases-pixtral-its-first-multimodal-model/)<!-- HN:41514727:end --><!-- HN:41519298:start -->
* [41519298](https://news.social-protocols.org/stats?id=41519298) #6 5 points 1 comments -> [The True Nature of LLMs](https://opengpa.ghost.io/the-true-nature-of-llms-2/)<!-- HN:41519298:end --><!-- HN:41519753:start -->
* [41519753](https://news.social-protocols.org/stats?id=41519753) #28 6 points 1 comments -> [Guile 3.10 now ships with support for parens-optional syntax (wisp)](https://www.draketo.de/software/wisp#guile-3.0.10)<!-- HN:41519753:end --><!-- HN:41519283:start -->
* [41519283](https://news.social-protocols.org/stats?id=41519283) #14 41 points 37 comments -> [AI took their jobs. Now they get paid to make it sound human](https://www.bbc.com/future/article/20240612-the-people-making-ai-sound-more-human)<!-- HN:41519283:end --><!-- HN:41519567:start -->
* [41519567](https://news.social-protocols.org/stats?id=41519567) #10 19 points 2 comments -> [SpaceX Polaris Dawn crew attempts first private spacewalk [video]](https://www.youtube.com/watch?v=ABQBEdOzrV0)<!-- HN:41519567:end --><!-- HN:41519736:start -->
* [41519736](https://news.social-protocols.org/stats?id=41519736) #13 104 points 80 comments -> [Officer who ignored NYPD's 'courtesy cards' receives $175K settlement](https://apnews.com/article/nypd-courtesy-card-police-misconduct-d5dfdbdad12b01a2cda864f69aa3d1aa)<!-- HN:41519736:end --><!-- HN:41519732:start -->
* [41519732](https://news.social-protocols.org/stats?id=41519732) #12 22 points 8 comments -> [A Stock Prius just drove across America averaging 93.158 MPG](https://www.theautopian.com/a-prius-just-drove-across-america-averaging-93-158-mpg-setting-a-guinness-world-record/)<!-- HN:41519732:end --><!-- HN:41478024:start -->
* [41478024](https://news.social-protocols.org/stats?id=41478024) #19 12 points 9 comments -> [I wish (Linux) WireGuard had a simple way to restrict peer public IPs](https://utcc.utoronto.ca/~cks/space/blog/linux/WireGuardIPRestrictionWish)<!-- HN:41478024:end --><!-- HN:41520540:start -->
* [41520540](https://news.social-protocols.org/stats?id=41520540) #18 3 points 0 comments -> [A Beginner's Guide to Terraform](https://blog.they.consulting/a-beginners-guide-to-terraform/)<!-- HN:41520540:end --><!-- HN:41523033:start -->
* [41523033](https://news.social-protocols.org/stats?id=41523033) #19 22 points 3 comments -> [OpenAI O1](https://openai.com/index/introducing-openai-o1-preview/)<!-- HN:41523033:end --><!-- HN:41522319:start -->
* [41522319](https://news.social-protocols.org/stats?id=41522319) #19 15 points 4 comments -> [Show HN: Ask LLMs to predict anything based on news](https://aipredict.fun/)<!-- HN:41522319:end --><!-- HN:41522005:start -->
* [41522005](https://news.social-protocols.org/stats?id=41522005) #25 12 points 7 comments -> [Self-Hosting at Home and Privacy](https://dataswamp.org/~solene/2024-09-10-self-hosting-at-home-privacy-issues.html)<!-- HN:41522005:end --><!-- HN:41525331:start -->
* [41525331](https://news.social-protocols.org/stats?id=41525331) #5 3 points 2 comments -> [OpenAI O1](https://openaio1.info)<!-- HN:41525331:end --><!-- HN:41524441:start -->
* [41524441](https://news.social-protocols.org/stats?id=41524441) #22 4 points 1 comments -> [Why sunlight in your eyes makes you healthier](https://jdnoc.com/light/)<!-- HN:41524441:end -->
#### **Friday, September 13, 2024**
<!-- HN:41475975:start -->
* [41475975](https://news.social-protocols.org/stats?id=41475975) #21 191 points 29 comments -> [DEF Con 32 – AMD Sinkclose Universal Ring-2 Privilege Escalation (Not Redacted) [pdf]](https://media.defcon.org/DEF%20CON%2032/DEF%20CON%2032%20presentations/DEF%20CON%2032%20-%20Enrique%20Nissim%20Krzysztof%20Okupski%20-%20AMD%20Sinkclose%20Universal%20Ring-2%20Privilege%20Escalation.pdf)<!-- HN:41475975:end --><!-- HN:41479487:start -->
* [41479487](https://news.social-protocols.org/stats?id=41479487) #23 72 points 2 comments -> [Show HN: Goroutine Monitor Powered by eBPF](https://github.com/keisku/gmon)<!-- HN:41479487:end --><!-- HN:41523070:start -->
* [41523070](https://news.social-protocols.org/stats?id=41523070) #19 1577 points 1186 comments -> [Learning to Reason with LLMs](https://openai.com/index/learning-to-reason-with-llms/)<!-- HN:41523070:end --><!-- HN:41481514:start -->
* [41481514](https://news.social-protocols.org/stats?id=41481514) #4 208 points 169 comments -> [Swimmable Cities](https://www.swimmablecities.org)<!-- HN:41481514:end --><!-- HN:41531209:start -->
* [41531209](https://news.social-protocols.org/stats?id=41531209) #23 10 points 1 comments -> [Florida officials investigate voters who signed abortion ballot initiative](https://www.theguardian.com/us-news/2024/sep/13/florida-abortion-petition-investigation)<!-- HN:41531209:end --><!-- HN:41488821:start -->
* [41488821](https://news.social-protocols.org/stats?id=41488821) #30 36 points 11 comments -> [Two Useful Prompts to Explore Intent and Behaviour](https://adrianhoward.com/posts/two-prompts-to-explore-intent-and-behaviour/)<!-- HN:41488821:end --><!-- HN:41531558:start -->
* [41531558](https://news.social-protocols.org/stats?id=41531558) #3 7 points 0 comments -> [Funded by YC (Your Cents)](https://www.fundedbyyc.com/)<!-- HN:41531558:end --><!-- HN:41490813:start -->
* [41490813](https://news.social-protocols.org/stats?id=41490813) #16 12 points 8 comments -> [The Roman siege of Masada lasted just a few weeks, not several years](https://phys.org/news/2024-09-roman-siege-masada-weeks-years.html)<!-- HN:41490813:end --><!-- HN:41531689:start -->
* [41531689](https://news.social-protocols.org/stats?id=41531689) #28 6 points 0 comments -> [Packed structs in Zig make bit/flag sets trivial](https://devlog.hexops.com/2022/packed-structs-in-zig/)<!-- HN:41531689:end --><!-- HN:41532564:start -->
* [41532564](https://news.social-protocols.org/stats?id=41532564) #11 8 points 1 comments -> [Affirmative Action Was Banned. What Happened Next Was Confusing](https://www.nytimes.com/2024/09/13/us/affirmative-action-ban-campus-diversity.html)<!-- HN:41532564:end --><!-- HN:41532605:start -->
* [41532605](https://news.social-protocols.org/stats?id=41532605) #8 -> [Americans Clicked Ads to Get Free Cash. Their Health Insurance Changed Instead](https://www.wsj.com/health/healthcare/social-media-ads-health-insurance-scams-37d1ecfa)<!-- HN:41532605:end --><!-- HN:41533359:start -->
* [41533359](https://news.social-protocols.org/stats?id=41533359) #5 9 points 14 comments -> [Why freedom of speech is a wicked problem](https://no-kill-switch.ghost.io/why-freedom-of-speech-is-a-wicked-problem/)<!-- HN:41533359:end --><!-- HN:41533784:start -->
* [41533784](https://news.social-protocols.org/stats?id=41533784) #15 10 points 41 comments -> [Older Americans Are About to Lose a Lot of Weight](https://www.theatlantic.com/health/archive/2024/02/ozempic-weight-loss-older-americans-boomers/677371/)<!-- HN:41533784:end --><!-- HN:41534396:start -->
* [41534396](https://news.social-protocols.org/stats?id=41534396) #21 8 points 2 comments -> [Richard Powers on What We Do to the Earth and What It Does to Us](https://www.newyorker.com/magazine/2024/09/16/richard-powers-profile)<!-- HN:41534396:end -->
#### **Saturday, September 14, 2024**
<!-- HN:41536041:start -->
* [41536041](https://news.social-protocols.org/stats?id=41536041) #22 15 points 29 comments -> [Tesla Cybertruck sales surge 61% in July, outsells direct rivals](https://www.teslarati.com/tesla-cybertruck-sales-61-percent-july-outsells-all-rivals-sp-global-mobility/)<!-- HN:41536041:end --><!-- HN:41486107:start -->
* [41486107](https://news.social-protocols.org/stats?id=41486107) #29 53 points 8 comments -> [Build Simple Fuzzer (2020)](https://carstein.github.io/fuzzing/2020/04/18/writing-simple-fuzzer-1.html)<!-- HN:41486107:end --><!-- HN:41537358:start -->
* [41537358](https://news.social-protocols.org/stats?id=41537358) #22 40 points 40 comments -> [Brazil Supreme Court unfreezes X, Starlink's bank accounts after taking $3.3M](https://thehill.com/policy/technology/4879133-brazil-unfreezes-starlink-x-assets/)<!-- HN:41537358:end --><!-- HN:41538326:start -->
* [41538326](https://news.social-protocols.org/stats?id=41538326) #21 -> [Losses widen at Stripe Europe to $1.1B after employee 'liquidity event'](https://www.irishtimes.com/business/2024/09/13/losses-widen-at-stripe-europe-to-11bn-after-employee-liquidity-event/)<!-- HN:41538326:end --><!-- HN:41535694:start -->
* [41535694](https://news.social-protocols.org/stats?id=41535694) #13 175 points 87 comments -> [OpenAI o1 Results on ARC-AGI-Pub](https://arcprize.org/blog/openai-o1-results-arc-prize)<!-- HN:41535694:end --><!-- HN:41501912:start -->
* [41501912](https://news.social-protocols.org/stats?id=41501912) #15 111 points 50 comments -> [Jerry Neumann: Resignation Letter](https://reactionwheel.net/2024/09/resignation-letter.html)<!-- HN:41501912:end --><!-- HN:41537994:start -->
* [41537994](https://news.social-protocols.org/stats?id=41537994) #15 29 points 26 comments -> [Who is responsible for the greatest change to our language? Teenage girls](https://www.abc.net.au/news/2024-08-04/teenage-girls-linguistics/104160082)<!-- HN:41537994:end --><!-- HN:41538572:start -->
* [41538572](https://news.social-protocols.org/stats?id=41538572) #21 7 points 1 comments -> [Self-Verification Theory](https://en.wikipedia.org/wiki/Self-verification_theory)<!-- HN:41538572:end --><!-- HN:41538595:start -->
* [41538595](https://news.social-protocols.org/stats?id=41538595) #12 8 points 3 comments -> [Sunamp's thermal battery uses a chemical found in salt-and-vinegar potato chips](https://techcrunch.com/2024/09/08/sunamps-thermal-battery-uses-a-chemical-found-in-salt-and-vinegar-potato-chips/)<!-- HN:41538595:end --><!-- HN:41538273:start -->
* [41538273](https://news.social-protocols.org/stats?id=41538273) #23 38 points 79 comments -> [Show HN: I removed politics from Twitter with AI](https://www.mindfw.com)<!-- HN:41538273:end --><!-- HN:41539653:start -->
* [41539653](https://news.social-protocols.org/stats?id=41539653) #28 4 points 0 comments -> [Canadian military admits new sleeping bags are not suited to Canadian winters](https://www.theguardian.com/world/2024/sep/13/canada-military-sleeping-bags)<!-- HN:41539653:end --><!-- HN:41539553:start -->
* [41539553](https://news.social-protocols.org/stats?id=41539553) #17 15 points 3 comments -> [Thomas Piketty: 'The Draghi report is a step in the right direction'](https://www.lemonde.fr/en/opinion/article/2024/09/14/thomas-piketty-the-draghi-report-is-a-step-in-the-right-direction_6725996_23.html)<!-- HN:41539553:end --><!-- HN:41541481:start -->
* [41541481](https://news.social-protocols.org/stats?id=41541481) #7 5 points 6 comments -> [Sweden to pay refugees up to 341,00 USD to return](https://www.dn.se/sverige/regeringen-hojer-atervandringsbidraget-kraftigt/)<!-- HN:41541481:end --><!-- HN:41541678:start -->
* [41541678](https://news.social-protocols.org/stats?id=41541678) #30 3 points 2 comments -> [Accha FM – World's First 100% AI Generated Audio Entertainment Super App](https://acchafm.com/)<!-- HN:41541678:end -->
#### **Sunday, September 15, 2024**
<!-- HN:41543382:start -->
* [41543382](https://news.social-protocols.org/stats?id=41543382) #24 24 points 40 comments -> [A cartoon butt clenching a bar of soap has invaded my online ads](https://arstechnica.com/culture/2024/09/a-cartoon-butt-clenching-a-bar-of-soap-has-invaded-my-online-ads/)<!-- HN:41543382:end --><!-- HN:41545541:start -->
* [41545541](https://news.social-protocols.org/stats?id=41545541) #24 6 points 0 comments -> [Show HN: I made a game testing your prompting skills](https://app4.hc11.org/49499641/en/)<!-- HN:41545541:end --><!-- HN:41507521:start -->
* [41507521](https://news.social-protocols.org/stats?id=41507521) #29 12 points 0 comments -> [Designing Organisations That Work](https://thenextwavefutures.wordpress.com/2024/09/10/designing-organisations-that-work-stafford-beer-viable-systems-model/)<!-- HN:41507521:end --><!-- HN:41547015:start -->
* [41547015](https://news.social-protocols.org/stats?id=41547015) #2 7 points 0 comments -> [I moved my emails to Proton Mail](https://dataswamp.org/~solene/2024-09-12-email-selfhost-to-protonmail.html)<!-- HN:41547015:end --><!-- HN:41546242:start -->
* [41546242](https://news.social-protocols.org/stats?id=41546242) #19 65 points 36 comments -> [European Consumer Organization goes after publishers for their in-game currency](https://www.gamingonlinux.com/2024/09/european-consumer-organization-goes-after-multiple-publishers-for-their-in-game-currency/)<!-- HN:41546242:end --><!-- HN:41545335:start -->
* [41545335](https://news.social-protocols.org/stats?id=41545335) #18 226 points 114 comments -> [Show HN: I Made Bullshit Remover](https://www.bullshitremover.com/)<!-- HN:41545335:end --><!-- HN:41518567:start -->
* [41518567](https://news.social-protocols.org/stats?id=41518567) #27 163 points 133 comments -> [USPS' long-awaited new mail truck makes its debut](https://apnews.com/article/postal-service-next-generation-delivery-vehicle-a2ebbfc7afec0eea2e036eef93bee4d9)<!-- HN:41518567:end --><!-- HN:41512910:start -->
* [41512910](https://news.social-protocols.org/stats?id=41512910) #30 19 points 14 comments -> [After 155 years, the Campbell Soup company is changing its name](https://www.cnn.com/2024/09/10/business/campbell-soup-company-name/index.html)<!-- HN:41512910:end --><!-- HN:41547637:start -->
* [41547637](https://news.social-protocols.org/stats?id=41547637) #23 3 points 1 comments -> [Honorary Citizenship of the United States](https://en.wikipedia.org/wiki/Honorary_citizenship_of_the_United_States)<!-- HN:41547637:end --><!-- HN:41547200:start -->
* [41547200](https://news.social-protocols.org/stats?id=41547200) #20 32 points 40 comments -> [US House votes to bar new DJI drones](https://www.reuters.com/world/us/us-house-votes-bar-new-drones-chinese-manufacturer-dji-2024-09-09/)<!-- HN:41547200:end --><!-- HN:41548213:start -->
* [41548213](https://news.social-protocols.org/stats?id=41548213) #29 3 points 0 comments -> [Kevin Hart's Vegan Fast-Food Chain Suddenly Closed All Locations Overnight](https://la.eater.com/2024/9/11/24241170/hart-house-kevin-hart-plant-based-vegan-restaurant-closing-los-angeles)<!-- HN:41548213:end --><!-- HN:41547566:start -->
* [41547566](https://news.social-protocols.org/stats?id=41547566) #14 9 points 0 comments -> [Designing mathematics standards in agreement with science [pdf]](https://www.iejme.com/download/designing-mathematics-standards-in-agreement-with-science-13179.pdf)<!-- HN:41547566:end --><!-- HN:41548677:start -->
* [41548677](https://news.social-protocols.org/stats?id=41548677) #7 18 points 24 comments -> [U.S. fleet welcomes newest USS New Jersey, the first gender-neutral submarine](https://www.northjersey.com/story/news/2024/09/14/uss-new-jersey-the-first-gender-neutral-submarine-joins-u-s-fleet/75210209007/)<!-- HN:41548677:end --><!-- HN:41548016:start -->
* [41548016](https://news.social-protocols.org/stats?id=41548016) #13 -> [Our New Religion Isn't Enough](https://www.freyaindia.co.uk/p/our-new-religion-isnt-enough)<!-- HN:41548016:end --><!-- HN:41548997:start -->
* [41548997](https://news.social-protocols.org/stats?id=41548997) #1 74 points 3 comments -> [Terence Tao: creative strategies, this aspect of LLM tools is still weak](https://mathstodon.xyz/@tao/113142753409304792)<!-- HN:41548997:end --><!-- HN:41550406:start -->
* [41550406](https://news.social-protocols.org/stats?id=41550406) #10 3 points 2 comments -> [The Unfortunate Physics of Male Urination (2016)](https://priceonomics.com/why-cant-we-build-a-splash-proof-toilet/)<!-- HN:41550406:end -->
#### **Monday, September 16, 2024**
<!-- HN:41505528:start -->
* [41505528](https://news.social-protocols.org/stats?id=41505528) #20 150 points 92 comments -> [The Disunity of Consciousness in Everyday Experience](http://schwitzsplinters.blogspot.com/2024/09/the-disunity-of-consciousness-in.html)<!-- HN:41505528:end --><!-- HN:41553840:start -->
* [41553840](https://news.social-protocols.org/stats?id=41553840) #5 9 points 4 comments -> [Startups Shouldn't Start with Figma](https://www.brainbuildai.com/blog/startups-not-start-with-figma)<!-- HN:41553840:end --><!-- HN:41554285:start -->
* [41554285](https://news.social-protocols.org/stats?id=41554285) #23 9 points 0 comments -> [Thierry Breton Has Resigned](https://twitter.com/thierrybreton/status/1835565206639972734)<!-- HN:41554285:end --><!-- HN:41552642:start -->
* [41552642](https://news.social-protocols.org/stats?id=41552642) #22 96 points 39 comments -> [Data center emissions probably 662% higher than big tech claims](https://www.theguardian.com/technology/2024/sep/15/data-center-gas-emissions-tech)<!-- HN:41552642:end --><!-- HN:41546769:start -->
* [41546769](https://news.social-protocols.org/stats?id=41546769) #14 239 points 80 comments -> [Learn Git Branching](https://learngitbranching.js.org/)<!-- HN:41546769:end --><!-- HN:41529292:start -->
* [41529292](https://news.social-protocols.org/stats?id=41529292) #14 95 points 46 comments -> [Using the Topics API (Chrome Only, Opposed by Firefox/Safari)](https://developer.mozilla.org/en-US/docs/Web/API/Topics_API/Using)<!-- HN:41529292:end --><!-- HN:41551387:start -->
* [41551387](https://news.social-protocols.org/stats?id=41551387) #15 92 points 23 comments -> [What Firefox trains are we in?](https://whattrainisitnow.com/)<!-- HN:41551387:end --><!-- HN:41531033:start -->
* [41531033](https://news.social-protocols.org/stats?id=41531033) #19 67 points 7 comments -> [The A-Z of Product Psychology](https://delightyourusers.com/psychology)<!-- HN:41531033:end --><!-- HN:41553031:start -->
* [41553031](https://news.social-protocols.org/stats?id=41553031) #23 63 points 61 comments -> [Diesel shop fined $10M for making and selling Emissions Defeat Devices](https://www.thedrive.com/news/feds-nail-another-diesel-shop-with-10m-in-fines-for-deleting-emissions-equipment)<!-- HN:41553031:end --><!-- HN:41548985:start -->
* [41548985](https://news.social-protocols.org/stats?id=41548985) #16 119 points 16 comments -> [Data Engineering Vault: A 1000 Node Second Brain for DE Knowledge](https://www.ssp.sh/brain/data-engineering/)<!-- HN:41548985:end --><!-- HN:41524932:start -->
* [41524932](https://news.social-protocols.org/stats?id=41524932) #25 281 points 325 comments -> [USPS' long-awaited new mail truck makes its debut to rave reviews from carriers](https://apnews.com/article/postal-service-next-generation-delivery-vehicle-a2ebbfc7afec0eea2e036eef93bee4d9)<!-- HN:41524932:end --><!-- HN:41554692:start -->
* [41554692](https://news.social-protocols.org/stats?id=41554692) #22 6 points 0 comments -> [date-fns 4.0 is out with first-class time zones support](https://blog.date-fns.org/v40-with-time-zone-support/)<!-- HN:41554692:end --><!-- HN:41520950:start -->
* [41520950](https://news.social-protocols.org/stats?id=41520950) #26 95 points 19 comments -> [The art of niwaki (Japanese tree pruning)](https://blog.fantasticgardenersmelbourne.com.au/art-of-niwaki/)<!-- HN:41520950:end --><!-- HN:41550426:start -->
* [41550426](https://news.social-protocols.org/stats?id=41550426) #29 13 points 0 comments -> [CSS Performance Optimization](https://developer.mozilla.org/en-US/docs/Learn/Performance/CSS)<!-- HN:41550426:end --><!-- HN:41512421:start -->
* [41512421](https://news.social-protocols.org/stats?id=41512421) #17 3 points 1 comments -> [Where the Crops Grow](https://flowingdata.com/2024/09/11/cropland/)<!-- HN:41512421:end --><!-- HN:41551776:start -->
* [41551776](https://news.social-protocols.org/stats?id=41551776) #28 38 points 62 comments -> [New tech can make air-conditioning less harmful to the planet](https://www.economist.com/science-and-technology/2024/09/04/new-tech-can-make-air-conditioning-less-harmful-to-the-planet)<!-- HN:41551776:end --><!-- HN:41557178:start -->
* [41557178](https://news.social-protocols.org/stats?id=41557178) #6 3 points 0 comments -> [Matrix Multiplication in Finite Fields](https://fileforma.substack.com/p/update-ffgemm-finite-field-general)<!-- HN:41557178:end --><!-- HN:41556910:start -->
* [41556910](https://news.social-protocols.org/stats?id=41556910) #30 5 points 0 comments -> [Ubisoft is using bots to promote new Assassin's Creed](https://www.neogaf.com/threads/ubisoft-is-now-using-bots-to-promote-ac-shadowss.1674976/)<!-- HN:41556910:end --><!-- HN:41558704:start -->
* [41558704](https://news.social-protocols.org/stats?id=41558704) #24 5 points 0 comments -> [Windows 12.1 Pro](https://www.youtube.com/watch?v=avN85_ElsRE)<!-- HN:41558704:end --><!-- HN:41558540:start -->
* [41558540](https://news.social-protocols.org/stats?id=41558540) #7 4 points 0 comments -> [When will AI outthink humans?](https://davidvgilmore.com/writings/outthinking-ai)<!-- HN:41558540:end -->