using System;

public class Solution {
    public string solution(string my_string) {
        string answer = " ";
        char[] array = my_string.ToCharArray();
        Array.Reverse(array);

        for(int i = 0; i < array.Length; i++)
        {
         answer += array[i];
        }
        answer = string.Concat(array);
        return answer;
    }
}