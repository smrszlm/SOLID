using SOLID.Entities;

namespace SOLID.Interfaces
{
    public interface IDiscount
    {
        Task<decimal> GetDiscount(OrderRequest order);
    }
}
