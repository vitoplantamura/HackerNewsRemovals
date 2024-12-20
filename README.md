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

#### **Saturday, December 14, 2024**
<!-- HN:42413693:start -->
* [42413693](https://news.social-protocols.org/stats?id=42413693) #2 35 points 1 comments -> [My PhD advisor rewrote himself in bash](https://matt.might.net/articles/shell-scripts-for-passive-voice-weasel-words-duplicates/)<!-- HN:42413693:end --><!-- HN:42414912:start -->
* [42414912](https://news.social-protocols.org/stats?id=42414912) #4 84 points 23 comments -> [Ilya Sutskever Test of Time Talk "Pre-training as we know it will end"](https://twitter.com/i/status/1867719020444889118)<!-- HN:42414912:end --><!-- HN:42413845:start -->
* [42413845](https://news.social-protocols.org/stats?id=42413845) #13 173 points 84 comments -> [Htmx 2.0.4 Released](https://github.com/bigskysoftware/htmx/blob/v2.0.4/CHANGELOG.md)<!-- HN:42413845:end --><!-- HN:42390226:start -->
* [42390226](https://news.social-protocols.org/stats?id=42390226) #24 6 points 9 comments -> [The case against static typing in PHP (2023)](https://www.tonymarston.net/php-mysql/against-static-typing-in-php.html)<!-- HN:42390226:end --><!-- HN:42415768:start -->
* [42415768](https://news.social-protocols.org/stats?id=42415768) #10 3 points 0 comments -> [John Carmack on Functional Programming in C++](http://www.sevangelatos.com/john-carmack-on/)<!-- HN:42415768:end --><!-- HN:42414641:start -->
* [42414641](https://news.social-protocols.org/stats?id=42414641) #18 38 points 9 comments -> [Suchir's Essay on Fair Use](https://suchir.net/fair_use.html)<!-- HN:42414641:end --><!-- HN:42378532:start -->
* [42378532](https://news.social-protocols.org/stats?id=42378532) #10 11 points 4 comments -> [Subnet routers: how do they work?](https://tailscale.com/blog/subnet-router-video)<!-- HN:42378532:end --><!-- HN:42418365:start -->
* [42418365](https://news.social-protocols.org/stats?id=42418365) #17 3 points 0 comments -> [TikTok's Future in the US Is Unclear](https://www.wired.com/story/tiktok-future-ban-billionaire-mccourt-sale/)<!-- HN:42418365:end --><!-- HN:42387220:start -->
* [42387220](https://news.social-protocols.org/stats?id=42387220) #6 31 points 43 comments -> [WhatsApp became an unstoppable cultural force](https://restofworld.org/2024/how-whatsapp-became-a-global-cultural-force/)<!-- HN:42387220:end --><!-- HN:42420012:start -->
* [42420012](https://news.social-protocols.org/stats?id=42420012) #23 17 points 12 comments -> [Scandal in Russian military town as new school is decorated with F-16 images](https://www.thebarentsobserver.com/news/scandal-in-russian-military-town-pechenga-as-new-school-is-decorated-with-picture-of-us-fighter-jets/422078)<!-- HN:42420012:end -->
#### **Sunday, December 15, 2024**
<!-- HN:42419895:start -->
* [42419895](https://news.social-protocols.org/stats?id=42419895) #11 8 points 2 comments -> [Meet your new Time Server](https://centerclick.com/ntp/)<!-- HN:42419895:end --><!-- HN:42420361:start -->
* [42420361](https://news.social-protocols.org/stats?id=42420361) #27 35 points 37 comments -> [There's a New Country Ranking and You're Not Going to Like It](https://www.atvbt.com/bmi/)<!-- HN:42420361:end --><!-- HN:42421477:start -->
* [42421477](https://news.social-protocols.org/stats?id=42421477) #9 38 points 5 comments -> [Doom ported to run mostly only on AMD GPUs via ROCm and LLVM Libc](https://www.phoronix.com/news/DOOM-ROCm-LLVM-Port)<!-- HN:42421477:end --><!-- HN:42391666:start -->
* [42391666](https://news.social-protocols.org/stats?id=42391666) #11 9 points 0 comments -> [Canids as Pollinators?](https://esajournals.onlinelibrary.wiley.com/doi/10.1002/ecy.4470)<!-- HN:42391666:end --><!-- HN:42422594:start -->
* [42422594](https://news.social-protocols.org/stats?id=42422594) #5 9 points 2 comments -> [Show HN: Shop Clothes with Models That Match Your Body Shape](https://www.thebodymatch.com)<!-- HN:42422594:end --><!-- HN:42407187:start -->
* [42407187](https://news.social-protocols.org/stats?id=42407187) #25 14 points 1 comments -> [In pictures: Learning the Knowledge (2016)](https://www.bbc.com/news/in-pictures-35667599)<!-- HN:42407187:end --><!-- HN:42423489:start -->
* [42423489](https://news.social-protocols.org/stats?id=42423489) #4 7 points 0 comments -> [Search through Rijksmuseum artworks based on meaning](https://artexplorer.ai/)<!-- HN:42423489:end --><!-- HN:42423645:start -->
* [42423645](https://news.social-protocols.org/stats?id=42423645) #15 6 points 0 comments -> [She took a DNA test. Police used it to charge her grandma with a 1997 murder](https://www.cnn.com/2024/12/12/us/baby-garnet-cold-case-michigan/index.html)<!-- HN:42423645:end --><!-- HN:42423437:start -->
* [42423437](https://news.social-protocols.org/stats?id=42423437) #22 9 points 1 comments -> [Spaces ZeroGPU: Dynamic GPU Allocation for Spaces](https://huggingface.co/docs/hub/en/spaces-zerogpu)<!-- HN:42423437:end --><!-- HN:42390863:start -->
* [42390863](https://news.social-protocols.org/stats?id=42390863) #20 8 points 1 comments -> [Promising early data in triple negative breast cancer](https://www.statnews.com/2024/12/10/triple-negative-breast-cancer-biontech-immunotherapy-bispecific/)<!-- HN:42390863:end --><!-- HN:42425022:start -->
* [42425022](https://news.social-protocols.org/stats?id=42425022) #14 12 points 2 comments -> [Infectious diseases in Victorian novels highlight public health fragility now](https://theconversation.com/infectious-diseases-killed-victorian-children-at-alarming-rates-their-novels-highlight-the-fragility-of-public-health-today-242273)<!-- HN:42425022:end --><!-- HN:42426296:start -->
* [42426296](https://news.social-protocols.org/stats?id=42426296) #2 19 points 2 comments -> [Visualization of cities with similar road networks](https://github.com/anvaka/similar-cities)<!-- HN:42426296:end -->
#### **Monday, December 16, 2024**
<!-- HN:42427731:start -->
* [42427731](https://news.social-protocols.org/stats?id=42427731) #5 3 points 2 comments -> [Luigi Mangione's Resume](https://www.kenklippenstein.com/p/read-luigi-mangiones-resume)<!-- HN:42427731:end --><!-- HN:42428876:start -->
* [42428876](https://news.social-protocols.org/stats?id=42428876) #12 21 points 40 comments -> [Swedish minister eyes energy crisis steps, blames German nuclear phase-out](https://www.euractiv.com/section/energy/news/swedish-minister-open-to-new-measures-to-tackle-energy-crisis-blames-german-nuclear-phase-out/)<!-- HN:42428876:end --><!-- HN:42423335:start -->
* [42423335](https://news.social-protocols.org/stats?id=42423335) #3 11 points 0 comments -> [Playstation 5 transformed into a laptop for $2,750](https://www.tomshardware.com/video-games/console-gaming/playstation-5-transformed-into-a-laptop-for-usd2-750-chinese-modders-made-sonys-console-more-portable-with-a-17-3-inch-4k-display-weighing-over-9-pounds)<!-- HN:42423335:end --><!-- HN:42430362:start -->
* [42430362](https://news.social-protocols.org/stats?id=42430362) #20 3 points 0 comments -> [OpenAI whistleblower S.Balaji found dead in his apartment](https://www.bbc.com/news/articles/cd0el3r2nlko)<!-- HN:42430362:end --><!-- HN:42433501:start -->
* [42433501](https://news.social-protocols.org/stats?id=42433501) #26 6 points 0 comments -> [Never Forgive Them](https://www.wheresyoured.at/never-forgive-them/)<!-- HN:42433501:end --><!-- HN:42432970:start -->
* [42432970](https://news.social-protocols.org/stats?id=42432970) #12 6 points 6 comments -> [Springfield, KS](https://unworld.neocities.org/)<!-- HN:42432970:end --><!-- HN:42434220:start -->
* [42434220](https://news.social-protocols.org/stats?id=42434220) #27 7 points 0 comments -> [Lard is healthier than sunflower oil](https://www.dailymail.co.uk/health/article-3176558/It-s-healthier-cook-LARD-sunflower-oil-Extraordinary-experiment-shows-ve-told-cooking-oils-wrong.html)<!-- HN:42434220:end --><!-- HN:42434151:start -->
* [42434151](https://news.social-protocols.org/stats?id=42434151) #23 -> [Do not throw away your old PCs](https://blog.lhotka.net/2024/12/15/Do-not-throw-away-your-old-PCs)<!-- HN:42434151:end -->
#### **Tuesday, December 17, 2024**<!-- HN:42439689:start -->
* [42439689](https://news.social-protocols.org/stats?id=42439689) #7 29 points 1 comments -> [Our first new Framework Laptop 16 Expansion Bay module](https://frame.work/au/en/blog/our-first-new-framework-laptop-16-expansion-bay-module)<!-- HN:42439689:end --><!-- HN:42416396:start -->
* [42416396](https://news.social-protocols.org/stats?id=42416396) #9 14 points 0 comments -> [Datasaurus dozen – Different datasets with the same descriptive statistics](https://en.wikipedia.org/wiki/Datasaurus_dozen)<!-- HN:42416396:end --><!-- HN:42427677:start -->
* [42427677](https://news.social-protocols.org/stats?id=42427677) #14 13 points 4 comments -> [Eating Spaghetti by the Fistful Was Once a Neapolitan Street Spectacle](https://www.atlasobscura.com/articles/spaghetti-eaten-by-hand-naples)<!-- HN:42427677:end --><!-- HN:42428192:start -->
* [42428192](https://news.social-protocols.org/stats?id=42428192) #8 17 points 1 comments -> [Technical Report on Mirror Bacteria: Feasibility and Risks](https://purl.stanford.edu/cv716pj4036)<!-- HN:42428192:end --><!-- HN:42438898:start -->
* [42438898](https://news.social-protocols.org/stats?id=42438898) #17 18 points 0 comments -> [Valhalla – Java's Epic Refactor](https://inside.java/2024/12/16/devoxxbelgium-valhalla/)<!-- HN:42438898:end --><!-- HN:42440998:start -->
* [42440998](https://news.social-protocols.org/stats?id=42440998) #5 10 points 4 comments -> [Ever wished you could time-travel just to say 'I told u so'?](https://www.tolduvault.com/)<!-- HN:42440998:end --><!-- HN:42441556:start -->
* [42441556](https://news.social-protocols.org/stats?id=42441556) #22 4 points 1 comments -> [AT&T user's erroneous $6,223 bill is reminder that AutoPay can wipe you out](https://www.phonearena.com/news/AT-T-users-erroneous-6223-bill-is-reminder-that-AutoPay-can-wipe-you-out_id165901)<!-- HN:42441556:end --><!-- HN:42442295:start -->
* [42442295](https://news.social-protocols.org/stats?id=42442295) #18 6 points 0 comments -> [Nvidia Jetson Orin Nano Super: The most affordable generative AI supercomputer](https://www.nvidia.com/en-us/autonomous-machines/embedded-systems/jetson-orin/nano-super-developer-kit/)<!-- HN:42442295:end --><!-- HN:42442331:start -->
* [42442331](https://news.social-protocols.org/stats?id=42442331) #23 4 points 0 comments -> [Celebrating a Decade of Discourse](https://blog.discourse.org/2024/08/celebrating-a-decade-of-discourse/)<!-- HN:42442331:end --><!-- HN:42442298:start -->
* [42442298](https://news.social-protocols.org/stats?id=42442298) #27 7 points 3 comments -> [Waymo – Avoiding a Falling Skateboarder](https://twitter.com/dmitri_dolgov/status/1868778679868047545)<!-- HN:42442298:end --><!-- HN:42442652:start -->
* [42442652](https://news.social-protocols.org/stats?id=42442652) #21 4 points 0 comments -> [Indian-born CEO of Japanese company says nation needs immigration to thrive](https://www.japantimes.co.jp/business/2024/12/15/companies/india-born-kameda-ceo/)<!-- HN:42442652:end --><!-- HN:42442107:start -->
* [42442107](https://news.social-protocols.org/stats?id=42442107) #13 37 points 30 comments -> [Nvidia Jetson Orin Nano Super [video]](https://www.youtube.com/watch?v=S9L2WGf1KrM)<!-- HN:42442107:end --><!-- HN:42442521:start -->
* [42442521](https://news.social-protocols.org/stats?id=42442521) #16 14 points 1 comments -> [New FCC chair wants to revoke broadcast licenses; First Amendment might stop him](https://arstechnica.com/tech-policy/2024/12/trumps-fcc-chair-can-hassle-the-living-daylights-out-of-news-broadcasters/)<!-- HN:42442521:end --><!-- HN:42441671:start -->
* [42441671](https://news.social-protocols.org/stats?id=42441671) #26 6 points 2 comments -> [Show HN: CerebrasCoder – make websites in less than a second](https://cerebrascoder.com/)<!-- HN:42441671:end --><!-- HN:42444113:start -->
* [42444113](https://news.social-protocols.org/stats?id=42444113) #15 9 points 0 comments -> [Japan's Honda and Nissan to reportedly begin merger talks](https://www.cnbc.com/2024/12/17/japans-honda-and-nissan-to-reportedly-begin-merger-talks.html)<!-- HN:42444113:end --><!-- HN:42443634:start -->
* [42443634](https://news.social-protocols.org/stats?id=42443634) #17 28 points 7 comments -> [Show HN: PipeGate – A Lightweight, Self-Hosted Proxy to Expose Local Servers](https://github.com/janbjorge/pipegate)<!-- HN:42443634:end -->
#### **Wednesday, December 18, 2024**
<!-- HN:42448405:start -->
* [42448405](https://news.social-protocols.org/stats?id=42448405) #17 13 points 2 comments -> [GPS – Bartosz Ciechanowski (2022)](https://ciechanow.ski/gps/)<!-- HN:42448405:end --><!-- HN:42418345:start -->
* [42418345](https://news.social-protocols.org/stats?id=42418345) #25 -> [US city tells residents to stop sticking googly eyes on its statues](https://news.sky.com/story/us-city-tells-residents-to-stop-sticking-googly-eyes-on-its-statues-13273478)<!-- HN:42418345:end --><!-- HN:42450890:start -->
* [42450890](https://news.social-protocols.org/stats?id=42450890) #15 26 points 41 comments -> [US airspace closures, lack of answers deepen East Coast drone mystery](https://www.theregister.com/2024/12/17/mystery_drone_sightings/)<!-- HN:42450890:end --><!-- HN:42451449:start -->
* [42451449](https://news.social-protocols.org/stats?id=42451449) #2 32 points 17 comments -> [AI will be dead in five years](https://erikgahner.dk/2024/ai-will-be-dead-in-five-years/)<!-- HN:42451449:end --><!-- HN:42451552:start -->
* [42451552](https://news.social-protocols.org/stats?id=42451552) #13 58 points 23 comments -> [Bank of North Dakota](https://en.wikipedia.org/wiki/Bank_of_North_Dakota)<!-- HN:42451552:end --><!-- HN:42451979:start -->
* [42451979](https://news.social-protocols.org/stats?id=42451979) #16 42 points 16 comments -> [W54](https://en.wikipedia.org/wiki/W54)<!-- HN:42451979:end --><!-- HN:42451886:start -->
* [42451886](https://news.social-protocols.org/stats?id=42451886) #11 38 points 7 comments -> [Leadership Power Tools: SQL and Statistics](https://matt.blwt.io/post/leadership-power-tools-sql-and-statistics/)<!-- HN:42451886:end --><!-- HN:42451868:start -->
* [42451868](https://news.social-protocols.org/stats?id=42451868) #14 53 points 72 comments -> [USDA locks barn door after Listeria escapes](https://efoodalert.com/2024/12/17/usda-locks-barn-door-after-listeria-escapes/)<!-- HN:42451868:end --><!-- HN:42451717:start -->
* [42451717](https://news.social-protocols.org/stats?id=42451717) #20 28 points 6 comments -> [Intel Inside, Gelsinger Outside](https://spyglass.org/intel-outside-gelsinger/)<!-- HN:42451717:end --><!-- HN:42453157:start -->
* [42453157](https://news.social-protocols.org/stats?id=42453157) #26 6 points 1 comments -> [Radxa Orion O6 Mini-ITX Arm Motherboard with Cix P1 12-Core ARMv9 SoC and UEFI](https://www.cnx-software.com/2024/12/18/radxa-orion-o6-mini-itx-motherboard-is-powered-by-cix-p1-12-core-armv9-soc-with-a-30-tops-ai-accelerator/)<!-- HN:42453157:end --><!-- HN:42452995:start -->
* [42452995](https://news.social-protocols.org/stats?id=42452995) #22 8 points 5 comments -> [We May Be on the Brink of Finding the Real Planet Nine](https://www.scientificamerican.com/article/if-planet-nine-exists-well-find-it-soon/)<!-- HN:42452995:end --><!-- HN:42431144:start -->
* [42431144](https://news.social-protocols.org/stats?id=42431144) #18 10 points 1 comments -> [Rootly New Blog Series: RescueOps](https://rootly.com/blog/new-blog-series-rescueops)<!-- HN:42431144:end --><!-- HN:42451271:start -->
* [42451271](https://news.social-protocols.org/stats?id=42451271) #11 72 points 4 comments -> [New H1-B Rule by Homeland Security](https://twitter.com/FedericoNoemie/status/1869381822637133842)<!-- HN:42451271:end --><!-- HN:42453529:start -->
* [42453529](https://news.social-protocols.org/stats?id=42453529) #30 5 points 1 comments -> [GitHub Copilot Free Plan](https://github.com/features/copilot/plans)<!-- HN:42453529:end --><!-- HN:42453770:start -->
* [42453770](https://news.social-protocols.org/stats?id=42453770) #28 3 points 0 comments -> [A Free GitHub Copilot for VS Code](https://code.visualstudio.com/blogs/2024/12/18/free-github-copilot)<!-- HN:42453770:end --><!-- HN:42418839:start -->
* [42418839](https://news.social-protocols.org/stats?id=42418839) #17 27 points 9 comments -> [Castle Game Engine: In progress: web target, IFC, mORMot sample](https://castle-engine.io/wp/2024/11/30/in-progress-web-target-ifc-mormot-sample/)<!-- HN:42418839:end --><!-- HN:42453126:start -->
* [42453126](https://news.social-protocols.org/stats?id=42453126) #30 20 points 2 comments -> [GitHub launches a free version of its Copilot](https://techcrunch.com/2024/12/18/github-launches-a-free-version-of-its-copilot/)<!-- HN:42453126:end --><!-- HN:42453574:start -->
* [42453574](https://news.social-protocols.org/stats?id=42453574) #17 18 points 40 comments -> [The end is nigh and here's why](https://www.experimental-history.com/p/the-end-is-nigh-and-heres-why)<!-- HN:42453574:end -->
#### **Thursday, December 19, 2024**
<!-- HN:42456980:start -->
* [42456980](https://news.social-protocols.org/stats?id=42456980) #26 3 points 0 comments -> [The Rise of the AI Crawler](https://vercel.com/blog/the-rise-of-the-ai-crawler)<!-- HN:42456980:end --><!-- HN:42457073:start -->
* [42457073](https://news.social-protocols.org/stats?id=42457073) #14 35 points 30 comments -> [Apple Says Meta Is Making Unreasonable Interoperability Requests Under EU's DMA](https://www.macrumors.com/2024/12/18/apple-meta-interoperability-requests-dma/)<!-- HN:42457073:end --><!-- HN:42437958:start -->
* [42437958](https://news.social-protocols.org/stats?id=42437958) #14 12 points 3 comments -> [Making Apple Watch functional with Android](https://github.com/abishekmuthian/apple-watch-with-android)<!-- HN:42437958:end --><!-- HN:42432216:start -->
* [42432216](https://news.social-protocols.org/stats?id=42432216) #6 35 points 15 comments -> [Physicists Find Particle That Only Has Mass When Moving in One Direction](https://www.sciencealert.com/physicists-find-particle-that-only-has-mass-when-moving-in-one-direction)<!-- HN:42432216:end --><!-- HN:42461566:start -->
* [42461566](https://news.social-protocols.org/stats?id=42461566) #7 22 points 13 comments -> [AIs Will Increasingly Attempt Shenanigans](https://www.lesswrong.com/posts/v7iepLXH2KT4SDEvB/ais-will-increasingly-attempt-shenanigans)<!-- HN:42461566:end --><!-- HN:42461428:start -->
* [42461428](https://news.social-protocols.org/stats?id=42461428) #20 59 points 19 comments -> [Santa Prefers Wealthy Sick Children](https://taylor.town/santa-prefers)<!-- HN:42461428:end --><!-- HN:42461480:start -->
* [42461480](https://news.social-protocols.org/stats?id=42461480) #18 3 points 1 comments -> [Show HN: Job Simlarity (vector similarity graphs, WhoIsHiring/JSON Resume)](https://registry.jsonresume.org/job-similarity)<!-- HN:42461480:end --><!-- HN:42463092:start -->
* [42463092](https://news.social-protocols.org/stats?id=42463092) #21 3 points 0 comments -> [CATL says it has co-developed 10 new EV models with swappable batteries](https://www.reuters.com/business/energy/catl-says-it-will-build-over-1000-battery-swapping-stations-2025-2024-12-18/)<!-- HN:42463092:end --><!-- HN:42466491:start -->
* [42466491](https://news.social-protocols.org/stats?id=42466491) #2 18 points 0 comments -> [The Ghosts in the Machine – Spotify's plot against musicians](https://harpers.org/archive/2025/01/the-ghosts-in-the-machine-liz-pelly-spotify-musicians/)<!-- HN:42466491:end -->
#### **Friday, December 20, 2024**
<!-- HN:42444088:start -->
* [42444088](https://news.social-protocols.org/stats?id=42444088) #13 39 points 5 comments -> [Max GPU: A new GenAI native serving stac](https://www.modular.com/blog/introducing-max-24-6-a-gpu-native-generative-ai-platform)<!-- HN:42444088:end --><!-- HN:42441956:start -->
* [42441956](https://news.social-protocols.org/stats?id=42441956) #11 6 points 4 comments -> [Eight Day Road Trip of Western Ghats in Karnataka from Bangalore](https://travelswithpriyanka.substack.com/p/8-day-road-trip-of-western-ghats)<!-- HN:42441956:end --><!-- HN:42470435:start -->
* [42470435](https://news.social-protocols.org/stats?id=42470435) #18 10 points 4 comments -> [10-foot-tall people discovered by archaeologists in Nevada cave](https://www.msn.com/en-gb/news/world/10-foot-tall-people-discovered-by-archaeologists-in-nevada-cave/ar-BB1oQVZ2)<!-- HN:42470435:end --><!-- HN:42471094:start -->
* [42471094](https://news.social-protocols.org/stats?id=42471094) #12 19 points 41 comments -> [Walmart Employees Now Wearing Body Cameras to Keep Them Safe](https://petapixel.com/2024/12/19/walmart-employees-now-wearing-body-cameras-to-keep-them-safe/)<!-- HN:42471094:end --><!-- HN:42434232:start -->
* [42434232](https://news.social-protocols.org/stats?id=42434232) #10 21 points 15 comments -> [Uber will need to fingerprint drivers in California to transport teens](https://techcrunch.com/2024/12/05/uber-will-need-to-fingerprint-drivers-in-california-to-transport-teens/)<!-- HN:42434232:end --><!-- HN:42468362:start -->
* [42468362](https://news.social-protocols.org/stats?id=42468362) #14 52 points 37 comments -> [ByteDance's Recommendation System](https://github.com/bytedance/monolith)<!-- HN:42468362:end --><!-- HN:42472525:start -->
* [42472525](https://news.social-protocols.org/stats?id=42472525) #28 3 points 1 comments -> [People Are the New Brands](https://www.profgalloway.com/people-are-the-new-brands/)<!-- HN:42472525:end -->