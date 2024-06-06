namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.AngularAccelerationConversions;

	namespace Generic
	{
		[SIUnit("rad/s²", "radian per second squared", "radians per second squared")]
		public record AngularAcceleration<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : AngularAcceleration<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class AngularAccelerationConversions
		{
			public static TStorage FromRadiansPerSecondSquared<TStorage>(TStorage value)
			where TStorage : INumber<TStorage>
			=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToRadiansPerSecondSquared<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromDegreesPerSecondSquared<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, Math.PI / 180, 0);
			public static TStorage ToDegreesPerSecondSquared<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, Math.PI / 180, 0);
			public static TStorage FromGradiansPerSecondSquared<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, Math.PI / 200, 0);
			public static TStorage ToGradiansPerSecondSquared<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, Math.PI / 200, 0);
			public static TStorage FromRevolutionsPerSecondSquared<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 2 * Math.PI, 0);
			public static TStorage ToRevolutionsPerSecondSquared<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 2 * Math.PI, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = AngularAcceleration;
		using TStorage = float;
		public record AngularAcceleration : AngularAcceleration<TQuantity, TStorage>;

		namespace Conversions.AngularAcceleration
		{
			public static class Conversions
			{
				public static TQuantity RadiansPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromRadiansPerSecondSquared(value));
				public static TStorage RadiansPerSecondSquared(this TQuantity quantity) => Convert.ToRadiansPerSecondSquared(quantity.Quantity);
				public static TQuantity DegreesPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromDegreesPerSecondSquared(value));
				public static TStorage DegreesPerSecondSquared(this TQuantity quantity) => Convert.ToDegreesPerSecondSquared(quantity.Quantity);
				public static TQuantity GradiansPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromGradiansPerSecondSquared(value));
				public static TStorage GradiansPerSecondSquared(this TQuantity quantity) => Convert.ToGradiansPerSecondSquared(quantity.Quantity);
				public static TQuantity RevolutionsPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromRevolutionsPerSecondSquared(value));
				public static TStorage RevolutionsPerSecondSquared(this TQuantity quantity) => Convert.ToRevolutionsPerSecondSquared(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = AngularAcceleration;
		using TStorage = double;
		public record AngularAcceleration : AngularAcceleration<TQuantity, TStorage>;

		namespace Conversions.AngularAcceleration
		{
			public static class Conversions
			{
				public static TQuantity RadiansPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromRadiansPerSecondSquared(value));
				public static TStorage RadiansPerSecondSquared(this TQuantity quantity) => Convert.ToRadiansPerSecondSquared(quantity.Quantity);
				public static TQuantity DegreesPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromDegreesPerSecondSquared(value));
				public static TStorage DegreesPerSecondSquared(this TQuantity quantity) => Convert.ToDegreesPerSecondSquared(quantity.Quantity);
				public static TQuantity GradiansPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromGradiansPerSecondSquared(value));
				public static TStorage GradiansPerSecondSquared(this TQuantity quantity) => Convert.ToGradiansPerSecondSquared(quantity.Quantity);
				public static TQuantity RevolutionsPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromRevolutionsPerSecondSquared(value));
				public static TStorage RevolutionsPerSecondSquared(this TQuantity quantity) => Convert.ToRevolutionsPerSecondSquared(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = AngularAcceleration;
		using TStorage = decimal;
		public record AngularAcceleration : AngularAcceleration<TQuantity, TStorage>;

		namespace Conversions.AngularAcceleration
		{
			public static class Conversions
			{
				public static TQuantity RadiansPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromRadiansPerSecondSquared(value));
				public static TStorage RadiansPerSecondSquared(this TQuantity quantity) => Convert.ToRadiansPerSecondSquared(quantity.Quantity);
				public static TQuantity DegreesPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromDegreesPerSecondSquared(value));
				public static TStorage DegreesPerSecondSquared(this TQuantity quantity) => Convert.ToDegreesPerSecondSquared(quantity.Quantity);
				public static TQuantity GradiansPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromGradiansPerSecondSquared(value));
				public static TStorage GradiansPerSecondSquared(this TQuantity quantity) => Convert.ToGradiansPerSecondSquared(quantity.Quantity);
				public static TQuantity RevolutionsPerSecondSquared(this TStorage value) => TQuantity.Create(Convert.FromRevolutionsPerSecondSquared(value));
				public static TStorage RevolutionsPerSecondSquared(this TQuantity quantity) => Convert.ToRevolutionsPerSecondSquared(quantity.Quantity);
			}
		}
	}
}
