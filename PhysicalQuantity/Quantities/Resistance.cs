// Ignore Spelling: ktsu Kiloohms Megaohms

namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.ResistanceConversions;

	namespace Generic
	{
		[SIUnit("Ω", "ohm", "ohms")]
		public record Resistance<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Resistance<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class ResistanceConversions
		{
			public static TStorage FromOhms<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToOhms<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromKiloohms<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1e3, 0);
			public static TStorage ToKiloohms<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1e3, 0);
			public static TStorage FromMegaohms<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1e6, 0);
			public static TStorage ToMegaohms<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1e6, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Resistance;
		using TStorage = float;
		public record Resistance : Resistance<TQuantity, TStorage>;

		namespace Conversions.Resistance
		{
			public static class Conversions
			{
				public static TQuantity Ohms(this TStorage value) => TQuantity.Create(Convert.FromOhms(value));
				public static TStorage Ohms(this TQuantity quantity) => Convert.ToOhms(quantity.Quantity);
				public static TQuantity Kiloohms(this TStorage value) => TQuantity.Create(Convert.FromKiloohms(value));
				public static TStorage Kiloohms(this TQuantity quantity) => Convert.ToKiloohms(quantity.Quantity);
				public static TQuantity Megaohms(this TStorage value) => TQuantity.Create(Convert.FromMegaohms(value));
				public static TStorage Megaohms(this TQuantity quantity) => Convert.ToMegaohms(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Resistance;
		using TStorage = double;
		public record Resistance : Resistance<TQuantity, TStorage>;

		namespace Conversions.Resistance
		{
			public static class Conversions
			{
				public static TQuantity Ohms(this TStorage value) => TQuantity.Create(Convert.FromOhms(value));
				public static TStorage Ohms(this TQuantity quantity) => Convert.ToOhms(quantity.Quantity);
				public static TQuantity Kiloohms(this TStorage value) => TQuantity.Create(Convert.FromKiloohms(value));
				public static TStorage Kiloohms(this TQuantity quantity) => Convert.ToKiloohms(quantity.Quantity);
				public static TQuantity Megaohms(this TStorage value) => TQuantity.Create(Convert.FromMegaohms(value));
				public static TStorage Megaohms(this TQuantity quantity) => Convert.ToMegaohms(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Resistance;
		using TStorage = decimal;
		public record Resistance : Resistance<TQuantity, TStorage>;

		namespace Conversions.Resistance
		{
			public static class Conversions
			{
				public static TQuantity Ohms(this TStorage value) => TQuantity.Create(Convert.FromOhms(value));
				public static TStorage Ohms(this TQuantity quantity) => Convert.ToOhms(quantity.Quantity);
				public static TQuantity Kiloohms(this TStorage value) => TQuantity.Create(Convert.FromKiloohms(value));
				public static TStorage Kiloohms(this TQuantity quantity) => Convert.ToKiloohms(quantity.Quantity);
				public static TQuantity Megaohms(this TStorage value) => TQuantity.Create(Convert.FromMegaohms(value));
				public static TStorage Megaohms(this TQuantity quantity) => Convert.ToMegaohms(quantity.Quantity);
			}
		}
	}

	namespace Significant
	{
		using Generic;
		using TQuantity = Resistance;
		using TStorage = SignificantNumber.SignificantNumber;
		public record Resistance : Resistance<TQuantity, TStorage>;

		namespace Conversions.Resistance
		{
			public static class Conversions
			{
				public static TQuantity Ohms(this TStorage value) => TQuantity.Create(Convert.FromOhms(value));
				public static TStorage Ohms(this TQuantity quantity) => Convert.ToOhms(quantity.Quantity);
				public static TQuantity Kiloohms(this TStorage value) => TQuantity.Create(Convert.FromKiloohms(value));
				public static TStorage Kiloohms(this TQuantity quantity) => Convert.ToKiloohms(quantity.Quantity);
				public static TQuantity Megaohms(this TStorage value) => TQuantity.Create(Convert.FromMegaohms(value));
				public static TStorage Megaohms(this TQuantity quantity) => Convert.ToMegaohms(quantity.Quantity);
			}
		}
	}
}
