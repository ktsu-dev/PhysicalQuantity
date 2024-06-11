// Ignore Spelling: ktsu

namespace ktsu.io.PhysicalQuantity
{
	using System.Numerics;
	using Convert = Generic.TemperatureConversions;

	namespace Generic
	{
		[SIUnit("K", "kelvin", "kelvins")]
		public record Temperature<TSelf, TStorage>
			: PhysicalQuantity<TSelf, TStorage>
			where TSelf : Temperature<TSelf, TStorage>, new()
			where TStorage : INumber<TStorage>
		{ }

		public static class TemperatureConversions
		{
			public static TStorage FromKelvins<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 0);
			public static TStorage ToKelvins<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 0);
			public static TStorage FromCelsius<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 1, 273.15);
			public static TStorage ToCelsius<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 1, 273.15);
			public static TStorage FromFahrenheit<TStorage>(TStorage value)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToSIQuantity(value, 5 / 9.0, 255.3722222222222);
			public static TStorage ToFahrenheit<TStorage>(TStorage quantity)
				where TStorage : INumber<TStorage>
				=> PhysicalQuantity.ConvertToArbitraryQuantity(quantity, 5 / 9.0, 255.3722222222222);
		}
	}

	namespace Single
	{
		using Generic;
		using TQuantity = Temperature;
		using TStorage = float;
		public record Temperature : Temperature<TQuantity, TStorage>;

		namespace Conversions.Temperature
		{
			public static class Conversions
			{
				public static TQuantity Kelvins(this TStorage value) => TQuantity.Create(Convert.FromKelvins(value));
				public static TStorage Kelvins(this TQuantity quantity) => Convert.ToKelvins(quantity.Quantity);
				public static TQuantity Celsius(this TStorage value) => TQuantity.Create(Convert.FromCelsius(value));
				public static TStorage Celsius(this TQuantity quantity) => Convert.ToCelsius(quantity.Quantity);
				public static TQuantity Fahrenheit(this TStorage value) => TQuantity.Create(Convert.FromFahrenheit(value));
				public static TStorage Fahrenheit(this TQuantity quantity) => Convert.ToFahrenheit(quantity.Quantity);
			}
		}
	}

	namespace Double
	{
		using Generic;
		using TQuantity = Temperature;
		using TStorage = double;
		public record Temperature : Temperature<TQuantity, TStorage>;

		namespace Conversions.Temperature
		{
			public static class Conversions
			{
				public static TQuantity Kelvins(this TStorage value) => TQuantity.Create(Convert.FromKelvins(value));
				public static TStorage Kelvins(this TQuantity quantity) => Convert.ToKelvins(quantity.Quantity);
				public static TQuantity Celsius(this TStorage value) => TQuantity.Create(Convert.FromCelsius(value));
				public static TStorage Celsius(this TQuantity quantity) => Convert.ToCelsius(quantity.Quantity);
				public static TQuantity Fahrenheit(this TStorage value) => TQuantity.Create(Convert.FromFahrenheit(value));
				public static TStorage Fahrenheit(this TQuantity quantity) => Convert.ToFahrenheit(quantity.Quantity);
			}
		}
	}

	namespace Decimal
	{
		using Generic;
		using TQuantity = Temperature;
		using TStorage = decimal;
		public record Temperature : Temperature<TQuantity, TStorage>;

		namespace Conversions.Temperature
		{
			public static class Conversions
			{
				public static TQuantity Kelvins(this TStorage value) => TQuantity.Create(Convert.FromKelvins(value));
				public static TStorage Kelvins(this TQuantity quantity) => Convert.ToKelvins(quantity.Quantity);
				public static TQuantity Celsius(this TStorage value) => TQuantity.Create(Convert.FromCelsius(value));
				public static TStorage Celsius(this TQuantity quantity) => Convert.ToCelsius(quantity.Quantity);
				public static TQuantity Fahrenheit(this TStorage value) => TQuantity.Create(Convert.FromFahrenheit(value));
				public static TStorage Fahrenheit(this TQuantity quantity) => Convert.ToFahrenheit(quantity.Quantity);
			}
		}
	}

	namespace Significant
	{
		using Generic;
		using TQuantity = Temperature;
		using TStorage = SignificantNumber.SignificantNumber;
		public record Temperature : Temperature<TQuantity, TStorage>;

		namespace Conversions.Temperature
		{
			public static class Conversions
			{
				public static TQuantity Kelvins(this TStorage value) => TQuantity.Create(Convert.FromKelvins(value));
				public static TStorage Kelvins(this TQuantity quantity) => Convert.ToKelvins(quantity.Quantity);
				public static TQuantity Celsius(this TStorage value) => TQuantity.Create(Convert.FromCelsius(value));
				public static TStorage Celsius(this TQuantity quantity) => Convert.ToCelsius(quantity.Quantity);
				public static TQuantity Fahrenheit(this TStorage value) => TQuantity.Create(Convert.FromFahrenheit(value));
				public static TStorage Fahrenheit(this TQuantity quantity) => Convert.ToFahrenheit(quantity.Quantity);
			}
		}
	}
}
