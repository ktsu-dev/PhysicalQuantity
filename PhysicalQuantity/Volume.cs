namespace ktsu.io.PhysicalQuantity;

using System.Numerics;

public record Volume<TStorage>(TStorage Quantity)
	: DerivedQuantity<Volume<TStorage>, TStorage, Area<TStorage>, Length<TStorage>>(Quantity)
	where TStorage : INumber<TStorage>
{
	protected override string SIUnitName => "cubic meter";
	protected override string SIUnitSymbol => "m³";
}
