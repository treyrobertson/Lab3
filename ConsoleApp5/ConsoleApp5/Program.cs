using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double Celsius = (fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine("Temperature in Celsius is {0}: ", Celsius);
            Console.ReadLine();
            if (fahrenheit >= 90)
                Console.WriteLine("It is hot");
            if (fahrenheit <= 40)
                Console.WriteLine("It is cold");
        }
    }
}
