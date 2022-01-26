//Problem No: 26
using System;
namespace Csharp_Assignment
{
    class AbsDiff
    {
        
        static void Main(string[] args)
        {
            long absdiff,n;
            Console.WriteLine("Enter Number: ");
            n=Convert.ToInt64(Console.ReadLine());
            int num=51;
            absdiff=Math.Abs(n-51);
            if(n>num)
            {
                Console.WriteLine("Given n is greater than 51 and triple their Absolute difference is: "+3*absdiff);
            }
            else
            {
                Console.WriteLine("Absolute Difference is: "+absdiff);

            }

        }
    }
}