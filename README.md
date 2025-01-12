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

#### **Monday, January 6, 2025**
<!-- HN:42606958:start -->
* [42606958](https://news.social-protocols.org/stats?id=42606958) #10 21 points 10 comments -> [Kentucky Cops Raid Wrong Home, Kill Innocent Man over Alleged Stolen Weed Eater](https://atlantablackstar.com/2024/12/31/kentucky-cops-raid-wrong-home-kill-man-over-alleged-stolen-weed-eater/)<!-- HN:42606958:end --><!-- HN:42573761:start -->
* [42573761](https://news.social-protocols.org/stats?id=42573761) #25 19 points 5 comments -> [The Maxwell-Heaviside Equations Explained by the Theory of Informatons](https://www.researchgate.net/publication/382229137_The_Maxwell-Heaviside_Equations_Explained_by_the_Theory_of_Informatons)<!-- HN:42573761:end --><!-- HN:42607682:start -->
* [42607682](https://news.social-protocols.org/stats?id=42607682) #15 17 points 40 comments -> [Show HN: I made it easy to create invoices](https://www.invoicefast.io)<!-- HN:42607682:end --><!-- HN:42585221:start -->
* [42585221](https://news.social-protocols.org/stats?id=42585221) #12 46 points 14 comments -> [My approach to running a link blog](https://simonwillison.net/2024/Dec/22/link-blog/)<!-- HN:42585221:end --><!-- HN:42607455:start -->
* [42607455](https://news.social-protocols.org/stats?id=42607455) #16 39 points 31 comments -> [Magic Links Have Rough Edges, but Passkeys Can Smooth Them Over](https://rmondello.com/2025/01/02/magic-links-and-passkeys/)<!-- HN:42607455:end --><!-- HN:42608470:start -->
* [42608470](https://news.social-protocols.org/stats?id=42608470) #20 -> [Why Computer Scientists Consult Oracles](https://www.quantamagazine.org/why-computer-scientists-consult-oracles-20250103/)<!-- HN:42608470:end --><!-- HN:42607087:start -->
* [42607087](https://news.social-protocols.org/stats?id=42607087) #24 109 points 128 comments -> [Printf Debugging Is OK](https://www.polymonster.co.uk/blog/printf-debugging-is-ok)<!-- HN:42607087:end --><!-- HN:42606231:start -->
* [42606231](https://news.social-protocols.org/stats?id=42606231) #29 203 points 72 comments -> [Killed by LLM](https://r0bk.github.io/killedbyllm/)<!-- HN:42606231:end --><!-- HN:42552016:start -->
* [42552016](https://news.social-protocols.org/stats?id=42552016) #20 131 points 303 comments -> [Why was there a wall near runway at S Korea plane crash airport?](https://www.bbc.com/news/articles/c0mvynnxzzmo)<!-- HN:42552016:end --><!-- HN:42609948:start -->
* [42609948](https://news.social-protocols.org/stats?id=42609948) #18 4 points 0 comments -> [4chan became the home of the elite reader](https://www.newstatesman.com/culture/2025/01/how-4chan-became-the-home-of-the-elite-reader)<!-- HN:42609948:end --><!-- HN:42610204:start -->
* [42610204](https://news.social-protocols.org/stats?id=42610204) #20 4 points 0 comments -> [Chromebooks still set for scrap, even with 10-year lifecycle](https://www.theregister.com/2025/01/06/chromebook_end_of_life/)<!-- HN:42610204:end --><!-- HN:42589672:start -->
* [42589672](https://news.social-protocols.org/stats?id=42589672) #13 -> [The Gentrification of Video Game History](https://felipepepe.medium.com/the-gentrification-of-video-game-history-dfe11f1e08ae)<!-- HN:42589672:end --><!-- HN:42608925:start -->
* [42608925](https://news.social-protocols.org/stats?id=42608925) #17 42 points 4 comments -> [Modern Generic SVGA driver for Windows 3.1](https://github.com/PluMGMK/vbesvga.drv)<!-- HN:42608925:end --><!-- HN:42611993:start -->
* [42611993](https://news.social-protocols.org/stats?id=42611993) #20 6 points 0 comments -> [Canadian Prime Minister Trudeau Resigns](https://apnews.com/live/justin-trudeau-canada-prime-minister)<!-- HN:42611993:end --><!-- HN:42609865:start -->
* [42609865](https://news.social-protocols.org/stats?id=42609865) #30 33 points 9 comments -> [Show HN: SPath is a Rust lib for query JSONPath over any semi-structured data](https://github.com/cratesland/spath)<!-- HN:42609865:end --><!-- HN:42613134:start -->
* [42613134](https://news.social-protocols.org/stats?id=42613134) #26 4 points 0 comments -> [Ford and Musk. They Made Cars. They Backed Fascists](https://prospect.org/power/2025-01-06-ford-musk-made-cars-backed-fascists/)<!-- HN:42613134:end --><!-- HN:42612453:start -->
* [42612453](https://news.social-protocols.org/stats?id=42612453) #21 8 points 1 comments -> [Getting LLMs to Generate Funny Memes Is Unexpectedly Hard](https://www.greptile.com/blog/reporoast)<!-- HN:42612453:end --><!-- HN:42614848:start -->
* [42614848](https://news.social-protocols.org/stats?id=42614848) #27 4 points 0 comments -> [Persistent spike protein in brain may contribute to sequelae of Covid-19](https://www.cell.com/cell-host-microbe/fulltext/S1931-3128(24)00438-4?_returnURL=https%3A%2F%2Flinkinghub.elsevier.com%2Fretrieve%2Fpii%2FS1931312824004384%3Fshowall%3Dtrue)<!-- HN:42614848:end --><!-- HN:42592970:start -->
* [42592970](https://news.social-protocols.org/stats?id=42592970) #15 12 points 4 comments -> [Show HN: Al Hugging Video Generator](https://cococlip.ai/features/ai-hug)<!-- HN:42592970:end --><!-- HN:42616269:start -->
* [42616269](https://news.social-protocols.org/stats?id=42616269) #29 48 points 20 comments -> [What Parler Saw During the Attack on the Capitol](https://projects.propublica.org/parler-capitol-videos/)<!-- HN:42616269:end -->
#### **Tuesday, January 7, 2025**
<!-- HN:42618260:start -->
* [42618260](https://news.social-protocols.org/stats?id=42618260) #19 14 points 1 comments -> [Instagram Begins Randomly Showing Users AI-Generated Images of Themselves](https://www.404media.co/instagram-begins-randomly-showing-users-ai-generated-images-of-themselves/)<!-- HN:42618260:end --><!-- HN:42618849:start -->
* [42618849](https://news.social-protocols.org/stats?id=42618849) #3 71 points 17 comments -> [Nvidia Blackwell GeForce RTX 50 Series Opens New World of AI Computer Graphics](https://nvidianews.nvidia.com/news/nvidia-blackwell-geforce-rtx-50-series-opens-new-world-of-ai-computer-graphics)<!-- HN:42618849:end --><!-- HN:42619163:start -->
* [42619163](https://news.social-protocols.org/stats?id=42619163) #30 9 points 2 comments -> [Nvidia Puts Grace Blackwell on Every Desk and at Every AI Developer's Fingertips](https://nvidianews.nvidia.com/news/nvidia-puts-grace-blackwell-on-every-desk-and-at-every-ai-developers-fingertips)<!-- HN:42619163:end --><!-- HN:42588579:start -->
* [42588579](https://news.social-protocols.org/stats?id=42588579) #20 7 points 2 comments -> [Postiz – open-source social media scheduler](https://github.com/gitroomhq/postiz-app)<!-- HN:42588579:end --><!-- HN:42619695:start -->
* [42619695](https://news.social-protocols.org/stats?id=42619695) #18 39 points 14 comments -> [Y2K – why I know it was a real problem (2015)](https://clarotesting.wordpress.com/2015/01/12/y2k-why-i-know-it-was-a-real-problem/)<!-- HN:42619695:end --><!-- HN:42621332:start -->
* [42621332](https://news.social-protocols.org/stats?id=42621332) #5 114 points 14 comments -> [Nvidia announces $3k personal AI supercomputer called Digits](https://www.theverge.com/2025/1/6/24337530/nvidia-ces-digits-super-computer-ai)<!-- HN:42621332:end --><!-- HN:42622220:start -->
* [42622220](https://news.social-protocols.org/stats?id=42622220) #28 13 points 2 comments -> [Meta to get rid of factcheckers and recommend more political content](https://www.theguardian.com/technology/2025/jan/07/meta-facebook-instagram-threads-mark-zuckerberg-remove-fact-checkers-recommend-political-content)<!-- HN:42622220:end --><!-- HN:42622082:start -->
* [42622082](https://news.social-protocols.org/stats?id=42622082) #17 51 points 53 comments -> [Mark Zuckerberg: It's time to get back to our roots around free expression](https://www.facebook.com/zuck/videos/its-time-to-get-back-to-our-roots-around-free-expression-were-replacing-fact-che/1525382954801931/)<!-- HN:42622082:end --><!-- HN:42620191:start -->
* [42620191](https://news.social-protocols.org/stats?id=42620191) #12 23 points 53 comments -> [Alcohol-free booze is becoming big business](https://www.economist.com/business/2025/01/06/alcohol-free-booze-is-becoming-big-business)<!-- HN:42620191:end --><!-- HN:42622147:start -->
* [42622147](https://news.social-protocols.org/stats?id=42622147) #19 36 points 33 comments -> [Mark Zuckerberg: Fact-Checking on Meta Is Too "Politically Biased"](https://www.hollywoodreporter.com/business/digital/mark-zuckerberg-meta-ends-content-restrictions-restore-free-speech-1236102963/)<!-- HN:42622147:end --><!-- HN:42622663:start -->
* [42622663](https://news.social-protocols.org/stats?id=42622663) #13 3 points 0 comments -> [The Great Filter Comes for Us All](https://blog.codinghorror.com/the-great-filter-comes-for-us-all/)<!-- HN:42622663:end --><!-- HN:42621012:start -->
* [42621012](https://news.social-protocols.org/stats?id=42621012) #23 4 points 1 comments -> ["America Is in Decline": Truth or Informational Indoctrination?](https://actfiles.org/america-is-in-decline-truth-or-informational-indoctrination/)<!-- HN:42621012:end --><!-- HN:42621793:start -->
* [42621793](https://news.social-protocols.org/stats?id=42621793) #30 9 points 5 comments -> [Computer Science graduates with a 4.0 GPA can't get a job in tech](https://xcancel.com/davenewworld_2/status/1874919912621453374)<!-- HN:42621793:end --><!-- HN:42622481:start -->
* [42622481](https://news.social-protocols.org/stats?id=42622481) #28 6 points 0 comments -> [Roman Empire's Air Pollution May Have Lowered the IQ of Europe](https://www.sciencealert.com/roman-empires-air-pollution-may-have-lowered-the-iq-of-europe)<!-- HN:42622481:end --><!-- HN:42624145:start -->
* [42624145](https://news.social-protocols.org/stats?id=42624145) #3 17 points 6 comments -> [Yeah, America can still build stuff](https://jabberwocking.com/yeah-america-can-still-build-stuff/)<!-- HN:42624145:end --><!-- HN:42624955:start -->
* [42624955](https://news.social-protocols.org/stats?id=42624955) #18 10 points 1 comments -> [Washington Post Cartoonist Quits After Jeff Bezos Cartoon Is Killed](https://www.nytimes.com/2025/01/03/business/media/washington-post-cartoonist-quits-after-jeff-bezos-cartoon-is-killed.html)<!-- HN:42624955:end --><!-- HN:42628303:start -->
* [42628303](https://news.social-protocols.org/stats?id=42628303) #12 8 points 0 comments -> [Go Is a Well-Designed Language](https://mattjhall.co.uk/posts/go-is-well-designed-actually.html)<!-- HN:42628303:end --><!-- HN:42627902:start -->
* [42627902](https://news.social-protocols.org/stats?id=42627902) #10 9 points 2 comments -> [50 Years of SNL's Graphic Parodies (2024)](https://www.printmag.com/daily-heller/the-daily-heller-snls-graphic-parody/)<!-- HN:42627902:end --><!-- HN:42629052:start -->
* [42629052](https://news.social-protocols.org/stats?id=42629052) #24 10 points 2 comments -> [Meta Now Lets Users Say Gay and Trans People Have 'Mental Illness'](https://www.wired.com/story/meta-immigration-gender-policies-change/)<!-- HN:42629052:end -->
#### **Wednesday, January 8, 2025**
<!-- HN:42627170:start -->
* [42627170](https://news.social-protocols.org/stats?id=42627170) #24 38 points 69 comments -> [Show HN: I Built an AI Tattoo Generator Using Flux](https://www.tattoopro.ai/)<!-- HN:42627170:end --><!-- HN:42632553:start -->
* [42632553](https://news.social-protocols.org/stats?id=42632553) #30 12 points 10 comments -> [Calling women 'household objects' now permitted on Facebook](https://www.cnn.com/2025/01/07/tech/meta-hateful-conduct-policy-update-fact-check/index.html)<!-- HN:42632553:end --><!-- HN:42604616:start -->
* [42604616](https://news.social-protocols.org/stats?id=42604616) #21 8 points 0 comments -> [How to generate OpenGraph images with Astro and Satori](https://skyfall.dev/posts/astro-og-with-satori)<!-- HN:42604616:end --><!-- HN:42633868:start -->
* [42633868](https://news.social-protocols.org/stats?id=42633868) #29 19 points 7 comments -> [Stop to use words like "safety" when they mean "sanitized"](https://old.reddit.com/r/StableDiffusion/comments/1hwhizq/we_need_to_stop_allowing_entities_to_coop/)<!-- HN:42633868:end --><!-- HN:42616495:start -->
* [42616495](https://news.social-protocols.org/stats?id=42616495) #16 67 points 10 comments -> [Small Data [video]](https://www.youtube.com/watch?v=eDr6_cMtfdA)<!-- HN:42616495:end --><!-- HN:42633865:start -->
* [42633865](https://news.social-protocols.org/stats?id=42633865) #19 12 points 6 comments -> [In a first, EU Court fines EU for breaching own data protection law](https://www.reuters.com/world/europe/first-eu-court-fines-eu-breaching-own-data-protection-law-2025-01-08/)<!-- HN:42633865:end --><!-- HN:42633494:start -->
* [42633494](https://news.social-protocols.org/stats?id=42633494) #22 15 points 3 comments -> [Nvidia CEO says his AI chips are improving faster than Moore's Law](https://techcrunch.com/2025/01/07/nvidia-ceo-says-his-ai-chips-are-improving-faster-than-moores-law/)<!-- HN:42633494:end --><!-- HN:42635089:start -->
* [42635089](https://news.social-protocols.org/stats?id=42635089) #26 3 points 0 comments -> [An introduction to Plato's Republic (1981)](https://archive.org/details/introductiontopl0000anna)<!-- HN:42635089:end --><!-- HN:42636195:start -->
* [42636195](https://news.social-protocols.org/stats?id=42636195) #6 11 points 0 comments -> [Why I Am Not Going to Buy a Computer [pdf]](https://classes.matthewjbrown.net/teaching-files/philtech/berry-computer.pdf)<!-- HN:42636195:end -->
#### **Thursday, January 9, 2025**
<!-- HN:42601942:start -->
* [42601942](https://news.social-protocols.org/stats?id=42601942) #20 4 points 1 comments -> [How to Activate the Value Flywheel Effect with Your Data](https://blog.owulveryck.info/2024/10/15/how-to-activate-the-value-flywheel-effect-with-your-data.html)<!-- HN:42601942:end --><!-- HN:42602438:start -->
* [42602438](https://news.social-protocols.org/stats?id=42602438) #23 10 points 9 comments -> [Brief Introduction to Fix and Fix JSON](https://fixparser.dev/what-is-fix)<!-- HN:42602438:end --><!-- HN:42612592:start -->
* [42612592](https://news.social-protocols.org/stats?id=42612592) #6 3 points 1 comments -> [Is rapid charging bad for your car? Learn about battery C-Rate [video]](https://foxev.io/batteries/c-rate-is-rapid-charging-bad/)<!-- HN:42612592:end --><!-- HN:42643518:start -->
* [42643518](https://news.social-protocols.org/stats?id=42643518) #18 29 points 40 comments -> [The sad beige aesthetic: why has the world suddenly turned taupe?](https://www.theguardian.com/lifeandstyle/2025/jan/09/the-sad-beige-aesthetic-why-has-the-world-suddenly-turned-taupe)<!-- HN:42643518:end --><!-- HN:42644015:start -->
* [42644015](https://news.social-protocols.org/stats?id=42644015) #10 135 points 125 comments -> [VLC tops 6B downloads, previews AI-generated subtitles](https://techcrunch.com/2025/01/09/vlc-tops-6-billion-downloads-previews-ai-generated-subtitles/)<!-- HN:42644015:end --><!-- HN:42602062:start -->
* [42602062](https://news.social-protocols.org/stats?id=42602062) #15 199 points 342 comments -> [Olympians turn to OnlyFans to fund dreams due to 'broken' finance system (2024)](https://www.cbc.ca/sports/olympics/summer/athletics/onlyfans-alysha-newman-canada-olympics-1.7290724)<!-- HN:42602062:end --><!-- HN:42642873:start -->
* [42642873](https://news.social-protocols.org/stats?id=42642873) #17 149 points 140 comments -> [New 16GB Raspberry Pi 5 on sale now at $120](https://www.raspberrypi.com/news/16gb-raspberry-pi-5-on-sale-now-at-120/)<!-- HN:42642873:end --><!-- HN:42608540:start -->
* [42608540](https://news.social-protocols.org/stats?id=42608540) #18 32 points 40 comments -> [Four causes for 'Zoom fatigue' (2021)](https://news.stanford.edu/stories/2021/02/four-causes-zoom-fatigue-solutions)<!-- HN:42608540:end --><!-- HN:42638735:start -->
* [42638735](https://news.social-protocols.org/stats?id=42638735) #28 342 points 479 comments -> [LA wildfires force thousands to evacuate, NASA JPL closed](https://www.theregister.com/2025/01/08/los_angeles_fires_jpl/)<!-- HN:42638735:end --><!-- HN:42642122:start -->
* [42642122](https://news.social-protocols.org/stats?id=42642122) #28 12 points 0 comments -> [VR Has Had a Phase Change and I Didn't Know It](https://jerf.org/iri/post/2024/vr_phase_change/)<!-- HN:42642122:end --><!-- HN:42643139:start -->
* [42643139](https://news.social-protocols.org/stats?id=42643139) #20 10 points 1 comments -> [How to become a Data Scientist? My journey, overview of skill set, practice tips](https://mljar.com/blog/how-to-become-data-scientist/)<!-- HN:42643139:end --><!-- HN:42647412:start -->
* [42647412](https://news.social-protocols.org/stats?id=42647412) #6 3 points 1 comments -> [Meta's TOS: degradation is not allowed, unless the target is LGBT](https://transparency.meta.com/policies/community-standards/hateful-conduct/?_fb_noscript=1)<!-- HN:42647412:end --><!-- HN:42645187:start -->
* [42645187](https://news.social-protocols.org/stats?id=42645187) #23 12 points 2 comments -> [Auto-saving Rails forms with Turbo Streams](https://nts.strzibny.name/rails-autosave-form-turbo-stream/)<!-- HN:42645187:end --><!-- HN:42647883:start -->
* [42647883](https://news.social-protocols.org/stats?id=42647883) #9 4 points 6 comments -> [Show HN: A browser designed to support uBlock Origin (MV2) and respect privacy](https://ublock-browser.com/)<!-- HN:42647883:end --><!-- HN:42614319:start -->
* [42614319](https://news.social-protocols.org/stats?id=42614319) #18 4 points 5 comments -> [Chemical reactions deplete nutrients in plant-based drinks](https://phys.org/news/2024-12-chemical-reactions-deplete-nutrients-based.html)<!-- HN:42614319:end --><!-- HN:42650094:start -->
* [42650094](https://news.social-protocols.org/stats?id=42650094) #26 4 points 0 comments -> [The '90s weren't that great](https://www.slowboring.com/p/the-90s-werent-that-great)<!-- HN:42650094:end -->
#### **Friday, January 10, 2025**
<!-- HN:42651087:start -->
* [42651087](https://news.social-protocols.org/stats?id=42651087) #5 28 points 6 comments -> [See the Thousands of Apps Hijacked to Spy on Your Location](https://www.404media.co/candy-crush-tinder-myfitnesspal-see-the-thousands-of-apps-hijacked-to-spy-on-your-location/)<!-- HN:42651087:end --><!-- HN:42620012:start -->
* [42620012](https://news.social-protocols.org/stats?id=42620012) #29 23 points 6 comments -> [Chat-Driven Development: A Better Way to Use LLMs for Coding](https://shekhargulati.com/2025/01/07/chat-first-development-a-better-way-to-use-llms-for-coding/)<!-- HN:42620012:end --><!-- HN:42651794:start -->
* [42651794](https://news.social-protocols.org/stats?id=42651794) #28 10 points 3 comments -> [Fascism shattered Europe century ago – historians hear echoes today in U.S. (24)](https://news.berkeley.edu/2024/09/09/fascism-shattered-europe-a-century-ago-and-historians-hear-echoes-today-in-the-u-s/)<!-- HN:42651794:end --><!-- HN:42652482:start -->
* [42652482](https://news.social-protocols.org/stats?id=42652482) #28 6 points 0 comments -> [Inside Meta's dehumanizing new speech policies for trans people](https://www.platformer.news/meta-new-trans-guidelines-hate-speech/)<!-- HN:42652482:end --><!-- HN:42622113:start -->
* [42622113](https://news.social-protocols.org/stats?id=42622113) #5 10 points 2 comments -> [How to Debug Python Code in Visual Studio Code](https://www.qodo.ai/blog/tutorial-how-to-debug-python-code-in-visual-studio-code/)<!-- HN:42622113:end --><!-- HN:42653434:start -->
* [42653434](https://news.social-protocols.org/stats?id=42653434) #12 24 points 40 comments -> [BYD's electric supercar jumps over potholes and spikes](https://www.drive.com.au/news/byd-yangwang-u9-jumps-over-potholes-and-spikes-video/)<!-- HN:42653434:end --><!-- HN:42653343:start -->
* [42653343](https://news.social-protocols.org/stats?id=42653343) #12 9 points 0 comments -> [Ruby/tk: Tk interface module using tcltklib](https://github.com/ruby/tk)<!-- HN:42653343:end --><!-- HN:42620582:start -->
* [42620582](https://news.social-protocols.org/stats?id=42620582) #10 22 points 40 comments -> [Thunderbolt 5 vs. Thunderbolt 4: Everything you need to know](https://www.tomsguide.com/computing/thunderbolt-5-vs-thunderbolt-4)<!-- HN:42620582:end --><!-- HN:42654447:start -->
* [42654447](https://news.social-protocols.org/stats?id=42654447) #27 11 points 1 comments -> [Male and female brains are wired differently](https://www.earth.com/news/male-and-female-brains-are-wired-completely-differently/)<!-- HN:42654447:end --><!-- HN:42652775:start -->
* [42652775](https://news.social-protocols.org/stats?id=42652775) #21 24 points 0 comments -> [A visual demo of Ruby's lazy enumerator](https://joyofrails.com/articles/simple-trick-to-understand-ruby-lazy-enumerator)<!-- HN:42652775:end --><!-- HN:42620272:start -->
* [42620272](https://news.social-protocols.org/stats?id=42620272) #16 13 points 13 comments -> [Koa – Next generation web framework for Node.js](https://koajs.com/)<!-- HN:42620272:end --><!-- HN:42620350:start -->
* [42620350](https://news.social-protocols.org/stats?id=42620350) #15 4 points 0 comments -> [Bird Buddy Launches 'Wonder' Camera for Watching Insects](https://www.macrumors.com/2025/01/06/ces-2025-wonder-insect-camera/)<!-- HN:42620350:end --><!-- HN:42652193:start -->
* [42652193](https://news.social-protocols.org/stats?id=42652193) #30 11 points 7 comments -> [A job platform for developers by developers (built by an experienced developer)](https://devjobs.work/)<!-- HN:42652193:end --><!-- HN:42620041:start -->
* [42620041](https://news.social-protocols.org/stats?id=42620041) #13 5 points 5 comments -> [HTML Is a Programming Language. Fight Me](https://www.wired.com/story/html-is-actually-a-programming-language-fight-me/)<!-- HN:42620041:end --><!-- HN:42616520:start -->
* [42616520](https://news.social-protocols.org/stats?id=42616520) #26 26 points 1 comments -> [Musings on Tracing in PyPy](https://pypy.org/posts/2025/01/musings-tracing.html)<!-- HN:42616520:end --><!-- HN:42657907:start -->
* [42657907](https://news.social-protocols.org/stats?id=42657907) #22 7 points 0 comments -> [Review: Reentry, by Eric Berger](https://www.thepsmiths.com/p/review-reentry-by-eric-berger)<!-- HN:42657907:end --><!-- HN:42658167:start -->
* [42658167](https://news.social-protocols.org/stats?id=42658167) #25 4 points 1 comments -> [Show HN: KeyTik: The All-in-One Input Automation Tool](https://keytik.com/)<!-- HN:42658167:end --><!-- HN:42659302:start -->
* [42659302](https://news.social-protocols.org/stats?id=42659302) #25 22 points 40 comments -> [WSJ: Americans Are Tipping Less Than They Have in Years](https://www.wsj.com/business/hospitality/restaurant-tip-fatigue-servers-covid-9e198567)<!-- HN:42659302:end -->
#### **Saturday, January 11, 2025**<!-- HN:42662329:start -->
* [42662329](https://news.social-protocols.org/stats?id=42662329) #4 20 points 5 comments -> [A Laptop Stand Made from a Single Sheet of Recycled Paper](https://www.core77.com/posts/134948/A-Laptop-Stand-Made-from-a-Single-Sheet-of-Recycled-Paper)<!-- HN:42662329:end --><!-- HN:42665771:start -->
* [42665771](https://news.social-protocols.org/stats?id=42665771) #21 5 points 2 comments -> [Zuckerberg trash talks Apple in interview with Joe Rogan](https://www.theverge.com/2025/1/10/24341039/meta-apple-mark-zuckerberg-trash-talks-joe-rogan-interview)<!-- HN:42665771:end --><!-- HN:42631876:start -->
* [42631876](https://news.social-protocols.org/stats?id=42631876) #15 65 points 28 comments -> [Donut Lab's next-generation in-wheel motors](https://www.donutlab.com/motor/)<!-- HN:42631876:end --><!-- HN:42665368:start -->
* [42665368](https://news.social-protocols.org/stats?id=42665368) #29 9 points 8 comments -> [TikTok Says It Will 'Go Dark' Without US Court Intervention](https://www.businessinsider.com/tiktok-says-wouid-go-dark-january-without-us-court-intervention-2025-1)<!-- HN:42665368:end --><!-- HN:42665533:start -->
* [42665533](https://news.social-protocols.org/stats?id=42665533) #26 8 points 0 comments -> [Sony Proposes Changing LLVM Clang Default to C++20 Mode](https://www.phoronix.com/news/Sony-LLVM-Clang-CXX20-Default)<!-- HN:42665533:end --><!-- HN:42626043:start -->
* [42626043](https://news.social-protocols.org/stats?id=42626043) #14 50 points 66 comments -> [Kirin demos "electric salt spoon" at CES](https://techcrunch.com/2025/01/05/kirin-offers-a-taste-of-its-electric-salt-spoon-at-ces-2025/)<!-- HN:42626043:end --><!-- HN:42666513:start -->
* [42666513](https://news.social-protocols.org/stats?id=42666513) #26 4 points 0 comments -> [The Elephant in the room: The myth of exponential hypergrowth](https://longform.asmartbear.com/exponential-growth/)<!-- HN:42666513:end --><!-- HN:42659111:start -->
* [42659111](https://news.social-protocols.org/stats?id=42659111) #11 24 points 20 comments -> [Year old startup overloaded GitHub – Incident report](https://lovable.dev/news/github-incident-2025-01-02)<!-- HN:42659111:end --><!-- HN:42668087:start -->
* [42668087](https://news.social-protocols.org/stats?id=42668087) #28 18 points 14 comments -> [Civilian police oversight in Florida crumbles after new law kicks in](https://www.tampabay.com/news/florida-politics/2025/01/11/civilian-police-oversight-florida-crumbles-after-new-law-kicks/)<!-- HN:42668087:end --><!-- HN:42667825:start -->
* [42667825](https://news.social-protocols.org/stats?id=42667825) #14 7 points 3 comments -> [You are an absolute moron for believing in the hype of "AI Agents"](https://nexustrade.io/blog/you-are-an-absolute-moron-for-believing-in-the-hype-of-ai-agents-20250111)<!-- HN:42667825:end --><!-- HN:42669065:start -->
* [42669065](https://news.social-protocols.org/stats?id=42669065) #1 5 points 2 comments -> [Test if a number is even](https://ubuntuincident.wordpress.com/2025/01/11/test-if-a-number-is-even/)<!-- HN:42669065:end --><!-- HN:42669006:start -->
* [42669006](https://news.social-protocols.org/stats?id=42669006) #1 34 points 3 comments -> [FCC Proposes Cybersecurity Labeling Program for Smart Devices](https://www.fcc.gov/cybersecurity-certification-mark)<!-- HN:42669006:end -->
#### **Sunday, January 12, 2025**
<!-- HN:42671404:start -->
* [42671404](https://news.social-protocols.org/stats?id=42671404) #30 3 points 0 comments -> [Epic Games Introduces New Terms of Service](https://twitter.com/Pirat_Nation/status/1878245087349538957)<!-- HN:42671404:end --><!-- HN:42641903:start -->
* [42641903](https://news.social-protocols.org/stats?id=42641903) #16 11 points 0 comments -> [The stories of survivors of the Rwandan Genocide](https://www.positivenewsus.org/rwandan-stories-of-survivor.html)<!-- HN:42641903:end --><!-- HN:42671589:start -->
* [42671589](https://news.social-protocols.org/stats?id=42671589) #12 12 points 6 comments -> [Show HN: Willpayforthis.com – Gathering posts about what people will pay for](https://www.willpayforthis.com/)<!-- HN:42671589:end --><!-- HN:42672477:start -->
* [42672477](https://news.social-protocols.org/stats?id=42672477) #10 10 points 0 comments -> [Asking rents skyrocket as LA fires destroy homes](https://laist.com/news/housing-homelessness/los-angeles-palisades-fire-housing-rent-price-gouging-law-california-zillow-listing)<!-- HN:42672477:end --><!-- HN:42672876:start -->
* [42672876](https://news.social-protocols.org/stats?id=42672876) #25 7 points 0 comments -> [Open letter to Mark Zuckerberg – Congratulations on your remarks](https://www.berliner-zeitung.de/politik-gesellschaft/open-letter-to-mark-zuckerberg-congratulations-on-your-speech-now-fire-correctiv-li.2288496)<!-- HN:42672876:end --><!-- HN:42672886:start -->
* [42672886](https://news.social-protocols.org/stats?id=42672886) #14 23 points 5 comments -> [Male and female brains differ at birth](https://bsd.biomedcentral.com/articles/10.1186/s13293-024-00657-5)<!-- HN:42672886:end --><!-- HN:42673366:start -->
* [42673366](https://news.social-protocols.org/stats?id=42673366) #5 7 points 1 comments -> [macOS No Longer Ships with Emacs](https://batsov.com/articles/2025/01/12/macos-no-longer-ships-with-emacs/)<!-- HN:42673366:end --><!-- HN:42673405:start -->
* [42673405](https://news.social-protocols.org/stats?id=42673405) #19 6 points 5 comments -> [Matt Should Resign (2010)](http://wpblogger.com/matt-should-resign.php)<!-- HN:42673405:end --><!-- HN:42675025:start -->
* [42675025](https://news.social-protocols.org/stats?id=42675025) #4 11 points 2 comments -> [It's time to abandon the cargo cult metaphor](https://www.righto.com/2025/01/its-time-to-abandon-cargo-cult-metaphor.html)<!-- HN:42675025:end --><!-- HN:42675251:start -->
* [42675251](https://news.social-protocols.org/stats?id=42675251) #27 4 points 0 comments -> [LA Renters Hit with Price Gouging During Wildfire Chaos](https://www.newsweek.com/la-renters-pride-gouging-los-angeles-wildfires-2013645)<!-- HN:42675251:end --><!-- HN:42675376:start -->
* [42675376](https://news.social-protocols.org/stats?id=42675376) #8 10 points 0 comments -> [On Misery](https://mcfunley.com/on-misery)<!-- HN:42675376:end --><!-- HN:42674627:start -->
* [42674627](https://news.social-protocols.org/stats?id=42674627) #29 15 points 4 comments -> [Show HN: SemHash – Fast Semantic Text Deduplication for Cleaner Datasets](https://github.com/MinishLab/semhash)<!-- HN:42674627:end --><!-- HN:42676176:start -->
* [42676176](https://news.social-protocols.org/stats?id=42676176) #17 11 points 1 comments -> [California Fire Facts](https://gavinnewsom.com/california-fire-facts/)<!-- HN:42676176:end -->