namespace ktsu.PhysicalQuantity.AngularMomentum;

using System.Numerics;
using ktsu.PhysicalQuantity.AngularVelocity;
using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.MomentOfInertia;

[SIUnit("kg·m²/s", "kilogram square meter per second", "kilogram square meters per second")]
public sealed record AngularMomentum
	: PhysicalQuantity<AngularMomentum>
	, IIntegralOperators<AngularMomentum, AngularVelocity, Force>
	, IDerivativeOperators<AngularMomentum, AngularVelocity, MomentOfInertia>
{
	public static Force operator *(AngularMomentum left, AngularVelocity right) =>
		IIntegralOperators<AngularMomentum, AngularVelocity, Force>.Integrate(left, right);

	public static MomentOfInertia operator /(AngularMomentum left, AngularVelocity right) =>
		IDerivativeOperators<AngularMomentum, AngularVelocity, MomentOfInertia>.Derive(left, right);
}

public static class AngularMomentumConversions
{
	public static AngularMomentum KilogramSquareMetersPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularMomentum>();

	public static TNumber KilogramSquareMetersPerSecond<TNumber>(this AngularMomentum value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	public static AngularMomentum GramSquareMetersPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularMomentum>(Constants.Milli);

	public static TNumber GramSquareMetersPerSecond<TNumber>(this AngularMomentum value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	public static AngularMomentum MilligramSquareMetersPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularMomentum>(Constants.Micro);

	public static TNumber MilligramSquareMetersPerSecond<TNumber>(this AngularMomentum value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();
}
