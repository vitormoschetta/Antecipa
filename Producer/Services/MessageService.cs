namespace Producer.Services
{
    public class MessageService : IMessageService
    {
        private string directory = Directory.GetCurrentDirectory();

        public void Enqueue(string message, string queue)
        {            
            var path = Path.GetFullPath(Path.Combine(directory, @"../"));

            using (StreamWriter writer = new StreamWriter($"{path}/{queue}", true))
            {
                writer.WriteLine(message);
            }
        }
    }
}