namespace ktsu.PhysicalQuantity.LuminousIntensity;

using System.Numerics;

using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.LuminousFlux;
using ktsu.PhysicalQuantity.SolidAngle;

/// <summary>
/// Represents a luminous intensity quantity measured in candelas.
/// </summary>
[SIUnit("cd", "candela", "candelas")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record LuminousIntensity
	: PhysicalQuantity<LuminousIntensity>
	, IIntegralOperators<LuminousIntensity, SolidAngle, LuminousFlux>
{
	/// <summary>
	/// Multiplies a <see cref="LuminousIntensity"/> instance by a <see cref="SolidAngle"/> instance
	/// to compute the resulting <see cref="LuminousFlux"/>.
	/// </summary>
	/// <param name="left">The luminous intensity value.</param>
	/// <param name="right">The solid angle value.</param>
	/// <returns>A <see cref="LuminousFlux"/> instance representing the result of the multiplication.</returns>
	public static LuminousFlux operator *(LuminousIntensity left, SolidAngle right) =>
		IIntegralOperators<LuminousIntensity, SolidAngle, LuminousFlux>.Integrate(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="LuminousIntensity"/>.
/// </summary>
public static class LuminousIntensityConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="LuminousIntensity"/> measured in candelas.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="LuminousIntensity"/> instance representing the specified value in candelas.</returns>
	public static LuminousIntensity Candelas<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, LuminousIntensity>();

	/// <summary>
	/// Converts a <see cref="LuminousIntensity"/> value to a numeric value measured in candelas.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="LuminousIntensity"/> value to convert.</param>
	/// <returns>The numeric value representing the luminous intensity in candelas.</returns>
	public static TNumber Candelas<TNumber>(this LuminousIntensity value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();
}
