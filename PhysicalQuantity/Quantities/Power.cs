// Ignore Spelling: Gigawatts

namespace ktsu.io.PhysicalQuantity.Power;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Energy;
using ktsu.io.PhysicalQuantity.Generic;
using ktsu.io.PhysicalQuantity.Time;

/// <summary>
/// Represents a power quantity measured in watts.
/// </summary>
[SIUnit("W", "watt", "watts")]
public sealed record Power
	: PhysicalQuantity<Power>
	, IIntegralOperators<Power, Time, Energy>
{
	public static Energy operator *(Power left, Time right) => (IIntegralOperators<Power, Time, Energy>)left * right;
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Power"/>.
/// </summary>
public static class PowerConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Power"/> measured in watts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Power"/> instance representing the specified value in watts.</returns>
	public static Power Watts<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Power>();

	/// <summary>
	/// Converts a <see cref="Power"/> value to a numeric value measured in watts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Power"/> value to convert.</param>
	/// <returns>The numeric value representing the power in watts.</returns>
	public static TNumber Watts<TNumber>(this Power value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Power"/> measured in horsepower.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Power"/> instance representing the specified value in horsepower.</returns>
	public static Power Horsepower<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Power>(Constants.HorsepowerToWattsFactor);

	/// <summary>
	/// Converts a <see cref="Power"/> value to a numeric value measured in horsepower.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Power"/> value to convert.</param>
	/// <returns>The numeric value representing the power in horsepower.</returns>
	public static TNumber Horsepower<TNumber>(this Power value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.HorsepowerToWattsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Power"/> measured in metric horsepower.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Power"/> instance representing the specified value in metric horsepower.</returns>
	public static Power MetricHorsepower<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Power>(Constants.MetricHorsePowerToWattsFactor);

	/// <summary>
	/// Converts a <see cref="Power"/> value to a numeric value measured in metric horsepower.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Power"/> value to convert.</param>
	/// <returns>The numeric value representing the power in metric horsepower.</returns>
	public static TNumber MetricHorsepower<TNumber>(this Power value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.MetricHorsePowerToWattsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Power"/> measured in kilowatts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Power"/> instance representing the specified value in kilowatts.</returns>
	public static Power Kilowatts<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Power>(Constants.Kilo);

	/// <summary>
	/// Converts a <see cref="Power"/> value to a numeric value measured in kilowatts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Power"/> value to convert.</param>
	/// <returns>The numeric value representing the power in kilowatts.</returns>
	public static TNumber Kilowatts<TNumber>(this Power value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Kilo).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Power"/> measured in megawatts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Power"/> instance representing the specified value in megawatts.</returns>
	public static Power Megawatts<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Power>(Constants.Mega);

	/// <summary>
	/// Converts a <see cref="Power"/> value to a numeric value measured in megawatts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Power"/> value to convert.</param>
	/// <returns>The numeric value representing the power in megawatts.</returns>
	public static TNumber Megawatts<TNumber>(this Power value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Mega).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Power"/> measured in gigawatts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Power"/> instance representing the specified value in gigawatts.</returns>
	public static Power Gigawatts<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Power>(Constants.Giga);

	/// <summary>
	/// Converts a <see cref="Power"/> value to a numeric value measured in gigawatts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Power"/> value to convert.</param>
	/// <returns>The numeric value representing the power in gigawatts.</returns>
	public static TNumber Gigawatts<TNumber>(this Power value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Giga).To<TNumber>();
}
