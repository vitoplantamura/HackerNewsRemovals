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

#### **Saturday, July 4, 2026**
<!-- HN:48781865:start -->
* [48781865](https://news.social-protocols.org/stats?id=48781865) #10 7 points 2 comments -> [CueBench for Developers is live: score how well you drive coding agents](https://app.cuebench.dev)<!-- HN:48781865:end --><!-- HN:48783125:start -->
* [48783125](https://news.social-protocols.org/stats?id=48783125) #12 6 points 3 comments -> [Godot bans "vibe-coded" code contributions](https://theguptalog.blogspot.com/2026/07/godot-bans-ai-generated-code.html)<!-- HN:48783125:end --><!-- HN:48785026:start -->
* [48785026](https://news.social-protocols.org/stats?id=48785026) #3 10 points 4 comments -> [Show HN: Foundation, a different approach to software and AI](https://github.com/nmxmxh/foundation)<!-- HN:48785026:end --><!-- HN:48785573:start -->
* [48785573](https://news.social-protocols.org/stats?id=48785573) #15 -> ['All men are created equal': America has lost its values. It's time to go back](https://www.theguardian.com/us-news/ng-interactive/2026/jul/04/250-years-declaration-of-independence)<!-- HN:48785573:end --><!-- HN:48788041:start -->
* [48788041](https://news.social-protocols.org/stats?id=48788041) #15 2 points 0 comments -> [Iredis](https://github.com/laixintao/iredis)<!-- HN:48788041:end --><!-- HN:48765066:start -->
* [48765066](https://news.social-protocols.org/stats?id=48765066) #11 8 points 0 comments -> [At Dog School, children gain a sense of achievement](https://www.csmonitor.com/Perspectives/Making-a-difference/2026/0630/dog-school-south-africa-funda-nenja)<!-- HN:48765066:end -->
#### **Sunday, July 5, 2026**
<!-- HN:48790122:start -->
* [48790122](https://news.social-protocols.org/stats?id=48790122) #23 9 points 6 comments -> [Zo Computer](https://www.zo.computer)<!-- HN:48790122:end --><!-- HN:48789325:start -->
* [48789325](https://news.social-protocols.org/stats?id=48789325) #26 28 points 41 comments -> [My AI-built PHP engine in Rust passes 17% of PHP-src tests, renders WordPress](https://ekinertac.com/blog/i-dont-know-rust-my-ai-is-rewriting-php-in-it/)<!-- HN:48789325:end --><!-- HN:48747762:start -->
* [48747762](https://news.social-protocols.org/stats?id=48747762) #20 30 points 40 comments -> [Can you build a recognizable World Map in under 500 bytes?](https://www.experimentlog.com/blog/building-a-world-map-with-only-500-bytes)<!-- HN:48747762:end --><!-- HN:48791440:start -->
* [48791440](https://news.social-protocols.org/stats?id=48791440) #15 15 points 3 comments -> [Beeg float library, a Rust port of Fabrice Bellard's libbf](https://github.com/lifthrasiir/libbeef)<!-- HN:48791440:end --><!-- HN:48791799:start -->
* [48791799](https://news.social-protocols.org/stats?id=48791799) #15 42 points 40 comments -> [Is The Economist Always Wrong?](https://economist.com/interactive/finance-and-economics/2026/07/02/is-the-economist-always-wrong)<!-- HN:48791799:end --><!-- HN:48760633:start -->
* [48760633](https://news.social-protocols.org/stats?id=48760633) #15 9 points 4 comments -> [The Economy Is K-Shaped](https://moai.studio/blog/posts/economy-is-k-shaped.html)<!-- HN:48760633:end --><!-- HN:48793102:start -->
* [48793102](https://news.social-protocols.org/stats?id=48793102) #1 10 points 3 comments -> [Returning to Zig after losing trust in Rust's governance](https://gracefulliberty.com/articles/return-to-zig/)<!-- HN:48793102:end --><!-- HN:48793020:start -->
* [48793020](https://news.social-protocols.org/stats?id=48793020) #1 25 points 4 comments -> [Ford rehires human engineers after AI fails to match quality checks](https://www.bbc.com/news/articles/cgrkd41n2v9o)<!-- HN:48793020:end --><!-- HN:48792984:start -->
* [48792984](https://news.social-protocols.org/stats?id=48792984) #13 5 points 4 comments -> [Common 3D Benchy Problems, Causes and Fixes](https://bambu3design.com/13-common-3d-benchy-problems-causes-fixes/)<!-- HN:48792984:end --><!-- HN:48792118:start -->
* [48792118](https://news.social-protocols.org/stats?id=48792118) #27 13 points 5 comments -> [Show HN: I trained a language model that thinks the capital of Japan is Paris](https://hamiltonianresearch.xyz/blog/hr-diffuse-1.html)<!-- HN:48792118:end --><!-- HN:48792352:start -->
* [48792352](https://news.social-protocols.org/stats?id=48792352) #21 26 points 5 comments -> [Apocketlypse](https://0dd.company/galleries/triumph/1.html)<!-- HN:48792352:end --><!-- HN:48793726:start -->
* [48793726](https://news.social-protocols.org/stats?id=48793726) #5 -> [Educators disciplined over Charlie Kirk posts are securing big payouts](https://www.nbcnews.com/news/us-news/educators-disciplined-charlie-kirk-posts-are-securing-big-payouts-rcna352568)<!-- HN:48793726:end --><!-- HN:48794281:start -->
* [48794281](https://news.social-protocols.org/stats?id=48794281) #12 5 points 4 comments -> [Hi, I am a 10 years old kid and made a Cool app](https://yf-profitable-strats.streamlit.app/)<!-- HN:48794281:end --><!-- HN:48794803:start -->
* [48794803](https://news.social-protocols.org/stats?id=48794803) #9 15 points 3 comments -> [Train and run transformers directly on Apple's Neural Engine](https://github.com/christopherkarani/Espresso)<!-- HN:48794803:end --><!-- HN:48793298:start -->
* [48793298](https://news.social-protocols.org/stats?id=48793298) #29 14 points 7 comments -> [Spain's cadastre API is SOAP from 2003, so I built a JSON wrapper (+MCP)](https://prediohq.com/)<!-- HN:48793298:end --><!-- HN:48794830:start -->
* [48794830](https://news.social-protocols.org/stats?id=48794830) #3 16 points 2 comments -> [Show your hands honor for the power they bring you](https://aresluna.org/show-your-hands-honor/)<!-- HN:48794830:end --><!-- HN:48792195:start -->
* [48792195](https://news.social-protocols.org/stats?id=48792195) #21 68 points 47 comments -> [Knowledge Should Not Be Gated](https://www.formaly.io/blog/knowledge-should-not-be-gated)<!-- HN:48792195:end --><!-- HN:48796099:start -->
* [48796099](https://news.social-protocols.org/stats?id=48796099) #5 11 points 0 comments -> [Longcat](https://longc.at/longcat.html)<!-- HN:48796099:end --><!-- HN:48796743:start -->
* [48796743](https://news.social-protocols.org/stats?id=48796743) #20 9 points 3 comments -> [Outfit makes you unrecognizable to cameras](https://jmagineuniverse.blogspot.com/p/fashion-against-machine-by-olivier-july_01930961321.html)<!-- HN:48796743:end --><!-- HN:48796334:start -->
* [48796334](https://news.social-protocols.org/stats?id=48796334) #13 5 points 2 comments -> [Australia probes mystery space balls that washed up on beach](https://www.bbc.com/news/articles/c1jyydr7jnjo)<!-- HN:48796334:end --><!-- HN:48795368:start -->
* [48795368](https://news.social-protocols.org/stats?id=48795368) #21 113 points 15 comments -> [Zuckerberg's Increasingly Bizarre War on Whistleblowers](https://pluralistic.net/2026/06/27/zuckerstreisand-2/#autodisparagement)<!-- HN:48795368:end --><!-- HN:48797824:start -->
* [48797824](https://news.social-protocols.org/stats?id=48797824) #30 9 points 2 comments -> [How to Dox Anyone](https://madattheinternet.substack.com/p/how-to-dox-anyone)<!-- HN:48797824:end --><!-- HN:48797878:start -->
* [48797878](https://news.social-protocols.org/stats?id=48797878) #22 11 points 3 comments -> [Y Combinator.singles](https://www.ycombinator.singles/)<!-- HN:48797878:end --><!-- HN:48798409:start -->
* [48798409](https://news.social-protocols.org/stats?id=48798409) #7 8 points 1 comments -> [AI Can Steal Your Bank Account in Hours](https://jmagineuniverse.blogspot.com/p/six-hours-to-infiltrate-bank-how-ai-is_0978359463.html)<!-- HN:48798409:end -->
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
* [48859781](https://news.social-protocols.org/stats?id=48859781) #4 15 points 3 comments -> [Offline tool to stabilize TV volume using IR control and spike detection](https://github.com/AdBusterOfficial/Adbuster--WinApp)<!-- HN:48859781:end --><!-- HN:48858997:start -->
* [48858997](https://news.social-protocols.org/stats?id=48858997) #27 38 points 40 comments -> [Ryanair Passenger Sucked Toward Broken Window After Midair Engine Failure](https://simpleflying.com/ryanair-thessaloniki-diversion-window-damage/)<!-- HN:48858997:end --><!-- HN:48862035:start -->
* [48862035](https://news.social-protocols.org/stats?id=48862035) #9 12 points 11 comments -> [Garnix Is Joining Shopify](https://garnix.io/blog/shutting-down/)<!-- HN:48862035:end --><!-- HN:48862510:start -->
* [48862510](https://news.social-protocols.org/stats?id=48862510) #18 6 points 1 comments -> [Chat Control 1.0 has been passed](https://gerarddupre.dev/en/blog/chat-control-1-passed/)<!-- HN:48862510:end --><!-- HN:48815278:start -->
* [48815278](https://news.social-protocols.org/stats?id=48815278) #21 6 points 4 comments -> [Let's Reinvent the Scroll Wheel](https://scrollpods.app/blog/lets-reinvent-the-scroll-wheel)<!-- HN:48815278:end --><!-- HN:48863064:start -->
* [48863064](https://news.social-protocols.org/stats?id=48863064) #21 21 points 41 comments -> [SpaceX wants to launch 100k more Starlink satellites – for 100x the bandwidth](https://www.zdnet.com/home-and-office/networking/spacex-wants-to-launch-100000-more-starlink-satellites/)<!-- HN:48863064:end --><!-- HN:48863022:start -->
* [48863022](https://news.social-protocols.org/stats?id=48863022) #19 6 points 6 comments -> [Bun vs. Deno vs. Node.js 2026: Real Benchmarks Mislead](https://byteiota.com/bun-vs-deno-vs-node-js-2026-real-benchmarks-mislead/)<!-- HN:48863022:end --><!-- HN:48862467:start -->
* [48862467](https://news.social-protocols.org/stats?id=48862467) #23 45 points 38 comments -> [Anyone else get a vague GitHub shakedown notice?](https://lists.osgeo.org/pipermail/qgis-developer/2026-July/068430.html)<!-- HN:48862467:end -->