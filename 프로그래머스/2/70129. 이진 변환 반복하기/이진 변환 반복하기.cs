using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        int convert = 0;
        int x_length = 0;
        int zeroNum = 0;
        
        while(s != "1")
        {
            convert++;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == '0')
                {
                    zeroNum++;
                }
            }
            s = s.Replace("0", "");
            x_length = s.Length;
            s = Convert.ToString(x_length, 2);
        }
        answer[0] = convert;
        answer[1] = zeroNum;
        return answer;
    }
}