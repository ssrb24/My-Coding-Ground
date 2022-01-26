//Problem No: 6
using System;
namespace Csharp_Assignment
{
    class Check3Num
    {
        static void Main(string[] args)
        {
           int num1,num2,num3,result;
            Console.WriteLine("Enter First Number: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number: ");
            num3=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if(num1==num2 && num2==num3 && num3==num1)
            {
                result= 30;
                Console.WriteLine(result);
            }
            else if(num1==num2 || num2==num3 || num3==num1)
            {
                result=40;
                Console.WriteLine(result);
            }
            else
            {
                result=20;
                Console.WriteLine(result);
            }

        }
        
    }
}