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

#### **Saturday, November 14, 2026**
<!-- HN:50491753:start -->
* [50491753](https://news.social-protocols.org/stats?id=50491753) #18 7 points 0 comments -> [Doc-foundry – AI writes Security detection rules, then proves they work](https://github.com/mjha-arya/DOC-foundry)<!-- HN:50491753:end --><!-- HN:50492450:start -->
* [50492450](https://news.social-protocols.org/stats?id=50492450) #14 -> [Hawaii DOT: All West Coast flights halted by SpaceX debris after FAA ground stop](https://www.hawaiinewsnow.com/2026/11/14/dot-all-west-coast-flights-halted-by-spacex-debris-after-faa-ground-stop/)<!-- HN:50492450:end --><!-- HN:50492945:start -->
* [50492945](https://news.social-protocols.org/stats?id=50492945) #9 7 points 1 comments -> [Hawaii flights halted due to debris from SpaceX launch amidst FAA's ground stop](https://www.kitv.com/news/hawaii-flights-to-west-coast-halted-due-to-debris-from-spacex-launch-amidst-faas-nationwide/article_9b8dfe4d-8e80-4949-96a2-39c4eddc870f.html)<!-- HN:50492945:end --><!-- HN:50492456:start -->
* [50492456](https://news.social-protocols.org/stats?id=50492456) #8 213 points 101 comments -> [Ukraine knocks out 36% of Russia's oil refining capacity in under two weeks](https://english.nv.ua/nation/thirteen-day-drone-blitz-paralyzes-36-of-moscow-s-oil-50658616.html)<!-- HN:50492456:end --><!-- HN:50492601:start -->
* [50492601](https://news.social-protocols.org/stats?id=50492601) #2 205 points 1 comments -> [FAA lifted National Ground Stop at 0119Z](https://www.fly.faa.gov/adv/adv_otherdis?adv_date=11142026&advn=5)<!-- HN:50492601:end --><!-- HN:50493731:start -->
* [50493731](https://news.social-protocols.org/stats?id=50493731) #15 12 points 1 comments -> [Run Cloudflare Workers Anywhere](https://openorange.dev/)<!-- HN:50493731:end --><!-- HN:50494303:start -->
* [50494303](https://news.social-protocols.org/stats?id=50494303) #30 -> [Israeli airstrike on Nasser hospital in Gaza killed surgeon and others](https://www.theguardian.com/world/2026/nov/12/israeli-airstrike-nasser-hospital-gaza-kills-surgeon)<!-- HN:50494303:end --><!-- HN:50494914:start -->
* [50494914](https://news.social-protocols.org/stats?id=50494914) #3 11 points 0 comments -> [The Invention of Islamic Invention](https://www.cremieux.xyz/p/the-invention-of-islamic-invention)<!-- HN:50494914:end --><!-- HN:50467010:start -->
* [50467010](https://news.social-protocols.org/stats?id=50467010) #26 6 points 1 comments -> [Cabo Pulmo, John Steinbeck, and the village that wouldn't give up](https://blue-continuum.com/the-village-that-gave-back-its-sea)<!-- HN:50467010:end --><!-- HN:50494711:start -->
* [50494711](https://news.social-protocols.org/stats?id=50494711) #13 9 points 5 comments -> [Why a NAT VPS can cost $1: the economics of an IPv4 address](https://natbox.io/blog/why-a-nat-vps-can-cost-1-dollar)<!-- HN:50494711:end --><!-- HN:50497141:start -->
* [50497141](https://news.social-protocols.org/stats?id=50497141) #10 8 points 1 comments -> [Show HN: Lampka – a Windows PDF reader whose dark mode keeps figures in colour](https://lampka.app/)<!-- HN:50497141:end --><!-- HN:50496938:start -->
* [50496938](https://news.social-protocols.org/stats?id=50496938) #13 4 points 0 comments -> [Does the Crichton Estate Have a Case?](https://yapern.com/blog/does-the-crichton-estate-have-a-case/)<!-- HN:50496938:end --><!-- HN:50498151:start -->
* [50498151](https://news.social-protocols.org/stats?id=50498151) #10 21 points 12 comments -> [The Cloud Is Just Someone Else's Computer – They Let It Burn](https://soargram.io/content/369523282)<!-- HN:50498151:end --><!-- HN:50498437:start -->
* [50498437](https://news.social-protocols.org/stats?id=50498437) #29 5 points 4 comments -> [A short history of the honey trap](https://engelsbergideas.com/notebook/a-short-history-of-the-honey-trap/)<!-- HN:50498437:end --><!-- HN:50499188:start -->
* [50499188](https://news.social-protocols.org/stats?id=50499188) #15 14 points 8 comments -> [The VHDL standard's float package gets sqrt(2) wrong](https://github.com/lmtlssss/speedrunpapi/tree/main/hardware/audit/ieee-float-pkg)<!-- HN:50499188:end --><!-- HN:50499712:start -->
* [50499712](https://news.social-protocols.org/stats?id=50499712) #14 7 points 5 comments -> [A reimagined OS with no folders and no apps](https://www.mercuryos.com/)<!-- HN:50499712:end --><!-- HN:50500792:start -->
* [50500792](https://news.social-protocols.org/stats?id=50500792) #11 5 points 1 comments -> [Yeah, LLM's haven't solved much of anything else, but hey, here you go](https://apps.apple.com/us/app/intellikey/id1667188645)<!-- HN:50500792:end --><!-- HN:50501515:start -->
* [50501515](https://news.social-protocols.org/stats?id=50501515) #8 18 points 3 comments -> [Mullvad VPN – Privacy is for the people](https://mullvad.net/en)<!-- HN:50501515:end -->
#### **Sunday, November 15, 2026**
<!-- HN:50503034:start -->
* [50503034](https://news.social-protocols.org/stats?id=50503034) #4 7 points 4 comments -> [Can the AI boom make enough money to sustain itself?](https://www.economist.com/briefing/2026/11/12/can-the-ai-boom-make-enough-money-to-sustain-itself)<!-- HN:50503034:end --><!-- HN:50502768:start -->
* [50502768](https://news.social-protocols.org/stats?id=50502768) #17 60 points 1 comments -> [US loses measles-free status: Pan American Health Organization](https://www.paho.org/en/news/10-11-2025-paho-calls-regional-action-americas-lose-measles-elimination-status)<!-- HN:50502768:end --><!-- HN:50503731:start -->
* [50503731](https://news.social-protocols.org/stats?id=50503731) #20 15 points 6 comments -> [Osint Case Studies](https://osintsearch.org/blog/osint-case-studies)<!-- HN:50503731:end --><!-- HN:50501631:start -->
* [50501631](https://news.social-protocols.org/stats?id=50501631) #14 413 points 205 comments -> [Nvidia deliberately kept GPU prices high through circular financing deals](https://www.techspot.com/news/114558-nvidia-deliberately-kept-gpu-prices-high-through-circular.html)<!-- HN:50501631:end --><!-- HN:50507231:start -->
* [50507231](https://news.social-protocols.org/stats?id=50507231) #13 5 points 0 comments -> [GPU says 35% busy. Busy doing what?](https://tensward.com/blog/gpu-busy-doing-what)<!-- HN:50507231:end --><!-- HN:50507722:start -->
* [50507722](https://news.social-protocols.org/stats?id=50507722) #16 5 points 10 comments -> [Show HN: A tiny macOS app that turns off the MacBook display [free license]](https://blackoutapp.io/)<!-- HN:50507722:end --><!-- HN:50508076:start -->
* [50508076](https://news.social-protocols.org/stats?id=50508076) #9 8 points 5 comments -> [What Picasso taught me about building AI Agents](https://claramap.com/blog/what-picasso-taught-me-about-building-ai-agents/)<!-- HN:50508076:end --><!-- HN:50507989:start -->
* [50507989](https://news.social-protocols.org/stats?id=50507989) #23 19 points 20 comments -> [The Atheist Bible](https://suchanek.name/texts/atheism/)<!-- HN:50507989:end -->
#### **Monday, November 16, 2026**
<!-- HN:50511505:start -->
* [50511505](https://news.social-protocols.org/stats?id=50511505) #16 11 points 2 comments -> [The Hofmann Wobble: Wikipedia and the problem of historical memory](https://harpers.org/archive/2023/12/the-hofmann-wobble-wikipedia-and-the-problem-of-historical-memory/)<!-- HN:50511505:end --><!-- HN:50513077:start -->
* [50513077](https://news.social-protocols.org/stats?id=50513077) #7 8 points 1 comments -> [Dffy: A fast terminal-native Git diff viewer, written in Rust](https://github.com/amalucelli/dffy)<!-- HN:50513077:end --><!-- HN:50511362:start -->
* [50511362](https://news.social-protocols.org/stats?id=50511362) #16 9 points 2 comments -> [DefCon: Breaking into Amazon Lockers by Any Means Necessary](https://www.youtube.com/watch?v=ZVmRe8OVZtE)<!-- HN:50511362:end --><!-- HN:50516301:start -->
* [50516301](https://news.social-protocols.org/stats?id=50516301) #6 26 points 10 comments -> [I posted in "Who wants to be hired?" and a recruiter sent me a RAT and a stealer](https://getjump.me/posts/03-huntrole-fake-take-home/)<!-- HN:50516301:end --><!-- HN:50515169:start -->
* [50515169](https://news.social-protocols.org/stats?id=50515169) #21 31 points 40 comments -> [How Should Armies Fight?](https://worksinprogress.co/issue/the-future-of-war/)<!-- HN:50515169:end --><!-- HN:50518572:start -->
* [50518572](https://news.social-protocols.org/stats?id=50518572) #29 6 points 0 comments -> [Mayor Zohran Kwame Mamdani: We Are Disbanding the SRG](https://twitter.com/NYCMayor/status/2122298477816504328)<!-- HN:50518572:end --><!-- HN:50518615:start -->
* [50518615](https://news.social-protocols.org/stats?id=50518615) #25 23 points 11 comments -> [Robert Pattinson Is Officially James Bond](https://variety.com/2026/film/global/robert-pattinson-new-james-bond-007-1236946655/)<!-- HN:50518615:end --><!-- HN:50517630:start -->
* [50517630](https://news.social-protocols.org/stats?id=50517630) #22 4 points 0 comments -> [Show HN: CheeseDB – agent memory where deleting a source deletes what it taught](https://github.com/govinargo-labs/cheesedb)<!-- HN:50517630:end --><!-- HN:50517352:start -->
* [50517352](https://news.social-protocols.org/stats?id=50517352) #25 17 points 14 comments -> [Show HN: OpenTodo – a self-hosted, local-first task manager in one Go binary](https://github.com/OpenTodoApp/OpenTodo)<!-- HN:50517352:end --><!-- HN:50520506:start -->
* [50520506](https://news.social-protocols.org/stats?id=50520506) #8 5 points 0 comments -> [Show HN: Claimseed, synthetic Medicare docs with planted errors and answer keys](https://github.com/claimseed/claimseed)<!-- HN:50520506:end --><!-- HN:50520825:start -->
* [50520825](https://news.social-protocols.org/stats?id=50520825) #5 37 points 13 comments -> [Duolingo uses screen time permission to block uninstall](https://blog.rhett.info/duolingo-screen-time-uninstall/)<!-- HN:50520825:end --><!-- HN:50521357:start -->
* [50521357](https://news.social-protocols.org/stats?id=50521357) #17 20 points 1 comments -> [US Banks report outages in latest tech hiccup](https://nypost.com/2026/11/16/business/outages-hit-chase-bank-of-america-and-wells-fargo-customers/)<!-- HN:50521357:end --><!-- HN:50466300:start -->
* [50466300](https://news.social-protocols.org/stats?id=50466300) #21 13 points 5 comments -> [Quxnet Is a Breath of Fresh Air](https://moddedbear.com/quxnet-is-a-breath-of-fresh-air/)<!-- HN:50466300:end --><!-- HN:50521644:start -->
* [50521644](https://news.social-protocols.org/stats?id=50521644) #15 3 points 2 comments -> [Adobe flash editor libre alternative](https://www.q0id.com/downloads)<!-- HN:50521644:end --><!-- HN:50522920:start -->
* [50522920](https://news.social-protocols.org/stats?id=50522920) #7 8 points 2 comments -> [Nations Must Die](https://marvindanig.com/blog/nations-must-die/)<!-- HN:50522920:end --><!-- HN:50523147:start -->
* [50523147](https://news.social-protocols.org/stats?id=50523147) #13 7 points 2 comments -> [Amtrak service stopped around Washington, D.C](https://www.fox5dc.com/news/amtrak-service-stopped-washington-dc-track-hold)<!-- HN:50523147:end --><!-- HN:50524260:start -->
* [50524260](https://news.social-protocols.org/stats?id=50524260) #15 43 points 9 comments -> [United Airlines has a widespread system outage](https://apnews.com/article/united-airlines-outage-5a5e5f75bb07f11ffb8750901f0076ff)<!-- HN:50524260:end -->
#### **Tuesday, November 17, 2026**
<!-- HN:50523300:start -->
* [50523300](https://news.social-protocols.org/stats?id=50523300) #4 184 points 2 comments -> [Optimizely Compromised](https://amirulcyber.com/2026/11/16/optimjack-optimizely-skimmer/)<!-- HN:50523300:end --><!-- HN:50525646:start -->
* [50525646](https://news.social-protocols.org/stats?id=50525646) #21 8 points 0 comments -> [Doom on the Nikon Z 6II camera](https://arnebaeyens.com/blog/2026/doom-on-nikon-z6ii/)<!-- HN:50525646:end --><!-- HN:50526380:start -->
* [50526380](https://news.social-protocols.org/stats?id=50526380) #9 8 points 1 comments -> [Show HN: Win98 PE Interpreter in WebAssembly – StarCraft and Diablo on Phones](https://wine-assembly.berrry.app/)<!-- HN:50526380:end --><!-- HN:50526527:start -->
* [50526527](https://news.social-protocols.org/stats?id=50526527) #30 12 points 5 comments -> [Show HN: A free interactive course on AI agent governance](https://studio.sinapsdata.com.br)<!-- HN:50526527:end --><!-- HN:50527311:start -->
* [50527311](https://news.social-protocols.org/stats?id=50527311) #24 11 points 5 comments -> [Unkernel: Linux kernel in WASM](https://unkernel.dev)<!-- HN:50527311:end --><!-- HN:50506648:start -->
* [50506648](https://news.social-protocols.org/stats?id=50506648) #9 6 points 2 comments -> [The Token Supercycle](https://solana.com/news/the-token-supercycle-oped)<!-- HN:50506648:end --><!-- HN:50528364:start -->
* [50528364](https://news.social-protocols.org/stats?id=50528364) #11 7 points 0 comments -> [40-domain study: 80% of Shopify stores expose /API/ucp/MCP, 0% /agents.md](https://verisource.dev/benchmarks/ai-search-readiness-2026)<!-- HN:50528364:end --><!-- HN:50530450:start -->
* [50530450](https://news.social-protocols.org/stats?id=50530450) #14 120 points 55 comments -> [Regulatory Capture by Anthropic Through METR](https://nitter.cf/kevinnbass/status/2099621874279817638)<!-- HN:50530450:end --><!-- HN:50532822:start -->
* [50532822](https://news.social-protocols.org/stats?id=50532822) #8 8 points 3 comments -> [GPT-6.2 Astra](https://openai.com/index/introducing-gpt-6-2-astra/)<!-- HN:50532822:end --><!-- HN:50532315:start -->
* [50532315](https://news.social-protocols.org/stats?id=50532315) #7 93 points 44 comments -> [Pentagon fails 9th financial audit in a row](https://thehill.com/policy/defense/6224597-pentagon-fails-ninth-audit/)<!-- HN:50532315:end --><!-- HN:50534664:start -->
* [50534664](https://news.social-protocols.org/stats?id=50534664) #8 70 points 11 comments -> [Optimizely hack infected CNN, Fox News, BBC, Salesforce sites with malware](https://www.bleepingcomputer.com/news/security/optimizely-supply-chain-attack-delivers-malware-to-cnn-fox-news-bbc-salesforce-sites/)<!-- HN:50534664:end --><!-- HN:50537470:start -->
* [50537470](https://news.social-protocols.org/stats?id=50537470) #18 19 points 1 comments -> [Israel Is Attacking Wikipedia](https://techforpalestine.org/wikipedia-report-2026)<!-- HN:50537470:end --><!-- HN:50533089:start -->
* [50533089](https://news.social-protocols.org/stats?id=50533089) #19 328 points 4 comments -> [NSA Internal Network Down](https://www.reuters.com/technology/highly-classified-us-national-security-communications-network-is-down-cnn-2026-11-17/)<!-- HN:50533089:end --><!-- HN:50538026:start -->
* [50538026](https://news.social-protocols.org/stats?id=50538026) #11 10 points 2 comments -> [CVE-2026-114938 – Java4Shell](https://www.cve.org/CVERecord?id=CVE-2026-114938)<!-- HN:50538026:end -->
#### **Wednesday, November 18, 2026**
<!-- HN:50541542:start -->
* [50541542](https://news.social-protocols.org/stats?id=50541542) #17 9 points 1 comments -> [Engineering Vitals in the Age of AI](https://octopus.com/blog/engineering-vitals-in-the-age-of-ai)<!-- HN:50541542:end --><!-- HN:50497903:start -->
* [50497903](https://news.social-protocols.org/stats?id=50497903) #27 10 points 3 comments -> [Adopting Python 3.15's lazy imports: a 4× faster CLI, and where they didn't help](https://namegarage.com/blog/python-3-15-lazy-imports)<!-- HN:50497903:end --><!-- HN:50542217:start -->
* [50542217](https://news.social-protocols.org/stats?id=50542217) #12 8 points 3 comments -> [I had AI read my field](https://science.caseyhandmer.com/physics/)<!-- HN:50542217:end --><!-- HN:50541550:start -->
* [50541550](https://news.social-protocols.org/stats?id=50541550) #26 35 points 40 comments -> [H-1B Executive Actions in 2026 [pdf]](https://www.everycrsreport.com/files/2026-10-14_IN12747_fcb1389788aa7b9102b795882af042e85d20532c.pdf)<!-- HN:50541550:end --><!-- HN:50543669:start -->
* [50543669](https://news.social-protocols.org/stats?id=50543669) #30 -> [DOJ letter shows UCLA medical school discriminates against Asians and Whites](https://www.justice.gov/crt/media/1439581/dl)<!-- HN:50543669:end --><!-- HN:50545118:start -->
* [50545118](https://news.social-protocols.org/stats?id=50545118) #7 -> [I had AI read my entire field, Theoretical Astrophysics](https://science.caseyhandmer.com/physics/)<!-- HN:50545118:end --><!-- HN:50545232:start -->
* [50545232](https://news.social-protocols.org/stats?id=50545232) #30 32 points 41 comments -> [GTA 6 Review: It Is a Masterpiece](https://www.bloomberg.com/news/features/2026-11-18/gta-6-review-rockstar-games-latest-is-a-masterpiece)<!-- HN:50545232:end --><!-- HN:50547331:start -->
* [50547331](https://news.social-protocols.org/stats?id=50547331) #25 5 points 0 comments -> [Show HN: Is Arabic One Language?](https://www.parallel-arabic.com/arabic-dialects)<!-- HN:50547331:end --><!-- HN:50548281:start -->
* [50548281](https://news.social-protocols.org/stats?id=50548281) #24 12 points 25 comments -> [Software Factory builds 30 complex open source libraries in a month](https://recursiveai.org/blog/what-my-software-factory-built/)<!-- HN:50548281:end --><!-- HN:50548828:start -->
* [50548828](https://news.social-protocols.org/stats?id=50548828) #16 28 points 3 comments -> [Stop Deploying to ECS Just to See If Your Code Works](https://metalbear.com/blog/stop-deploying-to-ecs/)<!-- HN:50548828:end --><!-- HN:50548485:start -->
* [50548485](https://news.social-protocols.org/stats?id=50548485) #21 107 points 52 comments -> ["Anthropic Is Not a Safe AI Company" – Coalition Challenges Anthropic Safety](https://www.businesswire.com/news/home/20261118974464/en/Anthropic-is-Not-a-Safe-AI-Company---Broad-Coalition-of-Scientists-Legal-Scholars-and-Tech-Leaders-Challenge-Anthropics-Safety-Branding-Ahead-of-IPO)<!-- HN:50548485:end --><!-- HN:50549711:start -->
* [50549711](https://news.social-protocols.org/stats?id=50549711) #22 4 points 1 comments -> [Who made the strawberry? 14 days of logs building a procedural fruit with agents](https://strawberry-methodology.pages.dev)<!-- HN:50549711:end --><!-- HN:50549677:start -->
* [50549677](https://news.social-protocols.org/stats?id=50549677) #21 19 points 19 comments -> [We asked AI the same 210 buying questions 2 days in a row,84% of answers changed](https://supercite.ai/blog/ai-answers-change-every-day)<!-- HN:50549677:end --><!-- HN:50549967:start -->
* [50549967](https://news.social-protocols.org/stats?id=50549967) #17 12 points 5 comments -> [Nvidia Hit with a Ransomware](https://www.ransomware.live/id/TlZJRElBQHRoZWdlbnRsZW1lbg)<!-- HN:50549967:end --><!-- HN:50547236:start -->
* [50547236](https://news.social-protocols.org/stats?id=50547236) #26 51 points 16 comments -> [Attackers Used Optimizely to A/B Test Malware on Top Websites](https://krebsonsecurity.com/2026/11/attackers-used-optimizely-to-a-b-test-malware-on-top-websites/)<!-- HN:50547236:end --><!-- HN:50547423:start -->
* [50547423](https://news.social-protocols.org/stats?id=50547423) #19 87 points 13 comments -> [NGINX2Root by Xint – From Nginx visitor to root of the server host](https://nginx2root.com/)<!-- HN:50547423:end -->
#### **Thursday, November 19, 2026**
<!-- HN:50553402:start -->
* [50553402](https://news.social-protocols.org/stats?id=50553402) #29 11 points 12 comments -> [Why educational system is broken](https://keycybermonk.com/edu)<!-- HN:50553402:end --><!-- HN:50553192:start -->
* [50553192](https://news.social-protocols.org/stats?id=50553192) #28 44 points 40 comments -> [GTA6-like as a 942Kb UEFI bootable image](https://github.com/eklavya-raj/gta6-uefi)<!-- HN:50553192:end --><!-- HN:50564004:start -->
* [50564004](https://news.social-protocols.org/stats?id=50564004) #10 12 points 5 comments -> [Chile: UFO Sightings by 18th Century Jesuits](https://inexplicata.blogspot.com/2026/08/chile-ufo-sightings-by-18th-century.html)<!-- HN:50564004:end --><!-- HN:50526244:start -->
* [50526244](https://news.social-protocols.org/stats?id=50526244) #29 -> [Show HN: 1.499x speedup and 28.5% dynamic energy drop on A40 via BF16 tiling](https://cwtractors.com)<!-- HN:50526244:end -->
#### **Friday, November 20, 2026**
<!-- HN:50568643:start -->
* [50568643](https://news.social-protocols.org/stats?id=50568643) #22 62 points 20 comments -> [Postgres 19 is out, and it's available on Neon and Databricks Lakebase](https://www.databricks.com/blog/postgresql-19-available-lakebase)<!-- HN:50568643:end --><!-- HN:50530426:start -->
* [50530426](https://news.social-protocols.org/stats?id=50530426) #21 4 points 1 comments -> [Making Art with QR Codes, and the Fine Line Between Inspiration and Idea Theft](https://www.gorillasun.de/blog/making-art-with-qr-codes-and-the-fine-line-between-inspiration-and-idea-theft/)<!-- HN:50530426:end --><!-- HN:50565788:start -->
* [50565788](https://news.social-protocols.org/stats?id=50565788) #25 3 points 1 comments -> [Tubemap Mark Two: A geographically-accurate diagram of the London Underground](https://www.marknoaddesign.co.uk/london-tube-map)<!-- HN:50565788:end --><!-- HN:50574772:start -->
* [50574772](https://news.social-protocols.org/stats?id=50574772) #9 23 points 15 comments -> [Llms.txt and MCP didn't move the needle](https://backpackforlaravel.com/articles/opinions/llms-txt-and-mcp-didn-t-move-the-needle-for-us-here-s-what-did)<!-- HN:50574772:end --><!-- HN:50520420:start -->
* [50520420](https://news.social-protocols.org/stats?id=50520420) #24 17 points 8 comments -> [Creativity in Negative Space](https://spf13.com/p/creativity-in-negative-space/)<!-- HN:50520420:end --><!-- HN:50578289:start -->
* [50578289](https://news.social-protocols.org/stats?id=50578289) #10 7 points 1 comments -> [Anthropic's Plunge Deepens AI Selloff](https://boamaehg.blogspot.com/2026/11/nasdaq-slides-as-anthropic-plunge-drags.html)<!-- HN:50578289:end --><!-- HN:50580176:start -->
* [50580176](https://news.social-protocols.org/stats?id=50580176) #10 7 points 3 comments -> [ChurchTerminal – Christian News Dashboard Inspired by Hacker News](https://churchterminal.com/)<!-- HN:50580176:end -->