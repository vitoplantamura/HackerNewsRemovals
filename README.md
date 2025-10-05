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

#### **Sunday, September 28, 2025**<!-- HN:45400945:start -->
* [45400945](https://news.social-protocols.org/stats?id=45400945) #2 22 points 6 comments -> [How to Set $2,455 on Fire](https://busd.steviep.xyz/howto)<!-- HN:45400945:end --><!-- HN:45400009:start -->
* [45400009](https://news.social-protocols.org/stats?id=45400009) #17 48 points 7 comments -> [How I accidently created the fastest CSV parser ever made](https://sanixdk.xyz/blogs/how-i-accidentally-created-the-fastest-csv-parser-ever-made)<!-- HN:45400009:end --><!-- HN:45401941:start -->
* [45401941](https://news.social-protocols.org/stats?id=45401941) #17 6 points 0 comments -> [Inside the Hidden Conservative Network Funding an Ecosystem of Right-Wing News](https://www.motherjones.com/politics/2025/09/inside-the-hidden-conservative-network-bankrolling-an-ecosystem-of-right-wing-news-informing-america-john-solomon-war-room/)<!-- HN:45401941:end --><!-- HN:45367635:start -->
* [45367635](https://news.social-protocols.org/stats?id=45367635) #9 7 points 0 comments -> [The Third Chair](https://www.henrikkarlsson.xyz/p/third-chair)<!-- HN:45367635:end --><!-- HN:45403775:start -->
* [45403775](https://news.social-protocols.org/stats?id=45403775) #20 19 points 11 comments -> [The stripper who ushered in the subscription-based internet](https://thehustle.co/originals/the-stripper-who-ushered-in-the-modern-subscription-based-internet)<!-- HN:45403775:end --><!-- HN:45404783:start -->
* [45404783](https://news.social-protocols.org/stats?id=45404783) #11 27 points 42 comments -> [Apple threatens to stop selling iPhones in the EU](https://pluralistic.net/2025/09/26/empty-threats/#500-million-affluent-consumers)<!-- HN:45404783:end --><!-- HN:45406215:start -->
* [45406215](https://news.social-protocols.org/stats?id=45406215) #25 8 points 0 comments -> [UN lists 158 firms tied to illegal Israeli settlements](https://www.aljazeera.com/news/2025/9/26/un-lists-150-firms-tied-to-illegal-israeli-settlements)<!-- HN:45406215:end --><!-- HN:45406075:start -->
* [45406075](https://news.social-protocols.org/stats?id=45406075) #23 2 points 0 comments -> [In C++ modules globally unique module names seem to be unavoidable](https://nibblestew.blogspot.com/2025/09/in-c-modules-globally-unique-module.html)<!-- HN:45406075:end --><!-- HN:45406921:start -->
* [45406921](https://news.social-protocols.org/stats?id=45406921) #26 -> [mRNA vaccines linked to increased risks of various cancers](https://biomarkerres.biomedcentral.com/articles/10.1186/s40364-025-00831-w)<!-- HN:45406921:end --><!-- HN:45405221:start -->
* [45405221](https://news.social-protocols.org/stats?id=45405221) #5 128 points 70 comments -> [Why I'm not rushing to take sides in the RubyGems fiasco](https://justin.searls.co/posts/why-im-not-rushing-to-take-sides-in-the-rubygems-fiasco/)<!-- HN:45405221:end -->
#### **Monday, September 29, 2025**
<!-- HN:45409013:start -->
* [45409013](https://news.social-protocols.org/stats?id=45409013) #16 9 points 1 comments -> [Imagination as General Intelligence: Reconciling Consciousness and Free Will](https://zenodo.org/records/17109096)<!-- HN:45409013:end --><!-- HN:45388402:start -->
* [45388402](https://news.social-protocols.org/stats?id=45388402) #15 18 points 40 comments -> [Reusable grocery bags durability test](https://www.cbc.ca/lite/story/1.7643243)<!-- HN:45388402:end --><!-- HN:45411666:start -->
* [45411666](https://news.social-protocols.org/stats?id=45411666) #7 28 points 1 comments -> [Twenty Lessons on Fighting Tyranny from the Twentieth Century](https://scholars.org/contribution/twenty-lessons-fighting-tyranny-twentieth)<!-- HN:45411666:end --><!-- HN:45412178:start -->
* [45412178](https://news.social-protocols.org/stats?id=45412178) #7 21 points 6 comments -> [Does AI Get Bored?](https://timkellogg.me/blog/2025/09/27/boredom)<!-- HN:45412178:end --><!-- HN:45376953:start -->
* [45376953](https://news.social-protocols.org/stats?id=45376953) #14 27 points 1 comments -> [Typst: A Possible LaTeX Replacement](https://lwn.net/Articles/1037577/)<!-- HN:45376953:end --><!-- HN:45412946:start -->
* [45412946](https://news.social-protocols.org/stats?id=45412946) #18 35 points 41 comments -> [Leading computer science professor says 'everybody' is struggling to get jobs](https://www.businessinsider.com/computer-science-students-job-search-ai-hany-farid-2025-9)<!-- HN:45412946:end --><!-- HN:45414327:start -->
* [45414327](https://news.social-protocols.org/stats?id=45414327) #5 36 points 18 comments -> [Grok is now the most popular model on OpenRouter](https://openrouter.ai/rankings#market-share)<!-- HN:45414327:end --><!-- HN:45416122:start -->
* [45416122](https://news.social-protocols.org/stats?id=45416122) #2 34 points 1 comments -> [Claude Sonnet 4.5 System Card [pdf]](https://assets.anthropic.com/m/12f214efcc2f457a/original/Claude-Sonnet-4-5-System-Card.pdf)<!-- HN:45416122:end --><!-- HN:45415469:start -->
* [45415469](https://news.social-protocols.org/stats?id=45415469) #28 7 points 1 comments -> [Google’s “G” gets a brighter look.](https://blog.google/inside-google/company-announcements/gradient-g-logo-design/)<!-- HN:45415469:end --><!-- HN:45389934:start -->
* [45389934](https://news.social-protocols.org/stats?id=45389934) #26 6 points 4 comments -> [Show HN: Font Tester – Preview fonts on custom content](https://fonts.tomhadley.link/)<!-- HN:45389934:end --><!-- HN:45416150:start -->
* [45416150](https://news.social-protocols.org/stats?id=45416150) #19 19 points 2 comments -> [OpenAI and Stripe create Agentic Commerce Protocol](https://www.agenticcommerce.dev/)<!-- HN:45416150:end --><!-- HN:45416572:start -->
* [45416572](https://news.social-protocols.org/stats?id=45416572) #25 95 points 1 comments -> [Instant Checkout for Merchants in ChatGPT](https://chatgpt.com/merchants)<!-- HN:45416572:end -->
#### **Tuesday, September 30, 2025**
<!-- HN:45420302:start -->
* [45420302](https://news.social-protocols.org/stats?id=45420302) #22 7 points 4 comments -> [Larry Ellison wants the U.S. to 'unify all the national data and then feed to AI](https://fortune.com/2025/02/14/larry-ellison-ai-centralized-database-citizen-data/)<!-- HN:45420302:end --><!-- HN:45424389:start -->
* [45424389](https://news.social-protocols.org/stats?id=45424389) #27 10 points 4 comments -> [Intel's original 64bit extensions for x86](https://soc.me/interfaces/intels-original-64bit-extensions-for-x86.html)<!-- HN:45424389:end --><!-- HN:45424217:start -->
* [45424217](https://news.social-protocols.org/stats?id=45424217) #1 42 points 17 comments -> [Apple HomeKit – The Long Con](https://www.naut.ca/blog/2025/08/29/apple-homekit-the-long-con/)<!-- HN:45424217:end --><!-- HN:45424840:start -->
* [45424840](https://news.social-protocols.org/stats?id=45424840) #17 18 points 40 comments -> [AI Actress Tilly Norwood Condemned by Sag-Aftra: Tilly 'Is Not an Actor '](https://variety.com/2025/film/news/sag-aftra-tilly-norwood-ai-actress-1236534779/)<!-- HN:45424840:end --><!-- HN:45426127:start -->
* [45426127](https://news.social-protocols.org/stats?id=45426127) #7 -> [J.K. Rowling Writes about Her Reasons for Speaking Out on Sex and Gender Issues](https://www.jkrowling.com/opinions/j-k-rowling-writes-about-her-reasons-for-speaking-out-on-sex-and-gender-issues/)<!-- HN:45426127:end --><!-- HN:45426457:start -->
* [45426457](https://news.social-protocols.org/stats?id=45426457) #15 16 points 10 comments -> [Show HN: I'm 17, built a face-verified social network to fight fake accounts](https://play.google.com/store/apps/details?id=com.whitelotus.social&hl=en_US)<!-- HN:45426457:end --><!-- HN:45426858:start -->
* [45426858](https://news.social-protocols.org/stats?id=45426858) #10 41 points 3 comments -> [Charlie Javice sentenced to 7 years in prison for fraudulent $175M sale of Frank](https://www.nbcnews.com/business/business-news/charlie-javice-sentenced-7-years-prison-fraudulent-175m-sale-financial-rcna234536)<!-- HN:45426858:end --><!-- HN:45425897:start -->
* [45425897](https://news.social-protocols.org/stats?id=45425897) #14 59 points 2 comments -> [Electronic Arts to be acquired for $52B in largest private equity buyout](https://www.nbcnews.com/business/business-news/electronic-arts-acquired-largest-ever-private-equity-buyout-rcna234432)<!-- HN:45425897:end --><!-- HN:45428294:start -->
* [45428294](https://news.social-protocols.org/stats?id=45428294) #14 6 points 1 comments -> [U.S. Department of Housing and Urban Development](https://www.hud.gov/)<!-- HN:45428294:end --><!-- HN:45428122:start -->
* [45428122](https://news.social-protocols.org/stats?id=45428122) #1 262 points 203 comments -> [Sora 2](https://openai.com/index/sora-2/)<!-- HN:45428122:end --><!-- HN:45431979:start -->
* [45431979](https://news.social-protocols.org/stats?id=45431979) #17 7 points 2 comments -> [Live Video of Global Sumud Flotilla](https://globalsumudflotilla.org/live/)<!-- HN:45431979:end -->
#### **Wednesday, October 1, 2025**<!-- HN:45433619:start -->
* [45433619](https://news.social-protocols.org/stats?id=45433619) #4 11 points 1 comments -> [A Requiem for a Dying Operating System (1994)](https://user.eng.umd.edu/~blj/funny/requium.html)<!-- HN:45433619:end --><!-- HN:45434179:start -->
* [45434179](https://news.social-protocols.org/stats?id=45434179) #10 35 points 23 comments -> [US government shuts down](https://www.theguardian.com/us-news/2025/oct/01/us-government-shuts-down)<!-- HN:45434179:end --><!-- HN:45402706:start -->
* [45402706](https://news.social-protocols.org/stats?id=45402706) #8 6 points 2 comments -> [What Is Copolymer 3D Filament and Why Should You Use It](https://filamatrix.com/blogs/blogs/what-is-copolymer-3d-filament-and-why-should-you-use-it)<!-- HN:45402706:end --><!-- HN:45434062:start -->
* [45434062](https://news.social-protocols.org/stats?id=45434062) #5 155 points 63 comments -> [I Went to Prison](https://prison.josh.mn/)<!-- HN:45434062:end --><!-- HN:45434700:start -->
* [45434700](https://news.social-protocols.org/stats?id=45434700) #29 8 points 0 comments -> [The Mainstream Media Is Catastrophically Failing to Meet the Moment](https://www.techdirt.com/2025/09/30/the-mainstream-media-is-catastrophically-failing-to-meet-the-moment/)<!-- HN:45434700:end --><!-- HN:45394146:start -->
* [45394146](https://news.social-protocols.org/stats?id=45394146) #8 -> [Type theory and functional programming. (1999) [pdf]](https://www.cs.cornell.edu/courses/cs6110/2015sp/textbook/Simon%20Thompson%20textbook.pdf)<!-- HN:45394146:end --><!-- HN:45434779:start -->
* [45434779](https://news.social-protocols.org/stats?id=45434779) #30 35 points 24 comments -> [The God Mode Vulnerability That Should Kill "Trust Microsoft" Forever](https://tide.org/blog/god-mode-vulnerability-microsoft-authorityless-security)<!-- HN:45434779:end --><!-- HN:45436378:start -->
* [45436378](https://news.social-protocols.org/stats?id=45436378) #16 9 points 3 comments -> [Cannabis extract found to be effective for lower back pain](https://www.newscientist.com/article/2498064-cannabis-extract-found-to-be-effective-for-lower-back-pain/)<!-- HN:45436378:end --><!-- HN:45436976:start -->
* [45436976](https://news.social-protocols.org/stats?id=45436976) #16 7 points 0 comments -> [Electronic Arts to be acquired in $55B deal](https://www.cbsnews.com/news/electronic-arts-the-sims-madden-nfl-acquisition-55-billion/)<!-- HN:45436976:end --><!-- HN:45397339:start -->
* [45397339](https://news.social-protocols.org/stats?id=45397339) #11 8 points 2 comments -> [Increase Image kb size to 20KB, 50KB, or to the specific KBs](https://www.hadbomb.com/increase-image-size/)<!-- HN:45397339:end --><!-- HN:45440207:start -->
* [45440207](https://news.social-protocols.org/stats?id=45440207) #28 37 points 41 comments -> [Supreme Court lets Fed Governor Cook keep job pending oral argument in January](https://www.cnbc.com/2025/10/01/supreme-court-trump-fed-lisa-cook.html)<!-- HN:45440207:end --><!-- HN:45442365:start -->
* [45442365](https://news.social-protocols.org/stats?id=45442365) #14 4 points 3 comments -> [The Anti-Truth Mandate: A Technical Flaw in Claude's Safety Architecture](https://github.com/anthropics/claude-code/issues/8683)<!-- HN:45442365:end -->
#### **Thursday, October 2, 2025**
<!-- HN:45445331:start -->
* [45445331](https://news.social-protocols.org/stats?id=45445331) #4 9 points 1 comments -> [Maine Woman Discovers Election Ballots in Amazon Package](https://www.themainewire.com/2025/10/maine-woman-discovers-hundreds-of-election-ballots-in-amazon-package-as-state-considers-voter-id/)<!-- HN:45445331:end --><!-- HN:45446240:start -->
* [45446240](https://news.social-protocols.org/stats?id=45446240) #11 10 points 4 comments -> [AI is not killing jobs, US study finds](https://www.ft.com/content/c9f905a0-cbfc-4a0a-ac4f-0d68d0fc64aa)<!-- HN:45446240:end --><!-- HN:45448935:start -->
* [45448935](https://news.social-protocols.org/stats?id=45448935) #3 11 points 0 comments -> [Visual loading states for Turbo Frames with CSS only](https://railsdesigner.com/visual-loading-turbo-frames/)<!-- HN:45448935:end --><!-- HN:45451467:start -->
* [45451467](https://news.social-protocols.org/stats?id=45451467) #26 -> [DHH Is Way Worse Than I Thought](https://jakelazaroff.com/words/dhh-is-way-worse-than-i-thought/)<!-- HN:45451467:end --><!-- HN:45455139:start -->
* [45455139](https://news.social-protocols.org/stats?id=45455139) #26 10 points 6 comments -> [USDA website blames "Radical Left Democrats" for shutdown](https://www.usda.gov/)<!-- HN:45455139:end --><!-- HN:45436391:start -->
* [45436391](https://news.social-protocols.org/stats?id=45436391) #18 4 points 0 comments -> [Creating a Database of Motivated Proofs](https://gowers.wordpress.com/2025/09/22/creating-a-database-of-motivated-proofs/)<!-- HN:45436391:end -->
#### **Friday, October 3, 2025**
<!-- HN:45458010:start -->
* [45458010](https://news.social-protocols.org/stats?id=45458010) #29 4 points 0 comments -> [Education Department employees' email messages changed to blame Democrats](https://www.nbcnews.com/politics/trump-administration/education-department-employees-email-automatically-changed-rcna235211)<!-- HN:45458010:end --><!-- HN:45457929:start -->
* [45457929](https://news.social-protocols.org/stats?id=45457929) #8 6 points 0 comments -> [I Trained a Small Language Model from Scratch](https://nwosunneoma.medium.com/how-i-trained-a-small-language-model-from-scratch-8af167479d1a)<!-- HN:45457929:end --><!-- HN:45458500:start -->
* [45458500](https://news.social-protocols.org/stats?id=45458500) #17 6 points 0 comments -> [USC sold dead bodies to U.S. military to train IDF medical personnel](https://www.uscannenbergmedia.com/2025/10/01/usc-sold-dead-bodies-to-us-military-to-train-idf-medical-personnel/)<!-- HN:45458500:end --><!-- HN:45458768:start -->
* [45458768](https://news.social-protocols.org/stats?id=45458768) #23 57 points 36 comments -> [Rescuer at Fatal Tesla Cybertruck Crash Says Car Doors Wouldn't Open](https://www.newsweek.com/tesla-cybertruck-car-door-malfunction-2043976)<!-- HN:45458768:end --><!-- HN:45459214:start -->
* [45459214](https://news.social-protocols.org/stats?id=45459214) #25 31 points 29 comments -> [Japan's ruling party is in crisis as voters swing to right-wing rivals](https://www.cnn.com/2025/10/02/asia/japan-ruling-party-election-explainer-intl-hnk)<!-- HN:45459214:end --><!-- HN:45460707:start -->
* [45460707](https://news.social-protocols.org/stats?id=45460707) #3 51 points 5 comments -> [Apple Pulls ICEBlock from the App Store](https://www.theverge.com/news/791170/iceblock-app-store-removed-by-apple)<!-- HN:45460707:end --><!-- HN:45461329:start -->
* [45461329](https://news.social-protocols.org/stats?id=45461329) #11 12 points 0 comments -> [Circassian Genocide](https://en.wikipedia.org/wiki/Circassian_genocide)<!-- HN:45461329:end --><!-- HN:45461951:start -->
* [45461951](https://news.social-protocols.org/stats?id=45461951) #5 -> [Apple Bows to MAGA Demands on ICE Goon Tracker Apps](https://www.msn.com/en-us/news/technology/apple-bows-to-maga-demands-on-ice-goon-tracker-apps/ar-AA1NMH7z)<!-- HN:45461951:end --><!-- HN:45462071:start -->
* [45462071](https://news.social-protocols.org/stats?id=45462071) #28 12 points 2 comments -> [Apple Takes Down ICE Tracking Apps Amid Trump Pressure Campaign](https://www.nytimes.com/2025/10/02/us/politics/apple-iceblock-app-store-trump.html)<!-- HN:45462071:end --><!-- HN:45425770:start -->
* [45425770](https://news.social-protocols.org/stats?id=45425770) #27 37 points 40 comments -> [Valuing Land: The Simplest Viable Method](https://progressandpoverty.substack.com/p/valuing-land-the-simplest-viable)<!-- HN:45425770:end --><!-- HN:45462163:start -->
* [45462163](https://news.social-protocols.org/stats?id=45462163) #17 55 points 55 comments -> [TikTok 'directs child accounts to pornographic content within a few clicks'](https://www.theguardian.com/technology/2025/oct/03/tiktok-child-accounts-pornographic-content-accessible)<!-- HN:45462163:end --><!-- HN:45462452:start -->
* [45462452](https://news.social-protocols.org/stats?id=45462452) #27 19 points 4 comments -> [Larry Ellison vetted Marco Rubio for fealty to Israel, hacked emails reveal](https://twitter.com/dd_geopolitics/status/1973837314926461264)<!-- HN:45462452:end --><!-- HN:45463177:start -->
* [45463177](https://news.social-protocols.org/stats?id=45463177) #15 10 points 2 comments -> [Tech Giant Bows to MAGA Demands on ICE Goon Tracker Apps](https://www.thedailybeast.com/apple-bows-to-maga-demands-and-removes-ice-tracking-apps/)<!-- HN:45463177:end --><!-- HN:45463111:start -->
* [45463111](https://news.social-protocols.org/stats?id=45463111) #2 76 points 8 comments -> [Apple removes ICEBlock and similar tracking apps from the App Store](https://techcrunch.com/2025/10/03/apple-removes-iceblock-and-similar-tracking-apps-from-the-app-store/)<!-- HN:45463111:end --><!-- HN:45464109:start -->
* [45464109](https://news.social-protocols.org/stats?id=45464109) #23 12 points 2 comments -> [White House posts "enemies list" of Democrats critical of ICE](https://www.techdirt.com/2025/10/02/trump-publishes-enemies-list-to-white-house-website-and-its-just-democrats-speaking-the-truth/)<!-- HN:45464109:end --><!-- HN:45464409:start -->
* [45464409](https://news.social-protocols.org/stats?id=45464409) #7 33 points 3 comments -> [0-Day iOS Exploit "Caught in the Wild" Released](https://seclists.org/fulldisclosure/2025/Oct/1)<!-- HN:45464409:end --><!-- HN:45465803:start -->
* [45465803](https://news.social-protocols.org/stats?id=45465803) #19 41 points 12 comments -> [Apple removes ICEBlock, won't allow apps that report locations of ICE agents](https://arstechnica.com/tech-policy/2025/10/apple-bends-to-trump-admin-demand-to-remove-ice-tracking-apps-like-iceblock/)<!-- HN:45465803:end --><!-- HN:45435283:start -->
* [45435283](https://news.social-protocols.org/stats?id=45435283) #24 44 points 2 comments -> [Glide, an extensible, keyboard-focused web browser](https://blog.craigie.dev/introducing-glide/)<!-- HN:45435283:end --><!-- HN:45467230:start -->
* [45467230](https://news.social-protocols.org/stats?id=45467230) #7 40 points 15 comments -> [Credit markets look increasingly dangerous](https://www.economist.com/finance-and-economics/2025/10/02/credit-markets-look-increasingly-dangerous)<!-- HN:45467230:end --><!-- HN:45467895:start -->
* [45467895](https://news.social-protocols.org/stats?id=45467895) #26 8 points 0 comments -> ['Our children are dying': Rare footage shows plight of besieged civilians](https://www.bbc.com/news/articles/czxp0qyn6dqo)<!-- HN:45467895:end --><!-- HN:45467886:start -->
* [45467886](https://news.social-protocols.org/stats?id=45467886) #3 -> [Oracle employees who criticise Israel referred to mental health services](https://responsiblestatecraft.org/oracle-tiktok-israel-2674151514/)<!-- HN:45467886:end --><!-- HN:45468324:start -->
* [45468324](https://news.social-protocols.org/stats?id=45468324) #6 11 points 2 comments -> [Show HN: A visual AI interface to understand papers/books/topics](https://www.kerns.ai/)<!-- HN:45468324:end -->
#### **Saturday, October 4, 2025**<!-- HN:45476347:start -->
* [45476347](https://news.social-protocols.org/stats?id=45476347) #25 4 points 6 comments -> [Designers Should Look to Demis Hassabis. Not Jony Ive](https://www.suffsyed.com/futurememo/designers-should-look-to-demis-hassabis-not-jony-ive)<!-- HN:45476347:end -->
#### **Sunday, October 5, 2025**
<!-- HN:45477215:start -->
* [45477215](https://news.social-protocols.org/stats?id=45477215) #6 22 points 7 comments -> [How do drivers react to partisan bumper stickers?](https://www.frontiersin.org/articles/10.3389/fpos.2025.1617785)<!-- HN:45477215:end -->