using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";

        char[] check = my_string.ToCharArray();

        for(int i = 0; i < check.Length; i++)
        {
            for(int j = 0; j < n; j++)
            {
                answer += check[i];
            }
        }
        return answer;
    }
}