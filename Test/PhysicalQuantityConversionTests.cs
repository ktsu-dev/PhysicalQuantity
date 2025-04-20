namespace PhysicalQuantity.Tests;

using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Time;
using ktsu.PhysicalQuantity.Velocity;
using ktsu.PhysicalQuantity.Acceleration;
using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Energy;
using ktsu.PhysicalQuantity.Power;
using ktsu.PhysicalQuantity.Area;
using ktsu.PhysicalQuantity.Volume;
using ktsu.PhysicalQuantity.Density;
using ktsu.PhysicalQuantity.Temperature;
using ktsu.PreciseNumber;
using ktsu.SignificantNumber;

[TestClass]
public class PhysicalQuantityConversionTests
{
	[TestMethod]
	public void LengthConversions_ShouldBeConsistent()
	{
		// Arrange
		var length = 10.Meters();

		// Act & Assert
		Assert.AreEqual(0.01, length.Kilometers<double>(), 1e-10);
		Assert.AreEqual(1000, length.Millimeters<double>(), 1e-10);
		Assert.AreEqual(32.8084, length.Feet<double>(), 1e-4);
		Assert.AreEqual(393.7008, length.Inches<double>(), 1e-4);
		Assert.AreEqual(10.9361, length.Yards<double>(), 1e-4);
		Assert.AreEqual(0.006214, length.Miles<double>(), 1e-6);

		// Test round-trip
		double roundTripMeters = length.Feet<double>().Feet().Meters<double>();
		Assert.AreEqual(10.0, roundTripMeters, 1e-10);
	}

	[TestMethod]
	public void TimeConversions_ShouldBeConsistent()
	{
		// Arrange
		var time = 3600.Seconds();

		// Act & Assert
		Assert.AreEqual(1.0, time.Hours<double>(), 1e-10);
		Assert.AreEqual(60, time.Minutes<double>(), 1e-10);
		Assert.AreEqual(3_600_000, time.Milliseconds<double>(), 1e-10);
		Assert.AreEqual(0.04166667, time.Days<double>(), 1e-7);

		// Test round-trip
		var roundTripSeconds = time.Minutes<double>().MinutesToSeconds();
		Assert.AreEqual(3600.0, roundTripSeconds.Seconds<double>(), 1e-10);
	}

	[TestMethod]
	public void MassConversions_ShouldBeConsistent()
	{
		// Arrange
		var mass = 100.Kilograms();

		// Act & Assert
		Assert.AreEqual(0.1, mass.MetricTons<double>(), 1e-10);
		Assert.AreEqual(100000, mass.Grams<double>(), 1e-10);
		Assert.AreEqual(220.462, mass.Pounds<double>(), 1e-3);
		Assert.AreEqual(3527.396, mass.Ounces<double>(), 1e-3);
		Assert.AreEqual(15.747, mass.Stones<double>(), 1e-3);

		// Test round-trip
		var roundTripKilograms = mass.Pounds<double>().PoundsToKilograms();
		Assert.AreEqual(100.0, roundTripKilograms.Kilograms<double>(), 1e-3);
	}

	[TestMethod]
	public void TemperatureConversions_ShouldBeConsistent()
	{
		// Arrange
		var temperature = 373.15.Kelvin();

		// Act & Assert
		Assert.AreEqual(100.0, temperature.Celsius<double>(), 1e-10);
		Assert.AreEqual(212.0, temperature.Fahrenheit<double>(), 1e-10);

		// Test round-trip
		var roundTripKelvin = temperature.Celsius<double>().CelsiusToKelvin();
		Assert.AreEqual(373.15, roundTripKelvin.Kelvin<double>(), 1e-10);

		// Test another common temperature
		var freezingPointKelvin = 273.15.Kelvin();
		Assert.AreEqual(0.0, freezingPointKelvin.Celsius<double>(), 1e-10);
		Assert.AreEqual(32.0, freezingPointKelvin.Fahrenheit<double>(), 1e-10);
	}

	[TestMethod]
	public void AreaConversions_ShouldBeConsistent()
	{
		// Arrange
		var area = 100.SquareMeters();

		// Act & Assert
		Assert.AreEqual(0.0001, area.SquareKilometers<double>(), 1e-10);
		Assert.AreEqual(1076.391, area.SquareFeet<double>(), 1e-3);
		Assert.AreEqual(0.02471, area.Acres<double>(), 1e-5);
		Assert.AreEqual(10000, area.SquareCentimeters<double>(), 1e-10);
		Assert.AreEqual(119.599, area.SquareYards<double>(), 1e-3);

		// Test round-trip
		var roundTripSquareMeters = area.SquareFeet<double>().SquareFeetToSquareMeters();
		Assert.AreEqual(100.0, roundTripSquareMeters.SquareMeters<double>(), 1e-3);
	}

	[TestMethod]
	public void VolumeConversions_ShouldBeConsistent()
	{
		// Arrange
		var volume = 10.CubicMeters();

		// Act & Assert
		Assert.AreEqual(10000, volume.Liters<double>(), 1e-10);
		Assert.AreEqual(10000000, volume.Milliliters<double>(), 1e-10);
		Assert.AreEqual(353.147, volume.CubicFeet<double>(), 1e-3);
		Assert.AreEqual(610.237, volume.CubicYards<double>(), 1e-3);
		Assert.AreEqual(2641.721, volume.USGallons<double>(), 1e-3);

		// Test round-trip
		var roundTripCubicMeters = volume.Liters<double>().LitersToCubicMeters();
		Assert.AreEqual(10.0, roundTripCubicMeters.CubicMeters<double>(), 1e-10);
	}

	[TestMethod]
	public void VelocityConversions_ShouldBeConsistent()
	{
		// Arrange
		var speed = 10.MetersPerSecond();

		// Act & Assert
		Assert.AreEqual(36, speed.KilometersPerHour<double>(), 1e-10);
		Assert.AreEqual(22.3694, speed.MilesPerHour<double>(), 1e-4);
		Assert.AreEqual(19.4384, speed.Knots<double>(), 1e-4);
		Assert.AreEqual(32.8084, speed.FeetPerSecond<double>(), 1e-4);

		// Test round-trip
		var roundTripMetersPerSecond = speed.KilometersPerHour<double>().KilometersPerHourToMetersPerSecond();
		Assert.AreEqual(10.0, roundTripMetersPerSecond.MetersPerSecond<double>(), 1e-10);
	}
}
