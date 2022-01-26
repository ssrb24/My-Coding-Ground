using System; //Problem No: 5
namespace Csharp_Assignment
{
    class CheckNum
    {
        static void Main(string[] args)
        {
            CheckNum check=new CheckNum();

            if(check.CheckNumber())
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            
        }
        public bool CheckNumber()
        {
            int num1,num2;
            Console.WriteLine("Enter First Number: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2=Convert.ToInt32(Console.ReadLine());
            if((num1==50 || num2==50) || (num1+num2==50))
            {
                return true;
            }
            else
            {
                return false;

            }

        }
    }
}