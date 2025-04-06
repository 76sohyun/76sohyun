using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        
        
         for (int i = 0; i < db.GetLength(0); i++)
            {
                    //아디 일치
                    if (db[i, 0] == id_pw[0])
                    {
                        //비번도 일치
                        if (db[i, 1] == id_pw[1])
                        {
                            return "login";
                            
                        }
                        //비번이 틀리면
                        else
                        {
                            return "wrong pw";
                            
                        }
                    }
            }
        
        return "fail";
    }
}