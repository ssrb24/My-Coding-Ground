using System; //Problem No: 23
namespace Csharp_Assignment
{
    class CircleArea
    {
        static void Main(string[] args)
        {
            int radius;
            Console.WriteLine("Enter Radius of Circle: ");
            radius=Convert.ToInt32(Console.ReadLine());
            double perimeter=Math.Round(2*Math.PI*(radius),2);
            double area=Math.Round(Math.PI*(Math.Pow(radius,2)),2);
            Console.WriteLine("Perimeter of Circle: "+perimeter);
            Console.WriteLine("Area of Circle: "+area);
        }
    }
}