using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int j = 1;
        for (int i = 1; j <= n; i++)
        {
            j *= i;
            answer = i;
            if(j > n)
            {
                answer--;
            }
        }
        return answer;
    }
}