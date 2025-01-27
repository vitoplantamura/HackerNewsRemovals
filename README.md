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

#### **Tuesday, January 21, 2025**
<!-- HN:42773311:start -->
* [42773311](https://news.social-protocols.org/stats?id=42773311) #5 98 points 39 comments -> [Matt Mullenweg, Automattic's CEO, Seems Bound and Determined to Wreck WordPress](https://digitalcxo.com/article/matt-mullenweg-automattics-ceo-seems-bound-and-determined-to-wreck-wordpress/)<!-- HN:42773311:end --><!-- HN:42775545:start -->
* [42775545](https://news.social-protocols.org/stats?id=42775545) #5 113 points 103 comments -> [It sure looks like Meta stole a lot of books to build its AI](https://lithub.com/it-sure-looks-like-meta-stole-a-lot-of-books-to-build-its-ai/)<!-- HN:42775545:end --><!-- HN:42776131:start -->
* [42776131](https://news.social-protocols.org/stats?id=42776131) #22 9 points 4 comments -> [Protecting the Meaning and Value of American Citizenship](https://www.whitehouse.gov/presidential-actions/2025/01/protecting-the-meaning-and-value-of-american-citizenship/)<!-- HN:42776131:end --><!-- HN:42776364:start -->
* [42776364](https://news.social-protocols.org/stats?id=42776364) #9 9 points 1 comments -> [White House Executive Orders](https://www.whitehouse.gov/presidential-actions/)<!-- HN:42776364:end --><!-- HN:42776378:start -->
* [42776378](https://news.social-protocols.org/stats?id=42776378) #21 8 points 1 comments -> [Bambu denies their own documented restrictions [video]](https://www.youtube.com/watch?v=W6MybDJfmmY)<!-- HN:42776378:end --><!-- HN:42750976:start -->
* [42750976](https://news.social-protocols.org/stats?id=42750976) #20 9 points 1 comments -> [Rolls-Royce Merlin alternative uses](https://en.wikipedia.org/wiki/Rolls-Royce_Merlin_alternative_uses)<!-- HN:42750976:end --><!-- HN:42778045:start -->
* [42778045](https://news.social-protocols.org/stats?id=42778045) #20 9 points 0 comments -> [Meta making users automatically follow Trump and Vance on Facebook](https://timfullerton.substack.com/p/something-weird-is-going-on-with)<!-- HN:42778045:end --><!-- HN:42777938:start -->
* [42777938](https://news.social-protocols.org/stats?id=42777938) #13 77 points 29 comments -> [Meta Censoring '#Democrat' on Instagram](https://mstdn.chrisalemany.ca/@chris/113864600222476627)<!-- HN:42777938:end --><!-- HN:42778075:start -->
* [42778075](https://news.social-protocols.org/stats?id=42778075) #15 10 points 0 comments -> [Ancient Celtic tribe had women at its social center](https://www.npr.org/2025/01/15/nx-s1-5258236/ancient-celtic-tribe-had-women-at-its-social-center)<!-- HN:42778075:end --><!-- HN:42777716:start -->
* [42777716](https://news.social-protocols.org/stats?id=42777716) #17 26 points 43 comments -> [X, Facebook, Instagram, and YouTube sign EU code to tackle hate speech](https://www.theverge.com/2025/1/20/24347876/x-facebook-instagram-youtube-eu-hate-speech-dsa-code)<!-- HN:42777716:end --><!-- HN:42778678:start -->
* [42778678](https://news.social-protocols.org/stats?id=42778678) #20 -> [Why is this "Elon is Naziscum" token hidden?](https://dexscreener.com/solana/5penx1oz7qxppifm4axvnpzzqjadebjnwzytfyirmoon)<!-- HN:42778678:end --><!-- HN:42778472:start -->
* [42778472](https://news.social-protocols.org/stats?id=42778472) #6 43 points 23 comments -> [Open Source Alternative to Vercel, Netlify and Heroku](https://dokploy.com)<!-- HN:42778472:end --><!-- HN:42778872:start -->
* [42778872](https://news.social-protocols.org/stats?id=42778872) #19 8 points 6 comments -> [The Gilded Age novel that helps explain our fascination with Luigi Mangione](https://theconversation.com/the-gilded-age-novel-that-helps-explain-our-fascination-with-luigi-mangione-246495)<!-- HN:42778872:end --><!-- HN:42777874:start -->
* [42777874](https://news.social-protocols.org/stats?id=42777874) #25 25 points 7 comments -> [The QUIC API OpenSSL will not provide (2021)](https://daniel.haxx.se/blog/2021/10/25/the-quic-api-openssl-will-not-provide/)<!-- HN:42777874:end --><!-- HN:42780144:start -->
* [42780144](https://news.social-protocols.org/stats?id=42780144) #16 4 points 0 comments -> [Microsoft Bing Now Hides Google Search Results](https://www.seroundtable.com/bing-hides-google-search-results-38770.html)<!-- HN:42780144:end --><!-- HN:42780074:start -->
* [42780074](https://news.social-protocols.org/stats?id=42780074) #22 4 points 0 comments -> [Promoting Beautiful Federal Civic Architecture](https://www.whitehouse.gov/presidential-actions/2025/01/promoting-beautiful-federal-civic-architecture/)<!-- HN:42780074:end --><!-- HN:42772983:start -->
* [42772983](https://news.social-protocols.org/stats?id=42772983) #26 209 points 72 comments -> [Official DeepSeek R1 Now on Ollama](https://ollama.com/library/deepseek-r1)<!-- HN:42772983:end --><!-- HN:42782168:start -->
* [42782168](https://news.social-protocols.org/stats?id=42782168) #27 7 points 4 comments -> [Show HN: Hold yourself accountable for gym visits with a $10 stake](https://www.gymbully.fit)<!-- HN:42782168:end -->
#### **Wednesday, January 22, 2025**<!-- HN:42789020:start -->
* [42789020](https://news.social-protocols.org/stats?id=42789020) #10 5 points 0 comments -> [The Arduous Luxembourg Visa Process](https://ravidwivedi.in/posts/luxembourg-visa-process/)<!-- HN:42789020:end --><!-- HN:42790729:start -->
* [42790729](https://news.social-protocols.org/stats?id=42790729) #3 65 points 28 comments -> [The Day Instagram Blocked Democracy](https://docpop.org/2025/01/the-day-instagram-blocked-democracy/)<!-- HN:42790729:end --><!-- HN:42791337:start -->
* [42791337](https://news.social-protocols.org/stats?id=42791337) #30 10 points 3 comments -> [FOSDEM '25 Protest](https://drewdevault.com/2025/01/20/2025-01-20-FOSDEM-protest.html)<!-- HN:42791337:end --><!-- HN:42790962:start -->
* [42790962](https://news.social-protocols.org/stats?id=42790962) #29 5 points 1 comments -> [Usenet is a worldwide distributed electronic bulletin board system](https://smfr.org/mtnw/docs/Usenet.html)<!-- HN:42790962:end --><!-- HN:42770351:start -->
* [42770351](https://news.social-protocols.org/stats?id=42770351) #13 13 points 7 comments -> [Calling Strangers Uncle and Auntie](https://solmaz.io/calling-strangers-uncle-and-auntie)<!-- HN:42770351:end --><!-- HN:42770341:start -->
* [42770341](https://news.social-protocols.org/stats?id=42770341) #23 47 points 32 comments -> [The testing pyramid is an outdated economic model](https://www.wiremock.io/post/rethinking-the-testing-pyramid)<!-- HN:42770341:end --><!-- HN:42783438:start -->
* [42783438](https://news.social-protocols.org/stats?id=42783438) #27 13 points 4 comments -> [Show HN: Fixa – an open source Python package for testing voice agents](https://github.com/fixadev/fixa)<!-- HN:42783438:end --><!-- HN:42793629:start -->
* [42793629](https://news.social-protocols.org/stats?id=42793629) #28 4 points 0 comments -> [Netflix price increase leaves fans furious](https://www.the-sun.com/money/13351174/netflix-price-increase/)<!-- HN:42793629:end --><!-- HN:42757076:start -->
* [42757076](https://news.social-protocols.org/stats?id=42757076) #11 21 points 7 comments -> [Examples of quick hash tables and dynamic arrays in C](https://nullprogram.com/blog/2025/01/19/)<!-- HN:42757076:end --><!-- HN:42797974:start -->
* [42797974](https://news.social-protocols.org/stats?id=42797974) #28 9 points 7 comments -> [The war over a private island in the San Francisco Bay](https://www.sfgate.com/local/article/battle-over-san-francisco-bay-private-island-20034048.php)<!-- HN:42797974:end -->
#### **Thursday, January 23, 2025**
<!-- HN:42799328:start -->
* [42799328](https://news.social-protocols.org/stats?id=42799328) #15 9 points 0 comments -> [I built an active community of trans people online](https://t4t.social)<!-- HN:42799328:end --><!-- HN:42799974:start -->
* [42799974](https://news.social-protocols.org/stats?id=42799974) #11 23 points 4 comments -> [Kidnapping of Ledger Co-Founder Sparks Major Investigation in France](https://www.leberry.fr/vierzon-18100/faits-divers/enlevement-de-l-un-des-cofondateurs-de-la-start-up-ledger-vaste-enquete-dans-le-cher_14629928/)<!-- HN:42799974:end --><!-- HN:42801839:start -->
* [42801839](https://news.social-protocols.org/stats?id=42801839) #11 30 points 40 comments -> [Jürgen Schmidhuber – Can All-Purpose Robots Fuel a Comeback?](https://people.idsia.ch/~juergen/GerJapUsaChiRobots.html)<!-- HN:42801839:end --><!-- HN:42803201:start -->
* [42803201](https://news.social-protocols.org/stats?id=42803201) #25 15 points 16 comments -> [Mass deportations would deliver a catastrophic blow to the U.S. Economy](https://www.jec.senate.gov/public/index.cfm/democrats/2024/12/mass-deportations-would-deliver-a-catastrophic-blow-to-the-u-s-economy)<!-- HN:42803201:end --><!-- HN:42803562:start -->
* [42803562](https://news.social-protocols.org/stats?id=42803562) #16 35 points 5 comments -> [Hackers exploit 16 zero-days on first day of Pwn2Own Automotive 2025](https://www.bleepingcomputer.com/news/security/hackers-exploit-16-zero-days-on-first-day-of-pwn2own-automotive-2025/)<!-- HN:42803562:end --><!-- HN:42803559:start -->
* [42803559](https://news.social-protocols.org/stats?id=42803559) #12 32 points 52 comments -> [Liberux: The Linux Phone You Have Been Waiting For](https://liberux.net/)<!-- HN:42803559:end --><!-- HN:42802842:start -->
* [42802842](https://news.social-protocols.org/stats?id=42802842) #8 29 points 40 comments -> [How to Inspect React Server Component Activity with Next.js and OpenTelemetry](https://www.dash0.com/blog/how-to-inspect-react-server-component-activity-with-next-js)<!-- HN:42802842:end --><!-- HN:42803483:start -->
* [42803483](https://news.social-protocols.org/stats?id=42803483) #17 5 points 1 comments -> [Lessons from building a small-scale AI application](https://www.thelis.org/blog/lessons-from-ai)<!-- HN:42803483:end --><!-- HN:42805324:start -->
* [42805324](https://news.social-protocols.org/stats?id=42805324) #4 9 points 0 comments -> [Replit, the Figma Replacement](https://nicbertino.com/blog/figma-replit/)<!-- HN:42805324:end --><!-- HN:42805585:start -->
* [42805585](https://news.social-protocols.org/stats?id=42805585) #6 4 points 1 comments -> [Space Ex High School Probe Designs (2024)](https://drive.google.com/file/d/1D3wniEdWS5uWQJffxnroHz2IjISezcCq/view?usp=sharing)<!-- HN:42805585:end --><!-- HN:42806390:start -->
* [42806390](https://news.social-protocols.org/stats?id=42806390) #29 10 points 2 comments -> [OpenAI Computer-Using Agent](https://openai.com/index/computer-using-agent/)<!-- HN:42806390:end --><!-- HN:42805546:start -->
* [42805546](https://news.social-protocols.org/stats?id=42805546) #18 6 points 1 comments -> [Humanity's Last Exam](https://lastexam.ai)<!-- HN:42805546:end --><!-- HN:42807043:start -->
* [42807043](https://news.social-protocols.org/stats?id=42807043) #21 39 points 12 comments -> [Finnish Wartime Photograph Archive (1939-1945)](http://sa-kuva.fi/neo?tem=webneoeng#)<!-- HN:42807043:end -->
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
* [42832360](https://news.social-protocols.org/stats?id=42832360) #15 6 points 0 comments -> [DeepSeek v3 and r1 free unlimited](https://www.blackbox.ai)<!-- HN:42832360:end --><!-- HN:42830923:start -->
* [42830923](https://news.social-protocols.org/stats?id=42830923) #10 32 points 40 comments -> [Are Americans' perceptions of the economy and crime broken?](https://www.niemanlab.org/2024/11/are-americans-perceptions-of-the-economy-and-crime-broken/)<!-- HN:42830923:end --><!-- HN:42831384:start -->
* [42831384](https://news.social-protocols.org/stats?id=42831384) #11 16 points 14 comments -> [Two F-14 fighter jets were diverted to USS Midway](https://theaviationgeekclub.com/that-time-two-f-14-fighter-jets-were-diverted-to-uss-midway-the-carriers-flight-deck-and-infrastructure-could-not-support-regular-operation-of-the-large-heavy-tomcat/)<!-- HN:42831384:end --><!-- HN:42832838:start -->
* [42832838](https://news.social-protocols.org/stats?id=42832838) #16 91 points 2 comments -> [Qwen2.5-7B-Instruct-1M and Qwen2.5-14B-Instruct-1M](https://simonwillison.net/2025/Jan/26/qwen25-1m/)<!-- HN:42832838:end --><!-- HN:42832132:start -->
* [42832132](https://news.social-protocols.org/stats?id=42832132) #28 46 points 50 comments -> [Austin rents have fallen for nearly two years](https://www.texastribune.org/2025/01/22/austin-texas-rents-falling/)<!-- HN:42832132:end --><!-- HN:42834911:start -->
* [42834911](https://news.social-protocols.org/stats?id=42834911) #1 102 points 12 comments -> [Mark Zuckerberg: This Man Is a Coward](https://www.theindex.media/this-man-is-a-coward/)<!-- HN:42834911:end -->
#### **Monday, January 27, 2025**
<!-- HN:42835932:start -->
* [42835932](https://news.social-protocols.org/stats?id=42835932) #3 9 points 2 comments -> [Eye Contact](https://kosayjabre.com/blog/eye_contact.html)<!-- HN:42835932:end --><!-- HN:42836675:start -->
* [42836675](https://news.social-protocols.org/stats?id=42836675) #6 30 points 15 comments -> [The race for "AI Supremacy" is over – at least for now](https://garymarcus.substack.com/p/the-race-for-ai-supremacy-is-over)<!-- HN:42836675:end --><!-- HN:42836934:start -->
* [42836934](https://news.social-protocols.org/stats?id=42836934) #6 6 points 3 comments -> [Show HN: Voice Cloning and Multilingual TTS in One Click (Windows)](https://github.com/abus-aikorea/voice-pro/blob/main/docs/README.eng.md)<!-- HN:42836934:end --><!-- HN:42838720:start -->
* [42838720](https://news.social-protocols.org/stats?id=42838720) #17 17 points 0 comments -> [Tim Cook Is Failing Us](https://joe-steel.com/2025-01-25-Tim-Cook-Is-Failing-Us.html)<!-- HN:42838720:end --><!-- HN:42839502:start -->
* [42839502](https://news.social-protocols.org/stats?id=42839502) #1 31 points 6 comments -> [Facebook Ban on Linux](https://distrowatch.com/weekly-mobile.php?issue=20250127#sitenews)<!-- HN:42839502:end --><!-- HN:42831927:start -->
* [42831927](https://news.social-protocols.org/stats?id=42831927) #16 142 points 18 comments -> [OpenJazz is a free, open-source version of the classic Jazz Jackrabbit games](https://alister.eu/jazz/oj/about.php)<!-- HN:42831927:end --><!-- HN:42813683:start -->
* [42813683](https://news.social-protocols.org/stats?id=42813683) #21 53 points 3 comments -> [Wikenigma – An Encyclopedia of Unknowns](https://wikenigma.org.uk/)<!-- HN:42813683:end --><!-- HN:42838779:start -->
* [42838779](https://news.social-protocols.org/stats?id=42838779) #23 4 points 0 comments -> [Announcing support for DeepSeek-R1 in our IDE plugin, self-hosted by Qodo](https://www.qodo.ai/blog/qodo-gen-adds-self-hosted-support-for-deepseek-r1/)<!-- HN:42838779:end --><!-- HN:42806413:start -->
* [42806413](https://news.social-protocols.org/stats?id=42806413) #12 36 points 4 comments -> [Why Liquidity Matters](https://www.hiive.com/market-reports/why-liquidity-matters-motivating-tech-talent)<!-- HN:42806413:end --><!-- HN:42839880:start -->
* [42839880](https://news.social-protocols.org/stats?id=42839880) #25 3 points 0 comments -> [Verifying FPGA using Free OS tools and frameworks](https://www.hackster.io/adam-taylor/verifying-vhdl-da9a93)<!-- HN:42839880:end -->