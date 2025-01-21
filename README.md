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

#### **Wednesday, January 15, 2025**
<!-- HN:42708295:start -->
* [42708295](https://news.social-protocols.org/stats?id=42708295) #22 7 points 1 comments -> [Mark Zuckerberg Was Right to Fire Facebook's Rogue Fact-Checkers](https://reason.com/2025/01/07/mark-zuckerberg-meta-facebook-fact-checkers-censorship/)<!-- HN:42708295:end --><!-- HN:42707606:start -->
* [42707606](https://news.social-protocols.org/stats?id=42707606) #6 40 points 42 comments -> [I failed moving my Google calendar to Proton](https://shilin.ca/i-tried-moving-my-google-calendar-to-proton-and-failed/)<!-- HN:42707606:end --><!-- HN:42711412:start -->
* [42711412](https://news.social-protocols.org/stats?id=42711412) #13 7 points 0 comments -> [Your brain is lying to you about the “good old days”](https://www.vox.com/future-perfect/394872/past-present-selective-memory-progress-brain-science)<!-- HN:42711412:end --><!-- HN:42670789:start -->
* [42670789](https://news.social-protocols.org/stats?id=42670789) #8 5 points 1 comments -> [Early Iron Age horse sacrifice at a royal tomb in southern Siberia](https://www.cambridge.org/core/journals/antiquity/article/spectral-cavalcade-early-iron-age-horse-sacrifice-at-a-royal-tomb-in-southern-siberia/80E0B627528E00EA7C2AE4456F182DAC)<!-- HN:42670789:end --><!-- HN:42714147:start -->
* [42714147](https://news.social-protocols.org/stats?id=42714147) #25 6 points 2 comments -> [Israel, Hamas reach ceasefire agreement meant to end 15-month Gaza war](https://www.reuters.com/world/middle-east/gaza-ceasefire-appears-close-us-egyptian-leaders-put-focus-coming-hours-2025-01-14/)<!-- HN:42714147:end --><!-- HN:42714774:start -->
* [42714774](https://news.social-protocols.org/stats?id=42714774) #11 26 points 42 comments -> [Banning TikTok Is Unconstitutional. The Supreme Court Must Step In](https://www.aclu.org/news/national-security/banning-tiktok-is-unconstitutional-the-supreme-court-must-step-in)<!-- HN:42714774:end --><!-- HN:42715462:start -->
* [42715462](https://news.social-protocols.org/stats?id=42715462) #12 12 points 6 comments -> [Laptop](https://mijndertstuij.nl/posts/the-best-laptop-ever/)<!-- HN:42715462:end --><!-- HN:42716926:start -->
* [42716926](https://news.social-protocols.org/stats?id=42716926) #11 33 points 9 comments -> [The Trouble with Elon](https://samharris.substack.com/p/the-trouble-with-elon)<!-- HN:42716926:end --><!-- HN:42715475:start -->
* [42715475](https://news.social-protocols.org/stats?id=42715475) #23 5 points 1 comments -> [Israel and Hamas reach Gaza ceasefire and hostage deal](https://www.cnbc.com/2025/01/15/israel-hamas-ceasefire-hostage-deal-agreed-to-in-principle.html)<!-- HN:42715475:end --><!-- HN:42714920:start -->
* [42714920](https://news.social-protocols.org/stats?id=42714920) #2 54 points 23 comments -> [Gemini Advanced now included in Google Workspace](https://workspace.google.com/blog/product-announcements/empowering-businesses-with-AI)<!-- HN:42714920:end -->
#### **Thursday, January 16, 2025**
<!-- HN:42719704:start -->
* [42719704](https://news.social-protocols.org/stats?id=42719704) #28 7 points 0 comments -> [Microsoft engineer terminated for threatening Palestinians with genocide](https://twitter.com/StopArabHate/status/1879695601820131454)<!-- HN:42719704:end --><!-- HN:42721191:start -->
* [42721191](https://news.social-protocols.org/stats?id=42721191) #18 12 points 4 comments -> [Milei shuts down museums memorializing victims of Argentine dictatorship](https://www.wsws.org/en/articles/2025/01/11/jtng-j11.html)<!-- HN:42721191:end --><!-- HN:42724179:start -->
* [42724179](https://news.social-protocols.org/stats?id=42724179) #6 5 points 1 comments -> [Strategies to Complete Tasks with ADHD](https://schroedermelanie.com/adhs-nichts-zuende-bringen/)<!-- HN:42724179:end --><!-- HN:42724823:start -->
* [42724823](https://news.social-protocols.org/stats?id=42724823) #14 165 points 120 comments -> [Nintendo Switch 2](https://www.nintendo.com/successor/en-gb/index.html)<!-- HN:42724823:end --><!-- HN:42723543:start -->
* [42723543](https://news.social-protocols.org/stats?id=42723543) #18 31 points 40 comments -> [Is there such a thing as a web-safe font?](https://www.highperformancewebfonts.com/read/web-safe-fonts)<!-- HN:42723543:end --><!-- HN:42727174:start -->
* [42727174](https://news.social-protocols.org/stats?id=42727174) #24 4 points 1 comments -> [You Blamed DEI for Hurting Your Career. Now What?](https://www.wsj.com/lifestyle/careers/you-blamed-dei-for-hurting-your-career-now-what-6150c575)<!-- HN:42727174:end --><!-- HN:42728967:start -->
* [42728967](https://news.social-protocols.org/stats?id=42728967) #7 147 points 7 comments -> [David Lynch, Twin Peaks and Muholland Drive director, dies aged 78](https://www.theguardian.com/film/2025/jan/16/david-lynch-twin-peaks-and-muholland-drive-director-dies-aged-78)<!-- HN:42728967:end --><!-- HN:42729347:start -->
* [42729347](https://news.social-protocols.org/stats?id=42729347) #29 26 points 8 comments -> [The Washington Post kills off its "Democracy Dies In Darkness" slogan](https://www.avclub.com/washington-post-kills-democracy-dies-in-darkness-slogan)<!-- HN:42729347:end --><!-- HN:42685018:start -->
* [42685018](https://news.social-protocols.org/stats?id=42685018) #17 8 points 3 comments -> [Cosine Similarity Isn't the Silver Bullet We Thought It Was](https://www.shaped.ai/blog/cosine-similarity-not-the-silver-bullet-we-thought-it-was)<!-- HN:42685018:end -->
#### **Friday, January 17, 2025**
<!-- HN:42735976:start -->
* [42735976](https://news.social-protocols.org/stats?id=42735976) #21 20 points 11 comments -> [Show HN: I built a credit-based system API](https://creduse.com/#features-grid)<!-- HN:42735976:end --><!-- HN:42736705:start -->
* [42736705](https://news.social-protocols.org/stats?id=42736705) #2 8 points 5 comments -> [Rumor About GPT-5 Changes Everything](https://www.thealgorithmicbridge.com/p/this-rumor-about-gpt-5-changes-everything)<!-- HN:42736705:end --><!-- HN:42680318:start -->
* [42680318](https://news.social-protocols.org/stats?id=42680318) #15 99 points 6 comments -> [Slum: The Shadow Library Uptime Monitor](https://open-slum.org/)<!-- HN:42680318:end --><!-- HN:42731962:start -->
* [42731962](https://news.social-protocols.org/stats?id=42731962) #16 243 points 170 comments -> [Some things to expect in 2025](https://lwn.net/Articles/1003780/)<!-- HN:42731962:end --><!-- HN:42738118:start -->
* [42738118](https://news.social-protocols.org/stats?id=42738118) #15 3 points 0 comments -> [BambuLabs removing 3rd party access to its printers](https://old.reddit.com/r/BambuLab/comments/1i3gq1t/why_you_should_care_about_bambu_labs_removing/)<!-- HN:42738118:end --><!-- HN:42736442:start -->
* [42736442](https://news.social-protocols.org/stats?id=42736442) #15 7 points 2 comments -> [Scaling to users requires Synapse Pro](https://element.io/blog/scaling-to-millions-of-users-requires-synapse-pro/)<!-- HN:42736442:end --><!-- HN:42737005:start -->
* [42737005](https://news.social-protocols.org/stats?id=42737005) #26 8 points 0 comments -> [Go 1.24 Interactive Tour](https://antonz.org/go-1-24/)<!-- HN:42737005:end --><!-- HN:42738333:start -->
* [42738333](https://news.social-protocols.org/stats?id=42738333) #24 3 points 0 comments -> [Phishing with Gmail's Gemini Summarize via prompt injection](https://twitter.com/makesxi/status/1880271032122241188)<!-- HN:42738333:end --><!-- HN:42740385:start -->
* [42740385](https://news.social-protocols.org/stats?id=42740385) #23 6 points 0 comments -> [Octopus overtakes British Gas as Britain's largest household energy supplier](https://www.theguardian.com/business/2025/jan/17/octopus-overtakes-british-gas-as-britains-largest-household-energy-supplier)<!-- HN:42740385:end --><!-- HN:42741880:start -->
* [42741880](https://news.social-protocols.org/stats?id=42741880) #29 9 points 0 comments -> [Undocumented Immigrant Offending Rate Lower Than U.S.-Born Citizen Rate](https://nij.ojp.gov/topics/articles/undocumented-immigrant-offending-rate-lower-us-born-citizen-rate)<!-- HN:42741880:end --><!-- HN:42742123:start -->
* [42742123](https://news.social-protocols.org/stats?id=42742123) #14 7 points 1 comments -> [Brits still associate working-class accents with criminals – study warns of bias](https://www.cam.ac.uk/research/news/brits-still-associate-working-class-accents-with-criminal-behaviour-study-warns-of-bias-in-the)<!-- HN:42742123:end --><!-- HN:42742462:start -->
* [42742462](https://news.social-protocols.org/stats?id=42742462) #29 5 points 0 comments -> [Show HN: Compile C to Not Gates](https://pypi.org/project/c2fj/)<!-- HN:42742462:end --><!-- HN:42743405:start -->
* [42743405](https://news.social-protocols.org/stats?id=42743405) #24 10 points 4 comments -> [How do playing cards work? No one knows](https://www.polygon.com/videos/506918/playing-cards-history)<!-- HN:42743405:end -->
#### **Saturday, January 18, 2025**
<!-- HN:42706890:start -->
* [42706890](https://news.social-protocols.org/stats?id=42706890) #20 7 points 0 comments -> [Grand Harbour of Malta Tornado](https://en.wikipedia.org/wiki/Grand_Harbour_of_Malta_tornado)<!-- HN:42706890:end --><!-- HN:42745771:start -->
* [42745771](https://news.social-protocols.org/stats?id=42745771) #22 38 points 13 comments -> [The Los Angeles wildfires are self-inflicted](https://caseyhandmer.wordpress.com/2025/01/17/the-los-angeles-wildfires-are-self-inflicted/)<!-- HN:42745771:end --><!-- HN:42747597:start -->
* [42747597](https://news.social-protocols.org/stats?id=42747597) #15 6 points 0 comments -> [MIT Shuts Down Internal Grant Database Used to Research School's Israel Ties](https://theintercept.com/2025/01/16/mit-israel-military-funding-research-gaza/)<!-- HN:42747597:end --><!-- HN:42747782:start -->
* [42747782](https://news.social-protocols.org/stats?id=42747782) #23 10 points 1 comments -> [FB fact checks were never going to save us. They just made liberals feel better](https://theintercept.com/2025/01/07/facebook-fact-check-mark-zuckerberg-trump/)<!-- HN:42747782:end --><!-- HN:42746752:start -->
* [42746752](https://news.social-protocols.org/stats?id=42746752) #25 9 points 2 comments -> [Show HN: I made a mini golf in my lunch time](https://paper-golf.netlify.app/)<!-- HN:42746752:end --><!-- HN:42748963:start -->
* [42748963](https://news.social-protocols.org/stats?id=42748963) #23 27 points 33 comments -> [Is Atlas Shrugged the New Vibe?](https://www.commonreader.co.uk/p/is-atlas-shrugged-the-new-vibe)<!-- HN:42748963:end --><!-- HN:42750473:start -->
* [42750473](https://news.social-protocols.org/stats?id=42750473) #20 8 points 1 comments -> [US Debt Clock](https://www.usdebtclock.org/)<!-- HN:42750473:end --><!-- HN:42750154:start -->
* [42750154](https://news.social-protocols.org/stats?id=42750154) #20 6 points 5 comments -> [Redesigning UI/UX so AI can use software](https://fromzero.ghost.io/redesigning-browser-ux-ui-what-ai-agents-expect-and-need/)<!-- HN:42750154:end --><!-- HN:42751627:start -->
* [42751627](https://news.social-protocols.org/stats?id=42751627) #24 6 points 0 comments -> [More than 1,100 inmates help Cal Fire battle for less than $30 a day](https://abc7.com/post/inmates-work-less-30-day-help-cal-fire-battle-eaton-palisades-fires/15813591/)<!-- HN:42751627:end -->
#### **Sunday, January 19, 2025**<!-- HN:42753591:start -->
* [42753591](https://news.social-protocols.org/stats?id=42753591) #26 4 points 1 comments -> [TikTok has officially shut down in the United States](https://9to5mac.com/2025/01/18/tiktok-is-officially-shutting-down-in-the-united-states/)<!-- HN:42753591:end --><!-- HN:42756648:start -->
* [42756648](https://news.social-protocols.org/stats?id=42756648) #30 3 points 0 comments -> [Bob Dylan's drafts for Mr Tambourine Man sell for more than £400k](https://www.theguardian.com/music/2025/jan/18/bob-dylans-drafts-for-mr-tambourine-man-sell-for-more-than-400000)<!-- HN:42756648:end --><!-- HN:42708974:start -->
* [42708974](https://news.social-protocols.org/stats?id=42708974) #19 95 points 8 comments -> [Beating cuBLAS in Single-Precision General Matrix Multiplication](https://salykova.github.io/sgemm-gpu)<!-- HN:42708974:end --><!-- HN:42757161:start -->
* [42757161](https://news.social-protocols.org/stats?id=42757161) #23 6 points 1 comments -> [Coming soon: PhD-level super-agents](https://www.axios.com/2025/01/19/ai-superagent-openai-meta)<!-- HN:42757161:end --><!-- HN:42757140:start -->
* [42757140](https://news.social-protocols.org/stats?id=42757140) #25 5 points 2 comments -> [Young people are hanging out less – it may be harming their mental health](https://www.ft.com/content/23053544-fede-4c0d-8cda-174e9bdce348)<!-- HN:42757140:end --><!-- HN:42733593:start -->
* [42733593](https://news.social-protocols.org/stats?id=42733593) #12 -> [Alignment faking in large language models](https://www.lesswrong.com/posts/njAZwT8nkHnjipJku/alignment-faking-in-large-language-models)<!-- HN:42733593:end --><!-- HN:42759330:start -->
* [42759330](https://news.social-protocols.org/stats?id=42759330) #1 25 points 15 comments -> [TikTok is back after executive order stalling ban](https://twitter.com/tiktokpolicy/status/1881030712188346459)<!-- HN:42759330:end --><!-- HN:42758809:start -->
* [42758809](https://news.social-protocols.org/stats?id=42758809) #3 15 points 3 comments -> [Mark Zuckerberg paid lobby$7.6M to aid in TikTok ban](https://readsludge.com/2024/04/23/meta-shatters-lobbying-record-as-house-passes-tiktok-ban/)<!-- HN:42758809:end --><!-- HN:42759925:start -->
* [42759925](https://news.social-protocols.org/stats?id=42759925) #14 6 points 1 comments -> [The tech oligarchy has been here for years](https://www.bloodinthemachine.com/p/the-tech-oligarchy-has-been-here)<!-- HN:42759925:end --><!-- HN:42759107:start -->
* [42759107](https://news.social-protocols.org/stats?id=42759107) #19 4 points 2 comments -> [Is RTO the biggest mistake tech companies are making in 2025?](https://www.behindhrdoors.com/p/why-tech-firms-are-failing-at-return-to-office-plans)<!-- HN:42759107:end -->
#### **Monday, January 20, 2025**
<!-- HN:42762972:start -->
* [42762972](https://news.social-protocols.org/stats?id=42762972) #14 4 points 0 comments -> [The Former Israeli Spies Building AI Systems at Global Tech Companies](https://www.donotpanic.news/p/the-former-israeli-spies-building)<!-- HN:42762972:end --><!-- HN:42764108:start -->
* [42764108](https://news.social-protocols.org/stats?id=42764108) #5 13 points 6 comments -> [F-Droid Security Issues](https://privsec.dev/posts/android/f-droid-security-issues/)<!-- HN:42764108:end --><!-- HN:42767995:start -->
* [42767995](https://news.social-protocols.org/stats?id=42767995) #20 3 points 3 comments -> [Trump's Day One Executive Order on 'Male and Female'](https://www.thefp.com/p/trumps-day-one-executive-order-male-female-gender-ideology-pronouns)<!-- HN:42767995:end --><!-- HN:42768081:start -->
* [42768081](https://news.social-protocols.org/stats?id=42768081) #19 3 points 0 comments -> [GM faces ban on selling driver data that can be used to raise insurance rates](https://arstechnica.com/tech-policy/2025/01/gm-faces-ban-on-selling-driver-data-that-can-be-used-to-raise-insurance-rates/)<!-- HN:42768081:end --><!-- HN:42758070:start -->
* [42758070](https://news.social-protocols.org/stats?id=42758070) #20 216 points 50 comments -> [Build a tiny CA for your homelab with a Raspberry Pi](https://smallstep.com/blog/build-a-tiny-ca-with-raspberry-pi-yubikey/)<!-- HN:42758070:end --><!-- HN:42768046:start -->
* [42768046](https://news.social-protocols.org/stats?id=42768046) #1 7 points 2 comments -> [You don't need a JavaScript framework to build websites](https://velocity-core.etribes.de/)<!-- HN:42768046:end --><!-- HN:42766715:start -->
* [42766715](https://news.social-protocols.org/stats?id=42766715) #22 4 points 3 comments -> [Play your favourite retro games online](https://playclassic.games/games/)<!-- HN:42766715:end --><!-- HN:42766637:start -->
* [42766637](https://news.social-protocols.org/stats?id=42766637) #20 36 points 14 comments -> [The real motivation behind systemd (2018)](https://unixdigest.com/articles/the-real-motivation-behind-systemd.html)<!-- HN:42766637:end --><!-- HN:42766725:start -->
* [42766725](https://news.social-protocols.org/stats?id=42766725) #27 38 points 13 comments -> [Google serving sponsored link to Homebrew site clone with malware](https://twitter.com/ryanchenkie/status/1880730173634699393)<!-- HN:42766725:end --><!-- HN:42769591:start -->
* [42769591](https://news.social-protocols.org/stats?id=42769591) #18 5 points 1 comments -> [Facebook, X, YouTube to do more against online hate speech, EU says](https://www.reuters.com/technology/facebook-x-youtube-do-more-against-online-hate-speech-eu-says-2025-01-20/)<!-- HN:42769591:end --><!-- HN:42770353:start -->
* [42770353](https://news.social-protocols.org/stats?id=42770353) #24 4 points 1 comments -> [Spain's PM Sanchez floats ban on non-EU citizens buying properties](https://www.reuters.com/world/europe/spains-pm-sanchez-floats-ban-non-eu-citizens-buying-properties-2025-01-20/)<!-- HN:42770353:end --><!-- HN:42770448:start -->
* [42770448](https://news.social-protocols.org/stats?id=42770448) #23 3 points 1 comments -> [Changes to Google Maps Platform Pricing](https://developers.google.com/maps/billing-and-pricing/faq)<!-- HN:42770448:end --><!-- HN:42770421:start -->
* [42770421](https://news.social-protocols.org/stats?id=42770421) #23 3 points 0 comments -> [Suspects allegedly posing as firefighters in Palisades had fake fire engine](https://ktla.com/news/local-news/suspects-allegedly-posing-as-firefighters-in-palisades-had-fake-fire-engine/)<!-- HN:42770421:end --><!-- HN:42770484:start -->
* [42770484](https://news.social-protocols.org/stats?id=42770484) #27 4 points 1 comments -> [Announcement: S3 Default Integrity Change](https://github.com/aws/aws-sdk-js-v3/issues/6810)<!-- HN:42770484:end --><!-- HN:42770178:start -->
* [42770178](https://news.social-protocols.org/stats?id=42770178) #20 18 points 7 comments -> [What is there left to believe in?](https://www.noahpinion.blog/p/what-is-there-left-to-believe-in)<!-- HN:42770178:end --><!-- HN:42771803:start -->
* [42771803](https://news.social-protocols.org/stats?id=42771803) #22 3 points 1 comments -> [Seven planets are lining up in the sky next month. This is what it means](https://www.bbc.com/future/article/20250117-planetary-parade-what-the-alignment-of-seven-planets-really-means-for-science)<!-- HN:42771803:end --><!-- HN:42772044:start -->
* [42772044](https://news.social-protocols.org/stats?id=42772044) #21 6 points 2 comments -> [The White House](https://www.whitehouse.gov/)<!-- HN:42772044:end --><!-- HN:42773915:start -->
* [42773915](https://news.social-protocols.org/stats?id=42773915) #21 10 points 0 comments -> [Yes, Climate Change Is Probably Going to Kill You](https://predicament.substack.com/p/what-most-people-dont-understand)<!-- HN:42773915:end --><!-- HN:42729488:start -->
* [42729488](https://news.social-protocols.org/stats?id=42729488) #27 96 points 210 comments -> [Dutch Align with US Export Controls on Some ASML Chip Tools](https://www.bloomberg.com/news/articles/2025-01-15/dutch-align-with-us-export-controls-on-some-asml-chip-tools)<!-- HN:42729488:end --><!-- HN:42773831:start -->
* [42773831](https://news.social-protocols.org/stats?id=42773831) #23 10 points 0 comments -> [US safety regulators expand Ford hands-free driving tech investigation](https://techcrunch.com/2025/01/20/us-safety-regulators-expand-ford-hands-free-driving-tech-investigation/)<!-- HN:42773831:end -->
#### **Tuesday, January 21, 2025**
<!-- HN:42773311:start -->
* [42773311](https://news.social-protocols.org/stats?id=42773311) #5 98 points 39 comments -> [Matt Mullenweg, Automattic's CEO, Seems Bound and Determined to Wreck WordPress](https://digitalcxo.com/article/matt-mullenweg-automattics-ceo-seems-bound-and-determined-to-wreck-wordpress/)<!-- HN:42773311:end -->