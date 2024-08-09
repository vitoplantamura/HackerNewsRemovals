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

#### **Saturday, August 3, 2024**<!-- HN:41144106:start -->
* [41144106](https://news.social-protocols.org/stats?id=41144106) #6 10 points 2 comments -> [What are the odds, II: the Venezuelan presidential election](https://terrytao.wordpress.com/2024/08/02/what-are-the-odds-ii-the-venezuelan-presidential-election/)<!-- HN:41144106:end --><!-- HN:41144434:start -->
* [41144434](https://news.social-protocols.org/stats?id=41144434) #3 11 points 4 comments -> [Games Managers Play: Unmasking Psychological Tactics in Tech Leadership](https://praachi.work/blog/games-managers-play.html)<!-- HN:41144434:end --><!-- HN:41144108:start -->
* [41144108](https://news.social-protocols.org/stats?id=41144108) #29 26 points 2 comments -> [Stop Destroying Videogames – European Citizens' Initiative](https://eci.ec.europa.eu/045/public/#/screen/home)<!-- HN:41144108:end --><!-- HN:41144521:start -->
* [41144521](https://news.social-protocols.org/stats?id=41144521) #15 26 points 9 comments -> [US Library of Congress Digital Archive Formats](https://www.loc.gov/preservation/resources/rfs/TOC.html)<!-- HN:41144521:end --><!-- HN:41144571:start -->
* [41144571](https://news.social-protocols.org/stats?id=41144571) #29 33 points 6 comments -> [SpaceX Raptor 3, SN1](https://twitter.com/elonmusk/status/1819551225504768286/photo/1)<!-- HN:41144571:end --><!-- HN:41143452:start -->
* [41143452](https://news.social-protocols.org/stats?id=41143452) #24 77 points 40 comments -> [EWritable – e-ink tablet news and reviews](https://ewritable.com/)<!-- HN:41143452:end --><!-- HN:41145314:start -->
* [41145314](https://news.social-protocols.org/stats?id=41145314) #21 8 points 2 comments -> [Why America fell behind in drones, and how to catch up agaon](https://www.noahpinion.blog/p/why-america-fell-behind-in-drones)<!-- HN:41145314:end --><!-- HN:41145732:start -->
* [41145732](https://news.social-protocols.org/stats?id=41145732) #16 37 points 42 comments -> [Delivery worker minimum wage is bringing order to a wild industry](https://nyc.streetsblog.org/2024/07/15/delivery-worker-minimum-wage-brings-order-to-industry-data-shows)<!-- HN:41145732:end --><!-- HN:41146167:start -->
* [41146167](https://news.social-protocols.org/stats?id=41146167) #29 7 points 4 comments -> [Wi-Fi is an important threat to human health (2018)](https://www.sciencedirect.com/science/article/pii/S0013935118300355)<!-- HN:41146167:end --><!-- HN:41142921:start -->
* [41142921](https://news.social-protocols.org/stats?id=41142921) #9 8 points 6 comments -> [Reverse Captcha](https://www.selabs.tech/reverse-captcha)<!-- HN:41142921:end --><!-- HN:41147109:start -->
* [41147109](https://news.social-protocols.org/stats?id=41147109) #13 15 points 1 comments -> [Intel took billions from the CHIPS Act, and gave nothing back](https://nypost.com/2024/08/02/opinion/biden-harris-wasted-8-5-billion-in-taxpayer-money-to-lose-15000-jobs-at-intel/)<!-- HN:41147109:end --><!-- HN:41146320:start -->
* [41146320](https://news.social-protocols.org/stats?id=41146320) #23 7 points 0 comments -> [An epic environment manager to fix local environment variable management](https://github.com/danthegoodman1/EpicEnv)<!-- HN:41146320:end --><!-- HN:41147464:start -->
* [41147464](https://news.social-protocols.org/stats?id=41147464) #16 4 points 1 comments -> [Show HN: InstaCured – Instant telehealth at $19 per visit](https://instacured.com/)<!-- HN:41147464:end --><!-- HN:41146132:start -->
* [41146132](https://news.social-protocols.org/stats?id=41146132) #21 36 points 40 comments -> [The Danger of Superhuman AI Is Not What You Think](https://www.noemamag.com/the-danger-of-superhuman-ai-is-not-what-you-think/)<!-- HN:41146132:end --><!-- HN:41148961:start -->
* [41148961](https://news.social-protocols.org/stats?id=41148961) #27 5 points 1 comments -> [Why America fell behind in drones, and how to catch up again](https://www.noahpinion.blog/p/why-america-fell-behind-in-drones)<!-- HN:41148961:end --><!-- HN:41144072:start -->
* [41144072](https://news.social-protocols.org/stats?id=41144072) #19 61 points 26 comments -> [Back dating Git commits based on file modification dates](https://til.simonwillison.net/git/backdate-git-commits)<!-- HN:41144072:end --><!-- HN:41149220:start -->
* [41149220](https://news.social-protocols.org/stats?id=41149220) #19 15 points 5 comments -> [Intel is a Victim of its Own Arrogance](https://innovationnation.blog/p/intel-is-a-victim-of-its-own-arrogance)<!-- HN:41149220:end -->
#### **Sunday, August 4, 2024**
<!-- HN:41149906:start -->
* [41149906](https://news.social-protocols.org/stats?id=41149906) #11 27 points 13 comments -> [What are the odds, II: the Venezuelan presidential election](https://terrytao.wordpress.com/2024/08/02/what-are-the-odds-ii-the-venezuelan-presidential-election/)<!-- HN:41149906:end --><!-- HN:41147830:start -->
* [41147830](https://news.social-protocols.org/stats?id=41147830) #21 51 points 6 comments -> [Show HN: Plain Vanilla – a tutorial website for vanilla web development](https://plainvanillaweb.com/)<!-- HN:41147830:end --><!-- HN:41150372:start -->
* [41150372](https://news.social-protocols.org/stats?id=41150372) #28 14 points 1 comments -> [Automating away the boring parts of my job with Gemini 1.5 Pro and long context](https://medium.com/@webpaige/automating-away-the-boring-parts-of-my-job-with-gemini-1-5-pro-long-context-windows-6d5a1d9a6f38)<!-- HN:41150372:end --><!-- HN:41151687:start -->
* [41151687](https://news.social-protocols.org/stats?id=41151687) #4 4 points 0 comments -> [I made my personal website](https://www.mandar.fun/)<!-- HN:41151687:end --><!-- HN:41152040:start -->
* [41152040](https://news.social-protocols.org/stats?id=41152040) #12 27 points 20 comments -> [The Academic Culture of Fraud](https://www.palladiummag.com/2024/08/02/the-academic-culture-of-fraud/)<!-- HN:41152040:end --><!-- HN:41150278:start -->
* [41150278](https://news.social-protocols.org/stats?id=41150278) #17 133 points 83 comments -> [Nvidia reportedly delays its next AI chip due to a design flaw](https://www.theverge.com/2024/8/3/24212518/nvidia-ai-chip-delay-blackwell-b200-microsoft-amazon-google-openai-meta-artificial-intelligence)<!-- HN:41150278:end --><!-- HN:41150483:start -->
* [41150483](https://news.social-protocols.org/stats?id=41150483) #20 25 points 17 comments -> [Perfect NAS Solution](https://vermaden.wordpress.com/2024/08/04/perfect-nas-solution/)<!-- HN:41150483:end --><!-- HN:41149882:start -->
* [41149882](https://news.social-protocols.org/stats?id=41149882) #15 70 points 12 comments -> [Reverse engineering XC2064, the first FPGA  (2020)](https://www.righto.com/2020/09/reverse-engineering-first-fpga-chip.html)<!-- HN:41149882:end --><!-- HN:41149948:start -->
* [41149948](https://news.social-protocols.org/stats?id=41149948) #14 64 points 3 comments -> [Upgrading my Chumby 8 kernel part 13: the end](https://www.downtowndougbrown.com/2024/08/upgrading-my-chumby-8-kernel-part-13-the-end/)<!-- HN:41149948:end --><!-- HN:41153147:start -->
* [41153147](https://news.social-protocols.org/stats?id=41153147) #4 4 points 1 comments -> [AI Personal Assistant with RAG and LLM](https://github.com/mytechnotalent/pa)<!-- HN:41153147:end --><!-- HN:41154033:start -->
* [41154033](https://news.social-protocols.org/stats?id=41154033) #15 9 points 1 comments -> [A WA Tax Break for Data Centers Became One of Their Biggest Corporate Giveaways](https://www.propublica.org/article/washington-data-centers-tech-jobs-tax-break)<!-- HN:41154033:end --><!-- HN:41154219:start -->
* [41154219](https://news.social-protocols.org/stats?id=41154219) #7 6 points 1 comments -> [People High on Dark Triad Personality Traits Employ Distinct Defense Mechanisms](https://www.robkhenderson.com/p/people-with-dark-triad-personality)<!-- HN:41154219:end --><!-- HN:41153980:start -->
* [41153980](https://news.social-protocols.org/stats?id=41153980) #28 9 points 12 comments -> [Wasted Education: How We Fail Our Graduates in STEM [video]](https://www.youtube.com/watch?v=ZTWaSPzAgBA)<!-- HN:41153980:end --><!-- HN:41155587:start -->
* [41155587](https://news.social-protocols.org/stats?id=41155587) #22 8 points 7 comments -> [Rich, western countries face a stark choice: 6-day workweeks or more immigration](https://fortune.com/2024/08/04/rich-western-countries-face-a-stark-choice-6-day-workweeks-or-more-immigration-top-economist-warns/)<!-- HN:41155587:end -->
#### **Monday, August 5, 2024**
<!-- HN:41157140:start -->
* [41157140](https://news.social-protocols.org/stats?id=41157140) #11 5 points 0 comments -> [How would you explain a tensor to a computer scientist?](https://math.stackexchange.com/questions/4861085/how-would-you-explain-a-tensor-to-a-computer-scientist)<!-- HN:41157140:end --><!-- HN:41154560:start -->
* [41154560](https://news.social-protocols.org/stats?id=41154560) #17 194 points 66 comments -> [Praise My GitHub Profile](https://praise-me.fly.dev/)<!-- HN:41154560:end --><!-- HN:41160815:start -->
* [41160815](https://news.social-protocols.org/stats?id=41160815) #18 8 points 3 comments -> [CrowdStrike unhappy with Delta litigation threat, says airline refused free help](https://www.theregister.com/2024/08/05/crowdstrike_is_not_at_all/)<!-- HN:41160815:end --><!-- HN:41161437:start -->
* [41161437](https://news.social-protocols.org/stats?id=41161437) #8 34 points 42 comments -> [CrowdStrike to Delta: Stop pointing at us](https://www.wsj.com/business/airlines/crowdstrike-to-delta-stop-pointing-the-finger-at-us-5b2eea6c)<!-- HN:41161437:end --><!-- HN:41161736:start -->
* [41161736](https://news.social-protocols.org/stats?id=41161736) #20 15 points 2 comments -> [Build a Digital Human](https://build.nvidia.com/nvidia/digital-humans-virtual-assistant)<!-- HN:41161736:end --><!-- HN:41163304:start -->
* [41163304](https://news.social-protocols.org/stats?id=41163304) #6 7 points 1 comments -> [Why Polars destroys Pandas in all possible ways for Data Scientists](https://differ.blog/inplainenglish/why-polars-destroys-pandas-in-all-possible-ways-for-data-scientists-b9c662)<!-- HN:41163304:end --><!-- HN:41163583:start -->
* [41163583](https://news.social-protocols.org/stats?id=41163583) #29 3 points 0 comments -> [Safari can block distracting ads and other website clutter with latest beta](https://www.engadget.com/safari-can-block-distracting-ads-and-other-website-clutter-with-the-latest-ios-18-and-macos-betas-172041678.html)<!-- HN:41163583:end --><!-- HN:41161466:start -->
* [41161466](https://news.social-protocols.org/stats?id=41161466) #30 3 points 0 comments -> [Does PostgreSQL respond to the challenge of analytical queries?](https://danolivo.substack.com/p/does-postgresql-respond-to-the-challenge)<!-- HN:41161466:end --><!-- HN:41161085:start -->
* [41161085](https://news.social-protocols.org/stats?id=41161085) #28 6 points 0 comments -> [Rust-Python interoperability [hands-on course]](https://rust-exercises.com/rust-python-interop/)<!-- HN:41161085:end --><!-- HN:41163536:start -->
* [41163536](https://news.social-protocols.org/stats?id=41163536) #27 13 points 6 comments -> [Apple's new Safari feature removes distracting items from websites](https://techcrunch.com/2024/08/05/apples-new-safari-feature-removes-distracting-items-from-websites/)<!-- HN:41163536:end --><!-- HN:41163983:start -->
* [41163983](https://news.social-protocols.org/stats?id=41163983) #26 5 points 2 comments -> [Every Microsoft employee is now being judged on their security work](https://www.theverge.com/2024/8/5/24213774/microsoft-security-performance-reviews-employees-top-priority)<!-- HN:41163983:end --><!-- HN:41164234:start -->
* [41164234](https://news.social-protocols.org/stats?id=41164234) #25 9 points 1 comments -> [Google Loses DOJ Antitrust Case over Search](https://www.nytimes.com/2024/08/05/technology/google-antitrust-ruling.html)<!-- HN:41164234:end --><!-- HN:41163203:start -->
* [41163203](https://news.social-protocols.org/stats?id=41163203) #18 11 points 3 comments -> [GPU Restaking – Beyond digital currencies to physical computing resources](https://blog.bagel.net/p/gpu-restaking)<!-- HN:41163203:end --><!-- HN:41163569:start -->
* [41163569](https://news.social-protocols.org/stats?id=41163569) #28 11 points 2 comments -> [Markets tremble over risks to US economy – AP News](https://apnews.com/article/stocks-markets-nikkei-economy-c6240977e9482bf7207abc53b2a11e58)<!-- HN:41163569:end --><!-- HN:41163847:start -->
* [41163847](https://news.social-protocols.org/stats?id=41163847) #30 16 points 16 comments -> [Gen Z became so nihilistic about money](https://www.bbc.com/worklife/article/20240731-how-gen-z-became-so-nihilistic-about-money)<!-- HN:41163847:end --><!-- HN:41164747:start -->
* [41164747](https://news.social-protocols.org/stats?id=41164747) #25 5 points 0 comments -> [Google is an illegal monopoly, federal court rules](https://www.washingtonpost.com/technology/2024/08/05/doj-google-monopoly-trial-judgment/)<!-- HN:41164747:end --><!-- HN:41162789:start -->
* [41162789](https://news.social-protocols.org/stats?id=41162789) #30 18 points 0 comments -> [Smartphone use decreases trustworthiness of strangers](https://www.sciencedirect.com/science/article/pii/S0167487024000229)<!-- HN:41162789:end --><!-- HN:41164876:start -->
* [41164876](https://news.social-protocols.org/stats?id=41164876) #28 3 points 1 comments -> [Google loses antitrust case over its search dominance](https://apnews.com/article/google-antitrust-search-engine-verdict-apple-319a61f20fb11510097845a30abaefd8)<!-- HN:41164876:end --><!-- HN:41164878:start -->
* [41164878](https://news.social-protocols.org/stats?id=41164878) #29 9 points 0 comments -> [A Republican State A.G. Fights to Keep Exonerated Prisoners Behind Bars](https://www.nytimes.com/2024/08/05/us/missouri-andrew-bailey-exonerated.html)<!-- HN:41164878:end --><!-- HN:41165409:start -->
* [41165409](https://news.social-protocols.org/stats?id=41165409) #5 11 points 2 comments -> [The Anatomy of Brainwashing](https://www.science.org/doi/10.1126/science.adp1705)<!-- HN:41165409:end --><!-- HN:41165536:start -->
* [41165536](https://news.social-protocols.org/stats?id=41165536) #23 3 points 0 comments -> [Moral Implications of Being a Moderately Successful Computer Scientist and Woman](https://www.sigops.org/2024/the-moral-implications-of-being-a-moderately-successful-computer-scientist-and-a-woman/)<!-- HN:41165536:end -->
#### **Tuesday, August 6, 2024**<!-- HN:41167891:start -->
* [41167891](https://news.social-protocols.org/stats?id=41167891) #11 6 points 0 comments -> [How the Regime Captured Wikipedia](https://www.piratewires.com/p/how-the-regime-captured-wikipedia)<!-- HN:41167891:end --><!-- HN:41166844:start -->
* [41166844](https://news.social-protocols.org/stats?id=41166844) #27 39 points 55 comments -> [Why is it so hard for the U.S. to build quality transit?](https://www.fastcompany.com/91166562/us-transit-exceptionalism)<!-- HN:41166844:end --><!-- HN:41167645:start -->
* [41167645](https://news.social-protocols.org/stats?id=41167645) #10 24 points 40 comments -> [Don't use Vim for the wrong reasons](https://gist.github.com/romainl/6b952db7a6138b48657ba0fbb9d65370)<!-- HN:41167645:end --><!-- HN:41167624:start -->
* [41167624](https://news.social-protocols.org/stats?id=41167624) #17 9 points 5 comments -> [A simply utility script which allows you to analyze your Python file](https://github.com/mraza007/python-file-analyzer)<!-- HN:41167624:end --><!-- HN:41169454:start -->
* [41169454](https://news.social-protocols.org/stats?id=41169454) #3 3 points 1 comments -> [Politicisation and Vandalism in the UK's Education](https://dominiccummings.substack.com/p/how-to-help-parents-and-teachers)<!-- HN:41169454:end --><!-- HN:41169470:start -->
* [41169470](https://news.social-protocols.org/stats?id=41169470) #1 11 points 0 comments -> [Reverse Diversity](https://www.drmindle.com/reverse-diversity/)<!-- HN:41169470:end --><!-- HN:41169538:start -->
* [41169538](https://news.social-protocols.org/stats?id=41169538) #14 39 points 41 comments -> [Big Macs and the Cost of Living Crisis](https://www.abc.net.au/news/2024-08-05/cost-of-living-interest-rates-burgers/104156654)<!-- HN:41169538:end --><!-- HN:41169407:start -->
* [41169407](https://news.social-protocols.org/stats?id=41169407) #18 18 points 5 comments -> [Minds are 'not currency for social media,' says EU as TikTok kills Lite Rewards](https://thenextweb.com/news/tiktok-kills-lite-rewards-eu)<!-- HN:41169407:end --><!-- HN:41168836:start -->
* [41168836](https://news.social-protocols.org/stats?id=41168836) #25 31 points 6 comments -> [Hetzner Cloud now also in Singapore](https://www.hetzner.com/news/new-location-singapore/)<!-- HN:41168836:end --><!-- HN:41170830:start -->
* [41170830](https://news.social-protocols.org/stats?id=41170830) #1 -> [Men report more pressure and threats to share location and accounts](https://malware.news/t/men-report-more-pressure-and-threats-to-share-location-and-accounts-with-partners-research-shows/84907)<!-- HN:41170830:end --><!-- HN:41171045:start -->
* [41171045](https://news.social-protocols.org/stats?id=41171045) #24 3 points 0 comments -> [Applied Materials Denied US CHIPS Act Funding](https://www.datacenterdynamics.com/en/news/applied-materials-denied-us-chips-act-funding-report/)<!-- HN:41171045:end --><!-- HN:41170713:start -->
* [41170713](https://news.social-protocols.org/stats?id=41170713) #23 8 points 9 comments -> [Ziff Davis is buying CNET for just $100M](https://www.theverge.com/2024/8/6/24214374/cnet-zeff-davis-acquisition-digital-media-100-million)<!-- HN:41170713:end --><!-- HN:41172118:start -->
* [41172118](https://news.social-protocols.org/stats?id=41172118) #21 8 points 0 comments -> [Whistleblowers Report Tulsi Gabbard Actively Under TSA Surveillance](https://uncoverdc.com/2024/08/04/fams-whistleblowers-report-tulsi-gabbard-on-quiet-skies-list)<!-- HN:41172118:end --><!-- HN:41173564:start -->
* [41173564](https://news.social-protocols.org/stats?id=41173564) #12 26 points 9 comments -> [Former geography teacher Tim Walz is really into maps](https://minnesotareformer.com/2024/08/06/former-geography-teacher-tim-walz-is-really-into-maps/)<!-- HN:41173564:end --><!-- HN:41174862:start -->
* [41174862](https://news.social-protocols.org/stats?id=41174862) #19 5 points 3 comments -> [The Future of Open Source](https://blog.gitbutler.com/the-future-of-open-source/)<!-- HN:41174862:end --><!-- HN:41175843:start -->
* [41175843](https://news.social-protocols.org/stats?id=41175843) #23 9 points 1 comments -> [Microsoft Encourages Employee Donations](https://www.dropsitenews.com/p/microsoft-employee-match-occupied-west-bank)<!-- HN:41175843:end --><!-- HN:41127949:start -->
* [41127949](https://news.social-protocols.org/stats?id=41127949) #16 61 points 24 comments -> ['Weird and Daunting': 7k Readers Told Us How It Felt to Focus](https://www.nytimes.com/2024/08/01/upshot/experiment-focus-painting-art.html)<!-- HN:41127949:end --><!-- HN:41175666:start -->
* [41175666](https://news.social-protocols.org/stats?id=41175666) #10 17 points 9 comments -> [Drake Releases 100gb Data Dump](https://100gigs.org/)<!-- HN:41175666:end --><!-- HN:41173486:start -->
* [41173486](https://news.social-protocols.org/stats?id=41173486) #23 388 points 113 comments -> [Parody site ClownStrike refused to bow to CrowdStrike's bogus DMCA takedown](https://arstechnica.com/tech-policy/2024/08/parody-site-clownstrike-refused-to-bow-to-crowdstrikes-bogus-dmca-takedown/)<!-- HN:41173486:end -->
#### **Wednesday, August 7, 2024**
<!-- HN:41174559:start -->
* [41174559](https://news.social-protocols.org/stats?id=41174559) #16 65 points 43 comments -> [AI agents but they're working in big tech](https://alexsima.substack.com/p/ai-multi-agents-with-corporate-structures)<!-- HN:41174559:end --><!-- HN:41176466:start -->
* [41176466](https://news.social-protocols.org/stats?id=41176466) #14 23 points 14 comments -> [Why is 'Left Stick to Sprint' so unpleasant in games?](https://aria.dog/barks/why-is-left-stick-to-sprint-so-unpleasant/)<!-- HN:41176466:end --><!-- HN:41172411:start -->
* [41172411](https://news.social-protocols.org/stats?id=41172411) #30 72 points 3 comments -> [Hetzner Cloud – Singapore location available](https://docs.hetzner.cloud/whats-new#2024-08-06-hetzner-goes-singapore---new-location-available-)<!-- HN:41172411:end --><!-- HN:41177701:start -->
* [41177701](https://news.social-protocols.org/stats?id=41177701) #4 10 points 6 comments -> [LangChain vs. LlamaIndex](https://myscale.com/blog/llamaindex-vs-langchain-detailed-comparison/)<!-- HN:41177701:end --><!-- HN:41178092:start -->
* [41178092](https://news.social-protocols.org/stats?id=41178092) #8 18 points 2 comments -> [Gangs in the Los Angeles County Sheriff's Department](https://en.wikipedia.org/wiki/Gangs_in_the_Los_Angeles_County_Sheriff%27s_Department)<!-- HN:41178092:end --><!-- HN:41177161:start -->
* [41177161](https://news.social-protocols.org/stats?id=41177161) #16 96 points 43 comments -> [Jeremy Rowley resigns from DigiCert due to mass-revocation incident](https://bugzilla.mozilla.org/show_bug.cgi?id=1910322)<!-- HN:41177161:end --><!-- HN:41179349:start -->
* [41179349](https://news.social-protocols.org/stats?id=41179349) #2 10 points 5 comments -> [Bitcoin Investors Buy Puts Aggressively](https://en.bitcoinhaber.net/bitcoin-investors-buy-puts-aggressively)<!-- HN:41179349:end --><!-- HN:41181045:start -->
* [41181045](https://news.social-protocols.org/stats?id=41181045) #20 5 points 0 comments -> [uBlock Origin could soon stop working in Chrome](https://www.theregister.com/2024/08/06/chrome_web_store_warns_end/)<!-- HN:41181045:end --><!-- HN:41178258:start -->
* [41178258](https://news.social-protocols.org/stats?id=41178258) #20 193 points 82 comments -> [70% of new NPM packages in last 6 months were spam](https://blog.phylum.io/the-great-npm-garbage-patch/)<!-- HN:41178258:end --><!-- HN:41179446:start -->
* [41179446](https://news.social-protocols.org/stats?id=41179446) #22 19 points 6 comments -> [Sourcetrail: Free and Open-Source Interactive Source Explorer](https://github.com/CoatiSoftware/Sourcetrail)<!-- HN:41179446:end --><!-- HN:41180154:start -->
* [41180154](https://news.social-protocols.org/stats?id=41180154) #26 19 points 4 comments -> [Massachusetts 'Reviewing' Kei Car Ban After Uproar over Canceled Registrations](https://www.thedrive.com/news/massachusetts-reviewing-kei-car-ban-after-uproar-over-canceled-registrations)<!-- HN:41180154:end --><!-- HN:41180873:start -->
* [41180873](https://news.social-protocols.org/stats?id=41180873) #28 6 points 0 comments -> [Social media has created a 'perfect storm' for UK's far-right riots](https://www.theguardian.com/media/article/2024/aug/03/a-polarisation-engine-how-social-media-has-created-a-perfect-storm-for-uks-far-right-riots)<!-- HN:41180873:end --><!-- HN:41181243:start -->
* [41181243](https://news.social-protocols.org/stats?id=41181243) #23 5 points 0 comments -> ["Mastodon for Harris" Is a Success Story for Fediverse Activism](https://wedistribute.org/2024/08/mastodon-for-harris/)<!-- HN:41181243:end --><!-- HN:41180932:start -->
* [41180932](https://news.social-protocols.org/stats?id=41180932) #29 5 points 1 comments -> [What's Up Python? Setuptools Breaks, a Better PDB, CPython on CalVer](https://www.bitecode.dev/p/whats-up-python-setuptools-breaks)<!-- HN:41180932:end --><!-- HN:41182963:start -->
* [41182963](https://news.social-protocols.org/stats?id=41182963) #17 10 points 3 comments -> [Green Tech Startup with No Climate Experience Secured Millions in Gov Contracts](https://www.propublica.org/article/nevada-nzero-carbon-emissions-tracking-project)<!-- HN:41182963:end --><!-- HN:41183119:start -->
* [41183119](https://news.social-protocols.org/stats?id=41183119) #16 9 points 0 comments -> [Humanity is failing one of its greatest moral tests](https://www.vox.com/future-perfect/363550/factory-farming-human-progress-sustainable-food-movement)<!-- HN:41183119:end --><!-- HN:41183048:start -->
* [41183048](https://news.social-protocols.org/stats?id=41183048) #21 12 points 1 comments -> [MacBook app generated $100k in seven days, now Stripe won't pay up](https://www.imore.com/apps/mac-apps/this-macbook-app-generated-dollar100000-in-seven-days-now-stripe-wont-pay-up)<!-- HN:41183048:end --><!-- HN:41183731:start -->
* [41183731](https://news.social-protocols.org/stats?id=41183731) #8 4 points 0 comments -> [System Design Scale](https://betterengineers.substack.com/p/system-design-scale-0-to-millions)<!-- HN:41183731:end --><!-- HN:41182986:start -->
* [41182986](https://news.social-protocols.org/stats?id=41182986) #21 5 points 0 comments -> [Dragoneer, owner of Fur Affinity, has passed away](https://www.resetera.com/threads/dragoneer-owner-of-fur-affinity-has-passed-away.946506/)<!-- HN:41182986:end --><!-- HN:41184307:start -->
* [41184307](https://news.social-protocols.org/stats?id=41184307) #8 43 points 33 comments -> [Türkiye Bans Roblox](https://www.turkiyetoday.com/turkiye/4-reasons-why-turkiye-banned-roblox-37404/)<!-- HN:41184307:end --><!-- HN:41185052:start -->
* [41185052](https://news.social-protocols.org/stats?id=41185052) #26 14 points 0 comments -> [macOS 15 Sequoia makes you jump through more hoops to disable Gatekeeper](https://arstechnica.com/gadgets/2024/08/macos-15-sequoia-makes-you-jump-through-more-hoops-to-disable-gatekeeper-app-checks/)<!-- HN:41185052:end --><!-- HN:41181057:start -->
* [41181057](https://news.social-protocols.org/stats?id=41181057) #23 29 points 5 comments -> [Basic ReAct webapp using FastHTML and LangGraph](https://github.com/jank/curiosity)<!-- HN:41181057:end --><!-- HN:41185930:start -->
* [41185930](https://news.social-protocols.org/stats?id=41185930) #24 40 points 41 comments -> [The Well-Off People Who Can't Spend Money](https://www.theatlantic.com/ideas/archive/2024/08/spending-money-finance-anxiety-tightwads/679373/)<!-- HN:41185930:end -->
#### **Thursday, August 8, 2024**<!-- HN:41186212:start -->
* [41186212](https://news.social-protocols.org/stats?id=41186212) #27 20 points 40 comments -> [Terraforming Mars may be easier than scientists thought](https://www.science.org/content/article/terraforming-mars-could-be-easier-scientists-thought)<!-- HN:41186212:end --><!-- HN:41187445:start -->
* [41187445](https://news.social-protocols.org/stats?id=41187445) #28 10 points 0 comments -> [Holodomor](https://en.wikipedia.org/wiki/Holodomor)<!-- HN:41187445:end --><!-- HN:41144685:start -->
* [41144685](https://news.social-protocols.org/stats?id=41144685) #17 97 points 9 comments -> [R5N - Obfuscated mesh routing on hostile networks.](https://lsd.gnunet.org/lsd0004/draft-schanzen-r5n.html)<!-- HN:41144685:end --><!-- HN:41145204:start -->
* [41145204](https://news.social-protocols.org/stats?id=41145204) #17 16 points 4 comments -> [Ancient Stars (and a Thought on SETI)](https://www.centauri-dreams.org/2024/08/02/on-ancient-stars-and-a-thought-on-seti/)<!-- HN:41145204:end --><!-- HN:41188292:start -->
* [41188292](https://news.social-protocols.org/stats?id=41188292) #3 44 points 8 comments -> [ISS astronauts on eight-day mission may be stuck until 2025, NASA says](https://www.theguardian.com/science/article/2024/aug/07/spacex-delay-international-space-station-boeing-nasa)<!-- HN:41188292:end --><!-- HN:41189494:start -->
* [41189494](https://news.social-protocols.org/stats?id=41189494) #27 6 points 2 comments -> [Open Source AWS SDK Code Examples: Your Go-To Resource for Cloud Development](https://github.com/awsdocs/aws-doc-sdk-examples)<!-- HN:41189494:end --><!-- HN:41189946:start -->
* [41189946](https://news.social-protocols.org/stats?id=41189946) #23 141 points 162 comments -> [The News Is Information Junk Food (2022)](https://chuck.is/news/)<!-- HN:41189946:end --><!-- HN:41189138:start -->
* [41189138](https://news.social-protocols.org/stats?id=41189138) #26 19 points 7 comments -> [Fallout 2 Remake 3D](https://jonasz-o.itch.io/fallout2remake3d)<!-- HN:41189138:end --><!-- HN:41191689:start -->
* [41191689](https://news.social-protocols.org/stats?id=41191689) #24 7 points 0 comments -> [CrowdStrike releases root cause analysis of the global Microsoft breakdown](https://www.abc.net.au/news/2024-08-07/drt-crowdstrike-root-cause-analysis/104193866)<!-- HN:41191689:end --><!-- HN:41191818:start -->
* [41191818](https://news.social-protocols.org/stats?id=41191818) #21 8 points 1 comments -> [Google and Meta ignored their own rules in secret teen-targeting ad deals](https://arstechnica.com/tech-policy/2024/08/google-and-meta-ignored-their-own-rules-in-secret-teen-targeting-ad-deals/)<!-- HN:41191818:end --><!-- HN:41192744:start -->
* [41192744](https://news.social-protocols.org/stats?id=41192744) #25 12 points 1 comments -> [Journalist Charged with a Hate Crime for Recording a Gaza Protest Action](https://theintercept.com/2024/08/08/journalist-hate-crime-gaza-protest/)<!-- HN:41192744:end --><!-- HN:41193507:start -->
* [41193507](https://news.social-protocols.org/stats?id=41193507) #7 4 points 1 comments -> [Dairy Queen's Soft Serve Isn't What You Think It Is](https://www.thetakeout.com/1630132/dairy-queen-not-ice-cream/)<!-- HN:41193507:end --><!-- HN:41193859:start -->
* [41193859](https://news.social-protocols.org/stats?id=41193859) #8 21 points 9 comments -> [GPT-4o System Card](https://openai.com/index/gpt-4o-system-card/)<!-- HN:41193859:end --><!-- HN:41195375:start -->
* [41195375](https://news.social-protocols.org/stats?id=41195375) #7 14 points 19 comments -> [New doctoral thesis proposes Buckminster Fuller was a 'charlatan'](https://research.aalto.fi/en/publications/genius-or-charlatanry-a-psychobiographical-reinterpretation-of-th)<!-- HN:41195375:end --><!-- HN:41195823:start -->
* [41195823](https://news.social-protocols.org/stats?id=41195823) #7 5 points 0 comments -> [Isometric Projection in Game Development](https://pikuma.com/blog/isometric-projection-in-games)<!-- HN:41195823:end --><!-- HN:41196669:start -->
* [41196669](https://news.social-protocols.org/stats?id=41196669) #27 4 points 3 comments -> [The Outrageous Rise of Neotoddlerism](https://www.gurwinder.blog/p/the-outrageous-rise-of-neotoddlerism)<!-- HN:41196669:end -->
#### **Friday, August 9, 2024**
<!-- HN:41150451:start -->
* [41150451](https://news.social-protocols.org/stats?id=41150451) #19 36 points 42 comments -> ["Grip Car"](https://teenage.engineering/products/grip-car)<!-- HN:41150451:end --><!-- HN:41146766:start -->
* [41146766](https://news.social-protocols.org/stats?id=41146766) #5 26 points 3 comments -> [Rise of the New York Tech Scene](https://newsletter.rhizomerd.com/p/rise-of-the-new-york-tech-scene)<!-- HN:41146766:end --><!-- HN:41147452:start -->
* [41147452](https://news.social-protocols.org/stats?id=41147452) #13 34 points 13 comments -> [Harmonic Function Theory](https://www.axler.net/HFT.html)<!-- HN:41147452:end --><!-- HN:41199006:start -->
* [41199006](https://news.social-protocols.org/stats?id=41199006) #2 11 points 9 comments -> [AI Pastor: Your Guide to Spiritual Growth](https://ai-pastor.com)<!-- HN:41199006:end --><!-- HN:41199363:start -->
* [41199363](https://news.social-protocols.org/stats?id=41199363) #8 4 points 1 comments -> [A powerful tool for converting speech into text](https://app.trintai.com/)<!-- HN:41199363:end --><!-- HN:41199109:start -->
* [41199109](https://news.social-protocols.org/stats?id=41199109) #11 21 points 19 comments -> [I built a second brain tool for college students](https://ainotebook.app/)<!-- HN:41199109:end -->