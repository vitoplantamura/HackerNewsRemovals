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

#### **Monday, June 8, 2026**
<!-- HN:48404070:start -->
* [48404070](https://news.social-protocols.org/stats?id=48404070) #16 5 points 3 comments -> [Crashing cars and improving hover detection](https://motion.dev/magazine/collision-detection-in-hover-detection)<!-- HN:48404070:end --><!-- HN:48438754:start -->
* [48438754](https://news.social-protocols.org/stats?id=48438754) #17 20 points 15 comments -> [VibeOS: First ever AI-native operating system](https://vibeos.sh/)<!-- HN:48438754:end --><!-- HN:48439709:start -->
* [48439709](https://news.social-protocols.org/stats?id=48439709) #27 13 points 2 comments -> [US troops, families adjust to new normal of Iran war](https://www.reuters.com/business/aerospace-defense/us-troops-families-adjust-to-new-normal-iran-war-2026-06-07/)<!-- HN:48439709:end --><!-- HN:48369703:start -->
* [48369703](https://news.social-protocols.org/stats?id=48369703) #16 28 points 19 comments -> [A Fundamental Principle of Aeronautical Engineering Has Been Overturned](https://www.tohoku.ac.jp/japanese/2026/05/press20260512-02-DMR.html)<!-- HN:48369703:end --><!-- HN:48397765:start -->
* [48397765](https://news.social-protocols.org/stats?id=48397765) #19 38 points 35 comments -> [Learn PHP in 2026 (Yes, Really)](https://fagnerbrack.com/learn-php-in-2026-yes-really-bd567753dd84)<!-- HN:48397765:end --><!-- HN:48440811:start -->
* [48440811](https://news.social-protocols.org/stats?id=48440811) #11 20 points 11 comments -> [90210 – running the show without property tax](https://github.com/Achint08/90210)<!-- HN:48440811:end --><!-- HN:48444543:start -->
* [48444543](https://news.social-protocols.org/stats?id=48444543) #11 60 points 28 comments -> [The iPhone explains 33–52% of fertility decline among women aged 15–44](https://www.nber.org/papers/w35310)<!-- HN:48444543:end --><!-- HN:48386689:start -->
* [48386689](https://news.social-protocols.org/stats?id=48386689) #9 18 points 13 comments -> [The 15-minute city is a dead end](https://blogs.lse.ac.uk/covid19/2021/05/28/the-15-minute-city-is-a-dead-end-cities-must-be-places-of-opportunity-for-everyone/)<!-- HN:48386689:end --><!-- HN:48446899:start -->
* [48446899](https://news.social-protocols.org/stats?id=48446899) #21 18 points 3 comments -> [Proton is funding the French far right on YouTube](https://old.reddit.com/r/degoogle/comments/1tzbizh/proton_is_funding_the_french_far_right_on_youtube)<!-- HN:48446899:end --><!-- HN:48384630:start -->
* [48384630](https://news.social-protocols.org/stats?id=48384630) #22 34 points 0 comments -> [Mutation Testing in Haskell](https://cs-syd.eu/posts/2026-06-03-mutation-testing-in-haskell)<!-- HN:48384630:end -->
#### **Tuesday, June 9, 2026**
<!-- HN:48453873:start -->
* [48453873](https://news.social-protocols.org/stats?id=48453873) #29 10 points 1 comments -> [Remembering the USS Liberty – and why it still matters](https://captimes.com/opinion/guest-columns/opinion-remembering-the-uss-liberty-and-why-it-still-matters/article_5880cb7e-e863-4c1b-95fb-dfdc5b3e4de2.html)<!-- HN:48453873:end --><!-- HN:48419000:start -->
* [48419000](https://news.social-protocols.org/stats?id=48419000) #28 49 points 27 comments -> [Hermes Agent – Open-Source AI Agent with Persistent Memory](https://hermes-agent.org/)<!-- HN:48419000:end --><!-- HN:48456104:start -->
* [48456104](https://news.social-protocols.org/stats?id=48456104) #3 8 points 2 comments -> [Claude Fable 5](https://www.anthropic.com/news/claude-fable-5-mythos-5)<!-- HN:48456104:end --><!-- HN:48458890:start -->
* [48458890](https://news.social-protocols.org/stats?id=48458890) #2 320 points 3 comments -> [GentleOS – Classic operating system with a lovely retro GUI](https://github.com/luke8086/gentleos32)<!-- HN:48458890:end --><!-- HN:48461522:start -->
* [48461522](https://news.social-protocols.org/stats?id=48461522) #29 6 points 1 comments -> [I ran an arbitrage bot on Polymarket. Here are the real numbers](https://kacho.io/polymarket-arbitrage-real-numbers)<!-- HN:48461522:end --><!-- HN:48463811:start -->
* [48463811](https://news.social-protocols.org/stats?id=48463811) #3 205 points 1 comments -> [System Card: Claude Fable 5 and Claude Mythos 5 [pdf]](https://www-cdn.anthropic.com/d00db56fa754a1b115b6dd7cb2e3c342ee809620.pdf)<!-- HN:48463811:end -->
#### **Wednesday, June 10, 2026**
<!-- HN:48470557:start -->
* [48470557](https://news.social-protocols.org/stats?id=48470557) #5 4 points 2 comments -> [If Claude Fable stops helping you, you'll never know](https://simonwillison.net/2026/Jun/10/if-claude-fable-stops-helping-you/)<!-- HN:48470557:end --><!-- HN:48473731:start -->
* [48473731](https://news.social-protocols.org/stats?id=48473731) #27 23 points 12 comments -> [Notepad++ Zero-Click RCE via Path Traversal (CVE-2026-52884)](https://github.com/notepad-plus-plus/notepad-plus-plus/security/advisories/GHSA-p58x-r3c9-x9p6)<!-- HN:48473731:end --><!-- HN:48476514:start -->
* [48476514](https://news.social-protocols.org/stats?id=48476514) #16 14 points 14 comments -> [GnuCash is right. It's also why I built my own finance app](https://k-id.app/blog/gnucash-is-right/)<!-- HN:48476514:end --><!-- HN:48427324:start -->
* [48427324](https://news.social-protocols.org/stats?id=48427324) #20 11 points 4 comments -> [A Server Called Mercury](https://kennethreitz.org/essays/2026-06-05-a_server_called_mercury)<!-- HN:48427324:end --><!-- HN:48482955:start -->
* [48482955](https://news.social-protocols.org/stats?id=48482955) #12 30 points 35 comments -> [Organic foods are not healthier or pesticide free](https://news.immunologic.org/p/organic-foods-are-not-healthieror)<!-- HN:48482955:end -->
#### **Thursday, June 11, 2026**
<!-- HN:48484475:start -->
* [48484475](https://news.social-protocols.org/stats?id=48484475) #6 8 points 2 comments -> [Aws.com and google.com don't have DNSSEC enabled](https://gist.github.com/acetousk/3c17d2aefde9175ffef21a8ec4673053)<!-- HN:48484475:end --><!-- HN:48484695:start -->
* [48484695](https://news.social-protocols.org/stats?id=48484695) #13 8 points 3 comments -> [I was tired of repos that say they run but don't](https://github.com/rossbuckley1990-hash/bootproof)<!-- HN:48484695:end --><!-- HN:48446554:start -->
* [48446554](https://news.social-protocols.org/stats?id=48446554) #12 10 points 2 comments -> [Building a Korean ambiguity solver fast enough to skip the GPU: 7,300 words/SEC](https://kimchi-reader.app/blog/int8-cpu-korean-disambiguation)<!-- HN:48446554:end --><!-- HN:48493786:start -->
* [48493786](https://news.social-protocols.org/stats?id=48493786) #25 7 points 4 comments -> [Show HN: A police department for your Claude Code agents](https://github.com/varmabudharaju/agent-pd/blob/master/README.md)<!-- HN:48493786:end -->
#### **Friday, June 12, 2026**
<!-- HN:48449899:start -->
* [48449899](https://news.social-protocols.org/stats?id=48449899) #22 16 points 2 comments -> [I Stopped Fighting My Tools and Built a Game Engine in D](https://blog.dlang.org/2026/05/29/i-stopped-fighting-my-tools-and-built-a-game-engine-in-d/)<!-- HN:48449899:end --><!-- HN:48505373:start -->
* [48505373](https://news.social-protocols.org/stats?id=48505373) #3 20 points 3 comments -> [Wasi: WebGPU – A Proposed WebAssembly System Interface API](https://github.com/WebAssembly/wasi-webgpu)<!-- HN:48505373:end --><!-- HN:48507836:start -->
* [48507836](https://news.social-protocols.org/stats?id=48507836) #13 69 points 17 comments -> [A Peter Thiel-Backed Tribunal Is Putting Journalists on Trial](https://www.hollywoodreporter.com/business/business-news/peter-thiel-tribunal-journalists-trial-1236617579/)<!-- HN:48507836:end --><!-- HN:48505561:start -->
* [48505561](https://news.social-protocols.org/stats?id=48505561) #24 107 points 63 comments -> [Keygen.music](https://keygen.music)<!-- HN:48505561:end --><!-- HN:48508649:start -->
* [48508649](https://news.social-protocols.org/stats?id=48508649) #24 -> [Kagi Magic](https://kagi.com/magic)<!-- HN:48508649:end --><!-- HN:48510082:start -->
* [48510082](https://news.social-protocols.org/stats?id=48510082) #26 13 points 0 comments -> [Satellite images reveal Putin is preparing for war with Europe](https://www.dailymail.com/news/article-15894289/Warnings-Putin-preparing-larger-war-Europe-satellite-images-reveal-military-expansion-NATO-border.html)<!-- HN:48510082:end --><!-- HN:48508949:start -->
* [48508949](https://news.social-protocols.org/stats?id=48508949) #23 31 points 24 comments -> [Can I Buy Your KV Cache?](https://arxiv.org/abs/2606.13361)<!-- HN:48508949:end -->
#### **Saturday, June 13, 2026**
<!-- HN:48510230:start -->
* [48510230](https://news.social-protocols.org/stats?id=48510230) #26 24 points 22 comments -> [DNI Gabbard Reveals Evidence of U.S. Taxpayer-Funded Global Biolab Program](https://www.dni.gov/index.php/newsroom/press-releases/press-releases-2026/4163-pr-10-26)<!-- HN:48510230:end --><!-- HN:48511121:start -->
* [48511121](https://news.social-protocols.org/stats?id=48511121) #3 242 points 123 comments -> [We've suspended access to Claude Mythos 5 and Claude Fable 5](https://status.claude.com/incidents/s9w82lp9dcn9)<!-- HN:48511121:end --><!-- HN:48510357:start -->
* [48510357](https://news.social-protocols.org/stats?id=48510357) #29 89 points 9 comments -> [AMD Stiffs Researcher $10k Bug Bounty](https://www.gadgetreview.com/amd-stiffs-researcher-10000-bug-bounty-after-critical-security-flaw-takes-124-days-to-fix)<!-- HN:48510357:end --><!-- HN:48511168:start -->
* [48511168](https://news.social-protocols.org/stats?id=48511168) #22 86 points 20 comments -> [As a result of a US Government directive, we are suspending access to Fable 5](https://twitter.com/ClaudeDevs/status/2065597942602531163)<!-- HN:48511168:end --><!-- HN:48511812:start -->
* [48511812](https://news.social-protocols.org/stats?id=48511812) #24 16 points 2 comments -> [Anthropic's leaning in to the whole nanny state thing](https://honeypot.net/2026/06/12/anthropics-leaning-in-to-the.html)<!-- HN:48511812:end --><!-- HN:48515344:start -->
* [48515344](https://news.social-protocols.org/stats?id=48515344) #12 3 points 0 comments -> [The Fable 5 Jailbreak Shows Why AI Guardrails Alone Are Not Enough](https://www.agilehunt.com/blog/fable-5-jailbreak-ai-guardrails)<!-- HN:48515344:end --><!-- HN:48516585:start -->
* [48516585](https://news.social-protocols.org/stats?id=48516585) #6 12 points 11 comments -> [Thoughts on AI and Jobs](https://blog.keyvan.net/p/thoughts-on-ai-and-jobs)<!-- HN:48516585:end --><!-- HN:48516053:start -->
* [48516053](https://news.social-protocols.org/stats?id=48516053) #20 8 points 8 comments -> [Labor Is a Market Distortion, we need VAT and UBI](https://wilsoniumite.com/2026/06/07/labor-is-a-market-distortion/)<!-- HN:48516053:end --><!-- HN:48467028:start -->
* [48467028](https://news.social-protocols.org/stats?id=48467028) #28 19 points 15 comments -> [Woman Gets on Route 66. Then She Starts Hearing Music Coming from Her Tires](https://www.motor1.com/news/798011/route-66-missouri-musical-road/)<!-- HN:48467028:end --><!-- HN:48519567:start -->
* [48519567](https://news.social-protocols.org/stats?id=48519567) #28 33 points 19 comments -> [Show HN: Verso – A $14.99 Mac word processor with no subscription](https://www.versowriter.app)<!-- HN:48519567:end --><!-- HN:48520305:start -->
* [48520305](https://news.social-protocols.org/stats?id=48520305) #13 3 points 0 comments -> [Best YouTube Downloader Alternatives That Work in 2026](https://www.youtubexx.com/)<!-- HN:48520305:end -->
#### **Sunday, June 14, 2026**
<!-- HN:48522555:start -->
* [48522555](https://news.social-protocols.org/stats?id=48522555) #14 31 points 18 comments -> [Show HN: I built 80 mini-games using Fable before it was shut down](https://minigames.world/en)<!-- HN:48522555:end --><!-- HN:48522237:start -->
* [48522237](https://news.social-protocols.org/stats?id=48522237) #26 28 points 2 comments -> [Derbyshire Police officer accused of using AI to 'create evidence'](https://www.bbc.com/news/articles/cy8wppwdxl6o)<!-- HN:48522237:end --><!-- HN:48526028:start -->
* [48526028](https://news.social-protocols.org/stats?id=48526028) #20 5 points 2 comments -> [UK police officer under criminal investigation over alleged use of AI](https://www.ft.com/content/514bab88-788c-4d48-a140-03597860bdb6)<!-- HN:48526028:end --><!-- HN:48527392:start -->
* [48527392](https://news.social-protocols.org/stats?id=48527392) #27 -> [SpaceX, Adding It Up – The $235B Cash Gap](https://capefearadvisors.substack.com/p/spacex-adding-it-up-the-235-billion)<!-- HN:48527392:end --><!-- HN:48530048:start -->
* [48530048](https://news.social-protocols.org/stats?id=48530048) #13 -> [Amodei the Man Behind DeepSeek?](https://txt.fyi/e8f40392583842df)<!-- HN:48530048:end --><!-- HN:48531986:start -->
* [48531986](https://news.social-protocols.org/stats?id=48531986) #7 7 points 6 comments -> [Bring Siri AI to EU iPhone Users Safely](https://siri4eu.com)<!-- HN:48531986:end --><!-- HN:48489309:start -->
* [48489309](https://news.social-protocols.org/stats?id=48489309) #19 24 points 40 comments -> [USB Power Delivery: Plugging into the Benefits](https://www.aptiv.com/en/insights/article/usb-power-delivery-plugging-into-the-benefits)<!-- HN:48489309:end -->