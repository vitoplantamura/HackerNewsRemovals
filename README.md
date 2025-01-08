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

#### **Thursday, January 2, 2025**<!-- HN:42571045:start -->
* [42571045](https://news.social-protocols.org/stats?id=42571045) #12 23 points 40 comments -> [Could the Soviet Union have survived?](https://www.historytoday.com/archive/head-head/could-soviet-union-have-survived)<!-- HN:42571045:end --><!-- HN:42571569:start -->
* [42571569](https://news.social-protocols.org/stats?id=42571569) #19 29 points 15 comments -> [Spirituality Is Secure Attachment with Reality](https://intimatemirror.substack.com/p/spirituality-is-secure-attachment)<!-- HN:42571569:end --><!-- HN:42573214:start -->
* [42573214](https://news.social-protocols.org/stats?id=42573214) #8 6 points 2 comments -> [Show HN: A tool to generate dragon names](https://dragonnamegenerator.net)<!-- HN:42573214:end --><!-- HN:42569236:start -->
* [42569236](https://news.social-protocols.org/stats?id=42569236) #25 320 points 184 comments -> [Rails for everything](https://literallythevoid.com/blog/rails_for_everything.html)<!-- HN:42569236:end --><!-- HN:42573936:start -->
* [42573936](https://news.social-protocols.org/stats?id=42573936) #28 6 points 1 comments -> [Pink Floyd's Young Lust telephone signalling explained](https://telephoneworld.org/landline-telephone-history/pink-floyds-young-lust-explained-and-demystified/)<!-- HN:42573936:end --><!-- HN:42542576:start -->
* [42542576](https://news.social-protocols.org/stats?id=42542576) #22 36 points 54 comments -> [Where are Mr. Beast's early sponsors now?](https://www.preethamrn.com/posts/where-are-mrbeast-sponsors-now)<!-- HN:42542576:end --><!-- HN:42540005:start -->
* [42540005](https://news.social-protocols.org/stats?id=42540005) #17 95 points 21 comments -> [DuPont and "DuPont" connectors, and how to crimp them properly](https://www.mattmillman.com/info/crimpconnectors/dupont-and-dupont-connectors/)<!-- HN:42540005:end --><!-- HN:42574420:start -->
* [42574420](https://news.social-protocols.org/stats?id=42574420) #26 3 points 0 comments -> [Things we think will happen in 2025](https://www.vox.com/future-perfect/392241/2025-new-year-predictions-trump-musk-artificial-intelligence)<!-- HN:42574420:end --><!-- HN:42570138:start -->
* [42570138](https://news.social-protocols.org/stats?id=42570138) #28 106 points 80 comments -> [Are there more trees on Earth than stars in the Milky Way? (2016)](https://www.snopes.com/fact-check/trees-stars-milky-way/)<!-- HN:42570138:end --><!-- HN:42574496:start -->
* [42574496](https://news.social-protocols.org/stats?id=42574496) #25 8 points 0 comments -> [What It's Like to Work for Elon Musk - Genius, Chaos, and Burnout](https://techiegamers.com/the-truth-about-working-for-elon-musk/)<!-- HN:42574496:end --><!-- HN:42574238:start -->
* [42574238](https://news.social-protocols.org/stats?id=42574238) #26 9 points 3 comments -> [US culture breeds 'laziness' and 'mediocrity](https://www.telegraph.co.uk/world-news/2024/12/27/us-culture-breeds-laziness-mediocrity-says-vivek-ramaswamy/)<!-- HN:42574238:end --><!-- HN:42553657:start -->
* [42553657](https://news.social-protocols.org/stats?id=42553657) #13 5 points 1 comments -> [The Upside of the Pentium Bug (1995) [pdf]](https://websrv.cecs.uci.edu/~papers/mpr/MPR/EDITOR/0903ed.pdf)<!-- HN:42553657:end --><!-- HN:42569728:start -->
* [42569728](https://news.social-protocols.org/stats?id=42569728) #23 73 points 2 comments -> [(Amiga) AROS Research Operating System: Summary of 2024](https://arosnews.github.io/aros-x86-summary-2024/)<!-- HN:42569728:end --><!-- HN:42574545:start -->
* [42574545](https://news.social-protocols.org/stats?id=42574545) #26 5 points 0 comments -> [Korean Assembly Speaker's adherence to procedure key to making troops stand down](https://www.aljazeera.com/news/2024/12/27/unlikely-political-thor-emerges-from-south-koreas-martial-law-crisis)<!-- HN:42574545:end --><!-- HN:42571963:start -->
* [42571963](https://news.social-protocols.org/stats?id=42571963) #28 25 points 9 comments -> [How I Use Claude](https://borretti.me/article/how-i-use-claude)<!-- HN:42571963:end --><!-- HN:42574352:start -->
* [42574352](https://news.social-protocols.org/stats?id=42574352) #30 6 points 4 comments -> [Nearly Half of US Unicorns Have Immigrants Founders](https://gfmag.com/capital-raising-corporate-finance/us-unicorns-immigrant-founders/)<!-- HN:42574352:end --><!-- HN:42539700:start -->
* [42539700](https://news.social-protocols.org/stats?id=42539700) #26 132 points 49 comments -> [We fine-tuned Llama and got 4.2x Sonnet 3.5 accuracy for code generation](https://finecodex.com/)<!-- HN:42539700:end --><!-- HN:42540792:start -->
* [42540792](https://news.social-protocols.org/stats?id=42540792) #28 72 points 28 comments -> [What is a second?](https://www.johndcook.com/blog/2024/12/29/what-exactly-is-a-second/)<!-- HN:42540792:end --><!-- HN:42576141:start -->
* [42576141](https://news.social-protocols.org/stats?id=42576141) #16 6 points 1 comments -> [Employees Speak Out: Google, Apple, MS, & Intel Discriminate Against White Men [video]](https://www.youtube.com/watch?v=sdwtMtaIkGM)<!-- HN:42576141:end --><!-- HN:42576001:start -->
* [42576001](https://news.social-protocols.org/stats?id=42576001) #23 6 points 1 comments -> [Palestinian Authority Suspends Al Jazeera TV in West Bank, Citing Incitement](https://www.bbc.com/news/articles/cvgmxzyrmn8o)<!-- HN:42576001:end --><!-- HN:42576090:start -->
* [42576090](https://news.social-protocols.org/stats?id=42576090) #27 8 points 0 comments -> [The Dogs of (Urban) War: Lessons from the IDFs' Specialized Canine Unit](https://mwi.westpoint.edu/the-dogs-of-urban-war-lessons-from-oketz-the-israel-defense-forces-specialized-canine-unit/)<!-- HN:42576090:end --><!-- HN:42547615:start -->
* [42547615](https://news.social-protocols.org/stats?id=42547615) #17 9 points 4 comments -> [Systems Ideas That Sound Good but Almost Never Work – "Let's Just "](https://hardcoresoftware.learningbyshipping.com/p/225-systems-ideas-that-sound-good)<!-- HN:42547615:end -->
#### **Friday, January 3, 2025**
<!-- HN:42582415:start -->
* [42582415](https://news.social-protocols.org/stats?id=42582415) #2 12 points 2 comments -> [FCC's Net Neutrality Rules Struck Down by Sixth Circuit](https://stocks.apple.com/AOtE_yI5dTe6OkLqgYKQ69A)<!-- HN:42582415:end --><!-- HN:42582913:start -->
* [42582913](https://news.social-protocols.org/stats?id=42582913) #13 5 points 3 comments -> [Justine: "I'm over 40 and I'm one of the most active coders in the world"](https://twitter.com/JustineTunney/status/1875041647198879889)<!-- HN:42582913:end --><!-- HN:42581368:start -->
* [42581368](https://news.social-protocols.org/stats?id=42581368) #15 35 points 40 comments -> [Party Squasher, the first guest occupancy counter for homes](https://www.partysquasher.com/)<!-- HN:42581368:end --><!-- HN:42583485:start -->
* [42583485](https://news.social-protocols.org/stats?id=42583485) #18 17 points 16 comments -> [Mars Exploration: How the CIA's Project Stargate Went to Mars [pdf]](https://www.cia.gov/readingroom/docs/cia-rdp96-00788r001900760001-9.pdf)<!-- HN:42583485:end --><!-- HN:42584900:start -->
* [42584900](https://news.social-protocols.org/stats?id=42584900) #6 30 points 34 comments -> [A free, unlimited online PDF converter with Privacy focus](https://quicklypdf.com)<!-- HN:42584900:end --><!-- HN:42566112:start -->
* [42566112](https://news.social-protocols.org/stats?id=42566112) #14 1244 points 264 comments -> [DOOM CAPTCHA](https://doom-captcha.vercel.app/)<!-- HN:42566112:end --><!-- HN:42585377:start -->
* [42585377](https://news.social-protocols.org/stats?id=42585377) #21 12 points 2 comments -> [Time to check if you ran any of these 33 malicious Chrome extensions](https://arstechnica.com/security/2025/01/dozens-of-backdoored-chrome-extensions-discovered-on-2-6-million-devices/)<!-- HN:42585377:end --><!-- HN:42584599:start -->
* [42584599](https://news.social-protocols.org/stats?id=42584599) #23 6 points 0 comments -> [K/Simple in OCaml](https://git.uwaterloo.ca/lseo/ksimple_ml)<!-- HN:42584599:end --><!-- HN:42584436:start -->
* [42584436](https://news.social-protocols.org/stats?id=42584436) #26 6 points 0 comments -> [Speeding Up SQLite Inserts](https://blog.julik.nl/2025/01/maximum-speed-sqlite-inserts)<!-- HN:42584436:end --><!-- HN:42587222:start -->
* [42587222](https://news.social-protocols.org/stats?id=42587222) #6 7 points 0 comments -> [Harnessing 3200 Gbps Network: A Journey with RDMA, EFA, and Libfabric](https://le.qun.ch/en/blog/2024/12/25/libfabric-efa-0-intro/)<!-- HN:42587222:end --><!-- HN:42588146:start -->
* [42588146](https://news.social-protocols.org/stats?id=42588146) #23 3 points 0 comments -> [Congo files criminal complaints against Apple in Europe over conflict minerals](https://www.reuters.com/sustainability/society-equity/congo-files-criminal-complaints-against-apple-europe-over-conflict-minerals-2024-12-17/)<!-- HN:42588146:end --><!-- HN:42554722:start -->
* [42554722](https://news.social-protocols.org/stats?id=42554722) #19 4 points 0 comments -> [Emulating 6502](https://zserge.com/posts/6502/)<!-- HN:42554722:end --><!-- HN:42586518:start -->
* [42586518](https://news.social-protocols.org/stats?id=42586518) #17 27 points 40 comments -> [Show HN: I'm tired of sharing code using PasteBin and Slack, so I made this](https://turbogist.dev)<!-- HN:42586518:end --><!-- HN:42587182:start -->
* [42587182](https://news.social-protocols.org/stats?id=42587182) #26 3 points 1 comments -> [Bridging Science and Art: Exploring the World of Scientific Illustrations](https://scientific-illustrations.com)<!-- HN:42587182:end --><!-- HN:42588285:start -->
* [42588285](https://news.social-protocols.org/stats?id=42588285) #8 22 points 17 comments -> [Overcoming Resistance to Extreme Programming](https://benjiweber.co.uk/blog/2025/01/01/overcoming-resistance-to-extreme-programming/)<!-- HN:42588285:end --><!-- HN:42589497:start -->
* [42589497](https://news.social-protocols.org/stats?id=42589497) #4 10 points 16 comments -> [Factories in Space](https://www.factoriesinspace.com/)<!-- HN:42589497:end --><!-- HN:42589788:start -->
* [42589788](https://news.social-protocols.org/stats?id=42589788) #6 55 points 1 comments -> [Canada Should Join the EU](https://www.economist.com/europe/2025/01/02/why-canada-should-join-the-eu)<!-- HN:42589788:end -->
#### **Saturday, January 4, 2025**<!-- HN:42570609:start -->
* [42570609](https://news.social-protocols.org/stats?id=42570609) #26 38 points 16 comments -> [Rust, Reflection and Access Rules](https://fractalfir.github.io/generated_html/refl_priv.html)<!-- HN:42570609:end --><!-- HN:42592370:start -->
* [42592370](https://news.social-protocols.org/stats?id=42592370) #16 22 points 5 comments -> [U-Haul Growth Metros and Cities of 2024: Dallas Top Metro for In-Migration](https://www.uhaul.com/Articles/About/U-Haul-Growth-Metros-And-Cities-Of-2024-Dallas-Top-Metro-for-IN-Migration-33084/)<!-- HN:42592370:end --><!-- HN:42594089:start -->
* [42594089](https://news.social-protocols.org/stats?id=42594089) #24 3 points 0 comments -> [Paralysed man communicates first words in months using brain implant](https://www.independent.co.uk/tech/paralysed-man-brain-implant-beer-b2044610.html)<!-- HN:42594089:end --><!-- HN:42594380:start -->
* [42594380](https://news.social-protocols.org/stats?id=42594380) #23 3 points 0 comments -> [LastPass Android app has seven trackers](https://reports.exodus-privacy.eu.org/en/reports/165465/)<!-- HN:42594380:end --><!-- HN:42594810:start -->
* [42594810](https://news.social-protocols.org/stats?id=42594810) #10 9 points 3 comments -> [Ellison declares Oracle all-in on AI mass surveillance, keep everyone in line](https://www.theregister.com/2024/09/16/oracle_ai_mass_surveillance_cloud/)<!-- HN:42594810:end --><!-- HN:42594922:start -->
* [42594922](https://news.social-protocols.org/stats?id=42594922) #19 3 points 1 comments -> [Apple Siri Eavesdropping Payout–Here's Who's Eligible and How to Claim](https://www.forbes.com/sites/kateoflahertyuk/2025/01/04/apple-siri-eavesdropping-payout-heres-whos-eligible-and-how-to-claim/)<!-- HN:42594922:end --><!-- HN:42596078:start -->
* [42596078](https://news.social-protocols.org/stats?id=42596078) #6 3 points 0 comments -> [Van Halen and Brown M&Ms](https://oddathenaeum.com/van-halen-and-brown-mms/)<!-- HN:42596078:end --><!-- HN:42597428:start -->
* [42597428](https://news.social-protocols.org/stats?id=42597428) #4 7 points 2 comments -> [Show HN: Signify – FOSS tool to generate Email signatures (HTML and PNG)](https://signify.difuse.io)<!-- HN:42597428:end --><!-- HN:42597977:start -->
* [42597977](https://news.social-protocols.org/stats?id=42597977) #27 4 points 0 comments -> [Ohio Puts Police Bodycam Footage Behind a Paywall](https://theintercept.com/2025/01/03/police-body-camera-footage-ohio/)<!-- HN:42597977:end --><!-- HN:42569077:start -->
* [42569077](https://news.social-protocols.org/stats?id=42569077) #14 10 points 5 comments -> [Human in the Loop and the Missing Productivity Growth](https://everything.intellectronica.net/p/human-and-tech-productivity)<!-- HN:42569077:end -->
#### **Sunday, January 5, 2025**
<!-- HN:42598948:start -->
* [42598948](https://news.social-protocols.org/stats?id=42598948) #16 7 points 0 comments -> [Understanding Doge as Procurement Capture](https://www.anildash.com//2025/01/04/DOGE-procurement-capture/)<!-- HN:42598948:end --><!-- HN:42598722:start -->
* [42598722](https://news.social-protocols.org/stats?id=42598722) #1 173 points 69 comments -> [Nearly half Dell's US workforce has rejected RTO. Rather WFH than get promoted](https://www.msn.com/en-us/money/companies/nearly-half-of-dell-s-full-time-workforce-in-the-u-s-has-rejected-returning-to-the-office-they-d-rather-work-from-home-than-get-promoted/ar-BB1oBygb)<!-- HN:42598722:end --><!-- HN:42601022:start -->
* [42601022](https://news.social-protocols.org/stats?id=42601022) #26 11 points 4 comments -> [Being a career-obsessed engineer wasn't the optimal way to be fulfilled](https://strategizeyourcareer.com/p/how-im-advancing-my-career-without-neglecting-my-life)<!-- HN:42601022:end --><!-- HN:42601438:start -->
* [42601438](https://news.social-protocols.org/stats?id=42601438) #26 27 points 3 comments -> [FCC net neutrality rules dead again as appeals court sides with Big Telco](https://www.theregister.com/2025/01/02/fcc_net_neutrality_rules_killed/)<!-- HN:42601438:end --><!-- HN:42602415:start -->
* [42602415](https://news.social-protocols.org/stats?id=42602415) #26 4 points 0 comments -> [X is testing a standalone app for Grok, its AI chatbot](https://twitter.com/refsrc/status/1875920739620343879)<!-- HN:42602415:end --><!-- HN:42601932:start -->
* [42601932](https://news.social-protocols.org/stats?id=42601932) #22 31 points 40 comments -> [AI's next leap requires intimate access to your digital life](https://www.washingtonpost.com/technology/2025/01/05/agents-ai-chatbots-google-mariner/)<!-- HN:42601932:end --><!-- HN:42602950:start -->
* [42602950](https://news.social-protocols.org/stats?id=42602950) #19 17 points 9 comments -> [After Layoffs, Why Do Tech Firms Still Claim Talent Shortages?](https://www.behindhrdoors.com/p/why-tech-companies-struggle-to-hire-after-massive-layoffs)<!-- HN:42602950:end --><!-- HN:42603394:start -->
* [42603394](https://news.social-protocols.org/stats?id=42603394) #26 8 points 2 comments -> [Self-driving Tesla steers onto train tracks](https://www.sfgate.com/tech/article/tesla-fsd-jesse-lyu-train-20014242.php)<!-- HN:42603394:end --><!-- HN:42604840:start -->
* [42604840](https://news.social-protocols.org/stats?id=42604840) #17 9 points 3 comments -> [Show HN: I built a tool to rank cities based on purchasing power for SWEs](https://www.techcities.app/?baseCity=sf)<!-- HN:42604840:end -->
#### **Monday, January 6, 2025**
<!-- HN:42606958:start -->
* [42606958](https://news.social-protocols.org/stats?id=42606958) #10 21 points 10 comments -> [Kentucky Cops Raid Wrong Home, Kill Innocent Man over Alleged Stolen Weed Eater](https://atlantablackstar.com/2024/12/31/kentucky-cops-raid-wrong-home-kill-man-over-alleged-stolen-weed-eater/)<!-- HN:42606958:end --><!-- HN:42573761:start -->
* [42573761](https://news.social-protocols.org/stats?id=42573761) #25 19 points 5 comments -> [The Maxwell-Heaviside Equations Explained by the Theory of Informatons](https://www.researchgate.net/publication/382229137_The_Maxwell-Heaviside_Equations_Explained_by_the_Theory_of_Informatons)<!-- HN:42573761:end --><!-- HN:42607682:start -->
* [42607682](https://news.social-protocols.org/stats?id=42607682) #15 17 points 40 comments -> [Show HN: I made it easy to create invoices](https://www.invoicefast.io)<!-- HN:42607682:end --><!-- HN:42585221:start -->
* [42585221](https://news.social-protocols.org/stats?id=42585221) #12 46 points 14 comments -> [My approach to running a link blog](https://simonwillison.net/2024/Dec/22/link-blog/)<!-- HN:42585221:end --><!-- HN:42607455:start -->
* [42607455](https://news.social-protocols.org/stats?id=42607455) #16 39 points 31 comments -> [Magic Links Have Rough Edges, but Passkeys Can Smooth Them Over](https://rmondello.com/2025/01/02/magic-links-and-passkeys/)<!-- HN:42607455:end --><!-- HN:42608470:start -->
* [42608470](https://news.social-protocols.org/stats?id=42608470) #20 -> [Why Computer Scientists Consult Oracles](https://www.quantamagazine.org/why-computer-scientists-consult-oracles-20250103/)<!-- HN:42608470:end --><!-- HN:42609569:start -->
* [42609569](https://news.social-protocols.org/stats?id=42609569) #21 8 points 1 comments -> [Air Force Tests Subscale Model of Blended-Wing Body Jet](https://www.airandspaceforces.com/air-force-subscale-model-blended-wing-body/)<!-- HN:42609569:end --><!-- HN:42607087:start -->
* [42607087](https://news.social-protocols.org/stats?id=42607087) #24 109 points 128 comments -> [Printf Debugging Is OK](https://www.polymonster.co.uk/blog/printf-debugging-is-ok)<!-- HN:42607087:end --><!-- HN:42606231:start -->
* [42606231](https://news.social-protocols.org/stats?id=42606231) #29 203 points 72 comments -> [Killed by LLM](https://r0bk.github.io/killedbyllm/)<!-- HN:42606231:end --><!-- HN:42552016:start -->
* [42552016](https://news.social-protocols.org/stats?id=42552016) #20 131 points 303 comments -> [Why was there a wall near runway at S Korea plane crash airport?](https://www.bbc.com/news/articles/c0mvynnxzzmo)<!-- HN:42552016:end --><!-- HN:42609948:start -->
* [42609948](https://news.social-protocols.org/stats?id=42609948) #18 4 points 0 comments -> [4chan became the home of the elite reader](https://www.newstatesman.com/culture/2025/01/how-4chan-became-the-home-of-the-elite-reader)<!-- HN:42609948:end --><!-- HN:42610204:start -->
* [42610204](https://news.social-protocols.org/stats?id=42610204) #20 4 points 0 comments -> [Chromebooks still set for scrap, even with 10-year lifecycle](https://www.theregister.com/2025/01/06/chromebook_end_of_life/)<!-- HN:42610204:end --><!-- HN:42589672:start -->
* [42589672](https://news.social-protocols.org/stats?id=42589672) #13 -> [The Gentrification of Video Game History](https://felipepepe.medium.com/the-gentrification-of-video-game-history-dfe11f1e08ae)<!-- HN:42589672:end --><!-- HN:42608925:start -->
* [42608925](https://news.social-protocols.org/stats?id=42608925) #17 42 points 4 comments -> [Modern Generic SVGA driver for Windows 3.1](https://github.com/PluMGMK/vbesvga.drv)<!-- HN:42608925:end --><!-- HN:42608927:start -->
* [42608927](https://news.social-protocols.org/stats?id=42608927) #21 36 points 19 comments -> [DVD shop owner vows to be 'last man standing'](https://www.bbc.com/news/articles/cx2wypg7jrdo)<!-- HN:42608927:end --><!-- HN:42611993:start -->
* [42611993](https://news.social-protocols.org/stats?id=42611993) #20 6 points 0 comments -> [Canadian Prime Minister Trudeau Resigns](https://apnews.com/live/justin-trudeau-canada-prime-minister)<!-- HN:42611993:end --><!-- HN:42609865:start -->
* [42609865](https://news.social-protocols.org/stats?id=42609865) #30 33 points 9 comments -> [Show HN: SPath is a Rust lib for query JSONPath over any semi-structured data](https://github.com/cratesland/spath)<!-- HN:42609865:end --><!-- HN:42613134:start -->
* [42613134](https://news.social-protocols.org/stats?id=42613134) #26 4 points 0 comments -> [Ford and Musk. They Made Cars. They Backed Fascists](https://prospect.org/power/2025-01-06-ford-musk-made-cars-backed-fascists/)<!-- HN:42613134:end --><!-- HN:42612453:start -->
* [42612453](https://news.social-protocols.org/stats?id=42612453) #21 8 points 1 comments -> [Getting LLMs to Generate Funny Memes Is Unexpectedly Hard](https://www.greptile.com/blog/reporoast)<!-- HN:42612453:end --><!-- HN:42614848:start -->
* [42614848](https://news.social-protocols.org/stats?id=42614848) #27 4 points 0 comments -> [Persistent spike protein in brain may contribute to sequelae of Covid-19](https://www.cell.com/cell-host-microbe/fulltext/S1931-3128(24)00438-4?_returnURL=https%3A%2F%2Flinkinghub.elsevier.com%2Fretrieve%2Fpii%2FS1931312824004384%3Fshowall%3Dtrue)<!-- HN:42614848:end --><!-- HN:42592970:start -->
* [42592970](https://news.social-protocols.org/stats?id=42592970) #15 12 points 4 comments -> [Show HN: Al Hugging Video Generator](https://cococlip.ai/features/ai-hug)<!-- HN:42592970:end --><!-- HN:42616269:start -->
* [42616269](https://news.social-protocols.org/stats?id=42616269) #29 48 points 20 comments -> [What Parler Saw During the Attack on the Capitol](https://projects.propublica.org/parler-capitol-videos/)<!-- HN:42616269:end -->
#### **Tuesday, January 7, 2025**
<!-- HN:42618260:start -->
* [42618260](https://news.social-protocols.org/stats?id=42618260) #19 14 points 1 comments -> [Instagram Begins Randomly Showing Users AI-Generated Images of Themselves](https://www.404media.co/instagram-begins-randomly-showing-users-ai-generated-images-of-themselves/)<!-- HN:42618260:end --><!-- HN:42618849:start -->
* [42618849](https://news.social-protocols.org/stats?id=42618849) #3 71 points 17 comments -> [Nvidia Blackwell GeForce RTX 50 Series Opens New World of AI Computer Graphics](https://nvidianews.nvidia.com/news/nvidia-blackwell-geforce-rtx-50-series-opens-new-world-of-ai-computer-graphics)<!-- HN:42618849:end --><!-- HN:42619163:start -->
* [42619163](https://news.social-protocols.org/stats?id=42619163) #30 9 points 2 comments -> [Nvidia Puts Grace Blackwell on Every Desk and at Every AI Developer's Fingertips](https://nvidianews.nvidia.com/news/nvidia-puts-grace-blackwell-on-every-desk-and-at-every-ai-developers-fingertips)<!-- HN:42619163:end --><!-- HN:42588579:start -->
* [42588579](https://news.social-protocols.org/stats?id=42588579) #20 7 points 2 comments -> [Postiz – open-source social media scheduler](https://github.com/gitroomhq/postiz-app)<!-- HN:42588579:end --><!-- HN:42619695:start -->
* [42619695](https://news.social-protocols.org/stats?id=42619695) #18 39 points 14 comments -> [Y2K – why I know it was a real problem (2015)](https://clarotesting.wordpress.com/2015/01/12/y2k-why-i-know-it-was-a-real-problem/)<!-- HN:42619695:end --><!-- HN:42621332:start -->
* [42621332](https://news.social-protocols.org/stats?id=42621332) #5 114 points 14 comments -> [Nvidia announces $3k personal AI supercomputer called Digits](https://www.theverge.com/2025/1/6/24337530/nvidia-ces-digits-super-computer-ai)<!-- HN:42621332:end --><!-- HN:42622220:start -->
* [42622220](https://news.social-protocols.org/stats?id=42622220) #28 13 points 2 comments -> [Meta to get rid of factcheckers and recommend more political content](https://www.theguardian.com/technology/2025/jan/07/meta-facebook-instagram-threads-mark-zuckerberg-remove-fact-checkers-recommend-political-content)<!-- HN:42622220:end --><!-- HN:42622082:start -->
* [42622082](https://news.social-protocols.org/stats?id=42622082) #17 51 points 53 comments -> [Mark Zuckerberg: It's time to get back to our roots around free expression](https://www.facebook.com/zuck/videos/its-time-to-get-back-to-our-roots-around-free-expression-were-replacing-fact-che/1525382954801931/)<!-- HN:42622082:end --><!-- HN:42620191:start -->
* [42620191](https://news.social-protocols.org/stats?id=42620191) #12 23 points 53 comments -> [Alcohol-free booze is becoming big business](https://www.economist.com/business/2025/01/06/alcohol-free-booze-is-becoming-big-business)<!-- HN:42620191:end --><!-- HN:42622147:start -->
* [42622147](https://news.social-protocols.org/stats?id=42622147) #19 36 points 33 comments -> [Mark Zuckerberg: Fact-Checking on Meta Is Too "Politically Biased"](https://www.hollywoodreporter.com/business/digital/mark-zuckerberg-meta-ends-content-restrictions-restore-free-speech-1236102963/)<!-- HN:42622147:end --><!-- HN:42622663:start -->
* [42622663](https://news.social-protocols.org/stats?id=42622663) #13 3 points 0 comments -> [The Great Filter Comes for Us All](https://blog.codinghorror.com/the-great-filter-comes-for-us-all/)<!-- HN:42622663:end --><!-- HN:42621012:start -->
* [42621012](https://news.social-protocols.org/stats?id=42621012) #23 4 points 1 comments -> ["America Is in Decline": Truth or Informational Indoctrination?](https://actfiles.org/america-is-in-decline-truth-or-informational-indoctrination/)<!-- HN:42621012:end --><!-- HN:42621793:start -->
* [42621793](https://news.social-protocols.org/stats?id=42621793) #30 9 points 5 comments -> [Computer Science graduates with a 4.0 GPA can't get a job in tech](https://xcancel.com/davenewworld_2/status/1874919912621453374)<!-- HN:42621793:end --><!-- HN:42622481:start -->
* [42622481](https://news.social-protocols.org/stats?id=42622481) #28 6 points 0 comments -> [Roman Empire's Air Pollution May Have Lowered the IQ of Europe](https://www.sciencealert.com/roman-empires-air-pollution-may-have-lowered-the-iq-of-europe)<!-- HN:42622481:end --><!-- HN:42624145:start -->
* [42624145](https://news.social-protocols.org/stats?id=42624145) #3 17 points 6 comments -> [Yeah, America can still build stuff](https://jabberwocking.com/yeah-america-can-still-build-stuff/)<!-- HN:42624145:end --><!-- HN:42624955:start -->
* [42624955](https://news.social-protocols.org/stats?id=42624955) #18 10 points 1 comments -> [Washington Post Cartoonist Quits After Jeff Bezos Cartoon Is Killed](https://www.nytimes.com/2025/01/03/business/media/washington-post-cartoonist-quits-after-jeff-bezos-cartoon-is-killed.html)<!-- HN:42624955:end --><!-- HN:42625274:start -->
* [42625274](https://news.social-protocols.org/stats?id=42625274) #21 11 points 9 comments -> [In a cold day of late winter a new search experience came out](http://lexy.uno)<!-- HN:42625274:end --><!-- HN:42628303:start -->
* [42628303](https://news.social-protocols.org/stats?id=42628303) #12 8 points 0 comments -> [Go Is a Well-Designed Language](https://mattjhall.co.uk/posts/go-is-well-designed-actually.html)<!-- HN:42628303:end --><!-- HN:42627902:start -->
* [42627902](https://news.social-protocols.org/stats?id=42627902) #10 9 points 2 comments -> [50 Years of SNL's Graphic Parodies (2024)](https://www.printmag.com/daily-heller/the-daily-heller-snls-graphic-parody/)<!-- HN:42627902:end --><!-- HN:42629052:start -->
* [42629052](https://news.social-protocols.org/stats?id=42629052) #24 10 points 2 comments -> [Meta Now Lets Users Say Gay and Trans People Have 'Mental Illness'](https://www.wired.com/story/meta-immigration-gender-policies-change/)<!-- HN:42629052:end -->
#### **Wednesday, January 8, 2025**
<!-- HN:42627170:start -->
* [42627170](https://news.social-protocols.org/stats?id=42627170) #24 38 points 69 comments -> [Show HN: I Built an AI Tattoo Generator Using Flux](https://www.tattoopro.ai/)<!-- HN:42627170:end -->