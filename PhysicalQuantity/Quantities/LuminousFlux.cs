// Ignore Spelling: ktsu Lumens

namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.LuminousFluxConversions;

	namespace Generic
	{
		[SIUnit("lm", "lumen", "lumens")]
		public record LuminousFlux<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : LuminousFlux<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class LuminousFluxConversions
		{
			public static TStorage FromLumens<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToLumens<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = LuminousFlux;
		using TStorage = float;
		public record LuminousFlux : LuminousFlux<TQuantity, TStorage>;

		namespace Conversions.LuminousFlux
		{
			public static class Conversions
			{
				public static TQuantity Lumens(this TStorage value) => TQuantity.Create(Convert.FromLumens(value));
				public static TStorage Lumens(this TQuantity quantity) => Convert.ToLumens(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = LuminousFlux;
		using TStorage = double;
		public record LuminousFlux : LuminousFlux<TQuantity, TStorage>;

		namespace Conversions.LuminousFlux
		{
			public static class Conversions
			{
				public static TQuantity Lumens(this TStorage value) => TQuantity.Create(Convert.FromLumens(value));
				public static TStorage Lumens(this TQuantity quantity) => Convert.ToLumens(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = LuminousFlux;
		using TStorage = decimal;
		public record LuminousFlux : LuminousFlux<TQuantity, TStorage>;

		namespace Conversions.LuminousFlux
		{
			public static class Conversions
			{
				public static TQuantity Lumens(this TStorage value) => TQuantity.Create(Convert.FromLumens(value));
				public static TStorage Lumens(this TQuantity quantity) => Convert.ToLumens(quantity.Quantity);
			}
		}
	}

	namespace Significant
	{
		using Generic;
		using TQuantity = LuminousFlux;
		using TStorage = SignificantNumber.SignificantNumber;
		public record LuminousFlux : LuminousFlux<TQuantity, TStorage>;

		namespace Conversions.LuminousFlux
		{
			public static class Conversions
			{
				public static TQuantity Lumens(this TStorage value) => TQuantity.Create(Convert.FromLumens(value));
				public static TStorage Lumens(this TQuantity quantity) => Convert.ToLumens(quantity.Quantity);
			}
		}
	}
}
