using System; //Problem No: 20
namespace Csharp_Assignment
{
    class Hieght
    {
        static void Main(string[] args)
        {
            int hieght;
            Console.WriteLine("Enter Hieght in Centimetres: ");
            hieght=Convert.ToInt32(Console.ReadLine());
            if(hieght>0)
            {
                if(hieght<135)
                {
                    Console.WriteLine("Dwarf");
                }
                else if(hieght>=135 && hieght<155)
                {
                    Console.WriteLine("Short");
                }
                else if(hieght>=155 && hieght<165)
                {
                    Console.WriteLine("Average");
                }
                else if(hieght>=165 && hieght<170)
                {
                    Console.WriteLine("Hieght");
                }
                else if(hieght>170 && hieght <300)
                {
                    Console.WriteLine("Tallest");
                }
                else
                {
                    Console.WriteLine("Enter a Valid Hieght");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}