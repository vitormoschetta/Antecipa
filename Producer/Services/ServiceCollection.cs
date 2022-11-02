namespace Producer.Services
{
    public class ServiceCollections
    {
        public static IMessageService GetMessageService()
        {
            return new MessageService();
        }
    }
}