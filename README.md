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

#### **Friday, September 20, 2024**
<!-- HN:41540542:start -->
* [41540542](https://news.social-protocols.org/stats?id=41540542) #12 170 points 104 comments -> [MicroPython on Flipper Zero](https://lab.flipper.net/apps/upython)<!-- HN:41540542:end --><!-- HN:41548551:start -->
* [41548551](https://news.social-protocols.org/stats?id=41548551) #21 5 points 0 comments -> [Sculpture commemorates 16th century drowning that inspired Shakespeare](https://www.theguardian.com/artanddesign/2024/sep/15/river-stour-sculpture-commemorates-16th-century-drowning-that-inspired-shakespeare)<!-- HN:41548551:end --><!-- HN:41598274:start -->
* [41598274](https://news.social-protocols.org/stats?id=41598274) #21 15 points 5 comments -> [How Stripe Built One of Silicon Valley’s Best Engineering Teams](https://review.firstround.com/how-stripe-built-one-of-silicon-valleys-best-engineering-teams/)<!-- HN:41598274:end --><!-- HN:41599259:start -->
* [41599259](https://news.social-protocols.org/stats?id=41599259) #19 8 points 3 comments -> [Pov: Living in My Car in SF](https://www.youtube.com/watch?v=tonG-OufefQ)<!-- HN:41599259:end --><!-- HN:41560225:start -->
* [41560225](https://news.social-protocols.org/stats?id=41560225) #7 33 points 22 comments -> [Show HN: Microtonal Piano](https://osolmaz.github.io/microtonal-piano/)<!-- HN:41560225:end --><!-- HN:41598170:start -->
* [41598170](https://news.social-protocols.org/stats?id=41598170) #19 176 points 92 comments -> [Why Apple Uses JPEG XL in the iPhone 16 and What It Means for Your Photos](https://petapixel.com/2024/09/18/why-apple-uses-jpeg-xl-in-the-iphone-16-and-what-it-means-for-your-photos/)<!-- HN:41598170:end --><!-- HN:41600170:start -->
* [41600170](https://news.social-protocols.org/stats?id=41600170) #23 16 points 6 comments -> [Young women are starting to leave men behind](https://www.ft.com/content/17606f25-1d03-4f37-b7f4-f39989af9bde)<!-- HN:41600170:end --><!-- HN:41600483:start -->
* [41600483](https://news.social-protocols.org/stats?id=41600483) #28 3 points 0 comments -> [30th-anniversary limited-run PS5 and PS5 Pro bring back mid-'90s gray plastic](https://arstechnica.com/gaming/2024/09/30th-anniversary-limited-run-ps5-and-ps5-pro-bring-back-mid-90s-gray-plastic/)<!-- HN:41600483:end --><!-- HN:41602181:start -->
* [41602181](https://news.social-protocols.org/stats?id=41602181) #17 7 points 0 comments -> [A year in exile: The fading hopes of Nagorno-Karabakh Armenians](https://www.newarab.com/analysis/year-exile-fading-hopes-nagorno-karabakh-armenians)<!-- HN:41602181:end --><!-- HN:41602024:start -->
* [41602024](https://news.social-protocols.org/stats?id=41602024) #23 10 points 14 comments -> [Dry Cask Storage](https://en.wikipedia.org/wiki/Dry_cask_storage)<!-- HN:41602024:end --><!-- HN:41603237:start -->
* [41603237](https://news.social-protocols.org/stats?id=41603237) #18 3 points 0 comments -> [Amazon says workers need to be in the office. Most of Silicon Valley disagrees](https://www.ft.com/content/c7b82efc-9174-4fc0-8f06-6c6a884d5105)<!-- HN:41603237:end --><!-- HN:41602877:start -->
* [41602877](https://news.social-protocols.org/stats?id=41602877) #12 20 points 6 comments -> [Comedian John Mulaney brutally roasts SF techies at Dreamforce](https://sfstandard.com/2024/09/19/comedian-john-mulaney-brutally-roasts-sf-techies-and-ai-at-dreamforce/)<!-- HN:41602877:end --><!-- HN:41603448:start -->
* [41603448](https://news.social-protocols.org/stats?id=41603448) #12 5 points 1 comments -> [Researcher reveals 'catastrophic' security flaw in the Arc browser](https://www.theverge.com/2024/9/20/24249919/arc-browser-boost-firebase-vulnerability-patched)<!-- HN:41603448:end --><!-- HN:41604241:start -->
* [41604241](https://news.social-protocols.org/stats?id=41604241) #26 6 points 2 comments -> [Updates to the Google Photos API](https://developers.google.com/photos/support/updates)<!-- HN:41604241:end --><!-- HN:41604161:start -->
* [41604161](https://news.social-protocols.org/stats?id=41604161) #30 20 points 12 comments -> [Evidence points to Wuhan market as source of Covid-19 outbreak](https://www.newscientist.com/article/2448671-evidence-points-to-wuhan-market-as-source-of-covid-19-outbreak/)<!-- HN:41604161:end --><!-- HN:41603920:start -->
* [41603920](https://news.social-protocols.org/stats?id=41603920) #23 13 points 4 comments -> [Re-opened Three Mile Island will power AI data centers under new deal](https://arstechnica.com/ai/2024/09/re-opened-three-mile-island-will-power-ai-data-centers-under-new-deal/)<!-- HN:41603920:end --><!-- HN:41605202:start -->
* [41605202](https://news.social-protocols.org/stats?id=41605202) #24 6 points 1 comments -> [Qualcomm Approached Intel About a Takeover in Recent Days](https://www.wsj.com/arts-culture/books/graveyard-of-the-pacific-review-broken-by-the-waves-883b6c3a)<!-- HN:41605202:end --><!-- HN:41550404:start -->
* [41550404](https://news.social-protocols.org/stats?id=41550404) #30 14 points 5 comments -> [Ultrasonic Chips Could Cut Interference in the IoT](https://spectrum.ieee.org/topological-acoustics)<!-- HN:41550404:end -->
#### **Saturday, September 21, 2024**
<!-- HN:41552849:start -->
* [41552849](https://news.social-protocols.org/stats?id=41552849) #8 17 points 4 comments -> [A picture of Earth through time](https://blog.google/products/earth/a-picture-of-earth-through-time/)<!-- HN:41552849:end --><!-- HN:41607569:start -->
* [41607569](https://news.social-protocols.org/stats?id=41607569) #19 41 points 27 comments -> [Ruby on Rails continues to thrive](https://blogyet.com/blog_posts/why-ruby-on-rails-will-never-die-a-veteran-coder-s-perspective)<!-- HN:41607569:end --><!-- HN:41606530:start -->
* [41606530](https://news.social-protocols.org/stats?id=41606530) #22 187 points 115 comments -> [Apple Shares Full iPhone 16 and iPhone 16 Pro Repair Manuals](https://www.macrumors.com/2024/09/20/iphone-16-repair-manual/)<!-- HN:41606530:end --><!-- HN:41607166:start -->
* [41607166](https://news.social-protocols.org/stats?id=41607166) #28 103 points 60 comments -> [Inside Annapurna Interactive's Mass Walkout](https://www.ign.com/articles/what-the-heck-has-been-going-on-at-annapurna-interactive-an-investigation)<!-- HN:41607166:end --><!-- HN:41609758:start -->
* [41609758](https://news.social-protocols.org/stats?id=41609758) #17 5 points 1 comments -> [Glacier National Park replacing signs that predicted glaciers would gone by 2020](https://www.cnn.com/2020/01/08/us/glaciers-national-park-2020-trnd/index.html)<!-- HN:41609758:end --><!-- HN:41569284:start -->
* [41569284](https://news.social-protocols.org/stats?id=41569284) #30 13 points 5 comments -> [Gibbons move with rhythm and intention. Dare we say style?](https://www.nytimes.com/2024/09/14/science/gibbons-dancing-apes.html)<!-- HN:41569284:end --><!-- HN:41612584:start -->
* [41612584](https://news.social-protocols.org/stats?id=41612584) #13 5 points 1 comments -> [The Pain of Travelling While Palestinian](https://www.newyorker.com/culture/the-weekend-essay/the-pain-of-travelling-while-palestinian)<!-- HN:41612584:end --><!-- HN:41613025:start -->
* [41613025](https://news.social-protocols.org/stats?id=41613025) #30 16 points 10 comments -> [Why I'm Leaving Meta](https://medium.com/@peravi8126/why-im-leaving-meta-c3ab43491204)<!-- HN:41613025:end -->
#### **Sunday, September 22, 2024**
<!-- HN:41567862:start -->
* [41567862](https://news.social-protocols.org/stats?id=41567862) #14 24 points 3 comments -> [A Simple Spaced Repetition Algo (In Ugly SQL)](https://taylor.town/flashcasts-srs-algo)<!-- HN:41567862:end --><!-- HN:41616612:start -->
* [41616612](https://news.social-protocols.org/stats?id=41616612) #2 16 points 12 comments -> [Hacker Leaks 3.3B Emails and Yes Every Single One Is Unique](https://hackerdose.com/privacy/massive-3-3-billion-emails-leaked/)<!-- HN:41616612:end --><!-- HN:41616706:start -->
* [41616706](https://news.social-protocols.org/stats?id=41616706) #7 9 points 1 comments -> [Fukuppy](https://en.wikipedia.org/wiki/Fukuppy)<!-- HN:41616706:end --><!-- HN:41609694:start -->
* [41609694](https://news.social-protocols.org/stats?id=41609694) #20 102 points 31 comments -> [Social Initiation](https://socialcommunication.truman.edu/attitudes-emotions/social-initiation/)<!-- HN:41609694:end --><!-- HN:41616799:start -->
* [41616799](https://news.social-protocols.org/stats?id=41616799) #22 4 points 1 comments -> [A 23-person Lego team built a 1:1 scale working McLaren P1 using 342,817 pieces](https://www.lego.com/en-us/aboutus/news/2024/september/lego-technic-ultimate-challenge)<!-- HN:41616799:end --><!-- HN:41616540:start -->
* [41616540](https://news.social-protocols.org/stats?id=41616540) #26 42 points 23 comments -> [Bruce Schneier: Israel's Pager Attacks Have Changed the World](https://www.nytimes.com/2024/09/22/opinion/israel-pager-attacks-supply-chain.html)<!-- HN:41616540:end --><!-- HN:41615563:start -->
* [41615563](https://news.social-protocols.org/stats?id=41615563) #21 8 points 3 comments -> [Open Source Icon Sets](https://icon-sets.iconify.design/)<!-- HN:41615563:end -->
#### **Monday, September 23, 2024**
<!-- HN:41621672:start -->
* [41621672](https://news.social-protocols.org/stats?id=41621672) #12 24 points 9 comments -> [Man dies after being knocked down by woman on scooter](https://abc7.com/post/man-dies-after-being-knocked-down-woman-scooter-koreatown-police-investigating-hit-run/15337382/)<!-- HN:41621672:end --><!-- HN:41621631:start -->
* [41621631](https://news.social-protocols.org/stats?id=41621631) #24 54 points 27 comments -> [California fails to track its homelessness spending or results, a new audit says](https://calmatters.org/housing/homelessness/2024/04/california-homelessness-spending/)<!-- HN:41621631:end --><!-- HN:41575856:start -->
* [41575856](https://news.social-protocols.org/stats?id=41575856) #16 94 points 57 comments -> [Trove of dinosaur fossils found high in B.C. mountains](https://www.cbc.ca/news/canada/british-columbia/b-c-researchers-fossil-trove-1.7325926)<!-- HN:41575856:end --><!-- HN:41576870:start -->
* [41576870](https://news.social-protocols.org/stats?id=41576870) #18 46 points 6 comments -> [The Norwegian model of training to run](http://www.mariusbakken.com/the-norwegian-model.html)<!-- HN:41576870:end --><!-- HN:41572437:start -->
* [41572437](https://news.social-protocols.org/stats?id=41572437) #29 174 points 49 comments -> [Scientific Visualization: Python + Matplotlib (2021)](https://github.com/rougier/scientific-visualization-book)<!-- HN:41572437:end --><!-- HN:41621477:start -->
* [41621477](https://news.social-protocols.org/stats?id=41621477) #8 6 points 0 comments -> [Show HN: I built a tool to roast landing pages using AI agents](https://roastmylandingpage.io/)<!-- HN:41621477:end --><!-- HN:41620661:start -->
* [41620661](https://news.social-protocols.org/stats?id=41620661) #30 50 points 9 comments -> [Linear Mobile – Available for iOS and Android](https://linear.app/mobile)<!-- HN:41620661:end --><!-- HN:41620923:start -->
* [41620923](https://news.social-protocols.org/stats?id=41620923) #20 44 points 19 comments -> [Super Useful Chrome Plugins for Front-End Developers](https://jsdevspace.substack.com/p/13-super-useful-chrome-plugins-for)<!-- HN:41620923:end --><!-- HN:41625358:start -->
* [41625358](https://news.social-protocols.org/stats?id=41625358) #2 5 points 0 comments -> [America is becoming less "woke"](https://www.economist.com/briefing/2024/09/19/america-is-becoming-less-woke)<!-- HN:41625358:end --><!-- HN:41624741:start -->
* [41624741](https://news.social-protocols.org/stats?id=41624741) #30 28 points 40 comments -> [Guiding principles: How US dietary guidelines contribute to obesity](https://thehill.com/opinion/4891813-robert-kennedy-jr-chronic-disease/)<!-- HN:41624741:end --><!-- HN:41621020:start -->
* [41621020](https://news.social-protocols.org/stats?id=41621020) #18 300 points 242 comments -> [London saw a surprising benefit to ultra-low emissions zone: More active kids](https://grist.org/cities/london-fining-polluting-cars-more-active-kids/)<!-- HN:41621020:end --><!-- HN:41580619:start -->
* [41580619](https://news.social-protocols.org/stats?id=41580619) #21 156 points 61 comments -> [Things I've learned serving on the board of the Python Software Foundation](https://simonwillison.net/2024/Sep/18/board-of-the-python-software-foundation/)<!-- HN:41580619:end --><!-- HN:41618926:start -->
* [41618926](https://news.social-protocols.org/stats?id=41618926) #27 230 points 108 comments -> [Sublime text started adding a “.s” to new files](https://forum.sublimetext.com/t/sublime-text-started-adding-a-s-to-new-files-very-annoying/73628)<!-- HN:41618926:end --><!-- HN:41618117:start -->
* [41618117](https://news.social-protocols.org/stats?id=41618117) #26 31 points 2 comments -> [Backup Strategies for SQLite in Production](https://oldmoe.blog/2024/04/30/backup-strategies-for-sqlite-in-production/)<!-- HN:41618117:end --><!-- HN:41578637:start -->
* [41578637](https://news.social-protocols.org/stats?id=41578637) #27 113 points 108 comments -> [Bricked iPhone 16 Can Be Restored Wirelessly Using Another iPhone](https://www.macrumors.com/2024/09/18/iphone-16-restored-wirelessly-another-iphone/)<!-- HN:41578637:end --><!-- HN:41588038:start -->
* [41588038](https://news.social-protocols.org/stats?id=41588038) #21 74 points 62 comments -> [It's Okay to Abandon Things](https://netninja.com/2024/02/05/its-okay-to-abandon-things/)<!-- HN:41588038:end --><!-- HN:41620086:start -->
* [41620086](https://news.social-protocols.org/stats?id=41620086) #27 22 points 8 comments -> [Mozilla's privacy preserving ad attribution: The future or an oxymoron?](https://www.ethicalads.io/blog/2024/08/mozillas-privacy-preserving-ad-attribution-the-future-or-an-oxymoron/)<!-- HN:41620086:end --><!-- HN:41620414:start -->
* [41620414](https://news.social-protocols.org/stats?id=41620414) #21 91 points 15 comments -> [Show HN: Put ful.co/ in front of any URL to easily copy its SVGs and images](https://ful.co/)<!-- HN:41620414:end --><!-- HN:41624675:start -->
* [41624675](https://news.social-protocols.org/stats?id=41624675) #27 23 points 3 comments -> [FTC Sues Prescription Drug Middlemen for Artificially Inflating Insulin Prices](https://www.ftc.gov/news-events/news/press-releases/2024/09/ftc-sues-prescription-drug-middlemen-artificially-inflating-insulin-drug-prices)<!-- HN:41624675:end --><!-- HN:41625258:start -->
* [41625258](https://news.social-protocols.org/stats?id=41625258) #23 16 points 1 comments -> [The Problems That Google Docs Never Solved](https://amistrongeryet.substack.com/p/the-problem-with-google-docs)<!-- HN:41625258:end --><!-- HN:41625488:start -->
* [41625488](https://news.social-protocols.org/stats?id=41625488) #25 4 points 2 comments -> [An AI can beat CAPTCHA tests 100 per cent of the time](https://www.newscientist.com/article/2448687-an-ai-can-beat-captcha-tests-100-per-cent-of-the-time/)<!-- HN:41625488:end --><!-- HN:41619516:start -->
* [41619516](https://news.social-protocols.org/stats?id=41619516) #29 20 points 10 comments -> [FOSDEM 2025](https://fosdem.org/2025/)<!-- HN:41619516:end --><!-- HN:41627806:start -->
* [41627806](https://news.social-protocols.org/stats?id=41627806) #20 4 points 0 comments -> [Today's satellite view of fires in southern Lebanon](https://firms.modaps.eosdis.nasa.gov/map/#d:today;@35.37,33.17,10.66z)<!-- HN:41627806:end --><!-- HN:41628225:start -->
* [41628225](https://news.social-protocols.org/stats?id=41628225) #25 47 points 41 comments -> [Honey, YouTubers Are Poisoning the Kids](https://www.trend-mill.com/p/honey-youtubers-are-poisoning-the)<!-- HN:41628225:end --><!-- HN:41630461:start -->
* [41630461](https://news.social-protocols.org/stats?id=41630461) #9 7 points 3 comments -> [Storing RSA Private Keys in DNS TXT Records?](https://reconwave.com/blog/post/storing-private-keys-in-txt-dns)<!-- HN:41630461:end --><!-- HN:41630348:start -->
* [41630348](https://news.social-protocols.org/stats?id=41630348) #16 7 points 0 comments -> [Positive effects of creatine supplementation on memory in healthy individuals](https://www.ncbi.nlm.nih.gov/pmc/articles/PMC9999677/)<!-- HN:41630348:end --><!-- HN:41630976:start -->
* [41630976](https://news.social-protocols.org/stats?id=41630976) #9 6 points 2 comments -> [Show HN: Who Should Be the President?](https://ileantoward.com/)<!-- HN:41630976:end --><!-- HN:41629811:start -->
* [41629811](https://news.social-protocols.org/stats?id=41629811) #29 95 points 262 comments -> [Anime is eating the world](https://a16z.com/anime-is-eating-the-world/)<!-- HN:41629811:end --><!-- HN:41631464:start -->
* [41631464](https://news.social-protocols.org/stats?id=41631464) #22 6 points 0 comments -> [Israeli military shuts down Al Jazeera bureau in West Bank raid](https://www.theguardian.com/world/2024/sep/22/al-jazeera-office-west-bank-raid-israeli-forces-media)<!-- HN:41631464:end -->
#### **Tuesday, September 24, 2024**
<!-- HN:41631995:start -->
* [41631995](https://news.social-protocols.org/stats?id=41631995) #18 6 points 2 comments -> ["Traffic Violence": The Grifters Go After Cars](https://albertcory50.substack.com/p/traffic-violence-the-grifters-go)<!-- HN:41631995:end --><!-- HN:41632606:start -->
* [41632606](https://news.social-protocols.org/stats?id=41632606) #6 5 points 2 comments -> [Bootstrapped to 10K Users: Is B2B the Only Way to Monetize?](https://www.jobsolv.com/)<!-- HN:41632606:end --><!-- HN:41579268:start -->
* [41579268](https://news.social-protocols.org/stats?id=41579268) #12 347 points 36 comments -> [GPU Puzzles](https://github.com/srush/GPU-Puzzles)<!-- HN:41579268:end --><!-- HN:41587350:start -->
* [41587350](https://news.social-protocols.org/stats?id=41587350) #19 5 points 0 comments -> [Retrowin32: Redoing Syscalls](https://neugierig.org/software/blog/2024/09/retrowin32-syscalls.html)<!-- HN:41587350:end --><!-- HN:41582756:start -->
* [41582756](https://news.social-protocols.org/stats?id=41582756) #22 42 points 45 comments -> [The Death of LCDs, Means New Life for Chips](https://timculpan.substack.com/p/the-death-of-lcds-means-new-life)<!-- HN:41582756:end --><!-- HN:41585509:start -->
* [41585509](https://news.social-protocols.org/stats?id=41585509) #24 35 points 4 comments -> [The Many Lives of James Lovelock by Jonathan Watts – Man of Many Myths](https://www.theguardian.com/books/article/2024/sep/14/the-many-lives-of-james-lovelock-by-jonathan-watts-man-of-many-myths)<!-- HN:41585509:end --><!-- HN:41603270:start -->
* [41603270](https://news.social-protocols.org/stats?id=41603270) #11 8 points 2 comments -> [Compress JPG: The Image Compressor That Lets You Compress Images Securely](https://compressjpg.io/)<!-- HN:41603270:end --><!-- HN:41633628:start -->
* [41633628](https://news.social-protocols.org/stats?id=41633628) #2 7 points 5 comments -> [You'll own nothing and be happy- Jaguar Land Rover now offer a car subscription](https://www.drivepivotal.com/)<!-- HN:41633628:end --><!-- HN:41633626:start -->
* [41633626](https://news.social-protocols.org/stats?id=41633626) #27 5 points 3 comments -> [The Environmental Toll of a Single ChatGPT Query Is Absolutely Wild](https://futurism.com/the-byte/environment-openai-chatgpt)<!-- HN:41633626:end --><!-- HN:41633904:start -->
* [41633904](https://news.social-protocols.org/stats?id=41633904) #20 22 points 3 comments -> [Matrix.org Breaks Federation: Users Can't Decrypt Messages from Other Servers](https://github.com/matrix-org/matrix.org/issues/2483)<!-- HN:41633904:end --><!-- HN:41633268:start -->
* [41633268](https://news.social-protocols.org/stats?id=41633268) #30 91 points 37 comments -> [An AI Event Hired John Mulaney to Do a Comedy Set and He Brutally Roasted Them O](https://futurism.com/the-byte/salesforce-ai-john-mulaney-mocked)<!-- HN:41633268:end --><!-- HN:41634899:start -->
* [41634899](https://news.social-protocols.org/stats?id=41634899) #16 8 points 0 comments -> ['Places to heal, not to harm': brutal prison design kills off hope](https://www.theguardian.com/society/2024/sep/24/places-to-heal-not-to-harm-why-brutal-prison-design-kills-off-hope)<!-- HN:41634899:end --><!-- HN:41625456:start -->
* [41625456](https://news.social-protocols.org/stats?id=41625456) #28 43 points 1 comments -> [NeRF-Supervised Feature Point Detection and Description](https://arxiv.org/abs/2403.08156)<!-- HN:41625456:end --><!-- HN:41630081:start -->
* [41630081](https://news.social-protocols.org/stats?id=41630081) #21 37 points 16 comments -> [Where has all the productivity gone? (2021)](https://www.johndcook.com/blog/2021/07/31/where-has-productivity-gone/)<!-- HN:41630081:end --><!-- HN:41598330:start -->
* [41598330](https://news.social-protocols.org/stats?id=41598330) #22 50 points 15 comments -> [Cache Me Not, Cache Me, Cache Me Not](https://hazelweakly.me/blog/cache-me-not-cache-me-cache-me-not/)<!-- HN:41598330:end --><!-- HN:41634119:start -->
* [41634119](https://news.social-protocols.org/stats?id=41634119) #29 41 points 23 comments -> [Excel spreadsheet caused network equipment's physical failure](https://twitter.com/lauriewired/status/1838256923428438345)<!-- HN:41634119:end --><!-- HN:41636731:start -->
* [41636731](https://news.social-protocols.org/stats?id=41636731) #22 6 points 0 comments -> [Argentina Scrapped Its Rent Controls, here's what happened next](https://www.wsj.com/world/americas/argentina-milei-rent-control-free-market-5345c3d5)<!-- HN:41636731:end --><!-- HN:41635088:start -->
* [41635088](https://news.social-protocols.org/stats?id=41635088) #27 29 points 4 comments -> [Show HN: An expression parser supporting multiple types](https://github.com/torrentg/expr)<!-- HN:41635088:end --><!-- HN:41638137:start -->
* [41638137](https://news.social-protocols.org/stats?id=41638137) #10 24 points 15 comments -> [Natural Gas Company Said It Was Going Green but Still Sells as Much Fossil Fuel](https://www.propublica.org/article/nw-natural-gas-oregon-fossil-fuel)<!-- HN:41638137:end --><!-- HN:41639920:start -->
* [41639920](https://news.social-protocols.org/stats?id=41639920) #29 6 points 1 comments -> ["Calories in / calories out" is bullshit](https://twitter.com/anabology/status/1838203663375888640)<!-- HN:41639920:end --><!-- HN:41633630:start -->
* [41633630](https://news.social-protocols.org/stats?id=41633630) #23 39 points 2 comments -> [X will soon make your public posts visible to accounts you've blocked](https://techcrunch.com/2024/09/23/x-will-soon-make-your-public-posts-visible-to-accounts-youve-blocked/)<!-- HN:41633630:end --><!-- HN:41640458:start -->
* [41640458](https://news.social-protocols.org/stats?id=41640458) #9 30 points 1 comments -> [Star FTX Witness Caroline Ellison Sentenced to Two Years in Prison](https://www.wsj.com/finance/currencies/ftx-trial-caroline-ellison-sentencing-cc104a84)<!-- HN:41640458:end --><!-- HN:41640313:start -->
* [41640313](https://news.social-protocols.org/stats?id=41640313) #18 24 points 1 comments -> [Caroline Ellison sentenced to 24 months in prison for FTX fraud](https://www.bloomberg.com/news/live-blog/2024-09-24/caroline-ellison-sentencing)<!-- HN:41640313:end --><!-- HN:41641560:start -->
* [41641560](https://news.social-protocols.org/stats?id=41641560) #16 18 points 8 comments -> [The White Collar Apocalypse Is Nigh](https://scott-fryxell.github.io/blog/the-white-collar-apocalypse-is-nigh/)<!-- HN:41641560:end -->
#### **Wednesday, September 25, 2024**<!-- HN:41641495:start -->
* [41641495](https://news.social-protocols.org/stats?id=41641495) #22 11 points 2 comments -> [Ethernet in 17 lines of Spade [video]](https://www.youtube.com/watch?v=0a8P0NLYPWA)<!-- HN:41641495:end --><!-- HN:41640941:start -->
* [41640941](https://news.social-protocols.org/stats?id=41640941) #29 62 points 23 comments -> [$1B Solar and Battery Storage Project Breaks Ground in Utah](https://electrek.co/2024/09/23/a-1-billion-solar-battery-storage-project-just-broke-ground-in-utah/)<!-- HN:41640941:end --><!-- HN:41642203:start -->
* [41642203](https://news.social-protocols.org/stats?id=41642203) #17 32 points 35 comments -> [Drinking 3 cups of coffee linked to preventing multiple diseases](https://studyfinds.org/3-cups-of-coffee-diseases/)<!-- HN:41642203:end --><!-- HN:41644056:start -->
* [41644056](https://news.social-protocols.org/stats?id=41644056) #12 5 points 1 comments -> [Free AI Celebrity Voice Generator](https://arting.ai/ai-celebrity-voice-generator)<!-- HN:41644056:end --><!-- HN:41643388:start -->
* [41643388](https://news.social-protocols.org/stats?id=41643388) #28 46 points 17 comments -> [A new semantic chunking approach for RAG](https://gpt3experiments.substack.com/p/a-new-chunking-approach-to-rag)<!-- HN:41643388:end --><!-- HN:41630094:start -->
* [41630094](https://news.social-protocols.org/stats?id=41630094) #17 213 points 385 comments -> [Twitter/X will let people you've blocked see your posts](https://www.theverge.com/2024/9/23/24252438/x-blocked-users-view-public-posts)<!-- HN:41630094:end --><!-- HN:41643610:start -->
* [41643610](https://news.social-protocols.org/stats?id=41643610) #13 14 points 1 comments -> [Jupyter Kernel for Deno](https://docs.deno.com/runtime/reference/cli/jupyter/)<!-- HN:41643610:end --><!-- HN:41645820:start -->
* [41645820](https://news.social-protocols.org/stats?id=41645820) #5 13 points 6 comments -> [Why We're Having to End Our Direct Peering Relationship with Deutsche Telekom](https://about.fb.com/news/2024/09/why-were-having-to-end-our-direct-peering-relationship-with-deutsche-telekom/)<!-- HN:41645820:end --><!-- HN:41646376:start -->
* [41646376](https://news.social-protocols.org/stats?id=41646376) #27 5 points 0 comments -> [Family moved from US to Switzerland. The difference in quality of life is huge](https://www.businessinsider.com/moving-us-to-switzerland-better-quality-of-life-staying-abroad-2024-9)<!-- HN:41646376:end --><!-- HN:41646419:start -->
* [41646419](https://news.social-protocols.org/stats?id=41646419) #13 13 points 2 comments -> [Gmail's blue checkmarks are coming to iOS and Android](https://www.theverge.com/2024/9/25/24253904/gmails-blue-checkmarks-are-coming-to-ios-and-android)<!-- HN:41646419:end --><!-- HN:41645265:start -->
* [41645265](https://news.social-protocols.org/stats?id=41645265) #17 50 points 29 comments -> [How I Built My Blog](https://www.joshwcomeau.com/blog/how-i-built-my-blog-v2/)<!-- HN:41645265:end --><!-- HN:41606932:start -->
* [41606932](https://news.social-protocols.org/stats?id=41606932) #21 34 points 20 comments -> [Filtered for home robots, fast and slow](https://interconnected.org/home/2024/09/20/filtered)<!-- HN:41606932:end --><!-- HN:41645443:start -->
* [41645443](https://news.social-protocols.org/stats?id=41645443) #30 24 points 8 comments -> [Apple's 80% Charging Limit for iPhone: How Much Did It Help After a Year?](https://www.macrumors.com/2024/09/24/iphone-80-percent-charging-test/)<!-- HN:41645443:end --><!-- HN:41645413:start -->
* [41645413](https://news.social-protocols.org/stats?id=41645413) #30 20 points 13 comments -> [Why Payments Engineers Should Avoid State Machines](https://news.alvaroduran.com/p/why-payments-engineers-should-avoid)<!-- HN:41645413:end --><!-- HN:41647129:start -->
* [41647129](https://news.social-protocols.org/stats?id=41647129) #15 7 points 0 comments -> [Scientists invent filter that can recycle PFAS into renewable batteries](https://www.abc.net.au/news/2024-09-05/scientists-invent-pfas-filter-for-battery-technology/104308214)<!-- HN:41647129:end --><!-- HN:41647286:start -->
* [41647286](https://news.social-protocols.org/stats?id=41647286) #17 4 points 0 comments -> [Google files first ever complaint with European Commission against Microsoft](https://www.theregister.com/2024/09/25/google_ms_ec_complaint/)<!-- HN:41647286:end --><!-- HN:41646135:start -->
* [41646135](https://news.social-protocols.org/stats?id=41646135) #27 21 points 4 comments -> [Google Paid $2.7B to Bring Back an AI Genius Who Quit in Frustration](https://www.wsj.com/tech/ai/noam-shazeer-google-ai-deal-d3605697)<!-- HN:41646135:end --><!-- HN:41647683:start -->
* [41647683](https://news.social-protocols.org/stats?id=41647683) #23 5 points 2 comments -> [The Social Web Foundation Is Shaping the Next Era of the Web](https://werd.io/2024/unlocking-the-fediverse-the-social-web-foundation-is-shaping-the)<!-- HN:41647683:end --><!-- HN:41605524:start -->
* [41605524](https://news.social-protocols.org/stats?id=41605524) #17 10 points 0 comments -> [Scaling up linear programming with PDLP](https://research.google/blog/scaling-up-linear-programming-with-pdlp/)<!-- HN:41605524:end --><!-- HN:41646167:start -->
* [41646167](https://news.social-protocols.org/stats?id=41646167) #28 20 points 7 comments -> [US Investigating SAP, Carahsoft for Potential Price-Fixing](https://www.msn.com/en-us/money/other/us-investigating-sap-carahsoft-for-potential-price-fixing/ar-AA1r9LW8)<!-- HN:41646167:end --><!-- HN:41648397:start -->
* [41648397](https://news.social-protocols.org/stats?id=41648397) #27 6 points 1 comments -> [A thriving underground economy is clogging the internet with AI garbage](https://nymag.com/intelligencer/article/ai-generated-content-internet-online-slop-spam.html)<!-- HN:41648397:end --><!-- HN:41603819:start -->
* [41603819](https://news.social-protocols.org/stats?id=41603819) #18 23 points 1 comments -> [Mathematicians define new class of shape seen throughout nature](https://www.nature.com/articles/d41586-024-03099-6)<!-- HN:41603819:end --><!-- HN:41648855:start -->
* [41648855](https://news.social-protocols.org/stats?id=41648855) #23 5 points 0 comments -> [Substack's Nazi problem isn't going away](https://theracket.news/p/substacks-nazi-problem-isnt-going-away)<!-- HN:41648855:end --><!-- HN:41599026:start -->
* [41599026](https://news.social-protocols.org/stats?id=41599026) #10 9 points 2 comments -> [Lessons from over 30 Years of Buy versus Rent Decision](https://citeseerx.ist.psu.edu/document?repid=rep1&type=pdf&doi=90db2525a8c74fe80b5771bb8422ea252bb642d8)<!-- HN:41599026:end --><!-- HN:41645736:start -->
* [41645736](https://news.social-protocols.org/stats?id=41645736) #23 56 points 63 comments -> [OpenAI rolls out Advanced Voice Mode with more voices and a new look](https://techcrunch.com/2024/09/24/openai-rolls-out-advanced-voice-mode-with-more-voices-and-a-new-look/)<!-- HN:41645736:end --><!-- HN:41650231:start -->
* [41650231](https://news.social-protocols.org/stats?id=41650231) #29 4 points 1 comments -> [Meta Ray-Ban's updated with real-time AI video, reminders, QR scanning](https://techcrunch.com/2024/09/25/meta-updates-ray-ban-smart-glasses-with-real-time-ai-video-reminders-and-qr-code-scanning/)<!-- HN:41650231:end --><!-- HN:41648112:start -->
* [41648112](https://news.social-protocols.org/stats?id=41648112) #27 8 points 1 comments -> [VitePress: Vite and Vue powered static site generator](https://github.com/vuejs/vitepress)<!-- HN:41648112:end --><!-- HN:41651001:start -->
* [41651001](https://news.social-protocols.org/stats?id=41651001) #11 5 points 2 comments -> [Cozystack has officially been included in the CNCF Landscape](https://blog.aenix.io/cozystack-has-officially-been-included-in-the-cncf-landscape-07cc60c9e0eb)<!-- HN:41651001:end --><!-- HN:41651596:start -->
* [41651596](https://news.social-protocols.org/stats?id=41651596) #18 19 points 40 comments -> [The Daily Scrum: Does It Have to Be Daily?](https://rethinkingsoftware.substack.com/p/the-daily-scrum)<!-- HN:41651596:end -->
#### **Thursday, September 26, 2024**
<!-- HN:41653592:start -->
* [41653592](https://news.social-protocols.org/stats?id=41653592) #18 8 points 0 comments -> [OpenAI Discusses Giving Altman 7% Stake in For-Profit Shift](https://www.bloomberg.com/news/articles/2024-09-25/openai-cto-mira-murati-says-she-will-leave-the-company)<!-- HN:41653592:end -->