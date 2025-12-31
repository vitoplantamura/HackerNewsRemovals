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

#### **Thursday, December 25, 2025**
<!-- HN:46380027:start -->
* [46380027](https://news.social-protocols.org/stats?id=46380027) #29 15 points 7 comments -> [Microsoft: "30% of Our Code Is AI." Also Microsoft: "Windows Is Broken."](https://michael-dev-tech.github.io/Website/broken.html)<!-- HN:46380027:end --><!-- HN:46381681:start -->
* [46381681](https://news.social-protocols.org/stats?id=46381681) #12 7 points 1 comments -> [The most damaging taboo about sexual violence](https://write.as/3k6gb4heu8whz)<!-- HN:46381681:end --><!-- HN:46351625:start -->
* [46351625](https://news.social-protocols.org/stats?id=46351625) #22 7 points 0 comments -> [A Child in the State of Nature](https://lareviewofbooks.org/article/a-child-in-the-state-of-nature/)<!-- HN:46351625:end --><!-- HN:46383344:start -->
* [46383344](https://news.social-protocols.org/stats?id=46383344) #4 12 points 9 comments -> [Why 'The Global Market' Is an Irresponsible Phrase](https://oswarld.com/eng/insight/251117_Why-the-global-market-Is-an-Irresponsible-Phrase)<!-- HN:46383344:end --><!-- HN:46323177:start -->
* [46323177](https://news.social-protocols.org/stats?id=46323177) #15 4 points 0 comments -> [Why Community Translation Falls Short for Your Plugins and Themes](https://wpml.org/announcements/2025/12/why-community-translation-falls-short-for-your-plugins-and-themes/)<!-- HN:46323177:end --><!-- HN:46384415:start -->
* [46384415](https://news.social-protocols.org/stats?id=46384415) #20 22 points 18 comments -> [Ultra-Low-Latency Trading System](https://submicro.krishnabajpai.me/)<!-- HN:46384415:end --><!-- HN:46384781:start -->
* [46384781](https://news.social-protocols.org/stats?id=46384781) #10 132 points 74 comments -> [Salesforce regrets firing 4000 experienced staff and replacing them with AI](https://maarthandam.com/2025/12/25/salesforce-regrets-firing-4000-staff-ai/)<!-- HN:46384781:end --><!-- HN:46338788:start -->
* [46338788](https://news.social-protocols.org/stats?id=46338788) #8 5 points 2 comments -> [Rare look inside the secret Lego Museum](https://www.cbsnews.com/news/lego-secret-museum-denmark-headquarters/)<!-- HN:46338788:end --><!-- HN:46385335:start -->
* [46385335](https://news.social-protocols.org/stats?id=46385335) #8 5 points 1 comments -> [Why FedRAMP Authorization and CMMC Level 2 Are Now Table Stakes for GovCon AI](https://blog.procurementsciences.com/psci_blogs/why-fedramp-authorization-and-cmmc-level-2-are-now-table-stakes-for-govcon-ai)<!-- HN:46385335:end -->
#### **Friday, December 26, 2025**
<!-- HN:46354192:start -->
* [46354192](https://news.social-protocols.org/stats?id=46354192) #23 14 points 3 comments -> [Dasharo TrustRoot Ephemeral Key Incident](https://blog.3mdeb.com/2025/2025-12-18-eom-key-issue/)<!-- HN:46354192:end --><!-- HN:46332018:start -->
* [46332018](https://news.social-protocols.org/stats?id=46332018) #22 10 points 6 comments -> [Choosing the Right Python Docker Image for Finance Workloads](https://jiripik.com/2025/12/19/choosing-the-right-python-docker-image-for-finance-workloads/)<!-- HN:46332018:end --><!-- HN:46388904:start -->
* [46388904](https://news.social-protocols.org/stats?id=46388904) #26 31 points 14 comments -> [WiFi DensePose: WiFi-based dense human pose estimation system through walls](https://github.com/ruvnet/wifi-densepose)<!-- HN:46388904:end --><!-- HN:46322379:start -->
* [46322379](https://news.social-protocols.org/stats?id=46322379) #25 15 points 6 comments -> [Reinventing the dial-up modem (2019)](https://saket.me/dtmf-tones/)<!-- HN:46322379:end --><!-- HN:46315583:start -->
* [46315583](https://news.social-protocols.org/stats?id=46315583) #27 338 points 183 comments -> [Toys with the highest play-time and lowest clean-up-time](https://joannabregan.substack.com/p/toys-with-the-highest-play-time-and)<!-- HN:46315583:end --><!-- HN:46353177:start -->
* [46353177](https://news.social-protocols.org/stats?id=46353177) #19 6 points 3 comments -> [I Spent 3 Months Researching Image-Based Attacks](https://zero-trust-web.vercel.app/)<!-- HN:46353177:end --><!-- HN:46389715:start -->
* [46389715](https://news.social-protocols.org/stats?id=46389715) #2 6 points 3 comments -> [SQLite AI](https://www.sqlite.ai)<!-- HN:46389715:end --><!-- HN:46351178:start -->
* [46351178](https://news.social-protocols.org/stats?id=46351178) #25 6 points 4 comments -> [Show HN: Coderive – Iterating through 1 Quintillion Inside a Loop in just 50ms](https://github.com/DanexCodr/Coderive)<!-- HN:46351178:end --><!-- HN:46391220:start -->
* [46391220](https://news.social-protocols.org/stats?id=46391220) #26 11 points 4 comments -> [How Postmodernism Killed Great Literature](https://jamesgmartin.center/2025/12/how-postmodernism-killed-great-literature/)<!-- HN:46391220:end --><!-- HN:46396267:start -->
* [46396267](https://news.social-protocols.org/stats?id=46396267) #8 9 points 1 comments -> [Uv: An Fast Python Package Manager](https://www.janestreet.com/tech-talks/uv-an-extremely-fast-python-package-manager/)<!-- HN:46396267:end --><!-- HN:46346546:start -->
* [46346546](https://news.social-protocols.org/stats?id=46346546) #10 6 points 0 comments -> [Lofoten Islands Hiking](https://www.switchbacktravel.com/norway/lofoten-islands/hiking)<!-- HN:46346546:end -->
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
* [46441592](https://news.social-protocols.org/stats?id=46441592) #6 3 points 1 comments -> [Questions to ask yourself every year](https://gourav.io/blog/yearly-review)<!-- HN:46441592:end -->