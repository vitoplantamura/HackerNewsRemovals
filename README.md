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

#### **Sunday, March 8, 2026**
<!-- HN:47292849:start -->
* [47292849](https://news.social-protocols.org/stats?id=47292849) #29 11 points 1 comments -> [Patel gutted FBI counterintelligence team tasked with tracking Iranian threats](https://www.cnn.com/2026/03/03/politics/patel-fbi-national-security-division-firings-iran)<!-- HN:47292849:end --><!-- HN:47292841:start -->
* [47292841](https://news.social-protocols.org/stats?id=47292841) #17 24 points 31 comments -> [Ghostmd: Ghostty but for Markdown Notes](https://mimoo.github.io/ghostmd/)<!-- HN:47292841:end --><!-- HN:47293514:start -->
* [47293514](https://news.social-protocols.org/stats?id=47293514) #20 36 points 21 comments -> [Iranian Women Graduate in Stem 3× the Rate of U.S. Women and Has 5× More PhDs](https://hrnews1.substack.com/p/iranian-women-graduate-in-stem-at)<!-- HN:47293514:end --><!-- HN:47294008:start -->
* [47294008](https://news.social-protocols.org/stats?id=47294008) #22 32 points 29 comments -> [Israel Strikes Oil Facilities in Iran](https://www.nytimes.com/2026/03/07/world/middleeast/israel-iran-oil-strikes.html)<!-- HN:47294008:end --><!-- HN:47294082:start -->
* [47294082](https://news.social-protocols.org/stats?id=47294082) #19 8 points 2 comments -> [Americans Are Now a Target for ICE](https://www.wsj.com/us-news/immigration-protests-noem-minneapolis-0b8bd496)<!-- HN:47294082:end --><!-- HN:47296787:start -->
* [47296787](https://news.social-protocols.org/stats?id=47296787) #10 16 points 17 comments -> [You Don't Need a Vector Database](https://vecstore.app/blog/you-dont-need-a-vector-database)<!-- HN:47296787:end --><!-- HN:47261529:start -->
* [47261529](https://news.social-protocols.org/stats?id=47261529) #18 5 points 1 comments -> [We Turned Our Wireshark Wizard into a Markdown File](https://www.checklyhq.com/blog/building-an-ai-agent/)<!-- HN:47261529:end --><!-- HN:47300560:start -->
* [47300560](https://news.social-protocols.org/stats?id=47300560) #10 7 points 1 comments -> [Show HN: WhatsApp Clone – No Setup or Signup](https://positive-intentions.com/)<!-- HN:47300560:end --><!-- HN:47302494:start -->
* [47302494](https://news.social-protocols.org/stats?id=47302494) #16 4 points 0 comments -> [The Making and Unraveling of the American–Israeli Alliance](https://egyptianstreets.com/2026/03/06/the-making-and-unraveling-of-the-american-israeli-alliance/)<!-- HN:47302494:end -->
#### **Monday, March 9, 2026**
<!-- HN:47239117:start -->
* [47239117](https://news.social-protocols.org/stats?id=47239117) #19 117 points 62 comments -> [Log messages are mostly for the people operating your software](https://utcc.utoronto.ca/~cks/space/blog/programming/LogMessagesAreForOperation)<!-- HN:47239117:end --><!-- HN:47248801:start -->
* [47248801](https://news.social-protocols.org/stats?id=47248801) #21 6 points 0 comments -> [Some Lotto Math](https://leancrew.com/all-this/2025/12/some-lotto-math/)<!-- HN:47248801:end --><!-- HN:47266919:start -->
* [47266919](https://news.social-protocols.org/stats?id=47266919) #23 16 points 5 comments -> [Are You Noticing This?](https://ryanholiday.net/are-you-noticing-this/)<!-- HN:47266919:end --><!-- HN:47306157:start -->
* [47306157](https://news.social-protocols.org/stats?id=47306157) #2 55 points 13 comments -> [Grammarly is using our identities without permission](https://www.theverge.com/ai-artificial-intelligence/890921/grammarly-ai-expert-reviews)<!-- HN:47306157:end --><!-- HN:47306692:start -->
* [47306692](https://news.social-protocols.org/stats?id=47306692) #5 6 points 0 comments -> [Every business will have AGI by 2027](https://nuggetz.ai/articles/every-business-will-have-agi-by-2027)<!-- HN:47306692:end --><!-- HN:47306447:start -->
* [47306447](https://news.social-protocols.org/stats?id=47306447) #11 8 points 10 comments -> [MiniMax Music 2.5 – AI Music Generation Model for Fast Song Creation](https://www.minimax-music.com/minimax-music-2-5)<!-- HN:47306447:end --><!-- HN:47307837:start -->
* [47307837](https://news.social-protocols.org/stats?id=47307837) #30 6 points 3 comments -> [Grok sparks outrage after chatbot makes offensive jibes about football disasters](https://www.theregister.com/2026/03/09/grok_football_controvery/)<!-- HN:47307837:end --><!-- HN:47308468:start -->
* [47308468](https://news.social-protocols.org/stats?id=47308468) #20 70 points 37 comments -> [Owner of ICE detention facility sees big opportunity in AI man camps](https://techcrunch.com/2026/03/08/owner-of-ice-detention-facility-sees-big-opportunity-in-ai-man-camps/)<!-- HN:47308468:end --><!-- HN:47309655:start -->
* [47309655](https://news.social-protocols.org/stats?id=47309655) #23 23 points 12 comments -> [Global Stocks Sink as Oil Prices Surge](https://www.nytimes.com/2026/03/09/business/stocks-iran-oil.html)<!-- HN:47309655:end --><!-- HN:47309790:start -->
* [47309790](https://news.social-protocols.org/stats?id=47309790) #15 9 points 0 comments -> [India offered sanctuary to Iranian ship three days before US sank it](https://www.bbc.com/news/articles/c2e4yxj0pd3o)<!-- HN:47309790:end --><!-- HN:47311077:start -->
* [47311077](https://news.social-protocols.org/stats?id=47311077) #21 71 points 31 comments -> [US missile hit military base near Iran school, video analysis shows](https://www.bbc.com/news/articles/cvg548lyjnyo)<!-- HN:47311077:end --><!-- HN:47311798:start -->
* [47311798](https://news.social-protocols.org/stats?id=47311798) #30 6 points 0 comments -> [Video appears to show U.S. cruise missile striking Iranian school compound](https://www.npr.org/2026/03/08/nx-s1-5739395/iran-school-airstrike-tomahawk-missile-trump)<!-- HN:47311798:end --><!-- HN:47311745:start -->
* [47311745](https://news.social-protocols.org/stats?id=47311745) #9 16 points 7 comments -> [The 1979 Design Choice Breaking AI Workloads](https://www.cerebrium.ai/blog/rethinking-container-image-distribution-to-eliminate-cold-starts)<!-- HN:47311745:end --><!-- HN:47312946:start -->
* [47312946](https://news.social-protocols.org/stats?id=47312946) #12 5 points 1 comments -> [UK Cryptography Developer claims IP to protect UK National Security was stolen](https://lists.libre-soc.org/pipermail/libre-soc-dev/2026-March/007164.html)<!-- HN:47312946:end --><!-- HN:47314036:start -->
* [47314036](https://news.social-protocols.org/stats?id=47314036) #6 10 points 0 comments -> [AI Didn't Break the Senior Engineer Pipeline. It Showed That One Never Existed](https://blog.bryanl.dev/posts/ai-senior-engineer-pipeline/)<!-- HN:47314036:end --><!-- HN:47313993:start -->
* [47313993](https://news.social-protocols.org/stats?id=47313993) #29 8 points 1 comments -> [Teenagers report for duty as Croatia reinstates conscription](https://www.bbc.com/news/articles/c93j2l32lzgo)<!-- HN:47313993:end -->
#### **Tuesday, March 10, 2026**
<!-- HN:47317115:start -->
* [47317115](https://news.social-protocols.org/stats?id=47317115) #6 11 points 3 comments -> [Helios: Real Real-Time Long Video Generation Model](https://www.alphaxiv.org/abs/2603.04379)<!-- HN:47317115:end --><!-- HN:47313613:start -->
* [47313613](https://news.social-protocols.org/stats?id=47313613) #16 205 points 70 comments -> [Workers report watching Ray-Ban Meta-shot footage of people using the bathroom](https://arstechnica.com/gadgets/2026/03/workers-report-watching-ray-ban-meta-shot-footage-of-people-using-the-bathroom/)<!-- HN:47313613:end --><!-- HN:47316880:start -->
* [47316880](https://news.social-protocols.org/stats?id=47316880) #1 210 points 50 comments -> [In Memoriam, Tony Hoare](http://lefenetrou.blogspot.com/2026/03/in-memoriam-tony-hoare.html)<!-- HN:47316880:end --><!-- HN:47321494:start -->
* [47321494](https://news.social-protocols.org/stats?id=47321494) #19 7 points 2 comments -> [OpenClaw Did Not Just Go Viral in China, It Solved a Structural Problem](https://hellochinatech.com/p/openclaw-china-ai-stack)<!-- HN:47321494:end --><!-- HN:47322002:start -->
* [47322002](https://news.social-protocols.org/stats?id=47322002) #21 6 points 0 comments -> [There are 56 ethnicities in China–and 55 are getting squashed](https://economist.com/china/2026/03/09/there-are-56-ethnicities-in-china-and-55-are-getting-squashed)<!-- HN:47322002:end --><!-- HN:47323300:start -->
* [47323300](https://news.social-protocols.org/stats?id=47323300) #9 3 points 2 comments -> [How Do You Choose a Managed Security Service Provider (MSSP)?](https://msspproviders.io/)<!-- HN:47323300:end --><!-- HN:47323828:start -->
* [47323828](https://news.social-protocols.org/stats?id=47323828) #10 7 points 1 comments -> [You Bought the AI Licenses. Why Is Only One Developer Getting 10x Results?](https://skills.new/post/you-bought-the-ai-licenses-why-is-only-one-developer-getting-10x-results/)<!-- HN:47323828:end --><!-- HN:47323918:start -->
* [47323918](https://news.social-protocols.org/stats?id=47323918) #22 10 points 3 comments -> [Intensifying global heat threatens livability for younger and older adults](https://iopscience.iop.org/article/10.1088/2752-5309/ae3c3a)<!-- HN:47323918:end --><!-- HN:47321533:start -->
* [47321533](https://news.social-protocols.org/stats?id=47321533) #13 396 points 214 comments -> [Yann LeCun's AI startup raises $1B in Europe's largest ever seed round](https://www.ft.com/content/e5245ec3-1a58-4eff-ab58-480b6259aaf1)<!-- HN:47321533:end --><!-- HN:47327143:start -->
* [47327143](https://news.social-protocols.org/stats?id=47327143) #26 10 points 5 comments -> [Maybe the G in AGI stands for Gemini](https://www.robinsloan.com/lab/gemini-agi/)<!-- HN:47327143:end --><!-- HN:47327367:start -->
* [47327367](https://news.social-protocols.org/stats?id=47327367) #30 35 points 2 comments -> [DOGE member took Social Security data on a thumb drive, whistleblower alleges](https://www.washingtonpost.com/politics/2026/03/10/social-security-data-breach-doge/)<!-- HN:47327367:end --><!-- HN:47328122:start -->
* [47328122](https://news.social-protocols.org/stats?id=47328122) #30 9 points 2 comments -> [The Latest Republican Efforts to Make It Harder to Vote in the Midterms](https://www.newyorker.com/news/the-lede/the-latest-republican-efforts-to-make-it-harder-to-vote-in-the-midterms)<!-- HN:47328122:end --><!-- HN:47328532:start -->
* [47328532](https://news.social-protocols.org/stats?id=47328532) #25 4 points 0 comments -> [Air strikes cause black rain and 'unprecedented' pollution in Tehran](https://www.bbc.com/news/articles/cqxd1nv3re2o)<!-- HN:47328532:end -->
#### **Wednesday, March 11, 2026**
<!-- HN:47331708:start -->
* [47331708](https://news.social-protocols.org/stats?id=47331708) #11 13 points 1 comments -> [Sergey Brin Funds Misleading Ballot Measure to Negate Wealth Tax](https://prospect.org/2026/03/10/google-brin-california-wealth-tax-ballot-measure/)<!-- HN:47331708:end --><!-- HN:47332939:start -->
* [47332939](https://news.social-protocols.org/stats?id=47332939) #1 29 points 41 comments -> [Why does AI tell you to use Terminal so much?](https://eclecticlight.co/2026/03/11/why-does-ai-tell-you-to-use-terminal-so-much/)<!-- HN:47332939:end --><!-- HN:47275743:start -->
* [47275743](https://news.social-protocols.org/stats?id=47275743) #21 14 points 18 comments -> [Docs directories are doomed](https://yagmin.com/blog/your-docs-directory-is-doomed/)<!-- HN:47275743:end --><!-- HN:47290574:start -->
* [47290574](https://news.social-protocols.org/stats?id=47290574) #26 12 points 7 comments -> [CAP theorem – Partition is a verb](http://mmudama.github.io/posts/2026/cap-partitions/)<!-- HN:47290574:end --><!-- HN:47291258:start -->
* [47291258](https://news.social-protocols.org/stats?id=47291258) #12 7 points 2 comments -> [Show HN: Custom Git-receive-pack implementation](https://github.com/runxiyu/furgit/tree/master/cmd/receivepack9418)<!-- HN:47291258:end --><!-- HN:47296163:start -->
* [47296163](https://news.social-protocols.org/stats?id=47296163) #11 10 points 2 comments -> [Show HN: I wrote down every expensive hardware development mistake I've seen](https://thehardesthardwarelessons.com/)<!-- HN:47296163:end --><!-- HN:47338445:start -->
* [47338445](https://news.social-protocols.org/stats?id=47338445) #18 23 points 20 comments -> [Why Do They Want to Get Rid of Software Engineers?](https://jrswab.com/blog/why-do-they-want-to-get-rid-of-software-engineers/)<!-- HN:47338445:end --><!-- HN:47338960:start -->
* [47338960](https://news.social-protocols.org/stats?id=47338960) #16 6 points 1 comments -> [Medical technology company in Michigan hit by suspected Iran-linked cyberattack](https://www.fox17online.com/news/local-news/kzoo-bc/kalamazoo/stryker-headquarters-in-portage-closes-amid-reported-cyber-attack-affecting-global-systems)<!-- HN:47338960:end --><!-- HN:47339888:start -->
* [47339888](https://news.social-protocols.org/stats?id=47339888) #12 80 points 38 comments -> [Hisense TVs force owners to watch intrusive ads](https://www.tomshardware.com/tech-industry/big-tech/hisense-tvs-force-owners-to-watch-intrusive-ads-when-switching-inputs-visiting-the-home-screen-or-even-changing-channels-practice-infuriates-consumers-brand-denies-wrongdoing)<!-- HN:47339888:end --><!-- HN:47339763:start -->
* [47339763](https://news.social-protocols.org/stats?id=47339763) #30 11 points 2 comments -> [Nvidia Releases NemoClaw – Enterprise AI Agents, Redefined](https://nemoclaw.bot)<!-- HN:47339763:end --><!-- HN:47343112:start -->
* [47343112](https://news.social-protocols.org/stats?id=47343112) #15 15 points 7 comments -> [NemoClaw – Nvidia's upcoming open-source AI agent platform](https://nemoclaw.bot)<!-- HN:47343112:end -->
#### **Thursday, March 12, 2026**<!-- HN:47346383:start -->
* [47346383](https://news.social-protocols.org/stats?id=47346383) #15 26 points 8 comments -> [US intelligence says Iran government is not at risk of collapse](https://www.reuters.com/business/media-telecom/us-intelligence-says-iran-government-is-not-risk-collapse-say-sources-2026-03-11/)<!-- HN:47346383:end --><!-- HN:47348573:start -->
* [47348573](https://news.social-protocols.org/stats?id=47348573) #30 3 points 0 comments -> [Independent Geophysical Forensic Analysis of the Nordstream Pipeline Sabotage](https://www.geophysical-forensics.ch/nordstream.html)<!-- HN:47348573:end --><!-- HN:47350341:start -->
* [47350341](https://news.social-protocols.org/stats?id=47350341) #25 7 points 0 comments -> [At Least 17 U.S. Sites Damaged in War with Iran, Analysis Shows](https://www.nytimes.com/interactive/2026/03/11/world/middleeast/iran-us-military-bases-strikes-map.html)<!-- HN:47350341:end --><!-- HN:47350252:start -->
* [47350252](https://news.social-protocols.org/stats?id=47350252) #21 14 points 29 comments -> [Show HN: I built an SDK that scrambles HTML so scrapers get garbage](https://www.obscrd.dev/)<!-- HN:47350252:end --><!-- HN:47350467:start -->
* [47350467](https://news.social-protocols.org/stats?id=47350467) #24 45 points 41 comments -> [USDA is closing buildings, relocating staff, and downsizing-a lot](https://www.foodpolitics.com/2026/03/usda-is-closing-buildings-relocating-staff-and-downsizing-a-lot/)<!-- HN:47350467:end --><!-- HN:47352819:start -->
* [47352819](https://news.social-protocols.org/stats?id=47352819) #20 42 points 12 comments -> [Another DOGE staffer explaining how he flagged grants at NEH for "DEI"](https://bsky.app/profile/404media.co/post/3mgupw4v3ak2j)<!-- HN:47352819:end --><!-- HN:47353293:start -->
* [47353293](https://news.social-protocols.org/stats?id=47353293) #7 8 points 0 comments -> [We will come to regret our every use of AI](https://libresolutions.network/articles/ai-regret/)<!-- HN:47353293:end --><!-- HN:47353981:start -->
* [47353981](https://news.social-protocols.org/stats?id=47353981) #28 16 points 10 comments -> [Show HN: LogClaw – Open-source AI SRE that auto-creates tickets from logs](https://logclaw.ai)<!-- HN:47353981:end --><!-- HN:47355213:start -->
* [47355213](https://news.social-protocols.org/stats?id=47355213) #9 30 points 16 comments -> [Show HN: Aurion OS – A 32-bit GUI operating system written from scratch in C](https://github.com/Luka12-dev/AurionOS)<!-- HN:47355213:end --><!-- HN:47357294:start -->
* [47357294](https://news.social-protocols.org/stats?id=47357294) #3 33 points 11 comments -> [Illinois introduces OS-level age verification law](https://legiscan.com/IL/bill/SB3977/2025)<!-- HN:47357294:end --><!-- HN:47358033:start -->
* [47358033](https://news.social-protocols.org/stats?id=47358033) #10 4 points 0 comments -> [Qodo Outperforms Claude in Code Review Benchmark](https://www.qodo.ai/blog/qodo-outperforms-claude-in-code-review-benchmark/)<!-- HN:47358033:end -->
#### **Friday, March 13, 2026**
<!-- HN:47359136:start -->
* [47359136](https://news.social-protocols.org/stats?id=47359136) #2 91 points 16 comments -> [Tennessee grandmother jailed after AI face recognition error links her to fraud](https://www.theguardian.com/us-news/2026/mar/12/tennessee-grandmother-ai-fraud)<!-- HN:47359136:end --><!-- HN:47363901:start -->
* [47363901](https://news.social-protocols.org/stats?id=47363901) #2 48 points 22 comments -> [301M Records Exposed: The HIPAA Breach Epidemic](https://ciphercue.com/blog/hipaa-breach-epidemic-301-million-records)<!-- HN:47363901:end --><!-- HN:47364829:start -->
* [47364829](https://news.social-protocols.org/stats?id=47364829) #4 6 points 0 comments -> [Four crew members killed after US refuelling plane crashes in Iraq](https://www.bbc.com/news/articles/cy0dz5ql17vo)<!-- HN:47364829:end --><!-- HN:47366400:start -->
* [47366400](https://news.social-protocols.org/stats?id=47366400) #1 64 points 3 comments -> [Channel Surfer – Watch YouTube Like It's Cable TV](https://channelsurfer.tv/)<!-- HN:47366400:end --><!-- HN:47365597:start -->
* [47365597](https://news.social-protocols.org/stats?id=47365597) #5 190 points 24 comments -> [Meta Platforms: Lobbying, Dark Money, and the App Store Accountability Act](https://github.com/upper-up/meta-lobbying-and-other-findings)<!-- HN:47365597:end --><!-- HN:47365461:start -->
* [47365461](https://news.social-protocols.org/stats?id=47365461) #25 40 points 3 comments -> [Two long-lost episodes of 'Doctor Who' have been found](https://apnews.com/article/doctor-who-lost-episodes-found-daleks-6849b09faa6eca9377b2a0db45d47ff8)<!-- HN:47365461:end --><!-- HN:47367291:start -->
* [47367291](https://news.social-protocols.org/stats?id=47367291) #26 6 points 0 comments -> [ECJ says EU states must change gender of citizens even if nat'l laws forbid it](https://brusselssignal.eu/2026/03/ecj-says-member-states-must-change-gender-of-citizens-even-if-national-laws-forbid-it/)<!-- HN:47367291:end -->
#### **Saturday, March 14, 2026**
<!-- HN:47371486:start -->
* [47371486](https://news.social-protocols.org/stats?id=47371486) #3 18 points 2 comments -> ["Added 1M context window for Opus 4.6 by default for Max, Team, and Enterprise"](https://raw.githubusercontent.com/anthropics/claude-code/refs/heads/main/CHANGELOG.md)<!-- HN:47371486:end --><!-- HN:47371275:start -->
* [47371275](https://news.social-protocols.org/stats?id=47371275) #10 31 points 40 comments -> [I beg you to follow Crocker's Rules, even if you will be rude to me](https://lr0.org/blog/p/crocker/)<!-- HN:47371275:end --><!-- HN:47372290:start -->
* [47372290](https://news.social-protocols.org/stats?id=47372290) #2 92 points 10 comments -> [An investigation of the forces behind the age-verification bills](https://lwn.net/Articles/1062779/)<!-- HN:47372290:end -->