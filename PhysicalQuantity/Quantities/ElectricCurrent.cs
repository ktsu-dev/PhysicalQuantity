namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.ElectricCurrentConversions;

	namespace Generic
	{
		[SIUnit("A", "ampere", "amperes")]
		public record ElectricCurrent<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : ElectricCurrent<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class ElectricCurrentConversions
		{
			public static TStorage FromAmperes<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToAmperes<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromMilliamperes<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1e-3, 0);
			public static TStorage ToMilliamperes<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1e-3, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = ElectricCurrent;
		using TStorage = float;
		public record ElectricCurrent : ElectricCurrent<TQuantity, TStorage>;

		namespace Conversions.ElectricCurrent
		{
			public static class Conversions
			{
				public static TQuantity Amperes(this TStorage value) => TQuantity.Create(Convert.FromAmperes(value));
				public static TStorage Amperes(this TQuantity quantity) => Convert.ToAmperes(quantity.Quantity);
				public static TQuantity Milliamperes(this TStorage value) => TQuantity.Create(Convert.FromMilliamperes(value));
				public static TStorage Milliamperes(this TQuantity quantity) => Convert.ToMilliamperes(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = ElectricCurrent;
		using TStorage = double;
		public record ElectricCurrent : ElectricCurrent<TQuantity, TStorage>;

		namespace Conversions.ElectricCurrent
		{
			public static class Conversions
			{
				public static TQuantity Amperes(this TStorage value) => TQuantity.Create(Convert.FromAmperes(value));
				public static TStorage Amperes(this TQuantity quantity) => Convert.ToAmperes(quantity.Quantity);
				public static TQuantity Milliamperes(this TStorage value) => TQuantity.Create(Convert.FromMilliamperes(value));
				public static TStorage Milliamperes(this TQuantity quantity) => Convert.ToMilliamperes(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = ElectricCurrent;
		using TStorage = decimal;
		public record ElectricCurrent : ElectricCurrent<TQuantity, TStorage>;

		namespace Conversions.ElectricCurrent
		{
			public static class Conversions
			{
				public static TQuantity Amperes(this TStorage value) => TQuantity.Create(Convert.FromAmperes(value));
				public static TStorage Amperes(this TQuantity quantity) => Convert.ToAmperes(quantity.Quantity);
				public static TQuantity Milliamperes(this TStorage value) => TQuantity.Create(Convert.FromMilliamperes(value));
				public static TStorage Milliamperes(this TQuantity quantity) => Convert.ToMilliamperes(quantity.Quantity);
			}
		}
	}
}
