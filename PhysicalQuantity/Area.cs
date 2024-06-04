namespace ktsu.io.PhysicalQuantity;

using System.Numerics;

public record Area<TStorage>(TStorage Quantity)
	: DerivedQuantity<Area<TStorage>, TStorage, Length<TStorage>, Volume<TStorage>, Length<TStorage>>(Quantity)
	where TStorage : INumber<TStorage>
{
	protected override string SIUnitName => "square meter";
	protected override string SIUnitSymbol => "m²";
}
