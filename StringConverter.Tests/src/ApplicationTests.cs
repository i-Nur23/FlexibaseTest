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
    
    [Test]
    public void Execute_RightNumbers_ReturnRightResult()
    {
        var initString = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420";
        var outString =
            "1, 2, fizz, muzz, buzz, fizz, guzz, muzz, fizz, buzz, 11, fizz-muzz, 13, guzz, fizz-buzz, fizz-buzz-muzz, " +
            "fizz-buzz-guzz, fizz-buzz-muzz-guzz";
        
        var app = new Application(_dictionary, initString);

        var result = app.Execute();

        Assert.AreEqual(result, outString);
    }
}