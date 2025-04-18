﻿namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.Area;
using ktsu.PhysicalQuantity.Illuminance;
using ktsu.PhysicalQuantity.LuminousFlux;
using ktsu.SignificantNumber;

[TestClass]
public class IlluminanceTests
{
	[TestMethod]
	public void TestIlluminanceConversions()
	{
		var value = 500.ToSignificantNumber();
		Assert.AreEqual(value, value.Lux().Lux<SignificantNumber>());
	}

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
}
