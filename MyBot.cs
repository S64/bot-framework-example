using System.Threading.Tasks;
using Microsoft.Bot.Builder;

namespace BotFrameworkExample
{

    public class MyBot : ActivityHandler
    {

        protected override async Task OnMessageActivityAsync(
            ITurnContext<Microsoft.Bot.Schema.IMessageActivity> turnContext,
            System.Threading.CancellationToken cancellationToken
        )
        {
            await turnContext.SendActivityAsync(
                MessageFactory.Text("Hello World!"),
                cancellationToken
            );
        }

    }

}
