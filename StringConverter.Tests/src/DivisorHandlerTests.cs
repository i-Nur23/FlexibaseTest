using NUnit.Framework;

namespace StringConverter.Tests;

[TestFixture]
public class DivisorHandlerTests
{
    [Test]
    public void CreateTests_ReturnTestsList()
    {
        var dictionary = new Dictionary<int, string>
        {
            { 3, "fizz" },
            { 5, "buzz" }
        };

        var handlersFromFactory = DivisorHandlersFactory.CreateHandlers(dictionary);

        var handlersList = new List<DivisorHandler>
        {
            new DivisorHandler { Divisor = 3, ReturningString = "fizz" },
            new DivisorHandler { Divisor = 5, ReturningString = "buzz" }
        };
        
        CollectionAssert.AreEqual(handlersList, handlersFromFactory, "Коллекции не эквивалентны");

    }
    
}