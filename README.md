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

#### **Friday, April 3, 2026**
<!-- HN:47621591:start -->
* [47621591](https://news.social-protocols.org/stats?id=47621591) #19 30 points 22 comments -> [Every Law a Commit – US Law in GitHub](https://v1d0b0t.github.io/blog/posts/2026-03-29-every-law-a-commit.html)<!-- HN:47621591:end --><!-- HN:47622776:start -->
* [47622776](https://news.social-protocols.org/stats?id=47622776) #16 30 points 5 comments -> [US-Israeli bombing destroys oldest medical research center in Iran](https://www.egyptindependent.com/us-israeli-bombing-destroys-oldest-medical-research-center-in-iran-official-says/)<!-- HN:47622776:end --><!-- HN:47623665:start -->
* [47623665](https://news.social-protocols.org/stats?id=47623665) #24 17 points 2 comments -> [Pentagon Pete's Bigoted Reason for Firing Top General Leaks](https://www.thedailybeast.com/pentagon-petes-bigoted-reason-for-firing-top-general-randy-george-leaks/)<!-- HN:47623665:end --><!-- HN:47564699:start -->
* [47564699](https://news.social-protocols.org/stats?id=47564699) #16 9 points 1 comments -> [Researchers uncover 2k-year-old bullet inscribed with ominous message](https://www.gbnews.com/science/archaeology-breakthrough-researchers-uncover-2000-year-old-bullet-ominous-message)<!-- HN:47564699:end --><!-- HN:47625665:start -->
* [47625665](https://news.social-protocols.org/stats?id=47625665) #6 12 points 3 comments -> [Lower Price for ChatGPT Business](https://help.openai.com/en/articles/8792828-what-is-chatgpt-business)<!-- HN:47625665:end --><!-- HN:47624741:start -->
* [47624741](https://news.social-protocols.org/stats?id=47624741) #13 322 points 134 comments -> [Show HN: European alternatives to Google, Apple, Dropbox and 120 US apps](https://only-eu.eu/en/)<!-- HN:47624741:end --><!-- HN:47626116:start -->
* [47626116](https://news.social-protocols.org/stats?id=47626116) #5 14 points 1 comments -> [Adult German men must request permission to leave Germany for more than 3 months](https://www.fr.de/politik/drastische-wehrpflicht-aenderung-maenner-die-deutschland-laenger-wollen-brauchen-genehmigung-zr-94248132.html)<!-- HN:47626116:end --><!-- HN:47626445:start -->
* [47626445](https://news.social-protocols.org/stats?id=47626445) #7 15 points 6 comments -> [Systemd BirthDate Merge: Conflicts of Interest](https://tboteproject.com/systemdfindings/)<!-- HN:47626445:end --><!-- HN:47625366:start -->
* [47625366](https://news.social-protocols.org/stats?id=47625366) #25 40 points 12 comments -> [United States Code (federal laws) in Git](https://github.com/nickvido/us-code)<!-- HN:47625366:end --><!-- HN:47626900:start -->
* [47626900](https://news.social-protocols.org/stats?id=47626900) #3 7 points 0 comments -> [Grok scored zero on ARC-AGI-3. Every 5-year-old did better](https://aitwerp.com/signals/agi-benchmark-five-year-old-wins/)<!-- HN:47626900:end --><!-- HN:47626434:start -->
* [47626434](https://news.social-protocols.org/stats?id=47626434) #15 19 points 11 comments -> [Claude 4.6 Jailbroken](https://github.com/Nicholas-Kloster/claude-4.6-jailbreak-vulnerability-disclosure-unredacted)<!-- HN:47626434:end --><!-- HN:47629905:start -->
* [47629905](https://news.social-protocols.org/stats?id=47629905) #16 16 points 2 comments -> [Show HN: An evidence-rated encyclopedia of peptides](https://www.whatthepeptide.org/)<!-- HN:47629905:end --><!-- HN:47631197:start -->
* [47631197](https://news.social-protocols.org/stats?id=47631197) #16 23 points 0 comments -> [War crimes are no longer shameful. That should terrify you](https://www.aljazeera.com/opinions/2026/4/3/war-crimes-are-no-longer-shameful-that-should-terrify-you)<!-- HN:47631197:end --><!-- HN:47567222:start -->
* [47567222](https://news.social-protocols.org/stats?id=47567222) #13 390 points 212 comments -> [Samsung Magician disk utility takes 18 steps and two reboots to uninstall](https://chalmovsky.com/2026/03/29/samsung-magician.html)<!-- HN:47567222:end --><!-- HN:47562135:start -->
* [47562135](https://news.social-protocols.org/stats?id=47562135) #27 86 points 5 comments -> [Show HN: TurboQuant for vector search – 2-4 bit compression](https://github.com/RyanCodrai/py-turboquant)<!-- HN:47562135:end --><!-- HN:47560967:start -->
* [47560967](https://news.social-protocols.org/stats?id=47560967) #30 132 points 29 comments -> [A Recipe for Steganogravy](https://theo.lol/python/ai/steganography/seo/recipes/2026/03/27/a-recipe-for-steganogravy.html)<!-- HN:47560967:end -->
#### **Saturday, April 4, 2026**
<!-- HN:47634738:start -->
* [47634738](https://news.social-protocols.org/stats?id=47634738) #14 6 points 0 comments -> [Anthropic open-sourced claude-code](https://github.com/anthropics/claude-code)<!-- HN:47634738:end --><!-- HN:47601033:start -->
* [47601033](https://news.social-protocols.org/stats?id=47601033) #5 10 points 1 comments -> [New Color Mode Coming to GIMP](https://www.gimp.org/news/2026/04/01/new-color-mode-coming-to-gimp/)<!-- HN:47601033:end --><!-- HN:47631732:start -->
* [47631732](https://news.social-protocols.org/stats?id=47631732) #22 477 points 260 comments -> [Oracle Files H-1B Visa Petitions Amid Mass Layoffs](https://nationaltoday.com/us/tx/austin/news/2026/04/03/oracle-files-thousands-of-h-1b-visa-petitions-amid-mass-layoffs/)<!-- HN:47631732:end --><!-- HN:47605531:start -->
* [47605531](https://news.social-protocols.org/stats?id=47605531) #20 5 points 0 comments -> [Paperweight, an April Fool's Prank from 40 years ago](https://www.goto10retro.com/p/paperweight-an-april-fools-prank)<!-- HN:47605531:end --><!-- HN:47635616:start -->
* [47635616](https://news.social-protocols.org/stats?id=47635616) #16 15 points 13 comments -> [Delve sets the record straight on anonymous attacks](https://delve.co/blog/delve-sets-the-record-straight-on-anonymous-attacks)<!-- HN:47635616:end --><!-- HN:47637228:start -->
* [47637228](https://news.social-protocols.org/stats?id=47637228) #5 11 points 3 comments -> [TurboQuant model weight compression support added to Llamacpp](https://github.com/TheTom/llama-cpp-turboquant/pull/45)<!-- HN:47637228:end --><!-- HN:47640770:start -->
* [47640770](https://news.social-protocols.org/stats?id=47640770) #23 4 points 0 comments -> [Show HN: DocMason – Agent Knowledge Base for local complex office files](https://github.com/jetxu-llm/docmason)<!-- HN:47640770:end --><!-- HN:47641487:start -->
* [47641487](https://news.social-protocols.org/stats?id=47641487) #25 7 points 4 comments -> [Show HN: Running local OpenClaw together with remote agents in an open network](https://github.com/hybroai/hybro-hub)<!-- HN:47641487:end --><!-- HN:47643620:start -->
* [47643620](https://news.social-protocols.org/stats?id=47643620) #18 -> [Seat Pricing Is Dead](http://seatpricing.rip/)<!-- HN:47643620:end --><!-- HN:47644291:start -->
* [47644291](https://news.social-protocols.org/stats?id=47644291) #14 17 points 4 comments -> [America is heading for a recession – and it may be the worst yet](https://thehill.com/opinion/finance/5814974-middle-class-decline-permanent-crisis/)<!-- HN:47644291:end --><!-- HN:47644410:start -->
* [47644410](https://news.social-protocols.org/stats?id=47644410) #5 11 points 3 comments -> [Banning All Anthropic Employees](https://joeyh.name/blog/entry/banning_all_Anthropic_employees/)<!-- HN:47644410:end -->
#### **Sunday, April 5, 2026**
<!-- HN:47644610:start -->
* [47644610](https://news.social-protocols.org/stats?id=47644610) #6 18 points 22 comments -> [Demand for autism care is soaring](https://economist.com/united-states/2026/04/01/demand-for-autism-care-is-soaring-the-system-is-struggling-to-cope)<!-- HN:47644610:end --><!-- HN:47606954:start -->
* [47606954](https://news.social-protocols.org/stats?id=47606954) #23 3 points 0 comments -> [Non-Determinism Isn't a Bug. It's Tuesday](https://www.kasava.dev/blog/why-pms-are-built-for-ai)<!-- HN:47606954:end --><!-- HN:47644605:start -->
* [47644605](https://news.social-protocols.org/stats?id=47644605) #21 32 points 6 comments -> [Sens Ask Gabbard to Tell Americans That VPN Use Subjects Them to Surveillance](https://www.techdirt.com/2026/04/03/senators-ask-tulsi-gabbard-to-tell-americans-that-vpn-use-might-subject-them-to-domestic-surveillance/)<!-- HN:47644605:end --><!-- HN:47645810:start -->
* [47645810](https://news.social-protocols.org/stats?id=47645810) #6 7 points 5 comments -> [AGI Is Here](https://breaking-changes.blog/agi-is-here/)<!-- HN:47645810:end --><!-- HN:47645822:start -->
* [47645822](https://news.social-protocols.org/stats?id=47645822) #15 4 points 0 comments -> [Remember Their Names](https://visualizingpalestine.org/visual/end-30-billion-of-us-military-aid-to-israel-green-jobs/)<!-- HN:47645822:end --><!-- HN:47646277:start -->
* [47646277](https://news.social-protocols.org/stats?id=47646277) #13 28 points 41 comments -> [I used AI. It worked. I hated it](https://taggart-tech.com/reckoning/)<!-- HN:47646277:end --><!-- HN:47646672:start -->
* [47646672](https://news.social-protocols.org/stats?id=47646672) #4 30 points 20 comments -> [GabeN Is Shitting Yacht Money into Flatpak and You're Still Arguing Init Systems](https://s3kshun8.games/blog/flatpak-won/)<!-- HN:47646672:end --><!-- HN:47646965:start -->
* [47646965](https://news.social-protocols.org/stats?id=47646965) #27 7 points 2 comments -> [U.S. Rescues Officer from Downed Fighter Jet in Iran](https://www.nytimes.com/live/2026/04/05/world/iran-war-trump-news)<!-- HN:47646965:end --><!-- HN:47647408:start -->
* [47647408](https://news.social-protocols.org/stats?id=47647408) #15 6 points 1 comments -> [The Future of Adult Entertainment: Personalized, AI Content](https://unbound.video/landing4)<!-- HN:47647408:end --><!-- HN:47648744:start -->
* [47648744](https://news.social-protocols.org/stats?id=47648744) #18 6 points 1 comments -> [Two Planes Destroyed by U.S. During Rescue Operation](https://www.wsj.com/livecoverage/iran-war-news-2026/card/two-special-operations-mj-130s-destroyed-by-u-s-during-rescue-operation-NbFfOdbvk7dWX1a7ZuW8)<!-- HN:47648744:end --><!-- HN:47601237:start -->
* [47601237](https://news.social-protocols.org/stats?id=47601237) #16 5 points 0 comments -> [Puzzlehunts](https://www.vikramsaraph.com/blog/2026/04/01/puzzlehunts/)<!-- HN:47601237:end --><!-- HN:47652421:start -->
* [47652421](https://news.social-protocols.org/stats?id=47652421) #7 8 points 6 comments -> [Gender Equality and Work](https://www.oecd.org/en/topics/gender-equality-and-work.html)<!-- HN:47652421:end --><!-- HN:47588929:start -->
* [47588929](https://news.social-protocols.org/stats?id=47588929) #19 8 points 4 comments -> [DNS is Simple. DNS is Hard](https://www.wespiser.com/posts/2026-03-29-dns-simple-dns-hard.html)<!-- HN:47588929:end --><!-- HN:47652487:start -->
* [47652487](https://news.social-protocols.org/stats?id=47652487) #29 34 points 6 comments -> [Show HN: Enter an Instagram/TikTok handle, get a data-backed price for collab](https://priceinfluencer.com)<!-- HN:47652487:end --><!-- HN:47653954:start -->
* [47653954](https://news.social-protocols.org/stats?id=47653954) #9 4 points 0 comments -> [Policy on adding AI generated content to my software projects](https://joeyh.name/blog/entry/policy_on_adding_AI_generated_content_to_my_software_projects/)<!-- HN:47653954:end -->
#### **Monday, April 6, 2026**
<!-- HN:47655338:start -->
* [47655338](https://news.social-protocols.org/stats?id=47655338) #8 24 points 40 comments -> [Peter Thiel's big bet on solar-powered cow collars](https://techcrunch.com/2026/04/04/unpacking-peter-thiels-big-bet-on-solar-powered-cow-collars/)<!-- HN:47655338:end --><!-- HN:47656035:start -->
* [47656035](https://news.social-protocols.org/stats?id=47656035) #25 4 points 0 comments -> [US War Machine Is Built on Decades of Lies. The Assault on Iran Is No Exception](https://truthout.org/articles/us-war-machine-is-built-on-decades-of-lies-the-assault-on-iran-is-no-exception/)<!-- HN:47656035:end --><!-- HN:47655618:start -->
* [47655618](https://news.social-protocols.org/stats?id=47655618) #22 10 points 3 comments -> [Apex Protocol – An open MCP-based standard for AI agent trading](https://apexstandard.org/)<!-- HN:47655618:end --><!-- HN:47594345:start -->
* [47594345](https://news.social-protocols.org/stats?id=47594345) #29 33 points 4 comments -> [Wavelets on Graphs via Spectral Graph Theory (2009)](https://arxiv.org/abs/0912.3848)<!-- HN:47594345:end --><!-- HN:47655329:start -->
* [47655329](https://news.social-protocols.org/stats?id=47655329) #2 150 points 32 comments -> [Copilot is 'for entertainment purposes only', per Microsoft's terms of use](https://techcrunch.com/2026/04/05/copilot-is-for-entertainment-purposes-only-according-to-microsofts-terms-of-service/)<!-- HN:47655329:end --><!-- HN:47657699:start -->
* [47657699](https://news.social-protocols.org/stats?id=47657699) #3 46 points 30 comments -> [VS Code rebuilt on Tauri. Same architecture, 96% smaller](https://github.com/Sidenai/sidex)<!-- HN:47657699:end --><!-- HN:47658328:start -->
* [47658328](https://news.social-protocols.org/stats?id=47658328) #7 41 points 11 comments -> [Euro-Office – Your sovereign office](https://github.com/Euro-Office)<!-- HN:47658328:end --><!-- HN:47659109:start -->
* [47659109](https://news.social-protocols.org/stats?id=47659109) #2 264 points 73 comments -> [Age Verification as Mass Surveillance Infrastructure](https://tboteproject.com/surveillancefindings/)<!-- HN:47659109:end --><!-- HN:47662442:start -->
* [47662442](https://news.social-protocols.org/stats?id=47662442) #16 20 points 41 comments -> [More Americans Are Breaking into the Upper Middle Class](https://www.wsj.com/economy/more-americans-are-breaking-into-the-upper-middle-class-bf8b7cb2)<!-- HN:47662442:end --><!-- HN:47662894:start -->
* [47662894](https://news.social-protocols.org/stats?id=47662894) #30 5 points 0 comments -> [US-Iranian War: a best case scenario](https://kamilkazani.substack.com/p/us-iranian-war-a-best-case-scenario)<!-- HN:47662894:end --><!-- HN:47666170:start -->
* [47666170](https://news.social-protocols.org/stats?id=47666170) #14 4 points 1 comments -> [AI agents over SSH from your phone. Starting to think this is where dev is going](https://onepilotapp.com)<!-- HN:47666170:end -->
#### **Tuesday, April 7, 2026**
<!-- HN:47654346:start -->
* [47654346](https://news.social-protocols.org/stats?id=47654346) #30 -> [The anatomy of SMS delivery: from request to carrier](https://blog.bridgexapi.io/the-anatomy-of-sms-delivery-from-request-to-carrier)<!-- HN:47654346:end --><!-- HN:47670276:start -->
* [47670276](https://news.social-protocols.org/stats?id=47670276) #27 18 points 8 comments -> [Why the majority of vibe coded projects fail](https://www.reddit.com/r/ClaudeAI/s/Vkkzi4lUW0)<!-- HN:47670276:end --><!-- HN:47670929:start -->
* [47670929](https://news.social-protocols.org/stats?id=47670929) #1 36 points 31 comments -> [People Love to Work Hard](https://www.anildash.com/2026/04/06/people-love-to-work-hard/)<!-- HN:47670929:end --><!-- HN:47673104:start -->
* [47673104](https://news.social-protocols.org/stats?id=47673104) #7 9 points 2 comments -> [AI Won't Replace You, but a Manager Using AI Will](https://yanivpreiss.com/2026/04/06/ai-wont-replace-you-but-a-manager-using-ai-will/)<!-- HN:47673104:end --><!-- HN:47672268:start -->
* [47672268](https://news.social-protocols.org/stats?id=47672268) #26 10 points 4 comments -> [Iran Is Not Blocking the Strait of Hormuz. It's Running a Toll Booth](https://www.shatterbelt.co/articles/iran-hormuz-toll-booth)<!-- HN:47672268:end --><!-- HN:47673919:start -->
* [47673919](https://news.social-protocols.org/stats?id=47673919) #16 8 points 2 comments -> [AI agents can communicate with each other, and can't be caught](https://arxiv.org/abs/2604.04757)<!-- HN:47673919:end --><!-- HN:47674469:start -->
* [47674469](https://news.social-protocols.org/stats?id=47674469) #22 4 points 0 comments -> [10 Enduring Lessons from Adam Smith](https://thedailyeconomy.org/article/the-wealth-of-nations-at-250-ten-profound-quotations-from-adam-smith/)<!-- HN:47674469:end --><!-- HN:47674786:start -->
* [47674786](https://news.social-protocols.org/stats?id=47674786) #19 17 points 6 comments -> [The best tools for sending an email if you go silent](https://blog.alcazarsec.com/posts/best-email-dead-mans-switches)<!-- HN:47674786:end --><!-- HN:47681954:start -->
* [47681954](https://news.social-protocols.org/stats?id=47681954) #20 5 points 4 comments -> [Is your app idea worth building?](https://www.build-check.com/)<!-- HN:47681954:end --><!-- HN:47615041:start -->
* [47615041](https://news.social-protocols.org/stats?id=47615041) #19 10 points 1 comments -> [Developer relations after the cheat code machine](https://sunilpai.dev/posts/developer-relations/)<!-- HN:47615041:end -->
#### **Wednesday, April 8, 2026**
<!-- HN:47682500:start -->
* [47682500](https://news.social-protocols.org/stats?id=47682500) #16 11 points 1 comments -> [USCIS.gov sends user/visitor data to Meta and Google](https://varlog.in/inspect/)<!-- HN:47682500:end --><!-- HN:47683033:start -->
* [47683033](https://news.social-protocols.org/stats?id=47683033) #11 10 points 1 comments -> [US, Iran say they have agreed to a two-week ceasefire](https://apnews.com/live/iran-war-israel-trump-04-07-2026)<!-- HN:47683033:end --><!-- HN:47688947:start -->
* [47688947](https://news.social-protocols.org/stats?id=47688947) #13 3 points 1 comments -> [Trier OS – Industrial Operating System](https://github.com/DougTrier/trier-os)<!-- HN:47688947:end --><!-- HN:47691363:start -->
* [47691363](https://news.social-protocols.org/stats?id=47691363) #7 18 points 22 comments -> [F-35 Got Hit](https://www.shatterbelt.co/articles/f35-got-hit)<!-- HN:47691363:end --><!-- HN:47692102:start -->
* [47692102](https://news.social-protocols.org/stats?id=47692102) #3 188 points 137 comments -> [Muse Spark – Meta Superintelligence Labs](https://meta.ai/)<!-- HN:47692102:end --><!-- HN:47663285:start -->
* [47663285](https://news.social-protocols.org/stats?id=47663285) #22 35 points 33 comments -> [Why do Macs ask you to press random keys when connecting a new keyboard?](https://unsung.aresluna.org/why-do-macs-ask-you-to-press-random-keys-when-connecting-a-new-keyboard/)<!-- HN:47663285:end -->