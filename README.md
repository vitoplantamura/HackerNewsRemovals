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

#### **Saturday, October 26, 2024**
<!-- HN:41951215:start -->
* [41951215](https://news.social-protocols.org/stats?id=41951215) #28 9 points 1 comments -> [Wikipedia Put a Near Total Ban on Calling Gaza Health Ministry "Hamas-Run"](https://jewishjournal.com/news/united-states/376157/wikipedia-editors-place-a-near-total-ban-on-calling-gaza-health-ministry-hamas-run/)<!-- HN:41951215:end --><!-- HN:41951972:start -->
* [41951972](https://news.social-protocols.org/stats?id=41951972) #4 6 points 5 comments -> [Cqwrteur's fork of Linux kernel, rename it to Cinux](https://github.com/Cqinux/cinux)<!-- HN:41951972:end --><!-- HN:41952120:start -->
* [41952120](https://news.social-protocols.org/stats?id=41952120) #25 5 points 0 comments -> [Israel strikes military targets in Iran](https://www.washingtonpost.com/world/2024/10/25/israel-iran-attack-war-strikes/)<!-- HN:41952120:end --><!-- HN:41951773:start -->
* [41951773](https://news.social-protocols.org/stats?id=41951773) #25 85 points 30 comments -> [Russia amplified hurricane disinformation to drive Americans apart](https://abc7chicago.com/post/russia-amplified-hurricane-disinformation-drive-americans-apart-researchers-find/15463309/)<!-- HN:41951773:end --><!-- HN:41952375:start -->
* [41952375](https://news.social-protocols.org/stats?id=41952375) #23 6 points 1 comments -> [Tesla headquarters spills gallons of lime-green liquid into Bay Area street](https://www.sfgate.com/tech/article/tesla-spills-lime-green-liquid-19863951.php)<!-- HN:41952375:end --><!-- HN:41916143:start -->
* [41916143](https://news.social-protocols.org/stats?id=41916143) #6 7 points 1 comments -> [Solving the Mystery of ARM7TDMI Multiply Carry Flag](https://bmchtech.github.io/post/multiply/)<!-- HN:41916143:end --><!-- HN:41953494:start -->
* [41953494](https://news.social-protocols.org/stats?id=41953494) #24 34 points 27 comments -> [On Linux MAINTAINERS file removal of Russian developers](https://laforge.gnumonks.org/blog/20241025-linux-maintainers-russian/)<!-- HN:41953494:end --><!-- HN:41954445:start -->
* [41954445](https://news.social-protocols.org/stats?id=41954445) #22 36 points 34 comments -> [Lily Allen Says Her OnlyFans Feet Pictures Make More Money Than Spotify Streams](https://variety.com/2024/music/news/lily-allen-onlyfans-feet-pictures-spotify-1236191247/)<!-- HN:41954445:end --><!-- HN:41954755:start -->
* [41954755](https://news.social-protocols.org/stats?id=41954755) #8 8 points 4 comments -> [Hacktoberfest 2024](https://hacktoberfest.com)<!-- HN:41954755:end --><!-- HN:41955754:start -->
* [41955754](https://news.social-protocols.org/stats?id=41955754) #2 -> ["Twitch or Terrorist?", A Game](https://www.twitchorterrorist.com/)<!-- HN:41955754:end --><!-- HN:41956080:start -->
* [41956080](https://news.social-protocols.org/stats?id=41956080) #13 43 points 11 comments -> [35% Faster Than the Filesystem](https://www.sqlite.org/fasterthanfs.html)<!-- HN:41956080:end --><!-- HN:41956788:start -->
* [41956788](https://news.social-protocols.org/stats?id=41956788) #10 11 points 0 comments -> [Microsoft fires employees who organized vigil for Palestinians killed in Gaza](https://apnews.com/article/microsoft-fired-workers-israel-palestinians-gaza-72de6fe1f35db9398e3b6785203c6bbf)<!-- HN:41956788:end --><!-- HN:41956759:start -->
* [41956759](https://news.social-protocols.org/stats?id=41956759) #23 5 points 1 comments -> [1933 and the Definition of Fascism](https://acoup.blog/2024/10/25/new-acquisitions-1933-and-the-definition-of-fascism/)<!-- HN:41956759:end --><!-- HN:41914835:start -->
* [41914835](https://news.social-protocols.org/stats?id=41914835) #5 60 points 13 comments -> [Vampire Number](https://mathworld.wolfram.com/VampireNumber.html)<!-- HN:41914835:end --><!-- HN:41909933:start -->
* [41909933](https://news.social-protocols.org/stats?id=41909933) #21 43 points 72 comments -> [Adaptation to high-altitude hypoxia on the Tibetan Plateau](https://www.sciencealert.com/humans-are-evolving-right-before-our-eyes-on-the-tibetan-plateau)<!-- HN:41909933:end --><!-- HN:41913319:start -->
* [41913319](https://news.social-protocols.org/stats?id=41913319) #22 60 points 75 comments -> [Marketing the Odin programming language is weird](http://www.gingerbill.org/article/2024/09/08/odin-weird-to-market/)<!-- HN:41913319:end --><!-- HN:41957829:start -->
* [41957829](https://news.social-protocols.org/stats?id=41957829) #19 83 points 24 comments -> [Bullenweg.com is no longer available following threats of legal action](https://bullenweg.com/)<!-- HN:41957829:end --><!-- HN:41958309:start -->
* [41958309](https://news.social-protocols.org/stats?id=41958309) #7 6 points 0 comments -> [Microsoft fires employees who organized vigil for Palestinians killed in Gaza](https://apnews.com/article/microsoft-fired-workers-israel-palestinians-gaza-72de6fe1f35db9398e3b6785203c6bbf)<!-- HN:41958309:end -->
#### **Sunday, October 27, 2024**
<!-- HN:41960114:start -->
* [41960114](https://news.social-protocols.org/stats?id=41960114) #25 6 points 3 comments -> [Google to develop AI that takes over computers, The Information reports](https://www.reuters.com/technology/artificial-intelligence/google-develop-ai-that-takes-over-computers-information-reports-2024-10-26/)<!-- HN:41960114:end --><!-- HN:41961469:start -->
* [41961469](https://news.social-protocols.org/stats?id=41961469) #18 5 points 0 comments -> [It's now the Washington Post humor writer's job to endorse Harris for president](https://www.washingtonpost.com/opinions/2024/10/26/washington-post-endorses-kamala-harris-satire/)<!-- HN:41961469:end --><!-- HN:41961391:start -->
* [41961391](https://news.social-protocols.org/stats?id=41961391) #12 10 points 10 comments -> [UK sleep experts say it's time to kill daylight saving for good](https://www.theregister.com/2024/10/27/abolish_daylight_saving_time/)<!-- HN:41961391:end --><!-- HN:41933527:start -->
* [41933527](https://news.social-protocols.org/stats?id=41933527) #12 8 points 0 comments -> [A brief history of Notion's data catalog](https://www.notion.so/blog/a-brief-history-of-notions-data-catalog)<!-- HN:41933527:end --><!-- HN:41935319:start -->
* [41935319](https://news.social-protocols.org/stats?id=41935319) #14 19 points 14 comments -> [Comparison of configuration file languages (2016)](https://gist.github.com/njsmith/78f68204c5d969f8c8bc645ef77d4a8f)<!-- HN:41935319:end --><!-- HN:41915978:start -->
* [41915978](https://news.social-protocols.org/stats?id=41915978) #23 63 points 69 comments -> [Order and orient the keys on your keychain](https://practicalbetterments.com/order-and-orient-the-keys-on-your-keychain/)<!-- HN:41915978:end --><!-- HN:41960124:start -->
* [41960124](https://news.social-protocols.org/stats?id=41960124) #14 41 points 1 comments -> [DragonRuby Game Toolkit hits v6.0](https://dragonruby.itch.io/dragonruby-gtk/devlog/809843/dragonruby-hits-v60)<!-- HN:41960124:end --><!-- HN:41918354:start -->
* [41918354](https://news.social-protocols.org/stats?id=41918354) #17 3 points 2 comments -> [Humans Are Evolving Right Before Our Eyes on the Tibetan Plateau](https://www.sciencealert.com/humans-are-evolving-right-before-our-eyes-on-the-tibetan-plateau)<!-- HN:41918354:end --><!-- HN:41961356:start -->
* [41961356](https://news.social-protocols.org/stats?id=41961356) #7 26 points 17 comments -> [Some people with ADHD thrive in periods of stress, new study shows](https://www.theguardian.com/us-news/2024/oct/26/adhd-symptoms-high-stress)<!-- HN:41961356:end --><!-- HN:41961550:start -->
* [41961550](https://news.social-protocols.org/stats?id=41961550) #20 4 points 0 comments -> [Decomplexifying Curl](https://daniel.haxx.se/blog/2024/10/27/decomplexifying-curl/)<!-- HN:41961550:end --><!-- HN:41960843:start -->
* [41960843](https://news.social-protocols.org/stats?id=41960843) #29 9 points 0 comments -> ['We took on Google and they were forced to pay out £2B'](https://www.bbc.co.uk/news/articles/cjr431lr72jo)<!-- HN:41960843:end --><!-- HN:41960011:start -->
* [41960011](https://news.social-protocols.org/stats?id=41960011) #18 51 points 10 comments -> [Codeberg Reconsidering OSI License Approval in Terms of Use](https://codeberg.org/Codeberg/Community/issues/1654)<!-- HN:41960011:end --><!-- HN:41959324:start -->
* [41959324](https://news.social-protocols.org/stats?id=41959324) #29 8 points 0 comments -> [A16 Technology](https://www.tsmc.com/english/dedicatedFoundry/technology/logic/l_A16)<!-- HN:41959324:end --><!-- HN:41962411:start -->
* [41962411](https://news.social-protocols.org/stats?id=41962411) #14 15 points 13 comments -> [Scientists developed a novel method to detect lies](https://www.universal-sci.com/headlines/2020/12/17/spotting-liars-is-hard-but-our-new-method-is-effective-and-ethical)<!-- HN:41962411:end --><!-- HN:41963083:start -->
* [41963083](https://news.social-protocols.org/stats?id=41963083) #15 4 points 0 comments -> [Microsoft fires employees who organized vigil for Palestinians killed in Gaza](https://apnews.com/article/microsoft-fired-workers-israel-palestinians-gaza-72de6fe1f35db9398e3b6785203c6bbf)<!-- HN:41963083:end --><!-- HN:41962569:start -->
* [41962569](https://news.social-protocols.org/stats?id=41962569) #8 8 points 0 comments -> [Show HN: I Built a Tech Stack Recommender](https://boilerplatehub.com/tech-stack-recommender)<!-- HN:41962569:end --><!-- HN:41962983:start -->
* [41962983](https://news.social-protocols.org/stats?id=41962983) #3 19 points 10 comments -> [The Blowout No One Sees Coming](https://app.vantagedatahouse.com/analysis/TheBlowoutNoOneSeesComing-1)<!-- HN:41962983:end --><!-- HN:41962820:start -->
* [41962820](https://news.social-protocols.org/stats?id=41962820) #25 7 points 5 comments -> [Don't use Summer and Winter for event invites, it's "northern" and not inclusive](https://www.nature.com/articles/d41586-024-03245-0)<!-- HN:41962820:end --><!-- HN:41962901:start -->
* [41962901](https://news.social-protocols.org/stats?id=41962901) #17 14 points 2 comments -> [Cissp Cheatsheet](https://old.reddit.com/r/cissp/comments/uzpwcw/cissp_cheatsheet_for_exam_preparation/)<!-- HN:41962901:end --><!-- HN:41962480:start -->
* [41962480](https://news.social-protocols.org/stats?id=41962480) #14 6 points 0 comments -> [Mathematics for Computer Science [pdf]](https://courses.csail.mit.edu/6.042/spring18/mcs.pdf)<!-- HN:41962480:end --><!-- HN:41961149:start -->
* [41961149](https://news.social-protocols.org/stats?id=41961149) #23 11 points 0 comments -> [Wafer Scale – Trilogy Systems: Part 2](https://thechipletter.substack.com/p/wafer-scale-trilogy-systems-part-359)<!-- HN:41961149:end --><!-- HN:41962757:start -->
* [41962757](https://news.social-protocols.org/stats?id=41962757) #11 4 points 0 comments -> [The Knowledge Graph: things, not strings (2012)](https://blog.google/products/search/introducing-knowledge-graph-things-not/)<!-- HN:41962757:end --><!-- HN:41962627:start -->
* [41962627](https://news.social-protocols.org/stats?id=41962627) #27 8 points 1 comments -> [Privacy4Cars](https://privacy4cars.com/)<!-- HN:41962627:end --><!-- HN:41926070:start -->
* [41926070](https://news.social-protocols.org/stats?id=41926070) #17 10 points 4 comments -> [A Deep Dive into German Strings](https://cedardb.com/blog/strings_deep_dive/)<!-- HN:41926070:end --><!-- HN:41963890:start -->
* [41963890](https://news.social-protocols.org/stats?id=41963890) #15 11 points 1 comments -> [ModelKit: Transforming AI/ML artifact sharing and management across lifecycles](https://kitops.ml/docs/modelkit/intro.html)<!-- HN:41963890:end --><!-- HN:41963906:start -->
* [41963906](https://news.social-protocols.org/stats?id=41963906) #20 13 points 4 comments -> [What Is a Raspberry Pi AI Kit?](https://raspberrytips.com/what-is-raspberry-pi-ai-kit/)<!-- HN:41963906:end -->
#### **Monday, October 28, 2024**
<!-- HN:41966711:start -->
* [41966711](https://news.social-protocols.org/stats?id=41966711) #26 8 points 1 comments -> [Microsoft fires employees who organized vigil for Palestinians killed in Gaza](https://www.seattletimes.com/business/microsoft-fires-employees-who-organized-vigil-for-palestinians-killed-in-gaza/)<!-- HN:41966711:end --><!-- HN:41967293:start -->
* [41967293](https://news.social-protocols.org/stats?id=41967293) #9 18 points 1 comments -> [Japan's Jimi 'Mundane' Halloween Costumes of 2024](https://www.spoon-tamago.com/jimi-mundane-halloween-2024/)<!-- HN:41967293:end --><!-- HN:41968008:start -->
* [41968008](https://news.social-protocols.org/stats?id=41968008) #21 10 points 2 comments -> [Digital Nomads Are Exploiting the World](https://www.thrillist.com/travel/nation/digital-nomads-criticism-locals-exploitation)<!-- HN:41968008:end --><!-- HN:41925216:start -->
* [41925216](https://news.social-protocols.org/stats?id=41925216) #13 12 points 7 comments -> [Did DORA's last update create an encryption loophole?](https://evervault.com/blog/did-dora-s-last-update-create-an-encryption-loophole)<!-- HN:41925216:end --><!-- HN:41968744:start -->
* [41968744](https://news.social-protocols.org/stats?id=41968744) #1 12 points 4 comments -> [Why Google Search Is Falling Apart?](https://wpxplore.com/google-search-is-falling-apart/)<!-- HN:41968744:end --><!-- HN:41969327:start -->
* [41969327](https://news.social-protocols.org/stats?id=41969327) #1 26 points 1 comments -> [How to Build Your Career in AI [pdf]](https://wordpress.deeplearning.ai/wp-content/uploads/2022/10/eBook-How-to-Build-a-Career-in-AI.pdf)<!-- HN:41969327:end --><!-- HN:41967147:start -->
* [41967147](https://news.social-protocols.org/stats?id=41967147) #9 59 points 114 comments -> [Could you pass this 8th grade test from 1912?](https://onepercentrule.substack.com/p/could-you-pass-this-8th-grade-test)<!-- HN:41967147:end --><!-- HN:41940394:start -->
* [41940394](https://news.social-protocols.org/stats?id=41940394) #7 8 points 2 comments -> [Preserved tracks suggest non-avian dinosaurs used their wings to run](https://www.newscientist.com/article/2452672-preserved-tracks-suggest-non-avian-dinosaurs-used-their-wings-to-run/)<!-- HN:41940394:end --><!-- HN:41970413:start -->
* [41970413](https://news.social-protocols.org/stats?id=41970413) #2 10 points 0 comments -> [Microsoft fires employees who organized vigil for Palestinians killed in Gaza](https://apnews.com/article/microsoft-fired-workers-israel-palestinians-gaza-72de6fe1f35db9398e3b6785203c6bbf)<!-- HN:41970413:end --><!-- HN:41971060:start -->
* [41971060](https://news.social-protocols.org/stats?id=41971060) #8 15 points 2 comments -> [M-series MacBook SSD storage upgrade (non-official) [video]](https://www.youtube.com/watch?v=E3N-z-Y8cuw)<!-- HN:41971060:end --><!-- HN:41947881:start -->
* [41947881](https://news.social-protocols.org/stats?id=41947881) #6 10 points 2 comments -> [x86 Early Kernel Boot Process with Microcode, ACPI Overrides, and Initrd](https://labcsmart.com/x86-platforms-part-3-early-kernel-boot-process-with-microcode-acpi-override-and-initrd/)<!-- HN:41947881:end --><!-- HN:41972610:start -->
* [41972610](https://news.social-protocols.org/stats?id=41972610) #23 9 points 2 comments -> [UnitedHealth says Change Healthcare hack affects 100M – largest US health breach](https://techcrunch.com/2024/10/24/unitedhealth-change-healthcare-hacked-millions-health-records-ransomware/)<!-- HN:41972610:end -->
#### **Tuesday, October 29, 2024**
<!-- HN:41978213:start -->
* [41978213](https://news.social-protocols.org/stats?id=41978213) #3 22 points 4 comments -> [How to Learn Things by Yourself](https://brunothedev.github.io/p/2024-10-28-how_to_learn.html)<!-- HN:41978213:end --><!-- HN:41977665:start -->
* [41977665](https://news.social-protocols.org/stats?id=41977665) #17 12 points 0 comments -> [Show HN: Apache ResilientDB, High-Performance Open-Source Blockchain](https://resilientdb.incubator.apache.org/)<!-- HN:41977665:end --><!-- HN:41978940:start -->
* [41978940](https://news.social-protocols.org/stats?id=41978940) #9 7 points 2 comments -> [Haiku OS domain has been hijacked](https://haiku-os.org)<!-- HN:41978940:end --><!-- HN:41942693:start -->
* [41942693](https://news.social-protocols.org/stats?id=41942693) #10 11 points 1 comments -> [Lost Silk Road cities discovered in Uzbek mountains](https://www.bbc.co.uk/news/articles/c238kv8ddeyo)<!-- HN:41942693:end --><!-- HN:41926320:start -->
* [41926320](https://news.social-protocols.org/stats?id=41926320) #26 54 points 25 comments -> [Debugging audio artifacts caused by... a serial port?](https://www.recall.ai/post/debugging-audio-artifacts-caused-by-a-serial-port)<!-- HN:41926320:end --><!-- HN:41978246:start -->
* [41978246](https://news.social-protocols.org/stats?id=41978246) #19 117 points 42 comments -> [An indie studio created a game based on Stanislaw Lem's novel](https://invinciblethegame.com/?hn)<!-- HN:41978246:end --><!-- HN:41937306:start -->
* [41937306](https://news.social-protocols.org/stats?id=41937306) #10 30 points 8 comments -> [The Circular Electronics Design Guide](https://www.ifixit.com/News/101938/introducing-the-circular-electronics-design-guide)<!-- HN:41937306:end --><!-- HN:41979906:start -->
* [41979906](https://news.social-protocols.org/stats?id=41979906) #23 35 points 28 comments -> [The Battery Revolution Is Finally Here](https://insideevs.com/features/738508/high-silicon-anode-solid-state/)<!-- HN:41979906:end --><!-- HN:41982702:start -->
* [41982702](https://news.social-protocols.org/stats?id=41982702) #26 3 points 0 comments -> [For some reason, NASA is treating Orion's heat shield problems as a secret](https://arstechnica.com/space/2024/10/for-some-reason-nasa-is-treating-orions-heat-shield-problems-as-a-secret/)<!-- HN:41982702:end --><!-- HN:41983486:start -->
* [41983486](https://news.social-protocols.org/stats?id=41983486) #18 4 points 0 comments -> [Migrating billions of records: moving our active DNS database while it's in use](https://blog.cloudflare.com/migrating-billions-of-records-moving-our-active-dns-database-while-in-use/)<!-- HN:41983486:end --><!-- HN:41984105:start -->
* [41984105](https://news.social-protocols.org/stats?id=41984105) #3 16 points 0 comments -> [You Are Jeff Bezos](https://direkris.itch.io/you-are-jeff-bezos)<!-- HN:41984105:end --><!-- HN:41986053:start -->
* [41986053](https://news.social-protocols.org/stats?id=41986053) #27 4 points 0 comments -> [Company renting SF sleeping pods for $700 a month gains city approval](https://abc7news.com/post/exclusive-san-francisco-sleeping-pods-700-month-gains-city-approval/15482731/)<!-- HN:41986053:end --><!-- HN:41986436:start -->
* [41986436](https://news.social-protocols.org/stats?id=41986436) #28 75 points 65 comments -> [X Algorithm Feeds Users Political Content Whether They Want It or Not](https://www.wsj.com/politics/elections/x-twitter-political-content-election-2024-28f2dadd)<!-- HN:41986436:end --><!-- HN:41988181:start -->
* [41988181](https://news.social-protocols.org/stats?id=41988181) #25 3 points 0 comments -> [Protecting Router Freedom in Europe [pdf]](https://download.fsfe.org/routers/fsfe-router-freedom-activity-summary.pdf)<!-- HN:41988181:end --><!-- HN:41989962:start -->
* [41989962](https://news.social-protocols.org/stats?id=41989962) #3 -> ["No way to prevent this" say users of only language where this regularly happens](https://xeiaso.net/shitposts/no-way-to-prevent-this/CVE-2024-9632/)<!-- HN:41989962:end -->
#### **Wednesday, October 30, 2024**
<!-- HN:41988769:start -->
* [41988769](https://news.social-protocols.org/stats?id=41988769) #30 7 points 0 comments -> [OpenAI will start using AMD chips and could make its own AI hardware in 2026](https://www.theverge.com/2024/10/29/24282843/openai-custom-hardware-amd-nvidia-ai-chips)<!-- HN:41988769:end --><!-- HN:41991360:start -->
* [41991360](https://news.social-protocols.org/stats?id=41991360) #6 42 points 24 comments -> [H5N1 virus isolated from infected dairy worker is 100% lethal in ferrets](https://news.wisc.edu/h5n1-virus-isolated-from-infected-dairy-worker-is-100-lethal-in-ferrets-but-does-not-appear-to-be-circulating-in-nature-anymore/)<!-- HN:41991360:end --><!-- HN:41992007:start -->
* [41992007](https://news.social-protocols.org/stats?id=41992007) #29 12 points 0 comments -> [Project 25, and Why It's Bad](https://economixcomix.com/2024/10/18/project-2025-and-why-its-bad/)<!-- HN:41992007:end --><!-- HN:41992219:start -->
* [41992219](https://news.social-protocols.org/stats?id=41992219) #28 12 points 1 comments -> [More than a quarter of new code at Google is generated by AI](https://www.theverge.com/2024/10/29/24282757/google-new-code-generated-ai-q3-2024)<!-- HN:41992219:end --><!-- HN:41960385:start -->
* [41960385](https://news.social-protocols.org/stats?id=41960385) #21 3 points 1 comments -> [Show HN: Mahjong Dark Dimensions: Mahjong Dimensions Game Online](https://www.mahjongdarkdimensions.org/)<!-- HN:41960385:end --><!-- HN:41968337:start -->
* [41968337](https://news.social-protocols.org/stats?id=41968337) #16 8 points 0 comments -> [Py4web – Evolution of the Web2py Framework](https://py4web.com/)<!-- HN:41968337:end --><!-- HN:41994278:start -->
* [41994278](https://news.social-protocols.org/stats?id=41994278) #26 4 points 0 comments -> [Evaluating OpenAI Whisper's Hallucinations on Different Silences](https://www.sabrina.dev/p/evaluating-openai-whisper-s-hallucinations-on-different-silences)<!-- HN:41994278:end --><!-- HN:41994379:start -->
* [41994379](https://news.social-protocols.org/stats?id=41994379) #26 3 points 1 comments -> [Super Micro Computer plummets as auditor resigns](https://seekingalpha.com/news/4222850-super-micro-computer-plummets-as-auditor-resigns)<!-- HN:41994379:end --><!-- HN:41995660:start -->
* [41995660](https://news.social-protocols.org/stats?id=41995660) #29 5 points 0 comments -> [Down with Meritocracy (2001)](https://www.theguardian.com/politics/2001/jun/29/comment)<!-- HN:41995660:end --><!-- HN:41996461:start -->
* [41996461](https://news.social-protocols.org/stats?id=41996461) #28 4 points 1 comments -> [After non-endorsement, 250k subscribers cancel The Washington Post](https://www.washingtonpost.com/style/media/2024/10/29/washington-post-cancellations-number/)<!-- HN:41996461:end --><!-- HN:41941869:start -->
* [41941869](https://news.social-protocols.org/stats?id=41941869) #13 9 points 8 comments -> [Excel has a row limit of 1,048,576 rows and a column limit of 16,384 column](https://rowzero.io/blog/excel-row-limit)<!-- HN:41941869:end --><!-- HN:41997269:start -->
* [41997269](https://news.social-protocols.org/stats?id=41997269) #21 5 points 2 comments -> [Don't Bet Against the Dollar](https://www.bloomberg.com/opinion/articles/2024-10-29/don-t-bet-against-the-dollar)<!-- HN:41997269:end --><!-- HN:41998011:start -->
* [41998011](https://news.social-protocols.org/stats?id=41998011) #18 17 points 7 comments -> [Show HN: Supercharge Your Mac](https://sindresorhus.com/supercharge)<!-- HN:41998011:end --><!-- HN:41998453:start -->
* [41998453](https://news.social-protocols.org/stats?id=41998453) #4 23 points 1 comments -> [MrBeast Investigation](https://www.loock.io/blog/mrbeast-investigation)<!-- HN:41998453:end --><!-- HN:41992419:start -->
* [41992419](https://news.social-protocols.org/stats?id=41992419) #15 170 points 1 comments -> [AI Flame Graphs](https://www.brendangregg.com/blog//2024-10-29/ai-flame-graphs.html)<!-- HN:41992419:end --><!-- HN:41999701:start -->
* [41999701](https://news.social-protocols.org/stats?id=41999701) #5 4 points 0 comments -> [Meta Reports Third Quarter 2024 Results](https://investor.fb.com/investor-news/press-release-details/2024/Meta-Reports-Third-Quarter-2024-Results/default.aspx)<!-- HN:41999701:end --><!-- HN:41961846:start -->
* [41961846](https://news.social-protocols.org/stats?id=41961846) #23 7 points 1 comments -> [Norlha, the Luxury Yak Wool Brand Made by Nomads on the Tibetan Plateau](https://www.anothermag.com/fashion-beauty/12229/norlha-is-the-tibetan-label-changing-what-luxury-fashion-looks-like)<!-- HN:41961846:end --><!-- HN:42000242:start -->
* [42000242](https://news.social-protocols.org/stats?id=42000242) #26 16 points 7 comments -> [The realities of building an IPv6-only city – APNIC](https://blog.apnic.net/2024/10/29/the-realities-of-building-an-ipv6-only-city/)<!-- HN:42000242:end -->
#### **Thursday, October 31, 2024**
<!-- HN:42002994:start -->
* [42002994](https://news.social-protocols.org/stats?id=42002994) #9 11 points 8 comments -> [Astronomers Found Something Cold and Wet Near Uranus](https://gizmodo.com/astronomers-found-something-cold-and-wet-near-uranus-2000518316)<!-- HN:42002994:end --><!-- HN:41956213:start -->
* [41956213](https://news.social-protocols.org/stats?id=41956213) #12 58 points 31 comments -> [Cerebras Trains Llama Models to Leap over GPUs](https://www.nextplatform.com/2024/10/25/cerebras-trains-llama-models-to-leap-over-gpus/)<!-- HN:41956213:end --><!-- HN:42007933:start -->
* [42007933](https://news.social-protocols.org/stats?id=42007933) #18 3 points 0 comments -> [Windows Themes zero-day bug exposes users to NTLM credential theft](https://www.theregister.com/2024/10/30/zeroday_windows_themes/)<!-- HN:42007933:end --><!-- HN:42008424:start -->
* [42008424](https://news.social-protocols.org/stats?id=42008424) #1 -> [If The Economist had a vote, we would cast it for Kamala Harris](https://www.economist.com/leaders/2024/10/31/a-second-trump-term-comes-with-unacceptable-risks)<!-- HN:42008424:end -->
#### **Friday, November 1, 2024**
<!-- HN:42012807:start -->
* [42012807](https://news.social-protocols.org/stats?id=42012807) #7 12 points 6 comments -> [Researchers are questioning if ADHD should be seen as a disorder](https://www.economist.com/science-and-technology/2024/10/30/researchers-are-questioning-if-adhd-should-be-seen-as-a-disorder)<!-- HN:42012807:end --><!-- HN:42013117:start -->
* [42013117](https://news.social-protocols.org/stats?id=42013117) #5 9 points 1 comments -> [Technical Women and Women-in-Tech](https://deadsimpletech.com/blog/women_in_tech)<!-- HN:42013117:end --><!-- HN:41968940:start -->
* [41968940](https://news.social-protocols.org/stats?id=41968940) #18 8 points 4 comments -> [Bionic reading converter for ePub in Rust](https://github.com/mmatczuk/bioniconv)<!-- HN:41968940:end --><!-- HN:42013368:start -->
* [42013368](https://news.social-protocols.org/stats?id=42013368) #11 10 points 3 comments -> [Dawn: Designing Distributed Agents in a Worldwide Network](https://arxiv.org/abs/2410.22339)<!-- HN:42013368:end --><!-- HN:42014704:start -->
* [42014704](https://news.social-protocols.org/stats?id=42014704) #4 10 points 17 comments -> [Norway's Wealth Tax Is Backfiring. Are Americans Paying Attention?](https://thedailyeconomy.org/article/norways-wealth-tax-is-backfiring-are-americans-paying-attention/)<!-- HN:42014704:end --><!-- HN:42015323:start -->
* [42015323](https://news.social-protocols.org/stats?id=42015323) #12 28 points 24 comments -> [Men Arrested for Transcribing a Movie, Posting Details to a Website](https://torrentfreak.com/men-arrested-for-transcribing-godzilla-minus-one-posting-details-to-a-website-241031/)<!-- HN:42015323:end --><!-- HN:42014817:start -->
* [42014817](https://news.social-protocols.org/stats?id=42014817) #19 38 points 18 comments -> [It's been 30 years since Intel's infamous Pentium FDIV bug reared its ugly head](https://www.tomshardware.com/pc-components/cpus/its-been-30-years-since-intels-infamous-pentium-fdiv-bug-reared-its-ugly-head-a-math-bug-caused-intels-first-cpu-recall)<!-- HN:42014817:end --><!-- HN:42011193:start -->
* [42011193](https://news.social-protocols.org/stats?id=42011193) #22 402 points 294 comments -> [Wait Until 8th](https://www.waituntil8th.org)<!-- HN:42011193:end --><!-- HN:42015101:start -->
* [42015101](https://news.social-protocols.org/stats?id=42015101) #27 14 points 4 comments -> [KDE Linux](https://community.kde.org/KDE_Linux)<!-- HN:42015101:end --><!-- HN:42016372:start -->
* [42016372](https://news.social-protocols.org/stats?id=42016372) #11 5 points 0 comments -> [Want Windows 10 Security? That Will Be $30, Microsoft Says](https://www.forbes.com/sites/daveywinder/2024/11/01/want-windows-10-security-that-will-be-30-microsoft-says/)<!-- HN:42016372:end --><!-- HN:42016070:start -->
* [42016070](https://news.social-protocols.org/stats?id=42016070) #18 8 points 3 comments -> [Filter, Map, Reduce in 1.5 minutes [video]](https://www.youtube.com/watch?v=PZvHZJVeYdw)<!-- HN:42016070:end --><!-- HN:42016904:start -->
* [42016904](https://news.social-protocols.org/stats?id=42016904) #2 10 points 3 comments -> [How to Train Yourself to Go to Sleep Earlier](https://www.sleepfoundation.org/sleep-hygiene/how-to-go-to-sleep-earlier)<!-- HN:42016904:end --><!-- HN:42016225:start -->
* [42016225](https://news.social-protocols.org/stats?id=42016225) #20 18 points 5 comments -> [Crowds gather in Dublin for fake Halloween parade posted on social media](https://www.thejournal.ie/dublin-fake-halloween-parade-6529584-Oct2024/)<!-- HN:42016225:end --><!-- HN:42017453:start -->
* [42017453](https://news.social-protocols.org/stats?id=42017453) #12 18 points 1 comments -> [Iconic Gun-Makers Gave Sensitive Customer Information to Political Operatives](https://www.propublica.org/article/gunmakers-owners-sensitive-personal-information-glock-remington-nssf)<!-- HN:42017453:end -->