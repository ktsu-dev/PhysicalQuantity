namespace ktsu.io.PhysicalQuantity;

using System.Numerics;

public sealed record Mass<TStorage>(TStorage Quantity)
	: BaseQuantity<Mass<TStorage>, TStorage>(Quantity)
	where TStorage : INumber<TStorage>
{
	protected override string SIUnitName => "kilogram";
	protected override string SIUnitSymbol => "kg";
}
