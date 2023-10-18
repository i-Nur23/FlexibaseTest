using NUnit.Framework;

namespace StringConverter.Tests;

[TestFixture]
public class NumbersHandlerTests : Globalinitializer
{
    [TestCase(new int[]{1,2,4,7,11}, "1, 2, 4, 7, 11")]
    [TestCase(new int[]{4}, "4")]
    [TestCase(new int[]{1,2,3,6,5,7,15}, "1, 2, fizz, fizz, buzz, 7, fizz-buzz")]
    [TestCase(new int[]{3}, "fizz")]
    [TestCase(new int[]{5}, "buzz")]
    [TestCase(new int[]{15}, "fizz-buzz")]
    public void ConvertNumbers_NumbersWithoutOrWithDivisibles_ReturnsRightResult(int[] numbersArray, string expectedResult)
    {
        var numbersList = numbersArray.ToList();
        var divisorHandlers = DivisorHandlersFactory.CreateHandlers(_dictionary);
        var numbersHandler = new NumbersHandler(divisorHandlers);

        var givenResult = numbersHandler.ConvertNumbers(numbersList);
        
        Assert.AreEqual(givenResult, expectedResult, $"Должно было быть: {expectedResult}; вернулось: {givenResult}");
    }
}