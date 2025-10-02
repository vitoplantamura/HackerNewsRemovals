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

#### **Friday, September 26, 2025**
<!-- HN:45380858:start -->
* [45380858](https://news.social-protocols.org/stats?id=45380858) #8 33 points 21 comments -> [Conspiracy content drives anti-establishment sentiment on TikTok, YouTube](https://news.umich.edu/conspiracy-content-drives-anti-establishment-sentiment-on-tiktok-youtube/)<!-- HN:45380858:end --><!-- HN:45380778:start -->
* [45380778](https://news.social-protocols.org/stats?id=45380778) #18 4 points 0 comments -> [Arctic sea ice has reached minimum extent for 2025](https://cires.colorado.edu/news/arctic-sea-ice-has-reached-minimum-extent-2025)<!-- HN:45380778:end --><!-- HN:45382668:start -->
* [45382668](https://news.social-protocols.org/stats?id=45382668) #21 39 points 21 comments -> [The effect of H-1B quota on employment and selection of foreign-born labor (2018)](https://doi.org/10.1016/j.euroecorev.2018.06.010)<!-- HN:45382668:end --><!-- HN:45384890:start -->
* [45384890](https://news.social-protocols.org/stats?id=45384890) #7 12 points 0 comments -> [Apple's Claimed Private Data Flows Pass Through Amazon Infrastructure](https://gist.github.com/JGoyd/e5fe395c4b51f9e03734ad08e6e790db)<!-- HN:45384890:end --><!-- HN:45384804:start -->
* [45384804](https://news.social-protocols.org/stats?id=45384804) #16 4 points 0 comments -> [Apple's disregard for security and privacy is mind-boggling (2020)](https://evermeet.cx/wiki/Apple%27s_disregard_for_security_and_privacy_is_mind-boggling)<!-- HN:45384804:end --><!-- HN:45385252:start -->
* [45385252](https://news.social-protocols.org/stats?id=45385252) #28 28 points 41 comments -> [Facebook and Instagram to offer ad-free service in UK for up to £3.99 a month](https://www.theguardian.com/technology/2025/sep/26/facebook-and-instagram-to-offer-paid-ad-free-service-uk)<!-- HN:45385252:end --><!-- HN:45387356:start -->
* [45387356](https://news.social-protocols.org/stats?id=45387356) #26 12 points 3 comments -> [Hundreds of Diplomats stage walkout from UN as Netanyahu enters to speak](https://www.timesofisrael.com/liveblog_entry/hundreds-of-diplomats-stage-walkout-from-un-general-assembly-as-netanyahu-enters-to-speak/)<!-- HN:45387356:end --><!-- HN:45390061:start -->
* [45390061](https://news.social-protocols.org/stats?id=45390061) #10 -> [Valve Prism](https://valveprism.com/)<!-- HN:45390061:end --><!-- HN:45358959:start -->
* [45358959](https://news.social-protocols.org/stats?id=45358959) #22 5 points 0 comments -> [How to manage Python projects with Poetry](https://www.infoworld.com/article/2256032/how-to-manage-python-projects-with-poetry.html)<!-- HN:45358959:end -->
#### **Saturday, September 27, 2025**
<!-- HN:45392811:start -->
* [45392811](https://news.social-protocols.org/stats?id=45392811) #27 8 points 0 comments -> [Times New Dumbass](https://timesnewdumbass.co/)<!-- HN:45392811:end --><!-- HN:45393087:start -->
* [45393087](https://news.social-protocols.org/stats?id=45393087) #7 8 points 1 comments -> [Casimir Effect Energy](https://www.casimirspace.com)<!-- HN:45393087:end --><!-- HN:45393306:start -->
* [45393306](https://news.social-protocols.org/stats?id=45393306) #24 13 points 1 comments -> [YC Stole a SF-Attacked Founder's Startup](https://twitter.com/_opencv_/status/1971774399729881319)<!-- HN:45393306:end --><!-- HN:45394181:start -->
* [45394181](https://news.social-protocols.org/stats?id=45394181) #28 3 points 0 comments -> [Show HN: One API for all your SMTPs](https://www.brieferl.com)<!-- HN:45394181:end --><!-- HN:45371359:start -->
* [45371359](https://news.social-protocols.org/stats?id=45371359) #14 8 points 0 comments -> [How many valid JSON strings are there?](https://qntm.org/jsoncount)<!-- HN:45371359:end --><!-- HN:45361717:start -->
* [45361717](https://news.social-protocols.org/stats?id=45361717) #25 6 points 0 comments -> [Notes on Geiger Counters](https://divested.dev/pages/blog#2025-09-24-geigers)<!-- HN:45361717:end --><!-- HN:45395782:start -->
* [45395782](https://news.social-protocols.org/stats?id=45395782) #15 3 points 1 comments -> [Health Effects of Cousin Marriage: Evidence from US Genealogical Records](https://www.aeaweb.org/articles?id=10.1257/aeri.20230544)<!-- HN:45395782:end --><!-- HN:45397773:start -->
* [45397773](https://news.social-protocols.org/stats?id=45397773) #15 39 points 24 comments -> [Americans Are Using PTO to Sleep, Not for Vacation–Report](https://www.newsweek.com/americans-are-using-pto-to-sleep-not-for-vacation-report-10783162)<!-- HN:45397773:end --><!-- HN:45398719:start -->
* [45398719](https://news.social-protocols.org/stats?id=45398719) #16 73 points 29 comments -> [NSPM-7 labels common beliefs as terrorism 'indicators'](https://www.kenklippenstein.com/p/trumps-nspm-7-labels-common-beliefs)<!-- HN:45398719:end --><!-- HN:45398716:start -->
* [45398716](https://news.social-protocols.org/stats?id=45398716) #17 6 points 4 comments -> [The truth behind standing desks](https://www.health.harvard.edu/blog/the-truth-behind-standing-desks-2016092310264)<!-- HN:45398716:end --><!-- HN:45362460:start -->
* [45362460](https://news.social-protocols.org/stats?id=45362460) #18 8 points 0 comments -> [Meshtastic 64: A meshtastic radio for the Commodore 64](http://64jim64.blogspot.com/2025/09/meshtastic-64-meshtastic-radio-for.html)<!-- HN:45362460:end -->
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
* [45451467](https://news.social-protocols.org/stats?id=45451467) #26 -> [DHH Is Way Worse Than I Thought](https://jakelazaroff.com/words/dhh-is-way-worse-than-i-thought/)<!-- HN:45451467:end --><!-- HN:45451971:start -->
* [45451971](https://news.social-protocols.org/stats?id=45451971) #3 28 points 21 comments -> [Y'all are over-complicating these AI-risk arguments](https://dynomight.net/ai-risk/)<!-- HN:45451971:end --><!-- HN:45455139:start -->
* [45455139](https://news.social-protocols.org/stats?id=45455139) #26 10 points 6 comments -> [USDA website blames "Radical Left Democrats" for shutdown](https://www.usda.gov/)<!-- HN:45455139:end -->