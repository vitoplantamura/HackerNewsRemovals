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
* [48093950](https://news.social-protocols.org/stats?id=48093950) #4 10 points 2 comments -> [From Today, Software Engineering Is Dead](https://building138.com/from-today-software-engineering-is-dead)<!-- HN:48093950:end --><!-- HN:48095566:start -->
* [48095566](https://news.social-protocols.org/stats?id=48095566) #30 5 points 0 comments -> [Iran's two-tier internet access fuels anger and exposes cracks in the regime](https://www.cnn.com/2026/05/10/middleeast/iran-internet-pro-blackout-access-vpn-intl)<!-- HN:48095566:end --><!-- HN:48096045:start -->
* [48096045](https://news.social-protocols.org/stats?id=48096045) #16 14 points 15 comments -> [Show HN: Free tool to see how much AI bots are costing your site](https://botcost.dev)<!-- HN:48096045:end --><!-- HN:48097651:start -->
* [48097651](https://news.social-protocols.org/stats?id=48097651) #5 11 points 5 comments -> [How to Leave Instagram](https://www.a-side.social/blog/how-to-leave-instagram/)<!-- HN:48097651:end --><!-- HN:48096471:start -->
* [48096471](https://news.social-protocols.org/stats?id=48096471) #25 40 points 38 comments -> [Should you leave red herrings about yourself online?](https://blog.alcazarsec.com/posts/should-you-leave-red-herrings-about-yourself-online)<!-- HN:48096471:end --><!-- HN:48074229:start -->
* [48074229](https://news.social-protocols.org/stats?id=48074229) #21 4 points 0 comments -> [Mouse Wheel Tweaks](https://mcpedl.com/mouse-wheel-tweaks/)<!-- HN:48074229:end -->
#### **Tuesday, May 12, 2026**
<!-- HN:48102221:start -->
* [48102221](https://news.social-protocols.org/stats?id=48102221) #15 6 points 0 comments -> [Postmortem: TanStack NPM supply-chain compromise](https://tanstack.com/blog/npm-supply-chain-compromise-postmortem)<!-- HN:48102221:end --><!-- HN:48103459:start -->
* [48103459](https://news.social-protocols.org/stats?id=48103459) #12 38 points 27 comments -> [Fake building: Claude wrote 3k lines instead of import pywikibot](https://fireflysentinel.github.io/posts/fake-building-claude-3000-lines/)<!-- HN:48103459:end --><!-- HN:48108273:start -->
* [48108273](https://news.social-protocols.org/stats?id=48108273) #27 8 points 0 comments -> [The gutting of USAID has left a void China will not fill](https://www.economist.com/asia/2026/05/07/the-gutting-of-usaid-has-left-a-void-china-will-not-fill)<!-- HN:48108273:end --><!-- HN:48075303:start -->
* [48075303](https://news.social-protocols.org/stats?id=48075303) #14 5 points 0 comments -> [Jankó Keyboard](https://en.wikipedia.org/wiki/Jank%C3%B3_keyboard)<!-- HN:48075303:end --><!-- HN:48080179:start -->
* [48080179](https://news.social-protocols.org/stats?id=48080179) #30 27 points 40 comments -> [Analysis points to a unexpected cause of reading difficulties](https://phys.org/news/2026-05-years-struggles-obvious-massive-analysis.html)<!-- HN:48080179:end --><!-- HN:48112190:start -->
* [48112190](https://news.social-protocols.org/stats?id=48112190) #22 15 points 3 comments -> [Unauthorized Anthropic stock sales and investment scams](https://support.claude.com/en/articles/13704655-unauthorized-anthropic-stock-sales-and-investment-scams)<!-- HN:48112190:end -->
#### **Wednesday, May 13, 2026**
<!-- HN:48116604:start -->
* [48116604](https://news.social-protocols.org/stats?id=48116604) #30 15 points 6 comments -> [AI shouldn't have a meter. Unlimited tokens. Forever](https://www.openmonoagent.ai/)<!-- HN:48116604:end --><!-- HN:48117733:start -->
* [48117733](https://news.social-protocols.org/stats?id=48117733) #30 4 points 1 comments -> [We tested super-resolution pre-filter for LPR OCR. It did nothing](https://www.wink.co/documentation/Neural-Super-Resolution-Pre-Filter-LPR-2026)<!-- HN:48117733:end --><!-- HN:48118573:start -->
* [48118573](https://news.social-protocols.org/stats?id=48118573) #8 5 points 4 comments -> [One Startup Is Gambling. Ten Is Mathematics](https://www.mynameisfeng.com/blog/one-startup-is-gambling-ten-is-mathematics)<!-- HN:48118573:end --><!-- HN:48118908:start -->
* [48118908](https://news.social-protocols.org/stats?id=48118908) #3 9 points 11 comments -> [AluminiumOS, by Google: Android Reimagined for the Desktop](https://aluminium-os.com/)<!-- HN:48118908:end --><!-- HN:48120081:start -->
* [48120081](https://news.social-protocols.org/stats?id=48120081) #27 4 points 2 comments -> [Show HN: I asked AI to write Sci-Fi for eternity](https://f055.net/thattimei/that-time-i-asked-ai-to-write-sci-fi-for-eternity/)<!-- HN:48120081:end --><!-- HN:48122624:start -->
* [48122624](https://news.social-protocols.org/stats?id=48122624) #21 34 points 41 comments -> [The AI Backlash Could Get Ugly](https://www.theatlantic.com/technology/2026/05/ai-backlash-data-centers-political-violence/687151/)<!-- HN:48122624:end --><!-- HN:48122285:start -->
* [48122285](https://news.social-protocols.org/stats?id=48122285) #28 6 points 6 comments -> [European Stagnation Is Real](https://www.siliconcontinent.com/p/european-stagnation-is-real)<!-- HN:48122285:end --><!-- HN:48125757:start -->
* [48125757](https://news.social-protocols.org/stats?id=48125757) #8 6 points 2 comments -> [Nginx.org/En/Changes](https://nginx.org/en/CHANGES)<!-- HN:48125757:end --><!-- HN:48125194:start -->
* [48125194](https://news.social-protocols.org/stats?id=48125194) #22 9 points 5 comments -> [Telegram Is Gone](https://lazybea.rs/telegram-is-gone/)<!-- HN:48125194:end --><!-- HN:48125494:start -->
* [48125494](https://news.social-protocols.org/stats?id=48125494) #29 68 points 21 comments -> [ReactOS](https://reactos.org/)<!-- HN:48125494:end -->
#### **Thursday, May 14, 2026**
<!-- HN:48129598:start -->
* [48129598](https://news.social-protocols.org/stats?id=48129598) #1 23 points 8 comments -> [Who Trusts Sam Altman?](https://techcrunch.com/2026/05/13/who-trusts-sam-altman/)<!-- HN:48129598:end --><!-- HN:48130976:start -->
* [48130976](https://news.social-protocols.org/stats?id=48130976) #15 12 points 2 comments -> [Built to help my dad pass CCNA, now were changing how people learn networking](https://switchlab.dev/)<!-- HN:48130976:end --><!-- HN:48131888:start -->
* [48131888](https://news.social-protocols.org/stats?id=48131888) #16 25 points 16 comments -> [LLMs are breaking 20 year old system design](https://zknill.io/posts/llms-are-breaking-20-year-old-system-design/)<!-- HN:48131888:end --><!-- HN:48132159:start -->
* [48132159](https://news.social-protocols.org/stats?id=48132159) #5 27 points 40 comments -> [What the Hell Was Going on with Cigarette Ads in the 70s?](https://tohippo.com/what-the-hell-was-going-on-with-cigarette-ads-in-the-70s/)<!-- HN:48132159:end --><!-- HN:48133917:start -->
* [48133917](https://news.social-protocols.org/stats?id=48133917) #21 8 points 4 comments -> [Ryan Cohen hits back at eBay, says his takeover proposal should not be dismissed](https://www.reuters.com/world/ryan-cohen-says-ebay-directors-should-not-dismiss-his-proposal-without-engaging-2026-05-13/)<!-- HN:48133917:end -->