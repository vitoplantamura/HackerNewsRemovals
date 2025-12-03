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

#### **Thursday, November 27, 2025**
<!-- HN:46062483:start -->
* [46062483](https://news.social-protocols.org/stats?id=46062483) #20 98 points 92 comments -> [AirDrop support for Pixel 10 likely exists because of the EU ruling](https://9to5google.com/2025/11/21/googles-airdrop-support-for-pixel-10-likely-exists-because-of-the-eus-apple-ruling/)<!-- HN:46062483:end --><!-- HN:46064998:start -->
* [46064998](https://news.social-protocols.org/stats?id=46064998) #25 3 points 1 comments -> [Vibe coding: What is it good for? Absolutely nothing](https://www.theregister.com/2025/11/24/opinion_column_vibe_coding/)<!-- HN:46064998:end --><!-- HN:46068314:start -->
* [46068314](https://news.social-protocols.org/stats?id=46068314) #5 5 points 1 comments -> [Why (Senior) Engineers Struggle to Build AI Agents](https://www.philschmid.de/why-engineers-struggle-building-agents)<!-- HN:46068314:end --><!-- HN:46069743:start -->
* [46069743](https://news.social-protocols.org/stats?id=46069743) #8 32 points 19 comments -> [Don't be a scary old guy: My 40s survival strategy with charm](https://www.devas.life/dont-be-a-scary-old-guy-my-40s-survival-strategy-with-charm/)<!-- HN:46069743:end --><!-- HN:46069919:start -->
* [46069919](https://news.social-protocols.org/stats?id=46069919) #2 11 points 4 comments -> [What Happens When You Train Pure Logic Without Knowledge: 15-Expert Moe](https://github.com/vac-architector/VAC-Memory-System/blob/main/LOGICA_MOE_STORY.md)<!-- HN:46069919:end --><!-- HN:46070597:start -->
* [46070597](https://news.social-protocols.org/stats?id=46070597) #21 5 points 1 comments -> [Face transplants promised hope. Patients were put through the unthinkable](https://www.theguardian.com/science/2025/nov/27/face-transplant-patients-results-outcomes)<!-- HN:46070597:end --><!-- HN:46070842:start -->
* [46070842](https://news.social-protocols.org/stats?id=46070842) #10 5 points 3 comments -> [It's Been a Very Hard Year](https://bell.bz/its-been-a-very-hard-year/)<!-- HN:46070842:end --><!-- HN:46073862:start -->
* [46073862](https://news.social-protocols.org/stats?id=46073862) #6 12 points 3 comments -> [Show HN: Whole-home VPN router with hardware kill switch (OpenWrt and WireGuard)](https://github.com/yoloshii/privacy-first-network)<!-- HN:46073862:end --><!-- HN:46073319:start -->
* [46073319](https://news.social-protocols.org/stats?id=46073319) #25 6 points 1 comments -> [Show HN: No Black Friday – A directory of fair-price brands](https://no-blackfriday.com)<!-- HN:46073319:end -->
#### **Friday, November 28, 2025**
<!-- HN:46036124:start -->
* [46036124](https://news.social-protocols.org/stats?id=46036124) #17 8 points 0 comments -> [Modelling Agent Systems with Erlang (2004) [pdf]](https://erlang.org/workshop/2004/carlosvarela.pdf)<!-- HN:46036124:end --><!-- HN:46075575:start -->
* [46075575](https://news.social-protocols.org/stats?id=46075575) #25 8 points 2 comments -> [Andrew Kelley removed his "monkeys" and "losers" references](https://web.archive.org/web/20251127021007/https://ziglang.org/news/migrating-from-github-to-codeberg/)<!-- HN:46075575:end --><!-- HN:46074729:start -->
* [46074729](https://news.social-protocols.org/stats?id=46074729) #24 10 points 7 comments -> [Overlord: AI accountability that watches over you](https://overlord.app/)<!-- HN:46074729:end --><!-- HN:46080131:start -->
* [46080131](https://news.social-protocols.org/stats?id=46080131) #21 12 points 0 comments -> [The Pro-Israel Information War](https://www.leefang.com/p/inside-the-pro-israel-information)<!-- HN:46080131:end --><!-- HN:46027104:start -->
* [46027104](https://news.social-protocols.org/stats?id=46027104) #24 16 points 4 comments -> [NSA and IETF, Part 2](https://blog.cr.yp.to/20251123-corruption.html)<!-- HN:46027104:end --><!-- HN:46080381:start -->
* [46080381](https://news.social-protocols.org/stats?id=46080381) #30 11 points 5 comments -> [200 Lines of Python beats $50M supercomputer – Navier-Stokes at Re=10⁸ [pdf]](https://philpapers.org/archive/CAMIIA-3.pdf)<!-- HN:46080381:end --><!-- HN:46079975:start -->
* [46079975](https://news.social-protocols.org/stats?id=46079975) #15 11 points 1 comments -> [Artificial Computation](https://cultureandcommunication.org/galloway/artificial-computation)<!-- HN:46079975:end --><!-- HN:46081956:start -->
* [46081956](https://news.social-protocols.org/stats?id=46081956) #6 20 points 5 comments -> [The Google Trends Spike Before the D.C. Shooting Raises New Questions](https://www.allenanalysis.com/p/the-google-trends-spike-before-the)<!-- HN:46081956:end -->
#### **Saturday, November 29, 2025**<!-- HN:46048327:start -->
* [46048327](https://news.social-protocols.org/stats?id=46048327) #28 9 points 6 comments -> [DJI ROMO robot vacuum [video]](https://www.youtube.com/watch?v=Iv7BYURURRI)<!-- HN:46048327:end --><!-- HN:46083730:start -->
* [46083730](https://news.social-protocols.org/stats?id=46083730) #10 20 points 40 comments -> [The Fatal Trap UBI Boosters Keep Falling Into](https://thereader.mitpress.mit.edu/the-fatal-trap-ubi-boosters-keep-falling-into/)<!-- HN:46083730:end --><!-- HN:46083137:start -->
* [46083137](https://news.social-protocols.org/stats?id=46083137) #18 30 points 40 comments -> [How to Short the Bubbliest Firms](https://www.economist.com/finance-and-economics/2025/11/26/how-to-short-the-bubbliest-firms)<!-- HN:46083137:end --><!-- HN:46084271:start -->
* [46084271](https://news.social-protocols.org/stats?id=46084271) #25 12 points 4 comments -> [Google CEO Pushes 'Vibe Coding' – But Real Developers Know It's Not Magic](https://www.interviewquery.com/p/ai-coding-vibe-coding-explained)<!-- HN:46084271:end --><!-- HN:46086646:start -->
* [46086646](https://news.social-protocols.org/stats?id=46086646) #2 9 points 1 comments -> [UN panel says Israel operating 'de facto policy of torture'](https://www.bbc.com/news/articles/ckglrdg6kz7o)<!-- HN:46086646:end --><!-- HN:46087541:start -->
* [46087541](https://news.social-protocols.org/stats?id=46087541) #2 6 points 0 comments -> [Sally Rooney books may be withdrawn from UK sale over Palestine Action ban](https://www.bbc.com/news/articles/cm20ldz0g9ro)<!-- HN:46087541:end --><!-- HN:46087520:start -->
* [46087520](https://news.social-protocols.org/stats?id=46087520) #29 17 points 8 comments -> [Quebec to ban public prayer in sweeping new secularism law](https://www.theguardian.com/world/2025/nov/28/quebec-prayer-law-canada)<!-- HN:46087520:end --><!-- HN:46088080:start -->
* [46088080](https://news.social-protocols.org/stats?id=46088080) #29 -> [Israel has 'de facto state policy' of organised torture, says UN report](https://www.theguardian.com/world/2025/nov/29/israel-has-de-facto-state-policy-of-organised-torture-says-un-report)<!-- HN:46088080:end --><!-- HN:46089579:start -->
* [46089579](https://news.social-protocols.org/stats?id=46089579) #18 50 points 1 comments -> [An Update on the Farphone's Battery](https://far.computer/battery-update/)<!-- HN:46089579:end --><!-- HN:46090738:start -->
* [46090738](https://news.social-protocols.org/stats?id=46090738) #11 4 points 3 comments -> [US War Dept's Big UFO Lie](https://www.overcomingbias.com/p/us-war-depts-big-ufo-lie)<!-- HN:46090738:end --><!-- HN:46091100:start -->
* [46091100](https://news.social-protocols.org/stats?id=46091100) #27 20 points 40 comments -> [Copper Thieves Are Wreaking Havoc Across America](https://www.wsj.com/business/telecom/copper-thieves-are-wreaking-havoc-across-america-9135906f)<!-- HN:46091100:end -->
#### **Sunday, November 30, 2025**<!-- HN:46093458:start -->
* [46093458](https://news.social-protocols.org/stats?id=46093458) #9 7 points 7 comments -> [MIT Report Claims 11.7% of U.S. Labor Can Be Replaced with Existing AI](https://iceberg.mit.edu/)<!-- HN:46093458:end --><!-- HN:46095521:start -->
* [46095521](https://news.social-protocols.org/stats?id=46095521) #2 14 points 2 comments -> [Austria's armed forces rely on LibreOffice instead of Microsoft](https://oe1.orf.at/programm/20250916/807304/Freie-Software-fuer-das-Bundesheer)<!-- HN:46095521:end --><!-- HN:46094465:start -->
* [46094465](https://news.social-protocols.org/stats?id=46094465) #25 37 points 23 comments -> [The Copenhagen Trap: How the West made passivity the only safe strategy](https://aliveness.kunnas.com/articles/copenhagen-trap)<!-- HN:46094465:end --><!-- HN:46096312:start -->
* [46096312](https://news.social-protocols.org/stats?id=46096312) #2 13 points 1 comments -> [OpenBSD: Free, Functional, and Secure](https://www.openbsd.org/)<!-- HN:46096312:end --><!-- HN:46097992:start -->
* [46097992](https://news.social-protocols.org/stats?id=46097992) #30 8 points 9 comments -> [Google CEO says ‘vibe coding’ made software development ‘so much more enjoyable’](https://www.google.com/url?q=https://indianexpress.com/article/technology/tech-news-technology/google-ceo-sundar-pichai-says-vibe-coding-has-made-software-development-so-much-more-enjoyable-10393752/)<!-- HN:46097992:end --><!-- HN:46097609:start -->
* [46097609](https://news.social-protocols.org/stats?id=46097609) #9 32 points 40 comments -> [Atlas Shrugged](https://david-jasso.com/2024/04/11/atlas-shrugged/)<!-- HN:46097609:end --><!-- HN:46098436:start -->
* [46098436](https://news.social-protocols.org/stats?id=46098436) #29 6 points 1 comments -> [Keep these Stupid American Trucks out of Europe [video]](https://youtu.be/--832LV9a3I)<!-- HN:46098436:end --><!-- HN:46100637:start -->
* [46100637](https://news.social-protocols.org/stats?id=46100637) #4 69 points 9 comments -> [Ty](https://docs.astral.sh/ty/)<!-- HN:46100637:end -->
#### **Monday, December 1, 2025**
<!-- HN:46053787:start -->
* [46053787](https://news.social-protocols.org/stats?id=46053787) #24 26 points 6 comments -> [The myth of reflected power (2017)](https://www.iz2uuf.net/wp/index.php/2017/07/29/the-myth-of-reflected-power/)<!-- HN:46053787:end --><!-- HN:46100566:start -->
* [46100566](https://news.social-protocols.org/stats?id=46100566) #14 24 points 40 comments -> [Stackoverflow Outage](https://www.stackstatus.net/)<!-- HN:46100566:end --><!-- HN:46101949:start -->
* [46101949](https://news.social-protocols.org/stats?id=46101949) #27 75 points 61 comments -> [Grokipedia Is the Antithesis of Wikipedia](https://www.404media.co/grokipedia-is-the-antithesis-of-everything-that-makes-wikipedia-good-useful-and-human/)<!-- HN:46101949:end --><!-- HN:46102267:start -->
* [46102267](https://news.social-protocols.org/stats?id=46102267) #30 7 points 0 comments -> [Stopping evil and open source: thoughts](https://blog.liw.fi/posts/2025/stop-evil/)<!-- HN:46102267:end --><!-- HN:46103811:start -->
* [46103811](https://news.social-protocols.org/stats?id=46103811) #2 42 points 8 comments -> [Google Antigravity Deletes D Drive](https://mastodon.gamedev.place/@bastardsheep@aus.social/115641546248437052)<!-- HN:46103811:end --><!-- HN:46105896:start -->
* [46105896](https://news.social-protocols.org/stats?id=46105896) #14 19 points 12 comments -> [Why Is ChatGPT for Mac So Good?](https://allenpike.com/2025/why-is-chatgpt-so-good-claude)<!-- HN:46105896:end --><!-- HN:46106629:start -->
* [46106629](https://news.social-protocols.org/stats?id=46106629) #12 14 points 2 comments -> [WW1 toxic compound sprayed on Georgian protesters, BBC evidence suggests](https://www.bbc.com/news/articles/czrk7g50e1po)<!-- HN:46106629:end --><!-- HN:46108892:start -->
* [46108892](https://news.social-protocols.org/stats?id=46108892) #12 15 points 11 comments -> [Show HN: I built a 1.8MB native app with self-built UI, vision and AI libraries](https://github.com/Okery/Aivition)<!-- HN:46108892:end --><!-- HN:46039140:start -->
* [46039140](https://news.social-protocols.org/stats?id=46039140) #7 159 points 84 comments -> [Isn't WSL2 just a VM?](https://ssg.dev/isnt-wsl2-just-a-vm/)<!-- HN:46039140:end --><!-- HN:46039594:start -->
* [46039594](https://news.social-protocols.org/stats?id=46039594) #21 119 points 57 comments -> [I made a quieter air purifier](https://chillphysicsenjoyer.substack.com/p/i-made-a-quieter-air-purifier)<!-- HN:46039594:end --><!-- HN:46040623:start -->
* [46040623](https://news.social-protocols.org/stats?id=46040623) #23 30 points 38 comments -> [How we built the v0 iOS app](https://vercel.com/blog/how-we-built-the-v0-ios-app)<!-- HN:46040623:end --><!-- HN:46056700:start -->
* [46056700](https://news.social-protocols.org/stats?id=46056700) #15 7 points 1 comments -> [Genesis DB is a event sourcing database and there are the technical insights](https://docs.genesisdb.io/technical-insights)<!-- HN:46056700:end -->
#### **Tuesday, December 2, 2025**
<!-- HN:46115608:start -->
* [46115608](https://news.social-protocols.org/stats?id=46115608) #10 3 points 1 comments -> [Artisanal Coding Is Dead, Long Live Artisanal Coding](https://joel.id/artisanal-coding-is-dead-long-live-artisanal-coding/)<!-- HN:46115608:end --><!-- HN:46112906:start -->
* [46112906](https://news.social-protocols.org/stats?id=46112906) #1 314 points 151 comments -> ["How to Attend Meetings" – Internal Guidelines from the New York Times](https://docs.google.com/presentation/d/1l7s1aAsNPlNhSye8OsMqmH6pMR32OYGGdLT6VKyFaQE/edit#slide=id.p)<!-- HN:46112906:end --><!-- HN:46058980:start -->
* [46058980](https://news.social-protocols.org/stats?id=46058980) #20 6 points 1 comments -> [Myths of Fleming's Penicillin Discovery](https://press.asimov.com/articles/penicillin-myth)<!-- HN:46058980:end --><!-- HN:46118195:start -->
* [46118195](https://news.social-protocols.org/stats?id=46118195) #9 7 points 4 comments -> [Beej's Guide to C Programming](https://beej.us/guide/bgc/)<!-- HN:46118195:end --><!-- HN:46117280:start -->
* [46117280](https://news.social-protocols.org/stats?id=46117280) #2 147 points 22 comments -> [Beej's Guide to Learning Computer Science](https://beej.us/guide/bglcs/html/split/)<!-- HN:46117280:end --><!-- HN:46120728:start -->
* [46120728](https://news.social-protocols.org/stats?id=46120728) #18 32 points 40 comments -> [Gary Tan claims Zoho will be out of business due to vibe coding](https://twitter.com/garrytan/status/1995664097007091818)<!-- HN:46120728:end --><!-- HN:46123469:start -->
* [46123469](https://news.social-protocols.org/stats?id=46123469) #5 15 points 3 comments -> [API GitHub Meta](https://api.github.com/meta)<!-- HN:46123469:end --><!-- HN:46086587:start -->
* [46086587](https://news.social-protocols.org/stats?id=46086587) #21 5 points 8 comments -> [Free Nano Banana Pro](https://www.freenanobanana.app)<!-- HN:46086587:end --><!-- HN:46088823:start -->
* [46088823](https://news.social-protocols.org/stats?id=46088823) #23 7 points 3 comments -> [Show HN: Rhubarb – C89 Libraries in Latin](https://github.com/farant/rhubarb)<!-- HN:46088823:end -->
#### **Wednesday, December 3, 2025**
<!-- HN:46135784:start -->
* [46135784](https://news.social-protocols.org/stats?id=46135784) #17 40 points 4 comments -> [Critical Security Vulnerability in React Server Components](https://react.dev/blog/2025/12/03/critical-security-vulnerability-in-react-server-components)<!-- HN:46135784:end -->