namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.Length;
using ktsu.io.PhysicalQuantity.Time;
using ktsu.io.PhysicalQuantity.Velocity;
using ktsu.io.SignificantNumber;

[TestClass]
public class LengthTests
{
	[TestMethod]
	public void TestLengthConversions()
	{
		var value = 100.ToSignificantNumber();
		Assert.AreEqual(value, value.Meters().Meters<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Meters().Kilometers<SignificantNumber>());
		Assert.AreEqual(value / 0.3048.ToSignificantNumber(), value.Meters().Feet<SignificantNumber>());
		Assert.AreEqual(value / 0.0254.ToSignificantNumber(), value.Meters().Inches<SignificantNumber>());
		Assert.AreEqual(value / 0.9144.ToSignificantNumber(), value.Meters().Yards<SignificantNumber>());
		Assert.AreEqual(value / 1609.344.ToSignificantNumber(), value.Meters().Miles<SignificantNumber>());
		Assert.AreEqual(value / 1852.ToSignificantNumber(), value.Meters().NauticalMiles<SignificantNumber>());
		Assert.AreEqual(value / 1.8288.ToSignificantNumber(), value.Meters().Fathoms<SignificantNumber>());
		Assert.AreEqual(value * 100.ToSignificantNumber(), value.Meters().Centimeters<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Meters().Millimeters<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.Meters().Micrometers<SignificantNumber>());
		Assert.AreEqual(value * 1e9.ToSignificantNumber(), value.Meters().Nanometers<SignificantNumber>());
	}

	[TestMethod]
	public void TestLengthIntegrationWithVelocity()
	{
		var velocity = 10.MetersPerSecond();
		var time = 5.Seconds();
		var length = velocity * time;

		Assert.AreEqual(50.0.ToSignificantNumber(), length.Meters<SignificantNumber>());

		length = time * velocity;

		Assert.AreEqual(50.0.ToSignificantNumber(), length.Meters<SignificantNumber>());
	}
}
