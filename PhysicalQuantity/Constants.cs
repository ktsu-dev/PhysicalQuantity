namespace ktsu.io.PhysicalQuantity;

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
	internal static SignificantNumber Pi { get; } = Math.PI.ToSignificantNumber();
	internal static SignificantNumber E { get; } = Math.E.ToSignificantNumber();
	internal static SignificantNumber GoldenRatio { get; } = 1.61803398874989484820458683436563811772030917980576m.ToSignificantNumber();

	internal static SignificantNumber MetersToFeetFactor { get; } = 0.3048m.ToSignificantNumber();
	internal static SignificantNumber MetersToInchesFactor { get; } = 0.0254m.ToSignificantNumber();
	internal static SignificantNumber MetersToYardsFactor { get; } = 0.9144m.ToSignificantNumber();
	internal static SignificantNumber MetersToMilesFactor { get; } = 1609.344m.ToSignificantNumber();
	internal static SignificantNumber MetersToNauticalMilesFactor { get; } = 1852m.ToSignificantNumber();
	internal static SignificantNumber MetersToFathomsFactor { get; } = 1.8288m.ToSignificantNumber();
	internal static SignificantNumber MetersToChainsFactor { get; } = 20.1168m.ToSignificantNumber();
	internal static SignificantNumber MetersToRodsFactor { get; } = 5.0292m.ToSignificantNumber();
	internal static SignificantNumber MetersToFurlongsFactor { get; } = 201.168m.ToSignificantNumber();
	internal static SignificantNumber MetersToLeaguesFactor { get; } = 4828.032m.ToSignificantNumber();
	internal static SignificantNumber MetersToAstronomicalUnitsFactor { get; } = 149_597_870_700.ToSignificantNumber();
	internal static SignificantNumber MetersToLightYearsFactor { get; } = 9.4607304725808e15.ToSignificantNumber();
	internal static SignificantNumber MetersToParsecsFactor { get; } = 3.08567758149137e16.ToSignificantNumber();

	internal static SignificantNumber RadiansToDegreesFactor { get; } = 57.295779513082320876798154814105m.ToSignificantNumber();
	internal static SignificantNumber RadiansToGradiansFactor { get; } = 63.661977236758134307553505349006m.ToSignificantNumber();
	internal static SignificantNumber RadiansToMinutesFactor { get; } = 3437.7467707849392526078892189764m.ToSignificantNumber();
	internal static SignificantNumber RadiansToSecondsFactor { get; } = 206264.80647089635515647335313858m.ToSignificantNumber();
	internal static SignificantNumber RadiansToRevolutionsFactor { get; } = 0.15915494309189533576888376337251m.ToSignificantNumber();
	internal static SignificantNumber RadiansToCyclesFactor { get; } = 0.15915494309189533576888376337251m.ToSignificantNumber();
	internal static SignificantNumber RadiansToTurnsFactor { get; } = 0.15915494309189533576888376337251m.ToSignificantNumber();

	internal static SignificantNumber KilogramsToPoundsFactor { get; } = 0.45359237m.ToSignificantNumber();
	internal static SignificantNumber KilogramsToOuncesFactor { get; } = 0.028349523125m.ToSignificantNumber();
	internal static SignificantNumber KilogramsToStonesFactor { get; } = 6.35029318m.ToSignificantNumber();
	internal static SignificantNumber KilogramsToImperialTonsFactor { get; } = 1016.0469088m.ToSignificantNumber();
	internal static SignificantNumber KilogramsToUSTonsFactor { get; } = 907.18474m.ToSignificantNumber();
	internal static SignificantNumber KilogramsToMetricTonsFactor { get; } = 1000.ToSignificantNumber();

	internal static SignificantNumber NewtonsToPoundsForceFactor { get; } = 0.22480894387096m.ToSignificantNumber();

	internal static SignificantNumber JoulesToCaloriesFactor { get; } = 0.23900573613767m.ToSignificantNumber();
	internal static SignificantNumber JoulesToBTUsFactor { get; } = 0.00094781707775m.ToSignificantNumber();

	internal static SignificantNumber WattsToHorsepowerFactor { get; } = 745.699872m.ToSignificantNumber();
	internal static SignificantNumber WattsToMetricHorsePowerFactor { get; } = 735.49875m.ToSignificantNumber();
}
