using PaymentSystemService.Models;

namespace PaymentSystemService
{
    public class PaymentSystem : IPaymentSystem
    {
        public bool MakePayment(Payment payment)
        {
            Console.WriteLine($"Making payment of price: ${payment.Price}");
            return true;
        }
    }
}
