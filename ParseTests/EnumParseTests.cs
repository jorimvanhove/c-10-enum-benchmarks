namespace Tests;

public class EnumParseTests : IEnumParseTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ParseString()
    {
        const string? value = "AUT";
        var result = Enum.Parse<Country>(value);
        Assert.AreEqual(Country.AUT, result);
    }
    
    [Test]
    public void ParseStringIgnoreCaseFails()
    {
        const string? value = "aut";
        Assert.Throws<ArgumentException>(() => Enum.Parse<Country>(value));
    }
    
    [Test]
    public void ParseInvalidStringFails()
    {
        const string? value = "RUS";
        Assert.Throws<ArgumentException>(() => Enum.Parse<Country>(value));
    }
    
    [Test]
    public void ParseNumber()
    {
        const string? value = "0";
        var result = Enum.Parse<Country>(value);
        Assert.AreEqual(Country.AUT, result);
    }
    
    [Test]
    public void ParseInvalidNumberFails()
    {
        const string? value = "-4";
        var result = Enum.Parse<Country>(value);
        Assert.Throws<ArgumentException>(() => Enum.Parse<Country>(value));
    }
}