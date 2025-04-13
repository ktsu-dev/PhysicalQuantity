namespace ktsu.PhysicalQuantity.Test;

[TestClass]
public class SIUnitAttributeTests
{
	[TestMethod]
	public void TestSIUnitAttributeInitialization()
	{
		// Arrange
		string symbol = "m";
		string singular = "meter";
		string plural = "meters";

		// Act
		var attribute = new SIUnitAttribute(symbol, singular, plural);

		// Assert
		Assert.AreEqual(symbol, attribute.Symbol);
		Assert.AreEqual(singular, attribute.Singular);
		Assert.AreEqual(plural, attribute.Plural);
	}

	[TestMethod]
	public void TestSIUnitAttributeDefaultValues()
	{
		// Arrange & Act
		var attribute = new SIUnitAttribute("m", "meter", "meters");

		// Assert
		Assert.AreEqual("m", attribute.Symbol);
		Assert.AreEqual("meter", attribute.Singular);
		Assert.AreEqual("meters", attribute.Plural);
	}

	[TestMethod]
	public void TestSIUnitAttributeAppliedToClass()
	{
		// Act
		object[] attributes = typeof(Meter).GetCustomAttributes(typeof(SIUnitAttribute), false);

		// Assert
		Assert.AreEqual(1, attributes.Length);
		var attribute = attributes[0] as SIUnitAttribute;
		Assert.IsNotNull(attribute);
		Assert.AreEqual("m", attribute!.Symbol);
		Assert.AreEqual("meter", attribute.Singular);
		Assert.AreEqual("meters", attribute.Plural);
	}

	[SIUnit("m", "meter", "meters")]
	public sealed class Meter
	{
	}
}
