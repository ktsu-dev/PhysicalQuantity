// Copyright (c) ktsu.dev
// All rights reserved.
// Licensed under the MIT license.

[assembly: CLSCompliant(true)]
[assembly: System.Runtime.InteropServices.ComVisible(false)]

namespace ktsu.PhysicalQuantity.Generic;

using System.Numerics;
using System.Reflection;

using ktsu.PreciseNumber;
using ktsu.SemanticQuantity;

using StorageType = SignificantNumber.SignificantNumber;

/// <summary>
/// Represents a physical quantity with a specific unit of measurement.
/// </summary>
/// <typeparam name="TSelf">The type of the derived class.</typeparam>
public abstract record PhysicalQuantity<TSelf>
	: SemanticQuantity<TSelf, StorageType>
	, IComparable<TSelf>
	where TSelf : PhysicalQuantity<TSelf>, new()
{
	/// <summary>
	/// Gets the SI unit attribute associated with the derived class.
	/// </summary>
	private static SIUnitAttribute SIUnitAttribute { get; } = typeof(TSelf).GetCustomAttribute<SIUnitAttribute>() ?? new SIUnitAttribute(string.Empty, string.Empty, string.Empty);

	/// <summary>
	/// Compares the current physical quantity to another instance of the same type.
	/// </summary>
	/// <param name="other">The other physical quantity to compare to.</param>
	/// <returns>
	/// A value less than zero if this instance is less than <paramref name="other"/>, 
	/// zero if they are equal, or a value greater than zero if this instance is greater than <paramref name="other"/>.
	/// </returns>
	public int CompareTo(TSelf? other) => other is null ? 1 : Quantity.CompareTo(other.Quantity);

	/// <summary>
	/// Returns a string representation of the physical quantity, including its unit symbol and name.
	/// </summary>
	/// <returns>A string that represents the physical quantity.</returns>
	public sealed override string ToString()
	{
		var symbolComponent = string.IsNullOrWhiteSpace(SIUnitAttribute.Symbol) ? string.Empty : $" {SIUnitAttribute.Symbol}";
		var absQuantity = Quantity.Abs();
		var isPlural = absQuantity.To<int>() > 1;
		var pluralComponent = isPlural ? SIUnitAttribute.Plural : SIUnitAttribute.Singular;
		var nameComponent = string.IsNullOrWhiteSpace(pluralComponent) ? string.Empty : $" ({pluralComponent})";
		return $"{Quantity}{symbolComponent}{nameComponent}";
	}

	/// <summary>
	/// Determines whether one physical quantity is less than another.
	/// </summary>
	/// <param name="left">The first physical quantity.</param>
	/// <param name="right">The second physical quantity.</param>
	/// <returns>True if <paramref name="left"/> is less than <paramref name="right"/>; otherwise, false.</returns>
	public static bool operator <(PhysicalQuantity<TSelf> left, TSelf right) =>
		left is null ? right is not null : left.CompareTo(right) < 0;

	/// <summary>
	/// Determines whether one physical quantity is less than or equal to another.
	/// </summary>
	/// <param name="left">The first physical quantity.</param>
	/// <param name="right">The second physical quantity.</param>
	/// <returns>True if <paramref name="left"/> is less than or equal to <paramref name="right"/>; otherwise, false.</returns>
	public static bool operator <=(PhysicalQuantity<TSelf> left, TSelf right) =>
		left is null || left.CompareTo(right) <= 0;

	/// <summary>
	/// Determines whether one physical quantity is greater than another.
	/// </summary>
	/// <param name="left">The first physical quantity.</param>
	/// <param name="right">The second physical quantity.</param>
	/// <returns>True if <paramref name="left"/> is greater than <paramref name="right"/>; otherwise, false.</returns>
	public static bool operator >(PhysicalQuantity<TSelf> left, TSelf right) =>
		left is not null && left.CompareTo(right) > 0;

	/// <summary>
	/// Determines whether one physical quantity is greater than or equal to another.
	/// </summary>
	/// <param name="left">The first physical quantity.</param>
	/// <param name="right">The second physical quantity.</param>
	/// <returns>True if <paramref name="left"/> is greater than or equal to <paramref name="right"/>; otherwise, false.</returns>
	public static bool operator >=(PhysicalQuantity<TSelf> left, TSelf right) =>
		left is null ? right is null : left.CompareTo(right) >= 0;

	/// <summary>
	/// Raises the physical quantity to the specified power.
	/// </summary>
	/// <typeparam name="TPower">The type of the power value.</typeparam>
	/// <param name="power">The power to raise the quantity to.</param>
	/// <returns>A new instance of the physical quantity raised to the specified power.</returns>
	/// <exception cref="ArgumentNullException">Thrown if <paramref name="power"/> is null.</exception>
	public TSelf Pow<TPower>(TPower power)
		where TPower : INumber<TPower>
	{
		ArgumentNullException.ThrowIfNull(power);

		return Create(Quantity.Pow(power.ToPreciseNumber()));
	}

	/// <summary>
	/// Returns the absolute value of the physical quantity.
	/// </summary>
	/// <returns>A new instance of the physical quantity with an absolute value.</returns>
	public TSelf Abs() => Create(new(Quantity.Abs()));

	/// <summary>
	/// Clamps the physical quantity to the specified minimum and maximum values.
	/// </summary>
	/// <typeparam name="T1">The type of the minimum value.</typeparam>
	/// <typeparam name="T2">The type of the maximum value.</typeparam>
	/// <param name="min">The minimum value.</param>
	/// <param name="max">The maximum value.</param>
	/// <returns>A new instance of the physical quantity clamped to the specified range.</returns>
	public TSelf Clamp<T1, T2>(T1 min, T2 max)
		where T1 : INumber<T1>
		where T2 : INumber<T2>
		=> Create(new(Quantity.Clamp<StorageType>(new(min.ToPreciseNumber()), new(max.ToPreciseNumber()))));

	/// <summary>
	/// Adds a specified value to the physical quantity during a unit conversion.
	/// </summary>
	/// <param name="other">The value to add.</param>
	/// <returns>A new instance of the physical quantity with the added value.</returns>
	protected TSelf ConversionAdd(StorageType other) => Create(Quantity + other);
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
	public static TQuantity ConvertToQuantity<TInput, TQuantity>(this TInput value, StorageType factor, StorageType offset)
		where TQuantity : PhysicalQuantity<TQuantity>, new()
		where TInput : INumber<TInput>
		=> PhysicalQuantity<TQuantity>.Create((new StorageType(value.ToPreciseNumber()) * factor) + offset);

	/// <summary>
	/// Converts a numeric value to a specific physical quantity type with a given conversion factor.
	/// </summary>
	/// <typeparam name="TInput">The type of the input numeric value.</typeparam>
	/// <typeparam name="TQuantity">The type of the physical quantity to convert to.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <param name="factor">The conversion factor to apply.</param>
	/// <returns>A new instance of the specified physical quantity type.</returns>
	public static TQuantity ConvertToQuantity<TInput, TQuantity>(this TInput value, StorageType factor)
		where TQuantity : PhysicalQuantity<TQuantity>, new()
		where TInput : INumber<TInput>
		=> PhysicalQuantity<TQuantity>.Create(new StorageType(value.ToPreciseNumber()) * factor);

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
		=> PhysicalQuantity<TQuantity>.Create(new(value.ToPreciseNumber()));

	/// <summary>
	/// Converts a physical quantity to a numeric value with a given conversion factor and offset.
	/// </summary>
	/// <typeparam name="TQuantity">The type of the physical quantity to convert from.</typeparam>
	/// <param name="value">The physical quantity to convert.</param>
	/// <param name="factor">The conversion factor to apply.</param>
	/// <param name="offset">The conversion offset to apply.</param>
	/// <returns>The numeric value representing the converted physical quantity.</returns>
	public static StorageType ConvertToNumber<TQuantity>(this TQuantity value, StorageType factor, StorageType offset)
		where TQuantity : PhysicalQuantity<TQuantity>, new()
	{
		ArgumentNullException.ThrowIfNull(value);

		return (value.Quantity - offset) / factor;
	}

	/// <summary>
	/// Converts a physical quantity to a numeric value with a given conversion factor.
	/// </summary>
	/// <typeparam name="TQuantity">The type of the physical quantity to convert from.</typeparam>
	/// <param name="value">The physical quantity to convert.</param>
	/// <param name="factor">The conversion factor to apply.</param>
	/// <returns>The numeric value representing the converted physical quantity.</returns>
	public static StorageType ConvertToNumber<TQuantity>(this TQuantity value, StorageType factor)
		where TQuantity : PhysicalQuantity<TQuantity>, new()
	{
		ArgumentNullException.ThrowIfNull(value);

		return value.Quantity / factor;
	}

	/// <summary>
	/// Converts a physical quantity to a numeric value without any conversion factor or offset.
	/// </summary>
	/// <typeparam name="TQuantity">The type of the physical quantity to convert from.</typeparam>
	/// <param name="value">The physical quantity to convert.</param>
	/// <returns>The numeric value representing the converted physical quantity.</returns>
	public static StorageType ConvertToNumber<TQuantity>(this TQuantity value)
		where TQuantity : PhysicalQuantity<TQuantity>, new()
	{
		ArgumentNullException.ThrowIfNull(value);

		return value.Quantity;
	}
}
