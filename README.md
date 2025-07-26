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

#### **Sunday, July 20, 2025**<!-- HN:44617910:start -->
* [44617910](https://news.social-protocols.org/stats?id=44617910) #21 153 points 16 comments -> [MCP Security Vulnerabilities and Attack Vectors](https://forgecode.dev/blog/prevent-attacks-on-mcp/)<!-- HN:44617910:end --><!-- HN:44591332:start -->
* [44591332](https://news.social-protocols.org/stats?id=44591332) #13 9 points 1 comments -> [C++ Trailing Return Types (2022)](https://danielsieger.com/blog/2022/01/28/cpp-trailing-return-types.html)<!-- HN:44591332:end --><!-- HN:44622725:start -->
* [44622725](https://news.social-protocols.org/stats?id=44622725) #19 16 points 3 comments -> [Replit goes rogue and deletes our entire database](https://twitter.com/jasonlk/status/1946069562723897802)<!-- HN:44622725:end --><!-- HN:44623801:start -->
* [44623801](https://news.social-protocols.org/stats?id=44623801) #6 3 points 1 comments -> [Genesis Protocol: The first communication protocol for digital life](https://genesis-protocol.org/)<!-- HN:44623801:end --><!-- HN:44622382:start -->
* [44622382](https://news.social-protocols.org/stats?id=44622382) #19 18 points 40 comments -> [Will the Fear of Being Confused for AI Mean That We Will Now Write Differently?](https://3quarksdaily.com/3quarksdaily/2025/06/will-the-fear-of-being-confused-for-ai-mean-that-we-will-now-write-differently.html)<!-- HN:44622382:end --><!-- HN:44625897:start -->
* [44625897](https://news.social-protocols.org/stats?id=44625897) #7 8 points 8 comments -> [When is it the best time to post on Show HN?](https://www.myriade.ai/blogs/when-is-it-the-best-time-to-post-on-show-hn)<!-- HN:44625897:end --><!-- HN:44627749:start -->
* [44627749](https://news.social-protocols.org/stats?id=44627749) #14 7 points 5 comments -> [The great AI delusion is falling apart](https://www.telegraph.co.uk/business/2025/07/14/the-great-ai-delusion-is-built-on-self-deception/)<!-- HN:44627749:end --><!-- HN:44628290:start -->
* [44628290](https://news.social-protocols.org/stats?id=44628290) #9 26 points 4 comments -> [Is DeepSeek a New Voice Among LLMs in Public Opinion Simulation?](https://arxiv.org/abs/2506.21587)<!-- HN:44628290:end --><!-- HN:44628973:start -->
* [44628973](https://news.social-protocols.org/stats?id=44628973) #24 8 points 1 comments -> [He Had Dangerous Delusions. ChatGPT Admitted It Made Them Worse](https://www.wsj.com/tech/ai/chatgpt-chatbot-psychology-manic-episodes-57452d14)<!-- HN:44628973:end --><!-- HN:44629166:start -->
* [44629166](https://news.social-protocols.org/stats?id=44629166) #25 4 points 0 comments -> [Israeli fire kills 67 people seeking aid in Gaza](https://www.reuters.com/world/middle-east/israeli-fire-kills-67-people-seeking-aid-gaza-medics-say-hunger-worsens-2025-07-20/)<!-- HN:44629166:end --><!-- HN:44628060:start -->
* [44628060](https://news.social-protocols.org/stats?id=44628060) #30 39 points 9 comments -> [Allentown man said to have died in ICE custody is alive in Guatemala](https://www.mcall.com/2025/07/18/luis-leon-allentown-grandfather-ice-guatemala/)<!-- HN:44628060:end --><!-- HN:44629349:start -->
* [44629349](https://news.social-protocols.org/stats?id=44629349) #8 -> [Show HN: A tool that generates nice photos for guys who dislike posing for pics](https://vibeflirting.com)<!-- HN:44629349:end --><!-- HN:44630075:start -->
* [44630075](https://news.social-protocols.org/stats?id=44630075) #27 12 points 1 comments -> [OpenAI Ignored IMO Request, Announced Math Results Before Closing Ceremony](https://twitter.com/mihonarium/status/1946880931723194389)<!-- HN:44630075:end -->
#### **Monday, July 21, 2025**
<!-- HN:44630872:start -->
* [44630872](https://news.social-protocols.org/stats?id=44630872) #26 6 points 1 comments -> [Europe has more heat deaths per year than the United States loses to gun deaths](https://www.perplexity.ai/search/europe-has-more-heat-deaths-pe-BDS6xdorS4.4x2WrCC9mAQ)<!-- HN:44630872:end --><!-- HN:44631053:start -->
* [44631053](https://news.social-protocols.org/stats?id=44631053) #9 3 points 5 comments -> [Hi guys, any thought on this project?](https://founder-hub-waitlist.vercel.app/)<!-- HN:44631053:end --><!-- HN:44631091:start -->
* [44631091](https://news.social-protocols.org/stats?id=44631091) #17 4 points 1 comments -> [HTTP/1.1 Must Die – The Desync Endgame Begins](https://http1mustdie.com/)<!-- HN:44631091:end --><!-- HN:44632575:start -->
* [44632575](https://news.social-protocols.org/stats?id=44632575) #21 86 points 41 comments -> [Vibe coding service Replit deleted production database, faked data, told fibs](https://www.theregister.com/2025/07/21/replit_saastr_vibe_coding_incident/)<!-- HN:44632575:end --><!-- HN:44633228:start -->
* [44633228](https://news.social-protocols.org/stats?id=44633228) #12 9 points 4 comments -> [The Missing Guide to Prompt Engineering](https://appetals.com/promptguide/)<!-- HN:44633228:end --><!-- HN:44633902:start -->
* [44633902](https://news.social-protocols.org/stats?id=44633902) #17 26 points 41 comments -> [France launches criminal probe of X over alleged algorithm 'manipulation' X says](https://www.ft.com/content/21818d23-71d7-45a4-ae8c-e7940f5d9e00)<!-- HN:44633902:end --><!-- HN:44634373:start -->
* [44634373](https://news.social-protocols.org/stats?id=44634373) #2 8 points 2 comments -> [HTTP/1.1 Must Die](https://http1mustdie.com/)<!-- HN:44634373:end --><!-- HN:44634664:start -->
* [44634664](https://news.social-protocols.org/stats?id=44634664) #2 8 points 1 comments -> [Coldplayed: A New Verb Is Born After Viral Coldplay Concert Scandal](https://suntechpulse.com/coldplayed-a-new-verb-is-born-after-viral-coldplay-concert-scandal/)<!-- HN:44634664:end --><!-- HN:44630815:start -->
* [44630815](https://news.social-protocols.org/stats?id=44630815) #29 75 points 49 comments -> [Claude jailbroken to mint unlimited Stripe coupons](https://www.generalanalysis.com/blog/imessage-stripe-exploit)<!-- HN:44630815:end --><!-- HN:44635324:start -->
* [44635324](https://news.social-protocols.org/stats?id=44635324) #1 -> [The €43B EU CHIPS Act gets green light. – TechHQ](https://techhq.com/news/the-e43-billion-eu-chips-act-gets-green-light-from-european-nations-whats-next/)<!-- HN:44635324:end --><!-- HN:44634734:start -->
* [44634734](https://news.social-protocols.org/stats?id=44634734) #23 35 points 40 comments -> [Cryptocurrency exchanges begin offering tokenized securities](https://apnews.com/article/crypto-robinhood-openai-tokenization-sec-bfd41220717fe9b6ebcd0305005e0018)<!-- HN:44634734:end --><!-- HN:44640005:start -->
* [44640005](https://news.social-protocols.org/stats?id=44640005) #9 24 points 41 comments -> [The special hell of Bolt, Europe's Uber clone](https://brandur.org/fragments/special-hell-of-bolt-app)<!-- HN:44640005:end --><!-- HN:44639949:start -->
* [44639949](https://news.social-protocols.org/stats?id=44639949) #14 20 points 7 comments -> [Africa's gigantic $80B dam could transform entire continent](https://en.clickpetroleoegas.com.br/maior-que-a-barragem-tres-gargantas-da-china-o-gigantesco-megaprojeto-africano-de-us-80-bilhoes-que-pode-revolucionar-a-energia-e-transformar-um-continente-inteiro/)<!-- HN:44639949:end --><!-- HN:44641173:start -->
* [44641173](https://news.social-protocols.org/stats?id=44641173) #22 4 points 0 comments -> [Sexual Offender or Not?](https://facecrime.io/)<!-- HN:44641173:end -->
#### **Tuesday, July 22, 2025**
<!-- HN:44641363:start -->
* [44641363](https://news.social-protocols.org/stats?id=44641363) #29 30 points 15 comments -> [How to break the 'AI hype cycle'](https://mitsloan.mit.edu/ideas-made-to-matter/how-to-break-ai-hype-cycle-and-make-good-ai-decisions-your-organization)<!-- HN:44641363:end --><!-- HN:44607125:start -->
* [44607125](https://news.social-protocols.org/stats?id=44607125) #12 12 points 12 comments -> [He Rewrote Everything in Rust – Then We Got Fired](https://medium.com/@ThreadSafeDiaries/he-rewrote-everything-in-rust-then-we-got-fired-293e3e16c2d3)<!-- HN:44607125:end --><!-- HN:44644428:start -->
* [44644428](https://news.social-protocols.org/stats?id=44644428) #21 3 points 0 comments -> [Raft Consensus Algorithms](https://blog.outlandish.claims/p/raft-consensus-algorithms)<!-- HN:44644428:end --><!-- HN:44649713:start -->
* [44649713](https://news.social-protocols.org/stats?id=44649713) #9 7 points 0 comments -> [The Case for Sabotage](https://collectiveactionintech.substack.com/p/the-case-for-sabotage)<!-- HN:44649713:end --><!-- HN:44651041:start -->
* [44651041](https://news.social-protocols.org/stats?id=44651041) #30 9 points 0 comments -> [AFP's last journalists in Gaza are starving to death](https://twitter.com/SDJ_AFP/status/1947609875183215005)<!-- HN:44651041:end -->
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
* [44693078](https://news.social-protocols.org/stats?id=44693078) #12 53 points 34 comments -> [Fuck dopamine, we're voluntarily breaking our own brains](https://anushkakarmakar.substack.com/p/35-fuck-dopamine)<!-- HN:44693078:end -->