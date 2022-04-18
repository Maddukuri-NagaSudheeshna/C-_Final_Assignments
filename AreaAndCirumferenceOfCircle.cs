using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        public static void console(double r)
        {
            Console.WriteLine("here we get area and circumference of circle");
            double pie = 3.142;
            double areaOfCircle = pie * r * r;
            double circumferenceOfCircle = 2* pie * r;
            Console.WriteLine("Area of the circle = {0} ", + areaOfCircle);
            Console.WriteLine("circumference of the circle = {0} ", + circumferenceOfCircle);         
        }
        public static void Main(string[] args)
        {
            console(22);

        }
    }
}
