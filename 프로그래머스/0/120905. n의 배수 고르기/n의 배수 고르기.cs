using System;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        int count = 0;
        int[] answer = new int[numlist.Length];


        for (int i = 0; i < numlist.Length; i++)
        {
            if (numlist[i] % n == 0)
            {

             answer[count++] = numlist[i];
            }

        }
        int[] result = new int[count];

        for (int i = 0; i < count; i++)
        {
            result[i] = answer[i];
        }

        return result;
    }
}