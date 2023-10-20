namespace StringConverter;

/// <summary>
/// Класс, отвечающий за основную работу приложения 
/// </summary>
public class Application
{
    private readonly Dictionary<int[], string> _numberToStringSwaps;
    private readonly string _rawString;
    
    public Application(Dictionary<int[], string> numberToStringSwaps, string rawString)
    {
        _rawString = rawString;
        _numberToStringSwaps = numberToStringSwaps;
    }

    /// <summary>
    /// Метод запускающий механизм обработки строки в новую
    /// </summary>
    /// <returns>Новая строка или сообщение об ошибке</returns>
    public string Execute()
    {
        var divisorHandlers = DivisorHandlersFactory.CreateHandlers(_numberToStringSwaps);

        if (string.IsNullOrWhiteSpace(_rawString))
        {
            return "Вы вписали пустую строку";
        }

        List<int> numbersList;

        try
        {
            numbersList = _rawString
                .Split(",")
                .Select(str => int.Parse(str.Trim()))
                .ToList();
        }
        catch (Exception e)
        {
            return "Один из элементов строки не число";
        }


        var numbersHandler = new NumbersConverter(divisorHandlers);
        return numbersHandler.ConvertNumbers(numbersList);
    }
}