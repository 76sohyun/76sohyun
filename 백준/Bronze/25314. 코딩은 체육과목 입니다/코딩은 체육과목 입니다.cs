using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int number);

            int nbyte = number / 4;

            for (int i = 0; i < nbyte; i++)
            {
                Console.Write("long ");
            }
            Console.Write("int");
        }
    }
}