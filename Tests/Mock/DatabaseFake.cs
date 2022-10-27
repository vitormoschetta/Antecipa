using Leitor;

namespace Tests.Mock
{
    public class DatabaseFake : IDatabase
    {
        public List<string> Tabela = new List<string>();

        public void Add(string item)
        {
            Tabela.Add(item);
        }
    }
}