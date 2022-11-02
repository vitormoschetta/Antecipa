using Microsoft.Extensions.DependencyInjection;
using Producer.Handlers;
using Producer.Services;

try
{
    var services = new ServiceCollection();
    services.AddScoped<IMessageService, MessageService>();
    services.AddScoped<IMessageHandler, MessageHandler>();

    var queue = "hello.txt";

    Console.WriteLine("Entre com a mensagem:");
    var message = Console.ReadLine();

    if (string.IsNullOrEmpty(message))
    {
        Console.WriteLine("Mensagem inválida");
        return;
    }

    var serviceProvider = services.BuildServiceProvider();
    var messageHandler = serviceProvider.GetService<IMessageHandler>();

    if (messageHandler == null)
    {
        Console.WriteLine("Erro ao obter o serviço");
        return;
    }

    var (success, result) = messageHandler.Handle(message, queue);

    if (success)
        Console.WriteLine(result);
    else
        Console.WriteLine("Erro ao adicionar a mensagem na fila");

}
catch (Exception ex)
{
    Console.WriteLine("Exception: " + ex.Message);
    Console.WriteLine(ex.StackTrace);
}
