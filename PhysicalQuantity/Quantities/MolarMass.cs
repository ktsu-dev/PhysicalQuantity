namespace ktsu.PhysicalQuantity.MolarMass;

using System.Numerics;

using ktsu.PhysicalQuantity.AmountOfSubstance;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Mass;

/// <summary>
/// Represents the molar mass, a physical quantity defined as the mass of a substance divided by the amount of substance.
/// </summary>
[SIUnit("kg/mol", "kilogram per mole", "kilograms per mole")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record MolarMass
	: PhysicalQuantity<MolarMass>
	, IIntegralOperators<MolarMass, AmountOfSubstance, Mass>
{
	/// <summary>
	/// Multiplies a <see cref="MolarMass"/> instance by an <see cref="AmountOfSubstance"/> instance to calculate the <see cref="Mass"/>.
	/// </summary>
	/// <param name="left">The molar mass.</param>
	/// <param name="right">The amount of substance.</param>
	/// <returns>The resulting mass.</returns>
	public static Mass operator *(MolarMass left, AmountOfSubstance right) =>
		IIntegralOperators<MolarMass, AmountOfSubstance, Mass>.Integrate(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="MolarMass"/>.
/// </summary>
public static class MolarMassConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="MolarMass"/> measured in kilograms per mole.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="MolarMass"/> instance representing the specified value in kilograms per mole.</returns>
	public static MolarMass KilogramsPerMole<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, MolarMass>();

	/// <summary>
	/// Converts a <see cref="MolarMass"/> value to a numeric value measured in kilograms per mole.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="MolarMass"/> value to convert.</param>
	/// <returns>The numeric value representing the molar mass in kilograms per mole.</returns>
	public static TNumber KilogramsPerMole<TNumber>(this MolarMass value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="MolarMass"/> measured in grams per mole.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="MolarMass"/> instance representing the specified value in grams per mole.</returns>
	public static MolarMass GramsPerMole<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, MolarMass>(Constants.Milli);

	/// <summary>
	/// Converts a <see cref="MolarMass"/> value to a numeric value measured in grams per mole.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="MolarMass"/> value to convert.</param>
	/// <returns>The numeric value representing the molar mass in grams per mole.</returns>
	public static TNumber GramsPerMole<TNumber>(this MolarMass value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="MolarMass"/> measured in milligrams per mole.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="MolarMass"/> instance representing the specified value in milligrams per mole.</returns>
	public static MolarMass MilligramsPerMole<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, MolarMass>(Constants.Micro);

	/// <summary>
	/// Converts a <see cref="MolarMass"/> value to a numeric value measured in milligrams per mole.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="MolarMass"/> value to convert.</param>
	/// <returns>The numeric value representing the molar mass in milligrams per mole.</returns>
	public static TNumber MilligramsPerMole<TNumber>(this MolarMass value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();
}
