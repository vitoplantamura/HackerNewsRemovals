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

#### **Saturday, February 22, 2025**
<!-- HN:43134544:start -->
* [43134544](https://news.social-protocols.org/stats?id=43134544) #24 4 points 0 comments -> [Why Parliamentary Systems Are Better for the Economy Than the Presidential Ones](https://www.internationalaffairs.org.au/australianoutlook/why-parliamentary-systems-are-better-for-the-economy-than-the-presidential-ones/)<!-- HN:43134544:end --><!-- HN:43134845:start -->
* [43134845](https://news.social-protocols.org/stats?id=43134845) #12 24 points 4 comments -> [Prominent DOGE staffer Edward Coristine is grandson of turncoat KGB spy](https://www.jacobsilverman.com/p/prominent-doge-staffer-is-grandson)<!-- HN:43134845:end --><!-- HN:43135333:start -->
* [43135333](https://news.social-protocols.org/stats?id=43135333) #25 27 points 35 comments -> [Who Wants to Work in a Factory?](https://arenamag.com/2025/02/11/who-wants-to-work-in-a-factory/)<!-- HN:43135333:end --><!-- HN:43136567:start -->
* [43136567](https://news.social-protocols.org/stats?id=43136567) #9 37 points 26 comments -> [Nobody Profits – George Hotz](https://geohot.github.io//blog/jekyll/update/2025/02/19/nobody-will-profit.html)<!-- HN:43136567:end --><!-- HN:43095337:start -->
* [43095337](https://news.social-protocols.org/stats?id=43095337) #24 -> [The Erasure of Islam from the Poetry of Rumi](https://www.newyorker.com/books/page-turner/the-erasure-of-islam-from-the-poetry-of-rumi)<!-- HN:43095337:end --><!-- HN:43089877:start -->
* [43089877](https://news.social-protocols.org/stats?id=43089877) #21 10 points 2 comments -> [Oh no, don't look – it's Developer Marketing (2024)](https://permit.substack.com/p/oh-no-dont-look-its-developer-marketing)<!-- HN:43089877:end --><!-- HN:43138522:start -->
* [43138522](https://news.social-protocols.org/stats?id=43138522) #15 21 points 2 comments -> [Doge says its savings total $55B, but analysis shows it's less](https://www.washingtonpost.com/business/2025/02/22/doge-savings-found-list-analysis/)<!-- HN:43138522:end --><!-- HN:43138950:start -->
* [43138950](https://news.social-protocols.org/stats?id=43138950) #1 25 points 2 comments -> [TikTok and X recommends pro-AfD content to non-partisan users ahead of election](https://jumpshare.com/s/tqzgE7gQ2Q81dTcnTSfF)<!-- HN:43138950:end --><!-- HN:43092007:start -->
* [43092007](https://news.social-protocols.org/stats?id=43092007) #9 6 points 0 comments -> [Nanotini – smallest pasta makes a good bandage](https://www.scientificamerican.com/article/the-worlds-smallest-pasta-is-not-very-tasty/)<!-- HN:43092007:end --><!-- HN:43139456:start -->
* [43139456](https://news.social-protocols.org/stats?id=43139456) #4 22 points 7 comments -> [Elon, Romania doesn't care about your tweets](https://dearelon.ro/)<!-- HN:43139456:end --><!-- HN:43140709:start -->
* [43140709](https://news.social-protocols.org/stats?id=43140709) #11 21 points 5 comments -> [Americans Are Heading for the Exits](https://newrepublic.com/article/191421/trump-emigration-wave-brain-drain)<!-- HN:43140709:end --><!-- HN:43141205:start -->
* [43141205](https://news.social-protocols.org/stats?id=43141205) #5 34 points 1 comments -> [Memo: 'Capture of U.S. Critical Infrastructure by Neoreactionaries'](https://www.thenerdreich.com/memo-capture-of-u-s-critical-infrastructure-by-neoreactionaries/)<!-- HN:43141205:end --><!-- HN:43141656:start -->
* [43141656](https://news.social-protocols.org/stats?id=43141656) #26 5 points 1 comments -> [Recording reveals new details on controversial DOGE employee Edward Coristine](https://www.cnn.com/2025/02/21/politics/doge-musk-edward-coristine-invs/index.html)<!-- HN:43141656:end --><!-- HN:43141392:start -->
* [43141392](https://news.social-protocols.org/stats?id=43141392) #7 42 points 2 comments -> [Warren Buffett sounds warning to Washington as Berkshire reports record profit](https://www.reuters.com/business/warren-buffett-says-us-should-spend-wisely-plans-increase-investment-japan-2025-02-22/)<!-- HN:43141392:end --><!-- HN:43141982:start -->
* [43141982](https://news.social-protocols.org/stats?id=43141982) #20 10 points 2 comments -> [The foundations of America's prosperity are being dismantled](https://www.technologyreview.com/2025/02/21/1112274/the-foundations-of-americas-prosperity-are-being-dismantled/)<!-- HN:43141982:end --><!-- HN:43142701:start -->
* [43142701](https://news.social-protocols.org/stats?id=43142701) #23 7 points 0 comments -> [Alarm as bird flu now 'endemic in cows'](https://www.theguardian.com/us-news/2025/feb/22/bird-flu-virus-trump)<!-- HN:43142701:end --><!-- HN:43142910:start -->
* [43142910](https://news.social-protocols.org/stats?id=43142910) #29 11 points 5 comments -> [Failure to respond will be taken as a resignation](https://twitter.com/elonmusk/status/1893386883444437415)<!-- HN:43142910:end --><!-- HN:43100435:start -->
* [43100435](https://news.social-protocols.org/stats?id=43100435) #17 3 points 0 comments -> [Allow me to explain this absurd thing on my head (made by 3D printer, not Apple)](https://twitter.com/waitbutwhy/status/1891989494875750600)<!-- HN:43100435:end --><!-- HN:43143637:start -->
* [43143637](https://news.social-protocols.org/stats?id=43143637) #17 22 points 1 comments -> [NIH funding freeze stalls applications on $1.5B in medical research funds](https://www.npr.org/sections/shots-health-news/2025/02/22/nx-s1-5305276/trump-nih-funding-freeze-medical-research)<!-- HN:43143637:end -->
#### **Sunday, February 23, 2025**<!-- HN:43060603:start -->
* [43060603](https://news.social-protocols.org/stats?id=43060603) #22 113 points 9 comments -> [Jill – a functional programming language for the Nand2Tetris platform](https://github.com/mpatajac/jillc)<!-- HN:43060603:end --><!-- HN:43144421:start -->
* [43144421](https://news.social-protocols.org/stats?id=43144421) #23 32 points 12 comments -> [Why are you lying to me? What the hell is wrong with you?](https://respectfulleadership.substack.com/p/a-true-story-software-bugs-dishonesty)<!-- HN:43144421:end --><!-- HN:43107244:start -->
* [43107244](https://news.social-protocols.org/stats?id=43107244) #5 20 points 1 comments -> [A Clang regression related to switch statements and inlining](https://nicula.xyz/2025/02/16/clang-and-big-switches.html)<!-- HN:43107244:end --><!-- HN:43144415:start -->
* [43144415](https://news.social-protocols.org/stats?id=43144415) #10 7 points 6 comments -> [Our Big Oops](https://www.overcomingbias.com/p/our-big-oops)<!-- HN:43144415:end --><!-- HN:43143806:start -->
* [43143806](https://news.social-protocols.org/stats?id=43143806) #29 35 points 40 comments -> [Official sequel to Cracking the Coding Interview is out](https://interviewing.io/blog/we-co-wrote-the-official-sequel-to-cracking-the-coding-interview-introducing-beyond-ctci)<!-- HN:43143806:end --><!-- HN:43100870:start -->
* [43100870](https://news.social-protocols.org/stats?id=43100870) #7 23 points 2 comments -> [Extreme Server Side Rendering](https://www.scd31.com/posts/extreme-server-side-rendering)<!-- HN:43100870:end --><!-- HN:43146357:start -->
* [43146357](https://news.social-protocols.org/stats?id=43146357) #7 17 points 3 comments -> [Men overestimate women's preference for masculinity](https://www.bps.org.uk/research-digest/men-overestimate-womens-preference-masculinity)<!-- HN:43146357:end --><!-- HN:43144895:start -->
* [43144895](https://news.social-protocols.org/stats?id=43144895) #25 43 points 8 comments -> [Python's official documentation contains textbook example of insecure code (XSS)](https://seclists.org/fulldisclosure/2025/Feb/15)<!-- HN:43144895:end --><!-- HN:43145483:start -->
* [43145483](https://news.social-protocols.org/stats?id=43145483) #14 134 points 214 comments -> [U Pittsburgh pauses all PhD admissions amid DOGE funding cuts](https://www.wesa.fm/health-science-tech/2025-02-21/university-pittsburgh-phd-pause-research-funding-uncertainty)<!-- HN:43145483:end --><!-- HN:43106574:start -->
* [43106574](https://news.social-protocols.org/stats?id=43106574) #11 31 points 40 comments -> [Protoclone, the first bipedal, musculoskeletal Android](https://clonerobotics.com/android/)<!-- HN:43106574:end --><!-- HN:43148355:start -->
* [43148355](https://news.social-protocols.org/stats?id=43148355) #18 12 points 5 comments -> [A Black Fungus Might Be Healing Chernobyl by Drinking Radiation](https://makerfairerome.eu/en/a-black-fungus-might-be-healing-chernobyl-by-drinking-radiation/)<!-- HN:43148355:end --><!-- HN:43149340:start -->
* [43149340](https://news.social-protocols.org/stats?id=43149340) #18 6 points 0 comments -> [The National Institute of Standards and Technology Braces for Mass Firings](https://www.wired.com/story/the-national-institute-of-standards-and-technology-braces-for-mass-firings/)<!-- HN:43149340:end --><!-- HN:43149398:start -->
* [43149398](https://news.social-protocols.org/stats?id=43149398) #8 11 points 4 comments -> [Why are Rust Foundation execs paid via foreign entities, not directly? [Page 35] [pdf]](https://rustfoundation.org/wp-content/uploads/2025/01/form-990-2023.pdf)<!-- HN:43149398:end --><!-- HN:43148803:start -->
* [43148803](https://news.social-protocols.org/stats?id=43148803) #21 10 points 4 comments -> [GitHub Hosting Malware Won't Remove After Report](https://github.com/UpdaterCisco)<!-- HN:43148803:end --><!-- HN:43149779:start -->
* [43149779](https://news.social-protocols.org/stats?id=43149779) #3 -> [ChatGPT: When did Google go wrong?](https://chatgpt.com/share/67bb39ca-af04-8009-a66d-6a42ef8400bf)<!-- HN:43149779:end --><!-- HN:43149928:start -->
* [43149928](https://news.social-protocols.org/stats?id=43149928) #30 13 points 0 comments -> [In war against DEI in science, researchers see collateral damage](https://arstechnica.com/science/2025/02/in-war-against-dei-in-science-researchers-see-collateral-damage/)<!-- HN:43149928:end --><!-- HN:43149591:start -->
* [43149591](https://news.social-protocols.org/stats?id=43149591) #15 26 points 5 comments -> [Immune markers of post COVID vaccination syndrome indicate future research](https://news.yale.edu/2025/02/19/immune-markers-post-vaccination-syndrome-indicate-future-research-directions)<!-- HN:43149591:end --><!-- HN:43106078:start -->
* [43106078](https://news.social-protocols.org/stats?id=43106078) #30 16 points 4 comments -> [Google Quality Issues: Harmful to Consumers and Possibly Intentional](https://wallethub.com/blog/google-quality-issues-report/147091)<!-- HN:43106078:end --><!-- HN:43151655:start -->
* [43151655](https://news.social-protocols.org/stats?id=43151655) #3 11 points 0 comments -> [Move Fast and Break People](https://www.thehandbasket.co/p/musk-opm-5-bullets-email-psychological-warfare)<!-- HN:43151655:end --><!-- HN:43151580:start -->
* [43151580](https://news.social-protocols.org/stats?id=43151580) #16 81 points 15 comments -> [Grok 3 claims its system prompt includes censorship about Musk/Trump](https://old.reddit.com/r/OpenAI/comments/1iw8eok/elon_musk_is_trying_to_censor_grok_3_which_the/)<!-- HN:43151580:end --><!-- HN:43149883:start -->
* [43149883](https://news.social-protocols.org/stats?id=43149883) #4 227 points 1 comments -> [Making any integer with four 2s](https://eli.thegreenplace.net/2025/making-any-integer-with-four-2s/)<!-- HN:43149883:end -->
#### **Monday, February 24, 2025**
<!-- HN:43124497:start -->
* [43124497](https://news.social-protocols.org/stats?id=43124497) #8 7 points 2 comments -> [JavaScript Promises](https://lancecourse.com/en/courses/javascript-in-100-bits/lesson-24-javascript-promises)<!-- HN:43124497:end --><!-- HN:43155204:start -->
* [43155204](https://news.social-protocols.org/stats?id=43155204) #21 5 points 0 comments -> [Federal prisons prep to move trans inmates as early as next week](https://www.npr.org/2025/02/21/nx-s1-5305282/trans-inmates-federal-prison-policy-transfers)<!-- HN:43155204:end --><!-- HN:43151294:start -->
* [43151294](https://news.social-protocols.org/stats?id=43151294) #19 285 points 178 comments -> [WhiteSur: macOS-like theme for GTK desktops](https://github.com/vinceliuice/WhiteSur-gtk-theme)<!-- HN:43151294:end --><!-- HN:43153262:start -->
* [43153262](https://news.social-protocols.org/stats?id=43153262) #16 182 points 146 comments -> [Bitwarden Authenticator](https://bitwarden.com/products/authenticator/)<!-- HN:43153262:end --><!-- HN:43150217:start -->
* [43150217](https://news.social-protocols.org/stats?id=43150217) #22 222 points 50 comments -> [Ultima VII: Revisited](https://www.u7revisited.com/)<!-- HN:43150217:end --><!-- HN:43154218:start -->
* [43154218](https://news.social-protocols.org/stats?id=43154218) #14 147 points 30 comments -> [Defragging my old Dell's UEFI NVRAM](https://artemis.sh/2025/02/22/uefi-nvram-defrag.html)<!-- HN:43154218:end --><!-- HN:43159979:start -->
* [43159979](https://news.social-protocols.org/stats?id=43159979) #18 3 points 0 comments -> [Cursing appears to improve exercise performance](https://pmc.ncbi.nlm.nih.gov/articles/PMC11586181/)<!-- HN:43159979:end --><!-- HN:43160093:start -->
* [43160093](https://news.social-protocols.org/stats?id=43160093) #17 4 points 0 comments -> [Why Do Young Men Migrate?](https://thewire.in/society/why-do-young-men-migrate)<!-- HN:43160093:end --><!-- HN:43123292:start -->
* [43123292](https://news.social-protocols.org/stats?id=43123292) #16 -> [AI cracks superbug problem in two days that took scientists years](https://www.bbc.com/news/articles/clyz6e9edy3o)<!-- HN:43123292:end --><!-- HN:43158187:start -->
* [43158187](https://news.social-protocols.org/stats?id=43158187) #18 43 points 11 comments -> [Apple will spend more than $500B in the U.S. over the next four years](https://www.apple.com/newsroom/2025/02/apple-will-spend-more-than-500-billion-usd-in-the-us-over-the-next-four-years/)<!-- HN:43158187:end --><!-- HN:43158739:start -->
* [43158739](https://news.social-protocols.org/stats?id=43158739) #4 63 points 2 comments -> [Microsoft Cancels Leases for AI Data Centers, Analyst Says](https://finance.yahoo.com/news/microsoft-cancels-leases-ai-data-055952585.html)<!-- HN:43158739:end --><!-- HN:43162933:start -->
* [43162933](https://news.social-protocols.org/stats?id=43162933) #16 3 points 0 comments -> [The Birth of Wetware (2018)](https://proto.life/2018/05/the-birth-of-wetware/)<!-- HN:43162933:end --><!-- HN:43163520:start -->
* [43163520](https://news.social-protocols.org/stats?id=43163520) #17 50 points 53 comments -> [Starship's Eighth Flight Test](https://www.spacex.com/launches/mission/?missionId)<!-- HN:43163520:end --><!-- HN:43127045:start -->
* [43127045](https://news.social-protocols.org/stats?id=43127045) #28 28 points 15 comments -> [The Champion Who Memorized 80 Numbers in 13.5 Seconds](https://www.nytimes.com/2025/02/14/science/vishvaa-rajakumar-memory-techniques.html)<!-- HN:43127045:end --><!-- HN:43123810:start -->
* [43123810](https://news.social-protocols.org/stats?id=43123810) #25 65 points 1 comments -> ["The closer [to] the railway station the less tasty the Kebab is" – A Study](https://old.reddit.com/r/gis/comments/1iph0yy/the_closer_to_the_railway_station_the_less_tasty/)<!-- HN:43123810:end -->
#### **Tuesday, February 25, 2025**
<!-- HN:43129884:start -->
* [43129884](https://news.social-protocols.org/stats?id=43129884) #21 3 points 0 comments -> [Grab AI Gateway: Connecting Grabbers to Multiple GenAI Providers](https://engineering.grab.com/grab-ai-gateway)<!-- HN:43129884:end --><!-- HN:43168059:start -->
* [43168059](https://news.social-protocols.org/stats?id=43168059) #21 30 points 40 comments -> [A16Z AI Voice Update 2025](https://gamma.app/docs/a16z-AI-Voice-Update-2025--ttkorld8iy6wfnj?mode=doc)<!-- HN:43168059:end --><!-- HN:43168739:start -->
* [43168739](https://news.social-protocols.org/stats?id=43168739) #22 6 points 0 comments -> [Grok Grok](https://thezvi.substack.com/p/grok-grok)<!-- HN:43168739:end --><!-- HN:43170093:start -->
* [43170093](https://news.social-protocols.org/stats?id=43170093) #10 10 points 3 comments -> [Does Linus think Rust causes Linux breakage?](https://lwn.net/ml/all/CAHk-=wie_Winz7CtRCM62S2b1pWKN2Jt2wdGHgFBv=aBU8qwqg@mail.gmail.com/)<!-- HN:43170093:end --><!-- HN:43170718:start -->
* [43170718](https://news.social-protocols.org/stats?id=43170718) #6 35 points 3 comments -> [Tesla sales almost halved in Europe last month](https://www.businessinsider.com/tesla-sales-europe-tumbled-elon-musk-china-evs-2025-2)<!-- HN:43170718:end --><!-- HN:43135968:start -->
* [43135968](https://news.social-protocols.org/stats?id=43135968) #17 5 points 2 comments -> [Severance show – Fan-based game](https://www.solana-industries.com/)<!-- HN:43135968:end --><!-- HN:43128392:start -->
* [43128392](https://news.social-protocols.org/stats?id=43128392) #24 164 points 118 comments -> [I ate and reviewed every snack in our office kitchen](https://www.getlago.com/blog/office-snacks)<!-- HN:43128392:end --><!-- HN:43167936:start -->
* [43167936](https://news.social-protocols.org/stats?id=43167936) #23 257 points 93 comments -> [How to change your settings to make yourself less valuable to Meta](https://johnoliverwantsyourraterotica.com/)<!-- HN:43167936:end --><!-- HN:43172180:start -->
* [43172180](https://news.social-protocols.org/stats?id=43172180) #23 8 points 0 comments -> [YC deleted the post of the demo for slavery](https://twitter.com/ns123abc/status/1894193460166397991)<!-- HN:43172180:end --><!-- HN:43172037:start -->
* [43172037](https://news.social-protocols.org/stats?id=43172037) #20 27 points 4 comments -> [Apple Voice Dictation Writes 'Trump' When You Say 'Racist'](https://boehs.org/node/racist-autocorrect)<!-- HN:43172037:end --><!-- HN:43172676:start -->
* [43172676](https://news.social-protocols.org/stats?id=43172676) #23 3 points 1 comments -> [PocketBeagle 2 SBC Combines TI AM6232 Dual-Core Cortex-A53 SoC with MSPM0 MCU](https://www.cnx-software.com/2025/02/18/pocketbeagle-2-sbc-combines-ti-am6232-soc-with-mspm0-mcu/)<!-- HN:43172676:end --><!-- HN:43173341:start -->
* [43173341](https://news.social-protocols.org/stats?id=43173341) #13 29 points 42 comments -> [Fabric and craft retailer Joann to go out of business, close all of its stores](https://apnews.com/article/joann-closing-bankruptcy-crafts-retail-b83c68fb641fad18cd6c8be925c6d90b)<!-- HN:43173341:end --><!-- HN:43174908:start -->
* [43174908](https://news.social-protocols.org/stats?id=43174908) #10 4 points 0 comments -> [The Harem of an Autist](https://fantasticanachronism.com/2025/02/25/the-harem-of-an-autist/)<!-- HN:43174908:end --><!-- HN:43149899:start -->
* [43149899](https://news.social-protocols.org/stats?id=43149899) #26 20 points 6 comments -> [Show HN: Dropbud – A place to upload files without uploading](https://dropbud.co/space)<!-- HN:43149899:end -->
#### **Wednesday, February 26, 2025**
<!-- HN:43156753:start -->
* [43156753](https://news.social-protocols.org/stats?id=43156753) #15 13 points 2 comments -> [Hive Roaster Handheld Smoke Incinerating Coffee Roaster](https://hiveroaster.com/)<!-- HN:43156753:end --><!-- HN:43180561:start -->
* [43180561](https://news.social-protocols.org/stats?id=43180561) #18 12 points 0 comments -> [Oil and Gas Subsidies Are Another Lie Detector Test for the DOGE Bros](https://www.motherjones.com/politics/2025/01/doge-fossil-fuel-subsidies-elon-musk-vivek-ramaswamy/)<!-- HN:43180561:end --><!-- HN:43180834:start -->
* [43180834](https://news.social-protocols.org/stats?id=43180834) #4 100 points 15 comments -> [Y Combinator Supports AI Startup Dehumanizing Factory Workers](https://www.404media.co/optifyeai-ycombinator-startup-ai-factory/)<!-- HN:43180834:end --><!-- HN:43182578:start -->
* [43182578](https://news.social-protocols.org/stats?id=43182578) #17 10 points 1 comments -> [Open-source is where dreams go to die](https://www.trevorlasn.com/blog/open-source-is-where-dreams-go-to-die)<!-- HN:43182578:end --><!-- HN:43138818:start -->
* [43138818](https://news.social-protocols.org/stats?id=43138818) #9 36 points 8 comments -> [Recurse Center's Social Rules](https://www.recurse.com/social-rules)<!-- HN:43138818:end --><!-- HN:43144830:start -->
* [43144830](https://news.social-protocols.org/stats?id=43144830) #11 35 points 13 comments -> [A compendium of "open-source" licenses](https://github.com/ErikMcClure/bad-licenses)<!-- HN:43144830:end --><!-- HN:43183169:start -->
* [43183169](https://news.social-protocols.org/stats?id=43183169) #12 44 points 25 comments -> [Marek has graciously offered to maintain the dma-mapping tree](https://lore.kernel.org/lkml/20250224162724.349679-1-hch@lst.de/)<!-- HN:43183169:end --><!-- HN:43137445:start -->
* [43137445](https://news.social-protocols.org/stats?id=43137445) #14 105 points 21 comments -> [Terence Tao – Machine-Assisted Proofs (February 19, 2025) [video]](https://www.youtube.com/watch?v=5ZIIGLiQWNM)<!-- HN:43137445:end --><!-- HN:43183688:start -->
* [43183688](https://news.social-protocols.org/stats?id=43183688) #17 28 points 12 comments -> [Apple's Dictation System Transcribes the Word 'Racist' as 'Trump'](https://www.nytimes.com/2025/02/25/technology/iphone-dictation-trump-racist.html)<!-- HN:43183688:end --><!-- HN:43183568:start -->
* [43183568](https://news.social-protocols.org/stats?id=43183568) #20 45 points 43 comments -> ["Do you not like money?"](https://rubenerd.com/do-you-not-like-money/)<!-- HN:43183568:end --><!-- HN:43185174:start -->
* [43185174](https://news.social-protocols.org/stats?id=43185174) #1 81 points 3 comments -> [A WebAssembly runtime implemented in TypeScript types](https://github.com/MichiganTypeScript/typescript-types-only-wasm-runtime)<!-- HN:43185174:end --><!-- HN:43187326:start -->
* [43187326](https://news.social-protocols.org/stats?id=43187326) #12 3 points 0 comments -> [An Identity-Based Model of Political Belief: Trends in Cognitive Sciences](https://www.cell.com/trends/cognitive-sciences/abstract/S1364-6613(18)30017-2)<!-- HN:43187326:end --><!-- HN:43187543:start -->
* [43187543](https://news.social-protocols.org/stats?id=43187543) #22 13 points 0 comments -> [Techno-Fascism Comes to America](https://www.newyorker.com/culture/infinite-scroll/techno-fascism-comes-to-america-elon-musk)<!-- HN:43187543:end -->
#### **Thursday, February 27, 2025**
<!-- HN:43190048:start -->
* [43190048](https://news.social-protocols.org/stats?id=43190048) #4 16 points 1 comments -> [Europe Is a Cautionary Tale on Birthright Citizenship](https://asanfranciscan.substack.com/p/europe-is-a-cautionary-tale-on-birthright)<!-- HN:43190048:end --><!-- HN:43190262:start -->
* [43190262](https://news.social-protocols.org/stats?id=43190262) #20 12 points 1 comments -> [Save Act would require all Americans prove citizenship when registering to vote](https://www.americanprogress.org/article/the-save-act-would-disenfranchise-millions-of-citizens/)<!-- HN:43190262:end --><!-- HN:43192547:start -->
* [43192547](https://news.social-protocols.org/stats?id=43192547) #16 19 points 41 comments -> [Japan births fall to lowest in 125 years](https://www.ft.com/content/95d3282e-daef-4670-b704-c1215393e7f8)<!-- HN:43192547:end --><!-- HN:43193326:start -->
* [43193326](https://news.social-protocols.org/stats?id=43193326) #2 18 points 13 comments -> [Germany's Water Consumption Down 17% Following Nuclear Reactor Shutdowns](https://www.vdi-nachrichten.com/technik/umwelt/wasserverbrauch-in-deutschland-sank-deutlich-durch-akw-abschaltung/)<!-- HN:43193326:end --><!-- HN:43193383:start -->
* [43193383](https://news.social-protocols.org/stats?id=43193383) #6 10 points 0 comments -> [Show HN: No-html.club, a plain text club](http://no-html.club/index.txt)<!-- HN:43193383:end --><!-- HN:43152051:start -->
* [43152051](https://news.social-protocols.org/stats?id=43152051) #10 22 points 3 comments -> [Transparency in Hardware/Software Interfaces](https://rfd.shared.oxide.computer/rfd/0552)<!-- HN:43152051:end --><!-- HN:43193734:start -->
* [43193734](https://news.social-protocols.org/stats?id=43193734) #24 3 points 0 comments -> [Kia's EV strategy: Smaller, cheaper cars like the EV3 hatch and EV4 sedan](https://arstechnica.com/cars/2025/02/kias-ev-strategy-smaller-cheaper-cars-like-ev3-hatch-and-ev4-sedan/)<!-- HN:43193734:end --><!-- HN:43159128:start -->
* [43159128](https://news.social-protocols.org/stats?id=43159128) #9 16 points 1 comments -> [Show HN: Orra – The missing glue layer for production-ready multi-agent apps](https://github.com/orra-dev/orra)<!-- HN:43159128:end --><!-- HN:43170242:start -->
* [43170242](https://news.social-protocols.org/stats?id=43170242) #9 13 points 2 comments -> [Metasploit – Penetration Testing Framework](https://www.metasploit.com/)<!-- HN:43170242:end --><!-- HN:43193795:start -->
* [43193795](https://news.social-protocols.org/stats?id=43193795) #23 44 points 26 comments -> [Local social spending and political dissatisfaction of the economically deprived](https://www.frontiersin.org/journals/political-science/articles/10.3389/fpos.2025.1516985/full)<!-- HN:43193795:end --><!-- HN:43194778:start -->
* [43194778](https://news.social-protocols.org/stats?id=43194778) #15 19 points 6 comments -> [Gene Hackman and pianist wife Betsy Arakawa found dead at home with their dog](https://www.theguardian.com/film/2025/feb/27/gene-hackman-dies-wife-dog-95)<!-- HN:43194778:end --><!-- HN:43195589:start -->
* [43195589](https://news.social-protocols.org/stats?id=43195589) #24 -> [At 3 A.m., I Turned to AI for Comfort. That Was My First Mistake](https://thewalrus.ca/at-3-a-m-i-turned-to-ai-for-comfort-that-was-my-first-mistake/)<!-- HN:43195589:end --><!-- HN:43196443:start -->
* [43196443](https://news.social-protocols.org/stats?id=43196443) #25 6 points 1 comments -> [Bezos censors the Washington Post in the name of freedom](https://www.washingtonpost.com/style/media/2025/02/26/washington-post-bezos-opinions-section/)<!-- HN:43196443:end --><!-- HN:43196585:start -->
* [43196585](https://news.social-protocols.org/stats?id=43196585) #15 8 points 1 comments -> [From "hot blonde" to "stepsis": porn titles over time](https://github.com/dhealy05/semen_and_semantics)<!-- HN:43196585:end --><!-- HN:43198759:start -->
* [43198759](https://news.social-protocols.org/stats?id=43198759) #14 9 points 5 comments -> [Think tank seeks to give "Trump his rightful third term in office"](https://thirdtermproject.com/)<!-- HN:43198759:end -->
#### **Friday, February 28, 2025**
<!-- HN:43200179:start -->
* [43200179](https://news.social-protocols.org/stats?id=43200179) #14 5 points 0 comments -> [Tesla Powerwall 3 Alternatives](https://www.virtuesolar.com/2025/02/17/tesla-powerwall-3-alternatives/)<!-- HN:43200179:end --><!-- HN:43199460:start -->
* [43199460](https://news.social-protocols.org/stats?id=43199460) #4 250 points 3 comments -> [Some Command & Conquer games are now open source](https://github.com/electronicarts)<!-- HN:43199460:end --><!-- HN:43205100:start -->
* [43205100](https://news.social-protocols.org/stats?id=43205100) #26 9 points 1 comments -> ['I decided I was done':Canada pizzeria boycotts US ingredients in tariff dispute](https://www.theguardian.com/world/2025/feb/28/canada-pizzeria-owner-boycotts-us-products)<!-- HN:43205100:end --><!-- HN:43207338:start -->
* [43207338](https://news.social-protocols.org/stats?id=43207338) #6 26 points 2 comments -> [Hundreds in US climate agency fired in latest cuts](https://www.bbc.com/news/articles/cdell8n14x2o)<!-- HN:43207338:end --><!-- HN:43200450:start -->
* [43200450](https://news.social-protocols.org/stats?id=43200450) #17 193 points 19 comments -> [Markov Chains Explained Visually (2014)](https://setosa.io/ev/markov-chains/)<!-- HN:43200450:end --><!-- HN:43207491:start -->
* [43207491](https://news.social-protocols.org/stats?id=43207491) #6 20 points 0 comments -> [The full force of this administration's destruction is about to hit](https://www.thehandbasket.co/p/government-destruction-ssa-doge)<!-- HN:43207491:end --><!-- HN:43205196:start -->
* [43205196](https://news.social-protocols.org/stats?id=43205196) #26 95 points 151 comments -> [AMD RDNA 4 – AMD Radeon RX 9000 Series Graphics Cards](https://www.amd.com/en/newsroom/press-releases/2025-2-28-amd-unveils-next-generation-amd-rdna-4-architectu.html)<!-- HN:43205196:end --><!-- HN:43169461:start -->
* [43169461](https://news.social-protocols.org/stats?id=43169461) #21 317 points 230 comments -> [Spotify's Beta Used 'Pirate' MP3 Files, Some from Pirate Bay](https://torrentfreak.com/spotifys-beta-used-pirate-mp3-files-some-from-pirate-bay-170509/)<!-- HN:43169461:end --><!-- HN:43200065:start -->
* [43200065](https://news.social-protocols.org/stats?id=43200065) #24 792 points 6 comments -> [Mozilla owns "information you input through Firefox"](https://www.mozilla.org/en-US/about/legal/terms/firefox/)<!-- HN:43200065:end --><!-- HN:43210569:start -->
* [43210569](https://news.social-protocols.org/stats?id=43210569) #1 51 points 7 comments -> ["No, we are absolutely not prepared to [fork Firefox]"](https://codeberg.org/librewolf/issues/issues/2252#issuecomment-2886286)<!-- HN:43210569:end -->