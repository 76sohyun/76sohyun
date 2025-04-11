using System;

public class Solution {
    public int solution(int hp) {
            int answer = 0;
            int ant = 0;

            if (hp % 5 == 0)
            {
                answer += hp / 5;
            }
            else
            {
                answer += hp / 5;
                ant = hp % 5;
                if (ant % 3 == 0)
                {
                    answer += ant / 3;
                }
                else
                {
                    answer += ant / 3;
                    answer += ant % 3;
                }
            }
        return answer;
    }
}