namespace ktsu.PhysicalQuantity.Torque;

using System.Numerics;
using ktsu.PhysicalQuantity.Generic;

/// <summary>
/// Represents a torque quantity measured in newton meters, foot-pounds, and pound-inches.
/// </summary>
[SIUnit("Nm", "newton meter", "newton meters")]
public sealed record Torque
	: PhysicalQuantity<Torque>
{ }

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Torque"/>.
/// </summary>
public static class TorqueConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Torque"/> measured in newton meters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Torque"/> instance representing the specified value in newton meters.</returns>
	public static Torque NewtonMeters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Torque>();

	/// <summary>
	/// Converts a <see cref="Torque"/> value to a numeric value measured in newton meters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Torque"/> value to convert.</param>
	/// <returns>The numeric value representing the torque in newton meters.</returns>
	public static TNumber NewtonMeters<TNumber>(this Torque value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Torque"/> measured in foot-pounds.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Torque"/> instance representing the specified value in foot-pounds.</returns>
	public static Torque FootPounds<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Torque>(Constants.FootPoundsToNewtonMetersFactor);

	/// <summary>
	/// Converts a <see cref="Torque"/> value to a numeric value measured in foot-pounds.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Torque"/> value to convert.</param>
	/// <returns>The numeric value representing the torque in foot-pounds.</returns>
	public static TNumber FootPounds<TNumber>(this Torque value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.FootPoundsToNewtonMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Torque"/> measured in pound-inches.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Torque"/> instance representing the specified value in pound-inches.</returns>
	public static Torque PoundInches<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Torque>(Constants.PoundInchesToNewtonMetersFactor);

	/// <summary>
	/// Converts a <see cref="Torque"/> value to a numeric value measured in pound-inches.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Torque"/> value to convert.</param>
	/// <returns>The numeric value representing the torque in pound-inches.</returns>
	public static TNumber PoundInches<TNumber>(this Torque value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.PoundInchesToNewtonMetersFactor).To<TNumber>();
}
