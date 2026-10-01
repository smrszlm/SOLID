using SOLID.Interfaces;

namespace SOLID.NotificationMethods
{
    public class PushNotification :INotificationMethod
    {
        public void Notify()
        {
            Console.WriteLine("Push Notification enviada com sucesso.");
        }
    }
}
