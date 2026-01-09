using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int k, int[] tangerine) {
        Dictionary<int,int> dict = new Dictionary<int,int>(); //딕셔너리 생성
        
        for(int i = 0; i < tangerine.Length; i++)
        {
            if(dict.ContainsKey(tangerine[i]))
                dict[tangerine[i]] ++;
            else
                dict[tangerine[i]] = 1;
        }
        
        List<int> tangerList = new List<int>();
        
        foreach(var tanger in dict)
        {
            tangerList.Add(tanger.Value);
        }
        
        tangerList.Sort();
        tangerList.Reverse();
        
        int count = 0;
        int selectedCount = 0;
        
        for(int i = 0; i < tangerList.Count; i++)
        {
            count += tangerList[i];
            selectedCount ++;
            if(count >= k)
                break;
        }
        return selectedCount;
        
    }
}