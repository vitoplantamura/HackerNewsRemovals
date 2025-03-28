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

#### **Saturday, March 22, 2025**<!-- HN:43409533:start -->
* [43409533](https://news.social-protocols.org/stats?id=43409533) #23 29 points 41 comments -> [Rocky Linux from CIQ – Hardened](https://ciq.com/products/rocky-linux/hardened/)<!-- HN:43409533:end --><!-- HN:43443280:start -->
* [43443280](https://news.social-protocols.org/stats?id=43443280) #12 5 points 2 comments -> [Show HN: Font Pair – I was wasting hours choosing fonts, so I built this](https://github.com/CodeWithNeer/FontPair)<!-- HN:43443280:end --><!-- HN:43443979:start -->
* [43443979](https://news.social-protocols.org/stats?id=43443979) #8 11 points 0 comments -> [Vibe Coding – The Ultimate Guide with Resources](https://natural20.com/vibe-coding/)<!-- HN:43443979:end --><!-- HN:43444098:start -->
* [43444098](https://news.social-protocols.org/stats?id=43444098) #29 4 points 0 comments -> [Number of border searches of electronic devices increasing every year](https://www.eff.org/issues/border-searches)<!-- HN:43444098:end --><!-- HN:43444191:start -->
* [43444191](https://news.social-protocols.org/stats?id=43444191) #7 9 points 1 comments -> [VibeSail: A case study in vibe coding a game](https://www.vibecoding.games/vibesail-a-case-study-in-vibe-coding-a-game/)<!-- HN:43444191:end --><!-- HN:43444337:start -->
* [43444337](https://news.social-protocols.org/stats?id=43444337) #24 24 points 9 comments -> [Zen browser had a backdoor enabled by default](https://github.com/zen-browser/desktop/issues/5947)<!-- HN:43444337:end --><!-- HN:43444605:start -->
* [43444605](https://news.social-protocols.org/stats?id=43444605) #10 27 points 40 comments -> [MacBooks account for 86% of total Mac sales; Mac desktops just 14%](https://macdailynews.com/2025/03/19/macbooks-account-for-86-of-total-mac-sales-mac-desktops-just-14/)<!-- HN:43444605:end --><!-- HN:43443974:start -->
* [43443974](https://news.social-protocols.org/stats?id=43443974) #17 33 points 22 comments -> [The future of AI is Ruby on Rails](https://www.seangoedecke.com/ai-and-ruby/#fnref-1)<!-- HN:43443974:end --><!-- HN:43443823:start -->
* [43443823](https://news.social-protocols.org/stats?id=43443823) #17 31 points 5 comments -> [Don't compete](https://invertedpassion.com/dont-compete/)<!-- HN:43443823:end --><!-- HN:43444017:start -->
* [43444017](https://news.social-protocols.org/stats?id=43444017) #21 30 points 1 comments -> [Concise Machine Learning [pdf]](https://people.eecs.berkeley.edu/~jrs/papers/machlearn.pdf)<!-- HN:43444017:end --><!-- HN:43445179:start -->
* [43445179](https://news.social-protocols.org/stats?id=43445179) #17 3 points 0 comments -> [Targeting Brain's Drainage Pathways Rejuvenates Memory](https://neurosciencenews.com/lymphatic-system-aging-memory-28507/)<!-- HN:43445179:end --><!-- HN:43446225:start -->
* [43446225](https://news.social-protocols.org/stats?id=43446225) #22 3 points 0 comments -> [Krazam: Microservices [video]](https://www.youtube.com/watch?v=y8OnoxKotPQ)<!-- HN:43446225:end --><!-- HN:43446544:start -->
* [43446544](https://news.social-protocols.org/stats?id=43446544) #9 7 points 4 comments -> [The Ugly Truth About the Education System You Were Never Told](https://www.thesouljam.com/posts/the-ugly-truth-about-the-education-system-you-were-never-told)<!-- HN:43446544:end --><!-- HN:43447308:start -->
* [43447308](https://news.social-protocols.org/stats?id=43447308) #24 11 points 1 comments -> [NYU Website Hacked](https://web.archive.org/web/20250322133330/https://www.nyu.edu/)<!-- HN:43447308:end --><!-- HN:43448528:start -->
* [43448528](https://news.social-protocols.org/stats?id=43448528) #12 11 points 1 comments -> [You Shouldn't Use Next.js](https://www.epicweb.dev/why-i-wont-use-nextjs)<!-- HN:43448528:end -->
#### **Sunday, March 23, 2025**
<!-- HN:43449973:start -->
* [43449973](https://news.social-protocols.org/stats?id=43449973) #3 6 points 1 comments -> [Hetzner is forwarding other people's traffic to you](https://kiwi.fuo.fi/notes/a5oh5qt4ra5o000v)<!-- HN:43449973:end --><!-- HN:43449889:start -->
* [43449889](https://news.social-protocols.org/stats?id=43449889) #1 28 points 6 comments -> [YC alum LunaJoy got $6.6M, offers job below minimum wage](https://www.workatastartup.com/jobs/72101)<!-- HN:43449889:end --><!-- HN:43448322:start -->
* [43448322](https://news.social-protocols.org/stats?id=43448322) #16 42 points 14 comments -> [Meta pirated at least 101 of my books, and others](https://garymarcus.substack.com/p/meta-pirated-at-least-101-of-my-books)<!-- HN:43448322:end --><!-- HN:43451695:start -->
* [43451695](https://news.social-protocols.org/stats?id=43451695) #18 4 points 0 comments -> [1k True Fans (2008)](https://kk.org/thetechnium/1000-true-fans/)<!-- HN:43451695:end --><!-- HN:43448193:start -->
* [43448193](https://news.social-protocols.org/stats?id=43448193) #12 118 points 39 comments -> [Mathematical Methods for Physics [pdf]](https://www.ma.imperial.ac.uk/~dturaev/Mathematical_Methods2021.pdf)<!-- HN:43448193:end --><!-- HN:43445614:start -->
* [43445614](https://news.social-protocols.org/stats?id=43445614) #14 143 points 7 comments -> [Differential Geometry: A First Course in Curves and Surfaces [pdf]](https://math.franklin.uga.edu/sites/default/files/users/user317/ShifrinDiffGeo.pdf)<!-- HN:43445614:end --><!-- HN:43451439:start -->
* [43451439](https://news.social-protocols.org/stats?id=43451439) #28 19 points 2 comments -> [ThePrimeagen: Programming, AI, ADHD, Productivity, Addiction, and God](https://www.youtube.com/watch?v=tNZnLkRBYA8)<!-- HN:43451439:end --><!-- HN:43451159:start -->
* [43451159](https://news.social-protocols.org/stats?id=43451159) #18 14 points 0 comments -> [Carl Linnaeus's note-taking innovations](https://jillianhess.substack.com/p/carl-linnaeuss-note-taking-innovations)<!-- HN:43451159:end --><!-- HN:43446174:start -->
* [43446174](https://news.social-protocols.org/stats?id=43446174) #7 9 points 1 comments -> [Neanderthals may have eaten maggots as part of their diet](https://www.science.org/content/article/neanderthals-may-have-eaten-maggots-part-their-diet)<!-- HN:43446174:end --><!-- HN:43452431:start -->
* [43452431](https://news.social-protocols.org/stats?id=43452431) #10 9 points 1 comments -> [Hardware-Aware Coding: CPU Architecture Concepts Every Developer Should Know](https://blog.codingconfessions.com/p/hardware-aware-coding)<!-- HN:43452431:end --><!-- HN:43452177:start -->
* [43452177](https://news.social-protocols.org/stats?id=43452177) #12 5 points 1 comments -> [Show HN: NPM-Audit-to-Report](https://github.com/egorsmkv/npm-audit-to-report)<!-- HN:43452177:end --><!-- HN:43454841:start -->
* [43454841](https://news.social-protocols.org/stats?id=43454841) #26 4 points 0 comments -> [All the terrifying signs World War III is already playing out in the shadows](https://www.dailymail.co.uk/news/article-14516439/world-war-3-playing-shadows-russia-ukraine-trump.html)<!-- HN:43454841:end --><!-- HN:43454341:start -->
* [43454341](https://news.social-protocols.org/stats?id=43454341) #18 15 points 2 comments -> [Ttyd – Share your terminal over the web](https://github.com/tsl0922/ttyd)<!-- HN:43454341:end --><!-- HN:43454136:start -->
* [43454136](https://news.social-protocols.org/stats?id=43454136) #20 7 points 0 comments -> [Tied Crosscoders: Tracing How Chat LLM Behavior Emerges from Base Model](https://www.lesswrong.com/posts/3T8eKyaPvDDm2wzor/research-question)<!-- HN:43454136:end --><!-- HN:43455011:start -->
* [43455011](https://news.social-protocols.org/stats?id=43455011) #9 5 points 0 comments -> [Donate USB Drives and SD Cards to Help US Smuggle Outside Info into North Korea](https://flashdrivesforfreedom.org)<!-- HN:43455011:end --><!-- HN:43456355:start -->
* [43456355](https://news.social-protocols.org/stats?id=43456355) #3 10 points 1 comments -> [Sharing My USPS Mail Alerts Apps Script](https://taslim.xyz/blog/2025/sharing-my-usps-mail-alerts-apps-script/)<!-- HN:43456355:end -->
#### **Monday, March 24, 2025**
<!-- HN:43457428:start -->
* [43457428](https://news.social-protocols.org/stats?id=43457428) #21 5 points 0 comments -> ["The bargain we are being asked to ratify" – AI as technological bribery](https://librarianshipwreck.wordpress.com/2025/03/02/the-bargain-we-are-being-asked-to-ratify-ai-as-technological-bribery/)<!-- HN:43457428:end --><!-- HN:43458359:start -->
* [43458359](https://news.social-protocols.org/stats?id=43458359) #1 6 points 0 comments -> [Show HN: I build a Free and Open-source tool for Macs:)](https://github.com/caioricciuti/cr-mac-helper)<!-- HN:43458359:end --><!-- HN:43458633:start -->
* [43458633](https://news.social-protocols.org/stats?id=43458633) #26 23 points 13 comments -> [Rust Additions for GCC 15 Bring Support for If-Let Statements](https://www.phoronix.com/news/GCC-15-Rust-if-let)<!-- HN:43458633:end --><!-- HN:43458758:start -->
* [43458758](https://news.social-protocols.org/stats?id=43458758) #18 63 points 21 comments -> [Tesla sales drop 35% in San Diego County](https://fox5sandiego.com/news/business/tesla-sales-drop-35-in-san-diego-county/)<!-- HN:43458758:end --><!-- HN:43459859:start -->
* [43459859](https://news.social-protocols.org/stats?id=43459859) #29 5 points 0 comments -> [Met Police gets first permanent facial recognition cameras in London](https://www.lbc.co.uk/crime/facial-recognition-camera-london-permanent-met-police/)<!-- HN:43459859:end --><!-- HN:43427595:start -->
* [43427595](https://news.social-protocols.org/stats?id=43427595) #16 26 points 4 comments -> [Taming Servers for Fun and Profit](https://blog.railway.com/p/data-center-build-part-two)<!-- HN:43427595:end --><!-- HN:43459990:start -->
* [43459990](https://news.social-protocols.org/stats?id=43459990) #7 25 points 40 comments -> [The Tranhumanist Cult Test](https://ewanmorrison.substack.com/p/the-tranhumanist-cult-test)<!-- HN:43459990:end --><!-- HN:43462463:start -->
* [43462463](https://news.social-protocols.org/stats?id=43462463) #16 4 points 0 comments -> [Greenlanders overwhelmingly oppose becoming part of United States, poll shows](https://www.reuters.com/world/poll-shows-85-greenlanders-do-not-want-be-part-us-2025-01-29/)<!-- HN:43462463:end --><!-- HN:43464193:start -->
* [43464193](https://news.social-protocols.org/stats?id=43464193) #20 5 points 0 comments -> [Delete Your DNA from 23andMe](https://www.washingtonpost.com/technology/2025/03/24/23andme-dna-privacy-delete/)<!-- HN:43464193:end --><!-- HN:43465097:start -->
* [43465097](https://news.social-protocols.org/stats?id=43465097) #27 12 points 4 comments -> [Court rules family can sue school for giving COVID-19 shot without consent](https://www.bizpacreview.com/2025/03/24/court-rules-north-carolina-family-can-sue-for-giving-14-yr-old-son-covid-shot-without-parental-consent-1531307/)<!-- HN:43465097:end --><!-- HN:43465170:start -->
* [43465170](https://news.social-protocols.org/stats?id=43465170) #24 5 points 0 comments -> [The rage bait economy is going strong [video]](https://www.youtube.com/watch?v=Ah6AB33JUgU)<!-- HN:43465170:end --><!-- HN:43465333:start -->
* [43465333](https://news.social-protocols.org/stats?id=43465333) #16 32 points 16 comments -> [OpenAI Says It's "Over" If It Can't Steal All Your Copyrighted Work](https://futurism.com/openai-over-copyrighted-work)<!-- HN:43465333:end --><!-- HN:43464299:start -->
* [43464299](https://news.social-protocols.org/stats?id=43464299) #18 30 points 6 comments -> [Building an idempotent email API](https://riverqueue.com/blog/idempotent-email-api-with-river)<!-- HN:43464299:end --><!-- HN:43448288:start -->
* [43448288](https://news.social-protocols.org/stats?id=43448288) #14 10 points 3 comments -> [New Jailbreak Technique Uses Fictional World to Manipulate AI](https://www.securityweek.com/new-jailbreak-technique-uses-fictional-world-to-manipulate-ai/)<!-- HN:43448288:end -->
#### **Tuesday, March 25, 2025**
<!-- HN:43466698:start -->
* [43466698](https://news.social-protocols.org/stats?id=43466698) #30 20 points 5 comments -> [Surrendering to Authoritarianism](https://chrishedges.substack.com/p/surrendering-to-authoritarianism)<!-- HN:43466698:end --><!-- HN:43466983:start -->
* [43466983](https://news.social-protocols.org/stats?id=43466983) #4 82 points 3 comments -> [Jeffrey Goldberg on being added to the group chat by Trump Administration](https://www.theatlantic.com/newsletters/archive/2025/03/jeffrey-goldberg-group-chat-military-houthi-yemen/682160/)<!-- HN:43466983:end --><!-- HN:43467585:start -->
* [43467585](https://news.social-protocols.org/stats?id=43467585) #8 6 points 1 comments -> [Open source AI agent helper to let it SEE what its doing](https://github.com/monteslu/vibe-eyes)<!-- HN:43467585:end --><!-- HN:43468590:start -->
* [43468590](https://news.social-protocols.org/stats?id=43468590) #22 5 points 0 comments -> [I Recommend Against Brave](https://thelibre.news/no-really-dont-use-brave/)<!-- HN:43468590:end --><!-- HN:43467615:start -->
* [43467615](https://news.social-protocols.org/stats?id=43467615) #23 16 points 10 comments -> [Post Apocalyptic Computing](https://thomashunter.name/posts/2025-03-23-post-apocalyptic-computing)<!-- HN:43467615:end --><!-- HN:43468899:start -->
* [43468899](https://news.social-protocols.org/stats?id=43468899) #8 12 points 0 comments -> ['No Other Land' Filmmaker Beaten and Detained, Claims Activist Group](https://www.hollywoodreporter.com/movies/movie-news/no-other-land-director-beaten-detained-1236171578/)<!-- HN:43468899:end --><!-- HN:43470269:start -->
* [43470269](https://news.social-protocols.org/stats?id=43470269) #30 32 points 24 comments -> [Deregulation in Argentina: Milei Takes "Deep Chainsaw" to Bureaucracy](https://www.cato.org/free-society/spring-2025/deregulation-argentina-milei-takes-deep-chainsaw-bureaucracy-red-tape)<!-- HN:43470269:end --><!-- HN:43471463:start -->
* [43471463](https://news.social-protocols.org/stats?id=43471463) #21 8 points 0 comments -> [A pilot makes a tough call and cancels the flight because of some alarming signs](https://old.reddit.com/r/aviation/comments/1jjfqwg/a_pilot_reluctantly_makes_an_extremely_tough_call/)<!-- HN:43471463:end --><!-- HN:43469661:start -->
* [43469661](https://news.social-protocols.org/stats?id=43469661) #16 78 points 29 comments -> [High‑dose Vitamin D reduces disease activity in early multiple sclerosis onset](https://medicalxpress.com/news/2025-03-highdose-vitamin-d-significantly-disease.html)<!-- HN:43469661:end --><!-- HN:43471134:start -->
* [43471134](https://news.social-protocols.org/stats?id=43471134) #20 16 points 0 comments -> [The Phony Comforts of AI Optimism](https://www.wheresyoured.at/optimistic-cowardice/)<!-- HN:43471134:end --><!-- HN:43471242:start -->
* [43471242](https://news.social-protocols.org/stats?id=43471242) #21 7 points 2 comments -> [Tokyo court orders former Unification Church to disban](https://www3.nhk.or.jp/nhkworld/en/news/20250325_13/)<!-- HN:43471242:end --><!-- HN:43438032:start -->
* [43438032](https://news.social-protocols.org/stats?id=43438032) #25 16 points 8 comments -> [What Is the Most Minimal Agentic Coder You Can Write?](https://benhouston3d.com/blog/minimal-agentic-coder)<!-- HN:43438032:end --><!-- HN:43439307:start -->
* [43439307](https://news.social-protocols.org/stats?id=43439307) #29 31 points 40 comments -> [Gene drive modified mosquitoes offer new tool for malaria elimination efforts](https://www.imperial.ac.uk/news/261995/gene-drive-modified-mosquitoes-offer-tool/)<!-- HN:43439307:end --><!-- HN:43474085:start -->
* [43474085](https://news.social-protocols.org/stats?id=43474085) #23 4 points 1 comments -> [Jensen Huang on GPUs [video]](https://www.youtube.com/watch?v=G6R7UOFx1bw)<!-- HN:43474085:end --><!-- HN:43476148:start -->
* [43476148](https://news.social-protocols.org/stats?id=43476148) #19 16 points 1 comments -> [A majority of Swedes are open to boycotting American products](https://www.lunduniversity.lu.se/article/majority-swedes-are-open-boycotting-american-products)<!-- HN:43476148:end -->
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
* [43506421](https://news.social-protocols.org/stats?id=43506421) #29 4 points 0 comments -> [Gemini hackers can deliver more potent attacks with a helping hand from Gemini](https://arstechnica.com/security/2025/03/gemini-hackers-can-deliver-more-potent-attacks-with-a-helping-hand-from-gemini/)<!-- HN:43506421:end --><!-- HN:43506657:start -->
* [43506657](https://news.social-protocols.org/stats?id=43506657) #30 4 points 0 comments -> [We Mapped DOGE's Silicon Valley and Corporate Connections](https://www.wired.com/story/elon-musk-doge-silicon-valley-corporate-connections/)<!-- HN:43506657:end --><!-- HN:43509558:start -->
* [43509558](https://news.social-protocols.org/stats?id=43509558) #5 11 points 2 comments -> [Is This Sex Offender Map in Japan Legal?](https://unseen-japan.com/sex-offender-map-japan-legal/)<!-- HN:43509558:end --><!-- HN:43510633:start -->
* [43510633](https://news.social-protocols.org/stats?id=43510633) #29 6 points 1 comments -> [ChatGPT 4o adds image generation and its fun as hell](https://daringfireball.net/linked/2025/03/28/chatgpt-4o-adds-image-generation-and-its-fun-as-hell)<!-- HN:43510633:end --><!-- HN:43510753:start -->
* [43510753](https://news.social-protocols.org/stats?id=43510753) #28 13 points 0 comments -> [RFK Jr. To Shut Down HHS Office of Infectious Diseases and HIV Policy](https://www.advocate.com/health/office-infectious-diseases-hiv-closing)<!-- HN:43510753:end -->