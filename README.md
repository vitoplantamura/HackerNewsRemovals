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

#### **Tuesday, January 27, 2026**
<!-- HN:46773636:start -->
* [46773636](https://news.social-protocols.org/stats?id=46773636) #10 4 points 0 comments -> [Infamous Gang of 40 Leader Banned from Wikipedia](https://www.neutralpov.com/p/infamous-gang-of-40-leader-banned)<!-- HN:46773636:end --><!-- HN:46743865:start -->
* [46743865](https://news.social-protocols.org/stats?id=46743865) #18 8 points 4 comments -> [Why autosave is not recovery](https://zippers.dev/blog/why-savior-exists)<!-- HN:46743865:end --><!-- HN:46774777:start -->
* [46774777](https://news.social-protocols.org/stats?id=46774777) #17 86 points 2 comments -> [Heathrow Drops the Liquids Rule](https://flymag.com/heathrow-drops-the-liquids-rule-what-changes-at-lhr-and-how-close-the-u-s-really-is/)<!-- HN:46774777:end --><!-- HN:46720061:start -->
* [46720061](https://news.social-protocols.org/stats?id=46720061) #28 7 points 2 comments -> [Visualizing the Collatz Conjecture as a Phase Transition](https://mathinspector.com/papers/collatz-polynomial-entropy.html)<!-- HN:46720061:end --><!-- HN:46777448:start -->
* [46777448](https://news.social-protocols.org/stats?id=46777448) #3 43 points 7 comments -> [Is OpenAI Dead Yet?](https://isopenaideadyet.com/)<!-- HN:46777448:end --><!-- HN:46778276:start -->
* [46778276](https://news.social-protocols.org/stats?id=46778276) #2 -> [For Fascists, Hypocrisy Is a Virtue](https://kottke.org/25/03/for-fascists-hypocrisy-is-a-virtue)<!-- HN:46778276:end --><!-- HN:46778554:start -->
* [46778554](https://news.social-protocols.org/stats?id=46778554) #27 17 points 1 comments -> [Startup Incubator Y Combinator Cuts Canada from Countries Where It Will Invest](https://www.bloomberg.com/news/articles/2026-01-26/startup-incubator-y-combinator-cuts-canada-from-countries-where-it-will-invest)<!-- HN:46778554:end --><!-- HN:46780017:start -->
* [46780017](https://news.social-protocols.org/stats?id=46780017) #20 -> [Italians furious over deployment of ICE to bolster US security at Olympics](https://www.cnn.com/2026/01/27/europe/italy-ice-agents-security-olympics-intl)<!-- HN:46780017:end --><!-- HN:46780137:start -->
* [46780137](https://news.social-protocols.org/stats?id=46780137) #5 11 points 1 comments -> [US to send ICE agents to Winter Olympics, prompting Italian anger](https://www.bbc.com/news/articles/c5y29xzjdzvo)<!-- HN:46780137:end --><!-- HN:46783289:start -->
* [46783289](https://news.social-protocols.org/stats?id=46783289) #17 16 points 1 comments -> [Federal judge in Minnesota orders ICE director to appear in court](https://www.bbc.co.uk/news/live/c3ve67195gyt)<!-- HN:46783289:end --><!-- HN:46783943:start -->
* [46783943](https://news.social-protocols.org/stats?id=46783943) #12 6 points 0 comments -> [I have no mouth and I must scream at Black people: Scott Adams, 1957-2026](https://www.tcj.com/i-have-no-mouth-and-i-must-scream-at-black-people-scott-adams-1957-2026/)<!-- HN:46783943:end --><!-- HN:46783024:start -->
* [46783024](https://news.social-protocols.org/stats?id=46783024) #21 32 points 7 comments -> [One Human and One Agent = One Browser from Scratch](https://simonwillison.net/2026/Jan/27/one-human-one-agent-one-browser/)<!-- HN:46783024:end --><!-- HN:46785334:start -->
* [46785334](https://news.social-protocols.org/stats?id=46785334) #29 9 points 6 comments -> [Twin – The AI Company Builder](https://twin.so/)<!-- HN:46785334:end --><!-- HN:46699505:start -->
* [46699505](https://news.social-protocols.org/stats?id=46699505) #16 12 points 0 comments -> [Designing Forms That Don't Get in the Way](https://www.souravinsights.com/blog/on-designing-forms)<!-- HN:46699505:end --><!-- HN:46711159:start -->
* [46711159](https://news.social-protocols.org/stats?id=46711159) #22 83 points 13 comments -> [Flexible use of a multi-purpose tool by a cow](https://doi.org/10.1016/j.cub.2025.11.059)<!-- HN:46711159:end --><!-- HN:46713721:start -->
* [46713721](https://news.social-protocols.org/stats?id=46713721) #29 8 points 4 comments -> [Why are we still so afraid of using the grumpy old period?](https://www.nytimes.com/2026/01/15/magazine/ending-sentences-period.html)<!-- HN:46713721:end -->
#### **Wednesday, January 28, 2026**
<!-- HN:46753350:start -->
* [46753350](https://news.social-protocols.org/stats?id=46753350) #13 8 points 3 comments -> [Go 1.26 Is Around the Corner: Small Changes, Big Impact for Real-World Go System](https://medium.com/@anand.hv123/go-1-26-is-around-the-corner-small-changes-big-impact-for-real-world-go-systems-b7e5bd271f51)<!-- HN:46753350:end --><!-- HN:46790250:start -->
* [46790250](https://news.social-protocols.org/stats?id=46790250) #16 45 points 11 comments -> [Apple MacBook Pro order deliveries delayed until mid March](https://www.apple.com/shop/buy-mac/macbook-pro/16-inch-space-black-standard-display-apple-m4-max-with-16-core-cpu-and-40-core-gpu-48gb-memory-1tb)<!-- HN:46790250:end --><!-- HN:46790068:start -->
* [46790068](https://news.social-protocols.org/stats?id=46790068) #11 10 points 9 comments -> [Is coding dead because AI has taken over it?](https://www.jehuamanna.com/blog/2026/is-coding-dead/)<!-- HN:46790068:end --><!-- HN:46791561:start -->
* [46791561](https://news.social-protocols.org/stats?id=46791561) #2 9 points 2 comments -> [The ICE the Dildo Distribution Delegation](https://www.closertotheedge.net/p/the-dildo-distribution-delegation)<!-- HN:46791561:end --><!-- HN:46791496:start -->
* [46791496](https://news.social-protocols.org/stats?id=46791496) #11 13 points 1 comments -> [Moltbot Security Guide: Protect Your VPS from Hackers and Vulnerabilities](https://veerhost.com/moltbot-security-guide/)<!-- HN:46791496:end --><!-- HN:46791974:start -->
* [46791974](https://news.social-protocols.org/stats?id=46791974) #2 6 points 1 comments -> [Peaceful – An AI-generated clone of ICE List](https://gitlab.com/joseph8th/peaceful)<!-- HN:46791974:end --><!-- HN:46791358:start -->
* [46791358](https://news.social-protocols.org/stats?id=46791358) #20 8 points 3 comments -> [How the new era of CEO supervillains are trapped in their own ideology](https://statmodeling.stat.columbia.edu/2026/01/27/facebook-and-the-inherent-incoherence-of-the-ideology-of-market-leading-tech-companies/)<!-- HN:46791358:end --><!-- HN:46792204:start -->
* [46792204](https://news.social-protocols.org/stats?id=46792204) #20 8 points 5 comments -> [I got 14.84x GPU speedup by studying how octopus arms coordinate](https://github.com/matthewlam721/octopus-parallel)<!-- HN:46792204:end --><!-- HN:46792427:start -->
* [46792427](https://news.social-protocols.org/stats?id=46792427) #4 9 points 1 comments -> [Surely [the crash of the US economy] has to be soon](https://wilsoniumite.com/2026/01/27/surely-it-has-to-be-soon/)<!-- HN:46792427:end --><!-- HN:46794365:start -->
* [46794365](https://news.social-protocols.org/stats?id=46794365) #1 367 points 193 comments -> [ICE and Palantir: US agents using health data to hunt illegal immigrants](https://www.bmj.com/content/392/bmj.s168)<!-- HN:46794365:end --><!-- HN:46756117:start -->
* [46756117](https://news.social-protocols.org/stats?id=46756117) #1 1440 points 944 comments -> [ICE using Palantir tool that feeds on Medicaid data](https://www.eff.org/deeplinks/2026/01/report-ice-using-palantir-tool-feeds-medicaid-data)<!-- HN:46756117:end --><!-- HN:46795732:start -->
* [46795732](https://news.social-protocols.org/stats?id=46795732) #8 -> ['I don't let bullies win,' says congresswoman Omar after substance thrown at her](https://www.bbc.com/news/articles/cn9zpee3llxo)<!-- HN:46795732:end --><!-- HN:46797895:start -->
* [46797895](https://news.social-protocols.org/stats?id=46797895) #12 28 points 31 comments -> [Show HN: I Built a Sandbox for Agents](https://github.com/vrn21/bouvet.com)<!-- HN:46797895:end --><!-- HN:46800730:start -->
* [46800730](https://news.social-protocols.org/stats?id=46800730) #10 13 points 13 comments -> [New Books Aren't Worth Reading](https://www.atlaspress.co/p/new-books-arent-worth-reading)<!-- HN:46800730:end -->
#### **Thursday, January 29, 2026**<!-- HN:46806505:start -->
* [46806505](https://news.social-protocols.org/stats?id=46806505) #7 11 points 0 comments -> [Generative Music with the Muse](https://computerhistory.org/blog/generative-music-with-the-muse/)<!-- HN:46806505:end --><!-- HN:46805243:start -->
* [46805243](https://news.social-protocols.org/stats?id=46805243) #16 30 points 40 comments -> [DECwindows Motif](https://products.vmssoftware.com/decwindowsmotif)<!-- HN:46805243:end --><!-- HN:46807201:start -->
* [46807201](https://news.social-protocols.org/stats?id=46807201) #12 34 points 40 comments -> [OpenAI's Unit Economics](https://www.exponentialview.co/p/inside-openais-unit-economics-epoch-exponentialview)<!-- HN:46807201:end --><!-- HN:46810698:start -->
* [46810698](https://news.social-protocols.org/stats?id=46810698) #28 12 points 0 comments -> [Best Gas Masks](https://www.theverge.com/policy/868571/best-gas-masks)<!-- HN:46810698:end --><!-- HN:46810465:start -->
* [46810465](https://news.social-protocols.org/stats?id=46810465) #5 13 points 7 comments -> [The Anti-Hat Riots of 1973](https://www.marginalia.nu/weird-ai-crap/hats/)<!-- HN:46810465:end --><!-- HN:46810644:start -->
* [46810644](https://news.social-protocols.org/stats?id=46810644) #20 -> [ICE violated at least 96 court orders in January](https://www.fox9.com/news/ice-violated-least-96-court-orders-january)<!-- HN:46810644:end --><!-- HN:46814358:start -->
* [46814358](https://news.social-protocols.org/stats?id=46814358) #30 10 points 3 comments -> [I've Been a Public School Teacher for 20 Years. Trust Me: Homeschool Your Kids](https://twitter.com/creation247/status/2012598176138535041)<!-- HN:46814358:end --><!-- HN:46815408:start -->
* [46815408](https://news.social-protocols.org/stats?id=46815408) #11 4 points 1 comments -> [1km tower in the desert is not progress it is a farewell letter to common sense](https://www.doubleglazinginbanbridge.co.uk/29-171405-1km-tower-in-the-desert/)<!-- HN:46815408:end --><!-- HN:46816000:start -->
* [46816000](https://news.social-protocols.org/stats?id=46816000) #12 38 points 9 comments -> [Taco writer detained–briefly–by feds](https://bigbendsentinel.com/2026/01/28/taco-writer-detained-briefly-by-feds/)<!-- HN:46816000:end -->
#### **Friday, January 30, 2026**
<!-- HN:46819466:start -->
* [46819466](https://news.social-protocols.org/stats?id=46819466) #7 7 points 0 comments -> [National Shutdown - No Work. No School. No Shopping. Stop Funding ICE.](https://nationalshutdown.org)<!-- HN:46819466:end --><!-- HN:46812173:start -->
* [46812173](https://news.social-protocols.org/stats?id=46812173) #29 419 points 211 comments -> [US cybersecurity chief leaked sensitive government files to ChatGPT: Report](https://www.dexerto.com/entertainment/us-cybersecurity-chief-leaked-sensitive-government-files-to-chatgpt-report-3311462/)<!-- HN:46812173:end --><!-- HN:46733625:start -->
* [46733625](https://news.social-protocols.org/stats?id=46733625) #12 8 points 1 comments -> [Interesting facts I've learned about wildfires over the years](https://madole.xyz/blog/things-i-learned-about-wildfires)<!-- HN:46733625:end --><!-- HN:46752754:start -->
* [46752754](https://news.social-protocols.org/stats?id=46752754) #28 84 points 35 comments -> [The Value of Things](https://journal.stuffwithstuff.com/2026/01/24/the-value-of-things/)<!-- HN:46752754:end --><!-- HN:46822856:start -->
* [46822856](https://news.social-protocols.org/stats?id=46822856) #27 7 points 1 comments -> [Potentially Critical RCE Vulnerability in OpenSSL](https://research.jfrog.com/post/potential-rce-vulnerabilityin-openssl-cve-2025-15467/)<!-- HN:46822856:end --><!-- HN:46826703:start -->
* [46826703](https://news.social-protocols.org/stats?id=46826703) #6 12 points 4 comments -> [In solidarity with victims of ICE violence](https://blog.ericyd.com/in-solidarity/)<!-- HN:46826703:end --><!-- HN:46825200:start -->
* [46825200](https://news.social-protocols.org/stats?id=46825200) #13 37 points 41 comments -> [HumanConsumption.Live – Real-Time Global Animal Consumption Stats](https://www.humanconsumption.live/)<!-- HN:46825200:end --><!-- HN:46821360:start -->
* [46821360](https://news.social-protocols.org/stats?id=46821360) #25 224 points 8 comments -> [Anthropic: AI Coding shows no productivity gains; impairs skill development](https://arxiv.org/abs/2601.20245)<!-- HN:46821360:end --><!-- HN:46830013:start -->
* [46830013](https://news.social-protocols.org/stats?id=46830013) #30 7 points 1 comments -> [I Built My Own Enterprise-Grade Clawdbot Without the Security Nightmares](https://medium.com/ai-native-enterprise/how-i-built-my-own-enterprise-grade-clawdbot-without-the-security-nightmares-00ae01193280)<!-- HN:46830013:end -->
#### **Saturday, January 31, 2026**
<!-- HN:46831635:start -->
* [46831635](https://news.social-protocols.org/stats?id=46831635) #7 6 points 0 comments -> [When your pastor is an ICE agent](https://www.christiancentury.org/online-columnists/minnesota-bonhoeffer)<!-- HN:46831635:end --><!-- HN:46832063:start -->
* [46832063](https://news.social-protocols.org/stats?id=46832063) #3 35 points 4 comments -> [The Department of Justice Ignores Court Orders Because It Knows It Can](https://www.americanmuckrakers.com/p/the-department-of-justice-ignores)<!-- HN:46832063:end --><!-- HN:46832670:start -->
* [46832670](https://news.social-protocols.org/stats?id=46832670) #26 6 points 0 comments -> [Thousands demonstrate in Minnesota and across US to protest ICE](https://www.reuters.com/world/us/nationwide-protests-walkouts-planned-over-fatal-ice-shootings-minneapolis-2026-01-30/)<!-- HN:46832670:end --><!-- HN:46832888:start -->
* [46832888](https://news.social-protocols.org/stats?id=46832888) #26 32 points 11 comments -> [ICE Expands Power of Agents to Arrest People Without Warrants](https://www.nytimes.com/2026/01/30/us/politics/ice-expands-power-agents-warrants.html)<!-- HN:46832888:end --><!-- HN:46833871:start -->
* [46833871](https://news.social-protocols.org/stats?id=46833871) #4 -> [Target director's Global Entry was revoked after ICE used app to scan her face](https://arstechnica.com/tech-policy/2026/01/ice-protester-says-her-global-entry-was-revoked-after-agent-scanned-her-face/)<!-- HN:46833871:end --><!-- HN:46833707:start -->
* [46833707](https://news.social-protocols.org/stats?id=46833707) #8 10 points 2 comments -> [Genesis](https://zenodo.org/records/18438130)<!-- HN:46833707:end --><!-- HN:46835414:start -->
* [46835414](https://news.social-protocols.org/stats?id=46835414) #23 4 points 2 comments -> [Melania PG, Now Playing, 1h 44M, Documentary](https://www.rottentomatoes.com/m/melania)<!-- HN:46835414:end --><!-- HN:46837021:start -->
* [46837021](https://news.social-protocols.org/stats?id=46837021) #4 14 points 6 comments -> [Resist and Unsubscribe from the tech companies that are enabling this](https://www.resistandunsubscribe.com)<!-- HN:46837021:end --><!-- HN:46836988:start -->
* [46836988](https://news.social-protocols.org/stats?id=46836988) #18 36 points 19 comments -> [Ads Are Killing Podcasting](https://podcasts.rip/)<!-- HN:46836988:end --><!-- HN:46820360:start -->
* [46820360](https://news.social-protocols.org/stats?id=46820360) #21 1624 points 760 comments -> [Moltbook](https://www.moltbook.com/)<!-- HN:46820360:end --><!-- HN:46836487:start -->
* [46836487](https://news.social-protocols.org/stats?id=46836487) #16 169 points 1 comments -> [US reportedly investigate claims that Meta can read encrypted WhatsApp messages](https://www.theguardian.com/technology/2026/jan/31/us-authorities-reportedly-investigate-claims-that-meta-can-read-encrypted-whatsapp-messages)<!-- HN:46836487:end --><!-- HN:46764979:start -->
* [46764979](https://news.social-protocols.org/stats?id=46764979) #8 59 points 32 comments -> [Animated AVIF for the Modern Web](https://arthur.pizza/2025/12/animated-avif-for-the-modern-web/)<!-- HN:46764979:end --><!-- HN:46775758:start -->
* [46775758](https://news.social-protocols.org/stats?id=46775758) #17 84 points 34 comments -> [Quaternion Algebras](https://jvoight.github.io/quat.html)<!-- HN:46775758:end --><!-- HN:46769399:start -->
* [46769399](https://news.social-protocols.org/stats?id=46769399) #21 18 points 7 comments -> [Predicting how Heathrow is using it's runways in the browser](https://blog.billyedmoore.com/heathrow)<!-- HN:46769399:end --><!-- HN:46840077:start -->
* [46840077](https://news.social-protocols.org/stats?id=46840077) #29 22 points 8 comments -> [TrumpRx delayed as senators question if it's a giant scam with Big Pharma](https://arstechnica.com/health/2026/01/trumprx-delayed-as-senators-question-if-its-a-giant-scam-with-big-pharma/)<!-- HN:46840077:end --><!-- HN:46796957:start -->
* [46796957](https://news.social-protocols.org/stats?id=46796957) #10 7 points 1 comments -> [Managing Unreliable Compilers](https://blog.tonkotsu.ai/p/managing-unreliable-compilers)<!-- HN:46796957:end --><!-- HN:46777409:start -->
* [46777409](https://news.social-protocols.org/stats?id=46777409) #29 76 points 52 comments -> [Claude Code is your customer](https://calebjohn.xyz/blog/b2cc/)<!-- HN:46777409:end --><!-- HN:46841325:start -->
* [46841325](https://news.social-protocols.org/stats?id=46841325) #29 16 points 0 comments -> [Govt's Theory for Prosecuting Don Lemon as to Disruption of Minn. Church Service](https://reason.com/volokh/2026/01/31/governments-theory-for-prosecuting-don-lemon-as-to-disruption-of-minneapolis-church-service/)<!-- HN:46841325:end -->
#### **Sunday, February 1, 2026**
<!-- HN:46779061:start -->
* [46779061](https://news.social-protocols.org/stats?id=46779061) #30 54 points 1 comments -> [Writing a .NET Garbage Collector in C# – Part 6: Mark and Sweep](https://minidump.net/writing-a-net-gc-in-c-part-6/)<!-- HN:46779061:end --><!-- HN:46843301:start -->
* [46843301](https://news.social-protocols.org/stats?id=46843301) #15 16 points 2 comments -> [I dropped my Google Pixel 9 XL Pro from 6th floor balcony to the street](https://ercanermis.com/i-dropped-my-google-pixel-9-xl-pro-from-6th-floor-balcony-to-the-street/)<!-- HN:46843301:end --><!-- HN:46844969:start -->
* [46844969](https://news.social-protocols.org/stats?id=46844969) #13 31 points 0 comments -> ['Unsubscribe' and 'opt out': A new Big Tech boycott to protest ICE](https://www.businessinsider.com/tech-ai-boycott-february-protest-ice-scott-galloway-2026-2)<!-- HN:46844969:end --><!-- HN:46846609:start -->
* [46846609](https://news.social-protocols.org/stats?id=46846609) #4 13 points 0 comments -> [Israel to ban Médecins Sans Frontières (MSF)  from working in Gaza](https://www.bbc.com/news/articles/cvg1ymmkpkro)<!-- HN:46846609:end --><!-- HN:46845470:start -->
* [46845470](https://news.social-protocols.org/stats?id=46845470) #28 119 points 60 comments -> [How to Scale a System from 0 to 10M+ Users](https://blog.algomaster.io/p/scaling-a-system-from-0-to-10-million-users)<!-- HN:46845470:end --><!-- HN:46818807:start -->
* [46818807](https://news.social-protocols.org/stats?id=46818807) #14 5 points 0 comments -> [Common Lisp Extension for Zed](https://github.com/etyurkin/zed-cl)<!-- HN:46818807:end --><!-- HN:46848731:start -->
* [46848731](https://news.social-protocols.org/stats?id=46848731) #27 2 points 0 comments -> [Clothes Are Plastic. Your Skin Pays the Price](https://substack.com/home/post/p-186265233)<!-- HN:46848731:end --><!-- HN:46849715:start -->
* [46849715](https://news.social-protocols.org/stats?id=46849715) #3 62 points 51 comments -> [Iran summons families of exiled journalists to halt their activities](https://www.iranintl.com/en/202602017863)<!-- HN:46849715:end -->
#### **Monday, February 2, 2026**
<!-- HN:46811655:start -->
* [46811655](https://news.social-protocols.org/stats?id=46811655) #20 10 points 4 comments -> [From its name, to its hazy origins, to its drug interactions, there's a lot goin](https://www.atlasobscura.com/articles/grapefruit-history-and-drug-interactions)<!-- HN:46811655:end --><!-- HN:46849375:start -->
* [46849375](https://news.social-protocols.org/stats?id=46849375) #23 12 points 0 comments -> [A Collection of Awesome Nostr Projects](https://github.com/aljazceru/awesome-nostr)<!-- HN:46849375:end --><!-- HN:46852548:start -->
* [46852548](https://news.social-protocols.org/stats?id=46852548) #22 5 points 0 comments -> [NPR and PBS Never Needed Your Taxpayer Dollars](https://www.nationalreview.com/2026/02/npr-and-pbs-never-needed-your-taxpayer-dollars/)<!-- HN:46852548:end --><!-- HN:46853532:start -->
* [46853532](https://news.social-protocols.org/stats?id=46853532) #21 5 points 3 comments -> [Welcome to Trumpistan](https://archive.vanityfair.com/article/2017/2/welcome-to-trumpistan)<!-- HN:46853532:end --><!-- HN:46813009:start -->
* [46813009](https://news.social-protocols.org/stats?id=46813009) #15 8 points 3 comments -> [Attilio Berni plays the sub-contrabass saxophone [video]](https://www.youtube.com/watch?v=9BiW2mVKk0w)<!-- HN:46813009:end --><!-- HN:46855003:start -->
* [46855003](https://news.social-protocols.org/stats?id=46855003) #7 17 points 16 comments -> [Applications where agents are first-class citizens](https://every.to/guides/agent-native)<!-- HN:46855003:end --><!-- HN:46805867:start -->
* [46805867](https://news.social-protocols.org/stats?id=46805867) #21 8 points 0 comments -> [High performance, open source RAFT clustered database: RooDB](https://github.com/jgarzik/roodb)<!-- HN:46805867:end --><!-- HN:46856133:start -->
* [46856133](https://news.social-protocols.org/stats?id=46856133) #3 5 points 0 comments -> [Tim Cook sold Apple's soul](https://www.loopwerk.io/articles/2026/tim-cook-sold-apples-soul/)<!-- HN:46856133:end --><!-- HN:46855550:start -->
* [46855550](https://news.social-protocols.org/stats?id=46855550) #14 34 points 40 comments -> [UK Government Launches Fuel Forecourt Price API](https://www.developer.fuel-finder.service.gov.uk/access-latest-fuelprices)<!-- HN:46855550:end --><!-- HN:46856384:start -->
* [46856384](https://news.social-protocols.org/stats?id=46856384) #18 10 points 1 comments -> [Google AI helped IDF drones with targeting in 2024 breaching its own policies](https://www.washingtonpost.com/technology/2026/02/01/google-ai-israel-military/)<!-- HN:46856384:end --><!-- HN:46857257:start -->
* [46857257](https://news.social-protocols.org/stats?id=46857257) #29 4 points 1 comments -> [Classified Whistleblower Complaint About Tulsi Gabbard Stalls Within Her Agency](https://www.wsj.com/politics/national-security/classified-whistleblower-complaint-about-tulsi-gabbard-stalls-within-her-agency-027f5331)<!-- HN:46857257:end --><!-- HN:46857082:start -->
* [46857082](https://news.social-protocols.org/stats?id=46857082) #24 22 points 14 comments -> [Rural Americans Are Trying to Hold Back the Tide of AI](https://www.wsj.com/politics/policy/these-rural-americans-are-trying-to-hold-back-the-tide-of-ai-66945306)<!-- HN:46857082:end --><!-- HN:46857796:start -->
* [46857796](https://news.social-protocols.org/stats?id=46857796) #5 15 points 4 comments -> [My five stages of AI grief](https://dev-tester.com/my-five-stages-of-ai-grief/)<!-- HN:46857796:end -->