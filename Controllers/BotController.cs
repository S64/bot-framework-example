using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Integration.AspNet.Core;

namespace BotFrameworkExample.Controllers
{

    [Route("api/messages")]
    [ApiController]
    public class BotController : ControllerBase
    {

        private readonly IBotFrameworkHttpAdapter Adapter;
        private readonly IBot Bot;
        
        public BotController(
            IBotFrameworkHttpAdapter adapter,
            IBot bot
        )
        {
            this.Adapter = adapter;
            this.Bot = bot;
        }

        [HttpPost]
        public async Task PostAsync()
        {
            await Adapter.ProcessAsync(
                Request, Response, Bot
            );
        }

    }

}