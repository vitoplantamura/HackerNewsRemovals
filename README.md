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

#### **Saturday, January 11, 2025**<!-- HN:42665771:start -->
* [42665771](https://news.social-protocols.org/stats?id=42665771) #21 5 points 2 comments -> [Zuckerberg trash talks Apple in interview with Joe Rogan](https://www.theverge.com/2025/1/10/24341039/meta-apple-mark-zuckerberg-trash-talks-joe-rogan-interview)<!-- HN:42665771:end --><!-- HN:42631876:start -->
* [42631876](https://news.social-protocols.org/stats?id=42631876) #15 65 points 28 comments -> [Donut Lab's next-generation in-wheel motors](https://www.donutlab.com/motor/)<!-- HN:42631876:end --><!-- HN:42665368:start -->
* [42665368](https://news.social-protocols.org/stats?id=42665368) #29 9 points 8 comments -> [TikTok Says It Will 'Go Dark' Without US Court Intervention](https://www.businessinsider.com/tiktok-says-wouid-go-dark-january-without-us-court-intervention-2025-1)<!-- HN:42665368:end --><!-- HN:42665533:start -->
* [42665533](https://news.social-protocols.org/stats?id=42665533) #26 8 points 0 comments -> [Sony Proposes Changing LLVM Clang Default to C++20 Mode](https://www.phoronix.com/news/Sony-LLVM-Clang-CXX20-Default)<!-- HN:42665533:end --><!-- HN:42626043:start -->
* [42626043](https://news.social-protocols.org/stats?id=42626043) #14 50 points 66 comments -> [Kirin demos "electric salt spoon" at CES](https://techcrunch.com/2025/01/05/kirin-offers-a-taste-of-its-electric-salt-spoon-at-ces-2025/)<!-- HN:42626043:end --><!-- HN:42666513:start -->
* [42666513](https://news.social-protocols.org/stats?id=42666513) #26 4 points 0 comments -> [The Elephant in the room: The myth of exponential hypergrowth](https://longform.asmartbear.com/exponential-growth/)<!-- HN:42666513:end --><!-- HN:42659111:start -->
* [42659111](https://news.social-protocols.org/stats?id=42659111) #11 24 points 20 comments -> [Year old startup overloaded GitHub – Incident report](https://lovable.dev/news/github-incident-2025-01-02)<!-- HN:42659111:end --><!-- HN:42668087:start -->
* [42668087](https://news.social-protocols.org/stats?id=42668087) #28 18 points 14 comments -> [Civilian police oversight in Florida crumbles after new law kicks in](https://www.tampabay.com/news/florida-politics/2025/01/11/civilian-police-oversight-florida-crumbles-after-new-law-kicks/)<!-- HN:42668087:end --><!-- HN:42667825:start -->
* [42667825](https://news.social-protocols.org/stats?id=42667825) #14 7 points 3 comments -> [You are an absolute moron for believing in the hype of "AI Agents"](https://nexustrade.io/blog/you-are-an-absolute-moron-for-believing-in-the-hype-of-ai-agents-20250111)<!-- HN:42667825:end --><!-- HN:42669006:start -->
* [42669006](https://news.social-protocols.org/stats?id=42669006) #1 34 points 3 comments -> [FCC Proposes Cybersecurity Labeling Program for Smart Devices](https://www.fcc.gov/cybersecurity-certification-mark)<!-- HN:42669006:end -->
#### **Sunday, January 12, 2025**
<!-- HN:42671404:start -->
* [42671404](https://news.social-protocols.org/stats?id=42671404) #30 3 points 0 comments -> [Epic Games Introduces New Terms of Service](https://twitter.com/Pirat_Nation/status/1878245087349538957)<!-- HN:42671404:end --><!-- HN:42641903:start -->
* [42641903](https://news.social-protocols.org/stats?id=42641903) #16 11 points 0 comments -> [The stories of survivors of the Rwandan Genocide](https://www.positivenewsus.org/rwandan-stories-of-survivor.html)<!-- HN:42641903:end --><!-- HN:42671589:start -->
* [42671589](https://news.social-protocols.org/stats?id=42671589) #12 12 points 6 comments -> [Show HN: Willpayforthis.com – Gathering posts about what people will pay for](https://www.willpayforthis.com/)<!-- HN:42671589:end --><!-- HN:42672477:start -->
* [42672477](https://news.social-protocols.org/stats?id=42672477) #10 10 points 0 comments -> [Asking rents skyrocket as LA fires destroy homes](https://laist.com/news/housing-homelessness/los-angeles-palisades-fire-housing-rent-price-gouging-law-california-zillow-listing)<!-- HN:42672477:end --><!-- HN:42672876:start -->
* [42672876](https://news.social-protocols.org/stats?id=42672876) #25 7 points 0 comments -> [Open letter to Mark Zuckerberg – Congratulations on your remarks](https://www.berliner-zeitung.de/politik-gesellschaft/open-letter-to-mark-zuckerberg-congratulations-on-your-speech-now-fire-correctiv-li.2288496)<!-- HN:42672876:end --><!-- HN:42672886:start -->
* [42672886](https://news.social-protocols.org/stats?id=42672886) #14 23 points 5 comments -> [Male and female brains differ at birth](https://bsd.biomedcentral.com/articles/10.1186/s13293-024-00657-5)<!-- HN:42672886:end --><!-- HN:42673366:start -->
* [42673366](https://news.social-protocols.org/stats?id=42673366) #5 7 points 1 comments -> [macOS No Longer Ships with Emacs](https://batsov.com/articles/2025/01/12/macos-no-longer-ships-with-emacs/)<!-- HN:42673366:end --><!-- HN:42673405:start -->
* [42673405](https://news.social-protocols.org/stats?id=42673405) #19 6 points 5 comments -> [Matt Should Resign (2010)](http://wpblogger.com/matt-should-resign.php)<!-- HN:42673405:end --><!-- HN:42675251:start -->
* [42675251](https://news.social-protocols.org/stats?id=42675251) #27 4 points 0 comments -> [LA Renters Hit with Price Gouging During Wildfire Chaos](https://www.newsweek.com/la-renters-pride-gouging-los-angeles-wildfires-2013645)<!-- HN:42675251:end --><!-- HN:42675376:start -->
* [42675376](https://news.social-protocols.org/stats?id=42675376) #8 10 points 0 comments -> [On Misery](https://mcfunley.com/on-misery)<!-- HN:42675376:end --><!-- HN:42674627:start -->
* [42674627](https://news.social-protocols.org/stats?id=42674627) #29 15 points 4 comments -> [Show HN: SemHash – Fast Semantic Text Deduplication for Cleaner Datasets](https://github.com/MinishLab/semhash)<!-- HN:42674627:end --><!-- HN:42676176:start -->
* [42676176](https://news.social-protocols.org/stats?id=42676176) #17 11 points 1 comments -> [California Fire Facts](https://gavinnewsom.com/california-fire-facts/)<!-- HN:42676176:end --><!-- HN:42633273:start -->
* [42633273](https://news.social-protocols.org/stats?id=42633273) #2 11 points 2 comments -> [Backdooring your backdoors – Another $20 domain, more governments](https://labs.watchtowr.com/more-governments-backdoors-in-your-backdoors/)<!-- HN:42633273:end --><!-- HN:42609436:start -->
* [42609436](https://news.social-protocols.org/stats?id=42609436) #14 11 points 4 comments -> [Show HN: wonderful.dev – social platform for programmers](https://wonderful.dev)<!-- HN:42609436:end -->
#### **Monday, January 13, 2025**
<!-- HN:42681435:start -->
* [42681435](https://news.social-protocols.org/stats?id=42681435) #27 24 points 40 comments -> [Apple asks investors to block proposal to scrap diversity programmes](https://www.theguardian.com/technology/2025/jan/13/apple-investors-diversity-dei)<!-- HN:42681435:end --><!-- HN:42682093:start -->
* [42682093](https://news.social-protocols.org/stats?id=42682093) #27 6 points 0 comments -> [Fedora 42 Looks to Ship Optimized Executables for Different x86_64 Capabilities](https://www.phoronix.com/news/Fedora-42-Optimized-Executables)<!-- HN:42682093:end --><!-- HN:42681866:start -->
* [42681866](https://news.social-protocols.org/stats?id=42681866) #10 11 points 1 comments -> [Show HN: JUring – Java bindings for io_uring file I/O](https://github.com/davidtos/JUring)<!-- HN:42681866:end --><!-- HN:42683962:start -->
* [42683962](https://news.social-protocols.org/stats?id=42683962) #26 5 points 0 comments -> [TikTok ban violates Americans' First Amendment rights](https://www.thefire.org/news/fire-scotus-tiktok-ban-violates-americans-first-amendment-rights)<!-- HN:42683962:end --><!-- HN:42683184:start -->
* [42683184](https://news.social-protocols.org/stats?id=42683184) #10 30 points 7 comments -> [The Origins of Wokeness](https://paulgraham.com/woke.html)<!-- HN:42683184:end --><!-- HN:42685225:start -->
* [42685225](https://news.social-protocols.org/stats?id=42685225) #7 22 points 2 comments -> [The Typical Man Disgusts the Typical Woman](https://www.betonit.ai/p/the-typical-man-disgusts-the-typical)<!-- HN:42685225:end --><!-- HN:42685582:start -->
* [42685582](https://news.social-protocols.org/stats?id=42685582) #15 -> [Anonymous ex-employee of X claims Elon Musk directed 2024 election interference](https://theconcernedbird.substack.com/p/elon-musks-and-xs-role-in-2024-election)<!-- HN:42685582:end --><!-- HN:42684574:start -->
* [42684574](https://news.social-protocols.org/stats?id=42684574) #29 19 points 20 comments -> [California Fire Facts](https://gavinnewsom.com/california-fire-facts/)<!-- HN:42684574:end --><!-- HN:42684912:start -->
* [42684912](https://news.social-protocols.org/stats?id=42684912) #14 31 points 40 comments -> [( UK ) Prime Minister sets out blueprint to turbocharge AI](https://www.gov.uk/government/news/prime-minister-sets-out-blueprint-to-turbocharge-ai)<!-- HN:42684912:end --><!-- HN:42686143:start -->
* [42686143](https://news.social-protocols.org/stats?id=42686143) #6 4 points 1 comments -> [Fail. Stop being a political party Superfan](https://justinebateman.substack.com/p/fail)<!-- HN:42686143:end --><!-- HN:42686362:start -->
* [42686362](https://news.social-protocols.org/stats?id=42686362) #5 85 points 58 comments -> [Let's Quit X](https://www.helloquitx.com)<!-- HN:42686362:end --><!-- HN:42687033:start -->
* [42687033](https://news.social-protocols.org/stats?id=42687033) #13 29 points 41 comments -> [Mark Zuckerberg says AI could soon do the work of Meta's midlevel engineers](https://www.businessinsider.com/mark-zuckerberg-meta-ai-replace-engineers-coders-joe-rogan-podcast-2025-1)<!-- HN:42687033:end --><!-- HN:42690618:start -->
* [42690618](https://news.social-protocols.org/stats?id=42690618) #22 10 points 1 comments -> [The great firewall is finally broken](https://medium.com/@dennyluan/the-great-firewall-is-finally-broken-deb82428481a)<!-- HN:42690618:end --><!-- HN:42691007:start -->
* [42691007](https://news.social-protocols.org/stats?id=42691007) #12 8 points 4 comments -> [Zombie deer disease 'may have jumped to humans' as US Government issue warning](https://www.dailymail.co.uk/health/article-14280007/researchers-warn-chronic-wasting-disease-zombie-deer.html)<!-- HN:42691007:end -->
#### **Tuesday, January 14, 2025**
<!-- HN:42663917:start -->
* [42663917](https://news.social-protocols.org/stats?id=42663917) #6 6 points 2 comments -> [AI-Powered 2D to 3D Model Generator](https://3dify.space)<!-- HN:42663917:end --><!-- HN:42655563:start -->
* [42655563](https://news.social-protocols.org/stats?id=42655563) #30 11 points 40 comments -> [Show HN: Python with do..end in place of strict indentation](https://github.com/navxio/dopy)<!-- HN:42655563:end --><!-- HN:42660950:start -->
* [42660950](https://news.social-protocols.org/stats?id=42660950) #10 11 points 1 comments -> [Apollo Landing Keypad Shrunken into Coolest Calculator Watch](https://gizmodo.com/apollo-landing-keypad-shrunken-into-worlds-coolest-calculator-watch-2000541103)<!-- HN:42660950:end --><!-- HN:42692868:start -->
* [42692868](https://news.social-protocols.org/stats?id=42692868) #6 6 points 0 comments -> [Has Canada Become a Jamaican Bobsled Team?](https://jaymartin.substack.com/p/has-canada-become-a-jamaican-bobsled)<!-- HN:42692868:end --><!-- HN:42694648:start -->
* [42694648](https://news.social-protocols.org/stats?id=42694648) #3 3 points 2 comments -> [What Is TikTok Refugee?](https://www.tiktokrefugee.info/)<!-- HN:42694648:end --><!-- HN:42694635:start -->
* [42694635](https://news.social-protocols.org/stats?id=42694635) #5 3 points 0 comments -> [RedNote Style Content Assistant](https://www.rednote.pro/)<!-- HN:42694635:end --><!-- HN:42694932:start -->
* [42694932](https://news.social-protocols.org/stats?id=42694932) #16 21 points 40 comments -> [U.S. Employee Engagement Sinks to 10-Year Low](https://www.gallup.com/workplace/654911/employee-engagement-sinks-year-low.aspx)<!-- HN:42694932:end --><!-- HN:42696324:start -->
* [42696324](https://news.social-protocols.org/stats?id=42696324) #23 8 points 4 comments -> [Russia is being set aflame by arson attacks](https://www.economist.com/europe/2025/01/12/russia-is-being-set-aflame-by-hundreds-of-arson-attacks)<!-- HN:42696324:end --><!-- HN:42696264:start -->
* [42696264](https://news.social-protocols.org/stats?id=42696264) #16 24 points 40 comments -> [Singapore is turning to AI to care for its rapidly aging population](https://restofworld.org/2025/singapore-ai-eldercare-tools/)<!-- HN:42696264:end --><!-- HN:42696204:start -->
* [42696204](https://news.social-protocols.org/stats?id=42696204) #30 24 points 40 comments -> [Sweden is a nearly cashless society – how it affects people who are left out](https://theconversation.com/sweden-is-a-nearly-cashless-society-heres-how-it-affects-people-who-are-left-out-216586)<!-- HN:42696204:end --><!-- HN:42657402:start -->
* [42657402](https://news.social-protocols.org/stats?id=42657402) #17 3 points 0 comments -> [Bad Apple with Regex in Vim](https://eieio.games/blog/bad-apple-with-regex-in-vim/)<!-- HN:42657402:end --><!-- HN:42698092:start -->
* [42698092](https://news.social-protocols.org/stats?id=42698092) #2 69 points 41 comments -> [47% of 160 Top Selling Protein Powders Tested Exceed P65 Limit for Toxic Metals [pdf]](https://cleanlabelproject.org/wp-content/uploads/CleanLabelProject_ProteinStudyWhitepaper_010625.pdf)<!-- HN:42698092:end --><!-- HN:42701057:start -->
* [42701057](https://news.social-protocols.org/stats?id=42701057) #18 6 points 6 comments -> [MrBeast Might Buy TikTok](https://twitter.com/MrBeast/status/1879224239485808811)<!-- HN:42701057:end --><!-- HN:42701393:start -->
* [42701393](https://news.social-protocols.org/stats?id=42701393) #23 34 points 41 comments -> [Software engineer pay heatmap for Europe](https://levels.fyi/heatmap/europe/)<!-- HN:42701393:end --><!-- HN:42703935:start -->
* [42703935](https://news.social-protocols.org/stats?id=42703935) #27 7 points 1 comments -> [Chinese RJ45-USB with Flash Memory .exe Recognized as Malware](https://epcyber.com/blog/f/chinese-rj45-usb-with-flash-memory-exe-recognized-as-malware)<!-- HN:42703935:end -->
#### **Wednesday, January 15, 2025**
<!-- HN:42708295:start -->
* [42708295](https://news.social-protocols.org/stats?id=42708295) #22 7 points 1 comments -> [Mark Zuckerberg Was Right to Fire Facebook's Rogue Fact-Checkers](https://reason.com/2025/01/07/mark-zuckerberg-meta-facebook-fact-checkers-censorship/)<!-- HN:42708295:end --><!-- HN:42707606:start -->
* [42707606](https://news.social-protocols.org/stats?id=42707606) #6 40 points 42 comments -> [I failed moving my Google calendar to Proton](https://shilin.ca/i-tried-moving-my-google-calendar-to-proton-and-failed/)<!-- HN:42707606:end --><!-- HN:42711412:start -->
* [42711412](https://news.social-protocols.org/stats?id=42711412) #13 7 points 0 comments -> [Your brain is lying to you about the “good old days”](https://www.vox.com/future-perfect/394872/past-present-selective-memory-progress-brain-science)<!-- HN:42711412:end --><!-- HN:42670789:start -->
* [42670789](https://news.social-protocols.org/stats?id=42670789) #8 5 points 1 comments -> [Early Iron Age horse sacrifice at a royal tomb in southern Siberia](https://www.cambridge.org/core/journals/antiquity/article/spectral-cavalcade-early-iron-age-horse-sacrifice-at-a-royal-tomb-in-southern-siberia/80E0B627528E00EA7C2AE4456F182DAC)<!-- HN:42670789:end --><!-- HN:42714147:start -->
* [42714147](https://news.social-protocols.org/stats?id=42714147) #25 6 points 2 comments -> [Israel, Hamas reach ceasefire agreement meant to end 15-month Gaza war](https://www.reuters.com/world/middle-east/gaza-ceasefire-appears-close-us-egyptian-leaders-put-focus-coming-hours-2025-01-14/)<!-- HN:42714147:end --><!-- HN:42714774:start -->
* [42714774](https://news.social-protocols.org/stats?id=42714774) #11 26 points 42 comments -> [Banning TikTok Is Unconstitutional. The Supreme Court Must Step In](https://www.aclu.org/news/national-security/banning-tiktok-is-unconstitutional-the-supreme-court-must-step-in)<!-- HN:42714774:end --><!-- HN:42715462:start -->
* [42715462](https://news.social-protocols.org/stats?id=42715462) #12 12 points 6 comments -> [Laptop](https://mijndertstuij.nl/posts/the-best-laptop-ever/)<!-- HN:42715462:end --><!-- HN:42716926:start -->
* [42716926](https://news.social-protocols.org/stats?id=42716926) #11 33 points 9 comments -> [The Trouble with Elon](https://samharris.substack.com/p/the-trouble-with-elon)<!-- HN:42716926:end --><!-- HN:42715475:start -->
* [42715475](https://news.social-protocols.org/stats?id=42715475) #23 5 points 1 comments -> [Israel and Hamas reach Gaza ceasefire and hostage deal](https://www.cnbc.com/2025/01/15/israel-hamas-ceasefire-hostage-deal-agreed-to-in-principle.html)<!-- HN:42715475:end --><!-- HN:42714920:start -->
* [42714920](https://news.social-protocols.org/stats?id=42714920) #2 54 points 23 comments -> [Gemini Advanced now included in Google Workspace](https://workspace.google.com/blog/product-announcements/empowering-businesses-with-AI)<!-- HN:42714920:end -->
#### **Thursday, January 16, 2025**
<!-- HN:42719704:start -->
* [42719704](https://news.social-protocols.org/stats?id=42719704) #28 7 points 0 comments -> [Microsoft engineer terminated for threatening Palestinians with genocide](https://twitter.com/StopArabHate/status/1879695601820131454)<!-- HN:42719704:end --><!-- HN:42721191:start -->
* [42721191](https://news.social-protocols.org/stats?id=42721191) #18 12 points 4 comments -> [Milei shuts down museums memorializing victims of Argentine dictatorship](https://www.wsws.org/en/articles/2025/01/11/jtng-j11.html)<!-- HN:42721191:end --><!-- HN:42724179:start -->
* [42724179](https://news.social-protocols.org/stats?id=42724179) #6 5 points 1 comments -> [Strategies to Complete Tasks with ADHD](https://schroedermelanie.com/adhs-nichts-zuende-bringen/)<!-- HN:42724179:end --><!-- HN:42724823:start -->
* [42724823](https://news.social-protocols.org/stats?id=42724823) #14 165 points 120 comments -> [Nintendo Switch 2](https://www.nintendo.com/successor/en-gb/index.html)<!-- HN:42724823:end --><!-- HN:42723543:start -->
* [42723543](https://news.social-protocols.org/stats?id=42723543) #18 31 points 40 comments -> [Is there such a thing as a web-safe font?](https://www.highperformancewebfonts.com/read/web-safe-fonts)<!-- HN:42723543:end --><!-- HN:42727174:start -->
* [42727174](https://news.social-protocols.org/stats?id=42727174) #24 4 points 1 comments -> [You Blamed DEI for Hurting Your Career. Now What?](https://www.wsj.com/lifestyle/careers/you-blamed-dei-for-hurting-your-career-now-what-6150c575)<!-- HN:42727174:end --><!-- HN:42728967:start -->
* [42728967](https://news.social-protocols.org/stats?id=42728967) #7 147 points 7 comments -> [David Lynch, Twin Peaks and Muholland Drive director, dies aged 78](https://www.theguardian.com/film/2025/jan/16/david-lynch-twin-peaks-and-muholland-drive-director-dies-aged-78)<!-- HN:42728967:end --><!-- HN:42729347:start -->
* [42729347](https://news.social-protocols.org/stats?id=42729347) #29 26 points 8 comments -> [The Washington Post kills off its "Democracy Dies In Darkness" slogan](https://www.avclub.com/washington-post-kills-democracy-dies-in-darkness-slogan)<!-- HN:42729347:end --><!-- HN:42685018:start -->
* [42685018](https://news.social-protocols.org/stats?id=42685018) #17 8 points 3 comments -> [Cosine Similarity Isn't the Silver Bullet We Thought It Was](https://www.shaped.ai/blog/cosine-similarity-not-the-silver-bullet-we-thought-it-was)<!-- HN:42685018:end -->
#### **Friday, January 17, 2025**
<!-- HN:42735976:start -->
* [42735976](https://news.social-protocols.org/stats?id=42735976) #21 20 points 11 comments -> [Show HN: I built a credit-based system API](https://creduse.com/#features-grid)<!-- HN:42735976:end --><!-- HN:42736705:start -->
* [42736705](https://news.social-protocols.org/stats?id=42736705) #2 8 points 5 comments -> [Rumor About GPT-5 Changes Everything](https://www.thealgorithmicbridge.com/p/this-rumor-about-gpt-5-changes-everything)<!-- HN:42736705:end --><!-- HN:42680318:start -->
* [42680318](https://news.social-protocols.org/stats?id=42680318) #15 99 points 6 comments -> [Slum: The Shadow Library Uptime Monitor](https://open-slum.org/)<!-- HN:42680318:end -->