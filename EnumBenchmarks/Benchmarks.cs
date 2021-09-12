namespace EnumBenchmarks;

public class Benchmarks
{
    [Benchmark(Baseline = true)]
    [Arguments("AUT")]
    [Arguments("BEL")]
    [Arguments("FIN")]
    [Arguments("SWE")]
    public Countries UsingDefaultParse(string value)
    {
        return Enum.Parse<Countries>(value);
    } 
    
    [Benchmark]
    [Arguments("AUT")]
    [Arguments("BEL")]
    [Arguments("FIN")]
    [Arguments("SWE")]
    public Countries UsingGenericLinqGeneratedDictionaryParser(string value)
    {
        return LinqGeneratedDictionaryParser<Countries>.Parse(value);
    }

    [Benchmark]
    [Arguments("AUT")]
    [Arguments("BEL")]
    [Arguments("FIN")]
    [Arguments("SWE")]
    public Countries UsingOtherGenericLinqGeneratedDictionaryParser(string value)
    {
        return OtherLinqGeneratedDictionaryParser<Countries>.Parse(value);
    }
    
    [Benchmark]
    [Arguments("AUT")]
    [Arguments("BEL")]
    [Arguments("FIN")]
    [Arguments("SWE")]
    public Countries UsingExplicitDictionaryParser(string value)
    {
        return ExplicitDictionaryParser.Parse(value);
    }

    [Benchmark]
    [Arguments("AUT")]
    [Arguments("BEL")]
    [Arguments("FIN")]
    [Arguments("SWE")]
    public Countries UsingSwitch(string value)
    {   
        return ExplicitSwitchParser.Parse(value);
    }
}