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

#### **Sunday, April 6, 2025**<!-- HN:43597836:start -->
* [43597836](https://news.social-protocols.org/stats?id=43597836) #25 -> [Silence Is Collaboration: Academics Must Speak Out Against Fascism](https://lithub.com/silence-is-collaboration-academics-must-speak-out-against-fascism/)<!-- HN:43597836:end --><!-- HN:43573453:start -->
* [43573453](https://news.social-protocols.org/stats?id=43573453) #17 13 points 10 comments -> [Show HN: Owl, a Spaced Repetition App](https://owl.cards)<!-- HN:43573453:end --><!-- HN:43598416:start -->
* [43598416](https://news.social-protocols.org/stats?id=43598416) #23 28 points 40 comments -> [The Death of the Middle-Class Restaurant](https://www.nytimes.com/2025/04/04/dining/middle-class-restaurant.html)<!-- HN:43598416:end --><!-- HN:43600060:start -->
* [43600060](https://news.social-protocols.org/stats?id=43600060) #30 35 points 10 comments -> [UK Police Arrest 30 People Per Day for Internet Comments](https://www.thetimes.com/uk/crime/article/police-make-30-arrests-a-day-for-offensive-online-messages-zbv886tqf)<!-- HN:43600060:end --><!-- HN:43600441:start -->
* [43600441](https://news.social-protocols.org/stats?id=43600441) #5 14 points 9 comments -> [Remote Work's Long-Term Effects: Why Dell and Amazon Are Bringing Employees Back](https://timestripe.com/magazine/blog/remote-works-long-term-effects/)<!-- HN:43600441:end --><!-- HN:43600490:start -->
* [43600490](https://news.social-protocols.org/stats?id=43600490) #30 19 points 15 comments -> [How to Make Superbabies](https://www.lesswrong.com/posts/DfrSZaf3JC8vJdbZL/how-to-make-superbabies)<!-- HN:43600490:end --><!-- HN:43600613:start -->
* [43600613](https://news.social-protocols.org/stats?id=43600613) #18 10 points 7 comments -> [ChatGPT-4o used to create a replica of his passport in just 5 mins bypassing KYC](https://securityaffairs.com/176224/security/chatgpt-4o-to-create-a-replica-of-his-passport-in-just-five-minutes.html)<!-- HN:43600613:end --><!-- HN:43579777:start -->
* [43579777](https://news.social-protocols.org/stats?id=43579777) #19 23 points 31 comments -> [What is an Ethernet cable? Here's how to connect to the internet without Wi-Fi](https://www.businessinsider.com/guides/tech/what-is-an-ethernet-cable)<!-- HN:43579777:end --><!-- HN:43601551:start -->
* [43601551](https://news.social-protocols.org/stats?id=43601551) #12 14 points 2 comments -> [Facebook Downloader](https://fload.app/)<!-- HN:43601551:end --><!-- HN:43602811:start -->
* [43602811](https://news.social-protocols.org/stats?id=43602811) #15 9 points 2 comments -> [U.S. Space Force awards billions to Space X](https://spaceflightnow.com/2025/04/05/u-s-space-force-awards-13-7-billion-in-new-national-security-launch-contracts-to-blue-origin-spacex-and-ula/)<!-- HN:43602811:end --><!-- HN:43602712:start -->
* [43602712](https://news.social-protocols.org/stats?id=43602712) #16 5 points 2 comments -> ['Netflix levy' would 'price out' consumers](https://www.rte.ie/news/2025/0406/1506141-netflix-levy-ireland/)<!-- HN:43602712:end --><!-- HN:43602851:start -->
* [43602851](https://news.social-protocols.org/stats?id=43602851) #4 19 points 1 comments -> [We're Committing Cultural Suicide](https://coreyrobin.com/2025/04/04/were-committing-cultural-suicide/)<!-- HN:43602851:end --><!-- HN:43602470:start -->
* [43602470](https://news.social-protocols.org/stats?id=43602470) #22 5 points 3 comments -> [How to Think About Raising Venture Capital for Your Startup](https://sillymoney.com/p/how-to-think-about-raising-venture-capital-for-your-startup)<!-- HN:43602470:end --><!-- HN:43603333:start -->
* [43603333](https://news.social-protocols.org/stats?id=43603333) #27 35 points 40 comments -> [SF Mayor Lurie to tech CEOs: 'How can we get you back?'](https://techcrunch.com/2025/04/05/sf-mayor-lurie-to-tech-ceos-how-can-we-get-you-back/)<!-- HN:43603333:end -->
#### **Monday, April 7, 2025**
<!-- HN:43606610:start -->
* [43606610](https://news.social-protocols.org/stats?id=43606610) #23 25 points 26 comments -> [Apple's mouse is so bad Tim Cook uses another brand at work](https://glassalmanac.com/apples-mouse-is-so-bad-tim-cook-uses-another-brand-at-work/)<!-- HN:43606610:end --><!-- HN:43607191:start -->
* [43607191](https://news.social-protocols.org/stats?id=43607191) #23 5 points 0 comments -> [Goldman Sachs forecast a recession if most of April 9 tariffs take effect](https://twitter.com/refsrc/status/1909078895875531074)<!-- HN:43607191:end --><!-- HN:43607906:start -->
* [43607906](https://news.social-protocols.org/stats?id=43607906) #16 10 points 6 comments -> [PHP isn't dead. Laravel is just bloated. Here's what I made instead](https://github.com/jeremie5/dataphyre)<!-- HN:43607906:end --><!-- HN:43607839:start -->
* [43607839](https://news.social-protocols.org/stats?id=43607839) #7 6 points 9 comments -> [Refutations to Roko's Basilisk](https://substack.com/home/post/p-160751863)<!-- HN:43607839:end --><!-- HN:43608695:start -->
* [43608695](https://news.social-protocols.org/stats?id=43608695) #24 4 points 0 comments -> [2025 Stock Market Crash](https://en.wikipedia.org/wiki/2025_stock_market_crash)<!-- HN:43608695:end --><!-- HN:43605751:start -->
* [43605751](https://news.social-protocols.org/stats?id=43605751) #18 140 points 13 comments -> [SciOp torrents: download, seed erased US Gov sites and datasets](https://sciop.net/uploads/)<!-- HN:43605751:end --><!-- HN:43599637:start -->
* [43599637](https://news.social-protocols.org/stats?id=43599637) #12 1162 points 238 comments -> [Standard Ebooks: liberated ebooks, carefully produced for the true book lover](https://standardebooks.org)<!-- HN:43599637:end --><!-- HN:43608551:start -->
* [43608551](https://news.social-protocols.org/stats?id=43608551) #30 104 points 60 comments -> [Writing C for Curl](https://daniel.haxx.se/blog/2025/04/07/writing-c-for-curl/)<!-- HN:43608551:end --><!-- HN:43611016:start -->
* [43611016](https://news.social-protocols.org/stats?id=43611016) #24 13 points 0 comments -> [Mark Cuban: Global tariffs with DOGE cuts 'risk far worse situation than 2008'](https://fortune.com/2025/04/07/trump-tariffs-doge-cuts-mark-cuban-2008-economic-crash/)<!-- HN:43611016:end --><!-- HN:43610936:start -->
* [43610936](https://news.social-protocols.org/stats?id=43610936) #19 3 points 0 comments -> [It's Official, Switch 2 Joy-Con Will Not Feature Hall Effect Sticks](https://www.nintendolife.com/news/2025/04/its-official-switch-2-joy-con-will-not-feature-hall-effect-sticks)<!-- HN:43610936:end --><!-- HN:43611468:start -->
* [43611468](https://news.social-protocols.org/stats?id=43611468) #13 3 points 0 comments -> [Why Software Consultants Benefit from Liberal Arts Education](https://spin.atomicobject.com/liberal-arts-software-consultant/)<!-- HN:43611468:end --><!-- HN:43611195:start -->
* [43611195](https://news.social-protocols.org/stats?id=43611195) #24 12 points 0 comments -> [Privacy at the Border: A Technical Guide to Securing Your Data and Devices](https://consciousdigital.org/privacy-at-the-border-the-ultimate-technical-guide-to-securing-your-data-and-devices-at-boarder-crossings/)<!-- HN:43611195:end --><!-- HN:43610952:start -->
* [43610952](https://news.social-protocols.org/stats?id=43610952) #18 9 points 0 comments -> [The speech police: Chairman Brendan Carr and the FCC's news distortion policy](https://arstechnica.com/tech-policy/2025/04/trumps-fcc-chair-invokes-rarely-enforced-news-distortion-policy-to-punish-media/)<!-- HN:43610952:end --><!-- HN:43611926:start -->
* [43611926](https://news.social-protocols.org/stats?id=43611926) #11 11 points 3 comments -> [AI usage is now a baseline expectation](https://twitter.com/tobi/status/1909231499448401946)<!-- HN:43611926:end --><!-- HN:43611382:start -->
* [43611382](https://news.social-protocols.org/stats?id=43611382) #3 15 points 2 comments -> [GitMCP: Transforms any GitHub project into an MCP endpoint](https://github.com/idosal/git-mcp)<!-- HN:43611382:end --><!-- HN:43580598:start -->
* [43580598](https://news.social-protocols.org/stats?id=43580598) #23 7 points 7 comments -> [Show HN: Copy Folder to ChatGPT in 0.6s – OpenRepoPrompt](https://github.com/wildberry-source/open-repoprompt)<!-- HN:43580598:end --><!-- HN:43614505:start -->
* [43614505](https://news.social-protocols.org/stats?id=43614505) #7 18 points 41 comments -> [Choviva: Chocolate replacement with less CO2 emissions](https://choviva.com/details)<!-- HN:43614505:end --><!-- HN:43613896:start -->
* [43613896](https://news.social-protocols.org/stats?id=43613896) #19 19 points 4 comments -> [Show HN: Kahuna, the IndexedDB-Manager Webextension](https://github.com/hummingme/kahuna)<!-- HN:43613896:end --><!-- HN:43582769:start -->
* [43582769](https://news.social-protocols.org/stats?id=43582769) #20 4 points 2 comments -> [Machine learning helps construct an evolutionary timeline of bacteria](https://www.sciencedaily.com/releases/2025/04/250403143647.htm)<!-- HN:43582769:end --><!-- HN:43582156:start -->
* [43582156](https://news.social-protocols.org/stats?id=43582156) #11 30 points 40 comments -> [The software engineers willing to pay $10k to help them land a coding job](https://www.businessinsider.com/software-engineer-offers-thousands-job-referral-linkedin-2025-4)<!-- HN:43582156:end -->
#### **Tuesday, April 8, 2025**
<!-- HN:43617237:start -->
* [43617237](https://news.social-protocols.org/stats?id=43617237) #15 21 points 9 comments -> [Silicon Valley 'nepo baby' publishes scathing first novel about growing up rich](https://sfstandard.com/2025/04/07/jim-breyer-son-daniel-breyer-novel-smokebirds/)<!-- HN:43617237:end --><!-- HN:43617206:start -->
* [43617206](https://news.social-protocols.org/stats?id=43617206) #22 -> [The day I taught AI to think like a Senior Developer](https://nmn.gl/blog/ai-understand-senior-developer)<!-- HN:43617206:end --><!-- HN:43617621:start -->
* [43617621](https://news.social-protocols.org/stats?id=43617621) #2 8 points 0 comments -> [Peter Thiel: Democrats not elite for going to Howard](https://offthefrontpage.com/peter-thiel-says-kamala-harris-not-elite-for-going-to-howard-not-harvard/)<!-- HN:43617621:end --><!-- HN:43617441:start -->
* [43617441](https://news.social-protocols.org/stats?id=43617441) #21 6 points 1 comments -> [Clean energy powered 40% of global electricity in 2024, report finds](https://www.theguardian.com/business/2025/apr/08/clean-energy-powered-40-of-global-electricity-in-2024-report-finds)<!-- HN:43617441:end --><!-- HN:43617299:start -->
* [43617299](https://news.social-protocols.org/stats?id=43617299) #23 13 points 1 comments -> [The Precise Language of Good Management](https://staysaasy.com/management/2025/04/06/precise-language.html)<!-- HN:43617299:end --><!-- HN:43617427:start -->
* [43617427](https://news.social-protocols.org/stats?id=43617427) #30 6 points 3 comments -> [Why are Japan streets devoid of US cars? It's no mystery, theyre not good enough](https://www.bloomberg.com/opinion/articles/2025-04-07/the-japan-tariff-myth-that-just-won-t-die-in-trump-s-head)<!-- HN:43617427:end --><!-- HN:43618178:start -->
* [43618178](https://news.social-protocols.org/stats?id=43618178) #3 29 points 11 comments -> [Deep Learning, Deep Scandal](https://garymarcus.substack.com/p/deep-learning-deep-scandal)<!-- HN:43618178:end --><!-- HN:43617671:start -->
* [43617671](https://news.social-protocols.org/stats?id=43617671) #24 4 points 1 comments -> [Lecture_diffusion_models.pdf](https://www.dropbox.com/scl/fi/gmwhx7jfi2nvm8pudn5it/lecture_diffusion_models.pdf?dl=0&e=2&noscript=1&rlkey=8w5rey4dubtnbdqitper0ab4l)<!-- HN:43617671:end --><!-- HN:43618494:start -->
* [43618494](https://news.social-protocols.org/stats?id=43618494) #23 34 points 12 comments -> [The Modern Struggle Is Fighting Weaponized Addiction (2020)](https://nav.al/addiction)<!-- HN:43618494:end --><!-- HN:43619098:start -->
* [43619098](https://news.social-protocols.org/stats?id=43619098) #28 7 points 1 comments -> [Critical Vulnerability: US Constitution v1.0](https://www.upbeatmoon.com/cve-1789-0304)<!-- HN:43619098:end --><!-- HN:43619178:start -->
* [43619178](https://news.social-protocols.org/stats?id=43619178) #27 57 points 6 comments -> [Gazans tell BBC of torture in Israeli detention](https://www.bbc.co.uk/news/articles/cn7vje365rno)<!-- HN:43619178:end --><!-- HN:43619571:start -->
* [43619571](https://news.social-protocols.org/stats?id=43619571) #20 9 points 1 comments -> [American academic faces years in jail after charged with insulting Thai monarchy](https://www.cnn.com/2025/04/08/asia/thailand-lese-majeste-paul-chambers-intl-hnk/index.html)<!-- HN:43619571:end --><!-- HN:43619804:start -->
* [43619804](https://news.social-protocols.org/stats?id=43619804) #21 11 points 2 comments -> [Microsoft ends employment of 2 workers who protested complicity of Gaza genocide](https://www.msn.com/en-us/money/other/report-microsoft-fires-two-employees-who-protested-inside-50th-anniversary-event/ar-AA1CtH32)<!-- HN:43619804:end --><!-- HN:43619315:start -->
* [43619315](https://news.social-protocols.org/stats?id=43619315) #19 144 points 112 comments -> [UK Effort to Keep Apple Encryption Fight Secret Is Blocked](https://www.msn.com/en-us/money/other/uk-effort-to-keep-apple-encryption-fight-secret-is-blocked/ar-AA1CsokD)<!-- HN:43619315:end --><!-- HN:43620859:start -->
* [43620859](https://news.social-protocols.org/stats?id=43620859) #27 55 points 54 comments -> [Doge using AI to snoop on U.S. federal workers, sources say](https://www.reuters.com/technology/artificial-intelligence/musks-doge-using-ai-snoop-us-federal-workers-sources-say-2025-04-08/)<!-- HN:43620859:end --><!-- HN:43623147:start -->
* [43623147](https://news.social-protocols.org/stats?id=43623147) #14 3 points 0 comments -> [The Coming Convergence of AI and Quantum Computing](https://www.forbes.com/sites/gilpress/2025/04/08/the-coming-convergence-of-ai-and-quantum-computing/)<!-- HN:43623147:end --><!-- HN:43624111:start -->
* [43624111](https://news.social-protocols.org/stats?id=43624111) #4 5 points 1 comments -> [Can reinforcement learning for LLMs scale beyond math and coding tasks? Probably](https://arxiv.org/abs/2503.23829)<!-- HN:43624111:end --><!-- HN:43624729:start -->
* [43624729](https://news.social-protocols.org/stats?id=43624729) #26 3 points 1 comments -> [The Coming Convergence of AI and Quantum Computing](https://www.forbes.com/sites/gilpress/2025/04/08/the-coming-convergence-of-ai-and-quantum-computing/)<!-- HN:43624729:end --><!-- HN:43624909:start -->
* [43624909](https://news.social-protocols.org/stats?id=43624909) #24 3 points 0 comments -> [A 'US-Made iPhone' Is Pure Fantasy](https://www.404media.co/a-us-made-iphone-is-pure-fantasy/)<!-- HN:43624909:end --><!-- HN:43596563:start -->
* [43596563](https://news.social-protocols.org/stats?id=43596563) #16 10 points 2 comments -> [Built an app that solved our grocery budget issues - saves us $200/month](https://apps.apple.com/us/app/plateful-meal-plan-budget/id6743173309)<!-- HN:43596563:end --><!-- HN:43624671:start -->
* [43624671](https://news.social-protocols.org/stats?id=43624671) #24 20 points 5 comments -> [Preparation Kept Bomb Threats from Disrupting the 2024 Elections](https://www.brennancenter.org/our-work/analysis-opinion/preparation-kept-bomb-threats-disrupting-2024-elections)<!-- HN:43624671:end --><!-- HN:43627075:start -->
* [43627075](https://news.social-protocols.org/stats?id=43627075) #18 16 points 2 comments -> [Trump, Doge Are Trying to Get Around Privacy Laws to Gather Your Personal Info](https://www.rollingstone.com/politics/politics-features/trump-musk-doge-privacy-personal-info-data-social-security-1235312853/)<!-- HN:43627075:end -->
#### **Wednesday, April 9, 2025**
<!-- HN:43627219:start -->
* [43627219](https://news.social-protocols.org/stats?id=43627219) #25 14 points 2 comments -> [Fictitious Name Permit](https://www.mbc.ca.gov/Licensing/Fictitious-Name-Permit/)<!-- HN:43627219:end --><!-- HN:43594311:start -->
* [43594311](https://news.social-protocols.org/stats?id=43594311) #9 18 points 1 comments -> [AI hasn't killed radiology, but it is changing it](https://www.washingtonpost.com/health/2025/04/05/ai-machine-learning-radiology-software/)<!-- HN:43594311:end --><!-- HN:43628528:start -->
* [43628528](https://news.social-protocols.org/stats?id=43628528) #30 3 points 0 comments -> [Using LLM to Generate Data for D3.js Force Directed Graph (FDG)](https://medium.com/@junjunzaragosa2309/using-llm-to-generate-data-for-d3-js-force-directed-graph-c490382d1172)<!-- HN:43628528:end --><!-- HN:43629455:start -->
* [43629455](https://news.social-protocols.org/stats?id=43629455) #4 16 points 28 comments -> [Domain Sniped on Launch Day](https://kill-saas.com/posts/domain-snipe)<!-- HN:43629455:end --><!-- HN:43597302:start -->
* [43597302](https://news.social-protocols.org/stats?id=43597302) #11 8 points 8 comments -> [Deaf "hearing" companion- Alerts for people who can't hear sounds they should](https://apps.apple.com/us/app/taptic-d-deaf-support/id6478986437)<!-- HN:43597302:end --><!-- HN:43629579:start -->
* [43629579](https://news.social-protocols.org/stats?id=43629579) #14 34 points 42 comments -> [The New Legislators of Silicon Valley](https://www.theideasletter.org/essay/silicon-valleys-new-legislators/)<!-- HN:43629579:end --><!-- HN:43631160:start -->
* [43631160](https://news.social-protocols.org/stats?id=43631160) #4 11 points 0 comments -> [The Fall of the American Empire](https://senecaeffect.substack.com/p/the-collapse-of-the-american-empire)<!-- HN:43631160:end --><!-- HN:43631401:start -->
* [43631401](https://news.social-protocols.org/stats?id=43631401) #25 8 points 1 comments -> [Israel military razed Gaza perimeter land to create 'kill zone', soldiers say](https://www.theguardian.com/world/2025/apr/07/israel-military-gaza-perimeter-land-testimony-report)<!-- HN:43631401:end --><!-- HN:43631444:start -->
* [43631444](https://news.social-protocols.org/stats?id=43631444) #14 6 points 5 comments -> [Determining IaC ownership – a tag-based approach](https://www.token.security/blog/iac-ownership---tag-based-approach)<!-- HN:43631444:end --><!-- HN:43631695:start -->
* [43631695](https://news.social-protocols.org/stats?id=43631695) #24 17 points 6 comments -> [Doge 'didn't test' Social Security fraud detection tool at appropriate scale](https://www.theregister.com/2025/04/09/social_security_website/)<!-- HN:43631695:end --><!-- HN:43596954:start -->
* [43596954](https://news.social-protocols.org/stats?id=43596954) #23 8 points 2 comments -> [18 train cars tip in Ohio during overnight weather](https://www.wtol.com/article/news/local/hancock-county-train-derailment-washington-township-severe-weather-local-news-no-spill-of-hazardous-material-tipped-cars/512-4801fa1a-e8ec-4bc0-aeb1-532bc8621293)<!-- HN:43596954:end --><!-- HN:43632516:start -->
* [43632516](https://news.social-protocols.org/stats?id=43632516) #7 4 points 0 comments -> [Hidden social & emotional competencies in autism spectrum disorders:digital lens](https://www.frontiersin.org/journals/psychiatry/articles/10.3389/fpsyt.2025.1559202/full)<!-- HN:43632516:end --><!-- HN:43632900:start -->
* [43632900](https://news.social-protocols.org/stats?id=43632900) #22 8 points 0 comments -> [Facebook hosts Israeli ads promoting illegal activity](https://www.aljazeera.com/program/newsfeed/2025/4/9/facebook-hosts-israeli-ads-promoting-illegal-activity)<!-- HN:43632900:end --><!-- HN:43633256:start -->
* [43633256](https://news.social-protocols.org/stats?id=43633256) #17 13 points 3 comments -> [Bundeswehr to remove all Microsoft software from its systems](https://www.itprotoday.com/software-development/german-military-to-replace-microsoft-software)<!-- HN:43633256:end --><!-- HN:43633458:start -->
* [43633458](https://news.social-protocols.org/stats?id=43633458) #27 31 points 4 comments -> [About 90% of Migrants Sent to Salvador Lacked US Criminal Record](https://www.bloomberg.com/news/articles/2025-04-09/about-90-of-migrants-sent-to-salvador-lacked-us-criminal-record)<!-- HN:43633458:end --><!-- HN:43633392:start -->
* [43633392](https://news.social-protocols.org/stats?id=43633392) #9 16 points 5 comments -> [Show HN: Accessing a website you never visited before while being offline [demo]](https://www.planujemywesele.pl/sxg-tests/offline-abuse)<!-- HN:43633392:end --><!-- HN:43634582:start -->
* [43634582](https://news.social-protocols.org/stats?id=43634582) #5 239 points 148 comments -> [Trump's DOJ will no longer prosecute cryptocurrency fraud](https://www.theverge.com/policy/645399/trump-doj-cryptocurrency-fraud-prosecutions-memo)<!-- HN:43634582:end --><!-- HN:43636974:start -->
* [43636974](https://news.social-protocols.org/stats?id=43636974) #7 25 points 11 comments -> [It's all fun and games until somebody loses their retirement savings](https://www.businesslawprofessors.com/2025/03/private-company-trading/)<!-- HN:43636974:end --><!-- HN:43637683:start -->
* [43637683](https://news.social-protocols.org/stats?id=43637683) #30 4 points 1 comments -> [Dept of Homeland Security Says Social Media Will Be Screened for 'Antisemitism'](https://dashboard.stripe.com/login)<!-- HN:43637683:end --><!-- HN:43633005:start -->
* [43633005](https://news.social-protocols.org/stats?id=43633005) #28 31 points 40 comments -> [Rolex Caliber 7135: new indirect impulse escapement and high frequency movement](https://www.hodinkee.com/articles/introducing-rolex-land-dweller)<!-- HN:43633005:end --><!-- HN:43638323:start -->
* [43638323](https://news.social-protocols.org/stats?id=43638323) #16 40 points 7 comments -> ["It's not that bad" they told me – Coreboot](https://lilysthings.org/blog/coreboot/)<!-- HN:43638323:end --><!-- HN:43638148:start -->
* [43638148](https://news.social-protocols.org/stats?id=43638148) #23 19 points 4 comments -> [Bye bye 3 way handshake](https://billatnapier.medium.com/bye-bye-three-way-handshake-and-hello-to-0-rtt-d11d9c4f4fdf)<!-- HN:43638148:end -->
#### **Thursday, April 10, 2025**
<!-- HN:43639889:start -->
* [43639889](https://news.social-protocols.org/stats?id=43639889) #28 8 points 0 comments -> [ICE nabs a Maryland woman in her car after smashing her window](https://www.thebaltimorebanner.com/community/local-news/video-ice-arrest-wesminster-elsy-noemi-berrios-QJ7CIME76ZGPZEBW5C3REEPZ6E/)<!-- HN:43639889:end --><!-- HN:43639875:start -->
* [43639875](https://news.social-protocols.org/stats?id=43639875) #4 8 points 1 comments -> [A2A Protocol – Agent-to-Agent Communication](https://a2aprotocol.ai)<!-- HN:43639875:end --><!-- HN:43609758:start -->
* [43609758](https://news.social-protocols.org/stats?id=43609758) #25 14 points 3 comments -> [Show HN: I turned GitHub contributions into a retro battle game](https://epicdevbattlesofhistory.com)<!-- HN:43609758:end --><!-- HN:43604788:start -->
* [43604788](https://news.social-protocols.org/stats?id=43604788) #16 9 points 1 comments -> [What Are the Dots on the Side of Vinyl Turntables, Is It Decoration?](https://www.djmentors.com/p/dj-machines-in-motion)<!-- HN:43604788:end --><!-- HN:43641402:start -->
* [43641402](https://news.social-protocols.org/stats?id=43641402) #3 67 points 38 comments -> [ICE director envisions Amazon-like mass deportation system](https://azmirror.com/2025/04/08/ice-director-envisions-amazon-like-mass-deportation-system-prime-but-with-human-beings/)<!-- HN:43641402:end --><!-- HN:43642802:start -->
* [43642802](https://news.social-protocols.org/stats?id=43642802) #3 9 points 0 comments -> [We've Been Conned: The Truth about Big LLM](https://www.dolthub.com/blog/2025-04-09-weve-been-conned-the-truth-about-llms/)<!-- HN:43642802:end --><!-- HN:43643342:start -->
* [43643342](https://news.social-protocols.org/stats?id=43643342) #27 9 points 4 comments -> [CPI for all items falls 0.1% in March, up 2.4% YoY](https://www.bls.gov/news.release/archives/cpi_04102025.htm)<!-- HN:43643342:end --><!-- HN:43643408:start -->
* [43643408](https://news.social-protocols.org/stats?id=43643408) #19 11 points 2 comments -> [Amazon CEO Andy Jassy's 2024 Letter to Shareholders](https://www.aboutamazon.com/news/company-news/amazon-ceo-andy-jassy-2024-letter-to-shareholders)<!-- HN:43643408:end --><!-- HN:43643104:start -->
* [43643104](https://news.social-protocols.org/stats?id=43643104) #5 12 points 0 comments -> [EGPU: Extending eBPF Programmability and Observability to GPUs](https://camps.aptaracorp.com/ACM_PMS/PMS/ACM/HCDS25/10/13a8f7c0-0a7e-11f0-ada9-16bb50361d1f/OUT/hcds25-10.html)<!-- HN:43643104:end --><!-- HN:43644146:start -->
* [43644146](https://news.social-protocols.org/stats?id=43644146) #24 10 points 2 comments -> [U.S. says it is now monitoring immigrants' social media for antisemitism](https://www.npr.org/2025/04/09/g-s1-59149/immigrants-social-media-antisemitism-dhs)<!-- HN:43644146:end --><!-- HN:43643877:start -->
* [43643877](https://news.social-protocols.org/stats?id=43643877) #30 16 points 27 comments -> [Flying Somewhere? You May Need That Real ID.](https://www.nytimes.com/2025/04/09/travel/real-id-deadline-what-to-know.html)<!-- HN:43643877:end --><!-- HN:43643312:start -->
* [43643312](https://news.social-protocols.org/stats?id=43643312) #16 -> [Photon: Rust/WebAssembly image processing library faster than VIPs and PIL](https://github.com/silvia-odwyer/photon)<!-- HN:43643312:end --><!-- HN:43643204:start -->
* [43643204](https://news.social-protocols.org/stats?id=43643204) #19 13 points 20 comments -> [Show HN: Temp.pw](https://temp.pw/)<!-- HN:43643204:end --><!-- HN:43642928:start -->
* [43642928](https://news.social-protocols.org/stats?id=43642928) #28 30 points 39 comments -> [Rick Steves: Are Americans Still Welcome in Europe?](https://blog.ricksteves.com/cameron/2025/03/americans-welcome-europe-2025/)<!-- HN:43642928:end --><!-- HN:43645724:start -->
* [43645724](https://news.social-protocols.org/stats?id=43645724) #5 6 points 0 comments -> [OpenAI Pioneers Program](https://openai.com/index/openai-pioneers-program/)<!-- HN:43645724:end --><!-- HN:43647316:start -->
* [43647316](https://news.social-protocols.org/stats?id=43647316) #27 7 points 1 comments -> [He Said He Would Ban Congressional Stock Trading. Now, He Trades Freely](https://www.nytimes.com/2025/04/05/us/politics/congress-stock-trading-ban.html)<!-- HN:43647316:end --><!-- HN:43647485:start -->
* [43647485](https://news.social-protocols.org/stats?id=43647485) #17 7 points 1 comments -> [The Brazilian Judge Taking on the Digital Far Right](https://www.newyorker.com/magazine/2025/04/14/the-brazilian-judge-taking-on-the-digital-far-right)<!-- HN:43647485:end --><!-- HN:43609468:start -->
* [43609468](https://news.social-protocols.org/stats?id=43609468) #23 7 points 1 comments -> [Your Mouse Is a Database (2012)](https://queue.acm.org/detail.cfm?id=2169076)<!-- HN:43609468:end --><!-- HN:43647164:start -->
* [43647164](https://news.social-protocols.org/stats?id=43647164) #30 9 points 2 comments -> [This is what a digital coup looks like](https://broligarchy.substack.com/p/speaking-truth-to-tech-gods-i-return)<!-- HN:43647164:end -->
#### **Friday, April 11, 2025**
<!-- HN:43648795:start -->
* [43648795](https://news.social-protocols.org/stats?id=43648795) #29 36 points 32 comments -> [We quit our Big Tech jobs after hitting #1 on HN and Product Hunt](https://www.heyopenspot.com/)<!-- HN:43648795:end --><!-- HN:43649204:start -->
* [43649204](https://news.social-protocols.org/stats?id=43649204) #10 31 points 4 comments -> [Kristi Noem, Department of Homeland Security, vs. Kilmar Armando Abrego Garcia [pdf]](https://www.supremecourt.gov/opinions/24pdf/24a949_lkhn.pdf)<!-- HN:43649204:end --><!-- HN:43649640:start -->
* [43649640](https://news.social-protocols.org/stats?id=43649640) #1 32 points 9 comments -> [Why do AI company logos look like buttholes?](https://velvetshark.com/ai-company-logos-that-look-like-buttholes)<!-- HN:43649640:end --><!-- HN:43648526:start -->
* [43648526](https://news.social-protocols.org/stats?id=43648526) #19 26 points 40 comments -> [this site uses cookies to store the fact you clicked "Accept Cookies"](https://rodyne.com/?p=2368)<!-- HN:43648526:end --><!-- HN:43650599:start -->
* [43650599](https://news.social-protocols.org/stats?id=43650599) #8 5 points 0 comments -> [I made a bot to spoil every book my girlfriend ever reads](https://www.olliechapman.com/blog/spoil-every-book)<!-- HN:43650599:end --><!-- HN:43651458:start -->
* [43651458](https://news.social-protocols.org/stats?id=43651458) #18 44 points 40 comments -> [Mastodon Exit Interview](https://v.cx/2025/04/mastodon-exit-interview)<!-- HN:43651458:end --><!-- HN:43652896:start -->
* [43652896](https://news.social-protocols.org/stats?id=43652896) #26 11 points 7 comments -> [What's Wrong with Apple?](https://www.nytimes.com/2025/04/11/technology/apple-issues-trump-tariffs.html)<!-- HN:43652896:end --><!-- HN:43653490:start -->
* [43653490](https://news.social-protocols.org/stats?id=43653490) #2 20 points 10 comments -> [No code is dead. Long live vibe coding](https://kenneth.io/post/no-code-is-dead-long-live-vibe-coding)<!-- HN:43653490:end --><!-- HN:43652643:start -->
* [43652643](https://news.social-protocols.org/stats?id=43652643) #13 7 points 4 comments -> [Show HN: Free TI-84 Plus Online (No Signup, Runs in Browser)](https://www.ti84-online.com)<!-- HN:43652643:end --><!-- HN:43649711:start -->
* [43649711](https://news.social-protocols.org/stats?id=43649711) #27 92 points 46 comments -> [Nvidia on NixOS WSL – Ollama up 24/7 on your gaming PC](https://yomaq.github.io/posts/nvidia-on-nixos-wsl-ollama-up-24-7-on-your-gaming-pc/)<!-- HN:43649711:end --><!-- HN:43654343:start -->
* [43654343](https://news.social-protocols.org/stats?id=43654343) #23 5 points 3 comments -> [Crime is down, way down](https://growsf.org/news/2025-04-10-crime-is-down/)<!-- HN:43654343:end --><!-- HN:43653922:start -->
* [43653922](https://news.social-protocols.org/stats?id=43653922) #5 10 points 4 comments -> [Browser extensions put 4M users at risk of cookie exposure](https://secureannex.com/blog/searching-for-something-unknow/)<!-- HN:43653922:end --><!-- HN:43655646:start -->
* [43655646](https://news.social-protocols.org/stats?id=43655646) #25 3 points 0 comments -> [Probiotics reduce negative mood over time: daily self-reports in detection](https://www.nature.com/articles/s44184-025-00123-z)<!-- HN:43655646:end -->
#### **Saturday, April 12, 2025**
<!-- HN:43661499:start -->
* [43661499](https://news.social-protocols.org/stats?id=43661499) #7 9 points 2 comments -> [The Coming Test of Sanity for the Administration](https://harrylitman.substack.com/p/the-coming-test-of-sanity-for-the)<!-- HN:43661499:end --><!-- HN:43663219:start -->
* [43663219](https://news.social-protocols.org/stats?id=43663219) #28 3 points 0 comments -> [What a digital coup looks like [video]](https://www.ted.com/talks/carole_cadwalladr_this_is_what_a_digital_coup_looks_like)<!-- HN:43663219:end --><!-- HN:43663941:start -->
* [43663941](https://news.social-protocols.org/stats?id=43663941) #4 16 points 41 comments -> [Why training AI can't be IP theft](https://blog.giovanh.com/blog/2025/04/03/why-training-ai-cant-be-ip-theft/)<!-- HN:43663941:end --><!-- HN:43664624:start -->
* [43664624](https://news.social-protocols.org/stats?id=43664624) #15 27 points 6 comments -> [Apple was getting bid up like crazy yesterday, don't tell me this wasn't leaked](https://twitter.com/TradingThomas3/status/1911047516021281205)<!-- HN:43664624:end --><!-- HN:43664866:start -->
* [43664866](https://news.social-protocols.org/stats?id=43664866) #21 9 points 0 comments -> [Sorry, America, tariffs won't bring jobs back](https://www.aljazeera.com/opinions/2025/4/11/sorry-america-tariffs-wont-bring-jobs-back)<!-- HN:43664866:end --><!-- HN:43664538:start -->
* [43664538](https://news.social-protocols.org/stats?id=43664538) #11 21 points 5 comments -> [AI Hallucinations Are Fueling a New Class of Supply Chain Attacks](https://socket.dev/blog/slopsquatting-how-ai-hallucinations-are-fueling-a-new-class-of-supply-chain-attacks)<!-- HN:43664538:end --><!-- HN:43664996:start -->
* [43664996](https://news.social-protocols.org/stats?id=43664996) #2 34 points 41 comments -> [Which countries would benefit most from an American brain drain?](https://www.economist.com/graphic-detail/2025/04/11/which-countries-would-benefit-most-from-an-american-brain-drain)<!-- HN:43664996:end --><!-- HN:43625815:start -->
* [43625815](https://news.social-protocols.org/stats?id=43625815) #22 20 points 0 comments -> [Stop Treating YAML Like a String](https://theyamlengineer.com/stop-treating-yaml-like-a-string)<!-- HN:43625815:end --><!-- HN:43667063:start -->
* [43667063](https://news.social-protocols.org/stats?id=43667063) #18 11 points 2 comments -> [Florida's New Social Media Bill Explicitly Demands an Encryption Backdoor](https://www.eff.org/deeplinks/2025/04/floridas-new-social-media-bill-says-quiet-part-out-loud-and-demands-encryption)<!-- HN:43667063:end --><!-- HN:43667630:start -->
* [43667630](https://news.social-protocols.org/stats?id=43667630) #18 8 points 0 comments -> [It never happened–but the picture says it did: 28 fake images that fooled world](https://www.theguardian.com/artanddesign/2025/apr/12/28-fake-images-that-fooled-the-world)<!-- HN:43667630:end -->