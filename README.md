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

#### **Tuesday, December 16, 2025**
<!-- HN:46283565:start -->
* [46283565](https://news.social-protocols.org/stats?id=46283565) #27 6 points 0 comments -> [Bondi lie peddled by Grok chatbot shows future of AI-poisoned info ecosystem](https://www.crikey.com.au/2025/12/16/elon-musk-ai-chatbot-grok-bondi-shooting-ahmed-al-ahmed/)<!-- HN:46283565:end --><!-- HN:46286313:start -->
* [46286313](https://news.social-protocols.org/stats?id=46286313) #8 8 points 6 comments -> [15,000 Free Pixel Art Icons](https://piixes.com/)<!-- HN:46286313:end --><!-- HN:46291827:start -->
* [46291827](https://news.social-protocols.org/stats?id=46291827) #8 53 points 13 comments -> [The new ChatGPT Images is here](https://openai.com/index/new-chatgpt-images-is-here/)<!-- HN:46291827:end -->
#### **Wednesday, December 17, 2025**
<!-- HN:46291414:start -->
* [46291414](https://news.social-protocols.org/stats?id=46291414) #22 444 points 211 comments -> [GitHub will begin charging for self-hosted action runners on March 2026](https://github.blog/changelog/2025-12-16-coming-soon-simpler-pricing-and-a-better-experience-for-github-actions/)<!-- HN:46291414:end --><!-- HN:46296181:start -->
* [46296181](https://news.social-protocols.org/stats?id=46296181) #11 24 points 42 comments -> [Americans overestimate how many social media users post harmful content](https://academic.oup.com/pnasnexus/article/4/12/pgaf310/8377954?login=false)<!-- HN:46296181:end --><!-- HN:46297767:start -->
* [46297767](https://news.social-protocols.org/stats?id=46297767) #9 23 points 13 comments -> [Why many Asian megacities are miserable places](https://www.economist.com/asia/2025/12/11/why-many-asian-megacities-are-miserable-places)<!-- HN:46297767:end --><!-- HN:46297336:start -->
* [46297336](https://news.social-protocols.org/stats?id=46297336) #27 62 points 29 comments -> [Locked out: How a gift card purchase destroyed an Apple account](https://appleinsider.com/articles/25/12/13/locked-out-how-a-gift-card-purchase-destroyed-an-apple-account)<!-- HN:46297336:end --><!-- HN:46226068:start -->
* [46226068](https://news.social-protocols.org/stats?id=46226068) #5 142 points 48 comments -> [Midjourney Is Alemwjsl](https://www.aadillpickle.com/blog/midjourney-is-alemwjsl)<!-- HN:46226068:end --><!-- HN:46219987:start -->
* [46219987](https://news.social-protocols.org/stats?id=46219987) #27 92 points 124 comments -> [Meta's new A.I. superstars are chafing against the rest of the company](https://www.nytimes.com/2025/12/10/technology/meta-ai-tbd-lab-friction.html)<!-- HN:46219987:end --><!-- HN:46230456:start -->
* [46230456](https://news.social-protocols.org/stats?id=46230456) #21 81 points 40 comments -> [VA Linux: The biggest dotcom IPO](https://dfarq.homeip.net/va-linux-the-biggest-dotcom-ipo/)<!-- HN:46230456:end --><!-- HN:46229761:start -->
* [46229761](https://news.social-protocols.org/stats?id=46229761) #30 47 points 25 comments -> [Show HN: Titan – JavaScript-first framework that compiles into a Rust server](https://www.npmjs.com/package/@ezetgalaxy/titan)<!-- HN:46229761:end --><!-- HN:46302010:start -->
* [46302010](https://news.social-protocols.org/stats?id=46302010) #28 24 points 40 comments -> [Ford Has Steered Its Former EV Truck and Plant Plans in to a Ditch](https://512pixels.net/2025/12/ford-ev-changes/)<!-- HN:46302010:end --><!-- HN:46303809:start -->
* [46303809](https://news.social-protocols.org/stats?id=46303809) #16 30 points 3 comments -> [Make Me CEO of Mozilla](https://blog.kingcons.io/posts/make-me-ceo-of-mozilla.html)<!-- HN:46303809:end --><!-- HN:46302892:start -->
* [46302892](https://news.social-protocols.org/stats?id=46302892) #26 19 points 5 comments -> [How, and why, I invented OnlyFans. In 2004](https://themosthandsomemanintheworld.com/how-and-why-i-invented-onlyfans-in-2004/)<!-- HN:46302892:end --><!-- HN:46233794:start -->
* [46233794](https://news.social-protocols.org/stats?id=46233794) #16 51 points 7 comments -> [Notes on Sorted Data](https://amit.prasad.me/blog/sorted-data)<!-- HN:46233794:end -->
#### **Thursday, December 18, 2025**
<!-- HN:46262875:start -->
* [46262875](https://news.social-protocols.org/stats?id=46262875) #22 4 points 2 comments -> [Ditch the Chain-of-Thought Hacks: A Modular System for Composing AI Operations](https://vibboai.com)<!-- HN:46262875:end --><!-- HN:46308263:start -->
* [46308263](https://news.social-protocols.org/stats?id=46308263) #27 3 points 0 comments -> [The Revolution Will Not Make the Hacker News Front Page](https://soatok.blog/2025/12/17/the-revolution-will-not-make-the-hacker-news-front-page/)<!-- HN:46308263:end --><!-- HN:46308300:start -->
* [46308300](https://news.social-protocols.org/stats?id=46308300) #25 5 points 1 comments -> [U.S. Customs and Border Protection Officer Charged with Bribery Offenses](https://www.justice.gov/usao-sdny/pr/us-customs-and-border-protection-officer-charged-bribery-offenses)<!-- HN:46308300:end --><!-- HN:46308295:start -->
* [46308295](https://news.social-protocols.org/stats?id=46308295) #12 3 points 2 comments -> [I Have to Live in a Forest to Work on Open Source](https://trop.in/blog/i-have-to-live-in-a-forest-to-work-on-open-source)<!-- HN:46308295:end --><!-- HN:46267015:start -->
* [46267015](https://news.social-protocols.org/stats?id=46267015) #24 8 points 0 comments -> [A Cosmic Offense: Elias Canetti's contest against death](https://www.commonwealmagazine.org/cosmic-offense)<!-- HN:46267015:end --><!-- HN:46311220:start -->
* [46311220](https://news.social-protocols.org/stats?id=46311220) #18 43 points 15 comments -> [America's Dirtiest Carbon Polluters, Mapped to Ridiculous Precision](https://gizmodo.com/americas-dirtiest-carbon-polluters-mapped-to-ridiculous-precision-2000700924)<!-- HN:46311220:end --><!-- HN:46310146:start -->
* [46310146](https://news.social-protocols.org/stats?id=46310146) #3 130 points 75 comments -> [GitHub Actions for Self-Hosted Runners Price Increase Postponed](https://pricetimeline.com/news/189)<!-- HN:46310146:end --><!-- HN:46317199:start -->
* [46317199](https://news.social-protocols.org/stats?id=46317199) #10 24 points 13 comments -> [Public Makes Millions on Plunging Crypto](https://cepr.net/publications/public-makes-trillions-on-plunging-crypto/)<!-- HN:46317199:end -->
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
* [46355227](https://news.social-protocols.org/stats?id=46355227) #23 25 points 18 comments -> [US Administration halted largest Offshore Wind project in the U.S.](https://www.cnbc.com/2025/12/22/trump-offshore-wind-cvow-dominion.html)<!-- HN:46355227:end --><!-- HN:46355793:start -->
* [46355793](https://news.social-protocols.org/stats?id=46355793) #19 29 points 40 comments -> [Spotify reportedly investigating Anna's Archive's scraping of their library](https://www.billboard.com/business/streaming/spotify-music-library-leak-1236143970/)<!-- HN:46355793:end --><!-- HN:46357227:start -->
* [46357227](https://news.social-protocols.org/stats?id=46357227) #30 5 points 0 comments -> [People Have Died in Crashes Where Tesla Doors Wouldn't Open](https://www.bloomberg.com/news/features/2025-12-22/tesla-door-safety-tied-to-at-least-15-auto-accident-deaths)<!-- HN:46357227:end --><!-- HN:46354773:start -->
* [46354773](https://news.social-protocols.org/stats?id=46354773) #28 28 points 40 comments -> [On the Existence, Impact, and Origin of Hallucination-Associated Neurons in LLMs](https://arxiv.org/abs/2512.01797)<!-- HN:46354773:end --><!-- HN:46356182:start -->
* [46356182](https://news.social-protocols.org/stats?id=46356182) #18 246 points 157 comments -> [Benn Jordan – This Flock Camera Leak Is Like Netflix for Stalkers [video]](https://www.youtube.com/watch?v=vU1-uiUlHTo)<!-- HN:46356182:end -->