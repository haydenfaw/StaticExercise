using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tempC = 7;
            var tempF = 15;

            Console.WriteLine($"The conversion of {tempC} Celcius to Farenheit is: {TempConverter.CelsiusToFahrenheit(tempC)} Farenheit");
            Console.WriteLine($"The conversion of {tempF} Farenheit to Celcius is: {TempConverter.FahrenheitToCelsius(tempF)} Celcius");
        }
    }
}
