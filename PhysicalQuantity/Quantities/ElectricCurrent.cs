// Copyright (c) ktsu.dev
// All rights reserved.
// Licensed under the MIT license.

namespace ktsu.PhysicalQuantity.ElectricCurrent;

using System.Numerics;

using ktsu.PhysicalQuantity.Charge;
using ktsu.PhysicalQuantity.ElectricPotential;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Power;
using ktsu.PhysicalQuantity.Resistance;
using ktsu.PhysicalQuantity.Time;

/// <summary>
/// Represents an electric current quantity measured in amperes.
/// </summary>
[SIUnit("A", "ampere", "amperes")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record ElectricCurrent
	: PhysicalQuantity<ElectricCurrent>
	, IIntegralOperators<ElectricCurrent, Resistance, ElectricPotential>
	, IIntegralOperators<ElectricCurrent, ElectricPotential, Power>
	, IIntegralOperators<ElectricCurrent, Time, Charge>
{
	/// <summary>
	/// Multiplies an <see cref="ElectricCurrent"/> by a <see cref="Resistance"/> to calculate the resulting <see cref="ElectricPotential"/>.
	/// </summary>
	/// <param name="left">The electric current value.</param>
	/// <param name="right">The resistance value.</param>
	/// <returns>The resulting electric potential.</returns>
	public static ElectricPotential operator *(ElectricCurrent left, Resistance right) =>
		IIntegralOperators<ElectricCurrent, Resistance, ElectricPotential>.Integrate(left, right);

	/// <summary>
	/// Multiplies an <see cref="ElectricCurrent"/> by an <see cref="ElectricPotential"/> to calculate the resulting <see cref="Power"/>.
	/// </summary>
	/// <param name="left">The electric current value.</param>
	/// <param name="right">The electric potential value.</param>
	/// <returns>The resulting power.</returns>
	public static Power operator *(ElectricCurrent left, ElectricPotential right) =>
		IIntegralOperators<ElectricCurrent, ElectricPotential, Power>.Integrate(left, right);

	/// <summary>
	/// Multiplies an <see cref="ElectricCurrent"/> by a <see cref="Time"/> to calculate the resulting <see cref="Charge"/>.
	/// </summary>
	/// <param name="left">The electric current value.</param>
	/// <param name="right">The time value.</param>
	/// <returns>The resulting electric charge.</returns>
	public static Charge operator *(ElectricCurrent left, Time right) =>
		IIntegralOperators<ElectricCurrent, Time, Charge>.Integrate(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="ElectricCurrent"/>.
/// </summary>
public static class ElectricCurrentConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="ElectricCurrent"/> measured in amperes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="ElectricCurrent"/> instance representing the specified value in amperes.</returns>
	public static ElectricCurrent Amperes<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, ElectricCurrent>();

	/// <summary>
	/// Converts an <see cref="ElectricCurrent"/> value to a numeric value measured in amperes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="ElectricCurrent"/> value to convert.</param>
	/// <returns>The numeric value representing the electric current in amperes.</returns>
	public static TNumber Amperes<TNumber>(this ElectricCurrent value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="ElectricCurrent"/> measured in milliamperes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="ElectricCurrent"/> instance representing the specified value in milliamperes.</returns>
	public static ElectricCurrent Milliamperes<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, ElectricCurrent>(Constants.Milli);

	/// <summary>
	/// Converts an <see cref="ElectricCurrent"/> value to a numeric value measured in milliamperes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="ElectricCurrent"/> value to convert.</param>
	/// <returns>The numeric value representing the electric current in milliamperes.</returns>
	public static TNumber Milliamperes<TNumber>(this ElectricCurrent value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="ElectricCurrent"/> measured in microamperes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="ElectricCurrent"/> instance representing the specified value in microamperes.</returns>
	public static ElectricCurrent Microamperes<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, ElectricCurrent>(Constants.Micro);

	/// <summary>
	/// Converts an <see cref="ElectricCurrent"/> value to a numeric value measured in microamperes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="ElectricCurrent"/> value to convert.</param>
	/// <returns>The numeric value representing the electric current in microamperes.</returns>
	public static TNumber Microamperes<TNumber>(this ElectricCurrent value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="ElectricCurrent"/> measured in nanoamperes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="ElectricCurrent"/> instance representing the specified value in nanoamperes.</returns>
	public static ElectricCurrent Nanoamperes<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, ElectricCurrent>(Constants.Nano);

	/// <summary>
	/// Converts an <see cref="ElectricCurrent"/> value to a numeric value measured in nanoamperes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="ElectricCurrent"/> value to convert.</param>
	/// <returns>The numeric value representing the electric current in nanoamperes.</returns>
	public static TNumber Nanoamperes<TNumber>(this ElectricCurrent value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Nano).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="ElectricCurrent"/> measured in kiloamperes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="ElectricCurrent"/> instance representing the specified value in kiloamperes.</returns>
	public static ElectricCurrent Kiloamperes<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, ElectricCurrent>(Constants.Kilo);

	/// <summary>
	/// Converts an <see cref="ElectricCurrent"/> value to a numeric value measured in kiloamperes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="ElectricCurrent"/> value to convert.</param>
	/// <returns>The numeric value representing the electric current in kiloamperes.</returns>
	public static TNumber Kiloamperes<TNumber>(this ElectricCurrent value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Kilo).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="ElectricCurrent"/> measured in megaamperes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="ElectricCurrent"/> instance representing the specified value in megaamperes.</returns>
	public static ElectricCurrent Megaamperes<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, ElectricCurrent>(Constants.Mega);

	/// <summary>
	/// Converts an <see cref="ElectricCurrent"/> value to a numeric value measured in megaamperes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="ElectricCurrent"/> value to convert.</param>
	/// <returns>The numeric value representing the electric current in megaamperes.</returns>
	public static TNumber Megaamperes<TNumber>(this ElectricCurrent value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Mega).To<TNumber>();
}
