// Copyright (c) ktsu.dev
// All rights reserved.
// Licensed under the MIT license.

namespace ktsu.PhysicalQuantity.Volume;

using System.Numerics;

using ktsu.PhysicalQuantity.Area;
using ktsu.PhysicalQuantity.Density;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Mass;

/// <summary>
/// Represents a volume quantity measured in cubic meters, liters, milliliters, cubic feet, and cubic inches.
/// </summary>
[SIUnit("m³", "cubic meter", "cubic meters")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]

public sealed record Volume
	: PhysicalQuantity<Volume>
	, IDerivativeOperators<Volume, Length, Area>
	, IDerivativeOperators<Volume, Area, Length>
	, IIntegralOperators<Volume, Density, Mass>
{
	/// <summary>
	/// Multiplies a <see cref="Volume"/> instance by a <see cref="Density"/> instance to calculate the resulting <see cref="Mass"/>.
	/// </summary>
	/// <param name="left">The volume value.</param>
	/// <param name="right">The density value.</param>
	/// <returns>The resulting <see cref="Mass"/>.</returns>
	public static Mass operator *(Volume left, Density right) =>
		IIntegralOperators<Volume, Density, Mass>.Integrate(left, right);

	/// <summary>
	/// Divides a <see cref="Volume"/> instance by a <see cref="Length"/> instance to calculate the resulting <see cref="Area"/>.
	/// </summary>
	/// <param name="left">The volume value.</param>
	/// <param name="right">The length value.</param>
	/// <returns>The resulting <see cref="Area"/>.</returns>
	public static Area operator /(Volume left, Length right) =>
		IDerivativeOperators<Volume, Length, Area>.Derive(left, right);

	/// <summary>
	/// Divides a <see cref="Volume"/> instance by an <see cref="Area"/> instance to calculate the resulting <see cref="Length"/>.
	/// </summary>
	/// <param name="left">The volume value.</param>
	/// <param name="right">The area value.</param>
	/// <returns>The resulting <see cref="Length"/>.</returns>
	public static Length operator /(Volume left, Area right) =>
		IDerivativeOperators<Volume, Area, Length>.Derive(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Volume"/>.
/// </summary>
public static class VolumeConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Volume"/> measured in cubic meters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Volume"/> instance representing the specified value in cubic meters.</returns>
	public static Volume CubicMeters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Volume>();

	/// <summary>
	/// Converts a <see cref="Volume"/> value to a numeric value measured in cubic meters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Volume"/> value to convert.</param>
	/// <returns>The numeric value representing the volume in cubic meters.</returns>
	public static TNumber CubicMeters<TNumber>(this Volume value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Volume"/> measured in liters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Volume"/> instance representing the specified value in liters.</returns>
	public static Volume Liters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Volume>(Constants.Milli);

	/// <summary>
	/// Converts a <see cref="Volume"/> value to a numeric value measured in liters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Volume"/> value to convert.</param>
	/// <returns>The numeric value representing the volume in liters.</returns>
	public static TNumber Liters<TNumber>(this Volume value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Volume"/> measured in milliliters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Volume"/> instance representing the specified value in milliliters.</returns>
	public static Volume Milliliters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Volume>(Constants.Micro);

	/// <summary>
	/// Converts a <see cref="Volume"/> value to a numeric value measured in milliliters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Volume"/> value to convert.</param>
	/// <returns>The numeric value representing the volume in milliliters.</returns>
	public static TNumber Milliliters<TNumber>(this Volume value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Volume"/> measured in cubic feet.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Volume"/> instance representing the specified value in cubic feet.</returns>
	public static Volume CubicFeet<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Volume>(new(Constants.FeetToMetersFactor.Cubed()));

	/// <summary>
	/// Converts a <see cref="Volume"/> value to a numeric value measured in cubic feet.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Volume"/> value to convert.</param>
	/// <returns>The numeric value representing the volume in cubic feet.</returns>
	public static TNumber CubicFeet<TNumber>(this Volume value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(new(Constants.FeetToMetersFactor.Cubed())).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Volume"/> measured in cubic inches.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Volume"/> instance representing the specified value in cubic inches.</returns>
	public static Volume CubicInches<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Volume>(new(Constants.InchesToMetersFactor.Cubed()));

	/// <summary>
	/// Converts a <see cref="Volume"/> value to a numeric value measured in cubic inches.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Volume"/> value to convert.</param>
	/// <returns>The numeric value representing the volume in cubic inches.</returns>
	public static TNumber CubicInches<TNumber>(this Volume value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(new(Constants.InchesToMetersFactor.Cubed())).To<TNumber>();
}
