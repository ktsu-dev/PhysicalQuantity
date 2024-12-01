namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.Area;
using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Pressure;
using ktsu.SignificantNumber;

[TestClass]
public class PressureTests
{
	[TestMethod]
	public void TestPressureConversions()
	{
		var value = 1000.ToSignificantNumber();
		Assert.AreEqual(value, value.Pascals().Pascals<SignificantNumber>());
		Assert.AreEqual(value / 1e5.ToSignificantNumber(), value.Pascals().Bars<SignificantNumber>());
		Assert.AreEqual(value / 6894.757293168361.ToSignificantNumber(), value.Pascals().Psi<SignificantNumber>());
		Assert.AreEqual(value / 101325.ToSignificantNumber(), value.Pascals().Atmospheres<SignificantNumber>());
		Assert.AreEqual(value / 133.32236842105263.ToSignificantNumber(), value.Pascals().Torr<SignificantNumber>());
	}

	[TestMethod]
	public void TestPressureIntegrationWithForceAndArea()
	{
		var force = 100.Newtons();
		var area = 2.SquareMeters();
		var pressure = force / area;

		Assert.AreEqual(50.0.ToSignificantNumber(), pressure.Pascals<SignificantNumber>());
	}

	[TestMethod]
	public void TestForceIntegrationWithPressureAndArea()
	{
		var pressure = 50.Pascals();
		var area = 2.SquareMeters();
		var force = pressure * area;

		Assert.AreEqual(100.0.ToSignificantNumber(), force.Newtons<SignificantNumber>());

		force = area * pressure;
		Assert.AreEqual(100.0.ToSignificantNumber(), force.Newtons<SignificantNumber>());
	}
}
