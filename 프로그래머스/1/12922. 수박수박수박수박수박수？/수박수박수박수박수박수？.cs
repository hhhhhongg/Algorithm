using System.Collections.Generic;
using System;
public class Solution {
    public string solution(int n) {
        string answer = "";
        
        List<char> list = new List<char>();
        
        for(int i = 0; i < n ; i++)
        {
            if(i == 0 || i % 2 == 0)
            {
                list.Add('수');
            }
            else
            {
                list.Add('박');
            }
        }
        
        answer = String.Join("", list.ToArray());
        return answer;
    }
}