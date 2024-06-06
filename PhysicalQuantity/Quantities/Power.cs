namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.PowerConversions;

	namespace Generic
	{
		[SIUnit("W", "watt", "watts")]
		public record Power<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Power<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class PowerConversions
		{
			public static TStorage FromWatts<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToWatts<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromKilowatts<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1e3, 0);
			public static TStorage ToKilowatts<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1e3, 0);
			public static TStorage FromMegawatts<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1e6, 0);
			public static TStorage ToMegawatts<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1e6, 0);
			public static TStorage FromHorsepower<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 745.69987158227022, 0);
			public static TStorage ToHorsepower<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 745.69987158227022, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Power;
		using TStorage = float;
		public record Power : Power<TQuantity, TStorage>;

		namespace Conversions.Power
		{
			public static class Conversions
			{
				public static TQuantity Watts(this TStorage value) => TQuantity.Create(Convert.FromWatts(value));
				public static TStorage Watts(this TQuantity quantity) => Convert.ToWatts(quantity.Quantity);
				public static TQuantity Kilowatts(this TStorage value) => TQuantity.Create(Convert.FromKilowatts(value));
				public static TStorage Kilowatts(this TQuantity quantity) => Convert.ToKilowatts(quantity.Quantity);
				public static TQuantity Megawatts(this TStorage value) => TQuantity.Create(Convert.FromMegawatts(value));
				public static TStorage Megawatts(this TQuantity quantity) => Convert.ToMegawatts(quantity.Quantity);
				public static TQuantity Horsepower(this TStorage value) => TQuantity.Create(Convert.FromHorsepower(value));
				public static TStorage Horsepower(this TQuantity quantity) => Convert.ToHorsepower(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Power;
		using TStorage = double;
		public record Power : Power<TQuantity, TStorage>;

		namespace Conversions.Power
		{
			public static class Conversions
			{
				public static TQuantity Watts(this TStorage value) => TQuantity.Create(Convert.FromWatts(value));
				public static TStorage Watts(this TQuantity quantity) => Convert.ToWatts(quantity.Quantity);
				public static TQuantity Kilowatts(this TStorage value) => TQuantity.Create(Convert.FromKilowatts(value));
				public static TStorage Kilowatts(this TQuantity quantity) => Convert.ToKilowatts(quantity.Quantity);
				public static TQuantity Megawatts(this TStorage value) => TQuantity.Create(Convert.FromMegawatts(value));
				public static TStorage Megawatts(this TQuantity quantity) => Convert.ToMegawatts(quantity.Quantity);
				public static TQuantity Horsepower(this TStorage value) => TQuantity.Create(Convert.FromHorsepower(value));
				public static TStorage Horsepower(this TQuantity quantity) => Convert.ToHorsepower(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Power;
		using TStorage = decimal;
		public record Power : Power<TQuantity, TStorage>;

		namespace Conversions.Power
		{
			public static class Conversions
			{
				public static TQuantity Watts(this TStorage value) => TQuantity.Create(Convert.FromWatts(value));
				public static TStorage Watts(this TQuantity quantity) => Convert.ToWatts(quantity.Quantity);
				public static TQuantity Kilowatts(this TStorage value) => TQuantity.Create(Convert.FromKilowatts(value));
				public static TStorage Kilowatts(this TQuantity quantity) => Convert.ToKilowatts(quantity.Quantity);
				public static TQuantity Megawatts(this TStorage value) => TQuantity.Create(Convert.FromMegawatts(value));
				public static TStorage Megawatts(this TQuantity quantity) => Convert.ToMegawatts(quantity.Quantity);
				public static TQuantity Horsepower(this TStorage value) => TQuantity.Create(Convert.FromHorsepower(value));
				public static TStorage Horsepower(this TQuantity quantity) => Convert.ToHorsepower(quantity.Quantity);
			}
		}
	}
}
