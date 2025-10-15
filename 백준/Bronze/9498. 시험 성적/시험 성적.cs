using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int score = 0;
            
            score = Convert.ToInt32(Console.ReadLine());

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80 && score < 90)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70 && score < 80)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60 && score < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}