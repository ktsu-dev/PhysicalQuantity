namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.AngularMomentum;
using ktsu.PhysicalQuantity.AngularVelocity;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.MomentOfInertia;
using ktsu.SignificantNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MomentOfInertiaTests
{
	[TestMethod]
	public void TestMomentOfInertiaCalculation()
	{
		var mass = 10.Kilograms();
		var radius = 2.Meters();
		var momentOfInertia = MomentOfInertia.FromMassAndRadius(mass, radius);

		Assert.AreEqual(40.ToSignificantNumber(), momentOfInertia.KilogramSquareMeters<SignificantNumber>());
	}

	[TestMethod]
	public void TestMomentOfInertiaConversions()
	{
		var momentOfInertia = 50.KilogramSquareMeters();
		Assert.AreEqual(50.ToSignificantNumber(), momentOfInertia.KilogramSquareMeters<SignificantNumber>());
	}

	[TestMethod]
	public void TestMomentOfInertiaAndAngularMomentum()
	{
		var momentOfInertia = 10.KilogramSquareMeters();
		var angularVelocity = 2.RadiansPerSecond();
		var angularMomentum = momentOfInertia * angularVelocity;

		Assert.AreEqual(20.ToSignificantNumber(), angularMomentum.KilogramSquareMetersPerSecond<SignificantNumber>());
	}
}
