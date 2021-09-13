namespace EnumBenchmarks.Parsers;
public static class ExplicitSwitchParser
{
    public static Country Parse(string value)
    {
        return value switch
        {
            "AUT" => Country.AUT,
            "BEL" => Country.BEL,
            "BGR" => Country.BGR,
            "CHE" => Country.CHE,
            "CZE" => Country.CZE,
            "DEU" => Country.DEU,
            "DNK" => Country.DNK,
            "ESP" => Country.ESP,
            "EST" => Country.EST,
            "FIN" => Country.FIN,
            "FRA" => Country.FRA,
            "GBR" => Country.GBR,
            "GRC" => Country.GRC,
            "HRV" => Country.HRV,
            "HUN" => Country.HUN,
            "IRL" => Country.IRL,
            "ITA" => Country.ITA,
            "LIE" => Country.LIE,
            "LTU" => Country.LTU,
            "LUX" => Country.LUX,
            "LVA" => Country.LVA,
            "NLD" => Country.NLD,
            "NOR" => Country.NOR,
            "POL" => Country.POL,
            "PRT" => Country.PRT,
            "ROU" => Country.ROU,
            "SVK" => Country.SVK,
            "SVN" => Country.SVN,
            "SWE" => Country.SWE,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };
    }
}