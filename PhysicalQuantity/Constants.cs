namespace ktsu.PhysicalQuantity;

using ktsu.SignificantNumber;

/// <summary>
/// Provides conversion factors for various physical quantities and metric prefixes.
/// </summary>
internal static class Constants
{
	// Metric prefixes
	internal static SignificantNumber Deca { get; } = 1e1.ToSignificantNumber();
	internal static SignificantNumber Hecto { get; } = 1e2.ToSignificantNumber();
	internal static SignificantNumber Kilo { get; } = 1e3.ToSignificantNumber();
	internal static SignificantNumber Mega { get; } = 1e6.ToSignificantNumber();
	internal static SignificantNumber Giga { get; } = 1e9.ToSignificantNumber();
	internal static SignificantNumber Tera { get; } = 1e12.ToSignificantNumber();
	internal static SignificantNumber Peta { get; } = 1e15.ToSignificantNumber();
	internal static SignificantNumber Exa { get; } = 1e18.ToSignificantNumber();
	internal static SignificantNumber Zetta { get; } = 1e21.ToSignificantNumber();
	internal static SignificantNumber Yotta { get; } = 1e24.ToSignificantNumber();
	internal static SignificantNumber Deci { get; } = 1e-1.ToSignificantNumber();
	internal static SignificantNumber Centi { get; } = 1e-2.ToSignificantNumber();
	internal static SignificantNumber Milli { get; } = 1e-3.ToSignificantNumber();
	internal static SignificantNumber Micro { get; } = 1e-6.ToSignificantNumber();
	internal static SignificantNumber Nano { get; } = 1e-9.ToSignificantNumber();
	internal static SignificantNumber Pico { get; } = 1e-12.ToSignificantNumber();
	internal static SignificantNumber Femto { get; } = 1e-15.ToSignificantNumber();
	internal static SignificantNumber Atto { get; } = 1e-18.ToSignificantNumber();
	internal static SignificantNumber Zepto { get; } = 1e-21.ToSignificantNumber();
	internal static SignificantNumber Yocto { get; } = 1e-24.ToSignificantNumber();

	// Length conversion factors
	internal static SignificantNumber FeetToMetersFactor { get; } = 0.3048m.ToSignificantNumber();
	internal static SignificantNumber InchesToMetersFactor { get; } = 0.0254m.ToSignificantNumber();
	internal static SignificantNumber YardsToMetersFactor { get; } = 0.9144m.ToSignificantNumber();
	internal static SignificantNumber MilesToMetersFactor { get; } = 1609.344m.ToSignificantNumber();
	internal static SignificantNumber NauticalMilesToMetersFactor { get; } = 1852m.ToSignificantNumber();
	internal static SignificantNumber FathomsToMetersFactor { get; } = 1.8288m.ToSignificantNumber();
	internal static SignificantNumber AstronomicalUnitsToMetersFactor { get; } = 1.495978707e11m.ToSignificantNumber();
	internal static SignificantNumber LightYearsToMetersFactor { get; } = 9.4607304725808e15m.ToSignificantNumber();
	internal static SignificantNumber ParsecsToMetersFactor { get; } = 3.08567758149137e16m.ToSignificantNumber();

	// Angular conversion factors
	internal static SignificantNumber DegreesToRadiansFactor { get; } = 0.01745329251994329576923690768489m.ToSignificantNumber();
	internal static SignificantNumber GradiansToRadiansFactor { get; } = 0.0157079632679489661923132169164m.ToSignificantNumber();
	internal static SignificantNumber MinutesToRadiansFactor { get; } = 0.00029088820866572159615394846141459m.ToSignificantNumber();
	internal static SignificantNumber SecondsToRadiansFactor { get; } = 4.8481368110953599358991410235795e-6m.ToSignificantNumber();
	internal static SignificantNumber RevolutionsToRadiansFactor { get; } = 6.283185307179586476925286766559m.ToSignificantNumber();
	internal static SignificantNumber CyclesToRadiansFactor { get; } = 6.283185307179586476925286766559m.ToSignificantNumber();
	internal static SignificantNumber TurnsToRadiansFactor { get; } = 6.283185307179586476925286766559m.ToSignificantNumber();

