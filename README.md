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

#### **Wednesday, November 18, 2026**
<!-- HN:50541542:start -->
* [50541542](https://news.social-protocols.org/stats?id=50541542) #17 9 points 1 comments -> [Engineering Vitals in the Age of AI](https://octopus.com/blog/engineering-vitals-in-the-age-of-ai)<!-- HN:50541542:end --><!-- HN:50497903:start -->
* [50497903](https://news.social-protocols.org/stats?id=50497903) #27 10 points 3 comments -> [Adopting Python 3.15's lazy imports: a 4× faster CLI, and where they didn't help](https://namegarage.com/blog/python-3-15-lazy-imports)<!-- HN:50497903:end --><!-- HN:50542217:start -->
* [50542217](https://news.social-protocols.org/stats?id=50542217) #12 8 points 3 comments -> [I had AI read my field](https://science.caseyhandmer.com/physics/)<!-- HN:50542217:end --><!-- HN:50541550:start -->
* [50541550](https://news.social-protocols.org/stats?id=50541550) #26 35 points 40 comments -> [H-1B Executive Actions in 2026 [pdf]](https://www.everycrsreport.com/files/2026-10-14_IN12747_fcb1389788aa7b9102b795882af042e85d20532c.pdf)<!-- HN:50541550:end --><!-- HN:50543669:start -->
* [50543669](https://news.social-protocols.org/stats?id=50543669) #30 -> [DOJ letter shows UCLA medical school discriminates against Asians and Whites](https://www.justice.gov/crt/media/1439581/dl)<!-- HN:50543669:end --><!-- HN:50545118:start -->
* [50545118](https://news.social-protocols.org/stats?id=50545118) #7 -> [I had AI read my entire field, Theoretical Astrophysics](https://science.caseyhandmer.com/physics/)<!-- HN:50545118:end --><!-- HN:50545232:start -->
* [50545232](https://news.social-protocols.org/stats?id=50545232) #30 32 points 41 comments -> [GTA 6 Review: It Is a Masterpiece](https://www.bloomberg.com/news/features/2026-11-18/gta-6-review-rockstar-games-latest-is-a-masterpiece)<!-- HN:50545232:end --><!-- HN:50547331:start -->
* [50547331](https://news.social-protocols.org/stats?id=50547331) #25 5 points 0 comments -> [Show HN: Is Arabic One Language?](https://www.parallel-arabic.com/arabic-dialects)<!-- HN:50547331:end --><!-- HN:50548281:start -->
* [50548281](https://news.social-protocols.org/stats?id=50548281) #24 12 points 25 comments -> [Software Factory builds 30 complex open source libraries in a month](https://recursiveai.org/blog/what-my-software-factory-built/)<!-- HN:50548281:end --><!-- HN:50548828:start -->
* [50548828](https://news.social-protocols.org/stats?id=50548828) #16 28 points 3 comments -> [Stop Deploying to ECS Just to See If Your Code Works](https://metalbear.com/blog/stop-deploying-to-ecs/)<!-- HN:50548828:end --><!-- HN:50548485:start -->
* [50548485](https://news.social-protocols.org/stats?id=50548485) #21 107 points 52 comments -> ["Anthropic Is Not a Safe AI Company" – Coalition Challenges Anthropic Safety](https://www.businesswire.com/news/home/20261118974464/en/Anthropic-is-Not-a-Safe-AI-Company---Broad-Coalition-of-Scientists-Legal-Scholars-and-Tech-Leaders-Challenge-Anthropics-Safety-Branding-Ahead-of-IPO)<!-- HN:50548485:end --><!-- HN:50549711:start -->
* [50549711](https://news.social-protocols.org/stats?id=50549711) #22 4 points 1 comments -> [Who made the strawberry? 14 days of logs building a procedural fruit with agents](https://strawberry-methodology.pages.dev)<!-- HN:50549711:end --><!-- HN:50549677:start -->
* [50549677](https://news.social-protocols.org/stats?id=50549677) #21 19 points 19 comments -> [We asked AI the same 210 buying questions 2 days in a row,84% of answers changed](https://supercite.ai/blog/ai-answers-change-every-day)<!-- HN:50549677:end --><!-- HN:50549967:start -->
* [50549967](https://news.social-protocols.org/stats?id=50549967) #17 12 points 5 comments -> [Nvidia Hit with a Ransomware](https://www.ransomware.live/id/TlZJRElBQHRoZWdlbnRsZW1lbg)<!-- HN:50549967:end --><!-- HN:50547236:start -->
* [50547236](https://news.social-protocols.org/stats?id=50547236) #26 51 points 16 comments -> [Attackers Used Optimizely to A/B Test Malware on Top Websites](https://krebsonsecurity.com/2026/11/attackers-used-optimizely-to-a-b-test-malware-on-top-websites/)<!-- HN:50547236:end --><!-- HN:50547423:start -->
* [50547423](https://news.social-protocols.org/stats?id=50547423) #19 87 points 13 comments -> [NGINX2Root by Xint – From Nginx visitor to root of the server host](https://nginx2root.com/)<!-- HN:50547423:end -->
#### **Thursday, November 19, 2026**
<!-- HN:50553402:start -->
* [50553402](https://news.social-protocols.org/stats?id=50553402) #29 11 points 12 comments -> [Why educational system is broken](https://keycybermonk.com/edu)<!-- HN:50553402:end --><!-- HN:50553192:start -->
* [50553192](https://news.social-protocols.org/stats?id=50553192) #28 44 points 40 comments -> [GTA6-like as a 942Kb UEFI bootable image](https://github.com/eklavya-raj/gta6-uefi)<!-- HN:50553192:end --><!-- HN:50564004:start -->
* [50564004](https://news.social-protocols.org/stats?id=50564004) #10 12 points 5 comments -> [Chile: UFO Sightings by 18th Century Jesuits](https://inexplicata.blogspot.com/2026/08/chile-ufo-sightings-by-18th-century.html)<!-- HN:50564004:end --><!-- HN:50526244:start -->
* [50526244](https://news.social-protocols.org/stats?id=50526244) #29 -> [Show HN: 1.499x speedup and 28.5% dynamic energy drop on A40 via BF16 tiling](https://cwtractors.com)<!-- HN:50526244:end -->
#### **Friday, November 20, 2026**
<!-- HN:50568643:start -->
* [50568643](https://news.social-protocols.org/stats?id=50568643) #22 62 points 20 comments -> [Postgres 19 is out, and it's available on Neon and Databricks Lakebase](https://www.databricks.com/blog/postgresql-19-available-lakebase)<!-- HN:50568643:end --><!-- HN:50530426:start -->
* [50530426](https://news.social-protocols.org/stats?id=50530426) #21 4 points 1 comments -> [Making Art with QR Codes, and the Fine Line Between Inspiration and Idea Theft](https://www.gorillasun.de/blog/making-art-with-qr-codes-and-the-fine-line-between-inspiration-and-idea-theft/)<!-- HN:50530426:end --><!-- HN:50565788:start -->
* [50565788](https://news.social-protocols.org/stats?id=50565788) #25 3 points 1 comments -> [Tubemap Mark Two: A geographically-accurate diagram of the London Underground](https://www.marknoaddesign.co.uk/london-tube-map)<!-- HN:50565788:end --><!-- HN:50574772:start -->
* [50574772](https://news.social-protocols.org/stats?id=50574772) #9 23 points 15 comments -> [Llms.txt and MCP didn't move the needle](https://backpackforlaravel.com/articles/opinions/llms-txt-and-mcp-didn-t-move-the-needle-for-us-here-s-what-did)<!-- HN:50574772:end --><!-- HN:50520420:start -->
* [50520420](https://news.social-protocols.org/stats?id=50520420) #24 17 points 8 comments -> [Creativity in Negative Space](https://spf13.com/p/creativity-in-negative-space/)<!-- HN:50520420:end --><!-- HN:50578289:start -->
* [50578289](https://news.social-protocols.org/stats?id=50578289) #10 7 points 1 comments -> [Anthropic's Plunge Deepens AI Selloff](https://boamaehg.blogspot.com/2026/11/nasdaq-slides-as-anthropic-plunge-drags.html)<!-- HN:50578289:end --><!-- HN:50580176:start -->
* [50580176](https://news.social-protocols.org/stats?id=50580176) #10 7 points 3 comments -> [ChurchTerminal – Christian News Dashboard Inspired by Hacker News](https://churchterminal.com/)<!-- HN:50580176:end --><!-- HN:50580385:start -->
* [50580385](https://news.social-protocols.org/stats?id=50580385) #15 48 points 15 comments -> [GrapheneOS claims Google is now waging war against it, could lock Pixel bootload](https://www.androidauthority.com/grapheneos-team-google-pressure-3737525/)<!-- HN:50580385:end --><!-- HN:50582746:start -->
* [50582746](https://news.social-protocols.org/stats?id=50582746) #21 22 points 3 comments -> [Supreme Court sentences 29-year-old activist to prison over FB post](https://prachataienglish.com/node/12123)<!-- HN:50582746:end -->
#### **Saturday, November 21, 2026**
<!-- HN:50582629:start -->
* [50582629](https://news.social-protocols.org/stats?id=50582629) #9 43 points 27 comments -> [A few hours ago Google DeepMind created a math horizon repo](https://github.com/google-deepmind/math-horizon)<!-- HN:50582629:end --><!-- HN:50588168:start -->
* [50588168](https://news.social-protocols.org/stats?id=50588168) #1 -> [Invalidity of the Alpoge Proposed Proof of the Riemann Hypothesis](https://philarchive.org/rec/NIEIOT-2)<!-- HN:50588168:end --><!-- HN:50588918:start -->
* [50588918](https://news.social-protocols.org/stats?id=50588918) #3 9 points 4 comments -> [Invalidity of Masullo's Proof of the Riemann Hypothesis](https://philarchive.org/rec/NIEIOM)<!-- HN:50588918:end --><!-- HN:50591820:start -->
* [50591820](https://news.social-protocols.org/stats?id=50591820) #8 5 points 2 comments -> [Invalidity of the Alpoge Proposed Proof of the Riemann Hypothesis](https://philarchive.org/rec/NIEIOT-2)<!-- HN:50591820:end -->
#### **Sunday, November 22, 2026**
<!-- HN:50595122:start -->
* [50595122](https://news.social-protocols.org/stats?id=50595122) #4 9 points 1 comments -> [(Supposed) ex-Rockstar employee: GTAVI creates psychological profiles, sells it](https://www.resetera.com/threads/supposed-ex-rockstar-employee-gtavi-creates-personality-profiles-based-on-gameplay-decisions-sells-them-to-outside-companies.1694417/)<!-- HN:50595122:end --><!-- HN:50595256:start -->
* [50595256](https://news.social-protocols.org/stats?id=50595256) #10 14 points 3 comments -> [Supposed Fired Rockstar Engineer Says GTAVI Makes Psychological Profiles](https://www.gadgetreview.com/man-claiming-to-be-fired-rockstar-engineer-says-gta-6-is-secretly-tracking-player-behavior-and-reporting-it-to-take-two)<!-- HN:50595256:end --><!-- HN:50595725:start -->
* [50595725](https://news.social-protocols.org/stats?id=50595725) #13 22 points 40 comments -> [The Most Popular Car Colors in America](https://www.iseecars.com/most-popular-car-colors-study)<!-- HN:50595725:end --><!-- HN:50596511:start -->
* [50596511](https://news.social-protocols.org/stats?id=50596511) #3 74 points 14 comments -> [AI Supply Chain Security: What Canary Tokens Found](https://www.dragos.com/blog/ai-supply-chain-security-canary-tokens)<!-- HN:50596511:end --><!-- HN:50533945:start -->
* [50533945](https://news.social-protocols.org/stats?id=50533945) #4 203 points 63 comments -> [A real Linux kernel, compiled to WebAssembly](https://github.com/pithings/unkernel)<!-- HN:50533945:end --><!-- HN:50604742:start -->
* [50604742](https://news.social-protocols.org/stats?id=50604742) #16 25 points 4 comments -> [Invalidity of the Alpoge Proposed Proof of the Riemann Hypothesis](https://philpapers.org/rec/NIEIOT-2)<!-- HN:50604742:end --><!-- HN:50604959:start -->
* [50604959](https://news.social-protocols.org/stats?id=50604959) #19 35 points 35 comments -> [Do Not Accept](https://donotaccept.ai/)<!-- HN:50604959:end -->
#### **Monday, November 23, 2026**
<!-- HN:50607591:start -->
* [50607591](https://news.social-protocols.org/stats?id=50607591) #10 8 points 3 comments -> [Mass destruction of weapons](https://computer.rip/2026-11-22-mass-destruction-of-weapons.html)<!-- HN:50607591:end --><!-- HN:50609079:start -->
* [50609079](https://news.social-protocols.org/stats?id=50609079) #11 88 points 48 comments -> [GTA 6 building personal behavioral profile for every player](https://huijzer.xyz/posts/174/gta-6-building-personal-behavioral-profile-for-eve)<!-- HN:50609079:end --><!-- HN:50610073:start -->
* [50610073](https://news.social-protocols.org/stats?id=50610073) #19 8 points 1 comments -> [China's prison for the elite is massively expanding](https://www.economist.com/china/2026/11/19/chinas-prison-for-the-elite-is-massively-expanding)<!-- HN:50610073:end --><!-- HN:50611588:start -->
* [50611588](https://news.social-protocols.org/stats?id=50611588) #1 1637 points 1390 comments -> [Jensen Huang Reinstated as Nvidia CEO](https://nvidianews.nvidia.com/news/nvidia-board-reinstates-jensen-huang-as-president-ceo-and-board-director)<!-- HN:50611588:end --><!-- HN:50616947:start -->
* [50616947](https://news.social-protocols.org/stats?id=50616947) #30 33 points 15 comments -> [Iranian authorities flog singer who performed without hijab, lawyers say](https://www.bbc.com/news/articles/cq1j6585l5g6o)<!-- HN:50616947:end --><!-- HN:50618490:start -->
* [50618490](https://news.social-protocols.org/stats?id=50618490) #12 48 points 29 comments -> [Congress shreds Nvidia's 'outrageous' return of Huang: 'Failure of character'](https://www.cnbc.com/2026/11/23/nvidia-jensen-huang-congress-trump.html)<!-- HN:50618490:end --><!-- HN:50620252:start -->
* [50620252](https://news.social-protocols.org/stats?id=50620252) #4 23 points 2 comments -> [VP != VNP over Every Field [pdf]](https://github.com/anthropics/formal-math/blob/11b6c7e3c927df2658f513b6b68ea7f8929c62c5/vp-vnp/paper.pdf)<!-- HN:50620252:end -->
#### **Tuesday, November 24, 2026**
<!-- HN:50623166:start -->
* [50623166](https://news.social-protocols.org/stats?id=50623166) #24 6 points 2 comments -> [Zero data retention with Enterprise Frontier Safeguards is now in beta](https://claude.com/resources/articles/zero-data-retention-with-enterprise-frontier-safeguards)<!-- HN:50623166:end --><!-- HN:50622769:start -->
* [50622769](https://news.social-protocols.org/stats?id=50622769) #1 129 points 36 comments -> [New York Bans Subscription and Post-Purchase Fees on Cars](https://wgna.com/car-bill-extra-fees/)<!-- HN:50622769:end --><!-- HN:50623175:start -->
* [50623175](https://news.social-protocols.org/stats?id=50623175) #30 9 points 0 comments -> [Show HN: Juncts, one DM inbox for five apps that Claude and ChatGPT can work in](https://juncts.com/app?demo=1&utm_source=hackernews&utm_medium=launch&utm_campaign=launch-nov26)<!-- HN:50623175:end -->