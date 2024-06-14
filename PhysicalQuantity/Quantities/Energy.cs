namespace ktsu.io.PhysicalQuantity.Energy;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Force;
using ktsu.io.PhysicalQuantity.Generic;
using ktsu.io.PhysicalQuantity.Length;
using ktsu.io.PhysicalQuantity.Power;
using ktsu.io.PhysicalQuantity.Time;

/// <summary>
/// Represents an energy quantity measured in joules.
/// </summary>
[SIUnit("J", "joule", "joules")]
public sealed record Energy
	: PhysicalQuantity<Energy>
	, IDerivativeOperators<Energy, Time, Power>
	, IDerivativeOperators<Energy, Force, Length>
	, IDerivativeOperators<Energy, Length, Force>
{
	public static Power operator /(Energy left, Time right) =>
		IDerivativeOperators<Energy, Time, Power>.Derive(left, right);

	public static Length operator /(Energy left, Force right) =>
		IDerivativeOperators<Energy, Force, Length>.Derive(left, right);

	public static Force operator /(Energy left, Length right) =>
		IDerivativeOperators<Energy, Length, Force>.Derive(left, right);

}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Energy"/>.
/// </summary>
public static class EnergyConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Energy"/> measured in joules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="Energy"/> instance representing the specified value in joules.</returns>
	public static Energy Joules<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Energy>();

	/// <summary>
	/// Converts an <see cref="Energy"/> value to a numeric value measured in joules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Energy"/> value to convert.</param>
	/// <returns>The numeric value representing the energy in joules.</returns>
	public static TNumber Joules<TNumber>(this Energy value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Energy"/> measured in millijoules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="Energy"/> instance representing the specified value in millijoules.</returns>
	public static Energy Millijoules<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Energy>(Constants.Milli);

	/// <summary>
	/// Converts an <see cref="Energy"/> value to a numeric value measured in millijoules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Energy"/> value to convert.</param>
	/// <returns>The numeric value representing the energy in millijoules.</returns>
	public static TNumber Millijoules<TNumber>(this Energy value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Energy"/> measured in microjoules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="Energy"/> instance representing the specified value in microjoules.</returns>
	public static Energy Microjoules<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Energy>(Constants.Micro);

	/// <summary>
	/// Converts an <see cref="Energy"/> value to a numeric value measured in microjoules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Energy"/> value to convert.</param>
	/// <returns>The numeric value representing the energy in microjoules.</returns>
	public static TNumber Microjoules<TNumber>(this Energy value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Energy"/> measured in nanojoules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="Energy"/> instance representing the specified value in nanojoules.</returns>
	public static Energy Nanojoules<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Energy>(Constants.Nano);

	/// <summary>
	/// Converts an <see cref="Energy"/> value to a numeric value measured in nanojoules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Energy"/> value to convert.</param>
	/// <returns>The numeric value representing the energy in nanojoules.</returns>
	public static TNumber Nanojoules<TNumber>(this Energy value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Nano).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Energy"/> measured in kilojoules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="Energy"/> instance representing the specified value in kilojoules.</returns>
	public static Energy Kilojoules<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Energy>(Constants.Kilo);

	/// <summary>
	/// Converts an <see cref="Energy"/> value to a numeric value measured in kilojoules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Energy"/> value to convert.</param>
	/// <returns>The numeric value representing the energy in kilojoules.</returns>
	public static TNumber Kilojoules<TNumber>(this Energy value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Kilo).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Energy"/> measured in megajoules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="Energy"/> instance representing the specified value in megajoules.</returns>
	public static Energy Megajoules<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Energy>(Constants.Mega);

	/// <summary>
	/// Converts an <see cref="Energy"/> value to a numeric value measured in megajoules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Energy"/> value to convert.</param>
	/// <returns>The numeric value representing the energy in megajoules.</returns>
	public static TNumber Megajoules<TNumber>(this Energy value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Mega).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Energy"/> measured in gigajoules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="Energy"/> instance representing the specified value in gigajoules.</returns>
	public static Energy Gigajoules<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Energy>(Constants.Giga);

	/// <summary>
	/// Converts an <see cref="Energy"/> value to a numeric value measured in gigajoules.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Energy"/> value to convert.</param>
	/// <returns>The numeric value representing the energy in gigajoules.</returns>
	public static TNumber Gigajoules<TNumber>(this Energy value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Giga).To<TNumber>();
}
