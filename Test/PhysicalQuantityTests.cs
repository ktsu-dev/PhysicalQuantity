// Ignore Spelling: Illuminance

namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.Acceleration;
using ktsu.io.PhysicalQuantity.AmountOfSubstance;
using ktsu.io.PhysicalQuantity.Angle;
using ktsu.io.PhysicalQuantity.AngularAcceleration;
using ktsu.io.PhysicalQuantity.AngularVelocity;
using ktsu.io.PhysicalQuantity.Area;
using ktsu.io.PhysicalQuantity.Density;
using ktsu.io.PhysicalQuantity.ElectricCurrent;
using ktsu.io.PhysicalQuantity.ElectricPotential;
using ktsu.io.PhysicalQuantity.Energy;
using ktsu.io.PhysicalQuantity.Force;
using ktsu.io.PhysicalQuantity.Illuminance;
using ktsu.io.PhysicalQuantity.Jerk;
using ktsu.io.PhysicalQuantity.Length;
using ktsu.io.PhysicalQuantity.LuminousFlux;
using ktsu.io.PhysicalQuantity.LuminousIntensity;
using ktsu.io.PhysicalQuantity.Mass;
using ktsu.io.PhysicalQuantity.Power;
using ktsu.io.PhysicalQuantity.Pressure;
using ktsu.io.PhysicalQuantity.Resistance;
using ktsu.io.PhysicalQuantity.Temperature;
using ktsu.io.PhysicalQuantity.Time;
using ktsu.io.PhysicalQuantity.Torque;
using ktsu.io.PhysicalQuantity.Velocity;
using ktsu.io.PhysicalQuantity.Volume;
using ktsu.io.SignificantNumber;

[TestClass]
public class PhysicalQuantityTests
{
	[TestMethod]
	public void TestAccelerationConversions()
	{
		var value = 9.8.ToSignificantNumber();
		Assert.AreEqual(value, value.MetersPerSecondSquared().MetersPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value / 0.3048.ToSignificantNumber(), value.MetersPerSecondSquared().FeetPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value / 0.0254.ToSignificantNumber(), value.MetersPerSecondSquared().InchesPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value / 0.9144.ToSignificantNumber(), value.MetersPerSecondSquared().YardsPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value / 1609.344.ToSignificantNumber(), value.MetersPerSecondSquared().MilesPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value / 1852.ToSignificantNumber(), value.MetersPerSecondSquared().NauticalMilesPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value / 1.8288.ToSignificantNumber(), value.MetersPerSecondSquared().FathomsPerSecondSquared<SignificantNumber>());
	}

