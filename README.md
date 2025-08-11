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

#### **Tuesday, August 5, 2025**
<!-- HN:44766893:start -->
* [44766893](https://news.social-protocols.org/stats?id=44766893) #6 27 points 41 comments -> [What'll happen if we spend nearly $3T on data centres no one needs?](https://www.ft.com/content/7052c560-4f31-4f45-bed0-cbc84453b3ce)<!-- HN:44766893:end --><!-- HN:44794135:start -->
* [44794135](https://news.social-protocols.org/stats?id=44794135) #5 3 points 1 comments -> [Oxmiq Labs Inc.: Re-Architecting the GPU Stack: From Atoms to Agents](https://oxmiq.ai/press)<!-- HN:44794135:end --><!-- HN:44797264:start -->
* [44797264](https://news.social-protocols.org/stats?id=44797264) #9 10 points 6 comments -> [GitHub CEO Warns Developers: "Either Embrace AI or Get Out of This Career"](https://www.finalroundai.com/blog/github-ceo-thomas-dohmke-warns-developers-embrace-ai-or-quit)<!-- HN:44797264:end --><!-- HN:44798601:start -->
* [44798601](https://news.social-protocols.org/stats?id=44798601) #30 11 points 1 comments -> [Doge wasted $21.7B in taxpayer funds, according to Senate report](https://www.msnbc.com/top-stories/latest/doge-federal-employees-reductions-in-force-rif-rcna222536)<!-- HN:44798601:end --><!-- HN:44799435:start -->
* [44799435](https://news.social-protocols.org/stats?id=44799435) #25 200 points 3 comments -> [GitHub Pull Requests Are Down](https://github.com/github/site-policy/pull/582)<!-- HN:44799435:end --><!-- HN:44802790:start -->
* [44802790](https://news.social-protocols.org/stats?id=44802790) #8 13 points 2 comments -> [You Should Probably Leave Substack](https://leavesubstack.com/)<!-- HN:44802790:end --><!-- HN:44803065:start -->
* [44803065](https://news.social-protocols.org/stats?id=44803065) #19 11 points 6 comments -> [A Zoo in Denmark Wants to Feed Your Pets to Its Predators](https://www.nytimes.com/2025/08/04/science/zoos-denmark-food-pets.html)<!-- HN:44803065:end --><!-- HN:44804269:start -->
* [44804269](https://news.social-protocols.org/stats?id=44804269) #17 5 points 2 comments -> [Trouble with Elections: Everything We Thought We Knew About Democracy Is Wrong](https://democracycreative.substack.com/p/the-trouble-with-elections)<!-- HN:44804269:end -->
#### **Wednesday, August 6, 2025**
<!-- HN:44807088:start -->
* [44807088](https://news.social-protocols.org/stats?id=44807088) #7 5 points 0 comments -> [Resistance to Politically-Ordered Gerrymandering in Texas](https://riggedredistricting.com)<!-- HN:44807088:end --><!-- HN:44806764:start -->
* [44806764](https://news.social-protocols.org/stats?id=44806764) #19 8 points 1 comments -> [If you're a direct employee of HP/Compaq you're not allowed to look at this code](https://www.ukcert.org.uk/repository/exploits/NETSYS_COM%20-%20The%20Intelligent%20Hacker%27s%20Choice%20-%20http--www_netsys_com-library-alerts-2002-08-05-dxchpwd.txt)<!-- HN:44806764:end --><!-- HN:44806543:start -->
* [44806543](https://news.social-protocols.org/stats?id=44806543) #10 176 points 76 comments -> [Kitten TTS: 25MB CPU-Only, Open-Source Voice Model](https://algogist.com/kitten-tts-the-25mb-ai-voice-model-thats-about-to-change-everything-runs-on-a-potato/)<!-- HN:44806543:end --><!-- HN:44807115:start -->
* [44807115](https://news.social-protocols.org/stats?id=44807115) #7 27 points 12 comments -> [I built a tool to help people remove their info from the Tea App](https://www.suetea.com/)<!-- HN:44807115:end --><!-- HN:44807748:start -->
* [44807748](https://news.social-protocols.org/stats?id=44807748) #24 4 points 1 comments -> ['We didn't vote for ChatGPT': Swedish PM under fire for using AI in role](https://www.theguardian.com/technology/2025/aug/05/chat-gpt-swedish-pm-ulf-kristersson-under-fire-for-using-ai-in-role)<!-- HN:44807748:end --><!-- HN:44806862:start -->
* [44806862](https://news.social-protocols.org/stats?id=44806862) #11 22 points 40 comments -> [Drivers who appeal school speed zone camera fines almost guaranteed to lose](https://www.abcactionnews.com/news/state/theres-no-point-in-fighting-drivers-who-appeal-school-speed-zone-camera-fines-almost-guaranteed-to-lose)<!-- HN:44806862:end --><!-- HN:44807431:start -->
* [44807431](https://news.social-protocols.org/stats?id=44807431) #13 5 points 3 comments -> [An AI Company Just Fired Someone for Endorsing Human Extinction](https://www.realtimetechpocalypse.com/p/did-an-ai-company-just-fire-someone)<!-- HN:44807431:end --><!-- HN:44811406:start -->
* [44811406](https://news.social-protocols.org/stats?id=44811406) #13 29 points 40 comments -> [Electric bikes might just be the healthiest thing to ever happen to teenagers](https://electrek.co/2025/08/05/electric-bikes-might-just-be-the-healthiest-thing-to-ever-happen-to-teenagers/)<!-- HN:44811406:end --><!-- HN:44811733:start -->
* [44811733](https://news.social-protocols.org/stats?id=44811733) #6 144 points 51 comments -> [Constitution of the United States Website has removed sections (web.archive.org)](https://old.reddit.com/r/law/comments/1mj3ttx/constitution_of_the_united_states_website_has/)<!-- HN:44811733:end --><!-- HN:44812521:start -->
* [44812521](https://news.social-protocols.org/stats?id=44812521) #30 7 points 1 comments -> [Meta violated privacy laws by collecting menstrual health data](https://techcrunch.com/2025/08/05/jury-rules-meta-violated-california-privacy-laws-by-collecting-menstrual-health-data-from-flo/)<!-- HN:44812521:end --><!-- HN:44816889:start -->
* [44816889](https://news.social-protocols.org/stats?id=44816889) #18 3 points 0 comments -> [Show HN: AsyncStatus CLI – post status updates from your terminal (open-source)](https://github.com/AsyncStatus/asyncstatus/tree/main/apps/cli)<!-- HN:44816889:end --><!-- HN:44818748:start -->
* [44818748](https://news.social-protocols.org/stats?id=44818748) #11 7 points 2 comments -> [I'm tired of stupid people treating me like I'm an idiot](https://whatwelost.substack.com/p/im-tired-of-stupid-people-treating)<!-- HN:44818748:end -->
#### **Thursday, August 7, 2025**
<!-- HN:44776058:start -->
* [44776058](https://news.social-protocols.org/stats?id=44776058) #20 7 points 0 comments -> [That Squiggly, Treacherous Line](https://fi-le.net/squiggly/)<!-- HN:44776058:end --><!-- HN:44819709:start -->
* [44819709](https://news.social-protocols.org/stats?id=44819709) #15 4 points 1 comments -> [Do you understand racial discrimination?](https://www.racialterms.com/)<!-- HN:44819709:end --><!-- HN:44819425:start -->
* [44819425](https://news.social-protocols.org/stats?id=44819425) #26 3 points 1 comments -> [I'm tired of stupid people treating me like I'm an idiot](https://whatwelost.substack.com/p/im-tired-of-stupid-people-treating)<!-- HN:44819425:end --><!-- HN:44821204:start -->
* [44821204](https://news.social-protocols.org/stats?id=44821204) #2 8 points 0 comments -> [Tech for Palestine](https://techforpalestine.org/)<!-- HN:44821204:end --><!-- HN:44821551:start -->
* [44821551](https://news.social-protocols.org/stats?id=44821551) #23 14 points 9 comments -> [Israel is reportedly storing Palestinian phone calls on Microsoft servers](https://www.engadget.com/big-tech/israel-is-reportedly-storing-millions-of-palestinian-phone-calls-on-microsoft-servers-161127912.html)<!-- HN:44821551:end --><!-- HN:44821351:start -->
* [44821351](https://news.social-protocols.org/stats?id=44821351) #2 23 points 31 comments -> ["I met a founder who writes 10k lines of code a day thanks to AI"](https://twitter.com/paulg/status/1953289830982664236)<!-- HN:44821351:end --><!-- HN:44823260:start -->
* [44823260](https://news.social-protocols.org/stats?id=44823260) #6 30 points 5 comments -> ["AI hype" is the true AI product](https://hardresetmedia.substack.com/p/machine-learning-expert-ai-hype-is)<!-- HN:44823260:end --><!-- HN:44824583:start -->
* [44824583](https://news.social-protocols.org/stats?id=44824583) #8 37 points 20 comments -> [No One Is Working](https://www.humaninvariant.com/blog/working)<!-- HN:44824583:end --><!-- HN:44826095:start -->
* [44826095](https://news.social-protocols.org/stats?id=44826095) #24 23 points 7 comments -> [Google confirms it has been hacked](https://www.forbes.com/sites/daveywinder/2025/08/07/google-confirms-it-has-been-hacked---user-data-stolen/)<!-- HN:44826095:end --><!-- HN:44826463:start -->
* [44826463](https://news.social-protocols.org/stats?id=44826463) #10 165 points 103 comments -> [Live: GPT-5](https://www.youtube.com/watch?v=0Uu_VJeVVfo)<!-- HN:44826463:end --><!-- HN:44829144:start -->
* [44829144](https://news.social-protocols.org/stats?id=44829144) #15 53 points 16 comments -> [GPT-5 Demo Mistake About Bernoulli Effect](https://bren.blog/gpt-5-demo-mistake-about-bernoulli-effect)<!-- HN:44829144:end -->
#### **Friday, August 8, 2025**
<!-- HN:44784495:start -->
* [44784495](https://news.social-protocols.org/stats?id=44784495) #9 9 points 2 comments -> [Lessons from writing a Kubernetes Security book](https://medium.com/@raul.lapaz/learning-kubernetes-security-2cb906ad8037)<!-- HN:44784495:end --><!-- HN:44834442:start -->
* [44834442](https://news.social-protocols.org/stats?id=44834442) #4 6 points 1 comments -> [GPT-5 thinks that Windsurf's original name was OpenAI](https://chatgpt.com/share/6895a143-b770-8002-8826-823e45f04c79)<!-- HN:44834442:end --><!-- HN:44835806:start -->
* [44835806](https://news.social-protocols.org/stats?id=44835806) #5 29 points 42 comments -> [Amtrak NextGen Acela Debuts on August 28](https://media.amtrak.com/2025/08/amtrak-nextgen-acela-debuts-on-august-28/)<!-- HN:44835806:end --><!-- HN:44837015:start -->
* [44837015](https://news.social-protocols.org/stats?id=44837015) #22 33 points 3 comments -> [Supreme Court Prepares to End Voting Rights as We Know Them](https://www.motherjones.com/politics/2025/08/voting-rights-act-supreme-court-2/)<!-- HN:44837015:end --><!-- HN:44838263:start -->
* [44838263](https://news.social-protocols.org/stats?id=44838263) #20 -> [Grok's 'spicy' video setting instantly made me Taylor Swift nude deepfakes](https://www.theverge.com/report/718975/xai-grok-imagine-taylor-swifty-deepfake-nudes)<!-- HN:44838263:end --><!-- HN:44838431:start -->
* [44838431](https://news.social-protocols.org/stats?id=44838431) #3 55 points 19 comments -> [AWS's sudden removal of a 10-year account and all of its data: lessons learned](https://www.suramya.com/blog/2025/08/lessons-learnt-from-aws-deleting-a-10-year-account-and-all-that-data-without-warning/)<!-- HN:44838431:end --><!-- HN:44839554:start -->
* [44839554](https://news.social-protocols.org/stats?id=44839554) #25 7 points 0 comments -> [Why the Far Right Hates Churchill](https://www.wsj.com/politics/why-the-far-right-hates-churchill-20fdc710)<!-- HN:44839554:end --><!-- HN:44839459:start -->
* [44839459](https://news.social-protocols.org/stats?id=44839459) #5 43 points 3 comments -> [I clustered four Framework Mainboards to test LLMs](https://www.jeffgeerling.com/blog/2025/i-clustered-four-framework-mainboards-test-huge-llms)<!-- HN:44839459:end --><!-- HN:44793981:start -->
* [44793981](https://news.social-protocols.org/stats?id=44793981) #21 4 points 0 comments -> [The Anatomy of the Most Affordable Travel T-Shirt](https://www.carryology.com/travel/the-anatomy-of-the-worlds-most-affordable-travel-t-shirt/)<!-- HN:44793981:end --><!-- HN:44840993:start -->
* [44840993](https://news.social-protocols.org/stats?id=44840993) #11 7 points 3 comments -> [GPT-5 Under Fire: Red Teaming OpenAI's Model Reveals Surprising Weaknesses](https://splx.ai/blog/gpt-5-red-teaming-results)<!-- HN:44840993:end --><!-- HN:44840982:start -->
* [44840982](https://news.social-protocols.org/stats?id=44840982) #28 38 points 40 comments -> [Disney 1985 film The Black Cauldron was an experiment that failed](https://www.bbc.com/culture/article/20250807-the-radical-film-that-became-a-disaster-for-disney)<!-- HN:44840982:end -->
#### **Saturday, August 9, 2025**
<!-- HN:44843105:start -->
* [44843105](https://news.social-protocols.org/stats?id=44843105) #5 6 points 0 comments -> [The Desperate Struggle to Squeeze Aid into a Starving Gaz](https://share.google/lwSKW8yEyTcCMaDrs)<!-- HN:44843105:end --><!-- HN:44845776:start -->
* [44845776](https://news.social-protocols.org/stats?id=44845776) #3 -> [DOGE's "Efficiency" Theater: Wasted $21.7B While Destroying Life-Saving Programs](https://www.techdirt.com/2025/08/08/doges-efficiency-theater-wasted-21-7-billion-while-destroying-life-saving-programs-based-on-conspiracy-theories/)<!-- HN:44845776:end --><!-- HN:44845966:start -->
* [44845966](https://news.social-protocols.org/stats?id=44845966) #2 8 points 2 comments -> [Show HN: Kimi K2 – Powerful Open-Source AI](https://kimik2ai.app)<!-- HN:44845966:end --><!-- HN:44845327:start -->
* [44845327](https://news.social-protocols.org/stats?id=44845327) #23 3 points 0 comments -> [Gptoss120B – OpenAI Open Source Large Language Model GPT-OSS-120B Official Site](https://gptoss120b.app/)<!-- HN:44845327:end --><!-- HN:44846360:start -->
* [44846360](https://news.social-protocols.org/stats?id=44846360) #5 -> [The conservative women who are having it all](https://www.wsj.com/lifestyle/relationships/the-conservative-women-who-are-having-it-all-84077b73)<!-- HN:44846360:end --><!-- HN:44846413:start -->
* [44846413](https://news.social-protocols.org/stats?id=44846413) #28 10 points 2 comments -> [Reuters reports that the entry-level software eng job market has collapsed](https://www.reuters.com/lifestyle/bootcamp-bust-how-ai-is-upending-software-development-industry-2025-08-09/)<!-- HN:44846413:end --><!-- HN:44846544:start -->
* [44846544](https://news.social-protocols.org/stats?id=44846544) #12 14 points 18 comments -> [Why Cargo Check Is So Slow](https://eveeifyeve.pages.dev/blogs/cargo-check-slow.mdx/)<!-- HN:44846544:end --><!-- HN:44848706:start -->
* [44848706](https://news.social-protocols.org/stats?id=44848706) #10 25 points 42 comments -> [How AI is upending the software development industry](https://www.reuters.com/lifestyle/bootcamp-bust-how-ai-is-upending-software-development-industry-2025-08-09/)<!-- HN:44848706:end -->
#### **Sunday, August 10, 2025**<!-- HN:44854623:start -->
* [44854623](https://news.social-protocols.org/stats?id=44854623) #15 6 points 2 comments -> [The 5 stages of SaaS Death](https://arnon.dk/the-5-stages-of-saas-death/)<!-- HN:44854623:end --><!-- HN:44855530:start -->
* [44855530](https://news.social-protocols.org/stats?id=44855530) #29 18 points 10 comments -> [NASA finds multi-billion-year-old 'coral' on Mars](https://www.livescience.com/space/mars/nasa-finds-multi-billion-year-old-coral-on-mars)<!-- HN:44855530:end --><!-- HN:44857135:start -->
* [44857135](https://news.social-protocols.org/stats?id=44857135) #25 6 points 3 comments -> [ICE Took Half Their Work Force. What Do They Do Now?](https://www.nytimes.com/2025/07/27/us/ice-glenn-valley-foods.html)<!-- HN:44857135:end --><!-- HN:44857252:start -->
* [44857252](https://news.social-protocols.org/stats?id=44857252) #7 7 points 0 comments -> [The Drone and AI Delusion](https://secretaryrofdefenserock.substack.com/p/the-drone-and-ai-delusion)<!-- HN:44857252:end --><!-- HN:44857205:start -->
* [44857205](https://news.social-protocols.org/stats?id=44857205) #14 30 points 41 comments -> [South Korea's military has shrunk by 20% in six years as male population drops](https://www.channelnewsasia.com/east-asia/south-koreas-military-has-shrunk-20-in-six-years-male-population-drops-5287301)<!-- HN:44857205:end --><!-- HN:44858944:start -->
* [44858944](https://news.social-protocols.org/stats?id=44858944) #26 12 points 0 comments -> [Israel Killed the last journalist sanding In North Gaza](https://twitter.com/AnasAlSharif0/status/1954670507128914219)<!-- HN:44858944:end --><!-- HN:44858915:start -->
* [44858915](https://news.social-protocols.org/stats?id=44858915) #29 -> [Prominent Al Jazeera journalist killed in Israeli airstrike on Gaza](https://www.theguardian.com/world/2025/aug/10/prominent-al-jazeera-journalist-killed-in-israeli-airstrike-on-gaza)<!-- HN:44858915:end --><!-- HN:44819346:start -->
* [44819346](https://news.social-protocols.org/stats?id=44819346) #13 4 points 3 comments -> [Microsoft's Windows XP Crocs](https://www.theverge.com/microsoft/717965/microsoft-crocs-windows-xp-bliss-wallpaper-theme)<!-- HN:44819346:end -->
#### **Monday, August 11, 2025**<!-- HN:44860589:start -->
* [44860589](https://news.social-protocols.org/stats?id=44860589) #23 8 points 0 comments -> [Five journalists killed in targeted Israeli airstrike on Gaza](https://www.theguardian.com/world/2025/aug/10/prominent-al-jazeera-journalist-killed-in-israeli-airstrike-on-gaza)<!-- HN:44860589:end --><!-- HN:44862263:start -->
* [44862263](https://news.social-protocols.org/stats?id=44862263) #2 8 points 2 comments -> [Cursor's Go-to-Market Playbook: How an AI Coding Assistant Hit $100M+ ARR](https://www.getcassius.ai/blogs/cursor-go-to-market-playbook-100m-arr-ai-coding-assistant)<!-- HN:44862263:end --><!-- HN:44827617:start -->
* [44827617](https://news.social-protocols.org/stats?id=44827617) #22 7 points 6 comments -> [Against the UUID](https://github.com/firasd/alphadec/blob/main/docs/against-the-uuid.md)<!-- HN:44827617:end --><!-- HN:44863303:start -->
* [44863303](https://news.social-protocols.org/stats?id=44863303) #6 28 points 40 comments -> [Why Is Web Performance Undervalued?](https://blaines-blog.com/post-2)<!-- HN:44863303:end --><!-- HN:44863568:start -->
* [44863568](https://news.social-protocols.org/stats?id=44863568) #19 28 points 40 comments -> [Justice Dept. Settles with Greystar to End Participation in Algorithmic Pricing](https://www.justice.gov/opa/pr/justice-department-reaches-proposed-settlement-greystar-largest-us-landlord-end-its)<!-- HN:44863568:end --><!-- HN:44864171:start -->
* [44864171](https://news.social-protocols.org/stats?id=44864171) #14 10 points 0 comments -> [Whistleblow HN: Ollama is being deceitful and everyone should know](https://github.com/ollama/ollama/issues/11714)<!-- HN:44864171:end --><!-- HN:44865319:start -->
* [44865319](https://news.social-protocols.org/stats?id=44865319) #27 9 points 0 comments -> [Hard Drive Shortage in Canada?](https://www.vogons.org/viewtopic.php?t=107758)<!-- HN:44865319:end --><!-- HN:44866970:start -->
* [44866970](https://news.social-protocols.org/stats?id=44866970) #17 23 points 9 comments -> [Cloudflare Is Not a CDN](https://magecdn.com/blog/2025/08/11/cloudflare-not-a-cdn/)<!-- HN:44866970:end --><!-- HN:44863487:start -->
* [44863487](https://news.social-protocols.org/stats?id=44863487) #1 618 points 203 comments -> [Wikimedia Foundation Challenges UK Online Safety Act Regulations](https://wikimediafoundation.org/news/2025/08/11/wikimedia-foundation-challenges-uk-online-safety-act-regulations/)<!-- HN:44863487:end --><!-- HN:44870502:start -->
* [44870502](https://news.social-protocols.org/stats?id=44870502) #23 8 points 1 comments -> [The GPT-5 rollout has been a big mess](https://arstechnica.com/information-technology/2025/08/the-gpt-5-rollout-has-been-a-big-mess/)<!-- HN:44870502:end -->