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

#### **Wednesday, November 20, 2024**
<!-- HN:42189241:start -->
* [42189241](https://news.social-protocols.org/stats?id=42189241) #13 5 points 2 comments -> [Show HN: Serverless code execution, but for AI agents](https://sandboxed.ai)<!-- HN:42189241:end --><!-- HN:42106623:start -->
* [42106623](https://news.social-protocols.org/stats?id=42106623) #4 72 points 11 comments -> [A stubborn computer scientist accidentally launched the deep learning boom](https://arstechnica.com/ai/2024/11/how-a-stubborn-computer-scientist-accidentally-launched-the-deep-learning-boom/)<!-- HN:42106623:end --><!-- HN:42190468:start -->
* [42190468](https://news.social-protocols.org/stats?id=42190468) #8 4 points 2 comments -> [ChatGPT Web search are not properly grounded and accurate](https://chatgpt.com/share/673d5043-cf90-800e-98f0-1ef4963c6baf)<!-- HN:42190468:end --><!-- HN:42190548:start -->
* [42190548](https://news.social-protocols.org/stats?id=42190548) #25 9 points 2 comments -> [Apple TV+ Will License Its Movies to Other Services to Reduce Billions in Losses](https://www.bloomberg.com/news/newsletters/2024-11-17/paramount-boss-on-gladiator-ii-scary-sequels-and-wicked-showdown)<!-- HN:42190548:end --><!-- HN:42190647:start -->
* [42190647](https://news.social-protocols.org/stats?id=42190647) #10 5 points 0 comments -> ["Safe" C++](https://izzys.casa/2024/11/on-safe-cxx/)<!-- HN:42190647:end --><!-- HN:42116051:start -->
* [42116051](https://news.social-protocols.org/stats?id=42116051) #12 67 points 144 comments -> [Is the 80 character line limit still relevant? (2008)](https://richarddingwall.name/2008/05/31/is-the-80-character-line-limit-still-relevant/)<!-- HN:42116051:end --><!-- HN:42191051:start -->
* [42191051](https://news.social-protocols.org/stats?id=42191051) #26 24 points 26 comments -> [Jaguar Cars rebranding without any cars](https://www.jaguarusa.com/copy-nothing/index.html)<!-- HN:42191051:end --><!-- HN:42192356:start -->
* [42192356](https://news.social-protocols.org/stats?id=42192356) #17 12 points 5 comments -> [Banned from Bluesky Within 30s](https://twitter.com/EndWokeness/status/1858157070018560377)<!-- HN:42192356:end --><!-- HN:42188555:start -->
* [42188555](https://news.social-protocols.org/stats?id=42188555) #9 156 points 44 comments -> [Using uv with PyTorch](https://docs.astral.sh/uv/guides/integration/pytorch/)<!-- HN:42188555:end --><!-- HN:42191335:start -->
* [42191335](https://news.social-protocols.org/stats?id=42191335) #7 18 points 13 comments -> [Trivial REST server in various languages to compare](https://github.com/begoon/http-server)<!-- HN:42191335:end --><!-- HN:42186016:start -->
* [42186016](https://news.social-protocols.org/stats?id=42186016) #17 174 points 16 comments -> [The Data Engineering Handbook](https://github.com/DataExpert-io/data-engineer-handbook)<!-- HN:42186016:end --><!-- HN:42189581:start -->
* [42189581](https://news.social-protocols.org/stats?id=42189581) #19 245 points 87 comments -> [Apple Confirms Zero-Day Attacks Hitting macOS Systems](https://www.securityweek.com/apple-confirms-zero-day-attacks-hitting-intel-based-macs/)<!-- HN:42189581:end --><!-- HN:42190379:start -->
* [42190379](https://news.social-protocols.org/stats?id=42190379) #30 84 points 23 comments -> [Call for Developer Projects](https://github.com/bluesky-social/atproto/discussions/3049)<!-- HN:42190379:end --><!-- HN:42192979:start -->
* [42192979](https://news.social-protocols.org/stats?id=42192979) #13 5 points 0 comments -> [China Could Re-Dollarize the World](https://indi.ca/how-china-starts-printing-usd/)<!-- HN:42192979:end --><!-- HN:42192412:start -->
* [42192412](https://news.social-protocols.org/stats?id=42192412) #4 16 points 4 comments -> [Underrated Ways to Change the World](https://www.experimental-history.com/p/underrated-ways-to-change-the-world)<!-- HN:42192412:end --><!-- HN:42188368:start -->
* [42188368](https://news.social-protocols.org/stats?id=42188368) #19 63 points 19 comments -> [Prusa CORE One: Our new fully-enclosed CoreXY 3D printer](https://blog.prusa3d.com/introducing-prusa-core-one-fully-enclosed-corexy-3d-printer-with-active-temperature-control_105477/)<!-- HN:42188368:end --><!-- HN:42193591:start -->
* [42193591](https://news.social-protocols.org/stats?id=42193591) #11 9 points 0 comments -> [Don't Call It a Substack](https://www.anildash.com//2024/11/19/dont-call-it-a-substack/)<!-- HN:42193591:end --><!-- HN:42193514:start -->
* [42193514](https://news.social-protocols.org/stats?id=42193514) #22 4 points 2 comments -> [Ozempic Could Prevent Diabetes. Should It Be Used for That?](https://www.nytimes.com/2024/11/13/well/ozempic-prediabetes.html)<!-- HN:42193514:end --><!-- HN:42194261:start -->
* [42194261](https://news.social-protocols.org/stats?id=42194261) #13 3 points 0 comments -> ["A major blocker to free and open source multimedia is isostandards"](https://twitter.com/FFmpeg/status/1858654093985935740)<!-- HN:42194261:end --><!-- HN:42143550:start -->
* [42143550](https://news.social-protocols.org/stats?id=42143550) #16 17 points 1 comments -> [Chrestomathy](https://en.wikipedia.org/wiki/Chrestomathy)<!-- HN:42143550:end --><!-- HN:42195842:start -->
* [42195842](https://news.social-protocols.org/stats?id=42195842) #23 4 points 0 comments -> [Cells have more mini 'organs' than researchers thought](https://theconversation.com/cells-have-more-mini-organs-than-researchers-thought-unbound-by-membranes-these-rogue-organelles-challenge-biologys-fundamentals-239558)<!-- HN:42195842:end --><!-- HN:42195874:start -->
* [42195874](https://news.social-protocols.org/stats?id=42195874) #8 4 points 0 comments -> [Show HN: One Prompt – A super framework for prompt engineering](https://github.com/VaibhavAcharya/oneprompt)<!-- HN:42195874:end --><!-- HN:42195587:start -->
* [42195587](https://news.social-protocols.org/stats?id=42195587) #11 8 points 10 comments -> [Show HN: I'm 17 and made a tool to help students study smarter](https://lira.study)<!-- HN:42195587:end --><!-- HN:42196553:start -->
* [42196553](https://news.social-protocols.org/stats?id=42196553) #24 3 points 0 comments -> [GPT-4o Got an Update](https://twitter.com/OpenAI/status/1859296125947347164)<!-- HN:42196553:end --><!-- HN:42196942:start -->
* [42196942](https://news.social-protocols.org/stats?id=42196942) #28 3 points 0 comments -> [Roadblocks to Competition: Investigate Google's Non-Compliance with the EU's DMA](https://spreadprivacy.com/investigate-google-dma/)<!-- HN:42196942:end --><!-- HN:42195948:start -->
* [42195948](https://news.social-protocols.org/stats?id=42195948) #20 17 points 2 comments -> [Ghost Tap: New cash-out tactic with NFC Relay](https://www.threatfabric.com/blogs/ghost-tap-new-cash-out-tactic-with-nfc-relay)<!-- HN:42195948:end --><!-- HN:42196381:start -->
* [42196381](https://news.social-protocols.org/stats?id=42196381) #21 21 points 8 comments -> [Show HN: Weave - actually measure engineering productivity](https://app.workweave.ai/welcome)<!-- HN:42196381:end --><!-- HN:42197767:start -->
* [42197767](https://news.social-protocols.org/stats?id=42197767) #19 6 points 3 comments -> [Google turns Android into a desktop OS in 5 steps](https://www.zdnet.com/article/how-google-turns-android-into-a-desktop-os-in-5-steps/)<!-- HN:42197767:end --><!-- HN:42197759:start -->
* [42197759](https://news.social-protocols.org/stats?id=42197759) #10 31 points 5 comments -> [DOJ wants to force Google Chrome sale, Android de-bundling](https://arstechnica.com/tech-policy/2024/11/report-doj-wants-to-force-google-chrome-sale-android-de-bundling/)<!-- HN:42197759:end --><!-- HN:42199059:start -->
* [42199059](https://news.social-protocols.org/stats?id=42199059) #25 6 points 2 comments -> [Why the sun is setting on European-style welfarism](https://www.telegraph.co.uk/business/2024/11/20/why-the-sun-is-setting-on-the-european-style-welfarism/)<!-- HN:42199059:end -->
#### **Thursday, November 21, 2024**
<!-- HN:42198783:start -->
* [42198783](https://news.social-protocols.org/stats?id=42198783) #22 11 points 4 comments -> [Show HN: Shop on Amazon with Crypto](https://www.baggins.ai/?source=hackernews)<!-- HN:42198783:end --><!-- HN:42200925:start -->
* [42200925](https://news.social-protocols.org/stats?id=42200925) #3 5 points 0 comments -> [Ford lost $3.7B on its EV sales](https://www.mackinac.org/blog/2024/the-market-speaks-against-electric-vehicles)<!-- HN:42200925:end --><!-- HN:42199301:start -->
* [42199301](https://news.social-protocols.org/stats?id=42199301) #13 364 points 98 comments -> [Z-Library Helps Students to Overcome Academic Poverty, Study Finds](https://torrentfreak.com/z-library-helps-students-to-overcome-academic-poverty-study-finds-241120/)<!-- HN:42199301:end --><!-- HN:42198256:start -->
* [42198256](https://news.social-protocols.org/stats?id=42198256) #14 104 points 30 comments -> [/usr/bin/env -S uv run](https://simonwillison.net/2024/Aug/21/usrbinenv-uv-run/)<!-- HN:42198256:end --><!-- HN:42201068:start -->
* [42201068](https://news.social-protocols.org/stats?id=42201068) #27 138 points 109 comments -> [Boeing overcharged the U.S. Air Force 8,000% above market for soap dispensers](https://www.reuters.com/business/aerospace-defense/boeing-overcharged-air-force-nearly-8000-soap-dispensers-watchdog-alleges-2024-10-29/)<!-- HN:42201068:end --><!-- HN:42194540:start -->
* [42194540](https://news.social-protocols.org/stats?id=42194540) #21 209 points 36 comments -> [Pipe Viewer – A Unix Utility You Should Know About](https://catonmat.net/unix-utilities-pipe-viewer)<!-- HN:42194540:end --><!-- HN:42203245:start -->
* [42203245](https://news.social-protocols.org/stats?id=42203245) #28 6 points 4 comments -> [Vercel acquires Grep](https://vercel.com/blog/vercel-acquires-grep)<!-- HN:42203245:end --><!-- HN:42200987:start -->
* [42200987](https://news.social-protocols.org/stats?id=42200987) #25 29 points 12 comments -> [Why one would use Qubes OS? (2023)](https://dataswamp.org/~solene/2023-06-17-qubes-os-why.html)<!-- HN:42200987:end --><!-- HN:42197824:start -->
* [42197824](https://news.social-protocols.org/stats?id=42197824) #25 107 points 125 comments -> [New Calculation Finds we are close to the Kessler Syndrome [video]](https://www.youtube.com/watch?v=Bi9EW9xhqAU)<!-- HN:42197824:end --><!-- HN:42204713:start -->
* [42204713](https://news.social-protocols.org/stats?id=42204713) #21 4 points 0 comments -> [Las Vegas man who called 911 for help killed by police in his home](https://www.bbc.com/news/articles/ckglp4nz75zo)<!-- HN:42204713:end --><!-- HN:42205132:start -->
* [42205132](https://news.social-protocols.org/stats?id=42205132) #17 6 points 2 comments -> [Child safety org launches AI model trained on real child sex abuse images](https://arstechnica.com/tech-policy/2024/11/ai-trained-on-real-child-sex-abuse-images-to-detect-new-csam/)<!-- HN:42205132:end --><!-- HN:42207804:start -->
* [42207804](https://news.social-protocols.org/stats?id=42207804) #26 4 points 0 comments -> [Microsoft tries to convince Windows 10 users with full-screen prompts](https://www.theverge.com/2024/11/20/24301768/microsoft-windows-10-upgrade-prompt-copilot-plus-pcs)<!-- HN:42207804:end --><!-- HN:42208021:start -->
* [42208021](https://news.social-protocols.org/stats?id=42208021) #17 11 points 3 comments -> [Comparison of Claude Sonnet 3.5, GPT-4o, o1, and Gemini 1.5 Pro for coding](https://www.qodo.ai/blog/comparison-of-claude-sonnet-3-5-gpt-4o-o1-and-gemini-1-5-pro-for-coding/)<!-- HN:42208021:end -->
#### **Friday, November 22, 2024**<!-- HN:42210690:start -->
* [42210690](https://news.social-protocols.org/stats?id=42210690) #1 -> [Microsoft Copilot Customers Discover It Can Let Them Read HR Docs and CEO Emails](https://21hats.substack.com/p/all-of-a-sudden-joe-blow-can-see)<!-- HN:42210690:end --><!-- HN:42211720:start -->
* [42211720](https://news.social-protocols.org/stats?id=42211720) #13 10 points 0 comments -> [Tesla has the highest rate of fatal accidents among all car brands, report shows](https://sherwood.news/business/tesla-has-the-highest-rate-of-fatal-accidents-among-all-car-brands-report/)<!-- HN:42211720:end --><!-- HN:42208580:start -->
* [42208580](https://news.social-protocols.org/stats?id=42208580) #12 121 points 51 comments -> [Security researchers identify new malware targeting Linux](https://www.welivesecurity.com/en/eset-research/unveiling-wolfsbane-gelsemiums-linux-counterpart-to-gelsevirine/)<!-- HN:42208580:end --><!-- HN:42211320:start -->
* [42211320](https://news.social-protocols.org/stats?id=42211320) #16 80 points 34 comments -> [Pidgin 3.0.0 Experimental 1 Announcement](https://discourse.imfreedom.org/t/pidgin-3-0-0-experimental-1-announcement/216)<!-- HN:42211320:end --><!-- HN:42210022:start -->
* [42210022](https://news.social-protocols.org/stats?id=42210022) #17 60 points 32 comments -> [Broadcastarr: Stream web content through your Jellyfin instance](https://github.com/Billos/Broadcastarr)<!-- HN:42210022:end --><!-- HN:42211367:start -->
* [42211367](https://news.social-protocols.org/stats?id=42211367) #19 80 points 7 comments -> [Oppose the Patent-Troll-Friendly Prevail Act](https://www.eff.org/deeplinks/2024/11/prevail-act-would-wreck-us-patent-review-system)<!-- HN:42211367:end --><!-- HN:42212920:start -->
* [42212920](https://news.social-protocols.org/stats?id=42212920) #17 4 points 0 comments -> [Mastodon's weaknesses and how to fix them](https://2ality.com/2024/11/mastodon-weaknesses.html)<!-- HN:42212920:end --><!-- HN:42182047:start -->
* [42182047](https://news.social-protocols.org/stats?id=42182047) #29 30 points 40 comments -> [Is Python That Slow?](https://blog.miguelgrinberg.com/post/is-python-really-that-slow)<!-- HN:42182047:end --><!-- HN:42213629:start -->
* [42213629](https://news.social-protocols.org/stats?id=42213629) #20 6 points 1 comments -> [The Soviet scientist who survived a particle accelerator beam through his head](https://en.wikipedia.org/wiki/Anatoli_Bugorski)<!-- HN:42213629:end --><!-- HN:42215043:start -->
* [42215043](https://news.social-protocols.org/stats?id=42215043) #24 18 points 11 comments -> [Toddlers Shoot Three People Every Month in Texas](https://kfox95.com/toddlers-shoot-people-texas/)<!-- HN:42215043:end --><!-- HN:42215202:start -->
* [42215202](https://news.social-protocols.org/stats?id=42215202) #27 8 points 0 comments -> [Majority of people believe their devices spy on them to serve up ads](https://www.newscientist.com/article/2457333-majority-of-people-believe-their-devices-spy-on-them-to-serve-up-ads/)<!-- HN:42215202:end --><!-- HN:42215608:start -->
* [42215608](https://news.social-protocols.org/stats?id=42215608) #30 6 points 0 comments -> [Feds release options for Colorado River as negotiations between states stall](https://phys.org/news/2024-11-feds-options-future-colorado-river.html)<!-- HN:42215608:end --><!-- HN:42217095:start -->
* [42217095](https://news.social-protocols.org/stats?id=42217095) #20 17 points 7 comments -> [Texas Opens Investigation into Conspiracy to Boycott Certain Social Platforms](https://www.texasattorneygeneral.gov/news/releases/attorney-general-ken-paxton-opens-investigation-possible-conspiracy-advertising-companies-boycott)<!-- HN:42217095:end -->
#### **Saturday, November 23, 2024**
<!-- HN:42218757:start -->
* [42218757](https://news.social-protocols.org/stats?id=42218757) #27 4 points 7 comments -> [Microsoft's New PC Looks Just Like a Mac Mini but Serves a Whole New Purpose](https://www.slashgear.com/1717092/microsoft-new-pc-mac-mini-lookalike/)<!-- HN:42218757:end --><!-- HN:42219036:start -->
* [42219036](https://news.social-protocols.org/stats?id=42219036) #20 3 points 2 comments -> [Pulling gold out of e-waste suddenly becomes super-profitable](https://newatlas.com/materials/gold-electronic-waste/)<!-- HN:42219036:end --><!-- HN:42170144:start -->
* [42170144](https://news.social-protocols.org/stats?id=42170144) #20 4 points 2 comments -> [Who Really Wrote the Bible: The Story of the Scribes](https://www.historytoday.com/archive/review/who-really-wrote-bible-william-m-schniedewind-review)<!-- HN:42170144:end --><!-- HN:42219646:start -->
* [42219646](https://news.social-protocols.org/stats?id=42219646) #6 5 points 1 comments -> [UK Farmers Trigger the Revolution – Politely](https://morningporridge.com/blog/nations/uk/uk-farmers-trigger-the-revolution-politely/)<!-- HN:42219646:end --><!-- HN:42219695:start -->
* [42219695](https://news.social-protocols.org/stats?id=42219695) #22 29 points 7 comments -> [Teslas Are Involved in More Fatal Accidents Than Any Other Brand, Study Finds](https://gizmodo.com/teslas-are-involved-in-more-fatal-accidents-than-any-other-brand-study-finds-2000528042)<!-- HN:42219695:end --><!-- HN:42220545:start -->
* [42220545](https://news.social-protocols.org/stats?id=42220545) #13 8 points 0 comments -> [Texas approves Bible-infused curriculum for public schools](https://www.houstonpublicmedia.org/articles/news/education-news/2024/11/22/506917/texas-approves-bible-infused-curriculum-for-public-schools/)<!-- HN:42220545:end --><!-- HN:42220719:start -->
* [42220719](https://news.social-protocols.org/stats?id=42220719) #21 7 points 0 comments -> [iFixit Shares M4 MacBook Pro Teardown](https://www.macrumors.com/2024/11/22/ifixit-shares-m4-macbook-pro-teardown/)<!-- HN:42220719:end --><!-- HN:42220062:start -->
* [42220062](https://news.social-protocols.org/stats?id=42220062) #27 36 points 25 comments -> [How the ZX Spectrum became a 1980s icon](https://www.bbc.com/news/articles/cpvzp80jv07o)<!-- HN:42220062:end --><!-- HN:42221615:start -->
* [42221615](https://news.social-protocols.org/stats?id=42221615) #10 6 points 0 comments -> [Kent Overstreet restricted from participation in kernel development](https://lwn.net/Articles/999197/)<!-- HN:42221615:end -->
#### **Sunday, November 24, 2024**
<!-- HN:42224891:start -->
* [42224891](https://news.social-protocols.org/stats?id=42224891) #26 7 points 6 comments -> [An Idaho County Will Publish Everyone's Ballots to Combat Mistrust](https://www.nytimes.com/2024/11/23/us/ballots-election-boise-idaho.html)<!-- HN:42224891:end --><!-- HN:42224398:start -->
* [42224398](https://news.social-protocols.org/stats?id=42224398) #24 51 points 40 comments -> [Wordpress.org released Secure Custom Fields "PRO" version with ACF pro features](https://old.reddit.com/r/Wordpress/comments/1gy8bud/wordpressorg_has_apparently_released_secure/)<!-- HN:42224398:end --><!-- HN:42226860:start -->
* [42226860](https://news.social-protocols.org/stats?id=42226860) #13 8 points 2 comments -> [Win for Internet freedom: Google must sell its Chrome browser](https://tuta.com/blog/google-must-sell-chrome-in-antitrust-case)<!-- HN:42226860:end --><!-- HN:42226963:start -->
* [42226963](https://news.social-protocols.org/stats?id=42226963) #4 5 points 4 comments -> [Not Using Copilot](https://macwright.com/2024/11/20/not-using-copilot)<!-- HN:42226963:end --><!-- HN:42227290:start -->
* [42227290](https://news.social-protocols.org/stats?id=42227290) #12 14 points 10 comments -> [PHP Is Legacy, in 2024](https://developer.vonage.com/en/blog/php-is-legacy-in-2024)<!-- HN:42227290:end --><!-- HN:42227151:start -->
* [42227151](https://news.social-protocols.org/stats?id=42227151) #20 20 points 40 comments -> [Homeless people to be given cash in first major UK trial to reduce poverty](https://www.theguardian.com/society/2024/nov/24/homeless-people-to-be-given-cash-in-first-major-uk-trial-to-reduce-poverty)<!-- HN:42227151:end --><!-- HN:42189125:start -->
* [42189125](https://news.social-protocols.org/stats?id=42189125) #12 11 points 5 comments -> [Why Smart C Coders Love Lua](https://realtimelogic.com/articles/Using-Lua-for-Embedded-Development-vs-Traditional-C-Code)<!-- HN:42189125:end --><!-- HN:42222717:start -->
* [42222717](https://news.social-protocols.org/stats?id=42222717) #16 145 points 42 comments -> [1 Dataset. 100 Visualizations](https://100.datavizproject.com/)<!-- HN:42222717:end --><!-- HN:42227996:start -->
* [42227996](https://news.social-protocols.org/stats?id=42227996) #19 4 points 0 comments -> [C++ Standards Contributor Expelled for 'The Undefined Behavior Question'](https://m.slashdot.org/submission/17330375)<!-- HN:42227996:end --><!-- HN:42230240:start -->
* [42230240](https://news.social-protocols.org/stats?id=42230240) #12 6 points 2 comments -> [Comparison of Claude Sonnet 3.5, GPT-4o, o1, and Gemini 1.5 Pro for coding](https://www.qodo.ai/blog/comparison-of-claude-sonnet-3-5-gpt-4o-o1-and-gemini-1-5-pro-for-coding/)<!-- HN:42230240:end --><!-- HN:42231007:start -->
* [42231007](https://news.social-protocols.org/stats?id=42231007) #13 -> [WebSockets cost us $1M on our AWS bill](https://www.recall.ai/post/how-websockets-cost-us-1m-on-our-aws-bill?)<!-- HN:42231007:end -->
#### **Monday, November 25, 2024**
<!-- HN:42232430:start -->
* [42232430](https://news.social-protocols.org/stats?id=42232430) #24 3 points 1 comments -> [Semantic Transpiler Agent](https://github.com/cyyeh/sta)<!-- HN:42232430:end --><!-- HN:42213485:start -->
* [42213485](https://news.social-protocols.org/stats?id=42213485) #24 10 points 2 comments -> [Slow Email (2008)](http://notes-from-a-sticky-wicket.blogspot.com/2008/03/my-slow-email-movement.html)<!-- HN:42213485:end --><!-- HN:42234097:start -->
* [42234097](https://news.social-protocols.org/stats?id=42234097) #6 12 points 7 comments -> [I Stopped Using Kubernetes. Our DevOps Team Is Happier Than Ever](https://blog.stackademic.com/i-stopped-using-kubernetes-our-devops-team-is-happier-than-ever-a5519f916ec0)<!-- HN:42234097:end --><!-- HN:42235887:start -->
* [42235887](https://news.social-protocols.org/stats?id=42235887) #20 3 points 0 comments -> [Adding Bluesky-powered comments to any website in five minutes](https://www.coryzue.com/writing/bluesky-comments/)<!-- HN:42235887:end --><!-- HN:42229299:start -->
* [42229299](https://news.social-protocols.org/stats?id=42229299) #12 302 points 96 comments -> [WireGuard: Beyond the most basic configuration](https://sloonz.github.io/posts/wireguard-beyond-basic-configuration/)<!-- HN:42229299:end --><!-- HN:42228472:start -->
* [42228472](https://news.social-protocols.org/stats?id=42228472) #12 240 points 5 comments -> [Full LLM training and evaluation toolkit](https://github.com/huggingface/smollm)<!-- HN:42228472:end --><!-- HN:42226953:start -->
* [42226953](https://news.social-protocols.org/stats?id=42226953) #14 263 points 356 comments -> [Charset="WTF-8"](https://wtf-8.xn--stpie-k0a81a.com/)<!-- HN:42226953:end --><!-- HN:42234174:start -->
* [42234174](https://news.social-protocols.org/stats?id=42234174) #24 44 points 9 comments -> [Raspberry Pi Pico 2 W on sale now at $7](https://www.raspberrypi.com/news/raspberry-pi-pico-2-w-on-sale-now/)<!-- HN:42234174:end --><!-- HN:42197918:start -->
* [42197918](https://news.social-protocols.org/stats?id=42197918) #20 30 points 0 comments -> [Dec(k)-Month 2: A Decker Game Jam](https://itch.io/jam/deck-month-2)<!-- HN:42197918:end --><!-- HN:42234147:start -->
* [42234147](https://news.social-protocols.org/stats?id=42234147) #8 98 points 11 comments -> [Judge's Investigation into Patent Troll Results in Criminal Referrals](https://www.eff.org/deeplinks/2024/11/judges-investigation-patent-troll-ip-edge-results-criminal-referrals)<!-- HN:42234147:end --><!-- HN:42212033:start -->
* [42212033](https://news.social-protocols.org/stats?id=42212033) #7 9 points 2 comments -> [Show HN: VR CPR app where the heart and lungs compress based on ur hand position](https://www.meta.com/experiences/heartbeat/7402671033184262/)<!-- HN:42212033:end --><!-- HN:42232715:start -->
* [42232715](https://news.social-protocols.org/stats?id=42232715) #19 29 points 14 comments -> [Computing Industry Doesn't Care about Performance: how I made things faster](https://deviantabstraction.com/2024/10/24/faster-computer/)<!-- HN:42232715:end --><!-- HN:42232289:start -->
* [42232289](https://news.social-protocols.org/stats?id=42232289) #12 139 points 60 comments -> [Wildlife monitoring technologies used to intimidate and spy on women](https://www.cam.ac.uk/research/news/wildlife-monitoring-technologies-used-to-intimidate-and-spy-on-women-study-finds)<!-- HN:42232289:end --><!-- HN:42231754:start -->
* [42231754](https://news.social-protocols.org/stats?id=42231754) #27 20 points 14 comments -> [Worldtimeapp.com Easy Timezone Converter](https://worldtimeapp.com/)<!-- HN:42231754:end --><!-- HN:42236574:start -->
* [42236574](https://news.social-protocols.org/stats?id=42236574) #8 5 points 1 comments -> [Bhutan Cashes Out $33.5B in Bitcoin, Still Holds $1.11B in BTC](https://finance.yahoo.com/news/bhutan-cashes-33-5b-bitcoin-081756733.html)<!-- HN:42236574:end --><!-- HN:42203290:start -->
* [42203290](https://news.social-protocols.org/stats?id=42203290) #14 8 points 3 comments -> [Code Search – Grep by Vercel](https://grep.app/)<!-- HN:42203290:end --><!-- HN:42171135:start -->
* [42171135](https://news.social-protocols.org/stats?id=42171135) #18 4 points 0 comments -> [The OSI Model Revisited (2023)](https://www.nathanhandy.blog/articles/osi-model-revisited.html)<!-- HN:42171135:end --><!-- HN:42237297:start -->
* [42237297](https://news.social-protocols.org/stats?id=42237297) #20 5 points 0 comments -> [Maths in Computer Science. What I wish I knew before starting university](https://www.sheffield.ac.uk/cs/blog/maths-computer-science)<!-- HN:42237297:end --><!-- HN:42235762:start -->
* [42235762](https://news.social-protocols.org/stats?id=42235762) #24 27 points 40 comments -> [What happened when a city started accepting - not evicting - homeless camps](https://www.bbc.com/news/articles/c3wq7l1lnqpo)<!-- HN:42235762:end --><!-- HN:42235015:start -->
* [42235015](https://news.social-protocols.org/stats?id=42235015) #13 11 points 0 comments -> [A Non-Technical Guide to Interpreting SHAP Analyses](https://www.aidancooper.co.uk/a-non-technical-guide-to-interpreting-shap-analyses/)<!-- HN:42235015:end --><!-- HN:42237014:start -->
* [42237014](https://news.social-protocols.org/stats?id=42237014) #28 4 points 0 comments -> [Do Coding Boot Camps Make Sense in an A.I. World?](https://www.nytimes.com/2024/11/24/business/computer-coding-boot-camps.html)<!-- HN:42237014:end --><!-- HN:42238531:start -->
* [42238531](https://news.social-protocols.org/stats?id=42238531) #14 22 points 35 comments -> [Bluesky is breaking the rules in the EU](https://www.theverge.com/2024/11/25/24305579/bluesky-breaking-european-union-rules-user-count)<!-- HN:42238531:end --><!-- HN:42239263:start -->
* [42239263](https://news.social-protocols.org/stats?id=42239263) #29 6 points 2 comments -> [Deno vs. Oracle: Canceling the JavaScript Trademark](https://deno.com/blog/deno-v-oracle)<!-- HN:42239263:end --><!-- HN:42180746:start -->
* [42180746](https://news.social-protocols.org/stats?id=42180746) #29 16 points 2 comments -> [The heirloom tomato org chart [video]](https://www.youtube.com/watch?v=I4vvBidQcck)<!-- HN:42180746:end --><!-- HN:42239319:start -->
* [42239319](https://news.social-protocols.org/stats?id=42239319) #16 6 points 1 comments -> [Ending Affirmative Action Harms Diversity Without Improving Academic Merit [pdf]](https://dl.acm.org/doi/pdf/10.1145/3689904.3694706)<!-- HN:42239319:end --><!-- HN:42240350:start -->
* [42240350](https://news.social-protocols.org/stats?id=42240350) #25 8 points 2 comments -> [Supreme Court wants US input on whether ISPs should be liable for users' piracy](https://arstechnica.com/tech-policy/2024/11/supreme-court-may-decide-whether-isps-must-terminate-users-accused-of-piracy/)<!-- HN:42240350:end --><!-- HN:42240316:start -->
* [42240316](https://news.social-protocols.org/stats?id=42240316) #26 4 points 0 comments -> [The next big arenas of competition](https://www.mckinsey.com/mgi/our-research/the-next-big-arenas-of-competition)<!-- HN:42240316:end --><!-- HN:42240938:start -->
* [42240938](https://news.social-protocols.org/stats?id=42240938) #26 4 points 0 comments -> [Nvidia claims a new AI audio generator can make sounds never heard before](https://www.theverge.com/2024/11/25/24305584/nvidia-fugatto-ai-audio-generator-music)<!-- HN:42240938:end --><!-- HN:42188795:start -->
* [42188795](https://news.social-protocols.org/stats?id=42188795) #29 -> [Hurricane Watch: The Peter McNeeley Website](http://www.hurricanepetermcneeley.com/)<!-- HN:42188795:end --><!-- HN:42240364:start -->
* [42240364](https://news.social-protocols.org/stats?id=42240364) #24 27 points 32 comments -> [Synapse still can't find its money](https://www.bloomberg.com/opinion/articles/2024-11-25/synapse-still-can-t-find-its-money)<!-- HN:42240364:end -->
#### **Tuesday, November 26, 2024**
<!-- HN:42241438:start -->
* [42241438](https://news.social-protocols.org/stats?id=42241438) #24 4 points 0 comments -> [Why Are All Tech Products Now Shit? [YouTube] [video]](https://www.youtube.com/watch?v=7Slib2bbMs4)<!-- HN:42241438:end --><!-- HN:42222773:start -->
* [42222773](https://news.social-protocols.org/stats?id=42222773) #21 -> [Apollo 68080: high performance 68k processor on FPGA](http://www.apollo-core.com/features.html)<!-- HN:42222773:end --><!-- HN:42183312:start -->
* [42183312](https://news.social-protocols.org/stats?id=42183312) #18 13 points 0 comments -> [Astra Dynamic Chunks: How We Saved by Redesigning a Key Part of Astra](https://slack.engineering/astra-dynamic-chunks-how-we-saved-by-redesigning-a-key-part-of-astra/)<!-- HN:42183312:end --><!-- HN:42163477:start -->
* [42163477](https://news.social-protocols.org/stats?id=42163477) #22 17 points 3 comments -> [Making waves through the Wallace Line](https://www.weatherzone.com.au/news/making-waves-through-the-wallace-line/1890090)<!-- HN:42163477:end --><!-- HN:42164058:start -->
* [42164058](https://news.social-protocols.org/stats?id=42164058) #27 89 points 30 comments -> [Transactional Object Storage?](https://blog.mbrt.dev/posts/transactional-object-storage/)<!-- HN:42164058:end --><!-- HN:42242825:start -->
* [42242825](https://news.social-protocols.org/stats?id=42242825) #11 -> [CEO fired 90% of his staff for missing a morning meeting](https://fortune.com/2024/11/25/ceo-fires-employees-slack-remote/)<!-- HN:42242825:end --><!-- HN:42243375:start -->
* [42243375](https://news.social-protocols.org/stats?id=42243375) #26 20 points 40 comments -> [Tesla appears to be building a teleoperations team for its robotaxi service](https://techcrunch.com/2024/11/25/tesla-appears-to-be-building-a-teleoperations-team-for-its-robotaxi-service/)<!-- HN:42243375:end --><!-- HN:42244183:start -->
* [42244183](https://news.social-protocols.org/stats?id=42244183) #14 28 points 0 comments -> [Linux 6.13 KVM Eliminates an "Awful Idea", Many x86_64 Improvements](https://www.phoronix.com/news/Linux-6.13-KVM)<!-- HN:42244183:end --><!-- HN:42213712:start -->
* [42213712](https://news.social-protocols.org/stats?id=42213712) #19 32 points 11 comments -> [New Comic Book: La BD de L'Avent, Le Lombard Publishing](https://www.davidrevoy.com/article1055/new-comic-book-la-bd-de-lavent-le-lombard-publishing)<!-- HN:42213712:end --><!-- HN:42243689:start -->
* [42243689](https://news.social-protocols.org/stats?id=42243689) #29 22 points 12 comments -> [Your docs are your infrastructure](https://stackoverflow.blog/2024/11/26/your-docs-are-your-infrastructure/)<!-- HN:42243689:end --><!-- HN:42245916:start -->
* [42245916](https://news.social-protocols.org/stats?id=42245916) #19 15 points 6 comments -> [Judge blocks Louisiana law that requires classrooms to display Ten Commandments](https://apnews.com/article/ten-commandments-law-blocked-public-schools-louisiana-87b3dde94e583fdbb9ecb26db42b0206)<!-- HN:42245916:end --><!-- HN:42246891:start -->
* [42246891](https://news.social-protocols.org/stats?id=42246891) #10 7 points 0 comments -> [Israel cracks down on Palestinian citizens who speak out against the war in Gaza](https://apnews.com/article/israel-gaza-war-palestinians-dissent-protest-849cc9250534b5bae98cea89e6f4d35e)<!-- HN:42246891:end -->