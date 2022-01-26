using System; //Problem No: 14
namespace Csharp_Assignment
{
    class PrimeInRange
    {
        static void Main(string[] args)
        {
            int start,end,count;
            Console.WriteLine("Enter starting Number: ");
            start=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ending Number: ");
            end=Convert.ToInt32(Console.ReadLine());
            for(int i=start;i<=end;i++)
            {
                count=0;
                for(int j=2;j<=i/2;j++)
                {
                    if(i%j==0)
                    {
                        count++;
                        break;
                    }

                }
                if(count==0 && i!=1)
                {
                    Console.Write(i);
                    Console.Write(", ");
                }
            }
            
        }
    }
}