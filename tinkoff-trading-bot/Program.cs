using System;
using System.IO;
using System.Threading.Tasks;

namespace tinkoff_trading_bot
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            var token = (await File.ReadAllTextAsync("token.txt")).Trim();
            await using var bot = new SandboxBot(token);
            await bot.StartAsync();
        }
    }
}
