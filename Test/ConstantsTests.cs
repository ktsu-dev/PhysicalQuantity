namespace PhysicalQuantity.Tests;

using ktsu.PhysicalQuantity;

[TestClass]
public class ConstantsTests
{
	[TestMethod]
	public void MetricPrefixes_ShouldHaveCorrectValues()
	{
		Assert.AreEqual(1e1m, Constants.Deca.To<decimal>());
		Assert.AreEqual(1e2m, Constants.Hecto.To<decimal>());
		Assert.AreEqual(1e3m, Constants.Kilo.To<decimal>());
		Assert.AreEqual(1e6m, Constants.Mega.To<decimal>());
		Assert.AreEqual(1e9m, Constants.Giga.To<decimal>());
		Assert.AreEqual(1e12m, Constants.Tera.To<decimal>());
		Assert.AreEqual(1e15m, Constants.Peta.To<decimal>());
		Assert.AreEqual(1e18m, Constants.Exa.To<decimal>());
		Assert.AreEqual(1e21m, Constants.Zetta.To<decimal>());
		Assert.AreEqual(1e24m, Constants.Yotta.To<decimal>());
		Assert.AreEqual(1e-1m, Constants.Deci.To<decimal>());
		Assert.AreEqual(1e-2m, Constants.Centi.To<decimal>());
		Assert.AreEqual(1e-3m, Constants.Milli.To<decimal>());
		Assert.AreEqual(1e-6m, Constants.Micro.To<decimal>());
		Assert.AreEqual(1e-9m, Constants.Nano.To<decimal>());
		Assert.AreEqual(1e-12m, Constants.Pico.To<decimal>());
		Assert.AreEqual(1e-15m, Constants.Femto.To<decimal>());
		Assert.AreEqual(1e-18m, Constants.Atto.To<decimal>());
		Assert.AreEqual(1e-21m, Constants.Zepto.To<decimal>());
		Assert.AreEqual(1e-24m, Constants.Yocto.To<decimal>());
	}

	[TestMethod]
	public void LengthConversionFactors_ShouldHaveCorrectValues()
	{
		Assert.AreEqual(0.3048m, Constants.FeetToMetersFactor.To<decimal>());
		Assert.AreEqual(0.0254m, Constants.InchesToMetersFactor.To<decimal>());
		Assert.AreEqual(0.9144m, Constants.YardsToMetersFactor.To<decimal>());
		Assert.AreEqual(1609.344m, Constants.MilesToMetersFactor.To<decimal>());
		Assert.AreEqual(1852m, Constants.NauticalMilesToMetersFactor.To<decimal>());
		Assert.AreEqual(1.8288m, Constants.FathomsToMetersFactor.To<decimal>());
		Assert.AreEqual(1.495978707e11m, Constants.AstronomicalUnitsToMetersFactor.To<decimal>());
		Assert.AreEqual(9.4607304725808e15m, Constants.LightYearsToMetersFactor.To<decimal>());
		Assert.AreEqual(3.08567758149137e16m, Constants.ParsecsToMetersFactor.To<decimal>());
	}

	[TestMethod]
	public void AngularConversionFactors_ShouldHaveCorrectValues()
	{
		Assert.AreEqual(0.01745329251994329576923690768489m, Constants.DegreesToRadiansFactor.To<decimal>());
		Assert.AreEqual(0.0157079632679489661923132169164m, Constants.GradiansToRadiansFactor.To<decimal>());
		Assert.AreEqual(0.00029088820866572159615394846141459m, Constants.MinutesToRadiansFactor.To<decimal>());
		Assert.AreEqual(4.8481368110953599358991410235795e-6m, Constants.SecondsToRadiansFactor.To<decimal>());
		Assert.AreEqual(6.283185307179586476925286766559m, Constants.RevolutionsToRadiansFactor.To<decimal>());
	}

	[TestMethod]
	public void MassConversionFactors_ShouldHaveCorrectValues()
	{
		Assert.AreEqual(0.45359237m, Constants.PoundsToKilogramsFactor.To<decimal>());
		Assert.AreEqual(0.028349523125m, Constants.OuncesToKilogramsFactor.To<decimal>());
		Assert.AreEqual(6.35029318m, Constants.StonesToKilogramsFactor.To<decimal>());
		Assert.AreEqual(1016.0469088m, Constants.ImperialTonsToKilogramsFactor.To<decimal>());
		Assert.AreEqual(907.18474m, Constants.USTonsToKilogramsFactor.To<decimal>());
		Assert.AreEqual(1000m, Constants.MetricTonsToKilogramsFactor.To<decimal>());
	}

	[TestMethod]
	public void TemperatureConversionFactors_ShouldHaveCorrectValues()
	{
		Assert.AreEqual(1m, Constants.CelsiusToKelvinFactor.To<decimal>());
		Assert.AreEqual(273.15m, Constants.CelsiusToKelvinOffset.To<decimal>());
		Assert.AreEqual(9m / 5m, Constants.FahrenheitToCelsiusFactor.To<decimal>());
		Assert.AreEqual(32m, Constants.FahrenheitToCelsiusOffset.To<decimal>());
	}
}
