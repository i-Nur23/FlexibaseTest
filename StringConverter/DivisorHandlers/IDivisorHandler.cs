namespace StringConverter;

public interface IDivisorHandler
{
    public string ReturningString { get; set; }
    public int Divisor { get; set; }
    
    public bool IsDividing(int dividend, out string result);
}