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

#### **Sunday, November 3, 2024**
<!-- HN:42030469:start -->
* [42030469](https://news.social-protocols.org/stats?id=42030469) #22 4 points 1 comments -> [Dead-heat poll results are astonishing – and improbable, these experts say](https://www.theguardian.com/us-news/2024/nov/02/what-polls-mean-so-far-trump-harris-election-voters)<!-- HN:42030469:end --><!-- HN:41978899:start -->
* [41978899](https://news.social-protocols.org/stats?id=41978899) #12 3 points 0 comments -> [Manage Database Clusters Without a Dedicated Operator on Kubernetes](https://kubeblocks.io/blog/how-to-manage-database-clusters-without-a-dedicated-operator)<!-- HN:41978899:end --><!-- HN:42030905:start -->
* [42030905](https://news.social-protocols.org/stats?id=42030905) #3 20 points 2 comments -> [PETA's Animal Shelter Continues as a Leader in Animal Death](https://www.lexology.com/library/detail.aspx?g=295a4113-b3be-42df-8585-665f496cc913)<!-- HN:42030905:end --><!-- HN:42030949:start -->
* [42030949](https://news.social-protocols.org/stats?id=42030949) #13 19 points 2 comments -> [A Golang Pipeline Abomination](https://poxate.com/blog/golang-pipeline-abomination)<!-- HN:42030949:end --><!-- HN:42031138:start -->
* [42031138](https://news.social-protocols.org/stats?id=42031138) #1 8 points 0 comments -> [The Prozac Era. What Next?](https://davidhealy.org/the-prozac-era-what-next/)<!-- HN:42031138:end --><!-- HN:42031476:start -->
* [42031476](https://news.social-protocols.org/stats?id=42031476) #15 5 points 0 comments -> [AI overwhelmingly prefers white and male job candidates](https://www.geekwire.com/2024/ai-overwhelmingly-prefers-white-and-male-job-candidates-in-new-test-of-resume-screening-bias/)<!-- HN:42031476:end --><!-- HN:42003136:start -->
* [42003136](https://news.social-protocols.org/stats?id=42003136) #16 19 points 3 comments -> [Writing Is a Visual Language](https://argumatronic.com/posts/2021-06-07-learning-to-write.html)<!-- HN:42003136:end --><!-- HN:42001762:start -->
* [42001762](https://news.social-protocols.org/stats?id=42001762) #21 6 points 1 comments -> [In search of Nirad Chaudhuri (2021)](https://thespectator.com/book-and-art/search-nirad-chaudhuri-india/)<!-- HN:42001762:end --><!-- HN:42032411:start -->
* [42032411](https://news.social-protocols.org/stats?id=42032411) #2 33 points 8 comments -> [Show HN: Kis.tools – A directory of tools that work](https://kis.tools)<!-- HN:42032411:end --><!-- HN:42032550:start -->
* [42032550](https://news.social-protocols.org/stats?id=42032550) #26 3 points 0 comments -> [Quantum Machines, Nvidia use machine learning to get closer to quantum computer](https://techcrunch.com/2024/11/02/quantum-machines-and-nvidia-use-machine-learning-to-get-closer-to-an-error-corrected-quantum-computer/)<!-- HN:42032550:end --><!-- HN:42031117:start -->
* [42031117](https://news.social-protocols.org/stats?id=42031117) #29 57 points 35 comments -> [Toyota to buy clean power from a $1.1B solar farm in Texas](https://electrek.co/2024/11/01/toyota-solar-farm-texas/)<!-- HN:42031117:end --><!-- HN:42032973:start -->
* [42032973](https://news.social-protocols.org/stats?id=42032973) #15 4 points 0 comments -> [Politicians not ambitious enough to save nature, say scientists](https://www.bbc.com/news/articles/cy9jdpep4ydo)<!-- HN:42032973:end --><!-- HN:42032035:start -->
* [42032035](https://news.social-protocols.org/stats?id=42032035) #12 22 points 0 comments -> [Advances in Zero-Knowledge Proofs: Bridging the Gap Between Theory and Practice [pdf]](https://www2.eecs.berkeley.edu/Pubs/TechRpts/2024/EECS-2024-35.pdf)<!-- HN:42032035:end --><!-- HN:42032693:start -->
* [42032693](https://news.social-protocols.org/stats?id=42032693) #2 35 points 22 comments -> [I Waited 10B Cycles and All I Got Was This Loading Screen](https://blog.preyneyv.dev/doing-less-with-more)<!-- HN:42032693:end --><!-- HN:42033238:start -->
* [42033238](https://news.social-protocols.org/stats?id=42033238) #11 7 points 1 comments -> [A new copyright rule lets McDonald's fix its own broken ice cream machines](https://www.npr.org/2024/11/02/g-s1-31893/mcdonalds-broken-ice-cream-machine-copyright-law)<!-- HN:42033238:end --><!-- HN:42035261:start -->
* [42035261](https://news.social-protocols.org/stats?id=42035261) #21 4 points 1 comments -> [FFmpeg: A 94x speed improvement demonstrated using handwritten assembly](https://twitter.com/FFmpeg/status/1852542388851601913)<!-- HN:42035261:end --><!-- HN:42035015:start -->
* [42035015](https://news.social-protocols.org/stats?id=42035015) #18 29 points 24 comments -> [$200M a year, 700k tons of rice, space tech: deal for North Korea in joining war](https://www.koreaherald.com/view.php?ud=20241103050116)<!-- HN:42035015:end --><!-- HN:42034974:start -->
* [42034974](https://news.social-protocols.org/stats?id=42034974) #21 6 points 1 comments -> [Commentary: Time to terminate the torture of time changes – Miami Herald](https://www.miamiherald.com/opinion/us-viewpoints/article294697994.html)<!-- HN:42034974:end --><!-- HN:42035699:start -->
* [42035699](https://news.social-protocols.org/stats?id=42035699) #26 6 points 0 comments -> [Apple's M4 Max is the single-core performance king in Geekbench 6](https://www.tomshardware.com/pc-components/cpus/apples-m4-max-is-the-single-core-performance-king-in-geekbench-6-m4-max-beats-the-core-ultra-9-285k-and-ryzen-9-9950x)<!-- HN:42035699:end --><!-- HN:42036488:start -->
* [42036488](https://news.social-protocols.org/stats?id=42036488) #29 5 points 0 comments -> [Let the internet vote: Trump or Harris](https://ip-vote.com/#trump_or_harris)<!-- HN:42036488:end -->
#### **Monday, November 4, 2024**
<!-- HN:41967396:start -->
* [41967396](https://news.social-protocols.org/stats?id=41967396) #5 10 points 0 comments -> [The Distracted Mind During a Crisis (2020)](https://distributed.blog/2020/04/29/adam-gazzaley-distracted-mind/)<!-- HN:41967396:end --><!-- HN:41978035:start -->
* [41978035](https://news.social-protocols.org/stats?id=41978035) #19 155 points 33 comments -> [Create block devices on your computer backed by Redstone Memory](https://github.com/williambl/blockblockdevice)<!-- HN:41978035:end --><!-- HN:42038004:start -->
* [42038004](https://news.social-protocols.org/stats?id=42038004) #16 22 points 40 comments -> [New better alterative to XML, JSON and YAML](https://xenondata.org)<!-- HN:42038004:end --><!-- HN:42036571:start -->
* [42036571](https://news.social-protocols.org/stats?id=42036571) #28 34 points 41 comments -> [Wasp Flamethrower Drone Attachment](https://throwflame.com/products/flamethrower-drone-kit/)<!-- HN:42036571:end --><!-- HN:42039406:start -->
* [42039406](https://news.social-protocols.org/stats?id=42039406) #14 24 points 11 comments -> [City council faces £216.5M loss over Oracle system debacle](https://www.theregister.com/2024/08/20/birmingham_oracle_cost/)<!-- HN:42039406:end --><!-- HN:42007138:start -->
* [42007138](https://news.social-protocols.org/stats?id=42007138) #13 18 points 3 comments -> [ASCII control characters in my terminal](https://jvns.ca/blog/2024/10/31/ascii-control-characters/)<!-- HN:42007138:end --><!-- HN:42036303:start -->
* [42036303](https://news.social-protocols.org/stats?id=42036303) #18 181 points 115 comments -> [Do you need Redis? PostgreSQL does queuing, locking, and pub/sub](https://spin.atomicobject.com/redis-postgresql/)<!-- HN:42036303:end --><!-- HN:42000752:start -->
* [42000752](https://news.social-protocols.org/stats?id=42000752) #12 6 points 0 comments -> [ClickPy – Python Package Analytics](https://clickpy.clickhouse.com/)<!-- HN:42000752:end --><!-- HN:42039454:start -->
* [42039454](https://news.social-protocols.org/stats?id=42039454) #25 3 points 0 comments -> [Soda Is Making a Comeback](https://www.cnn.com/2024/11/01/business/coke-dr-pepper-soda/index.html)<!-- HN:42039454:end --><!-- HN:42038821:start -->
* [42038821](https://news.social-protocols.org/stats?id=42038821) #23 13 points 0 comments -> [Internet Archive "Save Page Now" has been re-enabled](https://web.archive.org/save/)<!-- HN:42038821:end --><!-- HN:42034521:start -->
* [42034521](https://news.social-protocols.org/stats?id=42034521) #10 103 points 48 comments -> [ToolGit: A collection of scripts that extend Git with various sub-commands](https://github.com/ahmetsait/toolgit)<!-- HN:42034521:end --><!-- HN:42016816:start -->
* [42016816](https://news.social-protocols.org/stats?id=42016816) #21 51 points 0 comments -> [Programming NetBIOS on OS/2](https://www.os2museum.com/wp/programming-netbios-on-os-2/)<!-- HN:42016816:end --><!-- HN:42038911:start -->
* [42038911](https://news.social-protocols.org/stats?id=42038911) #22 13 points 2 comments -> [USB Insight Hub](https://www.crowdsupply.com/aerio-solutions/usb-insight-hub)<!-- HN:42038911:end --><!-- HN:42007586:start -->
* [42007586](https://news.social-protocols.org/stats?id=42007586) #16 3 points 0 comments -> [New Nintendo Music app could spell more trouble for illicit soundtrack posters](https://arstechnica.com/gaming/2024/10/will-the-new-nintendo-music-app-lead-to-more-dmca-takedowns-from-nintendo/)<!-- HN:42007586:end --><!-- HN:42035971:start -->
* [42035971](https://news.social-protocols.org/stats?id=42035971) #17 29 points 2 comments -> [Hermes 3 – Nous Research](https://nousresearch.com/hermes3/)<!-- HN:42035971:end --><!-- HN:42040166:start -->
* [42040166](https://news.social-protocols.org/stats?id=42040166) #11 10 points 0 comments -> [Quincy Jones, Giant of American Music, Dies at 91](https://www.nytimes.com/2024/11/04/arts/music/quincy-jones-dead.html)<!-- HN:42040166:end --><!-- HN:42036476:start -->
* [42036476](https://news.social-protocols.org/stats?id=42036476) #16 42 points 10 comments -> [GJS: Node.js Like Runtime for Gnome](https://gjs.guide/)<!-- HN:42036476:end --><!-- HN:42040600:start -->
* [42040600](https://news.social-protocols.org/stats?id=42040600) #21 66 points 23 comments -> [Is yt-dlp/yt-dlp compromised?](https://github.com/yt-dlp/yt-dlp/releases)<!-- HN:42040600:end --><!-- HN:42006125:start -->
* [42006125](https://news.social-protocols.org/stats?id=42006125) #16 25 points 9 comments -> [Open-source wheeled biped robot](https://github.com/upkie/upkie)<!-- HN:42006125:end --><!-- HN:42041638:start -->
* [42041638](https://news.social-protocols.org/stats?id=42041638) #18 6 points 2 comments -> [Nearly half of Americans think members of the opposing political party are evil](https://phys.org/news/2024-10-americans-members-opposing-political-party.html)<!-- HN:42041638:end --><!-- HN:42041397:start -->
* [42041397](https://news.social-protocols.org/stats?id=42041397) #16 24 points 16 comments -> [Once Linux's Biggest Enemy: Darl McBride Dies and Nobody Notices](https://fossforce.com/2024/11/once-linuxs-biggest-enemy-darl-mcbride-dies-and-nobody-notices/)<!-- HN:42041397:end --><!-- HN:42020103:start -->
* [42020103](https://news.social-protocols.org/stats?id=42020103) #24 132 points 170 comments -> [Interview Gone Wrong](https://www.ashu1461.com/interview-gone-wrong/)<!-- HN:42020103:end --><!-- HN:42041500:start -->
* [42041500](https://news.social-protocols.org/stats?id=42041500) #28 18 points 6 comments -> [Large Language Models Are Changing Collective Intelligence Forever](https://www.cmu.edu/tepper/news/stories/2024/september/collective-intelligence-and-llms.html)<!-- HN:42041500:end --><!-- HN:42042082:start -->
* [42042082](https://news.social-protocols.org/stats?id=42042082) #8 83 points 27 comments -> [New York Times Tech Workers Strike Ahead of Election](https://www.wsj.com/business/media/threat-of-new-york-times-tech-worker-strike-on-election-day-grows-174b1912)<!-- HN:42042082:end --><!-- HN:42042188:start -->
* [42042188](https://news.social-protocols.org/stats?id=42042188) #26 12 points 10 comments -> [One Company A/B Tested Hybrid Work. Here's What They Found](https://hbr.org/2024/10/one-company-a-b-tested-hybrid-work-heres-what-they-found)<!-- HN:42042188:end --><!-- HN:42043148:start -->
* [42043148](https://news.social-protocols.org/stats?id=42043148) #4 9 points 1 comments -> [ASCII Boobs in Your Codebase Won't Fix Themselves](https://shermanonsoftware.com/2024/11/04/ascii-boobs-in-your-codebase-wont-fix-themselves/)<!-- HN:42043148:end --><!-- HN:42018462:start -->
* [42018462](https://news.social-protocols.org/stats?id=42018462) #20 9 points 0 comments -> [Japan's Eightfold Fence](https://americanaffairsjournal.org/2017/08/japans-eightfold-fence/)<!-- HN:42018462:end --><!-- HN:42043108:start -->
* [42043108](https://news.social-protocols.org/stats?id=42043108) #26 6 points 0 comments -> [Amazon to cough $75B on capex in 2024, more next year](https://www.theregister.com/2024/11/01/amazon_75b_capex/)<!-- HN:42043108:end --><!-- HN:42043139:start -->
* [42043139](https://news.social-protocols.org/stats?id=42043139) #17 12 points 3 comments -> [Iceland embraced a shorter work week. Here's how it turned out](https://www.cnn.com/2024/10/25/business/iceland-shorter-working-week-economy/index.html)<!-- HN:42043139:end --><!-- HN:42046599:start -->
* [42046599](https://news.social-protocols.org/stats?id=42046599) #20 -> [Harris slams Speaker Mike Johnson for saying the GOP may repeal CHIPS Act](https://www.nbcnews.com/politics/kamala-harris/harris-slams-mike-johnson-gop-repeal-chips-act-rcna178513)<!-- HN:42046599:end --><!-- HN:42045212:start -->
* [42045212](https://news.social-protocols.org/stats?id=42045212) #6 171 points 2 comments -> [FFmpeg up to 94x performance boost after implementing handwritten assembly code](https://www.tomshardware.com/pc-components/cpus/ffmpeg-devs-boast-of-up-to-94x-performance-boost-after-implementing-handwritten-avx-512-assembly-code)<!-- HN:42045212:end -->
#### **Tuesday, November 5, 2024**
<!-- HN:42046956:start -->
* [42046956](https://news.social-protocols.org/stats?id=42046956) #9 10 points 8 comments -> [ReiserFS and the Art and Artist Problem](https://corecursive.com/reiserfs/)<!-- HN:42046956:end --><!-- HN:42047050:start -->
* [42047050](https://news.social-protocols.org/stats?id=42047050) #21 5 points 0 comments -> [After You Vote, Unplug](https://calnewport.com/blog/)<!-- HN:42047050:end --><!-- HN:42048795:start -->
* [42048795](https://news.social-protocols.org/stats?id=42048795) #17 6 points 1 comments -> [MrBeast's pitch decks get leaked](https://www.indiehackers.com/post/creators/mrbeasts-pitch-decks-get-leaked-and-they-aren-t-pretty-yJl2DI4mrKBcbtZixoB9)<!-- HN:42048795:end --><!-- HN:42049418:start -->
* [42049418](https://news.social-protocols.org/stats?id=42049418) #12 112 points 78 comments -> [Blood Sugar Control Is a Key Factor in Slowing Brain Aging, Mediterranean Diet++](https://www.bgu.ac.il/en/news-and-articles/blood-sugar-control-is-key-factor-in-slowing-brain-aging/)<!-- HN:42049418:end --><!-- HN:42018193:start -->
* [42018193](https://news.social-protocols.org/stats?id=42018193) #18 43 points 21 comments -> [Servicing a robot vacuum cleaner (2019)](https://willem.com/blog/2019-03-20_servicing-a-robot-vacuum-cleaner/)<!-- HN:42018193:end --><!-- HN:42048065:start -->
* [42048065](https://news.social-protocols.org/stats?id=42048065) #26 303 points 168 comments -> [Nvidia and its partners built a system to bypass U.S. export restrictions](https://twitter.com/kakashiii111/status/1853433531260649532)<!-- HN:42048065:end --><!-- HN:42048153:start -->
* [42048153](https://news.social-protocols.org/stats?id=42048153) #28 13 points 2 comments -> [Optimizing the Time and Dose of Melatonin as a Sleep-Promoting Drug](https://onlinelibrary.wiley.com/doi/10.1111/jpi.12985)<!-- HN:42048153:end --><!-- HN:42041611:start -->
* [42041611](https://news.social-protocols.org/stats?id=42041611) #4 19 points 10 comments -> [Oasis AI](https://oasis.decart.ai/starting-point)<!-- HN:42041611:end --><!-- HN:42017312:start -->
* [42017312](https://news.social-protocols.org/stats?id=42017312) #14 33 points 0 comments -> [Avoiding recompilation hell in Elixir with mix xref](https://r.ena.to/blog/avoiding-recompilation-hell-in-elixir-with-mix-xref/)<!-- HN:42017312:end --><!-- HN:42019672:start -->
* [42019672](https://news.social-protocols.org/stats?id=42019672) #15 10 points 2 comments -> [Bird wings inspire new approach to flight safety](https://engineering.princeton.edu/news/2024/10/28/bird-wings-inspire-new-approach-flight-safety)<!-- HN:42019672:end --><!-- HN:42005646:start -->
* [42005646](https://news.social-protocols.org/stats?id=42005646) #15 64 points 4 comments -> [Data Commons](https://datacommons.org/)<!-- HN:42005646:end --><!-- HN:42051651:start -->
* [42051651](https://news.social-protocols.org/stats?id=42051651) #9 30 points 42 comments -> [Why shouldn't you give money to homeless people?](https://spiralprogress.com/2024/11/04/why-shouldnt-you-give-money-to-homeless-people/)<!-- HN:42051651:end --><!-- HN:42052005:start -->
* [42052005](https://news.social-protocols.org/stats?id=42052005) #3 10 points 0 comments -> [Mozilla – Devil Incarnate](https://digdeeper.club/articles/mozilla.xhtml)<!-- HN:42052005:end --><!-- HN:41981674:start -->
* [41981674](https://news.social-protocols.org/stats?id=41981674) #16 15 points 0 comments -> [Managing Distributed State with GenServers in Phoenix and Elixir](https://blog.appsignal.com/2024/10/29/managing-distributed-state-with-genservers-in-phoenix-and-elixir.html)<!-- HN:41981674:end --><!-- HN:42042016:start -->
* [42042016](https://news.social-protocols.org/stats?id=42042016) #18 165 points 32 comments -> [What Every Developer Should Know About GPU Computing (2023)](https://blog.codingconfessions.com/p/gpu-computing)<!-- HN:42042016:end --><!-- HN:42052253:start -->
* [42052253](https://news.social-protocols.org/stats?id=42052253) #27 -> [The future belongs to those who prepare like Dwarkesh Patel](https://meridian.mercury.com/dwarkesh-patel)<!-- HN:42052253:end --><!-- HN:42052105:start -->
* [42052105](https://news.social-protocols.org/stats?id=42052105) #24 215 points 142 comments -> [New documentary reveals that 21,000 laborers have died working Saudi Vision 2030](https://www.archpaper.com/2024/10/documentary-reveals-21000-workers-killed-saudi-vision-2030-neom/)<!-- HN:42052105:end --><!-- HN:42051005:start -->
* [42051005](https://news.social-protocols.org/stats?id=42051005) #24 6 points 0 comments -> [Git Config](https://blog.izissise.net/posts/gitconfig/)<!-- HN:42051005:end --><!-- HN:41988127:start -->
* [41988127](https://news.social-protocols.org/stats?id=41988127) #20 16 points 14 comments -> [Myths and Realities: Prosecutors and Criminal Justice Reform](https://www.brennancenter.org/our-work/research-reports/myths-and-realities-prosecutors-and-criminal-justice-reform)<!-- HN:41988127:end --><!-- HN:42055702:start -->
* [42055702](https://news.social-protocols.org/stats?id=42055702) #28 5 points 1 comments -> [Google CEO Pichai Tells Employees to Stay Neutral](https://www.washingtonpost.com/elections/2024/11/04/trump-harris-election-live-updates/)<!-- HN:42055702:end -->
#### **Wednesday, November 6, 2024**
<!-- HN:42056287:start -->
* [42056287](https://news.social-protocols.org/stats?id=42056287) #3 9 points 0 comments -> [All the "Top" USElection tweets on X are scam or fake](https://i.ritzastatic.com/images/514e752c76a44dba9cf11b5e550afb33/x.gif)<!-- HN:42056287:end --><!-- HN:42056756:start -->
* [42056756](https://news.social-protocols.org/stats?id=42056756) #4 5 points 3 comments -> [MOATs Aren't Useful](https://rohan.ga/blog/moats/)<!-- HN:42056756:end --><!-- HN:42057186:start -->
* [42057186](https://news.social-protocols.org/stats?id=42057186) #20 5 points 1 comments -> [Bitcoin breaks above its all-time high of $73,777](https://www.fxstreet.com/cryptocurrencies/news/breaking-bitcoin-breaks-above-its-all-time-high-of-73-777-ahead-of-election-results-202411060312)<!-- HN:42057186:end --><!-- HN:42003087:start -->
* [42003087](https://news.social-protocols.org/stats?id=42003087) #5 20 points 12 comments -> [Why Aren't There B Batteries? (2022)](https://www.thebatterygenie.com/why-arent-there-b-batteries/)<!-- HN:42003087:end --><!-- HN:42057690:start -->
* [42057690](https://news.social-protocols.org/stats?id=42057690) #14 4 points 0 comments -> [Has a president ever won two non-consecutive White House elections?](https://nypost.com/2024/11/06/us-news/has-a-president-ever-won-two-non-consecutive-white-house-elections/)<!-- HN:42057690:end --><!-- HN:42057321:start -->
* [42057321](https://news.social-protocols.org/stats?id=42057321) #11 8 points 1 comments -> [Nintendo Switch successor will have backwards compatibility](https://twitter.com/NintendoCoLtd/status/1853972163033968794)<!-- HN:42057321:end --><!-- HN:42057465:start -->
* [42057465](https://news.social-protocols.org/stats?id=42057465) #14 5 points 2 comments -> [Show HN: Real-time ChatGPT-like data analysis for US Election](https://dashboard.itsverve.com/public)<!-- HN:42057465:end --><!-- HN:42057597:start -->
* [42057597](https://news.social-protocols.org/stats?id=42057597) #4 18 points 6 comments -> [A GitHub repo that curates all the awesome repos](https://github.com/bayandin/awesome-awesomeness)<!-- HN:42057597:end --><!-- HN:42025785:start -->
* [42025785](https://news.social-protocols.org/stats?id=42025785) #20 9 points 3 comments -> [Fact [pdf]](https://ranjitjhala.github.io/static/fact_dsl.pdf)<!-- HN:42025785:end --><!-- HN:42064963:start -->
* [42064963](https://news.social-protocols.org/stats?id=42064963) #29 3 points 2 comments -> ['Double Standards and Hypocrisy': The Dissent at Cisco over the War in Gaza](https://www.wired.com/story/cisco-dissent-gaza-israel-war/)<!-- HN:42064963:end --><!-- HN:42066129:start -->
* [42066129](https://news.social-protocols.org/stats?id=42066129) #24 5 points 1 comments -> [The Manosphere Won](https://www.wired.com/story/donald-trump-manosphere-won/)<!-- HN:42066129:end --><!-- HN:42066341:start -->
* [42066341](https://news.social-protocols.org/stats?id=42066341) #25 12 points 3 comments -> [Politicians are Jungian symbols, policies are facades](https://ofthetwodreams.substack.com/p/humans-live-and-die-by-their-myths)<!-- HN:42066341:end --><!-- HN:42069306:start -->
* [42069306](https://news.social-protocols.org/stats?id=42069306) #30 10 points 0 comments -> [German Government Collapses](https://www.euronews.com/my-europe/2024/11/06/german-coalition-government-collapses-chancellor-scholz-fires-finance-minister-lindner)<!-- HN:42069306:end --><!-- HN:42070007:start -->
* [42070007](https://news.social-protocols.org/stats?id=42070007) #3 9 points 0 comments -> [And now we see what is possible](https://geohot.github.io//blog/jekyll/update/2024/11/06/what-is-possible.html)<!-- HN:42070007:end -->
#### **Thursday, November 7, 2024**
<!-- HN:42072346:start -->
* [42072346](https://news.social-protocols.org/stats?id=42072346) #21 7 points 1 comments -> [Threads Bans Anyone for Mentioning Hitler, Even to Criticize](https://www.techdirt.com/2024/11/01/threads-bans-anyone-for-mentioning-hitler-even-to-criticize/)<!-- HN:42072346:end --><!-- HN:42073181:start -->
* [42073181](https://news.social-protocols.org/stats?id=42073181) #23 4 points 0 comments -> [Palestinians will not be allowed to return to homes in northern Gaza, says IDF](https://www.theguardian.com/world/2024/nov/06/palestinians-will-not-be-allowed-to-return-to-homes-in-northern-gaza-says-idf)<!-- HN:42073181:end --><!-- HN:42030915:start -->
* [42030915](https://news.social-protocols.org/stats?id=42030915) #24 7 points 0 comments -> [Listening in on the Mysterious Marbled Murrelet](https://hakaimagazine.com/news/listening-in-on-the-mysterious-marbled-murrelet/)<!-- HN:42030915:end --><!-- HN:42075387:start -->
* [42075387](https://news.social-protocols.org/stats?id=42075387) #15 9 points 4 comments -> [The Deterioration of Google](https://www.baldurbjarnason.com/2024/the-deterioration-of-google/)<!-- HN:42075387:end --><!-- HN:42074721:start -->
* [42074721](https://news.social-protocols.org/stats?id=42074721) #20 7 points 2 comments -> [WP Engine Tracker](https://wordpressenginetracker.com/)<!-- HN:42074721:end --><!-- HN:42069246:start -->
* [42069246](https://news.social-protocols.org/stats?id=42069246) #21 55 points 34 comments -> [Man spent $2M to find new largest prime number](https://www.popsci.com/science/largest-prime-number/)<!-- HN:42069246:end --><!-- HN:42075325:start -->
* [42075325](https://news.social-protocols.org/stats?id=42075325) #14 6 points 0 comments -> [What if everyone pointed a laser pointer at the moon? [video]](https://www.youtube.com/watch?v=JqFSGkFPipM)<!-- HN:42075325:end --><!-- HN:42074845:start -->
* [42074845](https://news.social-protocols.org/stats?id=42074845) #28 14 points 0 comments -> [Job leaving rituals in the WFH era](https://shkspr.mobi/blog/2022/11/job-leaving-rituals-in-the-wfh-era/)<!-- HN:42074845:end --><!-- HN:42004228:start -->
* [42004228](https://news.social-protocols.org/stats?id=42004228) #30 4 points 1 comments -> [Kliktopia Archive](https://kliktopia.org)<!-- HN:42004228:end --><!-- HN:42080974:start -->
* [42080974](https://news.social-protocols.org/stats?id=42080974) #16 19 points 26 comments -> [Top Billionaires make nearly $64B in post-Trump election stock surge](https://www.theregister.com/2024/11/07/top_10_billionaires/)<!-- HN:42080974:end --><!-- HN:42082119:start -->
* [42082119](https://news.social-protocols.org/stats?id=42082119) #8 7 points 1 comments -> [How to Solve It with Code](https://www.answer.ai/posts/2024-11-07-solveit.html)<!-- HN:42082119:end -->
#### **Friday, November 8, 2024**
<!-- HN:42083630:start -->
* [42083630](https://news.social-protocols.org/stats?id=42083630) #19 26 points 2 comments -> [Kagi Translate](https://translate.kagi.com/)<!-- HN:42083630:end --><!-- HN:42084571:start -->
* [42084571](https://news.social-protocols.org/stats?id=42084571) #11 29 points 40 comments -> [There's Almost No Gitlab](https://julien.danjou.info/p/theres-almost-no-gitlab)<!-- HN:42084571:end --><!-- HN:42084369:start -->
* [42084369](https://news.social-protocols.org/stats?id=42084369) #16 10 points 1 comments -> [Corinthian Bronze](https://en.wikipedia.org/wiki/Corinthian_bronze)<!-- HN:42084369:end --><!-- HN:42082498:start -->
* [42082498](https://news.social-protocols.org/stats?id=42082498) #21 54 points 37 comments -> [Wild Ball](https://r3f-drei-rapier.surge.sh)<!-- HN:42082498:end --><!-- HN:42083559:start -->
* [42083559](https://news.social-protocols.org/stats?id=42083559) #14 286 points 198 comments -> [After decades, FDA moves to pull ineffective decongestant off shelves](https://arstechnica.com/health/2024/11/fda-proposes-ditching-common-decongestant-for-being-completely-useless/)<!-- HN:42083559:end --><!-- HN:42086795:start -->
* [42086795](https://news.social-protocols.org/stats?id=42086795) #5 11 points 1 comments -> [Show HN: Motherfuckingrssreader.com](https://motherfuckingrssreader.com/)<!-- HN:42086795:end --><!-- HN:42087346:start -->
* [42087346](https://news.social-protocols.org/stats?id=42087346) #20 58 points 27 comments -> [TSMC will stop making 7 nm chips for Chinese customers](https://arstechnica.com/tech-policy/2024/11/tsmc-will-stop-making-7-nm-chips-for-chinese-customers/)<!-- HN:42087346:end --><!-- HN:42087478:start -->
* [42087478](https://news.social-protocols.org/stats?id=42087478) #22 38 points 2 comments -> [Man sick of crashes sues Intel for allegedly hiding CPU defects](https://arstechnica.com/tech-policy/2024/11/man-sick-of-crashes-sues-intel-for-allegedly-hiding-cpu-defects/)<!-- HN:42087478:end --><!-- HN:42088024:start -->
* [42088024](https://news.social-protocols.org/stats?id=42088024) #23 6 points 2 comments -> [How Much Porn Are We Watching? A Lot](https://thewalrus.ca/when-porn-becomes-communal/)<!-- HN:42088024:end --><!-- HN:42087811:start -->
* [42087811](https://news.social-protocols.org/stats?id=42087811) #26 26 points 15 comments -> [It feels like 2004 again](https://www.anildash.com//2024/10/15/its-2004-again/)<!-- HN:42087811:end --><!-- HN:42089883:start -->
* [42089883](https://news.social-protocols.org/stats?id=42089883) #24 -> [I wonder how much Cook dithered over that cheerful-looking exclamation mark](https://daringfireball.net/2024/11/i_wonder)<!-- HN:42089883:end --><!-- HN:42090306:start -->
* [42090306](https://news.social-protocols.org/stats?id=42090306) #15 7 points 0 comments -> [Nearly 70% of Gaza war dead are women and children, UN says](https://www.bbc.com/news/articles/cn5wel11pgdo)<!-- HN:42090306:end --><!-- HN:42090696:start -->
* [42090696](https://news.social-protocols.org/stats?id=42090696) #28 4 points 1 comments -> [Dutch king says his nation failed Jewish community during football fan attacks](https://www.independent.co.uk/news/world/europe/amsterdam-israel-football-ajax-maccabi-attacks-king-netherlands-b2643792.html)<!-- HN:42090696:end -->
#### **Saturday, November 9, 2024**
<!-- HN:42091181:start -->
* [42091181](https://news.social-protocols.org/stats?id=42091181) #24 4 points 2 comments -> [Maelstrom: High-Performance Matrix Home-Server Written in Rust](https://github.com/maelstrom-rs/maelstrom)<!-- HN:42091181:end --><!-- HN:42090568:start -->
* [42090568](https://news.social-protocols.org/stats?id=42090568) #29 27 points 6 comments -> [What does a scientist look like? Children drawing women more than ever before](https://www.science.org/content/article/what-does-scientist-look-children-are-drawing-women-more-ever)<!-- HN:42090568:end --><!-- HN:42094180:start -->
* [42094180](https://news.social-protocols.org/stats?id=42094180) #17 7 points 1 comments -> [The Retraction Watch Hijacked Journal Checker](https://retractionwatch.com/the-retraction-watch-hijacked-journal-checker/)<!-- HN:42094180:end --><!-- HN:42008891:start -->
* [42008891](https://news.social-protocols.org/stats?id=42008891) #16 112 points 24 comments -> ['Smart' insulin prevents diabetic highs – and deadly lows](https://www.nature.com/articles/d41586-024-03357-7#ref-CR1)<!-- HN:42008891:end --><!-- HN:42095390:start -->
* [42095390](https://news.social-protocols.org/stats?id=42095390) #13 11 points 0 comments -> [Average rate on a 30-year mortgage in the US rises for 6th straight week](https://apnews.com/article/mortgage-rates-housing-interest-financing-home-loan-36992be9d7760237baef95ca2c160f9a)<!-- HN:42095390:end --><!-- HN:42095362:start -->
* [42095362](https://news.social-protocols.org/stats?id=42095362) #22 12 points 5 comments -> [Australia to ban under-16s from social media – but can't say how TikTok](https://www.theguardian.com/australia-news/2024/nov/07/australian-government-to-legislate-social-media-age-limit-of-16-but-cant-say-how-platforms-will-enforce-it)<!-- HN:42095362:end --><!-- HN:42095319:start -->
* [42095319](https://news.social-protocols.org/stats?id=42095319) #26 14 points 0 comments -> [A brief history of privacy protection on Macs](https://eclecticlight.co/2024/11/09/a-brief-history-of-privacy-protection-on-macs/)<!-- HN:42095319:end --><!-- HN:42070807:start -->
* [42070807](https://news.social-protocols.org/stats?id=42070807) #19 56 points 14 comments -> [Writing Tiny Desktop Apps in C and GTK3 (2022)](https://danielc.dev/blog/tiny-windows-linux-gtk-apps/)<!-- HN:42070807:end --><!-- HN:42096208:start -->
* [42096208](https://news.social-protocols.org/stats?id=42096208) #24 3 points 0 comments -> [DNA firm [Atlas Biomed] holding highly sensitive data 'vanishes' without warning](https://www.bbc.co.uk/news/articles/cz7wl7rpndjo)<!-- HN:42096208:end --><!-- HN:42073406:start -->
* [42073406](https://news.social-protocols.org/stats?id=42073406) #21 5 points 0 comments -> [Calculating at Pencil and Paper Scale](https://win-vector.com/2024/11/06/calculating-at-pencil-and-paper-scale/)<!-- HN:42073406:end -->