using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int N);

            for (int i = 0; i < N; i++)
            {
                int mul = i + 1;
                for (int j = 0; j < mul; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }
    }
}