namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.Angle;
using ktsu.io.PhysicalQuantity.AngularVelocity;
using ktsu.io.PhysicalQuantity.Time;
using ktsu.io.SignificantNumber;

[TestClass]
public class AngleTests
{
	[TestMethod]
	public void TestAngleConversions()
	{
		var value = 180.ToSignificantNumber();
		Assert.AreEqual(value, value.Degrees().Degrees<SignificantNumber>());
		Assert.AreEqual(value * 0.017453292519943295.ToSignificantNumber(), value.Degrees().Radians<SignificantNumber>());
		Assert.AreEqual(value * 200.ToSignificantNumber() / 180.ToSignificantNumber(), value.Degrees().Gradians<SignificantNumber>());
		Assert.AreEqual(value * 0.0027777777777777778.ToSignificantNumber(), value.Degrees().Revolutions<SignificantNumber>());
		Assert.AreEqual(60.ToSignificantNumber(), 1.Degrees().ArcMinutes<SignificantNumber>());
		Assert.AreEqual(3600.ToSignificantNumber(), 1.Degrees().ArcSeconds<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngleIntegration()
	{
		var angularVelocity = 1.RadiansPerSecond();
		var time = 2.Seconds();
		var angle = angularVelocity * time;

		Assert.AreEqual(2.0.ToSignificantNumber(), angle.Radians<SignificantNumber>());

		angle = time * angularVelocity;

		Assert.AreEqual(2.0.ToSignificantNumber(), angle.Radians<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngleDerivative()
	{
		var angle = 2.Radians();
		var time = 2.Seconds();
		var angularVelocity = angle / time;

		Assert.AreEqual(1.0.ToSignificantNumber(), angularVelocity.RadiansPerSecond<SignificantNumber>());
	}
}
