namespace PhysicalQuantity.Tests;

using ktsu.PhysicalQuantity;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PreciseNumber;
using ktsu.SignificantNumber;

[TestClass]
public class IDerivativeOperatorsTests
{
	public record MockQuantity : PhysicalQuantity<MockQuantity>, IDerivativeOperators<MockQuantity, MockQuantity, MockQuantity>
	{
		public static MockQuantity Derive(MockQuantity left, MockQuantity right)
		{
			return Divide<MockQuantity>(left, right);
		}

		public static MockQuantity operator /(MockQuantity left, MockQuantity right) => Derive(left, right);
	}

	[TestMethod]
	public void Derive_ShouldReturnCorrectResult()
	{
		// Arrange
		var left = MockQuantity.Create(new SignificantNumber(10.ToPreciseNumber()));
		var right = MockQuantity.Create(new SignificantNumber(2.ToPreciseNumber()));

		// Act
		var result = MockQuantity.Derive(left, right);

		// Assert
		Assert.AreEqual(new SignificantNumber(5.ToPreciseNumber()), result.Quantity);
	}

	[TestMethod]
	public void Derive_WithZeroRightOperand_ShouldThrowException()
	{
		// Arrange
		var left = MockQuantity.Create(new SignificantNumber(10.ToPreciseNumber()));
		var right = MockQuantity.Create(new SignificantNumber(0.ToPreciseNumber()));

		// Act & Assert
		Assert.ThrowsException<DivideByZeroException>(() => MockQuantity.Derive(left, right));
	}

	[TestMethod]
	public void Derive_WithNegativeValues_ShouldReturnCorrectResult()
	{
		// Arrange
		var left = MockQuantity.Create(new SignificantNumber(-10.ToPreciseNumber()));
		var right = MockQuantity.Create(new SignificantNumber(2.ToPreciseNumber()));

		// Act
		var result = MockQuantity.Derive(left, right);

		// Assert
		Assert.AreEqual(new SignificantNumber(-5.ToPreciseNumber()), result.Quantity);
	}
}
