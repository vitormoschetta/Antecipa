using Producer.Services;

namespace Producer.Test.Mock
{
    public class MessageServiceFake : IMessageService
    {
        public Dictionary<string, List<string>> _queues = new Dictionary<string, List<string>>();

        public void Enqueue(string message, string queueName)
        {
            if (!_queues.ContainsKey(queueName))
            {
                _queues.Add(queueName, new List<string>());
            }

            _queues[queueName].Add(message);
        }
    }
}