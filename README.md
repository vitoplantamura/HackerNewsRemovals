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

#### **Wednesday, January 29, 2025**
<!-- HN:42859781:start -->
* [42859781](https://news.social-protocols.org/stats?id=42859781) #3 12 points 2 comments -> [Paul Krugman: I Have Resigned from the Washington Post, Effective Today](https://contrarian.substack.com/p/i-have-resigned-from-the-washington)<!-- HN:42859781:end --><!-- HN:42859580:start -->
* [42859580](https://news.social-protocols.org/stats?id=42859580) #9 38 points 8 comments -> [How Google determines the names for bodies of water in Google Earth (2008)](https://publicpolicy.googleblog.com/2008/04/how-google-determines-names-for-bodies.html)<!-- HN:42859580:end --><!-- HN:42859844:start -->
* [42859844](https://news.social-protocols.org/stats?id=42859844) #25 9 points 2 comments -> [Jennifer Rubin: I Have Resigned from the Washington Post, Effective Today](https://contrarian.substack.com/p/i-have-resigned-from-the-washington)<!-- HN:42859844:end --><!-- HN:42859771:start -->
* [42859771](https://news.social-protocols.org/stats?id=42859771) #17 15 points 17 comments -> [I want my AI to get mad](https://jesseduffield.com/Angry-AI/)<!-- HN:42859771:end --><!-- HN:42860265:start -->
* [42860265](https://news.social-protocols.org/stats?id=42860265) #14 3 points 0 comments -> [Late Stage Social Capitalism](https://mebassett.info/social-capitalism)<!-- HN:42860265:end --><!-- HN:42860045:start -->
* [42860045](https://news.social-protocols.org/stats?id=42860045) #23 27 points 40 comments -> [The Americans Pledging to Buy Less–Or Even Nothing](https://www.wsj.com/personal-finance/the-americans-pledging-to-buy-lessor-even-nothing-7edeacf3)<!-- HN:42860045:end --><!-- HN:42861275:start -->
* [42861275](https://news.social-protocols.org/stats?id=42861275) #23 -> ['Miserable self-loathing poser': NeuroVigil CEO's open letter on ex-friend Musk](https://www.lonestarlive.com/news/2025/01/miserable-self-loathing-poser-elon-musks-former-friend-pens-brutal-open-letter.html)<!-- HN:42861275:end --><!-- HN:42861628:start -->
* [42861628](https://news.social-protocols.org/stats?id=42861628) #28 5 points 2 comments -> [How to run Deepseek-R1 locally for only $6000](https://twitter.com/carrigmat/status/1884244369907278106)<!-- HN:42861628:end --><!-- HN:42861708:start -->
* [42861708](https://news.social-protocols.org/stats?id=42861708) #28 4 points 0 comments -> [A Deepseek Conspiracy Theory](https://twitter.com/PalmerLuckey/status/1884351579240927677)<!-- HN:42861708:end --><!-- HN:42863884:start -->
* [42863884](https://news.social-protocols.org/stats?id=42863884) #12 9 points 3 comments -> [TU Delft PhD candidate terminated, documents bullying online [video]](https://www.youtube.com/watch?v=ChS0eT683bA)<!-- HN:42863884:end --><!-- HN:42864796:start -->
* [42864796](https://news.social-protocols.org/stats?id=42864796) #17 13 points 2 comments -> [AppleCare+ claim denied after MacBook Pro was destroyed in a car crash](https://9to5mac.com/2025/01/28/applecare-claim-denied-after-macbook-pro-was-destroyed-in-a-car-crash/)<!-- HN:42864796:end --><!-- HN:42867111:start -->
* [42867111](https://news.social-protocols.org/stats?id=42867111) #8 6 points 1 comments -> [Show HN: DeepSeek vs. ChatGPT – The Clash of the AI Generations](https://www.sigmabrowser.com/blog/deepseek-vs-chatgpt-which-is-better)<!-- HN:42867111:end --><!-- HN:42865527:start -->
* [42865527](https://news.social-protocols.org/stats?id=42865527) #2 1213 points 535 comments -> [OpenAI Furious DeepSeek Might Have Stolen All the Data OpenAI Stole from Us](https://www.404media.co/openai-furious-deepseek-might-have-stolen-all-the-data-openai-stole-from-us/)<!-- HN:42865527:end --><!-- HN:42868723:start -->
* [42868723](https://news.social-protocols.org/stats?id=42868723) #26 9 points 3 comments -> [Senator Ted Cruz is trying to block Wi-Fi hotspots for schoolchildren](https://arstechnica.com/tech-policy/2025/01/senator-ted-cruz-is-trying-to-block-wi-fi-hotspots-for-schoolchildren/)<!-- HN:42868723:end --><!-- HN:42869464:start -->
* [42869464](https://news.social-protocols.org/stats?id=42869464) #21 13 points 8 comments -> [White House rescinds federal aid freeze](https://www.cnn.com/2025/01/29/politics/white-house-rescind-federal-funding-freeze/index.html)<!-- HN:42869464:end --><!-- HN:42869700:start -->
* [42869700](https://news.social-protocols.org/stats?id=42869700) #27 21 points 3 comments -> ['Headed for technofascism': the rightwing roots of Silicon Valley](https://www.theguardian.com/technology/ng-interactive/2025/jan/29/silicon-valley-rightwing-technofascism)<!-- HN:42869700:end --><!-- HN:42867764:start -->
* [42867764](https://news.social-protocols.org/stats?id=42867764) #5 75 points 27 comments -> [How to run DeepSeek R1 locally](https://workos.com/blog/how-to-run-deepseek-r1-locally)<!-- HN:42867764:end -->
#### **Thursday, January 30, 2025**
<!-- HN:42874321:start -->
* [42874321](https://news.social-protocols.org/stats?id=42874321) #15 27 points 1 comments -> [FAA issues ground stop after plane crashes in Potomac River](https://www.cnn.com/2025/01/29/us/plane-crash-potomac-river/index.html)<!-- HN:42874321:end --><!-- HN:42874638:start -->
* [42874638](https://news.social-protocols.org/stats?id=42874638) #29 9 points 1 comments -> [Plane Crashes Near Washington DC after midair collision with helicopter](https://www.nytimes.com/live/2025/01/29/us/plane-crash-washington-dc)<!-- HN:42874638:end --><!-- HN:42874481:start -->
* [42874481](https://news.social-protocols.org/stats?id=42874481) #24 -> [Declassified CIA Guide to Sabotaging Fascism Is Suddenly Viral](https://www.404media.co/declassified-cia-guide-to-sabotaging-fascism-is-suddenly-viral/)<!-- HN:42874481:end --><!-- HN:42875428:start -->
* [42875428](https://news.social-protocols.org/stats?id=42875428) #2 6 points 3 comments -> [Billionaire Paul Graham haggles over £5 at charity event](https://twitter.com/paulg/status/1882901922686074942)<!-- HN:42875428:end --><!-- HN:42877325:start -->
* [42877325](https://news.social-protocols.org/stats?id=42877325) #12 10 points 1 comments -> [I Told You: Chaos Is Coming](https://freddiedeboer.substack.com/p/i-told-you-chaos-is-coming)<!-- HN:42877325:end --><!-- HN:42877355:start -->
* [42877355](https://news.social-protocols.org/stats?id=42877355) #2 11 points 0 comments -> [Rust in Peace](https://github.com/torvalds/linux/pull/1110)<!-- HN:42877355:end --><!-- HN:42877222:start -->
* [42877222](https://news.social-protocols.org/stats?id=42877222) #29 7 points 0 comments -> [Kansas faces one of the largest tuberculosis outbreaks in US history](https://abcnews.go.com/Health/kansas-faces-largest-tuberculosis-outbreak-us-history-health/story?id=118174420)<!-- HN:42877222:end --><!-- HN:42877440:start -->
* [42877440](https://news.social-protocols.org/stats?id=42877440) #28 7 points 2 comments -> [Germany: Angela Merkel chides own party over far-right help](https://www.dw.com/en/merkel-slams-cdu-far-right-support/a-71454687)<!-- HN:42877440:end --><!-- HN:42875985:start -->
* [42875985](https://news.social-protocols.org/stats?id=42875985) #7 79 points 33 comments -> [I built a website where you can pop confettis for no reason](https://poptheconfetti.website)<!-- HN:42875985:end --><!-- HN:42878271:start -->
* [42878271](https://news.social-protocols.org/stats?id=42878271) #27 3 points 0 comments -> [DC Mid Air Collision Reconstruction Using Public Data [video]](https://www.youtube.com/watch?v=pGDN2fEaiuo)<!-- HN:42878271:end --><!-- HN:42878722:start -->
* [42878722](https://news.social-protocols.org/stats?id=42878722) #30 4 points 1 comments -> [IBM seeks $3.5B savings for 2025; the next year all about AI, AI, and more AI](https://www.theregister.com/2025/01/30/ibm_q4_2024/)<!-- HN:42878722:end --><!-- HN:42879267:start -->
* [42879267](https://news.social-protocols.org/stats?id=42879267) #29 5 points 0 comments -> [Asteroid Bennu Is Packed with Life's Building Blocks, New Studies Confirm](https://www.scientificamerican.com/article/nasas-latest-asteroid-sample-hints-at-lifes-extraterrestrial-origins/)<!-- HN:42879267:end --><!-- HN:42880663:start -->
* [42880663](https://news.social-protocols.org/stats?id=42880663) #10 23 points 35 comments -> [Unintended workplace safety consequences of minimum wages](https://www.sciencedirect.com/science/article/abs/pii/S004727272400183X)<!-- HN:42880663:end --><!-- HN:42831621:start -->
* [42831621](https://news.social-protocols.org/stats?id=42831621) #30 36 points 41 comments -> [Digital Reality, Digital Shock: Growing Up at the Dawn of Cyberspace](https://www.chrbutler.com/digital-reality-digital-shock)<!-- HN:42831621:end --><!-- HN:42882593:start -->
* [42882593](https://news.social-protocols.org/stats?id=42882593) #29 4 points 0 comments -> [Logitech's peel-and-stick radar sensors](https://www.theverge.com/news/24350437/logitech-spot-mmwave-radar-presence-corporate-office-real-estate)<!-- HN:42882593:end -->
#### **Friday, January 31, 2025**
<!-- HN:42884289:start -->
* [42884289](https://news.social-protocols.org/stats?id=42884289) #26 4 points 0 comments -> [US spent millions on STD prevention in Gaza. But it was a province in Mozambique](https://www.middleeasteye.net/news/us-spent-millions-std-prevention-gaza-it-was-province-mozambique)<!-- HN:42884289:end --><!-- HN:42884599:start -->
* [42884599](https://news.social-protocols.org/stats?id=42884599) #23 24 points 34 comments -> [Apple iPhone sales dip despite AI rollout](https://www.bbc.co.uk/news/articles/cn57l2nreglo)<!-- HN:42884599:end --><!-- HN:42884639:start -->
* [42884639](https://news.social-protocols.org/stats?id=42884639) #27 5 points 0 comments -> [How one YouTuber is trying to poison the AI bots stealing her content](https://arstechnica.com/ai/2025/01/how-one-youtuber-is-trying-to-poison-the-ai-bots-stealing-her-content/)<!-- HN:42884639:end --><!-- HN:42884056:start -->
* [42884056](https://news.social-protocols.org/stats?id=42884056) #6 20 points 3 comments -> [Show HN: 1M+ animated GPU sprites in JavaScript](https://phaser.io/news/2025/01/phaser-v4-beta-5-released)<!-- HN:42884056:end --><!-- HN:42884117:start -->
* [42884117](https://news.social-protocols.org/stats?id=42884117) #25 28 points 20 comments -> [65% of all ski resorts in the US have closed since 1960s (2022)](https://www.mdpi.com/2073-445X/11/4/494)<!-- HN:42884117:end --><!-- HN:42829287:start -->
* [42829287](https://news.social-protocols.org/stats?id=42829287) #15 6 points 5 comments -> [Show HN: Practice a second language by solving image-based puzzles](https://alkutshina.netlify.app/)<!-- HN:42829287:end --><!-- HN:42884803:start -->
* [42884803](https://news.social-protocols.org/stats?id=42884803) #11 57 points 2 comments -> [Google Pixel 4a update to "improve stability" of the battery cuts life in half](https://liliputing.com/google-pixel-4a-update-to-improve-stability-of-the-battery-cuts-battery-life-in-half-for-some-users/)<!-- HN:42884803:end --><!-- HN:42885412:start -->
* [42885412](https://news.social-protocols.org/stats?id=42885412) #7 8 points 0 comments -> [React's declarative model isn't perfect](https://blog.bennett.ink/reacts-model-isn-t-perfect-f198296f4db2)<!-- HN:42885412:end --><!-- HN:42885577:start -->
* [42885577](https://news.social-protocols.org/stats?id=42885577) #30 6 points 2 comments -> [Most "Investing" Is Just Speculation](https://www.vincentschmalbach.com/most-investing-is-just-speculation/)<!-- HN:42885577:end --><!-- HN:42886790:start -->
* [42886790](https://news.social-protocols.org/stats?id=42886790) #7 7 points 5 comments -> [AI and Palantir are reshaping how we fight crime](https://www.thetimes.com/comment/columnists/article/ai-there-youre-nicked-tech-is-reshaping-how-we-fight-crime-jb9bv7qh3)<!-- HN:42886790:end --><!-- HN:42886979:start -->
* [42886979](https://news.social-protocols.org/stats?id=42886979) #7 9 points 0 comments -> [Why I'm Boycotting the American Quilter's Society](https://www.iothealien.com/blog/censorshipintheaqs)<!-- HN:42886979:end --><!-- HN:42887070:start -->
* [42887070](https://news.social-protocols.org/stats?id=42887070) #24 24 points 41 comments -> [Five years of Brexit reshaped Britain](https://www.ft.com/content/4d2d78b0-eedd-485c-9a9c-4e41baf46146)<!-- HN:42887070:end --><!-- HN:42887651:start -->
* [42887651](https://news.social-protocols.org/stats?id=42887651) #18 6 points 3 comments -> [KVM Enhancements Within the Linux 6.14 Kernel](https://www.phoronix.com/news/Linux-6.14-KVM)<!-- HN:42887651:end --><!-- HN:42887839:start -->
* [42887839](https://news.social-protocols.org/stats?id=42887839) #27 3 points 6 comments -> [New CVS App Lets Customers Unlock Cabinets to Pick Up Products](https://www.nytimes.com/2025/01/28/business/cvs-app-pharmacy-locked-cabinets.html)<!-- HN:42887839:end --><!-- HN:42888138:start -->
* [42888138](https://news.social-protocols.org/stats?id=42888138) #14 9 points 1 comments -> [NYPD records longest no-shooting streak in 30 Years](https://abc7ny.com/post/2-overnight-shootings-brooklyn-bronx-end-nycs-5-day-no-shooting-streak-minutes-was-announced/15832500/)<!-- HN:42888138:end --><!-- HN:42888773:start -->
* [42888773](https://news.social-protocols.org/stats?id=42888773) #18 4 points 0 comments -> [A brief history of counting machines (2023)](https://lcamtuf.substack.com/p/a-brief-history-of-counting-stuff)<!-- HN:42888773:end --><!-- HN:42888967:start -->
* [42888967](https://news.social-protocols.org/stats?id=42888967) #9 12 points 6 comments -> [Show HN: Small LLM with Large Power](https://github.com/KarthikDevalla/Maximum-218M)<!-- HN:42888967:end --><!-- HN:42847987:start -->
* [42847987](https://news.social-protocols.org/stats?id=42847987) #28 25 points 3 comments -> [How do you comfort a JavaScript bug?](https://www.codepuns.com/post/771840982014640128/how-do-you-comfort-a-javascript-bug)<!-- HN:42847987:end --><!-- HN:42892052:start -->
* [42892052](https://news.social-protocols.org/stats?id=42892052) #16 4 points 0 comments -> [How to Stage a Coup](https://www.statecraft.pub/p/how-to-commit-a-coup)<!-- HN:42892052:end --><!-- HN:42893023:start -->
* [42893023](https://news.social-protocols.org/stats?id=42893023) #5 19 points 8 comments -> [.gov Sites Are Offline](http://faa.gov/)<!-- HN:42893023:end -->
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
* [42940124](https://news.social-protocols.org/stats?id=42940124) #6 9 points 0 comments -> [ChatGPT in Shambles](https://garymarcus.substack.com/p/chatgpt-in-shambles)<!-- HN:42940124:end --><!-- HN:42909068:start -->
* [42909068](https://news.social-protocols.org/stats?id=42909068) #12 22 points 40 comments -> [Wolves explain America's urban-rural divide](https://thehustle.co/originals/how-wolves-explain-americas-urban-rural-divide)<!-- HN:42909068:end -->