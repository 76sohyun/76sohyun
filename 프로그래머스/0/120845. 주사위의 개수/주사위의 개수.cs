using System;

public class Solution {
    public int solution(int[] box, int n) {
        int answer = 0;
            //가로 
            answer += box[0] / n;
            //세로
            answer *= box[1] / n;
            //높이
            answer *= box[2] / n;
        return answer;
    }
}