namespace ktsu.PhysicalQuantity.Charge;

using System.Numerics;
using ktsu.PhysicalQuantity.ElectricCurrent;
using ktsu.PhysicalQuantity.ElectricPotential;
using ktsu.PhysicalQuantity.Energy;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Time;

[SIUnit("C", "coulomb", "coulombs")]
public sealed record Charge
	: PhysicalQuantity<Charge>
	, IDerivativeOperators<Charge, Time, ElectricCurrent>
	, IIntegralOperators<Charge, ElectricPotential, Energy>
{
	public static ElectricCurrent operator /(Charge left, Time right) =>
		IDerivativeOperators<Charge, Time, ElectricCurrent>.Derive(left, right);
	public static Energy operator *(Charge left, ElectricPotential right) =>
		IIntegralOperators<Charge, ElectricPotential, Energy>.Integrate(left, right);
}

public static class ChargeConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Charge"/> measured in coulombs.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Charge"/> instance representing the specified value in coulombs.</returns>
	public static Charge Coulombs<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Charge>();

	/// <summary>
	/// Converts a <see cref="Charge"/> value to a numeric value measured in coulombs.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Charge"/> value to convert.</param>
	/// <returns>The numeric value representing the charge in coulombs.</returns>
	public static TNumber Coulombs<TNumber>(this Charge value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Charge"/> measured in milliampere-hours.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Charge"/> instance representing the specified value in milliampere-hours.</returns>
	public static Charge MilliampereHours<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Charge>(Constants.MilliampereHoursToCoulombsFactor);

	/// <summary>
	/// Converts a <see cref="Charge"/> value to a numeric value measured in milliampere-hours.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Charge"/> value to convert.</param>
	/// <returns>The numeric value representing the charge in milliampere-hours.</returns>
	public static TNumber MilliampereHours<TNumber>(this Charge value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.MilliampereHoursToCoulombsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Charge"/> measured in ampere-hours.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Charge"/> instance representing the specified value in ampere-hours.</returns>
	public static Charge AmpereHours<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Charge>(Constants.AmpereHoursToCoulombsFactor);

	/// <summary>
	/// Converts a <see cref="Charge"/> value to a numeric value measured in ampere-hours.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Charge"/> value to convert.</param>
	/// <returns>The numeric value representing the charge in ampere-hours.</returns>
	public static TNumber AmpereHours<TNumber>(this Charge value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.AmpereHoursToCoulombsFactor).To<TNumber>();
}
