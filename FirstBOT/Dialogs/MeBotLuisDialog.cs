using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FirstBOT.Dialogs
{
    [Serializable]
    [LuisModel("f1687e67-91a3-4894-8d5b-cb921d06e65d", "f4956c32cd81463bb4fddd161aa49b34")]
    public class MeBotLuisDialog : LuisDialog<object>
    {              
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            //   var MessageReceived = await result as Activity;
            await context.PostAsync("I'm sorry. I didn't understand you.");

         //   context.Wait(MessageReceived);
        }

        //[LuisIntent("AboutME")]
        //public async Task AboutMe(IDialogContext context, LuisResult result)
        //{
        //    await context.PostAsync(@"This is the bot application");
           
        //  //  context.Wait(MessageReceived);
        //}

        [LuisIntent("Profile")]
        public async Task Profile(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(@"My phone number is 9965564854");
           
            //  context.Wait(MessageReceived);
        }

        private async Task MessageReceived(IDialogContext context, IAwaitable<object> result)
        {


            await context.PostAsync("I'm sorry. I didn't understand you.");

            //var activity = await result as Activity;

            //// calculate something for us to return
            //int length = (activity.Text ?? string.Empty).Length;

            //// return our reply to the user
            //await context.PostAsync($"You sent {activity.Text} which was {length} characters");

            //context.Wait(MessageReceived);
        }
    }
}