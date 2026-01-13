public class Solution {
    public bool solution(int x) {
        
        int orig = x;
        int sum = 0;
        
        while (x > 0)
        {
            int num = x % 10;
            sum += num;
            x /= 10;
        }
        
        return orig % sum == 0;
    }
}