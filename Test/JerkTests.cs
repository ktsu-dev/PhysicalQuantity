namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.Acceleration;
using ktsu.io.PhysicalQuantity.Jerk;
using ktsu.io.PhysicalQuantity.Time;
using ktsu.io.SignificantNumber;

[TestClass]
public class JerkTests
{
	[TestMethod]
	public void TestJerkConversions()
	{
		var value = 7.ToSignificantNumber();
		Assert.AreEqual(value, value.MetersPerSecondCubed().MetersPerSecondCubed<SignificantNumber>());
		Assert.AreEqual(value / 0.3048.ToSignificantNumber(), value.MetersPerSecondCubed().FeetPerSecondCubed<SignificantNumber>());
		Assert.AreEqual(value / 0.0254.ToSignificantNumber(), value.MetersPerSecondCubed().InchesPerSecondCubed<SignificantNumber>());
		Assert.AreEqual(value / 0.9144.ToSignificantNumber(), value.MetersPerSecondCubed().YardsPerSecondCubed<SignificantNumber>());
		Assert.AreEqual(value / 1609.344.ToSignificantNumber(), value.MetersPerSecondCubed().MilesPerSecondCubed<SignificantNumber>());
	}

	[TestMethod]
	public void TestJerkIntegration()
	{
		var jerk = 5.MetersPerSecondCubed();
		var time = 4.Seconds();
		var acceleration = jerk * time;

		Assert.AreEqual(20.0.ToSignificantNumber(), acceleration.MetersPerSecondSquared<SignificantNumber>());

		acceleration = time * jerk;

		Assert.AreEqual(20.0.ToSignificantNumber(), acceleration.MetersPerSecondSquared<SignificantNumber>());
	}

	[TestMethod]
	public void TestJerkDerivative()
	{
		var acceleration = 20.MetersPerSecondSquared();
		var time = 4.Seconds();
		var jerk = acceleration / time;

		Assert.AreEqual(5.0.ToSignificantNumber(), jerk.MetersPerSecondCubed<SignificantNumber>());
	}
}
