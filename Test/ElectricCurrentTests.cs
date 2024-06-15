namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.Charge;
using ktsu.io.PhysicalQuantity.ElectricCurrent;
using ktsu.io.PhysicalQuantity.Time;
using ktsu.io.SignificantNumber;

[TestClass]
public class ElectricCurrentTests
{
	[TestMethod]
	public void TestElectricCurrentConversions()
	{
		var value = 5.ToSignificantNumber();
		Assert.AreEqual(value, value.Amperes().Amperes<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Amperes().Kiloamperes<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Amperes().Milliamperes<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.Amperes().Microamperes<SignificantNumber>());
		Assert.AreEqual(value * 1e9.ToSignificantNumber(), value.Amperes().Nanoamperes<SignificantNumber>());
	}

	[TestMethod]
	public void TestElectricCurrentIntegration()
	{
		var charge = 10.Coulombs();
		var time = 5.Seconds();
		var current = charge / time;

		Assert.AreEqual(2.0.ToSignificantNumber(), current.Amperes<SignificantNumber>());
	}

	[TestMethod]
	public void TestElectricCurrentDerivative()
	{
		var current = 2.Amperes();
		var time = 5.Seconds();
		var charge = current * time;

		Assert.AreEqual(10.0.ToSignificantNumber(), charge.Coulombs<SignificantNumber>());

		charge = time * current;

		Assert.AreEqual(10.0.ToSignificantNumber(), charge.Coulombs<SignificantNumber>());
	}
}
