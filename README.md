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

#### **Sunday, November 22, 2026**
<!-- HN:50595122:start -->
* [50595122](https://news.social-protocols.org/stats?id=50595122) #4 9 points 1 comments -> [(Supposed) ex-Rockstar employee: GTAVI creates psychological profiles, sells it](https://www.resetera.com/threads/supposed-ex-rockstar-employee-gtavi-creates-personality-profiles-based-on-gameplay-decisions-sells-them-to-outside-companies.1694417/)<!-- HN:50595122:end --><!-- HN:50595256:start -->
* [50595256](https://news.social-protocols.org/stats?id=50595256) #10 14 points 3 comments -> [Supposed Fired Rockstar Engineer Says GTAVI Makes Psychological Profiles](https://www.gadgetreview.com/man-claiming-to-be-fired-rockstar-engineer-says-gta-6-is-secretly-tracking-player-behavior-and-reporting-it-to-take-two)<!-- HN:50595256:end --><!-- HN:50595725:start -->
* [50595725](https://news.social-protocols.org/stats?id=50595725) #13 22 points 40 comments -> [The Most Popular Car Colors in America](https://www.iseecars.com/most-popular-car-colors-study)<!-- HN:50595725:end --><!-- HN:50596511:start -->
* [50596511](https://news.social-protocols.org/stats?id=50596511) #3 74 points 14 comments -> [AI Supply Chain Security: What Canary Tokens Found](https://www.dragos.com/blog/ai-supply-chain-security-canary-tokens)<!-- HN:50596511:end --><!-- HN:50533945:start -->
* [50533945](https://news.social-protocols.org/stats?id=50533945) #4 203 points 63 comments -> [A real Linux kernel, compiled to WebAssembly](https://github.com/pithings/unkernel)<!-- HN:50533945:end --><!-- HN:50604742:start -->
* [50604742](https://news.social-protocols.org/stats?id=50604742) #16 25 points 4 comments -> [Invalidity of the Alpoge Proposed Proof of the Riemann Hypothesis](https://philpapers.org/rec/NIEIOT-2)<!-- HN:50604742:end --><!-- HN:50604959:start -->
* [50604959](https://news.social-protocols.org/stats?id=50604959) #19 35 points 35 comments -> [Do Not Accept](https://donotaccept.ai/)<!-- HN:50604959:end -->
#### **Monday, November 23, 2026**
<!-- HN:50607591:start -->
* [50607591](https://news.social-protocols.org/stats?id=50607591) #10 8 points 3 comments -> [Mass destruction of weapons](https://computer.rip/2026-11-22-mass-destruction-of-weapons.html)<!-- HN:50607591:end --><!-- HN:50609079:start -->
* [50609079](https://news.social-protocols.org/stats?id=50609079) #11 88 points 48 comments -> [GTA 6 building personal behavioral profile for every player](https://huijzer.xyz/posts/174/gta-6-building-personal-behavioral-profile-for-eve)<!-- HN:50609079:end --><!-- HN:50610073:start -->
* [50610073](https://news.social-protocols.org/stats?id=50610073) #19 8 points 1 comments -> [China's prison for the elite is massively expanding](https://www.economist.com/china/2026/11/19/chinas-prison-for-the-elite-is-massively-expanding)<!-- HN:50610073:end --><!-- HN:50611588:start -->
* [50611588](https://news.social-protocols.org/stats?id=50611588) #1 1637 points 1390 comments -> [Jensen Huang Reinstated as Nvidia CEO](https://nvidianews.nvidia.com/news/nvidia-board-reinstates-jensen-huang-as-president-ceo-and-board-director)<!-- HN:50611588:end --><!-- HN:50616947:start -->
* [50616947](https://news.social-protocols.org/stats?id=50616947) #30 33 points 15 comments -> [Iranian authorities flog singer who performed without hijab, lawyers say](https://www.bbc.com/news/articles/cq1j6585l5g6o)<!-- HN:50616947:end --><!-- HN:50618490:start -->
* [50618490](https://news.social-protocols.org/stats?id=50618490) #12 48 points 29 comments -> [Congress shreds Nvidia's 'outrageous' return of Huang: 'Failure of character'](https://www.cnbc.com/2026/11/23/nvidia-jensen-huang-congress-trump.html)<!-- HN:50618490:end --><!-- HN:50620252:start -->
* [50620252](https://news.social-protocols.org/stats?id=50620252) #4 23 points 2 comments -> [VP != VNP over Every Field [pdf]](https://github.com/anthropics/formal-math/blob/11b6c7e3c927df2658f513b6b68ea7f8929c62c5/vp-vnp/paper.pdf)<!-- HN:50620252:end -->
#### **Tuesday, November 24, 2026**
<!-- HN:50623166:start -->
* [50623166](https://news.social-protocols.org/stats?id=50623166) #24 6 points 2 comments -> [Zero data retention with Enterprise Frontier Safeguards is now in beta](https://claude.com/resources/articles/zero-data-retention-with-enterprise-frontier-safeguards)<!-- HN:50623166:end --><!-- HN:50622769:start -->
* [50622769](https://news.social-protocols.org/stats?id=50622769) #1 129 points 36 comments -> [New York Bans Subscription and Post-Purchase Fees on Cars](https://wgna.com/car-bill-extra-fees/)<!-- HN:50622769:end --><!-- HN:50623175:start -->
* [50623175](https://news.social-protocols.org/stats?id=50623175) #30 9 points 0 comments -> [Show HN: Juncts, one DM inbox for five apps that Claude and ChatGPT can work in](https://juncts.com/app?demo=1&utm_source=hackernews&utm_medium=launch&utm_campaign=launch-nov26)<!-- HN:50623175:end --><!-- HN:50623812:start -->
* [50623812](https://news.social-protocols.org/stats?id=50623812) #24 4 points 2 comments -> [Online Backrooms](https://onlinebackrooms.com/)<!-- HN:50623812:end --><!-- HN:50624929:start -->
* [50624929](https://news.social-protocols.org/stats?id=50624929) #2 22 points 5 comments -> [VP ≠ VNP over Every Field [pdf]](https://github.com/anthropics/formal-math/blob/vp-vnp/vp-vnp/paper.pdf)<!-- HN:50624929:end --><!-- HN:50593006:start -->
* [50593006](https://news.social-protocols.org/stats?id=50593006) #29 34 points 13 comments -> [Ride the SQL curve from basics to mastery](https://sqlride.com/)<!-- HN:50593006:end --><!-- HN:50626012:start -->
* [50626012](https://news.social-protocols.org/stats?id=50626012) #17 18 points 8 comments -> [Google Chrome dev team declares bug report bankruptcy](https://blog.plover.com/2026/11/18/#bug-reports)<!-- HN:50626012:end --><!-- HN:50626578:start -->
* [50626578](https://news.social-protocols.org/stats?id=50626578) #15 433 points 248 comments -> [Investigation of Polymarket Insider Trading on the Reinstatement of Jensen Huang](https://deucalionn.vercel.app/polymarket-delit-initie-jensen-huang-nvidia/)<!-- HN:50626578:end --><!-- HN:50629289:start -->
* [50629289](https://news.social-protocols.org/stats?id=50629289) #21 9 points 2 comments -> [Ladybird Is Freakin' Awesome](https://dbushell.com/2026/11/24/ladybird-is-freakin-awesome/)<!-- HN:50629289:end --><!-- HN:50629413:start -->
* [50629413](https://news.social-protocols.org/stats?id=50629413) #15 18 points 1 comments -> [Anthropic falls below $83 IPO price in Swift reversal after record listing](https://www.reuters.com/business/anthropic-breaks-below-83-ipo-price-debut-rally-unravels-2026-11-24/)<!-- HN:50629413:end --><!-- HN:50631647:start -->
* [50631647](https://news.social-protocols.org/stats?id=50631647) #27 -> [Enron Employees Give Kenneth Lay a Standing Ovation Upon His Return as CEO](https://daringfireball.net/linked/2026/11/24/enron-ovation-1991)<!-- HN:50631647:end --><!-- HN:50630122:start -->
* [50630122](https://news.social-protocols.org/stats?id=50630122) #28 -> [Millions of bitcoin are probably lost for good. Almost none can be proved gone](https://blog.everstrike.io/lost-bitcoin/)<!-- HN:50630122:end --><!-- HN:50631900:start -->
* [50631900](https://news.social-protocols.org/stats?id=50631900) #16 12 points 15 comments -> [AstridVPN: A VPN that doesn't know who you are](https://astridvpn.com/)<!-- HN:50631900:end --><!-- HN:50632804:start -->
* [50632804](https://news.social-protocols.org/stats?id=50632804) #22 6 points 0 comments -> [Iran's quest for its own Monroe Doctrine](https://engelsbergideas.com/notebook/irans-quest-for-its-own-monroe-doctrine/)<!-- HN:50632804:end --><!-- HN:50635941:start -->
* [50635941](https://news.social-protocols.org/stats?id=50635941) #16 26 points 18 comments -> [Jensen Huang Spy Story Is a Hoax](https://www.kenklippenstein.com/p/jensen-huang-spy-story-is-a-hoax)<!-- HN:50635941:end -->
#### **Wednesday, November 25, 2026**
<!-- HN:50638811:start -->
* [50638811](https://news.social-protocols.org/stats?id=50638811) #16 8 points 2 comments -> [Invisible Wave Hits California, Oregon and Canada as Towns Evacuate](https://www.abovethenormnews.com/2026/11/24/king-tides-california/)<!-- HN:50638811:end --><!-- HN:50638523:start -->
* [50638523](https://news.social-protocols.org/stats?id=50638523) #29 21 points 4 comments -> [Show HN: U.S. Interstate Weather](https://www.interstateweather.com/)<!-- HN:50638523:end --><!-- HN:50608973:start -->
* [50608973](https://news.social-protocols.org/stats?id=50608973) #11 9 points 6 comments -> [Why Airlines Accept A321XLR's Heavier Takeoff Weight on Flights Shorter &lt; 1 Hour](https://simpleflying.com/airlines-accept-airbus-a321xlr-heavier-101-tonne-maximum-takeoff-weight-flights-shorter-hour/)<!-- HN:50608973:end --><!-- HN:50640746:start -->
* [50640746](https://news.social-protocols.org/stats?id=50640746) #17 36 points 8 comments -> [The Riemann Hypothesis Proof as a Mediaeval Fantasy RPG Map](https://marioschlosser.org/riemann/)<!-- HN:50640746:end --><!-- HN:50641836:start -->
* [50641836](https://news.social-protocols.org/stats?id=50641836) #2 -> [SSH Is the Most Underrated Platform in Tech](https://milkcrunch.com/ssh-is-a-platform/)<!-- HN:50641836:end --><!-- HN:50644162:start -->
* [50644162](https://news.social-protocols.org/stats?id=50644162) #9 30 points 8 comments -> [Anthropic migrated Messages API to Rust with no Rust developers](https://www.anthropic.com/research/migrating-api-to-rust)<!-- HN:50644162:end --><!-- HN:50646781:start -->
* [50646781](https://news.social-protocols.org/stats?id=50646781) #11 9 points 2 comments -> [Invalidity of the Alpoge Proposed Proof of the Riemann Hypothesis](https://philpapers.org/rec/NIEIOT-2)<!-- HN:50646781:end --><!-- HN:50647895:start -->
* [50647895](https://news.social-protocols.org/stats?id=50647895) #9 9 points 1 comments -> [Invalidity of the Alpoge Proposed Proof of the Riemann Hypothesis](https://philpapers.org/rec/NIEIOT-2)<!-- HN:50647895:end -->
#### **Thursday, November 26, 2026**
<!-- HN:50615059:start -->
* [50615059](https://news.social-protocols.org/stats?id=50615059) #18 20 points 5 comments -> [Who is in charge of Britain's web addresses?](https://medium.com/@jharbourne/who-is-in-charge-of-britains-web-addresses-6efc797bc133)<!-- HN:50615059:end --><!-- HN:50654354:start -->
* [50654354](https://news.social-protocols.org/stats?id=50654354) #4 7 points 3 comments -> [Samsung TV has 650 free channels behind one button most owners never press](https://www.makeuseof.com/samsung-tv-plus/)<!-- HN:50654354:end --><!-- HN:50654863:start -->
* [50654863](https://news.social-protocols.org/stats?id=50654863) #7 3 points 1 comments -> [What broke in 27 days of running a team of AI agents on real work](https://ethanflow.com/writing/what-broke-ai-agent-team/)<!-- HN:50654863:end --><!-- HN:50654669:start -->
* [50654669](https://news.social-protocols.org/stats?id=50654669) #30 3 points 0 comments -> [What if everyone had a wealth manager?](https://christian-tonny.dev/money)<!-- HN:50654669:end -->
#### **Friday, November 27, 2026**
<!-- HN:50662217:start -->
* [50662217](https://news.social-protocols.org/stats?id=50662217) #8 9 points 1 comments -> [Show HN: Sqrin – A better screen share for Mac](https://sqrin.app)<!-- HN:50662217:end --><!-- HN:50662153:start -->
* [50662153](https://news.social-protocols.org/stats?id=50662153) #8 24 points 9 comments -> [New AI research suggests AI bubble bursting and to expect major market collapse](https://www.london.edu/think/ai-bubble-about-to-burst)<!-- HN:50662153:end --><!-- HN:50664885:start -->
* [50664885](https://news.social-protocols.org/stats?id=50664885) #14 34 points 40 comments -> ['Cyber incident' forces UK Gov to take some services offline](https://www.bbc.co.uk/news/live/c6rrg94lgjrjt)<!-- HN:50664885:end --><!-- HN:50667025:start -->
* [50667025](https://news.social-protocols.org/stats?id=50667025) #21 11 points 5 comments -> [Weird Little Guys of FOSS (a.k.a. the Fourth Reich of FOSS)](https://drewdevault.com/weird-guys/)<!-- HN:50667025:end --><!-- HN:50667970:start -->
* [50667970](https://news.social-protocols.org/stats?id=50667970) #7 14 points 2 comments -> [Grand Theft GTA](https://grandtheftgta.com/)<!-- HN:50667970:end --><!-- HN:50668828:start -->
* [50668828](https://news.social-protocols.org/stats?id=50668828) #26 6 points 9 comments -> [Nvidia CEO's comeback fuels debate on misogyny or impunity for rich and powerful](https://www.pbs.org/newshour/nation/nvidia-ceos-comeback-fuels-debate-over-misogyny-and-impunity-for-the-rich-and-powerful)<!-- HN:50668828:end --><!-- HN:50669137:start -->
* [50669137](https://news.social-protocols.org/stats?id=50669137) #22 26 points 2 comments -> [Why is Hacker News like that?](https://drewdevault.com/blog/Why-is-HN-like-that/#)<!-- HN:50669137:end --><!-- HN:50666487:start -->
* [50666487](https://news.social-protocols.org/stats?id=50666487) #30 58 points 22 comments -> [She Reported Her Sexual Assault. The Marine Corps Kicked Her Out](https://thewarhorse.org/marine-corps-administrative-separation-after-sexual-assault/)<!-- HN:50666487:end --><!-- HN:50669280:start -->
* [50669280](https://news.social-protocols.org/stats?id=50669280) #21 24 points 41 comments -> [France Slips into Recession as Exports Sag](https://www.wsj.com/world/europe/french-economy-slips-into-recession-as-exports-sag-47e934c5)<!-- HN:50669280:end --><!-- HN:50667744:start -->
* [50667744](https://news.social-protocols.org/stats?id=50667744) #5 163 points 66 comments -> [GPT 6.2 Astra Solves a Historical Mystery](https://generativehistory.substack.com/p/gpt-62-astra-solves-a-historical)<!-- HN:50667744:end --><!-- HN:50670517:start -->
* [50670517](https://news.social-protocols.org/stats?id=50670517) #11 7 points 4 comments -> [I'm a watchmaker and I accidentally made a software factory](https://opentimegrapher.org/blog/2026-11-27-coordinators-chair-1/)<!-- HN:50670517:end --><!-- HN:50672734:start -->
* [50672734](https://news.social-protocols.org/stats?id=50672734) #25 9 points 0 comments -> [Documents expose Israel's state-funded propaganda network](https://www.972mag.com/voices-of-israel-documents-propaganda-network/)<!-- HN:50672734:end -->
#### **Saturday, November 28, 2026**
<!-- HN:50672829:start -->
* [50672829](https://news.social-protocols.org/stats?id=50672829) #22 14 points 5 comments -> [Painting 1990s anime scenes in Python](https://www.fofr.ai/greenhouse-after-the-typhoon)<!-- HN:50672829:end --><!-- HN:50676532:start -->
* [50676532](https://news.social-protocols.org/stats?id=50676532) #5 5 points 0 comments -> [No perfect way to find the love of your life](https://yappings.mikeluu.xyz/blogs/the-perfect-partner)<!-- HN:50676532:end --><!-- HN:50677014:start -->
* [50677014](https://news.social-protocols.org/stats?id=50677014) #18 13 points 4 comments -> [AnthropicAI posted a fraudulent proof of RH](https://twitter.com/QualiaQuanta/status/2126158001035768256)<!-- HN:50677014:end -->