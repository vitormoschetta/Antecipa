namespace App.Services
{
    public interface IQueue
    {
        void Enqueue(string message, string queueName = "default");
    }
}