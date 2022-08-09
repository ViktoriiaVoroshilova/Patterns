namespace PaymentSystemService.Models
{
    public class Payment
    {
        public Payment(int price)
        {
            Price = price;
        }

        public int Price { get; }
    }
}
