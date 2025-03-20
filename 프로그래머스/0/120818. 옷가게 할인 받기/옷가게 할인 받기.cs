using System;

public class Solution {
    public double solution(double price) {
        
        double answer = 0;
        
        if (price >= 100000 && price < 300000)
        {
            answer = price - (price * 0.05);
        }
        else if (price >= 300000 && 500000 > price)
        {
            answer = price - (price * 0.1);
        }
        else if (price >= 500000 && price <= 1000000)
        {
            answer = price - (price * 0.2);
        }
        else
        {
            answer = price;
        }
                return (int)answer;
    }
}