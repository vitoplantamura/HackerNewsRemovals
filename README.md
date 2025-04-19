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
* [43702201](https://news.social-protocols.org/stats?id=43702201) #2 15 points 14 comments -> [Show HN: I Made Bagel Font](https://www.bake-ai.com/fonts)<!-- HN:43702201:end --><!-- HN:43666814:start -->
* [43666814](https://news.social-protocols.org/stats?id=43666814) #21 4 points 2 comments -> [Curse of the German Cat or the Most Ridiculous Aircraft Carrier Loss in History](https://en.topwar.ru/261547-prokljatie-nemeckogo-kota-ili-samaja-nelepaja-gibel-avianosca-za-vsju-istoriju.html)<!-- HN:43666814:end --><!-- HN:43703951:start -->
* [43703951](https://news.social-protocols.org/stats?id=43703951) #13 5 points 0 comments -> [Trumps escalating trade war in 5 scenarios: impact on Dutch economy [Dutch]](https://www.rabobank.nl/kennis/d011475085-trumps-escalerende-handelsoorlog-in-vijf-scenarios-impact-op-de-nederlandse-economie-en-breder)<!-- HN:43703951:end --><!-- HN:43704357:start -->
* [43704357](https://news.social-protocols.org/stats?id=43704357) #8 29 points 27 comments -> [We're Raising Kids to Prefer AI over People–and No One's Noticing](https://substack.com/home/post/p-161454917)<!-- HN:43704357:end --><!-- HN:43704319:start -->
* [43704319](https://news.social-protocols.org/stats?id=43704319) #3 29 points 13 comments -> [AI Is Facing a Crisis](https://savethe.ai/)<!-- HN:43704319:end --><!-- HN:43704481:start -->
* [43704481](https://news.social-protocols.org/stats?id=43704481) #22 11 points 3 comments -> [Russian Breach of US Data Through Doge over Starlink "Directly to Russia"](https://www.narativ.org/p/whistle-blower-russian-breach-of)<!-- HN:43704481:end --><!-- HN:43704951:start -->
* [43704951](https://news.social-protocols.org/stats?id=43704951) #12 26 points 15 comments -> [Spotify Down](https://community.spotify.com/t5/Ongoing-Issues/Downtime-April-16th-App-and-website-not-loading/idi-p/6922020)<!-- HN:43704951:end -->
#### **Thursday, April 17, 2025**
<!-- HN:43712212:start -->
* [43712212](https://news.social-protocols.org/stats?id=43712212) #6 7 points 0 comments -> [American Concentration Camps](https://chrishedges.substack.com/p/american-concentration-camps)<!-- HN:43712212:end --><!-- HN:43712663:start -->
* [43712663](https://news.social-protocols.org/stats?id=43712663) #7 6 points 0 comments -> [Why does everything look infantilized?](https://assemblagenyc.substack.com/p/why-does-everything-look-infantilized)<!-- HN:43712663:end --><!-- HN:43685813:start -->
* [43685813](https://news.social-protocols.org/stats?id=43685813) #8 9 points 1 comments -> [C has its limits. If you know where to look](https://subethasoftware.com/2024/12/09/c-has-its-limits-if-you-know-where-to-look/)<!-- HN:43685813:end --><!-- HN:43713881:start -->
* [43713881](https://news.social-protocols.org/stats?id=43713881) #22 7 points 2 comments -> [Astronomers claim strongest evidence of alien life yet](https://www.newscientist.com/article/2477008-astronomers-claim-strongest-evidence-of-alien-life-yet/)<!-- HN:43713881:end --><!-- HN:43715097:start -->
* [43715097](https://news.social-protocols.org/stats?id=43715097) #30 10 points 3 comments -> [The point of no return:Only days left to stop a totalitarian state in the US](https://crookedtimber.org/2025/04/17/the-point-of-no-returnonly-days-left-to-stop-a-totalitarian-state-in-the-us/)<!-- HN:43715097:end --><!-- HN:43716766:start -->
* [43716766](https://news.social-protocols.org/stats?id=43716766) #24 10 points 0 comments -> [Europe's cloud customers eyeing exit from US hyperscalers](https://www.theregister.com/2025/04/17/us_hyperscaler_alternatives/)<!-- HN:43716766:end --><!-- HN:43673904:start -->
* [43673904](https://news.social-protocols.org/stats?id=43673904) #21 16 points 16 comments -> [The New Moat: Memory](https://jeffmorrisjr.substack.com/p/the-new-moat-memory)<!-- HN:43673904:end --><!-- HN:43719211:start -->
* [43719211](https://news.social-protocols.org/stats?id=43719211) #4 52 points 36 comments -> [Top OpenAI Catastrophic Risk Official Steps Down Abruptly](https://garrisonlovely.substack.com/p/breaking-top-openai-catastrophic)<!-- HN:43719211:end --><!-- HN:43721301:start -->
* [43721301](https://news.social-protocols.org/stats?id=43721301) #8 5 points 0 comments -> [LLM Reasoning may be older than we think](https://github.com/andyk/recursive_llm)<!-- HN:43721301:end --><!-- HN:43722220:start -->
* [43722220](https://news.social-protocols.org/stats?id=43722220) #11 4 points 2 comments -> [Digital nomads could create network states](https://www.elysian.press/p/digital-nomad-network-states)<!-- HN:43722220:end --><!-- HN:43723160:start -->
* [43723160](https://news.social-protocols.org/stats?id=43723160) #28 14 points 0 comments -> [Trump's FCC chair threatens Comcast, demands changes to NBC news coverage](https://arstechnica.com/tech-policy/2025/04/trumps-fcc-chair-threatens-comcast-demands-changes-to-nbc-news-coverage/)<!-- HN:43723160:end -->
#### **Friday, April 18, 2025**
<!-- HN:43723544:start -->
* [43723544](https://news.social-protocols.org/stats?id=43723544) #11 5 points 1 comments -> [Is anybody using this private key?](https://isanybodyusingthisprivatekey.com/)<!-- HN:43723544:end --><!-- HN:43723356:start -->
* [43723356](https://news.social-protocols.org/stats?id=43723356) #12 9 points 0 comments -> [Olympic Gold Medalist Dominates the 100M at Her Kid's Sports Day Event](https://kottke.org/25/04/olympic-gold-medalist-dominates-the-100m-at-her-kids-sports-day-event)<!-- HN:43723356:end --><!-- HN:43723825:start -->
* [43723825](https://news.social-protocols.org/stats?id=43723825) #9 -> [U.S.-born man held for ICE under Florida's new anti-immigration law](https://newhampshirebulletin.com/2025/04/17/u-s-born-man-held-for-ice-under-floridas-new-anti-immigration-law/)<!-- HN:43723825:end --><!-- HN:43723964:start -->
* [43723964](https://news.social-protocols.org/stats?id=43723964) #4 24 points 2 comments -> [Kagi Assistant is now available to all users](https://blog.kagi.com/assistant-for-all)<!-- HN:43723964:end --><!-- HN:43724173:start -->
* [43724173](https://news.social-protocols.org/stats?id=43724173) #28 16 points 3 comments -> [American citizen detained under ICE hold in Florida](https://www.cnn.com/2025/04/17/us/lopez-gomez-citizen-detained-ice-florida/index.html)<!-- HN:43724173:end --><!-- HN:43715022:start -->
* [43715022](https://news.social-protocols.org/stats?id=43715022) #15 332 points 364 comments -> [US Government threatens Harvard with foreign student ban](https://www.bbc.com/news/articles/c1egdy24v7po)<!-- HN:43715022:end --><!-- HN:43724618:start -->
* [43724618](https://news.social-protocols.org/stats?id=43724618) #10 5 points 0 comments -> [Everyone knows your location, Part 2: try it yourself and share the results](https://timsh.org/everyone-knows-your-location-part-2-try-it-yourself/)<!-- HN:43724618:end --><!-- HN:43724589:start -->
* [43724589](https://news.social-protocols.org/stats?id=43724589) #12 3 points 0 comments -> [PDF Dimmer Bookmarklet](https://susam.net/pdf-dimmer-bookmarklet.html)<!-- HN:43724589:end --><!-- HN:43724087:start -->
* [43724087](https://news.social-protocols.org/stats?id=43724087) #25 29 points 40 comments -> [Soldiers in combat can kill without moral injury](https://www.bps.org.uk/research-digest/soldiers-combat-can-kill-without-moral-injury)<!-- HN:43724087:end --><!-- HN:43725124:start -->
* [43725124](https://news.social-protocols.org/stats?id=43725124) #11 23 points 1 comments -> [A deep-cover KGB spy recruited his own son](https://www.theguardian.com/news/2025/apr/10/deep-cover-kgb-spy-recruited-son-peter-herrmann-illegals)<!-- HN:43725124:end --><!-- HN:43691054:start -->
* [43691054](https://news.social-protocols.org/stats?id=43691054) #14 5 points 3 comments -> [How I created a real-time F1 circuit tracker that updates every second on iOS](https://apps.apple.com/es/app/pit-stop/id6743395104?l=en-GB)<!-- HN:43691054:end --><!-- HN:43726708:start -->
* [43726708](https://news.social-protocols.org/stats?id=43726708) #25 6 points 0 comments -> [A deadly E. coli outbreak hit 15 states, but the FDA chose not to publicize it](https://www.nbcnews.com/news/us-news/ecoli-bacteria-lettuce-outbreak-rcna200236)<!-- HN:43726708:end --><!-- HN:43727367:start -->
* [43727367](https://news.social-protocols.org/stats?id=43727367) #11 13 points 1 comments -> [Trump is losing voters on the economy, the issue that got him elected](https://www.gelliottmorris.com/p/chart-of-the-week-trump-is-losing)<!-- HN:43727367:end --><!-- HN:43727397:start -->
* [43727397](https://news.social-protocols.org/stats?id=43727397) #30 4 points 0 comments -> [The Man Who Fought Chicago for His Cadillac–and Never Got It Back](https://reason.com/2025/04/16/the-man-who-fought-chicago-for-his-cadillac-and-never-got-it-back/)<!-- HN:43727397:end --><!-- HN:43727835:start -->
* [43727835](https://news.social-protocols.org/stats?id=43727835) #1 41 points 14 comments -> [NSF halts grant awards while staff do second review](https://www.science.org/content/article/nsf-halts-grant-awards-while-staff-do-second-review)<!-- HN:43727835:end --><!-- HN:43727816:start -->
* [43727816](https://news.social-protocols.org/stats?id=43727816) #14 29 points 17 comments -> [Americans Are Obsessed with Protein and It's Driving Nutrition Experts Nuts](https://www.wsj.com/lifestyle/protein-food-industry-trend-nutrition-8a2cf27b)<!-- HN:43727816:end --><!-- HN:43728733:start -->
* [43728733](https://news.social-protocols.org/stats?id=43728733) #12 8 points 1 comments -> [Why Crypto Developer Activity Is Declining](https://stovetop.substack.com/p/why-crypto-developer-activity-is)<!-- HN:43728733:end --><!-- HN:43729712:start -->
* [43729712](https://news.social-protocols.org/stats?id=43729712) #21 18 points 41 comments -> [Dear Lewis, my CEO wants AI to do it all. How do I argue for humans?](https://lewislin.substack.com/p/dear-lewis-my-ceo-wants-ai-to-do)<!-- HN:43729712:end --><!-- HN:43730253:start -->
* [43730253](https://news.social-protocols.org/stats?id=43730253) #17 -> [Tesla Odometer Mileage Wrong](https://old.reddit.com/r/TeslaModel3/comments/zjc21g/odometer_mileage_wrong/)<!-- HN:43730253:end --><!-- HN:43730796:start -->
* [43730796](https://news.social-protocols.org/stats?id=43730796) #15 6 points 0 comments -> [Tesla brand damage is destroying used car value](https://electrek.co/2025/04/18/tesla-tsla-brand-damage-destroying-used-car-value/)<!-- HN:43730796:end --><!-- HN:43730934:start -->
* [43730934](https://news.social-protocols.org/stats?id=43730934) #27 3 points 0 comments -> [NASA's next space-telescope is almost ready to launch but may be killed by cuts](https://www.scientificamerican.com/article/nasas-next-major-space-telescope-is-ready-to-launch-trump-wants-to-kill-it/)<!-- HN:43730934:end --><!-- HN:43731849:start -->
* [43731849](https://news.social-protocols.org/stats?id=43731849) #22 3 points 0 comments -> [Im launching a community of dis-regulation hackers](https://app.unblend.me)<!-- HN:43731849:end -->
#### **Saturday, April 19, 2025**
<!-- HN:43731917:start -->
* [43731917](https://news.social-protocols.org/stats?id=43731917) #27 7 points 12 comments -> [Show HN: Too Many Business Ideas? stop choosing, launch all of them, FAST&FREE](https://starterpilot.com/)<!-- HN:43731917:end -->