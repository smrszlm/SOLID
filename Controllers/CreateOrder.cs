using SOLID.Entities;
using SOLID.Enums;
using SOLID.Interfaces;

namespace SOLID.Controllers
{
    public class CreateOrder
    {

        private readonly IDiscount _discount;
        private readonly ISaveOrder _saveOrder;

        public CreateOrder(IDiscount discount,
            ISaveOrder saveOrder)
        {
            _discount = discount;
            _saveOrder = saveOrder;
        }

        public async Task Create(IPaymentMethod paymentMethod, INotificationMethod notificationMethod, OrderRequest request)
        {
            var discountTotal = await _discount.GetDiscount(request, request.DiscountType);
            var payment = paymentMethod.Pay(discountTotal);

            var order = new Order
            {
                Id = request.Id,
                CustomerName = request.CustomerName,
                CustomerEmail = request.CustomerEmail,  
                Total = discountTotal,
                Status = payment.Status
            };

            _saveOrder.Save(order);

            notificationMethod.Notify(request.CustomerName, payment.Mensagem);
        }
    }
}
