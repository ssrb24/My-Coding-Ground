using System; //Problem No: 21
namespace Csharp_Assignment
{
    class Quadrent
    {
        static void Main(string[] args)
        {
            int coordinate1,coordinate2;
            Console.WriteLine("Enter First Coordinate: ");
            coordinate1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Coordinate: ");
            coordinate2=Convert.ToInt32(Console.ReadLine());
            if(coordinate1>=0 && coordinate2>=0)
            {
                Console.WriteLine("lies at First Quadrent");
            }
            else if(coordinate1<=0 && coordinate2>=0)
            {
                Console.WriteLine("lies at Second Quadrent");
            }
            else if(coordinate1<0 && coordinate2<=0)
            {
                Console.WriteLine("lies at Third Quadrent");
            }
            else if(coordinate1>=0 && coordinate2<=0)
            {
                Console.WriteLine("lies at Fourth Quadrent");
            }
        }

    }
}