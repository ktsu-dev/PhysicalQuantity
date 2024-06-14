# ktsu.io.PhysicalQuantity

`PhysicalQuantity` is a .NET library that provides a robust framework for working with physical quantities, supporting a wide range of units and conversions.

## Features

- **Comprehensive Unit Support**: Supports a wide range of physical quantities including length, mass, time, energy, and more.
- **Accurate Conversions**: Provides accurate unit conversions for each quantity.
- **Significant Numbers**: Uses the SignificantNumber library to maintain precision in calculations.
- **Extensibility**: Easily extendable to support custom units and quantities.

## Installation

To install PhysicalQuantity, run the following command in your .NET project:

```bash
dotnet add package ktsu.io.PhysicalQuantity
```

## Usage

### Basic Example

```csharp
using ktsu.io.PhysicalQuantity.Length;
using ktsu.io.SignificantNumber;

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
using ktsu.io.PhysicalQuantity.Mass;
using ktsu.io.SignificantNumber;

Mass massInKilograms = 70.Kilograms();
float massInPounds = massInKilograms.Pounds<float>();

Console.WriteLine($"{massInKilograms} is equal to {massInPounds} pounds");
```

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For questions or feedback, please open an issue on GitHub.
