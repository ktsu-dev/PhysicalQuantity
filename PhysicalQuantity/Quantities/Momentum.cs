namespace ktsu.PhysicalQuantity.Momentum;

using System.Numerics;
using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Mass;
using ktsu.PhysicalQuantity.Velocity;

[SIUnit("kg·m/s", "kilogram meter per second", "kilogram meters per second")]
public sealed record Momentum
	: PhysicalQuantity<Momentum>
	, IIntegralOperators<Momentum, Velocity, Force>
	, IDerivativeOperators<Momentum, Velocity, Mass>
{
	public static Force operator *(Momentum left, Velocity right) =>
		IIntegralOperators<Momentum, Velocity, Force>.Integrate(left, right);

	public static Mass operator /(Momentum left, Velocity right) =>
		IDerivativeOperators<Momentum, Velocity, Mass>.Derive(left, right);
}

public static class MomentumConversions
{
	public static Momentum KilogramMetersPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Momentum>();

	public static TNumber KilogramMetersPerSecond<TNumber>(this Momentum value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	public static Momentum GramMetersPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Momentum>(Constants.Milli);

	public static TNumber GramMetersPerSecond<TNumber>(this Momentum value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	public static Momentum MilligramMetersPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Momentum>(Constants.Micro);

	public static TNumber MilligramMetersPerSecond<TNumber>(this Momentum value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();
}
