using SOLID.Interfaces;

namespace SOLID.DiscountTypes
{
    public class Employee : IDiscount
    {
        public decimal GetDiscount(OrderRequest order)
        {
            var discount = order.Total * 20 / 100;

            return order.Total - discount;
        }
    }
}
