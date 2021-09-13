namespace ParseTests;

public class ExplicitSwitchTests : IEnumParseTests
{
    [Test]
    public void ParseString()
    {
        const string? value = "AUT";
        var result = ExplicitSwitchParser.Parse(value);
        Assert.AreEqual(Country.AUT, result);
    }

    [Test]
    public void ParseStringIgnoreCaseFails()
    {
        const string? value = "aut";
        Assert.Throws<ArgumentOutOfRangeException>(() => ExplicitSwitchParser.Parse(value));
    }

    [Test]
    public void ParseInvalidStringFails()
    {
        const string? value = "RUS";
        Assert.Throws<ArgumentOutOfRangeException>(() => ExplicitSwitchParser.Parse(value));
    }

    [Test]
    public void ParseNumber()
    {
        const string? value = "0";
        var result = ExplicitSwitchParser.Parse(value);
        Assert.AreEqual(Country.AUT, result);
    }

    [Test]
    public void ParseInvalidNumberFails()
    {
        const string? value = "-4";
        Assert.Throws<ArgumentOutOfRangeException>(() => ExplicitSwitchParser.Parse(value));
    }
}