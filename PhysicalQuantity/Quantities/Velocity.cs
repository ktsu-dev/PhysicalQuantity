namespace ktsu.io.PhysicalQuantity.Velocity;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Acceleration;
using ktsu.io.PhysicalQuantity.Generic;
using ktsu.io.PhysicalQuantity.Length;
using ktsu.io.PhysicalQuantity.Time;
using ktsu.io.SignificantNumber;

/// <summary>
/// Represents a velocity quantity measured in meters per second, feet per second, inches per second, 
/// miles per hour, and kilometers per hour.
/// </summary>
[SIUnit("m/s", "meter per second", "meters per second")]
public sealed record Velocity
	: PhysicalQuantity<Velocity>
	, IDerivativeOperators<Velocity, Time, Acceleration>
	, IIntegralOperators<Velocity, Time, Length>
{
	public static Acceleration operator /(Velocity left, Time right) =>
		(IDerivativeOperators<Velocity, Time, Acceleration>)left / right;
	public static Length operator *(Velocity left, Time right) =>
		(IIntegralOperators<Velocity, Time, Length>)left * right;
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Velocity"/>.
/// </summary>
public static class VelocityConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Velocity"/> measured in meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Velocity"/> instance representing the specified value in meters per second.</returns>
	public static Velocity MetersPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Velocity>();

	/// <summary>
	/// Converts a <see cref="Velocity"/> value to a numeric value measured in meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Velocity"/> value to convert.</param>
	/// <returns>The numeric value representing the velocity in meters per second.</returns>
	public static TNumber MetersPerSecond<TNumber>(this Velocity value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Velocity"/> measured in feet per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Velocity"/> instance representing the specified value in feet per second.</returns>
	public static Velocity FeetPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Velocity>(Constants.FeetToMetersFactor);

	/// <summary>
	/// Converts a <see cref="Velocity"/> value to a numeric value measured in feet per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Velocity"/> value to convert.</param>
	/// <returns>The numeric value representing the velocity in feet per second.</returns>
	public static TNumber FeetPerSecond<TNumber>(this Velocity value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.FeetToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Velocity"/> measured in inches per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Velocity"/> instance representing the specified value in inches per second.</returns>
	public static Velocity InchesPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Velocity>(Constants.InchesToMetersFactor);

	/// <summary>
	/// Converts a <see cref="Velocity"/> value to a numeric value measured in inches per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Velocity"/> value to convert.</param>
	/// <returns>The numeric value representing the velocity in inches per second.</returns>
	public static TNumber InchesPerSecond<TNumber>(this Velocity value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.InchesToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Velocity"/> measured in miles per hour.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Velocity"/> instance representing the specified value in miles per hour.</returns>
	public static Velocity MilesPerHour<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Velocity>((Constants.MilesToMetersFactor.To<double>() / Constants.HoursToSecondsFactor.To<double>()).ToSignificantNumber());

	/// <summary>
	/// Converts a <see cref="Velocity"/> value to a numeric value measured in miles per hour.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Velocity"/> value to convert.</param>
	/// <returns>The numeric value representing the velocity in miles per hour.</returns>
	public static TNumber MilesPerHour<TNumber>(this Velocity value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber((Constants.MilesToMetersFactor.To<double>() / Constants.HoursToSecondsFactor.To<double>()).ToSignificantNumber()).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Velocity"/> measured in kilometers per hour.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Velocity"/> instance representing the specified value in kilometers per hour.</returns>
	public static Velocity KilometersPerHour<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Velocity>((Constants.Kilo.To<double>() / Constants.HoursToSecondsFactor.To<double>()).ToSignificantNumber());

	/// <summary>
	/// Converts a <see cref="Velocity"/> value to a numeric value measured in kilometers per hour.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Velocity"/> value to convert.</param>
	/// <returns>The numeric value representing the velocity in kilometers per hour.</returns>
	public static TNumber KilometersPerHour<TNumber>(this Velocity value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber((Constants.Kilo.To<double>() / Constants.HoursToSecondsFactor.To<double>()).ToSignificantNumber()).To<TNumber>();
}
