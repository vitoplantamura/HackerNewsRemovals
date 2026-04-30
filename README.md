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
* [47914215](https://news.social-protocols.org/stats?id=47914215) #4 13 points 12 comments -> [Let's Quit Open Source and go for Human Source (HSL 0.2)](https://github.com/xdgrulez/human-source-license)<!-- HN:47914215:end --><!-- HN:47914496:start -->
* [47914496](https://news.social-protocols.org/stats?id=47914496) #4 34 points 2 comments -> [1:59:30: Sabastian Sawe Shatters the 2-Hour Barrier at 2026 London Marathon](https://www.letsrun.com/news/2026/04/15930-sabastian-sawe-shatters-the-2-hour-barrier-at-2026-london-marathon/)<!-- HN:47914496:end -->
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
* [47950605](https://news.social-protocols.org/stats?id=47950605) #10 8 points 1 comments -> [The US Tech Giant Where Employees Wear IDF Uniforms to Work](https://www.donotpanic.news/p/exclusive-the-us-tech-giant-where)<!-- HN:47950605:end --><!-- HN:47952807:start -->
* [47952807](https://news.social-protocols.org/stats?id=47952807) #16 7 points 2 comments -> [The end of "Just ask Sarah"](https://simme.dev/posts/the-end-of-just-ask-sarah/)<!-- HN:47952807:end --><!-- HN:47955677:start -->
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
* [47933197](https://news.social-protocols.org/stats?id=47933197) #27 48 points 12 comments -> [A statement from members of the Toki Pona community](https://tokipona.net/wile-pona/)<!-- HN:47933197:end -->