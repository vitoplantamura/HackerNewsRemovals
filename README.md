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

#### **Wednesday, March 26, 2025**<!-- HN:43478162:start -->
* [43478162](https://news.social-protocols.org/stats?id=43478162) #17 7 points 0 comments -> [Phrack Issue 49, File 14: Smashing the Stack for Fun and Profit (1996)](https://phrack.org/issues/49/14)<!-- HN:43478162:end --><!-- HN:43477947:start -->
* [43477947](https://news.social-protocols.org/stats?id=43477947) #23 3 points 3 comments -> [OpenSMTPD and Maildrop working in concert](http://blog.whenhen.com/posts/opensmtpd-and-maildrop-working-in-concert.html)<!-- HN:43477947:end --><!-- HN:43478091:start -->
* [43478091](https://news.social-protocols.org/stats?id=43478091) #26 88 points 68 comments -> [CIA Director Reveals Signal Comes Installed on Agency Computers](https://theintercept.com/2025/03/25/signal-chat-encryption-hegseth-cia/)<!-- HN:43478091:end --><!-- HN:43469162:start -->
* [43469162](https://news.social-protocols.org/stats?id=43469162) #9 9 points 4 comments -> [Slow SMB Speeds over WiFi](https://forums.truenas.com/t/slow-smb-speeds-over-wifi/8529)<!-- HN:43469162:end --><!-- HN:43480210:start -->
* [43480210](https://news.social-protocols.org/stats?id=43480210) #14 10 points 10 comments -> [Anonymous Corpo Confessions](https://baserow.io/form/fhd_IgR1QDZzJX0tW7TRM__rs0Lv2-DRY3SLXkWUoE8)<!-- HN:43480210:end --><!-- HN:43476337:start -->
* [43476337](https://news.social-protocols.org/stats?id=43476337) #29 330 points 236 comments -> [Devs say AI crawlers dominate traffic, forcing blocks on entire countries](https://arstechnica.com/ai/2025/03/devs-say-ai-crawlers-dominate-traffic-forcing-blocks-on-entire-countries/)<!-- HN:43476337:end --><!-- HN:43483287:start -->
* [43483287](https://news.social-protocols.org/stats?id=43483287) #2 6 points 2 comments -> [Left Field – a dating app where your pool is who you cross paths with](https://apps.apple.com/us/app/left-field/id6738966547)<!-- HN:43483287:end --><!-- HN:43483255:start -->
* [43483255](https://news.social-protocols.org/stats?id=43483255) #1 15 points 3 comments -> [Show HN: New Agentic AI Framework in CNCF](https://github.com/dapr/dapr-agents)<!-- HN:43483255:end --><!-- HN:43482207:start -->
* [43482207](https://news.social-protocols.org/stats?id=43482207) #16 24 points 40 comments -> [The Gang of Four is wrong and you don't understand delegation (2012)](https://www.saturnflyer.com/blog/the-gang-of-four-is-wrong-and-you-dont-understand-delegation)<!-- HN:43482207:end --><!-- HN:43484467:start -->
* [43484467](https://news.social-protocols.org/stats?id=43484467) #3 12 points 2 comments -> [You have 5 days before the new DockerHub limits f*ck you over](https://www.blacksmith.sh/blog/you-have-5-days-before-the-new-dockerhub-limits-f-ck-you-over)<!-- HN:43484467:end --><!-- HN:43457754:start -->
* [43457754](https://news.social-protocols.org/stats?id=43457754) #17 15 points 0 comments -> [Exploring Ruby Ractors – I paid for for 10 cores I'm gonna use 10 cores](https://jpterry.com/posts/2025/03/exploring-ruby-ractors/)<!-- HN:43457754:end -->
#### **Thursday, March 27, 2025**<!-- HN:43493332:start -->
* [43493332](https://news.social-protocols.org/stats?id=43493332) #20 3 points 0 comments -> [Junior Devs: Avoid These Pitfalls with LLMs](https://spin.atomicobject.com/junior-dev-pitfalls-with-llm/)<!-- HN:43493332:end --><!-- HN:43494870:start -->
* [43494870](https://news.social-protocols.org/stats?id=43494870) #20 3 points 0 comments -> [eBay backs WunderGraph to build open source GraphQL federation](https://techcrunch.com/2025/03/27/ebay-backs-wundergraph-to-build-an-open-source-graphql-federation/)<!-- HN:43494870:end --><!-- HN:43495087:start -->
* [43495087](https://news.social-protocols.org/stats?id=43495087) #21 19 points 30 comments -> [People say they prefer stories written by humans over AI, study says otherwise](https://theconversation.com/people-say-they-prefer-stories-written-by-humans-over-ai-generated-works-yet-new-study-suggests-thats-not-quite-true-251347)<!-- HN:43495087:end --><!-- HN:43496474:start -->
* [43496474](https://news.social-protocols.org/stats?id=43496474) #14 6 points 1 comments -> [Ai2 Paper Finder](https://paperfinder.allen.ai/chat)<!-- HN:43496474:end --><!-- HN:43496517:start -->
* [43496517](https://news.social-protocols.org/stats?id=43496517) #2 14 points 0 comments -> [The Japanese Writing System Explained: Hiragana, Katakana and Kanji](https://www.kanjimaster.ai/blog/japanese-writing-system-hiragana-katakana-kanji)<!-- HN:43496517:end --><!-- HN:43497150:start -->
* [43497150](https://news.social-protocols.org/stats?id=43497150) #18 95 points 56 comments -> [SignalGate Is Driving the Most US Downloads of Signal Ever](https://www.wired.com/story/signalgate-is-driving-the-most-us-downloads-of-signal-ever/)<!-- HN:43497150:end --><!-- HN:43498176:start -->
* [43498176](https://news.social-protocols.org/stats?id=43498176) #25 8 points 2 comments -> [Web-based cryptography is always snake oil](https://www.devever.net/~hl/webcrypto)<!-- HN:43498176:end -->
#### **Friday, March 28, 2025**<!-- HN:43503207:start -->
* [43503207](https://news.social-protocols.org/stats?id=43503207) #19 17 points 0 comments -> [Postgres Extension Tutorial](https://github.com/IshaanAdarsh/Postgres-extension-tutorial/blob/main/SGML/intro_and_toc.md)<!-- HN:43503207:end --><!-- HN:43503004:start -->
* [43503004](https://news.social-protocols.org/stats?id=43503004) #14 47 points 11 comments -> [On Tyranny [book]](https://timothysnyder.org/on-tyranny)<!-- HN:43503004:end --><!-- HN:43499045:start -->
* [43499045](https://news.social-protocols.org/stats?id=43499045) #28 340 points 157 comments -> [Most promoted and blocked domains on Kagi](https://kagi.com/stats?stat=leaderboard)<!-- HN:43499045:end --><!-- HN:43504765:start -->
* [43504765](https://news.social-protocols.org/stats?id=43504765) #18 11 points 1 comments -> [Trump's FCC Starts Harassing Public Broadcasters with Bogus Investigations](https://www.techdirt.com/2025/03/28/trumps-fcc-starts-harassing-public-broadcasters-with-bogus-investigations/)<!-- HN:43504765:end --><!-- HN:43503505:start -->
* [43503505](https://news.social-protocols.org/stats?id=43503505) #29 5 points 0 comments -> [7.7M Violent Burma Earthquake](https://earthquake.usgs.gov/earthquakes/eventpage/us7000pn9s/pager)<!-- HN:43503505:end --><!-- HN:43505659:start -->
* [43505659](https://news.social-protocols.org/stats?id=43505659) #21 25 points 41 comments -> [Doge Plans to Rebuild SSA Codebase in Months](https://www.wired.com/story/doge-rebuild-social-security-administration-cobol-benefits/)<!-- HN:43505659:end --><!-- HN:43506421:start -->
* [43506421](https://news.social-protocols.org/stats?id=43506421) #29 4 points 0 comments -> [Gemini hackers can deliver more potent attacks with a helping hand from Gemini](https://arstechnica.com/security/2025/03/gemini-hackers-can-deliver-more-potent-attacks-with-a-helping-hand-from-gemini/)<!-- HN:43506421:end --><!-- HN:43510633:start -->
* [43510633](https://news.social-protocols.org/stats?id=43510633) #29 6 points 1 comments -> [ChatGPT 4o adds image generation and its fun as hell](https://daringfireball.net/linked/2025/03/28/chatgpt-4o-adds-image-generation-and-its-fun-as-hell)<!-- HN:43510633:end --><!-- HN:43510753:start -->
* [43510753](https://news.social-protocols.org/stats?id=43510753) #28 13 points 0 comments -> [RFK Jr. To Shut Down HHS Office of Infectious Diseases and HIV Policy](https://www.advocate.com/health/office-infectious-diseases-hiv-closing)<!-- HN:43510753:end --><!-- HN:43510816:start -->
* [43510816](https://news.social-protocols.org/stats?id=43510816) #13 5 points 0 comments -> [Rust Is Indeed Woke](https://diziet.dreamwidth.org/19480.html)<!-- HN:43510816:end -->
#### **Saturday, March 29, 2025**<!-- HN:43513811:start -->
* [43513811](https://news.social-protocols.org/stats?id=43513811) #23 141 points 65 comments -> [Trump's attacks on universities get darker, with shadows reaching our shores](https://christinapagel.substack.com/p/trumps-attacks-on-universities-get)<!-- HN:43513811:end --><!-- HN:43511464:start -->
* [43511464](https://news.social-protocols.org/stats?id=43511464) #9 168 points 65 comments -> [iCloud Mail has DNS misconfigured?](https://www.mail-tester.com/test-p3tdhnk3o)<!-- HN:43511464:end --><!-- HN:43478480:start -->
* [43478480](https://news.social-protocols.org/stats?id=43478480) #24 15 points 10 comments -> [Window cleaner in quest to confirm priceless Shakespeare portrait](https://www.bbc.com/news/articles/c5yr37nlzv8o)<!-- HN:43478480:end --><!-- HN:43482026:start -->
* [43482026](https://news.social-protocols.org/stats?id=43482026) #9 7 points 0 comments -> [I Went Undercover in Crypto's Answer to Squid Game. It Nearly Broke Me](https://www.wired.com/story/crypto-the-game-undercover/)<!-- HN:43482026:end --><!-- HN:43515268:start -->
* [43515268](https://news.social-protocols.org/stats?id=43515268) #28 10 points 0 comments -> [The Design of the New Swiss Passport](https://kottke.org/25/03/the-design-of-the-new-swiss-passport)<!-- HN:43515268:end --><!-- HN:43515169:start -->
* [43515169](https://news.social-protocols.org/stats?id=43515169) #28 12 points 2 comments -> [Therapy chatbot trial yields mental health benefits](https://home.dartmouth.edu/news/2025/03/first-therapy-chatbot-trial-yields-mental-health-benefits)<!-- HN:43515169:end --><!-- HN:43515676:start -->
* [43515676](https://news.social-protocols.org/stats?id=43515676) #28 4 points 0 comments -> [Targeting of Tufts Student for Deportation Stuns Friends and Teachers](https://www.nytimes.com/2025/03/29/us/rumeysa-ozturk-tufts-student-detained.html)<!-- HN:43515676:end --><!-- HN:43514459:start -->
* [43514459](https://news.social-protocols.org/stats?id=43514459) #8 24 points 2 comments -> [Building a search engine from scratch, in Rust: part 1](https://jdrouet.github.io/posts/202503170800-search-engine-part-1/)<!-- HN:43514459:end --><!-- HN:43515869:start -->
* [43515869](https://news.social-protocols.org/stats?id=43515869) #13 6 points 3 comments -> [ChatGPT is turning everything into Studio Ghibli art](https://www.theverge.com/openai/636529/images-chatgpt-openai-studio-ghibli-copyright)<!-- HN:43515869:end --><!-- HN:43475982:start -->
* [43475982](https://news.social-protocols.org/stats?id=43475982) #30 34 points 5 comments -> [The Curious Case of Beam CPU Usage (2019)](https://stressgrid.com/blog/beam_cpu_usage/)<!-- HN:43475982:end --><!-- HN:43479262:start -->
* [43479262](https://news.social-protocols.org/stats?id=43479262) #10 16 points 0 comments -> [AM Radio Will Never Die](https://www.discoursemagazine.com/p/am-radio-will-never-die)<!-- HN:43479262:end --><!-- HN:43517352:start -->
* [43517352](https://news.social-protocols.org/stats?id=43517352) #10 12 points 2 comments -> [Huge Structures Discovered Under Pyramids?](https://www.youtube.com/watch?v=cqCudopAz64)<!-- HN:43517352:end --><!-- HN:43517613:start -->
* [43517613](https://news.social-protocols.org/stats?id=43517613) #18 15 points 1 comments -> [Jeremy Howard taught AI and helped invent ChatGPT. He fears he's failed](https://www.abc.net.au/news/science/2023-11-15/jeremy-howard-taught-ai-to-the-world-and-helped-invent-chatgpt/103092474)<!-- HN:43517613:end --><!-- HN:43517262:start -->
* [43517262](https://news.social-protocols.org/stats?id=43517262) #22 22 points 40 comments -> [AI generated Ghibli images go viral as OpenAI loosens its rules](https://www.washingtonpost.com/technology/2025/03/28/chatgpt-ghibli-ai-images-copyright/)<!-- HN:43517262:end --><!-- HN:43518064:start -->
* [43518064](https://news.social-protocols.org/stats?id=43518064) #28 12 points 3 comments -> [Show HN: Job Application Bot by Ollama AI](https://github.com/lookr-fyi/job-application-bot-by-ollama-ai)<!-- HN:43518064:end --><!-- HN:43518030:start -->
* [43518030](https://news.social-protocols.org/stats?id=43518030) #16 19 points 3 comments -> [Proof that Steins;Gate world is a running simulation](https://samyar.me/posts/steins-gate-and-hamming-code/)<!-- HN:43518030:end --><!-- HN:43492378:start -->
* [43492378](https://news.social-protocols.org/stats?id=43492378) #20 4 points 0 comments -> [Why do blue-footed boobies have blue feet? And 8 other blue-footed booby facts](https://www.worldwildlife.org/stories/why-do-blue-footed-boobies-have-blue-feet-and-8-other-blue-footed-booby-facts)<!-- HN:43492378:end --><!-- HN:43519459:start -->
* [43519459](https://news.social-protocols.org/stats?id=43519459) #8 12 points 3 comments -> [Vibe Coding with Cursor](https://www.dolthub.com/blog/2025-03-29-vibin/)<!-- HN:43519459:end --><!-- HN:43519678:start -->
* [43519678](https://news.social-protocols.org/stats?id=43519678) #22 7 points 0 comments -> [Ex-FCC chairs from both parties say CBS news distortion investigation is bogus](https://arstechnica.com/tech-policy/2025/03/ex-fcc-chairs-from-both-parties-say-cbs-news-distortion-investigation-is-bogus/)<!-- HN:43519678:end -->
#### **Sunday, March 30, 2025**
<!-- HN:43519719:start -->
* [43519719](https://news.social-protocols.org/stats?id=43519719) #9 9 points 1 comments -> [Deep Musk](https://deepmusk.com/)<!-- HN:43519719:end --><!-- HN:43520302:start -->
* [43520302](https://news.social-protocols.org/stats?id=43520302) #30 7 points 0 comments -> [Rescission of the Final Scientific Integrity Policy of the NIH](https://grants.nih.gov/grants/guide/notice-files/NOT-OD-25-080.html)<!-- HN:43520302:end --><!-- HN:43521521:start -->
* [43521521](https://news.social-protocols.org/stats?id=43521521) #11 2 points 0 comments -> [Show HN: Online tool to show white fullscreen page](https://www.mywhitescreen.com/)<!-- HN:43521521:end --><!-- HN:43523165:start -->
* [43523165](https://news.social-protocols.org/stats?id=43523165) #24 6 points 0 comments -> [Hegseth's Wife Tagged Along for Top Secret Military Meetings](https://www.thedailybeast.com/pete-hegseths-wife-jennifer-tags-along-for-top-secret-military-meetings/)<!-- HN:43523165:end --><!-- HN:43523873:start -->
* [43523873](https://news.social-protocols.org/stats?id=43523873) #7 8 points 5 comments -> [Show HN: LinkedIn's Dead. Developers Are Moving to Grids](https://10000resumes.com)<!-- HN:43523873:end --><!-- HN:43498071:start -->
* [43498071](https://news.social-protocols.org/stats?id=43498071) #12 56 points 17 comments -> [Rust Adopting Ferrocene Language Specification](https://lwn.net/Articles/1015636/)<!-- HN:43498071:end --><!-- HN:43499319:start -->
* [43499319](https://news.social-protocols.org/stats?id=43499319) #13 62 points 7 comments -> [Charlie Brown and Franz Stigler incident (1943)](https://en.wikipedia.org/wiki/Charlie_Brown_and_Franz_Stigler_incident)<!-- HN:43499319:end --><!-- HN:43525937:start -->
* [43525937](https://news.social-protocols.org/stats?id=43525937) #2 10 points 2 comments -> [The First LLM](https://thundergolfer.com/blog/the-first-llm)<!-- HN:43525937:end --><!-- HN:43526270:start -->
* [43526270](https://news.social-protocols.org/stats?id=43526270) #23 4 points 0 comments -> [Satanist leader's attempt to hold Black Mass in Kansas Statehouse sparks chaos](https://www.cnn.com/2025/03/29/us/kansas-satanist-protest-arrests-hnk/index.html)<!-- HN:43526270:end --><!-- HN:43524385:start -->
* [43524385](https://news.social-protocols.org/stats?id=43524385) #23 12 points 3 comments -> [Lehmer's Continued Fraction Factorization Algorithm](https://leetarxiv.substack.com/p/continued-fraction-factorize-factorization)<!-- HN:43524385:end -->
#### **Monday, March 31, 2025**
<!-- HN:43529362:start -->
* [43529362](https://news.social-protocols.org/stats?id=43529362) #3 10 points 8 comments -> [Executive order phases out U.S. Treasury paper checks](https://bankingjournal.aba.com/2025/03/executive-order-phases-out-u-s-treasury-paper-checks/)<!-- HN:43529362:end --><!-- HN:43528496:start -->
* [43528496](https://news.social-protocols.org/stats?id=43528496) #19 42 points 41 comments -> [Can Style Be Timeless?](https://www.mrporter.com/en-gb/journal/fashion/derek-guy-timeless-style-25197344)<!-- HN:43528496:end --><!-- HN:43530751:start -->
* [43530751](https://news.social-protocols.org/stats?id=43530751) #24 41 points 40 comments -> [Fiber optic drones are changing combat operations](https://www.youtube.com/watch?v=JcB4dR_8xPo)<!-- HN:43530751:end --><!-- HN:43531494:start -->
* [43531494](https://news.social-protocols.org/stats?id=43531494) #5 16 points 5 comments -> [Agentic AI Needs Its TCP/IP Moment](https://www.anup.io/p/architecting-the-internet-of-agents)<!-- HN:43531494:end --><!-- HN:43532939:start -->
* [43532939](https://news.social-protocols.org/stats?id=43532939) #1 11 points 5 comments -> [GPT-4o draws itself as a consistent type of guy](https://newsletter.danielpaleka.com/p/gpt-4o-draws-itself-as-a-consistent)<!-- HN:43532939:end --><!-- HN:43532736:start -->
* [43532736](https://news.social-protocols.org/stats?id=43532736) #14 3 points 1 comments -> [Custom AI Chatbot Development Services: Restrictions and Opportunities](https://belitsoft.com/chatbot-development-services/custom-ai)<!-- HN:43532736:end --><!-- HN:43533634:start -->
* [43533634](https://news.social-protocols.org/stats?id=43533634) #14 11 points 4 comments -> [Net migration into the UK has tripled post-Brexit](https://www.bigissue.com/opinion/brexit-net-migration-rishi-sunak-uk-immigration/)<!-- HN:43533634:end --><!-- HN:43535311:start -->
* [43535311](https://news.social-protocols.org/stats?id=43535311) #30 7 points 0 comments -> [Trump's USAID Cuts Hobble Earthquake Response in Myanmar](https://www.nytimes.com/2025/03/30/world/asia/myanmar-earthquake-usaid-cuts.html)<!-- HN:43535311:end --><!-- HN:43525246:start -->
* [43525246](https://news.social-protocols.org/stats?id=43525246) #19 17 points 10 comments -> [Tiniest Flying Robot (Wingspan &lt;1cm) Soars Thanks to Magnets](https://spectrum.ieee.org/flying-robot-2671447539)<!-- HN:43525246:end --><!-- HN:43537580:start -->
* [43537580](https://news.social-protocols.org/stats?id=43537580) #6 -> [ICE deporting legal Permanent Residents, Refugees, and immigrants](https://www.rochesterfirst.com/rochester/ice-deporting-bhutanese-refugees/)<!-- HN:43537580:end --><!-- HN:43537624:start -->
* [43537624](https://news.social-protocols.org/stats?id=43537624) #20 2 points 0 comments -> [Chomsky: A "Study in Total Depravity"](http://bactra.org/chomsky.html)<!-- HN:43537624:end --><!-- HN:43498465:start -->
* [43498465](https://news.social-protocols.org/stats?id=43498465) #20 5 points 2 comments -> [A Man Who Went to Fake Prison Also Went to Real Jail](https://nymag.com/intelligencer/article/william-banks-comedian-jail.html)<!-- HN:43498465:end --><!-- HN:43537808:start -->
* [43537808](https://news.social-protocols.org/stats?id=43537808) #16 71 points 55 comments -> [The Average College Student Is Illiterate](https://www.persuasion.community/p/the-average-college-student-is-illiterate)<!-- HN:43537808:end -->
#### **Tuesday, April 1, 2025**<!-- HN:43541428:start -->
* [43541428](https://news.social-protocols.org/stats?id=43541428) #4 5 points 1 comments -> [Addressing Burnout – Libera Chat](https://libera.chat/news/burnout)<!-- HN:43541428:end --><!-- HN:43541926:start -->
* [43541926](https://news.social-protocols.org/stats?id=43541926) #26 4 points 1 comments -> [Tips for Travelers Entering the U.S. Now: Check Your Visa, Turn Off Your Phone](https://www.nytimes.com/2025/03/31/travel/us-travel-border-customs-visa-trump.html)<!-- HN:43541926:end --><!-- HN:43542151:start -->
* [43542151](https://news.social-protocols.org/stats?id=43542151) #21 -> [The Demand Side of Democratic Backsliding](https://www.cambridge.org/core/journals/british-journal-of-political-science/article/demand-side-of-democratic-backsliding-how-divergent-understandings-of-democracy-shape-political-choice/3DEB0DC344DF35BF4334366F07411116)<!-- HN:43542151:end -->