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

#### **Tuesday, December 3, 2024**
<!-- HN:42302342:start -->
* [42302342](https://news.social-protocols.org/stats?id=42302342) #25 27 points 12 comments -> [European Federation of Journalists to stop posting content on X](https://www.thelondoneconomic.com/news/media/european-federation-of-journalists-to-stop-posting-content-on-x-386598/)<!-- HN:42302342:end --><!-- HN:42304161:start -->
* [42304161](https://news.social-protocols.org/stats?id=42304161) #16 10 points 7 comments -> [Jaguar Introduces Type 00](https://www.jaguar.com/copy-nothing/jaguar-type-00.html)<!-- HN:42304161:end --><!-- HN:42303903:start -->
* [42303903](https://news.social-protocols.org/stats?id=42303903) #16 201 points 54 comments -> [No need to email me about Cisco AnyConnect](https://daniel.haxx.se/blog/2024/12/03/no-need-to-email-me-about-cisco-anyconnect/)<!-- HN:42303903:end --><!-- HN:42306261:start -->
* [42306261](https://news.social-protocols.org/stats?id=42306261) #27 26 points 9 comments -> [South Korea declares martial law](https://www.koreaherald.com/view.php?ud=20241203050117)<!-- HN:42306261:end --><!-- HN:42302963:start -->
* [42302963](https://news.social-protocols.org/stats?id=42302963) #19 225 points 99 comments -> [Twice-Yearly HIV Shot Shows 100% Effectiveness in Women](https://apnews.com/article/hiv-infections-aids-prevention-shot-02606f7d7892f0baf55bd0a0ff2ba3de)<!-- HN:42302963:end --><!-- HN:42303054:start -->
* [42303054](https://news.social-protocols.org/stats?id=42303054) #16 63 points 19 comments -> [Guile-Emacs Relaunched](https://emacsconf.org/2024/talks/guile/)<!-- HN:42303054:end --><!-- HN:42303111:start -->
* [42303111](https://news.social-protocols.org/stats?id=42303111) #15 211 points 125 comments -> [Raspberry Pi boosts Pi 5 performance with SDRAM tuning](https://www.jeffgeerling.com/blog/2024/raspberry-pi-boosts-pi-5-performance-sdram-tuning)<!-- HN:42303111:end --><!-- HN:42303274:start -->
* [42303274](https://news.social-protocols.org/stats?id=42303274) #17 224 points 146 comments -> [Blizzard's pulling of Warcraft I and II tests GOG's new Preservation Program](https://arstechnica.com/gaming/2024/12/blizzards-pulling-of-warcraft-i-ii-tests-gogs-new-preservation-program/)<!-- HN:42303274:end --><!-- HN:42307065:start -->
* [42307065](https://news.social-protocols.org/stats?id=42307065) #4 20 points 6 comments -> [AI Advent of Code: Implementing Papers](https://www.leetarxiv.com/)<!-- HN:42307065:end --><!-- HN:42308564:start -->
* [42308564](https://news.social-protocols.org/stats?id=42308564) #14 9 points 2 comments -> [America Stopped Cooking with Tallow for a Reason](https://www.theatlantic.com/health/archive/2024/12/beef-tallow-kennedy-cooking-fat-seed-oil/680848/)<!-- HN:42308564:end --><!-- HN:42308864:start -->
* [42308864](https://news.social-protocols.org/stats?id=42308864) #20 8 points 0 comments -> [Three years after opening, X Denver residents say the party is over](https://www.denverpost.com/2024/12/02/x-denver-apartments-union-station-update/)<!-- HN:42308864:end --><!-- HN:42308733:start -->
* [42308733](https://news.social-protocols.org/stats?id=42308733) #29 10 points 0 comments -> [South Korean Lawmakers Vote to Defy President, Demanding an End to Martial Law](https://www.nytimes.com/live/2024/12/03/world/south-korea-martial-law)<!-- HN:42308733:end --><!-- HN:42309560:start -->
* [42309560](https://news.social-protocols.org/stats?id=42309560) #19 14 points 3 comments -> [Christopher Hitchens and the Necessity of Universalism](https://salmagundi.skidmore.edu/articles/479-guest-column-christopher-hitchens-and-the-necessity-of-universalism)<!-- HN:42309560:end --><!-- HN:42287930:start -->
* [42287930](https://news.social-protocols.org/stats?id=42287930) #12 13 points 2 comments -> [Show HN: Simtown: A 2D Role-Playing Game Where Characters Talk, Move, and Act](https://app.simtown.ai/)<!-- HN:42287930:end --><!-- HN:42309010:start -->
* [42309010](https://news.social-protocols.org/stats?id=42309010) #1 127 points 3 comments -> [Intel Launches Arc B-Series Graphics Cards](https://www.intel.com/content/www/us/en/products/docs/discrete-gpus/arc/desktop/b-series/overview.html)<!-- HN:42309010:end --><!-- HN:42309742:start -->
* [42309742](https://news.social-protocols.org/stats?id=42309742) #16 22 points 6 comments -> [Webhooks Are Harder Than They Seem](https://www.svix.com/blog/webhooks-are-harder-than-they-seem/)<!-- HN:42309742:end --><!-- HN:42308348:start -->
* [42308348](https://news.social-protocols.org/stats?id=42308348) #26 59 points 17 comments -> [FTC Bans Location Data Company That Powers the Surveillance Ecosystem](https://www.404media.co/ftc-bans-location-data-company-that-powers-the-surveillance-ecosystem/)<!-- HN:42308348:end --><!-- HN:42311895:start -->
* [42311895](https://news.social-protocols.org/stats?id=42311895) #15 14 points 2 comments -> [Why Did Intel Fire CEO Pat Gelsinger?](https://www.semiaccurate.com/2024/12/03/why-did-intel-fire-ceo-pat-gelsinger/)<!-- HN:42311895:end -->
#### **Wednesday, December 4, 2024**
<!-- HN:42313450:start -->
* [42313450](https://news.social-protocols.org/stats?id=42313450) #9 3 points 1 comments -> [Andy Grove: Rich, Famous, Smart and Wrong (2007)](https://www.science.org/content/blog-post/andy-grove-rich-famous-smart-and-wrong)<!-- HN:42313450:end --><!-- HN:42311764:start -->
* [42311764](https://news.social-protocols.org/stats?id=42311764) #22 13 points 6 comments -> [Against 'Free Market Authoritarianism'](https://isonomiaquarterly.com/volume-2-issue-4/against-free-market-authoritarianism/)<!-- HN:42311764:end --><!-- HN:42235792:start -->
* [42235792](https://news.social-protocols.org/stats?id=42235792) #28 124 points 99 comments -> [The Curse of Markdown](https://codehike.org/blog/the-curse-of-markdown)<!-- HN:42235792:end --><!-- HN:42316398:start -->
* [42316398](https://news.social-protocols.org/stats?id=42316398) #12 13 points 1 comments -> [House panel concludes that Covid-19 pandemic came from a lab leak](https://www.science.org/content/article/house-panel-concludes-covid-19-pandemic-came-lab-leak)<!-- HN:42316398:end --><!-- HN:42313507:start -->
* [42313507](https://news.social-protocols.org/stats?id=42313507) #10 177 points 108 comments -> [No Nat November: My Month Without IPv4](https://blog.infected.systems/posts/2024-12-01-no-nat-november/)<!-- HN:42313507:end --><!-- HN:42315364:start -->
* [42315364](https://news.social-protocols.org/stats?id=42315364) #11 20 points 15 comments -> [Pinecone integrates AI inferencing with vector database](https://blocksandfiles.com/2024/12/02/pinecone-integrates-ai-inferencing-with-its-vector-database/)<!-- HN:42315364:end --><!-- HN:42255310:start -->
* [42255310](https://news.social-protocols.org/stats?id=42255310) #12 31 points 5 comments -> [Dark Mode in CSS Guide](https://css-tricks.com/a-complete-guide-to-dark-mode-on-the-web/)<!-- HN:42255310:end --><!-- HN:42312277:start -->
* [42312277](https://news.social-protocols.org/stats?id=42312277) #15 109 points 27 comments -> [A new home for Python-build-standalone](https://astral.sh/blog/python-build-standalone)<!-- HN:42312277:end --><!-- HN:42310683:start -->
* [42310683](https://news.social-protocols.org/stats?id=42310683) #16 128 points 178 comments -> [Stephen King to shut down his 3 radio stations in Maine](https://www.nytimes.com/2024/12/03/arts/stephen-king-maine-radio-stations.html)<!-- HN:42310683:end --><!-- HN:42305348:start -->
* [42305348](https://news.social-protocols.org/stats?id=42305348) #15 252 points 245 comments -> [Dependency management fatigue, or why I ditched React for Go+HTMX+Templ](https://blog.erodriguez.de/dependency-management-fatigue-or-why-i-forever-ditched-react-for-go-htmx-templ/)<!-- HN:42305348:end --><!-- HN:42311828:start -->
* [42311828](https://news.social-protocols.org/stats?id=42311828) #16 73 points 18 comments -> [Creating a Proxmox or QEMU ChromeOS Flex VM](https://kevindavid.org/code/2024/03/20/chrome-os-flex-proxmox.html)<!-- HN:42311828:end --><!-- HN:42314024:start -->
* [42314024](https://news.social-protocols.org/stats?id=42314024) #20 136 points 7 comments -> [EmacsConf 2024](https://emacsconf.org/2024/)<!-- HN:42314024:end --><!-- HN:42315969:start -->
* [42315969](https://news.social-protocols.org/stats?id=42315969) #26 49 points 3 comments -> [You're Breathtaking [Godot #100000]](https://github.com/godotengine/godot/issues/100000)<!-- HN:42315969:end --><!-- HN:42317698:start -->
* [42317698](https://news.social-protocols.org/stats?id=42317698) #9 10 points 1 comments -> [CEO of UnitedHealthcare Is Killed in Midtown Manhattan](https://www.nytimes.com/2024/12/04/nyregion/shooting-midtown-nyc-united-healthcare-brian-thompson.html)<!-- HN:42317698:end --><!-- HN:42288441:start -->
* [42288441](https://news.social-protocols.org/stats?id=42288441) #19 3 points 0 comments -> [Ephemeral Resource Configuration Reference](https://developer.hashicorp.com/terraform/language/v1.10.x/resources/ephemeral)<!-- HN:42288441:end --><!-- HN:42317511:start -->
* [42317511](https://news.social-protocols.org/stats?id=42317511) #3 6 points 1 comments -> [How to look out for yourself inside a particular company (2018)](https://rachelbythebay.com/w/2018/03/21/next/)<!-- HN:42317511:end --><!-- HN:42317991:start -->
* [42317991](https://news.social-protocols.org/stats?id=42317991) #23 20 points 23 comments -> [Telegram U-turns and joins child safety scheme](https://www.bbc.com/news/articles/c5yd35l0r91o)<!-- HN:42317991:end --><!-- HN:42320015:start -->
* [42320015](https://news.social-protocols.org/stats?id=42320015) #11 3 points 1 comments -> [The Planning Machine (2014)](https://www.newyorker.com/magazine/2014/10/13/planning-machine)<!-- HN:42320015:end --><!-- HN:42261953:start -->
* [42261953](https://news.social-protocols.org/stats?id=42261953) #14 7 points 1 comments -> [Quantum scars make their mark in graphene](https://www.nature.com/articles/d41586-024-03649-y)<!-- HN:42261953:end --><!-- HN:42319041:start -->
* [42319041](https://news.social-protocols.org/stats?id=42319041) #29 21 points 12 comments -> [Pisces: UK regulated market for private shares [pdf]](https://assets.publishing.service.gov.uk/media/67374daf12f25d730812722c/PISCES_consultation_response_November_2024_vf.pdf)<!-- HN:42319041:end -->
#### **Thursday, December 5, 2024**
<!-- HN:42323235:start -->
* [42323235](https://news.social-protocols.org/stats?id=42323235) #23 75 points 45 comments -> [Deploying Containers on NixOS: A Guide](https://bkiran.com/blog/deploying-containers-nixos)<!-- HN:42323235:end --><!-- HN:42325697:start -->
* [42325697](https://news.social-protocols.org/stats?id=42325697) #6 9 points 1 comments -> [Bitcoin Hits a Milestone: $100k](https://www.nytimes.com/2024/12/04/technology/bitcoin-price-record.html)<!-- HN:42325697:end --><!-- HN:42285206:start -->
* [42285206](https://news.social-protocols.org/stats?id=42285206) #22 56 points 66 comments -> [A made-up name is better than no name](https://mbuffett.com/posts/a-made-up-name)<!-- HN:42285206:end --><!-- HN:42299042:start -->
* [42299042](https://news.social-protocols.org/stats?id=42299042) #18 30 points 38 comments -> [Why are doctors wary of wearables?](https://www.bbc.com/news/articles/c79zpzdv4vno)<!-- HN:42299042:end --><!-- HN:42325922:start -->
* [42325922](https://news.social-protocols.org/stats?id=42325922) #6 5 points 0 comments -> [Amnesty change genocide definition in order to attack Israel](https://twitter.com/MarkGoldfeder/status/1864494075220509115)<!-- HN:42325922:end --><!-- HN:42326287:start -->
* [42326287](https://news.social-protocols.org/stats?id=42326287) #26 7 points 3 comments -> [Bitcoin surges past $100k for first time](https://www.bbc.co.uk/news/articles/cqj0wkwv1x2o)<!-- HN:42326287:end --><!-- HN:42249474:start -->
* [42249474](https://news.social-protocols.org/stats?id=42249474) #5 25 points 15 comments -> [Licking this "lollipop" will let you taste virtual flavors](https://arstechnica.com/science/2024/11/licking-this-lollipop-will-let-you-taste-virtual-flavors/)<!-- HN:42249474:end --><!-- HN:42327005:start -->
* [42327005](https://news.social-protocols.org/stats?id=42327005) #17 21 points 40 comments -> [How close is AI to human-level intelligence?](https://www.nature.com/articles/d41586-024-03905-1)<!-- HN:42327005:end --><!-- HN:42326346:start -->
* [42326346](https://news.social-protocols.org/stats?id=42326346) #27 6 points 3 comments -> [Building HTML in Go](https://templ.guide/)<!-- HN:42326346:end --><!-- HN:42328851:start -->
* [42328851](https://news.social-protocols.org/stats?id=42328851) #18 -> [It's Time to Defend Ourselves in Space](https://medium.com/@ToryBrunoULA/its-time-to-defend-ourselves-in-space-69608ab3da8f)<!-- HN:42328851:end --><!-- HN:42331341:start -->
* [42331341](https://news.social-protocols.org/stats?id=42331341) #14 15 points 1 comments -> [US West Coast Tsunami Warning](https://www.tsunami.gov/events/PAAQ/2024/12/05/so1aq0/1/WEAK51/WEAK51.txt)<!-- HN:42331341:end -->
#### **Friday, December 6, 2024**<!-- HN:42334872:start -->
* [42334872](https://news.social-protocols.org/stats?id=42334872) #3 58 points 7 comments -> [Assassination Is a Leaky Abstraction](https://coldwaters.substack.com/p/assassination-is-a-leaky-abstraction)<!-- HN:42334872:end --><!-- HN:42339071:start -->
* [42339071](https://news.social-protocols.org/stats?id=42339071) #29 4 points 0 comments -> [Former zynga CEO turns into a pro-genocide activist](https://twitter.com/StopArabHate/status/1864725936874176618)<!-- HN:42339071:end --><!-- HN:42340035:start -->
* [42340035](https://news.social-protocols.org/stats?id=42340035) #2 13 points 6 comments -> [Zero-based regulation made Idaho the least regulated state in the US](https://manhattan.institute/article/zero-based-regulation-a-step-by-step-guide-for-states)<!-- HN:42340035:end --><!-- HN:42330055:start -->
* [42330055](https://news.social-protocols.org/stats?id=42330055) #13 381 points 109 comments -> [7 Databases in 7 Weeks for 2025](https://matt.blwt.io/post/7-databases-in-7-weeks-for-2025/)<!-- HN:42330055:end --><!-- HN:42341566:start -->
* [42341566](https://news.social-protocols.org/stats?id=42341566) #13 21 points 20 comments -> [Serverless VPN Self-hosted Be your own private on-demand VPN provider](https://serverlessvpn.com)<!-- HN:42341566:end -->
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
<!-- HN:42362259:start -->
* [42362259](https://news.social-protocols.org/stats?id=42362259) #2 -> [A Man Was Murdered in Cold Blood and You're Laughing?](https://www.newyorker.com/news/the-lede/what-the-murder-of-the-unitedhealthcare-ceo-brian-thompson-means-to-america)<!-- HN:42362259:end -->