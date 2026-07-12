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

#### **Monday, July 6, 2026**
<!-- HN:48798187:start -->
* [48798187](https://news.social-protocols.org/stats?id=48798187) #30 9 points 2 comments -> [Had an idea for a Rust editor with simple Vim mode for learning](https://github.com/electronicsleep/rust-vim)<!-- HN:48798187:end --><!-- HN:48799220:start -->
* [48799220](https://news.social-protocols.org/stats?id=48799220) #14 5 points 6 comments -> [Strange Balls found on Queensland beaches could be toxic 'space debris': experts](https://www.inkl.com/news/strange-balls-found-on-queensland-beaches-could-be-toxic-space-debris-experts-warn)<!-- HN:48799220:end --><!-- HN:48799192:start -->
* [48799192](https://news.social-protocols.org/stats?id=48799192) #22 7 points 0 comments -> [Building Agents That Don't Break Themselves](https://fly.io/blog/building-agents-that-dont-break-themselves/)<!-- HN:48799192:end --><!-- HN:48799677:start -->
* [48799677](https://news.social-protocols.org/stats?id=48799677) #6 6 points 5 comments -> [Children Adopt AI 3x Faster Than Adults – and We're Not Ready](https://hackenewhome.blogspot.com/p/ai-is-taking-over-kids-lives-unicef.html)<!-- HN:48799677:end --><!-- HN:48757074:start -->
* [48757074](https://news.social-protocols.org/stats?id=48757074) #28 14 points 3 comments -> [Show HN: I wrote a Rust book ending with a Redis clone](https://shankhan3.gumroad.com/l/dnwmtp)<!-- HN:48757074:end --><!-- HN:48803286:start -->
* [48803286](https://news.social-protocols.org/stats?id=48803286) #4 11 points 2 comments -> [I'm just so bored of AI](https://shkspr.mobi/blog/2026/07/im-just-so-bored-of-ai/)<!-- HN:48803286:end --><!-- HN:48803507:start -->
* [48803507](https://news.social-protocols.org/stats?id=48803507) #6 3 points 0 comments -> [Probably the best AI detector tool is ready](https://aidetector.my/en)<!-- HN:48803507:end --><!-- HN:48803621:start -->
* [48803621](https://news.social-protocols.org/stats?id=48803621) #3 8 points 5 comments -> [Kill the Plastic AI Portrait](https://realistic-shot-deploy-eight.vercel.app/)<!-- HN:48803621:end --><!-- HN:48801488:start -->
* [48801488](https://news.social-protocols.org/stats?id=48801488) #20 48 points 38 comments -> [Generate parametric, manufacturable 3D models in seconds](https://kyrall.com/)<!-- HN:48801488:end --><!-- HN:48804113:start -->
* [48804113](https://news.social-protocols.org/stats?id=48804113) #5 8 points 0 comments -> [I packed 16 GB of GGUF quants into 1.8 GB, losslessly](https://github.com/theadamdanielsson/ggufpacker)<!-- HN:48804113:end --><!-- HN:48804049:start -->
* [48804049](https://news.social-protocols.org/stats?id=48804049) #10 36 points 25 comments -> [Bryan Johnson: I have an autoimmune disease. My stomach is eating itself](https://twitter.com/bryan_johnson/status/2072069730517860385)<!-- HN:48804049:end --><!-- HN:48804176:start -->
* [48804176](https://news.social-protocols.org/stats?id=48804176) #14 25 points 12 comments -> [The Fear of Dying Before You Become Yourself](https://www.dailicle.com/read/the-fear-of-dying-before-you-become-yourself)<!-- HN:48804176:end --><!-- HN:48804218:start -->
* [48804218](https://news.social-protocols.org/stats?id=48804218) #5 37 points 9 comments -> [Real time map of France's rail network](https://carto.tchoo.net/)<!-- HN:48804218:end --><!-- HN:48804000:start -->
* [48804000](https://news.social-protocols.org/stats?id=48804000) #22 14 points 9 comments -> [Show HN: Pet Reminder – A macOS reminder app with a desktop pet](https://reminder.w3cub.com/)<!-- HN:48804000:end --><!-- HN:48805627:start -->
* [48805627](https://news.social-protocols.org/stats?id=48805627) #11 71 points 24 comments -> [Google Chrome Installed a 4GB AI Model on Your PC](https://oztalking.com/en/issues/hidden-4gb-ai-model)<!-- HN:48805627:end --><!-- HN:48808047:start -->
* [48808047](https://news.social-protocols.org/stats?id=48808047) #21 6 points 3 comments -> [Schizo founder story (terrorist to tech exit)](https://peteryoung.me/the-terrorists-guide-to-retiring-young/)<!-- HN:48808047:end --><!-- HN:48807884:start -->
* [48807884](https://news.social-protocols.org/stats?id=48807884) #20 11 points 5 comments -> [Fable Built a 3D Model of Aristotle's Cognitive Architecture](https://conceptual-spaces.vercel.app)<!-- HN:48807884:end --><!-- HN:48810453:start -->
* [48810453](https://news.social-protocols.org/stats?id=48810453) #28 9 points 0 comments -> [DOGE Shrank the Payroll, Not the Deficit](https://rubbishtalk.com/economy/doge-shrank-the-payroll-not-the-deficit/)<!-- HN:48810453:end --><!-- HN:48811357:start -->
* [48811357](https://news.social-protocols.org/stats?id=48811357) #30 3 points 0 comments -> [Claude and Codex and Grok: my current workflow and its friction](https://www.nativesoul.dev/)<!-- HN:48811357:end -->
#### **Tuesday, July 7, 2026**
<!-- HN:48812450:start -->
* [48812450](https://news.social-protocols.org/stats?id=48812450) #16 5 points 2 comments -> [I created a free tool that pairs your Nasic and past performance to win contract](https://www.fedfinder.net/)<!-- HN:48812450:end --><!-- HN:48770485:start -->
* [48770485](https://news.social-protocols.org/stats?id=48770485) #12 6 points 2 comments -> [Artificial and Fake Eggs: Dance of Death](https://www.researchgate.net/publication/281149909_Artificial_and_Fake_Eggs_Dance_of_Death)<!-- HN:48770485:end --><!-- HN:48814852:start -->
* [48814852](https://news.social-protocols.org/stats?id=48814852) #8 4 points 0 comments -> [Fable – Inner Forward Pass](https://claude.ai/public/artifacts/05b42f8b-a4a3-4a7a-9774-c5d427ada379)<!-- HN:48814852:end --><!-- HN:48816087:start -->
* [48816087](https://news.social-protocols.org/stats?id=48816087) #1 6 points 1 comments -> [IDE with agentic support built using Flutter](https://lumide.dev)<!-- HN:48816087:end --><!-- HN:48816426:start -->
* [48816426](https://news.social-protocols.org/stats?id=48816426) #1 13 points 1 comments -> [Mullvad's co-founder is bankrolling the far right](https://korben.info/en/mullvad-cofounder-funding-far-right.html)<!-- HN:48816426:end --><!-- HN:48816129:start -->
* [48816129](https://news.social-protocols.org/stats?id=48816129) #13 25 points 5 comments -> [PostgreSQL Benchmark: AWS RDS vs. Self-Hosted on Hetzner (2026)](https://hostim.dev/blog/postgres-benchmark-rds-vs-hostim-vs-self-hosted/)<!-- HN:48816129:end --><!-- HN:48816768:start -->
* [48816768](https://news.social-protocols.org/stats?id=48816768) #24 14 points 2 comments -> [Immigrants Use Less Welfare, Even Counting Their US-Born Children](https://www.cato.org/blog/immigrants-use-less-welfare-even-counting-their-us-born-children)<!-- HN:48816768:end --><!-- HN:48818271:start -->
* [48818271](https://news.social-protocols.org/stats?id=48818271) #16 22 points 42 comments -> [Sodium-ion "salt" batteries will revolutionize electric-vehicle and grid storage](https://www.newscientist.com/article/2532997-salt-batteries-are-about-to-shake-up-evs-and-grid-storage/)<!-- HN:48818271:end --><!-- HN:48818124:start -->
* [48818124](https://news.social-protocols.org/stats?id=48818124) #6 22 points 10 comments -> [Show HN: Shellular – run Claude Code, Codex, Pi from your phone](https://shellular.dev/)<!-- HN:48818124:end --><!-- HN:48819958:start -->
* [48819958](https://news.social-protocols.org/stats?id=48819958) #18 11 points 0 comments -> [Weighing smoke: why AI visibility dashboards are mostly useless](https://betterthangood.xyz/blog/weighing-smoke/)<!-- HN:48819958:end --><!-- HN:48819084:start -->
* [48819084](https://news.social-protocols.org/stats?id=48819084) #30 10 points 1 comments -> [Secret Tracker in Claude Code Uncovered, Anthropic Directly Deletes Code](https://voi.id/en/technology/583552)<!-- HN:48819084:end --><!-- HN:48821691:start -->
* [48821691](https://news.social-protocols.org/stats?id=48821691) #28 5 points 3 comments -> [Decrypting View State Messages](https://zeroed.tech/blog/decrypting-viewstate-messages/)<!-- HN:48821691:end -->
#### **Wednesday, July 8, 2026**<!-- HN:48826118:start -->
* [48826118](https://news.social-protocols.org/stats?id=48826118) #27 4 points 2 comments -> [Path to Google's #1 Position](https://mysevenstars.com/articles/SEO-Google-top-rank.html)<!-- HN:48826118:end --><!-- HN:48826572:start -->
* [48826572](https://news.social-protocols.org/stats?id=48826572) #26 8 points 0 comments -> [Ranked worst to best: 13 flavors of Pure Leaf iced tea](https://www.tastingtable.com/1866292/pure-leaf-iced-tea-flavors-ranked/)<!-- HN:48826572:end --><!-- HN:48826756:start -->
* [48826756](https://news.social-protocols.org/stats?id=48826756) #2 9 points 4 comments -> [Google Gemini Killed Perplexity AI](https://fatjoe.com/blog/perplexity-ai-stats/)<!-- HN:48826756:end --><!-- HN:48830388:start -->
* [48830388](https://news.social-protocols.org/stats?id=48830388) #7 15 points 17 comments -> [We Got This Wrong. and We Are Fixing It](https://community.hubspot.com/t/we-got-this-wrong-and-we-are-fixing-it/152063)<!-- HN:48830388:end --><!-- HN:48837286:start -->
* [48837286](https://news.social-protocols.org/stats?id=48837286) #13 3 points 1 comments -> [The Great Cholesterol Scam and the Dangers of Statins](https://www.midwesterndoctor.com/p/the-great-cholesterol-scam-and-the)<!-- HN:48837286:end -->
#### **Thursday, July 9, 2026**
<!-- HN:48839751:start -->
* [48839751](https://news.social-protocols.org/stats?id=48839751) #11 19 points 3 comments -> [Rewriting Bun in Rust](https://simonwillison.net/2026/Jul/8/rewriting-bun-in-rust/)<!-- HN:48839751:end --><!-- HN:48783470:start -->
* [48783470](https://news.social-protocols.org/stats?id=48783470) #19 4 points 0 comments -> [The Factorio Effect](https://dangrafham.com/the-factorio-effect)<!-- HN:48783470:end --><!-- HN:48843585:start -->
* [48843585](https://news.social-protocols.org/stats?id=48843585) #5 4 points 0 comments -> [Please Delete Your Repository](https://github.com/Vandivier/ladderly-3/issues/652)<!-- HN:48843585:end --><!-- HN:48803545:start -->
* [48803545](https://news.social-protocols.org/stats?id=48803545) #12 13 points 8 comments -> [Why is there smoke from the boiler room? – Botanical Garden using Home Assistant](https://vooijs.eu/posts/why-is-there-smoke-from-the-boiler-room/)<!-- HN:48803545:end --><!-- HN:48844956:start -->
* [48844956](https://news.social-protocols.org/stats?id=48844956) #12 17 points 2 comments -> [Show HN: 92% of US city websites fail Ada accessibility](https://accesslumens.com/research/state-of-us-local-government-accessibility-2026)<!-- HN:48844956:end --><!-- HN:48845326:start -->
* [48845326](https://news.social-protocols.org/stats?id=48845326) #11 9 points 9 comments -> [AI builders outnumber AI governance hires 7:1 in Europe](https://axipro.co/eu-ai-act-hiring-gap-study/)<!-- HN:48845326:end --><!-- HN:48845555:start -->
* [48845555](https://news.social-protocols.org/stats?id=48845555) #22 9 points 2 comments -> [Is It Safe to Host HTML That Runs Its Own JavaScript?](https://sharemypage.app/blog/is-it-safe-to-host-html-that-runs-javascript)<!-- HN:48845555:end --><!-- HN:48845269:start -->
* [48845269](https://news.social-protocols.org/stats?id=48845269) #19 29 points 42 comments -> [Just Pay the Subscription](https://www.uncommonapps.nyc/p/just-pay-the-subscription)<!-- HN:48845269:end --><!-- HN:48845440:start -->
* [48845440](https://news.social-protocols.org/stats?id=48845440) #30 31 points 6 comments -> [MSG database tracked hundreds. Labels include "LGBTQIA," and low to high "risk."](https://www.wired.com/story/madison-square-garden-celebrity-database-surveillance/)<!-- HN:48845440:end --><!-- HN:48847446:start -->
* [48847446](https://news.social-protocols.org/stats?id=48847446) #5 10 points 0 comments -> [Deadly bacteria found in city's wastewater system tied to Meta data center](https://www.dailymail.com/sciencetech/article-15962981/mark-zuckerberg-meta-wyoming-ai-data-center-bacteria.html)<!-- HN:48847446:end --><!-- HN:48847368:start -->
* [48847368](https://news.social-protocols.org/stats?id=48847368) #24 4 points 6 comments -> [Stop Using reCAPTCHA – It's Not a Real Captcha](https://na0341.bearblog.dev/info/stop-using-recaptcha/)<!-- HN:48847368:end --><!-- HN:48845526:start -->
* [48845526](https://news.social-protocols.org/stats?id=48845526) #30 36 points 40 comments -> [A new way to reflect on how you use Claude](https://www.anthropic.com/news/reflect-with-claude)<!-- HN:48845526:end --><!-- HN:48846928:start -->
* [48846928](https://news.social-protocols.org/stats?id=48846928) #25 24 points 3 comments -> [New "Revenue Larping Trend" is this real?](https://www.larp.website/)<!-- HN:48846928:end --><!-- HN:48850428:start -->
* [48850428](https://news.social-protocols.org/stats?id=48850428) #29 9 points 2 comments -> [Dev productivity metrics suck. Ops reviews are key for AI-accelerated eng orgs](https://www.cortex.io/drive)<!-- HN:48850428:end --><!-- HN:48851430:start -->
* [48851430](https://news.social-protocols.org/stats?id=48851430) #8 15 points 5 comments -> [Don't Get Sick in America](https://blogography.com/archives/2026/07/dont-get-sick-in-america.html)<!-- HN:48851430:end -->
#### **Friday, July 10, 2026**
<!-- HN:48805587:start -->
* [48805587](https://news.social-protocols.org/stats?id=48805587) #10 6 points 2 comments -> [Preempt_none Is Dead; Your Postgres Probably Doesn't Care](https://thebuild.com/blog/preempt_none-is-dead-your-postgres-probably-doesnt-care/)<!-- HN:48805587:end --><!-- HN:48856685:start -->
* [48856685](https://news.social-protocols.org/stats?id=48856685) #10 12 points 2 comments -> [Browser Fingerprinting – How websites track you across internet –without cookies](https://mysysinfo.com/blog/what-is-browser-fingerprinting)<!-- HN:48856685:end --><!-- HN:48785421:start -->
* [48785421](https://news.social-protocols.org/stats?id=48785421) #27 -> [Thinking about buying a Prusa 3D printer?](https://bambu3design.com/prusa-summer-sale-2026-mk4s-gets-up-to-20-off-core-one-shipping-discount/)<!-- HN:48785421:end --><!-- HN:48858458:start -->
* [48858458](https://news.social-protocols.org/stats?id=48858458) #13 15 points 4 comments -> [80-year-old woman with Alzheimer's took mushrooms and started speaking again](https://www.microdos.in/en/research/alzheimers-case-report-psilocybin-speech)<!-- HN:48858458:end --><!-- HN:48859047:start -->
* [48859047](https://news.social-protocols.org/stats?id=48859047) #1 13 points 9 comments -> [AI doesn't know how to forgive and cannot forget](https://tejassuds.com/blog/ai-cannot-forget)<!-- HN:48859047:end --><!-- HN:48859781:start -->
* [48859781](https://news.social-protocols.org/stats?id=48859781) #4 15 points 3 comments -> [Offline tool to stabilize TV volume using IR control and spike detection](https://github.com/AdBusterOfficial/Adbuster--WinApp)<!-- HN:48859781:end --><!-- HN:48862035:start -->
* [48862035](https://news.social-protocols.org/stats?id=48862035) #9 12 points 11 comments -> [Garnix Is Joining Shopify](https://garnix.io/blog/shutting-down/)<!-- HN:48862035:end --><!-- HN:48862510:start -->
* [48862510](https://news.social-protocols.org/stats?id=48862510) #18 6 points 1 comments -> [Chat Control 1.0 has been passed](https://gerarddupre.dev/en/blog/chat-control-1-passed/)<!-- HN:48862510:end --><!-- HN:48815278:start -->
* [48815278](https://news.social-protocols.org/stats?id=48815278) #21 6 points 4 comments -> [Let's Reinvent the Scroll Wheel](https://scrollpods.app/blog/lets-reinvent-the-scroll-wheel)<!-- HN:48815278:end --><!-- HN:48863022:start -->
* [48863022](https://news.social-protocols.org/stats?id=48863022) #19 6 points 6 comments -> [Bun vs. Deno vs. Node.js 2026: Real Benchmarks Mislead](https://byteiota.com/bun-vs-deno-vs-node-js-2026-real-benchmarks-mislead/)<!-- HN:48863022:end --><!-- HN:48862467:start -->
* [48862467](https://news.social-protocols.org/stats?id=48862467) #23 45 points 38 comments -> [Anyone else get a vague GitHub shakedown notice?](https://lists.osgeo.org/pipermail/qgis-developer/2026-July/068430.html)<!-- HN:48862467:end --><!-- HN:48864158:start -->
* [48864158](https://news.social-protocols.org/stats?id=48864158) #29 173 points 44 comments -> [Mayor Mamdani Announces Landmark "Click-to-Cancel" Consumer Protection Rules](https://www.nyc.gov/mayors-office/news/2026/07/mayor-mamdani-announces-landmark--click-to-cancel--consumer-prot)<!-- HN:48864158:end --><!-- HN:48865431:start -->
* [48865431](https://news.social-protocols.org/stats?id=48865431) #25 102 points 12 comments -> [Apple Sues OpenAI, Accusing It of Stealing Company Secrets](https://www.nytimes.com/2026/07/10/technology/apple-openai-lawsuit.html)<!-- HN:48865431:end -->
#### **Saturday, July 11, 2026**
<!-- HN:48867124:start -->
* [48867124](https://news.social-protocols.org/stats?id=48867124) #6 6 points 0 comments -> [Show HN: We beat Cloudflare's bot detection (open-source stealth browser)](https://tilion.dev/blog/cloudflare-blocks-agents)<!-- HN:48867124:end --><!-- HN:48867220:start -->
* [48867220](https://news.social-protocols.org/stats?id=48867220) #25 6 points 2 comments -> [The iconic blue IKEA FRAKTA bag comes with a free lifetime warranty](https://ikeamuseum.com/en/explore/the-story-of-ikea/beloved-bag/)<!-- HN:48867220:end --><!-- HN:48867364:start -->
* [48867364](https://news.social-protocols.org/stats?id=48867364) #15 12 points 10 comments -> [I've been building this alone for months. Roast it before I lose any more time](https://peakd.io)<!-- HN:48867364:end --><!-- HN:48814341:start -->
* [48814341](https://news.social-protocols.org/stats?id=48814341) #8 4 points 0 comments -> [The Rule of 7 and the 7-Touchpoint Myth](https://anartfulscience.com/insights/rule-of-7-marketing/)<!-- HN:48814341:end --><!-- HN:48869243:start -->
* [48869243](https://news.social-protocols.org/stats?id=48869243) #15 39 points 11 comments -> [What's the best way to do authentication in modern applications](https://neciudan.dev/most-secure-way-to-store-auth-token)<!-- HN:48869243:end --><!-- HN:48870966:start -->
* [48870966](https://news.social-protocols.org/stats?id=48870966) #1 15 points 2 comments -> [pgrust passes 100% of the Postgres regression tests](https://malisper.me/pgrust-passes-100-of-postgresqls-regression-tests/)<!-- HN:48870966:end --><!-- HN:48817088:start -->
* [48817088](https://news.social-protocols.org/stats?id=48817088) #28 3 points 0 comments -> [Show HN: Sdlc factory built on pi.dev:intent-&gt;DDD-&gt;architecture-&gt;tested code](https://github.com/arman-jalili/guardian-framework)<!-- HN:48817088:end --><!-- HN:48871716:start -->
* [48871716](https://news.social-protocols.org/stats?id=48871716) #3 8 points 2 comments -> [Semantic/Hybrid Search in the Browser](https://bart.degoe.de/semantic-search-in-your-browser/)<!-- HN:48871716:end --><!-- HN:48873978:start -->
* [48873978](https://news.social-protocols.org/stats?id=48873978) #22 12 points 7 comments -> [Alex Karp Is Saying What Every Angry CEO Is Thinking About AI](https://www.wsj.com/tech/ai/alex-karp-is-saying-what-every-angry-ceo-is-thinking-about-ai-7f5f7c0c)<!-- HN:48873978:end --><!-- HN:48875709:start -->
* [48875709](https://news.social-protocols.org/stats?id=48875709) #2 21 points 8 comments -> [OpenAI Forked Git on GitHub](https://github.com/openai/git)<!-- HN:48875709:end --><!-- HN:48875494:start -->
* [48875494](https://news.social-protocols.org/stats?id=48875494) #21 34 points 40 comments -> [I used to love Claude, but the latest models are slowly ruining it](https://www.androidauthority.com/claude-latest-models-pushback-bad-3683521/)<!-- HN:48875494:end -->
#### **Sunday, July 12, 2026**<!-- HN:48876970:start -->
* [48876970](https://news.social-protocols.org/stats?id=48876970) #9 12 points 12 comments -> [Odyssey Linux](https://odysseylinux.org)<!-- HN:48876970:end --><!-- HN:48877349:start -->
* [48877349](https://news.social-protocols.org/stats?id=48877349) #12 31 points 9 comments -> [Firefox 12.58% for Desktop Browser Market Share in North America June 2026](https://gs.statcounter.com/browser-market-share/desktop/north-america)<!-- HN:48877349:end --><!-- HN:48877421:start -->
* [48877421](https://news.social-protocols.org/stats?id=48877421) #27 8 points 4 comments -> [Rep. Ro Khanna was detained by Israeli settlers in occupied West Bank](https://www.theguardian.com/world/2026/jul/11/ro-khanna-congressman-detained-israel-settlers-west-bank)<!-- HN:48877421:end --><!-- HN:48877009:start -->
* [48877009](https://news.social-protocols.org/stats?id=48877009) #22 18 points 3 comments -> [A public ledger of cloud outages and the SLA credits they trigger](https://slacreditwatch.com)<!-- HN:48877009:end --><!-- HN:48877672:start -->
* [48877672](https://news.social-protocols.org/stats?id=48877672) #21 3 points 3 comments -> [Show HN: Quantum-Qec / Matrix-Free Quantum Homeostatic Engine(Blueprint)](https://github.com/PJHkorea/quantum-mesh-qec)<!-- HN:48877672:end --><!-- HN:48878908:start -->
* [48878908](https://news.social-protocols.org/stats?id=48878908) #12 8 points 1 comments -> [Lindsey Graham, longtime South Carolina senator, dies at 71, office says](https://www.washingtonpost.com/politics/2026/07/12/lindsey-graham-longtime-south-carolina-senator-dies-71/)<!-- HN:48878908:end --><!-- HN:48877927:start -->
* [48877927](https://news.social-protocols.org/stats?id=48877927) #20 85 points 89 comments -> [Why are US consumers so angry? It's not just high prices](https://www.theguardian.com/us-news/ng-interactive/2026/jun/04/us-consumer-rage-prices-economy)<!-- HN:48877927:end --><!-- HN:48877192:start -->
* [48877192](https://news.social-protocols.org/stats?id=48877192) #22 98 points 45 comments -> [Long Covid May Physically Damage the Nerves That Control the Stomach](https://www.ijidonline.com/article/S1201-9712(26)00608-9/fulltext)<!-- HN:48877192:end --><!-- HN:48879232:start -->
* [48879232](https://news.social-protocols.org/stats?id=48879232) #27 10 points 4 comments -> [Senator Lindsey Graham, Republican of South Carolina, Dies at 71](https://www.nytimes.com/2026/07/12/us/politics/lindsey-graham-dead.html)<!-- HN:48879232:end --><!-- HN:48880037:start -->
* [48880037](https://news.social-protocols.org/stats?id=48880037) #11 8 points 1 comments -> [Sen. Lindsey Graham dies at 71 after 'brief and sudden illness'](https://www.nbcnews.com/politics/politics-news/sen-lindsey-graham-dies-71-brief-sudden-illness-rcna552722)<!-- HN:48880037:end --><!-- HN:48879920:start -->
* [48879920](https://news.social-protocols.org/stats?id=48879920) #19 4 points 1 comments -> [Oh dear, did someone steal something from Apple?](https://www.businessinsider.com/apple-openai-trade-secrets-masimo-a123-jony-ive-2026-7)<!-- HN:48879920:end --><!-- HN:48879902:start -->
* [48879902](https://news.social-protocols.org/stats?id=48879902) #24 14 points 13 comments -> [Death of the Status Update: Why 55% of Americans Stopped Posting on Social Media](https://ca.pcmag.com/social-media/16790/the-death-of-the-status-update-why-55-of-americans-stopped-posting-on-social-media)<!-- HN:48879902:end -->