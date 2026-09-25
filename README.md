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

#### **Saturday, September 19, 2026**
<!-- HN:49762573:start -->
* [49762573](https://news.social-protocols.org/stats?id=49762573) #2 15 points 6 comments -> [The Contract on America](https://3quarksdaily.com/3quarksdaily/2026/09/the-contract-on-america.html)<!-- HN:49762573:end --><!-- HN:49763234:start -->
* [49763234](https://news.social-protocols.org/stats?id=49763234) #13 5 points 0 comments -> [Harm Laundering in GPT Models: Gender Discrimination Transformed Rather Than](https://arxiv.org/abs/2609.20779)<!-- HN:49763234:end --><!-- HN:49766911:start -->
* [49766911](https://news.social-protocols.org/stats?id=49766911) #30 39 points 7 comments -> [AI Safety Is Mostly a Sex Cult](https://bsky.app/profile/segyges.bsky.social/post/3mvom4b4dn22q)<!-- HN:49766911:end --><!-- HN:49767743:start -->
* [49767743](https://news.social-protocols.org/stats?id=49767743) #4 16 points 2 comments -> [Leaving DigitalOcean, one site at a time](https://keith.is/post/leaving-digitalocean/)<!-- HN:49767743:end --><!-- HN:49768606:start -->
* [49768606](https://news.social-protocols.org/stats?id=49768606) #17 30 points 10 comments -> [People who know the most often sound the least certain](https://vrash.substack.com/p/the-people-who-know-the-most-often)<!-- HN:49768606:end --><!-- HN:49769694:start -->
* [49769694](https://news.social-protocols.org/stats?id=49769694) #9 36 points 17 comments -> [I captured 72 hours of idle Android packets behind pfSense](https://www.praveentechworld.com/research/degoogle-telemetry-2026)<!-- HN:49769694:end -->
#### **Sunday, September 20, 2026**
<!-- HN:49770860:start -->
* [49770860](https://news.social-protocols.org/stats?id=49770860) #24 6 points 1 comments -> [Claudecookie – convert, check, and mint Claude Code credentials from a cookie](https://claudecookie.com/)<!-- HN:49770860:end --><!-- HN:49771118:start -->
* [49771118](https://news.social-protocols.org/stats?id=49771118) #6 14 points 9 comments -> [Show HN: I created an open source locally usable full fledged AI platform](https://github.com/theguysudo/ENZO)<!-- HN:49771118:end --><!-- HN:49771873:start -->
* [49771873](https://news.social-protocols.org/stats?id=49771873) #9 9 points 2 comments -> [Comparing reflection capabilities of C++, Zig and C3](https://nyr24.github.io/blog/reflection-comparison/)<!-- HN:49771873:end --><!-- HN:49773871:start -->
* [49773871](https://news.social-protocols.org/stats?id=49773871) #23 8 points 0 comments -> [Show HN: AI Facial Attractiveness Model Aligned with Human Preferences](https://faceanalysisai.com/)<!-- HN:49773871:end --><!-- HN:49773951:start -->
* [49773951](https://news.social-protocols.org/stats?id=49773951) #12 28 points 17 comments -> [Don't Be Nice](https://roe.dev/blog/dont-be-nice)<!-- HN:49773951:end --><!-- HN:49775669:start -->
* [49775669](https://news.social-protocols.org/stats?id=49775669) #3 6 points 3 comments -> [PearOS](https://pearos.xyz/)<!-- HN:49775669:end --><!-- HN:49775979:start -->
* [49775979](https://news.social-protocols.org/stats?id=49775979) #3 14 points 6 comments -> [system design in depth – 200 topics, 118 diagrams, interactive demos](https://system-design-in-depth.pages.dev)<!-- HN:49775979:end --><!-- HN:49776589:start -->
* [49776589](https://news.social-protocols.org/stats?id=49776589) #4 8 points 9 comments -> [If You Knew God Exists, Wouldn't You Become a Priest?](https://joecmarshall.com/posts/if-you-knew-god-exists-wouldnt-you-become-a-priest/)<!-- HN:49776589:end --><!-- HN:49776887:start -->
* [49776887](https://news.social-protocols.org/stats?id=49776887) #14 6 points 0 comments -> [Jev Collection](https://academy.dair.ai/resources/jev-field-notes)<!-- HN:49776887:end --><!-- HN:49778078:start -->
* [49778078](https://news.social-protocols.org/stats?id=49778078) #14 11 points 2 comments -> [Self-hosted inference orchestrators compared: LocalAI, exo, GPUStack, vLLM](https://www.nexlab.net/articles/self-hosted-inference-orchestrators-compared-2026/)<!-- HN:49778078:end --><!-- HN:49778008:start -->
* [49778008](https://news.social-protocols.org/stats?id=49778008) #22 11 points 6 comments -> [Show HN: Three genlocked RP2350B make a console – 3k sprite pixels per line)](https://www.papydeck.eu/)<!-- HN:49778008:end --><!-- HN:49780466:start -->
* [49780466](https://news.social-protocols.org/stats?id=49780466) #10 17 points 18 comments -> [Nipple tattooist 'frustrated' by online censorship](https://www.bbc.com/news/articles/cx2z7ejn891o)<!-- HN:49780466:end -->
#### **Monday, September 21, 2026**
<!-- HN:49782242:start -->
* [49782242](https://news.social-protocols.org/stats?id=49782242) #5 16 points 1 comments -> [Can I Let My AI Agent Run on Shabbat?](https://www.chabad.org/library/article_cdo/aid/7288064/jewish/Can-I-Let-My-AI-Agent-Run-on-Shabbat.htm)<!-- HN:49782242:end --><!-- HN:49776699:start -->
* [49776699](https://news.social-protocols.org/stats?id=49776699) #8 528 points 143 comments -> [Pirate Face Rescues LLM Models from Deletion](https://pirateface.co/)<!-- HN:49776699:end --><!-- HN:49784873:start -->
* [49784873](https://news.social-protocols.org/stats?id=49784873) #10 8 points 3 comments -> [Show HN: Bitcoin-rs – An AI-assisted Bitcoin full node in Rust](https://github.com/gosuda/bitcoin-rs)<!-- HN:49784873:end --><!-- HN:49785783:start -->
* [49785783](https://news.social-protocols.org/stats?id=49785783) #8 9 points 6 comments -> [NEC V20 CPU: A bit of pep for an XT](https://dfarq.homeip.net/nec-v20-cpu-a-bit-of-pep-for-an-xt/)<!-- HN:49785783:end --><!-- HN:49786401:start -->
* [49786401](https://news.social-protocols.org/stats?id=49786401) #19 8 points 3 comments -> [Show HN: SQLBraid – Write SQL directly in TypeScript without a query-builder DSL](https://github.com/Clickin/SQLBraid)<!-- HN:49786401:end --><!-- HN:49787767:start -->
* [49787767](https://news.social-protocols.org/stats?id=49787767) #26 120 points 107 comments -> [Meta bans ads for Virginia Woolf play in Spain](https://www.theguardian.com/technology/2026/sep/21/meta-ban-virginia-woolf-a-room-of-ones-own-barcelona-teatre-raval)<!-- HN:49787767:end --><!-- HN:49791380:start -->
* [49791380](https://news.social-protocols.org/stats?id=49791380) #24 -> [Help 404 Media Find Out How Your Local Police Are Surveiling You](https://www.404media.co/is-your-city-using-axon-license-plate-cameras-we-need-your-help/)<!-- HN:49791380:end -->
#### **Tuesday, September 22, 2026**
<!-- HN:49797226:start -->
* [49797226](https://news.social-protocols.org/stats?id=49797226) #9 12 points 4 comments -> [Firmware Freedom](https://playtaurus.com/blog/firmware-freedom)<!-- HN:49797226:end --><!-- HN:49799187:start -->
* [49799187](https://news.social-protocols.org/stats?id=49799187) #5 10 points 2 comments -> [A Tokyo school counts the mornings it can see Mt. Fuji: 22 in 1965, 170 in 2023](https://jivx.com/fujimi)<!-- HN:49799187:end --><!-- HN:49799577:start -->
* [49799577](https://news.social-protocols.org/stats?id=49799577) #9 34 points 18 comments -> [Type Punning in C and C++](https://blog.pwkf.org/2026/09/21/correct-type-punning-in-c.html)<!-- HN:49799577:end --><!-- HN:49800917:start -->
* [49800917](https://news.social-protocols.org/stats?id=49800917) #29 15 points 1 comments -> [AI Is Antithetical to Learning](https://jola.dev/posts/ai-antithetical-learning)<!-- HN:49800917:end --><!-- HN:49801782:start -->
* [49801782](https://news.social-protocols.org/stats?id=49801782) #11 10 points 0 comments -> [Quantum information spreading via higher-order operator correlators](https://arxiv.org/abs/2609.05472)<!-- HN:49801782:end --><!-- HN:49800259:start -->
* [49800259](https://news.social-protocols.org/stats?id=49800259) #23 39 points 31 comments -> [What Capital Never Told You About Rent](https://www.humansontheloop.com/p/rent)<!-- HN:49800259:end --><!-- HN:49802619:start -->
* [49802619](https://news.social-protocols.org/stats?id=49802619) #9 12 points 12 comments -> [If you start writing today, there's no way to know if you can write without AI](https://www.ssp.sh/brain/ai-writing/)<!-- HN:49802619:end --><!-- HN:49802160:start -->
* [49802160](https://news.social-protocols.org/stats?id=49802160) #19 78 points 24 comments -> [Jev – A curation of Jev demos on X, tools, skills, and integrations](https://github.com/Amal-David/awesome-jev)<!-- HN:49802160:end --><!-- HN:49803863:start -->
* [49803863](https://news.social-protocols.org/stats?id=49803863) #1 255 points 180 comments -> [Claude Opus 5.5](https://www.anthropic.com/claude-opus-5-5)<!-- HN:49803863:end --><!-- HN:49806050:start -->
* [49806050](https://news.social-protocols.org/stats?id=49806050) #11 7 points 1 comments -> [Zero-downtime Linux kernel zero-day mitigation via eBPF and SECCOMP](https://github.com/mc493/linux-kernel-zero-day-mitigation-zero-downtime-kernel-defense-)<!-- HN:49806050:end --><!-- HN:49806905:start -->
* [49806905](https://news.social-protocols.org/stats?id=49806905) #11 8 points 0 comments -> [The human brain is two separate organs, study finds](https://news.stanford.edu/stories/2026/09/human-brain-two-separate-organs)<!-- HN:49806905:end --><!-- HN:49808096:start -->
* [49808096](https://news.social-protocols.org/stats?id=49808096) #8 34 points 15 comments -> [No Sloptober](https://no-sloptober.com/)<!-- HN:49808096:end --><!-- HN:49807688:start -->
* [49807688](https://news.social-protocols.org/stats?id=49807688) #4 114 points 35 comments -> [LLM Ass Bench](https://www.assbench.com/)<!-- HN:49807688:end -->
#### **Wednesday, September 23, 2026**<!-- HN:49813704:start -->
* [49813704](https://news.social-protocols.org/stats?id=49813704) #4 8 points 0 comments -> [What Is an AI Software Factory? Lessons from 3 Client Deployments](https://camplight.net/ai/ai-software-factory/)<!-- HN:49813704:end --><!-- HN:49814211:start -->
* [49814211](https://news.social-protocols.org/stats?id=49814211) #10 33 points 41 comments -> [The Download: why AI's latest breakthroughs and fears may be more hype than rea](https://www.technologyreview.com/2026/09/22/1144910/the-download-dont-believe-ai-hype/)<!-- HN:49814211:end --><!-- HN:49816221:start -->
* [49816221](https://news.social-protocols.org/stats?id=49816221) #11 4 points 1 comments -> [Heirs of Goebbels: falsification of the events in Bucha [pdf]](https://mid.ru/upload/medialibrary/498/kdvll1f5vpeumn6sk0mue9k2iseknfwh/Report%20Falsification%20of%20the%20events%20in%20Bucha%20by%20the%20Kiev%20regime%20in%20English%20(in%20PDF).pdf)<!-- HN:49816221:end --><!-- HN:49815095:start -->
* [49815095](https://news.social-protocols.org/stats?id=49815095) #24 17 points 8 comments -> [Show HN: RxFilm Studio–Create and edit your product videos with AI agent](https://filmstudio.rxlab.app)<!-- HN:49815095:end --><!-- HN:49815168:start -->
* [49815168](https://news.social-protocols.org/stats?id=49815168) #23 16 points 17 comments -> [Show HN: Ive Sent It – online courier for files, with signed proof of delivery](https://ivesentit.com)<!-- HN:49815168:end --><!-- HN:49817280:start -->
* [49817280](https://news.social-protocols.org/stats?id=49817280) #27 57 points 9 comments -> [Why is Hacker News like that?](https://drewdevault.com/blog/Why-is-HN-like-that/)<!-- HN:49817280:end --><!-- HN:49816487:start -->
* [49816487](https://news.social-protocols.org/stats?id=49816487) #15 27 points 5 comments -> [Jev in practice: typed decisions, scoped authority](https://tenuo.ai/blog/jev-scoped-authority)<!-- HN:49816487:end --><!-- HN:49815867:start -->
* [49815867](https://news.social-protocols.org/stats?id=49815867) #30 2 points 0 comments -> [Six of 48: I logged every way my AI agents failed for five months](https://github.com/taylorancapital/nothing-threw/blob/main/SIX_OF_FORTY_EIGHT.md)<!-- HN:49815867:end --><!-- HN:49816143:start -->
* [49816143](https://news.social-protocols.org/stats?id=49816143) #29 43 points 40 comments -> [Socialism's Positive Rating Tops 40% for First Time](https://news.gallup.com/poll/714653/socialism-positive-rating-tops-first-time.aspx)<!-- HN:49816143:end --><!-- HN:49817636:start -->
* [49817636](https://news.social-protocols.org/stats?id=49817636) #25 20 points 2 comments -> [What to Know About JavaScript in 2026](https://blog.master.dev/what-to-know-in-javascript-2026-edition/)<!-- HN:49817636:end --><!-- HN:49821925:start -->
* [49821925](https://news.social-protocols.org/stats?id=49821925) #5 23 points 15 comments -> [How can this Amazon scammer keep going, not shipping any goods?](https://www.amazon.de/sp?language=en&ie=UTF8&seller=A29EBN4DXM8UCL&asin=B0CGBFF8K9&ref_=dp_merchant_link)<!-- HN:49821925:end --><!-- HN:49822186:start -->
* [49822186](https://news.social-protocols.org/stats?id=49822186) #9 24 points 0 comments -> [LensVLM-9B by Apple](https://huggingface.co/papers/2605.07019)<!-- HN:49822186:end --><!-- HN:49822921:start -->
* [49822921](https://news.social-protocols.org/stats?id=49822921) #2 16 points 5 comments -> [Bulk Orders Surge at Used Bookstores in Japan; 50 Tons Sent to U.S.](https://news.ntv.co.jp/category/society/e48899c1ab1445f683929740ef2b3aa6)<!-- HN:49822921:end --><!-- HN:49822864:start -->
* [49822864](https://news.social-protocols.org/stats?id=49822864) #9 93 points 34 comments -> [Claude's Load-Bearing Seams](https://madradavid.com/claudes-load-bearing-seams/)<!-- HN:49822864:end -->
#### **Thursday, September 24, 2026**
<!-- HN:49823922:start -->
* [49823922](https://news.social-protocols.org/stats?id=49823922) #12 9 points 2 comments -> [We've Turned Starlink into a Planetary Barometer](https://www.spaceweather.com/starlink/starlink_drag_explainer.html)<!-- HN:49823922:end --><!-- HN:49824957:start -->
* [49824957](https://news.social-protocols.org/stats?id=49824957) #7 10 points 2 comments -> [We used an AI agent to fix an open-source bug. Someone asked to ban us](https://github.com/saulpw/visidata/pull/3229)<!-- HN:49824957:end --><!-- HN:49790937:start -->
* [49790937](https://news.social-protocols.org/stats?id=49790937) #19 9 points 0 comments -> [Show HN: Combinators in Array Languages](https://blog.softwarewrighter.com/2026/09/21/rabbit-hole-sage-y-combinator/)<!-- HN:49790937:end --><!-- HN:49825024:start -->
* [49825024](https://news.social-protocols.org/stats?id=49825024) #22 113 points 77 comments -> [Australia says OpenAI agent hacked into government website](https://www.channelnewsasia.com/world/australia-openai-agent-breach-government-portal-6406411)<!-- HN:49825024:end --><!-- HN:49827002:start -->
* [49827002](https://news.social-protocols.org/stats?id=49827002) #4 10 points 2 comments -> [AI Passport Photo](https://www.aipassportphoto.org/)<!-- HN:49827002:end --><!-- HN:49827019:start -->
* [49827019](https://news.social-protocols.org/stats?id=49827019) #12 6 points 2 comments -> [Can open-source prompt-injection detectors catch realistic AI agent attacks?](https://github.com/rudratoshs/buried-injections)<!-- HN:49827019:end --><!-- HN:49799702:start -->
* [49799702](https://news.social-protocols.org/stats?id=49799702) #17 9 points 2 comments -> [The backend that ran every game we made, ten years and counting](https://www.m2h.nl/writing/the-toolkit-behind-ten-years-of-games/)<!-- HN:49799702:end --><!-- HN:49828177:start -->
* [49828177](https://news.social-protocols.org/stats?id=49828177) #21 10 points 1 comments -> [Looks promising for document editing with your agent](https://www.paperinstruments.com/blog/introducing-paper-office)<!-- HN:49828177:end --><!-- HN:49787482:start -->
* [49787482](https://news.social-protocols.org/stats?id=49787482) #17 6 points 3 comments -> [Do Food Trucks Need a Commissary Kitchen? Yes – Here's Why That's a Good Thing](https://www.thefoodcorridor.com/blog/do-food-trucks-need-a-commissary-kitchen/)<!-- HN:49787482:end --><!-- HN:49825580:start -->
* [49825580](https://news.social-protocols.org/stats?id=49825580) #17 239 points 169 comments -> [OpenAI agent hacked Australian government website, PM says](https://www.bbc.com/news/live/cvgl73pxgndwt)<!-- HN:49825580:end --><!-- HN:49833269:start -->
* [49833269](https://news.social-protocols.org/stats?id=49833269) #21 9 points 0 comments -> [NAZA, a documentary on Israeli war crimes will be free to stream in November](https://twitter.com/yuval_abraham/status/2103061893913162054)<!-- HN:49833269:end --><!-- HN:49833611:start -->
* [49833611](https://news.social-protocols.org/stats?id=49833611) #11 20 points 12 comments -> [S.F. Democratic Party stands behind Flock surveillance cameras in vote](https://missionlocal.org/2026/09/san-francisco-democratic-party-flock-cameras/)<!-- HN:49833611:end --><!-- HN:49832317:start -->
* [49832317](https://news.social-protocols.org/stats?id=49832317) #20 -> [Why is the human body so crap except for the liver?](https://dynomight.net/liver/)<!-- HN:49832317:end --><!-- HN:49832564:start -->
* [49832564](https://news.social-protocols.org/stats?id=49832564) #21 27 points 1 comments -> [Oracle invokes force majeure on New Mexico AI data center](https://qz.com/oracle-force-majeure-new-mexico-ai-data-center-092426)<!-- HN:49832564:end --><!-- HN:49827713:start -->
* [49827713](https://news.social-protocols.org/stats?id=49827713) #22 9 points 3 comments -> [Rails World 2026 Opening Keynote [video]](https://www.youtube.com/watch?v=vDjW_dRyKXY)<!-- HN:49827713:end --><!-- HN:49836678:start -->
* [49836678](https://news.social-protocols.org/stats?id=49836678) #9 7 points 1 comments -> [Vibe Coding Production Kit – a production workflow for AI coding agents](https://github.com/Moeeryani/Vibe-Coding-Production-Kit)<!-- HN:49836678:end -->
#### **Friday, September 25, 2026**
<!-- HN:49839510:start -->
* [49839510](https://news.social-protocols.org/stats?id=49839510) #5 10 points 4 comments -> [Jev and System One Models: Calibration Beats Accuracy](https://www.kartikpansuriya.com/blog/jev-system-one-model-calibrated-decisions)<!-- HN:49839510:end --><!-- HN:49841103:start -->
* [49841103](https://news.social-protocols.org/stats?id=49841103) #6 6 points 6 comments -> [The Efficiency-Throughput Gap with GitHub Copilot](https://cacm.acm.org/research/beyond-the-hype-the-efficiency-throughput-gap-with-github-copilot/)<!-- HN:49841103:end --><!-- HN:49841912:start -->
* [49841912](https://news.social-protocols.org/stats?id=49841912) #3 11 points 9 comments -> [The last day of the dinosaurs, as an interactive painting](https://www.echohive.ai/experiments/dinosaurs)<!-- HN:49841912:end --><!-- HN:49842707:start -->
* [49842707](https://news.social-protocols.org/stats?id=49842707) #10 25 points 41 comments -> [Uproar in France over award-winning author accused of using AI](https://www.bbc.com/news/articles/ck7v4y45893go)<!-- HN:49842707:end --><!-- HN:49842788:start -->
* [49842788](https://news.social-protocols.org/stats?id=49842788) #9 18 points 3 comments -> [Anthropic: The Situation Report](https://www.anthropic.com/features/ebola-response)<!-- HN:49842788:end --><!-- HN:49848201:start -->
* [49848201](https://news.social-protocols.org/stats?id=49848201) #23 8 points 0 comments -> [How to Cure a Feminist](https://twitter.com/hannahspierMD/status/2102660372939374628)<!-- HN:49848201:end --><!-- HN:49846391:start -->
* [49846391](https://news.social-protocols.org/stats?id=49846391) #28 55 points 38 comments -> [Jevmem – automatic project memory for Claude Code, built on Jev](https://github.com/Avinash-jetwani/jevmem)<!-- HN:49846391:end --><!-- HN:49846864:start -->
* [49846864](https://news.social-protocols.org/stats?id=49846864) #7 -> [A Skill.md for Commenting on Hacker News](https://blog.coredump.cx/p/a-skillmd-for-commenting-on-hacker)<!-- HN:49846864:end -->