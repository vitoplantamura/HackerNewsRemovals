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

#### **Friday, June 20, 2025**
<!-- HN:44323982:start -->
* [44323982](https://news.social-protocols.org/stats?id=44323982) #13 7 points 1 comments -> [Show HN: ATAC, an event verification platform evidence based](https://atac.seraum.com)<!-- HN:44323982:end --><!-- HN:44296659:start -->
* [44296659](https://news.social-protocols.org/stats?id=44296659) #18 8 points 1 comments -> [A real fixed-point decimal crate in Rust](https://github.com/WuBingzheng/primitive_fixed_point_decimal)<!-- HN:44296659:end --><!-- HN:44327270:start -->
* [44327270](https://news.social-protocols.org/stats?id=44327270) #30 3 points 0 comments -> [Attack on Oxford City Council exposes 21 years of election worker data](https://www.theregister.com/2025/06/20/oxford_city_council_breach/)<!-- HN:44327270:end --><!-- HN:44326545:start -->
* [44326545](https://news.social-protocols.org/stats?id=44326545) #13 38 points 35 comments -> [Wayland Is Growing Up. and Now We Don't Have a Choice](https://fireborn.mataroa.blog/blog/i-want-to-love-linux-it-doesnt-love-me-back-post-4-wayland-is-growing-up-and-now-we-dont-have-a-choice/)<!-- HN:44326545:end --><!-- HN:44327047:start -->
* [44327047](https://news.social-protocols.org/stats?id=44327047) #6 6 points 0 comments -> [Nuke Map](https://nuclearsecrecy.com/nukemap/)<!-- HN:44327047:end --><!-- HN:44328282:start -->
* [44328282](https://news.social-protocols.org/stats?id=44328282) #14 5 points 1 comments -> [Wanted: New Instruments to Fund BBNs](https://www.freaktakes.com/p/wanted-new-instruments-to-fund-bbns)<!-- HN:44328282:end --><!-- HN:44326997:start -->
* [44326997](https://news.social-protocols.org/stats?id=44326997) #26 25 points 30 comments -> [Telegram founder Durov says his 100 children will receive share of his estate](https://www.cnn.com/2025/06/20/tech/durov-100-children-inheritance-scli-intl)<!-- HN:44326997:end --><!-- HN:44328677:start -->
* [44328677](https://news.social-protocols.org/stats?id=44328677) #29 3 points 0 comments -> [Amazon under UK investigation over alleged failure to pay suppliers on time](https://www.theguardian.com/technology/2025/jun/20/amazon-uk-investigation-alleged-failure-to-pay-groceries-suppliers-on-time)<!-- HN:44328677:end --><!-- HN:44328373:start -->
* [44328373](https://news.social-protocols.org/stats?id=44328373) #28 16 points 40 comments -> [Rise in 'alert fatigue' risks phone users disabling news notifications](https://www.theguardian.com/media/2025/jun/20/increase-alert-fatigue-phone-users-disable-news-notifications-study-finds)<!-- HN:44328373:end --><!-- HN:44330107:start -->
* [44330107](https://news.social-protocols.org/stats?id=44330107) #3 5 points 2 comments -> [Most AI Chatbots Are Just Glorified Search Bars](https://www.kasp.chat/)<!-- HN:44330107:end --><!-- HN:44331405:start -->
* [44331405](https://news.social-protocols.org/stats?id=44331405) #27 3 points 0 comments -> [Amazon says it will reduce its workforce as AI replaces human employees](https://www.cnn.com/2025/06/17/business/amazon-ai-human-employees-jobs)<!-- HN:44331405:end --><!-- HN:44330422:start -->
* [44330422](https://news.social-protocols.org/stats?id=44330422) #2 33 points 38 comments -> [Microsoft Is Deleting Old Drivers from Windows Update and It Might Break Your PC](https://nerds.xyz/2025/06/microsoft-driver-removal-windows-update-legacy-hardware-breaking/)<!-- HN:44330422:end --><!-- HN:44330755:start -->
* [44330755](https://news.social-protocols.org/stats?id=44330755) #15 89 points 91 comments -> [Malicious AI swarms can threaten democracy](https://osf.io/preprints/osf/qm9yk_v2)<!-- HN:44330755:end --><!-- HN:44332205:start -->
* [44332205](https://news.social-protocols.org/stats?id=44332205) #16 9 points 1 comments -> [DocuSign sends Cease and Desist to free SaaS developer](https://twitter.com/AzianMike/status/1935671153076678983)<!-- HN:44332205:end --><!-- HN:44332049:start -->
* [44332049](https://news.social-protocols.org/stats?id=44332049) #29 6 points 6 comments -> [U.S. Wealth Distribution (Including Billionaires)](https://joshworth.com/dev/wealthgap/)<!-- HN:44332049:end -->
#### **Saturday, June 21, 2025**
<!-- HN:44332912:start -->
* [44332912](https://news.social-protocols.org/stats?id=44332912) #22 49 points 41 comments -> [Drinks in glass bottles contain more microplastics than those in other container](https://www.anses.fr/en/content/drinks-glass-bottles-contain-more-microplastics-those-other-containers)<!-- HN:44332912:end --><!-- HN:44333077:start -->
* [44333077](https://news.social-protocols.org/stats?id=44333077) #19 12 points 7 comments -> [AtomicOS – A security-first OS with real crypto and deterministic language](https://github.com/ipenas-cl/AtomicOs)<!-- HN:44333077:end --><!-- HN:44307388:start -->
* [44307388](https://news.social-protocols.org/stats?id=44307388) #16 30 points 40 comments -> [I Dropped the Production Database on a Friday Night](https://vince.beehiiv.com/p/how-i-dropped-the-production-database-on-a-friday-night)<!-- HN:44307388:end --><!-- HN:44333921:start -->
* [44333921](https://news.social-protocols.org/stats?id=44333921) #30 40 points 40 comments -> [Texas Sheriffs Crack Bitcoin ATM with Power Tools to Retrieve $32,000](https://decrypt.co/326308/texas-sheriffs-crack-bitcoin-atm-with-power-tools-to-retrieve-32000)<!-- HN:44333921:end --><!-- HN:44337114:start -->
* [44337114](https://news.social-protocols.org/stats?id=44337114) #30 4 points 2 comments -> [I've ditched HR to free my company from the DEI police](https://nypost.com/2025/06/20/opinion/ive-ditched-hr-to-free-my-company-from-the-dei-police/)<!-- HN:44337114:end --><!-- HN:44337383:start -->
* [44337383](https://news.social-protocols.org/stats?id=44337383) #20 9 points 1 comments -> [A White Nationalist Wrote a Law Paper Promoting Racist Views. Won Him an Award](https://www.nytimes.com/2025/06/21/us/white-supremacist-university-of-florida-paper.html)<!-- HN:44337383:end --><!-- HN:44339343:start -->
* [44339343](https://news.social-protocols.org/stats?id=44339343) #25 3 points 1 comments -> [XOR's Shader Arsenal: A collection of various tiny shaders](https://www.xordev.com/arsenal)<!-- HN:44339343:end -->
#### **Sunday, June 22, 2025**
<!-- HN:44333187:start -->
* [44333187](https://news.social-protocols.org/stats?id=44333187) #25 249 points 160 comments -> [Plastic bag bans and fees reduce harmful bag litter on shorelines](https://www.science.org/doi/10.1126/science.adp9274)<!-- HN:44333187:end --><!-- HN:44341462:start -->
* [44341462](https://news.social-protocols.org/stats?id=44341462) #10 13 points 5 comments -> [Publishing a Docker Container for MS Edit to the GitHub Container Registry](https://til.simonwillison.net/github/container-registry)<!-- HN:44341462:end --><!-- HN:44341678:start -->
* [44341678](https://news.social-protocols.org/stats?id=44341678) #19 260 points 2 comments -> [U.S. strikes Iran's nuclear facilities](https://www.axios.com/2025/06/21/us-strike-iran-nuclear-israel-trump)<!-- HN:44341678:end --><!-- HN:44315409:start -->
* [44315409](https://news.social-protocols.org/stats?id=44315409) #21 11 points 0 comments -> [Death to WYSIWYG!](https://ratfactor.com/htmlwarden/death-to-wysiwyg)<!-- HN:44315409:end --><!-- HN:44348857:start -->
* [44348857](https://news.social-protocols.org/stats?id=44348857) #2 -> [The Jumping Frenchmen of Maine](https://www.amusingplanet.com/2025/06/the-jumping-frenchmen-of-maine.html)<!-- HN:44348857:end --><!-- HN:44349655:start -->
* [44349655](https://news.social-protocols.org/stats?id=44349655) #16 8 points 0 comments -> [Lawrence Yun on the State of U.S. Housing Market](https://www.c-span.org/program/washington-journal/lawrence-yun-on-the-state-of-us-housing-market/661482)<!-- HN:44349655:end --><!-- HN:44349933:start -->
* [44349933](https://news.social-protocols.org/stats?id=44349933) #2 -> [AI API Prices are 90% Subsidized](https://tinyml.substack.com/p/the-unsustainable-economics-of-llm)<!-- HN:44349933:end --><!-- HN:44350437:start -->
* [44350437](https://news.social-protocols.org/stats?id=44350437) #9 27 points 3 comments -> [Wait, Why Is Israel Allowed to Have Nukes?](https://www.currentaffairs.org/news/wait-why-is-israel-allowed-to-have-nukes)<!-- HN:44350437:end --><!-- HN:44324735:start -->
* [44324735](https://news.social-protocols.org/stats?id=44324735) #14 4 points 7 comments -> [Our support ticket volume was overwhelming,so we built an AI to handle 80% of it](https://www.kasp.chat/)<!-- HN:44324735:end -->
#### **Monday, June 23, 2025**
<!-- HN:44351865:start -->
* [44351865](https://news.social-protocols.org/stats?id=44351865) #20 8 points 4 comments -> [Republican representative's ectopic pregnancy clashes with Florida abortion law](https://www.theguardian.com/us-news/2025/jun/22/kat-cammack-republican-florida-abortion-law-ectopic-pregnancy)<!-- HN:44351865:end --><!-- HN:44351310:start -->
* [44351310](https://news.social-protocols.org/stats?id=44351310) #28 15 points 7 comments -> [CF-Shield – An open source tool to protect any website with Cloudflare](https://github.com/Sakura-sx/cf-shield)<!-- HN:44351310:end --><!-- HN:44353184:start -->
* [44353184](https://news.social-protocols.org/stats?id=44353184) #24 4 points 0 comments -> [IDF data reveals 377,000 Palestinians unaccounted for](https://medium.com/@m4xim1l1an/the-grim-arithmetic-idf-data-reveals-377-000-palestinians-unaccounted-for-59f747490e61)<!-- HN:44353184:end --><!-- HN:44324319:start -->
* [44324319](https://news.social-protocols.org/stats?id=44324319) #26 6 points 2 comments -> [Encounters with Reality on Christine Rosen's the Extinction of Experience](https://thepointmag.com/criticism/encounters-with-reality/)<!-- HN:44324319:end --><!-- HN:44353408:start -->
* [44353408](https://news.social-protocols.org/stats?id=44353408) #18 29 points 15 comments -> [OpenAI and Jony Ive's "io" brand has disappeared](https://www.theverge.com/news/690858/jony-ive-openai-sam-altman-ai-hardware)<!-- HN:44353408:end --><!-- HN:44329556:start -->
* [44329556](https://news.social-protocols.org/stats?id=44329556) #23 7 points 4 comments -> [2048 in bash with only 64 bits of state](https://github.com/izabera/bitwise-challenge-2048)<!-- HN:44329556:end --><!-- HN:44354250:start -->
* [44354250](https://news.social-protocols.org/stats?id=44354250) #4 8 points 3 comments -> [Where is Iran's uranium? Questions remain over stash of enriched material](https://www.ft.com/content/12a864cc-eeb8-4725-aed8-5ddff9ac588e)<!-- HN:44354250:end --><!-- HN:44354684:start -->
* [44354684](https://news.social-protocols.org/stats?id=44354684) #26 28 points 34 comments -> [The Gender Attractiveness Gap](https://www.biorxiv.org/content/10.1101/2025.05.21.655261v1)<!-- HN:44354684:end --><!-- HN:44355438:start -->
* [44355438](https://news.social-protocols.org/stats?id=44355438) #26 4 points 1 comments -> [Men, Where Have You Gone? Please Come Back](https://www.nytimes.com/2025/06/20/style/modern-love-men-where-have-you-gone-please-come-back.html)<!-- HN:44355438:end --><!-- HN:44353760:start -->
* [44353760](https://news.social-protocols.org/stats?id=44353760) #18 11 points 0 comments -> [Real-world performance comparison of ebtree/cebtree/rbtree](http://wtarreau.blogspot.com/2025/06/real-world-performance-comparison-of.html)<!-- HN:44353760:end --><!-- HN:44355750:start -->
* [44355750](https://news.social-protocols.org/stats?id=44355750) #30 39 points 24 comments -> [Gov. Greg Abbott vetoes THC ban](https://www.texastribune.org/2025/06/22/texas-thc-ban-bill-greg-abbott-veto-senate-bill-3/)<!-- HN:44355750:end --><!-- HN:44356509:start -->
* [44356509](https://news.social-protocols.org/stats?id=44356509) #2 40 points 8 comments -> [Don't trust Cloudflare with your personal data](https://shkspr.mobi/blog/2020/09/dont-trust-cloudflare-with-your-personal-data/)<!-- HN:44356509:end --><!-- HN:44358625:start -->
* [44358625](https://news.social-protocols.org/stats?id=44358625) #16 12 points 5 comments -> [X blocked a paid user for no reason for "5-7 days" or forever](https://substack.com/home/post/p-166662797)<!-- HN:44358625:end -->
#### **Tuesday, June 24, 2025**
<!-- HN:44361130:start -->
* [44361130](https://news.social-protocols.org/stats?id=44361130) #23 28 points 41 comments -> [How many PhDs does world need? Doctoral graduates outnumber academia jobs](https://www.nature.com/articles/d41586-025-01855-w)<!-- HN:44361130:end --><!-- HN:44367539:start -->
* [44367539](https://news.social-protocols.org/stats?id=44367539) #13 3 points 0 comments -> [C compiler for Web Assembly (c4wa)](https://github.com/kign/c4wa)<!-- HN:44367539:end --><!-- HN:44368811:start -->
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
* [44355003](https://news.social-protocols.org/stats?id=44355003) #17 15 points 2 comments -> [Introduction to error handling strategies in Go](https://go-monk.beehiiv.com/p/error-handling)<!-- HN:44355003:end --><!-- HN:44351912:start -->
* [44351912](https://news.social-protocols.org/stats?id=44351912) #5 12 points 0 comments -> [The symbol of earthly good, and the immediate object of toil](https://crookedtimber.org/2025/06/23/the-symbol-of-earthly-good-and-the-immediate-object-of-toil/)<!-- HN:44351912:end -->