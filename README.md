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

#### **Tuesday, June 24, 2025**
<!-- HN:44361130:start -->
* [44361130](https://news.social-protocols.org/stats?id=44361130) #23 28 points 41 comments -> [How many PhDs does world need? Doctoral graduates outnumber academia jobs](https://www.nature.com/articles/d41586-025-01855-w)<!-- HN:44361130:end --><!-- HN:44368811:start -->
* [44368811](https://news.social-protocols.org/stats?id=44368811) #22 11 points 4 comments -> [YouTube star Mikayla Raines dies by suicide, and her husband blames online abuse](https://www.nbcnews.com/news/obituaries/youtube-star-mikayla-raines-dies-suicide-29-husband-blames-online-abus-rcna214720)<!-- HN:44368811:end -->
#### **Wednesday, June 25, 2025**
<!-- HN:44372163:start -->
* [44372163](https://news.social-protocols.org/stats?id=44372163) #24 14 points 1 comments -> [Post-Attack Assessment of First 12 Days of Israeli Strikes on Iran Nuclear](https://isis-online.org/isis-reports/post-attack-assessment-of-the-first-12-days-of-israeli-strikes-on-iranian-nuclear-facilities)<!-- HN:44372163:end --><!-- HN:44372767:start -->
* [44372767](https://news.social-protocols.org/stats?id=44372767) #10 17 points 14 comments -> [Sorry, macOS Tahoe Beta 2 Still Does the Finder Icon Dirty](https://512pixels.net/2025/06/finder-icon-fixed/)<!-- HN:44372767:end --><!-- HN:44336577:start -->
* [44336577](https://news.social-protocols.org/stats?id=44336577) #19 8 points 0 comments -> [Controversial Plant Propagation Hack That Has Gardeners Divided](https://www.bhg.com/what-is-proplifting-11753036)<!-- HN:44336577:end --><!-- HN:44373754:start -->
* [44373754](https://news.social-protocols.org/stats?id=44373754) #3 68 points 27 comments -> [Gemini CLI: your open-source AI agent](https://blog.google/technology/developers/introducing-gemini-cli/)<!-- HN:44373754:end --><!-- HN:44376398:start -->
* [44376398](https://news.social-protocols.org/stats?id=44376398) #4 23 points 42 comments -> [Kid gamers to adult gamblers? Investigation of childhood gaming and YA gambling](https://www.tandfonline.com/doi/full/10.1080/14459795.2025.2488867)<!-- HN:44376398:end --><!-- HN:44373504:start -->
* [44373504](https://news.social-protocols.org/stats?id=44373504) #2 545 points 1 comments -> [A new PNG spec](https://www.programmax.net/articles/png-is-back/)<!-- HN:44373504:end --><!-- HN:44377031:start -->
* [44377031](https://news.social-protocols.org/stats?id=44377031) #4 32 points 1 comments -> [Gemini CLI: your open-source AI agent](https://blog.google/technology/developers/introducing-gemini-cli-open-source-ai-agent/)<!-- HN:44377031:end --><!-- HN:44376530:start -->
* [44376530](https://news.social-protocols.org/stats?id=44376530) #22 31 points 5 comments -> [Disposable E-Cigarettes More Toxic Than Traditional Cigarettes](https://www.ucdavis.edu/news/disposable-e-cigarettes-more-toxic-traditional-cigarettes)<!-- HN:44376530:end --><!-- HN:44380541:start -->
* [44380541](https://news.social-protocols.org/stats?id=44380541) #26 9 points 1 comments -> [Google removes fact checking from search results](https://developers.google.com/search/blog/2025/06/simplifying-search-results)<!-- HN:44380541:end --><!-- HN:44381302:start -->
* [44381302](https://news.social-protocols.org/stats?id=44381302) #24 7 points 1 comments -> [Broken by Design: Systemd](https://ewontfix.com/14/)<!-- HN:44381302:end --><!-- HN:44382519:start -->
* [44382519](https://news.social-protocols.org/stats?id=44382519) #13 11 points 5 comments -> [Why AGI Is Impossible](https://claude.ai/public/artifacts/445500b7-bb6b-4bf3-be9a-0fa4ee64c790)<!-- HN:44382519:end -->
#### **Thursday, June 26, 2025**
<!-- HN:44355003:start -->
* [44355003](https://news.social-protocols.org/stats?id=44355003) #17 15 points 2 comments -> [Introduction to error handling strategies in Go](https://go-monk.beehiiv.com/p/error-handling)<!-- HN:44355003:end --><!-- HN:44386328:start -->
* [44386328](https://news.social-protocols.org/stats?id=44386328) #29 5 points 2 comments -> [CC Signals: A New Social Contract for the Age of AI](https://creativecommons.org/2025/06/25/introducing-cc-signals-a-new-social-contract-for-the-age-of-ai/)<!-- HN:44386328:end --><!-- HN:44352990:start -->
* [44352990](https://news.social-protocols.org/stats?id=44352990) #24 9 points 2 comments -> [Low Overhead Allocation Sampling in a Garbage Collected Virtual Machine](https://arxiv.org/abs/2506.16883)<!-- HN:44352990:end --><!-- HN:44392414:start -->
* [44392414](https://news.social-protocols.org/stats?id=44392414) #26 4 points 0 comments -> [BBC to start charging US-based consumers for news and TV coverage](https://www.theguardian.com/media/2025/jun/26/bbc-usa-paid-subscription-news)<!-- HN:44392414:end -->
#### **Friday, June 27, 2025**
<!-- HN:44391711:start -->
* [44391711](https://news.social-protocols.org/stats?id=44391711) #25 65 points 43 comments -> [Senators reintroduce App Store bill to rein in 'gatekeeper power'](https://9to5mac.com/2025/06/25/senators-reintroduce-app-store-bill-to-rein-in-gatekeeper-power-in-the-app-economy/)<!-- HN:44391711:end --><!-- HN:44393270:start -->
* [44393270](https://news.social-protocols.org/stats?id=44393270) #24 9 points 0 comments -> [Canadian dies while in ICE custody in Florida, U.S. agency says](https://www.cbc.ca/lite/story/1.7571876)<!-- HN:44393270:end --><!-- HN:44392274:start -->
* [44392274](https://news.social-protocols.org/stats?id=44392274) #20 28 points 15 comments -> [Thomas Aquinas – The world is divine](https://ralphammer.com/thomas-aquinas-the-world-is-divine/)<!-- HN:44392274:end --><!-- HN:44393418:start -->
* [44393418](https://news.social-protocols.org/stats?id=44393418) #19 33 points 22 comments -> [Some thoughts on my first YC Demo Day](https://billchambers.me/articles/yc-demo-day-spring-25/)<!-- HN:44393418:end --><!-- HN:44391247:start -->
* [44391247](https://news.social-protocols.org/stats?id=44391247) #25 186 points 58 comments -> [A.I. Is Homogenizing Our Thoughts](https://www.newyorker.com/culture/infinite-scroll/ai-is-homogenizing-our-thoughts)<!-- HN:44391247:end --><!-- HN:44395523:start -->
* [44395523](https://news.social-protocols.org/stats?id=44395523) #2 29 points 24 comments -> [Echo Chamber: A Context-Poisoning Jailbreak That Bypasses LLM Guardrails](https://neuraltrust.ai/blog/echo-chamber-context-poisoning-jailbreak)<!-- HN:44395523:end --><!-- HN:44395602:start -->
* [44395602](https://news.social-protocols.org/stats?id=44395602) #14 23 points 27 comments -> [New IQ research shows why smarter people make better decisions](https://phys.org/news/2025-06-iq-smarter-people-decisions.html)<!-- HN:44395602:end --><!-- HN:44394085:start -->
* [44394085](https://news.social-protocols.org/stats?id=44394085) #26 9 points 0 comments -> [Timeline of US Class I Railroads Since 1977](https://en.wikipedia.org/wiki/Timeline_of_Class_I_railroads_(1977%E2%80%93present))<!-- HN:44394085:end --><!-- HN:44394208:start -->
* [44394208](https://news.social-protocols.org/stats?id=44394208) #15 50 points 41 comments -> [Apple Will Transition from the CTF to the CTC for EU Businesses](https://developer.apple.com/news/?id=awedznci)<!-- HN:44394208:end --><!-- HN:44398093:start -->
* [44398093](https://news.social-protocols.org/stats?id=44398093) #24 3 points 0 comments -> [Previously unknown 'loading dock' found inside human cells](https://newatlas.com/biology/organelle-human-cells/)<!-- HN:44398093:end --><!-- HN:44397962:start -->
* [44397962](https://news.social-protocols.org/stats?id=44397962) #30 3 points 0 comments -> [Why acetaminophen works: New discovery ends longstanding mystery](https://medicalxpress.com/news/2025-06-acetaminophen-discovery-longstanding-mystery.html)<!-- HN:44397962:end --><!-- HN:44398683:start -->
* [44398683](https://news.social-protocols.org/stats?id=44398683) #12 4 points 0 comments -> [People with Diabetes Are Cured in Small Trial of New Drug](https://www.nytimes.com/2025/06/20/health/diabetes-cure-insulin-stem-cell.html)<!-- HN:44398683:end --><!-- HN:44399040:start -->
* [44399040](https://news.social-protocols.org/stats?id=44399040) #12 6 points 0 comments -> [Blind spots on American cars are expanding](https://usa.streetsblog.org/2025/06/26/study-americas-blind-spots-are-expanding)<!-- HN:44399040:end --><!-- HN:44399280:start -->
* [44399280](https://news.social-protocols.org/stats?id=44399280) #20 9 points 1 comments -> [Supreme Court limits nationwide injunctions in birthright citizenship order](https://www.npr.org/2025/06/27/nx-s1-5435786/scotus-birthright-citizenship-universal-injunctions)<!-- HN:44399280:end --><!-- HN:44361326:start -->
* [44361326](https://news.social-protocols.org/stats?id=44361326) #18 12 points 0 comments -> [One Architect's Quest to Save Mumbai's Heritage from Disappearing](https://www.bloomberg.com/news/features/2025-06-18/architect-abha-narain-lambah-on-conserving-gateway-of-india-mumbai-heritage)<!-- HN:44361326:end --><!-- HN:44400011:start -->
* [44400011](https://news.social-protocols.org/stats?id=44400011) #24 3 points 1 comments -> [Tech CEO Pays $400k to Conduct the Toronto Symphony](https://www.nytimes.com/2025/06/27/arts/music/mandle-cheung-toronto-symphony-mahler.html)<!-- HN:44400011:end --><!-- HN:44400378:start -->
* [44400378](https://news.social-protocols.org/stats?id=44400378) #24 3 points 0 comments -> [Supreme Court overturns 5th Circuit ruling that upended Universal Service Fund](https://arstechnica.com/tech-policy/2025/06/supreme-court-saves-universal-service-fund-rules-fcc-fee-is-not-illegal-tax/)<!-- HN:44400378:end --><!-- HN:44399416:start -->
* [44399416](https://news.social-protocols.org/stats?id=44399416) #17 5 points 0 comments -> [Run Coverage on Tests](https://hugovk.dev/blog/2025/run-coverage-on-tests/)<!-- HN:44399416:end --><!-- HN:44400481:start -->
* [44400481](https://news.social-protocols.org/stats?id=44400481) #12 8 points 4 comments -> [You can now buy personally Human Attention for $5](https://momentarily.online/)<!-- HN:44400481:end -->
#### **Saturday, June 28, 2025**<!-- HN:44402887:start -->
* [44402887](https://news.social-protocols.org/stats?id=44402887) #12 16 points 2 comments -> [I will fix your vibe-coded MVP – sgnt.ai](https://sgnt.ai/p/vibe-coded/)<!-- HN:44402887:end --><!-- HN:44367640:start -->
* [44367640](https://news.social-protocols.org/stats?id=44367640) #8 9 points 3 comments -> [Show HN: La Touche Musicale PianoConvert](https://latouchemusicale.com/en/apps/pianoconvert/)<!-- HN:44367640:end --><!-- HN:44405655:start -->
* [44405655](https://news.social-protocols.org/stats?id=44405655) #5 3 points 2 comments -> [The American Dream Is Broken. This $50M Bet Could Help Rebuild It](https://denver-frederick.com/2025/06/24/the-american-dream-is-broken-this-50-million-bet-could-help-rebuild-it/)<!-- HN:44405655:end --><!-- HN:44406360:start -->
* [44406360](https://news.social-protocols.org/stats?id=44406360) #14 16 points 17 comments -> [Lima Site 85: How a CIA Helicopter Defended a Secret U.S. Radar Facility](https://www.aviacionline.com/lima-site-85-how-a-cia-helicopter-defended-a-secret-us-radar-facility)<!-- HN:44406360:end --><!-- HN:44406749:start -->
* [44406749](https://news.social-protocols.org/stats?id=44406749) #16 21 points 24 comments -> [BYU study: Why some people choose not to use artificial intelligence](https://news.byu.edu/intellect/byu-study-finds-the-real-reasons-why-some-people-choose-not-to-use-artificial-intelligence)<!-- HN:44406749:end --><!-- HN:44376075:start -->
* [44376075](https://news.social-protocols.org/stats?id=44376075) #24 17 points 11 comments -> [Show HN: A Go service that exposes a FIFO message queue in RAM](https://github.com/raiyanyahya/zapq)<!-- HN:44376075:end --><!-- HN:44346141:start -->
* [44346141](https://news.social-protocols.org/stats?id=44346141) #18 204 points 122 comments -> [Engineer creates ad block for the real world with augmented reality glasses](https://www.tomshardware.com/maker-stem/engineer-creates-ad-block-for-the-real-world-with-augmented-reality-glasses-no-more-products-or-branding-in-your-everyday-life)<!-- HN:44346141:end -->
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
* [44417846](https://news.social-protocols.org/stats?id=44417846) #14 -> [Manifold: An open-source tool to run AI models for 90% less](https://github.com/Esrbwt1/manifold)<!-- HN:44417846:end -->