namespace ktsu.PhysicalQuantity.Test;

using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Time;
using ktsu.PhysicalQuantity.Velocity;
using ktsu.SignificantNumber;

[TestClass]
public class TimeTests
{
	[TestMethod]
	public void TestTimeConversions()
	{
		var value = 3600.ToSignificantNumber();
		Assert.AreEqual(value, value.Seconds().Seconds<SignificantNumber>());
		Assert.AreEqual(value / 60.ToSignificantNumber(), value.Seconds().Minutes<SignificantNumber>());
		Assert.AreEqual(value / 3600.ToSignificantNumber(), value.Seconds().Hours<SignificantNumber>());
		Assert.AreEqual(value / 86400.ToSignificantNumber(), value.Seconds().Days<SignificantNumber>());
		Assert.AreEqual(value / 31556952.ToSignificantNumber(), value.Seconds().Years<SignificantNumber>());
	}

	[TestMethod]
	public void TestMinutesConversions()
	{
		var value = 60.ToSignificantNumber();
		Assert.AreEqual(value * 60.ToSignificantNumber(), value.Minutes().Seconds<SignificantNumber>());
		Assert.AreEqual(value / 60.ToSignificantNumber(), value.Minutes().Hours<SignificantNumber>());
		Assert.AreEqual(0.05.ToSignificantNumber(), value.Minutes().Days<SignificantNumber>());
	}

	[TestMethod]
	public void TestHoursConversions()
	{
		var value = 24.ToSignificantNumber();
		Assert.AreEqual(value * 3600.ToSignificantNumber(), value.Hours().Seconds<SignificantNumber>());
		Assert.AreEqual(1000.ToSignificantNumber(), value.Hours().Minutes<SignificantNumber>());
		Assert.AreEqual(value / 24.ToSignificantNumber(), value.Hours().Days<SignificantNumber>());
	}

	[TestMethod]
	public void TestDaysConversions()
	{
		var value = 7.ToSignificantNumber();
		Assert.AreEqual(value * 86400.ToSignificantNumber(), value.Days().Seconds<SignificantNumber>());
		Assert.AreEqual(10000.ToSignificantNumber(), value.Days().Minutes<SignificantNumber>());
		Assert.AreEqual(170.ToSignificantNumber(), value.Days().Hours<SignificantNumber>());
		Assert.AreEqual(value / 365.25.ToSignificantNumber(), value.Days().Years<SignificantNumber>());
	}

	[TestMethod]
	public void TestYearsConversions()
	{
		var value = 1.ToSignificantNumber();
		Assert.AreEqual(value * 31556952.ToSignificantNumber(), value.Years().Seconds<SignificantNumber>());
		Assert.AreEqual(value * 500000.ToSignificantNumber(), value.Years().Minutes<SignificantNumber>());
		Assert.AreEqual(value * 8800.ToSignificantNumber(), value.Years().Hours<SignificantNumber>());
		Assert.AreEqual(value * 365.25.ToSignificantNumber(), value.Years().Days<SignificantNumber>());
	}

	[TestMethod]
	public void TestTimeIntegration()
	{
		var velocity = 10.MetersPerSecond();
		var time = 5.Seconds();
		var length = velocity * time;

		Assert.AreEqual(50.0.ToSignificantNumber(), length.Meters<SignificantNumber>());

		length = time * velocity;
		Assert.AreEqual(50.0.ToSignificantNumber(), length.Meters<SignificantNumber>());
	}

	[TestMethod]
	public void TestTimeDerivative()
	{
		var length = 100.Meters();
		var time = 10.Seconds();
		var velocity = length / time;

		Assert.AreEqual(10.0.ToSignificantNumber(), velocity.MetersPerSecond<SignificantNumber>());
	}
}
