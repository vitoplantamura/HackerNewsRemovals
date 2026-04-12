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
#### **Thursday, April 9, 2026**
<!-- HN:47697952:start -->
* [47697952](https://news.social-protocols.org/stats?id=47697952) #8 26 points 1 comments -> [Little Snitch for Linux – Because Nothing Else Came Close](https://obdev.at/blog/little-snitch-for-linux/)<!-- HN:47697952:end --><!-- HN:47696760:start -->
* [47696760](https://news.social-protocols.org/stats?id=47696760) #24 22 points 40 comments -> [Show HN: Tired of logic in useEffect, I built a class-based React state manager](https://thales.me/posts/why-i-built-snapstate/)<!-- HN:47696760:end --><!-- HN:47700058:start -->
* [47700058](https://news.social-protocols.org/stats?id=47700058) #7 6 points 0 comments -> [Hungary is not just an illiberal state. It is a state with a moral mission](https://www.noemamag.com/the-return-of-the-moral-state/)<!-- HN:47700058:end --><!-- HN:47706120:start -->
* [47706120](https://news.social-protocols.org/stats?id=47706120) #7 52 points 31 comments -> [EFF Logs Out of X](https://twitter.com/EFF/status/2042278157609480566)<!-- HN:47706120:end --><!-- HN:47706611:start -->
* [47706611](https://news.social-protocols.org/stats?id=47706611) #3 12 points 1 comments -> [I Let Claude Code Autonomously Run Ads for a Month](https://read.technically.dev/p/i-let-claude-code-autonomously-run)<!-- HN:47706611:end -->
#### **Friday, April 10, 2026**
<!-- HN:47648854:start -->
* [47648854](https://news.social-protocols.org/stats?id=47648854) #30 16 points 2 comments -> [Progressive encoding and decoding of 'repeated' protobuffer fields](https://schilk.co/blog/protobuffer-repeat-append/)<!-- HN:47648854:end --><!-- HN:47711964:start -->
* [47711964](https://news.social-protocols.org/stats?id=47711964) #27 33 points 20 comments -> [Sam Altman's Coworkers Say He Can Barely Code and Misunderstands Basic Concepts](https://futurism.com/artificial-intelligence/sam-altman-technical-coding)<!-- HN:47711964:end --><!-- HN:47714239:start -->
* [47714239](https://news.social-protocols.org/stats?id=47714239) #8 33 points 13 comments -> [The tool that won't let AI say anything it can't cite](https://github.com/grainulation/grainulator)<!-- HN:47714239:end --><!-- HN:47714634:start -->
* [47714634](https://news.social-protocols.org/stats?id=47714634) #5 15 points 2 comments -> [How Uv Works Under the Hood](https://noos.blog/posts/uv-how-it-works-under-the-hood/)<!-- HN:47714634:end --><!-- HN:47715618:start -->
* [47715618](https://news.social-protocols.org/stats?id=47715618) #26 12 points 0 comments -> [Untaxed hidden wealth surpasses wealth of the poorest half of humanity](https://www.oxfam.org/en/press-releases/untaxed-wealth-hidden-offshore-richest-01-surpasses-entire-wealth-poorest-half)<!-- HN:47715618:end --><!-- HN:47715530:start -->
* [47715530](https://news.social-protocols.org/stats?id=47715530) #18 3 points 0 comments -> [We're Getting the Wrong Message from Mythos](https://danielmiessler.com/blog/wrong-message-from-mythos)<!-- HN:47715530:end --><!-- HN:47716219:start -->
* [47716219](https://news.social-protocols.org/stats?id=47716219) #27 8 points 4 comments -> [Python Is Dead](https://calebfenton.substack.com/p/python-is-dead)<!-- HN:47716219:end --><!-- HN:47716412:start -->
* [47716412](https://news.social-protocols.org/stats?id=47716412) #1 334 points 94 comments -> [Microsoft suspends dev accounts for high-profile open source projects](https://www.bleepingcomputer.com/news/microsoft/microsoft-suspends-dev-accounts-for-high-profile-open-source-projects/)<!-- HN:47716412:end --><!-- HN:47716043:start -->
* [47716043](https://news.social-protocols.org/stats?id=47716043) #7 746 points 359 comments -> [France Launches Government Linux Desktop Plan as Windows Exit Begins](https://www.numerique.gouv.fr/sinformer/espace-presse/souverainete-numerique-reduction-dependances-extra-europeennes/)<!-- HN:47716043:end --><!-- HN:47718718:start -->
* [47718718](https://news.social-protocols.org/stats?id=47718718) #18 13 points 0 comments -> [Consumer sentiment plummets to record low as Iran war jacks up inflation](https://www.cnn.com/2026/04/10/economy/us-consumer-sentiment-record-low-april)<!-- HN:47718718:end --><!-- HN:47718830:start -->
* [47718830](https://news.social-protocols.org/stats?id=47718830) #4 113 points 1 comments -> [CPU-Z and HWMonitor Compromised](https://old.reddit.com/r/pcmasterrace/comments/1sh4e5l/warning_hwmonitor_163_download_on_the_official/)<!-- HN:47718830:end --><!-- HN:47721022:start -->
* [47721022](https://news.social-protocols.org/stats?id=47721022) #9 6 points 0 comments -> [How Social Media Feminised Us All](https://www.freyaindia.co.uk/p/how-social-media-feminised-us-all)<!-- HN:47721022:end --><!-- HN:47719526:start -->
* [47719526](https://news.social-protocols.org/stats?id=47719526) #28 -> [Names and faces of those killed by Israel in its April 8 massacre](https://today.lorientlejour.com/article/1502922/names-and-faces-of-those-killed-by-israel-in-its-april-8-massacre.html)<!-- HN:47719526:end --><!-- HN:47721874:start -->
* [47721874](https://news.social-protocols.org/stats?id=47721874) #14 4 points 2 comments -> [Claude AI Assistant for Microsoft Office](https://pivot.claude.ai)<!-- HN:47721874:end --><!-- HN:47721516:start -->
* [47721516](https://news.social-protocols.org/stats?id=47721516) #22 13 points 3 comments -> ["Not Even Government Agencies" - Proton's misleading marketing](https://blog.ppb1701.com/not-even-government-agencies)<!-- HN:47721516:end -->
#### **Saturday, April 11, 2026**
<!-- HN:47727387:start -->
* [47727387](https://news.social-protocols.org/stats?id=47727387) #18 33 points 40 comments -> [The Seasons Are Wrong](https://kentwalters.com/posts/seasons/)<!-- HN:47727387:end --><!-- HN:47728134:start -->
* [47728134](https://news.social-protocols.org/stats?id=47728134) #21 17 points 6 comments -> [Moooooonitoring the Cow.txt Herd](https://moooo.farm/)<!-- HN:47728134:end --><!-- HN:47728721:start -->
* [47728721](https://news.social-protocols.org/stats?id=47728721) #23 26 points 40 comments -> [Artemis II is competency porn](https://lizplank.substack.com/p/artemis-ii-is-competency-porn-and)<!-- HN:47728721:end --><!-- HN:47730963:start -->
* [47730963](https://news.social-protocols.org/stats?id=47730963) #25 8 points 0 comments -> [Brazil seizes over 1,100 weapons and 1.5 tons of drugs from US, says official](https://www.reuters.com/world/americas/brazil-seizes-over-1100-weapons-15-tons-drugs-us-says-official-2026-04-10/)<!-- HN:47730963:end --><!-- HN:47733385:start -->
* [47733385](https://news.social-protocols.org/stats?id=47733385) #22 9 points 20 comments -> [Show HN: Editing 2000 photos made me build a macOS bulk photo editor](https://apps.apple.com/us/app/rapidphoto-batch-crop-edit/id6758485661?mt=12)<!-- HN:47733385:end --><!-- HN:47734224:start -->
* [47734224](https://news.social-protocols.org/stats?id=47734224) #12 7 points 0 comments -> [Democratic AI to serve the public – OneProject.org](https://oneproject.org/how-to-make-ai-serve-the-public/)<!-- HN:47734224:end -->
#### **Sunday, April 12, 2026**
<!-- HN:47735101:start -->
* [47735101](https://news.social-protocols.org/stats?id=47735101) #5 21 points 15 comments -> [AI Job Loss Tracker](https://jobloss.ai/)<!-- HN:47735101:end --><!-- HN:47735704:start -->
* [47735704](https://news.social-protocols.org/stats?id=47735704) #18 61 points 43 comments -> [We spoke to the man making viral Lego-style AI videos for Iran](https://www.bbc.com/news/articles/cjd8jrd1vnyo)<!-- HN:47735704:end --><!-- HN:47735507:start -->
* [47735507](https://news.social-protocols.org/stats?id=47735507) #25 10 points 1 comments -> [Used Graphify to turn incidents into a queryable knowledge graph](https://github.com/Rootly-AI-Labs/rootly-graphify-importer)<!-- HN:47735507:end --><!-- HN:47671365:start -->
* [47671365](https://news.social-protocols.org/stats?id=47671365) #21 15 points 5 comments -> [Dcmake: A new CMake debugger UI](https://nullprogram.com/blog/2026/04/07/)<!-- HN:47671365:end --><!-- HN:47735927:start -->
* [47735927](https://news.social-protocols.org/stats?id=47735927) #30 -> [Excellence Is a Habit](https://www.flyingbarron.com/2026/04/excellence-is-habit.html)<!-- HN:47735927:end --><!-- HN:47736907:start -->
* [47736907](https://news.social-protocols.org/stats?id=47736907) #19 54 points 12 comments -> [Pope Leo XIV denounces the 'delusion of omnipotence' he says fuels the Iran war](https://www.politico.com/news/2026/04/11/pope-leo-xiv-denounces-the-delusion-of-omnipotence-he-says-fuels-the-us-israeli-war-in-iran-00868142)<!-- HN:47736907:end --><!-- HN:47737928:start -->
* [47737928](https://news.social-protocols.org/stats?id=47737928) #27 77 points 25 comments -> [MiniMax M2.7 Is Now Open Source](https://firethering.com/minimax-m2-7-agentic-model/)<!-- HN:47737928:end --><!-- HN:47735810:start -->
* [47735810](https://news.social-protocols.org/stats?id=47735810) #26 54 points 37 comments -> [Why meaningful days look like nothing while you are living them](https://pilgrima.ge/p/the-grand-line)<!-- HN:47735810:end --><!-- HN:47738996:start -->
* [47738996](https://news.social-protocols.org/stats?id=47738996) #15 21 points 10 comments -> [Why weekends are under threat](https://thehustle.co/originals/why-weekends-are-under-threat)<!-- HN:47738996:end --><!-- HN:47737563:start -->
* [47737563](https://news.social-protocols.org/stats?id=47737563) #10 298 points 493 comments -> [AI Will Be Met with Violence, and Nothing Good Will Come of It](https://www.thealgorithmicbridge.com/p/ai-will-be-met-with-violence-and)<!-- HN:47737563:end --><!-- HN:47742680:start -->
* [47742680](https://news.social-protocols.org/stats?id=47742680) #3 101 points 39 comments -> [Apple has removed most of the towns and villages in Lebanon from Apple maps](https://maps.apple.com/frame?center=33.723388%2C35.614698&span=1.983925%2C4.004193)<!-- HN:47742680:end --><!-- HN:47742460:start -->
* [47742460](https://news.social-protocols.org/stats?id=47742460) #25 16 points 14 comments -> [Are sugar substitutes healthier than the real thing?](https://www.economist.com/science-and-technology/2026/04/10/are-sugar-substitutes-healthier-than-the-real-thing)<!-- HN:47742460:end --><!-- HN:47743553:start -->
* [47743553](https://news.social-protocols.org/stats?id=47743553) #18 102 points 20 comments -> [Viktor Orbán concedes defeat after 'painful' election result](https://apnews.com/article/hungary-election-orban-magyar-trump-1a4eb0ba6b94e0c80c3cd18bd36254ab)<!-- HN:47743553:end -->