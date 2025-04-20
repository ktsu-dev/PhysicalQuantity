namespace PhysicalQuantity.Tests;

using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Time;
using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.Temperature;
using ktsu.PhysicalQuantity.Area;
using ktsu.PhysicalQuantity.Volume;
using ktsu.PhysicalQuantity.Angle;
using ktsu.PhysicalQuantity.Velocity;
using ktsu.PhysicalQuantity.Acceleration;
using ktsu.PhysicalQuantity.Energy;
using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Power;
using ktsu.SignificantNumber;
using System;

[TestClass]
public class PhysicalQuantityExtensionMethodTests
{
	[TestMethod]
	public void NumericExtensions_ShouldCreateLengthQuantities()
	{
		// Act
		var meters = 10.Meters();
		var kilometers = 5.Kilometers();
		var millimeters = 200.Millimeters();
		var centimeters = 30.Centimeters();
		var inches = 12.Inches();
		var feet = 6.Feet();
		var yards = 3.Yards();
		var miles = 2.Miles();

		// Assert
		Assert.AreEqual(10.0, meters.Meters<double>(), 1e-10);
		Assert.AreEqual(5.0, kilometers.Kilometers<double>(), 1e-10);
		Assert.AreEqual(200.0, millimeters.Millimeters<double>(), 1e-10);
		Assert.AreEqual(30.0, centimeters.Centimeters<double>(), 1e-10);
		Assert.AreEqual(12.0, inches.Inches<double>(), 1e-10);
		Assert.AreEqual(6.0, feet.Feet<double>(), 1e-10);
		Assert.AreEqual(3.0, yards.Yards<double>(), 1e-10);
		Assert.AreEqual(2.0, miles.Miles<double>(), 1e-10);
	}

	[TestMethod]
	public void NumericExtensions_ShouldCreateTimeQuantities()
	{
		// Act
		var seconds = 60.Seconds();
		var minutes = 5.Minutes();
		var hours = 2.Hours();
		var days = 1.Days();
		var milliseconds = 500.Milliseconds();

		// Assert
		Assert.AreEqual(60.0, seconds.Seconds<double>(), 1e-10);
		Assert.AreEqual(5.0, minutes.Minutes<double>(), 1e-10);
		Assert.AreEqual(2.0, hours.Hours<double>(), 1e-10);
		Assert.AreEqual(1.0, days.Days<double>(), 1e-10);
		Assert.AreEqual(500.0, milliseconds.Milliseconds<double>(), 1e-10);
	}

	[TestMethod]
	public void NumericExtensions_ShouldCreateMassQuantities()
	{
		// Act
		var kilograms = 75.Kilograms();
		var grams = 500.Grams();
		var pounds = 180.Pounds();
		var ounces = 16.Ounces();
		var stones = 12.Stones();

		// Assert
		Assert.AreEqual(75.0, kilograms.Kilograms<double>(), 1e-10);
		Assert.AreEqual(500.0, grams.Grams<double>(), 1e-10);
		Assert.AreEqual(180.0, pounds.Pounds<double>(), 1e-10);
		Assert.AreEqual(16.0, ounces.Ounces<double>(), 1e-10);
		Assert.AreEqual(12.0, stones.Stones<double>(), 1e-10);
	}

	[TestMethod]
	public void NumericExtensions_ShouldCreateTemperatureQuantities()
	{
		// Act
		var kelvin = 300.Kelvin();
		var celsius = 25.CelsiusToKelvin();
		var fahrenheit = 70.FahrenheitToKelvin();

		// Assert
		Assert.AreEqual(300.0, kelvin.Kelvin<double>(), 1e-10);
		Assert.AreEqual(25.0, celsius.Celsius<double>(), 1e-10);
		Assert.AreEqual(70.0, fahrenheit.Fahrenheit<double>(), 1e-10);
	}

	[TestMethod]
	public void NumericExtensions_ShouldCreateAreaQuantities()
	{
		// Act
		var squareMeters = 50.SquareMeters();
		var squareKilometers = 2.SquareKilometers();
		var squareFeet = 100.SquareFeet();
		var acres = 5.Acres();

		// Assert
		Assert.AreEqual(50.0, squareMeters.SquareMeters<double>(), 1e-10);
		Assert.AreEqual(2.0, squareKilometers.SquareKilometers<double>(), 1e-10);
		Assert.AreEqual(100.0, squareFeet.SquareFeet<double>(), 1e-10);
		Assert.AreEqual(5.0, acres.Acres<double>(), 1e-10);
	}

	[TestMethod]
	public void NumericExtensions_ShouldCreateVolumeQuantities()
	{
		// Act
		var cubicMeters = 5.CubicMeters();
		var liters = 1000.Liters();
		var milliliters = 500.Milliliters();
		var cubicFeet = 35.CubicFeet();
		var gallons = 10.USGallons();

		// Assert
		Assert.AreEqual(5.0, cubicMeters.CubicMeters<double>(), 1e-10);
		Assert.AreEqual(1000.0, liters.Liters<double>(), 1e-10);
		Assert.AreEqual(500.0, milliliters.Milliliters<double>(), 1e-10);
		Assert.AreEqual(35.0, cubicFeet.CubicFeet<double>(), 1e-10);
		Assert.AreEqual(10.0, gallons.USGallons<double>(), 1e-10);
	}

