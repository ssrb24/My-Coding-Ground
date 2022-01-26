using System; //Problem No: 12
namespace Csharp_Assignment
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            for(int i=0;i<=15;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i+" is even");
                }
                else if(i%2!=0)
                {
                    Console.WriteLine(i+" is Odd");
                }
            }

        }
    }
    
}