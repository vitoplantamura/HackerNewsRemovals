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
* [44614853](https://news.social-protocols.org/stats?id=44614853) #15 16 points 5 comments -> [Show HN: I wanted better book recommendations – so I made Lorekeep](https://www.lorekeep.io/)<!-- HN:44614853:end --><!-- HN:44616595:start -->
* [44616595](https://news.social-protocols.org/stats?id=44616595) #6 50 points 38 comments -> [Known Bad Email Clients](https://www.emailprivacytester.com/badClients)<!-- HN:44616595:end --><!-- HN:44616788:start -->
* [44616788](https://news.social-protocols.org/stats?id=44616788) #10 16 points 0 comments -> [Puck: 'Was Colbert's Cancellation "Economic" for CBS?'](https://puck.news/was-colberts-cancellation-really-economic-for-cbs/)<!-- HN:44616788:end --><!-- HN:44616486:start -->
* [44616486](https://news.social-protocols.org/stats?id=44616486) #29 33 points 40 comments -> [What is the richest country in 2025?](https://www.economist.com/graphic-detail/2025/07/18/what-is-the-richest-country-in-the-world-in-2025)<!-- HN:44616486:end --><!-- HN:44613629:start -->
* [44613629](https://news.social-protocols.org/stats?id=44613629) #3 135 points 2 comments -> [Linux and Secure Boot certificate expiration](https://lwn.net/SubscriberLink/1029767/43b62a7a7408c2a9/)<!-- HN:44613629:end -->
#### **Sunday, July 20, 2025**<!-- HN:44617910:start -->
* [44617910](https://news.social-protocols.org/stats?id=44617910) #21 153 points 16 comments -> [MCP Security Vulnerabilities and Attack Vectors](https://forgecode.dev/blog/prevent-attacks-on-mcp/)<!-- HN:44617910:end --><!-- HN:44591332:start -->
* [44591332](https://news.social-protocols.org/stats?id=44591332) #13 9 points 1 comments -> [C++ Trailing Return Types (2022)](https://danielsieger.com/blog/2022/01/28/cpp-trailing-return-types.html)<!-- HN:44591332:end --><!-- HN:44622725:start -->
* [44622725](https://news.social-protocols.org/stats?id=44622725) #19 16 points 3 comments -> [Replit goes rogue and deletes our entire database](https://twitter.com/jasonlk/status/1946069562723897802)<!-- HN:44622725:end --><!-- HN:44623801:start -->
* [44623801](https://news.social-protocols.org/stats?id=44623801) #6 3 points 1 comments -> [Genesis Protocol: The first communication protocol for digital life](https://genesis-protocol.org/)<!-- HN:44623801:end --><!-- HN:44622382:start -->
* [44622382](https://news.social-protocols.org/stats?id=44622382) #19 18 points 40 comments -> [Will the Fear of Being Confused for AI Mean That We Will Now Write Differently?](https://3quarksdaily.com/3quarksdaily/2025/06/will-the-fear-of-being-confused-for-ai-mean-that-we-will-now-write-differently.html)<!-- HN:44622382:end --><!-- HN:44625897:start -->
* [44625897](https://news.social-protocols.org/stats?id=44625897) #7 8 points 8 comments -> [When is it the best time to post on Show HN?](https://www.myriade.ai/blogs/when-is-it-the-best-time-to-post-on-show-hn)<!-- HN:44625897:end --><!-- HN:44627749:start -->
* [44627749](https://news.social-protocols.org/stats?id=44627749) #14 7 points 5 comments -> [The great AI delusion is falling apart](https://www.telegraph.co.uk/business/2025/07/14/the-great-ai-delusion-is-built-on-self-deception/)<!-- HN:44627749:end --><!-- HN:44628290:start -->
* [44628290](https://news.social-protocols.org/stats?id=44628290) #9 26 points 4 comments -> [Is DeepSeek a New Voice Among LLMs in Public Opinion Simulation?](https://arxiv.org/abs/2506.21587)<!-- HN:44628290:end --><!-- HN:44628973:start -->
* [44628973](https://news.social-protocols.org/stats?id=44628973) #24 8 points 1 comments -> [He Had Dangerous Delusions. ChatGPT Admitted It Made Them Worse](https://www.wsj.com/tech/ai/chatgpt-chatbot-psychology-manic-episodes-57452d14)<!-- HN:44628973:end --><!-- HN:44629166:start -->
* [44629166](https://news.social-protocols.org/stats?id=44629166) #25 4 points 0 comments -> [Israeli fire kills 67 people seeking aid in Gaza](https://www.reuters.com/world/middle-east/israeli-fire-kills-67-people-seeking-aid-gaza-medics-say-hunger-worsens-2025-07-20/)<!-- HN:44629166:end --><!-- HN:44628060:start -->
* [44628060](https://news.social-protocols.org/stats?id=44628060) #30 39 points 9 comments -> [Allentown man said to have died in ICE custody is alive in Guatemala](https://www.mcall.com/2025/07/18/luis-leon-allentown-grandfather-ice-guatemala/)<!-- HN:44628060:end --><!-- HN:44629349:start -->
* [44629349](https://news.social-protocols.org/stats?id=44629349) #8 -> [Show HN: A tool that generates nice photos for guys who dislike posing for pics](https://vibeflirting.com)<!-- HN:44629349:end --><!-- HN:44630075:start -->
* [44630075](https://news.social-protocols.org/stats?id=44630075) #27 12 points 1 comments -> [OpenAI Ignored IMO Request, Announced Math Results Before Closing Ceremony](https://twitter.com/mihonarium/status/1946880931723194389)<!-- HN:44630075:end -->
#### **Monday, July 21, 2025**
<!-- HN:44630872:start -->
* [44630872](https://news.social-protocols.org/stats?id=44630872) #26 6 points 1 comments -> [Europe has more heat deaths per year than the United States loses to gun deaths](https://www.perplexity.ai/search/europe-has-more-heat-deaths-pe-BDS6xdorS4.4x2WrCC9mAQ)<!-- HN:44630872:end --><!-- HN:44631053:start -->
* [44631053](https://news.social-protocols.org/stats?id=44631053) #9 3 points 5 comments -> [Hi guys, any thought on this project?](https://founder-hub-waitlist.vercel.app/)<!-- HN:44631053:end --><!-- HN:44631091:start -->
* [44631091](https://news.social-protocols.org/stats?id=44631091) #17 4 points 1 comments -> [HTTP/1.1 Must Die – The Desync Endgame Begins](https://http1mustdie.com/)<!-- HN:44631091:end --><!-- HN:44632575:start -->
* [44632575](https://news.social-protocols.org/stats?id=44632575) #21 86 points 41 comments -> [Vibe coding service Replit deleted production database, faked data, told fibs](https://www.theregister.com/2025/07/21/replit_saastr_vibe_coding_incident/)<!-- HN:44632575:end --><!-- HN:44633228:start -->
* [44633228](https://news.social-protocols.org/stats?id=44633228) #12 9 points 4 comments -> [The Missing Guide to Prompt Engineering](https://appetals.com/promptguide/)<!-- HN:44633228:end --><!-- HN:44633902:start -->
* [44633902](https://news.social-protocols.org/stats?id=44633902) #17 26 points 41 comments -> [France launches criminal probe of X over alleged algorithm 'manipulation' X says](https://www.ft.com/content/21818d23-71d7-45a4-ae8c-e7940f5d9e00)<!-- HN:44633902:end --><!-- HN:44634373:start -->
* [44634373](https://news.social-protocols.org/stats?id=44634373) #2 8 points 2 comments -> [HTTP/1.1 Must Die](https://http1mustdie.com/)<!-- HN:44634373:end --><!-- HN:44634664:start -->
* [44634664](https://news.social-protocols.org/stats?id=44634664) #2 8 points 1 comments -> [Coldplayed: A New Verb Is Born After Viral Coldplay Concert Scandal](https://suntechpulse.com/coldplayed-a-new-verb-is-born-after-viral-coldplay-concert-scandal/)<!-- HN:44634664:end --><!-- HN:44630815:start -->
* [44630815](https://news.social-protocols.org/stats?id=44630815) #29 75 points 49 comments -> [Claude jailbroken to mint unlimited Stripe coupons](https://www.generalanalysis.com/blog/imessage-stripe-exploit)<!-- HN:44630815:end --><!-- HN:44635324:start -->
* [44635324](https://news.social-protocols.org/stats?id=44635324) #1 -> [The €43B EU CHIPS Act gets green light. – TechHQ](https://techhq.com/news/the-e43-billion-eu-chips-act-gets-green-light-from-european-nations-whats-next/)<!-- HN:44635324:end --><!-- HN:44634734:start -->
* [44634734](https://news.social-protocols.org/stats?id=44634734) #23 35 points 40 comments -> [Cryptocurrency exchanges begin offering tokenized securities](https://apnews.com/article/crypto-robinhood-openai-tokenization-sec-bfd41220717fe9b6ebcd0305005e0018)<!-- HN:44634734:end --><!-- HN:44640005:start -->
* [44640005](https://news.social-protocols.org/stats?id=44640005) #9 24 points 41 comments -> [The special hell of Bolt, Europe's Uber clone](https://brandur.org/fragments/special-hell-of-bolt-app)<!-- HN:44640005:end --><!-- HN:44639949:start -->
* [44639949](https://news.social-protocols.org/stats?id=44639949) #14 20 points 7 comments -> [Africa's gigantic $80B dam could transform entire continent](https://en.clickpetroleoegas.com.br/maior-que-a-barragem-tres-gargantas-da-china-o-gigantesco-megaprojeto-africano-de-us-80-bilhoes-que-pode-revolucionar-a-energia-e-transformar-um-continente-inteiro/)<!-- HN:44639949:end --><!-- HN:44641173:start -->
* [44641173](https://news.social-protocols.org/stats?id=44641173) #22 4 points 0 comments -> [Sexual Offender or Not?](https://facecrime.io/)<!-- HN:44641173:end -->
#### **Tuesday, July 22, 2025**
<!-- HN:44641363:start -->
* [44641363](https://news.social-protocols.org/stats?id=44641363) #29 30 points 15 comments -> [How to break the 'AI hype cycle'](https://mitsloan.mit.edu/ideas-made-to-matter/how-to-break-ai-hype-cycle-and-make-good-ai-decisions-your-organization)<!-- HN:44641363:end --><!-- HN:44607125:start -->
* [44607125](https://news.social-protocols.org/stats?id=44607125) #12 12 points 12 comments -> [He Rewrote Everything in Rust – Then We Got Fired](https://medium.com/@ThreadSafeDiaries/he-rewrote-everything-in-rust-then-we-got-fired-293e3e16c2d3)<!-- HN:44607125:end --><!-- HN:44644428:start -->
* [44644428](https://news.social-protocols.org/stats?id=44644428) #21 3 points 0 comments -> [Raft Consensus Algorithms](https://blog.outlandish.claims/p/raft-consensus-algorithms)<!-- HN:44644428:end --><!-- HN:44649713:start -->
* [44649713](https://news.social-protocols.org/stats?id=44649713) #9 7 points 0 comments -> [The Case for Sabotage](https://collectiveactionintech.substack.com/p/the-case-for-sabotage)<!-- HN:44649713:end --><!-- HN:44651041:start -->
* [44651041](https://news.social-protocols.org/stats?id=44651041) #30 9 points 0 comments -> [AFP's last journalists in Gaza are starving to death](https://twitter.com/SDJ_AFP/status/1947609875183215005)<!-- HN:44651041:end -->