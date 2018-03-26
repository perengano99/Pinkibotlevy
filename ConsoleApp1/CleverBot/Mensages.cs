using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Levy.CleverBot
{
    public class Mensages : ModuleBase<SocketCommandContext>
    {
        [Command("levy")]
        public async Task MensagesAsync()
        {
            await ReplyAsync("Que quieres? :v");
        }
    }
}
