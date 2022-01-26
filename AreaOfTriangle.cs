//Problem No: 1
using System;

namespace Csharp_Assignment
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            int side1=5,side2=6,side3=7;
            int perim=(side1+side2+side3)/2; // Used Herons Formula to solve area of triangle
            double area=Math.Sqrt(perim*(perim-side1)*(perim-side2)*(perim-side3));
            Console.WriteLine("Area of Triangle:{0} ",Math.Round(area,3));
        }
    }
}
