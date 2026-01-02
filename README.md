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

#### **Saturday, December 27, 2025**
<!-- HN:46397761:start -->
* [46397761](https://news.social-protocols.org/stats?id=46397761) #9 8 points 1 comments -> [Show HN: Me and my AI gf invented free energy from death puddles (public domain)](https://github.com/sqrew/le-claude-manson-engine)<!-- HN:46397761:end --><!-- HN:46398339:start -->
* [46398339](https://news.social-protocols.org/stats?id=46398339) #7 20 points 40 comments -> [Retreating from EVs could be hazardous for Western carmakers](https://www.economist.com/business/2025/12/17/retreating-from-evs-could-be-hazardous-for-western-carmakers)<!-- HN:46398339:end --><!-- HN:46354175:start -->
* [46354175](https://news.social-protocols.org/stats?id=46354175) #10 5 points 1 comments -> [Show HN: Vibe code from phone template repo](https://github.com/AdmTal/vibe-code-from-phone-starter)<!-- HN:46354175:end --><!-- HN:46400927:start -->
* [46400927](https://news.social-protocols.org/stats?id=46400927) #4 23 points 3 comments -> [Cursed Bundler: Using go get to install Ruby Gems](https://nesbitt.io/2025/12/25/cursed-bundler-using-go-get-to-install-ruby-gems.html)<!-- HN:46400927:end --><!-- HN:46371606:start -->
* [46371606](https://news.social-protocols.org/stats?id=46371606) #14 7 points 4 comments -> [Tieredsort: Header only, blazing fast (3-4x) C++17 sorting for numeric types](https://github.com/Cranot/tieredsort)<!-- HN:46371606:end --><!-- HN:46335473:start -->
* [46335473](https://news.social-protocols.org/stats?id=46335473) #15 9 points 0 comments -> [Building a Multi- Site Kubernetes Cluster with BGP Anycast](https://kyriakos.papadopoulos.tech/posts/multi-site-kubernetes-bgp/)<!-- HN:46335473:end --><!-- HN:46364482:start -->
* [46364482](https://news.social-protocols.org/stats?id=46364482) #11 12 points 0 comments -> [Reflections and rantings from a system design interviewer](https://www.calvinbarker.com/blog/reflections-and-rantings-from-a-system-design-interviewer)<!-- HN:46364482:end --><!-- HN:46404957:start -->
* [46404957](https://news.social-protocols.org/stats?id=46404957) #8 15 points 4 comments -> [Getting Fired over LinkedIn Account](https://priyatham.in/en/post/linkedin-horror/)<!-- HN:46404957:end --><!-- HN:46381236:start -->
* [46381236](https://news.social-protocols.org/stats?id=46381236) #13 15 points 0 comments -> [Love Actually is around Heathrow (2021)](https://www.heathrow.com/latest-news/love-actually-is-all-around-at-heathrow-airport)<!-- HN:46381236:end -->
#### **Sunday, December 28, 2025**
<!-- HN:46405375:start -->
* [46405375](https://news.social-protocols.org/stats?id=46405375) #30 40 points 9 comments -> [In 1995, a Netscape employee wrote a hack in 10 days that now runs the Internet](https://arstechnica.com/gadgets/2025/12/in-1995-a-netscape-employee-wrote-a-hack-in-10-days-that-now-runs-the-internet/)<!-- HN:46405375:end --><!-- HN:46405927:start -->
* [46405927](https://news.social-protocols.org/stats?id=46405927) #28 39 points 40 comments -> [Big Tech stole $35T from the public [video]](https://www.youtube.com/watch?v=P_TMuVQPfxw)<!-- HN:46405927:end --><!-- HN:46407331:start -->
* [46407331](https://news.social-protocols.org/stats?id=46407331) #30 3 points 1 comments -> [Software ate the world. Federation will eat embeddings](https://www.gnanaguru.com/p/federation-over-embeddings-let-ai)<!-- HN:46407331:end --><!-- HN:46408457:start -->
* [46408457](https://news.social-protocols.org/stats?id=46408457) #5 14 points 3 comments -> [Travel agents took 10 years to collapse, developers are three years in](https://martinalderson.com/posts/travel-agents-developers/)<!-- HN:46408457:end --><!-- HN:46406213:start -->
* [46406213](https://news.social-protocols.org/stats?id=46406213) #25 44 points 7 comments -> [7- and 14-segment fonts "DSEG"](https://www.keshikan.net/fonts.html)<!-- HN:46406213:end --><!-- HN:46412114:start -->
* [46412114](https://news.social-protocols.org/stats?id=46412114) #3 6 points 1 comments -> [Things Developers Can Avoid in 2026](https://newsletter.compasscalendar.com/p/77-things-to-avoid-in-2026-developer)<!-- HN:46412114:end --><!-- HN:46341926:start -->
* [46341926](https://news.social-protocols.org/stats?id=46341926) #23 31 points 40 comments -> [William Golding's Island of Savagery](https://www.historytoday.com/archive/portrait-author-historian/william-goldings-island-savagery)<!-- HN:46341926:end --><!-- HN:46412007:start -->
* [46412007](https://news.social-protocols.org/stats?id=46412007) #12 27 points 7 comments -> [Shut Up About the Water](https://prettygoodblog.com/p/shut-up-about-the-water)<!-- HN:46412007:end --><!-- HN:46412717:start -->
* [46412717](https://news.social-protocols.org/stats?id=46412717) #2 -> [RustOCR – Now do OCR 5-10x faster than EasyOCR](https://crates.io/crates/rustocr)<!-- HN:46412717:end --><!-- HN:46345412:start -->
* [46345412](https://news.social-protocols.org/stats?id=46345412) #16 113 points 32 comments -> [Never Use Pixelation to Hide Sensitive Text (2014)](https://dheera.net/posts/20140725-why-you-should-never-use-pixelation/)<!-- HN:46345412:end -->
#### **Monday, December 29, 2025**<!-- HN:46369808:start -->
* [46369808](https://news.social-protocols.org/stats?id=46369808) #10 89 points 39 comments -> [Researchers develop a camera that can focus on different distances at once](https://engineering.cmu.edu/news-events/news/2025/12/19-perfect-shot.html)<!-- HN:46369808:end --><!-- HN:46417724:start -->
* [46417724](https://news.social-protocols.org/stats?id=46417724) #19 45 points 24 comments -> [John Simpson: 'I've reported on 40 wars but I've never seen a year like 2025'](https://www.bbc.com/news/articles/cj4qp17e1lqo)<!-- HN:46417724:end --><!-- HN:46419249:start -->
* [46419249](https://news.social-protocols.org/stats?id=46419249) #29 9 points 0 comments -> [Musk's DOGE Failed to Slash Government Spending, It Led to a 6% Increase](https://offthefrontpage.com/musks-doge-failed-to-slash-government-spending-instead-leading-to-a-6-increase/)<!-- HN:46419249:end --><!-- HN:46401569:start -->
* [46401569](https://news.social-protocols.org/stats?id=46401569) #6 7 points 6 comments -> [I asked AI researchers and economists about SWE career strategies given AI](https://chrisbarber.co/I+asked+AI+researchers+%26+economists+about+SWE+career+strategy+and+the+future+of+AI)<!-- HN:46401569:end --><!-- HN:46364875:start -->
* [46364875](https://news.social-protocols.org/stats?id=46364875) #11 3 points 0 comments -> [Content Infinite Loop: 1 Hour Work, 30 Days of Traffic](https://blog.vect.pro/content-infinite-loop-guide)<!-- HN:46364875:end --><!-- HN:46421004:start -->
* [46421004](https://news.social-protocols.org/stats?id=46421004) #28 5 points 1 comments -> [Why Europe's night-train Renaissance derailed](https://www.politico.eu/article/why-europe-night-train-renaissance-derailed/)<!-- HN:46421004:end --><!-- HN:46422139:start -->
* [46422139](https://news.social-protocols.org/stats?id=46422139) #26 26 points 13 comments -> [US Confirms Strike on 'Big Facility' Inside Venezuela](https://www.bloomberg.com/news/articles/2025-12-29/trump-claims-us-strike-on-big-facility-inside-venezuela)<!-- HN:46422139:end --><!-- HN:46425371:start -->
* [46425371](https://news.social-protocols.org/stats?id=46425371) #9 3 points 1 comments -> [Show HN: I derived Planck mass from sphere packing – 0.574 ppm, zero free param](https://zenodo.org/records/18089296)<!-- HN:46425371:end --><!-- HN:46426131:start -->
* [46426131](https://news.social-protocols.org/stats?id=46426131) #12 49 points 64 comments -> [USPS Announces Changes to the Postmark Date System](https://nstp.org/article/usps-announces-changes-postmark-date-system)<!-- HN:46426131:end -->
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
* [46416863](https://news.social-protocols.org/stats?id=46416863) #24 7 points 3 comments -> [Vibe Coding for CTOs: The Real Cost of 100 Lines of Code](https://rocketedge.com/2025/12/29/vibe-coding-for-ctos-the-real-cost-of-100-lines-of-code-ai-agents-vs-human-developers-without-losing-control/)<!-- HN:46416863:end -->