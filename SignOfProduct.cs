using System; //Problem No: 9
namespace Csharp_Assignment
{
    class SignOfProduct
    {
        static void Main(string[] args)
        {
            long num1,num2,num3,product;
            Console.WriteLine("Enter First Number: ");
            num1=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Third Number: ");
            num3=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();
            product=(num1*num2*num3);
            if(product<0)
            {
                Console.WriteLine("Sign of product of three Numbers is: -");
            }
            else
            {
                 Console.WriteLine("Sign of product of three Numbers is: +");
            }
        }
    }
}