using SOLID.Interfaces;

namespace SOLID.NotificationMethods
{
    public class WhatsApp : INotificationMethod
    {
        public void Notify()
        {
            Console.WriteLine("Mensagem enviada com sucesso.");
        }
    }
}
