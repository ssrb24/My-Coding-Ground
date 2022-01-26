using System; //Problem No: 24
namespace Csharp_Assignment
{
    class Speed
    {
        static void Main(string[] args)
        {
            double distance,time;
            Console.WriteLine("Enter Distance in Kms: ");
            distance=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Time in Hours: ");
            time=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Speed in Km/hr: {0}",Math.Round((distance/time),2));
            double speedinmile=((distance/time)/1.609344);
            Console.WriteLine("Speed in Miles/hr: {0}",Math.Round(speedinmile,2));
        }
    }
}