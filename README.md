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

#### **Saturday, March 8, 2025**
<!-- HN:43296131:start -->
* [43296131](https://news.social-protocols.org/stats?id=43296131) #17 12 points 1 comments -> ['Elon killed my resale': Bay Area Tesla owners using stickers to avoid backlash](https://www.sfchronicle.com/bayarea/article/tesla-elon-musk-backlash-20206901.php)<!-- HN:43296131:end --><!-- HN:43251868:start -->
* [43251868](https://news.social-protocols.org/stats?id=43251868) #10 17 points 40 comments -> [The German language broke my website](https://speedbumpapp.com/en/blog/german-translation/)<!-- HN:43251868:end --><!-- HN:43297671:start -->
* [43297671](https://news.social-protocols.org/stats?id=43297671) #21 20 points 4 comments -> [It is hard to recommend Python in production](https://ashishb.net/programming/python-in-production/)<!-- HN:43297671:end --><!-- HN:43297168:start -->
* [43297168](https://news.social-protocols.org/stats?id=43297168) #25 8 points 1 comments -> [Exploring the Hybrid Debian GNU/KFreeBSD Distribution](https://www.linuxjournal.com/content/exploring-hybrid-debian-gnukfreebsd-distribution)<!-- HN:43297168:end --><!-- HN:43296886:start -->
* [43296886](https://news.social-protocols.org/stats?id=43296886) #10 103 points 21 comments -> [Take It Down Act: A Flawed Attempt to Protect Victims That'll Lead to Censorship](https://www.eff.org/deeplinks/2025/02/take-it-down-act-flawed-attempt-protect-victims-will-lead-censorship)<!-- HN:43296886:end --><!-- HN:43296765:start -->
* [43296765](https://news.social-protocols.org/stats?id=43296765) #28 12 points 0 comments -> [Revenge Font](https://revengefont.com/)<!-- HN:43296765:end --><!-- HN:43259146:start -->
* [43259146](https://news.social-protocols.org/stats?id=43259146) #12 16 points 1 comments -> [2025-03-01 the cold glow of tritium](https://computer.rip/2025-03-01-the-cold-glow-of-tritium.html)<!-- HN:43259146:end --><!-- HN:43256878:start -->
* [43256878](https://news.social-protocols.org/stats?id=43256878) #23 18 points 4 comments -> [I hacked my company's SSO provider](https://mattsayar.com/how-i-hacked-my-companys-sso-provider/)<!-- HN:43256878:end --><!-- HN:43267232:start -->
* [43267232](https://news.social-protocols.org/stats?id=43267232) #17 8 points 2 comments -> [Show HN: AI art generation faster than Midjourney](https://www.gentube.app/?_cid=np)<!-- HN:43267232:end --><!-- HN:43266327:start -->
* [43266327](https://news.social-protocols.org/stats?id=43266327) #14 39 points 49 comments -> [Qualcomm Claims New X85 Modem Creates 'Huge Delta' in Performance versus Apple](https://www.macrumors.com/2025/03/05/qualcomm-claims-x85-modem-better-than-apple/)<!-- HN:43266327:end --><!-- HN:43226052:start -->
* [43226052](https://news.social-protocols.org/stats?id=43226052) #24 116 points 22 comments -> [Unleashed Recompiled: PC port of the Xbox 360 version of Sonic Unleashed](https://github.com/hedge-dev/UnleashedRecomp)<!-- HN:43226052:end --><!-- HN:43302097:start -->
* [43302097](https://news.social-protocols.org/stats?id=43302097) #5 175 points 2 comments -> [Google will still have to break up its business, the Justice Department said](https://www.engadget.com/big-tech/google-will-still-have-to-break-up-its-business-the-justice-department-said-150000739.html)<!-- HN:43302097:end --><!-- HN:43302563:start -->
* [43302563](https://news.social-protocols.org/stats?id=43302563) #26 14 points 2 comments -> [Linear Pluggable Optics Save Energy in Data Centers](https://semiengineering.com/linear-pluggable-optics-save-energy-in-data-centers/)<!-- HN:43302563:end --><!-- HN:43303943:start -->
* [43303943](https://news.social-protocols.org/stats?id=43303943) #22 15 points 7 comments -> [Backdoor detected in ESP32 Espressif IoT chip](https://www.tarlogic.com/news/backdoor-esp32-chip-infect-ot-devices/)<!-- HN:43303943:end --><!-- HN:43304253:start -->
* [43304253](https://news.social-protocols.org/stats?id=43304253) #4 6 points 0 comments -> [The Lie That Facebook Sold You](https://havenweb.org/2022/11/02/facebook-lie.html)<!-- HN:43304253:end -->
#### **Sunday, March 9, 2025**
<!-- HN:43304971:start -->
* [43304971](https://news.social-protocols.org/stats?id=43304971) #18 7 points 2 comments -> [Tesla Cybertruck Banned and Seized by Police in the U.K](https://www.forbes.com/sites/peterlyon/2025/02/20/tesla-cybertruck-banned-in-the-uk-due-to-safety-issues/)<!-- HN:43304971:end --><!-- HN:43305375:start -->
* [43305375](https://news.social-protocols.org/stats?id=43305375) #13 12 points 2 comments -> [US 'to cease all future military exercises in Europe'](https://www.telegraph.co.uk/us/politics/2025/03/08/us-to-cease-all-future-military-exercises-in-europe-reports/)<!-- HN:43305375:end --><!-- HN:43304567:start -->
* [43304567](https://news.social-protocols.org/stats?id=43304567) #4 23 points 40 comments -> [Toward a Passwordless Future](https://www.privacyguides.org/articles/2025/03/08/toward-a-passwordless-future/)<!-- HN:43304567:end --><!-- HN:43287345:start -->
* [43287345](https://news.social-protocols.org/stats?id=43287345) #27 9 points 0 comments -> [The trap of the top-down approach](https://www.cryptologie.net/article/625/the-trap-of-the-top-down-approach/)<!-- HN:43287345:end --><!-- HN:43305683:start -->
* [43305683](https://news.social-protocols.org/stats?id=43305683) #13 27 points 23 comments -> [YouTube, when the walls fell [video]](https://www.youtube.com/watch?v=l0jw_Q23NIU)<!-- HN:43305683:end --><!-- HN:43306027:start -->
* [43306027](https://news.social-protocols.org/stats?id=43306027) #7 5 points 2 comments -> [GTA 6 fans gutted after learning it will be unplayable for PC Players at launch](https://www.gamingbible.com/news/gta-6-unplayable-launch-696549-20250307)<!-- HN:43306027:end --><!-- HN:43306192:start -->
* [43306192](https://news.social-protocols.org/stats?id=43306192) #29 43 points 24 comments -> [State Department Will Use AI to Search for 'Pro-Hamas' Students to Deport](https://gizmodo.com/state-department-will-use-ai-to-search-for-pro-hamas-students-to-deport-2000573143)<!-- HN:43306192:end --><!-- HN:43267291:start -->
* [43267291](https://news.social-protocols.org/stats?id=43267291) #29 29 points 40 comments -> [Time for a Change: The long, contentious history of time shifts](https://worldhistory.substack.com/p/time-for-a-change)<!-- HN:43267291:end --><!-- HN:43307229:start -->
* [43307229](https://news.social-protocols.org/stats?id=43307229) #1 16 points 20 comments -> [Rust vs. Go: Battle for the Back End](https://effective-programmer.com/rust-vs-go-battle-for-the-backend-368f775de9fc)<!-- HN:43307229:end --><!-- HN:43306839:start -->
* [43306839](https://news.social-protocols.org/stats?id=43306839) #11 12 points 1 comments -> [Becoming a Good Engineer](https://0x0001.cc/blog/good-engineer.md)<!-- HN:43306839:end --><!-- HN:43308852:start -->
* [43308852](https://news.social-protocols.org/stats?id=43308852) #17 3 points 0 comments -> [Developer guilty of using kill switch to sabotage employer's systems](https://www.bleepingcomputer.com/news/security/developer-guilty-of-using-kill-switch-to-sabotage-employers-systems/)<!-- HN:43308852:end --><!-- HN:43309485:start -->
* [43309485](https://news.social-protocols.org/stats?id=43309485) #23 4 points 0 comments -> [DHS Detains Lead Negotiator of Columbia Encampment](https://www.dropsitenews.com/p/dhs-detains-columbia-university-student-gaza)<!-- HN:43309485:end --><!-- HN:43311025:start -->
* [43311025](https://news.social-protocols.org/stats?id=43311025) #15 9 points 0 comments -> [DOGE's Cuts to the IRS Threaten to Cost More Than Doge Will Ever Save](https://www.propublica.org/article/how-doge-irs-cuts-will-cost-more-than-savings-trump-musk-deficit)<!-- HN:43311025:end --><!-- HN:43310634:start -->
* [43310634](https://news.social-protocols.org/stats?id=43310634) #22 14 points 3 comments -> [Reasons veterans are especially hard-hit by federal cuts](https://theconversation.com/5-reasons-veterans-are-especially-hard-hit-by-federal-cuts-251188)<!-- HN:43310634:end --><!-- HN:43279870:start -->
* [43279870](https://news.social-protocols.org/stats?id=43279870) #10 9 points 3 comments -> [BBS from Scratch](https://bbsfromscratch.com/)<!-- HN:43279870:end --><!-- HN:43312242:start -->
* [43312242](https://news.social-protocols.org/stats?id=43312242) #28 8 points 3 comments -> [Violent and sudden. What a firing squad execution looked like through my eyes](https://apnews.com/article/south-carolina-firing-squad-eyewitness-account-sigmon-427cccb55be58954af4434e89bcc41d8)<!-- HN:43312242:end --><!-- HN:43312516:start -->
* [43312516](https://news.social-protocols.org/stats?id=43312516) #9 32 points 12 comments -> [Poland says it may need alternative to Musk’s Starlink in Ukraine](https://www.reuters.com/world/europe/poland-says-it-may-need-alternative-musks-starlink-ukraine-2025-03-09/)<!-- HN:43312516:end --><!-- HN:43312920:start -->
* [43312920](https://news.social-protocols.org/stats?id=43312920) #3 14 points 2 comments -> [H.R. 1936: To prohibit funds for the USAF to invade Canada, Panama, or Greenland](https://www.govtrack.us/congress/bills/119/hr1936)<!-- HN:43312920:end --><!-- HN:43313398:start -->
* [43313398](https://news.social-protocols.org/stats?id=43313398) #12 8 points 1 comments -> [Can the US switch off Europe's weapons?](https://www.ft.com/content/1503a69e-13e4-4ee8-9d05-b9ce1f7cc89e)<!-- HN:43313398:end --><!-- HN:43313341:start -->
* [43313341](https://news.social-protocols.org/stats?id=43313341) #13 20 points 11 comments -> [Top links on Bluesky, Updated Hourly](https://theblue.report)<!-- HN:43313341:end --><!-- HN:43279939:start -->
* [43279939](https://news.social-protocols.org/stats?id=43279939) #15 28 points 1 comments -> [Graphite: Node-based, non-destructive, procedural 2D vector editor](https://github.com/GraphiteEditor/Graphite)<!-- HN:43279939:end --><!-- HN:43314301:start -->
* [43314301](https://news.social-protocols.org/stats?id=43314301) #14 12 points 1 comments -> [US authorities arrest Palestinian student protester at Columbia University](https://www.reuters.com/world/us/us-authorities-arrest-palestinian-student-protester-columbia-university-students-2025-03-09/)<!-- HN:43314301:end --><!-- HN:43314809:start -->
* [43314809](https://news.social-protocols.org/stats?id=43314809) #25 -> [The Fascist Tech Bro Takeover Is Here](https://www.theindex.media/the-fascist-tech-bro-takeover-is-here-2/)<!-- HN:43314809:end --><!-- HN:43283214:start -->
* [43283214](https://news.social-protocols.org/stats?id=43283214) #26 7 points 0 comments -> [Japan's Clever Anti-Snow Roadways](https://www.core77.com/posts/135763/Japans-Clever-Anti-Snow-Roadways)<!-- HN:43283214:end -->
#### **Monday, March 10, 2025**
<!-- HN:43314994:start -->
* [43314994](https://news.social-protocols.org/stats?id=43314994) #23 47 points 10 comments -> [ICE arrests Palestinian activist who helped lead Columbia University protests](https://apnews.com/article/columbia-university-mahmoud-khalil-ice-15014bcbb921f21a9f704d5acdcae7a8)<!-- HN:43314994:end --><!-- HN:43315046:start -->
* [43315046](https://news.social-protocols.org/stats?id=43315046) #25 34 points 13 comments -> [Tesla Used Car Price Crashes – Model Y, Model 3 Deals Explode](https://www.forbes.com/sites/brookecrothers/2025/03/09/tesla-used-car-price-crashes--model-y-model-3-deals-explode/)<!-- HN:43315046:end --><!-- HN:43283271:start -->
* [43283271](https://news.social-protocols.org/stats?id=43283271) #12 6 points 1 comments -> [Pompey's Greatest Show on Earth](https://www.historytoday.com/archive/history-matters/pompeys-greatest-show-earth)<!-- HN:43283271:end --><!-- HN:43316469:start -->
* [43316469](https://news.social-protocols.org/stats?id=43316469) #21 5 points 1 comments -> [The US economy is heading for recession](https://www.ft.com/content/078780dd-16e0-45e4-b281-c70d59cc07ee)<!-- HN:43316469:end --><!-- HN:43316590:start -->
* [43316590](https://news.social-protocols.org/stats?id=43316590) #26 5 points 1 comments -> [Columbia Expelled Student Protesters For the First Time in Over 50 Years](https://www.thenation.com/article/activism/columbia-expels-student-protesters-milstein-library/)<!-- HN:43316590:end --><!-- HN:43316237:start -->
* [43316237](https://news.social-protocols.org/stats?id=43316237) #25 8 points 1 comments -> [Tesla Showroom Set on Fire](https://www.hindustantimes.com/trending/tesla-showroom-set-on-fire-12-cars-destroyed-in-suspected-arson-attack-in-france-101741243979863.html)<!-- HN:43316237:end --><!-- HN:43316724:start -->
* [43316724](https://news.social-protocols.org/stats?id=43316724) #20 12 points 0 comments -> ['Nobody will trust a US treaty again,' and the yen is new safe haven](https://fortune.com/2025/03/09/us-treaty-nato-ukraine-russia-trump-japan-yen-safe-haven-dedollarization/)<!-- HN:43316724:end --><!-- HN:43314171:start -->
* [43314171](https://news.social-protocols.org/stats?id=43314171) #23 100 points 14 comments -> [Apple rearranged its XNU kernel with exclaves](https://www.theregister.com/2025/03/08/kernel_sanders_apple_rearranges_xnu/)<!-- HN:43314171:end --><!-- HN:43316556:start -->
* [43316556](https://news.social-protocols.org/stats?id=43316556) #28 24 points 10 comments -> [Free95: An open-source windows-compatible operating system](https://github.com/Versoft-Software/Free95)<!-- HN:43316556:end --><!-- HN:43317954:start -->
* [43317954](https://news.social-protocols.org/stats?id=43317954) #27 34 points 10 comments -> [Another late-night Claude Code post](https://twitter.com/Steve_Yegge/status/1898993080931611112)<!-- HN:43317954:end --><!-- HN:43318709:start -->
* [43318709](https://news.social-protocols.org/stats?id=43318709) #19 13 points 6 comments -> [Is X Down?](https://downdetector.in/status/twitter/)<!-- HN:43318709:end --><!-- HN:43318094:start -->
* [43318094](https://news.social-protocols.org/stats?id=43318094) #11 13 points 23 comments -> [Show HN: Back to one-time end-to-end encrypted anonymous chats in 2025](https://www.yaps.chat/)<!-- HN:43318094:end --><!-- HN:43290704:start -->
* [43290704](https://news.social-protocols.org/stats?id=43290704) #16 25 points 40 comments -> [Nomars: No Manning Required Ship](https://www.darpa.mil/research/programs/no-manning-required-ship)<!-- HN:43290704:end --><!-- HN:43317406:start -->
* [43317406](https://news.social-protocols.org/stats?id=43317406) #24 105 points 66 comments -> [Llama.cpp AI Performance with the GeForce RTX 5090 Review](https://www.phoronix.com/review/nvidia-rtx5090-llama-cpp)<!-- HN:43317406:end --><!-- HN:43320980:start -->
* [43320980](https://news.social-protocols.org/stats?id=43320980) #30 8 points 3 comments -> [What a Wrongful Death Lawsuit Reveals About America's Largest Oxygen Provider](https://www.propublica.org/article/lincare-wrongful-death-lawsuit-sleep-apnea-oxygen)<!-- HN:43320980:end --><!-- HN:43294756:start -->
* [43294756](https://news.social-protocols.org/stats?id=43294756) #16 44 points 14 comments -> [From Prompt to Adventures:Creating Games with LLMs and Restate Durable Functions](https://restate.dev/blog/from-prompt-to-adventures-creating-games-with-llms-and-restates-durable-functions/)<!-- HN:43294756:end --><!-- HN:43322481:start -->
* [43322481](https://news.social-protocols.org/stats?id=43322481) #20 6 points 0 comments -> [Wealthy Colleges Fight to Protect Their Riches from Taxation](https://www.bloomberg.com/news/articles/2025-03-10/wealthiest-colleges-fight-to-protect-their-riches-from-taxation)<!-- HN:43322481:end --><!-- HN:43322896:start -->
* [43322896](https://news.social-protocols.org/stats?id=43322896) #25 5 points 1 comments -> [George Washington knew difference between running a business vs. the government](https://theconversation.com/george-washington-a-real-estate-investor-and-successful-entrepreneur-knew-the-difference-between-running-a-business-and-running-the-government-250332)<!-- HN:43322896:end --><!-- HN:43323812:start -->
* [43323812](https://news.social-protocols.org/stats?id=43323812) #13 -> [Anonymous: We are here to fight against fasciscm that has taken root in America](https://opdreadnought.com)<!-- HN:43323812:end --><!-- HN:43323652:start -->
* [43323652](https://news.social-protocols.org/stats?id=43323652) #14 110 points 88 comments -> [Wall Street sell-off turns 'ugly' as US recession fears grow](https://www.independent.co.uk/business/wall-street-selloff-turns-ugly-as-us-recession-fears-grow-b2712420.html)<!-- HN:43323652:end --><!-- HN:43324220:start -->
* [43324220](https://news.social-protocols.org/stats?id=43324220) #9 14 points 11 comments -> [I quit my FAANG job because it'll be automated by the end of the year (2025)](https://jagilley.github.io/faang-blog.html)<!-- HN:43324220:end --><!-- HN:43325019:start -->
* [43325019](https://news.social-protocols.org/stats?id=43325019) #16 27 points 19 comments -> [We've been wrong about math for 2300 years](https://davidbessis.substack.com/p/weve-been-wrong-about-math-for-2300)<!-- HN:43325019:end --><!-- HN:43326554:start -->
* [43326554](https://news.social-protocols.org/stats?id=43326554) #6 6 points 0 comments -> [Leningrad-1: a 44-IC Soviet style ZX-Spectrum clone](https://alex-j-lowry.github.io/leningrd.html)<!-- HN:43326554:end -->
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
* [43364088](https://news.social-protocols.org/stats?id=43364088) #17 7 points 1 comments -> [The Tyranny of Work or Why Are We Still Measured by Our Productivity?](https://anticapitalistmusings.com/2025/03/the-tyranny-of-work-or-why-are-we-still-measured-by-our-productivity/)<!-- HN:43364088:end -->