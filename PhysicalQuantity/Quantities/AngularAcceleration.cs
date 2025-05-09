// Copyright (c) ktsu.dev
// All rights reserved.
// Licensed under the MIT license.

namespace ktsu.PhysicalQuantity.AngularAcceleration;

using System.Numerics;

using ktsu.PhysicalQuantity.AngularVelocity;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Time;

/// <summary>
/// Represents the angular acceleration, a measure of the rate of change of angular velocity over time.
/// </summary>
[SIUnit("rad/s²", "radian per second squared", "radians per second squared")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record AngularAcceleration
	: PhysicalQuantity<AngularAcceleration>
	, IIntegralOperators<AngularAcceleration, Time, AngularVelocity>
{
	/// <summary>
	/// Multiplies an <see cref="AngularAcceleration"/> by a <see cref="Time"/> to compute the resulting <see cref="AngularVelocity"/>.
	/// </summary>
	/// <param name="left">The angular acceleration.</param>
	/// <param name="right">The time duration.</param>
	/// <returns>The resulting angular velocity.</returns>
	public static AngularVelocity operator *(AngularAcceleration left, Time right) =>
		IIntegralOperators<AngularAcceleration, Time, AngularVelocity>.Integrate(left, right);
}

/// <summary>
/// Provides extension methods for converting numerical values to and from <see cref="AngularAcceleration"/> quantities.
/// </summary>
public static class AngularAccelerationConversions
{
	// Base unit: Radians per second squared
	/// <summary>
	/// Converts a numerical value to <see cref="AngularAcceleration"/> in radians per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="AngularAcceleration"/>.</returns>
	public static AngularAcceleration RadiansPerSecondSquared<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularAcceleration>();

	/// <summary>
	/// Converts an <see cref="AngularAcceleration"/> value to a numerical value in radians per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="AngularAcceleration"/> value to convert.</param>
	/// <returns>The numerical value in radians per second squared.</returns>
	public static TNumber RadiansPerSecondSquared<TNumber>(this AngularAcceleration value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	// Degrees per second squared
	/// <summary>
	/// Converts a numerical value to <see cref="AngularAcceleration"/> in degrees per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="AngularAcceleration"/>.</returns>
	public static AngularAcceleration DegreesPerSecondSquared<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularAcceleration>(Constants.DegreesToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="AngularAcceleration"/> value to a numerical value in degrees per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="AngularAcceleration"/> value to convert.</param>
	/// <returns>The numerical value in degrees per second squared.</returns>
	public static TNumber DegreesPerSecondSquared<TNumber>(this AngularAcceleration value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.DegreesToRadiansFactor).To<TNumber>();

	// Gradians per second squared
	/// <summary>
	/// Converts a numerical value to <see cref="AngularAcceleration"/> in gradians per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="AngularAcceleration"/>.</returns>
	public static AngularAcceleration GradiansPerSecondSquared<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularAcceleration>(Constants.GradiansToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="AngularAcceleration"/> value to a numerical value in gradians per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="AngularAcceleration"/> value to convert.</param>
	/// <returns>The numerical value in gradians per second squared.</returns>
	public static TNumber GradiansPerSecondSquared<TNumber>(this AngularAcceleration value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.GradiansToRadiansFactor).To<TNumber>();

	// Revolutions per second squared
	/// <summary>
	/// Converts a numerical value to <see cref="AngularAcceleration"/> in revolutions per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="AngularAcceleration"/>.</returns>
	public static AngularAcceleration RevolutionsPerSecondSquared<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularAcceleration>(Constants.RevolutionsToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="AngularAcceleration"/> value to a numerical value in revolutions per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="AngularAcceleration"/> value to convert.</param>
	/// <returns>The numerical value in revolutions per second squared.</returns>
	public static TNumber RevolutionsPerSecondSquared<TNumber>(this AngularAcceleration value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.RevolutionsToRadiansFactor).To<TNumber>();

	// Cycles per second squared
	/// <summary>
	/// Converts a numerical value to <see cref="AngularAcceleration"/> in cycles per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="AngularAcceleration"/>.</returns>
	public static AngularAcceleration CyclesPerSecondSquared<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularAcceleration>(Constants.CyclesToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="AngularAcceleration"/> value to a numerical value in cycles per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="AngularAcceleration"/> value to convert.</param>
	/// <returns>The numerical value in cycles per second squared.</returns>
	public static TNumber CyclesPerSecondSquared<TNumber>(this AngularAcceleration value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.CyclesToRadiansFactor).To<TNumber>();

	// Turns per second squared
	/// <summary>
	/// Converts a numerical value to <see cref="AngularAcceleration"/> in turns per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="AngularAcceleration"/>.</returns>
	public static AngularAcceleration TurnsPerSecondSquared<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularAcceleration>(Constants.TurnsToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="AngularAcceleration"/> value to a numerical value in turns per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="AngularAcceleration"/> value to convert.</param>
	/// <returns>The numerical value in turns per second squared.</returns>
	public static TNumber TurnsPerSecondSquared<TNumber>(this AngularAcceleration value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.TurnsToRadiansFactor).To<TNumber>();
}
