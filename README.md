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
* [45535263](https://news.social-protocols.org/stats?id=45535263) #19 43 points 13 comments -> [Apple Took Down These ICE-Tracking Apps. The Developers Aren't Giving Up](https://www.wired.com/story/apple-took-down-ice-tracking-apps-their-developers-arent-giving-up/)<!-- HN:45535263:end --><!-- HN:45535384:start -->
* [45535384](https://news.social-protocols.org/stats?id=45535384) #18 42 points 40 comments -> [I'm turning 41, but I don't feel like celebrating](https://twitter.com/durov/status/1976420399970701543)<!-- HN:45535384:end --><!-- HN:45536705:start -->
* [45536705](https://news.social-protocols.org/stats?id=45536705) #4 33 points 3 comments -> [Nobel Peace Prize 2025](https://www.nobelprize.org/prizes/peace/2025/machado/facts/)<!-- HN:45536705:end --><!-- HN:45537255:start -->
* [45537255](https://news.social-protocols.org/stats?id=45537255) #25 18 points 41 comments -> [EU lawmakers push to ban term 'veggie-burger'](https://www.reuters.com/business/eu-lawmakers-push-ban-term-veggie-burger-2025-10-08/)<!-- HN:45537255:end --><!-- HN:45538768:start -->
* [45538768](https://news.social-protocols.org/stats?id=45538768) #29 34 points 10 comments -> ["My dad says: people like you don't matter anymore."](https://twitter.com/travisakers/status/1976271447606624314)<!-- HN:45538768:end --><!-- HN:45538728:start -->
* [45538728](https://news.social-protocols.org/stats?id=45538728) #26 10 points 4 comments -> [US immigration enforcement using military hardware and tactics on civilians](https://www.theguardian.com/us-news/2025/oct/10/ice-immigration-agents-military-tactics)<!-- HN:45538728:end --><!-- HN:45538143:start -->
* [45538143](https://news.social-protocols.org/stats?id=45538143) #17 17 points 0 comments -> [Jamal Khashoggi, the Washington Post, and the Cost of Speaking Out](https://karenattiah.substack.com/p/jamal-khashoggi-the-washington-post)<!-- HN:45538143:end --><!-- HN:45540615:start -->
* [45540615](https://news.social-protocols.org/stats?id=45540615) #29 16 points 9 comments -> [Fascism Can't Mean Both a Specific Ideology and a Legitimate Target](https://www.astralcodexten.com/p/fascism-cant-mean-both-a-specific)<!-- HN:45540615:end --><!-- HN:45539924:start -->
* [45539924](https://news.social-protocols.org/stats?id=45539924) #26 5 points 2 comments -> [Show HN: A collection of Claude Code plugin marketplaces](https://claudecodeplugin.org)<!-- HN:45539924:end --><!-- HN:45541124:start -->
* [45541124](https://news.social-protocols.org/stats?id=45541124) #10 5 points 2 comments -> [Why Your Company Needs a Chief Failure Officer](https://brianchristner.io/why-your-company-needs-a-chief-failure-officer/)<!-- HN:45541124:end --><!-- HN:45489613:start -->
* [45489613](https://news.social-protocols.org/stats?id=45489613) #11 7 points 6 comments -> [Show HN: Iframetest.com](https://iframetest.com/)<!-- HN:45489613:end --><!-- HN:45536000:start -->
* [45536000](https://news.social-protocols.org/stats?id=45536000) #19 292 points 222 comments -> [I Switched from Htmx to Datastar](https://everydaysuperpowers.dev/articles/why-i-switched-from-htmx-to-datastar/)<!-- HN:45536000:end --><!-- HN:45543114:start -->
* [45543114](https://news.social-protocols.org/stats?id=45543114) #28 -> [Apple Decides ICE Agents Are a Protected Class](https://www.techdirt.com/2025/10/10/apple-decides-ice-agents-are-a-protected-class-because-apparently-government-accountability-is-now-hate-speech/)<!-- HN:45543114:end -->
#### **Saturday, October 11, 2025**
<!-- HN:45546657:start -->
* [45546657](https://news.social-protocols.org/stats?id=45546657) #6 -> [Peter Thiel's off-the-record lectures about the antichrist](https://www.theguardian.com/us-news/2025/oct/10/peter-thiel-lectures-antichrist)<!-- HN:45546657:end --><!-- HN:45502044:start -->
* [45502044](https://news.social-protocols.org/stats?id=45502044) #16 5 points 8 comments -> [Show HN: Cjam – a modern MP3 file editor](https://github.com/cutandjoin/Cjam/releases/tag/v2230)<!-- HN:45502044:end --><!-- HN:45548902:start -->
* [45548902](https://news.social-protocols.org/stats?id=45548902) #2 26 points 12 comments -> [Sysco Is Not "Ruining Restaurants"](https://liamrosen.com/2025/10/10/no-sysco-is-not-ruining-restaurants/)<!-- HN:45548902:end --><!-- HN:45549524:start -->
* [45549524](https://news.social-protocols.org/stats?id=45549524) #27 31 points 40 comments -> [Does anyone remember websites?](http://tttthis.com/rememberwebsites.php/)<!-- HN:45549524:end --><!-- HN:45551006:start -->
* [45551006](https://news.social-protocols.org/stats?id=45551006) #27 24 points 21 comments -> [Show HN: Gnokestation Is an Ultra Lightweight Web Desktop Environment](https://gnokestation.netlify.app)<!-- HN:45551006:end --><!-- HN:45551370:start -->
* [45551370](https://news.social-protocols.org/stats?id=45551370) #21 15 points 6 comments -> [Apple Postpones Jessica Chastain Thriller 'The Savant' Amid Current Events](https://deadline.com/2025/09/the-savant-jessica-chastain-postponed-apple-1236553658/)<!-- HN:45551370:end --><!-- HN:45489329:start -->
* [45489329](https://news.social-protocols.org/stats?id=45489329) #28 12 points 3 comments -> [Crypto-Current (2021)](https://zerophilosophy.substack.com/p/crypto-current)<!-- HN:45489329:end -->
#### **Sunday, October 12, 2025**<!-- HN:45500142:start -->
* [45500142](https://news.social-protocols.org/stats?id=45500142) #16 6 points 3 comments -> [Weird Operators in PHP](https://www.exakat.io/weird-operators-in-php/)<!-- HN:45500142:end -->