using System;

public class Solution {
    public int solution(string num_str) {
        string[] strs = new string[num_str.Length];
        int[] ints = new int[num_str.Length];
        int answer = 0;
        for (int i = 0; i < num_str.Length; i++)
        {
            strs[i] += num_str[i];
        }

        for (int i = 0; i < strs.Length; i++)
        {
            ints[i] = int.Parse(strs[i]);
        }

        for (int i = 0; i < ints.Length; i++)
        {
            answer += ints[i];
        }
        return answer;
    }
}