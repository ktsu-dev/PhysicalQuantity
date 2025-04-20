namespace PhysicalQuantity.Tests;

using ktsu.PhysicalQuantity;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PreciseNumber;
using ktsu.SignificantNumber;

[TestClass]
public class IIntegralOperatorsTests
{
	public record MockQuantity : PhysicalQuantity<MockQuantity>, IIntegralOperators<MockQuantity, MockQuantity, MockQuantity>
	{
		public static MockQuantity Integrate(MockQuantity left, MockQuantity right)
		{
			return Multiply<MockQuantity>(left, right);
		}

		public static MockQuantity operator *(MockQuantity left, MockQuantity right) => Integrate(left, right);
	}

	[TestMethod]
	public void Integrate_ShouldReturnCorrectResult()
	{
		// Arrange
		var left = MockQuantity.Create(new SignificantNumber(5.ToPreciseNumber()));
		var right = MockQuantity.Create(new SignificantNumber(3.ToPreciseNumber()));

		// Act
		var result = MockQuantity.Integrate(left, right);

		// Assert
		Assert.AreEqual(new SignificantNumber(15.ToPreciseNumber()), result.Quantity);
	}
}
