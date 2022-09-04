using FactoryMethod;
using FactoryMethod.Filters;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddSingleton<IBarclaysFilterCreator, BarclaysFilterCreator>()
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
    },
    new Trade {
        Amount = 108,
        Type = "Future",
        SubType = "NewOption"
    }
};

Console.WriteLine("Bofa " + string.Join(", ", tradeFilter!.FilterForBank(trades, Bank.Bofa, Country.England)));
Console.WriteLine("Barclays England " + string.Join(", ", tradeFilter!.FilterForBank(trades, Bank.Barclays, Country.England)));
Console.WriteLine("Barclays USA " + string.Join(", ", tradeFilter!.FilterForBank(trades, Bank.Barclays, Country.USA)));
Console.WriteLine("Connacord " + string.Join(", ", tradeFilter!.FilterForBank(trades, Bank.Connacord, Country.England)));
Console.WriteLine("Deutsche " + string.Join(", ", tradeFilter!.FilterForBank(trades, Bank.Deutsche, Country.England)));