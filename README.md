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

#### **Wednesday, October 30, 2024**
<!-- HN:41988769:start -->
* [41988769](https://news.social-protocols.org/stats?id=41988769) #30 7 points 0 comments -> [OpenAI will start using AMD chips and could make its own AI hardware in 2026](https://www.theverge.com/2024/10/29/24282843/openai-custom-hardware-amd-nvidia-ai-chips)<!-- HN:41988769:end --><!-- HN:41991360:start -->
* [41991360](https://news.social-protocols.org/stats?id=41991360) #6 42 points 24 comments -> [H5N1 virus isolated from infected dairy worker is 100% lethal in ferrets](https://news.wisc.edu/h5n1-virus-isolated-from-infected-dairy-worker-is-100-lethal-in-ferrets-but-does-not-appear-to-be-circulating-in-nature-anymore/)<!-- HN:41991360:end --><!-- HN:41992007:start -->
* [41992007](https://news.social-protocols.org/stats?id=41992007) #29 12 points 0 comments -> [Project 25, and Why It's Bad](https://economixcomix.com/2024/10/18/project-2025-and-why-its-bad/)<!-- HN:41992007:end --><!-- HN:41992219:start -->
* [41992219](https://news.social-protocols.org/stats?id=41992219) #28 12 points 1 comments -> [More than a quarter of new code at Google is generated by AI](https://www.theverge.com/2024/10/29/24282757/google-new-code-generated-ai-q3-2024)<!-- HN:41992219:end --><!-- HN:41960385:start -->
* [41960385](https://news.social-protocols.org/stats?id=41960385) #21 3 points 1 comments -> [Show HN: Mahjong Dark Dimensions: Mahjong Dimensions Game Online](https://www.mahjongdarkdimensions.org/)<!-- HN:41960385:end --><!-- HN:41968337:start -->
* [41968337](https://news.social-protocols.org/stats?id=41968337) #16 8 points 0 comments -> [Py4web – Evolution of the Web2py Framework](https://py4web.com/)<!-- HN:41968337:end --><!-- HN:41994278:start -->
* [41994278](https://news.social-protocols.org/stats?id=41994278) #26 4 points 0 comments -> [Evaluating OpenAI Whisper's Hallucinations on Different Silences](https://www.sabrina.dev/p/evaluating-openai-whisper-s-hallucinations-on-different-silences)<!-- HN:41994278:end --><!-- HN:41994379:start -->
* [41994379](https://news.social-protocols.org/stats?id=41994379) #26 3 points 1 comments -> [Super Micro Computer plummets as auditor resigns](https://seekingalpha.com/news/4222850-super-micro-computer-plummets-as-auditor-resigns)<!-- HN:41994379:end --><!-- HN:41995660:start -->
* [41995660](https://news.social-protocols.org/stats?id=41995660) #29 5 points 0 comments -> [Down with Meritocracy (2001)](https://www.theguardian.com/politics/2001/jun/29/comment)<!-- HN:41995660:end --><!-- HN:41996461:start -->
* [41996461](https://news.social-protocols.org/stats?id=41996461) #28 4 points 1 comments -> [After non-endorsement, 250k subscribers cancel The Washington Post](https://www.washingtonpost.com/style/media/2024/10/29/washington-post-cancellations-number/)<!-- HN:41996461:end --><!-- HN:41941869:start -->
* [41941869](https://news.social-protocols.org/stats?id=41941869) #13 9 points 8 comments -> [Excel has a row limit of 1,048,576 rows and a column limit of 16,384 column](https://rowzero.io/blog/excel-row-limit)<!-- HN:41941869:end --><!-- HN:41997269:start -->
* [41997269](https://news.social-protocols.org/stats?id=41997269) #21 5 points 2 comments -> [Don't Bet Against the Dollar](https://www.bloomberg.com/opinion/articles/2024-10-29/don-t-bet-against-the-dollar)<!-- HN:41997269:end --><!-- HN:41998011:start -->
* [41998011](https://news.social-protocols.org/stats?id=41998011) #18 17 points 7 comments -> [Show HN: Supercharge Your Mac](https://sindresorhus.com/supercharge)<!-- HN:41998011:end --><!-- HN:41998453:start -->
* [41998453](https://news.social-protocols.org/stats?id=41998453) #4 23 points 1 comments -> [MrBeast Investigation](https://www.loock.io/blog/mrbeast-investigation)<!-- HN:41998453:end --><!-- HN:41992419:start -->
* [41992419](https://news.social-protocols.org/stats?id=41992419) #15 170 points 1 comments -> [AI Flame Graphs](https://www.brendangregg.com/blog//2024-10-29/ai-flame-graphs.html)<!-- HN:41992419:end --><!-- HN:41999701:start -->
* [41999701](https://news.social-protocols.org/stats?id=41999701) #5 4 points 0 comments -> [Meta Reports Third Quarter 2024 Results](https://investor.fb.com/investor-news/press-release-details/2024/Meta-Reports-Third-Quarter-2024-Results/default.aspx)<!-- HN:41999701:end --><!-- HN:41961846:start -->
* [41961846](https://news.social-protocols.org/stats?id=41961846) #23 7 points 1 comments -> [Norlha, the Luxury Yak Wool Brand Made by Nomads on the Tibetan Plateau](https://www.anothermag.com/fashion-beauty/12229/norlha-is-the-tibetan-label-changing-what-luxury-fashion-looks-like)<!-- HN:41961846:end --><!-- HN:42000242:start -->
* [42000242](https://news.social-protocols.org/stats?id=42000242) #26 16 points 7 comments -> [The realities of building an IPv6-only city – APNIC](https://blog.apnic.net/2024/10/29/the-realities-of-building-an-ipv6-only-city/)<!-- HN:42000242:end -->
#### **Thursday, October 31, 2024**
<!-- HN:42002994:start -->
* [42002994](https://news.social-protocols.org/stats?id=42002994) #9 11 points 8 comments -> [Astronomers Found Something Cold and Wet Near Uranus](https://gizmodo.com/astronomers-found-something-cold-and-wet-near-uranus-2000518316)<!-- HN:42002994:end --><!-- HN:41956213:start -->
* [41956213](https://news.social-protocols.org/stats?id=41956213) #12 58 points 31 comments -> [Cerebras Trains Llama Models to Leap over GPUs](https://www.nextplatform.com/2024/10/25/cerebras-trains-llama-models-to-leap-over-gpus/)<!-- HN:41956213:end --><!-- HN:42007933:start -->
* [42007933](https://news.social-protocols.org/stats?id=42007933) #18 3 points 0 comments -> [Windows Themes zero-day bug exposes users to NTLM credential theft](https://www.theregister.com/2024/10/30/zeroday_windows_themes/)<!-- HN:42007933:end --><!-- HN:42008424:start -->
* [42008424](https://news.social-protocols.org/stats?id=42008424) #1 -> [If The Economist had a vote, we would cast it for Kamala Harris](https://www.economist.com/leaders/2024/10/31/a-second-trump-term-comes-with-unacceptable-risks)<!-- HN:42008424:end -->
#### **Friday, November 1, 2024**
<!-- HN:42012807:start -->
* [42012807](https://news.social-protocols.org/stats?id=42012807) #7 12 points 6 comments -> [Researchers are questioning if ADHD should be seen as a disorder](https://www.economist.com/science-and-technology/2024/10/30/researchers-are-questioning-if-adhd-should-be-seen-as-a-disorder)<!-- HN:42012807:end --><!-- HN:42013117:start -->
* [42013117](https://news.social-protocols.org/stats?id=42013117) #5 9 points 1 comments -> [Technical Women and Women-in-Tech](https://deadsimpletech.com/blog/women_in_tech)<!-- HN:42013117:end --><!-- HN:41968940:start -->
* [41968940](https://news.social-protocols.org/stats?id=41968940) #18 8 points 4 comments -> [Bionic reading converter for ePub in Rust](https://github.com/mmatczuk/bioniconv)<!-- HN:41968940:end --><!-- HN:42013368:start -->
* [42013368](https://news.social-protocols.org/stats?id=42013368) #11 10 points 3 comments -> [Dawn: Designing Distributed Agents in a Worldwide Network](https://arxiv.org/abs/2410.22339)<!-- HN:42013368:end --><!-- HN:42014704:start -->
* [42014704](https://news.social-protocols.org/stats?id=42014704) #4 10 points 17 comments -> [Norway's Wealth Tax Is Backfiring. Are Americans Paying Attention?](https://thedailyeconomy.org/article/norways-wealth-tax-is-backfiring-are-americans-paying-attention/)<!-- HN:42014704:end --><!-- HN:42015323:start -->
* [42015323](https://news.social-protocols.org/stats?id=42015323) #12 28 points 24 comments -> [Men Arrested for Transcribing a Movie, Posting Details to a Website](https://torrentfreak.com/men-arrested-for-transcribing-godzilla-minus-one-posting-details-to-a-website-241031/)<!-- HN:42015323:end --><!-- HN:42014817:start -->
* [42014817](https://news.social-protocols.org/stats?id=42014817) #19 38 points 18 comments -> [It's been 30 years since Intel's infamous Pentium FDIV bug reared its ugly head](https://www.tomshardware.com/pc-components/cpus/its-been-30-years-since-intels-infamous-pentium-fdiv-bug-reared-its-ugly-head-a-math-bug-caused-intels-first-cpu-recall)<!-- HN:42014817:end --><!-- HN:42011193:start -->
* [42011193](https://news.social-protocols.org/stats?id=42011193) #22 402 points 294 comments -> [Wait Until 8th](https://www.waituntil8th.org)<!-- HN:42011193:end --><!-- HN:42015101:start -->
* [42015101](https://news.social-protocols.org/stats?id=42015101) #27 14 points 4 comments -> [KDE Linux](https://community.kde.org/KDE_Linux)<!-- HN:42015101:end --><!-- HN:42016372:start -->
* [42016372](https://news.social-protocols.org/stats?id=42016372) #11 5 points 0 comments -> [Want Windows 10 Security? That Will Be $30, Microsoft Says](https://www.forbes.com/sites/daveywinder/2024/11/01/want-windows-10-security-that-will-be-30-microsoft-says/)<!-- HN:42016372:end --><!-- HN:42016070:start -->
* [42016070](https://news.social-protocols.org/stats?id=42016070) #18 8 points 3 comments -> [Filter, Map, Reduce in 1.5 minutes [video]](https://www.youtube.com/watch?v=PZvHZJVeYdw)<!-- HN:42016070:end --><!-- HN:42016225:start -->
* [42016225](https://news.social-protocols.org/stats?id=42016225) #20 18 points 5 comments -> [Crowds gather in Dublin for fake Halloween parade posted on social media](https://www.thejournal.ie/dublin-fake-halloween-parade-6529584-Oct2024/)<!-- HN:42016225:end --><!-- HN:42017864:start -->
* [42017864](https://news.social-protocols.org/stats?id=42017864) #13 5 points 0 comments -> [After the Election, California Will Keep Moving the World Forward No Matter What](https://www.wired.com/story/california-will-keep-moving-the-world-forward/)<!-- HN:42017864:end --><!-- HN:42017163:start -->
* [42017163](https://news.social-protocols.org/stats?id=42017163) #18 8 points 0 comments -> [Analyzing Go Build Times (2023)](https://blog.howardjohn.info/posts/go-build-times/)<!-- HN:42017163:end --><!-- HN:42018247:start -->
* [42018247](https://news.social-protocols.org/stats?id=42018247) #4 11 points 2 comments -> [ADHD should not be treated as a disorder](https://www.economist.com/leaders/2024/10/30/adhd-should-not-be-treated-as-a-disorder)<!-- HN:42018247:end --><!-- HN:42018881:start -->
* [42018881](https://news.social-protocols.org/stats?id=42018881) #20 3 points 0 comments -> [Microsoft JDConf 2025: Building the future with Java](https://devblogs.microsoft.com/java/microsoft-jdconf-2025-building-the-future-with-java/)<!-- HN:42018881:end --><!-- HN:42020538:start -->
* [42020538](https://news.social-protocols.org/stats?id=42020538) #25 18 points 12 comments -> [Half of Young Voters Say They've Lied about Which Candidates They Support](https://www.msn.com/en-us/news/politics/half-of-young-voters-say-they-ve-lied-about-which-candidates-they-support-new-poll-finds/ar-AA1thZks)<!-- HN:42020538:end --><!-- HN:42020253:start -->
* [42020253](https://news.social-protocols.org/stats?id=42020253) #7 29 points 28 comments -> [The Elimination Strategy – Why More Makes Your SaaS Worth Less](https://slimsaas.com/blog/elimination-strategy/)<!-- HN:42020253:end --><!-- HN:42021823:start -->
* [42021823](https://news.social-protocols.org/stats?id=42021823) #28 5 points 0 comments -> [Vatican and Israel implicated in Italian hacking scandal](https://www.politico.eu/article/vatican-israel-italian-hacking-scandal-uk-lithuania-equalize/)<!-- HN:42021823:end -->
#### **Saturday, November 2, 2024**
<!-- HN:42022599:start -->
* [42022599](https://news.social-protocols.org/stats?id=42022599) #1 55 points 16 comments -> [Nvidia (NVDA) to Replace Intel in the Dow Jones Industrial Average](https://www.tipranks.com/news/nvidia-nvda-to-replace-intel-in-the-dow-jones-industrial-average)<!-- HN:42022599:end --><!-- HN:42022464:start -->
* [42022464](https://news.social-protocols.org/stats?id=42022464) #25 32 points 40 comments -> [Why Tech Employees Are Ready to Revolt](https://www.inc.com/joe-procopio/why-tech-employees-are-ready-to-revolt/90996313)<!-- HN:42022464:end --><!-- HN:42024598:start -->
* [42024598](https://news.social-protocols.org/stats?id=42024598) #5 4 points 1 comments -> [Tailwind simple responsive Navbar component to get you started on your projects](https://sharewind.onrender.com/users/sign_in)<!-- HN:42024598:end --><!-- HN:42025167:start -->
* [42025167](https://news.social-protocols.org/stats?id=42025167) #2 15 points 5 comments -> [Show HN: Open-Source Alternative to Google Sign-In That Respects Your Privacy](https://github.com/earthodev/eartho)<!-- HN:42025167:end --><!-- HN:42021237:start -->
* [42021237](https://news.social-protocols.org/stats?id=42021237) #11 262 points 205 comments -> [Linux on Apple Silicon with Alyssa Rosenzweig](https://softwareengineeringdaily.com/2024/10/15/linux-apple-silicon-alyssa-rosenzweig/)<!-- HN:42021237:end --><!-- HN:41957615:start -->
* [41957615](https://news.social-protocols.org/stats?id=41957615) #14 28 points 19 comments -> [Prompts are Programs](https://blog.sigplan.org/2024/10/22/prompts-are-programs/)<!-- HN:41957615:end --><!-- HN:42025123:start -->
* [42025123](https://news.social-protocols.org/stats?id=42025123) #17 15 points 40 comments -> [Rivian's chief software officer says in-car buttons are 'an anomaly'](https://techcrunch.com/2024/10/30/rivians-chief-software-officer-says-in-car-buttons-are-an-anomaly/)<!-- HN:42025123:end --><!-- HN:42019586:start -->
* [42019586](https://news.social-protocols.org/stats?id=42019586) #16 496 points 216 comments -> [Notepad++ is 21 years old](https://learnhub.top/celebrating-21-years-of-notepad-the-legendary-journey-of-our-favorite-text-editor/)<!-- HN:42019586:end --><!-- HN:42024501:start -->
* [42024501](https://news.social-protocols.org/stats?id=42024501) #23 17 points 3 comments -> [Highly cited engineer offers guaranteed publication in return for coauthorship](https://retractionwatch.com/2024/10/30/highly-cited-engineer-offers-guaranteed-publication-citations-in-return-for-coauthorship/)<!-- HN:42024501:end --><!-- HN:42016931:start -->
* [42016931](https://news.social-protocols.org/stats?id=42016931) #19 341 points 452 comments -> [Apple's M4 Max chip is the fastest single-core performer in consumer computing](https://twitter.com/LeakerApple/status/1852280766471999661)<!-- HN:42016931:end --><!-- HN:41982974:start -->
* [41982974](https://news.social-protocols.org/stats?id=41982974) #13 57 points 16 comments -> [The trailing dot in domain names matter](https://lacot.org/blog/2024/10/29/the-trailing-dot-in-domain-names-a-detail-that-is-often-poorly-managed.html)<!-- HN:41982974:end --><!-- HN:42025911:start -->
* [42025911](https://news.social-protocols.org/stats?id=42025911) #20 5 points 2 comments -> [Steam on Linux Marketshare Hits 2.0% for October, AMD Use Linux Approaches 75%](https://www.phoronix.com/news/Steam-October-2024-Numbers)<!-- HN:42025911:end --><!-- HN:42025256:start -->
* [42025256](https://news.social-protocols.org/stats?id=42025256) #24 15 points 9 comments -> [The International Space Station Has Been Leaking for Five Years](https://www.scientificamerican.com/article/the-international-space-station-has-been-leaking-for-five-years/)<!-- HN:42025256:end --><!-- HN:42025764:start -->
* [42025764](https://news.social-protocols.org/stats?id=42025764) #16 7 points 0 comments -> [Neurotechnology boosts memory without surgery](https://actu.epfl.ch/news/neurotechnology-boosts-memory-without-surgery/)<!-- HN:42025764:end --><!-- HN:42026167:start -->
* [42026167](https://news.social-protocols.org/stats?id=42026167) #6 14 points 1 comments -> [Saving Satoshi: An open-source game for learning Bitcoin programming](https://savingsatoshi.com/)<!-- HN:42026167:end --><!-- HN:42026770:start -->
* [42026770](https://news.social-protocols.org/stats?id=42026770) #8 25 points 11 comments -> [US Government memo shows Ethel Rosenberg was not a spy but executed her anyway](https://www.bloomberg.com/news/newsletters/2024-11-01/using-foia-to-lift-the-veil-of-secrecy-on-a-cold-war-secret)<!-- HN:42026770:end --><!-- HN:42027308:start -->
* [42027308](https://news.social-protocols.org/stats?id=42027308) #20 4 points 1 comments -> [Killing the Command message: should we use Events or Documents? (2007)](https://learn.microsoft.com/en-us/archive/blogs/nickmalik/killing-the-command-message-should-we-use-events-or-documents)<!-- HN:42027308:end --><!-- HN:42024342:start -->
* [42024342](https://news.social-protocols.org/stats?id=42024342) #7 117 points 2 comments -> [Cramming Solitaire onto a Nintendo E-Reader card](https://mattgreer.dev/blog/cramming-solitaire-onto-a-nintendo-ereader-card/)<!-- HN:42024342:end --><!-- HN:42028678:start -->
* [42028678](https://news.social-protocols.org/stats?id=42028678) #9 6 points 0 comments -> [Israel has destroyed or damaged nearly a quarter of buildings in Lebanon's south](https://www.washingtonpost.com/world/2024/10/31/israel-war-lebanon-south-destruction/)<!-- HN:42028678:end --><!-- HN:41990523:start -->
* [41990523](https://news.social-protocols.org/stats?id=41990523) #14 22 points 9 comments -> ['An incurable romantic': The boy who lived a secret life in World of Warcraft](https://www.bbc.com/culture/article/20241024-the-remarkable-story-of-the-boy-who-lived-a-secret-life-in-world-of-warcraft)<!-- HN:41990523:end --><!-- HN:41983964:start -->
* [41983964](https://news.social-protocols.org/stats?id=41983964) #14 3 points 0 comments -> [Mental Accounting Matters (1999) [pdf]](https://people.bath.ac.uk/mnsrf/Teaching%202011/Thaler-99.pdf)<!-- HN:41983964:end --><!-- HN:42005105:start -->
* [42005105](https://news.social-protocols.org/stats?id=42005105) #13 28 points 34 comments -> [Make It Ephemeral: Software Should Decay and Lose Data](https://lucumr.pocoo.org/2024/10/30/make-it-ephemeral/)<!-- HN:42005105:end -->
#### **Sunday, November 3, 2024**
<!-- HN:42030469:start -->
* [42030469](https://news.social-protocols.org/stats?id=42030469) #22 4 points 1 comments -> [Dead-heat poll results are astonishing – and improbable, these experts say](https://www.theguardian.com/us-news/2024/nov/02/what-polls-mean-so-far-trump-harris-election-voters)<!-- HN:42030469:end --><!-- HN:41978899:start -->
* [41978899](https://news.social-protocols.org/stats?id=41978899) #12 3 points 0 comments -> [Manage Database Clusters Without a Dedicated Operator on Kubernetes](https://kubeblocks.io/blog/how-to-manage-database-clusters-without-a-dedicated-operator)<!-- HN:41978899:end --><!-- HN:42030905:start -->
* [42030905](https://news.social-protocols.org/stats?id=42030905) #3 20 points 2 comments -> [PETA's Animal Shelter Continues as a Leader in Animal Death](https://www.lexology.com/library/detail.aspx?g=295a4113-b3be-42df-8585-665f496cc913)<!-- HN:42030905:end --><!-- HN:42030949:start -->
* [42030949](https://news.social-protocols.org/stats?id=42030949) #13 19 points 2 comments -> [A Golang Pipeline Abomination](https://poxate.com/blog/golang-pipeline-abomination)<!-- HN:42030949:end --><!-- HN:42031138:start -->
* [42031138](https://news.social-protocols.org/stats?id=42031138) #1 8 points 0 comments -> [The Prozac Era. What Next?](https://davidhealy.org/the-prozac-era-what-next/)<!-- HN:42031138:end --><!-- HN:42031476:start -->
* [42031476](https://news.social-protocols.org/stats?id=42031476) #15 5 points 0 comments -> [AI overwhelmingly prefers white and male job candidates](https://www.geekwire.com/2024/ai-overwhelmingly-prefers-white-and-male-job-candidates-in-new-test-of-resume-screening-bias/)<!-- HN:42031476:end --><!-- HN:42003136:start -->
* [42003136](https://news.social-protocols.org/stats?id=42003136) #16 19 points 3 comments -> [Writing Is a Visual Language](https://argumatronic.com/posts/2021-06-07-learning-to-write.html)<!-- HN:42003136:end --><!-- HN:42001762:start -->
* [42001762](https://news.social-protocols.org/stats?id=42001762) #21 6 points 1 comments -> [In search of Nirad Chaudhuri (2021)](https://thespectator.com/book-and-art/search-nirad-chaudhuri-india/)<!-- HN:42001762:end --><!-- HN:42032411:start -->
* [42032411](https://news.social-protocols.org/stats?id=42032411) #2 33 points 8 comments -> [Show HN: Kis.tools – A directory of tools that work](https://kis.tools)<!-- HN:42032411:end --><!-- HN:42032550:start -->
* [42032550](https://news.social-protocols.org/stats?id=42032550) #26 3 points 0 comments -> [Quantum Machines, Nvidia use machine learning to get closer to quantum computer](https://techcrunch.com/2024/11/02/quantum-machines-and-nvidia-use-machine-learning-to-get-closer-to-an-error-corrected-quantum-computer/)<!-- HN:42032550:end --><!-- HN:42031117:start -->
* [42031117](https://news.social-protocols.org/stats?id=42031117) #29 57 points 35 comments -> [Toyota to buy clean power from a $1.1B solar farm in Texas](https://electrek.co/2024/11/01/toyota-solar-farm-texas/)<!-- HN:42031117:end --><!-- HN:42032973:start -->
* [42032973](https://news.social-protocols.org/stats?id=42032973) #15 4 points 0 comments -> [Politicians not ambitious enough to save nature, say scientists](https://www.bbc.com/news/articles/cy9jdpep4ydo)<!-- HN:42032973:end --><!-- HN:42032035:start -->
* [42032035](https://news.social-protocols.org/stats?id=42032035) #12 22 points 0 comments -> [Advances in Zero-Knowledge Proofs: Bridging the Gap Between Theory and Practice [pdf]](https://www2.eecs.berkeley.edu/Pubs/TechRpts/2024/EECS-2024-35.pdf)<!-- HN:42032035:end --><!-- HN:42032693:start -->
* [42032693](https://news.social-protocols.org/stats?id=42032693) #2 35 points 22 comments -> [I Waited 10B Cycles and All I Got Was This Loading Screen](https://blog.preyneyv.dev/doing-less-with-more)<!-- HN:42032693:end --><!-- HN:42033238:start -->
* [42033238](https://news.social-protocols.org/stats?id=42033238) #11 7 points 1 comments -> [A new copyright rule lets McDonald's fix its own broken ice cream machines](https://www.npr.org/2024/11/02/g-s1-31893/mcdonalds-broken-ice-cream-machine-copyright-law)<!-- HN:42033238:end --><!-- HN:42035261:start -->
* [42035261](https://news.social-protocols.org/stats?id=42035261) #21 4 points 1 comments -> [FFmpeg: A 94x speed improvement demonstrated using handwritten assembly](https://twitter.com/FFmpeg/status/1852542388851601913)<!-- HN:42035261:end --><!-- HN:42035015:start -->
* [42035015](https://news.social-protocols.org/stats?id=42035015) #18 29 points 24 comments -> [$200M a year, 700k tons of rice, space tech: deal for North Korea in joining war](https://www.koreaherald.com/view.php?ud=20241103050116)<!-- HN:42035015:end --><!-- HN:42034974:start -->
* [42034974](https://news.social-protocols.org/stats?id=42034974) #21 6 points 1 comments -> [Commentary: Time to terminate the torture of time changes – Miami Herald](https://www.miamiherald.com/opinion/us-viewpoints/article294697994.html)<!-- HN:42034974:end --><!-- HN:42035699:start -->
* [42035699](https://news.social-protocols.org/stats?id=42035699) #26 6 points 0 comments -> [Apple's M4 Max is the single-core performance king in Geekbench 6](https://www.tomshardware.com/pc-components/cpus/apples-m4-max-is-the-single-core-performance-king-in-geekbench-6-m4-max-beats-the-core-ultra-9-285k-and-ryzen-9-9950x)<!-- HN:42035699:end --><!-- HN:42036488:start -->
* [42036488](https://news.social-protocols.org/stats?id=42036488) #29 5 points 0 comments -> [Let the internet vote: Trump or Harris](https://ip-vote.com/#trump_or_harris)<!-- HN:42036488:end -->
#### **Monday, November 4, 2024**
<!-- HN:41967396:start -->
* [41967396](https://news.social-protocols.org/stats?id=41967396) #5 10 points 0 comments -> [The Distracted Mind During a Crisis (2020)](https://distributed.blog/2020/04/29/adam-gazzaley-distracted-mind/)<!-- HN:41967396:end --><!-- HN:41978035:start -->
* [41978035](https://news.social-protocols.org/stats?id=41978035) #19 155 points 33 comments -> [Create block devices on your computer backed by Redstone Memory](https://github.com/williambl/blockblockdevice)<!-- HN:41978035:end --><!-- HN:42038004:start -->
* [42038004](https://news.social-protocols.org/stats?id=42038004) #16 22 points 40 comments -> [New better alterative to XML, JSON and YAML](https://xenondata.org)<!-- HN:42038004:end --><!-- HN:42036571:start -->
* [42036571](https://news.social-protocols.org/stats?id=42036571) #28 34 points 41 comments -> [Wasp Flamethrower Drone Attachment](https://throwflame.com/products/flamethrower-drone-kit/)<!-- HN:42036571:end --><!-- HN:42039406:start -->
* [42039406](https://news.social-protocols.org/stats?id=42039406) #14 24 points 11 comments -> [City council faces £216.5M loss over Oracle system debacle](https://www.theregister.com/2024/08/20/birmingham_oracle_cost/)<!-- HN:42039406:end --><!-- HN:42007138:start -->
* [42007138](https://news.social-protocols.org/stats?id=42007138) #13 18 points 3 comments -> [ASCII control characters in my terminal](https://jvns.ca/blog/2024/10/31/ascii-control-characters/)<!-- HN:42007138:end --><!-- HN:42036303:start -->
* [42036303](https://news.social-protocols.org/stats?id=42036303) #18 181 points 115 comments -> [Do you need Redis? PostgreSQL does queuing, locking, and pub/sub](https://spin.atomicobject.com/redis-postgresql/)<!-- HN:42036303:end --><!-- HN:42000752:start -->
* [42000752](https://news.social-protocols.org/stats?id=42000752) #12 6 points 0 comments -> [ClickPy – Python Package Analytics](https://clickpy.clickhouse.com/)<!-- HN:42000752:end --><!-- HN:42039454:start -->
* [42039454](https://news.social-protocols.org/stats?id=42039454) #25 3 points 0 comments -> [Soda Is Making a Comeback](https://www.cnn.com/2024/11/01/business/coke-dr-pepper-soda/index.html)<!-- HN:42039454:end --><!-- HN:42038821:start -->
* [42038821](https://news.social-protocols.org/stats?id=42038821) #23 13 points 0 comments -> [Internet Archive "Save Page Now" has been re-enabled](https://web.archive.org/save/)<!-- HN:42038821:end --><!-- HN:42034521:start -->
* [42034521](https://news.social-protocols.org/stats?id=42034521) #10 103 points 48 comments -> [ToolGit: A collection of scripts that extend Git with various sub-commands](https://github.com/ahmetsait/toolgit)<!-- HN:42034521:end --><!-- HN:42016816:start -->
* [42016816](https://news.social-protocols.org/stats?id=42016816) #21 51 points 0 comments -> [Programming NetBIOS on OS/2](https://www.os2museum.com/wp/programming-netbios-on-os-2/)<!-- HN:42016816:end --><!-- HN:42038911:start -->
* [42038911](https://news.social-protocols.org/stats?id=42038911) #22 13 points 2 comments -> [USB Insight Hub](https://www.crowdsupply.com/aerio-solutions/usb-insight-hub)<!-- HN:42038911:end --><!-- HN:42007586:start -->
* [42007586](https://news.social-protocols.org/stats?id=42007586) #16 3 points 0 comments -> [New Nintendo Music app could spell more trouble for illicit soundtrack posters](https://arstechnica.com/gaming/2024/10/will-the-new-nintendo-music-app-lead-to-more-dmca-takedowns-from-nintendo/)<!-- HN:42007586:end --><!-- HN:42035971:start -->
* [42035971](https://news.social-protocols.org/stats?id=42035971) #17 29 points 2 comments -> [Hermes 3 – Nous Research](https://nousresearch.com/hermes3/)<!-- HN:42035971:end --><!-- HN:42039574:start -->
* [42039574](https://news.social-protocols.org/stats?id=42039574) #23 5 points 1 comments -> [Earth endured over one million years of rain in the "Carnian Pluvial Event"](https://www.earth.com/news/earth-endured-a-million-years-of-rain-in-the-carnian-pluvial-event/)<!-- HN:42039574:end --><!-- HN:42038053:start -->
* [42038053](https://news.social-protocols.org/stats?id=42038053) #27 4 points 0 comments -> [BC7 optimal solid-color blocks](https://fgiesen.wordpress.com/2024/11/03/bc7-optimal-solid-color-blocks/)<!-- HN:42038053:end --><!-- HN:42040166:start -->
* [42040166](https://news.social-protocols.org/stats?id=42040166) #11 10 points 0 comments -> [Quincy Jones, Giant of American Music, Dies at 91](https://www.nytimes.com/2024/11/04/arts/music/quincy-jones-dead.html)<!-- HN:42040166:end --><!-- HN:42036476:start -->
* [42036476](https://news.social-protocols.org/stats?id=42036476) #16 42 points 10 comments -> [GJS: Node.js Like Runtime for Gnome](https://gjs.guide/)<!-- HN:42036476:end --><!-- HN:42040600:start -->
* [42040600](https://news.social-protocols.org/stats?id=42040600) #21 66 points 23 comments -> [Is yt-dlp/yt-dlp compromised?](https://github.com/yt-dlp/yt-dlp/releases)<!-- HN:42040600:end --><!-- HN:42006125:start -->
* [42006125](https://news.social-protocols.org/stats?id=42006125) #16 25 points 9 comments -> [Open-source wheeled biped robot](https://github.com/upkie/upkie)<!-- HN:42006125:end --><!-- HN:42041638:start -->
* [42041638](https://news.social-protocols.org/stats?id=42041638) #18 6 points 2 comments -> [Nearly half of Americans think members of the opposing political party are evil](https://phys.org/news/2024-10-americans-members-opposing-political-party.html)<!-- HN:42041638:end --><!-- HN:42041397:start -->
* [42041397](https://news.social-protocols.org/stats?id=42041397) #16 24 points 16 comments -> [Once Linux's Biggest Enemy: Darl McBride Dies and Nobody Notices](https://fossforce.com/2024/11/once-linuxs-biggest-enemy-darl-mcbride-dies-and-nobody-notices/)<!-- HN:42041397:end --><!-- HN:42020103:start -->
* [42020103](https://news.social-protocols.org/stats?id=42020103) #24 132 points 170 comments -> [Interview Gone Wrong](https://www.ashu1461.com/interview-gone-wrong/)<!-- HN:42020103:end --><!-- HN:42041500:start -->
* [42041500](https://news.social-protocols.org/stats?id=42041500) #28 18 points 6 comments -> [Large Language Models Are Changing Collective Intelligence Forever](https://www.cmu.edu/tepper/news/stories/2024/september/collective-intelligence-and-llms.html)<!-- HN:42041500:end --><!-- HN:42041205:start -->
* [42041205](https://news.social-protocols.org/stats?id=42041205) #24 12 points 2 comments -> [I feel that NAT is inevitable even with IPv6](https://utcc.utoronto.ca/~cks/space/blog/tech/IPv6AndStillHavingNAT)<!-- HN:42041205:end --><!-- HN:42042082:start -->
* [42042082](https://news.social-protocols.org/stats?id=42042082) #8 83 points 27 comments -> [New York Times Tech Workers Strike Ahead of Election](https://www.wsj.com/business/media/threat-of-new-york-times-tech-worker-strike-on-election-day-grows-174b1912)<!-- HN:42042082:end --><!-- HN:42042188:start -->
* [42042188](https://news.social-protocols.org/stats?id=42042188) #26 12 points 10 comments -> [One Company A/B Tested Hybrid Work. Here's What They Found](https://hbr.org/2024/10/one-company-a-b-tested-hybrid-work-heres-what-they-found)<!-- HN:42042188:end --><!-- HN:42043148:start -->
* [42043148](https://news.social-protocols.org/stats?id=42043148) #4 9 points 1 comments -> [ASCII Boobs in Your Codebase Won't Fix Themselves](https://shermanonsoftware.com/2024/11/04/ascii-boobs-in-your-codebase-wont-fix-themselves/)<!-- HN:42043148:end --><!-- HN:42018462:start -->
* [42018462](https://news.social-protocols.org/stats?id=42018462) #20 9 points 0 comments -> [Japan's Eightfold Fence](https://americanaffairsjournal.org/2017/08/japans-eightfold-fence/)<!-- HN:42018462:end --><!-- HN:42043108:start -->
* [42043108](https://news.social-protocols.org/stats?id=42043108) #26 6 points 0 comments -> [Amazon to cough $75B on capex in 2024, more next year](https://www.theregister.com/2024/11/01/amazon_75b_capex/)<!-- HN:42043108:end --><!-- HN:42043139:start -->
* [42043139](https://news.social-protocols.org/stats?id=42043139) #17 12 points 3 comments -> [Iceland embraced a shorter work week. Here's how it turned out](https://www.cnn.com/2024/10/25/business/iceland-shorter-working-week-economy/index.html)<!-- HN:42043139:end --><!-- HN:42046599:start -->
* [42046599](https://news.social-protocols.org/stats?id=42046599) #20 -> [Harris slams Speaker Mike Johnson for saying the GOP may repeal CHIPS Act](https://www.nbcnews.com/politics/kamala-harris/harris-slams-mike-johnson-gop-repeal-chips-act-rcna178513)<!-- HN:42046599:end --><!-- HN:42045212:start -->
* [42045212](https://news.social-protocols.org/stats?id=42045212) #6 171 points 2 comments -> [FFmpeg up to 94x performance boost after implementing handwritten assembly code](https://www.tomshardware.com/pc-components/cpus/ffmpeg-devs-boast-of-up-to-94x-performance-boost-after-implementing-handwritten-avx-512-assembly-code)<!-- HN:42045212:end -->
#### **Tuesday, November 5, 2024**
<!-- HN:42046956:start -->
* [42046956](https://news.social-protocols.org/stats?id=42046956) #9 10 points 8 comments -> [ReiserFS and the Art and Artist Problem](https://corecursive.com/reiserfs/)<!-- HN:42046956:end --><!-- HN:42047050:start -->
* [42047050](https://news.social-protocols.org/stats?id=42047050) #21 5 points 0 comments -> [After You Vote, Unplug](https://calnewport.com/blog/)<!-- HN:42047050:end --><!-- HN:42048795:start -->
* [42048795](https://news.social-protocols.org/stats?id=42048795) #17 6 points 1 comments -> [MrBeast's pitch decks get leaked](https://www.indiehackers.com/post/creators/mrbeasts-pitch-decks-get-leaked-and-they-aren-t-pretty-yJl2DI4mrKBcbtZixoB9)<!-- HN:42048795:end -->