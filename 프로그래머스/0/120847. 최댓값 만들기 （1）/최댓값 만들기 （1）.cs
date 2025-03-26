using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 1;

        Array.Sort(numbers);

        for (int i = numbers.Length - 1; i > numbers.Length-3; i--)
        {
            answer = answer * numbers[i];
        }
        return answer;
    }
}