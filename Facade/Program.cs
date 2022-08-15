using Facade;
using InvoiceSystemService;
using Microsoft.Extensions.DependencyInjection;
using PaymentSystemService;
using ProductCatalogService;

var serviceProvider = new ServiceCollection()
            .AddSingleton<IProductCatalog, ProductCatalog>()
            .AddSingleton<IPaymentSystem, PaymentSystem>()
            .AddSingleton<IInvoiceSystem, InvoiceSystem>()
            .AddSingleton<IOrderService, OrderService>()
            .BuildServiceProvider();

var orderService = serviceProvider.GetService<IOrderService>();

// for test purpose
const string productId = "xct1234pt34dfrtss";
const int testQuantity = 5;
const string email = "example@graim.com";

orderService!.PlaceOrder(productId, testQuantity, email);
