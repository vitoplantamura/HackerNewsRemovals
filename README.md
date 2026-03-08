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

#### **Monday, March 2, 2026**
<!-- HN:47211112:start -->
* [47211112](https://news.social-protocols.org/stats?id=47211112) #22 49 points 31 comments -> [Big Breakfast Alters Appetite, Gut Health](https://www.cambridge.org/core/journals/british-journal-of-nutrition/article/big-breakfast-diet-composition-impacts-on-appetite-control-and-gut-health-a-randomized-weight-loss-trial-in-adults-with-overweight-or-obesity/69D4E150EAE7D9632D33904D7A4AE5FA)<!-- HN:47211112:end --><!-- HN:47142183:start -->
* [47142183](https://news.social-protocols.org/stats?id=47142183) #2 453 points 237 comments -> [How to talk to anyone, and why you should](https://www.theguardian.com/lifeandstyle/2026/feb/24/stranger-secret-how-to-talk-to-anyone-why-you-should)<!-- HN:47142183:end --><!-- HN:47213081:start -->
* [47213081](https://news.social-protocols.org/stats?id=47213081) #29 8 points 1 comments -> [We will sacrifice quality for convenience](https://twitter.com/backnotprop/status/2028293637373841759)<!-- HN:47213081:end --><!-- HN:47213124:start -->
* [47213124](https://news.social-protocols.org/stats?id=47213124) #2 92 points 1 comments -> [Claude hits #1 on the App Store as users rally behind Anthropic](https://9to5mac.com/2026/03/01/claude-hits-1-on-the-app-store-as-users-rally-behind-anthropics-government-standoff/)<!-- HN:47213124:end --><!-- HN:47172481:start -->
* [47172481](https://news.social-protocols.org/stats?id=47172481) #25 38 points 40 comments -> [What Your DNA Reveals about the Sex Life of Neanderthals](https://www.nytimes.com/2026/02/26/science/human-evolution-neanderthal-sex.html)<!-- HN:47172481:end --><!-- HN:47216589:start -->
* [47216589](https://news.social-protocols.org/stats?id=47216589) #24 -> [Robert F Kennedy Jr: 1 year of failure](https://www.thelancet.com/action/showPdf?pii=S0140-6736%2826%2900414-9)<!-- HN:47216589:end --><!-- HN:47216765:start -->
* [47216765](https://news.social-protocols.org/stats?id=47216765) #8 69 points 26 comments -> [Claude Code LSP](https://karanbansal.in/blog/claude-code-lsp/)<!-- HN:47216765:end --><!-- HN:47220057:start -->
* [47220057](https://news.social-protocols.org/stats?id=47220057) #27 6 points 1 comments -> [Show HN: I turned Claude Code into a personal assistant](https://github.com/daxaur/openpaw)<!-- HN:47220057:end -->
#### **Tuesday, March 3, 2026**
<!-- HN:47225826:start -->
* [47225826](https://news.social-protocols.org/stats?id=47225826) #16 8 points 3 comments -> [Astro and Svelte: Why I believe they're the future of web development](https://xergioalex.com/blog/astro-and-svelte-the-future-of-web-development/)<!-- HN:47225826:end --><!-- HN:47227329:start -->
* [47227329](https://news.social-protocols.org/stats?id=47227329) #20 42 points 19 comments -> [224k Publicly Exposed OpenClaw Instances](https://openclaw.allegro.earth/)<!-- HN:47227329:end --><!-- HN:47185594:start -->
* [47185594](https://news.social-protocols.org/stats?id=47185594) #19 3 points 0 comments -> [It's Time for LLM Connection Strings](https://danlevy.net/llm-connection-strings/)<!-- HN:47185594:end --><!-- HN:47230861:start -->
* [47230861](https://news.social-protocols.org/stats?id=47230861) #5 7 points 4 comments -> [The term 'Blood Moon' wasn't invented until 2013 (2014)](https://www.kelleycom.com/blood-moon/)<!-- HN:47230861:end --><!-- HN:47231469:start -->
* [47231469](https://news.social-protocols.org/stats?id=47231469) #25 78 points 43 comments -> [Stolen Gemini API key racks up $82,000 in 48 hours](https://llmhorrors.com/all/gemini-stolen-api-key-82k/)<!-- HN:47231469:end --><!-- HN:47234093:start -->
* [47234093](https://news.social-protocols.org/stats?id=47234093) #15 21 points 14 comments -> [I Used Claude to File My Taxes for Free](https://kachess.dev/taxes/ai/personal-finance/2026/02/27/breaking-up-with-turbotax.html)<!-- HN:47234093:end --><!-- HN:47235943:start -->
* [47235943](https://news.social-protocols.org/stats?id=47235943) #30 7 points 3 comments -> [US Stock Market has lost $1 TRILLION in value since open Tuesday](https://old.reddit.com/r/StockMarket/comments/1rjtww8)<!-- HN:47235943:end --><!-- HN:47236563:start -->
* [47236563](https://news.social-protocols.org/stats?id=47236563) #25 8 points 2 comments -> [El Paso ICE Camp East Montana under quarantine after measles outbreak](https://www.elpasotimes.com/story/news/immigration/2026/03/03/el-paso-ice-camp-east-montana-quarantine-after-measles-outbreak/88962085007/)<!-- HN:47236563:end --><!-- HN:47236893:start -->
* [47236893](https://news.social-protocols.org/stats?id=47236893) #26 13 points 3 comments -> [I Built a Spy Satellite Simulator in a Browser. Here's What I Learned](https://www.spatialintelligence.ai/p/i-built-a-spy-satellite-simulator)<!-- HN:47236893:end --><!-- HN:47237861:start -->
* [47237861](https://news.social-protocols.org/stats?id=47237861) #16 48 points 15 comments -> [I Audited the Privacy of Popular Free Dev Tools, the Results Are Terrifying](https://www.toolbox-kit.com/blog/i-audited-popular-dev-tools-privacy-results-are-scary)<!-- HN:47237861:end --><!-- HN:47236858:start -->
* [47236858](https://news.social-protocols.org/stats?id=47236858) #8 62 points 24 comments -> [Fire the CEO, Introducing the AxO's](https://boringops.sh/articles/fire_the_ceo/)<!-- HN:47236858:end --><!-- HN:47240158:start -->
* [47240158](https://news.social-protocols.org/stats?id=47240158) #10 22 points 12 comments -> [Zed will require age identification for its services](https://zed.dev/terms#21-eligibility)<!-- HN:47240158:end --><!-- HN:47238255:start -->
* [47238255](https://news.social-protocols.org/stats?id=47238255) #30 13 points 2 comments -> [Show HN: Online OCR Free – Batch OCR UI for Tesseract, Gemini and OpenRouter](https://onlineocrfree.qzz.io)<!-- HN:47238255:end -->
#### **Wednesday, March 4, 2026**
<!-- HN:47242271:start -->
* [47242271](https://news.social-protocols.org/stats?id=47242271) #5 6 points 0 comments -> [OpenClaw Partners with VirusTotal for Skill Security](https://openclaw.ai/blog/virustotal-partnership)<!-- HN:47242271:end --><!-- HN:47242567:start -->
* [47242567](https://news.social-protocols.org/stats?id=47242567) #3 27 points 14 comments -> [Just Send the Prompt](https://justsendtheprompt.com/)<!-- HN:47242567:end --><!-- HN:47242496:start -->
* [47242496](https://news.social-protocols.org/stats?id=47242496) #30 16 points 4 comments -> [CIA working to arm Kurdish forces to spark uprising in Iran, sources say](https://www.cnn.com/2026/03/03/politics/cia-arming-kurds-iran)<!-- HN:47242496:end --><!-- HN:47242765:start -->
* [47242765](https://news.social-protocols.org/stats?id=47242765) #2 -> [Nobody Gets Promoted for Simplicity](https://terriblesoftware.org/2026/03/03/nobody-gets-promoted-for-simplicity/)<!-- HN:47242765:end --><!-- HN:47246530:start -->
* [47246530](https://news.social-protocols.org/stats?id=47246530) #20 -> [US Supreme Court's Republicans seized most dangerous power in constitutional law](https://www.vox.com/politics/481401/supreme-court-mirabelli-bonta-sauron-wins)<!-- HN:47246530:end --><!-- HN:47250778:start -->
* [47250778](https://news.social-protocols.org/stats?id=47250778) #2 45 points 7 comments -> [You Bought Zuck's Ray-Bans. Now Someone in Nairobi Is Watching You Poop](https://blog.adafruit.com/2026/03/04/you-bought-zucks-ray-bans-now-someone-in-nairobi-is-watching-you-poop/)<!-- HN:47250778:end --><!-- HN:47252062:start -->
* [47252062](https://news.social-protocols.org/stats?id=47252062) #20 9 points 6 comments -> [AfricaMuseum refuses to yield Congo geological archives despite US pressure](https://www.vrt.be/vrtnws/en/2026/02/12/africamuseum-refuses-to-hand-over-geological-archive-on-congo-to/)<!-- HN:47252062:end --><!-- HN:47250985:start -->
* [47250985](https://news.social-protocols.org/stats?id=47250985) #10 58 points 15 comments -> [Who Writes the Bugs? A Deeper Look at 125,000 Kernel Vulnerabilities](https://pebblebed.com/blog/kernel-bugs-part2)<!-- HN:47250985:end --><!-- HN:47246110:start -->
* [47246110](https://news.social-protocols.org/stats?id=47246110) #3 816 points 455 comments -> [Nobody Gets Promoted for Simplicity](https://terriblesoftware.org/2026/03/03/nobody-gets-promoted-for-simplicity/)<!-- HN:47246110:end --><!-- HN:47255296:start -->
* [47255296](https://news.social-protocols.org/stats?id=47255296) #15 9 points 1 comments -> [Show HN: I built a tool that checks if your ISP is spying on you](https://ismyispspying.com)<!-- HN:47255296:end --><!-- HN:47254624:start -->
* [47254624](https://news.social-protocols.org/stats?id=47254624) #16 12 points 9 comments -> [Accessibility Issues Are Often Usability Issues](https://protovate.com/blog/you-dont-need-accessibility-until-you-do/)<!-- HN:47254624:end -->
#### **Thursday, March 5, 2026**<!-- HN:47256790:start -->
* [47256790](https://news.social-protocols.org/stats?id=47256790) #4 -> [I left work early to get a hug from my wife](https://rxa.me/why/)<!-- HN:47256790:end --><!-- HN:47256105:start -->
* [47256105](https://news.social-protocols.org/stats?id=47256105) #10 30 points 40 comments -> [What's Driving Rising Business Costs?](https://libertystreeteconomics.newyorkfed.org/2026/03/whats-driving-rising-business-costs/)<!-- HN:47256105:end --><!-- HN:47261418:start -->
* [47261418](https://news.social-protocols.org/stats?id=47261418) #23 15 points 6 comments -> [Unix Isn't for Agents](https://pwhite.org/unix-is-not-for-agents)<!-- HN:47261418:end --><!-- HN:47263825:start -->
* [47263825](https://news.social-protocols.org/stats?id=47263825) #11 29 points 13 comments -> [GitHub Actions is shitting the bed again](https://www.githubstatus.com/incidents/g5gnt5l5hf56)<!-- HN:47263825:end --><!-- HN:47263069:start -->
* [47263069](https://news.social-protocols.org/stats?id=47263069) #21 43 points 19 comments -> [Apple: Enough Is Enough](https://bastibe.de/2026-03-05-apple-woes.html)<!-- HN:47263069:end --><!-- HN:47265005:start -->
* [47265005](https://news.social-protocols.org/stats?id=47265005) #25 151 points 57 comments -> [GPT-5.4](https://openai.com/index/introducing-gpt-5-4/)<!-- HN:47265005:end --><!-- HN:47265089:start -->
* [47265089](https://news.social-protocols.org/stats?id=47265089) #21 90 points 2 comments -> [GPT-5.4 Thinking and GPT-5.4 Pro](https://twitter.com/i/status/2029620619743219811)<!-- HN:47265089:end --><!-- HN:47265150:start -->
* [47265150](https://news.social-protocols.org/stats?id=47265150) #25 61 points 11 comments -> [GPT 5.4 Thinking and Pro](https://twitter.com/OpenAI/status/2029620619743219811)<!-- HN:47265150:end --><!-- HN:47264341:start -->
* [47264341](https://news.social-protocols.org/stats?id=47264341) #21 271 points 110 comments -> [The Government Uses Targeted Advertising to Track Your Location](https://www.eff.org/deeplinks/2026/03/targeted-advertising-gives-your-location-government-just-ask-cbp)<!-- HN:47264341:end --><!-- HN:47266944:start -->
* [47266944](https://news.social-protocols.org/stats?id=47266944) #30 12 points 1 comments -> [As AI Turns Prevalent, UI Becomes Irrelevant](https://www.star-history.com/blog/ai-ui-irrelevant)<!-- HN:47266944:end -->
#### **Friday, March 6, 2026**
<!-- HN:47202360:start -->
* [47202360](https://news.social-protocols.org/stats?id=47202360) #11 -> [The Mystery of Skype](https://clevcode.org/the-mystery-of-skype/)<!-- HN:47202360:end --><!-- HN:47273964:start -->
* [47273964](https://news.social-protocols.org/stats?id=47273964) #15 36 points 41 comments -> [First MacBook Neo Benchmarks Are In](https://www.macrumors.com/2026/03/05/macbook-neo-first-benchmarks/)<!-- HN:47273964:end --><!-- HN:47276399:start -->
* [47276399](https://news.social-protocols.org/stats?id=47276399) #22 11 points 1 comments -> [United Airlines says it will boot passengers who refuse to use headphones](https://www.nbcnews.com/business/business-news/united-boot-passengers-dont-use-headphones-rcna261908)<!-- HN:47276399:end --><!-- HN:47277134:start -->
* [47277134](https://news.social-protocols.org/stats?id=47277134) #7 -> [Cursor Is Dead – How a $29B company became obsolete in under three years](https://www.permissionprotocol.com/blog/cursor-is-dead.html)<!-- HN:47277134:end --><!-- HN:47196525:start -->
* [47196525](https://news.social-protocols.org/stats?id=47196525) #11 27 points 1 comments -> ["Our programs are fun to use" – Beagle Bros](https://unsung.aresluna.org/our-programs-are-fun-to-use/)<!-- HN:47196525:end --><!-- HN:47282060:start -->
* [47282060](https://news.social-protocols.org/stats?id=47282060) #2 10 points 2 comments -> [Wild Crows in Sweden Help Clean Up Cigarette Butts](https://www.samodobrevijesti.com/en/news/wild-crows-in-sweden-help-clean-up-cigarette-butts/)<!-- HN:47282060:end -->
#### **Saturday, March 7, 2026**
<!-- HN:47214708:start -->
* [47214708](https://news.social-protocols.org/stats?id=47214708) #5 53 points 17 comments -> [Math Notepad](https://mathnotepad.com)<!-- HN:47214708:end --><!-- HN:47219462:start -->
* [47219462](https://news.social-protocols.org/stats?id=47219462) #9 210 points 101 comments -> [Open Camera is a FOSS Camera App for Android](https://opencamera.org.uk/)<!-- HN:47219462:end --><!-- HN:47206990:start -->
* [47206990](https://news.social-protocols.org/stats?id=47206990) #10 83 points 6 comments -> [Apache Otava](https://otava.apache.org/)<!-- HN:47206990:end --><!-- HN:47220411:start -->
* [47220411](https://news.social-protocols.org/stats?id=47220411) #15 307 points 67 comments -> [Payphone Go](https://walzr.com/payphone-go/)<!-- HN:47220411:end --><!-- HN:47215112:start -->
* [47215112](https://news.social-protocols.org/stats?id=47215112) #17 51 points 9 comments -> [Triplet Superconductor](https://www.sciencedaily.com/releases/2026/02/260221000252.htm)<!-- HN:47215112:end --><!-- HN:47284114:start -->
* [47284114](https://news.social-protocols.org/stats?id=47284114) #13 42 points 9 comments -> [AI and the Illegal War](https://buttondown.com/creativegood/archive/ai-and-the-illegal-war/)<!-- HN:47284114:end --><!-- HN:47284834:start -->
* [47284834](https://news.social-protocols.org/stats?id=47284834) #7 39 points 16 comments -> [AI Error May Have Contributed to Girl's School Bombing in Iran](https://thisweekinworcester.com/exclusive-ai-error-girls-school-bombing/)<!-- HN:47284834:end --><!-- HN:47285375:start -->
* [47285375](https://news.social-protocols.org/stats?id=47285375) #2 25 points 11 comments -> [German police probe student poster slur (Lick my balls Merz) against Merz](https://dpa-international.com/politics/urn:newsml:dpa.com:20090101:260306-99-743434/)<!-- HN:47285375:end --><!-- HN:47284916:start -->
* [47284916](https://news.social-protocols.org/stats?id=47284916) #23 34 points 40 comments -> [Why New Zealand is seeing an exodus of over-30s](https://www.cnn.com/2026/03/06/world/new-zealand-australia-emigration-midlife-intl-hnk-dst)<!-- HN:47284916:end --><!-- HN:47285433:start -->
* [47285433](https://news.social-protocols.org/stats?id=47285433) #27 9 points 1 comments -> [Your AI Slop Bores Me](https://www.youraislopbores.me/)<!-- HN:47285433:end --><!-- HN:47286236:start -->
* [47286236](https://news.social-protocols.org/stats?id=47286236) #13 15 points 17 comments -> [Claude AI Helped Bomb Iran. But How Exactly?](https://www.bloomberg.com/opinion/articles/2026-03-04/iran-strikes-anthropic-claude-ai-helped-us-attack-but-how-exactly)<!-- HN:47286236:end --><!-- HN:47286300:start -->
* [47286300](https://news.social-protocols.org/stats?id=47286300) #2 28 points 41 comments -> [Show HN: Tanstaafl – Pay-to-inbox email on Bitcoin Lightning](https://tanstaafl.email)<!-- HN:47286300:end --><!-- HN:47288046:start -->
* [47288046](https://news.social-protocols.org/stats?id=47288046) #12 50 points 41 comments -> [LLM Doesn't Write Correct Code. It Writes Plausible Code](https://twitter.com/KatanaLarp/status/2029928471632224486)<!-- HN:47288046:end --><!-- HN:47289123:start -->
* [47289123](https://news.social-protocols.org/stats?id=47289123) #6 56 points 22 comments -> [Tech jobs are getting demolished in ways not seen since 2008](https://www.businessinsider.com/tech-jobs-getting-demolished-great-recession-dot-com-era-2026-3)<!-- HN:47289123:end --><!-- HN:47289914:start -->
* [47289914](https://news.social-protocols.org/stats?id=47289914) #9 8 points 0 comments -> [Track AIPAC – Follow Israel lobby spending in U.S. politics](https://www.trackaipac.com)<!-- HN:47289914:end --><!-- HN:47289933:start -->
* [47289933](https://news.social-protocols.org/stats?id=47289933) #7 20 points 1 comments -> [Footage shows US citizen shot dead by ICE agent in Texas traffic stop](https://www.bbc.com/news/articles/cedzep6gp07o)<!-- HN:47289933:end --><!-- HN:47289869:start -->
* [47289869](https://news.social-protocols.org/stats?id=47289869) #16 4 points 2 comments -> [T3 Code is the best way to code with AI](https://t3.codes/)<!-- HN:47289869:end --><!-- HN:47289646:start -->
* [47289646](https://news.social-protocols.org/stats?id=47289646) #6 -> [Show HN: Prompt Armour – Real-time PII detection for AI chatbots, 100% local](https://prompt-armour.vercel.app/)<!-- HN:47289646:end --><!-- HN:47290631:start -->
* [47290631](https://news.social-protocols.org/stats?id=47290631) #8 5 points 0 comments -> [The Prompt I Cannot Read – Written by an LLM, about Being an LLM](https://the-prompt-i-cannot-read-ee16d7.gitlab.io/)<!-- HN:47290631:end --><!-- HN:47291202:start -->
* [47291202](https://news.social-protocols.org/stats?id=47291202) #15 -> [Sam Altman's greed and dishonesty are finally catching up to him](https://garymarcus.substack.com/p/breaking-sam-altmans-greed-and-dishonesty)<!-- HN:47291202:end -->
#### **Sunday, March 8, 2026**
<!-- HN:47292849:start -->
* [47292849](https://news.social-protocols.org/stats?id=47292849) #29 11 points 1 comments -> [Patel gutted FBI counterintelligence team tasked with tracking Iranian threats](https://www.cnn.com/2026/03/03/politics/patel-fbi-national-security-division-firings-iran)<!-- HN:47292849:end --><!-- HN:47292841:start -->
* [47292841](https://news.social-protocols.org/stats?id=47292841) #17 24 points 31 comments -> [Ghostmd: Ghostty but for Markdown Notes](https://mimoo.github.io/ghostmd/)<!-- HN:47292841:end --><!-- HN:47293514:start -->
* [47293514](https://news.social-protocols.org/stats?id=47293514) #20 36 points 21 comments -> [Iranian Women Graduate in Stem 3× the Rate of U.S. Women and Has 5× More PhDs](https://hrnews1.substack.com/p/iranian-women-graduate-in-stem-at)<!-- HN:47293514:end --><!-- HN:47294008:start -->
* [47294008](https://news.social-protocols.org/stats?id=47294008) #22 32 points 29 comments -> [Israel Strikes Oil Facilities in Iran](https://www.nytimes.com/2026/03/07/world/middleeast/israel-iran-oil-strikes.html)<!-- HN:47294008:end --><!-- HN:47294082:start -->
* [47294082](https://news.social-protocols.org/stats?id=47294082) #19 8 points 2 comments -> [Americans Are Now a Target for ICE](https://www.wsj.com/us-news/immigration-protests-noem-minneapolis-0b8bd496)<!-- HN:47294082:end --><!-- HN:47296787:start -->
* [47296787](https://news.social-protocols.org/stats?id=47296787) #10 16 points 17 comments -> [You Don't Need a Vector Database](https://vecstore.app/blog/you-dont-need-a-vector-database)<!-- HN:47296787:end --><!-- HN:47261529:start -->
* [47261529](https://news.social-protocols.org/stats?id=47261529) #18 5 points 1 comments -> [We Turned Our Wireshark Wizard into a Markdown File](https://www.checklyhq.com/blog/building-an-ai-agent/)<!-- HN:47261529:end --><!-- HN:47300560:start -->
* [47300560](https://news.social-protocols.org/stats?id=47300560) #10 7 points 1 comments -> [Show HN: WhatsApp Clone – No Setup or Signup](https://positive-intentions.com/)<!-- HN:47300560:end --><!-- HN:47299022:start -->
* [47299022](https://news.social-protocols.org/stats?id=47299022) #28 52 points 40 comments -> [Show HN: Skir – like Protocol Buffer but better](https://skir.build/)<!-- HN:47299022:end -->