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

#### **Monday, August 18, 2025**
<!-- HN:44937191:start -->
* [44937191](https://news.social-protocols.org/stats?id=44937191) #12 5 points 4 comments -> [Show HN: 500+ Golang Interview Questions Quiz](https://applyre.com/resources/500-interview-questions/golang/)<!-- HN:44937191:end --><!-- HN:44902731:start -->
* [44902731](https://news.social-protocols.org/stats?id=44902731) #12 28 points 15 comments -> [How Keeta processes 11M financial transactions per second with Spanner](https://cloud.google.com/blog/topics/financial-services/how-blockchain-network-keeta-processes-11-million-transactions-per-second-with-spanner)<!-- HN:44902731:end --><!-- HN:44938618:start -->
* [44938618](https://news.social-protocols.org/stats?id=44938618) #3 12 points 5 comments -> [We accidentally built the wrong internet](https://karimjedda.com/we-accidentally-built-the-wrong-internet/)<!-- HN:44938618:end --><!-- HN:44940551:start -->
* [44940551](https://news.social-protocols.org/stats?id=44940551) #5 9 points 8 comments -> [Discussing politics at work: Don't, just don't](https://betterthanrandom.substack.com/p/discussing-politics-at-work)<!-- HN:44940551:end --><!-- HN:44941750:start -->
* [44941750](https://news.social-protocols.org/stats?id=44941750) #30 11 points 4 comments -> [Apple Finally Destroyed Steve Jobs’ Vision of the iPad. Good](https://www.wired.com/story/apple-finally-destroyed-steve-jobss-vision-of-the-ipad-good/)<!-- HN:44941750:end --><!-- HN:44941755:start -->
* [44941755](https://news.social-protocols.org/stats?id=44941755) #13 4 points 0 comments -> [Show HN: Open-Source Framework for Real-Time AI Video Avatars](https://github.com/videosdk-community/ai-avatar-demo)<!-- HN:44941755:end --><!-- HN:44941907:start -->
* [44941907](https://news.social-protocols.org/stats?id=44941907) #30 -> [The administration's assault on science feels eerily Soviet](https://grist.org/politics/the-trump-administrations-assault-on-science-feels-eerily-soviet/)<!-- HN:44941907:end --><!-- HN:44940646:start -->
* [44940646](https://news.social-protocols.org/stats?id=44940646) #11 26 points 40 comments -> [The Coming Robot Home Invasion](https://www.andykessler.com/andy_kessler/2025/08/wsj-home-robots.html)<!-- HN:44940646:end --><!-- HN:44943545:start -->
* [44943545](https://news.social-protocols.org/stats?id=44943545) #29 25 points 1 comments -> [US helped Netanyahu's cyber chief evade child sex crime charges: Report](https://www.presstv.ir/Detail/2025/08/17/753255/Trump-admin--helped-Netanyahu%E2%80%99s-cyber-chief-go-free-after-his-arrest-for-child-sex-crimes--Report)<!-- HN:44943545:end --><!-- HN:44945785:start -->
* [44945785](https://news.social-protocols.org/stats?id=44945785) #23 3 points 0 comments -> [Customer churn is rarely about your product – it's your shitty support](https://www.synthicai.com)<!-- HN:44945785:end -->
#### **Tuesday, August 19, 2025**<!-- HN:44949059:start -->
* [44949059](https://news.social-protocols.org/stats?id=44949059) #30 5 points 0 comments -> ["Stop children using VPNs to watch porn", UK politicians told](https://www.bbc.co.uk/news/articles/cn438z3ejxyo)<!-- HN:44949059:end --><!-- HN:44950886:start -->
* [44950886](https://news.social-protocols.org/stats?id=44950886) #10 4 points 0 comments -> [Vibecoding my personal site into the 512KB Club](https://www.calvinbarker.com/blog/vibecoding-my-personal-site-into-the-512kb-club)<!-- HN:44950886:end --><!-- HN:44951204:start -->
* [44951204](https://news.social-protocols.org/stats?id=44951204) #3 20 points 12 comments -> [Ballot Hand Counts Lead to Inaccuracy](https://votingrightslab.org/2024/02/27/ballot-hand-counts-lead-to-inaccuracy/)<!-- HN:44951204:end --><!-- HN:44951681:start -->
* [44951681](https://news.social-protocols.org/stats?id=44951681) #26 22 points 7 comments -> [U.K. 30-Year Yield Tops U.S. as Pressure Mounts on Government Borrowing](https://www.coindesk.com/markets/2025/08/19/u-k-30-year-yield-tops-u-s-as-pressure-mounts-on-government-borrowing)<!-- HN:44951681:end --><!-- HN:44952240:start -->
* [44952240](https://news.social-protocols.org/stats?id=44952240) #6 32 points 3 comments -> [Google President Praised MAGA Speech Slamming 'Climate Extremist Agenda'](https://www.desmog.com/2025/08/19/google-president-praised-maga-speech-slamming-climate-extremist-agenda/)<!-- HN:44952240:end --><!-- HN:44953971:start -->
* [44953971](https://news.social-protocols.org/stats?id=44953971) #25 9 points 2 comments -> [Small Objects, Big Gains: Benchmarking Tigris Against AWS S3 and Cloudflare R2](https://www.tigrisdata.com/blog/benchmark-small-objects/)<!-- HN:44953971:end --><!-- HN:44956098:start -->
* [44956098](https://news.social-protocols.org/stats?id=44956098) #17 5 points 2 comments -> [Stop Paywalling SSO: It Is a Basic Right, Not an Enterprise Perk](https://oneuptime.com/blog/post/2025-08-19-sso-is-a-security-basic-not-an-enterprise-perk/view)<!-- HN:44956098:end --><!-- HN:44920437:start -->
* [44920437](https://news.social-protocols.org/stats?id=44920437) #22 8 points 3 comments -> [C# vs. Java int: Primitive type semantics, runtime behavior and tribal knowledge](https://msiyer.com/csharp-vs-java-int-primitive-type-semantics-runtime-behavior-and-tribal-knowledge/)<!-- HN:44920437:end -->
#### **Wednesday, August 20, 2025**
<!-- HN:44957520:start -->
* [44957520](https://news.social-protocols.org/stats?id=44957520) #11 11 points 12 comments -> [Avi Loeb: Is 3I/Atlas Our Turing Test by a Superior Alien Intelligence?](https://avi-loeb.medium.com/is-3i-atlas-our-turing-test-by-a-superior-alien-intelligence-32bfd838a9f2)<!-- HN:44957520:end --><!-- HN:44958452:start -->
* [44958452](https://news.social-protocols.org/stats?id=44958452) #8 8 points 1 comments -> [The Troubling Lines That Columbia Is Drawing](https://www.newyorker.com/news/the-lede/the-troubling-lines-that-columbia-is-drawing)<!-- HN:44958452:end --><!-- HN:44958506:start -->
* [44958506](https://news.social-protocols.org/stats?id=44958506) #8 14 points 7 comments -> [Pre-Sputnik Earth-Orbit Glints](https://www.overcomingbias.com/p/many-big-pre-sputnik-earth-orbit)<!-- HN:44958506:end --><!-- HN:44956774:start -->
* [44956774](https://news.social-protocols.org/stats?id=44956774) #14 85 points 1 comments -> [How to Scale Your Model: How to Think About GPUs](https://jax-ml.github.io/scaling-book/gpus/)<!-- HN:44956774:end --><!-- HN:44961584:start -->
* [44961584](https://news.social-protocols.org/stats?id=44961584) #12 -> [RFK Jr. is waging a misguided war on mRNA vaccine technology](https://www.wsj.com/opinion/rfk-jr-mrna-vaccines-hhs-covid-jay-bhattacharya-e9fa1ac3)<!-- HN:44961584:end -->
#### **Thursday, August 21, 2025**
<!-- HN:44968457:start -->
* [44968457](https://news.social-protocols.org/stats?id=44968457) #22 -> [At least 64 have been killed since dawn on Wednesday, including 19 aid seekers](https://www.aljazeera.com/news/liveblog/2025/8/20/live-israel-yet-to-reply-to-gaza-ceasefire-almost-19000-children-killed)<!-- HN:44968457:end --><!-- HN:44974717:start -->
* [44974717](https://news.social-protocols.org/stats?id=44974717) #16 8 points 1 comments -> [AI SRE Needs More Than AI: It Needs Operational Context](https://rootly.com/blog/ai-sre-needs-more-than-ai-it-needs-operational-context)<!-- HN:44974717:end --><!-- HN:44977543:start -->
* [44977543](https://news.social-protocols.org/stats?id=44977543) #12 12 points 8 comments -> [In Defense of Car-Centered Society](https://sweatofthebrow.blogspot.com/2025/08/in-defense-of-car-centered-society.html)<!-- HN:44977543:end -->
#### **Friday, August 22, 2025**
<!-- HN:44981383:start -->
* [44981383](https://news.social-protocols.org/stats?id=44981383) #9 24 points 42 comments -> [Is moderate drinking healthy? Scientists say the idea is outdated](https://news.stanford.edu/stories/2025/08/moderate-alcohol-consumption-drinking-health-benefits-impacts-research)<!-- HN:44981383:end --><!-- HN:44981572:start -->
* [44981572](https://news.social-protocols.org/stats?id=44981572) #26 8 points 2 comments -> [Nano Banana](https://nanobanana.ai/)<!-- HN:44981572:end --><!-- HN:44982631:start -->
* [44982631](https://news.social-protocols.org/stats?id=44982631) #16 -> [Gaza City and Surrounding Areas Are Officially Under Famine, Monitors Say](https://www.nytimes.com/2025/08/22/world/middleeast/famine-gaza-city-israel.html)<!-- HN:44982631:end --><!-- HN:44983301:start -->
* [44983301](https://news.social-protocols.org/stats?id=44983301) #21 7 points 1 comments -> [Bloomberg DMCA'd gamersnexus GPU smuggling documentary for quoting the President [video]](https://www.youtube.com/watch?v=6RJvrTC6oTI)<!-- HN:44983301:end --><!-- HN:44984045:start -->
* [44984045](https://news.social-protocols.org/stats?id=44984045) #21 9 points 0 comments -> [DMCA Used to Take Down GamersNexus Nvidia Smuggling Expose](https://twitter.com/GamersNexus/status/1958503184546111536)<!-- HN:44984045:end --><!-- HN:44984596:start -->
* [44984596](https://news.social-protocols.org/stats?id=44984596) #20 5 points 2 comments -> [NIMBYs threaten to sink Project Sail, a $17B datacenter development in Georgia](https://www.theregister.com/2025/08/22/georgia_datacenter_pushback/)<!-- HN:44984596:end --><!-- HN:44985028:start -->
* [44985028](https://news.social-protocols.org/stats?id=44985028) #21 35 points 17 comments -> [US to review all 55M visas to check if holders broke rules](https://www.bbc.com/news/articles/cvg04gm92d3o)<!-- HN:44985028:end --><!-- HN:44986087:start -->
* [44986087](https://news.social-protocols.org/stats?id=44986087) #14 42 points 25 comments -> [My development team costs $41.73 a month](https://philipotoole.com/my-development-team-costs-41-73-a-month/)<!-- HN:44986087:end --><!-- HN:44987692:start -->
* [44987692](https://news.social-protocols.org/stats?id=44987692) #7 36 points 14 comments -> [Essential Reading for Agentic Engineers – August 2025](https://steipete.me/posts/2025/essential-reading-august-2025)<!-- HN:44987692:end --><!-- HN:44985207:start -->
* [44985207](https://news.social-protocols.org/stats?id=44985207) #17 116 points 106 comments -> [A Guide to Gen AI / LLM Vibecoding for Expert Programmers](https://www.stochasticlifestyle.com/a-guide-to-gen-ai-llm-vibecoding-for-expert-programmers/)<!-- HN:44985207:end -->
#### **Saturday, August 23, 2025**<!-- HN:44993874:start -->
* [44993874](https://news.social-protocols.org/stats?id=44993874) #16 15 points 2 comments -> [DeepCode: Open Agentic Coding](https://github.com/HKUDS/DeepCode)<!-- HN:44993874:end --><!-- HN:44994515:start -->
* [44994515](https://news.social-protocols.org/stats?id=44994515) #7 5 points 6 comments -> [Asking three LLMs a simple question](https://sethops1.net/post/asking-three-llms-a-simple-question/)<!-- HN:44994515:end --><!-- HN:44949203:start -->
* [44949203](https://news.social-protocols.org/stats?id=44949203) #27 16 points 2 comments -> [Embedding Text Documents with Qwen3](https://www.daft.ai/blog/embedding-millions-of-text-documents-with-qwen3)<!-- HN:44949203:end --><!-- HN:44994217:start -->
* [44994217](https://news.social-protocols.org/stats?id=44994217) #20 24 points 40 comments -> [California teens are ditching office jobs – and making $100K before they turn 21](https://www.sfgate.com/bayarea/article/young-adults-changing-career-paths-ai-20824566.php)<!-- HN:44994217:end --><!-- HN:44993761:start -->
* [44993761](https://news.social-protocols.org/stats?id=44993761) #7 30 points 9 comments -> [Show HN: OctaneDB – Fast, Open-Source Vector Database for Python](https://github.com/RijinRaju/octanedb)<!-- HN:44993761:end --><!-- HN:44995168:start -->
* [44995168](https://news.social-protocols.org/stats?id=44995168) #22 26 points 40 comments -> [Self-driving cars begin testing on NYC streets](https://www.amny.com/nyc-transit/self-driving-cars-nyc-first-permit-waymo/)<!-- HN:44995168:end --><!-- HN:44994835:start -->
* [44994835](https://news.social-protocols.org/stats?id=44994835) #27 15 points 1 comments -> [Marital happiness = lovemaking rate – argument rate [pdf]](https://www.cmu.edu/dietrich/sds/docs/dawes/the-robust-beauty-of-improper-linear-models-in-decision-making.pdf)<!-- HN:44994835:end --><!-- HN:44996058:start -->
* [44996058](https://news.social-protocols.org/stats?id=44996058) #11 39 points 32 comments -> [Show HN: I Made the Hardest Focus App](https://apps.apple.com/us/app/pocket-the-hardest-focus-app/id6746587044)<!-- HN:44996058:end --><!-- HN:44963521:start -->
* [44963521](https://news.social-protocols.org/stats?id=44963521) #20 17 points 0 comments -> [Disk sampling on a sphere](https://observablehq.com/@jrus/spheredisksample)<!-- HN:44963521:end -->
#### **Sunday, August 24, 2025**
<!-- HN:45000400:start -->
* [45000400](https://news.social-protocols.org/stats?id=45000400) #21 11 points 2 comments -> [DeepCode: Open Agentic Coding](https://github.com/HKUDS/DeepCode)<!-- HN:45000400:end --><!-- HN:44977960:start -->
* [44977960](https://news.social-protocols.org/stats?id=44977960) #6 9 points 5 comments -> [Open Source Maintenance Fee business model example from WiX Toolset](https://github.com/wixtoolset)<!-- HN:44977960:end --><!-- HN:45002403:start -->
* [45002403](https://news.social-protocols.org/stats?id=45002403) #24 6 points 1 comments -> [Israeli army database suggests at least 83% of Gaza dead were civilians](https://www.972mag.com/israeli-intelligence-database-83-percent-civilians-militants/)<!-- HN:45002403:end --><!-- HN:44970974:start -->
* [44970974](https://news.social-protocols.org/stats?id=44970974) #14 34 points 40 comments -> [What if every city had a London Overground?](https://www.dwell.com/article/what-if-every-city-had-a-london-overground-ac7a7ff9)<!-- HN:44970974:end --><!-- HN:45002806:start -->
* [45002806](https://news.social-protocols.org/stats?id=45002806) #23 9 points 1 comments -> [Declaration of famine in Gaza lays bare Israel's disregard for humanitarian duty](https://www.theguardian.com/world/2025/aug/24/gaza-famine-declaration-israel-humanitarian-duty-analysis)<!-- HN:45002806:end -->