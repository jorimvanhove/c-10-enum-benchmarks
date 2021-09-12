namespace EnumBenchmarks.Parsers;

/// <summary>
/// Copied from https://stackoverflow.com/a/34775560
/// </summary>
/// <typeparam name="TTarget"></typeparam>
public static class LinqGeneratedDictionaryParser<TTarget>
{
    static LinqGeneratedDictionaryParser()
    {
        Dict = Enum.GetNames(typeof(TTarget)).ToDictionary(x => x, x => (TTarget)Enum.Parse(typeof(TTarget), x), StringComparer.OrdinalIgnoreCase);
    }

    private static readonly Dictionary<string, TTarget> Dict;

    public static TTarget Parse(string value)
    {
        return Dict[value];
    }
}