	[TestMethod]
	public void TestAmountOfSubstanceConversions()
	{
		var value = 2.ToSignificantNumber();
		Assert.AreEqual(value, value.Moles().Moles<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Moles().Millimoles<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngleConversions()
	{
		var value = 180.ToSignificantNumber();
		Assert.AreEqual(value, value.Degrees().Degrees<SignificantNumber>());
		Assert.AreEqual(value * 0.017453292519943295.ToSignificantNumber(), value.Degrees().Radians<SignificantNumber>());
		Assert.AreEqual(value * 0.0027777777777777778.ToSignificantNumber(), value.Degrees().Revolutions<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngularAccelerationConversions()
	{
		var value = 3.5.ToSignificantNumber();
		Assert.AreEqual(value, value.RadiansPerSecondSquared().RadiansPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value * 57.29577951308232.ToSignificantNumber(), value.RadiansPerSecondSquared().DegreesPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value * 0.15915494309189535.ToSignificantNumber(), value.RadiansPerSecondSquared().RevolutionsPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value * 0.15915494309189535.ToSignificantNumber(), value.RadiansPerSecondSquared().TurnsPerSecondSquared<SignificantNumber>());
		Assert.AreEqual(value * 0.15915494309189535.ToSignificantNumber(), value.RadiansPerSecondSquared().CyclesPerSecondSquared<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngularVelocityConversions()
	{
		var value = 2.ToSignificantNumber();
		Assert.AreEqual(value, value.RadiansPerSecond().RadiansPerSecond<SignificantNumber>());
		Assert.AreEqual(value * 57.29577951308232.ToSignificantNumber(), value.RadiansPerSecond().DegreesPerSecond<SignificantNumber>());
		Assert.AreEqual(value * 0.15915494309189535.ToSignificantNumber(), value.RadiansPerSecond().RevolutionsPerSecond<SignificantNumber>());
		Assert.AreEqual(value * 0.15915494309189535.ToSignificantNumber(), value.RadiansPerSecond().TurnsPerSecond<SignificantNumber>());
		Assert.AreEqual(value * 0.15915494309189535.ToSignificantNumber(), value.RadiansPerSecond().CyclesPerSecond<SignificantNumber>());
	}

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
	public void TestDensityConversions()
	{
		var value = 1000.ToSignificantNumber();
		Assert.AreEqual(value, value.KilogramsPerCubicMeter().KilogramsPerCubicMeter<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.KilogramsPerCubicMeter().GramsPerCubicCentimeter<SignificantNumber>());
	}

	[TestMethod]
	public void TestElectricCurrentConversions()
	{
		var value = 5.ToSignificantNumber();

		Assert.AreEqual(value, value.Amperes().Amperes<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Amperes().Kiloamperes<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Amperes().Milliamperes<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.Amperes().Microamperes<SignificantNumber>());
		Assert.AreEqual(value * 1e9.ToSignificantNumber(), value.Amperes().Nanoamperes<SignificantNumber>());
	}

	[TestMethod]
	public void TestElectricPotentialConversions()
	{
		var value = 120.ToSignificantNumber();
		Assert.AreEqual(value, value.Volts().Volts<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Volts().Kilovolts<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Volts().Millivolts<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.Volts().Microvolts<SignificantNumber>());
		Assert.AreEqual(value * 1e9.ToSignificantNumber(), value.Volts().Nanovolts<SignificantNumber>());
	}

	[TestMethod]
	public void TestEnergyConversions()
	{
		var value = 1000.ToSignificantNumber();
		Assert.AreEqual(value, value.Joules().Joules<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Joules().Kilojoules<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Joules().Millijoules<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.Joules().Microjoules<SignificantNumber>());
		Assert.AreEqual(value * 1e9.ToSignificantNumber(), value.Joules().Nanojoules<SignificantNumber>());
	}

	[TestMethod]
	public void TestForceConversions()
	{
		var value = 10.ToSignificantNumber();
		Assert.AreEqual(value, value.Newtons().Newtons<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Newtons().Kilonewtons<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Newtons().Millinewtons<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.Newtons().Micronewtons<SignificantNumber>());
	}

	[TestMethod]
	public void TestIlluminanceConversions()
	{
		var value = 500.ToSignificantNumber();
		Assert.AreEqual(value, value.Lux().Lux<SignificantNumber>());
	}

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
	public void TestLengthConversions()
	{
		var value = 100.ToSignificantNumber();
		Assert.AreEqual(value, value.Meters().Meters<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Meters().Kilometers<SignificantNumber>());
		Assert.AreEqual(value / 0.3048.ToSignificantNumber(), value.Meters().Feet<SignificantNumber>());
		Assert.AreEqual(value / 0.0254.ToSignificantNumber(), value.Meters().Inches<SignificantNumber>());
		Assert.AreEqual(value / 0.9144.ToSignificantNumber(), value.Meters().Yards<SignificantNumber>());
		Assert.AreEqual(value / 1609.344.ToSignificantNumber(), value.Meters().Miles<SignificantNumber>());
		Assert.AreEqual(value / 1852.ToSignificantNumber(), value.Meters().NauticalMiles<SignificantNumber>());
		Assert.AreEqual(value / 1.8288.ToSignificantNumber(), value.Meters().Fathoms<SignificantNumber>());
		Assert.AreEqual(value * 100.ToSignificantNumber(), value.Meters().Centimeters<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Meters().Millimeters<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.Meters().Micrometers<SignificantNumber>());
		Assert.AreEqual(value * 1e9.ToSignificantNumber(), value.Meters().Nanometers<SignificantNumber>());
	}

	[TestMethod]
	public void TestLuminousFluxConversions()
	{
		var value = 1500.ToSignificantNumber();
		Assert.AreEqual(value, value.Lumens().Lumens<SignificantNumber>());
	}

	[TestMethod]
	public void TestLuminousIntensityConversions()
	{
		var value = 20.ToSignificantNumber();
		Assert.AreEqual(value, value.Candelas().Candelas<SignificantNumber>());
	}

	[TestMethod]
	public void TestMassConversions()
	{
		var value = 100.ToSignificantNumber();
		Assert.AreEqual(value, value.Kilograms().Kilograms<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Kilograms().Grams<SignificantNumber>());
		Assert.AreEqual(value / 0.45359237.ToSignificantNumber(), value.Kilograms().Pounds<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Kilograms().MetricTons<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.Kilograms().Milligrams<SignificantNumber>());
	}

	[TestMethod]
	public void TestPowerConversions()
	{
		var value = 200.ToSignificantNumber();
		Assert.AreEqual(value, value.Watts().Watts<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Watts().Kilowatts<SignificantNumber>());
		Assert.AreEqual(value / 745.69987158227022.ToSignificantNumber(), value.Watts().Horsepower<SignificantNumber>());
	}

	[TestMethod]
	public void TestPressureConversions()
	{
		var value = 1000.ToSignificantNumber();
		Assert.AreEqual(value, value.Pascals().Pascals<SignificantNumber>());
	}

	[TestMethod]
	public void TestResistanceConversions()
	{
		var value = 50.ToSignificantNumber();
		Assert.AreEqual(value, value.Ohms().Ohms<SignificantNumber>());
		Assert.AreEqual(value / 1000.ToSignificantNumber(), value.Ohms().Kiloohms<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Ohms().Milliohms<SignificantNumber>());
	}

	[TestMethod]
	public void TestTemperatureConversions()
	{
		var value = 300.ToSignificantNumber();
		Assert.AreEqual(value, value.Kelvin().Kelvin<SignificantNumber>());
		Assert.AreEqual(value - 273.15.ToSignificantNumber(), value.Kelvin().Celsius<SignificantNumber>());
		Assert.AreEqual(((300.0 - 273.15).ToSignificantNumber() * (9.0 / 5.0).ToSignificantNumber()) + 32.ToSignificantNumber(), value.Kelvin().Fahrenheit<SignificantNumber>());
	}

	[TestMethod]
	public void TestTimeConversions()
	{
		var value = 60.ToSignificantNumber();
		Assert.AreEqual(value, value.Seconds().Seconds<SignificantNumber>());
		Assert.AreEqual(value / 60.ToSignificantNumber(), value.Seconds().Minutes<SignificantNumber>());
		Assert.AreEqual(value / 3600.ToSignificantNumber(), value.Seconds().Hours<SignificantNumber>());
		Assert.AreEqual(value / 86400.ToSignificantNumber(), value.Seconds().Days<SignificantNumber>());
	}

	[TestMethod]
	public void TestTorqueConversions()
	{
		var value = 10.ToSignificantNumber();
		Assert.AreEqual(value, value.NewtonMeters().NewtonMeters<SignificantNumber>());
	}

	[TestMethod]
	public void TestVelocityConversions()
	{
		var value = 10.ToSignificantNumber();
		Assert.AreEqual(value, value.MetersPerSecond().MetersPerSecond<SignificantNumber>());
		Assert.AreEqual(value * 3.6.ToSignificantNumber(), value.MetersPerSecond().KilometersPerHour<SignificantNumber>());
	}

	[TestMethod]
	public void TestVolumeConversions()
	{
		var value = 1.ToSignificantNumber();
		Assert.AreEqual(value, value.CubicMeters().CubicMeters<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.CubicMeters().Liters<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.CubicMeters().Milliliters<SignificantNumber>());
	}
}
