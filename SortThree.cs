using System; //Problem No: 10
namespace Csharp_Assignment
{
    class SortThree
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
            if(num1<=num2 && num1<=num3)
            {
                if(num2<=num3)
                {
                    Console.WriteLine("Sorted Numbers: "+num1+", "+num2+", "+num3);
                }
                else
                {
                    Console.WriteLine("Sorted Numbers: "+num1+", "+num3+","+num2);
                }
            }

            else if(num2<=num1 && num2<=num3)
            {
                if(num1<=num3)
                {
                    Console.WriteLine("Sorted Numbers: "+num2+", "+num1+", "+num3);
                }
                else
                {
                    Console.WriteLine("Sorted Numbers: "+num2+", "+num3+", "+num1);
                }
            }

            else if(num3<=num2 && num3<=num1)
            {
                if(num2<=num1)
                {
                    Console.WriteLine("Sorted Numbers: "+num3+", "+num2+", "+num1);
                }
                else
                {
                    Console.WriteLine("Sorted Numbers: "+num3+", "+num1+", "+num2);
                }
            }
        }
    }
}