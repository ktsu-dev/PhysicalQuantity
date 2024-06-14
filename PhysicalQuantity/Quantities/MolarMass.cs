namespace ktsu.io.PhysicalQuantity.MolarMass;

using System.Numerics;
using ktsu.io.PhysicalQuantity.AmountOfSubstance;
using ktsu.io.PhysicalQuantity.Generic;
using ktsu.io.PhysicalQuantity.Mass;

[SIUnit("g/mol", "gram per mole", "grams per mole")]
public sealed record MolarMass
	: PhysicalQuantity<MolarMass>
	, IIntegralOperators<MolarMass, AmountOfSubstance, Mass>
{
	public static Mass operator *(MolarMass left, AmountOfSubstance right) =>
		IIntegralOperators<MolarMass, AmountOfSubstance, Mass>.Integrate(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="MolarMass"/>.
/// </summary>
public static class MolarMassConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="MolarMass"/> measured in grams per mole.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="MolarMass"/> instance representing the specified value in grams per mole.</returns>
	public static MolarMass GramsPerMole<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, MolarMass>();

	/// <summary>
	/// Converts a <see cref="MolarMass"/> value to a numeric value measured in grams per mole.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="MolarMass"/> value to convert.</param>
	/// <returns>The numeric value representing the molar mass in grams per mole.</returns>
	public static TNumber GramsPerMole<TNumber>(this MolarMass value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="MolarMass"/> measured in kilograms per mole.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="MolarMass"/> instance representing the specified value in kilograms per mole.</returns>
	public static MolarMass KilogramsPerMole<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, MolarMass>(Constants.Kilo);

	/// <summary>
	/// Converts a <see cref="MolarMass"/> value to a numeric value measured in kilograms per mole.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="MolarMass"/> value to convert.</param>
	/// <returns>The numeric value representing the molar mass in kilograms per mole.</returns>
	public static TNumber KilogramsPerMole<TNumber>(this MolarMass value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Kilo).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="MolarMass"/> measured in milligrams per mole.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="MolarMass"/> instance representing the specified value in milligrams per mole.</returns>
	public static MolarMass MilligramsPerMole<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, MolarMass>(Constants.Milli);

	/// <summary>
	/// Converts a <see cref="MolarMass"/> value to a numeric value measured in milligrams per mole.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="MolarMass"/> value to convert.</param>
	/// <returns>The numeric value representing the molar mass in milligrams per mole.</returns>
	public static TNumber MilligramsPerMole<TNumber>(this MolarMass value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();
}
