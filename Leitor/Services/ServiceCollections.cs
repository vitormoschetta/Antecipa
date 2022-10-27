using App.Services;

namespace Leitor
{
    public class ServiceCollections
    {
        public static IDequeue GetQueue()
        {
            return new Dequeue();
        }

        public static IDatabase GetDatabase()
        {
            return new Database();
        }
    }
}