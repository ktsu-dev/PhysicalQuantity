namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.TorqueConversions;

	namespace Generic
	{
		[SIUnit("N·m", "newton meter", "newton meters")]
		public record Torque<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Torque<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class TorqueConversions
		{
			public static TStorage FromNewtonMeters<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToNewtonMeters<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromFootPounds<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1.3558179483314004, 0);
			public static TStorage ToFootPounds<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1.3558179483314004, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Torque;
		using TStorage = float;
		public record Torque : Torque<TQuantity, TStorage>;

		namespace Conversions.Torque
		{
			public static class Conversions
			{
				public static TQuantity NewtonMeters(this TStorage value) => TQuantity.Create(Convert.FromNewtonMeters(value));
				public static TStorage NewtonMeters(this TQuantity quantity) => Convert.ToNewtonMeters(quantity.Quantity);
				public static TQuantity FootPounds(this TStorage value) => TQuantity.Create(Convert.FromFootPounds(value));
				public static TStorage FootPounds(this TQuantity quantity) => Convert.ToFootPounds(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Torque;
		using TStorage = double;
		public record Torque : Torque<TQuantity, TStorage>;

		namespace Conversions.Torque
		{
			public static class Conversions
			{
				public static TQuantity NewtonMeters(this TStorage value) => TQuantity.Create(Convert.FromNewtonMeters(value));
				public static TStorage NewtonMeters(this TQuantity quantity) => Convert.ToNewtonMeters(quantity.Quantity);
				public static TQuantity FootPounds(this TStorage value) => TQuantity.Create(Convert.FromFootPounds(value));
				public static TStorage FootPounds(this TQuantity quantity) => Convert.ToFootPounds(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Torque;
		using TStorage = decimal;
		public record Torque : Torque<TQuantity, TStorage>;

		namespace Conversions.Torque
		{
			public static class Conversions
			{
				public static TQuantity NewtonMeters(this TStorage value) => TQuantity.Create(Convert.FromNewtonMeters(value));
				public static TStorage NewtonMeters(this TQuantity quantity) => Convert.ToNewtonMeters(quantity.Quantity);
				public static TQuantity FootPounds(this TStorage value) => TQuantity.Create(Convert.FromFootPounds(value));
				public static TStorage FootPounds(this TQuantity quantity) => Convert.ToFootPounds(quantity.Quantity);
			}
		}
	}
}
