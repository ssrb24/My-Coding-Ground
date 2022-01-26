using System; //Problem No: 3
namespace Csharp_Assignment
{
    class RandomNumber
    {
        
        static void Main(string[] args)
        {
            Random randomnum=new Random();
            int randomnumber=randomnum.Next(1,10);
            //Console.WriteLine(randomnumber);
            Console.WriteLine("Guess a Number in range of 1 to 10");
            int guess=Convert.ToInt16(Console.ReadLine());
            if(guess.Equals(randomnumber))
            {
                Console.WriteLine("Good Work");
            }
            else
            {
                Console.WriteLine("Not Matched");
            }

        }
        
    }
}