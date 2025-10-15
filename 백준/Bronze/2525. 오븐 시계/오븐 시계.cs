using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int minutes = 0;
            string[] time = Console.ReadLine().Split(' ');
            minutes = Convert.ToInt32(Console.ReadLine());

            int Num1 = int.Parse(time[0]);
            int Num2 = int.Parse(time[1]);
            int result = 0; // 결과 값

            if (Num1 > 0)
            {
                Num1 *= 60;
                result = (Num1 + Num2) + minutes;
                
                if (result / 60 >= 24)
                {
                    int hours = (result / 60) - 24;
                    Console.WriteLine($"{hours} {result % 60}");
                }
                else
                {
                    Console.WriteLine($"{result /  60} {result % 60}");    
                }
            }
            else
            {
                result = (1440 + Num2) + minutes;

                if (result / 60 >= 24)
                {
                    int hours = (result / 60) - 24;
                    Console.WriteLine($"{hours} {result % 60}");
                }
                else
                {
                    Console.WriteLine($"{result /  60} {result % 60}");    
                }
            }
        }
    }
}