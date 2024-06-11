// Ignore Spelling: ktsu

namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.EnergyConversions;

	namespace Generic
	{
		[SIUnit("J", "joule", "joules")]
		public record Energy<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Energy<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class EnergyConversions
		{
			public static TStorage FromJoules<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToJoules<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromKilojoules<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1e3, 0);
			public static TStorage ToKilojoules<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1e3, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Energy;
		using TStorage = float;
		public record Energy : Energy<TQuantity, TStorage>;

		namespace Conversions.Energy
		{
			public static class Conversions
			{
				public static TQuantity Joules(this TStorage value) => TQuantity.Create(Convert.FromJoules(value));
				public static TStorage Joules(this TQuantity quantity) => Convert.ToJoules(quantity.Quantity);
				public static TQuantity Kilojoules(this TStorage value) => TQuantity.Create(Convert.FromKilojoules(value));
				public static TStorage Kilojoules(this TQuantity quantity) => Convert.ToKilojoules(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Energy;
		using TStorage = double;
		public record Energy : Energy<TQuantity, TStorage>;

		namespace Conversions.Energy
		{
			public static class Conversions
			{
				public static TQuantity Joules(this TStorage value) => TQuantity.Create(Convert.FromJoules(value));
				public static TStorage Joules(this TQuantity quantity) => Convert.ToJoules(quantity.Quantity);
				public static TQuantity Kilojoules(this TStorage value) => TQuantity.Create(Convert.FromKilojoules(value));
				public static TStorage Kilojoules(this TQuantity quantity) => Convert.ToKilojoules(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Energy;
		using TStorage = decimal;
		public record Energy : Energy<TQuantity, TStorage>;

		namespace Conversions.Energy
		{
			public static class Conversions
			{
				public static TQuantity Joules(this TStorage value) => TQuantity.Create(Convert.FromJoules(value));
				public static TStorage Joules(this TQuantity quantity) => Convert.ToJoules(quantity.Quantity);
				public static TQuantity Kilojoules(this TStorage value) => TQuantity.Create(Convert.FromKilojoules(value));
				public static TStorage Kilojoules(this TQuantity quantity) => Convert.ToKilojoules(quantity.Quantity);
			}
		}
	}

	namespace Significant
	{
		using Generic;
		using TQuantity = Energy;
		using TStorage = SignificantNumber.SignificantNumber;
		public record Energy : Energy<TQuantity, TStorage>;

		namespace Conversions.Energy
		{
			public static class Conversions
			{
				public static TQuantity Joules(this TStorage value) => TQuantity.Create(Convert.FromJoules(value));
				public static TStorage Joules(this TQuantity quantity) => Convert.ToJoules(quantity.Quantity);
				public static TQuantity Kilojoules(this TStorage value) => TQuantity.Create(Convert.FromKilojoules(value));
				public static TStorage Kilojoules(this TQuantity quantity) => Convert.ToKilojoules(quantity.Quantity);
			}
		}
	}

}
