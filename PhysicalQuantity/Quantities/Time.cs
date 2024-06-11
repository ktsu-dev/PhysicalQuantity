// Ignore Spelling: ktsu

namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.TimeConversions;

	namespace Generic
	{
		[SIUnit("s", "second", "seconds")]
		public record Time<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Time<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class TimeConversions
		{
			public static TStorage FromSeconds<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToSeconds<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromMinutes<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 60, 0);
			public static TStorage ToMinutes<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 60, 0);
			public static TStorage FromHours<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 3600, 0);
			public static TStorage ToHours<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 3600, 0);
			public static TStorage FromDays<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 86400, 0);
			public static TStorage ToDays<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 86400, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Time;
		using TStorage = float;
		public record Time : Time<TQuantity, TStorage>;

		namespace Conversions.Time
		{
			public static class Conversions
			{
				public static TQuantity Seconds(this TStorage value) => TQuantity.Create(Convert.FromSeconds(value));
				public static TStorage Seconds(this TQuantity quantity) => Convert.ToSeconds(quantity.Quantity);
				public static TQuantity Minutes(this TStorage value) => TQuantity.Create(Convert.FromMinutes(value));
				public static TStorage Minutes(this TQuantity quantity) => Convert.ToMinutes(quantity.Quantity);
				public static TQuantity Hours(this TStorage value) => TQuantity.Create(Convert.FromHours(value));
				public static TStorage Hours(this TQuantity quantity) => Convert.ToHours(quantity.Quantity);
				public static TQuantity Days(this TStorage value) => TQuantity.Create(Convert.FromDays(value));
				public static TStorage Days(this TQuantity quantity) => Convert.ToDays(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Time;
		using TStorage = double;
		public record Time : Time<TQuantity, TStorage>;

		namespace Conversions.Time
		{
			public static class Conversions
			{
				public static TQuantity Seconds(this TStorage value) => TQuantity.Create(Convert.FromSeconds(value));
				public static TStorage Seconds(this TQuantity quantity) => Convert.ToSeconds(quantity.Quantity);
				public static TQuantity Minutes(this TStorage value) => TQuantity.Create(Convert.FromMinutes(value));
				public static TStorage Minutes(this TQuantity quantity) => Convert.ToMinutes(quantity.Quantity);
				public static TQuantity Hours(this TStorage value) => TQuantity.Create(Convert.FromHours(value));
				public static TStorage Hours(this TQuantity quantity) => Convert.ToHours(quantity.Quantity);
				public static TQuantity Days(this TStorage value) => TQuantity.Create(Convert.FromDays(value));
				public static TStorage Days(this TQuantity quantity) => Convert.ToDays(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Time;
		using TStorage = decimal;
		public record Time : Time<TQuantity, TStorage>;

		namespace Conversions.Time
		{
			public static class Conversions
			{
				public static TQuantity Seconds(this TStorage value) => TQuantity.Create(Convert.FromSeconds(value));
				public static TStorage Seconds(this TQuantity quantity) => Convert.ToSeconds(quantity.Quantity);
				public static TQuantity Minutes(this TStorage value) => TQuantity.Create(Convert.FromMinutes(value));
				public static TStorage Minutes(this TQuantity quantity) => Convert.ToMinutes(quantity.Quantity);
				public static TQuantity Hours(this TStorage value) => TQuantity.Create(Convert.FromHours(value));
				public static TStorage Hours(this TQuantity quantity) => Convert.ToHours(quantity.Quantity);
				public static TQuantity Days(this TStorage value) => TQuantity.Create(Convert.FromDays(value));
				public static TStorage Days(this TQuantity quantity) => Convert.ToDays(quantity.Quantity);
			}
		}
	}

	namespace Significant
	{
		using Generic;
		using TQuantity = Time;
		using TStorage = SignificantNumber.SignificantNumber;
		public record Time : Time<TQuantity, TStorage>;

		namespace Conversions.Time
		{
			public static class Conversions
			{
				public static TQuantity Seconds(this TStorage value) => TQuantity.Create(Convert.FromSeconds(value));
				public static TStorage Seconds(this TQuantity quantity) => Convert.ToSeconds(quantity.Quantity);
				public static TQuantity Minutes(this TStorage value) => TQuantity.Create(Convert.FromMinutes(value));
				public static TStorage Minutes(this TQuantity quantity) => Convert.ToMinutes(quantity.Quantity);
				public static TQuantity Hours(this TStorage value) => TQuantity.Create(Convert.FromHours(value));
				public static TStorage Hours(this TQuantity quantity) => Convert.ToHours(quantity.Quantity);
				public static TQuantity Days(this TStorage value) => TQuantity.Create(Convert.FromDays(value));
				public static TStorage Days(this TQuantity quantity) => Convert.ToDays(quantity.Quantity);
			}
		}
	}
}
