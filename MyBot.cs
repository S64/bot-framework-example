using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;

namespace BotFrameworkExample
{

    public class MyBot : ActivityHandler
    {

        private static readonly string[] DUMMY = new string[] { "blah-blah-blah", "something something" };

        protected override async Task OnMessageActivityAsync(
            ITurnContext<Microsoft.Bot.Schema.IMessageActivity> turnContext,
            System.Threading.CancellationToken cancellationToken
        )
        {
            string response;

            if (turnContext.Activity.Text.StartsWith("Hello")) {
                response = "Hello!";
            } else if (turnContext.Activity.Text.StartsWith("Hi")) {
                response = "Hi!";
            } else if (turnContext.Activity.Text.StartsWith("テスト")) {
                response = "🙆";
            } else {
                response = DUMMY.OrderBy(_ => Guid.NewGuid()).First();
            }

            await turnContext.SendActivityAsync(
                MessageFactory.Text(
                    response
                ),
                cancellationToken
            );
        }

    }

}
