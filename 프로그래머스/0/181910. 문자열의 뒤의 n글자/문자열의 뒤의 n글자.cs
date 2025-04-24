using System;

public class Solution {
    public string solution(string my_string, int n) {
       string answer = "";
        int j = 0;

        char[] chr = new char[my_string.Length];

        for (int i = chr.Length; i > 0; i--)
        {
            chr[j] = my_string[i - 1];
            j++;
        }

        for (int i = n; i > 0 ; i--)
        {
            answer += chr[i - 1];
        }
        return answer;
    }
}