using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int Num = 0;
            
            Num = Convert.ToInt32(Console.ReadLine());

            if (Num % 4 == 0)
            {
                if (Num % 100 != 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    if (Num % 400 == 0)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}