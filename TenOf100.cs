using System; //Problem No: 27
namespace Csharp_Assignment
{
    class TenOf100
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number: ");
            num=Convert.ToInt32(Console.ReadLine());
            if((num>90 && num<110) || (num>190 && num<210) )
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