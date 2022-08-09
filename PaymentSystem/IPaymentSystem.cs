using PaymentSystemService.Models;

namespace PaymentSystemService
{
    public interface IPaymentSystem
    {
        bool MakePayment(Payment payment);
    }
}
