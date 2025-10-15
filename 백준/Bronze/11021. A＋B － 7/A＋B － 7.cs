using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int T);
            
            int[] result = new int[T];
            int count = 0;
            int a = 0;
            int b = 0;
            
            for (int i = 0; i < T; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                
                a = int.Parse(str[0]);
                b = int.Parse(str[1]);
                
                result[count] = a + b;
                count++;
            }

            for (int i = 0; i < T; i++)
            {
                Console.WriteLine($"Case #{i + 1}: {result[i]}");    
            }
        }
    }
}