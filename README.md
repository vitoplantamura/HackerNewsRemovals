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

#### **Saturday, May 2, 2026**
<!-- HN:47982293:start -->
* [47982293](https://news.social-protocols.org/stats?id=47982293) #22 13 points 2 comments -> [Thousands of Pentagon Civilian Workers Will Be Fired Next Week as Purge Begins](https://www.military.com/daily-news/2025/02/21/pentagon-fire-5400-civilian-employees-first-step-trumps-purge-of-federal-workers.html)<!-- HN:47982293:end --><!-- HN:47984301:start -->
* [47984301](https://news.social-protocols.org/stats?id=47984301) #9 5 points 0 comments -> [Show HN: Hollow is an open-sourced self-modifying agentic system](https://github.com/ninjahawk/hollow-agentOS)<!-- HN:47984301:end --><!-- HN:47984486:start -->
* [47984486](https://news.social-protocols.org/stats?id=47984486) #18 28 points 15 comments -> [SKILL.make: Makefile Styled Skill File](https://github.com/Teaonly/SKILL.make)<!-- HN:47984486:end --><!-- HN:47985353:start -->
* [47985353](https://news.social-protocols.org/stats?id=47985353) #14 36 points 13 comments -> [Pushed by Trump policies, top U.S. battery scientist is moving to Singapore](https://www.science.org/content/article/pushed-trump-policies-top-u-s-battery-scientist-moving-singapore)<!-- HN:47985353:end --><!-- HN:47985725:start -->
* [47985725](https://news.social-protocols.org/stats?id=47985725) #4 22 points 11 comments -> [The Century-Long Pause in Fundamental Physics](https://danieltan.weblog.lol/2026/05/the-century-long-pause-in-fundamental-physics)<!-- HN:47985725:end --><!-- HN:47986578:start -->
* [47986578](https://news.social-protocols.org/stats?id=47986578) #1 24 points 15 comments -> [Mini PC for local LLMs in 2026](https://terminalbytes.com/best-mini-pc-for-local-llm-2026/)<!-- HN:47986578:end --><!-- HN:47985704:start -->
* [47985704](https://news.social-protocols.org/stats?id=47985704) #23 55 points 11 comments -> [Craig Venter of Human Genome Project Dies at 79](https://www.economist.com/obituary/2026/05/01/craig-venter-raced-to-decode-the-human-genome)<!-- HN:47985704:end --><!-- HN:47957680:start -->
* [47957680](https://news.social-protocols.org/stats?id=47957680) #21 6 points 0 comments -> [Demonstrating the idea of gamma camera imaging [video]](https://www.youtube.com/watch?v=PyGlHtvihXA)<!-- HN:47957680:end --><!-- HN:47989931:start -->
* [47989931](https://news.social-protocols.org/stats?id=47989931) #18 38 points 33 comments -> [I Do Not Recommend Bitwarden](https://xn--gckvb8fzb.com/i-do-not-recommend-bitwarden/)<!-- HN:47989931:end --><!-- HN:47953347:start -->
* [47953347](https://news.social-protocols.org/stats?id=47953347) #16 68 points 137 comments -> [Why IPv6 is so complicated](https://github.com/becarpenter/book6/blob/main/01.%20Introduction%20and%20Foreword/Why%20IPv6%20is%20so%20complicated.md)<!-- HN:47953347:end -->
#### **Sunday, May 3, 2026**
<!-- HN:47992351:start -->
* [47992351](https://news.social-protocols.org/stats?id=47992351) #16 3 points 3 comments -> [A Common Proof of the Riemann Hypothesis and the Collatz Conjecture](https://www.academia.edu/166172334/A_Common_Proof_of_the_Riemann_Hypothesis_and_the_Collatz_Conjecture_Echo_Interference_in_Number_Theoretic_Acoustic_Spacetime)<!-- HN:47992351:end --><!-- HN:47993636:start -->
* [47993636](https://news.social-protocols.org/stats?id=47993636) #9 10 points 3 comments -> [The Reality of Being a Man in Your 50s in South Korea](https://indignified.com/the-hidden-realities-of-midlife-masculinity-in-south-korea/)<!-- HN:47993636:end --><!-- HN:47962645:start -->
* [47962645](https://news.social-protocols.org/stats?id=47962645) #6 86 points 16 comments -> [The IBM Granite 4.1 family of models](https://research.ibm.com/blog/granite-4-1-ai-foundation-models)<!-- HN:47962645:end --><!-- HN:47995065:start -->
* [47995065](https://news.social-protocols.org/stats?id=47995065) #7 7 points 3 comments -> [Thoth – open-source Local-first AI Assistant](https://github.com/siddsachar/Thoth)<!-- HN:47995065:end --><!-- HN:47995815:start -->
* [47995815](https://news.social-protocols.org/stats?id=47995815) #11 15 points 5 comments -> [All Four Sentinel-1 Satellites Are Now Live](https://orbitaltoday.com/2026/05/03/all-four-sentinel-1-satellites-are-now-live-and-europes-earth-watch-just-got-stronger/)<!-- HN:47995815:end --><!-- HN:47996945:start -->
* [47996945](https://news.social-protocols.org/stats?id=47996945) #10 5 points 0 comments -> [The Petroleum System Is Entering Its Volatile Decline Phase](https://cleantechnica.com/2026/04/29/the-petroleum-system-is-entering-its-volatile-decline-phase/)<!-- HN:47996945:end --><!-- HN:47990047:start -->
* [47990047](https://news.social-protocols.org/stats?id=47990047) #12 17 points 4 comments -> [Automating Hermitage to see how transactions differ in MySQL and MariaDB](https://theconsensus.dev/p/2026/05/02/automating-hermitage.html)<!-- HN:47990047:end --><!-- HN:47997403:start -->
* [47997403](https://news.social-protocols.org/stats?id=47997403) #19 8 points 8 comments -> [The Hiddn Financial Bubble in AI Infrastructure [pdf]](https://financial-ai-bubble.pagey.site/The-Hidden-Financial-Bubble-in-AI-Infrastructure.pdf)<!-- HN:47997403:end --><!-- HN:47999395:start -->
* [47999395](https://news.social-protocols.org/stats?id=47999395) #9 21 points 5 comments -> [Maybe AI Isn't a Bubble After All](https://www.theatlantic.com/economy/2026/05/ai-bubble-revenue-anthropic/687022/)<!-- HN:47999395:end -->
#### **Monday, May 4, 2026**
<!-- HN:48005000:start -->
* [48005000](https://news.social-protocols.org/stats?id=48005000) #22 9 points 0 comments -> [Israel national security minister served gold death penalty noose birthday cake](https://www.independent.co.uk/news/world/middle-east/israel-minister-death-penalty-noose-birthday-cake-b2969820.html)<!-- HN:48005000:end --><!-- HN:48005484:start -->
* [48005484](https://news.social-protocols.org/stats?id=48005484) #4 9 points 4 comments -> [Midori, the first browser to offer a VPN with Mesh technology](https://astian.org/midori-en/performance-adblock-and-more-in-midori-11-7-1/)<!-- HN:48005484:end --><!-- HN:48006522:start -->
* [48006522](https://news.social-protocols.org/stats?id=48006522) #18 11 points 4 comments -> [Ruflo: Multi-agent AI orchestration for Claude Code](https://github.com/ruvnet/ruflo/blob/main/docs/USERGUIDE.md)<!-- HN:48006522:end --><!-- HN:48006832:start -->
* [48006832](https://news.social-protocols.org/stats?id=48006832) #2 -> [Amsterdam bans public adverts for meat and fossil fuels](https://www.bbc.com/news/articles/c9wejdekpwyo)<!-- HN:48006832:end --><!-- HN:48007145:start -->
* [48007145](https://news.social-protocols.org/stats?id=48007145) #7 89 points 35 comments -> [ASML's Best Selling Product Isn't What You Think It Is](https://www.siliconimist.com/p/asmls-best-selling-product)<!-- HN:48007145:end --><!-- HN:48008805:start -->
* [48008805](https://news.social-protocols.org/stats?id=48008805) #6 7 points 1 comments -> [Show HN: Let – Offline-first life events tracker (React Native, SQLite)](https://github.com/p32929/let)<!-- HN:48008805:end --><!-- HN:48010033:start -->
* [48010033](https://news.social-protocols.org/stats?id=48010033) #10 8 points 6 comments -> [Hallucination Is Inevitable: An Innate Limitation of Large Language Models](https://arxiv.org/abs/2401.11817)<!-- HN:48010033:end --><!-- HN:48008326:start -->
* [48008326](https://news.social-protocols.org/stats?id=48008326) #20 102 points 54 comments -> [Someone allegedly used a hairdryer to rig Polymarket weather bets](https://www.engadget.com/big-tech/someone-allegedly-used-a-hairdryer-to-rig-polymarket-weather-bets-155312411.html)<!-- HN:48008326:end --><!-- HN:48010992:start -->
* [48010992](https://news.social-protocols.org/stats?id=48010992) #22 22 points 3 comments -> ["They would never use the death star on us"](https://www.mcsweeneys.net/articles/they-would-never-use-the-death-star-on-us-alderaan-residents-reflect-on-their-support-for-the-empire-as-a-large-imperial-installation-enters-the-system)<!-- HN:48010992:end --><!-- HN:48009697:start -->
* [48009697](https://news.social-protocols.org/stats?id=48009697) #3 527 points 449 comments -> [Removable batteries in smartphones will be mandatory in the EU starting in 2027](https://www.ecopv-eu.com/en/blog-en/replaceable-smartphone-batteries-2027-eu-regulation/)<!-- HN:48009697:end --><!-- HN:48012695:start -->
* [48012695](https://news.social-protocols.org/stats?id=48012695) #19 25 points 17 comments -> [Rumor: Disney to Remove Star Wars Sequel Trilogy from Timeline](https://geeksandgamers.com/remove-star-wars-sequel-trilogy/)<!-- HN:48012695:end --><!-- HN:48015006:start -->
* [48015006](https://news.social-protocols.org/stats?id=48015006) #19 6 points 5 comments -> [Claude Is Dead](https://www.javiertordable.com/claude-is-dead/)<!-- HN:48015006:end --><!-- HN:48015146:start -->
* [48015146](https://news.social-protocols.org/stats?id=48015146) #18 20 points 40 comments -> [Welcome to Gas City](https://steve-yegge.medium.com/welcome-to-gas-city-57f564bb3607)<!-- HN:48015146:end --><!-- HN:48015548:start -->
* [48015548](https://news.social-protocols.org/stats?id=48015548) #12 15 points 5 comments -> [What do we lose when AI does our work?](https://rickyyean.com/2026/05/04/what-do-we-lose-when-ai-does-our-work/)<!-- HN:48015548:end -->
#### **Tuesday, May 5, 2026**
<!-- HN:48017526:start -->
* [48017526](https://news.social-protocols.org/stats?id=48017526) #23 6 points 8 comments -> [Linux, Windows or macOS: Which Operating System to Use in 2026?](https://www.lucasaguiar.xyz/posts/linux-windows-macos-qual-usar-2026/)<!-- HN:48017526:end --><!-- HN:48017602:start -->
* [48017602](https://news.social-protocols.org/stats?id=48017602) #13 12 points 4 comments -> [An LLM agent that runs on any Linux box](https://getclaw.site/#demo)<!-- HN:48017602:end --><!-- HN:48018098:start -->
* [48018098](https://news.social-protocols.org/stats?id=48018098) #11 10 points 5 comments -> [OpenAI can't build working RSS feeds](https://openai.com/news/rss.xml)<!-- HN:48018098:end --><!-- HN:48020249:start -->
* [48020249](https://news.social-protocols.org/stats?id=48020249) #25 13 points 8 comments -> [Show HN: Got tired of paying $100/mo for SEO tools, so I built an alternative](https://idiotproofseo.com/)<!-- HN:48020249:end --><!-- HN:48027022:start -->
* [48027022](https://news.social-protocols.org/stats?id=48027022) #13 8 points 5 comments -> [What five years of data tells us about lasting relationships](https://hanker.dating/study)<!-- HN:48027022:end -->
#### **Wednesday, May 6, 2026**
<!-- HN:48029034:start -->
* [48029034](https://news.social-protocols.org/stats?id=48029034) #26 16 points 6 comments -> [A website ranking judges by elo for the cases they dismiss in SF](https://sfcrime.pages.dev/)<!-- HN:48029034:end --><!-- HN:48029334:start -->
* [48029334](https://news.social-protocols.org/stats?id=48029334) #13 143 points 3 comments -> [Zuckerberg 'personally authorized' Meta's copyright infringement, publishers say](https://apnews.com/article/meta-mark-zuckerberg-ai-publishers-lawsuit-llama-5609846d4d840014974a847b01079c32)<!-- HN:48029334:end --><!-- HN:48033118:start -->
* [48033118](https://news.social-protocols.org/stats?id=48033118) #5 11 points 1 comments -> [.de domains were 'down' for 2 hours](https://status.denic.de/pages/incident/592577eab611ce1e0d00046f/69fa60ef9d12f5057a974f38)<!-- HN:48033118:end --><!-- HN:48033729:start -->
* [48033729](https://news.social-protocols.org/stats?id=48033729) #4 8 points 2 comments -> [You made me rich, thank you](https://github.com/theori-io/copy-fail-CVE-2026-31431/issues/128)<!-- HN:48033729:end --><!-- HN:48033689:start -->
* [48033689](https://news.social-protocols.org/stats?id=48033689) #30 34 points 35 comments -> [The Boring Internet](https://www.terrygodier.com/the-boring-internet)<!-- HN:48033689:end --><!-- HN:48033952:start -->
* [48033952](https://news.social-protocols.org/stats?id=48033952) #22 10 points 2 comments -> [The AI operator: Biggest role in Silicon Valley](https://www.rishgupta.com/blog/the-ai-operator-biggest-role-in-silicon-valley)<!-- HN:48033952:end --><!-- HN:48034372:start -->
* [48034372](https://news.social-protocols.org/stats?id=48034372) #19 24 points 14 comments -> [NZ Government to Disestablish the BSA](https://www.beehive.govt.nz/release/government-disestablish-bsa)<!-- HN:48034372:end --><!-- HN:48035874:start -->
* [48035874](https://news.social-protocols.org/stats?id=48035874) #5 5 points 0 comments -> [Australia will run an overt command economy by 2040](https://caseyhandmer.wordpress.com/2026/04/16/australia-will-run-an-overt-command-economy-by-2040/)<!-- HN:48035874:end --><!-- HN:48036524:start -->
* [48036524](https://news.social-protocols.org/stats?id=48036524) #8 5 points 3 comments -> [The next great software company won't sell software](https://blog.layerx.xyz/service-as-a-software)<!-- HN:48036524:end --><!-- HN:48037465:start -->
* [48037465](https://news.social-protocols.org/stats?id=48037465) #2 27 points 8 comments -> [Some kids are bypassing age verification checks with a fake mustache](https://techcrunch.com/2026/05/06/some-kids-are-bypassing-age-verification-checks-with-a-fake-mustache/)<!-- HN:48037465:end --><!-- HN:48038031:start -->
* [48038031](https://news.social-protocols.org/stats?id=48038031) #6 29 points 40 comments -> [The Disadvantages of an Elite Education (2008)](https://theamericanscholar.org/the-disadvantages-of-an-elite-education/)<!-- HN:48038031:end -->
#### **Thursday, May 7, 2026**
<!-- HN:48042842:start -->
* [48042842](https://news.social-protocols.org/stats?id=48042842) #17 61 points 39 comments -> [David Sacks crashed and burned in the White House](https://www.theverge.com/column/925487/david-sacks-trump-administration-ai-model-review)<!-- HN:48042842:end --><!-- HN:48043378:start -->
* [48043378](https://news.social-protocols.org/stats?id=48043378) #22 40 points 14 comments -> [Kash Patel's Personalized Bourbon Stash](https://www.theatlantic.com/politics/2026/05/kash-patel-fbi-bourbon/687066/)<!-- HN:48043378:end --><!-- HN:48043866:start -->
* [48043866](https://news.social-protocols.org/stats?id=48043866) #22 14 points 2 comments -> [They Don't Look Like Me](https://niccolorastrelli.com/they-dont-look-like-me)<!-- HN:48043866:end --><!-- HN:48044022:start -->
* [48044022](https://news.social-protocols.org/stats?id=48044022) #10 37 points 10 comments -> [How I made $350K from an open-source JavaScript library using dual licensing](https://www.paritydeals.com/blog/monetize-open-source-dual-licensing/)<!-- HN:48044022:end --><!-- HN:48046874:start -->
* [48046874](https://news.social-protocols.org/stats?id=48046874) #19 24 points 19 comments -> [Show HN: Social Network for Corporate Cringe](https://CringeOut.com)<!-- HN:48046874:end --><!-- HN:48038750:start -->
* [48038750](https://news.social-protocols.org/stats?id=48038750) #30 77 points 1 comments -> [SoundOff: Low-Cost Passive Ultrasound Tags](https://yibo-fu.com/SoundOff-Low-cost-Passive-Ultrasound-Tags-for-Non-invasive-and-Non)<!-- HN:48038750:end --><!-- HN:48048121:start -->
* [48048121](https://news.social-protocols.org/stats?id=48048121) #19 18 points 8 comments -> [KLM flight attendant hospitalized after contact with hantavirus](https://nltimes.nl/2026/05/07/klm-flight-attendant-hospitalized-contact-hantavirus-cruise-ship-passenger)<!-- HN:48048121:end --><!-- HN:48051080:start -->
* [48051080](https://news.social-protocols.org/stats?id=48051080) #2 60 points 30 comments -> [Authorities say Flock cameras' data allegedly used for immigration enforcement](https://www.ohio.news/stories/dayton-authorities-say-that-flock-cameras-data-allegedly-used-for-immigration-enforcement/)<!-- HN:48051080:end --><!-- HN:48054732:start -->
* [48054732](https://news.social-protocols.org/stats?id=48054732) #8 49 points 15 comments -> [Utah senator smacks ABC reporters phone out of hand amid Data Center controversy](https://www.abc4.com/news/digital-exclusives/reporter-jj-nursery-utah-senator-jerry-stevenson-box-elder-county-data-center/)<!-- HN:48054732:end --><!-- HN:48054953:start -->
* [48054953](https://news.social-protocols.org/stats?id=48054953) #12 7 points 1 comments -> [Why The Pentagon Is Quadrupling Missile Production, and Why It Won't Be Enough](https://militarymachine.com/pentagon-missile-production-surge-2026)<!-- HN:48054953:end -->
#### **Friday, May 8, 2026**<!-- HN:48056003:start -->
* [48056003](https://news.social-protocols.org/stats?id=48056003) #23 33 points 56 comments -> [OpenClaw Had a Rough Week](https://openclaw.ai/blog/openclaw-rough-week)<!-- HN:48056003:end --><!-- HN:48058217:start -->
* [48058217](https://news.social-protocols.org/stats?id=48058217) #19 17 points 2 comments -> [New York state set to ban law enforcement, including ICE, from wearing masks](https://www.reuters.com/legal/government/new-york-state-set-ban-law-enforcement-including-ice-wearing-masks-2026-05-07/)<!-- HN:48058217:end --><!-- HN:48062530:start -->
* [48062530](https://news.social-protocols.org/stats?id=48062530) #18 37 points 41 comments -> [UFO Release 1: Presidential Unsealing and Reporting System for UAP Encounters](https://www.war.gov/UFO/#release)<!-- HN:48062530:end --><!-- HN:48065332:start -->
* [48065332](https://news.social-protocols.org/stats?id=48065332) #15 10 points 0 comments -> [Banks are funding climate chaos. You don't have to](https://www.not-ship.com/banks-are-funding-climate-chaos-you-dont-have-to-2/)<!-- HN:48065332:end --><!-- HN:48069009:start -->
* [48069009](https://news.social-protocols.org/stats?id=48069009) #27 5 points 1 comments -> [If Anyone Builds It, Everyone Dies](https://ifanyonebuildsit.com/)<!-- HN:48069009:end --><!-- HN:48068475:start -->
* [48068475](https://news.social-protocols.org/stats?id=48068475) #14 17 points 1 comments -> [Dirty Frag: Universal Linux LPE](https://github.com/V4bel/dirtyfrag)<!-- HN:48068475:end -->