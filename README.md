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
* [44559205](https://news.social-protocols.org/stats?id=44559205) #27 6 points 0 comments -> [Ada in top Tiobe Index July 2025 programming languages](https://www.tiobe.com/tiobe-index/)<!-- HN:44559205:end --><!-- HN:44560489:start -->
* [44560489](https://news.social-protocols.org/stats?id=44560489) #1 42 points 8 comments -> [Show HN: TechBro Generator – Generate Satirical TechBro Posts](https://techbrogenerator.netlify.app/)<!-- HN:44560489:end --><!-- HN:44561431:start -->
* [44561431](https://news.social-protocols.org/stats?id=44561431) #20 11 points 3 comments -> [What happens when a brand built for sport loses some of its focus?](https://doinghandstands.substack.com/p/the-recovery-run)<!-- HN:44561431:end --><!-- HN:44563290:start -->
* [44563290](https://news.social-protocols.org/stats?id=44563290) #21 21 points 1 comments -> [Cognition (Devin AI) to Acquire Windsurf](https://twitter.com/cognition_labs/status/1944819486538023138)<!-- HN:44563290:end --><!-- HN:44564941:start -->
* [44564941](https://news.social-protocols.org/stats?id=44564941) #29 63 points 18 comments -> [Grok 4 Heavy ($300/mo) returns its surname and no other text: "Hitler"](https://twitter.com/goodside/status/1944266466875826617)<!-- HN:44564941:end --><!-- HN:44565548:start -->
* [44565548](https://news.social-protocols.org/stats?id=44565548) #12 -> [US Government announces $200M Grok contract a week after 'MechaHitler'](https://www.theverge.com/news/706855/grok-mechahitler-xai-defense-department-contract)<!-- HN:44565548:end -->
#### **Tuesday, July 15, 2025**<!-- HN:44568666:start -->
* [44568666](https://news.social-protocols.org/stats?id=44568666) #7 9 points 4 comments -> [We Tested 7 Languages Under Extreme Load and Only One Didn't Crash](https://freedium.cfd/https:/medium.com/@codeperfect/we-tested-7-languages-under-extreme-load-and-only-one-didnt-crash-it-wasn-t-what-we-expected-67f84c79dc34)<!-- HN:44568666:end --><!-- HN:44570021:start -->
* [44570021](https://news.social-protocols.org/stats?id=44570021) #7 17 points 2 comments -> [Google's Reverse Acquihire of Windsurf and the Future of AI Developer Tools](https://www.qodo.ai/blog/googles-reverse-acquihire-of-windsurf-a-glimpse-into-the-future-of-ai-developer-tools/)<!-- HN:44570021:end --><!-- HN:44567008:start -->
* [44567008](https://news.social-protocols.org/stats?id=44567008) #18 119 points 37 comments -> [Doge Denizen Marko Elez Leaked API Key for XAI](https://krebsonsecurity.com/2025/07/doge-denizen-marko-elez-leaked-api-key-for-xai/)<!-- HN:44567008:end --><!-- HN:44570380:start -->
* [44570380](https://news.social-protocols.org/stats?id=44570380) #2 3 points 0 comments -> [Aipac Hall of Shame](https://www.trackaipac.com/shame)<!-- HN:44570380:end --><!-- HN:44570513:start -->
* [44570513](https://news.social-protocols.org/stats?id=44570513) #22 3 points 0 comments -> [Why cultural heritage is important for community resilience](https://phys.org/news/2025-07-experts-reveal-cultural-heritage-important.html)<!-- HN:44570513:end --><!-- HN:44571193:start -->
* [44571193](https://news.social-protocols.org/stats?id=44571193) #18 5 points 1 comments -> [Irish tourist jailed by Ice for months](https://www.irishexaminer.com/news/arid-41670047.html)<!-- HN:44571193:end --><!-- HN:44571954:start -->
* [44571954](https://news.social-protocols.org/stats?id=44571954) #23 16 points 2 comments -> [Secret changes to major U.S. health datasets raise alarms](https://www.psypost.org/secret-changes-to-major-u-s-health-datasets-raise-alarms/)<!-- HN:44571954:end --><!-- HN:44572792:start -->
* [44572792](https://news.social-protocols.org/stats?id=44572792) #5 -> [Marc Andreessen Is a Traitor](https://www.liberalcurrents.com/marc-andreessen-is-a-traitor/)<!-- HN:44572792:end --><!-- HN:44574086:start -->
* [44574086](https://news.social-protocols.org/stats?id=44574086) #22 14 points 5 comments -> [ICE Lawyers Are Hiding Their Names in Court](https://theintercept.com/2025/07/15/ice-lawyers-hiding-names-court/)<!-- HN:44574086:end --><!-- HN:44574517:start -->
* [44574517](https://news.social-protocols.org/stats?id=44574517) #3 15 points 5 comments -> [AI coding may not be helping as much as you think](https://garymarcus.substack.com/p/breaking-news-ai-coding-may-not-be)<!-- HN:44574517:end --><!-- HN:44574382:start -->
* [44574382](https://news.social-protocols.org/stats?id=44574382) #23 24 points 43 comments -> [Meta announces new data centers, gobble up millions of gallons of water per day](https://www.engadget.com/ai/meta-announces-huge-new-data-centers-but-they-could-gobble-up-millions-of-gallons-of-water-per-day-174000478.html)<!-- HN:44574382:end --><!-- HN:44573799:start -->
* [44573799](https://news.social-protocols.org/stats?id=44573799) #25 27 points 7 comments -> [Open-source framework for real-time AI voice](https://github.com/videosdk-live/agents)<!-- HN:44573799:end --><!-- HN:44574860:start -->
* [44574860](https://news.social-protocols.org/stats?id=44574860) #13 6 points 4 comments -> [A new agentic IDE by AWS](https://kiroai.net)<!-- HN:44574860:end --><!-- HN:44573840:start -->
* [44573840](https://news.social-protocols.org/stats?id=44573840) #15 27 points 22 comments -> [Why my p(doom) has risen, dramatically](https://garymarcus.substack.com/p/why-my-pdoom-has-risen-dramatically)<!-- HN:44573840:end --><!-- HN:44575998:start -->
* [44575998](https://news.social-protocols.org/stats?id=44575998) #20 16 points 11 comments -> [US Government announces $200M Grok contract a week after 'MechaHitler'](https://www.theverge.com/news/706855/grok-mechahitler-xai-defense-department-contract)<!-- HN:44575998:end --><!-- HN:44574204:start -->
* [44574204](https://news.social-protocols.org/stats?id=44574204) #5 60 points 1 comments -> [Mistralai/Voxtral-Mini-3B-2507 · Hugging Face](https://huggingface.co/mistralai/Voxtral-Mini-3B-2507)<!-- HN:44574204:end --><!-- HN:44574095:start -->
* [44574095](https://news.social-protocols.org/stats?id=44574095) #3 125 points 2 comments -> [Encrypting Files with Passkeys and Age](https://words.filippo.io/passkey-encryption/)<!-- HN:44574095:end --><!-- HN:44576762:start -->
* [44576762](https://news.social-protocols.org/stats?id=44576762) #12 23 points 10 comments -> [Huawei's star AI model was built on burnout and plagiarism](https://the-open-source-ward.ghost.io/the-pangu-illusion-how-huaweis-star-ai-model-was-built-on-burnout-betrayal-and-open-source-theft/)<!-- HN:44576762:end -->
#### **Wednesday, July 16, 2025**
<!-- HN:44577263:start -->
* [44577263](https://news.social-protocols.org/stats?id=44577263) #28 9 points 2 comments -> [Nvidia chips become the first GPUs to fall to Rowhammer bit-flip attacks](https://arstechnica.com/security/2025/07/nvidia-chips-become-the-first-gpus-to-fall-to-rowhammer-bit-flip-attacks/)<!-- HN:44577263:end --><!-- HN:44578308:start -->
* [44578308](https://news.social-protocols.org/stats?id=44578308) #2 7 points 1 comments -> [Plasma Bigscreen – open-source user interface for TV](https://plasma-bigscreen.org)<!-- HN:44578308:end --><!-- HN:44578558:start -->
* [44578558](https://news.social-protocols.org/stats?id=44578558) #9 6 points 5 comments -> [Run LLM Agents as Microservices with One-Click Deployment](https://agentainer.io/)<!-- HN:44578558:end --><!-- HN:44580777:start -->
* [44580777](https://news.social-protocols.org/stats?id=44580777) #14 7 points 1 comments -> [What Jane Street did was plain old-fashioned manipulation](https://thefederal.com/category/business/jane-street-fo-markets-whistleblower-mayank-bansal-197061)<!-- HN:44580777:end --><!-- HN:44585286:start -->
* [44585286](https://news.social-protocols.org/stats?id=44585286) #3 12 points 2 comments -> [The party trick called LLM](https://destaatvanhetweb.nl/2025/07/12/the-party-trick-called-llm-blowing-away-smoke-and-break-some-mirrors/)<!-- HN:44585286:end -->
#### **Thursday, July 17, 2025**
<!-- HN:44589650:start -->
* [44589650](https://news.social-protocols.org/stats?id=44589650) #9 3 points 1 comments -> [Theory of Everything: Solved](https://github.com/Cosmolalia/TOE)<!-- HN:44589650:end --><!-- HN:44590422:start -->
* [44590422](https://news.social-protocols.org/stats?id=44590422) #9 32 points 41 comments -> [Treating beef like coal would make a big dent in greenhouse-gas emissions](https://www.economist.com/graphic-detail/2021/10/02/treating-beef-like-coal-would-make-a-big-dent-in-greenhouse-gas-emissions)<!-- HN:44590422:end --><!-- HN:44589833:start -->
* [44589833](https://news.social-protocols.org/stats?id=44589833) #29 31 points 13 comments -> [Show HN: Linux CLI tool to provide mutex locks for long running bash ops](https://github.com/bigattichouse/waitlock)<!-- HN:44589833:end --><!-- HN:44591521:start -->
* [44591521](https://news.social-protocols.org/stats?id=44591521) #18 5 points 0 comments -> [Show HN: Agent bypasses LLM context-window limit,read and edit &gt;10k LOC reliably](https://marketplace.visualstudio.com/items?itemName=Sixth.sixth-ai)<!-- HN:44591521:end --><!-- HN:44592876:start -->
* [44592876](https://news.social-protocols.org/stats?id=44592876) #29 14 points 4 comments -> [Texas has banned talking on college campuses at night. Seriously](https://www.houstonchronicle.com/opinion/outlook/article/texas-ban-universities-speech-talking-night-20361753.php)<!-- HN:44592876:end --><!-- HN:44591785:start -->
* [44591785](https://news.social-protocols.org/stats?id=44591785) #23 32 points 41 comments -> [Voting age to be lowered to 16 in UK by next general election](https://www.theguardian.com/politics/2025/jul/17/voting-age-to-be-lowered-to-16-in-england-and-northern-ireland)<!-- HN:44591785:end --><!-- HN:44594140:start -->
* [44594140](https://news.social-protocols.org/stats?id=44594140) #23 20 points 41 comments -> [FDA Authorizes Juul E-Cigarettes](https://www.wsj.com/business/fda-authorizes-juul-e-cigarettes-6ad37963)<!-- HN:44594140:end --><!-- HN:44595406:start -->
* [44595406](https://news.social-protocols.org/stats?id=44595406) #23 15 points 7 comments -> [AI tools slowed down experienced devs by 19%, study finds](https://leaddev.com/velocity/ai-doesnt-make-devs-as-productive-as-they-think-study-finds)<!-- HN:44595406:end --><!-- HN:44595898:start -->
* [44595898](https://news.social-protocols.org/stats?id=44595898) #20 8 points 6 comments -> [15,000+ AI-generated fake podcasts](https://www.kaggle.com/datasets/listennotes/ai-generated-fake-podcasts-spams)<!-- HN:44595898:end --><!-- HN:44596371:start -->
* [44596371](https://news.social-protocols.org/stats?id=44596371) #22 11 points 2 comments -> [Sen. Warren on Mamdani: He's willing to try new ideas to bring down costs for NY [video]](https://www.youtube.com/watch?v=MWrDi3acZcg)<!-- HN:44596371:end --><!-- HN:44596764:start -->
* [44596764](https://news.social-protocols.org/stats?id=44596764) #26 7 points 0 comments -> ["Even God Cannot Hear Us Here": What I Witnessed Inside an ICE Women's Prison](https://www.vanityfair.com/news/story/rumeysa-ozturk-what-i-witnessed-inside-an-ice-womens-prison)<!-- HN:44596764:end --><!-- HN:44596880:start -->
* [44596880](https://news.social-protocols.org/stats?id=44596880) #7 4 points 1 comments -> [Kiro Pauses Downloads](https://kiro.dev/downloads/)<!-- HN:44596880:end --><!-- HN:44596209:start -->
* [44596209](https://news.social-protocols.org/stats?id=44596209) #15 4 points 1 comments -> [Vibe Check: OpenAI Enters the Browser Wars with ChatGPT Agent](https://every.to/vibe-check/vibe-check-openai-enters-the-browser-wars-with-chatgpt-agent)<!-- HN:44596209:end --><!-- HN:44598153:start -->
* [44598153](https://news.social-protocols.org/stats?id=44598153) #20 8 points 1 comments -> [Fascism for First Time Founders](https://www.techdirt.com/2025/07/17/fascism-for-first-time-founders/)<!-- HN:44598153:end --><!-- HN:44562168:start -->
* [44562168](https://news.social-protocols.org/stats?id=44562168) #21 10 points 7 comments -> [Show HN: Google Maps can't map a story – MapScroll does, from one prompt](https://www.mapscroll.ai/)<!-- HN:44562168:end --><!-- HN:44590350:start -->
* [44590350](https://news.social-protocols.org/stats?id=44590350) #28 132 points 66 comments -> [Code Execution Through Email: How I Used Claude to Hack Itself](https://www.pynt.io/blog/llm-security-blogs/code-execution-through-email-how-i-used-claude-mcp-to-hack-itself)<!-- HN:44590350:end --><!-- HN:44598716:start -->
* [44598716](https://news.social-protocols.org/stats?id=44598716) #25 7 points 0 comments -> [What I Witnessed Inside an ICE Women's Prison](https://www.vanityfair.com/news/story/rumeysa-ozturk-what-i-witnessed-inside-an-ice-womens-prison)<!-- HN:44598716:end --><!-- HN:44598752:start -->
* [44598752](https://news.social-protocols.org/stats?id=44598752) #30 8 points 6 comments -> [White House Prepares Executive Order Targeting 'Woke AI'](https://www.wsj.com/tech/ai/white-house-prepares-executive-order-targeting-woke-ai-e68e8e24)<!-- HN:44598752:end -->
#### **Friday, July 18, 2025**
<!-- HN:44599936:start -->
* [44599936](https://news.social-protocols.org/stats?id=44599936) #20 12 points 2 comments -> [Felix Baumgartner, who jumped from edge of space, dies in paragliding accident](https://www.theguardian.com/sport/2025/jul/18/skydive-pioneer-felix-baumgartner-who-jumped-from-edge-of-space-dies-in-paragliding-accident)<!-- HN:44599936:end --><!-- HN:44603096:start -->
* [44603096](https://news.social-protocols.org/stats?id=44603096) #8 15 points 40 comments -> [Crypto's Wild West Era Is Over](https://gizmodo.com/cryptos-wild-west-era-is-over-2000631148)<!-- HN:44603096:end --><!-- HN:44606117:start -->
* [44606117](https://news.social-protocols.org/stats?id=44606117) #28 7 points 3 comments -> [The Number Go Up Rule: Why America Can't Fix Anything](https://www.thebignewsletter.com/p/the-number-go-up-rule-why-america)<!-- HN:44606117:end --><!-- HN:44607878:start -->
* [44607878](https://news.social-protocols.org/stats?id=44607878) #9 -> [The Amazon Layoffs You Didn't See Coming](https://thejobchicksinsideredge.substack.com/p/inside-amazons-offshoring-playbook)<!-- HN:44607878:end --><!-- HN:44608006:start -->
* [44608006](https://news.social-protocols.org/stats?id=44608006) #30 4 points 0 comments -> ['Gaza: Doctors Under Attack', a film that the BBC refused to air is out now](https://zeteo.com/p/watch-now-gaza-doctors-under-attack)<!-- HN:44608006:end --><!-- HN:44608468:start -->
* [44608468](https://news.social-protocols.org/stats?id=44608468) #3 14 points 8 comments -> [Everything You Need to Know About Grok 4](https://forgecode.dev/blog/grok-4-initial-impression/)<!-- HN:44608468:end --><!-- HN:44608669:start -->
* [44608669](https://news.social-protocols.org/stats?id=44608669) #27 8 points 0 comments -> [Lookism](https://en.wikipedia.org/wiki/Lookism)<!-- HN:44608669:end --><!-- HN:44576314:start -->
* [44576314](https://news.social-protocols.org/stats?id=44576314) #17 5 points 1 comments -> [I call them "Loop Bots"](https://www.imaurer.com/blog/posts/2025-07-15-i-call-them-loop-bots/)<!-- HN:44576314:end -->
#### **Saturday, July 19, 2025**
<!-- HN:44610623:start -->
* [44610623](https://news.social-protocols.org/stats?id=44610623) #17 60 points 40 comments -> [I'm Rebelling Against the Algorithm](https://varunraghu.com/im-rebelling-against-the-algorithm/)<!-- HN:44610623:end --><!-- HN:44613511:start -->
* [44613511](https://news.social-protocols.org/stats?id=44613511) #8 6 points 1 comments -> [Free BDSM Test – Discover Your True Role](https://bdsmtest.pro/)<!-- HN:44613511:end --><!-- HN:44614764:start -->
* [44614764](https://news.social-protocols.org/stats?id=44614764) #23 9 points 1 comments -> [Google Helped Israel Spread War Propaganda to 45M Europeans](https://scheerpost.com/2025/07/17/exclusive-google-helped-israel-spread-war-propaganda-to-45-million-europeans/)<!-- HN:44614764:end --><!-- HN:44614969:start -->
* [44614969](https://news.social-protocols.org/stats?id=44614969) #18 10 points 2 comments -> [OpenAI achieved gold medal-level performance on the 2025 IMO](https://twitter.com/polynoamial/status/1946478249187377206)<!-- HN:44614969:end --><!-- HN:44614853:start -->
* [44614853](https://news.social-protocols.org/stats?id=44614853) #15 16 points 5 comments -> [Show HN: I wanted better book recommendations – so I made Lorekeep](https://www.lorekeep.io/)<!-- HN:44614853:end -->