using System; //Problem No: 18
namespace Csharp_Assignment
{
    class Multiple
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter First Number: ");
            num=Convert.ToInt32(Console.ReadLine());
            if(num>=0)
            {
                if((num%3==0) || (num%7==0))
                {
                    Console.WriteLine("Given positive number is a multiple of 3 or a multiple of 7");
                }
                else
                {
                    Console.WriteLine("Given positive number is NOT a multiple of 3 or 7");
                }

            }
            else
            {
                Console.WriteLine("please enter a positive number");

            }

        }

    }
}