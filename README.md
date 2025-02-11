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

#### **Wednesday, February 5, 2025**
<!-- HN:42940284:start -->
* [42940284](https://news.social-protocols.org/stats?id=42940284) #5 230 points 3 comments -> [Google removes pledge to not use AI for weapons from website](https://techcrunch.com/2025/02/04/google-removes-pledge-to-not-use-ai-for-weapons-from-website/)<!-- HN:42940284:end --><!-- HN:42946046:start -->
* [42946046](https://news.social-protocols.org/stats?id=42946046) #12 125 points 77 comments -> [Carl Sagan Predicts the Decline of America (1995)](https://www.openculture.com/2025/02/carl-sagan-predicts-the-decline-of-america-unable-to-know-whats-true.html)<!-- HN:42946046:end --><!-- HN:42951959:start -->
* [42951959](https://news.social-protocols.org/stats?id=42951959) #16 10 points 0 comments -> [Project 2025](https://www.project2025.org/)<!-- HN:42951959:end --><!-- HN:42952330:start -->
* [42952330](https://news.social-protocols.org/stats?id=42952330) #30 6 points 1 comments -> [Google drops pledge not to use AI for weapons, surveillance](https://www.aljazeera.com/economy/2025/2/5/chk_google-drops-pledge-not-to-use-ai-for-weapons-surveillance)<!-- HN:42952330:end --><!-- HN:42917338:start -->
* [42917338](https://news.social-protocols.org/stats?id=42917338) #22 5 points 1 comments -> [How to Prepare Your Next RPG Campaign Instantly](https://rpgtabletops.com/products/the-ultimate-maps-bundle)<!-- HN:42917338:end -->
#### **Thursday, February 6, 2025**
<!-- HN:42957617:start -->
* [42957617](https://news.social-protocols.org/stats?id=42957617) #28 5 points 1 comments -> ['Accidental' FBI Chief Builds a Following as Agency's Defender](https://www.nytimes.com/2025/02/04/us/politics/fbi-director-brian-driscoll-trump-justice-department.html)<!-- HN:42957617:end --><!-- HN:42957874:start -->
* [42957874](https://news.social-protocols.org/stats?id=42957874) #27 -> [Of Course It's a Coup](https://snyder.substack.com/p/of-course-its-a-coup)<!-- HN:42957874:end --><!-- HN:42958286:start -->
* [42958286](https://news.social-protocols.org/stats?id=42958286) #4 7 points 0 comments -> [Department of Government Efficiency Live Tracker](https://doge-tracker.com/)<!-- HN:42958286:end --><!-- HN:42958257:start -->
* [42958257](https://news.social-protocols.org/stats?id=42958257) #22 21 points 2 comments -> [NOAA Employees Told to Pause Work with 'Foreign Nationals'](https://www.wired.com/story/noaa-employees-foreign-nationals/)<!-- HN:42958257:end --><!-- HN:42959260:start -->
* [42959260](https://news.social-protocols.org/stats?id=42959260) #5 125 points 5 comments -> [America's Dangerous Movement Toward Oligarchy, Authoritarianism and Kleptocracy](https://www.counterpunch.org/2025/02/04/americas-dangerous-movement-toward-oligarchy-authoritarianism-and-kleptocracy/)<!-- HN:42959260:end --><!-- HN:42930161:start -->
* [42930161](https://news.social-protocols.org/stats?id=42930161) #6 13 points 2 comments -> [Alpine Linux Seeking Support After Equinix Metal Sunsets](https://alpinelinux.org/posts/Seeking-Support-After-Equinix-Metal-Sunsets.html)<!-- HN:42930161:end --><!-- HN:42959440:start -->
* [42959440](https://news.social-protocols.org/stats?id=42959440) #17 49 points 2 comments -> [Google scraps diversity 'aspirations,' citing role as federal contractor](https://www.cnbc.com/2025/02/05/google-scraps-diversity-aspirations-as-a-federal-contractor.html)<!-- HN:42959440:end --><!-- HN:42959777:start -->
* [42959777](https://news.social-protocols.org/stats?id=42959777) #16 16 points 7 comments -> [LLMs Were Backdoored Years Ago](https://remyhax.xyz/posts/plagairism/)<!-- HN:42959777:end --><!-- HN:42961192:start -->
* [42961192](https://news.social-protocols.org/stats?id=42961192) #15 13 points 3 comments -> [Tesla's sales plummet across Europe](https://www.ft.com/content/ea2329e4-b4bc-4e2d-be34-e9a8ea31129c)<!-- HN:42961192:end --><!-- HN:42962183:start -->
* [42962183](https://news.social-protocols.org/stats?id=42962183) #1 33 points 9 comments -> [Republican Congressman Introduces Bill Seeking Abolishment of OSHA](https://www.hipaajournal.com/biggs-nulify-occupational-safety-health-administration-act-nosha/)<!-- HN:42962183:end --><!-- HN:42958012:start -->
* [42958012](https://news.social-protocols.org/stats?id=42958012) #5 105 points 6 comments -> [Deep Reinforcement Learning: Pong from Pixels (2016)](http://karpathy.github.io/2016/05/31/rl/)<!-- HN:42958012:end --><!-- HN:42949390:start -->
* [42949390](https://news.social-protocols.org/stats?id=42949390) #13 424 points 163 comments -> [Servo's progress in 2024](https://servo.org/blog/2025/01/31/servo-in-2024/)<!-- HN:42949390:end --><!-- HN:42960291:start -->
* [42960291](https://news.social-protocols.org/stats?id=42960291) #21 128 points 30 comments -> [Cloudflare R2 Global Outage](https://www.cloudflarestatus.com)<!-- HN:42960291:end --><!-- HN:42962015:start -->
* [42962015](https://news.social-protocols.org/stats?id=42962015) #25 28 points 16 comments -> [The Sad Math of Ads: messages of inadequacy and salvation through consumption](https://www.jamesdamore.com/articles/the-sad-math-of-ads)<!-- HN:42962015:end --><!-- HN:42962545:start -->
* [42962545](https://news.social-protocols.org/stats?id=42962545) #18 19 points 1 comments -> [Thailand cuts power and internet to areas of Myanmar to disrupt scam gangs](https://www.bitdefender.com/en-us/blog/hotforsecurity/thailand-cuts-power-and-internet-to-areas-of-myanmar-to-disrupt-scam-gangs)<!-- HN:42962545:end --><!-- HN:42962127:start -->
* [42962127](https://news.social-protocols.org/stats?id=42962127) #26 36 points 28 comments -> [FDIC has released 175 internal documents on "Operation Chokepoint 2.0"](https://www.fdic.gov/foia/correspondence-related-crypto-related-activities)<!-- HN:42962127:end --><!-- HN:42964166:start -->
* [42964166](https://news.social-protocols.org/stats?id=42964166) #27 10 points 3 comments -> ["Silicon Valley built the modern world. Why shouldn't we run it?"](https://twitter.com/Shedletsky/status/1886563357249212846)<!-- HN:42964166:end --><!-- HN:42963993:start -->
* [42963993](https://news.social-protocols.org/stats?id=42963993) #21 7 points 1 comments -> [Public services are for users, not providers](https://www.slowboring.com/p/public-services-are-for-users-not)<!-- HN:42963993:end --><!-- HN:42964424:start -->
* [42964424](https://news.social-protocols.org/stats?id=42964424) #6 9 points 5 comments -> [Show HN: Make your YC application stand out (Spring 2025 edition)](https://ycscore.com)<!-- HN:42964424:end --><!-- HN:42961046:start -->
* [42961046](https://news.social-protocols.org/stats?id=42961046) #5 8 points 1 comments -> [Java JIT Compiler and Runtime in Common Lisp](https://github.com/atgreen/openldk)<!-- HN:42961046:end --><!-- HN:42965336:start -->
* [42965336](https://news.social-protocols.org/stats?id=42965336) #26 5 points 2 comments -> [AI tool to create well-written LinkedIn posts in seconds](https://contentin.app/)<!-- HN:42965336:end -->
#### **Friday, February 7, 2025**<!-- HN:42967989:start -->
* [42967989](https://news.social-protocols.org/stats?id=42967989) #24 27 points 2 comments -> [White House budget proposal could shatter the National Science Foundation](https://arstechnica.com/science/2025/02/white-house-budget-proposal-could-shatter-the-national-science-foundation/)<!-- HN:42967989:end --><!-- HN:42968435:start -->
* [42968435](https://news.social-protocols.org/stats?id=42968435) #17 8 points 1 comments -> [Doge Treasury Agent Reportedly Resigns After Racist Posts](https://www.forbes.com/sites/mollybohannon/2025/02/06/doge-treasury-agent-reportedly-resigns-after-racist-posts-heres-what-to-know-about-musks-agency/)<!-- HN:42968435:end --><!-- HN:42968995:start -->
* [42968995](https://news.social-protocols.org/stats?id=42968995) #14 14 points 3 comments -> [Andreessen Horowitz Defends Hiring of Daniel Penny to Its Investors](https://www.nytimes.com/2025/02/05/technology/daniel-penny-andreessen-horowitz-investors.html)<!-- HN:42968995:end --><!-- HN:42969643:start -->
* [42969643](https://news.social-protocols.org/stats?id=42969643) #3 20 points 11 comments -> [Show HN: I built an AI satirical news site because news was depressing me](https://thescallion.netlify.app/)<!-- HN:42969643:end --><!-- HN:42970411:start -->
* [42970411](https://news.social-protocols.org/stats?id=42970411) #19 7 points 1 comments -> [Doge Engineer Resigns After Racist Eugenics Remarks Revealed](https://www.commondreams.org/news/doge-account-racist-marko-elez)<!-- HN:42970411:end --><!-- HN:42926845:start -->
* [42926845](https://news.social-protocols.org/stats?id=42926845) #18 35 points 41 comments -> [If your customers don't talk, NPS is a vanity metric](https://www.elliotcsmith.com/if-your-customers-dont-talk-nps-is-a-vanity-metric/)<!-- HN:42926845:end --><!-- HN:42970776:start -->
* [42970776](https://news.social-protocols.org/stats?id=42970776) #9 53 points 40 comments -> [Is the use of reCAPTCHA GDPR-compliant?](https://dg-datenschutz.de/ist_die_verwendung_von_recaptcha_dsgvo_konform/)<!-- HN:42970776:end --><!-- HN:42971116:start -->
* [42971116](https://news.social-protocols.org/stats?id=42971116) #13 5 points 0 comments -> [How to Not Get Fired in 2025](https://startupbaniya.com/how-to-not-get-fired-2025)<!-- HN:42971116:end --><!-- HN:42971609:start -->
* [42971609](https://news.social-protocols.org/stats?id=42971609) #24 3 points 0 comments -> [Podcasts probably have the lowest information density of any medium ever created](https://twitter.com/0x49fa98/status/1887522746147459484)<!-- HN:42971609:end --><!-- HN:42972315:start -->
* [42972315](https://news.social-protocols.org/stats?id=42972315) #4 13 points 8 comments -> [Rewrote 42k lines of code from Python to Go. Technical deep dive](https://lovable.dev/blog/from-python-to-go)<!-- HN:42972315:end --><!-- HN:42972431:start -->
* [42972431](https://news.social-protocols.org/stats?id=42972431) #11 8 points 1 comments -> [Asahi Linux Lead Developer Hector Martin Steps Down](https://www.phoronix.com/news/Asahi-Linux-Lead-No-Upstream)<!-- HN:42972431:end --><!-- HN:42970039:start -->
* [42970039](https://news.social-protocols.org/stats?id=42970039) #13 315 points 87 comments -> [Harvard preserving for public use data.gov datasets](https://lil.law.harvard.edu/blog/2025/02/06/announcing-data-gov-archive/)<!-- HN:42970039:end --><!-- HN:42930301:start -->
* [42930301](https://news.social-protocols.org/stats?id=42930301) #15 37 points 12 comments -> [Experience the DeepSeek R1 Distilled 'Reasoning' Models on Ryzen AI and Radeon](https://community.amd.com/t5/ai/experience-the-deepseek-r1-distilled-reasoning-models-on-amd/ba-p/740593)<!-- HN:42930301:end --><!-- HN:42971470:start -->
* [42971470](https://news.social-protocols.org/stats?id=42971470) #23 27 points 15 comments -> [OpenAI cofounder John Schulman is joining Mira Murati's startup](https://finance.yahoo.com/news/openai-cofounder-john-schulman-joining-211110685.html)<!-- HN:42971470:end --><!-- HN:42972129:start -->
* [42972129](https://news.social-protocols.org/stats?id=42972129) #26 11 points 0 comments -> [UK government reportedly demands Apple backdoor to encrypted cloud data](https://techcrunch.com/2025/02/07/uk-government-demands-apple-backdoor-to-encrypted-cloud-data-report/)<!-- HN:42972129:end --><!-- HN:42972996:start -->
* [42972996](https://news.social-protocols.org/stats?id=42972996) #21 7 points 0 comments -> [U.K. orders Apple to let it spy on users' encrypted accounts](https://www.msn.com/en-us/news/technology/uk-orders-apple-to-let-it-spy-on-users-encrypted-accounts/ar-AA1yzETB)<!-- HN:42972996:end --><!-- HN:42971144:start -->
* [42971144](https://news.social-protocols.org/stats?id=42971144) #19 47 points 31 comments -> [Boeing reports Starliner losses of more than half a billion dollars in 2024](https://spacenews.com/boeing-reports-starliner-losses-of-more-than-half-a-billion-dollars-in-2024/)<!-- HN:42971144:end --><!-- HN:42971875:start -->
* [42971875](https://news.social-protocols.org/stats?id=42971875) #27 -> [The Culture Scene Is Total Madness](https://www.honest-broker.com/p/the-culture-scene-is-total-madness)<!-- HN:42971875:end --><!-- HN:42971146:start -->
* [42971146](https://news.social-protocols.org/stats?id=42971146) #14 19 points 1 comments -> [Using pip to install a Large Language Model that's under 100MB](https://simonwillison.net/2025/Feb/7/pip-install-llm-smollm2/)<!-- HN:42971146:end --><!-- HN:42972380:start -->
* [42972380](https://news.social-protocols.org/stats?id=42972380) #14 17 points 4 comments -> [Entity-Component-System Architecture in Kubernetes](https://fancl20.github.io/contents/00-posts/2025-02-07-ecs-and-k8s.html)<!-- HN:42972380:end --><!-- HN:42972854:start -->
* [42972854](https://news.social-protocols.org/stats?id=42972854) #29 9 points 14 comments -> [AI dialogue analysis confirms movies have grown more violent over past 70 years](https://phys.org/news/2025-02-ai-driven-dialogue-analysis-popular.html)<!-- HN:42972854:end --><!-- HN:42972722:start -->
* [42972722](https://news.social-protocols.org/stats?id=42972722) #6 27 points 9 comments -> [Personal Software Is Becoming a Trend](https://xuanwo.io/links/2025/02/personal-software-is-becoming-a-trend/)<!-- HN:42972722:end --><!-- HN:42972678:start -->
* [42972678](https://news.social-protocols.org/stats?id=42972678) #20 27 points 7 comments -> [Multiple security flaws found in DeepSeek iOS app, incl sending unencrypted data](https://9to5mac.com/2025/02/07/multiple-security-flaws-found-in-deepseek-ios-app-including-sending-unencrypted-data/)<!-- HN:42972678:end --><!-- HN:42972910:start -->
* [42972910](https://news.social-protocols.org/stats?id=42972910) #28 12 points 0 comments -> [Gleam v1.8.0 Released](https://gleam.run/news/gleam-gets-rename-variable/)<!-- HN:42972910:end --><!-- HN:42973989:start -->
* [42973989](https://news.social-protocols.org/stats?id=42973989) #28 15 points 12 comments -> [AI Startup School with Elon Musk, Satya Nadella, Sam Altman, Andrej Karpathy](https://events.ycombinator.com/ai-sus)<!-- HN:42973989:end --><!-- HN:42975057:start -->
* [42975057](https://news.social-protocols.org/stats?id=42975057) #24 4 points 0 comments -> [A fourth federal agency locks its doors to Democratic lawmakers](https://www.axios.com/2025/02/07/house-democrats-education-department-doge-musk)<!-- HN:42975057:end --><!-- HN:42975431:start -->
* [42975431](https://news.social-protocols.org/stats?id=42975431) #27 16 points 0 comments -> [This ain't the Apprentice. Stop Calling Them Firings. They're Purges](https://talkingpointsmemo.com/morning-memo/this-aint-the-apprentice-stop-calling-them-firings-theyre-purges)<!-- HN:42975431:end --><!-- HN:42976352:start -->
* [42976352](https://news.social-protocols.org/stats?id=42976352) #27 4 points 0 comments -> [GCC 15 Compiler Showing Off Nice Performance Improvements on AMD Zen 5](https://www.phoronix.com/review/gcc-15-amd-zen5/4)<!-- HN:42976352:end --><!-- HN:42976278:start -->
* [42976278](https://news.social-protocols.org/stats?id=42976278) #28 3 points 0 comments -> [Commenters Cry Foul After Popular Silicon Valley Forum Bans Politics (2016)](https://www.buzzfeednews.com/article/nitashatiku/silicon-valleys-most-popular-forum-bans-stories-about-politi)<!-- HN:42976278:end --><!-- HN:42936253:start -->
* [42936253](https://news.social-protocols.org/stats?id=42936253) #18 25 points 4 comments -> [Don't Delegate Understanding](https://stephango.com/understand)<!-- HN:42936253:end --><!-- HN:42976716:start -->
* [42976716](https://news.social-protocols.org/stats?id=42976716) #9 7 points 0 comments -> [The Purge – By Dan Rather and Team Steady](https://steady.substack.com/p/the-purge)<!-- HN:42976716:end --><!-- HN:42977332:start -->
* [42977332](https://news.social-protocols.org/stats?id=42977332) #29 53 points 8 comments -> [Long Covid impacting more than 1M children: CDC study suggests](https://abcnews.go.com/Health/long-covid-impacting-1-million-children-cdc-study/story?id=118393880)<!-- HN:42977332:end --><!-- HN:42978060:start -->
* [42978060](https://news.social-protocols.org/stats?id=42978060) #29 16 points 0 comments -> [Surely You're a Creep, Mr. Feynman (2019)](https://thebaffler.com/outbursts/surely-youre-a-creep-mr-feynman-mcneill)<!-- HN:42978060:end --><!-- HN:42978228:start -->
* [42978228](https://news.social-protocols.org/stats?id=42978228) #5 6 points 3 comments -> [Consistent Jailbreaking Method in o1, o3, and 4o](https://generalanalysis.com/blog/jailbreaking_techniques)<!-- HN:42978228:end --><!-- HN:42978758:start -->
* [42978758](https://news.social-protocols.org/stats?id=42978758) #28 5 points 0 comments -> [Gleichschaltung](https://en.wikipedia.org/wiki/Gleichschaltung)<!-- HN:42978758:end -->
#### **Saturday, February 8, 2025**
<!-- HN:42979855:start -->
* [42979855](https://news.social-protocols.org/stats?id=42979855) #11 8 points 4 comments -> [Aliens Cause Global Warming – Michael Crichton [pdf]](https://stephenschneider.stanford.edu/Publications/PDF_Papers/Crichton2003.pdf)<!-- HN:42979855:end --><!-- HN:42953044:start -->
* [42953044](https://news.social-protocols.org/stats?id=42953044) #7 7 points 1 comments -> [25 Years Ago, Joan Didion Kept a Diary. It's About to Become Public](https://www.nytimes.com/2025/02/05/books/new-book-joan-didion-notes-to-john.html)<!-- HN:42953044:end --><!-- HN:42938235:start -->
* [42938235](https://news.social-protocols.org/stats?id=42938235) #22 22 points 4 comments -> [Unobtanium 6502 based KIM-1 part now obtanium with FPGA](https://blog.paulsajna.com/fpga-mcs6530-rriot/)<!-- HN:42938235:end --><!-- HN:42983180:start -->
* [42983180](https://news.social-protocols.org/stats?id=42983180) #15 4 points 4 comments -> [The Puzzle](https://silence.bearblog.dev/the-puzzle/)<!-- HN:42983180:end --><!-- HN:42983148:start -->
* [42983148](https://news.social-protocols.org/stats?id=42983148) #13 47 points 32 comments -> [Show HN: FreeDemandLetter – A Weapon for Anyone Who's Sick of Getting Shafted](https://www.freedemandletter.com)<!-- HN:42983148:end --><!-- HN:42954058:start -->
* [42954058](https://news.social-protocols.org/stats?id=42954058) #15 21 points 5 comments -> [Global Caps Lock Key](https://globalcapslock.com)<!-- HN:42954058:end --><!-- HN:42956261:start -->
* [42956261](https://news.social-protocols.org/stats?id=42956261) #15 6 points 6 comments -> [I Applied Wavelet Transforms to AI and Found Hidden Structure](https://zenodo.org/records/14799070)<!-- HN:42956261:end --><!-- HN:42986335:start -->
* [42986335](https://news.social-protocols.org/stats?id=42986335) #13 47 points 21 comments -> [Mark Zuckerberg messages Facebook engineer](https://twitter.com/TechEmails/status/1888313183024074910)<!-- HN:42986335:end -->
#### **Sunday, February 9, 2025**
<!-- HN:42949631:start -->
* [42949631](https://news.social-protocols.org/stats?id=42949631) #14 11 points 7 comments -> [Who Is Being Excluded by Museums' Wholesale Adoption of Digital Technology?](https://amuseumfornow.com/blog/who-is-being-excluded-by-museums-wholesale-adoption-of-digital-technology)<!-- HN:42949631:end --><!-- HN:42961442:start -->
* [42961442](https://news.social-protocols.org/stats?id=42961442) #28 13 points 10 comments -> [Enter OpenEuroLLM, an 'Open, Compliant, Diverse' Series of Foundation Models](https://slator.com/enter-openeurollm-open-compliant-diverse-series-of-foundation-models/)<!-- HN:42961442:end --><!-- HN:42988416:start -->
* [42988416](https://news.social-protocols.org/stats?id=42988416) #30 5 points 1 comments -> [Scientists just cracked the perfect boiled egg](https://www.pbs.org/newshour/science/scientists-just-cracked-the-perfect-boiled-egg)<!-- HN:42988416:end --><!-- HN:42988706:start -->
* [42988706](https://news.social-protocols.org/stats?id=42988706) #27 8 points 1 comments -> [Experts Call for an Immediate Ban on Magic Sponges for Household Cleaning](https://jasondeegan.com/experts-call-for-an-immediate-ban-on-magic-sponges-for-household-cleaning/)<!-- HN:42988706:end --><!-- HN:42986149:start -->
* [42986149](https://news.social-protocols.org/stats?id=42986149) #25 53 points 8 comments -> [Ada Gems (2014)](https://www.adacore.com/gems)<!-- HN:42986149:end --><!-- HN:42946223:start -->
* [42946223](https://news.social-protocols.org/stats?id=42946223) #26 194 points 59 comments -> [RISC-V Mainboard for Framework Laptop 13 is now available](https://frame.work/gb/en/blog/risc-v-mainboard-for-framework-laptop-13-is-now-available)<!-- HN:42946223:end --><!-- HN:42989306:start -->
* [42989306](https://news.social-protocols.org/stats?id=42989306) #23 7 points 1 comments -> [FOSDEM 2025 – How we are defending Software Freedom against Apple at the EU's h [video]](https://fosdem.org/2025/schedule/event/fosdem-2025-5084-how-we-are-defending-software-freedom-against-apple-at-the-eu-s-highest-court/)<!-- HN:42989306:end --><!-- HN:42990037:start -->
* [42990037](https://news.social-protocols.org/stats?id=42990037) #21 9 points 2 comments -> [Things USAID has funded [video]](https://www.youtube.com/watch?v=Pdw31c6HPCI)<!-- HN:42990037:end --><!-- HN:42990401:start -->
* [42990401](https://news.social-protocols.org/stats?id=42990401) #17 13 points 1 comments -> [Frontier AI systems have surpassed the self-replicating red line](https://arxiv.org/abs/2412.12140)<!-- HN:42990401:end --><!-- HN:42986485:start -->
* [42986485](https://news.social-protocols.org/stats?id=42986485) #19 205 points 163 comments -> [Is Software Abstraction Killing Civilization? (2021)](https://datagubbe.se/endofciv/)<!-- HN:42986485:end --><!-- HN:42990815:start -->
* [42990815](https://news.social-protocols.org/stats?id=42990815) #19 7 points 2 comments -> [TikTok Almost Won the Presidency for Romania's Far-Right Candidate](https://context.ro/how-tiktok-almost-won-the-presidency-for-romanias-far-right-candidate/)<!-- HN:42990815:end --><!-- HN:42991750:start -->
* [42991750](https://news.social-protocols.org/stats?id=42991750) #10 13 points 1 comments -> [CFPB 404: Page not found](https://www.consumerfinance.gov/)<!-- HN:42991750:end --><!-- HN:42971675:start -->
* [42971675](https://news.social-protocols.org/stats?id=42971675) #19 3 points 0 comments -> [René Girard and the Mimetic Trap](https://onepercentrule.substack.com/p/the-mimetic-trap)<!-- HN:42971675:end --><!-- HN:42992304:start -->
* [42992304](https://news.social-protocols.org/stats?id=42992304) #14 -> [Teen on Musk's DOGE Team Graduated from 'The Com'](https://krebsonsecurity.com/2025/02/teen-on-musks-doge-team-graduated-from-the-com/)<!-- HN:42992304:end --><!-- HN:42992365:start -->
* [42992365](https://news.social-protocols.org/stats?id=42992365) #13 5 points 1 comments -> [The "Need for Chaos" Voter](https://www.forkingpaths.co/p/the-need-for-chaos-voter-a68)<!-- HN:42992365:end --><!-- HN:42991830:start -->
* [42991830](https://news.social-protocols.org/stats?id=42991830) #15 19 points 40 comments -> [Mission Accomplished? Heat pump adoption has a long way to go](https://www.heatpumped.org/p/mission-accomplished-heat-pump-adoption-has-a-long-way-to-go)<!-- HN:42991830:end --><!-- HN:42994006:start -->
* [42994006](https://news.social-protocols.org/stats?id=42994006) #3 -> [Artifical ballot generation script by DOGE Engineer Ethan Shaotran](https://github.com/DevrathIyer/ballotproof/blob/master/generate.py)<!-- HN:42994006:end --><!-- HN:42994281:start -->
* [42994281](https://news.social-protocols.org/stats?id=42994281) #25 9 points 0 comments -> [Keir Starmer appoints Jeff Bezos as his "first buddy"](https://pluralistic.net/2025/01/22/autocrats-of-trade/)<!-- HN:42994281:end --><!-- HN:42993661:start -->
* [42993661](https://news.social-protocols.org/stats?id=42993661) #10 34 points 40 comments -> [Music Generation AI Models](https://www.maximepeabody.com/blog/music-ai-models)<!-- HN:42993661:end --><!-- HN:42995174:start -->
* [42995174](https://news.social-protocols.org/stats?id=42995174) #6 7 points 0 comments -> [DOGE Exposes Once-Secret Government Networks, Making Cyber-Espionage Easier Than](https://cyberintel.substack.com/p/doge-exposes-once-secret-government)<!-- HN:42995174:end -->
#### **Monday, February 10, 2025**
<!-- HN:42995524:start -->
* [42995524](https://news.social-protocols.org/stats?id=42995524) #30 13 points 0 comments -> [IT Unemployment Rises to 5.7% as AI Hits Tech Jobs](https://www.wsj.com/articles/it-unemployment-rises-to-5-7-as-ai-hits-tech-jobs-7726bb1b)<!-- HN:42995524:end --><!-- HN:42995453:start -->
* [42995453](https://news.social-protocols.org/stats?id=42995453) #2 18 points 5 comments -> [Clark County Election Analysis](https://electiontruthalliance.org/2024-us-election-analysis)<!-- HN:42995453:end --><!-- HN:42971044:start -->
* [42971044](https://news.social-protocols.org/stats?id=42971044) #21 15 points 0 comments -> [Why We Chose the Name Attio](https://attio.com/blog/how-we-chose-the-name-attio)<!-- HN:42971044:end --><!-- HN:42995886:start -->
* [42995886](https://news.social-protocols.org/stats?id=42995886) #1 -> [USPS Is a Failed Sovereign Wealth Fund](https://gopostal.substack.com/p/usps-is-a-failed-sovereign-wealth)<!-- HN:42995886:end --><!-- HN:42996690:start -->
* [42996690](https://news.social-protocols.org/stats?id=42996690) #1 8 points 1 comments -> [WTF Are Popcorn Tasks?](https://madole.xyz/blog/wtf-are-popcorn-tasks)<!-- HN:42996690:end --><!-- HN:42997285:start -->
* [42997285](https://news.social-protocols.org/stats?id=42997285) #11 9 points 1 comments -> [Judge denies union demand to block DOGE's access to Labor Department data](https://www.politico.com/news/2025/02/07/judge-denies-lawsuit-union-musk-doge-labor-department-00203245)<!-- HN:42997285:end --><!-- HN:42995403:start -->
* [42995403](https://news.social-protocols.org/stats?id=42995403) #24 35 points 40 comments -> [Reflect Orbital: Sunlight after dark using a constellation of spatial reflectors](https://www.reflectorbital.com/)<!-- HN:42995403:end --><!-- HN:42999044:start -->
* [42999044](https://news.social-protocols.org/stats?id=42999044) #24 29 points 40 comments -> [Man who lost Bitcoin fortune in Welsh tip explores purchase of entire landfill](https://www.theguardian.com/technology/2025/feb/10/man-who-lost-bitcoin-fortune-in-welsh-tip-explores-purchase-of-entire-landfill)<!-- HN:42999044:end --><!-- HN:42999742:start -->
* [42999742](https://news.social-protocols.org/stats?id=42999742) #23 3 points 0 comments -> [AI is accelerating scientific production, not progress](https://twitter.com/random_walker/status/1888919433671843947)<!-- HN:42999742:end --><!-- HN:42999672:start -->
* [42999672](https://news.social-protocols.org/stats?id=42999672) #15 11 points 3 comments -> [Python 3.14 Getting New Interpreter](https://docs.python.org/3.14/whatsnew/3.14.html#whatsnew314-tail-call)<!-- HN:42999672:end --><!-- HN:42997647:start -->
* [42997647](https://news.social-protocols.org/stats?id=42997647) #28 98 points 96 comments -> [Apple's Best Option: Decentralize iCloud](https://www.mnot.net/blog/2025/02/09/decentralize-icloud)<!-- HN:42997647:end --><!-- HN:42999464:start -->
* [42999464](https://news.social-protocols.org/stats?id=42999464) #24 14 points 11 comments -> [The Crisis in Tech's Obsession with Junior Talent](https://medium.com/mr-plan-publication/8-out-of-10-senior-engineers-feel-undervalued-the-hidden-crisis-in-techs-obsession-with-junior-fa9cc62b1e8e)<!-- HN:42999464:end --><!-- HN:43000170:start -->
* [43000170](https://news.social-protocols.org/stats?id=43000170) #3 7 points 1 comments -> [Show HN: Hanko – Open-Source Auth and User Management for the Passkey Era](https://www.hanko.io/)<!-- HN:43000170:end --><!-- HN:42993044:start -->
* [42993044](https://news.social-protocols.org/stats?id=42993044) #21 120 points 9 comments -> [OpenStreetMap Calendar](https://osmcal.org/)<!-- HN:42993044:end --><!-- HN:42996831:start -->
* [42996831](https://news.social-protocols.org/stats?id=42996831) #17 145 points 82 comments -> [How does Ada's memory safety compare against Rust?](https://ajxs.me/blog/How_Does_Adas_Memory_Safety_Compare_Against_Rust.html)<!-- HN:42996831:end --><!-- HN:42999088:start -->
* [42999088](https://news.social-protocols.org/stats?id=42999088) #12 56 points 26 comments -> [Beavers finish seven-year dam project in two days saving – $1M](https://www.nationalgeographic.com/animals/article/beaver-dam-czech-republic)<!-- HN:42999088:end --><!-- HN:42975885:start -->
* [42975885](https://news.social-protocols.org/stats?id=42975885) #9 16 points 3 comments -> [We rewrote The NYT text editing library. Then we OSSd it. Then rewrote it again](https://smoores.dev/post/we_rewrote_nyt_text_editing/)<!-- HN:42975885:end --><!-- HN:42996322:start -->
* [42996322](https://news.social-protocols.org/stats?id=42996322) #15 95 points 106 comments -> [I Blog with Raw HTML](https://devpoga.org/i-blog-with-raw-html/)<!-- HN:42996322:end --><!-- HN:42992345:start -->
* [42992345](https://news.social-protocols.org/stats?id=42992345) #19 144 points 96 comments -> [Persistent packages on Steam Deck using Nix](https://chrastecky.dev/gaming/persistent-packages-on-steam-deck-using-nix)<!-- HN:42992345:end --><!-- HN:42994440:start -->
* [42994440](https://news.social-protocols.org/stats?id=42994440) #23 144 points 25 comments -> [Show HN: Searchable library of free audiobooks](https://booksearch.party/)<!-- HN:42994440:end --><!-- HN:43000511:start -->
* [43000511](https://news.social-protocols.org/stats?id=43000511) #10 4 points 0 comments -> [LemonTV – Cross platform torrent streaming app](https://lemontv.xyz)<!-- HN:43000511:end --><!-- HN:43002492:start -->
* [43002492](https://news.social-protocols.org/stats?id=43002492) #11 33 points 23 comments -> [The Physicians Are Healing Themselves, with Ozempic](https://www.nytimes.com/2025/02/10/health/doctors-ozempic-weight-loss.html)<!-- HN:43002492:end --><!-- HN:43003953:start -->
* [43003953](https://news.social-protocols.org/stats?id=43003953) #21 5 points 0 comments -> [Corporate "DEI" is an imperfect vehicle for deeply meaningful ideas](https://charity.wtf/2025/02/10/corporate-dei-is-an-imperfect-vehicle-for-deeply-meaningful-ideals/)<!-- HN:43003953:end --><!-- HN:42998431:start -->
* [42998431](https://news.social-protocols.org/stats?id=42998431) #15 19 points 23 comments -> [Show HN: Seen: rendering 1,000,000+ notes in &lt;1s. speed, by default](https://seen-v2.vercel.app/)<!-- HN:42998431:end --><!-- HN:43005535:start -->
* [43005535](https://news.social-protocols.org/stats?id=43005535) #5 10 points 2 comments -> [It Is a Coup](https://broligarchy.substack.com/p/it-is-a-coup)<!-- HN:43005535:end --><!-- HN:43005265:start -->
* [43005265](https://news.social-protocols.org/stats?id=43005265) #21 13 points 2 comments -> [Duolingo Handbook](https://handbook.duolingo.com)<!-- HN:43005265:end --><!-- HN:43006172:start -->
* [43006172](https://news.social-protocols.org/stats?id=43006172) #10 14 points 1 comments -> [Musk-led group makes $97.4B bid for ChatGPT maker OpenAI](https://www.bbc.co.uk/news/articles/cpdx75zgg88o)<!-- HN:43006172:end --><!-- HN:43006097:start -->
* [43006097](https://news.social-protocols.org/stats?id=43006097) #7 3 points 0 comments -> [Frontier AI systems have surpassed the self-replicating red line](https://arxiv.org/abs/2412.12140)<!-- HN:43006097:end -->
#### **Tuesday, February 11, 2025**
<!-- HN:43007564:start -->
* [43007564](https://news.social-protocols.org/stats?id=43007564) #25 30 points 22 comments -> [Google Calendar removed events like Pride and BHM; retains Black Friday](https://www.theverge.com/news/608858/google-calendar-missing-events-holidays)<!-- HN:43007564:end --><!-- HN:43007862:start -->
* [43007862](https://news.social-protocols.org/stats?id=43007862) #26 52 points 13 comments -> [Danes sign petition to buy California from U.S.](https://ktla.com/news/california/thousands-of-danes-sign-petition-to-buy-california-from-u-s/amp/)<!-- HN:43007862:end --><!-- HN:43008340:start -->
* [43008340](https://news.social-protocols.org/stats?id=43008340) #19 5 points 0 comments -> [Trump's Orders on Gender Put Science Back in the Driver's Seat](https://www.newsweek.com/trumps-orders-gender-put-science-back-drivers-seat-opinion-2027532)<!-- HN:43008340:end --><!-- HN:43008417:start -->
* [43008417](https://news.social-protocols.org/stats?id=43008417) #23 34 points 16 comments -> [What are non intelligent people like me supposed to do for money?](https://www.reddit.com/r/findapath/s/Me91Ke0COG)<!-- HN:43008417:end --><!-- HN:43009729:start -->
* [43009729](https://news.social-protocols.org/stats?id=43009729) #29 5 points 3 comments -> [Musk-led group makes $97.4B bid for ChatGPT maker OpenAI](https://www.bbc.com/news/articles/cpdx75zgg88o)<!-- HN:43009729:end --><!-- HN:43011257:start -->
* [43011257](https://news.social-protocols.org/stats?id=43011257) #11 19 points 42 comments -> [Altman: OpenAI not for sale, especially to competitor who is not able to beat us](https://www.axios.com/2025/02/11/openai-altman-musk-offer)<!-- HN:43011257:end -->