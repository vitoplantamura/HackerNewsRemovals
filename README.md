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

#### **Sunday, June 29, 2025**
<!-- HN:44406768:start -->
* [44406768](https://news.social-protocols.org/stats?id=44406768) #22 31 points 40 comments -> [NovaCustom – Framework Laptop alternative focusing on privacy](https://novacustom.com/)<!-- HN:44406768:end --><!-- HN:44410159:start -->
* [44410159](https://news.social-protocols.org/stats?id=44410159) #27 14 points 5 comments -> [Techie went home rather than fix mistake that caused a meltdown](https://www.theregister.com/2025/06/23/who_me/)<!-- HN:44410159:end --><!-- HN:44411021:start -->
* [44411021](https://news.social-protocols.org/stats?id=44411021) #24 5 points 0 comments -> [A Gazan mother feeds her twins lentils instead of milk as blockade continues](https://truthforge.substack.com/p/a-gazan-mother-feeds-her-twins-lentils)<!-- HN:44411021:end --><!-- HN:44411083:start -->
* [44411083](https://news.social-protocols.org/stats?id=44411083) #23 7 points 0 comments -> [Calling white middle-aged women Karen 'borders on racism'](https://www.thetimes.com/uk/law/article/calling-white-middle-aged-women-karen-borders-on-racism-b6wccb9g6)<!-- HN:44411083:end --><!-- HN:44410616:start -->
* [44410616](https://news.social-protocols.org/stats?id=44410616) #17 32 points 40 comments -> [Brave creates new TLD on the blockchain](https://brave.com/blog/brave-tld/)<!-- HN:44410616:end --><!-- HN:44412308:start -->
* [44412308](https://news.social-protocols.org/stats?id=44412308) #4 8 points 3 comments -> [A Framework for Recognizing Emergent Consciousness in AI](https://habr.com/en/articles/922894/)<!-- HN:44412308:end --><!-- HN:44408459:start -->
* [44408459](https://news.social-protocols.org/stats?id=44408459) #15 85 points 39 comments -> [Group of investors represented by YouTuber Perifractic buys Commodore](https://www.amiga-news.de/en/news/AN-2025-06-00123-EN.html)<!-- HN:44408459:end --><!-- HN:44412296:start -->
* [44412296](https://news.social-protocols.org/stats?id=44412296) #29 6 points 0 comments -> [On the capacity, performance, and reliability of microSD cards](https://www.bahjeez.com/the-great-microsd-card-survey/)<!-- HN:44412296:end --><!-- HN:44412120:start -->
* [44412120](https://news.social-protocols.org/stats?id=44412120) #25 13 points 5 comments -> [Toyota RAV4 topples Tesla Model Y as best-selling car](https://www.carexpert.com.au/car-news/toyota-rav4-topples-tesla-model-y-as-worlds-best-selling-car)<!-- HN:44412120:end --><!-- HN:44414286:start -->
* [44414286](https://news.social-protocols.org/stats?id=44414286) #16 18 points 2 comments -> [Ok now this is just ridiculous](https://mastodon.social/@czeins/114739403773350112)<!-- HN:44414286:end --><!-- HN:44414895:start -->
* [44414895](https://news.social-protocols.org/stats?id=44414895) #10 13 points 0 comments -> [Budapest Pride Parade Was Bigger Than Ever, Despite Orban's Ban](https://www.nytimes.com/2025/06/28/world/europe/hungary-orban-gay-pride.html)<!-- HN:44414895:end --><!-- HN:44414553:start -->
* [44414553](https://news.social-protocols.org/stats?id=44414553) #7 5 points 0 comments -> [Analysing the Death Toll from the Hamas-Run Ministry of Health in Gaza [pdf]](https://henryjacksonsociety.org/wp-content/uploads/2024/12/HJS-Questionable-Counting-%E2%80%93-Hamas-Report-web-v2.pdf)<!-- HN:44414553:end --><!-- HN:44415145:start -->
* [44415145](https://news.social-protocols.org/stats?id=44415145) #9 11 points 3 comments -> [Agile Was Never Your Problem](https://thecynical.dev/posts/agile-was-never-your-problem/)<!-- HN:44415145:end --><!-- HN:44415563:start -->
* [44415563](https://news.social-protocols.org/stats?id=44415563) #24 9 points 1 comments -> [The Asymmetry of Destruction](https://passingtime.substack.com/p/the-asymmetry-of-destruction)<!-- HN:44415563:end --><!-- HN:44417629:start -->
* [44417629](https://news.social-protocols.org/stats?id=44417629) #19 7 points 3 comments -> [The End of US Democracy](https://crookedtimber.org/2025/06/29/the-end-of-us-democracy/)<!-- HN:44417629:end -->
#### **Monday, June 30, 2025**
<!-- HN:44417846:start -->
* [44417846](https://news.social-protocols.org/stats?id=44417846) #14 -> [Manifold: An open-source tool to run AI models for 90% less](https://github.com/Esrbwt1/manifold)<!-- HN:44417846:end --><!-- HN:44414853:start -->
* [44414853](https://news.social-protocols.org/stats?id=44414853) #28 284 points 132 comments -> [Loss of key US satellite data could send hurricane forecasting back 'decades'](https://www.theguardian.com/us-news/2025/jun/28/noaa-cuts-hurricane-forecasting-climate)<!-- HN:44414853:end --><!-- HN:44420436:start -->
* [44420436](https://news.social-protocols.org/stats?id=44420436) #30 6 points 3 comments -> [Louvre shuts down with staff sounding the alarm on mass tourism](https://www.washingtonpost.com/world/2025/06/16/louvre-museum-paris-closed-lines-delay/2b303a16-4a9f-11f0-8fff-262d6ec54ab9_story.html)<!-- HN:44420436:end --><!-- HN:44421749:start -->
* [44421749](https://news.social-protocols.org/stats?id=44421749) #15 15 points 2 comments -> [GOP Bill Adds Surprise Tax That Could Cripple Wind and Solar Power](https://www.nytimes.com/2025/06/29/climate/gop-bill-adds-surprise-tax-that-could-cripple-wind-and-solar-power.html)<!-- HN:44421749:end --><!-- HN:44422209:start -->
* [44422209](https://news.social-protocols.org/stats?id=44422209) #17 4 points 1 comments -> ['Bloodiest 21st century war': New study finds Gaza's real death toll nears 100k](https://thecradle.co/articles-id/31631)<!-- HN:44422209:end --><!-- HN:44422040:start -->
* [44422040](https://news.social-protocols.org/stats?id=44422040) #15 109 points 137 comments -> [Entry-level jobs down by a third since launch of ChatGPT](https://www.personneltoday.com/hr/fall-in-entry-level-jobs-linked-to-rise-of-ai-tools/)<!-- HN:44422040:end --><!-- HN:44424456:start -->
* [44424456](https://news.social-protocols.org/stats?id=44424456) #18 13 points 6 comments -> [Make Fun of Them](https://www.wheresyoured.at/make-fun-of-them/)<!-- HN:44424456:end --><!-- HN:44428518:start -->
* [44428518](https://news.social-protocols.org/stats?id=44428518) #25 -> [Corruption Database – DJT](https://github.com/codeddarkness/taco_pardons)<!-- HN:44428518:end -->
#### **Tuesday, July 1, 2025**<!-- HN:44429190:start -->
* [44429190](https://news.social-protocols.org/stats?id=44429190) #7 12 points 3 comments -> [Taste Is the New Intelligence](https://wildbarestepf.substack.com/p/taste-is-the-new-intelligence)<!-- HN:44429190:end --><!-- HN:44406866:start -->
* [44406866](https://news.social-protocols.org/stats?id=44406866) #30 8 points 2 comments -> [Making a $20 smart boombox [video]](https://www.youtube.com/watch?v=P3XCPywlXBI)<!-- HN:44406866:end --><!-- HN:44403117:start -->
* [44403117](https://news.social-protocols.org/stats?id=44403117) #25 7 points 1 comments -> [Beneath the canopy: Pioneering satellite reveals rainforests' hidden worlds](https://www.bbc.co.uk/news/resources/idt-d7353b50-0fea-46ba-8495-ae9e25192cfe)<!-- HN:44403117:end --><!-- HN:44431549:start -->
* [44431549](https://news.social-protocols.org/stats?id=44431549) #1 6 points 0 comments -> [Age-Verification Laws Seek to Erase LGBTQ+ Identity from the Internet](https://msmagazine.com/2025/02/25/lgbtq-abortion-censorship-age-verification-laws/)<!-- HN:44431549:end --><!-- HN:44398173:start -->
* [44398173](https://news.social-protocols.org/stats?id=44398173) #8 25 points 14 comments -> [Transparent Electronics](https://www.are.na/james-hicks/transparent-electronics)<!-- HN:44398173:end --><!-- HN:44431873:start -->
* [44431873](https://news.social-protocols.org/stats?id=44431873) #21 23 points 21 comments -> [Researchers Uncover Hidden Ingredients Behind AI Creativity](https://www.quantamagazine.org/researchers-uncover-hidden-ingredients-behind-ai-creativity-20250630/)<!-- HN:44431873:end --><!-- HN:44433990:start -->
* [44433990](https://news.social-protocols.org/stats?id=44433990) #19 -> [Effects of USAID defunding on mortality projections up to 2030](https://www.thelancet.com/journals/lancet/article/PIIS0140-6736(25)01186-9/fulltext)<!-- HN:44433990:end --><!-- HN:44435477:start -->
* [44435477](https://news.social-protocols.org/stats?id=44435477) #16 4 points 0 comments -> [Online shopping see biggest slowdown in over decade as tariffs disrupt ecommerce](https://www.cnbc.com/2025/07/01/online-retail-sees-biggest-slowdown-in-decade-tariffs-hit-e-commerce.html)<!-- HN:44435477:end -->
#### **Wednesday, July 2, 2025**
<!-- HN:44439306:start -->
* [44439306](https://news.social-protocols.org/stats?id=44439306) #8 4 points 0 comments -> [Profiting from Genocide](https://chrishedges.substack.com/p/profiting-from-genocide)<!-- HN:44439306:end --><!-- HN:44439513:start -->
* [44439513](https://news.social-protocols.org/stats?id=44439513) #6 21 points 1 comments -> [RFK Jr.'s health department calls Nature "junk science," cancels subscriptions](https://arstechnica.com/health/2025/07/rfk-jr-s-health-department-calls-nature-junk-science-cancels-subscriptions/)<!-- HN:44439513:end --><!-- HN:44439730:start -->
* [44439730](https://news.social-protocols.org/stats?id=44439730) #6 4 points 3 comments -> [Are Young People Having Enough Sex?](https://www.newyorker.com/magazine/2025/06/30/the-case-against-the-sexual-revolution-louise-perry-book-review-the-second-coming-carter-sherman)<!-- HN:44439730:end --><!-- HN:44440419:start -->
* [44440419](https://news.social-protocols.org/stats?id=44440419) #2 8 points 2 comments -> [Working too much? EU law says you're entitled to more rest.:)](https://nureti.com/blog/things-you-did-not-know-eu-time-directive/)<!-- HN:44440419:end --><!-- HN:44440464:start -->
* [44440464](https://news.social-protocols.org/stats?id=44440464) #10 10 points 0 comments -> [The first American 'scientific refugees' arrive in France](https://www.politico.eu/article/meet-first-academic-refugees-fleeing-us-france-science-program/)<!-- HN:44440464:end --><!-- HN:44440362:start -->
* [44440362](https://news.social-protocols.org/stats?id=44440362) #30 9 points 3 comments -> [Why Big Tech Turned Against Democrats – and Democracy](https://paulkrugman.substack.com/p/why-big-tech-turned-against-democrats)<!-- HN:44440362:end --><!-- HN:44440556:start -->
* [44440556](https://news.social-protocols.org/stats?id=44440556) #16 6 points 1 comments -> [Hydrogen sulphide gas restricts SARS-CoV-2 replication in host cells](https://iisc.ac.in/hydrogen-sulphide-gas-restricts-sars-cov-2-replication-in-host-cells/)<!-- HN:44440556:end --><!-- HN:44442020:start -->
* [44442020](https://news.social-protocols.org/stats?id=44442020) #30 3 points 1 comments -> [Gemini mirrored the user. Claude said "I love you." We recorded the drift](https://drive.proton.me/urls/QZQ6QN5AVM#xp94MAFlT8gD)<!-- HN:44442020:end --><!-- HN:44444556:start -->
* [44444556](https://news.social-protocols.org/stats?id=44444556) #12 16 points 10 comments -> [Ruby on Rails: The Open-Source Blueprint](https://blog.codeminer42.com/ruby-on-rails-the-open-source-blueprint/)<!-- HN:44444556:end --><!-- HN:44445042:start -->
* [44445042](https://news.social-protocols.org/stats?id=44445042) #29 20 points 12 comments -> [Show HN: I built an AI comic generator with consistent characters](https://www.glimora.ai)<!-- HN:44445042:end -->
#### **Thursday, July 3, 2025**<!-- HN:44452140:start -->
* [44452140](https://news.social-protocols.org/stats?id=44452140) #27 9 points 6 comments -> [We reimagined Transformer architectures inspired by nature's hidden structures](https://ieeexplore.ieee.org/document/10754699)<!-- HN:44452140:end --><!-- HN:44450937:start -->
* [44450937](https://news.social-protocols.org/stats?id=44450937) #20 29 points 40 comments -> [LLMs as Compilers](https://resync-games.com/blog/engineering/llms-as-compiler)<!-- HN:44450937:end --><!-- HN:44453527:start -->
* [44453527](https://news.social-protocols.org/stats?id=44453527) #8 4 points 0 comments -> [Far-Right Extremists Use Minecraft to Gamify Radicalisation](https://gnet-research.org/2025/07/02/playing-with-hate-how-far-right-extremists-use-minecraft-to-gamify-radicalisation/)<!-- HN:44453527:end --><!-- HN:44454147:start -->
* [44454147](https://news.social-protocols.org/stats?id=44454147) #29 9 points 1 comments -> [How Microsoft became a hub for Israeli intelligence](https://thegrayzone.com/2025/05/23/microsoft-hub-israeli-intel/)<!-- HN:44454147:end --><!-- HN:44453317:start -->
* [44453317](https://news.social-protocols.org/stats?id=44453317) #23 6 points 0 comments -> [How I keep up with AI progress (and why you must too)](https://blog.nilenso.com/blog/2025/06/23/how-i-keep-up-with-ai-progress/)<!-- HN:44453317:end --><!-- HN:44456389:start -->
* [44456389](https://news.social-protocols.org/stats?id=44456389) #10 37 points 29 comments -> [EBAF – eBPF Based Ad Firewall](https://github.com/Kazedaa/eBAF)<!-- HN:44456389:end --><!-- HN:44457949:start -->
* [44457949](https://news.social-protocols.org/stats?id=44457949) #29 5 points 0 comments -> [Samsung delays $44B Texas chip fab – sources: 'there are no customers'](https://www.tomshardware.com/tech-industry/semiconductors/samsung-delays-usd44-billion-texas-chip-fab-sources-say-completion-halted-because-there-are-no-customers)<!-- HN:44457949:end -->
#### **Friday, July 4, 2025**
<!-- HN:44461158:start -->
* [44461158](https://news.social-protocols.org/stats?id=44461158) #13 49 points 26 comments -> [White House claims expansive power to nullify TikTok ban and other laws](https://www.nytimes.com/2025/07/03/us/politics/trump-bondi-tiktok-executive-power.html)<!-- HN:44461158:end --><!-- HN:44461368:start -->
* [44461368](https://news.social-protocols.org/stats?id=44461368) #30 36 points 13 comments -> [Google says "not a security vulnerability", quickly fixes without attribution](https://groups.google.com/g/certificate-transparency/c/u8SsXgSFbz4/m/CThyzj-QBAAJ)<!-- HN:44461368:end --><!-- HN:44462361:start -->
* [44462361](https://news.social-protocols.org/stats?id=44462361) #9 6 points 0 comments -> [Show HN: Soham Agent – Write cold emails like Soham Parekh](https://buildthatidea.com/sohamagent/6c604d4f-caac-475f-b489-d568210f905a)<!-- HN:44462361:end --><!-- HN:44466737:start -->
* [44466737](https://news.social-protocols.org/stats?id=44466737) #2 12 points 0 comments -> [There's No Undo Button for Our Fallen Democracy](https://kottke.org/25/07/theres-no-undo-button-for-our-fallen-democracy)<!-- HN:44466737:end --><!-- HN:44468083:start -->
* [44468083](https://news.social-protocols.org/stats?id=44468083) #21 30 points 16 comments -> [Tesla's Cybertruck flop is historic. The brand collapse is even worse](https://www.dailykos.com/stories/2025/7/3/2331384/-Tesla-s-Cybertruck-flop-is-historic-The-brand-collapse-is-even-worse)<!-- HN:44468083:end -->
#### **Saturday, July 5, 2025**
<!-- HN:44466896:start -->
* [44466896](https://news.social-protocols.org/stats?id=44466896) #9 124 points 4 comments -> [Eight dormant Satoshi-era Bitcoin wallets reactivated after 14 yrs](https://twitter.com/WatcherGuru/status/1941167512491864554)<!-- HN:44466896:end --><!-- HN:44432215:start -->
* [44432215](https://news.social-protocols.org/stats?id=44432215) #17 12 points 0 comments -> [Show HN: Semcheck – AI Tool for checking implementation follows spec](https://github.com/rejot-dev/semcheck)<!-- HN:44432215:end --><!-- HN:44469798:start -->
* [44469798](https://news.social-protocols.org/stats?id=44469798) #16 32 points 16 comments -> [Amiga Linux (1993)](https://groups.google.com/g/comp.sys.amiga.emulations/c/xUgrpylQOXk)<!-- HN:44469798:end --><!-- HN:44470803:start -->
* [44470803](https://news.social-protocols.org/stats?id=44470803) #12 49 points 17 comments -> [French City of Lyon Kicks Out Microsoft](https://news.itsfoss.com/french-city-replaces-microsoft/)<!-- HN:44470803:end --><!-- HN:44471861:start -->
* [44471861](https://news.social-protocols.org/stats?id=44471861) #27 5 points 1 comments -> [Cars' Forward Blind Zones Are Worse Now Than 25 Years Ago](https://www.caranddriver.com/news/a65219830/car-blind-zones-study-iihs/)<!-- HN:44471861:end -->