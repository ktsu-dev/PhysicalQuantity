namespace ktsu.io.PhysicalQuantity.Test;
using Double.Conversions.Acceleration;
using Double.Conversions.AmountOfSubstance;
using Double.Conversions.Angle;
using Double.Conversions.AngularAcceleration;
using Double.Conversions.AngularVelocity;
using Double.Conversions.Area;
using Double.Conversions.Density;
using Double.Conversions.ElectricCurrent;
using Double.Conversions.ElectricPotential;
using Double.Conversions.Energy;
using Double.Conversions.Force;
using Double.Conversions.Illuminance;
using Double.Conversions.Jerk;
using Double.Conversions.Length;
using Double.Conversions.LuminousFlux;
using Double.Conversions.LuminousIntensity;
using Double.Conversions.Mass;
using Double.Conversions.Power;
using Double.Conversions.Pressure;
using Double.Conversions.Resistance;
using Double.Conversions.Temperature;
using Double.Conversions.Time;
using Double.Conversions.Torque;
using Double.Conversions.Velocity;
using Double.Conversions.Volume;

[TestClass]
public class TestDouble
{
	[TestMethod]
	public void TestLength()
	{
		var length = 2.0.Meters();
		Assert.AreEqual("2 m (meters)", length.ToString());
		length = 1.0.Meters();
		Assert.AreEqual("1 m (meter)", length.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, length.Meters());
		CustomAsserts.AreSignificantlyEqual(3.28084, length.Feet());
		CustomAsserts.AreSignificantlyEqual(39.37008, length.Inches());
		CustomAsserts.AreSignificantlyEqual(1.09361, length.Yards());
		CustomAsserts.AreSignificantlyEqual(0.00062, length.Miles());
		CustomAsserts.AreSignificantlyEqual(0.001, length.Kilometers());
		CustomAsserts.AreSignificantlyEqual(100, length.Centimeters());
		CustomAsserts.AreSignificantlyEqual(1000, length.Millimeters());

		length = 1.0.Feet();
		CustomAsserts.AreSignificantlyEqual(1.0, length.Feet());
		length = 1.0.Inches();
		CustomAsserts.AreSignificantlyEqual(1.0, length.Inches());
		length = 1.0.Yards();
		CustomAsserts.AreSignificantlyEqual(1.0, length.Yards());
		length = 1.0.Miles();
		CustomAsserts.AreSignificantlyEqual(1.0, length.Miles());
		length = 1.0.Kilometers();
		CustomAsserts.AreSignificantlyEqual(1.0, length.Kilometers());
		length = 1.0.Centimeters();
		CustomAsserts.AreSignificantlyEqual(1.0, length.Centimeters());
		length = 1.0.Millimeters();
		CustomAsserts.AreSignificantlyEqual(1.0, length.Millimeters());
	}

	[TestMethod]
	public void TestTorque()
	{
		var torque = 2.0.NewtonMeters();
		Assert.AreEqual("2 N·m (newton meters)", torque.ToString());
		torque = 1.0.NewtonMeters();
		Assert.AreEqual("1 N·m (newton meter)", torque.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, torque.NewtonMeters());
		CustomAsserts.AreSignificantlyEqual(0.73756, torque.FootPounds());

		torque = 1.0.FootPounds();
		CustomAsserts.AreSignificantlyEqual(1.0, torque.FootPounds());
	}

	[TestMethod]
	public void TestVolume()
	{
		var volume = 2.0.CubicMeters();
		Assert.AreEqual("2 m³ (cubic meters)", volume.ToString());
		volume = 1.0.CubicMeters();
		Assert.AreEqual("1 m³ (cubic meter)", volume.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, volume.CubicMeters());
		CustomAsserts.AreSignificantlyEqual(1000, volume.Liters());
		CustomAsserts.AreSignificantlyEqual(1e6, volume.Milliliters());
		CustomAsserts.AreSignificantlyEqual(61023.74409, volume.CubicInches());
		CustomAsserts.AreSignificantlyEqual(35.31467, volume.CubicFeet());

		volume = 1.0.Liters();
		CustomAsserts.AreSignificantlyEqual(1.0, volume.Liters());
		volume = 1.0.Milliliters();
		CustomAsserts.AreSignificantlyEqual(1.0, volume.Milliliters());
		volume = 1.0.CubicInches();
		CustomAsserts.AreSignificantlyEqual(1.0, volume.CubicInches());
		volume = 1.0.CubicFeet();
		CustomAsserts.AreSignificantlyEqual(1.0, volume.CubicFeet());
	}

