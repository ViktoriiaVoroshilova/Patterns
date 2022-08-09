using InvoiceSystemService.Models;

namespace InvoiceSystemService
{
    public class InvoiceSystem : IInvoiceSystem
    {
        public void SendInvoice(Invoice invoice)
        {
            Console.WriteLine($"Sending invoice about payment to {invoice.Email}");
        }
    }
}
