using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace TutorialBot.Modules{
    public class Commands : ModuleBase<SocketCommandContext>{
        [Command("hello")]
        public async Task Hello(){
            await ReplyAsync("Hello there, how are you doing?");
        }

        [Command("poll")]
        public async Task Poll()
        {
            var menuBuilder = new SelectMenuBuilder()
                .WithPlaceholder("Select an option")
                .WithCustomId("menu-1")
                .WithMinValues(1)
                .WithMaxValues(1)
                .AddOption("Option A", "opt-a", "Yes, I am!")
                .AddOption("Option B", "opt-b", "No, I'm not.");

            var builder = new ComponentBuilder()
                .WithSelectMenu(menuBuilder);

            await ReplyAsync("Are you happy today?", components: builder.Build());
        }
    }
}