	[TestMethod]
	public void TestDensity()
	{
		var density = 2.0.KilogramsPerCubicMeter();
		Assert.AreEqual("2 kg/m³ (kilograms per cubic meter)", density.ToString());
		density = 1.0.KilogramsPerCubicMeter();
		Assert.AreEqual("1 kg/m³ (kilogram per cubic meter)", density.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, density.KilogramsPerCubicMeter());
		CustomAsserts.AreSignificantlyEqual(0.001, density.GramsPerCubicCentimeter());
		CustomAsserts.AreSignificantlyEqual(0.06243, density.PoundsPerCubicFoot());
		CustomAsserts.AreSignificantlyEqual(3.6127292e-5, density.PoundsPerCubicInch());

		density = 1.0.GramsPerCubicCentimeter();
		CustomAsserts.AreSignificantlyEqual(1.0, density.GramsPerCubicCentimeter());
		density = 1.0.PoundsPerCubicFoot();
		CustomAsserts.AreSignificantlyEqual(1.0, density.PoundsPerCubicFoot());
		density = 1.0.PoundsPerCubicInch();
		CustomAsserts.AreSignificantlyEqual(1.0, density.PoundsPerCubicInch());
	}

	[TestMethod]
	public void TestMass()
	{
		var mass = 2.0.Kilograms();
		Assert.AreEqual("2 kg (kilograms)", mass.ToString());
		mass = 1.0.Kilograms();
		Assert.AreEqual("1 kg (kilogram)", mass.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, mass.Kilograms());
		CustomAsserts.AreSignificantlyEqual(1000, mass.Grams());
		CustomAsserts.AreSignificantlyEqual(2.20462, mass.Pounds());
		CustomAsserts.AreSignificantlyEqual(35.27396, mass.Ounces());

		mass = 1.0.Grams();
		CustomAsserts.AreSignificantlyEqual(1.0, mass.Grams());
		mass = 1.0.Pounds();
		CustomAsserts.AreSignificantlyEqual(1.0, mass.Pounds());
		mass = 1.0.Ounces();
		CustomAsserts.AreSignificantlyEqual(1.0, mass.Ounces());
	}

	[TestMethod]
	public void TestTime()
	{
		var time = 2.0.Seconds();
		Assert.AreEqual("2 s (seconds)", time.ToString());
		time = 1.0.Seconds();
		Assert.AreEqual("1 s (second)", time.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, time.Seconds());
		CustomAsserts.AreSignificantlyEqual(1.0 / 60, time.Minutes());
		CustomAsserts.AreSignificantlyEqual(1.0 / 3600, time.Hours());
		CustomAsserts.AreSignificantlyEqual(1.0 / 86400, time.Days());

		time = 1.0.Minutes();
		CustomAsserts.AreSignificantlyEqual(1.0, time.Minutes());
		time = 1.0.Hours();
		CustomAsserts.AreSignificantlyEqual(1.0, time.Hours());
		time = 1.0.Days();
		CustomAsserts.AreSignificantlyEqual(1.0, time.Days());
	}

	[TestMethod]
	public void TestVelocity()
	{
		var velocity = 2.0.MetersPerSecond();
		Assert.AreEqual("2 m/s (meters per second)", velocity.ToString());
		velocity = 1.0.MetersPerSecond();
		Assert.AreEqual("1 m/s (meter per second)", velocity.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, velocity.MetersPerSecond());
		CustomAsserts.AreSignificantlyEqual(3.28084, velocity.FeetPerSecond());
		CustomAsserts.AreSignificantlyEqual(3.6, velocity.KilometersPerHour());
		CustomAsserts.AreSignificantlyEqual(2.23694, velocity.MilesPerHour());

		velocity = 1.0.FeetPerSecond();
		CustomAsserts.AreSignificantlyEqual(1.0, velocity.FeetPerSecond());
		velocity = 1.0.KilometersPerHour();
		CustomAsserts.AreSignificantlyEqual(1.0, velocity.KilometersPerHour());
		velocity = 1.0.MilesPerHour();
		CustomAsserts.AreSignificantlyEqual(1.0, velocity.MilesPerHour());
	}

