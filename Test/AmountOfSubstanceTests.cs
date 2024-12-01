namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.AmountOfSubstance;
using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.MolarMass;
using ktsu.SignificantNumber;

[TestClass]
public class AmountOfSubstanceTests
{
	[TestMethod]
	public void TestAmountOfSubstanceConversions()
	{
		var value = 2.ToSignificantNumber();
		Assert.AreEqual(value, value.Moles().Moles<SignificantNumber>());
		Assert.AreEqual(value * 1000.ToSignificantNumber(), value.Moles().Millimoles<SignificantNumber>());
		Assert.AreEqual(value * 1e6.ToSignificantNumber(), value.Moles().Micromoles<SignificantNumber>());
		Assert.AreEqual(value * 1e9.ToSignificantNumber(), value.Moles().Nanomoles<SignificantNumber>());
	}

	[TestMethod]
	public void TestAmountOfSubstanceIntegrationWithMass()
	{
		var molarMass = 18.01528.GramsPerMole();
		var substanceAmount = 5.Moles();
		var mass = molarMass * substanceAmount;

		Assert.AreEqual(100.ToSignificantNumber(), mass.Grams<SignificantNumber>());

		mass = substanceAmount * molarMass;

		Assert.AreEqual(100.ToSignificantNumber(), mass.Grams<SignificantNumber>());
	}

	[TestMethod]
	public void TestAmountOfSubstanceDerivativeWithMass()
	{
		var mass = 90.0764.Grams();
		var molarMass = 18.01528.GramsPerMole();
		var substanceAmount = mass / molarMass;

		Assert.AreEqual(5.0.ToSignificantNumber(), substanceAmount.Moles<SignificantNumber>());
	}
}
