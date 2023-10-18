namespace StringConverter;

public static class DivisorHandlersFactory
{
    public static List<DivisorHandler> CreateHandlers(Dictionary<int, string> dictionary)
    {
        List<DivisorHandler> handlers = new List<DivisorHandler>();
        
        foreach (var pair in dictionary)
        {
            handlers.Add(new DivisorHandler { Divisor = pair.Key, ReturningString = pair.Value });
        }

        return handlers;
    }
}