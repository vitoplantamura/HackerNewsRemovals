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

#### **Wednesday, November 5, 2025**<!-- HN:45818043:start -->
* [45818043](https://news.social-protocols.org/stats?id=45818043) #17 6 points 0 comments -> [At least 3 dead after UPS plane crashes at Louisville airport; fire spreading](https://www.wlky.com/article/plane-crash-explosion-louisville-airport/69255042)<!-- HN:45818043:end --><!-- HN:45818089:start -->
* [45818089](https://news.social-protocols.org/stats?id=45818089) #2 60 points 14 comments -> [At least 3 dead after cargo plane crashes at Kentucky airport](https://www.bbc.com/news/live/c201kgq59qgt)<!-- HN:45818089:end --><!-- HN:45818694:start -->
* [45818694](https://news.social-protocols.org/stats?id=45818694) #27 9 points 4 comments -> [Live Updates: Mamdani Wins NYC Mayor's Race After Highest Turnout in Decades](https://www.nytimes.com/live/2025/11/04/nyregion/nyc-mayor-election)<!-- HN:45818694:end --><!-- HN:45720808:start -->
* [45720808](https://news.social-protocols.org/stats?id=45720808) #12 9 points 2 comments -> [What does computer literacy mean for 2026?](https://sjg.io/writing/the-2026-computer-literate-bar/)<!-- HN:45720808:end --><!-- HN:45709513:start -->
* [45709513](https://news.social-protocols.org/stats?id=45709513) #13 5 points 0 comments -> [The Magic of Precision Engineering](https://www.hightechinstitute.nl/the-magic-of-precision-engineering/)<!-- HN:45709513:end --><!-- HN:45727194:start -->
* [45727194](https://news.social-protocols.org/stats?id=45727194) #27 24 points 4 comments -> [FDD – Diskettes](https://retrocmp.de/fdd/diskette/diskette.htm)<!-- HN:45727194:end --><!-- HN:45823398:start -->
* [45823398](https://news.social-protocols.org/stats?id=45823398) #4 6 points 0 comments -> [If your app &gt; 100KB, delete your GitHub](https://mg0x7be.github.io/if-your-app-100kb-delete-your-github.html)<!-- HN:45823398:end --><!-- HN:45823841:start -->
* [45823841](https://news.social-protocols.org/stats?id=45823841) #30 26 points 16 comments -> ['A mass casualty event that could exceed Hiroshima': Yale researcher on Sudan](https://www.cnn.com/2025/11/03/tv/video/amanpour-sudan-nathaniel-raymond-hamid-khalafallah)<!-- HN:45823841:end --><!-- HN:45824775:start -->
* [45824775](https://news.social-protocols.org/stats?id=45824775) #3 16 points 0 comments -> [The Islamic, Arab Genocide in Sudan which the world ignores](https://europeantimes.org/the-islamic-arab-genocide-in-sudan-which-the-world-ignores/)<!-- HN:45824775:end --><!-- HN:45796811:start -->
* [45796811](https://news.social-protocols.org/stats?id=45796811) #20 9 points 0 comments -> [The Heart of the Matter](https://rodgercuddington.substack.com/p/the-heart-of-the-matter)<!-- HN:45796811:end --><!-- HN:45826142:start -->
* [45826142](https://news.social-protocols.org/stats?id=45826142) #1 -> [Fintech CEO caught manipulating social media likes](https://patrickstoica.substack.com/p/fintech-ceo-caught-manipulating-social)<!-- HN:45826142:end -->
#### **Thursday, November 6, 2025**
<!-- HN:45792085:start -->
* [45792085](https://news.social-protocols.org/stats?id=45792085) #11 6 points 2 comments -> [The Last Literary Lion of New York, Gay Talese](https://www.metropolitanreview.org/p/the-last-literary-lion-of-new-york)<!-- HN:45792085:end --><!-- HN:45766347:start -->
* [45766347](https://news.social-protocols.org/stats?id=45766347) #27 11 points 2 comments -> [The MDL ("Muddle") Programming Language (1979) [pdf]](http://bitsavers.informatik.uni-stuttgart.de/pdf/mit/lcs/tr/MIT-LCS-TR-0293_MDL_Pgmg_Lang.pdf)<!-- HN:45766347:end --><!-- HN:45832954:start -->
* [45832954](https://news.social-protocols.org/stats?id=45832954) #16 41 points 29 comments -> [Erlang Meets Idris: Cure Programming Language](https://cure-lang.org/)<!-- HN:45832954:end --><!-- HN:45834145:start -->
* [45834145](https://news.social-protocols.org/stats?id=45834145) #25 4 points 0 comments -> [The Telegraph: How a secret dossier blew open anti-Israel bias at the BBC [video]](https://www.youtube.com/watch?v=qdIIHMAMEiM)<!-- HN:45834145:end --><!-- HN:45834456:start -->
* [45834456](https://news.social-protocols.org/stats?id=45834456) #6 3 points 0 comments -> [Pussy Hunter](https://bigjobby.com/floof/)<!-- HN:45834456:end --><!-- HN:45840580:start -->
* [45840580](https://news.social-protocols.org/stats?id=45840580) #24 12 points 0 comments -> [Zohran Mamdani Just Inherited the NYPD Surveillance State](https://www.wired.com/story/welcome-to-mamdanis-surveillance-state/)<!-- HN:45840580:end --><!-- HN:45841464:start -->
* [45841464](https://news.social-protocols.org/stats?id=45841464) #1 106 points 44 comments -> [Man who threw sandwich at US border agent not guilty of assault](https://www.bbc.com/news/articles/c5ypvv8n1jvo)<!-- HN:45841464:end -->
#### **Friday, November 7, 2025**
<!-- HN:45765232:start -->
* [45765232](https://news.social-protocols.org/stats?id=45765232) #7 25 points 3 comments -> [Blame Wi-Fi drivers for printer (mDNS) discovery issues](https://printserver.ink/blog/blame-wifi-drivers-for-printer-discovery-issues/)<!-- HN:45765232:end --><!-- HN:45770577:start -->
* [45770577](https://news.social-protocols.org/stats?id=45770577) #11 38 points 28 comments -> [C++: A prvalue is not a temporary](https://blog.knatten.org/2025/10/31/a-prvalue-is-not-a-temporary/)<!-- HN:45770577:end --><!-- HN:45695282:start -->
* [45695282](https://news.social-protocols.org/stats?id=45695282) #18 44 points 4 comments -> [Writing Advice](https://chadnauseam.com/advice/writing-advice)<!-- HN:45695282:end --><!-- HN:45744518:start -->
* [45744518](https://news.social-protocols.org/stats?id=45744518) #21 60 points 6 comments -> [Springs and Bounces in Native CSS](https://www.joshwcomeau.com/animation/linear-timing-function/)<!-- HN:45744518:end --><!-- HN:45768688:start -->
* [45768688](https://news.social-protocols.org/stats?id=45768688) #30 80 points 14 comments -> [Pico-100BASE-TX: Bit-Banged 100 MBit/s Ethernet and UDP Framer for RP2040/RP2350](https://github.com/steve-m/Pico-100BASE-TX)<!-- HN:45768688:end --><!-- HN:45842380:start -->
* [45842380](https://news.social-protocols.org/stats?id=45842380) #11 55 points 27 comments -> [IRS Ends Direct File](https://www.wsj.com/politics/policy/irs-direct-file-tax-program-ended-00172148)<!-- HN:45842380:end --><!-- HN:45844117:start -->
* [45844117](https://news.social-protocols.org/stats?id=45844117) #6 10 points 6 comments -> [JavaScript Just Leveled Up: ES2025 – You'll Fall in Love With](https://jsdevspace.substack.com/p/javascript-just-leveled-up-es2025)<!-- HN:45844117:end --><!-- HN:45846444:start -->
* [45846444](https://news.social-protocols.org/stats?id=45846444) #8 9 points 7 comments -> [I Work Best Under Stress (and My Family Pays for It)](https://www.codecabin.dev/post/i-work-best-under-stress)<!-- HN:45846444:end --><!-- HN:45848360:start -->
* [45848360](https://news.social-protocols.org/stats?id=45848360) #30 8 points 6 comments -> [Lose weight or lose your jobs, offshore workers told](https://www.bbc.com/news/articles/cx274xp00zxo)<!-- HN:45848360:end --><!-- HN:45849204:start -->
* [45849204](https://news.social-protocols.org/stats?id=45849204) #6 9 points 2 comments -> [Why Zig Is Quietly Doing What Rust Couldn't: Staying Simple](https://freedium-mirror.cfd/@daxx5/why-zig-is-quietly-doing-what-rust-couldnt-staying-simple-a47f86b3a58a)<!-- HN:45849204:end -->
#### **Saturday, November 8, 2025**
<!-- HN:45852859:start -->
* [45852859](https://news.social-protocols.org/stats?id=45852859) #27 31 points 21 comments -> [The Boss Has a Message: Use AI or You're Fired](https://www.wsj.com/tech/ai/ai-work-use-performance-reviews-1e8975df)<!-- HN:45852859:end --><!-- HN:45853519:start -->
* [45853519](https://news.social-protocols.org/stats?id=45853519) #21 10 points 0 comments -> [Turkey issues genocide arrest warrant against Benjamin Netanyahu](https://www.theguardian.com/world/2025/nov/07/turkey-issues-genocide-arrest-warrant-against-benjamin-netanyahu)<!-- HN:45853519:end --><!-- HN:45792012:start -->
* [45792012](https://news.social-protocols.org/stats?id=45792012) #23 12 points 3 comments -> [Cure – Verification-First Programming for the Beam](https://cure-lang.org/index.html)<!-- HN:45792012:end --><!-- HN:45855829:start -->
* [45855829](https://news.social-protocols.org/stats?id=45855829) #29 7 points 0 comments -> [The Tech CEO 'Making No Apologies for the Work with ICE' (Alex Karp)](https://www.politico.com/news/magazine/2025/11/06/alex-karp-book-michael-steinberger-trump-evolution-00638951)<!-- HN:45855829:end --><!-- HN:45856136:start -->
* [45856136](https://news.social-protocols.org/stats?id=45856136) #14 -> [Kagi Small Web](https://kagi.com/smallweb)<!-- HN:45856136:end --><!-- HN:45856640:start -->
* [45856640](https://news.social-protocols.org/stats?id=45856640) #14 28 points 41 comments -> [Things I've Heard Boomers Say That I Agree with 100%](https://wildingout.substack.com/p/12-things-ive-heard-boomers-say-that)<!-- HN:45856640:end --><!-- HN:45856998:start -->
* [45856998](https://news.social-protocols.org/stats?id=45856998) #3 45 points 18 comments -> [Sam Altman Is Getting Desperate and It Is Starting to Show](https://tickerfeed.net/articles/sam-altman-reeks-of-desperation)<!-- HN:45856998:end --><!-- HN:45856563:start -->
* [45856563](https://news.social-protocols.org/stats?id=45856563) #2 24 points 40 comments -> [Why hasn't there been a new major sports league?](https://humaninvariant.substack.com/p/why-hasnt-there-been-a-new-major)<!-- HN:45856563:end --><!-- HN:45857016:start -->
* [45857016](https://news.social-protocols.org/stats?id=45857016) #23 77 points 42 comments -> [Zig is so cool, C is cooler](https://github.com/little-book-of/c/blob/main/articles/zig-is-cool-c-is-cooler.md)<!-- HN:45857016:end --><!-- HN:45799949:start -->
* [45799949](https://news.social-protocols.org/stats?id=45799949) #28 30 points 40 comments -> [Dark mode by local sunlight (2021)](https://www.ctnicholas.dev/articles/dark-mode-by-sunlight)<!-- HN:45799949:end --><!-- HN:45857890:start -->
* [45857890](https://news.social-protocols.org/stats?id=45857890) #13 10 points 2 comments -> [Mothers say chatbots encouraged their sons to kill themselves](https://www.bbc.com/news/articles/ce3xgwyywe4o)<!-- HN:45857890:end --><!-- HN:45801721:start -->
* [45801721](https://news.social-protocols.org/stats?id=45801721) #9 13 points 1 comments -> [What Is a Manifold?](https://www.quantamagazine.org/what-is-a-manifold-20251103/)<!-- HN:45801721:end --><!-- HN:45859840:start -->
* [45859840](https://news.social-protocols.org/stats?id=45859840) #3 82 points 9 comments -> [I want you to understand Chicago](https://aphyr.com/posts)<!-- HN:45859840:end --><!-- HN:45859107:start -->
* [45859107](https://news.social-protocols.org/stats?id=45859107) #24 40 points 45 comments -> [Transparent computer monitor designed to protect your vision](https://www.visualinstruments.co/phantom/display)<!-- HN:45859107:end -->
#### **Sunday, November 9, 2025**<!-- HN:45782713:start -->
* [45782713](https://news.social-protocols.org/stats?id=45782713) #26 65 points 1 comments -> [Syntax and Semantics of Programming Languages](https://homepage.cs.uiowa.edu/~slonnegr/plf/Book/)<!-- HN:45782713:end --><!-- HN:45861635:start -->
* [45861635](https://news.social-protocols.org/stats?id=45861635) #18 36 points 5 comments -> [Judge denies request to exempt Flock footage from Public Records Act](https://www.heraldnet.com/news/judge-denies-request-to-exempt-flock-footage-from-public-records-act/)<!-- HN:45861635:end --><!-- HN:45810589:start -->
* [45810589](https://news.social-protocols.org/stats?id=45810589) #8 10 points 10 comments -> [AI for Senior Software Engineers](https://www.emadibrahim.com/ai-guide)<!-- HN:45810589:end --><!-- HN:45862967:start -->
* [45862967](https://news.social-protocols.org/stats?id=45862967) #28 37 points 9 comments -> [Runc breaks pods when CPU requests aren't multiples of 10](https://github.com/opencontainers/runc/issues/4982)<!-- HN:45862967:end --><!-- HN:45865076:start -->
* [45865076](https://news.social-protocols.org/stats?id=45865076) #4 -> [Maybe Don't Talk to the New York Times About Zohran Mamdani](https://lithub.com/maybe-dont-talk-to-the-new-york-times-about-zohran-mamdani/)<!-- HN:45865076:end --><!-- HN:45868861:start -->
* [45868861](https://news.social-protocols.org/stats?id=45868861) #10 13 points 1 comments -> [Amiga vs. Atari ST: A rivalry that defined 16-bit home computing](https://slicker.me/retrocomputing/amiga_vs_atari_st.htm)<!-- HN:45868861:end --><!-- HN:45869762:start -->
* [45869762](https://news.social-protocols.org/stats?id=45869762) #22 16 points 2 comments -> [German Food Banks Feed 37,000 US Soldiers](https://hanschristensen.substack.com/p/german-food-banks-feed-37000-us-soldiers)<!-- HN:45869762:end -->
#### **Monday, November 10, 2025**
<!-- HN:45820824:start -->
* [45820824](https://news.social-protocols.org/stats?id=45820824) #16 6 points 3 comments -> [Largest panoramic image – 2 Terapixels](https://holmenkollen360.com/)<!-- HN:45820824:end --><!-- HN:45871271:start -->
* [45871271](https://news.social-protocols.org/stats?id=45871271) #3 7 points 9 comments -> [Show HN: LLM Onestop – Access ChatGPT, Claude, Gemini, and more in one interface](https://www.llmonestop.com)<!-- HN:45871271:end --><!-- HN:45865546:start -->
* [45865546](https://news.social-protocols.org/stats?id=45865546) #28 52 points 9 comments -> [Show HN: Pipeflow-PHP – Automate anything with pipelines even non-devs can edit](https://github.com/marcosiino/pipeflow-php)<!-- HN:45865546:end --><!-- HN:45826088:start -->
* [45826088](https://news.social-protocols.org/stats?id=45826088) #8 16 points 18 comments -> [You can just read 25 books](https://a16z.substack.com/p/you-can-just-read-25-books)<!-- HN:45826088:end --><!-- HN:45879151:start -->
* [45879151](https://news.social-protocols.org/stats?id=45879151) #27 7 points 1 comments -> [Texas Sheriff Used Flock ALPR in Abortion Investigation](https://www.eff.org/deeplinks/2025/10/flock-safety-and-texas-sheriff-claimed-license-plate-search-was-missing-person-it)<!-- HN:45879151:end --><!-- HN:45879602:start -->
* [45879602](https://news.social-protocols.org/stats?id=45879602) #17 16 points 9 comments -> [I refuse to date someone who uses ChatGPT](https://www.theguardian.com/lifeandstyle/2025/nov/10/chatgpt-dating-ick)<!-- HN:45879602:end -->
#### **Tuesday, November 11, 2025**
<!-- HN:45882617:start -->
* [45882617](https://news.social-protocols.org/stats?id=45882617) #22 8 points 2 comments -> [Kronecker in (O(p(n)^3): A Novel approach to 80-year-old P-hard problem [pdf]](https://github.com/bon-cdp/notes/blob/main/d.pdf)<!-- HN:45882617:end --><!-- HN:45882640:start -->
* [45882640](https://news.social-protocols.org/stats?id=45882640) #25 8 points 0 comments -> [The most nerdiest VC website that I have ever seen](https://rootventures.coffee/)<!-- HN:45882640:end --><!-- HN:45885013:start -->
* [45885013](https://news.social-protocols.org/stats?id=45885013) #19 6 points 3 comments -> [Show HN: PhantomCollect – Open-Source Web Data Collection Framework in Python](https://github.com/xsser01/phantomcollect)<!-- HN:45885013:end --><!-- HN:45886433:start -->
* [45886433](https://news.social-protocols.org/stats?id=45886433) #25 15 points 5 comments -> [James Watson, dead at 97, was a scientific legend and a pariah among his peers](https://www.statnews.com/2025/11/07/james-watson-remembrance-from-dna-pioneer-to-pariah/)<!-- HN:45886433:end --><!-- HN:45888387:start -->
* [45888387](https://news.social-protocols.org/stats?id=45888387) #12 11 points 0 comments -> [Tired of being manipulated by BigTech?](https://aol.codeberg.page/eci/)<!-- HN:45888387:end -->
#### **Wednesday, November 12, 2025**
<!-- HN:45800094:start -->
* [45800094](https://news.social-protocols.org/stats?id=45800094) #19 8 points 2 comments -> [AV1 vs. H.264: What Video Codec to Choose for Your App?](https://www.red5.net/blog/av1-vs-h264/)<!-- HN:45800094:end -->