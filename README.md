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

#### **Thursday, January 22, 2026**
<!-- HN:46655274:start -->
* [46655274](https://news.social-protocols.org/stats?id=46655274) #26 5 points 1 comments -> [Show HN: An opinionated fork of micro, built for vibe coders who enjoy code](https://github.com/elleryfamilia/thicc)<!-- HN:46655274:end --><!-- HN:46718556:start -->
* [46718556](https://news.social-protocols.org/stats?id=46718556) #19 11 points 4 comments -> [I am moving away from Scala](https://arbuh.medium.com/why-i-am-moving-away-from-scala-7a9d3dca17b9)<!-- HN:46718556:end --><!-- HN:46721220:start -->
* [46721220](https://news.social-protocols.org/stats?id=46721220) #29 16 points 7 comments -> [Zack Polanski to hand in NHS contract termination notice to Palantir](https://www.thecanary.co/uk/news/2026/01/22/zack-polanski-to-hand-in-nhs-contract-termination-notice-to-palantir/)<!-- HN:46721220:end --><!-- HN:46724714:start -->
* [46724714](https://news.social-protocols.org/stats?id=46724714) #2 30 points 9 comments -> [Goldman Sachs Global Macro Research: Gen AI: too much spend, too little benefit [pdf]](https://www.goldmansachs.com/static-libs/pdf-redirect/prod/index.html?path=/images/migrated/insights/pages/gs-research/gen-ai--too-much-spend,-too-little-benefit-/TOM_AI%202.0_ForRedaction.pdf&originalQuery=&referrer=)<!-- HN:46724714:end --><!-- HN:46725618:start -->
* [46725618](https://news.social-protocols.org/stats?id=46725618) #27 4 points 1 comments -> [The Education of the Broligarchy](https://colossus.com/article/education-broligarchy-silicon-valley-canon/)<!-- HN:46725618:end --><!-- HN:46725982:start -->
* [46725982](https://news.social-protocols.org/stats?id=46725982) #21 4 points 0 comments -> [How to Find LinkedIn Profiles and Work Emails in 5 Minutes](https://crona.ai/blog/how-to-find-a-work-email-from-a-name-and-linkedin-2-step-workflow)<!-- HN:46725982:end --><!-- HN:46725284:start -->
* [46725284](https://news.social-protocols.org/stats?id=46725284) #6 23 points 13 comments -> [Capital One Strikes $5.15B Deal for Fintech Brex (YC W17)](https://www.wsj.com/finance/banking/capital-one-to-buy-fintech-brex-e2dacc67)<!-- HN:46725284:end -->
#### **Friday, January 23, 2026**
<!-- HN:46725522:start -->
* [46725522](https://news.social-protocols.org/stats?id=46725522) #9 45 points 17 comments -> [Viking Ship Museum in Denmark announces the discovery of the largest cog](https://www.medievalists.net/2025/12/medieval-ship-discovered-copenhagen/)<!-- HN:46725522:end --><!-- HN:46650627:start -->
* [46650627](https://news.social-protocols.org/stats?id=46650627) #11 14 points 1 comments -> [What Is Control Flow Analysis for Lambda Calculus? – Iowa Type Theory Commute](https://rss.buzzsprout.com/728558.rss)<!-- HN:46650627:end --><!-- HN:46661167:start -->
* [46661167](https://news.social-protocols.org/stats?id=46661167) #25 99 points 46 comments -> [My first year in sales as technical founder](https://www.fabiandietrich.com/blog/first-year-in-sales.html)<!-- HN:46661167:end --><!-- HN:46731546:start -->
* [46731546](https://news.social-protocols.org/stats?id=46731546) #5 15 points 7 comments -> [How to Leave Germany](https://allaboutberlin.com/guides/leaving-germany)<!-- HN:46731546:end --><!-- HN:46733127:start -->
* [46733127](https://news.social-protocols.org/stats?id=46733127) #10 51 points 13 comments -> [White House Posts Altered Photo Showing Arrested Minnesota Protester Crying](https://www.nytimes.com/2026/01/22/us/politics/nekima-armstrong-photo-white-house.html)<!-- HN:46733127:end --><!-- HN:46733025:start -->
* [46733025](https://news.social-protocols.org/stats?id=46733025) #22 36 points 41 comments -> [Is liberal democracy in terminal decline?](https://www.ft.com/content/b4d2c7a3-587d-440f-a7a9-7e5e85b93a88)<!-- HN:46733025:end --><!-- HN:46733803:start -->
* [46733803](https://news.social-protocols.org/stats?id=46733803) #2 49 points 13 comments -> [DOGE improperly accessed and shared Social Security data](https://blog.quintarelli.it/2026/01/how-doge-improperly-accessed-and-shared-social-security-data-npr/)<!-- HN:46733803:end --><!-- HN:46735406:start -->
* [46735406](https://news.social-protocols.org/stats?id=46735406) #23 3 points 0 comments -> [Show HN: Claude Tutor – an open source engineering tutor](https://twitter.com/michaelraspuzzi/status/2014756546195148988)<!-- HN:46735406:end -->
#### **Saturday, January 24, 2026**
<!-- HN:46739278:start -->
* [46739278](https://news.social-protocols.org/stats?id=46739278) #10 10 points 12 comments -> [OpenAI to Take a Percentage from Customer AI-Assisted R&D Outcomes](https://news.aibase.com/news/24859)<!-- HN:46739278:end --><!-- HN:46739439:start -->
* [46739439](https://news.social-protocols.org/stats?id=46739439) #23 23 points 3 comments -> [Over 600 Minnesota businesses close in protest of ICE operations](https://www.perplexity.ai/discover/you/trump-immigration-enforcement-l3O3OX48SMuW4LngN6jltQ)<!-- HN:46739439:end --><!-- HN:46675193:start -->
* [46675193](https://news.social-protocols.org/stats?id=46675193) #15 21 points 6 comments -> [If You Think This Instrument Is Hard to Play, Try Building One](https://www.nytimes.com/2026/01/14/arts/music/oboe-laubin-jim-phelan.html)<!-- HN:46675193:end --><!-- HN:46742250:start -->
* [46742250](https://news.social-protocols.org/stats?id=46742250) #11 34 points 12 comments -> [Repatriate the gold': German economists advise withdrawal from US vaults](https://www.theguardian.com/world/2026/jan/24/repatriate-the-gold-german-economists-advise-withdrawal-from-us-vaults)<!-- HN:46742250:end --><!-- HN:46745591:start -->
* [46745591](https://news.social-protocols.org/stats?id=46745591) #7 33 points 3 comments -> [Gmail Spam Detection Down](https://www.google.com/appsstatus/dashboard/incidents/NNnDkY9CJ36annsfytjQ?hl=en)<!-- HN:46745591:end --><!-- HN:46746521:start -->
* [46746521](https://news.social-protocols.org/stats?id=46746521) #25 8 points 1 comments -> [ICE Executes Arrestee](https://old.reddit.com/r/pics/comments/1qlr507/ice_pinning_down_and_pistol_whipping_a/)<!-- HN:46746521:end --><!-- HN:46746231:start -->
* [46746231](https://news.social-protocols.org/stats?id=46746231) #4 8 points 1 comments -> [Get-Shit-Done](https://github.com/glittercowboy/get-shit-done)<!-- HN:46746231:end -->
#### **Sunday, January 25, 2026**
<!-- HN:46668841:start -->
* [46668841](https://news.social-protocols.org/stats?id=46668841) #29 4 points 0 comments -> [Show HN: Show HN: I built a fail-closed watchdog for ESP32/Arduino in C++](https://github.com/weareqrystal/qrystal_uplink_sdks)<!-- HN:46668841:end --><!-- HN:46705134:start -->
* [46705134](https://news.social-protocols.org/stats?id=46705134) #23 24 points 40 comments -> [Microservices for the Benefits, Not the Hustle](https://wolfoliver.medium.com/the-purposes-of-microservices-4e5f373f4ea3)<!-- HN:46705134:end --><!-- HN:46748077:start -->
* [46748077](https://news.social-protocols.org/stats?id=46748077) #24 40 points 39 comments -> [I don't write code anymore – I sculpt it](https://www.jerpint.io/blog/2026-01-24-i-dont-write-code-anymore-i-sculpt-it/)<!-- HN:46748077:end --><!-- HN:46749873:start -->
* [46749873](https://news.social-protocols.org/stats?id=46749873) #20 6 points 0 comments -> [National Guard activated in Minneapolis after Border Patrol agent kills man](https://apnews.com/live/minneapolis-ice-shooting-updates-1-24-2026)<!-- HN:46749873:end --><!-- HN:46750166:start -->
* [46750166](https://news.social-protocols.org/stats?id=46750166) #21 9 points 1 comments -> [Federal agents shoot man dead in Minneapolis](https://www.ft.com/content/3d855ba7-3e96-4512-b34c-6ff87ade6c12)<!-- HN:46750166:end --><!-- HN:46750208:start -->
* [46750208](https://news.social-protocols.org/stats?id=46750208) #23 13 points 0 comments -> [Civil Resistance](https://en.wikipedia.org/wiki/Civil_resistance)<!-- HN:46750208:end --><!-- HN:46743154:start -->
* [46743154](https://news.social-protocols.org/stats?id=46743154) #30 505 points 299 comments -> [MS confirms it will give the FBI your Windows PC data encryption key if asked](https://www.windowscentral.com/microsoft/windows-11/microsoft-bitlocker-encryption-keys-give-fbi-legal-order-privacy-nightmare)<!-- HN:46743154:end --><!-- HN:46750927:start -->
* [46750927](https://news.social-protocols.org/stats?id=46750927) #29 -> [AI won't take your job. A guy with a $599 Mac Mini and Claude will](https://webmatrices.com/post/ai-won-t-take-your-job-a-guy-with-a-599-mac-mini-and-claude-will)<!-- HN:46750927:end --><!-- HN:46753566:start -->
* [46753566](https://news.social-protocols.org/stats?id=46753566) #5 16 points 8 comments -> [LLMs Don't Hallucinate – They Drift](https://figshare.com/articles/conference_contribution/Measuring_Fidelity_Decay_A_Framework_for_Semantic_Drift_and_Collapse/30422107?file=58969378)<!-- HN:46753566:end --><!-- HN:46706100:start -->
* [46706100](https://news.social-protocols.org/stats?id=46706100) #24 22 points 7 comments -> [I scanned 2,500 Hugging Face models for malware/issues. Here is the data](https://github.com/ArseniiBrazhnyk/Veritensor)<!-- HN:46706100:end --><!-- HN:46755124:start -->
* [46755124](https://news.social-protocols.org/stats?id=46755124) #13 12 points 0 comments -> [iceout.tech](https://iceout.tech/)<!-- HN:46755124:end --><!-- HN:46755638:start -->
* [46755638](https://news.social-protocols.org/stats?id=46755638) #12 6 points 1 comments -> [FR#150 – On ICE, Verification, and Presence as Harm](https://connectedplaces.online/reports/fr150-on-ice-verification-and-presence-as-harm/)<!-- HN:46755638:end --><!-- HN:46756564:start -->
* [46756564](https://news.social-protocols.org/stats?id=46756564) #19 24 points 3 comments -> [Videos Contradict U.S. Account of Minneapolis Shooting by Federal Agents](https://www.wsj.com/us-news/videos-contradict-u-s-account-of-minneapolis-shooting-by-federal-agents-fbe1e488)<!-- HN:46756564:end --><!-- HN:46757126:start -->
* [46757126](https://news.social-protocols.org/stats?id=46757126) #3 14 points 5 comments -> [The AI Revolution in Coding: Why I'm Ignoring the Prophets of Doom](https://codingismycraft.blog/index.php/2026/01/23/the-ai-revolution-in-coding-why-im-ignoring-the-prophets-of-doom/)<!-- HN:46757126:end --><!-- HN:46756288:start -->
* [46756288](https://news.social-protocols.org/stats?id=46756288) #8 12 points 5 comments -> [What Is Starlink Mesh? – Starlink Help Center](https://starlink.com/ca/support/article/57f4bd5c-4125-2210-8bb2-30c90b558b7b)<!-- HN:46756288:end --><!-- HN:46757967:start -->
* [46757967](https://news.social-protocols.org/stats?id=46757967) #20 4 points 1 comments -> ["Those rights don't count": Bovino says Pretti forfeited 2nd Amendment rights](https://www.salon.com/2026/01/25/those-rights-dont-count-bovino-says-pretti-forfeited-2nd-amendment-rights-in-fatal-shooting/)<!-- HN:46757967:end -->
#### **Monday, January 26, 2026**<!-- HN:46761219:start -->
* [46761219](https://news.social-protocols.org/stats?id=46761219) #7 22 points 1 comments -> [SF Microclimates](https://microclimates.solofounders.com/)<!-- HN:46761219:end --><!-- HN:46759850:start -->
* [46759850](https://news.social-protocols.org/stats?id=46759850) #14 14 points 5 comments -> [Show HN: A desktop app that blocks work when you bite your nails](https://github.com/cacoos/trackhands)<!-- HN:46759850:end --><!-- HN:46764284:start -->
* [46764284](https://news.social-protocols.org/stats?id=46764284) #2 28 points 40 comments -> [Show HN: Posts p/month more than doubled in the last year](https://petegoldsmith.com/2026/01/26/2026-01-26-show-hn-trends/)<!-- HN:46764284:end --><!-- HN:46764811:start -->
* [46764811](https://news.social-protocols.org/stats?id=46764811) #2 7 points 2 comments -> [The New Dark Ages](https://yabirgb.com/posts/dark-age/)<!-- HN:46764811:end --><!-- HN:46764789:start -->
* [46764789](https://news.social-protocols.org/stats?id=46764789) #11 -> [EU investigates Elon Musk's X over Grok AI sexual deepfakes](https://www.bbc.com/news/articles/clye99wg0y8o)<!-- HN:46764789:end --><!-- HN:46764650:start -->
* [46764650](https://news.social-protocols.org/stats?id=46764650) #17 8 points 5 comments -> [Anthropic Just Built a Competitor to Meta's $2B Acquisition in 10 Days](https://medium.com/activated-thinker/anthropic-just-built-a-competitor-to-metas-2b-acquisition-in-10-days-using-its-own-ai-d1ebc93eba64)<!-- HN:46764650:end --><!-- HN:46769789:start -->
* [46769789](https://news.social-protocols.org/stats?id=46769789) #27 12 points 1 comments -> [When Constitutional Guardrails Fail](https://bayesianpersuasion.com/posts/ice-constitutional-guardrails/)<!-- HN:46769789:end --><!-- HN:46772404:start -->
* [46772404](https://news.social-protocols.org/stats?id=46772404) #11 47 points 8 comments -> [Toy implementations of the 30 foundational papers recommended by Ilya Sutskever](https://github.com/pageman/sutskever-30-implementations)<!-- HN:46772404:end -->
#### **Tuesday, January 27, 2026**
<!-- HN:46773636:start -->
* [46773636](https://news.social-protocols.org/stats?id=46773636) #10 4 points 0 comments -> [Infamous Gang of 40 Leader Banned from Wikipedia](https://www.neutralpov.com/p/infamous-gang-of-40-leader-banned)<!-- HN:46773636:end --><!-- HN:46743865:start -->
* [46743865](https://news.social-protocols.org/stats?id=46743865) #18 8 points 4 comments -> [Why autosave is not recovery](https://zippers.dev/blog/why-savior-exists)<!-- HN:46743865:end --><!-- HN:46774777:start -->
* [46774777](https://news.social-protocols.org/stats?id=46774777) #17 86 points 2 comments -> [Heathrow Drops the Liquids Rule](https://flymag.com/heathrow-drops-the-liquids-rule-what-changes-at-lhr-and-how-close-the-u-s-really-is/)<!-- HN:46774777:end --><!-- HN:46720061:start -->
* [46720061](https://news.social-protocols.org/stats?id=46720061) #28 7 points 2 comments -> [Visualizing the Collatz Conjecture as a Phase Transition](https://mathinspector.com/papers/collatz-polynomial-entropy.html)<!-- HN:46720061:end --><!-- HN:46777448:start -->
* [46777448](https://news.social-protocols.org/stats?id=46777448) #3 43 points 7 comments -> [Is OpenAI Dead Yet?](https://isopenaideadyet.com/)<!-- HN:46777448:end --><!-- HN:46778276:start -->
* [46778276](https://news.social-protocols.org/stats?id=46778276) #2 -> [For Fascists, Hypocrisy Is a Virtue](https://kottke.org/25/03/for-fascists-hypocrisy-is-a-virtue)<!-- HN:46778276:end --><!-- HN:46778554:start -->
* [46778554](https://news.social-protocols.org/stats?id=46778554) #27 17 points 1 comments -> [Startup Incubator Y Combinator Cuts Canada from Countries Where It Will Invest](https://www.bloomberg.com/news/articles/2026-01-26/startup-incubator-y-combinator-cuts-canada-from-countries-where-it-will-invest)<!-- HN:46778554:end --><!-- HN:46780017:start -->
* [46780017](https://news.social-protocols.org/stats?id=46780017) #20 -> [Italians furious over deployment of ICE to bolster US security at Olympics](https://www.cnn.com/2026/01/27/europe/italy-ice-agents-security-olympics-intl)<!-- HN:46780017:end --><!-- HN:46780137:start -->
* [46780137](https://news.social-protocols.org/stats?id=46780137) #5 11 points 1 comments -> [US to send ICE agents to Winter Olympics, prompting Italian anger](https://www.bbc.com/news/articles/c5y29xzjdzvo)<!-- HN:46780137:end --><!-- HN:46783289:start -->
* [46783289](https://news.social-protocols.org/stats?id=46783289) #17 16 points 1 comments -> [Federal judge in Minnesota orders ICE director to appear in court](https://www.bbc.co.uk/news/live/c3ve67195gyt)<!-- HN:46783289:end --><!-- HN:46783943:start -->
* [46783943](https://news.social-protocols.org/stats?id=46783943) #12 6 points 0 comments -> [I have no mouth and I must scream at Black people: Scott Adams, 1957-2026](https://www.tcj.com/i-have-no-mouth-and-i-must-scream-at-black-people-scott-adams-1957-2026/)<!-- HN:46783943:end --><!-- HN:46783024:start -->
* [46783024](https://news.social-protocols.org/stats?id=46783024) #21 32 points 7 comments -> [One Human and One Agent = One Browser from Scratch](https://simonwillison.net/2026/Jan/27/one-human-one-agent-one-browser/)<!-- HN:46783024:end --><!-- HN:46785334:start -->
* [46785334](https://news.social-protocols.org/stats?id=46785334) #29 9 points 6 comments -> [Twin – The AI Company Builder](https://twin.so/)<!-- HN:46785334:end --><!-- HN:46699505:start -->
* [46699505](https://news.social-protocols.org/stats?id=46699505) #16 12 points 0 comments -> [Designing Forms That Don't Get in the Way](https://www.souravinsights.com/blog/on-designing-forms)<!-- HN:46699505:end --><!-- HN:46711159:start -->
* [46711159](https://news.social-protocols.org/stats?id=46711159) #22 83 points 13 comments -> [Flexible use of a multi-purpose tool by a cow](https://doi.org/10.1016/j.cub.2025.11.059)<!-- HN:46711159:end --><!-- HN:46713721:start -->
* [46713721](https://news.social-protocols.org/stats?id=46713721) #29 8 points 4 comments -> [Why are we still so afraid of using the grumpy old period?](https://www.nytimes.com/2026/01/15/magazine/ending-sentences-period.html)<!-- HN:46713721:end -->
#### **Wednesday, January 28, 2026**
<!-- HN:46753350:start -->
* [46753350](https://news.social-protocols.org/stats?id=46753350) #13 8 points 3 comments -> [Go 1.26 Is Around the Corner: Small Changes, Big Impact for Real-World Go System](https://medium.com/@anand.hv123/go-1-26-is-around-the-corner-small-changes-big-impact-for-real-world-go-systems-b7e5bd271f51)<!-- HN:46753350:end --><!-- HN:46790250:start -->
* [46790250](https://news.social-protocols.org/stats?id=46790250) #16 45 points 11 comments -> [Apple MacBook Pro order deliveries delayed until mid March](https://www.apple.com/shop/buy-mac/macbook-pro/16-inch-space-black-standard-display-apple-m4-max-with-16-core-cpu-and-40-core-gpu-48gb-memory-1tb)<!-- HN:46790250:end --><!-- HN:46790068:start -->
* [46790068](https://news.social-protocols.org/stats?id=46790068) #11 10 points 9 comments -> [Is coding dead because AI has taken over it?](https://www.jehuamanna.com/blog/2026/is-coding-dead/)<!-- HN:46790068:end -->