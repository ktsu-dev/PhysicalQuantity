// Copyright (c) ktsu.dev
// All rights reserved.
// Licensed under the MIT license.

namespace ktsu.PhysicalQuantity.Momentum;

using System.Numerics;

using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.Velocity;

/// <summary>
/// Represents the physical quantity of momentum, defined as the product of mass and velocity.
/// </summary>
[SIUnit("kg·m/s", "kilogram meter per second", "kilogram meters per second")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record Momentum
	: PhysicalQuantity<Momentum>
	, IIntegralOperators<Momentum, Velocity, Force>
	, IDerivativeOperators<Momentum, Velocity, Mass>
{
	/// <summary>
	/// Multiplies a <see cref="Momentum"/> instance by a <see cref="Velocity"/> instance to compute the resulting <see cref="Force"/>.
	/// </summary>
	/// <param name="left">The momentum value.</param>
	/// <param name="right">The velocity value.</param>
	/// <returns>A new instance of <see cref="Force"/> representing the result of the integration.</returns>
	public static Force operator *(Momentum left, Velocity right) =>
		IIntegralOperators<Momentum, Velocity, Force>.Integrate(left, right);

	/// <summary>
	/// Divides a <see cref="Momentum"/> instance by a <see cref="Velocity"/> instance to compute the resulting <see cref="Mass"/>.
	/// </summary>
	/// <param name="left">The momentum value.</param>
	/// <param name="right">The velocity value.</param>
	/// <returns>A new instance of <see cref="Mass"/> representing the result of the derivative operation.</returns>
	public static Mass operator /(Momentum left, Velocity right) =>
		IDerivativeOperators<Momentum, Velocity, Mass>.Derive(left, right);
}

/// <summary>
/// Provides extension methods for converting numeric values to and from <see cref="Momentum"/> instances.
/// </summary>
public static class MomentumConversions
{
	/// <summary>
	/// Converts a numeric value to a <see cref="Momentum"/> instance in kilogram meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the input value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A new instance of <see cref="Momentum"/>.</returns>
	public static Momentum KilogramMetersPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Momentum>();

	/// <summary>
	/// Converts a <see cref="Momentum"/> instance to a numeric value in kilogram meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the output value.</typeparam>
	/// <param name="value">The momentum value to convert.</param>
	/// <returns>The numeric representation of the momentum.</returns>
	public static TNumber KilogramMetersPerSecond<TNumber>(this Momentum value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to a <see cref="Momentum"/> instance in gram meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the input value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A new instance of <see cref="Momentum"/>.</returns>
	public static Momentum GramMetersPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Momentum>(Constants.Milli);

	/// <summary>
	/// Converts a <see cref="Momentum"/> instance to a numeric value in gram meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the output value.</typeparam>
	/// <param name="value">The momentum value to convert.</param>
	/// <returns>The numeric representation of the momentum.</returns>
	public static TNumber GramMetersPerSecond<TNumber>(this Momentum value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to a <see cref="Momentum"/> instance in milligram meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the input value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A new instance of <see cref="Momentum"/>.</returns>
	public static Momentum MilligramMetersPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Momentum>(Constants.Micro);

	/// <summary>
	/// Converts a <see cref="Momentum"/> instance to a numeric value in milligram meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the output value.</typeparam>
	/// <param name="value">The momentum value to convert.</param>
	/// <returns>The numeric representation of the momentum.</returns>
	public static TNumber MilligramMetersPerSecond<TNumber>(this Momentum value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();
}
