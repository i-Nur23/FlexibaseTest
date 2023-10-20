namespace StringConverter;

/// <summary>
/// Фабрика для получения списка обработчиков делителей из словаря
/// </summary>
public static class DivisorHandlersFactory
{
    /// <summary>
    /// Метод конвертирующий словарь в список обработчиков делителей
    /// </summary>
    /// <param name="dictionary">Словарь типа массив_чисел-новая_строка</param>
    /// <returns>Список обрабочтиков</returns>
    public static List<IDivisorHandler> CreateHandlers(Dictionary<int[], string> dictionary)
    {
        dictionary = dictionary
            .OrderBy(pair => pair.Key.Length)
            .ToDictionary(x => x.Key, x => x.Value);
        
        List<IDivisorHandler> handlers = new List<IDivisorHandler>();
        
        foreach (var pair in dictionary)
        {
            if (pair.Key.Length == 1)
            {
                handlers.Add(new DivisorHandler { Divisor = pair.Key[0], ReturningString = pair.Value });
            }
            else
            {
                var handlerParts = handlers
                    .Where(h => pair.Key.Contains(h.Divisor))
                    .ToList();
                
                handlers.Insert(0, new MixedDivisorHandler{ 
                    DivisorHandlers = handlerParts, 
                    ReturningString = pair.Value, 
                    Divisor = pair.Key.Aggregate(1, (a,b) => a * b)
                });

                handlers = handlers
                    .Where(h => !pair.Key.Contains(h.Divisor))
                    .ToList();
            }
        }

        return handlers;
    }
}