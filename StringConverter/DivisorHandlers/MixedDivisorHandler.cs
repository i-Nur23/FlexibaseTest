namespace StringConverter;

/// <summary>
/// Класс для обработки комплексных делителей
/// </summary>
public class MixedDivisorHandler : IDivisorHandler
{
    public List<IDivisorHandler> DivisorHandlers { get; set; }
    
    public string ReturningString { get; set; } = "";
    public int Divisor { get; set; }
    
    /// <summary>
    /// Метод конвертации числа в строку
    /// </summary>
    /// <param name="dividend">Делимое</param>
    /// <param name="result">Возвращаемая строка, заменяющая число</param>
    /// <returns>true, если divident делится нацело на divisor или на его составные части, иначе false</returns>
    public bool IsDividing(int dividend, out string result)
    {
        result = "";
        
        if (DivisorHandlers.All(d => d.IsDividing(dividend, out _)))
        {
            result = ReturningString;
            return true;
        } 
        
        List<string> elements = new List<string>();
        foreach (var handler in DivisorHandlers)
        {
            if (handler.IsDividing(dividend, out string part))
            {
                elements.Add(part);
            }
        }
            
        if (elements.Count == 0)
        {
            return false;
        }
            
        result = String.Join("-", elements);

        return true;
    }

    public override bool Equals(object? obj)
    {
        if (obj is MixedDivisorHandler handler)
        {
            return handler.Divisor == this.Divisor 
                   && string.Equals(handler.ReturningString, this.ReturningString) 
                   && Enumerable.SequenceEqual(handler.DivisorHandlers, this.DivisorHandlers);
        }

        return false;
    }
}