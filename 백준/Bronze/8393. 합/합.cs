using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 0; i <= Num; i++)
            {
                result += i;
            }
            Console.WriteLine(result);
        }
    }
}