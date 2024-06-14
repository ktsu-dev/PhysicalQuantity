namespace ktsu.io.PhysicalQuantity.AngularVelocity;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Angle;
using ktsu.io.PhysicalQuantity.AngularAcceleration;
using ktsu.io.PhysicalQuantity.Generic;
using ktsu.io.PhysicalQuantity.Time;

[SIUnit("rad/s", "radian per second", "radians per second")]
public sealed record AngularVelocity
	: PhysicalQuantity<AngularVelocity>
	, IDerivativeOperators<AngularVelocity, Time, AngularAcceleration>
	, IIntegralOperators<AngularVelocity, Time, Angle>
{
	public static Angle operator *(AngularVelocity left, Time right) =>
		IIntegralOperators<AngularVelocity, Time, Angle>.Integrate(left, right);

	public static AngularAcceleration operator /(AngularVelocity left, Time right) =>
		IDerivativeOperators<AngularVelocity, Time, AngularAcceleration>.Derive(left, right);
}

/// <summary>
/// Provides extension methods for converting numerical values to and from <see cref="AngularVelocity"/> quantities.
/// </summary>
public static class AngularVelocityConversions
{
	// Base unit: Radians per second
	/// <summary>
	/// Converts a numerical value to <see cref="AngularVelocity"/> in radians per second.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="AngularVelocity"/>.</returns>
	public static AngularVelocity RadiansPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularVelocity>();

	/// <summary>
	/// Converts an <see cref="AngularVelocity"/> value to a numerical value in radians per second.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="AngularVelocity"/> value to convert.</param>
	/// <returns>The numerical value in radians per second.</returns>
	public static TNumber RadiansPerSecond<TNumber>(this AngularVelocity value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	// Degrees per second
	/// <summary>
	/// Converts a numerical value to <see cref="AngularVelocity"/> in degrees per second.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="AngularVelocity"/>.</returns>
	public static AngularVelocity DegreesPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularVelocity>(Constants.DegreesToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="AngularVelocity"/> value to a numerical value in degrees per second.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="AngularVelocity"/> value to convert.</param>
	/// <returns>The numerical value in degrees per second.</returns>
	public static TNumber DegreesPerSecond<TNumber>(this AngularVelocity value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.DegreesToRadiansFactor).To<TNumber>();

	// Gradians per second
	/// <summary>
	/// Converts a numerical value to <see cref="AngularVelocity"/> in gradians per second.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="AngularVelocity"/>.</returns>
	public static AngularVelocity GradiansPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularVelocity>(Constants.GradiansToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="AngularVelocity"/> value to a numerical value in gradians per second.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="AngularVelocity"/> value to convert.</param>
	/// <returns>The numerical value in gradians per second.</returns>
	public static TNumber GradiansPerSecond<TNumber>(this AngularVelocity value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.GradiansToRadiansFactor).To<TNumber>();

	// Revolutions per second
	/// <summary>
	/// Converts a numerical value to <see cref="AngularVelocity"/> in revolutions per second.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="AngularVelocity"/>.</returns>
	public static AngularVelocity RevolutionsPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularVelocity>(Constants.RevolutionsToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="AngularVelocity"/> value to a numerical value in revolutions per second.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="AngularVelocity"/> value to convert.</param>
	/// <returns>The numerical value in revolutions per second.</returns>
	public static TNumber RevolutionsPerSecond<TNumber>(this AngularVelocity value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.RevolutionsToRadiansFactor).To<TNumber>();

	// Cycles per second
	/// <summary>
	/// Converts a numerical value to <see cref="AngularVelocity"/> in cycles per second.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="AngularVelocity"/>.</returns>
	public static AngularVelocity CyclesPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularVelocity>(Constants.CyclesToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="AngularVelocity"/> value to a numerical value in cycles per second.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="AngularVelocity"/> value to convert.</param>
	/// <returns>The numerical value in cycles per second.</returns>
	public static TNumber CyclesPerSecond<TNumber>(this AngularVelocity value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.CyclesToRadiansFactor).To<TNumber>();

	// Turns per second
	/// <summary>
	/// Converts a numerical value to <see cref="AngularVelocity"/> in turns per second.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="AngularVelocity"/>.</returns>
	public static AngularVelocity TurnsPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularVelocity>(Constants.TurnsToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="AngularVelocity"/> value to a numerical value in turns per second.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="AngularVelocity"/> value to convert.</param>
	/// <returns>The numerical value in turns per second.</returns>
	public static TNumber TurnsPerSecond<TNumber>(this AngularVelocity value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.TurnsToRadiansFactor).To<TNumber>();
}
