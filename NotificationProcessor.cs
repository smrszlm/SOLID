using SOLID.Interfaces;

namespace SOLID
{
    public class NotificationProcessor : INotificationProcessor
    {
        public void Send(INotificationMethod method)
        {
            method.Notify();
        }
    }
}
