[assembly: CLSCompliant(true)]
[assembly: System.Runtime.InteropServices.ComVisible(false)]

namespace ktsu.PhysicalQuantity.Generic;

using System;
using System.Numerics;
using System.Reflection;
using ktsu.SemanticQuantity;
using ktsu.SignificantNumber;

/// <summary>
/// Represents a physical quantity with a specific unit of measurement.
/// </summary>
/// <typeparam name="TSelf">The type of the derived class.</typeparam>
public abstract record PhysicalQuantity<TSelf>
	: SemanticQuantity<TSelf, SignificantNumber>
	, IComparable<TSelf>
	where TSelf : PhysicalQuantity<TSelf>, new()
{
	private static SIUnitAttribute SIUnitAttribute { get; } = typeof(TSelf).GetCustomAttribute<SIUnitAttribute>() ?? new SIUnitAttribute(string.Empty, string.Empty, string.Empty);

	public int CompareTo(TSelf? other) => other is null ? 1 : Quantity.CompareTo(other.Quantity);

	/// <summary>
	/// Returns a string representation of the physical quantity, including its unit symbol and name.
	/// </summary>
	/// <returns>A string that represents the physical quantity.</returns>
	public sealed override string ToString()
	{
		string symbolComponent = string.IsNullOrWhiteSpace(SIUnitAttribute.Symbol) ? string.Empty : $" {SIUnitAttribute.Symbol}";
		var absQuantity = Quantity.Abs();
		bool isPlural = absQuantity > 1.ToSignificantNumber();
		string pluralComponent = isPlural ? SIUnitAttribute.Plural : SIUnitAttribute.Singular;
		string nameComponent = string.IsNullOrWhiteSpace(pluralComponent) ? string.Empty : $" ({pluralComponent})";
		return $"{Quantity}{symbolComponent}{nameComponent}";
	}

	public static bool operator <(PhysicalQuantity<TSelf> left, TSelf right) =>
		left is null ? right is not null : left.CompareTo(right) < 0;

	public static bool operator <=(PhysicalQuantity<TSelf> left, TSelf right) =>
		left is null || left.CompareTo(right) <= 0;

	public static bool operator >(PhysicalQuantity<TSelf> left, TSelf right) =>
		left is not null && left.CompareTo(right) > 0;

	public static bool operator >=(PhysicalQuantity<TSelf> left, TSelf right) =>
		left is null ? right is null : left.CompareTo(right) >= 0;

	public TSelf Pow<TPower>(TPower power)
		where TPower : INumber<TPower>
	{
		ArgumentNullException.ThrowIfNull(power);

		return Create(Quantity.Pow(power.ToSignificantNumber()));
	}

	public TSelf Abs() => Create(Quantity.Abs());

	public TSelf Clamp<T1, T2>(T1 min, T2 max)
		where T1 : INumber<T1>
		where T2 : INumber<T2>
		=> Create(Quantity.Clamp(min.ToSignificantNumber(), max.ToSignificantNumber()));

	protected TSelf ConversionAdd(SignificantNumber other)
	{
		ArgumentNullException.ThrowIfNull(other);

		return Create(Quantity + other);
	}
}

/// <summary>
/// Provides static methods for converting values to and from physical quantities.
/// </summary>
public static class PhysicalQuantity
{
	/// <summary>
	/// Converts a numeric value to a specific physical quantity type with a given conversion factor and offset.
	/// </summary>
	/// <typeparam name="TInput">The type of the input numeric value.</typeparam>
	/// <typeparam name="TQuantity">The type of the physical quantity to convert to.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <param name="factor">The conversion factor to apply.</param>
	/// <param name="offset">The conversion offset to apply.</param>
	/// <returns>A new instance of the specified physical quantity type.</returns>
	public static TQuantity ConvertToQuantity<TInput, TQuantity>(this TInput value, SignificantNumber factor, SignificantNumber offset)
		where TQuantity : PhysicalQuantity<TQuantity>, new()
		where TInput : INumber<TInput>
		=> PhysicalQuantity<TQuantity>.Create((value.ToSignificantNumber() * factor.ToSignificantNumber()) + offset.ToSignificantNumber());

	/// <summary>
	/// Converts a numeric value to a specific physical quantity type with a given conversion factor.
	/// </summary>
	/// <typeparam name="TInput">The type of the input numeric value.</typeparam>
	/// <typeparam name="TQuantity">The type of the physical quantity to convert to.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <param name="factor">The conversion factor to apply.</param>
	/// <returns>A new instance of the specified physical quantity type.</returns>
	public static TQuantity ConvertToQuantity<TInput, TQuantity>(this TInput value, SignificantNumber factor)
		where TQuantity : PhysicalQuantity<TQuantity>, new()
		where TInput : INumber<TInput>
		=> PhysicalQuantity<TQuantity>.Create(value.ToSignificantNumber() * factor.ToSignificantNumber());

	/// <summary>
	/// Converts a numeric value to a specific physical quantity type without any conversion factor or offset.
	/// </summary>
	/// <typeparam name="TInput">The type of the input numeric value.</typeparam>
	/// <typeparam name="TQuantity">The type of the physical quantity to convert to.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A new instance of the specified physical quantity type.</returns>
	public static TQuantity ConvertToQuantity<TInput, TQuantity>(this TInput value)
		where TQuantity : PhysicalQuantity<TQuantity>, new()
		where TInput : INumber<TInput>
		=> PhysicalQuantity<TQuantity>.Create(value.ToSignificantNumber());

	/// <summary>
	/// Converts a physical quantity to a numeric value with a given conversion factor and offset.
	/// </summary>
	/// <typeparam name="TQuantity">The type of the physical quantity to convert from.</typeparam>
	/// <param name="value">The physical quantity to convert.</param>
	/// <param name="factor">The conversion factor to apply.</param>
	/// <param name="offset">The conversion offset to apply.</param>
	/// <returns>The numeric value representing the converted physical quantity.</returns>
	public static SignificantNumber ConvertToNumber<TQuantity>(this TQuantity value, SignificantNumber factor, SignificantNumber offset)
		where TQuantity : PhysicalQuantity<TQuantity>, new()
	{
		ArgumentNullException.ThrowIfNull(value);

		return (value.Quantity.ToSignificantNumber() - offset.ToSignificantNumber()) / factor.ToSignificantNumber();
	}

	/// <summary>
	/// Converts a physical quantity to a numeric value with a given conversion factor.
	/// </summary>
	/// <typeparam name="TQuantity">The type of the physical quantity to convert from.</typeparam>
	/// <param name="value">The physical quantity to convert.</param>
	/// <param name="factor">The conversion factor to apply.</param>
	/// <returns>The numeric value representing the converted physical quantity.</returns>
	public static SignificantNumber ConvertToNumber<TQuantity>(this TQuantity value, SignificantNumber factor)
		where TQuantity : PhysicalQuantity<TQuantity>, new()
	{
		ArgumentNullException.ThrowIfNull(value);

		return value.Quantity.ToSignificantNumber() / factor.ToSignificantNumber();
	}

	/// <summary>
	/// Converts a physical quantity to a numeric value without any conversion factor or offset.
	/// </summary>
	/// <typeparam name="TQuantity">The type of the physical quantity to convert from.</typeparam>
	/// <param name="value">The physical quantity to convert.</param>
	/// <returns>The numeric value representing the converted physical quantity.</returns>
	public static SignificantNumber ConvertToNumber<TQuantity>(this TQuantity value)
		where TQuantity : PhysicalQuantity<TQuantity>, new()
	{
		ArgumentNullException.ThrowIfNull(value);

		return value.Quantity;
	}
}
