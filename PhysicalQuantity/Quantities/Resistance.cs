namespace ktsu.PhysicalQuantity.Resistance;

using System.Numerics;
using ktsu.PhysicalQuantity.ElectricCurrent;
using ktsu.PhysicalQuantity.ElectricPotential;
using ktsu.PhysicalQuantity.Generic;

/// <summary>
/// Represents an electrical resistance quantity measured in ohms.
/// </summary>
[SIUnit("Ω", "ohm", "ohms")]
public sealed record Resistance
	: PhysicalQuantity<Resistance>
	, IIntegralOperators<Resistance, ElectricCurrent, ElectricPotential>
{
	public static ElectricPotential operator *(Resistance left, ElectricCurrent right) =>
		IIntegralOperators<Resistance, ElectricCurrent, ElectricPotential>.Integrate(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Resistance"/>.
/// </summary>
public static class ResistanceConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Resistance"/> measured in ohms.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Resistance"/> instance representing the specified value in ohms.</returns>
	public static Resistance Ohms<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Resistance>();

	/// <summary>
	/// Converts a <see cref="Resistance"/> value to a numeric value measured in ohms.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Resistance"/> value to convert.</param>
	/// <returns>The numeric value representing the resistance in ohms.</returns>
	public static TNumber Ohms<TNumber>(this Resistance value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Resistance"/> measured in milliohms.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Resistance"/> instance representing the specified value in milliohms.</returns>
	public static Resistance Milliohms<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Resistance>(Constants.Milli);

	/// <summary>
	/// Converts a <see cref="Resistance"/> value to a numeric value measured in milliohms.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Resistance"/> value to convert.</param>
	/// <returns>The numeric value representing the resistance in milliohms.</returns>
	public static TNumber Milliohms<TNumber>(this Resistance value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Resistance"/> measured in kiloohms.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Resistance"/> instance representing the specified value in kiloohms.</returns>
	public static Resistance Kiloohms<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Resistance>(Constants.Kilo);

	/// <summary>
	/// Converts a <see cref="Resistance"/> value to a numeric value measured in kiloohms.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Resistance"/> value to convert.</param>
	/// <returns>The numeric value representing the resistance in kiloohms.</returns>
	public static TNumber Kiloohms<TNumber>(this Resistance value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Kilo).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Resistance"/> measured in megaohms.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Resistance"/> instance representing the specified value in megaohms.</returns>
	public static Resistance Megaohms<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Resistance>(Constants.Mega);

	/// <summary>
	/// Converts a <see cref="Resistance"/> value to a numeric value measured in megaohms.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Resistance"/> value to convert.</param>
	/// <returns>The numeric value representing the resistance in megaohms.</returns>
	public static TNumber Megaohms<TNumber>(this Resistance value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Mega).To<TNumber>();
}
