namespace StringConverter;

public class DivisorHandler
{
    
    public int Divisor { get; set; }
    public string ReturningString { get; set; } = "";

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