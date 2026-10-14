using SOLID.Interfaces;

namespace SOLID.DiscountTypes
{
    public class Standard : IDiscount
    {
        public decimal GetDiscount(OrderRequest order)
        {
            if (order.Total > 1000)
                return order.Total;

            var discount = order.Total * 10 / 100;

            return order.Total - discount;
        }

    }
}
