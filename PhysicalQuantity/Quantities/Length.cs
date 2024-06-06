namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.LengthConversions;

	namespace Generic
	{
		[SIUnit("m", "meter", "meters")]
		public record Length<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Length<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class LengthConversions
		{
			public static TStorage FromMeters<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToMeters<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromFeet<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.3048, 0);
			public static TStorage ToFeet<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.3048, 0);
			public static TStorage FromInches<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.0254, 0);
			public static TStorage ToInches<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.0254, 0);
			public static TStorage FromYards<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.9144, 0);
			public static TStorage ToYards<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.9144, 0);
			public static TStorage FromMiles<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1609.344, 0);
			public static TStorage ToMiles<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1609.344, 0);
			public static TStorage FromKilometers<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1000, 0);
			public static TStorage ToKilometers<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1000, 0);
			public static TStorage FromCentimeters<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.01, 0);
			public static TStorage ToCentimeters<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.01, 0);
			public static TStorage FromMillimeters<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.001, 0);
			public static TStorage ToMillimeters<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.001, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Length;
		using TStorage = float;
		public record Length : Length<TQuantity, TStorage>;

		namespace Conversions.Length
		{
			public static class Conversions
			{
				public static TQuantity Meters(this TStorage value) => TQuantity.Create(Convert.FromMeters(value));
				public static TStorage Meters(this TQuantity quantity) => Convert.ToMeters(quantity.Quantity);
				public static TQuantity Feet(this TStorage value) => TQuantity.Create(Convert.FromFeet(value));
				public static TStorage Feet(this TQuantity quantity) => Convert.ToFeet(quantity.Quantity);
				public static TQuantity Inches(this TStorage value) => TQuantity.Create(Convert.FromInches(value));
				public static TStorage Inches(this TQuantity quantity) => Convert.ToInches(quantity.Quantity);
				public static TQuantity Yards(this TStorage value) => TQuantity.Create(Convert.FromYards(value));
				public static TStorage Yards(this TQuantity quantity) => Convert.ToYards(quantity.Quantity);
				public static TQuantity Miles(this TStorage value) => TQuantity.Create(Convert.FromMiles(value));
				public static TStorage Miles(this TQuantity quantity) => Convert.ToMiles(quantity.Quantity);
				public static TQuantity Kilometers(this TStorage value) => TQuantity.Create(Convert.FromKilometers(value));
				public static TStorage Kilometers(this TQuantity quantity) => Convert.ToKilometers(quantity.Quantity);
				public static TQuantity Centimeters(this TStorage value) => TQuantity.Create(Convert.FromCentimeters(value));
				public static TStorage Centimeters(this TQuantity quantity) => Convert.ToCentimeters(quantity.Quantity);
				public static TQuantity Millimeters(this TStorage value) => TQuantity.Create(Convert.FromMillimeters(value));
				public static TStorage Millimeters(this TQuantity quantity) => Convert.ToMillimeters(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Length;
		using TStorage = double;
		public record Length : Length<TQuantity, TStorage>;

		namespace Conversions.Length
		{
			public static class Conversions
			{
				public static TQuantity Meters(this TStorage value) => TQuantity.Create(Convert.FromMeters(value));
				public static TStorage Meters(this TQuantity quantity) => Convert.ToMeters(quantity.Quantity);
				public static TQuantity Feet(this TStorage value) => TQuantity.Create(Convert.FromFeet(value));
				public static TStorage Feet(this TQuantity quantity) => Convert.ToFeet(quantity.Quantity);
				public static TQuantity Inches(this TStorage value) => TQuantity.Create(Convert.FromInches(value));
				public static TStorage Inches(this TQuantity quantity) => Convert.ToInches(quantity.Quantity);
				public static TQuantity Yards(this TStorage value) => TQuantity.Create(Convert.FromYards(value));
				public static TStorage Yards(this TQuantity quantity) => Convert.ToYards(quantity.Quantity);
				public static TQuantity Miles(this TStorage value) => TQuantity.Create(Convert.FromMiles(value));
				public static TStorage Miles(this TQuantity quantity) => Convert.ToMiles(quantity.Quantity);
				public static TQuantity Kilometers(this TStorage value) => TQuantity.Create(Convert.FromKilometers(value));
				public static TStorage Kilometers(this TQuantity quantity) => Convert.ToKilometers(quantity.Quantity);
				public static TQuantity Centimeters(this TStorage value) => TQuantity.Create(Convert.FromCentimeters(value));
				public static TStorage Centimeters(this TQuantity quantity) => Convert.ToCentimeters(quantity.Quantity);
				public static TQuantity Millimeters(this TStorage value) => TQuantity.Create(Convert.FromMillimeters(value));
				public static TStorage Millimeters(this TQuantity quantity) => Convert.ToMillimeters(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Length;
		using TStorage = decimal;
		public record Length : Length<TQuantity, TStorage>;

		namespace Conversions.Length
		{
			public static class Conversions
			{
				public static TQuantity Meters(this TStorage value) => TQuantity.Create(Convert.FromMeters(value));
				public static TStorage Meters(this TQuantity quantity) => Convert.ToMeters(quantity.Quantity);
				public static TQuantity Feet(this TStorage value) => TQuantity.Create(Convert.FromFeet(value));
				public static TStorage Feet(this TQuantity quantity) => Convert.ToFeet(quantity.Quantity);
				public static TQuantity Inches(this TStorage value) => TQuantity.Create(Convert.FromInches(value));
				public static TStorage Inches(this TQuantity quantity) => Convert.ToInches(quantity.Quantity);
				public static TQuantity Yards(this TStorage value) => TQuantity.Create(Convert.FromYards(value));
				public static TStorage Yards(this TQuantity quantity) => Convert.ToYards(quantity.Quantity);
				public static TQuantity Miles(this TStorage value) => TQuantity.Create(Convert.FromMiles(value));
				public static TStorage Miles(this TQuantity quantity) => Convert.ToMiles(quantity.Quantity);
				public static TQuantity Kilometers(this TStorage value) => TQuantity.Create(Convert.FromKilometers(value));
				public static TStorage Kilometers(this TQuantity quantity) => Convert.ToKilometers(quantity.Quantity);
				public static TQuantity Centimeters(this TStorage value) => TQuantity.Create(Convert.FromCentimeters(value));
				public static TStorage Centimeters(this TQuantity quantity) => Convert.ToCentimeters(quantity.Quantity);
				public static TQuantity Millimeters(this TStorage value) => TQuantity.Create(Convert.FromMillimeters(value));
				public static TStorage Millimeters(this TQuantity quantity) => Convert.ToMillimeters(quantity.Quantity);
			}
		}
	}
}
