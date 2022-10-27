namespace Leitor
{
    public class Database : IDatabase
    {
        private List<string> Tabela { get; set; }

        public Database()
        {
            Tabela = new List<string>();
        }

        public void Add(string item)
        {
            Tabela.Add(item);
        }

    }
}