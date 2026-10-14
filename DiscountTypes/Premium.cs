using SOLID.Interfaces;

namespace SOLID.DiscountTypes
{
    public class Premium : IDiscount
    {
        public decimal GetDiscount(OrderRequest order)
        {
            var discount = order.Total * 15 / 100;

            return order.Total - discount;
        }
    }
}
