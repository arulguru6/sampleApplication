using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Builder.Luis;

namespace FirstBOT.Dialogs
{
  //  [Serializable]

    //public class MeBotLuisDialog : LuisDialog<object>
    //{
    //    [LuisIntent("None")]
    //    [LuisModel("f1687e67-91a3-4894-8d5b-cb921d06e65d", "f4956c32cd81463bb4fddd161aa49b34")]
    //    public async Task None(IDialogContext context, LuisResult result)
    //    {
    //        //   var MessageReceived = await result as Activity;
    //        await context.PostAsync("I'm sorry. I didn't understand you.");

    //        context.Wait(MessageReceived);
    //    }

    //    [LuisIntent("AboutMe")]
    //    public async Task AboutMe(IDialogContext context, LuisResult result)
    //    {
    //        await context.PostAsync(@"Ankit is a Software Engineer currently working in Microsoft Center of Excellence team at Mindtree. He started his professional career in 2013 after completing his graduation as Bachelor in Computer Science.");
    //        await context.PostAsync(@"He is a technology enthusiast and loves to dig in emerging technologies. Most of his working hours are spent on creating architecture, evaluating upcoming products and developing frameworks.");
    //        context.Wait(MessageReceived);
    //    }
    //}

    //public class RootDialog : IDialog<object>
    //{
    //    public Task StartAsync(IDialogContext context)
    //    {
    //        context.Wait(MessageReceivedAsync);

    //        return Task.CompletedTask;
    //    }

    //    private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
    //    {
    //        var activity = await result as Activity;

    //        // calculate something for us to return
    //        int length = (activity.Text ?? string.Empty).Length;

    //        // return our reply to the user
    //        await context.PostAsync($"You sent {activity.Text} which was {length} characters");

    //        context.Wait(MessageReceivedAsync);
    //    }


    //}
}