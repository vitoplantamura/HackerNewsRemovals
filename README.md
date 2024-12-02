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

#### **Tuesday, November 26, 2024**
<!-- HN:42241438:start -->
* [42241438](https://news.social-protocols.org/stats?id=42241438) #24 4 points 0 comments -> [Why Are All Tech Products Now Shit? [YouTube] [video]](https://www.youtube.com/watch?v=7Slib2bbMs4)<!-- HN:42241438:end --><!-- HN:42222773:start -->
* [42222773](https://news.social-protocols.org/stats?id=42222773) #21 -> [Apollo 68080: high performance 68k processor on FPGA](http://www.apollo-core.com/features.html)<!-- HN:42222773:end --><!-- HN:42183312:start -->
* [42183312](https://news.social-protocols.org/stats?id=42183312) #18 13 points 0 comments -> [Astra Dynamic Chunks: How We Saved by Redesigning a Key Part of Astra](https://slack.engineering/astra-dynamic-chunks-how-we-saved-by-redesigning-a-key-part-of-astra/)<!-- HN:42183312:end --><!-- HN:42163477:start -->
* [42163477](https://news.social-protocols.org/stats?id=42163477) #22 17 points 3 comments -> [Making waves through the Wallace Line](https://www.weatherzone.com.au/news/making-waves-through-the-wallace-line/1890090)<!-- HN:42163477:end --><!-- HN:42164058:start -->
* [42164058](https://news.social-protocols.org/stats?id=42164058) #27 89 points 30 comments -> [Transactional Object Storage?](https://blog.mbrt.dev/posts/transactional-object-storage/)<!-- HN:42164058:end --><!-- HN:42242825:start -->
* [42242825](https://news.social-protocols.org/stats?id=42242825) #11 -> [CEO fired 90% of his staff for missing a morning meeting](https://fortune.com/2024/11/25/ceo-fires-employees-slack-remote/)<!-- HN:42242825:end --><!-- HN:42243375:start -->
* [42243375](https://news.social-protocols.org/stats?id=42243375) #26 20 points 40 comments -> [Tesla appears to be building a teleoperations team for its robotaxi service](https://techcrunch.com/2024/11/25/tesla-appears-to-be-building-a-teleoperations-team-for-its-robotaxi-service/)<!-- HN:42243375:end --><!-- HN:42244183:start -->
* [42244183](https://news.social-protocols.org/stats?id=42244183) #14 28 points 0 comments -> [Linux 6.13 KVM Eliminates an "Awful Idea", Many x86_64 Improvements](https://www.phoronix.com/news/Linux-6.13-KVM)<!-- HN:42244183:end --><!-- HN:42213712:start -->
* [42213712](https://news.social-protocols.org/stats?id=42213712) #19 32 points 11 comments -> [New Comic Book: La BD de L'Avent, Le Lombard Publishing](https://www.davidrevoy.com/article1055/new-comic-book-la-bd-de-lavent-le-lombard-publishing)<!-- HN:42213712:end --><!-- HN:42243689:start -->
* [42243689](https://news.social-protocols.org/stats?id=42243689) #29 22 points 12 comments -> [Your docs are your infrastructure](https://stackoverflow.blog/2024/11/26/your-docs-are-your-infrastructure/)<!-- HN:42243689:end --><!-- HN:42245916:start -->
* [42245916](https://news.social-protocols.org/stats?id=42245916) #19 15 points 6 comments -> [Judge blocks Louisiana law that requires classrooms to display Ten Commandments](https://apnews.com/article/ten-commandments-law-blocked-public-schools-louisiana-87b3dde94e583fdbb9ecb26db42b0206)<!-- HN:42245916:end --><!-- HN:42246891:start -->
* [42246891](https://news.social-protocols.org/stats?id=42246891) #10 7 points 0 comments -> [Israel cracks down on Palestinian citizens who speak out against the war in Gaza](https://apnews.com/article/israel-gaza-war-palestinians-dissent-protest-849cc9250534b5bae98cea89e6f4d35e)<!-- HN:42246891:end --><!-- HN:42245400:start -->
* [42245400](https://news.social-protocols.org/stats?id=42245400) #28 28 points 40 comments -> [Medicare Pays Different Prices for the Same Drug](https://www.wsj.com/health/healthcare/medicare-pays-wildly-different-prices-for-the-same-drug-b20fa58c)<!-- HN:42245400:end --><!-- HN:42247001:start -->
* [42247001](https://news.social-protocols.org/stats?id=42247001) #8 25 points 21 comments -> [An update on Google's compliance with the DMA](https://blog.google/around-the-globe/google-europe/dma-compliance-update/)<!-- HN:42247001:end --><!-- HN:42246596:start -->
* [42246596](https://news.social-protocols.org/stats?id=42246596) #19 5 points 1 comments -> [Qodo Merge integration with Jira — ensure code complies with ticket](https://www.qodo.ai/blog/qodo-merge-jira-ensuring-code-quality-through-ticket-compliance/)<!-- HN:42246596:end --><!-- HN:42248380:start -->
* [42248380](https://news.social-protocols.org/stats?id=42248380) #12 9 points 5 comments -> [Why you should never kiss a baby on the head](https://theconversation.com/why-you-should-never-kiss-a-baby-243661)<!-- HN:42248380:end --><!-- HN:42243500:start -->
* [42243500](https://news.social-protocols.org/stats?id=42243500) #27 301 points 384 comments -> [Lies we tell ourselves to keep using Golang (2022)](https://fasterthanli.me/articles/lies-we-tell-ourselves-to-keep-using-golang)<!-- HN:42243500:end --><!-- HN:42211735:start -->
* [42211735](https://news.social-protocols.org/stats?id=42211735) #18 4 points 2 comments -> [A Guide to Server-Side Rendering](https://www.builder.io/m/explainers/server-side-rendering)<!-- HN:42211735:end --><!-- HN:42248167:start -->
* [42248167](https://news.social-protocols.org/stats?id=42248167) #9 61 points 2 comments -> [Hats Off to NASA's Webb: Sombrero Galaxy Dazzles in New Image](https://webbtelescope.org/contents/news-releases/2024/news-2024-137)<!-- HN:42248167:end -->
#### **Wednesday, November 27, 2024**<!-- HN:42252041:start -->
* [42252041](https://news.social-protocols.org/stats?id=42252041) #3 27 points 2 comments -> [Reply on Bluesky and Decentralization](https://whtwnd.com/bnewbold.net/3lbvbtqrg5t2t)<!-- HN:42252041:end --><!-- HN:42250429:start -->
* [42250429](https://news.social-protocols.org/stats?id=42250429) #22 37 points 14 comments -> [Show HN: Clean Your Mac with a Script](https://github.com/hkdobrev/cleanmac)<!-- HN:42250429:end --><!-- HN:42252904:start -->
* [42252904](https://news.social-protocols.org/stats?id=42252904) #21 4 points 0 comments -> [Why Rust and Its Memory Safety Lulls Developers into a False Sense of Security](https://www.darrenhorrocks.co.uk/why-rust-its-memory-safety-lulls-developers-into-false-sense-security/)<!-- HN:42252904:end --><!-- HN:42255043:start -->
* [42255043](https://news.social-protocols.org/stats?id=42255043) #18 5 points 1 comments -> [Raspberry Pi Compute Module 5](https://www.raspberrypi.com/products/compute-module-5/)<!-- HN:42255043:end --><!-- HN:42255092:start -->
* [42255092](https://news.social-protocols.org/stats?id=42255092) #22 9 points 1 comments -> [SpaceX rocket explosion shredded the upper atmosphere](https://www.nature.com/articles/d41586-024-02841-4)<!-- HN:42255092:end --><!-- HN:42221152:start -->
* [42221152](https://news.social-protocols.org/stats?id=42221152) #11 9 points 0 comments -> [Ancient forest world discovered 630ft down sinkhole in China](https://www.unilad.com/news/world-news/southwestern-china-sink-hole-ancient-forest-748290-20241121)<!-- HN:42221152:end --><!-- HN:42217963:start -->
* [42217963](https://news.social-protocols.org/stats?id=42217963) #25 32 points 14 comments -> [Creating a social photo frame from scratch](https://insignificantdatascience.substack.com/p/creating-a-custom-social-photo-frame)<!-- HN:42217963:end --><!-- HN:42255266:start -->
* [42255266](https://news.social-protocols.org/stats?id=42255266) #26 4 points 2 comments -> [Huffman Coding](https://en.wikipedia.org/wiki/Huffman_coding)<!-- HN:42255266:end --><!-- HN:42255559:start -->
* [42255559](https://news.social-protocols.org/stats?id=42255559) #11 17 points 11 comments -> [How to build 99.999% uptime payment systems](https://news.alvaroduran.com/p/how-to-build-99999-uptime-payment)<!-- HN:42255559:end --><!-- HN:42257124:start -->
* [42257124](https://news.social-protocols.org/stats?id=42257124) #22 11 points 0 comments -> [Probable extinction of influenza B/Yamagata and its public health implications](https://www.thelancet.com/journals/lanmic/article/PIIS2666-5247(24)00066-1/fulltext)<!-- HN:42257124:end --><!-- HN:42260401:start -->
* [42260401](https://news.social-protocols.org/stats?id=42260401) #9 5 points 1 comments -> [Factoring in the Chicken McNugget monoid (2017)](https://arxiv.org/abs/1709.01606)<!-- HN:42260401:end -->
#### **Thursday, November 28, 2024**
<!-- HN:42260998:start -->
* [42260998](https://news.social-protocols.org/stats?id=42260998) #13 9 points 8 comments -> [Database full of 1000+ validated problems that can be turned into applications](https://www.bigideasdb.com/)<!-- HN:42260998:end --><!-- HN:42259950:start -->
* [42259950](https://news.social-protocols.org/stats?id=42259950) #26 15 points 26 comments -> [The Rise of the NormieNet – Echo chamber politics](https://www.bugeyedandshameless.com/p/the-rise-of-the-normienet)<!-- HN:42259950:end --><!-- HN:42262065:start -->
* [42262065](https://news.social-protocols.org/stats?id=42262065) #13 14 points 1 comments -> [Alibaba's OpenAI Challenger: The New AI Reasoning Titan](https://app.pageon.ai/share/8146?mode=share&shareToken=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJkb2N1bWVudFNoYXJlU2lnbiI6IjEiLCJleHAiOjE3MzI4NDk0NTYsInVzZXJJZCI6MzcxNywicHJvamVjdElkIjo4MTQ2LCJ0aW1lb3V0IjoxNzMyODQ5NDU2MDAwLCJpc1JlbW92ZVdhdGVybWFyayI6MH0.bXgFzoQqQXiRNfaWhWOjrkYP79o5_OCT34RDDWbq9_Y)<!-- HN:42262065:end --><!-- HN:42262533:start -->
* [42262533](https://news.social-protocols.org/stats?id=42262533) #25 9 points 2 comments -> [Appwrite: Open-Source Back End as a Service](https://tenbyte.org/appwrite-open-source-backend-as-a-service/)<!-- HN:42262533:end --><!-- HN:42261707:start -->
* [42261707](https://news.social-protocols.org/stats?id=42261707) #18 137 points 41 comments -> [Dell is posting unsigned updates to their website which fail to install](https://infosec.exchange/@0xabad1dea/113543212666056329)<!-- HN:42261707:end --><!-- HN:42262057:start -->
* [42262057](https://news.social-protocols.org/stats?id=42262057) #18 47 points 19 comments -> [Tornado Cash Sanctions Found Illegal, in Legal Win for Crypto](https://www.wsj.com/livecoverage/stock-market-today-pce-inflation-live-11-27-2024/card/tornado-cash-sanctions-found-illegal-in-legal-win-for-crypto-dEovQ561jwj3zmyvdz0M)<!-- HN:42262057:end --><!-- HN:42253756:start -->
* [42253756](https://news.social-protocols.org/stats?id=42253756) #20 92 points 158 comments -> [Python type hints may not be not for me in practice](https://utcc.utoronto.ca/~cks/space/blog/python/TypeHintsMaybeNotForMe)<!-- HN:42253756:end --><!-- HN:42258407:start -->
* [42258407](https://news.social-protocols.org/stats?id=42258407) #17 71 points 18 comments -> [Generate video sprites using just FFmpeg](https://steelcm.com/blog/generating-video-sprites-using-ffmpeg/)<!-- HN:42258407:end --><!-- HN:42213125:start -->
* [42213125](https://news.social-protocols.org/stats?id=42213125) #21 57 points 26 comments -> [Psychoacoustic and archeoacoustic nature of ancient Aztec skull whistles](https://www.nature.com/articles/s44271-024-00157-7)<!-- HN:42213125:end --><!-- HN:42262089:start -->
* [42262089](https://news.social-protocols.org/stats?id=42262089) #25 23 points 16 comments -> [Pocket 4: Modular full-featured Handheld AI PC](https://www.indiegogo.com/projects/pocket-4-modular-full-featured-handheld-ai-pc)<!-- HN:42262089:end --><!-- HN:42261314:start -->
* [42261314](https://news.social-protocols.org/stats?id=42261314) #15 55 points 20 comments -> [RomCom exploits Firefox and Windows zero days in the wild](https://www.welivesecurity.com/en/eset-research/romcom-exploits-firefox-and-windows-zero-days-in-the-wild/)<!-- HN:42261314:end --><!-- HN:42263724:start -->
* [42263724](https://news.social-protocols.org/stats?id=42263724) #5 8 points 1 comments -> [IMBA: A Curated Self-Learning MBA Inspired by 'The Personal MBA](https://github.com/abari111/iMBA)<!-- HN:42263724:end --><!-- HN:42198072:start -->
* [42198072](https://news.social-protocols.org/stats?id=42198072) #17 6 points 0 comments -> [Why can't we separate YAML from ML?](https://www.ethanrosenthal.com/2024/11/19/yaml-ml/)<!-- HN:42198072:end --><!-- HN:42263315:start -->
* [42263315](https://news.social-protocols.org/stats?id=42263315) #26 21 points 12 comments -> [Microsoft says it's built an Xbox game store on Android but can't launch it](https://www.theverge.com/2024/11/27/24307867/microsoft-google-xbox-game-store-android-purchase-games)<!-- HN:42263315:end --><!-- HN:42263598:start -->
* [42263598](https://news.social-protocols.org/stats?id=42263598) #29 6 points 1 comments -> [Spotify cuts developer access to several of its recommendation features](https://techcrunch.com/2024/11/27/spotify-cuts-developer-access-to-several-of-its-recommendation-features/)<!-- HN:42263598:end --><!-- HN:42232496:start -->
* [42232496](https://news.social-protocols.org/stats?id=42232496) #12 4 points 0 comments -> [Best Nigerian Movies: A Journey Through Nollywood's Finest](https://arkviews.com/best-nigerian-movies-a-journey-through-nollywoods-finest)<!-- HN:42232496:end --><!-- HN:42213264:start -->
* [42213264](https://news.social-protocols.org/stats?id=42213264) #16 27 points 6 comments -> [Reliably Benchmarking Small Changes – Ankush Menat](https://ankush.dev/p/reliable-benchmarking)<!-- HN:42213264:end --><!-- HN:42265818:start -->
* [42265818](https://news.social-protocols.org/stats?id=42265818) #18 7 points 2 comments -> [Hetzner – 20 times less traffic for a higher price](https://i.postimg.cc/4dyxZWCd/hertzen.png)<!-- HN:42265818:end --><!-- HN:42265226:start -->
* [42265226](https://news.social-protocols.org/stats?id=42265226) #3 9 points 2 comments -> [How we improved GPT-4o multi-step function calling success rate by 4x](https://xpander.ai/2024/11/20/announcing-agent-graph-system/)<!-- HN:42265226:end --><!-- HN:42265667:start -->
* [42265667](https://news.social-protocols.org/stats?id=42265667) #9 20 points 43 comments -> [It is humiliating to have to do LeetCode grinding for](https://twitter.com/prajdabre1/status/1861633099781808625)<!-- HN:42265667:end --><!-- HN:42265485:start -->
* [42265485](https://news.social-protocols.org/stats?id=42265485) #26 12 points 5 comments -> [Australia to ban under-16s from social media after passing landmark law](https://www.independent.co.uk/news/world/australasia/social-media-ban-australia-law-under-16s-b2655348.html)<!-- HN:42265485:end --><!-- HN:42265051:start -->
* [42265051](https://news.social-protocols.org/stats?id=42265051) #21 10 points 11 comments -> [Qodo automatically verifies PR complies with Jira ticket or GitHub issue](https://www.qodo.ai/blog/qodo-merge-jira-ensuring-code-quality-through-ticket-compliance/)<!-- HN:42265051:end --><!-- HN:42267519:start -->
* [42267519](https://news.social-protocols.org/stats?id=42267519) #29 7 points 0 comments -> [Reddit overtakes X in popularity of social media platforms in UK](https://www.theguardian.com/technology/2024/nov/28/reddit-overtakes-x-in-popularity-of-social-media-platforms-in-uk)<!-- HN:42267519:end --><!-- HN:42260030:start -->
* [42260030](https://news.social-protocols.org/stats?id=42260030) #26 170 points 2 comments -> [Float Self-Tagging](https://arxiv.org/abs/2411.16544)<!-- HN:42260030:end -->
#### **Friday, November 29, 2024**
<!-- HN:42242784:start -->
* [42242784](https://news.social-protocols.org/stats?id=42242784) #26 7 points 6 comments -> [Every Hands-Free Driving System Available in 2024](https://www.caranddriver.com/news/a62586657/every-hands-free-driving-system-2024/)<!-- HN:42242784:end --><!-- HN:42268475:start -->
* [42268475](https://news.social-protocols.org/stats?id=42268475) #3 294 points 4 comments -> [Hetzner raises prices while significantly lowering bandwidth (US)](https://adriano.fyi/posts/hetzner-raises-prices-while-significantly-lowering-bandwidth-in-us/)<!-- HN:42268475:end --><!-- HN:42270893:start -->
* [42270893](https://news.social-protocols.org/stats?id=42270893) #7 14 points 1 comments -> [An updated record of Tesla fatalities and Tesla accident deaths](https://www.tesladeaths.com)<!-- HN:42270893:end --><!-- HN:42270965:start -->
* [42270965](https://news.social-protocols.org/stats?id=42270965) #5 9 points 2 comments -> [New report advises mental health support for 'incels'](https://www.bps.org.uk/psychologist/new-report-advises-mental-health-support-incels)<!-- HN:42270965:end --><!-- HN:42270935:start -->
* [42270935](https://news.social-protocols.org/stats?id=42270935) #20 46 points 12 comments -> [US antitrust watchdog launches broad Microsoft investigation](https://news.bloomberglaw.com/us-law-week/us-antitrust-watchdog-launches-broad-microsoft-investigation)<!-- HN:42270935:end --><!-- HN:42272813:start -->
* [42272813](https://news.social-protocols.org/stats?id=42272813) #13 16 points 3 comments -> [New Zealand Navy ship sank off Samoa because autopilot was left on, inquiry](https://www.theguardian.com/world/2024/nov/29/new-zealand-navy-ship-hmnzs-manawanui-sinking-autopilot-inquiry-ntwnfb)<!-- HN:42272813:end --><!-- HN:42272732:start -->
* [42272732](https://news.social-protocols.org/stats?id=42272732) #29 4 points 0 comments -> ['Would you survive 72 hours?' Germany&Nordics prepare citizens for possible war](https://www.theguardian.com/world/2024/nov/29/would-you-survive-72-hours-germany-and-the-nordic-countries-prepare-citizens-for-possible-war)<!-- HN:42272732:end --><!-- HN:42273650:start -->
* [42273650](https://news.social-protocols.org/stats?id=42273650) #25 7 points 1 comments -> [NGI Projects adopt Mastodon and PeerTube as main communication channels](https://ngi.eu/news/2024/11/29/ngi-projects-adopt-mastodon-and-peertube-as-main-communication-channels/)<!-- HN:42273650:end --><!-- HN:42273349:start -->
* [42273349](https://news.social-protocols.org/stats?id=42273349) #27 6 points 1 comments -> [Stowaway found after boarding flight from New York to Paris](https://www.nbcnews.com/news/us-news/stowaway-found-boarding-flight-new-york-paris-rcna182103)<!-- HN:42273349:end --><!-- HN:42275062:start -->
* [42275062](https://news.social-protocols.org/stats?id=42275062) #1 7 points 1 comments -> [What I learned solo bootstrapping 8 software products](https://dominiksobe.com/thoughts/lessons-bootstrapping-8-software-products/)<!-- HN:42275062:end --><!-- HN:42275734:start -->
* [42275734](https://news.social-protocols.org/stats?id=42275734) #7 12 points 1 comments -> [Speaking at PyTexas – CFP closes December 1, 2024](https://www.pytexas.org/2025/schedule/speaking/)<!-- HN:42275734:end --><!-- HN:42275784:start -->
* [42275784](https://news.social-protocols.org/stats?id=42275784) #5 56 points 31 comments -> [Javier Milei: "My contempt for the state is infinite"](https://www.economist.com/leaders/2024/11/28/javier-milei-my-contempt-for-the-state-is-infinite)<!-- HN:42275784:end --><!-- HN:42273780:start -->
* [42273780](https://news.social-protocols.org/stats?id=42273780) #20 114 points 6 comments -> [Alibaba releases an 'open' challenger to OpenAI's O1 reasoning model](https://techcrunch.com/2024/11/27/alibaba-releases-an-open-challenger-to-openais-o1-reasoning-model/)<!-- HN:42273780:end --><!-- HN:42277438:start -->
* [42277438](https://news.social-protocols.org/stats?id=42277438) #20 8 points 3 comments -> [Apple removes Active Noise Cancelling from AirPods Pro 2](https://discussions.apple.com/thread/255774193)<!-- HN:42277438:end -->
#### **Saturday, November 30, 2024**
<!-- HN:42277963:start -->
* [42277963](https://news.social-protocols.org/stats?id=42277963) #22 80 points 101 comments -> [The Engagement Is Better on Bluesky](https://bsky.social/about/blog/11-29-2024-engagement)<!-- HN:42277963:end --><!-- HN:42277931:start -->
* [42277931](https://news.social-protocols.org/stats?id=42277931) #11 20 points 4 comments -> [Bluesky intends their indexing to be used by third parties](https://write.as/ulrikehahn/bridging-to-bluesky-the-open-social-web-consent-and-gdpr)<!-- HN:42277931:end --><!-- HN:42276700:start -->
* [42276700](https://news.social-protocols.org/stats?id=42276700) #14 29 points 8 comments -> [Australian Online Safety Amendment (Social Media Minimum Age) Bill 2024](https://www.aph.gov.au/Parliamentary_Business/Bills_Legislation/Bills_Search_Results/Result?bId=r7284)<!-- HN:42276700:end --><!-- HN:42275919:start -->
* [42275919](https://news.social-protocols.org/stats?id=42275919) #13 105 points 58 comments -> [Simple Sabotage for the 21st Century – Specific Suggestions](https://specificsuggestions.com)<!-- HN:42275919:end --><!-- HN:42244482:start -->
* [42244482](https://news.social-protocols.org/stats?id=42244482) #14 121 points 26 comments -> [Prioritize work at the task level](https://developer.apple.com/library/archive/documentation/Performance/Conceptual/power_efficiency_guidelines_osx/PrioritizeWorkAtTheTaskLevel.html)<!-- HN:42244482:end --><!-- HN:42273966:start -->
* [42273966](https://news.social-protocols.org/stats?id=42273966) #16 70 points 19 comments -> [How We Got the Lithium-Ion Battery](https://www.construction-physics.com/p/how-we-got-the-lithium-ion-battery)<!-- HN:42273966:end --><!-- HN:42278160:start -->
* [42278160](https://news.social-protocols.org/stats?id=42278160) #19 26 points 37 comments -> [TfL abandons plans for driverless tube trains](https://www.ianvisits.co.uk/articles/tfl-abandons-plans-for-driverless-tube-trains-77435/)<!-- HN:42278160:end --><!-- HN:42244409:start -->
* [42244409](https://news.social-protocols.org/stats?id=42244409) #25 51 points 35 comments -> [Rust: Tools (early access edition)](https://bitfieldconsulting.com/books/rust-tools)<!-- HN:42244409:end --><!-- HN:42275834:start -->
* [42275834](https://news.social-protocols.org/stats?id=42275834) #15 133 points 60 comments -> [Chinese pebble-bed nuclear reactor passes "meltdown" test](https://www.ans.org/news/article-6241/china-pebblebed-reactor-passes-meltdown-test/)<!-- HN:42275834:end --><!-- HN:42278617:start -->
* [42278617](https://news.social-protocols.org/stats?id=42278617) #13 22 points 0 comments -> [Virtual Geometry in Bevy 0.15](https://jms55.github.io/posts/2024-11-14-virtual-geometry-bevy-0-15/)<!-- HN:42278617:end --><!-- HN:42276078:start -->
* [42276078](https://news.social-protocols.org/stats?id=42276078) #12 -> [Calmy Leon – The Ultimate Relaxing Music and Sound Generator](https://calmyleon.com/)<!-- HN:42276078:end --><!-- HN:42279521:start -->
* [42279521](https://news.social-protocols.org/stats?id=42279521) #15 10 points 8 comments -> ['Switches' are turning handguns into machine guns on Ontario streets](https://www.cbc.ca/lite/story/1.7389625)<!-- HN:42279521:end --><!-- HN:42280641:start -->
* [42280641](https://news.social-protocols.org/stats?id=42280641) #11 7 points 4 comments -> [Formance – The Color of Money: Towards a New Data Model for Fintech, Part II](https://www.formance.com/blog/engineering/color-of-money)<!-- HN:42280641:end --><!-- HN:42249801:start -->
* [42249801](https://news.social-protocols.org/stats?id=42249801) #8 15 points 3 comments -> [California scientists accidentally find nuclear fever dream in Arctic snow](https://www.sfgate.com/bayarea/article/california-researchers-abandoned-military-site-19944337.php)<!-- HN:42249801:end --><!-- HN:42281066:start -->
* [42281066](https://news.social-protocols.org/stats?id=42281066) #21 52 points 77 comments -> [Tesla is looking to hire a team to remotely control its 'self-driving' robotaxis](https://gizmodo.com/tesla-is-looking-to-hire-a-team-to-remotely-control-its-self-driving-robotaxis-2000530600)<!-- HN:42281066:end --><!-- HN:42280865:start -->
* [42280865](https://news.social-protocols.org/stats?id=42280865) #22 -> [Possible new ancient human species uncovered](https://www.hawaii.edu/news/2024/11/27/homo-juluensis-nature-communications/)<!-- HN:42280865:end --><!-- HN:42281470:start -->
* [42281470](https://news.social-protocols.org/stats?id=42281470) #23 8 points 0 comments -> [In C, memory management begins – The Craft of Coding](https://craftofcoding.wordpress.com/2024/11/25/in-c-memory-management-begins-immediately/)<!-- HN:42281470:end --><!-- HN:42281585:start -->
* [42281585](https://news.social-protocols.org/stats?id=42281585) #20 10 points 0 comments -> [What can we learn from the Andrew Tate data breach?](https://archive.org/details/tate_data_breach)<!-- HN:42281585:end --><!-- HN:42282020:start -->
* [42282020](https://news.social-protocols.org/stats?id=42282020) #1 5 points 4 comments -> [I made an AI specifically for teachers](https://assignly.app/)<!-- HN:42282020:end --><!-- HN:42254385:start -->
* [42254385](https://news.social-protocols.org/stats?id=42254385) #21 3 points 0 comments -> [M4 chips: Matrix processing and Power Modes](https://eclecticlight.co/2024/11/27/inside-m4-chips-matrix-processing-and-power-modes/)<!-- HN:42254385:end --><!-- HN:42282078:start -->
* [42282078](https://news.social-protocols.org/stats?id=42282078) #24 24 points 10 comments -> [Chinese researchers indicate diamonds can store data for millions of years](https://readwrite.com/chinese-researchers-indicate-diamonds-can-store-data-for-millions-of-years/)<!-- HN:42282078:end --><!-- HN:42224492:start -->
* [42224492](https://news.social-protocols.org/stats?id=42224492) #12 30 points 0 comments -> [A Reintroduction to Programming](https://www.0de5.net/explore)<!-- HN:42224492:end --><!-- HN:42283123:start -->
* [42283123](https://news.social-protocols.org/stats?id=42283123) #6 14 points 1 comments -> ['I couldn't stop watching': stories of how porn obsession takes over lives](https://www.bbc.com/news/articles/cg57r337rvzo)<!-- HN:42283123:end --><!-- HN:42283331:start -->
* [42283331](https://news.social-protocols.org/stats?id=42283331) #24 4 points 0 comments -> [Florida Man Who Spied on Verizon for China Gets 4 Years in Prison](https://gizmodo.com/florida-man-who-spied-on-verizon-for-china-gets-4-years-in-prison-2000529731)<!-- HN:42283331:end --><!-- HN:42282761:start -->
* [42282761](https://news.social-protocols.org/stats?id=42282761) #25 6 points 2 comments -> [NASA's X-59 plane is aiming for a sonic thump, not a boom](https://www.theregister.com/2024/11/30/nasa_x59_aircraft/)<!-- HN:42282761:end -->
#### **Sunday, December 1, 2024**
<!-- HN:42283949:start -->
* [42283949](https://news.social-protocols.org/stats?id=42283949) #8 -> [Bluesky Quadruples Moderation Team](https://mindmatters.ai/brief/x-competitor-bluesky-quadruples-moderation-team/)<!-- HN:42283949:end --><!-- HN:42285196:start -->
* [42285196](https://news.social-protocols.org/stats?id=42285196) #5 12 points 3 comments -> [We need data engineering benchmarks for LLMs](https://structuredlabs.substack.com/p/why-we-need-data-engineering-benchmarks)<!-- HN:42285196:end --><!-- HN:42212377:start -->
* [42212377](https://news.social-protocols.org/stats?id=42212377) #23 9 points 0 comments -> [Bodging GenServers Together](https://underjord.io/bodging-genservers-together.html)<!-- HN:42212377:end --><!-- HN:42254146:start -->
* [42254146](https://news.social-protocols.org/stats?id=42254146) #15 56 points 31 comments -> [IE7 and IE7 (2005)](https://meyerweb.com/eric/thoughts/2005/10/17/ie7-and-ie7/)<!-- HN:42254146:end --><!-- HN:42286306:start -->
* [42286306](https://news.social-protocols.org/stats?id=42286306) #26 5 points 1 comments -> [Day 1 – Advent of Code 2024](https://adventofcode.com/2024/day/1)<!-- HN:42286306:end --><!-- HN:42286133:start -->
* [42286133](https://news.social-protocols.org/stats?id=42286133) #13 90 points 83 comments -> [Education and Healthcare Suck for the Same Reasons](https://betterschooling.in/collection/education-and-healthcare-suck-here-s-how-we-can-change-that)<!-- HN:42286133:end --><!-- HN:42286035:start -->
* [42286035](https://news.social-protocols.org/stats?id=42286035) #18 53 points 19 comments -> [Canon ships its first nanoprint lithography machine, rivals ASML](https://www.datacenterdynamics.com/en/news/canon-ships-its-first-nanoprint-lithography-machine-rivals-asml/)<!-- HN:42286035:end --><!-- HN:42285467:start -->
* [42285467](https://news.social-protocols.org/stats?id=42285467) #25 41 points 7 comments -> [Office CMBS Delinquency Rate Spikes to 10.4%, Just Below Worst of GFC Meltdown](https://wolfstreet.com/2024/11/30/office-cmbs-delinquency-rate-spikes-to-10-4-just-below-worst-of-financial-crisis-cre-meltdown-fastest-2-year-spike-ever/)<!-- HN:42285467:end --><!-- HN:42287946:start -->
* [42287946](https://news.social-protocols.org/stats?id=42287946) #14 3 points 0 comments -> [ChatGPT Learned to Reason [video]](https://www.youtube.com/watch?v=PvDaPeQjxOE)<!-- HN:42287946:end --><!-- HN:42288372:start -->
* [42288372](https://news.social-protocols.org/stats?id=42288372) #3 30 points 3 comments -> [Advent of No-Code 2024](https://www.adventofnocode.io/)<!-- HN:42288372:end --><!-- HN:42288948:start -->
* [42288948](https://news.social-protocols.org/stats?id=42288948) #27 15 points 3 comments -> [America Got Mean](https://www.theatlantic.com/magazine/archive/2023/09/us-culture-moral-education-formation/674765/)<!-- HN:42288948:end --><!-- HN:42289143:start -->
* [42289143](https://news.social-protocols.org/stats?id=42289143) #5 6 points 2 comments -> [Show HN: Open-source widget to embed OpenAI Assistant on your website](https://github.com/widgetplatform/widget-oa)<!-- HN:42289143:end --><!-- HN:42288483:start -->
* [42288483](https://news.social-protocols.org/stats?id=42288483) #27 16 points 0 comments -> [Tiny Arcades [video]](https://www.youtube.com/watch?v=bVdF9ByDb6g)<!-- HN:42288483:end --><!-- HN:42290663:start -->
* [42290663](https://news.social-protocols.org/stats?id=42290663) #7 4 points 0 comments -> [Hiroshi Nagai: Japan's Sun-Drenched Americana](https://www.tokyocowboy.co/articles/uy1r8j003qdvb4ozr4qgplhd3yujyn)<!-- HN:42290663:end --><!-- HN:42290519:start -->
* [42290519](https://news.social-protocols.org/stats?id=42290519) #28 16 points 10 comments -> [Uber's Dark Descent: How Abandoning Innovation Hurt Drivers and Gouges Riders](https://viewfromthewing.com/uber-downward-spiral/)<!-- HN:42290519:end --><!-- HN:42291286:start -->
* [42291286](https://news.social-protocols.org/stats?id=42291286) #9 25 points 13 comments -> [The Imminence of the Destruction of the Space Program](https://robertvanwey.substack.com/p/the-imminence-of-the-destruction)<!-- HN:42291286:end --><!-- HN:42291365:start -->
* [42291365](https://news.social-protocols.org/stats?id=42291365) #30 6 points 1 comments -> ['Call of Duty: Modern Warfare' Rewrites the Highway of Death as a Russian Attack](https://www.newsweek.com/call-duty-modern-warfare-highway-death-russia-gulf-war-1468207)<!-- HN:42291365:end -->
#### **Monday, December 2, 2024**
<!-- HN:42292067:start -->
* [42292067](https://news.social-protocols.org/stats?id=42292067) #26 48 points 23 comments -> [Feds: Tether Has Become a Money Laundering Tool for Mexican Drug Trafficker](https://www.404media.co/tether-has-become-a-massive-money-laundering-tool-for-mexican-drug-traffickers-feds-say/)<!-- HN:42292067:end --><!-- HN:42292235:start -->
* [42292235](https://news.social-protocols.org/stats?id=42292235) #1 57 points 11 comments -> [ICP-Brasil: Mis-issued certificate](https://bugzilla.mozilla.org/show_bug.cgi?id=1934361)<!-- HN:42292235:end -->