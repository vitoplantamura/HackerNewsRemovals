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

#### **Friday, January 24, 2025**<!-- HN:42810115:start -->
* [42810115](https://news.social-protocols.org/stats?id=42810115) #8 13 points 15 comments -> [New Tesla Model Y](https://www.tesla.com/modely)<!-- HN:42810115:end --><!-- HN:42810898:start -->
* [42810898](https://news.social-protocols.org/stats?id=42810898) #12 5 points 3 comments -> [Mississippi Senate Bill 2319 – The "Contraception Begins at Erection" Act](https://billstatus.ls.state.ms.us/documents/2025/html/SB/2300-2399/SB2319IN.htm)<!-- HN:42810898:end --><!-- HN:42810496:start -->
* [42810496](https://news.social-protocols.org/stats?id=42810496) #28 4 points 1 comments -> [Where to get an anticapitalist/anti-surveillance email address](https://paper.wf/downas/where-to-get-an-anticapitalist-anti-surveillance-email-address)<!-- HN:42810496:end --><!-- HN:42810646:start -->
* [42810646](https://news.social-protocols.org/stats?id=42810646) #23 7 points 1 comments -> [New Rust Jobs Site](https://www.RustDevFindJob.com)<!-- HN:42810646:end --><!-- HN:42811704:start -->
* [42811704](https://news.social-protocols.org/stats?id=42811704) #5 5 points 4 comments -> [L33T coding is DEAD code](https://substack.com/home/post/p-155602777)<!-- HN:42811704:end --><!-- HN:42777563:start -->
* [42777563](https://news.social-protocols.org/stats?id=42777563) #28 5 points 0 comments -> [Plausible Fiction – David Spivak](https://topos.institute/blog/2024-08-27-plausible-fiction/)<!-- HN:42777563:end --><!-- HN:42810865:start -->
* [42810865](https://news.social-protocols.org/stats?id=42810865) #28 22 points 40 comments -> [Modular PC Design: Sustainable Approach Enhanced Repairability Reduced E-Waste](https://community.intel.com/t5/Blogs/Tech-Innovation/Client/Modular-PC-Design-A-Sustainable-Approach-for-Enhanced/post/1657681)<!-- HN:42810865:end --><!-- HN:42813345:start -->
* [42813345](https://news.social-protocols.org/stats?id=42813345) #12 28 points 45 comments -> [AI Is Creating a Generation of Illiterate Programmers](https://nmn.gl/blog/ai-illiterate-programmers)<!-- HN:42813345:end --><!-- HN:42810737:start -->
* [42810737](https://news.social-protocols.org/stats?id=42810737) #22 39 points 63 comments -> [New Electrical Code Could Doom Most Common EV Charging](https://www.motortrend.com/news/national-electric-code-revision-threatens-ev-charging/)<!-- HN:42810737:end --><!-- HN:42812617:start -->
* [42812617](https://news.social-protocols.org/stats?id=42812617) #10 10 points 41 comments -> [Could Self-Driving Buses Bring Vehicle Autonomy Home?](https://spectrum.ieee.org/driverless-bus)<!-- HN:42812617:end --><!-- HN:42816028:start -->
* [42816028](https://news.social-protocols.org/stats?id=42816028) #7 7 points 1 comments -> [Kubestatus: Open source tool to easily add status page to your K8s cluster](https://github.com/soub4i/kubestatus-operator)<!-- HN:42816028:end --><!-- HN:42812859:start -->
* [42812859](https://news.social-protocols.org/stats?id=42812859) #14 149 points 1 comments -> [Lightpanda: The headless browser designed for AI and automation](https://github.com/lightpanda-io/browser)<!-- HN:42812859:end --><!-- HN:42817124:start -->
* [42817124](https://news.social-protocols.org/stats?id=42817124) #23 43 points 36 comments -> [Looking for work is a full time job](https://www.resumevue.com/board)<!-- HN:42817124:end --><!-- HN:42817738:start -->
* [42817738](https://news.social-protocols.org/stats?id=42817738) #6 6 points 1 comments -> [Wikipedia 'Arbitrators' Tearfully Sanction Pro-Hamas Editors](https://thewikipediaflood.blogspot.com/2025/01/wikipedia-arbitrators-tearfully.html)<!-- HN:42817738:end -->
#### **Saturday, January 25, 2025**
<!-- HN:42786740:start -->
* [42786740](https://news.social-protocols.org/stats?id=42786740) #2 15 points 7 comments -> [The Bizzare Story of the Three Identical Strangers](https://historicflix.com/the-bizzare-story-of-the-three-identical-strangers/)<!-- HN:42786740:end --><!-- HN:42819834:start -->
* [42819834](https://news.social-protocols.org/stats?id=42819834) #3 63 points 34 comments -> [Feeling Targeted: Executive Order Ending Wasteful DEIA Efforts](https://hartmans.dreamwidth.org/101412.html)<!-- HN:42819834:end --><!-- HN:42821943:start -->
* [42821943](https://news.social-protocols.org/stats?id=42821943) #7 11 points 4 comments -> [Why Your AI Product Team Needs an AI Quality Lead](https://freeplay.ai/blog/why-your-ai-product-team-needs-an-ai-quality-lead)<!-- HN:42821943:end --><!-- HN:42822204:start -->
* [42822204](https://news.social-protocols.org/stats?id=42822204) #4 7 points 1 comments -> [TikTok's 'cute winter boots' trend explained](https://www.usermag.co/p/tiktok-cute-winter-boots-meaning-explained-algospeak)<!-- HN:42822204:end --><!-- HN:42822430:start -->
* [42822430](https://news.social-protocols.org/stats?id=42822430) #30 6 points 5 comments -> [ICE Raids Are an Escalation of Our Long-Simmering De Facto Cold Civil War](https://daringfireball.net/2025/01/ice_raids_are_an_escalation_of_a_de_facto_cold_civil_war)<!-- HN:42822430:end --><!-- HN:42822780:start -->
* [42822780](https://news.social-protocols.org/stats?id=42822780) #15 14 points 4 comments -> [Do Russians Support the War in Ukraine?](https://www.newyorker.com/news/a-reporter-at-large/do-russians-really-support-the-war-in-ukraine)<!-- HN:42822780:end --><!-- HN:42822873:start -->
* [42822873](https://news.social-protocols.org/stats?id=42822873) #4 33 points 11 comments -> [Bloomberg Announces Effort to Ensure U.S. Honors Paris Agreement Commitments](https://www.bloomberg.org/press/un-special-envoy-michael-r-bloomberg-announces-effort-to-ensure-u-s-honors-paris-agreement-commitments/)<!-- HN:42822873:end --><!-- HN:42794691:start -->
* [42794691](https://news.social-protocols.org/stats?id=42794691) #9 18 points 2 comments -> [Giant, Mysterious Spires Ruled the Earth Long Before Trees Did](https://www.smithsonianmag.com/smart-news/giant-mysterious-spires-ruled-the-earth-long-before-trees-did-what-exactly-are-these-odd-looking-fossils-13709647/)<!-- HN:42794691:end --><!-- HN:42824966:start -->
* [42824966](https://news.social-protocols.org/stats?id=42824966) #6 17 points 6 comments -> [US Department of Labor to Cease and Desist All Investigation and Enforcement](https://www.dol.gov/newsroom/releases/osec/osec20250124)<!-- HN:42824966:end -->
#### **Sunday, January 26, 2025**
<!-- HN:42826120:start -->
* [42826120](https://news.social-protocols.org/stats?id=42826120) #21 4 points 1 comments -> [GitHub Copilot web interface](https://github.com/login)<!-- HN:42826120:end --><!-- HN:42827266:start -->
* [42827266](https://news.social-protocols.org/stats?id=42827266) #6 27 points 4 comments -> [Asahi Linux Silicon M3 Series Feature Support](https://github.com/AsahiLinux/docs/wiki/M3-Series-Feature-Support)<!-- HN:42827266:end --><!-- HN:42803946:start -->
* [42803946](https://news.social-protocols.org/stats?id=42803946) #21 7 points 0 comments -> [Xbox 360 security in details: the long way to RGH3](https://swarm.ptsecurity.com/xbox-360-security-in-details-the-long-way-to-rgh3/)<!-- HN:42803946:end --><!-- HN:42832360:start -->
* [42832360](https://news.social-protocols.org/stats?id=42832360) #15 6 points 0 comments -> [DeepSeek v3 and r1 free unlimited](https://www.blackbox.ai)<!-- HN:42832360:end --><!-- HN:42831384:start -->
* [42831384](https://news.social-protocols.org/stats?id=42831384) #11 16 points 14 comments -> [Two F-14 fighter jets were diverted to USS Midway](https://theaviationgeekclub.com/that-time-two-f-14-fighter-jets-were-diverted-to-uss-midway-the-carriers-flight-deck-and-infrastructure-could-not-support-regular-operation-of-the-large-heavy-tomcat/)<!-- HN:42831384:end --><!-- HN:42832838:start -->
* [42832838](https://news.social-protocols.org/stats?id=42832838) #16 91 points 2 comments -> [Qwen2.5-7B-Instruct-1M and Qwen2.5-14B-Instruct-1M](https://simonwillison.net/2025/Jan/26/qwen25-1m/)<!-- HN:42832838:end --><!-- HN:42832132:start -->
* [42832132](https://news.social-protocols.org/stats?id=42832132) #28 46 points 50 comments -> [Austin rents have fallen for nearly two years](https://www.texastribune.org/2025/01/22/austin-texas-rents-falling/)<!-- HN:42832132:end --><!-- HN:42834911:start -->
* [42834911](https://news.social-protocols.org/stats?id=42834911) #1 102 points 12 comments -> [Mark Zuckerberg: This Man Is a Coward](https://www.theindex.media/this-man-is-a-coward/)<!-- HN:42834911:end -->
#### **Monday, January 27, 2025**
<!-- HN:42835932:start -->
* [42835932](https://news.social-protocols.org/stats?id=42835932) #3 9 points 2 comments -> [Eye Contact](https://kosayjabre.com/blog/eye_contact.html)<!-- HN:42835932:end --><!-- HN:42836675:start -->
* [42836675](https://news.social-protocols.org/stats?id=42836675) #6 30 points 15 comments -> [The race for "AI Supremacy" is over – at least for now](https://garymarcus.substack.com/p/the-race-for-ai-supremacy-is-over)<!-- HN:42836675:end --><!-- HN:42836934:start -->
* [42836934](https://news.social-protocols.org/stats?id=42836934) #6 6 points 3 comments -> [Show HN: Voice Cloning and Multilingual TTS in One Click (Windows)](https://github.com/abus-aikorea/voice-pro/blob/main/docs/README.eng.md)<!-- HN:42836934:end --><!-- HN:42838720:start -->
* [42838720](https://news.social-protocols.org/stats?id=42838720) #17 17 points 0 comments -> [Tim Cook Is Failing Us](https://joe-steel.com/2025-01-25-Tim-Cook-Is-Failing-Us.html)<!-- HN:42838720:end --><!-- HN:42831927:start -->
* [42831927](https://news.social-protocols.org/stats?id=42831927) #16 142 points 18 comments -> [OpenJazz is a free, open-source version of the classic Jazz Jackrabbit games](https://alister.eu/jazz/oj/about.php)<!-- HN:42831927:end --><!-- HN:42813683:start -->
* [42813683](https://news.social-protocols.org/stats?id=42813683) #21 53 points 3 comments -> [Wikenigma – An Encyclopedia of Unknowns](https://wikenigma.org.uk/)<!-- HN:42813683:end --><!-- HN:42838779:start -->
* [42838779](https://news.social-protocols.org/stats?id=42838779) #23 4 points 0 comments -> [Announcing support for DeepSeek-R1 in our IDE plugin, self-hosted by Qodo](https://www.qodo.ai/blog/qodo-gen-adds-self-hosted-support-for-deepseek-r1/)<!-- HN:42838779:end --><!-- HN:42806413:start -->
* [42806413](https://news.social-protocols.org/stats?id=42806413) #12 36 points 4 comments -> [Why Liquidity Matters](https://www.hiive.com/market-reports/why-liquidity-matters-motivating-tech-talent)<!-- HN:42806413:end --><!-- HN:42839880:start -->
* [42839880](https://news.social-protocols.org/stats?id=42839880) #25 3 points 0 comments -> [Verifying FPGA using Free OS tools and frameworks](https://www.hackster.io/adam-taylor/verifying-vhdl-da9a93)<!-- HN:42839880:end --><!-- HN:42817713:start -->
* [42817713](https://news.social-protocols.org/stats?id=42817713) #15 40 points 41 comments -> [GenAI Art Is the Least Imaginative Use of AI Imaginable](https://medium.com/artful-design/genai-art-is-the-least-imaginative-use-of-ai-imaginable-eb071671a9c9)<!-- HN:42817713:end --><!-- HN:42838774:start -->
* [42838774](https://news.social-protocols.org/stats?id=42838774) #16 90 points 31 comments -> [Microplastics block blood flow in the brain, mouse study reveals](https://www.nature.com/articles/d41586-025-00178-0)<!-- HN:42838774:end --><!-- HN:42841461:start -->
* [42841461](https://news.social-protocols.org/stats?id=42841461) #28 21 points 0 comments -> [How DeepSeek-R1 Was Built, for Dummies](https://www.vellum.ai/blog/the-training-of-deepseek-r1-and-ways-to-use-it)<!-- HN:42841461:end --><!-- HN:42843092:start -->
* [42843092](https://news.social-protocols.org/stats?id=42843092) #16 8 points 0 comments -> [Show HN: ProductHunt for Blog Posts](https://blogdrop.io/)<!-- HN:42843092:end --><!-- HN:42845857:start -->
* [42845857](https://news.social-protocols.org/stats?id=42845857) #20 4 points 1 comments -> [AI Doomerism Is Bullshit](https://www.everythingisbullshit.blog/p/ai-doomerism-is-bullshit)<!-- HN:42845857:end -->
#### **Tuesday, January 28, 2025**
<!-- HN:42847758:start -->
* [42847758](https://news.social-protocols.org/stats?id=42847758) #25 8 points 10 comments -> [Google says it will change Gulf of Mexico to 'Gulf of America' in Maps](https://www.cnbc.com/2025/01/27/google-maps-to-show-gulf-of-america-after-government-updates.html)<!-- HN:42847758:end --><!-- HN:42847630:start -->
* [42847630](https://news.social-protocols.org/stats?id=42847630) #21 38 points 14 comments -> [The Impact of 25% Tariffs on Canadian GDP](https://stephaniekelton.substack.com/p/the-impact-of-25-tariffs-on-canadian)<!-- HN:42847630:end --><!-- HN:42845681:start -->
* [42845681](https://news.social-protocols.org/stats?id=42845681) #17 230 points 22 comments -> [Nvidia sheds almost $600B in market cap, biggest one-day loss in US history](https://www.cnbc.com/2025/01/27/nvidia-sheds-almost-600-billion-in-market-cap-biggest-drop-ever.html)<!-- HN:42845681:end --><!-- HN:42848015:start -->
* [42848015](https://news.social-protocols.org/stats?id=42848015) #26 14 points 0 comments -> [Capitulation Is Contagious](https://www.theatlantic.com/magazine/archive/2025/03/washington-post-bezos-trump-cartoon-ann-telnaes/681406/)<!-- HN:42848015:end --><!-- HN:42849604:start -->
* [42849604](https://news.social-protocols.org/stats?id=42849604) #15 22 points 1 comments -> [Google Maps to Rename 'Gulf of Mexico' to 'Gulf of America'](https://thehill.com/policy/technology/5109912-google-maps-to-rename-gulf-of-mexico-to-gulf-of-america/)<!-- HN:42849604:end --><!-- HN:42849341:start -->
* [42849341](https://news.social-protocols.org/stats?id=42849341) #6 -> [How Communism Is Outcompeting Capitalism](https://indi.ca/how-communism-is-obviously-outcompeting-capitalism/)<!-- HN:42849341:end --><!-- HN:42849878:start -->
* [42849878](https://news.social-protocols.org/stats?id=42849878) #24 5 points 4 comments -> [Show HN: Script downloads any YouTube videos, high quality, without ads](https://github.com/pH-7/Download-Simply-Videos-From-YouTube)<!-- HN:42849878:end --><!-- HN:42851607:start -->
* [42851607](https://news.social-protocols.org/stats?id=42851607) #8 84 points 90 comments -> [AI, but at What Cost? Breakdown of AI's Carbon Footprint](https://loopbreaker.substack.com/p/ai-but-at-what-cost-breakdown-of)<!-- HN:42851607:end --><!-- HN:42845070:start -->
* [42845070](https://news.social-protocols.org/stats?id=42845070) #12 1189 points 184 comments -> [Google open-sources the Pebble OS](https://opensource.googleblog.com/2025/01/see-code-that-powered-pebble-smartwatches.html)<!-- HN:42845070:end --><!-- HN:42839650:start -->
* [42839650](https://news.social-protocols.org/stats?id=42839650) #19 472 points 979 comments -> [Nvidia’s $589B DeepSeek rout](https://finance.yahoo.com/news/asml-sinks-china-ai-startup-081823609.html)<!-- HN:42839650:end --><!-- HN:42852563:start -->
* [42852563](https://news.social-protocols.org/stats?id=42852563) #30 17 points 12 comments -> [Google Maps Will Rename Gulf of Mexico as Gulf of America in US](https://www.theguardian.com/technology/2025/jan/28/google-maps-will-rename-gulf-of-mexico-as-gulf-of-america-in-us)<!-- HN:42852563:end --><!-- HN:42850177:start -->
* [42850177](https://news.social-protocols.org/stats?id=42850177) #30 34 points 26 comments -> [Show HN: I Created a Pomodoro Timer](https://25min.work)<!-- HN:42850177:end --><!-- HN:42817123:start -->
* [42817123](https://news.social-protocols.org/stats?id=42817123) #26 9 points 1 comments -> [Show HN: Vole Machine ISA Simulator](https://faresbakhit.github.io/vole-sim/)<!-- HN:42817123:end --><!-- HN:42855283:start -->
* [42855283](https://news.social-protocols.org/stats?id=42855283) #3 145 points 50 comments -> [Berkeley Researchers Replicate DeepSeek R1's Core Tech for Just $30: A Small Mod](https://xyzlabs.substack.com/p/berkeley-researchers-replicate-deepseek)<!-- HN:42855283:end --><!-- HN:42855726:start -->
* [42855726](https://news.social-protocols.org/stats?id=42855726) #30 6 points 0 comments -> [Bitly will start showing ads on their links](https://twitter.com/steventey/status/1884273239364624855)<!-- HN:42855726:end --><!-- HN:42853023:start -->
* [42853023](https://news.social-protocols.org/stats?id=42853023) #26 9 points 1 comments -> [Stable Flow: Vital Layers for Training-Free Image Editing](https://omriavrahami.com/stable-flow/)<!-- HN:42853023:end --><!-- HN:42855734:start -->
* [42855734](https://news.social-protocols.org/stats?id=42855734) #7 52 points 35 comments -> [Boom's XB-1 becomes first civil aircraft to go supersonic](https://techcrunch.com/2025/01/28/booms-xb-1-becomes-first-civil-aircraft-to-go-supersonic/)<!-- HN:42855734:end --><!-- HN:42857652:start -->
* [42857652](https://news.social-protocols.org/stats?id=42857652) #12 3 points 0 comments -> [ALA to U.S. Department of Education: Book bans are real](https://www.ala.org/news/2025/01/book-bans-are-real)<!-- HN:42857652:end --><!-- HN:42858138:start -->
* [42858138](https://news.social-protocols.org/stats?id=42858138) #28 5 points 0 comments -> [Trump's Project 2025 Ghostwriters](https://www.citationneeded.news/trumps-project-2025-ghostwriters/)<!-- HN:42858138:end --><!-- HN:42857780:start -->
* [42857780](https://news.social-protocols.org/stats?id=42857780) #29 -> [Russell Vought: "Put Them in Trauma"](https://www.propublica.org/article/video-donald-trump-russ-vought-center-renewing-america-maga)<!-- HN:42857780:end --><!-- HN:42858134:start -->
* [42858134](https://news.social-protocols.org/stats?id=42858134) #11 9 points 4 comments -> [Next Asteroid Predicted to Hit Earth: 2024 YR4 and Other Dangerous Asteroids](https://starwalk.space/en/news/should-you-worry-about-an-asteroid-hitting-earth)<!-- HN:42858134:end --><!-- HN:42858778:start -->
* [42858778](https://news.social-protocols.org/stats?id=42858778) #6 9 points 14 comments -> [Civilization VII only needs 20 GB of free disk space](https://www.corsair.com/us/en/explorer/gamer/gaming-pcs/civilization-vii-system-requirements-and-recommended-specs/)<!-- HN:42858778:end -->
#### **Wednesday, January 29, 2025**
<!-- HN:42859781:start -->
* [42859781](https://news.social-protocols.org/stats?id=42859781) #3 12 points 2 comments -> [Paul Krugman: I Have Resigned from the Washington Post, Effective Today](https://contrarian.substack.com/p/i-have-resigned-from-the-washington)<!-- HN:42859781:end --><!-- HN:42859580:start -->
* [42859580](https://news.social-protocols.org/stats?id=42859580) #9 38 points 8 comments -> [How Google determines the names for bodies of water in Google Earth (2008)](https://publicpolicy.googleblog.com/2008/04/how-google-determines-names-for-bodies.html)<!-- HN:42859580:end --><!-- HN:42859844:start -->
* [42859844](https://news.social-protocols.org/stats?id=42859844) #25 9 points 2 comments -> [Jennifer Rubin: I Have Resigned from the Washington Post, Effective Today](https://contrarian.substack.com/p/i-have-resigned-from-the-washington)<!-- HN:42859844:end --><!-- HN:42859771:start -->
* [42859771](https://news.social-protocols.org/stats?id=42859771) #17 15 points 17 comments -> [I want my AI to get mad](https://jesseduffield.com/Angry-AI/)<!-- HN:42859771:end --><!-- HN:42860265:start -->
* [42860265](https://news.social-protocols.org/stats?id=42860265) #14 3 points 0 comments -> [Late Stage Social Capitalism](https://mebassett.info/social-capitalism)<!-- HN:42860265:end --><!-- HN:42860045:start -->
* [42860045](https://news.social-protocols.org/stats?id=42860045) #23 27 points 40 comments -> [The Americans Pledging to Buy Less–Or Even Nothing](https://www.wsj.com/personal-finance/the-americans-pledging-to-buy-lessor-even-nothing-7edeacf3)<!-- HN:42860045:end --><!-- HN:42861275:start -->
* [42861275](https://news.social-protocols.org/stats?id=42861275) #23 -> ['Miserable self-loathing poser': NeuroVigil CEO's open letter on ex-friend Musk](https://www.lonestarlive.com/news/2025/01/miserable-self-loathing-poser-elon-musks-former-friend-pens-brutal-open-letter.html)<!-- HN:42861275:end --><!-- HN:42861628:start -->
* [42861628](https://news.social-protocols.org/stats?id=42861628) #28 5 points 2 comments -> [How to run Deepseek-R1 locally for only $6000](https://twitter.com/carrigmat/status/1884244369907278106)<!-- HN:42861628:end --><!-- HN:42861708:start -->
* [42861708](https://news.social-protocols.org/stats?id=42861708) #28 4 points 0 comments -> [A Deepseek Conspiracy Theory](https://twitter.com/PalmerLuckey/status/1884351579240927677)<!-- HN:42861708:end --><!-- HN:42863884:start -->
* [42863884](https://news.social-protocols.org/stats?id=42863884) #12 9 points 3 comments -> [TU Delft PhD candidate terminated, documents bullying online [video]](https://www.youtube.com/watch?v=ChS0eT683bA)<!-- HN:42863884:end --><!-- HN:42864019:start -->
* [42864019](https://news.social-protocols.org/stats?id=42864019) #20 7 points 1 comments -> [The Middle East's first super-luxury train will gleam gold](https://www.cnn.com/travel/dream-of-the-desert-saudi-arabia-train/index.html)<!-- HN:42864019:end --><!-- HN:42864796:start -->
* [42864796](https://news.social-protocols.org/stats?id=42864796) #17 13 points 2 comments -> [AppleCare+ claim denied after MacBook Pro was destroyed in a car crash](https://9to5mac.com/2025/01/28/applecare-claim-denied-after-macbook-pro-was-destroyed-in-a-car-crash/)<!-- HN:42864796:end --><!-- HN:42867111:start -->
* [42867111](https://news.social-protocols.org/stats?id=42867111) #8 6 points 1 comments -> [Show HN: DeepSeek vs. ChatGPT – The Clash of the AI Generations](https://www.sigmabrowser.com/blog/deepseek-vs-chatgpt-which-is-better)<!-- HN:42867111:end --><!-- HN:42865527:start -->
* [42865527](https://news.social-protocols.org/stats?id=42865527) #2 1213 points 535 comments -> [OpenAI Furious DeepSeek Might Have Stolen All the Data OpenAI Stole from Us](https://www.404media.co/openai-furious-deepseek-might-have-stolen-all-the-data-openai-stole-from-us/)<!-- HN:42865527:end --><!-- HN:42868723:start -->
* [42868723](https://news.social-protocols.org/stats?id=42868723) #26 9 points 3 comments -> [Senator Ted Cruz is trying to block Wi-Fi hotspots for schoolchildren](https://arstechnica.com/tech-policy/2025/01/senator-ted-cruz-is-trying-to-block-wi-fi-hotspots-for-schoolchildren/)<!-- HN:42868723:end --><!-- HN:42869464:start -->
* [42869464](https://news.social-protocols.org/stats?id=42869464) #21 13 points 8 comments -> [White House rescinds federal aid freeze](https://www.cnn.com/2025/01/29/politics/white-house-rescind-federal-funding-freeze/index.html)<!-- HN:42869464:end --><!-- HN:42869700:start -->
* [42869700](https://news.social-protocols.org/stats?id=42869700) #27 21 points 3 comments -> ['Headed for technofascism': the rightwing roots of Silicon Valley](https://www.theguardian.com/technology/ng-interactive/2025/jan/29/silicon-valley-rightwing-technofascism)<!-- HN:42869700:end --><!-- HN:42867764:start -->
* [42867764](https://news.social-protocols.org/stats?id=42867764) #5 75 points 27 comments -> [How to run DeepSeek R1 locally](https://workos.com/blog/how-to-run-deepseek-r1-locally)<!-- HN:42867764:end -->
#### **Thursday, January 30, 2025**
<!-- HN:42874321:start -->
* [42874321](https://news.social-protocols.org/stats?id=42874321) #15 27 points 1 comments -> [FAA issues ground stop after plane crashes in Potomac River](https://www.cnn.com/2025/01/29/us/plane-crash-potomac-river/index.html)<!-- HN:42874321:end --><!-- HN:42874638:start -->
* [42874638](https://news.social-protocols.org/stats?id=42874638) #29 9 points 1 comments -> [Plane Crashes Near Washington DC after midair collision with helicopter](https://www.nytimes.com/live/2025/01/29/us/plane-crash-washington-dc)<!-- HN:42874638:end --><!-- HN:42874481:start -->
* [42874481](https://news.social-protocols.org/stats?id=42874481) #24 -> [Declassified CIA Guide to Sabotaging Fascism Is Suddenly Viral](https://www.404media.co/declassified-cia-guide-to-sabotaging-fascism-is-suddenly-viral/)<!-- HN:42874481:end --><!-- HN:42875428:start -->
* [42875428](https://news.social-protocols.org/stats?id=42875428) #2 6 points 3 comments -> [Billionaire Paul Graham haggles over £5 at charity event](https://twitter.com/paulg/status/1882901922686074942)<!-- HN:42875428:end --><!-- HN:42877325:start -->
* [42877325](https://news.social-protocols.org/stats?id=42877325) #12 10 points 1 comments -> [I Told You: Chaos Is Coming](https://freddiedeboer.substack.com/p/i-told-you-chaos-is-coming)<!-- HN:42877325:end --><!-- HN:42877355:start -->
* [42877355](https://news.social-protocols.org/stats?id=42877355) #2 11 points 0 comments -> [Rust in Peace](https://github.com/torvalds/linux/pull/1110)<!-- HN:42877355:end --><!-- HN:42877222:start -->
* [42877222](https://news.social-protocols.org/stats?id=42877222) #29 7 points 0 comments -> [Kansas faces one of the largest tuberculosis outbreaks in US history](https://abcnews.go.com/Health/kansas-faces-largest-tuberculosis-outbreak-us-history-health/story?id=118174420)<!-- HN:42877222:end --><!-- HN:42877440:start -->
* [42877440](https://news.social-protocols.org/stats?id=42877440) #28 7 points 2 comments -> [Germany: Angela Merkel chides own party over far-right help](https://www.dw.com/en/merkel-slams-cdu-far-right-support/a-71454687)<!-- HN:42877440:end --><!-- HN:42875985:start -->
* [42875985](https://news.social-protocols.org/stats?id=42875985) #7 79 points 33 comments -> [I built a website where you can pop confettis for no reason](https://poptheconfetti.website)<!-- HN:42875985:end --><!-- HN:42878271:start -->
* [42878271](https://news.social-protocols.org/stats?id=42878271) #27 3 points 0 comments -> [DC Mid Air Collision Reconstruction Using Public Data [video]](https://www.youtube.com/watch?v=pGDN2fEaiuo)<!-- HN:42878271:end --><!-- HN:42878722:start -->
* [42878722](https://news.social-protocols.org/stats?id=42878722) #30 4 points 1 comments -> [IBM seeks $3.5B savings for 2025; the next year all about AI, AI, and more AI](https://www.theregister.com/2025/01/30/ibm_q4_2024/)<!-- HN:42878722:end --><!-- HN:42879267:start -->
* [42879267](https://news.social-protocols.org/stats?id=42879267) #29 5 points 0 comments -> [Asteroid Bennu Is Packed with Life's Building Blocks, New Studies Confirm](https://www.scientificamerican.com/article/nasas-latest-asteroid-sample-hints-at-lifes-extraterrestrial-origins/)<!-- HN:42879267:end --><!-- HN:42880663:start -->
* [42880663](https://news.social-protocols.org/stats?id=42880663) #10 23 points 35 comments -> [Unintended workplace safety consequences of minimum wages](https://www.sciencedirect.com/science/article/abs/pii/S004727272400183X)<!-- HN:42880663:end --><!-- HN:42831621:start -->
* [42831621](https://news.social-protocols.org/stats?id=42831621) #30 36 points 41 comments -> [Digital Reality, Digital Shock: Growing Up at the Dawn of Cyberspace](https://www.chrbutler.com/digital-reality-digital-shock)<!-- HN:42831621:end --><!-- HN:42882593:start -->
* [42882593](https://news.social-protocols.org/stats?id=42882593) #29 4 points 0 comments -> [Logitech's peel-and-stick radar sensors](https://www.theverge.com/news/24350437/logitech-spot-mmwave-radar-presence-corporate-office-real-estate)<!-- HN:42882593:end -->