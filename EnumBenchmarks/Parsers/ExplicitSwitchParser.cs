namespace EnumBenchmarks.Parsers;
public static class ExplicitSwitchParser
{
    public static Countries Parse(string value)
    {
        return value switch
        {
            "AUT" => Countries.AUT,
            "BEL" => Countries.BEL,
            "BGR" => Countries.BGR,
            "CHE" => Countries.CHE,
            "CZE" => Countries.CZE,
            "DEU" => Countries.DEU,
            "DNK" => Countries.DNK,
            "ESP" => Countries.ESP,
            "EST" => Countries.EST,
            "FIN" => Countries.FIN,
            "FRA" => Countries.FRA,
            "GBR" => Countries.GBR,
            "GRC" => Countries.GRC,
            "HRV" => Countries.HRV,
            "HUN" => Countries.HUN,
            "IRL" => Countries.IRL,
            "ITA" => Countries.ITA,
            "LIE" => Countries.LIE,
            "LTU" => Countries.LTU,
            "LUX" => Countries.LUX,
            "LVA" => Countries.LVA,
            "NLD" => Countries.NLD,
            "NOR" => Countries.NOR,
            "POL" => Countries.POL,
            "PRT" => Countries.PRT,
            "ROU" => Countries.ROU,
            "SVK" => Countries.SVK,
            "SVN" => Countries.SVN,
            "SWE" => Countries.SWE,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };
    }
}