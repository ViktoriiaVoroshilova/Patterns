using InvoiceSystemService;
using InvoiceSystemService.Models;
using PaymentSystemService;
using PaymentSystemService.Models;
using ProductCatalogService;

namespace Facade
{
    public class OrderService : IOrderService
    {
        public OrderService(IProductCatalog productCatalog, IPaymentSystem paymentSystem, IInvoiceSystem invoiceSystem)
        {
            _productCatalog = productCatalog;
            _paymentSystem = paymentSystem;
            _invoiceSystem = invoiceSystem;
        }

        public void PlaceOrder(string productId, int quantity, string email)
        {
            var product = _productCatalog.GetProductDetails(productId);

            var totalPrice = product.Price * quantity;

            var payment = new Payment(totalPrice);

            var isSucceeded = _paymentSystem.MakePayment(payment);

            var invoice = new Invoice
            {
                ProductId = productId,
                TotalPrice = totalPrice,
                Email = email,
                IsSucceeded = isSucceeded
            };

            _invoiceSystem.SendInvoice(invoice);
        }

        private readonly IProductCatalog _productCatalog;
        private readonly IPaymentSystem _paymentSystem;
        private readonly IInvoiceSystem _invoiceSystem;
    }
}
