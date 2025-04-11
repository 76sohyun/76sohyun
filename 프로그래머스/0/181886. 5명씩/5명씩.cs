using System;

public class Solution {
    public string[] solution(string[] names) {
        int a = 0;
            if (names.Length == 5)
            {
                a = 1;
            }
            else if (names.Length % 5 == 0)
            {
                a = names.Length/5;
            }
            else
            {
                a = names.Length/5 +1;
            }
            string[] answer = new string[a];
            int j = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (i == 0 || i % 5 == 0)
                {
                    answer[j] = names[i];
                    j++;
                }
            }
        return answer;
    }
}