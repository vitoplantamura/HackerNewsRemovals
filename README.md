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

#### **Tuesday, January 6, 2026**
<!-- HN:46506675:start -->
* [46506675](https://news.social-protocols.org/stats?id=46506675) #24 25 points 20 comments -> [Pink Power Ranger takes down white supremacist dating sites](https://www.thecanary.co/skwawkbox/2026/01/04/power-ranger-deletes-dating-site/)<!-- HN:46506675:end --><!-- HN:46509788:start -->
* [46509788](https://news.social-protocols.org/stats?id=46509788) #17 44 points 29 comments -> [Mapping Protests in Iran](https://www.fdd.org/analysis/2025/06/25/mapping-the-protests-in-iran-2/)<!-- HN:46509788:end --><!-- HN:46510656:start -->
* [46510656](https://news.social-protocols.org/stats?id=46510656) #13 6 points 3 comments -> [Show HN: Is this the best epoch converter?](https://epochconverter.dev/)<!-- HN:46510656:end --><!-- HN:46514707:start -->
* [46514707](https://news.social-protocols.org/stats?id=46514707) #17 2 points 0 comments -> [Show HN: Open-source Langsmith alternative written in Rust](https://github.com/lmnr-ai/lmnr)<!-- HN:46514707:end --><!-- HN:46473142:start -->
* [46473142](https://news.social-protocols.org/stats?id=46473142) #30 11 points 1 comments -> [Gtasks-terminal – Google Tasks power-tool for the terminal](https://github.com/sirusdas/gtasks-terminal)<!-- HN:46473142:end --><!-- HN:46518218:start -->
* [46518218](https://news.social-protocols.org/stats?id=46518218) #28 6 points 3 comments -> [America's affordability crisis is (mostly) a mirage](https://www.economist.com/briefing/2025/12/30/americas-affordability-crisis-is-mostly-a-mirage)<!-- HN:46518218:end --><!-- HN:46450014:start -->
* [46450014](https://news.social-protocols.org/stats?id=46450014) #29 5 points 4 comments -> [Runtime invariant to rule count in a single-pass boundary execution model](https://targetedwebresults.com/pounce-demo-final.gif)<!-- HN:46450014:end -->
#### **Wednesday, January 7, 2026**<!-- HN:46521619:start -->
* [46521619](https://news.social-protocols.org/stats?id=46521619) #27 20 points 2 comments -> [White House Posts False Jan. 6 Narrative on Riot's 5th Anniversary](https://www.nytimes.com/2026/01/06/us/politics/trump-white-house-jan-6-website.html)<!-- HN:46521619:end --><!-- HN:46520975:start -->
* [46520975](https://news.social-protocols.org/stats?id=46520975) #24 11 points 2 comments -> [Website with a DMCA Takedown](https://priyatham.in/en/post/hosting-dmca/)<!-- HN:46520975:end --><!-- HN:46451768:start -->
* [46451768](https://news.social-protocols.org/stats?id=46451768) #2 619 points 123 comments -> [Spherical Snake](https://kevinalbs.com/spherical_snake/)<!-- HN:46451768:end --><!-- HN:46470115:start -->
* [46470115](https://news.social-protocols.org/stats?id=46470115) #27 11 points 0 comments -> [Show HN: Open-source AI workflows with read-only auth scopes](https://github.com/seer-engg/seer)<!-- HN:46470115:end --><!-- HN:46472047:start -->
* [46472047](https://news.social-protocols.org/stats?id=46472047) #21 20 points 9 comments -> [Show HN: TCP chat server written in C# and .NET 9, used in the terminal](https://github.com/Sieep-Coding/simple-chat-csharp)<!-- HN:46472047:end --><!-- HN:46527443:start -->
* [46527443](https://news.social-protocols.org/stats?id=46527443) #11 -> [Supreme Court Increasingly Favors the Rich, Economists Say](https://www.nytimes.com/2026/01/05/us/politics/supreme-court-study-rich-poor.html)<!-- HN:46527443:end --><!-- HN:46529097:start -->
* [46529097](https://news.social-protocols.org/stats?id=46529097) #4 20 points 40 comments -> [The $14 Burrito: Why San Francisco Inflation Feels Higher Than 2.5%](https://www.foglinesf.com/p/the-14-burrito-why-san-francisco-inflation-feels-higher-than-2-5)<!-- HN:46529097:end --><!-- HN:46531150:start -->
* [46531150](https://news.social-protocols.org/stats?id=46531150) #12 5 points 7 comments -> [A practical guide to converting YAML to JSON safely (with Kubernetes examples)](https://coderaviverma.github.io/yaml-to-json-guide/)<!-- HN:46531150:end --><!-- HN:46533968:start -->
* [46533968](https://news.social-protocols.org/stats?id=46533968) #17 6 points 1 comments -> [Eyewitness says ICE agents gave conflicting orders before shooting woman](https://www.mprnews.org/story/2026/01/07/shooting-south-minneapolis-ice-agents-federal-operation)<!-- HN:46533968:end -->
#### **Thursday, January 8, 2026**<!-- HN:46536862:start -->
* [46536862](https://news.social-protocols.org/stats?id=46536862) #12 36 points 5 comments -> [Show HN: IceRaidsNearMe – Real-time, crowdsourced map of immigration enforcement](https://iceraidsnearme.com/)<!-- HN:46536862:end --><!-- HN:46537459:start -->
* [46537459](https://news.social-protocols.org/stats?id=46537459) #17 8 points 4 comments -> [Show HN: Lean4 proof that SSOT requires definition-time hooks and introspection](https://zenodo.org/records/18177320)<!-- HN:46537459:end --><!-- HN:46499469:start -->
* [46499469](https://news.social-protocols.org/stats?id=46499469) #20 62 points 11 comments -> [Solo ASIC tapeout on a budget: detailed write up](https://old.reddit.com/r/chipdesign/comments/1q4kvxt/solo_asic_tapeout_on_a_budget_detailed_write_up/)<!-- HN:46499469:end --><!-- HN:46460782:start -->
* [46460782](https://news.social-protocols.org/stats?id=46460782) #12 9 points 1 comments -> [I bootstrapped an AI OSINT search engine to 35k users. Trying $5 Day Pass Model](https://ai.cylect.io/)<!-- HN:46460782:end --><!-- HN:46499674:start -->
* [46499674](https://news.social-protocols.org/stats?id=46499674) #9 34 points 43 comments -> [I program without syntax highlighting](https://hakon.gylterud.net/opinion/syntax-highlighting.html)<!-- HN:46499674:end --><!-- HN:46541586:start -->
* [46541586](https://news.social-protocols.org/stats?id=46541586) #20 5 points 0 comments -> [Maine company in the spotlight after Maduro apparently wore one of their hoodies](https://www.boston.com/news/business/2026/01/06/maine-company-maduro-venezuela-hoodie/)<!-- HN:46541586:end --><!-- HN:46542206:start -->
* [46542206](https://news.social-protocols.org/stats?id=46542206) #8 9 points 0 comments -> [Icelist](https://icelist.is/)<!-- HN:46542206:end --><!-- HN:46542187:start -->
* [46542187](https://news.social-protocols.org/stats?id=46542187) #22 6 points 1 comments -> [Supreme Court Increasingly Favors the Rich, Economists Say](https://www.nytimes.com/2026/01/05/us/politics/supreme-court-study-rich-poor.html)<!-- HN:46542187:end --><!-- HN:46541885:start -->
* [46541885](https://news.social-protocols.org/stats?id=46541885) #7 32 points 23 comments -> [Show HN: A Daily Bible Game](https://bibdle.com)<!-- HN:46541885:end --><!-- HN:46543563:start -->
* [46543563](https://news.social-protocols.org/stats?id=46543563) #5 9 points 1 comments -> [BCA statement regarding investigation of ICE fatal shooting in Minneapolis](https://dps.mn.gov/news/bca/bca-statement-regarding-investigation-ice-fatal-shooting-minneapolis)<!-- HN:46543563:end --><!-- HN:46543457:start -->
* [46543457](https://news.social-protocols.org/stats?id=46543457) #30 117 points 23 comments -> [Minnesota officials say they can't access evidence after fatal ICE shooting](https://www.pbs.org/newshour/nation/minnesota-officials-say-they-cant-access-evidence-after-fatal-ice-shooting-and-fbi-wont-work-jointly-on-investigation)<!-- HN:46543457:end --><!-- HN:46487224:start -->
* [46487224](https://news.social-protocols.org/stats?id=46487224) #19 41 points 40 comments -> [The price of fame? Mortality risk among famous singers](https://jech.bmj.com/content/early/2025/11/30/jech-2025-224589)<!-- HN:46487224:end --><!-- HN:46544938:start -->
* [46544938](https://news.social-protocols.org/stats?id=46544938) #20 9 points 1 comments -> [Withdrawing the U.S. from International Organizations Not in U.S. Interests](https://www.whitehouse.gov/presidential-actions/2026/01/withdrawing-the-united-states-from-international-organizations-conventions-and-treaties-that-are-contrary-to-the-interests-of-the-united-states/)<!-- HN:46544938:end --><!-- HN:46544306:start -->
* [46544306](https://news.social-protocols.org/stats?id=46544306) #30 17 points 5 comments -> [Experts Warn U.S. in Early Stages of Genocide Against Trans Americans](https://www.lemkininstitute.com/single-post/experts-warn-u-s-in-early-stages-of-genocide-against-trans-americans)<!-- HN:46544306:end --><!-- HN:46545796:start -->
* [46545796](https://news.social-protocols.org/stats?id=46545796) #11 6 points 0 comments -> [Rethinking Quran Rendering for the Digital Age](https://tarteel.ai/blog/from-page-to-screen-rethinking-quran-rendering-for-the-digital-age/)<!-- HN:46545796:end --><!-- HN:46545962:start -->
* [46545962](https://news.social-protocols.org/stats?id=46545962) #25 27 points 9 comments -> [X faces global investigations for deepfake porn of women and minors](https://boingboing.net/2026/01/06/x-faces-global-investigations-as-grok-generates-deepfake-porn-of-women-and-minors.html)<!-- HN:46545962:end --><!-- HN:46547191:start -->
* [46547191](https://news.social-protocols.org/stats?id=46547191) #7 8 points 4 comments -> [I built a quantum internet that runs on your WiFi](https://github.com/mermaidnicheboutique-code/luxbin-quantum-internet)<!-- HN:46547191:end --><!-- HN:46547512:start -->
* [46547512](https://news.social-protocols.org/stats?id=46547512) #9 8 points 0 comments -> [Americans by Name, Punished for Believing It](https://boltsmag.org/prosecuted-for-voting-american-samoans-alaska/)<!-- HN:46547512:end -->
#### **Friday, January 9, 2026**
<!-- HN:46548190:start -->
* [46548190](https://news.social-protocols.org/stats?id=46548190) #16 25 points 2 comments -> ["Death to the Dictator": Tehran, Iran](https://www.iranintl.com/en/202601083176)<!-- HN:46548190:end --><!-- HN:46548451:start -->
* [46548451](https://news.social-protocols.org/stats?id=46548451) #30 16 points 12 comments -> [Why Are Grok and X Still Available in App Stores?](https://www.wired.com/story/x-grok-app-store-nudify-csam-apple-google-content-moderation/)<!-- HN:46548451:end --><!-- HN:46548787:start -->
* [46548787](https://news.social-protocols.org/stats?id=46548787) #5 43 points 10 comments -> [Tumblr removed from Apple App Store over abuse images](https://www.bbc.com/news/technology-46275138)<!-- HN:46548787:end --><!-- HN:46549965:start -->
* [46549965](https://news.social-protocols.org/stats?id=46549965) #14 24 points 2 comments -> [Remote Job](https://github.com/lukasz-madon/awesome-remote-job)<!-- HN:46549965:end --><!-- HN:46548724:start -->
* [46548724](https://news.social-protocols.org/stats?id=46548724) #22 15 points 1 comments -> [Iran Goes Dark as Government Cuts Itself Off from Internet](https://www.kentik.com/analysis/iran-goes-dark-as-government-cuts-itself-off-from-internet/)<!-- HN:46548724:end --><!-- HN:46551253:start -->
* [46551253](https://news.social-protocols.org/stats?id=46551253) #23 10 points 2 comments -> [Israel tells Doctors Without Borders to end its work in Gaza](https://www.nytimes.com/2026/01/06/world/middleeast/israel-bars-doctors-without-borders-gaza.html)<!-- HN:46551253:end --><!-- HN:46553342:start -->
* [46553342](https://news.social-protocols.org/stats?id=46553342) #21 14 points 17 comments -> ["If Starmer is successful in banning X in Britain, I will move forward in . . ."](https://twitter.com/RepLuna/status/2009460496668426449)<!-- HN:46553342:end --><!-- HN:46554307:start -->
* [46554307](https://news.social-protocols.org/stats?id=46554307) #19 -> [ICE Is What Happens When America Refuses to Learn from Black History](https://jemartisby.substack.com/p/ice-is-what-happens-when-america)<!-- HN:46554307:end --><!-- HN:46555439:start -->
* [46555439](https://news.social-protocols.org/stats?id=46555439) #12 35 points 10 comments -> [DHS Invokes Immigration Enforcement to Justify Gathering Americans' DNA](https://reason.com/2026/01/09/dhs-invokes-immigration-enforcement-to-justify-gathering-americans-dna/)<!-- HN:46555439:end --><!-- HN:46555705:start -->
* [46555705](https://news.social-protocols.org/stats?id=46555705) #28 8 points 0 comments -> [Inside the women's prison where violent male inmates have their way](https://thehill.com/opinion/criminal-justice/5674651-mci-framingham-sex-offenders/)<!-- HN:46555705:end --><!-- HN:46559192:start -->
* [46559192](https://news.social-protocols.org/stats?id=46559192) #3 59 points 16 comments -> [Video filmed by ICE agent who shot Minneapolis woman emerges](https://www.bbc.com/news/articles/cz7yv4524gqo)<!-- HN:46559192:end --><!-- HN:46558317:start -->
* [46558317](https://news.social-protocols.org/stats?id=46558317) #11 4 points 0 comments -> [Turn any image into a 3D Gaussian Splat](https://lab.revelium.studio/ml-sharp)<!-- HN:46558317:end --><!-- HN:46559309:start -->
* [46559309](https://news.social-protocols.org/stats?id=46559309) #2 22 points 5 comments -> [Looking for flagged discussions on HN? See what's active](https://news.ycombinator.com/active)<!-- HN:46559309:end -->
#### **Saturday, January 10, 2026**
<!-- HN:46562672:start -->
* [46562672](https://news.social-protocols.org/stats?id=46562672) #24 7 points 0 comments -> [Checks and Balances Are Dead](https://rall.com/2026/01/08/checks-and-balances-are-dead)<!-- HN:46562672:end --><!-- HN:46534466:start -->
* [46534466](https://news.social-protocols.org/stats?id=46534466) #13 9 points 4 comments -> [Samsung Galaxy Z TriFold hands-on](https://mashable.com/article/samsung-galaxy-z-trifold-hands-on-ces-2026)<!-- HN:46534466:end --><!-- HN:46565720:start -->
* [46565720](https://news.social-protocols.org/stats?id=46565720) #25 16 points 0 comments -> [Kavanaugh Stop](https://en.wikipedia.org/wiki/Kavanaugh_stop)<!-- HN:46565720:end --><!-- HN:46566100:start -->
* [46566100](https://news.social-protocols.org/stats?id=46566100) #16 12 points 9 comments -> [Show HN: Hosting 100 Linux dev environments on one VM using LXC](https://github.com/FootprintAI/Containarium)<!-- HN:46566100:end --><!-- HN:46566848:start -->
* [46566848](https://news.social-protocols.org/stats?id=46566848) #16 4 points 2 comments -> [X Is a Power Problem, Not a Platform Problem](https://connectedplaces.online/reports/a-power-problem-not-a-platform-problem/)<!-- HN:46566848:end --><!-- HN:46567151:start -->
* [46567151](https://news.social-protocols.org/stats?id=46567151) #8 7 points 4 comments -> [I Hate Go, but It Saved My Startup: An Architectural Autopsy](http://audiotext.live/blog/posts/hate-go-saved-startup-architecture/)<!-- HN:46567151:end --><!-- HN:46567588:start -->
* [46567588](https://news.social-protocols.org/stats?id=46567588) #27 -> [Kavanaugh Stop](https://en.wikipedia.org/wiki/Kavanaugh_stop)<!-- HN:46567588:end --><!-- HN:46567467:start -->
* [46567467](https://news.social-protocols.org/stats?id=46567467) #6 15 points 1 comments -> [Minnesota vs. US Federal Government Timeline Project](https://mnvsus.fyi)<!-- HN:46567467:end --><!-- HN:46567696:start -->
* [46567696](https://news.social-protocols.org/stats?id=46567696) #25 50 points 23 comments -> [Circumcision classed as possible child abuse in draft CPS document](https://www.theguardian.com/society/2026/jan/10/circumcision-classed-as-possible-child-abuse-in-draft-cps-document)<!-- HN:46567696:end --><!-- HN:46468086:start -->
* [46468086](https://news.social-protocols.org/stats?id=46468086) #9 11 points 1 comments -> [Pebble Round 2](https://techcrunch.com/2026/01/02/pebble-reboots-its-thinnest-smartwatch-with-the-pebble-round-2/)<!-- HN:46468086:end --><!-- HN:46536718:start -->
* [46536718](https://news.social-protocols.org/stats?id=46536718) #16 8 points 3 comments -> [AI Econ Seminar](https://cameron.stream/blog/econ-seminar/)<!-- HN:46536718:end -->
#### **Sunday, January 11, 2026**
<!-- HN:46572186:start -->
* [46572186](https://news.social-protocols.org/stats?id=46572186) #8 32 points 1 comments -> [Datadog, Thank You for Blocking Us](https://www.deductive.ai/blogs/datadog-thank-you-for-blocking-us)<!-- HN:46572186:end --><!-- HN:46479642:start -->
* [46479642](https://news.social-protocols.org/stats?id=46479642) #11 5 points 0 comments -> [MetaFun: Compile Haskell-like code to C++ template metaprograms](https://gergo.erdi.hu/projects/metafun/)<!-- HN:46479642:end --><!-- HN:46481060:start -->
* [46481060](https://news.social-protocols.org/stats?id=46481060) #13 35 points 7 comments -> [1970 Paris, cut into a grid and photographed](https://paris1970.jeantho.eu/index.html)<!-- HN:46481060:end --><!-- HN:46572593:start -->
* [46572593](https://news.social-protocols.org/stats?id=46572593) #27 8 points 6 comments -> [Show HN: PrintReadyBook](https://printreadybook.com/)<!-- HN:46572593:end --><!-- HN:46577869:start -->
* [46577869](https://news.social-protocols.org/stats?id=46577869) #28 35 points 17 comments -> ['F*ck You, Make Me' Without Saying the Words](https://daringfireball.net/2026/01/fuck_you_make_me_without_saying_the_words)<!-- HN:46577869:end -->
#### **Monday, January 12, 2026**<!-- HN:46514434:start -->
* [46514434](https://news.social-protocols.org/stats?id=46514434) #8 9 points 1 comments -> [Pyinfra: Turns Python code into shell commands and runs them on your servers](https://github.com/pyinfra-dev/pyinfra)<!-- HN:46514434:end -->