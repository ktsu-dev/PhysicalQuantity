namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.MassConversions;

	namespace Generic
	{
		[SIUnit("kg", "kilogram", "kilograms")]
		public record Mass<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Mass<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class MassConversions
		{
			public static TStorage FromKilograms<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToKilograms<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromGrams<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.001, 0);
			public static TStorage ToGrams<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.001, 0);
			public static TStorage FromPounds<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.45359237, 0);
			public static TStorage ToPounds<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.45359237, 0);
			public static TStorage FromOunces<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.0283495231, 0);
			public static TStorage ToOunces<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.0283495231, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Mass;
		using TStorage = float;
		public record Mass : Mass<TQuantity, TStorage>;

		namespace Conversions.Mass
		{
			public static class Conversions
			{
				public static TQuantity Kilograms(this TStorage value) => TQuantity.Create(Convert.FromKilograms(value));
				public static TStorage Kilograms(this TQuantity quantity) => Convert.ToKilograms(quantity.Quantity);
				public static TQuantity Grams(this TStorage value) => TQuantity.Create(Convert.FromGrams(value));
				public static TStorage Grams(this TQuantity quantity) => Convert.ToGrams(quantity.Quantity);
				public static TQuantity Pounds(this TStorage value) => TQuantity.Create(Convert.FromPounds(value));
				public static TStorage Pounds(this TQuantity quantity) => Convert.ToPounds(quantity.Quantity);
				public static TQuantity Ounces(this TStorage value) => TQuantity.Create(Convert.FromOunces(value));
				public static TStorage Ounces(this TQuantity quantity) => Convert.ToOunces(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Mass;
		using TStorage = double;
		public record Mass : Mass<TQuantity, TStorage>;

		namespace Conversions.Mass
		{
			public static class Conversions
			{
				public static TQuantity Kilograms(this TStorage value) => TQuantity.Create(Convert.FromKilograms(value));
				public static TStorage Kilograms(this TQuantity quantity) => Convert.ToKilograms(quantity.Quantity);
				public static TQuantity Grams(this TStorage value) => TQuantity.Create(Convert.FromGrams(value));
				public static TStorage Grams(this TQuantity quantity) => Convert.ToGrams(quantity.Quantity);
				public static TQuantity Pounds(this TStorage value) => TQuantity.Create(Convert.FromPounds(value));
				public static TStorage Pounds(this TQuantity quantity) => Convert.ToPounds(quantity.Quantity);
				public static TQuantity Ounces(this TStorage value) => TQuantity.Create(Convert.FromOunces(value));
				public static TStorage Ounces(this TQuantity quantity) => Convert.ToOunces(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Mass;
		using TStorage = decimal;
		public record Mass : Mass<TQuantity, TStorage>;

		namespace Conversions.Mass
		{
			public static class Conversions
			{
				public static TQuantity Kilograms(this TStorage value) => TQuantity.Create(Convert.FromKilograms(value));
				public static TStorage Kilograms(this TQuantity quantity) => Convert.ToKilograms(quantity.Quantity);
				public static TQuantity Grams(this TStorage value) => TQuantity.Create(Convert.FromGrams(value));
				public static TStorage Grams(this TQuantity quantity) => Convert.ToGrams(quantity.Quantity);
				public static TQuantity Pounds(this TStorage value) => TQuantity.Create(Convert.FromPounds(value));
				public static TStorage Pounds(this TQuantity quantity) => Convert.ToPounds(quantity.Quantity);
				public static TQuantity Ounces(this TStorage value) => TQuantity.Create(Convert.FromOunces(value));
				public static TStorage Ounces(this TQuantity quantity) => Convert.ToOunces(quantity.Quantity);
			}
		}
	}
}
