// Copyright (c) ktsu.dev
// All rights reserved.
// Licensed under the MIT license.

namespace ktsu.PhysicalQuantity;

using ktsu.PreciseNumber;

using StorageType = SignificantNumber.SignificantNumber;

/// <summary>
/// Provides conversion factors for various physical quantities and metric prefixes.
/// </summary>
internal static class Constants
{
	// Metric prefixes
	internal static StorageType Deca { get; } = 1e1.ToPreciseNumber().As<StorageType>();
	internal static StorageType Hecto { get; } = 1e2.ToPreciseNumber().As<StorageType>();
	internal static StorageType Kilo { get; } = 1e3.ToPreciseNumber().As<StorageType>();
	internal static StorageType Mega { get; } = 1e6.ToPreciseNumber().As<StorageType>();
	internal static StorageType Giga { get; } = 1e9.ToPreciseNumber().As<StorageType>();
	internal static StorageType Tera { get; } = 1e12.ToPreciseNumber().As<StorageType>();
	internal static StorageType Peta { get; } = 1e15.ToPreciseNumber().As<StorageType>();
	internal static StorageType Exa { get; } = 1e18.ToPreciseNumber().As<StorageType>();
	internal static StorageType Zetta { get; } = 1e21.ToPreciseNumber().As<StorageType>();
	internal static StorageType Yotta { get; } = 1e24.ToPreciseNumber().As<StorageType>();
	internal static StorageType Deci { get; } = 1e-1.ToPreciseNumber().As<StorageType>();
	internal static StorageType Centi { get; } = 1e-2.ToPreciseNumber().As<StorageType>();
	internal static StorageType Milli { get; } = 1e-3.ToPreciseNumber().As<StorageType>();
	internal static StorageType Micro { get; } = 1e-6.ToPreciseNumber().As<StorageType>();
	internal static StorageType Nano { get; } = 1e-9.ToPreciseNumber().As<StorageType>();
	internal static StorageType Pico { get; } = 1e-12.ToPreciseNumber().As<StorageType>();
	internal static StorageType Femto { get; } = 1e-15.ToPreciseNumber().As<StorageType>();
	internal static StorageType Atto { get; } = 1e-18.ToPreciseNumber().As<StorageType>();
	internal static StorageType Zepto { get; } = 1e-21.ToPreciseNumber().As<StorageType>();
	internal static StorageType Yocto { get; } = 1e-24.ToPreciseNumber().As<StorageType>();

	// Length conversion factors
	internal static StorageType FeetToMetersFactor { get; } = 0.3048m.ToPreciseNumber().As<StorageType>();
	internal static StorageType InchesToMetersFactor { get; } = 0.0254m.ToPreciseNumber().As<StorageType>();
	internal static StorageType YardsToMetersFactor { get; } = 0.9144m.ToPreciseNumber().As<StorageType>();
	internal static StorageType MilesToMetersFactor { get; } = 1609.344m.ToPreciseNumber().As<StorageType>();
	internal static StorageType NauticalMilesToMetersFactor { get; } = 1852m.ToPreciseNumber().As<StorageType>();
	internal static StorageType FathomsToMetersFactor { get; } = 1.8288m.ToPreciseNumber().As<StorageType>();
	internal static StorageType AstronomicalUnitsToMetersFactor { get; } = 1.495978707e11m.ToPreciseNumber().As<StorageType>();
	internal static StorageType LightYearsToMetersFactor { get; } = 9.4607304725808e15m.ToPreciseNumber().As<StorageType>();
	internal static StorageType ParsecsToMetersFactor { get; } = 3.08567758149137e16m.ToPreciseNumber().As<StorageType>();

	// Angular conversion factors
	internal static StorageType DegreesToRadiansFactor { get; } = 0.01745329251994329576923690768489m.ToPreciseNumber().As<StorageType>();
	internal static StorageType GradiansToRadiansFactor { get; } = 0.0157079632679489661923132169164m.ToPreciseNumber().As<StorageType>();
	internal static StorageType MinutesToRadiansFactor { get; } = 0.00029088820866572159615394846141459m.ToPreciseNumber().As<StorageType>();
	internal static StorageType SecondsToRadiansFactor { get; } = 4.8481368110953599358991410235795e-6m.ToPreciseNumber().As<StorageType>();
	internal static StorageType RevolutionsToRadiansFactor { get; } = 6.283185307179586476925286766559m.ToPreciseNumber().As<StorageType>();
	internal static StorageType CyclesToRadiansFactor { get; } = 6.283185307179586476925286766559m.ToPreciseNumber().As<StorageType>();
	internal static StorageType TurnsToRadiansFactor { get; } = 6.283185307179586476925286766559m.ToPreciseNumber().As<StorageType>();

