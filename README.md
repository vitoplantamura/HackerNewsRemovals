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

#### **Tuesday, September 9, 2025**
<!-- HN:45173933:start -->
* [45173933](https://news.social-protocols.org/stats?id=45173933) #21 63 points 14 comments -> [World Nuclear Association Welcomes Microsoft Corporation as Newest Member](https://world-nuclear.org/news-and-media/press-statements/world-nuclear-association-welcomes-microsoft-corporation-as-newest-member)<!-- HN:45173933:end --><!-- HN:45177043:start -->
* [45177043](https://news.social-protocols.org/stats?id=45177043) #12 8 points 2 comments -> [Source code for the X Recommendation Algorithm](https://github.com/twitter/the-algorithm)<!-- HN:45177043:end --><!-- HN:45178389:start -->
* [45178389](https://news.social-protocols.org/stats?id=45178389) #1 122 points 32 comments -> [Mistral AI raises €1.7B to accelerate technological progress with AI](https://mistral.ai/news/mistral-ai-raises-1-7-b-to-accelerate-technological-progress-with-ai)<!-- HN:45178389:end --><!-- HN:45181775:start -->
* [45181775](https://news.social-protocols.org/stats?id=45181775) #28 5 points 3 comments -> [Israel bombs Qatar, targeting Hamas leadership](https://www.reuters.com/world/middle-east/several-blasts-heard-qatars-doha-israeli-media-says-hamas-leadership-targeted-2025-09-09/)<!-- HN:45181775:end --><!-- HN:45180584:start -->
* [45180584](https://news.social-protocols.org/stats?id=45180584) #15 14 points 1 comments -> [I ran Claude in a loop for 3 months, and it created a genz programming language](https://ghuntley.com/cursed/)<!-- HN:45180584:end --><!-- HN:45182137:start -->
* [45182137](https://news.social-protocols.org/stats?id=45182137) #30 6 points 0 comments -> [Zohran Mamdani Is Part of Municipal Socialism's Long History](https://jacobin.com/2025/08/mamdani-municipal-socialism-history-cities/)<!-- HN:45182137:end --><!-- HN:45186723:start -->
* [45186723](https://news.social-protocols.org/stats?id=45186723) #16 5 points 0 comments -> [Devs Cancel Claude Code En Masse – But Why?](https://www.aiengineering.report/p/devs-cancel-claude-code-en-masse)<!-- HN:45186723:end --><!-- HN:45187765:start -->
* [45187765](https://news.social-protocols.org/stats?id=45187765) #7 15 points 0 comments -> [AI Darwin Awards 2025](https://aidarwinawards.org/index.html)<!-- HN:45187765:end --><!-- HN:45189700:start -->
* [45189700](https://news.social-protocols.org/stats?id=45189700) #22 7 points 1 comments -> [All You Need Is SSH](https://wrongthink.link/posts/all-you-need-is-ssh/)<!-- HN:45189700:end -->
#### **Wednesday, September 10, 2025**
<!-- HN:45160727:start -->
* [45160727](https://news.social-protocols.org/stats?id=45160727) #10 20 points 40 comments -> [She puts the Lord in 'vanlord.' Palo Alto wants to ban her business](https://sanjosespotlight.com/she-puts-the-lord-in-vanlord-palo-alto-wants-to-ban-her-business/)<!-- HN:45160727:end --><!-- HN:45194973:start -->
* [45194973](https://news.social-protocols.org/stats?id=45194973) #25 4 points 0 comments -> [The Gaza family torn apart by IDF snipers from Chicago and Munich](https://www.theguardian.com/world/2025/sep/09/the-gaza-family-torn-apart-by-idf-snipers-from-chicago-and-munich)<!-- HN:45194973:end --><!-- HN:45193410:start -->
* [45193410](https://news.social-protocols.org/stats?id=45193410) #14 37 points 42 comments -> [Defense.gov Now Redirects to War.gov](https://defense.gov)<!-- HN:45193410:end --><!-- HN:45200143:start -->
* [45200143](https://news.social-protocols.org/stats?id=45200143) #8 9 points 1 comments -> [Anthropic Services Down](https://status.anthropic.com)<!-- HN:45200143:end --><!-- HN:45202233:start -->
* [45202233](https://news.social-protocols.org/stats?id=45202233) #21 3 points 0 comments -> [Show HN: Llmswap – Universal AI SDK and Code Generation CLI](https://sreenathmenon.com/blog/2025-09-04-stopped-alt-tabbing-chatgpt-while-coding/)<!-- HN:45202233:end --><!-- HN:45202537:start -->
* [45202537](https://news.social-protocols.org/stats?id=45202537) #10 5 points 1 comments -> [X Open Sourced Algorithm Code, So I analyzed it to learn how to grow on X](https://supabird.io/articles/how-to-grow-on-x-what-we-learned-from-their-algorithm-reveal)<!-- HN:45202537:end -->
#### **Thursday, September 11, 2025**<!-- HN:45209487:start -->
* [45209487](https://news.social-protocols.org/stats?id=45209487) #17 13 points 10 comments -> [How Does the Cycle of Political Violence End? Here's What an Expert Says](https://www.politico.com/news/magazine/2025/06/02/political-violence-boulder-attack-00381778)<!-- HN:45209487:end --><!-- HN:45213448:start -->
* [45213448](https://news.social-protocols.org/stats?id=45213448) #16 12 points 1 comments -> [The Reichstag Fire](https://en.wikipedia.org/wiki/Reichstag_fire)<!-- HN:45213448:end --><!-- HN:45215143:start -->
* [45215143](https://news.social-protocols.org/stats?id=45215143) #16 8 points 0 comments -> [Gaza: The AI Human Laboratory](https://www.thecairoreview.com/essays/gaza-israels-ai-human-laboratory/)<!-- HN:45215143:end --><!-- HN:45215534:start -->
* [45215534](https://news.social-protocols.org/stats?id=45215534) #27 19 points 8 comments -> [C# Will Become F# – Gautier Talks About Microsoft Technology](https://gautiertalksmicrosoft.wordpress.com/2025/04/13/c-will-become-f/)<!-- HN:45215534:end -->
#### **Friday, September 12, 2025**
<!-- HN:45219909:start -->
* [45219909](https://news.social-protocols.org/stats?id=45219909) #5 9 points 6 comments -> [Decompiling the GPL violated Linux kernel using Evolutionary Algorithms](https://far.chickenkiller.com/computing/decompiling-the-kernel-using-ea/)<!-- HN:45219909:end --><!-- HN:45221006:start -->
* [45221006](https://news.social-protocols.org/stats?id=45221006) #28 9 points 2 comments -> [Netherlands will boycott Eurovision 2026 if Israel participates](https://nltimes.nl/2025/09/12/netherlands-will-boycott-2026-eurovision-israel-participates-says-broadcaster)<!-- HN:45221006:end --><!-- HN:45222251:start -->
* [45222251](https://news.social-protocols.org/stats?id=45222251) #21 17 points 10 comments -> [Think twice before abandoning X11. Wayland breaks everything](https://gist.github.com/probonopd/9feb7c20257af5dd915e3a9f2d1f2277)<!-- HN:45222251:end --><!-- HN:45221423:start -->
* [45221423](https://news.social-protocols.org/stats?id=45221423) #24 37 points 42 comments -> [AI Startup Founders Tout a Winning Formula–No Booze, No Sleep, No Fun](https://www.wsj.com/business/entrepreneurship/artificial-intelligence-startup-founders-bc730406)<!-- HN:45221423:end --><!-- HN:45223913:start -->
* [45223913](https://news.social-protocols.org/stats?id=45223913) #6 27 points 15 comments -> [The Rise of AI Cults](https://wisewolfmedia.substack.com/p/the-rise-of-ai-cults-truth-terminal)<!-- HN:45223913:end --><!-- HN:45226066:start -->
* [45226066](https://news.social-protocols.org/stats?id=45226066) #18 11 points 16 comments -> [Show HN: 47jobs – A Fiverr/Upwork for AI Agents](https://47jobs.xyz)<!-- HN:45226066:end -->
#### **Saturday, September 13, 2025**<!-- HN:45229443:start -->
* [45229443](https://news.social-protocols.org/stats?id=45229443) #3 52 points 6 comments -> [Qwen 3 now supports ARM and MLX](https://www.alizila.com/qwen-ecosystem-expands-rapidly-accelerating-ai-adoption-across-industries/)<!-- HN:45229443:end --><!-- HN:45231452:start -->
* [45231452](https://news.social-protocols.org/stats?id=45231452) #28 3 points 0 comments -> [Company That Bought Publishers Clearing House Won't Pay Past Prize Winners](https://www.nytimes.com/2025/09/12/business/pch-sweepstakes-bankruptcy-winners-unpaid.html)<!-- HN:45231452:end --><!-- HN:45231631:start -->
* [45231631](https://news.social-protocols.org/stats?id=45231631) #17 6 points 1 comments -> [Get Out of Technology](https://geohot.github.io//blog/jekyll/update/2025/09/13/get-out-of-technology.html)<!-- HN:45231631:end --><!-- HN:45232289:start -->
* [45232289](https://news.social-protocols.org/stats?id=45232289) #8 3 points 3 comments -> [I made an online version of the love money game](https://lovemoney-game.xyz)<!-- HN:45232289:end --><!-- HN:45236212:start -->
* [45236212](https://news.social-protocols.org/stats?id=45236212) #21 9 points 0 comments -> [Mamdani, If Elected Mayor, Pledges to Order N.Y.P.D. To Arrest Netanyahu](https://www.nytimes.com/2025/09/12/nyregion/mamdani-arrest-netanyahu-nyc-mayor.html)<!-- HN:45236212:end -->
#### **Sunday, September 14, 2025**
<!-- HN:45236454:start -->
* [45236454](https://news.social-protocols.org/stats?id=45236454) #5 4 points 1 comments -> [US/* time zone deprecation affects fresh Debian 12 installs](https://rachelbythebay.com/w/2025/09/12/tz/)<!-- HN:45236454:end --><!-- HN:45196874:start -->
* [45196874](https://news.social-protocols.org/stats?id=45196874) #25 10 points 4 comments -> [Presence in VR should show tiny people, not user avatars](https://interconnected.org/home/2022/05/03/landscape)<!-- HN:45196874:end --><!-- HN:45237785:start -->
* [45237785](https://news.social-protocols.org/stats?id=45237785) #16 8 points 6 comments -> [ChatGPT Sent Me to the ER](https://benorenstein.substack.com/p/chatgpt-sent-me-to-the-er)<!-- HN:45237785:end --><!-- HN:45205976:start -->
* [45205976](https://news.social-protocols.org/stats?id=45205976) #21 11 points 0 comments -> [Uniprof: Universal CPU Profiling](https://www.uniprof.sh/)<!-- HN:45205976:end --><!-- HN:45239878:start -->
* [45239878](https://news.social-protocols.org/stats?id=45239878) #4 5 points 0 comments -> [Christian nationalists set sights on tiny Jackson County, Tennessee](https://www.newschannel5.com/news/newschannel-5-investigates/confronting-hate/aiming-to-radicalize-main-street-christian-nationalists-set-sights-on-tiny-jackson-county-tennessee)<!-- HN:45239878:end --><!-- HN:45240439:start -->
* [45240439](https://news.social-protocols.org/stats?id=45240439) #19 8 points 1 comments -> [PG: Supporters want to believe Kirk was killed by some powerful organized "them"](https://twitter.com/paulg/status/1967088969986044238)<!-- HN:45240439:end --><!-- HN:45211305:start -->
* [45211305](https://news.social-protocols.org/stats?id=45211305) #25 4 points 0 comments -> [Designing user interfaces with bots not buttons](https://interconnected.org/home/2022/05/09/npcs)<!-- HN:45211305:end --><!-- HN:45241457:start -->
* [45241457](https://news.social-protocols.org/stats?id=45241457) #29 6 points 1 comments -> [Anti-Israel protests force early end to Vuelta a España cycle race](https://www.reuters.com/sports/pro-palestinian-protests-disrupt-end-vuelta-cycle-race-2025-09-14/)<!-- HN:45241457:end --><!-- HN:45241690:start -->
* [45241690](https://news.social-protocols.org/stats?id=45241690) #29 10 points 2 comments -> [Medics in southern Gaza sound alarm over wave of newly displaced Palestinians](https://www.theguardian.com/world/2025/sep/14/southern-gaza-nasser-medics-displaced-palestinians-fleeing)<!-- HN:45241690:end --><!-- HN:45242565:start -->
* [45242565](https://news.social-protocols.org/stats?id=45242565) #28 6 points 0 comments -> [Taxpayers Will Pay Billions in New Fossil Fuel Subsidies for Big Beautiful Bill](https://www.wired.com/story/us-taxpayers-will-pay-billions-in-new-fossil-fuel-subsidies-thanks-to-the-big-beautiful-bill/)<!-- HN:45242565:end --><!-- HN:45242659:start -->
* [45242659](https://news.social-protocols.org/stats?id=45242659) #3 9 points 0 comments -> [Show HN: Update: Open-source private home security camera(end-to-end encryption)](https://github.com/secluso/secluso)<!-- HN:45242659:end --><!-- HN:45242075:start -->
* [45242075](https://news.social-protocols.org/stats?id=45242075) #9 -> [Lisp in 2025 (FOSS Book, 10 chapters)](https://github.com/cloudstreet-dev/Lisp-in-2025/blob/main/01-introduction.md)<!-- HN:45242075:end --><!-- HN:45241719:start -->
* [45241719](https://news.social-protocols.org/stats?id=45241719) #25 12 points 4 comments -> [The Perl Programming Language in 2025 (FOSS book)](https://github.com/cloudstreet-dev/The-PERL-Programming-Language/blob/main/01-why-perl-still-matters.md)<!-- HN:45241719:end --><!-- HN:45242645:start -->
* [45242645](https://news.social-protocols.org/stats?id=45242645) #23 22 points 18 comments -> [Show HN: DriftDB – An experimental append-only database with time-travel queries](https://github.com/DavidLiedle/DriftDB)<!-- HN:45242645:end -->
#### **Monday, September 15, 2025**
<!-- HN:45244733:start -->
* [45244733](https://news.social-protocols.org/stats?id=45244733) #7 43 points 21 comments -> [Rebutting 33 False Claims About Solar, Wind, and Electric Vehicles](https://scholarship.law.columbia.edu/cgi/viewcontent.cgi?article=1218&context=sabin_climate_change)<!-- HN:45244733:end --><!-- HN:45246282:start -->
* [45246282](https://news.social-protocols.org/stats?id=45246282) #9 37 points 3 comments -> [US taxpayers to pay billions in fuel subsidies thanks to Big Beautiful Bill](https://www.wired.com/story/us-taxpayers-will-pay-billions-in-new-fossil-fuel-subsidies-thanks-to-the-big-beautiful-bill/)<!-- HN:45246282:end -->