namespace ktsu.io.PhysicalQuantity;
using System;
using System.Globalization;
using System.Numerics;

public static class Precision
{
	public static bool SignificantlyEquals<T1, T2>(T1 a, T2 b)
		where T1 : INumber<T1>
		where T2 : INumber<T2>
	{
		string aStr = a.ToString("e14", CultureInfo.InvariantCulture);
		string bStr = b.ToString("e14", CultureInfo.InvariantCulture);
		int eIndexA = aStr.IndexOf('e');
		int eIndexB = bStr.IndexOf('e');
		string aExponent = aStr[eIndexA..];
		string bExponent = bStr[eIndexB..];

		var aMantissa = aStr.AsSpan(0, eIndexA);
		var bMantissa = bStr.AsSpan(0, eIndexB);

		while (aMantissa.Length > 1 && aMantissa[^1] == '0')
		{
			aMantissa = aMantissa[..^1];
		}

		while (bMantissa.Length > 1 && bMantissa[^1] == '0')
		{
			bMantissa = bMantissa[..^1];
		}

		int longestMantissaLength = Math.Max(aMantissa.Length, bMantissa.Length);
		int shortestMantissaLength = Math.Min(aMantissa.Length, bMantissa.Length);
		int checkedMantissaLength = Math.Clamp(shortestMantissaLength <= 2 ? longestMantissaLength - 1 : shortestMantissaLength, 3, 17);

		int decimalPlaces = checkedMantissaLength - 2; // remove leading zero and decimal point
		double aMantissaDouble = double.Parse(aMantissa, CultureInfo.InvariantCulture);
		double bMantissaDouble = double.Parse(bMantissa, CultureInfo.InvariantCulture);
		double aMantissaRounded = Math.Round(aMantissaDouble, decimalPlaces);
		double bMantissaRounded = Math.Round(bMantissaDouble, decimalPlaces);
		double epsilon = Math.Pow(10, -decimalPlaces);
		double difference = aExponent != bExponent
			? Math.Max(Math.Abs(double.CreateTruncating(a - T1.CreateTruncating(b))), Math.Abs(double.CreateTruncating(T2.CreateTruncating(a) - b)))
			: Math.Abs(aMantissaRounded - bMantissaRounded);
		double roundedDifference = Math.Round(difference, decimalPlaces);
		return roundedDifference <= epsilon;
	}
}
