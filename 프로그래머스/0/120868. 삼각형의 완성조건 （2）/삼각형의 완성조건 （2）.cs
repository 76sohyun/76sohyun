using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        // 가장 긴 변이 6일 경우
        if (sides[1] > sides[0])
        {
            for (int i = 1; i <= sides[1]; i++)
            {
                if (sides[0] + i > sides[1])
                {
                    answer++;
                }
            }
            
            // 다른 한변이 가장 긴변인 경우
            for (int i = sides[1] + 1; i < sides[0]+sides[1]; i++)
            {
                answer++;
            }
        }
        else
        {
            for (int i = 1; i <= sides[0]; i++)
            {
                if (sides[1] + i > sides[0])
                {
                    answer++;
                }
            }
            
            // 다른 한변이 가장 긴변인 경우
            for (int i = sides[0] + 1; i < sides[0]+sides[1]; i++)
            {
                answer++;
            }
        }
        return answer;
    }
}