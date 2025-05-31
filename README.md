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

#### **Sunday, May 25, 2025**
<!-- HN:44085094:start -->
* [44085094](https://news.social-protocols.org/stats?id=44085094) #20 10 points 0 comments -> [J](https://blog.cloudflare.com/welcome-to-connectivity-cloud/)<!-- HN:44085094:end --><!-- HN:44084352:start -->
* [44084352](https://news.social-protocols.org/stats?id=44084352) #30 46 points 25 comments -> ['Crypto king' turned NYC townhouse into torture chamber to gain partner Bitcoin](https://www.nbcnewyork.com/new-york-city/manhattan-crypto-kidnapping-torture-bitcoin-password/6277345/)<!-- HN:44084352:end --><!-- HN:44085354:start -->
* [44085354](https://news.social-protocols.org/stats?id=44085354) #10 13 points 6 comments -> [Job Hunting Scripts](https://github.com/CajuM/jobhunt)<!-- HN:44085354:end --><!-- HN:44085891:start -->
* [44085891](https://news.social-protocols.org/stats?id=44085891) #13 4 points 0 comments -> [Global population growth is now slowing rapidly. Is it better for environment?](https://theconversation.com/global-population-growth-is-now-slowing-rapidly-will-a-falling-population-be-better-for-the-environment-235781)<!-- HN:44085891:end --><!-- HN:44053949:start -->
* [44053949](https://news.social-protocols.org/stats?id=44053949) #20 15 points 6 comments -> [Show HN: I made a running app that turns your runs to a virtual garden](https://www.runandgrow.com/)<!-- HN:44053949:end --><!-- HN:44087178:start -->
* [44087178](https://news.social-protocols.org/stats?id=44087178) #9 23 points 5 comments -> [From Philosophy to Power: The Misuse of René Girard by Peter Thiel, J.D. Vance](https://salmagundi.skidmore.edu/articles/1176-from-philosophy-to-power)<!-- HN:44087178:end --><!-- HN:44087926:start -->
* [44087926](https://news.social-protocols.org/stats?id=44087926) #4 10 points 11 comments -> [Trump's Middle East AI Deal: "Just Count the Server Racks"](https://www.chinatalk.media/p/about-that-ai-middle-east-deal)<!-- HN:44087926:end --><!-- HN:44090815:start -->
* [44090815](https://news.social-protocols.org/stats?id=44090815) #30 8 points 1 comments -> [Microsoft engineer fired for disrupting CEO Nadella's speech at Build 2025](https://timesofindia.indiatimes.com/technology/tech-news/microsoft-software-engineer-fired-for-disrupting-ceo-satya-nadellas-speech-at-build-2025-says-cant-open-/articleshow/121360389.cms)<!-- HN:44090815:end --><!-- HN:44070671:start -->
* [44070671](https://news.social-protocols.org/stats?id=44070671) #26 8 points 3 comments -> [What happens after you run Git push?](https://www.blacksmith.sh/blog/security)<!-- HN:44070671:end --><!-- HN:44092134:start -->
* [44092134](https://news.social-protocols.org/stats?id=44092134) #19 14 points 13 comments -> [The Grugbrained CEO](https://www.sam-rodriques.com/post/the-grugbrained-ceo)<!-- HN:44092134:end -->
#### **Monday, May 26, 2025**
<!-- HN:44073933:start -->
* [44073933](https://news.social-protocols.org/stats?id=44073933) #6 -> [So You Want to Look Rich?](https://marykateandsmashley.substack.com/p/so-you-want-to-look-rich)<!-- HN:44073933:end --><!-- HN:44071154:start -->
* [44071154](https://news.social-protocols.org/stats?id=44071154) #15 12 points 7 comments -> [Airhull lets electric boats glide on a layer of air](https://www.heise.de/en/news/Pascal-Technologies-Airhull-lets-electric-boats-glide-on-a-layer-of-air-10392755.html)<!-- HN:44071154:end --><!-- HN:44097050:start -->
* [44097050](https://news.social-protocols.org/stats?id=44097050) #2 27 points 3 comments -> [Show HN: Podman Desktop a 100% free OSS alternative to Docker Desktop](https://podman-desktop.io/)<!-- HN:44097050:end --><!-- HN:44097565:start -->
* [44097565](https://news.social-protocols.org/stats?id=44097565) #13 11 points 1 comments -> [The cost of AI is being paid in deserts far from Silicon Valley](https://restofworld.org/2025/ai-resource-extraction-chile-indigenous-communities/)<!-- HN:44097565:end --><!-- HN:44097311:start -->
* [44097311](https://news.social-protocols.org/stats?id=44097311) #3 11 points 6 comments -> [As a programmer, get your math sorted](https://www.csprimer.in/series/dm)<!-- HN:44097311:end --><!-- HN:44097539:start -->
* [44097539](https://news.social-protocols.org/stats?id=44097539) #3 17 points 4 comments -> ["Grok 3's Think mode identifies as Claude 3.5 Sonnet](https://www.websmithing.com/2025/05/24/grok-3-accidentally-reveals-its-actually-running-claude-3-5-sonnet/)<!-- HN:44097539:end --><!-- HN:44097076:start -->
* [44097076](https://news.social-protocols.org/stats?id=44097076) #3 1 points 0 comments -> [Show HN: Scholtz – Find customers and users that want your product](https://scholtz.ai/welcome)<!-- HN:44097076:end --><!-- HN:44097350:start -->
* [44097350](https://news.social-protocols.org/stats?id=44097350) #17 16 points 41 comments -> [$64B of data center projects blocked or delayed amid local opposition](https://www.datacenterwatch.org/report)<!-- HN:44097350:end --><!-- HN:44100429:start -->
* [44100429](https://news.social-protocols.org/stats?id=44100429) #19 8 points 0 comments -> [UAE becomes first to offer ChatGPT Plus to every resident and citizen](https://www.thearabianstories.com/2025/05/25/free-ai-for-all-uae-becomes-first-to-offer-chatgpt-plus-to-every-resident-and-citizen/)<!-- HN:44100429:end --><!-- HN:44100278:start -->
* [44100278](https://news.social-protocols.org/stats?id=44100278) #24 3 points 0 comments -> [Show HN: XOff an open source Chrome extension to change X links to Xcancel](https://codeberg.org/nice222/Xoff)<!-- HN:44100278:end --><!-- HN:44099096:start -->
* [44099096](https://news.social-protocols.org/stats?id=44099096) #14 171 points 34 comments -> [TeleMessage Customers Include DC Police, Andreessen Horowitz, JP Morgan,Hundreds](https://micahflee.com/telemessage-customers-include-dc-police-andreesen-horowitz-jp-morgan-and-hundreds-more/)<!-- HN:44099096:end -->
#### **Tuesday, May 27, 2025**
<!-- HN:44079313:start -->
* [44079313](https://news.social-protocols.org/stats?id=44079313) #8 10 points 2 comments -> [Black Mirror was a warmup act - OpenAI pivots into hardware](https://garymarcus.substack.com/p/black-mirror-was-a-warmup-act)<!-- HN:44079313:end --><!-- HN:44102376:start -->
* [44102376](https://news.social-protocols.org/stats?id=44102376) #4 103 points 15 comments -> [GitHub MCP Exploited: Accessing Private Repositories via MCP](https://invariantlabs.ai/blog/mcp-github-vulnerability)<!-- HN:44102376:end --><!-- HN:44081475:start -->
* [44081475](https://news.social-protocols.org/stats?id=44081475) #22 -> [Ask HN: Data aligment optimization in dav1d vs. rav1d](https://code.videolan.org/videolan/dav1d/-/merge_requests/1788)<!-- HN:44081475:end --><!-- HN:44104740:start -->
* [44104740](https://news.social-protocols.org/stats?id=44104740) #3 46 points 30 comments -> [He has powered his house for 8 years using laptop batteries](https://3dvf.com/en/he-has-powered-his-house-for-8-years-using-laptop-batteries/)<!-- HN:44104740:end --><!-- HN:44079204:start -->
* [44079204](https://news.social-protocols.org/stats?id=44079204) #14 16 points 6 comments -> [They Were Every Student's Worst Nightmare. Now Blue Books Are Back](https://www.wsj.com/business/chatgpt-ai-cheating-college-blue-books-5e3014a6)<!-- HN:44079204:end --><!-- HN:44105696:start -->
* [44105696](https://news.social-protocols.org/stats?id=44105696) #9 28 points 8 comments -> [Canon Law Ninja](https://canonlaw.ninja/)<!-- HN:44105696:end --><!-- HN:44105815:start -->
* [44105815](https://news.social-protocols.org/stats?id=44105815) #29 13 points 3 comments -> [Can It Run Doom? An Archive of All Known Ports](https://canitrundoom.org/)<!-- HN:44105815:end --><!-- HN:44109078:start -->
* [44109078](https://news.social-protocols.org/stats?id=44109078) #23 14 points 2 comments -> [Signal to Windows Recall: Drop Dead](https://www.computerworld.com/article/3994265/signal-to-windows-recall-drop-dead.html)<!-- HN:44109078:end --><!-- HN:44109239:start -->
* [44109239](https://news.social-protocols.org/stats?id=44109239) #4 14 points 6 comments -> [Women 3x More Likely to Lose Job to AI Than Men, UN Study Finds](https://www.allsides.com/story/economy-and-jobs-women-3x-more-likely-lose-job-ai-men-un-study-finds)<!-- HN:44109239:end --><!-- HN:44110220:start -->
* [44110220](https://news.social-protocols.org/stats?id=44110220) #3 7 points 1 comments -> [Chuuchuu - Train travel, made smart](https://www.chuuchuu.com/)<!-- HN:44110220:end -->
#### **Wednesday, May 28, 2025**
<!-- HN:44112152:start -->
* [44112152](https://news.social-protocols.org/stats?id=44112152) #20 3 points 4 comments -> [MailDock: Cold Email Infrastructure](https://maildock.io/)<!-- HN:44112152:end --><!-- HN:44087008:start -->
* [44087008](https://news.social-protocols.org/stats?id=44087008) #27 10 points 0 comments -> [Restoring Vangelis's Performance Sequencers](https://zyklus-mps.com/about)<!-- HN:44087008:end --><!-- HN:44112554:start -->
* [44112554](https://news.social-protocols.org/stats?id=44112554) #10 5 points 0 comments -> [Linux from Scratch](https://www.linuxfromscratch.org/lfs/view/12.3/)<!-- HN:44112554:end --><!-- HN:44112753:start -->
* [44112753](https://news.social-protocols.org/stats?id=44112753) #24 4 points 1 comments -> [EXT4 for Linux 6.16 Brings a Change Yielding "Stupendous Performance"](https://www.phoronix.com/news/Linux-6.16-EXT4-Performance)<!-- HN:44112753:end --><!-- HN:44112982:start -->
* [44112982](https://news.social-protocols.org/stats?id=44112982) #2 9 points 1 comments -> [The Captcha Paradox](https://talkingrobot.com/2025/05/the-captcha-paradox/)<!-- HN:44112982:end --><!-- HN:44113954:start -->
* [44113954](https://news.social-protocols.org/stats?id=44113954) #1 13 points 12 comments -> [We Tested 7 Languages Under Extreme Load and Only One Didn't Crash](https://freedium.cfd/https://medium.com/@codeperfect/we-tested-7-languages-under-extreme-load-and-only-one-didnt-crash-it-wasn-t-what-we-expected-67f84c79dc34)<!-- HN:44113954:end --><!-- HN:44113789:start -->
* [44113789](https://news.social-protocols.org/stats?id=44113789) #9 28 points 12 comments -> [Vibe coding for teams, thoughts to date](https://laughingmeme.org//2025/05/25/vibe-coding-for-teams.html)<!-- HN:44113789:end --><!-- HN:44114777:start -->
* [44114777](https://news.social-protocols.org/stats?id=44114777) #26 4 points 0 comments -> [SCOTUS Releases Long-Awaited Ethics Code: One Page That Says "Try Your Best"](https://sites.google.com/view/annnewsforamerica/scotus-releases-long-awaited-ethics-code-consisting-of-one-page-that-says?authuser=0)<!-- HN:44114777:end --><!-- HN:44114589:start -->
* [44114589](https://news.social-protocols.org/stats?id=44114589) #23 16 points 40 comments -> [Driverless Semi Trucks Are Here, with Little Regulation and Big Promises](https://www.nytimes.com/2025/05/27/business/driverless-semi-trucks-aurora-innovation.html)<!-- HN:44114589:end --><!-- HN:44115261:start -->
* [44115261](https://news.social-protocols.org/stats?id=44115261) #17 5 points 1 comments -> [Half the world population could be diabetic or insulin resistant by 2050](https://fortune.com/2025/05/26/half-the-world-population-potentially-diabetic-or-insulin-resistant-by-2050/)<!-- HN:44115261:end --><!-- HN:44115326:start -->
* [44115326](https://news.social-protocols.org/stats?id=44115326) #26 12 points 2 comments -> [The Colorado River is running low. The picture looks even worse underground](https://www.washingtonpost.com/climate-environment/2025/05/27/american-west-drought-water-colorado-river/)<!-- HN:44115326:end --><!-- HN:44118375:start -->
* [44118375](https://news.social-protocols.org/stats?id=44118375) #22 11 points 0 comments -> [LLM Shibboleths determine AI effectiveness](https://www.moderndescartes.com/essays/llm_shibboleths/)<!-- HN:44118375:end --><!-- HN:44117225:start -->
* [44117225](https://news.social-protocols.org/stats?id=44117225) #16 36 points 41 comments -> [Why is it so hard to get families to live in community houses?](https://supernuclear.substack.com/p/why-is-it-so-hard-to-get-families)<!-- HN:44117225:end --><!-- HN:44120381:start -->
* [44120381](https://news.social-protocols.org/stats?id=44120381) #11 6 points 3 comments -> [AR-Diffusion: Auto-Regressive Diffusion Model for Text Generation](https://arxiv.org/abs/2305.09515)<!-- HN:44120381:end -->
#### **Thursday, May 29, 2025**
<!-- HN:44121939:start -->
* [44121939](https://news.social-protocols.org/stats?id=44121939) #1 14 points 1 comments -> [I Lived Through Collapse. America Is Already There](https://indi.ca/i-lived-through-collapse-america-is-already-there/)<!-- HN:44121939:end --><!-- HN:44122305:start -->
* [44122305](https://news.social-protocols.org/stats?id=44122305) #16 10 points 1 comments -> [Anthropic CEO: AI could wipe out half of entry-level jobs](https://www.businessinsider.com/anthropic-ceo-warning-ai-could-eliminate-jobs-2025-5)<!-- HN:44122305:end --><!-- HN:44121891:start -->
* [44121891](https://news.social-protocols.org/stats?id=44121891) #17 3 points 0 comments -> [Sky, Natural Computing for the Macintosh](https://sky.app/)<!-- HN:44121891:end --><!-- HN:44125183:start -->
* [44125183](https://news.social-protocols.org/stats?id=44125183) #14 35 points 14 comments -> [The MAHA Report Cites Studies That Don't Exist](https://www.notus.org/health-science/make-america-healthy-again-report-citation-errors)<!-- HN:44125183:end --><!-- HN:44125493:start -->
* [44125493](https://news.social-protocols.org/stats?id=44125493) #30 9 points 2 comments -> [RFK Jr. says he may bar scientists from publishing in top medical journals](https://www.washingtonpost.com/health/2025/05/28/rfk-jr-ban-journals-lancet-jama/)<!-- HN:44125493:end --><!-- HN:44125874:start -->
* [44125874](https://news.social-protocols.org/stats?id=44125874) #29 3 points 0 comments -> [DeepSeek-R1-0528 performance improvements](https://huggingface.co/deepseek-ai/DeepSeek-R1-0528/blob/main/README.md)<!-- HN:44125874:end --><!-- HN:44127956:start -->
* [44127956](https://news.social-protocols.org/stats?id=44127956) #4 -> [Human coders are still better than LLMs](https://www.antirez.com/news/153)<!-- HN:44127956:end --><!-- HN:44128971:start -->
* [44128971](https://news.social-protocols.org/stats?id=44128971) #24 31 points 14 comments -> [The Headlines Are Evil, and They're Bringing Us Down](https://writing.kemitchell.com/2025/05/29/Trump-Tariffs-Decision-Headlines)<!-- HN:44128971:end --><!-- HN:44130928:start -->
* [44130928](https://news.social-protocols.org/stats?id=44130928) #4 30 points 15 comments -> [SQL Workbench – Republicans not welcome](https://www.sql-workbench.eu/)<!-- HN:44130928:end -->
#### **Friday, May 30, 2025**
<!-- HN:44131766:start -->
* [44131766](https://news.social-protocols.org/stats?id=44131766) #27 12 points 1 comments -> [US Economy Shrinks 0.2% on Weaker Spending, Larger Trade Impact](https://www.bloomberg.com/news/articles/2025-05-29/us-economy-shrinks-0-2-on-weaker-spending-larger-trade-impact)<!-- HN:44131766:end --><!-- HN:44132093:start -->
* [44132093](https://news.social-protocols.org/stats?id=44132093) #16 9 points 3 comments -> [Colleges must give up federal funding to achieve true intellectual freedom](https://thehill.com/opinion/5322428-trump-grants-harvard-columbia/)<!-- HN:44132093:end --><!-- HN:44131810:start -->
* [44131810](https://news.social-protocols.org/stats?id=44131810) #13 17 points 2 comments -> [The MAGA revolution threatens Boston, America's most innovative place](https://www.economist.com/united-states/2025/05/18/the-maga-revolution-threatens-americas-most-innovative-place)<!-- HN:44131810:end --><!-- HN:44132033:start -->
* [44132033](https://news.social-protocols.org/stats?id=44132033) #7 15 points 1 comments -> [What is Humphrey's Executor? A look at the 90-year-old Supreme Court decision](https://www.theusconstitution.org/news/what-is-humphreys-executor-a-look-at-the-90-year-old-supreme-court-decision-trump-is-targeting/)<!-- HN:44132033:end --><!-- HN:44133784:start -->
* [44133784](https://news.social-protocols.org/stats?id=44133784) #22 10 points 2 comments -> [The DSM is not medical science – it's a social control manual](https://github.com/stagas/papers/blob/main/dsm_arguments_against.md)<!-- HN:44133784:end --><!-- HN:44135713:start -->
* [44135713](https://news.social-protocols.org/stats?id=44135713) #30 7 points 0 comments -> [Radeon Software for Linux Dropping AMD's Proprietary OpenGL/Vulkan Drivers](https://www.phoronix.com/news/Radeon-Software-Drop-Prop-GL-VK)<!-- HN:44135713:end --><!-- HN:44133706:start -->
* [44133706](https://news.social-protocols.org/stats?id=44133706) #25 204 points 116 comments -> [Buttplug MCP](https://github.com/ConAcademy/buttplug-mcp)<!-- HN:44133706:end --><!-- HN:44135730:start -->
* [44135730](https://news.social-protocols.org/stats?id=44135730) #16 8 points 3 comments -> [Using Rust Back End to Serve an SPA](https://nguyenhuythanh.com/posts/rust-backend-spa/)<!-- HN:44135730:end --><!-- HN:44134208:start -->
* [44134208](https://news.social-protocols.org/stats?id=44134208) #19 30 points 40 comments -> [Why do we get earworms?](https://theneuroscienceofeverydaylife.substack.com/p/mahna-mahna-do-doo-be-do-do-why-do)<!-- HN:44134208:end --><!-- HN:44137822:start -->
* [44137822](https://news.social-protocols.org/stats?id=44137822) #27 4 points 0 comments -> [The Costs of AI: Why Your Cloud Bill Is Exploding](https://www.backblaze.com/blog/the-hidden-costs-of-ai-why-your-cloud-bill-is-exploding/)<!-- HN:44137822:end --><!-- HN:44139325:start -->
* [44139325](https://news.social-protocols.org/stats?id=44139325) #9 14 points 5 comments -> [Mercury's High Risk, High Rewards Strategy Runs into Regulatory Reality](https://fintechbusinessweekly.substack.com/p/mercurys-high-risk-high-rewards-strategy)<!-- HN:44139325:end --><!-- HN:44140285:start -->
* [44140285](https://news.social-protocols.org/stats?id=44140285) #3 14 points 2 comments -> [Governor Tina Kotek signs legislation to end child marriage in Oregon](https://www.nwprogressive.org/weblog/2025/05/done-governor-tina-kotek-signs-legislation-to-end-child-marriage-in-oregon.html)<!-- HN:44140285:end -->
#### **Saturday, May 31, 2025**
<!-- HN:44139765:start -->
* [44139765](https://news.social-protocols.org/stats?id=44139765) #25 25 points 29 comments -> [How to Automate Software Engineering](https://www.mechanize.work/blog/how-to-fully-automate-software-engineering/)<!-- HN:44139765:end -->