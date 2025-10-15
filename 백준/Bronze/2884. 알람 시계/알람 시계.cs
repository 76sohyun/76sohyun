using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split(' ');
            
            int Num1 = int.Parse(time[0]);
            int Num2 = int.Parse(time[1]);
            int result = 0; // 결과 값
            
            // -시를 분으로 변환
            if (Num1 > 0)
            {
                Num1 *= 60;
                //전체 분에서 45분 빼기
                result =  (Num1 + Num2) - 45;
                
                // 합치고 -시 -분으로 변환
                Console.WriteLine($"{result / 60} {result % 60}");
            }
            else
            {
                result = (1440 + Num2) - 45;

                if (result / 60 == 24)
                {
                    Console.WriteLine($"{0} {result % 60}");
                }
                else
                {
                    Console.WriteLine($"{result / 60} {result % 60}");    
                }
            }
        }
    }
}