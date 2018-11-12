using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedlimit;
            int speed;

            speedlimit = 35;
            speed = 42;

            if (speed > speedlimit)
            {
                Console.WriteLine("SLOW NOW");
            }
        }
    }
}
