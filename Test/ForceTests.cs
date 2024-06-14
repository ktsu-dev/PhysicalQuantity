namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.Acceleration;
using ktsu.io.PhysicalQuantity.Force;
using ktsu.io.PhysicalQuantity.Length;
using ktsu.io.PhysicalQuantity.Mass;
using ktsu.io.SignificantNumber;

[TestClass]
public class ForceTests
{
	[TestMethod]
	public void TestForceConversions()
	{
		var value = 10.ToSignificantNumber();
		Assert.AreEqual(value, value.Newtons().Newtons<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Newtons().Kilonewtons<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Newtons().Millinewtons<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.Newtons().Micronewtons<SignificantNumber>());
		Assert.AreEqual(value / 4.4482216152605.ToSignificantNumber(), value.Newtons().PoundsForce<SignificantNumber>());
	}

	[TestMethod]
	public void TestForceIntegrationWithMassAndAcceleration()
	{
		var mass = 10.Kilograms();
		var acceleration = 9.8.MetersPerSecondSquared();
		var force = mass * acceleration;

		Assert.AreEqual(98.0.ToSignificantNumber(), force.Newtons<SignificantNumber>());

		force = acceleration * mass;

		Assert.AreEqual(98.0.ToSignificantNumber(), force.Newtons<SignificantNumber>());
	}

	[TestMethod]
	public void TestForceDerivative()
	{
		var force = 98.Newtons();
		var mass = 10.Kilograms();
		var acceleration = force / mass;

		Assert.AreEqual(9.8.ToSignificantNumber(), acceleration.MetersPerSecondSquared<SignificantNumber>());
	}
}
