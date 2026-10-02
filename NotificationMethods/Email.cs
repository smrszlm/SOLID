using SOLID.Interfaces;

namespace SOLID.NotificationMethods
{
    public class Email : INotificationMethod
    {
        public void Notify(string customerName, string mensagem)
        {
            Console.WriteLine($"{customerName},{mensagem}");
        }
    }
}
