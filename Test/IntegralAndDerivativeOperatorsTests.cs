namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.Acceleration;
using ktsu.PhysicalQuantity.AngularAcceleration;
using ktsu.PhysicalQuantity.AngularVelocity;
using ktsu.PhysicalQuantity.Area;
using ktsu.PhysicalQuantity.Density;
using ktsu.PhysicalQuantity.ElectricCurrent;
using ktsu.PhysicalQuantity.ElectricPotential;
using ktsu.PhysicalQuantity.Energy;
using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Illuminance;
using ktsu.PhysicalQuantity.Jerk;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.LuminousFlux;
using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.Power;
using ktsu.PhysicalQuantity.Pressure;
using ktsu.PhysicalQuantity.Resistance;
using ktsu.PhysicalQuantity.Time;
using ktsu.PhysicalQuantity.Velocity;
using ktsu.PhysicalQuantity.Volume;
using ktsu.SignificantNumber;

[TestClass]
public class IntegralAndDerivativeOperatorsTests
{
	[TestMethod]
	public void TestVelocityIntegration()
	{
		var acceleration = 9.8.MetersPerSecondSquared();
		var time = 5.Seconds();
		var velocity = acceleration * time;

		Assert.AreEqual(50.ToSignificantNumber(), velocity.MetersPerSecond<SignificantNumber>());

		velocity = time * acceleration;
		Assert.AreEqual(50.ToSignificantNumber(), velocity.MetersPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestForceIntegration()
	{
		var mass = 10.Kilograms();
		var acceleration = 9.8.MetersPerSecondSquared();
		var force = mass * acceleration;

		Assert.AreEqual(100.ToSignificantNumber(), force.Newtons<SignificantNumber>());

		force = acceleration * mass;
		Assert.AreEqual(100.ToSignificantNumber(), force.Newtons<SignificantNumber>());
	}

	[TestMethod]
	public void TestAccelerationDerivative()
	{
		var velocity = 20.MetersPerSecond();
		var time = 2.Seconds();
		var acceleration = velocity / time;

		Assert.AreEqual(10.0.ToSignificantNumber(), acceleration.MetersPerSecondSquared<SignificantNumber>());
	}

	[TestMethod]
	public void TestVelocityDerivative()
	{
		var length = 100.Meters();
		var time = 10.Seconds();
		var velocity = length / time;

		Assert.AreEqual(10.0.ToSignificantNumber(), velocity.MetersPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestForceDerivative()
	{
		var force = 98.Newtons();
		var mass = 10.Kilograms();
		var acceleration = force / mass;

		Assert.AreEqual(9.8.ToSignificantNumber(), acceleration.MetersPerSecondSquared<SignificantNumber>());
	}

	[TestMethod]
	public void TestAreaIntegration()
	{
		var length1 = 10.Meters();
		var length2 = 20.Meters();
		var area = length1 * length2;

		Assert.AreEqual(200.0.ToSignificantNumber(), area.SquareMeters<SignificantNumber>());
	}

	[TestMethod]
	public void TestEnergyIntegration()
	{
		var force = 10.Newtons();
		var length = 5.Meters();
		var energy = force * length;

		Assert.AreEqual(50.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());

		energy = length * force;

		Assert.AreEqual(50.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());
	}

	[TestMethod]
	public void TestPowerIntegration()
	{
		var energy = 100.Joules();
		var time = 10.Seconds();
		var power = energy / time;

		Assert.AreEqual(10.0.ToSignificantNumber(), power.Watts<SignificantNumber>());
	}

	[TestMethod]
	public void TestPressureIntegration()
	{
		var force = 100.Newtons();
		var area = 2.SquareMeters();
		var pressure = force / area;

		Assert.AreEqual(50.0.ToSignificantNumber(), pressure.Pascals<SignificantNumber>());
	}

	[TestMethod]
	public void TestMassIntegration()
	{
		var density = 2.KilogramsPerCubicMeter();
		var volume = 3.CubicMeters();
		var mass = density * volume;

		Assert.AreEqual(6.0.ToSignificantNumber(), mass.Kilograms<SignificantNumber>());

		mass = volume * density;

		Assert.AreEqual(6.0.ToSignificantNumber(), mass.Kilograms<SignificantNumber>());
	}

	//[TestMethod]
	//public void TestAmountOfSubstanceIntegration()
	//{
	//	var molarMass = 18.01528.GramsPerMole();
	//	var substanceAmount = 5.Moles();
	//	var mass = molarMass * substanceAmount;

	//	Assert.AreEqual(90.0764.ToSignificantNumber(), mass.Grams<SignificantNumber>());

	//	mass = substanceAmount * molarMass;

	//	Assert.AreEqual(90.0764.ToSignificantNumber(), mass.Grams<SignificantNumber>());
	//}

	//[TestMethod]
	//public void TestAmountOfSubstanceDerivative()
	//{
	//	var mass = 90.0764.Grams();
	//	var molarMass = 18.01528.GramsPerMole();
	//	var substanceAmount = mass / molarMass;

	//	Assert.AreEqual(5.0.ToSignificantNumber(), substanceAmount.Moles<SignificantNumber>());
	//}

	//[TestMethod]
	//public void TestElectricCurrentIntegration()
	//{
	//	var charge = 10.Coulombs();
	//	var time = 5.Seconds();
	//	var current = charge / time;

	//	Assert.AreEqual(2.0.ToSignificantNumber(), current.Amperes<SignificantNumber>());
	//}

	//[TestMethod]
	//public void TestElectricPotentialIntegration()
	//{
	//	var energy = 100.Joules();
	//	var charge = 10.Coulombs();
	//	var potential = energy / charge;

	//	Assert.AreEqual(10.0.ToSignificantNumber(), potential.Volts<SignificantNumber>());
	//}

	//[TestMethod]
	//public void TestElectricCurrentDerivative()
	//{
	//	var current = 2.Amperes();
	//	var time = 5.Seconds();
	//	var charge = current * time;

	//	Assert.AreEqual(10.0.ToSignificantNumber(), charge.Coulombs<SignificantNumber>());

	//	charge = time * current;

	//	Assert.AreEqual(10.0.ToSignificantNumber(), charge.Coulombs<SignificantNumber>());
	//}

	//[TestMethod]
	//public void TestElectricPotentialDerivative()
	//{
	//	var potential = 10.Volts();
	//	var charge = 10.Coulombs();
	//	var energy = potential * charge;

	//	Assert.AreEqual(100.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());

	//	energy = charge * potential;

	//	Assert.AreEqual(100.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());
	//}

	[TestMethod]
	public void TestIlluminanceIntegration()
	{
		var luminousFlux = 1000.Lumens();
		var area = 10.SquareMeters();
		var illuminance = luminousFlux / area;

		Assert.AreEqual(100.0.ToSignificantNumber(), illuminance.Lux<SignificantNumber>());
	}

	[TestMethod]
	public void TestIlluminanceDerivative()
	{
		var illuminance = 100.Lux();
		var area = 10.SquareMeters();
		var luminousFlux = illuminance * area;

		Assert.AreEqual(1000.0.ToSignificantNumber(), luminousFlux.Lumens<SignificantNumber>());

		luminousFlux = area * illuminance;

		Assert.AreEqual(1000.0.ToSignificantNumber(), luminousFlux.Lumens<SignificantNumber>());
	}

	//[TestMethod]
	//public void TestLuminousIntensityIntegration()
	//{
	//	var luminousFlux = 1000.Lumens();
	//	var solidAngle = 2.Steradians();
	//	var luminousIntensity = luminousFlux / solidAngle;

	//	Assert.AreEqual(500.0.ToSignificantNumber(), luminousIntensity.Candelas<SignificantNumber>());
	//}

	//[TestMethod]
	//public void TestLuminousIntensityDerivative()
	//{
	//	var luminousIntensity = 500.Candelas();
	//	var solidAngle = 2.Steradians();
	//	var luminousFlux = luminousIntensity * solidAngle;

	//	Assert.AreEqual(1000.0.ToSignificantNumber(), luminousFlux.Lumens<SignificantNumber>());

	//	luminousFlux = solidAngle * luminousIntensity;

	//	Assert.AreEqual(1000.0.ToSignificantNumber(), luminousFlux.Lumens<SignificantNumber>());
	//}

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

	[TestMethod]
	public void TestEnergyDerivativeWithTime()
	{
		var power = 100.Watts();
		var time = 10.Seconds();
		var energy = power * time;

		Assert.AreEqual(1000.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());

		energy = time * power;

		Assert.AreEqual(1000.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());
	}

	[TestMethod]
	public void TestPowerDerivativeWithCurrent()
	{
		var voltage = 10.Volts();
		var current = 10.Amperes();
		var power = voltage * current;

		Assert.AreEqual(100.0.ToSignificantNumber(), power.Watts<SignificantNumber>());

		power = current * voltage;

		Assert.AreEqual(100.0.ToSignificantNumber(), power.Watts<SignificantNumber>());
	}

	[TestMethod]
	public void TestVelocityIntegrationWithLength()
	{
		var velocity = 10.MetersPerSecond();
		var time = 5.Seconds();
		var length = velocity * time;

		Assert.AreEqual(50.0.ToSignificantNumber(), length.Meters<SignificantNumber>());

		length = time * velocity;

		Assert.AreEqual(50.0.ToSignificantNumber(), length.Meters<SignificantNumber>());
	}

	[TestMethod]
	public void TestVolumeDerivativeWithArea()
	{
		var volume = 50.CubicMeters();
		var length = 5.Meters();
		var area = volume / length;

		Assert.AreEqual(10.0.ToSignificantNumber(), area.SquareMeters<SignificantNumber>());
	}

	[TestMethod]
	public void TestDensityDerivativeWithMass()
	{
		var mass = 10.Kilograms();
		var volume = 2.CubicMeters();
		var density = mass / volume;

		Assert.AreEqual(5.0.ToSignificantNumber(), density.KilogramsPerCubicMeter<SignificantNumber>());
	}

	[TestMethod]
	public void TestVolumeIntegrationWithAreaAndLength()
	{
		var area = 10.SquareMeters();
		var length = 5.Meters();
		var volume = area * length;

		Assert.AreEqual(50.0.ToSignificantNumber(), volume.CubicMeters<SignificantNumber>());

		volume = length * area;

		Assert.AreEqual(50.0.ToSignificantNumber(), volume.CubicMeters<SignificantNumber>());
	}

	[TestMethod]
	public void TestResistanceIntegrationWithVoltageAndCurrent()
	{
		var voltage = 10.Volts();
		var current = 2.Amperes();
		var resistance = voltage / current;

		Assert.AreEqual(5.0.ToSignificantNumber(), resistance.Ohms<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngularVelocityIntegrationWithTime()
	{
		var angularAcceleration = 2.RadiansPerSecondSquared();
		var time = 3.Seconds();
		var angularVelocity = angularAcceleration * time;

		Assert.AreEqual(6.0.ToSignificantNumber(), angularVelocity.RadiansPerSecond<SignificantNumber>());

		angularVelocity = time * angularAcceleration;

		Assert.AreEqual(6.0.ToSignificantNumber(), angularVelocity.RadiansPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngularAccelerationDerivativeWithTime()
	{
		var angularVelocity = 6.RadiansPerSecond();
		var time = 3.Seconds();
		var angularAcceleration = angularVelocity / time;

		Assert.AreEqual(2.0.ToSignificantNumber(), angularAcceleration.RadiansPerSecondSquared<SignificantNumber>());
	}
}
