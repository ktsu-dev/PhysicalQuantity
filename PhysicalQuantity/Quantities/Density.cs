// Ignore Spelling: ktsu

namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.DensityConversions;

	namespace Generic
	{
		[SIUnit("kg/m³", "kilogram per cubic meter", "kilograms per cubic meter")]
		public record Density<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Density<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class DensityConversions
		{
			public static TStorage FromKilogramsPerCubicMeter<TStorage>(TStorage value)
			where TStorage : INumber<TStorage>
			=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToKilogramsPerCubicMeter<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromGramsPerCubicCentimeter<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1000, 0);
			public static TStorage ToGramsPerCubicCentimeter<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1000, 0);
			public static TStorage FromPoundsPerCubicFoot<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 16.0184634, 0);
			public static TStorage ToPoundsPerCubicFoot<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 16.0184634, 0);
			public static TStorage FromPoundsPerCubicInch<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 27679.9047, 0);
			public static TStorage ToPoundsPerCubicInch<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 27679.9047, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Density;
		using TStorage = float;
		public record Density : Density<TQuantity, TStorage>;

		namespace Conversions.Density
		{
			public static class Conversions
			{
				public static TQuantity KilogramsPerCubicMeter(this TStorage value) => TQuantity.Create(Convert.FromKilogramsPerCubicMeter(value));
				public static TStorage KilogramsPerCubicMeter(this TQuantity quantity) => Convert.ToKilogramsPerCubicMeter(quantity.Quantity);
				public static TQuantity GramsPerCubicCentimeter(this TStorage value) => TQuantity.Create(Convert.FromGramsPerCubicCentimeter(value));
				public static TStorage GramsPerCubicCentimeter(this TQuantity quantity) => Convert.ToGramsPerCubicCentimeter(quantity.Quantity);
				public static TQuantity PoundsPerCubicFoot(this TStorage value) => TQuantity.Create(Convert.FromPoundsPerCubicFoot(value));
				public static TStorage PoundsPerCubicFoot(this TQuantity quantity) => Convert.ToPoundsPerCubicFoot(quantity.Quantity);
				public static TQuantity PoundsPerCubicInch(this TStorage value) => TQuantity.Create(Convert.FromPoundsPerCubicInch(value));
				public static TStorage PoundsPerCubicInch(this TQuantity quantity) => Convert.ToPoundsPerCubicInch(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Density;
		using TStorage = double;
		public record Density : Density<TQuantity, TStorage>;

		namespace Conversions.Density
		{
			public static class Conversions
			{
				public static TQuantity KilogramsPerCubicMeter(this TStorage value) => TQuantity.Create(Convert.FromKilogramsPerCubicMeter(value));
				public static TStorage KilogramsPerCubicMeter(this TQuantity quantity) => Convert.ToKilogramsPerCubicMeter(quantity.Quantity);
				public static TQuantity GramsPerCubicCentimeter(this TStorage value) => TQuantity.Create(Convert.FromGramsPerCubicCentimeter(value));
				public static TStorage GramsPerCubicCentimeter(this TQuantity quantity) => Convert.ToGramsPerCubicCentimeter(quantity.Quantity);
				public static TQuantity PoundsPerCubicFoot(this TStorage value) => TQuantity.Create(Convert.FromPoundsPerCubicFoot(value));
				public static TStorage PoundsPerCubicFoot(this TQuantity quantity) => Convert.ToPoundsPerCubicFoot(quantity.Quantity);
				public static TQuantity PoundsPerCubicInch(this TStorage value) => TQuantity.Create(Convert.FromPoundsPerCubicInch(value));
				public static TStorage PoundsPerCubicInch(this TQuantity quantity) => Convert.ToPoundsPerCubicInch(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Density;
		using TStorage = decimal;
		public record Density : Density<TQuantity, TStorage>;

		namespace Conversions.Density
		{
			public static class Conversions
			{
				public static TQuantity KilogramsPerCubicMeter(this TStorage value) => TQuantity.Create(Convert.FromKilogramsPerCubicMeter(value));
				public static TStorage KilogramsPerCubicMeter(this TQuantity quantity) => Convert.ToKilogramsPerCubicMeter(quantity.Quantity);
				public static TQuantity GramsPerCubicCentimeter(this TStorage value) => TQuantity.Create(Convert.FromGramsPerCubicCentimeter(value));
				public static TStorage GramsPerCubicCentimeter(this TQuantity quantity) => Convert.ToGramsPerCubicCentimeter(quantity.Quantity);
				public static TQuantity PoundsPerCubicFoot(this TStorage value) => TQuantity.Create(Convert.FromPoundsPerCubicFoot(value));
				public static TStorage PoundsPerCubicFoot(this TQuantity quantity) => Convert.ToPoundsPerCubicFoot(quantity.Quantity);
				public static TQuantity PoundsPerCubicInch(this TStorage value) => TQuantity.Create(Convert.FromPoundsPerCubicInch(value));
				public static TStorage PoundsPerCubicInch(this TQuantity quantity) => Convert.ToPoundsPerCubicInch(quantity.Quantity);
			}
		}
	}

	namespace Significant
	{
		using Generic;
		using TQuantity = Density;
		using TStorage = SignificantNumber.SignificantNumber;
		public record Density : Density<TQuantity, TStorage>;

		namespace Conversions.Density
		{
			public static class Conversions
			{
				public static TQuantity KilogramsPerCubicMeter(this TStorage value) => TQuantity.Create(Convert.FromKilogramsPerCubicMeter(value));
				public static TStorage KilogramsPerCubicMeter(this TQuantity quantity) => Convert.ToKilogramsPerCubicMeter(quantity.Quantity);
				public static TQuantity GramsPerCubicCentimeter(this TStorage value) => TQuantity.Create(Convert.FromGramsPerCubicCentimeter(value));
				public static TStorage GramsPerCubicCentimeter(this TQuantity quantity) => Convert.ToGramsPerCubicCentimeter(quantity.Quantity);
				public static TQuantity PoundsPerCubicFoot(this TStorage value) => TQuantity.Create(Convert.FromPoundsPerCubicFoot(value));
				public static TStorage PoundsPerCubicFoot(this TQuantity quantity) => Convert.ToPoundsPerCubicFoot(quantity.Quantity);
				public static TQuantity PoundsPerCubicInch(this TStorage value) => TQuantity.Create(Convert.FromPoundsPerCubicInch(value));
				public static TStorage PoundsPerCubicInch(this TQuantity quantity) => Convert.ToPoundsPerCubicInch(quantity.Quantity);
			}
		}
	}
}
