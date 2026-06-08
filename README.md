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

#### **Tuesday, June 2, 2026**
<!-- HN:48367253:start -->
* [48367253](https://news.social-protocols.org/stats?id=48367253) #9 -> [Cloudflare CDN Pricing 2026: Real Cost per GB, Hidden Fees and Best Alternatives](https://blog.blazingcdn.com/en-us/what-is-the-price-per-gb-of-cloudflare-cdn)<!-- HN:48367253:end --><!-- HN:48367009:start -->
* [48367009](https://news.social-protocols.org/stats?id=48367009) #23 5 points 3 comments -> [Not Every Byte Gets a Vote](https://mitander.xyz/posts/not-every-byte-gets-a-vote/)<!-- HN:48367009:end --><!-- HN:48368456:start -->
* [48368456](https://news.social-protocols.org/stats?id=48368456) #25 6 points 0 comments -> [A Zipper Patent Sat in a Garage for 40 Years. Now It's Real.](https://www.yankodesign.com/2026/05/31/a-zipper-patent-sat-in-a-garage-for-40-years-now-its-real/)<!-- HN:48368456:end --><!-- HN:48357075:start -->
* [48357075](https://news.social-protocols.org/stats?id=48357075) #26 529 points 49 comments -> [CS336: Language Modeling from Scratch](https://cs336.stanford.edu/)<!-- HN:48357075:end --><!-- HN:48371671:start -->
* [48371671](https://news.social-protocols.org/stats?id=48371671) #22 -> ["I was just scammed for $500K by Polymarket."](https://xcancel.com/willo2_Poly/status/2061640812132516321)<!-- HN:48371671:end --><!-- HN:48375544:start -->
* [48375544](https://news.social-protocols.org/stats?id=48375544) #3 55 points 27 comments -> [Uber caps employee AI spending after blowing through budget in four months](https://techcrunch.com/2026/06/02/uber-caps-employee-ai-spending-after-blowing-through-budget-in-four-months/)<!-- HN:48375544:end --><!-- HN:48377014:start -->
* [48377014](https://news.social-protocols.org/stats?id=48377014) #7 -> [I got tired of proprietary supplement blends, so I open-sourced my formulas](https://nuc.luyml.com)<!-- HN:48377014:end -->
#### **Wednesday, June 3, 2026**
<!-- HN:48378099:start -->
* [48378099](https://news.social-protocols.org/stats?id=48378099) #30 60 points 56 comments -> [I Don't Want My Search Engine to Think for Me](https://searchzee.com/blog/search-without-ai-summaries)<!-- HN:48378099:end --><!-- HN:48377631:start -->
* [48377631](https://news.social-protocols.org/stats?id=48377631) #12 49 points 30 comments -> [LLMs are not the black box you were promised](https://www.jay.ai/blog/llms-are-not-a-black-box)<!-- HN:48377631:end --><!-- HN:48378995:start -->
* [48378995](https://news.social-protocols.org/stats?id=48378995) #22 11 points 40 comments -> [Can A.I. Produce Writing That We Want to Read?](https://www.newyorker.com/news/fault-lines/can-ai-produce-writing-that-we-actually-want-to-read)<!-- HN:48378995:end --><!-- HN:48382782:start -->
* [48382782](https://news.social-protocols.org/stats?id=48382782) #4 8 points 3 comments -> [Did Claude Opus 4.8 distill Alibaba's Qwen? Here's what the evidence says](https://blog.kilo.ai/p/did-claude-opus-48-distill-alibabas)<!-- HN:48382782:end --><!-- HN:48341806:start -->
* [48341806](https://news.social-protocols.org/stats?id=48341806) #17 19 points 7 comments -> [OpenRidingController – DIY horse riding controller for the PC](https://github.com/Squalius-cephalus/OpenRidingController)<!-- HN:48341806:end --><!-- HN:48383018:start -->
* [48383018](https://news.social-protocols.org/stats?id=48383018) #7 39 points 41 comments -> [Bun Has Been Converted to Rust. Now What?](https://bytecode.news/posts/2026/06/bun-has-been-converted-to-rust-now-what)<!-- HN:48383018:end --><!-- HN:48383248:start -->
* [48383248](https://news.social-protocols.org/stats?id=48383248) #9 17 points 19 comments -> [Which sparkling water is the best?](https://www.maximevidal.com/sparkling-water)<!-- HN:48383248:end --><!-- HN:48383451:start -->
* [48383451](https://news.social-protocols.org/stats?id=48383451) #13 22 points 8 comments -> [Take Action: LAPD Removed Crime Location Data. Here's Why It Matters](https://blog.spotcrime.com/2026/06/take-action-lapd-removed-crime-location.html)<!-- HN:48383451:end --><!-- HN:48378349:start -->
* [48378349](https://news.social-protocols.org/stats?id=48378349) #23 16 points 3 comments -> [I Found a Bug in Apple's Fsck_hfs](https://medium.com/@kivancgunalp/i-found-a-bug-in-apples-fsck-hfs-here-s-how-i-tracked-it-down-edc782ce5cf9)<!-- HN:48378349:end -->
#### **Thursday, June 4, 2026**<!-- HN:48400544:start -->
* [48400544](https://news.social-protocols.org/stats?id=48400544) #13 7 points 7 comments -> [Show HN: Open Terminal – A Bloomberg Style App for Research](https://tesseractanalytics.ai/)<!-- HN:48400544:end --><!-- HN:48355607:start -->
* [48355607](https://news.social-protocols.org/stats?id=48355607) #18 74 points 71 comments -> [Now Is the Best Time to Be a Duct Tape Engineer](https://derwiki.medium.com/now-is-the-best-time-to-be-a-duct-tape-engineer-eefc1d141c23)<!-- HN:48355607:end --><!-- HN:48402052:start -->
* [48402052](https://news.social-protocols.org/stats?id=48402052) #7 24 points 42 comments -> [Fear and Social Pressure Are 'Overarming' the U.S.](https://home.dartmouth.edu/news/2026/06/how-fear-and-social-pressure-are-overarming-us)<!-- HN:48402052:end --><!-- HN:48404434:start -->
* [48404434](https://news.social-protocols.org/stats?id=48404434) #26 11 points 14 comments -> [Most men lie about how tall they are](https://www.newyorker.com/culture/the-lede/the-men-who-lie-about-their-height)<!-- HN:48404434:end --><!-- HN:48363683:start -->
* [48363683](https://news.social-protocols.org/stats?id=48363683) #15 9 points 1 comments -> [My two light switches got stuck in an infinite echo loop](https://docodethatmatters.com/the-infinite-echo-state-mirror-bug/)<!-- HN:48363683:end -->
#### **Friday, June 5, 2026**
<!-- HN:48406328:start -->
* [48406328](https://news.social-protocols.org/stats?id=48406328) #11 6 points 2 comments -> [Bricks and Minifigs Parts Ways with Franchise Owners](https://bricksandminifigs.com/blog/blog/2026/06/04/bricks-and-minifigs-salem-joshua-johnson-brandon-best-resignation/)<!-- HN:48406328:end --><!-- HN:48407068:start -->
* [48407068](https://news.social-protocols.org/stats?id=48407068) #10 22 points 41 comments -> [What happens if Japan takes in zero immigrants?](https://www.konichivalue.com/p/what-happens-if-japan-takes-in-zero)<!-- HN:48407068:end --><!-- HN:48407753:start -->
* [48407753](https://news.social-protocols.org/stats?id=48407753) #14 35 points 15 comments -> [SpaceX: Flying High on Impunity](https://georgiebc.wordpress.com/2026/06/01/flying-high-on-impunity/)<!-- HN:48407753:end --><!-- HN:48411542:start -->
* [48411542](https://news.social-protocols.org/stats?id=48411542) #27 19 points 12 comments -> [Ad Blocker Test – Check If Your Ad Blocker Works](https://adblock.turtlecute.org/)<!-- HN:48411542:end --><!-- HN:48414974:start -->
* [48414974](https://news.social-protocols.org/stats?id=48414974) #9 11 points 6 comments -> [Am I Unc?](https://amiunc.com/)<!-- HN:48414974:end --><!-- HN:48415279:start -->
* [48415279](https://news.social-protocols.org/stats?id=48415279) #5 46 points 2 comments -> [Adyen Selected as Payment Services Provider for GOV.UK Pay](https://www.adyen.com/press-and-media/adyen-payments-gov-uk)<!-- HN:48415279:end --><!-- HN:48418949:start -->
* [48418949](https://news.social-protocols.org/stats?id=48418949) #13 23 points 21 comments -> [Boeing 787 Dreamliner Loses Door at Remote Pacific Airport, Puzzling Engineers](https://aeroxplorer.com/articles/boeing-787-dreamliner-loses-door-at-remote-pacific-airport-puzzling-engineers)<!-- HN:48418949:end -->
#### **Saturday, June 6, 2026**
<!-- HN:48419023:start -->
* [48419023](https://news.social-protocols.org/stats?id=48419023) #20 66 points 2 comments -> [Microsoft wants users to be addicted to Scout, their AI personal assistant](https://disassociated.com/microsoft-users-addicted-ai-personal-assistant/)<!-- HN:48419023:end --><!-- HN:48385990:start -->
* [48385990](https://news.social-protocols.org/stats?id=48385990) #21 11 points 4 comments -> [What 100k concurrent sandboxes has taught us so far](https://www.computesdk.com/blog/scale-invitational-update/)<!-- HN:48385990:end --><!-- HN:48423381:start -->
* [48423381](https://news.social-protocols.org/stats?id=48423381) #20 8 points 4 comments -> [Is anyone here interested in contributing to this OS?](https://github.com/valivalivali/x-os)<!-- HN:48423381:end --><!-- HN:48423541:start -->
* [48423541](https://news.social-protocols.org/stats?id=48423541) #13 36 points 31 comments -> [Do Women's Mate Preferences Change Across the Ovulatory Cycle? A Meta-Analysis [pdf]](https://www.martiehaselton.com/_files/ugd/3ae410_aeb76edab75f457aae0c14c4c68d93c0.pdf)<!-- HN:48423541:end --><!-- HN:48425983:start -->
* [48425983](https://news.social-protocols.org/stats?id=48425983) #7 14 points 2 comments -> [AI didn't break the web. The dotcons did – AI just turned up the volume](https://hamishcampbell.com/ai-didnt-break-the-web-the-dotcons-did-ai-just-turned-up-the-volume/)<!-- HN:48425983:end --><!-- HN:48396417:start -->
* [48396417](https://news.social-protocols.org/stats?id=48396417) #13 14 points 3 comments -> [Lambda isn't leaking memory, your metrics are lying to you](https://engineering.taktile.com/blog/onnx-memory-usage-on-lambda/)<!-- HN:48396417:end --><!-- HN:48429343:start -->
* [48429343](https://news.social-protocols.org/stats?id=48429343) #2 9 points 1 comments -> [They are looting your life savings](https://social.bau-ha.us/@raganwald/116705256401454865)<!-- HN:48429343:end --><!-- HN:48428796:start -->
* [48428796](https://news.social-protocols.org/stats?id=48428796) #15 36 points 19 comments -> [Universal Memory Protocol – a shared format for agent memory](https://universalmemoryprotocol.io/)<!-- HN:48428796:end --><!-- HN:48423990:start -->
* [48423990](https://news.social-protocols.org/stats?id=48423990) #14 404 points 2 comments -> [Google will pay SpaceX $920M per month for compute](https://techcrunch.com/2026/06/05/google-will-pay-spacex-920m-per-month-for-compute/)<!-- HN:48423990:end --><!-- HN:48429940:start -->
* [48429940](https://news.social-protocols.org/stats?id=48429940) #17 14 points 7 comments -> [No Babies? Blame Capitalism](https://jacobin.com/2026/06/birth-rates-capitalism-socialism-germany)<!-- HN:48429940:end -->
#### **Sunday, June 7, 2026**<!-- HN:48358339:start -->
* [48358339](https://news.social-protocols.org/stats?id=48358339) #22 20 points 4 comments -> [PyTorch Custom Operation](https://leimao.github.io/blog/PyTorch-Custom-Operation/)<!-- HN:48358339:end --><!-- HN:48348876:start -->
* [48348876](https://news.social-protocols.org/stats?id=48348876) #26 87 points 18 comments -> [Building Rust Procedural Macros from the Grounds Up](https://www.learnix-os.com/ch02-03-implementing-the-bitfields-proc-macro.html)<!-- HN:48348876:end --><!-- HN:48430693:start -->
* [48430693](https://news.social-protocols.org/stats?id=48430693) #20 17 points 9 comments -> [Show HN: DomainTasker – avoid losing domains and surprise renewals](https://domaintasker.com/)<!-- HN:48430693:end --><!-- HN:48434114:start -->
* [48434114](https://news.social-protocols.org/stats?id=48434114) #3 14 points 11 comments -> [We Need VAT and UBI](https://wilsoniumite.com/2026/06/07/we-need-vat-and-ubi/)<!-- HN:48434114:end --><!-- HN:48434342:start -->
* [48434342](https://news.social-protocols.org/stats?id=48434342) #3 48 points 39 comments -> [Anthropic/OpenAI may be spending more than $1000 for every $100 you pay them](https://ea.rna.nl/2026/06/07/anthropic-openai-may-be-spending-more-than-1000-for-every-100-you-pay-them/)<!-- HN:48434342:end --><!-- HN:48435924:start -->
* [48435924](https://news.social-protocols.org/stats?id=48435924) #9 5 points 0 comments -> [Agents, Agile, Communism, Coercion](https://elliotmorris.net/agents-agile-communism-coercion)<!-- HN:48435924:end --><!-- HN:48436542:start -->
* [48436542](https://news.social-protocols.org/stats?id=48436542) #4 23 points 21 comments -> [Ripping a DVD, a federal crime in 1999, requires $22 and free software in 2026](https://ringmast4r.substack.com/p/in-1999-this-was-a-federal-crime)<!-- HN:48436542:end --><!-- HN:48438276:start -->
* [48438276](https://news.social-protocols.org/stats?id=48438276) #8 7 points 1 comments -> [What Are Tokens in LLMs?](https://bearisland.dev/posts/tokens-and-tokenization/)<!-- HN:48438276:end --><!-- HN:48437442:start -->
* [48437442](https://news.social-protocols.org/stats?id=48437442) #12 -> [Leiden Declaration on Artificial Intelligence and Mathematics](https://www.lms.ac.uk/news/leiden-declaration-on-ai-and-mathematics)<!-- HN:48437442:end --><!-- HN:48438854:start -->
* [48438854](https://news.social-protocols.org/stats?id=48438854) #29 14 points 9 comments -> [Data centers consumed 264B gallons of water as drought hits nearly 63% of US](https://www.barchart.com/story/news/2339834/ai-data-centers-water-consumption-breaks-264-billion-gallons-in-2025-as-devastating-drought-hits-nearly-63-of-u-s)<!-- HN:48438854:end --><!-- HN:48437814:start -->
* [48437814](https://news.social-protocols.org/stats?id=48437814) #26 7 points 0 comments -> [Iran says staff blocked from entering US after players given World Cup visas](https://www.bbc.com/news/articles/cy8286nqz87o)<!-- HN:48437814:end -->
#### **Monday, June 8, 2026**
<!-- HN:48404070:start -->
* [48404070](https://news.social-protocols.org/stats?id=48404070) #16 5 points 3 comments -> [Crashing cars and improving hover detection](https://motion.dev/magazine/collision-detection-in-hover-detection)<!-- HN:48404070:end --><!-- HN:48438754:start -->
* [48438754](https://news.social-protocols.org/stats?id=48438754) #17 20 points 15 comments -> [VibeOS: First ever AI-native operating system](https://vibeos.sh/)<!-- HN:48438754:end --><!-- HN:48439709:start -->
* [48439709](https://news.social-protocols.org/stats?id=48439709) #27 13 points 2 comments -> [US troops, families adjust to new normal of Iran war](https://www.reuters.com/business/aerospace-defense/us-troops-families-adjust-to-new-normal-iran-war-2026-06-07/)<!-- HN:48439709:end --><!-- HN:48369703:start -->
* [48369703](https://news.social-protocols.org/stats?id=48369703) #16 28 points 19 comments -> [A Fundamental Principle of Aeronautical Engineering Has Been Overturned](https://www.tohoku.ac.jp/japanese/2026/05/press20260512-02-DMR.html)<!-- HN:48369703:end --><!-- HN:48397765:start -->
* [48397765](https://news.social-protocols.org/stats?id=48397765) #19 38 points 35 comments -> [Learn PHP in 2026 (Yes, Really)](https://fagnerbrack.com/learn-php-in-2026-yes-really-bd567753dd84)<!-- HN:48397765:end --><!-- HN:48440811:start -->
* [48440811](https://news.social-protocols.org/stats?id=48440811) #11 20 points 11 comments -> [90210 – running the show without property tax](https://github.com/Achint08/90210)<!-- HN:48440811:end --><!-- HN:48442470:start -->
* [48442470](https://news.social-protocols.org/stats?id=48442470) #29 52 points 39 comments -> [GitHub Is Down](https://www.githubstatus.com/incidents/m7n7sm0sr1pz)<!-- HN:48442470:end --><!-- HN:48444543:start -->
* [48444543](https://news.social-protocols.org/stats?id=48444543) #11 60 points 28 comments -> [The iPhone explains 33–52% of fertility decline among women aged 15–44](https://www.nber.org/papers/w35310)<!-- HN:48444543:end --><!-- HN:48386689:start -->
* [48386689](https://news.social-protocols.org/stats?id=48386689) #9 18 points 13 comments -> [The 15-minute city is a dead end](https://blogs.lse.ac.uk/covid19/2021/05/28/the-15-minute-city-is-a-dead-end-cities-must-be-places-of-opportunity-for-everyone/)<!-- HN:48386689:end --><!-- HN:48446899:start -->
* [48446899](https://news.social-protocols.org/stats?id=48446899) #21 18 points 3 comments -> [Proton is funding the French far right on YouTube](https://old.reddit.com/r/degoogle/comments/1tzbizh/proton_is_funding_the_french_far_right_on_youtube)<!-- HN:48446899:end -->