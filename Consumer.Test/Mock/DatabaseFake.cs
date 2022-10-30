
using Consumer.Data;

namespace Consumer.Test.Mock
{
    public class DatabaseFake : IDatabase
    {
        public List<string> Storage = new List<string>();

        public void Add(string item)
        {
            Storage.Add(item);
        }
    }
}