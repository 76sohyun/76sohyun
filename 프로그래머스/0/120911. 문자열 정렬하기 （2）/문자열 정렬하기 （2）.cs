using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        answer = my_string.ToLower();
        char[] array = answer.ToCharArray();
        Array.Sort(array);
        string result = new string(array);
        return result;
    }
}