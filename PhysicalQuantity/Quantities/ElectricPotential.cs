// Ignore Spelling: ktsu

namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.ElectricPotentialConversions;

	namespace Generic
	{
		[SIUnit("V", "volt", "volts")]
		public record ElectricPotential<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : ElectricPotential<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class ElectricPotentialConversions
		{
			public static TStorage FromVolts<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToVolts<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromMillivolts<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1e-3, 0);
			public static TStorage ToMillivolts<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1e-3, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = ElectricPotential;
		using TStorage = float;
		public record ElectricPotential : ElectricPotential<TQuantity, TStorage>;

		namespace Conversions.ElectricPotential
		{
			public static class Conversions
			{
				public static TQuantity Volts(this TStorage value) => TQuantity.Create(Convert.FromVolts(value));
				public static TStorage Volts(this TQuantity quantity) => Convert.ToVolts(quantity.Quantity);
				public static TQuantity Millivolts(this TStorage value) => TQuantity.Create(Convert.FromMillivolts(value));
				public static TStorage Millivolts(this TQuantity quantity) => Convert.ToMillivolts(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = ElectricPotential;
		using TStorage = double;
		public record ElectricPotential : ElectricPotential<TQuantity, TStorage>;

		namespace Conversions.ElectricPotential
		{
			public static class Conversions
			{
				public static TQuantity Volts(this TStorage value) => TQuantity.Create(Convert.FromVolts(value));
				public static TStorage Volts(this TQuantity quantity) => Convert.ToVolts(quantity.Quantity);
				public static TQuantity Millivolts(this TStorage value) => TQuantity.Create(Convert.FromMillivolts(value));
				public static TStorage Millivolts(this TQuantity quantity) => Convert.ToMillivolts(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = ElectricPotential;
		using TStorage = decimal;
		public record ElectricPotential : ElectricPotential<TQuantity, TStorage>;

		namespace Conversions.ElectricPotential
		{
			public static class Conversions
			{
				public static TQuantity Volts(this TStorage value) => TQuantity.Create(Convert.FromVolts(value));
				public static TStorage Volts(this TQuantity quantity) => Convert.ToVolts(quantity.Quantity);
				public static TQuantity Millivolts(this TStorage value) => TQuantity.Create(Convert.FromMillivolts(value));
				public static TStorage Millivolts(this TQuantity quantity) => Convert.ToMillivolts(quantity.Quantity);
			}
		}
	}

	namespace Significant
	{
		using Generic;
		using TQuantity = ElectricPotential;
		using TStorage = SignificantNumber.SignificantNumber;
		public record ElectricPotential : ElectricPotential<TQuantity, TStorage>;

		namespace Conversions.ElectricPotential
		{
			public static class Conversions
			{
				public static TQuantity Volts(this TStorage value) => TQuantity.Create(Convert.FromVolts(value));
				public static TStorage Volts(this TQuantity quantity) => Convert.ToVolts(quantity.Quantity);
				public static TQuantity Millivolts(this TStorage value) => TQuantity.Create(Convert.FromMillivolts(value));
				public static TStorage Millivolts(this TQuantity quantity) => Convert.ToMillivolts(quantity.Quantity);
			}
		}
	}
}
