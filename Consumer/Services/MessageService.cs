namespace Consumer.Services
{
    public class MessageService : IMessageService
    {
        private readonly string directory = Directory.GetCurrentDirectory();

        public string Dequeue(string queue)
        {
            var path = Path.GetFullPath(Path.Combine(directory, @"../"));          

            StreamReader sr = new StreamReader($"{path}/{queue}");
            return sr.ReadToEnd();
        }
    }
}