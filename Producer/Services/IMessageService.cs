namespace Producer.Services
{
    public interface IMessageService
    {
        void Enqueue(string message, string queueName);   
    }
}