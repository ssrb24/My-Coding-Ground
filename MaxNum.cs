using System; //Problem No: 8
namespace Csharp_Assignment
{
    class MaxNum
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.WriteLine("Enter First Number: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Larger Number is: "+Math.Max(num1,num2));
        }
    }
}