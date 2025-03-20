using System;

public class Solution {
    public int solution(int n, int k) {
        
        int s = (n / 10) * 2000;

        int answer = ((12000 * n) + (2000 * k) - s);
        
        return answer;
    }
}