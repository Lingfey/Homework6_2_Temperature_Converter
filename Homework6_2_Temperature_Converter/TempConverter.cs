using System;
namespace Homework6_2_Temperature_Converter
{
    public class TempConverter
    {
        public static double? ToCelsius(double temperature, string initialUnit)
        {
            switch (initialUnit)
            {
                case "F":
                case "f":
                case "fahrenheit":
                case "Fahrenheit":
                    return (temperature - 32) * 0.5556;
                case "K":
                case "k":
                case "kelvin":
                case "Kelvin":
                    return temperature - 273.15;
                default:
                    return null;
            }
        }
        public static double? ToFahrenheit(double temperature, string initialUnit)
        {
            switch (initialUnit)
            {
                case "C":
                case "c":
                case "celsius":
                case "Celsius":
                    return temperature * 1.8 + 32;
                case "K":
                case "k":
                case "kelvin":
                case "Kelvin":
                    return (temperature - 273.15) * 1.8 + 32;
                default:
                    return null;
            }
        }
        public static double? ToKelvin(double temperature, string initialUnit)
        {
            switch (initialUnit)
            {
                case "C":
                case "c":
                case "celsius":
                case "Celsius":
                    return temperature + 273.15;
                case "F":
                case "f":
                case "fahrenheit":
                case "Fahrenheit":
                    return (temperature - 32) * 0.5556 + 273.15;
                default:
                    return null;
            }
        }
    }
}

