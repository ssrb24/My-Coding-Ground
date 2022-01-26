//Problem No: 29
using System;
namespace Csharp_Assignment
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.WriteLine("Enter First Number: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2=Convert.ToInt32(Console.ReadLine());
            char operatr;
            Console.WriteLine("Enter + to Perform Addition: ");
            Console.WriteLine("Enter - to Perform Subtraction: ");
            Console.WriteLine("Enter * to Perform Multiplication: ");
            Console.WriteLine("Enter / to Perform Division: ");
            Console.WriteLine("Enter % to perform Modulus: ");
            operatr=Convert.ToChar(Console.ReadLine());
            switch(operatr)
            {
                case '+':
                Console.WriteLine(num1+num2);
                break;
                case '-':
                Console.WriteLine(num1-num2);
                break;
                case '*':
                Console.WriteLine(num1*num2);
                break;
                case '/':
                Console.WriteLine(num1/num2);
                break;
                case '%':
                Console.WriteLine(num1%num2);
                break;

                default:
                Console.WriteLine("Enter a Valid Operator");
                break;

            }
        }
    }
}