namespace ktsu.PhysicalQuantity.MomentOfInertia;

using System.Numerics;

using ktsu.PhysicalQuantity.AngularMomentum;
using ktsu.PhysicalQuantity.AngularVelocity;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Mass;

/// <summary>
/// Represents the moment of inertia, a measure of an object's resistance to changes in its rotation.
/// </summary>
[SIUnit("kg·m²", "kilogram square meter", "kilogram square meters")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record MomentOfInertia
	: PhysicalQuantity<MomentOfInertia>
	, IIntegralOperators<MomentOfInertia, AngularVelocity, AngularMomentum>
{
	/// <summary>
	/// Multiplies a <see cref="MomentOfInertia"/> by an <see cref="AngularVelocity"/> to calculate the <see cref="AngularMomentum"/>.
	/// </summary>
	/// <param name="left">The moment of inertia.</param>
	/// <param name="right">The angular velocity.</param>
	/// <returns>The resulting angular momentum.</returns>
	public static AngularMomentum operator *(MomentOfInertia left, AngularVelocity right) =>
		IIntegralOperators<MomentOfInertia, AngularVelocity, AngularMomentum>.Integrate(left, right);

	/// <summary>
	/// Creates a <see cref="MomentOfInertia"/> from a given mass and radius.
	/// </summary>
	/// <param name="mass">The mass of the object.</param>
	/// <param name="radius">The radius of rotation.</param>
	/// <returns>A new instance of <see cref="MomentOfInertia"/>.</returns>
	public static MomentOfInertia FromMassAndRadius(Mass mass, Length radius)
	{
		ArgumentNullException.ThrowIfNull(mass);
		ArgumentNullException.ThrowIfNull(radius);
		return Create(mass.Quantity * radius.Quantity.Squared());
	}
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="MomentOfInertia"/>.
/// </summary>
public static class MomentOfInertiaConversions
{
	/// <summary>
	/// Converts a numeric value to a <see cref="MomentOfInertia"/> in kilogram square meters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A new instance of <see cref="MomentOfInertia"/>.</returns>
	public static MomentOfInertia KilogramSquareMeters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, MomentOfInertia>();

	/// <summary>
	/// Converts a <see cref="MomentOfInertia"/> to a numeric value in kilogram square meters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The moment of inertia to convert.</param>
	/// <returns>The numeric value in kilogram square meters.</returns>
	public static TNumber KilogramSquareMeters<TNumber>(this MomentOfInertia value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to a <see cref="MomentOfInertia"/> in gram square meters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A new instance of <see cref="MomentOfInertia"/>.</returns>
	public static MomentOfInertia GramSquareMeters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, MomentOfInertia>(Constants.Milli);

	/// <summary>
	/// Converts a <see cref="MomentOfInertia"/> to a numeric value in gram square meters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The moment of inertia to convert.</param>
	/// <returns>The numeric value in gram square meters.</returns>
	public static TNumber GramSquareMeters<TNumber>(this MomentOfInertia value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Milli).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to a <see cref="MomentOfInertia"/> in milligram square meters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The numeric value to convert.</param>
	/// <returns>A new instance of <see cref="MomentOfInertia"/>.</returns>
	public static MomentOfInertia MilligramSquareMeters<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, MomentOfInertia>(Constants.Micro);

	/// <summary>
	/// Converts a <see cref="MomentOfInertia"/> to a numeric value in milligram square meters.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The moment of inertia to convert.</param>
	/// <returns>The numeric value in milligram square meters.</returns>
	public static TNumber MilligramSquareMeters<TNumber>(this MomentOfInertia value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.Micro).To<TNumber>();
}
