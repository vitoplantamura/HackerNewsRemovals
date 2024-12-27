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

#### **Saturday, December 21, 2024**<!-- HN:42449481:start -->
* [42449481](https://news.social-protocols.org/stats?id=42449481) #22 25 points 11 comments -> [NoDB: Processing Payments Without a Database](https://news.alvaroduran.com/p/nodb-processing-payments-without)<!-- HN:42449481:end --><!-- HN:42439532:start -->
* [42439532](https://news.social-protocols.org/stats?id=42439532) #13 21 points 1 comments -> [The Focusing Illusion](https://www.optimallyirrational.com/p/the-focusing-illusion)<!-- HN:42439532:end --><!-- HN:42477685:start -->
* [42477685](https://news.social-protocols.org/stats?id=42477685) #21 13 points 5 comments -> [Show HN:Free Online Tool to Experience Microsoft's MarkItdown](https://markitdown.pro)<!-- HN:42477685:end --><!-- HN:42456397:start -->
* [42456397](https://news.social-protocols.org/stats?id=42456397) #7 24 points 40 comments -> [We don't know how many birds die in structural collisions](https://robertvanwey.substack.com/p/evaluating-avian-deaths-by-collision)<!-- HN:42456397:end --><!-- HN:42480176:start -->
* [42480176](https://news.social-protocols.org/stats?id=42480176) #12 20 points 42 comments -> [The NBA's Problem Is Economics, Not Basketball](https://www.bloomberg.com/opinion/articles/2024-12-18/nba-cup-the-league-s-problem-is-economics-not-basketball)<!-- HN:42480176:end --><!-- HN:42480617:start -->
* [42480617](https://news.social-protocols.org/stats?id=42480617) #18 6 points 0 comments -> [Elderly activist to spend Christmas in prison because tag does not fit](https://www.theguardian.com/society/2024/dec/21/elderly-activist-to-spend-christmas-in-prison-because-tag-does-not-fit)<!-- HN:42480617:end --><!-- HN:42456134:start -->
* [42456134](https://news.social-protocols.org/stats?id=42456134) #9 18 points 4 comments -> [After twelve years of writing about Bitcoin, here's how my thinking has changed](http://jpkoning.blogspot.com/2024/12/after-twelve-years-of-writing-about.html)<!-- HN:42456134:end --><!-- HN:42443456:start -->
* [42443456](https://news.social-protocols.org/stats?id=42443456) #6 21 points 40 comments -> [Save Daylight Savings Time](https://www.natesilver.net/p/save-daylight-savings-time)<!-- HN:42443456:end --><!-- HN:42439654:start -->
* [42439654](https://news.social-protocols.org/stats?id=42439654) #26 30 points 40 comments -> [Fixing C Strings](https://thasso.xyz/2024/12/16/fixing-c-strings.html)<!-- HN:42439654:end -->
#### **Sunday, December 22, 2024**<!-- HN:42484398:start -->
* [42484398](https://news.social-protocols.org/stats?id=42484398) #1 7 points 0 comments -> [The BBC's Civil War over Gaza](https://www.dropsitenews.com/p/bbc-civil-war-gaza-israel-biased-coverage)<!-- HN:42484398:end --><!-- HN:42484681:start -->
* [42484681](https://news.social-protocols.org/stats?id=42484681) #26 7 points 0 comments -> [Palestine Was the Deadliest Place for Journalists in 2024](https://rsf.org/en/rsf-s-2024-round-journalism-suffers-exorbitant-human-cost-due-conflicts-and-repressive-regimes)<!-- HN:42484681:end --><!-- HN:42484513:start -->
* [42484513](https://news.social-protocols.org/stats?id=42484513) #2 -> [The Most Scathing Book Reviews of 2024](https://lithub.com/the-most-scathing-book-reviews-of-2024/)<!-- HN:42484513:end --><!-- HN:42457295:start -->
* [42457295](https://news.social-protocols.org/stats?id=42457295) #23 19 points 3 comments -> [Towards a new kind of science and technology](https://scottlocklin.wordpress.com/2024/12/18/towards-a-new-kind-of-science-and-technology/)<!-- HN:42457295:end --><!-- HN:42485043:start -->
* [42485043](https://news.social-protocols.org/stats?id=42485043) #15 16 points 21 comments -> [US shoots down two of its own Navy pilots over Red Sea](https://www.theguardian.com/us-news/2024/dec/22/us-shoots-down-two-of-its-own-navy-pilots-over-red-sea-in-apparent-friendly-fire-incident)<!-- HN:42485043:end --><!-- HN:42485080:start -->
* [42485080](https://news.social-protocols.org/stats?id=42485080) #5 8 points 2 comments -> [The highest funded plagiarist has become a Professor](https://tinimini2.wordpress.com/2024/12/22/plagiarism-can-lead-to-professorship/)<!-- HN:42485080:end --><!-- HN:42486070:start -->
* [42486070](https://news.social-protocols.org/stats?id=42486070) #16 19 points 8 comments -> [Behind Germany's Political Turmoil, a Stagnating Economy](https://www.nytimes.com/2024/12/17/world/europe/germany-government-collapse-economy.html)<!-- HN:42486070:end --><!-- HN:42487241:start -->
* [42487241](https://news.social-protocols.org/stats?id=42487241) #1 18 points 3 comments -> [How much does The Cloud really cost?](https://baremetalsavings.com/)<!-- HN:42487241:end --><!-- HN:42487362:start -->
* [42487362](https://news.social-protocols.org/stats?id=42487362) #14 3 points 0 comments -> [Having Your Tonsils Out as a Child May Have a Drastic Impact on Your Life](https://www.sciencealert.com/having-your-tonsils-out-as-a-child-may-have-a-drastic-impact-on-your-life)<!-- HN:42487362:end --><!-- HN:42486831:start -->
* [42486831](https://news.social-protocols.org/stats?id=42486831) #6 22 points 2 comments -> [Database Release and End-to-End Testing: ClickHouse Database Cloning](https://qingant.notion.site/Database-Release-and-End-to-End-Testing-Bringing-Modern-Software-Development-Best-Practices-to-the--54b34a0736024e97a6b5db819b4708dd)<!-- HN:42486831:end -->
#### **Monday, December 23, 2024**
<!-- HN:42489944:start -->
* [42489944](https://news.social-protocols.org/stats?id=42489944) #3 23 points 8 comments -> [Nostr is public key microblogging that works](https://github.com/nostr-protocol/nips/blob/master/01.md)<!-- HN:42489944:end --><!-- HN:42477226:start -->
* [42477226](https://news.social-protocols.org/stats?id=42477226) #22 6 points 0 comments -> [Piezoelectric Generators](https://www.americanpiezo.com/knowledge-center/piezo-theory/generators/)<!-- HN:42477226:end --><!-- HN:42493868:start -->
* [42493868](https://news.social-protocols.org/stats?id=42493868) #20 6 points 1 comments -> [Palantir and Anduril join forces with tech groups to bid for Pentagon contracts](https://www.ft.com/content/6cfdfe2b-6872-4963-bde8-dc6c43be5093)<!-- HN:42493868:end --><!-- HN:42493664:start -->
* [42493664](https://news.social-protocols.org/stats?id=42493664) #20 28 points 41 comments -> [Coke, PepsiCo Lobby to Keep Sugary Sodas in Food-Stamp Program](https://www.wsj.com/politics/policy/rfk-jr-soda-snap-food-stamps-coke-pepsi-9bd9a872)<!-- HN:42493664:end --><!-- HN:42494809:start -->
* [42494809](https://news.social-protocols.org/stats?id=42494809) #22 28 points 20 comments -> [Good cities can't exist without public order](https://www.noahpinion.blog/p/good-cities-cant-exist-without-public)<!-- HN:42494809:end -->
#### **Tuesday, December 24, 2024**
<!-- HN:42500482:start -->
* [42500482](https://news.social-protocols.org/stats?id=42500482) #16 187 points 88 comments -> [Intel shareholders file case asking ex CEO, CFO to return 3 years of salary](https://www.cfodive.com/news/intel-shareholders-yank-exceo-cfo-compensation-foundry/736193/)<!-- HN:42500482:end --><!-- HN:42494746:start -->
* [42494746](https://news.social-protocols.org/stats?id=42494746) #21 401 points 298 comments -> [Commercial tea bags release microplastics, entering human cells](https://medicalxpress.com/news/2024-12-commercial-tea-bags-millions-microplastics.html)<!-- HN:42494746:end --><!-- HN:42495077:start -->
* [42495077](https://news.social-protocols.org/stats?id=42495077) #23 250 points 36 comments -> [Fogus: Things and Stuff of 2024](https://blog.fogus.me/2024/12/23/the-best-things-and-stuff-of-2024/)<!-- HN:42495077:end --><!-- HN:42502210:start -->
* [42502210](https://news.social-protocols.org/stats?id=42502210) #18 5 points 1 comments -> [7-year-old boy undergoes heart surgery after getting hit by falling drone](https://www.cbsnews.com/news/florida-holiday-show-drone-collision-orlando/)<!-- HN:42502210:end --><!-- HN:42502915:start -->
* [42502915](https://news.social-protocols.org/stats?id=42502915) #3 4 points 0 comments -> [Charlie Munger's wisdom lives on in LLMs](https://bren.blog/charlie-munger-lives-on-in-llms)<!-- HN:42502915:end --><!-- HN:42502768:start -->
* [42502768](https://news.social-protocols.org/stats?id=42502768) #26 5 points 0 comments -> [Return to NSA's Menwith Hill with 60 Minutes (2000)](https://cryptome.org/menwith-mn60.htm)<!-- HN:42502768:end --><!-- HN:42484790:start -->
* [42484790](https://news.social-protocols.org/stats?id=42484790) #17 22 points 23 comments -> [Communal Luxury: The Public Bathhouse](https://solar.lowtechmagazine.com/2024/09/communal-luxury-the-public-bathhouse/)<!-- HN:42484790:end --><!-- HN:42503558:start -->
* [42503558](https://news.social-protocols.org/stats?id=42503558) #15 22 points 24 comments -> [Apple seeks to defend Google's billion-dollar payments in search case](https://www.reuters.com/technology/apple-seeks-defend-googles-billion-dollar-payments-search-case-2024-12-24/)<!-- HN:42503558:end --><!-- HN:42503332:start -->
* [42503332](https://news.social-protocols.org/stats?id=42503332) #2 30 points 1 comments -> [I sensed anxiety and frustration at NeurIPS'24](https://kyunghyuncho.me/i-sensed-anxiety-and-frustration-at-neurips24/)<!-- HN:42503332:end --><!-- HN:42504250:start -->
* [42504250](https://news.social-protocols.org/stats?id=42504250) #9 9 points 1 comments -> [Nobody goes to New York City anymore. It's too crowded](https://www.natesilver.net/p/nobody-goes-to-new-york-city-anymore)<!-- HN:42504250:end --><!-- HN:42485688:start -->
* [42485688](https://news.social-protocols.org/stats?id=42485688) #11 10 points 1 comments -> [Suprnova's Founder Speaks: 20 Years, Many Lessons, and a YouTube Empire](https://torrentfreak.com/suprnovas-founder-speaks-20-years-many-lessons-and-a-youtube-empire-241219/)<!-- HN:42485688:end -->
#### **Wednesday, December 25, 2024**
<!-- HN:42506478:start -->
* [42506478](https://news.social-protocols.org/stats?id=42506478) #21 14 points 1 comments -> [Solar, EVs and a Big Exit from Coal: 2024's Good Climate News](https://www.bloomberg.com/news/articles/2024-12-24/solar-evs-and-a-big-exit-from-coal-2024-s-good-climate-news)<!-- HN:42506478:end --><!-- HN:42506882:start -->
* [42506882](https://news.social-protocols.org/stats?id=42506882) #8 3 points 2 comments -> [Destroy AI](https://ali-alkhatib.com/blog/fuck-up-ai)<!-- HN:42506882:end --><!-- HN:42489600:start -->
* [42489600](https://news.social-protocols.org/stats?id=42489600) #10 57 points 10 comments -> [What Happened to the Largest Tube TV? [video]](https://www.youtube.com/watch?v=JfZxOuc9Qwk)<!-- HN:42489600:end --><!-- HN:42505475:start -->
* [42505475](https://news.social-protocols.org/stats?id=42505475) #23 70 points 36 comments -> [Jujutsu Megamerges and jj Absorb](https://v5.chriskrycho.com/journal/jujutsu-megamerges-and-jj-absorb/)<!-- HN:42505475:end -->
#### **Thursday, December 26, 2024**
<!-- HN:42513907:start -->
* [42513907](https://news.social-protocols.org/stats?id=42513907) #28 34 points 22 comments -> [The Rise of Post-Literate History](https://www.compactmag.com/article/the-rise-of-post-literate-history/)<!-- HN:42513907:end --><!-- HN:42515052:start -->
* [42515052](https://news.social-protocols.org/stats?id=42515052) #16 4 points 1 comments -> [The Dome Paradox: A Loophole in Newton's Laws](https://www.youtube.com/watch?v=EjZB81jCGj4)<!-- HN:42515052:end --><!-- HN:42515871:start -->
* [42515871](https://news.social-protocols.org/stats?id=42515871) #2 33 points 24 comments -> [ChatGPT Saved Chats: Save and organize your important conversations in ChatGPT](https://chromewebstore.google.com/detail/chatgpt-saved-chats/aonhnhcglgpnpopfghdplgcdkhchkkcg)<!-- HN:42515871:end --><!-- HN:42516874:start -->
* [42516874](https://news.social-protocols.org/stats?id=42516874) #8 18 points 1 comments -> [Tokyo makes 3D data available](https://info.tokyo-digitaltwin.metro.tokyo.lg.jp/3dmodel/)<!-- HN:42516874:end -->
#### **Friday, December 27, 2024**
<!-- HN:42519202:start -->
* [42519202](https://news.social-protocols.org/stats?id=42519202) #27 8 points 6 comments -> [OpenAI is Lehman Brothers: A crash is coming](https://sherwood.news/tech/open-ai-is-lehman-brothers/)<!-- HN:42519202:end --><!-- HN:42519913:start -->
* [42519913](https://news.social-protocols.org/stats?id=42519913) #5 5 points 0 comments -> [Blazed – Rust-based 3D renderer](https://github.com/splurf/blazed-demo)<!-- HN:42519913:end --><!-- HN:42521914:start -->
* [42521914](https://news.social-protocols.org/stats?id=42521914) #2 61 points 18 comments -> [Denmark Offers to Buy USA (2019)](https://www.newyorker.com/humor/borowitz-report/denmark-offers-to-buy-us)<!-- HN:42521914:end --><!-- HN:42521782:start -->
* [42521782](https://news.social-protocols.org/stats?id=42521782) #18 7 points 2 comments -> [From Pen and Paper to an AI Factory: McLaren's F1 Reinvention](https://www.mclaren.com/racing/partners/dell-technologies/how-ai-is-revolutionising-f1-presented-by-dell-technologies/)<!-- HN:42521782:end -->