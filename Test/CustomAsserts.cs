namespace ktsu.io.PhysicalQuantity.Test;
using System.Numerics;

internal static class CustomAsserts
{
	public static void AreSignificantlyEqual<T1, T2>(T1 expected, T2 actual)
			where T1 : INumber<T1>
			where T2 : INumber<T2>
	{
		if (!Precision.SignificantlyEquals(expected, actual))
		{
			throw new AssertFailedException($"{nameof(CustomAsserts)}.{nameof(AreSignificantlyEqual)} Expected:<{expected}>. Actual<{actual}>.");
		}
	}

	public static void AreSignificantlyUnequal<T1, T2>(T1 expected, T2 actual)
			where T1 : INumber<T1>
			where T2 : INumber<T2>
	{
		if (Precision.SignificantlyEquals(expected, actual))
		{
			throw new AssertFailedException($"{nameof(CustomAsserts)}.{nameof(AreSignificantlyEqual)} Expected:<{expected}>. Actual<{actual}>.");
		}
	}
}
