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

#### **Sunday, January 11, 2026**
<!-- HN:46572186:start -->
* [46572186](https://news.social-protocols.org/stats?id=46572186) #8 32 points 1 comments -> [Datadog, Thank You for Blocking Us](https://www.deductive.ai/blogs/datadog-thank-you-for-blocking-us)<!-- HN:46572186:end --><!-- HN:46479642:start -->
* [46479642](https://news.social-protocols.org/stats?id=46479642) #11 5 points 0 comments -> [MetaFun: Compile Haskell-like code to C++ template metaprograms](https://gergo.erdi.hu/projects/metafun/)<!-- HN:46479642:end --><!-- HN:46481060:start -->
* [46481060](https://news.social-protocols.org/stats?id=46481060) #13 35 points 7 comments -> [1970 Paris, cut into a grid and photographed](https://paris1970.jeantho.eu/index.html)<!-- HN:46481060:end --><!-- HN:46572593:start -->
* [46572593](https://news.social-protocols.org/stats?id=46572593) #27 8 points 6 comments -> [Show HN: PrintReadyBook](https://printreadybook.com/)<!-- HN:46572593:end --><!-- HN:46577869:start -->
* [46577869](https://news.social-protocols.org/stats?id=46577869) #28 35 points 17 comments -> ['F*ck You, Make Me' Without Saying the Words](https://daringfireball.net/2026/01/fuck_you_make_me_without_saying_the_words)<!-- HN:46577869:end -->
#### **Monday, January 12, 2026**<!-- HN:46514434:start -->
* [46514434](https://news.social-protocols.org/stats?id=46514434) #8 9 points 1 comments -> [Pyinfra: Turns Python code into shell commands and runs them on your servers](https://github.com/pyinfra-dev/pyinfra)<!-- HN:46514434:end --><!-- HN:46583731:start -->
* [46583731](https://news.social-protocols.org/stats?id=46583731) #23 -> [Powell has highest approval rating of political leaders among US adults (2025)](https://news.gallup.com/poll/700241/americans-end-year-gloomy-mood.aspx)<!-- HN:46583731:end --><!-- HN:46587033:start -->
* [46587033](https://news.social-protocols.org/stats?id=46587033) #26 28 points 14 comments -> [How to Build Reactive Declarative UI in Vanilla JavaScript](https://jsdev.space/howto/reactive-vanilla-js/)<!-- HN:46587033:end --><!-- HN:46589386:start -->
* [46589386](https://news.social-protocols.org/stats?id=46589386) #7 32 points 20 comments -> [Why Ontario Digital Service couldn't procure '98% safe' LLMs (15M Canadians)](https://rosetta-labs-erb.github.io/authority-boundary-ledger/)<!-- HN:46589386:end --><!-- HN:46590905:start -->
* [46590905](https://news.social-protocols.org/stats?id=46590905) #12 7 points 4 comments -> [Telegram recovery model allows permanent lockout after phishing](https://bugs.telegram.org/c/58477)<!-- HN:46590905:end --><!-- HN:46589489:start -->
* [46589489](https://news.social-protocols.org/stats?id=46589489) #21 164 points 19 comments -> [Statement from Federal Reserve Chair](https://www.federalreserve.gov/newsevents/speech/powell20260111a.htm?mod=ANLink)<!-- HN:46589489:end --><!-- HN:46592827:start -->
* [46592827](https://news.social-protocols.org/stats?id=46592827) #28 112 points 95 comments -> [X Didn't Fix Grok's 'Undressing' Problem. It Just Makes People Pay for It](https://www.wired.com/story/x-didnt-fix-groks-undressing-problem-it-just-makes-people-pay-for-it/)<!-- HN:46592827:end -->
#### **Tuesday, January 13, 2026**
<!-- HN:46595868:start -->
* [46595868](https://news.social-protocols.org/stats?id=46595868) #27 15 points 1 comments -> [We're all just content for ICE](https://www.garbageday.email/p/we-re-all-just-content-for-ice)<!-- HN:46595868:end --><!-- HN:46519839:start -->
* [46519839](https://news.social-protocols.org/stats?id=46519839) #16 69 points 24 comments -> [Perlsecret – Perl secret operators and constants](https://metacpan.org/dist/perlsecret/view/lib/perlsecret.pod)<!-- HN:46519839:end --><!-- HN:46525639:start -->
* [46525639](https://news.social-protocols.org/stats?id=46525639) #26 332 points 73 comments -> [Personal thoughts/notes from working on Zootopia 2](https://blog.yiningkarlli.com/2025/12/zootopia-2.html)<!-- HN:46525639:end --><!-- HN:46597505:start -->
* [46597505](https://news.social-protocols.org/stats?id=46597505) #30 28 points 12 comments -> [Day Fifteen of Iran's Nationwide Protests: Sharp Rise in Human Casualties](https://www.en-hrana.org/day-fifteen-of-irans-nationwide-protests-sharp-rise-in-human-casualties/)<!-- HN:46597505:end --><!-- HN:46598913:start -->
* [46598913](https://news.social-protocols.org/stats?id=46598913) #30 23 points 1 comments -> [Justice Delayed Is Justice Denied](https://en.wikipedia.org/wiki/Justice_delayed_is_justice_denied)<!-- HN:46598913:end --><!-- HN:46599604:start -->
* [46599604](https://news.social-protocols.org/stats?id=46599604) #5 10 points 7 comments -> [Junior devs don't know the red flags we spot in seconds and we never tell them](https://yourlead.dev)<!-- HN:46599604:end --><!-- HN:46598890:start -->
* [46598890](https://news.social-protocols.org/stats?id=46598890) #22 4 points 1 comments -> [The Homepage of Ron Goodwin](http://rongoodwin.co.uk/)<!-- HN:46598890:end --><!-- HN:46568769:start -->
* [46568769](https://news.social-protocols.org/stats?id=46568769) #6 47 points 127 comments -> [Is beef tallow making a comeback?](https://www.nytimes.com/2026/01/10/dining/beef-tallow-food-pyramid-rfk-jr.html)<!-- HN:46568769:end --><!-- HN:46602898:start -->
* [46602898](https://news.social-protocols.org/stats?id=46602898) #7 -> [Scott Adams Has Died](https://www.washingtonpost.com/obituaries/2026/01/13/scott-adams-dead-dilbert/)<!-- HN:46602898:end --><!-- HN:46602711:start -->
* [46602711](https://news.social-protocols.org/stats?id=46602711) #29 3 points 0 comments -> [Show HN: I Will Do Whatever to Get Primeagen to My Hackathon Stream](https://vibe.devpost.com/)<!-- HN:46602711:end --><!-- HN:46602857:start -->
* [46602857](https://news.social-protocols.org/stats?id=46602857) #12 33 points 7 comments -> [Scott Adams Dead at 68](https://en.wikipedia.org/wiki/Scott_Adams)<!-- HN:46602857:end --><!-- HN:46603772:start -->
* [46603772](https://news.social-protocols.org/stats?id=46603772) #9 13 points 9 comments -> [Show HN: DebtBomb – Make TODOs expire and automatically create Jira tickets](https://github.com/jobin-404/debtbomb)<!-- HN:46603772:end --><!-- HN:46604443:start -->
* [46604443](https://news.social-protocols.org/stats?id=46604443) #16 -> [Dilbert's Scott Adams Dies](https://www.inc.com/jennifer-conrad/scott-adams-dilbert-dies-at-68/91286247)<!-- HN:46604443:end --><!-- HN:46603431:start -->
* [46603431](https://news.social-protocols.org/stats?id=46603431) #19 405 points 3 comments -> ['Dilbert' creator Scott Adams dies at 68 after prostate cancer battle](https://www.usatoday.com/story/entertainment/celebrities/2026/01/13/scott-adams-dead-dilbert-creator-prostate-cancer/88158828007/)<!-- HN:46603431:end --><!-- HN:46607331:start -->
* [46607331](https://news.social-protocols.org/stats?id=46607331) #27 3 points 0 comments -> [Whistleblower leaks personal details of thousands of Border Patrol/ICE Agents](https://www.rawstory.com/ice-agents-data-leak/)<!-- HN:46607331:end -->
#### **Wednesday, January 14, 2026**<!-- HN:46551041:start -->
* [46551041](https://news.social-protocols.org/stats?id=46551041) #1 33 points 1 comments -> [There's a ridiculous amount of tech in a disposable vape](https://blog.jgc.org/2026/01/theres-ridiculous-amount-of-tech-in.html)<!-- HN:46551041:end --><!-- HN:46534632:start -->
* [46534632](https://news.social-protocols.org/stats?id=46534632) #11 62 points 1 comments -> [Japan's Skyscraper Factories (2021)](https://www.construction-physics.com/p/japans-skyscraper-factories)<!-- HN:46534632:end --><!-- HN:46612339:start -->
* [46612339](https://news.social-protocols.org/stats?id=46612339) #5 10 points 0 comments -> [Democracy Is Under Attack](https://10stepscampaign.org/)<!-- HN:46612339:end --><!-- HN:46614777:start -->
* [46614777](https://news.social-protocols.org/stats?id=46614777) #21 32 points 40 comments -> [UK secures record supply of offshore wind projects](https://www.bbc.co.uk/news/articles/cn9zyx150xdo)<!-- HN:46614777:end --><!-- HN:46614963:start -->
* [46614963](https://news.social-protocols.org/stats?id=46614963) #18 30 points 41 comments -> [UK Officials could face US entry ban over Twitter policy](https://parliamentnews.co.uk/uk-officials-could-face-us-entry-ban-over-x-policy)<!-- HN:46614963:end --><!-- HN:46615465:start -->
* [46615465](https://news.social-protocols.org/stats?id=46615465) #20 4 points 0 comments -> [Becoming a Whorelord: The Overly Analytical Guide to Escorting (2021)](https://knowingless.com/2021/10/19/becoming-a-whorelord-the-overly-analytical-guide-to-escorting/)<!-- HN:46615465:end --><!-- HN:46617108:start -->
* [46617108](https://news.social-protocols.org/stats?id=46617108) #19 25 points 15 comments -> [Denmark sends military reinforcements to Greenland](https://www.dr.dk/nyheder/indland/groenland/efter-pres-fra-usa-danmark-er-nu-begyndt-sende-militaere-forstaerkninger-til-groenland)<!-- HN:46617108:end --><!-- HN:46618513:start -->
* [46618513](https://news.social-protocols.org/stats?id=46618513) #26 -> [Six Prosecutors Quit over Push to Investigate ICE Shooting Victim's Widow](https://www.nytimes.com/2026/01/13/us/prosecutors-doj-resignation-ice-shooting.html)<!-- HN:46618513:end --><!-- HN:46617808:start -->
* [46617808](https://news.social-protocols.org/stats?id=46617808) #1 104 points 32 comments -> [Epic fined €1.1M over manipulating children through in app purchases](https://nos.nl/artikel/2598157-maker-fortnite-vangt-bot-bij-rechter-moet-boete-betalen-voor-manipuleren-kinderen)<!-- HN:46617808:end --><!-- HN:46618926:start -->
* [46618926](https://news.social-protocols.org/stats?id=46618926) #7 8 points 0 comments -> [OpenAI's Sora now sits at #71 in the US App Store and #108 on Play Store](https://spencerdailey.com/2026/01/14/openais-sora-sits-at-71-in-the-us-app-store-and-100-on-play-store-what-just-happened/)<!-- HN:46618926:end --><!-- HN:46618809:start -->
* [46618809](https://news.social-protocols.org/stats?id=46618809) #19 68 points 27 comments -> [US freezes visas for 75 nations](https://english.mathrubhumi.com/news/world/us-visa-ban-public-charge-bjbpzu02)<!-- HN:46618809:end --><!-- HN:46619275:start -->
* [46619275](https://news.social-protocols.org/stats?id=46619275) #20 23 points 13 comments -> [Dutch police have their own car stolen during car theft chase](https://dutchreview.com/news/dutch-police-car-stolen-during-chase/)<!-- HN:46619275:end --><!-- HN:46621136:start -->
* [46621136](https://news.social-protocols.org/stats?id=46621136) #29 14 points 4 comments -> [Verizon, AT&T, and T-Mobile are all having outages now](https://www.howtogeek.com/verizon-att-and-t-mobile-are-all-having-outages-right-now/)<!-- HN:46621136:end --><!-- HN:46620125:start -->
* [46620125](https://news.social-protocols.org/stats?id=46620125) #14 23 points 1 comments -> [Technical Analysis of Starlink Terminal GPS Spoofing/Jamming Detection in Iran](https://github.com/narimangharib/starlink-iran-gps-spoofing/blob/main/starlink-iran.md)<!-- HN:46620125:end -->
#### **Thursday, January 15, 2026**<!-- HN:46625766:start -->
* [46625766](https://news.social-protocols.org/stats?id=46625766) #19 33 points 18 comments -> [Billion-Dollar Idea Generator](https://www.pivotgpt.ceo/)<!-- HN:46625766:end --><!-- HN:46626826:start -->
* [46626826](https://news.social-protocols.org/stats?id=46626826) #3 25 points 40 comments -> [Is passive investment inflating a stockmarket bubble?](https://www.economist.com/finance-and-economics/2026/01/14/is-passive-investment-inflating-a-stockmarket-bubble)<!-- HN:46626826:end --><!-- HN:46628484:start -->
* [46628484](https://news.social-protocols.org/stats?id=46628484) #8 6 points 10 comments -> [Tech Writers Are About to Become Obsolete](https://kibbler.dev/blog/turn-your-codebase-into-a-knowledge-base)<!-- HN:46628484:end --><!-- HN:46628185:start -->
* [46628185](https://news.social-protocols.org/stats?id=46628185) #26 2 points 1 comments -> [Raising Kids After Knowledge Became a Commodity](https://liorz.github.io/blog/posts/fallacy-education-for-academic-excellence/)<!-- HN:46628185:end --><!-- HN:46632955:start -->
* [46632955](https://news.social-protocols.org/stats?id=46632955) #11 31 points 41 comments -> [Nvidia Reportedly Ends GeForce RTX 5070 Ti Production, RTX 5060 Ti 16 GB Next](https://www.techpowerup.com/345224/nvidia-reportedly-ends-geforce-rtx-5070-ti-production-rtx-5060-ti-16-gb-next)<!-- HN:46632955:end --><!-- HN:46634263:start -->
* [46634263](https://news.social-protocols.org/stats?id=46634263) #25 20 points 19 comments -> [European military personnel arrive in Greenland as Trump says US needs island](https://www.bbc.com/news/articles/cd0ydjvxpejo)<!-- HN:46634263:end --><!-- HN:46566065:start -->
* [46566065](https://news.social-protocols.org/stats?id=46566065) #13 13 points 3 comments -> [Investing with GIFs: A Visual Guide](https://www.ft.com/content/9b1ff0b8-a1e8-4869-8d61-620c5ed32d35)<!-- HN:46566065:end --><!-- HN:46635810:start -->
* [46635810](https://news.social-protocols.org/stats?id=46635810) #4 9 points 2 comments -> [AI Tool Archive](https://aitoolarchive.com/)<!-- HN:46635810:end --><!-- HN:46639805:start -->
* [46639805](https://news.social-protocols.org/stats?id=46639805) #27 3 points 1 comments -> [There Is No Green Transition, and This Book Explains Why](https://www.highspeed.blog/too-much-more/)<!-- HN:46639805:end --><!-- HN:46547400:start -->
* [46547400](https://news.social-protocols.org/stats?id=46547400) #30 20 points 2 comments -> [Virginia Faulkner: Writer, editor, and ghostwriter?](https://lithub.com/virginia-faulkner-writer-editor-and-ghostwriter/)<!-- HN:46547400:end -->
#### **Friday, January 16, 2026**
<!-- HN:46641007:start -->
* [46641007](https://news.social-protocols.org/stats?id=46641007) #27 11 points 2 comments -> [An Unfolding Scientific Revolution in Cosmology](https://economicsfromthetopdown.com/2026/01/15/an-unfolding-scientific-revolution-in-cosmology/)<!-- HN:46641007:end --><!-- HN:46643070:start -->
* [46643070](https://news.social-protocols.org/stats?id=46643070) #2 35 points 42 comments -> [The Myth of the ThinkPad](https://innovintageblog.wordpress.com/2026/01/08/the-myth-of-the-thinkpad/)<!-- HN:46643070:end --><!-- HN:46647338:start -->
* [46647338](https://news.social-protocols.org/stats?id=46647338) #9 -> [I mass-deleted 200 lines of AI-generated code yesterday. All broken](https://ward-eight.vercel.app/)<!-- HN:46647338:end --><!-- HN:46646490:start -->
* [46646490](https://news.social-protocols.org/stats?id=46646490) #30 10 points 2 comments -> [Astro is joining Cloudflare](https://blog.cloudflare.com/astro-joins-cloudflare/)<!-- HN:46646490:end --><!-- HN:46648978:start -->
* [46648978](https://news.social-protocols.org/stats?id=46648978) #26 43 points 12 comments -> [ICE takes back into custody man released for violation of rights](https://apnews.com/article/minnesota-immigration-crackdown-25e46910fcc62fbf5ab341905af9891c)<!-- HN:46648978:end --><!-- HN:46652299:start -->
* [46652299](https://news.social-protocols.org/stats?id=46652299) #7 8 points 8 comments -> [The Engineer to Executive Translation Layer](https://refactoring.fm/p/the-engineer-executive-translation)<!-- HN:46652299:end -->
#### **Saturday, January 17, 2026**<!-- HN:46655034:start -->
* [46655034](https://news.social-protocols.org/stats?id=46655034) #23 5 points 0 comments -> [Gas Town is a glimpse into the future](https://johncodes.com/archive/2026/01-16-a-glimpse-into-the-future/)<!-- HN:46655034:end --><!-- HN:46653388:start -->
* [46653388](https://news.social-protocols.org/stats?id=46653388) #6 53 points 5 comments -> [The Dilbert Afterlife](https://www.astralcodexten.com/p/the-dilbert-afterlife)<!-- HN:46653388:end --><!-- HN:46657947:start -->
* [46657947](https://news.social-protocols.org/stats?id=46657947) #10 5 points 0 comments -> [The App You Should Be Building Is You](https://www.gnanaguru.com/p/the-app-you-should-be-building-is)<!-- HN:46657947:end --><!-- HN:46577968:start -->
* [46577968](https://news.social-protocols.org/stats?id=46577968) #20 22 points 14 comments -> [Finding and Fixing a 50k Goroutine Leak That Nearly Killed Production](https://skoredin.pro/blog/golang/goroutine-leak-debugging)<!-- HN:46577968:end --><!-- HN:46658166:start -->
* [46658166](https://news.social-protocols.org/stats?id=46658166) #4 3 points 1 comments -> [Rust for C Programmers](https://rust-for-c-programmers.com)<!-- HN:46658166:end -->