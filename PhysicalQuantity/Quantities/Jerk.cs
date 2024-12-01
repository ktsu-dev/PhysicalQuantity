namespace ktsu.PhysicalQuantity.Jerk;

using System.Numerics;
using ktsu.PhysicalQuantity.Acceleration;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Time;

[SIUnit("m/s³", "meter per second cubed", "meters per second cubed")]
public sealed record Jerk
	: PhysicalQuantity<Jerk>
	, IIntegralOperators<Jerk, Time, Acceleration>
{
	public static Acceleration operator *(Jerk left, Time right) =>
		IIntegralOperators<Jerk, Time, Acceleration>.Integrate(left, right);

}

public static class JerkConversions
{
	// Base unit: Meters per second cubed
	public static Jerk MetersPerSecondCubed<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Jerk>();

	public static TNumber MetersPerSecondCubed<TNumber>(this Jerk value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	// Feet per second cubed
	public static Jerk FeetPerSecondCubed<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Jerk>(Constants.FeetToMetersFactor);

	public static TNumber FeetPerSecondCubed<TNumber>(this Jerk value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.FeetToMetersFactor).To<TNumber>();

	// Inches per second cubed
	public static Jerk InchesPerSecondCubed<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Jerk>(Constants.InchesToMetersFactor);

	public static TNumber InchesPerSecondCubed<TNumber>(this Jerk value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.InchesToMetersFactor).To<TNumber>();

	// Yards per second cubed
	public static Jerk YardsPerSecondCubed<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Jerk>(Constants.YardsToMetersFactor);

	public static TNumber YardsPerSecondCubed<TNumber>(this Jerk value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.YardsToMetersFactor).To<TNumber>();

	// Miles per second cubed
	public static Jerk MilesPerSecondCubed<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Jerk>(Constants.MilesToMetersFactor);

	public static TNumber MilesPerSecondCubed<TNumber>(this Jerk value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.MilesToMetersFactor).To<TNumber>();
}
