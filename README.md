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

#### **Monday, August 17, 2026**
<!-- HN:49284093:start -->
* [49284093](https://news.social-protocols.org/stats?id=49284093) #27 4 points 9 comments -> [2,085 Tests, and None of Them Opens the Front Door](https://i.brandanthonymcdonald.com/what-my-tests-do-not-cover)<!-- HN:49284093:end --><!-- HN:49326443:start -->
* [49326443](https://news.social-protocols.org/stats?id=49326443) #29 12 points 7 comments -> [Hayden Panetierre Dies at 36](https://abcnews.com/US/hayden-panettiere-dies-36/story?id=135698473)<!-- HN:49326443:end --><!-- HN:49259980:start -->
* [49259980](https://news.social-protocols.org/stats?id=49259980) #11 191 points 54 comments -> [Low-Tech Ceramic Water Filter](https://wiki.lowtechlab.org/wiki/Filtre_%C3%A0_eau_c%C3%A9ramique/en)<!-- HN:49259980:end --><!-- HN:49245021:start -->
* [49245021](https://news.social-protocols.org/stats?id=49245021) #14 47 points 30 comments -> [Show HN: Vocal Slice – cut audio by selecting text, fully on-device](https://vocalslice.com/)<!-- HN:49245021:end --><!-- HN:49231418:start -->
* [49231418](https://news.social-protocols.org/stats?id=49231418) #20 61 points 14 comments -> [Interview with Amit Patel, Creator of "Solar Realms Elite"](https://breakintochat.com/blog/2013/02/18/amit-patel-creator-of-solar-realms-elite/)<!-- HN:49231418:end --><!-- HN:49257362:start -->
* [49257362](https://news.social-protocols.org/stats?id=49257362) #21 43 points 5 comments -> [Dancing with friends and enemies: boids' swarm intelligence](https://community.wolfram.com/groups/-/m/t/122095)<!-- HN:49257362:end --><!-- HN:49281175:start -->
* [49281175](https://news.social-protocols.org/stats?id=49281175) #27 19 points 1 comments -> [Production-ready detection and response queries for osquery](https://github.com/chainguard-dev/osquery-defense-kit)<!-- HN:49281175:end --><!-- HN:49330604:start -->
* [49330604](https://news.social-protocols.org/stats?id=49330604) #7 27 points 42 comments -> [Show HN: 1667, a terminal UI for writing fiction with language models](https://1667.ai/)<!-- HN:49330604:end --><!-- HN:49330139:start -->
* [49330139](https://news.social-protocols.org/stats?id=49330139) #14 91 points 40 comments -> [Stripe to Buy OpenRouter for $7B](https://www.bloomberg.com/news/articles/2026-08-16/stripe-nears-deal-to-buy-ai-firm-openrouter-for-over-7-billion)<!-- HN:49330139:end --><!-- HN:49291411:start -->
* [49291411](https://news.social-protocols.org/stats?id=49291411) #10 10 points 0 comments -> [File Recovery in Process](https://gwolf.org/2026/08/file-recovery-in-process.html)<!-- HN:49291411:end --><!-- HN:49331599:start -->
* [49331599](https://news.social-protocols.org/stats?id=49331599) #20 9 points 2 comments -> [Show HN: Eve Software Factory](https://github.com/vercel-labs/eve-software-factory-template/tree/main)<!-- HN:49331599:end --><!-- HN:49330386:start -->
* [49330386](https://news.social-protocols.org/stats?id=49330386) #27 8 points 0 comments -> [Show HN: LLMs each trading $100K vs. a frozen rulebook – the rulebook leads](https://aitradingcompetition.com/)<!-- HN:49330386:end --><!-- HN:49333450:start -->
* [49333450](https://news.social-protocols.org/stats?id=49333450) #29 4 points 0 comments -> [Too Little, Too Late: Flock Admits Their Technology Needs Reforms](https://www.theindianalawyer.com/articles/amazons-new-user-agreement-seeks-to-curb-class-action-suits)<!-- HN:49333450:end --><!-- HN:49335216:start -->
* [49335216](https://news.social-protocols.org/stats?id=49335216) #20 89 points 9 comments -> [Amazon, which started off selling books, is destroying rare texts to train AI](https://techcrunch.com/2026/08/17/amazon-once-an-online-bookseller-is-destroying-rare-books-to-train-ai-models/)<!-- HN:49335216:end --><!-- HN:49336050:start -->
* [49336050](https://news.social-protocols.org/stats?id=49336050) #8 117 points 5 comments -> [AirTag reveals Amazon is trashing rare books to train AI](https://arstechnica.com/tech-policy/2026/08/hidden-airtag-reveals-amazon-is-trashing-rare-books-to-train-ai/)<!-- HN:49336050:end --><!-- HN:49335292:start -->
* [49335292](https://news.social-protocols.org/stats?id=49335292) #21 40 points 31 comments -> [How I Over-Engineered My Book](https://ben.balter.com/2026/08/17/how-i-over-engineered-my-book/)<!-- HN:49335292:end --><!-- HN:49336520:start -->
* [49336520](https://news.social-protocols.org/stats?id=49336520) #21 13 points 1 comments -> [Three Minutes of Sprinting Beats 90 Minutes of Moderate Exercise](https://www.cell.com/cell-reports-medicine/fulltext/S2666-3791(26)00405-2?_returnURL=https%3A%2F%2Flinkinghub.elsevier.com%2Fretrieve%2Fpii%2FS2666379126004052%3Fshowall%3Dtrue)<!-- HN:49336520:end -->
#### **Tuesday, August 18, 2026**
<!-- HN:49339349:start -->
* [49339349](https://news.social-protocols.org/stats?id=49339349) #9 6 points 2 comments -> [Un-AI Your Internet](https://un-ai.digitalprophet.online/)<!-- HN:49339349:end --><!-- HN:49339359:start -->
* [49339359](https://news.social-protocols.org/stats?id=49339359) #2 45 points 19 comments -> [Cursor Origin](https://cursor.com/docs/origin)<!-- HN:49339359:end --><!-- HN:49341271:start -->
* [49341271](https://news.social-protocols.org/stats?id=49341271) #9 5 points 1 comments -> [DeepSeek-V4-Pro outperforms Fable 5 after fixing runtime inference control](https://github.com/Tiger3807861189/DeepSeek-V4-J-Space-Capability-Realization-Report)<!-- HN:49341271:end --><!-- HN:49342601:start -->
* [49342601](https://news.social-protocols.org/stats?id=49342601) #1 38 points 11 comments -> [git git git git git](https://caiustheory.com/git-git-git-git-git/)<!-- HN:49342601:end --><!-- HN:49345448:start -->
* [49345448](https://news.social-protocols.org/stats?id=49345448) #3 7 points 3 comments -> [AI to help planes avoid climate-warming 'sky graffiti'](https://www.bbc.com/news/articles/c62em5lpvnjo)<!-- HN:49345448:end --><!-- HN:49345438:start -->
* [49345438](https://news.social-protocols.org/stats?id=49345438) #3 22 points 0 comments -> [A group of Gandalfs protest outside the home of Peter Thiel in Argentina](https://dangerousminds.net/weird-news/gandalfs-protest-outside-the-home-peter-thiel-argentina/)<!-- HN:49345438:end --><!-- HN:49345154:start -->
* [49345154](https://news.social-protocols.org/stats?id=49345154) #12 21 points 15 comments -> [Show HN: I canceled my AI code reviewer and wrote a free local one](https://github.com/mukundzha/avouch)<!-- HN:49345154:end --><!-- HN:49346591:start -->
* [49346591](https://news.social-protocols.org/stats?id=49346591) #12 9 points 1 comments -> [Finger: A Protocol from 1977 Is Still Delivering Malware in 2026](https://artemissecurity.com/attack-stories/finger-protocol-python-rat-delivery/)<!-- HN:49346591:end --><!-- HN:49345320:start -->
* [49345320](https://news.social-protocols.org/stats?id=49345320) #19 28 points 23 comments -> [NeoBrowser: An MCP server that drives real Chrome with your logged-in sessions](https://github.com/pitiflautico/neobrowser)<!-- HN:49345320:end --><!-- HN:49346074:start -->
* [49346074](https://news.social-protocols.org/stats?id=49346074) #17 8 points 2 comments -> [Muse Glimmer is a memory hierarchy disguised as a 30B Transformer](https://abstractextraordinary.com/blog/how-muse-glimmer-fits-an-agent-on-your-device/)<!-- HN:49346074:end --><!-- HN:49348060:start -->
* [49348060](https://news.social-protocols.org/stats?id=49348060) #20 3 points 0 comments -> [A local ePub eBook server for my xteink](https://solariz.de/posts/26/04-xteink-local-epub-server)<!-- HN:49348060:end --><!-- HN:49348114:start -->
* [49348114](https://news.social-protocols.org/stats?id=49348114) #26 2 points 0 comments -> [Magnitude – Open-source AI coding agent that runs local models offline](https://digitalescapetools.com/tools/tool.html?id=magnitude)<!-- HN:49348114:end --><!-- HN:49349283:start -->
* [49349283](https://news.social-protocols.org/stats?id=49349283) #27 5 points 0 comments -> [Columbia House, Mail-Order Media Company, Is Shuttering](https://consequence.net/2026/08/columbia-house-closing-down/)<!-- HN:49349283:end --><!-- HN:49350833:start -->
* [49350833](https://news.social-protocols.org/stats?id=49350833) #13 6 points 2 comments -> [Could Four Billion People Die at 3°C?](https://safeclimate.org.au/article/could-four-billion-people-die-at-3c/)<!-- HN:49350833:end --><!-- HN:49351020:start -->
* [49351020](https://news.social-protocols.org/stats?id=49351020) #19 7 points 3 comments -> [Show HN: Argus, agentic QA for teams whose coding agents move faster than QA](https://github.com/argus-testing/argus)<!-- HN:49351020:end --><!-- HN:49351232:start -->
* [49351232](https://news.social-protocols.org/stats?id=49351232) #18 6 points 0 comments -> [llms.txt: a proposed standard no major AI platform has confirmed it uses](https://geojacker.com/llms-txt)<!-- HN:49351232:end --><!-- HN:49353181:start -->
* [49353181](https://news.social-protocols.org/stats?id=49353181) #17 46 points 17 comments -> [Flock impersonates journalist in order to cancel his hotel reservations](https://xcancel.com/bennjordan/status/2089430236945342508)<!-- HN:49353181:end -->
#### **Wednesday, August 19, 2026**
<!-- HN:49355368:start -->
* [49355368](https://news.social-protocols.org/stats?id=49355368) #18 19 points 2 comments -> [The Integer](https://gist.github.com/17twenty/1f230ab8256f42d4cd3ba931b9bd440b)<!-- HN:49355368:end --><!-- HN:49354778:start -->
* [49354778](https://news.social-protocols.org/stats?id=49354778) #30 27 points 6 comments -> [Why crypto's best infrastructure companies stopped looking like crypto?](https://konstantintkachuk.com/writing/depin-is-dead-long-live-infrastructure-as-a-service/)<!-- HN:49354778:end --><!-- HN:49279352:start -->
* [49279352](https://news.social-protocols.org/stats?id=49279352) #23 13 points 15 comments -> [I stopped caring about programming terms](https://teadriven.com/blog/why-i-stopped-caring-about-terminology/)<!-- HN:49279352:end --><!-- HN:49357881:start -->
* [49357881](https://news.social-protocols.org/stats?id=49357881) #6 8 points 3 comments -> [Show HN: Privacy focused client side password generator](https://password-generator.aaqa.dev/)<!-- HN:49357881:end --><!-- HN:49362044:start -->
* [49362044](https://news.social-protocols.org/stats?id=49362044) #6 11 points 15 comments -> [Proposal to prohibit vibe coded projects from being hosted on Sourcehut](https://lists.sr.ht/~sircmpwn/sr.ht-discuss/%3CDKSTMKM0ZD9N.2FTBDFREZH699@ddevault.org%3E)<!-- HN:49362044:end --><!-- HN:49362396:start -->
* [49362396](https://news.social-protocols.org/stats?id=49362396) #13 7 points 2 comments -> [X262: X264 with MPEG-2 Support](https://github.com/kierank/x262)<!-- HN:49362396:end --><!-- HN:49360384:start -->
* [49360384](https://news.social-protocols.org/stats?id=49360384) #29 7 points 1 comments -> [Sea Turtle Sex Crisis: Why 99% Are Now Female](https://mazingamazingly.blogspot.com/2026/08/sea-turtle-sex-crisis-why-99-are-now.html)<!-- HN:49360384:end --><!-- HN:49364158:start -->
* [49364158](https://news.social-protocols.org/stats?id=49364158) #19 5 points 1 comments -> [Blood Boy for All – Young blood is a human right](https://www.onethousandmeans.com/p/blood-boy-for-all)<!-- HN:49364158:end --><!-- HN:49366075:start -->
* [49366075](https://news.social-protocols.org/stats?id=49366075) #13 7 points 0 comments -> [Daily Reminder to Not Listen to Google's AI Overview](https://whatever.scalzi.com/2026/08/19/daily-reminder-to-not-listen-to-googles-ai-overview/)<!-- HN:49366075:end --><!-- HN:49366225:start -->
* [49366225](https://news.social-protocols.org/stats?id=49366225) #17 9 points 2 comments -> [You Probably Don't Get Why Stripe Bought OpenRouter](https://www.amppublic.com/research/openrouter)<!-- HN:49366225:end --><!-- HN:49365733:start -->
* [49365733](https://news.social-protocols.org/stats?id=49365733) #7 146 points 31 comments -> [Police officer used Flock cameras to track estranged wife 717 times](https://www.wsbtv.com/news/trending/affidavit-police-officer-used-flock-cameras-track-estranged-wife-717-times/5DVBYU2XTJEVDJR7LPZCBR7M5M/)<!-- HN:49365733:end --><!-- HN:49366704:start -->
* [49366704](https://news.social-protocols.org/stats?id=49366704) #15 12 points 1 comments -> [Copper Shortage Threatens the Green Transition](https://www.economyprism.com/2026/04/copper-shortage-threatens-green.html)<!-- HN:49366704:end -->
#### **Thursday, August 20, 2026**
<!-- HN:49317965:start -->
* [49317965](https://news.social-protocols.org/stats?id=49317965) #11 13 points 5 comments -> [Free v4 front end for your v6 site](https://v4-frontend.netiter.com/)<!-- HN:49317965:end --><!-- HN:49372792:start -->
* [49372792](https://news.social-protocols.org/stats?id=49372792) #15 29 points 43 comments -> [If this is true, the hyperscalers are toast](https://klementoninvesting.substack.com/p/if-this-is-true-the-hyperscalers)<!-- HN:49372792:end --><!-- HN:49374177:start -->
* [49374177](https://news.social-protocols.org/stats?id=49374177) #6 4 points 1 comments -> [Sokoban via Grok App Builder](https://sokoban.grok.me/)<!-- HN:49374177:end --><!-- HN:49374599:start -->
* [49374599](https://news.social-protocols.org/stats?id=49374599) #7 5 points 1 comments -> [Index of the best vibe coding tools](https://www.vibeleaderboard.ai/tools)<!-- HN:49374599:end --><!-- HN:49374376:start -->
* [49374376](https://news.social-protocols.org/stats?id=49374376) #18 6 points 2 comments -> [MH370 mystery deepens with new evidence](https://vt.co/news/world/mh370-aviation-mystery-new-evidence-wrong-place)<!-- HN:49374376:end --><!-- HN:49375164:start -->
* [49375164](https://news.social-protocols.org/stats?id=49375164) #17 -> [Grok.bot – the epic domain lottery ticket](https://grok.bot/)<!-- HN:49375164:end --><!-- HN:49376287:start -->
* [49376287](https://news.social-protocols.org/stats?id=49376287) #5 22 points 6 comments -> [I Am Morally Opposed to Updating My Claude.md](https://alex-jacobs.com/posts/claudemd/)<!-- HN:49376287:end --><!-- HN:49300438:start -->
* [49300438](https://news.social-protocols.org/stats?id=49300438) #22 7 points 2 comments -> [I bought the most expensive cable I could find. It still died](https://medium.com/@pokhts/i-bought-the-most-expensive-cable-i-could-and-it-still-died-welcome-to-rs485-vs-1000v-dc-d9e73d31a607)<!-- HN:49300438:end --><!-- HN:49377249:start -->
* [49377249](https://news.social-protocols.org/stats?id=49377249) #25 23 points 11 comments -> [The Defense-Tech Bubble Is Headed for Consolidation](https://foxandlion.pub/analysis/the-defense-tech-bubble-is-headed-for-consolidation)<!-- HN:49377249:end --><!-- HN:49378036:start -->
* [49378036](https://news.social-protocols.org/stats?id=49378036) #16 17 points 1 comments -> [Bitflash: A Tor-native revival of Bitcoin 0.1.0, mined on CPUs with RandomX](https://bitflash.network/)<!-- HN:49378036:end --><!-- HN:49378724:start -->
* [49378724](https://news.social-protocols.org/stats?id=49378724) #21 4 points 0 comments -> [Seeking God in Science Part 10.5: The Mind-Body Problem (Take 2)](http://blog.rongarret.info/2026/08/seeking-god-in-science-part-105-mind.html)<!-- HN:49378724:end --><!-- HN:49378305:start -->
* [49378305](https://news.social-protocols.org/stats?id=49378305) #30 6 points 2 comments -> [Show HN: Kandelo – a POSIX-compatible multi-process WASM kernel for the browser](https://kandelo.dev/20260819-demo/)<!-- HN:49378305:end --><!-- HN:49380555:start -->
* [49380555](https://news.social-protocols.org/stats?id=49380555) #30 4 points 1 comments -> [Pursuit of AGI](https://cognitus.grrn.io)<!-- HN:49380555:end -->
#### **Friday, August 21, 2026**
<!-- HN:49328758:start -->
* [49328758](https://news.social-protocols.org/stats?id=49328758) #21 8 points 5 comments -> [My Microscope Is a Dashcam](https://xecaz.com/reverse.engineering/tomlovdm9/)<!-- HN:49328758:end --><!-- HN:49321581:start -->
* [49321581](https://news.social-protocols.org/stats?id=49321581) #19 4 points 0 comments -> [The Quora Collapse](https://www.harperflow.io/dead-internet/quora-collapse)<!-- HN:49321581:end --><!-- HN:49386884:start -->
* [49386884](https://news.social-protocols.org/stats?id=49386884) #28 7 points 1 comments -> [If Your New People Are on X, Maybe Your New People Suck](https://coyotetracks.org/blog/new-people-on-x/)<!-- HN:49386884:end --><!-- HN:49387059:start -->
* [49387059](https://news.social-protocols.org/stats?id=49387059) #18 12 points 2 comments -> [AI;DR or Don't be a meat proxy](https://theaspiringnerd.com/aidr-or-dont-be-a-meat-proxy/)<!-- HN:49387059:end --><!-- HN:49388288:start -->
* [49388288](https://news.social-protocols.org/stats?id=49388288) #11 14 points 2 comments -> [Olympian Jenny Simpson Says Her Running Career Is Over After Cardiac Arrest](https://www.runnersworld.com/news/a73487839/jenny-simpson-running-cardiac-event-update/)<!-- HN:49388288:end --><!-- HN:49389948:start -->
* [49389948](https://news.social-protocols.org/stats?id=49389948) #28 5 points 1 comments -> [Flagwars.lol](https://www.flagwars.lol)<!-- HN:49389948:end --><!-- HN:49389912:start -->
* [49389912](https://news.social-protocols.org/stats?id=49389912) #18 6 points 2 comments -> [My AI agents kept trying to cross red lines, so I wrote them a constitution](https://github.com/Chong169/a-constitution-for-one)<!-- HN:49389912:end --><!-- HN:49389861:start -->
* [49389861](https://news.social-protocols.org/stats?id=49389861) #22 7 points 7 comments -> [Every shape can be cut exactly in half with one straight line](https://bisecto.com/every-shape-can-be-cut-in-half.html)<!-- HN:49389861:end --><!-- HN:49385994:start -->
* [49385994](https://news.social-protocols.org/stats?id=49385994) #2 689 points 2 comments -> [AI companies destroy physical books – let's scan rare books before it's too late](https://annas-archive.pk/blog/physical-destruction.html)<!-- HN:49385994:end --><!-- HN:49389565:start -->
* [49389565](https://news.social-protocols.org/stats?id=49389565) #18 163 points 118 comments -> [AI Boosted Homework Scores by 18% – Then Exam Scores Dropped 20%, Study Shows](https://canews24.online/?p=71)<!-- HN:49389565:end --><!-- HN:49386659:start -->
* [49386659](https://news.social-protocols.org/stats?id=49386659) #22 122 points 39 comments -> [TigerBeetle Core System Architecture: Deconstructing Performance Engineering](https://ixuvo.com/blog/tigerbeetle-core-system-architecture-performance-engineering)<!-- HN:49386659:end --><!-- HN:49392179:start -->
* [49392179](https://news.social-protocols.org/stats?id=49392179) #24 4 points 0 comments -> [A look under our trunk: what's in our compute of Waymo taxis](https://waymo.com/blog/2026/08/look-under-our-trunk/)<!-- HN:49392179:end --><!-- HN:49392449:start -->
* [49392449](https://news.social-protocols.org/stats?id=49392449) #30 6 points 7 comments -> [Death to the Self-Playing Game](https://www.jank.cool/death-to-the-self-playing-game/)<!-- HN:49392449:end -->
#### **Saturday, August 22, 2026**
<!-- HN:49394985:start -->
* [49394985](https://news.social-protocols.org/stats?id=49394985) #9 26 points 35 comments -> [Electric shock gloves in use by police departments in Bellevue, Omaha](https://nebraskapublicmedia.org/en/news/news-articles/electric-shock-gloves-already-in-use-by-police-departments-in-bellevue-omaha/)<!-- HN:49394985:end --><!-- HN:49392654:start -->
* [49392654](https://news.social-protocols.org/stats?id=49392654) #22 28 points 6 comments -> [Rust Glancer](https://matklad.github.io/2026/08/21/rust-glancer.html)<!-- HN:49392654:end --><!-- HN:49395663:start -->
* [49395663](https://news.social-protocols.org/stats?id=49395663) #12 12 points 2 comments -> [US Debt-to-GDP Ratio](https://www.us-debt-clock.com/debt-to-gdp)<!-- HN:49395663:end --><!-- HN:49401567:start -->
* [49401567](https://news.social-protocols.org/stats?id=49401567) #3 8 points 2 comments -> [Htmx live is cool. Datastar is fast. This cow is raw and strong](https://stario.dev/ox)<!-- HN:49401567:end --><!-- HN:49398304:start -->
* [49398304](https://news.social-protocols.org/stats?id=49398304) #11 658 points 1 comments -> [Canada suspends trade negotiations with USA and match tariffs dollar for dollar](https://www.pm.gc.ca/en/news/statements/2026/08/21/statement-prime-minister-carney-canada-us-trade-negotiations)<!-- HN:49398304:end --><!-- HN:49403484:start -->
* [49403484](https://news.social-protocols.org/stats?id=49403484) #14 17 points 6 comments -> [Knowing When to Stop: The Art of Making a Loop Converge](https://a16z.com/knowing-when-to-stop-the-art-of-making-a-loop-converge/)<!-- HN:49403484:end --><!-- HN:49403228:start -->
* [49403228](https://news.social-protocols.org/stats?id=49403228) #28 17 points 10 comments -> [Fast and Hard Code](https://lucumr.pocoo.org/2026/8/22/fast-hard-code/)<!-- HN:49403228:end -->
#### **Sunday, August 23, 2026**<!-- HN:49406021:start -->
* [49406021](https://news.social-protocols.org/stats?id=49406021) #19 8 points 0 comments -> [The Covid-19 scandal is still unfolding](https://www.economist.com/united-states/2026/08/20/the-real-covid-19-scandal-is-still-unfolding)<!-- HN:49406021:end --><!-- HN:49410074:start -->
* [49410074](https://news.social-protocols.org/stats?id=49410074) #10 21 points 8 comments -> [Being nude in public can make us feel better about our bodies](https://www.bbc.com/future/article/20260820-how-social-nudity-can-boost-your-body-image)<!-- HN:49410074:end --><!-- HN:49410097:start -->
* [49410097](https://news.social-protocols.org/stats?id=49410097) #7 226 points 96 comments -> [GLM-5.3 (open-weight) beat Anthropic/OpenAI models – for 1/5 the cost](https://reinvently.co.uk/tools/ed-o-meter/)<!-- HN:49410097:end --><!-- HN:49411027:start -->
* [49411027](https://news.social-protocols.org/stats?id=49411027) #21 4 points 0 comments -> [Yuval Noah Harari on the economic and political perils of AI](https://www.economist.com/business/2026/08/20/yuval-noah-harari-on-the-economic-and-political-perils-of-ai)<!-- HN:49411027:end -->