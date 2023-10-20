using NUnit.Framework;

namespace StringConverter.Tests;

[TestFixture]
public class DivisorHandlerTests : Globalinitializer
{
    [Test]
    public void CreateTests_ReturnTestsList()
    {

        var handlersFromFactory = DivisorHandlersFactory.CreateHandlers(_dictionary);

        var handlersList = new List<IDivisorHandler>
        {
            new MixedDivisorHandler
            {
                Divisor = 15, 
                ReturningString = "good-boy",
                DivisorHandlers = new List<IDivisorHandler>
                {
                    new DivisorHandler {Divisor = 3, ReturningString = "dog"},
                    new DivisorHandler {Divisor = 5, ReturningString = "cat"},
                }
            },
            new DivisorHandler { Divisor = 4, ReturningString = "muzz" },
            new DivisorHandler { Divisor = 7, ReturningString = "guzz" },
            
        };
        
        CollectionAssert.AreEquivalent(handlersList, handlersFromFactory, "Коллекции не эквивалентны");

    }
    
}