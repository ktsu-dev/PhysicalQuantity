namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.ForceConversions;

	namespace Generic
	{
		[SIUnit("N", "newton", "newtons")]
		public record Force<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Force<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class ForceConversions
		{
			public static TStorage FromNewtons<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToNewtons<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromKilonewtons<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1e3, 0);
			public static TStorage ToKilonewtons<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1e3, 0);
			public static TStorage FromPoundsForce<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 4.4482216152605, 0);
			public static TStorage ToPoundsForce<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 4.4482216152605, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Force;
		using TStorage = float;
		public record Force : Force<TQuantity, TStorage>;

		namespace Conversions.Force
		{
			public static class Conversions
			{
				public static TQuantity Newtons(this TStorage value) => TQuantity.Create(Convert.FromNewtons(value));
				public static TStorage Newtons(this TQuantity quantity) => Convert.ToNewtons(quantity.Quantity);
				public static TQuantity Kilonewtons(this TStorage value) => TQuantity.Create(Convert.FromKilonewtons(value));
				public static TStorage Kilonewtons(this TQuantity quantity) => Convert.ToKilonewtons(quantity.Quantity);
				public static TQuantity PoundsForce(this TStorage value) => TQuantity.Create(Convert.FromPoundsForce(value));
				public static TStorage PoundsForce(this TQuantity quantity) => Convert.ToPoundsForce(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Force;
		using TStorage = double;
		public record Force : Force<TQuantity, TStorage>;

		namespace Conversions.Force
		{
			public static class Conversions
			{
				public static TQuantity Newtons(this TStorage value) => TQuantity.Create(Convert.FromNewtons(value));
				public static TStorage Newtons(this TQuantity quantity) => Convert.ToNewtons(quantity.Quantity);
				public static TQuantity Kilonewtons(this TStorage value) => TQuantity.Create(Convert.FromKilonewtons(value));
				public static TStorage Kilonewtons(this TQuantity quantity) => Convert.ToKilonewtons(quantity.Quantity);
				public static TQuantity PoundsForce(this TStorage value) => TQuantity.Create(Convert.FromPoundsForce(value));
				public static TStorage PoundsForce(this TQuantity quantity) => Convert.ToPoundsForce(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Force;
		using TStorage = decimal;
		public record Force : Force<TQuantity, TStorage>;

		namespace Conversions.Force
		{
			public static class Conversions
			{
				public static TQuantity Newtons(this TStorage value) => TQuantity.Create(Convert.FromNewtons(value));
				public static TStorage Newtons(this TQuantity quantity) => Convert.ToNewtons(quantity.Quantity);
				public static TQuantity Kilonewtons(this TStorage value) => TQuantity.Create(Convert.FromKilonewtons(value));
				public static TStorage Kilonewtons(this TQuantity quantity) => Convert.ToKilonewtons(quantity.Quantity);
				public static TQuantity PoundsForce(this TStorage value) => TQuantity.Create(Convert.FromPoundsForce(value));
				public static TStorage PoundsForce(this TQuantity quantity) => Convert.ToPoundsForce(quantity.Quantity);
			}
		}
	}
}
