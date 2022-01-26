using System; //Problem No: 15
namespace Csharp_Assignment
{
    class SwapNum
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.WriteLine("Enter First Number: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2=Convert.ToInt32(Console.ReadLine());
            swap(num1,num2);
            
        }
        static void swap(int a,int b)
        {
            a=a*b;   
            b=a/b; 
            a=a/b; 
            Console.WriteLine("After Swaping "+a+" "+b); 

        }
    }
}