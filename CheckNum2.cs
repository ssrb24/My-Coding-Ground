using System; //Problem No: 7
namespace Csharp_Assignment
{
    class CheckNum2
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.WriteLine("Enter First Number: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2=Convert.ToInt32(Console.ReadLine());
            if((num1==15 || num2==15) || ((num1+num2==15) || (num1-num2==15)))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");

            }
        }
    }
}