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

#### **Monday, November 11, 2024**<!-- HN:42104374:start -->
* [42104374](https://news.social-protocols.org/stats?id=42104374) #2 14 points 0 comments -> [The mirror of fascism in big tech](https://deadsimpletech.com/blog/fascism_mirror)<!-- HN:42104374:end --><!-- HN:42103910:start -->
* [42103910](https://news.social-protocols.org/stats?id=42103910) #7 15 points 15 comments -> [Who Would Support Deploying the Military to Domestic Protests?](https://www.lawfaremedia.org/article/who-would-support-deploying-the-military-to-domestic-protests)<!-- HN:42103910:end --><!-- HN:42105398:start -->
* [42105398](https://news.social-protocols.org/stats?id=42105398) #27 11 points 0 comments -> [Australian scientists thought to be on the verge of curing paralysis](https://www.9news.com.au/national/spinal-cord-research-trials-using-nerve-cells-from-nose-to-treat-paralysis-queensland-griffith-university/a90c494b-1042-4ab3-b631-67e9d565ceb2)<!-- HN:42105398:end --><!-- HN:42104762:start -->
* [42104762](https://news.social-protocols.org/stats?id=42104762) #12 211 points 80 comments -> [Apple threatened workers over their talk about pay and remote work, feds charge](https://www.mercurynews.com/2024/11/06/apple-threatened-workers-over-talk-about-pay-remote-work-feds-charge/)<!-- HN:42104762:end --><!-- HN:42100876:start -->
* [42100876](https://news.social-protocols.org/stats?id=42100876) #15 220 points 64 comments -> [JVM Anatomy Quarks](https://shipilev.net/jvm/anatomy-quarks/)<!-- HN:42100876:end --><!-- HN:42103761:start -->
* [42103761](https://news.social-protocols.org/stats?id=42103761) #18 136 points 188 comments -> [Standing Desk Might Be as Bad as Sitting All Day](https://www.sciencealert.com/your-standing-desk-might-actually-be-as-bad-as-sitting-all-day)<!-- HN:42103761:end --><!-- HN:42105508:start -->
* [42105508](https://news.social-protocols.org/stats?id=42105508) #18 40 points 15 comments -> [Mattel apologises after Wicked movie dolls link to porn site on packaging](https://www.theguardian.com/film/2024/nov/11/mattel-apologises-after-mistakenly-linking-to-porn-website-on-wicked-dolls)<!-- HN:42105508:end --><!-- HN:42105835:start -->
* [42105835](https://news.social-protocols.org/stats?id=42105835) #19 23 points 4 comments -> [Inside M4 chips: P cores](https://eclecticlight.co/2024/11/11/inside-m4-chips-p-cores/)<!-- HN:42105835:end --><!-- HN:42106724:start -->
* [42106724](https://news.social-protocols.org/stats?id=42106724) #18 -> ["The Hatpin Peril" Terrorized Men Who Couldn't Handle the 20th-Century Woman](https://www.smithsonianmag.com/history/hatpin-peril-terrorized-men-who-couldnt-handle-20th-century-woman-180951219/)<!-- HN:42106724:end --><!-- HN:42106504:start -->
* [42106504](https://news.social-protocols.org/stats?id=42106504) #25 7 points 0 comments -> [A sit-down with Ubuntu founder Mark 'SABDFL' Shuttleworth](https://www.theregister.com/2024/11/11/mark_shuttleworth_ubuntu_interview/)<!-- HN:42106504:end --><!-- HN:42107120:start -->
* [42107120](https://news.social-protocols.org/stats?id=42107120) #13 20 points 8 comments -> [Memecoins Are the Point](http://jpkoning.blogspot.com/2024/10/memecoins-are-point.html)<!-- HN:42107120:end --><!-- HN:42107157:start -->
* [42107157](https://news.social-protocols.org/stats?id=42107157) #5 67 points 2 comments -> [AI protein-prediction tool AlphaFold3 is now open source](https://www.nature.com/articles/d41586-024-03708-4)<!-- HN:42107157:end --><!-- HN:42107966:start -->
* [42107966](https://news.social-protocols.org/stats?id=42107966) #25 3 points 0 comments -> [Traditional Japanese Salted Aged Salmon Recipe for 1,000 Years [video]](https://www.youtube.com/watch?v=DLaaqv1Tykg)<!-- HN:42107966:end --><!-- HN:42108247:start -->
* [42108247](https://news.social-protocols.org/stats?id=42108247) #24 4 points 0 comments -> [Tariffs Won't Work, Just as McKinley's Didn't](https://www.bloomberg.com/opinion/articles/2024-11-08/trump-s-tariffs-won-t-work-just-as-mckinley-s-didn-t)<!-- HN:42108247:end --><!-- HN:42030233:start -->
* [42030233](https://news.social-protocols.org/stats?id=42030233) #18 12 points 1 comments -> [Data movement bottlenecks to large-scale model training: Scaling past 1e28 FLOP](https://epochai.org/blog/data-movement-bottlenecks-scaling-past-1e28-flop)<!-- HN:42030233:end --><!-- HN:42109712:start -->
* [42109712](https://news.social-protocols.org/stats?id=42109712) #24 13 points 4 comments -> [LICENSE.TXT [video]](https://www.youtube.com/watch?v=CUleKnUUaGI)<!-- HN:42109712:end --><!-- HN:42110357:start -->
* [42110357](https://news.social-protocols.org/stats?id=42110357) #29 6 points 0 comments -> [Foundry worker puts wet scrap metal into furnace](https://www.youtube.com/watch?v=oWSHEC1N770)<!-- HN:42110357:end -->
#### **Tuesday, November 12, 2024**
<!-- HN:42112154:start -->
* [42112154](https://news.social-protocols.org/stats?id=42112154) #8 2 points 0 comments -> [Racketeer Influenced and Corrupt Organizations Act](https://en.wikipedia.org/wiki/Racketeer_Influenced_and_Corrupt_Organizations_Act)<!-- HN:42112154:end --><!-- HN:42073712:start -->
* [42073712](https://news.social-protocols.org/stats?id=42073712) #22 7 points 0 comments -> [Harnessing Vision for Computation (2008) [pdf]](https://www.changizi.com/uploads/8/3/4/4/83445868/viscomp.pdf)<!-- HN:42073712:end --><!-- HN:42112945:start -->
* [42112945](https://news.social-protocols.org/stats?id=42112945) #10 16 points 11 comments -> [Der Spiegel Proclaims the End of the West](https://www.spiegel.de/international/world/donald-trump-and-the-new-world-order-the-end-of-the-west-a-b71fa1bd-6147-47a4-8738-5c17eff44a55)<!-- HN:42112945:end --><!-- HN:42111597:start -->
* [42111597](https://news.social-protocols.org/stats?id=42111597) #15 78 points 45 comments -> [Git and Jujutsu: In Miniature](https://lottia.net/notes/0013-git-jujutsu-miniature.html)<!-- HN:42111597:end --><!-- HN:42112005:start -->
* [42112005](https://news.social-protocols.org/stats?id=42112005) #22 166 points 17 comments -> [This morning for no obvious reason, I remembered the Fuel Rats](https://hachyderm.io/@danderson/113465421567555186)<!-- HN:42112005:end --><!-- HN:42032451:start -->
* [42032451](https://news.social-protocols.org/stats?id=42032451) #17 116 points 32 comments -> [I2P Anonymous Network](https://geti2p.net/en/)<!-- HN:42032451:end --><!-- HN:42113398:start -->
* [42113398](https://news.social-protocols.org/stats?id=42113398) #28 25 points 1 comments -> [Nearly 70% of Gaza war dead are women and children, UN says](https://www.bbc.com/news/articles/cn5wel11pgdo)<!-- HN:42113398:end --><!-- HN:42113296:start -->
* [42113296](https://news.social-protocols.org/stats?id=42113296) #21 39 points 4 comments -> [I Will Always Be Angry About Software Engineering](https://ludic.mataroa.blog/blog/why-i-will-always-be-angry-about-software-engineering/)<!-- HN:42113296:end --><!-- HN:42075115:start -->
* [42075115](https://news.social-protocols.org/stats?id=42075115) #10 42 points 11 comments -> [FLUX1.1 [Pro] Ultra and Raw Modes](https://blackforestlabs.ai/flux-1-1-ultra/)<!-- HN:42075115:end --><!-- HN:42115578:start -->
* [42115578](https://news.social-protocols.org/stats?id=42115578) #19 37 points 40 comments -> [Genetic Discrimination Is Coming for Us All](https://www.theatlantic.com/health/archive/2024/11/dna-genetic-discrimination-insurance-privacy/680626/)<!-- HN:42115578:end --><!-- HN:42116220:start -->
* [42116220](https://news.social-protocols.org/stats?id=42116220) #27 3 points 1 comments -> [Solanine](https://en.wikipedia.org/wiki/Solanine)<!-- HN:42116220:end --><!-- HN:42116967:start -->
* [42116967](https://news.social-protocols.org/stats?id=42116967) #2 76 points 31 comments -> [US Senate to Revive Software Patents with PERA Bill Vote on Thursday](https://slashdot.org/submission/17329829/us-senate-to-revive-software-patents-with-pera-bill-vote-on-thursday)<!-- HN:42116967:end --><!-- HN:42081729:start -->
* [42081729](https://news.social-protocols.org/stats?id=42081729) #17 5 points 0 comments -> [Method for the determination of the luminance of two-photon vision stimuli](https://opg.optica.org/boe/fulltext.cfm?uri=boe-15-10-5818&id=559565)<!-- HN:42081729:end --><!-- HN:42072293:start -->
* [42072293](https://news.social-protocols.org/stats?id=42072293) #26 17 points 3 comments -> [Product Quality Through Change Management](https://www.ravenbrook.com/doc/1999/05/20/pqtcm/)<!-- HN:42072293:end --><!-- HN:42115453:start -->
* [42115453](https://news.social-protocols.org/stats?id=42115453) #23 7 points 19 comments -> [Show HN: We built the simplest Online Unit Converter for everyday use](https://www.betaconvert.com)<!-- HN:42115453:end --><!-- HN:42116936:start -->
* [42116936](https://news.social-protocols.org/stats?id=42116936) #29 11 points 3 comments -> [North Korean hackers create Flutter apps to bypass macOS security](https://www.bleepingcomputer.com/news/security/north-korean-hackers-create-flutter-apps-to-bypass-macos-security/)<!-- HN:42116936:end --><!-- HN:42081010:start -->
* [42081010](https://news.social-protocols.org/stats?id=42081010) #14 24 points 40 comments -> [How do you juggle WFH with a baby?](https://subscribe.marissagoldberg.com/posts/how-do-you-juggle-wfh-with-a-baby)<!-- HN:42081010:end --><!-- HN:42121122:start -->
* [42121122](https://news.social-protocols.org/stats?id=42121122) #3 17 points 6 comments -> [Nutrient Density and Other Stupid Magic Words](https://www.exfatloss.com/p/nutrient-density-and-other-stupid)<!-- HN:42121122:end --><!-- HN:42119733:start -->
* [42119733](https://news.social-protocols.org/stats?id=42119733) #25 30 points 25 comments -> [Review: The fastest of the M4 MacBook Pros might be the least interesting one](https://arstechnica.com/apple/2024/11/review-the-fastest-of-the-m4-macbook-pros-might-be-the-least-interesting-one/)<!-- HN:42119733:end -->
#### **Wednesday, November 13, 2024**
<!-- HN:42122113:start -->
* [42122113](https://news.social-protocols.org/stats?id=42122113) #29 9 points 1 comments -> [Why Boeing Killed DEI](https://www.city-journal.org/article/why-boeing-killed-dei)<!-- HN:42122113:end --><!-- HN:42123070:start -->
* [42123070](https://news.social-protocols.org/stats?id=42123070) #24 48 points 22 comments -> [Cock.li Is on Red Alert](https://cock.li/index.asc.txt)<!-- HN:42123070:end --><!-- HN:42122434:start -->
* [42122434](https://news.social-protocols.org/stats?id=42122434) #16 130 points 57 comments -> [Micron Launches First 60TB PCIe Gen5 SSD with 12GB/S Read Speeds](https://www.micron.com/products/storage/ssd/data-center-ssd/6550-ion)<!-- HN:42122434:end --><!-- HN:42120311:start -->
* [42120311](https://news.social-protocols.org/stats?id=42120311) #17 522 points 519 comments -> [M4 Mac mini's efficiency is incredible](https://www.jeffgeerling.com/blog/2024/m4-mac-minis-efficiency-incredible)<!-- HN:42120311:end --><!-- HN:42119141:start -->
* [42119141](https://news.social-protocols.org/stats?id=42119141) #14 105 points 34 comments -> [Voice acting in Space Quest V](https://github.com/cdb-boop/Space-Quest-V-Voice-Acting-Mod)<!-- HN:42119141:end --><!-- HN:42060081:start -->
* [42060081](https://news.social-protocols.org/stats?id=42060081) #14 20 points 4 comments -> [The Product-Market Fit Scale](https://iwantproductmarketfit.substack.com/p/the-product-market-fit-scale)<!-- HN:42060081:end --><!-- HN:42122740:start -->
* [42122740](https://news.social-protocols.org/stats?id=42122740) #28 36 points 1 comments -> [Backblaze Drive Stats for Q3 2024](https://www.backblaze.com/blog/backblaze-drive-stats-for-q3-2024/)<!-- HN:42122740:end --><!-- HN:42125275:start -->
* [42125275](https://news.social-protocols.org/stats?id=42125275) #23 5 points 2 comments -> [Forth May Be the Answer](https://forth.org/lost-at-c.html)<!-- HN:42125275:end --><!-- HN:42124409:start -->
* [42124409](https://news.social-protocols.org/stats?id=42124409) #24 14 points 4 comments -> [OpenAI and others seek new path to smarter AI as current methods hit limitations](https://www.reuters.com/technology/artificial-intelligence/openai-rivals-seek-new-path-smarter-ai-current-methods-hit-limitations-2024-11-11/)<!-- HN:42124409:end --><!-- HN:42075663:start -->
* [42075663](https://news.social-protocols.org/stats?id=42075663) #16 9 points 0 comments -> [A comic uses fluid dynamics to explain how groups of people move](https://nautil.us/bustling-through-the-physics-of-crowds-1077366/)<!-- HN:42075663:end --><!-- HN:42125720:start -->
* [42125720](https://news.social-protocols.org/stats?id=42125720) #27 3 points 0 comments -> [Airlines Hate 'Skiplagging.' Meet the Man Who Helps Travelers Pull It Off](https://www.nytimes.com/2024/11/12/travel/skiplagged-flights-hacks.html)<!-- HN:42125720:end --><!-- HN:42121548:start -->
* [42121548](https://news.social-protocols.org/stats?id=42121548) #22 86 points 129 comments -> [Manjaro is experimenting with **opt-out telemetry](https://discuss.privacyguides.net/t/manjaro-is-experimenting-with-opt-out-telemetry/22305)<!-- HN:42121548:end --><!-- HN:42093090:start -->
* [42093090](https://news.social-protocols.org/stats?id=42093090) #24 10 points 0 comments -> [How a neuron learns](https://qtnx.ai/posts/how_neuron_learns/)<!-- HN:42093090:end --><!-- HN:42126384:start -->
* [42126384](https://news.social-protocols.org/stats?id=42126384) #29 8 points 0 comments -> [US Congress to hold second hearing on UFOs in attempt to 'pull back curtain'](https://www.theguardian.com/us-news/2024/nov/13/house-ufo-hearing)<!-- HN:42126384:end --><!-- HN:42127161:start -->
* [42127161](https://news.social-protocols.org/stats?id=42127161) #28 21 points 22 comments -> [Journalism's fight for survival in a postliterate democracy](https://mattdpearce.substack.com/p/journalisms-fight-for-survival-in)<!-- HN:42127161:end --><!-- HN:42125989:start -->
* [42125989](https://news.social-protocols.org/stats?id=42125989) #21 6 points 1 comments -> [Show HN: 8arms – Marketing Campaign Generation](https://www.8arms.ai/)<!-- HN:42125989:end --><!-- HN:42127304:start -->
* [42127304](https://news.social-protocols.org/stats?id=42127304) #14 25 points 41 comments -> [Just Eat Is Selling Grubhub to Marc Lore's Wonder for $650M](https://www.theverge.com/2024/11/13/24295454/grubhub-wonder-acquisition-just-eat-food-delivery-app)<!-- HN:42127304:end --><!-- HN:42127877:start -->
* [42127877](https://news.social-protocols.org/stats?id=42127877) #13 9 points 2 comments -> [Codeium launches Windsurf – the first agentic IDE](https://codeium.com/blog/windsurf-launch)<!-- HN:42127877:end --><!-- HN:42129080:start -->
* [42129080](https://news.social-protocols.org/stats?id=42129080) #8 5 points 1 comments -> [Why Sabine Hossenfelder Is Just Wrong](https://www.math.columbia.edu/~woit/wordpress/?p=14232)<!-- HN:42129080:end --><!-- HN:42129791:start -->
* [42129791](https://news.social-protocols.org/stats?id=42129791) #17 33 points 23 comments -> [FBI seizes Polymarket CEO's phone, electronics](https://nypost.com/2024/11/13/business/fbi-seizes-polymarket-ceos-phone-electronics-after-betting-platform-predicts-trump-win-source/)<!-- HN:42129791:end --><!-- HN:42129779:start -->
* [42129779](https://news.social-protocols.org/stats?id=42129779) #11 8 points 3 comments -> [Show HN: I Built Tinder, but for Entrepreneurs and Investors](https://www.aloangels.me/)<!-- HN:42129779:end -->
#### **Thursday, November 14, 2024**<!-- HN:42133026:start -->
* [42133026](https://news.social-protocols.org/stats?id=42133026) #21 -> [14yo suicides after Santa Clara schoolmates bully him about being homeless](https://www.ktvu.com/news/14-year-old-dies-suicide-after-santa-clara-schoolmates-bully-him-about-being-homeless-father)<!-- HN:42133026:end --><!-- HN:42133624:start -->
* [42133624](https://news.social-protocols.org/stats?id=42133624) #13 145 points 41 comments -> [GOG's Preservation Program Is the DRM-Free Store Refocusing on the Classics](https://arstechnica.com/gaming/2024/11/gogs-preservation-program-is-the-drm-free-store-refocusing-on-the-classics/)<!-- HN:42133624:end --><!-- HN:42133980:start -->
* [42133980](https://news.social-protocols.org/stats?id=42133980) #16 80 points 33 comments -> [WebVM 2.0: A complete Linux Desktop Environment in the browser via WebAssembly](https://labs.leaningtech.com/blog/webvm-20)<!-- HN:42133980:end --><!-- HN:42108145:start -->
* [42108145](https://news.social-protocols.org/stats?id=42108145) #20 166 points 47 comments -> [New elliptic curve breaks 18-year-old record](https://www.quantamagazine.org/new-elliptic-curve-breaks-18-year-old-record-20241111/)<!-- HN:42108145:end --><!-- HN:42128438:start -->
* [42128438](https://news.social-protocols.org/stats?id=42128438) #15 170 points 21 comments -> [The Beginner's Guide to Visual Prompt Injections](https://www.lakera.ai/blog/visual-prompt-injections)<!-- HN:42128438:end --><!-- HN:42135277:start -->
* [42135277](https://news.social-protocols.org/stats?id=42135277) #25 7 points 6 comments -> [Amazon Haul–a broad selection of products $20 or less](https://www.aboutamazon.com/news/retail/affordable-products-amazon-20-dollars-and-under)<!-- HN:42135277:end --><!-- HN:42110664:start -->
* [42110664](https://news.social-protocols.org/stats?id=42110664) #25 67 points 5 comments -> [Debian Junior Desktop live image](https://get.debian.org/images/weekly-live-builds/amd64/iso-hybrid/)<!-- HN:42110664:end --><!-- HN:42086289:start -->
* [42086289](https://news.social-protocols.org/stats?id=42086289) #15 63 points 65 comments -> [Choose Boring Technology and LLMs](https://www.maragu.dev/blog/choose-boring-technology-and-llms)<!-- HN:42086289:end --><!-- HN:42135358:start -->
* [42135358](https://news.social-protocols.org/stats?id=42135358) #26 12 points 9 comments -> [I Regret Ever Open Sourcing Java – Jill Malony Ratkevic](https://m.facebook.com/login.php?next=https%3A%2F%2Fm.facebook.com%2Fstory.php%3Fstory_fbid%3D10159934131461514%26id%3D520846513&refsrc=deprecated&_rdr)<!-- HN:42135358:end --><!-- HN:42094889:start -->
* [42094889](https://news.social-protocols.org/stats?id=42094889) #26 142 points 30 comments -> [The number given as % CPU in Activity Monitor](https://eclecticlight.co/2024/11/08/why-cpu-in-activity-monitor-isnt-what-you-think/)<!-- HN:42094889:end --><!-- HN:42135531:start -->
* [42135531](https://news.social-protocols.org/stats?id=42135531) #28 5 points 1 comments -> [Hosting a hobby project without credit card and How I did it](https://smileplease.mataroa.blog/blog/hosting-a-hobby-project-without-card/)<!-- HN:42135531:end --><!-- HN:42134366:start -->
* [42134366](https://news.social-protocols.org/stats?id=42134366) #16 59 points 122 comments -> [Async Await Is the Worst Thing to Happen to Programming](https://andrewzuo.com/async-await-is-the-worst-thing-to-happen-to-programming-9b8f5150ba74)<!-- HN:42134366:end --><!-- HN:42136095:start -->
* [42136095](https://news.social-protocols.org/stats?id=42136095) #18 10 points 2 comments -> [FBI raids home and seizes phone of Polymarket founder](https://www.theguardian.com/technology/2024/nov/13/fbi-raid-polymarket-founder-trump-election)<!-- HN:42136095:end --><!-- HN:42136210:start -->
* [42136210](https://news.social-protocols.org/stats?id=42136210) #21 4 points 0 comments -> [How the Ivy League Broke America](https://www.theatlantic.com/magazine/archive/2024/12/meritocracy-college-admissions-social-economic-segregation/680392/)<!-- HN:42136210:end --><!-- HN:42136705:start -->
* [42136705](https://news.social-protocols.org/stats?id=42136705) #3 15 points 1 comments -> [Not Satire: The Onion Acquires Infowars](https://www.status.news/p/not-satire-the-onion-acquires-infowars)<!-- HN:42136705:end --><!-- HN:42136327:start -->
* [42136327](https://news.social-protocols.org/stats?id=42136327) #10 105 points 34 comments -> [The Onion wins Alex Jones' Infowars in bankruptcy auction](https://www.nbcnews.com/news/us-news/onion-wins-alex-jones-infowars-bankruptcy-auction-rcna179936)<!-- HN:42136327:end --><!-- HN:42138384:start -->
* [42138384](https://news.social-protocols.org/stats?id=42138384) #12 4 points 4 comments -> [How AI is beating VCs in their own game](https://arxiv.org/abs/2411.08257)<!-- HN:42138384:end --><!-- HN:42138976:start -->
* [42138976](https://news.social-protocols.org/stats?id=42138976) #19 24 points 10 comments -> [Mark Zuckerberg Wants to Feed You More AI Slop](https://www.bloomberg.com/opinion/articles/2024-11-04/mark-zuckerberg-wants-to-feed-you-more-ai-slop-on-facebook)<!-- HN:42138976:end --><!-- HN:42138319:start -->
* [42138319](https://news.social-protocols.org/stats?id=42138319) #7 93 points 1 comments -> [AI Progress Stalls as OpenAI, Google and Anthropic Hit Roadblocks](https://www.nasdaq.com/articles/ai-progress-stalls-openai-google-and-anthropic-hit-roadblocks)<!-- HN:42138319:end --><!-- HN:42140102:start -->
* [42140102](https://news.social-protocols.org/stats?id=42140102) #6 9 points 0 comments -> [Show HN: 16 year olds building an Integrated Writing Environment using AI](https://factful.io/)<!-- HN:42140102:end --><!-- HN:42139989:start -->
* [42139989](https://news.social-protocols.org/stats?id=42139989) #21 20 points 12 comments -> [Prompt Injecting Your Way to Shell: OpenAI's Containerized ChatGPT Environment](https://0din.ai/blog/prompt-injecting-your-way-to-shell-openai-s-containerized-chatgpt-environment)<!-- HN:42139989:end --><!-- HN:42140664:start -->
* [42140664](https://news.social-protocols.org/stats?id=42140664) #6 8 points 12 comments -> [Valuing Humans in the Age of Superintelligence: HumaneRank](https://roadtoartificia.com/p/valuing-humans-in-the-age-of-superintelligence-humanerank)<!-- HN:42140664:end -->
#### **Friday, November 15, 2024**<!-- HN:42144541:start -->
* [42144541](https://news.social-protocols.org/stats?id=42144541) #17 9 points 2 comments -> [Reducing the cost of a single Google Cloud Dataflow Pipeline by Over 60%](https://blog.allegro.tech/2024/06/cost-optimization-data-pipeline-gcp.html)<!-- HN:42144541:end --><!-- HN:42144873:start -->
* [42144873](https://news.social-protocols.org/stats?id=42144873) #9 8 points 0 comments -> [Terence Tao: Solving problems by abstracting away highly relevant information](https://mathstodon.xyz/@tao/113482950431855749)<!-- HN:42144873:end --><!-- HN:42145643:start -->
* [42145643](https://news.social-protocols.org/stats?id=42145643) #8 16 points 9 comments -> [Arrested and Charged Because My 11yo Was Walking 1 Mile from Home](https://www.businessinsider.com/mom-arrested-after-tween-walked-mile-town-alone-2024-11)<!-- HN:42145643:end --><!-- HN:42104714:start -->
* [42104714](https://news.social-protocols.org/stats?id=42104714) #9 47 points 13 comments -> [Assembly Optimization Tips by Mark Larson](https://masm32.com/masmcode/marklarson/index.htm)<!-- HN:42104714:end --><!-- HN:42102531:start -->
* [42102531](https://news.social-protocols.org/stats?id=42102531) #18 3 points 1 comments -> [New, Original, Multi-Purpose Programming Language](https://github.com/masonmarker/msnscript2)<!-- HN:42102531:end --><!-- HN:42143265:start -->
* [42143265](https://news.social-protocols.org/stats?id=42143265) #10 256 points 188 comments -> [New Apple security feature reboots iPhones after 3 days, researchers confirm](https://techcrunch.com/2024/11/14/new-apple-security-feature-reboots-iphones-after-3-days-researchers-confirm/)<!-- HN:42143265:end --><!-- HN:42137527:start -->
* [42137527](https://news.social-protocols.org/stats?id=42137527) #14 437 points 214 comments -> [AI makes tech debt more expensive](https://www.gauge.sh/blog/ai-makes-tech-debt-more-expensive)<!-- HN:42137527:end --><!-- HN:42142900:start -->
* [42142900](https://news.social-protocols.org/stats?id=42142900) #27 18 points 1 comments -> [Attestations: A new generation of signatures on PyPI](https://blog.trailofbits.com/2024/11/14/attestations-a-new-generation-of-signatures-on-pypi/)<!-- HN:42142900:end --><!-- HN:42139044:start -->
* [42139044](https://news.social-protocols.org/stats?id=42139044) #29 256 points 74 comments -> [Red Hat to contribute container tech (Podman, bootc, ComposeFS...) to CNCF](https://www.redhat.com/en/blog/red-hat-contribute-comprehensive-container-tools-collection-cloud-native-computing-foundation)<!-- HN:42139044:end --><!-- HN:42138115:start -->
* [42138115](https://news.social-protocols.org/stats?id=42138115) #10 644 points 235 comments -> [Daisy, an AI granny wasting scammers' time](https://news.virginmediao2.co.uk/o2-unveils-daisy-the-ai-granny-wasting-scammers-time/)<!-- HN:42138115:end --><!-- HN:42145612:start -->
* [42145612](https://news.social-protocols.org/stats?id=42145612) #8 8 points 0 comments -> [Tesla pushes update for highway driving, but only for newer vehicles](https://electrek.co/2024/11/14/tesla-pushes-end-to-end-neural-networks-for-highway-driving-but-only-for-newer-vehicles/)<!-- HN:42145612:end --><!-- HN:42095263:start -->
* [42095263](https://news.social-protocols.org/stats?id=42095263) #12 100 points 25 comments -> [My simple knowledge management and time tracking system](https://henrikwarne.com/2024/11/09/my-simple-knowledge-management-and-time-tracking-system/)<!-- HN:42095263:end --><!-- HN:42145047:start -->
* [42145047](https://news.social-protocols.org/stats?id=42145047) #24 12 points 40 comments -> [Europe's flying taxi dreams falter as cash runs short](https://www.bbc.com/news/articles/c33em6jrx1go)<!-- HN:42145047:end --><!-- HN:42146042:start -->
* [42146042](https://news.social-protocols.org/stats?id=42146042) #21 6 points 1 comments -> [Amazon S3 now supports up to 1M buckets per AWS account](https://aws.amazon.com/about-aws/whats-new/2024/11/amazon-s3-up-1-million-buckets-per-aws-account/)<!-- HN:42146042:end --><!-- HN:42145222:start -->
* [42145222](https://news.social-protocols.org/stats?id=42145222) #18 4 points 2 comments -> [Packages, Not Programs](https://bitfieldconsulting.com/posts/packages)<!-- HN:42145222:end --><!-- HN:42145704:start -->
* [42145704](https://news.social-protocols.org/stats?id=42145704) #16 13 points 8 comments -> [FlutterFlash - Ship your next Flutter app, at lightning speed](https://www.flutterfla.sh/)<!-- HN:42145704:end --><!-- HN:42146188:start -->
* [42146188](https://news.social-protocols.org/stats?id=42146188) #28 12 points 40 comments -> [Congress hears testimony on aliens the government hides](https://www.theregister.com/2024/11/14/congress_uap_hearings/)<!-- HN:42146188:end --><!-- HN:42148171:start -->
* [42148171](https://news.social-protocols.org/stats?id=42148171) #23 15 points 0 comments -> [Carl Sagan testifying before Congress in 1985 on climate change [video]](https://www.youtube.com/watch?v=Wp-WiNXH6hI)<!-- HN:42148171:end --><!-- HN:42148789:start -->
* [42148789](https://news.social-protocols.org/stats?id=42148789) #18 3 points 0 comments -> [Egg Consumption and 4-Year Change in Cognitive Function in Older Men and Women](https://www.mdpi.com/2072-6643/16/16/2765)<!-- HN:42148789:end --><!-- HN:42148817:start -->
* [42148817](https://news.social-protocols.org/stats?id=42148817) #19 6 points 2 comments -> [The Early Christian Strategy](https://www.astralcodexten.com/p/the-early-christian-strategy)<!-- HN:42148817:end --><!-- HN:42148864:start -->
* [42148864](https://news.social-protocols.org/stats?id=42148864) #5 8 points 0 comments -> [I Used Star Methodology to Crack Amazon Leadership Principles Interview](https://techcareergrowth.beehiiv.com/p/star-methodology-amazon-interviews)<!-- HN:42148864:end --><!-- HN:42149027:start -->
* [42149027](https://news.social-protocols.org/stats?id=42149027) #27 47 points 3 comments -> [Bill Atkinson Has Pancreatic Cancer](https://daringfireball.net/linked/2024/11/13/atkinson-prayers)<!-- HN:42149027:end --><!-- HN:42150504:start -->
* [42150504](https://news.social-protocols.org/stats?id=42150504) #5 38 points 12 comments -> [National Security Just Called, They Can't See the Email Traffic](https://chronicles.mad-scientist.club/tales/27-years-of-linux/)<!-- HN:42150504:end -->
#### **Saturday, November 16, 2024**
<!-- HN:42082754:start -->
* [42082754](https://news.social-protocols.org/stats?id=42082754) #28 6 points 1 comments -> [A Visual Guide to the Aztec Pantheon](https://pudding.cool/2022/06/aztec-gods/)<!-- HN:42082754:end --><!-- HN:42151986:start -->
* [42151986](https://news.social-protocols.org/stats?id=42151986) #17 19 points 2 comments -> [Jawboning in Plain Sight: The Unconstitutional Censorship Tolerated by the DMCA](https://www.rstreet.org/research/jawboning-in-plain-sight-the-unconstitutional-censorship-tolerated-by-the-dmca/)<!-- HN:42151986:end --><!-- HN:42092670:start -->
* [42092670](https://news.social-protocols.org/stats?id=42092670) #29 7 points 0 comments -> [Philosopher of Change: How Henri Bergson's View of Reality Came to Be](https://lithub.com/philosopher-of-change-how-henri-bergsons-radical-view-of-reality-came-to-be/)<!-- HN:42092670:end --><!-- HN:42100364:start -->
* [42100364](https://news.social-protocols.org/stats?id=42100364) #11 16 points 11 comments -> [Solo round-the-world sailor Cole Brauer:first two weeks I cried every single day](https://www.theguardian.com/sport/2024/nov/08/solo-sailer-cole-brauer-interview)<!-- HN:42100364:end --><!-- HN:42099646:start -->
* [42099646](https://news.social-protocols.org/stats?id=42099646) #26 8 points 6 comments -> [Pokemon TCG Pocket Hub – Open-Source Multilingual Card Game Resource Platform](https://pokemontcgpocket.app)<!-- HN:42099646:end --><!-- HN:42151569:start -->
* [42151569](https://news.social-protocols.org/stats?id=42151569) #12 94 points 85 comments -> [Why did people rub snow on frozen feet? (2017)](https://outdoors.stackexchange.com/questions/15801/why-did-people-rub-snow-on-frozen-feet)<!-- HN:42151569:end --><!-- HN:42155986:start -->
* [42155986](https://news.social-protocols.org/stats?id=42155986) #15 10 points 1 comments -> [Micromelo Undatus](https://en.wikipedia.org/wiki/Micromelo_undatus)<!-- HN:42155986:end --><!-- HN:42152341:start -->
* [42152341](https://news.social-protocols.org/stats?id=42152341) #16 56 points 19 comments -> [Getting Started with FPGAs](https://nandland.com/book-getting-started-with-fpga/)<!-- HN:42152341:end --><!-- HN:42152928:start -->
* [42152928](https://news.social-protocols.org/stats?id=42152928) #20 141 points 72 comments -> [M4 MacBook Pros use a quantum dot (QD) film rather than a red KSF phosphor film](https://twitter.com/DSCCRoss/status/1857208745014776215)<!-- HN:42152928:end --><!-- HN:42149694:start -->
* [42149694](https://news.social-protocols.org/stats?id=42149694) #22 140 points 29 comments -> [The Practical Guide to Scaling Django](https://slimsaas.com/blog/django-scaling-performance/)<!-- HN:42149694:end --><!-- HN:42153577:start -->
* [42153577](https://news.social-protocols.org/stats?id=42153577) #27 81 points 21 comments -> [How public key cryptography works, using only simple math](https://www.quantamagazine.org/how-public-key-cryptography-really-works-20241115/)<!-- HN:42153577:end --><!-- HN:42152068:start -->
* [42152068](https://news.social-protocols.org/stats?id=42152068) #28 128 points 75 comments -> [FTC to launch investigation into Microsoft's cloud business](https://arstechnica.com/tech-policy/2024/11/ftc-to-launch-investigation-into-microsofts-cloud-business/)<!-- HN:42152068:end --><!-- HN:42150278:start -->
* [42150278](https://news.social-protocols.org/stats?id=42150278) #29 415 points 697 comments -> [Maybe Bluesky has "won"](https://anderegg.ca/2024/11/15/maybe-bluesky-has-won)<!-- HN:42150278:end --><!-- HN:42156608:start -->
* [42156608](https://news.social-protocols.org/stats?id=42156608) #10 4 points 2 comments -> [E/acc as a religion:A Technologist's Right to Choose](https://www.avidfayaz.com/writings/eacc)<!-- HN:42156608:end --><!-- HN:42157862:start -->
* [42157862](https://news.social-protocols.org/stats?id=42157862) #12 28 points 9 comments -> [Pakistani religious body declares using VPN is against Islamic law](https://www.voanews.com/a/pakistani-religious-body-declares-using-vpn-is-against-islamic-law-/7865991.html)<!-- HN:42157862:end --><!-- HN:42157606:start -->
* [42157606](https://news.social-protocols.org/stats?id=42157606) #21 12 points 0 comments -> [Stephen Spoonamore suggests presidential vote manipulated in swing states](https://substack.com/home/post/p-151721941)<!-- HN:42157606:end --><!-- HN:42158401:start -->
* [42158401](https://news.social-protocols.org/stats?id=42158401) #10 28 points 8 comments -> [Blizzard-made Warcraft 1&2 remasters look like Zynga games made by blind duck](https://www.rockpapershotgun.com/blizzard-just-quietly-released-warcraft-1-and-2-remasters-and-they-look-like-zynga-games-made-by-a-blind-duck)<!-- HN:42158401:end --><!-- HN:42159589:start -->
* [42159589](https://news.social-protocols.org/stats?id=42159589) #15 9 points 1 comments -> [Judge Blocks The Onion Bid for Alex Jones's InfoWars](https://www.nationalreview.com/news/judge-blocks-the-onions-bid-for-alex-joness-infowars-to-review-bankruptcy-auction/)<!-- HN:42159589:end --><!-- HN:42102690:start -->
* [42102690](https://news.social-protocols.org/stats?id=42102690) #17 11 points 15 comments -> [Where Does the Magic Go as We Grow Older? (2020)](https://medium.com/mindfully-speaking/where-does-the-magic-go-as-we-grow-older-15d467212efe)<!-- HN:42102690:end -->
#### **Sunday, November 17, 2024**<!-- HN:42160661:start -->
* [42160661](https://news.social-protocols.org/stats?id=42160661) #11 8 points 2 comments -> [Another million users joined Bluesky today – could Bluesky spike spark end of X?](https://news.sky.com/story/the-x-exodus-could-bluesky-spike-spark-end-of-elon-musks-social-media-platform-13254722)<!-- HN:42160661:end --><!-- HN:42160713:start -->
* [42160713](https://news.social-protocols.org/stats?id=42160713) #6 12 points 0 comments -> [Potential algorithmic bias on platform X during the 2024 US election](https://eprints.qut.edu.au/253211/)<!-- HN:42160713:end -->