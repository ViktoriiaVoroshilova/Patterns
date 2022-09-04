using AbstractFactoryRestaurant;
using AbstractFactoryRestaurant.Factories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

var serviceProvider = new ServiceCollection()
    .AddLogging((loggingBuilder) => loggingBuilder
        .SetMinimumLevel(LogLevel.Information)
        .AddConsole())
    .AddSingleton<IRestaurant, Restaurant>()
    .AddSingleton<ISeasonFactory, SeasonFactory>()
    .AddSingleton<ICooker, Cooker>()
    .BuildServiceProvider();

var restaurant = serviceProvider.GetService<IRestaurant>();
var cooker = serviceProvider.GetService<ICooker>();
restaurant!.CookMasala(cooker!, Country.Ukraine, DateTime.Now);

Console.ReadLine();
