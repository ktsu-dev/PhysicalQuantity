// Copyright (c) ktsu.dev
// All rights reserved.
// Licensed under the MIT license.

namespace ktsu.PhysicalQuantity.Length;

using System.Numerics;

using ktsu.PhysicalQuantity.Area;
using ktsu.PhysicalQuantity.Energy;
using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Time;
using ktsu.PhysicalQuantity.Velocity;
using ktsu.PhysicalQuantity.Volume;

/// <summary>
/// Represents a length physical quantity.
/// </summary>
[SIUnit("m", "meter", "meters")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record Length
	: PhysicalQuantity<Length>
	, IIntegralOperators<Length, Length, Area>
	, IIntegralOperators<Length, Area, Volume>
	, IIntegralOperators<Length, Force, Energy>
	, IDerivativeOperators<Length, Time, Velocity>
{
	/// <summary>
	/// Multiplies two <see cref="Length"/> instances to compute an <see cref="Area"/>.
	/// </summary>
	/// <param name="left">The first <see cref="Length"/> operand.</param>
	/// <param name="right">The second <see cref="Length"/> operand.</param>
	/// <returns>An <see cref="Area"/> representing the product of the two lengths.</returns>
	public static Area operator *(Length left, Length right) =>
		IIntegralOperators<Length, Length, Area>.Integrate(left, right);

	/// <summary>
	/// Multiplies a <see cref="Length"/> and an <see cref="Area"/> to compute a <see cref="Volume"/>.
	/// </summary>
	/// <param name="left">The <see cref="Length"/> operand.</param>
	/// <param name="right">The <see cref="Area"/> operand.</param>
	/// <returns>A <see cref="Volume"/> representing the product of the length and area.</returns>
	public static Volume operator *(Length left, Area right) =>
		IIntegralOperators<Length, Area, Volume>.Integrate(left, right);

	/// <summary>
	/// Multiplies a <see cref="Length"/> and a <see cref="Force"/> to compute an <see cref="Energy"/>.
	/// </summary>
	/// <param name="left">The <see cref="Length"/> operand.</param>
	/// <param name="right">The <see cref="Force"/> operand.</param>
	/// <returns>An <see cref="Energy"/> representing the product of the length and force.</returns>
	public static Energy operator *(Length left, Force right) =>
		IIntegralOperators<Length, Force, Energy>.Integrate(left, right);

	/// <summary>
	/// Divides a <see cref="Length"/> by a <see cref="Time"/> to compute a <see cref="Velocity"/>.
	/// </summary>
	/// <param name="left">The <see cref="Length"/> operand.</param>
	/// <param name="right">The <see cref="Time"/> operand.</param>
	/// <returns>A <see cref="Velocity"/> representing the result of the division.</returns>
	public static Velocity operator /(Length left, Time right) =>
		IDerivativeOperators<Length, Time, Velocity>.Derive(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Length"/>.
/// </summary>
public static class LengthConversions
{
	/// <summary>
	/// Converts a value to meters.
	/// </summary>
	/// <typeparam name="TNumber">The type of the value to convert.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Length"/> representing the value in meters.</returns>
	public static Length Meters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Length>();

	/// <summary>
	/// Converts a <see cref="Length"/> to a numeric value in meters.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The <see cref="Length"/> to convert.</param>
	/// <returns>The numeric value in meters.</returns>
	public static TNumber Meters<TNumber>(this Length value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	// Metric prefixes
	/// <summary>
	/// Converts a value to kilometers.
	/// </summary>
	/// <typeparam name="TNumber">The type of the value to convert.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Length"/> representing the value in kilometers.</returns>
	public static Length Kilometers<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Length>(Constants.Kilo);

	/// <summary>
	/// Converts a <see cref="Length"/> to a numeric value in kilometers.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The <see cref="Length"/> to convert.</param>
	/// <returns>The numeric value in kilometers.</returns>
	public static TNumber Kilometers<TNumber>(this Length value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Kilo).To<TNumber>();

	/// <summary>
	/// Converts a value to centimeters.
	/// </summary>
	/// <typeparam name="TNumber">The type of the value to convert.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Length"/> representing the value in centimeters.</returns>
	public static Length Centimeters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Length>(Constants.Centi);

	/// <summary>
	/// Converts a <see cref="Length"/> to a numeric value in centimeters.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The <see cref="Length"/> to convert.</param>
	/// <returns>The numeric value in centimeters.</returns>
	public static TNumber Centimeters<TNumber>(this Length value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Centi).To<TNumber>();

	/// <summary>
	/// Converts a value to millimeters.
	/// </summary>
	/// <typeparam name="TNumber">The type of the value to convert.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Length"/> representing the value in millimeters.</returns>
	public static Length Millimeters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Length>(Constants.Milli);

	/// <summary>
	/// Converts a <see cref="Length"/> to a numeric value in millimeters.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The <see cref="Length"/> to convert.</param>
	/// <returns>The numeric value in millimeters.</returns>
	public static TNumber Millimeters<TNumber>(this Length value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a value to micrometers.
	/// </summary>
	/// <typeparam name="TNumber">The type of the value to convert.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Length"/> representing the value in micrometers.</returns>
	public static Length Micrometers<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Length>(Constants.Micro);

	/// <summary>
	/// Converts a <see cref="Length"/> to a numeric value in micrometers.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The <see cref="Length"/> to convert.</param>
	/// <returns>The numeric value in micrometers.</returns>
	public static TNumber Micrometers<TNumber>(this Length value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();

	/// <summary>
	/// Converts a value to nanometers.
	/// </summary>
	/// <typeparam name="TNumber">The type of the value to convert.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Length"/> representing the value in nanometers.</returns>
	public static Length Nanometers<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Length>(Constants.Nano);

	/// <summary>
	/// Converts a <see cref="Length"/> to a numeric value in nanometers.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The <see cref="Length"/> to convert.</param>
	/// <returns>The numeric value in nanometers.</returns>
	public static TNumber Nanometers<TNumber>(this Length value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Nano).To<TNumber>();

	// Imperial and other conversions
	/// <summary>
	/// Converts a value to feet.
	/// </summary>
	/// <typeparam name="TNumber">The type of the value to convert.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Length"/> representing the value in feet.</returns>
	public static Length Feet<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Length>(Constants.FeetToMetersFactor);

	/// <summary>
	/// Converts a <see cref="Length"/> to a numeric value in feet.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The <see cref="Length"/> to convert.</param>
	/// <returns>The numeric value in feet.</returns>
	public static TNumber Feet<TNumber>(this Length value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.FeetToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a value to inches.
	/// </summary>
	/// <typeparam name="TNumber">The type of the value to convert.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Length"/> representing the value in inches.</returns>
	public static Length Inches<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Length>(Constants.InchesToMetersFactor);

	/// <summary>
	/// Converts a <see cref="Length"/> to a numeric value in inches.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The <see cref="Length"/> to convert.</param>
	/// <returns>The numeric value in inches.</returns>
	public static TNumber Inches<TNumber>(this Length value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.InchesToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a value to yards.
	/// </summary>
	/// <typeparam name="TNumber">The type of the value to convert.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Length"/> representing the value in yards.</returns>
	public static Length Yards<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Length>(Constants.YardsToMetersFactor);

	/// <summary>
	/// Converts a <see cref="Length"/> to a numeric value in yards.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The <see cref="Length"/> to convert.</param>
	/// <returns>The numeric value in yards.</returns>
	public static TNumber Yards<TNumber>(this Length value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.YardsToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a value to miles.
	/// </summary>
	/// <typeparam name="TNumber">The type of the value to convert.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Length"/> representing the value in miles.</returns>
	public static Length Miles<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Length>(Constants.MilesToMetersFactor);

	/// <summary>
	/// Converts a <see cref="Length"/> to a numeric value in miles.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The <see cref="Length"/> to convert.</param>
	/// <returns>The numeric value in miles.</returns>
	public static TNumber Miles<TNumber>(this Length value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.MilesToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a value to nautical miles.
	/// </summary>
	/// <typeparam name="TNumber">The type of the value to convert.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Length"/> representing the value in nautical miles.</returns>
	public static Length NauticalMiles<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Length>(Constants.NauticalMilesToMetersFactor);

	/// <summary>
	/// Converts a <see cref="Length"/> to a numeric value in nautical miles.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The <see cref="Length"/> to convert.</param>
	/// <returns>The numeric value in nautical miles.</returns>
	public static TNumber NauticalMiles<TNumber>(this Length value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.NauticalMilesToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a value to fathoms.
	/// </summary>
	/// <typeparam name="TNumber">The type of the value to convert.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Length"/> representing the value in fathoms.</returns>
	public static Length Fathoms<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Length>(Constants.FathomsToMetersFactor);

	/// <summary>
	/// Converts a <see cref="Length"/> to a numeric value in fathoms.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The <see cref="Length"/> to convert.</param>
	/// <returns>The numeric value in fathoms.</returns>
	public static TNumber Fathoms<TNumber>(this Length value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.FathomsToMetersFactor).To<TNumber>();
}
