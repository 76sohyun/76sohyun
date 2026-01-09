using System;

class Solution 
{
    public int solution(int n) 
   {
        int answer = 0;
        int count = 0; //1의 수를 세야함
        string Num = Convert.ToString(n, 2); //n의 이진 변환
        
        for(int i = 0; i < Num.Length; i++)
        {
            if(Num[i] == '1')
                count++;
        }
        
        while(true)
        {
            n++;
            int count2 = 0;
            string Num2 = Convert.ToString(n,2);
            
            for(int i = 0; i < Num2.Length; i++)
            {
                if(Num2[i] == '1')
                    count2++;
            }
            if(count == count2) break;
        }
        answer = n;
        return answer;
    }
}