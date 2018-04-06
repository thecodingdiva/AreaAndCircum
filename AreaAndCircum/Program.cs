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
            try
            {
                Console.WriteLine("What action would you like to perform: \n1) Circumference of a Circle \n2) Area of a Circle \n3) Volume of a hemisphere: ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option > 3 || option < 0)
                {
                    throw new FormatException("Number not in range.");
                }
                else
                {
                    double radius = GetRadius();

                    if (radius == 0)
                    {
                        throw new Exception("Number cannot be 0");
                    }
                    else
                    {
                        switch (option)
                        {
                            case 1:
                                CircleCircumfrence(radius);
                                break;

                            case 2:
                                CircleArea(radius);
                                break;

                            case 3:
                                HemisphereVolume(radius);
                                break;
                        }
                    }                    
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Your input is invalid");
            }
            catch (Exception e1)
            {
                Console.WriteLine("Input cannot be 0");
            }
            finally
            {
                Console.WriteLine("Your program has terminated");
            }
        }

        static double GetRadius()
        {
            Console.WriteLine("Enter the radius: ");
            String r = Console.ReadLine();
            double radius = Convert.ToDouble(r);
            return radius;
        }

        static double CircleCircumfrence(double radius)
        {
            const double PI = 3.14159;
            double circumference = checked(2 * PI * radius);
            Console.WriteLine("The Circumfrence is: " + circumference);
            return circumference;
        }

        static double CircleArea(double radius)
        {
            const double PI = 3.14159;
            double area = checked(PI * (radius * radius));
            Console.WriteLine("The Area is: " + area);
            return area;
        }

        static double HemisphereVolume(double radius)
        {
            const double PI = 3.14159;
            double volume = checked((((4 / 3) * PI * (radius * radius * radius)) / 2));
            Console.WriteLine("The Volume is: " + volume);
            return volume;
        }
    }
}
