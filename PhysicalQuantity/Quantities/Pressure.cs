namespace ktsu.PhysicalQuantity.Pressure;

using System.Numerics;

using ktsu.PhysicalQuantity.Area;
using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Generic;

/// <summary>
/// Represents a pressure quantity measured in pascals.
/// </summary>
/// <remarks>
/// This class is a sealed record that inherits from <see cref="PhysicalQuantity{Pressure}"/> 
/// and implements <see cref="IIntegralOperators{Pressure, Area, Force}"/>.
/// It provides functionality for performing integral operations with other physical quantities.
/// </remarks>
[SIUnit("Pa", "pascal", "pascals")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record Pressure
	: PhysicalQuantity<Pressure>
	, IIntegralOperators<Pressure, Area, Force>
{
	/// <summary>
	/// Multiplies a <see cref="Pressure"/> instance by an <see cref="Area"/> instance to compute a <see cref="Force"/>.
	/// </summary>
	/// <param name="left">The pressure value.</param>
	/// <param name="right">The area value.</param>
	/// <returns>A <see cref="Force"/> instance representing the result of the multiplication.</returns>
	public static Force operator *(Pressure left, Area right) =>
		IIntegralOperators<Pressure, Area, Force>.Integrate(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Pressure"/>.
/// </summary>
public static class PressureConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Pressure"/> measured in pascals.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Pressure"/> instance representing the specified value in pascals.</returns>
	public static Pressure Pascals<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Pressure>();

	/// <summary>
	/// Converts a <see cref="Pressure"/> value to a numeric value measured in pascals.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Pressure"/> value to convert.</param>
	/// <returns>The numeric value representing the pressure in pascals.</returns>
	public static TNumber Pascals<TNumber>(this Pressure value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Pressure"/> measured in bars.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Pressure"/> instance representing the specified value in bars.</returns>
	public static Pressure Bars<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Pressure>(Constants.BarToPascalsFactor);

	/// <summary>
	/// Converts a <see cref="Pressure"/> value to a numeric value measured in bars.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Pressure"/> value to convert.</param>
	/// <returns>The numeric value representing the pressure in bars.</returns>
	public static TNumber Bars<TNumber>(this Pressure value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.BarToPascalsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Pressure"/> measured in psi (pounds per square inch).
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Pressure"/> instance representing the specified value in psi.</returns>
	public static Pressure Psi<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Pressure>(Constants.PsiToPascalsFactor);

	/// <summary>
	/// Converts a <see cref="Pressure"/> value to a numeric value measured in psi (pounds per square inch).
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Pressure"/> value to convert.</param>
	/// <returns>The numeric value representing the pressure in psi.</returns>
	public static TNumber Psi<TNumber>(this Pressure value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.PsiToPascalsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Pressure"/> measured in atmospheres (atm).
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Pressure"/> instance representing the specified value in atmospheres.</returns>
	public static Pressure Atmospheres<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Pressure>(Constants.AtmToPascalsFactor);

	/// <summary>
	/// Converts a <see cref="Pressure"/> value to a numeric value measured in atmospheres (atm).
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Pressure"/> value to convert.</param>
	/// <returns>The numeric value representing the pressure in atmospheres.</returns>
	public static TNumber Atmospheres<TNumber>(this Pressure value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.AtmToPascalsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Pressure"/> measured in torr.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Pressure"/> instance representing the specified value in torr.</returns>
	public static Pressure Torr<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Pressure>(Constants.TorrToPascalsFactor);

	/// <summary>
	/// Converts a <see cref="Pressure"/> value to a numeric value measured in torr.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Pressure"/> value to convert.</param>
	/// <returns>The numeric value representing the pressure in torr.</returns>
	public static TNumber Torr<TNumber>(this Pressure value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.TorrToPascalsFactor).To<TNumber>();
}
