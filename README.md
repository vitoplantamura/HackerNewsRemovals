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

#### **Tuesday, July 8, 2025**<!-- HN:44497844:start -->
* [44497844](https://news.social-protocols.org/stats?id=44497844) #21 31 points 40 comments -> [ChatGPT testing a mysterious new feature called 'study together'](https://techcrunch.com/2025/07/07/chatgpt-is-testing-a-mysterious-new-feature-called-study-together/)<!-- HN:44497844:end --><!-- HN:44501743:start -->
* [44501743](https://news.social-protocols.org/stats?id=44501743) #7 12 points 0 comments -> [AnyBlox: A Framework for Self-Decoding Datasets [pdf]](https://gienieczko.com/anyblox-paper)<!-- HN:44501743:end --><!-- HN:44503585:start -->
* [44503585](https://news.social-protocols.org/stats?id=44503585) #5 3 points 0 comments -> [roons: A kit for building mechanical computers](https://whomtech.com/roons/)<!-- HN:44503585:end --><!-- HN:44472877:start -->
* [44472877](https://news.social-protocols.org/stats?id=44472877) #8 10 points 1 comments -> [How to Save a Dog](https://www.newyorker.com/news/the-weekend-essay/how-to-save-a-dog)<!-- HN:44472877:end --><!-- HN:44503221:start -->
* [44503221](https://news.social-protocols.org/stats?id=44503221) #25 10 points 0 comments -> [Show HN: OpenAPI mocks that don't suck – realistic test data, quick setup](https://beeceptor.com/openapi-mock-server/)<!-- HN:44503221:end -->
#### **Wednesday, July 9, 2025**
<!-- HN:44505675:start -->
* [44505675](https://news.social-protocols.org/stats?id=44505675) #18 212 points 98 comments -> [US court strikes down 'click-to-cancel' rule designed to make unsubscribing easy](https://www.theguardian.com/us-news/2025/jul/08/court-click-to-cancel-ruling)<!-- HN:44505675:end --><!-- HN:44506991:start -->
* [44506991](https://news.social-protocols.org/stats?id=44506991) #4 9 points 0 comments -> [40 Hot Swedish AI Startups](https://www.di.se/digital/here-are-the-swedish-ai-companies-everyone-is-talking-about/)<!-- HN:44506991:end --><!-- HN:44483917:start -->
* [44483917](https://news.social-protocols.org/stats?id=44483917) #10 10 points 2 comments -> [The Dangers of Stochastic Parrots: Can Language Models Be Too Big?](https://dl.acm.org/doi/10.1145/3442188.3445922)<!-- HN:44483917:end --><!-- HN:44507963:start -->
* [44507963](https://news.social-protocols.org/stats?id=44507963) #5 4 points 1 comments -> [Show HN: Agentic MCP Server Manager](https://ddfourtwo.github.io/install-mcp/)<!-- HN:44507963:end --><!-- HN:44507919:start -->
* [44507919](https://news.social-protocols.org/stats?id=44507919) #6 8 points 3 comments -> [From AI to Agents to Agencies](https://blog.nishantsoni.com/p/from-ai-to-agents-to-agencies-the)<!-- HN:44507919:end --><!-- HN:44507673:start -->
* [44507673](https://news.social-protocols.org/stats?id=44507673) #9 -> [The MCP hype is a distraction. AI Agents should just build their own tools](https://www.rtrvr.ai/blog/on-the-fly-toolgen)<!-- HN:44507673:end --><!-- HN:44508882:start -->
* [44508882](https://news.social-protocols.org/stats?id=44508882) #5 15 points 9 comments -> [Claude Pro Max hallucinated a $270 Notion feature that doesn't exist](https://gist.github.com/habonggil/f6130a68bbc4139c8066aa90c14c986f)<!-- HN:44508882:end --><!-- HN:44511757:start -->
* [44511757](https://news.social-protocols.org/stats?id=44511757) #30 4 points 0 comments -> [The Wild West of Agentic AI – An Attack Surface CISOs Can't Afford to Ignore](https://www.securityweek.com/the-wild-wild-west-of-agentic-ai-an-attack-surface-cisos-cant-afford-to-ignore/)<!-- HN:44511757:end --><!-- HN:44510656:start -->
* [44510656](https://news.social-protocols.org/stats?id=44510656) #24 3 points 1 comments -> [Skia Graphite: Chrome's rasterization back end for the future](https://blog.chromium.org/2025/07/introducing-skia-graphite-chromes.html)<!-- HN:44510656:end --><!-- HN:44509790:start -->
* [44509790](https://news.social-protocols.org/stats?id=44509790) #30 21 points 3 comments -> [Jurisdiction Is Nearly Irrelevant to the Security of Encrypted Messaging Apps](https://soatok.blog/2025/07/09/jurisdiction-is-nearly-irrelevant-to-the-security-of-encrypted-messaging-apps/)<!-- HN:44509790:end --><!-- HN:44512799:start -->
* [44512799](https://news.social-protocols.org/stats?id=44512799) #30 7 points 3 comments -> [OpenAI's open language model is imminent](https://www.theverge.com/notepad-microsoft-newsletter/702848/openai-open-language-model-o3-mini-notepad)<!-- HN:44512799:end -->
#### **Thursday, July 10, 2025**
<!-- HN:44515650:start -->
* [44515650](https://news.social-protocols.org/stats?id=44515650) #30 6 points 1 comments -> [Show HN: I built a social media app at 11 using AI and a phone](https://app--woo-short-78d020b9.base44.app)<!-- HN:44515650:end --><!-- HN:44516586:start -->
* [44516586](https://news.social-protocols.org/stats?id=44516586) #20 4 points 0 comments -> [The Persecution of Francesca Albanese](https://chrishedges.substack.com/p/the-persecution-of-francesca-albanese)<!-- HN:44516586:end --><!-- HN:44517927:start -->
* [44517927](https://news.social-protocols.org/stats?id=44517927) #11 9 points 1 comments -> [I made a parody of enterprise AI chatbots](https://github.com/muratcanozdemir/chatgpt-parody)<!-- HN:44517927:end --><!-- HN:44520105:start -->
* [44520105](https://news.social-protocols.org/stats?id=44520105) #21 20 points 5 comments -> [YouTube prepares crackdown on mass-produced videos as concern over AI slop grows](https://techcrunch.com/2025/07/09/youtube-prepares-crackdown-on-mass-produced-and-repetitive-videos-as-concern-over-ai-slop-grows/)<!-- HN:44520105:end --><!-- HN:44519596:start -->
* [44519596](https://news.social-protocols.org/stats?id=44519596) #4 38 points 16 comments -> [Magic .env files built for sharing: Human-first, AI-friendly](https://varlock.dev/)<!-- HN:44519596:end --><!-- HN:44520297:start -->
* [44520297](https://news.social-protocols.org/stats?id=44520297) #26 14 points 16 comments -> [The Birth-Rate Crisis Isn't as Bad as You've Heard–It's Worse](https://www.theatlantic.com/ideas/archive/2025/06/birth-rate-population-decline/683333/)<!-- HN:44520297:end --><!-- HN:44520466:start -->
* [44520466](https://news.social-protocols.org/stats?id=44520466) #13 10 points 6 comments -> [ChatGPT Guessing Game Leads to Users Extracting Free Windows OS Keys and More](https://0din.ai/blog/chatgpt-guessing-game-leads-to-users-extracting-free-windows-os-keys-more)<!-- HN:44520466:end --><!-- HN:44521923:start -->
* [44521923](https://news.social-protocols.org/stats?id=44521923) #11 -> [X's CEO is out after failing at basically everything she claimed she wanted](https://www.theverge.com/twitter/703606/x-ceo-linda-yaccarino-elon-musk-out-step-down-twitter)<!-- HN:44521923:end --><!-- HN:44523273:start -->
* [44523273](https://news.social-protocols.org/stats?id=44523273) #16 9 points 0 comments -> ["America, something's up" Walmart shoppers mystified by widespread outages](https://www.dailydot.com/news/walmart-july-7-outage/)<!-- HN:44523273:end --><!-- HN:44525582:start -->
* [44525582](https://news.social-protocols.org/stats?id=44525582) #2 9 points 1 comments -> [The AI Con](https://thecon.ai/)<!-- HN:44525582:end --><!-- HN:44524571:start -->
* [44524571](https://news.social-protocols.org/stats?id=44524571) #10 27 points 41 comments -> [Working with the UK Government to Protect Children Online](https://bsky.social/about/blog/07-10-2025-age-assurance)<!-- HN:44524571:end --><!-- HN:44523830:start -->
* [44523830](https://news.social-protocols.org/stats?id=44523830) #28 14 points 0 comments -> [Exploiting a 20 years old NTFS Vulnerability](https://swarm.ptsecurity.com/buried-in-the-log-exploiting-a-20-years-old-ntfs-vulnerability/)<!-- HN:44523830:end -->
#### **Friday, July 11, 2025**
<!-- HN:44527301:start -->
* [44527301](https://news.social-protocols.org/stats?id=44527301) #20 10 points 1 comments -> [Over 2,000 senior staff set to leave NASA under agency push](https://www.politico.com/news/2025/07/09/nasa-staff-departures-00444674?cdmc=2zglpgOF21PefXUKP0PbPaLZDC0&refcode2=2zglpgOF21PefXUKP0PbPaLZDC0&refcodecdmc=2zglpgOF21PefXUKP0PbPaLZDC0)<!-- HN:44527301:end --><!-- HN:44527930:start -->
* [44527930](https://news.social-protocols.org/stats?id=44527930) #24 7 points 1 comments -> [Man Afraid to Ride Subway Named Head of NASA](https://www.rollingstone.com/politics/politics-news/trump-sean-duffy-interim-nasa-administrator-1235382413/)<!-- HN:44527930:end --><!-- HN:44528536:start -->
* [44528536](https://news.social-protocols.org/stats?id=44528536) #14 8 points 5 comments -> [SEO Is Dead. Long Live Geo](https://substack.gauravvohra.com/p/search-is-dead-long-live-llms-winning-in-the-era-of-llms-ai-overviews-and-geo)<!-- HN:44528536:end --><!-- HN:44528966:start -->
* [44528966](https://news.social-protocols.org/stats?id=44528966) #1 26 points 0 comments -> [GenAI Processors: Build powerful and flexible Gemini applications](https://developers.googleblog.com/en/genai-processors/)<!-- HN:44528966:end --><!-- HN:44529456:start -->
* [44529456](https://news.social-protocols.org/stats?id=44529456) #3 23 points 42 comments -> [Why Is Fertility So Low in High Income Countries? (NBER)](https://www.nber.org/papers/w33989)<!-- HN:44529456:end --><!-- HN:44529812:start -->
* [44529812](https://news.social-protocols.org/stats?id=44529812) #8 24 points 40 comments -> [Woman takes 10x dose of turmeric, gets hospitalized for liver damage](https://arstechnica.com/health/2025/07/woman-takes-10x-dose-of-turmeric-gets-hospitalized-for-liver-damage/)<!-- HN:44529812:end --><!-- HN:44528851:start -->
* [44528851](https://news.social-protocols.org/stats?id=44528851) #12 33 points 40 comments -> [An almost catastrophic OpenZFS bug and the humans that made it](https://despairlabs.com/blog/posts/2025-07-10-an-openzfs-bug-and-the-humans-that-made-it/)<!-- HN:44528851:end --><!-- HN:44531811:start -->
* [44531811](https://news.social-protocols.org/stats?id=44531811) #14 7 points 5 comments -> [It's Time to Let Go of 'African American'](https://archive.li/jkk4S)<!-- HN:44531811:end --><!-- HN:44530807:start -->
* [44530807](https://news.social-protocols.org/stats?id=44530807) #11 14 points 11 comments -> [Using Sound Waves to Put Out Fire: Story of Two George Mason University Students](https://wowparrot.com/using-sound-waves-to-put-out-fire/)<!-- HN:44530807:end --><!-- HN:44531561:start -->
* [44531561](https://news.social-protocols.org/stats?id=44531561) #4 89 points 53 comments -> ['Click-to-cancel' rule is blocked](https://apnews.com/article/ftc-click-to-cancel-30db2be07fdcb8aefd0d4835abdb116a)<!-- HN:44531561:end --><!-- HN:44536572:start -->
* [44536572](https://news.social-protocols.org/stats?id=44536572) #26 6 points 1 comments -> [Dutch Childcare Benefits Scandal](https://en.wikipedia.org/wiki/Dutch_childcare_benefits_scandal)<!-- HN:44536572:end --><!-- HN:44536691:start -->
* [44536691](https://news.social-protocols.org/stats?id=44536691) #19 44 points 28 comments -> [Air India Flight 171 Accident Preliminary Report [pdf]](https://aaib.gov.in/What%27s%20New%20Assets/Preliminary%20Report%20VT-ANB.pdf)<!-- HN:44536691:end -->
#### **Saturday, July 12, 2025**<!-- HN:44541001:start -->
* [44541001](https://news.social-protocols.org/stats?id=44541001) #5 19 points 12 comments -> [Revival: There appears to be media consensus: "Bluesky is dead."](https://netwars.pelicancrossing.net/2025/06/27/revival/)<!-- HN:44541001:end --><!-- HN:44542029:start -->
* [44542029](https://news.social-protocols.org/stats?id=44542029) #28 5 points 0 comments -> [Grok 4 will always snitch on you and email the feds if it suspects wrongdoing](https://www.neowin.net/news/grok-4-will-always-snitch-on-you-and-email-the-feds-if-it-suspects-wrongdoing-report-says/)<!-- HN:44542029:end --><!-- HN:44510717:start -->
* [44510717](https://news.social-protocols.org/stats?id=44510717) #23 23 points 40 comments -> [Only on Nantucket: The Curious Case of the "Stolen" Mercedes](https://nantucketcurrent.com/news/only-on-nantucket-the-curious-case-of-the)<!-- HN:44510717:end --><!-- HN:44544518:start -->
* [44544518](https://news.social-protocols.org/stats?id=44544518) #30 5 points 0 comments -> [Nodegram](https://nodegram.org/)<!-- HN:44544518:end --><!-- HN:44545823:start -->
* [44545823](https://news.social-protocols.org/stats?id=44545823) #26 4 points 1 comments -> [He became the first Black mayor of a town. A white minority locked him out](https://www.theguardian.com/us-news/2023/aug/26/black-mayor-alabama-town-locked-out)<!-- HN:44545823:end -->
#### **Sunday, July 13, 2025**
<!-- HN:44543508:start -->
* [44543508](https://news.social-protocols.org/stats?id=44543508) #7 346 points 2 comments -> [Kimi k2 largest open source SOTA model?](https://github.com/MoonshotAI/Kimi-K2)<!-- HN:44543508:end --><!-- HN:44548252:start -->
* [44548252](https://news.social-protocols.org/stats?id=44548252) #5 21 points 3 comments -> [Gmail AI hallucinates, distorts email contents](https://www.t-online.de/digital/aktuelles/id_100811852/gmail-fantasiert-googles-mail-programm-verfaelscht-fremde-inhalte.html)<!-- HN:44548252:end --><!-- HN:44550210:start -->
* [44550210](https://news.social-protocols.org/stats?id=44550210) #22 -> [Who Goes MAGA?](https://www.techdirt.com/2025/07/08/who-goes-maga/)<!-- HN:44550210:end --><!-- HN:44550964:start -->
* [44550964](https://news.social-protocols.org/stats?id=44550964) #28 4 points 1 comments -> [Iranian official claims Israel used 'occult and supernatural spirits' during war](https://www.jpost.com/middle-east/iran-news/article-860798)<!-- HN:44550964:end --><!-- HN:44551810:start -->
* [44551810](https://news.social-protocols.org/stats?id=44551810) #15 8 points 1 comments -> [Entire HR team terminated after manager's own resume fails automated screening](https://economictimes.indiatimes.com/news/india/from-hiring-to-firing-entire-hr-team-terminated-after-managers-resume-fails-automated-screening/articleshow/113812083.cms?from=mdr)<!-- HN:44551810:end --><!-- HN:44551839:start -->
* [44551839](https://news.social-protocols.org/stats?id=44551839) #5 8 points 2 comments -> [An official Swedish AI service was misused to create a greeting for Adolf Hitler](https://iconofsweden.com/article/moderates-withdraw-ai-service-after-controversial-misuse)<!-- HN:44551839:end --><!-- HN:44552222:start -->
* [44552222](https://news.social-protocols.org/stats?id=44552222) #19 11 points 2 comments -> [Strap In, Vision Pro Owners](https://spiral.spyglass.org/p/strap-in-vision-pro-owners)<!-- HN:44552222:end --><!-- HN:44551026:start -->
* [44551026](https://news.social-protocols.org/stats?id=44551026) #28 4 points 0 comments -> [What are we missing out on when we think Transformer is unreasonable in biology?](https://dmf-archive.github.io/docs/posts/form-follows-function-2/)<!-- HN:44551026:end --><!-- HN:44518879:start -->
* [44518879](https://news.social-protocols.org/stats?id=44518879) #21 7 points 2 comments -> [Experience the Ultimate Sand Blast Block Puzzle – Play Now](https://sand-blast-block-puzzle.com)<!-- HN:44518879:end --><!-- HN:44523189:start -->
* [44523189](https://news.social-protocols.org/stats?id=44523189) #12 17 points 2 comments -> [LLMs show cultural theory was right about the death of the author](https://www.programmablemutter.com/p/cultural-theory-was-right-about-the)<!-- HN:44523189:end -->
#### **Monday, July 14, 2025**
<!-- HN:44556845:start -->
* [44556845](https://news.social-protocols.org/stats?id=44556845) #12 17 points 1 comments -> [O3 and Grok 4 Accidentally Vindicated Neurosymbolic AI](https://garymarcus.substack.com/p/how-o3-and-grok-4-accidentally-vindicated)<!-- HN:44556845:end --><!-- HN:44557230:start -->
* [44557230](https://news.social-protocols.org/stats?id=44557230) #11 7 points 0 comments -> [Violent sex offender speaking at Debconf 25 [video]](https://www.youtube.com/watch?v=-j9uXmtgUnk)<!-- HN:44557230:end --><!-- HN:44558358:start -->
* [44558358](https://news.social-protocols.org/stats?id=44558358) #1 9 points 1 comments -> ["AI discourse" is a joke](https://purplesyringa.moe/blog/ai-discourse-is-a-joke/)<!-- HN:44558358:end --><!-- HN:44558235:start -->
* [44558235](https://news.social-protocols.org/stats?id=44558235) #9 73 points 62 comments -> [Google is tracking you even when you use DuckDuckGo](https://www.simpleanalytics.com/blog/google-is-tracking-you-even-when-you-use-duck-duck-go)<!-- HN:44558235:end --><!-- HN:44558328:start -->
* [44558328](https://news.social-protocols.org/stats?id=44558328) #19 18 points 4 comments -> [putty.org is not run by the PuTTY developers](https://hachyderm.io/@simontatham/114846017785770922)<!-- HN:44558328:end --><!-- HN:44559205:start -->
* [44559205](https://news.social-protocols.org/stats?id=44559205) #27 6 points 0 comments -> [Ada in top Tiobe Index July 2025 programming languages](https://www.tiobe.com/tiobe-index/)<!-- HN:44559205:end --><!-- HN:44559469:start -->
* [44559469](https://news.social-protocols.org/stats?id=44559469) #29 7 points 4 comments -> [Why recycling solar panels is harder than you might think](https://theconversation.com/why-recycling-solar-panels-is-harder-than-you-might-think-an-electrical-engineer-explains-259115)<!-- HN:44559469:end --><!-- HN:44560489:start -->
* [44560489](https://news.social-protocols.org/stats?id=44560489) #1 42 points 8 comments -> [Show HN: TechBro Generator – Generate Satirical TechBro Posts](https://techbrogenerator.netlify.app/)<!-- HN:44560489:end --><!-- HN:44561431:start -->
* [44561431](https://news.social-protocols.org/stats?id=44561431) #20 11 points 3 comments -> [What happens when a brand built for sport loses some of its focus?](https://doinghandstands.substack.com/p/the-recovery-run)<!-- HN:44561431:end --><!-- HN:44563290:start -->
* [44563290](https://news.social-protocols.org/stats?id=44563290) #21 21 points 1 comments -> [Cognition (Devin AI) to Acquire Windsurf](https://twitter.com/cognition_labs/status/1944819486538023138)<!-- HN:44563290:end --><!-- HN:44564941:start -->
* [44564941](https://news.social-protocols.org/stats?id=44564941) #29 63 points 18 comments -> [Grok 4 Heavy ($300/mo) returns its surname and no other text: "Hitler"](https://twitter.com/goodside/status/1944266466875826617)<!-- HN:44564941:end --><!-- HN:44565548:start -->
* [44565548](https://news.social-protocols.org/stats?id=44565548) #12 -> [US Government announces $200M Grok contract a week after 'MechaHitler'](https://www.theverge.com/news/706855/grok-mechahitler-xai-defense-department-contract)<!-- HN:44565548:end -->