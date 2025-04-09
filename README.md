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

#### **Thursday, April 3, 2025**
<!-- HN:43563608:start -->
* [43563608](https://news.social-protocols.org/stats?id=43563608) #28 13 points 4 comments -> [Australian beef singled out in latest USA tariffs](https://www.abc.net.au/news/2025-04-03/australian-beef-singled-out-in-donald-trumps-liberation-tariffs/105120998)<!-- HN:43563608:end --><!-- HN:43563389:start -->
* [43563389](https://news.social-protocols.org/stats?id=43563389) #27 6 points 3 comments -> [Show HN: OpenTariffs – Tariff Percentages by Country](https://opentariffs.fyi/)<!-- HN:43563389:end --><!-- HN:43527933:start -->
* [43527933](https://news.social-protocols.org/stats?id=43527933) #23 8 points 0 comments -> [The Carbon Bankroll 2.0 [pdf] (2024)](https://static1.squarespace.com/static/651da9cd0ad7706a768d14db/t/66024d827623d72ef543b545/1711426949213/The+Carbon+Bankroll+2.0+-+From+Awareness+to+Action+%28final%29.pdf)<!-- HN:43527933:end --><!-- HN:43569636:start -->
* [43569636](https://news.social-protocols.org/stats?id=43569636) #19 10 points 0 comments -> [Decapitation Strike](https://snyder.substack.com/p/decapitation-strike)<!-- HN:43569636:end --><!-- HN:43570859:start -->
* [43570859](https://news.social-protocols.org/stats?id=43570859) #7 5 points 0 comments -> [I Hired 5 People to Sit Behind Me and Make Me Productive for a Month](https://www.simonberens.com/p/i-hired-5-people-to-sit-behind-me)<!-- HN:43570859:end --><!-- HN:43573774:start -->
* [43573774](https://news.social-protocols.org/stats?id=43573774) #19 12 points 1 comments -> [US tariff protection decimated American shipbuilding; could do same to cleanTech](https://grist.org/economics/how-trumps-liberation-day-tariffs-could-kill-american-innovation/)<!-- HN:43573774:end -->
#### **Friday, April 4, 2025**
<!-- HN:43578310:start -->
* [43578310](https://news.social-protocols.org/stats?id=43578310) #17 77 points 34 comments -> [Anduril Industries banned from recruiting on NixOS forums](https://discourse.nixos.org/t/anduril-industries-electromagnetic-warfare-team-is-hiring/62569)<!-- HN:43578310:end --><!-- HN:43579197:start -->
* [43579197](https://news.social-protocols.org/stats?id=43579197) #11 16 points 1 comments -> [Apple killed Asahi Linux with M4 update](https://social.treehouse.systems/@sven/114278224116678776)<!-- HN:43579197:end --><!-- HN:43533554:start -->
* [43533554](https://news.social-protocols.org/stats?id=43533554) #10 46 points 29 comments -> [My Rust experience after eight years](https://codecs.multimedia.cx/2025/03/my-rust-experience-after-eight-years/)<!-- HN:43533554:end --><!-- HN:43580920:start -->
* [43580920](https://news.social-protocols.org/stats?id=43580920) #20 13 points 12 comments -> [When I converted my home from gas to electric my utility bills nearly doubled](https://www.washingtonpost.com/home/2025/04/02/electric-power-home-conversion/)<!-- HN:43580920:end --><!-- HN:43580814:start -->
* [43580814](https://news.social-protocols.org/stats?id=43580814) #29 17 points 3 comments -> [America's astonishing act of self-harm](https://www.ft.com/content/21454c08-8e1c-4335-84f9-ef2d0e1aeb14)<!-- HN:43580814:end --><!-- HN:43580439:start -->
* [43580439](https://news.social-protocols.org/stats?id=43580439) #10 69 points 25 comments -> [I just want to serve 5 terabytes [video]](https://www.youtube.com/watch?v=3t6L-FlfeaI)<!-- HN:43580439:end --><!-- HN:43581768:start -->
* [43581768](https://news.social-protocols.org/stats?id=43581768) #19 15 points 6 comments -> [Rubio Orders U.S. Diplomats to Scour Student Visa Applicants' Social Media](https://www.nytimes.com/2025/04/01/us/politics/student-visas-social-media.html)<!-- HN:43581768:end --><!-- HN:43537551:start -->
* [43537551](https://news.social-protocols.org/stats?id=43537551) #10 7 points 1 comments -> [End of Life for Akamai Identity Cloud](https://techdocs.akamai.com/identity-cloud/docs/product-status)<!-- HN:43537551:end --><!-- HN:43584714:start -->
* [43584714](https://news.social-protocols.org/stats?id=43584714) #12 31 points 45 comments -> [How the 2025 US Financial Crisis is Different than 2008](https://samhenrycliff.medium.com/how-the-2025-us-financial-crisis-is-different-than-2008-5b63bdd06067)<!-- HN:43584714:end --><!-- HN:43585713:start -->
* [43585713](https://news.social-protocols.org/stats?id=43585713) #15 4 points 1 comments -> [NASA astronaut reveals they nearly failed to dock Boeing Starliner to the ISS](https://www.foxnews.com/us/nasa-astronaut-reveals-nearly-failed-dock-boeing-starliner-international-space-station)<!-- HN:43585713:end --><!-- HN:43585921:start -->
* [43585921](https://news.social-protocols.org/stats?id=43585921) #27 15 points 0 comments -> [Cyber Forensic Expert in 2k Cases Faces FBI Probe](https://krebsonsecurity.com/2025/04/cyber-forensic-expert-in-2000-cases-faces-fbi-probe/)<!-- HN:43585921:end --><!-- HN:43586647:start -->
* [43586647](https://news.social-protocols.org/stats?id=43586647) #25 4 points 0 comments -> [An AI avatar tried to argue a case before a New York court](https://apnews.com/article/artificial-intelligence-ai-courts-nyc-5c97cba3f3757d9ab3c2e5840127f765)<!-- HN:43586647:end --><!-- HN:43586436:start -->
* [43586436](https://news.social-protocols.org/stats?id=43586436) #22 5 points 1 comments -> [America's 'Tree of Life' is nearing the end of its life](https://www.sfgate.com/national-parks/article/olympic-national-park-tree-of-life-collapse-20240943.php)<!-- HN:43586436:end --><!-- HN:43586742:start -->
* [43586742](https://news.social-protocols.org/stats?id=43586742) #30 6 points 1 comments -> [Fedora CoreOS adds Hetzner provisioning](https://docs.fedoraproject.org/en-US/fedora-coreos/provisioning-hetzner/)<!-- HN:43586742:end --><!-- HN:43586811:start -->
* [43586811](https://news.social-protocols.org/stats?id=43586811) #7 17 points 3 comments -> [The Spanish electricity market registers negative prices](https://aleasoft.com/negative-prices-spanish-electricity-market/)<!-- HN:43586811:end --><!-- HN:43587611:start -->
* [43587611](https://news.social-protocols.org/stats?id=43587611) #18 37 points 40 comments -> [Wall Street Blew It](https://www.theatlantic.com/ideas/archive/2025/04/wall-street-trump-tariffs/682304/)<!-- HN:43587611:end --><!-- HN:43587577:start -->
* [43587577](https://news.social-protocols.org/stats?id=43587577) #14 3 points 1 comments -> [Everyone is pulling ML models from HuggingFace, here's what can go wrong](https://repello.ai/blog/securing-machine-learning-models-a-comprehensive-guide-to-model-scanning)<!-- HN:43587577:end -->
#### **Saturday, April 5, 2025**
<!-- HN:43590616:start -->
* [43590616](https://news.social-protocols.org/stats?id=43590616) #23 15 points 2 comments -> [Fox News Removes Stock Ticker for First Time in 28 Years](https://blogaura.ai/view/qm751lrwuzn)<!-- HN:43590616:end --><!-- HN:43590649:start -->
* [43590649](https://news.social-protocols.org/stats?id=43590649) #3 7 points 1 comments -> [Message stuck in Kafka queue for months delivered, writes bestselling novel](https://nareal.substack.com/p/message-stuck-in-kafka-queue-for)<!-- HN:43590649:end --><!-- HN:43590421:start -->
* [43590421](https://news.social-protocols.org/stats?id=43590421) #15 165 points 83 comments -> [Trump's Tariff Formula Makes No Economic Sense. It's Also Based on an Error](https://www.aei.org/economics/president-trumps-tariff-formula-makes-no-economic-sense-its-also-based-on-an-error/)<!-- HN:43590421:end --><!-- HN:43590570:start -->
* [43590570](https://news.social-protocols.org/stats?id=43590570) #22 18 points 10 comments -> [Coqui TTS: Free Text-to-Speech](https://coquitts.com)<!-- HN:43590570:end --><!-- HN:43589119:start -->
* [43589119](https://news.social-protocols.org/stats?id=43589119) #23 68 points 13 comments -> [404s – gallery of error 404 page designs](https://www.404s.design/)<!-- HN:43589119:end --><!-- HN:43592406:start -->
* [43592406](https://news.social-protocols.org/stats?id=43592406) #30 11 points 3 comments -> [Tariffs Can Help America](https://www.foreignaffairs.com/united-states/how-tariffs-can-help-america)<!-- HN:43592406:end --><!-- HN:43593226:start -->
* [43593226](https://news.social-protocols.org/stats?id=43593226) #11 7 points 0 comments -> [Red Crescent Worker Who Survived Israeli Massacre Recounts Horror](https://www.dropsitenews.com/p/red-crescent-massacre-gaza-israel)<!-- HN:43593226:end --><!-- HN:43592400:start -->
* [43592400](https://news.social-protocols.org/stats?id=43592400) #20 46 points 11 comments -> [Major endometriosis study reveals impact of gluten, coffee, dairy and alcohol](https://www.theguardian.com/society/2025/apr/05/major-endometriosis-study-reveals-impact-of-gluten-coffee-dairy-and-alcohol)<!-- HN:43592400:end --><!-- HN:43593332:start -->
* [43593332](https://news.social-protocols.org/stats?id=43593332) #19 4 points 0 comments -> [I was a British tourist trying to leave America. Then I was detained, shackled](https://www.theguardian.com/us-news/2025/apr/05/i-was-a-british-tourist-trying-to-leave-america-then-i-was-detained-shackled-and-sent-to-an-immigration-detention-centre)<!-- HN:43593332:end --><!-- HN:43595858:start -->
* [43595858](https://news.social-protocols.org/stats?id=43595858) #8 45 points 1 comments -> [The Llama 4 Herd](https://ai.meta.com/blog/llama-4-multimodal-intelligence/?_fb_noscript=1)<!-- HN:43595858:end --><!-- HN:43595656:start -->
* [43595656](https://news.social-protocols.org/stats?id=43595656) #15 6 points 4 comments -> [A Hash160 Collision](https://lbc.cryptoguru.org/man/theory)<!-- HN:43595656:end --><!-- HN:43556029:start -->
* [43556029](https://news.social-protocols.org/stats?id=43556029) #18 9 points 0 comments -> [Practical Binary Analysis](https://practicalbinaryanalysis.com)<!-- HN:43556029:end --><!-- HN:43597343:start -->
* [43597343](https://news.social-protocols.org/stats?id=43597343) #21 15 points 0 comments -> [Christine Lagarde wants EU to ditch Visa, Mastercard for own platform](https://www.businesstoday.in/world/us/story/march-to-independence-christine-lagarde-wants-eu-to-ditch-visa-mastercard-for-own-platform-470816-2025-04-05)<!-- HN:43597343:end -->
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
* [43628528](https://news.social-protocols.org/stats?id=43628528) #30 3 points 0 comments -> [Using LLM to Generate Data for D3.js Force Directed Graph (FDG)](https://medium.com/@junjunzaragosa2309/using-llm-to-generate-data-for-d3-js-force-directed-graph-c490382d1172)<!-- HN:43628528:end --><!-- HN:43629294:start -->
* [43629294](https://news.social-protocols.org/stats?id=43629294) #6 8 points 2 comments -> [Mississippi libraries ordered to delete research in response to state laws](https://mississippitoday.org/2025/04/08/mississippi-libraries-ordered-to-delete-academic-research-in-response-to-state-laws/)<!-- HN:43629294:end --><!-- HN:43629455:start -->
* [43629455](https://news.social-protocols.org/stats?id=43629455) #4 16 points 28 comments -> [Domain Sniped on Launch Day](https://kill-saas.com/posts/domain-snipe)<!-- HN:43629455:end -->