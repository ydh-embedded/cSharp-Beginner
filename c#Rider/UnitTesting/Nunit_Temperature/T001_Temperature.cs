using NUnit.Framework;
using System;
using Xunit;

namespace Nunit_Temperature
{
    public class TemperatureTests
    {
        // [Fact]
        public void Convert_CelciusToFahrenheit_ConvertsCorrectly()
        {
            // Arrange
            // var converter = new Pro.Temperature;
            var temperature = new Pro.Temperature(20, Pro.Temperature.TemperatureUnit.Celcius);

            // Act
            
            temperature converter;
            var result = converter.Convert(temperature, Pro.Temperature.TemperatureUnit.Fahrenheit);

            // Assert
            Assert.ReferenceAreEqual(68, result.Value);
        }

        // [Fact]
        public void Convert_FahrenheitToCelcius_ConvertsCorrectly()
        {
            // Arrange
            var converter = new Pro.Temperature();
            var temperature = new Pro.Temperature(68, Pro.Temperature.TemperatureUnit.Fahrenheit);

            // Act
            var result = converter.Convert(temperature, Pro.Temperature.TemperatureUnit.Celcius);

            // Assert
            Assert.ReferenceAreEqual(20, result.Value);
        }

        // [Fact]

        public void TestConvert()
        {
            var fromTemperature = new Pro.Temperature(100, Pro.Temperature.TemperatureUnit.Celcius);
            var toTemperature = new Pro.Temperature(Convert(fromTemperature, Pro.Temperature.TemperatureUnit.Fahrenheit), Pro.Temperature.TemperatureUnit.Fahrenheit);
            Assert.ReferenceAreEqual(212, toTemperature.Value);
        }
    }

    public class Pro
    {
        public Temperature Convert(Temperature from, TemperatureUnit to)
        {
            if (from.Unit == TemperatureUnit.Celcius && to == TemperatureUnit.Fahrenheit)
            {
                return new Temperature((9.0 / 5.0) * from.Value + 32, TemperatureUnit.Fahrenheit);
            }

            if (from.Unit == TemperatureUnit.Fahrenheit && to == TemperatureUnit.Celcius)
            {
                return new Temperature((5.0 / 9.0) * (from.Value - 32), TemperatureUnit.Celcius);
            }

            return from;
        }

        public class Temperature
        {
            public Temperature(double value, TemperatureUnit unit)
            {
                Value = value;
                Unit = unit;
            }

            public Temperature(double value)
            {
                Value = value;
                Unit = TemperatureUnit.Celcius;
            }

            public TemperatureUnit Unit { get; }
            public double Value { get; }

            public class TemperatureUnit
            {
                public static TemperatureUnit Celcius { get; set; }
                public static TemperatureUnit Fahrenheit { get; set; }
            }
        }

        public enum TemperatureUnit
        {
            Celcius,
            Fahrenheit
        }
    }
}