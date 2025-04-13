namespace ktsu.PhysicalQuantity.AngularMomentum;

using System.Numerics;

using ktsu.PhysicalQuantity.AngularVelocity;
using ktsu.PhysicalQuantity.Force;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.MomentOfInertia;

/// <summary>
/// Represents the angular momentum, a measure of the rotational motion of an object.
/// </summary>
[SIUnit("kg·m²/s", "kilogram square meter per second", "kilogram square meters per second")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record AngularMomentum
	: PhysicalQuantity<AngularMomentum>
	, IIntegralOperators<AngularMomentum, AngularVelocity, Force>
	, IDerivativeOperators<AngularMomentum, AngularVelocity, MomentOfInertia>
{
	/// <summary>
	/// Multiplies an <see cref="AngularMomentum"/> instance by an <see cref="AngularVelocity"/> instance
	/// to compute the resulting <see cref="Force"/>.
	/// </summary>
	/// <param name="left">The angular momentum.</param>
	/// <param name="right">The angular velocity.</param>
	/// <returns>The resulting force.</returns>
	public static Force operator *(AngularMomentum left, AngularVelocity right) =>
		IIntegralOperators<AngularMomentum, AngularVelocity, Force>.Integrate(left, right);

	/// <summary>
	/// Divides an <see cref="AngularMomentum"/> instance by an <see cref="AngularVelocity"/> instance
	/// to compute the resulting <see cref="MomentOfInertia"/>.
	/// </summary>
	/// <param name="left">The angular momentum.</param>
	/// <param name="right">The angular velocity.</param>
	/// <returns>The resulting moment of inertia.</returns>
	public static MomentOfInertia operator /(AngularMomentum left, AngularVelocity right) =>
		IDerivativeOperators<AngularMomentum, AngularVelocity, MomentOfInertia>.Derive(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="AngularMomentum"/>.
/// </summary>
public static class AngularMomentumConversions
{
	/// <summary>
	/// Converts a numeric value to an <see cref="AngularMomentum"/> in kilogram square meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>The resulting angular momentum.</returns>
	public static AngularMomentum KilogramSquareMetersPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularMomentum>();

	/// <summary>
	/// Converts an <see cref="AngularMomentum"/> to a numeric value in kilogram square meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The angular momentum to convert.</param>
	/// <returns>The numeric value representing the angular momentum.</returns>
	public static TNumber KilogramSquareMetersPerSecond<TNumber>(this AngularMomentum value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to an <see cref="AngularMomentum"/> in gram square meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>The resulting angular momentum.</returns>
	public static AngularMomentum GramSquareMetersPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularMomentum>(Constants.Milli);

	/// <summary>
	/// Converts an <see cref="AngularMomentum"/> to a numeric value in gram square meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The angular momentum to convert.</param>
	/// <returns>The numeric value representing the angular momentum.</returns>
	public static TNumber GramSquareMetersPerSecond<TNumber>(this AngularMomentum value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to an <see cref="AngularMomentum"/> in milligram square meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>The resulting angular momentum.</returns>
	public static AngularMomentum MilligramSquareMetersPerSecond<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, AngularMomentum>(Constants.Micro);

	/// <summary>
	/// Converts an <see cref="AngularMomentum"/> to a numeric value in milligram square meters per second.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The angular momentum to convert.</param>
	/// <returns>The numeric value representing the angular momentum.</returns>
	public static TNumber MilligramSquareMetersPerSecond<TNumber>(this AngularMomentum value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();
}
