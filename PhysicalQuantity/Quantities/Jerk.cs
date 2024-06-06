namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.JerkConversions;

	namespace Generic
	{
		[SIUnit("m/s³", "meter per second cubed", "meters per second cubed")]
		public record Jerk<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Jerk<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class JerkConversions
		{
			public static TStorage FromMetersPerSecondCubed<TStorage>(TStorage value)
			where TStorage : INumber<TStorage>
			=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToMetersPerSecondCubed<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromFeetPerSecondCubed<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 0.3048, 0);
			public static TStorage ToFeetPerSecondCubed<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 0.3048, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Jerk;
		using TStorage = float;
		public record Jerk : Jerk<TQuantity, TStorage>;

		namespace Conversions.Jerk
		{
			public static class Conversions
			{
				public static TQuantity MetersPerSecondCubed(this TStorage value) => TQuantity.Create(Convert.FromMetersPerSecondCubed(value));
				public static TStorage MetersPerSecondCubed(this TQuantity quantity) => Convert.ToMetersPerSecondCubed(quantity.Quantity);
				public static TQuantity FeetPerSecondCubed(this TStorage value) => TQuantity.Create(Convert.FromFeetPerSecondCubed(value));
				public static TStorage FeetPerSecondCubed(this TQuantity quantity) => Convert.ToFeetPerSecondCubed(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Jerk;
		using TStorage = double;
		public record Jerk : Jerk<TQuantity, TStorage>;

		namespace Conversions.Jerk
		{
			public static class Conversions
			{
				public static TQuantity MetersPerSecondCubed(this TStorage value) => TQuantity.Create(Convert.FromMetersPerSecondCubed(value));
				public static TStorage MetersPerSecondCubed(this TQuantity quantity) => Convert.ToMetersPerSecondCubed(quantity.Quantity);
				public static TQuantity FeetPerSecondCubed(this TStorage value) => TQuantity.Create(Convert.FromFeetPerSecondCubed(value));
				public static TStorage FeetPerSecondCubed(this TQuantity quantity) => Convert.ToFeetPerSecondCubed(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Jerk;
		using TStorage = decimal;
		public record Jerk : Jerk<TQuantity, TStorage>;

		namespace Conversions.Jerk
		{
			public static class Conversions
			{
				public static TQuantity MetersPerSecondCubed(this TStorage value) => TQuantity.Create(Convert.FromMetersPerSecondCubed(value));
				public static TStorage MetersPerSecondCubed(this TQuantity quantity) => Convert.ToMetersPerSecondCubed(quantity.Quantity);
				public static TQuantity FeetPerSecondCubed(this TStorage value) => TQuantity.Create(Convert.FromFeetPerSecondCubed(value));
				public static TStorage FeetPerSecondCubed(this TQuantity quantity) => Convert.ToFeetPerSecondCubed(quantity.Quantity);
			}
		}
	}
}
