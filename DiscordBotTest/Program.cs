using DSharpPlus;

DiscordConfiguration DSConf = new DiscordConfiguration()
{
    //Token = Environment.GetEnvironmentVariable("LORDBOTTOKEN"),
    Token = "Nzc5OTE2NTc2OTc5NDE5MTM2.X7nf6g.24Wlk_i2XXuC1VDVBodKE9WHms8",
    TokenType = TokenType.Bot
};


static async Task MainAsync(DiscordConfiguration DSConf)
{
    var discord = new DiscordClient(DSConf);
    await discord.ConnectAsync();
    await Task.Delay(-1);


}


MainAsync(DSConf).GetAwaiter().GetResult();