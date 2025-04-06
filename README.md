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

#### **Monday, March 31, 2025**
<!-- HN:43529362:start -->
* [43529362](https://news.social-protocols.org/stats?id=43529362) #3 10 points 8 comments -> [Executive order phases out U.S. Treasury paper checks](https://bankingjournal.aba.com/2025/03/executive-order-phases-out-u-s-treasury-paper-checks/)<!-- HN:43529362:end --><!-- HN:43528496:start -->
* [43528496](https://news.social-protocols.org/stats?id=43528496) #19 42 points 41 comments -> [Can Style Be Timeless?](https://www.mrporter.com/en-gb/journal/fashion/derek-guy-timeless-style-25197344)<!-- HN:43528496:end --><!-- HN:43530751:start -->
* [43530751](https://news.social-protocols.org/stats?id=43530751) #24 41 points 40 comments -> [Fiber optic drones are changing combat operations](https://www.youtube.com/watch?v=JcB4dR_8xPo)<!-- HN:43530751:end --><!-- HN:43531494:start -->
* [43531494](https://news.social-protocols.org/stats?id=43531494) #5 16 points 5 comments -> [Agentic AI Needs Its TCP/IP Moment](https://www.anup.io/p/architecting-the-internet-of-agents)<!-- HN:43531494:end --><!-- HN:43532939:start -->
* [43532939](https://news.social-protocols.org/stats?id=43532939) #1 11 points 5 comments -> [GPT-4o draws itself as a consistent type of guy](https://newsletter.danielpaleka.com/p/gpt-4o-draws-itself-as-a-consistent)<!-- HN:43532939:end --><!-- HN:43532736:start -->
* [43532736](https://news.social-protocols.org/stats?id=43532736) #14 3 points 1 comments -> [Custom AI Chatbot Development Services: Restrictions and Opportunities](https://belitsoft.com/chatbot-development-services/custom-ai)<!-- HN:43532736:end --><!-- HN:43533634:start -->
* [43533634](https://news.social-protocols.org/stats?id=43533634) #14 11 points 4 comments -> [Net migration into the UK has tripled post-Brexit](https://www.bigissue.com/opinion/brexit-net-migration-rishi-sunak-uk-immigration/)<!-- HN:43533634:end --><!-- HN:43535311:start -->
* [43535311](https://news.social-protocols.org/stats?id=43535311) #30 7 points 0 comments -> [Trump's USAID Cuts Hobble Earthquake Response in Myanmar](https://www.nytimes.com/2025/03/30/world/asia/myanmar-earthquake-usaid-cuts.html)<!-- HN:43535311:end --><!-- HN:43525246:start -->
* [43525246](https://news.social-protocols.org/stats?id=43525246) #19 17 points 10 comments -> [Tiniest Flying Robot (Wingspan &lt;1cm) Soars Thanks to Magnets](https://spectrum.ieee.org/flying-robot-2671447539)<!-- HN:43525246:end --><!-- HN:43537580:start -->
* [43537580](https://news.social-protocols.org/stats?id=43537580) #6 -> [ICE deporting legal Permanent Residents, Refugees, and immigrants](https://www.rochesterfirst.com/rochester/ice-deporting-bhutanese-refugees/)<!-- HN:43537580:end --><!-- HN:43537624:start -->
* [43537624](https://news.social-protocols.org/stats?id=43537624) #20 2 points 0 comments -> [Chomsky: A "Study in Total Depravity"](http://bactra.org/chomsky.html)<!-- HN:43537624:end --><!-- HN:43498465:start -->
* [43498465](https://news.social-protocols.org/stats?id=43498465) #20 5 points 2 comments -> [A Man Who Went to Fake Prison Also Went to Real Jail](https://nymag.com/intelligencer/article/william-banks-comedian-jail.html)<!-- HN:43498465:end --><!-- HN:43537808:start -->
* [43537808](https://news.social-protocols.org/stats?id=43537808) #16 71 points 55 comments -> [The Average College Student Is Illiterate](https://www.persuasion.community/p/the-average-college-student-is-illiterate)<!-- HN:43537808:end -->
#### **Tuesday, April 1, 2025**<!-- HN:43541428:start -->
* [43541428](https://news.social-protocols.org/stats?id=43541428) #4 5 points 1 comments -> [Addressing Burnout – Libera Chat](https://libera.chat/news/burnout)<!-- HN:43541428:end --><!-- HN:43541926:start -->
* [43541926](https://news.social-protocols.org/stats?id=43541926) #26 4 points 1 comments -> [Tips for Travelers Entering the U.S. Now: Check Your Visa, Turn Off Your Phone](https://www.nytimes.com/2025/03/31/travel/us-travel-border-customs-visa-trump.html)<!-- HN:43541926:end --><!-- HN:43542151:start -->
* [43542151](https://news.social-protocols.org/stats?id=43542151) #21 -> [The Demand Side of Democratic Backsliding](https://www.cambridge.org/core/journals/british-journal-of-political-science/article/demand-side-of-democratic-backsliding-how-divergent-understandings-of-democracy-shape-political-choice/3DEB0DC344DF35BF4334366F07411116)<!-- HN:43542151:end --><!-- HN:43543492:start -->
* [43543492](https://news.social-protocols.org/stats?id=43543492) #5 5 points 0 comments -> [ØNTHR The World’s First Perfect Guaranteed $0.00 Stablecoin](https://netherzero.com/)<!-- HN:43543492:end --><!-- HN:43543881:start -->
* [43543881](https://news.social-protocols.org/stats?id=43543881) #24 1 points 0 comments -> [Goodbye Offpunk, Welcome XKCDpunk](https://ploum.net/2025-04-01-xkcdpunk.html)<!-- HN:43543881:end --><!-- HN:43517243:start -->
* [43517243](https://news.social-protocols.org/stats?id=43517243) #19 7 points 0 comments -> [Open-source browser-use/CUA equivalent for androids: mobile-use](https://github.com/runablehq/mobile-use)<!-- HN:43517243:end --><!-- HN:43546647:start -->
* [43546647](https://news.social-protocols.org/stats?id=43546647) #29 3 points 0 comments -> [Torrent Site Uploader and Member of 'The Scene' Sentenced to Prison in Denmark](https://torrentfreak.com/torrent-site-uploader-and-member-of-the-scene-sentenced-to-prison-in-denmark-250324/)<!-- HN:43546647:end --><!-- HN:43546669:start -->
* [43546669](https://news.social-protocols.org/stats?id=43546669) #7 -> [The Turd Reich [pdf]](https://mcusercontent.com/bd36014b9888db9081d204e78/files/4bd4265d-d050-c94b-d38b-311ec25db977/the_turd_reich_A0_.01.pdf)<!-- HN:43546669:end --><!-- HN:43548454:start -->
* [43548454](https://news.social-protocols.org/stats?id=43548454) #10 5 points 1 comments -> [Show HN: Switch 5 less apps a day using this iPhone app](https://medium.com/@saipremtelkar/switch-5-less-apps-a-day-using-this-iphone-app-a0b312433404)<!-- HN:43548454:end --><!-- HN:43516824:start -->
* [43516824](https://news.social-protocols.org/stats?id=43516824) #15 5 points 0 comments -> [Exploring Anagram Search in PostgreSQL with Recursive CTEs](https://medium.com/@thibaut.frain/exploring-anagram-search-in-postgresql-with-recursive-ctes-7b0c42c59d28)<!-- HN:43516824:end --><!-- HN:43520005:start -->
* [43520005](https://news.social-protocols.org/stats?id=43520005) #26 24 points 40 comments -> [Chess324 – A Chess Variant to Reduce Draws](https://www.chessprogramming.org/Chess324)<!-- HN:43520005:end -->
#### **Wednesday, April 2, 2025**
<!-- HN:43533104:start -->
* [43533104](https://news.social-protocols.org/stats?id=43533104) #20 8 points 2 comments -> [The March of the Vegetables Parade](http://www.marchofthevegetables.org)<!-- HN:43533104:end --><!-- HN:43552884:start -->
* [43552884](https://news.social-protocols.org/stats?id=43552884) #15 -> [Show HN: Fuck Lightroom and Fuck Adobe: How Adobe Is Systematically Predatory](https://fucklightroom.com/blog)<!-- HN:43552884:end --><!-- HN:43553134:start -->
* [43553134](https://news.social-protocols.org/stats?id=43553134) #17 16 points 3 comments -> [After Crash FAA Change Requires All Aircraft at Reagan to Broadcast Positions](https://www.nytimes.com/2025/03/27/us/politics/reagan-crash-faa-rule-change-broadcast-positions.html)<!-- HN:43553134:end --><!-- HN:43553271:start -->
* [43553271](https://news.social-protocols.org/stats?id=43553271) #30 5 points 1 comments -> [Call for testing: OpenSSH 10.0 (DSA support removed)](https://lists.mindrot.org/pipermail/openssh-unix-dev/2025-April/041855.html)<!-- HN:43553271:end --><!-- HN:43554064:start -->
* [43554064](https://news.social-protocols.org/stats?id=43554064) #10 25 points 40 comments -> [Travel Guide for Stateless People](https://taejun.substack.com/p/travel-guide-for-stateless-people)<!-- HN:43554064:end --><!-- HN:43555724:start -->
* [43555724](https://news.social-protocols.org/stats?id=43555724) #4 63 points 15 comments -> [An 'administrative error' sent a Maryland man to an El Salvador prison](https://apnews.com/article/el-salvador-deportation-maryland-man-trump-error-818a0fa1218de714448edcb5be1f7347)<!-- HN:43555724:end --><!-- HN:43555814:start -->
* [43555814](https://news.social-protocols.org/stats?id=43555814) #2 32 points 37 comments -> [Don't Bother with Vibe Coding](https://www.soeren.codes/articles/do-not-bother-with-vibe-coding)<!-- HN:43555814:end --><!-- HN:43556281:start -->
* [43556281](https://news.social-protocols.org/stats?id=43556281) #9 11 points 2 comments -> [Mike Waltz Used Personal Gmail for Government Communications: Report](https://www.newsweek.com/mike-waltz-used-personal-gmail-government-communications-report-2053863)<!-- HN:43556281:end --><!-- HN:43556463:start -->
* [43556463](https://news.social-protocols.org/stats?id=43556463) #12 42 points 9 comments -> [Tesla (TSLA) announces 336,681 deliveries, far worse than expected](https://electrek.co/2025/04/02/tesla-tsla-q1-deliveries-worse/)<!-- HN:43556463:end --><!-- HN:43556443:start -->
* [43556443](https://news.social-protocols.org/stats?id=43556443) #5 41 points 11 comments -> [Tesla suffers worst quarter since 2022 as deliveries tumble](https://www.ft.com/content/0ebcec51-2a5a-4820-99e8-1e500370fd68)<!-- HN:43556443:end --><!-- HN:43556355:start -->
* [43556355](https://news.social-protocols.org/stats?id=43556355) #12 9 points 4 comments -> [What I would do if I was 18 now](https://levels.io/eighteen/)<!-- HN:43556355:end --><!-- HN:43556344:start -->
* [43556344](https://news.social-protocols.org/stats?id=43556344) #5 7 points 4 comments -> [Starlink sets up subsidiary in Faroe Islands](https://dimma.fo/grein/starlink-vil-veita-internet-i-foroyum-stovnadu-foroyskt-smapartafelag)<!-- HN:43556344:end --><!-- HN:43556624:start -->
* [43556624](https://news.social-protocols.org/stats?id=43556624) #16 8 points 3 comments -> [American shakedown: Police won't charge you, but they'll grab your money](https://www.cbc.ca/news/world/american-shakedown-police-won-t-charge-you-but-they-ll-grab-your-money-1.2760736)<!-- HN:43556624:end --><!-- HN:43556841:start -->
* [43556841](https://news.social-protocols.org/stats?id=43556841) #18 3 points 0 comments -> [Anyone who trusts an AI therapist needs their head examined](https://pluralistic.net/2025/04/01/doctor-robo-blabbermouth/)<!-- HN:43556841:end --><!-- HN:43557655:start -->
* [43557655](https://news.social-protocols.org/stats?id=43557655) #23 3 points 1 comments -> [Global scam industry evolving at 'unprecedented scale' despite recent crackdown](https://www.cnn.com/2025/04/02/asia/myanmar-scam-center-crackdown-intl-hnk-dst/index.html)<!-- HN:43557655:end --><!-- HN:43558242:start -->
* [43558242](https://news.social-protocols.org/stats?id=43558242) #13 12 points 2 comments -> [Amazon Said to Make a Bid to Buy TikTok in the U.S.](https://www.nytimes.com/2025/04/02/business/media/amazon-tiktok-bid.html)<!-- HN:43558242:end --><!-- HN:43558095:start -->
* [43558095](https://news.social-protocols.org/stats?id=43558095) #29 5 points 0 comments -> [We Need to Rename ADHD (2021)](https://www.scientificamerican.com/article/we-need-to-rename-adhd/)<!-- HN:43558095:end --><!-- HN:43531816:start -->
* [43531816](https://news.social-protocols.org/stats?id=43531816) #29 32 points 16 comments -> [You're protecting your data wrong – Introducing the Protected Query Pattern](https://kilpi.vercel.app/blog/2025-03-27-introducing-the-protected-query-pattern/)<!-- HN:43531816:end --><!-- HN:43558777:start -->
* [43558777](https://news.social-protocols.org/stats?id=43558777) #23 5 points 1 comments -> [PayPal launches remote and local MCP servers](https://developer.paypal.com/limited-release/agents/)<!-- HN:43558777:end --><!-- HN:43559265:start -->
* [43559265](https://news.social-protocols.org/stats?id=43559265) #28 3 points 0 comments -> [Waymo's Foundation Model for Autonomous Driving with Drago Anguelov [video]](https://www.youtube.com/watch?v=oNKt1yhY4GY)<!-- HN:43559265:end --><!-- HN:43558352:start -->
* [43558352](https://news.social-protocols.org/stats?id=43558352) #16 34 points 21 comments -> [Bare: Run JavaScript Everywhere](https://pears.com/news/introducing-bare-actually-run-javascript-everywhere/)<!-- HN:43558352:end --><!-- HN:43560751:start -->
* [43560751](https://news.social-protocols.org/stats?id=43560751) #9 14 points 22 comments -> [It's Unreal Just How Awful 'Real ID' Is (2020)](https://www.zocalopublicsquare.org/real-id-is-awful/)<!-- HN:43560751:end --><!-- HN:43562005:start -->
* [43562005](https://news.social-protocols.org/stats?id=43562005) #24 38 points 25 comments -> [Wikipedia, says its bandwidth costs have gone up 50% since Jan 2024](https://bsky.app/profile/cameronwilson.bsky.social/post/3llt2a6b3bu2v)<!-- HN:43562005:end -->
#### **Thursday, April 3, 2025**
<!-- HN:43563608:start -->
* [43563608](https://news.social-protocols.org/stats?id=43563608) #28 13 points 4 comments -> [Australian beef singled out in latest USA tariffs](https://www.abc.net.au/news/2025-04-03/australian-beef-singled-out-in-donald-trumps-liberation-tariffs/105120998)<!-- HN:43563608:end --><!-- HN:43563389:start -->
* [43563389](https://news.social-protocols.org/stats?id=43563389) #27 6 points 3 comments -> [Show HN: OpenTariffs – Tariff Percentages by Country](https://opentariffs.fyi/)<!-- HN:43563389:end --><!-- HN:43527933:start -->
* [43527933](https://news.social-protocols.org/stats?id=43527933) #23 8 points 0 comments -> [The Carbon Bankroll 2.0 [pdf] (2024)](https://static1.squarespace.com/static/651da9cd0ad7706a768d14db/t/66024d827623d72ef543b545/1711426949213/The+Carbon+Bankroll+2.0+-+From+Awareness+to+Action+%28final%29.pdf)<!-- HN:43527933:end --><!-- HN:43569636:start -->
* [43569636](https://news.social-protocols.org/stats?id=43569636) #19 10 points 0 comments -> [Decapitation Strike](https://snyder.substack.com/p/decapitation-strike)<!-- HN:43569636:end --><!-- HN:43570859:start -->
* [43570859](https://news.social-protocols.org/stats?id=43570859) #7 5 points 0 comments -> [I Hired 5 People to Sit Behind Me and Make Me Productive for a Month](https://www.simonberens.com/p/i-hired-5-people-to-sit-behind-me)<!-- HN:43570859:end --><!-- HN:43573774:start -->
* [43573774](https://news.social-protocols.org/stats?id=43573774) #19 12 points 1 comments -> [US tariff protection decimated American shipbuilding; could do same to cleanTech](https://grist.org/economics/how-trumps-liberation-day-tariffs-could-kill-american-innovation/)<!-- HN:43573774:end -->
#### **Friday, April 4, 2025**
<!-- HN:43578310:start -->
* [43578310](https://news.social-protocols.org/stats?id=43578310) #17 77 points 34 comments -> [Anduril Industries banned from recruiting on NixOS forums](https://discourse.nixos.org/t/anduril-industries-electromagnetic-warfare-team-is-hiring/62569)<!-- HN:43578310:end --><!-- HN:43579197:start -->
* [43579197](https://news.social-protocols.org/stats?id=43579197) #11 16 points 1 comments -> [Apple killed Asahi Linux with M4 update](https://social.treehouse.systems/@sven/114278224116678776)<!-- HN:43579197:end --><!-- HN:43533554:start -->
* [43533554](https://news.social-protocols.org/stats?id=43533554) #10 46 points 29 comments -> [My Rust experience after eight years](https://codecs.multimedia.cx/2025/03/my-rust-experience-after-eight-years/)<!-- HN:43533554:end --><!-- HN:43580920:start -->
* [43580920](https://news.social-protocols.org/stats?id=43580920) #20 13 points 12 comments -> [When I converted my home from gas to electric my utility bills nearly doubled](https://www.washingtonpost.com/home/2025/04/02/electric-power-home-conversion/)<!-- HN:43580920:end --><!-- HN:43580814:start -->
* [43580814](https://news.social-protocols.org/stats?id=43580814) #29 17 points 3 comments -> [America's astonishing act of self-harm](https://www.ft.com/content/21454c08-8e1c-4335-84f9-ef2d0e1aeb14)<!-- HN:43580814:end --><!-- HN:43580439:start -->
* [43580439](https://news.social-protocols.org/stats?id=43580439) #10 69 points 25 comments -> [I just want to serve 5 terabytes [video]](https://www.youtube.com/watch?v=3t6L-FlfeaI)<!-- HN:43580439:end --><!-- HN:43581768:start -->
* [43581768](https://news.social-protocols.org/stats?id=43581768) #19 15 points 6 comments -> [Rubio Orders U.S. Diplomats to Scour Student Visa Applicants' Social Media](https://www.nytimes.com/2025/04/01/us/politics/student-visas-social-media.html)<!-- HN:43581768:end --><!-- HN:43537551:start -->
* [43537551](https://news.social-protocols.org/stats?id=43537551) #10 7 points 1 comments -> [End of Life for Akamai Identity Cloud](https://techdocs.akamai.com/identity-cloud/docs/product-status)<!-- HN:43537551:end --><!-- HN:43584714:start -->
* [43584714](https://news.social-protocols.org/stats?id=43584714) #12 31 points 45 comments -> [How the 2025 US Financial Crisis is Different than 2008](https://samhenrycliff.medium.com/how-the-2025-us-financial-crisis-is-different-than-2008-5b63bdd06067)<!-- HN:43584714:end --><!-- HN:43585713:start -->
* [43585713](https://news.social-protocols.org/stats?id=43585713) #15 4 points 1 comments -> [NASA astronaut reveals they nearly failed to dock Boeing Starliner to the ISS](https://www.foxnews.com/us/nasa-astronaut-reveals-nearly-failed-dock-boeing-starliner-international-space-station)<!-- HN:43585713:end --><!-- HN:43585921:start -->
* [43585921](https://news.social-protocols.org/stats?id=43585921) #27 15 points 0 comments -> [Cyber Forensic Expert in 2k Cases Faces FBI Probe](https://krebsonsecurity.com/2025/04/cyber-forensic-expert-in-2000-cases-faces-fbi-probe/)<!-- HN:43585921:end --><!-- HN:43586647:start -->
* [43586647](https://news.social-protocols.org/stats?id=43586647) #25 4 points 0 comments -> [An AI avatar tried to argue a case before a New York court](https://apnews.com/article/artificial-intelligence-ai-courts-nyc-5c97cba3f3757d9ab3c2e5840127f765)<!-- HN:43586647:end --><!-- HN:43586436:start -->
* [43586436](https://news.social-protocols.org/stats?id=43586436) #22 5 points 1 comments -> [America's 'Tree of Life' is nearing the end of its life](https://www.sfgate.com/national-parks/article/olympic-national-park-tree-of-life-collapse-20240943.php)<!-- HN:43586436:end --><!-- HN:43586742:start -->
* [43586742](https://news.social-protocols.org/stats?id=43586742) #30 6 points 1 comments -> [Fedora CoreOS adds Hetzner provisioning](https://docs.fedoraproject.org/en-US/fedora-coreos/provisioning-hetzner/)<!-- HN:43586742:end --><!-- HN:43586811:start -->
* [43586811](https://news.social-protocols.org/stats?id=43586811) #7 17 points 3 comments -> [The Spanish electricity market registers negative prices](https://aleasoft.com/negative-prices-spanish-electricity-market/)<!-- HN:43586811:end --><!-- HN:43587611:start -->
* [43587611](https://news.social-protocols.org/stats?id=43587611) #18 37 points 40 comments -> [Wall Street Blew It](https://www.theatlantic.com/ideas/archive/2025/04/wall-street-trump-tariffs/682304/)<!-- HN:43587611:end --><!-- HN:43587577:start -->
* [43587577](https://news.social-protocols.org/stats?id=43587577) #14 3 points 1 comments -> [Everyone is pulling ML models from HuggingFace, here's what can go wrong](https://repello.ai/blog/securing-machine-learning-models-a-comprehensive-guide-to-model-scanning)<!-- HN:43587577:end -->
#### **Saturday, April 5, 2025**
<!-- HN:43590616:start -->
* [43590616](https://news.social-protocols.org/stats?id=43590616) #23 15 points 2 comments -> [Fox News Removes Stock Ticker for First Time in 28 Years](https://blogaura.ai/view/qm751lrwuzn)<!-- HN:43590616:end --><!-- HN:43590649:start -->
* [43590649](https://news.social-protocols.org/stats?id=43590649) #3 7 points 1 comments -> [Message stuck in Kafka queue for months delivered, writes bestselling novel](https://nareal.substack.com/p/message-stuck-in-kafka-queue-for)<!-- HN:43590649:end --><!-- HN:43590421:start -->
* [43590421](https://news.social-protocols.org/stats?id=43590421) #15 165 points 83 comments -> [Trump's Tariff Formula Makes No Economic Sense. It's Also Based on an Error](https://www.aei.org/economics/president-trumps-tariff-formula-makes-no-economic-sense-its-also-based-on-an-error/)<!-- HN:43590421:end --><!-- HN:43590570:start -->
* [43590570](https://news.social-protocols.org/stats?id=43590570) #22 18 points 10 comments -> [Coqui TTS: Free Text-to-Speech](https://coquitts.com)<!-- HN:43590570:end --><!-- HN:43589119:start -->
* [43589119](https://news.social-protocols.org/stats?id=43589119) #23 68 points 13 comments -> [404s – gallery of error 404 page designs](https://www.404s.design/)<!-- HN:43589119:end --><!-- HN:43592406:start -->
* [43592406](https://news.social-protocols.org/stats?id=43592406) #30 11 points 3 comments -> [Tariffs Can Help America](https://www.foreignaffairs.com/united-states/how-tariffs-can-help-america)<!-- HN:43592406:end --><!-- HN:43593226:start -->
* [43593226](https://news.social-protocols.org/stats?id=43593226) #11 7 points 0 comments -> [Red Crescent Worker Who Survived Israeli Massacre Recounts Horror](https://www.dropsitenews.com/p/red-crescent-massacre-gaza-israel)<!-- HN:43593226:end --><!-- HN:43592400:start -->
* [43592400](https://news.social-protocols.org/stats?id=43592400) #20 46 points 11 comments -> [Major endometriosis study reveals impact of gluten, coffee, dairy and alcohol](https://www.theguardian.com/society/2025/apr/05/major-endometriosis-study-reveals-impact-of-gluten-coffee-dairy-and-alcohol)<!-- HN:43592400:end --><!-- HN:43593332:start -->
* [43593332](https://news.social-protocols.org/stats?id=43593332) #19 4 points 0 comments -> [I was a British tourist trying to leave America. Then I was detained, shackled](https://www.theguardian.com/us-news/2025/apr/05/i-was-a-british-tourist-trying-to-leave-america-then-i-was-detained-shackled-and-sent-to-an-immigration-detention-centre)<!-- HN:43593332:end --><!-- HN:43595858:start -->
* [43595858](https://news.social-protocols.org/stats?id=43595858) #8 45 points 1 comments -> [The Llama 4 Herd](https://ai.meta.com/blog/llama-4-multimodal-intelligence/?_fb_noscript=1)<!-- HN:43595858:end --><!-- HN:43595656:start -->
* [43595656](https://news.social-protocols.org/stats?id=43595656) #15 6 points 4 comments -> [A Hash160 Collision](https://lbc.cryptoguru.org/man/theory)<!-- HN:43595656:end --><!-- HN:43556029:start -->
* [43556029](https://news.social-protocols.org/stats?id=43556029) #18 9 points 0 comments -> [Practical Binary Analysis](https://practicalbinaryanalysis.com)<!-- HN:43556029:end --><!-- HN:43597343:start -->
* [43597343](https://news.social-protocols.org/stats?id=43597343) #21 15 points 0 comments -> [Christine Lagarde wants EU to ditch Visa, Mastercard for own platform](https://www.businesstoday.in/world/us/story/march-to-independence-christine-lagarde-wants-eu-to-ditch-visa-mastercard-for-own-platform-470816-2025-04-05)<!-- HN:43597343:end -->
#### **Sunday, April 6, 2025**<!-- HN:43597836:start -->
* [43597836](https://news.social-protocols.org/stats?id=43597836) #25 -> [Silence Is Collaboration: Academics Must Speak Out Against Fascism](https://lithub.com/silence-is-collaboration-academics-must-speak-out-against-fascism/)<!-- HN:43597836:end --><!-- HN:43573453:start -->
* [43573453](https://news.social-protocols.org/stats?id=43573453) #17 13 points 10 comments -> [Show HN: Owl, a Spaced Repetition App](https://owl.cards)<!-- HN:43573453:end --><!-- HN:43599864:start -->
* [43599864](https://news.social-protocols.org/stats?id=43599864) #10 26 points 1 comments -> [Video footage appears to contradict Israeli account of Gaza medic killings](https://www.bbc.com/news/articles/c4g2z103nqxo)<!-- HN:43599864:end -->