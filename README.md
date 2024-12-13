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

#### **Saturday, December 7, 2024**
<!-- HN:42346084:start -->
* [42346084](https://news.social-protocols.org/stats?id=42346084) #5 3 points 1 comments -> [Times New Dumbass Font](https://timesnewdumbass.co)<!-- HN:42346084:end --><!-- HN:42345570:start -->
* [42345570](https://news.social-protocols.org/stats?id=42345570) #19 65 points 40 comments -> [TikTok set to be banned in the US after losing appeal](https://www.bbc.com/news/articles/c2ldnq5095xo)<!-- HN:42345570:end --><!-- HN:42345500:start -->
* [42345500](https://news.social-protocols.org/stats?id=42345500) #1 115 points 28 comments -> [OpenWrt One router officially launched](https://openwrt.org/#openwrt_one_router_officially_launched)<!-- HN:42345500:end --><!-- HN:42348664:start -->
* [42348664](https://news.social-protocols.org/stats?id=42348664) #9 49 points 34 comments -> [Firefox Is the Superior Browser](https://asindu.xyz/posts/switching-to-firefox/)<!-- HN:42348664:end --><!-- HN:42349415:start -->
* [42349415](https://news.social-protocols.org/stats?id=42349415) #16 28 points 41 comments -> [Top internet sleuths say they won't help find the UnitedHealthcare CEO killer](https://www.nbcnews.com/tech/internet/internet-sleuths-say-wont-help-find-unitedhealthcare-ceo-suspect-rcna183228)<!-- HN:42349415:end --><!-- HN:42347885:start -->
* [42347885](https://news.social-protocols.org/stats?id=42347885) #21 27 points 40 comments -> [The Birmingham Blade: geographically tailored urban wind turbine designed by AI](https://www.birmingham.ac.uk/news/2024/the-birmingham-blade-the-worlds-first-geographically-tailored-urban-wind-turbine-designed-by-ai)<!-- HN:42347885:end --><!-- HN:42340000:start -->
* [42340000](https://news.social-protocols.org/stats?id=42340000) #15 237 points 243 comments -> [Rivian is opening its charging network to other EVs](https://www.thedrive.com/news/rivian-is-opening-its-charger-network-to-other-evs)<!-- HN:42340000:end --><!-- HN:42349797:start -->
* [42349797](https://news.social-protocols.org/stats?id=42349797) #26 34 points 5 comments -> [PSA: The Kagi search engine directly funds Yandex –- and refuses to stop](https://old.reddit.com/r/ukraine/comments/1gvcqua/psa_the_kagi_search_engine_directly_funds_yandex/)<!-- HN:42349797:end --><!-- HN:42350677:start -->
* [42350677](https://news.social-protocols.org/stats?id=42350677) #16 10 points 3 comments -> [Co-sleeping causes 3 more infant deaths in New York, officials say in warning](https://www.cbsnews.com/newyork/news/co-sleeping-dangers-infant-deaths-suffolk-county/)<!-- HN:42350677:end --><!-- HN:42350351:start -->
* [42350351](https://news.social-protocols.org/stats?id=42350351) #19 58 points 42 comments -> [Show HN: Scraper for job listings directly from company websites](https://www.unlistedjobs.com/)<!-- HN:42350351:end --><!-- HN:42352291:start -->
* [42352291](https://news.social-protocols.org/stats?id=42352291) #13 21 points 9 comments -> [How One of the Richest Men Is Avoiding $8B in Taxes](https://www.nytimes.com/2024/12/05/business/nvidia-jensen-huang-estate-taxes.html)<!-- HN:42352291:end --><!-- HN:42353338:start -->
* [42353338](https://news.social-protocols.org/stats?id=42353338) #20 6 points 1 comments -> [White British students not allowed to apply for security services internship](https://www.telegraph.co.uk/news/2024/12/07/white-british-not-able-apply-security-services-internship/)<!-- HN:42353338:end --><!-- HN:42352983:start -->
* [42352983](https://news.social-protocols.org/stats?id=42352983) #9 41 points 16 comments -> [US Food and Drug Administration moves to ban red food dye](https://www.theguardian.com/world/2024/dec/07/fda-moves-to-ban-red-food-dye)<!-- HN:42352983:end --><!-- HN:42351698:start -->
* [42351698](https://news.social-protocols.org/stats?id=42351698) #13 63 points 32 comments -> [Google's AI weather prediction model is pretty darn good](https://www.theverge.com/2024/12/7/24314064/ai-weather-forecast-model-google-deepmind-gencast)<!-- HN:42351698:end --><!-- HN:42351490:start -->
* [42351490](https://news.social-protocols.org/stats?id=42351490) #6 31 points 2 comments -> [Windows on ARM Gets Major Gaming Boost with Prism Update](https://windowsonarm.org/blog/66031766-b200-4b5f-a707-28a2a7888da9)<!-- HN:42351490:end --><!-- HN:42352682:start -->
* [42352682](https://news.social-protocols.org/stats?id=42352682) #13 27 points 4 comments -> [Five of the best science fiction books of 2024](https://www.theguardian.com/books/2024/dec/02/five-of-the-best-science-fiction-books-of-2024)<!-- HN:42352682:end --><!-- HN:42350672:start -->
* [42350672](https://news.social-protocols.org/stats?id=42350672) #30 54 points 53 comments -> [The electric shock behind Europe's stuttering EV future](https://news.sky.com/story/the-electric-shock-behind-europes-stuttering-ev-future-and-how-china-has-leapfrogged-major-car-exporting-nations-13267440)<!-- HN:42350672:end -->
#### **Sunday, December 8, 2024**
<!-- HN:42286808:start -->
* [42286808](https://news.social-protocols.org/stats?id=42286808) #17 6 points 1 comments -> [6 Lessons I learned working at an art gallery](https://www.henrikkarlsson.xyz/p/art-gallery)<!-- HN:42286808:end --><!-- HN:42353983:start -->
* [42353983](https://news.social-protocols.org/stats?id=42353983) #22 17 points 11 comments -> [Legendary video game developer imagines a future where GPUs don't need PCs](https://www.tomshardware.com/pc-components/gpus/legendary-video-game-developer-imagines-a-future-where-gpus-dont-need-pcs-john-carmack-envisions-a-gpu-with-linux-onboard-so-you-would-just-add-power-and-a-display)<!-- HN:42353983:end --><!-- HN:42354201:start -->
* [42354201](https://news.social-protocols.org/stats?id=42354201) #18 11 points 7 comments -> [Lower-cost sodium-ion batteries are finally having their moment](https://arstechnica.com/cars/2024/12/lower-cost-sodium-ion-batteries-are-finally-having-their-moment/)<!-- HN:42354201:end --><!-- HN:42353540:start -->
* [42353540](https://news.social-protocols.org/stats?id=42353540) #5 35 points 41 comments -> [Economics and Homemakers](https://thehomefront.substack.com/p/economics-and-homemakers)<!-- HN:42353540:end --><!-- HN:42353929:start -->
* [42353929](https://news.social-protocols.org/stats?id=42353929) #17 12 points 3 comments -> [FDIC's Redacted Pause Letters](https://downloads.ctfassets.net/c5bd0wqjc7v0/6y0GZ2y2LzOZi1gUnCTtxh/55bf6ae9665ca12b9fe7bdfb3ebe746b/-26-1-_Exhibit_A_-_Redacted_Pause_Letters.pdf)<!-- HN:42353929:end --><!-- HN:42354056:start -->
* [42354056](https://news.social-protocols.org/stats?id=42354056) #7 56 points 5 comments -> [GrapheneOS on Pixels getting extended Android support](https://grapheneos.social/@GrapheneOS/113603951027289464)<!-- HN:42354056:end --><!-- HN:42355790:start -->
* [42355790](https://news.social-protocols.org/stats?id=42355790) #28 4 points 0 comments -> [The UC Berkeley Project That Is the AI Industry's Obsession](https://www.wsj.com/tech/ai/the-uc-berkeley-project-that-is-the-ai-industrys-obsession-bc68b3e3)<!-- HN:42355790:end --><!-- HN:42355128:start -->
* [42355128](https://news.social-protocols.org/stats?id=42355128) #25 42 points 36 comments -> [What Arm's CEO makes of the Intel debacle](https://www.theverge.com/2024/12/6/24315123/arm-ceo-rene-haas-intel-ai-chips-samsung-changes)<!-- HN:42355128:end --><!-- HN:42292443:start -->
* [42292443](https://news.social-protocols.org/stats?id=42292443) #12 4 points 0 comments -> ['Maya blue': The mystery dye recreated two centuries after it was lost](https://www.aljazeera.com/features/2024/12/1/maya-blue-the-mystery-dye-recreated-two-centuries-after-it-was-lost)<!-- HN:42292443:end --><!-- HN:42353948:start -->
* [42353948](https://news.social-protocols.org/stats?id=42353948) #9 62 points 47 comments -> [Landlords Are Using AI to Raise Rents](https://gizmodo.com/landlords-are-using-ai-to-raise-rents-and-cities-are-starting-to-push-back-2000535519)<!-- HN:42353948:end --><!-- HN:42334383:start -->
* [42334383](https://news.social-protocols.org/stats?id=42334383) #9 21 points 2 comments -> [The Underground University](https://aeon.co/essays/how-a-cold-war-underground-university-smuggled-in-western-ideas)<!-- HN:42334383:end --><!-- HN:42311667:start -->
* [42311667](https://news.social-protocols.org/stats?id=42311667) #24 27 points 40 comments -> [A critical history of the FDA](https://www.midwesterndoctor.com/p/the-fdas-war-against-americas-health)<!-- HN:42311667:end --><!-- HN:42357663:start -->
* [42357663](https://news.social-protocols.org/stats?id=42357663) #23 5 points 0 comments -> ["Paycheck-to-paycheck" and five other popular myths](https://www.noahpinion.blog/p/paycheck-to-paycheck-and-five-other)<!-- HN:42357663:end --><!-- HN:42356814:start -->
* [42356814](https://news.social-protocols.org/stats?id=42356814) #25 6 points 1 comments -> [Don't Block the Event Loop (Or the Worker Pool) in JavaScript](https://github.com/rowsana/Not-blocking-event-loop)<!-- HN:42356814:end --><!-- HN:42359571:start -->
* [42359571](https://news.social-protocols.org/stats?id=42359571) #7 10 points 1 comments -> [I spent 2 years rebuilding my trading platform in Rust. I have no regrets](https://nexustrade.io/blog/i-spent-2-years-rebuilding-my-algorithmic-trading-platform-in-rust-i-have-noregrets-20241205)<!-- HN:42359571:end --><!-- HN:42360338:start -->
* [42360338](https://news.social-protocols.org/stats?id=42360338) #4 10 points 8 comments -> [In wake of CEO shooting, Amazon creates Executive Protection role](https://www.amazon.jobs/en/jobs/2789178/executive-protection-manager-protective-services-operations)<!-- HN:42360338:end --><!-- HN:42360116:start -->
* [42360116](https://news.social-protocols.org/stats?id=42360116) #18 13 points 4 comments -> [Defusing AGPL-3 with Batch Processing](https://flameeyes.blog/2024/12/08/defusing-agpl-3-with-batch-processing/)<!-- HN:42360116:end --><!-- HN:42360237:start -->
* [42360237](https://news.social-protocols.org/stats?id=42360237) #11 19 points 17 comments -> [Difference in Gastrointestinal Cancer Risk and Mortality by Dietary Patterns](https://academic.oup.com/nutritionreviews/advance-article/doi/10.1093/nutrit/nuae090/7715995)<!-- HN:42360237:end -->
#### **Monday, December 9, 2024**
<!-- HN:42362291:start -->
* [42362291](https://news.social-protocols.org/stats?id=42362291) #20 -> [Records Seized by Israel Show Hamas Presence in U.N. Schools](https://www.nytimes.com/2024/12/08/world/middleeast/hamas-unrwa-schools.html)<!-- HN:42362291:end --><!-- HN:42362970:start -->
* [42362970](https://news.social-protocols.org/stats?id=42362970) #6 24 points 5 comments -> [Lethal Dose of 55 Substances](https://www.visualistan.com/2021/03/the-lethal-doses-of-55-substances.html)<!-- HN:42362970:end --><!-- HN:42363087:start -->
* [42363087](https://news.social-protocols.org/stats?id=42363087) #5 8 points 9 comments -> [How to Create Intelligently Self-Modifying Software (Framework Release Soon)](https://github.com/EricArthurBlair1010/semantic_inference_programming_information)<!-- HN:42363087:end --><!-- HN:42363592:start -->
* [42363592](https://news.social-protocols.org/stats?id=42363592) #8 19 points 40 comments -> [Skype Credit is no longer available](https://www.skype.com/en/credit/)<!-- HN:42363592:end --><!-- HN:42364241:start -->
* [42364241](https://news.social-protocols.org/stats?id=42364241) #6 39 points 8 comments -> [Raspberry Pi 500 Review: The keyboard is the computer, again](https://www.tomshardware.com/raspberry-pi/raspberry-pi-500-review)<!-- HN:42364241:end --><!-- HN:42358358:start -->
* [42358358](https://news.social-protocols.org/stats?id=42358358) #11 139 points 75 comments -> [Replace Philips Hue Automation with Home Assistant's](https://blog.frankel.ch/home-assistant/3/)<!-- HN:42358358:end --><!-- HN:42361503:start -->
* [42361503](https://news.social-protocols.org/stats?id=42361503) #21 96 points 38 comments -> [Broward Co. to vacate convictions for buying crack made by Sheriff's Office](https://cbs12.com/news/local/broward-county-to-vacate-convictions-for-people-who-bought-crack-made-by-sheriffs-office-supreme-court-reverse-sting-1993-ruling-state-attorney)<!-- HN:42361503:end --><!-- HN:42292956:start -->
* [42292956](https://news.social-protocols.org/stats?id=42292956) #28 14 points 5 comments -> [See how a lab-grown diamond is made](https://www.washingtonpost.com/business/interactive/2024/how-lab-grown-diamonds-made-manufactured/)<!-- HN:42292956:end --><!-- HN:42361299:start -->
* [42361299](https://news.social-protocols.org/stats?id=42361299) #15 152 points 49 comments -> [Buffer Overflow Risk in Curl_inet_ntop and Inet_ntop4](https://hackerone.com/reports/2887487)<!-- HN:42361299:end --><!-- HN:42359905:start -->
* [42359905](https://news.social-protocols.org/stats?id=42359905) #28 49 points 7 comments -> [VictoriaLogs: A Grafana Dashboard for AWS VPC Flow Logs – Migrating from Grafan](https://rtfm.co.ua/en/victorialogs-a-grafana-dashboard-for-aws-vpc-flow-logs-migrating-from-grafana-loki/)<!-- HN:42359905:end --><!-- HN:42366505:start -->
* [42366505](https://news.social-protocols.org/stats?id=42366505) #16 4 points 0 comments -> [Flawless Replay, time-traveling debugger for Rust workflows](https://flawless.dev/replay/)<!-- HN:42366505:end --><!-- HN:42366706:start -->
* [42366706](https://news.social-protocols.org/stats?id=42366706) #30 10 points 1 comments -> [The "Quiet Quitting" Myth Is Toxic for Tech](https://blackentropy.com/the-quiet-quitting-myth-is-toxic-for-tech/)<!-- HN:42366706:end --><!-- HN:42366546:start -->
* [42366546](https://news.social-protocols.org/stats?id=42366546) #17 27 points 5 comments -> [Theory-building and why employee churn is lethal to software companies](https://www.baldurbjarnason.com/2022/theory-building/)<!-- HN:42366546:end --><!-- HN:42368697:start -->
* [42368697](https://news.social-protocols.org/stats?id=42368697) #15 4 points 0 comments -> [Howie Did It – 3D Printing a Printed Circuit Board [video]](https://www.youtube.com/watch?v=FzrZoVKT8gM)<!-- HN:42368697:end --><!-- HN:42364630:start -->
* [42364630](https://news.social-protocols.org/stats?id=42364630) #30 10 points 2 comments -> [Practical GrapheneOS for the Paranoid • Ventral Digital](https://ventral.digital/posts/2024/12/9/practical-grapheneos-for-the-paranoid/)<!-- HN:42364630:end --><!-- HN:42368210:start -->
* [42368210](https://news.social-protocols.org/stats?id=42368210) #8 -> [Show HN: I used ChatGPT and Blender to combine 150 WW2 movies chronologically](https://ww2supercut.substack.com/p/combining-143-world-war-ii-movies)<!-- HN:42368210:end --><!-- HN:42370370:start -->
* [42370370](https://news.social-protocols.org/stats?id=42370370) #21 7 points 1 comments -> [Mega-buildings are now slowing Earth's spin](https://www.sciencefocus.com/news/human-structures-slowing-earths-spin)<!-- HN:42370370:end --><!-- HN:42370688:start -->
* [42370688](https://news.social-protocols.org/stats?id=42370688) #16 16 points 6 comments -> [Luigi Mangione's arrest canary [video]](https://www.youtube.com/watch?v=bdhs9g3Wwg0)<!-- HN:42370688:end --><!-- HN:42370854:start -->
* [42370854](https://news.social-protocols.org/stats?id=42370854) #29 4 points 0 comments -> [The Dumbest Bike Lane Law Just Passed in Canada [video]](https://www.youtube.com/watch?v=KgFCQ7jEZxI)<!-- HN:42370854:end --><!-- HN:42347466:start -->
* [42347466](https://news.social-protocols.org/stats?id=42347466) #26 16 points 9 comments -> [Atoms for Peace: Learning to Love the Bomb](https://www.historytoday.com/archive/history-matters/atoms-peace-learning-love-bomb)<!-- HN:42347466:end --><!-- HN:42371315:start -->
* [42371315](https://news.social-protocols.org/stats?id=42371315) #7 6 points 2 comments -> [How Can I Be an AI Engineer?](https://timkellogg.me/blog/2024/12/09/ai-engineer)<!-- HN:42371315:end --><!-- HN:42371166:start -->
* [42371166](https://news.social-protocols.org/stats?id=42371166) #15 -> [Healthcare CEO killer studied computer science at UPenn, founded game dev club](https://www.bbc.com/news/live/crk0ep61p2mt)<!-- HN:42371166:end -->
#### **Tuesday, December 10, 2024**
<!-- HN:42372508:start -->
* [42372508](https://news.social-protocols.org/stats?id=42372508) #25 6 points 5 comments -> [Giant Study Links Drinking Coffee with Almost 2 Extra Years of Life](https://www.sciencealert.com/giant-study-links-drinking-coffee-with-almost-2-extra-years-of-life)<!-- HN:42372508:end --><!-- HN:42374469:start -->
* [42374469](https://news.social-protocols.org/stats?id=42374469) #4 8 points 0 comments -> [15 Times to use AI, and 5 Not to](https://www.oneusefulthing.org/p/15-times-to-use-ai-and-5-not-to)<!-- HN:42374469:end --><!-- HN:42375632:start -->
* [42375632](https://news.social-protocols.org/stats?id=42375632) #6 12 points 3 comments -> [ChatGPT's Sad Second Birthday](https://podcastaddict.com/podcast/system-crash/5515865)<!-- HN:42375632:end --><!-- HN:42316212:start -->
* [42316212](https://news.social-protocols.org/stats?id=42316212) #17 7 points 1 comments -> [Piskel – Free online editor for animated sprites and pixel art](https://www.piskelapp.com/)<!-- HN:42316212:end --><!-- HN:42379435:start -->
* [42379435](https://news.social-protocols.org/stats?id=42379435) #25 5 points 4 comments -> [Scientists claim they've found the cause mystery colon cancers in young people](https://www.dailymail.co.uk/health/article-14176551/Scientists-cause-mystery-colon-cancers-young-people-lifestyle-factors.html)<!-- HN:42379435:end -->
#### **Wednesday, December 11, 2024**<!-- HN:42386726:start -->
* [42386726](https://news.social-protocols.org/stats?id=42386726) #5 44 points 38 comments -> [Bankruptcy judge rejects The Onion's bid for Infowars](https://www.npr.org/2024/12/10/nx-s1-5224170/infowars-alex-jones-the-onion-bankruptcy-judge)<!-- HN:42386726:end --><!-- HN:42386683:start -->
* [42386683](https://news.social-protocols.org/stats?id=42386683) #25 37 points 0 comments -> [The Onion's Purchase of Alex Jones' Infowars Stopped by US Judge](https://www.reuters.com/legal/onions-purchase-alex-jones-infowars-stopped-by-us-judge-2024-12-11/)<!-- HN:42386683:end --><!-- HN:42387549:start -->
* [42387549](https://news.social-protocols.org/stats?id=42387549) #2 121 points 94 comments -> [The PayPal Mafia is taking over America's government](https://www.economist.com/business/2024/12/10/the-paypal-mafia-is-taking-over-americas-government)<!-- HN:42387549:end --><!-- HN:42388983:start -->
* [42388983](https://news.social-protocols.org/stats?id=42388983) #13 67 points 33 comments -> [Google are deliberately breaking YouTube when it detects you're running Firefox](https://old.reddit.com/r/firefox/comments/1cjbsmj/youtube_on_firefox_seems_to_be_getting_much_worse/)<!-- HN:42388983:end --><!-- HN:42390630:start -->
* [42390630](https://news.social-protocols.org/stats?id=42390630) #6 8 points 0 comments -> [UnitedHealthcare's Leaked Talking Points](https://www.kenklippenstein.com/p/unitedhealthcares-leaked-talking)<!-- HN:42390630:end --><!-- HN:42391483:start -->
* [42391483](https://news.social-protocols.org/stats?id=42391483) #14 29 points 13 comments -> [One of our clients hasn't paid us $130k – or "Why Every Contract Clause Matters"](https://www.apsis.io/blog/2024/12/11/clauses-matter/)<!-- HN:42391483:end --><!-- HN:42386906:start -->
* [42386906](https://news.social-protocols.org/stats?id=42386906) #28 5 points 1 comments -> [A chatbot hinted a kid should kill his parentts over screen time limits: lawsui](https://text.npr.org/nx-s1-5222574)<!-- HN:42386906:end -->
#### **Thursday, December 12, 2024**
<!-- HN:42350780:start -->
* [42350780](https://news.social-protocols.org/stats?id=42350780) #29 9 points 2 comments -> [WW1 dazzle camouflage was not as well understood as it might have been](https://phys.org/news/2024-12-world-war-dazzle-camouflage-understood.html)<!-- HN:42350780:end --><!-- HN:42399313:start -->
* [42399313](https://news.social-protocols.org/stats?id=42399313) #17 3 points 0 comments -> [Hacking Rooftop Solar Is a Way to Break Europe's Power Grid](https://www.bloomberg.com/news/articles/2024-12-12/europe-s-power-grid-vulnerable-to-hackers-exploiting-rooftop-solar-panels)<!-- HN:42399313:end --><!-- HN:42392660:start -->
* [42392660](https://news.social-protocols.org/stats?id=42392660) #20 156 points 47 comments -> [Instant macOS install on Proxmox including AMD patches](https://github.com/luchina-gabriel/OSX-PROXMOX)<!-- HN:42392660:end --><!-- HN:42398380:start -->
* [42398380](https://news.social-protocols.org/stats?id=42398380) #24 19 points 1 comments -> [The report for the 2024 security audit of the Mullvad app is now available](https://mullvad.net/en/blog/the-report-for-the-2024-security-audit-of-the-app-is-now-available)<!-- HN:42398380:end --><!-- HN:42388340:start -->
* [42388340](https://news.social-protocols.org/stats?id=42388340) #28 173 points 101 comments -> [Django and Postgres for the Busy Rails Developer](https://andyatkinson.com/django-python-postgres-busy-rails-developer)<!-- HN:42388340:end --><!-- HN:42398989:start -->
* [42398989](https://news.social-protocols.org/stats?id=42398989) #14 23 points 15 comments -> [French Piracy Blocking Order Goes Global, DNS Service Quad9 Vows to Fight](https://torrentfreak.com/french-piracy-blocking-order-goes-global-dns-service-quad9-vows-to-fight-241212/)<!-- HN:42398989:end --><!-- HN:42388973:start -->
* [42388973](https://news.social-protocols.org/stats?id=42388973) #19 250 points 45 comments -> [Pgroll – Zero-downtime, reversible, schema changes for PostgreSQL (new website)](https://pgroll.com/)<!-- HN:42388973:end --><!-- HN:42399562:start -->
* [42399562](https://news.social-protocols.org/stats?id=42399562) #5 5 points 0 comments -> [As Wolf Populations Rebound, an Angry Backlash Intensifies](https://e360.yale.edu/features/wolves-united-states-europe)<!-- HN:42399562:end --><!-- HN:42398314:start -->
* [42398314](https://news.social-protocols.org/stats?id=42398314) #16 12 points 0 comments -> [Retiring from Hanami/dry-rb/ROM-rb core teams](https://solnic.dev/retiring-from-the-core-teams)<!-- HN:42398314:end --><!-- HN:42392802:start -->
* [42392802](https://news.social-protocols.org/stats?id=42392802) #14 225 points 47 comments -> [QEMU with VirtIO GPU Vulkan Support](https://gist.github.com/peppergrayxyz/fdc9042760273d137dddd3e97034385f)<!-- HN:42392802:end --><!-- HN:42350293:start -->
* [42350293](https://news.social-protocols.org/stats?id=42350293) #28 17 points 40 comments -> [Can hunters' donations help deliver high-quality meat to Colorado food pantries?](https://collective.coloradotrust.org/stories/bringing-elk-and-venison-to-food-pantries/)<!-- HN:42350293:end --><!-- HN:42400179:start -->
* [42400179](https://news.social-protocols.org/stats?id=42400179) #19 16 points 7 comments -> [Particle gains or loses mass depending on direction it travels](https://newatlas.com/physics/particle-gains-loses-mass-depending-direction/)<!-- HN:42400179:end --><!-- HN:42354830:start -->
* [42354830](https://news.social-protocols.org/stats?id=42354830) #29 16 points 4 comments -> [The Holotypic Occlupanid Research Group](https://www.horg.com/)<!-- HN:42354830:end --><!-- HN:42390210:start -->
* [42390210](https://news.social-protocols.org/stats?id=42390210) #27 347 points 509 comments -> [OnlyFans models are using AI impersonators to keep up with their DMs](https://www.wired.com/story/onlyfans-models-are-using-ai-impersonators-to-keep-up-with-their-dms/)<!-- HN:42390210:end --><!-- HN:42401821:start -->
* [42401821](https://news.social-protocols.org/stats?id=42401821) #26 7 points 1 comments -> [Attacker Has Techdirt Reclassified as Phishing Site](https://www.techdirt.com/2024/12/12/attacker-has-techdirt-reclassified-as-phishing-site-proving-masnicks-impossibility-law-once-again/)<!-- HN:42401821:end -->
#### **Friday, December 13, 2024**
<!-- HN:42316470:start -->
* [42316470](https://news.social-protocols.org/stats?id=42316470) #14 83 points 49 comments -> [Misperception of the facial appearance that the opposite-sex desires](https://journals.plos.org/plosone/article?id=10.1371/journal.pone.0310835)<!-- HN:42316470:end --><!-- HN:42407619:start -->
* [42407619](https://news.social-protocols.org/stats?id=42407619) #27 9 points 2 comments -> [The dirty secret about OnlyFans: it's not hot to be a prostitute](https://unherd.com/2024/12/the-dirty-secret-about-onlyfans/)<!-- HN:42407619:end --><!-- HN:42378166:start -->
* [42378166](https://news.social-protocols.org/stats?id=42378166) #24 38 points 7 comments -> [When the future arrived, it felt ordinary](https://worksinprogress.co/issue/the-world-of-tomorrow/)<!-- HN:42378166:end --><!-- HN:42408202:start -->
* [42408202](https://news.social-protocols.org/stats?id=42408202) #1 142 points 32 comments -> [Test](https://www.defense.gov/News/News-Stories/Article/Article/4000004/test/)<!-- HN:42408202:end --><!-- HN:42375509:start -->
* [42375509](https://news.social-protocols.org/stats?id=42375509) #16 10 points 6 comments -> [Eventual Consistency Is Tricky](https://newsletter.systemdesigncodex.com/p/eventual-consistency-is-tricky)<!-- HN:42375509:end --><!-- HN:42351988:start -->
* [42351988](https://news.social-protocols.org/stats?id=42351988) #17 47 points 34 comments -> [Microsoft GW-Basic User's Guide and Reference (1989) [pdf]](https://bitsavers.computerhistory.org/pdf/microsoft/gw-basic/Microsoft_GW-BASIC_Users_Guide_and_Reference_1989.pdf)<!-- HN:42351988:end --><!-- HN:42376083:start -->
* [42376083](https://news.social-protocols.org/stats?id=42376083) #19 63 points 10 comments -> [Mastering Ruby Debugging: From Puts to Professional Tools](https://blog.jetbrains.com/ruby/2024/12/mastering_ruby_debugging/)<!-- HN:42376083:end --><!-- HN:42408117:start -->
* [42408117](https://news.social-protocols.org/stats?id=42408117) #23 20 points 16 comments -> [SpaceX Seeks Approval to Turn Texas Starbase Site into New City](https://www.bloomberg.com/news/articles/2024-12-13/spacex-seeks-approval-to-turn-texas-starbase-site-into-new-city)<!-- HN:42408117:end -->