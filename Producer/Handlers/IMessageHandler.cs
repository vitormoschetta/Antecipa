namespace Producer.Handlers
{
    public interface IMessageHandler
    {
        (bool, string) Handle(string message, string queue);
    }
}