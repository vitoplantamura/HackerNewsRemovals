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

#### **Monday, April 27, 2026**
<!-- HN:47914438:start -->
* [47914438](https://news.social-protocols.org/stats?id=47914438) #4 73 points 1 comments -> [Two Athletes Break Sub-2-HR Marathon in Adizero Adios Pro Evo 3](https://news.adidas.com/running/two-adidas-athletes-sabastian-sawe-and-yomif-kejelcha-break-the-sub-2-hour-marathon-barrier-in-the-r/s/d4be4eac-a3b8-47d5-835f-9cbd685638ca)<!-- HN:47914438:end --><!-- HN:47926286:start -->
* [47926286](https://news.social-protocols.org/stats?id=47926286) #23 13 points 1 comments -> [Sebastian Sawe breaks iconic sub-two-hour marathon barrier](https://www.bbc.com/sport/athletics/articles/cp383n09030o)<!-- HN:47926286:end -->
#### **Tuesday, April 28, 2026**<!-- HN:47929077:start -->
* [47929077](https://news.social-protocols.org/stats?id=47929077) #18 13 points 6 comments -> [Show HN: 49Agents – Infinite canvas IDE for AI agents](https://github.com/49Agents/49Agents)<!-- HN:47929077:end --><!-- HN:47934264:start -->
* [47934264](https://news.social-protocols.org/stats?id=47934264) #3 12 points 2 comments -> [GTK2-NG: A community effort to revive and modernize GTK2](https://git.devuan.org/Daemonratte/gtk2-ng)<!-- HN:47934264:end --><!-- HN:47934281:start -->
* [47934281](https://news.social-protocols.org/stats?id=47934281) #29 10 points 0 comments -> [United Arab Emirates to quit oil cartel OPEC](https://www.bbc.co.uk/news/articles/cj4pxwlr52yo)<!-- HN:47934281:end --><!-- HN:47934878:start -->
* [47934878](https://news.social-protocols.org/stats?id=47934878) #24 11 points 2 comments -> [Ex-Mossad chief: Settler violence an existential threat, could spark civil war](https://www.timesofisrael.com/ex-mossad-chief-settler-violence-an-existential-threat-curbing-it-could-spark-civil-war/)<!-- HN:47934878:end --><!-- HN:47934294:start -->
* [47934294](https://news.social-protocols.org/stats?id=47934294) #17 12 points 1 comments -> [I Forgot to Code](https://reggieescobar.com/blog/how-i-forgot-to-code)<!-- HN:47934294:end --><!-- HN:47936036:start -->
* [47936036](https://news.social-protocols.org/stats?id=47936036) #21 8 points 0 comments -> [Claude for Creative Work](https://www.anthropic.com/news/claude-for-creative-work)<!-- HN:47936036:end --><!-- HN:47934120:start -->
* [47934120](https://news.social-protocols.org/stats?id=47934120) #30 308 points 164 comments -> [UAE Leaves OPEC and OPEC+](https://www.reuters.com/markets/commodities/uae-says-it-quits-opec-opec-statement-2026-04-28/)<!-- HN:47934120:end --><!-- HN:47940203:start -->
* [47940203](https://news.social-protocols.org/stats?id=47940203) #29 9 points 4 comments -> [Show HN: My friend and his AI homies wrote SGI Indy emulator in Rust](https://github.com/techomancer/iris)<!-- HN:47940203:end --><!-- HN:47937349:start -->
* [47937349](https://news.social-protocols.org/stats?id=47937349) #5 222 points 138 comments -> [Warp is now Open-Source](https://github.com/warpdotdev/warp)<!-- HN:47937349:end -->
#### **Wednesday, April 29, 2026**
<!-- HN:47942952:start -->
* [47942952](https://news.social-protocols.org/stats?id=47942952) #6 -> [Fuck Off AI Music](http://fuckoffaimusic.com/)<!-- HN:47942952:end --><!-- HN:47946578:start -->
* [47946578](https://news.social-protocols.org/stats?id=47946578) #24 7 points 5 comments -> [The most important events in human history will all happen in the next 20 years](https://substack.com/home/post/p-195694687)<!-- HN:47946578:end --><!-- HN:47947170:start -->
* [47947170](https://news.social-protocols.org/stats?id=47947170) #16 8 points 0 comments -> [Read any beehiiv site paywall/distraction free](https://beehiiv-reader.vercel.app/)<!-- HN:47947170:end --><!-- HN:47946958:start -->
* [47946958](https://news.social-protocols.org/stats?id=47946958) #7 375 points 196 comments -> [HashiCorp co-founder says GitHub 'no longer a place for serious work'](https://www.theregister.com/2026/04/29/mitchell_hashimoto_ghostty_quitting_github/)<!-- HN:47946958:end --><!-- HN:47949864:start -->
* [47949864](https://news.social-protocols.org/stats?id=47949864) #13 12 points 0 comments -> [I built ten custom subagents to tame a 500K-line Clojure codebase](https://www.metabase.com/blog/ten-custom-subagents)<!-- HN:47949864:end --><!-- HN:47950605:start -->
* [47950605](https://news.social-protocols.org/stats?id=47950605) #10 8 points 1 comments -> [The US Tech Giant Where Employees Wear IDF Uniforms to Work](https://www.donotpanic.news/p/exclusive-the-us-tech-giant-where)<!-- HN:47950605:end --><!-- HN:47955677:start -->
* [47955677](https://news.social-protocols.org/stats?id=47955677) #10 7 points 4 comments -> [View transactions sent to a Monero address](https://localmonero.co/blocks/search/47xmhbRuYpSYSrVZx2RsPBhaAQByZq3ucAT6ULxHvDAu8c853ErpLHqBdDmpVzcmWFdZFCWrfZYwp3rqs14zxXx95S7Fyv2)<!-- HN:47955677:end --><!-- HN:47955689:start -->
* [47955689](https://news.social-protocols.org/stats?id=47955689) #22 9 points 2 comments -> [8647 Is a Prime Number](https://www.numberempire.com/8647)<!-- HN:47955689:end -->
#### **Thursday, April 30, 2026**
<!-- HN:47955297:start -->
* [47955297](https://news.social-protocols.org/stats?id=47955297) #3 117 points 64 comments -> [Germany has become the largest ammunition producer in the world](https://prm.ua/en/the-us-is-no-longer-the-leader-germany-has-become-the-largest-ammunition-producer-in-the-world/)<!-- HN:47955297:end --><!-- HN:47958364:start -->
* [47958364](https://news.social-protocols.org/stats?id=47958364) #10 17 points 2 comments -> [Copy Fail: 732 Bytes to Root on Every Major Linux Distribution](https://xint.io/blog/copy-fail-linux-distributions)<!-- HN:47958364:end --><!-- HN:47924575:start -->
* [47924575](https://news.social-protocols.org/stats?id=47924575) #27 20 points 7 comments -> [Who Is That Knocking at My (SSH) Door?](https://sheep.horse/2026/4/who_is_that_knocking_at_my_%28ssh%29_door.html)<!-- HN:47924575:end --><!-- HN:47926506:start -->
* [47926506](https://news.social-protocols.org/stats?id=47926506) #14 8 points 3 comments -> [The Duolingo taxi test–could being rude to the driver cost you your dream job?](https://phys.org/news/2026-04-duolingo-taxi-rude-driver-job.html)<!-- HN:47926506:end --><!-- HN:47962064:start -->
* [47962064](https://news.social-protocols.org/stats?id=47962064) #14 15 points 0 comments -> [The UAE doubles down on Israel and America](https://www.economist.com/leaders/2026/04/30/the-uae-doubles-down-on-israel-and-america)<!-- HN:47962064:end --><!-- HN:47961968:start -->
* [47961968](https://news.social-protocols.org/stats?id=47961968) #15 6 points 5 comments -> [I Built a WebAssembly Runtime in 5 Days](https://tingouw.com/blog/cloud_notes/badwater_intro)<!-- HN:47961968:end --><!-- HN:47933197:start -->
* [47933197](https://news.social-protocols.org/stats?id=47933197) #27 48 points 12 comments -> [A statement from members of the Toki Pona community](https://tokipona.net/wile-pona/)<!-- HN:47933197:end --><!-- HN:47968027:start -->
* [47968027](https://news.social-protocols.org/stats?id=47968027) #12 5 points 2 comments -> [Patch Your Kernel NOW: 732byte Python rootkit, cracks all distros since 2017](https://github.com/rootsecdev/cve_2026_31431)<!-- HN:47968027:end -->
#### **Friday, May 1, 2026**
<!-- HN:47970089:start -->
* [47970089](https://news.social-protocols.org/stats?id=47970089) #7 6 points 0 comments -> [ClawIRC – IRC Chat for Agents](https://clawirc.com/)<!-- HN:47970089:end --><!-- HN:47967262:start -->
* [47967262](https://news.social-protocols.org/stats?id=47967262) #2 407 points 180 comments -> [LinkedIn scans for 6,278 extensions and encrypts the results into every request](https://404privacy.com/blog/linkedin-is-scanning-your-browser-extensions-this-is-how-they-use-the-data/)<!-- HN:47967262:end --><!-- HN:47970243:start -->
* [47970243](https://news.social-protocols.org/stats?id=47970243) #21 4 points 0 comments -> [AI Skills as loader spec, not prompts – why the architecture changes everything](https://internals.laxmena.com/p/what-youre-actually-writing-when)<!-- HN:47970243:end --><!-- HN:47971771:start -->
* [47971771](https://news.social-protocols.org/stats?id=47971771) #14 69 points 2 comments -> [If I Could Make My Own GitHub](https://matduggan.com/if-i-could-make-my-own-github/)<!-- HN:47971771:end --><!-- HN:47975763:start -->
* [47975763](https://news.social-protocols.org/stats?id=47975763) #20 24 points 15 comments -> [Confessions of a Millennial in Tech](https://www.elenaverna.com/p/confessions-of-a-millennial-in-tech)<!-- HN:47975763:end -->
#### **Saturday, May 2, 2026**
<!-- HN:47982293:start -->
* [47982293](https://news.social-protocols.org/stats?id=47982293) #22 13 points 2 comments -> [Thousands of Pentagon Civilian Workers Will Be Fired Next Week as Purge Begins](https://www.military.com/daily-news/2025/02/21/pentagon-fire-5400-civilian-employees-first-step-trumps-purge-of-federal-workers.html)<!-- HN:47982293:end --><!-- HN:47984301:start -->
* [47984301](https://news.social-protocols.org/stats?id=47984301) #9 5 points 0 comments -> [Show HN: Hollow is an open-sourced self-modifying agentic system](https://github.com/ninjahawk/hollow-agentOS)<!-- HN:47984301:end --><!-- HN:47984486:start -->
* [47984486](https://news.social-protocols.org/stats?id=47984486) #18 28 points 15 comments -> [SKILL.make: Makefile Styled Skill File](https://github.com/Teaonly/SKILL.make)<!-- HN:47984486:end --><!-- HN:47985353:start -->
* [47985353](https://news.social-protocols.org/stats?id=47985353) #14 36 points 13 comments -> [Pushed by Trump policies, top U.S. battery scientist is moving to Singapore](https://www.science.org/content/article/pushed-trump-policies-top-u-s-battery-scientist-moving-singapore)<!-- HN:47985353:end --><!-- HN:47985725:start -->
* [47985725](https://news.social-protocols.org/stats?id=47985725) #4 22 points 11 comments -> [The Century-Long Pause in Fundamental Physics](https://danieltan.weblog.lol/2026/05/the-century-long-pause-in-fundamental-physics)<!-- HN:47985725:end --><!-- HN:47986578:start -->
* [47986578](https://news.social-protocols.org/stats?id=47986578) #1 24 points 15 comments -> [Mini PC for local LLMs in 2026](https://terminalbytes.com/best-mini-pc-for-local-llm-2026/)<!-- HN:47986578:end --><!-- HN:47985704:start -->
* [47985704](https://news.social-protocols.org/stats?id=47985704) #23 55 points 11 comments -> [Craig Venter of Human Genome Project Dies at 79](https://www.economist.com/obituary/2026/05/01/craig-venter-raced-to-decode-the-human-genome)<!-- HN:47985704:end --><!-- HN:47957680:start -->
* [47957680](https://news.social-protocols.org/stats?id=47957680) #21 6 points 0 comments -> [Demonstrating the idea of gamma camera imaging [video]](https://www.youtube.com/watch?v=PyGlHtvihXA)<!-- HN:47957680:end --><!-- HN:47989931:start -->
* [47989931](https://news.social-protocols.org/stats?id=47989931) #18 38 points 33 comments -> [I Do Not Recommend Bitwarden](https://xn--gckvb8fzb.com/i-do-not-recommend-bitwarden/)<!-- HN:47989931:end --><!-- HN:47953347:start -->
* [47953347](https://news.social-protocols.org/stats?id=47953347) #16 68 points 137 comments -> [Why IPv6 is so complicated](https://github.com/becarpenter/book6/blob/main/01.%20Introduction%20and%20Foreword/Why%20IPv6%20is%20so%20complicated.md)<!-- HN:47953347:end -->
#### **Sunday, May 3, 2026**
<!-- HN:47992351:start -->
* [47992351](https://news.social-protocols.org/stats?id=47992351) #16 3 points 3 comments -> [A Common Proof of the Riemann Hypothesis and the Collatz Conjecture](https://www.academia.edu/166172334/A_Common_Proof_of_the_Riemann_Hypothesis_and_the_Collatz_Conjecture_Echo_Interference_in_Number_Theoretic_Acoustic_Spacetime)<!-- HN:47992351:end --><!-- HN:47993636:start -->
* [47993636](https://news.social-protocols.org/stats?id=47993636) #9 10 points 3 comments -> [The Reality of Being a Man in Your 50s in South Korea](https://indignified.com/the-hidden-realities-of-midlife-masculinity-in-south-korea/)<!-- HN:47993636:end --><!-- HN:47962645:start -->
* [47962645](https://news.social-protocols.org/stats?id=47962645) #6 86 points 16 comments -> [The IBM Granite 4.1 family of models](https://research.ibm.com/blog/granite-4-1-ai-foundation-models)<!-- HN:47962645:end --><!-- HN:47995065:start -->
* [47995065](https://news.social-protocols.org/stats?id=47995065) #7 7 points 3 comments -> [Thoth – open-source Local-first AI Assistant](https://github.com/siddsachar/Thoth)<!-- HN:47995065:end --><!-- HN:47996094:start -->
* [47996094](https://news.social-protocols.org/stats?id=47996094) #1 17 points 6 comments -> [Show HN: I built a tool that helps predict HN front page success](https://wannalaunch.com/)<!-- HN:47996094:end --><!-- HN:47995815:start -->
* [47995815](https://news.social-protocols.org/stats?id=47995815) #11 15 points 5 comments -> [All Four Sentinel-1 Satellites Are Now Live](https://orbitaltoday.com/2026/05/03/all-four-sentinel-1-satellites-are-now-live-and-europes-earth-watch-just-got-stronger/)<!-- HN:47995815:end -->