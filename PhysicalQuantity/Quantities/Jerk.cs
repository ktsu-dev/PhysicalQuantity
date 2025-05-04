// Copyright (c) ktsu.dev
// All rights reserved.
// Licensed under the MIT license.

namespace ktsu.PhysicalQuantity.Jerk;

using System.Numerics;

using ktsu.PhysicalQuantity.Acceleration;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Time;

/// <summary>
/// Represents the physical quantity of jerk, which is the rate of change of acceleration over time.
/// </summary>
[SIUnit("m/s³", "meter per second cubed", "meters per second cubed")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record Jerk
	: PhysicalQuantity<Jerk>
	, IIntegralOperators<Jerk, Time, Acceleration>
{
	/// <summary>
	/// Multiplies a <see cref="Jerk"/> instance by a <see cref="Time"/> instance to compute the resulting <see cref="Acceleration"/>.
	/// </summary>
	/// <param name="left">The jerk value.</param>
	/// <param name="right">The time value.</param>
	/// <returns>An <see cref="Acceleration"/> instance representing the result of the integration.</returns>
	public static Acceleration operator *(Jerk left, Time right) =>
		IIntegralOperators<Jerk, Time, Acceleration>.Integrate(left, right);
}

/// <summary>
/// Provides extension methods for converting numeric values to and from <see cref="Jerk"/> instances.
/// </summary>
public static class JerkConversions
{
	/// <summary>
	/// Converts a numeric value to a <see cref="Jerk"/> instance in meters per second cubed.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A <see cref="Jerk"/> instance.</returns>
	public static Jerk MetersPerSecondCubed<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Jerk>();

	/// <summary>
	/// Converts a <see cref="Jerk"/> instance to a numeric value in meters per second cubed.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Jerk"/> instance to convert.</param>
	/// <returns>The numeric value.</returns>
	public static TNumber MetersPerSecondCubed<TNumber>(this Jerk value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to a <see cref="Jerk"/> instance in feet per second cubed.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A <see cref="Jerk"/> instance.</returns>
	public static Jerk FeetPerSecondCubed<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Jerk>(Constants.FeetToMetersFactor);

	/// <summary>
	/// Converts a <see cref="Jerk"/> instance to a numeric value in feet per second cubed.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Jerk"/> instance to convert.</param>
	/// <returns>The numeric value.</returns>
	public static TNumber FeetPerSecondCubed<TNumber>(this Jerk value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.FeetToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to a <see cref="Jerk"/> instance in inches per second cubed.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A <see cref="Jerk"/> instance.</returns>
	public static Jerk InchesPerSecondCubed<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Jerk>(Constants.InchesToMetersFactor);

	/// <summary>
	/// Converts a <see cref="Jerk"/> instance to a numeric value in inches per second cubed.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Jerk"/> instance to convert.</param>
	/// <returns>The numeric value.</returns>
	public static TNumber InchesPerSecondCubed<TNumber>(this Jerk value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.InchesToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to a <see cref="Jerk"/> instance in yards per second cubed.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A <see cref="Jerk"/> instance.</returns>
	public static Jerk YardsPerSecondCubed<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Jerk>(Constants.YardsToMetersFactor);

	/// <summary>
	/// Converts a <see cref="Jerk"/> instance to a numeric value in yards per second cubed.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Jerk"/> instance to convert.</param>
	/// <returns>The numeric value.</returns>
	public static TNumber YardsPerSecondCubed<TNumber>(this Jerk value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.YardsToMetersFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to a <see cref="Jerk"/> instance in miles per second cubed.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A <see cref="Jerk"/> instance.</returns>
	public static Jerk MilesPerSecondCubed<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Jerk>(Constants.MilesToMetersFactor);

	/// <summary>
	/// Converts a <see cref="Jerk"/> instance to a numeric value in miles per second cubed.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Jerk"/> instance to convert.</param>
	/// <returns>The numeric value.</returns>
	public static TNumber MilesPerSecondCubed<TNumber>(this Jerk value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.MilesToMetersFactor).To<TNumber>();
}
