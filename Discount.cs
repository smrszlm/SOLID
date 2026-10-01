using SOLID.Entities;
using SOLID.Interfaces;

namespace SOLID
{
    public class Discount : IDiscount
    {
        public async Task<decimal> GetDiscount (OrderRequest order) 
        {
            decimal totalWithDiscount;

            if (order.Total <= 1000)
                return order.Total;

            var discount = order.Total * 10 / 100;
            totalWithDiscount = order.Total - discount;

            return totalWithDiscount;
        }
    }
}
