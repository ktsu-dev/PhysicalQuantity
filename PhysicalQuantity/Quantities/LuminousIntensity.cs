namespace ktsu.io.PhysicalQuantity.LuminousIntensity;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Generic;
using ktsu.io.PhysicalQuantity.LuminousFlux;
using ktsu.io.PhysicalQuantity.SolidAngle;

/// <summary>
/// Represents a luminous intensity quantity measured in candelas.
/// </summary>
[SIUnit("cd", "candela", "candelas")]
public sealed record LuminousIntensity
	: PhysicalQuantity<LuminousIntensity>
	, IIntegralOperators<LuminousIntensity, SolidAngle, LuminousFlux>
{
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
