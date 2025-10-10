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

#### **Saturday, October 4, 2025**<!-- HN:45476347:start -->
* [45476347](https://news.social-protocols.org/stats?id=45476347) #25 4 points 6 comments -> [Designers Should Look to Demis Hassabis. Not Jony Ive](https://www.suffsyed.com/futurememo/designers-should-look-to-demis-hassabis-not-jony-ive)<!-- HN:45476347:end -->
#### **Sunday, October 5, 2025**
<!-- HN:45477215:start -->
* [45477215](https://news.social-protocols.org/stats?id=45477215) #6 22 points 7 comments -> [How do drivers react to partisan bumper stickers?](https://www.frontiersin.org/articles/10.3389/fpos.2025.1617785)<!-- HN:45477215:end --><!-- HN:45477898:start -->
* [45477898](https://news.social-protocols.org/stats?id=45477898) #24 6 points 0 comments -> [How ICE Is Using Your Data – and What You Can Do About It](https://www.kqed.org/news/12055606/how-ice-is-using-your-data-and-what-you-can-do-about-it)<!-- HN:45477898:end --><!-- HN:45477700:start -->
* [45477700](https://news.social-protocols.org/stats?id=45477700) #8 15 points 1 comments -> [Probiotics Finder](https://www.probioticfinder.org/)<!-- HN:45477700:end --><!-- HN:45447307:start -->
* [45447307](https://news.social-protocols.org/stats?id=45447307) #17 19 points 17 comments -> [One Battle After Another: PTA and the Death of Revolutionary Cinema](https://letterboxd.com/markcira/film/one-battle-after-another/2/)<!-- HN:45447307:end --><!-- HN:45478585:start -->
* [45478585](https://news.social-protocols.org/stats?id=45478585) #11 4 points 3 comments -> [Show HN: URI-Transformer: AI architecture that models meaning. 99.9% less memory](https://github.com/BruinGrowly/URI_Transformer)<!-- HN:45478585:end --><!-- HN:45478931:start -->
* [45478931](https://news.social-protocols.org/stats?id=45478931) #4 14 points 10 comments -> [Scientists debunk claims of seed oil health risks](https://hsph.harvard.edu/news/scientists-debunk-seed-oil-health-risks/)<!-- HN:45478931:end --><!-- HN:45448525:start -->
* [45448525](https://news.social-protocols.org/stats?id=45448525) #17 35 points 13 comments -> [Show HN: The Little Book of C](https://github.com/little-book-of/c)<!-- HN:45448525:end --><!-- HN:45450918:start -->
* [45450918](https://news.social-protocols.org/stats?id=45450918) #25 6 points 5 comments -> [Skills I Was Missing as a MongoDB User](https://www.mongodb.com/company/blog/technical/10-skills-was-missing-as-mongodb-user)<!-- HN:45450918:end --><!-- HN:45482394:start -->
* [45482394](https://news.social-protocols.org/stats?id=45482394) #13 20 points 42 comments -> [Westjet is going to make you pay to recline your seat](https://www.thestreet.com/travel/a-major-airline-is-going-to-make-you-pay-to-recline-your-seat)<!-- HN:45482394:end --><!-- HN:45483664:start -->
* [45483664](https://news.social-protocols.org/stats?id=45483664) #1 8 points 0 comments -> [Jamal Khashoggi, the Washington Post, and the Cost of Speaking Out](https://karenattiah.substack.com/p/jamal-khashoggi-the-washington-post)<!-- HN:45483664:end -->
#### **Monday, October 6, 2025**
<!-- HN:45486855:start -->
* [45486855](https://news.social-protocols.org/stats?id=45486855) #4 13 points 2 comments -> [A selfie with Netanyahu turns into an employee and customer exodus](https://www.hardresetmedia.com/p/a-selfie-with-netanyahu-turns-into)<!-- HN:45486855:end --><!-- HN:45448204:start -->
* [45448204](https://news.social-protocols.org/stats?id=45448204) #26 13 points 1 comments -> [AMD's EPYC 9355P: Inside a 32 Core Zen 5 Server Chip](https://chipsandcheese.com/p/amds-epyc-9355p-inside-a-32-core)<!-- HN:45448204:end --><!-- HN:45487052:start -->
* [45487052](https://news.social-protocols.org/stats?id=45487052) #23 6 points 0 comments -> [Gazans Have a Message for Hamas: End the War Now](https://www.wsj.com/world/middle-east/gazans-have-a-message-for-hamas-end-the-war-now-ec769626)<!-- HN:45487052:end --><!-- HN:45452721:start -->
* [45452721](https://news.social-protocols.org/stats?id=45452721) #24 4 points 6 comments -> [The Internet Is Better on Comet](https://www.perplexity.ai/hub/blog/comet-is-now-available-to-everyone-worldwide)<!-- HN:45452721:end --><!-- HN:45487531:start -->
* [45487531](https://news.social-protocols.org/stats?id=45487531) #12 13 points 0 comments -> [Michigan Anti-Porn Bill Criminalizes ASMR, Erotica, Depictions of Trans People](https://reason.com/2025/09/22/michigan-anti-porn-bill-would-criminalize-asmr-written-erotica-and-even-nonsexual-depictions-of-trans-people/)<!-- HN:45487531:end --><!-- HN:45488492:start -->
* [45488492](https://news.social-protocols.org/stats?id=45488492) #26 11 points 1 comments -> [A 'magic pill' made Israeli violence invisible. We need to stop swallowing it](https://www.theguardian.com/world/ng-interactive/2025/oct/05/gaza-palestine-israel-trump-peace-plan)<!-- HN:45488492:end --><!-- HN:45489657:start -->
* [45489657](https://news.social-protocols.org/stats?id=45489657) #13 8 points 0 comments -> [The Zionist Occupation of Open Source](https://moneo.com.tr/blog/the-zionist-occupation-of-open-source)<!-- HN:45489657:end --><!-- HN:45460307:start -->
* [45460307](https://news.social-protocols.org/stats?id=45460307) #15 14 points 12 comments -> [Protecting your (my) passport from liquid damage](https://blog.jgc.org/2025/10/protecting-your-my-passport-from-liquid.html)<!-- HN:45460307:end --><!-- HN:45489951:start -->
* [45489951](https://news.social-protocols.org/stats?id=45489951) #13 30 points 40 comments -> [The (economic) AI apocalypse is nigh](https://pluralistic.net/2025/09/27/econopocalypse/#subprime-intelligence)<!-- HN:45489951:end --><!-- HN:45490472:start -->
* [45490472](https://news.social-protocols.org/stats?id=45490472) #21 14 points 17 comments -> [French PM Lecornu resigns hours after forming cabinet](https://www.lemonde.fr/en/france/article/2025/10/06/french-pm-lecornu-resigns-hours-after-naming-government_6746132_7.html)<!-- HN:45490472:end --><!-- HN:45489978:start -->
* [45489978](https://news.social-protocols.org/stats?id=45489978) #23 69 points 18 comments -> [State Terror, American Style – Paul Krugman](https://paulkrugman.substack.com/p/state-terror-american-style)<!-- HN:45489978:end --><!-- HN:45490825:start -->
* [45490825](https://news.social-protocols.org/stats?id=45490825) #25 7 points 2 comments -> [Generation X may be the first to need a universal basic income](https://thehill.com/opinion/finance/5538292-gen-x-job-security-ai/)<!-- HN:45490825:end --><!-- HN:45491340:start -->
* [45491340](https://news.social-protocols.org/stats?id=45491340) #20 -> [ICE Targets Children with Payment in Exchange for Deportation](https://theintercept.com/2025/10/03/ice-children-deportation-payment/)<!-- HN:45491340:end --><!-- HN:45491273:start -->
* [45491273](https://news.social-protocols.org/stats?id=45491273) #8 6 points 2 comments -> [Wafflegate](https://aeryn.me/wafflegate/)<!-- HN:45491273:end --><!-- HN:45492410:start -->
* [45492410](https://news.social-protocols.org/stats?id=45492410) #24 97 points 43 comments -> [Apple's Unlawful Evil](https://pluralistic.net/2025/10/06/rogue-capitalism/#orphaned-syrian-refugees-need-not-apply)<!-- HN:45492410:end --><!-- HN:45490703:start -->
* [45490703](https://news.social-protocols.org/stats?id=45490703) #12 20 points 18 comments -> [AI has found 50 bugs in cURL. "AI-native SASTs work well"](https://etn.se/72494)<!-- HN:45490703:end --><!-- HN:45494592:start -->
* [45494592](https://news.social-protocols.org/stats?id=45494592) #8 28 points 1 comments -> [OpenZL: A Novel Data Compression Framework](https://github.com/facebook/openzl)<!-- HN:45494592:end -->
#### **Tuesday, October 7, 2025**
<!-- HN:45497893:start -->
* [45497893](https://news.social-protocols.org/stats?id=45497893) #1 54 points 3 comments -> [Microsoft are removing mechanisms for creating a local account in Windows Setup](https://blogs.windows.com/windows-insider/2025/10/06/announcing-windows-11-insider-preview-build-26120-6772-beta-channel/)<!-- HN:45497893:end --><!-- HN:45467078:start -->
* [45467078](https://news.social-protocols.org/stats?id=45467078) #14 19 points 8 comments -> [Grafana Labs made a Taylor Swift dashboard](https://grafana.com/blog/2025/10/03/taylor-swift-grafanas-version-how-to-track-and-visualize-data-related-to-pop-s-biggest-superstar/)<!-- HN:45467078:end --><!-- HN:45501099:start -->
* [45501099](https://news.social-protocols.org/stats?id=45501099) #2 19 points 8 comments -> [Redis CVE-2025-49844: Use-After-Free may lead to remote code execution](https://redis.io/blog/security-advisory-cve-2025-49844/)<!-- HN:45501099:end --><!-- HN:45501514:start -->
* [45501514](https://news.social-protocols.org/stats?id=45501514) #4 9 points 6 comments -> [Polish scientists' startup Pathway announces AI reasoning breakthrough](https://www.polskieradio.pl/395/7784/artykul/3588855,polish-scientists-startup-pathway-announces-ai-reasoning-breakthrough)<!-- HN:45501514:end --><!-- HN:45501459:start -->
* [45501459](https://news.social-protocols.org/stats?id=45501459) #12 66 points 24 comments -> [MacBook Lid Angle Sensor](https://github.com/samhenrigold/LidAngleSensor)<!-- HN:45501459:end --><!-- HN:45503028:start -->
* [45503028](https://news.social-protocols.org/stats?id=45503028) #5 14 points 2 comments -> [Eating capitalism: How our food got hijacked by profits](https://hi-im-ada.beehiiv.com/p/7-eating-capitalism)<!-- HN:45503028:end --><!-- HN:45503960:start -->
* [45503960](https://news.social-protocols.org/stats?id=45503960) #5 39 points 29 comments -> [Nearly 20 Percent Fewer International Students Traveled to the U.S. in August](https://www.nytimes.com/interactive/2025/10/06/upshot/us-international-student-travel.html)<!-- HN:45503960:end --><!-- HN:45502979:start -->
* [45502979](https://news.social-protocols.org/stats?id=45502979) #28 3 points 4 comments -> [Show HN: Blueprintor for Hardware Engineering](https://www.zima.run/)<!-- HN:45502979:end --><!-- HN:45505713:start -->
* [45505713](https://news.social-protocols.org/stats?id=45505713) #14 70 points 2 comments -> [Building a Browser for Reverse Engineers](https://nullpt.rs/reverse-engineering-browser)<!-- HN:45505713:end --><!-- HN:45507264:start -->
* [45507264](https://news.social-protocols.org/stats?id=45507264) #23 7 points 11 comments -> [Photographers are losing their jobs faster than software engineers](https://photowand.ai/packs)<!-- HN:45507264:end --><!-- HN:45508213:start -->
* [45508213](https://news.social-protocols.org/stats?id=45508213) #3 66 points 1 comments -> [A tiny recursive reasoning model achieves 45% on ARC-AGI-1 and 8% on ARC-AGI-2](http://alexiajm.github.io/2025/09/29/tiny_recursive_models.html)<!-- HN:45508213:end --><!-- HN:45507173:start -->
* [45507173](https://news.social-protocols.org/stats?id=45507173) #25 169 points 107 comments -> [Google's Requirement for Developers to Be Verified Threatens App Store F-Droid](https://www.techdirt.com/2025/10/07/googles-requirement-for-all-android-developers-to-register-and-be-verified-threatens-to-close-down-open-source-app-store-f-droid/)<!-- HN:45507173:end --><!-- HN:45509464:start -->
* [45509464](https://news.social-protocols.org/stats?id=45509464) #14 17 points 8 comments -> [Disney Is Officially Shutting Down Hulu After 20 Years](https://wibc.com/749914/disney-is-officially-shutting-down-hulu-after-20-years/)<!-- HN:45509464:end --><!-- HN:45508944:start -->
* [45508944](https://news.social-protocols.org/stats?id=45508944) #20 76 points 49 comments -> [No more loud commercials: Governor Newsom signs SB 576](https://www.gov.ca.gov/2025/10/06/no-more-loud-commercials-governor-newsom-signs-sb-576/)<!-- HN:45508944:end --><!-- HN:45505744:start -->
* [45505744](https://news.social-protocols.org/stats?id=45505744) #14 5 points 1 comments -> [Macroscopic quantum mechanical tunnelling wins Nobel Prize in physics](https://www.chemistryworld.com/news/macroscopic-quantum-mechanical-tunnelling-wins-nobel-prize-in-physics/4022281.article)<!-- HN:45505744:end -->
#### **Wednesday, October 8, 2025**
<!-- HN:45510820:start -->
* [45510820](https://news.social-protocols.org/stats?id=45510820) #19 -> [Ted Cruz doesn't seem to understand Wikipedia, lawyer for Wikimedia says](https://arstechnica.com/tech-policy/2025/10/wikipedia-rebuts-ted-cruz-attack-says-cruz-just-doesnt-understand-the-site/)<!-- HN:45510820:end --><!-- HN:45514189:start -->
* [45514189](https://news.social-protocols.org/stats?id=45514189) #30 7 points 2 comments -> [How to nail the AERO look on your website](https://frutigeraeroarchive.org/blog/posts/23_07_2025)<!-- HN:45514189:end --><!-- HN:45516346:start -->
* [45516346](https://news.social-protocols.org/stats?id=45516346) #3 26 points 8 comments -> [Samsung released a 7M model that achieved 45% on ARC-AGI-1](https://arxiv.org/abs/2510.04871)<!-- HN:45516346:end --><!-- HN:45516402:start -->
* [45516402](https://news.social-protocols.org/stats?id=45516402) #14 16 points 4 comments -> [Show HN: CodingFox – Open-Source AI Code Review Tool That Works Like Magic](https://github.com/furudo-erika/codingfox)<!-- HN:45516402:end --><!-- HN:45516556:start -->
* [45516556](https://news.social-protocols.org/stats?id=45516556) #16 9 points 6 comments -> [How To Start Bug Bounties (2021)](https://ozguralp.medium.com/how-to-start-bug-bounties-101-how-to-make-a-million-in-4-years-e15ee62d6f4)<!-- HN:45516556:end --><!-- HN:45520397:start -->
* [45520397](https://news.social-protocols.org/stats?id=45520397) #24 10 points 0 comments -> [Young lives cut short an unimaginable scale: the 18,457 children on Gaza's dead](https://www.theguardian.com/world/ng-interactive/2025/oct/08/young-lives-cut-short-on-an-unimaginable-scale-the-18457-children-on-gazas-list-of-war-dead)<!-- HN:45520397:end --><!-- HN:45521066:start -->
* [45521066](https://news.social-protocols.org/stats?id=45521066) #5 32 points 4 comments -> [Apple Made ICE Agents a Protected Class](https://migrantinsider.com/p/scoop-apple-quietly-made-ice-agents)<!-- HN:45521066:end --><!-- HN:45521476:start -->
* [45521476](https://news.social-protocols.org/stats?id=45521476) #2 71 points 7 comments -> [Portland is not burning. Here's live context and sourced fact checks](https://isportlandburning.com/)<!-- HN:45521476:end -->
#### **Thursday, October 9, 2025**
<!-- HN:45521484:start -->
* [45521484](https://news.social-protocols.org/stats?id=45521484) #12 77 points 29 comments -> [Why Circular AI Deals Among OpenAI, Nvidia, AMD Are Raising Eyebrows](https://www.bloomberg.com/news/articles/2025-10-08/the-circular-openai-nvidia-and-amd-deals-raising-fears-of-a-new-tech-bubble)<!-- HN:45521484:end --><!-- HN:45521833:start -->
* [45521833](https://news.social-protocols.org/stats?id=45521833) #5 35 points 6 comments -> [Radio Garten](https://radio.garden/)<!-- HN:45521833:end --><!-- HN:45526151:start -->
* [45526151](https://news.social-protocols.org/stats?id=45526151) #23 -> [Framework supporting far-right racists?](https://community.frame.work/t/framework-supporting-far-right-racists/75986)<!-- HN:45526151:end --><!-- HN:45525621:start -->
* [45525621](https://news.social-protocols.org/stats?id=45525621) #16 12 points 1 comments -> [US has spent $33.7B on Israel since it began its war on Gaza two years ago](https://costsofwar.watson.brown.edu/sites/default/files/2025-10/U.S.-Military-Aid-to-Israel_Hartung_Costs-of-War-Quincy_Oct-7-2025.pdf)<!-- HN:45525621:end --><!-- HN:45526715:start -->
* [45526715](https://news.social-protocols.org/stats?id=45526715) #27 10 points 3 comments -> [Framework supporting far-right racists?](https://community.frame.work/t/framework-supporting-far-right-racists/75986)<!-- HN:45526715:end --><!-- HN:45527629:start -->
* [45527629](https://news.social-protocols.org/stats?id=45527629) #25 9 points 2 comments -> [U.S. Military Aid and Arms Transfers to Israel, October 2023 – September 2025 [pdf]](https://costsofwar.watson.brown.edu/sites/default/files/2025-10/U.S.-Military-Aid-to-Israel_Hartung_Costs-of-War-Quincy_Oct-7-2025.pdf)<!-- HN:45527629:end --><!-- HN:45529764:start -->
* [45529764](https://news.social-protocols.org/stats?id=45529764) #19 78 points 1 comments -> [Python 3.14 Is Here. How Fast Is It? – Miguelgrinberg.com](https://blog.miguelgrinberg.com/post/python-3-14-is-here-how-fast-is-it)<!-- HN:45529764:end --><!-- HN:45531544:start -->
* [45531544](https://news.social-protocols.org/stats?id=45531544) #11 4 points 1 comments -> [I'm starting a fund that runs on luck, caffeine, and denial](https://brain.sanketh.in/share/2UrNabaPQD97)<!-- HN:45531544:end -->
#### **Friday, October 10, 2025**
<!-- HN:45534227:start -->
* [45534227](https://news.social-protocols.org/stats?id=45534227) #26 13 points 9 comments -> [Time Warp IDE – Complete Environment for Old-School Coding](https://github.com/James-HoneyBadger/Time_Warp)<!-- HN:45534227:end --><!-- HN:45535263:start -->
* [45535263](https://news.social-protocols.org/stats?id=45535263) #19 43 points 13 comments -> [Apple Took Down These ICE-Tracking Apps. The Developers Aren't Giving Up](https://www.wired.com/story/apple-took-down-ice-tracking-apps-their-developers-arent-giving-up/)<!-- HN:45535263:end -->