namespace ktsu.io.PhysicalQuantity.AmountOfSubstance;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Generic;
using ktsu.io.PhysicalQuantity.Mass;
using ktsu.io.PhysicalQuantity.MolarMass;

/// <summary>
/// Represents an amount of substance quantity measured in moles.
/// </summary>
[SIUnit("mol", "mole", "moles")]
public sealed record AmountOfSubstance
	: PhysicalQuantity<AmountOfSubstance>
	, IIntegralOperators<AmountOfSubstance, MolarMass, Mass>
{
	public static Mass operator *(AmountOfSubstance left, MolarMass right) =>
		IIntegralOperators<AmountOfSubstance, MolarMass, Mass>.Integrate(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="AmountOfSubstance"/>.
/// </summary>
public static class AmountOfSubstanceConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="AmountOfSubstance"/> measured in moles.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="AmountOfSubstance"/> instance representing the specified value in moles.</returns>
	public static AmountOfSubstance Moles<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AmountOfSubstance>();

	/// <summary>
	/// Converts a <see cref="AmountOfSubstance"/> value to a numeric value measured in moles.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="AmountOfSubstance"/> value to convert.</param>
	/// <returns>The numeric value representing the amount of substance in moles.</returns>
	public static TNumber Moles<TNumber>(this AmountOfSubstance value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="AmountOfSubstance"/> measured in kilomoles.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="AmountOfSubstance"/> instance representing the specified value in kilomoles.</returns>
	public static AmountOfSubstance Kilomoles<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AmountOfSubstance>(Constants.Kilo);

	/// <summary>
	/// Converts a <see cref="AmountOfSubstance"/> value to a numeric value measured in kilomoles.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="AmountOfSubstance"/> value to convert.</param>
	/// <returns>The numeric value representing the amount of substance in kilomoles.</returns>
	public static TNumber Kilomoles<TNumber>(this AmountOfSubstance value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Kilo).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="AmountOfSubstance"/> measured in millimoles.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="AmountOfSubstance"/> instance representing the specified value in millimoles.</returns>
	public static AmountOfSubstance Millimoles<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AmountOfSubstance>(Constants.Milli);

	/// <summary>
	/// Converts a <see cref="AmountOfSubstance"/> value to a numeric value measured in millimoles.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="AmountOfSubstance"/> value to convert.</param>
	/// <returns>The numeric value representing the amount of substance in millimoles.</returns>
	public static TNumber Millimoles<TNumber>(this AmountOfSubstance value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="AmountOfSubstance"/> measured in micromoles.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="AmountOfSubstance"/> instance representing the specified value in micromoles.</returns>
	public static AmountOfSubstance Micromoles<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AmountOfSubstance>(Constants.Micro);

	/// <summary>
	/// Converts a <see cref="AmountOfSubstance"/> value to a numeric value measured in micromoles.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="AmountOfSubstance"/> value to convert.</param>
	/// <returns>The numeric value representing the amount of substance in micromoles.</returns>
	public static TNumber Micromoles<TNumber>(this AmountOfSubstance value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="AmountOfSubstance"/> measured in nanomoles.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="AmountOfSubstance"/> instance representing the specified value in nanomoles.</returns>
	public static AmountOfSubstance Nanomoles<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AmountOfSubstance>(Constants.Nano);

	/// <summary>
	/// Converts a <see cref="AmountOfSubstance"/> value to a numeric value measured in nanomoles.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="AmountOfSubstance"/> value to convert.</param>
	/// <returns>The numeric value representing the amount of substance in nanomoles.</returns>
	public static TNumber Nanomoles<TNumber>(this AmountOfSubstance value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Nano).To<TNumber>();
}
