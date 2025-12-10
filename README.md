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

#### **Thursday, December 4, 2025**
<!-- HN:46142296:start -->
* [46142296](https://news.social-protocols.org/stats?id=46142296) #20 7 points 1 comments -> [PR adding custom progress bar themes to GNOME Bazaar rejected, citing "racism"](https://github.com/kolunmi/bazaar/pull/724)<!-- HN:46142296:end --><!-- HN:46143230:start -->
* [46143230](https://news.social-protocols.org/stats?id=46143230) #12 13 points 1 comments -> [Cellebrite to Acquire Corellium](https://www.corellium.com/blog/cellebrite-to-acquire-corellium)<!-- HN:46143230:end --><!-- HN:46144752:start -->
* [46144752](https://news.social-protocols.org/stats?id=46144752) #12 8 points 1 comments -> [How AI is transforming work at Anthropic](https://www.anthropic.com/research/how-ai-is-transforming-work-at-anthropic)<!-- HN:46144752:end --><!-- HN:46146103:start -->
* [46146103](https://news.social-protocols.org/stats?id=46146103) #21 19 points 41 comments -> [Porn company fined £1M over inadequate age checks (UK)](https://www.bbc.co.uk/news/articles/c93nll07z3go)<!-- HN:46146103:end --><!-- HN:46095819:start -->
* [46095819](https://news.social-protocols.org/stats?id=46095819) #22 14 points 1 comments -> [FLUX.2](https://bfl.ai/models/flux-2)<!-- HN:46095819:end --><!-- HN:46149740:start -->
* [46149740](https://news.social-protocols.org/stats?id=46149740) #18 29 points 2 comments -> [The End of the Train-Test Split](https://folio.benguzovsky.com/train-test)<!-- HN:46149740:end --><!-- HN:46153332:start -->
* [46153332](https://news.social-protocols.org/stats?id=46153332) #18 65 points 24 comments -> [Countdown until the AI bubble bursts](https://pop-the-bubble.xyz/)<!-- HN:46153332:end --><!-- HN:46151335:start -->
* [46151335](https://news.social-protocols.org/stats?id=46151335) #14 54 points 44 comments -> [Hammersmith Bridge – Where did 25,000 vehicles go?](https://nickmaini.substack.com/p/hammersmith-bridge)<!-- HN:46151335:end -->
#### **Friday, December 5, 2025**
<!-- HN:46154539:start -->
* [46154539](https://news.social-protocols.org/stats?id=46154539) #5 34 points 42 comments -> [Coca Cola has an executive dedicated to McDonald's](https://www.coca-colacompany.com/about-us/leadership/roberto-mercade)<!-- HN:46154539:end --><!-- HN:46156046:start -->
* [46156046](https://news.social-protocols.org/stats?id=46156046) #9 4 points 4 comments -> [You may loose your company email, but never lose your emails and contacts again](https://app.trevally.io/login.html)<!-- HN:46156046:end --><!-- HN:46156880:start -->
* [46156880](https://news.social-protocols.org/stats?id=46156880) #26 61 points 4 comments -> [Netflix in exclusive talks to buy HBO](https://www.cnn.com/2025/12/04/media/netflix-paramount-wbd-bidding-war-warner-bros-discovery)<!-- HN:46156880:end --><!-- HN:46157648:start -->
* [46157648](https://news.social-protocols.org/stats?id=46157648) #27 9 points 5 comments -> [Undisclosed Deaths in the Pfizer mRNA Covid-19 Vaccine Trial [pdf]](https://jpands.org/vol30no4/kunadhasan.pdf)<!-- HN:46157648:end --><!-- HN:46110291:start -->
* [46110291](https://news.social-protocols.org/stats?id=46110291) #23 3 points 0 comments -> [How many bytes does gzip compress?](https://www.awsistoohard.com/blog/gzip-is-cracked)<!-- HN:46110291:end --><!-- HN:46158846:start -->
* [46158846](https://news.social-protocols.org/stats?id=46158846) #16 9 points 3 comments -> [Four countries to boycott Eurovision 2026 as Israel cleared to compete](https://www.theguardian.com/tv-and-radio/2025/dec/04/ireland-spain-and-the-netherlands-to-boycott-eurovision-2026-as-israel-cleared-to-compete)<!-- HN:46158846:end --><!-- HN:46158338:start -->
* [46158338](https://news.social-protocols.org/stats?id=46158338) #2 -> [Cloudflare Is Down](https://cloudflare.com/)<!-- HN:46158338:end --><!-- HN:46158920:start -->
* [46158920](https://news.social-protocols.org/stats?id=46158920) #13 12 points 0 comments -> [Awful AI is a curated list to track current scary usages of AI](https://github.com/daviddao/awful-ai)<!-- HN:46158920:end --><!-- HN:46156645:start -->
* [46156645](https://news.social-protocols.org/stats?id=46156645) #20 62 points 139 comments -> [Warner Bros Begins Exclusive Deal Talks With Netflix](https://www.bloomberg.com/news/articles/2025-12-05/warner-bros-is-said-to-begin-exclusive-deal-talks-with-netflix)<!-- HN:46156645:end --><!-- HN:46156832:start -->
* [46156832](https://news.social-protocols.org/stats?id=46156832) #10 68 points 12 comments -> [Rats Snatching Bats Out of the Air and Eating Them–Researchers Got It on Video](https://www.smithsonianmag.com/smart-news/rats-are-snatching-bats-out-of-the-air-and-eating-them-and-researchers-got-it-on-video-180987610/)<!-- HN:46156832:end --><!-- HN:46160613:start -->
* [46160613](https://news.social-protocols.org/stats?id=46160613) #30 6 points 1 comments -> [Turning 40](https://andreabergia.com/blog/2025/12/turning-40/)<!-- HN:46160613:end --><!-- HN:46166248:start -->
* [46166248](https://news.social-protocols.org/stats?id=46166248) #7 7 points 0 comments -> [US Supreme Court agrees to hear case challenging birthright citizenship](https://www.bbc.com/news/articles/c208j0wrzrvo)<!-- HN:46166248:end -->
#### **Saturday, December 6, 2025**
<!-- HN:46169903:start -->
* [46169903](https://news.social-protocols.org/stats?id=46169903) #6 9 points 0 comments -> [Five hundred reasons to not use Microsoft Azure](https://azsh.it/500)<!-- HN:46169903:end --><!-- HN:46169355:start -->
* [46169355](https://news.social-protocols.org/stats?id=46169355) #24 10 points 3 comments -> [From Rockets to Heat Pumps](https://www.heatpumped.org/p/from-rockets-to-heat-pumps)<!-- HN:46169355:end --><!-- HN:46173677:start -->
* [46173677](https://news.social-protocols.org/stats?id=46173677) #13 11 points 2 comments -> [Decades-old study on common weed killer retracted](https://www.cbc.ca/news/health/glyphosate-retraction-9.7004363)<!-- HN:46173677:end --><!-- HN:46173785:start -->
* [46173785](https://news.social-protocols.org/stats?id=46173785) #12 8 points 3 comments -> [Carlo is no longer maintained](https://github.com/GoogleChromeLabs/carlo)<!-- HN:46173785:end --><!-- HN:46174878:start -->
* [46174878](https://news.social-protocols.org/stats?id=46174878) #6 10 points 2 comments -> [Show HN: SFX – A language where 0.1 and 0.2 = 0.3 and Context is first-class](https://github.com/roriau0422/sfex-lang)<!-- HN:46174878:end --><!-- HN:46175116:start -->
* [46175116](https://news.social-protocols.org/stats?id=46175116) #5 24 points 3 comments -> [Show HN: I made a tool to make PDFs look scanned because bureaucracy](https://github.com/Francium-Tech/scanify)<!-- HN:46175116:end --><!-- HN:46175481:start -->
* [46175481](https://news.social-protocols.org/stats?id=46175481) #7 11 points 8 comments -> [Fefe is back](http://blog.fefe.de/)<!-- HN:46175481:end --><!-- HN:46176641:start -->
* [46176641](https://news.social-protocols.org/stats?id=46176641) #27 5 points 0 comments -> [Why there are no cracked biotechnologists?](https://partialagonism.substack.com/p/why-there-are-no-cracked-biotechnologists)<!-- HN:46176641:end -->
#### **Sunday, December 7, 2025**
<!-- HN:46177714:start -->
* [46177714](https://news.social-protocols.org/stats?id=46177714) #12 15 points 9 comments -> [A fork of Calibre called Clbre, because the AI is stripped out](https://github.com/grimthorpe/clbre)<!-- HN:46177714:end --><!-- HN:46179339:start -->
* [46179339](https://news.social-protocols.org/stats?id=46179339) #23 6 points 0 comments -> [For US Businesses, Tariff Complexity Is "Death by a Thousand Papercuts"](https://www.cato.org/blog/us-businesses-tariff-complexity-death-thousand-papercuts)<!-- HN:46179339:end --><!-- HN:46182084:start -->
* [46182084](https://news.social-protocols.org/stats?id=46182084) #7 19 points 4 comments -> [Three-year-old forced to serve as her own attorney in Tucson immigration court](https://coppercourier.com/2025/12/05/childrens-immigration-court/)<!-- HN:46182084:end --><!-- HN:46184854:start -->
* [46184854](https://news.social-protocols.org/stats?id=46184854) #21 -> [FBI Making List of American "Extremists," Leaked Memo Reveals](https://www.kenklippenstein.com/p/leak-fbi-list-of-extremists-is-coming)<!-- HN:46184854:end --><!-- HN:46185210:start -->
* [46185210](https://news.social-protocols.org/stats?id=46185210) #20 7 points 1 comments -> [The Ways the AI Bubble Might Burst](https://www.wheresyoured.at/premium-the-ways-the-ai-bubble-might-burst/)<!-- HN:46185210:end --><!-- HN:46185393:start -->
* [46185393](https://news.social-protocols.org/stats?id=46185393) #1 32 points 19 comments -> [F-35 Fighter Jet's C++ Coding Standards [pdf]](https://www.stroustrup.com/JSF-AV-rules.pdf)<!-- HN:46185393:end --><!-- HN:46186573:start -->
* [46186573](https://news.social-protocols.org/stats?id=46186573) #22 6 points 3 comments -> [FL Governor Announces Proposal for Citizen Bill of Rights for AI](https://www.flgov.com/eog/news/press/2025/governor-ron-desantis-announces-proposal-citizen-bill-rights-artificial)<!-- HN:46186573:end -->
#### **Monday, December 8, 2025**<!-- HN:46191826:start -->
* [46191826](https://news.social-protocols.org/stats?id=46191826) #2 10 points 13 comments -> [Pantone Color of the Year 2026: Pantone 11-4201 Cloud Dancer](https://www.pantone.com/color-of-the-year/2026)<!-- HN:46191826:end --><!-- HN:46192919:start -->
* [46192919](https://news.social-protocols.org/stats?id=46192919) #5 36 points 46 comments -> [Microsoft is quietly walking back its diversity efforts](https://www.theverge.com/tech/838079/microsoft-diversity-and-inclusion-changes-notepad)<!-- HN:46192919:end --><!-- HN:46147021:start -->
* [46147021](https://news.social-protocols.org/stats?id=46147021) #25 19 points 0 comments -> [C++ Enum Class and Error Codes, Part 3](https://mropert.github.io/2025/12/03/enum_class_error_codes_part3/)<!-- HN:46147021:end --><!-- HN:46193413:start -->
* [46193413](https://news.social-protocols.org/stats?id=46193413) #1 128 points 2 comments -> [Tsunami warning issued after 7.6-magnitude earthquake strikes Japan](https://earthquake.usgs.gov/earthquakes/map/?currentFeatureId=us6000rtdt&extent=-5.61599,111.26953&extent=70.40735,173.14453)<!-- HN:46193413:end --><!-- HN:46193035:start -->
* [46193035](https://news.social-protocols.org/stats?id=46193035) #4 129 points 1 comments -> [7.6 earthquake off the coast of Japan](https://www.data.jma.go.jp/multi/quake/quake_detail.html?eventID=20251208232600&lang=en)<!-- HN:46193035:end --><!-- HN:46195205:start -->
* [46195205](https://news.social-protocols.org/stats?id=46195205) #10 5 points 1 comments -> ["The Matilda Effect": How Pioneering Women Are Written Out of Science History](https://www.openculture.com/2025/12/matilda-effect.html)<!-- HN:46195205:end -->
#### **Tuesday, December 9, 2025**
<!-- HN:46200420:start -->
* [46200420](https://news.social-protocols.org/stats?id=46200420) #4 18 points 7 comments -> [The power of proximity to coworkers [pdf]](https://pallais.scholars.harvard.edu/sites/g/files/omnuum5926/files/2025-11/Power%20of%20Proximity%20to%20Coworkers%20November%202025.pdf)<!-- HN:46200420:end --><!-- HN:46203665:start -->
* [46203665](https://news.social-protocols.org/stats?id=46203665) #18 53 points 30 comments -> [Torture Techniques from CIA Black Sites Were Used at Alligator Alcatraz](https://www.forever-wars.com/torture-techniques-from-cia-black-sites-were-used-at-alligator-alcatraz/)<!-- HN:46203665:end --><!-- HN:46205532:start -->
* [46205532](https://news.social-protocols.org/stats?id=46205532) #7 17 points 9 comments -> [Engineers: Stop trying to win other people's game](https://www.anthonyputignano.com/p/the-western-front-advantage-how-junior)<!-- HN:46205532:end --><!-- HN:46206863:start -->
* [46206863](https://news.social-protocols.org/stats?id=46206863) #28 20 points 5 comments -> [Berkeley professor's camera caught student allegedly sabotaging another student](https://www.mercurynews.com/2025/12/08/uc-berkeley-professor-installed-secret-camera-allegedly-catching-phd-candidate-sabotaging-fellow-students-work/)<!-- HN:46206863:end --><!-- HN:46210095:start -->
* [46210095](https://news.social-protocols.org/stats?id=46210095) #12 33 points 42 comments -> [We Need to Die](https://willllliam.com/blog/why-we-need-to-die/)<!-- HN:46210095:end --><!-- HN:46210661:start -->
* [46210661](https://news.social-protocols.org/stats?id=46210661) #8 21 points 45 comments -> [I misused LLMs to diagnose myself and ended up bedridden for a week](https://blog.shortround.space/blog/how-i-misused-llms-to-diagnose-myself-and-ended-up-bedridden-for-a-week/)<!-- HN:46210661:end --><!-- HN:46210994:start -->
* [46210994](https://news.social-protocols.org/stats?id=46210994) #10 6 points 3 comments -> [Canada's US Travel Boycott Is Backfiring in the Most Unexpected Way at US Border](https://www.thetravel.com/canadas-us-travel-boycott-is-backfiring-canadians-face-more-detailed-border-controls/)<!-- HN:46210994:end -->
#### **Wednesday, December 10, 2025**
<!-- HN:46212325:start -->
* [46212325](https://news.social-protocols.org/stats?id=46212325) #6 8 points 1 comments -> [US International Trade Administration Shaped EU Censorship Against US Companies](https://foundationforfreedomonline.com/us-international-trade-administration-shaped-eu-censorship-law/)<!-- HN:46212325:end --><!-- HN:46211953:start -->
* [46211953](https://news.social-protocols.org/stats?id=46211953) #18 9 points 2 comments -> [Show HN: Gemini 3 imagines Hacker News as a HyperCard stack in 1994](https://hyper-card-hacker-news.vercel.app/)<!-- HN:46211953:end -->