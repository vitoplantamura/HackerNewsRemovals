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

#### **Sunday, September 21, 2025**
<!-- HN:45318657:start -->
* [45318657](https://news.social-protocols.org/stats?id=45318657) #21 12 points 2 comments -> [Justice Dept. Closed Investigation into Tom Homan for Accepting Bag of Cash](https://www.nytimes.com/2025/09/20/us/politics/tom-homan-fbi-trump.html)<!-- HN:45318657:end --><!-- HN:45319451:start -->
* [45319451](https://news.social-protocols.org/stats?id=45319451) #12 3 points 0 comments -> [Nano Banana AI Image Generator](https://www.ai-nanobanana.net)<!-- HN:45319451:end --><!-- HN:45320140:start -->
* [45320140](https://news.social-protocols.org/stats?id=45320140) #15 4 points 1 comments -> [Democracy Has Never Experienced Aging](https://arxiv.org/login)<!-- HN:45320140:end --><!-- HN:45323429:start -->
* [45323429](https://news.social-protocols.org/stats?id=45323429) #12 -> [4Chan, MAGAs unite in 'clog the toilet' op to block H-1B workers flying back](https://www.indiatoday.in/india/story/h1b-visa-flight-fares-surge-india-us-4chan-blocks-bookings-trump-order-2790740-2025-09-21)<!-- HN:45323429:end --><!-- HN:45323623:start -->
* [45323623](https://news.social-protocols.org/stats?id=45323623) #1 41 points 17 comments -> [How far can you go by train in 5 hours? (interactive map)](https://old.chronotrains.com)<!-- HN:45323623:end --><!-- HN:45323619:start -->
* [45323619](https://news.social-protocols.org/stats?id=45323619) #1 22 points 2 comments -> [A C library offering generic, contiguous dynamic arrays with O(1) amortized push](https://github.com/L-A-Marchetti/Vec)<!-- HN:45323619:end --><!-- HN:45322328:start -->
* [45322328](https://news.social-protocols.org/stats?id=45322328) #18 17 points 1 comments -> [Sequoia: Rust OpenPGP Implementation](https://gitlab.com/sequoia-pgp/sequoia)<!-- HN:45322328:end --><!-- HN:45324408:start -->
* [45324408](https://news.social-protocols.org/stats?id=45324408) #23 15 points 1 comments -> [UK recognises Palestine as an independent state](https://www.theguardian.com/uk-news/2025/sep/21/uk-recognises-palestine-as-an-independent-state)<!-- HN:45324408:end --><!-- HN:45325728:start -->
* [45325728](https://news.social-protocols.org/stats?id=45325728) #30 6 points 0 comments -> [In Historic Shift, U.K., Australia and Canada Recognize a Palestinian State](https://www.wsj.com/world/middle-east/in-historic-shift-u-k-australia-and-canada-recognize-a-palestinian-state-83598a66)<!-- HN:45325728:end --><!-- HN:45326230:start -->
* [45326230](https://news.social-protocols.org/stats?id=45326230) #1 105 points 109 comments -> [Rail travel is booming in America](https://www.economist.com/united-states/2025/09/21/rail-travel-is-booming-in-america)<!-- HN:45326230:end --><!-- HN:45327217:start -->
* [45327217](https://news.social-protocols.org/stats?id=45327217) #15 5 points 0 comments -> [The future is compostable. Period](https://news.ubc.ca/2025/09/the-future-is-compostable-period/)<!-- HN:45327217:end -->
#### **Monday, September 22, 2025**
<!-- HN:45292066:start -->
* [45292066](https://news.social-protocols.org/stats?id=45292066) #11 30 points 15 comments -> [First Ultrasonic Chef's Knife Vibrates 40,000X/Second for Easy Cutting](https://www.cnet.com/home/kitchen-and-household/worlds-first-ultrasonic-chefs-knife-vibrates-40000-times-per-second-for-easy-cutting/)<!-- HN:45292066:end --><!-- HN:45328797:start -->
* [45328797](https://news.social-protocols.org/stats?id=45328797) #29 9 points 4 comments -> [Oracle- $5Billion to England AI, 1.3 Billion to Make Oxford a new Silicon Valley](https://cloudindustryreview.com/oracle-unveils-5-billion-investment-in-uk-cloud-infrastructure/)<!-- HN:45328797:end --><!-- HN:45328404:start -->
* [45328404](https://news.social-protocols.org/stats?id=45328404) #20 8 points 3 comments -> [fs-code: PyFilesystems for Gitlab, GitHub, and Git](https://danjou.gitlab.io/fs-code/dev/codefs.html)<!-- HN:45328404:end --><!-- HN:45328293:start -->
* [45328293](https://news.social-protocols.org/stats?id=45328293) #27 12 points 1 comments -> [Show HN: Wan-Animate – Unified Character Animation and Replacement](https://www.wananimate.net/)<!-- HN:45328293:end --><!-- HN:45331841:start -->
* [45331841](https://news.social-protocols.org/stats?id=45331841) #4 12 points 1 comments -> [Watches Are for the Poor](https://prajyoth.pages.dev/article?id=2025-09-20-watches-are-for-the-poor)<!-- HN:45331841:end --><!-- HN:45334362:start -->
* [45334362](https://news.social-protocols.org/stats?id=45334362) #28 9 points 2 comments -> [Ice detainees hold hunger strike at Louisiana state penitentiary](https://www.theguardian.com/us-news/2025/sep/21/ice-detainee-hunger-strike-louisiana)<!-- HN:45334362:end --><!-- HN:45338345:start -->
* [45338345](https://news.social-protocols.org/stats?id=45338345) #13 3 points 2 comments -> [Convert Google Maps Saved Places to Apple Maps](https://www.gotoapplemaps.com)<!-- HN:45338345:end --><!-- HN:45335695:start -->
* [45335695](https://news.social-protocols.org/stats?id=45335695) #3 65 points 2 comments -> [A board member's perspective of the RubyGems controversy](https://apiguy.substack.com/p/a-board-members-perspective-of-the)<!-- HN:45335695:end --><!-- HN:45338990:start -->
* [45338990](https://news.social-protocols.org/stats?id=45338990) #26 67 points 11 comments -> [Umberto Eco: Ur-Fascism](https://bobmschwartz.com/2017/12/28/umberto-eco-ur-fascism/)<!-- HN:45338990:end --><!-- HN:45339422:start -->
* [45339422](https://news.social-protocols.org/stats?id=45339422) #17 3 points 4 comments -> [GitHub replaces dashbord feed with AI shit?](https://github.com/login)<!-- HN:45339422:end --><!-- HN:45340295:start -->
* [45340295](https://news.social-protocols.org/stats?id=45340295) #6 8 points 4 comments -> [Linux: Make the Kernel Cute](https://github.com/torvalds/linux/pull/1290)<!-- HN:45340295:end --><!-- HN:45340251:start -->
* [45340251](https://news.social-protocols.org/stats?id=45340251) #2 9 points 2 comments -> [Show HN: Perfect your presentation with a panel of AI reviewers](https://review.thorntale.com/)<!-- HN:45340251:end -->
#### **Tuesday, September 23, 2025**
<!-- HN:45342230:start -->
* [45342230](https://news.social-protocols.org/stats?id=45342230) #4 11 points 2 comments -> [Eschatological thinking: why Peter Thiel is talking about the Antichrist](https://www.realtimetechpocalypse.com/p/the-political-power-of-eschatological-82b)<!-- HN:45342230:end --><!-- HN:45343863:start -->
* [45343863](https://news.social-protocols.org/stats?id=45343863) #10 4 points 1 comments -> [Show HN: Mushroom Identifier – Fast and Accurate Mushroom Identification with AI](https://mushroomidentification.online)<!-- HN:45343863:end --><!-- HN:45344080:start -->
* [45344080](https://news.social-protocols.org/stats?id=45344080) #19 8 points 1 comments -> [Netanyahu may struggle to find response that matches rhetoric on Palestine](https://www.theguardian.com/world/2025/sep/22/allies-recognition-of-palestine-angers-netanyahu-but-his-options-for-response-are-limited)<!-- HN:45344080:end --><!-- HN:45344662:start -->
* [45344662](https://news.social-protocols.org/stats?id=45344662) #9 -> [One step closer to bombing civilians](https://www.treason.io/p/read-one-step-closer-to-bombing-civilians)<!-- HN:45344662:end --><!-- HN:45346910:start -->
* [45346910](https://news.social-protocols.org/stats?id=45346910) #7 5 points 3 comments -> [If you make your app 10% easier to use you'll get twice as many users](https://twitter.com/paulg/status/1970422069151355163)<!-- HN:45346910:end --><!-- HN:45346770:start -->
* [45346770](https://news.social-protocols.org/stats?id=45346770) #25 5 points 0 comments -> [Sex tests for athletes are too little, too late](https://unherd.com/newsroom/sex-tests-for-athletes-are-too-little-too-late/)<!-- HN:45346770:end --><!-- HN:45347148:start -->
* [45347148](https://news.social-protocols.org/stats?id=45347148) #27 30 points 7 comments -> [Secret Service takes down network that could have crippled New York cell service](https://www.theguardian.com/us-news/2025/sep/23/secret-service-new-york-network)<!-- HN:45347148:end --><!-- HN:45348146:start -->
* [45348146](https://news.social-protocols.org/stats?id=45348146) #15 19 points 4 comments -> [He's ranked 2nd in the nation for youth rock climbing; AI just canceled him](https://insideinvestigator.org/hes-ranked-2nd-in-the-nation-for-youth-rock-climbing-ai-just-canceled-him/)<!-- HN:45348146:end --><!-- HN:45348330:start -->
* [45348330](https://news.social-protocols.org/stats?id=45348330) #28 8 points 7 comments -> [Grindr outage reports coincide with Kirk memorial service in Arizona](https://www.pride.com/culture/charlie-kirk-grindr-outage)<!-- HN:45348330:end --><!-- HN:45349231:start -->
* [45349231](https://news.social-protocols.org/stats?id=45349231) #10 35 points 2 comments -> [U.S. Secret Service disrupts telecom network that threatened NYC during U.N](https://www.cbsnews.com/news/u-s-secret-service-disrupts-telecom-network-threatened-new-york-city-u-n-general-assembly/)<!-- HN:45349231:end --><!-- HN:45353821:start -->
* [45353821](https://news.social-protocols.org/stats?id=45353821) #11 4 points 2 comments -> [Fake ycombinatoor / y-comblnator using GitHub issues for contact](https://github.com/ycombinatoor/ycombinator-co/issues)<!-- HN:45353821:end -->
#### **Wednesday, September 24, 2025**
<!-- HN:45357222:start -->
* [45357222](https://news.social-protocols.org/stats?id=45357222) #16 48 points 33 comments -> [Ruby Central Is Not Behaving in Good Faith, and I've Got Receipts](https://jaredwhite.com/articles/ruby-central-is-not-operating-in-good-faith)<!-- HN:45357222:end --><!-- HN:45359047:start -->
* [45359047](https://news.social-protocols.org/stats?id=45359047) #26 7 points 4 comments -> [Cloudflare Bankrolls Fascists](https://drewdevault.com/2025/09/24/2025-09-24-Cloudflare-and-fascists.html)<!-- HN:45359047:end --><!-- HN:45361921:start -->
* [45361921](https://news.social-protocols.org/stats?id=45361921) #11 20 points 28 comments -> [The Poison Pill to End the MMR Is Tylenol](https://rasmussenretorts.substack.com/p/the-poison-pill-to-end-the-mmr-is)<!-- HN:45361921:end --><!-- HN:45361574:start -->
* [45361574](https://news.social-protocols.org/stats?id=45361574) #15 27 points 13 comments -> [Replace PostgreSQL with Git for your next project](https://devcenter.upsun.com/posts/why-you-should-replace-postgresql-with-git-for-your-next-project/)<!-- HN:45361574:end --><!-- HN:45365001:start -->
* [45365001](https://news.social-protocols.org/stats?id=45365001) #9 14 points 5 comments -> [How Secure is Tor? Not secure at all](https://csam-bib.github.io/security/)<!-- HN:45365001:end --><!-- HN:45364514:start -->
* [45364514](https://news.social-protocols.org/stats?id=45364514) #8 21 points 41 comments -> [Unlocking a Million Times More Data for AI](https://ifp.org/unlocking-a-million-times-more-data-for-ai/)<!-- HN:45364514:end -->
#### **Thursday, September 25, 2025**
<!-- HN:45367485:start -->
* [45367485](https://news.social-protocols.org/stats?id=45367485) #9 -> [Fuck Hackcyom](https://studium.dev/osib/fuck-hackcyom)<!-- HN:45367485:end --><!-- HN:45367514:start -->
* [45367514](https://news.social-protocols.org/stats?id=45367514) #4 21 points 20 comments -> [Fewer H-1B Visas Did Not Mean More Employment for Natives (2017)](https://www.nber.org/digest/dec17/fewer-h-1b-visas-did-not-mean-more-employment-natives)<!-- HN:45367514:end --><!-- HN:45367364:start -->
* [45367364](https://news.social-protocols.org/stats?id=45367364) #16 46 points 13 comments -> [Harvard's Public Health Dean Was Paid $150k to Testify Tylenol Causes Autism](https://www.thecrimson.com/article/2025/9/24/autism-dean-public-health/)<!-- HN:45367364:end --><!-- HN:45370306:start -->
* [45370306](https://news.social-protocols.org/stats?id=45370306) #13 38 points 15 comments -> [Perhaps my last post – we'll see (2016)](http://itila.blogspot.com/2016/04/perhaps-my-last-post-well-see.html)<!-- HN:45370306:end --><!-- HN:45372888:start -->
* [45372888](https://news.social-protocols.org/stats?id=45372888) #8 29 points 38 comments -> [Shiller PE Ratio](https://www.multpl.com/shiller-pe)<!-- HN:45372888:end --><!-- HN:45373606:start -->
* [45373606](https://news.social-protocols.org/stats?id=45373606) #21 8 points 3 comments -> [It's Time to License Software Engineering](https://www.slater.dev/its-time-to-license-software-engineering/)<!-- HN:45373606:end --><!-- HN:45372935:start -->
* [45372935](https://news.social-protocols.org/stats?id=45372935) #17 7 points 10 comments -> [Ubuntu: The Indigenous Ethos of Restorative Justice](https://www.traum-und-verantwortung.de/zitate/ubuntu/)<!-- HN:45372935:end --><!-- HN:45375889:start -->
* [45375889](https://news.social-protocols.org/stats?id=45375889) #27 -> [Gov. Gavin Newsom says he fears there won't be a 2028 election](https://ktla.com/news/california/gov-gavin-newsom-fears-there-wont-be-a-2028-election/)<!-- HN:45375889:end --><!-- HN:45376063:start -->
* [45376063](https://news.social-protocols.org/stats?id=45376063) #24 32 points 5 comments -> [Microsoft blocks Israel's use of its data centers](https://www.engadget.com/big-tech/microsoft-blocks-israels-use-of-its-data-centers-for-mass-surveillance-of-palestinians-170107061.html)<!-- HN:45376063:end --><!-- HN:45377439:start -->
* [45377439](https://news.social-protocols.org/stats?id=45377439) #13 -> [Doge Continues to Operate Unchecked, Violating Federal Privacy and Security Laws](https://www.hsgac.senate.gov/media/dems/peters-report-finds-that-doge-continues-to-operate-unchecked-likely-violating-federal-privacy-and-security-laws-and-putting-the-safety-of-americans-personal-information-in-danger/)<!-- HN:45377439:end -->
#### **Friday, September 26, 2025**
<!-- HN:45380858:start -->
* [45380858](https://news.social-protocols.org/stats?id=45380858) #8 33 points 21 comments -> [Conspiracy content drives anti-establishment sentiment on TikTok, YouTube](https://news.umich.edu/conspiracy-content-drives-anti-establishment-sentiment-on-tiktok-youtube/)<!-- HN:45380858:end --><!-- HN:45380778:start -->
* [45380778](https://news.social-protocols.org/stats?id=45380778) #18 4 points 0 comments -> [Arctic sea ice has reached minimum extent for 2025](https://cires.colorado.edu/news/arctic-sea-ice-has-reached-minimum-extent-2025)<!-- HN:45380778:end --><!-- HN:45382668:start -->
* [45382668](https://news.social-protocols.org/stats?id=45382668) #21 39 points 21 comments -> [The effect of H-1B quota on employment and selection of foreign-born labor (2018)](https://doi.org/10.1016/j.euroecorev.2018.06.010)<!-- HN:45382668:end --><!-- HN:45384890:start -->
* [45384890](https://news.social-protocols.org/stats?id=45384890) #7 12 points 0 comments -> [Apple's Claimed Private Data Flows Pass Through Amazon Infrastructure](https://gist.github.com/JGoyd/e5fe395c4b51f9e03734ad08e6e790db)<!-- HN:45384890:end --><!-- HN:45384804:start -->
* [45384804](https://news.social-protocols.org/stats?id=45384804) #16 4 points 0 comments -> [Apple's disregard for security and privacy is mind-boggling (2020)](https://evermeet.cx/wiki/Apple%27s_disregard_for_security_and_privacy_is_mind-boggling)<!-- HN:45384804:end --><!-- HN:45385252:start -->
* [45385252](https://news.social-protocols.org/stats?id=45385252) #28 28 points 41 comments -> [Facebook and Instagram to offer ad-free service in UK for up to £3.99 a month](https://www.theguardian.com/technology/2025/sep/26/facebook-and-instagram-to-offer-paid-ad-free-service-uk)<!-- HN:45385252:end --><!-- HN:45387356:start -->
* [45387356](https://news.social-protocols.org/stats?id=45387356) #26 12 points 3 comments -> [Hundreds of Diplomats stage walkout from UN as Netanyahu enters to speak](https://www.timesofisrael.com/liveblog_entry/hundreds-of-diplomats-stage-walkout-from-un-general-assembly-as-netanyahu-enters-to-speak/)<!-- HN:45387356:end --><!-- HN:45390061:start -->
* [45390061](https://news.social-protocols.org/stats?id=45390061) #10 -> [Valve Prism](https://valveprism.com/)<!-- HN:45390061:end --><!-- HN:45358959:start -->
* [45358959](https://news.social-protocols.org/stats?id=45358959) #22 5 points 0 comments -> [How to manage Python projects with Poetry](https://www.infoworld.com/article/2256032/how-to-manage-python-projects-with-poetry.html)<!-- HN:45358959:end -->
#### **Saturday, September 27, 2025**
<!-- HN:45392811:start -->
* [45392811](https://news.social-protocols.org/stats?id=45392811) #27 8 points 0 comments -> [Times New Dumbass](https://timesnewdumbass.co/)<!-- HN:45392811:end --><!-- HN:45393087:start -->
* [45393087](https://news.social-protocols.org/stats?id=45393087) #7 8 points 1 comments -> [Casimir Effect Energy](https://www.casimirspace.com)<!-- HN:45393087:end --><!-- HN:45393306:start -->
* [45393306](https://news.social-protocols.org/stats?id=45393306) #24 13 points 1 comments -> [YC Stole a SF-Attacked Founder's Startup](https://twitter.com/_opencv_/status/1971774399729881319)<!-- HN:45393306:end -->