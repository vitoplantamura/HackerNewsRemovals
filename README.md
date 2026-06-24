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
* [48594286](https://news.social-protocols.org/stats?id=48594286) #20 8 points 1 comments -> [Moving Beyond Fork() + Exec()](https://lwn.net/Articles/1076018/)<!-- HN:48594286:end --><!-- HN:48577601:start -->
* [48577601](https://news.social-protocols.org/stats?id=48577601) #26 18 points 2 comments -> [Carlo Ginzburg, Who Told the History of the Obscure, Dies at 87](https://www.nytimes.com/2026/06/17/books/carlo-ginzburg-dead.html)<!-- HN:48577601:end --><!-- HN:48618761:start -->
* [48618761](https://news.social-protocols.org/stats?id=48618761) #4 8 points 0 comments -> [Artificial](https://www.inkandswitch.com/tangents/artificial/)<!-- HN:48618761:end --><!-- HN:48619396:start -->
* [48619396](https://news.social-protocols.org/stats?id=48619396) #15 18 points 4 comments -> [Former Olympian denies vandalising Washington Reflecting Pool after arrest](https://www.bbc.com/news/articles/c8d26051vv2o)<!-- HN:48619396:end --><!-- HN:48590573:start -->
* [48590573](https://news.social-protocols.org/stats?id=48590573) #21 9 points 3 comments -> [The Great Intermediary Panic](https://www.minid.net/2013/1/23/the-great-intermediary-panic)<!-- HN:48590573:end --><!-- HN:48618442:start -->
* [48618442](https://news.social-protocols.org/stats?id=48618442) #11 21 points 11 comments -> [Smashing the NIMBYs created modern capitalism](https://worksinprogress.co/issue/how-abolishing-the-stakeholder-state-caused-the-industrial-revolution/)<!-- HN:48618442:end --><!-- HN:48619783:start -->
* [48619783](https://news.social-protocols.org/stats?id=48619783) #25 10 points 0 comments -> [Olympian arrested for touching remnants of decaying Reflecting Pool: report](https://www.rawstory.com/reflecting-pool-paint-algae/)<!-- HN:48619783:end --><!-- HN:48620402:start -->
* [48620402](https://news.social-protocols.org/stats?id=48620402) #14 11 points 1 comments -> [AI is a mass psychotic delusion [video]](https://www.youtube.com/watch?v=WNiSUGCC-gY)<!-- HN:48620402:end --><!-- HN:48621847:start -->
* [48621847](https://news.social-protocols.org/stats?id=48621847) #7 4 points 0 comments -> [Selah // Your inbox is the Bible app](https://selah.to)<!-- HN:48621847:end --><!-- HN:48622815:start -->
* [48622815](https://news.social-protocols.org/stats?id=48622815) #7 28 points 30 comments -> [The Anatomy of an AI-Native Org](https://ajeygore.in/content/the-anatomy-of-an-ai-native-org)<!-- HN:48622815:end -->
#### **Monday, June 22, 2026**
<!-- HN:48623568:start -->
* [48623568](https://news.social-protocols.org/stats?id=48623568) #18 3 points 1 comments -> [Norway Bans AI for Kids 6-13 in Schools](https://yipzap.com/norway-bans-ai-for-kids-6-13-in-schools-a-bold-move-against-tech-dependency/)<!-- HN:48623568:end --><!-- HN:48623159:start -->
* [48623159](https://news.social-protocols.org/stats?id=48623159) #10 -> [I Gave an AI a Civilization to Run. It Built a Nuke – Launching CivBench](https://www.lwilko.com/blog/i-gave-an-ai-a-civilization)<!-- HN:48623159:end --><!-- HN:48624153:start -->
* [48624153](https://news.social-protocols.org/stats?id=48624153) #3 31 points 32 comments -> [Claude: Elevated Error Rates for Opus 4.8, Opus 4.7, Opus 4.6, and Sonnet 4.6](https://status.claude.com/incidents/lv35v0q9nsj2)<!-- HN:48624153:end --><!-- HN:48576209:start -->
* [48576209](https://news.social-protocols.org/stats?id=48576209) #17 5 points 0 comments -> [How the dark, violent medieval origins of Robin Hood were erased](https://www.bbc.com/culture/article/20260616-the-dark-violent-medieval-origins-of-robin-hood)<!-- HN:48576209:end --><!-- HN:48601810:start -->
* [48601810](https://news.social-protocols.org/stats?id=48601810) #10 -> [The Story of Semicolon](https://sheets.works/data-viz/semicolon)<!-- HN:48601810:end --><!-- HN:48632053:start -->
* [48632053](https://news.social-protocols.org/stats?id=48632053) #10 11 points 3 comments -> [Apparently I'm not a woman because I use Linux](https://danielle.bearblog.dev/apparently-im-not-a-woman-because-i-use-linux/)<!-- HN:48632053:end --><!-- HN:48633012:start -->
* [48633012](https://news.social-protocols.org/stats?id=48633012) #18 41 points 3 comments -> [Steam Machine Launches Today](https://store.steampowered.com/news/group/45479024/view/685257114654870245)<!-- HN:48633012:end --><!-- HN:48632989:start -->
* [48632989](https://news.social-protocols.org/stats?id=48632989) #9 48 points 21 comments -> [Steam Machine Game Testing](https://www.lttlabs.com/articles/2026/06/22/the-newell-nucleus-steam-machine-ltt-companion-article)<!-- HN:48632989:end --><!-- HN:48635363:start -->
* [48635363](https://news.social-protocols.org/stats?id=48635363) #12 3 points 0 comments -> [Brazilian Psychic Predicts Alien Invasion During World Cup Game Next Week](https://www.coasttocoastam.com/article/brazilian-psychic-predicts-alien-invasion-during-world-cup-game-next-week/)<!-- HN:48635363:end --><!-- HN:48636100:start -->
* [48636100](https://news.social-protocols.org/stats?id=48636100) #20 82 points 95 comments -> [Tacky men with ridiculous glasses want you to wear them too](https://manualdousuario.net/en/smart-glasses-ugly-tacky/)<!-- HN:48636100:end -->
#### **Tuesday, June 23, 2026**
<!-- HN:48600312:start -->
* [48600312](https://news.social-protocols.org/stats?id=48600312) #11 966 points 398 comments -> [Hyundai buys Boston Dynamics](https://startupfortune.com/hyundai-takes-full-control-of-boston-dynamics-as-softbank-exits-for-325-million/)<!-- HN:48600312:end --><!-- HN:48637566:start -->
* [48637566](https://news.social-protocols.org/stats?id=48637566) #12 8 points 0 comments -> [AI's PR Problem](https://blog.dshr.org/2026/05/ais-pr-problem.html)<!-- HN:48637566:end --><!-- HN:48638274:start -->
* [48638274](https://news.social-protocols.org/stats?id=48638274) #13 5 points 1 comments -> [Fable 5 wrote a Windows kernel in 38 minutes](https://tolmo.com/blog/when-the-model-writes-the-kernel/)<!-- HN:48638274:end --><!-- HN:48638660:start -->
* [48638660](https://news.social-protocols.org/stats?id=48638660) #5 158 points 71 comments -> [Polymarket's viral videos showed people winning big, but the bets were fake](https://arstechnica.com/tech-policy/2026/06/polymarkets-viral-videos-showed-people-winning-big-but-the-bets-were-fake/)<!-- HN:48638660:end --><!-- HN:48641869:start -->
* [48641869](https://news.social-protocols.org/stats?id=48641869) #21 5 points 2 comments -> [EU could open deportation centres outside bloc by next year, says Denmark PM](https://www.ft.com/content/cce58433-02bf-47aa-9222-89dd4e0ba2bd)<!-- HN:48641869:end --><!-- HN:48641763:start -->
* [48641763](https://news.social-protocols.org/stats?id=48641763) #19 13 points 9 comments -> [Show HN: Ideate a trading strategy with an Ex-Citadel Trader](https://sean-but-ai.vercel.app/)<!-- HN:48641763:end --><!-- HN:48648371:start -->
* [48648371](https://news.social-protocols.org/stats?id=48648371) #13 170 points 6 comments -> [75% More Pedestrians Have Been Killed Since 2009. Giant Trucks and SUVs Are Why](https://www.thedrive.com/news/75-more-pedestrians-have-been-killed-since-2009-giant-trucks-and-suvs-are-why)<!-- HN:48648371:end --><!-- HN:48649183:start -->
* [48649183](https://news.social-protocols.org/stats?id=48649183) #20 16 points 12 comments -> [The End of Code Review: Coding Agents Supersede Human Inspection](https://arxiv.org/abs/2606.13175)<!-- HN:48649183:end --><!-- HN:48650924:start -->
* [48650924](https://news.social-protocols.org/stats?id=48650924) #20 21 points 4 comments -> [Scars mark Britain's economy 10 years after Brexit vote](https://www.reuters.com/world/uk/scars-mark-britains-economy-10-years-after-brexit-vote-2026-06-23/)<!-- HN:48650924:end --><!-- HN:48650311:start -->
* [48650311](https://news.social-protocols.org/stats?id=48650311) #3 179 points 145 comments -> [Anthropic updates their terms to verify age or identity](https://www.anthropic.com/legal/privacy)<!-- HN:48650311:end --><!-- HN:48651163:start -->
* [48651163](https://news.social-protocols.org/stats?id=48651163) #22 18 points 3 comments -> [Audit finds San Francisco tax official steered $10M contract to friend](https://sfstandard.com/2026/06/23/audit-sparked-standard-investigation-finds-tax-official-steered-10m-contract-friend/)<!-- HN:48651163:end --><!-- HN:48651494:start -->
* [48651494](https://news.social-protocols.org/stats?id=48651494) #26 7 points 3 comments -> [No AI Co-Authors. A Manifesto](https://no-ai-coauthors.dev)<!-- HN:48651494:end --><!-- HN:48651700:start -->
* [48651700](https://news.social-protocols.org/stats?id=48651700) #12 9 points 1 comments -> [I automated my job (and it made me a better leader)](https://github.blog/developer-skills/github/i-automated-my-job-and-it-made-me-a-better-leader/)<!-- HN:48651700:end --><!-- HN:48651552:start -->
* [48651552](https://news.social-protocols.org/stats?id=48651552) #17 68 points 44 comments -> [All train services in Germany halted after train radio communications disruption](https://english.news.cn/20260624/65f1b6192cd947e28849776a5aef05c6/c.html)<!-- HN:48651552:end -->
#### **Wednesday, June 24, 2026**
<!-- HN:48653746:start -->
* [48653746](https://news.social-protocols.org/stats?id=48653746) #16 18 points 10 comments -> [How to Passive-Aggressively Shame People Who Use LLMs Selfishly](https://joshmoody.org/blog/selfish-ai/)<!-- HN:48653746:end --><!-- HN:48654823:start -->
* [48654823](https://news.social-protocols.org/stats?id=48654823) #13 4 points 0 comments -> [LineShine Debuts at No. 1 as the TOP500 Enters a New Global Exascale Era](https://top500.org/news/lineshine-debuts-no-1-top500-enters-new-global-exascale-era/)<!-- HN:48654823:end --><!-- HN:48654765:start -->
* [48654765](https://news.social-protocols.org/stats?id=48654765) #17 6 points 1 comments -> [Sakana Fugu: a multi-agent system delivered as one model](https://github.com/SakanaAI/fugu)<!-- HN:48654765:end --><!-- HN:48656807:start -->
* [48656807](https://news.social-protocols.org/stats?id=48656807) #2 19 points 13 comments -> [GitHub Is Becoming a Giant AI Code Dump](https://maref.cc/en/blog/vibe-coding-crisis/)<!-- HN:48656807:end --><!-- HN:48656943:start -->
* [48656943](https://news.social-protocols.org/stats?id=48656943) #14 13 points 7 comments -> [Grok Build 0.1: Intelligence, Performance and Price Analysis](https://artificialanalysis.ai/models/grok-build-0-1-06-16)<!-- HN:48656943:end -->