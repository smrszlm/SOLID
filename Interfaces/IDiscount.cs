using SOLID.Entities;
using SOLID.Enums;

namespace SOLID.Interfaces
{
    public interface IDiscount
    {
        Task<decimal> GetDiscount(OrderRequest order, DiscountEnums discount);
    }
}
