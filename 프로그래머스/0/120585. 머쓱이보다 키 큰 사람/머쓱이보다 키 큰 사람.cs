using System;

public class Solution {
    public int solution(int[] array, int height) {
        int answer = 0;

        Array.Sort(array);

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] > height)
            {
                answer += 1;
            }
        }
        return answer;
    }
}