using Consumer.Data;

namespace Consumer.Services
{
    public class ServiceCollection
    {
        public static IMessageService GetMessageService()
        {
            return new MessageService();
        }

        public static IDatabase GetDatabase()
        {
            return new Database();
        }
    }
}