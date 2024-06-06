namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.AmountOfSubstanceConversions;

	namespace Generic
	{
		[SIUnit("mol", "mole", "moles")]
		public record AmountOfSubstance<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : AmountOfSubstance<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class AmountOfSubstanceConversions
		{
			public static TStorage FromMoles<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToMoles<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = AmountOfSubstance;
		using TStorage = float;
		public record AmountOfSubstance : AmountOfSubstance<TQuantity, TStorage>;

		namespace Conversions.AmountOfSubstance
		{
			public static class Conversions
			{
				public static TQuantity Moles(this TStorage value) => TQuantity.Create(Convert.FromMoles(value));
				public static TStorage Moles(this TQuantity quantity) => Convert.ToMoles(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = AmountOfSubstance;
		using TStorage = double;
		public record AmountOfSubstance : AmountOfSubstance<TQuantity, TStorage>;

		namespace Conversions.AmountOfSubstance
		{
			public static class Conversions
			{
				public static TQuantity Moles(this TStorage value) => TQuantity.Create(Convert.FromMoles(value));
				public static TStorage Moles(this TQuantity quantity) => Convert.ToMoles(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = AmountOfSubstance;
		using TStorage = decimal;
		public record AmountOfSubstance : AmountOfSubstance<TQuantity, TStorage>;

		namespace Conversions.AmountOfSubstance
		{
			public static class Conversions
			{
				public static TQuantity Moles(this TStorage value) => TQuantity.Create(Convert.FromMoles(value));
				public static TStorage Moles(this TQuantity quantity) => Convert.ToMoles(quantity.Quantity);
			}
		}
	}
}
