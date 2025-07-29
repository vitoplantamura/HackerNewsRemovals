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

#### **Wednesday, July 23, 2025**
<!-- HN:44653899:start -->
* [44653899](https://news.social-protocols.org/stats?id=44653899) #27 5 points 5 comments -> [You lose 23 minutes of focus every Google or GPT use;](https://www.wagoo.ai/)<!-- HN:44653899:end --><!-- HN:44654493:start -->
* [44654493](https://news.social-protocols.org/stats?id=44654493) #7 29 points 41 comments -> [Why does raising the retirement age hurt young people?](https://www.governance.fyi/p/why-does-raising-the-retirement-age)<!-- HN:44654493:end --><!-- HN:44632500:start -->
* [44632500](https://news.social-protocols.org/stats?id=44632500) #19 33 points 40 comments -> [Java is still worth learning](https://empatheticdeveloper.wordpress.com/2025/07/20/why-java-is-still-worth-learning-in-2025-a-developers-25-year-journey/)<!-- HN:44632500:end --><!-- HN:44657028:start -->
* [44657028](https://news.social-protocols.org/stats?id=44657028) #24 -> [AFP journalists warn their 'last reporters will die' in current Gaza conditions](https://apnews.com/article/gaza-hunger-journalists-food-afp-32c19db56ddf9f3e6a847c76a676c7c9)<!-- HN:44657028:end --><!-- HN:44657133:start -->
* [44657133](https://news.social-protocols.org/stats?id=44657133) #10 -> [How to Start Prop Firm Trading with Minimal Capital?](https://propfirmplus.com/)<!-- HN:44657133:end --><!-- HN:44657261:start -->
* [44657261](https://news.social-protocols.org/stats?id=44657261) #22 9 points 0 comments -> [Wick Effect](https://en.wikipedia.org/wiki/Wick_effect)<!-- HN:44657261:end --><!-- HN:44657694:start -->
* [44657694](https://news.social-protocols.org/stats?id=44657694) #4 6 points 4 comments -> [Short Google](https://tompccs.github.io/blog/2025/07/23/short-google.html)<!-- HN:44657694:end --><!-- HN:44658112:start -->
* [44658112](https://news.social-protocols.org/stats?id=44658112) #21 10 points 6 comments -> [Are we witnessing the final days of Mozilla?](https://lunduke.locals.com/post/7132314/are-we-witnessing-the-final-days-of-mozilla)<!-- HN:44658112:end --><!-- HN:44658458:start -->
* [44658458](https://news.social-protocols.org/stats?id=44658458) #20 23 points 40 comments -> [Are we Trek yet? – A guide for how close we are to Star Trek technology](https://arewetrekyet.com/)<!-- HN:44658458:end --><!-- HN:44658573:start -->
* [44658573](https://news.social-protocols.org/stats?id=44658573) #13 12 points 12 comments -> [How younger people interact with the modern internet](https://social.restless.systems/@CursedSilicon/114899888735166987)<!-- HN:44658573:end --><!-- HN:44662658:start -->
* [44662658](https://news.social-protocols.org/stats?id=44662658) #14 18 points 5 comments -> [Why Do Victims of Massacres Go to Their Deaths?](https://www.benlandautaylor.com/p/why-do-victims-of-massacres-go-quietly)<!-- HN:44662658:end --><!-- HN:44663021:start -->
* [44663021](https://news.social-protocols.org/stats?id=44663021) #27 96 points 37 comments -> [ICE block founder's wife fired by DOJ in retaliation for the app](https://www.newsweek.com/iceblock-app-founder-wife-fired-doj-carolyn-feinstein-2102214)<!-- HN:44663021:end --><!-- HN:44621551:start -->
* [44621551](https://news.social-protocols.org/stats?id=44621551) #30 9 points 0 comments -> [Magnetic Components Directory Website](https://magdir.com)<!-- HN:44621551:end -->
#### **Thursday, July 24, 2025**
<!-- HN:44630028:start -->
* [44630028](https://news.social-protocols.org/stats?id=44630028) #26 10 points 17 comments -> [Thawing vacuum-packed fish correctly](https://www.canr.msu.edu/news/open_your_vacuum_packed_fish_before_thawing)<!-- HN:44630028:end --><!-- HN:44670727:start -->
* [44670727](https://news.social-protocols.org/stats?id=44670727) #26 -> [Instagram Temporarily Suspends Zohran Mamdani's Account](https://nycjournals.com/2025/07/21/instagram-suspends-zohran-mamdanis-account-leaked-memo-cites-national-interest-as-meta-tilts-right/)<!-- HN:44670727:end --><!-- HN:44670947:start -->
* [44670947](https://news.social-protocols.org/stats?id=44670947) #16 14 points 4 comments -> [Yet another bad three months as Tesla reports its Q2 2025 results](https://arstechnica.com/cars/2025/07/tesla-q2-2025-sell-fewer-cars-and-carbon-credits-make-less-money/)<!-- HN:44670947:end --><!-- HN:44671284:start -->
* [44671284](https://news.social-protocols.org/stats?id=44671284) #22 9 points 0 comments -> [We Need a European Sovereign Tech Fund](https://github.blog/open-source/maintainers/we-need-a-european-sovereign-tech-fund/)<!-- HN:44671284:end --><!-- HN:44672136:start -->
* [44672136](https://news.social-protocols.org/stats?id=44672136) #16 -> [Instagram Suspends Mamdani for 3 Hours, Cites 'National Interest'](https://nycjournals.com/2025/07/21/instagram-suspends-zohran-mamdanis-account-leaked-memo-cites-national-interest-as-meta-tilts-right/)<!-- HN:44672136:end --><!-- HN:44670624:start -->
* [44670624](https://news.social-protocols.org/stats?id=44670624) #7 188 points 2 comments -> [AMD CEO says U.S.-made TSMC chips are 5%-20% more expensive, but worth it](https://www.tomshardware.com/tech-industry/amd-ceo-says-u-s-made-tsmc-chips-are-more-expensive-but-worth-it-costs-more-than-5-percent-but-less-than-20-percent-higher-than-taiwan-sourced-alternative)<!-- HN:44670624:end --><!-- HN:44633809:start -->
* [44633809](https://news.social-protocols.org/stats?id=44633809) #22 14 points 1 comments -> [Global earthquake detection and warning using Android phones](https://doi.org/10.1126/science.ads4779)<!-- HN:44633809:end --><!-- HN:44675697:start -->
* [44675697](https://news.social-protocols.org/stats?id=44675697) #10 45 points 25 comments -> [Games: No sex, please. we're credit card companies](https://arstechnica.com/gaming/2025/07/once-a-relative-haven-for-adult-games-itch-io-begins-removing-explicit-titles/)<!-- HN:44675697:end -->
#### **Friday, July 25, 2025**
<!-- HN:44634110:start -->
* [44634110](https://news.social-protocols.org/stats?id=44634110) #16 10 points 2 comments -> [AI groups spend to replace low-cost 'data labellers' with high-paid experts](https://www.ft.com/content/e17647f0-4c3b-49b4-a031-b56158bbb3b8)<!-- HN:44634110:end --><!-- HN:44632369:start -->
* [44632369](https://news.social-protocols.org/stats?id=44632369) #19 14 points 3 comments -> [Information Warfare](https://yuxi.ml/sketches/posts/info-warfare/)<!-- HN:44632369:end --><!-- HN:44681883:start -->
* [44681883](https://news.social-protocols.org/stats?id=44681883) #14 6 points 0 comments -> ["Whites-only" community plotting expansion to another US state](https://www.independent.co.uk/news/world/americas/return-to-the-land-whites-only-community-b2795213.html)<!-- HN:44681883:end --><!-- HN:44685616:start -->
* [44685616](https://news.social-protocols.org/stats?id=44685616) #17 8 points 3 comments -> [Guns and Violence](https://rajivsethi.substack.com/p/guns-violence)<!-- HN:44685616:end --><!-- HN:44683447:start -->
* [44683447](https://news.social-protocols.org/stats?id=44683447) #23 55 points 67 comments -> [Air Canada returned lost bag, it now had knife,toiletries, ticket scanner inside](https://www.cbc.ca/news/canada/newfoundland-labrador/air-canada-mystery-baggage-1.7592756)<!-- HN:44683447:end -->
#### **Saturday, July 26, 2025**
<!-- HN:44691896:start -->
* [44691896](https://news.social-protocols.org/stats?id=44691896) #27 70 points 20 comments -> [Turn any diagram image into an editable Draw.io file. No more redrawing](https://imagetodrawio.com/)<!-- HN:44691896:end --><!-- HN:44692827:start -->
* [44692827](https://news.social-protocols.org/stats?id=44692827) #7 24 points 41 comments -> [Donate to the Treasury to help pay down the $36.7T public debt](https://www.pay.gov/public/form/start/23779454)<!-- HN:44692827:end --><!-- HN:44693528:start -->
* [44693528](https://news.social-protocols.org/stats?id=44693528) #5 -> [Thailand's F-16s and Gripens jointly bomb Cambodian indirect fire positions](https://www.nationthailand.com/news/asean/40053114)<!-- HN:44693528:end --><!-- HN:44693078:start -->
* [44693078](https://news.social-protocols.org/stats?id=44693078) #12 53 points 34 comments -> [Fuck dopamine, we're voluntarily breaking our own brains](https://anushkakarmakar.substack.com/p/35-fuck-dopamine)<!-- HN:44693078:end --><!-- HN:44694248:start -->
* [44694248](https://news.social-protocols.org/stats?id=44694248) #24 5 points 0 comments -> [The Worst ICE Agents Are Coming](https://www.thebulwark.com/p/the-worst-ice-agents-are-coming-170b-budget-hiring-training)<!-- HN:44694248:end --><!-- HN:44695159:start -->
* [44695159](https://news.social-protocols.org/stats?id=44695159) #3 29 points 9 comments -> [Is the Interstellar Object 3I/Atlas Alien Technology?](https://arxiv.org/abs/2507.12213)<!-- HN:44695159:end --><!-- HN:44695692:start -->
* [44695692](https://news.social-protocols.org/stats?id=44695692) #25 5 points 0 comments -> [Aid drops to Gaza 'inefficient and a distraction' with starvation deepening](https://www.theguardian.com/world/live/2025/jul/26/israel-gaza-war-palestinian-state-palestine-middle-east-latest-news-updates)<!-- HN:44695692:end --><!-- HN:44696922:start -->
* [44696922](https://news.social-protocols.org/stats?id=44696922) #7 4 points 2 comments -> [The Coming Age of Super Entertainment and Super Porn](https://vutran.substack.com/p/the-dopamine-machine-the-coming-age)<!-- HN:44696922:end --><!-- HN:44647134:start -->
* [44647134](https://news.social-protocols.org/stats?id=44647134) #24 4 points 0 comments -> [Why are we pretending AI is going to take all the jobs?](https://www.thebignewsletter.com/p/why-are-we-pretending-ai-is-going)<!-- HN:44647134:end --><!-- HN:44697089:start -->
* [44697089](https://news.social-protocols.org/stats?id=44697089) #9 6 points 0 comments -> [Gwyneth Paltrow Hired as Astronomer's "Spokesperson" in Wake of Kiss Cam](https://consequence.net/2025/07/gwyneth-paltrow-astronomer-video/)<!-- HN:44697089:end -->
#### **Sunday, July 27, 2025**
<!-- HN:44698750:start -->
* [44698750](https://news.social-protocols.org/stats?id=44698750) #18 5 points 1 comments -> [The Electron E1 Processor](https://www.efficient.computer/announcing-electron-e1-processor)<!-- HN:44698750:end --><!-- HN:44700173:start -->
* [44700173](https://news.social-protocols.org/stats?id=44700173) #27 7 points 0 comments -> [Has the Russian intelligence service penetrated Telegram?](https://www.perplexity.ai/search/is-there-evidence-that-suggest-FMgkZrx3SHONR2v1wSC.zg)<!-- HN:44700173:end --><!-- HN:44661402:start -->
* [44661402](https://news.social-protocols.org/stats?id=44661402) #13 13 points 3 comments -> [Base58 versus Base85 Encoding](https://www.johndcook.com/blog/2025/07/23/base58-base85/)<!-- HN:44661402:end --><!-- HN:44701579:start -->
* [44701579](https://news.social-protocols.org/stats?id=44701579) #15 36 points 7 comments -> [No](https://olu.online/no/)<!-- HN:44701579:end --><!-- HN:44664179:start -->
* [44664179](https://news.social-protocols.org/stats?id=44664179) #25 7 points 6 comments -> [Book Review: Nixon's Memoirs](https://justismills.substack.com/p/book-review-nixons-memoirs)<!-- HN:44664179:end --><!-- HN:44703613:start -->
* [44703613](https://news.social-protocols.org/stats?id=44703613) #10 22 points 2 comments -> [Tom Lehrer, song satirist and mathematician, dies at 97](https://apnews.com/article/tom-lehrer-son-satirist-mathematician-dies-9caa7ee01faf4fbfb793d7ba984c179d)<!-- HN:44703613:end --><!-- HN:44704052:start -->
* [44704052](https://news.social-protocols.org/stats?id=44704052) #14 4 points 1 comments -> [Boston Dynamics' Atlas does backflips (lesson and breakdown)](https://app.vidyaarthi.ai/ai-tutor?session_id=2YBSyF3WNzMNn_80jygEp&action=replay&shared=true)<!-- HN:44704052:end --><!-- HN:44704989:start -->
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
* [44725437](https://news.social-protocols.org/stats?id=44725437) #20 14 points 0 comments -> [UK to recognise Palestinian state in September unless Israel accepts ceasefire](https://www.theguardian.com/politics/2025/jul/29/uk-to-recognise-state-of-palestine-in-september-unless-israel-holds-to-a-ceasefire)<!-- HN:44725437:end -->