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
* [45800094](https://news.social-protocols.org/stats?id=45800094) #19 8 points 2 comments -> [AV1 vs. H.264: What Video Codec to Choose for Your App?](https://www.red5.net/blog/av1-vs-h264/)<!-- HN:45800094:end --><!-- HN:45895231:start -->
* [45895231](https://news.social-protocols.org/stats?id=45895231) #5 7 points 3 comments -> [The US Do Not Call registry is offline](https://www.donotcall.gov/)<!-- HN:45895231:end --><!-- HN:45808149:start -->
* [45808149](https://news.social-protocols.org/stats?id=45808149) #22 3 points 1 comments -> [The AI Localhost](https://getairbook.notion.site/The-AI-Localhost-2a1d4a82803d802a8753ffbcfa985664?source=copy_link)<!-- HN:45808149:end --><!-- HN:45898880:start -->
* [45898880](https://news.social-protocols.org/stats?id=45898880) #4 7 points 1 comments -> [Israeli settlers set fire to Palestinian warehouse and land](https://www.bbc.com/news/articles/c78zygz4xg9o)<!-- HN:45898880:end --><!-- HN:45898693:start -->
* [45898693](https://news.social-protocols.org/stats?id=45898693) #16 4 points 0 comments -> [Show HN: Hotkey → Screenshot → AI Help. Works in Every App](https://github.com/thisisharsh7/seeva-ai-assistant)<!-- HN:45898693:end --><!-- HN:45847033:start -->
* [45847033](https://news.social-protocols.org/stats?id=45847033) #19 11 points 0 comments -> [Show HN: XML-Lib – An over-engineered XML workflow with guardrails and proofs](https://github.com/farukalpay/xml-lib)<!-- HN:45847033:end --><!-- HN:45901464:start -->
* [45901464](https://news.social-protocols.org/stats?id=45901464) #21 9 points 10 comments -> [Two women had a business meeting. AI called it childcare](https://medium.com/hold-my-juice/two-women-had-a-business-meeting-ai-called-it-childcare-6b09f5952940)<!-- HN:45901464:end --><!-- HN:45901274:start -->
* [45901274](https://news.social-protocols.org/stats?id=45901274) #11 6 points 2 comments -> [Testing out Crush, a TUI based coding agent](https://grahamhelton.com/blog/crushing-it)<!-- HN:45901274:end --><!-- HN:45897457:start -->
* [45897457](https://news.social-protocols.org/stats?id=45897457) #22 297 points 213 comments -> [Please donate to keep Network Time Protocol up – Goal 1k](https://www.ntp.org/)<!-- HN:45897457:end --><!-- HN:45796709:start -->
* [45796709](https://news.social-protocols.org/stats?id=45796709) #20 7 points 0 comments -> [Being "Seen" and Feeling Part Of](https://growingfearless.substack.com/p/on-being-seen)<!-- HN:45796709:end -->
#### **Thursday, November 13, 2025**<!-- HN:45908680:start -->
* [45908680](https://news.social-protocols.org/stats?id=45908680) #30 72 points 33 comments -> [Louisiana Took Months to Sound Alarm Amid Whooping Cough Outbreak](https://undark.org/2025/11/11/louisiana-whooping-cough-slow/)<!-- HN:45908680:end --><!-- HN:45903840:start -->
* [45903840](https://news.social-protocols.org/stats?id=45903840) #30 388 points 122 comments -> [Valve Announces New Steam Machine, Steam Controller and Steam Frame](https://www.phoronix.com/news/Steam-Machines-Frame-2026)<!-- HN:45903840:end --><!-- HN:45910370:start -->
* [45910370](https://news.social-protocols.org/stats?id=45910370) #2 79 points 18 comments -> [A67z](https://www.a67z.com/)<!-- HN:45910370:end --><!-- HN:45910622:start -->
* [45910622](https://news.social-protocols.org/stats?id=45910622) #16 11 points 1 comments -> [Robert Moses's unfinished business should be Mamdani's priority](https://www.eatingpolicy.com/p/robert-mosess-unfinished-business)<!-- HN:45910622:end --><!-- HN:45913319:start -->
* [45913319](https://news.social-protocols.org/stats?id=45913319) #8 18 points 11 comments -> [fuckborderradius.com](https://fuckborderradius.com)<!-- HN:45913319:end --><!-- HN:45915674:start -->
* [45915674](https://news.social-protocols.org/stats?id=45915674) #16 20 points 14 comments -> [No Competition? That's Usually a Red Flag for Solopreneurs](https://meysam.io/blog/no-competition-red-flag-solopreneur-validated-market/)<!-- HN:45915674:end --><!-- HN:45916093:start -->
* [45916093](https://news.social-protocols.org/stats?id=45916093) #10 6 points 1 comments -> [We're Real Fucked](https://abermoo.wordpress.com/2025/11/13/were-real-fucked/)<!-- HN:45916093:end --><!-- HN:45917830:start -->
* [45917830](https://news.social-protocols.org/stats?id=45917830) #11 14 points 40 comments -> [Let AI do the hard parts of your holiday shopping](https://blog.google/products/shopping/agentic-checkout-holiday-ai-shopping/)<!-- HN:45917830:end --><!-- HN:45916146:start -->
* [45916146](https://news.social-protocols.org/stats?id=45916146) #20 236 points 213 comments -> [Tesla Is Recalling Cybertrucks Again. Yep, More Pieces Are Falling Off](https://www.popularmechanics.com/cars/hybrid-electric/a69384091/cybertruck-lightbar-recall/)<!-- HN:45916146:end --><!-- HN:45917618:start -->
* [45917618](https://news.social-protocols.org/stats?id=45917618) #4 133 points 47 comments -> [Rand Paul: Congress bill destroys hemp farmer livelihoods](https://www.courier-journal.com/story/opinion/contributors/2025/11/13/rand-paul-congress-funding-bill-hemp-products-farmers/87247317007/)<!-- HN:45917618:end --><!-- HN:45919058:start -->
* [45919058](https://news.social-protocols.org/stats?id=45919058) #14 16 points 9 comments -> [How to Grow your Startup Fast in 2025](https://founderpath.com/blog/how-to-grow-startup-growth-hacks)<!-- HN:45919058:end --><!-- HN:45913663:start -->
* [45913663](https://news.social-protocols.org/stats?id=45913663) #30 102 points 49 comments -> [Hack Club has been handling children's data for 4 years without a privacy policy](https://kys.llc/blog/my-hackclub-story)<!-- HN:45913663:end --><!-- HN:45921066:start -->
* [45921066](https://news.social-protocols.org/stats?id=45921066) #4 -> [I'm sorry, but you do not have enough coins for democracy](https://magazine.032c.com/magazine/i-m-sorry-but-you-do-not-have-enough-coins-for-democracy)<!-- HN:45921066:end --><!-- HN:45921334:start -->
* [45921334](https://news.social-protocols.org/stats?id=45921334) #3 24 points 6 comments -> [Disrupting the first reported AI-orchestrated cyber espionage campaign [pdf]](https://assets.anthropic.com/m/ec212e6566a0d47/original/Disrupting-the-first-reported-AI-orchestrated-cyber-espionage-campaign.pdf)<!-- HN:45921334:end -->
#### **Friday, November 14, 2025**
<!-- HN:45798762:start -->
* [45798762](https://news.social-protocols.org/stats?id=45798762) #9 7 points 4 comments -> [Prefer Boring Technology](https://itwont.work/blog/prefer-boring-technology)<!-- HN:45798762:end --><!-- HN:45923106:start -->
* [45923106](https://news.social-protocols.org/stats?id=45923106) #18 3 points 1 comments -> [What Technologies Are Running on 50k Websites (Oct 2025)](https://www.dropbox.com/scl/fi/xu8m2kzeu5z3wurvilb9t/oct_2025_jumbo_sample.zip?dl=0&e=1&noscript=1&rlkey=ygusc6p42ipo0kmma8oswqf16&st=gb0hctyl)<!-- HN:45923106:end -->