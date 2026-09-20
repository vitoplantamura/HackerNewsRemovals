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

#### **Monday, September 14, 2026**
<!-- HN:49690529:start -->
* [49690529](https://news.social-protocols.org/stats?id=49690529) #18 20 points 31 comments -> [AI is not a normal technology](https://12gramsofcarbon.com/p/ai-is-not-a-normal-technology)<!-- HN:49690529:end --><!-- HN:49691447:start -->
* [49691447](https://news.social-protocols.org/stats?id=49691447) #6 9 points 0 comments -> [Turkish police detain dozens in raids on gay bars and homes of LGBTQ+ activists](https://www.bbc.com/news/articles/cpve191wy47o)<!-- HN:49691447:end --><!-- HN:49690943:start -->
* [49690943](https://news.social-protocols.org/stats?id=49690943) #27 54 points 19 comments -> [Show HN: Is It Greg?](https://github.com/antoineleclair/is-it-greg)<!-- HN:49690943:end --><!-- HN:49652723:start -->
* [49652723](https://news.social-protocols.org/stats?id=49652723) #22 3 points 0 comments -> [Review a pull request by booting it](https://fzakaria.com/2026/09/09/review-a-pull-request-by-booting-it)<!-- HN:49652723:end --><!-- HN:49692765:start -->
* [49692765](https://news.social-protocols.org/stats?id=49692765) #12 31 points 40 comments -> [Of Gods and Languages: On "When God Spoke Greek"](https://lareviewofbooks.org/article/of-gods-and-languages-on-when-god-spoke-greek/)<!-- HN:49692765:end --><!-- HN:49694547:start -->
* [49694547](https://news.social-protocols.org/stats?id=49694547) #4 5 points 0 comments -> [How Is Compression Prediction?](https://lukefleed.xyz/posts/compression/)<!-- HN:49694547:end --><!-- HN:49694840:start -->
* [49694840](https://news.social-protocols.org/stats?id=49694840) #14 54 points 19 comments -> [How Much Has Trump Made from Crypto? ($1.4B from 2025 Federal Disclosure)](https://www.thepricer.org/how-much-has-trump-made-from-crypto/)<!-- HN:49694840:end --><!-- HN:49695087:start -->
* [49695087](https://news.social-protocols.org/stats?id=49695087) #23 9 points 1 comments -> [Why the software industry needs a lot of regulation](https://petewarden.com/2026/09/10/why-the-software-industry-needs-a-lot-of-regulation/)<!-- HN:49695087:end --><!-- HN:49695057:start -->
* [49695057](https://news.social-protocols.org/stats?id=49695057) #16 7 points 3 comments -> [Show HN: StemJSON – a language for LLMs to extend native mobile apps on the fly](https://stemjson.com/)<!-- HN:49695057:end --><!-- HN:49694404:start -->
* [49694404](https://news.social-protocols.org/stats?id=49694404) #29 7 points 9 comments -> [Show HN: ChaosTree – A zero-dependency Java tree library (AVL,RBT,B-Tree,B+Tree)](https://github.com/Chaos-vy/ChaosTree)<!-- HN:49694404:end --><!-- HN:49697247:start -->
* [49697247](https://news.social-protocols.org/stats?id=49697247) #9 3 points 0 comments -> [SubRunGear](https://www.subrungear.com/)<!-- HN:49697247:end --><!-- HN:49696704:start -->
* [49696704](https://news.social-protocols.org/stats?id=49696704) #22 8 points 0 comments -> [Kamal – Deploy web apps anywhere from bare metal to cloud VMs](https://kamal-deploy.org/)<!-- HN:49696704:end --><!-- HN:49697727:start -->
* [49697727](https://news.social-protocols.org/stats?id=49697727) #27 9 points 8 comments -> [A list of 1,325 AI assisted repositories, mined from GitHub](https://github.com/ActuallyTaylor/strata/blob/main/paper/data/large/datasets/ai-assisted-repositories.csv)<!-- HN:49697727:end --><!-- HN:49697444:start -->
* [49697444](https://news.social-protocols.org/stats?id=49697444) #23 21 points 3 comments -> [Graphic Rants: Nanite Tessellation](http://graphicrants.blogspot.com/2026/02/nanite-tessellation.html)<!-- HN:49697444:end --><!-- HN:49695459:start -->
* [49695459](https://news.social-protocols.org/stats?id=49695459) #17 264 points 249 comments -> [XCancel suspended "due to a new development in the ongoing legal proceedings"](https://xcancel.com/twitter)<!-- HN:49695459:end --><!-- HN:49698603:start -->
* [49698603](https://news.social-protocols.org/stats?id=49698603) #3 35 points 3 comments -> [Foundation Model Engineering: From Theory to Production](https://sungeuns.github.io/foundation-model-engineering/)<!-- HN:49698603:end --><!-- HN:49699527:start -->
* [49699527](https://news.social-protocols.org/stats?id=49699527) #22 7 points 5 comments -> [I stress-tested Meta Muse until its agent control plane started timing out](https://blog.cygankiewicz.com/en/meta-muse-black-box-testing/)<!-- HN:49699527:end --><!-- HN:49700299:start -->
* [49700299](https://news.social-protocols.org/stats?id=49700299) #3 18 points 1 comments -> [It's a Scam](https://nice-marmot.net/Archives/2026/September_2026.html#note_3792)<!-- HN:49700299:end --><!-- HN:49699526:start -->
* [49699526](https://news.social-protocols.org/stats?id=49699526) #16 33 points 4 comments -> [Hacking AI customer service agents](https://www.intigriti.com/researchers/blog/hacking-tools/hacking-ai-customer-service-agents)<!-- HN:49699526:end --><!-- HN:49700193:start -->
* [49700193](https://news.social-protocols.org/stats?id=49700193) #30 10 points 5 comments -> [iOS 27 Released](https://www.apple.com/os/ios/)<!-- HN:49700193:end --><!-- HN:49698423:start -->
* [49698423](https://news.social-protocols.org/stats?id=49698423) #28 50 points 41 comments -> [Things That Annoy Me About Cars](https://blog.decryption.net.au/posts/cars_suck.html)<!-- HN:49698423:end --><!-- HN:49671831:start -->
* [49671831](https://news.social-protocols.org/stats?id=49671831) #27 5 points 3 comments -> [NüshuRescue: Reviving the Endangered Nüshu Language with AI](https://aclanthology.org/2025.coling-main.468/)<!-- HN:49671831:end --><!-- HN:49666335:start -->
* [49666335](https://news.social-protocols.org/stats?id=49666335) #18 7 points 0 comments -> [Show HN: Bypassing Transformer Softmax via Static Contraction](https://github.com/PJHkorea/jax-softmax-bypass)<!-- HN:49666335:end --><!-- HN:49703276:start -->
* [49703276](https://news.social-protocols.org/stats?id=49703276) #26 28 points 3 comments -> [A Beginning for Mathematics](https://proofsandprompts.com/2026/09/14/a-beginning-for-mathematics/)<!-- HN:49703276:end --><!-- HN:49631365:start -->
* [49631365](https://news.social-protocols.org/stats?id=49631365) #21 40 points 2 comments -> [Show HN: Apollo Lunar Module landing simulation](https://gosandeep.com/eagles-descent/)<!-- HN:49631365:end -->
#### **Tuesday, September 15, 2026**
<!-- HN:49712337:start -->
* [49712337](https://news.social-protocols.org/stats?id=49712337) #7 9 points 1 comments -> [How the New York Times Framed the War Between Israel and Hamas](https://www.tandfonline.com/doi/full/10.1080/1057610X.2026.2707956#abstract)<!-- HN:49712337:end --><!-- HN:49712720:start -->
* [49712720](https://news.social-protocols.org/stats?id=49712720) #24 6 points 13 comments -> [Show HN: Jexxa: High Speed on Device Dictation](https://jexxa.org)<!-- HN:49712720:end --><!-- HN:49712596:start -->
* [49712596](https://news.social-protocols.org/stats?id=49712596) #18 5 points 0 comments -> [Sovereign: A Unified GPU Inference Substrate (Fractal Memory, Manifold Routing)](https://github.com/CuppaTea1983/Sovereign/tree/V1)<!-- HN:49712596:end --><!-- HN:49711225:start -->
* [49711225](https://news.social-protocols.org/stats?id=49711225) #30 11 points 1 comments -> [Suchir Balaji's Homepage](https://suchir.net/)<!-- HN:49711225:end --><!-- HN:49714457:start -->
* [49714457](https://news.social-protocols.org/stats?id=49714457) #8 10 points 7 comments -> [V1.1 state of open source- OS 4.4 months behind frontier [pdf]](https://stateofopensource.ai/state-of-open-source-ai-v1-1.pdf)<!-- HN:49714457:end --><!-- HN:49713637:start -->
* [49713637](https://news.social-protocols.org/stats?id=49713637) #19 8 points 2 comments -> [The bitter lesson of browser agents](https://browser-use.com/posts/bitter-lesson-browser-agents)<!-- HN:49713637:end --><!-- HN:49715463:start -->
* [49715463](https://news.social-protocols.org/stats?id=49715463) #8 11 points 16 comments -> [Leaving Linux](https://jackevans.bearblog.dev/leaving-linux/)<!-- HN:49715463:end --><!-- HN:49715802:start -->
* [49715802](https://news.social-protocols.org/stats?id=49715802) #9 5 points 3 comments -> [Why Personal Websites Are Coming Back](https://deadparrotbbs.com/why-personal-websites-are-coming-back/)<!-- HN:49715802:end --><!-- HN:49716702:start -->
* [49716702](https://news.social-protocols.org/stats?id=49716702) #8 10 points 3 comments -> [How AI tool calling works (40 lines of vanilla JavaScript)](https://buttercup.sh/lessons/2026-09-15-lesson-2-tool-calling.html)<!-- HN:49716702:end -->
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
* [49771118](https://news.social-protocols.org/stats?id=49771118) #6 14 points 9 comments -> [Show HN: I created an open source locally usable full fledged AI platform](https://github.com/theguysudo/ENZO)<!-- HN:49771118:end -->