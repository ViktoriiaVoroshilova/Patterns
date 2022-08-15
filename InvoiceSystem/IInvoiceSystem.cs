using InvoiceSystemService.Models;

namespace InvoiceSystemService
{
    public interface IInvoiceSystem
    {
        void SendInvoice(Invoice invoice);
    }
}
