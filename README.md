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

#### **Wednesday, September 3, 2025**
<!-- HN:45115549:start -->
* [45115549](https://news.social-protocols.org/stats?id=45115549) #22 20 points 40 comments -> [No place in children's hands: &lt;16s in UK to be banned from buying energy drinks](https://www.theguardian.com/business/2025/sep/02/children-energy-drinks-government-obesity-health)<!-- HN:45115549:end -->
#### **Thursday, September 4, 2025**<!-- HN:45126567:start -->
* [45126567](https://news.social-protocols.org/stats?id=45126567) #8 -> [Google's $45M contract to spread Netanyahu's propaganda](https://jackpoulson.substack.com/p/googles-45-million-contract-with)<!-- HN:45126567:end --><!-- HN:45127636:start -->
* [45127636](https://news.social-protocols.org/stats?id=45127636) #20 140 points 62 comments -> [Atlassian is acquiring the Browser Company](https://www.cnbc.com/2025/09/04/atlassian-the-browser-company-deal.html)<!-- HN:45127636:end --><!-- HN:45127232:start -->
* [45127232](https://news.social-protocols.org/stats?id=45127232) #8 76 points 32 comments -> [Browser Company (makers of Arc browser) Acquired By Atlassian for $610M](https://browsercompany.substack.com/p/your-tuesday-in-2030)<!-- HN:45127232:end --><!-- HN:45126500:start -->
* [45126500](https://news.social-protocols.org/stats?id=45126500) #13 64 points 18 comments -> [The company behind the Dia and Arc browsers is being acquired](https://www.theverge.com/web/770947/browser-company-arc-dia-acquired-atlassian)<!-- HN:45126500:end --><!-- HN:45132729:start -->
* [45132729](https://news.social-protocols.org/stats?id=45132729) #13 28 points 9 comments -> [They blew up a boat far offshore, killed eleven people, and called it justice](https://mitchthelawyer.substack.com/p/they-blew-up-a-boat-far-offshore)<!-- HN:45132729:end -->
#### **Friday, September 5, 2025**
<!-- HN:45094324:start -->
* [45094324](https://news.social-protocols.org/stats?id=45094324) #5 46 points 1 comments -> [The Unix Conspiracy](http://www.catb.org/~esr/jargon/html/U/Unix-conspiracy.html)<!-- HN:45094324:end --><!-- HN:45134212:start -->
* [45134212](https://news.social-protocols.org/stats?id=45134212) #3 44 points 10 comments -> [MIT says AI isn't replacing you it's just wasting your boss's money](https://www.interviewquery.com/p/mit-ai-isnt-replacing-workers-just-wasting-money)<!-- HN:45134212:end --><!-- HN:45134438:start -->
* [45134438](https://news.social-protocols.org/stats?id=45134438) #11 6 points 0 comments -> [simonw has vibe-coded 124 useful tools](https://simonwillison.net/2025/Sep/4/highlighted-tools/)<!-- HN:45134438:end --><!-- HN:45134771:start -->
* [45134771](https://news.social-protocols.org/stats?id=45134771) #11 10 points 11 comments -> [Expanding Economic Opportunity with AI](https://openai.com/index/expanding-economic-opportunity-with-ai/)<!-- HN:45134771:end --><!-- HN:45092621:start -->
* [45092621](https://news.social-protocols.org/stats?id=45092621) #8 25 points 5 comments -> [Show HN: First Half of "Swimming in Tech Debt" (book about tech debt)](https://helpthisbook.com/lou-franco/swimming-in-tech-debt)<!-- HN:45092621:end --><!-- HN:45135895:start -->
* [45135895](https://news.social-protocols.org/stats?id=45135895) #10 5 points 0 comments -> [To what extent is the war in Gaza justified?](https://mathsandsoundingoff.wordpress.com/2025/06/23/to-what-extent-is-the-war-in-gaza-justified/)<!-- HN:45135895:end --><!-- HN:45139122:start -->
* [45139122](https://news.social-protocols.org/stats?id=45139122) #4 10 points 8 comments -> [Why Browser Company at $610M is cheap](https://bigtechpr.substack.com/p/why-browser-co-610m-is-cheap)<!-- HN:45139122:end --><!-- HN:45095591:start -->
* [45095591](https://news.social-protocols.org/stats?id=45095591) #29 26 points 7 comments -> [The Diffusion Dilemma](https://arenamag.com/articles/the-diffusion-dilemma)<!-- HN:45095591:end --><!-- HN:45140991:start -->
* [45140991](https://news.social-protocols.org/stats?id=45140991) #8 6 points 0 comments -> [USA Cycling bans transgender athletes from female categories beginning Sep. 15](https://www.cyclingweekly.com/news/usa-cycling-bans-transgender-athletes-from-female-categories-beginning-september-15-2025)<!-- HN:45140991:end --><!-- HN:45108026:start -->
* [45108026](https://news.social-protocols.org/stats?id=45108026) #29 8 points 0 comments -> [How to Spot (and Fix) 5 Common Performance Bottlenecks in Pandas Workflows](https://developer.nvidia.com/blog/how-to-spot-and-fix-5-common-performance-bottlenecks-in-pandas-workflows/)<!-- HN:45108026:end --><!-- HN:45143481:start -->
* [45143481](https://news.social-protocols.org/stats?id=45143481) #12 12 points 3 comments -> [Boys vs. Women: Male High School Athletes vs. Female Olympians](https://boysvswomen.com/?2016)<!-- HN:45143481:end -->
#### **Saturday, September 6, 2025**
<!-- HN:45102536:start -->
* [45102536](https://news.social-protocols.org/stats?id=45102536) #22 16 points 0 comments -> [Everything About Bitflags: How to store up to 32 booleans in one value?](https://neg4n.dev/blog/everything-about-bitflags)<!-- HN:45102536:end --><!-- HN:45149330:start -->
* [45149330](https://news.social-protocols.org/stats?id=45149330) #12 14 points 10 comments -> [Vibe Coding Through the Berghain Challenge](https://www.nibzard.com/berghain/)<!-- HN:45149330:end --><!-- HN:45150749:start -->
* [45150749](https://news.social-protocols.org/stats?id=45150749) #18 4 points 0 comments -> [Stock buybacks are stock swindles](https://pluralistic.net/2025/09/06/computer-says-huh/#invisible-handcuffs)<!-- HN:45150749:end --><!-- HN:45148572:start -->
* [45148572](https://news.social-protocols.org/stats?id=45148572) #15 43 points 2 comments -> [Tylenol-maker shares hit after report RFK Jr will suggest autism link](https://www.bbc.com/news/articles/cx25l92q9xgo)<!-- HN:45148572:end --><!-- HN:45151573:start -->
* [45151573](https://news.social-protocols.org/stats?id=45151573) #7 7 points 0 comments -> [Study: Hashtags and humour are used to spread extreme content on social media](https://news.ku.dk/all_news/2025/09/hashtags-and-humour-are-used-to-spread-extreme-content-on-social-media/)<!-- HN:45151573:end --><!-- HN:45151539:start -->
* [45151539](https://news.social-protocols.org/stats?id=45151539) #17 10 points 1 comments -> [Microsoft BASIC, now open source](https://www.pcworld.com/article/2898698/microsofts-first-ever-programming-language-was-just-open-sourced.html)<!-- HN:45151539:end --><!-- HN:45151686:start -->
* [45151686](https://news.social-protocols.org/stats?id=45151686) #18 11 points 0 comments -> [Ghost sharks grow forehead teeth to help them have sex](https://news.ufl.edu/2025/09/ghost-shark-teeth/)<!-- HN:45151686:end -->
#### **Sunday, September 7, 2025**
<!-- HN:45154176:start -->
* [45154176](https://news.social-protocols.org/stats?id=45154176) #3 111 points 1 comments -> [mitchivin.com](https://mitchivin.com/)<!-- HN:45154176:end --><!-- HN:45117718:start -->
* [45117718](https://news.social-protocols.org/stats?id=45117718) #11 35 points 2 comments -> [Reveal – Read Eval Visualize Loop for Clojure](https://vlaaad.github.io/reveal/)<!-- HN:45117718:end --><!-- HN:45156660:start -->
* [45156660](https://news.social-protocols.org/stats?id=45156660) #8 13 points 4 comments -> [Nominees: The fastest legal way to lose your company](https://johnnydoe.is/threads/nominees-the-fastest-legal-way-to-lose-your-company.42278/)<!-- HN:45156660:end --><!-- HN:45157748:start -->
* [45157748](https://news.social-protocols.org/stats?id=45157748) #12 14 points 13 comments -> [ChatGPT is NOT a LLM – GPT is](https://www.vincirufus.com/posts/chatgpt-is-not-an-llm/)<!-- HN:45157748:end --><!-- HN:45158525:start -->
* [45158525](https://news.social-protocols.org/stats?id=45158525) #21 37 points 18 comments -> [Chrome extension that replaces occurrences of 'the cloud' with 'my butt'](https://github.com/panicsteve/cloud-to-butt)<!-- HN:45158525:end --><!-- HN:45158597:start -->
* [45158597](https://news.social-protocols.org/stats?id=45158597) #30 12 points 1 comments -> [The Expression Problem and its solution](https://eli.thegreenplace.net/2016/the-expression-problem-and-its-solutions)<!-- HN:45158597:end --><!-- HN:45160947:start -->
* [45160947](https://news.social-protocols.org/stats?id=45160947) #17 31 points 10 comments -> [Apple's A17 Pro Chip Ships with Hardware Flaw](https://github.com/JGoyd/Apple-Silicon-A17-Flaw)<!-- HN:45160947:end --><!-- HN:45161097:start -->
* [45161097](https://news.social-protocols.org/stats?id=45161097) #10 5 points 6 comments -> [Show HN: The World After 3, 5, 10, 25, 50, and 100 Years Ft. AI](https://www.mandar.cloud/blog.html)<!-- HN:45161097:end --><!-- HN:45162110:start -->
* [45162110](https://news.social-protocols.org/stats?id=45162110) #14 20 points 10 comments -> [Print GitHub Repositories as Books](https://gitprint.me/)<!-- HN:45162110:end -->
#### **Monday, September 8, 2025**<!-- HN:45164026:start -->
* [45164026](https://news.social-protocols.org/stats?id=45164026) #6 8 points 3 comments -> [Cloud Storage Is Full Email Scam: What It Is and How to Protect Yourself](https://malwaretips.com/blogs/your-cloud-storage-is-full-email-scam/)<!-- HN:45164026:end --><!-- HN:45164104:start -->
* [45164104](https://news.social-protocols.org/stats?id=45164104) #18 37 points 20 comments -> [Computers Are for Girls – Datagubbe.se](https://datagubbe.se/girls/)<!-- HN:45164104:end --><!-- HN:45157020:start -->
* [45157020](https://news.social-protocols.org/stats?id=45157020) #18 395 points 239 comments -> [Show HN: I'm a dermatologist and I vibe coded a skin cancer learning app](https://molecheck.info/)<!-- HN:45157020:end --><!-- HN:45165902:start -->
* [45165902](https://news.social-protocols.org/stats?id=45165902) #16 9 points 1 comments -> [50k art hoes will save San Francisco](https://twitter.com/taotechic/status/1964551131977437674)<!-- HN:45165902:end --><!-- HN:45139228:start -->
* [45139228](https://news.social-protocols.org/stats?id=45139228) #17 -> [How big are our embeddings now and why?](https://vickiboykis.com/2025/09/01/how-big-are-our-embeddings-now-and-why/)<!-- HN:45139228:end --><!-- HN:45167913:start -->
* [45167913](https://news.social-protocols.org/stats?id=45167913) #11 36 points 40 comments -> [Tesla Wants Out of the Car Business](https://www.theatlantic.com/technology/archive/2025/09/tesla-elon-musk-master-plan-robotaxi/684122/)<!-- HN:45167913:end --><!-- HN:45171564:start -->
* [45171564](https://news.social-protocols.org/stats?id=45171564) #8 14 points 1 comments -> [Color NPM Package Compromised](https://fasterthanli.me/articles/color-npm-package-compromised)<!-- HN:45171564:end --><!-- HN:45171361:start -->
* [45171361](https://news.social-protocols.org/stats?id=45171361) #17 29 points 20 comments -> [Escaping the Internet](https://www.ryanckulp.com/escaping-the-internet/)<!-- HN:45171361:end --><!-- HN:45172270:start -->
* [45172270](https://news.social-protocols.org/stats?id=45172270) #15 26 points 4 comments -> [The Job Market Is Hell](https://www.theatlantic.com/ideas/archive/2025/09/job-market-hell/684133/)<!-- HN:45172270:end --><!-- HN:45172942:start -->
* [45172942](https://news.social-protocols.org/stats?id=45172942) #10 -> [Spanish PM Pedro Sánchez says Israel is 'exterminating a defenceless people'](https://www.theguardian.com/world/2025/sep/08/spanish-pm-pedro-sanchez-israel-exterminating-defenceless-people-gaza)<!-- HN:45172942:end --><!-- HN:45172414:start -->
* [45172414](https://news.social-protocols.org/stats?id=45172414) #29 7 points 2 comments -> [iPhone app alerts users to nearby ICE sightings](https://www.cnn.com/2025/06/30/tech/iceblock-app-trump-immigration-crackdown)<!-- HN:45172414:end --><!-- HN:45174397:start -->
* [45174397](https://news.social-protocols.org/stats?id=45174397) #7 39 points 10 comments -> [US Holocaust museum removes anti-genocide post after being corelatted with Gaza](https://hyperallergic.com/1040088/los-angeles-holocaust-museum-walks-back-never-again-statement-sparking-outcry/)<!-- HN:45174397:end -->
#### **Tuesday, September 9, 2025**
<!-- HN:45173933:start -->
* [45173933](https://news.social-protocols.org/stats?id=45173933) #21 63 points 14 comments -> [World Nuclear Association Welcomes Microsoft Corporation as Newest Member](https://world-nuclear.org/news-and-media/press-statements/world-nuclear-association-welcomes-microsoft-corporation-as-newest-member)<!-- HN:45173933:end --><!-- HN:45177043:start -->
* [45177043](https://news.social-protocols.org/stats?id=45177043) #12 8 points 2 comments -> [Source code for the X Recommendation Algorithm](https://github.com/twitter/the-algorithm)<!-- HN:45177043:end --><!-- HN:45178389:start -->
* [45178389](https://news.social-protocols.org/stats?id=45178389) #1 122 points 32 comments -> [Mistral AI raises €1.7B to accelerate technological progress with AI](https://mistral.ai/news/mistral-ai-raises-1-7-b-to-accelerate-technological-progress-with-ai)<!-- HN:45178389:end --><!-- HN:45180353:start -->
* [45180353](https://news.social-protocols.org/stats?id=45180353) #4 18 points 27 comments -> [The Last Programmers](https://www.xipu.li/posts/the-last-programmers)<!-- HN:45180353:end --><!-- HN:45181775:start -->
* [45181775](https://news.social-protocols.org/stats?id=45181775) #28 5 points 3 comments -> [Israel bombs Qatar, targeting Hamas leadership](https://www.reuters.com/world/middle-east/several-blasts-heard-qatars-doha-israeli-media-says-hamas-leadership-targeted-2025-09-09/)<!-- HN:45181775:end --><!-- HN:45180584:start -->
* [45180584](https://news.social-protocols.org/stats?id=45180584) #15 14 points 1 comments -> [I ran Claude in a loop for 3 months, and it created a genz programming language](https://ghuntley.com/cursed/)<!-- HN:45180584:end --><!-- HN:45182137:start -->
* [45182137](https://news.social-protocols.org/stats?id=45182137) #30 6 points 0 comments -> [Zohran Mamdani Is Part of Municipal Socialism's Long History](https://jacobin.com/2025/08/mamdani-municipal-socialism-history-cities/)<!-- HN:45182137:end --><!-- HN:45186723:start -->
* [45186723](https://news.social-protocols.org/stats?id=45186723) #16 5 points 0 comments -> [Devs Cancel Claude Code En Masse – But Why?](https://www.aiengineering.report/p/devs-cancel-claude-code-en-masse)<!-- HN:45186723:end -->