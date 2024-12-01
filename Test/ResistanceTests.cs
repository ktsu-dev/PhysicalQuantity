namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.ElectricCurrent;
using ktsu.PhysicalQuantity.ElectricPotential;
using ktsu.PhysicalQuantity.Resistance;
using ktsu.SignificantNumber;

[TestClass]
public class ResistanceTests
{
	[TestMethod]
	public void TestResistanceConversions()
	{
		var value = 50.ToSignificantNumber();
		Assert.AreEqual(value, value.Ohms().Ohms<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Ohms().Kiloohms<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Ohms().Milliohms<SignificantNumber>());
	}

	[TestMethod]
	public void TestResistanceIntegrationWithVoltageAndCurrent()
	{
		var voltage = 10.Volts();
		var current = 2.Amperes();
		var resistance = voltage / current;

		Assert.AreEqual(5.0.ToSignificantNumber(), resistance.Ohms<SignificantNumber>());
	}

	[TestMethod]
	public void TestVoltageIntegrationWithResistanceAndCurrent()
	{
		var resistance = 5.Ohms();
		var current = 2.Amperes();
		var voltage = resistance * current;

		Assert.AreEqual(10.0.ToSignificantNumber(), voltage.Volts<SignificantNumber>());

		voltage = current * resistance;
		Assert.AreEqual(10.0.ToSignificantNumber(), voltage.Volts<SignificantNumber>());
	}

	[TestMethod]
	public void TestCurrentDerivativeWithVoltageAndResistance()
	{
		var voltage = 10.Volts();
		var resistance = 5.Ohms();
		var current = voltage / resistance;

		Assert.AreEqual(2.0.ToSignificantNumber(), current.Amperes<SignificantNumber>());
	}
}
