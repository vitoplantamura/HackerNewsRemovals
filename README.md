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

#### **Sunday, August 30, 2026**
<!-- HN:49494023:start -->
* [49494023](https://news.social-protocols.org/stats?id=49494023) #26 12 points 5 comments -> [Twitter (Not affiliated with X Corp)](https://twitter.now/maintenance/)<!-- HN:49494023:end --><!-- HN:49494212:start -->
* [49494212](https://news.social-protocols.org/stats?id=49494212) #28 18 points 2 comments -> [Police departments weren’t looking for Flock abuse. We did it for them.](https://www.washingtonpost.com/technology/2026/08/19/we-found-cops-who-misused-flock-their-police-departments-didnt-know/)<!-- HN:49494212:end --><!-- HN:49494049:start -->
* [49494049](https://news.social-protocols.org/stats?id=49494049) #30 4 points 0 comments -> [PCSX2 2.8.0 is now out This release is PACKED](https://pcsx2.net/blog/2026/pcsx2-2.8/)<!-- HN:49494049:end --><!-- HN:49495976:start -->
* [49495976](https://news.social-protocols.org/stats?id=49495976) #18 -> [Palestinian woman and NBC News team attacked by Israeli settlers in West Bank](https://www.nbcnews.com/world/middle-east/palestinian-nbc-news-team-attacked-masked-israeli-settlers-rcna595024)<!-- HN:49495976:end --><!-- HN:49496707:start -->
* [49496707](https://news.social-protocols.org/stats?id=49496707) #21 35 points 41 comments -> [Iceland rejects reopening talks on EU entry](https://www.ft.com/content/53b5abd8-2919-4dc6-8dd6-81fc054e8b6f)<!-- HN:49496707:end --><!-- HN:49497803:start -->
* [49497803](https://news.social-protocols.org/stats?id=49497803) #9 -> [The turbulent AI era is here. The choices we make now are critical](https://www.gatesnotes.com/home/home-page-topic/reader/a-turbulent-ai-era-and-critical-choices-to-make)<!-- HN:49497803:end --><!-- HN:49499051:start -->
* [49499051](https://news.social-protocols.org/stats?id=49499051) #10 6 points 1 comments -> [Emacs vs. Vim 2026: 24.3% vs. 8% Usage, 20x Memory Gap](https://tech-insider.org/emacs-vs-vim-2026/)<!-- HN:49499051:end --><!-- HN:49501087:start -->
* [49501087](https://news.social-protocols.org/stats?id=49501087) #30 11 points 1 comments -> [Flock's CEO Is Lying to Cops About 404 Media's Reporting on Abortion Case](https://www.404media.co/flocks-ceo-is-lying-to-cops-about-404-medias-reporting-on-abortion-case/)<!-- HN:49501087:end --><!-- HN:49501002:start -->
* [49501002](https://news.social-protocols.org/stats?id=49501002) #5 19 points 11 comments -> [Should We Have Kept the American Empire?](https://www.maximum-progress.com/p/should-we-have-kept-the-american)<!-- HN:49501002:end --><!-- HN:49502101:start -->
* [49502101](https://news.social-protocols.org/stats?id=49502101) #12 17 points 7 comments -> [I am no longer letting Claude Code add itself as Co-author in my commits](https://igupta.in/blog/why-i-am-no-longer-letting-claude-code-add-itself-as-coauthor/)<!-- HN:49502101:end --><!-- HN:49501147:start -->
* [49501147](https://news.social-protocols.org/stats?id=49501147) #29 25 points 13 comments -> [Running SQLite Apps on Docker and Kubernetes with Litestream](https://openrun.dev/blog/litestream/)<!-- HN:49501147:end --><!-- HN:49501932:start -->
* [49501932](https://news.social-protocols.org/stats?id=49501932) #9 17 points 12 comments -> [1kB Website as Status Symbol](https://async.cat/blog)<!-- HN:49501932:end --><!-- HN:49501210:start -->
* [49501210](https://news.social-protocols.org/stats?id=49501210) #22 29 points 21 comments -> [Norway Shrugged](https://paragraph.com/@hagaetc/norway-shrugged)<!-- HN:49501210:end -->
#### **Monday, August 31, 2026**
<!-- HN:49503421:start -->
* [49503421](https://news.social-protocols.org/stats?id=49503421) #12 27 points 20 comments -> [Show HN: Academa – Long-form STEM lecture videos generated by LLMs](https://academa.ai/)<!-- HN:49503421:end --><!-- HN:49504922:start -->
* [49504922](https://news.social-protocols.org/stats?id=49504922) #9 13 points 16 comments -> [CobaltC – The Successor to C?](https://strawberry9.github.io/the-wrong-memory/Appendix_06.html)<!-- HN:49504922:end --><!-- HN:49505043:start -->
* [49505043](https://news.social-protocols.org/stats?id=49505043) #27 10 points 5 comments -> [Show HN: Prove your code produced your claims without making reviewers rerun it](https://github.com/27-GROUP/kveritas-go/)<!-- HN:49505043:end --><!-- HN:49446839:start -->
* [49446839](https://news.social-protocols.org/stats?id=49446839) #14 8 points 0 comments -> [A spy satellite simulator in the browser, except the data is real](https://github.com/bilawalsidhu/gods-eye-view)<!-- HN:49446839:end --><!-- HN:49507976:start -->
* [49507976](https://news.social-protocols.org/stats?id=49507976) #4 12 points 4 comments -> [The ISBN was invented in 1970. Your books don't care](https://www.shelvd.org/blog/isbn-invented-1970)<!-- HN:49507976:end --><!-- HN:49508622:start -->
* [49508622](https://news.social-protocols.org/stats?id=49508622) #27 4 points 0 comments -> [Lake Ontario Now Called Lake America on Google Maps](https://apnews.com/article/lake-trump-ontario-america-7c5c9776d72cb8e8d782e05ec6e7332b)<!-- HN:49508622:end --><!-- HN:49508200:start -->
* [49508200](https://news.social-protocols.org/stats?id=49508200) #18 8 points 0 comments -> [The AI-Native SDLC Starts with Your Infrastructure](https://metalbear.com/blog/ai-native-sdlc-infrastructure/)<!-- HN:49508200:end --><!-- HN:49509876:start -->
* [49509876](https://news.social-protocols.org/stats?id=49509876) #5 29 points 30 comments -> [Omarchy: 1Password and 37signals become Distinguished Corporate Patrons](https://omarchy.org/news/2026/08/1password-and-37signals-become-distinguished-corporate-patrons/)<!-- HN:49509876:end --><!-- HN:49510600:start -->
* [49510600](https://news.social-protocols.org/stats?id=49510600) #12 6 points 1 comments -> [Show HN: 2x-4x cheaper GLM 5.3 for coding and research](https://www.coralbricks.ai)<!-- HN:49510600:end --><!-- HN:49510612:start -->
* [49510612](https://news.social-protocols.org/stats?id=49510612) #14 18 points 3 comments -> [Agentic Trust Controls](https://trustcontrols.ai/)<!-- HN:49510612:end --><!-- HN:49512789:start -->
* [49512789](https://news.social-protocols.org/stats?id=49512789) #30 73 points 62 comments -> [Student Teacher Arrested for Private Snapchat Message](https://www.gadgetreview.com/student-teacher-sent-a-private-snapchat-complaining-about-her-workday-an-hour-later-police-pulled-up-to-her-school)<!-- HN:49512789:end --><!-- HN:49514454:start -->
* [49514454](https://news.social-protocols.org/stats?id=49514454) #5 -> [The river of Apple's interface guidelines](https://hig.josefrichter.design/)<!-- HN:49514454:end -->
#### **Tuesday, September 1, 2026**
<!-- HN:49517420:start -->
* [49517420](https://news.social-protocols.org/stats?id=49517420) #3 61 points 4 comments -> [Tailcat: Tailscale Without Tailscale, by Tailscale](https://tailscale.com/blog/tailcat)<!-- HN:49517420:end --><!-- HN:49517483:start -->
* [49517483](https://news.social-protocols.org/stats?id=49517483) #10 20 points 0 comments -> [Is MCP Good Yet?](https://ismcpgoodyet.com)<!-- HN:49517483:end --><!-- HN:49518078:start -->
* [49518078](https://news.social-protocols.org/stats?id=49518078) #26 3 points 0 comments -> [Google Ads vs. Facebook Ads: Which Is Better for Small Businesses?](https://www.hostiqen.com/2026/08/google-ads-vs-facebook-ads-which-is.html)<!-- HN:49518078:end --><!-- HN:49518916:start -->
* [49518916](https://news.social-protocols.org/stats?id=49518916) #15 14 points 2 comments -> [1Password Supports the Ethnic Cleansing of Europe](https://www.alilleybrinker.com/blog/1password-funds-ethnic-cleansing/)<!-- HN:49518916:end --><!-- HN:49520270:start -->
* [49520270](https://news.social-protocols.org/stats?id=49520270) #18 34 points 40 comments -> [Lake Ontario ("Lake America")](https://community.openstreetmap.org/t/lake-ontario-lake-america/146975)<!-- HN:49520270:end --><!-- HN:49521192:start -->
* [49521192](https://news.social-protocols.org/stats?id=49521192) #3 5 points 1 comments -> [Nemotron 3 Ultra Explained](https://miraflow.ai/blog/nemotron-3-ultra-explained-nvidia-hybrid-mamba-moe-2026)<!-- HN:49521192:end --><!-- HN:49520229:start -->
* [49520229](https://news.social-protocols.org/stats?id=49520229) #12 6 points 4 comments -> [We Let AI Agents Rewrite a 92M-Message-a-Day Service in Go](https://www.checklyhq.com/blog/agentic-rewrite-nodejs-to-go/)<!-- HN:49520229:end --><!-- HN:49521490:start -->
* [49521490](https://news.social-protocols.org/stats?id=49521490) #7 5 points 0 comments -> [Please stop calling databases CP or AP (2015)](https://martin.kleppmann.com/2015/05/11/please-stop-calling-databases-cp-or-ap.html)<!-- HN:49521490:end --><!-- HN:49521180:start -->
* [49521180](https://news.social-protocols.org/stats?id=49521180) #5 12 points 1 comments -> [Fuck you, show me the prompt](https://hamel.dev/blog/posts/prompt/)<!-- HN:49521180:end --><!-- HN:49475924:start -->
* [49475924](https://news.social-protocols.org/stats?id=49475924) #14 19 points 3 comments -> [Benchmarking Vector Indexes](https://www.percona.com/blog/benchmarking-vector-indexes/)<!-- HN:49475924:end --><!-- HN:49523101:start -->
* [49523101](https://news.social-protocols.org/stats?id=49523101) #18 -> [Christian Employers Can Now Discriminate Against Trans People](https://theintercept.com/2026/09/01/christian-employers-settlement-gender-discrimination-eeoc/)<!-- HN:49523101:end --><!-- HN:49525576:start -->
* [49525576](https://news.social-protocols.org/stats?id=49525576) #7 14 points 0 comments -> [Fable 5.1 System Card](https://www.anthropic.com/document/claude-fable-5-1-mythos-5-1-system-card)<!-- HN:49525576:end --><!-- HN:49525496:start -->
* [49525496](https://news.social-protocols.org/stats?id=49525496) #7 65 points 11 comments -> [Claude Fable 5.1 and Claude Mythos 5.1](https://www.anthropic.com/claude-fable-and-mythos-5-1)<!-- HN:49525496:end -->
#### **Wednesday, September 2, 2026**
<!-- HN:49448019:start -->
* [49448019](https://news.social-protocols.org/stats?id=49448019) #29 52 points 11 comments -> [Specifications Don't Exist](https://www.galois.com/articles/specifications-dont-exist)<!-- HN:49448019:end --><!-- HN:49530472:start -->
* [49530472](https://news.social-protocols.org/stats?id=49530472) #8 43 points 11 comments -> [Claude Fable 5.1 made me a nice animated pelican](https://simonwillison.net/2026/Sep/1/claude-fable-5-1/)<!-- HN:49530472:end --><!-- HN:49533743:start -->
* [49533743](https://news.social-protocols.org/stats?id=49533743) #23 5 points 8 comments -> [Draft Punk – The Campaign for Alive 2027 – Alive2027.com](https://alive2027.com/)<!-- HN:49533743:end --><!-- HN:49534583:start -->
* [49534583](https://news.social-protocols.org/stats?id=49534583) #13 17 points 7 comments -> [LLM Judges Verify Presence, Not Absence: Omission Blindness in AI Clinical Notes](https://arxiv.org/abs/2608.31016)<!-- HN:49534583:end --><!-- HN:49509686:start -->
* [49509686](https://news.social-protocols.org/stats?id=49509686) #15 8 points 9 comments -> [Why can't you combine .tar.gz files with cat?](https://alexwlchan.net/2026/cat-confusion/)<!-- HN:49509686:end --><!-- HN:49535594:start -->
* [49535594](https://news.social-protocols.org/stats?id=49535594) #5 24 points 19 comments -> [HomeOS – A self-hosted family dashboard for a kitchen touchscreen](https://github.com/danialkhilji/HomeOS)<!-- HN:49535594:end --><!-- HN:49536536:start -->
* [49536536](https://news.social-protocols.org/stats?id=49536536) #27 25 points 20 comments -> [Just bury your trash: What if everything we know about recycling is wrong?](https://worksinprogress.co/issue/just-bury-your-trash/)<!-- HN:49536536:end --><!-- HN:49536180:start -->
* [49536180](https://news.social-protocols.org/stats?id=49536180) #14 18 points 27 comments -> [Dyson CameraJet: The only toothbrush with a camera and a jet](https://www.dyson.com/discover/news/latest/introducing-camerajet)<!-- HN:49536180:end --><!-- HN:49535506:start -->
* [49535506](https://news.social-protocols.org/stats?id=49535506) #26 30 points 40 comments -> [Why humanoid robots won't catch up to human workers any time soon](https://www.understandingai.org/p/why-humanoid-robots-wont-catch-up)<!-- HN:49535506:end --><!-- HN:49538007:start -->
* [49538007](https://news.social-protocols.org/stats?id=49538007) #3 74 points 16 comments -> [Gemini 3.8 Flash and 3.8 Flash Cyber](https://blog.google/innovation-and-ai/models-and-research/gemini-models/3-8-flash-and-3-8-flash-cyber/)<!-- HN:49538007:end --><!-- HN:49538481:start -->
* [49538481](https://news.social-protocols.org/stats?id=49538481) #17 19 points 0 comments -> [1Password Supports the Ethnic Cleansing of Europe](https://www.alilleybrinker.com/blog/1password-funds-ethnic-cleansing/)<!-- HN:49538481:end --><!-- HN:49539125:start -->
* [49539125](https://news.social-protocols.org/stats?id=49539125) #18 14 points 2 comments -> [1Password with an unbelievable own goal](https://birchtree.me/blog/1password-with-an-unbelievable-own-goal/)<!-- HN:49539125:end --><!-- HN:49540297:start -->
* [49540297](https://news.social-protocols.org/stats?id=49540297) #12 15 points 42 comments -> [Why do so many tools have JSON config files?](https://textlog.cc/post/895)<!-- HN:49540297:end --><!-- HN:49541149:start -->
* [49541149](https://news.social-protocols.org/stats?id=49541149) #24 62 points 2 comments -> [Introducing Muse Spark 1.3](https://research.meta.ai/blog/introducing-muse-spark-1-3)<!-- HN:49541149:end --><!-- HN:49543617:start -->
* [49543617](https://news.social-protocols.org/stats?id=49543617) #14 7 points 3 comments -> [Show HN: Every AI agrees with you. This writes your startup's obituary instead](https://theyfell.com/)<!-- HN:49543617:end -->
#### **Thursday, September 3, 2026**<!-- HN:49545547:start -->
* [49545547](https://news.social-protocols.org/stats?id=49545547) #9 12 points 25 comments -> [Wk. 6 of Vibecoding an MMO](https://eldermyr.com/)<!-- HN:49545547:end --><!-- HN:49491815:start -->
* [49491815](https://news.social-protocols.org/stats?id=49491815) #13 8 points 5 comments -> [How I turned Granola action items into to-do list](https://runnrr.io)<!-- HN:49491815:end --><!-- HN:49547681:start -->
* [49547681](https://news.social-protocols.org/stats?id=49547681) #17 26 points 2 comments -> [Your Racist Linux Distro Is Very Nice (Scott Jennings)](https://www.brokentoys.org/your-racist-linux-distro-is-very-nice/)<!-- HN:49547681:end --><!-- HN:49548285:start -->
* [49548285](https://news.social-protocols.org/stats?id=49548285) #4 9 points 2 comments -> [WASM_OS, an operating-system experiment that runs inside a browser tab](https://wasmos-production.up.railway.app)<!-- HN:49548285:end --><!-- HN:49548497:start -->
* [49548497](https://news.social-protocols.org/stats?id=49548497) #20 18 points 40 comments -> [Mark Cuban: Why US hospitals "don't know their costs"](https://www.beckershospitalreview.com/finance/mark-cuban-why-us-hospitals-dont-know-their-costs/)<!-- HN:49548497:end --><!-- HN:49554370:start -->
* [49554370](https://news.social-protocols.org/stats?id=49554370) #12 -> [GPT-6-Astra](https://openai.com/index/gpt-6-astra/)<!-- HN:49554370:end --><!-- HN:49554316:start -->
* [49554316](https://news.social-protocols.org/stats?id=49554316) #25 -> [Never Forget How Eagerly Apple and Google Coddled Fascism](https://karlbode.com/never-forget-how-eagerly-apple-and-google-coddled-fascism/)<!-- HN:49554316:end -->
#### **Friday, September 4, 2026**
<!-- HN:49559182:start -->
* [49559182](https://news.social-protocols.org/stats?id=49559182) #6 28 points 18 comments -> [1Password Replied to My Disappointment](https://nicolalosito.it/2026/09/03/1password-replied-to-my-disappointment/)<!-- HN:49559182:end --><!-- HN:49561670:start -->
* [49561670](https://news.social-protocols.org/stats?id=49561670) #22 -> [The phrase that ruins every eCommerce project: "Just connect it to our ERP."](https://shiftmag.dev/the-phrase-that-ruins-every-ecommerce-project-just-connect-it-to-our-erp-11689/)<!-- HN:49561670:end --><!-- HN:49564960:start -->
* [49564960](https://news.social-protocols.org/stats?id=49564960) #16 55 points 45 comments -> [Burnt out on a three-day week](https://jennywanger.com/articles/burnt-out-on-a-three-day-week/)<!-- HN:49564960:end --><!-- HN:49524872:start -->
* [49524872](https://news.social-protocols.org/stats?id=49524872) #11 6 points 1 comments -> [E-Paper Panel Isn't Broken: How Retained State Makes Drivers Look Buggy](https://msj.prose.sh/epaper-retained-state)<!-- HN:49524872:end --><!-- HN:49569088:start -->
* [49569088](https://news.social-protocols.org/stats?id=49569088) #17 6 points 4 comments -> [UN approves resolution in support of map that shows Africa's true size](https://www.reuters.com/world/africa/un-approves-resolution-support-map-that-shows-africas-true-size-2026-09-04/)<!-- HN:49569088:end -->
#### **Saturday, September 5, 2026**
<!-- HN:49571038:start -->
* [49571038](https://news.social-protocols.org/stats?id=49571038) #30 13 points 11 comments -> [Christmas Village shoppers no longer will be allowed to enter booths](https://www.phillyvoice.com/christmas-village-booths-ada-compliance/)<!-- HN:49571038:end --><!-- HN:49513822:start -->
* [49513822](https://news.social-protocols.org/stats?id=49513822) #6 14 points 0 comments -> [Things I Won't Work With: Straight Dimethyl Zinc](https://www.science.org/content/blog-post/things-i-won-t-work-straight-dimethyl-zinc)<!-- HN:49513822:end --><!-- HN:49577244:start -->
* [49577244](https://news.social-protocols.org/stats?id=49577244) #10 24 points 11 comments -> [Poetry book that Anthropic tried to censor](https://kk.org/cooltools/the-1930-poetry-book-that-anthropic-tried-to-censor/)<!-- HN:49577244:end --><!-- HN:49578136:start -->
* [49578136](https://news.social-protocols.org/stats?id=49578136) #14 25 points 40 comments -> [Bob and Van](https://marco.org/2026/09/04/bob-and-van)<!-- HN:49578136:end -->