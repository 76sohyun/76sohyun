public class Solution {
    public long solution(int n) {
        if(n <= 2) return n;
        
        long one = 1;
        long two = 2;
        long current = 0;
        
        for(int i = 3; i <= n; i++)
        {
            current = (one + two) % 1234567;
            
            one = two;
            two = current;
        }
        return current;
    }
}