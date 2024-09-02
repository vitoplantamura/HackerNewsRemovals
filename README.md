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

#### **Tuesday, August 27, 2024**
<!-- HN:41364114:start -->
* [41364114](https://news.social-protocols.org/stats?id=41364114) #3 9 points 8 comments -> [Show HN: I built a site that tracks short-lived flight deals](https://flight-price-alert.com/)<!-- HN:41364114:end --><!-- HN:41310822:start -->
* [41310822](https://news.social-protocols.org/stats?id=41310822) #23 62 points 11 comments -> [Compressing data with sample points and polynomial interpolation](https://www.johndcook.com/blog/2024/08/17/compression-and-interpolation/)<!-- HN:41310822:end --><!-- HN:41363637:start -->
* [41363637](https://news.social-protocols.org/stats?id=41363637) #22 25 points 17 comments -> [From 14 years old till 29, my experience with desktop Linux](https://blog.myli.page/from-14-years-old-till-29-my-experience-with-desktop-linux-b798d07bcd00)<!-- HN:41363637:end --><!-- HN:41364764:start -->
* [41364764](https://news.social-protocols.org/stats?id=41364764) #21 18 points 14 comments -> [Cellar Door: a quest to find the most beautiful word in English](https://www.cellar-door.co.uk/)<!-- HN:41364764:end --><!-- HN:41365972:start -->
* [41365972](https://news.social-protocols.org/stats?id=41365972) #22 5 points 0 comments -> [Keep Pavel Durov Locked Up](https://blog.thc.org/keep-pavel-durov-locked-up)<!-- HN:41365972:end --><!-- HN:41365598:start -->
* [41365598](https://news.social-protocols.org/stats?id=41365598) #28 53 points 25 comments -> [2023 state of the climate Entering uncharted territory](https://academic.oup.com/bioscience/article/73/12/841/7319571)<!-- HN:41365598:end --><!-- HN:41366628:start -->
* [41366628](https://news.social-protocols.org/stats?id=41366628) #28 13 points 5 comments -> [75% of founders in the Y Combinator S24 cohort are working on AI startups](https://sherwood.news/tech/three-quarters-of-founders-in-the-latest-y-combinator-cohort-are-working-on/)<!-- HN:41366628:end --><!-- HN:41366758:start -->
* [41366758](https://news.social-protocols.org/stats?id=41366758) #26 8 points 0 comments -> [Reasons not to be used by Facebook [2011-2019]](https://stallman.org/facebook.html)<!-- HN:41366758:end --><!-- HN:41366871:start -->
* [41366871](https://news.social-protocols.org/stats?id=41366871) #30 24 points 27 comments -> [Black Myth: Wukong Devs Told Streamers to Avoid Politics in Their Playthroughs](https://www.wired.com/story/black-myth-wukong-streaming-controversy/)<!-- HN:41366871:end --><!-- HN:41367126:start -->
* [41367126](https://news.social-protocols.org/stats?id=41367126) #28 3 points 1 comments -> [The Bewildering Politics of Telegram](https://www.politico.com/news/2024/08/26/telegram-app-politics-00176386)<!-- HN:41367126:end --><!-- HN:41367749:start -->
* [41367749](https://news.social-protocols.org/stats?id=41367749) #2 18 points 11 comments -> [The Real Exponential Curve for LLMs](https://fume.substack.com/p/inference-is-free-and-instant)<!-- HN:41367749:end --><!-- HN:41368677:start -->
* [41368677](https://news.social-protocols.org/stats?id=41368677) #22 10 points 6 comments -> [No smoking in your own home, California city orders residents](https://www.thetimes.com/world/us-world/article/carlsbad-california-smoking-illegal-where-houses-k9qrrvm05)<!-- HN:41368677:end --><!-- HN:41370147:start -->
* [41370147](https://news.social-protocols.org/stats?id=41370147) #24 -> [Show HN: I Built DollarAI.Store – A Collection of 350 AI Tools](https://app.dollarai.store)<!-- HN:41370147:end --><!-- HN:41374219:start -->
* [41374219](https://news.social-protocols.org/stats?id=41374219) #4 7 points 2 comments -> [Is iMessage really an encrypted messaging app? (2021)](https://warnerchad.medium.com/is-apple-imessage-end-to-end-encrypted-it-depends-8bcdcbd8c89b)<!-- HN:41374219:end -->
#### **Wednesday, August 28, 2024**
<!-- HN:41374276:start -->
* [41374276](https://news.social-protocols.org/stats?id=41374276) #27 34 points 40 comments -> [After a decade of free Alexa, Amazon now wants you to pay](https://www.washingtonpost.com/technology/2024/08/27/amazon-ai-alexa-new-subscription/)<!-- HN:41374276:end --><!-- HN:41375219:start -->
* [41375219](https://news.social-protocols.org/stats?id=41375219) #6 8 points 9 comments -> [Obsolete Command-Line Tools of Linux](https://linuxexpert.org/obsolete-command-line-tools-of-linux/)<!-- HN:41375219:end --><!-- HN:41326461:start -->
* [41326461](https://news.social-protocols.org/stats?id=41326461) #16 26 points 3 comments -> [Slime mold simulation in Rust using WASM and WebGPU](https://github.com/plul/slime-mold-simulation)<!-- HN:41326461:end --><!-- HN:41376990:start -->
* [41376990](https://news.social-protocols.org/stats?id=41376990) #21 8 points 3 comments -> [LinkedIn_AIHawk: AI job assistant. Automate applications and Resume Generation](https://github.com/feder-cr/linkedIn_auto_jobs_applier_with_AI)<!-- HN:41376990:end --><!-- HN:41377058:start -->
* [41377058](https://news.social-protocols.org/stats?id=41377058) #19 14 points 1 comments -> ['Order from Amazon': How tech giants are storing mass data for Israel's war](https://www.972mag.com/cloud-israeli-army-gaza-amazon-google-microsoft/)<!-- HN:41377058:end --><!-- HN:41374849:start -->
* [41374849](https://news.social-protocols.org/stats?id=41374849) #29 -> [Cerebras Launches the Fastest AI Inference](https://cerebras.ai/press-release/cerebras-launches-the-worlds-fastest-ai-inference)<!-- HN:41374849:end --><!-- HN:41377924:start -->
* [41377924](https://news.social-protocols.org/stats?id=41377924) #25 10 points 4 comments -> [Why Htmx is far superior to React and NextJS](https://henriqueleite42.com/why-htmx-is-far-superior-to-react-and-nextjs)<!-- HN:41377924:end --><!-- HN:41380031:start -->
* [41380031](https://news.social-protocols.org/stats?id=41380031) #23 11 points 41 comments -> [Unrealized Gain Tax–A Coming Sea Change in FY2025 Budget Proposal?](https://www.forbes.com/sites/andrewleahey/2024/04/30/unrealized-gain-tax-a-coming-sea-change-in-fy2025-budget-proposal/)<!-- HN:41380031:end --><!-- HN:41380977:start -->
* [41380977](https://news.social-protocols.org/stats?id=41380977) #2 6 points 2 comments -> [Is marriage associated with happiness for men or for women? Or both? Or neither?](https://statmodeling.stat.columbia.edu/2024/08/27/marriage-happiness/)<!-- HN:41380977:end --><!-- HN:41381816:start -->
* [41381816](https://news.social-protocols.org/stats?id=41381816) #16 8 points 5 comments -> [Man Is First to Be Charged in New York with Wearing a Mask in Public](https://www.nytimes.com/2024/08/27/nyregion/face-mask-ban-charges-nyc.html)<!-- HN:41381816:end --><!-- HN:41381487:start -->
* [41381487](https://news.social-protocols.org/stats?id=41381487) #5 5 points 1 comments -> [Fly.io (Still) Consistently Unreliable](https://community.fly.io/t/reliability-its-not-great/11253)<!-- HN:41381487:end --><!-- HN:41381994:start -->
* [41381994](https://news.social-protocols.org/stats?id=41381994) #1 32 points 9 comments -> [UAE Freezes $20B Jet Deal with France After Telegram CEO Arrest](https://thedailyguardian.com/uae-freezes-20-billion-jet-deal-with-france-after-telegram-ceo-arrest/)<!-- HN:41381994:end --><!-- HN:41383244:start -->
* [41383244](https://news.social-protocols.org/stats?id=41383244) #16 28 points 40 comments -> [I Hate the Term "Modern"](https://www.paritybit.ca/blog/why-i-hate-the-term-modern/)<!-- HN:41383244:end --><!-- HN:41385154:start -->
* [41385154](https://news.social-protocols.org/stats?id=41385154) #13 8 points 0 comments -> [Silicon Valley's Online Ideologues Are in Model Collapse](https://www.reimaginingliberty.com/silicon-valleys-very-online-ideologues-are-in-model-collapse/)<!-- HN:41385154:end -->
#### **Thursday, August 29, 2024**
<!-- HN:41385637:start -->
* [41385637](https://news.social-protocols.org/stats?id=41385637) #1 116 points 3 comments -> [Judge dismisses majority of GitHub Copilot copyright claims](https://lwn.net/Articles/987524/)<!-- HN:41385637:end --><!-- HN:41327394:start -->
* [41327394](https://news.social-protocols.org/stats?id=41327394) #9 316 points 104 comments -> [The journey of an internet packet: Exploring networks with traceroute](https://sebastianmarines.com/post/journey-of-a-packet-exploring-networks-with-traceroute/)<!-- HN:41327394:end --><!-- HN:41337268:start -->
* [41337268](https://news.social-protocols.org/stats?id=41337268) #15 161 points 92 comments -> ["Everything" is a filename search engine for Windows](https://www.voidtools.com/en-us/support/everything/)<!-- HN:41337268:end --><!-- HN:41357188:start -->
* [41357188](https://news.social-protocols.org/stats?id=41357188) #15 5 points 1 comments -> [An SSR Performance Showdown](https://blog.platformatic.dev/an-ssr-performance-showdown)<!-- HN:41357188:end --><!-- HN:41386848:start -->
* [41386848](https://news.social-protocols.org/stats?id=41386848) #6 9 points 35 comments -> [Show HN: Are You Smarter Than a 5th Grader?](https://areusmarterthanafifthgrader.com)<!-- HN:41386848:end --><!-- HN:41388557:start -->
* [41388557](https://news.social-protocols.org/stats?id=41388557) #30 14 points 6 comments -> [Show HN: A directory to find open source AI projects easier](https://www.aiexh.com/en)<!-- HN:41388557:end --><!-- HN:41389787:start -->
* [41389787](https://news.social-protocols.org/stats?id=41389787) #11 6 points 0 comments -> [OpenTofu is not so open](https://github.com/opentofu/registry/pull/824)<!-- HN:41389787:end --><!-- HN:41393462:start -->
* [41393462](https://news.social-protocols.org/stats?id=41393462) #22 22 points 6 comments -> [Rust Is Bad for Servers](https://kerkour.com/rust-is-bad-for-servers)<!-- HN:41393462:end --><!-- HN:41344245:start -->
* [41344245](https://news.social-protocols.org/stats?id=41344245) #16 132 points 50 comments -> [All Texts in Brooklyn](https://brooklyn.alltexts.nyc/)<!-- HN:41344245:end --><!-- HN:41342078:start -->
* [41342078](https://news.social-protocols.org/stats?id=41342078) #22 62 points 16 comments -> [Shufflecake: Plausible deniability for hidden filesystems on Linux (2023)](https://eprint.iacr.org/2023/1529)<!-- HN:41342078:end -->
#### **Friday, August 30, 2024**
<!-- HN:41349554:start -->
* [41349554](https://news.social-protocols.org/stats?id=41349554) #12 43 points 4 comments -> [Build an Infinite Canvas](https://infinitecanvas.cc/)<!-- HN:41349554:end --><!-- HN:41348869:start -->
* [41348869](https://news.social-protocols.org/stats?id=41348869) #19 5 points 0 comments -> [Colorful Ribbon Diagrams Became the Face of Proteins](https://www.quantamagazine.org/how-colorful-ribbon-diagrams-became-the-face-of-proteins-20240823/)<!-- HN:41348869:end --><!-- HN:41398480:start -->
* [41398480](https://news.social-protocols.org/stats?id=41398480) #6 5 points 1 comments -> [Grandma trapped in elevator for six days survived by rationing groceries](https://www.guinnessworldrecords.com/news/2024/1/grandma-trapped-in-elevator-for-six-days-survived-by-rationing-groceries-763381)<!-- HN:41398480:end --><!-- HN:41399249:start -->
* [41399249](https://news.social-protocols.org/stats?id=41399249) #13 7 points 8 comments -> [Bay Watch: Northern California is an energy catastrophe waiting to happen](https://newsletter.doomberg.com/p/bay-watch)<!-- HN:41399249:end --><!-- HN:41400570:start -->
* [41400570](https://news.social-protocols.org/stats?id=41400570) #21 5 points 0 comments -> [Web Kid Anand is a typical high schooler–except for his megahot site. (1999)](https://money.cnn.com/magazines/fsb/fsb_archive/1999/12/01/271048/index.htm)<!-- HN:41400570:end --><!-- HN:41400523:start -->
* [41400523](https://news.social-protocols.org/stats?id=41400523) #29 5 points 1 comments -> [AI cameras spot toddlers not wearing seat belts](https://www.bbc.com/news/articles/c5y3pdp099zo)<!-- HN:41400523:end --><!-- HN:41395921:start -->
* [41395921](https://news.social-protocols.org/stats?id=41395921) #27 262 points 71 comments -> [Anthropic's Prompt Engineering Interactive Tutorial](https://github.com/anthropics/courses/tree/master/prompt_engineering_interactive_tutorial)<!-- HN:41395921:end --><!-- HN:41400152:start -->
* [41400152](https://news.social-protocols.org/stats?id=41400152) #17 4 points 0 comments -> [Understanding the Postgres Hackers Mailing List](https://www.crunchydata.com/blog/understanding-the-postgres-hackers-mailing-list)<!-- HN:41400152:end --><!-- HN:41396710:start -->
* [41396710](https://news.social-protocols.org/stats?id=41396710) #16 10 points 1 comments -> [Sail and Muddy: A Retrospective](https://feelmuddy.notion.site/Sail-Muddy-A-Retrospective-388a528951de4da58e66940c5fb85b8a)<!-- HN:41396710:end --><!-- HN:41403466:start -->
* [41403466](https://news.social-protocols.org/stats?id=41403466) #19 19 points 16 comments -> [Show HN: I made a site that lets everyone edit the same gradient in real-time](https://internetgradient.com)<!-- HN:41403466:end --><!-- HN:41404897:start -->
* [41404897](https://news.social-protocols.org/stats?id=41404897) #5 17 points 6 comments -> [John Rawls and the Death of Western Marxism](https://josephheath.substack.com/p/john-rawls-and-the-death-of-western)<!-- HN:41404897:end -->
#### **Saturday, August 31, 2024**
<!-- HN:41358432:start -->
* [41358432](https://news.social-protocols.org/stats?id=41358432) #2 27 points 7 comments -> [Dinosaur Footprints on Either Side of the Atlantic Are Matching Sets](https://gizmodo.com/dinosaur-footprints-on-either-side-of-the-atlantic-are-matching-sets-2000490979)<!-- HN:41358432:end --><!-- HN:41357409:start -->
* [41357409](https://news.social-protocols.org/stats?id=41357409) #8 189 points 43 comments -> [Emacs-like editor written in Common Lisp](https://lem-project.github.io/#)<!-- HN:41357409:end --><!-- HN:41353830:start -->
* [41353830](https://news.social-protocols.org/stats?id=41353830) #10 17 points 0 comments -> [Libntruprime is a microlibrary for the Streamlined NTRU Prime cryptosyst](https://libntruprime.cr.yp.to/)<!-- HN:41353830:end --><!-- HN:41358333:start -->
* [41358333](https://news.social-protocols.org/stats?id=41358333) #19 3 points 1 comments -> [Synthetic Open Schema: code-first approach to Synthetic Monitoring](https://github.com/checksdev/synthetic-open-schema)<!-- HN:41358333:end --><!-- HN:41356775:start -->
* [41356775](https://news.social-protocols.org/stats?id=41356775) #24 128 points 97 comments -> [Pie doesn't need to be original unless you claim it so](https://buttondown.com/geoffreylitt/archive/your-pie-doesnt-need-to-be-original-unless-you/)<!-- HN:41356775:end --><!-- HN:41357123:start -->
* [41357123](https://news.social-protocols.org/stats?id=41357123) #25 115 points 51 comments -> [Leader Election with S3 Conditional Writes](https://www.morling.dev/blog/leader-election-with-s3-conditional-writes/)<!-- HN:41357123:end --><!-- HN:41352008:start -->
* [41352008](https://news.social-protocols.org/stats?id=41352008) #28 23 points 2 comments -> [Real-world uplift modelling with significance-based uplift trees [pdf]](https://www.stochasticsolutions.com/pdf/sig-based-up-trees.pdf)<!-- HN:41352008:end --><!-- HN:41377097:start -->
* [41377097](https://news.social-protocols.org/stats?id=41377097) #18 46 points 28 comments -> [How to Use React Compiler](https://www.freecodecamp.org/news/react-compiler-complete-guide-react-19/)<!-- HN:41377097:end --><!-- HN:41406502:start -->
* [41406502](https://news.social-protocols.org/stats?id=41406502) #24 19 points 0 comments -> [You've only added two lines – why did that take two days](https://www.mrlacey.com/2020/07/youve-only-added-two-lines-why-did-that.html)<!-- HN:41406502:end --><!-- HN:41408173:start -->
* [41408173](https://news.social-protocols.org/stats?id=41408173) #12 14 points 40 comments -> [Why A.I. Isn't Going to Make Art](https://www.newyorker.com/culture/the-weekend-essay/why-ai-isnt-going-to-make-art)<!-- HN:41408173:end --><!-- HN:41408792:start -->
* [41408792](https://news.social-protocols.org/stats?id=41408792) #24 6 points 0 comments -> [When the Mismanagerial Class Destroys Great Companies](https://www.palladiummag.com/2024/08/30/when-the-mismanagerial-class-destroys-great-companies/)<!-- HN:41408792:end --><!-- HN:41408464:start -->
* [41408464](https://news.social-protocols.org/stats?id=41408464) #29 5 points 0 comments -> [The California Supreme Court Should Help Protect Your Stored Communications](https://www.eff.org/deeplinks/2024/08/california-supreme-court-should-help-protect-your-stored-communications)<!-- HN:41408464:end --><!-- HN:41377328:start -->
* [41377328](https://news.social-protocols.org/stats?id=41377328) #20 29 points 1 comments -> [Bundling Information Goods: Pricing, Profits, and Efficiency (1999)](https://www.jstor.org/stable/2634781)<!-- HN:41377328:end --><!-- HN:41410344:start -->
* [41410344](https://news.social-protocols.org/stats?id=41410344) #3 6 points 0 comments -> [What the f* is e/acc (2022)](https://effectiveaccelerationism.substack.com/p/what-the-f-is-eacc)<!-- HN:41410344:end --><!-- HN:41409144:start -->
* [41409144](https://news.social-protocols.org/stats?id=41409144) #16 5 points 1 comments -> [We can have democracy or we can have Facebook, but we can't have both (2020)](https://the.ink/p/we-can-have-democracy-or-we-can-have)<!-- HN:41409144:end --><!-- HN:41410450:start -->
* [41410450](https://news.social-protocols.org/stats?id=41410450) #17 206 points 198 comments -> [Nearly half of Nvidia's revenue comes from four mystery whales each buying $3B+](https://fortune.com/2024/08/29/nvidia-jensen-huang-ai-customers/)<!-- HN:41410450:end --><!-- HN:41411635:start -->
* [41411635](https://news.social-protocols.org/stats?id=41411635) #20 22 points 3 comments -> [Federal Appeals Court Once Again Rejects Blanket Gun Ban for Cannabis Consumers](https://norml.org/blog/2024/08/29/federal-appeals-court-once-again-rejects-blanket-gun-ban-for-cannabis-consumers/)<!-- HN:41411635:end --><!-- HN:41411147:start -->
* [41411147](https://news.social-protocols.org/stats?id=41411147) #26 32 points 31 comments -> [Las Vegas police could boycott working NFL games over new facial ID policy](https://www.reviewjournal.com/local/local-las-vegas/nfl-facial-recognition-policy-upsets-las-vegas-police-union-3128202/)<!-- HN:41411147:end --><!-- HN:41377073:start -->
* [41377073](https://news.social-protocols.org/stats?id=41377073) #26 -> [Karpathy on Software 2.0 (2017)](https://karpathy.medium.com/software-2-0-a64152b37c35)<!-- HN:41377073:end --><!-- HN:41411504:start -->
* [41411504](https://news.social-protocols.org/stats?id=41411504) #24 4 points 0 comments -> [Hillbilly Lament](https://andrewpwheeler.com/2024/08/26/hillbilly-lament/)<!-- HN:41411504:end --><!-- HN:41411339:start -->
* [41411339](https://news.social-protocols.org/stats?id=41411339) #9 34 points 40 comments -> [Signals for Tailwind CSS (styling based on ancestor state via style queries)](https://github.com/brandonmcconnell/tailwindcss-signals)<!-- HN:41411339:end -->
#### **Sunday, September 1, 2024**
<!-- HN:41412129:start -->
* [41412129](https://news.social-protocols.org/stats?id=41412129) #17 6 points 2 comments -> [California Is Now Hitting Farmers Up to $10K Fines per Day](https://franknez.com/california-is-now-hitting-farmers-up-to-10k-fines-per-day/)<!-- HN:41412129:end --><!-- HN:41412356:start -->
* [41412356](https://news.social-protocols.org/stats?id=41412356) #17 7 points 3 comments -> [Why So Many People Are Going "No Contact" with Their Parents](https://www.newyorker.com/culture/annals-of-inquiry/why-so-many-people-are-going-no-contact-with-their-parents)<!-- HN:41412356:end --><!-- HN:41366614:start -->
* [41366614](https://news.social-protocols.org/stats?id=41366614) #4 52 points 17 comments -> [My first experience with Gleam Language](https://pliutau.com/my-first-experience-with-gleam-lang/)<!-- HN:41366614:end --><!-- HN:41368657:start -->
* [41368657](https://news.social-protocols.org/stats?id=41368657) #8 91 points 8 comments -> [Compilation of JavaScript to WASM, Part 2: Ahead-of-Time vs. JIT](https://cfallin.org/blog/2024/08/27/aot-js/)<!-- HN:41368657:end --><!-- HN:41369065:start -->
* [41369065](https://news.social-protocols.org/stats?id=41369065) #23 139 points 37 comments -> [Building Bubbletea Programs](https://leg100.github.io/en/posts/building-bubbletea-programs/)<!-- HN:41369065:end --><!-- HN:41413687:start -->
* [41413687](https://news.social-protocols.org/stats?id=41413687) #30 39 points 23 comments -> [Oprah will screw up the AI story](https://www.anildash.com//2024/08/31/oprah-wrong-ai/)<!-- HN:41413687:end --><!-- HN:41415063:start -->
* [41415063](https://news.social-protocols.org/stats?id=41415063) #24 4 points 3 comments -> [Artificial intelligence comes to male sex toys](https://english.elpais.com/lifestyle/2024-09-01/this-is-not-your-normal-masturbation-artificial-intelligence-comes-to-male-sex-toys.html)<!-- HN:41415063:end --><!-- HN:41415441:start -->
* [41415441](https://news.social-protocols.org/stats?id=41415441) #20 3 points 0 comments -> [Shame and Narcissistic Rage in Autogynephilic Transsexualism](https://annelawrence.com/wp-content/uploads/2023/11/Lawrence-2008-shame-and-narcissistic-rage.pdf)<!-- HN:41415441:end --><!-- HN:41414455:start -->
* [41414455](https://news.social-protocols.org/stats?id=41414455) #23 28 points 40 comments -> [AI is growing faster than companies can secure it, warn industry leaders](https://venturebeat.com/ai/ai-is-growing-faster-than-companies-can-secure-it-warn-industry-leaders/)<!-- HN:41414455:end --><!-- HN:41416855:start -->
* [41416855](https://news.social-protocols.org/stats?id=41416855) #29 3 points 1 comments -> [Huck Finn – One of the Greatest Anti-Racist Books Ever Written](https://medium.com/luminasticity/huck-finn-one-of-the-greatest-anti-racist-books-ever-written-db3f922dea44)<!-- HN:41416855:end --><!-- HN:41379751:start -->
* [41379751](https://news.social-protocols.org/stats?id=41379751) #18 52 points 12 comments -> [The Atari 7800](https://www.goto10retro.com/p/inside-the-atari-7800)<!-- HN:41379751:end --><!-- HN:41415468:start -->
* [41415468](https://news.social-protocols.org/stats?id=41415468) #17 74 points 34 comments -> [Take a closer look at Starbucks CEO's contract, which covers his commute by jet](https://www.abc.net.au/news/2024-09-01/starbucks-ceo-brian-niccol-contract-explained/104270064)<!-- HN:41415468:end --><!-- HN:41415363:start -->
* [41415363](https://news.social-protocols.org/stats?id=41415363) #20 50 points 13 comments -> [The papers that most heavily cite retracted studies](https://www.nature.com/articles/d41586-024-02719-5)<!-- HN:41415363:end --><!-- HN:41417368:start -->
* [41417368](https://news.social-protocols.org/stats?id=41417368) #5 10 points 0 comments -> [What 100 Years of Research Says about Ability Grouping and Acceleration [pdf]](http://www.k12accountability.org/resources/Gifted-Education/GT_Review_of_Ed_Research_Meta_Analysis.pdf)<!-- HN:41417368:end --><!-- HN:41417657:start -->
* [41417657](https://news.social-protocols.org/stats?id=41417657) #11 12 points 4 comments -> [Amazon and Bezos fund's influence over carbon credit market raises alarm](https://www.ft.com/content/388b190d-49b0-4997-af18-1049e911f0b7)<!-- HN:41417657:end -->
#### **Monday, September 2, 2024**<!-- HN:41396279:start -->
* [41396279](https://news.social-protocols.org/stats?id=41396279) #14 19 points 6 comments -> [The Imperial Origins of Big Data](https://yalebooks.yale.edu/2024/08/28/the-imperial-origins-of-big-data/)<!-- HN:41396279:end --><!-- HN:41423518:start -->
* [41423518](https://news.social-protocols.org/stats?id=41423518) #16 26 points 40 comments -> [Starlink Defies Order to Block X in Brazil](https://www.nytimes.com/2024/09/01/world/americas/elon-musk-brazil-starlink-x.html)<!-- HN:41423518:end --><!-- HN:41424016:start -->
* [41424016](https://news.social-protocols.org/stats?id=41424016) #25 58 points 31 comments -> [In Leak, Facebook Partner Brags About Listening to Your Phone's Microphone to S](https://futurism.com/the-byte/facebook-partner-phones-listening-microphone)<!-- HN:41424016:end --><!-- HN:41424359:start -->
* [41424359](https://news.social-protocols.org/stats?id=41424359) #20 6 points 0 comments -> [Court Denies Cheat Seller AimJunkies a New Trial, Affirms Bungie's $4.3M Win](https://torrentfreak.com/court-denies-cheat-seller-aimjunkies-a-new-trial-affirms-bungies-4-3-million-win-240902/)<!-- HN:41424359:end --><!-- HN:41424608:start -->
* [41424608](https://news.social-protocols.org/stats?id=41424608) #12 16 points 1 comments -> [Rust Maintainer for Linux Kernel Resigns](https://ostechnix.com/rust-maintainer-for-linux-kernel-resigns/)<!-- HN:41424608:end --><!-- HN:41387613:start -->
* [41387613](https://news.social-protocols.org/stats?id=41387613) #19 37 points 14 comments -> [Why Medieval Women Sometimes Fought in Bloody Trials by Combat](https://www.atlasobscura.com/articles/trial-by-combat-man-woman)<!-- HN:41387613:end --><!-- HN:41425028:start -->
* [41425028](https://news.social-protocols.org/stats?id=41425028) #29 42 points 19 comments -> [Brazil to Fine Anyone Using a VPN to Access X $8,874 per Day; Elon Musk Responds](https://www.complex.com/pop-culture/a/treyalston/brazil-x-elon-musk-fine)<!-- HN:41425028:end --><!-- HN:41425093:start -->
* [41425093](https://news.social-protocols.org/stats?id=41425093) #21 25 points 21 comments -> [How CrowdStrike Stopped Everything](https://cacm.acm.org/news/how-crowdstrike-stopped-everything/)<!-- HN:41425093:end --><!-- HN:41425857:start -->
* [41425857](https://news.social-protocols.org/stats?id=41425857) #24 5 points 0 comments -> [The Largest Wetland Is Burning, and Rare Animals Are Dying](https://www.nytimes.com/2024/08/27/world/americas/pantanal-wildfires-wildlife.html)<!-- HN:41425857:end --><!-- HN:41425808:start -->
* [41425808](https://news.social-protocols.org/stats?id=41425808) #24 4 points 2 comments -> [Revolution: Google Password Manager Syncs Passkeys to Apple and Windows Devices](https://www.corbado.com/blog/google-passkeys-sync-windows-macos)<!-- HN:41425808:end --><!-- HN:41425307:start -->
* [41425307](https://news.social-protocols.org/stats?id=41425307) #21 16 points 2 comments -> [He Emptied an Entire Crypto Exchange onto a Thumb Drive. Then He Disappeared](https://www.wired.com/story/faruk-ozer-turkey-crypto-fraud/)<!-- HN:41425307:end --><!-- HN:41426904:start -->
* [41426904](https://news.social-protocols.org/stats?id=41426904) #17 10 points 0 comments -> [Congress Should Make Universities Pay for Handing Out Useless Degrees](https://thefederalist.com/2024/09/02/congress-should-make-universities-pay-for-handing-out-useless-degrees/)<!-- HN:41426904:end -->