namespace PhysicalQuantity.Tests;

using ktsu.PhysicalQuantity.Generic;
using ktsu.PreciseNumber;

using System;

using StorageType = ktsu.SignificantNumber.SignificantNumber;

[TestClass]
public class PhysicalQuantityEdgeCaseTests
{
	public record TestQuantity : PhysicalQuantity<TestQuantity> { }

	[TestMethod]
	public void Create_WithNullValue_ShouldThrowArgumentNullException()
	{
		// Arrange & Act & Assert
		Assert.ThrowsException<ArgumentNullException>(() => TestQuantity.Create(null!));
	}

	[TestMethod]
	public void CompareTo_WithNull_ShouldReturnPositive()
	{
		// Arrange
		var quantity = TestQuantity.Create(new StorageType(10.ToPreciseNumber()));

		// Act
		var result = quantity.CompareTo(null);

		// Assert
		Assert.IsTrue(result > 0);
	}

	[TestMethod]
	public void Pow_WithZeroPower_ShouldReturnOne()
	{
		// Arrange
		var quantity = TestQuantity.Create(new StorageType(10.ToPreciseNumber()));

		// Act
		var result = quantity.Pow(0);

		// Assert
		Assert.AreEqual(new StorageType(1.ToPreciseNumber()), result.Quantity);
	}

	[TestMethod]
	public void Pow_WithNegativePower_ShouldReturnCorrectResult()
	{
		// Arrange
		var quantity = TestQuantity.Create(new StorageType(2.ToPreciseNumber()));

		// Act
		var result = quantity.Pow(-2);

		// Assert
		Assert.AreEqual(new StorageType(0.25.ToPreciseNumber()), result.Quantity);
	}

	[TestMethod]
	public void Clamp_WithValueBelowMin_ShouldReturnMin()
	{
		// Arrange
		var quantity = TestQuantity.Create(new StorageType(5.ToPreciseNumber()));

		// Act
		var result = quantity.Clamp(10, 20);

		// Assert
		Assert.AreEqual(new StorageType(10.ToPreciseNumber()), result.Quantity);
	}

	[TestMethod]
	public void Clamp_WithValueAboveMax_ShouldReturnMax()
	{
		// Arrange
		var quantity = TestQuantity.Create(new StorageType(25.ToPreciseNumber()));

		// Act
		var result = quantity.Clamp(10, 20);

		// Assert
		Assert.AreEqual(new StorageType(20.ToPreciseNumber()), result.Quantity);
	}

	[TestMethod]
	public void ConvertToQuantity_WithZeroFactor_ShouldThrowDivideByZeroException()
	{
		// Arrange
		var value = 10.0;

		// Act & Assert
		Assert.ThrowsException<DivideByZeroException>(() =>
			value.ConvertToQuantity<double, TestQuantity>(new StorageType(0.ToPreciseNumber())));
	}

	[TestMethod]
	public void ToString_WithCustomFormatting_ShouldReturnCorrectString()
	{
		// Arrange
		var quantity = TestQuantity.Create(new StorageType(1234.567.ToPreciseNumber()));

		// Act
		var result = quantity.ToString();

		// Assert
		Assert.IsFalse(string.IsNullOrEmpty(result));
		Assert.IsTrue(result.Contains("1234.567"));
	}

	[TestMethod]
	public void Create_WithMaxValue_ShouldWorkCorrectly()
	{
		// Arrange & Act
		var quantity = TestQuantity.Create(new StorageType(double.MaxValue.ToPreciseNumber()));

		// Assert
		Assert.IsNotNull(quantity);
	}

	[TestMethod]
	public void Create_WithMinValue_ShouldWorkCorrectly()
	{
		// Arrange & Act
		var quantity = TestQuantity.Create(new StorageType(double.MinValue.ToPreciseNumber()));

		// Assert
		Assert.IsNotNull(quantity);
	}
}
