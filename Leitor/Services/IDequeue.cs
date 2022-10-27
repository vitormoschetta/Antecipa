namespace App.Services
{
    public interface IDequeue
    {
        List<string>  Dequeue(string fila);
    }
}