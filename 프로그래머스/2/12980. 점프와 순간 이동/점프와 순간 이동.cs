using System;

class Solution
{
    public int solution(int n)
    {
        string str = Convert.ToString(n, 2);
        int count = 0;
        for(int i = 0; i < str.Length; i++)
        {
            if(str[i] == '1')
            {
                count ++;
            }
        }
        return count;
    }
}