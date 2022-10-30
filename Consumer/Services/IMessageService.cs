namespace Consumer.Services
{
    public interface IMessageService
    {
        string Dequeue(string queue);
    }
}