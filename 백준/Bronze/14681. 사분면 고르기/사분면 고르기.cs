using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int Num1 = 0;
            int Num2 = 0;
            
            Num1 = Convert.ToInt32(Console.ReadLine());
            Num2 = Convert.ToInt32(Console.ReadLine());

            if (Num1 > 0)
            {
                if (Num2 > 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(4);
                }
            }
            else if (Num1 < 0)
            {
                if (Num2 > 0)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(3);
                }
            }
        }
    }
}