using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int number1 = 0;
        
        if(denom1 > denom2)
        {
            number1 = LCM(denom2,denom1);
        }
        else 
        {
            number1 = LCM(denom1,denom2);
        } 
        numer1 = (number1 / denom1) * numer1;
        numer2 = (number1 / denom2) * numer2;
        int number2 = numer1 + numer2;
        int number3 = GCD(number1, number2);
        //만약 둘이 최대 공약수가 있으면 최대공약수로 나누기
        if (number3 != 0)
        {
            number1 = number1 / number3;
            number2 = number2 / number3;
        }
        else
        {
            
        }

        int[] answer = new int[] {number2,number1};

        return answer;
    }
        public int GCD(int a, int b)
        {               
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }   
            return a; 
        }
        public int LCM(int a, int b)
        {
            return (a * b)/GCD(a,b);
        }
}