public class Solution {
    public string solution(string s) {
        string[] str = s.Split(' ');
        int min = int.Parse(str[0]);
        int max = int.Parse(str[0]);
        
        for(int i = 1; i < str.Length; i++)
        {
            int num = int.Parse(str[i]);
            if(num < min)
                min = num;
            if(num > max)
                max = num;
        }
        return min + " " + max;
    }
}