using NUnit.Framework;

namespace StringConverter.Tests;

public class Globalinitializer
{
    protected Dictionary<int[], string> _dictionary;
    
    [SetUp]
    public void SetUp()
    {
        _dictionary = new Dictionary<int[], string>
        {
            { new []{3}, "dog" },
            { new []{5}, "cat" },
            { new []{4}, "muzz" },
            { new []{7}, "guzz" },
            { new []{3, 5}, "good-boy" }
        };
    }
}