	[TestMethod]
	public void TestTemperature()
	{
		var temperature = 2.0.Kelvins();
		Assert.AreEqual("2 K (kelvins)", temperature.ToString());
		temperature = 1.0.Kelvins();
		Assert.AreEqual("1 K (kelvin)", temperature.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, temperature.Kelvins());
		CustomAsserts.AreSignificantlyEqual(-272.15, temperature.Celsius());
		CustomAsserts.AreSignificantlyEqual(-457.87, temperature.Fahrenheit());

		temperature = 1.0.Celsius();
		CustomAsserts.AreSignificantlyEqual(1.0, temperature.Celsius());
		temperature = 1.0.Fahrenheit();
		CustomAsserts.AreSignificantlyEqual(1.0, temperature.Fahrenheit());
	}

	[TestMethod]
	public void TestResistance()
	{
		var resistance = 2.0.Ohms();
		Assert.AreEqual("2 Ω (ohms)", resistance.ToString());
		resistance = 1.0.Ohms();
		Assert.AreEqual("1 Ω (ohm)", resistance.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, resistance.Ohms());
		CustomAsserts.AreSignificantlyEqual(0.001, resistance.Kiloohms());
		CustomAsserts.AreSignificantlyEqual(1e-6, resistance.Megaohms());

		resistance = 1.0.Kiloohms();
		CustomAsserts.AreSignificantlyEqual(1.0, resistance.Kiloohms());
		resistance = 1.0.Megaohms();
		CustomAsserts.AreSignificantlyEqual(1.0, resistance.Megaohms());
	}

	[TestMethod]
	public void TestPrecision()
	{
		CustomAsserts.AreSignificantlyEqual(1.0, 1.0);
		CustomAsserts.AreSignificantlyEqual(1.0, 1.00000000000011);
		CustomAsserts.AreSignificantlyEqual(1.0, 0.99999999999999);
		CustomAsserts.AreSignificantlyUnequal(1.0, 1.0000000000111);
		CustomAsserts.AreSignificantlyUnequal(1.0, 0.8888888888888);
		CustomAsserts.AreSignificantlyUnequal(1.0, 1.1111111111111);
		CustomAsserts.AreSignificantlyUnequal(12345.678912345, 12345.5);
		CustomAsserts.AreSignificantlyEqual(12345.678912345, 12345.6);
		CustomAsserts.AreSignificantlyEqual(12345.678912345, 12345.7);
		CustomAsserts.AreSignificantlyEqual(12345.678912345, 12345.8);
		CustomAsserts.AreSignificantlyUnequal(12345.678912345, 12345.9);
	}

	[TestMethod]
	public void TestPressure()
	{
		var pressure = 2.0.Pascals();
		Assert.AreEqual("2 Pa (pascals)", pressure.ToString());
		pressure = 1.0.Pascals();
		Assert.AreEqual("1 Pa (pascal)", pressure.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, pressure.Pascals());
		CustomAsserts.AreSignificantlyEqual(0.001, pressure.Kilopascals());
		CustomAsserts.AreSignificantlyEqual(0.000145037, pressure.PoundsPerSquareInch());

		pressure = 1.0.Kilopascals();
		CustomAsserts.AreSignificantlyEqual(1.0, pressure.Kilopascals());
		pressure = 1.0.PoundsPerSquareInch();
		CustomAsserts.AreSignificantlyEqual(1.0, pressure.PoundsPerSquareInch());
	}

	[TestMethod]
	public void TestPower()
	{
		var power = 2.0.Watts();
		Assert.AreEqual("2 W (watts)", power.ToString());
		power = 1.0.Watts();
		Assert.AreEqual("1 W (watt)", power.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, power.Watts());
		CustomAsserts.AreSignificantlyEqual(0.001, power.Kilowatts());
		CustomAsserts.AreSignificantlyEqual(0.00134102, power.Horsepower());

		power = 1.0.Kilowatts();
		CustomAsserts.AreSignificantlyEqual(1.0, power.Kilowatts());
		power = 1.0.Horsepower();
		CustomAsserts.AreSignificantlyEqual(1.0, power.Horsepower());
	}

	[TestMethod]
	public void TestLuminousIntensity()
	{
		var luminousIntensity = 2.0.Candelas();
		Assert.AreEqual("2 cd (candelas)", luminousIntensity.ToString());
		luminousIntensity = 1.0.Candelas();
		Assert.AreEqual("1 cd (candela)", luminousIntensity.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, luminousIntensity.Candelas());
	}

	[TestMethod]
	public void TestLuminousFlux()
	{
		var luminousFlux = 2.0.Lumens();
		Assert.AreEqual("2 lm (lumens)", luminousFlux.ToString());
		luminousFlux = 1.0.Lumens();
		Assert.AreEqual("1 lm (lumen)", luminousFlux.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, luminousFlux.Lumens());
	}

