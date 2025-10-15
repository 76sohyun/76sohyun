using System;
using System.Linq;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] game = Console.ReadLine().Split(' ');

            int Num1 = int.Parse(game[0]);
            int Num2 = int.Parse(game[1]);
            int Num3 = int.Parse(game[2]);
            
            int[] NumArray = game.Select(int.Parse).ToArray(); //숫자 변환
            
            if (Num1 == Num2 && Num2 == Num3) //눈이 3개일 경우
            {
                Console.WriteLine($"{10000 + (Num1 * 1000)}");
            }
            else if (Num1 == Num2 || Num3 == Num1 || Num3 == Num2)
            {
                if (Num1 == Num3 || Num3 == Num2)
                {
                    Console.WriteLine($"{1000 + (Num3 * 100)}");    
                }
                else
                {
                    Console.WriteLine($"{1000 + (Num2 * 100)}");    
                }
            }
            else
            {
                Array.Sort(NumArray); //오름차순
                Console.WriteLine($"{NumArray[2] * 100}");
            }
        }
    }
}