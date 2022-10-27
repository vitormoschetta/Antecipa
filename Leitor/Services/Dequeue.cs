namespace App.Services
{
    public class Dequeue : IDequeue
    {
        List<string> IDequeue.Dequeue(string fila)
        {
            var directory = "/home/vfarias/Desktop/Antecipa";

            StreamReader sr = new StreamReader($"{directory}/{fila}");

            string line;

            var lista = new List<string>();

            while ((line = sr.ReadLine()) != null)
            {
                lista.Add(line);
            }

            sr.Close();

            return lista;
        }
    }
}