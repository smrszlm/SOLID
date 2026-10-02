using SOLID.Entities;
using SOLID.Enums;

namespace SOLID.Interfaces
{
    public interface IPaymentMethod
    {
        public PaymentResponse Pay(decimal total);
    }
}
