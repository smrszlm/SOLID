using SOLID.Entities;
using SOLID.Interfaces;

namespace SOLID.Controllers
{
    public class CreateOrder
    {

        private readonly ISaveOrder _saveOrder;

        public CreateOrder(ISaveOrder saveOrder)
        {
            _saveOrder = saveOrder;
        }

        public void Create(IPaymentMethod paymentMethod, IEnumerable<INotificationMethod> notificationMethod, IDiscount discount, OrderRequest request)
        {
            var discountTotal = discount.GetDiscount(request);
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

            foreach (var notification in notificationMethod)
            {
                notification.Notify(request.CustomerName, payment.Mensagem);
            }
        }
    }
}
