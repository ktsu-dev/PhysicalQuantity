// Ignore Spelling: ktsu Candelas

namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.LuminousIntensityConversions;

	namespace Generic
	{
		[SIUnit("cd", "candela", "candelas")]
		public record LuminousIntensity<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : LuminousIntensity<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class LuminousIntensityConversions
		{
			public static TStorage FromCandelas<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToCandelas<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = LuminousIntensity;
		using TStorage = float;
		public record LuminousIntensity : LuminousIntensity<TQuantity, TStorage>;

		namespace Conversions.LuminousIntensity
		{
			public static class Conversions
			{
				public static TQuantity Candelas(this TStorage value) => TQuantity.Create(Convert.FromCandelas(value));
				public static TStorage Candelas(this TQuantity quantity) => Convert.ToCandelas(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = LuminousIntensity;
		using TStorage = double;
		public record LuminousIntensity : LuminousIntensity<TQuantity, TStorage>;

		namespace Conversions.LuminousIntensity
		{
			public static class Conversions
			{
				public static TQuantity Candelas(this TStorage value) => TQuantity.Create(Convert.FromCandelas(value));
				public static TStorage Candelas(this TQuantity quantity) => Convert.ToCandelas(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = LuminousIntensity;
		using TStorage = decimal;
		public record LuminousIntensity : LuminousIntensity<TQuantity, TStorage>;

		namespace Conversions.LuminousIntensity
		{
			public static class Conversions
			{
				public static TQuantity Candelas(this TStorage value) => TQuantity.Create(Convert.FromCandelas(value));
				public static TStorage Candelas(this TQuantity quantity) => Convert.ToCandelas(quantity.Quantity);
			}
		}
	}

	namespace Significant
	{
		using Generic;
		using TQuantity = LuminousIntensity;
		using TStorage = SignificantNumber.SignificantNumber;
		public record LuminousIntensity : LuminousIntensity<TQuantity, TStorage>;

		namespace Conversions.LuminousIntensity
		{
			public static class Conversions
			{
				public static TQuantity Candelas(this TStorage value) => TQuantity.Create(Convert.FromCandelas(value));
				public static TStorage Candelas(this TQuantity quantity) => Convert.ToCandelas(quantity.Quantity);
			}
		}
	}
}
