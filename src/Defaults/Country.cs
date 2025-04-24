namespace underware.Edi.Common.Defaults;

public class Country(string code, string name)
{
    public string Code { get; set; } = code;
    public string Name { get; set; } = name;
    
    public static Country[] All =>
    [
        new Country("AT", "Austria"),
        new Country("BE", "Belgium"),
        new Country("BG", "Bulgaria"),
        new Country("HR", "Croatia"),
        new Country("CY", "Cyprus"),
        new Country("CZ", "Czech Republic"),
        new Country("DK", "Denmark"),
        new Country("EE", "Estonia"),
        new Country("FI", "Finland"),
        new Country("FR", "France"),
        new Country("DE", "Germany"),
        new Country("GR", "Greece"),
        new Country("HU", "Hungary"),
        new Country("IE", "Ireland"),
        new Country("IT", "Italy"),
        new Country("LV", "Latvia"),
        new Country("LT", "Lithuania"),
        new Country("LU", "Luxembourg"),
        new Country("MT", "Malta"),
        new Country("NL", "Netherlands"),
        new Country("PL", "Poland"),
        new Country("PT", "Portugal"),
        new Country("RO", "Romania"),
        new Country("SK", "Slovakia"),
        new Country("SI", "Slovenia"),
        new Country("ES", "Spain"),
        new Country("SE", "Sweden")
    ];


    public static Country GetCountry(string code)
    {
        return All.FirstOrDefault(c => c.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
    }
}