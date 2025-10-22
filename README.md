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

#### **Thursday, October 16, 2025**
<!-- HN:45509301:start -->
* [45509301](https://news.social-protocols.org/stats?id=45509301) #3 30 points 12 comments -> [Closer to production quality Python notebooks with `marimo check`](https://marimo.io/blog/marimo-check)<!-- HN:45509301:end --><!-- HN:45501088:start -->
* [45501088](https://news.social-protocols.org/stats?id=45501088) #14 59 points 25 comments -> [Bringing NumPy's type-completeness score to nearly 90% – Pyrefly](https://pyrefly.org/blog/numpy-type-completeness/)<!-- HN:45501088:end --><!-- HN:45489911:start -->
* [45489911](https://news.social-protocols.org/stats?id=45489911) #16 67 points 13 comments -> [Gerald Sussman - An Electrical Engineering View of a Mechanical Watch (2003)](https://techtv.mit.edu/videos/15895-an-electrical-engineering-view-of-a-mechanical-watch)<!-- HN:45489911:end --><!-- HN:45512538:start -->
* [45512538](https://news.social-protocols.org/stats?id=45512538) #30 157 points 73 comments -> [The brain navigates new spaces by 'darting' between reality and mental maps](https://medicine.yale.edu/news-article/brain-navigates-new-spaces-by-flickering-between-reality-and-old-mental-maps/)<!-- HN:45512538:end --><!-- HN:45602728:start -->
* [45602728](https://news.social-protocols.org/stats?id=45602728) #21 3 points 1 comments -> [Homeless Man AI Prank Prompt: Risks, Ethics, and How to Use AI Responsibly](https://ray3.run/posts/homeless-man-ai-prank-prompt)<!-- HN:45602728:end --><!-- HN:45603056:start -->
* [45603056](https://news.social-protocols.org/stats?id=45603056) #6 7 points 0 comments -> [The Economic Cost of Antisemitism](https://critiqueanddigest.substack.com/p/the-economic-cost-of-antisemitism)<!-- HN:45603056:end --><!-- HN:45603277:start -->
* [45603277](https://news.social-protocols.org/stats?id=45603277) #5 14 points 1 comments -> [Pentagon Imposes Pre-Publication Censorship – All Major U.S. Media Walk Out](https://archivethecontrolstack.substack.com/p/archive-003-badges-surrendered-the)<!-- HN:45603277:end --><!-- HN:45604034:start -->
* [45604034](https://news.social-protocols.org/stats?id=45604034) #2 -> [Get a Heat Pump on Lloyds](https://www.lloydsbankinggroup.com/media/press-releases/2025/lloyds-bank-2025/get-a-heat-pump-on-lloyds.html)<!-- HN:45604034:end --><!-- HN:45604381:start -->
* [45604381](https://news.social-protocols.org/stats?id=45604381) #21 9 points 1 comments -> [How The Pentagon Is Blocking Out News Organizations](https://www.nytimes.com/interactive/2025/10/15/business/media/pentatgon-press-rules.html)<!-- HN:45604381:end --><!-- HN:45604313:start -->
* [45604313](https://news.social-protocols.org/stats?id=45604313) #22 23 points 41 comments -> [Chat-GPT becomes Sex-GPT for verified adults](https://twitter.com/sama/status/1978129344598827128)<!-- HN:45604313:end --><!-- HN:45605299:start -->
* [45605299](https://news.social-protocols.org/stats?id=45605299) #5 -> [K](https://k.nyc/)<!-- HN:45605299:end --><!-- HN:45557680:start -->
* [45557680](https://news.social-protocols.org/stats?id=45557680) #10 24 points 1 comments -> [Cambridge University launches project to rescue data trapped on old floppy disks](https://www.lib.cam.ac.uk/stories/floppy-disk-funding)<!-- HN:45557680:end --><!-- HN:45606939:start -->
* [45606939](https://news.social-protocols.org/stats?id=45606939) #28 5 points 0 comments -> [Moscow Built What Kiev Could Not](https://nopolitik.substack.com/p/rus-between-kiev-and-moscow)<!-- HN:45606939:end --><!-- HN:45604823:start -->
* [45604823](https://news.social-protocols.org/stats?id=45604823) #15 26 points 47 comments -> [Like MS Excel, Pivot tables never die](https://www.rilldata.com/blog/why-pivot-tables-never-die)<!-- HN:45604823:end --><!-- HN:45608260:start -->
* [45608260](https://news.social-protocols.org/stats?id=45608260) #22 21 points 15 comments -> [Show HN: How Useless Are You? A brutally honest skills check](https://www.howuselessareyou.com)<!-- HN:45608260:end --><!-- HN:45606602:start -->
* [45606602](https://news.social-protocols.org/stats?id=45606602) #25 36 points 40 comments -> [Why more SaaS companies are hiring chief trust officers](https://www.itbrew.com/stories/2025/10/14/why-more-saas-companies-are-hiring-chief-trust-officers)<!-- HN:45606602:end --><!-- HN:45609942:start -->
* [45609942](https://news.social-protocols.org/stats?id=45609942) #22 17 points 26 comments -> [Show HN: We priced basic needs in work hours (global ranking and CSVs)](https://www.thepricer.org/hours-to-afford-essentials-best-and-worst-countries/)<!-- HN:45609942:end -->
#### **Friday, October 17, 2025**
<!-- HN:45612388:start -->
* [45612388](https://news.social-protocols.org/stats?id=45612388) #20 26 points 4 comments -> [ICE, Border Patrol agents to receive pay during government shutdown](https://www.reuters.com/world/us/some-federal-law-enforcement-receive-pay-during-government-shutdown-2025-10-16/)<!-- HN:45612388:end --><!-- HN:45551675:start -->
* [45551675](https://news.social-protocols.org/stats?id=45551675) #20 6 points 1 comments -> [My First Gulfstream](https://www.vanityfair.com/news/1998/10/gulfstream-199810)<!-- HN:45551675:end --><!-- HN:45548560:start -->
* [45548560](https://news.social-protocols.org/stats?id=45548560) #15 21 points 40 comments -> [Why I have to buy doughnuts with cash](https://www.ft.com/content/8766ef23-3938-4de2-8a37-602c798034aa)<!-- HN:45548560:end --><!-- HN:45613781:start -->
* [45613781](https://news.social-protocols.org/stats?id=45613781) #5 5 points 2 comments -> [Wabi – Personal Software Platform](https://wabi.ai/)<!-- HN:45613781:end --><!-- HN:45615494:start -->
* [45615494](https://news.social-protocols.org/stats?id=45615494) #13 13 points 9 comments -> [Codebase is 250% AI generated](https://www.moderndescartes.com/essays/ai_codebase/)<!-- HN:45615494:end --><!-- HN:45616777:start -->
* [45616777](https://news.social-protocols.org/stats?id=45616777) #17 7 points 0 comments -> [Europe Can't Defend Democracy on US Servers](https://werd.io/europe-cant-defend-democracy-on-us-servers/)<!-- HN:45616777:end --><!-- HN:45550328:start -->
* [45550328](https://news.social-protocols.org/stats?id=45550328) #13 8 points 1 comments -> [Dev Services for Spring Boot Using Arconia](https://www.thomasvitale.com/arconia-dev-services-spring-boot/)<!-- HN:45550328:end --><!-- HN:45617859:start -->
* [45617859](https://news.social-protocols.org/stats?id=45617859) #29 3 points 0 comments -> [Woman tricked into travelling to Thailand for modelling job killed for organs](https://www.dailymail.co.uk/news/article-15198093/Woman-tricked-travelling-Thailand-fake-modelling-job-killed-organs-harvested.html)<!-- HN:45617859:end --><!-- HN:45617990:start -->
* [45617990](https://news.social-protocols.org/stats?id=45617990) #2 13 points 3 comments -> [Show HN: Searchable compression for JSON – ~99% page skip and sub-ms lookups](https://github.com/kodomonocch1/see_proto)<!-- HN:45617990:end --><!-- HN:45620311:start -->
* [45620311](https://news.social-protocols.org/stats?id=45620311) #7 4 points 0 comments -> [What I Saw at This Weekend's Minnesota MAHA Fest Scared the Hell Out of Me](https://racketmn.com/what-i-saw-at-this-weekends-minnesota-maha-fest-scared-the-hell-out-of-me)<!-- HN:45620311:end --><!-- HN:45621246:start -->
* [45621246](https://news.social-protocols.org/stats?id=45621246) #12 22 points 41 comments -> [Making Every Windows 11 PC an AI PC](https://blogs.windows.com/windowsexperience/2025/10/16/making-every-windows-11-pc-an-ai-pc/)<!-- HN:45621246:end -->
#### **Saturday, October 18, 2025**
<!-- HN:45623679:start -->
* [45623679](https://news.social-protocols.org/stats?id=45623679) #1 128 points 3 comments -> [Ring cameras are about to get increasingly chummy with law enforcement](https://arstechnica.com/gadgets/2025/10/ring-cameras-are-about-to-get-increasingly-chummy-with-law-enforcement/)<!-- HN:45623679:end --><!-- HN:45566577:start -->
* [45566577](https://news.social-protocols.org/stats?id=45566577) #15 6 points 1 comments -> [I wrote a parser for Redis protocol so you don't have to](https://neversleeps.moscow/publications/resp.html)<!-- HN:45566577:end --><!-- HN:45623883:start -->
* [45623883](https://news.social-protocols.org/stats?id=45623883) #11 30 points 2 comments -> [Wikipedia Volunteers Avert Tragedy by Taking Down Gunman at Conference](https://www.nytimes.com/2025/10/17/nyregion/wikipedia-conference-gunman.html)<!-- HN:45623883:end --><!-- HN:45624908:start -->
* [45624908](https://news.social-protocols.org/stats?id=45624908) #27 15 points 1 comments -> [The Richest Third-World Country](https://www.noahpinion.blog/p/the-richest-third-world-country)<!-- HN:45624908:end --><!-- HN:45627171:start -->
* [45627171](https://news.social-protocols.org/stats?id=45627171) #25 94 points 56 comments -> [Game over. AGI is not imminent, and LLMs are not the royal road to getting there](https://garymarcus.substack.com/p/the-last-few-months-have-been-devastating)<!-- HN:45627171:end --><!-- HN:45628279:start -->
* [45628279](https://news.social-protocols.org/stats?id=45628279) #15 8 points 2 comments -> [Solving the NYTimes Pips puzzle with a constraint solver](https://www.righto.com/2025/10/solve-nyt-pips-with-constraints.html)<!-- HN:45628279:end --><!-- HN:45628373:start -->
* [45628373](https://news.social-protocols.org/stats?id=45628373) #18 62 points 10 comments -> [Testosterone Administration Induces a Red Shift in Democrats](https://pmc.ncbi.nlm.nih.gov/articles/PMC12230349/)<!-- HN:45628373:end --><!-- HN:45628499:start -->
* [45628499](https://news.social-protocols.org/stats?id=45628499) #4 29 points 4 comments -> [Atuin desktop: Runbooks that run](https://github.com/atuinsh/desktop)<!-- HN:45628499:end -->
#### **Sunday, October 19, 2025**
<!-- HN:45631455:start -->
* [45631455](https://news.social-protocols.org/stats?id=45631455) #16 6 points 6 comments -> [I ended my relationship because AI told me to](https://jetwilliams.com/from-prayers-to-prompts/)<!-- HN:45631455:end --><!-- HN:45631974:start -->
* [45631974](https://news.social-protocols.org/stats?id=45631974) #15 23 points 12 comments -> [The traffickers are winning the war on drugs](https://www.economist.com/briefing/2025/10/16/the-traffickers-are-winning-the-war-on-drugs)<!-- HN:45631974:end --><!-- HN:45557970:start -->
* [45557970](https://news.social-protocols.org/stats?id=45557970) #19 30 points 41 comments -> [Why do Stanford math professors still use chalk? (2021)](https://stanforddaily.com/2021/10/17/why-do-stanford-math-professors-still-use-chalk/)<!-- HN:45557970:end --><!-- HN:45632681:start -->
* [45632681](https://news.social-protocols.org/stats?id=45632681) #1 25 points 40 comments -> [Show HN: A better Hacker News front end](https://hakkernieuws.vercel.app/top)<!-- HN:45632681:end --><!-- HN:45635077:start -->
* [45635077](https://news.social-protocols.org/stats?id=45635077) #13 19 points 19 comments -> [How Senior Engineers Lose Trust](https://tahahussain.substack.com/p/how-senior-engineers-lose-trust)<!-- HN:45635077:end --><!-- HN:45635336:start -->
* [45635336](https://news.social-protocols.org/stats?id=45635336) #11 29 points 12 comments -> [Judge says body cameras for Chicago officers "was not a suggestion"](https://www.cbsnews.com/chicago/news/judge-homeland-security-federal-agents-chicago-body-cameras/)<!-- HN:45635336:end --><!-- HN:45634484:start -->
* [45634484](https://news.social-protocols.org/stats?id=45634484) #28 50 points 22 comments -> [Websites Are for Humans](https://marcus-obst.de/blog/websites-are-for-humans)<!-- HN:45634484:end --><!-- HN:45636271:start -->
* [45636271](https://news.social-protocols.org/stats?id=45636271) #5 -> [Criticizing Immigration Laws Is Not Racist](https://www.maximepeabody.com/blog/immigration-in-canada)<!-- HN:45636271:end --><!-- HN:45635147:start -->
* [45635147](https://news.social-protocols.org/stats?id=45635147) #20 35 points 41 comments -> [Show HN: Notepad.exe – macOS editor for Swift and Python (now Linux runtime)](https://notepadexe.com/)<!-- HN:45635147:end --><!-- HN:45638188:start -->
* [45638188](https://news.social-protocols.org/stats?id=45638188) #8 30 points 8 comments -> [Show HN: 18yo first iOS app: blocks distracting apps and unlocks with QR/barcode](https://apps.apple.com/us/app/recode-screen-time-control/id6752352978)<!-- HN:45638188:end -->
#### **Monday, October 20, 2025**<!-- HN:45643014:start -->
* [45643014](https://news.social-protocols.org/stats?id=45643014) #5 5 points 2 comments -> [Lessons from AWS Us-East-1 Outage: Why Local NVMe as Primary DB Storage Is Risky](https://www.eloqdata.com/blog/2025/10/20/local-nvme-risky-for-database)<!-- HN:45643014:end --><!-- HN:45644205:start -->
* [45644205](https://news.social-protocols.org/stats?id=45644205) #1 15 points 9 comments -> ["COBOL supports close to 90% of Fortune 500 business systems today."](https://cobolcowboys.com/cobol-today/)<!-- HN:45644205:end --><!-- HN:45644073:start -->
* [45644073](https://news.social-protocols.org/stats?id=45644073) #11 5 points 0 comments -> [Rental Income Analyzer](https://www.rebux.app/)<!-- HN:45644073:end --><!-- HN:45643678:start -->
* [45643678](https://news.social-protocols.org/stats?id=45643678) #22 4 points 0 comments -> [Ashen-WoW – Pure Vanilla, authentic, stable, community-run](https://ashen-wow.space/en)<!-- HN:45643678:end --><!-- HN:45645268:start -->
* [45645268](https://news.social-protocols.org/stats?id=45645268) #4 -> [Elites seek to retain their power: Lampedusa's The Leopard skewered super-rich](https://www.bbc.com/culture/article/20250304-the-leopard-the-1958-italian-novel-that-skewered-the-super-rich)<!-- HN:45645268:end --><!-- HN:45642951:start -->
* [45642951](https://news.social-protocols.org/stats?id=45642951) #19 288 points 151 comments -> [AWS Outage: A Single Cloud Region Shouldn't Take Down the World. But It Did](https://faun.dev/c/news/devopslinks/aws-outage-a-single-cloud-region-shouldnt-take-down-the-world-but-it-did/)<!-- HN:45642951:end --><!-- HN:45640772:start -->
* [45640772](https://news.social-protocols.org/stats?id=45640772) #15 1051 points 9 comments -> [Major AWS Outage Happening](https://old.reddit.com/r/aws/comments/1obd3lx/dynamodb_down_useast1/)<!-- HN:45640772:end --><!-- HN:45643144:start -->
* [45643144](https://news.social-protocols.org/stats?id=45643144) #30 27 points 11 comments -> [Show HN: I got tired of managing dev environments, so I built ServBay](https://www.servbay.com)<!-- HN:45643144:end --><!-- HN:45645567:start -->
* [45645567](https://news.social-protocols.org/stats?id=45645567) #26 23 points 41 comments -> [Kohler launches smart toilet camera](https://techcrunch.com/2025/10/19/kohler-unveils-a-camera-for-your-toilet/)<!-- HN:45645567:end --><!-- HN:45644276:start -->
* [45644276](https://news.social-protocols.org/stats?id=45644276) #23 42 points 52 comments -> [How Soon Will the Seas Rise?](https://www.quantamagazine.org/how-soon-will-the-seas-rise-20251020/)<!-- HN:45644276:end --><!-- HN:45646777:start -->
* [45646777](https://news.social-protocols.org/stats?id=45646777) #28 16 points 4 comments -> [Speaking of Amazon, here's a fresh post from an engineer who just quit](https://nekrolm.github.io/blog.html)<!-- HN:45646777:end --><!-- HN:45648864:start -->
* [45648864](https://news.social-protocols.org/stats?id=45648864) #27 -> [Should MS Replace Satya Nadella with an AI CEO?](https://old.reddit.com/r/microsoftsucks/comments/1obsew3/should_ms_replace_satya_nadella_with_an_ai_ceo/)<!-- HN:45648864:end --><!-- HN:45648726:start -->
* [45648726](https://news.social-protocols.org/stats?id=45648726) #28 106 points 69 comments -> [It Kind of Seems Like Peter Thiel Is Losing It](https://futurism.com/future-society/peter-thiel-antichrist-lectures)<!-- HN:45648726:end -->
#### **Tuesday, October 21, 2025**
<!-- HN:45569670:start -->
* [45569670](https://news.social-protocols.org/stats?id=45569670) #12 10 points 0 comments -> [Building a CMS without programming experience](https://www.vibediary.dev/essays/cms)<!-- HN:45569670:end --><!-- HN:45654132:start -->
* [45654132](https://news.social-protocols.org/stats?id=45654132) #4 27 points 14 comments -> [AI Weiwei: What I Wish I Had Known About Germany Earlier](https://hyperallergic.com/1050197/what-i-wish-i-had-known-about-germany-earlier/)<!-- HN:45654132:end --><!-- HN:45654382:start -->
* [45654382](https://news.social-protocols.org/stats?id=45654382) #2 122 points 2 comments -> [US chess grandmaster Daniel Naroditsky dies aged 29](https://www.bbc.com/news/articles/c15pz8vpjp9o)<!-- HN:45654382:end --><!-- HN:45655361:start -->
* [45655361](https://news.social-protocols.org/stats?id=45655361) #11 32 points 11 comments -> [The Karpathy Interview, 6 Months After AI 2027](https://futuresearch.ai/ai-2027-6-months-later/)<!-- HN:45655361:end --><!-- HN:45656676:start -->
* [45656676](https://news.social-protocols.org/stats?id=45656676) #16 11 points 0 comments -> [Fired Justice Department lawyer blows the whistle on abuses of power at the DOJ [video]](https://www.youtube.com/watch?v=vcSHMkyM0aE)<!-- HN:45656676:end --><!-- HN:45657055:start -->
* [45657055](https://news.social-protocols.org/stats?id=45657055) #28 19 points 20 comments -> [Show HN: Clink – Bring your own CLI Agents, Ship instantly](https://clink.new)<!-- HN:45657055:end --><!-- HN:45659523:start -->
* [45659523](https://news.social-protocols.org/stats?id=45659523) #7 4 points 2 comments -> [My wife gave me 100 days to make it as an indie creator](https://blog.jacobstechtavern.com/p/my-wife-gave-me-100-days)<!-- HN:45659523:end --><!-- HN:45659907:start -->
* [45659907](https://news.social-protocols.org/stats?id=45659907) #29 -> [Amazon Doesn't Use Route 53 for amazon.com](https://www.dnscheck.co/blog/dns-monitoring/2025/10/21/aws-dog-food.html)<!-- HN:45659907:end -->
#### **Wednesday, October 22, 2025**
<!-- HN:45664358:start -->
* [45664358](https://news.social-protocols.org/stats?id=45664358) #23 20 points 13 comments -> [I Bought $250k Worth of Physical Nickels](https://twitter.com/opinioncasino/status/1980038177785000114)<!-- HN:45664358:end --><!-- HN:45664751:start -->
* [45664751](https://news.social-protocols.org/stats?id=45664751) #2 41 points 14 comments -> [Spotify running ICE recruitment ads about "dangerous illegals"](https://djmag.com/news/spotify-defends-running-ice-recruitment-ads-about-dangerous-illegals-part-of-us-government)<!-- HN:45664751:end --><!-- HN:45662831:start -->
* [45662831](https://news.social-protocols.org/stats?id=45662831) #14 151 points 25 comments -> ["Butt breathing" might soon be a real medical treatment](https://arstechnica.com/science/2025/10/butt-breathing-might-soon-be-a-real-medical-treatment/)<!-- HN:45662831:end --><!-- HN:45666986:start -->
* [45666986](https://news.social-protocols.org/stats?id=45666986) #23 9 points 9 comments -> [Show HN: Coach Thyself – Replace your morning scroll with structured journaling](https://thyself.coach/)<!-- HN:45666986:end -->