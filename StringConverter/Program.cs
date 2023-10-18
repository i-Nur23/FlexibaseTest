// See https://aka.ms/new-console-template for more information

using StringConverter;

Dictionary<int, string> numbersAndStringsToConvert = new Dictionary<int, string>
{
    { 3, "fizz" },
    { 5, "buzz" }
};

var rawString = Console.ReadLine();

var app = new Application(numbersAndStringsToConvert, rawString);

Console.WriteLine(app.Execute());