namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.Acceleration;
using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.Time;
using ktsu.PhysicalQuantity.Velocity;
using ktsu.SignificantNumber;

[TestClass]
public class AccelerationTests
{
	[TestMethod]
	public void TestAccelerationConversions()
	{
		var value = 9.8.ToSignificantNumber();
		Assert.AreEqual(value, value.MetersPerSecondSquared().MetersPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value / 0.3048.ToSignificantNumber(), value.MetersPerSecondSquared().FeetPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value / 0.0254.ToSignificantNumber(), value.MetersPerSecondSquared().InchesPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value / 0.9144.ToSignificantNumber(), value.MetersPerSecondSquared().YardsPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value / 1609.344.ToSignificantNumber(), value.MetersPerSecondSquared().MilesPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value / 1852.ToSignificantNumber(), value.MetersPerSecondSquared().NauticalMilesPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value / 1.8288.ToSignificantNumber(), value.MetersPerSecondSquared().FathomsPerSecondSquared<SignificantNumber>());
	}

	[TestMethod]
	public void TestAccelerationIntegrationWithVelocity()
	{
		var acceleration = 9.8.MetersPerSecondSquared();
		var time = 5.Seconds();
		var velocity = acceleration * time;

		Assert.AreEqual(50.ToSignificantNumber(), velocity.MetersPerSecond<SignificantNumber>());

		velocity = time * acceleration;
		Assert.AreEqual(50.ToSignificantNumber(), velocity.MetersPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestAccelerationIntegrationWithLength()
	{
		var initialVelocity = 0.MetersPerSecond();
		var time = 5.Seconds();
		var acceleration = 9.8.MetersPerSecondSquared();
		var length = (initialVelocity * time) + (acceleration * time * time * 0.5.ToSignificantNumber());

		Assert.AreEqual(100.ToSignificantNumber(), length.Meters<SignificantNumber>());
	}

	[TestMethod]
	public void TestAccelerationDerivativeWithVelocityAndTime()
	{
		var velocity = 20.MetersPerSecond();
		var time = 2.Seconds();
		var acceleration = velocity / time;

		Assert.AreEqual(10.0.ToSignificantNumber(), acceleration.MetersPerSecondSquared<SignificantNumber>());
	}

	[TestMethod]
	public void TestAccelerationDerivativeWithForceAndMass()
	{
		var force = 98.Newtons();
		var mass = 10.Kilograms();
		var acceleration = force / mass;

		Assert.AreEqual(9.8.ToSignificantNumber(), acceleration.MetersPerSecondSquared<SignificantNumber>());
	}
}
