using System;

public class Solution {
    public int[] solution(int money) {
        int count = 0;
        for (int i = 1; money >= 5500; i++)
        {
            money = money - 5500;
            count = i;
        }

        int[] answer = new int[2] { count, money };
        return answer;
    }
}