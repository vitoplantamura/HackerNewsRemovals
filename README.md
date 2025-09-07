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
* [45100163](https://news.social-protocols.org/stats?id=45100163) #9 32 points 40 comments -> [A motto for programmers: "Tuere usorem, data, veritatem"](https://koas.dev/a-motto-for-programming/)<!-- HN:45100163:end --><!-- HN:45067251:start -->
* [45067251](https://news.social-protocols.org/stats?id=45067251) #29 48 points 32 comments -> [Memory is slow, Disk is fast – Part 1](https://www.bitflux.ai/blog/memory-is-slow-part1/)<!-- HN:45067251:end --><!-- HN:45104330:start -->
* [45104330](https://news.social-protocols.org/stats?id=45104330) #20 10 points 8 comments -> [US stocks fall as bond sell-off spills into equities](https://subs.ft.com/products)<!-- HN:45104330:end --><!-- HN:45104879:start -->
* [45104879](https://news.social-protocols.org/stats?id=45104879) #25 5 points 4 comments -> [Belgium to Recognise Palestinian State](https://www.theguardian.com/world/live/2025/sep/02/middle-east-crisis-israel-gaza-palestine-un-belgium-live-news-updates)<!-- HN:45104879:end --><!-- HN:45106903:start -->
* [45106903](https://news.social-protocols.org/stats?id=45106903) #30 156 points 52 comments -> [ICE obtains access to Israeli-made spyware that hack phones and encrypted apps](https://www.theguardian.com/us-news/2025/sep/02/trump-immigration-ice-israeli-spyware)<!-- HN:45106903:end -->
#### **Wednesday, September 3, 2025**
<!-- HN:45115549:start -->
* [45115549](https://news.social-protocols.org/stats?id=45115549) #22 20 points 40 comments -> [No place in children's hands: &lt;16s in UK to be banned from buying energy drinks](https://www.theguardian.com/business/2025/sep/02/children-energy-drinks-government-obesity-health)<!-- HN:45115549:end -->
#### **Thursday, September 4, 2025**<!-- HN:45126567:start -->
* [45126567](https://news.social-protocols.org/stats?id=45126567) #8 -> [Google's $45M contract to spread Netanyahu's propaganda](https://jackpoulson.substack.com/p/googles-45-million-contract-with)<!-- HN:45126567:end --><!-- HN:45127636:start -->
* [45127636](https://news.social-protocols.org/stats?id=45127636) #20 140 points 62 comments -> [Atlassian is acquiring the Browser Company](https://www.cnbc.com/2025/09/04/atlassian-the-browser-company-deal.html)<!-- HN:45127636:end --><!-- HN:45127232:start -->
* [45127232](https://news.social-protocols.org/stats?id=45127232) #8 76 points 32 comments -> [Browser Company (makers of Arc browser) Acquired By Atlassian for $610M](https://browsercompany.substack.com/p/your-tuesday-in-2030)<!-- HN:45127232:end --><!-- HN:45126500:start -->
* [45126500](https://news.social-protocols.org/stats?id=45126500) #13 64 points 18 comments -> [The company behind the Dia and Arc browsers is being acquired](https://www.theverge.com/web/770947/browser-company-arc-dia-acquired-atlassian)<!-- HN:45126500:end --><!-- HN:45132729:start -->
* [45132729](https://news.social-protocols.org/stats?id=45132729) #13 28 points 9 comments -> [They blew up a boat far offshore, killed eleven people, and called it justice](https://mitchthelawyer.substack.com/p/they-blew-up-a-boat-far-offshore)<!-- HN:45132729:end -->
#### **Friday, September 5, 2025**
<!-- HN:45094324:start -->
* [45094324](https://news.social-protocols.org/stats?id=45094324) #5 46 points 1 comments -> [The Unix Conspiracy](http://www.catb.org/~esr/jargon/html/U/Unix-conspiracy.html)<!-- HN:45094324:end --><!-- HN:45134212:start -->
* [45134212](https://news.social-protocols.org/stats?id=45134212) #3 44 points 10 comments -> [MIT says AI isn't replacing you it's just wasting your boss's money](https://www.interviewquery.com/p/mit-ai-isnt-replacing-workers-just-wasting-money)<!-- HN:45134212:end --><!-- HN:45134438:start -->
* [45134438](https://news.social-protocols.org/stats?id=45134438) #11 6 points 0 comments -> [simonw has vibe-coded 124 useful tools](https://simonwillison.net/2025/Sep/4/highlighted-tools/)<!-- HN:45134438:end --><!-- HN:45134771:start -->
* [45134771](https://news.social-protocols.org/stats?id=45134771) #11 10 points 11 comments -> [Expanding Economic Opportunity with AI](https://openai.com/index/expanding-economic-opportunity-with-ai/)<!-- HN:45134771:end --><!-- HN:45092621:start -->
* [45092621](https://news.social-protocols.org/stats?id=45092621) #8 25 points 5 comments -> [Show HN: First Half of "Swimming in Tech Debt" (book about tech debt)](https://helpthisbook.com/lou-franco/swimming-in-tech-debt)<!-- HN:45092621:end --><!-- HN:45135895:start -->
* [45135895](https://news.social-protocols.org/stats?id=45135895) #10 5 points 0 comments -> [To what extent is the war in Gaza justified?](https://mathsandsoundingoff.wordpress.com/2025/06/23/to-what-extent-is-the-war-in-gaza-justified/)<!-- HN:45135895:end --><!-- HN:45139122:start -->
* [45139122](https://news.social-protocols.org/stats?id=45139122) #4 10 points 8 comments -> [Why Browser Company at $610M is cheap](https://bigtechpr.substack.com/p/why-browser-co-610m-is-cheap)<!-- HN:45139122:end --><!-- HN:45095591:start -->
* [45095591](https://news.social-protocols.org/stats?id=45095591) #29 26 points 7 comments -> [The Diffusion Dilemma](https://arenamag.com/articles/the-diffusion-dilemma)<!-- HN:45095591:end --><!-- HN:45140991:start -->
* [45140991](https://news.social-protocols.org/stats?id=45140991) #8 6 points 0 comments -> [USA Cycling bans transgender athletes from female categories beginning Sep. 15](https://www.cyclingweekly.com/news/usa-cycling-bans-transgender-athletes-from-female-categories-beginning-september-15-2025)<!-- HN:45140991:end --><!-- HN:45108026:start -->
* [45108026](https://news.social-protocols.org/stats?id=45108026) #29 8 points 0 comments -> [How to Spot (and Fix) 5 Common Performance Bottlenecks in Pandas Workflows](https://developer.nvidia.com/blog/how-to-spot-and-fix-5-common-performance-bottlenecks-in-pandas-workflows/)<!-- HN:45108026:end --><!-- HN:45143481:start -->
* [45143481](https://news.social-protocols.org/stats?id=45143481) #12 12 points 3 comments -> [Boys vs. Women: Male High School Athletes vs. Female Olympians](https://boysvswomen.com/?2016)<!-- HN:45143481:end -->
#### **Saturday, September 6, 2025**
<!-- HN:45102536:start -->
* [45102536](https://news.social-protocols.org/stats?id=45102536) #22 16 points 0 comments -> [Everything About Bitflags: How to store up to 32 booleans in one value?](https://neg4n.dev/blog/everything-about-bitflags)<!-- HN:45102536:end --><!-- HN:45149330:start -->
* [45149330](https://news.social-protocols.org/stats?id=45149330) #12 14 points 10 comments -> [Vibe Coding Through the Berghain Challenge](https://www.nibzard.com/berghain/)<!-- HN:45149330:end --><!-- HN:45150749:start -->
* [45150749](https://news.social-protocols.org/stats?id=45150749) #18 4 points 0 comments -> [Stock buybacks are stock swindles](https://pluralistic.net/2025/09/06/computer-says-huh/#invisible-handcuffs)<!-- HN:45150749:end --><!-- HN:45148572:start -->
* [45148572](https://news.social-protocols.org/stats?id=45148572) #15 43 points 2 comments -> [Tylenol-maker shares hit after report RFK Jr will suggest autism link](https://www.bbc.com/news/articles/cx25l92q9xgo)<!-- HN:45148572:end --><!-- HN:45151573:start -->
* [45151573](https://news.social-protocols.org/stats?id=45151573) #7 7 points 0 comments -> [Study: Hashtags and humour are used to spread extreme content on social media](https://news.ku.dk/all_news/2025/09/hashtags-and-humour-are-used-to-spread-extreme-content-on-social-media/)<!-- HN:45151573:end --><!-- HN:45151539:start -->
* [45151539](https://news.social-protocols.org/stats?id=45151539) #17 10 points 1 comments -> [Microsoft BASIC, now open source](https://www.pcworld.com/article/2898698/microsofts-first-ever-programming-language-was-just-open-sourced.html)<!-- HN:45151539:end --><!-- HN:45151686:start -->
* [45151686](https://news.social-protocols.org/stats?id=45151686) #18 11 points 0 comments -> [Ghost sharks grow forehead teeth to help them have sex](https://news.ufl.edu/2025/09/ghost-shark-teeth/)<!-- HN:45151686:end -->
#### **Sunday, September 7, 2025**
<!-- HN:45154176:start -->
* [45154176](https://news.social-protocols.org/stats?id=45154176) #3 111 points 1 comments -> [mitchivin.com](https://mitchivin.com/)<!-- HN:45154176:end --><!-- HN:45117718:start -->
* [45117718](https://news.social-protocols.org/stats?id=45117718) #11 35 points 2 comments -> [Reveal – Read Eval Visualize Loop for Clojure](https://vlaaad.github.io/reveal/)<!-- HN:45117718:end --><!-- HN:45156660:start -->
* [45156660](https://news.social-protocols.org/stats?id=45156660) #8 13 points 4 comments -> [Nominees: The fastest legal way to lose your company](https://johnnydoe.is/threads/nominees-the-fastest-legal-way-to-lose-your-company.42278/)<!-- HN:45156660:end --><!-- HN:45157748:start -->
* [45157748](https://news.social-protocols.org/stats?id=45157748) #12 14 points 13 comments -> [ChatGPT is NOT a LLM – GPT is](https://www.vincirufus.com/posts/chatgpt-is-not-an-llm/)<!-- HN:45157748:end --><!-- HN:45158525:start -->
* [45158525](https://news.social-protocols.org/stats?id=45158525) #21 37 points 18 comments -> [Chrome extension that replaces occurrences of 'the cloud' with 'my butt'](https://github.com/panicsteve/cloud-to-butt)<!-- HN:45158525:end --><!-- HN:45158586:start -->
* [45158586](https://news.social-protocols.org/stats?id=45158586) #3 58 points 24 comments -> [AI Mode Is Good](https://simonwillison.net/2025/Sep/7/ai-mode/)<!-- HN:45158586:end -->