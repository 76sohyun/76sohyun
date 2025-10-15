using System;
using System.Text;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');
                
                int a = int.Parse(str[0]);
                int b = int.Parse(str[1]);

                if (a == 0 && b == 0)
                {
                    break;
                }
                else
                {
                    sb.Append(a + b + "\n");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}