using System;

public class Example
{
    public static void Main()
    {
        String s;
        string answer = "";

        Console.Clear();
        s = Console.ReadLine();
        char[] b = new char[s.Length];

        string a = s.ToUpper();

        for (int i = 0; i < s.Length; i++)
        {
            if (a[i] == s[i])
            {
             b[i] = char.ToLower(s[i]);
            }
            else
            {
                b[i] = char.ToUpper(s[i]);
            }
        }
        answer = new string(b);

        Console.WriteLine(answer);

    }
}