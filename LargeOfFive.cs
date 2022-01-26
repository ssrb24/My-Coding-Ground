using System; //Problem No:11
namespace Csharp_Assignment
{
    class LargeOfFive
    {
        static void Main(string[] args)
        {
            int[] nums=new int[5]{99,3,1044,5,6};
            int max=nums[0];
            for(int i=0;i<nums.Length;i++)
            {
                if(max<nums[i])
                {
                    max=nums[i];
                }

            }
            Console.WriteLine("Largest Number in Given Five Numbers: "+max);

            int num1,num2,num3,num4,num5;
            Console.WriteLine("Enter First Number: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number: ");
            num3=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Fourth Number");
            num4=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Fifth Number: ");
            num5=Convert.ToInt32(Console.ReadLine());
            int maxnum=0;
            if(num1>=num2 && num1>=num3 && num1>=num4 && num1>=num5)
            {
                maxnum=num1;
                
            }
            else if(num2>=num3 && num2>=num4 && num2>=num5 && num2>=num1)
            {
                maxnum=num2;
            }
            else if(num3>=num1 && num3>=num2 && num4>=num5 && num3>=num4)
            {
                maxnum=num3;
            }
            else if(num4>=num1 && num4>=num2 && num4>=num3 && num4>=num5)
            {
                maxnum=num4;
            }
            else
            {
                maxnum=num5;
            }

            Console.WriteLine("Largest of Five: "+maxnum);

           
        }
    }
}