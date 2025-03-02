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

#### **Tuesday, February 25, 2025**
<!-- HN:43129884:start -->
* [43129884](https://news.social-protocols.org/stats?id=43129884) #21 3 points 0 comments -> [Grab AI Gateway: Connecting Grabbers to Multiple GenAI Providers](https://engineering.grab.com/grab-ai-gateway)<!-- HN:43129884:end --><!-- HN:43168059:start -->
* [43168059](https://news.social-protocols.org/stats?id=43168059) #21 30 points 40 comments -> [A16Z AI Voice Update 2025](https://gamma.app/docs/a16z-AI-Voice-Update-2025--ttkorld8iy6wfnj?mode=doc)<!-- HN:43168059:end --><!-- HN:43168739:start -->
* [43168739](https://news.social-protocols.org/stats?id=43168739) #22 6 points 0 comments -> [Grok Grok](https://thezvi.substack.com/p/grok-grok)<!-- HN:43168739:end --><!-- HN:43170093:start -->
* [43170093](https://news.social-protocols.org/stats?id=43170093) #10 10 points 3 comments -> [Does Linus think Rust causes Linux breakage?](https://lwn.net/ml/all/CAHk-=wie_Winz7CtRCM62S2b1pWKN2Jt2wdGHgFBv=aBU8qwqg@mail.gmail.com/)<!-- HN:43170093:end --><!-- HN:43170718:start -->
* [43170718](https://news.social-protocols.org/stats?id=43170718) #6 35 points 3 comments -> [Tesla sales almost halved in Europe last month](https://www.businessinsider.com/tesla-sales-europe-tumbled-elon-musk-china-evs-2025-2)<!-- HN:43170718:end --><!-- HN:43135968:start -->
* [43135968](https://news.social-protocols.org/stats?id=43135968) #17 5 points 2 comments -> [Severance show – Fan-based game](https://www.solana-industries.com/)<!-- HN:43135968:end --><!-- HN:43128392:start -->
* [43128392](https://news.social-protocols.org/stats?id=43128392) #24 164 points 118 comments -> [I ate and reviewed every snack in our office kitchen](https://www.getlago.com/blog/office-snacks)<!-- HN:43128392:end --><!-- HN:43167936:start -->
* [43167936](https://news.social-protocols.org/stats?id=43167936) #23 257 points 93 comments -> [How to change your settings to make yourself less valuable to Meta](https://johnoliverwantsyourraterotica.com/)<!-- HN:43167936:end --><!-- HN:43172180:start -->
* [43172180](https://news.social-protocols.org/stats?id=43172180) #23 8 points 0 comments -> [YC deleted the post of the demo for slavery](https://twitter.com/ns123abc/status/1894193460166397991)<!-- HN:43172180:end --><!-- HN:43172037:start -->
* [43172037](https://news.social-protocols.org/stats?id=43172037) #20 27 points 4 comments -> [Apple Voice Dictation Writes 'Trump' When You Say 'Racist'](https://boehs.org/node/racist-autocorrect)<!-- HN:43172037:end --><!-- HN:43172676:start -->
* [43172676](https://news.social-protocols.org/stats?id=43172676) #23 3 points 1 comments -> [PocketBeagle 2 SBC Combines TI AM6232 Dual-Core Cortex-A53 SoC with MSPM0 MCU](https://www.cnx-software.com/2025/02/18/pocketbeagle-2-sbc-combines-ti-am6232-soc-with-mspm0-mcu/)<!-- HN:43172676:end --><!-- HN:43173341:start -->
* [43173341](https://news.social-protocols.org/stats?id=43173341) #13 29 points 42 comments -> [Fabric and craft retailer Joann to go out of business, close all of its stores](https://apnews.com/article/joann-closing-bankruptcy-crafts-retail-b83c68fb641fad18cd6c8be925c6d90b)<!-- HN:43173341:end --><!-- HN:43174908:start -->
* [43174908](https://news.social-protocols.org/stats?id=43174908) #10 4 points 0 comments -> [The Harem of an Autist](https://fantasticanachronism.com/2025/02/25/the-harem-of-an-autist/)<!-- HN:43174908:end --><!-- HN:43149899:start -->
* [43149899](https://news.social-protocols.org/stats?id=43149899) #26 20 points 6 comments -> [Show HN: Dropbud – A place to upload files without uploading](https://dropbud.co/space)<!-- HN:43149899:end -->
#### **Wednesday, February 26, 2025**
<!-- HN:43156753:start -->
* [43156753](https://news.social-protocols.org/stats?id=43156753) #15 13 points 2 comments -> [Hive Roaster Handheld Smoke Incinerating Coffee Roaster](https://hiveroaster.com/)<!-- HN:43156753:end --><!-- HN:43180561:start -->
* [43180561](https://news.social-protocols.org/stats?id=43180561) #18 12 points 0 comments -> [Oil and Gas Subsidies Are Another Lie Detector Test for the DOGE Bros](https://www.motherjones.com/politics/2025/01/doge-fossil-fuel-subsidies-elon-musk-vivek-ramaswamy/)<!-- HN:43180561:end --><!-- HN:43180834:start -->
* [43180834](https://news.social-protocols.org/stats?id=43180834) #4 100 points 15 comments -> [Y Combinator Supports AI Startup Dehumanizing Factory Workers](https://www.404media.co/optifyeai-ycombinator-startup-ai-factory/)<!-- HN:43180834:end --><!-- HN:43182578:start -->
* [43182578](https://news.social-protocols.org/stats?id=43182578) #17 10 points 1 comments -> [Open-source is where dreams go to die](https://www.trevorlasn.com/blog/open-source-is-where-dreams-go-to-die)<!-- HN:43182578:end --><!-- HN:43138818:start -->
* [43138818](https://news.social-protocols.org/stats?id=43138818) #9 36 points 8 comments -> [Recurse Center's Social Rules](https://www.recurse.com/social-rules)<!-- HN:43138818:end --><!-- HN:43144830:start -->
* [43144830](https://news.social-protocols.org/stats?id=43144830) #11 35 points 13 comments -> [A compendium of "open-source" licenses](https://github.com/ErikMcClure/bad-licenses)<!-- HN:43144830:end --><!-- HN:43183169:start -->
* [43183169](https://news.social-protocols.org/stats?id=43183169) #12 44 points 25 comments -> [Marek has graciously offered to maintain the dma-mapping tree](https://lore.kernel.org/lkml/20250224162724.349679-1-hch@lst.de/)<!-- HN:43183169:end --><!-- HN:43137445:start -->
* [43137445](https://news.social-protocols.org/stats?id=43137445) #14 105 points 21 comments -> [Terence Tao – Machine-Assisted Proofs (February 19, 2025) [video]](https://www.youtube.com/watch?v=5ZIIGLiQWNM)<!-- HN:43137445:end --><!-- HN:43183688:start -->
* [43183688](https://news.social-protocols.org/stats?id=43183688) #17 28 points 12 comments -> [Apple's Dictation System Transcribes the Word 'Racist' as 'Trump'](https://www.nytimes.com/2025/02/25/technology/iphone-dictation-trump-racist.html)<!-- HN:43183688:end --><!-- HN:43183568:start -->
* [43183568](https://news.social-protocols.org/stats?id=43183568) #20 45 points 43 comments -> ["Do you not like money?"](https://rubenerd.com/do-you-not-like-money/)<!-- HN:43183568:end --><!-- HN:43185174:start -->
* [43185174](https://news.social-protocols.org/stats?id=43185174) #1 81 points 3 comments -> [A WebAssembly runtime implemented in TypeScript types](https://github.com/MichiganTypeScript/typescript-types-only-wasm-runtime)<!-- HN:43185174:end --><!-- HN:43187326:start -->
* [43187326](https://news.social-protocols.org/stats?id=43187326) #12 3 points 0 comments -> [An Identity-Based Model of Political Belief: Trends in Cognitive Sciences](https://www.cell.com/trends/cognitive-sciences/abstract/S1364-6613(18)30017-2)<!-- HN:43187326:end --><!-- HN:43187543:start -->
* [43187543](https://news.social-protocols.org/stats?id=43187543) #22 13 points 0 comments -> [Techno-Fascism Comes to America](https://www.newyorker.com/culture/infinite-scroll/techno-fascism-comes-to-america-elon-musk)<!-- HN:43187543:end -->
#### **Thursday, February 27, 2025**
<!-- HN:43190048:start -->
* [43190048](https://news.social-protocols.org/stats?id=43190048) #4 16 points 1 comments -> [Europe Is a Cautionary Tale on Birthright Citizenship](https://asanfranciscan.substack.com/p/europe-is-a-cautionary-tale-on-birthright)<!-- HN:43190048:end --><!-- HN:43190262:start -->
* [43190262](https://news.social-protocols.org/stats?id=43190262) #20 12 points 1 comments -> [Save Act would require all Americans prove citizenship when registering to vote](https://www.americanprogress.org/article/the-save-act-would-disenfranchise-millions-of-citizens/)<!-- HN:43190262:end --><!-- HN:43192547:start -->
* [43192547](https://news.social-protocols.org/stats?id=43192547) #16 19 points 41 comments -> [Japan births fall to lowest in 125 years](https://www.ft.com/content/95d3282e-daef-4670-b704-c1215393e7f8)<!-- HN:43192547:end --><!-- HN:43193326:start -->
* [43193326](https://news.social-protocols.org/stats?id=43193326) #2 18 points 13 comments -> [Germany's Water Consumption Down 17% Following Nuclear Reactor Shutdowns](https://www.vdi-nachrichten.com/technik/umwelt/wasserverbrauch-in-deutschland-sank-deutlich-durch-akw-abschaltung/)<!-- HN:43193326:end --><!-- HN:43193383:start -->
* [43193383](https://news.social-protocols.org/stats?id=43193383) #6 10 points 0 comments -> [Show HN: No-html.club, a plain text club](http://no-html.club/index.txt)<!-- HN:43193383:end --><!-- HN:43152051:start -->
* [43152051](https://news.social-protocols.org/stats?id=43152051) #10 22 points 3 comments -> [Transparency in Hardware/Software Interfaces](https://rfd.shared.oxide.computer/rfd/0552)<!-- HN:43152051:end --><!-- HN:43193734:start -->
* [43193734](https://news.social-protocols.org/stats?id=43193734) #24 3 points 0 comments -> [Kia's EV strategy: Smaller, cheaper cars like the EV3 hatch and EV4 sedan](https://arstechnica.com/cars/2025/02/kias-ev-strategy-smaller-cheaper-cars-like-ev3-hatch-and-ev4-sedan/)<!-- HN:43193734:end --><!-- HN:43159128:start -->
* [43159128](https://news.social-protocols.org/stats?id=43159128) #9 16 points 1 comments -> [Show HN: Orra – The missing glue layer for production-ready multi-agent apps](https://github.com/orra-dev/orra)<!-- HN:43159128:end --><!-- HN:43170242:start -->
* [43170242](https://news.social-protocols.org/stats?id=43170242) #9 13 points 2 comments -> [Metasploit – Penetration Testing Framework](https://www.metasploit.com/)<!-- HN:43170242:end --><!-- HN:43193795:start -->
* [43193795](https://news.social-protocols.org/stats?id=43193795) #23 44 points 26 comments -> [Local social spending and political dissatisfaction of the economically deprived](https://www.frontiersin.org/journals/political-science/articles/10.3389/fpos.2025.1516985/full)<!-- HN:43193795:end --><!-- HN:43194778:start -->
* [43194778](https://news.social-protocols.org/stats?id=43194778) #15 19 points 6 comments -> [Gene Hackman and pianist wife Betsy Arakawa found dead at home with their dog](https://www.theguardian.com/film/2025/feb/27/gene-hackman-dies-wife-dog-95)<!-- HN:43194778:end --><!-- HN:43195589:start -->
* [43195589](https://news.social-protocols.org/stats?id=43195589) #24 -> [At 3 A.m., I Turned to AI for Comfort. That Was My First Mistake](https://thewalrus.ca/at-3-a-m-i-turned-to-ai-for-comfort-that-was-my-first-mistake/)<!-- HN:43195589:end --><!-- HN:43196443:start -->
* [43196443](https://news.social-protocols.org/stats?id=43196443) #25 6 points 1 comments -> [Bezos censors the Washington Post in the name of freedom](https://www.washingtonpost.com/style/media/2025/02/26/washington-post-bezos-opinions-section/)<!-- HN:43196443:end --><!-- HN:43196585:start -->
* [43196585](https://news.social-protocols.org/stats?id=43196585) #15 8 points 1 comments -> [From "hot blonde" to "stepsis": porn titles over time](https://github.com/dhealy05/semen_and_semantics)<!-- HN:43196585:end --><!-- HN:43198759:start -->
* [43198759](https://news.social-protocols.org/stats?id=43198759) #14 9 points 5 comments -> [Think tank seeks to give "Trump his rightful third term in office"](https://thirdtermproject.com/)<!-- HN:43198759:end -->
#### **Friday, February 28, 2025**
<!-- HN:43200179:start -->
* [43200179](https://news.social-protocols.org/stats?id=43200179) #14 5 points 0 comments -> [Tesla Powerwall 3 Alternatives](https://www.virtuesolar.com/2025/02/17/tesla-powerwall-3-alternatives/)<!-- HN:43200179:end --><!-- HN:43199460:start -->
* [43199460](https://news.social-protocols.org/stats?id=43199460) #4 250 points 3 comments -> [Some Command & Conquer games are now open source](https://github.com/electronicarts)<!-- HN:43199460:end --><!-- HN:43205100:start -->
* [43205100](https://news.social-protocols.org/stats?id=43205100) #26 9 points 1 comments -> ['I decided I was done':Canada pizzeria boycotts US ingredients in tariff dispute](https://www.theguardian.com/world/2025/feb/28/canada-pizzeria-owner-boycotts-us-products)<!-- HN:43205100:end --><!-- HN:43207338:start -->
* [43207338](https://news.social-protocols.org/stats?id=43207338) #6 26 points 2 comments -> [Hundreds in US climate agency fired in latest cuts](https://www.bbc.com/news/articles/cdell8n14x2o)<!-- HN:43207338:end --><!-- HN:43200450:start -->
* [43200450](https://news.social-protocols.org/stats?id=43200450) #17 193 points 19 comments -> [Markov Chains Explained Visually (2014)](https://setosa.io/ev/markov-chains/)<!-- HN:43200450:end --><!-- HN:43207491:start -->
* [43207491](https://news.social-protocols.org/stats?id=43207491) #6 20 points 0 comments -> [The full force of this administration's destruction is about to hit](https://www.thehandbasket.co/p/government-destruction-ssa-doge)<!-- HN:43207491:end --><!-- HN:43205196:start -->
* [43205196](https://news.social-protocols.org/stats?id=43205196) #26 95 points 151 comments -> [AMD RDNA 4 – AMD Radeon RX 9000 Series Graphics Cards](https://www.amd.com/en/newsroom/press-releases/2025-2-28-amd-unveils-next-generation-amd-rdna-4-architectu.html)<!-- HN:43205196:end --><!-- HN:43169461:start -->
* [43169461](https://news.social-protocols.org/stats?id=43169461) #21 317 points 230 comments -> [Spotify's Beta Used 'Pirate' MP3 Files, Some from Pirate Bay](https://torrentfreak.com/spotifys-beta-used-pirate-mp3-files-some-from-pirate-bay-170509/)<!-- HN:43169461:end --><!-- HN:43200065:start -->
* [43200065](https://news.social-protocols.org/stats?id=43200065) #24 792 points 6 comments -> [Mozilla owns "information you input through Firefox"](https://www.mozilla.org/en-US/about/legal/terms/firefox/)<!-- HN:43200065:end --><!-- HN:43210569:start -->
* [43210569](https://news.social-protocols.org/stats?id=43210569) #1 51 points 7 comments -> ["No, we are absolutely not prepared to [fork Firefox]"](https://codeberg.org/librewolf/issues/issues/2252#issuecomment-2886286)<!-- HN:43210569:end --><!-- HN:43211925:start -->
* [43211925](https://news.social-protocols.org/stats?id=43211925) #9 -> [Google's Sergey Brin: Engineers Should Work 60-Hour Weeks in Office to Build AI](https://gizmodo.com/googles-sergey-brin-says-engineers-should-work-60-hour-weeks-in-office-to-build-ai-that-could-replace-them-2000570025)<!-- HN:43211925:end --><!-- HN:43170457:start -->
* [43170457](https://news.social-protocols.org/stats?id=43170457) #23 18 points 9 comments -> [The Moped King](https://www.streetsblogprojects.org/fly-electric-bike-moped-new-york-city-streets-safety-lithium-ion-batteries)<!-- HN:43170457:end -->
#### **Saturday, March 1, 2025**
<!-- HN:43215769:start -->
* [43215769](https://news.social-protocols.org/stats?id=43215769) #29 6 points 0 comments -> [DeepSeek-V3/R1 Inference System Overview](https://github.com/deepseek-ai/open-infra-index/blob/main/202502OpenSourceWeek/day_6_one_more_thing_deepseekV3R1_inference_system_overview.md)<!-- HN:43215769:end --><!-- HN:43214294:start -->
* [43214294](https://news.social-protocols.org/stats?id=43214294) #3 305 points 68 comments -> [Self-Hosting a Firefox Sync Server](https://blog.diego.dev/posts/firefox-sync-server/)<!-- HN:43214294:end --><!-- HN:43219743:start -->
* [43219743](https://news.social-protocols.org/stats?id=43219743) #11 7 points 0 comments -> [HIV/AIDS deaths likely to soar after USAID promises broken](https://www.science.org/content/article/bloodbath-hiv-field-reeling-after-billions-u-s-funding-axed)<!-- HN:43219743:end --><!-- HN:43219616:start -->
* [43219616](https://news.social-protocols.org/stats?id=43219616) #27 8 points 9 comments -> [The Press Falls to Another Record Low in Public Trust](https://jonathanturley.org/2025/03/01/the-press-falls-to-another-record-low-in-public-trust/)<!-- HN:43219616:end --><!-- HN:43220426:start -->
* [43220426](https://news.social-protocols.org/stats?id=43220426) #16 5 points 0 comments -> [Coastal Economies Rely on NOAA, from Maine to Florida, Texas and Alaska](https://theconversation.com/coastal-economies-rely-on-noaa-from-maine-to-florida-texas-and-alaska-even-if-they-dont-realize-it-250016)<!-- HN:43220426:end --><!-- HN:43221543:start -->
* [43221543](https://news.social-protocols.org/stats?id=43221543) #4 59 points 37 comments -> [Open AI in Trouble](https://garymarcus.substack.com/p/openai-in-deep-trouble)<!-- HN:43221543:end --><!-- HN:43221685:start -->
* [43221685](https://news.social-protocols.org/stats?id=43221685) #7 32 points 43 comments -> [Why so many children in America have ADHD](https://www.economist.com/united-states/2025/02/20/why-so-many-children-in-america-have-adhd)<!-- HN:43221685:end --><!-- HN:43222653:start -->
* [43222653](https://news.social-protocols.org/stats?id=43222653) #24 6 points 0 comments -> [Is Donald Trump the Antichrist? A Bayesian Analysis](https://gist.github.com/ndbroadbent/cfaad426ef641e981cdea3642a3e45b1)<!-- HN:43222653:end --><!-- HN:43223209:start -->
* [43223209](https://news.social-protocols.org/stats?id=43223209) #17 5 points 0 comments -> [RFK Jr. issues rule barring public comment on HHS rulemaking](https://thehill.com/policy/healthcare/5170090-rfk-jr-hhs-public-comment-rulemaking-ends/)<!-- HN:43223209:end --><!-- HN:43223684:start -->
* [43223684](https://news.social-protocols.org/stats?id=43223684) #11 49 points 18 comments -> [China advises citizens specializing in AI to avoid traveling to America](https://www.saba.ye/en/news3445018.htm)<!-- HN:43223684:end -->
#### **Sunday, March 2, 2025**<!-- HN:43205642:start -->
* [43205642](https://news.social-protocols.org/stats?id=43205642) #15 10 points 0 comments -> [New footage shows sneaky killer is decapitating baby seals on California beaches](https://www.sfgate.com/local/article/coyotes-decapitating-seals-northern-california-20183166.php)<!-- HN:43205642:end --><!-- HN:43227131:start -->
* [43227131](https://news.social-protocols.org/stats?id=43227131) #17 7 points 10 comments -> [Show HN: What did you do last week? – Evaluates your 5 bullet points](https://whatdidyoudolastweek.biz)<!-- HN:43227131:end --><!-- HN:43182253:start -->
* [43182253](https://news.social-protocols.org/stats?id=43182253) #27 14 points 0 comments -> [The GitVenom campaign: cryptocurrency theft using GitHub](https://securelist.com/gitvenom-campaign/115694/)<!-- HN:43182253:end --><!-- HN:43230442:start -->
* [43230442](https://news.social-protocols.org/stats?id=43230442) #14 5 points 2 comments -> [Pubmed Has Been Deleted](https://pubmed.ncbi.nlm.nih.gov/)<!-- HN:43230442:end --><!-- HN:43230904:start -->
* [43230904](https://news.social-protocols.org/stats?id=43230904) #8 5 points 1 comments -> [Perun on "could Europe defend itself without US?"](https://www.youtube.com/watch?v=7giYIisLuaA)<!-- HN:43230904:end --><!-- HN:43231551:start -->
* [43231551](https://news.social-protocols.org/stats?id=43231551) #30 11 points 9 comments -> [I'm a neuroscientist. Here's the surprising truth about TikTok 'brain rot'](https://www.sciencefocus.com/comment/tiktok-braintot-psychologist-explains)<!-- HN:43231551:end --><!-- HN:43232841:start -->
* [43232841](https://news.social-protocols.org/stats?id=43232841) #15 27 points 13 comments -> [Falsehoods programmers believe about languages (localization)](https://www.lexiconista.com/falsehoods-about-languages/)<!-- HN:43232841:end --><!-- HN:43234281:start -->
* [43234281](https://news.social-protocols.org/stats?id=43234281) #30 18 points 4 comments -> [Brazilians hail strength of democracy as Bolsonaro is called to account](https://www.theguardian.com/world/2025/feb/19/brazil-jair-bolsonaro-coup)<!-- HN:43234281:end --><!-- HN:43235524:start -->
* [43235524](https://news.social-protocols.org/stats?id=43235524) #29 -> [Donald Trump supporters lose $12B after his meme coin collapses](https://www.uniladtech.com/news/tech-news/donald-trump-supporters-lose-12-billion-after-meme-coin-collapse-393345-20250228)<!-- HN:43235524:end --><!-- HN:43236182:start -->
* [43236182](https://news.social-protocols.org/stats?id=43236182) #15 11 points 1 comments -> [Stand Up for Science](https://standupforscience2025.org/)<!-- HN:43236182:end -->
#### **Monday, March 3, 2025**
<!-- HN:43235933:start -->
* [43235933](https://news.social-protocols.org/stats?id=43235933) #1 78 points 9 comments -> [Firefly Aerospace Becomes First Commercial Company to Successfully Land on Moon](https://fireflyspace.com/news/firefly-aerospace-becomes-first-commercial-company-to-successfully-land-on-the-moon/)<!-- HN:43235933:end --><!-- HN:43239249:start -->
* [43239249](https://news.social-protocols.org/stats?id=43239249) #17 307 points 394 comments -> [The top 10% owns 87% of the stocks](https://awealthofcommonsense.com/2025/02/the-top-10/)<!-- HN:43239249:end --><!-- HN:43205209:start -->
* [43205209](https://news.social-protocols.org/stats?id=43205209) #23 18 points 2 comments -> [Show HN: Free Kindle Scribe Weekly Planner Creator](https://tools.docgenie.co.uk/)<!-- HN:43205209:end -->