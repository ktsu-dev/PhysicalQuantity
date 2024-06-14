namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.Force;
using ktsu.io.PhysicalQuantity.Length;
using ktsu.io.PhysicalQuantity.Torque;
using ktsu.io.SignificantNumber;

[TestClass]
public class TorqueTests
{
	[TestMethod]
	public void TestTorqueConversions()
	{
		var value = 10.ToSignificantNumber();
		Assert.AreEqual(value, value.NewtonMeters().NewtonMeters<SignificantNumber>());
		Assert.AreEqual(value / 1.3558179483314004.ToSignificantNumber(), value.NewtonMeters().FootPounds<SignificantNumber>());
		Assert.AreEqual(value / 0.1130057188312.ToSignificantNumber(), value.NewtonMeters().PoundInches<SignificantNumber>());
	}

	[TestMethod]
	public void TestTorqueIntegration()
	{
		var force = 20.Newtons();
		var length = 2.Meters();
		var torque = force * length;

		Assert.AreEqual(40.0.ToSignificantNumber(), torque.NewtonMeters<SignificantNumber>());

		torque = length * force;

		Assert.AreEqual(40.0.ToSignificantNumber(), torque.NewtonMeters<SignificantNumber>());
	}

	[TestMethod]
	public void TestTorqueDerivative()
	{
		var torque = 40.NewtonMeters();
		var length = 2.Meters();
		var force = torque / length;

		Assert.AreEqual(20.0.ToSignificantNumber(), force.Newtons<SignificantNumber>());
	}
}
