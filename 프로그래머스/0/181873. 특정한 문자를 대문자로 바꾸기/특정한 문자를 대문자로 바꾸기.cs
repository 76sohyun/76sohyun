using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string answer = "";
        foreach (char check in my_string)
        {
            if (alp[0] == check)
            {
                answer += alp.ToUpper();
            }
            else
            {
                answer += check;
            }    
        }
            return answer;
    }
}