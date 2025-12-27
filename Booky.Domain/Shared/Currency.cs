namespace Booky.Domain.Shared;

public record Currency
{
    internal static readonly Currency None = new("");
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Eur = new("EUR");
    public static readonly Currency Gbp = new("GBP");
    public static readonly Currency Cad = new("CAD");
    
    private Currency(string code) => Code = code;
    
    public string Code { get; init; }

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(x => x.Code == code)
            ?? throw new ApplicationException($"Unsupported currency code");
    }
    
    public static readonly IReadOnlyCollection<Currency> All = new[]
    {
        Usd,
        Eur,
        Gbp,
        Cad
    };
}