using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == null)
                {
                    break;
                }
                string[] str = input.Split(' ');
                
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);

                Console.WriteLine($"{a + b}");
            }
            
        }
    }
}