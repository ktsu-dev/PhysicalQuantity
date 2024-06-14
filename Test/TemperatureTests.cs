namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.Temperature;
using ktsu.io.SignificantNumber;

[TestClass]
public class TemperatureTests
{
	[TestMethod]
	public void TestTemperatureConversions()
	{
		var value = 300.ToSignificantNumber();
		Assert.AreEqual(value, value.Kelvin().Kelvin<SignificantNumber>());
		Assert.AreEqual(value - 273.15.ToSignificantNumber(), value.Kelvin().Celsius<SignificantNumber>());
		Assert.AreEqual(((300.0 - 273.15).ToSignificantNumber() * (9.0 / 5.0).ToSignificantNumber()) + 32.ToSignificantNumber(), value.Kelvin().Fahrenheit<SignificantNumber>());
	}

	[TestMethod]
	public void TestCelsiusConversions()
	{
		var value = 26.85.ToSignificantNumber();
		Assert.AreEqual(value + 273.15.ToSignificantNumber(), value.Celsius().Kelvin<SignificantNumber>());
		Assert.AreEqual((value * (9.0 / 5.0).ToSignificantNumber()) + 32.ToSignificantNumber(), value.Celsius().Fahrenheit<SignificantNumber>());
	}

	[TestMethod]
	public void TestFahrenheitConversions()
	{
		var value = 80.ToSignificantNumber();
		Assert.AreEqual((value - 32.ToSignificantNumber()) * (5.0 / 9.0).ToSignificantNumber(), value.Fahrenheit().Celsius<SignificantNumber>());
		Assert.AreEqual(((value - 32.ToSignificantNumber()) * (5.0 / 9.0).ToSignificantNumber()) + 273.15.ToSignificantNumber(), value.Fahrenheit().Kelvin<SignificantNumber>());
	}

	[TestMethod]
	public void TestTemperatureDerivative()
	{
		var value1 = 300.ToSignificantNumber();
		var value2 = 310.ToSignificantNumber();
		var difference = value2.Kelvin() - value1.Kelvin();

		Assert.AreEqual(10.ToSignificantNumber(), difference.Kelvin<SignificantNumber>());
	}
}
