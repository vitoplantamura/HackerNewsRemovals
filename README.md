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

#### **Sunday, July 27, 2025**
<!-- HN:44698750:start -->
* [44698750](https://news.social-protocols.org/stats?id=44698750) #18 5 points 1 comments -> [The Electron E1 Processor](https://www.efficient.computer/announcing-electron-e1-processor)<!-- HN:44698750:end --><!-- HN:44700173:start -->
* [44700173](https://news.social-protocols.org/stats?id=44700173) #27 7 points 0 comments -> [Has the Russian intelligence service penetrated Telegram?](https://www.perplexity.ai/search/is-there-evidence-that-suggest-FMgkZrx3SHONR2v1wSC.zg)<!-- HN:44700173:end --><!-- HN:44661402:start -->
* [44661402](https://news.social-protocols.org/stats?id=44661402) #13 13 points 3 comments -> [Base58 versus Base85 Encoding](https://www.johndcook.com/blog/2025/07/23/base58-base85/)<!-- HN:44661402:end --><!-- HN:44701579:start -->
* [44701579](https://news.social-protocols.org/stats?id=44701579) #15 36 points 7 comments -> [No](https://olu.online/no/)<!-- HN:44701579:end --><!-- HN:44664179:start -->
* [44664179](https://news.social-protocols.org/stats?id=44664179) #25 7 points 6 comments -> [Book Review: Nixon's Memoirs](https://justismills.substack.com/p/book-review-nixons-memoirs)<!-- HN:44664179:end --><!-- HN:44703613:start -->
* [44703613](https://news.social-protocols.org/stats?id=44703613) #10 22 points 2 comments -> [Tom Lehrer, song satirist and mathematician, dies at 97](https://apnews.com/article/tom-lehrer-son-satirist-mathematician-dies-9caa7ee01faf4fbfb793d7ba984c179d)<!-- HN:44703613:end --><!-- HN:44704989:start -->
* [44704989](https://news.social-protocols.org/stats?id=44704989) #24 8 points 7 comments -> [As Women Take over a Male-Dominated Field, the Pay Drops](https://www.nytimes.com/2016/03/20/upshot/as-women-take-over-a-male-dominated-field-the-pay-drops.html)<!-- HN:44704989:end --><!-- HN:44704391:start -->
* [44704391](https://news.social-protocols.org/stats?id=44704391) #19 37 points 20 comments -> [The Evilization of Google–and What to Do About It](https://billdembski.substack.com/p/the-evilization-of-googleand-what)<!-- HN:44704391:end -->
#### **Monday, July 28, 2025**
<!-- HN:44704319:start -->
* [44704319](https://news.social-protocols.org/stats?id=44704319) #28 8 points 0 comments -> [Electrified dry reforming of methane on Ni-La2O3–loaded activated carbon](https://www.science.org/doi/10.1126/sciadv.adv1585)<!-- HN:44704319:end --><!-- HN:44704305:start -->
* [44704305](https://news.social-protocols.org/stats?id=44704305) #23 27 points 1 comments -> [Formal specs as sets of behaviors](https://surfingcomplexity.blog/2025/07/26/formal-specs-as-sets-of-behaviors/)<!-- HN:44704305:end --><!-- HN:44707040:start -->
* [44707040](https://news.social-protocols.org/stats?id=44707040) #28 4 points 8 comments -> [Self-host is just waiting for its iPhone moment](https://www.robertmao.com/blog/en/self-hosting-isnt-dead-its-just-waiting-for-its-iphone-moment)<!-- HN:44707040:end --><!-- HN:44708884:start -->
* [44708884](https://news.social-protocols.org/stats?id=44708884) #30 41 points 40 comments -> [Generative AI. "Slop Generators, are unsuitable for use [ ]"](https://asahilinux.org/docs/project/policies/slop/)<!-- HN:44708884:end --><!-- HN:44712107:start -->
* [44712107](https://news.social-protocols.org/stats?id=44712107) #12 5 points 8 comments -> [AI for Coding: Why Most Developers Are Getting It Wrong](https://www.ksred.com/ai-for-coding-why-most-developers-are-getting-it-wrong-and-how-to-get-it-right/)<!-- HN:44712107:end --><!-- HN:44712459:start -->
* [44712459](https://news.social-protocols.org/stats?id=44712459) #17 79 points 74 comments -> [NASA faces brain drain as thousands exit under voluntary resignation scheme](https://www.theregister.com/2025/07/28/nasa_voluntary_exits/)<!-- HN:44712459:end --><!-- HN:44712831:start -->
* [44712831](https://news.social-protocols.org/stats?id=44712831) #17 21 points 10 comments -> [The Rise of Vibeinsecurity](https://vibeinsecurity.com/)<!-- HN:44712831:end -->
#### **Tuesday, July 29, 2025**
<!-- HN:44718686:start -->
* [44718686](https://news.social-protocols.org/stats?id=44718686) #2 11 points 11 comments -> [Every American Is Bilingual](https://justevilenough.com/every-american-is-bilingual/)<!-- HN:44718686:end --><!-- HN:44721604:start -->
* [44721604](https://news.social-protocols.org/stats?id=44721604) #24 27 points 3 comments -> [Palestinian who helped make Oscar-winning No Other Land killed in West Bank](https://www.theguardian.com/world/2025/jul/29/palestinian-awdah-hathaleen-oscar-winning-no-other-land-killed-in-west-bank)<!-- HN:44721604:end --><!-- HN:44722701:start -->
* [44722701](https://news.social-protocols.org/stats?id=44722701) #5 10 points 13 comments -> [Detached Point Arithmetic](https://github.com/Pedantic-Research-Limited/DPA)<!-- HN:44722701:end --><!-- HN:44724663:start -->
* [44724663](https://news.social-protocols.org/stats?id=44724663) #10 12 points 2 comments -> [The IPCC: Can it regain its credibility?](https://www.meer.com/en/91051-the-ipcc-can-it-regain-its-credibility)<!-- HN:44724663:end --><!-- HN:44725437:start -->
* [44725437](https://news.social-protocols.org/stats?id=44725437) #20 14 points 0 comments -> [UK to recognise Palestinian state in September unless Israel accepts ceasefire](https://www.theguardian.com/politics/2025/jul/29/uk-to-recognise-state-of-palestine-in-september-unless-israel-holds-to-a-ceasefire)<!-- HN:44725437:end --><!-- HN:44726921:start -->
* [44726921](https://news.social-protocols.org/stats?id=44726921) #11 13 points 6 comments -> [Why CI/CD Still Doesn't Include Continuous Documentation?](https://deepdocs.dev/why-ci-cd-still-doesnt-include-continuous-documentation/)<!-- HN:44726921:end --><!-- HN:44727066:start -->
* [44727066](https://news.social-protocols.org/stats?id=44727066) #6 25 points 25 comments -> [The half-life of tech skills](https://haraldagterhuis.substack.com/p/the-great-skills-decay)<!-- HN:44727066:end -->
#### **Wednesday, July 30, 2025**<!-- HN:44732216:start -->
* [44732216](https://news.social-protocols.org/stats?id=44732216) #6 5 points 0 comments -> [Show HN: I built a free backlink exchange marketplace](https://launchigniter.com/link-exchange)<!-- HN:44732216:end --><!-- HN:44731883:start -->
* [44731883](https://news.social-protocols.org/stats?id=44731883) #5 19 points 33 comments -> [One diet soda a day increases type 2 diabetes risk by 38%](https://newatlas.com/diet-nutrition/one-drink-diabetes-risk/)<!-- HN:44731883:end --><!-- HN:44732939:start -->
* [44732939](https://news.social-protocols.org/stats?id=44732939) #3 7 points 1 comments -> [Track how much money AIPAC spent to buy Congress](https://www.trackaipac.com)<!-- HN:44732939:end --><!-- HN:44732893:start -->
* [44732893](https://news.social-protocols.org/stats?id=44732893) #15 10 points 1 comments -> [New York Times rolls back claims about viral photo of starving Gaza boy](https://nypost.com/2025/07/29/media/new-york-times-stunningly-rolls-back-claims-about-viral-photo-of-starving-gaza-boy/)<!-- HN:44732893:end --><!-- HN:44733313:start -->
* [44733313](https://news.social-protocols.org/stats?id=44733313) #27 3 points 0 comments -> [Hamas's propaganda war: Israel battles famine allegations](https://nationalpost.com/news/hamass-propaganda-war-israel-battles-famine-allegations)<!-- HN:44733313:end --><!-- HN:44733445:start -->
* [44733445](https://news.social-protocols.org/stats?id=44733445) #9 13 points 3 comments -> [We have appended an Editors' Note about Mohammed Zakaria, a child in Gaza](https://twitter.com/NYTimesPR/status/1950311365756817690)<!-- HN:44733445:end --><!-- HN:44732994:start -->
* [44732994](https://news.social-protocols.org/stats?id=44732994) #30 5 points 0 comments -> [Figma S-1, the Figma OS, Figma's AI Potential](https://stratechery.com/2025/figma-s-1-the-figma-os-figmas-ai-potential/)<!-- HN:44732994:end --><!-- HN:44733944:start -->
* [44733944](https://news.social-protocols.org/stats?id=44733944) #28 8 points 2 comments -> [The fringe movement punishing officials with fake debt claims](https://www.latimes.com/california/story/2025-07-30/fake-filings-real-consequences-how-paper-terrorism-is-burying-a-state-system-with-bogus-claims)<!-- HN:44733944:end --><!-- HN:44735359:start -->
* [44735359](https://news.social-protocols.org/stats?id=44735359) #6 -> [Startup failed. Relationship ended. 29 lessons from the wreckage](https://burnedchris.com/blog/29-lessons)<!-- HN:44735359:end --><!-- HN:44737839:start -->
* [44737839](https://news.social-protocols.org/stats?id=44737839) #29 13 points 2 comments -> [Drawing for the New Yorker](https://lizadonnelly.substack.com/p/drawing-for-the-new-yorker)<!-- HN:44737839:end --><!-- HN:44739117:start -->
* [44739117](https://news.social-protocols.org/stats?id=44739117) #7 23 points 15 comments -> [Actions Reflect Your Priorities](https://tombrady.com/posts/your-actions-reflect-your-priorities)<!-- HN:44739117:end -->
#### **Thursday, July 31, 2025**
<!-- HN:44704052:start -->
* [44704052](https://news.social-protocols.org/stats?id=44704052) #29 9 points 5 comments -> [Boston Dynamics' Atlas does backflips (lesson and breakdown)](https://app.vidyaarthi.ai/ai-tutor?session_id=2YBSyF3WNzMNn_80jygEp&action=replay&shared=true)<!-- HN:44704052:end --><!-- HN:44746272:start -->
* [44746272](https://news.social-protocols.org/stats?id=44746272) #9 5 points 1 comments -> [Italy Armed to the Teeth: My Top Nine Poliziotteschi](https://multiglom.com/2020/04/12/italy-armed-to-the-teeth-my-top-ten-poliziotteschi/)<!-- HN:44746272:end --><!-- HN:44746326:start -->
* [44746326](https://news.social-protocols.org/stats?id=44746326) #21 19 points 11 comments -> [Do PE firms create value? How?](https://www.gain.pro/insight-reports/value-creation)<!-- HN:44746326:end -->
#### **Friday, August 1, 2025**
<!-- HN:44751258:start -->
* [44751258](https://news.social-protocols.org/stats?id=44751258) #12 14 points 4 comments -> [Comprehensive Overview of the Identity Management Ecosystem in 2025](https://guptadeepak.com/understanding-the-complete-identity-management-ecosystem/)<!-- HN:44751258:end --><!-- HN:44752051:start -->
* [44752051](https://news.social-protocols.org/stats?id=44752051) #11 8 points 0 comments -> [We Asked 100 AI Models to Write Code](https://www.veracode.com/blog/genai-code-security-report/)<!-- HN:44752051:end --><!-- HN:44755298:start -->
* [44755298](https://news.social-protocols.org/stats?id=44755298) #3 43 points 36 comments -> [How to Secure a Linux Server](https://github.com/imthenachoman/How-To-Secure-A-Linux-Server)<!-- HN:44755298:end --><!-- HN:44755341:start -->
* [44755341](https://news.social-protocols.org/stats?id=44755341) #2 63 points 4 comments -> [Gemini 2.5 Deep Think](https://twitter.com/GoogleDeepMind/status/1951239132950204439)<!-- HN:44755341:end --><!-- HN:44758453:start -->
* [44758453](https://news.social-protocols.org/stats?id=44758453) #14 17 points 41 comments -> [Rate, Price Drops Won't Substantially Improve Affordability](https://www.zillow.com/research/rate-drops-35389/)<!-- HN:44758453:end --><!-- HN:44759237:start -->
* [44759237](https://news.social-protocols.org/stats?id=44759237) #26 4 points 0 comments -> [Show HN: The platform making SEO simpler, cheaper, and more effective](https://idiotproofseo.com/)<!-- HN:44759237:end --><!-- HN:44760740:start -->
* [44760740](https://news.social-protocols.org/stats?id=44760740) #14 4 points 0 comments -> [The Economy? He died five years ago](https://daverupert.com/2025/08/the-economy-he-died-five-years-ago/)<!-- HN:44760740:end --><!-- HN:44762157:start -->
* [44762157](https://news.social-protocols.org/stats?id=44762157) #19 5 points 1 comments -> [HTTP Methods](https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Methods)<!-- HN:44762157:end -->
#### **Saturday, August 2, 2025**
<!-- HN:44762504:start -->
* [44762504](https://news.social-protocols.org/stats?id=44762504) #16 39 points 24 comments -> [JSON is not a YAML subset (2022)](https://john-millikin.com/json-is-not-a-yaml-subset)<!-- HN:44762504:end --><!-- HN:44765939:start -->
* [44765939](https://news.social-protocols.org/stats?id=44765939) #7 27 points 10 comments -> [EU kills Android bootloader unlock starting August 1](https://xiaomitime.com/eu-kills-android-bootloader-unlock-starting-august-1-59449/)<!-- HN:44765939:end --><!-- HN:44766313:start -->
* [44766313](https://news.social-protocols.org/stats?id=44766313) #4 31 points 2 comments -> [Tesla Found Partly Liable in 2019 Autopilot Death](https://www.wired.com/story/tesla-liable-2019-autopilot-crash-death/)<!-- HN:44766313:end -->