using App.Services;

namespace Leitor
{
    public class Processo
    {
        IDequeue _dequeue;
        IDatabase _database;
        public Processo(IDequeue queue, IDatabase database)
        {
            _dequeue = queue;
            _database = database;
        }       

        public void Execute(string queue)
        {
            var list = _dequeue.Dequeue(queue);
            foreach (var item in list)
            {
                _database.Add(item);
            }
        }
    }
}