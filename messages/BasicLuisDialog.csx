using System;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

// For more information about this template visit http://aka.ms/azurebots-csharp-luis
[Serializable]
public class BasicLuisDialog : LuisDialog<object>
{
    public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute("ce181128-0512-448e-a9ed-052be93058a9", "4c04858761a6404bbff14d30c2c01d63")))
    {
    }

    [LuisIntent("None")]
    public async Task NoneIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Não entendi o que você disse. Poderia repetir?"); //
        context.Wait(MessageReceived);
    }

    // Go to https://luis.ai and create a new intent, then train/publish your luis app.
    // Finally replace "MyIntent" with the name of your newly created intent in the following handler
    [LuisIntent("PresidenteAtento")]
    public async Task MyIntent(IDialogContext context, LuisResult result)
    {
        
        await context.PostAsync($"O atual presidente da atento no brasil é Mário Câmara"); //
        context.Wait(MessageReceived);
    }
}