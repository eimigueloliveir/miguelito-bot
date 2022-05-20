﻿using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace miguelito_bot_commands.commands
{
    internal class random_commands : BaseCommandModule
    {
        [Command("bolo"), Aliases("mulango")]
        public async Task bolo(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            DiscordEmbedBuilder embed = new DiscordEmbedBuilder
            {
                Color = DiscordColor.Red,
                ImageUrl = "https://c.tenor.com/t4zUkk1R-UIAAAAd/pica-pau.gif"
            };
            await ctx.RespondAsync(ctx.User.Mention, embed);
            await Program.log("bolo");
        }

        [Command("portugues"), Aliases("pt")]
        public async Task portugues(CommandContext ctx, DiscordUser user = null)
        {
            await ctx.TriggerTypingAsync();
            DiscordEmbedBuilder embed;
            if (user == null)
            {
                user = ctx.User;
                embed = new DiscordEmbedBuilder
                {
                    Color = main_commands.cores(),
                    ImageUrl = "https://media.discordapp.net/attachments/949836472985460766/950064401732493372/fala_portugues.png",
                    Description = ctx.User.Mention,
                };
            }
            else
            {
                embed = new DiscordEmbedBuilder
                {
                    Color = main_commands.cores(),
                    ImageUrl = "https://media.discordapp.net/attachments/949836472985460766/950064401732493372/fala_portugues.png?width=587&height=559",
                    Description = " ei " + user.Mention,
                };
            }
            await ctx.RespondAsync(ctx.User.Mention, embed);
            await Program.log("pt");
        }
        [Command("viniccius13"), Aliases("13", "vini")]
        public async Task viniccius(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            DiscordEmbedBuilder embed = new DiscordEmbedBuilder
            {
                Color = DiscordColor.Red,
                ImageUrl = "https://cdn.discordapp.com/attachments/949838790774636644/949838931581612062/vinicius13.gif"
            };
            await ctx.RespondAsync(embed);
            await Program.log("viniccius13");
        }

        [Command("migueloliveira")]
        public async Task migueloliveira(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            DiscordEmbedBuilder embed = new DiscordEmbedBuilder
            {
                Color = DiscordColor.Red,
                ImageUrl = "https://pbs.twimg.com/profile_images/1520827797761105920/vJvgL4Tw_400x400.jpg",
            };
            embed.WithAuthor("Miguel Oliveira", "https://migueloliveira.xyz", "https://pbs.twimg.com/profile_images/1486866093604016131/jzbj65Ku_400x400.jpg");
            await ctx.RespondAsync($"{ctx.User.Mention} Falou o nome do patrão?", embed);
            await Program.log("miguel oliveira");
        }

        [Command("aiai")]
        public async Task aiai(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            DiscordEmbedBuilder embed = new DiscordEmbedBuilder
            {
                Title = "aiai",
                Color = main_commands.cores(),
                ImageUrl = "https://cdn.discordapp.com/attachments/949838790774636644/949839400790028308/essa-gente-inventa.gif"
            };
            await ctx.RespondAsync(embed);
            await Program.log("aiai");
        }

        [Command("diálogo"), Aliases("dialogo")]
        public async Task diálogo(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            DiscordEmbedBuilder embed = new DiscordEmbedBuilder
            {
                Title = "dialogo",
                Color = main_commands.cores(),
                ImageUrl = "https://cdn.discordapp.com/attachments/949838790774636644/949839927972102184/dialogo.gif",
                Description = ctx.User.Mention + "vamo resolver isso no dialogo?"
            };
            await ctx.RespondAsync(embed);
            await Program.log("dialogo");
        }
        #region comandos diferenciados

        [Command("sexo"), Aliases("hentai", "porno", "buceta", "punheta")]
        public async Task sexo(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            DiscordEmbedBuilder embed = new DiscordEmbedBuilder
            {
                Color = DiscordColor.Red,
                ImageUrl = "https://media.discordapp.net/attachments/949836472985460766/951596734331633734/vai_orar_imunda.jpg"
            };
            await ctx.RespondAsync(":new_moon_with_face:", embed);
            await Program.log(":new_moon_with_face:");
        }
        #endregion

        [Command("boanoite"), Aliases("boa-noite")]
        public async Task boanoite(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            await ctx.RespondAsync("Boa noite");
            await Program.log("boa noite");
        }
    }
}
