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

#### **Friday, December 19, 2025**
<!-- HN:46319324:start -->
* [46319324](https://news.social-protocols.org/stats?id=46319324) #9 136 points 25 comments -> [AI Vending Machine Was Tricked into Giving Away Everything](https://kottke.org/25/12/this-ai-vending-machine-was-tricked-into-giving-away-everything)<!-- HN:46319324:end --><!-- HN:46287140:start -->
* [46287140](https://news.social-protocols.org/stats?id=46287140) #14 6 points 1 comments -> [C++ lowcode toolkit for ERP and Accounting Software](https://fin.in.net)<!-- HN:46287140:end --><!-- HN:46261844:start -->
* [46261844](https://news.social-protocols.org/stats?id=46261844) #23 6 points 1 comments -> [Startup Playbook](https://playbook.samaltman.com/)<!-- HN:46261844:end --><!-- HN:46329109:start -->
* [46329109](https://news.social-protocols.org/stats?id=46329109) #11 28 points 20 comments -> [Why we're taking legal action against SerpApi's unlawful scraping](https://blog.google/technology/safety-security/serpapi-lawsuit/)<!-- HN:46329109:end --><!-- HN:46327791:start -->
* [46327791](https://news.social-protocols.org/stats?id=46327791) #19 16 points 40 comments -> [AI will kill all the lawyers](https://spectator.com/article/ai-will-kill-all-the-lawyers/)<!-- HN:46327791:end --><!-- HN:46327325:start -->
* [46327325](https://news.social-protocols.org/stats?id=46327325) #6 164 points 104 comments -> [Cursor Acquires Graphite](https://graphite.com/blog/graphite-joins-cursor)<!-- HN:46327325:end --><!-- HN:46329729:start -->
* [46329729](https://news.social-protocols.org/stats?id=46329729) #16 5 points 4 comments -> [Your AI is lying to you.](https://WithTofu.com)<!-- HN:46329729:end --><!-- HN:46258377:start -->
* [46258377](https://news.social-protocols.org/stats?id=46258377) #22 37 points 40 comments -> [Does my key fob have more computing power than the Lunar lander?](https://www.buzzsprout.com/2469780/episodes/18340142-17-does-my-key-fob-have-more-computing-power-than-the-lunar-lander)<!-- HN:46258377:end --><!-- HN:46329530:start -->
* [46329530](https://news.social-protocols.org/stats?id=46329530) #6 40 points 1 comments -> [Performance Hints – Jeff Dean and Sanjay Ghemawat](https://abseil.io/fast/hints.html)<!-- HN:46329530:end -->
#### **Saturday, December 20, 2025**
<!-- HN:46332745:start -->
* [46332745](https://news.social-protocols.org/stats?id=46332745) #13 4 points 5 comments -> [The FOSS community acts like a cult and it's not helping the cause](https://torrent-empress.leaflet.pub/3mackqgyzh22t)<!-- HN:46332745:end --><!-- HN:46266915:start -->
* [46266915](https://news.social-protocols.org/stats?id=46266915) #21 13 points 0 comments -> [Language Immersion, Prison-Style (2017)](https://www.themarshallproject.org/2017/12/14/my-do-it-yourself-language-immersion-prison-style)<!-- HN:46266915:end --><!-- HN:46245904:start -->
* [46245904](https://news.social-protocols.org/stats?id=46245904) #27 5 points 0 comments -> [Finding Alignment by Visualizing Music in Rust](https://positron.solutions/articles/finding-alignment-by-visualizing-music)<!-- HN:46245904:end --><!-- HN:46251460:start -->
* [46251460](https://news.social-protocols.org/stats?id=46251460) #18 145 points 36 comments -> [Lite^3, a JSON-compatible zero-copy serialization format](https://github.com/fastserial/lite3)<!-- HN:46251460:end --><!-- HN:46270574:start -->
* [46270574](https://news.social-protocols.org/stats?id=46270574) #15 17 points 1 comments -> [Iberian peninsula is rotating clockwise](https://phys.org/news/2025-12-iberian-peninsula-rotating-clockwise-geodynamic.html)<!-- HN:46270574:end --><!-- HN:46336892:start -->
* [46336892](https://news.social-protocols.org/stats?id=46336892) #7 4 points 1 comments -> [DotMeow – A fun domain with a serious mission](https://www.dotmeow.org)<!-- HN:46336892:end --><!-- HN:46336792:start -->
* [46336792](https://news.social-protocols.org/stats?id=46336792) #15 4 points 0 comments -> [Trumps Biggest Failures 2025](https://asiaviewnews.com/gigabots/Threads?p=100049)<!-- HN:46336792:end --><!-- HN:46337026:start -->
* [46337026](https://news.social-protocols.org/stats?id=46337026) #6 6 points 2 comments -> [Brothers are taking down Claude Code with OSS CLI](https://github.com/blackboxaicode/cli)<!-- HN:46337026:end --><!-- HN:46339495:start -->
* [46339495](https://news.social-protocols.org/stats?id=46339495) #26 3 points 0 comments -> [Show HN: Fucking Websites](https://afw.kuber.studio)<!-- HN:46339495:end -->
#### **Sunday, December 21, 2025**
<!-- HN:46340192:start -->
* [46340192](https://news.social-protocols.org/stats?id=46340192) #13 31 points 9 comments -> [I wrote a code editor in C and now I'm a changed man](https://github.com/thisismars-x/light)<!-- HN:46340192:end --><!-- HN:46271844:start -->
* [46271844](https://news.social-protocols.org/stats?id=46271844) #28 19 points 26 comments -> [The Graffiti Question](https://www.guernicamag.com/the-graffiti-question/)<!-- HN:46271844:end --><!-- HN:46341035:start -->
* [46341035](https://news.social-protocols.org/stats?id=46341035) #14 19 points 13 comments -> [Humankind's 10 million year love affair with booze might end](https://www.economist.com/christmas-specials/2025/12/18/how-humankinds-10m-year-love-affair-with-booze-might-end)<!-- HN:46341035:end --><!-- HN:46343976:start -->
* [46343976](https://news.social-protocols.org/stats?id=46343976) #1 60 points 10 comments -> [ISBN Visualization Showing 99_959_000 books](https://annas-archive.li/isbn-visualization/)<!-- HN:46343976:end --><!-- HN:46345692:start -->
* [46345692](https://news.social-protocols.org/stats?id=46345692) #5 9 points 1 comments -> [RAG accuracy jumped from 10% to 60% when I added outcome scoring](https://roampal.ai/blog-ai-learns.html)<!-- HN:46345692:end --><!-- HN:46345000:start -->
* [46345000](https://news.social-protocols.org/stats?id=46345000) #15 38 points 13 comments -> [Mozilla right now (Digital Painting)](https://www.davidrevoy.com/article1108/mozilla-right-now)<!-- HN:46345000:end --><!-- HN:46286167:start -->
* [46286167](https://news.social-protocols.org/stats?id=46286167) #15 7 points 0 comments -> [A2UI: An Open Spec for Agent-Generated User Interfaces (Google)](https://developers.googleblog.com/introducing-a2ui-an-open-project-for-agent-driven-interfaces/)<!-- HN:46286167:end --><!-- HN:46348528:start -->
* [46348528](https://news.social-protocols.org/stats?id=46348528) #5 6 points 2 comments -> [Creators Turn Your Outrage into Their Paycheck](https://thebookofragebait.com/)<!-- HN:46348528:end --><!-- HN:46346796:start -->
* [46346796](https://news.social-protocols.org/stats?id=46346796) #2 496 points 173 comments -> [Logging Sucks](https://loggingsucks.com/)<!-- HN:46346796:end --><!-- HN:46348660:start -->
* [46348660](https://news.social-protocols.org/stats?id=46348660) #28 15 points 5 comments -> [Engineering dogmas it's time to retire – by Anton Zaides](https://newsletter.manager.dev/p/5-engineering-dogmas-its-time-to)<!-- HN:46348660:end -->
#### **Monday, December 22, 2025**<!-- HN:46285424:start -->
* [46285424](https://news.social-protocols.org/stats?id=46285424) #22 80 points 9 comments -> [Show HN: Autograd.c – a tiny ML framework built from scratch](https://github.com/sueszli/autograd.c)<!-- HN:46285424:end --><!-- HN:46352545:start -->
* [46352545](https://news.social-protocols.org/stats?id=46352545) #27 6 points 2 comments -> [Israel could be bringing back the death penalty – but only for Palestinians](https://www.cbc.ca/news/world/israel-gaza-palestinian-death-penalty-9.7019609)<!-- HN:46352545:end --><!-- HN:46313024:start -->
* [46313024](https://news.social-protocols.org/stats?id=46313024) #13 27 points 40 comments -> [Engineering dogmas it's time to retire](https://newsletter.manager.dev/p/5-engineering-dogmas-its-time-to)<!-- HN:46313024:end --><!-- HN:46289237:start -->
* [46289237](https://news.social-protocols.org/stats?id=46289237) #15 9 points 1 comments -> [Show HN: Jordle – Japanese Furigana Practice](https://jordle.io)<!-- HN:46289237:end --><!-- HN:46354117:start -->
* [46354117](https://news.social-protocols.org/stats?id=46354117) #27 5 points 1 comments -> [Republican made deepfake AI video of Democrat giving kid trans hormone therapy](https://www.youtube.com/watch?v=mxyC8StKRHE)<!-- HN:46354117:end --><!-- HN:46355227:start -->
* [46355227](https://news.social-protocols.org/stats?id=46355227) #23 25 points 18 comments -> [US Administration halted largest Offshore Wind project in the U.S.](https://www.cnbc.com/2025/12/22/trump-offshore-wind-cvow-dominion.html)<!-- HN:46355227:end --><!-- HN:46357227:start -->
* [46357227](https://news.social-protocols.org/stats?id=46357227) #30 5 points 0 comments -> [People Have Died in Crashes Where Tesla Doors Wouldn't Open](https://www.bloomberg.com/news/features/2025-12-22/tesla-door-safety-tied-to-at-least-15-auto-accident-deaths)<!-- HN:46357227:end --><!-- HN:46354773:start -->
* [46354773](https://news.social-protocols.org/stats?id=46354773) #28 28 points 40 comments -> [On the Existence, Impact, and Origin of Hallucination-Associated Neurons in LLMs](https://arxiv.org/abs/2512.01797)<!-- HN:46354773:end --><!-- HN:46356182:start -->
* [46356182](https://news.social-protocols.org/stats?id=46356182) #18 246 points 157 comments -> [Benn Jordan – This Flock Camera Leak Is Like Netflix for Stalkers [video]](https://www.youtube.com/watch?v=vU1-uiUlHTo)<!-- HN:46356182:end --><!-- HN:46286935:start -->
* [46286935](https://news.social-protocols.org/stats?id=46286935) #10 97 points 18 comments -> [Let's write a toy UI library](https://nakst.gitlab.io/tutorial/ui-part-1.html)<!-- HN:46286935:end --><!-- HN:46287464:start -->
* [46287464](https://news.social-protocols.org/stats?id=46287464) #13 14 points 2 comments -> [How do SSDs change database design?](https://brooker.co.za:443/blog/2025/12/15/database-for-ssd.html)<!-- HN:46287464:end --><!-- HN:46288042:start -->
* [46288042](https://news.social-protocols.org/stats?id=46288042) #23 126 points 79 comments -> [Microsoft will kill obsolete cipher that has wreaked decades of havoc](https://arstechnica.com/security/2025/12/microsoft-will-finally-kill-obsolete-cipher-that-has-wreaked-decades-of-havoc/)<!-- HN:46288042:end --><!-- HN:46290307:start -->
* [46290307](https://news.social-protocols.org/stats?id=46290307) #24 13 points 0 comments -> [Star Gauge: a Chinese reversible poem formed by a 29x29 grid of characters](https://en.wikipedia.org/wiki/Star_Gauge)<!-- HN:46290307:end --><!-- HN:46359396:start -->
* [46359396](https://news.social-protocols.org/stats?id=46359396) #14 37 points 16 comments -> [I'm tired of Hacker News slop](https://blog.absurdpirate.com/im-tired-of-hacker-news-slop/)<!-- HN:46359396:end --><!-- HN:46359515:start -->
* [46359515](https://news.social-protocols.org/stats?id=46359515) #13 19 points 10 comments -> [DOJ uploaded a 12-SEC video showing Epstein attempting suicide](https://twitter.com/rtwlz/status/2003211685650374823)<!-- HN:46359515:end --><!-- HN:46317166:start -->
* [46317166](https://news.social-protocols.org/stats?id=46317166) #16 9 points 5 comments -> [Show HN: It's Like Clay but in Google Sheets](https://www.getvurge.com/)<!-- HN:46317166:end -->
#### **Tuesday, December 23, 2025**
<!-- HN:46359923:start -->
* [46359923](https://news.social-protocols.org/stats?id=46359923) #25 3 points 0 comments -> [Fascintern Media](https://berjon.com/fascintern-media/)<!-- HN:46359923:end --><!-- HN:46361496:start -->
* [46361496](https://news.social-protocols.org/stats?id=46361496) #23 22 points 40 comments -> [NYC Spends $200 Million on Cell Service for School Chromebooks](https://nysfocus.com/2025/12/22/eric-adams-school-chromebooks-contract)<!-- HN:46361496:end --><!-- HN:46362531:start -->
* [46362531](https://news.social-protocols.org/stats?id=46362531) #28 11 points 4 comments -> [Spiked '60 Minutes' Segment Spreads Online](https://www.hollywoodreporter.com/tv/tv-news/spiked-60-minutes-segment-posted-online-airs-canada-1236457731/)<!-- HN:46362531:end --><!-- HN:46362882:start -->
* [46362882](https://news.social-protocols.org/stats?id=46362882) #20 -> [60 Minutes prison segment postponed by CBS briefly viewed in Canada on Global TV](https://www.cbc.ca/news/canada/cbs-60-minutes-report-el-salvador-cecot-global-9.7025912)<!-- HN:46362882:end --><!-- HN:46296498:start -->
* [46296498](https://news.social-protocols.org/stats?id=46296498) #26 20 points 23 comments -> [Show HN: I wrote a small lib to turn a USB gamepad into a Bluetooth one](https://github.com/skorokithakis/bluetooth-gamepad)<!-- HN:46296498:end --><!-- HN:46364338:start -->
* [46364338](https://news.social-protocols.org/stats?id=46364338) #9 18 points 12 comments -> [What Is (AI) Glaze?](https://glaze.cs.uchicago.edu/what-is-glaze.html)<!-- HN:46364338:end --><!-- HN:46364783:start -->
* [46364783](https://news.social-protocols.org/stats?id=46364783) #24 84 points 19 comments -> [Postponed '60 Minutes' segment on Salvadoran prison is streamed by Canadian news](https://www.nbcnews.com/news/us-news/cbs-news-el-salvador-cecot-prison-sharyn-alfonsi-bari-weiss-rcna250618)<!-- HN:46364783:end --><!-- HN:46366061:start -->
* [46366061](https://news.social-protocols.org/stats?id=46366061) #26 4 points 0 comments -> [CBS 60 minutes on CECOT only aired in Canada](https://archive.org/details/cecot-60mins)<!-- HN:46366061:end --><!-- HN:46369356:start -->
* [46369356](https://news.social-protocols.org/stats?id=46369356) #3 28 points 13 comments -> [Fuck You, I Won't Use Tailwind](https://fuckyouiwontusetailwind.com)<!-- HN:46369356:end -->
#### **Wednesday, December 24, 2025**<!-- HN:46303506:start -->
* [46303506](https://news.social-protocols.org/stats?id=46303506) #23 30 points 40 comments -> [Jimmy Wales trusts the process](https://www.theverge.com/tech/846184/jimmy-wales-trusts-the-process)<!-- HN:46303506:end --><!-- HN:46373919:start -->
* [46373919](https://news.social-protocols.org/stats?id=46373919) #4 8 points 4 comments -> [Next JavaScript app is hacked, you just don't know it yet](https://audits.blockhacks.io/audit/your-next-js-app-is-already-hacked)<!-- HN:46373919:end --><!-- HN:46375470:start -->
* [46375470](https://news.social-protocols.org/stats?id=46375470) #14 29 points 43 comments -> [The EU's Fine Against X Is Not About Speech or 'Censorship'](https://www.techpolicy.press/the-eus-fine-against-x-is-not-about-speech-or-censorship/)<!-- HN:46375470:end --><!-- HN:46376944:start -->
* [46376944](https://news.social-protocols.org/stats?id=46376944) #5 13 points 2 comments -> [Show HN: No more writing shitty regexes to police usernames](https://www.username.dev)<!-- HN:46376944:end --><!-- HN:46377605:start -->
* [46377605](https://news.social-protocols.org/stats?id=46377605) #22 12 points 5 comments -> [A Father, a Son and Their $108B Push for Media Moguldom (Larry Ellison)](https://www.nytimes.com/2025/12/24/business/media/larry-david-ellison-warner-bros-discovery-cbs.html)<!-- HN:46377605:end --><!-- HN:46378804:start -->
* [46378804](https://news.social-protocols.org/stats?id=46378804) #28 15 points 1 comments -> [The Government Unconstitutionally Labels ICE Observers as Domestic Terrorists](https://www.cato.org/blog/dhs-policy-threatening-arresting-ice-observers-violates-their-rights)<!-- HN:46378804:end --><!-- HN:46379129:start -->
* [46379129](https://news.social-protocols.org/stats?id=46379129) #15 15 points 8 comments -> [Build Your Own 100TB NAS in 2025: Complete TrueNAS Storage Guide](https://techlife.blog/posts/build-your-own-100tb-nas-2025-complete-truenas-storage-guide/)<!-- HN:46379129:end --><!-- HN:46378714:start -->
* [46378714](https://news.social-protocols.org/stats?id=46378714) #26 3 points 0 comments -> [A Distant Salutation: The moment the South lost the civil war](https://lessobvious.shorthandstories.com/jeb/)<!-- HN:46378714:end --><!-- HN:46379743:start -->
* [46379743](https://news.social-protocols.org/stats?id=46379743) #29 16 points 2 comments -> [It Is Happening Here](https://newrepublic.com/article/204227/trump-immigration-nightmare-happening-here)<!-- HN:46379743:end --><!-- HN:46379927:start -->
* [46379927](https://news.social-protocols.org/stats?id=46379927) #7 23 points 14 comments -> [Show HN: Just Fucking Use Cloudflare – A satirical guide to the CF stack](https://justfuckingusecloudflare.com)<!-- HN:46379927:end --><!-- HN:46379941:start -->
* [46379941](https://news.social-protocols.org/stats?id=46379941) #15 6 points 0 comments -> [TOPS-10 in a Box (2011)](https://www.filfre.net/2011/05/tops-10-in-a-box/)<!-- HN:46379941:end -->
#### **Thursday, December 25, 2025**
<!-- HN:46380027:start -->
* [46380027](https://news.social-protocols.org/stats?id=46380027) #29 15 points 7 comments -> [Microsoft: "30% of Our Code Is AI." Also Microsoft: "Windows Is Broken."](https://michael-dev-tech.github.io/Website/broken.html)<!-- HN:46380027:end --><!-- HN:46381681:start -->
* [46381681](https://news.social-protocols.org/stats?id=46381681) #12 7 points 1 comments -> [The most damaging taboo about sexual violence](https://write.as/3k6gb4heu8whz)<!-- HN:46381681:end --><!-- HN:46351625:start -->
* [46351625](https://news.social-protocols.org/stats?id=46351625) #22 7 points 0 comments -> [A Child in the State of Nature](https://lareviewofbooks.org/article/a-child-in-the-state-of-nature/)<!-- HN:46351625:end --><!-- HN:46383344:start -->
* [46383344](https://news.social-protocols.org/stats?id=46383344) #4 12 points 9 comments -> [Why 'The Global Market' Is an Irresponsible Phrase](https://oswarld.com/eng/insight/251117_Why-the-global-market-Is-an-Irresponsible-Phrase)<!-- HN:46383344:end --><!-- HN:46323177:start -->
* [46323177](https://news.social-protocols.org/stats?id=46323177) #15 4 points 0 comments -> [Why Community Translation Falls Short for Your Plugins and Themes](https://wpml.org/announcements/2025/12/why-community-translation-falls-short-for-your-plugins-and-themes/)<!-- HN:46323177:end --><!-- HN:46384415:start -->
* [46384415](https://news.social-protocols.org/stats?id=46384415) #20 22 points 18 comments -> [Ultra-Low-Latency Trading System](https://submicro.krishnabajpai.me/)<!-- HN:46384415:end --><!-- HN:46384781:start -->
* [46384781](https://news.social-protocols.org/stats?id=46384781) #10 132 points 74 comments -> [Salesforce regrets firing 4000 experienced staff and replacing them with AI](https://maarthandam.com/2025/12/25/salesforce-regrets-firing-4000-staff-ai/)<!-- HN:46384781:end --><!-- HN:46338788:start -->
* [46338788](https://news.social-protocols.org/stats?id=46338788) #8 5 points 2 comments -> [Rare look inside the secret Lego Museum](https://www.cbsnews.com/news/lego-secret-museum-denmark-headquarters/)<!-- HN:46338788:end --><!-- HN:46385335:start -->
* [46385335](https://news.social-protocols.org/stats?id=46385335) #8 5 points 1 comments -> [Why FedRAMP Authorization and CMMC Level 2 Are Now Table Stakes for GovCon AI](https://blog.procurementsciences.com/psci_blogs/why-fedramp-authorization-and-cmmc-level-2-are-now-table-stakes-for-govcon-ai)<!-- HN:46385335:end --><!-- HN:46386211:start -->
* [46386211](https://news.social-protocols.org/stats?id=46386211) #8 23 points 0 comments -> [39c3 Fahrplan (Schedule)](https://fahrplan.events.ccc.de/congress/2025/fahrplan/)<!-- HN:46386211:end -->