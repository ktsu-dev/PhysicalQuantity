namespace ktsu.PhysicalQuantity;

[AttributeUsage(AttributeTargets.Class)]
public sealed class SIUnitAttribute(string symbol, string singular, string plural) : Attribute
{
	public string Symbol { get; init; } = symbol;
	public string Singular { get; init; } = singular;
	public string Plural { get; init; } = plural;
}
