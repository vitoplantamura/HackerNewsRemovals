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

#### **Tuesday, May 5, 2026**
<!-- HN:48017526:start -->
* [48017526](https://news.social-protocols.org/stats?id=48017526) #23 6 points 8 comments -> [Linux, Windows or macOS: Which Operating System to Use in 2026?](https://www.lucasaguiar.xyz/posts/linux-windows-macos-qual-usar-2026/)<!-- HN:48017526:end --><!-- HN:48017602:start -->
* [48017602](https://news.social-protocols.org/stats?id=48017602) #13 12 points 4 comments -> [An LLM agent that runs on any Linux box](https://getclaw.site/#demo)<!-- HN:48017602:end --><!-- HN:48018098:start -->
* [48018098](https://news.social-protocols.org/stats?id=48018098) #11 10 points 5 comments -> [OpenAI can't build working RSS feeds](https://openai.com/news/rss.xml)<!-- HN:48018098:end --><!-- HN:48020249:start -->
* [48020249](https://news.social-protocols.org/stats?id=48020249) #25 13 points 8 comments -> [Show HN: Got tired of paying $100/mo for SEO tools, so I built an alternative](https://idiotproofseo.com/)<!-- HN:48020249:end --><!-- HN:48027022:start -->
* [48027022](https://news.social-protocols.org/stats?id=48027022) #13 8 points 5 comments -> [What five years of data tells us about lasting relationships](https://hanker.dating/study)<!-- HN:48027022:end -->
#### **Wednesday, May 6, 2026**
<!-- HN:48029034:start -->
* [48029034](https://news.social-protocols.org/stats?id=48029034) #26 16 points 6 comments -> [A website ranking judges by elo for the cases they dismiss in SF](https://sfcrime.pages.dev/)<!-- HN:48029034:end --><!-- HN:48029334:start -->
* [48029334](https://news.social-protocols.org/stats?id=48029334) #13 143 points 3 comments -> [Zuckerberg 'personally authorized' Meta's copyright infringement, publishers say](https://apnews.com/article/meta-mark-zuckerberg-ai-publishers-lawsuit-llama-5609846d4d840014974a847b01079c32)<!-- HN:48029334:end --><!-- HN:48033118:start -->
* [48033118](https://news.social-protocols.org/stats?id=48033118) #5 11 points 1 comments -> [.de domains were 'down' for 2 hours](https://status.denic.de/pages/incident/592577eab611ce1e0d00046f/69fa60ef9d12f5057a974f38)<!-- HN:48033118:end --><!-- HN:48033729:start -->
* [48033729](https://news.social-protocols.org/stats?id=48033729) #4 8 points 2 comments -> [You made me rich, thank you](https://github.com/theori-io/copy-fail-CVE-2026-31431/issues/128)<!-- HN:48033729:end --><!-- HN:48033689:start -->
* [48033689](https://news.social-protocols.org/stats?id=48033689) #30 34 points 35 comments -> [The Boring Internet](https://www.terrygodier.com/the-boring-internet)<!-- HN:48033689:end --><!-- HN:48033952:start -->
* [48033952](https://news.social-protocols.org/stats?id=48033952) #22 10 points 2 comments -> [The AI operator: Biggest role in Silicon Valley](https://www.rishgupta.com/blog/the-ai-operator-biggest-role-in-silicon-valley)<!-- HN:48033952:end --><!-- HN:48034372:start -->
* [48034372](https://news.social-protocols.org/stats?id=48034372) #19 24 points 14 comments -> [NZ Government to Disestablish the BSA](https://www.beehive.govt.nz/release/government-disestablish-bsa)<!-- HN:48034372:end --><!-- HN:48035874:start -->
* [48035874](https://news.social-protocols.org/stats?id=48035874) #5 5 points 0 comments -> [Australia will run an overt command economy by 2040](https://caseyhandmer.wordpress.com/2026/04/16/australia-will-run-an-overt-command-economy-by-2040/)<!-- HN:48035874:end --><!-- HN:48036524:start -->
* [48036524](https://news.social-protocols.org/stats?id=48036524) #8 5 points 3 comments -> [The next great software company won't sell software](https://blog.layerx.xyz/service-as-a-software)<!-- HN:48036524:end --><!-- HN:48037465:start -->
* [48037465](https://news.social-protocols.org/stats?id=48037465) #2 27 points 8 comments -> [Some kids are bypassing age verification checks with a fake mustache](https://techcrunch.com/2026/05/06/some-kids-are-bypassing-age-verification-checks-with-a-fake-mustache/)<!-- HN:48037465:end --><!-- HN:48038031:start -->
* [48038031](https://news.social-protocols.org/stats?id=48038031) #6 29 points 40 comments -> [The Disadvantages of an Elite Education (2008)](https://theamericanscholar.org/the-disadvantages-of-an-elite-education/)<!-- HN:48038031:end -->
#### **Thursday, May 7, 2026**
<!-- HN:48042842:start -->
* [48042842](https://news.social-protocols.org/stats?id=48042842) #17 61 points 39 comments -> [David Sacks crashed and burned in the White House](https://www.theverge.com/column/925487/david-sacks-trump-administration-ai-model-review)<!-- HN:48042842:end --><!-- HN:48043378:start -->
* [48043378](https://news.social-protocols.org/stats?id=48043378) #22 40 points 14 comments -> [Kash Patel's Personalized Bourbon Stash](https://www.theatlantic.com/politics/2026/05/kash-patel-fbi-bourbon/687066/)<!-- HN:48043378:end --><!-- HN:48043866:start -->
* [48043866](https://news.social-protocols.org/stats?id=48043866) #22 14 points 2 comments -> [They Don't Look Like Me](https://niccolorastrelli.com/they-dont-look-like-me)<!-- HN:48043866:end --><!-- HN:48044022:start -->
* [48044022](https://news.social-protocols.org/stats?id=48044022) #10 37 points 10 comments -> [How I made $350K from an open-source JavaScript library using dual licensing](https://www.paritydeals.com/blog/monetize-open-source-dual-licensing/)<!-- HN:48044022:end --><!-- HN:48046874:start -->
* [48046874](https://news.social-protocols.org/stats?id=48046874) #19 24 points 19 comments -> [Show HN: Social Network for Corporate Cringe](https://CringeOut.com)<!-- HN:48046874:end --><!-- HN:48038750:start -->
* [48038750](https://news.social-protocols.org/stats?id=48038750) #30 77 points 1 comments -> [SoundOff: Low-Cost Passive Ultrasound Tags](https://yibo-fu.com/SoundOff-Low-cost-Passive-Ultrasound-Tags-for-Non-invasive-and-Non)<!-- HN:48038750:end --><!-- HN:48048121:start -->
* [48048121](https://news.social-protocols.org/stats?id=48048121) #19 18 points 8 comments -> [KLM flight attendant hospitalized after contact with hantavirus](https://nltimes.nl/2026/05/07/klm-flight-attendant-hospitalized-contact-hantavirus-cruise-ship-passenger)<!-- HN:48048121:end --><!-- HN:48051080:start -->
* [48051080](https://news.social-protocols.org/stats?id=48051080) #2 60 points 30 comments -> [Authorities say Flock cameras' data allegedly used for immigration enforcement](https://www.ohio.news/stories/dayton-authorities-say-that-flock-cameras-data-allegedly-used-for-immigration-enforcement/)<!-- HN:48051080:end --><!-- HN:48054732:start -->
* [48054732](https://news.social-protocols.org/stats?id=48054732) #8 49 points 15 comments -> [Utah senator smacks ABC reporters phone out of hand amid Data Center controversy](https://www.abc4.com/news/digital-exclusives/reporter-jj-nursery-utah-senator-jerry-stevenson-box-elder-county-data-center/)<!-- HN:48054732:end --><!-- HN:48054953:start -->
* [48054953](https://news.social-protocols.org/stats?id=48054953) #12 7 points 1 comments -> [Why The Pentagon Is Quadrupling Missile Production, and Why It Won't Be Enough](https://militarymachine.com/pentagon-missile-production-surge-2026)<!-- HN:48054953:end -->
#### **Friday, May 8, 2026**<!-- HN:48056003:start -->
* [48056003](https://news.social-protocols.org/stats?id=48056003) #23 33 points 56 comments -> [OpenClaw Had a Rough Week](https://openclaw.ai/blog/openclaw-rough-week)<!-- HN:48056003:end --><!-- HN:48058217:start -->
* [48058217](https://news.social-protocols.org/stats?id=48058217) #19 17 points 2 comments -> [New York state set to ban law enforcement, including ICE, from wearing masks](https://www.reuters.com/legal/government/new-york-state-set-ban-law-enforcement-including-ice-wearing-masks-2026-05-07/)<!-- HN:48058217:end --><!-- HN:48062530:start -->
* [48062530](https://news.social-protocols.org/stats?id=48062530) #18 37 points 41 comments -> [UFO Release 1: Presidential Unsealing and Reporting System for UAP Encounters](https://www.war.gov/UFO/#release)<!-- HN:48062530:end --><!-- HN:48065332:start -->
* [48065332](https://news.social-protocols.org/stats?id=48065332) #15 10 points 0 comments -> [Banks are funding climate chaos. You don't have to](https://www.not-ship.com/banks-are-funding-climate-chaos-you-dont-have-to-2/)<!-- HN:48065332:end --><!-- HN:48069009:start -->
* [48069009](https://news.social-protocols.org/stats?id=48069009) #27 5 points 1 comments -> [If Anyone Builds It, Everyone Dies](https://ifanyonebuildsit.com/)<!-- HN:48069009:end --><!-- HN:48068475:start -->
* [48068475](https://news.social-protocols.org/stats?id=48068475) #14 17 points 1 comments -> [Dirty Frag: Universal Linux LPE](https://github.com/V4bel/dirtyfrag)<!-- HN:48068475:end --><!-- HN:48069354:start -->
* [48069354](https://news.social-protocols.org/stats?id=48069354) #19 -> [Judge rules DOGE cancellation of humanities grants was unconstitutional](https://apnews.com/article/trump-doge-humanities-funding-cuts-dda1383436c41be08da3bbf7cc08818e)<!-- HN:48069354:end --><!-- HN:48069088:start -->
* [48069088](https://news.social-protocols.org/stats?id=48069088) #3 37 points 9 comments -> [AWS data center outage hits trading on Fanduel, Coinbase](https://www.cnbc.com/2026/05/08/aws-outage-data-center-fanduel-coinbase.html)<!-- HN:48069088:end -->
#### **Saturday, May 9, 2026**
<!-- HN:48069844:start -->
* [48069844](https://news.social-protocols.org/stats?id=48069844) #25 3 points 0 comments -> [Unprecedented GPS Game in the AppStore](https://cheapshot.co/)<!-- HN:48069844:end --><!-- HN:48070721:start -->
* [48070721](https://news.social-protocols.org/stats?id=48070721) #22 6 points 23 comments -> [I built GitHub Store to 12,500 stars in 6 months – I started at 16](https://github-store.org/blog/how-i-built-github-store/)<!-- HN:48070721:end --><!-- HN:48072319:start -->
* [48072319](https://news.social-protocols.org/stats?id=48072319) #30 39 points 29 comments -> [I Will Never Use AI to Code](https://antman-does-software.com/i-will-never-use-ai-to-code-or-write)<!-- HN:48072319:end --><!-- HN:48072671:start -->
* [48072671](https://news.social-protocols.org/stats?id=48072671) #6 19 points 2 comments -> [Mythos 'Discovered' a CVE in Its Training Data and That's Still Worrying](https://rival.security/posts/mythos-discovered-a-cve-already-in-its-training-data---and-thats-still-worrying)<!-- HN:48072671:end --><!-- HN:48040522:start -->
* [48040522](https://news.social-protocols.org/stats?id=48040522) #27 13 points 3 comments -> [How to Optimize MongoDB Query Performance with Indexes](https://visualeaf.com/blog/mongodb-query-optimization-indexes/)<!-- HN:48040522:end --><!-- HN:48077231:start -->
* [48077231](https://news.social-protocols.org/stats?id=48077231) #3 89 points 4 comments -> [Bun ported to Rust in 6 days](https://xunroll.com/thread/2053047748191232310)<!-- HN:48077231:end --><!-- HN:48077314:start -->
* [48077314](https://news.social-protocols.org/stats?id=48077314) #11 29 points 11 comments -> ["Dirty Frag" (CVE-2026-43284): The Second Linux Root Exploit in Eight Days](https://www.copahost.com/blog/dirty-frag-cve-2026-43284/)<!-- HN:48077314:end --><!-- HN:48078538:start -->
* [48078538](https://news.social-protocols.org/stats?id=48078538) #17 10 points 2 comments -> [The 90 Day disclosure policy is dead](https://blog.himanshuanand.com/2026/05/the-90-day-disclosure-policy-is-dead/)<!-- HN:48078538:end --><!-- HN:48078617:start -->
* [48078617](https://news.social-protocols.org/stats?id=48078617) #18 3 points 0 comments -> [The Death of the Roadmap](https://debarshibasak.github.io/readables/blogs/death-of-roadmap.html)<!-- HN:48078617:end --><!-- HN:48079114:start -->
* [48079114](https://news.social-protocols.org/stats?id=48079114) #8 10 points 0 comments -> [User just tricked Grok and Bankrbot to send tokens with Morse code](https://www.cryptopolitan.com/user-tricked-grok-bankrbot-to-send-tokens/)<!-- HN:48079114:end -->
#### **Sunday, May 10, 2026**
<!-- HN:48072720:start -->
* [48072720](https://news.social-protocols.org/stats?id=48072720) #30 178 points 72 comments -> [All my clients wanted a carousel, now it's an AI chatbot](https://adele.pages.casa/md/blog/all-my-clients-wanted-a-carousel-now-it-s-an-ai-chatbot.md)<!-- HN:48072720:end --><!-- HN:48082342:start -->
* [48082342](https://news.social-protocols.org/stats?id=48082342) #15 8 points 3 comments -> [FreeBSD – A Lesson in Poor Defaults](https://vez.mrsk.me/freebsd-defaults)<!-- HN:48082342:end --><!-- HN:48081094:start -->
* [48081094](https://news.social-protocols.org/stats?id=48081094) #18 25 points 29 comments -> [Scouting's Real Crisis Is Not Marketing. It Is Decades of Neglect.](https://www.untendedfire.org/2026/05/09/scoutings-real-crisis-is-not-marketing-it-is-decades-of-neglect/)<!-- HN:48081094:end -->
#### **Monday, May 11, 2026**<!-- HN:48089319:start -->
* [48089319](https://news.social-protocols.org/stats?id=48089319) #14 18 points 7 comments -> [AI Productivity Fails](https://blog.sshh.io/p/how-ai-productivity-fails)<!-- HN:48089319:end --><!-- HN:48089531:start -->
* [48089531](https://news.social-protocols.org/stats?id=48089531) #27 18 points 12 comments -> [Make America AI Ready: Strengths, Weaknesses, and Recommendations](https://blog.citp.princeton.edu/2026/05/05/make-america-ai-ready-strengths-weaknesses-and-recommendations/)<!-- HN:48089531:end --><!-- HN:48067402:start -->
* [48067402](https://news.social-protocols.org/stats?id=48067402) #17 26 points 7 comments -> [I designed Microsoft's EA channel in 2001. It's being dismantled in 2026](https://www.brendanoconnor.net/case-studies/microsoft-enterprise-channel/)<!-- HN:48067402:end --><!-- HN:48090349:start -->
* [48090349](https://news.social-protocols.org/stats?id=48090349) #15 6 points 0 comments -> [BSides Austin Is on Hold](https://bsidesaustin.com/)<!-- HN:48090349:end --><!-- HN:48092462:start -->
* [48092462](https://news.social-protocols.org/stats?id=48092462) #25 8 points 0 comments -> [Truth Social lays bare narrow obsessions of an online president](https://www.npr.org/2026/05/08/nx-s1-5749358/trump-truth-social-online-posts-iran-white-house-ballroom)<!-- HN:48092462:end --><!-- HN:48093016:start -->
* [48093016](https://news.social-protocols.org/stats?id=48093016) #13 7 points 5 comments -> [When Is "Next Friday"?](https://whenisnextfriday.com/)<!-- HN:48093016:end --><!-- HN:48093468:start -->
* [48093468](https://news.social-protocols.org/stats?id=48093468) #14 16 points 1 comments -> [Organized Dogmatism Controls the Message about Gender Bias in the Academy](https://journalofcontroversialideas.org/article/6/1/313)<!-- HN:48093468:end --><!-- HN:48093950:start -->
* [48093950](https://news.social-protocols.org/stats?id=48093950) #4 10 points 2 comments -> [From Today, Software Engineering Is Dead](https://building138.com/from-today-software-engineering-is-dead)<!-- HN:48093950:end -->