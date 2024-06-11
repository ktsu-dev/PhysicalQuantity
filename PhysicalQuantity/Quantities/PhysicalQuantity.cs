// Ignore Spelling: ktsu

namespace ktsu.io.PhysicalQuantity.Generic;

using System.Numerics;
using System.Reflection;
using ktsu.io.PhysicalQuantity;
using ktsu.io.SemanticQuantity;

public abstract record PhysicalQuantity<TSelf, TStorage>
	: SemanticQuantity<TSelf, TStorage>
	where TSelf : PhysicalQuantity<TSelf, TStorage>, new()
	where TStorage : INumber<TStorage>
{
	private static SIUnitAttribute SIUnitAttribute { get; } = typeof(TSelf).GetCustomAttribute<SIUnitAttribute>() ?? new SIUnitAttribute(string.Empty, string.Empty, string.Empty);

	public sealed override string ToString()
	{
		string symbolComponent = string.IsNullOrWhiteSpace(SIUnitAttribute.Symbol) ? string.Empty : $" {SIUnitAttribute.Symbol}";
		var absQuantity = TStorage.Abs(Quantity);
		bool isPlural = absQuantity.CompareTo(TStorage.One) > 0;
		string pluralComponent = isPlural ? SIUnitAttribute.Plural : SIUnitAttribute.Singular;
		string nameComponent = string.IsNullOrWhiteSpace(pluralComponent) ? string.Empty : $" ({pluralComponent})";
		return $"{Quantity}{symbolComponent}{nameComponent}";
	}

	//public static TStorage ConvertToStorage<T1, T2>(TSelf quantity, T1 factor, T2 offset)
	//	where T1 : INumber<T1>
	//	where T2 : INumber<T2>
	//	=> (quantity.Quantity - TStorage.CreateChecked(offset)) / TStorage.CreateChecked(factor);

	//public static TSelf ConvertFromStorage<T1, T2>(TStorage value, T1 factor, T2 offset)
	//	where T1 : INumber<T1>
	//	where T2 : INumber<T2>
	//	=> Create<TSelf>((value * TStorage.CreateChecked(factor)) + TStorage.CreateChecked(offset));



}

public static class PhysicalQuantity
{
	public static TStorage ConvertToSIQuantity<TStorage, T1, T2>(TStorage value, T1 factor, T2 offset)
		where TStorage : INumber<TStorage>
		where T1 : INumber<T1>
		where T2 : INumber<T2>
		=> (value * TStorage.CreateChecked(factor)) + TStorage.CreateChecked(offset);

	public static TStorage ConvertToArbitraryQuantity<TStorage, T1, T2>(TStorage value, T1 factor, T2 offset)
		where TStorage : INumber<TStorage>
		where T1 : INumber<T1>
		where T2 : INumber<T2>
		=> (value - TStorage.CreateChecked(offset)) / TStorage.CreateChecked(factor);
}
