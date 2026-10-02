using SOLID.Interfaces;

namespace SOLID.NotificationMethods
{
    public class WhatsApp : INotificationMethod
    {
        public void Notify(string customerName, string mensagem)
        {
            Console.WriteLine($"{customerName},{mensagem}");
        }
    }
}
