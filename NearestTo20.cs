using System; //Problem No: 19
namespace Csharp_Assignment
{
    class NearestTo20
    {
        static void Main(string[] args)
        {
            long num1,num2;
            Console.WriteLine("Enter First Number: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2=Convert.ToInt32(Console.ReadLine());
            int n=20;
            var value1=Math.Abs(num1-n);
            var value2=Math.Abs(num2-n);
            Console.WriteLine("Nearest Number to 20: {0} ",(num1==num2)?0:(value1<value2?num1:num2));
            
        }
    }
}