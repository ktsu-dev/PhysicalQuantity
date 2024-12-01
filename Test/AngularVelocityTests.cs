namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.AngularAcceleration;
using ktsu.PhysicalQuantity.AngularVelocity;
using ktsu.PhysicalQuantity.Time;
using ktsu.SignificantNumber;

[TestClass]
public class AngularVelocityTests
{
	[TestMethod]
	public void TestAngularVelocityConversions()
	{
		var value = 2.ToSignificantNumber();
		Assert.AreEqual(value, value.RadiansPerSecond().RadiansPerSecond<SignificantNumber>());
		Assert.AreEqual(value * 57.29577951308232.ToSignificantNumber(), value.RadiansPerSecond().DegreesPerSecond<SignificantNumber>());
		Assert.AreEqual(value * 0.15915494309189535.ToSignificantNumber(), value.RadiansPerSecond().RevolutionsPerSecond<SignificantNumber>());
		Assert.AreEqual(value * 0.15915494309189535.ToSignificantNumber(), value.RadiansPerSecond().TurnsPerSecond<SignificantNumber>());
		Assert.AreEqual(value * 0.15915494309189535.ToSignificantNumber(), value.RadiansPerSecond().CyclesPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngularVelocityIntegration()
	{
		var angularAcceleration = 2.RadiansPerSecondSquared();
		var time = 3.Seconds();
		var angularVelocity = angularAcceleration * time;

		Assert.AreEqual(6.0.ToSignificantNumber(), angularVelocity.RadiansPerSecond<SignificantNumber>());

		angularVelocity = time * angularAcceleration;

		Assert.AreEqual(6.0.ToSignificantNumber(), angularVelocity.RadiansPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngularVelocityDerivative()
	{
		var angularVelocity = 6.RadiansPerSecond();
		var time = 3.Seconds();
		var angularAcceleration = angularVelocity / time;

		Assert.AreEqual(2.0.ToSignificantNumber(), angularAcceleration.RadiansPerSecondSquared<SignificantNumber>());
	}
}
