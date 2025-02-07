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

#### **Saturday, February 1, 2025**
<!-- HN:42851880:start -->
* [42851880](https://news.social-protocols.org/stats?id=42851880) #10 8 points 1 comments -> [Facebook free bikes dumped by employees and police hassle kids who ride them](https://www.businessinsider.com/facebook-bikes-locals-stopped-police-riding-employee-bikes-2019-2)<!-- HN:42851880:end --><!-- HN:42895529:start -->
* [42895529](https://news.social-protocols.org/stats?id=42895529) #16 3 points 3 comments -> [Hypocrisy and politics in free and open source software projects](https://unixdigest.com/articles/hypocrisy-and-politics-in-free-and-open-source-software-projects.html)<!-- HN:42895529:end --><!-- HN:42894708:start -->
* [42894708](https://news.social-protocols.org/stats?id=42894708) #7 154 points 69 comments -> [Decision to dump water from Tulare County lakes altered after confusing locals](https://sjvwater.org/decision-to-dump-water-from-tulare-county-lakes-altered-after-sending-locals-in-mad-scramble/)<!-- HN:42894708:end --><!-- HN:42896145:start -->
* [42896145](https://news.social-protocols.org/stats?id=42896145) #2 27 points 1 comments -> [Authoritarian Coups Are Gradual Then Sudden](https://hartmannreport.com/p/authoritarian-coups-are-gradual-then)<!-- HN:42896145:end --><!-- HN:42854489:start -->
* [42854489](https://news.social-protocols.org/stats?id=42854489) #21 4 points 1 comments -> [I made a quiz from famous outages – What's the root cause?](https://spike.sh/quiz)<!-- HN:42854489:end --><!-- HN:42896188:start -->
* [42896188](https://news.social-protocols.org/stats?id=42896188) #23 34 points 41 comments -> [Norway's wealth fund now worth $319,900 per citizen](https://sherwood.news/world/norways-wealth-fund-reports-record-profits-worth-usd319-900-citizen/)<!-- HN:42896188:end --><!-- HN:42898676:start -->
* [42898676](https://news.social-protocols.org/stats?id=42898676) #6 6 points 0 comments -> [Big Tech's Class War Politics](https://www.unpopularfront.news/p/big-techs-class-war-politics)<!-- HN:42898676:end --><!-- HN:42897785:start -->
* [42897785](https://news.social-protocols.org/stats?id=42897785) #18 19 points 16 comments -> [Running DeepSeek R1 on Your Own (cheap) Hardware – The fast and easy way](https://linux-howto.org/running-deepseek-r1-on-your-own-hardware-the-fast-and-easy-way)<!-- HN:42897785:end --><!-- HN:42899368:start -->
* [42899368](https://news.social-protocols.org/stats?id=42899368) #15 10 points 2 comments -> [Executive Order: For each new agency regulation issued, 10 must be repealed](https://www.whitehouse.gov/fact-sheets/2025/01/fact-sheet-president-donald-j-trump-launches-massive-10-to-1-deregulation-initiative/)<!-- HN:42899368:end --><!-- HN:42898771:start -->
* [42898771](https://news.social-protocols.org/stats?id=42898771) #16 106 points 1 comments -> [Datasets from Data.gov Have Disappeared](https://mashable.com/article/government-datasets-disappear-since-trump-inauguration)<!-- HN:42898771:end --><!-- HN:42899913:start -->
* [42899913](https://news.social-protocols.org/stats?id=42899913) #8 45 points 22 comments -> [The Strike Is Coming](https://generalstrikeus.com)<!-- HN:42899913:end --><!-- HN:42899732:start -->
* [42899732](https://news.social-protocols.org/stats?id=42899732) #28 20 points 9 comments -> [Revisiting Random Number Generation](https://swlody.dev/Posts/Revisiting-random-number-generation)<!-- HN:42899732:end --><!-- HN:42899841:start -->
* [42899841](https://news.social-protocols.org/stats?id=42899841) #13 140 points 97 comments -> [ADHD Didn't Break Me–My Parents Did](https://claimingattention.substack.com/p/adhd-did-not-break-me-my-parents-did)<!-- HN:42899841:end --><!-- HN:42902576:start -->
* [42902576](https://news.social-protocols.org/stats?id=42902576) #6 -> [Musk's Junta Establishes Him as Head of Government](https://www.doomsdayscenario.co/p/musk-s-junta-establishes-him-as-head-of-government)<!-- HN:42902576:end --><!-- HN:42902678:start -->
* [42902678](https://news.social-protocols.org/stats?id=42902678) #23 61 points 17 comments -> [USDA Inspector General Who Refused to Leave Escorted from Office by Security](https://gizmodo.com/usda-inspector-general-who-refused-to-leave-post-escorted-from-office-by-security-2000556605)<!-- HN:42902678:end -->
#### **Sunday, February 2, 2025**
<!-- HN:42903336:start -->
* [42903336](https://news.social-protocols.org/stats?id=42903336) #30 102 points 22 comments -> [Philip Low Unmasking Musk](https://bsky.app/profile/brainking.bsky.social/post/3lgsco7cdnc26)<!-- HN:42903336:end --><!-- HN:42903803:start -->
* [42903803](https://news.social-protocols.org/stats?id=42903803) #24 11 points 6 comments -> [The Power of Poetry: Why Everyone Should Write](https://domofutu.substack.com/p/the-power-of-poetry)<!-- HN:42903803:end --><!-- HN:42906311:start -->
* [42906311](https://news.social-protocols.org/stats?id=42906311) #27 6 points 1 comments -> [800x Speed Boost on Nvidia GPUs](https://www.scmp.com/news/china/science/article/3296135/chinese-algorithm-boosts-nvidia-gpu-performance-800-fold-science-computing)<!-- HN:42906311:end --><!-- HN:42864019:start -->
* [42864019](https://news.social-protocols.org/stats?id=42864019) #11 10 points 10 comments -> [The Middle East's first super-luxury train will gleam gold](https://www.cnn.com/travel/dream-of-the-desert-saudi-arabia-train/index.html)<!-- HN:42864019:end --><!-- HN:42909259:start -->
* [42909259](https://news.social-protocols.org/stats?id=42909259) #5 6 points 3 comments -> [Show HN: BGNix-100% Free and Privacy Image Background Removal](https://www.bgnix.com/)<!-- HN:42909259:end --><!-- HN:42911598:start -->
* [42911598](https://news.social-protocols.org/stats?id=42911598) #21 4 points 0 comments -> [The Network State Coup is Happening Right Now](https://www.thenerdreich.com/the-network-state-coup-is-happening-right-now/)<!-- HN:42911598:end --><!-- HN:42911764:start -->
* [42911764](https://news.social-protocols.org/stats?id=42911764) #26 4 points 0 comments -> [The AI revolution is running out of data](https://www.nature.com/articles/d41586-025-00288-9)<!-- HN:42911764:end --><!-- HN:42912649:start -->
* [42912649](https://news.social-protocols.org/stats?id=42912649) #14 11 points 1 comments -> [Protest against deportations forms in downtown L.A causing ‘major gridlock’](https://ktla.com/news/local-news/massive-protest-against-trump-deportations-forms-near-downtown-l-a-lapd-calls-it-non-permitted/)<!-- HN:42912649:end -->
#### **Monday, February 3, 2025**
<!-- HN:42913420:start -->
* [42913420](https://news.social-protocols.org/stats?id=42913420) #11 12 points 2 comments -> [Federal government grant award search](https://datarepublican.com/award_search/)<!-- HN:42913420:end --><!-- HN:42913909:start -->
* [42913909](https://news.social-protocols.org/stats?id=42913909) #22 31 points 20 comments -> [Vibe Coding](https://twitter.com/karpathy/status/1886192184808149383)<!-- HN:42913909:end --><!-- HN:42914135:start -->
* [42914135](https://news.social-protocols.org/stats?id=42914135) #21 10 points 1 comments -> [Making System Calls in Rust: Requesting Services from the Kernel](https://www.kaishira.com/2025/01/30/making-system-calls-in-rust-requesting-services-from-the-kernel/)<!-- HN:42914135:end --><!-- HN:42915053:start -->
* [42915053](https://news.social-protocols.org/stats?id=42915053) #29 8 points 1 comments -> [AI Is Robbing Jr. Devs](https://benbrougher.tech/posts/llms-are-robbing-jr-devs/)<!-- HN:42915053:end --><!-- HN:42920125:start -->
* [42920125](https://news.social-protocols.org/stats?id=42920125) #26 3 points 0 comments -> [Dianna (Physics girl on YT) stands in 2 years [video]](https://www.youtube.com/watch?v=2ntx91cOYEc)<!-- HN:42920125:end --><!-- HN:42920437:start -->
* [42920437](https://news.social-protocols.org/stats?id=42920437) #21 -> [Coup](https://wh47.substack.com/p/ongoing-coup)<!-- HN:42920437:end --><!-- HN:42920500:start -->
* [42920500](https://news.social-protocols.org/stats?id=42920500) #21 15 points 2 comments -> [Better AI Is a Matter of Timing](https://spectrum.ieee.org/mems-time)<!-- HN:42920500:end --><!-- HN:42921867:start -->
* [42921867](https://news.social-protocols.org/stats?id=42921867) #26 11 points 1 comments -> [Texas Tempts Meta](https://www.bloomberg.com/opinion/articles/2025-02-03/texas-tempts-meta)<!-- HN:42921867:end --><!-- HN:42920723:start -->
* [42920723](https://news.social-protocols.org/stats?id=42920723) #19 54 points 68 comments -> [It's not 'emotional labour', it's kin work](https://thefuturefeeling.substack.com/p/its-not-emotional-labour)<!-- HN:42920723:end -->
#### **Tuesday, February 4, 2025**
<!-- HN:42926732:start -->
* [42926732](https://news.social-protocols.org/stats?id=42926732) #8 8 points 4 comments -> [Hector Martin: "Behold, a maintainer sabotaging the Rust for Linux project"](https://lwn.net/ml/all/20250131075751.GA16720@lst.de/)<!-- HN:42926732:end --><!-- HN:42928101:start -->
* [42928101](https://news.social-protocols.org/stats?id=42928101) #21 4 points 1 comments -> [Try to Jailbreak Claude's Constitutional Classifiers](https://claude.ai/login?returnTo=/constitutional-classifiers)<!-- HN:42928101:end --><!-- HN:42897360:start -->
* [42897360](https://news.social-protocols.org/stats?id=42897360) #5 23 points 1 comments -> [How to Compile Java into Native Binaries with Mill and Graal](https://mill-build.org/blog/7-graal-native-executables.html)<!-- HN:42897360:end --><!-- HN:42931953:start -->
* [42931953](https://news.social-protocols.org/stats?id=42931953) #2 6 points 1 comments -> [Codeberg: Free GitHub hosting](https://codeberg.org/)<!-- HN:42931953:end --><!-- HN:42932390:start -->
* [42932390](https://news.social-protocols.org/stats?id=42932390) #15 7 points 1 comments -> [New Bill to Kill Anime and Other Piracy in US Backed by Netflix, Disney and Sony](https://www.cbr.com/america-new-piracy-bill-netflix-disney-sony-backing/)<!-- HN:42932390:end --><!-- HN:42930786:start -->
* [42930786](https://news.social-protocols.org/stats?id=42930786) #19 81 points 67 comments -> [Backblaze seemingly does not support files greater than 1 TB](https://wadetregaskis.com/backblaze-seemingly-does-not-support-files-greater-than-1-tb/)<!-- HN:42930786:end --><!-- HN:42890915:start -->
* [42890915](https://news.social-protocols.org/stats?id=42890915) #20 44 points 51 comments -> [Apple Scraps Work on Mac-Connected Augmented Reality Glasses](https://www.bloomberg.com/news/articles/2025-01-31/apple-scraps-work-on-mac-connected-augmented-reality-glasses)<!-- HN:42890915:end --><!-- HN:42931088:start -->
* [42931088](https://news.social-protocols.org/stats?id=42931088) #22 59 points 11 comments -> [VSCode Marketplace Web Pages No Longer Allow Direct VSIX Downloads](https://github.com/microsoft/vsmarketplace/issues/1135)<!-- HN:42931088:end --><!-- HN:42904723:start -->
* [42904723](https://news.social-protocols.org/stats?id=42904723) #17 144 points 78 comments -> [Compiling Java into native binaries with Graal and Mill](https://mill-build.org/blog/7-graal-native-executables.html)<!-- HN:42904723:end --><!-- HN:42931803:start -->
* [42931803](https://news.social-protocols.org/stats?id=42931803) #23 12 points 2 comments -> ['No medical evidence' to support Lucy Letby's conviction, expert panel finds](https://www.theguardian.com/uk-news/2025/feb/04/no-medical-evidence-to-support-lucy-letby-conviction-expert-panel-finds)<!-- HN:42931803:end --><!-- HN:42932956:start -->
* [42932956](https://news.social-protocols.org/stats?id=42932956) #20 3 points 0 comments -> [European Alternatives for Popular Services](https://european-alternatives.eu/alternatives-to)<!-- HN:42932956:end --><!-- HN:42933031:start -->
* [42933031](https://news.social-protocols.org/stats?id=42933031) #6 18 points 19 comments -> [Programmers are modern-day computers](https://jtlicardo.com/writing/modern-day-computers/)<!-- HN:42933031:end --><!-- HN:42934363:start -->
* [42934363](https://news.social-protocols.org/stats?id=42934363) #7 10 points 2 comments -> [Venture Capital Extremism](https://www.vcinfodocs.com/venture-capital-extremism)<!-- HN:42934363:end --><!-- HN:42935581:start -->
* [42935581](https://news.social-protocols.org/stats?id=42935581) #29 9 points 0 comments -> [The 'Rapid Unscheduled Disassembly' of the United States Government](https://www.theatlantic.com/technology/archive/2025/02/elon-musk-bureaucratic-coup/681559/)<!-- HN:42935581:end --><!-- HN:42937286:start -->
* [42937286](https://news.social-protocols.org/stats?id=42937286) #7 10 points 0 comments -> [Trump's Guantánamo Memo](https://www.stevevladeck.com/p/bonus-120-trumps-guantanamo-memo)<!-- HN:42937286:end --><!-- HN:42937783:start -->
* [42937783](https://news.social-protocols.org/stats?id=42937783) #12 5 points 1 comments -> [Peter Thiel Company Generator](https://www.peterthielcompanygenerator.org/)<!-- HN:42937783:end --><!-- HN:42938647:start -->
* [42938647](https://news.social-protocols.org/stats?id=42938647) #8 -> [A Coup Is in Progress in America](https://www.notesfromthecircus.com/p/a-coup-is-in-progress-in-america)<!-- HN:42938647:end --><!-- HN:42939995:start -->
* [42939995](https://news.social-protocols.org/stats?id=42939995) #5 62 points 18 comments -> [Doge Sets Sights on Medicaid: New York Times](https://www.beckershospitalreview.com/finance/doge-sets-sights-on-medicaid-new-york-times.html)<!-- HN:42939995:end --><!-- HN:42940124:start -->
* [42940124](https://news.social-protocols.org/stats?id=42940124) #6 9 points 0 comments -> [ChatGPT in Shambles](https://garymarcus.substack.com/p/chatgpt-in-shambles)<!-- HN:42940124:end -->
#### **Wednesday, February 5, 2025**
<!-- HN:42940284:start -->
* [42940284](https://news.social-protocols.org/stats?id=42940284) #5 230 points 3 comments -> [Google removes pledge to not use AI for weapons from website](https://techcrunch.com/2025/02/04/google-removes-pledge-to-not-use-ai-for-weapons-from-website/)<!-- HN:42940284:end --><!-- HN:42946918:start -->
* [42946918](https://news.social-protocols.org/stats?id=42946918) #11 8 points 3 comments -> [HN as TikTok: Welcome to HN Hell](https://hnhell.com)<!-- HN:42946918:end --><!-- HN:42946046:start -->
* [42946046](https://news.social-protocols.org/stats?id=42946046) #12 125 points 77 comments -> [Carl Sagan Predicts the Decline of America (1995)](https://www.openculture.com/2025/02/carl-sagan-predicts-the-decline-of-america-unable-to-know-whats-true.html)<!-- HN:42946046:end --><!-- HN:42951959:start -->
* [42951959](https://news.social-protocols.org/stats?id=42951959) #16 10 points 0 comments -> [Project 2025](https://www.project2025.org/)<!-- HN:42951959:end --><!-- HN:42952330:start -->
* [42952330](https://news.social-protocols.org/stats?id=42952330) #30 6 points 1 comments -> [Google drops pledge not to use AI for weapons, surveillance](https://www.aljazeera.com/economy/2025/2/5/chk_google-drops-pledge-not-to-use-ai-for-weapons-surveillance)<!-- HN:42952330:end --><!-- HN:42917338:start -->
* [42917338](https://news.social-protocols.org/stats?id=42917338) #22 5 points 1 comments -> [How to Prepare Your Next RPG Campaign Instantly](https://rpgtabletops.com/products/the-ultimate-maps-bundle)<!-- HN:42917338:end -->
#### **Thursday, February 6, 2025**
<!-- HN:42957617:start -->
* [42957617](https://news.social-protocols.org/stats?id=42957617) #28 5 points 1 comments -> ['Accidental' FBI Chief Builds a Following as Agency's Defender](https://www.nytimes.com/2025/02/04/us/politics/fbi-director-brian-driscoll-trump-justice-department.html)<!-- HN:42957617:end --><!-- HN:42957874:start -->
* [42957874](https://news.social-protocols.org/stats?id=42957874) #27 -> [Of Course It's a Coup](https://snyder.substack.com/p/of-course-its-a-coup)<!-- HN:42957874:end --><!-- HN:42958286:start -->
* [42958286](https://news.social-protocols.org/stats?id=42958286) #4 7 points 0 comments -> [Department of Government Efficiency Live Tracker](https://doge-tracker.com/)<!-- HN:42958286:end --><!-- HN:42958257:start -->
* [42958257](https://news.social-protocols.org/stats?id=42958257) #22 21 points 2 comments -> [NOAA Employees Told to Pause Work with 'Foreign Nationals'](https://www.wired.com/story/noaa-employees-foreign-nationals/)<!-- HN:42958257:end --><!-- HN:42959260:start -->
* [42959260](https://news.social-protocols.org/stats?id=42959260) #5 125 points 5 comments -> [America's Dangerous Movement Toward Oligarchy, Authoritarianism and Kleptocracy](https://www.counterpunch.org/2025/02/04/americas-dangerous-movement-toward-oligarchy-authoritarianism-and-kleptocracy/)<!-- HN:42959260:end --><!-- HN:42930161:start -->
* [42930161](https://news.social-protocols.org/stats?id=42930161) #6 13 points 2 comments -> [Alpine Linux Seeking Support After Equinix Metal Sunsets](https://alpinelinux.org/posts/Seeking-Support-After-Equinix-Metal-Sunsets.html)<!-- HN:42930161:end --><!-- HN:42959440:start -->
* [42959440](https://news.social-protocols.org/stats?id=42959440) #17 49 points 2 comments -> [Google scraps diversity 'aspirations,' citing role as federal contractor](https://www.cnbc.com/2025/02/05/google-scraps-diversity-aspirations-as-a-federal-contractor.html)<!-- HN:42959440:end --><!-- HN:42959777:start -->
* [42959777](https://news.social-protocols.org/stats?id=42959777) #16 16 points 7 comments -> [LLMs Were Backdoored Years Ago](https://remyhax.xyz/posts/plagairism/)<!-- HN:42959777:end --><!-- HN:42961192:start -->
* [42961192](https://news.social-protocols.org/stats?id=42961192) #15 13 points 3 comments -> [Tesla's sales plummet across Europe](https://www.ft.com/content/ea2329e4-b4bc-4e2d-be34-e9a8ea31129c)<!-- HN:42961192:end --><!-- HN:42962183:start -->
* [42962183](https://news.social-protocols.org/stats?id=42962183) #1 33 points 9 comments -> [Republican Congressman Introduces Bill Seeking Abolishment of OSHA](https://www.hipaajournal.com/biggs-nulify-occupational-safety-health-administration-act-nosha/)<!-- HN:42962183:end --><!-- HN:42958012:start -->
* [42958012](https://news.social-protocols.org/stats?id=42958012) #5 105 points 6 comments -> [Deep Reinforcement Learning: Pong from Pixels (2016)](http://karpathy.github.io/2016/05/31/rl/)<!-- HN:42958012:end --><!-- HN:42949390:start -->
* [42949390](https://news.social-protocols.org/stats?id=42949390) #13 424 points 163 comments -> [Servo's progress in 2024](https://servo.org/blog/2025/01/31/servo-in-2024/)<!-- HN:42949390:end --><!-- HN:42960291:start -->
* [42960291](https://news.social-protocols.org/stats?id=42960291) #21 128 points 30 comments -> [Cloudflare R2 Global Outage](https://www.cloudflarestatus.com)<!-- HN:42960291:end --><!-- HN:42962015:start -->
* [42962015](https://news.social-protocols.org/stats?id=42962015) #25 28 points 16 comments -> [The Sad Math of Ads: messages of inadequacy and salvation through consumption](https://www.jamesdamore.com/articles/the-sad-math-of-ads)<!-- HN:42962015:end --><!-- HN:42962545:start -->
* [42962545](https://news.social-protocols.org/stats?id=42962545) #18 19 points 1 comments -> [Thailand cuts power and internet to areas of Myanmar to disrupt scam gangs](https://www.bitdefender.com/en-us/blog/hotforsecurity/thailand-cuts-power-and-internet-to-areas-of-myanmar-to-disrupt-scam-gangs)<!-- HN:42962545:end --><!-- HN:42962127:start -->
* [42962127](https://news.social-protocols.org/stats?id=42962127) #26 36 points 28 comments -> [FDIC has released 175 internal documents on "Operation Chokepoint 2.0"](https://www.fdic.gov/foia/correspondence-related-crypto-related-activities)<!-- HN:42962127:end --><!-- HN:42964166:start -->
* [42964166](https://news.social-protocols.org/stats?id=42964166) #27 10 points 3 comments -> ["Silicon Valley built the modern world. Why shouldn't we run it?"](https://twitter.com/Shedletsky/status/1886563357249212846)<!-- HN:42964166:end --><!-- HN:42963993:start -->
* [42963993](https://news.social-protocols.org/stats?id=42963993) #21 7 points 1 comments -> [Public services are for users, not providers](https://www.slowboring.com/p/public-services-are-for-users-not)<!-- HN:42963993:end --><!-- HN:42964424:start -->
* [42964424](https://news.social-protocols.org/stats?id=42964424) #6 9 points 5 comments -> [Show HN: Make your YC application stand out (Spring 2025 edition)](https://ycscore.com)<!-- HN:42964424:end --><!-- HN:42961046:start -->
* [42961046](https://news.social-protocols.org/stats?id=42961046) #5 8 points 1 comments -> [Java JIT Compiler and Runtime in Common Lisp](https://github.com/atgreen/openldk)<!-- HN:42961046:end --><!-- HN:42965336:start -->
* [42965336](https://news.social-protocols.org/stats?id=42965336) #26 5 points 2 comments -> [AI tool to create well-written LinkedIn posts in seconds](https://contentin.app/)<!-- HN:42965336:end -->
#### **Friday, February 7, 2025**<!-- HN:42967989:start -->
* [42967989](https://news.social-protocols.org/stats?id=42967989) #24 27 points 2 comments -> [White House budget proposal could shatter the National Science Foundation](https://arstechnica.com/science/2025/02/white-house-budget-proposal-could-shatter-the-national-science-foundation/)<!-- HN:42967989:end -->