# ktsu.PhysicalQuantity

`PhysicalQuantity` is a .NET library that provides a robust framework for working with physical quantities, supporting a wide range of units and conversions.

## Features

- **Comprehensive Unit Support**: Supports a wide range of physical quantities including length, mass, time, energy, and more.
- **Accurate Conversions**: Provides accurate unit conversions for each quantity.
- **Significant Numbers**: Uses the SignificantNumber library to maintain precision in calculations.
- **Extensibility**: Easily extendable to support custom units and quantities.

## Installation

To install PhysicalQuantity, run the following command in your .NET project:

```bash
dotnet add package ktsu.PhysicalQuantity
```

## Usage

### Basic Example

```csharp
using ktsu.PhysicalQuantity.Length;
using ktsu.SignificantNumber;

Length lengthInMeters = 100.Meters();
float lengthInKilometers = lengthInMeters.Kilometers<float>();

Console.WriteLine($"{lengthInMeters} is equal to {lengthInKilometers} kilometers");
```

### Supported Quantities

- Acceleration
- AmountOfSubstance
- Angle
- AngularAcceleration
- AngularVelocity
- Area
- Density
- ElectricCurrent
- ElectricPotential
- Energy
- Force
- Illuminance
- Jerk
- Length
- LuminousFlux
- LuminousIntensity
- Mass
- Power
- Pressure
- Resistance
- Temperature
- Time
- Torque
- Velocity
- Volume

### Example Conversion

```csharp
using ktsu.PhysicalQuantity.Mass;
using ktsu.SignificantNumber;

Mass massInKilograms = 70.Kilograms();
float massInPounds = massInKilograms.Pounds<float>();

Console.WriteLine($"{massInKilograms} is equal to {massInPounds} pounds");
```

### Integrating and Deriving Quantities

The `PhysicalQuantity` library supports operations for integrating and deriving physical quantities, making it easier to work with quantities that result from these operations.

#### Deriving Quantities

To derive a quantity, you can use the appropriate operators provided by the `IIntegrationOperators` interface. For example, deriving velocity from distance and time:

```csharp
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Time;
using ktsu.PhysicalQuantity.Velocity;
using ktsu.SignificantNumber;

Length distance = 100.Meters();
Time time = 10.Seconds();
Velocity velocity = distance / time;

Console.WriteLine($"Velocity: {velocity}"); // Output: Velocity: 10 m/s
```

#### Integrating Quantities

To integrate quantities, you can use the appropriate operators. For example, integrating acceleration over time to get velocity:

```csharp
using ktsu.PhysicalQuantity.Acceleration;
using ktsu.PhysicalQuantity.Time;
using ktsu.PhysicalQuantity.Velocity;
using ktsu.SignificantNumber;

Acceleration acceleration = 9.8.MetersPerSecondSquared();
Time time = 5.Seconds();
Velocity velocity = acceleration * time;

Console.WriteLine($"Velocity: {velocity}"); // Output: Velocity: 49 m/s
```

### Example

Here's a more comprehensive example that demonstrates both integration and derivation:

```csharp
using ktsu.PhysicalQuantity.Acceleration;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Time;
using ktsu.PhysicalQuantity.Velocity;
using ktsu.SignificantNumber;

Length initialDistance = 0.Meters();
Velocity initialVelocity = 0.MetersPerSecond();
Acceleration acceleration = 9.8.MetersPerSecondSquared();
Time time = 10.Seconds();

// Calculate final velocity: v = u + at
Velocity finalVelocity = initialVelocity + acceleration * time;

// Calculate distance traveled: s = ut + 0.5 * a * t^2
Length distance = initialVelocity * time + 0.5 * acceleration * time * time;

Console.WriteLine($"Final Velocity: {finalVelocity}"); // Output: Final Velocity: 98 m/s
Console.WriteLine($"Distance Traveled: {distance}");   // Output: Distance Traveled: 490 m
```

By using these integration and derivation methods, you can handle a wide range of physical calculations with ease.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For questions or feedback, please open an issue on GitHub.
