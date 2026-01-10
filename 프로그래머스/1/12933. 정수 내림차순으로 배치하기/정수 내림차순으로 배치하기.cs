using System;
public class Solution {
    public long solution(long n) {
        
        char[] arr = n.ToString().ToCharArray();
        
        Array.Sort(arr);
        Array.Reverse(arr);
        
        return Convert.ToInt64(string.Join("", arr));
    }
}