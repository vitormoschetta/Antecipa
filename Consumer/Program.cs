using Consumer;
using Consumer.Services;

try
{
    var messageService = ServiceCollection.GetMessageService();

    var database = ServiceCollection.GetDatabase();

    var handler = new Handler(messageService, database);

    var (success, message) = handler.Handle("hello.txt");

    if (success)
        Console.WriteLine(message);
}
catch (Exception ex)
{
    Console.WriteLine("Exception: " + ex.Message);
    Console.WriteLine(ex.StackTrace);
}
