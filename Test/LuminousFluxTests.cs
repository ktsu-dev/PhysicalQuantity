namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.LuminousFlux;
using ktsu.PhysicalQuantity.LuminousIntensity;
using ktsu.PhysicalQuantity.SolidAngle;
using ktsu.SignificantNumber;

[TestClass]
public class LuminousFluxTests
{
	[TestMethod]
	public void TestLuminousFluxConversions()
	{
		var value = 1500.ToSignificantNumber();
		Assert.AreEqual(value, value.Lumens().Lumens<SignificantNumber>());
	}

	[TestMethod]
	public void TestLuminousFluxIntegrationWithLuminousIntensity()
	{
		var luminousIntensity = 500.Candelas();
		var solidAngle = 3.Steradians();
		var luminousFlux = luminousIntensity * solidAngle;

		Assert.AreEqual(1500.0.ToSignificantNumber(), luminousFlux.Lumens<SignificantNumber>());

		luminousFlux = solidAngle * luminousIntensity;

		Assert.AreEqual(1500.0.ToSignificantNumber(), luminousFlux.Lumens<SignificantNumber>());
	}

	[TestMethod]
	public void TestLuminousFluxDerivativeWithLuminousIntensity()
	{
		var luminousFlux = 1500.Lumens();
		var solidAngle = 3.Steradians();
		var luminousIntensity = luminousFlux / solidAngle;

		Assert.AreEqual(500.0.ToSignificantNumber(), luminousIntensity.Candelas<SignificantNumber>());
	}
}
