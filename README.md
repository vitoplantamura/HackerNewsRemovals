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

#### **Thursday, April 10, 2025**
<!-- HN:43639889:start -->
* [43639889](https://news.social-protocols.org/stats?id=43639889) #28 8 points 0 comments -> [ICE nabs a Maryland woman in her car after smashing her window](https://www.thebaltimorebanner.com/community/local-news/video-ice-arrest-wesminster-elsy-noemi-berrios-QJ7CIME76ZGPZEBW5C3REEPZ6E/)<!-- HN:43639889:end --><!-- HN:43639875:start -->
* [43639875](https://news.social-protocols.org/stats?id=43639875) #4 8 points 1 comments -> [A2A Protocol – Agent-to-Agent Communication](https://a2aprotocol.ai)<!-- HN:43639875:end --><!-- HN:43609758:start -->
* [43609758](https://news.social-protocols.org/stats?id=43609758) #25 14 points 3 comments -> [Show HN: I turned GitHub contributions into a retro battle game](https://epicdevbattlesofhistory.com)<!-- HN:43609758:end --><!-- HN:43604788:start -->
* [43604788](https://news.social-protocols.org/stats?id=43604788) #16 9 points 1 comments -> [What Are the Dots on the Side of Vinyl Turntables, Is It Decoration?](https://www.djmentors.com/p/dj-machines-in-motion)<!-- HN:43604788:end --><!-- HN:43641402:start -->
* [43641402](https://news.social-protocols.org/stats?id=43641402) #3 67 points 38 comments -> [ICE director envisions Amazon-like mass deportation system](https://azmirror.com/2025/04/08/ice-director-envisions-amazon-like-mass-deportation-system-prime-but-with-human-beings/)<!-- HN:43641402:end --><!-- HN:43642802:start -->
* [43642802](https://news.social-protocols.org/stats?id=43642802) #3 9 points 0 comments -> [We've Been Conned: The Truth about Big LLM](https://www.dolthub.com/blog/2025-04-09-weve-been-conned-the-truth-about-llms/)<!-- HN:43642802:end --><!-- HN:43643342:start -->
* [43643342](https://news.social-protocols.org/stats?id=43643342) #27 9 points 4 comments -> [CPI for all items falls 0.1% in March, up 2.4% YoY](https://www.bls.gov/news.release/archives/cpi_04102025.htm)<!-- HN:43643342:end --><!-- HN:43643408:start -->
* [43643408](https://news.social-protocols.org/stats?id=43643408) #19 11 points 2 comments -> [Amazon CEO Andy Jassy's 2024 Letter to Shareholders](https://www.aboutamazon.com/news/company-news/amazon-ceo-andy-jassy-2024-letter-to-shareholders)<!-- HN:43643408:end --><!-- HN:43643104:start -->
* [43643104](https://news.social-protocols.org/stats?id=43643104) #5 12 points 0 comments -> [EGPU: Extending eBPF Programmability and Observability to GPUs](https://camps.aptaracorp.com/ACM_PMS/PMS/ACM/HCDS25/10/13a8f7c0-0a7e-11f0-ada9-16bb50361d1f/OUT/hcds25-10.html)<!-- HN:43643104:end --><!-- HN:43644146:start -->
* [43644146](https://news.social-protocols.org/stats?id=43644146) #24 10 points 2 comments -> [U.S. says it is now monitoring immigrants' social media for antisemitism](https://www.npr.org/2025/04/09/g-s1-59149/immigrants-social-media-antisemitism-dhs)<!-- HN:43644146:end --><!-- HN:43643877:start -->
* [43643877](https://news.social-protocols.org/stats?id=43643877) #30 16 points 27 comments -> [Flying Somewhere? You May Need That Real ID.](https://www.nytimes.com/2025/04/09/travel/real-id-deadline-what-to-know.html)<!-- HN:43643877:end --><!-- HN:43643312:start -->
* [43643312](https://news.social-protocols.org/stats?id=43643312) #16 -> [Photon: Rust/WebAssembly image processing library faster than VIPs and PIL](https://github.com/silvia-odwyer/photon)<!-- HN:43643312:end --><!-- HN:43643204:start -->
* [43643204](https://news.social-protocols.org/stats?id=43643204) #19 13 points 20 comments -> [Show HN: Temp.pw](https://temp.pw/)<!-- HN:43643204:end --><!-- HN:43642928:start -->
* [43642928](https://news.social-protocols.org/stats?id=43642928) #28 30 points 39 comments -> [Rick Steves: Are Americans Still Welcome in Europe?](https://blog.ricksteves.com/cameron/2025/03/americans-welcome-europe-2025/)<!-- HN:43642928:end --><!-- HN:43645724:start -->
* [43645724](https://news.social-protocols.org/stats?id=43645724) #5 6 points 0 comments -> [OpenAI Pioneers Program](https://openai.com/index/openai-pioneers-program/)<!-- HN:43645724:end --><!-- HN:43647316:start -->
* [43647316](https://news.social-protocols.org/stats?id=43647316) #27 7 points 1 comments -> [He Said He Would Ban Congressional Stock Trading. Now, He Trades Freely](https://www.nytimes.com/2025/04/05/us/politics/congress-stock-trading-ban.html)<!-- HN:43647316:end --><!-- HN:43647485:start -->
* [43647485](https://news.social-protocols.org/stats?id=43647485) #17 7 points 1 comments -> [The Brazilian Judge Taking on the Digital Far Right](https://www.newyorker.com/magazine/2025/04/14/the-brazilian-judge-taking-on-the-digital-far-right)<!-- HN:43647485:end --><!-- HN:43609468:start -->
* [43609468](https://news.social-protocols.org/stats?id=43609468) #23 7 points 1 comments -> [Your Mouse Is a Database (2012)](https://queue.acm.org/detail.cfm?id=2169076)<!-- HN:43609468:end --><!-- HN:43647164:start -->
* [43647164](https://news.social-protocols.org/stats?id=43647164) #30 9 points 2 comments -> [This is what a digital coup looks like](https://broligarchy.substack.com/p/speaking-truth-to-tech-gods-i-return)<!-- HN:43647164:end -->
#### **Friday, April 11, 2025**
<!-- HN:43648795:start -->
* [43648795](https://news.social-protocols.org/stats?id=43648795) #29 36 points 32 comments -> [We quit our Big Tech jobs after hitting #1 on HN and Product Hunt](https://www.heyopenspot.com/)<!-- HN:43648795:end --><!-- HN:43649204:start -->
* [43649204](https://news.social-protocols.org/stats?id=43649204) #10 31 points 4 comments -> [Kristi Noem, Department of Homeland Security, vs. Kilmar Armando Abrego Garcia [pdf]](https://www.supremecourt.gov/opinions/24pdf/24a949_lkhn.pdf)<!-- HN:43649204:end --><!-- HN:43649640:start -->
* [43649640](https://news.social-protocols.org/stats?id=43649640) #1 32 points 9 comments -> [Why do AI company logos look like buttholes?](https://velvetshark.com/ai-company-logos-that-look-like-buttholes)<!-- HN:43649640:end --><!-- HN:43648526:start -->
* [43648526](https://news.social-protocols.org/stats?id=43648526) #19 26 points 40 comments -> [this site uses cookies to store the fact you clicked "Accept Cookies"](https://rodyne.com/?p=2368)<!-- HN:43648526:end --><!-- HN:43650599:start -->
* [43650599](https://news.social-protocols.org/stats?id=43650599) #8 5 points 0 comments -> [I made a bot to spoil every book my girlfriend ever reads](https://www.olliechapman.com/blog/spoil-every-book)<!-- HN:43650599:end --><!-- HN:43651458:start -->
* [43651458](https://news.social-protocols.org/stats?id=43651458) #18 44 points 40 comments -> [Mastodon Exit Interview](https://v.cx/2025/04/mastodon-exit-interview)<!-- HN:43651458:end --><!-- HN:43652896:start -->
* [43652896](https://news.social-protocols.org/stats?id=43652896) #26 11 points 7 comments -> [What's Wrong with Apple?](https://www.nytimes.com/2025/04/11/technology/apple-issues-trump-tariffs.html)<!-- HN:43652896:end --><!-- HN:43653490:start -->
* [43653490](https://news.social-protocols.org/stats?id=43653490) #2 20 points 10 comments -> [No code is dead. Long live vibe coding](https://kenneth.io/post/no-code-is-dead-long-live-vibe-coding)<!-- HN:43653490:end --><!-- HN:43652643:start -->
* [43652643](https://news.social-protocols.org/stats?id=43652643) #13 7 points 4 comments -> [Show HN: Free TI-84 Plus Online (No Signup, Runs in Browser)](https://www.ti84-online.com)<!-- HN:43652643:end --><!-- HN:43649711:start -->
* [43649711](https://news.social-protocols.org/stats?id=43649711) #27 92 points 46 comments -> [Nvidia on NixOS WSL – Ollama up 24/7 on your gaming PC](https://yomaq.github.io/posts/nvidia-on-nixos-wsl-ollama-up-24-7-on-your-gaming-pc/)<!-- HN:43649711:end --><!-- HN:43654343:start -->
* [43654343](https://news.social-protocols.org/stats?id=43654343) #23 5 points 3 comments -> [Crime is down, way down](https://growsf.org/news/2025-04-10-crime-is-down/)<!-- HN:43654343:end --><!-- HN:43653922:start -->
* [43653922](https://news.social-protocols.org/stats?id=43653922) #5 10 points 4 comments -> [Browser extensions put 4M users at risk of cookie exposure](https://secureannex.com/blog/searching-for-something-unknow/)<!-- HN:43653922:end --><!-- HN:43655646:start -->
* [43655646](https://news.social-protocols.org/stats?id=43655646) #25 3 points 0 comments -> [Probiotics reduce negative mood over time: daily self-reports in detection](https://www.nature.com/articles/s44184-025-00123-z)<!-- HN:43655646:end -->
#### **Saturday, April 12, 2025**
<!-- HN:43661499:start -->
* [43661499](https://news.social-protocols.org/stats?id=43661499) #7 9 points 2 comments -> [The Coming Test of Sanity for the Administration](https://harrylitman.substack.com/p/the-coming-test-of-sanity-for-the)<!-- HN:43661499:end --><!-- HN:43663219:start -->
* [43663219](https://news.social-protocols.org/stats?id=43663219) #28 3 points 0 comments -> [What a digital coup looks like [video]](https://www.ted.com/talks/carole_cadwalladr_this_is_what_a_digital_coup_looks_like)<!-- HN:43663219:end --><!-- HN:43664624:start -->
* [43664624](https://news.social-protocols.org/stats?id=43664624) #15 27 points 6 comments -> [Apple was getting bid up like crazy yesterday, don't tell me this wasn't leaked](https://twitter.com/TradingThomas3/status/1911047516021281205)<!-- HN:43664624:end --><!-- HN:43664866:start -->
* [43664866](https://news.social-protocols.org/stats?id=43664866) #21 9 points 0 comments -> [Sorry, America, tariffs won't bring jobs back](https://www.aljazeera.com/opinions/2025/4/11/sorry-america-tariffs-wont-bring-jobs-back)<!-- HN:43664866:end --><!-- HN:43664538:start -->
* [43664538](https://news.social-protocols.org/stats?id=43664538) #11 21 points 5 comments -> [AI Hallucinations Are Fueling a New Class of Supply Chain Attacks](https://socket.dev/blog/slopsquatting-how-ai-hallucinations-are-fueling-a-new-class-of-supply-chain-attacks)<!-- HN:43664538:end --><!-- HN:43664996:start -->
* [43664996](https://news.social-protocols.org/stats?id=43664996) #2 34 points 41 comments -> [Which countries would benefit most from an American brain drain?](https://www.economist.com/graphic-detail/2025/04/11/which-countries-would-benefit-most-from-an-american-brain-drain)<!-- HN:43664996:end --><!-- HN:43625815:start -->
* [43625815](https://news.social-protocols.org/stats?id=43625815) #22 20 points 0 comments -> [Stop Treating YAML Like a String](https://theyamlengineer.com/stop-treating-yaml-like-a-string)<!-- HN:43625815:end --><!-- HN:43667063:start -->
* [43667063](https://news.social-protocols.org/stats?id=43667063) #18 11 points 2 comments -> [Florida's New Social Media Bill Explicitly Demands an Encryption Backdoor](https://www.eff.org/deeplinks/2025/04/floridas-new-social-media-bill-says-quiet-part-out-loud-and-demands-encryption)<!-- HN:43667063:end --><!-- HN:43667472:start -->
* [43667472](https://news.social-protocols.org/stats?id=43667472) #24 7 points 2 comments -> [UK takes control of British Steel under emergency powers](https://www.bbc.com/news/articles/ckg17g39x41o)<!-- HN:43667472:end --><!-- HN:43667282:start -->
* [43667282](https://news.social-protocols.org/stats?id=43667282) #9 16 points 5 comments -> [CLP Calculus Textbooks](https://personal.math.ubc.ca/~CLP/)<!-- HN:43667282:end --><!-- HN:43667305:start -->
* [43667305](https://news.social-protocols.org/stats?id=43667305) #9 33 points 10 comments -> [A Remarkable Newly Deciphered Hittite Tablet Sheds New Light on the Trojan War](https://www.anatolianarchaeology.net/a-remarkable-newly-deciphered-hittite-tablet-sheds-new-light-on-the-trojan-war/)<!-- HN:43667305:end --><!-- HN:43668019:start -->
* [43668019](https://news.social-protocols.org/stats?id=43668019) #19 6 points 1 comments -> [Microsoft rolls out AI screenshot tool dubbed 'privacy nightmare'](https://www.bbc.com/news/articles/cj3xjrj7v78o)<!-- HN:43668019:end --><!-- HN:43667963:start -->
* [43667963](https://news.social-protocols.org/stats?id=43667963) #4 19 points 7 comments -> [My prediction after GPT-4o image generation](https://arxiv.org/abs/2504.06256)<!-- HN:43667963:end --><!-- HN:43667790:start -->
* [43667790](https://news.social-protocols.org/stats?id=43667790) #11 6 points 12 comments -> [WTF Is Botmetr? The First Platform That Rewards You for Hunting Chatbots](https://www.botmetr.com/)<!-- HN:43667790:end -->
#### **Sunday, April 13, 2025**
<!-- HN:43668877:start -->
* [43668877](https://news.social-protocols.org/stats?id=43668877) #16 12 points 0 comments -> [Federal judge orders USDA to unfreeze funds to Maine](https://www.npr.org/2025/04/12/nx-s1-5362976/maine-usda-unfreeze-janet-mills-trump)<!-- HN:43668877:end --><!-- HN:43635105:start -->
* [43635105](https://news.social-protocols.org/stats?id=43635105) #20 3 points 1 comments -> [AI Action Figure Generator](https://ai-figure-generator.com)<!-- HN:43635105:end --><!-- HN:43672082:start -->
* [43672082](https://news.social-protocols.org/stats?id=43672082) #27 11 points 1 comments -> [DragonFlyBSD Lands "Next-Gen" Disk Encryption Code](https://www.phoronix.com/news/DragonFlyBSD-DM-Crypt-NG)<!-- HN:43672082:end --><!-- HN:43673297:start -->
* [43673297](https://news.social-protocols.org/stats?id=43673297) #30 14 points 1 comments -> [The rise of end times fascism](https://www.theguardian.com/us-news/ng-interactive/2025/apr/13/end-times-fascism-far-right-trump-musk)<!-- HN:43673297:end --><!-- HN:43673515:start -->
* [43673515](https://news.social-protocols.org/stats?id=43673515) #28 4 points 0 comments -> [School student uses AI to reveal 1.5M previously unknown objects in space](https://phys.org/news/2025-04-high-school-student-ai-reveal.html)<!-- HN:43673515:end --><!-- HN:43673518:start -->
* [43673518](https://news.social-protocols.org/stats?id=43673518) #28 7 points 2 comments -> [Why Our Brains Crave Ideology](https://nautil.us/why-our-brains-crave-ideology-1203194/)<!-- HN:43673518:end --><!-- HN:43674682:start -->
* [43674682](https://news.social-protocols.org/stats?id=43674682) #4 11 points 0 comments -> [Few build Hypervisors. We're one of them](https://virtualize.sh/blog/few-build-hypervisors-were-one-of-them/)<!-- HN:43674682:end --><!-- HN:43634853:start -->
* [43634853](https://news.social-protocols.org/stats?id=43634853) #30 33 points 40 comments -> [More than 1,500 new fonts – including all-time favorites – come to Adobe Fonts](https://blog.adobe.com/en/publish/2025/04/08/more-than-1500-new-fonts-including-all-time-favorites-come-to-adobe-fonts)<!-- HN:43634853:end --><!-- HN:43674764:start -->
* [43674764](https://news.social-protocols.org/stats?id=43674764) #13 20 points 4 comments -> [Show HN: Crystal, the most accurate U.S. gov't data search tool](https://askcrystal.info/)<!-- HN:43674764:end --><!-- HN:43676153:start -->
* [43676153](https://news.social-protocols.org/stats?id=43676153) #15 15 points 5 comments -> [Microsoft Prepares for New Round of Layoffs in May 2025](https://www.thebridgechronicle.com/tech/microsoft-layoffs-may-2025)<!-- HN:43676153:end --><!-- HN:43676075:start -->
* [43676075](https://news.social-protocols.org/stats?id=43676075) #3 25 points 1 comments -> [What Is GNU Radio?](https://wiki.gnuradio.org/index.php?title=What_Is_GNU_Radio)<!-- HN:43676075:end -->
#### **Monday, April 14, 2025**<!-- HN:43651295:start -->
* [43651295](https://news.social-protocols.org/stats?id=43651295) #14 26 points 41 comments -> [Organised gangs behind rise in QR 'quishing' scams](https://www.bbc.com/news/articles/cq6yznmv3gzo)<!-- HN:43651295:end --><!-- HN:43680019:start -->
* [43680019](https://news.social-protocols.org/stats?id=43680019) #28 4 points 1 comments -> [Delete All IP Law](https://twitter.com/jack/status/1910829254214115681)<!-- HN:43680019:end --><!-- HN:43678914:start -->
* [43678914](https://news.social-protocols.org/stats?id=43678914) #16 31 points 40 comments -> [Engineers Who Won't Commit](https://www.seangoedecke.com/taking-a-position/)<!-- HN:43678914:end --><!-- HN:43680685:start -->
* [43680685](https://news.social-protocols.org/stats?id=43680685) #12 29 points 40 comments -> [Kotlin, Swift, and Ruby losing popularity](https://www.infoworld.com/article/3956262/kotlin-swift-and-ruby-losing-popularity-tiobe-index.html)<!-- HN:43680685:end --><!-- HN:43680900:start -->
* [43680900](https://news.social-protocols.org/stats?id=43680900) #20 16 points 42 comments -> [Political beliefs affect patients' trust in doctors, study finds](https://news.uoregon.edu/political-beliefs-affect-patients-trust-doctors-study-finds)<!-- HN:43680900:end --><!-- HN:43680367:start -->
* [43680367](https://news.social-protocols.org/stats?id=43680367) #9 18 points 4 comments -> [SSH Keys Don't Scale. SSH Certificates Do](https://infisical.com/blog/ssh-keys-dont-scale)<!-- HN:43680367:end --><!-- HN:43681195:start -->
* [43681195](https://news.social-protocols.org/stats?id=43681195) #14 19 points 0 comments -> [One of the country's leading Alzheimer's projects is in jeopardy](https://www.nbcnews.com/health/health-news/one-countrys-leading-alzheimers-projects-jeopardy-rcna199788)<!-- HN:43681195:end --><!-- HN:43680556:start -->
* [43680556](https://news.social-protocols.org/stats?id=43680556) #16 44 points 24 comments -> [EU issues US-bound staff with burner phones over spying fears](https://www.ft.com/content/20d0678a-41b2-468d-ac10-14ce1eae357b)<!-- HN:43680556:end --><!-- HN:43683315:start -->
* [43683315](https://news.social-protocols.org/stats?id=43683315) #27 7 points 2 comments -> [GPT 4.1](https://platform.openai.com/docs/models/gpt-4.1)<!-- HN:43683315:end --><!-- HN:43683573:start -->
* [43683573](https://news.social-protocols.org/stats?id=43683573) #14 5 points 0 comments -> [Nihilism Is Not Enough by Peter Thiel](https://www.nihilismisnotenough.com/)<!-- HN:43683573:end --><!-- HN:43684828:start -->
* [43684828](https://news.social-protocols.org/stats?id=43684828) #24 7 points 1 comments -> [Will Peak Demand Roil Global Oil Markets?](https://libertystreeteconomics.newyorkfed.org/2025/04/will-peak-demand-roil-global-oil-markets/)<!-- HN:43684828:end --><!-- HN:43685629:start -->
* [43685629](https://news.social-protocols.org/stats?id=43685629) #7 11 points 0 comments -> [The Situation at Columbia (and Harvard)](https://www.math.columbia.edu/~woit/wordpress/?p=14556)<!-- HN:43685629:end --><!-- HN:43686004:start -->
* [43686004](https://news.social-protocols.org/stats?id=43686004) #12 5 points 0 comments -> [Why Is Africa Poor? Economic unfreedom, not slavery or colonialism](https://freeblackthought.substack.com/cp/156391441)<!-- HN:43686004:end -->
#### **Tuesday, April 15, 2025**<!-- HN:43688456:start -->
* [43688456](https://news.social-protocols.org/stats?id=43688456) #8 11 points 9 comments -> [USL – A Universal Scripting Language That Outputs to 111 Programming Languages](https://townsendatomics.gumroad.com/l/usl)<!-- HN:43688456:end --><!-- HN:43688395:start -->
* [43688395](https://news.social-protocols.org/stats?id=43688395) #22 32 points 13 comments -> [Overuse of CT scans could cause 100k extra cancers in US](https://www.icr.ac.uk/about-us/icr-news/detail/overuse-of-ct-scans-could-cause-100-000-extra-cancers-in-us)<!-- HN:43688395:end --><!-- HN:43688962:start -->
* [43688962](https://news.social-protocols.org/stats?id=43688962) #28 31 points 40 comments -> [The Industrialization of IT](https://benn.substack.com/p/the-industrialization-of-it)<!-- HN:43688962:end --><!-- HN:43690732:start -->
* [43690732](https://news.social-protocols.org/stats?id=43690732) #3 12 points 5 comments -> [Understanding US Power Outages – By Brian Potter](https://www.construction-physics.com/p/understanding-us-power-outages)<!-- HN:43690732:end --><!-- HN:43692341:start -->
* [43692341](https://news.social-protocols.org/stats?id=43692341) #3 9 points 1 comments -> [Show HN: Million Dollar Homepage Meets LinkedIn](https://10000resumes.com)<!-- HN:43692341:end --><!-- HN:43692690:start -->
* [43692690](https://news.social-protocols.org/stats?id=43692690) #18 46 points 14 comments -> [I'm getting fed up of making the rich, richer](https://bell.bz/im-getting-fed-up-of-making-the-rich-richer/)<!-- HN:43692690:end --><!-- HN:43694252:start -->
* [43694252](https://news.social-protocols.org/stats?id=43694252) #8 7 points 1 comments -> ["We have no bros and no oligarchs" EU President Ursula von der Leyen](https://www.zeit.de/politik/2025-04/ursula-von-der-leyen-eu-usa-donald-trump-english)<!-- HN:43694252:end --><!-- HN:43695069:start -->
* [43695069](https://news.social-protocols.org/stats?id=43695069) #5 22 points 2 comments -> [Show HN: I made a tool to send a letter now people use it to just print](https://www.pieterpost.com/)<!-- HN:43695069:end --><!-- HN:43695424:start -->
* [43695424](https://news.social-protocols.org/stats?id=43695424) #14 13 points 2 comments -> [Japanese Typography Essentials: Japanese Type Between Japanese and Latin](https://www.researchgate.net/publication/383515797_JAPANESE_TYPOGRAPHY_ESSENTIALS_JAPANESE_TYPE_BETWEEN_JAPANESE_LATIN_CHARACTER)<!-- HN:43695424:end --><!-- HN:43696213:start -->
* [43696213](https://news.social-protocols.org/stats?id=43696213) #25 16 points 0 comments -> [OCC Notifies Congress of Incident Involving Email System](https://occ.gov/news-issuances/news-releases/2025/nr-occ-2025-30.html)<!-- HN:43696213:end --><!-- HN:43699126:start -->
* [43699126](https://news.social-protocols.org/stats?id=43699126) #9 4 points 0 comments -> [Show HN: Open Source AI App – Try on Any Outfit](https://github.com/oyeolamilekan/gemini-ai-tryon)<!-- HN:43699126:end -->
#### **Wednesday, April 16, 2025**
<!-- HN:43702201:start -->
* [43702201](https://news.social-protocols.org/stats?id=43702201) #2 15 points 14 comments -> [Show HN: I Made Bagel Font](https://www.bake-ai.com/fonts)<!-- HN:43702201:end --><!-- HN:43670652:start -->
* [43670652](https://news.social-protocols.org/stats?id=43670652) #13 23 points 40 comments -> [Audiobooks vs. Printed Books: a debate as a reader and an author](https://newsandreviews.substack.com/p/audiobooks-vs-printed-books-a-debate)<!-- HN:43670652:end --><!-- HN:43666814:start -->
* [43666814](https://news.social-protocols.org/stats?id=43666814) #21 4 points 2 comments -> [Curse of the German Cat or the Most Ridiculous Aircraft Carrier Loss in History](https://en.topwar.ru/261547-prokljatie-nemeckogo-kota-ili-samaja-nelepaja-gibel-avianosca-za-vsju-istoriju.html)<!-- HN:43666814:end -->