	[TestMethod]
	public void TestAcceleration()
	{
		var acceleration = 2.0.MetersPerSecondSquared();
		Assert.AreEqual("2 m/s² (meters per second squared)", acceleration.ToString());
		acceleration = 1.0.MetersPerSecondSquared();
		Assert.AreEqual("1 m/s² (meter per second squared)", acceleration.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, acceleration.MetersPerSecondSquared());
		CustomAsserts.AreSignificantlyEqual(3.28084, acceleration.FeetPerSecondSquared());

		acceleration = 1.0.FeetPerSecondSquared();
		CustomAsserts.AreSignificantlyEqual(1.0, acceleration.FeetPerSecondSquared());
	}

	[TestMethod]
	public void TestAmountOfSubstance()
	{
		var amountOfSubstance = 2.0.Moles();
		Assert.AreEqual("2 mol (moles)", amountOfSubstance.ToString());
		amountOfSubstance = 1.0.Moles();
		Assert.AreEqual("1 mol (mole)", amountOfSubstance.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, amountOfSubstance.Moles());
	}

	[TestMethod]
	public void TestAngle()
	{
		var angle = 2.0.Radians();
		Assert.AreEqual("2 rad (radians)", angle.ToString());
		angle = 1.0.Radians();
		Assert.AreEqual("1 rad (radian)", angle.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, angle.Radians());
		CustomAsserts.AreSignificantlyEqual(57.29578, angle.Degrees());
		CustomAsserts.AreSignificantlyEqual(63.66198, angle.Gradians());
		CustomAsserts.AreSignificantlyEqual(0.15915, angle.Revolutions());

		angle = 1.0.Degrees();
		CustomAsserts.AreSignificantlyEqual(1.0, angle.Degrees());
		angle = 1.0.Gradians();
		CustomAsserts.AreSignificantlyEqual(1.0, angle.Gradians());
		angle = 1.0.Revolutions();
		CustomAsserts.AreSignificantlyEqual(1.0, angle.Revolutions());
	}

	[TestMethod]
	public void TestAngularAcceleration()
	{
		var angularAcceleration = 2.0.RadiansPerSecondSquared();
		Assert.AreEqual("2 rad/s² (radians per second squared)", angularAcceleration.ToString());
		angularAcceleration = 1.0.RadiansPerSecondSquared();
		Assert.AreEqual("1 rad/s² (radian per second squared)", angularAcceleration.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, angularAcceleration.RadiansPerSecondSquared());
		CustomAsserts.AreSignificantlyEqual(57.29578, angularAcceleration.DegreesPerSecondSquared());

		angularAcceleration = 1.0.DegreesPerSecondSquared();
		CustomAsserts.AreSignificantlyEqual(1.0, angularAcceleration.DegreesPerSecondSquared());
	}

	[TestMethod]
	public void TestAngularVelocity()
	{
		var angularVelocity = 2.0.RadiansPerSecond();
		Assert.AreEqual("2 rad/s (radians per second)", angularVelocity.ToString());
		angularVelocity = 1.0.RadiansPerSecond();
		Assert.AreEqual("1 rad/s (radian per second)", angularVelocity.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, angularVelocity.RadiansPerSecond());
		CustomAsserts.AreSignificantlyEqual(57.29578, angularVelocity.DegreesPerSecond());
		CustomAsserts.AreSignificantlyEqual(9.5493, angularVelocity.RevolutionsPerMinute());
		CustomAsserts.AreSignificantlyEqual(0.15915, angularVelocity.RevolutionsPerSecond());

		angularVelocity = 1.0.DegreesPerSecond();
		CustomAsserts.AreSignificantlyEqual(1.0, angularVelocity.DegreesPerSecond());
		angularVelocity = 1.0.RevolutionsPerMinute();
		CustomAsserts.AreSignificantlyEqual(1.0, angularVelocity.RevolutionsPerMinute());
		angularVelocity = 1.0.RevolutionsPerSecond();
		CustomAsserts.AreSignificantlyEqual(1.0, angularVelocity.RevolutionsPerSecond());
	}

