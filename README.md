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

#### **Thursday, October 23, 2025**
<!-- HN:45677397:start -->
* [45677397](https://news.social-protocols.org/stats?id=45677397) #7 5 points 5 comments -> [A Homological Proof of P != NP: Computational Topology via Categorical Framework](https://arxiv.org/abs/2510.17829)<!-- HN:45677397:end --><!-- HN:45677201:start -->
* [45677201](https://news.social-protocols.org/stats?id=45677201) #21 17 points 15 comments -> [Is AI a Bubble? I Didn't Think So Until I Heard of SDD](https://hyperdev.matsuoka.com/p/is-ai-a-bubble-i-didnt-think-so-until)<!-- HN:45677201:end --><!-- HN:45679558:start -->
* [45679558](https://news.social-protocols.org/stats?id=45679558) #18 32 points 40 comments -> [Female spies are waging 'sex warfare' to steal Silicon Valley secrets](https://www.thetimes.com/us/american-politics/article/silicon-valley-spy-china-russia-2v03676kl)<!-- HN:45679558:end --><!-- HN:45591264:start -->
* [45591264](https://news.social-protocols.org/stats?id=45591264) #20 24 points 28 comments -> [They Clean the Balls in a Ball Pit](https://www.core77.com/posts/138608/Heres-How-They-Clean-the-Balls-in-a-Ball-Pit)<!-- HN:45591264:end --><!-- HN:45681322:start -->
* [45681322](https://news.social-protocols.org/stats?id=45681322) #6 9 points 0 comments -> [I Went All in on AI. The MIT Study Was Right](https://leadershiplighthouse.substack.com/p/i-went-all-in-on-ai-the-mit-study)<!-- HN:45681322:end --><!-- HN:45622122:start -->
* [45622122](https://news.social-protocols.org/stats?id=45622122) #23 5 points 1 comments -> [The Tonnetz](https://thetonnetz.com/)<!-- HN:45622122:end --><!-- HN:45684035:start -->
* [45684035](https://news.social-protocols.org/stats?id=45684035) #2 162 points 2 comments -> [MinIO declines to release Docker builds resolving CVE-2025-62506](https://github.com/minio/minio/issues/21647)<!-- HN:45684035:end -->
#### **Friday, October 24, 2025**
<!-- HN:45690506:start -->
* [45690506](https://news.social-protocols.org/stats?id=45690506) #3 37 points 17 comments -> [US Tariff Negotiations with Canada Terminated over Advertisement](https://www.bbc.com/news/articles/cdjrlmd4pmeo)<!-- HN:45690506:end --><!-- HN:45602940:start -->
* [45602940](https://news.social-protocols.org/stats?id=45602940) #26 19 points 11 comments -> [Why does collapsing a bubble with a sound wave produce light?](https://akshatjiwannotes.blogspot.com/2025/10/why-does-collapsing-bubble-with-sound.html)<!-- HN:45602940:end --><!-- HN:45696539:start -->
* [45696539](https://news.social-protocols.org/stats?id=45696539) #1 21 points 1 comments -> [Men who mean just what they say](https://journal.humancenteredtech.us/p/men-who-mean-just-what-they-say)<!-- HN:45696539:end --><!-- HN:45697395:start -->
* [45697395](https://news.social-protocols.org/stats?id=45697395) #1 138 points 25 comments -> [FBI Agents Visit Anti-ICE Protester: "Your name was brought up."](https://www.kenklippenstein.com/p/video-fbi-agents-visit-anti-ice-protester)<!-- HN:45697395:end --><!-- HN:45697649:start -->
* [45697649](https://news.social-protocols.org/stats?id=45697649) #1 -> [Protein Is a Trap and I Have Fallen into It, or Second Breakfast #19](https://buttondown.com/meghanmccarron/archive/protein-is-a-trap-and-i-have-fallen-into-it-or/)<!-- HN:45697649:end --><!-- HN:45699294:start -->
* [45699294](https://news.social-protocols.org/stats?id=45699294) #6 4 points 0 comments -> [Leaving the Freedesktop.org Community](https://vt.social/@lina/115431232807081648)<!-- HN:45699294:end --><!-- HN:45680805:start -->
* [45680805](https://news.social-protocols.org/stats?id=45680805) #9 9 points 0 comments -> [Why PHP and JavaScript Are Great](http://xahlee.info/comp/PHP_is_great.html)<!-- HN:45680805:end -->
#### **Saturday, October 25, 2025**
<!-- HN:45616791:start -->
* [45616791](https://news.social-protocols.org/stats?id=45616791) #8 20 points 2 comments -> [You Can Cool Chips with Lasers](https://spectrum.ieee.org/laser-cooling-chips)<!-- HN:45616791:end --><!-- HN:45620483:start -->
* [45620483](https://news.social-protocols.org/stats?id=45620483) #12 8 points 0 comments -> [Compiler optimizations for 5.8ms GPT-OSS-120B inference (not on GPUs)](https://furiosa.ai/blog/serving-gpt-oss-120b-at-5-8-ms-tpot-with-two-rngd-cards-compiler-optimizations-in-practice)<!-- HN:45620483:end --><!-- HN:45593532:start -->
* [45593532](https://news.social-protocols.org/stats?id=45593532) #25 10 points 3 comments -> [Many Factorials in Lambda Calculus](https://text.marvinborner.de/2025-10-08-12.html)<!-- HN:45593532:end --><!-- HN:45566817:start -->
* [45566817](https://news.social-protocols.org/stats?id=45566817) #28 100 points 92 comments -> [Wasp Blower](https://softsolder.com/2025/08/12/wasp-blower/)<!-- HN:45566817:end --><!-- HN:45700301:start -->
* [45700301](https://news.social-protocols.org/stats?id=45700301) #10 -> [Virtual Try on Free Online – AI Clothes Changer – I-TryOn](https://virtual-try-on.app/)<!-- HN:45700301:end --><!-- HN:45701622:start -->
* [45701622](https://news.social-protocols.org/stats?id=45701622) #4 28 points 12 comments -> [Claudeskills.cc – Share, Discover, and Reuse Claude/OpenAI Agent Skills](https://claudeskills.cc)<!-- HN:45701622:end --><!-- HN:45705250:start -->
* [45705250](https://news.social-protocols.org/stats?id=45705250) #26 38 points 11 comments -> [Armed police handcuff teen after AI mistakes chip bag for gun in Baltimore](https://www.bbc.com/news/articles/cgjdlx92lylo)<!-- HN:45705250:end --><!-- HN:45703767:start -->
* [45703767](https://news.social-protocols.org/stats?id=45703767) #12 65 points 61 comments -> [DNA reveals the real killers that brought down Napoleon's army](https://www.gavi.org/vaccineswork/dna-reveals-real-killers-brought-down-napoleons-army)<!-- HN:45703767:end --><!-- HN:45706690:start -->
* [45706690](https://news.social-protocols.org/stats?id=45706690) #4 14 points 8 comments -> [Violent crime plummets 36% in downtown Seattle, lowest since 2017](https://mynorthwest.com/crime-blotter/seattle-downtown-crime/4146723)<!-- HN:45706690:end --><!-- HN:45706872:start -->
* [45706872](https://news.social-protocols.org/stats?id=45706872) #24 13 points 5 comments -> [Do Orthodox Jewish Men Wear Suits 24/7?](https://jewinthecity.com/2018/02/do-orthodox-men-wear-suits-247/)<!-- HN:45706872:end --><!-- HN:45707022:start -->
* [45707022](https://news.social-protocols.org/stats?id=45707022) #27 9 points 2 comments -> [AI agents require to-do lists to stay on track](https://blog.justcopy.ai/p/why-your-ai-agents-need-a-todo-list)<!-- HN:45707022:end --><!-- HN:45657100:start -->
* [45657100](https://news.social-protocols.org/stats?id=45657100) #20 30 points 40 comments -> [Show HN: We tried to build a job board that isn't awful](https://teeming.ai)<!-- HN:45657100:end --><!-- HN:45706601:start -->
* [45706601](https://news.social-protocols.org/stats?id=45706601) #30 10 points 1 comments -> [Global key-value metadata storage for Scryer Prolog](https://github.com/jjtolton/environment.pl)<!-- HN:45706601:end -->
#### **Sunday, October 26, 2025**
<!-- HN:45707779:start -->
* [45707779](https://news.social-protocols.org/stats?id=45707779) #6 29 points 44 comments -> [Sora might have a 'pervert' problem on its hands](https://www.businessinsider.com/sora-video-openai-fetish-content-my-face-problem-2025-10)<!-- HN:45707779:end --><!-- HN:45708229:start -->
* [45708229](https://news.social-protocols.org/stats?id=45708229) #12 7 points 0 comments -> [Why the New Leisure Class Enjoys Activism and Philanthropy](https://letter.palladiummag.com/p/early-article-why-the-new-leisure)<!-- HN:45708229:end --><!-- HN:45708442:start -->
* [45708442](https://news.social-protocols.org/stats?id=45708442) #15 5 points 0 comments -> [Noam Chomsky Slams ŽIžek and Lacan: Empty 'Posturing' (2013)](https://www.openculture.com/2013/06/noam_chomsky_slams_zizek_and_lacan_empty_posturing.html)<!-- HN:45708442:end --><!-- HN:45639903:start -->
* [45639903](https://news.social-protocols.org/stats?id=45639903) #18 22 points 15 comments -> [The Privacy Theater of Hashed PII](https://matthodges.com/posts/2025-10-19-privacy-theater-pii-phone-numbers/)<!-- HN:45639903:end --><!-- HN:45712124:start -->
* [45712124](https://news.social-protocols.org/stats?id=45712124) #6 6 points 0 comments -> [Gambling Is Bad](https://geohot.github.io//blog/jekyll/update/2025/10/24/gambling-is-bad.html)<!-- HN:45712124:end --><!-- HN:45712618:start -->
* [45712618](https://news.social-protocols.org/stats?id=45712618) #30 -> [Keira Knightley's viral rant on the population's cognitive resilience](https://twitter.com/orphcorp/status/1982230134850572551)<!-- HN:45712618:end --><!-- HN:45713507:start -->
* [45713507](https://news.social-protocols.org/stats?id=45713507) #6 17 points 6 comments -> [Show HN: FlashRecord – 2MB Python-native CLI screen recorder](https://github.com/Flamehaven/FlashRecord)<!-- HN:45713507:end -->
#### **Monday, October 27, 2025**
<!-- HN:45717285:start -->
* [45717285](https://news.social-protocols.org/stats?id=45717285) #5 56 points 28 comments -> [Severe performance penalty found in VSCode rendering loop](https://github.com/microsoft/vscode/issues/272155)<!-- HN:45717285:end --><!-- HN:45717424:start -->
* [45717424](https://news.social-protocols.org/stats?id=45717424) #17 11 points 0 comments -> [The striking Swedish workers taking on carmaker Tesla](https://www.bbc.com/news/articles/c5y9082q0jjo)<!-- HN:45717424:end --><!-- HN:45718367:start -->
* [45718367](https://news.social-protocols.org/stats?id=45718367) #14 13 points 1 comments -> [My Email to Tim Cook](https://substack.com/inbox/post/175351960)<!-- HN:45718367:end --><!-- HN:45719805:start -->
* [45719805](https://news.social-protocols.org/stats?id=45719805) #26 12 points 2 comments -> [Isomorphic JS/TS Functions Orchestrator](https://github.com/damianofalcioni/js-functions-orchestrator)<!-- HN:45719805:end --><!-- HN:45726137:start -->
* [45726137](https://news.social-protocols.org/stats?id=45726137) #1 218 points 47 comments -> [The PSF has withdrawn a $1.5M proposal to US Government grant program](https://simonwillison.net/2025/Oct/27/psf-withdrawn-proposal/)<!-- HN:45726137:end --><!-- HN:45654202:start -->
* [45654202](https://news.social-protocols.org/stats?id=45654202) #28 -> [Iroh-blobs 0.95 – New features – Iroh](https://www.iroh.computer/blog/iroh-blobs-0-95-new-features)<!-- HN:45654202:end -->
#### **Tuesday, October 28, 2025**
<!-- HN:45728415:start -->
* [45728415](https://news.social-protocols.org/stats?id=45728415) #10 4 points 2 comments -> [ChatGPT shares data on how many users exhibit psychosis or suicidal thoughts](https://www.bbc.com/news/articles/c5yd90g0q43o)<!-- HN:45728415:end --><!-- HN:45652367:start -->
* [45652367](https://news.social-protocols.org/stats?id=45652367) #5 62 points 5 comments -> [Finding my rhythm again](https://jeremydaly.com/finding-my-rhythm-again/)<!-- HN:45652367:end --><!-- HN:45635384:start -->
* [45635384](https://news.social-protocols.org/stats?id=45635384) #10 43 points 2 comments -> [Yet another year with Decker](http://beyondloom.com/blog/unionstate3.html)<!-- HN:45635384:end --><!-- HN:45644066:start -->
* [45644066](https://news.social-protocols.org/stats?id=45644066) #13 67 points 33 comments -> [Go beyond Goroutines: introducing the Reactive paradigm](https://samuelberthe.substack.com/p/go-beyond-goroutines-introducing)<!-- HN:45644066:end --><!-- HN:45652952:start -->
* [45652952](https://news.social-protocols.org/stats?id=45652952) #19 161 points 94 comments -> [Should LLMs just treat text content as an image?](https://www.seangoedecke.com/text-tokens-as-image-tokens/)<!-- HN:45652952:end --><!-- HN:45658461:start -->
* [45658461](https://news.social-protocols.org/stats?id=45658461) #23 64 points 0 comments -> [Solving regex crosswords with Z3](https://blog.nelhage.com/post/regex-crosswords-z3/)<!-- HN:45658461:end --><!-- HN:45661617:start -->
* [45661617](https://news.social-protocols.org/stats?id=45661617) #26 14 points 2 comments -> [We resolve a $1000 Erdős problem, with a Lean proof vibe coded using ChatGPT](https://borisalexeev.com/papers/erdos707.html)<!-- HN:45661617:end --><!-- HN:45729357:start -->
* [45729357](https://news.social-protocols.org/stats?id=45729357) #8 4 points 0 comments -> [My Domain Was Poached by a Cambodian](https://davidnicholaswilliams.com/my-domain-was-poached/)<!-- HN:45729357:end --><!-- HN:45728729:start -->
* [45728729](https://news.social-protocols.org/stats?id=45728729) #24 8 points 10 comments -> [Drivers who do 10k miles a year 'face new £1,500 charge'](https://www.birminghammail.co.uk/motoring/motoring-news/drivers-who-10000-miles-year-32727647)<!-- HN:45728729:end --><!-- HN:45729599:start -->
* [45729599](https://news.social-protocols.org/stats?id=45729599) #8 12 points 3 comments -> [Show HN: Write Node.js code in Rust to achieve massive HTTP throughput](https://www.npmjs.com/package/brahma-firelight)<!-- HN:45729599:end --><!-- HN:45730073:start -->
* [45730073](https://news.social-protocols.org/stats?id=45730073) #9 13 points 3 comments -> [Why IP address truncation fails at anonymization](https://00f.net/2025/10/27/ip-anonymization/)<!-- HN:45730073:end --><!-- HN:45730210:start -->
* [45730210](https://news.social-protocols.org/stats?id=45730210) #30 16 points 9 comments -> [183M Gmail Passwords Leaked](https://www.forbes.com/sites/daveywinder/2025/10/27/gmail-passwords-confirmed-as-part-of-183-million-account-data-breach/)<!-- HN:45730210:end --><!-- HN:45680050:start -->
* [45680050](https://news.social-protocols.org/stats?id=45680050) #9 8 points 2 comments -> [Show HN: A Visual No-Code Game Engine – 50x Easier Than Unity](https://play-maker.io)<!-- HN:45680050:end --><!-- HN:45729437:start -->
* [45729437](https://news.social-protocols.org/stats?id=45729437) #20 203 points 100 comments -> [I Built the Same App 10 Times: Evaluating Frameworks for Mobile Performance](https://www.lorenstew.art/blog/10-kanban-boards/)<!-- HN:45729437:end --><!-- HN:45731385:start -->
* [45731385](https://news.social-protocols.org/stats?id=45731385) #4 18 points 9 comments -> [Nine months later, is still the "Gulf of Mexico" to news outlets](https://www.niemanlab.org/2025/10/nine-months-later-that-body-of-water-down-south-is-still-the-gulf-of-mexico-to-news-outlets/)<!-- HN:45731385:end --><!-- HN:45676191:start -->
* [45676191](https://news.social-protocols.org/stats?id=45676191) #26 39 points 10 comments -> [DJI Removes Video Shot in National Parks After It Raises Eyebrows](https://petapixel.com/2025/10/21/dji-removes-video-shot-in-national-parks-after-it-raises-eyebrows/)<!-- HN:45676191:end --><!-- HN:45732783:start -->
* [45732783](https://news.social-protocols.org/stats?id=45732783) #8 17 points 10 comments -> [Microsoft to Get 27% of OpenAI, Access to AI Models Until 2032](https://www.bloomberg.com/news/articles/2025-10-28/microsoft-to-get-27-of-openai-access-to-ai-models-until-2032)<!-- HN:45732783:end --><!-- HN:45734529:start -->
* [45734529](https://news.social-protocols.org/stats?id=45734529) #10 4 points 0 comments -> [How to build a brand that AI can't copy](https://www.eleanot.es/p/how-to-build-brands-ai-cant-copy)<!-- HN:45734529:end -->
#### **Wednesday, October 29, 2025**
<!-- HN:45740348:start -->
* [45740348](https://news.social-protocols.org/stats?id=45740348) #6 10 points 2 comments -> [Static Android Debug Bridge (adb)](https://github.com/kiddlu/adb-static)<!-- HN:45740348:end --><!-- HN:45740467:start -->
* [45740467](https://news.social-protocols.org/stats?id=45740467) #28 11 points 1 comments -> [Fil-C: A memory-safe C implementation](https://lwn.net/SubscriberLink/1042938/ac9a001023324bf8/)<!-- HN:45740467:end --><!-- HN:45741877:start -->
* [45741877](https://news.social-protocols.org/stats?id=45741877) #29 7 points 2 comments -> [Rockylinux.org not hosted on Rocky Linux](https://rockylinux-org.vercel.app/)<!-- HN:45741877:end --><!-- HN:45745876:start -->
* [45745876](https://news.social-protocols.org/stats?id=45745876) #13 10 points 4 comments -> [Now any body can write JavaScript code in Rust](https://github.com/Shyam20001/rsjs)<!-- HN:45745876:end --><!-- HN:45746313:start -->
* [45746313](https://news.social-protocols.org/stats?id=45746313) #26 9 points 6 comments -> [Create your first business email for free](https://fromzerotollc.com/step/create-your-first-business-email)<!-- HN:45746313:end --><!-- HN:45747263:start -->
* [45747263](https://news.social-protocols.org/stats?id=45747263) #19 33 points 42 comments -> [Mom's son was asking Tesla's Grok AI bot about soccer; told him to send nudes](https://www.cbc.ca/news/investigates/tesla-grok-mom-9.6956930)<!-- HN:45747263:end -->