	// Mass conversion factors
	internal static SignificantNumber PoundsToKilogramsFactor { get; } = 0.45359237m.ToSignificantNumber();
	internal static SignificantNumber OuncesToKilogramsFactor { get; } = 0.028349523125m.ToSignificantNumber();
	internal static SignificantNumber StonesToKilogramsFactor { get; } = 6.35029318m.ToSignificantNumber();
	internal static SignificantNumber ImperialTonsToKilogramsFactor { get; } = 1016.0469088m.ToSignificantNumber();
	internal static SignificantNumber USTonsToKilogramsFactor { get; } = 907.18474m.ToSignificantNumber();
	internal static SignificantNumber MetricTonsToKilogramsFactor { get; } = 1000m.ToSignificantNumber();

	// Force conversion factors
	internal static SignificantNumber PoundsForceToNewtonsFactor { get; } = 4.4482216152605m.ToSignificantNumber();

	// Energy conversion factors
	internal static SignificantNumber CaloriesToJoulesFactor { get; } = 4.184m.ToSignificantNumber();
	internal static SignificantNumber BTUsToJoulesFactor { get; } = 1055.05585262m.ToSignificantNumber();

	// Power conversion factors
	internal static SignificantNumber HorsepowerToWattsFactor { get; } = 745.69987158227022m.ToSignificantNumber();
	internal static SignificantNumber MetricHorsePowerToWattsFactor { get; } = 735.49875m.ToSignificantNumber();

	// Pressure conversion factors
	internal static SignificantNumber BarToPascalsFactor { get; } = 1e5m.ToSignificantNumber();
	internal static SignificantNumber PsiToPascalsFactor { get; } = 6894.757293168361m.ToSignificantNumber();
	internal static SignificantNumber AtmToPascalsFactor { get; } = 101325m.ToSignificantNumber();
	internal static SignificantNumber TorrToPascalsFactor { get; } = 133.32236842105263m.ToSignificantNumber();

	// Temperature conversion factors
	internal static SignificantNumber CelsiusToKelvinFactor { get; } = 1m.ToSignificantNumber();
	internal static SignificantNumber CelsiusToKelvinOffset { get; } = 273.15m.ToSignificantNumber();
	internal static SignificantNumber FahrenheitToCelsiusFactor { get; } = (9m / 5m).ToSignificantNumber();
	internal static SignificantNumber FahrenheitToCelsiusOffset { get; } = 32m.ToSignificantNumber();

	// Time conversion factors
	internal static SignificantNumber MinutesToSecondsFactor { get; } = 60m.ToSignificantNumber();
	internal static SignificantNumber HoursToSecondsFactor { get; } = 3600m.ToSignificantNumber();
	internal static SignificantNumber DaysToSecondsFactor { get; } = 86400m.ToSignificantNumber();
	internal static SignificantNumber HoursToMinutesFactor { get; } = 60m.ToSignificantNumber();
	internal static SignificantNumber DaysToMinutesFactor { get; } = 1440m.ToSignificantNumber();
	internal static SignificantNumber DaysToHoursFactor { get; } = 24m.ToSignificantNumber();
	internal static SignificantNumber YearsToSecondsFactor { get; } = 31556952m.ToSignificantNumber();

	// Torque conversion factors
	internal static SignificantNumber FootPoundsToNewtonMetersFactor { get; } = 1.3558179483314004m.ToSignificantNumber();
	internal static SignificantNumber PoundInchesToNewtonMetersFactor { get; } = 0.1130057188312m.ToSignificantNumber();

	// Illuminance conversion factors
	internal static SignificantNumber FootCandleToLuxFactor { get; } = 10.763910416709722m.ToSignificantNumber();

	// Area conversion factors
	internal static SignificantNumber AcresToSquareMetersFactor { get; } = 4046.8564224m.ToSignificantNumber();

	// Solid Angle conversion factors
	internal static SignificantNumber SquareDegreesToSteradiansFactor { get; } = 3282.80635001.ToSignificantNumber();

	// Charge conversion factors
	internal static SignificantNumber MilliampereHoursToCoulombsFactor { get; } = 3.6.ToSignificantNumber();
	internal static SignificantNumber AmpereHoursToCoulombsFactor { get; } = 3600.ToSignificantNumber();
}
