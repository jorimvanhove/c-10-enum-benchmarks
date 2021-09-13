namespace EnumBenchmarks;

public class Benchmarks
{
    [Benchmark]
    [Arguments("AUT")]
    [Arguments("BEL")]
    [Arguments("FIN")]
    [Arguments("SWE")]
    public Country UsingDefaultParse(string value)
    {
        return Enum.Parse<Country>(value);
    } 
    
    [Benchmark]
    [Arguments("AUT")]
    [Arguments("BEL")]
    [Arguments("FIN")]
    [Arguments("SWE")]
    public Country UsingGenericLinqGeneratedDictionaryParser(string value)
    {
        return LinqGeneratedDictionaryParser<Country>.Parse(value);
    }

    [Benchmark]
    [Arguments("AUT")]
    [Arguments("BEL")]
    [Arguments("FIN")]
    [Arguments("SWE")]
    public Country UsingOtherGenericLinqGeneratedDictionaryParser(string value)
    {
        return OtherLinqGeneratedDictionaryParser<Country>.Parse(value);
    }
    
    [Benchmark]
    [Arguments("AUT")]
    [Arguments("BEL")]
    [Arguments("FIN")]
    [Arguments("SWE")]
    public Country UsingExplicitDictionaryParser(string value)
    {
        return ExplicitDictionaryParser.Parse(value);
    }

    [Benchmark(Baseline = true)]
    [Arguments("AUT")]
    [Arguments("BEL")]
    [Arguments("FIN")]
    [Arguments("SWE")]
    public Country UsingSwitch(string value)
    {   
        return ExplicitSwitchParser.Parse(value);
    }
}