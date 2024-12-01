namespace ktsu.PhysicalQuantity.MomentOfInertia;

using System.Numerics;
using ktsu.PhysicalQuantity.AngularMomentum;
using ktsu.PhysicalQuantity.AngularVelocity;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Mass;

[SIUnit("kg·m²", "kilogram square meter", "kilogram square meters")]
public sealed record MomentOfInertia
	: PhysicalQuantity<MomentOfInertia>
	, IIntegralOperators<MomentOfInertia, AngularVelocity, AngularMomentum>
{
	public static AngularMomentum operator *(MomentOfInertia left, AngularVelocity right) =>
		IIntegralOperators<MomentOfInertia, AngularVelocity, AngularMomentum>.Integrate(left, right);

	public static MomentOfInertia FromMassAndRadius(Mass mass, Length radius) =>
		Create(mass.Quantity * radius.Quantity.Squared());
}

public static class MomentOfInertiaConversions
{
	public static MomentOfInertia KilogramSquareMeters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, MomentOfInertia>();

	public static TNumber KilogramSquareMeters<TNumber>(this MomentOfInertia value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	public static MomentOfInertia GramSquareMeters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, MomentOfInertia>(Constants.Milli);

	public static TNumber GramSquareMeters<TNumber>(this MomentOfInertia value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	public static MomentOfInertia MilligramSquareMeters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, MomentOfInertia>(Constants.Micro);

	public static TNumber MilligramSquareMeters<TNumber>(this MomentOfInertia value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();
}
