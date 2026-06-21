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
* [48586811](https://news.social-protocols.org/stats?id=48586811) #23 14 points 7 comments -> [Show HN: 10x better performance from the Coding Harnesses with LLM-wiki](https://llm-wiki.net/)<!-- HN:48586811:end --><!-- HN:48588072:start -->
* [48588072](https://news.social-protocols.org/stats?id=48588072) #8 10 points 1 comments -> [Securing the Future of AI Agents](https://deepmind.google/blog/securing-the-future-of-ai-agents/)<!-- HN:48588072:end --><!-- HN:48588206:start -->
* [48588206](https://news.social-protocols.org/stats?id=48588206) #19 26 points 12 comments -> [Tech CEOs are breaking the law](https://kiesow.net/tech-ceos-are-breaking-the-law/)<!-- HN:48588206:end --><!-- HN:48542963:start -->
* [48542963](https://news.social-protocols.org/stats?id=48542963) #26 15 points 28 comments -> [My LSM tree was slower than a B-tree. Then I profiled it](https://aasheesh.vercel.app/blog/lsm-tree)<!-- HN:48542963:end --><!-- HN:48590280:start -->
* [48590280](https://news.social-protocols.org/stats?id=48590280) #17 9 points 1 comments -> [Integer Quantization: Deep Dive](https://hello-fri-end.github.io/2026/06/integer-quantization-deep-dive/)<!-- HN:48590280:end --><!-- HN:48591562:start -->
* [48591562](https://news.social-protocols.org/stats?id=48591562) #6 52 points 18 comments -> [Everything Is BOM: Bill of Materials Encyclopedia](https://bomwiki.com/)<!-- HN:48591562:end -->
#### **Friday, June 19, 2026**
<!-- HN:48539412:start -->
* [48539412](https://news.social-protocols.org/stats?id=48539412) #27 24 points 13 comments -> [It doesn't matter if it works](https://henry.codes/writing/it-doesnt-matter-if-it-works/)<!-- HN:48539412:end --><!-- HN:48594012:start -->
* [48594012](https://news.social-protocols.org/stats?id=48594012) #29 33 points 9 comments -> [GLM-5.2: The Most Powerful Open Model yet and the Brutal Reality of Running It](https://vettedconsumer.com/glm-5-2-the-most-powerful-open-weight-model-yet-and-the-brutal-reality-of-running-it-locally/)<!-- HN:48594012:end --><!-- HN:48523800:start -->
* [48523800](https://news.social-protocols.org/stats?id=48523800) #30 24 points 18 comments -> [Automating my job away](https://austinhenley.com/blog/automatingmyjob.html)<!-- HN:48523800:end --><!-- HN:48595390:start -->
* [48595390](https://news.social-protocols.org/stats?id=48595390) #12 6 points 0 comments -> [Iran Delays U.S. Peace Talks over Israeli Attacks in Lebanon](https://maritime-executive.com/article/report-iran-suspends-hormuz-talks-because-of-israeli-attacks-in-lebanon)<!-- HN:48595390:end --><!-- HN:48595316:start -->
* [48595316](https://news.social-protocols.org/stats?id=48595316) #16 6 points 3 comments -> [The ISA Doesn't Matter Where It Counts](https://www.chipstrat.com/p/the-isa-doesnt-matter-where-it-counts)<!-- HN:48595316:end --><!-- HN:48597760:start -->
* [48597760](https://news.social-protocols.org/stats?id=48597760) #2 18 points 0 comments -> [Banning trade with Israeli settlements in Palestine](https://www.regjeringen.no/en/whats-new/proposal-for-a-bill-banning-trade-with-israeli-settlements-in-palestine-announced-for-public-consultation/id3166860/)<!-- HN:48597760:end --><!-- HN:48597783:start -->
* [48597783](https://news.social-protocols.org/stats?id=48597783) #2 11 points 5 comments -> [Google is turning Android into a 'sloperating' system. Your thoughts?](https://android-developers.googleblog.com/2026/06/Android-17.html)<!-- HN:48597783:end --><!-- HN:48597668:start -->
* [48597668](https://news.social-protocols.org/stats?id=48597668) #11 28 points 41 comments -> [From Australia to Europe, countries move to curb children's social media access](https://www.reuters.com/legal/government/australia-europe-countries-move-curb-childrens-social-media-access-2026-06-18/)<!-- HN:48597668:end --><!-- HN:48600236:start -->
* [48600236](https://news.social-protocols.org/stats?id=48600236) #22 33 points 40 comments -> [Spotify Killed the Thrill of the Hunt](https://erildrun.bearblog.dev/spotify-killed-the-thrill-of-the-hunt/)<!-- HN:48600236:end --><!-- HN:48600666:start -->
* [48600666](https://news.social-protocols.org/stats?id=48600666) #9 6 points 2 comments -> [What if Palantir's logo was square?](https://www.jasonwu.ink/signals/2026-06-18-palantir-square)<!-- HN:48600666:end --><!-- HN:48527520:start -->
* [48527520](https://news.social-protocols.org/stats?id=48527520) #25 6 points 3 comments -> [Music generation using Algebra, presented as web MIDI shop](https://monictheory.com)<!-- HN:48527520:end -->
#### **Saturday, June 20, 2026**
<!-- HN:48554812:start -->
* [48554812](https://news.social-protocols.org/stats?id=48554812) #10 11 points 0 comments -> [A Love Story](https://pudding.cool/2026/06/love-story/)<!-- HN:48554812:end --><!-- HN:48605778:start -->
* [48605778](https://news.social-protocols.org/stats?id=48605778) #2 14 points 9 comments -> [XLibre XServer 25.2.0 Released](https://github.com/X11Libre/xserver/wiki/XLibre-XServer-25.2-Changes)<!-- HN:48605778:end --><!-- HN:48604186:start -->
* [48604186](https://news.social-protocols.org/stats?id=48604186) #10 195 points 110 comments -> [Americans express unease over SpaceX's influence on retirement savings](https://www.theguardian.com/science/2026/jun/19/spacex-retirement-savings-elon-musk)<!-- HN:48604186:end --><!-- HN:48514843:start -->
* [48514843](https://news.social-protocols.org/stats?id=48514843) #5 227 points 148 comments -> [I used sound waves to make espresso. It could cut coffee‑brewing energy use by ¾](https://theconversation.com/i-used-sound-waves-to-make-espresso-it-could-cut-coffee-brewing-energy-use-by-75-284929)<!-- HN:48514843:end --><!-- HN:48541777:start -->
* [48541777](https://news.social-protocols.org/stats?id=48541777) #22 81 points 8 comments -> [A 1976 university experiment spun up the U.S. wind industry](https://spectrum.ieee.org/william-heronemus-wind-energy)<!-- HN:48541777:end --><!-- HN:48532447:start -->
* [48532447](https://news.social-protocols.org/stats?id=48532447) #24 24 points 5 comments -> [RhinoCollab a plugin for real-time editing for Rhino 3D](https://rhinocollab.com)<!-- HN:48532447:end --><!-- HN:48543311:start -->
* [48543311](https://news.social-protocols.org/stats?id=48543311) #28 361 points 55 comments -> [To study how chips work, MIT researchers built their own operating system](https://news.mit.edu/2026/to-study-how-chips-really-work-mit-researchers-built-their-own-operating-system-0610)<!-- HN:48543311:end --><!-- HN:48607407:start -->
* [48607407](https://news.social-protocols.org/stats?id=48607407) #13 9 points 4 comments -> [Jeff Bezos says human water consumption is limiting AI's potential](https://theprint.in/feature/jeff-bezos-water-consumption-amazon-ai-potential/2964266/)<!-- HN:48607407:end --><!-- HN:48557090:start -->
* [48557090](https://news.social-protocols.org/stats?id=48557090) #10 6 points 1 comments -> [Mental causation is not load-bearing](https://unstableontology.com/2026/06/07/mental-causation-is-not-load-bearing/)<!-- HN:48557090:end --><!-- HN:48552291:start -->
* [48552291](https://news.social-protocols.org/stats?id=48552291) #8 5 points 3 comments -> [What Happens When Your Domain Expires](https://urlwatch.io/blog/what-happens-when-domain-expires.php)<!-- HN:48552291:end --><!-- HN:48556333:start -->
* [48556333](https://news.social-protocols.org/stats?id=48556333) #21 5 points 0 comments -> [Visiting the History of Computing and Play](https://arbesman.substack.com/p/visiting-the-history-of-computing)<!-- HN:48556333:end --><!-- HN:48608503:start -->
* [48608503](https://news.social-protocols.org/stats?id=48608503) #6 51 points 16 comments -> [16-year-old SATA II SSD survives 1 petabyte of writes, 25x the drive's rating](https://www.tomshardware.com/pc-components/ssds/16-year-old-sata-ii-ssd-survives-1-petabyte-of-writes-25x-over-the-drives-tbw-rating)<!-- HN:48608503:end --><!-- HN:48599626:start -->
* [48599626](https://news.social-protocols.org/stats?id=48599626) #21 42 points 13 comments -> [I restarted a 10 year old Xeon 174 times to delete 12 flags and gain 4 tps](https://point.free/blog/delete-12-flags/)<!-- HN:48599626:end --><!-- HN:48555505:start -->
* [48555505](https://news.social-protocols.org/stats?id=48555505) #24 8 points 12 comments -> [The Doctor Who Treats Patients with a Gaming Mouse](https://textexpander.com/blog/doctor-gaming-mouse)<!-- HN:48555505:end --><!-- HN:48611435:start -->
* [48611435](https://news.social-protocols.org/stats?id=48611435) #7 2 points 0 comments -> [Show HN: Cody – Voice control for Neovim using its own commands, LSP](https://github.com/juancgarza/cody)<!-- HN:48611435:end --><!-- HN:48610999:start -->
* [48610999](https://news.social-protocols.org/stats?id=48610999) #16 4 points 1 comments -> [AIPropel, AI-powered proposal generation for freelancers and agencies](https://www.aipropel.app/)<!-- HN:48610999:end --><!-- HN:48612378:start -->
* [48612378](https://news.social-protocols.org/stats?id=48612378) #6 -> [The most banned man inside the United States of America](https://www.skrrl.com/)<!-- HN:48612378:end --><!-- HN:48560535:start -->
* [48560535](https://news.social-protocols.org/stats?id=48560535) #26 29 points 5 comments -> [S‑CURVES a field guide to technology adoption · 1825–2026](https://escurves.com/)<!-- HN:48560535:end --><!-- HN:48612029:start -->
* [48612029](https://news.social-protocols.org/stats?id=48612029) #15 10 points 7 comments -> [Google display wrong flags for world cup 2026](https://swiss-cow.com/blog/google-world-cup-wrong-flags)<!-- HN:48612029:end --><!-- HN:48613674:start -->
* [48613674](https://news.social-protocols.org/stats?id=48613674) #13 9 points 2 comments -> [Stop calling the Super Productionizer a 'baby blender' – Frank Elavsky](https://www.frank.computer/blog/2025/06/baby-blender.html)<!-- HN:48613674:end -->
#### **Sunday, June 21, 2026**
<!-- HN:48613732:start -->
* [48613732](https://news.social-protocols.org/stats?id=48613732) #17 149 points 61 comments -> [Turns Out, There Is a Cabal of Elite Crazies Trying to Control the World](https://www.esquire.com/news-politics/politics/a71619211/peter-thiel-dialog-club-wired-report/)<!-- HN:48613732:end --><!-- HN:48614062:start -->
* [48614062](https://news.social-protocols.org/stats?id=48614062) #17 8 points 1 comments -> [Show HN: Submarius – Global water clarity for divers](https://submarius.com)<!-- HN:48614062:end --><!-- HN:48594286:start -->
* [48594286](https://news.social-protocols.org/stats?id=48594286) #20 8 points 1 comments -> [Moving Beyond Fork() + Exec()](https://lwn.net/Articles/1076018/)<!-- HN:48594286:end --><!-- HN:48583407:start -->
* [48583407](https://news.social-protocols.org/stats?id=48583407) #27 48 points 40 comments -> [Excessive nil pointer checks in Go](https://konradreiche.com/blog/excessive-nil-pointer-checks-in-go/)<!-- HN:48583407:end --><!-- HN:48577601:start -->
* [48577601](https://news.social-protocols.org/stats?id=48577601) #26 18 points 2 comments -> [Carlo Ginzburg, Who Told the History of the Obscure, Dies at 87](https://www.nytimes.com/2026/06/17/books/carlo-ginzburg-dead.html)<!-- HN:48577601:end --><!-- HN:48618761:start -->
* [48618761](https://news.social-protocols.org/stats?id=48618761) #4 8 points 0 comments -> [Artificial](https://www.inkandswitch.com/tangents/artificial/)<!-- HN:48618761:end --><!-- HN:48619396:start -->
* [48619396](https://news.social-protocols.org/stats?id=48619396) #15 18 points 4 comments -> [Former Olympian denies vandalising Washington Reflecting Pool after arrest](https://www.bbc.com/news/articles/c8d26051vv2o)<!-- HN:48619396:end --><!-- HN:48590573:start -->
* [48590573](https://news.social-protocols.org/stats?id=48590573) #21 9 points 3 comments -> [The Great Intermediary Panic](https://www.minid.net/2013/1/23/the-great-intermediary-panic)<!-- HN:48590573:end --><!-- HN:48618442:start -->
* [48618442](https://news.social-protocols.org/stats?id=48618442) #11 21 points 11 comments -> [Smashing the NIMBYs created modern capitalism](https://worksinprogress.co/issue/how-abolishing-the-stakeholder-state-caused-the-industrial-revolution/)<!-- HN:48618442:end --><!-- HN:48619783:start -->
* [48619783](https://news.social-protocols.org/stats?id=48619783) #25 10 points 0 comments -> [Olympian arrested for touching remnants of decaying Reflecting Pool: report](https://www.rawstory.com/reflecting-pool-paint-algae/)<!-- HN:48619783:end --><!-- HN:48620402:start -->
* [48620402](https://news.social-protocols.org/stats?id=48620402) #14 11 points 1 comments -> [AI is a mass psychotic delusion [video]](https://www.youtube.com/watch?v=WNiSUGCC-gY)<!-- HN:48620402:end -->