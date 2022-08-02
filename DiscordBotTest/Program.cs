using DSharpPlus;

DiscordConfiguration DSConf = new DiscordConfiguration()
{
    Token = Environment.GetEnvironmentVariable("LORDBOTTOKEN"),
    TokenType = TokenType.Bot
};


static async Task MainAsync(DiscordConfiguration DSConf)
{
    var discord = new DiscordClient(DSConf);
    await discord.ConnectAsync();
    await Task.Delay(-1);


}


MainAsync(DSConf).GetAwaiter().GetResult();