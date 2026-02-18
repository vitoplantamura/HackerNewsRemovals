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

#### **Thursday, February 12, 2026**
<!-- HN:46982762:start -->
* [46982762](https://news.social-protocols.org/stats?id=46982762) #22 14 points 1 comments -> [Rare, dangerous side effects of some Covid-19 vaccines explained](https://www.science.org/content/article/rare-dangerous-side-effects-some-covid-19-vaccines-explained)<!-- HN:46982762:end --><!-- HN:46984799:start -->
* [46984799](https://news.social-protocols.org/stats?id=46984799) #14 17 points 10 comments -> [GLM-5 was trained entirely on Huawei chips](https://glm5.net/)<!-- HN:46984799:end --><!-- HN:46976443:start -->
* [46976443](https://news.social-protocols.org/stats?id=46976443) #13 365 points 170 comments -> [Why Vampires Live Forever](https://machielreyneke.com/blog/vampires-longevity/)<!-- HN:46976443:end --><!-- HN:46986064:start -->
* [46986064](https://news.social-protocols.org/stats?id=46986064) #18 9 points 4 comments -> [Show HN: Huesnatch – 6 free color tools for designers, no login, no uploads](https://github.com/huesnatch/huesnatch)<!-- HN:46986064:end --><!-- HN:46987524:start -->
* [46987524](https://news.social-protocols.org/stats?id=46987524) #4 39 points 4 comments -> [Resist and Unsubscribe](https://www.resistandunsubscribe.com)<!-- HN:46987524:end --><!-- HN:46934901:start -->
* [46934901](https://news.social-protocols.org/stats?id=46934901) #19 4 points 0 comments -> [Put Your Reputation on the Deadline (2023)](https://taylor.town/reputation-deadline)<!-- HN:46934901:end --><!-- HN:46988035:start -->
* [46988035](https://news.social-protocols.org/stats?id=46988035) #7 3 points 4 comments -> [Did HN just censor the Resist and Unsubscribe story?](https://www.resistandunsubscribe.com)<!-- HN:46988035:end --><!-- HN:46940959:start -->
* [46940959](https://news.social-protocols.org/stats?id=46940959) #17 9 points 1 comments -> [Quitting](https://thepointmag.com/examined-life/quitting/)<!-- HN:46940959:end --><!-- HN:46986614:start -->
* [46986614](https://news.social-protocols.org/stats?id=46986614) #21 22 points 40 comments -> [Show HN: A free online British accent generator for instant voice conversion](https://audioconvert.ai/british-accent-generator)<!-- HN:46986614:end --><!-- HN:46988928:start -->
* [46988928](https://news.social-protocols.org/stats?id=46988928) #29 33 points 8 comments -> [I Regret to Inform You That the FDA Is FDAing Again](https://marginalrevolution.com/marginalrevolution/2026/02/i-regret-to-inform-you-that-the-fda-is-still-fdaing.html)<!-- HN:46988928:end --><!-- HN:46989379:start -->
* [46989379](https://news.social-protocols.org/stats?id=46989379) #12 37 points 23 comments -> [Kim Jong Un chooses teen daughter as heir](https://www.bbc.com/news/articles/cn0e1g7kwglo)<!-- HN:46989379:end --><!-- HN:46990839:start -->
* [46990839](https://news.social-protocols.org/stats?id=46990839) #10 10 points 9 comments -> [AI agents can now create their own bank accounts](https://clawbot.cash/)<!-- HN:46990839:end --><!-- HN:46993829:start -->
* [46993829](https://news.social-protocols.org/stats?id=46993829) #9 -> [Googlers Demand Worker Safety and ICE Contract Transparency](https://www.googlers-against-ice.com)<!-- HN:46993829:end --><!-- HN:46994455:start -->
* [46994455](https://news.social-protocols.org/stats?id=46994455) #30 7 points 1 comments -> [Sex Workers Are Built Different (Graph Dump)](https://aella.substack.com/p/sex-workers-are-built-different-graph)<!-- HN:46994455:end -->
#### **Friday, February 13, 2026**
<!-- HN:46928105:start -->
* [46928105](https://news.social-protocols.org/stats?id=46928105) #25 15 points 1 comments -> [Barn Owls Know When to Wait](https://blog.typeobject.com/posts/2026-barn-owls-know-when-to-wait/)<!-- HN:46928105:end --><!-- HN:46998803:start -->
* [46998803](https://news.social-protocols.org/stats?id=46998803) #8 8 points 0 comments -> [ICE Masks Up in More Ways Than One](https://www.kenklippenstein.com/p/exclusive-ice-masks-up-in-more-ways)<!-- HN:46998803:end --><!-- HN:46998606:start -->
* [46998606](https://news.social-protocols.org/stats?id=46998606) #20 29 points 40 comments -> [The Wonder of Modern Drywall](https://worksinprogress.co/issue/the-wonder-of-modern-drywall/)<!-- HN:46998606:end --><!-- HN:47001037:start -->
* [47001037](https://news.social-protocols.org/stats?id=47001037) #6 4 points 6 comments -> [Bullet Garden – a Vampire Survivors-like game in a single 85KB HTML file](https://www.myvibe.so/nategu/sound-garden)<!-- HN:47001037:end --><!-- HN:47001683:start -->
* [47001683](https://news.social-protocols.org/stats?id=47001683) #11 17 points 3 comments -> [Israel used weapons in Gaza that made Palestinians evaporate](https://www.aljazeera.com/features/2026/2/10/israel-used-weapons-in-gaza-that-made-thousands-of-palestinians-evaporate)<!-- HN:47001683:end --><!-- HN:47001865:start -->
* [47001865](https://news.social-protocols.org/stats?id=47001865) #30 79 points 52 comments -> [US repeals EPA endangerment finding for greenhouse gases](https://www.cnn.com/2026/02/12/climate/trump-repeals-epa-endangerment-finding)<!-- HN:47001865:end --><!-- HN:47003036:start -->
* [47003036](https://news.social-protocols.org/stats?id=47003036) #10 4 points 1 comments -> [Kodak Charmera Review, Tiny Toy Camera That Makes Garbage Photos Feel Like Gold](https://kirkstechtips.com/kodak-charmera-review-the-30-tiny-toy-camera-that-makes-garbage-photos-feel-like-gold/)<!-- HN:47003036:end -->
#### **Saturday, February 14, 2026**
<!-- HN:47009630:start -->
* [47009630](https://news.social-protocols.org/stats?id=47009630) #3 8 points 1 comments -> [Why Stripe paid $1B for Metronome instead of fixing Billing](https://getlago.com/blog/why-stripe-paid-1b-for-metronome-instead-of-fixing-billing)<!-- HN:47009630:end --><!-- HN:47009416:start -->
* [47009416](https://news.social-protocols.org/stats?id=47009416) #1 111 points 2 comments -> [The evolution of OpenAI's mission statement](https://simonwillison.net/2026/Feb/13/openai-mission-statement/)<!-- HN:47009416:end --><!-- HN:46963672:start -->
* [46963672](https://news.social-protocols.org/stats?id=46963672) #19 6 points 3 comments -> [Marginal Revolution](https://sebastiangaliani.substack.com/p/marginal-revolution)<!-- HN:46963672:end --><!-- HN:47014704:start -->
* [47014704](https://news.social-protocols.org/stats?id=47014704) #4 28 points 14 comments -> [Golf game built last night with Claude Code, Svelte and ThreeJS](https://www.the-golf-is-golfing.com)<!-- HN:47014704:end --><!-- HN:47016050:start -->
* [47016050](https://news.social-protocols.org/stats?id=47016050) #21 33 points 41 comments -> [Stoat removes all LLM-generated code following user criticism](https://github.com/orgs/stoatchat/discussions/1022)<!-- HN:47016050:end -->
#### **Sunday, February 15, 2026**
<!-- HN:46952510:start -->
* [46952510](https://news.social-protocols.org/stats?id=46952510) #13 5 points 6 comments -> [Git with WD-40 Applied](https://github.com/Libre-WD-40/git)<!-- HN:46952510:end --><!-- HN:47021322:start -->
* [47021322](https://news.social-protocols.org/stats?id=47021322) #5 4 points 2 comments -> [I gave my AI drugs](https://github.com/nich2533/just_say_no)<!-- HN:47021322:end --><!-- HN:47021705:start -->
* [47021705](https://news.social-protocols.org/stats?id=47021705) #4 3 points 0 comments -> [Show HN: DocSync – Git hooks that block commits with stale documentation](https://github.com/suhteevah/docsync)<!-- HN:47021705:end --><!-- HN:47023333:start -->
* [47023333](https://news.social-protocols.org/stats?id=47023333) #28 16 points 9 comments -> [Show HN: Perlin Noise Terminal Animation in Rust (60 FPS, Truecolor)](https://github.com/denisepattenson/perlin-terminal)<!-- HN:47023333:end --><!-- HN:47027044:start -->
* [47027044](https://news.social-protocols.org/stats?id=47027044) #4 19 points 0 comments -> [With Apple: Fortify your app: Essential strategies to strengthen security](https://developer.apple.com/events/view/TUHA23T82K/dashboard)<!-- HN:47027044:end -->
#### **Monday, February 16, 2026**
<!-- HN:46969642:start -->
* [46969642](https://news.social-protocols.org/stats?id=46969642) #29 18 points 7 comments -> [I'm Always in the Club](https://www.lrb.co.uk/the-paper/v48/n02/christian-lorentzen/i-m-always-in-the-club)<!-- HN:46969642:end --><!-- HN:46986604:start -->
* [46986604](https://news.social-protocols.org/stats?id=46986604) #25 17 points 4 comments -> [Show HN: Solving Sudoku reasoning via Energy Geometric models](https://www.davisgeometric.com/index.html)<!-- HN:46986604:end --><!-- HN:47036116:start -->
* [47036116](https://news.social-protocols.org/stats?id=47036116) #23 25 points 40 comments -> [Intermittent fasting may make little difference to weight loss, review finds](https://www.bbc.co.uk/news/articles/c4ge7n3pq62o)<!-- HN:47036116:end --><!-- HN:47037666:start -->
* [47037666](https://news.social-protocols.org/stats?id=47037666) #26 25 points 7 comments -> [Palantir CEO wants to spray "fentanyl-laced urine" on analysts](https://twitter.com/jawwwn_/status/2023207418922959234)<!-- HN:47037666:end --><!-- HN:47039073:start -->
* [47039073](https://news.social-protocols.org/stats?id=47039073) #23 16 points 6 comments -> [Docker Swarm vs. Kubernetes in 2026](https://thedecipherist.com/articles/docker_swarm_vs_kubernetes/)<!-- HN:47039073:end -->
#### **Tuesday, February 17, 2026**
<!-- HN:46977901:start -->
* [46977901](https://news.social-protocols.org/stats?id=46977901) #14 32 points 2 comments -> [Camera that captures photos to cassette tape](https://hackaday.io/project/205004-digital-analog-tape-picture-camera)<!-- HN:46977901:end --><!-- HN:46996852:start -->
* [46996852](https://news.social-protocols.org/stats?id=46996852) #30 21 points 26 comments -> [Nvidia with unusually fast coding model on plate-sized chips](https://arstechnica.com/ai/2026/02/openai-sidesteps-nvidia-with-unusually-fast-coding-model-on-plate-sized-chips/)<!-- HN:46996852:end --><!-- HN:47041841:start -->
* [47041841](https://news.social-protocols.org/stats?id=47041841) #27 9 points 3 comments -> [Show HN: Journey – A Custom 2D ECS Game Engine Written in Rust and WGPU](https://ujjwalvivek.com/blog/proj_0004_rust_game_engine.md)<!-- HN:47041841:end --><!-- HN:47043435:start -->
* [47043435](https://news.social-protocols.org/stats?id=47043435) #30 7 points 4 comments -> [Performative virtue-signaling has become a threat to higher ed](https://thehill.com/opinion/education/5446702-performative-virtue-signaling-has-become-a-threat-to-higher-ed/)<!-- HN:47043435:end --><!-- HN:47045124:start -->
* [47045124](https://news.social-protocols.org/stats?id=47045124) #4 9 points 3 comments -> [Slopware AI: Ship Garbage Even Faster](https://slopware.ai/)<!-- HN:47045124:end --><!-- HN:47046560:start -->
* [47046560](https://news.social-protocols.org/stats?id=47046560) #16 8 points 0 comments -> [How the Kakistocracy Became a Quackistocracy](https://paulkrugman.substack.com/p/how-the-kakistocracy-became-a-quackistocracy)<!-- HN:47046560:end --><!-- HN:47046973:start -->
* [47046973](https://news.social-protocols.org/stats?id=47046973) #14 5 points 0 comments -> [We just made a $200M AI movie in just one day. Yes, this is 100% AI](https://twitter.com/thedorbrothers/status/2023460644905742577)<!-- HN:47046973:end --><!-- HN:47047932:start -->
* [47047932](https://news.social-protocols.org/stats?id=47047932) #16 14 points 6 comments -> [The mathematical mystery inside the legendary '90s shooter Quake 3](https://www.scientificamerican.com/article/the-mathematical-mystery-inside-the-legendary-90s-shooter-quake-3/)<!-- HN:47047932:end --><!-- HN:47050447:start -->
* [47050447](https://news.social-protocols.org/stats?id=47050447) #2 65 points 13 comments -> [Claude Sonnet 4.6](https://www.anthropic.com/news/claude-sonnet-4-6)<!-- HN:47050447:end --><!-- HN:47023255:start -->
* [47023255](https://news.social-protocols.org/stats?id=47023255) #27 12 points 0 comments -> [Show HN: Clawntown – An Evolving Crustacean Island](https://clawntown.lol)<!-- HN:47023255:end -->
#### **Wednesday, February 18, 2026**
<!-- HN:47052674:start -->
* [47052674](https://news.social-protocols.org/stats?id=47052674) #24 50 points 40 comments -> [Show HN: I'm launching a LPFM radio station](https://www.kpbj.fm/)<!-- HN:47052674:end --><!-- HN:47055467:start -->
* [47055467](https://news.social-protocols.org/stats?id=47055467) #16 33 points 9 comments -> [Tesla Robotaxis Reportedly Crashing at a Rate That's 4x Higher Than Humans](https://gizmodo.com/tesla-robotaxis-reportedly-crashing-at-a-rate-thats-4x-higher-than-humans-2000722989)<!-- HN:47055467:end --><!-- HN:47059652:start -->
* [47059652](https://news.social-protocols.org/stats?id=47059652) #3 13 points 3 comments -> [Stop prompting. Let the AI interview you to build specs](https://www.ideaforge.chat/)<!-- HN:47059652:end -->