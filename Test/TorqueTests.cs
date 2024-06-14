namespace ktsu.io.PhysicalQuantity.Tests;

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
}
