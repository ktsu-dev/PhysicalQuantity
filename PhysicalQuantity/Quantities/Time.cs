namespace ktsu.io.PhysicalQuantity.Time;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Acceleration;
using ktsu.io.PhysicalQuantity.AngularAcceleration;
using ktsu.io.PhysicalQuantity.AngularVelocity;
using ktsu.io.PhysicalQuantity.Energy;
using ktsu.io.PhysicalQuantity.Generic;
using ktsu.io.PhysicalQuantity.Jerk;
using ktsu.io.PhysicalQuantity.Length;
using ktsu.io.PhysicalQuantity.Power;
using ktsu.io.PhysicalQuantity.Velocity;

/// <summary>
/// Represents a time quantity measured in seconds, minutes, hours, and days.
/// </summary>
[SIUnit("s", "second", "seconds")]
public sealed record Time
	: PhysicalQuantity<Time>
	, IIntegralOperators<Time, Acceleration, Velocity>
	, IIntegralOperators<Time, Velocity, Length>
	, IIntegralOperators<Time, Jerk, Acceleration>
	, IIntegralOperators<Time, Power, Energy>
	, IIntegralOperators<Time, AngularAcceleration, AngularVelocity>
{
	public static Velocity operator *(Time left, Acceleration right) => (IIntegralOperators<Time, Acceleration, Velocity>)left * right;
	public static Acceleration operator *(Time left, Jerk right) => (IIntegralOperators<Time, Jerk, Acceleration>)left * right;
	public static Energy operator *(Time left, Power right) => (IIntegralOperators<Time, Power, Energy>)left * right;
	public static Length operator *(Time left, Velocity right) => (IIntegralOperators<Time, Velocity, Length>)left * right;
	public static AngularVelocity operator *(Time left, AngularAcceleration right) => (IIntegralOperators<Time, AngularAcceleration, AngularVelocity>)left * right;
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Time"/>.
/// </summary>
public static class TimeConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Time"/> measured in seconds.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Time"/> instance representing the specified value in seconds.</returns>
	public static Time Seconds<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Time>();

	/// <summary>
	/// Converts a <see cref="Time"/> value to a numeric value measured in seconds.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Time"/> value to convert.</param>
	/// <returns>The numeric value representing the time in seconds.</returns>
	public static TNumber Seconds<TNumber>(this Time value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Time"/> measured in minutes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Time"/> instance representing the specified value in minutes.</returns>
	public static Time Minutes<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Time>(Constants.MinutesToSecondsFactor);

	/// <summary>
	/// Converts a <see cref="Time"/> value to a numeric value measured in minutes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Time"/> value to convert.</param>
	/// <returns>The numeric value representing the time in minutes.</returns>
	public static TNumber Minutes<TNumber>(this Time value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.MinutesToSecondsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Time"/> measured in hours.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Time"/> instance representing the specified value in hours.</returns>
	public static Time Hours<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Time>(Constants.HoursToSecondsFactor);

	/// <summary>
	/// Converts a <see cref="Time"/> value to a numeric value measured in hours.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Time"/> value to convert.</param>
	/// <returns>The numeric value representing the time in hours.</returns>
	public static TNumber Hours<TNumber>(this Time value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.HoursToSecondsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Time"/> measured in days.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Time"/> instance representing the specified value in days.</returns>
	public static Time Days<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Time>(Constants.DaysToSecondsFactor);

	/// <summary>
	/// Converts a <see cref="Time"/> value to a numeric value measured in days.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Time"/> value to convert.</param>
	/// <returns>The numeric value representing the time in days.</returns>
	public static TNumber Days<TNumber>(this Time value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.DaysToSecondsFactor).To<TNumber>();
}
