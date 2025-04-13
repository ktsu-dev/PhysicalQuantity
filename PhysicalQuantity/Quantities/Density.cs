namespace ktsu.PhysicalQuantity.Density;

using System.Numerics;

using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.Volume;

/// <summary>
/// Represents a density quantity measured in kilograms per cubic meter.
/// </summary>
[SIUnit("kg/m³", "kilogram per cubic meter", "kilograms per cubic meter")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record Density
	: PhysicalQuantity<Density>
	, IIntegralOperators<Density, Volume, Mass>
{
	/// <summary>
	/// Multiplies a <see cref="Density"/> instance by a <see cref="Volume"/> instance to calculate the resulting <see cref="Mass"/>.
	/// </summary>
	/// <param name="left">The density value.</param>
	/// <param name="right">The volume value.</param>
	/// <returns>A <see cref="Mass"/> instance representing the product of the density and volume.</returns>
	public static Mass operator *(Density left, Volume right) =>
		IIntegralOperators<Density, Volume, Mass>.Integrate(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Density"/>.
/// </summary>
public static class DensityConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Density"/> measured in kilograms per cubic meter.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Density"/> instance representing the specified value in kilograms per cubic meter.</returns>
	public static Density KilogramsPerCubicMeter<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Density>();

	/// <summary>
	/// Converts a <see cref="Density"/> value to a numeric value measured in kilograms per cubic meter.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Density"/> value to convert.</param>
	/// <returns>The numeric value representing the density in kilograms per cubic meter.</returns>
	public static TNumber KilogramsPerCubicMeter<TNumber>(this Density value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Density"/> measured in grams per cubic centimeter.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Density"/> instance representing the specified value in grams per cubic centimeter.</returns>
	public static Density GramsPerCubicCentimeter<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Density>(Constants.Kilo);

	/// <summary>
	/// Converts a <see cref="Density"/> value to a numeric value measured in grams per cubic centimeter.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Density"/> value to convert.</param>
	/// <returns>The numeric value representing the density in grams per cubic centimeter.</returns>
	public static TNumber GramsPerCubicCentimeter<TNumber>(this Density value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Kilo).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Density"/> measured in milligrams per cubic meter.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Density"/> instance representing the specified value in milligrams per cubic meter.</returns>
	public static Density MilligramsPerCubicMeter<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Density>(Constants.Milli);

	/// <summary>
	/// Converts a <see cref="Density"/> value to a numeric value measured in milligrams per cubic meter.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Density"/> value to convert.</param>
	/// <returns>The numeric value representing the density in milligrams per cubic meter.</returns>
	public static TNumber MilligramsPerCubicMeter<TNumber>(this Density value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Density"/> measured in micrograms per cubic meter.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Density"/> instance representing the specified value in micrograms per cubic meter.</returns>
	public static Density MicrogramsPerCubicMeter<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Density>(Constants.Micro);

	/// <summary>
	/// Converts a <see cref="Density"/> value to a numeric value measured in micrograms per cubic meter.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Density"/> value to convert.</param>
	/// <returns>The numeric value representing the density in micrograms per cubic meter.</returns>
	public static TNumber MicrogramsPerCubicMeter<TNumber>(this Density value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Density"/> measured in nanograms per cubic meter.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Density"/> instance representing the specified value in nanograms per cubic meter.</returns>
	public static Density NanogramsPerCubicMeter<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Density>(Constants.Nano);

	/// <summary>
	/// Converts a <see cref="Density"/> value to a numeric value measured in nanograms per cubic meter.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Density"/> value to convert.</param>
	/// <returns>The numeric value representing the density in nanograms per cubic meter.</returns>
	public static TNumber NanogramsPerCubicMeter<TNumber>(this Density value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Nano).To<TNumber>();
}
