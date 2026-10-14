using SOLID.Interfaces;

namespace SOLID.NotificationMethods
{
    public class Sms :INotificationMethod
    {
        public void Notify(string customerName, string mensagem)
        {
            Console.WriteLine($"{customerName},{mensagem}");

        }
    }
}
