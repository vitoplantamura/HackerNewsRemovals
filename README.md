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

#### **Sunday, July 12, 2026**<!-- HN:48876970:start -->
* [48876970](https://news.social-protocols.org/stats?id=48876970) #9 12 points 12 comments -> [Odyssey Linux](https://odysseylinux.org)<!-- HN:48876970:end --><!-- HN:48877349:start -->
* [48877349](https://news.social-protocols.org/stats?id=48877349) #12 31 points 9 comments -> [Firefox 12.58% for Desktop Browser Market Share in North America June 2026](https://gs.statcounter.com/browser-market-share/desktop/north-america)<!-- HN:48877349:end --><!-- HN:48877421:start -->
* [48877421](https://news.social-protocols.org/stats?id=48877421) #27 8 points 4 comments -> [Rep. Ro Khanna was detained by Israeli settlers in occupied West Bank](https://www.theguardian.com/world/2026/jul/11/ro-khanna-congressman-detained-israel-settlers-west-bank)<!-- HN:48877421:end --><!-- HN:48877009:start -->
* [48877009](https://news.social-protocols.org/stats?id=48877009) #22 18 points 3 comments -> [A public ledger of cloud outages and the SLA credits they trigger](https://slacreditwatch.com)<!-- HN:48877009:end --><!-- HN:48877672:start -->
* [48877672](https://news.social-protocols.org/stats?id=48877672) #21 3 points 3 comments -> [Show HN: Quantum-Qec / Matrix-Free Quantum Homeostatic Engine(Blueprint)](https://github.com/PJHkorea/quantum-mesh-qec)<!-- HN:48877672:end --><!-- HN:48878908:start -->
* [48878908](https://news.social-protocols.org/stats?id=48878908) #12 8 points 1 comments -> [Lindsey Graham, longtime South Carolina senator, dies at 71, office says](https://www.washingtonpost.com/politics/2026/07/12/lindsey-graham-longtime-south-carolina-senator-dies-71/)<!-- HN:48878908:end --><!-- HN:48877927:start -->
* [48877927](https://news.social-protocols.org/stats?id=48877927) #20 85 points 89 comments -> [Why are US consumers so angry? It's not just high prices](https://www.theguardian.com/us-news/ng-interactive/2026/jun/04/us-consumer-rage-prices-economy)<!-- HN:48877927:end --><!-- HN:48877192:start -->
* [48877192](https://news.social-protocols.org/stats?id=48877192) #22 98 points 45 comments -> [Long Covid May Physically Damage the Nerves That Control the Stomach](https://www.ijidonline.com/article/S1201-9712(26)00608-9/fulltext)<!-- HN:48877192:end --><!-- HN:48879232:start -->
* [48879232](https://news.social-protocols.org/stats?id=48879232) #27 10 points 4 comments -> [Senator Lindsey Graham, Republican of South Carolina, Dies at 71](https://www.nytimes.com/2026/07/12/us/politics/lindsey-graham-dead.html)<!-- HN:48879232:end --><!-- HN:48880037:start -->
* [48880037](https://news.social-protocols.org/stats?id=48880037) #11 8 points 1 comments -> [Sen. Lindsey Graham dies at 71 after 'brief and sudden illness'](https://www.nbcnews.com/politics/politics-news/sen-lindsey-graham-dies-71-brief-sudden-illness-rcna552722)<!-- HN:48880037:end --><!-- HN:48879920:start -->
* [48879920](https://news.social-protocols.org/stats?id=48879920) #19 4 points 1 comments -> [Oh dear, did someone steal something from Apple?](https://www.businessinsider.com/apple-openai-trade-secrets-masimo-a123-jony-ive-2026-7)<!-- HN:48879920:end --><!-- HN:48880233:start -->
* [48880233](https://news.social-protocols.org/stats?id=48880233) #16 26 points 15 comments -> [IT administrators are "fed up" with Microsoft's "useless" apps and Windows 11](https://www.neowin.net/news/it-admins-feel-overwhelmingly-sick-of-microsoft-and-windows-11-garbage-apps-products/)<!-- HN:48880233:end --><!-- HN:48881009:start -->
* [48881009](https://news.social-protocols.org/stats?id=48881009) #10 17 points 5 comments -> [Show HN: Only 1 of 4,356 reachable MCP servers is ready for the 2026-07-28 spec](https://github.com/Roee-Tsur/mcp-spec-check)<!-- HN:48881009:end --><!-- HN:48881634:start -->
* [48881634](https://news.social-protocols.org/stats?id=48881634) #30 7 points 2 comments -> [Undeniable proof that time travel is real](https://twitter.com/DataChaz/status/2076233674648088760)<!-- HN:48881634:end --><!-- HN:48882304:start -->
* [48882304](https://news.social-protocols.org/stats?id=48882304) #8 13 points 1 comments -> [The European Oligarchy](https://rocketup.pages.dev/posts/the-european-oligrachy/)<!-- HN:48882304:end --><!-- HN:48882601:start -->
* [48882601](https://news.social-protocols.org/stats?id=48882601) #25 18 points 0 comments -> [Website is served from a 200KB binary](https://200kb.freelang.dev/)<!-- HN:48882601:end --><!-- HN:48881385:start -->
* [48881385](https://news.social-protocols.org/stats?id=48881385) #24 15 points 0 comments -> [The Lunduke Computer Operating System](https://github.com/BryanLunduke/LCOS)<!-- HN:48881385:end --><!-- HN:48883064:start -->
* [48883064](https://news.social-protocols.org/stats?id=48883064) #22 36 points 41 comments -> [Claude Code get 50% more weekly limit](https://support.claude.com/en/articles/15910845-claude-code-may-july-2026-weekly-limits-promotion)<!-- HN:48883064:end --><!-- HN:48884055:start -->
* [48884055](https://news.social-protocols.org/stats?id=48884055) #23 3 points 0 comments -> [Terrifying moment Grandpa is launched eight feet in the air by charging bison](https://www.dailymail.com/news/article-15971065/Grandpa-launched-eight-feet-air-bison-Yellowstone.html)<!-- HN:48884055:end --><!-- HN:48885049:start -->
* [48885049](https://news.social-protocols.org/stats?id=48885049) #4 6 points 1 comments -> [Nuclear war survival guide reveals seven everyday items if disaster strikes](https://www.dailymail.com/sciencetech/article-15795297/Forgotten-nuclear-war-survival-guide-reveals-seven-everyday-items-Americans-need-disaster-strikes.html)<!-- HN:48885049:end --><!-- HN:48885236:start -->
* [48885236](https://news.social-protocols.org/stats?id=48885236) #19 5 points 0 comments -> [I trained a 113M-parameter earthquake LLM from absolute scratch](https://github.com/jiazhe868/nanogpt-seis)<!-- HN:48885236:end --><!-- HN:48885097:start -->
* [48885097](https://news.social-protocols.org/stats?id=48885097) #24 8 points 2 comments -> [I made a free Islamic prayer app to quit saying "I'll pray in 5 minutes"](https://better-prayer.com)<!-- HN:48885097:end -->
#### **Monday, July 13, 2026**
<!-- HN:48850285:start -->
* [48850285](https://news.social-protocols.org/stats?id=48850285) #29 13 points 5 comments -> [Nicotine pouches, tobacco's latest ploy](https://med.stanford.edu/news/insights/2026/06/nicotine-pouches-addiction-tobacco-industry-latest-ploy.html)<!-- HN:48850285:end --><!-- HN:48886065:start -->
* [48886065](https://news.social-protocols.org/stats?id=48886065) #29 58 points 20 comments -> [Billion Dollar PDFs](https://billiondollarpdf.com/)<!-- HN:48886065:end --><!-- HN:48886368:start -->
* [48886368](https://news.social-protocols.org/stats?id=48886368) #12 8 points 1 comments -> [Gameboy is back ( no signup)](https://gb.omniiii.com/)<!-- HN:48886368:end --><!-- HN:48818314:start -->
* [48818314](https://news.social-protocols.org/stats?id=48818314) #6 17 points 0 comments -> [A Peek Inside Jim Henson's Creature Shop, Where Whimsical Puppets Are Designed](https://www.smithsonianmag.com/travel/a-peek-inside-jim-hensons-creature-shop-where-sesame-street-characters-and-other-whimsical-puppets-are-designed-180989051/)<!-- HN:48818314:end --><!-- HN:48822234:start -->
* [48822234](https://news.social-protocols.org/stats?id=48822234) #21 80 points 17 comments -> [Deir El-Medina Strikes](https://en.wikipedia.org/wiki/Deir_el-Medina_strikes)<!-- HN:48822234:end --><!-- HN:48887490:start -->
* [48887490](https://news.social-protocols.org/stats?id=48887490) #7 6 points 1 comments -> [1970 Plymouth Hemi 'CUDA](https://knuckledustchronicles.com/1970-plymouth-hemi-cuda/)<!-- HN:48887490:end --><!-- HN:48886881:start -->
* [48886881](https://news.social-protocols.org/stats?id=48886881) #30 33 points 21 comments -> [Modernizing Property Tax Assessments in Allegheny County](https://www.prohousingpgh.org/blog/new-report-modernizing-property-tax-assessments-in-allegheny-county)<!-- HN:48886881:end --><!-- HN:48888748:start -->
* [48888748](https://news.social-protocols.org/stats?id=48888748) #29 4 points 1 comments -> [New Zealand actor Sam Neill, known for Jurassic Park and The Piano, dies at 78](https://cnalifestyle.channelnewsasia.com/entertainment/sam-neill-dead-jurassic-park-actor-585891)<!-- HN:48888748:end --><!-- HN:48892111:start -->
* [48892111](https://news.social-protocols.org/stats?id=48892111) #17 -> [A Right Too Expensive to Exercise Isn't a Right](https://deepbluedynamics.com/blog/right-too-expensive-to-exercise)<!-- HN:48892111:end --><!-- HN:48893360:start -->
* [48893360](https://news.social-protocols.org/stats?id=48893360) #25 11 points 0 comments -> [Detained by settlers, US Democrat Ro Khanna now faces pro-Israel attacks](https://www.aljazeera.com/news/2026/7/12/detained-by-settlers-us-democrat-ro-khanna-now-faces-pro-israel-attacks)<!-- HN:48893360:end --><!-- HN:48892512:start -->
* [48892512](https://news.social-protocols.org/stats?id=48892512) #5 469 points 244 comments -> [Grok uploaded my user directory to xAI's servers](https://twitter.com/a_green_being/status/2076598897779020159)<!-- HN:48892512:end --><!-- HN:48896308:start -->
* [48896308](https://news.social-protocols.org/stats?id=48896308) #3 7 points 0 comments -> [NTSB Report on NetJets first fatality in 40 years (Josh Baer RIP)](https://data.ntsb.gov/carol-repgen/api/Aviation/ReportMain/GenerateNewestReport/203191/pdf)<!-- HN:48896308:end --><!-- HN:48896365:start -->
* [48896365](https://news.social-protocols.org/stats?id=48896365) #12 18 points 3 comments -> [The Human Cost of DOGE's War on USAID](https://www.newyorker.com/news/the-new-yorker-interview/the-human-cost-of-doges-war-on-usaid)<!-- HN:48896365:end --><!-- HN:48896993:start -->
* [48896993](https://news.social-protocols.org/stats?id=48896993) #21 17 points 4 comments -> [The Chud Vision of Roman History](https://acoup.blog/2026/07/10/friday-friday-july-10-2026-on-the-chud-vision-of-roman-history/)<!-- HN:48896993:end --><!-- HN:48898064:start -->
* [48898064](https://news.social-protocols.org/stats?id=48898064) #27 4 points 0 comments -> [The security checks in every Lionshead PR](https://lionshead.digital/notes/the-security-checks-in-every-lionshead-pr)<!-- HN:48898064:end --><!-- HN:48897969:start -->
* [48897969](https://news.social-protocols.org/stats?id=48897969) #28 8 points 6 comments -> [Show HN: PlanWright – A control plane for AI coding agents](https://planwright.tools)<!-- HN:48897969:end --><!-- HN:48899741:start -->
* [48899741](https://news.social-protocols.org/stats?id=48899741) #16 -> [California rocked by another earthquake that will unleash the Big One](https://www.dailymail.com/sciencetech/article-15973745/california-earthquake-unlocks-san-andreas-garlock.html)<!-- HN:48899741:end --><!-- HN:48896800:start -->
* [48896800](https://news.social-protocols.org/stats?id=48896800) #9 146 points 72 comments -> [The real prices of frontier models. Tokens * Price, right?](https://playcode.io/blog/real-price-of-frontier-models)<!-- HN:48896800:end -->
#### **Tuesday, July 14, 2026**
<!-- HN:48901788:start -->
* [48901788](https://news.social-protocols.org/stats?id=48901788) #23 3 points 0 comments -> [America's Other Elections Problem](https://www.economist.com/united-states/2026/07/13/americas-other-elections-problem)<!-- HN:48901788:end --><!-- HN:48901695:start -->
* [48901695](https://news.social-protocols.org/stats?id=48901695) #25 37 points 13 comments -> [Agents.md – Dumb Human](https://gist.github.com/skorotkiewicz/2d4db4ceaf83aa54eb7f2066fdb961ff)<!-- HN:48901695:end --><!-- HN:48903701:start -->
* [48903701](https://news.social-protocols.org/stats?id=48903701) #28 8 points 5 comments -> [Two Case Studies of NaN](https://sebsite.pw/w/20260709-nan.html)<!-- HN:48903701:end --><!-- HN:48905030:start -->
* [48905030](https://news.social-protocols.org/stats?id=48905030) #6 14 points 4 comments -> [Show HN: Beautiful QR Codes](https://scanwayy.com)<!-- HN:48905030:end --><!-- HN:48905122:start -->
* [48905122](https://news.social-protocols.org/stats?id=48905122) #11 13 points 3 comments -> [The Definition of Done](https://adi.bio/done)<!-- HN:48905122:end --><!-- HN:48906339:start -->
* [48906339](https://news.social-protocols.org/stats?id=48906339) #22 4 points 0 comments -> [Serena Williams Fit-Dex](https://serena-williams-fitdex.netlify.app/)<!-- HN:48906339:end --><!-- HN:48847943:start -->
* [48847943](https://news.social-protocols.org/stats?id=48847943) #12 142 points 20 comments -> [The tiny cell that wasn't there](https://grist.org/science/nitrogen-cycle-cell-discovery-nitroplast-science-fertilizer-algae-bacteria/)<!-- HN:48847943:end --><!-- HN:48850688:start -->
* [48850688](https://news.social-protocols.org/stats?id=48850688) #29 65 points 7 comments -> [Paxos Made Simple (2001)[pdf]](https://lamport.azurewebsites.net/pubs/paxos-simple.pdf)<!-- HN:48850688:end --><!-- HN:48913220:start -->
* [48913220](https://news.social-protocols.org/stats?id=48913220) #12 78 points 12 comments -> [Microsoft Deletes User's 25-Year-Old Account with Thousands Spent on Games](https://xcancel.com/JoshuaKhane/status/2076918699248803977)<!-- HN:48913220:end -->
#### **Wednesday, July 15, 2026**
<!-- HN:48913953:start -->
* [48913953](https://news.social-protocols.org/stats?id=48913953) #12 10 points 5 comments -> [Linear is always a lagging indicator](https://remark.ing/rob/rob.mw/-/Linear-is-always-a)<!-- HN:48913953:end --><!-- HN:48918530:start -->
* [48918530](https://news.social-protocols.org/stats?id=48918530) #2 19 points 40 comments -> [New era for Gibraltar with removal of border controls with Spain](https://www.bbc.com/news/articles/cwydz60j3eno)<!-- HN:48918530:end --><!-- HN:48919004:start -->
* [48919004](https://news.social-protocols.org/stats?id=48919004) #21 6 points 2 comments -> [Floating Companion: Exploring Design Space for Soft Floating Robots in Indoor](https://dl.acm.org/doi/10.1145/3800645.3813051)<!-- HN:48919004:end --><!-- HN:48919265:start -->
* [48919265](https://news.social-protocols.org/stats?id=48919265) #29 6 points 7 comments -> [Filmgrab: Films A-Z](https://film-grab.com/movies-a-z/)<!-- HN:48919265:end --><!-- HN:48919832:start -->
* [48919832](https://news.social-protocols.org/stats?id=48919832) #16 8 points 5 comments -> [The $110/month self-improving pipeline](https://andywidjaja.com/blog/110-pipeline)<!-- HN:48919832:end --><!-- HN:48918956:start -->
* [48918956](https://news.social-protocols.org/stats?id=48918956) #15 31 points 40 comments -> [Societal Impacts: Claude's values across models and languages](https://www.anthropic.com/research/claude-values-models-languages)<!-- HN:48918956:end --><!-- HN:48920836:start -->
* [48920836](https://news.social-protocols.org/stats?id=48920836) #10 25 points 41 comments -> [US House of Representatives takes step to make daylight saving time permanent](https://www.bbc.com/news/articles/cz9l9venjd8o)<!-- HN:48920836:end --><!-- HN:48920537:start -->
* [48920537](https://news.social-protocols.org/stats?id=48920537) #16 14 points 23 comments -> [Show HN: Grepathy – Claude made a decision nobody approved](https://github.com/evansjp/grepathy)<!-- HN:48920537:end --><!-- HN:48920156:start -->
* [48920156](https://news.social-protocols.org/stats?id=48920156) #27 13 points 20 comments -> [What `for x in y` hides from you – From Scratch Code](https://fromscratchcode.com/blog/what-for-x-in-y-hides-from-you/)<!-- HN:48920156:end --><!-- HN:48924929:start -->
* [48924929](https://news.social-protocols.org/stats?id=48924929) #1 113 points 21 comments -> [Murati's Thinking Machines Releases Open-Weights 975B Parameter LLM](https://thinkingmachines.ai/inkling/)<!-- HN:48924929:end --><!-- HN:48926841:start -->
* [48926841](https://news.social-protocols.org/stats?id=48926841) #6 20 points 4 comments -> [Grok Build is open source](https://x.ai/open-source)<!-- HN:48926841:end --><!-- HN:48927136:start -->
* [48927136](https://news.social-protocols.org/stats?id=48927136) #10 29 points 41 comments -> [The End of Creativity](https://hugodaniel.com/posts/the-end-of-creativity/)<!-- HN:48927136:end -->
#### **Thursday, July 16, 2026**
<!-- HN:48930149:start -->
* [48930149](https://news.social-protocols.org/stats?id=48930149) #28 17 points 6 comments -> [My Throw Decides My Aim](https://thegustafson.com/blog/my-throw-decides-my-aim)<!-- HN:48930149:end --><!-- HN:48882777:start -->
* [48882777](https://news.social-protocols.org/stats?id=48882777) #12 15 points 12 comments -> [In defense of not understanding your codebase](https://www.seangoedecke.com/in-defense-of-not-understanding-your-codebase/)<!-- HN:48882777:end --><!-- HN:48932889:start -->
* [48932889](https://news.social-protocols.org/stats?id=48932889) #20 4 points 0 comments -> [I resurrected an 8-year-old dead CSS library and gave it an engine](https://usevivace.dev)<!-- HN:48932889:end --><!-- HN:48934340:start -->
* [48934340](https://news.social-protocols.org/stats?id=48934340) #21 5 points 5 comments -> [Show HN: We hid a backdoor in an LLM – $51,200 on finding it](https://protora.vulcora.se/challenge)<!-- HN:48934340:end --><!-- HN:48934583:start -->
* [48934583](https://news.social-protocols.org/stats?id=48934583) #10 20 points 11 comments -> [Show HN: AI Law Tracker – one audited API for US, EU and global AI law](https://ai-law-tracker.com)<!-- HN:48934583:end --><!-- HN:48934434:start -->
* [48934434](https://news.social-protocols.org/stats?id=48934434) #7 33 points 3 comments -> [How to spend 15 years perfecting a product](https://refactoring.guru/email/gbb-rollout2)<!-- HN:48934434:end --><!-- HN:48936621:start -->
* [48936621](https://news.social-protocols.org/stats?id=48936621) #22 7 points 1 comments -> [Building scalable AI agents with modular prompt transpilation](https://developers.googleblog.com/building-scalable-ai-agents-with-modular-prompt-transpilation/)<!-- HN:48936621:end --><!-- HN:48935541:start -->
* [48935541](https://news.social-protocols.org/stats?id=48935541) #21 15 points 1 comments -> [Kimi K3 Is Live](https://www.kimi.com/code/docs/en/kimi-code/models)<!-- HN:48935541:end --><!-- HN:48937007:start -->
* [48937007](https://news.social-protocols.org/stats?id=48937007) #13 30 points 41 comments -> [Someone Used AI to Write an Unauthorized Biography of Me](https://www.nytimes.com/2026/07/16/technology/ai-slop-books-biography-amazon.html)<!-- HN:48937007:end --><!-- HN:48938001:start -->
* [48938001](https://news.social-protocols.org/stats?id=48938001) #23 40 points 42 comments -> [SPCX is now Wall Street's most shorted new stock](https://invezz.com/news/2026/07/16/the-worlds-most-valuable-ipo-spcx-is-now-wall-streets-most-shorted-new-stock/)<!-- HN:48938001:end --><!-- HN:48938607:start -->
* [48938607](https://news.social-protocols.org/stats?id=48938607) #5 24 points 6 comments -> [Kimi K3: Open Frontier Intelligence](https://www.kimi.com/blog/kimi-k3)<!-- HN:48938607:end --><!-- HN:48939066:start -->
* [48939066](https://news.social-protocols.org/stats?id=48939066) #14 4 points 1 comments -> [Kimi K3 is ranked 3rd on artificial analysis, only 2 points behind Sol](https://artificialanalysis.ai)<!-- HN:48939066:end --><!-- HN:48900541:start -->
* [48900541](https://news.social-protocols.org/stats?id=48900541) #22 18 points 3 comments -> [Human Canaries: Remembering the Munitionettes](https://www.historytoday.com/archive/great-debates/human-canaries-remembering-munitionettes)<!-- HN:48900541:end --><!-- HN:48939596:start -->
* [48939596](https://news.social-protocols.org/stats?id=48939596) #24 3 points 1 comments -> [Show HN: Bonebox-01 – 29KB bare metal x86 OS (80 KiB, built to kill Tiny Core)](https://github.com/Deadbytes101/BONEBOX-01)<!-- HN:48939596:end --><!-- HN:48939580:start -->
* [48939580](https://news.social-protocols.org/stats?id=48939580) #2 47 points 2 comments -> [Kimi K3 Intelligence, Performance and Price Analysis](https://artificialanalysis.ai/models/kimi-k3)<!-- HN:48939580:end --><!-- HN:48870746:start -->
* [48870746](https://news.social-protocols.org/stats?id=48870746) #24 5 points 1 comments -> [Show HN: Make images render brighter than white by abusing Rec.2100 PQ profiles](https://superwhite.app/blog/how-it-works)<!-- HN:48870746:end --><!-- HN:48940801:start -->
* [48940801](https://news.social-protocols.org/stats?id=48940801) #23 12 points 7 comments -> [Just Do Things](https://ray.zo.space/blog/just-do-things)<!-- HN:48940801:end -->
#### **Friday, July 17, 2026**
<!-- HN:48941051:start -->
* [48941051](https://news.social-protocols.org/stats?id=48941051) #25 6 points 8 comments -> [Show HN: ReasonGate- An explainable gate that blocks LLM prompt injection](https://github.com/cgrtml/reasongate)<!-- HN:48941051:end --><!-- HN:48942250:start -->
* [48942250](https://news.social-protocols.org/stats?id=48942250) #9 43 points 24 comments -> [Google Kills Custom Search API on Jan 1, 2027](https://thenextgennexus.com/2026/05/14/google-kills-custom-search-api-on-jan-1-2027-you-have-9-months/)<!-- HN:48942250:end --><!-- HN:48951147:start -->
* [48951147](https://news.social-protocols.org/stats?id=48951147) #6 -> [Why the People Who Could Fix It Are the First to Leave](https://www.hackingleadership.com/p/why-the-people-who-could-fix-it-are-the-first-to-leave)<!-- HN:48951147:end --><!-- HN:48951014:start -->
* [48951014](https://news.social-protocols.org/stats?id=48951014) #12 50 points 14 comments -> [ICE Flight Monitor Interactive Dashboard](https://www.humanrightsfirst.org/ice-flight-monitor-interactive-dashboard)<!-- HN:48951014:end --><!-- HN:48952450:start -->
* [48952450](https://news.social-protocols.org/stats?id=48952450) #8 8 points 2 comments -> [I built a digital F1 garage to learn how Formula 1 cars work](https://paddockpass.app)<!-- HN:48952450:end --><!-- HN:48924855:start -->
* [48924855](https://news.social-protocols.org/stats?id=48924855) #14 7 points 2 comments -> [Show HN: Tarit – a hypervisor which is 2x faster than firecracker](https://github.com/instavm/tarit)<!-- HN:48924855:end -->
#### **Saturday, July 18, 2026**
<!-- HN:48953830:start -->
* [48953830](https://news.social-protocols.org/stats?id=48953830) #16 5 points 0 comments -> [Native C# CEL Implementation](https://www.nuget.org/packages/Celly)<!-- HN:48953830:end --><!-- HN:48954267:start -->
* [48954267](https://news.social-protocols.org/stats?id=48954267) #4 8 points 0 comments -> [Algorithm for NP-Complete Sudoku](https://zenodo.org/records/21420871)<!-- HN:48954267:end --><!-- HN:48955740:start -->
* [48955740](https://news.social-protocols.org/stats?id=48955740) #29 10 points 1 comments -> [Show HN: Find someone in the dark – light them or light yourself? (Three.js)](https://github.com/skorotkiewicz/signal-in-the-dark)<!-- HN:48955740:end --><!-- HN:48903490:start -->
* [48903490](https://news.social-protocols.org/stats?id=48903490) #13 8 points 1 comments -> [Responsive Design Calculator](https://www.redblobgames.com/blog/2026-07-11-responsive-design-calculator/)<!-- HN:48903490:end --><!-- HN:48959314:start -->
* [48959314](https://news.social-protocols.org/stats?id=48959314) #6 13 points 0 comments -> [Frozen 2 should be Rated R](https://interconnected.org/home/2026/07/17/frozen)<!-- HN:48959314:end -->