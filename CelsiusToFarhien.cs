//Problem No: 4
using System;
namespace Csharp_Assignment
{
    class CelsiusToFarhien
    {
        static void Main(string[] args)
        {
            double celsiustemp,fahrentemp;
            Console.Write("Enter the Temparature in Celsius: "); 
            celsiustemp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Temperature in Fahrenheit = {0}", Math.Round((9*celsiustemp+(32*5))/5,2));

            Console.Write("Enter the Temparature of Fahrenheit: "); 
            fahrentemp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Temperature in Celsius = {0}", Math.Round((5*(fahrentemp-32)/9),2));
        }
    }
}