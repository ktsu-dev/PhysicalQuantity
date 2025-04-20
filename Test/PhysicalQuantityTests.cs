namespace ktsu.PhysicalQuantity.Tests;

using ktsu.PhysicalQuantity.Generic;
using ktsu.PreciseNumber;

using StorageType = SignificantNumber.SignificantNumber;

[TestClass]
public class PhysicalQuantityTests
{
	public record TestQuantity : PhysicalQuantity<TestQuantity> { }

	[TestMethod]
	public void CompareTo_ShouldReturnCorrectComparison()
	{
		var quantity1 = TestQuantity.Create(new StorageType(10.ToPreciseNumber()));
		var quantity2 = TestQuantity.Create(new StorageType(20.ToPreciseNumber()));

		Assert.IsTrue(quantity1.CompareTo(quantity2) < 0);
		Assert.IsTrue(quantity2.CompareTo(quantity1) > 0);
		Assert.AreEqual(0, quantity1.CompareTo(quantity1));
	}

	[TestMethod]
	public void ToString_ShouldReturnFormattedString()
	{
		var quantity = TestQuantity.Create(new StorageType(10.ToPreciseNumber()));
		Assert.IsFalse(string.IsNullOrEmpty(quantity.ToString()));
	}

	[TestMethod]
	public void OperatorOverloads_ShouldWorkCorrectly()
	{
		var quantity1 = TestQuantity.Create(new StorageType(10.ToPreciseNumber()));
		var quantity2 = TestQuantity.Create(new StorageType(20.ToPreciseNumber()));

		Assert.IsTrue(quantity1 < quantity2);
		Assert.IsTrue(quantity1 <= quantity2);
		Assert.IsTrue(quantity2 > quantity1);
		Assert.IsTrue(quantity2 >= quantity1);
	}

	[TestMethod]
	public void Pow_ShouldReturnCorrectResult()
	{
		var quantity = TestQuantity.Create(new StorageType(2.ToPreciseNumber()));
		var result = quantity.Pow(3);

		Assert.AreEqual(new StorageType(8.ToPreciseNumber()), result.Quantity);
	}

	[TestMethod]
	public void Abs_ShouldReturnAbsoluteValue()
	{
		var quantity = TestQuantity.Create(new StorageType(-10.ToPreciseNumber()));
		var result = quantity.Abs();

		Assert.AreEqual(new StorageType(10.ToPreciseNumber()), result.Quantity);
	}

	[TestMethod]
	public void Clamp_ShouldReturnClampedValue()
	{
		var quantity = TestQuantity.Create(new StorageType(15.ToPreciseNumber()));
		var result = quantity.Clamp(new StorageType(10.ToPreciseNumber()), new StorageType(20.ToPreciseNumber()));

		Assert.AreEqual(new StorageType(15.ToPreciseNumber()), result.Quantity);
	}

	[TestMethod]
	public void ConvertToQuantity_ShouldConvertCorrectly()
	{
		var value = new StorageType(10.ToPreciseNumber());
		var result = value.ConvertToQuantity<StorageType, TestQuantity>(new StorageType(2.ToPreciseNumber()), new StorageType(1.ToPreciseNumber()));

		Assert.AreEqual(new StorageType(21.ToPreciseNumber()), result.Quantity);
	}

	[TestMethod]
	public void ConvertToNumber_ShouldConvertCorrectly()
	{
		var quantity = TestQuantity.Create(new StorageType(21.ToPreciseNumber()));
		var result = quantity.ConvertToNumber(new StorageType(2.ToPreciseNumber()), new StorageType(1.ToPreciseNumber()));

		Assert.AreEqual(new StorageType(10.ToPreciseNumber()), result);
	}
}
