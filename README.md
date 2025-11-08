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

#### **Sunday, November 2, 2025**
<!-- HN:45789115:start -->
* [45789115](https://news.social-protocols.org/stats?id=45789115) #23 7 points 2 comments -> [Leaving the Freedesktop.org Community](https://vt.social/@lina/115431232807081648)<!-- HN:45789115:end --><!-- HN:45716371:start -->
* [45716371](https://news.social-protocols.org/stats?id=45716371) #28 18 points 3 comments -> [Hyperbolic Non-Euclidean World (2007)](http://web1.kcn.jp/hp28ah77/)<!-- HN:45716371:end --><!-- HN:45790447:start -->
* [45790447](https://news.social-protocols.org/stats?id=45790447) #7 26 points 11 comments -> [MySafeSpace – Whitehouse.gov](https://www.whitehouse.gov/mysafespace/)<!-- HN:45790447:end --><!-- HN:45740382:start -->
* [45740382](https://news.social-protocols.org/stats?id=45740382) #16 7 points 0 comments -> [Preserving Digital Memory at the Festival of Floppies](https://digitalpreservation-blog.lib.cam.ac.uk/preserving-digital-memory-at-the-festival-of-floppies-200f01092738)<!-- HN:45740382:end --><!-- HN:45792435:start -->
* [45792435](https://news.social-protocols.org/stats?id=45792435) #6 10 points 2 comments -> [Y Combinator Interview Practice Simulation](https://www.kydarin.com/uses/y-combinator-interview-practice-simulation)<!-- HN:45792435:end --><!-- HN:45792958:start -->
* [45792958](https://news.social-protocols.org/stats?id=45792958) #15 36 points 31 comments -> ['This is the big one' – tech firms bet on electrifying rail](https://www.bbc.com/news/articles/czdjg92y00no)<!-- HN:45792958:end -->
#### **Monday, November 3, 2025**
<!-- HN:45706610:start -->
* [45706610](https://news.social-protocols.org/stats?id=45706610) #20 11 points 0 comments -> [OKLCH color picker and converter](https://oklch.com)<!-- HN:45706610:end --><!-- HN:45795413:start -->
* [45795413](https://news.social-protocols.org/stats?id=45795413) #1 78 points 39 comments -> [The Great Decoupling of Labor and Capital](https://www.mbi-deepdives.com/the-great-decoupling-of-labor-and-capital/)<!-- HN:45795413:end --><!-- HN:45794475:start -->
* [45794475](https://news.social-protocols.org/stats?id=45794475) #14 33 points 28 comments -> [I ****Ing Hate Science (2021)](https://buttondown.com/hillelwayne/archive/i-ing-hate-science/)<!-- HN:45794475:end --><!-- HN:45798522:start -->
* [45798522](https://news.social-protocols.org/stats?id=45798522) #20 8 points 2 comments -> [As world rises up for Gaza, Sudanese in Israel say larger catastrophe is ignored](https://www.timesofisrael.com/as-world-rises-up-for-gaza-sudanese-in-israel-say-larger-catastrophe-being-ignored/)<!-- HN:45798522:end --><!-- HN:45798753:start -->
* [45798753](https://news.social-protocols.org/stats?id=45798753) #22 -> [Mar-a-Lago Face](https://en.wikipedia.org/wiki/Mar-a-Lago_face)<!-- HN:45798753:end --><!-- HN:45798750:start -->
* [45798750](https://news.social-protocols.org/stats?id=45798750) #2 16 points 1 comments -> [Linux running in a browser tab via WASM](https://joelseverin.github.io/linux-wasm/)<!-- HN:45798750:end --><!-- HN:45798724:start -->
* [45798724](https://news.social-protocols.org/stats?id=45798724) #5 33 points 1 comments -> [Port of Linux to WebAssembly](https://lore.kernel.org/lkml/618f3602-03aa-46a8-b2d4-3c9798c4cd2b@icemanor.se/)<!-- HN:45798724:end --><!-- HN:45798768:start -->
* [45798768](https://news.social-protocols.org/stats?id=45798768) #20 -> [A Woman Who Predicted Tech Fascism [video]](https://www.youtube.com/watch?v=DL-kwZdkiOA)<!-- HN:45798768:end --><!-- HN:45798975:start -->
* [45798975](https://news.social-protocols.org/stats?id=45798975) #20 11 points 1 comments -> [She Was Ready to Have Her 15th Child. Then Came the Felony Charges](https://www.nytimes.com/2025/11/02/magazine/marybeth-lewis-13-children-felony-charges.html)<!-- HN:45798975:end --><!-- HN:45799652:start -->
* [45799652](https://news.social-protocols.org/stats?id=45799652) #15 10 points 0 comments -> [Uv Crash Course](https://lernerpython.com/uv-crash-course/)<!-- HN:45799652:end --><!-- HN:45799719:start -->
* [45799719](https://news.social-protocols.org/stats?id=45799719) #4 11 points 2 comments -> [Israeli military's ex-top lawyer arrested as scandal over video leak deepens](https://www.bbc.com/news/articles/cy0kpd97qqko)<!-- HN:45799719:end --><!-- HN:45801221:start -->
* [45801221](https://news.social-protocols.org/stats?id=45801221) #20 14 points 10 comments -> [Show HN: I was tired of wasting engineer time on screening calls so I built Niju](https://niju.dev)<!-- HN:45801221:end --><!-- HN:45801455:start -->
* [45801455](https://news.social-protocols.org/stats?id=45801455) #17 3 points 0 comments -> [Your Infra Isn't Special: Why Open Source Infrastructure as Code (IaC) Wins](https://masterpoint.io/blog/why-open-source-iac-wins/)<!-- HN:45801455:end --><!-- HN:45802248:start -->
* [45802248](https://news.social-protocols.org/stats?id=45802248) #16 32 points 12 comments -> [America is bracing for political violence – and significant portion think its OK](https://www.politico.com/news/2025/11/03/poll-americans-political-violence-00632864)<!-- HN:45802248:end --><!-- HN:45802600:start -->
* [45802600](https://news.social-protocols.org/stats?id=45802600) #13 11 points 7 comments -> [The Stallman Paradox: How Web3 Became the Ultimate Open Source Theater](https://paragraph.com/@holonic-horizons/the-stallman-paradox-how-web3-became-the-ultimate-open-source-theater)<!-- HN:45802600:end -->
#### **Tuesday, November 4, 2025**<!-- HN:45806945:start -->
* [45806945](https://news.social-protocols.org/stats?id=45806945) #18 -> [A robotaxi killed a beloved SF cat; city supervisor wants driverless car reform](https://www.sfchronicle.com/sf/article/waymo-killed-cat-21136038.php)<!-- HN:45806945:end --><!-- HN:45728889:start -->
* [45728889](https://news.social-protocols.org/stats?id=45728889) #15 10 points 0 comments -> [Is Your Data Valid? Why Bufstream Guarantees What Kafka Can't](https://vutr.substack.com/p/is-your-data-valid-why-bufstream)<!-- HN:45728889:end --><!-- HN:45812565:start -->
* [45812565](https://news.social-protocols.org/stats?id=45812565) #28 6 points 5 comments -> [America's electric car market runs out of juice with sales plunging much as 80%](https://www.dailymail.co.uk/yourmoney/article-15254869/america-ev-sales-market-ford-hyundai-toyota.html)<!-- HN:45812565:end --><!-- HN:45814285:start -->
* [45814285](https://news.social-protocols.org/stats?id=45814285) #9 3 points 0 comments -> [Arguably the prettiest selfhosting services dashboard](https://github.com/deyaa1251/HostMonk)<!-- HN:45814285:end --><!-- HN:45814522:start -->
* [45814522](https://news.social-protocols.org/stats?id=45814522) #12 26 points 21 comments -> [Man spent 200 days building a solar-powered explorer yacht that can run forever](https://supercarblondie.com/solar-powered-explorer-yacht-helios-11/)<!-- HN:45814522:end --><!-- HN:45816946:start -->
* [45816946](https://news.social-protocols.org/stats?id=45816946) #25 23 points 15 comments -> [Border Patrol agent testifies sandwich thrown at him "exploded all over,"](https://www.cbsnews.com/news/sean-dunn-trial-dc-sandwich-thrower-testimony-onions-mustard/)<!-- HN:45816946:end -->
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
* [45856640](https://news.social-protocols.org/stats?id=45856640) #14 28 points 41 comments -> [Things I've Heard Boomers Say That I Agree with 100%](https://wildingout.substack.com/p/12-things-ive-heard-boomers-say-that)<!-- HN:45856640:end -->