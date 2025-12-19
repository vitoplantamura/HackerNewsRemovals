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

#### **Saturday, December 13, 2025**
<!-- HN:46192924:start -->
* [46192924](https://news.social-protocols.org/stats?id=46192924) #29 7 points 3 comments -> [How we built context management for tab completion](https://docs.getpochi.com/developer-updates/context-management-in-your-editor/)<!-- HN:46192924:end --><!-- HN:46251852:start -->
* [46251852](https://news.social-protocols.org/stats?id=46251852) #26 -> [Show HN: Claude Code Recipes for Knowledge Workers (Open Source)](https://github.com/sgharlow/claude-code-recipes)<!-- HN:46251852:end --><!-- HN:46254276:start -->
* [46254276](https://news.social-protocols.org/stats?id=46254276) #11 45 points 57 comments -> [AI is bringing old nuclear plants out of retirement](https://www.wbur.org/hereandnow/2025/12/09/nuclear-power-ai)<!-- HN:46254276:end --><!-- HN:46255697:start -->
* [46255697](https://news.social-protocols.org/stats?id=46255697) #1 9 points 14 comments -> [Show HN: Kinkora – A creative playground for experimenting with video models](https://kinkora.fun/)<!-- HN:46255697:end --><!-- HN:46255158:start -->
* [46255158](https://news.social-protocols.org/stats?id=46255158) #23 32 points 23 comments -> [Show HN: I audited 500 K8s pods. Java wastes ~48% RAM, Go ~18%](https://github.com/WozzHQ/wozz)<!-- HN:46255158:end --><!-- HN:46259102:start -->
* [46259102](https://news.social-protocols.org/stats?id=46259102) #2 15 points 0 comments -> [Multiple shootings by active shooter at Brown University](https://www.brown.edu/)<!-- HN:46259102:end -->
#### **Sunday, December 14, 2025**
<!-- HN:46261739:start -->
* [46261739](https://news.social-protocols.org/stats?id=46261739) #2 56 points 34 comments -> [Surface Tension of Software](https://iamstelios.com/blog/surface-tension-of-software/)<!-- HN:46261739:end --><!-- HN:46263874:start -->
* [46263874](https://news.social-protocols.org/stats?id=46263874) #8 16 points 21 comments -> [AI was not invented, it arrived](https://andrewarrow.dev/2025/12/ai-was-not-invented-it-arrived/)<!-- HN:46263874:end --><!-- HN:46265378:start -->
* [46265378](https://news.social-protocols.org/stats?id=46265378) #28 3 points 1 comments -> [Hero who disarmed one of the Bondi Beach attackers by grabbing his gun](https://www.dailymail.co.uk/news/article-15382973/Hero-disarmed-one-Bondi-Beach-attackers-grabbing-gun-father-two-fruit-shop-owner.html)<!-- HN:46265378:end --><!-- HN:46264955:start -->
* [46264955](https://news.social-protocols.org/stats?id=46264955) #6 28 points 35 comments -> [Sacrificing accessibility for not getting web scraped](https://tilschuenemann.de/projects/sacrificing-accessibility-for-not-getting-web-scraped)<!-- HN:46264955:end --><!-- HN:46265457:start -->
* [46265457](https://news.social-protocols.org/stats?id=46265457) #29 5 points 2 comments -> [Mass shooting in Australia – 12 dead -terrorist event](https://www.dailytelegraph.com.au/news/nsw/beachgoers-flee-as-gunshots-heard-in-bondi/live-coverage/f7f1e82a4b957533cac56ba0809cb9ba)<!-- HN:46265457:end --><!-- HN:46265697:start -->
* [46265697](https://news.social-protocols.org/stats?id=46265697) #30 6 points 4 comments -> [Update Now Warning Issued to All iPhone Users](https://www.forbes.com/sites/kateoflahertyuk/2025/12/14/ios-262-update-now-waning-issued-to-all-iphone-users/)<!-- HN:46265697:end --><!-- HN:46265627:start -->
* [46265627](https://news.social-protocols.org/stats?id=46265627) #25 8 points 6 comments -> [Cisco Finally Did It](https://www.ft.com/content/b27ae706-6244-4337-81cd-5204bd2b9a00)<!-- HN:46265627:end --><!-- HN:46265794:start -->
* [46265794](https://news.social-protocols.org/stats?id=46265794) #13 6 points 1 comments -> [Freakpages](https://freakpages.org/)<!-- HN:46265794:end --><!-- HN:46266655:start -->
* [46266655](https://news.social-protocols.org/stats?id=46266655) #26 24 points 36 comments -> [Opus 4.5 is the first model that makes me fear for my job](https://old.reddit.com/r/ClaudeAI/comments/1pmgk5c/opus_45_is_the_first_model_that_makes_me_actually/)<!-- HN:46266655:end -->
#### **Monday, December 15, 2025**
<!-- HN:46268585:start -->
* [46268585](https://news.social-protocols.org/stats?id=46268585) #11 13 points 3 comments -> [Microsoft AI](https://microsoft.ai/)<!-- HN:46268585:end --><!-- HN:46269121:start -->
* [46269121](https://news.social-protocols.org/stats?id=46269121) #5 15 points 4 comments -> [Signal1996.net](https://signal1996.net/)<!-- HN:46269121:end --><!-- HN:46268809:start -->
* [46268809](https://news.social-protocols.org/stats?id=46268809) #4 -> [Frances Elizabeth Allen: The Woman Who Made Code Run Fast – and Was Forgotten](https://voxmeditantis.com/2025/12/13/frances-elizabeth-allen-the-woman-who-made-code-run-fast-and-was-forgotten-because-it-worked/)<!-- HN:46268809:end --><!-- HN:46270264:start -->
* [46270264](https://news.social-protocols.org/stats?id=46270264) #4 7 points 0 comments -> [The Generative AI Industry Is Fraudulent, Immoral and Dangerous](https://dianne.skoll.ca/writings/ai-is-bad/)<!-- HN:46270264:end --><!-- HN:46270746:start -->
* [46270746](https://news.social-protocols.org/stats?id=46270746) #3 33 points 2 comments -> [Rob Reiner,Legendary Director and Actor,and Wife Found Dead in Apparent Homicide](https://www.rollingstone.com/tv-movies/tv-movie-news/rob-reiner-ldead-obituary-1235483876/)<!-- HN:46270746:end --><!-- HN:46270597:start -->
* [46270597](https://news.social-protocols.org/stats?id=46270597) #22 12 points 1 comments -> [SVG Fullstack Website](https://github.com/icitry/SVGWebsite)<!-- HN:46270597:end --><!-- HN:46271250:start -->
* [46271250](https://news.social-protocols.org/stats?id=46271250) #28 5 points 0 comments -> [Risk of acute kidney injury and mortality in patients vaccinated for Covid-19](https://www.medsci.org/v22p4483.htm)<!-- HN:46271250:end --><!-- HN:46270972:start -->
* [46270972](https://news.social-protocols.org/stats?id=46270972) #30 70 points 27 comments -> [Why proteins fold and how GPUs help us fold](https://aval.bearblog.dev/nvidiaproteins/)<!-- HN:46270972:end --><!-- HN:46198177:start -->
* [46198177](https://news.social-protocols.org/stats?id=46198177) #27 81 points 55 comments -> [Running on Empty: Copper](https://thehonestsorcerer.substack.com/p/running-on-empty-copper)<!-- HN:46198177:end --><!-- HN:46173762:start -->
* [46173762](https://news.social-protocols.org/stats?id=46173762) #4 42 points 12 comments -> [Make images smaller using best-in-class codecs, right in the browser](https://github.com/GoogleChromeLabs/squoosh)<!-- HN:46173762:end --><!-- HN:46182975:start -->
* [46182975](https://news.social-protocols.org/stats?id=46182975) #6 77 points 25 comments -> [P-computers can solve spin-glass problems faster than quantum systems](https://news.ucsb.edu/2025/022239/new-ucsb-research-shows-p-computers-can-solve-spin-glass-problems-faster-quantum)<!-- HN:46182975:end --><!-- HN:46189205:start -->
* [46189205](https://news.social-protocols.org/stats?id=46189205) #10 61 points 11 comments -> [Speech and Language Processing (3rd ed. draft)](https://web.stanford.edu/~jurafsky/slp3/)<!-- HN:46189205:end --><!-- HN:46189011:start -->
* [46189011](https://news.social-protocols.org/stats?id=46189011) #17 40 points 13 comments -> [Finnix](https://en.wikipedia.org/wiki/Finnix)<!-- HN:46189011:end --><!-- HN:46181628:start -->
* [46181628](https://news.social-protocols.org/stats?id=46181628) #22 68 points 18 comments -> [DNA Learning Center: Mechanism of Replication 3D Animation](https://dnalc.cshl.edu/resources/3d/04-mechanism-of-replication-advanced.html)<!-- HN:46181628:end --><!-- HN:46279674:start -->
* [46279674](https://news.social-protocols.org/stats?id=46279674) #14 46 points 2 comments -> [Google discontinuing their dark web report](https://support.google.com/websearch/answer/16767242?hl=en&co=GENIE.Platform%3DAndroid)<!-- HN:46279674:end --><!-- HN:46281435:start -->
* [46281435](https://news.social-protocols.org/stats?id=46281435) #28 4 points 2 comments -> [Killed by Google](https://killedbygoogle.com)<!-- HN:46281435:end -->
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
* [46258377](https://news.social-protocols.org/stats?id=46258377) #22 37 points 40 comments -> [Does my key fob have more computing power than the Lunar lander?](https://www.buzzsprout.com/2469780/episodes/18340142-17-does-my-key-fob-have-more-computing-power-than-the-lunar-lander)<!-- HN:46258377:end -->