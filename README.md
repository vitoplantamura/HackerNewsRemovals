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

#### **Wednesday, August 27, 2025**
<!-- HN:45035336:start -->
* [45035336](https://news.social-protocols.org/stats?id=45035336) #2 14 points 1 comments -> [Hire Palestinian Tech Talent](https://apricotinternational.org/)<!-- HN:45035336:end --><!-- HN:45035741:start -->
* [45035741](https://news.social-protocols.org/stats?id=45035741) #25 39 points 3 comments -> [We have become an authoritarian state, and our top newsrooms are in denial](https://presswatchers.org/2025/08/we-have-become-an-authoritarian-state-and-our-top-newsrooms-are-in-denial/)<!-- HN:45035741:end --><!-- HN:45038529:start -->
* [45038529](https://news.social-protocols.org/stats?id=45038529) #20 14 points 1 comments -> [Money Can't Buy You Love: The Story Behind Elon Musk's Berghain Rejection](https://berlinguide.de/money-cant-buy-you-love-the-story-behind-elon-musks-berghain-rejection/)<!-- HN:45038529:end --><!-- HN:45039228:start -->
* [45039228](https://news.social-protocols.org/stats?id=45039228) #12 4 points 15 comments -> [A vibe-coding tool for serious developers](https://appjet.ai)<!-- HN:45039228:end --><!-- HN:45041906:start -->
* [45041906](https://news.social-protocols.org/stats?id=45041906) #10 10 points 8 comments -> [I built a production app in a week by managing a swarm of 20 AI agents](https://zachwills.net/i-managed-a-swarm-of-20-ai-agents-for-a-week-here-are-the-8-rules-i-learned/)<!-- HN:45041906:end --><!-- HN:45038653:start -->
* [45038653](https://news.social-protocols.org/stats?id=45038653) #1 467 points 250 comments -> [Nx compromised: malware uses Claude code CLI to explore the filesystem](https://semgrep.dev/blog/2025/security-alert-nx-compromised-to-steal-wallets-and-credentials/)<!-- HN:45038653:end --><!-- HN:45041779:start -->
* [45041779](https://news.social-protocols.org/stats?id=45041779) #22 28 points 40 comments -> [Desktop Linux Keeps Winning the Wrong Battles](https://www.howtogeek.com/desktop-linux-keeps-winning-the-wrong-battles/)<!-- HN:45041779:end --><!-- HN:45042831:start -->
* [45042831](https://news.social-protocols.org/stats?id=45042831) #18 5 points 2 comments -> [Show HN: Whose p*nis is that now? Probably the weirdest website I've ever made](https://whosepenis.com/pages/fun)<!-- HN:45042831:end --><!-- HN:45046124:start -->
* [45046124](https://news.social-protocols.org/stats?id=45046124) #23 20 points 3 comments -> [Asahi Linux Lead Developer Steps Down](https://linuxiac.com/asahi-linux-lead-developer-steps-down/)<!-- HN:45046124:end -->
#### **Thursday, August 28, 2025**<!-- HN:45049320:start -->
* [45049320](https://news.social-protocols.org/stats?id=45049320) #3 14 points 16 comments -> [Show HN: I built AI that turns 4 hours of financial analysis into 30 seconds](https://duebase.com)<!-- HN:45049320:end --><!-- HN:45007857:start -->
* [45007857](https://news.social-protocols.org/stats?id=45007857) #30 19 points 24 comments -> [A Ritzy L.A. Enclave Learned a Bitter Lesson About the Limits of Its Wealth](https://www.nytimes.com/2025/08/24/magazine/landfill-calabasas-los-angeles-wildfire-ash.html)<!-- HN:45007857:end --><!-- HN:45051777:start -->
* [45051777](https://news.social-protocols.org/stats?id=45051777) #8 17 points 9 comments -> [LLMs solving problems OCR+NLP couldn't](https://cloudsquid.substack.com/p/ocr-is-legacy-tech)<!-- HN:45051777:end --><!-- HN:45052242:start -->
* [45052242](https://news.social-protocols.org/stats?id=45052242) #16 19 points 40 comments -> [US to put economic data on 9 blockchains](https://www.bloomberg.com/news/articles/2025-08-28/us-puts-gdp-data-on-the-blockchain-in-trump-crypto-push)<!-- HN:45052242:end --><!-- HN:45053226:start -->
* [45053226](https://news.social-protocols.org/stats?id=45053226) #3 44 points 17 comments -> [The Stock Market Is Selling the Fed's Independence Because ZIRP Broke the World](https://www.splinter.com/the-stock-market-is-selling-its-soul-and-the-feds-independence-to-trump-because-zirp-broke-the-world)<!-- HN:45053226:end --><!-- HN:45052980:start -->
* [45052980](https://news.social-protocols.org/stats?id=45052980) #27 47 points 37 comments -> [Brazil offers America a lesson in democratic maturity](https://www.economist.com/leaders/2025/08/28/brazil-offers-america-a-lesson-in-democratic-maturity)<!-- HN:45052980:end --><!-- HN:45054482:start -->
* [45054482](https://news.social-protocols.org/stats?id=45054482) #7 15 points 3 comments -> [GPT-realtime and Realtime API updates](https://openai.com/index/introducing-gpt-realtime/)<!-- HN:45054482:end --><!-- HN:45055450:start -->
* [45055450](https://news.social-protocols.org/stats?id=45055450) #7 32 points 1 comments -> [CDC director has been ousted just weeks after Senate confirmation](https://arstechnica.com/health/2025/08/report-cdc-director-being-ousted-just-weeks-after-senate-confirmation/)<!-- HN:45055450:end --><!-- HN:45054648:start -->
* [45054648](https://news.social-protocols.org/stats?id=45054648) #12 19 points 1 comments -> [In Search of AI Psychosis](https://www.astralcodexten.com/p/in-search-of-ai-psychosis)<!-- HN:45054648:end --><!-- HN:45057984:start -->
* [45057984](https://news.social-protocols.org/stats?id=45057984) #6 5 points 0 comments -> [Deep Zionism](https://scottaaronson.blog/?p=9082)<!-- HN:45057984:end -->
#### **Friday, August 29, 2025**
<!-- HN:45058483:start -->
* [45058483](https://news.social-protocols.org/stats?id=45058483) #29 11 points 8 comments -> [I researched every attempt to stop fascism in history. The success rate is 0%](https://cmarmitage.substack.com/p/i-researched-every-attempt-to-stop)<!-- HN:45058483:end --><!-- HN:45058762:start -->
* [45058762](https://news.social-protocols.org/stats?id=45058762) #3 -> [Deep Zionism](https://scottaaronson.blog/?p=9082)<!-- HN:45058762:end --><!-- HN:45058241:start -->
* [45058241](https://news.social-protocols.org/stats?id=45058241) #14 19 points 4 comments -> [Bad Craziness](https://www.math.columbia.edu/~woit/wordpress/?p=15191)<!-- HN:45058241:end --><!-- HN:45058844:start -->
* [45058844](https://news.social-protocols.org/stats?id=45058844) #8 4 points 2 comments -> [Deep Zionism](https://scottaaronson.blog/?p=9082)<!-- HN:45058844:end --><!-- HN:45057781:start -->
* [45057781](https://news.social-protocols.org/stats?id=45057781) #21 46 points 40 comments -> [Every Industry Is an Overcrowded Airport Lounge Now](https://quoththeraven.substack.com/p/every-industry-is-an-overcrowded)<!-- HN:45057781:end --><!-- HN:45060344:start -->
* [45060344](https://news.social-protocols.org/stats?id=45060344) #5 9 points 1 comments -> [Why Americans Under 30 Are So Miserable](https://questionsforum.com/americans-under-30-are-so-miserable-that-the-u-s-just-fell-to-a-historic-low-ranking-in-the-annual-world-happiness/)<!-- HN:45060344:end --><!-- HN:45061537:start -->
* [45061537](https://news.social-protocols.org/stats?id=45061537) #20 7 points 0 comments -> [Reuters stopped sharing Gaza locations with Israel after IDF strikes](https://www.nbcnews.com/world/gaza/news-group-stopped-sharing-gaza-locations-israel-many-journalists-kill-rcna227687)<!-- HN:45061537:end --><!-- HN:45065439:start -->
* [45065439](https://news.social-protocols.org/stats?id=45065439) #4 -> [The Mattresses to Avoid Buying](https://www.choice.com.au/home-and-living/bedroom/mattresses/articles/mattresses-to-avoid-buying)<!-- HN:45065439:end --><!-- HN:45016263:start -->
* [45016263](https://news.social-protocols.org/stats?id=45016263) #20 33 points 41 comments -> [It's Not Wrong that (for HN) " ".length == 36](https://zaerl.com/2025/08/24/its-not-wrong-that-for-hn-%f0%9f%a4%a6%f0%9f%8f%bc%e2%99%82%ef%b8%8f-length-36/)<!-- HN:45016263:end --><!-- HN:45065234:start -->
* [45065234](https://news.social-protocols.org/stats?id=45065234) #17 6 points 2 comments -> [Ex-Mar-a-Lago employee granted broad AI search patent (US12,277,125) – thoughts? [pdf]](https://patentimages.storage.googleapis.com/81/08/e8/400c0d5b380d04/US12277125B2.pdf)<!-- HN:45065234:end --><!-- HN:45064703:start -->
* [45064703](https://news.social-protocols.org/stats?id=45064703) #29 27 points 13 comments -> [Fake accounts drove the DeepSeek AI hype and distorted markets](https://www.evai.ai/en/post/disinformation-the-deepseek-hype-was-all-made-up-how-fake-accounts-managed-a-market-frenzy)<!-- HN:45064703:end --><!-- HN:45066889:start -->
* [45066889](https://news.social-protocols.org/stats?id=45066889) #30 8 points 3 comments -> [JPMorgan Restricts Employees from Using ChatGPT](https://www.wsj.com/articles/jpmorgan-restricts-employees-from-using-chatgpt-2da5dc34)<!-- HN:45066889:end --><!-- HN:45067395:start -->
* [45067395](https://news.social-protocols.org/stats?id=45067395) #18 -> [Hardware Flaw in Apple A16 Chip: Debug Logic Active on Production Devices](https://github.com/JGoyd/A16-FuseBypass)<!-- HN:45067395:end --><!-- HN:45069361:start -->
* [45069361](https://news.social-protocols.org/stats?id=45069361) #29 16 points 19 comments -> [AI is ummasking ICE officers. Can Washington do anything about it?](https://www.politico.com/news/2025/08/29/ai-unmasking-ice-officers-00519478)<!-- HN:45069361:end -->
#### **Saturday, August 30, 2025**<!-- HN:45035817:start -->
* [45035817](https://news.social-protocols.org/stats?id=45035817) #17 8 points 1 comments -> [Anatomy of a Python Loop](https://orencodes.io/anatomy-of-a-python-loop/)<!-- HN:45035817:end --><!-- HN:45072170:start -->
* [45072170](https://news.social-protocols.org/stats?id=45072170) #6 5 points 1 comments -> [Free AI Tool Removes Image Backgrounds in Seconds](https://nanobananas.site/tools/background-removal)<!-- HN:45072170:end --><!-- HN:45072599:start -->
* [45072599](https://news.social-protocols.org/stats?id=45072599) #28 7 points 1 comments -> [Milan's expat 'explosion' brings new buzz to Italy's financial centre](https://www.ft.com/content/f33a01dc-f873-4c62-886f-f69562fb2e46)<!-- HN:45072599:end --><!-- HN:45024406:start -->
* [45024406](https://news.social-protocols.org/stats?id=45024406) #9 13 points 0 comments -> [Who Gives a Sheaf?](https://www.youtube.com/playlist?list=PLnNqTHlK5sGJrRvH0YBxE4Oe1M9EoSTPQ)<!-- HN:45024406:end --><!-- HN:45071847:start -->
* [45071847](https://news.social-protocols.org/stats?id=45071847) #22 22 points 9 comments -> [I sat down with Werner Vogels, the CTO of Amazon](https://everton.xyz/i-sat-down-with-werner-vogels/)<!-- HN:45071847:end --><!-- HN:45074840:start -->
* [45074840](https://news.social-protocols.org/stats?id=45074840) #15 16 points 1 comments -> [Americans Are Having Less Sex](https://www.wsj.com/lifestyle/relationships/americans-are-having-less-sex-than-ever-785973ce)<!-- HN:45074840:end --><!-- HN:45075666:start -->
* [45075666](https://news.social-protocols.org/stats?id=45075666) #11 4 points 3 comments -> [AWS has finally made SQS a viable queuing solution](https://aws.amazon.com/blogs/compute/building-resilient-multi-tenant-systems-with-amazon-sqs-fair-queues/)<!-- HN:45075666:end --><!-- HN:45075796:start -->
* [45075796](https://news.social-protocols.org/stats?id=45075796) #14 11 points 3 comments -> [Reuters stopped sharing Gaza locations after IDF strikes killed many journalists](https://www.nbcnews.com/world/gaza/news-group-stopped-sharing-gaza-locations-israel-many-journalists-kill-rcna227687)<!-- HN:45075796:end --><!-- HN:45075571:start -->
* [45075571](https://news.social-protocols.org/stats?id=45075571) #15 18 points 20 comments -> [The V Programming Language](https://vlang.io/)<!-- HN:45075571:end --><!-- HN:45077631:start -->
* [45077631](https://news.social-protocols.org/stats?id=45077631) #25 23 points 31 comments -> [U.S. guided-missile cruiser crosses Panama Canal, warships deployed to Venezuela](https://www.cbsnews.com/news/us-guided-missile-cruiser-panama-canal-warships-deployed-venezuela/)<!-- HN:45077631:end -->
#### **Sunday, August 31, 2025**
<!-- HN:45078598:start -->
* [45078598](https://news.social-protocols.org/stats?id=45078598) #1 70 points 52 comments -> [New Huawei 96GB GPU](https://e.huawei.com/cn/products/computing/ascend/atlas-300i-duo)<!-- HN:45078598:end --><!-- HN:45080819:start -->
* [45080819](https://news.social-protocols.org/stats?id=45080819) #3 9 points 3 comments -> [I Don't Like "AI"](https://ian.mccowan.space/2024/07/22/ai/)<!-- HN:45080819:end --><!-- HN:45080222:start -->
* [45080222](https://news.social-protocols.org/stats?id=45080222) #13 10 points 7 comments -> [Show HN: Q.js – Smaller than React/Vue, yet more powerful (40KB gzipped)](https://github.com/Qbix/Q.js)<!-- HN:45080222:end --><!-- HN:45081561:start -->
* [45081561](https://news.social-protocols.org/stats?id=45081561) #16 5 points 0 comments -> [Show HN: Banana AI – Completely free Nano Banana image editing](https://banana-ai.org/)<!-- HN:45081561:end --><!-- HN:45083023:start -->
* [45083023](https://news.social-protocols.org/stats?id=45083023) #14 5 points 2 comments -> [Great Barrier Reef Is Still Doing Fine Despite 'Cataclysmic' Bleaching Events](https://co2coalition.org/2025/08/08/the-great-barrier-reef-is-still-doing-fine-despite-cataclysmic-bleaching-events/)<!-- HN:45083023:end --><!-- HN:45084133:start -->
* [45084133](https://news.social-protocols.org/stats?id=45084133) #9 4 points 1 comments -> [Baby's first type checker](https://austinhenley.com/blog/babytypechecker.html)<!-- HN:45084133:end --><!-- HN:45051523:start -->
* [45051523](https://news.social-protocols.org/stats?id=45051523) #22 3 points 0 comments -> [ECG Interpretation Tools Compared – Why PMcardio Stands Out](https://www.powerfulmedical.com/blog/ecg-interpretation-tools-compared-why-pmcardio-stands-out/)<!-- HN:45051523:end --><!-- HN:45084822:start -->
* [45084822](https://news.social-protocols.org/stats?id=45084822) #25 6 points 2 comments -> [Why Dishwashers Are Quietly Disappearing from American Homes](https://www.gadgetreview.com/why-dishwashers-are-quietly-disappearing-from-american-homes)<!-- HN:45084822:end --><!-- HN:45050908:start -->
* [45050908](https://news.social-protocols.org/stats?id=45050908) #22 30 points 2 comments -> [The Case for Crazy Philanthropy](https://www.palladiummag.com/2025/08/22/the-case-for-crazy-philanthropy/)<!-- HN:45050908:end --><!-- HN:45055065:start -->
* [45055065](https://news.social-protocols.org/stats?id=45055065) #16 7 points 1 comments -> [Cricket, Fandom, and the Unspoken Price of Fantasy Gaming](https://uselessmbaguy.substack.com/p/cricket-fandom-and-the-unspoken-price)<!-- HN:45055065:end -->
#### **Monday, September 1, 2025**
<!-- HN:45088988:start -->
* [45088988](https://news.social-protocols.org/stats?id=45088988) #30 7 points 0 comments -> [Alarm as US far-right extremists eye drones for use in domestic attacks](https://www.theguardian.com/us-news/2025/aug/30/us-far-right-extremists-drones)<!-- HN:45088988:end --><!-- HN:45088977:start -->
* [45088977](https://news.social-protocols.org/stats?id=45088977) #3 29 points 18 comments -> [Substack just killed the creator economy](https://mail.bigdeskenergy.com/p/substack-just-killed-creator-economy)<!-- HN:45088977:end --><!-- HN:45090007:start -->
* [45090007](https://news.social-protocols.org/stats?id=45090007) #12 6 points 1 comments -> [Catholic churches in France have a bad landlord: the French government](https://thecatholicherald.com/article/catholic-churches-in-france-suffer-from-a-bad-landlord-the-french-government)<!-- HN:45090007:end --><!-- HN:45090091:start -->
* [45090091](https://news.social-protocols.org/stats?id=45090091) #17 5 points 0 comments -> [Global Sumud Flotilla](https://globalsumudflotilla.org/)<!-- HN:45090091:end --><!-- HN:45091538:start -->
* [45091538](https://news.social-protocols.org/stats?id=45091538) #28 10 points 1 comments -> [The deadly toll on journalists in the Gaza war](https://www.theguardian.com/global-development/ng-interactive/2025/sep/01/israel-gaza-war-media-palestinian-journalists-killed-cpj)<!-- HN:45091538:end --><!-- HN:45091972:start -->
* [45091972](https://news.social-protocols.org/stats?id=45091972) #5 39 points 20 comments -> [Show HN: AfriTales – Discover the Magic of African Storytelling](https://afritales.org/)<!-- HN:45091972:end --><!-- HN:45092814:start -->
* [45092814](https://news.social-protocols.org/stats?id=45092814) #7 -> [Vibe coded a website to share vibe coding tips](https://vibecodinglearn.com)<!-- HN:45092814:end --><!-- HN:45092977:start -->
* [45092977](https://news.social-protocols.org/stats?id=45092977) #26 6 points 1 comments -> [Racist Maths - the hidden ideology in your business systems](https://fluxus.io/article/racist-maths)<!-- HN:45092977:end --><!-- HN:45093821:start -->
* [45093821](https://news.social-protocols.org/stats?id=45093821) #28 13 points 0 comments -> [Israel committing genocide in Gaza, top scholars on the crime say](https://www.theguardian.com/world/2025/sep/01/israel-committing-genocide-in-gaza-worlds-top-scholars-on-the-say)<!-- HN:45093821:end --><!-- HN:45094156:start -->
* [45094156](https://news.social-protocols.org/stats?id=45094156) #15 4 points 1 comments -> [AI Couldn't Build My iPhone Podcast App](https://beard.fm/blog/ai-failed-my-podcast-app)<!-- HN:45094156:end --><!-- HN:45094785:start -->
* [45094785](https://news.social-protocols.org/stats?id=45094785) #16 11 points 1 comments -> [Our Genocide](https://www.btselem.org/publications/202507_our_genocide)<!-- HN:45094785:end --><!-- HN:45096359:start -->
* [45096359](https://news.social-protocols.org/stats?id=45096359) #18 -> [Gaza: AI Human Laboratory](https://www.thecairoreview.com/essays/gaza-israels-ai-human-laboratory/)<!-- HN:45096359:end -->
#### **Tuesday, September 2, 2025**
<!-- HN:45098262:start -->
* [45098262](https://news.social-protocols.org/stats?id=45098262) #29 8 points 1 comments -> [PewDiePie has a GitHub now](https://github.com/pewdiepie-archdaemon)<!-- HN:45098262:end --><!-- HN:45099619:start -->
* [45099619](https://news.social-protocols.org/stats?id=45099619) #16 21 points 14 comments -> [Vibe-Coding as We Need to Eat Our Own Dog Food](https://kevinkuipers.substack.com/p/vc-for-vibe-coding-a-fresh-new-start)<!-- HN:45099619:end --><!-- HN:45100801:start -->
* [45100801](https://news.social-protocols.org/stats?id=45100801) #2 13 points 0 comments -> [Five armed police officers arrest writer Graham Linehan in the UK for 3 tweets](https://grahamlinehan.substack.com/p/i-just-got-arrested-again)<!-- HN:45100801:end --><!-- HN:45100163:start -->
* [45100163](https://news.social-protocols.org/stats?id=45100163) #9 32 points 40 comments -> [A motto for programmers: "Tuere usorem, data, veritatem"](https://koas.dev/a-motto-for-programming/)<!-- HN:45100163:end --><!-- HN:45064241:start -->
* [45064241](https://news.social-protocols.org/stats?id=45064241) #20 17 points 40 comments -> [Primitive tortureboard: Untangling the myths and mysteries of Dvorak and QWERTY](https://aresluna.org/the-primitive-tortureboard/)<!-- HN:45064241:end --><!-- HN:45067251:start -->
* [45067251](https://news.social-protocols.org/stats?id=45067251) #29 48 points 32 comments -> [Memory is slow, Disk is fast – Part 1](https://www.bitflux.ai/blog/memory-is-slow-part1/)<!-- HN:45067251:end --><!-- HN:45104330:start -->
* [45104330](https://news.social-protocols.org/stats?id=45104330) #20 10 points 8 comments -> [US stocks fall as bond sell-off spills into equities](https://subs.ft.com/products)<!-- HN:45104330:end --><!-- HN:45104879:start -->
* [45104879](https://news.social-protocols.org/stats?id=45104879) #25 5 points 4 comments -> [Belgium to Recognise Palestinian State](https://www.theguardian.com/world/live/2025/sep/02/middle-east-crisis-israel-gaza-palestine-un-belgium-live-news-updates)<!-- HN:45104879:end --><!-- HN:45104115:start -->
* [45104115](https://news.social-protocols.org/stats?id=45104115) #3 21 points 44 comments -> [Why teach calculus in the age of AI](https://mappingignorance.org/2025/08/18/why-teach-calculus-in-the-age-of-ai/)<!-- HN:45104115:end --><!-- HN:45106903:start -->
* [45106903](https://news.social-protocols.org/stats?id=45106903) #30 156 points 52 comments -> [ICE obtains access to Israeli-made spyware that hack phones and encrypted apps](https://www.theguardian.com/us-news/2025/sep/02/trump-immigration-ice-israeli-spyware)<!-- HN:45106903:end -->