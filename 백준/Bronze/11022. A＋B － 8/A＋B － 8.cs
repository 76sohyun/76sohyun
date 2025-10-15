using System;
using System.Text;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int T);
            StringBuilder sb = new StringBuilder();
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
                
                sb.Append($"Case #{i + 1}: " + a + " + " + b + " = " + result[count] +"\n");
                
                count++;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}