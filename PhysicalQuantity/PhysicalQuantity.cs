namespace ktsu.io.PhysicalQuantity;

using System.Numerics;
using Humanizer;
using ktsu.io.SemanticQuantity;

public abstract record PhysicalQuantity<TSelf, TStorage>(TStorage Quantity)
	: SemanticQuantity<TSelf, TStorage>(Quantity)
	where TSelf : PhysicalQuantity<TSelf, TStorage>
	where TStorage : INumber<TStorage>
{
	protected abstract string SIUnitName { get; }
	protected abstract string SIUnitSymbol { get; }

	public sealed override string ToString()
	{
		string symbolComponent = string.IsNullOrWhiteSpace(SIUnitSymbol) ? string.Empty : $" {SIUnitSymbol}";
		string nameComponent = string.IsNullOrWhiteSpace(SIUnitName) ? string.Empty : $" ({SIUnitName.ToQuantity(double.CreateChecked(Quantity))})";
		return $"{Quantity}{symbolComponent}{nameComponent}";
	}
}
