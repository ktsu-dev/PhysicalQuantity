namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.Area;
using ktsu.io.PhysicalQuantity.Length;
using ktsu.io.SignificantNumber;

[TestClass]
public class AreaTests
{
	[TestMethod]
	public void TestAreaConversions()
	{
		var value = 100.ToSignificantNumber();
		Assert.AreEqual(value, value.SquareMeters().SquareMeters<SignificantNumber>());
		Assert.AreEqual(value * 10000.ToSignificantNumber(), value.SquareMeters().SquareCentimeters<SignificantNumber>());
		Assert.AreEqual(value * 1000000.ToSignificantNumber(), value.SquareMeters().SquareMillimeters<SignificantNumber>());
		Assert.AreEqual(value / 10000.ToSignificantNumber(), value.SquareMeters().Hectares<SignificantNumber>());
		Assert.AreEqual(value / 1000000.ToSignificantNumber(), value.SquareMeters().SquareKilometers<SignificantNumber>());
		Assert.AreEqual(value / 0.09290304.ToSignificantNumber(), value.SquareMeters().SquareFeet<SignificantNumber>());
		Assert.AreEqual(value / 0.00064516.ToSignificantNumber(), value.SquareMeters().SquareInches<SignificantNumber>());
		Assert.AreEqual(value / 0.83612736.ToSignificantNumber(), value.SquareMeters().SquareYards<SignificantNumber>());
		Assert.AreEqual(value / 4046.8564224.ToSignificantNumber(), value.SquareMeters().Acres<SignificantNumber>());
	}

	[TestMethod]
	public void TestAreaIntegration()
	{
		var length1 = 10.Meters();
		var length2 = 20.Meters();
		var area = length1 * length2;

		Assert.AreEqual(200.0.ToSignificantNumber(), area.SquareMeters<SignificantNumber>());

		area = length2 * length1;

		Assert.AreEqual(200.0.ToSignificantNumber(), area.SquareMeters<SignificantNumber>());
	}
}
