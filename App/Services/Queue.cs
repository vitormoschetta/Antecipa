namespace App.Services
{
    public class Queue : IQueue
    {
        public void Enqueue(string message, string queueName)
        {
            var directory = "/home/vfarias/Desktop/Antecipa";

            using (StreamWriter writer = new StreamWriter(directory + queueName, true))
            {
                writer.WriteLine(message);
            }
        }
    }
}