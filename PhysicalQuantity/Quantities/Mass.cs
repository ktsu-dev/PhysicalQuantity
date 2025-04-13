namespace ktsu.PhysicalQuantity.Mass;

using System.Numerics;

using ktsu.PhysicalQuantity.Acceleration;
using ktsu.PhysicalQuantity.AmountOfSubstance;
using ktsu.PhysicalQuantity.Density;
using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.MolarMass;
using ktsu.PhysicalQuantity.Momentum;
using ktsu.PhysicalQuantity.Velocity;
using ktsu.PhysicalQuantity.Volume;

/// <summary>
/// Represents a mass quantity measured in kilograms.
/// </summary>
[SIUnit("kg", "kilogram", "kilograms")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record Mass
	: PhysicalQuantity<Mass>
	, IDerivativeOperators<Mass, Volume, Density>
	, IDerivativeOperators<Mass, Density, Volume>
	, IDerivativeOperators<Mass, MolarMass, AmountOfSubstance>
	, IDerivativeOperators<Mass, AmountOfSubstance, MolarMass>
	, IIntegralOperators<Mass, Velocity, Momentum>
	, IIntegralOperators<Mass, Acceleration, Force>
{
	/// <summary>
	/// Multiplies a <see cref="Mass"/> instance with an <see cref="Acceleration"/> instance to compute the resulting <see cref="Force"/>.
	/// </summary>
	/// <param name="left">The mass operand.</param>
	/// <param name="right">The acceleration operand.</param>
	/// <returns>A <see cref="Force"/> instance representing the result of the multiplication.</returns>
	public static Force operator *(Mass left, Acceleration right) =>
		IIntegralOperators<Mass, Acceleration, Force>.Integrate(left, right);

	/// <summary>
	/// Multiplies a <see cref="Mass"/> instance with a <see cref="Velocity"/> instance to compute the resulting <see cref="Momentum"/>.
	/// </summary>
	/// <param name="left">The mass operand.</param>
	/// <param name="right">The velocity operand.</param>
	/// <returns>A <see cref="Momentum"/> instance representing the result of the multiplication.</returns>
	public static Momentum operator *(Mass left, Velocity right) =>
		IIntegralOperators<Mass, Velocity, Momentum>.Integrate(left, right);

	/// <summary>
	/// Divides a <see cref="Mass"/> instance by a <see cref="Volume"/> instance to compute the resulting <see cref="Density"/>.
	/// </summary>
	/// <param name="left">The mass operand.</param>
	/// <param name="right">The volume operand.</param>
	/// <returns>A <see cref="Density"/> instance representing the result of the division.</returns>
	public static Density operator /(Mass left, Volume right) =>
		IDerivativeOperators<Mass, Volume, Density>.Derive(left, right);

	/// <summary>
	/// Divides a <see cref="Mass"/> instance by a <see cref="Density"/> instance to compute the resulting <see cref="Volume"/>.
	/// </summary>
	/// <param name="left">The mass operand.</param>
	/// <param name="right">The density operand.</param>
	/// <returns>A <see cref="Volume"/> instance representing the result of the division.</returns>
	public static Volume operator /(Mass left, Density right) =>
		IDerivativeOperators<Mass, Density, Volume>.Derive(left, right);

	/// <summary>
	/// Divides a <see cref="Mass"/> instance by a <see cref="MolarMass"/> instance to compute the resulting <see cref="AmountOfSubstance"/>.
	/// </summary>
	/// <param name="left">The mass operand.</param>
	/// <param name="right">The molar mass operand.</param>
	/// <returns>An <see cref="AmountOfSubstance"/> instance representing the result of the division.</returns>
	public static AmountOfSubstance operator /(Mass left, MolarMass right) =>
		IDerivativeOperators<Mass, MolarMass, AmountOfSubstance>.Derive(left, right);

	/// <summary>
	/// Divides a <see cref="Mass"/> instance by an <see cref="AmountOfSubstance"/> instance to compute the resulting <see cref="MolarMass"/>.
	/// </summary>
	/// <param name="left">The mass operand.</param>
	/// <param name="right">The amount of substance operand.</param>
	/// <returns>A <see cref="MolarMass"/> instance representing the result of the division.</returns>
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
