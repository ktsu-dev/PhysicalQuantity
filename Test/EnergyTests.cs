namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.Energy;
using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Power;
using ktsu.PhysicalQuantity.Time;
using ktsu.SignificantNumber;

[TestClass]
public class EnergyTests
{
	[TestMethod]
	public void TestEnergyConversions()
	{
		var value = 1000.ToSignificantNumber();
		Assert.AreEqual(value, value.Joules().Joules<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Joules().Kilojoules<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Joules().Millijoules<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.Joules().Microjoules<SignificantNumber>());
		Assert.AreEqual(value * 1e9.ToSignificantNumber(), value.Joules().Nanojoules<SignificantNumber>());
	}

	[TestMethod]
	public void TestEnergyIntegrationWithForceAndLength()
	{
		var force = 10.Newtons();
		var length = 5.Meters();
		var energy = force * length;

		Assert.AreEqual(50.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());

		energy = length * force;

		Assert.AreEqual(50.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());
	}

	[TestMethod]
	public void TestEnergyDerivativeWithPowerAndTime()
	{
		var power = 100.Watts();
		var time = 10.Seconds();
		var energy = power * time;

		Assert.AreEqual(1000.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());

		energy = time * power;

		Assert.AreEqual(1000.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());
	}
}
