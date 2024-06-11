// Ignore Spelling: ktsu

namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.VolumeConversions;

	namespace Generic
	{
		[SIUnit("m³", "cubic meter", "cubic meters")]
		public record Volume<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Volume<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class VolumeConversions
		{
			public static TStorage FromCubicMeters<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToCubicMeters<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromLiters<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.001, 0);
			public static TStorage ToLiters<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.001, 0);
			public static TStorage FromMilliliters<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1E-6, 0);
			public static TStorage ToMilliliters<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1E-6, 0);
			public static TStorage FromCubicInches<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.000016387064, 0);
			public static TStorage ToCubicInches<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.000016387064, 0);
			public static TStorage FromCubicFeet<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.028316846592, 0);
			public static TStorage ToCubicFeet<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.028316846592, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Volume;
		using TStorage = float;
		public record Volume : Volume<TQuantity, TStorage>;

		namespace Conversions.Volume
		{
			public static class Conversions
			{
				public static TQuantity CubicMeters(this TStorage value) => TQuantity.Create(Convert.FromCubicMeters(value));
				public static TStorage CubicMeters(this TQuantity quantity) => Convert.ToCubicMeters(quantity.Quantity);
				public static TQuantity Liters(this TStorage value) => TQuantity.Create(Convert.FromLiters(value));
				public static TStorage Liters(this TQuantity quantity) => Convert.ToLiters(quantity.Quantity);
				public static TQuantity Milliliters(this TStorage value) => TQuantity.Create(Convert.FromMilliliters(value));
				public static TStorage Milliliters(this TQuantity quantity) => Convert.ToMilliliters(quantity.Quantity);
				public static TQuantity CubicInches(this TStorage value) => TQuantity.Create(Convert.FromCubicInches(value));
				public static TStorage CubicInches(this TQuantity quantity) => Convert.ToCubicInches(quantity.Quantity);
				public static TQuantity CubicFeet(this TStorage value) => TQuantity.Create(Convert.FromCubicFeet(value));
				public static TStorage CubicFeet(this TQuantity quantity) => Convert.ToCubicFeet(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Volume;
		using TStorage = double;
		public record Volume : Volume<TQuantity, TStorage>;

		namespace Conversions.Volume
		{
			public static class Conversions
			{
				public static TQuantity CubicMeters(this TStorage value) => TQuantity.Create(Convert.FromCubicMeters(value));
				public static TStorage CubicMeters(this TQuantity quantity) => Convert.ToCubicMeters(quantity.Quantity);
				public static TQuantity Liters(this TStorage value) => TQuantity.Create(Convert.FromLiters(value));
				public static TStorage Liters(this TQuantity quantity) => Convert.ToLiters(quantity.Quantity);
				public static TQuantity Milliliters(this TStorage value) => TQuantity.Create(Convert.FromMilliliters(value));
				public static TStorage Milliliters(this TQuantity quantity) => Convert.ToMilliliters(quantity.Quantity);
				public static TQuantity CubicInches(this TStorage value) => TQuantity.Create(Convert.FromCubicInches(value));
				public static TStorage CubicInches(this TQuantity quantity) => Convert.ToCubicInches(quantity.Quantity);
				public static TQuantity CubicFeet(this TStorage value) => TQuantity.Create(Convert.FromCubicFeet(value));
				public static TStorage CubicFeet(this TQuantity quantity) => Convert.ToCubicFeet(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Volume;
		using TStorage = decimal;
		public record Volume : Volume<TQuantity, TStorage>;

		namespace Conversions.Volume
		{
			public static class Conversions
			{
				public static TQuantity CubicMeters(this TStorage value) => TQuantity.Create(Convert.FromCubicMeters(value));
				public static TStorage CubicMeters(this TQuantity quantity) => Convert.ToCubicMeters(quantity.Quantity);
				public static TQuantity Liters(this TStorage value) => TQuantity.Create(Convert.FromLiters(value));
				public static TStorage Liters(this TQuantity quantity) => Convert.ToLiters(quantity.Quantity);
				public static TQuantity Milliliters(this TStorage value) => TQuantity.Create(Convert.FromMilliliters(value));
				public static TStorage Milliliters(this TQuantity quantity) => Convert.ToMilliliters(quantity.Quantity);
				public static TQuantity CubicInches(this TStorage value) => TQuantity.Create(Convert.FromCubicInches(value));
				public static TStorage CubicInches(this TQuantity quantity) => Convert.ToCubicInches(quantity.Quantity);
				public static TQuantity CubicFeet(this TStorage value) => TQuantity.Create(Convert.FromCubicFeet(value));
				public static TStorage CubicFeet(this TQuantity quantity) => Convert.ToCubicFeet(quantity.Quantity);
			}
		}
	}

	namespace Significant
	{
		using Generic;
		using TQuantity = Volume;
		using TStorage = SignificantNumber.SignificantNumber;
		public record Volume : Volume<TQuantity, TStorage>;

		namespace Conversions.Volume
		{
			public static class Conversions
			{
				public static TQuantity CubicMeters(this TStorage value) => TQuantity.Create(Convert.FromCubicMeters(value));
				public static TStorage CubicMeters(this TQuantity quantity) => Convert.ToCubicMeters(quantity.Quantity);
				public static TQuantity Liters(this TStorage value) => TQuantity.Create(Convert.FromLiters(value));
				public static TStorage Liters(this TQuantity quantity) => Convert.ToLiters(quantity.Quantity);
				public static TQuantity Milliliters(this TStorage value) => TQuantity.Create(Convert.FromMilliliters(value));
				public static TStorage Milliliters(this TQuantity quantity) => Convert.ToMilliliters(quantity.Quantity);
				public static TQuantity CubicInches(this TStorage value) => TQuantity.Create(Convert.FromCubicInches(value));
				public static TStorage CubicInches(this TQuantity quantity) => Convert.ToCubicInches(quantity.Quantity);
				public static TQuantity CubicFeet(this TStorage value) => TQuantity.Create(Convert.FromCubicFeet(value));
				public static TStorage CubicFeet(this TQuantity quantity) => Convert.ToCubicFeet(quantity.Quantity);
			}
		}
	}
}
