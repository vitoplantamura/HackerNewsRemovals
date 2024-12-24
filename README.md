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
* [42472525](https://news.social-protocols.org/stats?id=42472525) #28 3 points 1 comments -> [People Are the New Brands](https://www.profgalloway.com/people-are-the-new-brands/)<!-- HN:42472525:end --><!-- HN:42474426:start -->
* [42474426](https://news.social-protocols.org/stats?id=42474426) #10 9 points 0 comments -> ['No Civilians. Everyone's a Terrorist': IDF Soldiers Expose Arbitrary Killings](https://www.haaretz.com/israel-news/2024-12-18/ty-article-magazine/.premium/idf-soldiers-expose-arbitrary-killings-and-rampant-lawlessness-in-gazas-netzarim-corridor/00000193-da7f-de86-a9f3-fefff2e50000)<!-- HN:42474426:end --><!-- HN:42474623:start -->
* [42474623](https://news.social-protocols.org/stats?id=42474623) #20 3 points 0 comments -> [Tea bags release microplastics, entering human intestinal cells](https://medicalxpress.com/news/2024-12-commercial-tea-bags-millions-microplastics.html)<!-- HN:42474623:end --><!-- HN:42442322:start -->
* [42442322](https://news.social-protocols.org/stats?id=42442322) #22 6 points 0 comments -> [Why use a monorepo build tool?](https://mill-build.org/blog/2-monorepo-build-tool.html)<!-- HN:42442322:end -->
#### **Saturday, December 21, 2024**<!-- HN:42449481:start -->
* [42449481](https://news.social-protocols.org/stats?id=42449481) #22 25 points 11 comments -> [NoDB: Processing Payments Without a Database](https://news.alvaroduran.com/p/nodb-processing-payments-without)<!-- HN:42449481:end --><!-- HN:42439532:start -->
* [42439532](https://news.social-protocols.org/stats?id=42439532) #13 21 points 1 comments -> [The Focusing Illusion](https://www.optimallyirrational.com/p/the-focusing-illusion)<!-- HN:42439532:end --><!-- HN:42477685:start -->
* [42477685](https://news.social-protocols.org/stats?id=42477685) #21 13 points 5 comments -> [Show HN:Free Online Tool to Experience Microsoft's MarkItdown](https://markitdown.pro)<!-- HN:42477685:end --><!-- HN:42456397:start -->
* [42456397](https://news.social-protocols.org/stats?id=42456397) #7 24 points 40 comments -> [We don't know how many birds die in structural collisions](https://robertvanwey.substack.com/p/evaluating-avian-deaths-by-collision)<!-- HN:42456397:end --><!-- HN:42480176:start -->
* [42480176](https://news.social-protocols.org/stats?id=42480176) #12 20 points 42 comments -> [The NBA's Problem Is Economics, Not Basketball](https://www.bloomberg.com/opinion/articles/2024-12-18/nba-cup-the-league-s-problem-is-economics-not-basketball)<!-- HN:42480176:end --><!-- HN:42480617:start -->
* [42480617](https://news.social-protocols.org/stats?id=42480617) #18 6 points 0 comments -> [Elderly activist to spend Christmas in prison because tag does not fit](https://www.theguardian.com/society/2024/dec/21/elderly-activist-to-spend-christmas-in-prison-because-tag-does-not-fit)<!-- HN:42480617:end --><!-- HN:42456134:start -->
* [42456134](https://news.social-protocols.org/stats?id=42456134) #9 18 points 4 comments -> [After twelve years of writing about Bitcoin, here's how my thinking has changed](http://jpkoning.blogspot.com/2024/12/after-twelve-years-of-writing-about.html)<!-- HN:42456134:end --><!-- HN:42443456:start -->
* [42443456](https://news.social-protocols.org/stats?id=42443456) #6 21 points 40 comments -> [Save Daylight Savings Time](https://www.natesilver.net/p/save-daylight-savings-time)<!-- HN:42443456:end --><!-- HN:42439654:start -->
* [42439654](https://news.social-protocols.org/stats?id=42439654) #26 30 points 40 comments -> [Fixing C Strings](https://thasso.xyz/2024/12/16/fixing-c-strings.html)<!-- HN:42439654:end -->
#### **Sunday, December 22, 2024**<!-- HN:42484398:start -->
* [42484398](https://news.social-protocols.org/stats?id=42484398) #1 7 points 0 comments -> [The BBC's Civil War over Gaza](https://www.dropsitenews.com/p/bbc-civil-war-gaza-israel-biased-coverage)<!-- HN:42484398:end --><!-- HN:42484681:start -->
* [42484681](https://news.social-protocols.org/stats?id=42484681) #26 7 points 0 comments -> [Palestine Was the Deadliest Place for Journalists in 2024](https://rsf.org/en/rsf-s-2024-round-journalism-suffers-exorbitant-human-cost-due-conflicts-and-repressive-regimes)<!-- HN:42484681:end --><!-- HN:42484513:start -->
* [42484513](https://news.social-protocols.org/stats?id=42484513) #2 -> [The Most Scathing Book Reviews of 2024](https://lithub.com/the-most-scathing-book-reviews-of-2024/)<!-- HN:42484513:end --><!-- HN:42457295:start -->
* [42457295](https://news.social-protocols.org/stats?id=42457295) #23 19 points 3 comments -> [Towards a new kind of science and technology](https://scottlocklin.wordpress.com/2024/12/18/towards-a-new-kind-of-science-and-technology/)<!-- HN:42457295:end --><!-- HN:42485043:start -->
* [42485043](https://news.social-protocols.org/stats?id=42485043) #15 16 points 21 comments -> [US shoots down two of its own Navy pilots over Red Sea](https://www.theguardian.com/us-news/2024/dec/22/us-shoots-down-two-of-its-own-navy-pilots-over-red-sea-in-apparent-friendly-fire-incident)<!-- HN:42485043:end --><!-- HN:42485080:start -->
* [42485080](https://news.social-protocols.org/stats?id=42485080) #5 8 points 2 comments -> [The highest funded plagiarist has become a Professor](https://tinimini2.wordpress.com/2024/12/22/plagiarism-can-lead-to-professorship/)<!-- HN:42485080:end --><!-- HN:42486070:start -->
* [42486070](https://news.social-protocols.org/stats?id=42486070) #16 19 points 8 comments -> [Behind Germany's Political Turmoil, a Stagnating Economy](https://www.nytimes.com/2024/12/17/world/europe/germany-government-collapse-economy.html)<!-- HN:42486070:end --><!-- HN:42487241:start -->
* [42487241](https://news.social-protocols.org/stats?id=42487241) #1 18 points 3 comments -> [How much does The Cloud really cost?](https://baremetalsavings.com/)<!-- HN:42487241:end --><!-- HN:42487362:start -->
* [42487362](https://news.social-protocols.org/stats?id=42487362) #14 3 points 0 comments -> [Having Your Tonsils Out as a Child May Have a Drastic Impact on Your Life](https://www.sciencealert.com/having-your-tonsils-out-as-a-child-may-have-a-drastic-impact-on-your-life)<!-- HN:42487362:end --><!-- HN:42486831:start -->
* [42486831](https://news.social-protocols.org/stats?id=42486831) #6 22 points 2 comments -> [Database Release and End-to-End Testing: ClickHouse Database Cloning](https://qingant.notion.site/Database-Release-and-End-to-End-Testing-Bringing-Modern-Software-Development-Best-Practices-to-the--54b34a0736024e97a6b5db819b4708dd)<!-- HN:42486831:end -->
#### **Monday, December 23, 2024**
<!-- HN:42489944:start -->
* [42489944](https://news.social-protocols.org/stats?id=42489944) #3 23 points 8 comments -> [Nostr is public key microblogging that works](https://github.com/nostr-protocol/nips/blob/master/01.md)<!-- HN:42489944:end --><!-- HN:42489600:start -->
* [42489600](https://news.social-protocols.org/stats?id=42489600) #23 7 points 4 comments -> [What Happened to the Largest Tube TV? [video]](https://www.youtube.com/watch?v=JfZxOuc9Qwk)<!-- HN:42489600:end --><!-- HN:42477226:start -->
* [42477226](https://news.social-protocols.org/stats?id=42477226) #22 6 points 0 comments -> [Piezoelectric Generators](https://www.americanpiezo.com/knowledge-center/piezo-theory/generators/)<!-- HN:42477226:end --><!-- HN:42493868:start -->
* [42493868](https://news.social-protocols.org/stats?id=42493868) #20 6 points 1 comments -> [Palantir and Anduril join forces with tech groups to bid for Pentagon contracts](https://www.ft.com/content/6cfdfe2b-6872-4963-bde8-dc6c43be5093)<!-- HN:42493868:end --><!-- HN:42493664:start -->
* [42493664](https://news.social-protocols.org/stats?id=42493664) #20 28 points 41 comments -> [Coke, PepsiCo Lobby to Keep Sugary Sodas in Food-Stamp Program](https://www.wsj.com/politics/policy/rfk-jr-soda-snap-food-stamps-coke-pepsi-9bd9a872)<!-- HN:42493664:end --><!-- HN:42494809:start -->
* [42494809](https://news.social-protocols.org/stats?id=42494809) #22 28 points 20 comments -> [Good cities can't exist without public order](https://www.noahpinion.blog/p/good-cities-cant-exist-without-public)<!-- HN:42494809:end -->
#### **Tuesday, December 24, 2024**
<!-- HN:42500482:start -->
* [42500482](https://news.social-protocols.org/stats?id=42500482) #16 187 points 88 comments -> [Intel shareholders file case asking ex CEO, CFO to return 3 years of salary](https://www.cfodive.com/news/intel-shareholders-yank-exceo-cfo-compensation-foundry/736193/)<!-- HN:42500482:end --><!-- HN:42494746:start -->
* [42494746](https://news.social-protocols.org/stats?id=42494746) #21 401 points 298 comments -> [Commercial tea bags release microplastics, entering human cells](https://medicalxpress.com/news/2024-12-commercial-tea-bags-millions-microplastics.html)<!-- HN:42494746:end --><!-- HN:42495077:start -->
* [42495077](https://news.social-protocols.org/stats?id=42495077) #23 250 points 36 comments -> [Fogus: Things and Stuff of 2024](https://blog.fogus.me/2024/12/23/the-best-things-and-stuff-of-2024/)<!-- HN:42495077:end --><!-- HN:42502210:start -->
* [42502210](https://news.social-protocols.org/stats?id=42502210) #18 5 points 1 comments -> [7-year-old boy undergoes heart surgery after getting hit by falling drone](https://www.cbsnews.com/news/florida-holiday-show-drone-collision-orlando/)<!-- HN:42502210:end --><!-- HN:42502915:start -->
* [42502915](https://news.social-protocols.org/stats?id=42502915) #3 4 points 0 comments -> [Charlie Munger's wisdom lives on in LLMs](https://bren.blog/charlie-munger-lives-on-in-llms)<!-- HN:42502915:end --><!-- HN:42502768:start -->
* [42502768](https://news.social-protocols.org/stats?id=42502768) #26 5 points 0 comments -> [Return to NSA's Menwith Hill with 60 Minutes (2000)](https://cryptome.org/menwith-mn60.htm)<!-- HN:42502768:end --><!-- HN:42484790:start -->
* [42484790](https://news.social-protocols.org/stats?id=42484790) #17 22 points 23 comments -> [Communal Luxury: The Public Bathhouse](https://solar.lowtechmagazine.com/2024/09/communal-luxury-the-public-bathhouse/)<!-- HN:42484790:end --><!-- HN:42503558:start -->
* [42503558](https://news.social-protocols.org/stats?id=42503558) #15 22 points 24 comments -> [Apple seeks to defend Google's billion-dollar payments in search case](https://www.reuters.com/technology/apple-seeks-defend-googles-billion-dollar-payments-search-case-2024-12-24/)<!-- HN:42503558:end -->