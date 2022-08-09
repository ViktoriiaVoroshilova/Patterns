namespace InvoiceSystemService.Models
{
    public class Invoice
    {
        public int TotalPrice { get; set; }

        public string ProductId { get; set; } = null!;

        public string Email { get; set; } = null!;

        public bool IsSucceeded { get; set; }
    }
}
