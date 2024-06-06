namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.AreaConversions;

	namespace Generic
	{
		[SIUnit("m²", "square meter", "square meters")]
		public record Area<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Area<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class AreaConversions
		{
			public static TStorage FromSquareMeters<TStorage>(TStorage value)
			where TStorage : INumber<TStorage>
			=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToSquareMeters<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromSquareFeet<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.09290304, 0);
			public static TStorage ToSquareFeet<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.09290304, 0);
			public static TStorage FromSquareInches<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.00064516, 0);
			public static TStorage ToSquareInches<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.00064516, 0);
			public static TStorage FromSquareCentimeters<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.0001, 0);
			public static TStorage ToSquareCentimeters<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.0001, 0);
			public static TStorage FromSquareMillimeters<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.000001, 0);
			public static TStorage ToSquareMillimeters<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.000001, 0);
			public static TStorage FromHectares<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 10000, 0);
			public static TStorage ToHectares<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 10000, 0);
			public static TStorage FromAcres<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 4046.8564224, 0);
			public static TStorage ToAcres<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 4046.8564224, 0);
			public static TStorage FromSquareKilometers<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1000000, 0);
			public static TStorage ToSquareKilometers<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1000000, 0);
			public static TStorage FromSquareMiles<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 2589988.110336, 0);
			public static TStorage ToSquareMiles<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 2589988.110336, 0);
			public static TStorage FromSquareYards<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.83612736, 0);
			public static TStorage ToSquareYards<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.83612736, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Area;
		using TStorage = float;
		public record Area : Area<TQuantity, TStorage>;

		namespace Conversions.Area
		{
			public static class Conversions
			{
				public static TQuantity SquareMeters(this TStorage value) => TQuantity.Create(Convert.FromSquareMeters(value));
				public static TStorage SquareMeters(this TQuantity quantity) => Convert.ToSquareMeters(quantity.Quantity);
				public static TQuantity SquareFeet(this TStorage value) => TQuantity.Create(Convert.FromSquareFeet(value));
				public static TStorage SquareFeet(this TQuantity quantity) => Convert.ToSquareFeet(quantity.Quantity);
				public static TQuantity SquareInches(this TStorage value) => TQuantity.Create(Convert.FromSquareInches(value));
				public static TStorage SquareInches(this TQuantity quantity) => Convert.ToSquareInches(quantity.Quantity);
				public static TQuantity SquareCentimeters(this TStorage value) => TQuantity.Create(Convert.FromSquareCentimeters(value));
				public static TStorage SquareCentimeters(this TQuantity quantity) => Convert.ToSquareCentimeters(quantity.Quantity);
				public static TQuantity SquareMillimeters(this TStorage value) => TQuantity.Create(Convert.FromSquareMillimeters(value));
				public static TStorage SquareMillimeters(this TQuantity quantity) => Convert.ToSquareMillimeters(quantity.Quantity);
				public static TQuantity Hectares(this TStorage value) => TQuantity.Create(Convert.FromHectares(value));
				public static TStorage Hectares(this TQuantity quantity) => Convert.ToHectares(quantity.Quantity);
				public static TQuantity Acres(this TStorage value) => TQuantity.Create(Convert.FromAcres(value));
				public static TStorage Acres(this TQuantity quantity) => Convert.ToAcres(quantity.Quantity);
				public static TQuantity SquareKilometers(this TStorage value) => TQuantity.Create(Convert.FromSquareKilometers(value));
				public static TStorage SquareKilometers(this TQuantity quantity) => Convert.ToSquareKilometers(quantity.Quantity);
				public static TQuantity SquareMiles(this TStorage value) => TQuantity.Create(Convert.FromSquareMiles(value));
				public static TStorage SquareMiles(this TQuantity quantity) => Convert.ToSquareMiles(quantity.Quantity);
				public static TQuantity SquareYards(this TStorage value) => TQuantity.Create(Convert.FromSquareYards(value));
				public static TStorage SquareYards(this TQuantity quantity) => Convert.ToSquareYards(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Area;
		using TStorage = double;
		public record Area : Area<TQuantity, TStorage>;

		namespace Conversions.Area
		{
			public static class Conversions
			{
				public static TQuantity SquareMeters(this TStorage value) => TQuantity.Create(Convert.FromSquareMeters(value));
				public static TStorage SquareMeters(this TQuantity quantity) => Convert.ToSquareMeters(quantity.Quantity);
				public static TQuantity SquareFeet(this TStorage value) => TQuantity.Create(Convert.FromSquareFeet(value));
				public static TStorage SquareFeet(this TQuantity quantity) => Convert.ToSquareFeet(quantity.Quantity);
				public static TQuantity SquareInches(this TStorage value) => TQuantity.Create(Convert.FromSquareInches(value));
				public static TStorage SquareInches(this TQuantity quantity) => Convert.ToSquareInches(quantity.Quantity);
				public static TQuantity SquareCentimeters(this TStorage value) => TQuantity.Create(Convert.FromSquareCentimeters(value));
				public static TStorage SquareCentimeters(this TQuantity quantity) => Convert.ToSquareCentimeters(quantity.Quantity);
				public static TQuantity SquareMillimeters(this TStorage value) => TQuantity.Create(Convert.FromSquareMillimeters(value));
				public static TStorage SquareMillimeters(this TQuantity quantity) => Convert.ToSquareMillimeters(quantity.Quantity);
				public static TQuantity Hectares(this TStorage value) => TQuantity.Create(Convert.FromHectares(value));
				public static TStorage Hectares(this TQuantity quantity) => Convert.ToHectares(quantity.Quantity);
				public static TQuantity Acres(this TStorage value) => TQuantity.Create(Convert.FromAcres(value));
				public static TStorage Acres(this TQuantity quantity) => Convert.ToAcres(quantity.Quantity);
				public static TQuantity SquareKilometers(this TStorage value) => TQuantity.Create(Convert.FromSquareKilometers(value));
				public static TStorage SquareKilometers(this TQuantity quantity) => Convert.ToSquareKilometers(quantity.Quantity);
				public static TQuantity SquareMiles(this TStorage value) => TQuantity.Create(Convert.FromSquareMiles(value));
				public static TStorage SquareMiles(this TQuantity quantity) => Convert.ToSquareMiles(quantity.Quantity);
				public static TQuantity SquareYards(this TStorage value) => TQuantity.Create(Convert.FromSquareYards(value));
				public static TStorage SquareYards(this TQuantity quantity) => Convert.ToSquareYards(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Area;
		using TStorage = decimal;
		public record Area : Area<TQuantity, TStorage>;

		namespace Conversions.Area
		{
			public static class Conversions
			{
				public static TQuantity SquareMeters(this TStorage value) => TQuantity.Create(Convert.FromSquareMeters(value));
				public static TStorage SquareMeters(this TQuantity quantity) => Convert.ToSquareMeters(quantity.Quantity);
				public static TQuantity SquareFeet(this TStorage value) => TQuantity.Create(Convert.FromSquareFeet(value));
				public static TStorage SquareFeet(this TQuantity quantity) => Convert.ToSquareFeet(quantity.Quantity);
				public static TQuantity SquareInches(this TStorage value) => TQuantity.Create(Convert.FromSquareInches(value));
				public static TStorage SquareInches(this TQuantity quantity) => Convert.ToSquareInches(quantity.Quantity);
				public static TQuantity SquareCentimeters(this TStorage value) => TQuantity.Create(Convert.FromSquareCentimeters(value));
				public static TStorage SquareCentimeters(this TQuantity quantity) => Convert.ToSquareCentimeters(quantity.Quantity);
				public static TQuantity SquareMillimeters(this TStorage value) => TQuantity.Create(Convert.FromSquareMillimeters(value));
				public static TStorage SquareMillimeters(this TQuantity quantity) => Convert.ToSquareMillimeters(quantity.Quantity);
				public static TQuantity Hectares(this TStorage value) => TQuantity.Create(Convert.FromHectares(value));
				public static TStorage Hectares(this TQuantity quantity) => Convert.ToHectares(quantity.Quantity);
				public static TQuantity Acres(this TStorage value) => TQuantity.Create(Convert.FromAcres(value));
				public static TStorage Acres(this TQuantity quantity) => Convert.ToAcres(quantity.Quantity);
				public static TQuantity SquareKilometers(this TStorage value) => TQuantity.Create(Convert.FromSquareKilometers(value));
				public static TStorage SquareKilometers(this TQuantity quantity) => Convert.ToSquareKilometers(quantity.Quantity);
				public static TQuantity SquareMiles(this TStorage value) => TQuantity.Create(Convert.FromSquareMiles(value));
				public static TStorage SquareMiles(this TQuantity quantity) => Convert.ToSquareMiles(quantity.Quantity);
				public static TQuantity SquareYards(this TStorage value) => TQuantity.Create(Convert.FromSquareYards(value));
				public static TStorage SquareYards(this TQuantity quantity) => Convert.ToSquareYards(quantity.Quantity);
			}
		}
	}
}
