using SOLID.Interfaces;

namespace SOLID.NotificationMethods
{
    public class Sms :INotificationMethod
    {
        public void Notify()
        {
            Console.WriteLine("Sms enviado com sucesso.");
        }
    }
}
