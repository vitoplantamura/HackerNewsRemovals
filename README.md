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

#### **Tuesday, December 10, 2024**
<!-- HN:42372508:start -->
* [42372508](https://news.social-protocols.org/stats?id=42372508) #25 6 points 5 comments -> [Giant Study Links Drinking Coffee with Almost 2 Extra Years of Life](https://www.sciencealert.com/giant-study-links-drinking-coffee-with-almost-2-extra-years-of-life)<!-- HN:42372508:end --><!-- HN:42374469:start -->
* [42374469](https://news.social-protocols.org/stats?id=42374469) #4 8 points 0 comments -> [15 Times to use AI, and 5 Not to](https://www.oneusefulthing.org/p/15-times-to-use-ai-and-5-not-to)<!-- HN:42374469:end --><!-- HN:42375632:start -->
* [42375632](https://news.social-protocols.org/stats?id=42375632) #6 12 points 3 comments -> [ChatGPT's Sad Second Birthday](https://podcastaddict.com/podcast/system-crash/5515865)<!-- HN:42375632:end --><!-- HN:42316212:start -->
* [42316212](https://news.social-protocols.org/stats?id=42316212) #17 7 points 1 comments -> [Piskel – Free online editor for animated sprites and pixel art](https://www.piskelapp.com/)<!-- HN:42316212:end --><!-- HN:42379435:start -->
* [42379435](https://news.social-protocols.org/stats?id=42379435) #25 5 points 4 comments -> [Scientists claim they've found the cause mystery colon cancers in young people](https://www.dailymail.co.uk/health/article-14176551/Scientists-cause-mystery-colon-cancers-young-people-lifestyle-factors.html)<!-- HN:42379435:end -->
#### **Wednesday, December 11, 2024**<!-- HN:42386726:start -->
* [42386726](https://news.social-protocols.org/stats?id=42386726) #5 44 points 38 comments -> [Bankruptcy judge rejects The Onion's bid for Infowars](https://www.npr.org/2024/12/10/nx-s1-5224170/infowars-alex-jones-the-onion-bankruptcy-judge)<!-- HN:42386726:end --><!-- HN:42386683:start -->
* [42386683](https://news.social-protocols.org/stats?id=42386683) #25 37 points 0 comments -> [The Onion's Purchase of Alex Jones' Infowars Stopped by US Judge](https://www.reuters.com/legal/onions-purchase-alex-jones-infowars-stopped-by-us-judge-2024-12-11/)<!-- HN:42386683:end --><!-- HN:42387549:start -->
* [42387549](https://news.social-protocols.org/stats?id=42387549) #2 121 points 94 comments -> [The PayPal Mafia is taking over America's government](https://www.economist.com/business/2024/12/10/the-paypal-mafia-is-taking-over-americas-government)<!-- HN:42387549:end --><!-- HN:42388983:start -->
* [42388983](https://news.social-protocols.org/stats?id=42388983) #13 67 points 33 comments -> [Google are deliberately breaking YouTube when it detects you're running Firefox](https://old.reddit.com/r/firefox/comments/1cjbsmj/youtube_on_firefox_seems_to_be_getting_much_worse/)<!-- HN:42388983:end --><!-- HN:42390630:start -->
* [42390630](https://news.social-protocols.org/stats?id=42390630) #6 8 points 0 comments -> [UnitedHealthcare's Leaked Talking Points](https://www.kenklippenstein.com/p/unitedhealthcares-leaked-talking)<!-- HN:42390630:end --><!-- HN:42391483:start -->
* [42391483](https://news.social-protocols.org/stats?id=42391483) #14 29 points 13 comments -> [One of our clients hasn't paid us $130k – or "Why Every Contract Clause Matters"](https://www.apsis.io/blog/2024/12/11/clauses-matter/)<!-- HN:42391483:end --><!-- HN:42386906:start -->
* [42386906](https://news.social-protocols.org/stats?id=42386906) #28 5 points 1 comments -> [A chatbot hinted a kid should kill his parentts over screen time limits: lawsui](https://text.npr.org/nx-s1-5222574)<!-- HN:42386906:end -->
#### **Thursday, December 12, 2024**
<!-- HN:42350780:start -->
* [42350780](https://news.social-protocols.org/stats?id=42350780) #29 9 points 2 comments -> [WW1 dazzle camouflage was not as well understood as it might have been](https://phys.org/news/2024-12-world-war-dazzle-camouflage-understood.html)<!-- HN:42350780:end --><!-- HN:42399313:start -->
* [42399313](https://news.social-protocols.org/stats?id=42399313) #17 3 points 0 comments -> [Hacking Rooftop Solar Is a Way to Break Europe's Power Grid](https://www.bloomberg.com/news/articles/2024-12-12/europe-s-power-grid-vulnerable-to-hackers-exploiting-rooftop-solar-panels)<!-- HN:42399313:end --><!-- HN:42392660:start -->
* [42392660](https://news.social-protocols.org/stats?id=42392660) #20 156 points 47 comments -> [Instant macOS install on Proxmox including AMD patches](https://github.com/luchina-gabriel/OSX-PROXMOX)<!-- HN:42392660:end --><!-- HN:42398380:start -->
* [42398380](https://news.social-protocols.org/stats?id=42398380) #24 19 points 1 comments -> [The report for the 2024 security audit of the Mullvad app is now available](https://mullvad.net/en/blog/the-report-for-the-2024-security-audit-of-the-app-is-now-available)<!-- HN:42398380:end --><!-- HN:42388340:start -->
* [42388340](https://news.social-protocols.org/stats?id=42388340) #28 173 points 101 comments -> [Django and Postgres for the Busy Rails Developer](https://andyatkinson.com/django-python-postgres-busy-rails-developer)<!-- HN:42388340:end --><!-- HN:42398989:start -->
* [42398989](https://news.social-protocols.org/stats?id=42398989) #14 23 points 15 comments -> [French Piracy Blocking Order Goes Global, DNS Service Quad9 Vows to Fight](https://torrentfreak.com/french-piracy-blocking-order-goes-global-dns-service-quad9-vows-to-fight-241212/)<!-- HN:42398989:end --><!-- HN:42388973:start -->
* [42388973](https://news.social-protocols.org/stats?id=42388973) #19 250 points 45 comments -> [Pgroll – Zero-downtime, reversible, schema changes for PostgreSQL (new website)](https://pgroll.com/)<!-- HN:42388973:end --><!-- HN:42399562:start -->
* [42399562](https://news.social-protocols.org/stats?id=42399562) #5 5 points 0 comments -> [As Wolf Populations Rebound, an Angry Backlash Intensifies](https://e360.yale.edu/features/wolves-united-states-europe)<!-- HN:42399562:end --><!-- HN:42398314:start -->
* [42398314](https://news.social-protocols.org/stats?id=42398314) #16 12 points 0 comments -> [Retiring from Hanami/dry-rb/ROM-rb core teams](https://solnic.dev/retiring-from-the-core-teams)<!-- HN:42398314:end --><!-- HN:42392802:start -->
* [42392802](https://news.social-protocols.org/stats?id=42392802) #14 225 points 47 comments -> [QEMU with VirtIO GPU Vulkan Support](https://gist.github.com/peppergrayxyz/fdc9042760273d137dddd3e97034385f)<!-- HN:42392802:end --><!-- HN:42350293:start -->
* [42350293](https://news.social-protocols.org/stats?id=42350293) #28 17 points 40 comments -> [Can hunters' donations help deliver high-quality meat to Colorado food pantries?](https://collective.coloradotrust.org/stories/bringing-elk-and-venison-to-food-pantries/)<!-- HN:42350293:end --><!-- HN:42400179:start -->
* [42400179](https://news.social-protocols.org/stats?id=42400179) #19 16 points 7 comments -> [Particle gains or loses mass depending on direction it travels](https://newatlas.com/physics/particle-gains-loses-mass-depending-direction/)<!-- HN:42400179:end --><!-- HN:42354830:start -->
* [42354830](https://news.social-protocols.org/stats?id=42354830) #29 16 points 4 comments -> [The Holotypic Occlupanid Research Group](https://www.horg.com/)<!-- HN:42354830:end --><!-- HN:42390210:start -->
* [42390210](https://news.social-protocols.org/stats?id=42390210) #27 347 points 509 comments -> [OnlyFans models are using AI impersonators to keep up with their DMs](https://www.wired.com/story/onlyfans-models-are-using-ai-impersonators-to-keep-up-with-their-dms/)<!-- HN:42390210:end --><!-- HN:42401821:start -->
* [42401821](https://news.social-protocols.org/stats?id=42401821) #26 7 points 1 comments -> [Attacker Has Techdirt Reclassified as Phishing Site](https://www.techdirt.com/2024/12/12/attacker-has-techdirt-reclassified-as-phishing-site-proving-masnicks-impossibility-law-once-again/)<!-- HN:42401821:end -->
#### **Friday, December 13, 2024**
<!-- HN:42316470:start -->
* [42316470](https://news.social-protocols.org/stats?id=42316470) #14 83 points 49 comments -> [Misperception of the facial appearance that the opposite-sex desires](https://journals.plos.org/plosone/article?id=10.1371/journal.pone.0310835)<!-- HN:42316470:end --><!-- HN:42407619:start -->
* [42407619](https://news.social-protocols.org/stats?id=42407619) #27 9 points 2 comments -> [The dirty secret about OnlyFans: it's not hot to be a prostitute](https://unherd.com/2024/12/the-dirty-secret-about-onlyfans/)<!-- HN:42407619:end --><!-- HN:42378166:start -->
* [42378166](https://news.social-protocols.org/stats?id=42378166) #24 38 points 7 comments -> [When the future arrived, it felt ordinary](https://worksinprogress.co/issue/the-world-of-tomorrow/)<!-- HN:42378166:end --><!-- HN:42375509:start -->
* [42375509](https://news.social-protocols.org/stats?id=42375509) #16 10 points 6 comments -> [Eventual Consistency Is Tricky](https://newsletter.systemdesigncodex.com/p/eventual-consistency-is-tricky)<!-- HN:42375509:end --><!-- HN:42351988:start -->
* [42351988](https://news.social-protocols.org/stats?id=42351988) #17 47 points 34 comments -> [Microsoft GW-Basic User's Guide and Reference (1989) [pdf]](https://bitsavers.computerhistory.org/pdf/microsoft/gw-basic/Microsoft_GW-BASIC_Users_Guide_and_Reference_1989.pdf)<!-- HN:42351988:end --><!-- HN:42376083:start -->
* [42376083](https://news.social-protocols.org/stats?id=42376083) #19 63 points 10 comments -> [Mastering Ruby Debugging: From Puts to Professional Tools](https://blog.jetbrains.com/ruby/2024/12/mastering_ruby_debugging/)<!-- HN:42376083:end --><!-- HN:42408117:start -->
* [42408117](https://news.social-protocols.org/stats?id=42408117) #23 20 points 16 comments -> [SpaceX Seeks Approval to Turn Texas Starbase Site into New City](https://www.bloomberg.com/news/articles/2024-12-13/spacex-seeks-approval-to-turn-texas-starbase-site-into-new-city)<!-- HN:42408117:end --><!-- HN:42405357:start -->
* [42405357](https://news.social-protocols.org/stats?id=42405357) #17 102 points 19 comments -> [Rust's Incremental Compiler Architecture](https://lwn.net/Articles/997784/)<!-- HN:42405357:end --><!-- HN:42409059:start -->
* [42409059](https://news.social-protocols.org/stats?id=42409059) #27 7 points 0 comments -> [Fourteen North Koreans Indicted for Fraudulent IT Worker Scheme and Extortions](https://www.justice.gov/opa/pr/fourteen-north-korean-nationals-indicted-carrying-out-multi-year-fraudulent-information)<!-- HN:42409059:end --><!-- HN:42409904:start -->
* [42409904](https://news.social-protocols.org/stats?id=42409904) #21 3 points 0 comments -> [Coffee Prices Break 47-Year Old Record](https://www.wsj.com/livecoverage/stock-market-today-dow-sp500-nasdaq-live-12-10-2024/card/coffee-prices-break-47-year-old-record-B46Hi6BOWrhxLhos0DH2)<!-- HN:42409904:end --><!-- HN:42404202:start -->
* [42404202](https://news.social-protocols.org/stats?id=42404202) #19 158 points 26 comments -> [Taming LLMs – A Practical Guide to LLM Pitfalls with Open Source Software](https://www.souzatharsis.com/tamingLLMs/markdown/toc.html)<!-- HN:42404202:end --><!-- HN:42408927:start -->
* [42408927](https://news.social-protocols.org/stats?id=42408927) #27 12 points 1 comments -> [People are living longer – But spending more time in poor health](https://studyfinds.org/living-longer-in-poor-health/)<!-- HN:42408927:end --><!-- HN:42410571:start -->
* [42410571](https://news.social-protocols.org/stats?id=42410571) #9 4 points 0 comments -> [Identifying Political Bias in AI – Communications of the ACM](https://cacm.acm.org/news/identifying-political-bias-in-ai/)<!-- HN:42410571:end --><!-- HN:42352075:start -->
* [42352075](https://news.social-protocols.org/stats?id=42352075) #22 11 points 2 comments -> [PostmarketOS-Powered Kubernetes Cluster](https://blog.denv.it/posts/pmos-k3s-cluster/)<!-- HN:42352075:end -->
#### **Saturday, December 14, 2024**
<!-- HN:42413693:start -->
* [42413693](https://news.social-protocols.org/stats?id=42413693) #2 35 points 1 comments -> [My PhD advisor rewrote himself in bash](https://matt.might.net/articles/shell-scripts-for-passive-voice-weasel-words-duplicates/)<!-- HN:42413693:end --><!-- HN:42414912:start -->
* [42414912](https://news.social-protocols.org/stats?id=42414912) #4 84 points 23 comments -> [Ilya Sutskever Test of Time Talk "Pre-training as we know it will end"](https://twitter.com/i/status/1867719020444889118)<!-- HN:42414912:end --><!-- HN:42413845:start -->
* [42413845](https://news.social-protocols.org/stats?id=42413845) #13 173 points 84 comments -> [Htmx 2.0.4 Released](https://github.com/bigskysoftware/htmx/blob/v2.0.4/CHANGELOG.md)<!-- HN:42413845:end --><!-- HN:42390226:start -->
* [42390226](https://news.social-protocols.org/stats?id=42390226) #24 6 points 9 comments -> [The case against static typing in PHP (2023)](https://www.tonymarston.net/php-mysql/against-static-typing-in-php.html)<!-- HN:42390226:end --><!-- HN:42415768:start -->
* [42415768](https://news.social-protocols.org/stats?id=42415768) #10 3 points 0 comments -> [John Carmack on Functional Programming in C++](http://www.sevangelatos.com/john-carmack-on/)<!-- HN:42415768:end --><!-- HN:42414641:start -->
* [42414641](https://news.social-protocols.org/stats?id=42414641) #18 38 points 9 comments -> [Suchir's Essay on Fair Use](https://suchir.net/fair_use.html)<!-- HN:42414641:end --><!-- HN:42378532:start -->
* [42378532](https://news.social-protocols.org/stats?id=42378532) #10 11 points 4 comments -> [Subnet routers: how do they work?](https://tailscale.com/blog/subnet-router-video)<!-- HN:42378532:end --><!-- HN:42418365:start -->
* [42418365](https://news.social-protocols.org/stats?id=42418365) #17 3 points 0 comments -> [TikTok's Future in the US Is Unclear](https://www.wired.com/story/tiktok-future-ban-billionaire-mccourt-sale/)<!-- HN:42418365:end --><!-- HN:42387220:start -->
* [42387220](https://news.social-protocols.org/stats?id=42387220) #6 31 points 43 comments -> [WhatsApp became an unstoppable cultural force](https://restofworld.org/2024/how-whatsapp-became-a-global-cultural-force/)<!-- HN:42387220:end --><!-- HN:42420012:start -->
* [42420012](https://news.social-protocols.org/stats?id=42420012) #23 17 points 12 comments -> [Scandal in Russian military town as new school is decorated with F-16 images](https://www.thebarentsobserver.com/news/scandal-in-russian-military-town-pechenga-as-new-school-is-decorated-with-picture-of-us-fighter-jets/422078)<!-- HN:42420012:end -->
#### **Sunday, December 15, 2024**
<!-- HN:42419895:start -->
* [42419895](https://news.social-protocols.org/stats?id=42419895) #11 8 points 2 comments -> [Meet your new Time Server](https://centerclick.com/ntp/)<!-- HN:42419895:end --><!-- HN:42420361:start -->
* [42420361](https://news.social-protocols.org/stats?id=42420361) #27 35 points 37 comments -> [There's a New Country Ranking and You're Not Going to Like It](https://www.atvbt.com/bmi/)<!-- HN:42420361:end --><!-- HN:42421477:start -->
* [42421477](https://news.social-protocols.org/stats?id=42421477) #9 38 points 5 comments -> [Doom ported to run mostly only on AMD GPUs via ROCm and LLVM Libc](https://www.phoronix.com/news/DOOM-ROCm-LLVM-Port)<!-- HN:42421477:end --><!-- HN:42391666:start -->
* [42391666](https://news.social-protocols.org/stats?id=42391666) #11 9 points 0 comments -> [Canids as Pollinators?](https://esajournals.onlinelibrary.wiley.com/doi/10.1002/ecy.4470)<!-- HN:42391666:end --><!-- HN:42422594:start -->
* [42422594](https://news.social-protocols.org/stats?id=42422594) #5 9 points 2 comments -> [Show HN: Shop Clothes with Models That Match Your Body Shape](https://www.thebodymatch.com)<!-- HN:42422594:end --><!-- HN:42407187:start -->
* [42407187](https://news.social-protocols.org/stats?id=42407187) #25 14 points 1 comments -> [In pictures: Learning the Knowledge (2016)](https://www.bbc.com/news/in-pictures-35667599)<!-- HN:42407187:end --><!-- HN:42423489:start -->
* [42423489](https://news.social-protocols.org/stats?id=42423489) #4 7 points 0 comments -> [Search through Rijksmuseum artworks based on meaning](https://artexplorer.ai/)<!-- HN:42423489:end --><!-- HN:42423645:start -->
* [42423645](https://news.social-protocols.org/stats?id=42423645) #15 6 points 0 comments -> [She took a DNA test. Police used it to charge her grandma with a 1997 murder](https://www.cnn.com/2024/12/12/us/baby-garnet-cold-case-michigan/index.html)<!-- HN:42423645:end --><!-- HN:42423437:start -->
* [42423437](https://news.social-protocols.org/stats?id=42423437) #22 9 points 1 comments -> [Spaces ZeroGPU: Dynamic GPU Allocation for Spaces](https://huggingface.co/docs/hub/en/spaces-zerogpu)<!-- HN:42423437:end --><!-- HN:42390863:start -->
* [42390863](https://news.social-protocols.org/stats?id=42390863) #20 8 points 1 comments -> [Promising early data in triple negative breast cancer](https://www.statnews.com/2024/12/10/triple-negative-breast-cancer-biontech-immunotherapy-bispecific/)<!-- HN:42390863:end --><!-- HN:42425022:start -->
* [42425022](https://news.social-protocols.org/stats?id=42425022) #14 12 points 2 comments -> [Infectious diseases in Victorian novels highlight public health fragility now](https://theconversation.com/infectious-diseases-killed-victorian-children-at-alarming-rates-their-novels-highlight-the-fragility-of-public-health-today-242273)<!-- HN:42425022:end --><!-- HN:42426296:start -->
* [42426296](https://news.social-protocols.org/stats?id=42426296) #2 19 points 2 comments -> [Visualization of cities with similar road networks](https://github.com/anvaka/similar-cities)<!-- HN:42426296:end -->
#### **Monday, December 16, 2024**
<!-- HN:42427731:start -->
* [42427731](https://news.social-protocols.org/stats?id=42427731) #5 3 points 2 comments -> [Luigi Mangione's Resume](https://www.kenklippenstein.com/p/read-luigi-mangiones-resume)<!-- HN:42427731:end -->