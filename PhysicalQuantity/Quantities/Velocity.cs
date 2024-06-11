// Ignore Spelling: ktsu

namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.VelocityConversions;

	namespace Generic
	{
		[SIUnit("m/s", "meter per second", "meters per second")]
		public record Velocity<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Velocity<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class VelocityConversions
		{
			public static TStorage FromMetersPerSecond<TStorage>(TStorage value)
			where TStorage : INumber<TStorage>
			=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToMetersPerSecond<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromKilometersPerHour<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.2777777777777778, 0);
			public static TStorage ToKilometersPerHour<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.2777777777777778, 0);
			public static TStorage FromMilesPerHour<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.44704, 0);
			public static TStorage ToMilesPerHour<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.44704, 0);
			public static TStorage FromKnots<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.5144444444444445, 0);
			public static TStorage ToKnots<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.5144444444444445, 0);
			public static TStorage FromFeetPerSecond<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.3048, 0);
			public static TStorage ToFeetPerSecond<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.3048, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Velocity;
		using TStorage = float;
		public record Velocity : Velocity<TQuantity, TStorage>;

		namespace Conversions.Velocity
		{
			public static class Conversions
			{
				public static TQuantity MetersPerSecond(this TStorage value) => TQuantity.Create(Convert.FromMetersPerSecond(value));
				public static TStorage MetersPerSecond(this TQuantity quantity) => Convert.ToMetersPerSecond(quantity.Quantity);
				public static TQuantity KilometersPerHour(this TStorage value) => TQuantity.Create(Convert.FromKilometersPerHour(value));
				public static TStorage KilometersPerHour(this TQuantity quantity) => Convert.ToKilometersPerHour(quantity.Quantity);
				public static TQuantity MilesPerHour(this TStorage value) => TQuantity.Create(Convert.FromMilesPerHour(value));
				public static TStorage MilesPerHour(this TQuantity quantity) => Convert.ToMilesPerHour(quantity.Quantity);
				public static TQuantity Knots(this TStorage value) => TQuantity.Create(Convert.FromKnots(value));
				public static TStorage Knots(this TQuantity quantity) => Convert.ToKnots(quantity.Quantity);
				public static TQuantity FeetPerSecond(this TStorage value) => TQuantity.Create(Convert.FromFeetPerSecond(value));
				public static TStorage FeetPerSecond(this TQuantity quantity) => Convert.ToFeetPerSecond(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Velocity;
		using TStorage = double;
		public record Velocity : Velocity<TQuantity, TStorage>;

		namespace Conversions.Velocity
		{
			public static class Conversions
			{
				public static TQuantity MetersPerSecond(this TStorage value) => TQuantity.Create(Convert.FromMetersPerSecond(value));
				public static TStorage MetersPerSecond(this TQuantity quantity) => Convert.ToMetersPerSecond(quantity.Quantity);
				public static TQuantity KilometersPerHour(this TStorage value) => TQuantity.Create(Convert.FromKilometersPerHour(value));
				public static TStorage KilometersPerHour(this TQuantity quantity) => Convert.ToKilometersPerHour(quantity.Quantity);
				public static TQuantity MilesPerHour(this TStorage value) => TQuantity.Create(Convert.FromMilesPerHour(value));
				public static TStorage MilesPerHour(this TQuantity quantity) => Convert.ToMilesPerHour(quantity.Quantity);
				public static TQuantity Knots(this TStorage value) => TQuantity.Create(Convert.FromKnots(value));
				public static TStorage Knots(this TQuantity quantity) => Convert.ToKnots(quantity.Quantity);
				public static TQuantity FeetPerSecond(this TStorage value) => TQuantity.Create(Convert.FromFeetPerSecond(value));
				public static TStorage FeetPerSecond(this TQuantity quantity) => Convert.ToFeetPerSecond(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Velocity;
		using TStorage = decimal;
		public record Velocity : Velocity<TQuantity, TStorage>;

		namespace Conversions.Velocity
		{
			public static class Conversions
			{
				public static TQuantity MetersPerSecond(this TStorage value) => TQuantity.Create(Convert.FromMetersPerSecond(value));
				public static TStorage MetersPerSecond(this TQuantity quantity) => Convert.ToMetersPerSecond(quantity.Quantity);
				public static TQuantity KilometersPerHour(this TStorage value) => TQuantity.Create(Convert.FromKilometersPerHour(value));
				public static TStorage KilometersPerHour(this TQuantity quantity) => Convert.ToKilometersPerHour(quantity.Quantity);
				public static TQuantity MilesPerHour(this TStorage value) => TQuantity.Create(Convert.FromMilesPerHour(value));
				public static TStorage MilesPerHour(this TQuantity quantity) => Convert.ToMilesPerHour(quantity.Quantity);
				public static TQuantity Knots(this TStorage value) => TQuantity.Create(Convert.FromKnots(value));
				public static TStorage Knots(this TQuantity quantity) => Convert.ToKnots(quantity.Quantity);
				public static TQuantity FeetPerSecond(this TStorage value) => TQuantity.Create(Convert.FromFeetPerSecond(value));
				public static TStorage FeetPerSecond(this TQuantity quantity) => Convert.ToFeetPerSecond(quantity.Quantity);
			}
		}
	}

	namespace Significant
	{
		using Generic;
		using TQuantity = Velocity;
		using TStorage = SignificantNumber.SignificantNumber;
		public record Velocity : Velocity<TQuantity, TStorage>;

		namespace Conversions.Velocity
		{
			public static class Conversions
			{
				public static TQuantity MetersPerSecond(this TStorage value) => TQuantity.Create(Convert.FromMetersPerSecond(value));
				public static TStorage MetersPerSecond(this TQuantity quantity) => Convert.ToMetersPerSecond(quantity.Quantity);
				public static TQuantity KilometersPerHour(this TStorage value) => TQuantity.Create(Convert.FromKilometersPerHour(value));
				public static TStorage KilometersPerHour(this TQuantity quantity) => Convert.ToKilometersPerHour(quantity.Quantity);
				public static TQuantity MilesPerHour(this TStorage value) => TQuantity.Create(Convert.FromMilesPerHour(value));
				public static TStorage MilesPerHour(this TQuantity quantity) => Convert.ToMilesPerHour(quantity.Quantity);
				public static TQuantity Knots(this TStorage value) => TQuantity.Create(Convert.FromKnots(value));
				public static TStorage Knots(this TQuantity quantity) => Convert.ToKnots(quantity.Quantity);
				public static TQuantity FeetPerSecond(this TStorage value) => TQuantity.Create(Convert.FromFeetPerSecond(value));
				public static TStorage FeetPerSecond(this TQuantity quantity) => Convert.ToFeetPerSecond(quantity.Quantity);
			}
		}
	}
}
