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
* [44327270](https://news.social-protocols.org/stats?id=44327270) #30 3 points 0 comments -> [Attack on Oxford City Council exposes 21 years of election worker data](https://www.theregister.com/2025/06/20/oxford_city_council_breach/)<!-- HN:44327270:end --><!-- HN:44326545:start -->
* [44326545](https://news.social-protocols.org/stats?id=44326545) #13 38 points 35 comments -> [Wayland Is Growing Up. and Now We Don't Have a Choice](https://fireborn.mataroa.blog/blog/i-want-to-love-linux-it-doesnt-love-me-back-post-4-wayland-is-growing-up-and-now-we-dont-have-a-choice/)<!-- HN:44326545:end --><!-- HN:44327047:start -->
* [44327047](https://news.social-protocols.org/stats?id=44327047) #6 6 points 0 comments -> [Nuke Map](https://nuclearsecrecy.com/nukemap/)<!-- HN:44327047:end --><!-- HN:44328282:start -->
* [44328282](https://news.social-protocols.org/stats?id=44328282) #14 5 points 1 comments -> [Wanted: New Instruments to Fund BBNs](https://www.freaktakes.com/p/wanted-new-instruments-to-fund-bbns)<!-- HN:44328282:end --><!-- HN:44326997:start -->
* [44326997](https://news.social-protocols.org/stats?id=44326997) #26 25 points 30 comments -> [Telegram founder Durov says his 100 children will receive share of his estate](https://www.cnn.com/2025/06/20/tech/durov-100-children-inheritance-scli-intl)<!-- HN:44326997:end --><!-- HN:44328677:start -->
* [44328677](https://news.social-protocols.org/stats?id=44328677) #29 3 points 0 comments -> [Amazon under UK investigation over alleged failure to pay suppliers on time](https://www.theguardian.com/technology/2025/jun/20/amazon-uk-investigation-alleged-failure-to-pay-groceries-suppliers-on-time)<!-- HN:44328677:end --><!-- HN:44328373:start -->
* [44328373](https://news.social-protocols.org/stats?id=44328373) #28 16 points 40 comments -> [Rise in 'alert fatigue' risks phone users disabling news notifications](https://www.theguardian.com/media/2025/jun/20/increase-alert-fatigue-phone-users-disable-news-notifications-study-finds)<!-- HN:44328373:end --><!-- HN:44330107:start -->
* [44330107](https://news.social-protocols.org/stats?id=44330107) #3 5 points 2 comments -> [Most AI Chatbots Are Just Glorified Search Bars](https://www.kasp.chat/)<!-- HN:44330107:end --><!-- HN:44331405:start -->
* [44331405](https://news.social-protocols.org/stats?id=44331405) #27 3 points 0 comments -> [Amazon says it will reduce its workforce as AI replaces human employees](https://www.cnn.com/2025/06/17/business/amazon-ai-human-employees-jobs)<!-- HN:44331405:end --><!-- HN:44330422:start -->
* [44330422](https://news.social-protocols.org/stats?id=44330422) #2 33 points 38 comments -> [Microsoft Is Deleting Old Drivers from Windows Update and It Might Break Your PC](https://nerds.xyz/2025/06/microsoft-driver-removal-windows-update-legacy-hardware-breaking/)<!-- HN:44330422:end --><!-- HN:44330755:start -->
* [44330755](https://news.social-protocols.org/stats?id=44330755) #15 89 points 91 comments -> [Malicious AI swarms can threaten democracy](https://osf.io/preprints/osf/qm9yk_v2)<!-- HN:44330755:end --><!-- HN:44332205:start -->
* [44332205](https://news.social-protocols.org/stats?id=44332205) #16 9 points 1 comments -> [DocuSign sends Cease and Desist to free SaaS developer](https://twitter.com/AzianMike/status/1935671153076678983)<!-- HN:44332205:end --><!-- HN:44332049:start -->
* [44332049](https://news.social-protocols.org/stats?id=44332049) #29 6 points 6 comments -> [U.S. Wealth Distribution (Including Billionaires)](https://joshworth.com/dev/wealthgap/)<!-- HN:44332049:end -->
#### **Saturday, June 21, 2025**
<!-- HN:44332912:start -->
* [44332912](https://news.social-protocols.org/stats?id=44332912) #22 49 points 41 comments -> [Drinks in glass bottles contain more microplastics than those in other container](https://www.anses.fr/en/content/drinks-glass-bottles-contain-more-microplastics-those-other-containers)<!-- HN:44332912:end --><!-- HN:44333077:start -->
* [44333077](https://news.social-protocols.org/stats?id=44333077) #19 12 points 7 comments -> [AtomicOS – A security-first OS with real crypto and deterministic language](https://github.com/ipenas-cl/AtomicOs)<!-- HN:44333077:end --><!-- HN:44307388:start -->
* [44307388](https://news.social-protocols.org/stats?id=44307388) #16 30 points 40 comments -> [I Dropped the Production Database on a Friday Night](https://vince.beehiiv.com/p/how-i-dropped-the-production-database-on-a-friday-night)<!-- HN:44307388:end --><!-- HN:44333921:start -->
* [44333921](https://news.social-protocols.org/stats?id=44333921) #30 40 points 40 comments -> [Texas Sheriffs Crack Bitcoin ATM with Power Tools to Retrieve $32,000](https://decrypt.co/326308/texas-sheriffs-crack-bitcoin-atm-with-power-tools-to-retrieve-32000)<!-- HN:44333921:end --><!-- HN:44337114:start -->
* [44337114](https://news.social-protocols.org/stats?id=44337114) #30 4 points 2 comments -> [I've ditched HR to free my company from the DEI police](https://nypost.com/2025/06/20/opinion/ive-ditched-hr-to-free-my-company-from-the-dei-police/)<!-- HN:44337114:end --><!-- HN:44337383:start -->
* [44337383](https://news.social-protocols.org/stats?id=44337383) #20 9 points 1 comments -> [A White Nationalist Wrote a Law Paper Promoting Racist Views. Won Him an Award](https://www.nytimes.com/2025/06/21/us/white-supremacist-university-of-florida-paper.html)<!-- HN:44337383:end --><!-- HN:44339343:start -->
* [44339343](https://news.social-protocols.org/stats?id=44339343) #25 3 points 1 comments -> [XOR's Shader Arsenal: A collection of various tiny shaders](https://www.xordev.com/arsenal)<!-- HN:44339343:end -->
#### **Sunday, June 22, 2025**
<!-- HN:44333187:start -->
* [44333187](https://news.social-protocols.org/stats?id=44333187) #25 249 points 160 comments -> [Plastic bag bans and fees reduce harmful bag litter on shorelines](https://www.science.org/doi/10.1126/science.adp9274)<!-- HN:44333187:end --><!-- HN:44341462:start -->
* [44341462](https://news.social-protocols.org/stats?id=44341462) #10 13 points 5 comments -> [Publishing a Docker Container for MS Edit to the GitHub Container Registry](https://til.simonwillison.net/github/container-registry)<!-- HN:44341462:end --><!-- HN:44341678:start -->
* [44341678](https://news.social-protocols.org/stats?id=44341678) #19 260 points 2 comments -> [U.S. strikes Iran's nuclear facilities](https://www.axios.com/2025/06/21/us-strike-iran-nuclear-israel-trump)<!-- HN:44341678:end -->