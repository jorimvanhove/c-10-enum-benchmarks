namespace ParseTests;

public class EnumTryParseTests : IEnumParseTests
{
    [Test]
    public void ParseString()
    {
        const string? value = "AUT";
        Country country;
        var result = Enum.TryParse<Country>(value, out country);
        Assert.IsTrue(result);
        Assert.AreEqual(Country.AUT, country);
    }
    
    [Test]
    public void ParseStringIgnoreCaseFails()
    {
        const string? value = "aut";
        Country country;
        var result = Enum.TryParse<Country>(value, out country);
        Assert.IsFalse(result);
    }
    
    [Test]
    public void ParseInvalidStringFails()
    {
        const string? value = "RUS";
        Country country;
        var result = Enum.TryParse<Country>(value, out country);
        Assert.IsFalse(result);
    }
    
    [Test]
    public void ParseNumber()
    {
        const string? value = "0";
        Country country;
        var result = Enum.TryParse<Country>(value, out country);
        Assert.IsTrue(result);
        Assert.AreEqual(Country.AUT, country);
    }
    
    [Test]
    public void ParseInvalidNumberFails()
    {
        const string? value = "-4";
        Country country;
        var result = Enum.TryParse<Country>(value, out country);
        Assert.IsFalse(result);
        Assert.AreNotEqual(Country.AUT, country);
    }
}