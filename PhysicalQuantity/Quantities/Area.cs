namespace ktsu.PhysicalQuantity.Area;

using System.Numerics;
using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Illuminance;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.LuminousFlux;
using ktsu.PhysicalQuantity.Pressure;
using ktsu.PhysicalQuantity.Volume;

[SIUnit("m²", "square meter", "square meters")]
public sealed record Area
	: PhysicalQuantity<Area>
	, IDerivativeOperators<Area, Length, Length>
	, IIntegralOperators<Area, Length, Volume>
	, IIntegralOperators<Area, Pressure, Force>
	, IIntegralOperators<Area, Illuminance, LuminousFlux>
{
	public static Volume operator *(Area left, Length right) =>
		IIntegralOperators<Area, Length, Volume>.Integrate(left, right);

	public static Force operator *(Area left, Pressure right) =>
		IIntegralOperators<Area, Pressure, Force>.Integrate(left, right);

	public static LuminousFlux operator *(Area left, Illuminance right) =>
		IIntegralOperators<Area, Illuminance, LuminousFlux>.Integrate(left, right);

	public static Length operator /(Area left, Length right) =>
		IDerivativeOperators<Area, Length, Length>.Derive(left, right);
}

/// <summary>
/// Provides extension methods for converting numerical values to and from <see cref="Area"/> quantities.
/// </summary>
public static class AreaConversions
{
	// Base unit: Square meters
	/// <summary>
	/// Converts a numerical value to <see cref="Area"/> in square meters.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Area"/>.</returns>
	public static Area SquareMeters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Area>();

	/// <summary>
	/// Converts an <see cref="Area"/> value to a numerical value in square meters.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Area"/> value to convert.</param>
	/// <returns>The numerical value in square meters.</returns>
	public static TNumber SquareMeters<TNumber>(this Area value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	// Square kilometers
	/// <summary>
	/// Converts a numerical value to <see cref="Area"/> in square kilometers.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Area"/>.</returns>
	public static Area SquareKilometers<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Area>(Constants.Kilo * Constants.Kilo);

	/// <summary>
	/// Converts an <see cref="Area"/> value to a numerical value in square kilometers.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Area"/> value to convert.</param>
	/// <returns>The numerical value in square kilometers.</returns>
	public static TNumber SquareKilometers<TNumber>(this Area value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Kilo * Constants.Kilo).To<TNumber>();

	// Square centimeters
	/// <summary>
	/// Converts a numerical value to <see cref="Area"/> in square centimeters.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Area"/>.</returns>
	public static Area SquareCentimeters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Area>(Constants.Centi * Constants.Centi);

	/// <summary>
	/// Converts an <see cref="Area"/> value to a numerical value in square centimeters.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Area"/> value to convert.</param>
	/// <returns>The numerical value in square centimeters.</returns>
	public static TNumber SquareCentimeters<TNumber>(this Area value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Centi * Constants.Centi).To<TNumber>();

	// Square millimeters
	/// <summary>
	/// Converts a numerical value to <see cref="Area"/> in square millimeters.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Area"/>.</returns>
	public static Area SquareMillimeters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Area>(Constants.Milli * Constants.Milli);

	/// <summary>
	/// Converts an <see cref="Area"/> value to a numerical value in square millimeters.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Area"/> value to convert.</param>
	/// <returns>The numerical value in square millimeters.</returns>
	public static TNumber SquareMillimeters<TNumber>(this Area value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli * Constants.Milli).To<TNumber>();

	// Square micrometers
	/// <summary>
	/// Converts a numerical value to <see cref="Area"/> in square micrometers.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Area"/>.</returns>
	public static Area SquareMicrometers<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Area>(Constants.Micro * Constants.Micro);

	/// <summary>
	/// Converts an <see cref="Area"/> value to a numerical value in square micrometers.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Area"/> value to convert.</param>
	/// <returns>The numerical value in square micrometers.</returns>
	public static TNumber SquareMicrometers<TNumber>(this Area value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro * Constants.Micro).To<TNumber>();

	// Square nanometers
	/// <summary>
	/// Converts a numerical value to <see cref="Area"/> in square nanometers.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Area"/>.</returns>
	public static Area SquareNanometers<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Area>(Constants.Nano * Constants.Nano);

	/// <summary>
	/// Converts an <see cref="Area"/> value to a numerical value in square nanometers.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Area"/> value to convert.</param>
	/// <returns>The numerical value in square nanometers.</returns>
	public static TNumber SquareNanometers<TNumber>(this Area value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Nano * Constants.Nano).To<TNumber>();

	// Hectares
	/// <summary>
	/// Converts a numerical value to <see cref="Area"/> in hectares.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Area"/>.</returns>
	public static Area Hectares<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Area>(Constants.Hecto * Constants.Hecto);

	/// <summary>
	/// Converts an <see cref="Area"/> value to a numerical value in hectares.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Area"/> value to convert.</param>
	/// <returns>The numerical value in hectares.</returns>
	public static TNumber Hectares<TNumber>(this Area value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Hecto * Constants.Hecto).To<TNumber>();

	// Acres
	/// <summary>
	/// Converts a numerical value to <see cref="Area"/> in acres.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Area"/>.</returns>
	public static Area Acres<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Area>(Constants.AcresToSquareMetersFactor);

	/// <summary>
	/// Converts an <see cref="Area"/> value to a numerical value in acres.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Area"/> value to convert.</param>
	/// <returns>The numerical value in acres.</returns>
	public static TNumber Acres<TNumber>(this Area value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.AcresToSquareMetersFactor).To<TNumber>();

	// Square feet
	/// <summary>
	/// Converts a numerical value to <see cref="Area"/> in square feet.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Area"/>.</returns>
	public static Area SquareFeet<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Area>(Constants.FeetToMetersFactor * Constants.FeetToMetersFactor);

	/// <summary>
	/// Converts an <see cref="Area"/> value to a numerical value in square feet.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Area"/> value to convert.</param>
	/// <returns>The numerical value in square feet.</returns>
	public static TNumber SquareFeet<TNumber>(this Area value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.FeetToMetersFactor * Constants.FeetToMetersFactor).To<TNumber>();

	// Square inches
	/// <summary>
	/// Converts a numerical value to <see cref="Area"/> in square inches.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Area"/>.</returns>
	public static Area SquareInches<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Area>(Constants.InchesToMetersFactor * Constants.InchesToMetersFactor);

	/// <summary>
	/// Converts an <see cref="Area"/> value to a numerical value in square inches.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Area"/> value to convert.</param>
	/// <returns>The numerical value in square inches.</returns>
	public static TNumber SquareInches<TNumber>(this Area value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.InchesToMetersFactor * Constants.InchesToMetersFactor).To<TNumber>();

	// Square yards
	/// <summary>
	/// Converts a numerical value to <see cref="Area"/> in square yards.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The numerical value to convert.</param>
	/// <returns>An instance of <see cref="Area"/>.</returns>
	public static Area SquareYards<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Area>(Constants.YardsToMetersFactor * Constants.YardsToMetersFactor);

	/// <summary>
	/// Converts an <see cref="Area"/> value to a numerical value in square yards.
	/// </summary>
	/// <typeparam name="TNumber">The type of the numerical value.</typeparam>
	/// <param name="value">The <see cref="Area"/> value to convert.</param>
	/// <returns>The numerical value in square yards.</returns>
	public static TNumber SquareYards<TNumber>(this Area value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.YardsToMetersFactor * Constants.YardsToMetersFactor).To<TNumber>();
}
