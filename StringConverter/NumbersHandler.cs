using System.Text;
using Microsoft.VisualBasic;

namespace StringConverter;

public class NumbersHandler
{
    private readonly List<DivisorHandler> _dividerHandlers;
    

    public NumbersHandler(List<DivisorHandler> handlers)
    {
        _dividerHandlers = handlers;
    }

    public string ConvertNumbers(List<int> numbers)
    {
        string swappedString;
        List<string> resultStringArray = new List<string>();

        foreach (var number in numbers)
        {
            List<string> numberStringArray = new List<string>();

            foreach (var handler in _dividerHandlers)
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