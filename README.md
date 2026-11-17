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

#### **Wednesday, November 11, 2026**
<!-- HN:50427407:start -->
* [50427407](https://news.social-protocols.org/stats?id=50427407) #14 4 points 2 comments -> [Good Enough for a Tuesday Night](https://www.newyorker.com/culture/the-weekend-essay/good-enough-for-a-tuesday-night)<!-- HN:50427407:end --><!-- HN:50452074:start -->
* [50452074](https://news.social-protocols.org/stats?id=50452074) #7 36 points 31 comments -> [The Zig project is going nowhere](https://bytecode.news/posts/2026/10/the-zig-project-is-going-nowhere)<!-- HN:50452074:end --><!-- HN:50451985:start -->
* [50451985](https://news.social-protocols.org/stats?id=50451985) #9 36 points 41 comments -> [The Housing Market Is Nuts](https://nuts.logical.li/)<!-- HN:50451985:end --><!-- HN:50428860:start -->
* [50428860](https://news.social-protocols.org/stats?id=50428860) #25 6 points 0 comments -> [Beans at altitude: stovetop vs. pressure cooker](https://highaltitudelife.com/beans-at-altitude-stovetop-vs-pressure-cooker/)<!-- HN:50428860:end -->
#### **Thursday, November 12, 2026**
<!-- HN:50459776:start -->
* [50459776](https://news.social-protocols.org/stats?id=50459776) #11 221 points 187 comments -> [Nvidia prepares to fire CEO Jensen Huang, WSJ reports](https://twitter.com/watcherguru/status/2120645607866188008)<!-- HN:50459776:end --><!-- HN:50463813:start -->
* [50463813](https://news.social-protocols.org/stats?id=50463813) #12 13 points 3 comments -> [Europe has been living beyond its means. Now the bills are due](https://economist.com/europe/2026/11/10/europe-has-been-living-beyond-its-means-now-the-bills-are-due)<!-- HN:50463813:end --><!-- HN:50467139:start -->
* [50467139](https://news.social-protocols.org/stats?id=50467139) #8 162 points 87 comments -> [Nvidia CEO Jensen Huang resigns after reports of second affair deepened scandal](https://www.bbc.co.uk/news/live/c6zjry11v8w1t)<!-- HN:50467139:end --><!-- HN:50467132:start -->
* [50467132](https://news.social-protocols.org/stats?id=50467132) #3 364 points 197 comments -> [Jensen Huang resigns as Nvidia CEO immediately](https://www.reuters.com/live/nvidia-live-board-meets-fate-ceo-jensen-huang-after-affair-reports-2026-11-12/)<!-- HN:50467132:end --><!-- HN:50467191:start -->
* [50467191](https://news.social-protocols.org/stats?id=50467191) #17 70 points 18 comments -> [Nvidia CEO Jensen Huang resigns after reports of extramarital relationships](https://www.nbcnews.com/tech/tech-news/nvidia-ceo-jensen-huang-resigns-reports-extramarital-relationships-rcna608402)<!-- HN:50467191:end --><!-- HN:50469123:start -->
* [50469123](https://news.social-protocols.org/stats?id=50469123) #26 8 points 3 comments -> [Show HN: A self-hosted PHP platform combining CMS, e-commerce and more, built-in](https://getvale.org)<!-- HN:50469123:end --><!-- HN:50470975:start -->
* [50470975](https://news.social-protocols.org/stats?id=50470975) #23 17 points 8 comments -> [AI Models Know What Women, Peace and Security Is. They Just Don't Bring It Up](https://blog.cip.org/p/ai-models-know-what-women-peace-and)<!-- HN:50470975:end --><!-- HN:50471428:start -->
* [50471428](https://news.social-protocols.org/stats?id=50471428) #12 14 points 3 comments -> [Gemini 4 Hydrogen](https://deepmind.google/models/model-cards/gemini-4-hydrogen/)<!-- HN:50471428:end --><!-- HN:50471793:start -->
* [50471793](https://news.social-protocols.org/stats?id=50471793) #2 300 points 7 comments -> [Rust 1.100.0](https://github.com/rust-lang/rust/releases/tag/1.100.0)<!-- HN:50471793:end --><!-- HN:50473606:start -->
* [50473606](https://news.social-protocols.org/stats?id=50473606) #23 21 points 14 comments -> [Microsoft Status: "We are re-routing the protocols"](https://admin.cloud.microsoft/?#/servicehealth/:/alerts/MO1550821)<!-- HN:50473606:end -->
#### **Friday, November 13, 2026**
<!-- HN:50475735:start -->
* [50475735](https://news.social-protocols.org/stats?id=50475735) #2 76 points 44 comments -> [Why You Should Expect an AI Crash](https://www.economist.com/leaders/2026/11/12/why-you-should-expect-an-ai-crash)<!-- HN:50475735:end --><!-- HN:50475505:start -->
* [50475505](https://news.social-protocols.org/stats?id=50475505) #27 14 points 2 comments -> [Outlook Down, Microsoft Teams and Office may be impacted](https://status.cloud.microsoft/m365/referrer=serviceStatusRedirect)<!-- HN:50475505:end --><!-- HN:50477331:start -->
* [50477331](https://news.social-protocols.org/stats?id=50477331) #1 112 points 43 comments -> [Africa's solar revolution is vast and speedy](https://www.economist.com/middle-east-and-africa/2026/11/12/africas-solar-revolution-is-vast-and-speedy)<!-- HN:50477331:end --><!-- HN:50480194:start -->
* [50480194](https://news.social-protocols.org/stats?id=50480194) #3 9 points 1 comments -> [People Vote for Anti-Immigration Parties Because They Don't Like Immigration](https://www.popularbydesign.org/p/people-vote-for-anti-immigration)<!-- HN:50480194:end --><!-- HN:50481354:start -->
* [50481354](https://news.social-protocols.org/stats?id=50481354) #14 7 points 1 comments -> [Llama.cpp: 6.5x faster prompt processing on Arm with a NEON kernel](https://github.com/hardwiredagent/silicon-forge-arm-neon-study)<!-- HN:50481354:end --><!-- HN:50485166:start -->
* [50485166](https://news.social-protocols.org/stats?id=50485166) #4 10 points 7 comments -> [Comparing Jensen to Steve Jobs Is Stupid](https://jonaserthal.com/blog/jobs-and-jensen/)<!-- HN:50485166:end --><!-- HN:50487861:start -->
* [50487861](https://news.social-protocols.org/stats?id=50487861) #6 15 points 4 comments -> [6-11X speedup running Qwen3.6 on my RTX 4090, full repo.](https://github.com/me-farza/lightreason/tree/main)<!-- HN:50487861:end --><!-- HN:50486480:start -->
* [50486480](https://news.social-protocols.org/stats?id=50486480) #23 21 points 11 comments -> [Gnomon. Git for Postgres data, built for agents](https://github.com/bitsinfra/gnomon)<!-- HN:50486480:end --><!-- HN:50490383:start -->
* [50490383](https://news.social-protocols.org/stats?id=50490383) #6 -> [US Radar Service Outage](https://www.weather.gov/afc/radaroutage)<!-- HN:50490383:end --><!-- HN:50490967:start -->
* [50490967](https://news.social-protocols.org/stats?id=50490967) #14 6 points 1 comments -> [Home Assistant: the password is not the key – token secrets in cleartext](https://seclists.org/fulldisclosure/2026/Nov/34)<!-- HN:50490967:end -->
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
* [50525646](https://news.social-protocols.org/stats?id=50525646) #21 8 points 0 comments -> [Doom on the Nikon Z 6II camera](https://arnebaeyens.com/blog/2026/doom-on-nikon-z6ii/)<!-- HN:50525646:end -->