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

#### **Sunday, February 15, 2026**
<!-- HN:46952510:start -->
* [46952510](https://news.social-protocols.org/stats?id=46952510) #13 5 points 6 comments -> [Git with WD-40 Applied](https://github.com/Libre-WD-40/git)<!-- HN:46952510:end --><!-- HN:47021322:start -->
* [47021322](https://news.social-protocols.org/stats?id=47021322) #5 4 points 2 comments -> [I gave my AI drugs](https://github.com/nich2533/just_say_no)<!-- HN:47021322:end --><!-- HN:47021705:start -->
* [47021705](https://news.social-protocols.org/stats?id=47021705) #4 3 points 0 comments -> [Show HN: DocSync – Git hooks that block commits with stale documentation](https://github.com/suhteevah/docsync)<!-- HN:47021705:end --><!-- HN:47023333:start -->
* [47023333](https://news.social-protocols.org/stats?id=47023333) #28 16 points 9 comments -> [Show HN: Perlin Noise Terminal Animation in Rust (60 FPS, Truecolor)](https://github.com/denisepattenson/perlin-terminal)<!-- HN:47023333:end --><!-- HN:47027044:start -->
* [47027044](https://news.social-protocols.org/stats?id=47027044) #4 19 points 0 comments -> [With Apple: Fortify your app: Essential strategies to strengthen security](https://developer.apple.com/events/view/TUHA23T82K/dashboard)<!-- HN:47027044:end -->
#### **Monday, February 16, 2026**
<!-- HN:46969642:start -->
* [46969642](https://news.social-protocols.org/stats?id=46969642) #29 18 points 7 comments -> [I'm Always in the Club](https://www.lrb.co.uk/the-paper/v48/n02/christian-lorentzen/i-m-always-in-the-club)<!-- HN:46969642:end --><!-- HN:46986604:start -->
* [46986604](https://news.social-protocols.org/stats?id=46986604) #25 17 points 4 comments -> [Show HN: Solving Sudoku reasoning via Energy Geometric models](https://www.davisgeometric.com/index.html)<!-- HN:46986604:end --><!-- HN:47036116:start -->
* [47036116](https://news.social-protocols.org/stats?id=47036116) #23 25 points 40 comments -> [Intermittent fasting may make little difference to weight loss, review finds](https://www.bbc.co.uk/news/articles/c4ge7n3pq62o)<!-- HN:47036116:end --><!-- HN:47037666:start -->
* [47037666](https://news.social-protocols.org/stats?id=47037666) #26 25 points 7 comments -> [Palantir CEO wants to spray "fentanyl-laced urine" on analysts](https://twitter.com/jawwwn_/status/2023207418922959234)<!-- HN:47037666:end --><!-- HN:47039073:start -->
* [47039073](https://news.social-protocols.org/stats?id=47039073) #23 16 points 6 comments -> [Docker Swarm vs. Kubernetes in 2026](https://thedecipherist.com/articles/docker_swarm_vs_kubernetes/)<!-- HN:47039073:end -->
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
* [47047559](https://news.social-protocols.org/stats?id=47047559) #19 30 points 10 comments -> [Show HN: PIrateRF – Turn a $20 Raspberry Pi Zero into a 12-mode RF transmitter](https://github.com/psyb0t/piraterf)<!-- HN:47047559:end -->