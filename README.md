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

#### **Tuesday, March 11, 2025**
<!-- HN:43328035:start -->
* [43328035](https://news.social-protocols.org/stats?id=43328035) #30 6 points 0 comments -> [Bluesky's CEO on the Future of Social Media at SXSW [video]](https://www.youtube.com/watch?v=B7OwcXCE5Rg)<!-- HN:43328035:end --><!-- HN:43327395:start -->
* [43327395](https://news.social-protocols.org/stats?id=43327395) #20 10 points 7 comments -> [A 19yo woman graduated from high school with honors even though she can't read](https://www.ky3.com/2025/02/28/former-high-school-honors-student-who-says-she-cant-read-write-sues-district-where-she-graduated/)<!-- HN:43327395:end --><!-- HN:43328967:start -->
* [43328967](https://news.social-protocols.org/stats?id=43328967) #19 10 points 1 comments -> [Judicial Independence May Require Confrontation](https://www.lawfaremedia.org/article/judicial-independence-may-require-confrontation)<!-- HN:43328967:end --><!-- HN:43329261:start -->
* [43329261](https://news.social-protocols.org/stats?id=43329261) #4 13 points 2 comments -> [Leopards, Faces, etc.](https://blog.plover.com/politics/mangione.html)<!-- HN:43329261:end --><!-- HN:43329344:start -->
* [43329344](https://news.social-protocols.org/stats?id=43329344) #22 24 points 6 comments -> [Nasdaq halts high-speed trading service after regulatory pressure](https://www.ft.com/content/d062eb67-4fa7-4b72-bbf8-6cb27bef2202)<!-- HN:43329344:end --><!-- HN:43331231:start -->
* [43331231](https://news.social-protocols.org/stats?id=43331231) #14 52 points 21 comments -> [Carlos Slim Cancels $22B in Starlink Orders](https://cleantechnica.com/2025/03/10/billionaire-carlos-slim-cancels-22-billion-in-starlink-orders-due-to-elon-musks-outburst/)<!-- HN:43331231:end --><!-- HN:43331264:start -->
* [43331264](https://news.social-protocols.org/stats?id=43331264) #18 3 points 0 comments -> [Nvidia-backed AI firm signs $12B AI cloud deal with OpenAI](https://www.techinasia.com/news/nvidia-backed-ai-firm-signs-12b-ai-cloud-deal-with-openai)<!-- HN:43331264:end --><!-- HN:43331215:start -->
* [43331215](https://news.social-protocols.org/stats?id=43331215) #12 5 points 0 comments -> [COBOL Language Front End Merged for GCC 15 Compiler](https://www.phoronix.com/news/GCC-15-Merges-COBOL)<!-- HN:43331215:end --><!-- HN:43329795:start -->
* [43329795](https://news.social-protocols.org/stats?id=43329795) #24 40 points 3 comments -> [Meta must defend claim it stripped copyright info from Llama's training fodder](https://www.theregister.com/2025/03/11/meta_dmca_copyright_removal_case/)<!-- HN:43329795:end --><!-- HN:43323923:start -->
* [43323923](https://news.social-protocols.org/stats?id=43323923) #18 248 points 206 comments -> [Firmware update bricks HP printers, makes them unable to use HP cartridges](https://arstechnica.com/gadgets/2025/03/firmware-update-bricks-hp-printers-makes-them-unable-to-use-hp-cartridges/)<!-- HN:43323923:end --><!-- HN:43307541:start -->
* [43307541](https://news.social-protocols.org/stats?id=43307541) #21 83 points 35 comments -> [How to Implement a Cosine Similarity Function in TypeScript](https://alexop.dev/posts/how-to-implement-a-cosine-similarity-function-in-typescript-for-vector-comparison/)<!-- HN:43307541:end --><!-- HN:43332352:start -->
* [43332352](https://news.social-protocols.org/stats?id=43332352) #28 30 points 13 comments -> [A Practical Guide to Running Local LLMs](https://spin.atomicobject.com/running-local-llms/)<!-- HN:43332352:end --><!-- HN:43336554:start -->
* [43336554](https://news.social-protocols.org/stats?id=43336554) #16 4 points 0 comments -> [Steal My Tesla](http://stealmytesla.com/)<!-- HN:43336554:end -->
#### **Wednesday, March 12, 2025**
<!-- HN:43336872:start -->
* [43336872](https://news.social-protocols.org/stats?id=43336872) #25 59 points 42 comments -> [India's Battle to Control the Democracy Narrative](https://www.theplankmag.com/india-democracy-narrative)<!-- HN:43336872:end --><!-- HN:43339219:start -->
* [43339219](https://news.social-protocols.org/stats?id=43339219) #8 4 points 0 comments -> [Steal My Tesla](http://stealmytesla.com/)<!-- HN:43339219:end --><!-- HN:43298075:start -->
* [43298075](https://news.social-protocols.org/stats?id=43298075) #30 17 points 40 comments -> [Tesco trials giant trolley scales in Gateshead](https://www.bbc.co.uk/news/articles/c0rzvrjkklko)<!-- HN:43298075:end --><!-- HN:43340790:start -->
* [43340790](https://news.social-protocols.org/stats?id=43340790) #19 5 points 13 comments -> [Show HN: I made a movie recommendation app based on your mood](https://www.moodiemovie.top/)<!-- HN:43340790:end --><!-- HN:43340932:start -->
* [43340932](https://news.social-protocols.org/stats?id=43340932) #15 2 points 1 comments -> [No More Basic Cursive Fonts – Built Realistic Handwritten Signature Generator](https://handwrittensignaturegenerator.com/)<!-- HN:43340932:end --><!-- HN:43313902:start -->
* [43313902](https://news.social-protocols.org/stats?id=43313902) #24 18 points 2 comments -> [The State of Coherence in the Land of Type Classes](https://programming-journal.org/2025/10/15/)<!-- HN:43313902:end --><!-- HN:43341741:start -->
* [43341741](https://news.social-protocols.org/stats?id=43341741) #23 15 points 3 comments -> [Usaid staff told to shred and burn classified documents](https://www.bbc.com/news/articles/cjw2yywy3x7o)<!-- HN:43341741:end --><!-- HN:43339158:start -->
* [43339158](https://news.social-protocols.org/stats?id=43339158) #28 138 points 87 comments -> [Happy 10k Day](https://blog.comma.ai/happy10kday/)<!-- HN:43339158:end --><!-- HN:43341834:start -->
* [43341834](https://news.social-protocols.org/stats?id=43341834) #26 15 points 0 comments -> [TypeScript is being ported to Go – interview with Anders Hejlsberg](https://www.youtube.com/watch?v=10qowKUW82U)<!-- HN:43341834:end --><!-- HN:43343026:start -->
* [43343026](https://news.social-protocols.org/stats?id=43343026) #30 4 points 0 comments -> [Texas Instruments MSPM0C1104 is the smallest microcontroller](https://www.cnx-software.com/2025/03/12/texas-instruments-mspm0c1104-is-the-worlds-smallest-microcontroller-with-a-size-of-1-38mm2/)<!-- HN:43343026:end --><!-- HN:43307845:start -->
* [43307845](https://news.social-protocols.org/stats?id=43307845) #19 11 points 4 comments -> [A Committed Year](https://www.ramijames.com/thoughts/a-committed-year)<!-- HN:43307845:end --><!-- HN:43343497:start -->
* [43343497](https://news.social-protocols.org/stats?id=43343497) #28 6 points 0 comments -> [TSMC Pitches Intel Foundry JV to Nvidia, AMD and Broadcom](https://www.cnbc.com/2025/03/12/tsmc-pitched-intel-foundry-jv-to-nvidia-amd-and-broadcom-sources-say.html)<!-- HN:43343497:end --><!-- HN:43343839:start -->
* [43343839](https://news.social-protocols.org/stats?id=43343839) #6 4 points 3 comments -> [Crawl AI – A Web-Based Platform for Building Custom AI Assistants](https://www.crawlai.dev)<!-- HN:43343839:end --><!-- HN:43344002:start -->
* [43344002](https://news.social-protocols.org/stats?id=43344002) #21 4 points 0 comments -> [YouTube-transcript-API 1.0.0 released](https://github.com/jdepoix/youtube-transcript-api/releases/tag/v1.0.0)<!-- HN:43344002:end --><!-- HN:43343832:start -->
* [43343832](https://news.social-protocols.org/stats?id=43343832) #20 41 points 12 comments -> [A Perplexing JavaScript Parsing Puzzle](https://www.hillelwayne.com/post/javascript-puzzle/)<!-- HN:43343832:end -->
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
* [43385491](https://news.social-protocols.org/stats?id=43385491) #29 26 points 9 comments -> [Brown Medicine professor and doctor deported to Lebanon despite valid visa](https://www.nbcnews.com/news/us-news/brown-medicine-professor-doctor-deported-lebanon-valid-visa-court-fili-rcna196638)<!-- HN:43385491:end -->