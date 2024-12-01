namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.AngularAcceleration;
using ktsu.PhysicalQuantity.AngularVelocity;
using ktsu.PhysicalQuantity.Time;
using ktsu.SignificantNumber;

[TestClass]
public class AngularAccelerationTests
{
	[TestMethod]
	public void TestAngularAccelerationConversions()
	{
		var value = 3.5.ToSignificantNumber();
		Assert.AreEqual(value, value.RadiansPerSecondSquared().RadiansPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value * 57.29577951308232.ToSignificantNumber(), value.RadiansPerSecondSquared().DegreesPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value * 0.15915494309189535.ToSignificantNumber(), value.RadiansPerSecondSquared().RevolutionsPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value * 0.15915494309189535.ToSignificantNumber(), value.RadiansPerSecondSquared().TurnsPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value * 0.15915494309189535.ToSignificantNumber(), value.RadiansPerSecondSquared().CyclesPerSecondSquared<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngularAccelerationIntegration()
	{
		var angularAcceleration = 2.RadiansPerSecondSquared();
		var time = 3.Seconds();
		var angularVelocity = angularAcceleration * time;

		Assert.AreEqual(6.0.ToSignificantNumber(), angularVelocity.RadiansPerSecond<SignificantNumber>());

		angularVelocity = time * angularAcceleration;

		Assert.AreEqual(6.0.ToSignificantNumber(), angularVelocity.RadiansPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngularAccelerationDerivative()
	{
		var angularVelocity = 6.RadiansPerSecond();
		var time = 3.Seconds();
		var angularAcceleration = angularVelocity / time;

		Assert.AreEqual(2.0.ToSignificantNumber(), angularAcceleration.RadiansPerSecondSquared<SignificantNumber>());
	}
}
