using NUnit.Framework;

namespace StringConverter.Tests;

public class Globalinitializer
{
    protected Dictionary<int, string> _dictionary;
    
    [SetUp]
    public void SetUp()
    {
        _dictionary = new Dictionary<int, string>
        {
            { 3, "fizz" },
            { 5, "buzz" }
        };
    }
}