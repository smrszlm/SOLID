namespace SOLID.Interfaces
{
    public interface INotificationProcessor
    {
        void Send(INotificationMethod method);
    }
}
