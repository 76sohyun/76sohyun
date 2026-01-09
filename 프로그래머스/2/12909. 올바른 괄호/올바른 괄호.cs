using System;
using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {
        bool answer = true;
        Stack<Char> sta = new Stack<Char>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
                sta.Push('a');
            }
            else
            {
                if(sta.Count == 0)
                {
                    answer = false;
                    return answer;
                }
                sta.Pop();
            }
        }
        if(sta.Count != 0)
        {
            answer = false;
        }
        return answer;
    }
}