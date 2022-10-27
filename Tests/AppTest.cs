using App;
using Tests.Mock;

namespace Tests;

public class AppTest
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var text = "Hello World";
        var fila = "Fila1";

        var queue = new QueueFake();

        var processo = new Processo(queue);

        // Act        
        processo.Execute(text, fila);

        // Assert
        Assert.Equal(1, queue._queues[fila].Count);
        Assert.Equal(text, queue._queues[fila][0]);
    }
}