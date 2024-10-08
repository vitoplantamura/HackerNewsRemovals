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

#### **Wednesday, October 2, 2024**
<!-- HN:41714056:start -->
* [41714056](https://news.social-protocols.org/stats?id=41714056) #25 31 points 40 comments -> [What happens if someone votes by absentee/mail-in and dies before Election Day?](https://ballotpedia.org/What_happens_if_someone_votes_by_absentee/mail-in_ballot_and_dies_before_Election_Day%3F_(2024))<!-- HN:41714056:end --><!-- HN:41716102:start -->
* [41716102](https://news.social-protocols.org/stats?id=41716102) #8 18 points 14 comments -> [The Nobel Prize in Economics Is Fake](https://www.chibus.com/perspectives/2024/2/13/the-nobel-prize-in-economics-is-fake)<!-- HN:41716102:end --><!-- HN:41668372:start -->
* [41668372](https://news.social-protocols.org/stats?id=41668372) #10 69 points 10 comments -> [Nobody knows what happened within the MMC Association in 1998](https://sdomi.pl/weblog/21-nobody-knows-what-happened-at-mmca/)<!-- HN:41668372:end --><!-- HN:41717466:start -->
* [41717466](https://news.social-protocols.org/stats?id=41717466) #4 64 points 11 comments -> [Show HN: Weird Books to Read](https://bizarrebookshelf.com/)<!-- HN:41717466:end --><!-- HN:41716975:start -->
* [41716975](https://news.social-protocols.org/stats?id=41716975) #24 137 points 49 comments -> [Nvidia releases NVLM 1.0 72B open weight model](https://huggingface.co/nvidia/NVLM-D-72B)<!-- HN:41716975:end --><!-- HN:41688088:start -->
* [41688088](https://news.social-protocols.org/stats?id=41688088) #19 57 points 7 comments -> [PC Floppy Copy Protection: Vault Prolok](https://martypc.blogspot.com/2024/09/pc-floppy-copy-protection-vault-prolok.html)<!-- HN:41688088:end --><!-- HN:41719610:start -->
* [41719610](https://news.social-protocols.org/stats?id=41719610) #16 28 points 40 comments -> [GitHub's Copilot lies about its documentation. Why would I trust it with my code](https://shkspr.mobi/blog/2024/10/githubs-copilot-lies-about-its-own-documentation-so-why-would-i-trust-it-with-my-code/)<!-- HN:41719610:end --><!-- HN:41717174:start -->
* [41717174](https://news.social-protocols.org/stats?id=41717174) #28 27 points 4 comments -> [Dashi – A Streamlit Like Framework for Rubyists](https://thedayisntgray.github.io/now/2024/10/01/dashi-preview/)<!-- HN:41717174:end --><!-- HN:41719764:start -->
* [41719764](https://news.social-protocols.org/stats?id=41719764) #18 15 points 8 comments -> [Yoshua Bengio: Humanity faces a 'catastrophic' future if we don't regulate AI](https://www.livescience.com/technology/artificial-intelligence/people-always-say-these-risks-are-science-fiction-but-they-re-not-godfather-of-ai-yoshua-bengio-on-the-risks-of-machine-intelligence-to-humanity)<!-- HN:41719764:end --><!-- HN:41719680:start -->
* [41719680](https://news.social-protocols.org/stats?id=41719680) #20 11 points 3 comments -> [Former Nintendo factory in Kyoto opens as nostalgia-fuelled gaming museum](https://www.theguardian.com/games/2024/oct/02/former-nintendo-factory-in-kyoto-opens-as-nostalgia-fuelled-gaming-museum)<!-- HN:41719680:end --><!-- HN:41720685:start -->
* [41720685](https://news.social-protocols.org/stats?id=41720685) #19 35 points 37 comments -> [Famous AI Artist Says He's Losing Millions from People Stealing His Work](https://gizmodo.com/famous-ai-artist-says-hes-losing-millions-of-dollars-from-people-stealing-his-work-2000505822)<!-- HN:41720685:end --><!-- HN:41721947:start -->
* [41721947](https://news.social-protocols.org/stats?id=41721947) #24 7 points 2 comments -> [2 years after entering the graphics card game, Intel has nothing to show for it](https://www.theregister.com/2024/10/02/intel_aib_market_share/)<!-- HN:41721947:end --><!-- HN:41688499:start -->
* [41688499](https://news.social-protocols.org/stats?id=41688499) #15 40 points 27 comments -> [Porting OpenVMS to the Itanium Processor Family (2003)[pdf]](https://de.openvms.org/TUD2004/Itanium.PDF)<!-- HN:41688499:end --><!-- HN:41694509:start -->
* [41694509](https://news.social-protocols.org/stats?id=41694509) #26 6 points 0 comments -> [How to manage dangerous actions in user interfaces](https://www.smashingmagazine.com/2024/09/how-manage-dangerous-actions-user-interfaces/)<!-- HN:41694509:end --><!-- HN:41722532:start -->
* [41722532](https://news.social-protocols.org/stats?id=41722532) #7 5 points 0 comments -> [MM1.5: Methods, Analysis and Insights from Multimodal LLM Fine-Tuning](https://arxiv.org/abs/2409.20566)<!-- HN:41722532:end --><!-- HN:41723333:start -->
* [41723333](https://news.social-protocols.org/stats?id=41723333) #26 9 points 0 comments -> [OpenAI just raised $6.6B to build ever-larger AI models](https://www.theverge.com/2024/10/2/24260457/openai-funding-round-thrive-capital-6-billion)<!-- HN:41723333:end --><!-- HN:41695549:start -->
* [41695549](https://news.social-protocols.org/stats?id=41695549) #22 43 points 6 comments -> [Show HN: Pipet – CLI tool for scraping and extracting data online, with pipes](https://github.com/bjesus/pipet)<!-- HN:41695549:end --><!-- HN:41724957:start -->
* [41724957](https://news.social-protocols.org/stats?id=41724957) #26 3 points 0 comments -> [Meta smart glasses can be used to dox anyone in seconds, study finds](https://arstechnica.com/tech-policy/2024/10/harvard-students-make-auto-doxxing-smart-glasses-to-show-need-for-privacy-regs/)<!-- HN:41724957:end --><!-- HN:41725558:start -->
* [41725558](https://news.social-protocols.org/stats?id=41725558) #4 10 points 22 comments -> [Show HN: End-to-End Encrypted Dead Man's Switch](https://www.cipherwill.com/)<!-- HN:41725558:end -->
#### **Thursday, October 3, 2024**
<!-- HN:41726056:start -->
* [41726056](https://news.social-protocols.org/stats?id=41726056) #22 4 points 0 comments -> [Nvidia stunned the world with a ChatGPT rival that's as good as GPT-4o](https://bgr.com/tech/nvidia-stunned-the-world-with-a-chatgpt-rival-thats-as-good-as-gpt-4o/)<!-- HN:41726056:end --><!-- HN:41695158:start -->
* [41695158](https://news.social-protocols.org/stats?id=41695158) #20 4 points 0 comments -> [What Can a Coffee Machine Teach You About Python's Functions?](https://www.thepythoncodingstack.com/p/coffee-machine-python-function-analogy)<!-- HN:41695158:end --><!-- HN:41725584:start -->
* [41725584](https://news.social-protocols.org/stats?id=41725584) #7 7 points 0 comments -> [Code in Database vs. Code in Application](https://brandur.org/fragments/code-database-vs-app)<!-- HN:41725584:end --><!-- HN:41726724:start -->
* [41726724](https://news.social-protocols.org/stats?id=41726724) #8 8 points 4 comments -> [Watch as Tesla burns in flooded Florida garage days after Hurricane Helene](https://www.heraldtribune.com/story/weather/hurricane/2024/10/01/hurricane-helene-tesla-fire-breaks-out-in-flooded-florida-garage/75469839007/)<!-- HN:41726724:end --><!-- HN:41701339:start -->
* [41701339](https://news.social-protocols.org/stats?id=41701339) #26 10 points 6 comments -> [The box problem that baffled the boffins](https://www.theguardian.com/science/2024/sep/30/did-you-solve-it-the-box-problem-that-baffled-the-boffins)<!-- HN:41701339:end --><!-- HN:41727375:start -->
* [41727375](https://news.social-protocols.org/stats?id=41727375) #25 6 points 1 comments -> [A student built a fusion reactor at home in just 4 weeks using $2k and AI](https://bgr.com/science/a-student-built-a-fusion-reactor-at-home-in-just-4-weeks-using-2000-and-ai/)<!-- HN:41727375:end --><!-- HN:41686326:start -->
* [41686326](https://news.social-protocols.org/stats?id=41686326) #4 59 points 8 comments -> [Study: Cats in little crocheted hats shed light on feline chronic pain](https://arstechnica.com/science/2024/09/scientists-crocheted-tiny-hats-for-cats-to-record-eegs-of-brain-response-to-pain/)<!-- HN:41686326:end --><!-- HN:41728408:start -->
* [41728408](https://news.social-protocols.org/stats?id=41728408) #19 3 points 1 comments -> [Popular ad blocker uBlock Origin Lite pulled from Firefox store](https://www.pcworld.com/article/2474353/popular-ad-blocker-removed-from-firefox-extension-store.html)<!-- HN:41728408:end --><!-- HN:41727776:start -->
* [41727776](https://news.social-protocols.org/stats?id=41727776) #21 30 points 40 comments -> [Microsoft: 'ever present' AI assistants are coming](https://www.bbc.co.uk/news/articles/czj9vmnlv9zo)<!-- HN:41727776:end --><!-- HN:41687950:start -->
* [41687950](https://news.social-protocols.org/stats?id=41687950) #16 80 points 57 comments -> [Salt Water Dimmers](https://en.wikipedia.org/wiki/Salt_water_dimmers)<!-- HN:41687950:end --><!-- HN:41728859:start -->
* [41728859](https://news.social-protocols.org/stats?id=41728859) #18 38 points 36 comments -> [We avoid effort even though it can improve our well-being](https://www.newscientist.com/article/mg26435110-700-why-we-avoid-effort-even-though-it-can-improve-our-well-being/)<!-- HN:41728859:end --><!-- HN:41729359:start -->
* [41729359](https://news.social-protocols.org/stats?id=41729359) #18 20 points 8 comments -> [Amazon to increase number of advertisements on Prime Video](https://www.ft.com/content/f8112991-820c-4e09-bcf4-23b5e0f190a5)<!-- HN:41729359:end --><!-- HN:41729793:start -->
* [41729793](https://news.social-protocols.org/stats?id=41729793) #17 41 points 16 comments -> [UK will give sovereignty of Chagos Islands to Mauritius](https://www.bbc.com/news/articles/c98ynejg4l5o)<!-- HN:41729793:end --><!-- HN:41731371:start -->
* [41731371](https://news.social-protocols.org/stats?id=41731371) #28 27 points 15 comments -> [YouTube puts a Strike for showing how to setup Jellyfin](https://twitter.com/geerlingguy/status/1841477101670605205)<!-- HN:41731371:end --><!-- HN:41731970:start -->
* [41731970](https://news.social-protocols.org/stats?id=41731970) #26 8 points 0 comments -> [Bhutan's Prime Minister: 'We have to ask ourselves why we want economic growth'](https://english.elpais.com/international/2024-10-03/bhutans-prime-minister-we-have-to-ask-ourselves-why-we-want-economic-growth-it-has-to-be-ultimately-for-the-happiness-and-well-being-of-the-people.html)<!-- HN:41731970:end --><!-- HN:41733048:start -->
* [41733048](https://news.social-protocols.org/stats?id=41733048) #25 6 points 0 comments -> [In Its Ruling on Murthy vs. Missouri, the US Supreme Court Harmed Free Speech](https://www.illusionconsensus.com/p/in-its-ruling-on-murthy-v-missouri)<!-- HN:41733048:end --><!-- HN:41689833:start -->
* [41689833](https://news.social-protocols.org/stats?id=41689833) #26 13 points 1 comments -> [Earth's ambipolar electrostatic field and its role in ion escape to space](https://www.nature.com/articles/s41586-024-07480-3.epdf?sharing_token=I_iijIlqb3HMon5ISI-xBdRgN0jAjWel9jnR3ZoTv0Nyrlc02oJzExWUuDgAFVXFWQm-5tl5ZQFVbDbaRGPu8BS5_R9K9Au1gs-SKWxRrjMbJ2eV5VK-jFk3v5NbIHray3_BN5_uObULF-IXEID0EETe47O4K1uAgQiM7aC8d4E%3D)<!-- HN:41689833:end --><!-- HN:41681796:start -->
* [41681796](https://news.social-protocols.org/stats?id=41681796) #27 4 points 0 comments -> [A haze of inspiration](https://blog.gingerbeardman.com/2024/09/28/a-haze-of-inspiration/)<!-- HN:41681796:end --><!-- HN:41734889:start -->
* [41734889](https://news.social-protocols.org/stats?id=41734889) #27 5 points 1 comments -> [Opinion letter about Robert Roberson, about to be executed in Texas](https://shakenbaby.science/roberson.html)<!-- HN:41734889:end -->
#### **Friday, October 4, 2024**
<!-- HN:41702532:start -->
* [41702532](https://news.social-protocols.org/stats?id=41702532) #11 12 points 0 comments -> [Who's Allowed to Know Things?](https://deadsimpletech.com/blog/epistemology)<!-- HN:41702532:end --><!-- HN:41694154:start -->
* [41694154](https://news.social-protocols.org/stats?id=41694154) #8 63 points 27 comments -> [Tengine: Open-source web server, originated by Taobao, based on Nginx](https://tengine.taobao.org/)<!-- HN:41694154:end --><!-- HN:41737653:start -->
* [41737653](https://news.social-protocols.org/stats?id=41737653) #14 96 points 33 comments -> [IRS Direct File adds 12 additional states, covers more tax situations in 2025](https://www.irs.gov/newsroom/irs-direct-file-set-to-expand-availability-in-a-dozen-new-states-and-cover-wider-range-of-tax-situations-for-the-2025-tax-filing-season)<!-- HN:41737653:end --><!-- HN:41732851:start -->
* [41732851](https://news.social-protocols.org/stats?id=41732851) #12 94 points 34 comments -> [DOSBox-X: Enhanced Fork of DOSBox for Expanded DOS and Retro PC Support](https://github.com/joncampbell123/dosbox-x)<!-- HN:41732851:end --><!-- HN:41739216:start -->
* [41739216](https://news.social-protocols.org/stats?id=41739216) #18 4 points 0 comments -> [Girl, enslaved for 10 years by Hamas, Freed](https://nypost.com/2024/10/03/world-news/child-hostage-held-by-hamas-for-10-years-is-rescued-in-gaza/)<!-- HN:41739216:end --><!-- HN:41734119:start -->
* [41734119](https://news.social-protocols.org/stats?id=41734119) #30 149 points 82 comments -> [US Dept of Energy announces $1.5B in electric grid improvements](https://www.upi.com/Top_News/US/2024/10/03/energy-department-electric-grid-investment/3631727969828/)<!-- HN:41734119:end --><!-- HN:41735257:start -->
* [41735257](https://news.social-protocols.org/stats?id=41735257) #16 44 points 5 comments -> [Skymont: Intel’s E-Cores reach for the Sky](https://chipsandcheese.com/2024/10/03/skymont-intels-e-cores-reach-for-the-sky/)<!-- HN:41735257:end --><!-- HN:41738564:start -->
* [41738564](https://news.social-protocols.org/stats?id=41738564) #29 6 points 0 comments -> [X Corp loses court challenge over fine for child abuse material notice](https://www.abc.net.au/news/2024-10-04/x-corp-loses-court-challenge-over-child-abuse-notice/104434580)<!-- HN:41738564:end --><!-- HN:41739108:start -->
* [41739108](https://news.social-protocols.org/stats?id=41739108) #21 8 points 1 comments -> ["When evacuating, shoot at the server room"](https://old.reddit.com/r/UkraineRussiaReport/comments/1fvtb6x/ru_pov_when_evacuating_shoot_at_the_server_room/)<!-- HN:41739108:end --><!-- HN:41739953:start -->
* [41739953](https://news.social-protocols.org/stats?id=41739953) #5 5 points 0 comments -> [Senator tells Native Amerite to go back to where she came from](https://www.boisestatepublicradio.org/politics-government/2024-10-03/dan-foreman-racism-idaho-nez-perce-candidate-kendrick)<!-- HN:41739953:end --><!-- HN:41740084:start -->
* [41740084](https://news.social-protocols.org/stats?id=41740084) #11 9 points 1 comments -> [France's 31-year treasure hunt for a buried owl statue ends](https://www.theguardian.com/world/2024/oct/03/france-treasure-hunt-buried-owl-statue-ends)<!-- HN:41740084:end --><!-- HN:41737160:start -->
* [41737160](https://news.social-protocols.org/stats?id=41737160) #24 11 points 0 comments -> [Contributing to Haskell GHC (2023) [pdf]](https://ryanglscott.github.io/talk-slides/ghc-contributors-workshop-2023.pdf)<!-- HN:41737160:end --><!-- HN:41740519:start -->
* [41740519](https://news.social-protocols.org/stats?id=41740519) #24 12 points 1 comments -> [Their Uber Driver Crashed. A Pizza Order Unraveled Their Injury Lawsuit](https://www.nytimes.com/2024/10/04/nyregion/uber-eats-car-crash-injury-nj.html)<!-- HN:41740519:end --><!-- HN:41741905:start -->
* [41741905](https://news.social-protocols.org/stats?id=41741905) #19 20 points 38 comments -> [The Nobel-, Emmy-winning genius who became Google's star antitrust witness](https://www.semafor.com/article/10/02/2024/the-nobel-emmy-winning-genius-who-became-googles-star-antitrust-witness)<!-- HN:41741905:end --><!-- HN:41742542:start -->
* [41742542](https://news.social-protocols.org/stats?id=41742542) #13 8 points 1 comments -> [D-E-F-I-N-I-T-E-L-Y](http://www.d-e-f-i-n-i-t-e-l-y.com/)<!-- HN:41742542:end --><!-- HN:41743123:start -->
* [41743123](https://news.social-protocols.org/stats?id=41743123) #22 6 points 2 comments -> [Scrum's "Product Owner" Problem](https://rethinkingsoftware.substack.com/p/scrums-product-owner-problem)<!-- HN:41743123:end --><!-- HN:41743488:start -->
* [41743488](https://news.social-protocols.org/stats?id=41743488) #23 11 points 1 comments -> [The profit-obsessed monster destroying American emergency rooms](https://www.vox.com/health-care/374820/emergency-rooms-private-equity-hospitals-profits-no-surprises)<!-- HN:41743488:end --><!-- HN:41744816:start -->
* [41744816](https://news.social-protocols.org/stats?id=41744816) #16 7 points 3 comments -> [Why Do Older People Waste Their Time Playing Dumb Phone Games?](https://www.wsj.com/lifestyle/why-do-older-people-waste-their-time-playing-dumb-phone-games-d3bdd2ea)<!-- HN:41744816:end --><!-- HN:41745959:start -->
* [41745959](https://news.social-protocols.org/stats?id=41745959) #23 8 points 0 comments -> [Rust in Linux Is a Failed Experiment](https://techrights.org/n/2024/09/28/Linus_Torvalds_His_Employers_and_Critics_of_His_Employers_Can_A.shtml)<!-- HN:41745959:end --><!-- HN:41745810:start -->
* [41745810](https://news.social-protocols.org/stats?id=41745810) #29 26 points 13 comments -> [I made $1M in 67 days during Covid](https://www.marshallhaas.com/post/the-wild-story-of-how-i-made-1-036-175-in-67-days-during-covid)<!-- HN:41745810:end --><!-- HN:41701563:start -->
* [41701563](https://news.social-protocols.org/stats?id=41701563) #5 25 points 0 comments -> [Upstream containers with compiler toolchains from kernel.org](https://gtucker.io/posts/2024-09-30-korg-containers/)<!-- HN:41701563:end --><!-- HN:41697443:start -->
* [41697443](https://news.social-protocols.org/stats?id=41697443) #16 45 points 18 comments -> [Safety Goggles for Alchemists](https://jack.wrenn.fyi/blog/safety-goggles-for-alchemists/)<!-- HN:41697443:end --><!-- HN:41701864:start -->
* [41701864](https://news.social-protocols.org/stats?id=41701864) #29 89 points 17 comments -> [Manuscripts reveal the details of everyday life on the Silk Road](https://www.historytoday.com/archive/feature/secrets-silk-road)<!-- HN:41701864:end --><!-- HN:41745636:start -->
* [41745636](https://news.social-protocols.org/stats?id=41745636) #20 5 points 1 comments -> [If You Meet ET in Space, Kill Him](https://nautil.us/if-you-meet-et-in-space-kill-him-917243/)<!-- HN:41745636:end -->
#### **Saturday, October 5, 2024**<!-- HN:41717208:start -->
* [41717208](https://news.social-protocols.org/stats?id=41717208) #23 5 points 4 comments -> [Confessions of a Hinge Power User](https://www.wired.com/story/confessions-of-a-hinge-power-user/)<!-- HN:41717208:end --><!-- HN:41709525:start -->
* [41709525](https://news.social-protocols.org/stats?id=41709525) #15 9 points 3 comments -> [The mullet is alive and well in AFL](https://www.abc.net.au/news/2024-05-23/afl-mullet-count-data-analysis/103850072)<!-- HN:41709525:end --><!-- HN:41747863:start -->
* [41747863](https://news.social-protocols.org/stats?id=41747863) #28 106 points 19 comments -> [Apple releases Depth Pro, an AI model that rewrites the rules of 3D vision](https://venturebeat.com/ai/apple-releases-depth-pro-an-ai-model-that-rewrites-the-rules-of-3d-vision/)<!-- HN:41747863:end --><!-- HN:41749352:start -->
* [41749352](https://news.social-protocols.org/stats?id=41749352) #2 43 points 23 comments -> [New HBO Documentary Claims Bitcoin Creator Satoshi Nakamoto Is Len Sassaman](https://www.blockhead.co/2024/10/05/new-bitcoin-documentary-to-sheds-more-light-on-satoshi-nakamotos-identity/)<!-- HN:41749352:end --><!-- HN:41750447:start -->
* [41750447](https://news.social-protocols.org/stats?id=41750447) #20 19 points 7 comments -> [Matt Mullenweg trying to change /r/Wordpress to /r/WordPress](https://old.reddit.com/r/Wordpress/comments/1fwnybm/lets_capitalize_the_p/)<!-- HN:41750447:end --><!-- HN:41751776:start -->
* [41751776](https://news.social-protocols.org/stats?id=41751776) #22 33 points 14 comments -> [Automattic turns to weaponizing responsible disclosure against WP Engine](https://twitter.com/automattic/status/1842612123488473341)<!-- HN:41751776:end -->
#### **Sunday, October 6, 2024**
<!-- HN:41753639:start -->
* [41753639](https://news.social-protocols.org/stats?id=41753639) #7 2 points 0 comments -> [Literary Theory and Criticism](https://literariness.org/2019/03/04/critical-theory/)<!-- HN:41753639:end --><!-- HN:41752465:start -->
* [41752465](https://news.social-protocols.org/stats?id=41752465) #5 52 points 2 comments -> [Wikidata Is a Giant Crosswalk File](https://www.dbreunig.com/2024/10/04/wikidata-is-a-giant-crosswalk-file.html)<!-- HN:41752465:end --><!-- HN:41712763:start -->
* [41712763](https://news.social-protocols.org/stats?id=41712763) #13 8 points 7 comments -> [USB-C PD for an industrial Cisco IR829 router](https://eloydegen.com/blog/posts/cisco-ir829-power/)<!-- HN:41712763:end --><!-- HN:41754314:start -->
* [41754314](https://news.social-protocols.org/stats?id=41754314) #13 61 points 36 comments -> ["Extreme" Broadcom-proposed price hike would up VMware costs 1,050%, AT&T says](https://arstechnica.com/information-technology/2024/10/broadcom-tried-to-jack-vmware-prices-by-1050-percent-att-claims/)<!-- HN:41754314:end --><!-- HN:41750630:start -->
* [41750630](https://news.social-protocols.org/stats?id=41750630) #16 190 points 129 comments -> [I Stayed](https://zeldman.com/2024/10/04/i-stayed/)<!-- HN:41750630:end --><!-- HN:41728185:start -->
* [41728185](https://news.social-protocols.org/stats?id=41728185) #19 82 points 24 comments -> [IPU6 camera support in Fedora 41](https://hansdegoede.dreamwidth.org/28841.html)<!-- HN:41728185:end --><!-- HN:41754074:start -->
* [41754074](https://news.social-protocols.org/stats?id=41754074) #27 160 points 146 comments -> [We need a real GNU/Linux (not Android) smartphone ecosystem](https://old.reddit.com/r/linux/comments/1fx5fq0/we_need_a_real_gnulinux_not_android_smartphone/)<!-- HN:41754074:end --><!-- HN:41754657:start -->
* [41754657](https://news.social-protocols.org/stats?id=41754657) #29 8 points 0 comments -> [Speeding up the Rust compiler without changing its code](https://kobzol.github.io/rust/rustc/2022/10/27/speeding-rustc-without-changing-its-code.html)<!-- HN:41754657:end --><!-- HN:41756088:start -->
* [41756088](https://news.social-protocols.org/stats?id=41756088) #9 3 points 0 comments -> [Open Letter from American Medical Professionals Who Served in Gaza](https://www.gazahealthcareletters.org/usa-letter-oct-2-2024)<!-- HN:41756088:end --><!-- HN:41756336:start -->
* [41756336](https://news.social-protocols.org/stats?id=41756336) #15 12 points 1 comments -> [Satoshi Nakamoto identity revealed? HBO claims it](https://twitter.com/WatcherGuru/status/1841901176562094484)<!-- HN:41756336:end --><!-- HN:41756747:start -->
* [41756747](https://news.social-protocols.org/stats?id=41756747) #25 6 points 5 comments -> [Mars is now a political football](https://old.reddit.com/r/EnoughMuskSpam/comments/1fnvt8n/elon_musk_wont_go_to_mars_if_kamala_harris/)<!-- HN:41756747:end --><!-- HN:41756220:start -->
* [41756220](https://news.social-protocols.org/stats?id=41756220) #8 25 points 41 comments -> [200GB Free Cloud for Your Files](https://blog.tomaszdunia.pl/darmowa-chmura-200gb-eng/)<!-- HN:41756220:end --><!-- HN:41756284:start -->
* [41756284](https://news.social-protocols.org/stats?id=41756284) #21 25 points 2 comments -> [Pocketbase v0.23.0-RC Prerelease](https://github.com/pocketbase/pocketbase/releases/tag/v0.23.0-rc)<!-- HN:41756284:end --><!-- HN:41723315:start -->
* [41723315](https://news.social-protocols.org/stats?id=41723315) #18 21 points 7 comments -> [Identification of officer from Sir John franklin's Northwest Passage expedition](https://www.sciencedirect.com/science/article/pii/S2352409X24003766)<!-- HN:41723315:end --><!-- HN:41758101:start -->
* [41758101](https://news.social-protocols.org/stats?id=41758101) #24 4 points 1 comments -> [CJ Hopkins Acquital Overturned – The New Normal Germany](https://consentfactory.org/2024/10/05/fear-and-loathing-in-new-normal-germany/)<!-- HN:41758101:end --><!-- HN:41758572:start -->
* [41758572](https://news.social-protocols.org/stats?id=41758572) #11 6 points 2 comments -> [Harvard students hack Meta glasses to compile dossiers on strangers in real time [video]](https://www.youtube.com/watch?v=zKVXNVnPCrQ)<!-- HN:41758572:end -->
#### **Monday, October 7, 2024**
<!-- HN:41761797:start -->
* [41761797](https://news.social-protocols.org/stats?id=41761797) #5 7 points 3 comments -> [Proven Risks of Refillable Soap Dispensers](https://www.gojo.com/en/Newsroom/Blog/2023/Proven-Risks-of-Refillable-Soap-Dispensers)<!-- HN:41761797:end --><!-- HN:41762500:start -->
* [41762500](https://news.social-protocols.org/stats?id=41762500) #21 22 points 4 comments -> [Scarlet Rot: a biological exploration of Elden Ring's decaying disease](https://jgeekstudies.org/2024/10/06/scarlet-rot-a-biological-exploration-of-elden-rings-decaying-disease/)<!-- HN:41762500:end --><!-- HN:41761511:start -->
* [41761511](https://news.social-protocols.org/stats?id=41761511) #23 69 points 10 comments -> [The SQLite Amalgamation](https://www.sqlite.org/amalgamation.html)<!-- HN:41761511:end --><!-- HN:41761900:start -->
* [41761900](https://news.social-protocols.org/stats?id=41761900) #30 11 points 5 comments -> [Future Halo Titles to Use Unreal Engine](https://www.halowaypoint.com/news/a-new-dawn)<!-- HN:41761900:end --><!-- HN:41762397:start -->
* [41762397](https://news.social-protocols.org/stats?id=41762397) #22 94 points 50 comments -> [Nintendo isn't just attacking emulators [video]](https://www.youtube.com/watch?v=sk6MK5Wpx4o)<!-- HN:41762397:end --><!-- HN:41758644:start -->
* [41758644](https://news.social-protocols.org/stats?id=41758644) #18 138 points 42 comments -> [Popular Science Magazine Archives, May 1872-March 2009](https://books.google.com/books/about/Popular_Science.html?id=qR8DAAAAMBAJ)<!-- HN:41758644:end --><!-- HN:41763176:start -->
* [41763176](https://news.social-protocols.org/stats?id=41763176) #22 8 points 0 comments -> [Hello, Perceptron](https://matt.might.net/articles/hello-perceptron/)<!-- HN:41763176:end --><!-- HN:41749288:start -->
* [41749288](https://news.social-protocols.org/stats?id=41749288) #30 60 points 15 comments -> [Compiling and running sqlite3-rsync from a branch](https://til.simonwillison.net/sqlite/compile-sqlite3-rsync)<!-- HN:41749288:end --><!-- HN:41760421:start -->
* [41760421](https://news.social-protocols.org/stats?id=41760421) #30 232 points 294 comments -> [Rust needs a web framework](https://ntietz.com/blog/rust-needs-a-web-framework-for-lazy-developers/)<!-- HN:41760421:end --><!-- HN:41767383:start -->
* [41767383](https://news.social-protocols.org/stats?id=41767383) #24 5 points 0 comments -> [Why trolls, extremists, and others spread conspiracy theories they don't believe](https://theconversation.com/some-online-conspiracy-spreaders-dont-even-believe-the-lies-theyre-spewing-237730)<!-- HN:41767383:end --><!-- HN:41768259:start -->
* [41768259](https://news.social-protocols.org/stats?id=41768259) #28 4 points 1 comments -> [AI will use a lot of energy. That's good for the climate](https://climate.benjames.io/ai-go-brrr/)<!-- HN:41768259:end --><!-- HN:41768752:start -->
* [41768752](https://news.social-protocols.org/stats?id=41768752) #5 44 points 6 comments -> [Decoding Bitcoin: An interactive, exercise-heavy approach to learning Bitcoin](https://bitcoindevs.xyz/decoding)<!-- HN:41768752:end --><!-- HN:41767279:start -->
* [41767279](https://news.social-protocols.org/stats?id=41767279) #26 13 points 16 comments -> [Hot Take: Don'T provide incident resolution estimates](https://firehydrant.com/blog/hot-take-dont-provide-incident-resolution-estimates/)<!-- HN:41767279:end -->
#### **Tuesday, October 8, 2024**
<!-- HN:41772683:start -->
* [41772683](https://news.social-protocols.org/stats?id=41772683) #2 7 points 0 comments -> [I immersed myself in furry culture. You don't understand them](https://www.michigandaily.com/statement/i-immersed-myself-in-furry-culture-you-dont-understand-them/)<!-- HN:41772683:end --><!-- HN:41772662:start -->
* [41772662](https://news.social-protocols.org/stats?id=41772662) #28 12 points 2 comments -> [Satyagraha: The Highest Practise of Democracy and Freedom](https://journals.sagepub.com/doi/full/10.1177/0049085721993160)<!-- HN:41772662:end --><!-- HN:41727005:start -->
* [41727005](https://news.social-protocols.org/stats?id=41727005) #17 81 points 58 comments -> [Solving the Maker-Taker Problem](https://dri.es/solving-the-maker-taker-problem)<!-- HN:41727005:end --><!-- HN:41774300:start -->
* [41774300](https://news.social-protocols.org/stats?id=41774300) #22 3 points 1 comments -> [Cognizant Discriminated Against Non-Indian Workers, US Jury Says](https://www.bloomberg.com/news/articles/2024-10-08/cognizant-discriminated-against-non-indian-workers-us-jury-says)<!-- HN:41774300:end --><!-- HN:41774268:start -->
* [41774268](https://news.social-protocols.org/stats?id=41774268) #26 5 points 4 comments -> [I just signed up for Twilio Sendgrid, and got instantly permabanned](https://www.twilio.com/en-us/sendgrid/email-api)<!-- HN:41774268:end --><!-- HN:41775521:start -->
* [41775521](https://news.social-protocols.org/stats?id=41775521) #6 18 points 2 comments -> [Nobel Prize goes to John Hopfield and Geoffrey Hinton work on machine learning](https://www.bbc.co.uk/news/articles/c62r02z75jyo)<!-- HN:41775521:end --><!-- HN:41769971:start -->
* [41769971](https://news.social-protocols.org/stats?id=41769971) #15 179 points 465 comments -> [Is the attack helicopter dead?](https://hushkit.net/2024/10/07/is-the-attack-helicopter-dead/)<!-- HN:41769971:end --><!-- HN:41769648:start -->
* [41769648](https://news.social-protocols.org/stats?id=41769648) #10 143 points 46 comments -> [Wigle.net: All the networks, found by everyone](https://wigle.net/)<!-- HN:41769648:end --><!-- HN:41774001:start -->
* [41774001](https://news.social-protocols.org/stats?id=41774001) #11 28 points 7 comments -> [Show HN: Running Game Boy ROMs on the STM32 ARM Cortex Microcontroller](https://github.com/jnz/stm32boy)<!-- HN:41774001:end --><!-- HN:41768658:start -->
* [41768658](https://news.social-protocols.org/stats?id=41768658) #21 424 points 191 comments -> [US antitrust case against Amazon to move forward](https://www.reuters.com/technology/us-antitrust-case-against-amazon-move-forward-2024-10-07/)<!-- HN:41768658:end --><!-- HN:41767644:start -->
* [41767644](https://news.social-protocols.org/stats?id=41767644) #17 165 points 63 comments -> [Show HN: Compiling C in the browser using WebAssembly](https://wasmer.io/posts/clang-in-browser)<!-- HN:41767644:end --><!-- HN:41773096:start -->
* [41773096](https://news.social-protocols.org/stats?id=41773096) #18 24 points 15 comments -> [Rust GPU: The future of GPU programming](https://rust-gpu.github.io/)<!-- HN:41773096:end --><!-- HN:41769346:start -->
* [41769346](https://news.social-protocols.org/stats?id=41769346) #21 91 points 2 comments -> [EuroBSDcon 2024: Some notes after the conference](https://blog.netbsd.org/tnf/entry/eurobsdcon_2024_in_dublin_ireland)<!-- HN:41769346:end --><!-- HN:41775872:start -->
* [41775872](https://news.social-protocols.org/stats?id=41775872) #29 9 points 0 comments -> [Tesla Cybertruck 'too big and sharp' for European roads, say campaigners](https://www.theguardian.com/technology/2024/oct/08/tesla-cybertruck-too-big-and-sharp-for-european-roads-say-campaigners)<!-- HN:41775872:end --><!-- HN:41769932:start -->
* [41769932](https://news.social-protocols.org/stats?id=41769932) #21 81 points 13 comments -> [Gunter's Space Page](https://space.skyrocket.de/index.html)<!-- HN:41769932:end --><!-- HN:41775795:start -->
* [41775795](https://news.social-protocols.org/stats?id=41775795) #25 11 points 7 comments -> [US House panel probes FCC decision to deny Starlink nearly $900M](https://www.reuters.com/technology/us-house-panel-probes-fcc-decision-deny-starlink-nearly-900-million-2024-10-07/)<!-- HN:41775795:end --><!-- HN:41775592:start -->
* [41775592](https://news.social-protocols.org/stats?id=41775592) #26 10 points 0 comments -> [Generation Never-Called-in-Sick](https://www.businessinsider.com/baby-boomers-gen-z-sick-days-time-off-work-regret-2024-9)<!-- HN:41775592:end --><!-- HN:41777301:start -->
* [41777301](https://news.social-protocols.org/stats?id=41777301) #11 20 points 3 comments -> [Geoffrey Hinton and John Hopfield win Nobel Prize in physics](https://www.theguardian.com/science/2024/oct/08/nobel-prize-physics-john-hopfield-geoffrey-hinton-machine-learning)<!-- HN:41777301:end --><!-- HN:41777803:start -->
* [41777803](https://news.social-protocols.org/stats?id=41777803) #13 8 points 2 comments -> [Let's prepare for life without Twitter](https://www.prweek.com/article/1890974/lets-prepare-life-without-twitter)<!-- HN:41777803:end -->