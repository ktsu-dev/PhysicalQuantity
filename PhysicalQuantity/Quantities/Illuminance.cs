// Ignore Spelling: ktsu Illuminance Lux Footcandles

namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.IlluminanceConversions;

	namespace Generic
	{
		[SIUnit("lx", "lux", "lux")]
		public record Illuminance<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Illuminance<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class IlluminanceConversions
		{
			public static TStorage FromLux<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToLux<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromFootcandles<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 10.76391, 0);
			public static TStorage ToFootcandles<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 10.76391, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Illuminance;
		using TStorage = float;
		public record Illuminance : Illuminance<TQuantity, TStorage>;

		namespace Conversions.Illuminance
		{
			public static class Conversions
			{
				public static TQuantity Lux(this TStorage value) => TQuantity.Create(Convert.FromLux(value));
				public static TStorage Lux(this TQuantity quantity) => Convert.ToLux(quantity.Quantity);
				public static TQuantity Footcandles(this TStorage value) => TQuantity.Create(Convert.FromFootcandles(value));
				public static TStorage Footcandles(this TQuantity quantity) => Convert.ToFootcandles(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Illuminance;
		using TStorage = double;
		public record Illuminance : Illuminance<TQuantity, TStorage>;

		namespace Conversions.Illuminance
		{
			public static class Conversions
			{
				public static TQuantity Lux(this TStorage value) => TQuantity.Create(Convert.FromLux(value));
				public static TStorage Lux(this TQuantity quantity) => Convert.ToLux(quantity.Quantity);
				public static TQuantity Footcandles(this TStorage value) => TQuantity.Create(Convert.FromFootcandles(value));
				public static TStorage Footcandles(this TQuantity quantity) => Convert.ToFootcandles(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Illuminance;
		using TStorage = decimal;
		public record Illuminance : Illuminance<TQuantity, TStorage>;

		namespace Conversions.Illuminance
		{
			public static class Conversions
			{
				public static TQuantity Lux(this TStorage value) => TQuantity.Create(Convert.FromLux(value));
				public static TStorage Lux(this TQuantity quantity) => Convert.ToLux(quantity.Quantity);
				public static TQuantity Footcandles(this TStorage value) => TQuantity.Create(Convert.FromFootcandles(value));
				public static TStorage Footcandles(this TQuantity quantity) => Convert.ToFootcandles(quantity.Quantity);
			}
		}
	}

	namespace Significant
	{
		using Generic;
		using TQuantity = Illuminance;
		using TStorage = SignificantNumber.SignificantNumber;
		public record Illuminance : Illuminance<TQuantity, TStorage>;

		namespace Conversions.Illuminance
		{
			public static class Conversions
			{
				public static TQuantity Lux(this TStorage value) => TQuantity.Create(Convert.FromLux(value));
				public static TStorage Lux(this TQuantity quantity) => Convert.ToLux(quantity.Quantity);
				public static TQuantity Footcandles(this TStorage value) => TQuantity.Create(Convert.FromFootcandles(value));
				public static TStorage Footcandles(this TQuantity quantity) => Convert.ToFootcandles(quantity.Quantity);
			}
		}
	}
}
