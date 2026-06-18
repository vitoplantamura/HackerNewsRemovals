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
* [48531986](https://news.social-protocols.org/stats?id=48531986) #7 7 points 6 comments -> [Bring Siri AI to EU iPhone Users Safely](https://siri4eu.com)<!-- HN:48531986:end -->
#### **Monday, June 15, 2026**
<!-- HN:48533736:start -->
* [48533736](https://news.social-protocols.org/stats?id=48533736) #15 35 points 34 comments -> [The Jqwik Anti-AI Affair](https://blog.johanneslink.net/2026/06/09/the-jqwik-anti-ai-affair/)<!-- HN:48533736:end --><!-- HN:48533829:start -->
* [48533829](https://news.social-protocols.org/stats?id=48533829) #3 26 points 43 comments -> [What even is food authenticity? Why we guard carbonara, and flatten chicken rice](https://iza.ac/posts/2026/06/food-authenticity/)<!-- HN:48533829:end --><!-- HN:48535118:start -->
* [48535118](https://news.social-protocols.org/stats?id=48535118) #2 86 points 13 comments -> [The rich aren't your role models](https://theslowburningfuse.wordpress.com/2026/06/14/the-rich-arent-your-role-models-theyre-your-oppressors/)<!-- HN:48535118:end --><!-- HN:48491773:start -->
* [48491773](https://news.social-protocols.org/stats?id=48491773) #30 -> [Why Your CPU Is Fast but Your Program Is Slow: Understanding the Memory Wall](https://prawns.dev/blogs/memory-wall)<!-- HN:48491773:end --><!-- HN:48533976:start -->
* [48533976](https://news.social-protocols.org/stats?id=48533976) #25 72 points 175 comments -> [US and Iran announce deal to end military operations](https://www.bbc.com/news/live/cj0grpyg4v1t)<!-- HN:48533976:end --><!-- HN:48538350:start -->
* [48538350](https://news.social-protocols.org/stats?id=48538350) #12 23 points 42 comments -> [UK Brings in Full Social Media Ban for Under-16s](https://deadline.com/2026/06/uk-social-media-ban-under-16s-x-youtube-tiktok-reddit-1236956163/)<!-- HN:48538350:end --><!-- HN:48539859:start -->
* [48539859](https://news.social-protocols.org/stats?id=48539859) #4 20 points 7 comments -> [Belgian politicians would rather risk treason charges than trust engineers](http://mikhailian.mova.org/node/325)<!-- HN:48539859:end --><!-- HN:48540428:start -->
* [48540428](https://news.social-protocols.org/stats?id=48540428) #30 5 points 1 comments -> [Tesla presented misleading 'Full Self-Driving' safety data to European regulator](https://www.reuters.com/world/tesla-presented-misleading-full-self-driving-safety-data-european-regulators-2026-06-15/)<!-- HN:48540428:end --><!-- HN:48541222:start -->
* [48541222](https://news.social-protocols.org/stats?id=48541222) #2 13 points 12 comments -> [I wrote 5000 lines of assembly because I was angry](https://ujjwalvivek.com/blog/log_0009_baremetal.md)<!-- HN:48541222:end --><!-- HN:48540813:start -->
* [48540813](https://news.social-protocols.org/stats?id=48540813) #21 36 points 17 comments -> [Applying Brevity and Language Efficiency in Prompt Engineering](https://prahladyeri.github.io/guides/applying-brevity-and-language-efficiency-to-prompt-engineering.html)<!-- HN:48540813:end --><!-- HN:48499690:start -->
* [48499690](https://news.social-protocols.org/stats?id=48499690) #27 23 points 12 comments -> [Stdx, Rust's extended standard library](https://kerkour.com/stdx)<!-- HN:48499690:end --><!-- HN:48542209:start -->
* [48542209](https://news.social-protocols.org/stats?id=48542209) #11 75 points 6 comments -> [Fox Is Buying Roku](https://www.fastcompany.com/91559558/fox-corp-buying-roku-stock-prices-fall-on-tv-streaming-merger)<!-- HN:48542209:end --><!-- HN:48492548:start -->
* [48492548](https://news.social-protocols.org/stats?id=48492548) #8 16 points 4 comments -> [Bots flooded my anti-bot startup with 55,000 fake signups](https://humaverify.com/blog/anatomy-of-a-55k-bot-attack)<!-- HN:48492548:end --><!-- HN:48546648:start -->
* [48546648](https://news.social-protocols.org/stats?id=48546648) #20 20 points 3 comments -> [Commander Keen Games (free book)](https://forgottenbytes.net/)<!-- HN:48546648:end -->
#### **Tuesday, June 16, 2026**<!-- HN:48553438:start -->
* [48553438](https://news.social-protocols.org/stats?id=48553438) #15 4 points 1 comments -> [Electrifying the Cow Path](https://sebas.fika.bar/electrifying-the-cow-path-01KSJS9QM201WECVBBV2HKAV6M)<!-- HN:48553438:end --><!-- HN:48554677:start -->
* [48554677](https://news.social-protocols.org/stats?id=48554677) #7 6 points 8 comments -> [Show HN: Voice Age Verification](https://agewarden.ai/)<!-- HN:48554677:end --><!-- HN:48554208:start -->
* [48554208](https://news.social-protocols.org/stats?id=48554208) #20 110 points 43 comments -> [Russian artist and Putin critic shot dead in Poland](https://www.bbc.com/news/articles/clyrzd5g6k2o)<!-- HN:48554208:end --><!-- HN:48554215:start -->
* [48554215](https://news.social-protocols.org/stats?id=48554215) #20 264 points 299 comments -> [SpaceX Is Buying Cursor](https://www.bbc.com/news/articles/cvgd5g7d7gyo)<!-- HN:48554215:end --><!-- HN:48556414:start -->
* [48556414](https://news.social-protocols.org/stats?id=48556414) #7 128 points 3 comments -> [Google Chrome's Next Update Will Mark the End of Popular Ad Blockers](https://tech.slashdot.org/story/26/06/15/205219/google-chromes-next-update-will-mark-the-end-of-popular-ad-blockers)<!-- HN:48556414:end --><!-- HN:48558545:start -->
* [48558545](https://news.social-protocols.org/stats?id=48558545) #6 40 points 23 comments -> [Gamers beware: malicious wallpapers on Steam found stealing accounts](https://securelist.com/dozens-of-malicious-wallpapers-found-on-steam-workshop/120186/)<!-- HN:48558545:end --><!-- HN:48562274:start -->
* [48562274](https://news.social-protocols.org/stats?id=48562274) #13 26 points 18 comments -> [Total Iran Economic Damage Estimate](https://www.fdd.org/analysis/2026/04/23/total-iran-economic-damage-estimate/)<!-- HN:48562274:end -->
#### **Wednesday, June 17, 2026**
<!-- HN:48565130:start -->
* [48565130](https://news.social-protocols.org/stats?id=48565130) #1 187 points 164 comments -> [Leaked OpenAI financials show $38.5B loss and compute burn](https://runtimewire.com/article/openai-leaked-financials-altman-compute-burn)<!-- HN:48565130:end --><!-- HN:48566326:start -->
* [48566326](https://news.social-protocols.org/stats?id=48566326) #3 27 points 3 comments -> [Peter Thiel's private society attendance list leaked via hard-coded HTML](https://github.com/nzaki-dev/dialog)<!-- HN:48566326:end --><!-- HN:48566095:start -->
* [48566095](https://news.social-protocols.org/stats?id=48566095) #13 17 points 1 comments -> [Apple plans change to Hide My Email that could make it less effective](https://techcrunch.com/2026/06/16/apple-plans-to-change-its-hide-my-email-privacy-feature-that-could-make-it-less-effective/)<!-- HN:48566095:end --><!-- HN:48497067:start -->
* [48497067](https://news.social-protocols.org/stats?id=48497067) #26 105 points 4 comments -> [Formal Methods and the Future of Programming](https://blog.janestreet.com/formal-methods-at-jane-street-index/)<!-- HN:48497067:end --><!-- HN:48567574:start -->
* [48567574](https://news.social-protocols.org/stats?id=48567574) #5 4 points 0 comments -> [Most of the CVE-2026-4020 attackers are the same client](https://honeylabs.net/blog/the-cloud-fleet-behind-cve-2026-4020)<!-- HN:48567574:end --><!-- HN:48570763:start -->
* [48570763](https://news.social-protocols.org/stats?id=48570763) #19 98 points 40 comments -> [ICE Appears to Be Buying Immigrants' Tax Identifiers from a Data Broker](https://www.404media.co/ice-appears-to-be-buying-immigrants-tax-identifiers-from-a-data-broker/)<!-- HN:48570763:end --><!-- HN:48576113:start -->
* [48576113](https://news.social-protocols.org/stats?id=48576113) #10 62 points 18 comments -> [Krugman: Musk, a Human Ponzi Scheme](https://paulkrugman.substack.com/p/elon-musk-human-ponzi-scheme)<!-- HN:48576113:end --><!-- HN:48576307:start -->
* [48576307](https://news.social-protocols.org/stats?id=48576307) #24 22 points 11 comments -> [Apple Intelligence may become mandatory in iOS and macOS 27](https://manualdousuario.net/en/apple-intelligence-mandatory-ios-macos-27/)<!-- HN:48576307:end -->
#### **Thursday, June 18, 2026**
<!-- HN:48577208:start -->
* [48577208](https://news.social-protocols.org/stats?id=48577208) #6 341 points 4 comments -> [Leaked financial docs show OpenAI is losing billions of dollars a year](https://arstechnica.com/ai/2026/06/leaked-financial-docs-show-openai-is-losing-billions-of-dollars-a-year/)<!-- HN:48577208:end --><!-- HN:48579718:start -->
* [48579718](https://news.social-protocols.org/stats?id=48579718) #1 74 points 5 comments -> [Midjourney Ultrasonic CT Scanner](https://www.midjourney.com/medical/blogpost)<!-- HN:48579718:end --><!-- HN:48573435:start -->
* [48573435](https://news.social-protocols.org/stats?id=48573435) #19 134 points 107 comments -> [The Competitive Moat That AI Can't Replicate](https://ghostinthedata.info/posts/2026/2026-06-13-human-connection-moat/)<!-- HN:48573435:end --><!-- HN:48580147:start -->
* [48580147](https://news.social-protocols.org/stats?id=48580147) #18 5 points 2 comments -> [Continue has been acquired by Cursor](https://www.continue.dev/)<!-- HN:48580147:end --><!-- HN:48581485:start -->
* [48581485](https://news.social-protocols.org/stats?id=48581485) #8 22 points 3 comments -> [How to Become a Person After Smartphones Have Rotted Your Brain](https://www.thenewatlantis.com/publications/how-to-become-a-person-after-smartphones-have-rotted-your-brain)<!-- HN:48581485:end --><!-- HN:48583843:start -->
* [48583843](https://news.social-protocols.org/stats?id=48583843) #15 46 points 44 comments -> [Challenging the Narrative of European Decline](https://paulkrugman.substack.com/p/challenging-the-narrative-of-european-478)<!-- HN:48583843:end --><!-- HN:48585626:start -->
* [48585626](https://news.social-protocols.org/stats?id=48585626) #23 3 points 0 comments -> [Converting Books into Visual Novels](https://github.com/JohnQPulp/PublicDomainPulp)<!-- HN:48585626:end --><!-- HN:48584873:start -->
* [48584873](https://news.social-protocols.org/stats?id=48584873) #21 22 points 30 comments -> [Git platform built for agentic era](https://gitlawb.com/node)<!-- HN:48584873:end --><!-- HN:48586811:start -->
* [48586811](https://news.social-protocols.org/stats?id=48586811) #23 14 points 7 comments -> [Show HN: 10x better performance from the Coding Harnesses with LLM-wiki](https://llm-wiki.net/)<!-- HN:48586811:end --><!-- HN:48586635:start -->
* [48586635](https://news.social-protocols.org/stats?id=48586635) #20 13 points 10 comments -> [US Supreme Court drug users cannot be prohibited from firearms [pdf]](https://www.supremecourt.gov/opinions/25pdf/24-1234_g2bh.pdf)<!-- HN:48586635:end --><!-- HN:48588072:start -->
* [48588072](https://news.social-protocols.org/stats?id=48588072) #8 10 points 1 comments -> [Securing the Future of AI Agents](https://deepmind.google/blog/securing-the-future-of-ai-agents/)<!-- HN:48588072:end -->