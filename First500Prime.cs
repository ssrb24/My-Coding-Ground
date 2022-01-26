using System; //Problem No: 17
namespace Csharp_Assignment
{
    class First500Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSum of the first 500 prime numbers: ");
            long sum = 0;
            int count = 0,num = 2;
            while (count < 500)
            {
                if (isPrime(num))
                {
                    sum += num;
                    count++;
                }
                num++;
            }
            Console.WriteLine("Sum of First 500 Prime Numbers: "+sum);
        }
        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1)
            {
                return false;
            }
            
            if (n == 2)
            {
                return true;
            }

            for (int i = 2; i <= x; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}