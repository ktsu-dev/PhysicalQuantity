namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.Density;
using ktsu.io.PhysicalQuantity.Mass;
using ktsu.io.PhysicalQuantity.Volume;
using ktsu.io.SignificantNumber;

[TestClass]
public class DensityTests
{
	[TestMethod]
	public void TestDensityConversions()
	{
		var value = 1000.ToSignificantNumber();
		Assert.AreEqual(value, value.KilogramsPerCubicMeter().KilogramsPerCubicMeter<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.KilogramsPerCubicMeter().GramsPerCubicCentimeter<SignificantNumber>());
	}

	[TestMethod]
	public void TestDensityIntegration()
	{
		var density = 2.KilogramsPerCubicMeter();
		var volume = 3.CubicMeters();
		var mass = density * volume;

		Assert.AreEqual(6.0.ToSignificantNumber(), mass.Kilograms<SignificantNumber>());

		mass = volume * density;

		Assert.AreEqual(6.0.ToSignificantNumber(), mass.Kilograms<SignificantNumber>());
	}

	[TestMethod]
	public void TestDensityDerivative()
	{
		var mass = 10.Kilograms();
		var volume = 2.CubicMeters();
		var density = mass / volume;

		Assert.AreEqual(5.0.ToSignificantNumber(), density.KilogramsPerCubicMeter<SignificantNumber>());
	}
}
