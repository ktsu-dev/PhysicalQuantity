// Ignore Spelling: Gradians ktsu

namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.AngularVelocityConversions;

	namespace Generic
	{
		[SIUnit("rad/s", "radian per second", "radians per second")]
		public record AngularVelocity<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : AngularVelocity<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class AngularVelocityConversions
		{
			public static TStorage FromRadiansPerSecond<TStorage>(TStorage value)
			where TStorage : INumber<TStorage>
			=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToRadiansPerSecond<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromDegreesPerSecond<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, Math.PI / 180, 0);
			public static TStorage ToDegreesPerSecond<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, Math.PI / 180, 0);
			public static TStorage FromGradiansPerSecond<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, Math.PI / 200, 0);
			public static TStorage ToGradiansPerSecond<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, Math.PI / 200, 0);
			public static TStorage FromRevolutionsPerSecond<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 2 * Math.PI, 0);
			public static TStorage ToRevolutionsPerSecond<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 2 * Math.PI, 0);
			public static TStorage FromRevolutionsPerMinute<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 2 * Math.PI / 60, 0);
			public static TStorage ToRevolutionsPerMinute<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 2 * Math.PI / 60, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = AngularVelocity;
		using TStorage = float;
		public record AngularVelocity : AngularVelocity<TQuantity, TStorage>;

		namespace Conversions.AngularVelocity
		{
			public static class Conversions
			{
				public static TQuantity RadiansPerSecond(this TStorage value) => TQuantity.Create(Convert.FromRadiansPerSecond(value));
				public static TStorage RadiansPerSecond(this TQuantity quantity) => Convert.ToRadiansPerSecond(quantity.Quantity);
				public static TQuantity DegreesPerSecond(this TStorage value) => TQuantity.Create(Convert.FromDegreesPerSecond(value));
				public static TStorage DegreesPerSecond(this TQuantity quantity) => Convert.ToDegreesPerSecond(quantity.Quantity);
				public static TQuantity GradiansPerSecond(this TStorage value) => TQuantity.Create(Convert.FromGradiansPerSecond(value));
				public static TStorage GradiansPerSecond(this TQuantity quantity) => Convert.ToGradiansPerSecond(quantity.Quantity);
				public static TQuantity RevolutionsPerSecond(this TStorage value) => TQuantity.Create(Convert.FromRevolutionsPerSecond(value));
				public static TStorage RevolutionsPerSecond(this TQuantity quantity) => Convert.ToRevolutionsPerSecond(quantity.Quantity);
				public static TQuantity RevolutionsPerMinute(this TStorage value) => TQuantity.Create(Convert.FromRevolutionsPerMinute(value));
				public static TStorage RevolutionsPerMinute(this TQuantity quantity) => Convert.ToRevolutionsPerMinute(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = AngularVelocity;
		using TStorage = double;
		public record AngularVelocity : AngularVelocity<TQuantity, TStorage>;

		namespace Conversions.AngularVelocity
		{
			public static class Conversions
			{
				public static TQuantity RadiansPerSecond(this TStorage value) => TQuantity.Create(Convert.FromRadiansPerSecond(value));
				public static TStorage RadiansPerSecond(this TQuantity quantity) => Convert.ToRadiansPerSecond(quantity.Quantity);
				public static TQuantity DegreesPerSecond(this TStorage value) => TQuantity.Create(Convert.FromDegreesPerSecond(value));
				public static TStorage DegreesPerSecond(this TQuantity quantity) => Convert.ToDegreesPerSecond(quantity.Quantity);
				public static TQuantity GradiansPerSecond(this TStorage value) => TQuantity.Create(Convert.FromGradiansPerSecond(value));
				public static TStorage GradiansPerSecond(this TQuantity quantity) => Convert.ToGradiansPerSecond(quantity.Quantity);
				public static TQuantity RevolutionsPerSecond(this TStorage value) => TQuantity.Create(Convert.FromRevolutionsPerSecond(value));
				public static TStorage RevolutionsPerSecond(this TQuantity quantity) => Convert.ToRevolutionsPerSecond(quantity.Quantity);
				public static TQuantity RevolutionsPerMinute(this TStorage value) => TQuantity.Create(Convert.FromRevolutionsPerMinute(value));
				public static TStorage RevolutionsPerMinute(this TQuantity quantity) => Convert.ToRevolutionsPerMinute(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = AngularVelocity;
		using TStorage = decimal;
		public record AngularVelocity : AngularVelocity<TQuantity, TStorage>;

		namespace Conversions.AngularVelocity
		{
			public static class Conversions
			{
				public static TQuantity RadiansPerSecond(this TStorage value) => TQuantity.Create(Convert.FromRadiansPerSecond(value));
				public static TStorage RadiansPerSecond(this TQuantity quantity) => Convert.ToRadiansPerSecond(quantity.Quantity);
				public static TQuantity DegreesPerSecond(this TStorage value) => TQuantity.Create(Convert.FromDegreesPerSecond(value));
				public static TStorage DegreesPerSecond(this TQuantity quantity) => Convert.ToDegreesPerSecond(quantity.Quantity);
				public static TQuantity GradiansPerSecond(this TStorage value) => TQuantity.Create(Convert.FromGradiansPerSecond(value));
				public static TStorage GradiansPerSecond(this TQuantity quantity) => Convert.ToGradiansPerSecond(quantity.Quantity);
				public static TQuantity RevolutionsPerSecond(this TStorage value) => TQuantity.Create(Convert.FromRevolutionsPerSecond(value));
				public static TStorage RevolutionsPerSecond(this TQuantity quantity) => Convert.ToRevolutionsPerSecond(quantity.Quantity);
				public static TQuantity RevolutionsPerMinute(this TStorage value) => TQuantity.Create(Convert.FromRevolutionsPerMinute(value));
				public static TStorage RevolutionsPerMinute(this TQuantity quantity) => Convert.ToRevolutionsPerMinute(quantity.Quantity);
			}
		}
	}

	namespace Significant
	{
		using Generic;
		using TQuantity = AngularVelocity;
		using TStorage = SignificantNumber.SignificantNumber;
		public record AngularVelocity : AngularVelocity<TQuantity, TStorage>;

		namespace Conversions.AngularVelocity
		{
			public static class Conversions
			{
				public static TQuantity RadiansPerSecond(this TStorage value) => TQuantity.Create(Convert.FromRadiansPerSecond(value));
				public static TStorage RadiansPerSecond(this TQuantity quantity) => Convert.ToRadiansPerSecond(quantity.Quantity);
				public static TQuantity DegreesPerSecond(this TStorage value) => TQuantity.Create(Convert.FromDegreesPerSecond(value));
				public static TStorage DegreesPerSecond(this TQuantity quantity) => Convert.ToDegreesPerSecond(quantity.Quantity);
				public static TQuantity GradiansPerSecond(this TStorage value) => TQuantity.Create(Convert.FromGradiansPerSecond(value));
				public static TStorage GradiansPerSecond(this TQuantity quantity) => Convert.ToGradiansPerSecond(quantity.Quantity);
				public static TQuantity RevolutionsPerSecond(this TStorage value) => TQuantity.Create(Convert.FromRevolutionsPerSecond(value));
				public static TStorage RevolutionsPerSecond(this TQuantity quantity) => Convert.ToRevolutionsPerSecond(quantity.Quantity);
				public static TQuantity RevolutionsPerMinute(this TStorage value) => TQuantity.Create(Convert.FromRevolutionsPerMinute(value));
				public static TStorage RevolutionsPerMinute(this TQuantity quantity) => Convert.ToRevolutionsPerMinute(quantity.Quantity);
			}
		}
	}
}
