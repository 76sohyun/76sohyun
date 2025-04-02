using System;

public class Solution {
    public string solution(string cipher, int code) {
                string answer = "";
                char[] check = cipher.ToCharArray();
                int a = cipher.Length / code;
        
                for(int i = 1; i <= a; i++)
                {
                    answer += check[(code * i) - 1];
                }
        return answer;
    }
}