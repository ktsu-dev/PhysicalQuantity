// Copyright (c) ktsu.dev
// All rights reserved.
// Licensed under the MIT license.

namespace ktsu.PhysicalQuantity.SolidAngle;

using System.Numerics;

using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.LuminousFlux;
using ktsu.PhysicalQuantity.LuminousIntensity;

/// <summary>
/// Represents a solid angle, a measure of the two-dimensional angle in three-dimensional space.
/// </summary>
[SIUnit("sr", "steradian", "steradians")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record SolidAngle
	: PhysicalQuantity<SolidAngle>
	, IIntegralOperators<SolidAngle, LuminousIntensity, LuminousFlux>
{
	/// <summary>
	/// Multiplies a <see cref="SolidAngle"/> by a <see cref="LuminousIntensity"/> to produce a <see cref="LuminousFlux"/>.
	/// </summary>
	/// <param name="left">The solid angle.</param>
	/// <param name="right">The luminous intensity.</param>
	/// <returns>The resulting luminous flux.</returns>
	public static LuminousFlux operator *(SolidAngle left, LuminousIntensity right) =>
		IIntegralOperators<SolidAngle, LuminousIntensity, LuminousFlux>.Integrate(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="SolidAngle"/>.
/// </summary>
public static class SolidAngleConversions
{
	/// <summary>
	/// Converts a numeric value to a <see cref="SolidAngle"/> in steradians.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A <see cref="SolidAngle"/> representing the value in steradians.</returns>
	public static SolidAngle Steradians<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, SolidAngle>();

	/// <summary>
	/// Converts a <see cref="SolidAngle"/> to a numeric value in steradians.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The solid angle to convert.</param>
	/// <returns>The numeric value representing the solid angle in steradians.</returns>
	public static TNumber Steradians<TNumber>(this SolidAngle value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to a <see cref="SolidAngle"/> in square degrees.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A <see cref="SolidAngle"/> representing the value in square degrees.</returns>
	public static SolidAngle SquareDegrees<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, SolidAngle>(Constants.SquareDegreesToSteradiansFactor);

	/// <summary>
	/// Converts a <see cref="SolidAngle"/> to a numeric value in square degrees.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numeric value.</typeparam>
	/// <param name="value">The solid angle to convert.</param>
	/// <returns>The numeric value representing the solid angle in square degrees.</returns>
	public static TNumber SquareDegrees<TNumber>(this SolidAngle value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.SquareDegreesToSteradiansFactor).To<TNumber>();
}
