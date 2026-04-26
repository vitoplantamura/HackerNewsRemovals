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

#### **Monday, April 20, 2026**<!-- HN:47829015:start -->
* [47829015](https://news.social-protocols.org/stats?id=47829015) #28 -> [Canada's PM calls economic ties with US a weakness that must be corrected](https://abcnews.com/Business/wireStory/canadas-prime-minister-economic-ties-us-weakness-corrected-132187806)<!-- HN:47829015:end --><!-- HN:47829800:start -->
* [47829800](https://news.social-protocols.org/stats?id=47829800) #17 37 points 9 comments -> [Anthropic installs spyware when you install Claude Desktop](https://www.thatprivacyguy.com/blog/anthropic-spyware/)<!-- HN:47829800:end --><!-- HN:47830234:start -->
* [47830234](https://news.social-protocols.org/stats?id=47830234) #4 5 points 0 comments -> [Anthropic installs spyware when you install Claude Desktop](https://blog.alexewerlof.com/p/local-browser-ai)<!-- HN:47830234:end --><!-- HN:47830534:start -->
* [47830534](https://news.social-protocols.org/stats?id=47830534) #3 7 points 0 comments -> [DIDs Are Cool. We Didn't Need Them](https://www.inamoon.com/blog/dids-vs-subjects)<!-- HN:47830534:end --><!-- HN:47829757:start -->
* [47829757](https://news.social-protocols.org/stats?id=47829757) #18 12 points 2 comments -> [Contra Benn Jordan, data center (and all) sub-audible infrasound issues are fake](https://blog.andymasley.com/p/contra-benn-jordan-data-center-and)<!-- HN:47829757:end --><!-- HN:47766185:start -->
* [47766185](https://news.social-protocols.org/stats?id=47766185) #23 18 points 7 comments -> [Recovering Windows Live Writer Files](https://benovermyer.com/blog/2026/04/recovering-windows-live-writer-files/)<!-- HN:47766185:end --><!-- HN:47831499:start -->
* [47831499](https://news.social-protocols.org/stats?id=47831499) #30 42 points 11 comments -> [Tracking when Trump chickens out](https://www.thetacotracker.com/)<!-- HN:47831499:end --><!-- HN:47833156:start -->
* [47833156](https://news.social-protocols.org/stats?id=47833156) #1 249 points 116 comments -> [Tesla Hid Fatal Accidents to Continue Testing Autonomous Driving (French)](https://www.rts.ch/info/monde/2026/article/tesla-dissimule-des-milliers-d-incidents-de-conduite-autonome-mortels-29214161.html)<!-- HN:47833156:end --><!-- HN:47838969:start -->
* [47838969](https://news.social-protocols.org/stats?id=47838969) #11 6 points 1 comments -> [Outrage over Israeli soldier's vandalism of Jesus statue in Lebanon](https://www.bbc.com/news/articles/cpd575n1znzo)<!-- HN:47838969:end --><!-- HN:47838178:start -->
* [47838178](https://news.social-protocols.org/stats?id=47838178) #21 75 points 20 comments -> [The Palantir's Stasi Protocols](https://professorsigmund.com/praxis/palantir-stasi-protocols.html)<!-- HN:47838178:end --><!-- HN:47840570:start -->
* [47840570](https://news.social-protocols.org/stats?id=47840570) #2 50 points 1 comments -> [Tim Cook Stepping Down as Apple CEO, John Ternus Taking Over](https://techcrunch.com/2026/04/20/tim-cook-stepping-down-as-apple-ceo-john-ternus-taking-over/)<!-- HN:47840570:end -->
#### **Tuesday, April 21, 2026**
<!-- HN:47843573:start -->
* [47843573](https://news.social-protocols.org/stats?id=47843573) #21 10 points 3 comments -> [FreeBSD CVE-2026-4747 Log Suggests Mythos Is a Marketing Trick](https://www.flyingpenguin.com/freebsd-cve-2026-4747-log-suggests-mythos-is-a-marketing-trick/)<!-- HN:47843573:end --><!-- HN:47848110:start -->
* [47848110](https://news.social-protocols.org/stats?id=47848110) #17 -> [Show HN: Antenna – RSS reader with a built-in MCP server](https://antennafeed.com/)<!-- HN:47848110:end --><!-- HN:47822372:start -->
* [47822372](https://news.social-protocols.org/stats?id=47822372) #27 77 points 29 comments -> [Bullshit About Bullshit Machines [pdf]](https://aphyr.com/data/posts/411/the-future-of-everything-is-lies.pdf)<!-- HN:47822372:end --><!-- HN:47849018:start -->
* [47849018](https://news.social-protocols.org/stats?id=47849018) #21 9 points 1 comments -> [Zelensky says failure of US envoys to visit Kyiv is 'disrespectful'](https://www.bbc.com/news/articles/cd9v420y190o)<!-- HN:47849018:end --><!-- HN:47849131:start -->
* [47849131](https://news.social-protocols.org/stats?id=47849131) #27 5 points 0 comments -> [My University Hired a Terrorist](https://www.facultyleaks.com/p/my-university-hired-terrorist)<!-- HN:47849131:end --><!-- HN:47844431:start -->
* [47844431](https://news.social-protocols.org/stats?id=47844431) #27 272 points 145 comments -> [A Roblox cheat and one AI tool brought down Vercel's platform](https://webmatrices.com/post/how-a-roblox-cheat-and-one-ai-tool-brought-down-vercel-s-entire-platform)<!-- HN:47844431:end --><!-- HN:47789445:start -->
* [47789445](https://news.social-protocols.org/stats?id=47789445) #26 47 points 0 comments -> [Leonardo, Borgia, and Machiavelli: A Fateful Collusion](https://www.historytoday.com/archive/leonardo-borgia-and-machiavelli-fateful-collusion)<!-- HN:47789445:end --><!-- HN:47851242:start -->
* [47851242](https://news.social-protocols.org/stats?id=47851242) #24 47 points 10 comments -> [Meta to start capturing employee mouse movements, keystrokes for AI training](https://www.reuters.com/sustainability/boards-policy-regulation/meta-start-capturing-employee-mouse-movements-keystrokes-ai-training-data-2026-04-21/)<!-- HN:47851242:end -->
#### **Wednesday, April 22, 2026**
<!-- HN:47855616:start -->
* [47855616](https://news.social-protocols.org/stats?id=47855616) #9 102 points 41 comments -> [SpaceX Says It Has Agreement to Acquire Cursor for $60B](https://www.bloomberg.com/news/articles/2026-04-21/spacex-says-has-agreement-to-acquire-cursor-for-60-billion)<!-- HN:47855616:end --><!-- HN:47855448:start -->
* [47855448](https://news.social-protocols.org/stats?id=47855448) #15 96 points 69 comments -> [SpaceX Said to Agree to Buy Cursor for More Than $50B](https://www.nytimes.com/2026/04/21/business/spacex-cursor-deal.html)<!-- HN:47855448:end --><!-- HN:47858014:start -->
* [47858014](https://news.social-protocols.org/stats?id=47858014) #6 11 points 3 comments -> [OpenAI reinvents Recall except everything is stored remotely](https://developers.openai.com/codex/memories/chronicle)<!-- HN:47858014:end --><!-- HN:47860742:start -->
* [47860742](https://news.social-protocols.org/stats?id=47860742) #5 178 points 101 comments -> [Irony as Meta staff unhappy about running surveillance software on work PCs](https://www.theregister.com/2026/04/22/meta_employee_surveillance_software/)<!-- HN:47860742:end --><!-- HN:47860961:start -->
* [47860961](https://news.social-protocols.org/stats?id=47860961) #12 89 points 63 comments -> [Meta employees are up in arms over a mandatory program to train AI on their](https://www.businessinsider.com/meta-new-ai-tool-tracks-staff-activity-sparks-concern-2026-4)<!-- HN:47860961:end --><!-- HN:47863248:start -->
* [47863248](https://news.social-protocols.org/stats?id=47863248) #10 14 points 7 comments -> [Books Are Not Remotely Too Expensive](https://www.millersbookreview.com/p/no-books-are-not-remotely-too-expensive)<!-- HN:47863248:end --><!-- HN:47862608:start -->
* [47862608](https://news.social-protocols.org/stats?id=47862608) #4 64 points 8 comments -> [The eighth-generation TPU: An architecture deep dive](https://cloud.google.com/blog/products/compute/tpu-8t-and-tpu-8i-technical-deep-dive)<!-- HN:47862608:end --><!-- HN:47864566:start -->
* [47864566](https://news.social-protocols.org/stats?id=47864566) #8 8 points 1 comments -> [The best time to post on Hacker News](https://blog.alcazarsec.com/tech/posts/best-time-to-post-on-hacker-news)<!-- HN:47864566:end --><!-- HN:47864808:start -->
* [47864808](https://news.social-protocols.org/stats?id=47864808) #24 49 points 24 comments -> [Top MAGA influencer revealed to be AI](https://nypost.com/2026/04/21/us-news/top-maga-influencer-emily-hart-revealed-to-be-ai-created-by-a-guy-in-india/)<!-- HN:47864808:end --><!-- HN:47865432:start -->
* [47865432](https://news.social-protocols.org/stats?id=47865432) #8 6 points 1 comments -> [Windows 9x Subsystem for Linux](https://codeberg.org/hails/wsl9x)<!-- HN:47865432:end --><!-- HN:47865838:start -->
* [47865838](https://news.social-protocols.org/stats?id=47865838) #8 24 points 6 comments -> [The Tech Oligarch's Republic](https://www.forever-wars.com/the-tech-oligarchs-republic/)<!-- HN:47865838:end --><!-- HN:47870528:start -->
* [47870528](https://news.social-protocols.org/stats?id=47870528) #18 5 points 0 comments -> [Islam Is Not the Cause of Honor Killings. It's Part of the Solution](https://yaqeeninstitute.org/read/paper/islam-is-not-the-cause-of-honor-killings-its-part-of-the-solution)<!-- HN:47870528:end -->
#### **Thursday, April 23, 2026**
<!-- HN:47872008:start -->
* [47872008](https://news.social-protocols.org/stats?id=47872008) #3 52 points 21 comments -> [It's time to reclaim the word "Palantir" for JRR Tolkien](https://www.zig.art/p/its-time-to-reclaim-the-word-palantir)<!-- HN:47872008:end --><!-- HN:47873517:start -->
* [47873517](https://news.social-protocols.org/stats?id=47873517) #13 6 points 2 comments -> [Former Israeli intelligence agents from Unit 8200 hired by Apple](https://vuseum.wordpress.com/2025/07/22/ex-spie-israeliane-dellunita-8200-assunte-da-apple/)<!-- HN:47873517:end --><!-- HN:47873646:start -->
* [47873646](https://news.social-protocols.org/stats?id=47873646) #22 15 points 0 comments -> [FIU Student Arrested After Joking About Netanyahu on WhatsApp](https://www.youtube.com/watch?v=o1Zsb1IijYY)<!-- HN:47873646:end --><!-- HN:47874673:start -->
* [47874673](https://news.social-protocols.org/stats?id=47874673) #30 5 points 0 comments -> [The Demonization of Male Ambition – Lisa Britton](https://lisabritton.substack.com/p/the-demonization-of-male-ambition)<!-- HN:47874673:end --><!-- HN:47876365:start -->
* [47876365](https://news.social-protocols.org/stats?id=47876365) #6 10 points 0 comments -> [I checked 506 citations from ChatGPT,Claude, Gemini Deep Research- 36% are wrong](https://spineframe.xyz/blog)<!-- HN:47876365:end --><!-- HN:47876282:start -->
* [47876282](https://news.social-protocols.org/stats?id=47876282) #11 7 points 2 comments -> [Be sinceerly human – AI to undo your AI writing](https://sinceerly.com/)<!-- HN:47876282:end -->
#### **Friday, April 24, 2026**
<!-- HN:47883205:start -->
* [47883205](https://news.social-protocols.org/stats?id=47883205) #19 4 points 0 comments -> [How tolls saved Britain from pothole hell in the Industrial Revolution](https://www.cam.ac.uk/stories/fixing-the-roads-turnpikes)<!-- HN:47883205:end --><!-- HN:47885014:start -->
* [47885014](https://news.social-protocols.org/stats?id=47885014) #29 146 points 14 comments -> [DeepSeek-V4: Towards Highly Efficient Million-Token Context Intelligence](https://huggingface.co/deepseek-ai/DeepSeek-V4-Pro)<!-- HN:47885014:end --><!-- HN:47888159:start -->
* [47888159](https://news.social-protocols.org/stats?id=47888159) #15 2 points 1 comments -> [Wisp – Social that's fun again](https://wisp.mobile)<!-- HN:47888159:end --><!-- HN:47889664:start -->
* [47889664](https://news.social-protocols.org/stats?id=47889664) #22 18 points 1 comments -> [The Era of Citizens United Could Be Nearing Its End](https://jacobin.com/2026/04/citizens-united-electoral-corruption-case)<!-- HN:47889664:end --><!-- HN:47890319:start -->
* [47890319](https://news.social-protocols.org/stats?id=47890319) #23 16 points 3 comments -> [Iran War Has Drained U.S. Supplies of Critical, Costly Weapons](https://www.nytimes.com/2026/04/23/us/politics/iran-war-cost-military.html)<!-- HN:47890319:end --><!-- HN:47888557:start -->
* [47888557](https://news.social-protocols.org/stats?id=47888557) #5 183 points 68 comments -> [UK Biobank leak: Health details of 500 000 people are offered for sale](https://www.bmj.com/content/393/bmj.s781)<!-- HN:47888557:end --><!-- HN:47891260:start -->
* [47891260](https://news.social-protocols.org/stats?id=47891260) #23 23 points 3 comments -> [AI as a Fascist Artifact](https://tante.cc/2026/04/21/ai-as-a-fascist-artifact/)<!-- HN:47891260:end --><!-- HN:47890365:start -->
* [47890365](https://news.social-protocols.org/stats?id=47890365) #25 37 points 40 comments -> [Linux 7.1 Removes Drivers for Bus Mouse Support](https://www.phoronix.com/news/Linux-7.1-Input)<!-- HN:47890365:end --><!-- HN:47893541:start -->
* [47893541](https://news.social-protocols.org/stats?id=47893541) #6 9 points 4 comments -> [Microsoft OpenClaw](https://github.com/microsoft/openclaw)<!-- HN:47893541:end --><!-- HN:47895080:start -->
* [47895080](https://news.social-protocols.org/stats?id=47895080) #1 200 points 106 comments -> [Google to invest up to $40B in Anthropic in cash and compute](https://techcrunch.com/2026/04/24/google-to-invest-up-to-40b-in-anthropic-in-cash-and-compute/)<!-- HN:47895080:end --><!-- HN:47894129:start -->
* [47894129](https://news.social-protocols.org/stats?id=47894129) #16 48 points 24 comments -> [Google investing up to $40B in Anthropic](https://www.wsj.com/finance/investing/google-expands-anthropic-investment-with-40-billion-commitment-99b4de74)<!-- HN:47894129:end --><!-- HN:47862870:start -->
* [47862870](https://news.social-protocols.org/stats?id=47862870) #12 19 points 0 comments -> [The SPLC indictment, the Klan history behind it, and ignominy of Todd Blanche](https://www.lawdork.com/p/splc-indictment-united-klans-of-america)<!-- HN:47862870:end -->
#### **Saturday, April 25, 2026**
<!-- HN:47898744:start -->
* [47898744](https://news.social-protocols.org/stats?id=47898744) #1 27 points 1 comments -> [Do I belong in tech anymore?](https://ky.fyi/posts/ai-burnout)<!-- HN:47898744:end --><!-- HN:47901993:start -->
* [47901993](https://news.social-protocols.org/stats?id=47901993) #18 16 points 41 comments -> [UK to permanently ban future generations from buying cigarettes](https://nypost.com/2026/04/21/world-news/uk-to-permanently-ban-future-generations-from-buying-cigarettes/)<!-- HN:47901993:end --><!-- HN:47903737:start -->
* [47903737](https://news.social-protocols.org/stats?id=47903737) #12 10 points 3 comments -> [IPv7: Identity-Centric Network Protocol – IETF Draft and Rust Implementation](https://datatracker.ietf.org/doc/draft-subbiah-ipv7/)<!-- HN:47903737:end -->
#### **Sunday, April 26, 2026**
<!-- HN:47906937:start -->
* [47906937](https://news.social-protocols.org/stats?id=47906937) #23 6 points 0 comments -> [The death of the American Dream is now official](https://thehill.com/opinion/finance/5846892-american-dream-debt-crisis/)<!-- HN:47906937:end --><!-- HN:47841141:start -->
* [47841141](https://news.social-protocols.org/stats?id=47841141) #28 116 points 20 comments -> [Desmond Morris has died](https://www.bbc.com/news/articles/c51y797v200o)<!-- HN:47841141:end --><!-- HN:47907205:start -->
* [47907205](https://news.social-protocols.org/stats?id=47907205) #21 15 points 2 comments -> [A Home Made PBX](https://wandel.ca/homepage/pbx.html)<!-- HN:47907205:end --><!-- HN:47909942:start -->
* [47909942](https://news.social-protocols.org/stats?id=47909942) #12 95 points 65 comments -> [At least 10 people tied to sensitive US research have died or disappeared](https://www.cnn.com/2026/04/21/us/deaths-disappearances-scientists-investigation)<!-- HN:47909942:end --><!-- HN:47914215:start -->
* [47914215](https://news.social-protocols.org/stats?id=47914215) #4 13 points 12 comments -> [Let's Quit Open Source and go for Human Source (HSL 0.2)](https://github.com/xdgrulez/human-source-license)<!-- HN:47914215:end -->