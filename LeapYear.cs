using System; //Problem No: 2
namespace Csharp_Assignment
{
        class LeapYear
        {
            static void Main(string[] args)
            {
                int year;

                Console.WriteLine("Enter Year to check its leap year or not A/C to Gregorian Calendar");
                year=Convert.ToInt32(Console.ReadLine());
                if(year%4==0)
                {
                    if(year%100==0)
                    {
                        if(year%400==0)
                        {
                            Console.WriteLine("Given Year is a leap year");
                        }
                        else
                        {
                            Console.WriteLine("Given Year is Not leap year");

                        }

                    }
                    else
                    {
                         Console.WriteLine("Given Year is a leap year");
                    }

                }
                else
                {
                    Console.WriteLine("Given Year is not leap year");

                }
            }
        }
        
}


