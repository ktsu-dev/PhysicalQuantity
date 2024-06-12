namespace ktsu.io.PhysicalQuantity;

using System;
using ktsu.io.SignificantNumber;

internal static class Constants
{
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
	internal static SignificantNumber Pi { get; } = 3.14159265358979323846m.ToSignificantNumber();
	internal static SignificantNumber E { get; } = 2.71828182845904523536m.ToSignificantNumber();
	internal static SignificantNumber GoldenRatio { get; } = 1.61803398874989484820m.ToSignificantNumber();

	// Length conversion factors
	internal static SignificantNumber MetersToFeetFactor { get; } = 3.280839895013123m.ToSignificantNumber();
	internal static SignificantNumber MetersToInchesFactor { get; } = 39.37007874015748m.ToSignificantNumber();
	internal static SignificantNumber MetersToYardsFactor { get; } = 1.0936132983377078m.ToSignificantNumber();
	internal static SignificantNumber MetersToMilesFactor { get; } = 0.0006213711922373339m.ToSignificantNumber();
	internal static SignificantNumber MetersToNauticalMilesFactor { get; } = 0.0005399568034557235m.ToSignificantNumber();
	internal static SignificantNumber MetersToFathomsFactor { get; } = 0.5468066491688539m.ToSignificantNumber();
	internal static SignificantNumber MetersToChainsFactor { get; } = 0.04970969537898672m.ToSignificantNumber();
	internal static SignificantNumber MetersToRodsFactor { get; } = 0.198838781515954m.ToSignificantNumber();
	internal static SignificantNumber MetersToFurlongsFactor { get; } = 0.004970969537898672m.ToSignificantNumber();
	internal static SignificantNumber MetersToLeaguesFactor { get; } = 0.0002071237307457777m.ToSignificantNumber();
	internal static SignificantNumber MetersToAstronomicalUnitsFactor { get; } = 6.6845871226706e-12m.ToSignificantNumber();
	internal static SignificantNumber MetersToLightYearsFactor { get; } = 1.0570008340247e-16m.ToSignificantNumber();
	internal static SignificantNumber MetersToParsecsFactor { get; } = 3.2407792896393e-17m.ToSignificantNumber();

	// Angular conversion factors
	internal static SignificantNumber RadiansToDegreesFactor { get; } = 57.295779513082320876798154814105m.ToSignificantNumber();
	internal static SignificantNumber RadiansToGradiansFactor { get; } = 63.661977236758134307553505349006m.ToSignificantNumber();
	internal static SignificantNumber RadiansToMinutesFactor { get; } = 3437.7467707849392526078892189764m.ToSignificantNumber();
	internal static SignificantNumber RadiansToSecondsFactor { get; } = 206264.80624709635515647335313858m.ToSignificantNumber();
	internal static SignificantNumber RadiansToRevolutionsFactor { get; } = 0.15915494309189533576888376337251m.ToSignificantNumber();
	internal static SignificantNumber RadiansToCyclesFactor { get; } = 0.15915494309189533576888376337251m.ToSignificantNumber();
	internal static SignificantNumber RadiansToTurnsFactor { get; } = 0.15915494309189533576888376337251m.ToSignificantNumber();

	// Mass conversion factors
	internal static SignificantNumber KilogramsToPoundsFactor { get; } = 2.2046226218487757m.ToSignificantNumber();
	internal static SignificantNumber KilogramsToOuncesFactor { get; } = 35.27396194958041m.ToSignificantNumber();
	internal static SignificantNumber KilogramsToStonesFactor { get; } = 0.15747304441777m.ToSignificantNumber();
	internal static SignificantNumber KilogramsToImperialTonsFactor { get; } = 0.00098420652761106m.ToSignificantNumber();
	internal static SignificantNumber KilogramsToUSTonsFactor { get; } = 0.001102311310924388m.ToSignificantNumber();
	internal static SignificantNumber KilogramsToMetricTonsFactor { get; } = 0.001m.ToSignificantNumber();

	// Force conversion factors
	internal static SignificantNumber NewtonsToPoundsForceFactor { get; } = 0.2248089430997105m.ToSignificantNumber();

	// Energy conversion factors
	internal static SignificantNumber JoulesToCaloriesFactor { get; } = 0.23900573613767m.ToSignificantNumber();
	internal static SignificantNumber JoulesToBTUsFactor { get; } = 0.00094781707775m.ToSignificantNumber();

	// Power conversion factors
	internal static SignificantNumber WattsToHorsepowerFactor { get; } = 0.001341022089595028m.ToSignificantNumber();
	internal static SignificantNumber WattsToMetricHorsePowerFactor { get; } = 0.0013596216173039m.ToSignificantNumber();

	// Pressure conversion factors
	internal static SignificantNumber PascalsToBarFactor { get; } = 1e-5m.ToSignificantNumber();
	internal static SignificantNumber PascalsToPsiFactor { get; } = 0.000145037737797m.ToSignificantNumber();
	internal static SignificantNumber PascalsToAtmFactor { get; } = 9.8692326671601283e-6m.ToSignificantNumber();
	internal static SignificantNumber PascalsToTorrFactor { get; } = 0.0075006168270417m.ToSignificantNumber();

	// Temperature conversion factors
	internal static SignificantNumber CelsiusToKelvinFactor { get; } = 1m.ToSignificantNumber();
	internal static SignificantNumber CelsiusToKelvinOffset { get; } = 273.15m.ToSignificantNumber();
	internal static SignificantNumber FahrenheitToCelsiusFactor { get; } = 5m.ToSignificantNumber() / 9m.ToSignificantNumber();
	internal static SignificantNumber FahrenheitToCelsiusOffset { get; } = (-32m).ToSignificantNumber();
	internal static SignificantNumber FahrenheitToKelvinFactor { get; } = 5m.ToSignificantNumber() / 9m.ToSignificantNumber();
	internal static SignificantNumber FahrenheitToKelvinOffset { get; } = (459.67m * 5m / 9m).ToSignificantNumber();

	// Time conversion factors
	internal static SignificantNumber SecondsToMinutesFactor { get; } = (1m / 60m).ToSignificantNumber();
	internal static SignificantNumber SecondsToHoursFactor { get; } = (1m / 3600m).ToSignificantNumber();
	internal static SignificantNumber SecondsToDaysFactor { get; } = (1m / 86400m).ToSignificantNumber();
	internal static SignificantNumber MinutesToHoursFactor { get; } = (1m / 60m).ToSignificantNumber();
	internal static SignificantNumber MinutesToDaysFactor { get; } = (1m / 1440m).ToSignificantNumber();
	internal static SignificantNumber HoursToDaysFactor { get; } = (1m / 24m).ToSignificantNumber();

	// Torque conversion factors
	internal static SignificantNumber NewtonMetersToFootPoundsFactor { get; } = 0.737562149m.ToSignificantNumber();
	internal static SignificantNumber NewtonMetersToPoundInchesFactor { get; } = 8.85074579m.ToSignificantNumber();
}
