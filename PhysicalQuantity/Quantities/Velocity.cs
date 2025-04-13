namespace ktsu.PhysicalQuantity.Velocity;

using System.Numerics;

using ktsu.PhysicalQuantity.Acceleration;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.Momentum;
using ktsu.PhysicalQuantity.Time;
using ktsu.SignificantNumber;

/// <summary>
/// Represents a velocity quantity measured in meters per second, feet per second, inches per second, 
/// miles per hour, and kilometers per hour.
/// </summary>
[SIUnit("m/s", "meter per second", "meters per second")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record Velocity
	: PhysicalQuantity<Velocity>
	, IDerivativeOperators<Velocity, Time, Acceleration>
	, IIntegralOperators<Velocity, Time, Length>
	, IIntegralOperators<Velocity, Mass, Momentum>
{
	/// <summary>
	/// Divides a <see cref="Velocity"/> instance by a <see cref="Time"/> instance to compute the <see cref="Acceleration"/>.
	/// </summary>
	/// <param name="left">The velocity value.</param>
	/// <param name="right">The time value.</param>
	/// <returns>An <see cref="Acceleration"/> instance representing the result of the division.</returns>
	public static Acceleration operator /(Velocity left, Time right) =>
		IDerivativeOperators<Velocity, Time, Acceleration>.Derive(left, right);

	/// <summary>
	/// Multiplies a <see cref="Velocity"/> instance by a <see cref="Time"/> instance to compute the <see cref="Length"/>.
	/// </summary>
	/// <param name="left">The velocity value.</param>
	/// <param name="right">The time value.</param>
	/// <returns>A <see cref="Length"/> instance representing the result of the multiplication.</returns>
	public static Length operator *(Velocity left, Time right) =>
		IIntegralOperators<Velocity, Time, Length>.Integrate(left, right);

	/// <summary>
	/// Multiplies a <see cref="Velocity"/> instance by a <see cref="Mass"/> instance to compute the <see cref="Momentum"/>.
	/// </summary>
	/// <param name="left">The velocity value.</param>
	/// <param name="right">The mass value.</param>
	/// <returns>A <see cref="Momentum"/> instance representing the result of the multiplication.</returns>
	public static Momentum operator *(Velocity left, Mass right) =>
		IIntegralOperators<Velocity, Mass, Momentum>.Integrate(left, right);
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
