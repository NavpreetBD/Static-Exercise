using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double fTemp)
        {
            double celcius = (fTemp - 32) * 5 / 9;
            Console.WriteLine(celcius);
            return celcius;
        }
        public static double CelsiusToFahrenheit(double cTemp)
        {
            double fahrenheit = (cTemp * 9) / 5 + 32;
            Console.WriteLine(fahrenheit);
            return fahrenheit;
        }
        
    }
}
