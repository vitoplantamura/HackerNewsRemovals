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

#### **Wednesday, September 30, 2026**
<!-- HN:49905264:start -->
* [49905264](https://news.social-protocols.org/stats?id=49905264) #29 19 points 4 comments -> [Postgres with QUIC](https://blogs.lupyd.com/blog/postgres-with-quic/)<!-- HN:49905264:end --><!-- HN:49908851:start -->
* [49908851](https://news.social-protocols.org/stats?id=49908851) #12 6 points 0 comments -> [Scientists Have Found a Weird Physical Sign That Someone Is Interested in You](https://www.iflscience.com/scientists-have-found-a-weird-physical-sign-that-someone-is-interested-in-you-romantically-84795)<!-- HN:49908851:end --><!-- HN:49909629:start -->
* [49909629](https://news.social-protocols.org/stats?id=49909629) #15 25 points 14 comments -> [I can't tell who's teaching who anymore](https://blog.murphytrueman.com/i-cant-tell-whos-teaching-who-anymore/)<!-- HN:49909629:end --><!-- HN:49886422:start -->
* [49886422](https://news.social-protocols.org/stats?id=49886422) #21 19 points 4 comments -> [Show HN: Corral – Kill every command your agent starts](https://github.com/Cardinal44/corral)<!-- HN:49886422:end --><!-- HN:49911928:start -->
* [49911928](https://news.social-protocols.org/stats?id=49911928) #16 61 points 23 comments -> [Claude Says](https://ohhfishal.net/Posts/claude)<!-- HN:49911928:end --><!-- HN:49914539:start -->
* [49914539](https://news.social-protocols.org/stats?id=49914539) #10 8 points 5 comments -> [Codex Pricing: Pro has unlimited 5.6 usage](https://chatgpt.com/codex/pricing/)<!-- HN:49914539:end --><!-- HN:49903129:start -->
* [49903129](https://news.social-protocols.org/stats?id=49903129) #12 9 points 1 comments -> [Why the Bronze Age collapsed](https://www.worksinprogress.news/p/why-really-caused-the-bronze-age)<!-- HN:49903129:end --><!-- HN:49915221:start -->
* [49915221](https://news.social-protocols.org/stats?id=49915221) #7 8 points 2 comments -> [Why the Bronze Age Collapsed](https://www.worksinprogress.news/p/why-really-caused-the-bronze-age)<!-- HN:49915221:end -->
#### **Thursday, October 1, 2026**
<!-- HN:49915484:start -->
* [49915484](https://news.social-protocols.org/stats?id=49915484) #4 25 points 1 comments -> [EDG C++ Compiler is open source](https://github.com/edgcpp/compiler)<!-- HN:49915484:end --><!-- HN:49916015:start -->
* [49916015](https://news.social-protocols.org/stats?id=49916015) #12 7 points 0 comments -> [The Great Cholesterol Scam and the Dangers of Statins](https://www.midwesterndoctor.com/p/the-great-cholesterol-scam-and-the)<!-- HN:49916015:end --><!-- HN:49888178:start -->
* [49888178](https://news.social-protocols.org/stats?id=49888178) #20 9 points 10 comments -> [Clipboard Normalizer](https://www.jefftk.com/p/clipboard-normalizer-in-mac-app-store)<!-- HN:49888178:end --><!-- HN:49920472:start -->
* [49920472](https://news.social-protocols.org/stats?id=49920472) #16 13 points 4 comments -> [The Beclowning of Scott Bessent](https://paulkrugman.substack.com/p/the-beclowning-of-scott-bessent)<!-- HN:49920472:end --><!-- HN:49921523:start -->
* [49921523](https://news.social-protocols.org/stats?id=49921523) #5 8 points 0 comments -> [Navy Sailor Dies by Suicide After Deployment Keeps Getting Extended](https://atlantablackstar.com/2026/09/30/black-navy-sailor-dies-by-suicide-after-extended-deployment/)<!-- HN:49921523:end --><!-- HN:49921310:start -->
* [49921310](https://news.social-protocols.org/stats?id=49921310) #12 3 points 6 comments -> [Effective altruism is this century's biggest idea](https://www.economist.com/leaders/2026/10/01/effective-altruism-is-this-centurys-biggest-idea)<!-- HN:49921310:end --><!-- HN:49920997:start -->
* [49920997](https://news.social-protocols.org/stats?id=49920997) #9 331 points 141 comments -> [Google breaks promise to provide 10 years of updates to Chromebooks](https://www.osnews.com/story/146052/google-breaks-promise-to-provide-10-years-of-updates-to-chromebooks/)<!-- HN:49920997:end --><!-- HN:49925133:start -->
* [49925133](https://news.social-protocols.org/stats?id=49925133) #3 18 points 2 comments -> [I am so tired of this bullshit](https://rmoff.net/2026/10/01/i-am-so-tired-of-this-bullshit/)<!-- HN:49925133:end --><!-- HN:49925836:start -->
* [49925836](https://news.social-protocols.org/stats?id=49925836) #3 10 points 8 comments -> [Big Tech's Capex Is Half of Wall Street's Profit Growth](https://inlevel9.com/en/issues/half-the-growth-was-capex)<!-- HN:49925836:end --><!-- HN:49925421:start -->
* [49925421](https://news.social-protocols.org/stats?id=49925421) #28 12 points 1 comments -> [Terminal Email: terminal email clients for every system](https://terminalemail.com/)<!-- HN:49925421:end --><!-- HN:49926630:start -->
* [49926630](https://news.social-protocols.org/stats?id=49926630) #6 -> [Manyfold's Agents.md Is Based](https://github.com/manyfold3d/manyfold/blob/main/AGENTS.md)<!-- HN:49926630:end --><!-- HN:49927392:start -->
* [49927392](https://news.social-protocols.org/stats?id=49927392) #14 11 points 11 comments -> [OpenRadioss is not open anymore](https://www.siemens.com/en-us/products/simcenter/mechanical-simulation/radioss/rd/)<!-- HN:49927392:end -->
#### **Friday, October 2, 2026**
<!-- HN:49933386:start -->
* [49933386](https://news.social-protocols.org/stats?id=49933386) #3 16 points 4 comments -> [Claude-Shaped Science](https://www.anthropic.com/research/claude-shaped-science)<!-- HN:49933386:end --><!-- HN:49933819:start -->
* [49933819](https://news.social-protocols.org/stats?id=49933819) #20 11 points 16 comments -> [We're Missing a Key Reason Why Americans Hate AI](https://www.derekthompson.org/p/were-missing-a-key-reason-why-americans)<!-- HN:49933819:end -->
#### **Saturday, October 3, 2026**
<!-- HN:49940653:start -->
* [49940653](https://news.social-protocols.org/stats?id=49940653) #4 9 points 3 comments -> [Show HN: Google Maps Scraper MCP](https://gmapscrawl.com/google-maps-scraper-mcp)<!-- HN:49940653:end --><!-- HN:49921543:start -->
* [49921543](https://news.social-protocols.org/stats?id=49921543) #15 6 points 2 comments -> [Eight Bytes Are a Number](https://blog.sebastiansastre.co/posts/eight-bytes-are-already-a-number/)<!-- HN:49921543:end --><!-- HN:49912369:start -->
* [49912369](https://news.social-protocols.org/stats?id=49912369) #21 3 points 0 comments -> [Museum of Time-Based Art](https://motba.art)<!-- HN:49912369:end --><!-- HN:49941327:start -->
* [49941327](https://news.social-protocols.org/stats?id=49941327) #24 5 points 5 comments -> [What if AI worked at 1.000.000 tokens per seconds?](https://www.echohive.ai/one-million-tokens-per-second)<!-- HN:49941327:end --><!-- HN:49942437:start -->
* [49942437](https://news.social-protocols.org/stats?id=49942437) #28 30 points 5 comments -> [U.S. may have overthrown Venezuela due to chat with Grok](https://www.thedailybeast.com/jaw-dropping-way-trump-80-got-talked-into-a-war-is-leaked/)<!-- HN:49942437:end --><!-- HN:49942865:start -->
* [49942865](https://news.social-protocols.org/stats?id=49942865) #1 35 points 40 comments -> [An AI agent emailed researchers for help. It told us why](https://www.science.org/content/article/exclusive-ai-agent-emailed-hundreds-researchers-help-it-told-us-why)<!-- HN:49942865:end --><!-- HN:49945866:start -->
* [49945866](https://news.social-protocols.org/stats?id=49945866) #6 6 points 9 comments -> [EventMaxxer – Automatically apply to events to get you in the right room](https://github.com/giga-james/eventmaxxer)<!-- HN:49945866:end --><!-- HN:49943034:start -->
* [49943034](https://news.social-protocols.org/stats?id=49943034) #20 405 points 13 comments -> [Kolibri is an open-weight LLM from Aleph Alpha for German and English](https://tej.as/blog/aleph-alpha-kolibri)<!-- HN:49943034:end --><!-- HN:49946482:start -->
* [49946482](https://news.social-protocols.org/stats?id=49946482) #7 11 points 10 comments -> [Delta WiFi Survival Guide](https://dialta.adorellc.pro/)<!-- HN:49946482:end --><!-- HN:49947109:start -->
* [49947109](https://news.social-protocols.org/stats?id=49947109) #21 38 points 6 comments -> [Elon Musk Emails](https://elonmuskmails.com/)<!-- HN:49947109:end --><!-- HN:49947050:start -->
* [49947050](https://news.social-protocols.org/stats?id=49947050) #17 36 points 40 comments -> [Anthropic tried to persuade Pope that AI could be conscious being](https://www.telegraph.co.uk/business/2026/10/02/anthropic-lobbied-pope-to-argue-ai-conscious-being/)<!-- HN:49947050:end --><!-- HN:49948364:start -->
* [49948364](https://news.social-protocols.org/stats?id=49948364) #3 16 points 14 comments -> [Writing code by hand is over, forever](https://eliocapella.com/blog/writing-code-by-hand-is-over/)<!-- HN:49948364:end -->
#### **Sunday, October 4, 2026**
<!-- HN:49950283:start -->
* [49950283](https://news.social-protocols.org/stats?id=49950283) #8 9 points 2 comments -> [Iran says it seized US underwater vehicle conducting 'espionage'](https://thearabweekly.com/iran-says-it-seized-us-underwater-vehicle-conducting-espionage)<!-- HN:49950283:end --><!-- HN:49951081:start -->
* [49951081](https://news.social-protocols.org/stats?id=49951081) #17 6 points 1 comments -> [I stopped reviewing my agents' code. Here's what I do instead](https://alexeyindeev.substack.com/p/i-stopped-reviewing-my-agents-code)<!-- HN:49951081:end --><!-- HN:49951648:start -->
* [49951648](https://news.social-protocols.org/stats?id=49951648) #12 25 points 13 comments -> [OpenBSD Developers Reject Uutils Coreutils](https://news.lavx.hu/article/openbsd-developers-reject-uutils-coreutils-port-over-licensing-and-compatibility-concerns)<!-- HN:49951648:end --><!-- HN:49951684:start -->
* [49951684](https://news.social-protocols.org/stats?id=49951684) #18 29 points 41 comments -> ["Torturing" LLMs in a Robot Prison Has Triggered the Dumbest Debate in AI Yet](https://www.404media.co/someone-torturing-llms-in-a-robot-prison-has-triggered-the-dumbest-debate-in-ai-yet/)<!-- HN:49951684:end --><!-- HN:49955232:start -->
* [49955232](https://news.social-protocols.org/stats?id=49955232) #16 7 points 2 comments -> [Caffè Corretto](https://en.wikipedia.org/wiki/Caff%C3%A8_corretto)<!-- HN:49955232:end --><!-- HN:49955626:start -->
* [49955626](https://news.social-protocols.org/stats?id=49955626) #27 6 points 4 comments -> [Background Passive FTP with No GUI Control Survives Apple Store DFU](https://knowledgeisuserdata.medium.com/passive-ftp-enabled-on-macbook-after-apple-store-reset-and-other-observations-ac8573069e5d)<!-- HN:49955626:end --><!-- HN:49955839:start -->
* [49955839](https://news.social-protocols.org/stats?id=49955839) #4 21 points 15 comments -> [What I learnt co-leading an AI Safety bootcamp for legal and governance practit](https://www.lesswrong.com/posts/KtAug62dYRgAS8sqJ/what-i-learnt-co-leading-an-ai-safety-bootcamp-for-legal-and)<!-- HN:49955839:end --><!-- HN:49956358:start -->
* [49956358](https://news.social-protocols.org/stats?id=49956358) #3 25 points 4 comments -> [Software Engineering Is Dead. Long Live Product Engineering](https://newsletter.chainofthought.show/p/software-engineering-is-dead-long)<!-- HN:49956358:end --><!-- HN:49954882:start -->
* [49954882](https://news.social-protocols.org/stats?id=49954882) #3 189 points 111 comments -> [Car is a smartphone on wheels. Here's who's listening](https://automatictransmission.khoury.northeastern.edu/)<!-- HN:49954882:end --><!-- HN:49956416:start -->
* [49956416](https://news.social-protocols.org/stats?id=49956416) #3 5 points 3 comments -> [The CISA Alert: Security Beyond Solitary Confinement](https://jnior.com/blog/the-cisa-alert-security-beyond-solitary-confinement/)<!-- HN:49956416:end --><!-- HN:49958482:start -->
* [49958482](https://news.social-protocols.org/stats?id=49958482) #8 5 points 3 comments -> [Erm, does anyone still bother hiring in US/UK?](https://www.hotsourced.io/talent-marketplace)<!-- HN:49958482:end --><!-- HN:49958761:start -->
* [49958761](https://news.social-protocols.org/stats?id=49958761) #8 14 points 5 comments -> ["No Vendor Lock-In" Is Code for "No Product"](https://ferran.sh/writing/no-vendor-lock-in-is-code-for-no-product)<!-- HN:49958761:end -->
#### **Monday, October 5, 2026**
<!-- HN:49959260:start -->
* [49959260](https://news.social-protocols.org/stats?id=49959260) #6 18 points 4 comments -> [1 in 8 cancer cases are caused by infections](https://www.livescience.com/health/cancer/1-in-8-cancer-cases-are-caused-by-infections-underscoring-the-importance-of-vaccines-experts-say)<!-- HN:49959260:end --><!-- HN:49930690:start -->
* [49930690](https://news.social-protocols.org/stats?id=49930690) #21 51 points 10 comments -> [Quantitative Finance with OCaml](https://qcaml.com/index.html)<!-- HN:49930690:end --><!-- HN:49962726:start -->
* [49962726](https://news.social-protocols.org/stats?id=49962726) #15 5 points 1 comments -> [Girl, 12, fatally shot in US during 'dispute over parking space'](https://www.bbc.com/news/articles/cwr5y48p89vvo)<!-- HN:49962726:end --><!-- HN:49964248:start -->
* [49964248](https://news.social-protocols.org/stats?id=49964248) #9 24 points 42 comments -> [Accept 'bad things' in return for benefits of AI, says Sam Altman](https://www.theguardian.com/technology/2026/oct/05/sam-altman-open-ai-chatgpt-benefits-risks)<!-- HN:49964248:end --><!-- HN:49965786:start -->
* [49965786](https://news.social-protocols.org/stats?id=49965786) #20 22 points 16 comments -> [Altman: The world should accept some bad things happening for the benefits of AI](https://www.politico.com/news/2026/10/04/sam-altman-decoded-interview-ai-01106217)<!-- HN:49965786:end --><!-- HN:49965856:start -->
* [49965856](https://news.social-protocols.org/stats?id=49965856) #14 9 points 4 comments -> [Parents upset after CA high school cuts honors classes for 'equity' reasons](https://thenationaldesk.com/news/americas-news-now/parents-upset-after-california-high-school-cuts-honors-classes-for-equity-reasons-san-diego-advanced-patrick-henry-gpa-college-admissions-kids-students-grades)<!-- HN:49965856:end --><!-- HN:49964265:start -->
* [49964265](https://news.social-protocols.org/stats?id=49964265) #18 54 points 30 comments -> [Gitframes](https://github.com/gatewai-dev/gitframes)<!-- HN:49964265:end --><!-- HN:49963094:start -->
* [49963094](https://news.social-protocols.org/stats?id=49963094) #17 131 points 1 comments -> [Press Release: Nobel Prize in Physiology or Medicine 2026](https://www.nobelprize.org/prizes/medicine/2026/press-release/)<!-- HN:49963094:end --><!-- HN:49963386:start -->
* [49963386](https://news.social-protocols.org/stats?id=49963386) #26 8 points 2 comments -> [Nobel Prize in Physiology or Medicine 2026](https://www.nobelprize.org/prizes/medicine/)<!-- HN:49963386:end --><!-- HN:49965042:start -->
* [49965042](https://news.social-protocols.org/stats?id=49965042) #30 23 points 40 comments -> [Jonathan Haidt: AI Is the 'Neutron Bomb for Education' [video]](https://www.youtube.com/watch?v=RFTfANuLBF4)<!-- HN:49965042:end --><!-- HN:49944451:start -->
* [49944451](https://news.social-protocols.org/stats?id=49944451) #10 9 points 3 comments -> [Earth Tipped on Its Side During the Age of Dinosaurs–and Not Just Once](https://gizmodo.com/earth-tipped-on-its-side-during-the-age-of-dinosaurs-and-not-just-once-2000820281)<!-- HN:49944451:end --><!-- HN:49965833:start -->
* [49965833](https://news.social-protocols.org/stats?id=49965833) #26 34 points 41 comments -> [People are asking ChatGPT to help them decide how to vote in the midterms](https://www.npr.org/2026/10/05/nx-s1-5977852/ai-chatbots-midterm-election)<!-- HN:49965833:end --><!-- HN:49968355:start -->
* [49968355](https://news.social-protocols.org/stats?id=49968355) #20 5 points 1 comments -> [FBI Tracked Susie Wiles Phone, Emails with Journalists & Lawyers, New Docs Show](https://www.dailysignal.com/2026/10/05/fbi-tracked-susie-wiles-phone-email-communications-with-journalists-lawyers-political-advisors-new-documents-show/)<!-- HN:49968355:end --><!-- HN:49968819:start -->
* [49968819](https://news.social-protocols.org/stats?id=49968819) #25 8 points 0 comments -> [ProPublica Reporters Became Private School Owners in 24 Hours](https://www.propublica.org/article/propublica-reporters-private-school-owners)<!-- HN:49968819:end --><!-- HN:49969294:start -->
* [49969294](https://news.social-protocols.org/stats?id=49969294) #7 4 points 0 comments -> [OpenSSH Ships on Every Mac, Linux Server and Windows. Its Creator Trusts No One](https://zbruceli.org/blog/the-man-who-trusts-no-one/)<!-- HN:49969294:end --><!-- HN:49969073:start -->
* [49969073](https://news.social-protocols.org/stats?id=49969073) #8 18 points 5 comments -> [How did Rosalind Franklin miss the helix in her iconic DNA image? She didn't](https://www.science.org/content/article/how-did-rosalind-franklin-miss-helix-her-iconic-dna-image-she-didn-t)<!-- HN:49969073:end --><!-- HN:49970318:start -->
* [49970318](https://news.social-protocols.org/stats?id=49970318) #4 6 points 3 comments -> [How much should we worry about the pneumonic plague lableak in Siberia?](https://www.lesswrong.com/posts/TYfpTRxGH9frTymwN/how-much-should-we-worry-about-the-pneumonic-plague-lableak)<!-- HN:49970318:end --><!-- HN:49964018:start -->
* [49964018](https://news.social-protocols.org/stats?id=49964018) #16 66 points 1 comments -> [The era of software quality, or the era of ostriches?](https://blogs.gnome.org/mcatanzaro/2026/10/02/the-era-of-software-quality-or-the-era-of-ostriches/)<!-- HN:49964018:end --><!-- HN:49971895:start -->
* [49971895](https://news.social-protocols.org/stats?id=49971895) #9 4 points 1 comments -> [Food Atlas: Connections behind the dishes we love](https://knowledgeartist.org/pages/food-atlas)<!-- HN:49971895:end --><!-- HN:49970073:start -->
* [49970073](https://news.social-protocols.org/stats?id=49970073) #17 25 points 40 comments -> [The Third Way of Using Linux](https://hisvirusness.com/third-is-the-way)<!-- HN:49970073:end -->
#### **Tuesday, October 6, 2026**
<!-- HN:49973811:start -->
* [49973811](https://news.social-protocols.org/stats?id=49973811) #2 14 points 1 comments -> [A single license fee of £100k.00](https://dbushell.com/copyright/)<!-- HN:49973811:end --><!-- HN:49974173:start -->
* [49974173](https://news.social-protocols.org/stats?id=49974173) #8 3 points 1 comments -> [Wood Tape (2004)](http://gamesbyemail.com/WoodTape/Default.htm)<!-- HN:49974173:end --><!-- HN:49975484:start -->
* [49975484](https://news.social-protocols.org/stats?id=49975484) #4 22 points 29 comments -> [German Bundeswehr Uses AI to Screen Applicants for Right-Wing Extremism](https://news.osna.fm/german-military-intelligence-uses-ai-to-screen-bundeswehr-applicants-for-right-wing-extremism/)<!-- HN:49975484:end --><!-- HN:49975809:start -->
* [49975809](https://news.social-protocols.org/stats?id=49975809) #1 6 points 2 comments -> [DOOM, simulated and rendered inside the Firebird SQL database using WASM](https://github.com/mariuz/firebird-doom)<!-- HN:49975809:end --><!-- HN:49976693:start -->
* [49976693](https://news.social-protocols.org/stats?id=49976693) #14 4 points 1 comments -> [Asos users receive pop-up notification apparently sent by hackers](https://www.bbc.co.uk/news/live/cjkg7205q9ret)<!-- HN:49976693:end -->