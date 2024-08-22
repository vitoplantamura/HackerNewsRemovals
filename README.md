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

#### **Friday, August 16, 2024**
<!-- HN:41232682:start -->
* [41232682](https://news.social-protocols.org/stats?id=41232682) #19 21 points 10 comments -> [Take selfies with public traffic cameras](https://trafficcamphotobooth.com/)<!-- HN:41232682:end --><!-- HN:41262878:start -->
* [41262878](https://news.social-protocols.org/stats?id=41262878) #11 11 points 2 comments -> [Cartoon Network's Website Was Deleted. That Should Scare You All](https://slate.com/technology/2024/08/david-zaslav-warner-bros-discovery-culture-deleting-movies-tv-shows.html)<!-- HN:41262878:end --><!-- HN:41263616:start -->
* [41263616](https://news.social-protocols.org/stats?id=41263616) #15 27 points 26 comments -> [Cryptominers made $100k from mining at an Airbnb for three weeks](https://www.tomshardware.com/tech-industry/cryptomining/cryptominers-made-100000-dollars-from-mining-at-an-airbnb-for-three-weeks)<!-- HN:41263616:end --><!-- HN:41263656:start -->
* [41263656](https://news.social-protocols.org/stats?id=41263656) #8 3 points 2 comments -> [Show HN: Free Online Car Logo Information Website](https://carlogohub.com)<!-- HN:41263656:end --><!-- HN:41265318:start -->
* [41265318](https://news.social-protocols.org/stats?id=41265318) #18 3 points 0 comments -> [Running Go HTTP server on Teensy 4.1](https://embeddedgo.github.io/2024/01/01/go_http_server_on_teensy4.html)<!-- HN:41265318:end --><!-- HN:41264418:start -->
* [41264418](https://news.social-protocols.org/stats?id=41264418) #17 4 points 0 comments -> [A comparison of 22 Arenas in Rust](https://donsz.nl/blog/arenas/)<!-- HN:41264418:end --><!-- HN:41265525:start -->
* [41265525](https://news.social-protocols.org/stats?id=41265525) #19 7 points 0 comments -> [Carles Puigdemont: How I pulled off my daring escape from Spain](https://www.politico.eu/article/carles-puigdemont-catalonia-independence-spain-operation-arc-de-triomf-escape-exile/)<!-- HN:41265525:end --><!-- HN:41265461:start -->
* [41265461](https://news.social-protocols.org/stats?id=41265461) #7 25 points 17 comments -> [Is this the slow decline of the Apple "cult"?](https://birchtree.me/blog/is-this-the-slow-decline-of-the-apple-cult/)<!-- HN:41265461:end --><!-- HN:41265396:start -->
* [41265396](https://news.social-protocols.org/stats?id=41265396) #1 12 points 4 comments -> [The Tenth Man Rule: How to Take Devil's Advocacy to a New Level](https://themindcollection.com/the-tenth-man-rule-devils-advocacy/)<!-- HN:41265396:end --><!-- HN:41265562:start -->
* [41265562](https://news.social-protocols.org/stats?id=41265562) #2 8 points 3 comments -> [The Day GitHub Almost CrowdStriked Us All (Again)](https://blog.codeminer42.com/the-day-github-almost-crowdstriked-us-all-again/)<!-- HN:41265562:end --><!-- HN:41264844:start -->
* [41264844](https://news.social-protocols.org/stats?id=41264844) #26 46 points 42 comments -> [Microsoft is finally removing the FAT32 partition size limit in Windows 11](https://www.theverge.com/2024/8/16/24221635/microsoft-fat32-partition-size-limit-windows-11)<!-- HN:41264844:end --><!-- HN:41261107:start -->
* [41261107](https://news.social-protocols.org/stats?id=41261107) #29 66 points 37 comments -> [Reticulum Is Unstoppable Networks for the People](https://reticulum.network/)<!-- HN:41261107:end --><!-- HN:41262244:start -->
* [41262244](https://news.social-protocols.org/stats?id=41262244) #19 70 points 24 comments -> [SREBench Competition](https://sreben.ch/)<!-- HN:41262244:end --><!-- HN:41265397:start -->
* [41265397](https://news.social-protocols.org/stats?id=41265397) #22 11 points 1 comments -> [FusionAuth 1.52.0 – Passkeys for Everyone](https://fusionauth.io/blog/announcing-fusionauth-1-52)<!-- HN:41265397:end --><!-- HN:41222738:start -->
* [41222738](https://news.social-protocols.org/stats?id=41222738) #26 102 points 65 comments -> [How does it feel to test a compiler?](https://medium.com/@zakharenko/how-does-it-feel-to-test-a-compiler-fa1ff5d86065)<!-- HN:41222738:end --><!-- HN:41268221:start -->
* [41268221](https://news.social-protocols.org/stats?id=41268221) #21 11 points 1 comments -> [Joe Rogan Experience #2190 – Peter Thiel [video]](https://www.youtube.com/watch?v=klRb0_BAX9g)<!-- HN:41268221:end --><!-- HN:41268104:start -->
* [41268104](https://news.social-protocols.org/stats?id=41268104) #20 22 points 42 comments -> [Subway calls 'emergency' meeting with franchisees as sales plummet](https://nypost.com/2024/08/14/business/subway-calls-emergency-meeting-with-franchisees-as-sales-plummet-sources/)<!-- HN:41268104:end --><!-- HN:41265930:start -->
* [41265930](https://news.social-protocols.org/stats?id=41265930) #17 21 points 42 comments -> [America prepares for a new nuclear-arms race](https://www.economist.com/united-states/2024/08/12/america-prepares-for-a-new-nuclear-arms-race)<!-- HN:41265930:end --><!-- HN:41269640:start -->
* [41269640](https://news.social-protocols.org/stats?id=41269640) #10 9 points 0 comments -> [Uncensored.com: Try 100% Uncensored AI](https://uncensored.com/)<!-- HN:41269640:end --><!-- HN:41269474:start -->
* [41269474](https://news.social-protocols.org/stats?id=41269474) #26 21 points 2 comments -> [First Look Inside Blue Origin's New Glenn Factory with Jeff Bezos [video]](https://www.youtube.com/watch?v=rsuqSn7ifpU)<!-- HN:41269474:end --><!-- HN:41269137:start -->
* [41269137](https://news.social-protocols.org/stats?id=41269137) #25 21 points 7 comments -> [Windows 11 vs. Ubuntu 24.04 Linux Performance For The AMD Ryzen 9 9590X](https://www.phoronix.com/review/ryzen-9950x-windows11-ubuntu)<!-- HN:41269137:end --><!-- HN:41268818:start -->
* [41268818](https://news.social-protocols.org/stats?id=41268818) #27 43 points 15 comments -> [Forbes 30 under 30 inductee charged with fraud in the same week](https://www.cbsnews.com/chicago/news/chicago-rapper-g-herbo-5-others-charged-with-using-stolen-credit-info-for-flights-vacations-and-designer-puppies/)<!-- HN:41268818:end --><!-- HN:41270536:start -->
* [41270536](https://news.social-protocols.org/stats?id=41270536) #28 9 points 2 comments -> [Dubai Court Declares Crypto Salary Legal](https://www.econotimes.com/Dubai-Court-Declares-Crypto-Salary-Legal-Ushering-in-a-Revolutionary-Shift-for-UAE-Workers-1684321)<!-- HN:41270536:end --><!-- HN:41241373:start -->
* [41241373](https://news.social-protocols.org/stats?id=41241373) #21 27 points 40 comments -> [Nitric Is Terraform for Developers](https://medium.com/@rsiva_nitric/nitric-is-terraform-for-developers-9cd6cd7f0e76)<!-- HN:41241373:end -->
#### **Saturday, August 17, 2024**
<!-- HN:41271223:start -->
* [41271223](https://news.social-protocols.org/stats?id=41271223) #4 6 points 0 comments -> [Flux better than Stable Diffusion](https://github.com/black-forest-labs/flux)<!-- HN:41271223:end --><!-- HN:41270277:start -->
* [41270277](https://news.social-protocols.org/stats?id=41270277) #27 4 points 0 comments -> [Should I Close Source My Company? Replying to Supabase](https://orth.uk/close-source/)<!-- HN:41270277:end --><!-- HN:41270245:start -->
* [41270245](https://news.social-protocols.org/stats?id=41270245) #27 6 points 1 comments -> [Why your website should be under 14kB in size](https://endtimes.dev/why-your-website-should-be-under-14kb-in-size/)<!-- HN:41270245:end --><!-- HN:41271458:start -->
* [41271458](https://news.social-protocols.org/stats?id=41271458) #12 11 points 2 comments -> [Show HN: an AI copilot for Next.js developers](https://useglass.ai)<!-- HN:41271458:end --><!-- HN:41237811:start -->
* [41237811](https://news.social-protocols.org/stats?id=41237811) #29 20 points 30 comments -> [Do Art Scenes Lead to Gentrification? (2018)](https://www.bloomberg.com/news/articles/2018-03-22/artists-aren-t-to-blame-for-gentrification-after-all)<!-- HN:41237811:end --><!-- HN:41247322:start -->
* [41247322](https://news.social-protocols.org/stats?id=41247322) #7 9 points 0 comments -> [The use of mare's milk for yogurt ice cream and synbiotic ice cream production](https://journals.plos.org/plosone/article?id=10.1371/journal.pone.0304692)<!-- HN:41247322:end --><!-- HN:41273148:start -->
* [41273148](https://news.social-protocols.org/stats?id=41273148) #13 37 points 12 comments -> [Lilygo T-Deck Plus is a $70 handheld with GPS, LoRa, and a BlackBerry keyboard](https://liliputing.com/lilygo-t-deck-plus-is-a-70-handheld-with-gps-lora-and-a-blackberry-keyboard/)<!-- HN:41273148:end --><!-- HN:41274098:start -->
* [41274098](https://news.social-protocols.org/stats?id=41274098) #23 17 points 8 comments -> [You Can Gaslight Yourself into Loving Someone](https://gist.github.com/Wilsontomass/de0d9b4d331eda0880c601c8890c1143)<!-- HN:41274098:end --><!-- HN:41276494:start -->
* [41276494](https://news.social-protocols.org/stats?id=41276494) #30 4 points 0 comments -> [Germany records 1.4 GW of new solar in July](https://www.pv-magazine.com/2024/08/16/germany-records-1-4-gw-of-new-solar-in-july/)<!-- HN:41276494:end --><!-- HN:41275695:start -->
* [41275695](https://news.social-protocols.org/stats?id=41275695) #30 37 points 40 comments -> [AI stole my job and my work, and the boss didn't know – or care](https://www.theregister.com/2024/08/15/robot_took_my_job/)<!-- HN:41275695:end --><!-- HN:41275114:start -->
* [41275114](https://news.social-protocols.org/stats?id=41275114) #20 40 points 6 comments -> [Running NixOS on Proxmox LXC](https://taoofmac.com/space/blog/2024/08/17/1530)<!-- HN:41275114:end --><!-- HN:41275766:start -->
* [41275766](https://news.social-protocols.org/stats?id=41275766) #22 25 points 13 comments -> [The Living Computer Museum auction listing](https://onlineonly.christies.com/s/firsts-history-computing-paul-g-allen-collection/lots/3726)<!-- HN:41275766:end --><!-- HN:41277040:start -->
* [41277040](https://news.social-protocols.org/stats?id=41277040) #9 35 points 9 comments -> [Sergey Brin: "Irate Call from Steve Jobs" (2005)](https://twitter.com/TechEmails/status/1610099684345024512)<!-- HN:41277040:end --><!-- HN:41277058:start -->
* [41277058](https://news.social-protocols.org/stats?id=41277058) #10 90 points 37 comments -> [Releasing everyone's SSN and the hacks used to acquire them](https://github.com/PatrickJS/everyone-ssn-usa)<!-- HN:41277058:end --><!-- HN:41277593:start -->
* [41277593](https://news.social-protocols.org/stats?id=41277593) #5 51 points 19 comments -> [AI Seinfeld was the peak of AI-generated content. It will never happen again](https://minimaxir.com/2024/08/ai-seinfeld/)<!-- HN:41277593:end --><!-- HN:41278226:start -->
* [41278226](https://news.social-protocols.org/stats?id=41278226) #4 7 points 0 comments -> [Eric Schmidt's AI prophecy: The next two years will shock you](https://www.exponentialview.co/p/eric-schmidts-ai-prophecy)<!-- HN:41278226:end -->
#### **Sunday, August 18, 2024**
<!-- HN:41261481:start -->
* [41261481](https://news.social-protocols.org/stats?id=41261481) #17 18 points 5 comments -> [Symmetric Power Transformers](https://manifestai.com/articles/symmetric-power-transformers/)<!-- HN:41261481:end --><!-- HN:41281259:start -->
* [41281259](https://news.social-protocols.org/stats?id=41281259) #26 6 points 1 comments -> [Male UK university students are 'less macho' when sharing flats with women](https://www.theguardian.com/education/article/2024/aug/18/male-uk-university-students-are-less-macho-when-sharing-flats-with-women)<!-- HN:41281259:end --><!-- HN:41237204:start -->
* [41237204](https://news.social-protocols.org/stats?id=41237204) #13 46 points 7 comments -> [SWE-Bench Verified](https://openai.com/index/introducing-swe-bench-verified/)<!-- HN:41237204:end --><!-- HN:41242095:start -->
* [41242095](https://news.social-protocols.org/stats?id=41242095) #21 95 points 6 comments -> [Basic MetaProgramming in Zig](https://www.openmymind.net/Basic-MetaProgramming-in-Zig/)<!-- HN:41242095:end --><!-- HN:41281454:start -->
* [41281454](https://news.social-protocols.org/stats?id=41281454) #16 3 points 0 comments -> [Compiling Tetris from 1992 on OpenVMS x86 in 2024](https://raymii.org/s/blog/Tetris_from_1992_on_OpenVMS_x86_in_2024.html)<!-- HN:41281454:end --><!-- HN:41244493:start -->
* [41244493](https://news.social-protocols.org/stats?id=41244493) #18 6 points 7 comments -> [Speedo-Shaped Skillset](https://www.scottantipa.com/speedo-shaped-skillset)<!-- HN:41244493:end --><!-- HN:41282514:start -->
* [41282514](https://news.social-protocols.org/stats?id=41282514) #28 10 points 2 comments -> [Telegram Deletes User Groups Without Warning: A Concerning Issue](https://twitter.com/edisonjwa/status/1825142648933625913)<!-- HN:41282514:end --><!-- HN:41283010:start -->
* [41283010](https://news.social-protocols.org/stats?id=41283010) #10 26 points 13 comments -> ["Us vs. Them" language shapes the Apple ecosystem narrative](https://twitter.com/xroissance/status/1825068918509072852)<!-- HN:41283010:end --><!-- HN:41283129:start -->
* [41283129](https://news.social-protocols.org/stats?id=41283129) #15 28 points 43 comments -> [Microsoft begins cracking down on people dodging Windows 11 system requirements](https://www.xda-developers.com/microsoft-cracking-down-dodging-windows-11-system-requirements/)<!-- HN:41283129:end --><!-- HN:41283900:start -->
* [41283900](https://news.social-protocols.org/stats?id=41283900) #15 13 points 3 comments -> [Moonlight](https://moonlight-stream.org)<!-- HN:41283900:end --><!-- HN:41282981:start -->
* [41282981](https://news.social-protocols.org/stats?id=41282981) #19 17 points 9 comments -> [Show HN: Proxmox VE Helper Scripts: Make managing your homelab a breeze](https://proxmox-helper-scripts.vercel.app)<!-- HN:41282981:end --><!-- HN:41284604:start -->
* [41284604](https://news.social-protocols.org/stats?id=41284604) #6 11 points 12 comments -> [Stop Using Git Ignore](https://eddiejaoude.substack.com/p/you-must-use-your-global-git-ignore)<!-- HN:41284604:end --><!-- HN:41284549:start -->
* [41284549](https://news.social-protocols.org/stats?id=41284549) #25 97 points 68 comments -> [Apple might be implementing a VPN censorship order in Brazil](https://status.proton.me/incidents/0frlp8crn7kx)<!-- HN:41284549:end -->
#### **Monday, August 19, 2024**
<!-- HN:41247991:start -->
* [41247991](https://news.social-protocols.org/stats?id=41247991) #6 31 points 6 comments -> [Animate.css: Seamless CSS Animations Across All Browsers](https://github.com/animate-css/animate.css)<!-- HN:41247991:end --><!-- HN:41287014:start -->
* [41287014](https://news.social-protocols.org/stats?id=41287014) #17 150 points 90 comments -> [Eric Schmidt deleted Stanford interview](https://www.youtube.com/watch?v=3f6XM6_7pUE)<!-- HN:41287014:end --><!-- HN:41288958:start -->
* [41288958](https://news.social-protocols.org/stats?id=41288958) #27 4 points 0 comments -> [2GB Raspberry Pi 5 on sale now at $50](https://www.raspberrypi.com/news/2gb-raspberry-pi-5-on-sale-now-at-50/)<!-- HN:41288958:end --><!-- HN:41288510:start -->
* [41288510](https://news.social-protocols.org/stats?id=41288510) #4 4 points 1 comments -> [The Guide to Build a Profitable Flippa Clone App](https://www.trioangle.com/blog/build-flippa-clone-app/)<!-- HN:41288510:end --><!-- HN:41283367:start -->
* [41283367](https://news.social-protocols.org/stats?id=41283367) #24 96 points 46 comments -> [Bold Edit: An editor written by power users](https://bold-edit.com)<!-- HN:41283367:end --><!-- HN:41289096:start -->
* [41289096](https://news.social-protocols.org/stats?id=41289096) #21 6 points 1 comments -> [What comes after the AI crash?](https://disconnect.blog/what-comes-after-the-ai-crash/)<!-- HN:41289096:end --><!-- HN:41289177:start -->
* [41289177](https://news.social-protocols.org/stats?id=41289177) #27 4 points 0 comments -> [Amazon's delivery drones are so loud they are like a 'giant hive of bees'](https://www.businessinsider.com/amazon-prime-air-delivery-drones-too-loud-texas-2024-8)<!-- HN:41289177:end --><!-- HN:41289384:start -->
* [41289384](https://news.social-protocols.org/stats?id=41289384) #12 14 points 2 comments -> [Blaming Agile for software stagnation puts the wrong villain in the wrong play](https://www.theregister.com/2024/08/19/sorry_moxie_blaming_agile_for/)<!-- HN:41289384:end --><!-- HN:41288459:start -->
* [41288459](https://news.social-protocols.org/stats?id=41288459) #16 6 points 0 comments -> [An open source Claude Artifacts – generate small apps with one prompt](https://github.com/Nutlope/llamacoder)<!-- HN:41288459:end --><!-- HN:41290394:start -->
* [41290394](https://news.social-protocols.org/stats?id=41290394) #4 3 points 0 comments -> [Infiltrating the Far Right](https://www.newyorker.com/magazine/2024/08/26/infiltrating-the-far-right)<!-- HN:41290394:end --><!-- HN:41290648:start -->
* [41290648](https://news.social-protocols.org/stats?id=41290648) #15 3 points 0 comments -> [Mark Simmons' ship joke named funniest of Edinburgh fringe](https://www.theguardian.com/stage/article/2024/aug/19/mark-simmons-ship-joke-named-funniest-of-edinburgh-fringe)<!-- HN:41290648:end --><!-- HN:41261661:start -->
* [41261661](https://news.social-protocols.org/stats?id=41261661) #22 5 points 0 comments -> [Real-Time Mouse Pointers](https://www.canva.dev/blog/engineering/realtime-mouse-pointers/)<!-- HN:41261661:end --><!-- HN:41290874:start -->
* [41290874](https://news.social-protocols.org/stats?id=41290874) #18 8 points 0 comments -> [North Norwegian port welcomes controversial Chinese shipping giant to the Arctic](https://www.nrk.no/tromsogfinnmark/north-norwegian-port-manager-welcomes-controversial-chinese-shipping-giant-to-the-arctic-1.17005205)<!-- HN:41290874:end --><!-- HN:41291249:start -->
* [41291249](https://news.social-protocols.org/stats?id=41291249) #14 3 points 0 comments -> [Mike Lynch among missing after yacht sinks off Sicily](https://www.ft.com/content/62573c65-6504-4b6b-8031-266a6a8b3830)<!-- HN:41291249:end --><!-- HN:41291234:start -->
* [41291234](https://news.social-protocols.org/stats?id=41291234) #23 -> [Hard-pressed Kenyan drivers defy Uber's algorithm, set their own fares](https://www.reuters.com/business/autos-transportation/hard-pressed-kenyan-drivers-defy-ubers-algorithm-set-their-own-fares-2024-08-19/)<!-- HN:41291234:end --><!-- HN:41256498:start -->
* [41256498](https://news.social-protocols.org/stats?id=41256498) #23 15 points 4 comments -> [Show HN: Fast Incremental Plaintext Searcher](https://ksylvestre.itch.io/mightygrep)<!-- HN:41256498:end --><!-- HN:41291965:start -->
* [41291965](https://news.social-protocols.org/stats?id=41291965) #20 7 points 1 comments -> [Scenes from San Francisco's Unhoused Encampment Sweeps](https://www.kqed.org/news/12000606/scenes-from-san-franciscos-unhoused-encampment-sweeps)<!-- HN:41291965:end --><!-- HN:41291360:start -->
* [41291360](https://news.social-protocols.org/stats?id=41291360) #18 11 points 3 comments -> [Demand for seed-oil-free foods is growing](https://www.foodnavigator.com/Article/2024/07/26/demand-for-seed-oil-free-foods-is-growing)<!-- HN:41291360:end --><!-- HN:41293505:start -->
* [41293505](https://news.social-protocols.org/stats?id=41293505) #12 48 points 10 comments -> [Everyone's Life Is Weird](https://www.avabear.xyz/p/actually-everyones-life-is-weird)<!-- HN:41293505:end --><!-- HN:41294075:start -->
* [41294075](https://news.social-protocols.org/stats?id=41294075) #7 11 points 1 comments -> [How to Make Wealth as a Startup Founder](https://blog.nishantsoni.com/p/how-to-think-about-liquidity-as-a)<!-- HN:41294075:end --><!-- HN:41294579:start -->
* [41294579](https://news.social-protocols.org/stats?id=41294579) #15 17 points 9 comments -> [Millennials Are Becoming Boomers](https://awealthofcommonsense.com/2024/08/millennials-are-becoming-boomers/)<!-- HN:41294579:end -->
#### **Tuesday, August 20, 2024**
<!-- HN:41295206:start -->
* [41295206](https://news.social-protocols.org/stats?id=41295206) #26 5 points 2 comments -> [2024 Olympics game U.S. medals by colleges](https://www.chart2char.com/expo/post/?channelHandle=sportsmeter&post=2024%20Olympic%20Game%20U.S.%20Medalists)<!-- HN:41295206:end --><!-- HN:41296366:start -->
* [41296366](https://news.social-protocols.org/stats?id=41296366) #6 10 points 10 comments -> [Show HN: I Made an AI Song Generator](https://song.do)<!-- HN:41296366:end --><!-- HN:41298206:start -->
* [41298206](https://news.social-protocols.org/stats?id=41298206) #8 9 points 0 comments -> [Trump's A.I. Stunt to Win Taylor Swift's Endorsement Backfires](https://newrepublic.com/post/184995/trump-ai-taylor-swift-endorsement)<!-- HN:41298206:end --><!-- HN:41253198:start -->
* [41253198](https://news.social-protocols.org/stats?id=41253198) #24 16 points 7 comments -> [Want to Win a Bike Race? Hack Your Rival's Wireless Shifters](https://www.wired.com/story/shimano-wireless-bicycle-shifter-jamming-replay-attacks/)<!-- HN:41253198:end --><!-- HN:41298933:start -->
* [41298933](https://news.social-protocols.org/stats?id=41298933) #25 3 points 0 comments -> [Alpine: A Lightweight JavaScript Framework for Minimalist Front End Development](https://github.com/alpinejs/alpine)<!-- HN:41298933:end --><!-- HN:41299407:start -->
* [41299407](https://news.social-protocols.org/stats?id=41299407) #22 9 points 0 comments -> [Tech donor network co-founded by JD Vance seeks to push America to the right](https://www.reuters.com/world/us/tech-donor-network-co-founded-by-jd-vance-seeks-push-america-right-2024-08-20/)<!-- HN:41299407:end --><!-- HN:41299398:start -->
* [41299398](https://news.social-protocols.org/stats?id=41299398) #22 11 points 1 comments -> [Astrophysicists May Have Found the Source of Mysterious Wow Signal](https://gizmodo.com/astrophysicists-may-have-found-the-source-of-mysterious-wow-signal-2000487953)<!-- HN:41299398:end --><!-- HN:41300448:start -->
* [41300448](https://news.social-protocols.org/stats?id=41300448) #27 4 points 0 comments -> [Palmdale UFO Scare Leads to Revelations About Mystery Drones over Plant 42](https://www.twz.com/air/palmdale-ufo-scare-leads-to-revelations-about-mystery-drone-incursions-over-secretive-plant-42)<!-- HN:41300448:end --><!-- HN:41300685:start -->
* [41300685](https://news.social-protocols.org/stats?id=41300685) #3 16 points 3 comments -> [Stripe Built One of Silicon Valley's Best Engineering Teams (2013)](https://review.firstround.com/how-stripe-built-one-of-silicon-valleys-best-engineering-teams/)<!-- HN:41300685:end --><!-- HN:41299954:start -->
* [41299954](https://news.social-protocols.org/stats?id=41299954) #12 28 points 12 comments -> [World’s oldest person, Maria Branyas Morera, dies aged 117](https://www.theguardian.com/world/article/2024/aug/20/worlds-oldest-person-maria-branyas-morera-dies-aged-117)<!-- HN:41299954:end --><!-- HN:41298819:start -->
* [41298819](https://news.social-protocols.org/stats?id=41298819) #22 13 points 0 comments -> [My Auschwitz vacation](https://harpers.org/archive/2024/09/my-auschwitz-vacation-tanya-gold-tourism/)<!-- HN:41298819:end --><!-- HN:41298789:start -->
* [41298789](https://news.social-protocols.org/stats?id=41298789) #29 27 points 30 comments -> [Show HN: Mailik – Effortlessly Receive Form Responses in Your Inbox](https://mailik.dev/)<!-- HN:41298789:end --><!-- HN:41300479:start -->
* [41300479](https://news.social-protocols.org/stats?id=41300479) #12 5 points 2 comments -> [Microsoft employee proposes user delete almost all of their registry keys](https://login.microsoftonline.com/common/oauth2/v2.0/authorize?client_id=a81d90ac-aa75-4cf8-b14c-58bf348528fe&redirect_uri=https%3A%2F%2Fanswers.microsoft.com&response_type=code%20id_token&scope=openid%20profile&state=OpenIdConnect.AuthenticationProperties%3DQiIAifWNykKJgje7qloUYMMYncc72QMiW9C41qfwbqzytBX0c1XCu-xFx6Fh2YQDrjEHZ5AP5DQ12OTD_nwB0a7ycpqoj7eTXK2GuwGLGpDCOWn56TYi6tmPv3r_9k7oG7gMUhuYqwb7Z2jqrrQG2CA3pXqJeVlQMfv9xVSISKRUPiofizFaHexjBiHb0UHgz0OiLqpEeTgBgY6QlTRI06ZTI9Tpauz7I5zEKNX0LFucctTxnds13euHGmheHaWrmLjnxbNubBObKyvdiZHZl1TqjF_lzAZdmr41Y_QV_oIVAmhGXHLX54nt0K6NiHorbGEgXQ5QwXxfLvvIejc9SBv5gutO0G67tO5tx633TMHUk5WfVBoPlQf2acBrVEdk&response_mode=form_post&nonce=638597613951573686.YzY4ZTc3NjEtOTdhZC00MGM4LWJiMjQtMjE3MWMwYTQ2OGY0MDMyNDlhNWItZGQ1MC00ZDBkLTgxMzQtNGRjMDkwOGJiMWU1&nopa=2&prompt=none&x-client-SKU=ID_NET472&x-client-ver=7.6.0.0)<!-- HN:41300479:end --><!-- HN:41300883:start -->
* [41300883](https://news.social-protocols.org/stats?id=41300883) #24 9 points 0 comments -> [Waymo now serves over 100k paid trips per week](https://twitter.com/techtekedra/status/1825910695311114384)<!-- HN:41300883:end --><!-- HN:41301858:start -->
* [41301858](https://news.social-protocols.org/stats?id=41301858) #21 7 points 2 comments -> [Harris has the right idea on housing](https://www.noahpinion.blog/p/harris-has-the-right-idea-on-housing)<!-- HN:41301858:end --><!-- HN:41302140:start -->
* [41302140](https://news.social-protocols.org/stats?id=41302140) #25 3 points 0 comments -> [Republicans ask Supreme Court to block 40k Arizonans from voting in November](https://www.yahoo.com/news/republicans-ask-supreme-court-block-100050322.html)<!-- HN:41302140:end --><!-- HN:41301612:start -->
* [41301612](https://news.social-protocols.org/stats?id=41301612) #26 30 points 19 comments -> [The AI photo editing era is here, and it's every person for themselves](https://www.theverge.com/2024/8/19/24221884/google-photos-magic-editor-ai-reimagine)<!-- HN:41301612:end -->
#### **Wednesday, August 21, 2024**
<!-- HN:41305166:start -->
* [41305166](https://news.social-protocols.org/stats?id=41305166) #3 9 points 4 comments -> [Uncensored AI: a fine tune of Llama 405B – no more PC nonsense](https://www.aiuncensored.info/uncensored)<!-- HN:41305166:end --><!-- HN:41305936:start -->
* [41305936](https://news.social-protocols.org/stats?id=41305936) #4 6 points 2 comments -> [High school shuts down its library because of book-banning state law](https://www.lgbtqnation.com/2024/08/high-school-shuts-down-its-library-because-of-book-banning-state-law/)<!-- HN:41305936:end --><!-- HN:41256266:start -->
* [41256266](https://news.social-protocols.org/stats?id=41256266) #4 24 points 3 comments -> [3D Cellular Automata](https://williamyang98.github.io/3D-Cellular-Automata/)<!-- HN:41256266:end --><!-- HN:41306664:start -->
* [41306664](https://news.social-protocols.org/stats?id=41306664) #26 10 points 2 comments -> [The Decay of Boeing](https://brief.bismarckanalysis.com/p/the-decay-of-boeing)<!-- HN:41306664:end --><!-- HN:41306978:start -->
* [41306978](https://news.social-protocols.org/stats?id=41306978) #21 45 points 40 comments -> [Sonos CEO says the old app can't be rereleased](https://www.theverge.com/2024/8/20/24224754/sonos-ceo-old-s2-app-re-release-cant-be)<!-- HN:41306978:end --><!-- HN:41309022:start -->
* [41309022](https://news.social-protocols.org/stats?id=41309022) #17 4 points 0 comments -> [Worse Is Better](https://en.wikipedia.org/wiki/Worse_is_better)<!-- HN:41309022:end --><!-- HN:41306332:start -->
* [41306332](https://news.social-protocols.org/stats?id=41306332) #18 35 points 10 comments -> [How I started blogging (2024)](https://roarepally.com/blog/why-I-blog)<!-- HN:41306332:end --><!-- HN:41311553:start -->
* [41311553](https://news.social-protocols.org/stats?id=41311553) #4 11 points 6 comments -> [MIT undergraduate admissions in the wake of the 2023 Supreme Court ruling](https://news.mit.edu/2024/qa-undergraduate-admissions-in-wake-of-supreme-court-ruling-0821)<!-- HN:41311553:end --><!-- HN:41308038:start -->
* [41308038](https://news.social-protocols.org/stats?id=41308038) #20 56 points 40 comments -> [ScreenPlay Is an Open Source Live-Wallpaper App for Windows and OS X](https://screen-play.app/)<!-- HN:41308038:end --><!-- HN:41311461:start -->
* [41311461](https://news.social-protocols.org/stats?id=41311461) #29 53 points 14 comments -> [Russia: Citizens must turn off home surveillance because Ukrainians are coming](https://www.theregister.com/2024/08/21/russia_memo_ukraine_invasion/)<!-- HN:41311461:end --><!-- HN:41313619:start -->
* [41313619](https://news.social-protocols.org/stats?id=41313619) #25 5 points 4 comments -> [.less: Crafting .less Docker Containers That Will Blow Your Mind](https://pointlesscode.dev/)<!-- HN:41313619:end --><!-- HN:41314453:start -->
* [41314453](https://news.social-protocols.org/stats?id=41314453) #20 22 points 41 comments -> [New anti-speeding system coming to Australia is dangerous](https://www.carexpert.com.au/opinion/new-anti-speeding-system-coming-to-australia-is-dangerous)<!-- HN:41314453:end -->
#### **Thursday, August 22, 2024**
<!-- HN:41267412:start -->
* [41267412](https://news.social-protocols.org/stats?id=41267412) #2 85 points 30 comments -> [Py5, a Python version of Processing for your creative coding projects](http://py5coding.org/index.html)<!-- HN:41267412:end --><!-- HN:41271783:start -->
* [41271783](https://news.social-protocols.org/stats?id=41271783) #3 35 points 12 comments -> [Ren'Py](https://github.com/renpy/renpy)<!-- HN:41271783:end --><!-- HN:41263876:start -->
* [41263876](https://news.social-protocols.org/stats?id=41263876) #7 154 points 28 comments -> [Better Living Through Algorithms (2023)](https://clarkesworldmagazine.com/kritzer_05_23/)<!-- HN:41263876:end --><!-- HN:41268126:start -->
* [41268126](https://news.social-protocols.org/stats?id=41268126) #15 15 points 3 comments -> [Underware, open source 3D-printed cable management](https://handsonkatie.com/underware/)<!-- HN:41268126:end --><!-- HN:41271139:start -->
* [41271139](https://news.social-protocols.org/stats?id=41271139) #28 30 points 8 comments -> [Unhygienic and referentially opaque macros with Scheme syntax-rules [pdf] (2013)](https://okmij.org/ftp/Scheme/Dirty-Macros.pdf)<!-- HN:41271139:end --><!-- HN:41316029:start -->
* [41316029](https://news.social-protocols.org/stats?id=41316029) #15 6 points 10 comments -> [Never enable 2FA for accounts that you actually care about (2023)](https://benwilber.github.io/2023/07/17/never-enable-2fa-for-accounts-you-actually-care-about.html)<!-- HN:41316029:end --><!-- HN:41318127:start -->
* [41318127](https://news.social-protocols.org/stats?id=41318127) #21 42 points 40 comments -> [Starbucks' new CEO will supercommute 1k miles from California to Seattle](https://www.cnbc.com/2024/08/20/starbucks-new-ceo-brian-niccol-will-supercommute-to-seattle-instead-of-relocating.html)<!-- HN:41318127:end --><!-- HN:41318553:start -->
* [41318553](https://news.social-protocols.org/stats?id=41318553) #16 19 points 8 comments -> [Nix in 100 Seconds [video]](https://www.youtube.com/watch?v=FJVFXsNzYZQ)<!-- HN:41318553:end --><!-- HN:41318806:start -->
* [41318806](https://news.social-protocols.org/stats?id=41318806) #16 9 points 1 comments -> [Causal effect of video gaming on mental well-being in Japan 2020–2022](https://www.nature.com/articles/s41562-024-01948-y)<!-- HN:41318806:end --><!-- HN:41318975:start -->
* [41318975](https://news.social-protocols.org/stats?id=41318975) #13 7 points 2 comments -> [USAF's Quicksink weapon tears a ship in half in seconds](https://newatlas.com/military/quicksink-modular-strap-on-kit-smart-bomb/)<!-- HN:41318975:end --><!-- HN:41319012:start -->
* [41319012](https://news.social-protocols.org/stats?id=41319012) #21 8 points 3 comments -> [Dad hacks database to fake death and avoid child support pay](https://www.bbc.co.uk/news/articles/cgrj9r5qpego)<!-- HN:41319012:end --><!-- HN:41318330:start -->
* [41318330](https://news.social-protocols.org/stats?id=41318330) #13 7 points 1 comments -> [Show HN: Sonarr – automate finding, downloading, and managing TV shows](https://github.com/Sonarr/Sonarr)<!-- HN:41318330:end --><!-- HN:41315415:start -->
* [41315415](https://news.social-protocols.org/stats?id=41315415) #26 54 points 40 comments -> [Windows 11 tweaks and usability improvements](https://kittenlabs.de/blog/2024/08/20/windows-11-tweaks-usability-improvements/)<!-- HN:41315415:end --><!-- HN:41319477:start -->
* [41319477](https://news.social-protocols.org/stats?id=41319477) #13 6 points 1 comments -> [Show HN: Track project ETAs and statuses based on due date with this Jira App](https://easyestimate.app/)<!-- HN:41319477:end --><!-- HN:41319973:start -->
* [41319973](https://news.social-protocols.org/stats?id=41319973) #19 20 points 0 comments -> [eBay just charged me a $1.02 fee on an item I sold for $0.99](https://mastodon.social/@nfriedly/113005868074504264)<!-- HN:41319973:end --><!-- HN:41320554:start -->
* [41320554](https://news.social-protocols.org/stats?id=41320554) #8 24 points 11 comments -> [Make Sports Betting Taboo Again](https://jacobin.com/2024/08/sports-betting-taxation-robinhood-draftkings/)<!-- HN:41320554:end -->