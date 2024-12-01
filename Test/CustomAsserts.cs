namespace ktsu.PhysicalQuantity.Test;
using System.Numerics;

using ktsu.SignificantNumber;

internal static class CustomAsserts
{
	public static void AreSignificantlyEqual<T1, T2>(T1 expected, T2 actual)
			where T1 : INumber<T1>
			where T2 : INumber<T2>
	{
		Assert.AreEqual(expected.ToSignificantNumber(), actual.ToSignificantNumber());
	}

	public static void AreSignificantlyUnequal<T1, T2>(T1 expected, T2 actual)
			where T1 : INumber<T1>
			where T2 : INumber<T2>
	{
		Assert.AreNotEqual(expected.ToSignificantNumber(), actual.ToSignificantNumber());
	}
}
