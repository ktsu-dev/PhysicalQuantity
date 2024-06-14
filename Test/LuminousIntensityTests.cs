namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.LuminousFlux;
using ktsu.io.PhysicalQuantity.LuminousIntensity;
using ktsu.io.PhysicalQuantity.SolidAngle;
using ktsu.io.SignificantNumber;

[TestClass]
public class LuminousIntensityTests
{
	[TestMethod]
	public void TestLuminousIntensityConversions()
	{
		var value = 20.ToSignificantNumber();
		Assert.AreEqual(value, value.Candelas().Candelas<SignificantNumber>());
	}

	[TestMethod]
	public void TestLuminousIntensityIntegrationWithLuminousFlux()
	{
		var luminousFlux = 1000.Lumens();
		var solidAngle = 2.Steradians();
		var luminousIntensity = luminousFlux / solidAngle;

		Assert.AreEqual(500.0.ToSignificantNumber(), luminousIntensity.Candelas<SignificantNumber>());
	}

	[TestMethod]
	public void TestLuminousIntensityDerivativeWithLuminousFlux()
	{
		var luminousIntensity = 500.Candelas();
		var solidAngle = 2.Steradians();
		var luminousFlux = luminousIntensity * solidAngle;

		Assert.AreEqual(1000.0.ToSignificantNumber(), luminousFlux.Lumens<SignificantNumber>());
	}
}
