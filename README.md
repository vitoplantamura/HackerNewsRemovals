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

#### **Tuesday, March 24, 2026**
<!-- HN:47496798:start -->
* [47496798](https://news.social-protocols.org/stats?id=47496798) #6 31 points 29 comments -> [No, Windows Start does not use React](https://pathar.tl/blog/no-windows-start-does-not-use-react/)<!-- HN:47496798:end --><!-- HN:47496232:start -->
* [47496232](https://news.social-protocols.org/stats?id=47496232) #9 16 points 4 comments -> [Study: Workers who fall for 'corporate bullshit' may be worse at their jobs](https://www.theguardian.com/business/2026/mar/23/corporate-speak-study)<!-- HN:47496232:end --><!-- HN:47498108:start -->
* [47498108](https://news.social-protocols.org/stats?id=47498108) #2 16 points 2 comments -> [US bans new foreign-made consumer Internet routers](https://www.bbc.com/news/articles/c74787w149zo)<!-- HN:47498108:end --><!-- HN:47498509:start -->
* [47498509](https://news.social-protocols.org/stats?id=47498509) #2 40 points 2 comments -> [Box of Secrets: Discreetly modding an apartment intercom with Matter](https://www.jackhogan.me/blog/box-of-secrets/)<!-- HN:47498509:end --><!-- HN:47499438:start -->
* [47499438](https://news.social-protocols.org/stats?id=47499438) #17 4 points 0 comments -> [systemd has not implemented age verification](https://blog.bofh.it/debian/id_473)<!-- HN:47499438:end --><!-- HN:47433429:start -->
* [47433429](https://news.social-protocols.org/stats?id=47433429) #22 144 points 80 comments -> [Books of the Century by Le Monde](https://standardebooks.org/collections/le-mondes-100-books-of-the-century)<!-- HN:47433429:end --><!-- HN:47499033:start -->
* [47499033](https://news.social-protocols.org/stats?id=47499033) #23 10 points 2 comments -> [Pool spare GPU capacity to run LLMs at larger scale](https://github.com/michaelneale/mesh-llm)<!-- HN:47499033:end --><!-- HN:47500954:start -->
* [47500954](https://news.social-protocols.org/stats?id=47500954) #6 3 points 0 comments -> [Israel's Defense Innovation Industrial Base](https://www.israeltechinsider.com/p/inside-israels-defense-innovation)<!-- HN:47500954:end --><!-- HN:47500823:start -->
* [47500823](https://news.social-protocols.org/stats?id=47500823) #16 15 points 0 comments -> [ICE: $45 an Hour to Stand There. TSA: $0 an Hour to Keep You Safe](https://botonomous.ai/featured/government_shutdown/article-v2.html)<!-- HN:47500823:end --><!-- HN:47502460:start -->
* [47502460](https://news.social-protocols.org/stats?id=47502460) #3 25 points 4 comments -> [Your bridge to wealth is being pulled up](https://danielhomola.com/m%20&%20e/ai/your-bridge-to-wealth-is-being-pulled-up/)<!-- HN:47502460:end --><!-- HN:47503493:start -->
* [47503493](https://news.social-protocols.org/stats?id=47503493) #4 5 points 3 comments -> [The Engineer Who Tried to Put Age Verification into Linux](https://www.sambent.com/the-engineer-who-tried-to-put-age-verification-into-linux-5/)<!-- HN:47503493:end --><!-- HN:47506519:start -->
* [47506519](https://news.social-protocols.org/stats?id=47506519) #1 94 points 56 comments -> [FCC has banned the import of all new foreign-made routers here's what you can do](https://blog.adafruit.com/2026/03/24/fcc-just-banned-the-import-of-all-new-foreign-made-routers-heres-what-you-can-do-about-it/)<!-- HN:47506519:end --><!-- HN:47501729:start -->
* [47501729](https://news.social-protocols.org/stats?id=47501729) #9 701 points 1 comments -> [LiteLLM Python package compromised by supply-chain attack](https://github.com/BerriAI/litellm/issues/24512)<!-- HN:47501729:end --><!-- HN:47431465:start -->
* [47431465](https://news.social-protocols.org/stats?id=47431465) #18 12 points 0 comments -> [Building Liberal Compute](https://simongrimm.substack.com/p/building-liberal-compute)<!-- HN:47431465:end --><!-- HN:47439413:start -->
* [47439413](https://news.social-protocols.org/stats?id=47439413) #24 123 points 131 comments -> [No-build, no-NPM, SSR-first JavaScript framework if you hate React, love HTML](https://qitejs.qount25.dev)<!-- HN:47439413:end --><!-- HN:47510657:start -->
* [47510657](https://news.social-protocols.org/stats?id=47510657) #11 10 points 3 comments -> [Thoughts on LLMs – Psychological Complications](https://parsingphase.dev/tech/LLMs/psychologicalFactors.html)<!-- HN:47510657:end --><!-- HN:47509234:start -->
* [47509234](https://news.social-protocols.org/stats?id=47509234) #5 197 points 1 comments -> [Disney Exits OpenAI Deal After AI Giant Shutters Sora](https://www.hollywoodreporter.com/business/digital/openai-shutting-down-sora-ai-video-app-1236546187/)<!-- HN:47509234:end -->
#### **Wednesday, March 25, 2026**
<!-- HN:47513098:start -->
* [47513098](https://news.social-protocols.org/stats?id=47513098) #22 69 points 27 comments -> [Meta ordered to pay $375M in New Mexico trial over child exploitation](https://www.reuters.com/sustainability/boards-policy-regulation/jury-orders-meta-pay-375-mln-new-mexico-lawsuit-over-child-sexual-exploitation-2026-03-24/)<!-- HN:47513098:end --><!-- HN:47517904:start -->
* [47517904](https://news.social-protocols.org/stats?id=47517904) #25 6 points 0 comments -> [Palestinians warn of expanding West Bank settler violence](https://www.bbc.com/news/articles/c747x00m83vo)<!-- HN:47517904:end --><!-- HN:47519114:start -->
* [47519114](https://news.social-protocols.org/stats?id=47519114) #8 4 points 0 comments -> [Death by Clawd](https://deathbyclawd.com)<!-- HN:47519114:end --><!-- HN:47520825:start -->
* [47520825](https://news.social-protocols.org/stats?id=47520825) #9 10 points 4 comments -> [I bought the MacBook Neo and it sucks](https://alexandmanu.com/blog/the-macbook-neo-disappointment/)<!-- HN:47520825:end --><!-- HN:47519625:start -->
* [47519625](https://news.social-protocols.org/stats?id=47519625) #3 271 points 53 comments -> [Jury says Meta knowingly harmed children for profit, awarding landmark verdict](https://www.latimes.com/business/story/2026-03-25/jury-says-meta-knowingly-harmed-children-for-profit-awarding-landmark-verdict)<!-- HN:47519625:end --><!-- HN:47521766:start -->
* [47521766](https://news.social-protocols.org/stats?id=47521766) #3 9 points 4 comments -> [Model collapse is already happening](https://cacm.acm.org/blogcacm/model-collapse-is-already-happening-we-just-pretend-it-isnt/)<!-- HN:47521766:end --><!-- HN:47520717:start -->
* [47520717](https://news.social-protocols.org/stats?id=47520717) #4 91 points 1 comments -> [Meta and Google found liable in social media addiction trial](https://www.bbc.co.uk/news/articles/c747x7gz249o)<!-- HN:47520717:end --><!-- HN:47518785:start -->
* [47518785](https://news.social-protocols.org/stats?id=47518785) #24 144 points 2 comments -> [Sony V. Cox Decision Reversed](https://supreme.justia.com/cases/federal/us/607/24-171/)<!-- HN:47518785:end --><!-- HN:47522238:start -->
* [47522238](https://news.social-protocols.org/stats?id=47522238) #13 9 points 2 comments -> [ARC-AGI-3 benchmark is out now](https://arcprize.org/tasks/ls20)<!-- HN:47522238:end --><!-- HN:47523053:start -->
* [47523053](https://news.social-protocols.org/stats?id=47523053) #11 5 points 1 comments -> [Supreme Court rules ISPs aren't liable for subscribers' music piracy](https://www.engadget.com/entertainment/streaming/supreme-court-rules-isps-arent-liable-for-subscribers-music-piracy-163412791.html)<!-- HN:47523053:end --><!-- HN:47522492:start -->
* [47522492](https://news.social-protocols.org/stats?id=47522492) #20 5 points 3 comments -> [Tired of Ghost Positions in Companies?](https://ghostjobs.net)<!-- HN:47522492:end --><!-- HN:47524633:start -->
* [47524633](https://news.social-protocols.org/stats?id=47524633) #29 10 points 0 comments -> [ICE has been lying about being authorized to make arrests at immigration courts](https://bsky.app/profile/bradlander.bsky.social/post/3mhvpk32vxc2e)<!-- HN:47524633:end -->
#### **Thursday, March 26, 2026**
<!-- HN:47481983:start -->
* [47481983](https://news.social-protocols.org/stats?id=47481983) #17 6 points 0 comments -> [We Solved the Recording Problem. The Playback Problem Is Still Broken](https://medium.com/@jo.sagar/we-solved-the-recording-problem-the-playback-problem-is-still-broken-1768038911b3)<!-- HN:47481983:end --><!-- HN:47526276:start -->
* [47526276](https://news.social-protocols.org/stats?id=47526276) #8 19 points 11 comments -> [Show HN: Nit – I rebuilt Git in Zig to save AI agents 71% on tokens](https://justfielding.com/blog/nit-replacing-git-with-zig)<!-- HN:47526276:end --><!-- HN:47528380:start -->
* [47528380](https://news.social-protocols.org/stats?id=47528380) #4 35 points 32 comments -> [Why Sora Failed: $15M/day inference cost vs. $2.1M lifetime revenue](https://www.revolutioninai.com/2026/03/%20chatgpt-gpt-54-mini-silent-switch-march-2026.html)<!-- HN:47528380:end --><!-- HN:47528683:start -->
* [47528683](https://news.social-protocols.org/stats?id=47528683) #19 10 points 17 comments -> [Show HN: Relay – The open-source Claude Cowork for OpenClaw](https://github.com/SeventeenLabs/relay)<!-- HN:47528683:end --><!-- HN:47526467:start -->
* [47526467](https://news.social-protocols.org/stats?id=47526467) #16 17 points 3 comments -> [The Cassandra of 'The Machine'](https://www.thenewatlantis.com/publications/the-cassandra-of-the-machine)<!-- HN:47526467:end --><!-- HN:47529534:start -->
* [47529534](https://news.social-protocols.org/stats?id=47529534) #8 288 points 199 comments -> [Landmark L.A. jury verdict finds Instagram, YouTube were designed to addict kids](https://www.latimes.com/california/story/2026-03-25/social-media-lawsuit-trial-meta-google-verdict)<!-- HN:47529534:end --><!-- HN:47530984:start -->
* [47530984](https://news.social-protocols.org/stats?id=47530984) #23 63 points 7 comments -> [Meta and YouTube Found Negligent in Social-Media Addiction Trial](https://www.wsj.com/tech/personal-tech/meta-and-youtube-found-negligent-in-social-media-addiction-trial-35b2830d)<!-- HN:47530984:end --><!-- HN:47529646:start -->
* [47529646](https://news.social-protocols.org/stats?id=47529646) #5 533 points 120 comments -> [European Parliament decided that Chat Control 1.0 must stop](https://bsky.app/profile/tuta.com/post/3mhxkfowv322c)<!-- HN:47529646:end --><!-- HN:47462834:start -->
* [47462834](https://news.social-protocols.org/stats?id=47462834) #17 14 points 9 comments -> [Ant Chat](https://www.baothiento.com/ant-chat)<!-- HN:47462834:end --><!-- HN:47532145:start -->
* [47532145](https://news.social-protocols.org/stats?id=47532145) #22 45 points 6 comments -> [Show HN: Claude skill that evaluates B2B vendors by talking to their AI agents](https://github.com/salespeak-ai/buyer-eval-skill)<!-- HN:47532145:end --><!-- HN:47457407:start -->
* [47457407](https://news.social-protocols.org/stats?id=47457407) #5 106 points 49 comments -> [Fermented foods shaped human biology](https://press.asimov.com/articles/culture-shift)<!-- HN:47457407:end --><!-- HN:47534830:start -->
* [47534830](https://news.social-protocols.org/stats?id=47534830) #30 11 points 5 comments -> [The Secret History of European Intelligence and Mossad's Assassination Campaign](https://www.lrb.co.uk/the-paper/v48/n06/andrew-cockburn/beware-the-mattress)<!-- HN:47534830:end -->
#### **Friday, March 27, 2026**
<!-- HN:47495076:start -->
* [47495076](https://news.social-protocols.org/stats?id=47495076) #9 10 points 0 comments -> [Every Kid Gets a Robot](https://www.steamconnection.org/ekgar)<!-- HN:47495076:end --><!-- HN:47538078:start -->
* [47538078](https://news.social-protocols.org/stats?id=47538078) #18 83 points 46 comments -> [From 0% to 36% on Day 1 of ARC-AGI-3](https://www.symbolica.ai/blog/arc-agi-3)<!-- HN:47538078:end --><!-- HN:47540422:start -->
* [47540422](https://news.social-protocols.org/stats?id=47540422) #4 -> [Was the Iran War Caused by AI Psychosis?](https://houseofsaud.com/iran-war-ai-psychosis-sycophancy-rlhf/)<!-- HN:47540422:end --><!-- HN:47490571:start -->
* [47490571](https://news.social-protocols.org/stats?id=47490571) #16 6 points 3 comments -> [Understanding the Go Runtime: The Garbage Collector](https://internals-for-interns.com/posts/go-garbage-collector/)<!-- HN:47490571:end --><!-- HN:47543361:start -->
* [47543361](https://news.social-protocols.org/stats?id=47543361) #29 17 points 14 comments -> [Rising Air-Conditioning Use Intensifies Global Warming](https://www.nature.com/articles/s41467-026-69393-1)<!-- HN:47543361:end --><!-- HN:47544006:start -->
* [47544006](https://news.social-protocols.org/stats?id=47544006) #9 20 points 6 comments -> [SimpleX Chat](https://simplex.chat/)<!-- HN:47544006:end --><!-- HN:47546262:start -->
* [47546262](https://news.social-protocols.org/stats?id=47546262) #4 23 points 33 comments -> [Don't Wait for Claude](https://jeapostrophe.github.io/tech/jc-workflow/)<!-- HN:47546262:end --><!-- HN:47546028:start -->
* [47546028](https://news.social-protocols.org/stats?id=47546028) #13 53 points 19 comments -> [We broke 92% of SHA-256 – you should start to migrate from it](https://stateofutopia.com/papers/2/we-broke-92-percent-of-sha-256.html)<!-- HN:47546028:end --><!-- HN:47490609:start -->
* [47490609](https://news.social-protocols.org/stats?id=47490609) #10 164 points 58 comments -> [How and why to take a logarithm of an image [video]](https://www.youtube.com/watch?v=ldxFjLJ3rVY)<!-- HN:47490609:end --><!-- HN:47546265:start -->
* [47546265](https://news.social-protocols.org/stats?id=47546265) #1 81 points 36 comments -> [PyPI package telnyx has been compromised in yet another supply chain attack](https://www.aikido.dev/blog/telnyx-pypi-compromised-teampcp-canisterworm)<!-- HN:47546265:end --><!-- HN:47546081:start -->
* [47546081](https://news.social-protocols.org/stats?id=47546081) #7 16 points 4 comments -> [Telnyx Python SDK: Supply Chain Security Notice](https://telnyx.com/resources/telnyx-python-sdk-supply-chain-security-notice-march-2026)<!-- HN:47546081:end --><!-- HN:47545032:start -->
* [47545032](https://news.social-protocols.org/stats?id=47545032) #28 150 points 3 comments -> [Iran-linked hackers have breached FBI director's personal emails](https://www.cnn.com/2026/03/27/politics/iran-linked-hackers-fbi-director-patel)<!-- HN:47545032:end --><!-- HN:47546181:start -->
* [47546181](https://news.social-protocols.org/stats?id=47546181) #27 5 points 0 comments -> [Statistics Canada to Replace Food and Gas with "Huge TVs" in Inflation Reporting](https://lzon.ca/posts/series/duck/tv-inflation/)<!-- HN:47546181:end --><!-- HN:47547686:start -->
* [47547686](https://news.social-protocols.org/stats?id=47547686) #7 4 points 0 comments -> [The telnyx packages on PyPI have been compromised](https://lwn.net/Articles/1065059/)<!-- HN:47547686:end --><!-- HN:47547671:start -->
* [47547671](https://news.social-protocols.org/stats?id=47547671) #2 13 points 3 comments -> [Was the Iran War Caused by AI Psychosis?](https://houseofsaud.com/iran-war-ai-psychosis-sycophancy-rlhf/)<!-- HN:47547671:end -->
#### **Saturday, March 28, 2026**
<!-- HN:47511838:start -->
* [47511838](https://news.social-protocols.org/stats?id=47511838) #20 19 points 8 comments -> [Matlab Alternatives 2026: Benchmarks, GPU, Browser and Compatibility Compared](https://runmat.com/blog/free-matlab-alternatives)<!-- HN:47511838:end --><!-- HN:47550366:start -->
* [47550366](https://news.social-protocols.org/stats?id=47550366) #11 3 points 1 comments -> [Brent Price Now – Free AI oil market insights and email price alerts](https://brentpricenow.top/price-alerts)<!-- HN:47550366:end --><!-- HN:47550684:start -->
* [47550684](https://news.social-protocols.org/stats?id=47550684) #2 7 points 1 comments -> [Brave Browser unable to block certain ads due to Rust language limitations](https://github.com/brave/brave-browser/issues/43098)<!-- HN:47550684:end --><!-- HN:47548670:start -->
* [47548670](https://news.social-protocols.org/stats?id=47548670) #21 247 points 129 comments -> [DOJ confirms FBI Director Kash Patel's personal email was hacked](https://arstechnica.com/tech-policy/2026/03/doj-confirms-fbi-director-kash-patels-personal-email-was-hacked/)<!-- HN:47548670:end --><!-- HN:47551254:start -->
* [47551254](https://news.social-protocols.org/stats?id=47551254) #12 13 points 10 comments -> [The future of text layout is not CSS](https://chenglou.me/pretext/editorial-engine/)<!-- HN:47551254:end --><!-- HN:47552059:start -->
* [47552059](https://news.social-protocols.org/stats?id=47552059) #10 5 points 1 comments -> [Stop Calling Every AI Miss a Hallucination](https://ai.gtzilla.com/papers/stop-calling-every-ai-miss-a-hallucination-v1.0/)<!-- HN:47552059:end --><!-- HN:47553345:start -->
* [47553345](https://news.social-protocols.org/stats?id=47553345) #18 5 points 1 comments -> [Palestinian toddler returns injured after IDF detention in Gaza](https://news.sky.com/story/gaza-toddler-released-from-israeli-custody-with-suspected-torture-wounds-13525011)<!-- HN:47553345:end --><!-- HN:47554412:start -->
* [47554412](https://news.social-protocols.org/stats?id=47554412) #20 34 points 27 comments -> [You Do Not, in Fact, Have to Hand It to Them](https://2ndbreakfast.audreywatters.com/you-do-not-in-fact-have-to-hand-it-to-them/)<!-- HN:47554412:end --><!-- HN:47554779:start -->
* [47554779](https://news.social-protocols.org/stats?id=47554779) #22 4 points 0 comments -> [Behind the Scenes of the Westworld UI](https://vanschneider.com/blog/behind-the-scenes-of-the-westworld-ui/)<!-- HN:47554779:end --><!-- HN:47550016:start -->
* [47550016](https://news.social-protocols.org/stats?id=47550016) #16 13 points 4 comments -> [Going Founder Mode on Cancer](https://centuryofbio.com/p/sid)<!-- HN:47550016:end --><!-- HN:47555636:start -->
* [47555636](https://news.social-protocols.org/stats?id=47555636) #15 44 points 17 comments -> [Show HN: Free, in-browser PDF editor](https://breezepdf.com/?v=2)<!-- HN:47555636:end --><!-- HN:47556979:start -->
* [47556979](https://news.social-protocols.org/stats?id=47556979) #17 -> [Bitwarden Doubled Their Price. I'd Left. Here's What You Missed](https://blog.ppb1701.com/bitwarden-doubled-their-price-id-already-left-heres-what-you-missed)<!-- HN:47556979:end --><!-- HN:47556347:start -->
* [47556347](https://news.social-protocols.org/stats?id=47556347) #20 10 points 1 comments -> [Show HN: A prompt that builds the most capable AI agent system](https://github.com/fainir/most-capable-agent-system-prompt)<!-- HN:47556347:end --><!-- HN:47557355:start -->
* [47557355](https://news.social-protocols.org/stats?id=47557355) #14 7 points 5 comments -> [Nothing new to see here](https://feld.com/archives/2026/03/nothing-new-to-see-here/)<!-- HN:47557355:end --><!-- HN:47557058:start -->
* [47557058](https://news.social-protocols.org/stats?id=47557058) #21 15 points 4 comments -> [Improving personal tax filing with Claude CLI and Obsidian](https://www.mrafayaleem.com/blog/improving-personal-tax-filing-with-claude-obsidian)<!-- HN:47557058:end --><!-- HN:47557804:start -->
* [47557804](https://news.social-protocols.org/stats?id=47557804) #30 12 points 0 comments -> [Iran images appear to show land mines scattered by U.S. forces, a first in years](https://www.washingtonpost.com/investigations/2026/03/27/iran-us-land-mines/)<!-- HN:47557804:end --><!-- HN:47558813:start -->
* [47558813](https://news.social-protocols.org/stats?id=47558813) #25 8 points 0 comments -> [Roman Catholic Churches See a Surge of New Converts](https://www.nytimes.com/2026/03/26/us/catholics-converts.html)<!-- HN:47558813:end -->
#### **Sunday, March 29, 2026**
<!-- HN:47559026:start -->
* [47559026](https://news.social-protocols.org/stats?id=47559026) #25 6 points 0 comments -> [Attie.ai](https://attie.ai/login)<!-- HN:47559026:end --><!-- HN:47560592:start -->
* [47560592](https://news.social-protocols.org/stats?id=47560592) #29 15 points 5 comments -> [The United States is driving a public health emergency of international concern](https://www.bmj.com/content/392/bmj-2026-089474)<!-- HN:47560592:end --><!-- HN:47506889:start -->
* [47506889](https://news.social-protocols.org/stats?id=47506889) #21 64 points 2 comments -> [Meta Partners with Arm to Develop New Class of Data Center Silicon](https://about.fb.com/news/2026/03/meta-partners-with-arm-to-develop-new-class-of-data-center-silicon/)<!-- HN:47506889:end --><!-- HN:47562294:start -->
* [47562294](https://news.social-protocols.org/stats?id=47562294) #16 7 points 0 comments -> [I built a better, human like memory, for Agents](https://github.com/emson/elfmem)<!-- HN:47562294:end --><!-- HN:47562589:start -->
* [47562589](https://news.social-protocols.org/stats?id=47562589) #11 29 points 15 comments -> [The Cloud: The dystopian book that changed Germany (2022)](https://www.bbc.com/culture/article/20221101-the-cloud-the-nuclear-novel-that-shaped-germany)<!-- HN:47562589:end --><!-- HN:47563325:start -->
* [47563325](https://news.social-protocols.org/stats?id=47563325) #8 18 points 20 comments -> [Show HN: 2.7KB Zig WASM – live globe showing executions at 300 CF edges](https://mcpaas.live/globe)<!-- HN:47563325:end --><!-- HN:47563172:start -->
* [47563172](https://news.social-protocols.org/stats?id=47563172) #25 -> [Patriot Crisis: US Embezzles Switzerland's Fighter Jet Funds](https://clashreport.com/defense/articles/patriot-crisis-us-seizes-switzerlands-fighter-jet-funds-07crgkch8ihr)<!-- HN:47563172:end --><!-- HN:47563921:start -->
* [47563921](https://news.social-protocols.org/stats?id=47563921) #13 51 points 10 comments -> [App that shows real-time lightning on Earth is showing bombings in Middle East](https://maps.blitzortung.org/)<!-- HN:47563921:end --><!-- HN:47566268:start -->
* [47566268](https://news.social-protocols.org/stats?id=47566268) #11 14 points 1 comments -> [Personal AI Development Environment](https://github.com/rbren/personal-ai-devbox)<!-- HN:47566268:end --><!-- HN:47566491:start -->
* [47566491](https://news.social-protocols.org/stats?id=47566491) #17 106 points 54 comments -> [The "Vibe Coding" Wall of Shame](https://crackr.dev/vibe-coding-failures)<!-- HN:47566491:end -->
#### **Monday, March 30, 2026**
<!-- HN:47568939:start -->
* [47568939](https://news.social-protocols.org/stats?id=47568939) #13 7 points 1 comments -> [AI Tokens Are Mana](https://www.proofofconcept.pub/p/ai-tokens-are-mana)<!-- HN:47568939:end --><!-- HN:47569290:start -->
* [47569290](https://news.social-protocols.org/stats?id=47569290) #7 14 points 14 comments -> [Something unexpected: Sunbathers live longer](https://www.health.harvard.edu/blog/heres-something-unexpected-sunbathers-live-longer-201606069738)<!-- HN:47569290:end --><!-- HN:47569835:start -->
* [47569835](https://news.social-protocols.org/stats?id=47569835) #7 9 points 0 comments -> [Pretext](https://simonwillison.net/2026/Mar/29/pretext/)<!-- HN:47569835:end --><!-- HN:47571064:start -->
* [47571064](https://news.social-protocols.org/stats?id=47571064) #28 27 points 40 comments -> [AI and bots have officially taken over the internet](https://www.cnbc.com/2026/03/26/ai-bots-humans-internet.html)<!-- HN:47571064:end --><!-- HN:47572008:start -->
* [47572008](https://news.social-protocols.org/stats?id=47572008) #22 8 points 3 comments -> [Apple nailed AI by doing fucking nothing lol](https://xcancel.com/cryptopunk7213/status/2038351931589193953?s=20)<!-- HN:47572008:end --><!-- HN:47572611:start -->
* [47572611](https://news.social-protocols.org/stats?id=47572611) #7 -> [MCP is great, you're just using it wrong](https://techstackups.com/comparisons/mcp-is-solving-the-wrong-problem/)<!-- HN:47572611:end --><!-- HN:47573205:start -->
* [47573205](https://news.social-protocols.org/stats?id=47573205) #26 33 points 1 comments -> [Spain closes airspace to aircraft involved in Iran war](https://english.elpais.com/international/2026-03-30/spain-closes-airspace-to-aircraft-involved-in-iran-war-but-us-bases-are-being-used-in-other-ways.html)<!-- HN:47573205:end --><!-- HN:47574045:start -->
* [47574045](https://news.social-protocols.org/stats?id=47574045) #4 15 points 2 comments -> [Show HN: Phantom – Open-source AI agent on its own VM that rewrites its config](https://github.com/ghostwright/phantom)<!-- HN:47574045:end --><!-- HN:47574547:start -->
* [47574547](https://news.social-protocols.org/stats?id=47574547) #16 9 points 2 comments -> [Pharma is dosing drugs wrong – the quantum tunneling correction nobody is using](https://sectio-aurea-q.github.io/pharma-dosing-error.html)<!-- HN:47574547:end -->