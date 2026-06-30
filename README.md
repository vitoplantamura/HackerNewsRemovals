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

#### **Wednesday, June 24, 2026**
<!-- HN:48653746:start -->
* [48653746](https://news.social-protocols.org/stats?id=48653746) #16 18 points 10 comments -> [How to Passive-Aggressively Shame People Who Use LLMs Selfishly](https://joshmoody.org/blog/selfish-ai/)<!-- HN:48653746:end --><!-- HN:48654823:start -->
* [48654823](https://news.social-protocols.org/stats?id=48654823) #13 4 points 0 comments -> [LineShine Debuts at No. 1 as the TOP500 Enters a New Global Exascale Era](https://top500.org/news/lineshine-debuts-no-1-top500-enters-new-global-exascale-era/)<!-- HN:48654823:end --><!-- HN:48654765:start -->
* [48654765](https://news.social-protocols.org/stats?id=48654765) #17 6 points 1 comments -> [Sakana Fugu: a multi-agent system delivered as one model](https://github.com/SakanaAI/fugu)<!-- HN:48654765:end --><!-- HN:48656807:start -->
* [48656807](https://news.social-protocols.org/stats?id=48656807) #2 19 points 13 comments -> [GitHub Is Becoming a Giant AI Code Dump](https://maref.cc/en/blog/vibe-coding-crisis/)<!-- HN:48656807:end --><!-- HN:48656943:start -->
* [48656943](https://news.social-protocols.org/stats?id=48656943) #14 13 points 7 comments -> [Grok Build 0.1: Intelligence, Performance and Price Analysis](https://artificialanalysis.ai/models/grok-build-0-1-06-16)<!-- HN:48656943:end --><!-- HN:48658544:start -->
* [48658544](https://news.social-protocols.org/stats?id=48658544) #3 5 points 4 comments -> [Show HN: Make your game multiplayer in one prompt](https://antics.gg/)<!-- HN:48658544:end --><!-- HN:48658484:start -->
* [48658484](https://news.social-protocols.org/stats?id=48658484) #22 17 points 41 comments -> [Europeans should learn to love the air-conditioner … green electricity](https://www.economist.com/europe/2026/06/18/europeans-should-learn-to-love-the-air-conditioner)<!-- HN:48658484:end --><!-- HN:48661195:start -->
* [48661195](https://news.social-protocols.org/stats?id=48661195) #11 4 points 1 comments -> [Registration](https://www.winnipegsd.ca/student-registration)<!-- HN:48661195:end --><!-- HN:48662805:start -->
* [48662805](https://news.social-protocols.org/stats?id=48662805) #23 -> [Ubisoft co-founder Claude Guillemot dies in plane crash](https://techcrunch.com/2026/06/21/ubisoft-co-founder-claude-guillemot-dies-in-plane-crash/)<!-- HN:48662805:end --><!-- HN:48659257:start -->
* [48659257](https://news.social-protocols.org/stats?id=48659257) #7 139 points 1 comments -> [OpenAI and Broadcom unveil LLM-optimized inference chip](https://openai.com/index/openai-broadcom-jalapeno-inference-chip/)<!-- HN:48659257:end --><!-- HN:48627980:start -->
* [48627980](https://news.social-protocols.org/stats?id=48627980) #17 8 points 4 comments -> [How a Microsecond-Level Low-Latency Engine Works](https://medium.com/@DolphinDB_Inc/c-speed-without-c-pain-inside-a-microsecond-level-low-latency-engine-a634f260a4ee)<!-- HN:48627980:end --><!-- HN:48665740:start -->
* [48665740](https://news.social-protocols.org/stats?id=48665740) #10 4 points 5 comments -> [A Tesla Crashed Through a Harris County Home. Is the Car to Blame?](https://www.readponder.com/essay/a-tesla-crashed-through-a-harris-county-home-is-the-car-to-blame)<!-- HN:48665740:end -->
#### **Thursday, June 25, 2026**
<!-- HN:48667277:start -->
* [48667277](https://news.social-protocols.org/stats?id=48667277) #18 7 points 0 comments -> [10 Years of Euthanasia in Canada: 27 Deaths a Day](https://zenit.org/2026/06/22/10-years-of-euthanasia-in-canada-27-deaths-a-day-10000-a-year-and-now-theyre-targeting-the-mentally-ill/)<!-- HN:48667277:end --><!-- HN:48668662:start -->
* [48668662](https://news.social-protocols.org/stats?id=48668662) #29 32 points 40 comments -> [GTA 6 Physical Copies Won't Include a Disc, Will Just Be a Code in a Box](https://www.ign.com/articles/grand-theft-auto-6-physical-copies-wont-include-a-disc-will-just-be-a-code-in-a-box)<!-- HN:48668662:end --><!-- HN:48670490:start -->
* [48670490](https://news.social-protocols.org/stats?id=48670490) #4 6 points 1 comments -> [Mad Fucking Witches](https://www.mfw.org.au/)<!-- HN:48670490:end --><!-- HN:48673321:start -->
* [48673321](https://news.social-protocols.org/stats?id=48673321) #7 5 points 2 comments -> [UN hypocrisy in AI Environmental demands](https://www.thatprivacyguy.com/blog/un-tracking-without-consent/)<!-- HN:48673321:end --><!-- HN:48674096:start -->
* [48674096](https://news.social-protocols.org/stats?id=48674096) #8 248 points 192 comments -> [Apple increases MacBook and iPad prices by 20%](https://www.ft.com/content/0f067265-2baf-4b6e-8fb2-ed56daef6f3c)<!-- HN:48674096:end --><!-- HN:48669932:start -->
* [48669932](https://news.social-protocols.org/stats?id=48669932) #23 196 points 3 comments -> [Wikipedia Workers in Britain set global first by seeking union recognition](https://utaw.tech/news/wikipedia-recognition)<!-- HN:48669932:end --><!-- HN:48678240:start -->
* [48678240](https://news.social-protocols.org/stats?id=48678240) #9 5 points 0 comments -> [AI Is Designing Radio Chips That Humans Couldn't Even Imagine](https://spectrum.ieee.org/ai-radio-chip-design)<!-- HN:48678240:end --><!-- HN:48678789:start -->
* [48678789](https://news.social-protocols.org/stats?id=48678789) #9 8 points 4 comments -> [OpenAI to Stagger Release of GPT 5.6 at Request of U.S. Government](https://velo.xyz/news/1908)<!-- HN:48678789:end --><!-- HN:48678820:start -->
* [48678820](https://news.social-protocols.org/stats?id=48678820) #20 15 points 18 comments -> [The Customer Who Almost Killed Slack, Stripe, and Airbnb](https://siliconopera.com/the-customer-who-almost-killed-slack-stripe-and-airbnb/)<!-- HN:48678820:end -->
#### **Friday, June 26, 2026**
<!-- HN:48680727:start -->
* [48680727](https://news.social-protocols.org/stats?id=48680727) #10 14 points 5 comments -> [Om Malik – Silicon Valley Has an Empathy Vacuum (Nov 2016)](https://www.newyorker.com/business/currency/silicon-valley-has-an-empathy-vacuum)<!-- HN:48680727:end --><!-- HN:48629112:start -->
* [48629112](https://news.social-protocols.org/stats?id=48629112) #19 3 points 0 comments -> [You Have to Poop in the Eiffel Tower [video]](https://www.youtube.com/watch?v=1v2g3GLaJtE)<!-- HN:48629112:end --><!-- HN:48681361:start -->
* [48681361](https://news.social-protocols.org/stats?id=48681361) #30 23 points 6 comments -> [A data race that doesn't compile (in Rust)](https://corentin-core.github.io/posts/ruxe-type-level-disjointness/)<!-- HN:48681361:end --><!-- HN:48623687:start -->
* [48623687](https://news.social-protocols.org/stats?id=48623687) #17 5 points 1 comments -> [Falcon GX the most powerful brand engineering tool](https://falcon.so/)<!-- HN:48623687:end --><!-- HN:48684063:start -->
* [48684063](https://news.social-protocols.org/stats?id=48684063) #29 6 points 0 comments -> [Alan Greenspan Has Died](https://businessdesk.co.nz/article/economy/remembering-alan-greenspan)<!-- HN:48684063:end --><!-- HN:48685789:start -->
* [48685789](https://news.social-protocols.org/stats?id=48685789) #14 7 points 2 comments -> [What Would C. S. Lewis Have Thought of AI?](https://chroniclesmagazine.org/web/what-would-c-s-lewis-have-thought-of-ai/)<!-- HN:48685789:end --><!-- HN:48686576:start -->
* [48686576](https://news.social-protocols.org/stats?id=48686576) #22 16 points 22 comments -> [Why were Covid vaccine trials so fast?](https://www.clinicaltrialsabundance.blog/p/why-were-covid-vaccine-trials-so-fast)<!-- HN:48686576:end --><!-- HN:48630499:start -->
* [48630499](https://news.social-protocols.org/stats?id=48630499) #17 33 points 12 comments -> [The best thing that has ever happened for multiplayer games](https://mas-bandwidth.com/the-best-thing-that-has-ever-happened-for-multiplayer-games/)<!-- HN:48630499:end --><!-- HN:48687794:start -->
* [48687794](https://news.social-protocols.org/stats?id=48687794) #11 21 points 16 comments -> [Why software engineers are grieving](https://dev.jimgrey.net/2026/06/25/why-software-engineers-are-grieving/)<!-- HN:48687794:end --><!-- HN:48687508:start -->
* [48687508](https://news.social-protocols.org/stats?id=48687508) #21 51 points 34 comments -> [Mullvad founder gave millions to extremist far right party](https://mastodon.social/@raphaelrobert/116816274242387568)<!-- HN:48687508:end --><!-- HN:48689182:start -->
* [48689182](https://news.social-protocols.org/stats?id=48689182) #20 16 points 2 comments -> [Ex-NOAA employees laid off by DOGE rebuilt climate website](https://www.climate.us/)<!-- HN:48689182:end --><!-- HN:48692620:start -->
* [48692620](https://news.social-protocols.org/stats?id=48692620) #25 8 points 2 comments -> [US strikes Iran in response to drone strike on commercial ship](https://www.aljazeera.com/news/2026/6/26/us-strikes-iran-in-response-to-drone-strike-on-commercial-ship)<!-- HN:48692620:end -->
#### **Saturday, June 27, 2026**
<!-- HN:48695981:start -->
* [48695981](https://news.social-protocols.org/stats?id=48695981) #23 10 points 0 comments -> [Om Malik, Whose Blog Shaped How Silicon Valley Saw Itself, Dies at 59](https://www.nytimes.com/2026/06/26/technology/om-malik-dead.html)<!-- HN:48695981:end --><!-- HN:48648008:start -->
* [48648008](https://news.social-protocols.org/stats?id=48648008) #15 13 points 0 comments -> [Building apps using TanStack Start](https://lovable.dev/blog/building-apps-using-tanstack-start)<!-- HN:48648008:end --><!-- HN:48696176:start -->
* [48696176](https://news.social-protocols.org/stats?id=48696176) #3 4 points 0 comments -> [World Cup fans frustrated by 'confusing and expensive' tipping culture in US](https://www.bbc.com/news/articles/clyxgjykx7lo)<!-- HN:48696176:end --><!-- HN:48690709:start -->
* [48690709](https://news.social-protocols.org/stats?id=48690709) #29 81 points 1 comments -> [Long Wave radio era set to end with Droitwich switch-off](https://www.bbc.com/news/articles/c74yn7v7k4qo)<!-- HN:48690709:end --><!-- HN:48648341:start -->
* [48648341](https://news.social-protocols.org/stats?id=48648341) #14 11 points 16 comments -> [Why Windows 95 Was Tech's Last True Revolution](https://comuniq.xyz/post.php?t=1307)<!-- HN:48648341:end --><!-- HN:48699969:start -->
* [48699969](https://news.social-protocols.org/stats?id=48699969) #21 12 points 15 comments -> ["No, I swear I wrote this."](https://revise.io/blog/06-27-2026/no-i-swear-i-wrote-this)<!-- HN:48699969:end --><!-- HN:48701766:start -->
* [48701766](https://news.social-protocols.org/stats?id=48701766) #20 9 points 40 comments -> [Should European housing politics be Americanized?](https://worksinprogress.co/issue/should-european-housing-politics-be-americanized/)<!-- HN:48701766:end -->
#### **Sunday, June 28, 2026**
<!-- HN:48705396:start -->
* [48705396](https://news.social-protocols.org/stats?id=48705396) #28 9 points 0 comments -> [Hungary holds first post-Orban Budapest Pride march](https://www.dw.com/en/hungary-holds-first-post-orban-budapest-pride-march/a-77736596)<!-- HN:48705396:end --><!-- HN:48705276:start -->
* [48705276](https://news.social-protocols.org/stats?id=48705276) #25 38 points 41 comments -> [Can China build its own ASML?](https://nikkei.shorthandstories.com/can-china-build-its-own-asml/)<!-- HN:48705276:end --><!-- HN:48703968:start -->
* [48703968](https://news.social-protocols.org/stats?id=48703968) #12 205 points 131 comments -> [Ford hired AI and sacked humans. It backfired badly](https://www.the-independent.com/tech/ford-ai-automation-human-workers-b3003787.html)<!-- HN:48703968:end --><!-- HN:48655158:start -->
* [48655158](https://news.social-protocols.org/stats?id=48655158) #12 5 points 0 comments -> [Instantiating UI Components with Distinguishing Variations [pdf]](https://static.barik.net/barik/publications/chi2026/vaithilingam_celestial_chi26.pdf)<!-- HN:48655158:end --><!-- HN:48706690:start -->
* [48706690](https://news.social-protocols.org/stats?id=48706690) #19 14 points 14 comments -> [Guy in his basement creates a drug to treat Alzheimer's disease using AI](https://twitter.com/DouglasYaoDY/status/2070904914050797582)<!-- HN:48706690:end --><!-- HN:48706903:start -->
* [48706903](https://news.social-protocols.org/stats?id=48706903) #4 23 points 41 comments -> [Greece Is Richer. So Why Do So Many Greeks Still Feel Poor?](https://www.dnews.gr/eidhseis/news-in-english/596650/greece-is-richer-so-why-do-so-many-greeks-still-feel-poor)<!-- HN:48706903:end --><!-- HN:48708265:start -->
* [48708265](https://news.social-protocols.org/stats?id=48708265) #20 7 points 3 comments -> [Does Your Paper Really Suck?](https://www.sina.bio/posts/does-your-paper-really-suck.html)<!-- HN:48708265:end --><!-- HN:48710749:start -->
* [48710749](https://news.social-protocols.org/stats?id=48710749) #9 120 points 43 comments -> [Ford rehires 'gray beard' engineers after AI falls short](https://techcrunch.com/2026/06/28/ford-rehires-gray-beard-engineers-after-ai-falls-short/)<!-- HN:48710749:end --><!-- HN:48712604:start -->
* [48712604](https://news.social-protocols.org/stats?id=48712604) #15 9 points 2 comments -> [Microsoft worker emails employees about company's support of Israel](https://www.thecanary.co/global/world-analysis/2026/06/26/microsoft-worker-emails/)<!-- HN:48712604:end -->
#### **Monday, June 29, 2026**
<!-- HN:48712338:start -->
* [48712338](https://news.social-protocols.org/stats?id=48712338) #3 35 points 2 comments -> [A QNX-inspired operating system with selectable kernels](https://qsoe.net)<!-- HN:48712338:end --><!-- HN:48713686:start -->
* [48713686](https://news.social-protocols.org/stats?id=48713686) #5 22 points 13 comments -> [Sophon PFG-1: a monolithic-3D AI ASIC with 330 GB of on-die DRAM and no HBM](https://www.phantafield.com/whitepaper)<!-- HN:48713686:end --><!-- HN:48713887:start -->
* [48713887](https://news.social-protocols.org/stats?id=48713887) #8 68 points 16 comments -> [Tell Congress: Don't Force Age Checks Online](https://act.eff.org/action/tell-congress-don-t-force-age-checks-online)<!-- HN:48713887:end --><!-- HN:48714919:start -->
* [48714919](https://news.social-protocols.org/stats?id=48714919) #4 21 points 4 comments -> [Some Simple Economics of AGI](https://papers.ssrn.com/sol3/papers.cfm?abstract_id=6298838)<!-- HN:48714919:end --><!-- HN:48717573:start -->
* [48717573](https://news.social-protocols.org/stats?id=48717573) #18 4 points 0 comments -> [Children in West Bank are being killed by Israel without accountability](https://www.theguardian.com/world/2026/jun/29/is-it-israels-aim-to-kill-our-children-west-bank-parents-implore-end-to-idfs-child-killings-with-impunity)<!-- HN:48717573:end --><!-- HN:48683417:start -->
* [48683417](https://news.social-protocols.org/stats?id=48683417) #14 9 points 1 comments -> [The Meadows of Medieval Summer](https://www.historytoday.com/archive/out-margins/meadows-medieval-summer)<!-- HN:48683417:end --><!-- HN:48719665:start -->
* [48719665](https://news.social-protocols.org/stats?id=48719665) #27 54 points 35 comments -> [A field guide to the modern front end for developers who hand-wrote HTML](https://davidpoblador.com/deep-dives/the-descent/)<!-- HN:48719665:end --><!-- HN:48720179:start -->
* [48720179](https://news.social-protocols.org/stats?id=48720179) #10 12 points 3 comments -> [WebGL Without a GPU](https://microlink.io/blog/webgl-without-a-gpu)<!-- HN:48720179:end --><!-- HN:48719483:start -->
* [48719483](https://news.social-protocols.org/stats?id=48719483) #20 12 points 6 comments -> [DocumentDB – a MongoDB compatible open-source database](https://documentdb.io/)<!-- HN:48719483:end --><!-- HN:48720997:start -->
* [48720997](https://news.social-protocols.org/stats?id=48720997) #4 15 points 0 comments -> [Mullvad's co-founder is bankrolling the far right](https://korben.info/en/mullvad-cofounder-funding-far-right.html)<!-- HN:48720997:end --><!-- HN:48721083:start -->
* [48721083](https://news.social-protocols.org/stats?id=48721083) #2 30 points 6 comments -> [Mullvad VPN co-founder donated ~500,000USD to Swedish far-right political party](https://www.flamman.se/techprofil-ger-miljoner-till-orebropartiet/)<!-- HN:48721083:end --><!-- HN:48722366:start -->
* [48722366](https://news.social-protocols.org/stats?id=48722366) #6 12 points 0 comments -> [Mullvad's co-founder is bankrolling the far right](https://korben.info/en/mullvad-cofounder-funding-far-right.html)<!-- HN:48722366:end --><!-- HN:48723276:start -->
* [48723276](https://news.social-protocols.org/stats?id=48723276) #13 17 points 9 comments -> [The 80% Problem: The Last 20% Is Where the Engineer Used to Live](https://www.jonathanbeard.io/blog/2026/06/27/the-80-percent-problem.html)<!-- HN:48723276:end --><!-- HN:48668269:start -->
* [48668269](https://news.social-protocols.org/stats?id=48668269) #17 11 points 6 comments -> [Alternatives to Nested If Function](https://medium.com/@crispomwangi/7-alternatives-to-nested-if-function-a9cb07f3df1e)<!-- HN:48668269:end -->
#### **Tuesday, June 30, 2026**
<!-- HN:48727059:start -->
* [48727059](https://news.social-protocols.org/stats?id=48727059) #17 4 points 3 comments -> [What any website can see about you](https://mysysinfo.com)<!-- HN:48727059:end --><!-- HN:48725359:start -->
* [48725359](https://news.social-protocols.org/stats?id=48725359) #22 29 points 40 comments -> [You really shouldn't copy-paste errors into Claude Code](https://home.robusta.dev/blog/you-really-shouldnt-copy-paste-errors-into-claude-code)<!-- HN:48725359:end --><!-- HN:48727538:start -->
* [48727538](https://news.social-protocols.org/stats?id=48727538) #25 26 points 22 comments -> [Why Won't Europe Build AI Data Centers in Iceland?](https://mrkt30.com/why-wont-europe-build-ai-data-centers-in-iceland/)<!-- HN:48727538:end --><!-- HN:48728442:start -->
* [48728442](https://news.social-protocols.org/stats?id=48728442) #30 10 points 0 comments -> [ICE Tracks Down Woman to Force Her to Delete Instagram Post](https://newrepublic.com/post/212340/ice-poll-worker-election-delete-instagram-post)<!-- HN:48728442:end -->