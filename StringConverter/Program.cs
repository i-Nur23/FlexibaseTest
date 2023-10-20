// See https://aka.ms/new-console-template for more information

using StringConverter;

Dictionary<int[], string> numbersAndStringsToConvert = new Dictionary<int[], string>
{
    { new []{3}, "dog" },
    { new []{5}, "cat" },
    { new []{4}, "muzz" },
    { new []{7}, "guzz" },
    { new []{3, 5}, "good-boy" }
};

var rawString = Console.ReadLine();

var app = new Application(numbersAndStringsToConvert, rawString);

Console.WriteLine(app.Execute());