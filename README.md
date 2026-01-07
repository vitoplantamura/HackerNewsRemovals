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

#### **Thursday, January 1, 2026**
<!-- HN:46373817:start -->
* [46373817](https://news.social-protocols.org/stats?id=46373817) #14 10 points 8 comments -> [Ultra-Wide Band: A Transformational Technology for the Internet of Things](https://www.eetimes.com/ultra-wide-band-a-transformational-technology-for-the-internet-of-things/)<!-- HN:46373817:end --><!-- HN:46385943:start -->
* [46385943](https://news.social-protocols.org/stats?id=46385943) #21 7 points 0 comments -> [How to recognise a genuine password request](https://eclecticlight.co/2025/12/18/how-to-recognise-a-genuine-password-request/)<!-- HN:46385943:end --><!-- HN:46384349:start -->
* [46384349](https://news.social-protocols.org/stats?id=46384349) #29 33 points 3 comments -> [A Christmas Present to Myself – Vector Network Analyzer (2014)](https://axotron.se/blog/vector-network-analyzer-a-christmas-present-to-myself/)<!-- HN:46384349:end --><!-- HN:46456838:start -->
* [46456838](https://news.social-protocols.org/stats?id=46456838) #24 5 points 4 comments -> [Modern evidence for God from cosmology, astrochemistry, etc. (by a YC alum)](https://www.saintbeluga.org/follow-the-evidence-wherever-it-leads)<!-- HN:46456838:end -->
#### **Friday, January 2, 2026**
<!-- HN:46459859:start -->
* [46459859](https://news.social-protocols.org/stats?id=46459859) #7 4 points 1 comments -> [Show HN: Kirkified AI – 1-click Charlie Kirk face-swap memes (free, no signup)](https://kirkifiedai.com/)<!-- HN:46459859:end --><!-- HN:46460208:start -->
* [46460208](https://news.social-protocols.org/stats?id=46460208) #12 21 points 1 comments -> [California Delete Request and Opt-out Platform (DROP)](https://privacy.ca.gov/DROP/)<!-- HN:46460208:end --><!-- HN:46460831:start -->
* [46460831](https://news.social-protocols.org/stats?id=46460831) #19 7 points 2 comments -> [DENT: A network operating system (NOS) for everyone else](https://dent.dev/)<!-- HN:46460831:end --><!-- HN:46460867:start -->
* [46460867](https://news.social-protocols.org/stats?id=46460867) #25 33 points 11 comments -> [China's BYD set to overtake Tesla as top EV seller](https://www.bbc.com/news/articles/cj9rjwpvmpzo)<!-- HN:46460867:end --><!-- HN:46416863:start -->
* [46416863](https://news.social-protocols.org/stats?id=46416863) #24 7 points 3 comments -> [Vibe Coding for CTOs: The Real Cost of 100 Lines of Code](https://rocketedge.com/2025/12/29/vibe-coding-for-ctos-the-real-cost-of-100-lines-of-code-ai-agents-vs-human-developers-without-losing-control/)<!-- HN:46416863:end --><!-- HN:46463600:start -->
* [46463600](https://news.social-protocols.org/stats?id=46463600) #19 5 points 2 comments -> [2025 Letter](https://danwang.co/)<!-- HN:46463600:end --><!-- HN:46464565:start -->
* [46464565](https://news.social-protocols.org/stats?id=46464565) #6 4 points 0 comments -> [A Socialist Now Runs New York. Here's What History Predicts](https://zcashexplained.com/blog/new-york-voted-socialist/)<!-- HN:46464565:end --><!-- HN:46465513:start -->
* [46465513](https://news.social-protocols.org/stats?id=46465513) #14 33 points 23 comments -> [Vibe Coding Killed Cursor](https://ischemist.com/writings/long-form/how-vibe-coding-killed-cursor)<!-- HN:46465513:end --><!-- HN:46465622:start -->
* [46465622](https://news.social-protocols.org/stats?id=46465622) #30 4 points 1 comments -> [Kling Motion Control AI](https://motion-control.io)<!-- HN:46465622:end --><!-- HN:46469780:start -->
* [46469780](https://news.social-protocols.org/stats?id=46469780) #22 36 points 22 comments -> [I wrote the manual Karpathy said was missing for agentic AI](https://github.com/nicolasahar/morphic-programming)<!-- HN:46469780:end -->
#### **Saturday, January 3, 2026**
<!-- HN:46470571:start -->
* [46470571](https://news.social-protocols.org/stats?id=46470571) #28 59 points 22 comments -> [NY Fed cash transfers to banks increase dramatically in Q4 2025](https://www.dcreport.org/2025/12/29/ny-fed-unlimited-cash-infusions-bank-crisis/)<!-- HN:46470571:end --><!-- HN:46420119:start -->
* [46420119](https://news.social-protocols.org/stats?id=46420119) #21 5 points 4 comments -> [Show HN: True Persistent F*****G Memory for Robotics (Bypassing Linux Kernel)](https://ryjoxdemo.com/demo)<!-- HN:46420119:end --><!-- HN:46473831:start -->
* [46473831](https://news.social-protocols.org/stats?id=46473831) #16 7 points 0 comments -> [U.S. launches military strikes on Venezuela](https://www.cbsnews.com/live-updates/venezuela-us-military-strikes-maduro-trump/)<!-- HN:46473831:end --><!-- HN:46473232:start -->
* [46473232](https://news.social-protocols.org/stats?id=46473232) #23 7 points 3 comments -> [The Constitution Was a Coup](https://lucasvance.github.io/2100/coup/)<!-- HN:46473232:end --><!-- HN:46474833:start -->
* [46474833](https://news.social-protocols.org/stats?id=46474833) #2 28 points 4 comments -> [How to Win Friends and Influence People: Unrevised Version](https://socialskillswisdom.com/)<!-- HN:46474833:end --><!-- HN:46475376:start -->
* [46475376](https://news.social-protocols.org/stats?id=46475376) #11 48 points 20 comments -> [Not for Human Consumption](https://vectorculture.substack.com/p/not-for-human-consumption)<!-- HN:46475376:end --><!-- HN:46404005:start -->
* [46404005](https://news.social-protocols.org/stats?id=46404005) #14 5 points 1 comments -> [Quality Food Comes from Constraints](https://gist.github.com/breadchris/00f64f3c26ebb9bccb7fd9d94be9d708)<!-- HN:46404005:end --><!-- HN:46478740:start -->
* [46478740](https://news.social-protocols.org/stats?id=46478740) #4 9 points 1 comments -> [Show HN: Underpriced AI – Snap a photo, get instant resale value with AI](https://underpricedai.com)<!-- HN:46478740:end --><!-- HN:46478398:start -->
* [46478398](https://news.social-protocols.org/stats?id=46478398) #4 62 points 47 comments -> [Cardiovascular disease is a solved problem](https://totalhealthoptimization.com/2025/09/27/cardiovascular-disease-is-a-solved-problem/)<!-- HN:46478398:end --><!-- HN:46479869:start -->
* [46479869](https://news.social-protocols.org/stats?id=46479869) #7 28 points 11 comments -> [Bluesky is not the good place](https://www.ms.now/opinion/bluesky-elon-musk-twitter-replacement)<!-- HN:46479869:end --><!-- HN:46480194:start -->
* [46480194](https://news.social-protocols.org/stats?id=46480194) #18 15 points 21 comments -> [Reddit Has Become the Internet's Strip Mall](https://pontozero.info/static/reddit-strip-mall/)<!-- HN:46480194:end --><!-- HN:46403062:start -->
* [46403062](https://news.social-protocols.org/stats?id=46403062) #15 138 points 18 comments -> [Of Boot Vectors and Double Glitches: Bypassing RP2350's Secure Boot](https://streaming.media.ccc.de/39c3/relive/2149)<!-- HN:46403062:end --><!-- HN:46407376:start -->
* [46407376](https://news.social-protocols.org/stats?id=46407376) #24 10 points 2 comments -> [2026 macro outlook – views across the street (synthesis 2026 outlook reports)](https://2026macro.vercel.app/)<!-- HN:46407376:end --><!-- HN:46403704:start -->
* [46403704](https://news.social-protocols.org/stats?id=46403704) #30 20 points 8 comments -> [Hacking VBA to support native scripting runtime with no COM dependencies](https://github.com/ECP-Solutions/ASF)<!-- HN:46403704:end --><!-- HN:46480709:start -->
* [46480709](https://news.social-protocols.org/stats?id=46480709) #5 33 points 10 comments -> [Busy Is the New Stupid](https://www.cisotradecraft.com/bitns)<!-- HN:46480709:end --><!-- HN:46482234:start -->
* [46482234](https://news.social-protocols.org/stats?id=46482234) #9 10 points 1 comments -> [The Return of the American Protectorate](https://www.karlsnotes.com/running-venezuela-the-return-of-the-american-protectorate/)<!-- HN:46482234:end --><!-- HN:46482972:start -->
* [46482972](https://news.social-protocols.org/stats?id=46482972) #6 3 points 0 comments -> [The Venezuelan change: Why do people keep getting him wrong on foreign policy?](https://warontherocks.com/2026/01/trumps-venezuelan-regime-change-why-do-people-keep-getting-him-wrong-on-foreign-policy/)<!-- HN:46482972:end -->
#### **Sunday, January 4, 2026**
<!-- HN:46483876:start -->
* [46483876](https://news.social-protocols.org/stats?id=46483876) #7 6 points 0 comments -> [The Vietnam War: The Press on the Front Lines](https://www.heinzhistorycenter.org/blog/collection-spotlight-vietnam-war-press-on-the-front-lines/)<!-- HN:46483876:end --><!-- HN:46426931:start -->
* [46426931](https://news.social-protocols.org/stats?id=46426931) #17 10 points 4 comments -> [Evolution: Training neural networks with genetic selection achieves 81% on MNIST](https://github.com/A1CST/GENREG_ALPHA_MNIST)<!-- HN:46426931:end --><!-- HN:46487523:start -->
* [46487523](https://news.social-protocols.org/stats?id=46487523) #10 14 points 1 comments -> [Open Veins of Latin America Five Centuries of the Pillage of a Continent [pdf]](https://archive.wphna.org/wp-content/uploads/2015/06/1971-Eduardo-Galeano-Open-Veins-of-Latin-America.pdf)<!-- HN:46487523:end --><!-- HN:46488652:start -->
* [46488652](https://news.social-protocols.org/stats?id=46488652) #14 5 points 0 comments -> [Democracy Will Not Survive the Age of Consumption](https://kasurian.com/p/democracy-will-not-survive-consumption)<!-- HN:46488652:end --><!-- HN:46489658:start -->
* [46489658](https://news.social-protocols.org/stats?id=46489658) #26 7 points 1 comments -> [Trump the Robber Baron](https://forumgeopolitica.com/article/trump-the-robber-baron)<!-- HN:46489658:end --><!-- HN:46488661:start -->
* [46488661](https://news.social-protocols.org/stats?id=46488661) #21 40 points 40 comments -> [Neurodivergent Brains Build Better Systems (2025)](https://blog.drjoshcsimmons.com/p/how-neurodivergent-brains-build-better)<!-- HN:46488661:end --><!-- HN:46469845:start -->
* [46469845](https://news.social-protocols.org/stats?id=46469845) #2 45 points 35 comments -> [Microservices Killed Our Startup. Monoliths Would've Saved Us](https://medium.com/lets-code-future/microservices-killed-our-startup-monoliths-wouldve-saved-us-4ebadf584a6d)<!-- HN:46469845:end --><!-- HN:46417768:start -->
* [46417768](https://news.social-protocols.org/stats?id=46417768) #9 9 points 0 comments -> [Copybara – tool for transforming and moving code between repositories](https://github.com/google/copybara)<!-- HN:46417768:end -->
#### **Monday, January 5, 2026**
<!-- HN:46494830:start -->
* [46494830](https://news.social-protocols.org/stats?id=46494830) #8 7 points 5 comments -> [AGI Is Here](https://www.robinsloan.com/winter-garden/agi-is-here/)<!-- HN:46494830:end --><!-- HN:46434717:start -->
* [46434717](https://news.social-protocols.org/stats?id=46434717) #26 4 points 2 comments -> [What changes when AI memory stops being ephemeral?](https://ryjoxdemo.com/architecture)<!-- HN:46434717:end --><!-- HN:46422574:start -->
* [46422574](https://news.social-protocols.org/stats?id=46422574) #11 178 points 110 comments -> [The Year of the 3D Printed Miniature (and Other Lies We Tell Ourselves)](https://matduggan.com/the-year-of-the-3d-printed-miniature-and-other-lies-we-tell-ourselves/)<!-- HN:46422574:end --><!-- HN:46496975:start -->
* [46496975](https://news.social-protocols.org/stats?id=46496975) #23 -> [Danish PM tells Trump to stop 'threats' against Greenland](https://www.bbc.com/news/articles/c4g0zg974v1o)<!-- HN:46496975:end --><!-- HN:46497883:start -->
* [46497883](https://news.social-protocols.org/stats?id=46497883) #5 2 points 0 comments -> [Didascal](https://didascal.com)<!-- HN:46497883:end --><!-- HN:46498676:start -->
* [46498676](https://news.social-protocols.org/stats?id=46498676) #28 25 points 21 comments -> [Ozempic Melted Away Weight–and the Idea of 'Body Positivity'](https://www.wsj.com/opinion/ozempic-melted-away-weight-and-the-idea-of-body-positivity-4917671c)<!-- HN:46498676:end --><!-- HN:46442322:start -->
* [46442322](https://news.social-protocols.org/stats?id=46442322) #26 -> [What do I mean by some software devs are "ngmi"?](https://ghuntley.com/ngmi/)<!-- HN:46442322:end --><!-- HN:46500394:start -->
* [46500394](https://news.social-protocols.org/stats?id=46500394) #7 9 points 0 comments -> [Windows Is That Bad](https://bomfather.dev/comics/7/)<!-- HN:46500394:end --><!-- HN:46435328:start -->
* [46435328](https://news.social-protocols.org/stats?id=46435328) #15 6 points 4 comments -> [Square Face Generator – A Cute Square Face Icon Maker](https://www.squarefacegenerators.com/)<!-- HN:46435328:end --><!-- HN:46501017:start -->
* [46501017](https://news.social-protocols.org/stats?id=46501017) #27 28 points 5 comments -> ['We need Greenland': Trump repeats threat to annex Danish territory](https://www.bbc.com/news/articles/c4g0zg974v1o)<!-- HN:46501017:end --><!-- HN:46504159:start -->
* [46504159](https://news.social-protocols.org/stats?id=46504159) #14 56 points 17 comments -> [Pentagon moves to punish Democratic senator over 'seditious video'](https://www.bbc.com/news/articles/cp8039wg1rdo)<!-- HN:46504159:end --><!-- HN:46436857:start -->
* [46436857](https://news.social-protocols.org/stats?id=46436857) #14 10 points 1 comments -> [5 Years, 12 Pivots](https://boundaryml.com/blog/5-years-12-pivots)<!-- HN:46436857:end --><!-- HN:46504454:start -->
* [46504454](https://news.social-protocols.org/stats?id=46504454) #15 5 points 0 comments -> [Pentagon moves to punish Democratic senator over 'seditious video'](https://news.ycombinator.com/item?id=46504159)<!-- HN:46504454:end --><!-- HN:46504389:start -->
* [46504389](https://news.social-protocols.org/stats?id=46504389) #20 3 points 3 comments -> [AGI is here (and I feel fine)](https://www.robinsloan.com/winter-garden/agi-is-here/)<!-- HN:46504389:end --><!-- HN:46504692:start -->
* [46504692](https://news.social-protocols.org/stats?id=46504692) #23 3 points 2 comments -> [Reasons I did 301,432 flashcard reviews in 2025](https://www.natemeyvis.com/22-reasons-i-did-301432-flashcard-reviews-in-2025/)<!-- HN:46504692:end -->
#### **Tuesday, January 6, 2026**
<!-- HN:46506675:start -->
* [46506675](https://news.social-protocols.org/stats?id=46506675) #24 25 points 20 comments -> [Pink Power Ranger takes down white supremacist dating sites](https://www.thecanary.co/skwawkbox/2026/01/04/power-ranger-deletes-dating-site/)<!-- HN:46506675:end --><!-- HN:46509788:start -->
* [46509788](https://news.social-protocols.org/stats?id=46509788) #17 44 points 29 comments -> [Mapping Protests in Iran](https://www.fdd.org/analysis/2025/06/25/mapping-the-protests-in-iran-2/)<!-- HN:46509788:end --><!-- HN:46510656:start -->
* [46510656](https://news.social-protocols.org/stats?id=46510656) #13 6 points 3 comments -> [Show HN: Is this the best epoch converter?](https://epochconverter.dev/)<!-- HN:46510656:end --><!-- HN:46514707:start -->
* [46514707](https://news.social-protocols.org/stats?id=46514707) #17 2 points 0 comments -> [Show HN: Open-source Langsmith alternative written in Rust](https://github.com/lmnr-ai/lmnr)<!-- HN:46514707:end --><!-- HN:46473142:start -->
* [46473142](https://news.social-protocols.org/stats?id=46473142) #30 11 points 1 comments -> [Gtasks-terminal – Google Tasks power-tool for the terminal](https://github.com/sirusdas/gtasks-terminal)<!-- HN:46473142:end --><!-- HN:46518218:start -->
* [46518218](https://news.social-protocols.org/stats?id=46518218) #28 6 points 3 comments -> [America's affordability crisis is (mostly) a mirage](https://www.economist.com/briefing/2025/12/30/americas-affordability-crisis-is-mostly-a-mirage)<!-- HN:46518218:end --><!-- HN:46450014:start -->
* [46450014](https://news.social-protocols.org/stats?id=46450014) #29 5 points 4 comments -> [Runtime invariant to rule count in a single-pass boundary execution model](https://targetedwebresults.com/pounce-demo-final.gif)<!-- HN:46450014:end -->
#### **Wednesday, January 7, 2026**<!-- HN:46521619:start -->
* [46521619](https://news.social-protocols.org/stats?id=46521619) #27 20 points 2 comments -> [White House Posts False Jan. 6 Narrative on Riot's 5th Anniversary](https://www.nytimes.com/2026/01/06/us/politics/trump-white-house-jan-6-website.html)<!-- HN:46521619:end --><!-- HN:46520975:start -->
* [46520975](https://news.social-protocols.org/stats?id=46520975) #24 11 points 2 comments -> [Website with a DMCA Takedown](https://priyatham.in/en/post/hosting-dmca/)<!-- HN:46520975:end --><!-- HN:46451768:start -->
* [46451768](https://news.social-protocols.org/stats?id=46451768) #2 619 points 123 comments -> [Spherical Snake](https://kevinalbs.com/spherical_snake/)<!-- HN:46451768:end --><!-- HN:46470115:start -->
* [46470115](https://news.social-protocols.org/stats?id=46470115) #27 11 points 0 comments -> [Show HN: Open-source AI workflows with read-only auth scopes](https://github.com/seer-engg/seer)<!-- HN:46470115:end --><!-- HN:46472047:start -->
* [46472047](https://news.social-protocols.org/stats?id=46472047) #21 20 points 9 comments -> [Show HN: TCP chat server written in C# and .NET 9, used in the terminal](https://github.com/Sieep-Coding/simple-chat-csharp)<!-- HN:46472047:end --><!-- HN:46527443:start -->
* [46527443](https://news.social-protocols.org/stats?id=46527443) #11 -> [Supreme Court Increasingly Favors the Rich, Economists Say](https://www.nytimes.com/2026/01/05/us/politics/supreme-court-study-rich-poor.html)<!-- HN:46527443:end --><!-- HN:46529097:start -->
* [46529097](https://news.social-protocols.org/stats?id=46529097) #4 20 points 40 comments -> [The $14 Burrito: Why San Francisco Inflation Feels Higher Than 2.5%](https://www.foglinesf.com/p/the-14-burrito-why-san-francisco-inflation-feels-higher-than-2-5)<!-- HN:46529097:end --><!-- HN:46531150:start -->
* [46531150](https://news.social-protocols.org/stats?id=46531150) #12 5 points 7 comments -> [A practical guide to converting YAML to JSON safely (with Kubernetes examples)](https://coderaviverma.github.io/yaml-to-json-guide/)<!-- HN:46531150:end --><!-- HN:46531899:start -->
* [46531899](https://news.social-protocols.org/stats?id=46531899) #14 29 points 7 comments -> [US immigration officer fatally shoots woman, 37, in Minneapolis, officials say](https://www.bbc.com/news/live/c7510l1135wt)<!-- HN:46531899:end --><!-- HN:46533968:start -->
* [46533968](https://news.social-protocols.org/stats?id=46533968) #17 6 points 1 comments -> [Eyewitness says ICE agents gave conflicting orders before shooting woman](https://www.mprnews.org/story/2026/01/07/shooting-south-minneapolis-ice-agents-federal-operation)<!-- HN:46533968:end -->