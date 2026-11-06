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

#### **Saturday, October 31, 2026**
<!-- HN:50311537:start -->
* [50311537](https://news.social-protocols.org/stats?id=50311537) #2 19 points 40 comments -> [Fair Use Benefits Everyone](https://openai.com/index/fair-use-benefits-everyone/)<!-- HN:50311537:end --><!-- HN:50311670:start -->
* [50311670](https://news.social-protocols.org/stats?id=50311670) #15 5 points 0 comments -> [Be a Loser](https://makemeacto.cc/be-a-loser/)<!-- HN:50311670:end --><!-- HN:50312221:start -->
* [50312221](https://news.social-protocols.org/stats?id=50312221) #15 4 points 2 comments -> [Do At-Proto Users Know This Is Public?](https://melaniekat.com/blog/public-on-pds/)<!-- HN:50312221:end --><!-- HN:50313508:start -->
* [50313508](https://news.social-protocols.org/stats?id=50313508) #1 -> [Tools Hacker News keeps asking for](https://stillunbuilt.shiptiffin.app/)<!-- HN:50313508:end --><!-- HN:50289991:start -->
* [50289991](https://news.social-protocols.org/stats?id=50289991) #28 17 points 0 comments -> [Configure a UPS on Linux with NUT](https://linuxjunkies.org/guides/configure-a-ups-with-nut)<!-- HN:50289991:end --><!-- HN:50316275:start -->
* [50316275](https://news.social-protocols.org/stats?id=50316275) #4 8 points 3 comments -> [MoneyPouch – self hosted expense tracker](https://demo.moneypouch.app/session/new)<!-- HN:50316275:end --><!-- HN:50316526:start -->
* [50316526](https://news.social-protocols.org/stats?id=50316526) #10 3 points 6 comments -> [Gemini Code vs. Claude Code – A cautionary post-mortem ($800 in 12h)](https://n.aspencreekbs.com/RZo9ksiKqtTiTLy6b0xiKj2j)<!-- HN:50316526:end --><!-- HN:50317332:start -->
* [50317332](https://news.social-protocols.org/stats?id=50317332) #29 3 points 0 comments -> [How this AI Agent ended +$517.61 in profits during a 10% market sell-off](https://twitter.com/DeployFinance/status/2116556597082116490)<!-- HN:50317332:end --><!-- HN:50318812:start -->
* [50318812](https://news.social-protocols.org/stats?id=50318812) #13 3 points 0 comments -> [Shaun Thomas: Burnt Toast](https://www.pgedge.com/blog/burnt-toast)<!-- HN:50318812:end --><!-- HN:50319873:start -->
* [50319873](https://news.social-protocols.org/stats?id=50319873) #5 7 points 1 comments -> [GPT-6.1 Terra](https://simonwillison.net/2026/Oct/26/gpt-61-terra/)<!-- HN:50319873:end --><!-- HN:50320003:start -->
* [50320003](https://news.social-protocols.org/stats?id=50320003) #7 18 points 9 comments -> [Common Desktop Environment available now as open-source](https://sourceforge.net/projects/cdesktopenv/)<!-- HN:50320003:end --><!-- HN:50321351:start -->
* [50321351](https://news.social-protocols.org/stats?id=50321351) #6 9 points 0 comments -> [Inverse Zitron: An Investment Strategy](https://chalmovsky.com/posts/inverse-zitron)<!-- HN:50321351:end -->
#### **Sunday, November 1, 2026**
<!-- HN:50321373:start -->
* [50321373](https://news.social-protocols.org/stats?id=50321373) #26 8 points 0 comments -> [Work Requirements for Trick-or-Treaters](https://morewrong.lol/?post=work-requirements-trick-or-treaters)<!-- HN:50321373:end --><!-- HN:50325072:start -->
* [50325072](https://news.social-protocols.org/stats?id=50325072) #14 6 points 2 comments -> [Is It EDT or EST?](https://www.edtorest.com)<!-- HN:50325072:end --><!-- HN:50325069:start -->
* [50325069](https://news.social-protocols.org/stats?id=50325069) #16 17 points 7 comments -> [Everyone Has Email. Nobody Uses It Right](https://kaplich.me/essays/email)<!-- HN:50325069:end --><!-- HN:50326025:start -->
* [50326025](https://news.social-protocols.org/stats?id=50326025) #7 21 points 12 comments -> [Pi Is the Last Harness](https://destiner.io/blog/post/pi-is-the-last-harness/)<!-- HN:50326025:end --><!-- HN:50326699:start -->
* [50326699](https://news.social-protocols.org/stats?id=50326699) #8 13 points 2 comments -> [We Took over ChatGPT Accounts](https://simonwillison.net/2026/Oct/31/how-we-took-over-chatgpt-accounts/)<!-- HN:50326699:end --><!-- HN:50326721:start -->
* [50326721](https://news.social-protocols.org/stats?id=50326721) #13 4 points 1 comments -> [I vibecoded a 2d pixel game in 6h yesterday](https://www.sabih.dev/game/)<!-- HN:50326721:end --><!-- HN:50330005:start -->
* [50330005](https://news.social-protocols.org/stats?id=50330005) #4 65 points 39 comments -> [Apple captures 50% of consumer revenue of the top half of the S&P 500](https://asymco.com/2026/11/01/the-last-consumer-company/)<!-- HN:50330005:end -->
#### **Monday, November 2, 2026**
<!-- HN:50335914:start -->
* [50335914](https://news.social-protocols.org/stats?id=50335914) #14 27 points 41 comments -> [Private Jet plane crashes in Florida](https://www.cbc.ca/news/world/florida-plane-crash-9.7404996)<!-- HN:50335914:end --><!-- HN:50336221:start -->
* [50336221](https://news.social-protocols.org/stats?id=50336221) #7 5 points 2 comments -> [Claude is providing incorrect or misleading responses](https://support.claude.com/en/articles/8525154-claude-is-providing-incorrect-or-misleading-responses-what-s-going-on)<!-- HN:50336221:end --><!-- HN:50336791:start -->
* [50336791](https://news.social-protocols.org/stats?id=50336791) #5 53 points 20 comments -> [Sam Altman: All the RAM Should Belong to Me, So I Can Charge People to Use It](https://gizmodo.com/sam-altman-all-the-ram-should-belong-to-me-so-i-can-charge-people-to-use-it-2000833412)<!-- HN:50336791:end --><!-- HN:50336921:start -->
* [50336921](https://news.social-protocols.org/stats?id=50336921) #5 39 points 12 comments -> [Pray for Chaos](https://geohot.github.io//blog/jekyll/update/2026/11/01/pray-for-chaos.html)<!-- HN:50336921:end --><!-- HN:50333877:start -->
* [50333877](https://news.social-protocols.org/stats?id=50333877) #7 168 points 24 comments -> [Show HN: HackerHack – HackerBooks but for Posts Posted on HN](https://news.ycombinator.com/)<!-- HN:50333877:end --><!-- HN:50337392:start -->
* [50337392](https://news.social-protocols.org/stats?id=50337392) #23 19 points 13 comments -> [School has given straight-a grades to the student, who can't do masic math](https://nypost.com/2026/10/31/us-news/adriana-aviles-says-her-son-was-given-phony-grades-is-behind-in-math/)<!-- HN:50337392:end --><!-- HN:50337653:start -->
* [50337653](https://news.social-protocols.org/stats?id=50337653) #19 -> [The U.S. Is Bullying Europe Like Never Before](https://www.theatlantic.com/ideas/2026/11/trump-europe-guilfoyle-afd-meddling/689226/)<!-- HN:50337653:end --><!-- HN:50336025:start -->
* [50336025](https://news.social-protocols.org/stats?id=50336025) #15 13 points 1 comments -> [Show HN: Hacker News but for comments posted on HN](https://news.ycombinator.com/newcomments)<!-- HN:50336025:end --><!-- HN:50337410:start -->
* [50337410](https://news.social-protocols.org/stats?id=50337410) #11 5 points 3 comments -> [Show HN: Aulico, my free tradingview alternative](https://www.aulico.com)<!-- HN:50337410:end --><!-- HN:50339021:start -->
* [50339021](https://news.social-protocols.org/stats?id=50339021) #10 7 points 3 comments -> [Grokipedia offers lessons in how AI can help Wikipedia](https://www.niemanlab.org/2026/11/elon-musks-grokipedia-is-littered-with-mistakes-but-wikipedia-could-still-learn-some-things-from-it/)<!-- HN:50339021:end --><!-- HN:50340109:start -->
* [50340109](https://news.social-protocols.org/stats?id=50340109) #6 5 points 0 comments -> [Vibe-Coding a Game in 2026: What AI Builds, What Breaks](https://vlstudio.app/blog/vibe-coding-a-game-2026/)<!-- HN:50340109:end --><!-- HN:50338871:start -->
* [50338871](https://news.social-protocols.org/stats?id=50338871) #14 15 points 10 comments -> [Show HN: VHS Camera – Run your camera or videos through a simulated VHS signal](https://fotojockovic.com/vhs)<!-- HN:50338871:end --><!-- HN:50340362:start -->
* [50340362](https://news.social-protocols.org/stats?id=50340362) #26 28 points 10 comments -> [I Read the Clankers' Code](https://fev.al/posts/i-read-the-code/)<!-- HN:50340362:end --><!-- HN:50344536:start -->
* [50344536](https://news.social-protocols.org/stats?id=50344536) #26 16 points 3 comments -> [Stop Hogging RAM You Monster](https://ramhogger.monster/)<!-- HN:50344536:end -->
#### **Tuesday, November 3, 2026**<!-- HN:50347574:start -->
* [50347574](https://news.social-protocols.org/stats?id=50347574) #11 11 points 1 comments -> [Own Your HackerTube,an AI Curator Inspired by Karpathy's HackerTube](https://ownhackertube.cc/)<!-- HN:50347574:end --><!-- HN:50350693:start -->
* [50350693](https://news.social-protocols.org/stats?id=50350693) #19 22 points 42 comments -> [Sam Altman's Case Against Your RAM Is Efficient. That's the Problem](https://www.techdirt.com/2026/11/02/sam-altmans-case-against-your-ram-is-efficient-thats-the-problem/)<!-- HN:50350693:end --><!-- HN:50350673:start -->
* [50350673](https://news.social-protocols.org/stats?id=50350673) #22 9 points 0 comments -> [Ten harness patterns that you can apply to a real repo](https://deepsense.ai/blog/harness-engineering-for-coding-agents-9-patterns-for-more-reliable-ai-assisted-development/)<!-- HN:50350673:end --><!-- HN:50353465:start -->
* [50353465](https://news.social-protocols.org/stats?id=50353465) #6 5 points 2 comments -> [The State of Longevity: The healthmaxxing economy is here](https://www.a16z.news/p/the-state-of-longevity)<!-- HN:50353465:end --><!-- HN:50353905:start -->
* [50353905](https://news.social-protocols.org/stats?id=50353905) #9 36 points 10 comments -> [Google Will Turn Off Search for Schools That Reject A.I](https://www.nytimes.com/2026/11/03/us/google-search-schools-restrict-ai.html)<!-- HN:50353905:end --><!-- HN:50355782:start -->
* [50355782](https://news.social-protocols.org/stats?id=50355782) #10 7 points 0 comments -> [People Against Genocide Smash Military Satellites on Balfour Anniversary](https://aftershock.media/military-satellites-balfour/)<!-- HN:50355782:end --><!-- HN:50357862:start -->
* [50357862](https://news.social-protocols.org/stats?id=50357862) #8 -> [Subvocal raised $1.3M. A developer recreated it with AirPods in 9 minutes](https://github.com/joeblau/subvox)<!-- HN:50357862:end -->
#### **Wednesday, November 4, 2026**
<!-- HN:50359839:start -->
* [50359839](https://news.social-protocols.org/stats?id=50359839) #13 12 points 6 comments -> [Prompting Is Programming](https://www.brethorsting.com/blog/2026/11/prompting-is-programming/)<!-- HN:50359839:end --><!-- HN:50360720:start -->
* [50360720](https://news.social-protocols.org/stats?id=50360720) #6 9 points 1 comments -> [Running 17 Claude Code bots in a real company for $100/month](https://botsinproduction.com/blog/what-10-claude-code-bots-cost-per-month/)<!-- HN:50360720:end --><!-- HN:50363193:start -->
* [50363193](https://news.social-protocols.org/stats?id=50363193) #5 21 points 11 comments -> [Osewa – An open-source alternative to SSH and Mosh](https://osewa.dev/)<!-- HN:50363193:end --><!-- HN:50363717:start -->
* [50363717](https://news.social-protocols.org/stats?id=50363717) #13 31 points 23 comments -> [Told to reboot a server, it destroyed systemd, destroyed containers, ran random](https://github.com/openai/codex/issues/59060)<!-- HN:50363717:end --><!-- HN:50364430:start -->
* [50364430](https://news.social-protocols.org/stats?id=50364430) #17 3 points 1 comments -> [The engineering around post-quantum cryptography is as important](https://github.com/lecodev-26/nexus-q)<!-- HN:50364430:end --><!-- HN:50365159:start -->
* [50365159](https://news.social-protocols.org/stats?id=50365159) #24 13 points 3 comments -> [I got banned from Lobsters for writing like an LLM](https://en.andros.dev/blog/94a77341/i-got-banned-from-lobsters-for-writing-like-an-llm/)<!-- HN:50365159:end --><!-- HN:50365009:start -->
* [50365009](https://news.social-protocols.org/stats?id=50365009) #29 10 points 5 comments -> [Disaster is still better than AI](https://jasonpolak.substack.com/p/disaster-is-still-better-than-ai)<!-- HN:50365009:end --><!-- HN:50364561:start -->
* [50364561](https://news.social-protocols.org/stats?id=50364561) #22 51 points 20 comments -> [A map of 5000+ midterm ads](https://admap.org/)<!-- HN:50364561:end --><!-- HN:50369544:start -->
* [50369544](https://news.social-protocols.org/stats?id=50369544) #18 14 points 3 comments -> [A farmer destroys 10 hectares of crops after following AI advice](https://miguelstudy.pages.dev/a-farmer-destroys-10-hectares-of-crops/)<!-- HN:50369544:end --><!-- HN:50369840:start -->
* [50369840](https://news.social-protocols.org/stats?id=50369840) #16 49 points 1 comments -> [Conductor Is Joining Meta](https://www.conductor.build/changelog/0.93.0-conductor-is-joining-meta)<!-- HN:50369840:end -->
#### **Thursday, November 5, 2026**
<!-- HN:50375728:start -->
* [50375728](https://news.social-protocols.org/stats?id=50375728) #3 60 points 11 comments -> [Want to Rent an Internet Address at the White House?](https://krebsonsecurity.com/2026/11/want-to-rent-an-internet-address-at-the-white-house/)<!-- HN:50375728:end --><!-- HN:50337586:start -->
* [50337586](https://news.social-protocols.org/stats?id=50337586) #13 14 points 4 comments -> [An intuition for how neural nets can understand text](https://info.zairai.ai/neurons-understanding-text)<!-- HN:50337586:end --><!-- HN:50385091:start -->
* [50385091](https://news.social-protocols.org/stats?id=50385091) #17 6 points 0 comments -> [How "Safety" Rhetoric Is Weaponized to Protect Israel and Smear Its Critics](https://www.columnblog.com/p/how-safety-rhetoric-is-weaponized)<!-- HN:50385091:end --><!-- HN:50385764:start -->
* [50385764](https://news.social-protocols.org/stats?id=50385764) #24 -> [Thursday's $3T tech sell-off, and what it means if you build AI products](https://vithushansylvester.com/writing/the-3-trillion-thursday)<!-- HN:50385764:end -->
#### **Friday, November 6, 2026**
<!-- HN:50383963:start -->
* [50383963](https://news.social-protocols.org/stats?id=50383963) #9 94 points 3 comments -> [Tencent Launches Hy4, One of the Leading Open-Source AI Models](https://www.tencent.com/tencent-launches-hy4-joining-the-ranks-of-the-worlds-leading-open-source-ai-models/)<!-- HN:50383963:end --><!-- HN:50387623:start -->
* [50387623](https://news.social-protocols.org/stats?id=50387623) #12 11 points 2 comments -> [Claude was faster and cheaper. We took the scenic route anyway](https://blog.grainulation.org/verify-then-vote/)<!-- HN:50387623:end -->