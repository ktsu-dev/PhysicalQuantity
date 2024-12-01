namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.Momentum;
using ktsu.PhysicalQuantity.Velocity;
using ktsu.SignificantNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MomentumTests
{
	[TestMethod]
	public void TestMomentumCalculation()
	{
		var mass = 5.Kilograms();
		var velocity = 10.MetersPerSecond();
		var momentum = mass * velocity;

		Assert.AreEqual(50.ToSignificantNumber(), momentum.KilogramMetersPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestMomentumConversions()
	{
		var momentum = 100.KilogramMetersPerSecond();
		Assert.AreEqual(100.ToSignificantNumber(), momentum.KilogramMetersPerSecond<SignificantNumber>());
	}
}
