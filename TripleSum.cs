using System; //Problem No: 25
namespace Csharp_Assignment
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            long num1,num2,sum;
            Console.WriteLine("Enter First Number: ");
            num1=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2=Convert.ToInt64(Console.ReadLine());
            sum=num1+num2;
            if(num1.Equals(num2))
            {
                Console.WriteLine("Given two numbers are SAME and triple their sum is: "+sum*3);
            }
            else
            {
                Console.WriteLine(sum);
            }
            
        }
        
    }
}