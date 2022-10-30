using Consumer.Data;
using Consumer.Services;

namespace Consumer
{
    public class Handler
    {
        private IMessageService _messageService;
        private IDatabase _database;

        public Handler(IMessageService messageService, IDatabase database)
        {
            _messageService = messageService;
            _database = database;
        }

        public (bool, string) Handle(string queue)
        {
            var message = _messageService.Dequeue(queue);

            _database.Add(message);

            return (true, "Message added to database: " + message);
        }
    }
}