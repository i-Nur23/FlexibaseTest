namespace StringConverter;

/// <summary>
/// Конвертер списка чисел в строку  
/// </summary>
public class NumbersConverter
{
    private readonly List<IDivisorHandler> _divisorHandlers;
    

    public NumbersConverter(List<IDivisorHandler> handlers)
    {
        _divisorHandlers = handlers;
    }

    /// <summary>
    /// Метод, конвертирующий список чисел в строку
    /// </summary>
    /// <param name="numbers">Список чисел</param>
    /// <returns>Новая строка с заменёнными числами</returns>
    public string ConvertNumbers(List<int> numbers)
    {
        List<string> resultStringArray = new List<string>();
        string swappedString;

        foreach (var number in numbers)
        {
            List<string> numberStringArray = new List<string>();

            foreach (var handler in _divisorHandlers)
            {
                if (handler.IsDividing(number, out swappedString))
                {
                    numberStringArray.Add(swappedString);
                }
            }

            if (numberStringArray.Count != 0)
            {
                resultStringArray.Add(String.Join('-', numberStringArray));
            }
            else
            {
                resultStringArray.Add(number.ToString());
            }
        }
        
        return String.Join(", ", resultStringArray);
    }
    
}