using Producer.Handlers;
using Producer.Test.Mock;

namespace Producer.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var message = "Hello World";
        var queue = "hello";

        var messageService = new MessageServiceFake();

        var handler = new MessageHandler(messageService);

        // Act        
        handler.Handle(message, queue);

        // Assert
        Assert.Equal(1, messageService._queues.Count);
        Assert.Equal(message, messageService._queues[queue][0]);
    }
}