namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.Area;
using ktsu.PhysicalQuantity.Density;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.Volume;
using ktsu.SignificantNumber;

[TestClass]
public class VolumeTests
{
	[TestMethod]
	public void TestVolumeConversions()
	{
		var value = 10.ToSignificantNumber();
		Assert.AreEqual(value, value.CubicMeters().CubicMeters<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.CubicMeters().Liters<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.CubicMeters().Milliliters<SignificantNumber>());
		Assert.AreEqual(value * 35.314666721.ToSignificantNumber(), value.CubicMeters().CubicFeet<SignificantNumber>());
		Assert.AreEqual(value * 61023.744094732284.ToSignificantNumber(), value.CubicMeters().CubicInches<SignificantNumber>());
	}

	[TestMethod]
	public void TestVolumeIntegrationWithAreaAndLength()
	{
		var area = 10.SquareMeters();
		var length = 5.Meters();
		var volume = area * length;

		Assert.AreEqual(50.0.ToSignificantNumber(), volume.CubicMeters<SignificantNumber>());

		volume = length * area;
		Assert.AreEqual(50.0.ToSignificantNumber(), volume.CubicMeters<SignificantNumber>());
	}

	[TestMethod]
	public void TestVolumeWithDensityAndMass()
	{
		var density = 2.KilogramsPerCubicMeter();
		var mass = 10.Kilograms();
		var volume = mass / density;

		Assert.AreEqual(5.0.ToSignificantNumber(), volume.CubicMeters<SignificantNumber>());
	}

	[TestMethod]
	public void TestVolumeWithLengthAndArea()
	{
		var length = 5.Meters();
		var area = 10.SquareMeters();
		var volume = length * area;

		Assert.AreEqual(50.0.ToSignificantNumber(), volume.CubicMeters<SignificantNumber>());

		volume = area * length;
		Assert.AreEqual(50.0.ToSignificantNumber(), volume.CubicMeters<SignificantNumber>());
	}
}
