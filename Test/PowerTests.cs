namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.Energy;
using ktsu.io.PhysicalQuantity.Power;
using ktsu.io.PhysicalQuantity.Time;
using ktsu.io.SignificantNumber;

[TestClass]
public class PowerTests
{
	[TestMethod]
	public void TestPowerConversions()
	{
		var value = 200.ToSignificantNumber();
		Assert.AreEqual(value, value.Watts().Watts<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Watts().Kilowatts<SignificantNumber>());
		Assert.AreEqual(value / 745.69987158227022.ToSignificantNumber(), value.Watts().Horsepower<SignificantNumber>());
	}

	[TestMethod]
	public void TestPowerIntegrationWithEnergyAndTime()
	{
		var energy = 1000.Joules();
		var time = 10.Seconds();
		var power = energy / time;

		Assert.AreEqual(100.0.ToSignificantNumber(), power.Watts<SignificantNumber>());
	}

	[TestMethod]
	public void TestEnergyIntegrationWithPowerAndTime()
	{
		var power = 100.Watts();
		var time = 10.Seconds();
		var energy = power * time;

		Assert.AreEqual(1000.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());

		energy = time * power;
		Assert.AreEqual(1000.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());
	}
}
