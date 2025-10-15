using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //처음에 케이스 갯수 입력
            int T = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int[] result = new int[T];
            //갯수 만큼 케이스 작성
            for (int i = 0; i < T; i++)
            {
                string[] Num = Console.ReadLine().Split(' ');   
                
                int Num1 = Convert.ToInt32(Num[0]);
                int Num2 = Convert.ToInt32(Num[1]);

                int Num3 = Num1 + Num2;
                
                result[count] = Num3;
                count++;
            }

            for (int i = 0; i < T; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}