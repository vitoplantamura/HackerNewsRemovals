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

#### **Monday, August 19, 2024**
<!-- HN:41247991:start -->
* [41247991](https://news.social-protocols.org/stats?id=41247991) #6 31 points 6 comments -> [Animate.css: Seamless CSS Animations Across All Browsers](https://github.com/animate-css/animate.css)<!-- HN:41247991:end --><!-- HN:41287014:start -->
* [41287014](https://news.social-protocols.org/stats?id=41287014) #17 150 points 90 comments -> [Eric Schmidt deleted Stanford interview](https://www.youtube.com/watch?v=3f6XM6_7pUE)<!-- HN:41287014:end --><!-- HN:41288958:start -->
* [41288958](https://news.social-protocols.org/stats?id=41288958) #27 4 points 0 comments -> [2GB Raspberry Pi 5 on sale now at $50](https://www.raspberrypi.com/news/2gb-raspberry-pi-5-on-sale-now-at-50/)<!-- HN:41288958:end --><!-- HN:41288510:start -->
* [41288510](https://news.social-protocols.org/stats?id=41288510) #4 4 points 1 comments -> [The Guide to Build a Profitable Flippa Clone App](https://www.trioangle.com/blog/build-flippa-clone-app/)<!-- HN:41288510:end --><!-- HN:41283367:start -->
* [41283367](https://news.social-protocols.org/stats?id=41283367) #24 96 points 46 comments -> [Bold Edit: An editor written by power users](https://bold-edit.com)<!-- HN:41283367:end --><!-- HN:41289096:start -->
* [41289096](https://news.social-protocols.org/stats?id=41289096) #21 6 points 1 comments -> [What comes after the AI crash?](https://disconnect.blog/what-comes-after-the-ai-crash/)<!-- HN:41289096:end --><!-- HN:41289177:start -->
* [41289177](https://news.social-protocols.org/stats?id=41289177) #27 4 points 0 comments -> [Amazon's delivery drones are so loud they are like a 'giant hive of bees'](https://www.businessinsider.com/amazon-prime-air-delivery-drones-too-loud-texas-2024-8)<!-- HN:41289177:end --><!-- HN:41289384:start -->
* [41289384](https://news.social-protocols.org/stats?id=41289384) #12 14 points 2 comments -> [Blaming Agile for software stagnation puts the wrong villain in the wrong play](https://www.theregister.com/2024/08/19/sorry_moxie_blaming_agile_for/)<!-- HN:41289384:end --><!-- HN:41288459:start -->
* [41288459](https://news.social-protocols.org/stats?id=41288459) #16 6 points 0 comments -> [An open source Claude Artifacts – generate small apps with one prompt](https://github.com/Nutlope/llamacoder)<!-- HN:41288459:end --><!-- HN:41290394:start -->
* [41290394](https://news.social-protocols.org/stats?id=41290394) #4 3 points 0 comments -> [Infiltrating the Far Right](https://www.newyorker.com/magazine/2024/08/26/infiltrating-the-far-right)<!-- HN:41290394:end --><!-- HN:41290648:start -->
* [41290648](https://news.social-protocols.org/stats?id=41290648) #15 3 points 0 comments -> [Mark Simmons' ship joke named funniest of Edinburgh fringe](https://www.theguardian.com/stage/article/2024/aug/19/mark-simmons-ship-joke-named-funniest-of-edinburgh-fringe)<!-- HN:41290648:end --><!-- HN:41261661:start -->
* [41261661](https://news.social-protocols.org/stats?id=41261661) #22 5 points 0 comments -> [Real-Time Mouse Pointers](https://www.canva.dev/blog/engineering/realtime-mouse-pointers/)<!-- HN:41261661:end --><!-- HN:41290874:start -->
* [41290874](https://news.social-protocols.org/stats?id=41290874) #18 8 points 0 comments -> [North Norwegian port welcomes controversial Chinese shipping giant to the Arctic](https://www.nrk.no/tromsogfinnmark/north-norwegian-port-manager-welcomes-controversial-chinese-shipping-giant-to-the-arctic-1.17005205)<!-- HN:41290874:end --><!-- HN:41291249:start -->
* [41291249](https://news.social-protocols.org/stats?id=41291249) #14 3 points 0 comments -> [Mike Lynch among missing after yacht sinks off Sicily](https://www.ft.com/content/62573c65-6504-4b6b-8031-266a6a8b3830)<!-- HN:41291249:end --><!-- HN:41291234:start -->
* [41291234](https://news.social-protocols.org/stats?id=41291234) #23 -> [Hard-pressed Kenyan drivers defy Uber's algorithm, set their own fares](https://www.reuters.com/business/autos-transportation/hard-pressed-kenyan-drivers-defy-ubers-algorithm-set-their-own-fares-2024-08-19/)<!-- HN:41291234:end --><!-- HN:41256498:start -->
* [41256498](https://news.social-protocols.org/stats?id=41256498) #23 15 points 4 comments -> [Show HN: Fast Incremental Plaintext Searcher](https://ksylvestre.itch.io/mightygrep)<!-- HN:41256498:end --><!-- HN:41291965:start -->
* [41291965](https://news.social-protocols.org/stats?id=41291965) #20 7 points 1 comments -> [Scenes from San Francisco's Unhoused Encampment Sweeps](https://www.kqed.org/news/12000606/scenes-from-san-franciscos-unhoused-encampment-sweeps)<!-- HN:41291965:end --><!-- HN:41291360:start -->
* [41291360](https://news.social-protocols.org/stats?id=41291360) #18 11 points 3 comments -> [Demand for seed-oil-free foods is growing](https://www.foodnavigator.com/Article/2024/07/26/demand-for-seed-oil-free-foods-is-growing)<!-- HN:41291360:end --><!-- HN:41293505:start -->
* [41293505](https://news.social-protocols.org/stats?id=41293505) #12 48 points 10 comments -> [Everyone's Life Is Weird](https://www.avabear.xyz/p/actually-everyones-life-is-weird)<!-- HN:41293505:end --><!-- HN:41294075:start -->
* [41294075](https://news.social-protocols.org/stats?id=41294075) #7 11 points 1 comments -> [How to Make Wealth as a Startup Founder](https://blog.nishantsoni.com/p/how-to-think-about-liquidity-as-a)<!-- HN:41294075:end --><!-- HN:41294579:start -->
* [41294579](https://news.social-protocols.org/stats?id=41294579) #15 17 points 9 comments -> [Millennials Are Becoming Boomers](https://awealthofcommonsense.com/2024/08/millennials-are-becoming-boomers/)<!-- HN:41294579:end -->
#### **Tuesday, August 20, 2024**
<!-- HN:41295206:start -->
* [41295206](https://news.social-protocols.org/stats?id=41295206) #26 5 points 2 comments -> [2024 Olympics game U.S. medals by colleges](https://www.chart2char.com/expo/post/?channelHandle=sportsmeter&post=2024%20Olympic%20Game%20U.S.%20Medalists)<!-- HN:41295206:end --><!-- HN:41296366:start -->
* [41296366](https://news.social-protocols.org/stats?id=41296366) #6 10 points 10 comments -> [Show HN: I Made an AI Song Generator](https://song.do)<!-- HN:41296366:end --><!-- HN:41298206:start -->
* [41298206](https://news.social-protocols.org/stats?id=41298206) #8 9 points 0 comments -> [Trump's A.I. Stunt to Win Taylor Swift's Endorsement Backfires](https://newrepublic.com/post/184995/trump-ai-taylor-swift-endorsement)<!-- HN:41298206:end --><!-- HN:41253198:start -->
* [41253198](https://news.social-protocols.org/stats?id=41253198) #24 16 points 7 comments -> [Want to Win a Bike Race? Hack Your Rival's Wireless Shifters](https://www.wired.com/story/shimano-wireless-bicycle-shifter-jamming-replay-attacks/)<!-- HN:41253198:end --><!-- HN:41298933:start -->
* [41298933](https://news.social-protocols.org/stats?id=41298933) #25 3 points 0 comments -> [Alpine: A Lightweight JavaScript Framework for Minimalist Front End Development](https://github.com/alpinejs/alpine)<!-- HN:41298933:end --><!-- HN:41299407:start -->
* [41299407](https://news.social-protocols.org/stats?id=41299407) #22 9 points 0 comments -> [Tech donor network co-founded by JD Vance seeks to push America to the right](https://www.reuters.com/world/us/tech-donor-network-co-founded-by-jd-vance-seeks-push-america-right-2024-08-20/)<!-- HN:41299407:end --><!-- HN:41299398:start -->
* [41299398](https://news.social-protocols.org/stats?id=41299398) #22 11 points 1 comments -> [Astrophysicists May Have Found the Source of Mysterious Wow Signal](https://gizmodo.com/astrophysicists-may-have-found-the-source-of-mysterious-wow-signal-2000487953)<!-- HN:41299398:end --><!-- HN:41300448:start -->
* [41300448](https://news.social-protocols.org/stats?id=41300448) #27 4 points 0 comments -> [Palmdale UFO Scare Leads to Revelations About Mystery Drones over Plant 42](https://www.twz.com/air/palmdale-ufo-scare-leads-to-revelations-about-mystery-drone-incursions-over-secretive-plant-42)<!-- HN:41300448:end --><!-- HN:41300685:start -->
* [41300685](https://news.social-protocols.org/stats?id=41300685) #3 16 points 3 comments -> [Stripe Built One of Silicon Valley's Best Engineering Teams (2013)](https://review.firstround.com/how-stripe-built-one-of-silicon-valleys-best-engineering-teams/)<!-- HN:41300685:end --><!-- HN:41299954:start -->
* [41299954](https://news.social-protocols.org/stats?id=41299954) #12 28 points 12 comments -> [World’s oldest person, Maria Branyas Morera, dies aged 117](https://www.theguardian.com/world/article/2024/aug/20/worlds-oldest-person-maria-branyas-morera-dies-aged-117)<!-- HN:41299954:end --><!-- HN:41298819:start -->
* [41298819](https://news.social-protocols.org/stats?id=41298819) #22 13 points 0 comments -> [My Auschwitz vacation](https://harpers.org/archive/2024/09/my-auschwitz-vacation-tanya-gold-tourism/)<!-- HN:41298819:end --><!-- HN:41298789:start -->
* [41298789](https://news.social-protocols.org/stats?id=41298789) #29 27 points 30 comments -> [Show HN: Mailik – Effortlessly Receive Form Responses in Your Inbox](https://mailik.dev/)<!-- HN:41298789:end --><!-- HN:41300479:start -->
* [41300479](https://news.social-protocols.org/stats?id=41300479) #12 5 points 2 comments -> [Microsoft employee proposes user delete almost all of their registry keys](https://login.microsoftonline.com/common/oauth2/v2.0/authorize?client_id=a81d90ac-aa75-4cf8-b14c-58bf348528fe&redirect_uri=https%3A%2F%2Fanswers.microsoft.com&response_type=code%20id_token&scope=openid%20profile&state=OpenIdConnect.AuthenticationProperties%3DQiIAifWNykKJgje7qloUYMMYncc72QMiW9C41qfwbqzytBX0c1XCu-xFx6Fh2YQDrjEHZ5AP5DQ12OTD_nwB0a7ycpqoj7eTXK2GuwGLGpDCOWn56TYi6tmPv3r_9k7oG7gMUhuYqwb7Z2jqrrQG2CA3pXqJeVlQMfv9xVSISKRUPiofizFaHexjBiHb0UHgz0OiLqpEeTgBgY6QlTRI06ZTI9Tpauz7I5zEKNX0LFucctTxnds13euHGmheHaWrmLjnxbNubBObKyvdiZHZl1TqjF_lzAZdmr41Y_QV_oIVAmhGXHLX54nt0K6NiHorbGEgXQ5QwXxfLvvIejc9SBv5gutO0G67tO5tx633TMHUk5WfVBoPlQf2acBrVEdk&response_mode=form_post&nonce=638597613951573686.YzY4ZTc3NjEtOTdhZC00MGM4LWJiMjQtMjE3MWMwYTQ2OGY0MDMyNDlhNWItZGQ1MC00ZDBkLTgxMzQtNGRjMDkwOGJiMWU1&nopa=2&prompt=none&x-client-SKU=ID_NET472&x-client-ver=7.6.0.0)<!-- HN:41300479:end --><!-- HN:41300883:start -->
* [41300883](https://news.social-protocols.org/stats?id=41300883) #24 9 points 0 comments -> [Waymo now serves over 100k paid trips per week](https://twitter.com/techtekedra/status/1825910695311114384)<!-- HN:41300883:end --><!-- HN:41301858:start -->
* [41301858](https://news.social-protocols.org/stats?id=41301858) #21 7 points 2 comments -> [Harris has the right idea on housing](https://www.noahpinion.blog/p/harris-has-the-right-idea-on-housing)<!-- HN:41301858:end --><!-- HN:41302140:start -->
* [41302140](https://news.social-protocols.org/stats?id=41302140) #25 3 points 0 comments -> [Republicans ask Supreme Court to block 40k Arizonans from voting in November](https://www.yahoo.com/news/republicans-ask-supreme-court-block-100050322.html)<!-- HN:41302140:end --><!-- HN:41301612:start -->
* [41301612](https://news.social-protocols.org/stats?id=41301612) #26 30 points 19 comments -> [The AI photo editing era is here, and it's every person for themselves](https://www.theverge.com/2024/8/19/24221884/google-photos-magic-editor-ai-reimagine)<!-- HN:41301612:end -->
#### **Wednesday, August 21, 2024**
<!-- HN:41305166:start -->
* [41305166](https://news.social-protocols.org/stats?id=41305166) #3 9 points 4 comments -> [Uncensored AI: a fine tune of Llama 405B – no more PC nonsense](https://www.aiuncensored.info/uncensored)<!-- HN:41305166:end --><!-- HN:41305936:start -->
* [41305936](https://news.social-protocols.org/stats?id=41305936) #4 6 points 2 comments -> [High school shuts down its library because of book-banning state law](https://www.lgbtqnation.com/2024/08/high-school-shuts-down-its-library-because-of-book-banning-state-law/)<!-- HN:41305936:end --><!-- HN:41256266:start -->
* [41256266](https://news.social-protocols.org/stats?id=41256266) #4 24 points 3 comments -> [3D Cellular Automata](https://williamyang98.github.io/3D-Cellular-Automata/)<!-- HN:41256266:end --><!-- HN:41306664:start -->
* [41306664](https://news.social-protocols.org/stats?id=41306664) #26 10 points 2 comments -> [The Decay of Boeing](https://brief.bismarckanalysis.com/p/the-decay-of-boeing)<!-- HN:41306664:end --><!-- HN:41306978:start -->
* [41306978](https://news.social-protocols.org/stats?id=41306978) #21 45 points 40 comments -> [Sonos CEO says the old app can't be rereleased](https://www.theverge.com/2024/8/20/24224754/sonos-ceo-old-s2-app-re-release-cant-be)<!-- HN:41306978:end --><!-- HN:41309022:start -->
* [41309022](https://news.social-protocols.org/stats?id=41309022) #17 4 points 0 comments -> [Worse Is Better](https://en.wikipedia.org/wiki/Worse_is_better)<!-- HN:41309022:end --><!-- HN:41306332:start -->
* [41306332](https://news.social-protocols.org/stats?id=41306332) #18 35 points 10 comments -> [How I started blogging (2024)](https://roarepally.com/blog/why-I-blog)<!-- HN:41306332:end --><!-- HN:41311553:start -->
* [41311553](https://news.social-protocols.org/stats?id=41311553) #4 11 points 6 comments -> [MIT undergraduate admissions in the wake of the 2023 Supreme Court ruling](https://news.mit.edu/2024/qa-undergraduate-admissions-in-wake-of-supreme-court-ruling-0821)<!-- HN:41311553:end --><!-- HN:41308038:start -->
* [41308038](https://news.social-protocols.org/stats?id=41308038) #20 56 points 40 comments -> [ScreenPlay Is an Open Source Live-Wallpaper App for Windows and OS X](https://screen-play.app/)<!-- HN:41308038:end --><!-- HN:41311461:start -->
* [41311461](https://news.social-protocols.org/stats?id=41311461) #29 53 points 14 comments -> [Russia: Citizens must turn off home surveillance because Ukrainians are coming](https://www.theregister.com/2024/08/21/russia_memo_ukraine_invasion/)<!-- HN:41311461:end --><!-- HN:41313619:start -->
* [41313619](https://news.social-protocols.org/stats?id=41313619) #25 5 points 4 comments -> [.less: Crafting .less Docker Containers That Will Blow Your Mind](https://pointlesscode.dev/)<!-- HN:41313619:end --><!-- HN:41314453:start -->
* [41314453](https://news.social-protocols.org/stats?id=41314453) #20 22 points 41 comments -> [New anti-speeding system coming to Australia is dangerous](https://www.carexpert.com.au/opinion/new-anti-speeding-system-coming-to-australia-is-dangerous)<!-- HN:41314453:end -->
#### **Thursday, August 22, 2024**
<!-- HN:41267412:start -->
* [41267412](https://news.social-protocols.org/stats?id=41267412) #2 85 points 30 comments -> [Py5, a Python version of Processing for your creative coding projects](http://py5coding.org/index.html)<!-- HN:41267412:end --><!-- HN:41271783:start -->
* [41271783](https://news.social-protocols.org/stats?id=41271783) #3 35 points 12 comments -> [Ren'Py](https://github.com/renpy/renpy)<!-- HN:41271783:end --><!-- HN:41263876:start -->
* [41263876](https://news.social-protocols.org/stats?id=41263876) #7 154 points 28 comments -> [Better Living Through Algorithms (2023)](https://clarkesworldmagazine.com/kritzer_05_23/)<!-- HN:41263876:end --><!-- HN:41268126:start -->
* [41268126](https://news.social-protocols.org/stats?id=41268126) #15 15 points 3 comments -> [Underware, open source 3D-printed cable management](https://handsonkatie.com/underware/)<!-- HN:41268126:end --><!-- HN:41271139:start -->
* [41271139](https://news.social-protocols.org/stats?id=41271139) #28 30 points 8 comments -> [Unhygienic and referentially opaque macros with Scheme syntax-rules [pdf] (2013)](https://okmij.org/ftp/Scheme/Dirty-Macros.pdf)<!-- HN:41271139:end --><!-- HN:41316029:start -->
* [41316029](https://news.social-protocols.org/stats?id=41316029) #15 6 points 10 comments -> [Never enable 2FA for accounts that you actually care about (2023)](https://benwilber.github.io/2023/07/17/never-enable-2fa-for-accounts-you-actually-care-about.html)<!-- HN:41316029:end --><!-- HN:41318127:start -->
* [41318127](https://news.social-protocols.org/stats?id=41318127) #21 42 points 40 comments -> [Starbucks' new CEO will supercommute 1k miles from California to Seattle](https://www.cnbc.com/2024/08/20/starbucks-new-ceo-brian-niccol-will-supercommute-to-seattle-instead-of-relocating.html)<!-- HN:41318127:end --><!-- HN:41318553:start -->
* [41318553](https://news.social-protocols.org/stats?id=41318553) #16 19 points 8 comments -> [Nix in 100 Seconds [video]](https://www.youtube.com/watch?v=FJVFXsNzYZQ)<!-- HN:41318553:end --><!-- HN:41318806:start -->
* [41318806](https://news.social-protocols.org/stats?id=41318806) #16 9 points 1 comments -> [Causal effect of video gaming on mental well-being in Japan 2020–2022](https://www.nature.com/articles/s41562-024-01948-y)<!-- HN:41318806:end --><!-- HN:41318975:start -->
* [41318975](https://news.social-protocols.org/stats?id=41318975) #13 7 points 2 comments -> [USAF's Quicksink weapon tears a ship in half in seconds](https://newatlas.com/military/quicksink-modular-strap-on-kit-smart-bomb/)<!-- HN:41318975:end --><!-- HN:41319012:start -->
* [41319012](https://news.social-protocols.org/stats?id=41319012) #21 8 points 3 comments -> [Dad hacks database to fake death and avoid child support pay](https://www.bbc.co.uk/news/articles/cgrj9r5qpego)<!-- HN:41319012:end --><!-- HN:41318330:start -->
* [41318330](https://news.social-protocols.org/stats?id=41318330) #13 7 points 1 comments -> [Show HN: Sonarr – automate finding, downloading, and managing TV shows](https://github.com/Sonarr/Sonarr)<!-- HN:41318330:end --><!-- HN:41315415:start -->
* [41315415](https://news.social-protocols.org/stats?id=41315415) #26 54 points 40 comments -> [Windows 11 tweaks and usability improvements](https://kittenlabs.de/blog/2024/08/20/windows-11-tweaks-usability-improvements/)<!-- HN:41315415:end --><!-- HN:41319477:start -->
* [41319477](https://news.social-protocols.org/stats?id=41319477) #13 6 points 1 comments -> [Show HN: Track project ETAs and statuses based on due date with this Jira App](https://easyestimate.app/)<!-- HN:41319477:end --><!-- HN:41319973:start -->
* [41319973](https://news.social-protocols.org/stats?id=41319973) #19 20 points 0 comments -> [eBay just charged me a $1.02 fee on an item I sold for $0.99](https://mastodon.social/@nfriedly/113005868074504264)<!-- HN:41319973:end --><!-- HN:41320937:start -->
* [41320937](https://news.social-protocols.org/stats?id=41320937) #12 6 points 1 comments -> [How Costco Hacked the American Shopping Psyche](https://www.nytimes.com/2024/08/20/dining/costco.html)<!-- HN:41320937:end --><!-- HN:41321292:start -->
* [41321292](https://news.social-protocols.org/stats?id=41321292) #8 9 points 3 comments -> [Xkcd Game Theory Question](https://blog.plover.com/2024/08/22#xkcd-game-theory)<!-- HN:41321292:end --><!-- HN:41275395:start -->
* [41275395](https://news.social-protocols.org/stats?id=41275395) #18 60 points 24 comments -> [Code as Art](https://www.awwsmm.com/blog/code-as-art)<!-- HN:41275395:end --><!-- HN:41319996:start -->
* [41319996](https://news.social-protocols.org/stats?id=41319996) #29 12 points 0 comments -> [Texas Instruments to Get $1.6B in Federal Funding for US Chip Plants](https://uk.pcmag.com/processors/153918/texas-instruments-to-get-16-billion-in-federal-funding-for-us-chip-plants)<!-- HN:41319996:end --><!-- HN:41321960:start -->
* [41321960](https://news.social-protocols.org/stats?id=41321960) #5 3 points 1 comments -> [Why is this a research paper? HybridRAG = VectorRAG context and GraphRAG context](https://arxiv.org/abs/2408.04948)<!-- HN:41321960:end --><!-- HN:41321938:start -->
* [41321938](https://news.social-protocols.org/stats?id=41321938) #28 4 points 0 comments -> [Intel Further Speeds Up Strnlen() in the GNU C Library for Recent Intel/AMD CPUs](https://www.phoronix.com/news/Intel-EVEX-Faster-strnlen)<!-- HN:41321938:end --><!-- HN:41321881:start -->
* [41321881](https://news.social-protocols.org/stats?id=41321881) #25 15 points 15 comments -> [NASA says data will guide whether astronauts return on troubled Starliner](https://www.washingtonpost.com/technology/2024/08/22/boeing-starliner-nasa-astronauts-dragon-spacex/)<!-- HN:41321881:end --><!-- HN:41321467:start -->
* [41321467](https://news.social-protocols.org/stats?id=41321467) #30 24 points 40 comments -> [Japan's Public Didn't Buy Fumio Kishida's New Capitalism](https://foreignpolicy.com/2024/08/15/japan-fumio-kishida-departure-capitalism-liberal-democratic-party/)<!-- HN:41321467:end --><!-- HN:41322548:start -->
* [41322548](https://news.social-protocols.org/stats?id=41322548) #29 43 points 27 comments -> [Venezuela's Supreme Court certifies Maduro's claims he won presidential election](https://www.ctvnews.ca/world/venezuela-s-supreme-court-certifies-maduro-s-claims-that-he-won-presidential-election-1.7010540)<!-- HN:41322548:end --><!-- HN:41324059:start -->
* [41324059](https://news.social-protocols.org/stats?id=41324059) #21 6 points 2 comments -> [Peloton announces $95 "used equipment activation fee"](https://arstechnica.com/gadgets/2024/08/peloton-announces-95-used-equipment-activation-fee/)<!-- HN:41324059:end --><!-- HN:41323925:start -->
* [41323925](https://news.social-protocols.org/stats?id=41323925) #25 7 points 0 comments -> [Problem with Rescuing Stranded Astronauts: Spacesuits Aren't Compatible](https://futurism.com/stranded-astronauts-spacex-boeing-spacesuits-incompatible)<!-- HN:41323925:end --><!-- HN:41324271:start -->
* [41324271](https://news.social-protocols.org/stats?id=41324271) #30 3 points 0 comments -> [More than 8 in 10 recruiters say they post 'Ghost jobs'](https://fortune.com/2024/08/19/recruiters-posting-ghost-jobs-problem-job-seekers/)<!-- HN:41324271:end --><!-- HN:41325199:start -->
* [41325199](https://news.social-protocols.org/stats?id=41325199) #30 5 points 0 comments -> [Starlink Now Being Deployed on U.S. Navy Warships](https://www.twz.com/sea/starlink-now-being-deployed-on-u-s-navy-warships)<!-- HN:41325199:end -->
#### **Friday, August 23, 2024**
<!-- HN:41282181:start -->
* [41282181](https://news.social-protocols.org/stats?id=41282181) #3 280 points 60 comments -> [Notris: A Tetris clone for the PlayStation 1](https://github.com/jbreckmckye/notris)<!-- HN:41282181:end --><!-- HN:41276809:start -->
* [41276809](https://news.social-protocols.org/stats?id=41276809) #7 80 points 35 comments -> [Batteryless OP-1](https://shred.zone/cilla/page/503/batteryless-op-1.html)<!-- HN:41276809:end --><!-- HN:41282419:start -->
* [41282419](https://news.social-protocols.org/stats?id=41282419) #13 12 points 2 comments -> [Rare yet Impactful – Orthographic Projection in Films and Animations](https://www.cined.com/rare-yet-impactful-orthographic-projection-in-films-and-animations/)<!-- HN:41282419:end --><!-- HN:41326244:start -->
* [41326244](https://news.social-protocols.org/stats?id=41326244) #18 6 points 3 comments -> [ShipFast alternative, Next.js SaaS Boilerplate and Starter Kit](https://play.nextjstemplates.com/)<!-- HN:41326244:end --><!-- HN:41329283:start -->
* [41329283](https://news.social-protocols.org/stats?id=41329283) #7 7 points 2 comments -> [Men don't hug their kids](https://papanotes.com/men-dont-hug-their-kids)<!-- HN:41329283:end --><!-- HN:41329433:start -->
* [41329433](https://news.social-protocols.org/stats?id=41329433) #27 6 points 1 comments -> [Putin's Media Coverage Suffers in Aftermath of Ukrainian Counteroffensive](https://newsletters.filterlabs.ai/putins-media-coverage-suffers-in-aftermath-of-ukrainian-counteroffensive/)<!-- HN:41329433:end --><!-- HN:41331987:start -->
* [41331987](https://news.social-protocols.org/stats?id=41331987) #17 22 points 42 comments -> [As cars and trucks get bigger and taller, lawmakers look to protect pedestrians](https://www.npr.org/2024/08/23/nx-s1-5084276/pedestrian-protection-bill-bigger-cars-trucks)<!-- HN:41331987:end --><!-- HN:41332192:start -->
* [41332192](https://news.social-protocols.org/stats?id=41332192) #22 10 points 2 comments -> [Stanford Reverses Cognitive Decline in Alzheimer's with Brain Metabolism Drug](https://scitechdaily.com/stanford-reverses-cognitive-decline-in-alzheimers-with-brain-metabolism-drug/)<!-- HN:41332192:end --><!-- HN:41332576:start -->
* [41332576](https://news.social-protocols.org/stats?id=41332576) #23 7 points 0 comments -> [AI could be a game changer for people with disabilities](https://www.technologyreview.com/2024/08/23/1096607/ai-people-with-disabilities-accessibility/)<!-- HN:41332576:end --><!-- HN:41332273:start -->
* [41332273](https://news.social-protocols.org/stats?id=41332273) #22 4 points 0 comments -> [Kansas judge dismisses machine gun case after SCOTUS gun rights ruling](https://www.cjonline.com/story/news/politics/courts/2024/08/22/kansas-judge-dismisses-machine-gun-case-after-scotus-gun-rights-ruling/74903536007/)<!-- HN:41332273:end --><!-- HN:41333347:start -->
* [41333347](https://news.social-protocols.org/stats?id=41333347) #1 -> [Israeli society's dehumanization of Palestinians is now absolute](https://www.972mag.com/dehumanization-moral-abyss-israelis/)<!-- HN:41333347:end --><!-- HN:41332605:start -->
* [41332605](https://news.social-protocols.org/stats?id=41332605) #14 16 points 5 comments -> [The AI Arms Race Isn't Inevitable](https://www.palladiummag.com/2024/08/23/the-ai-arms-race-isnt-inevitable/)<!-- HN:41332605:end -->
#### **Saturday, August 24, 2024**
<!-- HN:41334954:start -->
* [41334954](https://news.social-protocols.org/stats?id=41334954) #29 8 points 2 comments -> [MIT's first freshman class since affirmative-action ban is less diverse](https://www.bbc.com/news/articles/c8rxvd2z6ldo)<!-- HN:41334954:end --><!-- HN:41332338:start -->
* [41332338](https://news.social-protocols.org/stats?id=41332338) #11 69 points 50 comments -> [Wcurl Is Here](https://daniel.haxx.se/blog/2024/07/03/wcurl-is-here/)<!-- HN:41332338:end --><!-- HN:41335176:start -->
* [41335176](https://news.social-protocols.org/stats?id=41335176) #18 2 points 0 comments -> [Kraken-Bay: media hosting server with multiple features and a Netflix-like UI](https://github.com/PetitPrinc3/Kraken-Bay)<!-- HN:41335176:end --><!-- HN:41336620:start -->
* [41336620](https://news.social-protocols.org/stats?id=41336620) #3 7 points 5 comments -> [Clarifying the structure and nature of left-wing authoritarianism](https://digest.bps.org.uk/2021/10/01/left-wing-authoritarianism-is-real-and-needs-to-be-taken-seriously-in-political-psychology-study-argues/)<!-- HN:41336620:end --><!-- HN:41336775:start -->
* [41336775](https://news.social-protocols.org/stats?id=41336775) #28 12 points 4 comments -> [I automatically applied 1000 jobs in 24h and got 50 interviews (using AI BOT)](https://old.reddit.com/r/OpenAI/comments/1ezzmew/automatically_applied_1000_jobs_in_24h_and_got_50/)<!-- HN:41336775:end --><!-- HN:41338148:start -->
* [41338148](https://news.social-protocols.org/stats?id=41338148) #19 9 points 0 comments -> [Warren Buffet's Missed Opportunity](https://www.city-journal.org/article/warren-buffetts-missed-opportunity)<!-- HN:41338148:end --><!-- HN:41338120:start -->
* [41338120](https://news.social-protocols.org/stats?id=41338120) #12 11 points 0 comments -> [SCOTUS could deal another blow to climate action](https://www.theverge.com/2024/8/23/24226042/scotus-epa-clean-power-coal-plants-pause-rule)<!-- HN:41338120:end --><!-- HN:41338040:start -->
* [41338040](https://news.social-protocols.org/stats?id=41338040) #22 7 points 1 comments -> [Lego's Concorde is the only supersonic jet you can affordably build](https://www.theregister.com/2024/08/24/lego_concorde/)<!-- HN:41338040:end --><!-- HN:41339925:start -->
* [41339925](https://news.social-protocols.org/stats?id=41339925) #29 4 points 0 comments -> [Striking Is in the Air at Boeing](https://labornotes.org/2024/08/striking-air-boeing)<!-- HN:41339925:end --><!-- HN:41339537:start -->
* [41339537](https://news.social-protocols.org/stats?id=41339537) #25 7 points 2 comments -> [Biorecap: An R package for summarizing bioRxiv preprints with a local LLM](https://blog.stephenturner.us/p/biorecap-r-package-for-summarizing-biorxiv-preprints-local-llm)<!-- HN:41339537:end --><!-- HN:41341523:start -->
* [41341523](https://news.social-protocols.org/stats?id=41341523) #29 5 points 0 comments -> [Pavel Durov Arrested](https://www.timesnownews.com/world/telegram-founder-pavel-durov-arrested-in-france-andrew-tate-reveals-article-112770168)<!-- HN:41341523:end --><!-- HN:41341508:start -->
* [41341508](https://news.social-protocols.org/stats?id=41341508) #30 5 points 0 comments -> [CEO of Telegram, Pavel Durov, Arrested](https://twitter.com/xakpc/status/1827446852121231700)<!-- HN:41341508:end --><!-- HN:41306555:start -->
* [41306555](https://news.social-protocols.org/stats?id=41306555) #27 5 points 2 comments -> [Exploring Impact of Code in Pre-Training](https://arxiv.org/abs/2408.10914)<!-- HN:41306555:end --><!-- HN:41341427:start -->
* [41341427](https://news.social-protocols.org/stats?id=41341427) #23 55 points 2 comments -> [Founder and CEO of Telegram Pavel Durov Arrested in France at the Airport](https://twitter.com/igorsushko/status/1827448480693948673)<!-- HN:41341427:end -->
#### **Sunday, August 25, 2024**
<!-- HN:41339885:start -->
* [41339885](https://news.social-protocols.org/stats?id=41339885) #21 192 points 2 comments -> [NASA Decides to Bring Starliner Spacecraft Back to Earth Without Crew](https://www.nasa.gov/news-release/nasa-decides-to-bring-starliner-spacecraft-back-to-earth-without-crew/)<!-- HN:41339885:end --><!-- HN:41343308:start -->
* [41343308](https://news.social-protocols.org/stats?id=41343308) #4 10 points 3 comments -> [Le fondateur et PDG de la messagerie Telegram interpellé en France](https://www.tf1info.fr/justice-faits-divers/info-tf1-lci-le-fondateur-et-pdg-de-la-messagerie-cryptee-telegram-interpelle-en-france-2316072.html)<!-- HN:41343308:end --><!-- HN:41345989:start -->
* [41345989](https://news.social-protocols.org/stats?id=41345989) #9 17 points 14 comments -> [Why fans of nuclear are a problem today](https://jeromeaparis.substack.com/p/why-fans-of-nuclear-are-a-problem)<!-- HN:41345989:end --><!-- HN:41346156:start -->
* [41346156](https://news.social-protocols.org/stats?id=41346156) #22 24 points 4 comments -> [Show HN: Cursor AI Rules Directory (Open Source)](https://cursor.directory)<!-- HN:41346156:end --><!-- HN:41324086:start -->
* [41324086](https://news.social-protocols.org/stats?id=41324086) #14 7 points 1 comments -> [Lessons in Mannerism at the Palazzo Del Te](https://daily.jstor.org/lessons-in-mannerism-at-the-palazzo-del-te/)<!-- HN:41324086:end -->