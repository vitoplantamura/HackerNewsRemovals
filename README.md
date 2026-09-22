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

#### **Wednesday, September 16, 2026**
<!-- HN:49724194:start -->
* [49724194](https://news.social-protocols.org/stats?id=49724194) #6 51 points 15 comments -> [Tech Fascism Has Come for American Democracy](https://techwontsave.us/episode/342_tech_fascism_has_come_for_american_democracy_w_gil_duran)<!-- HN:49724194:end --><!-- HN:49726800:start -->
* [49726800](https://news.social-protocols.org/stats?id=49726800) #29 5 points 1 comments -> [The American Age Is Over](https://www.theatlantic.com/ideas/2026/09/trump-iran-superpower-decline/688639/)<!-- HN:49726800:end --><!-- HN:49688007:start -->
* [49688007](https://news.social-protocols.org/stats?id=49688007) #12 6 points 1 comments -> [145 Days of Uptime, 56 TiB of Traffic, One Debian Upgrade](https://sarah-robin.com/blog/debian-12-13)<!-- HN:49688007:end --><!-- HN:49731515:start -->
* [49731515](https://news.social-protocols.org/stats?id=49731515) #19 23 points 2 comments -> [Fed Raises Rates for First Time in Three Years](https://www.wsj.com/economy/central-banking/fed-raises-rates-for-first-time-in-three-years-08539fbe)<!-- HN:49731515:end --><!-- HN:49733836:start -->
* [49733836](https://news.social-protocols.org/stats?id=49733836) #1 31 points 2 comments -> [Flock cameras are riddled with security vulnerabilities and hardcoded creds](https://micahflee.com/flock-cameras-are-riddled-with-security-vulnerabilities-and-hard-coded-credentials/)<!-- HN:49733836:end -->
#### **Thursday, September 17, 2026**<!-- HN:49736077:start -->
* [49736077](https://news.social-protocols.org/stats?id=49736077) #7 13 points 1 comments -> [ASCII City](https://asciicity.live/)<!-- HN:49736077:end --><!-- HN:49740093:start -->
* [49740093](https://news.social-protocols.org/stats?id=49740093) #3 8 points 3 comments -> [My AI agent gets his own calendar](https://heyjonny.dev/posts/gave-my-ai-agent-a-calendar/)<!-- HN:49740093:end --><!-- HN:49699611:start -->
* [49699611](https://news.social-protocols.org/stats?id=49699611) #19 13 points 3 comments -> [Sixteen Locks Ought to Be Enough for Anybody](https://thebuild.com/blog/sixteen-locks-ought-to-be-enough-for-anybody/)<!-- HN:49699611:end --><!-- HN:49740330:start -->
* [49740330](https://news.social-protocols.org/stats?id=49740330) #19 81 points 34 comments -> [I had Gemini train its own replacement for $9](https://www.petervijeh.com/projects/reddit-ner)<!-- HN:49740330:end --><!-- HN:49743095:start -->
* [49743095](https://news.social-protocols.org/stats?id=49743095) #10 11 points 10 comments -> [Show HN: Die With Me – Claude and Codex rate limits as AIM away messages](https://diewithme.co/join)<!-- HN:49743095:end --><!-- HN:49746986:start -->
* [49746986](https://news.social-protocols.org/stats?id=49746986) #4 105 points 43 comments -> [I Hate You Microsoft](https://henriquenunez.eu/posts/you_did_it_again_ms/)<!-- HN:49746986:end -->
#### **Friday, September 18, 2026**
<!-- HN:49749457:start -->
* [49749457](https://news.social-protocols.org/stats?id=49749457) #30 5 points 0 comments -> [The open source version of Claude Project that gives you the context ownershp](https://github.com/zqiren/Orbital)<!-- HN:49749457:end --><!-- HN:49746654:start -->
* [49746654](https://news.social-protocols.org/stats?id=49746654) #16 195 points 193 comments -> [Sex, AI, and the Apocalypse](https://www.iankduncan.com/personal/2026-09-16-sex-ai-and-the-apocalypse/)<!-- HN:49746654:end --><!-- HN:49753417:start -->
* [49753417](https://news.social-protocols.org/stats?id=49753417) #16 24 points 41 comments -> [If materialism is true, the United States is probably conscious](https://www.jstor.org/stable/24704177)<!-- HN:49753417:end --><!-- HN:49755062:start -->
* [49755062](https://news.social-protocols.org/stats?id=49755062) #15 4 points 3 comments -> [Friend at Jane Street said they will solve Riemann Hypothesis](https://www.millenniumresearch.ai/)<!-- HN:49755062:end --><!-- HN:49754516:start -->
* [49754516](https://news.social-protocols.org/stats?id=49754516) #24 9 points 2 comments -> [Show HN: Jev vs. GPT-5.6 and Claude Haiku at Pong](https://jev-pong.ably.dev/)<!-- HN:49754516:end --><!-- HN:49755312:start -->
* [49755312](https://news.social-protocols.org/stats?id=49755312) #27 22 points 14 comments -> [Show HN: Rickub – The Smartest Git in the Universe](https://rickub.com/)<!-- HN:49755312:end --><!-- HN:49757973:start -->
* [49757973](https://news.social-protocols.org/stats?id=49757973) #28 6 points 2 comments -> [iPhone Duo is design nerd catnip](https://www.gq-magazine.co.uk/article/iphone-duo-design)<!-- HN:49757973:end --><!-- HN:49757859:start -->
* [49757859](https://news.social-protocols.org/stats?id=49757859) #10 16 points 5 comments -> [Grok Voice Transcribe 2.0](https://x.ai/news/grok-voice-transcribe-2)<!-- HN:49757859:end --><!-- HN:49760746:start -->
* [49760746](https://news.social-protocols.org/stats?id=49760746) #3 37 points 9 comments -> [Y Combinator's PAC is throwing money at Republicans across the country](https://sf.gazetteer.co/y-combinators-pac-is-throwing-money-at-a-bunch-of-republicans-across-the-country)<!-- HN:49760746:end --><!-- HN:49760737:start -->
* [49760737](https://news.social-protocols.org/stats?id=49760737) #9 34 points 42 comments -> [War may be coming. Are we psychologically ready?](https://www.bbc.com/news/articles/cmn0jke547r5o)<!-- HN:49760737:end -->
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
* [49806905](https://news.social-protocols.org/stats?id=49806905) #11 8 points 0 comments -> [The human brain is two separate organs, study finds](https://news.stanford.edu/stories/2026/09/human-brain-two-separate-organs)<!-- HN:49806905:end -->