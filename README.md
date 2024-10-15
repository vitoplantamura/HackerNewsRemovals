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

#### **Wednesday, October 9, 2024**
<!-- HN:41783609:start -->
* [41783609](https://news.social-protocols.org/stats?id=41783609) #20 10 points 8 comments -> [Bitcoin creator is Peter Todd, HBO film says](https://www.politico.eu/article/peter-todd-bitcoin-creator-cullen-hoback-hbo-cryptocurrency-satoshi-nakamoto/)<!-- HN:41783609:end --><!-- HN:41783787:start -->
* [41783787](https://news.social-protocols.org/stats?id=41783787) #2 98 points 65 comments -> [The human internet is dying. AI images are taking over Google top results](https://old.reddit.com/r/ChatGPT/comments/1fye6tb/the_human_internet_is_dying_ai_images_taking_over/)<!-- HN:41783787:end --><!-- HN:41784138:start -->
* [41784138](https://news.social-protocols.org/stats?id=41784138) #7 7 points 4 comments -> [DOJ's proposals risk hurting consumers, businesses, and developers](https://blog.google/outreach-initiatives/public-policy/doj-search-remedies-framework/)<!-- HN:41784138:end --><!-- HN:41784332:start -->
* [41784332](https://news.social-protocols.org/stats?id=41784332) #20 4 points 0 comments -> [Seeed Studio XIAO RP2040 with NuttX(RTOS)](https://wiki.seeedstudio.com/xiao-rp2040-with-nuttx/)<!-- HN:41784332:end --><!-- HN:41787177:start -->
* [41787177](https://news.social-protocols.org/stats?id=41787177) #18 5 points 0 comments -> [Know their names – Palestinian families killed in Israeli attacks on Gaza](https://www.aljazeera.com/news/longform/2024/10/8/know-their-names-palestinian-families-killed-in-israeli-attacks-on-gaza)<!-- HN:41787177:end --><!-- HN:41786012:start -->
* [41786012](https://news.social-protocols.org/stats?id=41786012) #22 95 points 73 comments -> [A free and open internet shouldn't come at the expense of privacy](https://blog.mozilla.org/en/mozilla/digital-advertising-privacy/)<!-- HN:41786012:end --><!-- HN:41784668:start -->
* [41784668](https://news.social-protocols.org/stats?id=41784668) #29 90 points 78 comments -> [Why the ISO format has to die](https://easyos.org/about/why-the-iso-format-has-to-die.html)<!-- HN:41784668:end --><!-- HN:41759175:start -->
* [41759175](https://news.social-protocols.org/stats?id=41759175) #19 4 points 0 comments -> [HN in Your Language with Real-Time Generated Highlights](https://zeli.app)<!-- HN:41759175:end --><!-- HN:41787804:start -->
* [41787804](https://news.social-protocols.org/stats?id=41787804) #6 4 points 1 comments -> [Chris.lu: How I Used Next.js and MDX to create a modern, static-first Blog](https://chris.lu)<!-- HN:41787804:end --><!-- HN:41786457:start -->
* [41786457](https://news.social-protocols.org/stats?id=41786457) #16 8 points 5 comments -> [Startup Guru Steve Blank Says AI Changes Everything](https://spectrum.ieee.org/steve-blank)<!-- HN:41786457:end --><!-- HN:41787290:start -->
* [41787290](https://news.social-protocols.org/stats?id=41787290) #11 61 points 53 comments -> [Google threatened with being broken up by US](https://www.bbc.com/news/articles/c62504lv00do)<!-- HN:41787290:end --><!-- HN:41763190:start -->
* [41763190](https://news.social-protocols.org/stats?id=41763190) #29 18 points 11 comments -> [You can create your own holiday](https://near.blog/unusual-holidays/)<!-- HN:41763190:end --><!-- HN:41788517:start -->
* [41788517](https://news.social-protocols.org/stats?id=41788517) #19 12 points 12 comments -> [Bankrupt Fisker says it can't migrate its EVs to a new owner's server](https://arstechnica.com/cars/2024/10/connected-car-failure-puts-kibosh-on-sale-of-3300-fisker-oceans/)<!-- HN:41788517:end --><!-- HN:41788290:start -->
* [41788290](https://news.social-protocols.org/stats?id=41788290) #22 6 points 3 comments -> [Show HN: Create AI Dialogue Podcasts](https://newspodcastdone.com)<!-- HN:41788290:end --><!-- HN:41790775:start -->
* [41790775](https://news.social-protocols.org/stats?id=41790775) #28 5 points 0 comments -> [Alaska utilities pursue renewables as costs escalate for fossil fuel electricity](https://www.seattletimes.com/seattle-news/climate-lab/alaska-utilities-turn-to-renewables-as-costs-escalate-for-fossil-fuel-electricity-generation/)<!-- HN:41790775:end --><!-- HN:41790762:start -->
* [41790762](https://news.social-protocols.org/stats?id=41790762) #25 6 points 0 comments -> [Free Software Foundation to serve on "artificial intelligence" safety consortium](https://www.fsf.org/news/fsf-serves-on-nist)<!-- HN:41790762:end --><!-- HN:41791658:start -->
* [41791658](https://news.social-protocols.org/stats?id=41791658) #11 4 points 1 comments -> [Are these 18 things all that's killing you?](https://domofutu.substack.com/p/these-18-things)<!-- HN:41791658:end --><!-- HN:41792880:start -->
* [41792880](https://news.social-protocols.org/stats?id=41792880) #1 41 points 2 comments -> [Internet Archive Hacked (Probably)](https://words.theresnotime.co.uk/2024/internet-archive-hacked-probably/)<!-- HN:41792880:end -->
#### **Thursday, October 10, 2024**
<!-- HN:41765009:start -->
* [41765009](https://news.social-protocols.org/stats?id=41765009) #28 19 points 6 comments -> [Is Android Unicode Yet?](https://shkspr.mobi/blog/2024/10/is-android-unicode-yet/)<!-- HN:41765009:end --><!-- HN:41794150:start -->
* [41794150](https://news.social-protocols.org/stats?id=41794150) #9 15 points 17 comments -> [The Case for Web Components: A Simpler, Framework-Free Future for the Web](https://blog.lnear.dev/the-case-for-web-components/)<!-- HN:41794150:end --><!-- HN:41742779:start -->
* [41742779](https://news.social-protocols.org/stats?id=41742779) #27 27 points 2 comments -> [Working Set Size Estimation (2018)](https://www.brendangregg.com/wss.html)<!-- HN:41742779:end --><!-- HN:41797081:start -->
* [41797081](https://news.social-protocols.org/stats?id=41797081) #22 5 points 3 comments -> [The Internet Archive is under attack](https://www.theverge.com/2024/10/9/24266135/nintendo-original-alarm-clock-alarmo-prototypes)<!-- HN:41797081:end --><!-- HN:41797084:start -->
* [41797084](https://news.social-protocols.org/stats?id=41797084) #2 58 points 28 comments -> [All We Have in This World Is Ourselves](https://rxjourney.com.ng/all-we-really-have-in-this-world-is-ourselves)<!-- HN:41797084:end --><!-- HN:41792803:start -->
* [41792803](https://news.social-protocols.org/stats?id=41792803) #18 45 points 36 comments -> [Upgrading Homebrew and avoiding the "failed to verify attestation" error](https://til.simonwillison.net/homebrew/no-verify-attestations)<!-- HN:41792803:end --><!-- HN:41797048:start -->
* [41797048](https://news.social-protocols.org/stats?id=41797048) #28 7 points 6 comments -> [BBC Weather app bug suggests hurricane winds in UK](https://www.bbc.co.uk/news/articles/c0kjrp2rngzo)<!-- HN:41797048:end --><!-- HN:41763034:start -->
* [41763034](https://news.social-protocols.org/stats?id=41763034) #22 13 points 1 comments -> [What the (2021)](https://articles.foletta.org/post/2021-04-19-what-the/)<!-- HN:41763034:end --><!-- HN:41797724:start -->
* [41797724](https://news.social-protocols.org/stats?id=41797724) #12 8 points 0 comments -> [A utopian strand of economic thought is making a surprising comeback](https://www.vox.com/the-highlight/24065976/economists-post-scarcity-abundance-industrial-revolution-socialism-capitalism)<!-- HN:41797724:end --><!-- HN:41799011:start -->
* [41799011](https://news.social-protocols.org/stats?id=41799011) #5 12 points 5 comments -> [AAA Gaming on Asahi Linux](https://asahilinux.org/2024/10/aaa-gaming-on-asahi-linux/)<!-- HN:41799011:end --><!-- HN:41801795:start -->
* [41801795](https://news.social-protocols.org/stats?id=41801795) #25 24 points 13 comments -> [X will pay its Premium users to engage with each other](https://www.theverge.com/2024/10/9/24266258/x-pay-premium-users-engage-with-each-other)<!-- HN:41801795:end -->
#### **Friday, October 11, 2024**<!-- HN:41805515:start -->
* [41805515](https://news.social-protocols.org/stats?id=41805515) #13 10 points 10 comments -> [Tesla's Robotaxi event still not started after 40 minutes [video]](https://www.youtube.com/watch?v=6v6dbxPlsXs)<!-- HN:41805515:end --><!-- HN:41805628:start -->
* [41805628](https://news.social-protocols.org/stats?id=41805628) #1 -> [UFO announcement 'could happen within weeks' as expert says 'we found it'](https://www.irishstar.com/news/us-news/ufo-announcement-aliens-extraterrestrials-nasa-33865539)<!-- HN:41805628:end --><!-- HN:41805941:start -->
* [41805941](https://news.social-protocols.org/stats?id=41805941) #9 8 points 8 comments -> [The digits of pi are not random](https://github.com/seccode/pi)<!-- HN:41805941:end --><!-- HN:41766126:start -->
* [41766126](https://news.social-protocols.org/stats?id=41766126) #10 16 points 1 comments -> [Show HN: Daily puzzle game where you build a bridge of your own words (SolidJS)](https://bridj.link/)<!-- HN:41766126:end --><!-- HN:41807121:start -->
* [41807121](https://news.social-protocols.org/stats?id=41807121) #25 7 points 0 comments -> [I'm Running Out of Ways to Explain How Bad This Is](https://www.theatlantic.com/technology/archive/2024/10/hurricane-milton-conspiracies-misinformation/680221/)<!-- HN:41807121:end --><!-- HN:41806645:start -->
* [41806645](https://news.social-protocols.org/stats?id=41806645) #22 -> [Georgia county official dies after testifying about BioLab chemical plant fire](https://www.wabe.org/georgia-county-official-dies-after-testifying-about-conyers-biolab-chemical-plant-fire/)<!-- HN:41806645:end --><!-- HN:41805391:start -->
* [41805391](https://news.social-protocols.org/stats?id=41805391) #27 129 points 84 comments -> [WordPress Alternatives](https://darn.es/wordpress-alternatives/)<!-- HN:41805391:end --><!-- HN:41806714:start -->
* [41806714](https://news.social-protocols.org/stats?id=41806714) #26 18 points 2 comments -> [Tesla's Robotaxi day was a total Snoozefest](https://twitter.com/realdanodowd/status/1844605093368512799)<!-- HN:41806714:end --><!-- HN:41806852:start -->
* [41806852](https://news.social-protocols.org/stats?id=41806852) #8 14 points 5 comments -> [Show HN: I made a football/soccer formation and squad app](https://apps.apple.com/au/app/football-formation/id6683308607)<!-- HN:41806852:end --><!-- HN:41757398:start -->
* [41757398](https://news.social-protocols.org/stats?id=41757398) #29 29 points 9 comments -> [Beast of Gévaudan](https://en.wikipedia.org/wiki/Beast_of_G%C3%A9vaudan)<!-- HN:41757398:end --><!-- HN:41770389:start -->
* [41770389](https://news.social-protocols.org/stats?id=41770389) #28 47 points 14 comments -> [Answer any question about your photo albums with OmniQuery](https://jiahaoli.net/omniquery/)<!-- HN:41770389:end --><!-- HN:41804460:start -->
* [41804460](https://news.social-protocols.org/stats?id=41804460) #29 68 points 185 comments -> [Is population density the reason Americans can't discuss politics?](https://www.georgesaines.com/blog/2024/10/10/is-population-density-the-reason-americans-cant-discuss-politics)<!-- HN:41804460:end --><!-- HN:41771774:start -->
* [41771774](https://news.social-protocols.org/stats?id=41771774) #17 12 points 2 comments -> [Who uses public libraries the most? There's a divide by religion, and politics.](https://www.washingtonpost.com/business/2024/10/04/who-uses-libraries/)<!-- HN:41771774:end --><!-- HN:41809013:start -->
* [41809013](https://news.social-protocols.org/stats?id=41809013) #24 5 points 0 comments -> [How to Find Consulting Clients (2017)](https://www.gkogan.co/how-to-find-consulting-clients/)<!-- HN:41809013:end --><!-- HN:41808282:start -->
* [41808282](https://news.social-protocols.org/stats?id=41808282) #3 28 points 16 comments -> [Startup Success: How Founder Personalities Shape Venture Outcomes](https://business.columbia.edu/research-brief/research-brief/startups-founder-personalities-vc)<!-- HN:41808282:end --><!-- HN:41808663:start -->
* [41808663](https://news.social-protocols.org/stats?id=41808663) #4 -> [Regrad Is Micrograd in Rust](https://github.com/ostadgeorge/regrad)<!-- HN:41808663:end --><!-- HN:41809224:start -->
* [41809224](https://news.social-protocols.org/stats?id=41809224) #26 15 points 0 comments -> ['That's a bloodbath': How a federal program kills wildlife for private interests](https://www.npr.org/2024/10/10/g-s1-26426/wildlife-services-usda-wild-animals-killed-livestock)<!-- HN:41809224:end --><!-- HN:41809920:start -->
* [41809920](https://news.social-protocols.org/stats?id=41809920) #4 3 points 1 comments -> [JavaScript Is Broken](https://codexstoney.medium.com/javascript-is-broken-8841df6f6fc8)<!-- HN:41809920:end --><!-- HN:41809911:start -->
* [41809911](https://news.social-protocols.org/stats?id=41809911) #21 15 points 17 comments -> [Apple's naming conventions are a mess](https://medium.com/@spacedawwwg/apples-naming-conventions-are-a-mess-here-s-what-i-would-do-f8ba364ce37a)<!-- HN:41809911:end --><!-- HN:41810627:start -->
* [41810627](https://news.social-protocols.org/stats?id=41810627) #18 27 points 17 comments -> ['Nearly unusable': Calif. police majorly push back on Tesla cop cars](https://www.sfgate.com/bayarea/article/california-switch-electric-cars-cops-19816671.php)<!-- HN:41810627:end --><!-- HN:41812358:start -->
* [41812358](https://news.social-protocols.org/stats?id=41812358) #4 9 points 2 comments -> [The sad state of font rendering on Linux](https://pandasauce.org/post/linux-fonts/)<!-- HN:41812358:end -->
#### **Saturday, October 12, 2024**
<!-- HN:41764369:start -->
* [41764369](https://news.social-protocols.org/stats?id=41764369) #9 13 points 2 comments -> [A roadmap for VirtIO Video on ChromeOS: part 3](https://www.collabora.com/news-and-blog/blog/2024/06/06/a-roadmap-for-virtio-video-on-chromeos-part-3/)<!-- HN:41764369:end --><!-- HN:41754942:start -->
* [41754942](https://news.social-protocols.org/stats?id=41754942) #15 9 points 1 comments -> [Scaling Laws of Optimization](https://francisbach.com/scaling-laws-of-optimization/)<!-- HN:41754942:end --><!-- HN:41814738:start -->
* [41814738](https://news.social-protocols.org/stats?id=41814738) #23 6 points 4 comments -> [Bug, $50K+ in bounties: how Zendesk left a backdoor in companies](https://gist.github.com/hackermondev/68ec8ed145fcee49d2f5e2b9d2cf2e52)<!-- HN:41814738:end --><!-- HN:41784098:start -->
* [41784098](https://news.social-protocols.org/stats?id=41784098) #10 10 points 1 comments -> [The $550M Question: How Does David Geffen Hall Sound?](https://www.nytimes.com/2024/10/08/arts/music/geffen-hall-acoustics.html)<!-- HN:41784098:end --><!-- HN:41816271:start -->
* [41816271](https://news.social-protocols.org/stats?id=41816271) #15 3 points 0 comments -> [How SpaceX became the MyPillow of government contractors](https://www.theverge.com/2024/10/11/24267262/elon-musk-donald-trump-politics-republican)<!-- HN:41816271:end --><!-- HN:41780914:start -->
* [41780914](https://news.social-protocols.org/stats?id=41780914) #10 21 points 41 comments -> [In Defense of LeetCode Interviews](https://www.alexmolas.com/2024/06/21/leetcode-interviews.html)<!-- HN:41780914:end --><!-- HN:41815544:start -->
* [41815544](https://news.social-protocols.org/stats?id=41815544) #11 9 points 2 comments -> [Show HN: Peak Brain Plasticity book – maximize brain power](https://www.saidhasyim.com/book/peak-brain-plasticity/)<!-- HN:41815544:end --><!-- HN:41818757:start -->
* [41818757](https://news.social-protocols.org/stats?id=41818757) #2 10 points 5 comments -> [Show HN: Here's how I steal your SaaS ideas](https://30percent.netlify.app/)<!-- HN:41818757:end --><!-- HN:41818382:start -->
* [41818382](https://news.social-protocols.org/stats?id=41818382) #30 37 points 40 comments -> [In Praise of 'Megalopolis'](https://www.compactmag.com/article/in-praise-of-megalopolis/)<!-- HN:41818382:end --><!-- HN:41819900:start -->
* [41819900](https://news.social-protocols.org/stats?id=41819900) #8 14 points 13 comments -> [The Boo Programming Language](https://github.com/boo-lang/boo)<!-- HN:41819900:end --><!-- HN:41821131:start -->
* [41821131](https://news.social-protocols.org/stats?id=41821131) #3 16 points 3 comments -> [Europeans Spend 575M Hours Clicking Cookie Banners Every Year](https://legiscope.com/blog/hidden-productivity-drain-cookie-banners.html)<!-- HN:41821131:end --><!-- HN:41820915:start -->
* [41820915](https://news.social-protocols.org/stats?id=41820915) #15 25 points 2 comments -> [Latest Asahi Linux brings AAA gaming to Apple's M1 with respectable frame rates](https://www.tomshardware.com/laptops/macbooks/aaa-gaming-comes-to-apple-m1-thanks-to-the-latest-asahi-linux-build-control-cyberpunk-2077-and-the-witcher-3-are-playable-with-respectable-frame-rates)<!-- HN:41820915:end --><!-- HN:41821775:start -->
* [41821775](https://news.social-protocols.org/stats?id=41821775) #13 4 points 2 comments -> [Evidence of alien may be announced within weeks](https://www.dailymail.co.uk/sciencetech/article-13950399/Evidence-alien-life-revealed-month.html)<!-- HN:41821775:end --><!-- HN:41821582:start -->
* [41821582](https://news.social-protocols.org/stats?id=41821582) #17 7 points 0 comments -> [AI helps farmers target weeds, livestock illnesses and pests](https://www.abc.net.au/news/2024-10-12/artificial-intelligence-agriculture-boom-australia-rural/104450732)<!-- HN:41821582:end --><!-- HN:41822200:start -->
* [41822200](https://news.social-protocols.org/stats?id=41822200) #4 -> [Killer drones play disturbing sounds to lure civilians out into the open](https://reliefweb.int/report/occupied-palestinian-territory/israeli-army-broadcasts-intimidating-sounds-lure-kill-and-forcibly-displace-civilians-nuseirat-camp-enar)<!-- HN:41822200:end --><!-- HN:41771010:start -->
* [41771010](https://news.social-protocols.org/stats?id=41771010) #16 44 points 14 comments -> [Researchers Find Cannibalized Victim of 19th-Century Arctic Voyage](https://www.nytimes.com/2024/10/04/science/franklin-expedition-cannibalism.html)<!-- HN:41771010:end --><!-- HN:41771864:start -->
* [41771864](https://news.social-protocols.org/stats?id=41771864) #20 12 points 1 comments -> [Ion and Molecular Sieving with Ultrathin Polydopamine Nanomembranes](https://onlinelibrary.wiley.com/doi/10.1002/adma.202401137)<!-- HN:41771864:end --><!-- HN:41821193:start -->
* [41821193](https://news.social-protocols.org/stats?id=41821193) #27 31 points 40 comments -> [Nvidia Stock Rises. AMD's New AI Chip Is Not Competitive](https://www.barrons.com/articles/nvidia-stock-price-amd-ai-chips-b6c42016)<!-- HN:41821193:end --><!-- HN:41823175:start -->
* [41823175](https://news.social-protocols.org/stats?id=41823175) #8 25 points 3 comments -> [Every time Matt Mullenweg has lied, misrepresented or behaved questionably](https://bullenweg.com/)<!-- HN:41823175:end --><!-- HN:41823155:start -->
* [41823155](https://news.social-protocols.org/stats?id=41823155) #6 7 points 7 comments -> [New vulnerability in sha256](https://github.com/seccode/Sha256)<!-- HN:41823155:end -->
#### **Sunday, October 13, 2024**
<!-- HN:41823437:start -->
* [41823437](https://news.social-protocols.org/stats?id=41823437) #6 49 points 14 comments -> [Columbus' DNA suggests he was a Sephardic Jew from the western Mediterranean](https://www.abc.es/cultura/adn-colon-apunta-judio-sefardi-mediterraneo-occidental-20241012233342-nt.html)<!-- HN:41823437:end --><!-- HN:41822910:start -->
* [41822910](https://news.social-protocols.org/stats?id=41822910) #5 64 points 2 comments -> [FAA grants SpaceX Starship Flight 5 license](https://drs.faa.gov/browse/excelExternalWindow/DRSDOCID173891218620231102140506.0001)<!-- HN:41822910:end --><!-- HN:41821639:start -->
* [41821639](https://news.social-protocols.org/stats?id=41821639) #25 37 points 41 comments -> [Home Libraries Will Save Civilization](https://www.frontporchrepublic.com/2024/10/home-libraries-will-save-civilization/)<!-- HN:41821639:end --><!-- HN:41824852:start -->
* [41824852](https://news.social-protocols.org/stats?id=41824852) #3 205 points 49 comments -> [ACF Has Been Hijacked](https://anderegg.ca/2024/10/13/acf-has-been-hijacked)<!-- HN:41824852:end --><!-- HN:41825041:start -->
* [41825041](https://news.social-protocols.org/stats?id=41825041) #8 11 points 40 comments -> [Show HN: A free alternative to Typora –– IF](https://if.openages.com)<!-- HN:41825041:end --><!-- HN:41824784:start -->
* [41824784](https://news.social-protocols.org/stats?id=41824784) #16 42 points 19 comments -> [The optimised version of 7-Zip can't be built from source](https://pileofhacks.dev/post/the-optimised-version-of-7-zip-cant-be-built-from-source/)<!-- HN:41824784:end --><!-- HN:41826432:start -->
* [41826432](https://news.social-protocols.org/stats?id=41826432) #13 4 points 1 comments -> [New Gmail Security Alert for 2.5B Users as AI Hack Confirmed](https://www.forbes.com/sites/daveywinder/2024/10/12/new-gmail-security-alert-for-billions-as-7-day-ai-hack-confirmed/)<!-- HN:41826432:end --><!-- HN:41826344:start -->
* [41826344](https://news.social-protocols.org/stats?id=41826344) #15 20 points 1 comments -> [Wim Taymans: PipeWire Inventor](https://en.wikipedia.org/wiki/Wim_Taymans)<!-- HN:41826344:end --><!-- HN:41827112:start -->
* [41827112](https://news.social-protocols.org/stats?id=41827112) #10 -> [Changing Views Toward mRNA Based Covid Vaccines in the Scientific Literature](http://www.paom.pl/Changing-Views-toward-mRNA-based-Covid-Vaccines-in-the-Scientific-Literature-2020,189961,0,2.html)<!-- HN:41827112:end --><!-- HN:41827218:start -->
* [41827218](https://news.social-protocols.org/stats?id=41827218) #21 3 points 0 comments -> [Removing Windows Recall Breaks File Explorer in Latest 24H2 Update](https://www.notebookcheck.net/Removing-Windows-Recall-breaks-File-Explorer-in-latest-24H2-update.899991.0.html)<!-- HN:41827218:end --><!-- HN:41827136:start -->
* [41827136](https://news.social-protocols.org/stats?id=41827136) #14 9 points 4 comments -> [Difference Between Butter Chicken and Chicken Tikka Masala](https://twitter.com/devahaz/status/1845267197268054216)<!-- HN:41827136:end --><!-- HN:41828039:start -->
* [41828039](https://news.social-protocols.org/stats?id=41828039) #10 7 points 0 comments -> [Secret Documents Show Hamas Tried to Persuade Iran to Join Its Oct. 7 Attack](https://www.nytimes.com/2024/10/12/world/middleeast/hamas-israel-war.html)<!-- HN:41828039:end --><!-- HN:41827955:start -->
* [41827955](https://news.social-protocols.org/stats?id=41827955) #3 10 points 2 comments -> [Show HN: I built a free screen recording app similar to Screen Studio](https://www.screenvivid.com)<!-- HN:41827955:end --><!-- HN:41828348:start -->
* [41828348](https://news.social-protocols.org/stats?id=41828348) #13 17 points 7 comments -> [Billions of Gmail users at risk from sophisticated new AI hack](https://www.tomsguide.com/computing/online-security/billions-of-gmail-users-at-risk-from-sophisticated-new-ai-hack-how-to-stay-safe)<!-- HN:41828348:end --><!-- HN:41828960:start -->
* [41828960](https://news.social-protocols.org/stats?id=41828960) #24 4 points 1 comments -> ["Simple English" is a language on Wikipedia](https://simple.wikipedia.org/wiki/Simple_English_Wikipedia)<!-- HN:41828960:end --><!-- HN:41829464:start -->
* [41829464](https://news.social-protocols.org/stats?id=41829464) #20 5 points 0 comments -> [Systemic proteome adaptions to 7-day complete caloric restriction in humans](https://www.nature.com/articles/s42255-024-01008-9)<!-- HN:41829464:end --><!-- HN:41829646:start -->
* [41829646](https://news.social-protocols.org/stats?id=41829646) #7 28 points 11 comments -> [ClassicPress – The CMS for Creators](https://www.classicpress.net/)<!-- HN:41829646:end --><!-- HN:41829783:start -->
* [41829783](https://news.social-protocols.org/stats?id=41829783) #25 16 points 9 comments -> [Mystery UFOs swarm US Military base](https://www.wsj.com/politics/national-security/drones-military-pentagon-defense-331871f4)<!-- HN:41829783:end --><!-- HN:41830345:start -->
* [41830345](https://news.social-protocols.org/stats?id=41830345) #24 6 points 2 comments -> [Columbus was a Sephardic Jew from Western Europe, study finds](https://www.reuters.com/science/columbus-was-sephardic-jew-western-europe-study-finds-2024-10-13/)<!-- HN:41830345:end --><!-- HN:41804389:start -->
* [41804389](https://news.social-protocols.org/stats?id=41804389) #10 18 points 41 comments -> [What, Exactly, Is 'Moderate Drinking'?](https://www.nytimes.com/2024/10/10/well/eat/moderate-alcohol-drinking-definition.html)<!-- HN:41804389:end --><!-- HN:41831932:start -->
* [41831932](https://news.social-protocols.org/stats?id=41831932) #15 7 points 0 comments -> [Black Voters Drift from Democrats, Imperiling Harris's Bid, Poll Shows](https://www.nytimes.com/2024/10/12/us/politics/poll-black-voters-harris-trump.html)<!-- HN:41831932:end --><!-- HN:41830421:start -->
* [41830421](https://news.social-protocols.org/stats?id=41830421) #23 6 points 7 comments -> [HHKB and Realforce – Mechanical Programming and Gaming Keyboards](https://hhkeyboard.us/)<!-- HN:41830421:end --><!-- HN:41831794:start -->
* [41831794](https://news.social-protocols.org/stats?id=41831794) #2 25 points 2 comments -> [Refurb weekend: the Symbolics MacIvory Lisp machine I have hated](http://oldvcr.blogspot.com/2024/10/refurb-weekend-symbolics-macivory-lisp.html)<!-- HN:41831794:end -->
#### **Monday, October 14, 2024**
<!-- HN:41807713:start -->
* [41807713](https://news.social-protocols.org/stats?id=41807713) #23 17 points 5 comments -> [Lessons from USAF Brutalism](https://dmsnell.blog/2017/10/15/lessons-from-usaf-brutalism/)<!-- HN:41807713:end --><!-- HN:41833928:start -->
* [41833928](https://news.social-protocols.org/stats?id=41833928) #23 14 points 20 comments -> [We Are in Need of Renaissance People](https://victorhanson.com/we-are-in-need-of-renaissance-people/)<!-- HN:41833928:end --><!-- HN:41834585:start -->
* [41834585](https://news.social-protocols.org/stats?id=41834585) #2 6 points 3 comments -> [I'm a feminist and I think it's harder to be a man than a woman](https://celestemdavis.substack.com/p/hard-to-be-a-man)<!-- HN:41834585:end --><!-- HN:41835140:start -->
* [41835140](https://news.social-protocols.org/stats?id=41835140) #25 10 points 2 comments -> [Graph Databases for Crime-Fighting: How Memgraph Maps and Analyzes Criminal](https://memgraph.com/blog/graph-databases-crime-fighting-memgraph-criminal-networks)<!-- HN:41835140:end --><!-- HN:41832099:start -->
* [41832099](https://news.social-protocols.org/stats?id=41832099) #19 34 points 5 comments -> [FriendlyElec NanoPi R5S as PTP Grandmaster Clock with GNSS/GPS Discipline (2022)](https://blog.kylemanna.com/hardware/nanopi-r5s-as-ptp-grandmaster-clock-with-gnss-gps-discipline/)<!-- HN:41832099:end --><!-- HN:41835210:start -->
* [41835210](https://news.social-protocols.org/stats?id=41835210) #17 3 points 0 comments -> [Trust Rules Everything Around Me](https://scottarc.blog/2024/10/14/trust-rules-everything-around-me/)<!-- HN:41835210:end --><!-- HN:41836570:start -->
* [41836570](https://news.social-protocols.org/stats?id=41836570) #17 3 points 0 comments -> [Matt Mullenweg's Bull(enweg)](https://bullenweg.com/)<!-- HN:41836570:end --><!-- HN:41838555:start -->
* [41838555](https://news.social-protocols.org/stats?id=41838555) #17 14 points 1 comments -> [Report of 'armed militia' prompts relocation of NC hurricane recovery officials](https://www.washingtonpost.com/weather/2024/10/13/federal-officials-nc-temporarily-relocated-amid-report-armed-militia-email-shows/)<!-- HN:41838555:end --><!-- HN:41836769:start -->
* [41836769](https://news.social-protocols.org/stats?id=41836769) #30 29 points 41 comments -> [Avoiding a Geopolitical open-source Apocalypse](https://thenewstack.io/avoiding-a-geopolitical-open-source-apocalypse/)<!-- HN:41836769:end --><!-- HN:41838547:start -->
* [41838547](https://news.social-protocols.org/stats?id=41838547) #26 8 points 0 comments -> [He was sentenced to death. Shaken baby syndrome is at the heart of his appeals](https://www.cnn.com/2024/10/13/us/robert-roberson-execution-shaken-baby-syndrome/index.html)<!-- HN:41838547:end --><!-- HN:41838604:start -->
* [41838604](https://news.social-protocols.org/stats?id=41838604) #23 8 points 1 comments -> [Magnetically regulated gene therapy offers precise brain-circuit control](https://news.weill.cornell.edu/news/2024/10/magnetically-regulated-gene-therapy-tech-offers-precise-brain-circuit-control)<!-- HN:41838604:end --><!-- HN:41840076:start -->
* [41840076](https://news.social-protocols.org/stats?id=41840076) #28 3 points 0 comments -> [Starlink Gen2](https://twitter.com/ajtourville/status/1845858409633210751)<!-- HN:41840076:end --><!-- HN:41840337:start -->
* [41840337](https://news.social-protocols.org/stats?id=41840337) #22 3 points 0 comments -> [Terraform Industries Master Plan](https://terraformindustries.wordpress.com/2024/10/04/terraform-industries-master-plan/)<!-- HN:41840337:end --><!-- HN:41840746:start -->
* [41840746](https://news.social-protocols.org/stats?id=41840746) #14 5 points 0 comments -> [You can track changes someone makes to their Instagram account](https://github.com/ibnaleem/instatracker)<!-- HN:41840746:end --><!-- HN:41839270:start -->
* [41839270](https://news.social-protocols.org/stats?id=41839270) #30 6 points 0 comments -> [Reading Marx's Capital with David Harvey](https://davidharvey.org/)<!-- HN:41839270:end --><!-- HN:41840450:start -->
* [41840450](https://news.social-protocols.org/stats?id=41840450) #1 87 points 1 comments -> [Gosub: A browser engine written in Rust](https://github.com/gosub-io/gosub-engine)<!-- HN:41840450:end --><!-- HN:41842463:start -->
* [41842463](https://news.social-protocols.org/stats?id=41842463) #21 7 points 6 comments -> [Mullenweg : Response to DHH](https://ma.tt/)<!-- HN:41842463:end --><!-- HN:41841835:start -->
* [41841835](https://news.social-protocols.org/stats?id=41841835) #6 31 points 4 comments -> [I don't want your AI](https://martinantos.com/I-don%27t-want-your-AI/)<!-- HN:41841835:end -->
#### **Tuesday, October 15, 2024**
<!-- HN:41845075:start -->
* [41845075](https://news.social-protocols.org/stats?id=41845075) #25 5 points 0 comments -> [Riots and the far right: the global network behind the violence](https://news.sky.com/story/riots-and-the-far-right-the-global-network-behind-the-violence-13232023)<!-- HN:41845075:end --><!-- HN:41846876:start -->
* [41846876](https://news.social-protocols.org/stats?id=41846876) #19 13 points 0 comments -> [The deep-sea 'emergency service' that keeps the internet running](https://www.bbc.com/future/article/20241014-the-deep-sea-emergency-service-that-keeps-the-internet-running)<!-- HN:41846876:end --><!-- HN:41807954:start -->
* [41807954](https://news.social-protocols.org/stats?id=41807954) #8 37 points 17 comments -> ['Islands' of regularity discovered in the famously chaotic three-body problem](https://phys.org/news/2024-10-islands-regularity-famously-chaotic-body.html)<!-- HN:41807954:end --><!-- HN:41845624:start -->
* [41845624](https://news.social-protocols.org/stats?id=41845624) #18 23 points 11 comments -> [India's Renewable Energy Capacity Hits 200 GW Milestone, Accounts for 46.3%](https://www.ndtvprofit.com/business/india-renewable-energy-hits-200-gw-milestone-46-percent-total-power)<!-- HN:41845624:end --><!-- HN:41848053:start -->
* [41848053](https://news.social-protocols.org/stats?id=41848053) #9 8 points 3 comments -> [Looking for help for Bloxtor: A Free Open-Source Web App Framework](https://github.com/a19836/bloxtor)<!-- HN:41848053:end --><!-- HN:41845705:start -->
* [41845705](https://news.social-protocols.org/stats?id=41845705) #21 28 points 43 comments -> [The American economy has left other rich countries in the dust](https://www.economist.com/special-report/2024/10/14/the-american-economy-has-left-other-rich-countries-in-the-dust)<!-- HN:41845705:end --><!-- HN:41848935:start -->
* [41848935](https://news.social-protocols.org/stats?id=41848935) #11 5 points 0 comments -> [Announcing Our Updated Responsible Scaling Policy](https://www.anthropic.com/news/announcing-our-updated-responsible-scaling-policy)<!-- HN:41848935:end --><!-- HN:41849735:start -->
* [41849735](https://news.social-protocols.org/stats?id=41849735) #8 12 points 1 comments -> [OpenAI Is a Bad Business](https://www.wheresyoured.at/oai-business/)<!-- HN:41849735:end -->