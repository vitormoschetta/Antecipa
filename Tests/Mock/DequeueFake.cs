using App.Services;

namespace Tests.Mock
{
    public class DequeueFake : IDequeue
    {
        public List<string> Dequeue(string fila)
        {
            return new List<string>()
            {
                "Hello World"
            };
        }
    }
}