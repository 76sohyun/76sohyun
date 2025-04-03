using System;

public class Solution {
    public string solution(string rsp) {
        string answer = "";
        char[] check = rsp.ToCharArray();
            for (int i = 0; i < check.Length; i++)
            {
                if (check[i] == '2')
                {
                    answer += "0";
                }
                else if (check[i] == '0')
                {
                    answer += "5";
                }
                else 
                {
                    answer += "2";
                }
            }
        return answer;
    }
}