	[TestMethod]
	public void TestArea()
	{
		var area = 2.0.SquareMeters();
		Assert.AreEqual("2 m² (square meters)", area.ToString());
		area = 1.0.SquareMeters();
		Assert.AreEqual("1 m² (square meter)", area.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, area.SquareMeters());
		CustomAsserts.AreSignificantlyEqual(10.76391, area.SquareFeet());
		CustomAsserts.AreSignificantlyEqual(1550.0031, area.SquareInches());
		CustomAsserts.AreSignificantlyEqual(1.19599, area.SquareYards());
		CustomAsserts.AreSignificantlyEqual(3.861e-7, area.SquareMiles());
		CustomAsserts.AreSignificantlyEqual(1e-4, area.Hectares());
		CustomAsserts.AreSignificantlyEqual(0.000247105, area.Acres());

		area = 1.0.SquareFeet();
		CustomAsserts.AreSignificantlyEqual(1.0, area.SquareFeet());
		area = 1.0.SquareInches();
		CustomAsserts.AreSignificantlyEqual(1.0, area.SquareInches());
		area = 1.0.SquareYards();
		CustomAsserts.AreSignificantlyEqual(1.0, area.SquareYards());
		area = 1.0.SquareMiles();
		CustomAsserts.AreSignificantlyEqual(1.0, area.SquareMiles());
		area = 1.0.Hectares();
		CustomAsserts.AreSignificantlyEqual(1.0, area.Hectares());
		area = 1.0.Acres();
		CustomAsserts.AreSignificantlyEqual(1.0, area.Acres());
	}

	[TestMethod]
	public void TestElectricCurrent()
	{
		var electricCurrent = 2.0.Amperes();
		Assert.AreEqual("2 A (amperes)", electricCurrent.ToString());
		electricCurrent = 1.0.Amperes();
		Assert.AreEqual("1 A (ampere)", electricCurrent.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, electricCurrent.Amperes());
	}

	[TestMethod]
	public void TestElectricPotential()
	{
		var electricPotential = 2.0.Volts();
		Assert.AreEqual("2 V (volts)", electricPotential.ToString());
		electricPotential = 1.0.Volts();
		Assert.AreEqual("1 V (volt)", electricPotential.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, electricPotential.Volts());
		CustomAsserts.AreSignificantlyEqual(1000, electricPotential.Millivolts());

		electricPotential = 1.0.Millivolts();
		CustomAsserts.AreSignificantlyEqual(1.0, electricPotential.Millivolts());
	}

	[TestMethod]
	public void TestEnergy()
	{
		var energy = 2.0.Joules();
		Assert.AreEqual("2 J (joules)", energy.ToString());
		energy = 1.0.Joules();
		Assert.AreEqual("1 J (joule)", energy.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, energy.Joules());
		CustomAsserts.AreSignificantlyEqual(0.001, energy.Kilojoules());

		energy = 1.0.Kilojoules();
		CustomAsserts.AreSignificantlyEqual(1.0, energy.Kilojoules());
	}

	[TestMethod]
	public void TestForce()
	{
		var force = 2.0.Newtons();
		Assert.AreEqual("2 N (newtons)", force.ToString());
		force = 1.0.Newtons();
		Assert.AreEqual("1 N (newton)", force.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, force.Newtons());
		CustomAsserts.AreSignificantlyEqual(0.001, force.Kilonewtons());
		CustomAsserts.AreSignificantlyEqual(0.22481, force.PoundsForce());

		force = 1.0.Kilonewtons();
		CustomAsserts.AreSignificantlyEqual(1.0, force.Kilonewtons());
		force = 1.0.PoundsForce();
		CustomAsserts.AreSignificantlyEqual(1.0, force.PoundsForce());
	}

	[TestMethod]
	public void TestJerk()
	{
		var jerk = 2.0.MetersPerSecondCubed();
		Assert.AreEqual("2 m/s³ (meters per second cubed)", jerk.ToString());
		jerk = 1.0.MetersPerSecondCubed();
		Assert.AreEqual("1 m/s³ (meter per second cubed)", jerk.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, jerk.MetersPerSecondCubed());
		CustomAsserts.AreSignificantlyEqual(3.28084, jerk.FeetPerSecondCubed());

		jerk = 1.0.FeetPerSecondCubed();
		CustomAsserts.AreSignificantlyEqual(1.0, jerk.FeetPerSecondCubed());
	}

	[TestMethod]
	public void TestIlluminance()
	{
		var illuminance = 2.0.Lux();
		Assert.AreEqual("2 lx (lux)", illuminance.ToString());
		illuminance = 1.0.Lux();
		Assert.AreEqual("1 lx (lux)", illuminance.ToString());

		CustomAsserts.AreSignificantlyEqual(1.0, illuminance.Lux());
	}
}
