using Producer.Services;

namespace Producer.Handlers
{
    public class MessageHandler : IMessageHandler
    {
        private readonly IMessageService _messageService;

        public MessageHandler(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public (bool, string) Handle(string message, string queue)
        {
            // validations and other logic here

            _messageService.Enqueue(message, queue);

            return (true, "Message added to queue: " + message);
        }
    }
}