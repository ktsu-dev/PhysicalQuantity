namespace ktsu.PhysicalQuantity.Force;

using System.Numerics;
using ktsu.PhysicalQuantity.Acceleration;
using ktsu.PhysicalQuantity.Area;
using ktsu.PhysicalQuantity.Energy;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.Pressure;

/// <summary>
/// Represents a force quantity measured in newtons.
/// </summary>
[SIUnit("N", "newton", "newtons")]
public sealed record Force
	: PhysicalQuantity<Force>
	, IDerivativeOperators<Force, Mass, Acceleration>
	, IDerivativeOperators<Force, Acceleration, Mass>
	, IDerivativeOperators<Force, Area, Pressure>
	, IIntegralOperators<Force, Length, Energy>
{
	public static Energy operator *(Force left, Length right) =>
		IIntegralOperators<Force, Length, Energy>.Integrate(left, right);

	public static Acceleration operator /(Force left, Mass right) =>
		IDerivativeOperators<Force, Mass, Acceleration>.Derive(left, right);

	public static Mass operator /(Force left, Acceleration right) =>
		IDerivativeOperators<Force, Acceleration, Mass>.Derive(left, right);

	public static Pressure operator /(Force left, Area right) =>
		IDerivativeOperators<Force, Area, Pressure>.Derive(left, right);

}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Force"/>.
/// </summary>
public static class ForceConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Force"/> measured in newtons.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="Force"/> instance representing the specified value in newtons.</returns>
	public static Force Newtons<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Force>();

	/// <summary>
	/// Converts an <see cref="Force"/> value to a numeric value measured in newtons.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Force"/> value to convert.</param>
	/// <returns>The numeric value representing the force in newtons.</returns>
	public static TNumber Newtons<TNumber>(this Force value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Force"/> measured in kilonewtons.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="Force"/> instance representing the specified value in kilonewtons.</returns>
	public static Force Kilonewtons<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Force>(Constants.Kilo);

	/// <summary>
	/// Converts an <see cref="Force"/> value to a numeric value measured in kilonewtons.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Force"/> value to convert.</param>
	/// <returns>The numeric value representing the force in kilonewtons.</returns>
	public static TNumber Kilonewtons<TNumber>(this Force value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Kilo).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Force"/> measured in millinewtons.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="Force"/> instance representing the specified value in millinewtons.</returns>
	public static Force Millinewtons<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Force>(Constants.Milli);

	/// <summary>
	/// Converts an <see cref="Force"/> value to a numeric value measured in millinewtons.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Force"/> value to convert.</param>
	/// <returns>The numeric value representing the force in millinewtons.</returns>
	public static TNumber Millinewtons<TNumber>(this Force value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Force"/> measured in micronewtons.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="Force"/> instance representing the specified value in micronewtons.</returns>
	public static Force Micronewtons<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Force>(Constants.Micro);

	/// <summary>
	/// Converts an <see cref="Force"/> value to a numeric value measured in micronewtons.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Force"/> value to convert.</param>
	/// <returns>The numeric value representing the force in micronewtons.</returns>
	public static TNumber Micronewtons<TNumber>(this Force value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Force"/> measured in pounds-force.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="Force"/> instance representing the specified value in pounds-force.</returns>
	public static Force PoundsForce<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Force>(Constants.PoundsForceToNewtonsFactor);

	/// <summary>
	/// Converts an <see cref="Force"/> value to a numeric value measured in pounds-force.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Force"/> value to convert.</param>
	/// <returns>The numeric value representing the force in pounds-force.</returns>
	public static TNumber PoundsForce<TNumber>(this Force value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.PoundsForceToNewtonsFactor).To<TNumber>();
}
