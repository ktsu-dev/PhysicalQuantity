namespace ktsu.PhysicalQuantity.LuminousFlux;

using System.Numerics;

using ktsu.PhysicalQuantity.Area;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Illuminance;
using ktsu.PhysicalQuantity.LuminousIntensity;
using ktsu.PhysicalQuantity.SolidAngle;

/// <summary>
/// Represents a luminous flux quantity measured in lumens.
/// </summary>
[SIUnit("lm", "lumen", "lumens")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record LuminousFlux
	: PhysicalQuantity<LuminousFlux>
	, IDerivativeOperators<LuminousFlux, Area, Illuminance>
	, IDerivativeOperators<LuminousFlux, SolidAngle, LuminousIntensity>
{
	/// <summary>
	/// Divides a <see cref="LuminousFlux"/> by an <see cref="Area"/> to calculate <see cref="Illuminance"/>.
	/// </summary>
	/// <param name="left">The luminous flux value.</param>
	/// <param name="right">The area value.</param>
	/// <returns>An <see cref="Illuminance"/> instance representing the result of the division.</returns>
	public static Illuminance operator /(LuminousFlux left, Area right) =>
		IDerivativeOperators<LuminousFlux, Area, Illuminance>.Derive(left, right);

	/// <summary>
	/// Divides a <see cref="LuminousFlux"/> by a <see cref="SolidAngle"/> to calculate <see cref="LuminousIntensity"/>.
	/// </summary>
	/// <param name="left">The luminous flux value.</param>
	/// <param name="right">The solid angle value.</param>
	/// <returns>A <see cref="LuminousIntensity"/> instance representing the result of the division.</returns>
	public static LuminousIntensity operator /(LuminousFlux left, SolidAngle right) =>
		IDerivativeOperators<LuminousFlux, SolidAngle, LuminousIntensity>.Derive(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="LuminousFlux"/>.
/// </summary>
public static class LuminousFluxConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="LuminousFlux"/> measured in lumens.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="LuminousFlux"/> instance representing the specified value in lumens.</returns>
	public static LuminousFlux Lumens<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, LuminousFlux>();

	/// <summary>
	/// Converts a <see cref="LuminousFlux"/> value to a numeric value measured in lumens.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="LuminousFlux"/> value to convert.</param>
	/// <returns>The numeric value representing the luminous flux in lumens.</returns>
	public static TNumber Lumens<TNumber>(this LuminousFlux value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();
}
