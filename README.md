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

#### **Thursday, March 13, 2025**<!-- HN:43349901:start -->
* [43349901](https://news.social-protocols.org/stats?id=43349901) #3 54 points 9 comments -> [Doge Privacy Act Requests](https://jamieraskin.com/doge-privacy-act-requests/)<!-- HN:43349901:end --><!-- HN:43340662:start -->
* [43340662](https://news.social-protocols.org/stats?id=43340662) #22 224 points 228 comments -> [I use Cursor daily - here's how I avoid the garbage parts](https://www.nickcraux.com/blog/cursor-tips)<!-- HN:43340662:end --><!-- HN:43351985:start -->
* [43351985](https://news.social-protocols.org/stats?id=43351985) #25 21 points 3 comments -> [DOGE Makes Its Latest Errors Harder to Find](https://www.nytimes.com/2025/03/13/us/politics/doge-makes-its-latest-errors-harder-to-find.html)<!-- HN:43351985:end --><!-- HN:43352656:start -->
* [43352656](https://news.social-protocols.org/stats?id=43352656) #28 4 points 0 comments -> [Testing Begins for Community Notes on Facebook, Instagram and Threads](https://about.fb.com/news/2025/03/testing-begins-community-notes-facebook-instagram-threads/)<!-- HN:43352656:end --><!-- HN:43351949:start -->
* [43351949](https://news.social-protocols.org/stats?id=43351949) #25 59 points 15 comments -> [Meta goes to arbitrator to prevent whistleblower from promoting tell-all book](https://www.cnbc.com/2025/03/12/arbitrator-prohibits-meta-whistleblower-from-promoting-tell-all-book.html)<!-- HN:43351949:end --><!-- HN:43353052:start -->
* [43353052](https://news.social-protocols.org/stats?id=43353052) #25 6 points 4 comments -> [Are There Opportunities to Use OODA Loops in Your Software Project?](https://spin.atomicobject.com/ooda-loops-software-project/)<!-- HN:43353052:end --><!-- HN:43328835:start -->
* [43328835](https://news.social-protocols.org/stats?id=43328835) #18 32 points 27 comments -> [Photographers Are on Mission to Fix Wikipedia's Famously Bad Celebrity Portraits](https://www.404media.co/photographers-are-on-a-mission-to-fix-wikipedias-famously-bad-celebrity-portraits/)<!-- HN:43328835:end --><!-- HN:43353956:start -->
* [43353956](https://news.social-protocols.org/stats?id=43353956) #4 4 points 0 comments -> [Starting with Two Matrices [pdf]](https://web.mit.edu/18.06/www/Essays/starting2matrices.pdf)<!-- HN:43353956:end --><!-- HN:43354219:start -->
* [43354219](https://news.social-protocols.org/stats?id=43354219) #2 22 points 13 comments -> [Show HN: I built AI agents with CrewAI to automate my entire Gmail workflow](https://github.com/tonykipkemboi/crewai-gmail-automation)<!-- HN:43354219:end --><!-- HN:43355749:start -->
* [43355749](https://news.social-protocols.org/stats?id=43355749) #30 5 points 0 comments -> [Visual Studio: New, Simpler Solution File Format](https://devblogs.microsoft.com/visualstudio/new-simpler-solution-file-format/)<!-- HN:43355749:end --><!-- HN:43355976:start -->
* [43355976](https://news.social-protocols.org/stats?id=43355976) #23 7 points 0 comments -> [Why it makes sense for wealthier nations to help others decarbonize](https://www.nature.com/articles/d41586-025-00779-9)<!-- HN:43355976:end -->
#### **Friday, March 14, 2025**
<!-- HN:43358831:start -->
* [43358831](https://news.social-protocols.org/stats?id=43358831) #9 3 points 0 comments -> [When did you first start worrying for humankind?](https://theneuroscienceofeverydaylife.substack.com/p/when-did-you-first-start-worrying)<!-- HN:43358831:end --><!-- HN:43359006:start -->
* [43359006](https://news.social-protocols.org/stats?id=43359006) #12 3 points 0 comments -> [Show HN: Borderless Venmo](https://www.eth.cash/)<!-- HN:43359006:end --><!-- HN:43360541:start -->
* [43360541](https://news.social-protocols.org/stats?id=43360541) #15 15 points 10 comments -> [The End of YC](https://benn.substack.com/p/the-end-of-yc)<!-- HN:43360541:end --><!-- HN:43362081:start -->
* [43362081](https://news.social-protocols.org/stats?id=43362081) #23 10 points 0 comments -> [Stanford students want in on the military tech gold rush](https://sfstandard.com/2025/03/12/stanford-students-want-in-on-the-military-tech-gold-rush/)<!-- HN:43362081:end --><!-- HN:43335956:start -->
* [43335956](https://news.social-protocols.org/stats?id=43335956) #30 6 points 4 comments -> [Fridgeditions Demo "Children's Art the World Can Enjoy"](https://www.fridgeditions.com/)<!-- HN:43335956:end --><!-- HN:43363145:start -->
* [43363145](https://news.social-protocols.org/stats?id=43363145) #13 6 points 0 comments -> [Renowned US health research hub Johns Hopkins to slash 2k jobs](https://medicalxpress.com/news/2025-03-renowned-health-hub-johns-hopkins.html)<!-- HN:43363145:end --><!-- HN:43363148:start -->
* [43363148](https://news.social-protocols.org/stats?id=43363148) #25 8 points 1 comments -> [Gold pops above $3k/oz for first time in historic safe-haven rally](https://www.reuters.com/markets/commodities/gold-mounts-record-summit-eyes-3000-peak-2025-03-14/)<!-- HN:43363148:end --><!-- HN:43362847:start -->
* [43362847](https://news.social-protocols.org/stats?id=43362847) #5 8 points 3 comments -> [Show HN: I built a vector illustration generator](https://www.illustration.app/)<!-- HN:43362847:end --><!-- HN:43364524:start -->
* [43364524](https://news.social-protocols.org/stats?id=43364524) #15 8 points 1 comments -> [USA asks Sweden for help in the egg crisis](https://freshpost.substack.com/p/usa-asks-sweden-for-help-in-the-egg)<!-- HN:43364524:end --><!-- HN:43364088:start -->
* [43364088](https://news.social-protocols.org/stats?id=43364088) #17 7 points 1 comments -> [The Tyranny of Work or Why Are We Still Measured by Our Productivity?](https://anticapitalistmusings.com/2025/03/the-tyranny-of-work-or-why-are-we-still-measured-by-our-productivity/)<!-- HN:43364088:end --><!-- HN:43362339:start -->
* [43362339](https://news.social-protocols.org/stats?id=43362339) #18 35 points 1 comments -> [Athena landed in a dark crater where the temperature was minus 280° F](https://arstechnica.com/space/2025/03/athena-landed-in-a-dark-crater-where-the-temperature-was-minus-280-f/)<!-- HN:43362339:end -->
#### **Saturday, March 15, 2025**
<!-- HN:43368488:start -->
* [43368488](https://news.social-protocols.org/stats?id=43368488) #1 -> [Show HN: I lost 15% to Congress' lag, so I built a trade-sniping tool](https://politichook.com/)<!-- HN:43368488:end --><!-- HN:43368590:start -->
* [43368590](https://news.social-protocols.org/stats?id=43368590) #23 10 points 0 comments -> [Lazarus Group deceives developers with 6 new malicious NPM packages](https://cyberscoop.com/lazarus-group-north-korea-malicious-npm-packages-socket/)<!-- HN:43368590:end --><!-- HN:43369190:start -->
* [43369190](https://news.social-protocols.org/stats?id=43369190) #3 11 points 1 comments -> [Salting the Earth and the Vandalism of America](https://3quarksdaily.com/3quarksdaily/2025/03/salting-the-earth-and-the-vandalism-of-america.html)<!-- HN:43369190:end --><!-- HN:43369815:start -->
* [43369815](https://news.social-protocols.org/stats?id=43369815) #6 5 points 3 comments -> [A Proof of the Collatz Conjecture](https://arxiv.org/abs/2502.20642)<!-- HN:43369815:end --><!-- HN:43368765:start -->
* [43368765](https://news.social-protocols.org/stats?id=43368765) #17 23 points 11 comments -> [From QED to Neovim](https://l-o-o-s-e-d.net/qed-neovim)<!-- HN:43368765:end --><!-- HN:43370950:start -->
* [43370950](https://news.social-protocols.org/stats?id=43370950) #3 39 points 18 comments -> [Tesla is done in Germany: 94% say they won't buy a Tesla car](https://electrek.co/2025/03/14/tesla-is-done-in-germany-94-say-they-wont-buy-a-tesla-car/)<!-- HN:43370950:end --><!-- HN:43364016:start -->
* [43364016](https://news.social-protocols.org/stats?id=43364016) #23 580 points 503 comments -> [Samsung Q990D unresponsive after 1020 firmware update](https://us.community.samsung.com/t5/Home-Theater/Samsung-Q990D-unresponsive-after-1020-firmware-update/td-p/3168571)<!-- HN:43364016:end --><!-- HN:43368870:start -->
* [43368870](https://news.social-protocols.org/stats?id=43368870) #30 262 points 3 comments -> [Popular GitHub Action tj-actions/changed-files is compromised](https://semgrep.dev/blog/2025/popular-github-action-tj-actionschanged-files-is-compromised/)<!-- HN:43368870:end --><!-- HN:43335432:start -->
* [43335432](https://news.social-protocols.org/stats?id=43335432) #3 -> [Show HN: 715-999-7483.com, a website updated by calling the same phone number](https://715-999-7483.com/)<!-- HN:43335432:end --><!-- HN:43357420:start -->
* [43357420](https://news.social-protocols.org/stats?id=43357420) #20 17 points 8 comments -> [Sketch-Programming: A Minimalist Paradigm for Code Design](https://github.com/DmitryOlkhovoi/Sketch-programming)<!-- HN:43357420:end --><!-- HN:43373726:start -->
* [43373726](https://news.social-protocols.org/stats?id=43373726) #12 24 points 2 comments -> [LearnLM: An experimental task-specific model for learning science principles](https://ai.google.dev/gemini-api/docs/learnlm)<!-- HN:43373726:end --><!-- HN:43375371:start -->
* [43375371](https://news.social-protocols.org/stats?id=43375371) #26 3 points 0 comments -> [As We May Think (1945)](https://breckyunits.com/asWeMayThink.html)<!-- HN:43375371:end --><!-- HN:43375609:start -->
* [43375609](https://news.social-protocols.org/stats?id=43375609) #20 7 points 0 comments -> [Strings Attached: Talking about Russia's agenda for laws in cyberspace](https://bytesandborscht.com/strings-attached-talking-about-russias-agenda-for-laws-in-cyberspace/)<!-- HN:43375609:end -->
#### **Sunday, March 16, 2025**
<!-- HN:43376268:start -->
* [43376268](https://news.social-protocols.org/stats?id=43376268) #20 5 points 0 comments -> [Sound weapon used at protest in Belgrade [video]](https://www.youtube.com/watch?v=m0q-FVz6LK0)<!-- HN:43376268:end --><!-- HN:43376569:start -->
* [43376569](https://news.social-protocols.org/stats?id=43376569) #11 4 points 0 comments -> [Modern Agile is Stupid: on why all great ideas are killed by idiots](https://medium.com/@thecodingteacher_52591/modern-agile-is-stupid-on-why-all-great-ideas-are-killed-by-simple-minded-idiots-why-jira-kills-02080b937de2)<!-- HN:43376569:end --><!-- HN:43346843:start -->
* [43346843](https://news.social-protocols.org/stats?id=43346843) #16 8 points 1 comments -> [Show HN: I Made an Escape Room Themed Prompt Injection Challenge](https://pangea.cloud/landing/ai-escape-room/)<!-- HN:43346843:end --><!-- HN:43379099:start -->
* [43379099](https://news.social-protocols.org/stats?id=43379099) #30 6 points 0 comments -> [Origami measuring spoon incites fury after 9 years of Kickstarter delay hell](https://arstechnica.com/tech-policy/2025/03/scoop-origami-measuring-spoon-incites-fury-after-9-years-of-kickstarter-delay-hell/)<!-- HN:43379099:end --><!-- HN:43379764:start -->
* [43379764](https://news.social-protocols.org/stats?id=43379764) #25 6 points 0 comments -> [Life Altering PostgreSQL Patterns](https://mccue.dev/pages/3-11-25-life-altering-postgresql-patterns)<!-- HN:43379764:end --><!-- HN:43380069:start -->
* [43380069](https://news.social-protocols.org/stats?id=43380069) #26 10 points 0 comments -> [Media Blackout: America's Poorest Counties Devastated by Catastrophic Flooding](https://www.youtube.com/watch?v=gRvbdidqAhs)<!-- HN:43380069:end --><!-- HN:43378934:start -->
* [43378934](https://news.social-protocols.org/stats?id=43378934) #21 29 points 16 comments -> [Bio Cringe – The Obnoxious Social Media Bio Generator](https://biocringe.com/)<!-- HN:43378934:end --><!-- HN:43347482:start -->
* [43347482](https://news.social-protocols.org/stats?id=43347482) #20 3 points 0 comments -> [ScanSearch Integrates Workflow and Full OCR Scan](https://scansearch.com/)<!-- HN:43347482:end --><!-- HN:43381043:start -->
* [43381043](https://news.social-protocols.org/stats?id=43381043) #10 15 points 9 comments -> [US deports Venezuelans despite court order](https://www.bbc.com/news/articles/cp9yv1gnzyvo)<!-- HN:43381043:end --><!-- HN:43381390:start -->
* [43381390](https://news.social-protocols.org/stats?id=43381390) #22 16 points 2 comments -> ['People are angry': A vibe shift is happening across the workforce](https://www.cnbc.com/2025/03/16/a-vibe-shift-around-layoffs-is-happening-across-the-workforce.html)<!-- HN:43381390:end --><!-- HN:43382135:start -->
* [43382135](https://news.social-protocols.org/stats?id=43382135) #25 14 points 3 comments -> [Urbandead MMORPG (zombies and humans, made by 1 person) dead to moderarion laws](https://www.urbandead.com/)<!-- HN:43382135:end -->
#### **Monday, March 17, 2025**
<!-- HN:43384021:start -->
* [43384021](https://news.social-protocols.org/stats?id=43384021) #17 -> [X now monitors your DMs](https://bsky.app/profile/blueskywins.bsky.social/post/3lkjvonax7224)<!-- HN:43384021:end --><!-- HN:43360571:start -->
* [43360571](https://news.social-protocols.org/stats?id=43360571) #19 6 points 1 comments -> [Decrypting Encrypted files from Akira Ransomware using a bunch of GPUs](https://tinyhack.com/2025/03/13/decrypting-encrypted-files-from-akira-ransomware-linux-esxi-variant-2024-using-a-bunch-of-gpus/)<!-- HN:43360571:end --><!-- HN:43384047:start -->
* [43384047](https://news.social-protocols.org/stats?id=43384047) #4 16 points 2 comments -> [Leaving X](https://cacm.acm.org/opinion/leaving-x/)<!-- HN:43384047:end --><!-- HN:43384730:start -->
* [43384730](https://news.social-protocols.org/stats?id=43384730) #29 39 points 17 comments -> [Brown University Professor Is Deported Despite a Judge's Order](https://www.nytimes.com/2025/03/16/us/brown-university-rasha-alawieh-professor-deported.html)<!-- HN:43384730:end --><!-- HN:43358593:start -->
* [43358593](https://news.social-protocols.org/stats?id=43358593) #25 14 points 13 comments -> [My Journey Back to Math: A Short Review of MathAcademy](https://www.staszewski.xyz/blog/math-academy-review/)<!-- HN:43358593:end --><!-- HN:43385491:start -->
* [43385491](https://news.social-protocols.org/stats?id=43385491) #29 26 points 9 comments -> [Brown Medicine professor and doctor deported to Lebanon despite valid visa](https://www.nbcnews.com/news/us-news/brown-medicine-professor-doctor-deported-lebanon-valid-visa-court-fili-rcna196638)<!-- HN:43385491:end --><!-- HN:43386788:start -->
* [43386788](https://news.social-protocols.org/stats?id=43386788) #15 18 points 4 comments -> [Trump Derangement Syndrome](https://www.revisor.mn.gov/bills/text.php?number=SF2589&version=0&session=ls94&session_year=2025&session_number=0)<!-- HN:43386788:end --><!-- HN:43360564:start -->
* [43360564](https://news.social-protocols.org/stats?id=43360564) #21 3 points 1 comments -> [Cline: Autonomous Coding Agent for VS Code](https://github.com/cline/cline)<!-- HN:43360564:end --><!-- HN:43365878:start -->
* [43365878](https://news.social-protocols.org/stats?id=43365878) #14 12 points 0 comments -> [The Trials of an Exorcist, 1597](https://www.gethistories.com/p/the-trials-of-an-exorcist-1597)<!-- HN:43365878:end --><!-- HN:43387718:start -->
* [43387718](https://news.social-protocols.org/stats?id=43387718) #24 36 points 40 comments -> [22% Drop in Programming Jobs](https://www.washingtonpost.com/business/2025/03/14/programming-jobs-lost-artificial-intelligence/)<!-- HN:43387718:end --><!-- HN:43387936:start -->
* [43387936](https://news.social-protocols.org/stats?id=43387936) #16 13 points 1 comments -> [Bambu Labs launches 3D-printable toys with reusable electronics](https://www.theverge.com/news/631060/bambu-labs-makerworld-cyberbrick-3d-printed-toys-programmable-kickstarter)<!-- HN:43387936:end --><!-- HN:43378925:start -->
* [43378925](https://news.social-protocols.org/stats?id=43378925) #25 125 points 67 comments -> [Show HN: 10 teams are racing to build a pivotal tracker replacement](https://bye-tracker.net)<!-- HN:43378925:end --><!-- HN:43387381:start -->
* [43387381](https://news.social-protocols.org/stats?id=43387381) #29 12 points 6 comments -> [Starlink satellite part hit a Canadian farm when it fell from orbit](https://www.newscientist.com/article/2472334-starlink-satellite-part-hit-a-canadian-farm-when-it-fell-from-orbit/)<!-- HN:43387381:end --><!-- HN:43387906:start -->
* [43387906](https://news.social-protocols.org/stats?id=43387906) #23 5 points 1 comments -> [LLM generated code is like particleboard](https://so.dang.cool/blog/2023-12-30-llm-generated-code-is-like-particleboard.html)<!-- HN:43387906:end --><!-- HN:43387514:start -->
* [43387514](https://news.social-protocols.org/stats?id=43387514) #15 19 points 3 comments -> [Scientists discover first known animal that doesn't breathe](https://www.livescience.com/first-non-breathing-animal.html)<!-- HN:43387514:end --><!-- HN:43386856:start -->
* [43386856](https://news.social-protocols.org/stats?id=43386856) #12 44 points 7 comments -> [Pine64's RISC-V tablet now ships with a Debian-based Linux and improved hardware](https://liliputing.com/pine64s-risc-v-tablet-now-ships-with-a-debian-based-linux-distro-and-improved-hardware/)<!-- HN:43386856:end --><!-- HN:43385857:start -->
* [43385857](https://news.social-protocols.org/stats?id=43385857) #16 22 points 4 comments -> [Technical Mathematics (1954) [pdf]](https://sliderulemuseum.com/Manuals/TechnicalMathematics_RiceAndKnight.pdf)<!-- HN:43385857:end --><!-- HN:43381195:start -->
* [43381195](https://news.social-protocols.org/stats?id=43381195) #25 155 points 66 comments -> [Tcl Tutorial](https://www.tcl-lang.org/man/tcl8.5/tutorial/tcltutorial.html)<!-- HN:43381195:end --><!-- HN:43389056:start -->
* [43389056](https://news.social-protocols.org/stats?id=43389056) #20 6 points 1 comments -> [Harvard Will Make Tuition Free for More Students](https://www.nytimes.com/2025/03/17/us/politics/harvard-free-tuition.html)<!-- HN:43389056:end --><!-- HN:43391149:start -->
* [43391149](https://news.social-protocols.org/stats?id=43391149) #26 4 points 2 comments -> [Drones swarming sensitive national security sites](https://www.cbsnews.com/news/drone-swarms-national-security-60-minutes-transcript/)<!-- HN:43391149:end --><!-- HN:43364776:start -->
* [43364776](https://news.social-protocols.org/stats?id=43364776) #23 86 points 33 comments -> [Checkers written in Rust and exported to WASM](https://kevinalbs.com/checkers/)<!-- HN:43364776:end --><!-- HN:43391394:start -->
* [43391394](https://news.social-protocols.org/stats?id=43391394) #25 15 points 0 comments -> [Heritage Foundation and Allies Discuss Dismantling the EU](https://www.desmog.com/2025/03/14/heritage-foundation-project-2025-allies-mcc-ordo-iuris-discuss-dismantling-the-eu-european-union/)<!-- HN:43391394:end --><!-- HN:43393077:start -->
* [43393077](https://news.social-protocols.org/stats?id=43393077) #3 16 points 3 comments -> [Half of Canadians favour joining EU](https://www.westernstandard.news/news/revealed-half-of-canadians-favour-joining-eu-carney-says-canada-is-the-most-european-of-non-european-countries/63137)<!-- HN:43393077:end --><!-- HN:43393150:start -->
* [43393150](https://news.social-protocols.org/stats?id=43393150) #10 13 points 40 comments -> [The Best Size of a Laptop](https://gokmengorgen.net/2025/03/17/the-best-size-of-a-laptop/)<!-- HN:43393150:end -->
#### **Tuesday, March 18, 2025**<!-- HN:43394099:start -->
* [43394099](https://news.social-protocols.org/stats?id=43394099) #22 21 points 3 comments -> [Sobering Revenue Stats of 70K Mobile Apps Show Why Devs Beg for Subscriptions](https://arstechnica.com/gadgets/2025/03/sobering-revenue-stats-of-70k-mobile-apps-show-why-devs-beg-for-subscriptions/)<!-- HN:43394099:end --><!-- HN:43393772:start -->
* [43393772](https://news.social-protocols.org/stats?id=43393772) #20 6 points 0 comments -> [A Farewell from Cosmo Music](https://cosmomusic.ca/)<!-- HN:43393772:end --><!-- HN:43393079:start -->
* [43393079](https://news.social-protocols.org/stats?id=43393079) #28 220 points 194 comments -> [Amazon plans to lay off 14,000 managerial positions to save $3.5B yearly](https://techstartups.com/2025/03/17/amazon-to-lay-off-14000-managerial-positions-to-save-3-5-billion-annually/)<!-- HN:43393079:end --><!-- HN:43392303:start -->
* [43392303](https://news.social-protocols.org/stats?id=43392303) #27 45 points 73 comments -> [Occupry your next lease to negotiate a better deal](https://occupry.com)<!-- HN:43392303:end --><!-- HN:43394554:start -->
* [43394554](https://news.social-protocols.org/stats?id=43394554) #5 35 points 12 comments -> [How Many Lives Does US Foreign Aid Save?](https://www.cgdev.org/blog/how-many-lives-does-us-foreign-aid-save)<!-- HN:43394554:end --><!-- HN:43394931:start -->
* [43394931](https://news.social-protocols.org/stats?id=43394931) #27 4 points 0 comments -> [Webb Just Captured the First Direct Image of Carbon Dioxide on an Exoplanet](https://scitechdaily.com/webb-just-captured-the-first-direct-image-of-carbon-dioxide-on-an-exoplanet/)<!-- HN:43394931:end --><!-- HN:43395360:start -->
* [43395360](https://news.social-protocols.org/stats?id=43395360) #25 -> [Israel ends Gaza ceasefire. 86 Palestinians killed in minutes](https://www.cnn.com/world/live-news/gaza-israel-hamas-strikes-03-18-25/index.html)<!-- HN:43395360:end --><!-- HN:43378076:start -->
* [43378076](https://news.social-protocols.org/stats?id=43378076) #26 4 points 2 comments -> [Using Time Travel for Procrastination](https://medium.com/luminasticity/using-time-travel-for-procrastination-8c8ab4d0de4d)<!-- HN:43378076:end --><!-- HN:43397896:start -->
* [43397896](https://news.social-protocols.org/stats?id=43397896) #27 4 points 0 comments -> [At least 404 killed as Israel unleashes strikes on Gaza, breaking ceasefire](https://www.aljazeera.com/news/2025/3/18/israel-launches-gaza-assault-killing-hundreds-and-shattering-ceasefire)<!-- HN:43397896:end --><!-- HN:43398374:start -->
* [43398374](https://news.social-protocols.org/stats?id=43398374) #2 8 points 0 comments -> [Mistral AI is a research lab building the best open source models in the world](https://docs.mistral.ai/)<!-- HN:43398374:end --><!-- HN:43396808:start -->
* [43396808](https://news.social-protocols.org/stats?id=43396808) #9 9 points 9 comments -> [Show HN: I made a visual UI creation tool.](https://uiblocks.xyz)<!-- HN:43396808:end --><!-- HN:43399796:start -->
* [43399796](https://news.social-protocols.org/stats?id=43399796) #15 17 points 0 comments -> [More than 400 Palestinians killed in Israeli strikes on Gaza](https://www.nbcnews.com/news/world/live-blog/israel-hamas-war-hundreds-palestinians-killed-israeli-strikes-gaza-rcna196842)<!-- HN:43399796:end --><!-- HN:43397832:start -->
* [43397832](https://news.social-protocols.org/stats?id=43397832) #23 17 points 16 comments -> [Ownership of High-Risk ("Vicious") Dogs as a Marker for Deviant Behaviors](https://www.researchgate.net/publication/6729905_Ownership_of_High-Risk_Vicious_Dogs_as_a_Marker_for_Deviant_Behaviors)<!-- HN:43397832:end --><!-- HN:43398837:start -->
* [43398837](https://news.social-protocols.org/stats?id=43398837) #15 54 points 32 comments -> [AI crawlers haven't learned to play nice with websites](https://www.theregister.com/2025/03/18/ai_crawlers_sourcehut/)<!-- HN:43398837:end --><!-- HN:43400876:start -->
* [43400876](https://news.social-protocols.org/stats?id=43400876) #1 20 points 1 comments -> [Asahi Lina: I no longer feel safe working on Linux GPU drivers or Linux graphics](https://vt.social/@lina/114184129186555191)<!-- HN:43400876:end --><!-- HN:43400867:start -->
* [43400867](https://news.social-protocols.org/stats?id=43400867) #23 3 points 0 comments -> [Google's AI 'co-scientist' cracked 10-year superbug problem in just 2 days](https://www.livescience.com/technology/artificial-intelligence/googles-ai-co-scientist-cracked-10-year-superbug-problem-in-just-2-days)<!-- HN:43400867:end --><!-- HN:43398780:start -->
* [43398780](https://news.social-protocols.org/stats?id=43398780) #1 214 points 4 comments -> [Google announces agreement to acquire Wiz](https://blog.google/inside-google/company-announcements/google-agreement-acquire-wiz/)<!-- HN:43398780:end --><!-- HN:43404482:start -->
* [43404482](https://news.social-protocols.org/stats?id=43404482) #6 30 points 4 comments -> [Doge order leads to journal cancellations by U.S. agricultural library](https://www.science.org/content/article/doge-order-leads-journal-cancellations-u-s-agricultural-library)<!-- HN:43404482:end -->
#### **Wednesday, March 19, 2025**
<!-- HN:43406555:start -->
* [43406555](https://news.social-protocols.org/stats?id=43406555) #5 30 points 20 comments -> [Would You Rather Have Married Young?](https://www.metropolitanreview.org/p/would-you-rather-have-married-young)<!-- HN:43406555:end --><!-- HN:43407423:start -->
* [43407423](https://news.social-protocols.org/stats?id=43407423) #2 49 points 14 comments -> [Show HN: I made a worldwide sexual life dashboard](https://www.worldsexmap.com/)<!-- HN:43407423:end --><!-- HN:43408140:start -->
* [43408140](https://news.social-protocols.org/stats?id=43408140) #30 7 points 3 comments -> [Why Is White House Using Starlink to 'Improve Wi-Fi'?](https://www.msn.com/en-us/news/technology/wait-why-is-the-white-house-using-starlink-to-improve-wi-fi/ar-AA1BaYFi)<!-- HN:43408140:end --><!-- HN:43402115:start -->
* [43402115](https://news.social-protocols.org/stats?id=43402115) #18 430 points 113 comments -> [Amazon to kill off local Alexa processing, all voice requests shipped to cloud](https://www.theregister.com/2025/03/17/amazon_kills_on_device_alexa/)<!-- HN:43402115:end --><!-- HN:43403377:start -->
* [43403377](https://news.social-protocols.org/stats?id=43403377) #24 164 points 40 comments -> [PeerTube v7.1 Is Out](https://joinpeertube.org/news/release-7.1)<!-- HN:43403377:end --><!-- HN:43409044:start -->
* [43409044](https://news.social-protocols.org/stats?id=43409044) #24 3 points 0 comments -> [Ne Zha 2 is the most successful animated film – and I've no idea why](https://www.telegraph.co.uk/films/0/ne-aha-2-review-animation/)<!-- HN:43409044:end --><!-- HN:43409092:start -->
* [43409092](https://news.social-protocols.org/stats?id=43409092) #23 9 points 4 comments -> [Co-Doodle with Gemini](https://huggingface.co/spaces/Trudy/gemini-codrawing)<!-- HN:43409092:end --><!-- HN:43401421:start -->
* [43401421](https://news.social-protocols.org/stats?id=43401421) #19 164 points 45 comments -> [Preview: Amazon S3 Tables and Lakehouse in DuckDB](https://duckdb.org/2025/03/14/preview-amazon-s3-tables.html)<!-- HN:43401421:end --><!-- HN:43409281:start -->
* [43409281](https://news.social-protocols.org/stats?id=43409281) #29 4 points 0 comments -> [Nvidia DGX Spark](https://www.nvidia.com/en-us/products/workstations/dgx-spark/)<!-- HN:43409281:end --><!-- HN:43408564:start -->
* [43408564](https://news.social-protocols.org/stats?id=43408564) #21 16 points 10 comments -> [Digital Hygiene](https://karpathy.bearblog.dev/digital-hygiene/)<!-- HN:43408564:end --><!-- HN:43378571:start -->
* [43378571](https://news.social-protocols.org/stats?id=43378571) #27 144 points 42 comments -> [Rust on the RP2350 (2024)](https://thejpster.org.uk/blog/blog-2024-08-08/)<!-- HN:43378571:end --><!-- HN:43377910:start -->
* [43377910](https://news.social-protocols.org/stats?id=43377910) #14 12 points 3 comments -> [The Wasp That Lays Eggs Inside Caterpillars and Turns Them into Slaves](https://www.wired.com/2014/10/absurd-creature-week-glyptapanteles-wasp-caterpillar-bodyguard/)<!-- HN:43377910:end --><!-- HN:43410559:start -->
* [43410559](https://news.social-protocols.org/stats?id=43410559) #2 31 points 4 comments -> [This is How Tesla Will Die](https://www.planetearthandbeyond.co/p/this-is-how-tesla-will-die)<!-- HN:43410559:end --><!-- HN:43410858:start -->
* [43410858](https://news.social-protocols.org/stats?id=43410858) #4 16 points 2 comments -> [Tesla Will Die](https://www.planetearthandbeyond.co/p/this-is-how-tesla-will-die)<!-- HN:43410858:end -->