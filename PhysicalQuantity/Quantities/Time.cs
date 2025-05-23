// Copyright (c) ktsu.dev
// All rights reserved.
// Licensed under the MIT license.

namespace ktsu.PhysicalQuantity.Time;

using System.Numerics;

using ktsu.PhysicalQuantity.Acceleration;
using ktsu.PhysicalQuantity.Angle;
using ktsu.PhysicalQuantity.AngularAcceleration;
using ktsu.PhysicalQuantity.AngularVelocity;
using ktsu.PhysicalQuantity.Charge;
using ktsu.PhysicalQuantity.ElectricCurrent;
using ktsu.PhysicalQuantity.Energy;
using ktsu.PhysicalQuantity.Generic;
using ktsu.PhysicalQuantity.Jerk;
using ktsu.PhysicalQuantity.Length;
using ktsu.PhysicalQuantity.Power;
using ktsu.PhysicalQuantity.Velocity;

/// <summary>
/// Represents a time quantity measured in seconds, minutes, hours, and days.
/// </summary>
[SIUnit("s", "second", "seconds")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "<Pending>")]
public sealed record Time
	: PhysicalQuantity<Time>
	, IIntegralOperators<Time, Acceleration, Velocity>
	, IIntegralOperators<Time, Velocity, Length>
	, IIntegralOperators<Time, Jerk, Acceleration>
	, IIntegralOperators<Time, Power, Energy>
	, IIntegralOperators<Time, AngularAcceleration, AngularVelocity>
	, IIntegralOperators<Time, AngularVelocity, Angle>
	, IIntegralOperators<Time, ElectricCurrent, Charge>
{
	/// <summary>
	/// Multiplies a <see cref="Time"/> instance with an <see cref="Acceleration"/> instance
	/// to compute the resulting <see cref="Velocity"/>.
	/// </summary>
	/// <param name="left">The time quantity.</param>
	/// <param name="right">The acceleration quantity.</param>
	/// <returns>The resulting velocity.</returns>
	public static Velocity operator *(Time left, Acceleration right) =>
		IIntegralOperators<Time, Acceleration, Velocity>.Integrate(left, right);

	/// <summary>
	/// Multiplies a <see cref="Time"/> instance with a <see cref="Jerk"/> instance
	/// to compute the resulting <see cref="Acceleration"/>.
	/// </summary>
	/// <param name="left">The time quantity.</param>
	/// <param name="right">The jerk quantity.</param>
	/// <returns>The resulting acceleration.</returns>
	public static Acceleration operator *(Time left, Jerk right) =>
		IIntegralOperators<Time, Jerk, Acceleration>.Integrate(left, right);

	/// <summary>
	/// Multiplies a <see cref="Time"/> instance with a <see cref="Power"/> instance
	/// to compute the resulting <see cref="Energy"/>.
	/// </summary>
	/// <param name="left">The time quantity.</param>
	/// <param name="right">The power quantity.</param>
	/// <returns>The resulting energy.</returns>
	public static Energy operator *(Time left, Power right) =>
		IIntegralOperators<Time, Power, Energy>.Integrate(left, right);

	/// <summary>
	/// Multiplies a <see cref="Time"/> instance with a <see cref="Velocity"/> instance
	/// to compute the resulting <see cref="Length"/>.
	/// </summary>
	/// <param name="left">The time quantity.</param>
	/// <param name="right">The velocity quantity.</param>
	/// <returns>The resulting length.</returns>
	public static Length operator *(Time left, Velocity right) =>
		IIntegralOperators<Time, Velocity, Length>.Integrate(left, right);

	/// <summary>
	/// Multiplies a <see cref="Time"/> instance with an <see cref="AngularAcceleration"/> instance
	/// to compute the resulting <see cref="AngularVelocity"/>.
	/// </summary>
	/// <param name="left">The time quantity.</param>
	/// <param name="right">The angular acceleration quantity.</param>
	/// <returns>The resulting angular velocity.</returns>
	public static AngularVelocity operator *(Time left, AngularAcceleration right) =>
		IIntegralOperators<Time, AngularAcceleration, AngularVelocity>.Integrate(left, right);

	/// <summary>
	/// Multiplies a <see cref="Time"/> instance with an <see cref="AngularVelocity"/> instance
	/// to compute the resulting <see cref="Angle"/>.
	/// </summary>
	/// <param name="left">The time quantity.</param>
	/// <param name="right">The angular velocity quantity.</param>
	/// <returns>The resulting angle.</returns>
	public static Angle operator *(Time left, AngularVelocity right) =>
		IIntegralOperators<Time, AngularVelocity, Angle>.Integrate(left, right);

	/// <summary>
	/// Multiplies a <see cref="Time"/> instance with an <see cref="ElectricCurrent"/> instance
	/// to compute the resulting <see cref="Charge"/>.
	/// </summary>
	/// <param name="left">The time quantity.</param>
	/// <param name="right">The electric current quantity.</param>
	/// <returns>The resulting charge.</returns>
	public static Charge operator *(Time left, ElectricCurrent right) =>
		IIntegralOperators<Time, ElectricCurrent, Charge>.Integrate(left, right);
}

