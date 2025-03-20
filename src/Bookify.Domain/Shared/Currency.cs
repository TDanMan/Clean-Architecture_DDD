namespace Bookify.Domain.Shared;
public record Currency
{
    internal static readonly Currency None = new(string.Empty);
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Eur = new("EUR");
    public Currency(string code) => Code = code;
    public string Code { get; set; }
    public static Currency FromCode(string code) => All.FirstOrDefault(c => c.Code == code) ?? throw new ApplicationException("Invalid currency code");
    public static readonly IReadOnlyCollection<Currency> All = [Usd, Eur];
}
