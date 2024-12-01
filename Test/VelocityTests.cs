namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.Acceleration;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Time;
using ktsu.PhysicalQuantity.Velocity;
using ktsu.SignificantNumber;

[TestClass]
public class VelocityTests
{
	[TestMethod]
	public void TestVelocityConversions()
	{
		var value = 10.ToSignificantNumber();
		Assert.AreEqual(value, value.MetersPerSecond().MetersPerSecond<SignificantNumber>());
		Assert.AreEqual(value * 3.6.ToSignificantNumber(), value.MetersPerSecond().KilometersPerHour<SignificantNumber>());
		Assert.AreEqual(value / 0.44704.ToSignificantNumber(), value.MetersPerSecond().MilesPerHour<SignificantNumber>());
		Assert.AreEqual(value / 0.3048.ToSignificantNumber(), value.MetersPerSecond().FeetPerSecond<SignificantNumber>());
		Assert.AreEqual(value / 0.0254.ToSignificantNumber(), value.MetersPerSecond().InchesPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestVelocityIntegration()
	{
		var acceleration = 9.8.MetersPerSecondSquared();
		var time = 5.Seconds();
		var velocity = acceleration * time;

		Assert.AreEqual(50.ToSignificantNumber(), velocity.MetersPerSecond<SignificantNumber>());

		velocity = time * acceleration;
		Assert.AreEqual(50.ToSignificantNumber(), velocity.MetersPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestVelocityDerivative()
	{
		var length = 100.Meters();
		var time = 10.Seconds();
		var velocity = length / time;

		Assert.AreEqual(10.0.ToSignificantNumber(), velocity.MetersPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestVelocityWithAcceleration()
	{
		var velocity = 30.MetersPerSecond();
		var acceleration = 3.MetersPerSecondSquared();
		var time = 10.Seconds();
		var newVelocity = velocity + (acceleration * time);

		Assert.AreEqual(60.0.ToSignificantNumber(), newVelocity.MetersPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestAccelerationDerivative()
	{
		var velocity = 20.MetersPerSecond();
		var time = 2.Seconds();
		var acceleration = velocity / time;

		Assert.AreEqual(10.0.ToSignificantNumber(), acceleration.MetersPerSecondSquared<SignificantNumber>());
	}
}
