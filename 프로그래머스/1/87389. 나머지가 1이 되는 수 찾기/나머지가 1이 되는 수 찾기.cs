using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int num = 2;
        while(num < n)
        {
            if(n % num == 1)
            {
                answer = num;
                break;
            }
            num ++;
        }
        return answer;
    }
}