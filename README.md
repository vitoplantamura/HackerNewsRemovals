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

#### **Monday, October 7, 2024**
<!-- HN:41761797:start -->
* [41761797](https://news.social-protocols.org/stats?id=41761797) #5 7 points 3 comments -> [Proven Risks of Refillable Soap Dispensers](https://www.gojo.com/en/Newsroom/Blog/2023/Proven-Risks-of-Refillable-Soap-Dispensers)<!-- HN:41761797:end --><!-- HN:41762500:start -->
* [41762500](https://news.social-protocols.org/stats?id=41762500) #21 22 points 4 comments -> [Scarlet Rot: a biological exploration of Elden Ring's decaying disease](https://jgeekstudies.org/2024/10/06/scarlet-rot-a-biological-exploration-of-elden-rings-decaying-disease/)<!-- HN:41762500:end --><!-- HN:41761511:start -->
* [41761511](https://news.social-protocols.org/stats?id=41761511) #23 69 points 10 comments -> [The SQLite Amalgamation](https://www.sqlite.org/amalgamation.html)<!-- HN:41761511:end --><!-- HN:41761900:start -->
* [41761900](https://news.social-protocols.org/stats?id=41761900) #30 11 points 5 comments -> [Future Halo Titles to Use Unreal Engine](https://www.halowaypoint.com/news/a-new-dawn)<!-- HN:41761900:end --><!-- HN:41762397:start -->
* [41762397](https://news.social-protocols.org/stats?id=41762397) #22 94 points 50 comments -> [Nintendo isn't just attacking emulators [video]](https://www.youtube.com/watch?v=sk6MK5Wpx4o)<!-- HN:41762397:end --><!-- HN:41758644:start -->
* [41758644](https://news.social-protocols.org/stats?id=41758644) #18 138 points 42 comments -> [Popular Science Magazine Archives, May 1872-March 2009](https://books.google.com/books/about/Popular_Science.html?id=qR8DAAAAMBAJ)<!-- HN:41758644:end --><!-- HN:41749288:start -->
* [41749288](https://news.social-protocols.org/stats?id=41749288) #30 60 points 15 comments -> [Compiling and running sqlite3-rsync from a branch](https://til.simonwillison.net/sqlite/compile-sqlite3-rsync)<!-- HN:41749288:end --><!-- HN:41760421:start -->
* [41760421](https://news.social-protocols.org/stats?id=41760421) #30 232 points 294 comments -> [Rust needs a web framework](https://ntietz.com/blog/rust-needs-a-web-framework-for-lazy-developers/)<!-- HN:41760421:end --><!-- HN:41767383:start -->
* [41767383](https://news.social-protocols.org/stats?id=41767383) #24 5 points 0 comments -> [Why trolls, extremists, and others spread conspiracy theories they don't believe](https://theconversation.com/some-online-conspiracy-spreaders-dont-even-believe-the-lies-theyre-spewing-237730)<!-- HN:41767383:end --><!-- HN:41768259:start -->
* [41768259](https://news.social-protocols.org/stats?id=41768259) #28 4 points 1 comments -> [AI will use a lot of energy. That's good for the climate](https://climate.benjames.io/ai-go-brrr/)<!-- HN:41768259:end --><!-- HN:41768752:start -->
* [41768752](https://news.social-protocols.org/stats?id=41768752) #5 44 points 6 comments -> [Decoding Bitcoin: An interactive, exercise-heavy approach to learning Bitcoin](https://bitcoindevs.xyz/decoding)<!-- HN:41768752:end --><!-- HN:41767279:start -->
* [41767279](https://news.social-protocols.org/stats?id=41767279) #26 13 points 16 comments -> [Hot Take: Don'T provide incident resolution estimates](https://firehydrant.com/blog/hot-take-dont-provide-incident-resolution-estimates/)<!-- HN:41767279:end -->
#### **Tuesday, October 8, 2024**
<!-- HN:41772683:start -->
* [41772683](https://news.social-protocols.org/stats?id=41772683) #2 7 points 0 comments -> [I immersed myself in furry culture. You don't understand them](https://www.michigandaily.com/statement/i-immersed-myself-in-furry-culture-you-dont-understand-them/)<!-- HN:41772683:end --><!-- HN:41772662:start -->
* [41772662](https://news.social-protocols.org/stats?id=41772662) #28 12 points 2 comments -> [Satyagraha: The Highest Practise of Democracy and Freedom](https://journals.sagepub.com/doi/full/10.1177/0049085721993160)<!-- HN:41772662:end --><!-- HN:41727005:start -->
* [41727005](https://news.social-protocols.org/stats?id=41727005) #17 81 points 58 comments -> [Solving the Maker-Taker Problem](https://dri.es/solving-the-maker-taker-problem)<!-- HN:41727005:end --><!-- HN:41774300:start -->
* [41774300](https://news.social-protocols.org/stats?id=41774300) #22 3 points 1 comments -> [Cognizant Discriminated Against Non-Indian Workers, US Jury Says](https://www.bloomberg.com/news/articles/2024-10-08/cognizant-discriminated-against-non-indian-workers-us-jury-says)<!-- HN:41774300:end --><!-- HN:41774268:start -->
* [41774268](https://news.social-protocols.org/stats?id=41774268) #26 5 points 4 comments -> [I just signed up for Twilio Sendgrid, and got instantly permabanned](https://www.twilio.com/en-us/sendgrid/email-api)<!-- HN:41774268:end --><!-- HN:41775521:start -->
* [41775521](https://news.social-protocols.org/stats?id=41775521) #6 18 points 2 comments -> [Nobel Prize goes to John Hopfield and Geoffrey Hinton work on machine learning](https://www.bbc.co.uk/news/articles/c62r02z75jyo)<!-- HN:41775521:end --><!-- HN:41769648:start -->
* [41769648](https://news.social-protocols.org/stats?id=41769648) #10 143 points 46 comments -> [Wigle.net: All the networks, found by everyone](https://wigle.net/)<!-- HN:41769648:end --><!-- HN:41774001:start -->
* [41774001](https://news.social-protocols.org/stats?id=41774001) #11 28 points 7 comments -> [Show HN: Running Game Boy ROMs on the STM32 ARM Cortex Microcontroller](https://github.com/jnz/stm32boy)<!-- HN:41774001:end --><!-- HN:41768658:start -->
* [41768658](https://news.social-protocols.org/stats?id=41768658) #21 424 points 191 comments -> [US antitrust case against Amazon to move forward](https://www.reuters.com/technology/us-antitrust-case-against-amazon-move-forward-2024-10-07/)<!-- HN:41768658:end --><!-- HN:41767644:start -->
* [41767644](https://news.social-protocols.org/stats?id=41767644) #17 165 points 63 comments -> [Show HN: Compiling C in the browser using WebAssembly](https://wasmer.io/posts/clang-in-browser)<!-- HN:41767644:end --><!-- HN:41773096:start -->
* [41773096](https://news.social-protocols.org/stats?id=41773096) #18 24 points 15 comments -> [Rust GPU: The future of GPU programming](https://rust-gpu.github.io/)<!-- HN:41773096:end --><!-- HN:41769346:start -->
* [41769346](https://news.social-protocols.org/stats?id=41769346) #21 91 points 2 comments -> [EuroBSDcon 2024: Some notes after the conference](https://blog.netbsd.org/tnf/entry/eurobsdcon_2024_in_dublin_ireland)<!-- HN:41769346:end --><!-- HN:41775872:start -->
* [41775872](https://news.social-protocols.org/stats?id=41775872) #29 9 points 0 comments -> [Tesla Cybertruck 'too big and sharp' for European roads, say campaigners](https://www.theguardian.com/technology/2024/oct/08/tesla-cybertruck-too-big-and-sharp-for-european-roads-say-campaigners)<!-- HN:41775872:end --><!-- HN:41769932:start -->
* [41769932](https://news.social-protocols.org/stats?id=41769932) #21 81 points 13 comments -> [Gunter's Space Page](https://space.skyrocket.de/index.html)<!-- HN:41769932:end --><!-- HN:41775795:start -->
* [41775795](https://news.social-protocols.org/stats?id=41775795) #25 11 points 7 comments -> [US House panel probes FCC decision to deny Starlink nearly $900M](https://www.reuters.com/technology/us-house-panel-probes-fcc-decision-deny-starlink-nearly-900-million-2024-10-07/)<!-- HN:41775795:end --><!-- HN:41775592:start -->
* [41775592](https://news.social-protocols.org/stats?id=41775592) #26 10 points 0 comments -> [Generation Never-Called-in-Sick](https://www.businessinsider.com/baby-boomers-gen-z-sick-days-time-off-work-regret-2024-9)<!-- HN:41775592:end --><!-- HN:41777301:start -->
* [41777301](https://news.social-protocols.org/stats?id=41777301) #11 20 points 3 comments -> [Geoffrey Hinton and John Hopfield win Nobel Prize in physics](https://www.theguardian.com/science/2024/oct/08/nobel-prize-physics-john-hopfield-geoffrey-hinton-machine-learning)<!-- HN:41777301:end --><!-- HN:41777803:start -->
* [41777803](https://news.social-protocols.org/stats?id=41777803) #13 8 points 2 comments -> [Let's prepare for life without Twitter](https://www.prweek.com/article/1890974/lets-prepare-life-without-twitter)<!-- HN:41777803:end --><!-- HN:41778249:start -->
* [41778249](https://news.social-protocols.org/stats?id=41778249) #4 2 points 0 comments -> [Replit's Path to Product-Market Fit–The $1B Side Project](https://review.firstround.com/replits-path-to-product-market-fit/)<!-- HN:41778249:end --><!-- HN:41731536:start -->
* [41731536](https://news.social-protocols.org/stats?id=41731536) #11 56 points 11 comments -> [Canon plans to disrupt chipmaking with low-cost "stamp" machine](https://arstechnica.com/reviews/2024/01/canon-plans-to-disrupt-chipmaking-with-low-cost-stamp-machine/)<!-- HN:41731536:end --><!-- HN:41778866:start -->
* [41778866](https://news.social-protocols.org/stats?id=41778866) #21 6 points 5 comments -> [How to get started in Graphics Programming in 2024?](https://twitter.com/rainbowpikmin/status/1842967087809237119)<!-- HN:41778866:end --><!-- HN:41776988:start -->
* [41776988](https://news.social-protocols.org/stats?id=41776988) #19 56 points 62 comments -> [PSA: Don't use iPhone Mirroring on your work computer](https://www.sevcosecurity.com/iphone-mirroring-expose-employee-personal-information/)<!-- HN:41776988:end --><!-- HN:41782516:start -->
* [41782516](https://news.social-protocols.org/stats?id=41782516) #3 18 points 5 comments -> [Do you want to measure signal from the body, muscle, brain it is open-source](https://www.preprints.org/manuscript/202409.1703/v1)<!-- HN:41782516:end --><!-- HN:41782415:start -->
* [41782415](https://news.social-protocols.org/stats?id=41782415) #24 8 points 1 comments -> [VA congressional candidate creates AI chatbot as debate stand-in for incumbent](https://www.reuters.com/world/us/virginia-congressional-candidate-creates-ai-chatbot-debate-stand-in-incumbent-2024-10-08/)<!-- HN:41782415:end --><!-- HN:41781570:start -->
* [41781570](https://news.social-protocols.org/stats?id=41781570) #26 23 points 3 comments -> [Boeing at Risk of Junk Rating with S&P Amid Strike](https://www.bloomberg.com/news/articles/2024-10-08/boeing-at-risk-of-junk-credit-rating-with-s-p-as-strike-goes-on)<!-- HN:41781570:end --><!-- HN:41779984:start -->
* [41779984](https://news.social-protocols.org/stats?id=41779984) #30 14 points 2 comments -> [Caveman Debugging in the Modern Age](https://theapache64.github.io/posts/caveman-debugging-using-live-templates/)<!-- HN:41779984:end -->
#### **Wednesday, October 9, 2024**
<!-- HN:41783609:start -->
* [41783609](https://news.social-protocols.org/stats?id=41783609) #20 10 points 8 comments -> [Bitcoin creator is Peter Todd, HBO film says](https://www.politico.eu/article/peter-todd-bitcoin-creator-cullen-hoback-hbo-cryptocurrency-satoshi-nakamoto/)<!-- HN:41783609:end --><!-- HN:41783787:start -->
* [41783787](https://news.social-protocols.org/stats?id=41783787) #2 98 points 65 comments -> [The human internet is dying. AI images are taking over Google top results](https://old.reddit.com/r/ChatGPT/comments/1fye6tb/the_human_internet_is_dying_ai_images_taking_over/)<!-- HN:41783787:end --><!-- HN:41784138:start -->
* [41784138](https://news.social-protocols.org/stats?id=41784138) #7 7 points 4 comments -> [DOJ's proposals risk hurting consumers, businesses, and developers](https://blog.google/outreach-initiatives/public-policy/doj-search-remedies-framework/)<!-- HN:41784138:end --><!-- HN:41784332:start -->
* [41784332](https://news.social-protocols.org/stats?id=41784332) #20 4 points 0 comments -> [Seeed Studio XIAO RP2040 with NuttX(RTOS)](https://wiki.seeedstudio.com/xiao-rp2040-with-nuttx/)<!-- HN:41784332:end --><!-- HN:41787177:start -->
* [41787177](https://news.social-protocols.org/stats?id=41787177) #18 5 points 0 comments -> [Know their names – Palestinian families killed in Israeli attacks on Gaza](https://www.aljazeera.com/news/longform/2024/10/8/know-their-names-palestinian-families-killed-in-israeli-attacks-on-gaza)<!-- HN:41787177:end --><!-- HN:41786012:start -->
* [41786012](https://news.social-protocols.org/stats?id=41786012) #22 95 points 73 comments -> [A free and open internet shouldn't come at the expense of privacy](https://blog.mozilla.org/en/mozilla/digital-advertising-privacy/)<!-- HN:41786012:end --><!-- HN:41784668:start -->
* [41784668](https://news.social-protocols.org/stats?id=41784668) #29 90 points 78 comments -> [Why the ISO format has to die](https://easyos.org/about/why-the-iso-format-has-to-die.html)<!-- HN:41784668:end --><!-- HN:41759175:start -->
* [41759175](https://news.social-protocols.org/stats?id=41759175) #19 4 points 0 comments -> [HN in Your Language with Real-Time Generated Highlights](https://zeli.app)<!-- HN:41759175:end --><!-- HN:41787804:start -->
* [41787804](https://news.social-protocols.org/stats?id=41787804) #6 4 points 1 comments -> [Chris.lu: How I Used Next.js and MDX to create a modern, static-first Blog](https://chris.lu)<!-- HN:41787804:end --><!-- HN:41786457:start -->
* [41786457](https://news.social-protocols.org/stats?id=41786457) #16 8 points 5 comments -> [Startup Guru Steve Blank Says AI Changes Everything](https://spectrum.ieee.org/steve-blank)<!-- HN:41786457:end --><!-- HN:41787290:start -->
* [41787290](https://news.social-protocols.org/stats?id=41787290) #11 61 points 53 comments -> [Google threatened with being broken up by US](https://www.bbc.com/news/articles/c62504lv00do)<!-- HN:41787290:end --><!-- HN:41763190:start -->
* [41763190](https://news.social-protocols.org/stats?id=41763190) #29 18 points 11 comments -> [You can create your own holiday](https://near.blog/unusual-holidays/)<!-- HN:41763190:end --><!-- HN:41788517:start -->
* [41788517](https://news.social-protocols.org/stats?id=41788517) #19 12 points 12 comments -> [Bankrupt Fisker says it can't migrate its EVs to a new owner's server](https://arstechnica.com/cars/2024/10/connected-car-failure-puts-kibosh-on-sale-of-3300-fisker-oceans/)<!-- HN:41788517:end --><!-- HN:41788290:start -->
* [41788290](https://news.social-protocols.org/stats?id=41788290) #22 6 points 3 comments -> [Show HN: Create AI Dialogue Podcasts](https://newspodcastdone.com)<!-- HN:41788290:end --><!-- HN:41790775:start -->
* [41790775](https://news.social-protocols.org/stats?id=41790775) #28 5 points 0 comments -> [Alaska utilities pursue renewables as costs escalate for fossil fuel electricity](https://www.seattletimes.com/seattle-news/climate-lab/alaska-utilities-turn-to-renewables-as-costs-escalate-for-fossil-fuel-electricity-generation/)<!-- HN:41790775:end --><!-- HN:41790762:start -->
* [41790762](https://news.social-protocols.org/stats?id=41790762) #25 6 points 0 comments -> [Free Software Foundation to serve on "artificial intelligence" safety consortium](https://www.fsf.org/news/fsf-serves-on-nist)<!-- HN:41790762:end --><!-- HN:41791658:start -->
* [41791658](https://news.social-protocols.org/stats?id=41791658) #11 4 points 1 comments -> [Are these 18 things all that's killing you?](https://domofutu.substack.com/p/these-18-things)<!-- HN:41791658:end --><!-- HN:41792880:start -->
* [41792880](https://news.social-protocols.org/stats?id=41792880) #1 41 points 2 comments -> [Internet Archive Hacked (Probably)](https://words.theresnotime.co.uk/2024/internet-archive-hacked-probably/)<!-- HN:41792880:end -->
#### **Thursday, October 10, 2024**
<!-- HN:41765009:start -->
* [41765009](https://news.social-protocols.org/stats?id=41765009) #28 19 points 6 comments -> [Is Android Unicode Yet?](https://shkspr.mobi/blog/2024/10/is-android-unicode-yet/)<!-- HN:41765009:end --><!-- HN:41794150:start -->
* [41794150](https://news.social-protocols.org/stats?id=41794150) #9 15 points 17 comments -> [The Case for Web Components: A Simpler, Framework-Free Future for the Web](https://blog.lnear.dev/the-case-for-web-components/)<!-- HN:41794150:end --><!-- HN:41742779:start -->
* [41742779](https://news.social-protocols.org/stats?id=41742779) #27 27 points 2 comments -> [Working Set Size Estimation (2018)](https://www.brendangregg.com/wss.html)<!-- HN:41742779:end --><!-- HN:41794912:start -->
* [41794912](https://news.social-protocols.org/stats?id=41794912) #26 28 points 40 comments -> [Electric vehicle safety via crash test](https://www.kbtx.com/2024/10/09/texas-am-tti-researches-electric-vehicle-safety-via-crash-test-jaws-hit-ground/)<!-- HN:41794912:end --><!-- HN:41797081:start -->
* [41797081](https://news.social-protocols.org/stats?id=41797081) #22 5 points 3 comments -> [The Internet Archive is under attack](https://www.theverge.com/2024/10/9/24266135/nintendo-original-alarm-clock-alarmo-prototypes)<!-- HN:41797081:end --><!-- HN:41797084:start -->
* [41797084](https://news.social-protocols.org/stats?id=41797084) #2 58 points 28 comments -> [All We Have in This World Is Ourselves](https://rxjourney.com.ng/all-we-really-have-in-this-world-is-ourselves)<!-- HN:41797084:end --><!-- HN:41792803:start -->
* [41792803](https://news.social-protocols.org/stats?id=41792803) #18 45 points 36 comments -> [Upgrading Homebrew and avoiding the "failed to verify attestation" error](https://til.simonwillison.net/homebrew/no-verify-attestations)<!-- HN:41792803:end --><!-- HN:41797048:start -->
* [41797048](https://news.social-protocols.org/stats?id=41797048) #28 7 points 6 comments -> [BBC Weather app bug suggests hurricane winds in UK](https://www.bbc.co.uk/news/articles/c0kjrp2rngzo)<!-- HN:41797048:end --><!-- HN:41763034:start -->
* [41763034](https://news.social-protocols.org/stats?id=41763034) #22 13 points 1 comments -> [What the (2021)](https://articles.foletta.org/post/2021-04-19-what-the/)<!-- HN:41763034:end --><!-- HN:41797724:start -->
* [41797724](https://news.social-protocols.org/stats?id=41797724) #12 8 points 0 comments -> [A utopian strand of economic thought is making a surprising comeback](https://www.vox.com/the-highlight/24065976/economists-post-scarcity-abundance-industrial-revolution-socialism-capitalism)<!-- HN:41797724:end --><!-- HN:41799011:start -->
* [41799011](https://news.social-protocols.org/stats?id=41799011) #5 12 points 5 comments -> [AAA Gaming on Asahi Linux](https://asahilinux.org/2024/10/aaa-gaming-on-asahi-linux/)<!-- HN:41799011:end --><!-- HN:41801795:start -->
* [41801795](https://news.social-protocols.org/stats?id=41801795) #25 24 points 13 comments -> [X will pay its Premium users to engage with each other](https://www.theverge.com/2024/10/9/24266258/x-pay-premium-users-engage-with-each-other)<!-- HN:41801795:end -->
#### **Friday, October 11, 2024**<!-- HN:41805515:start -->
* [41805515](https://news.social-protocols.org/stats?id=41805515) #13 10 points 10 comments -> [Tesla's Robotaxi event still not started after 40 minutes [video]](https://www.youtube.com/watch?v=6v6dbxPlsXs)<!-- HN:41805515:end --><!-- HN:41805628:start -->
* [41805628](https://news.social-protocols.org/stats?id=41805628) #1 -> [UFO announcement 'could happen within weeks' as expert says 'we found it'](https://www.irishstar.com/news/us-news/ufo-announcement-aliens-extraterrestrials-nasa-33865539)<!-- HN:41805628:end --><!-- HN:41805941:start -->
* [41805941](https://news.social-protocols.org/stats?id=41805941) #9 8 points 8 comments -> [The digits of pi are not random](https://github.com/seccode/pi)<!-- HN:41805941:end --><!-- HN:41766126:start -->
* [41766126](https://news.social-protocols.org/stats?id=41766126) #10 16 points 1 comments -> [Show HN: Daily puzzle game where you build a bridge of your own words (SolidJS)](https://bridj.link/)<!-- HN:41766126:end --><!-- HN:41807121:start -->
* [41807121](https://news.social-protocols.org/stats?id=41807121) #25 7 points 0 comments -> [I'm Running Out of Ways to Explain How Bad This Is](https://www.theatlantic.com/technology/archive/2024/10/hurricane-milton-conspiracies-misinformation/680221/)<!-- HN:41807121:end --><!-- HN:41806645:start -->
* [41806645](https://news.social-protocols.org/stats?id=41806645) #22 -> [Georgia county official dies after testifying about BioLab chemical plant fire](https://www.wabe.org/georgia-county-official-dies-after-testifying-about-conyers-biolab-chemical-plant-fire/)<!-- HN:41806645:end --><!-- HN:41805391:start -->
* [41805391](https://news.social-protocols.org/stats?id=41805391) #27 129 points 84 comments -> [WordPress Alternatives](https://darn.es/wordpress-alternatives/)<!-- HN:41805391:end --><!-- HN:41806714:start -->
* [41806714](https://news.social-protocols.org/stats?id=41806714) #26 18 points 2 comments -> [Tesla's Robotaxi day was a total Snoozefest](https://twitter.com/realdanodowd/status/1844605093368512799)<!-- HN:41806714:end --><!-- HN:41806852:start -->
* [41806852](https://news.social-protocols.org/stats?id=41806852) #8 14 points 5 comments -> [Show HN: I made a football/soccer formation and squad app](https://apps.apple.com/au/app/football-formation/id6683308607)<!-- HN:41806852:end --><!-- HN:41757398:start -->
* [41757398](https://news.social-protocols.org/stats?id=41757398) #29 29 points 9 comments -> [Beast of Gévaudan](https://en.wikipedia.org/wiki/Beast_of_G%C3%A9vaudan)<!-- HN:41757398:end --><!-- HN:41770389:start -->
* [41770389](https://news.social-protocols.org/stats?id=41770389) #28 47 points 14 comments -> [Answer any question about your photo albums with OmniQuery](https://jiahaoli.net/omniquery/)<!-- HN:41770389:end --><!-- HN:41804460:start -->
* [41804460](https://news.social-protocols.org/stats?id=41804460) #29 68 points 185 comments -> [Is population density the reason Americans can't discuss politics?](https://www.georgesaines.com/blog/2024/10/10/is-population-density-the-reason-americans-cant-discuss-politics)<!-- HN:41804460:end --><!-- HN:41771774:start -->
* [41771774](https://news.social-protocols.org/stats?id=41771774) #17 12 points 2 comments -> [Who uses public libraries the most? There's a divide by religion, and politics.](https://www.washingtonpost.com/business/2024/10/04/who-uses-libraries/)<!-- HN:41771774:end --><!-- HN:41809013:start -->
* [41809013](https://news.social-protocols.org/stats?id=41809013) #24 5 points 0 comments -> [How to Find Consulting Clients (2017)](https://www.gkogan.co/how-to-find-consulting-clients/)<!-- HN:41809013:end --><!-- HN:41808282:start -->
* [41808282](https://news.social-protocols.org/stats?id=41808282) #3 28 points 16 comments -> [Startup Success: How Founder Personalities Shape Venture Outcomes](https://business.columbia.edu/research-brief/research-brief/startups-founder-personalities-vc)<!-- HN:41808282:end --><!-- HN:41808663:start -->
* [41808663](https://news.social-protocols.org/stats?id=41808663) #4 -> [Regrad Is Micrograd in Rust](https://github.com/ostadgeorge/regrad)<!-- HN:41808663:end --><!-- HN:41809224:start -->
* [41809224](https://news.social-protocols.org/stats?id=41809224) #26 15 points 0 comments -> ['That's a bloodbath': How a federal program kills wildlife for private interests](https://www.npr.org/2024/10/10/g-s1-26426/wildlife-services-usda-wild-animals-killed-livestock)<!-- HN:41809224:end --><!-- HN:41809920:start -->
* [41809920](https://news.social-protocols.org/stats?id=41809920) #4 3 points 1 comments -> [JavaScript Is Broken](https://codexstoney.medium.com/javascript-is-broken-8841df6f6fc8)<!-- HN:41809920:end --><!-- HN:41809911:start -->
* [41809911](https://news.social-protocols.org/stats?id=41809911) #21 15 points 17 comments -> [Apple's naming conventions are a mess](https://medium.com/@spacedawwwg/apples-naming-conventions-are-a-mess-here-s-what-i-would-do-f8ba364ce37a)<!-- HN:41809911:end --><!-- HN:41810627:start -->
* [41810627](https://news.social-protocols.org/stats?id=41810627) #18 27 points 17 comments -> ['Nearly unusable': Calif. police majorly push back on Tesla cop cars](https://www.sfgate.com/bayarea/article/california-switch-electric-cars-cops-19816671.php)<!-- HN:41810627:end --><!-- HN:41812358:start -->
* [41812358](https://news.social-protocols.org/stats?id=41812358) #4 9 points 2 comments -> [The sad state of font rendering on Linux](https://pandasauce.org/post/linux-fonts/)<!-- HN:41812358:end -->
#### **Saturday, October 12, 2024**
<!-- HN:41764369:start -->
* [41764369](https://news.social-protocols.org/stats?id=41764369) #9 13 points 2 comments -> [A roadmap for VirtIO Video on ChromeOS: part 3](https://www.collabora.com/news-and-blog/blog/2024/06/06/a-roadmap-for-virtio-video-on-chromeos-part-3/)<!-- HN:41764369:end --><!-- HN:41754942:start -->
* [41754942](https://news.social-protocols.org/stats?id=41754942) #15 9 points 1 comments -> [Scaling Laws of Optimization](https://francisbach.com/scaling-laws-of-optimization/)<!-- HN:41754942:end --><!-- HN:41814738:start -->
* [41814738](https://news.social-protocols.org/stats?id=41814738) #23 6 points 4 comments -> [Bug, $50K+ in bounties: how Zendesk left a backdoor in companies](https://gist.github.com/hackermondev/68ec8ed145fcee49d2f5e2b9d2cf2e52)<!-- HN:41814738:end --><!-- HN:41784098:start -->
* [41784098](https://news.social-protocols.org/stats?id=41784098) #10 10 points 1 comments -> [The $550M Question: How Does David Geffen Hall Sound?](https://www.nytimes.com/2024/10/08/arts/music/geffen-hall-acoustics.html)<!-- HN:41784098:end --><!-- HN:41816271:start -->
* [41816271](https://news.social-protocols.org/stats?id=41816271) #15 3 points 0 comments -> [How SpaceX became the MyPillow of government contractors](https://www.theverge.com/2024/10/11/24267262/elon-musk-donald-trump-politics-republican)<!-- HN:41816271:end --><!-- HN:41780914:start -->
* [41780914](https://news.social-protocols.org/stats?id=41780914) #10 21 points 41 comments -> [In Defense of LeetCode Interviews](https://www.alexmolas.com/2024/06/21/leetcode-interviews.html)<!-- HN:41780914:end --><!-- HN:41815544:start -->
* [41815544](https://news.social-protocols.org/stats?id=41815544) #11 9 points 2 comments -> [Show HN: Peak Brain Plasticity book – maximize brain power](https://www.saidhasyim.com/book/peak-brain-plasticity/)<!-- HN:41815544:end --><!-- HN:41818757:start -->
* [41818757](https://news.social-protocols.org/stats?id=41818757) #2 10 points 5 comments -> [Show HN: Here's how I steal your SaaS ideas](https://30percent.netlify.app/)<!-- HN:41818757:end --><!-- HN:41818382:start -->
* [41818382](https://news.social-protocols.org/stats?id=41818382) #30 37 points 40 comments -> [In Praise of 'Megalopolis'](https://www.compactmag.com/article/in-praise-of-megalopolis/)<!-- HN:41818382:end --><!-- HN:41819900:start -->
* [41819900](https://news.social-protocols.org/stats?id=41819900) #8 14 points 13 comments -> [The Boo Programming Language](https://github.com/boo-lang/boo)<!-- HN:41819900:end --><!-- HN:41821131:start -->
* [41821131](https://news.social-protocols.org/stats?id=41821131) #3 16 points 3 comments -> [Europeans Spend 575M Hours Clicking Cookie Banners Every Year](https://legiscope.com/blog/hidden-productivity-drain-cookie-banners.html)<!-- HN:41821131:end --><!-- HN:41820915:start -->
* [41820915](https://news.social-protocols.org/stats?id=41820915) #15 25 points 2 comments -> [Latest Asahi Linux brings AAA gaming to Apple's M1 with respectable frame rates](https://www.tomshardware.com/laptops/macbooks/aaa-gaming-comes-to-apple-m1-thanks-to-the-latest-asahi-linux-build-control-cyberpunk-2077-and-the-witcher-3-are-playable-with-respectable-frame-rates)<!-- HN:41820915:end --><!-- HN:41821775:start -->
* [41821775](https://news.social-protocols.org/stats?id=41821775) #13 4 points 2 comments -> [Evidence of alien may be announced within weeks](https://www.dailymail.co.uk/sciencetech/article-13950399/Evidence-alien-life-revealed-month.html)<!-- HN:41821775:end --><!-- HN:41821582:start -->
* [41821582](https://news.social-protocols.org/stats?id=41821582) #17 7 points 0 comments -> [AI helps farmers target weeds, livestock illnesses and pests](https://www.abc.net.au/news/2024-10-12/artificial-intelligence-agriculture-boom-australia-rural/104450732)<!-- HN:41821582:end --><!-- HN:41822200:start -->
* [41822200](https://news.social-protocols.org/stats?id=41822200) #4 -> [Killer drones play disturbing sounds to lure civilians out into the open](https://reliefweb.int/report/occupied-palestinian-territory/israeli-army-broadcasts-intimidating-sounds-lure-kill-and-forcibly-displace-civilians-nuseirat-camp-enar)<!-- HN:41822200:end --><!-- HN:41771010:start -->
* [41771010](https://news.social-protocols.org/stats?id=41771010) #16 44 points 14 comments -> [Researchers Find Cannibalized Victim of 19th-Century Arctic Voyage](https://www.nytimes.com/2024/10/04/science/franklin-expedition-cannibalism.html)<!-- HN:41771010:end --><!-- HN:41771864:start -->
* [41771864](https://news.social-protocols.org/stats?id=41771864) #20 12 points 1 comments -> [Ion and Molecular Sieving with Ultrathin Polydopamine Nanomembranes](https://onlinelibrary.wiley.com/doi/10.1002/adma.202401137)<!-- HN:41771864:end --><!-- HN:41821193:start -->
* [41821193](https://news.social-protocols.org/stats?id=41821193) #27 31 points 40 comments -> [Nvidia Stock Rises. AMD's New AI Chip Is Not Competitive](https://www.barrons.com/articles/nvidia-stock-price-amd-ai-chips-b6c42016)<!-- HN:41821193:end --><!-- HN:41823175:start -->
* [41823175](https://news.social-protocols.org/stats?id=41823175) #8 25 points 3 comments -> [Every time Matt Mullenweg has lied, misrepresented or behaved questionably](https://bullenweg.com/)<!-- HN:41823175:end --><!-- HN:41823155:start -->
* [41823155](https://news.social-protocols.org/stats?id=41823155) #6 7 points 7 comments -> [New vulnerability in sha256](https://github.com/seccode/Sha256)<!-- HN:41823155:end -->
#### **Sunday, October 13, 2024**
<!-- HN:41823437:start -->
* [41823437](https://news.social-protocols.org/stats?id=41823437) #6 49 points 14 comments -> [Columbus' DNA suggests he was a Sephardic Jew from the western Mediterranean](https://www.abc.es/cultura/adn-colon-apunta-judio-sefardi-mediterraneo-occidental-20241012233342-nt.html)<!-- HN:41823437:end --><!-- HN:41822910:start -->
* [41822910](https://news.social-protocols.org/stats?id=41822910) #5 64 points 2 comments -> [FAA grants SpaceX Starship Flight 5 license](https://drs.faa.gov/browse/excelExternalWindow/DRSDOCID173891218620231102140506.0001)<!-- HN:41822910:end --><!-- HN:41821639:start -->
* [41821639](https://news.social-protocols.org/stats?id=41821639) #25 37 points 41 comments -> [Home Libraries Will Save Civilization](https://www.frontporchrepublic.com/2024/10/home-libraries-will-save-civilization/)<!-- HN:41821639:end --><!-- HN:41824852:start -->
* [41824852](https://news.social-protocols.org/stats?id=41824852) #3 205 points 49 comments -> [ACF Has Been Hijacked](https://anderegg.ca/2024/10/13/acf-has-been-hijacked)<!-- HN:41824852:end --><!-- HN:41825041:start -->
* [41825041](https://news.social-protocols.org/stats?id=41825041) #8 11 points 40 comments -> [Show HN: A free alternative to Typora –– IF](https://if.openages.com)<!-- HN:41825041:end --><!-- HN:41824784:start -->
* [41824784](https://news.social-protocols.org/stats?id=41824784) #16 42 points 19 comments -> [The optimised version of 7-Zip can't be built from source](https://pileofhacks.dev/post/the-optimised-version-of-7-zip-cant-be-built-from-source/)<!-- HN:41824784:end --><!-- HN:41826432:start -->
* [41826432](https://news.social-protocols.org/stats?id=41826432) #13 4 points 1 comments -> [New Gmail Security Alert for 2.5B Users as AI Hack Confirmed](https://www.forbes.com/sites/daveywinder/2024/10/12/new-gmail-security-alert-for-billions-as-7-day-ai-hack-confirmed/)<!-- HN:41826432:end --><!-- HN:41827112:start -->
* [41827112](https://news.social-protocols.org/stats?id=41827112) #27 -> [Changing Views Toward mRNA Based Covid Vaccines in the Scientific Literature](http://www.paom.pl/Changing-Views-toward-mRNA-based-Covid-Vaccines-in-the-Scientific-Literature-2020,189961,0,2.html)<!-- HN:41827112:end -->