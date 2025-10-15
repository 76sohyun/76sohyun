using System;
using System.Text;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int number);
            
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < number; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                
                sb.Append(int.Parse(str[0]) + int.Parse(str[1]) + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}