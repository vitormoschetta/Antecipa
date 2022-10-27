using App.Services;

namespace App
{
    public class ServiceCollections
    {
        public static IQueue GetQueue()
        {
            return new Queue();
        }
    }
}