namespace ktsu.io.PhysicalQuantity.Mass;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Acceleration;
using ktsu.io.PhysicalQuantity.AmountOfSubstance;
using ktsu.io.PhysicalQuantity.Density;
using ktsu.io.PhysicalQuantity.Force;
using ktsu.io.PhysicalQuantity.Generic;
using ktsu.io.PhysicalQuantity.MolarMass;
using ktsu.io.PhysicalQuantity.Volume;

/// <summary>
/// Represents a mass quantity measured in kilograms.
/// </summary>
[SIUnit("kg", "kilogram", "kilograms")]
public sealed record Mass
	: PhysicalQuantity<Mass>
	, IDerivativeOperators<Mass, Volume, Density>
	, IDerivativeOperators<Mass, Density, Volume>
	, IDerivativeOperators<Mass, MolarMass, AmountOfSubstance>
	, IDerivativeOperators<Mass, AmountOfSubstance, MolarMass>
	, IIntegralOperators<Mass, Acceleration, Force>
{
	public static Force operator *(Mass left, Acceleration right) =>
		IIntegralOperators<Mass, Acceleration, Force>.Integrate(left, right);

	public static Density operator /(Mass left, Volume right) =>
		IDerivativeOperators<Mass, Volume, Density>.Derive(left, right);

	public static Volume operator /(Mass left, Density right) =>
		IDerivativeOperators<Mass, Density, Volume>.Derive(left, right);

	public static AmountOfSubstance operator /(Mass left, MolarMass right) =>
		IDerivativeOperators<Mass, MolarMass, AmountOfSubstance>.Derive(left, right);

	public static MolarMass operator /(Mass left, AmountOfSubstance right) =>
		IDerivativeOperators<Mass, AmountOfSubstance, MolarMass>.Derive(left, right);

}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Mass"/>.
/// </summary>
public static class MassConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Mass"/> measured in kilograms.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Mass"/> instance representing the specified value in kilograms.</returns>
	public static Mass Kilograms<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Mass>();

	/// <summary>
	/// Converts a <see cref="Mass"/> value to a numeric value measured in kilograms.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Mass"/> value to convert.</param>
	/// <returns>The numeric value representing the mass in kilograms.</returns>
	public static TNumber Kilograms<TNumber>(this Mass value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Mass"/> measured in grams.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Mass"/> instance representing the specified value in grams.</returns>
	public static Mass Grams<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Mass>(Constants.Milli);

	/// <summary>
	/// Converts a <see cref="Mass"/> value to a numeric value measured in grams.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Mass"/> value to convert.</param>
	/// <returns>The numeric value representing the mass in grams.</returns>
	public static TNumber Grams<TNumber>(this Mass value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Mass"/> measured in milligrams.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Mass"/> instance representing the specified value in milligrams.</returns>
	public static Mass Milligrams<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Mass>(Constants.Micro);

	/// <summary>
	/// Converts a <see cref="Mass"/> value to a numeric value measured in milligrams.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Mass"/> value to convert.</param>
	/// <returns>The numeric value representing the mass in milligrams.</returns>
	public static TNumber Milligrams<TNumber>(this Mass value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Mass"/> measured in pounds.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Mass"/> instance representing the specified value in pounds.</returns>
	public static Mass Pounds<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Mass>(Constants.PoundsToKilogramsFactor);

	/// <summary>
	/// Converts a <see cref="Mass"/> value to a numeric value measured in pounds.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Mass"/> value to convert.</param>
	/// <returns>The numeric value representing the mass in pounds.</returns>
	public static TNumber Pounds<TNumber>(this Mass value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.PoundsToKilogramsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Mass"/> measured in ounces.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Mass"/> instance representing the specified value in ounces.</returns>
	public static Mass Ounces<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Mass>(Constants.OuncesToKilogramsFactor);

	/// <summary>
	/// Converts a <see cref="Mass"/> value to a numeric value measured in ounces.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Mass"/> value to convert.</param>
	/// <returns>The numeric value representing the mass in ounces.</returns>
	public static TNumber Ounces<TNumber>(this Mass value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.OuncesToKilogramsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Mass"/> measured in stones.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Mass"/> instance representing the specified value in stones.</returns>
	public static Mass Stones<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Mass>(Constants.StonesToKilogramsFactor);

	/// <summary>
	/// Converts a <see cref="Mass"/> value to a numeric value measured in stones.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Mass"/> value to convert.</param>
	/// <returns>The numeric value representing the mass in stones.</returns>
	public static TNumber Stones<TNumber>(this Mass value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.StonesToKilogramsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Mass"/> measured in metric tons.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Mass"/> instance representing the specified value in metric tons.</returns>
	public static Mass MetricTons<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Mass>(Constants.MetricTonsToKilogramsFactor);

	/// <summary>
	/// Converts a <see cref="Mass"/> value to a numeric value measured in metric tons.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Mass"/> value to convert.</param>
	/// <returns>The numeric value representing the mass in metric tons.</returns>
	public static TNumber MetricTons<TNumber>(this Mass value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.MetricTonsToKilogramsFactor).To<TNumber>();
}
