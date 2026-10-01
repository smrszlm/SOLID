using SOLID.Enums;
using SOLID.Interfaces;

namespace SOLID.PaymentMethods
{
    public class Pix : IPaymentMethod
    {
        public StatusEnums Pay(decimal total)
        {
            Console.WriteLine("Pagamento com Pix Efetuado");
            return StatusEnums.Paid;
        }
    }
}
