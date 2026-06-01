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

#### **Tuesday, May 26, 2026**
<!-- HN:48272945:start -->
* [48272945](https://news.social-protocols.org/stats?id=48272945) #30 11 points 4 comments -> [Citing Gandalf, Pope Leo says we must "disarm" AI](https://arstechnica.com/tech-policy/2026/05/citing-gandalf-pope-leo-says-we-must-disarm-ai/)<!-- HN:48272945:end --><!-- HN:48272694:start -->
* [48272694](https://news.social-protocols.org/stats?id=48272694) #29 21 points 8 comments -> [Agentic Patterns](https://veso.ai/research/agentic-patterns/)<!-- HN:48272694:end --><!-- HN:48274018:start -->
* [48274018](https://news.social-protocols.org/stats?id=48274018) #26 7 points 11 comments -> [Browser-based file encryption tool using WebCrypto](https://secvant.com/)<!-- HN:48274018:end --><!-- HN:48243849:start -->
* [48243849](https://news.social-protocols.org/stats?id=48243849) #21 16 points 12 comments -> [You Only Use 10% of Printf() – Here Are Things They Didn't Teach You [video]](https://www.youtube.com/watch?v=kdnN0kk7MS0)<!-- HN:48243849:end --><!-- HN:48277537:start -->
* [48277537](https://news.social-protocols.org/stats?id=48277537) #16 83 points 38 comments -> [I bypassed AWS API Gateway auth with a trailing slash. Got $12K bounty](https://theguptalog.blogspot.com/2026/04/i-bypassed-aws-api-gateway-auth-with.html)<!-- HN:48277537:end --><!-- HN:48278832:start -->
* [48278832](https://news.social-protocols.org/stats?id=48278832) #3 13 points 9 comments -> [Nearly half (44%) of every T-shirt goes to waste before you even buy it](https://norwegianscitechnews.com/2026/05/nearly-half-of-every-t-shirt-goes-to-waste-before-you-even-buy-it/)<!-- HN:48278832:end --><!-- HN:48279321:start -->
* [48279321](https://news.social-protocols.org/stats?id=48279321) #7 157 points 75 comments -> [AWS Fired the One Employee Who Gave a Damn](https://www.seuros.com/blog/aws-fired-the-human-who-made-the-difference/)<!-- HN:48279321:end --><!-- HN:48244075:start -->
* [48244075](https://news.social-protocols.org/stats?id=48244075) #20 13 points 2 comments -> [Trying to preserve other peoples code](https://github.com/Essenceia/CRC_generator/tree/main)<!-- HN:48244075:end --><!-- HN:48287025:start -->
* [48287025](https://news.social-protocols.org/stats?id=48287025) #2 20 points 12 comments -> [Uber blows through its AI budget in 1 quarter](https://fortune.com/2026/05/26/uber-coo-ai-spending-tokens-claude-code/)<!-- HN:48287025:end --><!-- HN:48286428:start -->
* [48286428](https://news.social-protocols.org/stats?id=48286428) #20 4 points 2 comments -> [Bouncy Castle Communism Is the Solution](https://www.laborpolitics.com/p/bouncy-castle-communism)<!-- HN:48286428:end -->
#### **Wednesday, May 27, 2026**
<!-- HN:48287007:start -->
* [48287007](https://news.social-protocols.org/stats?id=48287007) #4 22 points 3 comments -> [Colorado and California Exempt Open Source from Age Attestation](https://system76.com/blog/post/co-and-ca-exempt-open-source-from-age-attestation)<!-- HN:48287007:end --><!-- HN:48287808:start -->
* [48287808](https://news.social-protocols.org/stats?id=48287808) #29 33 points 13 comments -> [Agent Memory: An Anatomy](https://brgsk.xyz/agent-memory-anatomy/)<!-- HN:48287808:end --><!-- HN:48287220:start -->
* [48287220](https://news.social-protocols.org/stats?id=48287220) #3 68 points 43 comments -> [Xiaomi MiMo-v2.5 price drops 99% – AI pricing war](https://platform.xiaomimimo.com/docs/en-US/welcome)<!-- HN:48287220:end --><!-- HN:48288761:start -->
* [48288761](https://news.social-protocols.org/stats?id=48288761) #9 5 points 0 comments -> [Gear Commit: Dev gadget box personalized from GitHub activity](https://gearcommit.nanocorp.app/)<!-- HN:48288761:end --><!-- HN:48292775:start -->
* [48292775](https://news.social-protocols.org/stats?id=48292775) #13 10 points 6 comments -> [Jensen Huang Just Told Every CEO Hiding Behind AI Layoffs to Shut Up](https://www.thestateofbrand.com/news/jensen-huang-ai-layoffs)<!-- HN:48292775:end --><!-- HN:48265629:start -->
* [48265629](https://news.social-protocols.org/stats?id=48265629) #7 15 points 4 comments -> [Thunderbolt vs. USB-C: what the connector hides](https://www.whatcable.uk/blog/thunderbolt-vs-usb-c)<!-- HN:48265629:end --><!-- HN:48294315:start -->
* [48294315](https://news.social-protocols.org/stats?id=48294315) #3 39 points 24 comments -> [Why AI Agents Cannot Change Software Systems](https://phroneses.com/articles/build/notes/agents-cannot-maintain-systems.html)<!-- HN:48294315:end --><!-- HN:48298837:start -->
* [48298837](https://news.social-protocols.org/stats?id=48298837) #12 33 points 38 comments -> [Germany Law to Force Algorithm Boost for State-Approved News](https://nonogra.ph/germany-considers-law-to-force-social-media-algorithm-boost-for-state-approved-news-05-27-2026)<!-- HN:48298837:end --><!-- HN:48299414:start -->
* [48299414](https://news.social-protocols.org/stats?id=48299414) #25 4 points 0 comments -> [Deterministic Hydrodynamic Quantum Engine in Rust](https://github.com/fbcouto/deterministic-wave-engine)<!-- HN:48299414:end --><!-- HN:48253063:start -->
* [48253063](https://news.social-protocols.org/stats?id=48253063) #27 8 points 2 comments -> [Reconstructing a Mixbook movie from its data API with FFmpeg](https://segar.me/blog/posts/reconstructing_a_mixbook_movie.html)<!-- HN:48253063:end -->
#### **Thursday, May 28, 2026**
<!-- HN:48307231:start -->
* [48307231](https://news.social-protocols.org/stats?id=48307231) #11 315 points 134 comments -> [AMD pulls a bait-and-switch on Linux users with Vivado licensing changes](https://itsfoss.com/news/amd-vivado-bait-and-switch-on-linux-users/)<!-- HN:48307231:end --><!-- HN:48309463:start -->
* [48309463](https://news.social-protocols.org/stats?id=48309463) #3 40 points 26 comments -> [Valve hikes Steam Deck prices by more than 40%, blaming rising costs](https://www.bbc.com/news/articles/cz725d5d1x7o)<!-- HN:48309463:end --><!-- HN:48269609:start -->
* [48269609](https://news.social-protocols.org/stats?id=48269609) #21 4 points 4 comments -> [You Were Never Declaring State. You Were Observing by Hand](https://webframp.com/posts/you-were-never-declaring-state/)<!-- HN:48269609:end --><!-- HN:48314650:start -->
* [48314650](https://news.social-protocols.org/stats?id=48314650) #12 18 points 5 comments -> [Caio, a cleaner search engine for 500k+ tech jobs](https://caio-jobs.com/)<!-- HN:48314650:end --><!-- HN:48316462:start -->
* [48316462](https://news.social-protocols.org/stats?id=48316462) #7 12 points 4 comments -> [Minimax M3](https://www.minimax.co.uk/products/water-softeners/minimax-m3-water-softener/)<!-- HN:48316462:end -->
#### **Friday, May 29, 2026**
<!-- HN:48317073:start -->
* [48317073](https://news.social-protocols.org/stats?id=48317073) #28 9 points 0 comments -> [The internet has become too American to trust](https://thewalrus.ca/the-internet-has-become-too-american-to-trust/)<!-- HN:48317073:end --><!-- HN:48317224:start -->
* [48317224](https://news.social-protocols.org/stats?id=48317224) #18 6 points 5 comments -> [Eric Schmidt: you don't have any friends](https://www.inkl.com/news/if-youre-writing-code-traditionally-stop-its-over-former-google-ceo-eric-schmidt-explains-why-he-is-mourning-as-a-programmer/qYwMPRFlVMQ)<!-- HN:48317224:end --><!-- HN:48316958:start -->
* [48316958](https://news.social-protocols.org/stats?id=48316958) #29 12 points 7 comments -> [The Silent Critic](https://www.tft.io/the-silent-critic/)<!-- HN:48316958:end --><!-- HN:48266950:start -->
* [48266950](https://news.social-protocols.org/stats?id=48266950) #13 4 points 0 comments -> [How a Startup Is Collapsing a 200-Year-Old Supply Chain](https://www.carryology.com/insights/how-a-startup-is-collapsing-a-200-year-old-supply-chain/)<!-- HN:48266950:end --><!-- HN:48265849:start -->
* [48265849](https://news.social-protocols.org/stats?id=48265849) #28 15 points 7 comments -> [The Pack That Killed the Pack Mule](https://www.carryology.com/liking/industry/the-pack-that-killed-the-pack-mule/)<!-- HN:48265849:end --><!-- HN:48318978:start -->
* [48318978](https://news.social-protocols.org/stats?id=48318978) #19 17 points 1 comments -> [Python utility package for building Claude Code hooks](https://github.com/RasmusGodske/claude-hook-utils)<!-- HN:48318978:end --><!-- HN:48318678:start -->
* [48318678](https://news.social-protocols.org/stats?id=48318678) #3 204 points 112 comments -> [Blue Origin’s New Glenn rocket exploded during a static fire test](https://arstechnica.com/space/2026/05/blue-origins-new-glenn-rocket-just-exploded-during-a-static-fire-test/)<!-- HN:48318678:end --><!-- HN:48320382:start -->
* [48320382](https://news.social-protocols.org/stats?id=48320382) #4 5 points 2 comments -> [NexusCortex Just Beat Opus 4.8 – and It's Open Source](https://github.com/office233/Nexuscortex)<!-- HN:48320382:end --><!-- HN:48319968:start -->
* [48319968](https://news.social-protocols.org/stats?id=48319968) #24 40 points 40 comments -> [Fed up with vibe coders, dev sneaks data-nuking prompt injection into their code](https://arstechnica.com/security/2026/05/fed-up-with-vibe-coders-dev-sneaks-data-nuking-prompt-injection-into-their-code/)<!-- HN:48319968:end --><!-- HN:48322265:start -->
* [48322265](https://news.social-protocols.org/stats?id=48322265) #8 7 points 2 comments -> [We should be more tired than the model](https://newsletter.vickiboykis.com/archive/we-should-be-more-tired-than-the-model/)<!-- HN:48322265:end --><!-- HN:48323854:start -->
* [48323854](https://news.social-protocols.org/stats?id=48323854) #24 16 points 6 comments -> [Do U.S. Presidents Always Make This Much Money? [video]](https://www.youtube.com/watch?v=X5MzTvfjcOM)<!-- HN:48323854:end --><!-- HN:48323495:start -->
* [48323495](https://news.social-protocols.org/stats?id=48323495) #20 26 points 2 comments -> [Blue Origin rocket explodes on launchpad in a setback](https://www.reuters.com/science/blue-origin-says-it-faced-anomaly-during-hot-fire-test-2026-05-29/)<!-- HN:48323495:end --><!-- HN:48325707:start -->
* [48325707](https://news.social-protocols.org/stats?id=48325707) #14 10 points 1 comments -> [Rsync maintainer starts uses Claude, regressions mount](https://mastodon.gamedev.place/@JeremiahFieldhaven/116654345332213390)<!-- HN:48325707:end --><!-- HN:48321264:start -->
* [48321264](https://news.social-protocols.org/stats?id=48321264) #28 84 points 92 comments -> [Is This Sustainable?](https://jamiehurst.co.uk/2026-05-24_ai-sustainable)<!-- HN:48321264:end --><!-- HN:48328088:start -->
* [48328088](https://news.social-protocols.org/stats?id=48328088) #22 8 points 1 comments -> [CVE-Bench: testing LLM agents on real-world vulnerability patches](https://giovannigatti.github.io/cve-bench/)<!-- HN:48328088:end -->
#### **Saturday, May 30, 2026**
<!-- HN:48332889:start -->
* [48332889](https://news.social-protocols.org/stats?id=48332889) #13 10 points 0 comments -> [Records Show UC Sharing Data with US Customs and Border Protection](https://www.dailycal.org/news/uc/records-show-uc-sharing-data-with-us-customs-and-border-protection/article_785ac3ca-9ab2-4ab0-bbb8-07742e62d3d8.html)<!-- HN:48332889:end --><!-- HN:48333177:start -->
* [48333177](https://news.social-protocols.org/stats?id=48333177) #24 6 points 1 comments -> [Company accidentally blows $500M on Claude AI in one month](https://www.msn.com/en-us/news/technology/company-accidentally-blows-500-000-000-on-claude-ai-in-one-month/ar-AA24nahv)<!-- HN:48333177:end --><!-- HN:48282025:start -->
* [48282025](https://news.social-protocols.org/stats?id=48282025) #29 20 points 2 comments -> [Understand Anything – Graphs that teach the codebase](https://understand-anything.com/)<!-- HN:48282025:end --><!-- HN:48336022:start -->
* [48336022](https://news.social-protocols.org/stats?id=48336022) #16 13 points 9 comments -> [Airlines Can't Charge You for What You Wear](https://voyagecoat.com/)<!-- HN:48336022:end --><!-- HN:48288583:start -->
* [48288583](https://news.social-protocols.org/stats?id=48288583) #13 7 points 1 comments -> [Gardeners often hear about supposed hacks and quick fix. Here are some debunked](https://apnews.com/article/gardening-myths-vinegar-tilling-watering-c07faf7472e7a2dc40d3886b94f1b508)<!-- HN:48288583:end --><!-- HN:48335135:start -->
* [48335135](https://news.social-protocols.org/stats?id=48335135) #15 299 points 222 comments -> [Proposed new US funding rules: We can cancel any grant at any time](https://arstechnica.com/science/2026/05/the-office-of-management-and-budget-tries-again-to-cripple-us-science/)<!-- HN:48335135:end --><!-- HN:48338988:start -->
* [48338988](https://news.social-protocols.org/stats?id=48338988) #30 6 points 1 comments -> [Driver, 87, dies after Tesla on Autopilot mode crashes into pond](https://www.usatoday.com/story/news/nation/2026/05/29/tesla-on-autopilot-mode-crashes-into-pond-87-year-old-driver-dies/90319482007/)<!-- HN:48338988:end --><!-- HN:48339576:start -->
* [48339576](https://news.social-protocols.org/stats?id=48339576) #24 48 points 13 comments -> [Thiel moves family to Milei's libertarian Argentina](https://www.ft.com/content/3d7ab893-1842-4c6c-a3d9-26871d79dde4)<!-- HN:48339576:end --><!-- HN:48340025:start -->
* [48340025](https://news.social-protocols.org/stats?id=48340025) #17 6 points 0 comments -> [An OS in pure Rust with its own TCP/IP and TLS 1.3 stack, fetching the live web](https://github.com/rfi-irfos/rusty-penguin)<!-- HN:48340025:end --><!-- HN:48340468:start -->
* [48340468](https://news.social-protocols.org/stats?id=48340468) #6 11 points 1 comments -> [Zerostack v1.3.4 released – Lightweight Unix-inspired coding agent](https://crates.io/crates/zerostack/1.3.4)<!-- HN:48340468:end --><!-- HN:48340528:start -->
* [48340528](https://news.social-protocols.org/stats?id=48340528) #16 9 points 5 comments -> [Kore: Binary File Format Optimized for Modern Data Systems (Open Source)](https://github.com/arunkatherashala/Kore)<!-- HN:48340528:end --><!-- HN:48340944:start -->
* [48340944](https://news.social-protocols.org/stats?id=48340944) #16 -> [Republicans are trying to kill science in this country](https://www.npr.org/2026/05/21/nx-s1-5828768/science-funding-cuts-nih-trump-administration)<!-- HN:48340944:end --><!-- HN:48340958:start -->
* [48340958](https://news.social-protocols.org/stats?id=48340958) #23 6 points 0 comments -> [AWS Budgets Has an 8-Hour Delay. Your Bedrock Bill Doesn't](https://blog.llmcap.io/aws-budgets-has-an-8-hour-delay-your-bedrock-bill-doesn-t)<!-- HN:48340958:end -->
#### **Sunday, May 31, 2026**
<!-- HN:48341505:start -->
* [48341505](https://news.social-protocols.org/stats?id=48341505) #20 8 points 1 comments -> [Custom Errors Are Non-Negotiable in My Rust Applications](https://tristonarmstrong.com/blog/custom-errors-are-non-negotiable-in-my-rust-applications)<!-- HN:48341505:end --><!-- HN:48342097:start -->
* [48342097](https://news.social-protocols.org/stats?id=48342097) #3 39 points 16 comments -> [Anyone can build a platform now. Almost nobody can get people to find it](https://claudefolio.com/blog/anyone-can-build-a-platform-now-almost-nobody-can-get-people-to-find-it)<!-- HN:48342097:end --><!-- HN:48303859:start -->
* [48303859](https://news.social-protocols.org/stats?id=48303859) #23 5 points 0 comments -> [Carbon Nanotube CPU Cooling](https://www.lttlabs.com/articles/2026/05/26/carbice-ice-pads)<!-- HN:48303859:end --><!-- HN:48343061:start -->
* [48343061](https://news.social-protocols.org/stats?id=48343061) #24 11 points 0 comments -> [Building a LangGraph pipeline for production data engineering](https://labyrinthanalyticsconsulting.com/blog/building-first-langgraph-pipeline)<!-- HN:48343061:end --><!-- HN:48343445:start -->
* [48343445](https://news.social-protocols.org/stats?id=48343445) #22 5 points 1 comments -> [The ~500kB NBSDGames 6 managed to be published ahead of GTA 6](https://github.com/abakh/nbsdgames/releases)<!-- HN:48343445:end --><!-- HN:48309623:start -->
* [48309623](https://news.social-protocols.org/stats?id=48309623) #21 10 points 1 comments -> [Soviet 80s supercomputer project "Start"](https://start.iis.nsk.su/)<!-- HN:48309623:end --><!-- HN:48344930:start -->
* [48344930](https://news.social-protocols.org/stats?id=48344930) #6 4 points 1 comments -> [Show HN: The Tired Engineer](https://www.thetiredengineer.com/)<!-- HN:48344930:end --><!-- HN:48345414:start -->
* [48345414](https://news.social-protocols.org/stats?id=48345414) #24 9 points 11 comments -> [Human brains are misaligned, hallucinative, stochastic parrots](https://substack.com/@samuelfitoussi/p-191268395)<!-- HN:48345414:end --><!-- HN:48346697:start -->
* [48346697](https://news.social-protocols.org/stats?id=48346697) #9 17 points 6 comments -> [An Analysis of GrapheneOS's Server Infrastructure](https://write.as/hcbg2iz91vzqh)<!-- HN:48346697:end -->
#### **Monday, June 1, 2026**
<!-- HN:48346947:start -->
* [48346947](https://news.social-protocols.org/stats?id=48346947) #6 506 points 328 comments -> [Creatine raises brain energy levels and slows cognitive decline: study](https://thesciverse.org/scientists-found-that-the-creatine-supplement-millions-take-for-muscle-gains-is-quietly-raising-brain-energy-levels-and-slowing-early-alzheimers-cognitive-decline-by-30/)<!-- HN:48346947:end --><!-- HN:48352627:start -->
* [48352627](https://news.social-protocols.org/stats?id=48352627) #10 26 points 40 comments -> [Surface Laptop Ultra: Made for World Makers](https://blogs.windows.com/devices/2026/05/31/introducing-surface-laptop-ultra-made-for-world-makers/)<!-- HN:48352627:end --><!-- HN:48353670:start -->
* [48353670](https://news.social-protocols.org/stats?id=48353670) #19 24 points 40 comments -> [Dune's Butlerian Jihad and the Future of AI](https://technology.inquirer.net/147084/dunes-butlerian-jihad-and-the-future-of-ai)<!-- HN:48353670:end --><!-- HN:48354405:start -->
* [48354405](https://news.social-protocols.org/stats?id=48354405) #21 25 points 40 comments -> [Why Are Large Language Models So Terrible at Video Games?](https://spectrum.ieee.org/ai-video-games-llms-togelius)<!-- HN:48354405:end -->