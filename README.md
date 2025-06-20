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
* [44295977](https://news.social-protocols.org/stats?id=44295977) #16 5 points 2 comments -> [She Won. They Didn't Just Change the Machines. They Rewired the Election](https://substack.com/inbox/post/165658733)<!-- HN:44295977:end --><!-- HN:44296087:start -->
* [44296087](https://news.social-protocols.org/stats?id=44296087) #4 24 points 1 comments -> [Defense Department signs OpenAI for $200M 'frontier AI' pilot project](https://www.theregister.com/2025/06/17/dod_openai_contract/)<!-- HN:44296087:end --><!-- HN:44296711:start -->
* [44296711](https://news.social-protocols.org/stats?id=44296711) #3 135 points 5 comments -> [Accumulation of Cognitive Debt When Using an AI Assistant for Essay Writing Task](https://www.brainonllm.com/)<!-- HN:44296711:end --><!-- HN:44275321:start -->
* [44275321](https://news.social-protocols.org/stats?id=44275321) #21 4 points 0 comments -> [Inverted commas are falling out of fashion](https://www.economist.com/britain/2025/06/12/inverted-commas-are-falling-out-of-fashion)<!-- HN:44275321:end --><!-- HN:44298407:start -->
* [44298407](https://news.social-protocols.org/stats?id=44298407) #2 14 points 11 comments -> [Is Documentation Like Pineapple on Pizza?](https://techleadtoolkit.substack.com/p/is-documentation-like-pineapple-on)<!-- HN:44298407:end --><!-- HN:44298174:start -->
* [44298174](https://news.social-protocols.org/stats?id=44298174) #11 15 points 40 comments -> [Just How Many More Successful UBI Trials Do We Need?](https://medium.com/the-no%C3%B6sphere/just-how-many-more-successful-ubi-trials-do-we-need-64ed124c7001)<!-- HN:44298174:end --><!-- HN:44298256:start -->
* [44298256](https://news.social-protocols.org/stats?id=44298256) #27 3 points 0 comments -> [[Dennis Yurichev] was forcefully draften/enrolled to Ukraine army](https://yurichev.com/n/army/)<!-- HN:44298256:end --><!-- HN:44298438:start -->
* [44298438](https://news.social-protocols.org/stats?id=44298438) #1 7 points 1 comments -> [Casio to Release Edifice Featuring Forged Carbon: Ever Mechanical Movement Casio](https://www.casio.com/intl/news/2025/0616-efk-100/)<!-- HN:44298438:end --><!-- HN:44297652:start -->
* [44297652](https://news.social-protocols.org/stats?id=44297652) #8 63 points 32 comments -> ["Microsoft Locked My Account – I Lost 30 Years of Photos and Work"](https://old.reddit.com/r/pcmasterrace/comments/1ldef4p/microsoft_locked_my_account_i_lost_30_years_of/)<!-- HN:44297652:end --><!-- HN:44300361:start -->
* [44300361](https://news.social-protocols.org/stats?id=44300361) #14 5 points 1 comments -> [Israel said Iran racing toward a nuclear weapon. US Intel says it was years away](https://www.cnn.com/2025/06/17/politics/israel-iran-nuclear-bomb-us-intelligence-years-away)<!-- HN:44300361:end --><!-- HN:44300768:start -->
* [44300768](https://news.social-protocols.org/stats?id=44300768) #11 21 points 0 comments -> [Western Oil: the US/UK-Backed Iranian Coup D'état of 1953](https://en.wikipedia.org/wiki/1953_Iranian_coup_d%27%C3%A9tat)<!-- HN:44300768:end --><!-- HN:44301874:start -->
* [44301874](https://news.social-protocols.org/stats?id=44301874) #24 6 points 0 comments -> [Israel Built Its Case for War on New Intelligence. The U.S. Didn't Buy It](https://www.wsj.com/world/middle-east/israel-built-its-case-for-war-with-iran-on-new-intelligence-the-u-s-didnt-buy-it-55592e81)<!-- HN:44301874:end --><!-- HN:44302461:start -->
* [44302461](https://news.social-protocols.org/stats?id=44302461) #15 -> [New York City mayoral candidate Brad Lander arrested at immigration court](https://www.theguardian.com/us-news/2025/jun/17/brad-lander-arrested-new-york-city-comptroller)<!-- HN:44302461:end --><!-- HN:44303929:start -->
* [44303929](https://news.social-protocols.org/stats?id=44303929) #20 11 points 0 comments -> [Apple: Prepare your network for quantum-secure encryption in TLS](https://support.apple.com/en-my/122756)<!-- HN:44303929:end -->
#### **Wednesday, June 18, 2025**
<!-- HN:44307257:start -->
* [44307257](https://news.social-protocols.org/stats?id=44307257) #1 103 points 75 comments -> [AI is eating our brains. MIT study: Your brain on ChatGPT](https://www.media.mit.edu/projects/your-brain-on-chatgpt/overview/)<!-- HN:44307257:end --><!-- HN:44307057:start -->
* [44307057](https://news.social-protocols.org/stats?id=44307057) #4 52 points 15 comments -> [Your Brain on ChatGPT: Accumulation of Cognitive Debt When Using an AI Assistant](https://fermatslibrary.com/s/your-brain-on-chatgpt-accumulation-of-cognitive-debt-when-using-an-ai-assistant-for-essay-writing-task)<!-- HN:44307057:end --><!-- HN:44308041:start -->
* [44308041](https://news.social-protocols.org/stats?id=44308041) #30 9 points 4 comments -> [Iran is going offline to prevent purported Israeli cyberattacks](https://www.theverge.com/politics/688875/iran-cutting-off-internet-israel-war)<!-- HN:44308041:end --><!-- HN:44308122:start -->
* [44308122](https://news.social-protocols.org/stats?id=44308122) #30 10 points 0 comments -> [Google May Charge a Fee to Provide Source Code for Android Binaries](https://source.android.com/opensourcerequest)<!-- HN:44308122:end --><!-- HN:44309847:start -->
* [44309847](https://news.social-protocols.org/stats?id=44309847) #20 5 points 0 comments -> [Governments are ditching Windows and Microsoft Office](https://www.windowscentral.com/software-apps/windows-11/goverments-are-ditching-windows-and-microsoft-office-new-letter-reveals-the-real-costs-of-switching-to-windows-11)<!-- HN:44309847:end --><!-- HN:44309550:start -->
* [44309550](https://news.social-protocols.org/stats?id=44309550) #25 17 points 11 comments -> [Why China is giving away its tech for free](https://www.economist.com/business/2025/06/17/why-china-is-giving-away-its-tech-for-free)<!-- HN:44309550:end --><!-- HN:44311040:start -->
* [44311040](https://news.social-protocols.org/stats?id=44311040) #14 15 points 11 comments -> [ChatGPT is my static site generator](https://notes.npilk.com/chatgpt-is-my-ssg)<!-- HN:44311040:end --><!-- HN:44311509:start -->
* [44311509](https://news.social-protocols.org/stats?id=44311509) #1 211 points 134 comments -> [Andrej Karpathy's talk on the future of the industry](https://www.donnamagi.com/articles/karpathy-yc-talk)<!-- HN:44311509:end -->
#### **Thursday, June 19, 2025**
<!-- HN:44315409:start -->
* [44315409](https://news.social-protocols.org/stats?id=44315409) #21 6 points 0 comments -> [Death to WYSIWYG!](https://ratfactor.com/htmlwarden/death-to-wysiwyg)<!-- HN:44315409:end --><!-- HN:44315400:start -->
* [44315400](https://news.social-protocols.org/stats?id=44315400) #6 14 points 1 comments -> [Writing Toy Software Is a Joy](https://blog.jsbarretto.com/post/software-is-joy)<!-- HN:44315400:end --><!-- HN:44317041:start -->
* [44317041](https://news.social-protocols.org/stats?id=44317041) #7 12 points 10 comments -> [A Deep Dive into OpenAPI](https://www.deployhq.com/blog/unlocking-seamless-development-and-collaboration-a-deep-dive-into-openapi)<!-- HN:44317041:end --><!-- HN:44317663:start -->
* [44317663](https://news.social-protocols.org/stats?id=44317663) #16 43 points 25 comments -> [How Close to Black Mirror Are We?](https://www.howclosetoblackmirror.com/)<!-- HN:44317663:end --><!-- HN:44318330:start -->
* [44318330](https://news.social-protocols.org/stats?id=44318330) #22 15 points 1 comments -> [How My Reporting on the Columbia Protests Led to My Deportation](https://www.newyorker.com/news/the-lede/how-my-reporting-on-the-columbia-protests-led-to-my-deportation)<!-- HN:44318330:end --><!-- HN:44318219:start -->
* [44318219](https://news.social-protocols.org/stats?id=44318219) #28 4 points 0 comments -> [US safety board wants Boeing 737 MAX engine warnings over smoke entering cockpit](https://www.reuters.com/world/us/ntsb-wants-action-cfm-leap-1b-engines-over-smoke-entering-cockpit-2025-06-18/)<!-- HN:44318219:end -->
#### **Friday, June 20, 2025**
<!-- HN:44323982:start -->
* [44323982](https://news.social-protocols.org/stats?id=44323982) #13 7 points 1 comments -> [Show HN: ATAC, an event verification platform evidence based](https://atac.seraum.com)<!-- HN:44323982:end --><!-- HN:44296659:start -->
* [44296659](https://news.social-protocols.org/stats?id=44296659) #18 8 points 1 comments -> [A real fixed-point decimal crate in Rust](https://github.com/WuBingzheng/primitive_fixed_point_decimal)<!-- HN:44296659:end --><!-- HN:44327270:start -->
* [44327270](https://news.social-protocols.org/stats?id=44327270) #30 3 points 0 comments -> [Attack on Oxford City Council exposes 21 years of election worker data](https://www.theregister.com/2025/06/20/oxford_city_council_breach/)<!-- HN:44327270:end -->