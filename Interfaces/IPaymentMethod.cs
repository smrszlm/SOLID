using SOLID.Enums;

namespace SOLID.Interfaces
{
    public interface IPaymentMethod
    {
        public StatusEnums Pay(decimal total);
    }
}
