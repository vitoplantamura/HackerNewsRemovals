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

#### **Friday, May 9, 2025**
<!-- HN:43932278:start -->
* [43932278](https://news.social-protocols.org/stats?id=43932278) #18 11 points 6 comments -> [Gender characteristics of service robots can influence customer decisions](https://www.psu.edu/news/health-and-human-development/story/gender-characteristics-service-robots-can-influence-customer)<!-- HN:43932278:end --><!-- HN:43901081:start -->
* [43901081](https://news.social-protocols.org/stats?id=43901081) #12 23 points 9 comments -> [Show HN: OpenRouter Model Price Comparison](https://compare-openrouter-models.pages.dev/)<!-- HN:43901081:end --><!-- HN:43934781:start -->
* [43934781](https://news.social-protocols.org/stats?id=43934781) #30 7 points 1 comments -> [Realism Still Doesn't Justify Including Sexual Assault](https://mythcreants.com/blog/realism-still-doesnt-justify-including-sexual-assault/)<!-- HN:43934781:end --><!-- HN:43898956:start -->
* [43898956](https://news.social-protocols.org/stats?id=43898956) #19 8 points 0 comments -> [Fui: C library for interacting with the framebuffer in a tty context](https://github.com/martinfama/fui)<!-- HN:43898956:end --><!-- HN:43934279:start -->
* [43934279](https://news.social-protocols.org/stats?id=43934279) #10 45 points 26 comments -> [6502 Illegal Opcodes in the Siemens PC 100 Assembly Manual (1980)](https://www.pagetable.com/?p=1798)<!-- HN:43934279:end --><!-- HN:43935814:start -->
* [43935814](https://news.social-protocols.org/stats?id=43935814) #20 11 points 1 comments -> [Apple is planning smart glasses with and without AR](https://www.theverge.com/news/663600/apple-smart-glasses-chips-ar-chip)<!-- HN:43935814:end --><!-- HN:43936460:start -->
* [43936460](https://news.social-protocols.org/stats?id=43936460) #28 3 points 0 comments -> [Reincarnated by A.I., Arizona Man Forgives His Killer at Sentencing](https://www.nytimes.com/2025/05/08/us/ai-victim-impact-statement-manslaughter.html)<!-- HN:43936460:end --><!-- HN:43937396:start -->
* [43937396](https://news.social-protocols.org/stats?id=43937396) #19 7 points 1 comments -> ['Inheritance is an injustice': Why a 33-year-old redistributed €27M](https://www.lemonde.fr/en/economy/article/2025/05/08/inheritance-is-an-injustice-why-a-33-year-old-redistributed-27-million_6741060_19.html)<!-- HN:43937396:end --><!-- HN:43939834:start -->
* [43939834](https://news.social-protocols.org/stats?id=43939834) #26 6 points 0 comments -> [Bluetooth 6.1](https://www.bluetooth.com/blog/delivering-on-the-bi-annual-release-schedule-bluetooth-core-6-1-is-here/)<!-- HN:43939834:end --><!-- HN:43909774:start -->
* [43909774](https://news.social-protocols.org/stats?id=43909774) #16 13 points 0 comments -> [Some Thoughts on LCP eBook DRM](https://shkspr.mobi/blog/2025/03/some-thoughts-on-lcp-ebook-drm/)<!-- HN:43909774:end -->
#### **Saturday, May 10, 2025**
<!-- HN:43942928:start -->
* [43942928](https://news.social-protocols.org/stats?id=43942928) #8 -> [Uber Driver app can get location in background without the permissions (How?)](https://developer.apple.com/forums/thread/783227)<!-- HN:43942928:end --><!-- HN:43911197:start -->
* [43911197](https://news.social-protocols.org/stats?id=43911197) #21 8 points 0 comments -> [Running Windows.exe on a Linux Brain: The Sysadmin's Guide to Neurodivergence](https://leantime.io/running-windows-exe-on-a-linux-brain-the-sysadmins-guide-to-neurodivergence/)<!-- HN:43911197:end --><!-- HN:43943871:start -->
* [43943871](https://news.social-protocols.org/stats?id=43943871) #7 27 points 16 comments -> [Why should I care? or why punks are correct and old wise philosophers are wrong](https://abuseofnotation.github.io/moral-law/)<!-- HN:43943871:end --><!-- HN:43944809:start -->
* [43944809](https://news.social-protocols.org/stats?id=43944809) #3 39 points 39 comments -> [The Fallacy of Techno-Feudalism](https://petrapalusova.com/articles/tech-platforms-digital-economy-techno-feudalism)<!-- HN:43944809:end --><!-- HN:43945324:start -->
* [43945324](https://news.social-protocols.org/stats?id=43945324) #18 4 points 0 comments -> [The Dave and Busters Anomaly](https://www.searchengine.show/the-dave-and-busters-anomaly/)<!-- HN:43945324:end --><!-- HN:43947161:start -->
* [43947161](https://news.social-protocols.org/stats?id=43947161) #5 10 points 0 comments -> [Simon Willison's first blog on LLMs (2022)](https://simonwillison.net/2022/May/31/a-datasette-tutorial-written-by-gpt-3/)<!-- HN:43947161:end --><!-- HN:43949108:start -->
* [43949108](https://news.social-protocols.org/stats?id=43949108) #22 17 points 3 comments -> [Everyone Is Cheating Their Way Through College](https://www.msn.com/en-us/news/technology/everyone-is-cheating-their-way-through-college/ar-AA1EjCRk)<!-- HN:43949108:end -->
#### **Sunday, May 11, 2025**
<!-- HN:43950081:start -->
* [43950081](https://news.social-protocols.org/stats?id=43950081) #15 7 points 0 comments -> [Covid-19 mRNA Destroys over 60% of Non-Renewable Egg Supply](https://www.thefocalpoints.com/p/breaking-covid-19-mrna-shots-destroy)<!-- HN:43950081:end --><!-- HN:43950053:start -->
* [43950053](https://news.social-protocols.org/stats?id=43950053) #5 6 points 0 comments -> [Why I didn't attend PyCon Australia 2024](https://www.lesinskis.com/pyconau-2024.html)<!-- HN:43950053:end --><!-- HN:43950970:start -->
* [43950970](https://news.social-protocols.org/stats?id=43950970) #10 10 points 2 comments -> ["Barely Literate": U.S. Education Secretary Mocked for Grammar in Harvard Letter](https://verdaily.com/trump-education-secretary-mocked-for-grammar-errors-in-harvard-letter/)<!-- HN:43950970:end --><!-- HN:43952715:start -->
* [43952715](https://news.social-protocols.org/stats?id=43952715) #25 10 points 1 comments -> [Financial Times: The Weet Shameful Silence on Gasa's Starvation](https://www.ft.com/content/f5fd6f8d-06a7-4d1f-b842-752e3aca9272)<!-- HN:43952715:end --><!-- HN:43951943:start -->
* [43951943](https://news.social-protocols.org/stats?id=43951943) #3 26 points 40 comments -> [What is it like to be a thermostat? (1996)](https://www.organism.earth/library/document/what-is-it-like-to-be-a-thermostat)<!-- HN:43951943:end --><!-- HN:43954470:start -->
* [43954470](https://news.social-protocols.org/stats?id=43954470) #29 9 points 1 comments -> [Immunogenicity and Safety of Influenza and Covid-19 Multicomponent Vaccine](https://jamanetwork.com/journals/jama/article-abstract/2833668)<!-- HN:43954470:end --><!-- HN:43954436:start -->
* [43954436](https://news.social-protocols.org/stats?id=43954436) #29 4 points 3 comments -> [HunyuanVideo-I2V: 14B model turns an image into 720p video on 8GB GPU](https://wavespeed.ai/models/wavespeed-ai/hunyuan-video/i2v)<!-- HN:43954436:end --><!-- HN:43956630:start -->
* [43956630](https://news.social-protocols.org/stats?id=43956630) #13 10 points 9 comments -> [The Paradoxes of Feminine Muscle](https://www.newyorker.com/culture/critics-notebook/the-paradoxes-of-feminine-muscle)<!-- HN:43956630:end --><!-- HN:43957481:start -->
* [43957481](https://news.social-protocols.org/stats?id=43957481) #29 10 points 11 comments -> [Satellite will have to be turned off when it floats over the US](https://www.thecooldown.com/green-tech/biomass-satellite-carbon-capture-forests/)<!-- HN:43957481:end -->
#### **Monday, May 12, 2025**
<!-- HN:43958716:start -->
* [43958716](https://news.social-protocols.org/stats?id=43958716) #15 50 points 23 comments -> [Custom SIM card in Tesla Model 3 2024, Tesla Model Y 2025 and Cybertruck](https://olegkutkov.me/2025/05/12/custom-sim-card-in-tesla-model-3-2024-tesla-model-y-2025-and-cybertruck/)<!-- HN:43958716:end --><!-- HN:43962037:start -->
* [43962037](https://news.social-protocols.org/stats?id=43962037) #5 14 points 5 comments -> [When Compiler Engineers Act as Judges, What Can Possibly Go Wrong?](https://seylaw.blogspot.com/2025/05/when-compiler-engineers-act-as-judges.html)<!-- HN:43962037:end --><!-- HN:43962942:start -->
* [43962942](https://news.social-protocols.org/stats?id=43962942) #4 95 points 63 comments -> [Just Fucking Use HTML](https://justfuckingusehtml.com)<!-- HN:43962942:end --><!-- HN:43965354:start -->
* [43965354](https://news.social-protocols.org/stats?id=43965354) #13 -> [U.S. Nuclear Emergency Support aircraft touched down in Pakistan](https://thecommunemag.com/egyptian-plane-with-boron-us-plane-checking-radioactivity-did-india-really-hit-pakistans-nuclear-centres/)<!-- HN:43965354:end --><!-- HN:43966422:start -->
* [43966422](https://news.social-protocols.org/stats?id=43966422) #17 6 points 2 comments -> [A Proven Guide to Building Your Path to Success](https://diamantinoalmeida.com/career-strategy-a-proven-guide-to-building-your-path-to-success/)<!-- HN:43966422:end -->
#### **Tuesday, May 13, 2025**
<!-- HN:43965099:start -->
* [43965099](https://news.social-protocols.org/stats?id=43965099) #15 98 points 22 comments -> [Byte Latent Transformer: Patches Scale Better Than Tokens](https://arxiv.org/abs/2412.09871)<!-- HN:43965099:end --><!-- HN:43963868:start -->
* [43963868](https://news.social-protocols.org/stats?id=43963868) #18 446 points 135 comments -> [Embeddings Are Underrated](https://technicalwriting.dev/ml/embeddings/overview.html)<!-- HN:43963868:end --><!-- HN:43969274:start -->
* [43969274](https://news.social-protocols.org/stats?id=43969274) #7 4 points 0 comments -> [I developed an AI clothing-changing tool. Would you like to take a look?](https://www.aioutfitgen.com)<!-- HN:43969274:end --><!-- HN:43970112:start -->
* [43970112](https://news.social-protocols.org/stats?id=43970112) #5 4 points 0 comments -> [ChatGPT Blows Mapmaking 101](https://garymarcus.substack.com/p/chatgpt-blows-mapmaking-101)<!-- HN:43970112:end --><!-- HN:43969950:start -->
* [43969950](https://news.social-protocols.org/stats?id=43969950) #14 43 points 26 comments -> [Twitch star HasanAbi says he was detained, questioned by border agents](https://www.washingtonpost.com/immigration/2025/05/12/hasan-piker-detained-border-agents-twitch/)<!-- HN:43969950:end --><!-- HN:43970712:start -->
* [43970712](https://news.social-protocols.org/stats?id=43970712) #1 38 points 17 comments -> [Iceland approved 4-day workweek in 2019; six years later, predictions came true](https://farmingdale-observer.com/2025/05/10/iceland-approved-the-4-day-workweek-in-2019-nearly-6-years-later-all-the-predictions-made-have-come-true/)<!-- HN:43970712:end --><!-- HN:43971523:start -->
* [43971523](https://news.social-protocols.org/stats?id=43971523) #21 4 points 0 comments -> [Show HN: Why hanging out on Hacker News is a good use of your time?](https://www.parliant.ai/surveys/e31a7442-080b-4921-bfa4-457ef0b974ec)<!-- HN:43971523:end --><!-- HN:43972455:start -->
* [43972455](https://news.social-protocols.org/stats?id=43972455) #4 16 points 0 comments -> [Why the Poor Vote for the Right (and Stop Demanding More Equality)](https://www.unibocconi.it/en/news/why-poor-vote-right-and-stop-demanding-more-equality)<!-- HN:43972455:end --><!-- HN:43971982:start -->
* [43971982](https://news.social-protocols.org/stats?id=43971982) #13 6 points 1 comments -> [Overcoming Self-Doubt: A Practical Guide to Building Lasting Confidence](https://diamantinoalmeida.com/overcoming-self-doubt-a-practical-guide-to-building-lasting-confidence/)<!-- HN:43971982:end --><!-- HN:43972493:start -->
* [43972493](https://news.social-protocols.org/stats?id=43972493) #3 49 points 13 comments -> [How the United States Gave Up Being a Science Superpower](https://steveblank.com/2025/05/13/how-the-united-states-became-a-science-superpower-and-how-quickly-it-could-crumble/)<!-- HN:43972493:end --><!-- HN:43973353:start -->
* [43973353](https://news.social-protocols.org/stats?id=43973353) #23 15 points 0 comments -> [Coinbase joins the S&P 500, another summit scaled on towards economic freedom](https://www.coinbase.com/zh-tw/blog/Coinbase-joins-the-S&P-500-another-summit-scaled-on-Coinbase-drive-towards-economic-freedom)<!-- HN:43973353:end --><!-- HN:43974064:start -->
* [43974064](https://news.social-protocols.org/stats?id=43974064) #28 11 points 3 comments -> [Tariffs Drive Honda to Move SUV Production from Canada to U.S.](https://www.nytimes.com/2025/05/13/world/americas/honda-trump-tariffs-us-canada.html)<!-- HN:43974064:end --><!-- HN:43973518:start -->
* [43973518](https://news.social-protocols.org/stats?id=43973518) #13 12 points 6 comments -> [Understanding Java's Asynchronous Journey](https://amritpandey.io/understanding-javas-asynchronous-journey/)<!-- HN:43973518:end --><!-- HN:43974565:start -->
* [43974565](https://news.social-protocols.org/stats?id=43974565) #23 18 points 8 comments -> [GOP Senator Introduces Bill to Make All Porn a Federal Crime](https://gizmodo.com/gop-senator-introduces-bill-to-make-all-porn-a-federal-crime-following-project-2025-playbook-2000600994)<!-- HN:43974565:end --><!-- HN:43975318:start -->
* [43975318](https://news.social-protocols.org/stats?id=43975318) #12 44 points 16 comments -> [Sid Meier's Colonization](https://peyre.42web.io/Colonization/index.htm)<!-- HN:43975318:end --><!-- HN:43976726:start -->
* [43976726](https://news.social-protocols.org/stats?id=43976726) #2 9 points 3 comments -> [Programmers Will Be Replaced by People with Ideas](https://www.cleverthinkingsoftware.com/programmers-will-be-replaced-by-people-with-ideas/)<!-- HN:43976726:end -->
#### **Wednesday, May 14, 2025**
<!-- HN:43979197:start -->
* [43979197](https://news.social-protocols.org/stats?id=43979197) #9 16 points 14 comments -> [Less meat is nearly always better than sustainable meat](https://ourworldindata.org/less-meat-or-sustainable-meat)<!-- HN:43979197:end --><!-- HN:43944844:start -->
* [43944844](https://news.social-protocols.org/stats?id=43944844) #16 6 points 3 comments -> [Simplifying the Ethereum Layer 1](https://vitalik.eth.limo/general/2025/05/03/simplel1.html)<!-- HN:43944844:end --><!-- HN:43982816:start -->
* [43982816](https://news.social-protocols.org/stats?id=43982816) #16 14 points 5 comments -> [Databricks to Buy Startup Neon for $1B](https://www.wsj.com/articles/databricks-to-buy-startup-neon-for-1-billion-fdded971)<!-- HN:43982816:end --><!-- HN:43984132:start -->
* [43984132](https://news.social-protocols.org/stats?id=43984132) #19 9 points 1 comments -> [US brain drain: the scientists seeking jobs abroad amid assault on research](https://www.nature.com/articles/d41586-025-01489-y)<!-- HN:43984132:end --><!-- HN:43984409:start -->
* [43984409](https://news.social-protocols.org/stats?id=43984409) #26 3 points 0 comments -> [Making my app worse because of macOS privacy protections](https://lapcatsoftware.com/articles/2025/5/3.html)<!-- HN:43984409:end --><!-- HN:43984282:start -->
* [43984282](https://news.social-protocols.org/stats?id=43984282) #27 5 points 0 comments -> [How to Secure Your Home Wi-Fi Network from Hackers](https://www.youtube.com/watch?v=W8EIahhrw-s)<!-- HN:43984282:end --><!-- HN:43981603:start -->
* [43981603](https://news.social-protocols.org/stats?id=43981603) #16 13 points 5 comments -> [Show HN: Sam TTS – Recreates the classic Microsoft SAM voice in the browser](https://samtts.com)<!-- HN:43981603:end --><!-- HN:43985340:start -->
* [43985340](https://news.social-protocols.org/stats?id=43985340) #20 7 points 0 comments -> [A farewell to Ada with null (1992)](https://web.elastic.org/~fche/mirrors/old-usenet/ada-with-null)<!-- HN:43985340:end --><!-- HN:43985930:start -->
* [43985930](https://news.social-protocols.org/stats?id=43985930) #4 45 points 3 comments -> [DeepMind unveils 'spectacular' general-purpose science AI](https://www.nature.com/articles/d41586-025-01523-z)<!-- HN:43985930:end --><!-- HN:43987768:start -->
* [43987768](https://news.social-protocols.org/stats?id=43987768) #8 4 points 0 comments -> [They expect us to keep changing](https://benv.ca/blog/posts/they-expect-us-to-keep-changing)<!-- HN:43987768:end -->
#### **Thursday, May 15, 2025**
<!-- HN:43990107:start -->
* [43990107](https://news.social-protocols.org/stats?id=43990107) #5 20 points 5 comments -> [Why agency and cognition are fundamentally not computational](https://www.frontiersin.org/journals/psychology/articles/10.3389/fpsyg.2024.1362658/full)<!-- HN:43990107:end --><!-- HN:43950834:start -->
* [43950834](https://news.social-protocols.org/stats?id=43950834) #21 8 points 4 comments -> [The AUCTUS A6: the chip enabling inexpensive DMR Radio (2021)](https://jhart99.com/auctus-a6/)<!-- HN:43950834:end --><!-- HN:43990976:start -->
* [43990976](https://news.social-protocols.org/stats?id=43990976) #6 15 points 7 comments -> [AI is like hyperprocessed foods for learning](https://blindsidenetworks.com/ai-is-like-hyperprocessed-food-for-learning/)<!-- HN:43990976:end --><!-- HN:43953674:start -->
* [43953674](https://news.social-protocols.org/stats?id=43953674) #9 4 points 1 comments -> [Intelligence on Earth Evolved Independently at Least Twice](https://www.wired.com/story/intelligence-evolved-at-least-twice-in-vertebrate-animals/)<!-- HN:43953674:end --><!-- HN:43992198:start -->
* [43992198](https://news.social-protocols.org/stats?id=43992198) #28 -> [XAI's Grok suddenly can't stop bringing up "white genocide" in South Africa](https://arstechnica.com/ai/2025/05/xais-grok-suddenly-cant-stop-bringing-up-white-genocide-in-south-africa/)<!-- HN:43992198:end --><!-- HN:43993548:start -->
* [43993548](https://news.social-protocols.org/stats?id=43993548) #20 9 points 9 comments -> [UK becomes fastest-growing G7 economy](https://apnews.com/article/uk-economy-growth-g7-reeves-2d7b9761e53d3d490c3181a1fa89651b)<!-- HN:43993548:end --><!-- HN:43993709:start -->
* [43993709](https://news.social-protocols.org/stats?id=43993709) #28 18 points 3 comments -> [How Qatar Bought America](https://www.thefp.com/p/how-qatar-bought-america)<!-- HN:43993709:end --><!-- HN:43958696:start -->
* [43958696](https://news.social-protocols.org/stats?id=43958696) #11 5 points 0 comments -> [Solved: What Is Microcode and Why You Need to Be Aware of It](https://www.urtech.ca/2025/02/solved-what-is-microcode-why-you-need-to-be-aware-of-it/)<!-- HN:43958696:end --><!-- HN:43993332:start -->
* [43993332](https://news.social-protocols.org/stats?id=43993332) #13 96 points 24 comments -> [XAI's Grok suddenly can't stop bringing up "white genocide" in South Africa](https://arstechnica.com/ai/2025/05/xais-grok-suddenly-cant-stop-bringing-up-white-genocide-in-south-africa/)<!-- HN:43993332:end -->