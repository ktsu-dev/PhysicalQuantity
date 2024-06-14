namespace ktsu.io.PhysicalQuantity.Tests;

using ktsu.io.PhysicalQuantity.Acceleration;
using ktsu.io.PhysicalQuantity.AngularAcceleration;
using ktsu.io.PhysicalQuantity.AngularVelocity;
using ktsu.io.PhysicalQuantity.Area;
using ktsu.io.PhysicalQuantity.Density;
using ktsu.io.PhysicalQuantity.ElectricCurrent;
using ktsu.io.PhysicalQuantity.ElectricPotential;
using ktsu.io.PhysicalQuantity.Energy;
using ktsu.io.PhysicalQuantity.Force;
using ktsu.io.PhysicalQuantity.Length;
using ktsu.io.PhysicalQuantity.Mass;
using ktsu.io.PhysicalQuantity.Power;
using ktsu.io.PhysicalQuantity.Pressure;
using ktsu.io.PhysicalQuantity.Resistance;
using ktsu.io.PhysicalQuantity.Time;
using ktsu.io.PhysicalQuantity.Velocity;
using ktsu.io.PhysicalQuantity.Volume;
using ktsu.io.SignificantNumber;

[TestClass]
public class IntegralAndDerivativeOperatorsTests
{
	[TestMethod]
	public void TestVelocityIntegration()
	{
		var acceleration = 9.8.MetersPerSecondSquared();
		var time = 5.Seconds();
		var velocity = acceleration * time;

		Assert.AreEqual(49.0.ToSignificantNumber(), velocity.MetersPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestLengthIntegration()
	{
		var velocity = 10.MetersPerSecond();
		var time = 5.Seconds();
		var length = velocity * time;

		Assert.AreEqual(50.0.ToSignificantNumber(), length.Meters<SignificantNumber>());
	}

	[TestMethod]
	public void TestForceIntegration()
	{
		var mass = 10.Kilograms();
		var acceleration = 9.8.MetersPerSecondSquared();
		var force = mass * acceleration;

		Assert.AreEqual(98.0.ToSignificantNumber(), force.Newtons<SignificantNumber>());
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
	public void TestVolumeIntegration()
	{
		var area = 10.SquareMeters();
		var length = 5.Meters();
		var volume = area * length;

		Assert.AreEqual(50.0.ToSignificantNumber(), volume.CubicMeters<SignificantNumber>());
	}

	[TestMethod]
	public void TestMassIntegration()
	{
		var density = 2.KilogramsPerCubicMeter();
		var volume = 3.CubicMeters();
		var mass = density * volume;

		Assert.AreEqual(6.0.ToSignificantNumber(), mass.Kilograms<SignificantNumber>());
	}

	[TestMethod]
	public void TestResistanceIntegration()
	{
		var voltage = 10.Volts();
		var current = 2.Amperes();
		var resistance = voltage / current;

		Assert.AreEqual(5.0.ToSignificantNumber(), resistance.Ohms<SignificantNumber>());
	}

	[TestMethod]
	public void TestAreaDerivative()
	{
		var area = 200.SquareMeters();
		var length = 10.Meters();
		var otherLength = area / length;

		Assert.AreEqual(20.0.ToSignificantNumber(), otherLength.Meters<SignificantNumber>());
	}

	[TestMethod]
	public void TestEnergyDerivative()
	{
		var energy = 50.Joules();
		var length = 5.Meters();
		var force = energy / length;

		Assert.AreEqual(10.0.ToSignificantNumber(), force.Newtons<SignificantNumber>());
	}

	[TestMethod]
	public void TestPowerDerivative()
	{
		var power = 10.Watts();
		var time = 10.Seconds();
		var energy = power * time;

		Assert.AreEqual(100.0.ToSignificantNumber(), energy.Joules<SignificantNumber>());
	}

	[TestMethod]
	public void TestPressureDerivative()
	{
		var pressure = 50.Pascals();
		var area = 2.SquareMeters();
		var force = pressure * area;

		Assert.AreEqual(100.0.ToSignificantNumber(), force.Newtons<SignificantNumber>());
	}

	[TestMethod]
	public void TestVolumeDerivative()
	{
		var volume = 50.CubicMeters();
		var length = 5.Meters();
		var area = volume / length;

		Assert.AreEqual(10.0.ToSignificantNumber(), area.SquareMeters<SignificantNumber>());
	}

	[TestMethod]
	public void TestMassDerivative()
	{
		var mass = 10.Kilograms();
		var volume = 2.CubicMeters();
		var density = mass / volume;

		Assert.AreEqual(5.0.ToSignificantNumber(), density.KilogramsPerCubicMeter<SignificantNumber>());
	}

	[TestMethod]
	public void TestResistanceDerivative()
	{
		var resistance = 5.Ohms();
		var current = 2.Amperes();
		var voltage = resistance * current;

		Assert.AreEqual(10.0.ToSignificantNumber(), voltage.Volts<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngularVelocityIntegration()
	{
		var angularAcceleration = 2.RadiansPerSecondSquared();
		var time = 3.Seconds();
		var angularVelocity = angularAcceleration * time;

		Assert.AreEqual(6.0.ToSignificantNumber(), angularVelocity.RadiansPerSecond<SignificantNumber>());
	}

	[TestMethod]
	public void TestAngularAccelerationDerivative()
	{
		var angularVelocity = 6.RadiansPerSecond();
		var time = 3.Seconds();
		var angularAcceleration = angularVelocity / time;

		Assert.AreEqual(2.0.ToSignificantNumber(), angularAcceleration.RadiansPerSecondSquared<SignificantNumber>());
	}
}
