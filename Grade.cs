using System; //Problem No: 13
namespace Csharp_Assignment
{
    class Grade
    {
        static void Main(string[] args)
        {
            int avg,sum=0;
            int[] marks=new int[]{80,77,88,95,68};
            for(int i=0;i<marks.Length;i++)
            {
                sum=sum+marks[i];
            }
            avg=sum/marks.Length;
            switch(avg/10)
            {
                case 10:
                case 9:
                Console.WriteLine("A");
                break;

                case 8:
                Console.WriteLine("B");
                break;

                case 7:
                Console.WriteLine("C");
                break;

                case 6:
                Console.WriteLine("D");
                break;

                default:
                Console.WriteLine("F");
                break;
            }
            /*switch(avg>=90 && avg <100)
            {
                case true:
                Console.WriteLine("A");
                break;

            }
            switch(avg>=80 && avg <90)
            {
                case true:
                Console.WriteLine("B");
                break;

            }
            switch(avg>=70 && avg <80)
            {
                case true:
                Console.WriteLine("c");
                break;

            }
            switch(avg>=60 && avg <70)
            {
                case true:
                Console.WriteLine("D");
                break;

            }
            switch(avg<60)
            {
                case true:
                Console.WriteLine("F");
                break;

            }*/
        }
    }
}