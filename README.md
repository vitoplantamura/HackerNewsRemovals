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

#### **Friday, July 4, 2025**
<!-- HN:44461158:start -->
* [44461158](https://news.social-protocols.org/stats?id=44461158) #13 49 points 26 comments -> [White House claims expansive power to nullify TikTok ban and other laws](https://www.nytimes.com/2025/07/03/us/politics/trump-bondi-tiktok-executive-power.html)<!-- HN:44461158:end --><!-- HN:44461368:start -->
* [44461368](https://news.social-protocols.org/stats?id=44461368) #30 36 points 13 comments -> [Google says "not a security vulnerability", quickly fixes without attribution](https://groups.google.com/g/certificate-transparency/c/u8SsXgSFbz4/m/CThyzj-QBAAJ)<!-- HN:44461368:end --><!-- HN:44462361:start -->
* [44462361](https://news.social-protocols.org/stats?id=44462361) #9 6 points 0 comments -> [Show HN: Soham Agent – Write cold emails like Soham Parekh](https://buildthatidea.com/sohamagent/6c604d4f-caac-475f-b489-d568210f905a)<!-- HN:44462361:end --><!-- HN:44466737:start -->
* [44466737](https://news.social-protocols.org/stats?id=44466737) #2 12 points 0 comments -> [There's No Undo Button for Our Fallen Democracy](https://kottke.org/25/07/theres-no-undo-button-for-our-fallen-democracy)<!-- HN:44466737:end --><!-- HN:44468083:start -->
* [44468083](https://news.social-protocols.org/stats?id=44468083) #21 30 points 16 comments -> [Tesla's Cybertruck flop is historic. The brand collapse is even worse](https://www.dailykos.com/stories/2025/7/3/2331384/-Tesla-s-Cybertruck-flop-is-historic-The-brand-collapse-is-even-worse)<!-- HN:44468083:end -->
#### **Saturday, July 5, 2025**
<!-- HN:44466896:start -->
* [44466896](https://news.social-protocols.org/stats?id=44466896) #9 124 points 4 comments -> [Eight dormant Satoshi-era Bitcoin wallets reactivated after 14 yrs](https://twitter.com/WatcherGuru/status/1941167512491864554)<!-- HN:44466896:end --><!-- HN:44469798:start -->
* [44469798](https://news.social-protocols.org/stats?id=44469798) #16 32 points 16 comments -> [Amiga Linux (1993)](https://groups.google.com/g/comp.sys.amiga.emulations/c/xUgrpylQOXk)<!-- HN:44469798:end --><!-- HN:44470803:start -->
* [44470803](https://news.social-protocols.org/stats?id=44470803) #12 49 points 17 comments -> [French City of Lyon Kicks Out Microsoft](https://news.itsfoss.com/french-city-replaces-microsoft/)<!-- HN:44470803:end --><!-- HN:44471861:start -->
* [44471861](https://news.social-protocols.org/stats?id=44471861) #27 5 points 1 comments -> [Cars' Forward Blind Zones Are Worse Now Than 25 Years Ago](https://www.caranddriver.com/news/a65219830/car-blind-zones-study-iihs/)<!-- HN:44471861:end --><!-- HN:44432895:start -->
* [44432895](https://news.social-protocols.org/stats?id=44432895) #1 33 points 2 comments -> [How AI on Microcontrollers Works: Operators and Kernels](https://danielmangum.com/posts/ai-microcontrollers-operators-kernels/)<!-- HN:44432895:end --><!-- HN:44472884:start -->
* [44472884](https://news.social-protocols.org/stats?id=44472884) #21 6 points 0 comments -> [Before releasing a new AI model Sam Altman would be put into a Server room](https://twitter.com/the_yanco/status/1941388896387875282)<!-- HN:44472884:end --><!-- HN:44473098:start -->
* [44473098](https://news.social-protocols.org/stats?id=44473098) #26 7 points 2 comments -> [Musk and co should ask AI what defines intelligence. They may learn something](https://observer.co.uk/news/columnists/article/musk-and-co-should-ask-an-ai-what-defines-intelligence-they-may-learn-something)<!-- HN:44473098:end --><!-- HN:44473436:start -->
* [44473436](https://news.social-protocols.org/stats?id=44473436) #9 7 points 7 comments -> [How U.S. Tourists Are Dealing with a New Animosity Overseas](https://www.wsj.com/lifestyle/travel/american-international-travel-tips-0a70af73)<!-- HN:44473436:end --><!-- HN:44473638:start -->
* [44473638](https://news.social-protocols.org/stats?id=44473638) #5 -> [The "Big Beautiful Bill" destroys science, freedom, equality, and democracy](https://news.immunologic.org/p/rip-america-or-at-least-the-american)<!-- HN:44473638:end --><!-- HN:44473677:start -->
* [44473677](https://news.social-protocols.org/stats?id=44473677) #10 40 points 8 comments -> [Goodbye to All That – My Resignation from the FBI](https://www.lawfaremedia.org/article/goodbye-to-all-that)<!-- HN:44473677:end --><!-- HN:44473711:start -->
* [44473711](https://news.social-protocols.org/stats?id=44473711) #4 48 points 17 comments -> [ApplePay vs. Alternative Payment Services](https://www.taler.net/en/news/2025-05.html)<!-- HN:44473711:end --><!-- HN:44474460:start -->
* [44474460](https://news.social-protocols.org/stats?id=44474460) #4 7 points 1 comments -> [Two years ago today, Meta launched Threads. Does the world need this app?](https://stylestitches.substack.com/p/who-really-needs-threads)<!-- HN:44474460:end --><!-- HN:44473590:start -->
* [44473590](https://news.social-protocols.org/stats?id=44473590) #14 157 points 58 comments -> [Local-First Software Is Easier to Scale](https://elijahpotter.dev/articles/local-first_software_is_easier_to_scale)<!-- HN:44473590:end -->
#### **Sunday, July 6, 2025**
<!-- HN:44476502:start -->
* [44476502](https://news.social-protocols.org/stats?id=44476502) #3 6 points 3 comments -> [I Shipped a macOS App Built by Claude Code](https://www.indragie.com/blog/i-shipped-a-macos-app-built-entirely-by-claude-code)<!-- HN:44476502:end --><!-- HN:44476774:start -->
* [44476774](https://news.social-protocols.org/stats?id=44476774) #12 15 points 4 comments -> ['It's too late': David Suzuki says the fight against climate change is lost](https://www.ipolitics.ca/2025/07/02/its-too-late-david-suzuki-says-the-fight-against-climate-change-is-lost/)<!-- HN:44476774:end --><!-- HN:44477394:start -->
* [44477394](https://news.social-protocols.org/stats?id=44477394) #19 -> [I live in TX and TX needs to do better. Global warming cannot be denied](https://www.cnn.com/2025/07/05/climate/texas-flooding-forecast-response)<!-- HN:44477394:end --><!-- HN:44477648:start -->
* [44477648](https://news.social-protocols.org/stats?id=44477648) #24 9 points 2 comments -> [As Floods Hit, Key Roles Were Vacant at Weather Service Offices in Texas](https://www.nytimes.com/2025/07/05/us/politics/texas-floods-warnings-vacancies.html)<!-- HN:44477648:end --><!-- HN:44477512:start -->
* [44477512](https://news.social-protocols.org/stats?id=44477512) #7 19 points 8 comments -> [Zuck's Haul: Tracking Meta's AI Talent Acquisitions](https://zuckshaul.com)<!-- HN:44477512:end --><!-- HN:44477785:start -->
* [44477785](https://news.social-protocols.org/stats?id=44477785) #7 6 points 0 comments -> [Anubis – Open-Source Web AI Firewall Utility](https://github.com/TecharoHQ/anubis)<!-- HN:44477785:end --><!-- HN:44478737:start -->
* [44478737](https://news.social-protocols.org/stats?id=44478737) #11 34 points 29 comments -> [Triffin Dilemma: How the US Genius Act Could Trigger a 'Digital Nixon Shock](https://www.haebom.dev/archive?tl=en&post=943zqpmqrk14g2wnvy87)<!-- HN:44478737:end --><!-- HN:44480389:start -->
* [44480389](https://news.social-protocols.org/stats?id=44480389) #26 7 points 0 comments -> [Guide to Ukraine's Long Range Attack Drones](http://www.hisutton.com/Ukraine-OWA-UAVs.html)<!-- HN:44480389:end --><!-- HN:44481949:start -->
* [44481949](https://news.social-protocols.org/stats?id=44481949) #20 4 points 0 comments -> [C mistakes among the vulnerabilities present in curl code](https://mastodon.social/@bagder/114806766613678922)<!-- HN:44481949:end --><!-- HN:44481964:start -->
* [44481964](https://news.social-protocols.org/stats?id=44481964) #24 16 points 2 comments -> [ChatGPT is pushing people towards mania, psychosis and death](https://www.the-independent.com/tech/chatgpt-psychosis-ai-therapy-chatbot-b2781202.html)<!-- HN:44481964:end -->
#### **Monday, July 7, 2025**
<!-- HN:44482611:start -->
* [44482611](https://news.social-protocols.org/stats?id=44482611) #22 66 points 4 comments -> [Cool People [pdf]](https://www.apa.org/pubs/journals/releases/xge-xge0001799.pdf)<!-- HN:44482611:end --><!-- HN:44485027:start -->
* [44485027](https://news.social-protocols.org/stats?id=44485027) #10 24 points 3 comments -> ["Do not highlight any negatives"](https://www.google.com/search?q=%22do+not+highlight+any+negatives%22+site%3Aarxiv.org)<!-- HN:44485027:end --><!-- HN:44486193:start -->
* [44486193](https://news.social-protocols.org/stats?id=44486193) #20 15 points 28 comments -> [Web3 Onboarding Was a Flop – and Thank Goodness](https://tomhadley.link/blog/web3-onboarding-flop)<!-- HN:44486193:end --><!-- HN:44480284:start -->
* [44480284](https://news.social-protocols.org/stats?id=44480284) #28 118 points 2 comments -> [Stop killing games and the industry response](https://blog.kronis.dev/blog/stop-killing-games)<!-- HN:44480284:end --><!-- HN:44485336:start -->
* [44485336](https://news.social-protocols.org/stats?id=44485336) #27 61 points 12 comments -> [There's a COMPUTER inside my DS flashcart [video]](https://www.youtube.com/watch?v=uq0pJmd7GAA)<!-- HN:44485336:end --><!-- HN:44494117:start -->
* [44494117](https://news.social-protocols.org/stats?id=44494117) #11 3 points 1 comments -> [The 'ChatGPT Moment' in Robotics and Beyond](https://paritoshmohan.substack.com/p/the-chatgpt-moment-in-robotics-and)<!-- HN:44494117:end --><!-- HN:44494401:start -->
* [44494401](https://news.social-protocols.org/stats?id=44494401) #27 4 points 1 comments -> [An Open Letter to the Leadership of Sequoia Capital](https://shaunmaguire.fyi/)<!-- HN:44494401:end -->
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
* [44515650](https://news.social-protocols.org/stats?id=44515650) #30 6 points 1 comments -> [Show HN: I built a social media app at 11 using AI and a phone](https://app--woo-short-78d020b9.base44.app)<!-- HN:44515650:end -->