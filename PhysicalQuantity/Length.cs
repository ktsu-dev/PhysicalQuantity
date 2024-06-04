namespace ktsu.io.PhysicalQuantity;

using System.Numerics;

public sealed record Length<TStorage>(TStorage Quantity)
	: BaseQuantity<Length<TStorage>, TStorage, Area<TStorage>>(Quantity)
	where TStorage : INumber<TStorage>
{
	protected override string SIUnitName => "meter";
	protected override string SIUnitSymbol => "m";
}
