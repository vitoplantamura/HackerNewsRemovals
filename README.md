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

#### **Wednesday, June 11, 2025**
<!-- HN:44244340:start -->
* [44244340](https://news.social-protocols.org/stats?id=44244340) #11 36 points 29 comments -> [What MS-DOS Can Do That Linux Can't](http://webarchive.me/geocities/SiliconValley/2072/dosvslnx.htm)<!-- HN:44244340:end --><!-- HN:44245731:start -->
* [44245731](https://news.social-protocols.org/stats?id=44245731) #24 60 points 35 comments -> [Steve Jobs would have fired everyone](https://twitter.com/greggertruck/status/1932173476879888556)<!-- HN:44245731:end --><!-- HN:44245813:start -->
* [44245813](https://news.social-protocols.org/stats?id=44245813) #25 17 points 4 comments -> [US ambassador to Israel:US no longer pursuing goal independent Palestinian state](https://www.theguardian.com/us-news/2025/jun/10/mike-huckabee-independent-palestinian-state)<!-- HN:44245813:end --><!-- HN:44216996:start -->
* [44216996](https://news.social-protocols.org/stats?id=44216996) #30 50 points 7 comments -> [A Thousand Tiny Optimisations](https://leejo.github.io/2025/06/08/alttpr/)<!-- HN:44216996:end --><!-- HN:44246400:start -->
* [44246400](https://news.social-protocols.org/stats?id=44246400) #21 6 points 0 comments -> [NASA raises the odds that an asteroid could hit the moon in 2032](https://www.space.com/astronomy/asteroids/nasa-raises-the-odds-that-an-asteroid-could-hit-the-moon-in-2032)<!-- HN:44246400:end --><!-- HN:44246977:start -->
* [44246977](https://news.social-protocols.org/stats?id=44246977) #30 7 points 4 comments -> [Why common climate messaging backfires](https://phys.org/news/2025-06-common-climate-messaging-backfires.html)<!-- HN:44246977:end --><!-- HN:44247292:start -->
* [44247292](https://news.social-protocols.org/stats?id=44247292) #12 13 points 6 comments -> [Rewriting Unix Philosophy for the Post-AI Era](https://gizvault.com/archives/unix-philo-for-past-ai-era)<!-- HN:44247292:end --><!-- HN:44249932:start -->
* [44249932](https://news.social-protocols.org/stats?id=44249932) #27 12 points 2 comments -> [Fervo Energy Drills 15,000', 520 F Geothermal Well in 16 Drilling Days](https://www.businesswire.com/news/home/20250610223846/en/Fervo-Energy-Drills-15000-FT-500F-Geothermal-Well-Pushing-the-Envelope-for-EGS-Deployment)<!-- HN:44249932:end --><!-- HN:44217776:start -->
* [44217776](https://news.social-protocols.org/stats?id=44217776) #18 6 points 0 comments -> [Struggle for Monarchy on the U.S.-Mexican Border](http://madmonarchist.blogspot.com/2013/02/struggle-for-monarchy-on-us-mexican.html)<!-- HN:44217776:end -->
#### **Thursday, June 12, 2025**
<!-- HN:44253533:start -->
* [44253533](https://news.social-protocols.org/stats?id=44253533) #30 7 points 1 comments -> [Zuckerberg created the saddest place on the internet with Meta AI's public feed](https://www.businessinsider.com/mark-zuckerberg-meta-ai-chatbot-discover-feed-depressing-why-2025-6)<!-- HN:44253533:end --><!-- HN:44253807:start -->
* [44253807](https://news.social-protocols.org/stats?id=44253807) #29 7 points 0 comments -> [Polystyrene nanoplastics disrupt the intestinal microenvironment](https://www.nature.com/articles/s41467-025-59884-y)<!-- HN:44253807:end --><!-- HN:44256242:start -->
* [44256242](https://news.social-protocols.org/stats?id=44256242) #12 23 points 10 comments -> [First Boeing 787 Dreamliner Crash](https://www.nytimes.com/live/2025/06/12/world/india-plane-crash-ahmedabad)<!-- HN:44256242:end --><!-- HN:44256844:start -->
* [44256844](https://news.social-protocols.org/stats?id=44256844) #11 6 points 1 comments -> [AI coding tools are like that helpful but untrustworthy friend, devs say](https://www.theregister.com/2025/06/12/devs_mostly_welcome_ai_coding/)<!-- HN:44256844:end --><!-- HN:44256169:start -->
* [44256169](https://news.social-protocols.org/stats?id=44256169) #15 42 points 41 comments -> [Brazil's Supreme Court makes social media liable for user content](https://economictimes.indiatimes.com/tech/technology/brazils-supreme-court-justices-agree-to-make-social-media-companies-liable-for-user-content/articleshow/121791147.cms?from=mdr)<!-- HN:44256169:end --><!-- HN:44257796:start -->
* [44257796](https://news.social-protocols.org/stats?id=44257796) #3 8 points 0 comments -> [The Mass Trauma of Porn](https://www.afterbabel.com/p/the-mass-trauma-of-porn)<!-- HN:44257796:end --><!-- HN:44258895:start -->
* [44258895](https://news.social-protocols.org/stats?id=44258895) #11 7 points 0 comments -> [South Korea Lab Makes Bird Flu 100% Lethal in Mammals](https://virologyj.biomedcentral.com/articles/10.1186/s12985-025-02811-w)<!-- HN:44258895:end --><!-- HN:44259095:start -->
* [44259095](https://news.social-protocols.org/stats?id=44259095) #3 11 points 4 comments -> [Your Job used to impress people. That era just ended](https://carmenvankerckhove.substack.com/p/your-job-used-to-impress-people-that)<!-- HN:44259095:end --><!-- HN:44258541:start -->
* [44258541](https://news.social-protocols.org/stats?id=44258541) #21 18 points 17 comments -> [Becoming an AI-Native Engineer](https://rfitz.io/blog/becoming-ai-native-engineer/)<!-- HN:44258541:end --><!-- HN:44259001:start -->
* [44259001](https://news.social-protocols.org/stats?id=44259001) #29 226 points 231 comments -> [Trump's NASA cuts would destroy decades of science and wipe out its future](https://www.latimes.com/business/story/2025-06-09/trumps-nasa-cuts-would-destroy-decades-of-science-and-wipe-out-its-future)<!-- HN:44259001:end --><!-- HN:44260717:start -->
* [44260717](https://news.social-protocols.org/stats?id=44260717) #24 16 points 3 comments -> [Twitch Is Down](https://status.twitch.com)<!-- HN:44260717:end --><!-- HN:44262383:start -->
* [44262383](https://news.social-protocols.org/stats?id=44262383) #5 22 points 14 comments -> [Cursor goes rogue in YOLO mode, deletes itself and everything else](https://www.machine.news/it-felt-like-ultron-took-over-cursor-goes-rogue-in-yolo-mode-deletes-itself-and-everything-else/)<!-- HN:44262383:end --><!-- HN:44263460:start -->
* [44263460](https://news.social-protocols.org/stats?id=44263460) #23 4 points 1 comments -> [A Primer on US Healthcare](https://www.generativevalue.com/p/a-primer-on-us-healthcare)<!-- HN:44263460:end -->
#### **Friday, June 13, 2025**
<!-- HN:44261577:start -->
* [44261577](https://news.social-protocols.org/stats?id=44261577) #18 -> [Emulating an iPhone in QEMU (Part 2)](https://eshard.com/posts/emulating-ios-14-with-qemu-part2)<!-- HN:44261577:end --><!-- HN:44264529:start -->
* [44264529](https://news.social-protocols.org/stats?id=44264529) #24 3 points 1 comments -> [Vibe Coding Is Coming for Engineering Jobs](https://www.wired.com/story/vibe-coding-engineering-apocalypse/)<!-- HN:44264529:end --><!-- HN:44267060:start -->
* [44267060](https://news.social-protocols.org/stats?id=44267060) #8 28 points 40 comments -> [Andrew Ng says vibe coding is a bad name for a real and exhausting job](https://www.businessinsider.com/andrew-ng-vibe-coding-unfortunate-term-exhausting-job-2025-6)<!-- HN:44267060:end --><!-- HN:44267371:start -->
* [44267371](https://news.social-protocols.org/stats?id=44267371) #27 25 points 40 comments -> [They Asked an A.I. Chatbot Questions. The Answers Sent Them Spiraling](https://www.nytimes.com/2025/06/13/technology/chatgpt-ai-chatbots-conspiracies.html)<!-- HN:44267371:end --><!-- HN:44267091:start -->
* [44267091](https://news.social-protocols.org/stats?id=44267091) #9 114 points 75 comments -> [The European public DNS that makes your Internet safer](https://www.dns0.eu)<!-- HN:44267091:end --><!-- HN:44270660:start -->
* [44270660](https://news.social-protocols.org/stats?id=44270660) #16 11 points 6 comments -> [I'm the CTO of Palantir. Today I Join the Army](https://www.thefp.com/p/im-the-cto-of-palantir-today-i-join)<!-- HN:44270660:end --><!-- HN:44271712:start -->
* [44271712](https://news.social-protocols.org/stats?id=44271712) #26 6 points 0 comments -> [Silicon Valley tech execs are joining the US Army Reserve](https://techcrunch.com/2025/06/13/silicon-valley-tech-execs-are-joining-the-us-army-reserve/)<!-- HN:44271712:end --><!-- HN:44271191:start -->
* [44271191](https://news.social-protocols.org/stats?id=44271191) #4 57 points 1 comments -> [The Claude Bliss Attractor](https://www.astralcodexten.com/p/the-claude-bliss-attractor)<!-- HN:44271191:end -->
#### **Saturday, June 14, 2025**<!-- HN:44208938:start -->
* [44208938](https://news.social-protocols.org/stats?id=44208938) #25 94 points 43 comments -> [The concurrency trap: How an atomic counter stalled a pipeline](https://www.conviva.com/platform/the-concurrency-trap-how-an-atomic-counter-stalled-a-pipeline/)<!-- HN:44208938:end --><!-- HN:44252409:start -->
* [44252409](https://news.social-protocols.org/stats?id=44252409) #23 27 points 23 comments -> [AI Isn't Magic, It's Maths](https://zerofluff.substack.com/p/ai-isnt-magic-its-maths)<!-- HN:44252409:end --><!-- HN:44273067:start -->
* [44273067](https://news.social-protocols.org/stats?id=44273067) #29 72 points 2 comments -> [U.S. Army bringing in big tech executives as lieutenant colonels](https://taskandpurpose.com/military-life/army-reserve-lt-col-tech-execs/)<!-- HN:44273067:end --><!-- HN:44274475:start -->
* [44274475](https://news.social-protocols.org/stats?id=44274475) #24 12 points 3 comments -> [Builder.ai did not "fake AI with 700 engineers"](https://blog.pragmaticengineer.com/builder-ai-did-not-fake-ai/)<!-- HN:44274475:end --><!-- HN:44274458:start -->
* [44274458](https://news.social-protocols.org/stats?id=44274458) #21 15 points 12 comments -> [How to Write the Worst Possible Python Code (Humor)](https://effective-programmer.com/how-to-write-the-worst-possible-python-code-8c6e49816e90?sk=d06d4241ce97a51a969fbce67070f8ba)<!-- HN:44274458:end --><!-- HN:44275643:start -->
* [44275643](https://news.social-protocols.org/stats?id=44275643) #3 6 points 15 comments -> [Built an AI that brutally roasts your website designs](https://ugh.design)<!-- HN:44275643:end --><!-- HN:44277289:start -->
* [44277289](https://news.social-protocols.org/stats?id=44277289) #20 4 points 1 comments -> [Emissions Test: Car vs. Truck vs. Leaf Blower](https://www.edmunds.com/car-reviews/features/emissions-test-car-vs-truck-vs-leaf-blower.html)<!-- HN:44277289:end --><!-- HN:44277238:start -->
* [44277238](https://news.social-protocols.org/stats?id=44277238) #13 10 points 1 comments -> [Democratic state politician and husband shot dead in targeted attack](https://www.bbc.com/news/live/cvgv4y99n7rt)<!-- HN:44277238:end --><!-- HN:44277671:start -->
* [44277671](https://news.social-protocols.org/stats?id=44277671) #14 27 points 1 comments -> [Minnesota Lawmaker Assassinated](https://apnews.com/article/minnesota-lawmakers-shot-d7983e1e4f1a7573a487cab1a98cd172)<!-- HN:44277671:end --><!-- HN:44272444:start -->
* [44272444](https://news.social-protocols.org/stats?id=44272444) #11 6 points 0 comments -> [Unsupervised Elicitation of Language Models](https://arxiv.org/abs/2506.10139)<!-- HN:44272444:end --><!-- HN:44277899:start -->
* [44277899](https://news.social-protocols.org/stats?id=44277899) #6 -> [Officials are searching for a 57-year-old man in shooting 2 Minnesota lawmakers](https://apnews.com/article/minnesota-lawmakers-shot-d7983e1e4f1a7573a487cab1a98cd172)<!-- HN:44277899:end --><!-- HN:44249305:start -->
* [44249305](https://news.social-protocols.org/stats?id=44249305) #22 23 points 40 comments -> [Texting myself the weather every day](https://bensilverman.co.uk/posts/daily-weather-sms/)<!-- HN:44249305:end --><!-- HN:44278279:start -->
* [44278279](https://news.social-protocols.org/stats?id=44278279) #20 3 points 0 comments -> [Anne Wojcicki is taking back control of 23andMe](https://www.theverge.com/news/687123/23andme-anne-wojcicki-acquisition)<!-- HN:44278279:end --><!-- HN:44278608:start -->
* [44278608](https://news.social-protocols.org/stats?id=44278608) #21 5 points 0 comments -> [Why AI and SQL Go Together Like Peanut Butter and Jelly](https://thenewstack.io/why-ai-and-sql-go-together-like-peanut-butter-and-jelly/)<!-- HN:44278608:end --><!-- HN:44235612:start -->
* [44235612](https://news.social-protocols.org/stats?id=44235612) #22 152 points 268 comments -> [Liquid Glass – WWDC25 [video]](https://developer.apple.com/videos/play/wwdc2025/219)<!-- HN:44235612:end -->
#### **Sunday, June 15, 2025**
<!-- HN:44279325:start -->
* [44279325](https://news.social-protocols.org/stats?id=44279325) #5 27 points 11 comments -> [I used ChatGPT to learn programming from zero and built a video generation SaaS](https://www.vidmakerpro.com/)<!-- HN:44279325:end --><!-- HN:44280588:start -->
* [44280588](https://news.social-protocols.org/stats?id=44280588) #25 15 points 1 comments -> [The Tech Plutocrats Dreaming of a Right-Wing San Francisco (2024)](https://newrepublic.com/article/178675/garry-tan-tech-san-francisco)<!-- HN:44280588:end --><!-- HN:44277764:start -->
* [44277764](https://news.social-protocols.org/stats?id=44277764) #16 36 points 6 comments -> [Infineon security microcontroller flaw enabled extraction of TPM secret keys](https://it4sec.substack.com/p/a-flaw-in-infineons-security-microcontrollers)<!-- HN:44277764:end --><!-- HN:44280952:start -->
* [44280952](https://news.social-protocols.org/stats?id=44280952) #22 6 points 1 comments -> [Coinbase, famously a "no politics" company in 2020, sponsors a military parade](https://old.reddit.com/r/Military/comments/1lblspo/thanks_to_our_sponsor_coinbase/)<!-- HN:44280952:end --><!-- HN:44282142:start -->
* [44282142](https://news.social-protocols.org/stats?id=44282142) #6 9 points 0 comments -> [Competitive Hormone Supplementation Is Shaping America's Future Business Titans](https://letter.palladiummag.com/p/competitive-hormone-supplementation)<!-- HN:44282142:end --><!-- HN:44281996:start -->
* [44281996](https://news.social-protocols.org/stats?id=44281996) #9 7 points 4 comments -> [Show HN: PromptForge – A minimal AI SaaS to generate better GPT prompts](https://forge-ai-interface.lovable.app/)<!-- HN:44281996:end --><!-- HN:44282960:start -->
* [44282960](https://news.social-protocols.org/stats?id=44282960) #17 7 points 1 comments -> [The unions are (finally) coming for big tech](https://leaddev.com/leadership/unions-finally-coming-big-tech)<!-- HN:44282960:end --><!-- HN:44284322:start -->
* [44284322](https://news.social-protocols.org/stats?id=44284322) #30 3 points 0 comments -> [Brain implant breakthrough helps ALS man talk – and sing – again](https://newatlas.com/medical-tech/brain-implant-bci-als-talk-sing/)<!-- HN:44284322:end --><!-- HN:44284261:start -->
* [44284261](https://news.social-protocols.org/stats?id=44284261) #25 17 points 5 comments -> [Apple Completes Migration of Key Service to Swift, Gains 40% Performance Uplift](https://www.infoq.com/news/2025/06/apple-swift-migration/)<!-- HN:44284261:end --><!-- HN:44285116:start -->
* [44285116](https://news.social-protocols.org/stats?id=44285116) #24 29 points 3 comments -> ['No Kings' Protests Across the United States](https://www.nytimes.com/2025/06/14/us/protests-cities-no-kings.html)<!-- HN:44285116:end -->
#### **Monday, June 16, 2025**
<!-- HN:44285503:start -->
* [44285503](https://news.social-protocols.org/stats?id=44285503) #4 14 points 7 comments -> [Coding agents have crossed a chasm](https://blog.singleton.io/posts/2025-06-14-coding-agents-cross-a-chasm/)<!-- HN:44285503:end --><!-- HN:44286078:start -->
* [44286078](https://news.social-protocols.org/stats?id=44286078) #1 31 points 19 comments -> [Meta's Llama 3.1 can recall 42 percent of the first Harry Potter book](https://www.understandingai.org/p/metas-llama-31-can-recall-42-percent)<!-- HN:44286078:end --><!-- HN:44264362:start -->
* [44264362](https://news.social-protocols.org/stats?id=44264362) #3 20 points 6 comments -> [Being a Force Multiplier](https://substack.com/home/post/p-165651243)<!-- HN:44264362:end --><!-- HN:44287984:start -->
* [44287984](https://news.social-protocols.org/stats?id=44287984) #2 13 points 6 comments -> [The Illusion of Thinking: A Reality Check on AI Reasoning](https://leotsem.com/blog/the-illusion-of-thinking/)<!-- HN:44287984:end --><!-- HN:44288000:start -->
* [44288000](https://news.social-protocols.org/stats?id=44288000) #6 65 points 41 comments -> [Tesla blows past stopped school bus and hits kid-sized dummies in FSD tests](https://www.engadget.com/transportation/tesla-blows-past-stopped-school-bus-and-hits-kid-sized-dummies-in-full-self-driving-tests-183756251.html)<!-- HN:44288000:end --><!-- HN:44289833:start -->
* [44289833](https://news.social-protocols.org/stats?id=44289833) #18 3 points 2 comments -> [WhatsApp adds ads to the status screen](https://techcrunch.com/2025/06/16/whatsapp-is-adding-ads-to-the-status-screen/)<!-- HN:44289833:end --><!-- HN:44290759:start -->
* [44290759](https://news.social-protocols.org/stats?id=44290759) #23 5 points 1 comments -> [This is nuts. When’s the crash?](https://www.ft.com/content/80019dab-78ab-4dbd-b6c5-a54ce953532f)<!-- HN:44290759:end --><!-- HN:44289944:start -->
* [44289944](https://news.social-protocols.org/stats?id=44289944) #7 20 points 1 comments -> [How the first electric grid was built](https://www.worksinprogress.news/p/how-the-worlds-first-electric-grid)<!-- HN:44289944:end --><!-- HN:44291750:start -->
* [44291750](https://news.social-protocols.org/stats?id=44291750) #19 6 points 0 comments -> [The React-Killer Is Born](https://medium.com/@resti.guay/juris-object-first-web-development-a-new-paradigm-for-reactive-user-interfaces-721a5a734732)<!-- HN:44291750:end --><!-- HN:44291630:start -->
* [44291630](https://news.social-protocols.org/stats?id=44291630) #28 126 points 181 comments -> [Getting free internet on a cruise, saving $170](https://angad.me/blog/2025/getting-free-cruise-internet/)<!-- HN:44291630:end -->
#### **Tuesday, June 17, 2025**
<!-- HN:44294299:start -->
* [44294299](https://news.social-protocols.org/stats?id=44294299) #10 12 points 1 comments -> [Your Texas LLC Won't Protect You from Blue State Labor Laws](https://upcactus.com/blog/your-Texas-LLC-won-t-protect-you-from-Blue-State-Labor-Laws)<!-- HN:44294299:end --><!-- HN:44295977:start -->
* [44295977](https://news.social-protocols.org/stats?id=44295977) #16 5 points 2 comments -> [She Won. They Didn't Just Change the Machines. They Rewired the Election](https://substack.com/inbox/post/165658733)<!-- HN:44295977:end -->