using SOLID.Interfaces;

namespace SOLID.NotificationMethods
{
    public class Email : INotificationMethod
    {
        public void Notify()
        {
            Console.WriteLine("Email enviado com sucesso.");
        }
    }
}
