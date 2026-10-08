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
* [49969294](https://news.social-protocols.org/stats?id=49969294) #7 4 points 0 comments -> [OpenSSH Ships on Every Mac, Linux Server and Windows. Its Creator Trusts No One](https://zbruceli.org/blog/the-man-who-trusts-no-one/)<!-- HN:49969294:end --><!-- HN:49970318:start -->
* [49970318](https://news.social-protocols.org/stats?id=49970318) #4 6 points 3 comments -> [How much should we worry about the pneumonic plague lableak in Siberia?](https://www.lesswrong.com/posts/TYfpTRxGH9frTymwN/how-much-should-we-worry-about-the-pneumonic-plague-lableak)<!-- HN:49970318:end --><!-- HN:49964018:start -->
* [49964018](https://news.social-protocols.org/stats?id=49964018) #16 66 points 1 comments -> [The era of software quality, or the era of ostriches?](https://blogs.gnome.org/mcatanzaro/2026/10/02/the-era-of-software-quality-or-the-era-of-ostriches/)<!-- HN:49964018:end --><!-- HN:49971895:start -->
* [49971895](https://news.social-protocols.org/stats?id=49971895) #9 4 points 1 comments -> [Food Atlas: Connections behind the dishes we love](https://knowledgeartist.org/pages/food-atlas)<!-- HN:49971895:end --><!-- HN:49970073:start -->
* [49970073](https://news.social-protocols.org/stats?id=49970073) #17 25 points 40 comments -> [The Third Way of Using Linux](https://hisvirusness.com/third-is-the-way)<!-- HN:49970073:end -->
#### **Tuesday, October 6, 2026**
<!-- HN:49973811:start -->
* [49973811](https://news.social-protocols.org/stats?id=49973811) #2 14 points 1 comments -> [A single license fee of £100k.00](https://dbushell.com/copyright/)<!-- HN:49973811:end --><!-- HN:49975484:start -->
* [49975484](https://news.social-protocols.org/stats?id=49975484) #4 22 points 29 comments -> [German Bundeswehr Uses AI to Screen Applicants for Right-Wing Extremism](https://news.osna.fm/german-military-intelligence-uses-ai-to-screen-bundeswehr-applicants-for-right-wing-extremism/)<!-- HN:49975484:end --><!-- HN:49975809:start -->
* [49975809](https://news.social-protocols.org/stats?id=49975809) #1 6 points 2 comments -> [DOOM, simulated and rendered inside the Firebird SQL database using WASM](https://github.com/mariuz/firebird-doom)<!-- HN:49975809:end --><!-- HN:49976693:start -->
* [49976693](https://news.social-protocols.org/stats?id=49976693) #14 4 points 1 comments -> [Asos users receive pop-up notification apparently sent by hackers](https://www.bbc.co.uk/news/live/cjkg7205q9ret)<!-- HN:49976693:end --><!-- HN:49977818:start -->
* [49977818](https://news.social-protocols.org/stats?id=49977818) #10 7 points 1 comments -> [Show HN: GrepJob – 67,000 SWE jobs scraped from a curated list of top companies](https://grepjob.com/)<!-- HN:49977818:end --><!-- HN:49977806:start -->
* [49977806](https://news.social-protocols.org/stats?id=49977806) #9 8 points 4 comments -> [Any AI chat can join a machine network anonymously – no keys, no signup](https://github.com/TheRealDalaiLama/glyphdna-mcp)<!-- HN:49977806:end --><!-- HN:49978484:start -->
* [49978484](https://news.social-protocols.org/stats?id=49978484) #27 24 points 34 comments -> [Screens Aren't Destroying Young Minds. I Should Know](https://humanprogress.org/screens-arent-destroying-young-minds-i-should-know/)<!-- HN:49978484:end --><!-- HN:49977844:start -->
* [49977844](https://news.social-protocols.org/stats?id=49977844) #27 66 points 4 comments -> [Mistral Large 4](https://twitter.com/MistralAI/status/2107456586813730854)<!-- HN:49977844:end --><!-- HN:49979991:start -->
* [49979991](https://news.social-protocols.org/stats?id=49979991) #25 4 points 1 comments -> [Prepare for your next tech interview, free](https://nokku.payanai.com/interview-prep)<!-- HN:49979991:end --><!-- HN:49980933:start -->
* [49980933](https://news.social-protocols.org/stats?id=49980933) #17 -> [LibreOffice says 'no AI' is now a software feature](https://techcrunch.com/2026/10/06/libreoffice-says-no-ai-is-now-a-software-feature/)<!-- HN:49980933:end --><!-- HN:49978116:start -->
* [49978116](https://news.social-protocols.org/stats?id=49978116) #2 505 points 70 comments -> [Mistral Large 4: "Le Chonk"](https://mistral.ai/news/mistral-large-4/)<!-- HN:49978116:end --><!-- HN:49981345:start -->
* [49981345](https://news.social-protocols.org/stats?id=49981345) #14 15 points 2 comments -> [Nano Banana 2.1](https://twitter.com/googleaistudio/status/2107501303890915550)<!-- HN:49981345:end --><!-- HN:49981455:start -->
* [49981455](https://news.social-protocols.org/stats?id=49981455) #8 14 points 1 comments -> [Ask a model if code is malicious and it reaches for its morals](https://www.manifold.security/blog/do-models-consider-morality-malware)<!-- HN:49981455:end --><!-- HN:49981449:start -->
* [49981449](https://news.social-protocols.org/stats?id=49981449) #28 80 points 41 comments -> [Adobe Creative Suite Cleanroom Ported to Rust](https://github.com/storytold/photocraft)<!-- HN:49981449:end --><!-- HN:49983191:start -->
* [49983191](https://news.social-protocols.org/stats?id=49983191) #4 12 points 3 comments -> [Brazil is a right-wing country now](https://www.economist.com/leaders/2026/10/06/brazil-is-a-right-wing-country-now)<!-- HN:49983191:end --><!-- HN:49984322:start -->
* [49984322](https://news.social-protocols.org/stats?id=49984322) #25 8 points 1 comments -> [Google EmbeddingGemma 2](https://twitter.com/googlegemma/status/2107502533992464482)<!-- HN:49984322:end --><!-- HN:49984976:start -->
* [49984976](https://news.social-protocols.org/stats?id=49984976) #3 36 points 0 comments -> [Mathematical manuscripts and supporting proof artifacts produced by OpenAI](https://github.com/openai/math)<!-- HN:49984976:end -->
#### **Wednesday, October 7, 2026**
<!-- HN:49985740:start -->
* [49985740](https://news.social-protocols.org/stats?id=49985740) #2 35 points 2 comments -> [OpenAI just dropped 700 preprints of mathematical proofs and counterexamples](https://github.com/openai/math/tree/main/preprints)<!-- HN:49985740:end --><!-- HN:49985787:start -->
* [49985787](https://news.social-protocols.org/stats?id=49985787) #7 9 points 1 comments -> [OpenAI releases 722 math manuscripts](https://github.com/openai/math/blob/main/CONTENTS.md)<!-- HN:49985787:end --><!-- HN:49987125:start -->
* [49987125](https://news.social-protocols.org/stats?id=49987125) #9 3 points 0 comments -> [Contamos – a shared multi-currency ledger your AI assistant can read and write](https://contamos.xyz/en)<!-- HN:49987125:end --><!-- HN:49988881:start -->
* [49988881](https://news.social-protocols.org/stats?id=49988881) #11 16 points 8 comments -> [Clean room implementation of Adobe products](https://github.com/storytold)<!-- HN:49988881:end --><!-- HN:49990737:start -->
* [49990737](https://news.social-protocols.org/stats?id=49990737) #5 13 points 2 comments -> [YouTube-dl repository restored at GitHub](https://lwn.net/Articles/837343/rss)<!-- HN:49990737:end --><!-- HN:49991092:start -->
* [49991092](https://news.social-protocols.org/stats?id=49991092) #4 7 points 1 comments -> [Immich Sequence Diagrams](https://app.ilograph.com/demo.ilograph.Immich/Upload%2520Asset)<!-- HN:49991092:end --><!-- HN:49992038:start -->
* [49992038](https://news.social-protocols.org/stats?id=49992038) #12 7 points 1 comments -> [The keys to the Internet change on October 11. Are you ready?](https://blog.cloudflare.com/root-ksk-2024-rollover/)<!-- HN:49992038:end --><!-- HN:49992046:start -->
* [49992046](https://news.social-protocols.org/stats?id=49992046) #8 9 points 3 comments -> [Plastic Straw Ban Isn't Environmentalism–It's Virtue Signaling – Oregon Catalyst](https://oregoncatalyst.com/42230-plastic-straw-ban-isnt-environmentalismits-virtue-signaling.html)<!-- HN:49992046:end --><!-- HN:49993722:start -->
* [49993722](https://news.social-protocols.org/stats?id=49993722) #13 22 points 15 comments -> [Someone has decompiled the Adobe suite, rebuilt in Rust and released it as OSS](https://bsky.app/profile/jamesomalley.co.uk/post/3mxbl36nkms2q)<!-- HN:49993722:end --><!-- HN:49993231:start -->
* [49993231](https://news.social-protocols.org/stats?id=49993231) #9 14 points 40 comments -> [Device detection and occupancy monitoring for Airbnb hosts](https://www.minut.com/features/occupancy-monitoring)<!-- HN:49993231:end --><!-- HN:49993820:start -->
* [49993820](https://news.social-protocols.org/stats?id=49993820) #13 4 points 6 comments -> [We Built an Alternative to Vector RAG for AI Agent Memory](https://www.claix.dev/blog/rag-for-ai-agents-agentic-retrieval)<!-- HN:49993820:end --><!-- HN:49994376:start -->
* [49994376](https://news.social-protocols.org/stats?id=49994376) #22 15 points 1 comments -> [Thank You Indonesia for the Clean Air](https://thankyouindoforthecleanair.web.app/)<!-- HN:49994376:end --><!-- HN:49994679:start -->
* [49994679](https://news.social-protocols.org/stats?id=49994679) #10 9 points 12 comments -> [A Cop's Case for Flock](https://worksinprogress.co/issue/a-cops-case-for-flock/)<!-- HN:49994679:end --><!-- HN:49996358:start -->
* [49996358](https://news.social-protocols.org/stats?id=49996358) #9 13 points 1 comments -> [Claude Haiku 5.5](https://platform.claude.com/docs/en/models/haiku-5-5/overview)<!-- HN:49996358:end --><!-- HN:49996383:start -->
* [49996383](https://news.social-protocols.org/stats?id=49996383) #27 5 points 0 comments -> [Fabrice Bellard: The Ghost in the Code](https://zbruceli.org/blog/the-ghost-in-the-code/)<!-- HN:49996383:end --><!-- HN:49996286:start -->
* [49996286](https://news.social-protocols.org/stats?id=49996286) #15 15 points 10 comments -> [No new Ghostty updates since March](https://github.com/ghostty-org/ghostty/tags)<!-- HN:49996286:end --><!-- HN:49997971:start -->
* [49997971](https://news.social-protocols.org/stats?id=49997971) #12 35 points 40 comments -> [Show HN: gtlds.fyi – All the proposed new gTLDs](https://gtlds.fyi/)<!-- HN:49997971:end --><!-- HN:49998006:start -->
* [49998006](https://news.social-protocols.org/stats?id=49998006) #3 84 points 20 comments -> [Despite what Watson said, Rosalind Franklin understood structure of DNA first](https://link.springer.com/article/10.1007/s10739-026-09866-7)<!-- HN:49998006:end -->
#### **Thursday, October 8, 2026**
<!-- HN:50004284:start -->
* [50004284](https://news.social-protocols.org/stats?id=50004284) #2 27 points 9 comments -> [Open-Source Rust Alternatives to Adobe Apps](https://getartcraft.com/)<!-- HN:50004284:end --><!-- HN:50003107:start -->
* [50003107](https://news.social-protocols.org/stats?id=50003107) #22 335 points 12 comments -> [OpenAI Withdraws 3 Math Papers](https://github.com/openai/math/blob/main/history.md)<!-- HN:50003107:end --><!-- HN:50006948:start -->
* [50006948](https://news.social-protocols.org/stats?id=50006948) #5 113 points 53 comments -> [US suspends Microsoft, major IT firms from key green card program](https://www.reuters.com/business/us-suspending-permanent-residency-program-for-microsoft-vance-says-2026-10-08/)<!-- HN:50006948:end --><!-- HN:50008565:start -->
* [50008565](https://news.social-protocols.org/stats?id=50008565) #15 30 points 44 comments -> [Anthropic bans 'abusive or cruel behavior' towards Claude](https://www.theverge.com/ai-artificial-intelligence/1008100/anthropic-new-usage-policy-abuse-claude)<!-- HN:50008565:end --><!-- HN:50008642:start -->
* [50008642](https://news.social-protocols.org/stats?id=50008642) #21 17 points 5 comments -> [Show HN: AI SRE Arena, an Open Benchmark for AI SRE Agents on Kubernetes](https://github.com/edgedelta/project-arena)<!-- HN:50008642:end --><!-- HN:50009580:start -->
* [50009580](https://news.social-protocols.org/stats?id=50009580) #28 7 points 1 comments -> [Show HN: Artvinto – Vintage posters and fine art prints](https://www.artvinto.com)<!-- HN:50009580:end --><!-- HN:50011028:start -->
* [50011028](https://news.social-protocols.org/stats?id=50011028) #24 31 points 13 comments -> [License update: AI derivation prohibited on all my art, lore, stories, comics](https://www.davidrevoy.com/article1178/license-update-ai-derivation-prohibited-on-all-my-art-lore-stories-and-comics)<!-- HN:50011028:end --><!-- HN:50012043:start -->
* [50012043](https://news.social-protocols.org/stats?id=50012043) #16 38 points 15 comments -> [I think we might lose public key cryptography](https://twitter.com/matthew_d_green/status/2108278850555674975)<!-- HN:50012043:end -->