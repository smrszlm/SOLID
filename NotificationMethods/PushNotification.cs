using SOLID.Interfaces;

namespace SOLID.NotificationMethods
{
    public class PushNotification :INotificationMethod
    {
        public void Notify(string customerName, string mensagem)
        {
            Console.WriteLine($"{customerName},{mensagem}");
        }
    }
}
