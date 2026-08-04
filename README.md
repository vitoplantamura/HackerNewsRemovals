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

#### **Wednesday, July 29, 2026**
<!-- HN:49090083:start -->
* [49090083](https://news.social-protocols.org/stats?id=49090083) #5 55 points 2 comments -> [Anthropic publishes a practical key-recovery attack on HAWK-256](https://github.com/anthropics/cryptography-research-demo)<!-- HN:49090083:end --><!-- HN:49091153:start -->
* [49091153](https://news.social-protocols.org/stats?id=49091153) #9 19 points 42 comments -> [Schools are adding pepper-spraying drones to help combat active shooters](https://www.washingtonpost.com/nation/2026/07/28/schools-are-adding-pepper-spraying-drones-help-combat-active-shooters/)<!-- HN:49091153:end --><!-- HN:49095620:start -->
* [49095620](https://news.social-protocols.org/stats?id=49095620) #6 6 points 0 comments -> [Who's a Rat](https://whosarat.com/)<!-- HN:49095620:end --><!-- HN:49058673:start -->
* [49058673](https://news.social-protocols.org/stats?id=49058673) #19 14 points 8 comments -> [CSV Is Never Just CSV](https://immaschinenraum.blog/en/funpark/never-just-csv/)<!-- HN:49058673:end --><!-- HN:49095787:start -->
* [49095787](https://news.social-protocols.org/stats?id=49095787) #19 8 points 1 comments -> [We Hardened an AI Security Platform Against 16 Critical Vulnerabilities](https://aegis-security.higgsfield.app)<!-- HN:49095787:end --><!-- HN:49095823:start -->
* [49095823](https://news.social-protocols.org/stats?id=49095823) #17 13 points 3 comments -> [Starling: The first real desktop written by AI](https://starling.build/)<!-- HN:49095823:end --><!-- HN:49078196:start -->
* [49078196](https://news.social-protocols.org/stats?id=49078196) #15 -> [PostgreSQL's MVCC is bad. So is everyone else's](https://boringsql.com/posts/mvcc-bad-bad/)<!-- HN:49078196:end --><!-- HN:49096389:start -->
* [49096389](https://news.social-protocols.org/stats?id=49096389) #11 7 points 0 comments -> [Deleting Codeberg](https://thanosapollo.org/posts/deleting-codeberg/)<!-- HN:49096389:end --><!-- HN:49097611:start -->
* [49097611](https://news.social-protocols.org/stats?id=49097611) #8 7 points 0 comments -> [It doesn't matter whether "Matz is nice"](https://po-ru.com/2026/07/29/it-doesnt-matter-whether-matz-is-nice)<!-- HN:49097611:end --><!-- HN:49096493:start -->
* [49096493](https://news.social-protocols.org/stats?id=49096493) #24 7 points 5 comments -> [Pulse Path – a browser puzzle where placement is the only decision](https://pulsepathgame.netlify.app/)<!-- HN:49096493:end --><!-- HN:49098728:start -->
* [49098728](https://news.social-protocols.org/stats?id=49098728) #5 24 points 7 comments -> [The Scientific Literature Is Poisonous to LLMs](https://www.reinvent.science/p/the-scientific-literature-is-poisonous)<!-- HN:49098728:end --><!-- HN:49098417:start -->
* [49098417](https://news.social-protocols.org/stats?id=49098417) #27 26 points 9 comments -> [PostgreSQL's MVCC is bad. So is everyone else's](https://boringsql.com/posts/mvcc-bad-bad/)<!-- HN:49098417:end --><!-- HN:49099015:start -->
* [49099015](https://news.social-protocols.org/stats?id=49099015) #2 142 points 41 comments -> [Superlogical – Mitchell Hashimoto](https://mitchellh.com/writing/superlogical)<!-- HN:49099015:end --><!-- HN:49100035:start -->
* [49100035](https://news.social-protocols.org/stats?id=49100035) #21 24 points 3 comments -> [Infrastructure Patterns for Agentic Applications](https://render.com/blog/infrastructure-patterns-for-agentic-applications)<!-- HN:49100035:end --><!-- HN:49098466:start -->
* [49098466](https://news.social-protocols.org/stats?id=49098466) #6 132 points 52 comments -> [Hugging Face: Anatomy of a frontier-lab agent intrusion](https://huggingface-anatomy-of-frontier-lab-model-intrusion.static.hf.space/index.html)<!-- HN:49098466:end --><!-- HN:49040469:start -->
* [49040469](https://news.social-protocols.org/stats?id=49040469) #16 14 points 1 comments -> [Aurora DSQL: Scalable, Multi-Region OLTP](http://muratbuffalo.blogspot.com/2026/07/aurora-dsql-scalable-multi-region-oltp.html)<!-- HN:49040469:end --><!-- HN:49036404:start -->
* [49036404](https://news.social-protocols.org/stats?id=49036404) #28 34 points 17 comments -> [Learning Musical Multitasking](https://www.jefftk.com/p/learning-musical-multitasking)<!-- HN:49036404:end -->
#### **Thursday, July 30, 2026**
<!-- HN:49104611:start -->
* [49104611](https://news.social-protocols.org/stats?id=49104611) #7 8 points 2 comments -> [Sell Your AI Skills?](https://capabase.ai/learn/sell-your-ai-skills)<!-- HN:49104611:end --><!-- HN:49104996:start -->
* [49104996](https://news.social-protocols.org/stats?id=49104996) #12 16 points 6 comments -> [Starter Homes Are Piling Up While Luxury Homes Fly Off the Market](https://www.zillow.com/research/starter-homes-price-tiers-36571/)<!-- HN:49104996:end --><!-- HN:49106643:start -->
* [49106643](https://news.social-protocols.org/stats?id=49106643) #1 42 points 20 comments -> [EU now fears US interference in European elections](https://www.eunews.it/en/2026/07/29/eu-now-fears-us-interference-in-european-elections/)<!-- HN:49106643:end --><!-- HN:49106568:start -->
* [49106568](https://news.social-protocols.org/stats?id=49106568) #30 12 points 1 comments -> [Claude is down for 2nd consecutive day](https://status.claude.com/incidents/fsh2zzzl2c4l)<!-- HN:49106568:end --><!-- HN:49106529:start -->
* [49106529](https://news.social-protocols.org/stats?id=49106529) #16 4 points 2 comments -> [Show HN: Edge Drop- #1 productivity and unique clipboard 200 stars on GitHub](https://github.com/Deepender25/Edge-Drop)<!-- HN:49106529:end --><!-- HN:49105924:start -->
* [49105924](https://news.social-protocols.org/stats?id=49105924) #30 34 points 40 comments -> [Why the future is local app](https://getapps.cafe/blog/why-the-future-is-local-app)<!-- HN:49105924:end --><!-- HN:49109634:start -->
* [49109634](https://news.social-protocols.org/stats?id=49109634) #24 7 points 1 comments -> [UK police to arrest people for showing support for Palestine Action](https://twitter.com/metpoliceuk/status/2082527338735005811)<!-- HN:49109634:end --><!-- HN:49110215:start -->
* [49110215](https://news.social-protocols.org/stats?id=49110215) #22 4 points 1 comments -> [Show HN: I audited my AI leaderboard scale – every score dropped 6-15 points](https://agiranker.com/)<!-- HN:49110215:end --><!-- HN:49109440:start -->
* [49109440](https://news.social-protocols.org/stats?id=49109440) #2 403 points 144 comments -> ['VPNs are lawful technical tools,' says EU Court in landmark copyright ruling](https://remysharp.com/links/2026-07-23-35890312)<!-- HN:49109440:end --><!-- HN:49111925:start -->
* [49111925](https://news.social-protocols.org/stats?id=49111925) #10 4 points 0 comments -> [Postgres rewritten in Rust v0.2, now faster than Postgres and ClickHouse](https://github.com/malisper/pgrust/releases/tag/v0.2-release)<!-- HN:49111925:end --><!-- HN:49111312:start -->
* [49111312](https://news.social-protocols.org/stats?id=49111312) #17 7 points 3 comments -> [Show HN: I think I made my own web version of minimalistic audacity](https://github.com/askpext/HERTZ)<!-- HN:49111312:end --><!-- HN:49115620:start -->
* [49115620](https://news.social-protocols.org/stats?id=49115620) #12 18 points 17 comments -> [I obtained Claude Opus 5 system prompt](https://claude.ai/share/98073770-0ad9-431f-a1e7-e0243db18758)<!-- HN:49115620:end -->
#### **Friday, July 31, 2026**
<!-- HN:49119322:start -->
* [49119322](https://news.social-protocols.org/stats?id=49119322) #8 10 points 1 comments -> [Human Honeypot](https://human2llm.pages.dev/)<!-- HN:49119322:end --><!-- HN:49122462:start -->
* [49122462](https://news.social-protocols.org/stats?id=49122462) #4 6 points 0 comments -> [About 60k migrants arrive in Ceuta in 24 hours, Spanish territory's leader says](https://www.bbc.com/news/articles/cx2kp639yx4o)<!-- HN:49122462:end --><!-- HN:49122785:start -->
* [49122785](https://news.social-protocols.org/stats?id=49122785) #17 7 points 0 comments -> [Another Reason Not to Use "AI" for Your Writing](https://whatever.scalzi.com/2026/07/31/another-reason-not-to-use-ai-for-your-writing/)<!-- HN:49122785:end --><!-- HN:49124690:start -->
* [49124690](https://news.social-protocols.org/stats?id=49124690) #13 4 points 1 comments -> [Next-Level Productivity Revealed to Be Smart Sticky Notes](https://www.taskloco.com/)<!-- HN:49124690:end --><!-- HN:49124367:start -->
* [49124367](https://news.social-protocols.org/stats?id=49124367) #8 8 points 1 comments -> [Puberty blockers trial can start recruiting children](https://www.bbc.com/news/articles/c0jl4np49w1o)<!-- HN:49124367:end --><!-- HN:49124825:start -->
* [49124825](https://news.social-protocols.org/stats?id=49124825) #14 47 points 21 comments -> [US Government lists fictional nation Wakanda as trade partner](https://www.bbc.com/news/world-us-canada-50849559)<!-- HN:49124825:end --><!-- HN:49124733:start -->
* [49124733](https://news.social-protocols.org/stats?id=49124733) #30 16 points 12 comments -> [Show HN: Shared memory graph for Claude and ChatGPT, over MCP](https://uml.gpmai.workers.dev)<!-- HN:49124733:end --><!-- HN:49124214:start -->
* [49124214](https://news.social-protocols.org/stats?id=49124214) #23 23 points 13 comments -> [I built a f.lux alternative because the M5 Max firmware broke existing solutions](https://driftformac.app/)<!-- HN:49124214:end --><!-- HN:49127284:start -->
* [49127284](https://news.social-protocols.org/stats?id=49127284) #27 37 points 35 comments -> [AI companies destroy rare and non recoverable physical books](https://www.heraldscotland.com/opinion/26422014.library-alexandria-burns-ai-companies-destroying-books-bulk/)<!-- HN:49127284:end --><!-- HN:49126201:start -->
* [49126201](https://news.social-protocols.org/stats?id=49126201) #6 45 points 6 comments -> [AFC Stands in Solidarity with UEFA and Concacaf to Protect the FIFA World Cup](https://www.the-afc.com/en/more/afc_news.html/news/afc-stands-in-solidarity-with-uefa-and-concacaf-to-protect-the-fifa-world-cup)<!-- HN:49126201:end --><!-- HN:49128751:start -->
* [49128751](https://news.social-protocols.org/stats?id=49128751) #29 9 points 1 comments -> [Thomson Reuters built its own AI model that now ranks among the best](https://www.thomsonreuters.com/en-us/posts/innovation/thomson-reuters-built-its-own-ai-model-that-now-ranks-among-the-worlds-best/)<!-- HN:49128751:end --><!-- HN:49129699:start -->
* [49129699](https://news.social-protocols.org/stats?id=49129699) #6 10 points 2 comments -> [That Viral Photo of San Francisco NIMBYs Shows Why Housing Is Winning](https://inpractice.yimbyaction.org/p/that-viral-photo-of-san-francisco)<!-- HN:49129699:end -->
#### **Saturday, August 1, 2026**
<!-- HN:49070810:start -->
* [49070810](https://news.social-protocols.org/stats?id=49070810) #18 122 points 13 comments -> [How JPEG works: Interactively explore JPEG's lossy compression methods](https://cgjennings.ca/articles/jpeg-compression/)<!-- HN:49070810:end --><!-- HN:49130723:start -->
* [49130723](https://news.social-protocols.org/stats?id=49130723) #11 3 points 0 comments -> [What Is MiniMax H3? Everything You Need to Know About the Hailuo 3.0 Video Model](https://minimaxh3.art/blog/what-is-minimax-h3)<!-- HN:49130723:end --><!-- HN:49095744:start -->
* [49095744](https://news.social-protocols.org/stats?id=49095744) #7 7 points 0 comments -> [History remembers two Robert McNamaras](https://indevelopmentmag.com/numbers-man/)<!-- HN:49095744:end --><!-- HN:49131860:start -->
* [49131860](https://news.social-protocols.org/stats?id=49131860) #1 20 points 10 comments -> [A migrant surge tests Spain's open policies](https://economist.com/europe/2026/07/31/a-migrant-surge-tests-spains-open-policies)<!-- HN:49131860:end --><!-- HN:49131034:start -->
* [49131034](https://news.social-protocols.org/stats?id=49131034) #20 40 points 40 comments -> [What Liberal Arts Education Is for (2024)](https://innig.net/teaching/liberal-arts-manifesto)<!-- HN:49131034:end --><!-- HN:49131737:start -->
* [49131737](https://news.social-protocols.org/stats?id=49131737) #15 9 points 1 comments -> [OpenAI's work on Git for large repositories](https://openai-git-upstream.openai.chatgpt.site/)<!-- HN:49131737:end --><!-- HN:49132468:start -->
* [49132468](https://news.social-protocols.org/stats?id=49132468) #27 11 points 4 comments -> [Simon Willison on DeepSeek-V4-Flash-0731](https://simonwillison.net/2026/Jul/31/deepseek-v4-flash-0731/)<!-- HN:49132468:end --><!-- HN:49133672:start -->
* [49133672](https://news.social-protocols.org/stats?id=49133672) #2 10 points 2 comments -> [Show HN: Free AI Prompt Gen – A local-first, open-source prompt engineering tool](https://freeaipromptgen.com/)<!-- HN:49133672:end --><!-- HN:49133617:start -->
* [49133617](https://news.social-protocols.org/stats?id=49133617) #7 5 points 4 comments -> [$0.09 and $290.12 are both the price of 1M output tokens](https://runinfra.ai/news/inference-cost-truth)<!-- HN:49133617:end --><!-- HN:49134310:start -->
* [49134310](https://news.social-protocols.org/stats?id=49134310) #4 23 points 41 comments -> [How to Spot AI Writing](https://www.economist.com/culture/2026/07/30/how-to-spot-ai-writing)<!-- HN:49134310:end --><!-- HN:49135401:start -->
* [49135401](https://news.social-protocols.org/stats?id=49135401) #9 4 points 1 comments -> [Crystal Wars – turn-based strategy on a fresh Voronoi map every match](https://play.crystalwars.io)<!-- HN:49135401:end --><!-- HN:49135383:start -->
* [49135383](https://news.social-protocols.org/stats?id=49135383) #11 13 points 0 comments -> [Indexing the Data Lake for Online Point Queries](https://engineering.atspotify.com/2026/7/indexing-the-data-lake-for-online-point-queries)<!-- HN:49135383:end --><!-- HN:49136065:start -->
* [49136065](https://news.social-protocols.org/stats?id=49136065) #10 3 points 3 comments -> [DNS propagation checker that shows the results as a box of 24 donuts](https://donutdns.com)<!-- HN:49136065:end --><!-- HN:49135914:start -->
* [49135914](https://news.social-protocols.org/stats?id=49135914) #14 19 points 32 comments -> [I Fired My AI Assitant](https://chreke.com/posts/i-fired-my-ai-assistant)<!-- HN:49135914:end --><!-- HN:49136061:start -->
* [49136061](https://news.social-protocols.org/stats?id=49136061) #11 7 points 2 comments -> [Twelve Years Without a VPN](https://khessin.de/twelve-years-without-a-vpn/)<!-- HN:49136061:end --><!-- HN:49136134:start -->
* [49136134](https://news.social-protocols.org/stats?id=49136134) #16 16 points 1 comments -> [Tesla Spyware](https://ma.tt/2026/07/tesla-spyware/)<!-- HN:49136134:end --><!-- HN:49135184:start -->
* [49135184](https://news.social-protocols.org/stats?id=49135184) #24 8 points 6 comments -> [Toast IDE Gets Markdown Spell Checking](https://github.com/paradise-runner/toast)<!-- HN:49135184:end --><!-- HN:49137303:start -->
* [49137303](https://news.social-protocols.org/stats?id=49137303) #16 9 points 0 comments -> [Chess Engine Dev Community Openly Hostile to AI Assisted Development](https://github.com/adamtwiss/coda/issues/15)<!-- HN:49137303:end --><!-- HN:49135975:start -->
* [49135975](https://news.social-protocols.org/stats?id=49135975) #12 28 points 41 comments -> [Franken.domains: Stitched-Together Domains, Because Every .com Is Taken](https://franken.domains/)<!-- HN:49135975:end --><!-- HN:49137808:start -->
* [49137808](https://news.social-protocols.org/stats?id=49137808) #28 37 points 19 comments -> [Top amputation surgeon had own legs removed due to fetish. Were patients safe?](https://www.theguardian.com/uk-news/2026/aug/01/neil-hopper-surgeon-amputated-legs-fetish-extreme-mutilation-patients-questions)<!-- HN:49137808:end --><!-- HN:49137413:start -->
* [49137413](https://news.social-protocols.org/stats?id=49137413) #24 3 points 0 comments -> [I made Squirrel game with Flutter and Flame](https://danvilela.com/squirrel-up)<!-- HN:49137413:end --><!-- HN:49137410:start -->
* [49137410](https://news.social-protocols.org/stats?id=49137410) #29 8 points 1 comments -> [Show HN: Cockpit for you Claude Code agents in Rust](https://episko.dev/)<!-- HN:49137410:end --><!-- HN:49138731:start -->
* [49138731](https://news.social-protocols.org/stats?id=49138731) #5 11 points 4 comments -> [The 14 Steps it takes to open my office door with a new phone](https://shub.club/writings/2026/august/14-steps-to-open-a-door/)<!-- HN:49138731:end -->
#### **Sunday, August 2, 2026**
<!-- HN:49120000:start -->
* [49120000](https://news.social-protocols.org/stats?id=49120000) #18 9 points 3 comments -> [Beltrunner: Game Design Postmortem](https://blog.gingerbeardman.com/2026/07/30/beltrunner-game-design-postmortem/)<!-- HN:49120000:end --><!-- HN:49139562:start -->
* [49139562](https://news.social-protocols.org/stats?id=49139562) #23 31 points 23 comments -> [Stop fucking around with database commits and transactions](https://www.droppedasbaby.com/posts/db-commits/)<!-- HN:49139562:end --><!-- HN:49139865:start -->
* [49139865](https://news.social-protocols.org/stats?id=49139865) #21 4 points 0 comments -> [Walsh: Multi-agent research pipeline with risk manager that can veto trades](https://github.com/ats4321/walsh)<!-- HN:49139865:end --><!-- HN:49140080:start -->
* [49140080](https://news.social-protocols.org/stats?id=49140080) #11 8 points 2 comments -> [Persistent State Machines: LLM Attention with INT4 In-Memory Cells](https://zenodo.org/records/21753002)<!-- HN:49140080:end --><!-- HN:49140713:start -->
* [49140713](https://news.social-protocols.org/stats?id=49140713) #6 7 points 5 comments -> [Futurism says Meta has "almost nothing" to show for AI. The numbers say](https://runtimewire.com/article/futurism-says-meta-has-almost-nothing-to-show-for-ai-the-numbers-say-otherwise)<!-- HN:49140713:end --><!-- HN:49140737:start -->
* [49140737](https://news.social-protocols.org/stats?id=49140737) #7 35 points 11 comments -> [The teenage hitmen recruited to kill across Europe](https://www.bbc.com/news/articles/czrjyevmv61o)<!-- HN:49140737:end --><!-- HN:49140869:start -->
* [49140869](https://news.social-protocols.org/stats?id=49140869) #5 -> [OpenAI's claimed disproof of Connes' Rigidity Conjecture is invalid [pdf]](https://philarchive.org/archive/NIEWTCv17)<!-- HN:49140869:end --><!-- HN:49141008:start -->
* [49141008](https://news.social-protocols.org/stats?id=49141008) #18 25 points 28 comments -> [Don't credit the LLM](https://isaacsu.com/2026/08/dont-credit-the-llm/)<!-- HN:49141008:end --><!-- HN:49140996:start -->
* [49140996](https://news.social-protocols.org/stats?id=49140996) #13 14 points 13 comments -> [Canadians are leaving the country at record levels. Can anyone solve this?](https://thehub.ca/2026/04/03/can-anyone-solve-canadas-brain-drain-problem/)<!-- HN:49140996:end --><!-- HN:49141877:start -->
* [49141877](https://news.social-protocols.org/stats?id=49141877) #10 25 points 40 comments -> [Australia's social media ban has failed](https://www.reuters.com/legal/litigation/australia-defends-teen-social-media-ban-after-study-shows-most-still-online-2026-08-01/)<!-- HN:49141877:end --><!-- HN:49141847:start -->
* [49141847](https://news.social-protocols.org/stats?id=49141847) #9 10 points 5 comments -> [CRM: An open-source, agentic-first CRM](https://github.com/trycompai/crm)<!-- HN:49141847:end --><!-- HN:49142002:start -->
* [49142002](https://news.social-protocols.org/stats?id=49142002) #7 7 points 5 comments -> [Show HN: Tone Generator](https://soundtonegenerator.com/)<!-- HN:49142002:end --><!-- HN:49141967:start -->
* [49141967](https://news.social-protocols.org/stats?id=49141967) #23 15 points 11 comments -> [Police in the US are making their own true crime podcasts](https://www.bbc.com/news/articles/cpw9q0ekd9eo)<!-- HN:49141967:end --><!-- HN:49142083:start -->
* [49142083](https://news.social-protocols.org/stats?id=49142083) #21 34 points 40 comments -> [Mathematics Without Mathematicians](https://borretti.me/article/mathematics-without-mathematicians)<!-- HN:49142083:end --><!-- HN:49143630:start -->
* [49143630](https://news.social-protocols.org/stats?id=49143630) #14 38 points 50 comments -> [Only 8.9% of sites block AI crawlers, but 94.8% are never cited in AI answers](https://website-auditor.io/ai-visibility-index)<!-- HN:49143630:end --><!-- HN:49143688:start -->
* [49143688](https://news.social-protocols.org/stats?id=49143688) #16 38 points 26 comments -> [An internal OpenAI Astra model solved 10 major open math and CS problems](https://twitter.com/polynoamial/status/2083467194663571701)<!-- HN:49143688:end --><!-- HN:49143315:start -->
* [49143315](https://news.social-protocols.org/stats?id=49143315) #19 -> [LLMs Discover P=NP (Comic)](https://chatgpt.com/s/m_6a6f252612a08191b4081f60a92bceba)<!-- HN:49143315:end --><!-- HN:49144946:start -->
* [49144946](https://news.social-protocols.org/stats?id=49144946) #5 25 points 3 comments -> [The Seinfeld Chronicles: Digital Edition](https://seinfeld.visualisingdata.com/)<!-- HN:49144946:end --><!-- HN:49143304:start -->
* [49143304](https://news.social-protocols.org/stats?id=49143304) #22 13 points 7 comments -> [I made a Promise-aware debounce and throttle library for TypeScript](https://github.com/nyvexis1/temporize)<!-- HN:49143304:end --><!-- HN:49146051:start -->
* [49146051](https://news.social-protocols.org/stats?id=49146051) #10 13 points 4 comments -> [GE-97 Terminal: The Old Internet](https://ge97.com/)<!-- HN:49146051:end --><!-- HN:49146372:start -->
* [49146372](https://news.social-protocols.org/stats?id=49146372) #14 26 points 15 comments -> [The Coldcard Disaster Gets Worse: The Hack May Have Reached $88.6M](https://medium.com/mountain-movers/the-coldcard-disaster-gets-worse-the-hack-may-have-reached-88-6-af507b028594)<!-- HN:49146372:end --><!-- HN:49146982:start -->
* [49146982](https://news.social-protocols.org/stats?id=49146982) #7 6 points 2 comments -> [Welcome to Agents Week](https://blog.cloudflare.com/agents-week-welcome/)<!-- HN:49146982:end --><!-- HN:49148070:start -->
* [49148070](https://news.social-protocols.org/stats?id=49148070) #7 10 points 0 comments -> [Anthropic's Fever Dream: Claude's package that stole real keys](https://www.aikido.dev/blog/anthropic-rogue-agents-package-stole-keys)<!-- HN:49148070:end --><!-- HN:49147222:start -->
* [49147222](https://news.social-protocols.org/stats?id=49147222) #30 5 points 3 comments -> [Effective HTML](https://www.effectivehtml.com/)<!-- HN:49147222:end --><!-- HN:49148335:start -->
* [49148335](https://news.social-protocols.org/stats?id=49148335) #6 8 points 1 comments -> [WireguardTCP: WireGuard over TCP](https://wireguardtcp.net/)<!-- HN:49148335:end --><!-- HN:49148163:start -->
* [49148163](https://news.social-protocols.org/stats?id=49148163) #11 8 points 1 comments -> [Show HN: Draco – A single-binary, self-hostable Firecrawl alternative in Rust](https://github.com/0xchasercat/draco/)<!-- HN:49148163:end -->
#### **Monday, August 3, 2026**<!-- HN:49150490:start -->
* [49150490](https://news.social-protocols.org/stats?id=49150490) #21 18 points 1 comments -> [Qwen 3.8 Max Live Now](https://www.qwencloud.com/models/qwen3.8-max)<!-- HN:49150490:end --><!-- HN:49150561:start -->
* [49150561](https://news.social-protocols.org/stats?id=49150561) #2 161 points 64 comments -> [OpenAI's super PAC is funding AI-generated news site attacking industry critics](https://www.modelrepublic.org/articles/the-reporters-at-this-news-site-are-ai-bots.-openai%E2%80%99s-super-pac-appears-to-be-using-it-to-advance-its-political-agenda)<!-- HN:49150561:end --><!-- HN:49118542:start -->
* [49118542](https://news.social-protocols.org/stats?id=49118542) #14 4 points 0 comments -> [Emulating ALiBi with Rope](https://alexlitzenberger.com/blog/emulating_alibi_with_rope)<!-- HN:49118542:end --><!-- HN:49154685:start -->
* [49154685](https://news.social-protocols.org/stats?id=49154685) #16 8 points 3 comments -> [GLM-5.3 Soon](https://github.com/zai-org/z-ai-sdk-java/commits/glm-5.3)<!-- HN:49154685:end --><!-- HN:49154237:start -->
* [49154237](https://news.social-protocols.org/stats?id=49154237) #13 191 points 76 comments -> [ICE Collected Nearly 1M People's DNA Last Year–Including Young Children](https://www.wired.com/story/ice-dna-collection-fbi-codis/)<!-- HN:49154237:end --><!-- HN:49156559:start -->
* [49156559](https://news.social-protocols.org/stats?id=49156559) #22 -> [TSA Privatization Returns Airport Security to a Dangerous Past](https://prospect.org/2026/08/03/tsa-privatization-airport-security-911-trump-bush/)<!-- HN:49156559:end --><!-- HN:49158837:start -->
* [49158837](https://news.social-protocols.org/stats?id=49158837) #19 28 points 4 comments -> [Leaked Flock Guide Shows How It Teaches Cops to Promote Its Tech](https://www.404media.co/own-the-narrative-leaked-flock-guide-shows-how-it-teaches-cops-to-promote-its-tech/)<!-- HN:49158837:end -->
#### **Tuesday, August 4, 2026**
<!-- HN:49163158:start -->
* [49163158](https://news.social-protocols.org/stats?id=49163158) #3 10 points 0 comments -> [Native Apps Should Be Avoided Whenever Possible](https://nooneshappy.com/article/native-apps-should-be-avoided-whenever-possible/)<!-- HN:49163158:end --><!-- HN:49097083:start -->
* [49097083](https://news.social-protocols.org/stats?id=49097083) #13 8 points 3 comments -> [Nobody checked which state IBM's flagship quantum chemistry results compute](https://zenodo.org/records/21359923)<!-- HN:49097083:end -->