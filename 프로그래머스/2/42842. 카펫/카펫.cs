using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        for(int i = 1; i <= (i == 1 ? 1 : yellow/2); i++)
        {
            if(yellow % i == 0)
            {
                int h = i; //높이
                int w = yellow / i; //가로
                int totalB = (w * 2) + ((h + 2) * 2);
                if(totalB == brown)
                {
                    answer[0] = Math.Max(h + 2, w + 2); // 가로
                    answer[1] = Math.Min(h + 2, w + 2); // 세로
                }    
            }
        }
        return answer;
    }
}