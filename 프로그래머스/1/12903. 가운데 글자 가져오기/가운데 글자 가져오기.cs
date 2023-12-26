using System.Collections.Generic;
using System;

public class Solution {
    public string solution(string s)
    {
        string answer = "";
        List<char> list = new List<char>();
        char[] arr = s.ToCharArray();

        if (arr.Length % 2 == 0)
        {
            list.Add(arr[(arr.Length) / 2 - 1]);
            list.Add(arr[(arr.Length) / 2]);
        }
        else
        {
            list.Add(arr[(arr.Length - 1) / 2]);
        }

        answer = String.Join("", list.ToArray());

        return answer;
    }
}