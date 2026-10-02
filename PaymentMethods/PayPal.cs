using SOLID.Entities;
using SOLID.Enums;
using SOLID.Interfaces;

namespace SOLID.PaymentMethods
{
    public class PayPal : IPaymentMethod
    {
        public PaymentResponse Pay(decimal total)
        {
            return new PaymentResponse
            {
                Status = StatusEnums.Paid,
                TransactionId = 0,
                Mensagem = null
            };
        }
    }
}
