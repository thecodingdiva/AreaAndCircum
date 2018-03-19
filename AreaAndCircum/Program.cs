using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndCircum
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            Console.WriteLine("Enter the radius: ");
            double radius = Console.Read();

            double circumference = 2 * pi * radius;
            double area = pi * (radius * radius);

            Console.WriteLine("Circumference = " + circumference + "/nArea = " + area);


        }
    }
}
