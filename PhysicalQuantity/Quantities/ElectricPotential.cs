// Copyright (c) ktsu.dev
// All rights reserved.
// Licensed under the MIT license.

namespace ktsu.PhysicalQuantity.ElectricPotential;

using System.Numerics;

using ktsu.PhysicalQuantity.Charge;
using ktsu.PhysicalQuantity.ElectricCurrent;
using ktsu.PhysicalQuantity.Energy;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Power;
using ktsu.PhysicalQuantity.Resistance;

/// <summary>
/// Represents an electric potential quantity measured in volts.
/// </summary>
[SIUnit("V", "volt", "volts")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record ElectricPotential
	: PhysicalQuantity<ElectricPotential>
	, IDerivativeOperators<ElectricPotential, ElectricCurrent, Resistance>
	, IDerivativeOperators<ElectricPotential, Resistance, ElectricCurrent>
	, IIntegralOperators<ElectricPotential, ElectricCurrent, Power>
	, IIntegralOperators<ElectricPotential, Charge, Energy>
{
	/// <summary>
	/// Multiplies an <see cref="ElectricPotential"/> by an <see cref="ElectricCurrent"/> to calculate <see cref="Power"/>.
	/// </summary>
	/// <param name="left">The electric potential.</param>
	/// <param name="right">The electric current.</param>
	/// <returns>The resulting <see cref="Power"/>.</returns>
	public static Power operator *(ElectricPotential left, ElectricCurrent right) =>
		IIntegralOperators<ElectricPotential, ElectricCurrent, Power>.Integrate(left, right);

	/// <summary>
	/// Multiplies an <see cref="ElectricPotential"/> by a <see cref="Charge"/> to calculate <see cref="Energy"/>.
	/// </summary>
	/// <param name="left">The electric potential.</param>
	/// <param name="right">The electric charge.</param>
	/// <returns>The resulting <see cref="Energy"/>.</returns>
	public static Energy operator *(ElectricPotential left, Charge right) =>
		IIntegralOperators<ElectricPotential, Charge, Energy>.Integrate(left, right);

	/// <summary>
	/// Divides an <see cref="ElectricPotential"/> by an <see cref="ElectricCurrent"/> to calculate <see cref="Resistance"/>.
	/// </summary>
	/// <param name="left">The electric potential.</param>
	/// <param name="right">The electric current.</param>
	/// <returns>The resulting <see cref="Resistance"/>.</returns>
	public static Resistance operator /(ElectricPotential left, ElectricCurrent right) =>
		IDerivativeOperators<ElectricPotential, ElectricCurrent, Resistance>.Derive(left, right);

	/// <summary>
	/// Divides an <see cref="ElectricPotential"/> by a <see cref="Resistance"/> to calculate <see cref="ElectricCurrent"/>.
	/// </summary>
	/// <param name="left">The electric potential.</param>
	/// <param name="right">The resistance.</param>
	/// <returns>The resulting <see cref="ElectricCurrent"/>.</returns>
	public static ElectricCurrent operator /(ElectricPotential left, Resistance right) =>
		IDerivativeOperators<ElectricPotential, Resistance, ElectricCurrent>.Derive(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="ElectricPotential"/>.
/// </summary>
public static class ElectricPotentialConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="ElectricPotential"/> measured in volts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="ElectricPotential"/> instance representing the specified value in volts.</returns>
	public static ElectricPotential Volts<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, ElectricPotential>();

	/// <summary>
	/// Converts an <see cref="ElectricPotential"/> value to a numeric value measured in volts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="ElectricPotential"/> value to convert.</param>
	/// <returns>The numeric value representing the electric potential in volts.</returns>
	public static TNumber Volts<TNumber>(this ElectricPotential value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="ElectricPotential"/> measured in millivolts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="ElectricPotential"/> instance representing the specified value in millivolts.</returns>
	public static ElectricPotential Millivolts<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, ElectricPotential>(Constants.Milli);

	/// <summary>
	/// Converts an <see cref="ElectricPotential"/> value to a numeric value measured in millivolts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="ElectricPotential"/> value to convert.</param>
	/// <returns>The numeric value representing the electric potential in millivolts.</returns>
	public static TNumber Millivolts<TNumber>(this ElectricPotential value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="ElectricPotential"/> measured in microvolts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="ElectricPotential"/> instance representing the specified value in microvolts.</returns>
	public static ElectricPotential Microvolts<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, ElectricPotential>(Constants.Micro);

	/// <summary>
	/// Converts an <see cref="ElectricPotential"/> value to a numeric value measured in microvolts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="ElectricPotential"/> value to convert.</param>
	/// <returns>The numeric value representing the electric potential in microvolts.</returns>
	public static TNumber Microvolts<TNumber>(this ElectricPotential value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="ElectricPotential"/> measured in nanovolts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="ElectricPotential"/> instance representing the specified value in nanovolts.</returns>
	public static ElectricPotential Nanovolts<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, ElectricPotential>(Constants.Nano);

	/// <summary>
	/// Converts an <see cref="ElectricPotential"/> value to a numeric value measured in nanovolts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="ElectricPotential"/> value to convert.</param>
	/// <returns>The numeric value representing the electric potential in nanovolts.</returns>
	public static TNumber Nanovolts<TNumber>(this ElectricPotential value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Nano).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="ElectricPotential"/> measured in kilovolts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="ElectricPotential"/> instance representing the specified value in kilovolts.</returns>
	public static ElectricPotential Kilovolts<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, ElectricPotential>(Constants.Kilo);

	/// <summary>
	/// Converts an <see cref="ElectricPotential"/> value to a numeric value measured in kilovolts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="ElectricPotential"/> value to convert.</param>
	/// <returns>The numeric value representing the electric potential in kilovolts.</returns>
	public static TNumber Kilovolts<TNumber>(this ElectricPotential value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Kilo).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="ElectricPotential"/> measured in megavolts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>An <see cref="ElectricPotential"/> instance representing the specified value in megavolts.</returns>
	public static ElectricPotential Megavolts<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, ElectricPotential>(Constants.Mega);

	/// <summary>
	/// Converts an <see cref="ElectricPotential"/> value to a numeric value measured in megavolts.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="ElectricPotential"/> value to convert.</param>
	/// <returns>The numeric value representing the electric potential in megavolts.</returns>
	public static TNumber Megavolts<TNumber>(this ElectricPotential value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Mega).To<TNumber>();
}
