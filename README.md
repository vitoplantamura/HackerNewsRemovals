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

#### **Monday, February 17, 2025**
<!-- HN:43072640:start -->
* [43072640](https://news.social-protocols.org/stats?id=43072640) #23 10 points 2 comments -> [Why Artificial General Intelligence Is and Remains a Fiction](https://osf.io/preprints/osf/fjcns_v1)<!-- HN:43072640:end --><!-- HN:43073773:start -->
* [43073773](https://news.social-protocols.org/stats?id=43073773) #15 19 points 8 comments -> [America will collapse by 2025 (2010)](https://www.salon.com/2010/12/06/america_collapse_2025/)<!-- HN:43073773:end --><!-- HN:43073481:start -->
* [43073481](https://news.social-protocols.org/stats?id=43073481) #5 13 points 5 comments -> [How to add a directory to your PATH](https://jvns.ca/blog/2025/02/13/how-to-add-a-directory-to-your-path/)<!-- HN:43073481:end --><!-- HN:43074155:start -->
* [43074155](https://news.social-protocols.org/stats?id=43074155) #22 55 points 23 comments -> [Elon Musk's terrifying vision for AI](https://garymarcus.substack.com/p/elon-musks-terrifying-vision-for)<!-- HN:43074155:end --><!-- HN:43074291:start -->
* [43074291](https://news.social-protocols.org/stats?id=43074291) #27 48 points 2 comments -> [Javier Milei risks impeachment after endorsing $107M Libra rug pull](https://cointelegraph.com/news/javier-milei-risks-impeachment-107-m-libra-rug-pull)<!-- HN:43074291:end --><!-- HN:43075724:start -->
* [43075724](https://news.social-protocols.org/stats?id=43075724) #21 5 points 0 comments -> [Trump's true enemy isn't China or Russia but liberal democracy](https://nickcohen.substack.com/p/trumps-true-enemy-isnt-china-or-russia)<!-- HN:43075724:end --><!-- HN:43077175:start -->
* [43077175](https://news.social-protocols.org/stats?id=43077175) #6 17 points 3 comments -> [Broligarchy does not build civilization](https://not-a-tech-bro.ghost.io/broligarchy-does-not-build-civilization/)<!-- HN:43077175:end --><!-- HN:43079109:start -->
* [43079109](https://news.social-protocols.org/stats?id=43079109) #5 9 points 1 comments -> [Show HN: Bag of words – Build and share smart data apps using AI](https://github.com/bagofwords1/bagofwords)<!-- HN:43079109:end --><!-- HN:43038109:start -->
* [43038109](https://news.social-protocols.org/stats?id=43038109) #20 145 points 40 comments -> [Anno 1800: Shadows of Beauty](https://simonschreibt.de/gat/anno-1800-shadows-of-beauty/)<!-- HN:43038109:end --><!-- HN:43039140:start -->
* [43039140](https://news.social-protocols.org/stats?id=43039140) #26 38 points 7 comments -> [Tokyo Xtreme Racer Early Access Review: We Are So Back](https://www.thedrive.com/news/tokyo-xtreme-racer-early-access-review)<!-- HN:43039140:end --><!-- HN:43076137:start -->
* [43076137](https://news.social-protocols.org/stats?id=43076137) #22 114 points 107 comments -> [Managers given 200 characters to justify not firing nuclear regulators](https://www.npr.org/2025/02/14/nx-s1-5298190/nuclear-agency-trump-firings-nnsa)<!-- HN:43076137:end --><!-- HN:43069533:start -->
* [43069533](https://news.social-protocols.org/stats?id=43069533) #18 223 points 342 comments -> [IPv6 Is Hard](https://techlog.jenslink.net/posts/ipv6-is-hard/)<!-- HN:43069533:end --><!-- HN:43077833:start -->
* [43077833](https://news.social-protocols.org/stats?id=43077833) #13 41 points 25 comments -> [Open source maintainers are feeling the squeeze](https://www.theregister.com/2025/02/16/open_source_maintainers_state_of_open/)<!-- HN:43077833:end --><!-- HN:43076418:start -->
* [43076418](https://news.social-protocols.org/stats?id=43076418) #22 60 points 45 comments -> [Is ChatGPT autocomplete bad UX/UI?](https://honzabe.com/blog/posts/chatgpt-autocomplete-bad-ux-ui/)<!-- HN:43076418:end --><!-- HN:43077551:start -->
* [43077551](https://news.social-protocols.org/stats?id=43077551) #27 36 points 25 comments -> [Techie pointed out meetings are pointless, and was punished for it](https://www.theregister.com/2025/02/17/who_me/)<!-- HN:43077551:end --><!-- HN:43054506:start -->
* [43054506](https://news.social-protocols.org/stats?id=43054506) #18 9 points 4 comments -> [Show HN: Tools for Math Research](https://sugaku.net/)<!-- HN:43054506:end --><!-- HN:43083280:start -->
* [43083280](https://news.social-protocols.org/stats?id=43083280) #4 94 points 10 comments -> [Project 2025 Observer](https://www.project2025.observer/)<!-- HN:43083280:end --><!-- HN:43084176:start -->
* [43084176](https://news.social-protocols.org/stats?id=43084176) #29 5 points 0 comments -> [Racism Against Indians: The Internet's Acceptable Prejudice](https://substack.com/home/post/p-156976775)<!-- HN:43084176:end -->
#### **Tuesday, February 18, 2025**
<!-- HN:43084215:start -->
* [43084215](https://news.social-protocols.org/stats?id=43084215) #22 -> [Hundreds fired at aviation safety agency, union says](https://www.bbc.com/news/articles/cly9y1e1kpjo)<!-- HN:43084215:end --><!-- HN:43085712:start -->
* [43085712](https://news.social-protocols.org/stats?id=43085712) #29 6 points 1 comments -> [X is reportedly blocking links to secure Signal contact pages](https://arstechnica.com/gadgets/2025/02/x-is-reportedly-blocking-links-to-secure-signal-contact-pages/)<!-- HN:43085712:end --><!-- HN:43084998:start -->
* [43084998](https://news.social-protocols.org/stats?id=43084998) #16 13 points 1 comments -> [John Carmack discusses SpaceX strategy and Mars](https://twitter.com/ID_AA_Carmack/status/1890178216436043828)<!-- HN:43084998:end --><!-- HN:43079656:start -->
* [43079656](https://news.social-protocols.org/stats?id=43079656) #10 -> [Why Upstart from Ubuntu Failed](https://machaddr.substack.com/p/why-upstart-from-ubuntu-failed)<!-- HN:43079656:end --><!-- HN:43047590:start -->
* [43047590](https://news.social-protocols.org/stats?id=43047590) #13 7 points 1 comments -> [Indian native rediscovers Department of Defense 1963 Algorithm](https://math.stackexchange.com/questions/4744025/factoring-an-integer-using-its-zeckendorf-representation)<!-- HN:43047590:end --><!-- HN:43086952:start -->
* [43086952](https://news.social-protocols.org/stats?id=43086952) #11 3 points 2 comments -> [Maharishi Effect: 1% of population practicing TM produces results for all](https://research.miu.edu/maharishi-effect/)<!-- HN:43086952:end --><!-- HN:43088163:start -->
* [43088163](https://news.social-protocols.org/stats?id=43088163) #25 8 points 42 comments -> [Huawei launches $3,660 trifold phone](https://www.cnbc.com/2025/02/18/huawei-mate-xt-trifold-launches-outside-of-china-price-specs-.html)<!-- HN:43088163:end --><!-- HN:43089068:start -->
* [43089068](https://news.social-protocols.org/stats?id=43089068) #27 6 points 0 comments -> [Policing the internet in Germany, where hate speech, insults are a crime [video]](https://www.youtube.com/watch?v=-bMzFDpfDwc)<!-- HN:43089068:end --><!-- HN:43083687:start -->
* [43083687](https://news.social-protocols.org/stats?id=43083687) #17 131 points 31 comments -> [Setting up a trusted, self-signed SSL/TLS certificate authority in Linux](https://previnder.com/tls-ca-linux/)<!-- HN:43083687:end --><!-- HN:43088993:start -->
* [43088993](https://news.social-protocols.org/stats?id=43088993) #27 58 points 31 comments -> [Tesla was hit by a wave of protests, sales are crashing, insiders are waking up](https://electrek.co/2025/02/17/tesla-was-hit-by-a-wave-of-protests-over-musk-sales-are-crashing-insiders-are-waking-up/)<!-- HN:43088993:end --><!-- HN:43083772:start -->
* [43083772](https://news.social-protocols.org/stats?id=43083772) #21 291 points 72 comments -> [List of DRM-Free Bookshops](https://libreture.com/bookshops/)<!-- HN:43083772:end --><!-- HN:43081378:start -->
* [43081378](https://news.social-protocols.org/stats?id=43081378) #28 149 points 12 comments -> [Small Tech](https://www.scattered-thoughts.net/writing/small-tech/)<!-- HN:43081378:end --><!-- HN:43091340:start -->
* [43091340](https://news.social-protocols.org/stats?id=43091340) #9 5 points 0 comments -> [Grok-3, the Nvidia Shortcut, Competitive Implications](https://stratechery.com/2025/grok-3-the-nvidia-shortcut-competitive-implications/)<!-- HN:43091340:end --><!-- HN:43090851:start -->
* [43090851](https://news.social-protocols.org/stats?id=43090851) #6 12 points 0 comments -> [The Empire Self-Destructs](https://chrishedges.substack.com/p/the-empire-self-destructs)<!-- HN:43090851:end --><!-- HN:43092378:start -->
* [43092378](https://news.social-protocols.org/stats?id=43092378) #2 42 points 9 comments -> [X Prevents Research on Potential Election Interference](https://freiheitsrechte.org/en/themen/digitale-grundrechte/x)<!-- HN:43092378:end --><!-- HN:43092421:start -->
* [43092421](https://news.social-protocols.org/stats?id=43092421) #14 10 points 12 comments -> [A simple geometry question that fools almost everyone](https://www.theguardian.com/science/2025/feb/17/can-you-solve-it-the-simple-geometry-question-that-fools-almost-everyone)<!-- HN:43092421:end --><!-- HN:43093429:start -->
* [43093429](https://news.social-protocols.org/stats?id=43093429) #11 16 points 1 comments -> [Thinking Machines Lab](https://thinkingmachines.ai/)<!-- HN:43093429:end --><!-- HN:43067123:start -->
* [43067123](https://news.social-protocols.org/stats?id=43067123) #16 5 points 0 comments -> [Yes you built that but at what cost?](https://www.abhinavomprakash.com/posts/tradeoffs/)<!-- HN:43067123:end --><!-- HN:43093044:start -->
* [43093044](https://news.social-protocols.org/stats?id=43093044) #19 37 points 2 comments -> [OpenAI Announces New SWE-Lancer Benchmark](https://openai.com/index/swe-lancer/)<!-- HN:43093044:end --><!-- HN:43096446:start -->
* [43096446](https://news.social-protocols.org/stats?id=43096446) #12 -> [Doge Savings](https://doge.gov/savings)<!-- HN:43096446:end -->
#### **Wednesday, February 19, 2025**
<!-- HN:43098019:start -->
* [43098019](https://news.social-protocols.org/stats?id=43098019) #5 7 points 2 comments -> [Visualized: Presidential Executive Orders](https://www.opicdata.com/blog/presidential-executive-orders)<!-- HN:43098019:end --><!-- HN:43098806:start -->
* [43098806](https://news.social-protocols.org/stats?id=43098806) #6 7 points 0 comments -> [Cruel ASMR Video by the White House of Deporting Immigrants](https://kottke.org/25/02/unbelievably-cruel-asmr-video-immigrants)<!-- HN:43098806:end --><!-- HN:43099417:start -->
* [43099417](https://news.social-protocols.org/stats?id=43099417) #10 13 points 11 comments -> [uBlock Origin Has Been Disabled](https://ublockorigin.com)<!-- HN:43099417:end --><!-- HN:43099826:start -->
* [43099826](https://news.social-protocols.org/stats?id=43099826) #20 127 points 69 comments -> [A few hours ago, the US has turned into a de-facto dictatorship](https://old.reddit.com/r/law/comments/1isvzgu/the_full_executive_order_is_out_this_is_the)<!-- HN:43099826:end --><!-- HN:43101073:start -->
* [43101073](https://news.social-protocols.org/stats?id=43101073) #25 5 points 1 comments -> [Libra Token's Co-Creator Claimed He Paid Argentinian President Milei's Sister](https://www.coindesk.com/business/2025/02/18/libra-token-s-co-creator-bragged-of-sending-money-to-argentine-president-milei-s-sister)<!-- HN:43101073:end --><!-- HN:43055400:start -->
* [43055400](https://news.social-protocols.org/stats?id=43055400) #21 120 points 7 comments -> [Little Sisyphus A physics-based platformer for the NES](https://pubby.games/sisyphus.html)<!-- HN:43055400:end --><!-- HN:43102771:start -->
* [43102771](https://news.social-protocols.org/stats?id=43102771) #24 3 points 3 comments -> [Cargo Cult Programming](https://en.wikipedia.org/wiki/Cargo_cult_programming)<!-- HN:43102771:end --><!-- HN:43102231:start -->
* [43102231](https://news.social-protocols.org/stats?id=43102231) #28 9 points 1 comments -> [Penguins Help to Map Antarctica's Growing Mercury Threat](https://www.scientificamerican.com/article/penguins-help-to-map-antarcticas-growing-mercury-threat/)<!-- HN:43102231:end --><!-- HN:43102775:start -->
* [43102775](https://news.social-protocols.org/stats?id=43102775) #15 26 points 14 comments -> [America stopped caring how poor kids do in school](https://www.slowboring.com/p/america-stopped-caring-how-poor-kids)<!-- HN:43102775:end --><!-- HN:43097747:start -->
* [43097747](https://news.social-protocols.org/stats?id=43097747) #20 94 points 50 comments -> [The Unbrickable Pledge](https://usetrmnl.com/blog/the-unbrickable-pledge)<!-- HN:43097747:end --><!-- HN:43103272:start -->
* [43103272](https://news.social-protocols.org/stats?id=43103272) #6 5 points 0 comments -> [Apache Airflow: Key Use Cases, Architectural Insights, and Pro Tips](https://codingcops.com/apache-airflow/)<!-- HN:43103272:end --><!-- HN:43066340:start -->
* [43066340](https://news.social-protocols.org/stats?id=43066340) #18 17 points 0 comments -> [Designer Diary: Panda Royale](https://boardgamegeek.com/blog/1/blogpost/165251/designer-diary-panda-royale)<!-- HN:43066340:end --><!-- HN:43104075:start -->
* [43104075](https://news.social-protocols.org/stats?id=43104075) #25 4 points 0 comments -> [America Needs a Working-Class Media](https://www.cjr.org/analysis/america-needs-working-class-media-end-catering-rich-audiences.php)<!-- HN:43104075:end --><!-- HN:43104652:start -->
* [43104652](https://news.social-protocols.org/stats?id=43104652) #22 11 points 0 comments -> [Trump Calls Zelensky a 'Dictator'](https://www.bbc.com/news/live/c62e2158mkpt)<!-- HN:43104652:end --><!-- HN:43104684:start -->
* [43104684](https://news.social-protocols.org/stats?id=43104684) #19 18 points 12 comments -> [European Alternatives for Popular Services](https://european-alternatives.eu/alternatives-to)<!-- HN:43104684:end --><!-- HN:43105472:start -->
* [43105472](https://news.social-protocols.org/stats?id=43105472) #17 -> [Trump administration kills New York City's congestion pricing](https://www.cnn.com/2025/02/19/business/trump-kills-congestion-pricing-nyc/index.html)<!-- HN:43105472:end --><!-- HN:43066347:start -->
* [43066347](https://news.social-protocols.org/stats?id=43066347) #20 4 points 1 comments -> [Colocation](https://kentcdodds.com/blog/colocation)<!-- HN:43066347:end --><!-- HN:43106086:start -->
* [43106086](https://news.social-protocols.org/stats?id=43106086) #22 7 points 3 comments -> [GPT4 level intelligence fell 1000x in 18 months](https://twitter.com/swyx/status/1882933368444309723)<!-- HN:43106086:end --><!-- HN:43105959:start -->
* [43105959](https://news.social-protocols.org/stats?id=43105959) #19 21 points 2 comments -> [Building a Bitcoin Exchange with FOSS BTC Pay Server](https://blog.btcpayserver.org/case-study-unbank/)<!-- HN:43105959:end --><!-- HN:43108513:start -->
* [43108513](https://news.social-protocols.org/stats?id=43108513) #6 13 points 5 comments -> [Behavioural Patterns Are the New Skin Colour](https://www.nthprocess.com/behavioural-patterns-are-the-new-skin-colour-2/)<!-- HN:43108513:end --><!-- HN:43108714:start -->
* [43108714](https://news.social-protocols.org/stats?id=43108714) #10 10 points 0 comments -> [Good samaritan offers .com domain for free](http://mynewdomainhahaha.com/)<!-- HN:43108714:end -->
#### **Thursday, February 20, 2025**
<!-- HN:43109376:start -->
* [43109376](https://news.social-protocols.org/stats?id=43109376) #17 13 points 0 comments -> [Trump's firing spree rises to SCOTUS as watchdog attorney challenges termination](https://www.courthousenews.com/trumps-firing-spree-rises-to-scotus-as-watchdog-government-attorney-challenges-termination/)<!-- HN:43109376:end --><!-- HN:43109537:start -->
* [43109537](https://news.social-protocols.org/stats?id=43109537) #28 12 points 0 comments -> [ICE Prosecutor in Dallas Runs White Supremacist X Account](https://www.texasobserver.org/ice-prosecutor-dallas-white-supremacist-x-account/)<!-- HN:43109537:end --><!-- HN:43109915:start -->
* [43109915](https://news.social-protocols.org/stats?id=43109915) #28 10 points 3 comments -> [Trump signs order declaring only president and AG can interpret US law](https://www.jurist.org/news/2025/02/trump-signs-order-declaring-only-president-and-ag-can-interpret-us-law-for-executive-branch/)<!-- HN:43109915:end --><!-- HN:43110539:start -->
* [43110539](https://news.social-protocols.org/stats?id=43110539) #12 48 points 18 comments -> [Doge Teen with Cybercrime Connections Now Inside Cybersecurity Agency CISA](https://www.nextgov.com/cybersecurity/2025/02/doge-employee-edward-coristine-lands-cisa-dhs-email/403126/)<!-- HN:43110539:end --><!-- HN:43111607:start -->
* [43111607](https://news.social-protocols.org/stats?id=43111607) #29 5 points 2 comments -> [Doge accounting of savings is mostly incorrect](https://twitter.com/electricfutures/status/1891898336208105676)<!-- HN:43111607:end --><!-- HN:43111876:start -->
* [43111876](https://news.social-protocols.org/stats?id=43111876) #22 8 points 1 comments -> [Show HN: Devv – launch your API services in minutes](https://devv.ai/build)<!-- HN:43111876:end --><!-- HN:43067002:start -->
* [43067002](https://news.social-protocols.org/stats?id=43067002) #11 48 points 6 comments -> [Requesting SDK for Meta Ray-Ban Smart Glasses for Visually Impaired Users](https://communityforums.atmeta.com/t5/General-VR-MR-Development/Suggestion-for-Developing-an-SDK-for-Meta-Ray-ban-Glasses/td-p/1196341/page/2)<!-- HN:43067002:end --><!-- HN:43074559:start -->
* [43074559](https://news.social-protocols.org/stats?id=43074559) #14 16 points 1 comments -> [Someone put an iPhone SE 3 inside a Nokia Lumia 1020](https://old.reddit.com/r/hackintosh/comments/1ime6y2/hackintosh_but_on_a_phone_lumiphone_1020_se/)<!-- HN:43074559:end --><!-- HN:43112036:start -->
* [43112036](https://news.social-protocols.org/stats?id=43112036) #28 68 points 24 comments -> [The Plan 9 Foundation](https://plan9foundation.org/)<!-- HN:43112036:end --><!-- HN:43087774:start -->
* [43087774](https://news.social-protocols.org/stats?id=43087774) #29 66 points 17 comments -> [The Fall of FiveM](https://fivem.team/)<!-- HN:43087774:end --><!-- HN:43114622:start -->
* [43114622](https://news.social-protocols.org/stats?id=43114622) #10 7 points 1 comments -> [KiCad 9.0 Released](https://www.kicad.org/blog/2025/02/Version-9.0.0-Released/)<!-- HN:43114622:end --><!-- HN:43081491:start -->
* [43081491](https://news.social-protocols.org/stats?id=43081491) #14 14 points 0 comments -> [EnigmaEval: A Benchmark of Long Multimodal Reasoning Challenges](https://arxiv.org/abs/2502.08859)<!-- HN:43081491:end --><!-- HN:43114986:start -->
* [43114986](https://news.social-protocols.org/stats?id=43114986) #21 3 points 1 comments -> [Amazon Ends Support for Chime](https://aws.amazon.com/blogs/messaging-and-targeting/update-on-support-for-amazon-chime/)<!-- HN:43114986:end --><!-- HN:43114811:start -->
* [43114811](https://news.social-protocols.org/stats?id=43114811) #2 7 points 1 comments -> [A new experiment from Google to help people explore more career possibilities](https://blog.google/outreach-initiatives/grow-with-google/a-new-experiment-to-help-people-explore-more-career-possibilities/)<!-- HN:43114811:end --><!-- HN:43114235:start -->
* [43114235](https://news.social-protocols.org/stats?id=43114235) #7 28 points 40 comments -> [A password generator inspired by the Xkcd password spec](https://github.com/beala/xkcd-password)<!-- HN:43114235:end --><!-- HN:43110173:start -->
* [43110173](https://news.social-protocols.org/stats?id=43110173) #12 148 points 26 comments -> [Run structured extraction on documents/images locally with Ollama and Pydantic](https://github.com/vlm-run/vlmrun-hub)<!-- HN:43110173:end --><!-- HN:43089082:start -->
* [43089082](https://news.social-protocols.org/stats?id=43089082) #19 3 points 0 comments -> [Rewriting essential Linux packages in Rust](https://lwn.net/SubscriberLink/1007907/a9db87fc233bceae/)<!-- HN:43089082:end --><!-- HN:43115922:start -->
* [43115922](https://news.social-protocols.org/stats?id=43115922) #14 3 points 0 comments -> [Obsidian is now free for work](https://twitter.com/obsdmd/status/1892586092882276352)<!-- HN:43115922:end --><!-- HN:43115548:start -->
* [43115548](https://news.social-protocols.org/stats?id=43115548) #29 6 points 1 comments -> [AI cracks superbug problem in two days that took scientists years](https://www.bbc.co.uk/news/articles/clyz6e9edy3o)<!-- HN:43115548:end --><!-- HN:43116403:start -->
* [43116403](https://news.social-protocols.org/stats?id=43116403) #12 14 points 9 comments -> [Nezha 2 becomes highest-grossing animated film globally](https://www.reuters.com/lifestyle/chinese-film-nezha-2-becomes-highest-grossing-animated-film-globally-2025-02-18/)<!-- HN:43116403:end --><!-- HN:43118257:start -->
* [43118257](https://news.social-protocols.org/stats?id=43118257) #21 26 points 40 comments -> [A fiscal crisis is looming for many US cities](https://theconversation.com/a-fiscal-crisis-is-looming-for-many-us-cities-249436)<!-- HN:43118257:end --><!-- HN:43090222:start -->
* [43090222](https://news.social-protocols.org/stats?id=43090222) #20 30 points 16 comments -> [DotSlash: Simplified Executable Deployment](https://github.com/facebook/dotslash)<!-- HN:43090222:end --><!-- HN:43120107:start -->
* [43120107](https://news.social-protocols.org/stats?id=43120107) #28 33 points 15 comments -> [Elon Musk recommends that the International Space Station be deorbited ASAP](https://arstechnica.com/features/2025/02/elon-musk-recommends-that-the-international-space-station-be-deorbited-asap/)<!-- HN:43120107:end --><!-- HN:43118634:start -->
* [43118634](https://news.social-protocols.org/stats?id=43118634) #1 288 points 148 comments -> [OpenEuroLLM](https://openeurollm.eu/)<!-- HN:43118634:end --><!-- HN:43120404:start -->
* [43120404](https://news.social-protocols.org/stats?id=43120404) #20 31 points 3 comments -> [Amazon remembers it has an Android app store, kills it](https://arstechnica.com/gadgets/2025/02/amazon-remembers-it-has-an-android-app-store-kills-it/)<!-- HN:43120404:end -->
#### **Friday, February 21, 2025**
<!-- HN:43122341:start -->
* [43122341](https://news.social-protocols.org/stats?id=43122341) #3 17 points 5 comments -> [Blackmailing Grok](https://blog.hermesloom.org/p/blackmailing-grok)<!-- HN:43122341:end --><!-- HN:43123283:start -->
* [43123283](https://news.social-protocols.org/stats?id=43123283) #13 42 points 22 comments -> [Ax falls on elite group of PhDs training to lead U.S. public health labs](https://www.science.org/content/article/ax-falls-elite-group-ph-d-s-training-lead-u-s-public-health-labs)<!-- HN:43123283:end --><!-- HN:43077931:start -->
* [43077931](https://news.social-protocols.org/stats?id=43077931) #19 8 points 0 comments -> [Blockchain that runs Python smart contracts native. No Solidity, no VM overhead](https://xian.org/)<!-- HN:43077931:end --><!-- HN:43127334:start -->
* [43127334](https://news.social-protocols.org/stats?id=43127334) #19 11 points 0 comments -> [Conflicts of interest in climate change science](https://jessicaweinkle.substack.com/p/conflicts-of-interest-in-climate)<!-- HN:43127334:end --><!-- HN:43128650:start -->
* [43128650](https://news.social-protocols.org/stats?id=43128650) #16 10 points 1 comments -> [Railings Made from WWII Stretchers](https://en.wikipedia.org/wiki/Stretcher_railing)<!-- HN:43128650:end --><!-- HN:43129521:start -->
* [43129521](https://news.social-protocols.org/stats?id=43129521) #23 4 points 0 comments -> [Apple removing iCloud end-to-encryption after UK government compelled backdoors](https://9to5mac.com/2025/02/21/apple-removing-end-to-encryption-uk/)<!-- HN:43129521:end --><!-- HN:43129295:start -->
* [43129295](https://news.social-protocols.org/stats?id=43129295) #15 27 points 5 comments -> [Anger, despair, and defiance from a voice within the US federal research system](https://www.bmj.com/content/388/bmj.r294)<!-- HN:43129295:end --><!-- HN:43128870:start -->
* [43128870](https://news.social-protocols.org/stats?id=43128870) #4 194 points 3 comments -> [Apple Pulls Encrypted iCloud Security Feature in UK](https://www.macrumors.com/2025/02/21/apple-pulls-encrypted-icloud-security-feature-uk/)<!-- HN:43128870:end --><!-- HN:43130416:start -->
* [43130416](https://news.social-protocols.org/stats?id=43130416) #27 7 points 1 comments -> [Claims of college grade inflation and dumbing-down are overblown](https://greyenlightenment.com/2025/02/20/college-and-grade-inflation/)<!-- HN:43130416:end --><!-- HN:43129662:start -->
* [43129662](https://news.social-protocols.org/stats?id=43129662) #12 13 points 5 comments -> [CSS-zero: opinionated CSS starter kit for your "nobuild" application](https://github.com/lazaronixon/css-zero)<!-- HN:43129662:end --><!-- HN:43087561:start -->
* [43087561](https://news.social-protocols.org/stats?id=43087561) #26 5 points 1 comments -> [A Lightweight MDX CMS for Static Sites (No Git, No Complex Setup)](https://swapcone.com)<!-- HN:43087561:end --><!-- HN:43132656:start -->
* [43132656](https://news.social-protocols.org/stats?id=43132656) #22 4 points 2 comments -> [ERPs suck. Generative AI will fix them](https://getlumina.substack.com/p/erps-suck-generative-ai-will-fix)<!-- HN:43132656:end -->
#### **Saturday, February 22, 2025**
<!-- HN:43134544:start -->
* [43134544](https://news.social-protocols.org/stats?id=43134544) #24 4 points 0 comments -> [Why Parliamentary Systems Are Better for the Economy Than the Presidential Ones](https://www.internationalaffairs.org.au/australianoutlook/why-parliamentary-systems-are-better-for-the-economy-than-the-presidential-ones/)<!-- HN:43134544:end --><!-- HN:43134845:start -->
* [43134845](https://news.social-protocols.org/stats?id=43134845) #12 24 points 4 comments -> [Prominent DOGE staffer Edward Coristine is grandson of turncoat KGB spy](https://www.jacobsilverman.com/p/prominent-doge-staffer-is-grandson)<!-- HN:43134845:end --><!-- HN:43135333:start -->
* [43135333](https://news.social-protocols.org/stats?id=43135333) #25 27 points 35 comments -> [Who Wants to Work in a Factory?](https://arenamag.com/2025/02/11/who-wants-to-work-in-a-factory/)<!-- HN:43135333:end --><!-- HN:43136567:start -->
* [43136567](https://news.social-protocols.org/stats?id=43136567) #9 37 points 26 comments -> [Nobody Profits – George Hotz](https://geohot.github.io//blog/jekyll/update/2025/02/19/nobody-will-profit.html)<!-- HN:43136567:end --><!-- HN:43095337:start -->
* [43095337](https://news.social-protocols.org/stats?id=43095337) #24 -> [The Erasure of Islam from the Poetry of Rumi](https://www.newyorker.com/books/page-turner/the-erasure-of-islam-from-the-poetry-of-rumi)<!-- HN:43095337:end --><!-- HN:43089877:start -->
* [43089877](https://news.social-protocols.org/stats?id=43089877) #21 10 points 2 comments -> [Oh no, don't look – it's Developer Marketing (2024)](https://permit.substack.com/p/oh-no-dont-look-its-developer-marketing)<!-- HN:43089877:end --><!-- HN:43138522:start -->
* [43138522](https://news.social-protocols.org/stats?id=43138522) #15 21 points 2 comments -> [Doge says its savings total $55B, but analysis shows it's less](https://www.washingtonpost.com/business/2025/02/22/doge-savings-found-list-analysis/)<!-- HN:43138522:end --><!-- HN:43138950:start -->
* [43138950](https://news.social-protocols.org/stats?id=43138950) #1 25 points 2 comments -> [TikTok and X recommends pro-AfD content to non-partisan users ahead of election](https://jumpshare.com/s/tqzgE7gQ2Q81dTcnTSfF)<!-- HN:43138950:end --><!-- HN:43092007:start -->
* [43092007](https://news.social-protocols.org/stats?id=43092007) #9 6 points 0 comments -> [Nanotini – smallest pasta makes a good bandage](https://www.scientificamerican.com/article/the-worlds-smallest-pasta-is-not-very-tasty/)<!-- HN:43092007:end --><!-- HN:43139456:start -->
* [43139456](https://news.social-protocols.org/stats?id=43139456) #4 22 points 7 comments -> [Elon, Romania doesn't care about your tweets](https://dearelon.ro/)<!-- HN:43139456:end --><!-- HN:43140709:start -->
* [43140709](https://news.social-protocols.org/stats?id=43140709) #11 21 points 5 comments -> [Americans Are Heading for the Exits](https://newrepublic.com/article/191421/trump-emigration-wave-brain-drain)<!-- HN:43140709:end --><!-- HN:43141205:start -->
* [43141205](https://news.social-protocols.org/stats?id=43141205) #5 34 points 1 comments -> [Memo: 'Capture of U.S. Critical Infrastructure by Neoreactionaries'](https://www.thenerdreich.com/memo-capture-of-u-s-critical-infrastructure-by-neoreactionaries/)<!-- HN:43141205:end --><!-- HN:43141656:start -->
* [43141656](https://news.social-protocols.org/stats?id=43141656) #26 5 points 1 comments -> [Recording reveals new details on controversial DOGE employee Edward Coristine](https://www.cnn.com/2025/02/21/politics/doge-musk-edward-coristine-invs/index.html)<!-- HN:43141656:end --><!-- HN:43141392:start -->
* [43141392](https://news.social-protocols.org/stats?id=43141392) #7 42 points 2 comments -> [Warren Buffett sounds warning to Washington as Berkshire reports record profit](https://www.reuters.com/business/warren-buffett-says-us-should-spend-wisely-plans-increase-investment-japan-2025-02-22/)<!-- HN:43141392:end --><!-- HN:43141982:start -->
* [43141982](https://news.social-protocols.org/stats?id=43141982) #20 10 points 2 comments -> [The foundations of America's prosperity are being dismantled](https://www.technologyreview.com/2025/02/21/1112274/the-foundations-of-americas-prosperity-are-being-dismantled/)<!-- HN:43141982:end --><!-- HN:43142701:start -->
* [43142701](https://news.social-protocols.org/stats?id=43142701) #23 7 points 0 comments -> [Alarm as bird flu now 'endemic in cows'](https://www.theguardian.com/us-news/2025/feb/22/bird-flu-virus-trump)<!-- HN:43142701:end --><!-- HN:43142910:start -->
* [43142910](https://news.social-protocols.org/stats?id=43142910) #29 11 points 5 comments -> [Failure to respond will be taken as a resignation](https://twitter.com/elonmusk/status/1893386883444437415)<!-- HN:43142910:end --><!-- HN:43100435:start -->
* [43100435](https://news.social-protocols.org/stats?id=43100435) #17 3 points 0 comments -> [Allow me to explain this absurd thing on my head (made by 3D printer, not Apple)](https://twitter.com/waitbutwhy/status/1891989494875750600)<!-- HN:43100435:end --><!-- HN:43143637:start -->
* [43143637](https://news.social-protocols.org/stats?id=43143637) #17 22 points 1 comments -> [NIH funding freeze stalls applications on $1.5B in medical research funds](https://www.npr.org/sections/shots-health-news/2025/02/22/nx-s1-5305276/trump-nih-funding-freeze-medical-research)<!-- HN:43143637:end -->
#### **Sunday, February 23, 2025**
