using Consumer.Services;

namespace Consumer.Test.Mock
{
    public class MessageServiceFake : IMessageService
    {
        public string Dequeue(string queueName)
        {
            return "Hello World";
        }
    }
}