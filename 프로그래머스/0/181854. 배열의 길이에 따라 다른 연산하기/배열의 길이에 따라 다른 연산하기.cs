using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int[] answer = new int[arr.Length];
        if(arr.Length % 2 != 0)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(i == 0 || i % 2 == 0)
                {
                    arr[i] += n;
                }
            }
        }
        else
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(i % 2 != 0)
                {
                    arr[i] += n;
                }
            }
        }
        
        for(int i = 0; i < arr.Length; i++)
        {
            answer[i] = arr[i];
        }
        return answer;
    }
}