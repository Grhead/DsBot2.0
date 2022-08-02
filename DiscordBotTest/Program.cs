using DiscordBotTest.Commands;
using DSharpPlus;
using DSharpPlus.CommandsNext;

DiscordConfiguration DSConf = new DiscordConfiguration()
{
    Token = Environment.GetEnvironmentVariable("TKNVAR"),
    TokenType = TokenType.Bot
};

static async Task MainAsync(DiscordConfiguration DSConf)
{
    var discord = new DiscordClient(DSConf);
    var commands = discord.UseCommandsNext(
    new CommandsNextConfiguration()
    {
        StringPrefixes = new[] { "." },
        CaseSensitive = false
    });
    commands.RegisterCommands<TrainingModule>();
    //commands.RegisterCommands<StaffModule>();
    await discord.ConnectAsync();
    await Task.Delay(-1);
}

MainAsync(DSConf).GetAwaiter().GetResult();