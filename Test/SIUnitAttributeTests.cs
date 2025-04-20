namespace PhysicalQuantity.Tests;

using ktsu.PhysicalQuantity;

[TestClass]
public class SIUnitAttributeTests
{
	[TestMethod]
	public void Constructor_ShouldSetPropertiesCorrectly()
	{
		// Arrange
		string expectedSymbol = "m";
		string expectedSingular = "meter";
		string expectedPlural = "meters";

		// Act
		var attribute = new SIUnitAttribute(expectedSymbol, expectedSingular, expectedPlural);

		// Assert
		Assert.AreEqual(expectedSymbol, attribute.Symbol);
		Assert.AreEqual(expectedSingular, attribute.Singular);
		Assert.AreEqual(expectedPlural, attribute.Plural);
	}
}
