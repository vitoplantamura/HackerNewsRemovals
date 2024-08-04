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

#### **Monday, July 29, 2024**
<!-- HN:41096600:start -->
* [41096600](https://news.social-protocols.org/stats?id=41096600) #7 16 points 3 comments -> [Be MacGyver](https://macgyver.com/be-macgyver/)<!-- HN:41096600:end --><!-- HN:41093210:start -->
* [41093210](https://news.social-protocols.org/stats?id=41093210) #23 21 points 16 comments -> [Up to 90% of my code is now generated by AI](https://www.techsistence.com/p/up-to-90-of-my-code-is-now-generated)<!-- HN:41093210:end --><!-- HN:41094469:start -->
* [41094469](https://news.social-protocols.org/stats?id=41094469) #16 10 points 1 comments -> [The CMD FD-4000 Floppy Drive's Can Convert Disks from HD (1.4MB) to ED (3.2MB)](https://www.amigalove.com/viewtopic.php?t=2794)<!-- HN:41094469:end --><!-- HN:41096891:start -->
* [41096891](https://news.social-protocols.org/stats?id=41096891) #18 3 points 0 comments -> [The opulent world of six-figure kids birthday parties in Silicon Valley](https://sfstandard.com/2024/07/28/kid-parties-silicon-valley-entertainers/)<!-- HN:41096891:end --><!-- HN:41095812:start -->
* [41095812](https://news.social-protocols.org/stats?id=41095812) #18 9 points 1 comments -> [I will not do you a quick favour](https://sebs.website/blog/i-will-not-do-you-a-quick-favour)<!-- HN:41095812:end --><!-- HN:41045212:start -->
* [41045212](https://news.social-protocols.org/stats?id=41045212) #11 66 points 21 comments -> [Show HN: SwimOS Rust – A framework for real-time streaming data applications](https://github.com/swimos/swim-rust)<!-- HN:41045212:end --><!-- HN:41049955:start -->
* [41049955](https://news.social-protocols.org/stats?id=41049955) #17 46 points 42 comments -> [How many children had Lady Macbeth?](https://lifeandletters.substack.com/p/how-many-children-had-lady-macbeth)<!-- HN:41049955:end --><!-- HN:41047334:start -->
* [41047334](https://news.social-protocols.org/stats?id=41047334) #19 18 points 3 comments -> [Lullaby Language (2006)](https://www.humansystemsinaction.com/lullaby-language/)<!-- HN:41047334:end --><!-- HN:41094625:start -->
* [41094625](https://news.social-protocols.org/stats?id=41094625) #18 13 points 1 comments -> [Dual-action antibiotic could make bacterial resistance nearly impossible](https://today.uic.edu/dual-action-antibiotic-could-make-bacterial-resistance-nearly-impossible/)<!-- HN:41094625:end --><!-- HN:41097277:start -->
* [41097277](https://news.social-protocols.org/stats?id=41097277) #14 6 points 0 comments -> [How Alzheimer's undid my wife in her 40s](https://www.theguardian.com/news/article/2024/jul/09/how-alzheimers-undid-my-dazzling-creative-wife-in-her-40s)<!-- HN:41097277:end --><!-- HN:41097509:start -->
* [41097509](https://news.social-protocols.org/stats?id=41097509) #16 5 points 0 comments -> [New drug shows promise in clearing HIV from brain](https://www.sciencedaily.com/releases/2024/07/240725193914.htm)<!-- HN:41097509:end --><!-- HN:41096814:start -->
* [41096814](https://news.social-protocols.org/stats?id=41096814) #18 3 points 0 comments -> [NixOS Option Inspection](https://fzakaria.com/2024/07/28/nixos-option-inspection.html)<!-- HN:41096814:end --><!-- HN:41059388:start -->
* [41059388](https://news.social-protocols.org/stats?id=41059388) #26 12 points 8 comments -> [Counting Lines of Code](https://andrewpwheeler.com/2022/12/14/counting-lines-of-code/)<!-- HN:41059388:end --><!-- HN:41097388:start -->
* [41097388](https://news.social-protocols.org/stats?id=41097388) #13 7 points 3 comments -> [The ocean floor is covered in naturally-occurring batteries that make oxygen](https://theeggandtherock.com/p/the-deep-ocean-floor-is-covered-in)<!-- HN:41097388:end --><!-- HN:41097622:start -->
* [41097622](https://news.social-protocols.org/stats?id=41097622) #11 42 points 1 comments -> [Secure Boot useless on PCs from major vendors after key leak](https://www.theregister.com/2024/07/29/infosec_roundup/)<!-- HN:41097622:end --><!-- HN:41097837:start -->
* [41097837](https://news.social-protocols.org/stats?id=41097837) #28 4 points 0 comments -> [Pennsylvania's oil industry dumped waste across the state](https://grist.org/regulation/roadspreading-pennsylvania-fracking-waste/)<!-- HN:41097837:end --><!-- HN:41098384:start -->
* [41098384](https://news.social-protocols.org/stats?id=41098384) #11 12 points 3 comments -> [OpenAI could be on the brink of bankruptcy under 12 mths, projections $5B losses](https://www.windowscentral.com/software-apps/openai-could-be-on-the-brink-of-bankruptcy-in-under-12-months-with-projections-of-dollar5-billion-in-losses)<!-- HN:41098384:end --><!-- HN:41098963:start -->
* [41098963](https://news.social-protocols.org/stats?id=41098963) #18 20 points 0 comments -> [French fibre optic cables sabotaged](https://www.dw.com/en/france-telecom-fiber-optic-networks-reportedly-sabotaged/a-69795351)<!-- HN:41098963:end --><!-- HN:41098311:start -->
* [41098311](https://news.social-protocols.org/stats?id=41098311) #16 6 points 2 comments -> [The Documentation Tradeoff](https://tidyfirst.substack.com/p/the-documentation-tradeoff)<!-- HN:41098311:end --><!-- HN:41098166:start -->
* [41098166](https://news.social-protocols.org/stats?id=41098166) #19 15 points 4 comments -> [Happy Macs Gopher Site Back Online](https://happymacs.wordpress.com/2024/07/28/happy-macs-gopher-site-back-online/)<!-- HN:41098166:end --><!-- HN:41098579:start -->
* [41098579](https://news.social-protocols.org/stats?id=41098579) #16 38 points 23 comments -> [Microsoft backs down over rivals' Vista access (2006)](https://web.archive.org/web/20061023112233/http://software.silicon.com/security/0,39024655,39163277,00.htm)<!-- HN:41098579:end --><!-- HN:41099554:start -->
* [41099554](https://news.social-protocols.org/stats?id=41099554) #14 6 points 0 comments -> [WazirX to 'socialize' $230M security breach loss among customers](https://techcrunch.com/2024/07/27/wazirx-to-socialize-230-million-security-breach-loss-among-customers/)<!-- HN:41099554:end --><!-- HN:41098015:start -->
* [41098015](https://news.social-protocols.org/stats?id=41098015) #30 36 points 35 comments -> [Investors Are Suddenly Getting Concerned That AI Isn't Making Any Serious Money](https://futurism.com/investors-concerned-ai-making-money)<!-- HN:41098015:end --><!-- HN:41100224:start -->
* [41100224](https://news.social-protocols.org/stats?id=41100224) #9 7 points 4 comments -> [My Mom Says She Loves Me. AI Says She's Lying](https://www.theatlantic.com/ideas/archive/2024/07/ai-lie-detection-technology/679201/)<!-- HN:41100224:end --><!-- HN:41098931:start -->
* [41098931](https://news.social-protocols.org/stats?id=41098931) #29 35 points 6 comments -> [Let's release Rust-based fish](https://github.com/fish-shell/fish-shell/issues/10633)<!-- HN:41098931:end --><!-- HN:41100577:start -->
* [41100577](https://news.social-protocols.org/stats?id=41100577) #22 12 points 0 comments -> [I built an RPG and LLM jailbreaking adventure game](https://www.sabrina.dev/p/glitch-game-an-llm-jailbreak-adventure)<!-- HN:41100577:end --><!-- HN:41100551:start -->
* [41100551](https://news.social-protocols.org/stats?id=41100551) #16 9 points 3 comments -> [Ferrari exec foils deepfake attempt by asking a question only CEO could answer](https://fortune.com/2024/07/27/ferrari-deepfake-attempt-scammer-security-question-ceo-benedetto-vigna-cybersecurity-ai/)<!-- HN:41100551:end --><!-- HN:41100798:start -->
* [41100798](https://news.social-protocols.org/stats?id=41100798) #29 3 points 1 comments -> ['Nothing is getting done': Angry mob storms TMON offices over refund policy](https://koreajoongangdaily.joins.com/news/2024-07-26/business/industry/Nothing-is-getting-done-Angry-mob-storms-TMON-offices-over-refund-policy/2099710)<!-- HN:41100798:end --><!-- HN:41100097:start -->
* [41100097](https://news.social-protocols.org/stats?id=41100097) #18 5 points 6 comments -> [Moral Implications of Being Moderately Successful Computer Scientist and a Woman](https://irenezhang.net/blog/2024/07/24/misogyny.html)<!-- HN:41100097:end --><!-- HN:41101068:start -->
* [41101068](https://news.social-protocols.org/stats?id=41101068) #11 7 points 0 comments -> [Lambda: The Gathering](https://esolangs.org/wiki/Lambda:_the_Gathering)<!-- HN:41101068:end --><!-- HN:41102770:start -->
* [41102770](https://news.social-protocols.org/stats?id=41102770) #26 4 points 1 comments -> [Federal Court Says Warrant Required for Device Searches at the Border](https://knightcolumbia.org/content/federal-court-says-warrant-required-for-device-searches-at-the-border)<!-- HN:41102770:end --><!-- HN:41103220:start -->
* [41103220](https://news.social-protocols.org/stats?id=41103220) #29 5 points 2 comments -> [A Crisis for Vultures Led to a Human Disaster: Half a Million Deaths](https://www.nytimes.com/2024/07/29/climate/vultures-india-poisoning.html)<!-- HN:41103220:end --><!-- HN:41103166:start -->
* [41103166](https://news.social-protocols.org/stats?id=41103166) #19 16 points 42 comments -> [Future Ford's May Detect Speeding and Report You to the Cops](https://www.motorauthority.com/news/1143913_future-fords-might-detect-speeding-and-report-you-to-the-cops)<!-- HN:41103166:end --><!-- HN:41102862:start -->
* [41102862](https://news.social-protocols.org/stats?id=41102862) #26 21 points 40 comments -> [McDonald's sales fall globally for first time in more than three years](https://www.reuters.com/business/retail-consumer/mcdonalds-posts-surprise-drop-quarterly-global-sales-spending-slows-2024-07-29/)<!-- HN:41102862:end --><!-- HN:41104334:start -->
* [41104334](https://news.social-protocols.org/stats?id=41104334) #30 3 points 0 comments -> [How top data teams are structured](https://medium.com/@mikldd/how-top-data-teams-are-structured-48d46a64b990)<!-- HN:41104334:end --><!-- HN:41103581:start -->
* [41103581](https://news.social-protocols.org/stats?id=41103581) #24 3 points 0 comments -> [Ora2PG now supports oracle_fdw to increase data migration speed](https://migops.com/)<!-- HN:41103581:end --><!-- HN:41104395:start -->
* [41104395](https://news.social-protocols.org/stats?id=41104395) #11 22 points 5 comments -> [PasteBar – Limitless, Free Clipboard Manager for Mac and Windows. Open Source](https://github.com/PasteBar/PasteBarApp)<!-- HN:41104395:end -->
#### **Tuesday, July 30, 2024**
<!-- HN:41061963:start -->
* [41061963](https://news.social-protocols.org/stats?id=41061963) #8 97 points 35 comments -> [Julia for Economists Bootcamp](https://github.com/cpfiffer/julia-bootcamp-2022)<!-- HN:41061963:end --><!-- HN:41056912:start -->
* [41056912](https://news.social-protocols.org/stats?id=41056912) #15 85 points 26 comments -> [Notes on Taylor and Maclaurin Series](https://eli.thegreenplace.net/2024/notes-on-taylor-and-maclaurin-series/)<!-- HN:41056912:end --><!-- HN:41104913:start -->
* [41104913](https://news.social-protocols.org/stats?id=41104913) #25 45 points 19 comments -> [Delta to Seek Damages from CrowdStrike](https://www.cnbc.com/2024/07/29/delta-hires-david-boies-to-seek-damages-from-crowdstrike-microsoft-.html)<!-- HN:41104913:end --><!-- HN:41105018:start -->
* [41105018](https://news.social-protocols.org/stats?id=41105018) #28 6 points 0 comments -> [Email explained from first principles (2021)](https://explained-from-first-principles.com/email/)<!-- HN:41105018:end --><!-- HN:41108479:start -->
* [41108479](https://news.social-protocols.org/stats?id=41108479) #21 7 points 1 comments -> [PGP: The software that changed Internet Privacy and Cryptography](https://www.youtube.com/watch?v=0kcDBe6AkQE)<!-- HN:41108479:end --><!-- HN:41063489:start -->
* [41063489](https://news.social-protocols.org/stats?id=41063489) #20 80 points 48 comments -> [Hackers Exploited a PC Driving SIM to Pull Off Disney Data Breach](https://www.thedrive.com/news/culture/hackers-exploited-a-pc-driving-sim-to-pull-off-massive-disney-data-breach)<!-- HN:41063489:end --><!-- HN:41109295:start -->
* [41109295](https://news.social-protocols.org/stats?id=41109295) #22 14 points 1 comments -> [Marcus Hutchins - Why Microsoft Is to Blame for the CrowdStrike Outage](https://www.youtube.com/watch?v=EGttFWntctU)<!-- HN:41109295:end --><!-- HN:41108841:start -->
* [41108841](https://news.social-protocols.org/stats?id=41108841) #14 36 points 41 comments -> [Please Stop Reinventing JSX](https://gist.github.com/kevmo314/7bbf5d5868b973b53898d12b977b15b7)<!-- HN:41108841:end --><!-- HN:41110859:start -->
* [41110859](https://news.social-protocols.org/stats?id=41110859) #14 8 points 4 comments -> [The Little Tech Agenda](https://a16z.com/the-little-tech-agenda/)<!-- HN:41110859:end --><!-- HN:41110195:start -->
* [41110195](https://news.social-protocols.org/stats?id=41110195) #26 56 points 46 comments -> [Microsoft apologises after thousands report new outage](https://www.bbc.co.uk/news/articles/c903e793w74o)<!-- HN:41110195:end --><!-- HN:41110933:start -->
* [41110933](https://news.social-protocols.org/stats?id=41110933) #14 52 points 5 comments -> [ActivityPub's Evan Prodromou (currently developing E2EE) hit by truck:(](https://evanp.me/2024/07/26/health-update/)<!-- HN:41110933:end --><!-- HN:41112105:start -->
* [41112105](https://news.social-protocols.org/stats?id=41112105) #9 4 points 1 comments -> [Show HN: Browser Based RDP and SSH](https://www.tsncglobal.com/2024/07/apache-guacamole-installation-in-docker.html)<!-- HN:41112105:end --><!-- HN:41112273:start -->
* [41112273](https://news.social-protocols.org/stats?id=41112273) #20 10 points 3 comments -> [Logitech has an idea for a "forever mouse" that requires a subscription](https://arstechnica.com/gadgets/2024/07/logitech-has-an-idea-for-a-forever-mouse-thatrequires-a-subscription/)<!-- HN:41112273:end -->
#### **Wednesday, July 31, 2024**
<!-- HN:41114468:start -->
* [41114468](https://news.social-protocols.org/stats?id=41114468) #28 6 points 0 comments -> [Check Maybe Div by Zero for Gleam](https://hexdocs.pm/check_maybe_div_by_zero/)<!-- HN:41114468:end --><!-- HN:41115776:start -->
* [41115776](https://news.social-protocols.org/stats?id=41115776) #17 -> [X suspends 'White Dudes for Harris' account after fundraiser](https://www.washingtonpost.com/technology/2024/07/30/white-dudes-harris-suspended-x-twitter/)<!-- HN:41115776:end --><!-- HN:41068016:start -->
* [41068016](https://news.social-protocols.org/stats?id=41068016) #27 26 points 6 comments -> [Zuo: A Tiny Racket for Scripting](https://github.com/racket/zuo)<!-- HN:41068016:end --><!-- HN:41116617:start -->
* [41116617](https://news.social-protocols.org/stats?id=41116617) #5 9 points 5 comments -> [Jio Cloud](https://www.jio.com/business/services/jio-cloud)<!-- HN:41116617:end --><!-- HN:41115911:start -->
* [41115911](https://news.social-protocols.org/stats?id=41115911) #27 36 points 20 comments -> [Nobody Cares](https://a16z.com/nobody-cares/)<!-- HN:41115911:end --><!-- HN:41116885:start -->
* [41116885](https://news.social-protocols.org/stats?id=41116885) #23 12 points 7 comments -> [Fedora Asahi Remix](https://bentsukun.ch/posts/fedora-asahi/)<!-- HN:41116885:end --><!-- HN:41118281:start -->
* [41118281](https://news.social-protocols.org/stats?id=41118281) #20 12 points 6 comments -> [Australia starts world-first peanut allergy treatment for babies](https://www.bbc.co.uk/news/articles/c0xj3xq5l1vo)<!-- HN:41118281:end --><!-- HN:41118349:start -->
* [41118349](https://news.social-protocols.org/stats?id=41118349) #15 13 points 27 comments -> [Which country consumes the most coffee?](https://cafely.com/blogs/research/which-country-consumes-the-most-coffee)<!-- HN:41118349:end --><!-- HN:41118659:start -->
* [41118659](https://news.social-protocols.org/stats?id=41118659) #22 16 points 8 comments -> [New study finds people alter their appearance to suit their names](https://phys.org/news/2024-07-reveals-people-evolve.html)<!-- HN:41118659:end --><!-- HN:41118300:start -->
* [41118300](https://news.social-protocols.org/stats?id=41118300) #20 4 points 0 comments -> [So You're Thinking About Monetizing Your Blog – Loren's Blog](https://lorenblog.me/posts/so-you-re-thinking-about-monetizing-your-blog)<!-- HN:41118300:end --><!-- HN:41118962:start -->
* [41118962](https://news.social-protocols.org/stats?id=41118962) #24 18 points 2 comments -> [A Mathematician's Lament [pdf]](https://worrydream.com/refs/Lockhart_2002_-_A_Mathematician%27s_Lament.pdf)<!-- HN:41118962:end --><!-- HN:41119486:start -->
* [41119486](https://news.social-protocols.org/stats?id=41119486) #29 4 points 0 comments -> [Ukrainian Weaponized Yamaha Jet Ski with Starlink Antenna](http://www.hisutton.com/Ukraine-USV-Jetski.html)<!-- HN:41119486:end --><!-- HN:41119218:start -->
* [41119218](https://news.social-protocols.org/stats?id=41119218) #27 15 points 5 comments -> [Tesla recalls 1.8M cars because their hoods can open while driving](https://arstechnica.com/cars/2024/07/tesla-recalls-1-8-million-cars-because-their-hoods-can-open-while-driving/)<!-- HN:41119218:end --><!-- HN:41076399:start -->
* [41076399](https://news.social-protocols.org/stats?id=41076399) #6 6 points 1 comments -> [Two Threads One Core : How Simultaneous Multithreading Works Under the Hood ?](https://blog.codingconfessions.com/p/simultaneous-multithreading)<!-- HN:41076399:end --><!-- HN:41121083:start -->
* [41121083](https://news.social-protocols.org/stats?id=41121083) #24 39 points 18 comments -> [Oil companies sold the public on a fake climate solution](https://www.vox.com/climate/363076/climate-change-solution-shell-exxon-mobil-carbon-capture)<!-- HN:41121083:end --><!-- HN:41120961:start -->
* [41120961](https://news.social-protocols.org/stats?id=41120961) #30 10 points 11 comments -> [Xbox console sales continue to crater with 42% revenue drop](https://arstechnica.com/gaming/2024/07/xbox-console-sales-continue-to-crater-with-massive-42-revenue-drop/)<!-- HN:41120961:end --><!-- HN:41121721:start -->
* [41121721](https://news.social-protocols.org/stats?id=41121721) #14 11 points 0 comments -> [Kamala Harris gets support of more than 100 VCs and tech execs in online pledge](https://www.cnbc.com/2024/07/31/more-than-100-techies-sign-vcs-for-kamala-pledge-backing-vp-harris.html)<!-- HN:41121721:end --><!-- HN:41122792:start -->
* [41122792](https://news.social-protocols.org/stats?id=41122792) #4 33 points 11 comments -> [Heavy metal analysis of dark chocolate and cocoa products in the USA](https://www.frontiersin.org/journals/nutrition/articles/10.3389/fnut.2024.1366231/full)<!-- HN:41122792:end --><!-- HN:41123449:start -->
* [41123449](https://news.social-protocols.org/stats?id=41123449) #14 29 points 10 comments -> [This Month in Ladybird: July 2024](https://mailchi.mp/ladybird/july-2024)<!-- HN:41123449:end --><!-- HN:41122986:start -->
* [41122986](https://news.social-protocols.org/stats?id=41122986) #7 81 points 24 comments -> [An affordable, portable and focused device for music, writing and coding](https://tulip.computer/)<!-- HN:41122986:end -->
#### **Thursday, August 1, 2024**
<!-- HN:41123989:start -->
* [41123989](https://news.social-protocols.org/stats?id=41123989) #28 20 points 11 comments -> [Two new dementia risks identified by major report](https://www.bbc.com/news/articles/c84jdxd4x1ro)<!-- HN:41123989:end --><!-- HN:41124007:start -->
* [41124007](https://news.social-protocols.org/stats?id=41124007) #7 12 points 1 comments -> [Files](https://www.files.gallery/)<!-- HN:41124007:end --><!-- HN:41073907:start -->
* [41073907](https://news.social-protocols.org/stats?id=41073907) #21 39 points 18 comments -> [Is the nervous system a democracy? (2016)](https://www.scientificamerican.com/article/is-your-nervous-system-a-democracy-or-a-dictatorship/)<!-- HN:41073907:end --><!-- HN:41076021:start -->
* [41076021](https://news.social-protocols.org/stats?id=41076021) #28 129 points 59 comments -> [Where does the name "algebraic data type" come from?](https://blog.poisson.chat/posts/2024-07-26-adt-history.html)<!-- HN:41076021:end --><!-- HN:41126365:start -->
* [41126365](https://news.social-protocols.org/stats?id=41126365) #20 5 points 2 comments -> [Predicting Harris' VP nominee based on who's scrubbing their Wikipedia page most](https://old.reddit.com/r/dataisbeautiful/s/Ryxq8HaA0a)<!-- HN:41126365:end --><!-- HN:41127269:start -->
* [41127269](https://news.social-protocols.org/stats?id=41127269) #21 49 points 42 comments -> [Google listed my restaurant's number as its British HQ](https://www.theguardian.com/money/article/2024/aug/01/google-listed-my-restaurants-number-as-its-british-hq)<!-- HN:41127269:end --><!-- HN:41126130:start -->
* [41126130](https://news.social-protocols.org/stats?id=41126130) #14 126 points 15 comments -> [This month in Servo: console logging, parallel tables, OpenXR, and more](https://servo.org/blog/2024/07/31/this-month-in-servo/)<!-- HN:41126130:end --><!-- HN:41124112:start -->
* [41124112](https://news.social-protocols.org/stats?id=41124112) #17 67 points 41 comments -> [Show HN: Non SaaS – Directory of Non SaaS Apps](https://nonsaas.com)<!-- HN:41124112:end --><!-- HN:41127496:start -->
* [41127496](https://news.social-protocols.org/stats?id=41127496) #16 26 points 2 comments -> [Amazon is responsible for recalling unsafe products sold on its site,agency says](https://www.npr.org/2024/08/01/g-s1-14633/amazon-must-recall-unsafe-products-independent-sellers)<!-- HN:41127496:end --><!-- HN:41128528:start -->
* [41128528](https://news.social-protocols.org/stats?id=41128528) #30 10 points 6 comments -> [The VS Code Flatpak is useless](https://bentsukun.ch/posts/vscode-flatpak/)<!-- HN:41128528:end --><!-- HN:41128413:start -->
* [41128413](https://news.social-protocols.org/stats?id=41128413) #15 15 points 41 comments -> [Scientist Wants to Block the Sun to Cool the Earth](https://www.nytimes.com/2024/08/01/climate/david-keith-solar-geoengineering.html)<!-- HN:41128413:end --><!-- HN:41128541:start -->
* [41128541](https://news.social-protocols.org/stats?id=41128541) #20 9 points 3 comments -> [Unusual Whales Subversive Democratic Trading ETF](https://finance.yahoo.com/quote/NANC/)<!-- HN:41128541:end --><!-- HN:41129328:start -->
* [41129328](https://news.social-protocols.org/stats?id=41129328) #16 14 points 5 comments -> [Anger mounts over environmental cost of Google datacentre in Uruguay](https://www.theguardian.com/global-development/article/2024/aug/01/uruguay-anger-environmental-cost-google-datacentre-carbon-emissions-toxic-waste-water)<!-- HN:41129328:end --><!-- HN:41128990:start -->
* [41128990](https://news.social-protocols.org/stats?id=41128990) #24 55 points 99 comments -> [Proposed rule would ban airlines from charging parents to sit with children](https://www.cnbc.com/2024/08/01/proposed-rule-would-ban-airlines-from-charging-parents-to-sit-with-their-children.html)<!-- HN:41128990:end --><!-- HN:41130035:start -->
* [41130035](https://news.social-protocols.org/stats?id=41130035) #6 10 points 1 comments -> [Single precision matrix multiplication up to 43% faster than the one from cuBLAS](https://github.com/arekpaterek/Faster_SGEMM_CUDA)<!-- HN:41130035:end --><!-- HN:41091245:start -->
* [41091245](https://news.social-protocols.org/stats?id=41091245) #13 30 points 10 comments -> [Discovering a New Neolithic World](https://archaeology.org/issues/march-april-2024/features/discovering-a-new-neolithic-world/)<!-- HN:41091245:end --><!-- HN:41129752:start -->
* [41129752](https://news.social-protocols.org/stats?id=41129752) #24 39 points 40 comments -> [Say less in your emails, get more replies](https://www.gkogan.co/increase-reply-rates/)<!-- HN:41129752:end --><!-- HN:41131238:start -->
* [41131238](https://news.social-protocols.org/stats?id=41131238) #17 8 points 0 comments -> [Planted bomb, remote control and AI: How the Mossad killed Hamas' leader in Iran](https://www.axios.com/2024/08/01/haniyeh-assassination-mossad)<!-- HN:41131238:end --><!-- HN:41130342:start -->
* [41130342](https://news.social-protocols.org/stats?id=41130342) #28 35 points 18 comments -> [Intel Faces Potential Class-Action Lawsuit over Chip Bug Controversy](https://uk.pcmag.com/processors/153676/intel-faces-potential-class-action-lawsuit-over-chip-bug-controversy)<!-- HN:41130342:end --><!-- HN:41132822:start -->
* [41132822](https://news.social-protocols.org/stats?id=41132822) #22 56 points 32 comments -> [Pharma CIO cancels AI enhanced Office 365 deal as "it doesn't add value"](https://hardforum.com/threads/pharma-cio-cancels-ai-enhanced-office-365-deal-as-it-doesnt-add-value.2036205/)<!-- HN:41132822:end -->
#### **Friday, August 2, 2024**
<!-- HN:41093197:start -->
* [41093197](https://news.social-protocols.org/stats?id=41093197) #18 158 points 81 comments -> [A skeptic's first contact with Kubernetes](https://blog.davidv.dev/posts/first-contact-with-k8s/)<!-- HN:41093197:end --><!-- HN:41136099:start -->
* [41136099](https://news.social-protocols.org/stats?id=41136099) #29 3 points 1 comments -> [US progressives push for Nvidia antitrust investigation](https://www.reuters.com/technology/us-progressives-push-nvidia-antitrust-investigation-2024-08-01/)<!-- HN:41136099:end --><!-- HN:41136905:start -->
* [41136905](https://news.social-protocols.org/stats?id=41136905) #26 8 points 0 comments -> [List of vintage Japanese pixel/dot art software](https://blog.gingerbeardman.com/2023/10/21/list-of-vintage-japanese-pixel-dot-art-software/)<!-- HN:41136905:end --><!-- HN:41137773:start -->
* [41137773](https://news.social-protocols.org/stats?id=41137773) #29 7 points 3 comments -> [Ask iFixit: Does Blowing Into Gaming Cartridges Actually Fix Them?](https://www.ifixit.com/News/97647/ask-ifixit-does-blowing-into-gaming-cartridges-actually-fix-them)<!-- HN:41137773:end --><!-- HN:41138119:start -->
* [41138119](https://news.social-protocols.org/stats?id=41138119) #17 5 points 2 comments -> [Eating Processed Red Meat Linked to Increased Dementia Risk](https://www.nytimes.com/2024/07/31/well/eat/ultraprocessed-foods-brain-health.html)<!-- HN:41138119:end --><!-- HN:41138840:start -->
* [41138840](https://news.social-protocols.org/stats?id=41138840) #4 5 points 1 comments -> [Pregnancy in Patient with XY Chromosomes](https://www.fertstert.org/article/S0015-0282(10)02954-7/fulltext)<!-- HN:41138840:end --><!-- HN:41139419:start -->
* [41139419](https://news.social-protocols.org/stats?id=41139419) #5 6 points 0 comments -> [Predicting political beliefs with scores for cognitive performance](https://mfr.osf.io/render?url=https%3A%2F%2Fosf.io%2Fdownload%2Fbdr6s%2F%3Fdirect%3D%26mode%3Drender)<!-- HN:41139419:end --><!-- HN:41139696:start -->
* [41139696](https://news.social-protocols.org/stats?id=41139696) #23 7 points 2 comments -> [Show HN: I built an interactive demo builder for your sales team](https://demoshake.com)<!-- HN:41139696:end --><!-- HN:41100737:start -->
* [41100737](https://news.social-protocols.org/stats?id=41100737) #27 279 points 134 comments -> [The protein Reelin keeps popping up in brains that resist aging and Alzheimer’s](https://www.npr.org/sections/shots-health-news/2024/07/29/g-s1-13519/alzheimers-protein-reelin-brain-aging-amyloid-tau-memory)<!-- HN:41100737:end --><!-- HN:41140263:start -->
* [41140263](https://news.social-protocols.org/stats?id=41140263) #5 29 points 7 comments -> [Does the success of LLM support Wittgenstein's position that "meaning is use"?](https://philosophy.stackexchange.com/questions/112021/does-the-success-of-ai-large-language-models-support-wittgensteins-position-t)<!-- HN:41140263:end --><!-- HN:41142365:start -->
* [41142365](https://news.social-protocols.org/stats?id=41142365) #29 7 points 3 comments -> [Why are religious teens happier than their secular peers?](https://www.bostonglobe.com/2024/06/06/opinion/religious-teens-mental-health/)<!-- HN:41142365:end -->
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
* [41150372](https://news.social-protocols.org/stats?id=41150372) #28 14 points 1 comments -> [Automating away the boring parts of my job with Gemini 1.5 Pro and long context](https://medium.com/@webpaige/automating-away-the-boring-parts-of-my-job-with-gemini-1-5-pro-long-context-windows-6d5a1d9a6f38)<!-- HN:41150372:end --><!-- HN:41150317:start -->
* [41150317](https://news.social-protocols.org/stats?id=41150317) #28 79 points 38 comments -> [How I Use AI (Nicholas Carlini)](https://nicholas.carlini.com/writing/2024/how-i-use-ai.html)<!-- HN:41150317:end --><!-- HN:41151494:start -->
* [41151494](https://news.social-protocols.org/stats?id=41151494) #12 12 points 6 comments -> [Computers are amazing. So why is software so terrible?](https://handmade.network/manifesto)<!-- HN:41151494:end -->