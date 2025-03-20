using System;

public class Solution {
    public int solution(int n) {
        int lcm = LCM(6,n);
        return lcm/6;
    }
    public int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a%b;
                a = temp;
            }
            return a;
        }
        
        public int LCM(int a, int b)
        {
            return (a * b)/GCD(a,b);
        }
}