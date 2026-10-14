using SOLID.Entities;
using SOLID.Enums;
using SOLID.Interfaces;

namespace SOLID.PaymentMethods
{
    public class Boleto : IPaymentMethod
    {
        public PaymentResponse Pay(decimal total)
        {
            return new PaymentResponse
            {
                Status = StatusEnums.Pending,
                TransactionId = "0",
                Mensagem = "Aguardando pagamento do boleto."
            };
        }
    }
}
