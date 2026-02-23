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

#### **Tuesday, February 17, 2026**
<!-- HN:46977901:start -->
* [46977901](https://news.social-protocols.org/stats?id=46977901) #14 32 points 2 comments -> [Camera that captures photos to cassette tape](https://hackaday.io/project/205004-digital-analog-tape-picture-camera)<!-- HN:46977901:end --><!-- HN:46996852:start -->
* [46996852](https://news.social-protocols.org/stats?id=46996852) #30 21 points 26 comments -> [Nvidia with unusually fast coding model on plate-sized chips](https://arstechnica.com/ai/2026/02/openai-sidesteps-nvidia-with-unusually-fast-coding-model-on-plate-sized-chips/)<!-- HN:46996852:end --><!-- HN:47041841:start -->
* [47041841](https://news.social-protocols.org/stats?id=47041841) #27 9 points 3 comments -> [Show HN: Journey – A Custom 2D ECS Game Engine Written in Rust and WGPU](https://ujjwalvivek.com/blog/proj_0004_rust_game_engine.md)<!-- HN:47041841:end --><!-- HN:47043435:start -->
* [47043435](https://news.social-protocols.org/stats?id=47043435) #30 7 points 4 comments -> [Performative virtue-signaling has become a threat to higher ed](https://thehill.com/opinion/education/5446702-performative-virtue-signaling-has-become-a-threat-to-higher-ed/)<!-- HN:47043435:end --><!-- HN:47045124:start -->
* [47045124](https://news.social-protocols.org/stats?id=47045124) #4 9 points 3 comments -> [Slopware AI: Ship Garbage Even Faster](https://slopware.ai/)<!-- HN:47045124:end --><!-- HN:47046560:start -->
* [47046560](https://news.social-protocols.org/stats?id=47046560) #16 8 points 0 comments -> [How the Kakistocracy Became a Quackistocracy](https://paulkrugman.substack.com/p/how-the-kakistocracy-became-a-quackistocracy)<!-- HN:47046560:end --><!-- HN:47046973:start -->
* [47046973](https://news.social-protocols.org/stats?id=47046973) #14 5 points 0 comments -> [We just made a $200M AI movie in just one day. Yes, this is 100% AI](https://twitter.com/thedorbrothers/status/2023460644905742577)<!-- HN:47046973:end --><!-- HN:47047932:start -->
* [47047932](https://news.social-protocols.org/stats?id=47047932) #16 14 points 6 comments -> [The mathematical mystery inside the legendary '90s shooter Quake 3](https://www.scientificamerican.com/article/the-mathematical-mystery-inside-the-legendary-90s-shooter-quake-3/)<!-- HN:47047932:end --><!-- HN:47050447:start -->
* [47050447](https://news.social-protocols.org/stats?id=47050447) #2 65 points 13 comments -> [Claude Sonnet 4.6](https://www.anthropic.com/news/claude-sonnet-4-6)<!-- HN:47050447:end --><!-- HN:47023255:start -->
* [47023255](https://news.social-protocols.org/stats?id=47023255) #27 12 points 0 comments -> [Show HN: Clawntown – An Evolving Crustacean Island](https://clawntown.lol)<!-- HN:47023255:end -->
#### **Wednesday, February 18, 2026**
<!-- HN:47055467:start -->
* [47055467](https://news.social-protocols.org/stats?id=47055467) #16 33 points 9 comments -> [Tesla Robotaxis Reportedly Crashing at a Rate That's 4x Higher Than Humans](https://gizmodo.com/tesla-robotaxis-reportedly-crashing-at-a-rate-thats-4x-higher-than-humans-2000722989)<!-- HN:47055467:end --><!-- HN:47059652:start -->
* [47059652](https://news.social-protocols.org/stats?id=47059652) #3 13 points 3 comments -> [Stop prompting. Let the AI interview you to build specs](https://www.ideaforge.chat/)<!-- HN:47059652:end --><!-- HN:47016624:start -->
* [47016624](https://news.social-protocols.org/stats?id=47016624) #18 10 points 1 comments -> [World's Only Pencil Sharpener Museum](https://www.bostonglobe.com/2026/02/13/lifestyle/pencil-sharpener-museum-ohio/)<!-- HN:47016624:end --><!-- HN:47060041:start -->
* [47060041](https://news.social-protocols.org/stats?id=47060041) #12 -> [AI made every test pass, but the code was still wrong](https://doodledapp.com/feed/ai-made-every-test-pass-the-code-was-still-wrong)<!-- HN:47060041:end --><!-- HN:47062142:start -->
* [47062142](https://news.social-protocols.org/stats?id=47062142) #7 5 points 1 comments -> [The Ozempic Effect: How McDonald's Is Reinventing Fast Food](https://ariatatrezvalthazar.blogspot.com/2026/02/the-ozempic-effect-how-mcdonalds-is.html)<!-- HN:47062142:end --><!-- HN:47062911:start -->
* [47062911](https://news.social-protocols.org/stats?id=47062911) #10 10 points 2 comments -> [Dear Comrade Xi](https://www.campbellramble.ai/p/dear-comrade-xi)<!-- HN:47062911:end --><!-- HN:47064453:start -->
* [47064453](https://news.social-protocols.org/stats?id=47064453) #4 15 points 7 comments -> [Vermont EV buses prove unreliable for transportation this winter](https://vermontdailychronicle.com/vermont-ev-buses-prove-unreliable-for-transportation-this-winter/)<!-- HN:47064453:end --><!-- HN:47065140:start -->
* [47065140](https://news.social-protocols.org/stats?id=47065140) #10 7 points 2 comments -> [Complexity Science and Emergent Order: How Simple Rules Create Complex Systems](https://mysticryst.com/blogs/the-mystic-journal/complexity-science-emergent-order-simple-rules-complex-systems)<!-- HN:47065140:end --><!-- HN:47003672:start -->
* [47003672](https://news.social-protocols.org/stats?id=47003672) #19 58 points 24 comments -> [Delphi is 31 years old – innovation timeline](https://blogs.embarcadero.com/delphi-innovation-timeline-31st-anniversary-edition-published-get-your-free-pdf/)<!-- HN:47003672:end --><!-- HN:47005945:start -->
* [47005945](https://news.social-protocols.org/stats?id=47005945) #27 23 points 3 comments -> [SkyRL brings Tinker to your GPUs (2025)](https://novasky-ai.notion.site/skyrl-tinker)<!-- HN:47005945:end --><!-- HN:47065425:start -->
* [47065425](https://news.social-protocols.org/stats?id=47065425) #30 16 points 12 comments -> [Show HN: Strava for Claude Code](https://straude.com/)<!-- HN:47065425:end -->
#### **Thursday, February 19, 2026**
<!-- HN:47072141:start -->
* [47072141](https://news.social-protocols.org/stats?id=47072141) #1 19 points 4 comments -> [Andrew Mountbatten-Windsor arrested on suspicion of misconduct in public office](https://www.bbc.com/news/live/c70kjr9wjw0t)<!-- HN:47072141:end --><!-- HN:47075406:start -->
* [47075406](https://news.social-protocols.org/stats?id=47075406) #26 6 points 1 comments -> [AI found 12 of 12 OpenSSL zero-days](https://www.lesswrong.com/posts/7aJwgbMEiKq5egQbd/ai-found-12-of-12-openssl-zero-days-while-curl-cancelled-its)<!-- HN:47075406:end --><!-- HN:47075422:start -->
* [47075422](https://news.social-protocols.org/stats?id=47075422) #10 7 points 1 comments -> [Why Do the Police Exist? (2020)](https://novaramedia.com/2020/06/20/why-does-the-police-exist/)<!-- HN:47075422:end --><!-- HN:47076327:start -->
* [47076327](https://news.social-protocols.org/stats?id=47076327) #16 33 points 11 comments -> [Hitler's Greenland Obsession](https://www.theatlantic.com/ideas/2026/02/hitler-greenland/685984/)<!-- HN:47076327:end --><!-- HN:47076001:start -->
* [47076001](https://news.social-protocols.org/stats?id=47076001) #17 16 points 4 comments -> [Why applicant tracking systems are broken by design](https://www.saj.ad/2026/ats)<!-- HN:47076001:end --><!-- HN:47022527:start -->
* [47022527](https://news.social-protocols.org/stats?id=47022527) #6 35 points 3 comments -> [Arrays in Forth](https://www.forth.org/svfig/Len/arrays.htm)<!-- HN:47022527:end --><!-- HN:47023391:start -->
* [47023391](https://news.social-protocols.org/stats?id=47023391) #11 56 points 13 comments -> [Large Language Models for Mortals: A Practical Guide for Analysts with Python](https://crimede-coder.com/blogposts/2026/LLMsForMortals)<!-- HN:47023391:end --><!-- HN:47023510:start -->
* [47023510](https://news.social-protocols.org/stats?id=47023510) #16 6 points 2 comments -> [Show HN: Chaos Studies – attractors and spatial audio (iOS/Mac/Playdate)](https://fieldbw.com/chaos-studies/)<!-- HN:47023510:end --><!-- HN:47076826:start -->
* [47076826](https://news.social-protocols.org/stats?id=47076826) #16 129 points 38 comments -> [DOGE Bro's Grant Review Process Was Literally Just Asking ChatGPT 'Is This DEI?'](https://www.techdirt.com/2026/02/19/doge-bros-grant-review-process-was-literally-just-asking-chatgpt-is-this-dei/)<!-- HN:47076826:end --><!-- HN:47078868:start -->
* [47078868](https://news.social-protocols.org/stats?id=47078868) #20 7 points 1 comments -> [UK has not given US permission to use RAF bases for Iran strikes](https://www.bbc.co.uk/news/articles/cj98egkl7l1o)<!-- HN:47078868:end --><!-- HN:47075318:start -->
* [47075318](https://news.social-protocols.org/stats?id=47075318) #3 592 points 3 comments -> [Gemini 3.1](https://deepmind.google/models/model-cards/gemini-3-1-pro/)<!-- HN:47075318:end --><!-- HN:47079969:start -->
* [47079969](https://news.social-protocols.org/stats?id=47079969) #10 22 points 14 comments -> [Freedom.gov](https://freedom.gov/)<!-- HN:47079969:end -->
#### **Friday, February 20, 2026**<!-- HN:47086735:start -->
* [47086735](https://news.social-protocols.org/stats?id=47086735) #3 8 points 0 comments -> [A Primer on Terrorism, Insurgency and Protest](https://acoup.blog/2026/02/13/collections-against-the-state-a-primer-on-terrorism-insurgency-and-protest/)<!-- HN:47086735:end --><!-- HN:47086458:start -->
* [47086458](https://news.social-protocols.org/stats?id=47086458) #14 9 points 2 comments -> [Why Developers Keep Choosing Claude over Every Other AI](https://www.bhusalmanish.com.np/blog/posts/why-claude-wins-coding.html)<!-- HN:47086458:end --><!-- HN:47086847:start -->
* [47086847](https://news.social-protocols.org/stats?id=47086847) #2 17 points 1 comments -> [I used Claude Code and GSD to build the accessibility tool I've always wanted](https://blakewatson.com/journal/i-used-claude-code-and-gsd-to-build-the-accessibility-tool-ive-always-wanted/)<!-- HN:47086847:end --><!-- HN:47094808:start -->
* [47094808](https://news.social-protocols.org/stats?id=47094808) #10 6 points 2 comments -> [Nebraska company is supplying ICE with surveillance tech](https://flatwaterfreepress.org/this-nebraska-company-is-supplying-ice-with-surveillance-tech/)<!-- HN:47094808:end -->
#### **Saturday, February 21, 2026**<!-- HN:47096044:start -->
* [47096044](https://news.social-protocols.org/stats?id=47096044) #11 4 points 0 comments -> [Irish man detained by ICE [Update] – It's not what it seems](https://www.limerickleader.ie/news/national-news/2018902/daughter-of-man-detained-in-the-us-says-she-has-no-sympathy-whatsoever-for-her-father.html)<!-- HN:47096044:end --><!-- HN:47096210:start -->
* [47096210](https://news.social-protocols.org/stats?id=47096210) #11 28 points 17 comments -> [Claude Code's compaction discards data that's still on disk](https://github.com/anthropics/claude-code/issues/26771)<!-- HN:47096210:end --><!-- HN:47096335:start -->
* [47096335](https://news.social-protocols.org/stats?id=47096335) #26 6 points 1 comments -> [Show HN: I built a 55K-word email marketing knowledge base and Claude Code skill](https://www.emailmarketingskill.com/)<!-- HN:47096335:end --><!-- HN:47047559:start -->
* [47047559](https://news.social-protocols.org/stats?id=47047559) #19 30 points 10 comments -> [Show HN: PIrateRF – Turn a $20 Raspberry Pi Zero into a 12-mode RF transmitter](https://github.com/psyb0t/piraterf)<!-- HN:47047559:end --><!-- HN:47047936:start -->
* [47047936](https://news.social-protocols.org/stats?id=47047936) #20 -> [The Evolution of x86 SIMD: From SSE to AVX-512](https://bgslabs.org/blog/evolution-of-x86-simd/)<!-- HN:47047936:end --><!-- HN:47099473:start -->
* [47099473](https://news.social-protocols.org/stats?id=47099473) #6 13 points 6 comments -> [What Happened to Software Is Happening to Finance and Accounting](https://doempke.com/what-happened-to-software-is-happening-to-finance-and-accounting/)<!-- HN:47099473:end --><!-- HN:47101336:start -->
* [47101336](https://news.social-protocols.org/stats?id=47101336) #3 4 points 0 comments -> [Claude Code published fabricated claims to 8 platforms over 72hrs](https://github.com/anthropics/claude-code/issues/27430)<!-- HN:47101336:end --><!-- HN:47100641:start -->
* [47100641](https://news.social-protocols.org/stats?id=47100641) #15 10 points 5 comments -> [DJB's Cryptographic Odyssey: From Code Hero to Standards Gadfly](https://cryptography.watch/articles/djb-cryptographic-odyssey/)<!-- HN:47100641:end --><!-- HN:47050699:start -->
* [47050699](https://news.social-protocols.org/stats?id=47050699) #12 3 points 3 comments -> [I wrote about a bad paper](https://girl.surgery/bad_paper)<!-- HN:47050699:end --><!-- HN:47099160:start -->
* [47099160](https://news.social-protocols.org/stats?id=47099160) #16 262 points 63 comments -> [Andrej Karpathy talks about "Claws"](https://simonwillison.net/2026/Feb/21/claws/)<!-- HN:47099160:end -->
#### **Sunday, February 22, 2026**
<!-- HN:47105087:start -->
* [47105087](https://news.social-protocols.org/stats?id=47105087) #22 29 points 11 comments -> [Happy Zelda's 40th first LLM running on N64 hardware (4MB RAM, 93MHz)](https://github.com/sophiaeagent-beep/n64llm-legend-of-Elya)<!-- HN:47105087:end --><!-- HN:47106406:start -->
* [47106406](https://news.social-protocols.org/stats?id=47106406) #8 -> [Who's liable when your AI agent burns down production?](https://reading.sh/whos-liable-when-your-ai-agent-burns-down-production-039193d82746?sk=4921ed2dbc46f0c618835ac458cf5051)<!-- HN:47106406:end --><!-- HN:47107367:start -->
* [47107367](https://news.social-protocols.org/stats?id=47107367) #11 5 points 2 comments -> [Why every AI video tool feels broke](https://www.openslop.ai/blog/why-every-ai-video-tool-feels-broken)<!-- HN:47107367:end --><!-- HN:47107512:start -->
* [47107512](https://news.social-protocols.org/stats?id=47107512) #11 63 points 38 comments -> [Palantir's secret weapon isn't AI – it's Ontology. An open-source deep dive](https://github.com/Leading-AI-IO/palantir-ontology-strategy)<!-- HN:47107512:end --><!-- HN:47108538:start -->
* [47108538](https://news.social-protocols.org/stats?id=47108538) #10 52 points 13 comments -> [U.S. Cannot Legally Impose Tariffs Using Section 122 of the Trade Act of 1974](https://ielp.worldtradelaw.net/2026/01/guest-post-president-trump-cannot-legally-impose-tariffs-using-section-122-of-the-trade-act-of-1974/)<!-- HN:47108538:end --><!-- HN:47110362:start -->
* [47110362](https://news.social-protocols.org/stats?id=47110362) #19 21 points 6 comments -> [Porkbun sells out – Starts requiring Age ID despite no legal requirement](https://kb.porkbun.com/article/225-why-porkbun-id-verification)<!-- HN:47110362:end --><!-- HN:47110310:start -->
* [47110310](https://news.social-protocols.org/stats?id=47110310) #7 40 points 34 comments -> [Postgres Is Your Friend. ORM Is Not](https://hypha.pub/postgres-is-your-friend-orm-is-not)<!-- HN:47110310:end --><!-- HN:47112633:start -->
* [47112633](https://news.social-protocols.org/stats?id=47112633) #10 28 points 41 comments -> [Altman on AI energy: it also takes 20 years of eating food to train a human](https://old.reddit.com/r/singularity/comments/1rb2pzf/sam_altman_people_talk_about_how_much_energy_it/)<!-- HN:47112633:end --><!-- HN:47113883:start -->
* [47113883](https://news.social-protocols.org/stats?id=47113883) #7 8 points 5 comments -> [Green Lumber Fallacy in Software Engineering](https://www.chrisbehan.ca/posts/green-lumber-fallacy-in-software)<!-- HN:47113883:end -->
#### **Monday, February 23, 2026**
<!-- HN:47046124:start -->
* [47046124](https://news.social-protocols.org/stats?id=47046124) #14 13 points 0 comments -> [Browse Code by Meaning](https://haskellforall.com/2026/02/browse-code-by-meaning)<!-- HN:47046124:end --><!-- HN:47046433:start -->
* [47046433](https://news.social-protocols.org/stats?id=47046433) #30 32 points 49 comments -> [Write-Only Code](https://www.heavybit.com/library/article/write-only-code)<!-- HN:47046433:end --><!-- HN:47116385:start -->
* [47116385](https://news.social-protocols.org/stats?id=47116385) #23 33 points 19 comments -> [IT Staffing Firms (TCS, Cognizant, Infosis Underpay Developers by 80–100%](https://h1bdatahub.com/blog/cognizant-tcs-infosys-low-h1b-salaries-exposed)<!-- HN:47116385:end --><!-- HN:47117521:start -->
* [47117521](https://news.social-protocols.org/stats?id=47117521) #15 9 points 0 comments -> [LGP to take Mister Car Wash private in $3.1B deal](https://www.alternativeswatch.com/2026/02/22/lgp-take-mister-car-wash-private-3-1-billion-deal/)<!-- HN:47117521:end --><!-- HN:47117972:start -->
* [47117972](https://news.social-protocols.org/stats?id=47117972) #10 16 points 3 comments -> [Show HN: Openslack – An open source version of Slack](https://github.com/BilalG1/openslack)<!-- HN:47117972:end --><!-- HN:47117681:start -->
* [47117681](https://news.social-protocols.org/stats?id=47117681) #21 5 points 4 comments -> [Show HN: I scraped 5,700 YC companies to find what niches are now getting funded](https://bigideasdb.com/saas-sellers-report)<!-- HN:47117681:end --><!-- HN:47073674:start -->
* [47073674](https://news.social-protocols.org/stats?id=47073674) #14 5 points 1 comments -> [What size should I use for my queue](https://www.syntacticbrownsugar.tech/posts/what-size-queue/)<!-- HN:47073674:end --><!-- HN:47118338:start -->
* [47118338](https://news.social-protocols.org/stats?id=47118338) #30 9 points 1 comments -> [Compulsively violent people might have lower IQs](https://www.psypost.org/people-who-engage-in-impulsive-violence-tend-to-have-lower-iq-scores/)<!-- HN:47118338:end --><!-- HN:47074049:start -->
* [47074049](https://news.social-protocols.org/stats?id=47074049) #19 22 points 5 comments -> [Cursor's Debug Mode Is Arguably Its Best Feature](https://davidgomes.com/cursor-debug-mode/)<!-- HN:47074049:end --><!-- HN:47087443:start -->
* [47087443](https://news.social-protocols.org/stats?id=47087443) #21 6 points 2 comments -> [The Oracle of Bacon: Thirty Years Later](https://3quarksdaily.com/3quarksdaily/2026/02/the-oracle-of-bacon-thirty-years-later.html)<!-- HN:47087443:end --><!-- HN:47121442:start -->
* [47121442](https://news.social-protocols.org/stats?id=47121442) #12 29 points 8 comments -> [I Donut Believe – Presenting Third Party Results (Donut Lab)](https://idonutbelieve.com/)<!-- HN:47121442:end --><!-- HN:47112299:start -->
* [47112299](https://news.social-protocols.org/stats?id=47112299) #8 7 points 1 comments -> [Artist who "paints" portraits on glass by hitting it with a hammer](https://simonbergerart.com)<!-- HN:47112299:end --><!-- HN:47120901:start -->
* [47120901](https://news.social-protocols.org/stats?id=47120901) #19 39 points 41 comments -> [Don't host email yourself – your reminder in 2026](https://www.coinerella.com/dont-host-email-yourself-your-reminder-in-2026/)<!-- HN:47120901:end --><!-- HN:47122337:start -->
* [47122337](https://news.social-protocols.org/stats?id=47122337) #12 27 points 40 comments -> [How in the Hell Did Joann Fabrics Die While Best Buy Survived? It Wasn't Amazon](https://www.governance.fyi/p/how-in-the-hell-did-joann-fabrics)<!-- HN:47122337:end -->