using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] sortArray = new int[array.Length];
        int[] answer = new int[2];
        int index = 0;

        foreach (int i in array)
        {
            sortArray[index] = i;
            index++;
        }
        Array.Sort(sortArray);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == sortArray[array.Length- 1])
            {
                answer[0] = sortArray[array.Length- 1];
                answer[1] = i;
            }
        }
        return answer;
    }
}