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
            const double PI = 3.14159;
            Console.WriteLine("Enter the radius: ");
            String r = Console.ReadLine();
            double radius = Convert.ToDouble(r);

            double circumference = 2 * PI * radius;
            double area = PI * (radius * radius);
            double volume = (((4 / 3) * PI * (radius * radius * radius)) / 2);

            Console.WriteLine("Circumference = " + circumference + "\nArea = " + area + "\nVolume = " + volume);
        }
    }
}
