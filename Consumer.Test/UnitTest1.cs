using Consumer.Test.Mock;

namespace Consumer.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange            
        var queue = "hello";

        var messageService = new MessageServiceFake();
        var database = new DatabaseFake();

        var handler = new Handler(messageService, database);

        // Act        
        handler.Handle(queue);

        // Assert
        Assert.Equal(1, database.Storage.Count);
        Assert.Equal("Hello World", database.Storage[0]);
    }
}