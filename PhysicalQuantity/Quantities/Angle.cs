// Copyright (c) ktsu.dev
// All rights reserved.
// Licensed under the MIT license.

namespace ktsu.PhysicalQuantity.Angle;

using System.Numerics;

using ktsu.PhysicalQuantity.AngularVelocity;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Time;

/// <summary>
/// Represents an angle as a physical quantity.
/// </summary>
[SIUnit("rad", "radian", "radians")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record Angle
	: PhysicalQuantity<Angle>
	, IDerivativeOperators<Angle, Time, AngularVelocity>
{
	/// <summary>
	/// Divides an <see cref="Angle"/> by a <see cref="Time"/> to compute the <see cref="AngularVelocity"/>.
	/// </summary>
	/// <param name="left">The angle to divide.</param>
	/// <param name="right">The time to divide by.</param>
	/// <returns>An instance of <see cref="AngularVelocity"/> representing the result of the division.</returns>
	public static AngularVelocity operator /(Angle left, Time right) =>
		IDerivativeOperators<Angle, Time, AngularVelocity>.Derive(left, right);
}

/// <summary>
/// Provides extension methods for converting numerical values to and from <see cref="Angle"/> quantities.
/// </summary>
public static class AngleConversions
{
	// Base unit: Radians
	/// <summary>
	/// Converts a numerical value to <see cref="Angle"/> in radians.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Angle"/>.</returns>
	public static Angle Radians<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Angle>();

	/// <summary>
	/// Converts an <see cref="Angle"/> value to a numerical value in radians.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Angle"/> value to convert.</param>
	/// <returns>The numerical value in radians.</returns>
	public static TNumber Radians<TNumber>(this Angle value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	// Degrees
	/// <summary>
	/// Converts a numerical value to <see cref="Angle"/> in degrees.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Angle"/>.</returns>
	public static Angle Degrees<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Angle>(Constants.DegreesToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="Angle"/> value to a numerical value in degrees.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Angle"/> value to convert.</param>
	/// <returns>The numerical value in degrees.</returns>
	public static TNumber Degrees<TNumber>(this Angle value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.DegreesToRadiansFactor).To<TNumber>();

	// Gradians
	/// <summary>
	/// Converts a numerical value to <see cref="Angle"/> in gradians.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Angle"/>.</returns>
	public static Angle Gradians<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Angle>(Constants.GradiansToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="Angle"/> value to a numerical value in gradians.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Angle"/> value to convert.</param>
	/// <returns>The numerical value in gradians.</returns>
	public static TNumber Gradians<TNumber>(this Angle value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.GradiansToRadiansFactor).To<TNumber>();

	// Minutes
	/// <summary>
	/// Converts a numerical value to <see cref="Angle"/> in arcminutes.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Angle"/>.</returns>
	public static Angle ArcMinutes<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Angle>(Constants.MinutesToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="Angle"/> value to a numerical value in arcminutes.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Angle"/> value to convert.</param>
	/// <returns>The numerical value in arcminutes.</returns>
	public static TNumber ArcMinutes<TNumber>(this Angle value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.MinutesToRadiansFactor).To<TNumber>();

	// Seconds
	/// <summary>
	/// Converts a numerical value to <see cref="Angle"/> in arcseconds.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Angle"/>.</returns>
	public static Angle ArcSeconds<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Angle>(Constants.SecondsToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="Angle"/> value to a numerical value in arcseconds.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Angle"/> value to convert.</param>
	/// <returns>The numerical value in arcseconds.</returns>
	public static TNumber ArcSeconds<TNumber>(this Angle value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.SecondsToRadiansFactor).To<TNumber>();

	// Revolutions
	/// <summary>
	/// Converts a numerical value to <see cref="Angle"/> in revolutions.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Angle"/>.</returns>
	public static Angle Revolutions<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Angle>(Constants.RevolutionsToRadiansFactor);

	/// <summary>
	/// Converts an <see cref="Angle"/> value to a numerical value in revolutions.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Angle"/> value to convert.</param>
	/// <returns>The numerical value in revolutions.</returns>
	public static TNumber Revolutions<TNumber>(this Angle value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.RevolutionsToRadiansFactor).To<TNumber>();
}