	[TestMethod]
	public void NumericExtensions_ShouldCreateAngleQuantities()
	{
		// Act
		var radians = (Math.PI / 4).Radians();
		var degrees = 45.Degrees();
		var gradians = 50.Gradians();
		var revolutions = 0.5.Revolutions();

		// Assert
		Assert.AreEqual(Math.PI / 4, radians.Radians<double>(), 1e-10);
		Assert.AreEqual(45.0, degrees.Degrees<double>(), 1e-10);
		Assert.AreEqual(50.0, gradians.Gradians<double>(), 1e-10);
		Assert.AreEqual(0.5, revolutions.Revolutions<double>(), 1e-10);

		// Confirm conversions between angles work correctly
		Assert.AreEqual(45.0, radians.Degrees<double>(), 1e-10);
		Assert.AreEqual(Math.PI / 4, degrees.Radians<double>(), 1e-10);
	}

	[TestMethod]
	public void NumericExtensions_ShouldCreateVelocityQuantities()
	{
		// Act
		var metersPerSecond = 10.MetersPerSecond();
		var kilometersPerHour = 36.KilometersPerHour();
		var milesPerHour = 60.MilesPerHour();
		var knots = 20.Knots();

		// Assert
		Assert.AreEqual(10.0, metersPerSecond.MetersPerSecond<double>(), 1e-10);
		Assert.AreEqual(36.0, kilometersPerHour.KilometersPerHour<double>(), 1e-10);
		Assert.AreEqual(60.0, milesPerHour.MilesPerHour<double>(), 1e-10);
		Assert.AreEqual(20.0, knots.Knots<double>(), 1e-10);

		// Check that 36 km/h is approximately 10 m/s
		Assert.AreEqual(10.0, kilometersPerHour.MetersPerSecond<double>(), 1e-2);
	}

	[TestMethod]
	public void NumericExtensions_ShouldCreateForceQuantities()
	{
		// Act
		var newtons = 100.Newtons();
		var poundForce = 25.PoundForce();
		var kiloNewtons = 5.KiloNewtons();

		// Assert
		Assert.AreEqual(100.0, newtons.Newtons<double>(), 1e-10);
		Assert.AreEqual(25.0, poundForce.PoundForce<double>(), 1e-10);
		Assert.AreEqual(5.0, kiloNewtons.KiloNewtons<double>(), 1e-10);
	}

	[TestMethod]
	public void NumericExtensions_ShouldCreateEnergyQuantities()
	{
		// Act
		var joules = 1000.Joules();
		var kilojoules = 2.Kilojoules();
		var calories = 500.Calories();
		var kilocalories = 2.5.Kilocalories();
		var wattHours = 250.WattHours();
		var kilowattHours = 1.5.KilowattHours();

		// Assert
		Assert.AreEqual(1000.0, joules.Joules<double>(), 1e-10);
		Assert.AreEqual(2.0, kilojoules.Kilojoules<double>(), 1e-10);
		Assert.AreEqual(500.0, calories.Calories<double>(), 1e-10);
		Assert.AreEqual(2.5, kilocalories.Kilocalories<double>(), 1e-10);
		Assert.AreEqual(250.0, wattHours.WattHours<double>(), 1e-10);
		Assert.AreEqual(1.5, kilowattHours.KilowattHours<double>(), 1e-10);
	}

	[TestMethod]
	public void NumericExtensions_ShouldCreatePowerQuantities()
	{
		// Act
		var watts = 500.Watts();
		var kilowatts = 1.5.Kilowatts();
		var horsepower = 10.Horsepower();

		// Assert
		Assert.AreEqual(500.0, watts.Watts<double>(), 1e-10);
		Assert.AreEqual(1.5, kilowatts.Kilowatts<double>(), 1e-10);
		Assert.AreEqual(10.0, horsepower.Horsepower<double>(), 1e-10);
	}

	[TestMethod]
	public void GenericConversion_ShouldWorkWithDifferentNumericTypes()
	{
		// Act & Assert - Double conversions
		var lengthDouble = 10.5.Meters();
		Assert.AreEqual(10.5, lengthDouble.Meters<double>(), 1e-10);

		// Act & Assert - Float conversions
		var timeFloat = 45.5f.Seconds();
		Assert.AreEqual(45.5f, timeFloat.Seconds<float>(), 1e-6f);

		// Act & Assert - Integer conversions
		var massInt = 75.Kilograms();
		Assert.AreEqual(75, massInt.Kilograms<int>());

		// Act & Assert - Decimal conversions
		var powerDecimal = 120.5m.Watts();
		Assert.AreEqual(120.5m, powerDecimal.Watts<decimal>(), 1e-10m);
	}

	[TestMethod]
	public void QuantityConversion_ShouldRoundTrip()
	{
		// Act & Assert - Length
		var meters = 5.28.Meters();
		var feet = meters.Feet<double>();
		var backToMeters = feet.FeetToMeters();
		Assert.AreEqual(5.28, backToMeters.Meters<double>(), 1e-10);

		// Act & Assert - Temperature
		var kelvin = 295.15.Kelvin();
		var celsius = kelvin.Celsius<double>();
		var backToKelvin = celsius.CelsiusToKelvin();
		Assert.AreEqual(295.15, backToKelvin.Kelvin<double>(), 1e-10);

		// Act & Assert - Mass
		var kilograms = 65.7.Kilograms();
		var pounds = kilograms.Pounds<double>();
		var backToKilograms = pounds.PoundsToKilograms();
		Assert.AreEqual(65.7, backToKilograms.Kilograms<double>(), 1e-3);
	}
}
