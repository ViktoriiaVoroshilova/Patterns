using Adapter.Containers;
using Adapter.Elements;
using Adapter.Printers;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
            .AddSingleton<IElements<string>, Elements<string>>()
            .AddSingleton<IContainer<string>, ContainerAdapter<string>>()
            .AddSingleton<IPrinter, Printer>()
            .BuildServiceProvider();


var printer = serviceProvider.GetService<IPrinter>();
printer!.Print(serviceProvider.GetService<IContainer<string>>()!);