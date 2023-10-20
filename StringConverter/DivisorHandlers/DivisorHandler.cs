namespace StringConverter;

/// <summary>
/// Класс для обработки одинарного делителя
/// </summary>
public class DivisorHandler : IDivisorHandler
{
    public string ReturningString { get; set; } = "";
    public int Divisor { get; set; }

    /// <summary>
    /// Метод конвертации числа в строку
    /// </summary>
    /// <param name="dividend">Делимое</param>
    /// <param name="result">Возвращаемая строка, заменяющая число</param>
    /// <returns>true, если divident делится нацело на divisor, иначе false</returns>
    public bool IsDividing(int dividend, out string result)
    {
        var isDividing = dividend % Divisor == 0;
        result = ReturningString;
        return isDividing;
    }
    
    

    public override bool Equals(object? obj)
    {
        if (obj is DivisorHandler handler)
        {
            return handler.Divisor == this.Divisor && string.Equals(handler.ReturningString, this.ReturningString);
        }

        return false;
    }
}