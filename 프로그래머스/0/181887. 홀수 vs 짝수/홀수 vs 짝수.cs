using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
            int result = 0;

            for (int i = 0; i < num_list.Length; i++)
            {
                if (i % 2 == 0)
                {
                    answer += num_list[i];
                }
                else
                {
                    result += num_list[i];
                }
            }

            if (answer > result)
            {
                return answer;
            }
            else
            {
                return result;
            }
    }
}