namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.ElectricCurrent;
using ktsu.io.PhysicalQuantity.ElectricPotential;
using ktsu.io.PhysicalQuantity.Energy;
using ktsu.io.PhysicalQuantity.Time;
using ktsu.io.SignificantNumber;

[TestClass]
public class ElectricPotentialTests
{
	[TestMethod]
	public void TestElectricPotentialConversions()
	{
		var value = 120.ToSignificantNumber();
		Assert.AreEqual(value, value.Volts().Volts<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Volts().Kilovolts<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Volts().Millivolts<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.Volts().Microvolts<SignificantNumber>());
		Assert.AreEqual(value * 1e9.ToSignificantNumber(), value.Volts().Nanovolts<SignificantNumber>());
	}

	//[TestMethod]
	//public void TestElectricPotentialIntegration()
	//{
	//	var energy = 100.Joules();
	//	var charge = 10.Coulombs();
	//	var potential = energy / charge;

	//	Assert.AreEqual(10.0.ToSignificantNumber(), potential.Volts<SignificantNumber>());
	//}

	//[TestMethod]
	//public void TestElectricPotentialDerivative()
	//{
	//	var potential = 10.Volts();
	//	var charge = 10.Coulombs();
	//	var energy = potential * charge;

	//	Assert.AreEqual(100.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());

	//	energy = charge * potential;

	//	Assert.AreEqual(100.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());
	//}
}
