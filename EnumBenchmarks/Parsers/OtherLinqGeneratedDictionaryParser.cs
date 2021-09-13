using System.Linq;

namespace EnumBenchmarks.Parsers;

/// <summary>
/// Copied from https://github.com/mariuszwojcik/Blog-posts-code
/// </summary>
/// <typeparam name="TTarget"></typeparam>
public static class OtherLinqGeneratedDictionaryParser<TTarget>
{
    static OtherLinqGeneratedDictionaryParser()
    {
        Dict =
            Enum
                .GetValues(typeof(TTarget))
                .Cast<TTarget>()
                .SelectMany(v =>
                    new[] {
                        (n: v!.ToString(), v),
                        (n: Convert.ToInt32(v).ToString(), v)
                    })
                .ToDictionary(i => i.n, i => i.v, StringComparer.OrdinalIgnoreCase);
    }

    private static readonly Dictionary<string, TTarget> Dict;

    public static TTarget Parse(string value)
    {
        return Dict[value];
    }
}