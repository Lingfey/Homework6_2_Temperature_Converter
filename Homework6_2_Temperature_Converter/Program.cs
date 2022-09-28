using System;
using System.Text.RegularExpressions;
namespace Homework6_2_Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("E.g.: 40C to F");
                string request = Console.ReadLine();
                string[] splitRequest = Regex.Split(request, @"([\d.-]+) ?(\w+?) to (\w+?)");
                double initialTemperature = Convert.ToDouble(splitRequest[1]);
                string initialUnit = splitRequest[2];
                string convertedUnit = splitRequest[3];
                switch (convertedUnit)
                {
                    case "k":
                    case "K":
                    case "kelvin":
                    case "Kelvin":
                        Console.WriteLine($"{initialTemperature}{initialUnit}" +
                            $" is {TempConverter.ToKelvin(initialTemperature, initialUnit):0.0}" +
                            $"{convertedUnit}");
                        break;
                    case "C":
                    case "c":
                    case "celsius":
                    case "Celsius":
                        Console.WriteLine($"{initialTemperature}{initialUnit}" +
                            $" is {TempConverter.ToCelsius(initialTemperature, initialUnit):0.0}" +
                            $"{convertedUnit}");
                        break;
                    case "F":
                    case "f":
                    case "fahrenheit":
                    case "Fahrenheit":
                        Console.WriteLine($"{initialTemperature}{initialUnit}" +
                            $" is {TempConverter.ToFahrenheit(initialTemperature, initialUnit):0.0}" +
                            $"{convertedUnit}");
                        break;
                    default:
                        Console.WriteLine("Wrong format");
                        break;
                }
                Console.WriteLine("Try again?(y/n)");
                answer = Console.ReadLine();
            }
            while (answer == "y" || answer == "yes");
          
        }
    }
}