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

#### **Saturday, November 30, 2024**
<!-- HN:42277963:start -->
* [42277963](https://news.social-protocols.org/stats?id=42277963) #22 80 points 101 comments -> [The Engagement Is Better on Bluesky](https://bsky.social/about/blog/11-29-2024-engagement)<!-- HN:42277963:end --><!-- HN:42277931:start -->
* [42277931](https://news.social-protocols.org/stats?id=42277931) #11 20 points 4 comments -> [Bluesky intends their indexing to be used by third parties](https://write.as/ulrikehahn/bridging-to-bluesky-the-open-social-web-consent-and-gdpr)<!-- HN:42277931:end --><!-- HN:42276700:start -->
* [42276700](https://news.social-protocols.org/stats?id=42276700) #14 29 points 8 comments -> [Australian Online Safety Amendment (Social Media Minimum Age) Bill 2024](https://www.aph.gov.au/Parliamentary_Business/Bills_Legislation/Bills_Search_Results/Result?bId=r7284)<!-- HN:42276700:end --><!-- HN:42275919:start -->
* [42275919](https://news.social-protocols.org/stats?id=42275919) #13 105 points 58 comments -> [Simple Sabotage for the 21st Century – Specific Suggestions](https://specificsuggestions.com)<!-- HN:42275919:end --><!-- HN:42244482:start -->
* [42244482](https://news.social-protocols.org/stats?id=42244482) #14 121 points 26 comments -> [Prioritize work at the task level](https://developer.apple.com/library/archive/documentation/Performance/Conceptual/power_efficiency_guidelines_osx/PrioritizeWorkAtTheTaskLevel.html)<!-- HN:42244482:end --><!-- HN:42273966:start -->
* [42273966](https://news.social-protocols.org/stats?id=42273966) #16 70 points 19 comments -> [How We Got the Lithium-Ion Battery](https://www.construction-physics.com/p/how-we-got-the-lithium-ion-battery)<!-- HN:42273966:end --><!-- HN:42278160:start -->
* [42278160](https://news.social-protocols.org/stats?id=42278160) #19 26 points 37 comments -> [TfL abandons plans for driverless tube trains](https://www.ianvisits.co.uk/articles/tfl-abandons-plans-for-driverless-tube-trains-77435/)<!-- HN:42278160:end --><!-- HN:42244409:start -->
* [42244409](https://news.social-protocols.org/stats?id=42244409) #25 51 points 35 comments -> [Rust: Tools (early access edition)](https://bitfieldconsulting.com/books/rust-tools)<!-- HN:42244409:end --><!-- HN:42275834:start -->
* [42275834](https://news.social-protocols.org/stats?id=42275834) #15 133 points 60 comments -> [Chinese pebble-bed nuclear reactor passes "meltdown" test](https://www.ans.org/news/article-6241/china-pebblebed-reactor-passes-meltdown-test/)<!-- HN:42275834:end --><!-- HN:42278617:start -->
* [42278617](https://news.social-protocols.org/stats?id=42278617) #13 22 points 0 comments -> [Virtual Geometry in Bevy 0.15](https://jms55.github.io/posts/2024-11-14-virtual-geometry-bevy-0-15/)<!-- HN:42278617:end --><!-- HN:42276078:start -->
* [42276078](https://news.social-protocols.org/stats?id=42276078) #12 -> [Calmy Leon – The Ultimate Relaxing Music and Sound Generator](https://calmyleon.com/)<!-- HN:42276078:end --><!-- HN:42279521:start -->
* [42279521](https://news.social-protocols.org/stats?id=42279521) #15 10 points 8 comments -> ['Switches' are turning handguns into machine guns on Ontario streets](https://www.cbc.ca/lite/story/1.7389625)<!-- HN:42279521:end --><!-- HN:42280641:start -->
* [42280641](https://news.social-protocols.org/stats?id=42280641) #11 7 points 4 comments -> [Formance – The Color of Money: Towards a New Data Model for Fintech, Part II](https://www.formance.com/blog/engineering/color-of-money)<!-- HN:42280641:end --><!-- HN:42249801:start -->
* [42249801](https://news.social-protocols.org/stats?id=42249801) #8 15 points 3 comments -> [California scientists accidentally find nuclear fever dream in Arctic snow](https://www.sfgate.com/bayarea/article/california-researchers-abandoned-military-site-19944337.php)<!-- HN:42249801:end --><!-- HN:42281066:start -->
* [42281066](https://news.social-protocols.org/stats?id=42281066) #21 52 points 77 comments -> [Tesla is looking to hire a team to remotely control its 'self-driving' robotaxis](https://gizmodo.com/tesla-is-looking-to-hire-a-team-to-remotely-control-its-self-driving-robotaxis-2000530600)<!-- HN:42281066:end --><!-- HN:42280865:start -->
* [42280865](https://news.social-protocols.org/stats?id=42280865) #22 -> [Possible new ancient human species uncovered](https://www.hawaii.edu/news/2024/11/27/homo-juluensis-nature-communications/)<!-- HN:42280865:end --><!-- HN:42281470:start -->
* [42281470](https://news.social-protocols.org/stats?id=42281470) #23 8 points 0 comments -> [In C, memory management begins – The Craft of Coding](https://craftofcoding.wordpress.com/2024/11/25/in-c-memory-management-begins-immediately/)<!-- HN:42281470:end --><!-- HN:42281585:start -->
* [42281585](https://news.social-protocols.org/stats?id=42281585) #20 10 points 0 comments -> [What can we learn from the Andrew Tate data breach?](https://archive.org/details/tate_data_breach)<!-- HN:42281585:end --><!-- HN:42282020:start -->
* [42282020](https://news.social-protocols.org/stats?id=42282020) #1 5 points 4 comments -> [I made an AI specifically for teachers](https://assignly.app/)<!-- HN:42282020:end --><!-- HN:42254385:start -->
* [42254385](https://news.social-protocols.org/stats?id=42254385) #21 3 points 0 comments -> [M4 chips: Matrix processing and Power Modes](https://eclecticlight.co/2024/11/27/inside-m4-chips-matrix-processing-and-power-modes/)<!-- HN:42254385:end --><!-- HN:42282078:start -->
* [42282078](https://news.social-protocols.org/stats?id=42282078) #24 24 points 10 comments -> [Chinese researchers indicate diamonds can store data for millions of years](https://readwrite.com/chinese-researchers-indicate-diamonds-can-store-data-for-millions-of-years/)<!-- HN:42282078:end --><!-- HN:42224492:start -->
* [42224492](https://news.social-protocols.org/stats?id=42224492) #12 30 points 0 comments -> [A Reintroduction to Programming](https://www.0de5.net/explore)<!-- HN:42224492:end --><!-- HN:42283123:start -->
* [42283123](https://news.social-protocols.org/stats?id=42283123) #6 14 points 1 comments -> ['I couldn't stop watching': stories of how porn obsession takes over lives](https://www.bbc.com/news/articles/cg57r337rvzo)<!-- HN:42283123:end --><!-- HN:42283331:start -->
* [42283331](https://news.social-protocols.org/stats?id=42283331) #24 4 points 0 comments -> [Florida Man Who Spied on Verizon for China Gets 4 Years in Prison](https://gizmodo.com/florida-man-who-spied-on-verizon-for-china-gets-4-years-in-prison-2000529731)<!-- HN:42283331:end --><!-- HN:42282761:start -->
* [42282761](https://news.social-protocols.org/stats?id=42282761) #25 6 points 2 comments -> [NASA's X-59 plane is aiming for a sonic thump, not a boom](https://www.theregister.com/2024/11/30/nasa_x59_aircraft/)<!-- HN:42282761:end -->
#### **Sunday, December 1, 2024**
<!-- HN:42283949:start -->
* [42283949](https://news.social-protocols.org/stats?id=42283949) #8 -> [Bluesky Quadruples Moderation Team](https://mindmatters.ai/brief/x-competitor-bluesky-quadruples-moderation-team/)<!-- HN:42283949:end --><!-- HN:42285196:start -->
* [42285196](https://news.social-protocols.org/stats?id=42285196) #5 12 points 3 comments -> [We need data engineering benchmarks for LLMs](https://structuredlabs.substack.com/p/why-we-need-data-engineering-benchmarks)<!-- HN:42285196:end --><!-- HN:42212377:start -->
* [42212377](https://news.social-protocols.org/stats?id=42212377) #23 9 points 0 comments -> [Bodging GenServers Together](https://underjord.io/bodging-genservers-together.html)<!-- HN:42212377:end --><!-- HN:42254146:start -->
* [42254146](https://news.social-protocols.org/stats?id=42254146) #15 56 points 31 comments -> [IE7 and IE7 (2005)](https://meyerweb.com/eric/thoughts/2005/10/17/ie7-and-ie7/)<!-- HN:42254146:end --><!-- HN:42286306:start -->
* [42286306](https://news.social-protocols.org/stats?id=42286306) #26 5 points 1 comments -> [Day 1 – Advent of Code 2024](https://adventofcode.com/2024/day/1)<!-- HN:42286306:end --><!-- HN:42286133:start -->
* [42286133](https://news.social-protocols.org/stats?id=42286133) #13 90 points 83 comments -> [Education and Healthcare Suck for the Same Reasons](https://betterschooling.in/collection/education-and-healthcare-suck-here-s-how-we-can-change-that)<!-- HN:42286133:end --><!-- HN:42286035:start -->
* [42286035](https://news.social-protocols.org/stats?id=42286035) #18 53 points 19 comments -> [Canon ships its first nanoprint lithography machine, rivals ASML](https://www.datacenterdynamics.com/en/news/canon-ships-its-first-nanoprint-lithography-machine-rivals-asml/)<!-- HN:42286035:end --><!-- HN:42285467:start -->
* [42285467](https://news.social-protocols.org/stats?id=42285467) #25 41 points 7 comments -> [Office CMBS Delinquency Rate Spikes to 10.4%, Just Below Worst of GFC Meltdown](https://wolfstreet.com/2024/11/30/office-cmbs-delinquency-rate-spikes-to-10-4-just-below-worst-of-financial-crisis-cre-meltdown-fastest-2-year-spike-ever/)<!-- HN:42285467:end --><!-- HN:42287946:start -->
* [42287946](https://news.social-protocols.org/stats?id=42287946) #14 3 points 0 comments -> [ChatGPT Learned to Reason [video]](https://www.youtube.com/watch?v=PvDaPeQjxOE)<!-- HN:42287946:end --><!-- HN:42288372:start -->
* [42288372](https://news.social-protocols.org/stats?id=42288372) #3 30 points 3 comments -> [Advent of No-Code 2024](https://www.adventofnocode.io/)<!-- HN:42288372:end --><!-- HN:42288948:start -->
* [42288948](https://news.social-protocols.org/stats?id=42288948) #27 15 points 3 comments -> [America Got Mean](https://www.theatlantic.com/magazine/archive/2023/09/us-culture-moral-education-formation/674765/)<!-- HN:42288948:end --><!-- HN:42289143:start -->
* [42289143](https://news.social-protocols.org/stats?id=42289143) #5 6 points 2 comments -> [Show HN: Open-source widget to embed OpenAI Assistant on your website](https://github.com/widgetplatform/widget-oa)<!-- HN:42289143:end --><!-- HN:42290663:start -->
* [42290663](https://news.social-protocols.org/stats?id=42290663) #7 4 points 0 comments -> [Hiroshi Nagai: Japan's Sun-Drenched Americana](https://www.tokyocowboy.co/articles/uy1r8j003qdvb4ozr4qgplhd3yujyn)<!-- HN:42290663:end --><!-- HN:42290519:start -->
* [42290519](https://news.social-protocols.org/stats?id=42290519) #28 16 points 10 comments -> [Uber's Dark Descent: How Abandoning Innovation Hurt Drivers and Gouges Riders](https://viewfromthewing.com/uber-downward-spiral/)<!-- HN:42290519:end --><!-- HN:42291286:start -->
* [42291286](https://news.social-protocols.org/stats?id=42291286) #9 25 points 13 comments -> [The Imminence of the Destruction of the Space Program](https://robertvanwey.substack.com/p/the-imminence-of-the-destruction)<!-- HN:42291286:end --><!-- HN:42291365:start -->
* [42291365](https://news.social-protocols.org/stats?id=42291365) #30 6 points 1 comments -> ['Call of Duty: Modern Warfare' Rewrites the Highway of Death as a Russian Attack](https://www.newsweek.com/call-duty-modern-warfare-highway-death-russia-gulf-war-1468207)<!-- HN:42291365:end -->
#### **Monday, December 2, 2024**
<!-- HN:42292067:start -->
* [42292067](https://news.social-protocols.org/stats?id=42292067) #26 48 points 23 comments -> [Feds: Tether Has Become a Money Laundering Tool for Mexican Drug Trafficker](https://www.404media.co/tether-has-become-a-massive-money-laundering-tool-for-mexican-drug-traffickers-feds-say/)<!-- HN:42292067:end --><!-- HN:42292235:start -->
* [42292235](https://news.social-protocols.org/stats?id=42292235) #1 57 points 11 comments -> [ICP-Brasil: Mis-issued certificate](https://bugzilla.mozilla.org/show_bug.cgi?id=1934361)<!-- HN:42292235:end --><!-- HN:42292170:start -->
* [42292170](https://news.social-protocols.org/stats?id=42292170) #15 50 points 11 comments -> [Amazon Workers on Strike from Black Friday to Cyber Monday](https://www.wfxrtv.com/homepage-video/amazon-worker-strike-expected/)<!-- HN:42292170:end --><!-- HN:42257432:start -->
* [42257432](https://news.social-protocols.org/stats?id=42257432) #30 7 points 4 comments -> [Show HN: A program to learn phrases in multiple languages at once](https://fluent.monster/)<!-- HN:42257432:end --><!-- HN:42292204:start -->
* [42292204](https://news.social-protocols.org/stats?id=42292204) #20 40 points 14 comments -> [Discovery of CVE-2024-2550 (Palo Alto)](https://www.ac3.com.au/resources/discovery-of-CVE-2024-2550/)<!-- HN:42292204:end --><!-- HN:42262791:start -->
* [42262791](https://news.social-protocols.org/stats?id=42262791) #26 14 points 18 comments -> ['The Endless Refrain' asks: Do we even want new music anymore?](https://www.washingtonpost.com/books/2024/11/26/endless-refrain-nostalgia-music-david-rowell-review/)<!-- HN:42262791:end --><!-- HN:42290245:start -->
* [42290245](https://news.social-protocols.org/stats?id=42290245) #28 65 points 42 comments -> [IBM RISC System/6000 Family – Computer Ads from the Past](https://computeradsfromthepast.substack.com/p/ibm-risc-system6000-family)<!-- HN:42290245:end --><!-- HN:42248272:start -->
* [42248272](https://news.social-protocols.org/stats?id=42248272) #26 127 points 197 comments -> [Intel Gets Up to $7.9B Award for U.S. Chip-Plant Construction](https://www.wsj.com/tech/intel-gets-up-to-7-9-billion-award-for-u-s-chip-plant-construction-6c6818a1)<!-- HN:42248272:end --><!-- HN:42264595:start -->
* [42264595](https://news.social-protocols.org/stats?id=42264595) #17 5 points 1 comments -> [Gene behind orange fur in cats found at last](https://www.science.org/content/article/gene-behind-orange-fur-cats-found-last)<!-- HN:42264595:end --><!-- HN:42296228:start -->
* [42296228](https://news.social-protocols.org/stats?id=42296228) #30 11 points 27 comments -> [Carbon dioxide capture from open air using covalent organic frameworks](https://www.nature.com/articles/s41586-024-08080-x)<!-- HN:42296228:end --><!-- HN:42268307:start -->
* [42268307](https://news.social-protocols.org/stats?id=42268307) #18 16 points 74 comments -> [Bury me on the moon, preferably on the far side](https://www.scientificamerican.com/article/why-i-want-to-be-buried-on-the-moon/)<!-- HN:42268307:end --><!-- HN:42299687:start -->
* [42299687](https://news.social-protocols.org/stats?id=42299687) #7 10 points 4 comments -> [Natural soundscapes enhance mood recovery amid anthropogenic noise pollution](https://journals.plos.org/plosone/article?id=10.1371/journal.pone.0311487)<!-- HN:42299687:end -->
#### **Tuesday, December 3, 2024**
<!-- HN:42302342:start -->
* [42302342](https://news.social-protocols.org/stats?id=42302342) #25 27 points 12 comments -> [European Federation of Journalists to stop posting content on X](https://www.thelondoneconomic.com/news/media/european-federation-of-journalists-to-stop-posting-content-on-x-386598/)<!-- HN:42302342:end --><!-- HN:42304161:start -->
* [42304161](https://news.social-protocols.org/stats?id=42304161) #16 10 points 7 comments -> [Jaguar Introduces Type 00](https://www.jaguar.com/copy-nothing/jaguar-type-00.html)<!-- HN:42304161:end --><!-- HN:42303903:start -->
* [42303903](https://news.social-protocols.org/stats?id=42303903) #16 201 points 54 comments -> [No need to email me about Cisco AnyConnect](https://daniel.haxx.se/blog/2024/12/03/no-need-to-email-me-about-cisco-anyconnect/)<!-- HN:42303903:end --><!-- HN:42306261:start -->
* [42306261](https://news.social-protocols.org/stats?id=42306261) #27 26 points 9 comments -> [South Korea declares martial law](https://www.koreaherald.com/view.php?ud=20241203050117)<!-- HN:42306261:end --><!-- HN:42302963:start -->
* [42302963](https://news.social-protocols.org/stats?id=42302963) #19 225 points 99 comments -> [Twice-Yearly HIV Shot Shows 100% Effectiveness in Women](https://apnews.com/article/hiv-infections-aids-prevention-shot-02606f7d7892f0baf55bd0a0ff2ba3de)<!-- HN:42302963:end --><!-- HN:42303054:start -->
* [42303054](https://news.social-protocols.org/stats?id=42303054) #16 63 points 19 comments -> [Guile-Emacs Relaunched](https://emacsconf.org/2024/talks/guile/)<!-- HN:42303054:end --><!-- HN:42303111:start -->
* [42303111](https://news.social-protocols.org/stats?id=42303111) #15 211 points 125 comments -> [Raspberry Pi boosts Pi 5 performance with SDRAM tuning](https://www.jeffgeerling.com/blog/2024/raspberry-pi-boosts-pi-5-performance-sdram-tuning)<!-- HN:42303111:end --><!-- HN:42303274:start -->
* [42303274](https://news.social-protocols.org/stats?id=42303274) #17 224 points 146 comments -> [Blizzard's pulling of Warcraft I and II tests GOG's new Preservation Program](https://arstechnica.com/gaming/2024/12/blizzards-pulling-of-warcraft-i-ii-tests-gogs-new-preservation-program/)<!-- HN:42303274:end --><!-- HN:42307065:start -->
* [42307065](https://news.social-protocols.org/stats?id=42307065) #4 20 points 6 comments -> [AI Advent of Code: Implementing Papers](https://www.leetarxiv.com/)<!-- HN:42307065:end --><!-- HN:42308564:start -->
* [42308564](https://news.social-protocols.org/stats?id=42308564) #14 9 points 2 comments -> [America Stopped Cooking with Tallow for a Reason](https://www.theatlantic.com/health/archive/2024/12/beef-tallow-kennedy-cooking-fat-seed-oil/680848/)<!-- HN:42308564:end --><!-- HN:42308864:start -->
* [42308864](https://news.social-protocols.org/stats?id=42308864) #20 8 points 0 comments -> [Three years after opening, X Denver residents say the party is over](https://www.denverpost.com/2024/12/02/x-denver-apartments-union-station-update/)<!-- HN:42308864:end --><!-- HN:42308733:start -->
* [42308733](https://news.social-protocols.org/stats?id=42308733) #29 10 points 0 comments -> [South Korean Lawmakers Vote to Defy President, Demanding an End to Martial Law](https://www.nytimes.com/live/2024/12/03/world/south-korea-martial-law)<!-- HN:42308733:end --><!-- HN:42309560:start -->
* [42309560](https://news.social-protocols.org/stats?id=42309560) #19 14 points 3 comments -> [Christopher Hitchens and the Necessity of Universalism](https://salmagundi.skidmore.edu/articles/479-guest-column-christopher-hitchens-and-the-necessity-of-universalism)<!-- HN:42309560:end --><!-- HN:42287930:start -->
* [42287930](https://news.social-protocols.org/stats?id=42287930) #12 13 points 2 comments -> [Show HN: Simtown: A 2D Role-Playing Game Where Characters Talk, Move, and Act](https://app.simtown.ai/)<!-- HN:42287930:end --><!-- HN:42309010:start -->
* [42309010](https://news.social-protocols.org/stats?id=42309010) #1 127 points 3 comments -> [Intel Launches Arc B-Series Graphics Cards](https://www.intel.com/content/www/us/en/products/docs/discrete-gpus/arc/desktop/b-series/overview.html)<!-- HN:42309010:end --><!-- HN:42309742:start -->
* [42309742](https://news.social-protocols.org/stats?id=42309742) #16 22 points 6 comments -> [Webhooks Are Harder Than They Seem](https://www.svix.com/blog/webhooks-are-harder-than-they-seem/)<!-- HN:42309742:end --><!-- HN:42308348:start -->
* [42308348](https://news.social-protocols.org/stats?id=42308348) #26 59 points 17 comments -> [FTC Bans Location Data Company That Powers the Surveillance Ecosystem](https://www.404media.co/ftc-bans-location-data-company-that-powers-the-surveillance-ecosystem/)<!-- HN:42308348:end --><!-- HN:42311895:start -->
* [42311895](https://news.social-protocols.org/stats?id=42311895) #15 14 points 2 comments -> [Why Did Intel Fire CEO Pat Gelsinger?](https://www.semiaccurate.com/2024/12/03/why-did-intel-fire-ceo-pat-gelsinger/)<!-- HN:42311895:end -->
#### **Wednesday, December 4, 2024**
<!-- HN:42313450:start -->
* [42313450](https://news.social-protocols.org/stats?id=42313450) #9 3 points 1 comments -> [Andy Grove: Rich, Famous, Smart and Wrong (2007)](https://www.science.org/content/blog-post/andy-grove-rich-famous-smart-and-wrong)<!-- HN:42313450:end --><!-- HN:42311764:start -->
* [42311764](https://news.social-protocols.org/stats?id=42311764) #22 13 points 6 comments -> [Against 'Free Market Authoritarianism'](https://isonomiaquarterly.com/volume-2-issue-4/against-free-market-authoritarianism/)<!-- HN:42311764:end --><!-- HN:42235792:start -->
* [42235792](https://news.social-protocols.org/stats?id=42235792) #28 124 points 99 comments -> [The Curse of Markdown](https://codehike.org/blog/the-curse-of-markdown)<!-- HN:42235792:end --><!-- HN:42316398:start -->
* [42316398](https://news.social-protocols.org/stats?id=42316398) #12 13 points 1 comments -> [House panel concludes that Covid-19 pandemic came from a lab leak](https://www.science.org/content/article/house-panel-concludes-covid-19-pandemic-came-lab-leak)<!-- HN:42316398:end --><!-- HN:42313507:start -->
* [42313507](https://news.social-protocols.org/stats?id=42313507) #10 177 points 108 comments -> [No Nat November: My Month Without IPv4](https://blog.infected.systems/posts/2024-12-01-no-nat-november/)<!-- HN:42313507:end --><!-- HN:42315364:start -->
* [42315364](https://news.social-protocols.org/stats?id=42315364) #11 20 points 15 comments -> [Pinecone integrates AI inferencing with vector database](https://blocksandfiles.com/2024/12/02/pinecone-integrates-ai-inferencing-with-its-vector-database/)<!-- HN:42315364:end --><!-- HN:42255310:start -->
* [42255310](https://news.social-protocols.org/stats?id=42255310) #12 31 points 5 comments -> [Dark Mode in CSS Guide](https://css-tricks.com/a-complete-guide-to-dark-mode-on-the-web/)<!-- HN:42255310:end --><!-- HN:42312277:start -->
* [42312277](https://news.social-protocols.org/stats?id=42312277) #15 109 points 27 comments -> [A new home for Python-build-standalone](https://astral.sh/blog/python-build-standalone)<!-- HN:42312277:end --><!-- HN:42310683:start -->
* [42310683](https://news.social-protocols.org/stats?id=42310683) #16 128 points 178 comments -> [Stephen King to shut down his 3 radio stations in Maine](https://www.nytimes.com/2024/12/03/arts/stephen-king-maine-radio-stations.html)<!-- HN:42310683:end --><!-- HN:42305348:start -->
* [42305348](https://news.social-protocols.org/stats?id=42305348) #15 252 points 245 comments -> [Dependency management fatigue, or why I ditched React for Go+HTMX+Templ](https://blog.erodriguez.de/dependency-management-fatigue-or-why-i-forever-ditched-react-for-go-htmx-templ/)<!-- HN:42305348:end --><!-- HN:42311828:start -->
* [42311828](https://news.social-protocols.org/stats?id=42311828) #16 73 points 18 comments -> [Creating a Proxmox or QEMU ChromeOS Flex VM](https://kevindavid.org/code/2024/03/20/chrome-os-flex-proxmox.html)<!-- HN:42311828:end --><!-- HN:42314024:start -->
* [42314024](https://news.social-protocols.org/stats?id=42314024) #20 136 points 7 comments -> [EmacsConf 2024](https://emacsconf.org/2024/)<!-- HN:42314024:end --><!-- HN:42315969:start -->
* [42315969](https://news.social-protocols.org/stats?id=42315969) #26 49 points 3 comments -> [You're Breathtaking [Godot #100000]](https://github.com/godotengine/godot/issues/100000)<!-- HN:42315969:end --><!-- HN:42317698:start -->
* [42317698](https://news.social-protocols.org/stats?id=42317698) #9 10 points 1 comments -> [CEO of UnitedHealthcare Is Killed in Midtown Manhattan](https://www.nytimes.com/2024/12/04/nyregion/shooting-midtown-nyc-united-healthcare-brian-thompson.html)<!-- HN:42317698:end --><!-- HN:42288441:start -->
* [42288441](https://news.social-protocols.org/stats?id=42288441) #19 3 points 0 comments -> [Ephemeral Resource Configuration Reference](https://developer.hashicorp.com/terraform/language/v1.10.x/resources/ephemeral)<!-- HN:42288441:end --><!-- HN:42317511:start -->
* [42317511](https://news.social-protocols.org/stats?id=42317511) #3 6 points 1 comments -> [How to look out for yourself inside a particular company (2018)](https://rachelbythebay.com/w/2018/03/21/next/)<!-- HN:42317511:end --><!-- HN:42317991:start -->
* [42317991](https://news.social-protocols.org/stats?id=42317991) #23 20 points 23 comments -> [Telegram U-turns and joins child safety scheme](https://www.bbc.com/news/articles/c5yd35l0r91o)<!-- HN:42317991:end --><!-- HN:42320015:start -->
* [42320015](https://news.social-protocols.org/stats?id=42320015) #11 3 points 1 comments -> [The Planning Machine (2014)](https://www.newyorker.com/magazine/2014/10/13/planning-machine)<!-- HN:42320015:end --><!-- HN:42261953:start -->
* [42261953](https://news.social-protocols.org/stats?id=42261953) #14 7 points 1 comments -> [Quantum scars make their mark in graphene](https://www.nature.com/articles/d41586-024-03649-y)<!-- HN:42261953:end --><!-- HN:42319041:start -->
* [42319041](https://news.social-protocols.org/stats?id=42319041) #29 21 points 12 comments -> [Pisces: UK regulated market for private shares [pdf]](https://assets.publishing.service.gov.uk/media/67374daf12f25d730812722c/PISCES_consultation_response_November_2024_vf.pdf)<!-- HN:42319041:end -->
#### **Thursday, December 5, 2024**
<!-- HN:42323235:start -->
* [42323235](https://news.social-protocols.org/stats?id=42323235) #23 75 points 45 comments -> [Deploying Containers on NixOS: A Guide](https://bkiran.com/blog/deploying-containers-nixos)<!-- HN:42323235:end --><!-- HN:42325697:start -->
* [42325697](https://news.social-protocols.org/stats?id=42325697) #6 9 points 1 comments -> [Bitcoin Hits a Milestone: $100k](https://www.nytimes.com/2024/12/04/technology/bitcoin-price-record.html)<!-- HN:42325697:end --><!-- HN:42285206:start -->
* [42285206](https://news.social-protocols.org/stats?id=42285206) #22 56 points 66 comments -> [A made-up name is better than no name](https://mbuffett.com/posts/a-made-up-name)<!-- HN:42285206:end --><!-- HN:42299042:start -->
* [42299042](https://news.social-protocols.org/stats?id=42299042) #18 30 points 38 comments -> [Why are doctors wary of wearables?](https://www.bbc.com/news/articles/c79zpzdv4vno)<!-- HN:42299042:end --><!-- HN:42325922:start -->
* [42325922](https://news.social-protocols.org/stats?id=42325922) #6 5 points 0 comments -> [Amnesty change genocide definition in order to attack Israel](https://twitter.com/MarkGoldfeder/status/1864494075220509115)<!-- HN:42325922:end --><!-- HN:42326287:start -->
* [42326287](https://news.social-protocols.org/stats?id=42326287) #26 7 points 3 comments -> [Bitcoin surges past $100k for first time](https://www.bbc.co.uk/news/articles/cqj0wkwv1x2o)<!-- HN:42326287:end --><!-- HN:42249474:start -->
* [42249474](https://news.social-protocols.org/stats?id=42249474) #5 25 points 15 comments -> [Licking this "lollipop" will let you taste virtual flavors](https://arstechnica.com/science/2024/11/licking-this-lollipop-will-let-you-taste-virtual-flavors/)<!-- HN:42249474:end --><!-- HN:42327005:start -->
* [42327005](https://news.social-protocols.org/stats?id=42327005) #17 21 points 40 comments -> [How close is AI to human-level intelligence?](https://www.nature.com/articles/d41586-024-03905-1)<!-- HN:42327005:end --><!-- HN:42326346:start -->
* [42326346](https://news.social-protocols.org/stats?id=42326346) #27 6 points 3 comments -> [Building HTML in Go](https://templ.guide/)<!-- HN:42326346:end --><!-- HN:42328851:start -->
* [42328851](https://news.social-protocols.org/stats?id=42328851) #18 -> [It's Time to Defend Ourselves in Space](https://medium.com/@ToryBrunoULA/its-time-to-defend-ourselves-in-space-69608ab3da8f)<!-- HN:42328851:end --><!-- HN:42331341:start -->
* [42331341](https://news.social-protocols.org/stats?id=42331341) #14 15 points 1 comments -> [US West Coast Tsunami Warning](https://www.tsunami.gov/events/PAAQ/2024/12/05/so1aq0/1/WEAK51/WEAK51.txt)<!-- HN:42331341:end -->