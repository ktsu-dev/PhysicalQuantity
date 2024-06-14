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
		var value = 3.ToSignificantNumber();
		Assert.AreEqual(value, value.Radians().Radians<SignificantNumber>());
		Assert.AreEqual(value * 57.2957795.ToSignificantNumber(), value.Radians().Degrees<SignificantNumber>());
		Assert.AreEqual(value * 0.15915494.ToSignificantNumber(), value.Radians().Revolutions<SignificantNumber>());
		Assert.AreEqual(value * 3437.74677.ToSignificantNumber(), value.Radians().ArcMinutes<SignificantNumber>());
		Assert.AreEqual(value * 206264.806.ToSignificantNumber(), value.Radians().ArcSeconds<SignificantNumber>());
		Assert.AreEqual(value * 63.6619772.ToSignificantNumber(), value.Radians().Gradians<SignificantNumber>());
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
		Assert.AreEqual(value / 4.4482216152605.ToSignificantNumber(), value.Newtons().PoundsForce<SignificantNumber>());
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
		Assert.AreEqual(value / 6.35029318.ToSignificantNumber(), value.Kilograms().Stones<SignificantNumber>());
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
		Assert.AreEqual(value / 1e5.ToSignificantNumber(), value.Pascals().Bars<SignificantNumber>());
		Assert.AreEqual(value / 6894.757293168361.ToSignificantNumber(), value.Pascals().Psi<SignificantNumber>());
		Assert.AreEqual(value / 101325.ToSignificantNumber(), value.Pascals().Atmospheres<SignificantNumber>());
		Assert.AreEqual(value / 133.32236842105263.ToSignificantNumber(), value.Pascals().Torr<SignificantNumber>());
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
		Assert.AreEqual(value / 1.3558179483314004.ToSignificantNumber(), value.NewtonMeters().FootPounds<SignificantNumber>());
		Assert.AreEqual(value / 0.1130057188312.ToSignificantNumber(), value.NewtonMeters().PoundInches<SignificantNumber>());
	}

	[TestMethod]
	public void TestVelocityConversions()
	{
		var value = 10.ToSignificantNumber();
		Assert.AreEqual(value, value.MetersPerSecond().MetersPerSecond<SignificantNumber>());
		Assert.AreEqual(value * 3.6.ToSignificantNumber(), value.MetersPerSecond().KilometersPerHour<SignificantNumber>());
		Assert.AreEqual(value / 0.44704.ToSignificantNumber(), value.MetersPerSecond().MilesPerHour<SignificantNumber>());
		Assert.AreEqual(value / 0.3048.ToSignificantNumber(), value.MetersPerSecond().FeetPerSecond<SignificantNumber>());
		Assert.AreEqual(value / 0.0254.ToSignificantNumber(), value.MetersPerSecond().InchesPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestVolumeConversions()
	{
		var value = 10.ToSignificantNumber();
		Assert.AreEqual(value, value.CubicMeters().CubicMeters<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.CubicMeters().Liters<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.CubicMeters().Milliliters<SignificantNumber>());
		Assert.AreEqual(value * 35.314666721.ToSignificantNumber(), value.CubicMeters().CubicFeet<SignificantNumber>());
		Assert.AreEqual(value * 61023.744094732284.ToSignificantNumber(), value.CubicMeters().CubicInches<SignificantNumber>());
	}

	[TestMethod]
	public void TestSIUnitAttributeUsage()
	{
		object[] attributes = typeof(Length).GetCustomAttributes(typeof(SIUnitAttribute), false);
		Assert.AreEqual(1, attributes.Length);
		var siUnitAttribute = (SIUnitAttribute)attributes[0];
		Assert.AreEqual("m", siUnitAttribute.Symbol);
		Assert.AreEqual("meter", siUnitAttribute.Singular);
		Assert.AreEqual("meters", siUnitAttribute.Plural);
	}

	[TestMethod]
	public void TestLengthConversionAccuracy()
	{
		var value = 123.456.ToSignificantNumber();
		var convertedValue = value.Meters().Kilometers<SignificantNumber>();
		Assert.AreEqual(value / 1000.ToSignificantNumber(), convertedValue);
	}

	[TestMethod]
	public void TestEdgeCasesForConversions()
	{
		var zeroLength = 0.Meters().Kilometers<SignificantNumber>();
		Assert.AreEqual(0.ToSignificantNumber(), zeroLength);

		var negativeLength = (-5).Meters().Kilometers<SignificantNumber>();
		Assert.AreEqual((-0.005).ToSignificantNumber(), negativeLength);

		var largeLength = 1e9.Meters().Kilometers<SignificantNumber>();
		Assert.AreEqual(1e6.ToSignificantNumber(), largeLength);

		var smallLength = 1e-9.Meters().Kilometers<SignificantNumber>();
		Assert.AreEqual(1e-12.ToSignificantNumber(), smallLength);
	}

	[TestMethod]
	public void TestOverloadedOperators()
	{
		var length1 = 2.Meters();
		var length2 = 3.Meters();
		var result = length1 + length2;
		Assert.AreEqual(5.ToSignificantNumber(), result.Meters<SignificantNumber>());
		result = length1 - length2;
		Assert.AreEqual((-1).ToSignificantNumber(), result.Meters<SignificantNumber>());
	}

	[TestMethod]
	public void TestQuantityComparisons()
	{
		var length1 = 100.Meters();
		var length2 = 200.Meters();
		Assert.IsTrue(length1 < length2);
		Assert.IsTrue(length2 > length1);
		Assert.AreEqual(length1, length1);
		Assert.AreNotEqual(length1, length2);
	}
}
