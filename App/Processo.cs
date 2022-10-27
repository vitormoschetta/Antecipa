using App.Services;

namespace App
{
    public class Processo
    {
        IQueue _queue;
        public Processo(IQueue queue)
        {
            _queue = queue;
        }

        public void Execute(string text, string queue)
        {
            _queue.Enqueue(text, queue);
        }
    }
}