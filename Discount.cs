using SOLID.Enums;
using SOLID.Interfaces;

namespace SOLID
{
    public class Discount : IDiscount
    {
        public async Task<decimal> GetDiscount (OrderRequest order, DiscountEnums discount) 
        {
            decimal totalWithDiscount;

            if (order.Total <= 1000 && discount == DiscountEnums.Regular)
                return order.Total;

            var totalDiscount = order.Total * (int)discount / 100;
            totalWithDiscount = order.Total - totalDiscount;

            return totalWithDiscount;
        }
    }
}
