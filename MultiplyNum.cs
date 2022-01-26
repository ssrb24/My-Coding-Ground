using System; //Problem No: 16
namespace Csharp_Assignment
{
    class MultiplyNum
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;
            Console.WriteLine("Enter First Number: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number: ");
            num3=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Multiplication Of Three Numbers: "+(num1*num2*num3));
        }
    }
}