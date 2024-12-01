namespace ktsu.PhysicalQuantity.Illuminance;

using System.Numerics;
using ktsu.PhysicalQuantity.Area;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.LuminousFlux;

/// <summary>
/// Represents a physical quantity of illuminance.
/// </summary>
[SIUnit("lx", "lux", "lux")]
public sealed record Illuminance
	: PhysicalQuantity<Illuminance>
	, IIntegralOperators<Illuminance, Area, LuminousFlux>
{
	public static LuminousFlux operator *(Illuminance left, Area right) =>
		IIntegralOperators<Illuminance, Area, LuminousFlux>.Integrate(left, right);

}

/// <summary>
/// Provides extension methods for converting numerical values to and from <see cref="Illuminance"/>.
/// </summary>
public static class IlluminanceConversions
{
	// Base unit: Lux
	/// <summary>
	/// Converts a numerical value to <see cref="Illuminance"/> in lux.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>The converted <see cref="Illuminance"/> value.</returns>
	public static Illuminance Lux<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Illuminance>();

	/// <summary>
	/// Converts a <see cref="Illuminance"/> value to a numerical value in lux.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Illuminance"/> value to convert.</param>
	/// <returns>The converted numerical value in lux.</returns>
	public static TNumber Lux<TNumber>(this Illuminance value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	// Foot-candle
	/// <summary>
	/// Converts a numerical value to <see cref="Illuminance"/> in foot-candles.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>The converted <see cref="Illuminance"/> value in foot-candles.</returns>
	public static Illuminance FootCandle<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Illuminance>(Constants.FootCandleToLuxFactor);

	/// <summary>
	/// Converts a <see cref="Illuminance"/> value to a numerical value in foot-candles.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Illuminance"/> value to convert.</param>
	/// <returns>The converted numerical value in foot-candles.</returns>
	public static TNumber FootCandle<TNumber>(this Illuminance value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.FootCandleToLuxFactor).To<TNumber>();
}
