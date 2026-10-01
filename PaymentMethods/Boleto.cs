using SOLID.Enums;
using SOLID.Interfaces;

namespace SOLID.PaymentMethods
{
    public class Boleto : IPaymentMethod
    {
        public StatusEnums Pay(decimal total)
        {
            Console.WriteLine("Pagamento com Boleto Efetuado");
            return StatusEnums.Pending;
        }
    }
}
