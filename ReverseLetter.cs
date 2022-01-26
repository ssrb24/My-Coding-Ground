using System; //Problem No: 22
namespace Csharp_Assignment
{
    class ReverseLetter
    {
        static void Main()
        {
            char firstletter,secondletter,thirdletter;
            Console.WriteLine("Enter  First Letter: ");
            firstletter=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Second Letter: ");
            secondletter=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Third Letter: ");
            thirdletter=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Given letters in reverse: "+thirdletter+", "+secondletter+", "+firstletter);
        }
    }
}