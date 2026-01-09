using System;
public class Solution {
    public string solution(string s) {
        string[] arr = s.Split(' '); //문자열 배열 만들어주고
        
        for(int i = 0; i < arr.Length; i++)
        {
            string str = arr[i].ToLower();
            if(str == "") continue;
            if(!char.IsDigit(str[0])) //만약 첫글자가 숫자가 아니면
            {
                str = str[0].ToString().ToUpper() + str.Substring(1);
            }
            arr[i] = str;
        }
        return string.Join(" ", arr);
        
    }
}