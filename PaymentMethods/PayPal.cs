using SOLID.Enums;
using SOLID.Interfaces;

namespace SOLID.PaymentMethods
{
    public class PayPal : IPaymentMethod
    {
        public StatusEnums Pay(decimal total)
        {
            Console.WriteLine("Pagamento com Paypal Efetuado");
            return StatusEnums.Paid;
        }
    }
}
