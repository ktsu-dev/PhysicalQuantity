namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.Density;
using ktsu.io.PhysicalQuantity.Mass;
using ktsu.io.PhysicalQuantity.Volume;
using ktsu.io.SignificantNumber;

[TestClass]
public class MassTests
{
	[TestMethod]
	public void TestMassConversions()
	{
		var value = 100.ToSignificantNumber();
		Assert.AreEqual(value, value.Kilograms().Kilograms<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Kilograms().Grams<SignificantNumber>());
		Assert.AreEqual(value / 0.45359237.ToSignificantNumber(), value.Kilograms().Pounds<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Kilograms().MetricTons<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.Kilograms().Milligrams<SignificantNumber>());
		Assert.AreEqual(value / 6.35029318.ToSignificantNumber(), value.Kilograms().Stones<SignificantNumber>());
	}

	[TestMethod]
	public void TestMassIntegrationWithDensityAndVolume()
	{
		var density = 2.KilogramsPerCubicMeter();
		var volume = 3.CubicMeters();
		var mass = density * volume;

		Assert.AreEqual(6.0.ToSignificantNumber(), mass.Kilograms<SignificantNumber>());

		mass = volume * density;

		Assert.AreEqual(6.0.ToSignificantNumber(), mass.Kilograms<SignificantNumber>());
	}

	[TestMethod]
	public void TestMassDerivativeWithDensityAndVolume()
	{
		var mass = 6.Kilograms();
		var volume = 3.CubicMeters();
		var density = mass / volume;

		Assert.AreEqual(2.0.ToSignificantNumber(), density.KilogramsPerCubicMeter<SignificantNumber>());
	}
}
