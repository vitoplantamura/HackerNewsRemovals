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

#### **Friday, March 20, 2026**
<!-- HN:47406731:start -->
* [47406731](https://news.social-protocols.org/stats?id=47406731) #23 6 points 1 comments -> [I built a clip-on muscle sensor so personal trainers can show clients progress](https://inara.technology)<!-- HN:47406731:end --><!-- HN:47450514:start -->
* [47450514](https://news.social-protocols.org/stats?id=47450514) #25 9 points 2 comments -> [Kin: Semantic version control that tracks code as entities, not files](https://github.com/firelock-ai/kin)<!-- HN:47450514:end --><!-- HN:47452828:start -->
* [47452828](https://news.social-protocols.org/stats?id=47452828) #14 42 points 31 comments -> [3M's PFAS exit killed the supply chain for two-phase immersion cooling in DCs](https://thecoolingreport.com/intel.html)<!-- HN:47452828:end --><!-- HN:47453728:start -->
* [47453728](https://news.social-protocols.org/stats?id=47453728) #5 7 points 6 comments -> [The 12" chef knife, a humble plea](https://kellykozakandjoshdonald.substack.com/p/the-12-chef-knife-a-humble-plea)<!-- HN:47453728:end --><!-- HN:47454241:start -->
* [47454241](https://news.social-protocols.org/stats?id=47454241) #25 12 points 21 comments -> [Nvidia's Huang pitches AI tokens on top of salary](https://www.cnbc.com/2026/03/20/nvidia-ai-agents-tokens-human-workers-engineer-jobs-unemployment-jensen-huang.html)<!-- HN:47454241:end --><!-- HN:47457929:start -->
* [47457929](https://news.social-protocols.org/stats?id=47457929) #9 34 points 7 comments -> [US to deploy additional troops to the Middle East, officials say](https://www.reuters.com/world/us-deploy-thousands-additional-troops-middle-east-officials-say-2026-03-20/)<!-- HN:47457929:end --><!-- HN:47459969:start -->
* [47459969](https://news.social-protocols.org/stats?id=47459969) #11 24 points 9 comments -> [Time to Dump Windows?](https://dennisforbes.ca/blog/microblog/2026/02/time_to_dump_windows/)<!-- HN:47459969:end -->
#### **Saturday, March 21, 2026**
<!-- HN:47462298:start -->
* [47462298](https://news.social-protocols.org/stats?id=47462298) #9 28 points 21 comments -> [Why I'm Not Worried About Running Out of Work in the Age of AI](https://kellblog.com/2026/03/19/why-im-not-worried-about-running-out-of-work-in-the-age-of-ai/)<!-- HN:47462298:end --><!-- HN:47407293:start -->
* [47407293](https://news.social-protocols.org/stats?id=47407293) #29 158 points 54 comments -> [Video Encoding and Decoding with Vulkan Compute Shaders in FFmpeg](https://www.khronos.org/blog/video-encoding-and-decoding-with-vulkan-compute-shaders-in-ffmpeg)<!-- HN:47407293:end --><!-- HN:47464127:start -->
* [47464127](https://news.social-protocols.org/stats?id=47464127) #25 17 points 2 comments -> [Israel and Weapons of Mass Destruction](https://en.wikipedia.org/wiki/Israel_and_weapons_of_mass_destruction)<!-- HN:47464127:end --><!-- HN:47464394:start -->
* [47464394](https://news.social-protocols.org/stats?id=47464394) #1 86 points 34 comments -> [Google adds 24-hour wait and mandatory reboot to Android sideloading flow](https://android-developers.googleblog.com/2025/08/elevating-android-security.html)<!-- HN:47464394:end --><!-- HN:47428698:start -->
* [47428698](https://news.social-protocols.org/stats?id=47428698) #28 15 points 9 comments -> [Why One Key Shouldn't Rule Them All: Threshold Signatures for the Rest of Us](https://eric.mann.blog/why-one-key-shouldnt-rule-them-all-threshold-signatures-for-the-rest-of-us/)<!-- HN:47428698:end --><!-- HN:47467415:start -->
* [47467415](https://news.social-protocols.org/stats?id=47467415) #16 12 points 1 comments -> [Israel deliberately targeting medical facilities in south Lebanon](https://www.theguardian.com/world/2026/mar/21/israel-targeting-medical-facilities-south-lebanon-health-workers)<!-- HN:47467415:end --><!-- HN:47468104:start -->
* [47468104](https://news.social-protocols.org/stats?id=47468104) #7 -> [Show HN: A deterministic middleware to compress LLM prompts by 50-80%](https://github.com/ARPAHLS/skillware)<!-- HN:47468104:end --><!-- HN:47468778:start -->
* [47468778](https://news.social-protocols.org/stats?id=47468778) #4 8 points 1 comments -> [Report and receive real-time ICE sighting alerts online in your neighborhood](https://antifreeze.app/)<!-- HN:47468778:end --><!-- HN:47468777:start -->
* [47468777](https://news.social-protocols.org/stats?id=47468777) #24 8 points 0 comments -> [Parents are refusing routine preventive care for newborns](https://apnews.com/article/babies-newborns-pediatricians-vitamin-k-hepatitis-b-erythromycin-9126463f0cb38b9778fb77bc0d071776)<!-- HN:47468777:end --><!-- HN:47469543:start -->
* [47469543](https://news.social-protocols.org/stats?id=47469543) #3 10 points 3 comments -> [Democracy Is a Liability](https://geohot.github.io//blog/jekyll/update/2026/03/21/democracy-liability.html)<!-- HN:47469543:end --><!-- HN:47470120:start -->
* [47470120](https://news.social-protocols.org/stats?id=47470120) #6 2 points 0 comments -> [Microsoft's Year 2000 Resource Center CD](https://huguesjohnson.com/programming/y2k/)<!-- HN:47470120:end --><!-- HN:47429562:start -->
* [47429562](https://news.social-protocols.org/stats?id=47429562) #22 17 points 4 comments -> [I Built a Spy Satellite Simulator in a Browser. Here's What I Learned](https://www.spatialintelligence.ai/p/i-built-a-spy-satellite-simulator)<!-- HN:47429562:end --><!-- HN:47411110:start -->
* [47411110](https://news.social-protocols.org/stats?id=47411110) #8 78 points 9 comments -> [The seven hour explosion nobody could explain](https://phys.org/news/2026-03-hour-explosion.html)<!-- HN:47411110:end --><!-- HN:47413486:start -->
* [47413486](https://news.social-protocols.org/stats?id=47413486) #23 7 points 0 comments -> [Esqueleto Tutorial](https://entropicthoughts.com/esqueleto-tutorial)<!-- HN:47413486:end --><!-- HN:47471120:start -->
* [47471120](https://news.social-protocols.org/stats?id=47471120) #27 8 points 0 comments -> [Prevalence of GenAI sexualized image usage by adolescents in the US](https://journals.plos.org/plosone/article?id=10.1371/journal.pone.0342824)<!-- HN:47471120:end -->
#### **Sunday, March 22, 2026**
<!-- HN:47471805:start -->
* [47471805](https://news.social-protocols.org/stats?id=47471805) #5 68 points 11 comments -> [Attempts to post the latest Trivy security incident have been marked [dead]](https://news.ycombinator.com/from?site=github.com%2Faquasecurity)<!-- HN:47471805:end --><!-- HN:47417424:start -->
* [47417424](https://news.social-protocols.org/stats?id=47417424) #24 18 points 2 comments -> [Welcome to the Block Universe](https://nautil.us/welcome-to-the-block-universe-1278973)<!-- HN:47417424:end --><!-- HN:47475039:start -->
* [47475039](https://news.social-protocols.org/stats?id=47475039) #28 5 points 0 comments -> [Rat King](https://en.wikipedia.org/wiki/Rat_king)<!-- HN:47475039:end --><!-- HN:47475232:start -->
* [47475232](https://news.social-protocols.org/stats?id=47475232) #10 7 points 0 comments -> [We've had front end reactivity since 2018 – via Async Iterables](https://github.com/SacDeNoeuds/yawn)<!-- HN:47475232:end --><!-- HN:47477653:start -->
* [47477653](https://news.social-protocols.org/stats?id=47477653) #29 15 points 9 comments -> [Nintendo's not-AI, not-a-game toy](https://tapestry.news/culture/nintendo-talking-flower/)<!-- HN:47477653:end --><!-- HN:47477491:start -->
* [47477491](https://news.social-protocols.org/stats?id=47477491) #24 9 points 10 comments -> [Show HN: Crack – Turn your MacBook into a squeaky door](http://crackmacapp.com/)<!-- HN:47477491:end --><!-- HN:47477068:start -->
* [47477068](https://news.social-protocols.org/stats?id=47477068) #24 32 points 16 comments -> [Convincing Is Not Persuading](https://blog.alaindichiappari.dev/p/convincing-is-not-persuading)<!-- HN:47477068:end --><!-- HN:47480638:start -->
* [47480638](https://news.social-protocols.org/stats?id=47480638) #4 8 points 1 comments -> [The biggest theft in human history occurred in broad daylight](https://labyrinth.pika.page/posts/the-biggest-theft-in-human-history-occurred-in-broad-daylight)<!-- HN:47480638:end --><!-- HN:47480492:start -->
* [47480492](https://news.social-protocols.org/stats?id=47480492) #13 10 points 1 comments -> [Show HN: A Markdown file that turns your AI agent into an autonomous researcher](https://github.com/krzysztofdudek/ResearcherSkill)<!-- HN:47480492:end --><!-- HN:47480644:start -->
* [47480644](https://news.social-protocols.org/stats?id=47480644) #12 19 points 5 comments -> [Nebraska wildfires leave ranchers scrambling for forage](https://www.farmprogress.com/forage/nebraska-wildfires-leave-ranchers-scrambling-for-forage)<!-- HN:47480644:end --><!-- HN:47482252:start -->
* [47482252](https://news.social-protocols.org/stats?id=47482252) #6 13 points 1 comments -> [AI Is Garbage and a Bubble](https://www.richardcarrier.info/archives/38652)<!-- HN:47482252:end --><!-- HN:47482585:start -->
* [47482585](https://news.social-protocols.org/stats?id=47482585) #12 4 points 0 comments -> [Kash Patel's Nike Shoes Weren't Customized by Nike](https://www.yellopolitics.com/p/kash-patels-garish-custom-shoes-werent)<!-- HN:47482585:end --><!-- HN:47483211:start -->
* [47483211](https://news.social-protocols.org/stats?id=47483211) #9 5 points 0 comments -> [51% of freelancers experience non-payment – payment-gated delivery as a solution](https://proposallock.vercel.app)<!-- HN:47483211:end --><!-- HN:47483233:start -->
* [47483233](https://news.social-protocols.org/stats?id=47483233) #9 8 points 1 comments -> [Supply Chain Attack on Trivy](https://www.wiz.io/blog/trivy-compromised-teampcp-supply-chain-attack)<!-- HN:47483233:end -->
#### **Monday, March 23, 2026**
<!-- HN:47483371:start -->
* [47483371](https://news.social-protocols.org/stats?id=47483371) #10 26 points 14 comments -> [Why I Vibe in Go, Not Rust or Python](https://lifelog.my/episode/why-i-vibe-in-go-not-rust-or-python)<!-- HN:47483371:end --><!-- HN:47487040:start -->
* [47487040](https://news.social-protocols.org/stats?id=47487040) #3 5 points 0 comments -> [GB News seems to have become Reform TV–and Ofcom hasn't stopped it](https://www.prospectmagazine.co.uk/ideas/media/72784/gb-news-reform-tv-no-one-stopped-it)<!-- HN:47487040:end --><!-- HN:47486644:start -->
* [47486644](https://news.social-protocols.org/stats?id=47486644) #2 45 points 38 comments -> [White-Collar AI Apocalypse Narrative Is Just Another Bullshit](https://martynasm.com/2026/03/22/white-collar-ai-apocalypse-narrative-is-just-another-bullshit/)<!-- HN:47486644:end --><!-- HN:47488089:start -->
* [47488089](https://news.social-protocols.org/stats?id=47488089) #23 12 points 7 comments -> [Trump Postpones Iran Energy Strikes for Five Days, Citing "Productive" Talks](https://sharetxt.live/blog/markets-react-as-trump-postpones-strikes-on-irans-power-plants)<!-- HN:47488089:end --><!-- HN:47489662:start -->
* [47489662](https://news.social-protocols.org/stats?id=47489662) #10 12 points 1 comments -> [Wikipedia bans eight editors, six of them anti-Israel](https://www.jns.org/israel-news/wikipedia-bans-8-editors-6-of-them-anti-israel)<!-- HN:47489662:end --><!-- HN:47491117:start -->
* [47491117](https://news.social-protocols.org/stats?id=47491117) #4 10 points 3 comments -> [Sed, a powerfull mini-language from the 70s](https://julienlargetpiet.tech/articles/sed-a-powerfull-mini-language-from-the-70s.html)<!-- HN:47491117:end --><!-- HN:47492285:start -->
* [47492285](https://news.social-protocols.org/stats?id=47492285) #5 -> [Unix philosophy is dead Long live something else?](https://sdomi.pl/weblog/27-manifesto-of-a-burnt-out-hacker/)<!-- HN:47492285:end --><!-- HN:47493312:start -->
* [47493312](https://news.social-protocols.org/stats?id=47493312) #11 -> [The machine didn't take your craft. You gave it up](https://www.davidabram.dev/musings/the-machine-didnt-take-your-craft/)<!-- HN:47493312:end --><!-- HN:47494232:start -->
* [47494232](https://news.social-protocols.org/stats?id=47494232) #9 3 points 1 comments -> [We analyzed 134,000 legal AI interactions. Lawyers still win](https://haqq.ai/whitepaper/legal-ai-index)<!-- HN:47494232:end --><!-- HN:47495168:start -->
* [47495168](https://news.social-protocols.org/stats?id=47495168) #8 -> [The Minimalist Entrepreneur – Claude Code Skills](https://github.com/slavingia/skills)<!-- HN:47495168:end --><!-- HN:47494733:start -->
* [47494733](https://news.social-protocols.org/stats?id=47494733) #27 7 points 2 comments -> [The machine didn't take your craft. You gave it up.](https://www.davidabram.dev/musings/the-machine-didnt-take-your-craft/)<!-- HN:47494733:end --><!-- HN:47495684:start -->
* [47495684](https://news.social-protocols.org/stats?id=47495684) #2 16 points 0 comments -> [FCC Adds Routers Produced in Foreign Countries to Covered List](https://www.fcc.gov/document/fcc-adds-routers-produced-foreign-countries-covered-list)<!-- HN:47495684:end --><!-- HN:47494655:start -->
* [47494655](https://news.social-protocols.org/stats?id=47494655) #24 15 points 12 comments -> [Next-generation electricity is almost here](https://www.gatesnotes.com/work/accelerate-energy-innovation/reader/the-next-generation-of-electricity-is-almost-here)<!-- HN:47494655:end --><!-- HN:47439821:start -->
* [47439821](https://news.social-protocols.org/stats?id=47439821) #20 12 points 1 comments -> [Conway's Game of Life, in real life](https://lcamtuf.coredump.cx/blog/conway/)<!-- HN:47439821:end --><!-- HN:47495820:start -->
* [47495820](https://news.social-protocols.org/stats?id=47495820) #7 11 points 1 comments -> [FCC adds "routers produced in foreign countries" to covered list [pdf]](https://docs.fcc.gov/public/attachments/DA-26-278A1.pdf)<!-- HN:47495820:end --><!-- HN:47495966:start -->
* [47495966](https://news.social-protocols.org/stats?id=47495966) #17 9 points 20 comments -> [Nvidia CEO Jensen Huang says 'I think we've achieved AGI'](https://www.theverge.com/ai-artificial-intelligence/899086/jensen-huang-nvidia-agi)<!-- HN:47495966:end -->
#### **Tuesday, March 24, 2026**
<!-- HN:47496798:start -->
* [47496798](https://news.social-protocols.org/stats?id=47496798) #6 31 points 29 comments -> [No, Windows Start does not use React](https://pathar.tl/blog/no-windows-start-does-not-use-react/)<!-- HN:47496798:end --><!-- HN:47496232:start -->
* [47496232](https://news.social-protocols.org/stats?id=47496232) #9 16 points 4 comments -> [Study: Workers who fall for 'corporate bullshit' may be worse at their jobs](https://www.theguardian.com/business/2026/mar/23/corporate-speak-study)<!-- HN:47496232:end --><!-- HN:47498108:start -->
* [47498108](https://news.social-protocols.org/stats?id=47498108) #2 16 points 2 comments -> [US bans new foreign-made consumer Internet routers](https://www.bbc.com/news/articles/c74787w149zo)<!-- HN:47498108:end --><!-- HN:47498509:start -->
* [47498509](https://news.social-protocols.org/stats?id=47498509) #2 40 points 2 comments -> [Box of Secrets: Discreetly modding an apartment intercom with Matter](https://www.jackhogan.me/blog/box-of-secrets/)<!-- HN:47498509:end --><!-- HN:47499438:start -->
* [47499438](https://news.social-protocols.org/stats?id=47499438) #17 4 points 0 comments -> [systemd has not implemented age verification](https://blog.bofh.it/debian/id_473)<!-- HN:47499438:end --><!-- HN:47433429:start -->
* [47433429](https://news.social-protocols.org/stats?id=47433429) #22 144 points 80 comments -> [Books of the Century by Le Monde](https://standardebooks.org/collections/le-mondes-100-books-of-the-century)<!-- HN:47433429:end --><!-- HN:47499033:start -->
* [47499033](https://news.social-protocols.org/stats?id=47499033) #23 10 points 2 comments -> [Pool spare GPU capacity to run LLMs at larger scale](https://github.com/michaelneale/mesh-llm)<!-- HN:47499033:end --><!-- HN:47500954:start -->
* [47500954](https://news.social-protocols.org/stats?id=47500954) #6 3 points 0 comments -> [Israel's Defense Innovation Industrial Base](https://www.israeltechinsider.com/p/inside-israels-defense-innovation)<!-- HN:47500954:end --><!-- HN:47500823:start -->
* [47500823](https://news.social-protocols.org/stats?id=47500823) #16 15 points 0 comments -> [ICE: $45 an Hour to Stand There. TSA: $0 an Hour to Keep You Safe](https://botonomous.ai/featured/government_shutdown/article-v2.html)<!-- HN:47500823:end --><!-- HN:47502460:start -->
* [47502460](https://news.social-protocols.org/stats?id=47502460) #3 25 points 4 comments -> [Your bridge to wealth is being pulled up](https://danielhomola.com/m%20&%20e/ai/your-bridge-to-wealth-is-being-pulled-up/)<!-- HN:47502460:end --><!-- HN:47503493:start -->
* [47503493](https://news.social-protocols.org/stats?id=47503493) #4 5 points 3 comments -> [The Engineer Who Tried to Put Age Verification into Linux](https://www.sambent.com/the-engineer-who-tried-to-put-age-verification-into-linux-5/)<!-- HN:47503493:end --><!-- HN:47506519:start -->
* [47506519](https://news.social-protocols.org/stats?id=47506519) #1 94 points 56 comments -> [FCC has banned the import of all new foreign-made routers here's what you can do](https://blog.adafruit.com/2026/03/24/fcc-just-banned-the-import-of-all-new-foreign-made-routers-heres-what-you-can-do-about-it/)<!-- HN:47506519:end --><!-- HN:47501729:start -->
* [47501729](https://news.social-protocols.org/stats?id=47501729) #9 701 points 1 comments -> [LiteLLM Python package compromised by supply-chain attack](https://github.com/BerriAI/litellm/issues/24512)<!-- HN:47501729:end --><!-- HN:47431465:start -->
* [47431465](https://news.social-protocols.org/stats?id=47431465) #18 12 points 0 comments -> [Building Liberal Compute](https://simongrimm.substack.com/p/building-liberal-compute)<!-- HN:47431465:end --><!-- HN:47439413:start -->
* [47439413](https://news.social-protocols.org/stats?id=47439413) #24 123 points 131 comments -> [No-build, no-NPM, SSR-first JavaScript framework if you hate React, love HTML](https://qitejs.qount25.dev)<!-- HN:47439413:end --><!-- HN:47510657:start -->
* [47510657](https://news.social-protocols.org/stats?id=47510657) #11 10 points 3 comments -> [Thoughts on LLMs – Psychological Complications](https://parsingphase.dev/tech/LLMs/psychologicalFactors.html)<!-- HN:47510657:end --><!-- HN:47509234:start -->
* [47509234](https://news.social-protocols.org/stats?id=47509234) #5 197 points 1 comments -> [Disney Exits OpenAI Deal After AI Giant Shutters Sora](https://www.hollywoodreporter.com/business/digital/openai-shutting-down-sora-ai-video-app-1236546187/)<!-- HN:47509234:end -->
#### **Wednesday, March 25, 2026**
<!-- HN:47513098:start -->
* [47513098](https://news.social-protocols.org/stats?id=47513098) #22 69 points 27 comments -> [Meta ordered to pay $375M in New Mexico trial over child exploitation](https://www.reuters.com/sustainability/boards-policy-regulation/jury-orders-meta-pay-375-mln-new-mexico-lawsuit-over-child-sexual-exploitation-2026-03-24/)<!-- HN:47513098:end --><!-- HN:47517904:start -->
* [47517904](https://news.social-protocols.org/stats?id=47517904) #25 6 points 0 comments -> [Palestinians warn of expanding West Bank settler violence](https://www.bbc.com/news/articles/c747x00m83vo)<!-- HN:47517904:end --><!-- HN:47519114:start -->
* [47519114](https://news.social-protocols.org/stats?id=47519114) #8 4 points 0 comments -> [Death by Clawd](https://deathbyclawd.com)<!-- HN:47519114:end --><!-- HN:47520825:start -->
* [47520825](https://news.social-protocols.org/stats?id=47520825) #9 10 points 4 comments -> [I bought the MacBook Neo and it sucks](https://alexandmanu.com/blog/the-macbook-neo-disappointment/)<!-- HN:47520825:end --><!-- HN:47519625:start -->
* [47519625](https://news.social-protocols.org/stats?id=47519625) #3 271 points 53 comments -> [Jury says Meta knowingly harmed children for profit, awarding landmark verdict](https://www.latimes.com/business/story/2026-03-25/jury-says-meta-knowingly-harmed-children-for-profit-awarding-landmark-verdict)<!-- HN:47519625:end --><!-- HN:47521766:start -->
* [47521766](https://news.social-protocols.org/stats?id=47521766) #3 9 points 4 comments -> [Model collapse is already happening](https://cacm.acm.org/blogcacm/model-collapse-is-already-happening-we-just-pretend-it-isnt/)<!-- HN:47521766:end --><!-- HN:47520717:start -->
* [47520717](https://news.social-protocols.org/stats?id=47520717) #4 91 points 1 comments -> [Meta and Google found liable in social media addiction trial](https://www.bbc.co.uk/news/articles/c747x7gz249o)<!-- HN:47520717:end --><!-- HN:47518785:start -->
* [47518785](https://news.social-protocols.org/stats?id=47518785) #24 144 points 2 comments -> [Sony V. Cox Decision Reversed](https://supreme.justia.com/cases/federal/us/607/24-171/)<!-- HN:47518785:end --><!-- HN:47522238:start -->
* [47522238](https://news.social-protocols.org/stats?id=47522238) #13 9 points 2 comments -> [ARC-AGI-3 benchmark is out now](https://arcprize.org/tasks/ls20)<!-- HN:47522238:end --><!-- HN:47523053:start -->
* [47523053](https://news.social-protocols.org/stats?id=47523053) #11 5 points 1 comments -> [Supreme Court rules ISPs aren't liable for subscribers' music piracy](https://www.engadget.com/entertainment/streaming/supreme-court-rules-isps-arent-liable-for-subscribers-music-piracy-163412791.html)<!-- HN:47523053:end --><!-- HN:47522492:start -->
* [47522492](https://news.social-protocols.org/stats?id=47522492) #20 5 points 3 comments -> [Tired of Ghost Positions in Companies?](https://ghostjobs.net)<!-- HN:47522492:end --><!-- HN:47524633:start -->
* [47524633](https://news.social-protocols.org/stats?id=47524633) #29 10 points 0 comments -> [ICE has been lying about being authorized to make arrests at immigration courts](https://bsky.app/profile/bradlander.bsky.social/post/3mhvpk32vxc2e)<!-- HN:47524633:end -->
#### **Thursday, March 26, 2026**
<!-- HN:47481983:start -->
* [47481983](https://news.social-protocols.org/stats?id=47481983) #17 6 points 0 comments -> [We Solved the Recording Problem. The Playback Problem Is Still Broken](https://medium.com/@jo.sagar/we-solved-the-recording-problem-the-playback-problem-is-still-broken-1768038911b3)<!-- HN:47481983:end --><!-- HN:47526276:start -->
* [47526276](https://news.social-protocols.org/stats?id=47526276) #8 19 points 11 comments -> [Show HN: Nit – I rebuilt Git in Zig to save AI agents 71% on tokens](https://justfielding.com/blog/nit-replacing-git-with-zig)<!-- HN:47526276:end --><!-- HN:47528380:start -->
* [47528380](https://news.social-protocols.org/stats?id=47528380) #4 35 points 32 comments -> [Why Sora Failed: $15M/day inference cost vs. $2.1M lifetime revenue](https://www.revolutioninai.com/2026/03/%20chatgpt-gpt-54-mini-silent-switch-march-2026.html)<!-- HN:47528380:end --><!-- HN:47528683:start -->
* [47528683](https://news.social-protocols.org/stats?id=47528683) #19 10 points 17 comments -> [Show HN: Relay – The open-source Claude Cowork for OpenClaw](https://github.com/SeventeenLabs/relay)<!-- HN:47528683:end -->