/// <summary>
/// Provides extension methods for converting values to and from <see cref="Time"/>.
/// </summary>
public static class TimeConversions
{
	/// <summary>
	/// Converts a numeric value to <see cref="Time"/> measured in seconds.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Time"/> instance representing the specified value in seconds.</returns>
	public static Time Seconds<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Time>();

	/// <summary>
	/// Converts a <see cref="Time"/> value to a numeric value measured in seconds.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Time"/> value to convert.</param>
	/// <returns>The numeric value representing the time in seconds.</returns>
	public static TNumber Seconds<TNumber>(this Time value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber().To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Time"/> measured in minutes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Time"/> instance representing the specified value in minutes.</returns>
	public static Time Minutes<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Time>(Constants.MinutesToSecondsFactor);

	/// <summary>
	/// Converts a <see cref="Time"/> value to a numeric value measured in minutes.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Time"/> value to convert.</param>
	/// <returns>The numeric value representing the time in minutes.</returns>
	public static TNumber Minutes<TNumber>(this Time value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.MinutesToSecondsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Time"/> measured in hours.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Time"/> instance representing the specified value in hours.</returns>
	public static Time Hours<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Time>(Constants.HoursToSecondsFactor);

	/// <summary>
	/// Converts a <see cref="Time"/> value to a numeric value measured in hours.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Time"/> value to convert.</param>
	/// <returns>The numeric value representing the time in hours.</returns>
	public static TNumber Hours<TNumber>(this Time value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.HoursToSecondsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Time"/> measured in days.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Time"/> instance representing the specified value in days.</returns>
	public static Time Days<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Time>(Constants.DaysToSecondsFactor);

	/// <summary>
	/// Converts a <see cref="Time"/> value to a numeric value measured in days.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Time"/> value to convert.</param>
	/// <returns>The numeric value representing the time in days.</returns>
	public static TNumber Days<TNumber>(this Time value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.DaysToSecondsFactor).To<TNumber>();

	/// <summary>
	/// Converts a numeric value to <see cref="Time"/> measured in years.
	/// </summary>
	/// <typeparam name="TNumber">The numeric type of the value.</typeparam>
	/// <param name="value">The value to convert.</param>
	/// <returns>A <see cref="Time"/> instance representing the specified value in years.</returns>
	public static Time Years<TNumber>(this TNumber value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToQuantity<TNumber, Time>(Constants.YearsToSecondsFactor);

	/// <summary>
	/// Converts a <see cref="Time"/> value to a numeric value measured in years.
	///  </summary>
	/// <typeparam name="TNumber">The numeric type of the result.</typeparam>
	/// <param name="value">The <see cref="Time"/> value to convert.</param>
	/// <returns>The numeric value representing the time in years.</returns>
	public static TNumber Years<TNumber>(this Time value)
		where TNumber : INumber<TNumber>
		=> value.ConvertToNumber(Constants.YearsToSecondsFactor).To<TNumber>();
}
