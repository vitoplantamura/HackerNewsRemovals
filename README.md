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

#### **Sunday, September 14, 2025**
<!-- HN:45236454:start -->
* [45236454](https://news.social-protocols.org/stats?id=45236454) #5 4 points 1 comments -> [US/* time zone deprecation affects fresh Debian 12 installs](https://rachelbythebay.com/w/2025/09/12/tz/)<!-- HN:45236454:end --><!-- HN:45196874:start -->
* [45196874](https://news.social-protocols.org/stats?id=45196874) #25 10 points 4 comments -> [Presence in VR should show tiny people, not user avatars](https://interconnected.org/home/2022/05/03/landscape)<!-- HN:45196874:end --><!-- HN:45237785:start -->
* [45237785](https://news.social-protocols.org/stats?id=45237785) #16 8 points 6 comments -> [ChatGPT Sent Me to the ER](https://benorenstein.substack.com/p/chatgpt-sent-me-to-the-er)<!-- HN:45237785:end --><!-- HN:45205976:start -->
* [45205976](https://news.social-protocols.org/stats?id=45205976) #21 11 points 0 comments -> [Uniprof: Universal CPU Profiling](https://www.uniprof.sh/)<!-- HN:45205976:end --><!-- HN:45239878:start -->
* [45239878](https://news.social-protocols.org/stats?id=45239878) #4 5 points 0 comments -> [Christian nationalists set sights on tiny Jackson County, Tennessee](https://www.newschannel5.com/news/newschannel-5-investigates/confronting-hate/aiming-to-radicalize-main-street-christian-nationalists-set-sights-on-tiny-jackson-county-tennessee)<!-- HN:45239878:end --><!-- HN:45240439:start -->
* [45240439](https://news.social-protocols.org/stats?id=45240439) #19 8 points 1 comments -> [PG: Supporters want to believe Kirk was killed by some powerful organized "them"](https://twitter.com/paulg/status/1967088969986044238)<!-- HN:45240439:end --><!-- HN:45211305:start -->
* [45211305](https://news.social-protocols.org/stats?id=45211305) #25 4 points 0 comments -> [Designing user interfaces with bots not buttons](https://interconnected.org/home/2022/05/09/npcs)<!-- HN:45211305:end --><!-- HN:45241457:start -->
* [45241457](https://news.social-protocols.org/stats?id=45241457) #29 6 points 1 comments -> [Anti-Israel protests force early end to Vuelta a España cycle race](https://www.reuters.com/sports/pro-palestinian-protests-disrupt-end-vuelta-cycle-race-2025-09-14/)<!-- HN:45241457:end --><!-- HN:45241690:start -->
* [45241690](https://news.social-protocols.org/stats?id=45241690) #29 10 points 2 comments -> [Medics in southern Gaza sound alarm over wave of newly displaced Palestinians](https://www.theguardian.com/world/2025/sep/14/southern-gaza-nasser-medics-displaced-palestinians-fleeing)<!-- HN:45241690:end --><!-- HN:45242565:start -->
* [45242565](https://news.social-protocols.org/stats?id=45242565) #28 6 points 0 comments -> [Taxpayers Will Pay Billions in New Fossil Fuel Subsidies for Big Beautiful Bill](https://www.wired.com/story/us-taxpayers-will-pay-billions-in-new-fossil-fuel-subsidies-thanks-to-the-big-beautiful-bill/)<!-- HN:45242565:end --><!-- HN:45242659:start -->
* [45242659](https://news.social-protocols.org/stats?id=45242659) #3 9 points 0 comments -> [Show HN: Update: Open-source private home security camera(end-to-end encryption)](https://github.com/secluso/secluso)<!-- HN:45242659:end --><!-- HN:45242075:start -->
* [45242075](https://news.social-protocols.org/stats?id=45242075) #9 -> [Lisp in 2025 (FOSS Book, 10 chapters)](https://github.com/cloudstreet-dev/Lisp-in-2025/blob/main/01-introduction.md)<!-- HN:45242075:end --><!-- HN:45241719:start -->
* [45241719](https://news.social-protocols.org/stats?id=45241719) #25 12 points 4 comments -> [The Perl Programming Language in 2025 (FOSS book)](https://github.com/cloudstreet-dev/The-PERL-Programming-Language/blob/main/01-why-perl-still-matters.md)<!-- HN:45241719:end --><!-- HN:45242645:start -->
* [45242645](https://news.social-protocols.org/stats?id=45242645) #23 22 points 18 comments -> [Show HN: DriftDB – An experimental append-only database with time-travel queries](https://github.com/DavidLiedle/DriftDB)<!-- HN:45242645:end -->
#### **Monday, September 15, 2025**
<!-- HN:45244733:start -->
* [45244733](https://news.social-protocols.org/stats?id=45244733) #7 43 points 21 comments -> [Rebutting 33 False Claims About Solar, Wind, and Electric Vehicles](https://scholarship.law.columbia.edu/cgi/viewcontent.cgi?article=1218&context=sabin_climate_change)<!-- HN:45244733:end --><!-- HN:45219356:start -->
* [45219356](https://news.social-protocols.org/stats?id=45219356) #22 12 points 1 comments -> [The Rise of 'Conspiracy Physics'](https://www.wsj.com/science/physics/the-rise-of-conspiracy-physics-dd79fe36)<!-- HN:45219356:end --><!-- HN:45251995:start -->
* [45251995](https://news.social-protocols.org/stats?id=45251995) #11 64 points 21 comments -> [The U.S. Government's Extraordinary Pursuit of Kilmar Ábrego García](https://www.newyorker.com/news/the-lede/the-us-governments-extraordinary-pursuit-of-kilmar-abrego-garcia)<!-- HN:45251995:end --><!-- HN:45249287:start -->
* [45249287](https://news.social-protocols.org/stats?id=45249287) #1 633 points 251 comments -> [Hosting a WebSite on a Disposable Vape](https://bogdanthegeek.github.io/blog/projects/vapeserver/)<!-- HN:45249287:end --><!-- HN:45255288:start -->
* [45255288](https://news.social-protocols.org/stats?id=45255288) #19 8 points 1 comments -> [Charlie Kirk Assassination Sparks Social Media Crackdown](https://www.kenklippenstein.com/p/charlie-kirk-assassination-sparks)<!-- HN:45255288:end -->
#### **Tuesday, September 16, 2025**
<!-- HN:45256229:start -->
* [45256229](https://news.social-protocols.org/stats?id=45256229) #21 19 points 5 comments -> [Fighting human trafficking with self-contained applications](https://lwn.net/SubscriberLink/1036916/2b10f1356b7ab0e7/)<!-- HN:45256229:end --><!-- HN:45256729:start -->
* [45256729](https://news.social-protocols.org/stats?id=45256729) #12 5 points 0 comments -> [FBI investigates social media accounts appearing have prior knowledge shooting](https://thepostmillennial.com/fbi-investigates-social-media-accounts-appearing-to-have-knowledge-of-charlie-kirk-shooting-beforehand-report)<!-- HN:45256729:end --><!-- HN:45259360:start -->
* [45259360](https://news.social-protocols.org/stats?id=45259360) #12 56 points 9 comments -> [Reichstag Fire Decree: Decree of the President for Protection of People & State](https://encyclopedia.ushmm.org/content/en/article/reichstag-fire-decree)<!-- HN:45259360:end --><!-- HN:45260379:start -->
* [45260379](https://news.social-protocols.org/stats?id=45260379) #27 5 points 0 comments -> [Spain becomes 3rd country to confirm Eurovision exit if Israel remains.](https://www.thejournal.ie/spain-becomes-first-of-eurovision-big-five-countries-to-confirm-it-will-withdraw-if-israel-remains-in-contest-6818193-Sep2025/)<!-- HN:45260379:end --><!-- HN:45260178:start -->
* [45260178](https://news.social-protocols.org/stats?id=45260178) #30 8 points 0 comments -> [Commenters Deemed Offensive After Charlie Kirk's Death Face Consequences](https://time.com/7316628/charlie-kirk-death-celebrations-social-media-consequences-fired-immigrants-deport/)<!-- HN:45260178:end --><!-- HN:45261120:start -->
* [45261120](https://news.social-protocols.org/stats?id=45261120) #18 10 points 0 comments -> [UN Independent International Commission: Israel has committed genocide in Gaza [pdf]](https://www.ohchr.org/sites/default/files/documents/hrbodies/hrcouncil/sessions-regular/session60/advance-version/a-hrc-60-crp-3.pdf)<!-- HN:45261120:end --><!-- HN:45264363:start -->
* [45264363](https://news.social-protocols.org/stats?id=45264363) #18 11 points 1 comments -> [Israel has committed genocide in the Gaza Strip, UN Commission finds](https://www.ohchr.org/en/press-releases/2025/09/israel-has-committed-genocide-gaza-strip-un-commission-finds)<!-- HN:45264363:end --><!-- HN:45265035:start -->
* [45265035](https://news.social-protocols.org/stats?id=45265035) #23 20 points 6 comments -> [US backpedals as Hyundai factory ICE raid enrages South Korea](https://www.theregister.com/2025/09/16/us_hyundai_immigration/)<!-- HN:45265035:end --><!-- HN:45266401:start -->
* [45266401](https://news.social-protocols.org/stats?id=45266401) #15 6 points 2 comments -> [Does Pam Bondi know what free speech is?](https://thespectator.com/topic/pam-bondi-know-what-free-speech/)<!-- HN:45266401:end --><!-- HN:45265937:start -->
* [45265937](https://news.social-protocols.org/stats?id=45265937) #4 43 points 3 comments -> [Live Updates: Shai-Hulud, the Most Dangerous NPM Breach in History](https://www.koi.security/blog/shai-hulud-npm-supply-chain-attack-crowdstrike-tinycolor)<!-- HN:45265937:end --><!-- HN:45268830:start -->
* [45268830](https://news.social-protocols.org/stats?id=45268830) #11 5 points 0 comments -> [Study Shows Number of Childless Women in the U.S. Continues to Rise](https://www.unh.edu/unhtoday/news/release/2025/09/15/study-shows-number-childless-women-us-continues-rise)<!-- HN:45268830:end -->
#### **Wednesday, September 17, 2025**<!-- HN:45271180:start -->
* [45271180](https://news.social-protocols.org/stats?id=45271180) #9 22 points 1 comments -> [Java 25 General Availability](https://jdk.java.net/25/)<!-- HN:45271180:end --><!-- HN:45274290:start -->
* [45274290](https://news.social-protocols.org/stats?id=45274290) #9 5 points 3 comments -> [Political Violence Makes No Sense](https://avi-loeb.medium.com/political-violence-makes-no-sense-cee20addd441)<!-- HN:45274290:end --><!-- HN:45276099:start -->
* [45276099](https://news.social-protocols.org/stats?id=45276099) #11 13 points 5 comments -> [AI Coding: A Sober Review](https://www.ubicloud.com/blog/ai-coding-a-sober-review)<!-- HN:45276099:end --><!-- HN:45276614:start -->
* [45276614](https://news.social-protocols.org/stats?id=45276614) #24 86 points 2 comments -> [A single adblock filter may have caused YouTube's global view drop](https://github.com/easylist/easylist/issues/22375)<!-- HN:45276614:end --><!-- HN:45279790:start -->
* [45279790](https://news.social-protocols.org/stats?id=45279790) #27 46 points 9 comments -> [The "Debate Me Bro" Grift: How Trolls Weaponized the Marketplace of Ideas](https://www.techdirt.com/2025/09/17/the-debate-me-bro-grift-how-trolls-weaponized-the-marketplace-of-ideas/)<!-- HN:45279790:end --><!-- HN:45282130:start -->
* [45282130](https://news.social-protocols.org/stats?id=45282130) #8 9 points 0 comments -> [Death of the Holocaust Industry](https://chrishedges.substack.com/p/death-of-the-holocaust-industry-read)<!-- HN:45282130:end -->
#### **Thursday, September 18, 2025**
<!-- HN:45283513:start -->
* [45283513](https://news.social-protocols.org/stats?id=45283513) #7 10 points 3 comments -> [Meta Ray Ban Display and Neural Interface Announced](https://about.fb.com/news/2025/09/meta-ray-ban-display-ai-glasses-emg-wristband/)<!-- HN:45283513:end --><!-- HN:45284477:start -->
* [45284477](https://news.social-protocols.org/stats?id=45284477) #1 98 points 39 comments -> [UC Berkeley gives personal information for 150 students and staff to government](https://www.dailycal.org/news/campus/uc-berkeley-turns-over-personal-information-of-more-than-150-students-and-staff-to-federal/article_a4aad3e1-bbba-42cc-92d7-a7964d9641c5.html)<!-- HN:45284477:end --><!-- HN:45285253:start -->
* [45285253](https://news.social-protocols.org/stats?id=45285253) #22 10 points 1 comments -> [ABC Pulls Jimmy Kimmel Off Air for Charlie Kirk Comments After FCC Pressure](https://www.nytimes.com/2025/09/17/business/media/abc-jimmy-kimmel.html)<!-- HN:45285253:end --><!-- HN:45288627:start -->
* [45288627](https://news.social-protocols.org/stats?id=45288627) #8 3 points 1 comments -> [Jack Dorsey Is Jesus Christ Returned](https://indignified.substack.com/p/jack-dorsey-is-jesus-christ-returned)<!-- HN:45288627:end --><!-- HN:45288457:start -->
* [45288457](https://news.social-protocols.org/stats?id=45288457) #9 7 points 0 comments -> [Track Aipac (American Israel Public Affairs Committee) Donations](https://www.trackaipac.com)<!-- HN:45288457:end --><!-- HN:45288888:start -->
* [45288888](https://news.social-protocols.org/stats?id=45288888) #30 9 points 1 comments -> [Exploiting Male Rage](https://paulkrugman.substack.com/p/exploiting-male-rage)<!-- HN:45288888:end --><!-- HN:45289848:start -->
* [45289848](https://news.social-protocols.org/stats?id=45289848) #8 9 points 2 comments -> [React hook causes downtime at Cloudflare, which just stopped the biggest DDoS](https://blog.cloudflare.com/deep-dive-into-cloudflares-sept-12-dashboard-and-api-outage/)<!-- HN:45289848:end --><!-- HN:45291169:start -->
* [45291169](https://news.social-protocols.org/stats?id=45291169) #25 27 points 10 comments -> [New bill aims to block both online adult content and VPNs](https://www.cnet.com/tech/services-and-software/new-bill-aims-to-block-both-online-adult-content-and-vpns/)<!-- HN:45291169:end --><!-- HN:45291504:start -->
* [45291504](https://news.social-protocols.org/stats?id=45291504) #10 66 points 4 comments -> [ABC Pulls Jimmy Kimmel Off Air After FCC Pressure](https://www.nytimes.com/2025/09/17/business/media/abc-jimmy-kimmel.html)<!-- HN:45291504:end --><!-- HN:45292033:start -->
* [45292033](https://news.social-protocols.org/stats?id=45292033) #8 -> [ICE report finds 60 violations in 50 days at Fort Bliss migrant facility](https://www.elpasotimes.com/story/news/immigration/2025/09/17/ice-finds-60-violations-at-fort-bliss-migrant-facility-in-texas/86199672007/)<!-- HN:45292033:end --><!-- HN:45292130:start -->
* [45292130](https://news.social-protocols.org/stats?id=45292130) #10 41 points 10 comments -> [Yes, Jimmy Kimmel's suspension was government censorship](https://www.theverge.com/policy/781148/jimmy-kimmel-charlie-kirk-monologue-brendan-carr-censorship-first-amendment)<!-- HN:45292130:end --><!-- HN:45293757:start -->
* [45293757](https://news.social-protocols.org/stats?id=45293757) #16 5 points 0 comments -> [Organs Cannot Simply Be Classified as Male or Female](https://www.mpg.de/25425064/0918-limn-the-sex-of-the-body-why-our-organs-cannot-simply-be-classified-as-male-or-female-153345-x)<!-- HN:45293757:end --><!-- HN:45295388:start -->
* [45295388](https://news.social-protocols.org/stats?id=45295388) #25 14 points 14 comments -> [Returning to Church won't save us from nihilism](https://thereader.mitpress.mit.edu/returning-to-church-wont-save-us-from-nihilism/)<!-- HN:45295388:end --><!-- HN:45296182:start -->
* [45296182](https://news.social-protocols.org/stats?id=45296182) #8 47 points 14 comments -> [Jimmy Kimmel Should Have Strong Odds at the Supreme Court](https://www.politico.com/news/magazine/2025/09/18/jimmy-kimmel-supreme-court-first-amendment-lawsuit-00570697)<!-- HN:45296182:end -->
#### **Friday, September 19, 2025**
<!-- HN:45248709:start -->
* [45248709](https://news.social-protocols.org/stats?id=45248709) #16 10 points 5 comments -> [Pizza Cutters, from Underdesigned to Overdesigned](https://www.core77.com/posts/138409/Pizza-Cutters-from-Underdesigned-to-Overdesigned)<!-- HN:45248709:end --><!-- HN:45300925:start -->
* [45300925](https://news.social-protocols.org/stats?id=45300925) #16 34 points 23 comments -> [Grocery prices have jumped up, and there's no relief in sight](https://www.npr.org/2025/09/19/nx-s1-5539547/grocery-prices-tariffs-food-inflation)<!-- HN:45300925:end --><!-- HN:45301603:start -->
* [45301603](https://news.social-protocols.org/stats?id=45301603) #1 20 points 6 comments -> [The Invisible Character That Cost Me Too Much Debugging Time](https://blog.dochia.dev/blog/the-invisible-character/)<!-- HN:45301603:end --><!-- HN:45304992:start -->
* [45304992](https://news.social-protocols.org/stats?id=45304992) #26 112 points 59 comments -> [After getting Jimmy Kimmel suspended, FCC chair threatens ABC's The View](https://arstechnica.com/tech-policy/2025/09/after-getting-jimmy-kimmel-suspended-fcc-chair-threatens-abcs-the-view/)<!-- HN:45304992:end --><!-- HN:45306210:start -->
* [45306210](https://news.social-protocols.org/stats?id=45306210) #3 12 points 0 comments -> [Genocide in the Gaza Strip: Brazil files a declaration of intervention to ICJ [pdf]](https://www.icj-cij.org/sites/default/files/case-related/192/192-20250919-pre-01-00-en.pdf)<!-- HN:45306210:end --><!-- HN:45306975:start -->
* [45306975](https://news.social-protocols.org/stats?id=45306975) #21 11 points 1 comments -> [Ted Cruz: MAGA "will regret" what it did to Jimmy Kimmel](https://www.axios.com/2025/09/19/ted-cruz-jimmy-kimmel-fcc-brendan-carr)<!-- HN:45306975:end --><!-- HN:45307003:start -->
* [45307003](https://news.social-protocols.org/stats?id=45307003) #21 33 points 24 comments -> [Rails Needs New Governance](https://davidcel.is/articles/rails-needs-new-governance)<!-- HN:45307003:end -->
#### **Saturday, September 20, 2025**
<!-- HN:45308628:start -->
* [45308628](https://news.social-protocols.org/stats?id=45308628) #2 135 points 3 comments -> [H1Bs will start costing $100k/yr](https://www.boundless.com/blog/trump-administration-to-propose-new-100000-fee-for-h-1b-visa-applications/)<!-- HN:45308628:end --><!-- HN:45308778:start -->
* [45308778](https://news.social-protocols.org/stats?id=45308778) #14 74 points 54 comments -> [Trumpcard (Official US Government Website)](https://trumpcard.gov/)<!-- HN:45308778:end --><!-- HN:45308503:start -->
* [45308503](https://news.social-protocols.org/stats?id=45308503) #3 98 points 42 comments -> [Did you read the quarter-million-line license for your Slack app?](https://mastodon.mit.edu/@Eggfreckles/114825126857396420)<!-- HN:45308503:end --><!-- HN:45312457:start -->
* [45312457](https://news.social-protocols.org/stats?id=45312457) #29 29 points 41 comments -> [The Gold Card](https://www.whitehouse.gov/presidential-actions/2025/09/the-gold-card/)<!-- HN:45312457:end --><!-- HN:45313589:start -->
* [45313589](https://news.social-protocols.org/stats?id=45313589) #26 5 points 8 comments -> [Embrace hope, reject assisted suicide](https://thecritic.co.uk/embrace-hope-reject-assisted-suicide/)<!-- HN:45313589:end --><!-- HN:45313844:start -->
* [45313844](https://news.social-protocols.org/stats?id=45313844) #11 9 points 0 comments -> [H-1B Jobs Direct](https://guestworkervisas.com/gwv/jobs_direct.php)<!-- HN:45313844:end --><!-- HN:45281913:start -->
* [45281913](https://news.social-protocols.org/stats?id=45281913) #30 25 points 33 comments -> [Bosch Unveils New Brake Technology](https://thebrakereport.com/bosch-unveils-new-brake-technology-driving-future-automation/)<!-- HN:45281913:end --><!-- HN:45316555:start -->
* [45316555](https://news.social-protocols.org/stats?id=45316555) #27 -> [Albert Einstein Gives a Speech Praising Immigrants' Contributions to America](https://www.openculture.com/2025/09/albert-einstein-gives-a-speech-praising-diversity-immigrants-contributions.html)<!-- HN:45316555:end --><!-- HN:45318505:start -->
* [45318505](https://news.social-protocols.org/stats?id=45318505) #26 -> [California bans face masks for ICE agents](https://sfstandard.com/2025/09/20/california-bans-face-masks-ice-agents/)<!-- HN:45318505:end -->
#### **Sunday, September 21, 2025**
<!-- HN:45318657:start -->
* [45318657](https://news.social-protocols.org/stats?id=45318657) #21 12 points 2 comments -> [Justice Dept. Closed Investigation into Tom Homan for Accepting Bag of Cash](https://www.nytimes.com/2025/09/20/us/politics/tom-homan-fbi-trump.html)<!-- HN:45318657:end --><!-- HN:45318917:start -->
* [45318917](https://news.social-protocols.org/stats?id=45318917) #17 6 points 0 comments -> [As Ellison Buys Out TikTok, US Moves Toward One-Party Media](https://fair.org/home/as-ellison-buys-out-tiktok-us-moves-toward-one-party-media/)<!-- HN:45318917:end -->