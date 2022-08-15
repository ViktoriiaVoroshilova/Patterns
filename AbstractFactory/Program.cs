using AbstractFactory;
using AbstractFactory.Filters;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
            .AddSingleton<IFilterCreator, FilterCreator>()
            .AddSingleton<TradeFilter>()
            .BuildServiceProvider();

var tradeFilter = serviceProvider.GetService<TradeFilter>();

var trades = new[]
{
    new Trade
    {
        Amount = 95,
        Type = "Option",
        SubType = "MyOption"
    },
    new Trade
    {
        Amount = 34,
        Type = "Future",
        SubType = "NewOption"
    },
    new Trade {
        Amount = 95,
        Type = "Option",
        SubType = "NewOption"
    }
};

Console.WriteLine(string.Join(", ", tradeFilter!.FilterForBank(trades, Bank.Bofa, Country.England)));
Console.WriteLine(string.Join(", ", tradeFilter!.FilterForBank(trades, Bank.Barclays, Country.England)));
Console.WriteLine(string.Join(", ", tradeFilter!.FilterForBank(trades, Bank.Connacord, Country.England)));
Console.WriteLine(string.Join(", ", tradeFilter!.FilterForBank(trades, Bank.Deutsche, Country.England)));