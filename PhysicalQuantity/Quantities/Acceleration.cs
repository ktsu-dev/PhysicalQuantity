namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.AccelerationConversions;

	namespace Generic
	{
		[SIUnit("m/s²", "meter per second squared", "meters per second squared")]
		public abstract record Acceleration<TSelf, TStorage>
		: PhysicalQuantity<TSelf, TStorage>
		where TSelf : Acceleration<TSelf, TStorage>, new()
		where TStorage : INumber<TStorage>
		{ }

		public static class AccelerationConversions
		{
			public static TStorage FromMetersPerSecondSquared<TStorage>(TStorage value)
			where TStorage : INumber<TStorage>
			=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToMetersPerSecondSquared<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromFeetPerSecondSquared<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.3048, 0);
			public static TStorage ToFeetPerSecondSquared<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.3048, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Acceleration;
		using TStorage = float;
		public record Acceleration : Acceleration<TQuantity, TStorage>;

		namespace Conversions.Acceleration
		{
			public static class Conversions
			{
				public static TQuantity MetersPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromMetersPerSecondSquared(value));
				public static TStorage MetersPerSecondSquared(this TQuantity quantity) => Convert.ToMetersPerSecondSquared(quantity.Quantity);
				public static TQuantity FeetPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromFeetPerSecondSquared(value));
				public static TStorage FeetPerSecondSquared(this TQuantity quantity) => Convert.ToFeetPerSecondSquared(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Acceleration;
		using TStorage = double;
		public record Acceleration : Acceleration<TQuantity, TStorage>;

		namespace Conversions.Acceleration
		{
			public static class Conversions
			{
				public static TQuantity MetersPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromMetersPerSecondSquared(value));
				public static TStorage MetersPerSecondSquared(this TQuantity quantity) => Convert.ToMetersPerSecondSquared(quantity.Quantity);
				public static TQuantity FeetPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromFeetPerSecondSquared(value));
				public static TStorage FeetPerSecondSquared(this TQuantity quantity) => Convert.ToFeetPerSecondSquared(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Acceleration;
		using TStorage = decimal;
		public record Acceleration : Acceleration<TQuantity, TStorage>;

		namespace Conversions.Acceleration
		{
			public static class Conversions
			{
				public static TQuantity MetersPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromMetersPerSecondSquared(value));
				public static TStorage MetersPerSecondSquared(this TQuantity quantity) => Convert.ToMetersPerSecondSquared(quantity.Quantity);
				public static TQuantity FeetPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromFeetPerSecondSquared(value));
				public static TStorage FeetPerSecondSquared(this TQuantity quantity) => Convert.ToFeetPerSecondSquared(quantity.Quantity);
			}
		}
	}
}
