using NUnit.Framework;

namespace StringConverter.Tests;

[TestFixture]
public class ApplicationTests : Globalinitializer
{
    
    [TestCase("")]
    [TestCase("             ")]
    public void Execute_EmptyString_ReturnErrorString(string value)
    {
        var app = new Application(_dictionary, value);

        var result = app.Execute();

        Assert.AreEqual(result, "Вы вписали пустую строку");
    }
    
    [TestCase("1,2,3,,4,5")]
    [TestCase("1,abc,2")]
    public void Execute_WrongNumbers_ReturnErrorString(string value)
    {
        var app = new Application(_dictionary, value);

        var result = app.Execute();

        Assert.AreEqual(result, "Один из элементов строки не число");
    }
    
    [TestCase("1,2,3,4,5", "1, 2, fizz, 4, buzz")]
    [TestCase("1", "1")]
    [TestCase("15", "fizz-buzz")]
    public void Execute_RightNumbers_ReturnRightResult(string value, string expectedResult)
    {
        var app = new Application(_dictionary, value);

        var result = app.Execute();

        Assert.AreEqual(result, expectedResult);
    }
}