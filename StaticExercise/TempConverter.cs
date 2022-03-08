using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double tempF)
        {
            double tempC = (tempF - 32) / 1.8;
            return tempC;
        }
        public static double CelsiusToFahrenheit(double tempC)
        {
            double tempF = (tempC * 9) / 5 + 32;
            return tempF;
        }
    }
}
