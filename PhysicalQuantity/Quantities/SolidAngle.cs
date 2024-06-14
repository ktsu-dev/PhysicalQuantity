namespace ktsu.io.PhysicalQuantity.SolidAngle;

using System.Numerics;
using ktsu.io.PhysicalQuantity.Generic;
using ktsu.io.PhysicalQuantity.LuminousFlux;
using ktsu.io.PhysicalQuantity.LuminousIntensity;

[SIUnit("sr", "steradian", "steradians")]
public sealed record SolidAngle
	: PhysicalQuantity<SolidAngle>
	, IIntegralOperators<SolidAngle, LuminousIntensity, LuminousFlux>
{
	public static LuminousFlux operator *(SolidAngle left, LuminousIntensity right) =>
		IIntegralOperators<SolidAngle, LuminousIntensity, LuminousFlux>.Integrate(left, right);
}

public static class SolidAngleConversions
{
	public static SolidAngle Steradians<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, SolidAngle>();

	public static TNumber Steradians<TNumber>(this SolidAngle value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	public static SolidAngle SquareDegrees<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, SolidAngle>(Constants.SquareDegreesToSteradiansFactor);

	public static TNumber SquareDegrees<TNumber>(this SolidAngle value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.SquareDegreesToSteradiansFactor).To<TNumber>();
}
