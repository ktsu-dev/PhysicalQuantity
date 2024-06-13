// Ignore Spelling: Lumens

namespace ktsu.io.PhysicalQuantity.LuminousFlux;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Generic;

/// <summary>
/// Represents a luminous flux quantity measured in lumens.
/// </summary>
[SIUnit("lm", "lumen", "lumens")]
public sealed record LuminousFlux
	: PhysicalQuantity<LuminousFlux>
{ }

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
