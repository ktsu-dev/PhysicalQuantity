namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.PressureConversions;

	namespace Generic
	{
		[SIUnit("Pa", "pascal", "pascals")]
		public record Pressure<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Pressure<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class PressureConversions
		{
			public static TStorage FromPascals<TStorage>(TStorage value)
			where TStorage : INumber<TStorage>
			=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToPascals<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromKilopascals<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1000, 0);
			public static TStorage ToKilopascals<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1000, 0);
			public static TStorage FromPoundsPerSquareInch<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 6894.76, 0);
			public static TStorage ToPoundsPerSquareInch<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 6894.76, 0);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Pressure;
		using TStorage = float;
		public record Pressure : Pressure<TQuantity, TStorage>;

		namespace Conversions.Pressure
		{
			public static class Conversions
			{
				public static TQuantity Pascals(this TStorage value) => TQuantity.Create(Convert.FromPascals(value));
				public static TStorage Pascals(this TQuantity quantity) => Convert.ToPascals(quantity.Quantity);
				public static TQuantity Kilopascals(this TStorage value) => TQuantity.Create(Convert.FromKilopascals(value));
				public static TStorage Kilopascals(this TQuantity quantity) => Convert.ToKilopascals(quantity.Quantity);
				public static TQuantity PoundsPerSquareInch(this TStorage value) => TQuantity.Create(Convert.FromPoundsPerSquareInch(value));
				public static TStorage PoundsPerSquareInch(this TQuantity quantity) => Convert.ToPoundsPerSquareInch(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Pressure;
		using TStorage = double;
		public record Pressure : Pressure<TQuantity, TStorage>;

		namespace Conversions.Pressure
		{
			public static class Conversions
			{
				public static TQuantity Pascals(this TStorage value) => TQuantity.Create(Convert.FromPascals(value));
				public static TStorage Pascals(this TQuantity quantity) => Convert.ToPascals(quantity.Quantity);
				public static TQuantity Kilopascals(this TStorage value) => TQuantity.Create(Convert.FromKilopascals(value));
				public static TStorage Kilopascals(this TQuantity quantity) => Convert.ToKilopascals(quantity.Quantity);
				public static TQuantity PoundsPerSquareInch(this TStorage value) => TQuantity.Create(Convert.FromPoundsPerSquareInch(value));
				public static TStorage PoundsPerSquareInch(this TQuantity quantity) => Convert.ToPoundsPerSquareInch(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Pressure;
		using TStorage = decimal;
		public record Pressure : Pressure<TQuantity, TStorage>;

		namespace Conversions.Pressure
		{
			public static class Conversions
			{
				public static TQuantity Pascals(this TStorage value) => TQuantity.Create(Convert.FromPascals(value));
				public static TStorage Pascals(this TQuantity quantity) => Convert.ToPascals(quantity.Quantity);
				public static TQuantity Kilopascals(this TStorage value) => TQuantity.Create(Convert.FromKilopascals(value));
				public static TStorage Kilopascals(this TQuantity quantity) => Convert.ToKilopascals(quantity.Quantity);
				public static TQuantity PoundsPerSquareInch(this TStorage value) => TQuantity.Create(Convert.FromPoundsPerSquareInch(value));
				public static TStorage PoundsPerSquareInch(this TQuantity quantity) => Convert.ToPoundsPerSquareInch(quantity.Quantity);
			}
		}
	}
}
