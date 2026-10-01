using SOLID.Enums;
using SOLID.Interfaces;

namespace SOLID.PaymentMethods
{
    public class CreditCard : IPaymentMethod
    {
        public StatusEnums Pay(decimal total)
        {
            Console.WriteLine("Pagamento com Cartao de Credito Efetuado");
            return StatusEnums.Paid;
        }
    }
}
