using Discord.Commands;
using System;
using Discord.WebSocket;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Discord;

namespace OxygeNiuM
{
    class Program
    {
        DiscordSocketClient client;
        static void Main(string[] args)
         => new Program().MainAsync().GetAwaiter().GetResult();

        private async Task MainAsync()
        {
            client = new DiscordSocketClient();
            client.MessageReceived += CommandsHandler;
            client.Log += Log;

            var token = "YOUR TOKEN";

            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            Console.ReadLine();
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;

        }

        private Task CommandsHandler(SocketMessage msg)
        {
            if (!msg.Author.IsBot)
                switch (msg.Content)
                {

                    case "$help":
                        {
                            msg.Channel.SendMessageAsync($":moyai: $meme - Trend Memes\n " +
                                $":candle: $contact - Our social networks\n " +
                                $":pencil: $info - About bot\n" +
                                $"----------------------------------------------------\n  " +
                                $":pushpin: SPECIAL !!! :map: $quest - <<Rick and Morty>>");
                            break;
                        }
                    case "$meme":
                        {
                            msg.Channel.SendMessageAsync(":clock1: Meme of 24h \n" +
                                "https://www.reddit.com/r/memes/comments/spxdx9/hol_up_what \n" +
                                ":date: Meme of week \n" +
                                "https://www.reddit.com/r/memes/comments/spxkop/it_really_be_like_this/");
                            break;
                        }
                    case "$contact":
                        {
                            msg.Channel.SendMessageAsync($":desktop: Developer - in" +
                                $"st(https://www.instagram.com/hayk_oxygen/) \n:paperclip: Sponsor - " +
                                $"inst(https://www.instagram.com/rickandmorty_meemes/)");
                            break;
                        }
                    case "$info":
                        {
                            msg.Channel.SendMessageAsync($":question: Meaning of the Bot - Every month " +
                                $"there will be a special quest on different topics, and every week the questions " +
                                $"of the quest will be updated. And also there is a command with which you can " +
                                $"see the best meme according to NeuroFlex's version every week and every month");
                            break;
                        }

                    case "$quest":
                        {
                            msg.Channel.SendMessageAsync($"Our first quest :) " +
                                $"https://take.quiz-maker.com/QS2LSJNLR \n Answer the questions, and then we will check and publish the best results" +
                                $"\n Good luck :)"
                                );
                            break;
                        }
                    case "$klklkjfhehsadugiawdgbiawsfvbiwausbdikwhsvdkaqvbdkiwusbfkmjsbdwe3kuirgfuwsjhvcfs":
                        {
                            msg.Channel.SendMessageAsync($"┊1.1 Այն ամենը, ինչ գրված է այստեղ, ենթակա չէ քննարկման, հակադրության, համեմատության:\n" +
                                $" ┊1.2 Կանոնների անտեղյակությունը չի ազատում ձեզ պատասխանատվությունից:\n " +
                                $" ┊1.3 Հետեւեք սպասարկիչում հաճելի ժամանցի բոլոր կանոններին:\n" +
                                $" ┊1.4 Արգելվում է վարչությունից դերեր կամ արտոնություններ խնդրել:\n" +
                                $" ┊1.5 Արգելվում է օգտագործել twink հաշիվներ:\n" +
                                $" ┊1.6 Պատժից խուսափելը արգելվում է: Պատասխանատվություն ստանձնեք ձեր գործողությունների համար:\n" +
                                $" ┊2.1 Արգելվում է վիրավորել սպասարկիչի այլ անդամներին:\n" +
                                $" ┊2.2 Արգելվում է ստեղծել կոնֆլիկտային իրավիճակներ:\n" +
                                $" ┊2.3 Offtopic-ն արգելված է: (Offtopic - բաներ, որոնք դուրս են գալիս ալիքի սահմանված թեմայից):\n" +
                                $" ┊2.4 Արգելվում է հեղեղել նամակներով, սպամերով կամ CAPS-ի չարաշահումը:\n" +
                                $" ┊2.5 Արգելվում է ցանկացած ձեւի ցանկացած գովազդ:\n" +
                                $" ┊2.6 Արգելվում է ռասիզմի, նացիզմի, ֆաշիզմի, սեքսիզմի ցանկացած ներկայացում:\n" +
                                $" ┊2.7 Արգելվում են ինքնասպանության կոչ ունեցող բովանդակության հաղորդագրությունները:\n" +
                                $" ┊2.8 Առանց պատճառի արգելված @pinging-ը:\n" +
                                $" ┊2.9 Արգելվում է տարածել օգտագործողի անձնական տվյալները առանց նրա համաձայնության:\n" +
                                $" ┊2.10 Արգելվում է բոտերին օգտագործել իրենց համար չնախատեսված ալիքներում:\n" +
                                $" ┊3.1 Արգելվում է վիրավորել, նվաստացնել սպասարկիչի այլ անդամներին:\n" +
                                $" ┊3.2 Արգելվում է ռասիզմի, նացիզմի, սեքսիզմի եւ ֆաշիզմի ցանկացած ձեւի բովանդակություն ունեցող բաներ:\n" +
                                $" ┊3.3 Արգելվում է երրորդ կողմի ծրագրերով ապահովել միջամտություն, աղմուկ եւ կողմնակի հնչյուններ:\n" +
                                $" ┊3.4 Արգելվում է NFSW բովանդակություն:");
                            break;
                        }
                    case "$efuhfewhr37rheuh83nruc3uc3c83yr8c3ymx92qhiau938yxm24w8rgufsha3yen38hcai38rynusygxm9s98eyghs":
                        {
                            msg.Channel.SendMessageAsync($"Այս կանոնների խախտման դեպքում լիազորված օգտատերն իրավունք ունի գործելու իր հայեցողությամբ, սակայն ստանդարտ պատիժը նախազգուշացում տալն է, որին հաջորդում է mut (որոշ ժամանակով չաթերին գրելու անկարողություն): Սերվերն ունի նախազգուշացումների համակարգ, որն աշխատում է կուտակային համակարգի համաձայն.\n\n" +
                                $"• 1 նախազգուշացում՝ 30 րոպե mute\n" +
                                $"• 2 նախազգուշացում՝ 24 ժամ mute\n" +
                                $"• 3-րդ նախազգուշացում՝ 7 օր mute\n" +
                                $"• 4-րդ զգուշացում՝ 60 օրով ban\n" +
                                $"Նախազգուշացման ժամկետը լրանում է ստանալուց 30 օր հետո:");
                            break;
                        }
                    case "$ajshasdhdwojmoduwnocowmoxiewoixoieweqwqwqpwooeiqnxiquoxqouwbgwhwodduwobnewhewmiwhdsiowurownusm":
                        {
                            msg.Channel.SendMessageAsync("---");
                            break;
                        }

                }
            return Task.CompletedTask;
        }
    }
}

/* 
 if (!result.StartsWith("["))
    JArray arr = JArray.Parse(result);
JObject post = JObject.Parse(arr[0]["data"]["children"][0]["data"].ToString());

var builder = new EmbedBuilder()
.WithImageUrl(post["url"].ToString())a
.WithColor(new Color(33, 176, 252))
.WithTitle(post["title"].ToString())
.WithUrl("https://reddit.com" + post["permalink"].ToString())

var embed = builder.Build();
await Context.Channel.SendMessageAsync(null, false, embed); 

         [Command("!meme")]
        [Alias("reddit")]
        public async Task Meme()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync($"https://reddit.com/r/memes/random.jsin?limit=1");
        }


NeuroFlex intended for fun. The only developer and owner worked on the bot - Oxygen#5135
*/


