using NUnit.Framework;

namespace StringConverter.Tests;

[TestFixture]
public class DivisorHandlerTests : Globalinitializer
{
    [Test]
    public void CreateTests_ReturnTestsList()
    {

        var handlersFromFactory = DivisorHandlersFactory.CreateHandlers(_dictionary);

        var handlersList = new List<DivisorHandler>
        {
            new DivisorHandler { Divisor = 3, ReturningString = "fizz" },
            new DivisorHandler { Divisor = 5, ReturningString = "buzz" },
            new DivisorHandler { Divisor = 4, ReturningString = "muzz" },
            new DivisorHandler { Divisor = 7, ReturningString = "guzz" }
        };
        
        CollectionAssert.AreEqual(handlersList, handlersFromFactory, "Коллекции не эквивалентны");

    }
    
}