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

#### **Saturday, August 23, 2025**<!-- HN:44993874:start -->
* [44993874](https://news.social-protocols.org/stats?id=44993874) #16 15 points 2 comments -> [DeepCode: Open Agentic Coding](https://github.com/HKUDS/DeepCode)<!-- HN:44993874:end --><!-- HN:44994515:start -->
* [44994515](https://news.social-protocols.org/stats?id=44994515) #7 5 points 6 comments -> [Asking three LLMs a simple question](https://sethops1.net/post/asking-three-llms-a-simple-question/)<!-- HN:44994515:end --><!-- HN:44949203:start -->
* [44949203](https://news.social-protocols.org/stats?id=44949203) #27 16 points 2 comments -> [Embedding Text Documents with Qwen3](https://www.daft.ai/blog/embedding-millions-of-text-documents-with-qwen3)<!-- HN:44949203:end --><!-- HN:44994217:start -->
* [44994217](https://news.social-protocols.org/stats?id=44994217) #20 24 points 40 comments -> [California teens are ditching office jobs – and making $100K before they turn 21](https://www.sfgate.com/bayarea/article/young-adults-changing-career-paths-ai-20824566.php)<!-- HN:44994217:end --><!-- HN:44993761:start -->
* [44993761](https://news.social-protocols.org/stats?id=44993761) #7 30 points 9 comments -> [Show HN: OctaneDB – Fast, Open-Source Vector Database for Python](https://github.com/RijinRaju/octanedb)<!-- HN:44993761:end --><!-- HN:44995168:start -->
* [44995168](https://news.social-protocols.org/stats?id=44995168) #22 26 points 40 comments -> [Self-driving cars begin testing on NYC streets](https://www.amny.com/nyc-transit/self-driving-cars-nyc-first-permit-waymo/)<!-- HN:44995168:end --><!-- HN:44994835:start -->
* [44994835](https://news.social-protocols.org/stats?id=44994835) #27 15 points 1 comments -> [Marital happiness = lovemaking rate – argument rate [pdf]](https://www.cmu.edu/dietrich/sds/docs/dawes/the-robust-beauty-of-improper-linear-models-in-decision-making.pdf)<!-- HN:44994835:end --><!-- HN:44996058:start -->
* [44996058](https://news.social-protocols.org/stats?id=44996058) #11 39 points 32 comments -> [Show HN: I Made the Hardest Focus App](https://apps.apple.com/us/app/pocket-the-hardest-focus-app/id6746587044)<!-- HN:44996058:end --><!-- HN:44963521:start -->
* [44963521](https://news.social-protocols.org/stats?id=44963521) #20 17 points 0 comments -> [Disk sampling on a sphere](https://observablehq.com/@jrus/spheredisksample)<!-- HN:44963521:end -->
#### **Sunday, August 24, 2025**
<!-- HN:45000400:start -->
* [45000400](https://news.social-protocols.org/stats?id=45000400) #21 11 points 2 comments -> [DeepCode: Open Agentic Coding](https://github.com/HKUDS/DeepCode)<!-- HN:45000400:end --><!-- HN:44977960:start -->
* [44977960](https://news.social-protocols.org/stats?id=44977960) #6 9 points 5 comments -> [Open Source Maintenance Fee business model example from WiX Toolset](https://github.com/wixtoolset)<!-- HN:44977960:end --><!-- HN:45002403:start -->
* [45002403](https://news.social-protocols.org/stats?id=45002403) #24 6 points 1 comments -> [Israeli army database suggests at least 83% of Gaza dead were civilians](https://www.972mag.com/israeli-intelligence-database-83-percent-civilians-militants/)<!-- HN:45002403:end --><!-- HN:45002806:start -->
* [45002806](https://news.social-protocols.org/stats?id=45002806) #23 9 points 1 comments -> [Declaration of famine in Gaza lays bare Israel's disregard for humanitarian duty](https://www.theguardian.com/world/2025/aug/24/gaza-famine-declaration-israel-humanitarian-duty-analysis)<!-- HN:45002806:end --><!-- HN:44967396:start -->
* [44967396](https://news.social-protocols.org/stats?id=44967396) #17 12 points 1 comments -> [Go-away – Customizable, conditional challenges to incoming requests](https://git.gammaspectra.live/git/go-away/wiki/Challenges)<!-- HN:44967396:end --><!-- HN:45003819:start -->
* [45003819](https://news.social-protocols.org/stats?id=45003819) #7 103 points 21 comments -> [ICE Uses Celebrity Loophole to Hide Deportation Flights](https://jacobin.com/2025/08/ice-uses-celebrities-loophole-to-hide-deportation-flights/)<!-- HN:45003819:end --><!-- HN:45003360:start -->
* [45003360](https://news.social-protocols.org/stats?id=45003360) #6 -> [Show HN: Clearcam – Add AI object detection to Your IP CCTV cameras in a minute](https://github.com/roryclear/clearcam)<!-- HN:45003360:end --><!-- HN:44971867:start -->
* [44971867](https://news.social-protocols.org/stats?id=44971867) #5 35 points 11 comments -> [NASA's Juno Mission Leaves Legacy of Science at Jupiter](https://www.scientificamerican.com/article/how-nasas-juno-probe-changed-everything-we-know-about-jupiter/)<!-- HN:44971867:end --><!-- HN:45006468:start -->
* [45006468](https://news.social-protocols.org/stats?id=45006468) #15 -> [Walmart Fires VP for Taking Daily Kickbacks Starting from $30K](https://www.ctol.digital/news/walmart-fires-vp-kickbacks-terminates-1200-contractors/)<!-- HN:45006468:end --><!-- HN:45006507:start -->
* [45006507](https://news.social-protocols.org/stats?id=45006507) #10 7 points 1 comments -> [How Does a Firewall Work Step by Step](https://kalilinuxtutorials.com/how-firewall-works-step-by-step/)<!-- HN:45006507:end --><!-- HN:45008323:start -->
* [45008323](https://news.social-protocols.org/stats?id=45008323) #22 35 points 14 comments -> [2.5B Gmail users endangered after Google database hack](https://www.pcworld.com/article/2880822/2-5-billion-gmail-users-endangered-after-google-database-hack.html)<!-- HN:45008323:end -->
#### **Monday, August 25, 2025**
<!-- HN:45008406:start -->
* [45008406](https://news.social-protocols.org/stats?id=45008406) #30 14 points 1 comments -> [Introducing: VuIO – open-source UPNP/DLNA server written in Rust](https://github.com/vuiodev/vuio)<!-- HN:45008406:end --><!-- HN:45005954:start -->
* [45005954](https://news.social-protocols.org/stats?id=45005954) #28 30 points 2 comments -> [Y Combinator says Apple's App Store has hindered startup growth](https://techcrunch.com/2025/08/22/y-combinator-says-apples-app-store-has-hindered-startup-growth/)<!-- HN:45005954:end --><!-- HN:45009486:start -->
* [45009486](https://news.social-protocols.org/stats?id=45009486) #21 9 points 0 comments -> [Show HN: Decentralized Bitcoin Incentives via QR Codes](https://github.com/DT7QR/Bitcoin-Rewards-System-Proposal)<!-- HN:45009486:end --><!-- HN:45012640:start -->
* [45012640](https://news.social-protocols.org/stats?id=45012640) #5 9 points 1 comments -> [Censorship in the EU: Hate Speech Laws Are Suffocating Free Speech](https://www.freedom-research.org/p/censorship-in-the-eu-hate-speech)<!-- HN:45012640:end --><!-- HN:45013076:start -->
* [45013076](https://news.social-protocols.org/stats?id=45013076) #2 71 points 46 comments -> [Walmart Fires VP in Tech for Taking Daily Kickbacks Starting from $30K](https://www.ctol.digital/news/walmart-fires-vp-kickbacks-terminates-1200-contractors/)<!-- HN:45013076:end --><!-- HN:45015465:start -->
* [45015465](https://news.social-protocols.org/stats?id=45015465) #26 16 points 6 comments -> [EU cave in on vehicle trade rules will cost European lives](https://www.transportenvironment.org/articles/eu-cave-in-on-vehicle-trade-rules-will-cost-european-lives-as-us-pick-up-trucks-flood-into-europe)<!-- HN:45015465:end --><!-- HN:45016275:start -->
* [45016275](https://news.social-protocols.org/stats?id=45016275) #28 4 points 0 comments -> [Journalists killed in Israeli strikes on Gaza hospital, health officials say](https://www.pbs.org/newshour/world/4-journalists-killed-in-israeli-strikes-on-gaza-hospital-health-officials-say)<!-- HN:45016275:end --><!-- HN:45017930:start -->
* [45017930](https://news.social-protocols.org/stats?id=45017930) #7 5 points 0 comments -> [By Birth Alone: The Original Meaning of Birthright Citizenship](https://papers.ssrn.com/sol3/papers.cfm?abstract_id=5394605)<!-- HN:45017930:end --><!-- HN:45018343:start -->
* [45018343](https://news.social-protocols.org/stats?id=45018343) #4 98 points 1 comments -> [Google to require developer verification for Android apps outside the Play Store](https://techcrunch.com/2025/08/25/google-will-require-developer-verification-for-android-apps-outside-the-play-store/)<!-- HN:45018343:end --><!-- HN:45019513:start -->
* [45019513](https://news.social-protocols.org/stats?id=45019513) #27 14 points 0 comments -> [How the Richest People in America Avoid Paying Taxes](https://www.theatlantic.com/economy/archive/2025/08/billionaire-tax-study/683987/)<!-- HN:45019513:end -->
#### **Tuesday, August 26, 2025**<!-- HN:45021675:start -->
* [45021675](https://news.social-protocols.org/stats?id=45021675) #29 -> [Last Photos Taken by Gaza Journalists Before They Were Killed in Israeli Strikes](https://www.haaretz.com/israel-news/2025-08-25/ty-article-magazine/last-photos-taken-by-gaza-journalists-before-they-were-killed-in-israeli-strikes/00000198-e123-de0b-a7d9-e9e76bdb0000)<!-- HN:45021675:end --><!-- HN:45019724:start -->
* [45019724](https://news.social-protocols.org/stats?id=45019724) #17 16 points 17 comments -> [AI Is Slowing Down Tracker](https://aislowdown.replit.app/)<!-- HN:45019724:end --><!-- HN:45022239:start -->
* [45022239](https://news.social-protocols.org/stats?id=45022239) #17 -> [The US used to be a haven for research. Now, scientists are packing their bags](https://www.csmonitor.com/USA/Education/2025/0825/trump-science-brain-drain-europe)<!-- HN:45022239:end --><!-- HN:45021955:start -->
* [45021955](https://news.social-protocols.org/stats?id=45021955) #19 112 points 62 comments -> [US retail giants raise prices due to tariffs](https://english.elpais.com/economy-and-business/2025-08-25/us-retail-giants-raise-prices-and-seek-new-import-sources-due-to-tariffs.html)<!-- HN:45021955:end --><!-- HN:45001057:start -->
* [45001057](https://news.social-protocols.org/stats?id=45001057) #30 19 points 4 comments -> [What Are Oklch Colors?](https://jakub.kr/components/oklch-colors)<!-- HN:45001057:end --><!-- HN:45025272:start -->
* [45025272](https://news.social-protocols.org/stats?id=45025272) #19 14 points 8 comments -> [Red meat consumption within high-quality diets may support mental health](https://medicalxpress.com/news/2025-08-red-meat-consumption-high-quality.html)<!-- HN:45025272:end --><!-- HN:45025406:start -->
* [45025406](https://news.social-protocols.org/stats?id=45025406) #30 15 points 5 comments -> [In the Matter of Lisa Cook](https://paulkrugman.substack.com/p/in-the-matter-of-lisa-cook)<!-- HN:45025406:end --><!-- HN:45026949:start -->
* [45026949](https://news.social-protocols.org/stats?id=45026949) #3 17 points 1 comments -> [Gemini 2.5 Flash Image, our image model](https://developers.googleblog.com/en/introducing-gemini-2-5-flash-image/)<!-- HN:45026949:end --><!-- HN:45028173:start -->
* [45028173](https://news.social-protocols.org/stats?id=45028173) #9 9 points 0 comments -> [It's Time for Americans to Start Talking About "Soft Secession"](https://cmarmitage.substack.com/p/its-time-for-americans-to-start-talking)<!-- HN:45028173:end --><!-- HN:45029203:start -->
* [45029203](https://news.social-protocols.org/stats?id=45029203) #13 8 points 0 comments -> [Google Release Nano Banana](https://blog.google/intl/en-mena/product-updates/explore-get-answers/nano-banana-image-editing-in-gemini-just-got-a-major-upgrade/)<!-- HN:45029203:end --><!-- HN:45028163:start -->
* [45028163](https://news.social-protocols.org/stats?id=45028163) #19 24 points 25 comments -> [Apple´s Tim Cook battle results](https://hugston.com/articles/Apple_2016_Stand_Was_Never_About_One_Case)<!-- HN:45028163:end --><!-- HN:45032686:start -->
* [45032686](https://news.social-protocols.org/stats?id=45032686) #13 6 points 1 comments -> ['Less Fun Than a Barrel of Crackers'](https://johnmccoy.org/2025/08/25/less-fun-than-a-barrel-of-crackers/)<!-- HN:45032686:end -->
#### **Wednesday, August 27, 2025**
<!-- HN:45035336:start -->
* [45035336](https://news.social-protocols.org/stats?id=45035336) #2 14 points 1 comments -> [Hire Palestinian Tech Talent](https://apricotinternational.org/)<!-- HN:45035336:end --><!-- HN:45035741:start -->
* [45035741](https://news.social-protocols.org/stats?id=45035741) #25 39 points 3 comments -> [We have become an authoritarian state, and our top newsrooms are in denial](https://presswatchers.org/2025/08/we-have-become-an-authoritarian-state-and-our-top-newsrooms-are-in-denial/)<!-- HN:45035741:end --><!-- HN:45038529:start -->
* [45038529](https://news.social-protocols.org/stats?id=45038529) #20 14 points 1 comments -> [Money Can't Buy You Love: The Story Behind Elon Musk's Berghain Rejection](https://berlinguide.de/money-cant-buy-you-love-the-story-behind-elon-musks-berghain-rejection/)<!-- HN:45038529:end --><!-- HN:45039228:start -->
* [45039228](https://news.social-protocols.org/stats?id=45039228) #12 4 points 15 comments -> [A vibe-coding tool for serious developers](https://appjet.ai)<!-- HN:45039228:end --><!-- HN:45041906:start -->
* [45041906](https://news.social-protocols.org/stats?id=45041906) #10 10 points 8 comments -> [I built a production app in a week by managing a swarm of 20 AI agents](https://zachwills.net/i-managed-a-swarm-of-20-ai-agents-for-a-week-here-are-the-8-rules-i-learned/)<!-- HN:45041906:end --><!-- HN:45038653:start -->
* [45038653](https://news.social-protocols.org/stats?id=45038653) #1 467 points 250 comments -> [Nx compromised: malware uses Claude code CLI to explore the filesystem](https://semgrep.dev/blog/2025/security-alert-nx-compromised-to-steal-wallets-and-credentials/)<!-- HN:45038653:end --><!-- HN:45041779:start -->
* [45041779](https://news.social-protocols.org/stats?id=45041779) #22 28 points 40 comments -> [Desktop Linux Keeps Winning the Wrong Battles](https://www.howtogeek.com/desktop-linux-keeps-winning-the-wrong-battles/)<!-- HN:45041779:end --><!-- HN:45042831:start -->
* [45042831](https://news.social-protocols.org/stats?id=45042831) #18 5 points 2 comments -> [Show HN: Whose p*nis is that now? Probably the weirdest website I've ever made](https://whosepenis.com/pages/fun)<!-- HN:45042831:end --><!-- HN:45046124:start -->
* [45046124](https://news.social-protocols.org/stats?id=45046124) #23 20 points 3 comments -> [Asahi Linux Lead Developer Steps Down](https://linuxiac.com/asahi-linux-lead-developer-steps-down/)<!-- HN:45046124:end -->
#### **Thursday, August 28, 2025**<!-- HN:45049320:start -->
* [45049320](https://news.social-protocols.org/stats?id=45049320) #3 14 points 16 comments -> [Show HN: I built AI that turns 4 hours of financial analysis into 30 seconds](https://duebase.com)<!-- HN:45049320:end --><!-- HN:45007857:start -->
* [45007857](https://news.social-protocols.org/stats?id=45007857) #30 19 points 24 comments -> [A Ritzy L.A. Enclave Learned a Bitter Lesson About the Limits of Its Wealth](https://www.nytimes.com/2025/08/24/magazine/landfill-calabasas-los-angeles-wildfire-ash.html)<!-- HN:45007857:end --><!-- HN:45051777:start -->
* [45051777](https://news.social-protocols.org/stats?id=45051777) #8 17 points 9 comments -> [LLMs solving problems OCR+NLP couldn't](https://cloudsquid.substack.com/p/ocr-is-legacy-tech)<!-- HN:45051777:end --><!-- HN:45052242:start -->
* [45052242](https://news.social-protocols.org/stats?id=45052242) #16 19 points 40 comments -> [US to put economic data on 9 blockchains](https://www.bloomberg.com/news/articles/2025-08-28/us-puts-gdp-data-on-the-blockchain-in-trump-crypto-push)<!-- HN:45052242:end --><!-- HN:45053226:start -->
* [45053226](https://news.social-protocols.org/stats?id=45053226) #3 44 points 17 comments -> [The Stock Market Is Selling the Fed's Independence Because ZIRP Broke the World](https://www.splinter.com/the-stock-market-is-selling-its-soul-and-the-feds-independence-to-trump-because-zirp-broke-the-world)<!-- HN:45053226:end --><!-- HN:45052980:start -->
* [45052980](https://news.social-protocols.org/stats?id=45052980) #27 47 points 37 comments -> [Brazil offers America a lesson in democratic maturity](https://www.economist.com/leaders/2025/08/28/brazil-offers-america-a-lesson-in-democratic-maturity)<!-- HN:45052980:end --><!-- HN:45054482:start -->
* [45054482](https://news.social-protocols.org/stats?id=45054482) #7 15 points 3 comments -> [GPT-realtime and Realtime API updates](https://openai.com/index/introducing-gpt-realtime/)<!-- HN:45054482:end --><!-- HN:45055450:start -->
* [45055450](https://news.social-protocols.org/stats?id=45055450) #7 32 points 1 comments -> [CDC director has been ousted just weeks after Senate confirmation](https://arstechnica.com/health/2025/08/report-cdc-director-being-ousted-just-weeks-after-senate-confirmation/)<!-- HN:45055450:end --><!-- HN:45054648:start -->
* [45054648](https://news.social-protocols.org/stats?id=45054648) #12 19 points 1 comments -> [In Search of AI Psychosis](https://www.astralcodexten.com/p/in-search-of-ai-psychosis)<!-- HN:45054648:end --><!-- HN:45057002:start -->
* [45057002](https://news.social-protocols.org/stats?id=45057002) #14 17 points 40 comments -> [There Goes the American Muscle Car](https://thedispatch.com/article/dodge-challenger-muscle-cars/)<!-- HN:45057002:end --><!-- HN:45057984:start -->
* [45057984](https://news.social-protocols.org/stats?id=45057984) #6 5 points 0 comments -> [Deep Zionism](https://scottaaronson.blog/?p=9082)<!-- HN:45057984:end -->
#### **Friday, August 29, 2025**
<!-- HN:45058483:start -->
* [45058483](https://news.social-protocols.org/stats?id=45058483) #29 11 points 8 comments -> [I researched every attempt to stop fascism in history. The success rate is 0%](https://cmarmitage.substack.com/p/i-researched-every-attempt-to-stop)<!-- HN:45058483:end --><!-- HN:45058762:start -->
* [45058762](https://news.social-protocols.org/stats?id=45058762) #3 -> [Deep Zionism](https://scottaaronson.blog/?p=9082)<!-- HN:45058762:end --><!-- HN:45058241:start -->
* [45058241](https://news.social-protocols.org/stats?id=45058241) #14 19 points 4 comments -> [Bad Craziness](https://www.math.columbia.edu/~woit/wordpress/?p=15191)<!-- HN:45058241:end -->