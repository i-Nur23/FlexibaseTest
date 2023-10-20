using NUnit.Framework;

namespace StringConverter.Tests;

[TestFixture]
public class NumbersHandlerTests : Globalinitializer
{
    [TestCase(new int[]{1,2,11}, "1, 2, 11")]
    [TestCase(new int[]{1,2,4,7,11}, "1, 2, muzz, guzz, 11")]
    [TestCase(new int[]{17}, "17")]
    [TestCase(new int[]{7}, "guzz")]
    [TestCase(new int[]{4}, "muzz")]
    [TestCase(new int[]{3}, "dog")]
    [TestCase(new int[]{5}, "cat")]
    [TestCase(new int[]{15}, "good-boy")]
    [TestCase(new int[]{28}, "muzz-guzz")]
    [TestCase(new int[]{420},"good-boy-muzz-guzz")]
    [TestCase(new int[]{105},"good-boy-guzz")]
    public void ConvertNumbers_NumbersWithoutOrWithDivisibles_ReturnsRightResult(int[] numbersArray, string expectedResult)
    {
        var numbersList = numbersArray.ToList();
        var divisorHandlers = DivisorHandlersFactory.CreateHandlers(_dictionary);
        var numbersHandler = new NumbersConverter(divisorHandlers);

        var givenResult = numbersHandler.ConvertNumbers(numbersList);
        
        Assert.AreEqual(givenResult, expectedResult, $"Должно было быть: {expectedResult}; вернулось: {givenResult}");
    }
}