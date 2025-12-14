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
* [46206863](https://news.social-protocols.org/stats?id=46206863) #28 20 points 5 comments -> [Berkeley professor's camera caught student allegedly sabotaging another student](https://www.mercurynews.com/2025/12/08/uc-berkeley-professor-installed-secret-camera-allegedly-catching-phd-candidate-sabotaging-fellow-students-work/)<!-- HN:46206863:end --><!-- HN:46210661:start -->
* [46210661](https://news.social-protocols.org/stats?id=46210661) #8 21 points 45 comments -> [I misused LLMs to diagnose myself and ended up bedridden for a week](https://blog.shortround.space/blog/how-i-misused-llms-to-diagnose-myself-and-ended-up-bedridden-for-a-week/)<!-- HN:46210661:end --><!-- HN:46210994:start -->
* [46210994](https://news.social-protocols.org/stats?id=46210994) #10 6 points 3 comments -> [Canada's US Travel Boycott Is Backfiring in the Most Unexpected Way at US Border](https://www.thetravel.com/canadas-us-travel-boycott-is-backfiring-canadians-face-more-detailed-border-controls/)<!-- HN:46210994:end -->
#### **Wednesday, December 10, 2025**
<!-- HN:46212325:start -->
* [46212325](https://news.social-protocols.org/stats?id=46212325) #6 8 points 1 comments -> [US International Trade Administration Shaped EU Censorship Against US Companies](https://foundationforfreedomonline.com/us-international-trade-administration-shaped-eu-censorship-law/)<!-- HN:46212325:end --><!-- HN:46213161:start -->
* [46213161](https://news.social-protocols.org/stats?id=46213161) #21 5 points 0 comments -> [Google kills Gemini Cloud Services (2035)](https://sw.vtom.net/hn35/item.html?id=90099555)<!-- HN:46213161:end --><!-- HN:46171463:start -->
* [46171463](https://news.social-protocols.org/stats?id=46171463) #19 29 points 12 comments -> [Very Important People](https://dirt.fyi/article/2025/11/very-important-people)<!-- HN:46171463:end --><!-- HN:46215688:start -->
* [46215688](https://news.social-protocols.org/stats?id=46215688) #28 28 points 40 comments -> [Big Tech are the new Soviets](https://unherd.com/2025/12/big-tech-are-the-new-soviets/)<!-- HN:46215688:end --><!-- HN:46169508:start -->
* [46169508](https://news.social-protocols.org/stats?id=46169508) #29 26 points 40 comments -> [Are We over the "Jaws Effect?"](https://nautil.us/are-we-finally-over-the-jaws-effect-1253001/)<!-- HN:46169508:end --><!-- HN:46217755:start -->
* [46217755](https://news.social-protocols.org/stats?id=46217755) #24 4 points 0 comments -> [Hamas hid tons of baby formula to damage Israel with starvation claims](https://nypost.com/2025/12/09/world-news/hamas-hid-tons-of-baby-formula-to-damage-israel-with-starvation-claims-palestinian-activist-says/)<!-- HN:46217755:end --><!-- HN:46217793:start -->
* [46217793](https://news.social-protocols.org/stats?id=46217793) #1 20 points 16 comments -> [Taxing Growth](https://www.equitileconversations.com/2459100/episodes/18312924-taxing-growth)<!-- HN:46217793:end --><!-- HN:46148995:start -->
* [46148995](https://news.social-protocols.org/stats?id=46148995) #18 5 points 3 comments -> [Rust: Proof of Concept, Not Replacement](https://files.neoon.com/rust-game-over-203X.html)<!-- HN:46148995:end --><!-- HN:46218537:start -->
* [46218537](https://news.social-protocols.org/stats?id=46218537) #12 14 points 5 comments -> [Why AGI Will Not Happen](https://timdettmers.com/2025/12/10/why-agi-will-not-happen/)<!-- HN:46218537:end --><!-- HN:46224610:start -->
* [46224610](https://news.social-protocols.org/stats?id=46224610) #15 57 points 47 comments -> [Rubio orders return to Times New Roman font over 'wasteful' Calibri](https://www.bbc.com/news/articles/cgkez3367xmo)<!-- HN:46224610:end --><!-- HN:46173584:start -->
* [46173584](https://news.social-protocols.org/stats?id=46173584) #29 11 points 6 comments -> [Resolution Dynamics: Deriving the Fine Structure Constant from Shannon Capacity](https://zenodo.org/records/17821936)<!-- HN:46173584:end -->
#### **Thursday, December 11, 2025**<!-- HN:46228916:start -->
* [46228916](https://news.social-protocols.org/stats?id=46228916) #23 4 points 1 comments -> [Hamas hid tons of baby formula to damage Israel with starvation claims](https://www.theaustralian.com.au/world/hamas-hid-tons-of-baby-formula-to-damage-israel-with-starvation-claims-palestinian-activist-says/news-story/c0884abf9e71450cc2db1675e75572c0)<!-- HN:46228916:end --><!-- HN:46229346:start -->
* [46229346](https://news.social-protocols.org/stats?id=46229346) #13 52 points 43 comments -> [Just 0.001% hold 3 times the wealth of poorest half of humanity, report finds](https://www.theguardian.com/inequality/2025/dec/10/just-0001-hold-three-times-the-wealth-of-poorest-half-of-humanity-report-finds)<!-- HN:46229346:end --><!-- HN:46232222:start -->
* [46232222](https://news.social-protocols.org/stats?id=46232222) #20 19 points 41 comments -> [Did that Colorado station sign say gas for only $1.69? Yes, it did](https://coloradosun.com/2025/12/11/colorado-gas-prices-falling-national-average/)<!-- HN:46232222:end --><!-- HN:46234874:start -->
* [46234874](https://news.social-protocols.org/stats?id=46234874) #3 174 points 68 comments -> [GPT-5.2](https://openai.com/index/introducing-gpt-5-2/)<!-- HN:46234874:end --><!-- HN:46235531:start -->
* [46235531](https://news.social-protocols.org/stats?id=46235531) #2 92 points 2 comments -> [Age Verification Is Coming for the Internet](https://www.eff.org/deeplinks/2025/12/age-verification-coming-internet-we-built-you-resource-hub-fight-back)<!-- HN:46235531:end --><!-- HN:46231585:start -->
* [46231585](https://news.social-protocols.org/stats?id=46231585) #19 318 points 2 comments -> [Disney making $1B investment in OpenAI, will allow characters on Sora AI](https://www.cnbc.com/2025/12/11/disney-openai-sora-characters-video.html)<!-- HN:46231585:end --><!-- HN:46237515:start -->
* [46237515](https://news.social-protocols.org/stats?id=46237515) #6 19 points 1 comments -> [React2Shell and related RSC vulnerabilities threat brief](https://blog.cloudflare.com/react2shell-rsc-vulnerabilities-exploitation-threat-brief/)<!-- HN:46237515:end --><!-- HN:46237527:start -->
* [46237527](https://news.social-protocols.org/stats?id=46237527) #4 27 points 1 comments -> [Two new RSC protocol vulnerabilities uncovered](https://nextjs.org/blog/security-update-2025-12-11)<!-- HN:46237527:end -->
#### **Friday, December 12, 2025**
<!-- HN:46236738:start -->
* [46236738](https://news.social-protocols.org/stats?id=46236738) #26 329 points 325 comments -> [UK House of Lords attempting to ban use of VPNs by anyone under 16](https://alecmuffett.com/article/134925)<!-- HN:46236738:end --><!-- HN:46175894:start -->
* [46175894](https://news.social-protocols.org/stats?id=46175894) #20 3 points 1 comments -> [One Last Trip: Traveling with my brother's remains (2022)](https://www.thecut.com/2022/03/traveling-brothers-remains.html)<!-- HN:46175894:end --><!-- HN:46154190:start -->
* [46154190](https://news.social-protocols.org/stats?id=46154190) #21 18 points 2 comments -> [Tile IR Specification](https://docs.nvidia.com/cuda/tile-ir/)<!-- HN:46154190:end --><!-- HN:46138534:start -->
* [46138534](https://news.social-protocols.org/stats?id=46138534) #26 13 points 2 comments -> [The Invisible Cost: From Creator to Consumer](https://edwardnoaland.substack.com/p/the-invisible-cost-from-creator-to)<!-- HN:46138534:end --><!-- HN:46240998:start -->
* [46240998](https://news.social-protocols.org/stats?id=46240998) #25 7 points 3 comments -> [Show HN: I got my site down to 237kb by ditching Google Analytics](https://deadstack.net/)<!-- HN:46240998:end --><!-- HN:46242513:start -->
* [46242513](https://news.social-protocols.org/stats?id=46242513) #13 21 points 11 comments -> [You are dating an ecosystem](https://www.razor.blog/2025/12/you-will-never-be-in-two-person.html)<!-- HN:46242513:end --><!-- HN:46243586:start -->
* [46243586](https://news.social-protocols.org/stats?id=46243586) #22 8 points 1 comments -> [Censorship in Western Academia and the War in Ukraine](https://www.newglobalpolitics.org/censorship-in-western-academia-and-the-war-in-ukraine/)<!-- HN:46243586:end --><!-- HN:46246223:start -->
* [46246223](https://news.social-protocols.org/stats?id=46246223) #28 6 points 2 comments -> [Trump repeats baseless claim about Haitian immigrants eating pets](https://clipnotebook.com/p/671d1ace-bc25-478e-b631-42c226dfc360)<!-- HN:46246223:end --><!-- HN:46245971:start -->
* [46245971](https://news.social-protocols.org/stats?id=46245971) #9 15 points 16 comments -> [Why more American seniors are getting high](https://www.economist.com/graphic-detail/2025/12/11/why-more-american-seniors-are-getting-high)<!-- HN:46245971:end --><!-- HN:46190877:start -->
* [46190877](https://news.social-protocols.org/stats?id=46190877) #11 9 points 6 comments -> [How to Articulate Yourself Intelligently](https://letters.thedankoe.com/p/how-to-articulate-yourself-intelligently)<!-- HN:46190877:end --><!-- HN:46246117:start -->
* [46246117](https://news.social-protocols.org/stats?id=46246117) #29 32 points 10 comments -> [Show HN: tomcp.org – Turn any URL into an MCP server](https://github.com/Ami3466/tomcp)<!-- HN:46246117:end -->
#### **Saturday, December 13, 2025**
<!-- HN:46249834:start -->
* [46249834](https://news.social-protocols.org/stats?id=46249834) #24 16 points 4 comments -> [Can I use HTTPS RRs?](https://www.netmeister.org/blog/https-caniuse.html)<!-- HN:46249834:end --><!-- HN:46192924:start -->
* [46192924](https://news.social-protocols.org/stats?id=46192924) #29 7 points 3 comments -> [How we built context management for tab completion](https://docs.getpochi.com/developer-updates/context-management-in-your-editor/)<!-- HN:46192924:end --><!-- HN:46251852:start -->
* [46251852](https://news.social-protocols.org/stats?id=46251852) #26 -> [Show HN: Claude Code Recipes for Knowledge Workers (Open Source)](https://github.com/sgharlow/claude-code-recipes)<!-- HN:46251852:end --><!-- HN:46254276:start -->
* [46254276](https://news.social-protocols.org/stats?id=46254276) #11 45 points 57 comments -> [AI is bringing old nuclear plants out of retirement](https://www.wbur.org/hereandnow/2025/12/09/nuclear-power-ai)<!-- HN:46254276:end --><!-- HN:46255697:start -->
* [46255697](https://news.social-protocols.org/stats?id=46255697) #1 9 points 14 comments -> [Show HN: Kinkora – A creative playground for experimenting with video models](https://kinkora.fun/)<!-- HN:46255697:end --><!-- HN:46255158:start -->
* [46255158](https://news.social-protocols.org/stats?id=46255158) #23 32 points 23 comments -> [Show HN: I audited 500 K8s pods. Java wastes ~48% RAM, Go ~18%](https://github.com/WozzHQ/wozz)<!-- HN:46255158:end --><!-- HN:46256504:start -->
* [46256504](https://news.social-protocols.org/stats?id=46256504) #8 10 points 1 comments -> [Purrtran – ᓚᘏᗢ – A Programming Language for Cat People](https://github.com/cmontella/purrtran)<!-- HN:46256504:end --><!-- HN:46259102:start -->
* [46259102](https://news.social-protocols.org/stats?id=46259102) #2 15 points 0 comments -> [Multiple shootings by active shooter at Brown University](https://www.brown.edu/)<!-- HN:46259102:end -->
#### **Sunday, December 14, 2025**
<!-- HN:46178966:start -->
* [46178966](https://news.social-protocols.org/stats?id=46178966) #25 4 points 2 comments -> [Rio de Janeiro's talipot palm trees bloom for the first and only time](https://en.jardineriaon.com/The-talipot-palm-trees-of-Rio-de-Janeiro-bloom-for-the-first-and-only-time.html)<!-- HN:46178966:end --><!-- HN:46261739:start -->
* [46261739](https://news.social-protocols.org/stats?id=46261739) #2 56 points 34 comments -> [Surface Tension of Software](https://iamstelios.com/blog/surface-tension-of-software/)<!-- HN:46261739:end --><!-- HN:46263874:start -->
* [46263874](https://news.social-protocols.org/stats?id=46263874) #8 16 points 21 comments -> [AI was not invented, it arrived](https://andrewarrow.dev/2025/12/ai-was-not-invented-it-arrived/)<!-- HN:46263874:end --><!-- HN:46265378:start -->
* [46265378](https://news.social-protocols.org/stats?id=46265378) #28 3 points 1 comments -> [Hero who disarmed one of the Bondi Beach attackers by grabbing his gun](https://www.dailymail.co.uk/news/article-15382973/Hero-disarmed-one-Bondi-Beach-attackers-grabbing-gun-father-two-fruit-shop-owner.html)<!-- HN:46265378:end --><!-- HN:46264657:start -->
* [46264657](https://news.social-protocols.org/stats?id=46264657) #10 17 points 10 comments -> [Show HN: a Pager](https://www.udp7777.com/)<!-- HN:46264657:end --><!-- HN:46264955:start -->
* [46264955](https://news.social-protocols.org/stats?id=46264955) #6 28 points 35 comments -> [Sacrificing accessibility for not getting web scraped](https://tilschuenemann.de/projects/sacrificing-accessibility-for-not-getting-web-scraped)<!-- HN:46264955:end --><!-- HN:46265457:start -->
* [46265457](https://news.social-protocols.org/stats?id=46265457) #29 5 points 2 comments -> [Mass shooting in Australia – 12 dead -terrorist event](https://www.dailytelegraph.com.au/news/nsw/beachgoers-flee-as-gunshots-heard-in-bondi/live-coverage/f7f1e82a4b957533cac56ba0809cb9ba)<!-- HN:46265457:end --><!-- HN:46265697:start -->
* [46265697](https://news.social-protocols.org/stats?id=46265697) #30 6 points 4 comments -> [Update Now Warning Issued to All iPhone Users](https://www.forbes.com/sites/kateoflahertyuk/2025/12/14/ios-262-update-now-waning-issued-to-all-iphone-users/)<!-- HN:46265697:end -->