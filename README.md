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

#### **Tuesday, July 21, 2026**
<!-- HN:48901918:start -->
* [48901918](https://news.social-protocols.org/stats?id=48901918) #21 16 points 3 comments -> [Rendering Fonts Quickly on the GPU](https://www.outercloud.dev/blogs/webgpu-font-rendering/)<!-- HN:48901918:end --><!-- HN:48986912:start -->
* [48986912](https://news.social-protocols.org/stats?id=48986912) #13 4 points 2 comments -> [Show HN: I made email signatures less boring](https://esigna.app)<!-- HN:48986912:end --><!-- HN:48987618:start -->
* [48987618](https://news.social-protocols.org/stats?id=48987618) #7 6 points 0 comments -> [Show HN: Turn casual photos into professional headshots with AI](https://portraify.app)<!-- HN:48987618:end --><!-- HN:48987958:start -->
* [48987958](https://news.social-protocols.org/stats?id=48987958) #19 3 points 0 comments -> [Bash for Browser Front End](https://alganet.github.io/terminal/?p=post:2026-07-21-00-Bash-for-Browser-Frontend&lang=en)<!-- HN:48987958:end --><!-- HN:48988265:start -->
* [48988265](https://news.social-protocols.org/stats?id=48988265) #20 25 points 18 comments -> [Reverse-engineering is cheap now](https://simonwillison.net/2026/Jul/20/cheap-reverse-engineering/)<!-- HN:48988265:end --><!-- HN:48988189:start -->
* [48988189](https://news.social-protocols.org/stats?id=48988189) #15 12 points 9 comments -> [Zoom is now Chrome only](https://zoom.us/test)<!-- HN:48988189:end --><!-- HN:48937703:start -->
* [48937703](https://news.social-protocols.org/stats?id=48937703) #23 11 points 4 comments -> [Flight Planning with Little Navmap](https://tech.marksblogg.com/little-navmap-flight-planning.html)<!-- HN:48937703:end --><!-- HN:48968474:start -->
* [48968474](https://news.social-protocols.org/stats?id=48968474) #12 17 points 40 comments -> [Postmortem of a British Startup: Tract](https://buildwithtract.com/)<!-- HN:48968474:end --><!-- HN:48992028:start -->
* [48992028](https://news.social-protocols.org/stats?id=48992028) #6 4 points 1 comments -> [Garzed – my garden waters itself off soil-moisture sensors](https://garzed.com)<!-- HN:48992028:end --><!-- HN:48992039:start -->
* [48992039](https://news.social-protocols.org/stats?id=48992039) #27 19 points 3 comments -> [Mullvad and Daniel Berntsson's Failed Cleanup](https://markwrites.io/mullvad-and-daniel-berntssons-failed-cleanup/)<!-- HN:48992039:end --><!-- HN:48992960:start -->
* [48992960](https://news.social-protocols.org/stats?id=48992960) #12 20 points 11 comments -> [Sarah's Wager](https://colossus.com/article/sarah-guo-conviction/)<!-- HN:48992960:end --><!-- HN:48993448:start -->
* [48993448](https://news.social-protocols.org/stats?id=48993448) #9 174 points 86 comments -> [ICE to Pay Thomson Reuters $125M to Find Voter Fraud](https://www.404media.co/ice-to-pay-thomson-reuters-125-million-to-find-voter-fraud/)<!-- HN:48993448:end --><!-- HN:48994103:start -->
* [48994103](https://news.social-protocols.org/stats?id=48994103) #20 29 points 41 comments -> [Amid nurse shortage, a university rolls out the welcome mat for men](https://text.npr.org/nx-s1-5869813)<!-- HN:48994103:end --><!-- HN:48995333:start -->
* [48995333](https://news.social-protocols.org/stats?id=48995333) #25 11 points 3 comments -> [Show HN: I built a command palette for the terminal – 6.2MB, pure Go, no fzf](https://github.com/matheuzgomes/decoreba)<!-- HN:48995333:end --><!-- HN:48995946:start -->
* [48995946](https://news.social-protocols.org/stats?id=48995946) #30 24 points 10 comments -> [How did the H1B visa become the 'Indian' visa](https://numberstation.fm/the-body-shop/)<!-- HN:48995946:end -->
#### **Wednesday, July 22, 2026**
<!-- HN:48999376:start -->
* [48999376](https://news.social-protocols.org/stats?id=48999376) #9 27 points 4 comments -> [An Engineer's Guide to USB Type-C [pdf]](https://www.ti.com/lit/eb/slyy228/slyy228.pdf)<!-- HN:48999376:end --><!-- HN:49002010:start -->
* [49002010](https://news.social-protocols.org/stats?id=49002010) #19 6 points 2 comments -> [Airglow browser lets users modify YouTube, Gmail and Spotify in real time](https://runtimewire.com/article/airglow-browser-lets-users-modify-youtube-gmail-and-spotify-in-real-time)<!-- HN:49002010:end --><!-- HN:49001775:start -->
* [49001775](https://news.social-protocols.org/stats?id=49001775) #19 17 points 3 comments -> [Ten ways a check passes while the thing it checks is broken](https://phronesis.world/papers/ways-of-checking/)<!-- HN:49001775:end --><!-- HN:49001930:start -->
* [49001930](https://news.social-protocols.org/stats?id=49001930) #3 61 points 6 comments -> [Kimi K3: second only to Fable 5 on AA-Briefcase](https://artificialanalysis.ai/articles/kimi-k3-agentic-knowledge-benchmark)<!-- HN:49001930:end --><!-- HN:49001708:start -->
* [49001708](https://news.social-protocols.org/stats?id=49001708) #29 18 points 40 comments -> [Tesla Balance Bike](https://shop.tesla.com/product/balance-bike-for-kids)<!-- HN:49001708:end --><!-- HN:49003465:start -->
* [49003465](https://news.social-protocols.org/stats?id=49003465) #13 38 points 40 comments -> [Codeberg: ToU extension to prohibit LLM-extrusions](https://codeberg.org/Codeberg/org/pulls/1253)<!-- HN:49003465:end --><!-- HN:49004914:start -->
* [49004914](https://news.social-protocols.org/stats?id=49004914) #13 5 points 0 comments -> [OpenAI Hacks Hugging Face, What Happened, Alignment and Paper Clips](https://stratechery.com/2026/openai-hacks-hugging-face-what-happened-alignment-and-paper-clips/)<!-- HN:49004914:end --><!-- HN:49005398:start -->
* [49005398](https://news.social-protocols.org/stats?id=49005398) #30 69 points 80 comments -> [OpenAI says its AI went rogue and launched 'unprecedented' cyber-attack](https://www.bbc.com/news/articles/c3ek3gvdnj3o)<!-- HN:49005398:end --><!-- HN:49008217:start -->
* [49008217](https://news.social-protocols.org/stats?id=49008217) #10 10 points 2 comments -> [I Am Buiding BorgIOS to de-shitify the Internet](https://github.com/bitmonky/BorgIOS)<!-- HN:49008217:end --><!-- HN:49007487:start -->
* [49007487](https://news.social-protocols.org/stats?id=49007487) #28 44 points 26 comments -> [How to Read a Painting](https://sheets.works/data-viz/how-to-read-a-painting/)<!-- HN:49007487:end --><!-- HN:48933232:start -->
* [48933232](https://news.social-protocols.org/stats?id=48933232) #11 36 points 7 comments -> [Drake Anthony Recreates the Mechanical Bulb First Seen in 1675 – TechEBlog](https://www.techeblog.com/drake-anthony-styropyro-mechanical-bulb-barometric-light/)<!-- HN:48933232:end -->
#### **Thursday, July 23, 2026**
<!-- HN:49015999:start -->
* [49015999](https://news.social-protocols.org/stats?id=49015999) #13 3 points 4 comments -> [Google illegally retains customer data](https://discuss.ai.google.dev/t/google-illegally-retains-customer-data-and-i-am-taking-legal-action-against-them/175294)<!-- HN:49015999:end --><!-- HN:49017170:start -->
* [49017170](https://news.social-protocols.org/stats?id=49017170) #24 4 points 1 comments -> [Local AI that finds sensitive files on your Mac before attackers do](https://www.vaultsort.com/guardian)<!-- HN:49017170:end --><!-- HN:48977463:start -->
* [48977463](https://news.social-protocols.org/stats?id=48977463) #26 45 points 40 comments -> [Why malloc always does more than I asked for?](https://ssenthilnathan3.github.io/blog/malloc/)<!-- HN:48977463:end --><!-- HN:49022644:start -->
* [49022644](https://news.social-protocols.org/stats?id=49022644) #20 16 points 1 comments -> [Vulkan Tutorial](https://vulkan-tutorial.com/)<!-- HN:49022644:end --><!-- HN:49022838:start -->
* [49022838](https://news.social-protocols.org/stats?id=49022838) #9 29 points 40 comments -> [Cross-entropy comparison of LLM responses reveals Kimi's similarity to Claude](https://typebulb.com/u/lab/you-re-relatively-right/full)<!-- HN:49022838:end --><!-- HN:49024993:start -->
* [49024993](https://news.social-protocols.org/stats?id=49024993) #21 4 points 4 comments -> [Launching Health in ChatGPT](https://openai.com/index/health-in-chatgpt/)<!-- HN:49024993:end --><!-- HN:49027426:start -->
* [49027426](https://news.social-protocols.org/stats?id=49027426) #21 18 points 7 comments -> [Big Tech Isn't Hiding $1.65T of Debt](https://finterm.ai/blog/big-tech-hidden-debt-fact-check.html)<!-- HN:49027426:end -->
#### **Friday, July 24, 2026**
<!-- HN:48951500:start -->
* [48951500](https://news.social-protocols.org/stats?id=48951500) #10 99 points 32 comments -> [A24 Is Copyright Striking Backrooms Artwork Older Than the Movie](https://www.thegamer.com/the-backrooms-a24-copyright-strike-artwork/)<!-- HN:48951500:end --><!-- HN:48952392:start -->
* [48952392](https://news.social-protocols.org/stats?id=48952392) #14 36 points 6 comments -> [Interview with Matheus Moreira about Lone Lisp and Linux Kernel](https://alexalejandre.com/interviews/interview-with-matheus-moreira/)<!-- HN:48952392:end --><!-- HN:49031330:start -->
* [49031330](https://news.social-protocols.org/stats?id=49031330) #3 8 points 0 comments -> [Zuckerberg Emojis](https://rybakov.com/blog/zuckerberg_emojis/)<!-- HN:49031330:end --><!-- HN:49027985:start -->
* [49027985](https://news.social-protocols.org/stats?id=49027985) #30 54 points 18 comments -> [Stripe in talks to buy OpenRouter for ~10B](https://www.wsj.com/tech/ai/stripe-in-talks-to-buy-buzzy-ai-model-marketplace-openrouter-decc6a74)<!-- HN:49027985:end --><!-- HN:49033173:start -->
* [49033173](https://news.social-protocols.org/stats?id=49033173) #7 6 points 2 comments -> [Show HN: A static, client-side tarot calculator for Brazilian Portuguese](https://meuarcanopessoal.net/)<!-- HN:49033173:end --><!-- HN:49033975:start -->
* [49033975](https://news.social-protocols.org/stats?id=49033975) #7 3 points 1 comments -> [My football predictor scores 0.203 vs. the bookies' 0.198 – and loses](https://kickoffreport.com/how-our-prediction-model-works/)<!-- HN:49033975:end --><!-- HN:49034344:start -->
* [49034344](https://news.social-protocols.org/stats?id=49034344) #6 9 points 0 comments -> [Indian police cracked down on 'cockroach' protesters. They made memes about it](https://www.bbc.com/news/articles/c3ek3l9gp7go)<!-- HN:49034344:end --><!-- HN:49034838:start -->
* [49034838](https://news.social-protocols.org/stats?id=49034838) #5 10 points 0 comments -> [LLMs Are Still Toxic, Stuck in the Past, and Bad at Math](https://www.eyosias.dev/blog/llms-are-still-toxic-and-bad-at-math)<!-- HN:49034838:end --><!-- HN:49033363:start -->
* [49033363](https://news.social-protocols.org/stats?id=49033363) #19 27 points 40 comments -> [Launching Health in ChatGPT to US Users](https://openai.com/index/health-in-chatgpt/)<!-- HN:49033363:end --><!-- HN:49037127:start -->
* [49037127](https://news.social-protocols.org/stats?id=49037127) #3 13 points 0 comments -> [You need to let the AI cook](https://www.ivan.codes/blog/let-it-cook)<!-- HN:49037127:end --><!-- HN:49037076:start -->
* [49037076](https://news.social-protocols.org/stats?id=49037076) #14 13 points 0 comments -> [Marc Andreessen, venture capitalist, married to wait, what?](https://tyrandus.dev/2026/07/23/marc-andreessen-venture-capitalist-married-to-wait-what/)<!-- HN:49037076:end --><!-- HN:49038260:start -->
* [49038260](https://news.social-protocols.org/stats?id=49038260) #20 3 points 1 comments -> [Must have tool for agentic workspace and Mac users](https://github.com/rohankc69/clickit)<!-- HN:49038260:end --><!-- HN:49038393:start -->
* [49038393](https://news.social-protocols.org/stats?id=49038393) #17 72 points 8 comments -> [Claude Opus 5](https://www.anthropic.com/news/claude-opus-5)<!-- HN:49038393:end -->
#### **Saturday, July 25, 2026**<!-- HN:49008624:start -->
* [49008624](https://news.social-protocols.org/stats?id=49008624) #15 -> [Six questions before you add an LLM](https://cameronmpalmer.medium.com/should-you-even-use-an-llm-b4f3b7914f4d)<!-- HN:49008624:end --><!-- HN:49047198:start -->
* [49047198](https://news.social-protocols.org/stats?id=49047198) #13 43 points 28 comments -> [League of Legends designer shares game design field manual](https://areadenial.games/design/preface#00-01)<!-- HN:49047198:end --><!-- HN:49049241:start -->
* [49049241](https://news.social-protocols.org/stats?id=49049241) #29 16 points 14 comments -> [Apple Is the King of AI and Nobody Knows It](https://limitededitionjonathan.substack.com/p/apple-is-the-king-of-ai-and-nobody)<!-- HN:49049241:end --><!-- HN:48984984:start -->
* [48984984](https://news.social-protocols.org/stats?id=48984984) #26 4 points 1 comments -> [D-FINE-seg – detection, instance and semantic segmentation in one model](https://github.com/ArgoHA/D-FINE-seg)<!-- HN:48984984:end --><!-- HN:49050412:start -->
* [49050412](https://news.social-protocols.org/stats?id=49050412) #11 7 points 7 comments -> [The Hitler Salute Was Never German](https://warcommons.com/2026/07/25/hitler-salute-origin-history-roman-salute-mussolini/)<!-- HN:49050412:end --><!-- HN:49005722:start -->
* [49005722](https://news.social-protocols.org/stats?id=49005722) #25 6 points 0 comments -> [Pkgxray – inspect what gets installed, not what executes](https://github.com/adamsjack711-ux/pkgxray)<!-- HN:49005722:end --><!-- HN:49052406:start -->
* [49052406](https://news.social-protocols.org/stats?id=49052406) #9 11 points 1 comments -> [We Need a National Ballroom](https://weneedaballroom.com/)<!-- HN:49052406:end --><!-- HN:49052625:start -->
* [49052625](https://news.social-protocols.org/stats?id=49052625) #14 11 points 0 comments -> [As Supreme Court decisions grow sharper, study examines justices’ concessions](https://www.umass.edu/news/article/supreme-court-decisions-grow-sharper-study-examines-justices-calculated-concessions)<!-- HN:49052625:end -->
#### **Sunday, July 26, 2026**<!-- HN:49054108:start -->
* [49054108](https://news.social-protocols.org/stats?id=49054108) #30 5 points 0 comments -> [Google ignored my site for 13 weeks, so I audited everyone who outranks me](https://getqrcodepro.com/blog/google-ranking-evidence)<!-- HN:49054108:end --><!-- HN:48976262:start -->
* [48976262](https://news.social-protocols.org/stats?id=48976262) #5 648 points 158 comments -> [Stolen Buttons](https://anatolyzenkov.com/stolen-buttons)<!-- HN:48976262:end --><!-- HN:48989304:start -->
* [48989304](https://news.social-protocols.org/stats?id=48989304) #15 15 points 3 comments -> [What if they are all wrong? (2020)](https://igorpak.wordpress.com/2020/12/10/what-if-they-are-all-wrong/)<!-- HN:48989304:end --><!-- HN:48991984:start -->
* [48991984](https://news.social-protocols.org/stats?id=48991984) #22 125 points 88 comments -> [GDID Windows – Cut the tracker that follows you even under VPN](https://korben.info/en/gdid-windows-cut-tracker-vpn.html)<!-- HN:48991984:end --><!-- HN:49055339:start -->
* [49055339](https://news.social-protocols.org/stats?id=49055339) #5 7 points 4 comments -> [Vision 50 Years Phone – Keeping old Android phones fast without root](https://github.com/50YearsPhone/vision-50-years-phone)<!-- HN:49055339:end --><!-- HN:49056689:start -->
* [49056689](https://news.social-protocols.org/stats?id=49056689) #10 9 points 0 comments -> [Claude Code Deletes Your Context History from Your Device After 30 Days](https://code.claude.com/docs/en/data-usage)<!-- HN:49056689:end --><!-- HN:49059587:start -->
* [49059587](https://news.social-protocols.org/stats?id=49059587) #16 34 points 7 comments -> [This July I Was Fired from Simple AI (A Deeply YC Company)](https://andys.blog/this-july-i-was-fired-from-simple-ai/)<!-- HN:49059587:end --><!-- HN:49060205:start -->
* [49060205](https://news.social-protocols.org/stats?id=49060205) #3 42 points 8 comments -> [Lidl Introduces the European Payment Method Wero in Germany](https://unternehmen.lidl.de/pressreleases/260724_lidl_pi_einfuehrung_wero)<!-- HN:49060205:end --><!-- HN:49060279:start -->
* [49060279](https://news.social-protocols.org/stats?id=49060279) #24 15 points 3 comments -> [Show HN: Boffin – Staff-engineer layer for AI coding agents](https://github.com/MicSm/boffin)<!-- HN:49060279:end --><!-- HN:49060802:start -->
* [49060802](https://news.social-protocols.org/stats?id=49060802) #11 10 points 3 comments -> [Google Cache used to have a copy of this page at](https://www.hornet.org/wikipedia-notes.txt)<!-- HN:49060802:end --><!-- HN:49060998:start -->
* [49060998](https://news.social-protocols.org/stats?id=49060998) #20 15 points 3 comments -> [Show HN: The Occult Gatsby](https://occultgatsby.work)<!-- HN:49060998:end --><!-- HN:49061652:start -->
* [49061652](https://news.social-protocols.org/stats?id=49061652) #5 8 points 1 comments -> [Show HN: Free Bible study that explains every chapter you read](https://learnofchrist.com)<!-- HN:49061652:end --><!-- HN:49061620:start -->
* [49061620](https://news.social-protocols.org/stats?id=49061620) #3 16 points 8 comments -> [Kimi K3 is not cheap](https://www.alexinch.com/blog/kimi-k3)<!-- HN:49061620:end --><!-- HN:49061015:start -->
* [49061015](https://news.social-protocols.org/stats?id=49061015) #23 16 points 15 comments -> [Show HN: HART OS – an open-source AI OS built so frontier AI needs no datacenter](https://github.com/hertz-ai/HARTOS)<!-- HN:49061015:end -->
#### **Monday, July 27, 2026**
<!-- HN:49063454:start -->
* [49063454](https://news.social-protocols.org/stats?id=49063454) #1 39 points 14 comments -> [Show HN: Distill and serve small models with frontier quality for half the cost](https://github.com/experientiallabs/world-model-optimizer)<!-- HN:49063454:end --><!-- HN:49063186:start -->
* [49063186](https://news.social-protocols.org/stats?id=49063186) #13 15 points 19 comments -> [Cursor Bridge – Run Unlimited Claude Code on Your Cursor Subscription](https://github.com/hkc5/cursor-bridge)<!-- HN:49063186:end --><!-- HN:49063789:start -->
* [49063789](https://news.social-protocols.org/stats?id=49063789) #4 30 points 41 comments -> [I Championed Prediction Markets. Look What They've Become](https://newsletter.platypuseconomics.com/p/i-championed-prediction-markets-look)<!-- HN:49063789:end --><!-- HN:49016772:start -->
* [49016772](https://news.social-protocols.org/stats?id=49016772) #12 4 points 0 comments -> [Mirror-Mirror: Mirror your PC screen to your phone over your local network](https://github.com/maco30001/Mirror-Mirror)<!-- HN:49016772:end --><!-- HN:49064588:start -->
* [49064588](https://news.social-protocols.org/stats?id=49064588) #26 23 points 41 comments -> [The old-school way of keeping the summer heat out of your home](https://monocle.com/design/architecture/keeping-your-home-cool-without-air-conditioning/)<!-- HN:49064588:end --><!-- HN:49067076:start -->
* [49067076](https://news.social-protocols.org/stats?id=49067076) #11 5 points 4 comments -> [Show HN: NameThatUI – A quiz game to test your UI design knowledge](https://namethatui.org/)<!-- HN:49067076:end --><!-- HN:49013671:start -->
* [49013671](https://news.social-protocols.org/stats?id=49013671) #22 14 points 4 comments -> [Boox Go 10.3 (gen II) Lumi: First impressions](https://manualdousuario.net/en/boox-go-10-3-lumi-first-impressions/)<!-- HN:49013671:end --><!-- HN:49068573:start -->
* [49068573](https://news.social-protocols.org/stats?id=49068573) #29 4 points 2 comments -> [Tanker hits mine in the Strait of Hormuz as Iran intercepts six vessels](https://nypost.com/2026/07/26/world-news/tanker-hits-mine-in-the-strait-of-hormuz-as-iran-intercepts-six-vessels/)<!-- HN:49068573:end --><!-- HN:49058384:start -->
* [49058384](https://news.social-protocols.org/stats?id=49058384) #10 10 points 1 comments -> [3D-printed F-14 Tomcat uses FPGA recreation of the first microprocessor](https://www.tomshardware.com/pc-components/cpus/3d-printed-f-14-tomcat-uses-an-fpga-recreation-of-the-worlds-first-microprocessor-cadcs-mp944-chip-controls-the-fighters-swing-wing-system-among-other-things)<!-- HN:49058384:end --><!-- HN:49071441:start -->
* [49071441](https://news.social-protocols.org/stats?id=49071441) #6 21 points 13 comments -> [All major LLMs are lib-left. Even Grok, half the time](https://unslop.run/blog/political-compass-of-llms)<!-- HN:49071441:end -->