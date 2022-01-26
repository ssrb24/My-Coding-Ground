using System; //Problem No: 21
namespace Csharp_Assignment
{
    class Quadractic
    {
        static void Main(string[] args)
        {
            double a,b,c,result1,result2,denom;
            Console.WriteLine("Enter a value: ");
            a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b value: ");
            b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c value: ");
            c=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            denom=(b*b-4*a*c);
            if(denom==0)
            {
                Console.WriteLine("Roots are Equal");
            }
            else if(denom>0)
            {
                result1=(-b+Math.Sqrt(denom))/2*a;
                result2=(-b-Math.Sqrt(denom))/2*a;
                Console.WriteLine("Roots are Real and roots are"+Math.Round(result1,2)+"and "+Math.Round(result2),3);
            }
            else
            {
                Console.WriteLine("Roots are Imaginary");
            }
            
        }
    }
}