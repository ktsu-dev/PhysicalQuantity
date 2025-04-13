namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.AngularMomentum;
using ktsu.PhysicalQuantity.AngularVelocity;
using ktsu.PhysicalQuantity.MomentOfInertia;
using ktsu.SignificantNumber;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class AngularMomentumTests
{
	[TestMethod]
	public void TestAngularMomentumCalculation()
	{
		var momentOfInertia = 5.KilogramSquareMeters();
		var angularVelocity = 3.RadiansPerSecond();
		var angularMomentum = momentOfInertia * angularVelocity;

		Assert.AreEqual(15.ToSignificantNumber(), angularMomentum.KilogramSquareMetersPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngularMomentumConversions()
	{
		var angularMomentum = 20.KilogramSquareMetersPerSecond();
		Assert.AreEqual(20.ToSignificantNumber(), angularMomentum.KilogramSquareMetersPerSecond<SignificantNumber>());
	}
}
