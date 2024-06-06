namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.AngleConversions;

	namespace Generic
	{
		[SIUnit("rad", "radian", "radians")]
		public record Angle<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Angle<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class AngleConversions
		{
			public static TStorage FromRadians<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToRadians<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromDegrees<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, Math.PI / 180, 0);
			public static TStorage ToDegrees<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, Math.PI / 180, 0);
			public static TStorage FromGradians<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, Math.PI / 200, 0);
			public static TStorage ToGradians<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, Math.PI / 200, 0);
			public static TStorage FromRevolutions<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 2 * Math.PI, 0);
			public static TStorage ToRevolutions<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 2 * Math.PI, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Angle;
		using TStorage = float;
		public record Angle : Angle<TQuantity, TStorage>;

		namespace Conversions.Angle
		{
			public static class Conversions
			{
				public static TQuantity Radians(this TStorage value) => TQuantity.Create(Convert.FromRadians(value));
				public static TStorage Radians(this TQuantity quantity) => Convert.ToRadians(quantity.Quantity);
				public static TQuantity Degrees(this TStorage value) => TQuantity.Create(Convert.FromDegrees(value));
				public static TStorage Degrees(this TQuantity quantity) => Convert.ToDegrees(quantity.Quantity);
				public static TQuantity Gradians(this TStorage value) => TQuantity.Create(Convert.FromGradians(value));
				public static TStorage Gradians(this TQuantity quantity) => Convert.ToGradians(quantity.Quantity);
				public static TQuantity Revolutions(this TStorage value) => TQuantity.Create(Convert.FromRevolutions(value));
				public static TStorage Revolutions(this TQuantity quantity) => Convert.ToRevolutions(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Angle;
		using TStorage = double;
		public record Angle : Angle<TQuantity, TStorage>;

		namespace Conversions.Angle
		{
			public static class Conversions
			{
				public static TQuantity Radians(this TStorage value) => TQuantity.Create(Convert.FromRadians(value));
				public static TStorage Radians(this TQuantity quantity) => Convert.ToRadians(quantity.Quantity);
				public static TQuantity Degrees(this TStorage value) => TQuantity.Create(Convert.FromDegrees(value));
				public static TStorage Degrees(this TQuantity quantity) => Convert.ToDegrees(quantity.Quantity);
				public static TQuantity Gradians(this TStorage value) => TQuantity.Create(Convert.FromGradians(value));
				public static TStorage Gradians(this TQuantity quantity) => Convert.ToGradians(quantity.Quantity);
				public static TQuantity Revolutions(this TStorage value) => TQuantity.Create(Convert.FromRevolutions(value));
				public static TStorage Revolutions(this TQuantity quantity) => Convert.ToRevolutions(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Angle;
		using TStorage = decimal;
		public record Angle : Angle<TQuantity, TStorage>;

		namespace Conversions.Angle
		{
			public static class Conversions
			{
				public static TQuantity Radians(this TStorage value) => TQuantity.Create(Convert.FromRadians(value));
				public static TStorage Radians(this TQuantity quantity) => Convert.ToRadians(quantity.Quantity);
				public static TQuantity Degrees(this TStorage value) => TQuantity.Create(Convert.FromDegrees(value));
				public static TStorage Degrees(this TQuantity quantity) => Convert.ToDegrees(quantity.Quantity);
				public static TQuantity Gradians(this TStorage value) => TQuantity.Create(Convert.FromGradians(value));
				public static TStorage Gradians(this TQuantity quantity) => Convert.ToGradians(quantity.Quantity);
				public static TQuantity Revolutions(this TStorage value) => TQuantity.Create(Convert.FromRevolutions(value));
				public static TStorage Revolutions(this TQuantity quantity) => Convert.ToRevolutions(quantity.Quantity);
			}
		}
	}
}