	// Mass conversion factors
	internal static StorageType PoundsToKilogramsFactor { get; } = 0.45359237m.ToPreciseNumber().As<StorageType>();
	internal static StorageType OuncesToKilogramsFactor { get; } = 0.028349523125m.ToPreciseNumber().As<StorageType>();
	internal static StorageType StonesToKilogramsFactor { get; } = 6.35029318m.ToPreciseNumber().As<StorageType>();
	internal static StorageType ImperialTonsToKilogramsFactor { get; } = 1016.0469088m.ToPreciseNumber().As<StorageType>();
	internal static StorageType USTonsToKilogramsFactor { get; } = 907.18474m.ToPreciseNumber().As<StorageType>();
	internal static StorageType MetricTonsToKilogramsFactor { get; } = 1000m.ToPreciseNumber().As<StorageType>();

	// Force conversion factors
	internal static StorageType PoundsForceToNewtonsFactor { get; } = 4.4482216152605m.ToPreciseNumber().As<StorageType>();

	// Energy conversion factors
	internal static StorageType CaloriesToJoulesFactor { get; } = 4.184m.ToPreciseNumber().As<StorageType>();
	internal static StorageType BTUsToJoulesFactor { get; } = 1055.05585262m.ToPreciseNumber().As<StorageType>();

	// Power conversion factors
	internal static StorageType HorsepowerToWattsFactor { get; } = 745.69987158227022m.ToPreciseNumber().As<StorageType>();
	internal static StorageType MetricHorsePowerToWattsFactor { get; } = 735.49875m.ToPreciseNumber().As<StorageType>();

	// Pressure conversion factors
	internal static StorageType BarToPascalsFactor { get; } = 1e5m.ToPreciseNumber().As<StorageType>();
	internal static StorageType PsiToPascalsFactor { get; } = 6894.757293168361m.ToPreciseNumber().As<StorageType>();
	internal static StorageType AtmToPascalsFactor { get; } = 101325m.ToPreciseNumber().As<StorageType>();
	internal static StorageType TorrToPascalsFactor { get; } = 133.32236842105263m.ToPreciseNumber().As<StorageType>();

	// Temperature conversion factors
	internal static StorageType CelsiusToKelvinFactor { get; } = 1m.ToPreciseNumber().As<StorageType>();
	internal static StorageType CelsiusToKelvinOffset { get; } = 273.15m.ToPreciseNumber().As<StorageType>();
	internal static StorageType FahrenheitToCelsiusFactor { get; } = (9m / 5m).ToPreciseNumber().As<StorageType>();
	internal static StorageType FahrenheitToCelsiusOffset { get; } = 32m.ToPreciseNumber().As<StorageType>();

	// Time conversion factors
	internal static StorageType MinutesToSecondsFactor { get; } = 60m.ToPreciseNumber().As<StorageType>();
	internal static StorageType HoursToSecondsFactor { get; } = 3600m.ToPreciseNumber().As<StorageType>();
	internal static StorageType DaysToSecondsFactor { get; } = 86400m.ToPreciseNumber().As<StorageType>();
	internal static StorageType HoursToMinutesFactor { get; } = 60m.ToPreciseNumber().As<StorageType>();
	internal static StorageType DaysToMinutesFactor { get; } = 1440m.ToPreciseNumber().As<StorageType>();
	internal static StorageType DaysToHoursFactor { get; } = 24m.ToPreciseNumber().As<StorageType>();
	internal static StorageType YearsToSecondsFactor { get; } = 31556952m.ToPreciseNumber().As<StorageType>();

	// Torque conversion factors
	internal static StorageType FootPoundsToNewtonMetersFactor { get; } = 1.3558179483314004m.ToPreciseNumber().As<StorageType>();
	internal static StorageType PoundInchesToNewtonMetersFactor { get; } = 0.1130057188312m.ToPreciseNumber().As<StorageType>();

	// Illuminance conversion factors
	internal static StorageType FootCandleToLuxFactor { get; } = 10.763910416709722m.ToPreciseNumber().As<StorageType>();

	// Area conversion factors
	internal static StorageType AcresToSquareMetersFactor { get; } = 4046.8564224m.ToPreciseNumber().As<StorageType>();

	// Solid Angle conversion factors
	internal static StorageType SquareDegreesToSteradiansFactor { get; } = 3282.80635001.ToPreciseNumber().As<StorageType>();

	// Charge conversion factors
	internal static StorageType MilliampereHoursToCoulombsFactor { get; } = 3.6.ToPreciseNumber().As<StorageType>();
	internal static StorageType AmpereHoursToCoulombsFactor { get; } = 3600.ToPreciseNumber().As<StorageType>();
}
