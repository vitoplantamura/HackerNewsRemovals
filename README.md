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

#### **Monday, January 19, 2026**<!-- HN:46674513:start -->
* [46674513](https://news.social-protocols.org/stats?id=46674513) #29 4 points 2 comments -> [In Minneapolis, a Pattern of Misconduct Toward Protesters](https://www.nytimes.com/2026/01/18/us/minneapolis-federal-agents-misconduct-protesters.html)<!-- HN:46674513:end --><!-- HN:46674976:start -->
* [46674976](https://news.social-protocols.org/stats?id=46674976) #28 14 points 5 comments -> [My thoughts on Gas Town after 10k hours of Claude Code](https://simonhartcher.com/posts/2026-01-19-my-thoughts-on-gas-town-after-10000-hours-of-claude-code/)<!-- HN:46674976:end --><!-- HN:46676991:start -->
* [46676991](https://news.social-protocols.org/stats?id=46676991) #13 31 points 16 comments -> [The Jolla Phone Proved We've Been Using Smartphones Wrong All Along](https://techglimmer.io/jolla-phone-2026-review-kill-switch-privacy-review/#Jolla)<!-- HN:46676991:end --><!-- HN:46677907:start -->
* [46677907](https://news.social-protocols.org/stats?id=46677907) #22 8 points 0 comments -> [Oxfam's wealth inequality report 2026: Resisting the Rule of the Rich](https://policy-practice.oxfam.org/resources/resisting-the-rule-of-the-rich-621776/)<!-- HN:46677907:end --><!-- HN:46677549:start -->
* [46677549](https://news.social-protocols.org/stats?id=46677549) #27 21 points 22 comments -> [Show HN: Kacet – a freelancer marketplace with crypto-native payments](https://kacet.com/)<!-- HN:46677549:end --><!-- HN:46678163:start -->
* [46678163](https://news.social-protocols.org/stats?id=46678163) #8 13 points 2 comments -> [Are you tired of AI stigma?](https://slopper.robot-future.com/)<!-- HN:46678163:end --><!-- HN:46679230:start -->
* [46679230](https://news.social-protocols.org/stats?id=46679230) #9 15 points 2 comments -> [Sweden deploys fighter jets to Iceland](https://www.sverigesradio.se/artikel/sverige-skickar-stridsflyg-till-island)<!-- HN:46679230:end --><!-- HN:46679515:start -->
* [46679515](https://news.social-protocols.org/stats?id=46679515) #23 10 points 4 comments -> [Idiocracy](https://pt.wikipedia.org/wiki/Idiocracy)<!-- HN:46679515:end --><!-- HN:46626441:start -->
* [46626441](https://news.social-protocols.org/stats?id=46626441) #17 68 points 17 comments -> [Vm0](https://github.com/vm0-ai/vm0)<!-- HN:46626441:end --><!-- HN:46680261:start -->
* [46680261](https://news.social-protocols.org/stats?id=46680261) #5 11 points 15 comments -> [Are You YES AI or No AI?](https://voteyesornoai.com)<!-- HN:46680261:end --><!-- HN:46673809:start -->
* [46673809](https://news.social-protocols.org/stats?id=46673809) #15 285 points 377 comments -> [Show HN: I quit coding years ago. AI brought me back](https://calquio.com)<!-- HN:46673809:end --><!-- HN:46682806:start -->
* [46682806](https://news.social-protocols.org/stats?id=46682806) #7 57 points 18 comments -> [US Places Arctic Airborne Troops on Standby as Greenland Dispute Escalates](https://www.thedefensenews.com/news-details/Pentagon-Places-1500-Arctic-Trained-Airborne-Troops-on-Standby-as-Greenland-Dispute-Escalates/)<!-- HN:46682806:end --><!-- HN:46683447:start -->
* [46683447](https://news.social-protocols.org/stats?id=46683447) #8 2 points 0 comments -> [The unreasonable effectiveness of pattern matching](https://arxiv.org/abs/2601.11432)<!-- HN:46683447:end --><!-- HN:46607969:start -->
* [46607969](https://news.social-protocols.org/stats?id=46607969) #27 55 points 62 comments -> [Two Concepts of Intelligence](https://cacm.acm.org/blogcacm/two-concepts-of-intelligence/)<!-- HN:46607969:end --><!-- HN:46684647:start -->
* [46684647](https://news.social-protocols.org/stats?id=46684647) #10 -> [Help Denmark Buy California – Because Why Not?](https://denmarkification.com/)<!-- HN:46684647:end --><!-- HN:46685325:start -->
* [46685325](https://news.social-protocols.org/stats?id=46685325) #7 13 points 0 comments -> [What Have Unions Done for Us?](https://whathaveunionsdoneforus.uk/)<!-- HN:46685325:end -->
#### **Tuesday, January 20, 2026**<!-- HN:46688787:start -->
* [46688787](https://news.social-protocols.org/stats?id=46688787) #1 10 points 4 comments -> [You did not vote for Him, but you helped Him win](https://eurodivergent.bearblog.dev/you-didnt-vote-for-him-but-you-helped-him-win/)<!-- HN:46688787:end --><!-- HN:46689143:start -->
* [46689143](https://news.social-protocols.org/stats?id=46689143) #7 64 points 2 comments -> [America Is Slow-Walking into a Polymarket Disaster](https://www.theatlantic.com/technology/2026/01/america-polymarket-disaster/685662/)<!-- HN:46689143:end --><!-- HN:46644356:start -->
* [46644356](https://news.social-protocols.org/stats?id=46644356) #4 4 points 0 comments -> [Show HN: Bettershot an OSS Alternative of Cleanshot](https://github.com/KartikLabhshetwar/better-shot)<!-- HN:46644356:end --><!-- HN:46692087:start -->
* [46692087](https://news.social-protocols.org/stats?id=46692087) #23 6 points 0 comments -> [Minneapolis software engineers mistaken for ICE agents](https://www.foxnews.com/us/minneapolis-software-engineers-mistaken-ice-agents-eating-lunch-harassed-anti-ice-crowd)<!-- HN:46692087:end --><!-- HN:46692284:start -->
* [46692284](https://news.social-protocols.org/stats?id=46692284) #25 5 points 1 comments -> [Vibe coding is a hobby. Let me explain](https://medium.com/@wob/vibe-coding-is-a-hobby-let-me-explain-a54949c3b455)<!-- HN:46692284:end --><!-- HN:46693363:start -->
* [46693363](https://news.social-protocols.org/stats?id=46693363) #13 11 points 2 comments -> [US citizen says ICE removed him from his Minnesota home in his underwear](https://apnews.com/article/minnesota-immigration-us-citizen-detained-hmong-d009590a491c0c8243ef21ef24db7182)<!-- HN:46693363:end --><!-- HN:46693456:start -->
* [46693456](https://news.social-protocols.org/stats?id=46693456) #12 13 points 4 comments -> ['AI' is a dick move, redux](https://www.baldurbjarnason.com/notes/2026/note-on-debating-llm-fans/)<!-- HN:46693456:end --><!-- HN:46693021:start -->
* [46693021](https://news.social-protocols.org/stats?id=46693021) #22 17 points 19 comments -> [Claude Code is the ChatGPT moment repeated and awful news for software stocks](https://sherwood.news/markets/how-claude-code-is-the-chatgpt-moment-repeated-and-why-thats-awful-news-for/)<!-- HN:46693021:end --><!-- HN:46646174:start -->
* [46646174](https://news.social-protocols.org/stats?id=46646174) #14 25 points 10 comments -> [A Pro Meticulously Restores a Damaged Oil Painting [video]](https://www.youtube.com/watch?v=uQbZIyo-SgM)<!-- HN:46646174:end --><!-- HN:46695492:start -->
* [46695492](https://news.social-protocols.org/stats?id=46695492) #22 3 points 0 comments -> [Show HN: Typing Tennis](https://typingtennis.com)<!-- HN:46695492:end --><!-- HN:46697700:start -->
* [46697700](https://news.social-protocols.org/stats?id=46697700) #15 -> [Citizen says ICE took him at gunpoint in underwear despite cold and no warrant](https://apnews.com/article/minnesota-immigration-us-citizen-detained-hmong-d009590a491c0c8243ef21ef24db7182)<!-- HN:46697700:end -->
#### **Wednesday, January 21, 2026**
<!-- HN:46698723:start -->
* [46698723](https://news.social-protocols.org/stats?id=46698723) #26 -> [DOGE employees may have improperly accessed social security data, DOJ says](https://www.axios.com/2026/01/20/doge-employees-social-security-information-court-filing)<!-- HN:46698723:end --><!-- HN:46632593:start -->
* [46632593](https://news.social-protocols.org/stats?id=46632593) #18 12 points 0 comments -> [Catching API regressions with snapshot testing](https://kreya.app/blog/api-snapshot-testing/)<!-- HN:46632593:end --><!-- HN:46701239:start -->
* [46701239](https://news.social-protocols.org/stats?id=46701239) #4 12 points 4 comments -> [Germany Forces Lexus to Remotely Kill Car Heating in Dead of Winter](https://www.gadgetreview.com/germany-forces-lexus-to-remotely-kill-car-heating-in-dead-of-winter)<!-- HN:46701239:end --><!-- HN:46663686:start -->
* [46663686](https://news.social-protocols.org/stats?id=46663686) #29 12 points 2 comments -> [The life of a playboy publisher who shaped 20th-century literature](https://www.washingtonpost.com/books/2026/01/09/bennett-cerf-biography-nothing-random-feldman-book-review/)<!-- HN:46663686:end --><!-- HN:46702019:start -->
* [46702019](https://news.social-protocols.org/stats?id=46702019) #22 8 points 1 comments -> [EU moves closer to using its trade bazooka against the US](https://www.politico.eu/article/eu-bazooka-trade-us-greenland-france-threat-nato/)<!-- HN:46702019:end --><!-- HN:46703243:start -->
* [46703243](https://news.social-protocols.org/stats?id=46703243) #10 4 points 1 comments -> [Leave X – Protect Democracy](https://leavex.eu)<!-- HN:46703243:end --><!-- HN:46703643:start -->
* [46703643](https://news.social-protocols.org/stats?id=46703643) #30 33 points 19 comments -> [EU chief says EU should abandon caution after Bessent calls Denmark 'irrelevant'](https://www.theguardian.com/world/live/2026/jan/21/europe-donald-trump-davos-speech-greenland-denmark-latest-updates)<!-- HN:46703643:end --><!-- HN:46705402:start -->
* [46705402](https://news.social-protocols.org/stats?id=46705402) #21 10 points 1 comments -> [Europe has a lot to learn from Mark Carney](https://www.newstatesman.com/world/americas/north-america/us/2026/01/europe-has-a-lot-to-learn-from-mark-carney)<!-- HN:46705402:end --><!-- HN:46705385:start -->
* [46705385](https://news.social-protocols.org/stats?id=46705385) #29 58 points 35 comments -> [Canada Announces Divorce from America](https://charlotteclymer.substack.com/p/canada-announces-divorce-from-america)<!-- HN:46705385:end --><!-- HN:46706732:start -->
* [46706732](https://news.social-protocols.org/stats?id=46706732) #22 12 points 0 comments -> [The Oligarchs Pushing for Conquest in Greenland](https://newrepublic.com/article/205102/oligarchs-pushing-conquest-greenland-trump)<!-- HN:46706732:end --><!-- HN:46706532:start -->
* [46706532](https://news.social-protocols.org/stats?id=46706532) #21 -> [DOGE Employees Shared Social Security Data](https://www.nytimes.com/2026/01/20/us/politics/doge-employees-social-security-data.html)<!-- HN:46706532:end --><!-- HN:46707638:start -->
* [46707638](https://news.social-protocols.org/stats?id=46707638) #30 8 points 1 comments -> [The Oligarchs Pushing for Conquest in Greenland](https://newrepublic.com/article/205102/oligarchs-pushing-conquest-greenland-trump)<!-- HN:46707638:end --><!-- HN:46676661:start -->
* [46676661](https://news.social-protocols.org/stats?id=46676661) #22 5 points 1 comments -> [BitChat.land – Global Bitchat relay overview](https://bitchat.land/)<!-- HN:46676661:end --><!-- HN:46636362:start -->
* [46636362](https://news.social-protocols.org/stats?id=46636362) #22 77 points 28 comments -> [What Is a PC Compatible?](https://codon.org.uk/~mjg59/blog/p/what-is-a-pc-compatible/)<!-- HN:46636362:end --><!-- HN:46641007:start -->
* [46641007](https://news.social-protocols.org/stats?id=46641007) #27 26 points 5 comments -> [An Unfolding Scientific Revolution in Cosmology](https://economicsfromthetopdown.com/2026/01/15/an-unfolding-scientific-revolution-in-cosmology/)<!-- HN:46641007:end --><!-- HN:46711346:start -->
* [46711346](https://news.social-protocols.org/stats?id=46711346) #25 100 points 46 comments -> [FreeBSD](https://docs.freebsd.org/en/books/handbook/)<!-- HN:46711346:end --><!-- HN:46712959:start -->
* [46712959](https://news.social-protocols.org/stats?id=46712959) #20 3 points 0 comments -> [The Inflation Trap: Housing replacement costs vs. market value](https://suretyinsights.com/blog/the-inflation-trap-why-your-home-insurance-limit-might-be-too-low)<!-- HN:46712959:end -->
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
* [46749873](https://news.social-protocols.org/stats?id=46749873) #20 6 points 0 comments -> [National Guard activated in Minneapolis after Border Patrol agent kills man](https://apnews.com/live/minneapolis-ice-shooting-updates-1-24-2026)<!-- HN:46749873:end --><!-- HN:46749319:start -->
* [46749319](https://news.social-protocols.org/stats?id=46749319) #7 33 points 24 comments -> [Tesla unsupervised Robotaxis are nowhere to be found](https://lightbrd.com/ZacksJerryRig/status/2015119993428705575#m)<!-- HN:46749319:end --><!-- HN:46750166:start -->
* [46750166](https://news.social-protocols.org/stats?id=46750166) #21 9 points 1 comments -> [Federal agents shoot man dead in Minneapolis](https://www.ft.com/content/3d855ba7-3e96-4512-b34c-6ff87ade6c12)<!-- HN:46750166:end --><!-- HN:46750208:start -->
* [46750208](https://news.social-protocols.org/stats?id=46750208) #23 13 points 0 comments -> [Civil Resistance](https://en.wikipedia.org/wiki/Civil_resistance)<!-- HN:46750208:end -->