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
* [49411027](https://news.social-protocols.org/stats?id=49411027) #21 4 points 0 comments -> [Yuval Noah Harari on the economic and political perils of AI](https://www.economist.com/business/2026/08/20/yuval-noah-harari-on-the-economic-and-political-perils-of-ai)<!-- HN:49411027:end --><!-- HN:49411268:start -->
* [49411268](https://news.social-protocols.org/stats?id=49411268) #14 8 points 9 comments -> [Say It Four Times (In Your System Prompt)](https://www.khola.blog/p/say-it-four-times)<!-- HN:49411268:end --><!-- HN:49412274:start -->
* [49412274](https://news.social-protocols.org/stats?id=49412274) #14 5 points 0 comments -> [We gave nine LLMs the same PDF. Two answered without reading it](https://theaijudge.com/en/blog/we-gave-nine-llms-the-same-pdf/)<!-- HN:49412274:end --><!-- HN:49410927:start -->
* [49410927](https://news.social-protocols.org/stats?id=49410927) #26 11 points 0 comments -> [From Front Panel to Program: Thinking Like a PDP-8](https://pikuma.com/blog/pdp-8-minicomputer)<!-- HN:49410927:end --><!-- HN:49412548:start -->
* [49412548](https://news.social-protocols.org/stats?id=49412548) #14 5 points 1 comments -> [Cicada.os – Graphene.os for Your Laptop](https://kpres12.github.io/Cicada.OS/)<!-- HN:49412548:end --><!-- HN:49410480:start -->
* [49410480](https://news.social-protocols.org/stats?id=49410480) #25 30 points 40 comments -> [Erik Brynjolfsson says an AI "job apocalypse" is unlikely](https://wpintelligence.washingtonpost.com/topics/ai-tech/2026/08/19/wpi-conversation-why-an-ai-job-apocalypse-is-unlikely/)<!-- HN:49410480:end --><!-- HN:49407944:start -->
* [49407944](https://news.social-protocols.org/stats?id=49407944) #26 23 points 1 comments -> [Andrew Ng: "AI Engineering Skills Map: Building and Deploying AI Applications"](https://twitter.com/AndrewYNg/status/2090840747738374568)<!-- HN:49407944:end -->
#### **Monday, August 24, 2026**
<!-- HN:49414676:start -->
* [49414676](https://news.social-protocols.org/stats?id=49414676) #4 8 points 6 comments -> [Fastmail Pricing Changes](https://www.fastmail.com/pricing/us/)<!-- HN:49414676:end --><!-- HN:49415237:start -->
* [49415237](https://news.social-protocols.org/stats?id=49415237) #20 11 points 4 comments -> [AI Is Quietly Draining the Public Internet of Thought](https://twitter.com/BrianRoemmele/status/2091127620431933780)<!-- HN:49415237:end --><!-- HN:49414651:start -->
* [49414651](https://news.social-protocols.org/stats?id=49414651) #19 7 points 0 comments -> [This Fact About KPIs May Surprise You](https://www.satisfice.com/blog/archives/488189)<!-- HN:49414651:end --><!-- HN:49413093:start -->
* [49413093](https://news.social-protocols.org/stats?id=49413093) #30 55 points 40 comments -> [Parallel development without the headaches using Git worktree](https://barrd.dev/article/parallel-development-without-the-headaches-using-git-worktree/)<!-- HN:49413093:end --><!-- HN:49415695:start -->
* [49415695](https://news.social-protocols.org/stats?id=49415695) #23 6 points 1 comments -> [LLM Tool Failures: Only 3 Root Causes – Value, Condition, Intent](https://github.com/Jang-woo-AnnaSoft/execution-state-preflight/blob/main/who-fills-in-the-form.md)<!-- HN:49415695:end --><!-- HN:49416200:start -->
* [49416200](https://news.social-protocols.org/stats?id=49416200) #6 24 points 40 comments -> [The Work Number: credit score but for your employment history – by Equifax](https://employees.theworknumber.com)<!-- HN:49416200:end --><!-- HN:49421421:start -->
* [49421421](https://news.social-protocols.org/stats?id=49421421) #11 5 points 0 comments -> [Majority of Britons say free speech has deteriorated under Labour](https://www.gbnews.com/news/free-speech-worsened-under-labour-liberty-polling)<!-- HN:49421421:end --><!-- HN:49421068:start -->
* [49421068](https://news.social-protocols.org/stats?id=49421068) #20 3 points 0 comments -> [Thefinalthirdfootball](https://thefinalthirdfootball.blogspot.com/2026/08/hull-city-2-0-manchester-united-carrick.html)<!-- HN:49421068:end --><!-- HN:49421005:start -->
* [49421005](https://news.social-protocols.org/stats?id=49421005) #12 6 points 1 comments -> [How to choose chocolate (not based on percentage)](https://chof.nl/how-to-choose-chocolate)<!-- HN:49421005:end --><!-- HN:49422278:start -->
* [49422278](https://news.social-protocols.org/stats?id=49422278) #18 5 points 1 comments -> [A Practical Intuition for C++20 Coroutines](https://blog.ydb.tech/making-coroutines-routine-building-a-scalable-tpc-c-client-in-c-b14f55a09471?postPublishedType=repub)<!-- HN:49422278:end --><!-- HN:49422220:start -->
* [49422220](https://news.social-protocols.org/stats?id=49422220) #15 6 points 8 comments -> [A Server Lost Power at 00:32. We Found Out at 08:18](https://danubedata.ro/blog/storage-power-loss-postmortem-august-2026)<!-- HN:49422220:end --><!-- HN:49422404:start -->
* [49422404](https://news.social-protocols.org/stats?id=49422404) #17 62 points 11 comments -> [Man Dressed as Darth Vader Defends Flock Cameras to San Diego City Council](https://thehill.com/policy/technology/6042349-darth-vader-flock-surveillance/)<!-- HN:49422404:end --><!-- HN:49423500:start -->
* [49423500](https://news.social-protocols.org/stats?id=49423500) #16 5 points 0 comments -> [Claude Code Tips](https://github.com/ykdojo/claude-code-tips)<!-- HN:49423500:end --><!-- HN:49423832:start -->
* [49423832](https://news.social-protocols.org/stats?id=49423832) #12 6 points 7 comments -> [Technology Is Over](https://www.taylorforeman.com/p/technology-is-over)<!-- HN:49423832:end --><!-- HN:49423445:start -->
* [49423445](https://news.social-protocols.org/stats?id=49423445) #20 13 points 4 comments -> [Adding 4 more 2.5GbE interfaces to the GMKtec NucBox G9](https://catskull.net/adding-4-more-25gbe-interfaces-to-the-gmktec-nucbox-g9.html)<!-- HN:49423445:end --><!-- HN:49357290:start -->
* [49357290](https://news.social-protocols.org/stats?id=49357290) #21 38 points 3 comments -> [Curvature Beziers – Improving on a timeless recipe](https://acko.net/blog/curvature-beziers/)<!-- HN:49357290:end --><!-- HN:49425867:start -->
* [49425867](https://news.social-protocols.org/stats?id=49425867) #14 3 points 0 comments -> [Assinafy – Assinatura eletrônica grátis and API liberada](https://www.assinafy.com.br)<!-- HN:49425867:end --><!-- HN:49426118:start -->
* [49426118](https://news.social-protocols.org/stats?id=49426118) #8 5 points 1 comments -> [NIST is selling Peanut Butter for $415.33 per jar](https://shop.nist.gov/ccrz__ProductDetails?sku=2387)<!-- HN:49426118:end -->
#### **Tuesday, August 25, 2026**
<!-- HN:49427825:start -->
* [49427825](https://news.social-protocols.org/stats?id=49427825) #30 11 points 2 comments -> [What languages are agent skills written in?](https://plicara.ai/research/agent-skill-languages/)<!-- HN:49427825:end --><!-- HN:49429345:start -->
* [49429345](https://news.social-protocols.org/stats?id=49429345) #12 -> [Rupert Lowe set to be paid as much for divisive posts on X as for being MP](https://www.theguardian.com/politics/2026/aug/24/rupert-lowe-restore-britain-earn-same-on-x-as-being-mp-elon-musk)<!-- HN:49429345:end --><!-- HN:49431119:start -->
* [49431119](https://news.social-protocols.org/stats?id=49431119) #10 9 points 6 comments -> [Ox Alpha – A mysterious new AI model](https://oxalpha.com)<!-- HN:49431119:end --><!-- HN:49433372:start -->
* [49433372](https://news.social-protocols.org/stats?id=49433372) #23 48 points 91 comments -> [US data centers tripled annual water consumption to 17B gallons](https://forgeeks.net/us-data-centers-water-use-17-billion-gallons/)<!-- HN:49433372:end --><!-- HN:49433759:start -->
* [49433759](https://news.social-protocols.org/stats?id=49433759) #23 25 points 40 comments -> [The state of AI in 2026: On the road to ROI](https://www.mckinsey.com/capabilities/quantumblack/our-insights/the-state-of-ai)<!-- HN:49433759:end --><!-- HN:49433064:start -->
* [49433064](https://news.social-protocols.org/stats?id=49433064) #5 109 points 50 comments -> [France's tax agency got hacked (in French)](https://www.cybernetica.fr/piratage-des-impots-comment-en-est-on-arrive-la/)<!-- HN:49433064:end --><!-- HN:49436556:start -->
* [49436556](https://news.social-protocols.org/stats?id=49436556) #8 3 points 0 comments -> [Why iPhone App Blockers Are Harder to Build Than They Look](https://usefella.com/blog/how-iphone-app-blockers-work/)<!-- HN:49436556:end --><!-- HN:49436536:start -->
* [49436536](https://news.social-protocols.org/stats?id=49436536) #11 20 points 43 comments -> [Anthropic Sees over $30T in Potential Revenue](https://www.wsj.com/tech/ai/anthropic-expected-to-tell-investors-it-sees-over-30-trillion-in-potential-revenue-a611efea)<!-- HN:49436536:end --><!-- HN:49438178:start -->
* [49438178](https://news.social-protocols.org/stats?id=49438178) #27 7 points 1 comments -> [Dolly Parton, queen of country music and humanitarian hero, dead at 80](https://www.cnn.com/2026/08/25/entertainment/dolly-parton-death)<!-- HN:49438178:end -->