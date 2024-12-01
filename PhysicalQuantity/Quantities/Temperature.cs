namespace ktsu.PhysicalQuantity.Temperature;

using System.Numerics;
using ktsu.PhysicalQuantity.Generic;
using ktsu.SignificantNumber;

/// <summary>
/// Represents a temperature quantity measured in Kelvin, degrees Celsius, and degrees Fahrenheit.
/// </summary>
[SIUnit("K", "kelvin", "kelvins")]
public sealed record Temperature
	: PhysicalQuantity<Temperature>
{ }

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Temperature"/>.
/// </summary>
public static class TemperatureConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Temperature"/> measured in Kelvin.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Temperature"/> instance representing the specified value in Kelvin.</returns>
	public static Temperature Kelvin<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Temperature>();

	/// <summary>
	/// Converts a <see cref="Temperature"/> value to a numeric value measured in Kelvin.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Temperature"/> value to convert.</param>
	/// <returns>The numeric value representing the temperature in Kelvin.</returns>
	public static TNumber Kelvin<TNumber>(this Temperature value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Temperature"/> measured in degrees Celsius.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Temperature"/> instance representing the specified value in degrees Celsius.</returns>
	public static Temperature Celsius<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Temperature>(Constants.CelsiusToKelvinFactor, Constants.CelsiusToKelvinOffset);

	/// <summary>
	/// Converts a <see cref="Temperature"/> value to a numeric value measured in degrees Celsius.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Temperature"/> value to convert.</param>
	/// <returns>The numeric value representing the temperature in degrees Celsius.</returns>
	public static TNumber Celsius<TNumber>(this Temperature value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.CelsiusToKelvinFactor, Constants.CelsiusToKelvinOffset).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Temperature"/> measured in degrees Fahrenheit.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Temperature"/> instance representing the specified value in degrees Fahrenheit.</returns>
	public static Temperature Fahrenheit<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> ((value.ToSignificantNumber() - Constants.FahrenheitToCelsiusOffset) / Constants.FahrenheitToCelsiusFactor).Celsius();

	/// <summary>
	/// Converts a <see cref="Temperature"/> value to a numeric value measured in degrees Fahrenheit.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Temperature"/> value to convert.</param>
	/// <returns>The numeric value representing the temperature in degrees Fahrenheit.</returns>
	public static TNumber Fahrenheit<TNumber>(this Temperature value)
		where TNumber : INumber<TNumber>
		=> ((value.Celsius<SignificantNumber>() * Constants.FahrenheitToCelsiusFactor) + Constants.FahrenheitToCelsiusOffset).To<TNumber>();
}
