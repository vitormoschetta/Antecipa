using Leitor;
using Tests.Mock;

namespace Tests
{
    public class LeitorTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange            
            var fila = "Fila1";

            var dequeue = new DequeueFake();
            var database = new DatabaseFake();

            var processo = new Processo(dequeue, database);

            // Act        
            processo.Execute(fila);

            // Assert
            Assert.Equal(1, database.Tabela.Count);
            Assert.Equal("Hello World", database.Tabela[0]);
        }
    }
}