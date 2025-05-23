// Copyright (c) ktsu.dev
// All rights reserved.
// Licensed under the MIT license.

namespace ktsu.PhysicalQuantity.Acceleration;

using System.Numerics;

using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Jerk;
using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.Time;
using ktsu.PhysicalQuantity.Velocity;

/// <summary>
/// Represents the physical quantity of acceleration.
/// </summary>
[SIUnit("m/s²", "meter per second squared", "meters per second squared")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record Acceleration
	: PhysicalQuantity<Acceleration>
	, IDerivativeOperators<Acceleration, Time, Jerk>
	, IIntegralOperators<Acceleration, Time, Velocity>
	, IIntegralOperators<Acceleration, Mass, Force>
{
	/// <summary>
	/// Divides an <see cref="Acceleration"/> by a <see cref="Time"/> to compute the <see cref="Jerk"/>.
	/// </summary>
	/// <param name="left">The acceleration value.</param>
	/// <param name="right">The time value.</param>
	/// <returns>The resulting <see cref="Jerk"/>.</returns>
	public static Jerk operator /(Acceleration left, Time right) =>
		IDerivativeOperators<Acceleration, Time, Jerk>.Derive(left, right);

	/// <summary>
	/// Multiplies an <see cref="Acceleration"/> by a <see cref="Time"/> to compute the <see cref="Velocity"/>.
	/// </summary>
	/// <param name="left">The acceleration value.</param>
	/// <param name="right">The time value.</param>
	/// <returns>The resulting <see cref="Velocity"/>.</returns>
	public static Velocity operator *(Acceleration left, Time right) =>
		IIntegralOperators<Acceleration, Time, Velocity>.Integrate(left, right);

	/// <summary>
	/// Multiplies an <see cref="Acceleration"/> by a <see cref="Mass"/> to compute the <see cref="Force"/>.
	/// </summary>
	/// <param name="left">The acceleration value.</param>
	/// <param name="right">The mass value.</param>
	/// <returns>The resulting <see cref="Force"/>.</returns>
	public static Force operator *(Acceleration left, Mass right) =>
		IIntegralOperators<Acceleration, Mass, Force>.Integrate(left, right);
}

/// <summary>
/// Provides extension methods for converting to and from <see cref="Acceleration"/>.
/// </summary>
public static class AccelerationConversions
{
	/// <summary>
	/// Converts a numerical value to <see cref="Acceleration"/> in meters per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Acceleration"/>.</returns>
	public static Acceleration MetersPerSecondSquared<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Acceleration>();

	/// <summary>
	/// Converts an <see cref="Acceleration"/> value to a numerical value in meters per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Acceleration"/> value to convert.</param>
	/// <returns>The numerical value in meters per second squared.</returns>
	public static TNumber MetersPerSecondSquared<TNumber>(this Acceleration value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numerical value to <see cref="Acceleration"/> in feet per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Acceleration"/>.</returns>
	public static Acceleration FeetPerSecondSquared<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Acceleration>(Constants.FeetToMetersFactor);

	/// <summary>
	/// Converts an <see cref="Acceleration"/> value to a numerical value in feet per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Acceleration"/> value to convert.</param>
	/// <returns>The numerical value in feet per second squared.</returns>
	public static TNumber FeetPerSecondSquared<TNumber>(this Acceleration value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.FeetToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a numerical value to <see cref="Acceleration"/> in inches per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Acceleration"/>.</returns>
	public static Acceleration InchesPerSecondSquared<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Acceleration>(Constants.InchesToMetersFactor);

	/// <summary>
	/// Converts an <see cref="Acceleration"/> value to a numerical value in inches per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Acceleration"/> value to convert.</param>
	/// <returns>The numerical value in inches per second squared.</returns>
	public static TNumber InchesPerSecondSquared<TNumber>(this Acceleration value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.InchesToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a numerical value to <see cref="Acceleration"/> in yards per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Acceleration"/>.</returns>
	public static Acceleration YardsPerSecondSquared<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Acceleration>(Constants.YardsToMetersFactor);

	/// <summary>
	/// Converts an <see cref="Acceleration"/> value to a numerical value in yards per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Acceleration"/> value to convert.</param>
	/// <returns>The numerical value in yards per second squared.</returns>
	public static TNumber YardsPerSecondSquared<TNumber>(this Acceleration value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.YardsToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a numerical value to <see cref="Acceleration"/> in miles per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Acceleration"/>.</returns>
	public static Acceleration MilesPerSecondSquared<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Acceleration>(Constants.MilesToMetersFactor);

	/// <summary>
	/// Converts an <see cref="Acceleration"/> value to a numerical value in miles per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Acceleration"/> value to convert.</param>
	/// <returns>The numerical value in miles per second squared.</returns>
	public static TNumber MilesPerSecondSquared<TNumber>(this Acceleration value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.MilesToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a numerical value to <see cref="Acceleration"/> in nautical miles per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Acceleration"/>.</returns>
	public static Acceleration NauticalMilesPerSecondSquared<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Acceleration>(Constants.NauticalMilesToMetersFactor);

	/// <summary>
	/// Converts an <see cref="Acceleration"/> value to a numerical value in nautical miles per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Acceleration"/> value to convert.</param>
	/// <returns>The numerical value in nautical miles per second squared.</returns>
	public static TNumber NauticalMilesPerSecondSquared<TNumber>(this Acceleration value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.NauticalMilesToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a numerical value to <see cref="Acceleration"/> in fathoms per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Acceleration"/>.</returns>
	public static Acceleration FathomsPerSecondSquared<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Acceleration>(Constants.FathomsToMetersFactor);

	/// <summary>
	/// Converts an <see cref="Acceleration"/> value to a numerical value in fathoms per second squared.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Acceleration"/> value to convert.</param>
	/// <returns>The numerical value in fathoms per second squared.</returns>
	public static TNumber FathomsPerSecondSquared<TNumber>(this Acceleration value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.FathomsToMetersFactor).To<TNumber>();
}
