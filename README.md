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
* [45500142](https://news.social-protocols.org/stats?id=45500142) #16 6 points 3 comments -> [Weird Operators in PHP](https://www.exakat.io/weird-operators-in-php/)<!-- HN:45500142:end --><!-- HN:45556010:start -->
* [45556010](https://news.social-protocols.org/stats?id=45556010) #8 17 points 11 comments -> [CBP Enforces Binary Sex Codes and Enhanced US Passport Validation in APIs](https://www.gtlaw-insidebusinessimmigration.com/u-s-customs-and-border-protection-cbp/cbp-enforces-binary-sex-codes-and-enhanced-us-passport-validation-in-apis/)<!-- HN:45556010:end --><!-- HN:45493480:start -->
* [45493480](https://news.social-protocols.org/stats?id=45493480) #12 6 points 2 comments -> [Blossom – Heroku-like deploys on your servers; cheaper, no lock-in](https://www.blossom88.com)<!-- HN:45493480:end --><!-- HN:45557256:start -->
* [45557256](https://news.social-protocols.org/stats?id=45557256) #27 17 points 8 comments -> [A New Algorithm Makes It Faster to Find the Shortest Paths](https://www.wired.com/story/new-method-is-the-fastest-way-to-find-the-best-routes/)<!-- HN:45557256:end --><!-- HN:45558900:start -->
* [45558900](https://news.social-protocols.org/stats?id=45558900) #5 7 points 2 comments -> [The IP risks of LLMs at work are nontrivial](https://www.augmentedswe.com/p/how-to-use-ai-written-code-in-without)<!-- HN:45558900:end --><!-- HN:45560593:start -->
* [45560593](https://news.social-protocols.org/stats?id=45560593) #24 49 points 25 comments -> [Nielsen Norman Group on iOS 26 usability](https://anderegg.ca/2025/10/12/nielsen-norman-group-on-ios-26-usability)<!-- HN:45560593:end --><!-- HN:45560218:start -->
* [45560218](https://news.social-protocols.org/stats?id=45560218) #11 21 points 3 comments -> [Agent Shell 0.5 Improvements](https://xenodium.com/agent-shell-0-5-improvements)<!-- HN:45560218:end -->
#### **Monday, October 13, 2025**
<!-- HN:45564981:start -->
* [45564981](https://news.social-protocols.org/stats?id=45564981) #23 5 points 0 comments -> [Framework embraces deeply extremist views](https://www.osnews.com/story/143520/in-bizarre-move-framework-embraces-deeply-extremist-views/)<!-- HN:45564981:end --><!-- HN:45520550:start -->
* [45520550](https://news.social-protocols.org/stats?id=45520550) #26 19 points 13 comments -> [A debate about AI plays out on the subway walls](https://www.nytimes.com/2025/10/07/style/friend-ai-subway-ads-new-york.html)<!-- HN:45520550:end --><!-- HN:45566454:start -->
* [45566454](https://news.social-protocols.org/stats?id=45566454) #10 5 points 4 comments -> [Show HN: I built an online productivity tools website](https://onlinenotep.ad)<!-- HN:45566454:end --><!-- HN:45568713:start -->
* [45568713](https://news.social-protocols.org/stats?id=45568713) #30 21 points 10 comments -> [Hamas Releases Israeli Hostages](https://www.npr.org/2025/10/13/g-s1-93207/hamas-releasing-israeli-hostages)<!-- HN:45568713:end --><!-- HN:45569896:start -->
* [45569896](https://news.social-protocols.org/stats?id=45569896) #4 23 points 41 comments -> [Apple Renames 'Apple TV+' to 'Apple TV'](https://www.apple.com/tv-pr/news/2025/10/apple-original-films-blockbuster-feature-f1-the-movie-from-joseph-kosinski-to-make-global-streaming-debut-on-friday-december-12-2025/)<!-- HN:45569896:end --><!-- HN:45570840:start -->
* [45570840](https://news.social-protocols.org/stats?id=45570840) #24 9 points 4 comments -> [ProtonVPN Lied About Logging](https://vp.net/l/en-US/blog/ProtonVPN-Lied-About-Logging)<!-- HN:45570840:end --><!-- HN:45571718:start -->
* [45571718](https://news.social-protocols.org/stats?id=45571718) #6 45 points 12 comments -> [People Are People, or Why I Don't Want to Be a Landlord](https://oddevan.com/2025/10/13/people-are-people-or-why.html)<!-- HN:45571718:end --><!-- HN:45572640:start -->
* [45572640](https://news.social-protocols.org/stats?id=45572640) #7 11 points 1 comments -> [DJI's Promo Shows Drone Footage from Prohibited National Parks and Tribal Lands](https://dronexl.co/2025/10/12/dji-mavic-4-pro-drone-footage-prohibited-national-parks/)<!-- HN:45572640:end -->
#### **Tuesday, October 14, 2025**
<!-- HN:45574935:start -->
* [45574935](https://news.social-protocols.org/stats?id=45574935) #27 54 points 1 comments -> [SpaceX Starship flight 11 successful](https://twitter.com/SpaceX/status/1977895039318864296)<!-- HN:45574935:end --><!-- HN:45518418:start -->
* [45518418](https://news.social-protocols.org/stats?id=45518418) #19 6 points 2 comments -> [The Bari Weiss Strategy](https://letter.otherlife.co/p/bari)<!-- HN:45518418:end --><!-- HN:45577193:start -->
* [45577193](https://news.social-protocols.org/stats?id=45577193) #20 17 points 10 comments -> [I let my AI agents run unsupervised and they burned $200 in 2 hours](https://blog.justcopy.ai/p/i-let-my-ai-agents-run-unsupervised)<!-- HN:45577193:end --><!-- HN:45577470:start -->
* [45577470](https://news.social-protocols.org/stats?id=45577470) #30 3 points 1 comments -> [Freed Israeli hostages recount brutal beatings, starvation](https://nypost.com/2025/10/14/world-news/freed-israeli-hostages-recount-brutal-beatings-starvation-and-years-underground-in-hamas-captivity/)<!-- HN:45577470:end --><!-- HN:45578469:start -->
* [45578469](https://news.social-protocols.org/stats?id=45578469) #20 6 points 0 comments -> [US news outlets refuse to sign new Pentagon rules to report only official info](https://www.theguardian.com/us-news/2025/oct/13/defense-department-media-news-rules)<!-- HN:45578469:end --><!-- HN:45526931:start -->
* [45526931](https://news.social-protocols.org/stats?id=45526931) #15 11 points 2 comments -> [2025 Q3 Sardines](https://draftcorgi.substack.com/p/2025-q3-recommendations)<!-- HN:45526931:end --><!-- HN:45580724:start -->
* [45580724](https://news.social-protocols.org/stats?id=45580724) #16 14 points 7 comments -> [Scientists create 'Superwood' that's 10 times stronger than steel](https://www.cnn.com/science/superwood-10-times-stronger-than-steel-spc)<!-- HN:45580724:end --><!-- HN:45579158:start -->
* [45579158](https://news.social-protocols.org/stats?id=45579158) #30 9 points 2 comments -> [Gravity Can Explain the Collapse of the Wavefunction](https://arxiv.org/abs/2510.11037)<!-- HN:45579158:end --><!-- HN:45582688:start -->
* [45582688](https://news.social-protocols.org/stats?id=45582688) #24 14 points 1 comments -> [Opinion: Why I'm handing in my Pentagon press pass](https://www.npr.org/2025/10/14/g-s1-93297/pentagon-reporter-opinion-press-policy)<!-- HN:45582688:end --><!-- HN:45583122:start -->
* [45583122](https://news.social-protocols.org/stats?id=45583122) #20 16 points 1 comments -> [Young Republicans brag about their racism](https://www.politico.com/news/2025/10/14/private-chat-among-young-gop-club-members-00592146)<!-- HN:45583122:end --><!-- HN:45584295:start -->
* [45584295](https://news.social-protocols.org/stats?id=45584295) #3 116 points 46 comments -> [Half of America's Voting Machines Are Now Owned by a MAGA Oligarch](https://dissentinbloom.substack.com/p/half-of-americas-voting-machines)<!-- HN:45584295:end --><!-- HN:45584809:start -->
* [45584809](https://news.social-protocols.org/stats?id=45584809) #14 24 points 45 comments -> [New-Vehicle Avg Price Hits Record High in Sep, Surges Past $50k for First Time](https://www.coxautoinc.com/insights-hub/sept-2025-atp-report/)<!-- HN:45584809:end --><!-- HN:45586219:start -->
* [45586219](https://news.social-protocols.org/stats?id=45586219) #10 -> [Meta Erases Gaza Journalist's Instagram](https://twitter.com/DropSiteNews/status/1977795050206576763)<!-- HN:45586219:end -->
#### **Wednesday, October 15, 2025**
<!-- HN:45586618:start -->
* [45586618](https://news.social-protocols.org/stats?id=45586618) #11 6 points 0 comments -> [Meditating with mongooses: Backyard wildlife phtotography lessons](https://wildgundmi.com/meditating-with-mongooses)<!-- HN:45586618:end --><!-- HN:45590842:start -->
* [45590842](https://news.social-protocols.org/stats?id=45590842) #10 6 points 3 comments -> [Show HN: I started treasure hunt in Blue Ridge. It's Day 7. Prize is up to $36k+](https://countdowntreasure.com/treasure-hunt)<!-- HN:45590842:end --><!-- HN:45590239:start -->
* [45590239](https://news.social-protocols.org/stats?id=45590239) #14 6 points 0 comments -> [Show HN: Nano Banana AI Prompt Gallery](https://nanobananas.ai/banana-image-prompt)<!-- HN:45590239:end -->