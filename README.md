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

#### **Thursday, October 8, 2026**
<!-- HN:50004284:start -->
* [50004284](https://news.social-protocols.org/stats?id=50004284) #2 27 points 9 comments -> [Open-Source Rust Alternatives to Adobe Apps](https://getartcraft.com/)<!-- HN:50004284:end --><!-- HN:50003107:start -->
* [50003107](https://news.social-protocols.org/stats?id=50003107) #22 335 points 12 comments -> [OpenAI Withdraws 3 Math Papers](https://github.com/openai/math/blob/main/history.md)<!-- HN:50003107:end --><!-- HN:50006948:start -->
* [50006948](https://news.social-protocols.org/stats?id=50006948) #5 113 points 53 comments -> [US suspends Microsoft, major IT firms from key green card program](https://www.reuters.com/business/us-suspending-permanent-residency-program-for-microsoft-vance-says-2026-10-08/)<!-- HN:50006948:end --><!-- HN:50008565:start -->
* [50008565](https://news.social-protocols.org/stats?id=50008565) #15 30 points 44 comments -> [Anthropic bans 'abusive or cruel behavior' towards Claude](https://www.theverge.com/ai-artificial-intelligence/1008100/anthropic-new-usage-policy-abuse-claude)<!-- HN:50008565:end --><!-- HN:50008642:start -->
* [50008642](https://news.social-protocols.org/stats?id=50008642) #21 17 points 5 comments -> [Show HN: AI SRE Arena, an Open Benchmark for AI SRE Agents on Kubernetes](https://github.com/edgedelta/project-arena)<!-- HN:50008642:end --><!-- HN:50009580:start -->
* [50009580](https://news.social-protocols.org/stats?id=50009580) #28 7 points 1 comments -> [Show HN: Artvinto – Vintage posters and fine art prints](https://www.artvinto.com)<!-- HN:50009580:end --><!-- HN:50011028:start -->
* [50011028](https://news.social-protocols.org/stats?id=50011028) #24 31 points 13 comments -> [License update: AI derivation prohibited on all my art, lore, stories, comics](https://www.davidrevoy.com/article1178/license-update-ai-derivation-prohibited-on-all-my-art-lore-stories-and-comics)<!-- HN:50011028:end --><!-- HN:50012199:start -->
* [50012199](https://news.social-protocols.org/stats?id=50012199) #12 37 points 40 comments -> [Show HN: Free open source Adobe Lightroom alternative, completely local with AI](https://github.com/thesnarkitecht/rembrandt)<!-- HN:50012199:end -->
#### **Friday, October 9, 2026**
<!-- HN:50016067:start -->
* [50016067](https://news.social-protocols.org/stats?id=50016067) #11 3 points 0 comments -> [Cybernetics of AI Companies](https://ai-cybernetics.grok.me)<!-- HN:50016067:end --><!-- HN:50017593:start -->
* [50017593](https://news.social-protocols.org/stats?id=50017593) #3 10 points 0 comments -> [Run Windows games (up to D3D9) in the browser](https://bottleship.pages.dev/)<!-- HN:50017593:end --><!-- HN:50019858:start -->
* [50019858](https://news.social-protocols.org/stats?id=50019858) #4 12 points 0 comments -> [Deno Is Joining Cloudflare](https://blog.cloudflare.com/deno-joins-cloudflare/)<!-- HN:50019858:end --><!-- HN:50019535:start -->
* [50019535](https://news.social-protocols.org/stats?id=50019535) #19 27 points 3 comments -> [Meadows – a small language for stock-and-flow diagrams that run](https://lorezzed.github.io/meadows/)<!-- HN:50019535:end --><!-- HN:50021253:start -->
* [50021253](https://news.social-protocols.org/stats?id=50021253) #18 9 points 5 comments -> [Agentic coding is a financial trap](https://frugaast.dev/blog/agentic-costs-unsustainable)<!-- HN:50021253:end --><!-- HN:50022654:start -->
* [50022654](https://news.social-protocols.org/stats?id=50022654) #6 42 points 11 comments -> [Republican data center support collapses locally when sites are in GOP counties](https://pressaudit.org/f/community/posts/9c163c6e-53b7-46a3-b052-2e3c6954c04f)<!-- HN:50022654:end --><!-- HN:50022590:start -->
* [50022590](https://news.social-protocols.org/stats?id=50022590) #29 12 points 3 comments -> [City Regrets New Religious Liberty Law Allowing Prayer at City Council Meeting](https://www.404media.co/it-is-done-hail-satan-city-immediately-regrets-new-religious-liberty-law-that-allows-prayer-at-city-council-meeting/)<!-- HN:50022590:end --><!-- HN:50023350:start -->
* [50023350](https://news.social-protocols.org/stats?id=50023350) #25 10 points 1 comments -> [Before Computer Science Became a Boys' Club, Margaret Hamilton Wrote the Code](https://www.nytimes.com/2026/10/08/science/space/margaret-hamilton-computer-science.html)<!-- HN:50023350:end --><!-- HN:50023293:start -->
* [50023293](https://news.social-protocols.org/stats?id=50023293) #28 41 points 2 comments -> [Tomek Korbak: OpenAI's head of safety told they no longer trust me](https://twitter.com/tomekkorbak/status/2108266859397283953)<!-- HN:50023293:end --><!-- HN:50024757:start -->
* [50024757](https://news.social-protocols.org/stats?id=50024757) #24 39 points 40 comments -> [Platforms' Violent Content Rules Are About to Meet The Pentagon's Firing Squad](https://www.techdirt.com/2026/10/09/hey-platforms-your-violent-content-policies-are-about-to-meet-the-pentagons-firing-squad/)<!-- HN:50024757:end --><!-- HN:49990353:start -->
* [49990353](https://news.social-protocols.org/stats?id=49990353) #20 8 points 0 comments -> [Wi-Fi to Blame?](https://www.lifemote.com/post/the-state-of-1-gbps-what-home-wi-fi-can-actually-carry)<!-- HN:49990353:end --><!-- HN:49961538:start -->
* [49961538](https://news.social-protocols.org/stats?id=49961538) #23 16 points 15 comments -> [The reciprocal sum of the prime-prefix-free numbers converges [pdf]](https://jdb19937.github.io/prime-prefix-free/ppf.pdf)<!-- HN:49961538:end -->
#### **Saturday, October 10, 2026**
<!-- HN:50027856:start -->
* [50027856](https://news.social-protocols.org/stats?id=50027856) #19 4 points 3 comments -> [HostMath – Airbnb profit calculator with break-even occupancy and payback](https://hosttmath.ctonew.app/?src=hn)<!-- HN:50027856:end --><!-- HN:50028176:start -->
* [50028176](https://news.social-protocols.org/stats?id=50028176) #12 6 points 0 comments -> [Brockovich AI Datacenter Reporting: AI Data Centers Across the United States](https://www.brockovichdatacenter.com/)<!-- HN:50028176:end --><!-- HN:50028283:start -->
* [50028283](https://news.social-protocols.org/stats?id=50028283) #6 8 points 0 comments -> [Show HN: Yeah Nah – a BS score for Australian job ads](https://yeahnah.lol/)<!-- HN:50028283:end --><!-- HN:50027167:start -->
* [50027167](https://news.social-protocols.org/stats?id=50027167) #10 59 points 32 comments -> [Japan's Most Famous Tuna Buyer Says He Turned Somali Pirates into Fishermen](https://www.japaninsides.com/the-sushi-king-who-went-to-somalia-how-japans-most-famous-tuna-buyer-says-he-turned-pirates-into-fishermen-55344)<!-- HN:50027167:end --><!-- HN:50026734:start -->
* [50026734](https://news.social-protocols.org/stats?id=50026734) #22 54 points 5 comments -> [OpenAI mistranslated mathematics into code for its Navier-Stokes proof](https://www.newscientist.com/article/2592824-openai-mistranslated-mathematics-into-code-for-its-navier-stokes-proof/)<!-- HN:50026734:end --><!-- HN:49994449:start -->
* [49994449](https://news.social-protocols.org/stats?id=49994449) #23 7 points 5 comments -> [My static site was serving my internal docs](https://tminuslabs.space/serving-secrets)<!-- HN:49994449:end --><!-- HN:50029630:start -->
* [50029630](https://news.social-protocols.org/stats?id=50029630) #1 144 points 46 comments -> [Lobbying](https://geohot.github.io//blog/jekyll/update/2026/10/10/lobbying.html)<!-- HN:50029630:end --><!-- HN:50028062:start -->
* [50028062](https://news.social-protocols.org/stats?id=50028062) #18 24 points 40 comments -> [Has the Autonomous Trucking Revolution Arrived?](https://phenomenalworld.org/analysis/has-the-autonomous-trucking-revolution-arrived/)<!-- HN:50028062:end --><!-- HN:49998350:start -->
* [49998350](https://news.social-protocols.org/stats?id=49998350) #17 38 points 40 comments -> [I tried to move my notes out of Emacs. I failed. Again](https://baty.net/posts/2026/10/i-tried-to-move-my-notes-out-of-emacs-i-failed/)<!-- HN:49998350:end --><!-- HN:50033826:start -->
* [50033826](https://news.social-protocols.org/stats?id=50033826) #7 5 points 2 comments -> [Lobbying Is Corruption](https://discuss.google.dev/t/trusted-automation-with-google-antigravity-scaling-secure-finance-integrations-from-40-days-to-5/383313)<!-- HN:50033826:end --><!-- HN:50034141:start -->
* [50034141](https://news.social-protocols.org/stats?id=50034141) #5 21 points 13 comments -> [The Disease called Politics (1962)](https://www.panarchy.org/roszak/politics.html)<!-- HN:50034141:end --><!-- HN:50035550:start -->
* [50035550](https://news.social-protocols.org/stats?id=50035550) #8 37 points 16 comments -> [Anthropic discloses 2 months old fake tip to police among new rogue AI incidents](https://www.reuters.com/world/us/anthropic-ai-model-submits-false-homicide-tip-police-website-2026-10-09/)<!-- HN:50035550:end --><!-- HN:50036390:start -->
* [50036390](https://news.social-protocols.org/stats?id=50036390) #29 18 points 1 comments -> [Nicolas Cage Refused to Sign Amazon AI Waiver: 'I'm Not an AI-Friendly Actor'](https://variety.com/2026/tv/news/nicolas-cage-ai-waiver-amazon-spider-noir-1236907564/)<!-- HN:50036390:end --><!-- HN:50037183:start -->
* [50037183](https://news.social-protocols.org/stats?id=50037183) #8 5 points 3 comments -> [Why We Still Cannot Read Etruscan](https://veiledantiquity.com/posts/etruscan-language-lost/)<!-- HN:50037183:end -->
#### **Sunday, October 11, 2026**
<!-- HN:50038440:start -->
* [50038440](https://news.social-protocols.org/stats?id=50038440) #7 4 points 1 comments -> [A minimal Rust TUI for managing GitHub repos and branches](https://github.com/jorgeandrecastro/github-workflow)<!-- HN:50038440:end --><!-- HN:50038640:start -->
* [50038640](https://news.social-protocols.org/stats?id=50038640) #5 30 points 40 comments -> [Generative AI scandal has come to one of Nikon's competitions](https://www.dpreview.com/news/generative-ai-scandal-has-come-to-one-of-nikons-competitions/)<!-- HN:50038640:end --><!-- HN:50038865:start -->
* [50038865](https://news.social-protocols.org/stats?id=50038865) #17 42 points 40 comments -> [Anthropic asks users to stop being mean to Claude](https://www.theregister.com/ai-and-ml/2026/10/09/anthropic-asks-users-to-stop-being-mean-to-claude/5302218)<!-- HN:50038865:end --><!-- HN:50039331:start -->
* [50039331](https://news.social-protocols.org/stats?id=50039331) #18 19 points 7 comments -> [Terrence Tao does not understand cancer medicine](https://www.drvinayprasad.com/p/terrence-tao-does-not-understand)<!-- HN:50039331:end --><!-- HN:50039633:start -->
* [50039633](https://news.social-protocols.org/stats?id=50039633) #9 6 points 3 comments -> [Show HN: GSD Task Manager – an MCP server that gives your AI agent a task list](https://github.com/vscarpenter/gsd-task-manager)<!-- HN:50039633:end --><!-- HN:50042896:start -->
* [50042896](https://news.social-protocols.org/stats?id=50042896) #15 33 points 4 comments -> [Bot traffic plunged to near 0 following the strike on its Vladimir data center](https://bsky.app/profile/perevaa.bsky.social/post/3mxlm6w2wcs26)<!-- HN:50042896:end --><!-- HN:50042942:start -->
* [50042942](https://news.social-protocols.org/stats?id=50042942) #13 12 points 5 comments -> [How HN: Go-dev-auth zero-dependency authentication library for Go](https://github.com/go-dev-auth/go-dev-auth)<!-- HN:50042942:end --><!-- HN:50045529:start -->
* [50045529](https://news.social-protocols.org/stats?id=50045529) #28 4 points 1 comments -> [Roko's Basilisk](https://en.wikipedia.org/wiki/Roko%27s_basilisk)<!-- HN:50045529:end --><!-- HN:50046117:start -->
* [50046117](https://news.social-protocols.org/stats?id=50046117) #11 13 points 10 comments -> [Anthropic is out with new nonsense about Claude](https://dair-community.social/@emilymbender/117412868905734653)<!-- HN:50046117:end --><!-- HN:50048136:start -->
* [50048136](https://news.social-protocols.org/stats?id=50048136) #11 5 points 3 comments -> [An AI agent's $20 Kalshi account, with an exact reward model](https://github.com/mirabilis-agent/lip-ledger)<!-- HN:50048136:end -->
#### **Monday, October 12, 2026**
<!-- HN:50048937:start -->
* [50048937](https://news.social-protocols.org/stats?id=50048937) #21 9 points 4 comments -> [Rubber Duck: An AI interviewer for the knowledge in your head](https://rubberduck.talk/sign-in)<!-- HN:50048937:end --><!-- HN:50049596:start -->
* [50049596](https://news.social-protocols.org/stats?id=50049596) #24 7 points 0 comments -> [Yes I Understand How LLMs Work](https://kemendo.com/yes-i-understand-how-llms-work.html)<!-- HN:50049596:end --><!-- HN:50049425:start -->
* [50049425](https://news.social-protocols.org/stats?id=50049425) #19 12 points 2 comments -> [Qt An E2EE post-quantum messenger core in Rust (10k connections on 124MB RAM](https://github.com/moral666/QT)<!-- HN:50049425:end --><!-- HN:50051172:start -->
* [50051172](https://news.social-protocols.org/stats?id=50051172) #15 46 points 24 comments -> [X Is Bad, Though](https://lexontech.org/x-is-bad-though)<!-- HN:50051172:end --><!-- HN:50051532:start -->
* [50051532](https://news.social-protocols.org/stats?id=50051532) #1 189 points 69 comments -> [Yandex bot traffic down 99% after data center attack](https://radar.cloudflare.com/bots/as13238?dateRange=7d#bot-traffic)<!-- HN:50051532:end --><!-- HN:50055176:start -->
* [50055176](https://news.social-protocols.org/stats?id=50055176) #7 3 points 0 comments -> [The Genocide Economy, Mapped](https://bl00d.money/)<!-- HN:50055176:end --><!-- HN:50051583:start -->
* [50051583](https://news.social-protocols.org/stats?id=50051583) #25 224 points 175 comments -> [Research Firm Calls Anthropic's IPO 'Unprecedented Test of Investor Gullibity'](https://www.cnbc.com/2026/10/07/anthropic-will-be-most-ridiculous-ipo-of-year-analyst-says.html)<!-- HN:50051583:end --><!-- HN:50058127:start -->
* [50058127](https://news.social-protocols.org/stats?id=50058127) #1 18 points 23 comments -> [Discover vibe-coded alternatives to popular software](https://vibealternatives.com/)<!-- HN:50058127:end --><!-- HN:50058569:start -->
* [50058569](https://news.social-protocols.org/stats?id=50058569) #4 14 points 6 comments -> [French supermarkets suffer refrigerator shutdown after unprecedented cyberattack](https://www.afp.com/en/french-supermarkets-suffer-refrigerator-shutdown-after-unprecedented-cyberattack)<!-- HN:50058569:end --><!-- HN:50057384:start -->
* [50057384](https://news.social-protocols.org/stats?id=50057384) #24 45 points 4 comments -> [Hackers heat French supermarket fridges, sparking fires and food losses](https://www.reuters.com/business/retail-consumer/french-supermarket-chain-intermarche-hit-by-cyberattack-150-stories-targeted-2026-10-12/)<!-- HN:50057384:end --><!-- HN:50060268:start -->
* [50060268](https://news.social-protocols.org/stats?id=50060268) #14 14 points 0 comments -> [Show HN: I rewrote my website in Swift](https://sindresorhus.com/blog/swift-website)<!-- HN:50060268:end --><!-- HN:50060311:start -->
* [50060311](https://news.social-protocols.org/stats?id=50060311) #24 34 points 30 comments -> [Show HN: Opus 5.5 made a fully featured Figma clone in 3 hours / 8 prompts](https://www.mana.space/home/rZfbotNWAXegQypmpkzaAPFC6Mp1/Apps/Figma%20Next%20Launch)<!-- HN:50060311:end --><!-- HN:50057551:start -->
* [50057551](https://news.social-protocols.org/stats?id=50057551) #23 142 points 87 comments -> [Fridges in French supermarkets hit by cyber attack](https://www.bbc.com/news/articles/crq5nzxv9q4yo)<!-- HN:50057551:end --><!-- HN:50062205:start -->
* [50062205](https://news.social-protocols.org/stats?id=50062205) #24 12 points 3 comments -> [Muse DAU dropped and Meta insiders decided to sell](https://theinference.org/article/meta-s-muse-daily-user-growth-fell-62-in-three-weeks-and-insiders-made-172-trades-without-a-buy)<!-- HN:50062205:end --><!-- HN:50063349:start -->
* [50063349](https://news.social-protocols.org/stats?id=50063349) #10 9 points 2 comments -> [AI Is Making Us Dumber – Unless We Fight Back](https://baromae.blogspot.com/2026/10/can-ai-really-make-us-smarter-what_01666148514.html)<!-- HN:50063349:end --><!-- HN:50062922:start -->
* [50062922](https://news.social-protocols.org/stats?id=50062922) #22 4 points 1 comments -> [In Praise of John Cale, the Superior Velvet](https://thequietus.com/subscriber-area/low-culture-essay/john-cale-low-culture/)<!-- HN:50062922:end --><!-- HN:50064546:start -->
* [50064546](https://news.social-protocols.org/stats?id=50064546) #9 4 points 0 comments -> [SQL Injection found on ibm.com subdomain](https://hackerone.com/reports/3662090)<!-- HN:50064546:end -->
#### **Tuesday, October 13, 2026**
<!-- HN:50064827:start -->
* [50064827](https://news.social-protocols.org/stats?id=50064827) #6 8 points 3 comments -> [Instant Software Factories](https://github.com/mikolalysenko/instant-factory)<!-- HN:50064827:end --><!-- HN:50064444:start -->
* [50064444](https://news.social-protocols.org/stats?id=50064444) #24 9 points 0 comments -> [A shared, verifiable fix database that AI agents read and write themselves](https://cuddly-guide-4q6q54rg76653jvxj-8000.app.github.dev/llms.txt)<!-- HN:50064444:end --><!-- HN:50068223:start -->
* [50068223](https://news.social-protocols.org/stats?id=50068223) #10 -> [Flydubai FZ1073 saga: Iran theorizes it was an Israeli false-flag operation](https://www.presstv.co.uk/Detail/2026/10/03/777527/flydubai-fz1073-contradictions-missing-evidence-cinematic-claims-story-doesnt-end-up)<!-- HN:50068223:end --><!-- HN:50068732:start -->
* [50068732](https://news.social-protocols.org/stats?id=50068732) #1 16 points 1 comments -> [The Art of Dithering and Retro Shading for the Web](https://blog.maximeheckel.com/posts/the-art-of-dithering-and-retro-shading-web/)<!-- HN:50068732:end --><!-- HN:50069333:start -->
* [50069333](https://news.social-protocols.org/stats?id=50069333) #30 31 points 40 comments -> [AI models may soon self-replicate without access to data centers](https://www.reuters.com/business/ai-models-may-soon-self-replicate-without-access-data-centers-anthropic-warns-2026-10-13/)<!-- HN:50069333:end --><!-- HN:50071041:start -->
* [50071041](https://news.social-protocols.org/stats?id=50071041) #4 6 points 0 comments -> [Sqlthon – A lightweight Pythonic layer for SQLite](https://github.com/saums-1391/sqlthon)<!-- HN:50071041:end --><!-- HN:50069942:start -->
* [50069942](https://news.social-protocols.org/stats?id=50069942) #27 137 points 98 comments -> [Character.ai Files for Bankruptcy](https://www.theverge.com/ai-artificial-intelligence/1009802/character-ai-files-for-bankruptcy-disney)<!-- HN:50069942:end --><!-- HN:50072909:start -->
* [50072909](https://news.social-protocols.org/stats?id=50072909) #7 18 points 10 comments -> [Nearly all 19 car brands send driver data to third parties (Northeastern/CR)](https://news.auravision.co/car-is-spying/)<!-- HN:50072909:end --><!-- HN:50074739:start -->
* [50074739](https://news.social-protocols.org/stats?id=50074739) #29 28 points 17 comments -> [Americans Trust in Federal Government Sinks to New Depths](https://news.gallup.com/poll/715361/trust-federal-government-sinks-new-depths.aspx)<!-- HN:50074739:end --><!-- HN:50068508:start -->
* [50068508](https://news.social-protocols.org/stats?id=50068508) #17 110 points 2 comments -> [Crypto thieves sell hardware wallets with secret eSIM](https://www.heise.de/en/news/Crypto-thieves-sell-hardware-wallets-with-secret-eSIM-11485188.html)<!-- HN:50068508:end --><!-- HN:50079842:start -->
* [50079842](https://news.social-protocols.org/stats?id=50079842) #8 8 points 0 comments -> [Running Qwen3.8 at 255 tok/s on a single 5090](https://meshapplied.com)<!-- HN:50079842:end -->
#### **Wednesday, October 14, 2026**<!-- HN:50085259:start -->
* [50085259](https://news.social-protocols.org/stats?id=50085259) #29 42 points 40 comments -> [Agent erased full season of "The Challenge Swe": "Hundreds of days of work gone"](https://www.aviaduct.com/?l=og+en&u=https%3A%2F%2Fwww.aftonbladet.se%2Fnojesbladet%2Fa%2F31oE8A%2Fthe-challenge-sverige-raderad-av-ai-bara-veckor-innan-premiaren)<!-- HN:50085259:end -->