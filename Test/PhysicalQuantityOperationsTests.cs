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
using ktsu.PhysicalQuantity.Pressure;
using ktsu.PhysicalQuantity.Momentum;
using ktsu.PhysicalQuantity.ElectricCurrent;
using ktsu.PhysicalQuantity.ElectricPotential;
using ktsu.PhysicalQuantity.Resistance;
using ktsu.SignificantNumber;

[TestClass]
public class PhysicalQuantityOperationsTests
{
	[TestMethod]
	public void VelocityFromLengthAndTime_ShouldCalculateCorrectly()
	{
		// Arrange
		var length = 100.Meters();
		var time = 10.Seconds();

		// Act
		var velocity = length / time;

		// Assert
		Assert.AreEqual(10.0, velocity.MetersPerSecond<double>(), 1e-10);
	}

	[TestMethod]
	public void AccelerationFromVelocityAndTime_ShouldCalculateCorrectly()
	{
		// Arrange
		var velocity = 20.MetersPerSecond();
		var time = 5.Seconds();

		// Act
		var acceleration = velocity / time;

		// Assert
		Assert.AreEqual(4.0, acceleration.MetersPerSecondSquared<double>(), 1e-10);
	}

	[TestMethod]
	public void ForceFromMassAndAcceleration_ShouldCalculateCorrectly()
	{
		// Arrange
		var mass = 10.Kilograms();
		var acceleration = 9.8.MetersPerSecondSquared();

		// Act
		var force = mass * acceleration;

		// Assert
		Assert.AreEqual(98.0, force.Newtons<double>(), 1e-10);
	}

	[TestMethod]
	public void EnergyFromForceAndLength_ShouldCalculateCorrectly()
	{
		// Arrange
		var force = 50.Newtons();
		var length = 2.Meters();

		// Act
		var energy = force * length;

		// Assert
		Assert.AreEqual(100.0, energy.Joules<double>(), 1e-10);
	}

	[TestMethod]
	public void PowerFromEnergyAndTime_ShouldCalculateCorrectly()
	{
		// Arrange
		var energy = 1000.Joules();
		var time = 5.Seconds();

		// Act
		var power = energy / time;

		// Assert
		Assert.AreEqual(200.0, power.Watts<double>(), 1e-10);
	}

	[TestMethod]
	public void AreaFromLengthSquared_ShouldCalculateCorrectly()
	{
		// Arrange
		var length = 5.Meters();

		// Act
		var area = length * length;

		// Assert
		Assert.AreEqual(25.0, area.SquareMeters<double>(), 1e-10);
	}

	[TestMethod]
	public void VolumeFromAreaAndLength_ShouldCalculateCorrectly()
	{
		// Arrange
		var area = 25.SquareMeters();
		var height = 4.Meters();

		// Act
		var volume = area * height;

		// Assert
		Assert.AreEqual(100.0, volume.CubicMeters<double>(), 1e-10);
	}

	[TestMethod]
	public void DensityFromMassAndVolume_ShouldCalculateCorrectly()
	{
		// Arrange
		var mass = 50.Kilograms();
		var volume = 5.CubicMeters();

		// Act
		var density = mass / volume;

		// Assert
		Assert.AreEqual(10.0, density.KilogramsPerCubicMeter<double>(), 1e-10);
	}

	[TestMethod]
	public void MassFromDensityAndVolume_ShouldCalculateCorrectly()
	{
		// Arrange
		var density = 800.KilogramsPerCubicMeter();
		var volume = 0.5.CubicMeters();

		// Act
		var mass = density * volume;

		// Assert
		Assert.AreEqual(400.0, mass.Kilograms<double>(), 1e-10);
	}

	[TestMethod]
	public void PressureFromForceAndArea_ShouldCalculateCorrectly()
	{
		// Arrange
		var force = 1000.Newtons();
		var area = 10.SquareMeters();

		// Act
		var pressure = force / area;

		// Assert
		Assert.AreEqual(100.0, pressure.Pascals<double>(), 1e-10);
	}

	[TestMethod]
	public void ForceFromPressureAndArea_ShouldCalculateCorrectly()
	{
		// Arrange
		var pressure = 200.Pascals();
		var area = 5.SquareMeters();

		// Act
		var force = pressure * area;

		// Assert
		Assert.AreEqual(1000.0, force.Newtons<double>(), 1e-10);
	}

	[TestMethod]
	public void MomentumFromMassAndVelocity_ShouldCalculateCorrectly()
	{
		// Arrange
		var mass = 5.Kilograms();
		var velocity = 10.MetersPerSecond();

		// Act
		var momentum = mass * velocity;

		// Assert
		Assert.AreEqual(50.0, momentum.KilogramMetersPerSecond<double>(), 1e-10);
	}

	[TestMethod]
	public void ElectricPotentialFromCurrentAndResistance_ShouldCalculateCorrectly()
	{
		// Arrange
		var current = 2.Amperes();
		var resistance = 10.Ohms();

		// Act
		var voltage = current * resistance;

		// Assert
		Assert.AreEqual(20.0, voltage.Volts<double>(), 1e-10);
	}

	[TestMethod]
	public void PowerFromVoltageAndCurrent_ShouldCalculateCorrectly()
	{
		// Arrange
		var voltage = 230.Volts();
		var current = 5.Amperes();

		// Act
		var power = voltage * current;

		// Assert
		Assert.AreEqual(1150.0, power.Watts<double>(), 1e-10);
	}

	[TestMethod]
	public void ComplexCalculation_ShouldWorkCorrectly()
	{
		// Calculate kinetic energy: E = 0.5 * m * v²

		// Arrange
		var mass = 2.Kilograms();
		var velocity = 10.MetersPerSecond();
		var factor = 0.5;

		// Act
		// We need to calculate v² first
		var velocitySquared = velocity * velocity;
		// Then calculate 0.5 * m * v²
		var kineticEnergy = mass * velocitySquared * factor;

		// Assert
		Assert.AreEqual(100.0, kineticEnergy.Joules<double>(), 1e-10);
	}

	[TestMethod]
	public void DistanceWithAcceleration_ShouldCalculateCorrectly()
	{
		// Formula: s = ut + 0.5at²

		// Arrange
		var initialVelocity = 5.MetersPerSecond();
		var time = 4.Seconds();
		var acceleration = 2.MetersPerSecondSquared();
		var factor = 0.5;

		// Act
		var firstTerm = initialVelocity * time;
		var timeSquared = time.Seconds<double>() * time.Seconds<double>();
		var secondTerm = factor * acceleration.MetersPerSecondSquared<double>() * timeSquared;
		var distance = firstTerm.Meters<double>() + secondTerm.Meters();

		// Assert
		// s = 5*4 + 0.5*2*16 = 20 + 16 = 36 meters
		Assert.AreEqual(36.0, distance.Meters<double>(), 1e-10);
	}
}
