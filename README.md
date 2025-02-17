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

#### **Tuesday, February 11, 2025**
<!-- HN:43007564:start -->
* [43007564](https://news.social-protocols.org/stats?id=43007564) #25 30 points 22 comments -> [Google Calendar removed events like Pride and BHM; retains Black Friday](https://www.theverge.com/news/608858/google-calendar-missing-events-holidays)<!-- HN:43007564:end --><!-- HN:43007862:start -->
* [43007862](https://news.social-protocols.org/stats?id=43007862) #26 52 points 13 comments -> [Danes sign petition to buy California from U.S.](https://ktla.com/news/california/thousands-of-danes-sign-petition-to-buy-california-from-u-s/amp/)<!-- HN:43007862:end --><!-- HN:43008340:start -->
* [43008340](https://news.social-protocols.org/stats?id=43008340) #19 5 points 0 comments -> [Trump's Orders on Gender Put Science Back in the Driver's Seat](https://www.newsweek.com/trumps-orders-gender-put-science-back-drivers-seat-opinion-2027532)<!-- HN:43008340:end --><!-- HN:43008417:start -->
* [43008417](https://news.social-protocols.org/stats?id=43008417) #23 34 points 16 comments -> [What are non intelligent people like me supposed to do for money?](https://www.reddit.com/r/findapath/s/Me91Ke0COG)<!-- HN:43008417:end --><!-- HN:43009729:start -->
* [43009729](https://news.social-protocols.org/stats?id=43009729) #29 5 points 3 comments -> [Musk-led group makes $97.4B bid for ChatGPT maker OpenAI](https://www.bbc.com/news/articles/cpdx75zgg88o)<!-- HN:43009729:end --><!-- HN:43011257:start -->
* [43011257](https://news.social-protocols.org/stats?id=43011257) #11 19 points 42 comments -> [Altman: OpenAI not for sale, especially to competitor who is not able to beat us](https://www.axios.com/2025/02/11/openai-altman-musk-offer)<!-- HN:43011257:end --><!-- HN:43010662:start -->
* [43010662](https://news.social-protocols.org/stats?id=43010662) #28 68 points 81 comments -> [Sid Meier's Civilization VII](https://civilization.2k.com/civ-vii/buy/)<!-- HN:43010662:end --><!-- HN:43011989:start -->
* [43011989](https://news.social-protocols.org/stats?id=43011989) #12 4 points 2 comments -> [Most Harvard students are unemployed, tech companies prefer H1B workers](https://twitter.com/soulofpetronius/status/1871977670256238833)<!-- HN:43011989:end --><!-- HN:43012390:start -->
* [43012390](https://news.social-protocols.org/stats?id=43012390) #18 5 points 0 comments -> [UK and US refuse to sign international AI declaration](https://www.bbc.com/news/articles/c8edn0n58gwo)<!-- HN:43012390:end --><!-- HN:43007052:start -->
* [43007052](https://news.social-protocols.org/stats?id=43007052) #25 75 points 144 comments -> [Google Maps now shows the 'Gulf of America'](https://www.theverge.com/news/609772/google-maps-gulf-of-america-rename-mexico)<!-- HN:43007052:end --><!-- HN:43011535:start -->
* [43011535](https://news.social-protocols.org/stats?id=43011535) #22 11 points 1 comments -> [Enterprise Is Dead](https://cra.mr/enterprise-is-dead/)<!-- HN:43011535:end --><!-- HN:43014321:start -->
* [43014321](https://news.social-protocols.org/stats?id=43014321) #10 7 points 0 comments -> [Proton Wallet is now available for all](https://primal.net/e/note1fus8glne8684xtn3n8lt2wjztsjss6k4jmc56ttl573ngxczerlqp84g9m)<!-- HN:43014321:end --><!-- HN:43014716:start -->
* [43014716](https://news.social-protocols.org/stats?id=43014716) #8 15 points 9 comments -> [The Curious Similarity Between LLMs and Quantum Mechanics](https://robleclerc.substack.com/p/the-curious-similarity-between-llms)<!-- HN:43014716:end --><!-- HN:43015271:start -->
* [43015271](https://news.social-protocols.org/stats?id=43015271) #5 8 points 9 comments -> [Show HN: I built an AI coloring page generator](https://www.colori.io/)<!-- HN:43015271:end --><!-- HN:42989340:start -->
* [42989340](https://news.social-protocols.org/stats?id=42989340) #18 12 points 0 comments -> [Tariff Engineering](https://www.readtrung.com/p/tariff-engineering-explained)<!-- HN:42989340:end --><!-- HN:43016703:start -->
* [43016703](https://news.social-protocols.org/stats?id=43016703) #28 -> [DOGE Teen Ran Image-Sharing Site Linked to Pedophilia and the KKK](https://www.muskwatch.com/p/doge-teen-ran-image-sharing-site)<!-- HN:43016703:end --><!-- HN:43018223:start -->
* [43018223](https://news.social-protocols.org/stats?id=43018223) #19 6 points 1 comments -> [Man who lost $780M in Bitcoin in a landfill now wants to buy the dump](https://www.tomshardware.com/tech-industry/cryptocurrency/landfill-concealing-8-000-bitcoins-valued-at-usd780m-to-transform-into-a-solar-farm-but-man-now-wishes-to-buy-the-site)<!-- HN:43018223:end --><!-- HN:43018790:start -->
* [43018790](https://news.social-protocols.org/stats?id=43018790) #10 6 points 1 comments -> [Letters from BBC Television Licensing](http://www.bbctvlicence.com/)<!-- HN:43018790:end --><!-- HN:43014070:start -->
* [43014070](https://news.social-protocols.org/stats?id=43014070) #19 74 points 11 comments -> [Get in loser. We're rewinding the stack](https://andrews.substack.com/p/get-in-loser-were-rewinding-the-stack)<!-- HN:43014070:end -->
#### **Wednesday, February 12, 2025**<!-- HN:42985614:start -->
* [42985614](https://news.social-protocols.org/stats?id=42985614) #16 3 points 0 comments -> [Creality Space Pi Filament Dryer Plus: Review and Specs](https://syntaxglow.com/2025/02/08/creality-space-pi-filament-dryer-plus-review-specs/)<!-- HN:42985614:end --><!-- HN:43021333:start -->
* [43021333](https://news.social-protocols.org/stats?id=43021333) #10 224 points 112 comments -> [Resist Authoritarianism by Refusing to Obey in Advance (2017)](https://lithub.com/resist-authoritarianism-by-refusing-to-obey-in-advance/)<!-- HN:43021333:end --><!-- HN:43020684:start -->
* [43020684](https://news.social-protocols.org/stats?id=43020684) #11 293 points 260 comments -> [WASM will replace containers](https://creston.blog/wasm-will-replace-containers/)<!-- HN:43020684:end --><!-- HN:42994590:start -->
* [42994590](https://news.social-protocols.org/stats?id=42994590) #12 230 points 58 comments -> [Smoke in the cabin of two 737 MAX caused by Load Reduction Device system [video]](https://www.youtube.com/watch?v=swlVkYVSlIE)<!-- HN:42994590:end --><!-- HN:43019737:start -->
* [43019737](https://news.social-protocols.org/stats?id=43019737) #13 99 points 40 comments -> [Migrate purchases from one Apple Account to another](https://support.apple.com/en-us/117294)<!-- HN:43019737:end --><!-- HN:43021515:start -->
* [43021515](https://news.social-protocols.org/stats?id=43021515) #17 147 points 97 comments -> [jj: a Git-compatible VCS that is both simple and powerful](https://github.com/jj-vcs/jj)<!-- HN:43021515:end --><!-- HN:42986629:start -->
* [42986629](https://news.social-protocols.org/stats?id=42986629) #20 55 points 28 comments -> [Show HN: App that simulates a software engineer's daily job](https://mock-job-mentor.vercel.app/dashboard)<!-- HN:42986629:end --><!-- HN:43025266:start -->
* [43025266](https://news.social-protocols.org/stats?id=43025266) #23 8 points 4 comments -> [Delivering Malware Through Abandoned Amazon S3 Buckets](https://www.schneier.com/blog/archives/2025/02/delivering-malware-through-abandoned-amazon-s3-buckets.html)<!-- HN:43025266:end --><!-- HN:43025420:start -->
* [43025420](https://news.social-protocols.org/stats?id=43025420) #21 4 points 0 comments -> [Representation of BBC News Content in AI Assistants [pdf]](https://www.bbc.co.uk/aboutthebbc/documents/bbc-research-into-ai-assistants.pdf)<!-- HN:43025420:end --><!-- HN:43026302:start -->
* [43026302](https://news.social-protocols.org/stats?id=43026302) #18 5 points 0 comments -> [Ignorance is bliss when you're drowning in information](https://www.theregister.com/2025/02/12/ignorance_really_is_bliss/)<!-- HN:43026302:end --><!-- HN:43026455:start -->
* [43026455](https://news.social-protocols.org/stats?id=43026455) #27 3 points 0 comments -> [The secret behind sharp vision: the benefits of tiny eye movements](https://medicalxpress.com/news/2025-02-secret-sharp-vision-reveals-benefits.html)<!-- HN:43026455:end --><!-- HN:43026104:start -->
* [43026104](https://news.social-protocols.org/stats?id=43026104) #21 29 points 1 comments -> [Syd: An Introduction to Secure Application Sandboxing for Linux [video]](https://fosdem.org/2025/schedule/event/fosdem-2025-4176-syd-an-introduction-to-secure-application-sandboxing-for-linux/)<!-- HN:43026104:end --><!-- HN:43028063:start -->
* [43028063](https://news.social-protocols.org/stats?id=43028063) #8 4 points 1 comments -> [Let's Buy California – Denmark's Next Big Adventure](https://denmarkification.com/)<!-- HN:43028063:end --><!-- HN:43028641:start -->
* [43028641](https://news.social-protocols.org/stats?id=43028641) #8 9 points 1 comments -> [Startup Funding Roadmap](https://anyonyashraya.com/on_startup_funding.html)<!-- HN:43028641:end -->
#### **Thursday, February 13, 2025**
<!-- HN:43031367:start -->
* [43031367](https://news.social-protocols.org/stats?id=43031367) #8 10 points 2 comments -> [Help Denmark Buy California – Because Why Not?](https://denmarkification.com/)<!-- HN:43031367:end --><!-- HN:43032112:start -->
* [43032112](https://news.social-protocols.org/stats?id=43032112) #24 16 points 11 comments -> [Apple Resumes Advertising on X](https://www.macrumors.com/2025/02/12/apple-resumes-advertising-on-x/)<!-- HN:43032112:end --><!-- HN:43032540:start -->
* [43032540](https://news.social-protocols.org/stats?id=43032540) #2 7 points 0 comments -> [More than 100 women kept as slaves in illegal egg harvesting farm in Georgia](https://thenewfeminist.co.uk/2025/02/more-than-100-women-kept-as-slaves-in-illegal-egg-harvesting-farm-in-georgia/)<!-- HN:43032540:end --><!-- HN:43033202:start -->
* [43033202](https://news.social-protocols.org/stats?id=43033202) #1 7 points 1 comments -> [Diversity: The U.S. Military's Not-So-Secret Weapon](https://angrystaffofficer.com/2025/02/12/diversity-the-u-s-militarys-not-so-secret-weapon/)<!-- HN:43033202:end --><!-- HN:43034405:start -->
* [43034405](https://news.social-protocols.org/stats?id=43034405) #7 17 points 13 comments -> [New DOGE site update breaks down government jobs by salary/age/headcount](https://doge.gov/workforce)<!-- HN:43034405:end --><!-- HN:43036550:start -->
* [43036550](https://news.social-protocols.org/stats?id=43036550) #15 8 points 2 comments -> [Senior State Dept. Advisor "BigBalls" Ran Image Host with Racist/Pedophilic URLs](https://www.muskwatch.com/p/doge-teen-ran-image-sharing-site)<!-- HN:43036550:end --><!-- HN:43036611:start -->
* [43036611](https://news.social-protocols.org/stats?id=43036611) #21 11 points 2 comments -> [Apple has started advertising on X again](https://www.theverge.com/news/611967/apple-resumes-x-twitter-ad-spending-boycott)<!-- HN:43036611:end --><!-- HN:43036366:start -->
* [43036366](https://news.social-protocols.org/stats?id=43036366) #17 9 points 0 comments -> [UTEP leaders silent as Ted Cruz accuses researchers of using 'woke DEI grants'](https://elpasomatters.org/2025/02/12/ted-cruz-utep-grants-national-science-foundation/)<!-- HN:43036366:end --><!-- HN:42993603:start -->
* [42993603](https://news.social-protocols.org/stats?id=42993603) #27 11 points 5 comments -> [The World Without a Mask (1934)](https://scifist.net/2022/07/23/the-world-without-a-mask/)<!-- HN:42993603:end --><!-- HN:43037600:start -->
* [43037600](https://news.social-protocols.org/stats?id=43037600) #7 104 points 28 comments -> [I built a failed startups goods website and named it VcSubsidized.com](https://vcsubsidized.com/)<!-- HN:43037600:end -->
#### **Friday, February 14, 2025**
<!-- HN:43039347:start -->
* [43039347](https://news.social-protocols.org/stats?id=43039347) #19 57 points 40 comments -> [Tolerating full cloud outages with Monzo Stand-in](https://monzo.com/blog/tolerating-full-cloud-outages-with-monzo-stand-in)<!-- HN:43039347:end --><!-- HN:43042835:start -->
* [43042835](https://news.social-protocols.org/stats?id=43042835) #25 8 points 2 comments -> [JPMorgan's Jamie Dimon slams anti-RTO petition](https://nypost.com/2025/02/13/business/jpmorgans-jamie-dimon-slams-f-g-anti-rto-petition-dont-waste-time-on-it/)<!-- HN:43042835:end --><!-- HN:43043199:start -->
* [43043199](https://news.social-protocols.org/stats?id=43043199) #26 11 points 2 comments -> [Federal Prosecutors in New York and Washington DC Resign](https://www.nbcnews.com/politics/justice-department/top-federal-prosecutor-ny-resigns-told-drop-adams-charges-rcna192030)<!-- HN:43043199:end --><!-- HN:43043426:start -->
* [43043426](https://news.social-protocols.org/stats?id=43043426) #16 38 points 10 comments -> [Passing the Torch on Asahi Linux](https://asahilinux.org/2025/02/passing-the-torch/)<!-- HN:43043426:end --><!-- HN:43043652:start -->
* [43043652](https://news.social-protocols.org/stats?id=43043652) #19 11 points 5 comments -> [Ted Cruz "Woke" NSF DEI Grants](https://ramadda.org/repository/entry/show?entryid=b4a2c7ea-4652-44d8-8003-93d5ade529be)<!-- HN:43043652:end --><!-- HN:43043312:start -->
* [43043312](https://news.social-protocols.org/stats?id=43043312) #21 135 points 112 comments -> [We are the "thin blue line" that is trying to keep the code high quality](https://lore.kernel.org/lkml/20250208204416.GL1130956@mit.edu/)<!-- HN:43043312:end --><!-- HN:43043752:start -->
* [43043752](https://news.social-protocols.org/stats?id=43043752) #12 113 points 96 comments -> [Apple Resumes Advertising on X](https://daringfireball.net/linked/2025/02/12/apple-advertising-x)<!-- HN:43043752:end --><!-- HN:43044806:start -->
* [43044806](https://news.social-protocols.org/stats?id=43044806) #22 11 points 1 comments -> [VA dismisses more than 1k employees](https://news.va.gov/press-room/va-dismisses-more-than-1000-employees/)<!-- HN:43044806:end --><!-- HN:43044962:start -->
* [43044962](https://news.social-protocols.org/stats?id=43044962) #23 42 points 12 comments -> [State Capture](https://en.wikipedia.org/wiki/State_capture)<!-- HN:43044962:end --><!-- HN:43046466:start -->
* [43046466](https://news.social-protocols.org/stats?id=43046466) #8 59 points 35 comments -> ["Homotopical macrocosms for higher category theory" identified as woke DEI grant](https://mathstodon.xyz/@johncarlosbaez/114000054766059217)<!-- HN:43046466:end --><!-- HN:43047892:start -->
* [43047892](https://news.social-protocols.org/stats?id=43047892) #4 11 points 0 comments -> [Watch me turn $25K and Python into either a hedge fund origin story or](https://pythonfintech.com)<!-- HN:43047892:end --><!-- HN:43048405:start -->
* [43048405](https://news.social-protocols.org/stats?id=43048405) #8 31 points 17 comments -> [US Gov Org Chart](https://doge.gov/workforce?orgId=69ee18bc-9ac8-467e-84b0-106601b01b90)<!-- HN:43048405:end --><!-- HN:43049382:start -->
* [43049382](https://news.social-protocols.org/stats?id=43049382) #28 8 points 3 comments -> [We Tried to Warn You](https://unsafescience.substack.com/p/we-tried-to-warn-you)<!-- HN:43049382:end --><!-- HN:43049525:start -->
* [43049525](https://news.social-protocols.org/stats?id=43049525) #2 16 points 11 comments -> [Bitly injecting ads into shortened links](https://social.jvns.ca/@b0rk/114002651694606295)<!-- HN:43049525:end --><!-- HN:43049838:start -->
* [43049838](https://news.social-protocols.org/stats?id=43049838) #19 -> [Doge Exposes Once-Secret Government Networks](https://cyberintel.substack.com/p/doge-exposes-once-secret-government)<!-- HN:43049838:end --><!-- HN:43050378:start -->
* [43050378](https://news.social-protocols.org/stats?id=43050378) #30 4 points 3 comments -> [DOGE Exposes Once-Secret Government Networks](https://cyberintel.substack.com/p/doge-exposes-once-secret-government)<!-- HN:43050378:end --><!-- HN:43019557:start -->
* [43019557](https://news.social-protocols.org/stats?id=43019557) #17 35 points 41 comments -> [What the Black Hawk pilots could see, just before the crash](https://www.nytimes.com/interactive/2025/02/05/us/dc-crash-helicopter-black-hawk-pilots.html)<!-- HN:43019557:end --><!-- HN:43050579:start -->
* [43050579](https://news.social-protocols.org/stats?id=43050579) #5 38 points 9 comments -> [DOGE Website Hacked](https://arstechnica.com/tech-policy/2025/02/doges-gov-site-lampooned-as-coders-quickly-realize-it-can-be-edited-by-anyone/)<!-- HN:43050579:end --><!-- HN:43051132:start -->
* [43051132](https://news.social-protocols.org/stats?id=43051132) #26 2 points 0 comments -> [Pope Francis hospitalised with bronchitis after struggling to speak](https://www.irishtimes.com/world/europe/2025/02/14/pope-francis-hospitalised-for-bronchitis-treatment/)<!-- HN:43051132:end --><!-- HN:43051135:start -->
* [43051135](https://news.social-protocols.org/stats?id=43051135) #29 49 points 14 comments -> [DOGE Exposes Once-Secret Government Networks, Making Cyber-Espionage Easier Than](https://cyberintel.substack.com/p/doge-exposes-once-secret-government)<!-- HN:43051135:end --><!-- HN:43051370:start -->
* [43051370](https://news.social-protocols.org/stats?id=43051370) #2 -> ["Experts" Left Their Database Open – Roro](https://doge.gov/workforce?orgId=7cd300eb-cf3f-47f5-90f1-9e66a8bc8d07)<!-- HN:43051370:end --><!-- HN:43050676:start -->
* [43050676](https://news.social-protocols.org/stats?id=43050676) #27 6 points 0 comments -> [Everyone Should Read 'Why Should White Guys Have All the Fun?' By Reginald Lewis](https://substack.com/home/post/p-157005620)<!-- HN:43050676:end --><!-- HN:43051697:start -->
* [43051697](https://news.social-protocols.org/stats?id=43051697) #6 47 points 12 comments -> [DOGE 'Audits': A Mask for Corruption, Not Efficiency](https://medium.com/less-than-a-minute/doge-audits-a-mask-for-corruption-not-efficiency-3668b846a364)<!-- HN:43051697:end --><!-- HN:43051839:start -->
* [43051839](https://news.social-protocols.org/stats?id=43051839) #29 8 points 0 comments -> [US Treasury watchdog begins audit of DOGE access to federal payment system](https://www.reuters.com/world/us/us-treasury-watchdog-begins-audit-doge-access-federal-payment-system-ap-reports-2025-02-14/)<!-- HN:43051839:end --><!-- HN:43007453:start -->
* [43007453](https://news.social-protocols.org/stats?id=43007453) #24 34 points 40 comments -> [Do Lake Names Reflect Their Properties?](https://ivanludvig.dev/tech/lake-colors)<!-- HN:43007453:end --><!-- HN:43052468:start -->
* [43052468](https://news.social-protocols.org/stats?id=43052468) #7 -> [DOGE's 'Genius' Coders Launch Website So Full of Holes, Anyone Can Write to It](https://www.techdirt.com/2025/02/14/doges-genius-coders-launch-website-so-full-of-holes-anyone-can-write-to-it/)<!-- HN:43052468:end --><!-- HN:43052430:start -->
* [43052430](https://news.social-protocols.org/stats?id=43052430) #2 -> [Danish Petition to Buy California](https://denmarkification.com/)<!-- HN:43052430:end --><!-- HN:43047554:start -->
* [43047554](https://news.social-protocols.org/stats?id=43047554) #25 55 points 41 comments -> [Show HN: A New Way to Learn Languages](https://www.langturbo.com)<!-- HN:43047554:end --><!-- HN:43053552:start -->
* [43053552](https://news.social-protocols.org/stats?id=43053552) #27 12 points 3 comments -> [The United States is not a Silicon Valley company](http://scripting.com/2025/02/12/140926.html)<!-- HN:43053552:end --><!-- HN:43054050:start -->
* [43054050](https://news.social-protocols.org/stats?id=43054050) #25 8 points 2 comments -> [Trump's Purge Hits Nuclear Weapons Agency–Setting Off National Crisis](https://newrepublic.com/post/191564/trump-fires-rehires-nuclear-weapons-agency-staff)<!-- HN:43054050:end -->
#### **Saturday, February 15, 2025**<!-- HN:43054889:start -->
* [43054889](https://news.social-protocols.org/stats?id=43054889) #5 7 points 6 comments -> [Executive Order for MAHA Commission](https://foodishealth.substack.com/p/breaking-executive-order-for-maha)<!-- HN:43054889:end --><!-- HN:43054829:start -->
* [43054829](https://news.social-protocols.org/stats?id=43054829) #11 -> [If JFK was setting us on a journey to cure Chronic Disease what might he say](https://foodishealth.substack.com/p/what-would-jfk-do)<!-- HN:43054829:end --><!-- HN:43054892:start -->
* [43054892](https://news.social-protocols.org/stats?id=43054892) #14 68 points 37 comments -> [Men claiming to be from DOGE show up at San Francisco City Hall, demand records](https://www.cbsnews.com/sanfrancisco/news/doge-3-men-show-up-at-sf-city-hall-demand-records/)<!-- HN:43054892:end --><!-- HN:43055087:start -->
* [43055087](https://news.social-protocols.org/stats?id=43055087) #21 5 points 1 comments -> [DOGE – these experts let their database open](https://web.archive.org/web/20250214084840/https://twitter.com/?mx=1)<!-- HN:43055087:end --><!-- HN:43055340:start -->
* [43055340](https://news.social-protocols.org/stats?id=43055340) #18 26 points 34 comments -> [Why We're Falling Out of Love with Tesla](https://worldcrunch.com/business-finance/tesla-sales-musk)<!-- HN:43055340:end --><!-- HN:43055660:start -->
* [43055660](https://news.social-protocols.org/stats?id=43055660) #7 13 points 0 comments -> [Tuvalu – The First Digital Nation](https://www.tuvalu.tv/)<!-- HN:43055660:end --><!-- HN:43055809:start -->
* [43055809](https://news.social-protocols.org/stats?id=43055809) #15 25 points 40 comments -> ["the Zooms don't show up" Jamie Dimon](https://www.mediaite.com/tv/leaked-audio-reveals-jp-morgan-ceo-going-off-on-young-staffers-wanting-to-work-from-home/)<!-- HN:43055809:end --><!-- HN:43055772:start -->
* [43055772](https://news.social-protocols.org/stats?id=43055772) #13 15 points 1 comments -> [Sunsetting Create React App](https://react.dev/blog/2025/02/14/sunsetting-create-react-app)<!-- HN:43055772:end --><!-- HN:43056993:start -->
* [43056993](https://news.social-protocols.org/stats?id=43056993) #17 39 points 40 comments -> [Are DOGE's Claims of Social Security Payments to 150-Year-Olds Way Off Base?](https://slashdot.org/submission/17333271/are-doges-claims-of-social-security-payments-to-150-year-olds-way-off-base)<!-- HN:43056993:end --><!-- HN:43057687:start -->
* [43057687](https://news.social-protocols.org/stats?id=43057687) #12 15 points 4 comments -> [Nouveau kernel maintainer steps down](https://lists.freedesktop.org/archives/nouveau/2025-February/046677.html)<!-- HN:43057687:end --><!-- HN:43057930:start -->
* [43057930](https://news.social-protocols.org/stats?id=43057930) #19 34 points 12 comments -> [Karol Herbst Steps Down as Nouveau Maintainer Due to Linux's Toxic Environment](https://www.phoronix.com/news/Karol-Herbst-Nouveau-No)<!-- HN:43057930:end --><!-- HN:43058346:start -->
* [43058346](https://news.social-protocols.org/stats?id=43058346) #11 64 points 20 comments -> [Gazeta Wyborcza, Poland's largest newspaper quits X, now on Bluesky](https://bsky.app/profile/blueskywins.bsky.social/post/3li7rxl3o2c2t)<!-- HN:43058346:end --><!-- HN:43054963:start -->
* [43054963](https://news.social-protocols.org/stats?id=43054963) #14 110 points 68 comments -> [Q2DOS – Quake 2 backported to MS-DOS](https://dk.toastednet.org/Q2DOS/)<!-- HN:43054963:end --><!-- HN:43058896:start -->
* [43058896](https://news.social-protocols.org/stats?id=43058896) #17 20 points 17 comments -> [The Unicorn Boom Is Over, and Startups Are Getting Desperate](https://www.bloomberg.com/news/articles/2025-02-14/silicon-valley-unicorn-startups-are-desperate-for-cash)<!-- HN:43058896:end --><!-- HN:43060062:start -->
* [43060062](https://news.social-protocols.org/stats?id=43060062) #16 7 points 2 comments -> [Sabine Hossenfelder – I was asked to keep this confidential [video]](https://www.youtube.com/watch?v=shFUDPqVmTg)<!-- HN:43060062:end --><!-- HN:43059965:start -->
* [43059965](https://news.social-protocols.org/stats?id=43059965) #25 4 points 0 comments -> [NIH's 15% Indirect Spending Cuts Hurt Hard Tech Startups](https://nanosilicon.com/f/slicing-up-budgets-in-hard-tech-startups)<!-- HN:43059965:end --><!-- HN:43060496:start -->
* [43060496](https://news.social-protocols.org/stats?id=43060496) #15 9 points 2 comments -> [Sabine Hossenfelder: I was asked to keep this confidential](https://www.youtube.com/watch?v=shFUDPqVmTg)<!-- HN:43060496:end --><!-- HN:43060218:start -->
* [43060218](https://news.social-protocols.org/stats?id=43060218) #23 16 points 0 comments -> [Honest Government Ad – Nuclear Power (Australia) [video]](https://www.youtube.com/watch?v=JBqVVBUdW84)<!-- HN:43060218:end --><!-- HN:43060928:start -->
* [43060928](https://news.social-protocols.org/stats?id=43060928) #14 8 points 1 comments -> [White House bans AP journalists from Oval Office amid continued Gulf dispute](https://www.theguardian.com/us-news/2025/feb/14/white-house-ap-ban-oval-office)<!-- HN:43060928:end --><!-- HN:43060655:start -->
* [43060655](https://news.social-protocols.org/stats?id=43060655) #28 16 points 3 comments -> [Electronic Frontier Foundation](https://www.eff.org/)<!-- HN:43060655:end --><!-- HN:43061148:start -->
* [43061148](https://news.social-protocols.org/stats?id=43061148) #4 5 points 1 comments -> [Will Google Search Be the Next to Join Killed by Google?](http://stan-kondrat.github.io//thoughts/google-search/)<!-- HN:43061148:end --><!-- HN:43028457:start -->
* [43028457](https://news.social-protocols.org/stats?id=43028457) #19 7 points 0 comments -> [Japanese food makers step in to preserve sake breweries' legacy](https://www.japantimes.co.jp/news/2025/01/30/japan/food-makers-sake-legacy/)<!-- HN:43028457:end --><!-- HN:43061554:start -->
* [43061554](https://news.social-protocols.org/stats?id=43061554) #20 11 points 3 comments -> [Leave Billionaires Alone](https://m-onz.net/leave-billionaires-alone)<!-- HN:43061554:end --><!-- HN:43062974:start -->
* [43062974](https://news.social-protocols.org/stats?id=43062974) #16 6 points 0 comments -> [New homes listed for sale is absolutely EXPLODING in Washington DC](https://twitter.com/VladTheInflator/status/1890432617205387557)<!-- HN:43062974:end -->
#### **Sunday, February 16, 2025**
<!-- HN:43063589:start -->
* [43063589](https://news.social-protocols.org/stats?id=43063589) #5 14 points 40 comments -> [Will AI take web developer jobs?](https://www.alpower.com/blog/2025-02-13-will-ai-take-web-developer-jobs/)<!-- HN:43063589:end --><!-- HN:43064359:start -->
* [43064359](https://news.social-protocols.org/stats?id=43064359) #21 40 points 9 comments -> [GulfOfMexico: Perfect Programming Language](https://github.com/TodePond/GulfOfMexico)<!-- HN:43064359:end --><!-- HN:43064547:start -->
* [43064547](https://news.social-protocols.org/stats?id=43064547) #23 18 points 6 comments -> [It's Time for a United Front to Take on Billionaire Rule](https://inthesetimes.com/article/labor-unions-trump-musk-doge-billionaires)<!-- HN:43064547:end --><!-- HN:43065095:start -->
* [43065095](https://news.social-protocols.org/stats?id=43065095) #23 10 points 19 comments -> [Alex Karp Wants Silicon Valley to Fight for America](https://www.wsj.com/tech/who-is-alex-karp-palantir-ceo-dcd66e21)<!-- HN:43065095:end --><!-- HN:43065498:start -->
* [43065498](https://news.social-protocols.org/stats?id=43065498) #29 7 points 0 comments -> [Modding the Gulf of Mexico Back (In Google Maps) [video]](https://www.youtube.com/watch?v=F5m2JxplnXk)<!-- HN:43065498:end --><!-- HN:43024471:start -->
* [43024471](https://news.social-protocols.org/stats?id=43024471) #16 9 points 1 comments -> [Age of Invention: How Coal Won](https://www.ageofinvention.xyz/p/age-of-invention-how-coal-really)<!-- HN:43024471:end --><!-- HN:43065757:start -->
* [43065757](https://news.social-protocols.org/stats?id=43065757) #7 44 points 25 comments -> [US Energy Department ending appliance efficiency standards](https://www.energy.gov/articles/energy-department-acts-lower-prices-and-increase-consumer-choice-household-appliances)<!-- HN:43065757:end --><!-- HN:43067193:start -->
* [43067193](https://news.social-protocols.org/stats?id=43067193) #21 6 points 2 comments -> [Cancel culture? We should stop it. End of story](https://www.theguardian.com/books/2025/feb/15/cancel-culture-we-should-stop-it-end-of-story-chimamanda-ngozi-adichie-on-backlash-writers-block-and-her-two-new-babies)<!-- HN:43067193:end --><!-- HN:43066993:start -->
* [43066993](https://news.social-protocols.org/stats?id=43066993) #23 8 points 3 comments -> [Stock Market and Financial Data API](https://financialdata.net)<!-- HN:43066993:end --><!-- HN:43069104:start -->
* [43069104](https://news.social-protocols.org/stats?id=43069104) #6 6 points 1 comments -> [I went viral with a silly startup](https://www.cyberpatterns.xyz/p/vc-subsidized)<!-- HN:43069104:end --><!-- HN:43069835:start -->
* [43069835](https://news.social-protocols.org/stats?id=43069835) #29 5 points 0 comments -> [He who saves his country, violates no law](https://en.wikipedia.org/wiki/He_who_saves_his_country,_violates_no_law)<!-- HN:43069835:end --><!-- HN:43061803:start -->
* [43061803](https://news.social-protocols.org/stats?id=43061803) #25 19 points 21 comments -> [Reasons to Not Parse Localized Strings](https://blog.sffc.xyz/post/190943794505/why-you-should-not-parse-localized-strings)<!-- HN:43061803:end --><!-- HN:43069973:start -->
* [43069973](https://news.social-protocols.org/stats?id=43069973) #27 7 points 0 comments -> ['Reading is part of my identity': the woman taking on Goodreads owner Amazon](https://www.theguardian.com/books/2025/feb/16/goodreads-amazon-nadia-odunayo-the-storygraph)<!-- HN:43069973:end --><!-- HN:43070946:start -->
* [43070946](https://news.social-protocols.org/stats?id=43070946) #20 59 points 7 comments -> [Top US Election Security Watchdog Forced to Stop Election Security Work](https://www.wired.com/story/cisa-election-security-freeze-memo/)<!-- HN:43070946:end --><!-- HN:43070643:start -->
* [43070643](https://news.social-protocols.org/stats?id=43070643) #9 6 points 2 comments -> [When Compilers Were the 'AI' That Scared Programmers](https://vivekhaldar.com/articles/when-compilers-were-the--ai--that-scared-programmers/)<!-- HN:43070643:end --><!-- HN:43071645:start -->
* [43071645](https://news.social-protocols.org/stats?id=43071645) #16 13 points 5 comments -> [You are all a bunch of sick freaks](https://selfh.st/sick-freaks/)<!-- HN:43071645:end --><!-- HN:43038141:start -->
* [43038141](https://news.social-protocols.org/stats?id=43038141) #17 4 points 0 comments -> [Solving a GitHub Mystery in Seconds](https://lumigo.io/blog/solving-a-github-mystery-in-seconds/)<!-- HN:43038141:end -->
#### **Monday, February 17, 2025**
<!-- HN:43072640:start -->
* [43072640](https://news.social-protocols.org/stats?id=43072640) #23 10 points 2 comments -> [Why Artificial General Intelligence Is and Remains a Fiction](https://osf.io/preprints/osf/fjcns_v1)<!-- HN:43072640:end --><!-- HN:43073773:start -->
* [43073773](https://news.social-protocols.org/stats?id=43073773) #15 19 points 8 comments -> [America will collapse by 2025 (2010)](https://www.salon.com/2010/12/06/america_collapse_2025/)<!-- HN:43073773:end --><!-- HN:43073481:start -->
* [43073481](https://news.social-protocols.org/stats?id=43073481) #5 13 points 5 comments -> [How to add a directory to your PATH](https://jvns.ca/blog/2025/02/13/how-to-add-a-directory-to-your-path/)<!-- HN:43073481:end --><!-- HN:43074155:start -->
* [43074155](https://news.social-protocols.org/stats?id=43074155) #14 38 points 11 comments -> [Elon Musk's terrifying vision for AI](https://garymarcus.substack.com/p/elon-musks-terrifying-vision-for)<!-- HN:43074155:end -->