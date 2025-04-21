using System;
using System.Text.RegularExpressions;
public class Solution {
    public int solution(string my_string) {
        string str = Regex.Replace(my_string, @"\D","");
        string[] str2 = new string[str.Length];
        int answer = 0;

        for (int i = 0; i < str.Length; i++)
        {
            str2[i] = str[i].ToString();
        }
        
        Array.Sort(str2);

        for (int i = 0; i < str2.Length; i++)
        {
            answer += Int32.Parse(str2[i]);
        }
        return answer;
    }
}