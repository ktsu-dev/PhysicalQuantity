namespace ktsu.io.PhysicalQuantity.Time;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Generic;

/// <summary>
/// Represents a time quantity measured in seconds, minutes, hours, and days.
/// </summary>
[SIUnit("s", "second", "seconds")]
public sealed record Time
	: PhysicalQuantity<Time>
{ }

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
