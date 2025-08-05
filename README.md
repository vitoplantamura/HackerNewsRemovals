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

#### **Wednesday, July 30, 2025**<!-- HN:44732216:start -->
* [44732216](https://news.social-protocols.org/stats?id=44732216) #6 5 points 0 comments -> [Show HN: I built a free backlink exchange marketplace](https://launchigniter.com/link-exchange)<!-- HN:44732216:end --><!-- HN:44731883:start -->
* [44731883](https://news.social-protocols.org/stats?id=44731883) #5 19 points 33 comments -> [One diet soda a day increases type 2 diabetes risk by 38%](https://newatlas.com/diet-nutrition/one-drink-diabetes-risk/)<!-- HN:44731883:end --><!-- HN:44732939:start -->
* [44732939](https://news.social-protocols.org/stats?id=44732939) #3 7 points 1 comments -> [Track how much money AIPAC spent to buy Congress](https://www.trackaipac.com)<!-- HN:44732939:end --><!-- HN:44732893:start -->
* [44732893](https://news.social-protocols.org/stats?id=44732893) #15 10 points 1 comments -> [New York Times rolls back claims about viral photo of starving Gaza boy](https://nypost.com/2025/07/29/media/new-york-times-stunningly-rolls-back-claims-about-viral-photo-of-starving-gaza-boy/)<!-- HN:44732893:end --><!-- HN:44733313:start -->
* [44733313](https://news.social-protocols.org/stats?id=44733313) #27 3 points 0 comments -> [Hamas's propaganda war: Israel battles famine allegations](https://nationalpost.com/news/hamass-propaganda-war-israel-battles-famine-allegations)<!-- HN:44733313:end --><!-- HN:44733445:start -->
* [44733445](https://news.social-protocols.org/stats?id=44733445) #9 13 points 3 comments -> [We have appended an Editors' Note about Mohammed Zakaria, a child in Gaza](https://twitter.com/NYTimesPR/status/1950311365756817690)<!-- HN:44733445:end --><!-- HN:44732994:start -->
* [44732994](https://news.social-protocols.org/stats?id=44732994) #30 5 points 0 comments -> [Figma S-1, the Figma OS, Figma's AI Potential](https://stratechery.com/2025/figma-s-1-the-figma-os-figmas-ai-potential/)<!-- HN:44732994:end --><!-- HN:44733944:start -->
* [44733944](https://news.social-protocols.org/stats?id=44733944) #28 8 points 2 comments -> [The fringe movement punishing officials with fake debt claims](https://www.latimes.com/california/story/2025-07-30/fake-filings-real-consequences-how-paper-terrorism-is-burying-a-state-system-with-bogus-claims)<!-- HN:44733944:end --><!-- HN:44735359:start -->
* [44735359](https://news.social-protocols.org/stats?id=44735359) #6 -> [Startup failed. Relationship ended. 29 lessons from the wreckage](https://burnedchris.com/blog/29-lessons)<!-- HN:44735359:end --><!-- HN:44737839:start -->
* [44737839](https://news.social-protocols.org/stats?id=44737839) #29 13 points 2 comments -> [Drawing for the New Yorker](https://lizadonnelly.substack.com/p/drawing-for-the-new-yorker)<!-- HN:44737839:end --><!-- HN:44739117:start -->
* [44739117](https://news.social-protocols.org/stats?id=44739117) #7 23 points 15 comments -> [Actions Reflect Your Priorities](https://tombrady.com/posts/your-actions-reflect-your-priorities)<!-- HN:44739117:end -->
#### **Thursday, July 31, 2025**
<!-- HN:44704052:start -->
* [44704052](https://news.social-protocols.org/stats?id=44704052) #29 9 points 5 comments -> [Boston Dynamics' Atlas does backflips (lesson and breakdown)](https://app.vidyaarthi.ai/ai-tutor?session_id=2YBSyF3WNzMNn_80jygEp&action=replay&shared=true)<!-- HN:44704052:end --><!-- HN:44746272:start -->
* [44746272](https://news.social-protocols.org/stats?id=44746272) #9 5 points 1 comments -> [Italy Armed to the Teeth: My Top Nine Poliziotteschi](https://multiglom.com/2020/04/12/italy-armed-to-the-teeth-my-top-ten-poliziotteschi/)<!-- HN:44746272:end --><!-- HN:44746326:start -->
* [44746326](https://news.social-protocols.org/stats?id=44746326) #21 19 points 11 comments -> [Do PE firms create value? How?](https://www.gain.pro/insight-reports/value-creation)<!-- HN:44746326:end -->
#### **Friday, August 1, 2025**
<!-- HN:44751258:start -->
* [44751258](https://news.social-protocols.org/stats?id=44751258) #12 14 points 4 comments -> [Comprehensive Overview of the Identity Management Ecosystem in 2025](https://guptadeepak.com/understanding-the-complete-identity-management-ecosystem/)<!-- HN:44751258:end --><!-- HN:44752051:start -->
* [44752051](https://news.social-protocols.org/stats?id=44752051) #11 8 points 0 comments -> [We Asked 100 AI Models to Write Code](https://www.veracode.com/blog/genai-code-security-report/)<!-- HN:44752051:end --><!-- HN:44755298:start -->
* [44755298](https://news.social-protocols.org/stats?id=44755298) #3 43 points 36 comments -> [How to Secure a Linux Server](https://github.com/imthenachoman/How-To-Secure-A-Linux-Server)<!-- HN:44755298:end --><!-- HN:44755341:start -->
* [44755341](https://news.social-protocols.org/stats?id=44755341) #2 63 points 4 comments -> [Gemini 2.5 Deep Think](https://twitter.com/GoogleDeepMind/status/1951239132950204439)<!-- HN:44755341:end --><!-- HN:44758453:start -->
* [44758453](https://news.social-protocols.org/stats?id=44758453) #14 17 points 41 comments -> [Rate, Price Drops Won't Substantially Improve Affordability](https://www.zillow.com/research/rate-drops-35389/)<!-- HN:44758453:end --><!-- HN:44759237:start -->
* [44759237](https://news.social-protocols.org/stats?id=44759237) #26 4 points 0 comments -> [Show HN: The platform making SEO simpler, cheaper, and more effective](https://idiotproofseo.com/)<!-- HN:44759237:end --><!-- HN:44760740:start -->
* [44760740](https://news.social-protocols.org/stats?id=44760740) #14 4 points 0 comments -> [The Economy? He died five years ago](https://daverupert.com/2025/08/the-economy-he-died-five-years-ago/)<!-- HN:44760740:end --><!-- HN:44762157:start -->
* [44762157](https://news.social-protocols.org/stats?id=44762157) #19 5 points 1 comments -> [HTTP Methods](https://developer.mozilla.org/en-US/docs/Web/HTTP/Reference/Methods)<!-- HN:44762157:end -->
#### **Saturday, August 2, 2025**
<!-- HN:44762504:start -->
* [44762504](https://news.social-protocols.org/stats?id=44762504) #16 39 points 24 comments -> [JSON is not a YAML subset (2022)](https://john-millikin.com/json-is-not-a-yaml-subset)<!-- HN:44762504:end --><!-- HN:44765939:start -->
* [44765939](https://news.social-protocols.org/stats?id=44765939) #7 27 points 10 comments -> [EU kills Android bootloader unlock starting August 1](https://xiaomitime.com/eu-kills-android-bootloader-unlock-starting-august-1-59449/)<!-- HN:44765939:end --><!-- HN:44766313:start -->
* [44766313](https://news.social-protocols.org/stats?id=44766313) #4 31 points 2 comments -> [Tesla Found Partly Liable in 2019 Autopilot Death](https://www.wired.com/story/tesla-liable-2019-autopilot-crash-death/)<!-- HN:44766313:end --><!-- HN:44737759:start -->
* [44737759](https://news.social-protocols.org/stats?id=44737759) #21 4 points 2 comments -> [Microsoft Has a Surface Laptop 'Smurface Edition' for Smurfs Fans](https://www.theverge.com/news/715741/microsoft-surface-laptop-smurface-edition)<!-- HN:44737759:end --><!-- HN:44765193:start -->
* [44765193](https://news.social-protocols.org/stats?id=44765193) #3 58 points 66 comments -> [At $250M, top AI salaries dwarf the Manhattan Project and the Space Race](https://arstechnica.com/ai/2025/08/at-250-million-top-ai-salaries-dwarf-those-of-the-manhattan-project-and-the-space-race/)<!-- HN:44765193:end --><!-- HN:44727871:start -->
* [44727871](https://news.social-protocols.org/stats?id=44727871) #28 13 points 1 comments -> [Palo Alto Networks closing on over $20B acquisition of CyberArk](https://www.calcalistech.com/ctechnews/article/hksugkiwxe)<!-- HN:44727871:end --><!-- HN:44768302:start -->
* [44768302](https://news.social-protocols.org/stats?id=44768302) #22 22 points 40 comments -> [Ana Marie Cox on the Shaky Foundation of Substack as a Business](https://newsletter.anamariecox.com/archive/substack-did-not-see-that-coming/)<!-- HN:44768302:end --><!-- HN:44767003:start -->
* [44767003](https://news.social-protocols.org/stats?id=44767003) #8 163 points 1 comments -> [6 Weeks of Claude Code](https://blog.puzzmo.com/posts/2025/07/30/six-weeks-of-claude-code/)<!-- HN:44767003:end --><!-- HN:44767947:start -->
* [44767947](https://news.social-protocols.org/stats?id=44767947) #15 33 points 1 comments -> [Unikernel Guide: Build and Deploy Lightweight, Secure Apps](https://tallysolutions.com/technology/introduction-to-unikernel-2/)<!-- HN:44767947:end --><!-- HN:44770485:start -->
* [44770485](https://news.social-protocols.org/stats?id=44770485) #3 -> [Chilling warnings from 1930s Europe: "Reality is stronger than all our wishes"](https://www.doomsdayscenario.co/p/fleeing-one-step-ahead-of-fascism-fbcf5ac4661dca77)<!-- HN:44770485:end --><!-- HN:44770874:start -->
* [44770874](https://news.social-protocols.org/stats?id=44770874) #21 4 points 0 comments -> [GrapheneOS Is a Cult (German)](https://www.onli-blogging.de/2546/GrapheneOS-ist-ein-gefaehrlicher-Kult.html)<!-- HN:44770874:end -->
#### **Sunday, August 3, 2025**
<!-- HN:44774121:start -->
* [44774121](https://news.social-protocols.org/stats?id=44774121) #15 62 points 36 comments -> [Useful AI coding guide with Claude Code](https://www.sabrina.dev/p/ultimate-ai-coding-guide-claude-code)<!-- HN:44774121:end --><!-- HN:44775596:start -->
* [44775596](https://news.social-protocols.org/stats?id=44775596) #12 26 points 8 comments -> [Tesla loses Autopilot wrongful death case in $329M verdict](https://arstechnica.com/cars/2025/08/tesla-loses-autopilot-wrongful-death-case-in-329-million-verdict/)<!-- HN:44775596:end --><!-- HN:44775987:start -->
* [44775987](https://news.social-protocols.org/stats?id=44775987) #9 9 points 3 comments -> [Why you're going to see more swimming pools in strip malls](https://thehustle.co/originals/why-youre-going-to-see-a-lot-more-swimming-pools-in-strip-malls)<!-- HN:44775987:end --><!-- HN:44776574:start -->
* [44776574](https://news.social-protocols.org/stats?id=44776574) #2 46 points 14 comments -> [One Third of the Web Will Stop Working in 4 Days](https://lowendbox.com/blog/one-third-of-the-web-will-stop-working-in-4-days-massive-scale-cdn-compromise-starts-wednesday/)<!-- HN:44776574:end --><!-- HN:44777584:start -->
* [44777584](https://news.social-protocols.org/stats?id=44777584) #2 11 points 1 comments -> [How OpenAI Is Turning Monopoly Money into Real Debt](https://saturn.land/monopoly-money.html)<!-- HN:44777584:end --><!-- HN:44778088:start -->
* [44778088](https://news.social-protocols.org/stats?id=44778088) #14 9 points 4 comments -> [Time Theft at the Terminal](https://marginalrevolution.com/marginalrevolution/2025/08/time-theft-at-the-terminal.html)<!-- HN:44778088:end --><!-- HN:44778408:start -->
* [44778408](https://news.social-protocols.org/stats?id=44778408) #3 8 points 4 comments -> [We Paid Users $300K to Upload Their Camera Rolls, Homework, and Dashcam Footage](https://www.kled.ai/)<!-- HN:44778408:end --><!-- HN:44746062:start -->
* [44746062](https://news.social-protocols.org/stats?id=44746062) #29 10 points 0 comments -> [Show HN: Implementation of DDPM (Denoising Diffusion Probabilistic Models)](https://github.com/alenMangattu/DDPM-Denoising-Diffusion-Probabilistic-Models)<!-- HN:44746062:end --><!-- HN:44778534:start -->
* [44778534](https://news.social-protocols.org/stats?id=44778534) #4 -> [How to Leave Substack](https://leavesubstack.com/)<!-- HN:44778534:end --><!-- HN:44779686:start -->
* [44779686](https://news.social-protocols.org/stats?id=44779686) #8 12 points 4 comments -> [In the Future All Food Will Be Cooked in a Microwave](https://www.colincornaby.me/2025/08/in-the-future-all-food-will-be-cooked-in-a-microwave-and-if-you-cant-deal-with-that-then-you-need-to-get-out-of-the-kitchen/)<!-- HN:44779686:end --><!-- HN:44779071:start -->
* [44779071](https://news.social-protocols.org/stats?id=44779071) #29 3 points 1 comments -> [The Worst Programmer I Know (2023)](https://dannorth.net/blog/the-worst-programmer/)<!-- HN:44779071:end --><!-- HN:44780244:start -->
* [44780244](https://news.social-protocols.org/stats?id=44780244) #30 7 points 2 comments -> [US woman jailed over North Korea remote-work scam](https://www.theguardian.com/us-news/2025/aug/03/ninety-laptops-millions-of-dollars-us-woman-jailed-for-role-in-north-korea-remote-work-scam)<!-- HN:44780244:end --><!-- HN:44780706:start -->
* [44780706](https://news.social-protocols.org/stats?id=44780706) #24 12 points 0 comments -> [Texas House Democrats flee state in bid to block GOP proposed congressional map](https://www.texastribune.org/2025/08/03/texas-democrats-quorum-break-redistricting-map/)<!-- HN:44780706:end -->
#### **Monday, August 4, 2025**
<!-- HN:44781772:start -->
* [44781772](https://news.social-protocols.org/stats?id=44781772) #11 7 points 0 comments -> [The Demon that Wears my Face](https://mirawelner.com/posts/demon.html)<!-- HN:44781772:end --><!-- HN:44783895:start -->
* [44783895](https://news.social-protocols.org/stats?id=44783895) #25 6 points 1 comments -> [BBC finds electrocuted, drowned and starved cats in online torture groups](https://www.bbc.com/news/articles/c5yp9w5kyw7o)<!-- HN:44783895:end --><!-- HN:44784809:start -->
* [44784809](https://news.social-protocols.org/stats?id=44784809) #3 11 points 4 comments -> [Every Reason Why I Hate AI and You Should Too](https://malwaretech.com/2025/08/every-reason-why-i-hate-ai.html)<!-- HN:44784809:end --><!-- HN:44785093:start -->
* [44785093](https://news.social-protocols.org/stats?id=44785093) #18 28 points 23 comments -> [Why I'm Leaving NixOS After a Year?](https://www.rugu.dev/en/blog/leaving-nixos/)<!-- HN:44785093:end --><!-- HN:44787777:start -->
* [44787777](https://news.social-protocols.org/stats?id=44787777) #12 3 points 1 comments -> [Rethinking how we measure AI intelligence](https://blog.google/technology/ai/kaggle-game-arena/)<!-- HN:44787777:end --><!-- HN:44791969:start -->
* [44791969](https://news.social-protocols.org/stats?id=44791969) #16 10 points 2 comments -> [An Investigation into the Firm at the Heart of the Democratic Spam Machine](https://data4democracy.substack.com/p/the-mothership-vortex-an-investigation)<!-- HN:44791969:end --><!-- HN:44792163:start -->
* [44792163](https://news.social-protocols.org/stats?id=44792163) #7 12 points 5 comments -> [Tesla Diner](https://www.tesla.com/tesla-diner)<!-- HN:44792163:end -->
#### **Tuesday, August 5, 2025**
<!-- HN:44766893:start -->
* [44766893](https://news.social-protocols.org/stats?id=44766893) #6 27 points 41 comments -> [What'll happen if we spend nearly $3T on data centres no one needs?](https://www.ft.com/content/7052c560-4f31-4f45-bed0-cbc84453b3ce)<!-- HN:44766893:end --><!-- HN:44794135:start -->
* [44794135](https://news.social-protocols.org/stats?id=44794135) #5 3 points 1 comments -> [Oxmiq Labs Inc.: Re-Architecting the GPU Stack: From Atoms to Agents](https://oxmiq.ai/press)<!-- HN:44794135:end --><!-- HN:44797264:start -->
* [44797264](https://news.social-protocols.org/stats?id=44797264) #9 10 points 6 comments -> [GitHub CEO Warns Developers: "Either Embrace AI or Get Out of This Career"](https://www.finalroundai.com/blog/github-ceo-thomas-dohmke-warns-developers-embrace-ai-or-quit)<!-- HN:44797264:end --><!-- HN:44798601:start -->
* [44798601](https://news.social-protocols.org/stats?id=44798601) #30 11 points 1 comments -> [Doge wasted $21.7B in taxpayer funds, according to Senate report](https://www.msnbc.com/top-stories/latest/doge-federal-employees-reductions-in-force-rif-rcna222536)<!-- HN:44798601:end --><!-- HN:44799494:start -->
* [44799494](https://news.social-protocols.org/stats?id=44799494) #7 54 points 2 comments -> [GitHub is having an ongoing incident with loading pull requests](https://www.githubstatus.com/incidents/6swp0zf7lk8h)<!-- HN:44799494:end --><!-- HN:44799435:start -->
* [44799435](https://news.social-protocols.org/stats?id=44799435) #25 200 points 3 comments -> [GitHub Pull Requests Are Down](https://github.com/github/site-policy/pull/582)<!-- HN:44799435:end -->