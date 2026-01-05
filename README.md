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

#### **Tuesday, December 30, 2025**
<!-- HN:46428699:start -->
* [46428699](https://news.social-protocols.org/stats?id=46428699) #21 11 points 11 comments -> [Show HN: Cover letter generator with Ollama/local LLMs (Open source)](https://www.coverlettermaker.co)<!-- HN:46428699:end --><!-- HN:46390123:start -->
* [46390123](https://news.social-protocols.org/stats?id=46390123) #25 11 points 2 comments -> [The AI Noise](https://rishi.monster/posts/time-intelligence-economy-part-1-the-ai-noise/)<!-- HN:46390123:end --><!-- HN:46431453:start -->
* [46431453](https://news.social-protocols.org/stats?id=46431453) #8 188 points 162 comments -> [HSBC blocks its app due to F-Droid-installed Bitwarden](https://mastodon.neilzone.co.uk/@neil/115807834298031971)<!-- HN:46431453:end --><!-- HN:46433035:start -->
* [46433035](https://news.social-protocols.org/stats?id=46433035) #2 160 points 139 comments -> [Win32 is the stable Linux ABI](https://loss32.org/)<!-- HN:46433035:end --><!-- HN:46434903:start -->
* [46434903](https://news.social-protocols.org/stats?id=46434903) #16 11 points 5 comments -> [Why people are mad at Framework](https://sgued.fr/blog/framework-omarchy/)<!-- HN:46434903:end --><!-- HN:46393609:start -->
* [46393609](https://news.social-protocols.org/stats?id=46393609) #2 56 points 9 comments -> [I built a quiet site for finding ambient albums while working](https://ambientmusic.com/)<!-- HN:46393609:end --><!-- HN:46438216:start -->
* [46438216](https://news.social-protocols.org/stats?id=46438216) #17 4 points 1 comments -> [Tatiana Schlossberg, granddaughter of John F Kennedy, dies aged 35](https://www.bbc.com/news/articles/c338ne3relzo)<!-- HN:46438216:end --><!-- HN:46438252:start -->
* [46438252](https://news.social-protocols.org/stats?id=46438252) #10 10 points 3 comments -> [The moment GMV is labeled ARR, the business is built on sand](https://oswarld.com/eng/insight/250816_ai-arr-illusion-gmv-vs-arr)<!-- HN:46438252:end --><!-- HN:46438122:start -->
* [46438122](https://news.social-protocols.org/stats?id=46438122) #16 18 points 4 comments -> [How the "Marvelization" of Cinema Accelerates the Decline of Filmmaking](https://www.openculture.com/2025/11/how-the-marvelization-of-cinema-accelerates-the-decline-of-filmmaking.html)<!-- HN:46438122:end -->
#### **Wednesday, December 31, 2025**
<!-- HN:46439369:start -->
* [46439369](https://news.social-protocols.org/stats?id=46439369) #16 6 points 1 comments -> [Honey's Dieselgate: Detecting and Tricking Testers](https://www.benedelman.org/honey-detecting-testers/)<!-- HN:46439369:end --><!-- HN:46440621:start -->
* [46440621](https://news.social-protocols.org/stats?id=46440621) #6 8 points 0 comments -> [SomaliScan – US Fraud aggregator sourced from public records](https://www.somaliscan.com/)<!-- HN:46440621:end --><!-- HN:46441592:start -->
* [46441592](https://news.social-protocols.org/stats?id=46441592) #6 3 points 1 comments -> [Questions to ask yourself every year](https://gourav.io/blog/yearly-review)<!-- HN:46441592:end --><!-- HN:46362895:start -->
* [46362895](https://news.social-protocols.org/stats?id=46362895) #7 9 points 0 comments -> [Scamp (Suite for Computer-Assisted Music in Python)](https://scamp.marcevanstein.com)<!-- HN:46362895:end --><!-- HN:46366010:start -->
* [46366010](https://news.social-protocols.org/stats?id=46366010) #16 214 points 28 comments -> [Reverse Engineering a Mysterious UDP Stream in My Hotel (2016)](https://www.gkbrk.com/hotel-music)<!-- HN:46366010:end --><!-- HN:46388445:start -->
* [46388445](https://news.social-protocols.org/stats?id=46388445) #15 52 points 40 comments -> [What If Heavy Files Felt Heavy?](https://www.shiveesh.com/thoughts-and-ideas/what-if-heavy-files-actually-felt-heavy)<!-- HN:46388445:end --><!-- HN:46443643:start -->
* [46443643](https://news.social-protocols.org/stats?id=46443643) #26 4 points 1 comments -> [Immigrant Derangement Syndrome](https://paulkrugman.substack.com/p/immigrant-derangement-syndrome)<!-- HN:46443643:end --><!-- HN:46443692:start -->
* [46443692](https://news.social-protocols.org/stats?id=46443692) #4 5 points 0 comments -> [Stages of AI Grief](https://sellsbrothers.com/the-5-stages-of-ai-grief)<!-- HN:46443692:end --><!-- HN:46443077:start -->
* [46443077](https://news.social-protocols.org/stats?id=46443077) #20 31 points 40 comments -> [Show HN: I built a universal clipboard that syncs realtime on multiple devices](https://www.quickclip.space/)<!-- HN:46443077:end --><!-- HN:46446395:start -->
* [46446395](https://news.social-protocols.org/stats?id=46446395) #27 11 points 6 comments -> [New York's incoming mayor bans Raspberry Pi at inauguration](https://www.theregister.com/2025/12/31/zohran_mamdani_raspberry_pi_ban/)<!-- HN:46446395:end --><!-- HN:46447659:start -->
* [46447659](https://news.social-protocols.org/stats?id=46447659) #6 21 points 24 comments -> [FTX whistleblower Caroline Ellison set for early release next month](https://invezz.com/news/2025/12/26/ftx-whistleblower-caroline-ellison-set-for-early-release-next-month/)<!-- HN:46447659:end --><!-- HN:46448031:start -->
* [46448031](https://news.social-protocols.org/stats?id=46448031) #9 -> [Happy New Year HN](https://tenor.com/view/gg-gif-12398339126318398543)<!-- HN:46448031:end --><!-- HN:46403813:start -->
* [46403813](https://news.social-protocols.org/stats?id=46403813) #24 13 points 5 comments -> [39C3 Grafana Dashboard](https://dashboard.congress.ccc.de/public-dashboards/e6cf86b287304662b4d1b8eb31b5ab50)<!-- HN:46403813:end -->
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
<!-- HN:46491765:start -->
* [46491765](https://news.social-protocols.org/stats?id=46491765) #21 40 points 40 comments -> [OpenGitOps](https://opengitops.dev/)<!-- HN:46491765:end --><!-- HN:46494830:start -->
* [46494830](https://news.social-protocols.org/stats?id=46494830) #8 7 points 5 comments -> [AGI Is Here](https://www.robinsloan.com/winter-garden/agi-is-here/)<!-- HN:46494830:end --><!-- HN:46434717:start -->
* [46434717](https://news.social-protocols.org/stats?id=46434717) #26 4 points 2 comments -> [What changes when AI memory stops being ephemeral?](https://ryjoxdemo.com/architecture)<!-- HN:46434717:end --><!-- HN:46422574:start -->
* [46422574](https://news.social-protocols.org/stats?id=46422574) #11 178 points 110 comments -> [The Year of the 3D Printed Miniature (and Other Lies We Tell Ourselves)](https://matduggan.com/the-year-of-the-3d-printed-miniature-and-other-lies-we-tell-ourselves/)<!-- HN:46422574:end -->